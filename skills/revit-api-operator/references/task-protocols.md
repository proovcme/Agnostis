# Generic Revit task protocols

These protocols describe evidence order. Category and discipline names always come from live Revit results.

## Answer about the open document

1. Read `document` for active context.
2. Read the smallest relevant live catalog or element set.
3. Page until complete or until the exact answer is proven.
4. Calculate only from typed returned values; state scope and unit.
5. Finish with `finish_revit_response`.

## Count, sum or group elements

1. Discover exact categories/systems/parameters instead of translating the user's wording into guessed Revit names.
2. Discover the exact parameter identity, scope, storage type and unit when the metric is not intrinsic to the capability.
3. Call the typed aggregate/calculator capability with the model-selected field, operation, filters and output unit.
4. If the capability is absent, return `MISSING: aggregate capability`; do not sum formatted element rows in the model.
5. Preserve null/missing coverage separately; do not silently treat it as zero.
6. Report scope, filters, matched count, covered count, metric, unit and calculation provenance.

## Select elements

1. Discover exact live identities needed for the query.
2. Build one universal query over `model`, `active_view` or `selection`.
3. Call `prepare_revit_action(operation=select_elements)`.
4. Report the actual resulting selection, not the intended filter.

## Create a schedule

1. Treat the user's object word only as intent. If no exact category identity has already been returned in this conversation, call `query_revit(mode=categories)` without a guessed category and read the complete catalog.
2. Choose and preserve one exact category only from that live result. Never construct a localized category, English category, `BuiltInCategory` name or id from memory.
3. Inspect the current `query_revit.mode` enum. If `schedule_fields` is absent, immediately call `finish_revit_response` with `MISSING: schedule_fields capability`. Do not call `elements` or `parameters`: neither can prove which fields the schedule definition accepts.
4. Otherwise request the live `schedule_fields` catalog for that category.
5. Choose fields, grouping, filtering and itemization only from that catalog and the user's intent.
6. If the catalog is incomplete, return `MISSING`; never use element ids, generic property names or guessed parameter names as schedule fields.
7. Submit `create_schedule`, preview targets, request confirmation according to the safety guard, then report the actual created view and fields.

## Read or change a parameter

1. Discover the exact parameter identity on representative matching elements and their types.
2. Preserve instance/type scope, storage type, units/spec and read-only state.
3. For reads, page matching elements and distinguish missing from empty.
4. For writes, state type-wide impact when scope is `type`, submit `set_parameter`, preview, confirm and transact.
5. Report actual changed ids and rejected/missing/read-only targets.

## Revit API help

1. Read active Revit version when the question concerns the installed environment.
2. Search `ARTEL_Index` by exact type/member/task and version.
3. Cite the exact source/member and distinguish verified signature from inference.
4. Return `MISSING` when the indexed corpus does not prove the requested symbol or version behavior.

## Unsupported action

1. Do not simulate execution in prose.
2. State the missing generic capability, such as `schedule_fields`, `create_view`, `place_family_instance`, `bind_parameter`, or `export_ifc`.
3. Keep the user's requested operation intact for future tool expansion; do not redirect it to a vaguely similar allowlisted action.
