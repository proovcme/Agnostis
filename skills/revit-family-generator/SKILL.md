---
name: revit-family-generator
description: Turn text, technical requirements, DOCX/XLSX/PDF files, URLs and images into evidence-backed Revit 2024/2025 family specifications for ARTEL. Use when the family generator must choose category, template, parameters, types, materials, geometry and acceptance checks while preserving model ownership of professional decisions and returning the artel.family_spec.v1 machine-readable contract.
---

# Revit Family Generator

Build a source-grounded family specification that deterministic Revit code can validate and execute. The model owns every professional choice; code may validate schema, references, units, provenance and confirmation hashes, but must never add or replace category, parameters, types, geometry, features or materials.

## Workflow

1. Parse the user's description and all attached text, technical documents, links and images. Record the source name and keep explicit values distinct from interpretation.
2. Read typed active-Revit context when available: Revit version, document kind, active view, selected elements, categories, family/type inventory and units.
3. Retrieve only relevant ARTEL_Index evidence:
   - `FAMILY_GUIDE` for family/category/template and modeling practice.
   - `FOP_PROFILE` for exact shared parameter names, GUIDs, data types and instance/type rules.
   - `REVIT_API_REFERENCE`, `REVIT_API_SYMBOL_MAP` or `SDK_DOC` for exact Revit API symbols and version behavior.
   - `LEARNING_CASE` only as an example, never as authority over the current requirements.
4. Choose the category, template, parameters, type strategy, geometry, features, materials and acceptance checks from the request plus evidence. Keep those choices model-owned.
5. Put every unresolved fact in `missing` and every question that prevents safe construction in `blocking_questions`. Never guess a GUID, template, API symbol, dimension, material or source requirement.
6. Self-check against [the family specification contract](references/family-spec-contract.md). Return only one JSON object using exact snake_case keys.

## Evidence rules

- User-provided requirements and live Revit context take precedence for the current artifact.
- A parameter `shared_guid` is allowed only when an exact GUID is present in FOP evidence. Otherwise use `null` and report the gap when sharing is required.
- Skill text defines procedure only. It is not evidence for a Revit API signature, GUID, template availability or project fact.
- Every provenance item must identify a concrete supplied source, live-context field or LES evidence reference.
- If evidence conflicts, preserve the conflict in `missing`/`blocking_questions`; do not silently resolve it in code.

## Model ownership boundary

- A later model pass may only normalize the first model draft into the contract without changing its professional choices or adding facts.
- Deterministic code may reject malformed or unsafe output and may compile an accepted specification into allowlisted Revit operations.
- Deterministic code must not infer missing dimensions, substitute parameters, choose a category/template, invent geometry or improve the model's design.
- When required fields remain unknown, return a blocked specification. A plausible invented family is a failure.

## Completion gate

Return a compilable specification only when the contract is structurally valid, required values are evidence-backed, `blocking_questions` is empty and the proposed family is within Revit 2024/2025 capabilities known from evidence. Otherwise return the specification with explicit gaps and no executable operations.
