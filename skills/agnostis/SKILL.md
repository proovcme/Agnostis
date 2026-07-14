---
name: agnostis
description: "Work on the standalone ARTEL repository: Revit 2024/2025 add-in, local backend, Revit MCP capability layer, family generator, BIM agent, ARTEL Index, installer, and optional LES integration. Use for architecture, implementation, validation, documentation, release preparation, or repository synchronization involving ARTEL/Agnostis."
---

# ARTEL repository operator

Use the repository root containing this skill as the canonical ARTEL source. The public remote is `https://github.com/proovcme/Agnostis`.

Read `AGENTS.md`, then `README.md`, `docs/ARCHITECTURE.md`, `docs/MCP_CONTRACT.md`, `docs/LES_INTEGRATION.md`, `docs/DEVELOPMENT.md`, and `docs/STATUS.md`.

## Boundaries

- Keep ARTEL standalone. LES is optional retrieval/export enrichment.
- Keep the Revit add-in as the API-thread executor through `ExternalEvent`.
- Put reasoning discipline in `skills/revit-api-operator`; expose machine capabilities through MCP.
- Do not add category-specific intent code, generated C#, UI automation, or model arithmetic over display values.
- Do not touch Windows/Revit/Legion or LES runtime without explicit user permission.
- Do not commit binaries, build output, installer payload, logs or state.

## Workflow

1. Identify whether the change belongs to skill, MCP contract, Revit session bridge, executor, generator, knowledge, UI, installer or LES adapter.
2. Read only the corresponding source and canonical doc.
3. Preserve model ownership of intent and professional selection.
4. Validate with the narrowest relevant check.
5. For Revit behavior, distinguish compile/synthetic checks from the required live installed hand-test.
6. Update docs/status/version with behavior changes.

## Checks

```bash
dotnet build backend/Agnostis.Api/Agnostis.Api.csproj --configuration Release
node --check app/app.js
git diff --check
```

Windows add-in/installer/live gates require explicit authorization and follow `docs/DEVELOPMENT.md`.
