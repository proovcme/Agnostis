# ARTEL Revit API Reference

Product: ARTEL
Document type: REVIT_API_REFERENCE
Purpose: operational Revit API basis for automated RFA/template inspection,
family creation, validation and catalog JSON extraction.

## Sources

- Autodesk Revit API Developer Guide, Family Documents:
  https://help.autodesk.com/cloudhelp/2018/CHS/Revit-API/files/GUID-DC143EB8-43CB-48AB-938E-7ADE3A9D2E63.htm
- Autodesk Revit API Developer Guide, Managing family types and parameters:
  https://help.autodesk.com/cloudhelp/2024/ENU/Revit-API/files/Revit_API_Developers_Guide/Revit_Geometric_Elements/Family_Documents/Revit_API_Revit_API_Developers_Guide_Revit_Geometric_Elements_Family_Documents_Managing_family_types_and_parameters_html.html
- RVTDocs Revit API 2026:
  https://rvtdocs.com/2026/
- RevitAPIDocs Revit API 2026:
  https://www.revitapidocs.com/2026/

## Retrieval Hints

Revit API ARTEL RFA FamilyManager FamilyParameter FamilyType FamilySymbol
FamilyInstance FamilyCategory OwnerFamily IsFamilyDocument NewFamilyDocument
OpenDocumentFile EditFamily LoadFamily IFamilyLoadOptions FilteredElementCollector
Transaction TransactionGroup SubTransaction ExternalCommandData UIApplication
UIDocument Document Element Parameter StorageType BuiltInParameter
BuiltInCategory shared parameters ExternalDefinition GUID ConnectorManager
MEPModel Connector subcategories Materials template extractor JSON.

## LES Usage Contract

Use this source when ARTEL needs to write, review or debug:

- Revit add-in commands;
- batch extraction of `.rfa` and `.rft` metadata;
- family/template JSON catalogs;
- family validation reports;
- FOP/shared-parameter checks;
- Revit API implementation plans for Windows/Legion.

Pair with `FAMILY_GUIDE` for modeling/quality methodology and with
`FOP_PROFILE` for exact shared-parameter names, GUIDs and datatypes.

## Runtime Boundary

Native Revit API extraction normally requires Autodesk Revit on Windows.
Direct `.rfa`/`.rft` introspection without Revit is limited because family
files are proprietary Revit documents, not an open JSON/SQLite format.
Acceptable automation paths:

1. Local Revit add-in or external command on Legion.
2. RevitCoreConsole where the target workflow is supported.
3. Autodesk Platform Services Design Automation for Revit.
4. No-Revit filesystem manifest only: path, file name, size, modified time,
   template folder and naming signals.

## Entry Points

### External Command

`IExternalCommand.Execute(ExternalCommandData commandData, ref string message,
ElementSet elements)` is the common add-in command entry point.

Access chain:

- `commandData.Application` -> `UIApplication`;
- `UIApplication.ActiveUIDocument` -> `UIDocument`;
- `UIDocument.Document` -> active `Document`;
- `UIApplication.Application` -> Revit application object for opening or
  creating documents.

ARTEL rule: Revit add-in calls ARTEL backend. The backend calls LES. Revit
should not call OpenRouter or LES directly in MVP.

### Document Opening And Creation

For existing `.rfa` files use application-level document opening, then close
the document after extraction.

For new family creation use `Application.NewFamilyDocument(templatePath)` with
an explicit `.rft` template. Record the template path in task/catalog JSON.

For an already loaded project family use `Document.EditFamily(family)` to get
a family document, then `LoadFamily()` to reload after edits when needed.

Always check `Document.IsFamilyDocument` before using family-only APIs.

## Family Document Model

`Document.OwnerFamily` represents the family in an open family document.
`OwnerFamily.FamilyCategory` gives the Revit category that controls behavior,
scheduling, graphics and available built-in parameters.

Important extract fields:

- `family_name`;
- `family_category`;
- `category_id`;
- `is_work_plane_based`;
- `template_path`;
- `family_symbols`;
- `family_types`;
- `family_parameters`;
- `nested_family_symbols`;
- `subcategories`;
- `materials`;
- `connectors`;
- `warnings`.

## FamilyManager

`Document.FamilyManager` is the central API for family types and family
parameters.

Use it to inspect:

- `FamilyManager.Types`;
- `FamilyManager.CurrentType`;
- `FamilyManager.Parameters` or `GetParameters()`;
- parameter formula;
- parameter group;
- type-vs-instance behavior;
- shared parameter status.

Use it to modify:

- `NewType(typeName)`;
- `DeleteCurrentType()`;
- `Set(FamilyParameter, value)`;
- add/remove family parameters;
- add/remove shared parameters;
- formulas and ordering.

ARTEL rule: any edit must be inside a transaction and followed by a flex/load
validation step before the family is accepted.

## Parameters

Parameter extraction must preserve both API identity and human labels.

For ordinary element parameters:

- `Parameter.Definition.Name`;
- `Parameter.StorageType`;
- `Parameter.AsString()`;
- `Parameter.AsValueString()`;
- `Parameter.AsDouble()`;
- `Parameter.AsInteger()`;
- `Parameter.AsElementId()`;
- `Parameter.IsReadOnly`;
- built-in parameter id when present.

For family parameters:

- name;
- datatype/spec;
- parameter group;
- type or instance flag;
- formula;
- reporting flag;
- shared flag;
- GUID for shared parameters when accessible.

ARTEL rule: compare required shared parameters against indexed `FOP_PROFILE`.
The validation report must list missing, wrong-type and mismatched-GUID
parameters separately.

## Collectors

`FilteredElementCollector` is the primary way to enumerate elements in a
Revit document.

Efficient collector rules:

- use `OfClass()` or `OfCategory()` first;
- use `WhereElementIsNotElementType()` for instances;
- use `WhereElementIsElementType()` for types;
- use `ToElementIds()` when only ids are needed;
- use `FirstElement()` when only one element is needed;
- avoid materializing every element when count or ids are enough.

Common ARTEL collectors:

- `FamilySymbol` for loaded/nested symbols;
- `FamilyInstance` for instances in test projects;
- `Material` for material catalog;
- `GraphicsStyle` for subcategories;
- `FillPatternElement` and line styles for graphics checks;
- MEP connector-bearing instances for connector validation.

## Transactions

Revit model changes must run inside `Transaction`.

Patterns:

- `Transaction` for a single edit;
- `SubTransaction` for scoped rollback inside a larger edit;
- `TransactionGroup` for multi-step operations and one undo item;
- rollback on validation failure;
- never leave an open transaction after an exception.

Extraction-only commands should not start transactions unless they need to
create a temporary type, set temporary parameter values, or run a flex test.

## Loading And Reloading Families

When editing a project family:

1. Get `Family` from `FamilySymbol.Family`.
2. Open family document via `Document.EditFamily(family)`.
3. Edit inside a transaction.
4. Use `LoadFamily(projectDocument, IFamilyLoadOptions)` to reload.
5. Close the family document.

`IFamilyLoadOptions` should make overwrite behavior explicit. ARTEL should
record whether parameter values are overwritten during validation.

## MEP Connectors

MEP families may expose connectors through `MEPModel.ConnectorManager` or a
connector manager on the relevant instance/type API surface.

Extract:

- connector domain;
- shape;
- direction;
- system type;
- diameter/height/width;
- origin and coordinate system;
- flow-related settings where applicable.

ARTEL rule: connector validation is required for families expected to connect
to ducts, pipes, cable trays, conduits or equipment systems.

## Template JSON Extractor Shape

A Revit-backed extractor should emit one JSON object per `.rfa` or `.rft`:

```json
{
  "schema": "artel.revit_family_catalog.v1",
  "source_path": "C:/ProgramData/Autodesk/RVT 2026/Family Templates/...",
  "file_kind": "rft",
  "revit_version": "2026",
  "family_name": "Metric Generic Model",
  "category": "Generic Models",
  "template_path": "...",
  "parameters": [
    {
      "name": "ADSK_Наименование",
      "storage_type": "String",
      "is_shared": true,
      "guid": "..."
    }
  ],
  "types": [],
  "subcategories": [],
  "materials": [],
  "connectors": [],
  "warnings": []
}
```

JSON should be stable and diff-friendly:

- sort arrays by name where possible;
- store raw Revit ids only as diagnostics;
- keep user-visible names;
- normalize units deliberately;
- preserve source file path and modified timestamp.

## Batch Extraction Algorithm

1. Build a filesystem manifest of `.rfa` and `.rft` roots.
2. Start Revit/API host once per batch, not once per file.
3. Open each document read-only where possible.
4. Detect `IsFamilyDocument`; skip or mark unsupported files.
5. Extract category, types, parameters, symbols, materials, subcategories and
   connectors.
6. Write one JSON file per source plus a run summary.
7. Close every document without saving unless the task explicitly edits.
8. Import JSON summaries into LES as ARTEL knowledge and accepted catalog
   evidence.

## Quality Checks For API Output

Reject or flag extractor output when:

- file failed to open;
- document is not a family document;
- category is missing or unexpected;
- required FOP parameters are absent;
- shared parameter GUID differs from FOP;
- no type exists where type catalog is not used;
- connector family has no connectors;
- extraction emitted unstable ordering;
- warning list contains load/blocking failures.

## Implementation Notes For ARTEL

- Keep extraction separate from generation.
- Keep validation reports as first-class artifacts.
- Do not hide Revit API errors behind generic AI text.
- Preserve source file paths for traceability.
- Convert successful extractor output into `LEARNING_CASE` or catalog JSON
  only after review.
- Use LES retrieval before drafting code: `REVIT_API_REFERENCE` for API,
  `FAMILY_GUIDE` for family methodology, `FOP_PROFILE` for parameters.
