# ARTEL Revit Family Requirements And Quality Basis

Source title: Руководство по созданию семейств Autodesk Revit
Source URL: https://www.autodesk.com/akn-aknsite-article-attachments/1858ea62-e6ba-4782-a7d6-aca350219b7c.pdf
Source version: 1.02
Source year/place: Москва 2017
Product: ARTEL
Document type: FAMILY_GUIDE
Purpose: operational requirements for creating, reviewing and accepting Revit RFA families.

## Retrieval Hints

ARTEL Revit family requirements RFA качество семейства создание семейств
проверка семейств требования к семействам опорные плоскости каркас семейства
параметры типа параметры экземпляра общие параметры ФОП shared parameters
ADSK_Наименование ADSK_Обозначение ADSK_Код изделия типоразмер каталог
LOD уровень детализации подкатегории материалы формулы вложенные семейства
точка вставки точка расчета помещения technical description validation checklist.

## LES Usage Contract

Use this source when ARTEL needs to produce or review a Revit family task,
family specification, acceptance checklist, validation report, catalog card,
FOP/shared-parameter comparison, or quality explanation. Pair it with
`FOP_PROFILE` chunks for exact ADSK names and GUIDs.

## Requirements

### ARF-SCOPE-001 Family Purpose

A family must have a defined usage purpose, category, project stage, LOD
target, and expected schedule/tag behavior before modeling starts.
Evidence: task/specification states category, family name, use case, LOD,
discipline, required parameters and acceptance checks.

### ARF-TEMPLATE-001 Template And Category

A loadable family must start from the correct Revit family template and
category. The category controls behavior, available parameters, graphics,
scheduling and interaction with the project.
Evidence: selected `.rft` template and category are recorded in the task.

### ARF-SKELETON-001 Reference Skeleton

The family skeleton must be built with reference planes and reference lines
before detailed geometry. Parameters should drive the skeleton, and the
skeleton should drive geometry and symbolic graphics.
Evidence: key dimensions flex by moving reference planes/lines without
breaking constraints.

### ARF-ORIGIN-001 Insertion And Room Behavior

Origin, insertion point, host behavior and room calculation point must be
deliberate. Families that belong to rooms or room boundaries must be checked
for correct room association.
Evidence: loaded family inserts in the expected position and reports room
relation correctly where relevant.

### ARF-GEOM-001 Reasonable Geometry

Geometry must be sufficient for the task and not excessive. Avoid hidden
internals, unnecessary threads, small chamfers, over-detailed fittings and
manufacturing detail unless explicitly required.
Evidence: family file size and view behavior remain appropriate for project
use.

### ARF-DETAIL-001 Detail Levels

Low, medium and high detail levels must be controlled intentionally. Large
elements can appear broadly; small or detailed geometry should appear only
where it is useful.
Evidence: plan, section, elevation and 3D views display correctly at all
target detail levels.

### ARF-GRAPHICS-001 Symbolic Graphics

Plan symbols should use symbolic/detail/annotation graphics where that is
lighter and clearer than model geometry.
Evidence: plans are readable and do not rely on heavy 3D geometry for simple
symbols.

### ARF-SUBCATEGORY-001 Subcategories

Subcategories must be used deliberately so project teams can control object
graphics. Do not create random or duplicate subcategories.
Evidence: technical description lists subcategories and their intended use.

### ARF-PARAM-001 Parameter Intent

Separate type parameters, instance parameters, shared parameters and internal
family parameters. Family-only parameters are suitable for internal geometry
and graphics; shared parameters are required for schedules, tags and
cross-project exchange.
Evidence: parameter list marks type/instance behavior and shared/FOP status.

### ARF-FOP-001 Shared Parameter Profile

Required ADSK/shared parameters must be checked against the indexed FOP
profile before acceptance. Use `FOP_PROFILE` for exact GUID, datatype,
visibility and user-modifiable flags.
Evidence: validation report lists required ADSK parameters and whether each
parameter is present, correctly typed and populated.

### ARF-FORMULA-001 Formula Minimalism

Formulas, arrays and voids must be kept to the minimum needed for stable
behavior. Excessive formulas and arrays increase maintenance and performance
risk.
Evidence: parameter flex tests pass and formulas remain readable.

### ARF-NESTED-001 Nested Families

Nested families should be used only when a component is genuinely reusable or
must be counted/tagged independently. Large numbers of nested families are a
performance and maintainability risk.
Evidence: nested components have a documented reason.

### ARF-CATALOG-001 Type Catalogs

Families with many type sizes should use a type catalog instead of bloating
the family with embedded types.
Evidence: type catalog exists when the type set is large and loading only
needed types is expected.

### ARF-MATERIAL-001 Materials

Materials and material parameters must be intentional. When project teams
control appearance by category/subcategory, document that behavior instead of
hardcoding unnecessary materials.
Evidence: material behavior is described and schedule/tag needs are met.

### ARF-VALIDATION-001 Acceptance Testing

A family is not accepted until it opens, loads, flexes, displays, schedules
and tags correctly for the target workflow.
Evidence: validation report includes open/load test, parameter flex test,
view/detail test, schedule/tag/shared-parameter test and known limitations.

### ARF-DOC-001 Technical Description

Accepted families need a technical description: purpose, LOD, display
behavior, parameters, subcategories, type catalog behavior, usage notes and
known limitations.
Evidence: catalog card or technical description is attached to the accepted
learning case.

### ARF-VERSION-001 Change And Versioning

Family changes must preserve traceability: version, author/reviewer role,
reason for change, validation result and compatibility notes.
Evidence: catalog/learning case records version and acceptance notes.

## ARTEL Quality Checklist

- Correct template and category selected.
- Family purpose, LOD, discipline and project stage are explicit.
- Reference skeleton exists and flexes.
- Geometry is constrained to the skeleton.
- Detail levels and symbolic graphics are checked.
- Type and instance parameters are separated.
- Shared parameters are verified against FOP_PROFILE.
- Materials and subcategories are intentional.
- Type catalog is used for large type sets.
- Family opens, loads and inserts without blocking warnings.
- Tags and schedules return expected values.
- File size and nested/formula complexity are reasonable.
- Technical description and validation report are attached.

## Reject Patterns

- Unclear family category or wrong template.
- Geometry controlled by loose dimensions instead of a reference skeleton.
- Excessive high-detail geometry for ordinary project use.
- Heavy 3D geometry used for simple plan symbols.
- Missing shared parameters required by the task/FOP.
- Large embedded type list where a type catalog is expected.
- Unexplained nested families, voids, arrays or formulas.
- No parameter flex test.
- No schedule/tag validation.
- No technical description or acceptance notes.

## ARTEL Workflow

1. Read the task and retrieve `FAMILY_GUIDE` chunks for methodology.
2. Retrieve `FOP_PROFILE` chunks for exact shared parameter names and GUIDs.
3. Produce a family specification with template, category, LOD, geometry,
   parameters, validation checks and catalog metadata.
4. Validate the resulting RFA against this checklist.
5. Save accepted results as `LEARNING_CASE` so LES improves future work.
