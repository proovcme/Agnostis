# ARTEL family specification contract

Return one JSON object with these exact keys:

```json
{
  "family_name": "string or MISSING",
  "category": "string or MISSING",
  "template": "string or MISSING",
  "parameters": [{
    "name": "string",
    "data_type": "Text|Length|Material|Number",
    "group": "string",
    "is_instance": false,
    "is_required": true,
    "shared_guid": null
  }],
  "types": [{"name": "string", "values": {}}],
  "materials": ["string"],
  "geometry": {
    "shape": "string",
    "width_parameter": "string",
    "depth_parameter": "string",
    "height_parameter": "string",
    "features": []
  },
  "acceptance_checklist": ["string"],
  "missing": ["string"],
  "blocking_questions": ["string"],
  "provenance": ["string or evidence reference"]
}
```

Do not emit camelCase aliases or explanatory prose around the object. Use `MISSING`, `null` and the two gap arrays rather than guessed values. Parameter names referenced by geometry and type values must exist in `parameters`. A shared GUID must be an exact evidence value. Do not add the top-level `schema`, source metadata, status, operation plan or confirmation hash; deterministic orchestration adds those fields without changing professional decisions.
