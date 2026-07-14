# Revit agent contract

## Evidence routing

| Claim or operation | Required evidence |
|---|---|
| Active document/view/version | complete live `document` result |
| Category exists or is absent | complete live `categories` result |
| Element count/properties | complete matching live `elements` pages |
| Sum/min/max/average/grouped quantity | exact live field identity plus typed `aggregate` result with unit and coverage |
| Instance/type parameter read or write | live parameter identity, scope, storage type and mutability |
| Selection result | resolved live query plus actual selected ids |
| Regular schedule creation | exact category plus live `schedule_fields` catalog for that category |
| Revit API symbol/signature/version | exact-version `REVIT_API_SDK_DOC` source |
| ARTEL family/FOP rule | `ARTEL` source ref and profile/revision |

If the required evidence surface is unavailable, return `MISSING` with the missing capability. Related evidence is not a substitute.

For `aggregate`, the model owns category, field, filter, operation and output-unit selection. Deterministic code owns storage-value reading, unit conversion, arithmetic, null coverage and provenance. Model-side arithmetic over formatted element values is not an aggregate result.

Check the action catalog before model data collection. An API reference describing placement, view creation, deletion, export, open/save/synchronize or purge is not an executable capability. If the matching typed action is absent, return `MISSING` without collecting unrelated categories or parameters.

## Plan shape

```json
{
  "schema": "artel.revit_operator_plan.v3",
  "status": "ready|missing|blocked",
  "revit_version": "2024|2025",
  "summary": "short user-facing intent",
  "operations": [
    {
      "op": "allowlisted_operation",
      "target_ids": [],
      "arguments": {
        "query": {
          "scope": "model|active_view|selection",
          "categories": ["exact live category"],
          "family": "optional exact live family",
          "type": "optional exact live type",
          "system": "optional exact live system",
          "parameter_filters": [
            {
              "parameter": "exact live identity or name",
              "scope": "instance|type",
              "operator": "typed operator",
              "value": "typed/display value with explicit semantics"
            }
          ]
        },
        "fields": ["exact live schedulable field"],
        "group_by": ["field already present in fields"],
        "itemize_every_instance": false
      },
      "evidence_refs": [],
      "transaction": "transaction name or selection only",
      "expected_result": "observable result",
      "rollback": "transaction rollback or selection recovery"
    }
  ],
  "missing": [],
  "risks": []
}
```

The backend creates the canonical confirmation hash. Do not invent it.

## Terminal protocol

End every agent turn with exactly one explicit tool decision:

- `query_revit` to obtain more active-document evidence;
- `search_artel_index` to obtain exact API/reference evidence;
- `prepare_revit_action` to submit an evidence-complete typed action;
- `finish_revit_response` to return a final read-only answer.

Ordinary assistant prose is not terminal. If action validation returns `missing` or `blocked`, use the message as evidence, obtain the missing live capability, repair the arguments, and call again. Never convert a failed action into a success explanation.

## Execution contract

Before execution, resolve the universal query and return `artel.revit_operator_preview.v1` with target count, sample ids and fingerprint. Execute the unchanged plan only when confirmation and the current target fingerprint satisfy the safety mode.

Return `artel.revit_operator_result.v1` containing per-operation status, actual affected element ids, transaction outcome, warnings, safety-bypass state and report path. Do not claim success from a prepared plan or preview.

The model selects intent, queries, fields and actions. Deterministic code may validate identities, schemas, current state, units, limits, transactions and provenance; it must not choose a professional replacement.
