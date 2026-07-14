# ARTEL FamilyLearningCase

Case ID: demo_metal_cabinet_001
Product: ARTEL
Visibility: public_demo

## Task
Title: Металлический шкаф управления для каталога Revit-семейств
Family category: Оборудование
Family name: ARTEL_DEMO_MetalCabinet
Goal: Сделать параметрическое Revit-семейство шкафа управления для повторного использования в проектах.
Constraints:
- Типоразмеры 600x400x200 и 800x600x250 мм
- Дверь должна быть отдельной управляемой геометрией
- Каталожные параметры обязательны перед публикацией

## Source Summaries
- task_brief: Заказчик просит типовое семейство шкафа с материалом корпуса, монтажным основанием и понятной карточкой каталога.
- rfa_review: Первичная версия не прошла проверку из-за пустого ADSK_Наименование и отсутствующего кода изделия.

## Approved Specification
Types:
- 600x400x200
- 800x600x250
Geometry: Параметрический корпус, дверь, ручка, монтажная панель и условное обозначение. Размеры управляются типами.
Materials:
- Окрашенная сталь
- Пластик ручки
Parameters:
- ADSK_Наименование: Шкаф управления металлический [Каталог]
- ADSK_КодИзделия: ARTEL-DEMO-CABINET-{type} [Каталог]
- МатериалКорпуса: Окрашенная сталь [Материалы]

## Parameter Profile
FOP profile: ARTEL_DEMO_FOP_v1
Required shared parameters:
- ADSK_Наименование
- ADSK_КодИзделия
- ADSK_Марка
- ADSK_Примечание

## Validation Report
Status: accepted_with_notes
Checks:
- Все типоразмеры открываются без ошибок
- Обязательные shared parameters заполнены
- Каталожная карточка содержит назначение и поисковые теги
Known failures:
- Пустой ADSK_Наименование приводит к неинформативному каталогу
- Отсутствующий ADSK_КодИзделия мешает связать семейство со спецификацией
Fixes:
- Заполнить ADSK_Наименование на уровне типа
- Сформировать ADSK_КодИзделия по правилу ARTEL-DEMO-CABINET-{type}
- Добавить теги: шкаф, управление, оборудование, металл

## Catalog Card
Display name: Шкаф управления металлический
Category: Оборудование
Tags:
- шкаф
- управление
- оборудование
- металл
Search terms:
- металлический шкаф
- шкаф управления
- Revit family
- RFA catalog
- ADSK_Наименование

## Acceptance
Outcome: accepted_with_notes
Accepted by role: BIM coordinator
Notes: Кейс годится как public-safe seed для проверки ARTEL_Index и retrieval по похожим RFA задачам.

## Retrieval Hints
ARTEL RFA Revit family catalog validation FOP shared parameters ADSK_Наименование ADSK_КодИзделия FamilyLearningCase
