# ARTEL conformance kit

Versioned inputs and expected `artel.family_action_plan.v1` outputs for the
standalone family generator.

The fixtures cover FOP resolution and the current geometry archetypes:

- `rect_cabinet`;
- `cylinder_revolve`;
- `bar_profile`.

`inputs/` contains approved specifications, geometry recipes and a minimal
shared-parameter file. `expected/` contains the corresponding action plans.

The C# compiler in `backend/Agnostis.Api` is the product implementation. Any
future fixture generator must live in this repository; LES is not the oracle
and is not required to validate these contracts.

Changing compiler behavior requires updating or adding a fixture and checking
the resulting plan against the schema and the Revit executor. JSON equality is
only a deterministic contract check; it does not replace a live Revit gate.
