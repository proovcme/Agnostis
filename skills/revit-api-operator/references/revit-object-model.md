# Revit object model for agent reasoning

Use this map to decide what must be discovered from the active Revit document. It is a conceptual guide, not evidence for an exact API signature.

## Document and UI state

- `Document` owns persistent model data. `UIDocument` owns UI state such as current selection.
- Active document, active view, current selection, linked documents and family documents are different contexts. Never silently widen one into another.
- Read Revit state and execute Revit API work on the valid API thread through `ExternalEvent`.
- A document mutation requires a transaction. A selection change does not mutate the document, but its actual selected ids must still be reported.

## Elements and identity

- An element instance has an `ElementId`; its type is another element reached through its type id.
- Category, family and type describe different levels. Category groups elements; family contains types; type carries type-level data; instance carries placement and instance-level data.
- Display names can be localized, empty or duplicated. Prefer tool-returned stable ids and explicit identity fields. Never manufacture ids from names.
- Linked-model elements need document/link identity in addition to an element id. If the tool contract lacks that identity, report `MISSING` rather than pretending they are host elements.

## Parameters

- A parameter belongs to an instance or type and has identity, definition, storage type, read-only state, value and possibly a unit/spec.
- Two parameters may share a displayed name. A name alone is insufficient when the tool exposes a stronger identity such as built-in id, shared-parameter GUID or parameter element id.
- Preserve `instance|type` scope. Never change a type parameter when the user selected instances unless the plan explicitly states the type-wide impact.
- Keep displayed text separate from storage values: `String`, `Integer`, `Double`, and `ElementId` need different comparisons and writes. Convert units only with Revit's unit/spec evidence.
- A missing or read-only parameter blocks that write. Do not select a similarly named replacement.

## Categories and collectors

- Use live category evidence from the active document. Localized display names and `BuiltInCategory` identifiers are not interchangeable.
- Query scope and filters define target elements. Use the same resolved query for preview and execution; any target change invalidates the preview.
- Prove absence only after the relevant paginated result is complete.

## Schedules

- A regular schedule is valid only for categories accepted by Revit for that schedule kind.
- Schedulable fields belong to the schedule definition for a specific category. They are not the same catalog as element properties or parameter display names.
- Before planning `create_schedule`, obtain the exact live schedulable-field catalog for the exact category. Use only returned field identities/names. If `query_revit` cannot expose that catalog, return `MISSING: schedule_fields capability`.
- Grouping, sorting, filtering and itemization refer to fields already added to the schedule. Quantity/count fields may be special schedule fields rather than ordinary element parameters.
- Schedule creation is a document mutation and must be validated, previewed and transacted.

## Geometry, quantities and systems

- Count, length, area and volume are different metrics. Use explicit typed quantities and units returned by Revit; never sum formatted strings.
- MEP system membership may be a typed relationship or parameter-derived value. Use the evidence exposed by the tool and preserve its source.
- Geometry may depend on view, phase, design option, level, host, link and element state. If those constraints matter but are not observable, report them as missing.

## Families

- A project document and family document have different APIs and transaction workflows.
- Family category, template, reference skeleton, types, parameters, formulas, materials, connectors and nested families are separate decisions.
- Use the dedicated family-generator workflow for new family specifications. Use this operator skill to inspect, validate, load or act only through available typed capabilities.
