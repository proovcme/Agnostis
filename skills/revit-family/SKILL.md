---
name: artel-revit-family
description: "Create, review and validate Autodesk Revit RFA families in standalone ARTEL, including requirements, templates, categories, FOP/shared parameters, geometry, types, connectors and quality gates."
---

# ARTEL Revit Family

## Evidence order

1. User attachments and explicit requirements.
2. Local `knowledge/ARTEL/` sources and `knowledge/ARTEL_DATASET.json`.
3. Exact Revit capabilities returned by the active add-in session.
4. Optional LES retrieval when the integration is available.
5. `references/family-quality-requirements.md` as the offline minimum.

Never treat documentation or an index chunk as evidence about the active Revit document.

## Workflow

1. Normalize the input: text, technical assignment, datasheet, file, URL or image.
2. Identify category, template, discipline, purpose, stage, LOD, host behavior, tags and schedules.
3. Resolve parameters by exact name, GUID, datatype, type/instance scope and FOP source.
4. Describe the reference skeleton, constraints, geometry, subcategories, materials, detail levels and connectors.
5. Define types and decide whether a type catalog is required.
6. Produce a reviewable specification before generating or changing an RFA.
7. Compile the approved specification into `artel.family_action_plan.v1`.
8. Execute only through `ARTEL.Revit.FamilyFactory` on the Revit API thread.
9. Validate open/load/insert/flex/tag/schedule behavior and return evidence from the actual document.

## Required output

- source requirements with unresolved items;
- category and template;
- parameters and FOP mapping;
- types and values;
- geometry and reference skeleton;
- materials, subcategories, symbolic graphics and connectors;
- generation plan;
- validation checklist;
- blockers marked `MISSING` rather than guessed.

## Quality gates

- Correct template and category.
- Geometry is constrained to a reference skeleton.
- Type and instance parameters are intentionally separated.
- Shared parameters match FOP by name, GUID and datatype.
- Types flex without broken constraints.
- Family loads, inserts, tags and schedules correctly.
- Geometry, nesting, arrays, voids and formulas are proportionate.
- The validation report identifies the Revit version and actual document result.

## Local checks

From the repository root:

```bash
dotnet build backend/Agnostis.Api/Agnostis.Api.csproj --configuration Release
node --check app/app.js
```

On an explicitly authorized Windows/Revit host:

```powershell
.\build-family-factory-revit.ps1 -RevitVersions 2024,2025
.\run-family-factory-revit-generate.ps1 -InputPath C:\path\request.json
```

Do not contact a remote Revit host merely to validate documentation or source changes.
