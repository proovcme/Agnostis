# ARTEL FamilyLearningCase

Case ID: validation_report_fde30369290d46499604a9666de3ac77
Product: ARTEL
Visibility: private_runtime

## Task
Title: Шкаф архивный металлический
Family category: Furniture
Family name: Шкаф архивный металлический
Goal: Параметрическое семейство шкафа с линейкой типоразмеров.
Constraints:
- Все обязательные параметры существуют
- Все типы из спецификации созданы
- Материалы назначены параметрически

## Source Summaries
- validation_report: ARTEL smoke validation report from Legion build

## Approved Specification
Types:
- Шкаф 800x400x1800
Geometry: See approved ARTEL specification and Revit validation report.
Materials:
- Материал корпуса: RAL 7035
Parameters:
- ADSK_Наименование: required [Identity Data]
- Ширина: required [Dimensions]
- Высота: required [Dimensions]

## Parameter Profile
FOP profile: fop_2026
Required shared parameters:
- ADSK_Наименование (4f5cb6a1-0000-0000-0000-000000000000)

## Validation Report
Status: warning
Checks:
- Все обязательные параметры существуют
- Все типы из спецификации созданы
- Материалы назначены параметрически
- warning: missing_shared_parameter - Missing shared parameter
Known failures:
- missing_shared_parameter: ADSK_???????????? should exist as a shared parameter.
Fixes:
- manual_check ADSK_????????????: pending - Open family in Revit 2025 and run ARTEL Family Validate.

## Catalog Card
Display name: Шкаф архивный металлический
Category: Furniture
Tags:
- мебель
- шкаф
- архив
Search terms:
- Шкаф архивный металлический
- Furniture
- FAM-0241
- RFA
- ARTEL

## Acceptance
Outcome: warning
Accepted by role: ARTEL validation workflow
Notes: ARTEL smoke validation report from Legion build

## Retrieval Hints
ARTEL RFA Revit family catalog validation FOP shared parameters ADSK_Наименование ADSK_КодИзделия FamilyLearningCase
