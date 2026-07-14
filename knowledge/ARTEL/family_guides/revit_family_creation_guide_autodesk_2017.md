# ARTEL Revit Family Guide

Source title: Руководство по созданию семейств Autodesk Revit
Source URL: https://www.autodesk.com/akn-aknsite-article-attachments/1858ea62-e6ba-4782-a7d6-aca350219b7c.pdf
Publisher/source: Autodesk attachment
Version: 1.02
Year/place: Москва 2017
Product: ARTEL
Document type: FAMILY_GUIDE
Pages: 45

## Retrieval Hints

ARTEL Revit RFA family guide Autodesk создание семейств требования к семействам
процедура создания семейств планирование разработка семейств опорные плоскости
параметры общие параметры ADSK_Наименование ADSK_Обозначение типоразмеры каталог
LOD графика геометрия подкатегории проверка семейств версионность лучшие практики.

## Scope

This guide is a methodology source for ARTEL family development. It should be
used to answer questions about planning, creating, validating and maintaining
Revit loadable families. It is not a FOP/shared-parameter GUID profile and is
not an accepted family learning case.

## Table Of Contents Summary

- Scope, terms and family definitions.
- General principles for Revit family development.
- Requirements for families.
- Family creation procedure.
- Planning and analysis before development.
- Creation rules for templates, reference planes, geometry, parameters,
  subcategories, graphics, materials, formulas, connectors and type catalogs.
- Adaptation of families from open sources.
- Technical family description.
- Family validation.
- Change management and versioning.
- Best practices and common mistakes.
- Appendices with a family technical-description template and examples.

## Family Development Principles

- Treat the family as a digital analogue of a real building element, product or
  equipment item.
- Prefer reasonable sufficiency: include enough geometry and attributes for the
  task, but avoid unnecessary detail that increases model weight.
- Use parametric families to reduce duplicated family files and support type
  variation.
- Develop families from the correct family template and category.
- Plan usage context before modeling: discipline, category, LOD, project stage,
  expected schedules, tags, room behavior, host behavior and type catalog needs.

## ARTEL Planning Checklist

- Identify family category and template before writing a specification.
- Define whether the family is generic, manufacturer-specific, loadable,
  nested, shared nested, annotation, detail or adaptive.
- Define target LOD and display rules for low, medium and high detail levels.
- Define type parameters and instance parameters separately.
- Define which parameters must be shared parameters and which can stay as
  family-only parameters.
- Define catalog strategy when the family has many type sizes.
- Define validation scenarios: load into project, flex parameters, check tags,
  schedules, visibility, materials, geometry weight and room calculation point.

## Modeling Rules

- Build the family skeleton from reference planes and reference lines first.
- Drive geometry from the skeleton, not directly from loose dimensions.
- Lock critical origin/reference planes and keep a clear insertion point.
- Use symbolic graphics or annotation/detail elements for plan symbols instead
  of heavy model geometry where appropriate.
- Keep geometry simple enough for general arrangement drawings; avoid modeling
  hidden internals, small chamfers, threads and excessive manufacturing detail
  unless the task requires it.
- Split geometry visibility by detail level so small parts appear only where
  needed.
- Use subcategories deliberately so project teams can control graphics.
- Use nested families only when the reusable component is genuinely shared by
  several families or must be counted/tagged independently.

## Parameter Rules

- Prefer explicit, task-oriented parameter names and groups.
- Separate type-level and instance-level behavior.
- Use shared parameters for values that must appear in schedules, tags or
  cross-project data exchange.
- Use family parameters for internal geometry and graphics controls.
- Keep formulas minimal and readable; excessive formulas reduce maintainability.
- Use type catalogs for large type sets instead of bloating the family with many
  embedded types.
- ARTEL should compare task-required ADSK parameters against FOP_PROFILE chunks
  before accepting an RFA.

## Validation Checklist

- Open and load the family without warnings that affect use.
- Flex all important dimensions and type parameters.
- Verify origin, insertion point, host behavior and room calculation point where
  relevant.
- Verify low, medium and high detail display.
- Verify plan, elevation, section and 3D behavior.
- Verify materials and subcategories.
- Verify type catalog behavior when used.
- Verify required shared parameters, tags and schedules.
- Verify file size and performance risk.
- Write a technical family description with scope, LOD, display behavior,
  parameters, subcategories and usage notes.

## Common Failure Patterns

- Geometry is not constrained to reference planes or reference lines.
- Parameters are attached directly to geometry instead of the skeleton.
- Plan symbols are modeled as heavy 3D geometry.
- Detail level is too high for the intended project use.
- Too many voids, formulas, arrays or nested families increase file size and
  slow projects.
- Large type sets are embedded in the family instead of being moved to a type
  catalog.
- Parameter naming and file naming are inconsistent.
- Family is not tested by parameter flexing before catalog acceptance.

## ARTEL Usage

Use this source when ARTEL creates or reviews a family specification, selects a
Revit template, decides which parameters belong to FOP/shared parameters, writes
validation criteria, or explains why a generated/edited RFA should be accepted
or sent back for correction.
