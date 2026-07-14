# ARTEL Revit API 2024 XML Documentation

Product: ARTEL
Document type: REVIT_API_SDK_DOC
Source kind: Revit SDK XML documentation
Revit API version: 2024.1.10.25
Assembly: RevitAPI
Source file: RevitAPI.xml
Source XML SHA-256: 07eef86660fc3e118a52d485648c9d26b421c324375783f22f0c9a7a1eae2089
Package URL: https://api.nuget.org/v3-flatcontainer/autodesk.revit.sdk/2024.1.10.25/autodesk.revit.sdk.2024.1.10.25.nupkg
Package SHA-256: 72e2be30d84f438e6d9d9eeb92ff99a7674dfbcbe906c2dcaf9229b75c5cff43
Shard: 42
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.ViewSchedule.IsDataOutOfDate`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.IsDataOutOfDate`

#### Summary

Indicates whether the schedule data is out of date.

#### Remarks

To improve performance, the ViewSchedule may contain TableSections that are only updated on demand. For example,
the body section of a schedule is not updated when the ViewSchedule is closed. In this case, you need to call
RefreshData to avoid getting the stale data.

#### Returns

True if the schedule data is out of date, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForNoteBlock(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForNoteBlock(Autodesk.Revit.DB.Document)`

#### Summary

Gets the default view name that will be used when creating a note block.

#### Parameter `document`

The document to which the new schedule will be added.

#### Returns

The default view name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForRevisionSchedule(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForRevisionSchedule(Autodesk.Revit.DB.Document)`

#### Summary

Gets the default view name that will be used when creating a revision schedule.

#### Parameter `document`

The titleblock family document to which the new schedule will be added.

#### Returns

The default view name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a titleblock family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForKeynoteLegend(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForKeynoteLegend(Autodesk.Revit.DB.Document)`

#### Summary

Gets the default view name that will be used when creating a keynote legend.

#### Parameter `document`

The document to which the new schedule will be added.

#### Returns

The default view name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForSheetList(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForSheetList(Autodesk.Revit.DB.Document)`

#### Summary

Gets the default view name that will be used when creating a sheet list.

#### Parameter `document`

The document to which the new schedule will be added.

#### Returns

The default view name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForViewList(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForViewList(Autodesk.Revit.DB.Document)`

#### Summary

Gets the default view name that will be used when creating a view list.

#### Parameter `document`

The document to which the new schedule will be added.

#### Returns

The default view name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForMaterialTakeoff(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForMaterialTakeoff(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the default view name that will be used when creating a material takeoff.

#### Parameter `document`

The document to which the new schedule will be added.

#### Parameter `categoryId`

The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.

#### Returns

The default view name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
categoryId is not a valid category for a material takeoff.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.GetDefaultParameterNameForKeySchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetDefaultParameterNameForKeySchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the default parameter name that will be used when creating a key schedule.

#### Remarks

See ViewSchedule.KeyScheduleParameterName for details.

#### Parameter `document`

The document to which the new schedule will be added.

#### Parameter `categoryId`

The ID of the category of elements that the schedule's keys will be associated with.

#### Returns

The default parameter name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
categoryId is not a valid category for a key schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForKeySchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForKeySchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the default view name that will be used when creating a key schedule.

#### Parameter `document`

The document to which the new schedule will be added.

#### Parameter `categoryId`

The ID of the category of elements that the schedule's keys will be associated with.

#### Returns

The default view name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
categoryId is not a valid category for a key schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForSchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForSchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the default view name that will be used when creating a schedule.

#### Parameter `document`

The document to which the new schedule will be added.

#### Parameter `categoryId`

The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.

#### Parameter `areaSchemeId`

The ID of an area scheme in an area schedule, InvalidElementId otherwise.

#### Returns

The default view name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
categoryId is not a valid category for a regular schedule.
-or-
In a non-area schedule, areaSchemeId is not InvalidElementId.
-or-
In an area schedule, areaSchemeId is not the ID of an area scheme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForSchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetDefaultNameForSchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the default view name that will be used when creating a regular schedule.

#### Parameter `document`

The document to which the new schedule will be added.

#### Parameter `categoryId`

The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.

#### Returns

The default view name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
categoryId is not a valid category for a regular schedule.
-or-
The Areas category was specified but an area scheme ID was not provided.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.GetValidFamiliesForNoteBlock(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetValidFamiliesForNoteBlock(Autodesk.Revit.DB.Document)`

#### Summary

Gets a list of families that can be used for a note block.

#### Parameter `document`

The document.

#### Returns

The IDs of all valid families.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.GetValidCategoriesForMaterialTakeoff`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetValidCategoriesForMaterialTakeoff`

#### Summary

Gets a list of categories that can be used for a material takeoff.

#### Returns

The IDs of all valid categories.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.GetValidCategoriesForKeySchedule`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetValidCategoriesForKeySchedule`

#### Summary

Gets a list of categories that can be used for a key schedule.

#### Returns

The IDs of all valid categories.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.GetValidCategoriesForSchedule`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetValidCategoriesForSchedule`

#### Summary

Gets a list of categories that can be used for a regular schedule.

#### Returns

The IDs of all valid categories.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.IsValidFamilyForNoteBlock(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.IsValidFamilyForNoteBlock(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether a family can be used for a note block.

#### Parameter `document`

The document.

#### Parameter `familyId`

The family ID to check.

#### Returns

True if the family can be used for a note block,
false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.IsValidCategoryForMaterialTakeoff(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.IsValidCategoryForMaterialTakeoff(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether a category can be used for a material takeoff.

#### Parameter `categoryId`

The category ID to check.

#### Returns

True if the category can be used for a material takeoff,
false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.IsValidCategoryForKeySchedule(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.IsValidCategoryForKeySchedule(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether a category can be used for a key schedule.

#### Parameter `categoryId`

The category ID to check.

#### Returns

True if the category can be used for a key schedule,
false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.IsValidCategoryForSchedule(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.IsValidCategoryForSchedule(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether a category can be used for a regular schedule.

#### Parameter `categoryId`

The category ID to check.

#### Returns

True if the category can be used for a regular schedule,
false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.CreateNoteBlock(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.CreateNoteBlock(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a note block.

#### Remarks

A note block is a schedule of the Generic Annotations category
that shows elements of a single family rather than all elements
in the category.

#### Parameter `document`

The document to which the new schedule will be added.

#### Parameter `familyId`

The ID of the family whose elements will be included in the schedule.

#### Returns

The newly created schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
familyId is not a valid family for a note block.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.CreateRevisionSchedule(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.CreateRevisionSchedule(Autodesk.Revit.DB.Document)`

#### Summary

Creates a revision schedule.

#### Remarks

Revision schedules are added to titleblock families and become
visible as part of titleblocks on sheets.

#### Parameter `document`

The titleblock family document to which the new schedule will be added.

#### Returns

The newly created schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a titleblock family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.CreateKeynoteLegend(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.CreateKeynoteLegend(Autodesk.Revit.DB.Document)`

#### Summary

Creates a keynote legend.

#### Remarks

A keynote legend is a schedule of the Keynote Tags category.

#### Parameter `document`

The document to which the new schedule will be added.

#### Returns

The newly created schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.CreateSheetList(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.CreateSheetList(Autodesk.Revit.DB.Document)`

#### Summary

Creates a sheet list.

#### Remarks

A sheet list is a schedule of sheets in the project.
It is a schedule of the Sheets category.

#### Parameter `document`

The document to which the new schedule will be added.

#### Returns

The newly created schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.CreateViewList(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.CreateViewList(Autodesk.Revit.DB.Document)`

#### Summary

Creates a view list.

#### Remarks

A view list is a schedule of views in the project.
It is a schedule of the Views category.

#### Parameter `document`

The document to which the new schedule will be added.

#### Returns

The newly created schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.CreateMaterialTakeoff(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.CreateMaterialTakeoff(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a material takeoff.

#### Remarks

A material takeoff is a schedule that displays information about
the materials that make up elements in the model. Unlike regular
schedules where each row (before grouping) represents a single
element, each row in a material takeoff represents a single
<element, material> pair.

#### Parameter `document`

The document to which the new schedule will be added.

#### Parameter `categoryId`

The ID of the category whose elements will be included in the schedule,
or InvalidElementId for a multi-category schedule.

#### Returns

The newly created schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
categoryId is not a valid category for a material takeoff.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.CreateKeySchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.CreateKeySchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Create a key schedule.

#### Remarks

A key schedule displays abstract "key" elements that can be used to
populate parameters of ordinary model elements.

#### Parameter `document`

The document to which the new schedule will be added.

#### Parameter `categoryId`

The ID of the category of elements that the schedule's keys will be associated with.

#### Returns

The newly created schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
categoryId is not a valid category for a key schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.CreateSchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.CreateSchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a regular schedule that can relate to a specific area scheme.

#### Parameter `document`

The document to which the new schedule will be added.

#### Parameter `categoryId`

The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.

#### Parameter `areaSchemeId`

The ID of an area scheme in an area schedule, InvalidElementId otherwise.

#### Returns

The newly created schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
categoryId is not a valid category for a regular schedule.
-or-
In a non-area schedule, areaSchemeId is not InvalidElementId.
-or-
In an area schedule, areaSchemeId is not the ID of an area scheme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.CreateSchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.CreateSchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a regular schedule.

#### Parameter `document`

The document to which the new schedule will be added.

#### Parameter `categoryId`

The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.

#### Returns

The newly created schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
categoryId is not a valid category for a regular schedule.
-or-
The Areas category was specified but an area scheme ID was not provided.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2013

### `P:Autodesk.Revit.DB.ViewSchedule.IsInternalKeynoteSchedule`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.IsInternalKeynoteSchedule`

#### Summary

Identifies if this ViewSchedule is an internal schedule used when keynotes are filtered based on the elements that are shown on a sheet.

#### Remarks

These schedules cannot be modified by the user or placed on sheets.

#### Since

2013

### `P:Autodesk.Revit.DB.ViewSchedule.IsTitleblockRevisionSchedule`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.IsTitleblockRevisionSchedule`

#### Summary

Identifies if this ViewSchedule is an internal schedule used to display revision schedules as part of a titleblock.

#### Remarks

These schedules cannot be modified by the user or placed on sheets.

#### Since

2013

### `P:Autodesk.Revit.DB.ViewSchedule.IsHeaderFrozen`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.IsHeaderFrozen`

#### Summary

A static property defining if the schedule header frozen setting is turned on or off in current Revit Application Session.

#### Remarks

The setting will be written into Revit.ini if users set the value.
If users start multiple Revit sessions, the schedule header frozen setting might be different in each session.
Revit.ini file stores the lastest setting no matter what the Revit session is.

#### Since

2020.1

### `P:Autodesk.Revit.DB.ViewSchedule.UseStripedRowsOnSheets`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.UseStripedRowsOnSheets`

#### Summary

Indicates whether a property setting of true will also change the display of this schedule to show striped rows on a sheet.
If true, setting that property to true will also change the display.
If false, striped rows will not display for this schedule on a sheet no matter what value is set for HasStripedRows.

#### Remarks

Striped rows on sheets can be overidden by shading or conditional formatting.

#### Since

2021

### `P:Autodesk.Revit.DB.ViewSchedule.HasStripedRows`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.HasStripedRows`

#### Summary

Indicates whether this schedule has striped rows.

#### Remarks

Striped rows can be overridden by shading or conditional formatting.

#### Since

2020.1

### `P:Autodesk.Revit.DB.ViewSchedule.RowHeightOverride`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.RowHeightOverride`

#### Summary

Defines the override that is applied to the row height.

#### Remarks

Setting this property to anything but `F:Autodesk.Revit.DB.RowHeightOverrideOptions.None` will allow setting the `P:Autodesk.Revit.DB.ViewSchedule.RowHeight` property.
This is taken into account when the schedule is viewed as a ScheduleSheetInstance on a ViewSheet.

#### Value

`F:Autodesk.Revit.DB.RowHeightOverrideOptions.None` to disable row height override.
`F:Autodesk.Revit.DB.RowHeightOverrideOptions.All` enables row height override for all the body rows in the schedule.
`F:Autodesk.Revit.DB.RowHeightOverrideOptions.ImageRows` enables row height override for all the schedule body rows that contains images or custom graphics.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.ViewSchedule.RowHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.RowHeight`

#### Summary

Defines the schedule body rows height.

#### Remarks

Setting this property will force all or image only (depending on how `P:Autodesk.Revit.DB.ViewSchedule.RowHeightOverride` is defined) schedule body rows to be resized to the indicated height value (when viewed as a ScheduleSheetInstance on a ViewSheet).
If the value that is set is smaller than the height of the text (single or multi line), then that value is not taken into account.
To access or set this property the `P:Autodesk.Revit.DB.ViewSchedule.RowHeightOverride` property should not be `F:Autodesk.Revit.DB.RowHeightOverrideOptions.None`

#### Value

The row height for any body rows in the schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for rowHeight must be between 0 and 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RowHeightOverride property is set to RowHeightOverrideOptions.None.

#### Since

2024

### `P:Autodesk.Revit.DB.ViewSchedule.ImageRowHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.ImageRowHeight`

#### Summary

Defines the image row height in the schedule.

#### Remarks

If there is at least one image field in the schedule, then setting this property will force all rows containing images to be
resized to the indicated height value (when viewed as a ScheduleSheetInstance on a ViewSheet). Setting this property will have
no effect if HasImageField returns false.

This height will be maintained until the user or application restores the original image sizes (in API: `M:Autodesk.Revit.DB.ViewSchedule.RestoreImageSize` ).

#### Value

The row height for any rows containing images in the schedule. The value is 0.0 by default if not customized.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for imageRowHeight must be greater than 0 and no more than 30000 feet.

#### Since

2015

### `P:Autodesk.Revit.DB.ViewSchedule.KeyScheduleParameterName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.KeyScheduleParameterName`

#### Summary

In a key schedule, the name of the parameter for choosing one of the keys.

#### Remarks

When a key schedule is created, elements of the schedule's category
receive a new parameter for choosing one of the keys defined in the key schedule.
This is the name of that parameter.

#### Value

The name of the key schedule parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ViewSchedule is not key schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

When setting this property: The document containing this ViewSchedule is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
When setting this property: The document containing this ViewSchedule is being loaded, or is in the midst of another
sensitive process.
-or-
When setting this property: This ViewSchedule is an internal element, such as a component of a
loaded family or a group type.
-or-
When setting this property: The document containing this ViewSchedule is in Group Edit Mode,
Sketch Edit Mode, or Paste Mode, and the element is not a
member of the group, sketch, or clipboard.
-or-
When setting this property: This ViewSchedule is a member of a group or sketch, and the document
is not currently editing the group or sketch.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

When setting this property: The document containing this ViewSchedule has no open transaction.

#### Since

2013

### `P:Autodesk.Revit.DB.ViewSchedule.EmbeddedDefinition`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.EmbeddedDefinition`

#### Summary

The embedded ScheduleDefinition.

#### Since

2013

### `P:Autodesk.Revit.DB.ViewSchedule.Definition`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.Definition`

#### Summary

The primary ScheduleDefinition.

#### Since

2013

### `P:Autodesk.Revit.DB.ViewSchedule.BodyTextTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.BodyTextTypeId`

#### Summary

Defines the default text style used for the data section of the schedule.

#### Remarks

Columns may override the default style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The text type id doesn't represent a valid text type element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ViewSchedule.HeaderTextTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.HeaderTextTypeId`

#### Summary

Defines the default text style used in the column headers in the body section of the schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The text type id doesn't represent a valid text type element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ViewSchedule.TitleTextTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSchedule.TitleTextTypeId`

#### Summary

Defines the default text style used in the header section of the schedule.

#### Remarks

Cells may override the default style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The text type id doesn't represent a valid text type element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.ViewSchedule`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewSchedule`

#### Summary

A schedule view.

#### Remarks

The ViewSchedule class represents schedules and other schedule-like views,
including single-category and multi-category schedules, key schedules,
material takeoffs, view lists, sheet lists, keynote legends, revision schedules,
and note blocks. The ViewSchedule class is not used for panel schedules
(see PanelScheduleView) or graphical column schedules.

A schedule is a tabular representation of data. A typical
schedule shows all elements of a category (doors, rooms, etc.)
with each row representing an element and each column representing a
parameter. This basic structure can be modified using filters, sorting,
grouping, totals, formulas, and other features.

The ScheduleDefinition class contains most settings that determine
the contents of a schedule, including category, fields, filters, and sorting.

A graphical representation of a schedule can be placed on a sheet
using the ScheduleSheetInstance class.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleHeightsOnSheet.GetBodyRowHeights`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleHeightsOnSheet.GetBodyRowHeights`

#### Summary

Returns each row's height of schedule body on sheet view.

#### Returns

Each row's height of schedule body on sheet view.

#### Since

2022.1

### `P:Autodesk.Revit.DB.ScheduleHeightsOnSheet.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleHeightsOnSheet.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ScheduleHeightsOnSheet.ColumnHeaderHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleHeightsOnSheet.ColumnHeaderHeight`

#### Summary

The height of all schedule header part, including the gap line between header and body.

#### Since

2022.1

### `P:Autodesk.Revit.DB.ScheduleHeightsOnSheet.TitleHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleHeightsOnSheet.TitleHeight`

#### Summary

The height of schedule title on sheet view.

#### Remarks

If title is set to unshown, it will be 0.

#### Since

2022.1

### `T:Autodesk.Revit.DB.ScheduleHeightsOnSheet`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleHeightsOnSheet`

#### Summary

Heights information of a schedule on sheet.

#### Remarks

This class returns the heights of schedule title, column header and each body row on sheet view.

#### Since

2022.1

### `T:Autodesk.Revit.DB.RowHeightOverrideOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.RowHeightOverrideOptions`

#### Summary

Describes the options for overriding schedule body row heights (applied when viewed as a ScheduleSheetInstance on a ViewSheet).

#### Since

2024

#### Since

2024

### `F:Autodesk.Revit.DB.RowHeightOverrideOptions.ImageRows`

Member kind: field
Symbol: `Autodesk.Revit.DB.RowHeightOverrideOptions.ImageRows`

#### Summary

Override row height for body rows containing images in the schedule.

### `F:Autodesk.Revit.DB.RowHeightOverrideOptions.All`

Member kind: field
Symbol: `Autodesk.Revit.DB.RowHeightOverrideOptions.All`

#### Summary

Override row height for any body rows in the schedule.

### `F:Autodesk.Revit.DB.RowHeightOverrideOptions.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.RowHeightOverrideOptions.None`

#### Summary

No override would be applied for the row height.

### `M:Autodesk.Revit.DB.TableView.GetCalculatedValueText(Autodesk.Revit.DB.SectionType,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableView.GetCalculatedValueText(Autodesk.Revit.DB.SectionType,System.Int32,System.Int32)`

#### Summary

Gets the calculated value text for a cell from the instance view.

#### Parameter `sectionType`

The section type.

#### Parameter `row`

The row.

#### Parameter `column`

The column.

#### Returns

The calculated value text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The sectionType is not a valid type for this view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given row number row is invalid.
-or-
The given column number column is invalid.
-or-
A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.TableView.GetCalculatedValueName(Autodesk.Revit.DB.SectionType,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableView.GetCalculatedValueName(Autodesk.Revit.DB.SectionType,System.Int32,System.Int32)`

#### Summary

Gets the calculated value name for a cell from the template view.

#### Parameter `sectionType`

The section type.

#### Parameter `row`

The row.

#### Parameter `column`

The column.

#### Returns

The name of the calculated value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The sectionType is not a valid type for this view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given row number row is invalid.
-or-
The given column number column is invalid.
-or-
A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.TableView.GetCellText(Autodesk.Revit.DB.SectionType,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableView.GetCellText(Autodesk.Revit.DB.SectionType,System.Int32,System.Int32)`

#### Summary

Gets the cell's text based on its type

#### Parameter `sectionType`

The requested section type

#### Parameter `row`

Row Number in the Section

#### Parameter `column`

Column Number in the Section

#### Returns

The text for the given cell

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The sectionType is not a valid type for this view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given row number row is invalid.
-or-
The given column number column is invalid.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.TableView.GetAvailableParameters(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableView.GetAvailableParameters(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets a list of valid parameters for the specified category that can be used in the table view.

#### Parameter `cda`

The document.

#### Parameter `categoryId`

The specified element category id.

#### Returns

The IDs of all valid parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.TableView.GetAvailableParameterCategories(Autodesk.Revit.DB.SectionType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableView.GetAvailableParameterCategories(Autodesk.Revit.DB.SectionType,System.Int32)`

#### Summary

Get all available parameter categories.

#### Parameter `sectionType`

The section the row lies in.

#### Parameter `row`

The row.

#### Returns

The available parameter categories.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The sectionType is not a valid type for this view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given row number row is invalid.
-or-
A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.TableView.IsValidSectionType(Autodesk.Revit.DB.SectionType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableView.IsValidSectionType(Autodesk.Revit.DB.SectionType)`

#### Summary

Identifies if the section type is valid for this view.

#### Remarks

Some TableViews do not contain all of the possible section types. For
example, standard schedules have only a Heading and Body.

#### Parameter `sectionType`

The section type.

#### Returns

True if the Section Type is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.TableView.MaximumRowHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableView.MaximumRowHeight`

#### Summary

Gets the maximum row height

### `P:Autodesk.Revit.DB.TableView.MaximumColumnWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableView.MaximumColumnWidth`

#### Summary

Gets the maximum column width

### `P:Autodesk.Revit.DB.TableView.MinimumRowHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableView.MinimumRowHeight`

#### Summary

Gets the minimum row height

#### Since

2014

### `P:Autodesk.Revit.DB.TableView.MinimumColumnWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableView.MinimumColumnWidth`

#### Summary

Gets the minimum column width

#### Since

2014

### `P:Autodesk.Revit.DB.TableView.MaximumGridWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableView.MaximumGridWidth`

#### Summary

Gets the allowed maximum grid width

#### Since

2014

### `P:Autodesk.Revit.DB.TableView.TargetId`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableView.TargetId`

#### Summary

the element id of the element that is being viewed

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `T:Autodesk.Revit.DB.TableView`

Member kind: type
Symbol: `Autodesk.Revit.DB.TableView`

#### Summary

This represents a view that shows a table.
Most of the layout data for the table is contained in the TableData class.

### `T:Autodesk.Revit.DB.StripedRowPattern`

Member kind: type
Symbol: `Autodesk.Revit.DB.StripedRowPattern`

#### Since

2021

#### Summary

An enumerated type representing the possible sets of rows of a striped row schedule.

#### Since

2021

### `F:Autodesk.Revit.DB.StripedRowPattern.SecondRow`

Member kind: field
Symbol: `Autodesk.Revit.DB.StripedRowPattern.SecondRow`

#### Summary

The second row and every other row thereafter.

### `F:Autodesk.Revit.DB.StripedRowPattern.FirstRow`

Member kind: field
Symbol: `Autodesk.Revit.DB.StripedRowPattern.FirstRow`

#### Summary

The first row and every other row thereafter.

### `M:Autodesk.Revit.DB.ViewSheet.CanBeDuplicated(Autodesk.Revit.DB.SheetDuplicateOption)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.CanBeDuplicated(Autodesk.Revit.DB.SheetDuplicateOption)`

#### Summary

Identifies if this sheet can be duplicated.

#### Parameter `duplicateOption`

The option to use when duplicating the sheet.

#### Returns

True if the sheet can be duplicated, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2023

### `M:Autodesk.Revit.DB.ViewSheet.Duplicate(Autodesk.Revit.DB.SheetDuplicateOption)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.Duplicate(Autodesk.Revit.DB.SheetDuplicateOption)`

#### Summary

Duplicates this sheet to generate a new one.

#### Parameter `duplicateOption`

The option to use when duplicating the sheet.

#### Returns

The id of the newly created sheet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Sheet cannot be duplicated

#### Since

2023

### `M:Autodesk.Revit.DB.ViewSheet.DeleteViewport(Autodesk.Revit.DB.Viewport)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.DeleteViewport(Autodesk.Revit.DB.Viewport)`

#### Summary

Removes a viewport from the sheet by deleting it from the document.

#### Parameter `viewport`

The viewport that will be deleted and removed from the sheet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSheet.GetAllPlacedViews`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.GetAllPlacedViews`

#### Summary

Returns the ElementIds of Views placed on this sheet.

#### Remarks

Schedules on the sheet are not returned by this method. Use ScheduleSheetInstance.OwnerViewId to find the sheet on which a schedule is placed.

#### Returns

The ids of the views on this sheet.

#### Since

2015

### `M:Autodesk.Revit.DB.ViewSheet.GetAllViewports`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.GetAllViewports`

#### Summary

Returns the ElementIds of Viewports on this sheet.

#### Remarks

Schedules on the sheet are not returned by this method. Use ScheduleSheetInstance.OwnerViewId to find the sheet on which a schedule is placed.

#### Returns

The Viewports on this sheet.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSheet.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new ViewSheet.

#### Parameter `document`

The document to which the ViewSheet will be added.

#### Parameter `titleBlockTypeId`

The type id of the TitleBlock type which will be used by the new ViewSheet.
For no TitleBlock, pass invalid element ID.

#### Returns

The new ViewSheet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId titleBlockTypeId does not correspond to a TitleBlock type.
-or-
document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSheet.CreatePlaceholder(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.CreatePlaceholder(Autodesk.Revit.DB.Document)`

#### Summary

Creates a placeholder sheet in a document.

#### Remarks

Placeholder sheets represent sheets stored outside of the Revit model,
but which should be organized along with the Revit sheets.

#### Parameter `aDoc`

The document.

#### Returns

The placeholder sheet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ViewSheet.SetAdditionalRevisionIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.SetAdditionalRevisionIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets the Revisions to additionally include in the sheet's revision schedules.

#### Remarks

Additionally included Revisions will always participate in the sheet's revision schedules.
Normally a Revision is scheduled in the revision schedule because one of its associated RevisionClouds
is present on the sheet.

The additional project revision ids setting corresponds to the sheet's Revisions On Sheet parameter.

#### Parameter `projectRevisionIds`

The ids of Revisions to explicitly include in the sheet's revision schedules.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more ElementIds in projectRevisionIds do not correspond to a Revision element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ViewSheet.GetAdditionalRevisionIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.GetAdditionalRevisionIds`

#### Summary

Gets the Revisions that are additionally included in the sheet's revision schedules.

#### Remarks

Revisions in the sheet's additional project revisions set will appear in revisions schedules
even if no RevisionCloud belonging to that Revision is visible on the sheet.
These ids correspond to the Revisions that are explicitly included on the sheet via the
Revisions On Sheet parameter.

#### Returns

The additionally included Revisions for the sheet's revision schedules.

#### Since

2015

### `M:Autodesk.Revit.DB.ViewSheet.GetAllRevisionIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.GetAllRevisionIds`

#### Summary

Gets the ordered array of Revisions which participate in the sheet's revision schedules.

#### Remarks

The Revisions are ordered according to the revision sequence in the project.
A Revision is considered to be participating in revision scheduling on the sheet
if either a revision cloud belonging to that Revision is visible on the sheet or the Revision
has been explicitly included using the Revisions On Sheet parameter.

#### Returns

The ordered array of ids of Revisions participating in the sheet's revision schedules.

#### Since

2015

### `M:Autodesk.Revit.DB.ViewSheet.GetAllRevisionCloudIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.GetAllRevisionCloudIds`

#### Summary

Gets the ids of the revision clouds which appear on the sheet's revision schedules.

#### Remarks

The sheet's revision schedules include the revisions that are associated with revision clouds that are visible on the sheet.
Revision schedules may also include revisions that have been additionally added to the sheet via the Revisions On Sheets parameter.
Use `M:Autodesk.Revit.DB.ViewSheet.GetAdditionalRevisionIds` to get the additionally added revisions.

#### Returns

The ids of the revisions clouds which appear on the sheet's revision schedules.

#### Since

2023.1

### `M:Autodesk.Revit.DB.ViewSheet.GetRevisionCloudNumberOnSheet(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.GetRevisionCloudNumberOnSheet(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the Revision Number for a RevisionCloud on this sheet.

#### Remarks

Returns `null` if the RevisionCloud or its associated Revision do not appear on this sheet. The Revision Number for
a RevisionCloud will always be the same as the Revision Number of the associated Revision.

#### Parameter `revisionCloudId`

The id of the RevisionCLoud.

#### Returns

Returns the Revision Number as it will appear on this sheet or `null` if there is no Revision Number assigned on this sheet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

revisionCloudId is not the Id of a RevisionCloud.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ViewSheet.GetRevisionNumberOnSheet(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.GetRevisionNumberOnSheet(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the Revision Number for a particular Revision as it will appear on this sheet.

#### Remarks

Returns `null` if the Revision does not appear on this sheet.

#### Parameter `revisionId`

The id of the Revision.

#### Returns

Returns the Revision Number as it will appear on this sheet or `null` if the Revision does not appear on this sheet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

revisionId is not a valid Revision.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ViewSheet.GetCurrentRevision`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.GetCurrentRevision`

#### Summary

Returns the most recent numbered Revision shown on this ViewSheet.

#### Remarks

If the most recent Revision is not issued, Revit will typically use it as the default Revision for
RevisionClouds placed on this ViewSheet. InvalidElementId will be returned if no Revisions are present.
Revisions with RevisionNumberType.None will not be returned.

#### Returns

The Id of the most recent numbered Revision shown on this ViewSheet or InvalidElementId if none are shown.

#### Since

2015

### `M:Autodesk.Revit.DB.ViewSheet.ConvertToRealSheet(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheet.ConvertToRealSheet(Autodesk.Revit.DB.ElementId)`

#### Summary

Converts a placeholder sheet to a real one with an optional titleblock.

#### Parameter `titleBlockTypeId`

The id of the placeholder sheet, or invalidElementId if no titleblock should be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

titleBlockTypeId does not correspond to a TitleBlock type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This method may only be called on a placeholder sheet.
-or-
Failed to convert the sheet because the input titleblock could not be applied.

#### Since

2011

### `P:Autodesk.Revit.DB.ViewSheet.IsPlaceholder`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSheet.IsPlaceholder`

#### Summary

Identifies whether or not the view sheet represents a placeholder sheet.

#### Since

2011

### `P:Autodesk.Revit.DB.ViewSheet.SheetNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSheet.SheetNumber`

#### Summary

The sheet number of the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: sheetNumber is an empty string or contains only whitespace.
-or-
When setting this property: sheetNumber cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
When setting this property: Sheet number is already in use.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `T:Autodesk.Revit.DB.ViewSheet`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewSheet`

#### Summary

Class for ViewSheet

### `T:Autodesk.Revit.DB.SheetDuplicateOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.SheetDuplicateOption`

#### Summary

Options for duplicating sheets

#### Since

2023

#### Since

2023

### `F:Autodesk.Revit.DB.SheetDuplicateOption.DuplicateSheetWithViewsAsDependent`

Member kind: field
Symbol: `Autodesk.Revit.DB.SheetDuplicateOption.DuplicateSheetWithViewsAsDependent`

#### Summary

Duplicate the sheet. Copy its title block, details, viewports, and duplicate its contained views as dependent.
The newly created sheet will reference the newly duplicated dependent views.

### `F:Autodesk.Revit.DB.SheetDuplicateOption.DuplicateSheetWithViewsAndDetailing`

Member kind: field
Symbol: `Autodesk.Revit.DB.SheetDuplicateOption.DuplicateSheetWithViewsAndDetailing`

#### Summary

Duplicate the sheet. Copy its title block, details, viewports, and duplicate its contained views with detailing.
The newly created sheet will reference the newly duplicated views.

### `F:Autodesk.Revit.DB.SheetDuplicateOption.DuplicateSheetWithViewsOnly`

Member kind: field
Symbol: `Autodesk.Revit.DB.SheetDuplicateOption.DuplicateSheetWithViewsOnly`

#### Summary

Duplicate the sheet. Copy its title block, details, viewports and contained views.
The newly created sheet will reference the newly duplicated views.

### `F:Autodesk.Revit.DB.SheetDuplicateOption.DuplicateSheetWithDetailing`

Member kind: field
Symbol: `Autodesk.Revit.DB.SheetDuplicateOption.DuplicateSheetWithDetailing`

#### Summary

Duplicate the sheet, copy the title block and details.

### `F:Autodesk.Revit.DB.SheetDuplicateOption.DuplicateEmptySheet`

Member kind: field
Symbol: `Autodesk.Revit.DB.SheetDuplicateOption.DuplicateEmptySheet`

#### Summary

Duplicate the sheet, only copy its title block.

### `M:Autodesk.Revit.DB.View3D.CanToggleBetweenPerspectiveAndIsometricInternal`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.CanToggleBetweenPerspectiveAndIsometricInternal`

#### Summary

Checks whether this view can toggle between perspective and isometric.

#### Remarks

If view contains view specific elements, ask to duplicate the view before toggling it.

#### Returns

True if this view can be toggled, false otherwise.

### `M:Autodesk.Revit.DB.View3D.ScalePerspectiveCropBox(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.ScalePerspectiveCropBox(System.Double)`

#### Summary

Scale an existing crop box of the perspective view.

#### Remarks

In addition to changing the view crop box, this operation also makes the change analogous to changing the scale of the orthographic view, so that both the size and scale of the view on a sheet changes according to the provided argument 'multiplier'.

For getting or setting view crop box size use property `P:Autodesk.Revit.DB.View.CropBox`

#### Parameter `multiplier`

Multiplier to change the view scale and the current crop box size on both X and Y.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Returns true if the view is not a view template.

#### Since

2024.1

### `M:Autodesk.Revit.DB.View3D.ShowGridsOnLevels(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.ShowGridsOnLevels(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

This method displays the grid lines in this 3D view on the given Levels.

#### Remarks

Previously selected Levels for showing grids will be replaced with the new ids.

#### Parameter `levelsIds`

Levels ids where grids lines will be displayed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.View3D.HideGridsOnLevel(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.HideGridsOnLevel(Autodesk.Revit.DB.ElementId)`

#### Summary

This method hides the grid lines in this 3D view on the given Level.

#### Parameter `levelId`

The id of the Level where grids will not be displayed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.View3D.ShowGridsOnLevel(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.ShowGridsOnLevel(Autodesk.Revit.DB.ElementId)`

#### Summary

This method displays the grid lines in this 3DView on the given Level.

#### Remarks

Grids will be displayed only if they intersects Level's plane.

#### Parameter `levelId`

The id of the Level where grids should be displayed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.View3D.GetLevelsThatShowGrids`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.GetLevelsThatShowGrids`

#### Summary

Returns the list of levels ids where grids are displayed in this 3D view.

#### Returns

The list of levels ids where grids are displayed in 3D views.

#### Since

2022

### `M:Autodesk.Revit.DB.View3D.ToggleToIsometric`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.ToggleToIsometric`

#### Summary

Toggles this view to isometric.

#### Remarks

This view can only be toggled to isometric if no view specific elements are contained.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This view cannot be toggled.

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.DB.View3D.ToggleToPerspective`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.ToggleToPerspective`

#### Summary

Toggles this view to perspective.

#### Remarks

This view can only be toggled to perspective if no view specific elements are contained.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This view cannot be toggled.

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.DB.View3D.CanToggleBetweenPerspectiveAndIsometric`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.CanToggleBetweenPerspectiveAndIsometric`

#### Summary

Checks whether this view can toggle between perspective and isometric.

#### Remarks

This view can only be toggled if no view specific elements are contained.

#### Returns

True if this view can be toggled, false otherwise.

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.DB.View3D.GetSectionBox`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.GetSectionBox`

#### Summary

Gets a copy of the section box for this 3D view.

#### Remarks

The section box cuts the model in this view by its boundaries.

#### Returns

The section box. Note that the section box can be rotated and transformed and thus you will need to use
`!:Autodesk::Revit::DB::BoundingBoxXYZ::Transform` to
interpret the coordinates of the corners or sides of the box in model coordinates.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Returns true if the view is not a view template.

### `M:Autodesk.Revit.DB.View3D.SetSectionBox(Autodesk.Revit.DB.BoundingBoxXYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.SetSectionBox(Autodesk.Revit.DB.BoundingBoxXYZ)`

#### Summary

Sets the section box for this 3D view.

#### Parameter `boundingBoxXYZ`

The bounding box to use for the section box. To turn off the section box, set `P:Autodesk.Revit.DB.View3D.IsSectionBoxActive` to false.
Individual bound enabled flags in the input box are ignored.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Bounding box cannot be empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Returns true if the view is not a view template.

### `M:Autodesk.Revit.DB.View3D.Unlock`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.Unlock`

#### Summary

Unlocks the view. Has no effect if the view is already unlocked.

#### Since

2013

### `M:Autodesk.Revit.DB.View3D.HasBeenLocked`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.HasBeenLocked`

#### Summary

Identifies if the view has ever been locked.

#### Since

2013

### `M:Autodesk.Revit.DB.View3D.RestoreOrientationAndLock`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.RestoreOrientationAndLock`

#### Summary

Locks the view and restores its orientation.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

View has never been locked.

#### Since

2013

### `M:Autodesk.Revit.DB.View3D.SaveOrientationAndLock`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.SaveOrientationAndLock`

#### Summary

Locks the view and saves its orientation

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Returns true if the view is not a view template.
-or-
The orientation of the View3D cannot be saved.

#### Since

2013

### `M:Autodesk.Revit.DB.View3D.CanSaveOrientation`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.CanSaveOrientation`

#### Summary

Returns true if the View3D's orientation can be saved, false otherwise.

#### Remarks

The saved orientation of the default 3D view cannot be overwritten. To convert the default 3D view into a normal 3D view, rename the default 3D view.

#### Returns

True if the View3D's orientation can be saved, false otherwise.

#### Since

2013

### `M:Autodesk.Revit.DB.View3D.SaveOrientation`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.SaveOrientation`

#### Summary

Converts the temporary orientation of the View3D into its saved orientation.

#### Remarks

The View3D will be oriented to its saved orientation on file open.
To save the orientation of the default View3D, first rename the default View3D.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The orientation of the View3D cannot be saved.

#### Since

2013

### `M:Autodesk.Revit.DB.View3D.OrientTo(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.OrientTo(Autodesk.Revit.DB.XYZ)`

#### Summary

Reorients the view to align with the forward direction.

#### Remarks

This method adjusts the ViewOrientation to align with the input forward direction.
The eye position will be automatically determined based on the shape of the
viewing area and size of the model. The UpDirection will be aligned with the project Z axis.

#### Parameter `forwardDirection`

The forward direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

forwardDirection has zero length.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

View is locked and cannot be reoriented.

#### Since

2015

### `M:Autodesk.Revit.DB.View3D.SetOrientation(Autodesk.Revit.DB.ViewOrientation3D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.SetOrientation(Autodesk.Revit.DB.ViewOrientation3D)`

#### Summary

Sets the temporary orientation of the View3D. The new orientation is not saved in the document.

#### Parameter `newViewOrientation3D`

The new orientation to set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

View is locked and cannot be reoriented.

#### Since

2013

### `M:Autodesk.Revit.DB.View3D.GetSavedOrientation`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.GetSavedOrientation`

#### Summary

Gets the saved orientation of the View3D.

#### Returns

The saved orientation of the View3D.

#### Since

2013

### `M:Autodesk.Revit.DB.View3D.GetOrientation`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.GetOrientation`

#### Summary

Gets the current non-saved orientation of the View3D.

#### Returns

The current non-saved orientation of the View3D.

#### Since

2013

### `M:Autodesk.Revit.DB.View3D.CreatePerspective(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.CreatePerspective(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns a new perspective View3D.

#### Remarks

The new View3D will receive a unique view name. The view will be oriented in the same position as the default 3D view.

#### Parameter `document`

The document to which the new View3D will be added.

#### Parameter `viewFamilyTypeId`

The id of the ViewFamilyType which will be used by the new View3D. The type needs to be a ThreeDimensional ViewType.

#### Returns

The new perspective View3D.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This View Family Type is not a ThreeDimensional view type.
-or-
3D view creation is not allowed in this family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2013

### `M:Autodesk.Revit.DB.View3D.CreateIsometric(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.CreateIsometric(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns a new isometric View3D.

#### Remarks

The new View3D will receive a unique view name. The view will be oriented in the same position as the default 3D view.

#### Parameter `document`

The document to which the new View3D will be added.

#### Parameter `viewFamilyTypeId`

The id of the ViewFamilyType which will be used by the new View3D. The type needs to be a ThreeDimensional ViewType.

#### Returns

The new isometric View3D.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This View Family Type is not a ThreeDimensional view type.
-or-
3D view creation is not allowed in this family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2013

### `M:Autodesk.Revit.DB.View3D.ResetCameraTarget`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.ResetCameraTarget`

#### Summary

Resets the camera target to the center of the field of view.

#### Remarks

The camera target can only be reset for perspective view.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The camera target cannot be reset for the view.

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.DB.View3D.CanResetCameraTarget`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.CanResetCameraTarget`

#### Summary

Checks whether the camera target can be reset for this view.

#### Remarks

The camera target can only be reset for perspective view.

#### Returns

True if camera target can be reset for this view, false otherwise.

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.DB.View3D.SetRenderingSettings(Autodesk.Revit.DB.RenderingSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.SetRenderingSettings(Autodesk.Revit.DB.RenderingSettings)`

#### Summary

Changes the rendering settings for this 3d view.

#### Parameter `settings`

The new rendering settings to be applied to this view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.View3D.GetRenderingSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.View3D.GetRenderingSettings`

#### Summary

Returns the current rendering settings for this 3d view.

#### Returns

The returned object represents the current rendering settings.
If you change the returned object, you need to call SetRenderingSettings to apply the new settings back to Revit.

#### Since

2013

### `P:Autodesk.Revit.DB.View3D.ProjectGridsOnSectionBox`

Member kind: property
Symbol: `Autodesk.Revit.DB.View3D.ProjectGridsOnSectionBox`

#### Summary

This option projects all grids from the current 3d view on the bottom face of the section box.
Only grids that are inside or intersects the section box

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Returns true if the view is not a view template.

#### Since

2022

### `P:Autodesk.Revit.DB.View3D.IsSectionBoxActive`

Member kind: property
Symbol: `Autodesk.Revit.DB.View3D.IsSectionBoxActive`

#### Summary

Identifies whether or not the section box is active in this 3D view.

#### Value

An active section box clips the geometry of the model in the 3D view. This affects
the appearance of the view, and also will affect information returned from the API. For example:
Elements outside the active section box will not be returned in the list of elements
obtained from `!:Autodesk::Revit::DB::FilteredElementCollector` when
this view is passed when contructing the collector.

Elements clipped by the active section box will return clipped geometry
from `P:Autodesk.Revit.DB.Element.Geometry(Autodesk.Revit.DB.Options)`
when this view is included in the options.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Returns true if the view is not a view template.

### `P:Autodesk.Revit.DB.View3D.IsPerspective`

Member kind: property
Symbol: `Autodesk.Revit.DB.View3D.IsPerspective`

#### Summary

Identifies whether this is a perspective view.

#### Remarks

In a perspective view, view direction is variable - it is the direction that connects a particular point on the model with the eye position.
The property `P:Autodesk.Revit.DB.View.ViewDirection` becomes less meaningful -
it only describes the general orientation of the camera.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Returns true if the view is not a view template.

### `P:Autodesk.Revit.DB.View3D.IsLocked`

Member kind: property
Symbol: `Autodesk.Revit.DB.View3D.IsLocked`

#### Summary

Indicates if the view is locked.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Returns true if the view is not a view template.

#### Since

2013

### `T:Autodesk.Revit.DB.View3D`

Member kind: type
Symbol: `Autodesk.Revit.DB.View3D`

#### Summary

Class for 3D views

### `P:Autodesk.Revit.DB.ViewOrientation3D.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewOrientation3D.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewOrientation3D.ForwardDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewOrientation3D.ForwardDirection`

#### Summary

The forward direction vector

#### Since

2013

### `P:Autodesk.Revit.DB.ViewOrientation3D.UpDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewOrientation3D.UpDirection`

#### Summary

The up direction vector

#### Since

2013

### `P:Autodesk.Revit.DB.ViewOrientation3D.EyePosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewOrientation3D.EyePosition`

#### Summary

The eye position point

#### Since

2013

### `M:Autodesk.Revit.DB.ViewOrientation3D.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewOrientation3D.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Constructs a new ViewOrientation3D using the input eye position, up and forward directions.

#### Parameter `eyePosition`

The eye position

#### Parameter `upDirection`

The up direction. This vector will be normalized. Up direction must be perpendicular to the forward direction.

#### Parameter `forwardDirection`

The forward direction. This vector will be normalized. Forward direction must be perpendicular to the up direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or both of the input vectors cannot be normalized.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

upDirection has zero length.
-or-
forwardDirection has zero length.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The vectors upDirection and forwardDirection are not perpendicular.

#### Since

2013

### `T:Autodesk.Revit.DB.ViewOrientation3D`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewOrientation3D`

#### Summary

Container for the point and vectors which define View3D's orientation.

#### Since

2013

### `M:Autodesk.Revit.DB.AssemblyViewUtils.AcquireAssemblyViews(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyViewUtils.AcquireAssemblyViews(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Transfers the assembly views owned by a source assembly instance to a target sibling assembly instance of the same assembly type.

#### Parameter `document`

The document in which the assembly instances live.

#### Parameter `sourceAssemblyInstanceId`

Id of the assembly instance that currently owns the assembly views.

#### Parameter `targetAssemblyInstanceId`

Id of the assembly instance which will become the new owner of the assembly views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

sourceAssemblyInstanceId is not an AssemblyInstance with assembly views.
-or-
targetAssemblyInstanceId is not an AssemblyInstance.
-or-
sourceAssemblyInstanceId and targetAssemblyInstanceId are not AssemblyInstances from the same assembly type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2013

### `M:Autodesk.Revit.DB.AssemblyViewUtils.CreateSheet(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyViewUtils.CreateSheet(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new sheet assembly view for the assembly instance.

#### Remarks

The document must be regenerated before using the sheet.

#### Parameter `document`

The document to which the view will be added.

#### Parameter `assemblyInstanceId`

Id of the assembly instance that owns the new view.

#### Parameter `titleBlockId`

Id of the titleblock family to use. For no titleblock, pass invalidElementId.

#### Returns

A new sheet assembly view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

assemblyInstanceId is not an AssemblyInstance.
-or-
titleBlockId is not a TitleBlock.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyViewUtils.CreateMaterialTakeoff(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyViewUtils.CreateMaterialTakeoff(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Creates a new material takeoff multicategory schedule assembly view for the assembly instance.

#### Remarks

The material takeoff schedule will be preloaded with fields "Material: Name" and "Material: Volume".
The document must be regenerated before using the schedule.

#### Parameter `document`

The document to which the view will be added.

#### Parameter `assemblyInstanceId`

Id of the assembly instance that owns the new view.

#### Parameter `viewTemplateId`

Id of the view template that is used to create the view;
if invalidElementId, the view will be created with the default settings.

#### Parameter `isAssigned`

If true, the template will be assigned, if false, the template will be applied.

#### Returns

A new material takeoff multicategory schedule assembly view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

assemblyInstanceId is not an AssemblyInstance.
-or-
viewTemplateId is not a correct view template for the schedule view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2017

### `M:Autodesk.Revit.DB.AssemblyViewUtils.CreateMaterialTakeoff(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyViewUtils.CreateMaterialTakeoff(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new material takeoff multicategory schedule assembly view for the assembly instance.

#### Remarks

The material takeoff schedule will be preloaded with fields "Material: Name" and "Material: Volume".
The document must be regenerated before using the schedule.

#### Parameter `document`

The document to which the view will be added.

#### Parameter `assemblyInstanceId`

Id of the assembly instance that owns the new view.

#### Returns

A new material takeoff multicategory schedule assembly view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

assemblyInstanceId is not an AssemblyInstance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyViewUtils.CreatePartList(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyViewUtils.CreatePartList(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Creates a new part list multicategory schedule assembly view for the assembly instance.

#### Remarks

The new part list schedule will be preloaded with fields "Category", "Family and Type" and "Count".
The document must be regenerated before using the schedule.

#### Parameter `document`

The document to which the view will be added.

#### Parameter `assemblyInstanceId`

Id of the assembly instance that owns the new view.

#### Parameter `viewTemplateId`

Id of the view template that is used to create the view;
if invalidElementId, the view will be created with the default settings.

#### Parameter `isAssigned`

If true, the template will be assigned, if false, the template will be applied.

#### Returns

A new part list multicategory schedule assembly view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

assemblyInstanceId is not an AssemblyInstance.
-or-
viewTemplateId is not a correct view template for the schedule view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2017

### `M:Autodesk.Revit.DB.AssemblyViewUtils.CreatePartList(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyViewUtils.CreatePartList(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new part list multicategory schedule assembly view for the assembly instance.

#### Remarks

The new part list schedule will be preloaded with fields "Category", "Family and Type" and "Count".
The document must be regenerated before using the schedule.

#### Parameter `document`

The document to which the view will be added.

#### Parameter `assemblyInstanceId`

Id of the assembly instance that owns the new view.

#### Returns

A new part list multicategory schedule assembly view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

assemblyInstanceId is not an AssemblyInstance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyViewUtils.CreateSingleCategorySchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyViewUtils.CreateSingleCategorySchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Creates a new single-category schedule assembly view for the assembly instance.

#### Remarks

The new single-category schedule will be preloaded with fields "Family and Type" and "Count".
The schedule will be empty if there are no elements of the specified category in the assembly instance.
The document must be regenerated before using the schedule.

#### Parameter `document`

The document to which the view will be added.

#### Parameter `assemblyInstanceId`

Id of the assembly instance that owns the new view.

#### Parameter `scheduleCategoryId`

Id of the category for which the schedule will be created.
Use ViewSchedule.IsValidCategoryForSchedule() to check if a category can be scheduled.

#### Parameter `viewTemplateId`

Id of the view template that is used to create the view;
if invalidElementId, the view will be created with the default settings.

#### Parameter `isAssigned`

If true, the template will be assigned, if false, the template will be applied.

#### Returns

A new single-category schedule assembly view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

assemblyInstanceId is not an AssemblyInstance.
-or-
scheduleCategoryId is not a valid category for a regular schedule.
-or-
viewTemplateId is not a correct view template for the schedule view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2017

### `M:Autodesk.Revit.DB.AssemblyViewUtils.CreateSingleCategorySchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyViewUtils.CreateSingleCategorySchedule(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new single-category schedule assembly view for the assembly instance.

#### Remarks

The new single-category schedule will be preloaded with fields "Family and Type" and "Count".
The schedule will be empty if there are no elements of the specified category in the assembly instance.
The document must be regenerated before using the schedule.

#### Parameter `document`

The document to which the view will be added.

#### Parameter `assemblyInstanceId`

Id of the assembly instance that owns the new view.

#### Parameter `scheduleCategoryId`

Id of the category for which the schedule will be created.
Use ViewSchedule.IsValidCategoryForSchedule() to check if a category can be scheduled.

#### Returns

A new single-category schedule assembly view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

assemblyInstanceId is not an AssemblyInstance.
-or-
scheduleCategoryId is not a valid category for a regular schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyViewUtils.CreateDetailSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.AssemblyDetailViewOrientation,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyViewUtils.CreateDetailSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.AssemblyDetailViewOrientation,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Creates a new detail section assembly view for the assembly instance.

#### Remarks

The detail section will cut through the center of the assembly instance's outline.
The document must be regenerated before using the detail section.

#### Parameter `document`

The document to which the view will be added.

#### Parameter `assemblyInstanceId`

Id of the assembly instance that owns the new view.

#### Parameter `direction`

The direction for the new view.

#### Parameter `viewTemplateId`

Id of the view template that is used to create the view; if invalidElementId, the view will be created with the default settings.

#### Parameter `isAssigned`

If true, the template will be assigned; if false, the template will be applied.

#### Returns

A new detail section assembly view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

assemblyInstanceId is not an AssemblyInstance.
-or-
viewTemplateId is not a correct view template for the geom view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2017

### `M:Autodesk.Revit.DB.AssemblyViewUtils.CreateDetailSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.AssemblyDetailViewOrientation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyViewUtils.CreateDetailSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.AssemblyDetailViewOrientation)`

#### Summary

Creates a new detail section assembly view for the assembly instance.

#### Remarks

The detail section will cut through the center of the assembly instance's outline.
The document must be regenerated before using the detail section.

#### Parameter `document`

The document to which the view will be added.

#### Parameter `assemblyInstanceId`

Id of the assembly instance that owns the new view.

#### Parameter `direction`

The direction for the new view.

#### Returns

A new detail section assembly view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

assemblyInstanceId is not an AssemblyInstance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyViewUtils.Create3DOrthographic(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyViewUtils.Create3DOrthographic(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Creates a new orthographic 3D assembly view for the assembly instance.
The view will have the same orientation as the Default 3D view.
The document must be regenerated before using the 3D view.

#### Parameter `document`

The document to which the view will be added.

#### Parameter `assemblyInstanceId`

Id of the assembly instance that owns the new view.

#### Parameter `viewTemplateId`

Id of the view template that is used to create the view;
if invalidElementId, the view will be created with the default settings.

#### Parameter `isAssigned`

If true, the template will be assigned, if false, the template will be applied.

#### Returns

A new orthographic 3D assembly view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

assemblyInstanceId is not an AssemblyInstance.
-or-
viewTemplateId is not a correct view template for the geom view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2017

### `M:Autodesk.Revit.DB.AssemblyViewUtils.Create3DOrthographic(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyViewUtils.Create3DOrthographic(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new orthographic 3D assembly view for the assembly instance.

#### Remarks

The view will have the same orientation as the Default 3D view.
The document must be regenerated before using the 3D view.

#### Parameter `document`

The document to which the view will be added.

#### Parameter `assemblyInstanceId`

Id of the assembly instance that owns the new view.

#### Returns

A new orthographic 3D assembly view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

assemblyInstanceId is not an AssemblyInstance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2012

### `T:Autodesk.Revit.DB.AssemblyViewUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyViewUtils`

#### Summary

Utilities that provide capabilities related to assembly view creation and validation.

#### Since

2012

### `T:Autodesk.Revit.DB.AssemblyDetailViewOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyDetailViewOrientation`

#### Summary

Orientation of the Assembly Detail View.

#### Remarks

The orientation can be specified during creation but not modified for existing views.

#### Since

2012

### `F:Autodesk.Revit.DB.AssemblyDetailViewOrientation.ElevationBack`

Member kind: field
Symbol: `Autodesk.Revit.DB.AssemblyDetailViewOrientation.ElevationBack`

#### Summary

The Detail View will be oriented vertically, with its cut plane along the back face of the assembly's bounding box, looking into the bounding box.

### `F:Autodesk.Revit.DB.AssemblyDetailViewOrientation.ElevationFront`

Member kind: field
Symbol: `Autodesk.Revit.DB.AssemblyDetailViewOrientation.ElevationFront`

#### Summary

The Detail View will be oriented vertically, with its cut plane along the front face of the assembly's bounding box, looking into the bounding box.

### `F:Autodesk.Revit.DB.AssemblyDetailViewOrientation.ElevationRight`

Member kind: field
Symbol: `Autodesk.Revit.DB.AssemblyDetailViewOrientation.ElevationRight`

#### Summary

The Detail View will be oriented vertically, with its cut plane along the right face of the assembly's bounding box, looking into the bounding box.

### `F:Autodesk.Revit.DB.AssemblyDetailViewOrientation.ElevationLeft`

Member kind: field
Symbol: `Autodesk.Revit.DB.AssemblyDetailViewOrientation.ElevationLeft`

#### Summary

The Detail View will be oriented vertically, with its cut plane along the left face of the assembly's bounding box, looking into the bounding box.

### `F:Autodesk.Revit.DB.AssemblyDetailViewOrientation.ElevationBottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.AssemblyDetailViewOrientation.ElevationBottom`

#### Summary

The Detail View will be oriented horizontally, with its cut plane along the bottom face of the assembly's bounding box, looking up into the bounding box.

### `F:Autodesk.Revit.DB.AssemblyDetailViewOrientation.ElevationTop`

Member kind: field
Symbol: `Autodesk.Revit.DB.AssemblyDetailViewOrientation.ElevationTop`

#### Summary

The Detail View will be oriented horizontally, with its cut plane along the top face of the assembly's bounding box, looking down into the bounding box.

### `F:Autodesk.Revit.DB.AssemblyDetailViewOrientation.DetailSectionB`

Member kind: field
Symbol: `Autodesk.Revit.DB.AssemblyDetailViewOrientation.DetailSectionB`

#### Summary

The Detail View will be oriented vertically, looking west.

### `F:Autodesk.Revit.DB.AssemblyDetailViewOrientation.DetailSectionA`

Member kind: field
Symbol: `Autodesk.Revit.DB.AssemblyDetailViewOrientation.DetailSectionA`

#### Summary

The Detail View will be oriented vertically, looking north.

### `F:Autodesk.Revit.DB.AssemblyDetailViewOrientation.HorizontalDetail`

Member kind: field
Symbol: `Autodesk.Revit.DB.AssemblyDetailViewOrientation.HorizontalDetail`

#### Summary

The Detail View will be oriented horizontally, looking down.

### `T:Autodesk.Revit.DB.AssemblyType`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyType`

#### Summary

Type for construction assembly elements.

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.IsPrecastAssembly`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.IsPrecastAssembly`

#### Summary

Identifies if the assembly is made by Precast addin.

#### Returns

True if the assembly contains Precast data, false otherwise.

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.SetTransform(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.SetTransform(Autodesk.Revit.DB.Transform)`

#### Summary

Sets the origin of the assembly instance.

#### Parameter `trf`

Transform to be set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

trf is not a rigid body transformation.

#### Since

2013

### `M:Autodesk.Revit.DB.AssemblyInstance.GetTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.GetTransform`

#### Summary

Gets the origin of the assembly instance.

#### Returns

The origin of the assembly instance.

#### Since

2013

### `M:Autodesk.Revit.DB.AssemblyInstance.GetCenter`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.GetCenter`

#### Summary

Returns the center of the bounding box for the assembly instance.
This is the default position for placed assembly instances.

#### Returns

The position for the center of the assembly instance.

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.CompareAssemblyInstances(Autodesk.Revit.DB.AssemblyInstance,Autodesk.Revit.DB.AssemblyInstance)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.CompareAssemblyInstances(Autodesk.Revit.DB.AssemblyInstance,Autodesk.Revit.DB.AssemblyInstance)`

#### Summary

Compares two assembly instances and returns a result with details about the differences

#### Remarks

Only the first found difference is returned.
If the instances are identical, AssemblyDifferenceNone will be returned.

#### Parameter `instance1`

The first assembly instance to compare

#### Parameter `instance2`

the second assembly instance to compare

#### Returns

An object describing the difference between the two instances

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.Disassemble`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.Disassemble`

#### Summary

Removes the assembly instance and releases the member elements.

#### Returns

ids of elements previously under the assembly instance.

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.AllowsAssemblyViewCreation`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.AllowsAssemblyViewCreation`

#### Summary

Returns true if assembly views can be created for this Assembly Instance.

#### Remarks

Assembly views are allowed when there are no assembly views for any instance of this type,
or when the only existing assembly views belong to this instance

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.IsMember(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.IsMember(Autodesk.Revit.DB.ElementId)`

#### Summary

Determines whether the given ElementId is a member of this assembly

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.AssemblyInstance.RemoveMemberIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.RemoveMemberIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Removes member element ids from the assembly instance.

#### Parameter `memberIds`

Element ids to be removed from the assembly instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more element ids was not permitted to be removed from the assembly instance.
Provided set should not be empty and all elements should be a member of the assembly instance.
-or-
The provided set includes one or more element ids that cannot be added to or removed from the assembly on their own.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.AddMemberIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.AddMemberIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Adds member element ids for the assembly instance.

#### Parameter `memberIds`

Element ids to be added to the assembly instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more element ids was not permitted for membership in the assembly instance.
Elements should be of a valid category and should not be a member of an existing assembly.
-or-
The provided set includes one or more element ids that cannot be added to or removed from the assembly on their own.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.SetMemberIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.SetMemberIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets member element ids for the assembly instance. All existing members are cleared.

#### Parameter `memberIds`

Element ids to set for the assembly instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.GetMemberIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.GetMemberIds`

#### Summary

Gets member element ids for the assembly instance.

#### Returns

Element ids for the members of the assembly instance.

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.IsValidNamingCategory(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.IsValidNamingCategory(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Identifies if the naming category is valid for an assembly instance.

#### Parameter `document`

The document for the assembly instance.

#### Parameter `namingCategoryId`

The id of the naming category for the assembly instance.

#### Parameter `assemblyMemberIds`

Member ids to check validity of naming category

#### Returns

True if the naming category is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.CanRemoveElementsFromAssembly(Autodesk.Revit.DB.AssemblyInstance,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.CanRemoveElementsFromAssembly(Autodesk.Revit.DB.AssemblyInstance,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Identifies if provided assembly members can be removed from the assembly instance.

#### Parameter `assemblyInstance`

The assembly instance to remove elements from.

#### Parameter `memberIds`

Element ids to be tested for validity to remove from the assembly instance.

#### Returns

True if all member ids are valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.AreElementsValidForAssembly(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.AreElementsValidForAssembly(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if provided assembly members are valid.

#### Parameter `document`

The document.

#### Parameter `assemblyMemberIds`

Element ids to be tested for validity for membership of an assembly instance.

#### Parameter `assemblyId`

Id of the existing assembly to add components to. If invalid, the method return whether the components can be added to a new assembly

#### Returns

True if all member ids are valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.PlaceInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.PlaceInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

#### Summary

Places an assembly instance of a given assembly type at the specified location.

#### Parameter `document`

The document for the new assembly instance.

#### Parameter `assemblyTypeId`

The id of the assembly type to be used for the instance.

#### Parameter `location`

The placement location for the instance in project coordinates.

#### Returns

The newly created assembly instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyInstance.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyInstance.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new assembly instance.

#### Remarks

Transaction must be committed after calling this method before performing any action on the newly created instance.
Assembly type is assigned after the transaction for creating assembly instance is complete.

#### Parameter `document`

The document containing the elements.

#### Parameter `assemblyMemberIds`

The elements that comprise the assembly.

#### Parameter `namingCategoryId`

The naming category for the assembly instance.

#### Returns

The newly created assembly instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more element ids was not permitted for membership in the assembly instance.
Elements should be of a valid category and should not be a member of an existing assembly.
-or-
This naming category was not valid for an assembly instance containing the proposed members.
The naming category should match one of the member element categories.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyInstance.AssemblyTypeName`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyInstance.AssemblyTypeName`

#### Summary

The name for the assembly type.
All matching assembly instances share this name.
Unique assembly instances are named automatically based on their naming category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: This assembly type name is not valid for this assembly instance.
An assembly type name should be non-empty, should contain valid characters, and should be unique for its naming category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyInstance.NamingCategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyInstance.NamingCategoryId`

#### Summary

Id of the category that drives the default naming scheme for the assembly instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: This naming category was not valid for an assembly instance containing the proposed members.
The naming category should match one of the member element categories.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyInstance.Location`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyInstance.Location`

#### Summary

This property is used to find the physical location of the assembly instance within project.

#### Since

2013

#### Remarks

The Location property returns an object that can be used to find the location of an object
within the project. Assembly instances return a point location object positioned at the center of the assembly instance.

### `T:Autodesk.Revit.DB.AssemblyInstance`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyInstance`

#### Summary

Combines multiple elements for tagging, filtering, scheduling and creating isolated assembly views.

#### Since

2012

### `T:Autodesk.Revit.DB.AssemblyMemberDifferentParameters`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyMemberDifferentParameters`

#### Summary

The two assembly members being compared have different parameters

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyMemberDifferentType.TypeId2`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyMemberDifferentType.TypeId2`

#### Summary

Type id of the second assembly member

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyMemberDifferentType.TypeId1`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyMemberDifferentType.TypeId1`

#### Summary

Type id of the first assembly member

#### Since

2012

### `T:Autodesk.Revit.DB.AssemblyMemberDifferentType`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyMemberDifferentType`

#### Summary

The two assembly members being compared have different type

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyMemberDifferentCategory.CategoryId2`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyMemberDifferentCategory.CategoryId2`

#### Summary

Category id of the second assembly member

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyMemberDifferentCategory.CategoryId1`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyMemberDifferentCategory.CategoryId1`

#### Summary

Category id of the first assembly member

#### Since

2012

### `T:Autodesk.Revit.DB.AssemblyMemberDifferentCategory`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyMemberDifferentCategory`

#### Summary

The two assembly members being compared have different category

#### Since

2012

### `T:Autodesk.Revit.DB.AssemblyMemberDifferentGeometry`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyMemberDifferentGeometry`

#### Summary

The two assembly members being compared have different geometry

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyMemberDifference.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyMemberDifference.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.AssemblyMemberDifference`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyMemberDifference`

#### Summary

Class that describes difference between two assembly members

#### Remarks

Different sub-classes of this class represent different kinds of differences
between assembly members and contain additional data for each particular kind of difference.

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyDifferenceMemberDifference.MemberDifference`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyDifferenceMemberDifference.MemberDifference`

#### Summary

Difference between the assembly members

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyDifferenceMemberDifference.MemberId2`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyDifferenceMemberDifference.MemberId2`

#### Summary

Id of the member in the second assembly

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyDifferenceMemberDifference.MemberId1`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyDifferenceMemberDifference.MemberId1`

#### Summary

Id of the member in the first assembly

#### Since

2012

### `T:Autodesk.Revit.DB.AssemblyDifferenceMemberDifference`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyDifferenceMemberDifference`

#### Summary

The two assemblies being compared have different members

#### Remarks

This difference means that there is a member of the first assembly which
is different from the corresponding member of the second assembly.
Details about the difference are in memberDifference.

#### Since

2012

### `T:Autodesk.Revit.DB.AssemblyDifferenceConfiguration`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyDifferenceConfiguration`

#### Summary

The two assemblies being compared have different spatial configuration

#### Remarks

Assemblies resulting in this difference might be made up of identical elements,
but the elements are not arranged in space relative to each other in the same way.

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyDifferenceMemberCount.Count2`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyDifferenceMemberCount.Count2`

#### Summary

Number of members in the second assembly

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyDifferenceMemberCount.Count1`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyDifferenceMemberCount.Count1`

#### Summary

Number of members in the first assembly

#### Since

2012

### `T:Autodesk.Revit.DB.AssemblyDifferenceMemberCount`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyDifferenceMemberCount`

#### Summary

The two assemblies being compared have different number of members

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyDifferenceNamingCategory.NamingCategoryId2`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyDifferenceNamingCategory.NamingCategoryId2`

#### Summary

Naming category id of the second assembly

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyDifferenceNamingCategory.NamingCategoryId1`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyDifferenceNamingCategory.NamingCategoryId1`

#### Summary

Naming category id of the first assembly

#### Since

2012

### `T:Autodesk.Revit.DB.AssemblyDifferenceNamingCategory`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyDifferenceNamingCategory`

#### Summary

The two assemblies being compared have different naming categories

#### Since

2012

### `T:Autodesk.Revit.DB.AssemblyDifferenceNone`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyDifferenceNone`

#### Summary

The two assemblies being compared are identical

#### Since

2012

### `P:Autodesk.Revit.DB.AssemblyDifference.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.AssemblyDifference.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.AssemblyDifference`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyDifference`

#### Summary

Class that describes difference between two assemblies.

#### Remarks

The assembly comparison function returns a sub-class of this class.
Different sub-classes represent different kinds of differences and contain
additional data for each particular kind of difference.

#### Since

2012

### `M:Autodesk.Revit.DB.AssemblyCodeTable.GetAssemblyCodeTable(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AssemblyCodeTable.GetAssemblyCodeTable(Autodesk.Revit.DB.Document)`

#### Summary

Returns the AssemblyCodeTable for the specified document.

#### Parameter `doc`

The document owns the AssemblyCodeTable.

#### Returns

The AssemblyCodeTable for the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.AssemblyCodeTable`

Member kind: type
Symbol: `Autodesk.Revit.DB.AssemblyCodeTable`

#### Summary

AssemblyCodeTable represents the collection of ClassificationEntries for a document.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.AreaReinforcementType.CreateDefaultAreaReinforcementType(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcementType.CreateDefaultAreaReinforcementType(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new AreaReinforcementType object with a default name.

#### Parameter `aDoc`

The document.

#### Returns

The newly created type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.AreaReinforcementType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcementType`

#### Summary

An object that specifies the type of a Structural Area Reinforcement element in Autodesk Revit.

#### Remarks

The clear cover settings can be accessed via this object.

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

#### Summary

Sets Area Reinforcement to be shown unobscured in a view.

#### Parameter `view`

The view element

#### Parameter `unobscured`

True if Area Reinforcement is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This element doesn't have valid visibility data.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.IsUnobscuredInView(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.IsUnobscuredInView(Autodesk.Revit.DB.View)`

#### Summary

Checks if Area Reinforcement is shown unobscured in a view.

#### Parameter `view`

The view element

#### Returns

True if Area Reinforcement is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This element doesn't have valid visibility data.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.GetHostId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.GetHostId`

#### Summary

The element that contains the Area Reinforcement.

#### Returns

The element that the Area Reinforcement object belongs to, such as a structural
wall, floor or foundation.

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.GetBoundaryCurveIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.GetBoundaryCurveIds`

#### Summary

Retrieves the set of curves forming the boundary of the Area Reinforcement.

#### Remarks

Each ElementId in the collection is an Id of an Element of type AreaReinforcementCurve. Each element has a Curve property
to retrieve the geometric curve, together with some Parameters allowing the developer to override the clear cover side,
hook type, and hook direction of each layer of bars terminating at the curve.

#### Returns

A collection of ElementIds of AreaReinforcementCurve elements.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.SetLayerActive(System.Boolean,Autodesk.Revit.DB.Structure.AreaReinforcementLayerType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.SetLayerActive(System.Boolean,Autodesk.Revit.DB.Structure.AreaReinforcementLayerType)`

#### Summary

Sets if the desired layer is active or not.

#### Parameter `active`

True to set the layer to be active, false otherwise.

#### Parameter `layer`

The layer type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.IsLayerActive(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.IsLayerActive(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType)`

#### Summary

Identifies if the layer is active or not.

#### Parameter `layer`

The layer that will be tested.

#### Returns

Returns true if the input layer is active, false otherwise

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.GetLayerDirection(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.GetLayerDirection(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType)`

#### Summary

Gets the direction of the layer. The lines are distributed along this direction.

#### Parameter `layer`

The layer type.

#### Returns

Returns the direction of the desired layer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The layer layer isn't active.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.ResetMovedLineTransform(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.ResetMovedLineTransform(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType,System.Int32)`

#### Summary

Reset the transformation representing the movement of the line relative to its default position along the direction of the specified layer. The moved line transform will be set to Identity.

#### Parameter `layer`

The layer on which the line stays.

#### Parameter `linePositionIndex`

The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

linePositionIndex is not in the range [ 0, NumberOfLines-1 ].
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The layer layer isn't active.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This AreaReinforcement does not host Rebar.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.GetMovedLineTransform(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.GetMovedLineTransform(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType,System.Int32)`

#### Summary

Returns a transform representing the movement of the line relative to its default position along the direction of the desired layer.

#### Parameter `layer`

The layer on which the line stays.

#### Parameter `linePositionIndex`

The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).

#### Returns

The transform representing the movement of the line relative to its default position along the direction of the desired layer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

linePositionIndex is not in the range [ 0, NumberOfLines-1 ].
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The layer layer isn't active.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This AreaReinforcement does not host Rebar.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.MoveLine(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.AreaReinforcementLayerType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.MoveLine(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.AreaReinforcementLayerType,System.Int32)`

#### Summary

This method applies the translation to the line from the desired layer, at the specified position.
If the line was already moved, the method will concatenate the translation with the existing movement.
The line will be translated only along the direction of the specified layer.

#### Parameter `translation`

The translation vector.

#### Parameter `layer`

The layer on which the line stays.

#### Parameter `linePositionIndex`

The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

linePositionIndex is not in the range [ 0, NumberOfLines-1 ].
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The layer layer isn't active.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This AreaReinforcement does not host Rebar.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.IsLineIncluded(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.IsLineIncluded(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType,System.Int32)`

#### Summary

Checks whether the line from the desired layer at the specified position is included or not.

#### Parameter `layer`

The layer on which the line stays.

#### Parameter `linePositionIndex`

The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).

#### Returns

Returns true if the line from the desired layer at the specified position is included, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

linePositionIndex is not in the range [ 0, NumberOfLines-1 ].
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The layer layer isn't active.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This AreaReinforcement does not host Rebar.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.SetLineIncluded(System.Boolean,Autodesk.Revit.DB.Structure.AreaReinforcementLayerType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.SetLineIncluded(System.Boolean,Autodesk.Revit.DB.Structure.AreaReinforcementLayerType,System.Int32)`

#### Summary

Sets if the line from desired layer at the specified position is included or not.

#### Parameter `include`

True to include the line, false to exclude the line.

#### Parameter `layer`

The layer on which the line stays.

#### Parameter `linePositionIndex`

The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

linePositionIndex is not in the range [ 0, NumberOfLines-1 ].
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The layer layer isn't active.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This AreaReinforcement does not host Rebar.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.GetLineFromLayerAtIndex(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.GetLineFromLayerAtIndex(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType,System.Int32)`

#### Summary

Gets the line from the desired layer at the specified index.

#### Remarks

This method will return the line even if it isn't included.

#### Parameter `layer`

The layer on which the line stays.

#### Parameter `linePositionIndex`

The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).

#### Returns

Returns the line from the desired layer at the specified index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

linePositionIndex is not in the range [ 0, NumberOfLines-1 ].
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The layer layer isn't active.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.GetNumberOfLines(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.GetNumberOfLines(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType)`

#### Summary

Gets the number of lines on the specified layer. It also counts the excluded ones.

#### Parameter `layer`

The layer type for which will return the number of lines.

#### Returns

Returns the number of lines on the specified layer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The layer layer isn't active.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.ConvertRebarInSystemToRebars(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.AreaReinforcement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.ConvertRebarInSystemToRebars(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.AreaReinforcement)`

#### Summary

Converts all RebarInSystem elements owned by the input AreaReinforcement to equivalent Rebar elements.

#### Parameter `doc`

The document.

#### Parameter `system`

An AreaReinforcement element in the document.

#### Returns

The ids of the newly created Rebar elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element system was not found in the given document.
-or-
system does not host Rebar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.RemoveAreaReinforcementSystem(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.AreaReinforcement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.RemoveAreaReinforcementSystem(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.AreaReinforcement)`

#### Summary

Deletes the specified AreaReinforcement, and converts its RebarInSystem
elements to equivalent Rebar elements.

#### Parameter `doc`

The document.

#### Parameter `system`

An AreaReinforcement element in the document.

#### Returns

The ids of the newly created Rebar elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element system was not found in the given document.
-or-
system does not host Rebar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.GetRebarInSystemIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.GetRebarInSystemIds`

#### Summary

Returns the ids of the RebarInSystem elements owned by the AreaReinforcement
element.

#### Remarks

The RebarInSystem elements are only created if
ReinforcementSettings.HostStructuralRebar is set to true. If that setting
is false, this function returns an empty array.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new AreaReinforcement object based on a host boundary.

#### Parameter `document`

The document.

#### Parameter `hostElement`

The element that will host the AreaReinforcement. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.

#### Parameter `majorDirection`

A vector to define the major direction of the AreaReinforcement.

#### Parameter `areaReinforcementTypeId`

The id of the AreaReinforcementType.

#### Parameter `rebarBarTypeId`

The id of the RebarBarType.

#### Parameter `rebarHookTypeId`

The id of the RebarHookType.
If this parameter is InvalidElementId, it means to create a rebar with no hooks.

#### Returns

The newly created AreaReinforcement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element hostElement was not found in the given document.
-or-
the host Element is not a valid host for Area Reinforcement, Path Reinforcement, Fabric Area or Fabric Sheet.
-or-
areaReinforcementTypeId should refer to an AreaReinforcementType element.
-or-
rebarBarTypeId should refer to an RebarBarType element.
-or-
rebarHookTypeId should be invalid or refer to an RebarHookType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

majorDirection has zero length.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.AreaReinforcement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new AreaReinforcement object from an array of curves.
This method replaces the NewAreaReinforcement method, which has been deprecated.

#### Parameter `document`

The document.

#### Parameter `hostElement`

The element that will host the AreaReinforcement. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.

#### Parameter `curveArray`

An array of curves that will define the outline of the AreaReinforcement.

#### Parameter `majorDirection`

A vector to define the major direction of the AreaReinforcement.

#### Parameter `areaReinforcementTypeId`

The id of the AreaReinforcementType.

#### Parameter `rebarBarTypeId`

The id of the RebarBarType.

#### Parameter `rebarHookTypeId`

The id of the RebarHookType.
If this parameter is InvalidElementId, it means to create a rebar with no hooks.

#### Returns

The newly created AreaReinforcement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curveArray is empty.
-or-
The input curveArray contains at least one helical curve and is not supported for this operation.
-or-
The element hostElement was not found in the given document.
-or-
the host Element is not a valid host for Area Reinforcement, Path Reinforcement, Fabric Area or Fabric Sheet.
-or-
Curves in curveArray are not closed and continuous.
-or-
areaReinforcementTypeId should refer to an AreaReinforcementType element.
-or-
rebarBarTypeId should refer to an RebarBarType element.
-or-
rebarHookTypeId should be invalid or refer to an RebarHookType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

majorDirection has zero length.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.AreaReinforcement.Direction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.Direction`

#### Summary

Retrieve the Major Direction of the Area Reinforcement.

### `P:Autodesk.Revit.DB.Structure.AreaReinforcement.AreaReinforcementType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.AreaReinforcementType`

#### Summary

Retrieves the type of the Area Reinforcement.

### `P:Autodesk.Revit.DB.Structure.AreaReinforcement.AdditionalBottomCoverOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.AdditionalBottomCoverOffset`

#### Summary

Additional offset from the bottom or interior cover reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for additionalBottomCoverOffset must be no more than 30000 feet in absolute value.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.AreaReinforcement.AdditionalTopCoverOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement.AdditionalTopCoverOffset`

#### Summary

Additional offset from the top or exterior cover reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for additionalTopCoverOffset must be no more than 30000 feet in absolute value.

#### Since

2013

### `T:Autodesk.Revit.DB.Structure.AreaReinforcement`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcement`

#### Summary

An object that represents an Area Reinforcement within the Autodesk Revit project.

#### Remarks

This object derived from the Element base object and such supports all the
methods of that object such as the ability to retrieve the parameters of that object.
The Area Reinforcement element is available only in the Autodesk Revit Structure product.

### `T:Autodesk.Revit.DB.Structure.AreaReinforcementLayerType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcementLayerType`

#### Summary

Describes the layers of an Area Reinforcement

#### Since

2022

#### Since

2022

### `F:Autodesk.Revit.DB.Structure.AreaReinforcementLayerType.BottomOrBackMinor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcementLayerType.BottomOrBackMinor`

#### Summary

Reinforcement layer is on the bottom face of a floor host, or on the back face of a wall host in the minor direction.

### `F:Autodesk.Revit.DB.Structure.AreaReinforcementLayerType.BottomOrBackMajor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcementLayerType.BottomOrBackMajor`

#### Summary

Reinforcement layer is on the bottom face of a floor host, or on the back face of a wall host in the major direction.

### `F:Autodesk.Revit.DB.Structure.AreaReinforcementLayerType.TopOrFrontMinor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcementLayerType.TopOrFrontMinor`

#### Summary

Reinforcement layer is on the top face of a floor host, or on the front face of a wall host in the minor direction.

### `F:Autodesk.Revit.DB.Structure.AreaReinforcementLayerType.TopOrFrontMajor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcementLayerType.TopOrFrontMajor`

#### Summary

Reinforcement layer is on the top face of a floor host, or on the front face of a wall host in the major direction.

### `T:Autodesk.Revit.DB.Structure.AreaLoadType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AreaLoadType`

#### Summary

AreaLoadType class

### `T:Autodesk.Revit.DB.Structure.LineLoadType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LineLoadType`

#### Summary

LineLoadType class

### `T:Autodesk.Revit.DB.Structure.PointLoadType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.PointLoadType`

#### Summary

PointLoadType class

### `T:Autodesk.Revit.DB.Structure.LoadTypeBase`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LoadTypeBase`

#### Summary

The base class for LoadTypes

### `M:Autodesk.Revit.DB.Structure.AreaLoad.IsCurveLoopsInsideHostBoundaries(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.IsCurveLoopsInsideHostBoundaries(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Checks if contour loops is inside host boundaries.

#### Parameter `doc`

Document.

#### Parameter `hostId`

The id of the analytical element that is about to host a load

#### Parameter `loops`

CurveLoops to be checked.

#### Returns

Returns true if area load is positioned with entire distribution over the host, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.AreaLoad.SetLoops(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.SetLoops(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Sets curve loops that define geometry of the area load.

#### Remarks

This method works for loads which are not constrained to their host.
This method works with hosted area load only.
All previously defined reference points will be removed.
Curve Loop must be planar and not self-intersecting.

#### Parameter `doc`

The document that contains the area load.

#### Parameter `newLoops`

Loops that define new geometry of the area load.
The curve loop collection should contains a closed loops consisting of lines.

#### Returns

Returns true if successful, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One of the following requirements is not satisfied :
- curve loops newLoops are not planar
- curve loops newLoops are self-intersecting
- curve loops newLoops contains zero length curves
-or-
Thrown when newLoops collection is empty.
-or-
Thrown when newLoops contains open loop.
-or-
Thrown when newLoops contains a loop consisting of other elements then lines.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This AreaLoad is not a hosted load.
-or-
This AreaLoad is a constrained load.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.AreaLoad.GetLoops`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.GetLoops`

#### Summary

Returns curve loops that define geometry of the area load.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.AreaLoad.GetRefPoint(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.GetRefPoint(System.Int32)`

#### Summary

Returns the physical location of the reference point.

#### Remarks

The index should be between 0 and less than NumRefPoints.

#### Parameter `index`

The index of the point to return.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when index is out of range.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.AreaLoad.AreCurveLoopsValid(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.AreCurveLoopsValid(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Checks if curve loops are valid for creating an area load.

#### Parameter `loops`

The curve loops to be checked.

#### Returns

Returns true if curve loops are ok, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.AreaLoad.IsValidHostId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.IsValidHostId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Indicates if the provided host id can host area loads
The document containing both the host and the load
The id of the analytical element that is about to host an area load
True if an area load can be placed on the input host id

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AreaLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Int32},System.Collections.Generic.IList{System.Int32},Autodesk.Revit.DB.Structure.AreaLoadType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Int32},System.Collections.Generic.IList{System.Int32},Autodesk.Revit.DB.Structure.AreaLoadType)`

#### Summary

Creates a new custom area load within the project.

#### Parameter `document`

Document to which new area load will be added.

#### Parameter `hostElemId`

The analytical surface host element id for the area Load.

#### Parameter `loops`

The loops that define geometry of the area load.
The curve loop collection should contains a closed loops consisting of lines.

#### Parameter `forceVectors`

The array of force vectors applied to the maximum three reference point of the area load.

#### Parameter `refPointCurveIndexes`

The array of maximum three curve indexes on which reference points should be placed on.

#### Parameter `refPointCurveEnds`

The array of maximum three curve ends indicating where reference points should be placed on.
The array can have only 0 or 1 values, which means 0 - curve start point, 1 - curve end point.

#### Parameter `symbol`

The symbol of the AreaLoad. Set `null` to use default type.

#### Returns

If successful, returns an object of the newly created AreaLoad. `null` is returned if the operation fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

hostElemId is not permitted for this type of load.
-or-
One of the following requirements is not satisfied :
- curve loops loops are not planar
- curve loops loops are self-intersecting
- curve loops loops contains zero length curves
-or-
Thrown when force vector is equal zero.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown if the host element id is a Curved Panel.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if type could not be set for newly created area load.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.AreaLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.AreaLoadType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.AreaLoadType)`

#### Summary

Creates a new custom area load within the project.

#### Parameter `document`

Document to which new area load will be added.

#### Parameter `hostElemId`

The analytical surface host element id for the area Load.

#### Parameter `loops`

The loops that define geometry of the area load.
The curve loop collection should contains a closed loops consisting of lines.

#### Parameter `forceVector`

The force vector applied to the 1st reference point of the area load.

#### Parameter `symbol`

The symbol of the AreaLoad. Set `null` to use default type.

#### Returns

If successful, returns an object of the newly created AreaLoad. `null` is returned if the operation fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

hostElemId is not permitted for this type of load.
-or-
One of the following requirements is not satisfied :
- curve loops loops are not planar
- curve loops loops are self-intersecting
- curve loops loops contains zero length curves

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown if the host element id is a Curved Panel.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if type could not be set for newly created area load.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.AreaLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.AreaLoadType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.AreaLoadType)`

#### Summary

Creates a new hosted area load within the project.

#### Parameter `document`

Document to which new area load will be added.

#### Parameter `hostElemId`

The analytical surface host element id for the area Load.

#### Parameter `forceVector`

The force vector applied to the 1st reference point of the area load.

#### Parameter `symbol`

The symbol of the AreaLoad. Set `null` to use default type.

#### Returns

If successful, returns an object of the newly created AreaLoad. `null` is returned if the operation fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element hostElemId does not exist in the document
-or-
hostElemId is not permitted for this type of load.
-or-
Thrown when force vector is equal zero.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if type could not be set for newly created area load.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.AreaLoad.Area`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.Area`

#### Summary

Returns area of the area load.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.AreaLoad.IsProjected`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.IsProjected`

#### Summary

Indicates if the load is projected.

#### Remarks

Returns true if the area load is projected, false otherwise.
This parameter will take effect only if AreaLoad.OrientTo property is set to LoadOrientTo.Project.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.AreaLoad.NumRefPoints`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.NumRefPoints`

#### Summary

Returns the total number of reference points for the area load.

### `P:Autodesk.Revit.DB.Structure.AreaLoad.ForceVector3`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.ForceVector3`

#### Summary

The force vector applied to the 3rd reference point of the area load, oriented according to OrientTo setting.

#### Remarks

The default force unit is kN/m^2 for metric, and ksf for imperial.
Use UnitUtils class methods to convert value from or to internal units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.AreaLoad.ForceVector2`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.ForceVector2`

#### Summary

The force vector applied to the 2nd reference point of the area load, oriented according to OrientTo setting.

#### Remarks

The default force unit is kN/m^2 for metric, and ksf for imperial.
Use UnitUtils class methods to convert value from or to internal units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.AreaLoad.ForceVector1`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad.ForceVector1`

#### Summary

The force vector applied to the 1st reference point of the area load, oriented according to OrientTo setting.

#### Remarks

The default force unit is kN/m^2 for metric, and ksf for imperial.
Use UnitUtils class methods to convert value from or to internal units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.AreaLoad`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AreaLoad`

#### Summary

An object that represents a force applied across an area.

### `M:Autodesk.Revit.DB.Structure.LoadBase.RemoveHostConstraint`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadBase.RemoveHostConstraint`

#### Summary

Removes constraint from host for this load.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This LoadBase is not a constraint load.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

Thrown when the load is an AreaLoad and the host is an Analytical Panel with curved profile.

### `M:Autodesk.Revit.DB.Structure.LoadBase.IsOrientToPermitted(Autodesk.Revit.DB.Structure.LoadOrientTo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadBase.IsOrientToPermitted(Autodesk.Revit.DB.Structure.LoadOrientTo)`

#### Summary

Indicates if the provided orientation is permitted for this load.

#### Remarks

For hosted load only LoadOrientTo.Project and LoadOrientTo.HostLocalCoordinateSystem are permitted.
For non-hosted load only LoadOrientTo.Project and LoadOrientTo.WorkPlane are permitted.
To determine if load is hosted use `P:Autodesk.Revit.DB.Structure.LoadBase.IsHosted` property.

#### Parameter `orientTo`

Load orientation to check.

#### Returns

True if provided orientation type is permitted for this load, false if not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.LoadBase.OrientTo`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadBase.OrientTo`

#### Summary

The load orientation option.

#### Remarks

For hosted load only LoadOrientTo.Project and LoadOrientTo.HostLocalCoordinateSystem are permitted.
For non-hosted load only LoadOrientTo.Project and LoadOrientTo.WorkPlane are permitted.
To determine if load is hosted use `P:Autodesk.Revit.DB.Structure.LoadBase.IsHosted` property.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: orientTo is not permitted for this type of load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.LoadBase.WorkPlaneId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadBase.WorkPlaneId`

#### Summary

Id of the work plane which may determine the orientation of the load.

#### Remarks

The load might be oriented to be perpendicular to this work plane. Determine how load is oriented by checking `P:Autodesk.Revit.DB.Structure.LoadBase.OrientTo` .

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.LoadBase.HostElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadBase.HostElementId`

#### Summary

The host element ID for the load.

#### Remarks

If the load is hosted this is the id of the Analytical Element that hosts the load. If the load is not hosted, `P:Autodesk.Revit.DB.ElementId.InvalidElementId` is returned.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.LoadBase.LoadCategoryName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadBase.LoadCategoryName`

#### Summary

The name of the category to which this load belongs.

### `P:Autodesk.Revit.DB.Structure.LoadBase.LoadNatureName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadBase.LoadNatureName`

#### Summary

A string representing the nature of the load.

### `P:Autodesk.Revit.DB.Structure.LoadBase.LoadCaseName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadBase.LoadCaseName`

#### Summary

The name of the load case to which this load belongs.

### `P:Autodesk.Revit.DB.Structure.LoadBase.LoadCase`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadBase.LoadCase`

#### Summary

The load case for the load.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LoadBase.IsHosted`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadBase.IsHosted`

#### Summary

Indicates if the Load is hosted or non-hosted.

#### Remarks

True is returned when load is hosted. False is returned load is non-hosted.
To determine if load is hosted `P:Autodesk.Revit.DB.Structure.LoadBase.HostElementId` property or
`!:Autodesk::Revit::DB::Structure::LoadBase::HostElement` property may also be used.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LoadBase.IsConstrainedOnHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadBase.IsConstrainedOnHost`

#### Summary

The load is constrained to host or not.

### `P:Autodesk.Revit.DB.Structure.LoadBase.IsReaction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadBase.IsReaction`

#### Summary

The load is reaction option.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LoadBase.LoadCaseId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadBase.LoadCaseId`

#### Summary

The load case ID for the load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `T:Autodesk.Revit.DB.Structure.LoadBase`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LoadBase`

#### Summary

The LoadBase object is the base class for all load objects within the Autodesk Revit API.
Data members

#### Remarks

Load objects are only available in Autodesk Revit Structure. This object contains methods that are common to all other load objects.

### `T:Autodesk.Revit.DB.Structure.LoadOrientTo`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LoadOrientTo`

#### Summary

Specifies load orientation.

#### Since

2015

#### Since

2015

### `F:Autodesk.Revit.DB.Structure.LoadOrientTo.HostLocalCoordinateSystem`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadOrientTo.HostLocalCoordinateSystem`

#### Summary

Load is oriented in respect to it analytical host element coordinate system and will follow host changes.

### `F:Autodesk.Revit.DB.Structure.LoadOrientTo.WorkPlane`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadOrientTo.WorkPlane`

#### Summary

Load is oriented in respect to work plane.

### `F:Autodesk.Revit.DB.Structure.LoadOrientTo.Project`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadOrientTo.Project`

#### Summary

Load is oriented in respect to project global coordinate system, that is X to East, Y to North, and Z to up.

### `T:Autodesk.Revit.DB.Structure.LoadType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LoadType`

#### Summary

This enum declares types of Loads.

#### Since

2015

### `F:Autodesk.Revit.DB.Structure.LoadType.Area`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadType.Area`

#### Summary

Area Load

### `F:Autodesk.Revit.DB.Structure.LoadType.Line`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadType.Line`

#### Summary

Line Load

### `F:Autodesk.Revit.DB.Structure.LoadType.Point`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadType.Point`

#### Summary

Point Load

### `M:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.GetAnalyticalLoadScenariosData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.GetAnalyticalLoadScenariosData`

#### Summary

Gets the electrical analytical load scenarios data.

#### Returns

The electrical analytical load scenarios data.

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.CanConnectToUpstreamNode(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.CanConnectToUpstreamNode(Autodesk.Revit.DB.ElementId)`

#### Summary

Verifies that the area based load can connect to the upstream electrical analytical node.
If the area based load already has an upstream node or the upstream node is full of downstream nodes, the area based load can't connect to the upstream node.

#### Remarks

If the area based load supplies from Node A, Node A is the upstream node of the area based load, and the area based load is the downstream node of node A.

#### Parameter `upstreamNodeId`

The upstream electrical analytical node id.

#### Returns

True if the area based load can connect to the upstream electrical analytical node.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.CanDisconnectFromUpstreamNode`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.CanDisconnectFromUpstreamNode`

#### Summary

Verifies that the area based load can disconnect from the upstream electrical analytical node.
If the area based load hasn't an upstream node, it can't disconnect from the upstream node.

#### Remarks

If the area based load supplies from Node A, Node A is the upstream node of the area based load, and the area based load is the downstream node of node A.

#### Returns

True if the area based load can disconnect from the upstream electrical analytical node.

#### Since

2024

### `M:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.DisconnectFromUpstreamNode`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.DisconnectFromUpstreamNode`

#### Summary

Disconnects from an upstream electrical analytical node.

#### Remarks

If the area based load supplies from Node A, Node A is the upstream node of the area based load, and the area based load is the downstream node of node A.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The area based load can not disconnect from the upstream electrical analytical node.

#### Since

2024

### `M:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.ConnectToUpstreamNode(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.ConnectToUpstreamNode(Autodesk.Revit.DB.ElementId)`

#### Summary

Connects to an upstream electrical analytical node.

#### Remarks

If the area based load supplies from Node A, Node A is the upstream node of the area based load, and the area based load is the downstream node of node A.

#### Parameter `upstreamNodeId`

The upstream electrical analytical node id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id is not an electrical analytical node id.
-or-
The area based load can not connect to the upstream electrical analytical node.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.GetUpstreamNodeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.GetUpstreamNodeId`

#### Summary

Gets the upstream electrical analytical node id.

#### Remarks

If the area based load supplies from Node A, Node A is the upstream node of the area based load, and the area based load is the downstream node of node A.

#### Returns

The upstream node id.

#### Since

2024

### `M:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.GetElectricalLoadAreas`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.GetElectricalLoadAreas`

#### Summary

Gets electrical load areas which the area based load includes.

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.RemoveElectricalLoadArea(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.RemoveElectricalLoadArea(Autodesk.Revit.DB.ElementId)`

#### Summary

Removes electrical load area from the area based load.

#### Parameter `electricalLoadAreaId`

The electrical load area id to remove.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.AddElectricalLoadArea(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.AddElectricalLoadArea(Autodesk.Revit.DB.ElementId)`

#### Summary

Adds electrical load area into the area based load.

#### Parameter `electricalLoadAreaId`

The electrical load area id to add.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id isn't a valid electrical load area.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.Current`

#### Summary

The current of the area based load .

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.Voltage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.Voltage`

#### Summary

The voltage of the area based load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for voltage is not a number
-or-
When setting this property: The given value for voltage is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for voltage must be positive.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.ApparentPowerDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.ApparentPowerDensity`

#### Summary

The apparent power density of the area based load.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.LoadType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.LoadType`

#### Summary

The load type of the area based load.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.ApparentLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.ApparentLoad`

#### Summary

The electrical apparent load of the area based load.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.PowerFactor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.PowerFactor`

#### Summary

The power factor of the area based load.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.TrueLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.TrueLoad`

#### Summary

The electrical true load of the area based load.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.LoadClassification`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.LoadClassification`

#### Summary

The load classification of the area based load.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.LoadDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.LoadDensity`

#### Summary

The load density of the area based load.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.AreaBasedLoadType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.AreaBasedLoadType`

#### Summary

The electrical area based load type of the area based load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The id isn't a valid area based load type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadData.PhasesNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData.PhasesNumber`

#### Summary

The Phases Number of the area based load.

#### Remarks

This property is used to retrieve the Phases Number.

#### Since

2023

### `T:Autodesk.Revit.DB.Electrical.AreaBasedLoadData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadData`

#### Summary

Represents the electrical area based load data.

#### Since

2023

### `T:Autodesk.Revit.DB.Electrical.ElectricalLoadType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadType`

#### Summary

Represents the electrical load type.

#### Since

2023

### `F:Autodesk.Revit.DB.Electrical.ElectricalLoadType.AreaBasedLoad`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadType.AreaBasedLoad`

#### Summary

Area Based Load

### `F:Autodesk.Revit.DB.Electrical.ElectricalLoadType.EquipmentLoad`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadType.EquipmentLoad`

#### Summary

Equipment Load

### `P:Autodesk.Revit.DB.Mechanical.ZoneElementDomainData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneElementDomainData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Mechanical.ZoneElementDomainData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneElementDomainData`

#### Summary

A base class for specific domain requirements for a zone.

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData.GetLevelIdsInRange`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData.GetLevelIdsInRange`

#### Summary

Returns level ids between the top level and the bottom level (including the top level and the bottom level) of
the area based load boundary line.

#### Returns

The level ids between the top level and the bottom level (including the top level and the bottom level).

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData.IsElevationWithinRange(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData.IsElevationWithinRange(System.Double)`

#### Summary

Checks whether the given elevation is between the bottom level and the top level(including
the bottom level and the top level) of the area based load boundary line.

#### Parameter `elev`

The elevation value.

#### Returns

True if given elevation is between the bottom level elevation and the top level elevation, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for elev is not a number
-or-
The given value for elev is not finite

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData.IsLevelWithinRange(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData.IsLevelWithinRange(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the given level is between the bottom level and the top level (including
the bottom level and the top level) of the area based load boundary line.

#### Parameter `levelId`

The id of the Level.

#### Returns

True if given level is between the bottom level and the top level, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId levelId is not a Level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData.TopLevelId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData.TopLevelId`

#### Summary

The top level id of the area based load boundary line.

#### Remarks

The top level's elevation cannot be lower than the bottom level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The ElementId levelId cannot be used as the top level.
The ElementId levelId is not a Level or it's elevation is lower than the bottom level's elevation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData.BottomLevelId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData.BottomLevelId`

#### Summary

The bottom level id of the area based load boundary line.

#### Remarks

The bottom level's elevation cannot be higher than the top level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The ElementId levelId cannot be used as the bottom level.
The ElementId levelId is not a Level or it's elevation is higher than the top level's elevation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2023

### `T:Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData`

#### Summary

Wrapper class used to access area based load boundary line related data.

#### Since

2023

### `M:Autodesk.Revit.DB.OpenOptions.SetOpenWorksetsConfiguration(Autodesk.Revit.DB.WorksetConfiguration)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OpenOptions.SetOpenWorksetsConfiguration(Autodesk.Revit.DB.WorksetConfiguration)`

#### Summary

Sets the object used to configure the worksets to open when the model is opened.

#### Remarks

These options are ignored for non-workshared models.

#### Parameter `openConfiguration`

The options. If `null` , all user-created worksets will be opened.

#### Since

2014

### `M:Autodesk.Revit.DB.OpenOptions.GetOpenWorksetsConfiguration`

Member kind: method
Symbol: `Autodesk.Revit.DB.OpenOptions.GetOpenWorksetsConfiguration`

#### Summary

Gets the object used to configure the worksets to open when the model is opened.

#### Returns

The options. If `null` , all user-created worksets will be opened.

#### Since

2014

### `P:Autodesk.Revit.DB.OpenOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.OpenOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.OpenOptions.OpenForeignOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.OpenOptions.OpenForeignOption`

#### Summary

An option that specifies how to open files saved by an application that was not developed or licensed by Autodesk.

#### Value

The default value is OpenForeignOption.Open.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2019.2

### `P:Autodesk.Revit.DB.OpenOptions.DoNotLoadLinks`

Member kind: property
Symbol: `Autodesk.Revit.DB.OpenOptions.DoNotLoadLinks`

#### Summary

Whether or not loading links when opening the model

#### Remarks

Default behavior is to load the links

#### Since

2013

### `P:Autodesk.Revit.DB.OpenOptions.AllowOpeningLocalByWrongUser`

Member kind: property
Symbol: `Autodesk.Revit.DB.OpenOptions.AllowOpeningLocalByWrongUser`

#### Summary

Specifies whether a local file is allowed to be opened as read-only by a user other than its owner.

#### Remarks

The default is false. This option is ignored for central and non-workshared models.

#### Since

2014

### `P:Autodesk.Revit.DB.OpenOptions.Audit`

Member kind: property
Symbol: `Autodesk.Revit.DB.OpenOptions.Audit`

#### Summary

Specifies whether to expand all elements in order to check for corruption.

#### Remarks

The default is false. Setting this to true will increase the time and memory required to open the file.

#### Since

2014

### `P:Autodesk.Revit.DB.OpenOptions.IgnoreExtensibleStorageSchemaConflict`

Member kind: property
Symbol: `Autodesk.Revit.DB.OpenOptions.IgnoreExtensibleStorageSchemaConflict`

#### Summary

Specifies whether to ignore the error of schema conflict.

#### Remarks

The default is false. Setting this to true will ignore the exception of schema conflict while opening the model.
Data in the existing schema with the same ID will be erased from the model.

#### Since

2022

### `P:Autodesk.Revit.DB.OpenOptions.DetachFromCentralOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.OpenOptions.DetachFromCentralOption`

#### Summary

An option that specifies whether or not a workset-enabled document is detached from its central document.

#### Value

The default value is DetachFromCentralOption.DoNotDetach.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.OpenOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.OpenOptions.#ctor`

#### Summary

Constructs a new instance of the options class using default values.

#### Since

2013

### `T:Autodesk.Revit.DB.OpenOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.OpenOptions`

#### Summary

This class contains options available for opening a document from disk.

#### Since

2013

### `T:Autodesk.Revit.DB.OpenForeignOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.OpenForeignOption`

#### Summary

Options for opening files saved by an application that was not developed or licensed by Autodesk.

#### Since

2019.2

### `F:Autodesk.Revit.DB.OpenForeignOption.Prompt`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpenForeignOption.Prompt`

#### Summary

If possible, show a prompt to the user if a foreign file is detected. The operation may proceed or cancel based on the response.

### `F:Autodesk.Revit.DB.OpenForeignOption.DoNotOpen`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpenForeignOption.DoNotOpen`

#### Summary

Do not show any prompt to the user if a foreign file is detected. Cancel this operation (do not open the file).

### `F:Autodesk.Revit.DB.OpenForeignOption.Open`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpenForeignOption.Open`

#### Summary

Do not show any prompt to the user if a foreign file is detected. Proceed to open.

### `T:Autodesk.Revit.DB.DetachFromCentralOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.DetachFromCentralOption`

#### Summary

Options for workset detachment behavior.

#### Since

2013

### `F:Autodesk.Revit.DB.DetachFromCentralOption.ClearTransmittedSaveAsNewCentral`

Member kind: field
Symbol: `Autodesk.Revit.DB.DetachFromCentralOption.ClearTransmittedSaveAsNewCentral`

#### Summary

After opening the transmitted, workshared model, immediately resave it with its current name
and clear the transmitted flag.

### `F:Autodesk.Revit.DB.DetachFromCentralOption.DetachAndDiscardWorksets`

Member kind: field
Symbol: `Autodesk.Revit.DB.DetachFromCentralOption.DetachAndDiscardWorksets`

#### Summary

Detach the model being opened from its central model and discard worksets/worksharing.

### `F:Autodesk.Revit.DB.DetachFromCentralOption.DetachAndPreserveWorksets`

Member kind: field
Symbol: `Autodesk.Revit.DB.DetachFromCentralOption.DetachAndPreserveWorksets`

#### Summary

Detach the file being opened from its central file.

### `F:Autodesk.Revit.DB.DetachFromCentralOption.DoNotDetach`

Member kind: field
Symbol: `Autodesk.Revit.DB.DetachFromCentralOption.DoNotDetach`

#### Summary

Do not detach the file being opened from its central file.

### `M:Autodesk.Revit.DB.DefaultOpenFromCloudCallback.OnOpenConflict(Autodesk.Revit.DB.OpenConflictScenario)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefaultOpenFromCloudCallback.OnOpenConflict(Autodesk.Revit.DB.OpenConflictScenario)`

#### Summary

A method called when the conflict is happen during the model opening.

#### Parameter `scenario`

The scenario of the conflict.

#### Returns

Returns the result to indicate whether to keep the unsynchronized change, or open the latest version or cancel the open action.

#### Since

2019

### `P:Autodesk.Revit.DB.DefaultOpenFromCloudCallback.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefaultOpenFromCloudCallback.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.DefaultOpenFromCloudCallback.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefaultOpenFromCloudCallback.#ctor`

#### Summary

Create a default open callback. Open latest by default for all scenarios.

#### Since

2019

### `T:Autodesk.Revit.DB.DefaultOpenFromCloudCallback`

Member kind: type
Symbol: `Autodesk.Revit.DB.DefaultOpenFromCloudCallback`

#### Summary

A default callback that may be used to control Revit's behavior when opening a model.

#### Since

2019

### `M:Autodesk.Revit.DB.IOpenFromCloudCallbackProxy.OnOpenConflict(Autodesk.Revit.DB.OpenConflictScenario)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IOpenFromCloudCallbackProxy.OnOpenConflict(Autodesk.Revit.DB.OpenConflictScenario)`

#### Summary

A method called when the conflict is happen during the model opening.

#### Parameter `scenario`

The scenario of the conflict.

#### Returns

Returns the result to indicate whether to keep the unsynchronized change, or open the latest version or cancel the open action.

#### Since

2019

### `M:Autodesk.Revit.DB.IOpenFromCloudCallback.OnOpenConflict(Autodesk.Revit.DB.OpenConflictScenario)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IOpenFromCloudCallback.OnOpenConflict(Autodesk.Revit.DB.OpenConflictScenario)`

#### Summary

A method called when the conflict is happen during the model opening.

#### Parameter `scenario`

The scenario of the conflict.

#### Returns

Returns the result to indicate whether to keep the unsynchronized change, or open the latest version or cancel the open action.

#### Since

2019

### `T:Autodesk.Revit.DB.IOpenFromCloudCallback`

Member kind: type
Symbol: `Autodesk.Revit.DB.IOpenFromCloudCallback`

#### Summary

An interface that may be used to control Revit's behavior when opening a cloud model.

#### Since

2019

### `T:Autodesk.Revit.DB.OpenConflictResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.OpenConflictResult`

#### Since

2019

#### Summary

The result of the open conflict.

#### Since

2019

### `F:Autodesk.Revit.DB.OpenConflictResult.DetachFromCentral`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpenConflictResult.DetachFromCentral`

#### Summary

Detach the model from its central model, with worksets preserved.

### `F:Autodesk.Revit.DB.OpenConflictResult.Cancel`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpenConflictResult.Cancel`

#### Summary

Cancel the open action.

### `F:Autodesk.Revit.DB.OpenConflictResult.DiscardLocalChangesAndOpenLatestVersion`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpenConflictResult.DiscardLocalChangesAndOpenLatestVersion`

#### Summary

Discard the local changes and open the latest version of the model.

### `F:Autodesk.Revit.DB.OpenConflictResult.KeepLocalChanges`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpenConflictResult.KeepLocalChanges`

#### Summary

Keeps the local changes and open the model.

### `T:Autodesk.Revit.DB.OpenConflictScenario`

Member kind: type
Symbol: `Autodesk.Revit.DB.OpenConflictScenario`

#### Since

2019

#### Summary

The kinds of conflicts happened during open.

#### Since

2019

### `F:Autodesk.Revit.DB.OpenConflictScenario.VersionArchived`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpenConflictScenario.VersionArchived`

#### Summary

Last central version merged into the local model has been archived in the central model.

### `F:Autodesk.Revit.DB.OpenConflictScenario.OutOfDate`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpenConflictScenario.OutOfDate`

#### Summary

Model is out of date.

### `F:Autodesk.Revit.DB.OpenConflictScenario.Relinquished`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpenConflictScenario.Relinquished`

#### Summary

Ownership to model elements is relinquished.

### `F:Autodesk.Revit.DB.OpenConflictScenario.Rollback`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpenConflictScenario.Rollback`

#### Summary

Central model is restored to an earlier version.

### `M:Autodesk.Revit.DB.IFC.IFCImportOptions.SetExtraOptions(System.Collections.Generic.IDictionary{System.String,System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFC.IFCImportOptions.SetExtraOptions(System.Collections.Generic.IDictionary{System.String,System.String})`

#### Summary

Set the list of extra options to be passed into the importer. Each entry in the map is a pair of option name and value.
Note that any value here will overwrite the other values in the IFCImportOptions, if it has the same name.

#### Parameter `options`

The list of options.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018.1

### `M:Autodesk.Revit.DB.IFC.IFCImportOptions.GetExtraOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFC.IFCImportOptions.GetExtraOptions`

#### Summary

Get the list of extra options to be passed into the importer. Each entry in the map is a pair of option name and value.

#### Returns

The list of options.

#### Since

2018.1

### `M:Autodesk.Revit.DB.IFC.IFCImportOptions.GetConversionData`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFC.IFCImportOptions.GetConversionData`

#### Summary

Get the data used in the creation of the associated Revit file for an IFC link operation, if it exists.

#### Since

2015

### `P:Autodesk.Revit.DB.IFC.IFCImportOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFC.IFCImportOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.IFC.IFCImportOptions.RevitLinkFileName`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFC.IFCImportOptions.RevitLinkFileName`

#### Summary

The full path of the intermediate Revit file created during a previous link action.
This is used during "Reload From" to determine the path to the previous generated Revit file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.IFC.IFCImportOptions.CreateLinkInstanceOnly`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFC.IFCImportOptions.CreateLinkInstanceOnly`

#### Summary

Determines whether to create a linked symbol element or not.

#### Remarks

If this value is false (default), we will create a linked symbol and instance.
If this value is true, then we will re-use an existing linked symbol file and create an instance only.
The intention is for CreateLinkInstanceOnly to be true when we are trying to create a new link, when the link already exists in the host file.

#### Since

2015

### `P:Autodesk.Revit.DB.IFC.IFCImportOptions.ForceImport`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFC.IFCImportOptions.ForceImport`

#### Summary

Force the IFC file to be imported regardless of an existing corresponding Revit file.

#### Remarks

If this value is true (default), we will perform the import even if the existing corresponding Revit file is up-to-date.
If this value is false, then we will re-use an existing RVT file if it is up-to-date.
The intention is for ForceImport to be false during host file open while reloading links,
and true during link reload via the Manage Links API.

#### Since

2015

### `P:Autodesk.Revit.DB.IFC.IFCImportOptions.Action`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFC.IFCImportOptions.Action`

#### Summary

The action of the import.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `P:Autodesk.Revit.DB.IFC.IFCImportOptions.AutocorrectOffAxisLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFC.IFCImportOptions.AutocorrectOffAxisLines`

#### Summary

Enable or disable correcting lines that are slight off-axis.

#### Remarks

Enabling correcting lines that are slightly off-axis will snap lines that are close to axes
to the nearest axis. This will reduce warnings in Revit, but may cause elements that are created
from sketches to slightly change shape, and extrusions to slightly change directions.
Disabling this option will leave the original geometry intact but may cause warnings in Revit.
Default is true for Open IFC; it is ignored (and false) for Link IFC.

#### Since

2016

### `P:Autodesk.Revit.DB.IFC.IFCImportOptions.AutoJoin`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFC.IFCImportOptions.AutoJoin`

#### Summary

Enable or disable auto-join at the end of import.

#### Remarks

Enabling auto-join will join appropriate elements (e.g., walls, columns), but will take extra time and may fail.
Disabling auto-join will allow some imports that otherwise fail.
Default is true for Open IFC; it is ignored (and false) for Link IFC.

#### Since

2015

### `P:Autodesk.Revit.DB.IFC.IFCImportOptions.Intent`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFC.IFCImportOptions.Intent`

#### Summary

The intent of the import.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.IFC.IFCImportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFC.IFCImportOptions.#ctor`

#### Summary

Constructs a new IFCImportOptions using default settings.

#### Since

2015

### `T:Autodesk.Revit.DB.IFC.IFCImportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.IFC.IFCImportOptions`

#### Summary

IFC Import options.

#### Since

2015

### `T:Autodesk.Revit.DB.IFC.IFCImportAction`

Member kind: type
Symbol: `Autodesk.Revit.DB.IFC.IFCImportAction`

#### Summary

The action of the IFC import.

#### Since

2015

### `F:Autodesk.Revit.DB.IFC.IFCImportAction.Link`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFC.IFCImportAction.Link`

#### Summary

Link into an existing project file.

### `F:Autodesk.Revit.DB.IFC.IFCImportAction.Open`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFC.IFCImportAction.Open`

#### Summary

Open a new project file.

### `T:Autodesk.Revit.DB.IFC.IFCImportIntent`

Member kind: type
Symbol: `Autodesk.Revit.DB.IFC.IFCImportIntent`

#### Summary

The intent of the IFC import.

#### Since

2015

### `F:Autodesk.Revit.DB.IFC.IFCImportIntent.Reference`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFC.IFCImportIntent.Reference`

#### Summary

Imports the IFC file to serve as a reference (lightweight and accurate representations will be constructed, but they cannot be edited as standard Revit elements).

### `F:Autodesk.Revit.DB.IFC.IFCImportIntent.Parametric`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFC.IFCImportIntent.Parametric`

#### Summary

Imports the IFC file to allow for continued editing in Revit (standard Revit elements will be created).

### `M:Autodesk.Revit.DB.IFailuresProcessorProxy.Dismiss(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFailuresProcessorProxy.Dismiss(Autodesk.Revit.DB.Document)`

#### Summary

This method is being called in case of exception or document destruction to dismiss any possible pending failure UI that may
have left on the screen

#### Parameter `document`

Document for which pending failures processing UI should be dismissed

### `M:Autodesk.Revit.DB.IFailuresProcessorProxy.ProcessFailures(Autodesk.Revit.DB.FailuresAccessor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFailuresProcessorProxy.ProcessFailures(Autodesk.Revit.DB.FailuresAccessor)`

#### Summary

Method that Revit will invoke to process failures at the end of transaction.

#### Remarks

This method is invoked after some failures may have been handled by any FailuresPreprocessor
and/or FailureProcessing event subscribers.

#### Parameter `data`

Provides all necessary data to perform the resolution of failures.

#### Returns

The result of the failures processing.
Continue - Should be returned if there were no failures or highest failure severity was "Warning" and all warnings were deleted.
If some failures are still present and "Continue" is returned, it will be treated as "ProceedWithRollback".
Note: If this method has attempted to resolve failures, it should return "ProceedWithCommit"
to repeat end of transaction checks and failures processing.

ProceedWithCommit - End of transaction checks and failure processing will restart from the beginning.
If some failures were resolved, they will be removed and not delivered to the user.
ProceedWithCommit cannot be returned if transaction is being rolled back.

ProceedWithRollBack - Transaction will be rolled back even if Commit was originally requested.

WaitForUserInput - Should be returned if method has activated modeless user interaction and is waiting for an external event
(typically user input) to complete failures processing.

### `M:Autodesk.Revit.DB.IFailuresProcessor.Dismiss(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFailuresProcessor.Dismiss(Autodesk.Revit.DB.Document)`

#### Summary

This method is being called in case of exception or document destruction to dismiss any possible pending failure UI that may
have left on the screen

#### Parameter `document`

Document for which pending failures processing UI should be dismissed

### `M:Autodesk.Revit.DB.IFailuresProcessor.ProcessFailures(Autodesk.Revit.DB.FailuresAccessor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFailuresProcessor.ProcessFailures(Autodesk.Revit.DB.FailuresAccessor)`

#### Summary

Method that Revit will invoke to process failures at the end of transaction.

#### Remarks

This method is invoked after some failures may have been handled by any FailuresPreprocessor
and/or FailureProcessing event subscribers.

#### Parameter `data`

Provides all necessary data to perform the resolution of failures.

#### Returns

The result of the failures processing.
Continue - Should be returned if there were no failures or highest failure severity was "Warning" and all warnings were deleted.
If some failures are still present and "Continue" is returned, it will be treated as "ProceedWithRollback".
Note: If this method has attempted to resolve failures, it should return "ProceedWithCommit"
to repeat end of transaction checks and failures processing.

ProceedWithCommit - End of transaction checks and failure processing will restart from the beginning.
If some failures were resolved, they will be removed and not delivered to the user.
ProceedWithCommit cannot be returned if transaction is being rolled back.

ProceedWithRollBack - Transaction will be rolled back even if Commit was originally requested.

WaitForUserInput - Should be returned if method has activated modeless user interaction and is waiting for an external event
(typically user input) to complete failures processing.

### `T:Autodesk.Revit.DB.IFailuresProcessor`

Member kind: type
Symbol: `Autodesk.Revit.DB.IFailuresProcessor`

#### Summary

To create your own UI or fully automated tool to process Revit Failures, derive a class from this interface.

#### Remarks

To override Revit default Failures Processing UI, instantiate your own processor derived from this interface
and register it in Revit application.

### `M:Autodesk.Revit.DB.FailureDefinitionRegistry.ListAllFailureDefinitions`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureDefinitionRegistry.ListAllFailureDefinitions`

#### Summary

Retrieves all the registered FailureDefinitions.

#### Returns

All the registered FailureDefinitions.

#### Since

2011

### `M:Autodesk.Revit.DB.FailureDefinitionRegistry.FindFailureDefinition(Autodesk.Revit.DB.FailureDefinitionId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureDefinitionRegistry.FindFailureDefinition(Autodesk.Revit.DB.FailureDefinitionId)`

#### Summary

Finds a specific FailureDefinition by a given FailureDefinitionId.

#### Parameter `id`

The id of the FailureDefinition.

#### Returns

The accessor of the found FailureDefinition, or null, if the FailureDefinition was not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.FailureDefinitionRegistry.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FailureDefinitionRegistry.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FailureDefinitionRegistry`

Member kind: type
Symbol: `Autodesk.Revit.DB.FailureDefinitionRegistry`

#### Summary

The global registry for all FailureDefinitions in the Revit session.

#### Remarks

When a FailureDefinition is created, it will be registered in this registry automatically.
Registration is allowed only during Revit Application startup - after that FailureDefinitionRegistry is locked
and creation of new FailureDefinitions is not allowed.
There is only one instance of FailureDefinitionRegistry in session.
`M:Autodesk.Revit.ApplicationServices.Application.GetFailureDefinitionRegistry`

#### Since

2011

### `M:Autodesk.Revit.DB.AppearanceAssetElement.GetRenderingAsset`

Member kind: method
Symbol: `Autodesk.Revit.DB.AppearanceAssetElement.GetRenderingAsset`

#### Summary

Gets the rendering asset for the appearance asset element.

#### Remarks

The retrieved Asset may be empty if it is loaded from material library without any modification.
In this case, you can use Application.GetAssets(AssetType.Appearance) to load all preset appearance assets, and retrieve the asset by its name.

#### Returns

The rendering asset held by this appearance asset element.

#### Since

2014

### `M:Autodesk.Revit.DB.AppearanceAssetElement.SetRenderingAsset(Autodesk.Revit.DB.Visual.Asset)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AppearanceAssetElement.SetRenderingAsset(Autodesk.Revit.DB.Visual.Asset)`

#### Summary

Sets the rendering asset for the appearance asset element.

#### Parameter `asset`

The new rendering asset. It should be an appearance asset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The asset is not an appearance asset.

#### Since

2014

### `M:Autodesk.Revit.DB.AppearanceAssetElement.Duplicate(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AppearanceAssetElement.Duplicate(System.String)`

#### Summary

Duplicates the appearance asset element.

#### Remarks

The asset contained by this element will be duplicated as well. Changes to the duplicated element or its asset do not affect the original element and asset.

#### Parameter `name`

Name of the new appearance asset element - this name must be correctly structured for Revit use and not duplicate the name
of another appearance asset in the document.

#### Returns

The new AppearanceAssetElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
The given value for name is already in use as an appearance asset name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018.1

### `M:Autodesk.Revit.DB.AppearanceAssetElement.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Visual.Asset)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AppearanceAssetElement.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Visual.Asset)`

#### Summary

Creates a new AppearanceAssetElement from an existing rendering asset.

#### Parameter `document`

The document in which to create the AppearanceAssetElement.

#### Parameter `name`

The name of the AppearanceAssetElement.

#### Parameter `asset`

The rendering asset of the element.

#### Returns

The new AppearanceAssetElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
The given value for name is already in use as an appearance asset name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.AppearanceAssetElement.GetAppearanceAssetElementByName(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AppearanceAssetElement.GetAppearanceAssetElementByName(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Gets an AppearanceAssetElement by name.

#### Parameter `doc`

Document containing the AppearanceAssetElement.

#### Parameter `name`

Name of the AppearanceAssetElement.

#### Returns

The AppearanceAssetElement with the given name, or `null` if this element does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.AppearanceAssetElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.AppearanceAssetElement`

#### Summary

An element that contains a rendering asset used as a portion of a material definition.

#### Since

2014

### `M:adp.IDesignPropertyUnits.Dispose`

Member kind: method
Symbol: `adp.IDesignPropertyUnits.Dispose`

### `T:adp.IDesignPropertyUnits`

Member kind: type
Symbol: `adp.IDesignPropertyUnits`

### `M:autodesk.platform.core.string.IString.#ctor`

Member kind: method
Symbol: `autodesk.platform.core.string.IString.#ctor`

### `M:autodesk.platform.core.string.IString.detach`

Member kind: method
Symbol: `autodesk.platform.core.string.IString.detach`

### `M:autodesk.platform.core.string.IString.isEmpty`

Member kind: method
Symbol: `autodesk.platform.core.string.IString.isEmpty`

### `M:autodesk.platform.core.string.IString.length`

Member kind: method
Symbol: `autodesk.platform.core.string.IString.length`

#### B

strlen

#### B

wcslen

#### B

char*

### `M:autodesk.platform.core.string.IString.bytes`

Member kind: method
Symbol: `autodesk.platform.core.string.IString.bytes`

### `M:autodesk.platform.core.string.IString.set(autodesk.platform.core.string.IString!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `autodesk.platform.core.string.IString.set(autodesk.platform.core.string.IString!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:autodesk.platform.core.string.IString.Dispose`

Member kind: method
Symbol: `autodesk.platform.core.string.IString.Dispose`

### `T:autodesk.platform.core.string.IString`

Member kind: type
Symbol: `autodesk.platform.core.string.IString`

### `T:_finddata32_t`

Member kind: type
Symbol: `_finddata32_t`

### `M:Autodesk.Revit.DB.Visual.AppearanceAssetEditScope.Commit(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AppearanceAssetEditScope.Commit(System.Boolean)`

#### Summary

Finishes the edit scope.

#### Remarks

All the changes made after starting the EditScope will be committed. Changes will be merged into one transaction.
If the appearance asset element is used in one or more materials, they will be updated to match any changes made.
Open views may not redraw after changes. View update can be forced with the input argument, but doing so can be an expensive operation.
Consider using false if immediate update is not needed or if multiple calls to this method are used in a loop.

#### Parameter `updateOpenViews`

When true, force update of the open views.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

EditScope is not active. EditScope can only be committed or cancelled when it is active.
-or-
EditScope cannot be closed, there is no opened transaction.
-or-
The editable asset is not valid.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Visual.AppearanceAssetEditScope.Cancel`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AppearanceAssetEditScope.Cancel`

#### Summary

Cancels the edit scope.

#### Remarks

All the changes made after starting the EditScope will be discarded.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

EditScope is not active. EditScope can only be committed or cancelled when it is active.
-or-
EditScope cannot be closed, there is no opened transaction.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Visual.AppearanceAssetEditScope.Start(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AppearanceAssetEditScope.Start(Autodesk.Revit.DB.ElementId)`

#### Summary

Starts the edit scope.

#### Parameter `assetElementId`

The appearance asset element whose asset should be edited.

#### Returns

The appearance asset to be used for editing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.AppearanceAssetEditScope.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.AppearanceAssetEditScope.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Visual.AppearanceAssetEditScope.IsActive`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.AppearanceAssetEditScope.IsActive`

#### Summary

Identifies if the EditScope is active. In other words, the EditScope has started but not committed/canceled yet.

#### Remarks

Starting the edit scope is not permitted when it is active.
Canceling/committing is not allowed when the edit scope is not active.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Visual.AppearanceAssetEditScope.#ctor(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AppearanceAssetEditScope.#ctor(Autodesk.Revit.DB.Document)`

#### Summary

Constructs a new instance of an AppearanceAssetEditScope.

#### Parameter `document`

The document for which this EditScope is going to be used.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.AppearanceAssetEditScope`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.AppearanceAssetEditScope`

#### Summary

A scope object that provides special access and limitations related to editing appearance assets and their related elements.

#### Remarks

You can use an AppearanceAssetEditScope to modify the values of the properties of appearance assets and connected assets (such as bitmaps). The following restrictions apply:
A single edit scope is allowed only to edit one top level rendering assets (and its connected assets). To edit more than one appearance asset you must start a different edit scope.

An edit scope may be reused for editing another asset, so long as it has been committed or canceled before using start to associate it to a new asset.

Multiple changes to the asset are allowed before commit.

A transaction must be started before using Commit() on the edited asset. The transaction may be opened before or after the edit scope is started, but must be open to allow the changes into the model.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Arc.Create(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Arc.Create(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new geometric arc object based on three points.

#### Parameter `end0`

The start point of the arc.

#### Parameter `end1`

The end point of the arc.

#### Parameter `pointOnArc`

A point on the arc.

#### Returns

The new arc.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The vectors end0 and end1 are coincident.
-or-
The vectors end0 and pointOnArc are coincident.
-or-
The vectors end1 and pointOnArc are coincident.
-or-
Cannot create an arc.
-or-
Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Since

2014

### `M:Autodesk.Revit.DB.Arc.Create(Autodesk.Revit.DB.Plane,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Arc.Create(Autodesk.Revit.DB.Plane,System.Double,System.Double,System.Double)`

#### Summary

Creates a new geometric arc object based on plane, radius, and angles.

#### Remarks

If the angle range is equal to or greater than 2 * PI, the curve will be
automatically converted to an unbounded circle.

#### Parameter `plane`

The plane which the arc resides. The plane's origin is the center of the arc.

#### Parameter `radius`

The radius of the arc.

#### Parameter `startAngle`

The start angle of the arc (in radians).

#### Parameter `endAngle`

The end angle of the arc (in radians).

#### Returns

The new arc.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for radius must be greater than 0 and no more than 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Start angle must be less than end angle.
-or-
Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Since

2014

### `M:Autodesk.Revit.DB.Arc.Create(Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Arc.Create(Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new geometric arc object based on center, radius, unit vectors, and angles.

#### Remarks

If the angle range is equal to or greater than 2 * PI, the curve will be
automatically converted to an unbounded circle.

#### Parameter `center`

The center of the arc.

#### Parameter `radius`

The radius of the arc.

#### Parameter `startAngle`

The start angle of the arc (in radians).

#### Parameter `endAngle`

The end angle of the arc (in radians).

#### Parameter `xAxis`

The x axis to define the arc plane. Must be normalized.

#### Parameter `yAxis`

The y axis to define the arc plane. Must be normalized.

#### Returns

The new arc.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

xAxis is not length 1.0.
-or-
yAxis is not length 1.0.
-or-
The given value for radius must be between 0 and 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The vectors xAxis and yAxis are not perpendicular.
-or-
Start angle must be less than end angle.
-or-
Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Since

2014

### `P:Autodesk.Revit.DB.Arc.Radius`

Member kind: property
Symbol: `Autodesk.Revit.DB.Arc.Radius`

#### Summary

Returns the radius of the arc.

### `P:Autodesk.Revit.DB.Arc.YDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.Arc.YDirection`

#### Summary

Returns the Y direction.

### `P:Autodesk.Revit.DB.Arc.XDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.Arc.XDirection`

#### Summary

Returns the X direction.

### `P:Autodesk.Revit.DB.Arc.Normal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Arc.Normal`

#### Summary

Returns the normal to the plane in which the arc is defined.

### `P:Autodesk.Revit.DB.Arc.Center`

Member kind: property
Symbol: `Autodesk.Revit.DB.Arc.Center`

#### Summary

Returns the center of the arc.

### `T:Autodesk.Revit.DB.Arc`

Member kind: type
Symbol: `Autodesk.Revit.DB.Arc`

#### Summary

A circular arc.

#### Remarks

The arc lies in the plane defined by center and normal.

### `M:Autodesk.Revit.DB.DimensionType.CanHaveOrdinateDimensionSetting`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionType.CanHaveOrdinateDimensionSetting`

#### Summary

Checks whether this DimensionType can have an ordinate dimension settings.

#### Remarks

It returns true when the DimensionType is linear and when Dimension String Type parameter is set to Ordinate.

#### Returns

True when the DimensionType is linear and the Dimension String Type parameter is ordinate, false otherwise.

### `M:Autodesk.Revit.DB.DimensionType.SetOrdinateDimensionSetting(Autodesk.Revit.DB.OrdinateDimensionSetting)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionType.SetOrdinateDimensionSetting(Autodesk.Revit.DB.OrdinateDimensionSetting)`

#### Summary

Sets the ordinate dimension settings for this DimensionType.

#### Parameter `ordinateDimSetting`

The new ordinate dimension settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The origin tick mark id in the Ordinate Dimension Setting is invalid for the dimension style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This DimensionType cannot be assigned ordinate dimension settings, as it is not a linear DimensionType or its Dimension String Type parameter is not set to Ordinate.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.DimensionType.GetOrdinateDimensionSetting`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionType.GetOrdinateDimensionSetting`

#### Summary

Gets the ordinate dimension settings for this DimensionType.

#### Returns

The ordinate dimension settings.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.DimensionType.CanHaveEqualityFormula`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionType.CanHaveEqualityFormula`

#### Summary

Checks whether this DimensionType can have an equality formula.

#### Remarks

Equality formulas can be used for continuous linear or angular dimension types.

#### Returns

True when the DimensionType is continuous linear or angular, false otherwise

### `M:Autodesk.Revit.DB.DimensionType.SetEqualityFormula(System.Collections.Generic.IList{Autodesk.Revit.DB.DimensionEqualityLabelFormatting})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionType.SetEqualityFormula(System.Collections.Generic.IList{Autodesk.Revit.DB.DimensionEqualityLabelFormatting})`

#### Summary

Sets an ordered list of the entries to use in the equality formula definition.

#### Parameter `formattingArr`

An ordered list of the entries to use in the equality formula definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input equality formula entries are not valid for use in the given DimensionType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.DimensionType.GetEqualityFormula`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionType.GetEqualityFormula`

#### Summary

Gets an ordered list of the entries in the equality formula definition.

#### Returns

An ordered list of the entries in the equality formula definition.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The given DimensionType cannot be assigned an equality formula as it is not continuous linear or angular.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.DimensionType.GetSpecTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionType.GetSpecTypeId`

#### Summary

Gets the spec of this dimension style.

#### Remarks

The spec will represent either length, angle or slope.

#### Returns

Identifier of the spec.

### `M:Autodesk.Revit.DB.DimensionType.SetUnitsFormatOptions(Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionType.SetUnitsFormatOptions(Autodesk.Revit.DB.FormatOptions)`

#### Summary

Sets the FormatOptions to optionally override the default settings in the Units class for the units value.

#### Remarks

See the UnitType property to determine the unit type of this dimension style.

#### Parameter `formatOptions`

The FormatOptions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The display unit in formatOptions is not a valid display unit for the unit type of this DimensionType, or the rounding method in formatOptions is not set to Nearest. See UnitUtils.IsValidDisplayUnit(UnitType, DisplayUnitType), UnitUtils.GetValidDisplayUnits(UnitType) and FormatOptions.RoundingMethod.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.DimensionType.GetUnitsFormatOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionType.GetUnitsFormatOptions`

#### Summary

Gets the FormatOptions to optionally override the default settings in the Units class for the units value.

#### Returns

A copy of the FormatOptions.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.DimensionType.SetAlternateUnitsFormatOptions(Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionType.SetAlternateUnitsFormatOptions(Autodesk.Revit.DB.FormatOptions)`

#### Summary

Sets the FormatOptions to optionally override the default settings in the Units class for the alternate units value.

#### Remarks

See the UnitType property to determine the unit type of this dimension style.

#### Parameter `formatOptions`

The FormatOptions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The display unit in formatOptions is not a valid display unit for the unit type of this DimensionType, or the rounding method in formatOptions is not set to Nearest. See UnitUtils.IsValidDisplayUnit(UnitType, DisplayUnitType), UnitUtils.GetValidDisplayUnits(UnitType) and FormatOptions.RoundingMethod.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.DimensionType.GetAlternateUnitsFormatOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionType.GetAlternateUnitsFormatOptions`

#### Summary

Gets the FormatOptions to optionally override the default settings in the Units class for the alternate units value.

#### Returns

A copy of the FormatOptions.

### `P:Autodesk.Revit.DB.DimensionType.Suffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionType.Suffix`

#### Summary

The suffix text for the dimension value.

#### Remarks

The text goes immediately after the value and is not overridden by the possible instance suffix.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.DimensionType.Prefix`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionType.Prefix`

#### Summary

The prefix text for the dimension value.

#### Remarks

The text goes immediately before the value and is not overridden by the possible instance prefix.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.DimensionType.AlternateUnitsSuffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionType.AlternateUnitsSuffix`

#### Summary

The suffix text for the alternate units value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.DimensionType.AlternateUnitsPrefix`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionType.AlternateUnitsPrefix`

#### Summary

The prefix text for the alternate units value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.DimensionType.AlternateUnits`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionType.AlternateUnits`

#### Summary

The alternate units display mode for this DimensionType.

#### Value

Alternate units let dimensions display values in multiple units.
For example, for a dimension which shows its values in imperial units,
alternate units can be used to repeat those values in metric units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.DimensionType.StyleType`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionType.StyleType`

#### Summary

The dimension style type of this DimensionType.

### `T:Autodesk.Revit.DB.DimensionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.DimensionType`

#### Summary

An object that represents a dimension style.

### `T:Autodesk.Revit.DB.DimensionStyleType`

Member kind: type
Symbol: `Autodesk.Revit.DB.DimensionStyleType`

#### Summary

An enumerated type containing possible style types of dimensions.

### `F:Autodesk.Revit.DB.DimensionStyleType.AlignmentStationLabel`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionStyleType.AlignmentStationLabel`

#### Summary

Alignment Station Label

### `F:Autodesk.Revit.DB.DimensionStyleType.Diameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionStyleType.Diameter`

#### Summary

Diameter dimension.

### `F:Autodesk.Revit.DB.DimensionStyleType.SpotSlope`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionStyleType.SpotSlope`

#### Summary

SpotSlope

### `F:Autodesk.Revit.DB.DimensionStyleType.LinearFixed`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionStyleType.LinearFixed`

#### Summary

LinearFixed dimension, which is linear dimension whose direction is parallel to X or Y.

### `F:Autodesk.Revit.DB.DimensionStyleType.SpotCoordinate`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionStyleType.SpotCoordinate`

#### Summary

SpotCoordinate

### `F:Autodesk.Revit.DB.DimensionStyleType.SpotElevation`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionStyleType.SpotElevation`

#### Summary

SpotElevation

### `F:Autodesk.Revit.DB.DimensionStyleType.ArcLength`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionStyleType.ArcLength`

#### Summary

ArcLength dimension.

### `F:Autodesk.Revit.DB.DimensionStyleType.Radial`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionStyleType.Radial`

#### Summary

Radial dimension.

### `F:Autodesk.Revit.DB.DimensionStyleType.Angular`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionStyleType.Angular`

#### Summary

Angular dimension.

### `F:Autodesk.Revit.DB.DimensionStyleType.Linear`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionStyleType.Linear`

#### Summary

Linear dimension.

### `M:Autodesk.Revit.DB.AngularDimension.SetAngularRadius(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AngularDimension.SetAngularRadius(System.Double)`

#### Summary

Set radius of an Angular Dimension arc.
The new radius of the arc.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for radius must be non-negative.

#### Since

2017

### `M:Autodesk.Revit.DB.AngularDimension.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.Arc,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference},Autodesk.Revit.DB.DimensionType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AngularDimension.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.Arc,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference},Autodesk.Revit.DB.DimensionType)`

#### Summary

Creates a new instance of an Angular Dimension element within the project.

#### Parameter `document`

The document where new Angular Dimension is created.

#### Parameter `dbView`

The view in which the Angular Dimension will appear.

#### Parameter `arc`

Arc for the Angular Dimension.

#### Parameter `references`

The references which the Angular Dimension will witness.

#### Parameter `dimensionStyle`

Dimension Style.

#### Returns

The newly created Angular Dimension instance, or `null` if the operation fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

References should be: at least two, non parallel and rays of the arc passed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2017

### `T:Autodesk.Revit.DB.AngularDimension`

Member kind: type
Symbol: `Autodesk.Revit.DB.AngularDimension`

#### Summary

An object that represents an Angular Dimension within the Revit project.

#### Since

2017

### `M:Autodesk.Revit.DB.Dimension.GenerateDimensionGeometry(Autodesk.Revit.DB.DimensionGeometryOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Dimension.GenerateDimensionGeometry(Autodesk.Revit.DB.DimensionGeometryOptions)`

#### Summary

Generates Dimension geometry that is computed based on the provided input.

#### Remarks

A new dimension element will not be added into document.

Use concrete instances of the `T:Autodesk.Revit.DB.DimensionGeometryOptions` to produce different types of dimension geometry:

`!:LinearDimensionGeometryOptions` for linear dimension.
`!:AngularDimensionGeometryOptions` for angular dimension.
`!:RadialDimensionGeometryOptions` for radial dimension.
`!:DiameterDimensionGeometryOptions` for diameter dimension.
`!:ArcLengthDimensionGeometryOptions` for arc length dimension.

#### Parameter `options`

The options that will be used to compute the Dimension geometry.

#### Returns

Returns Dimension geometry that is computed based on the provided input.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Dimension.HasOneSegment`

Member kind: method
Symbol: `Autodesk.Revit.DB.Dimension.HasOneSegment`

#### Summary

Determines whether a dimension has one segment.

#### Since

2021.1

### `M:Autodesk.Revit.DB.Dimension.IsTextPositionAdjustable`

Member kind: method
Symbol: `Autodesk.Revit.DB.Dimension.IsTextPositionAdjustable`

#### Summary

Indicates if this dimension is supported to set/get TextPosition/LeaderEndPosition.

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.DB.Dimension.ResetTextPosition`

Member kind: method
Symbol: `Autodesk.Revit.DB.Dimension.ResetTextPosition`

#### Summary

Resets the text position of the dimension to the initial position determined by its type and parameters.

#### Remarks

The initial point is the text position determined by the type and parameters of the dimension.
This property is for use with single-segment dimensions only.
For multi-segment dimensions use the corresponding method of the
DimensionSegment class.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when:
SpotDimension has more than one segments.

### `P:Autodesk.Revit.DB.Dimension.IsValid`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.IsValid`

#### Summary

Indicates if this dimension is valid.

#### Remarks

This property always returns true for model dimensions.
It can return false for view-specific dimensions that are hidden
because they are in an invalid state. An example of an invalid
state is having misaligned references for an aligned dimension.

#### Since

2019

### `P:Autodesk.Revit.DB.Dimension.AreReferencesAvailable`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.AreReferencesAvailable`

#### Summary

Indicates if this dimension's references can be resolved.

#### Remarks

This property always returns true for model dimensions.
It can return false for view-specific dimensions that can lose their
references in certain situations. For example, the host element
references may not be available when the view containing the
dimension is closed. In general, if the host element view-specific
geometry is not available, dimensions that reference that geometry
will not be able to resolve their references.

#### Since

2019

### `P:Autodesk.Revit.DB.Dimension.TextPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.TextPosition`

#### Summary

The position of the dimension text's drag point.

#### Remarks

This property is not applicable to all dimensions.
For example, it is not available for spot slope dimensions, multi-segments dimensions,
dimensions using equality formula, and when dimension style is ordinate.

If the position is not applicable, this property throws InvalidOperationException.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when:
SpotDimension style type is SpotSlope.Using equality formula.Dimension style is ordinate.
-or-
Thrown when:
SpotDimension has more than one segments.
-or-

#### Since

2015 Subscription Update

### `P:Autodesk.Revit.DB.Dimension.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.Origin`

#### Summary

The dimension origin.

#### Remarks

The origin is the middle point of the dimension line that makes up the dimension.
This property is for use with single-segment dimensions only.
For multi-segment dimensions use the corresponding property of the
DimensionSegment class.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when:
SpotDimension has more than one segments.

#### Since

2015 Subscription Update

### `P:Autodesk.Revit.DB.Dimension.LeaderEndPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.LeaderEndPosition`

#### Summary

The position of the dimension's leader end point.

#### Remarks

This property is not applicable to all dimensions.
For example, it is not available for spot slope dimensions, multi-segments dimensions,
dimensions using equality formula, and when dimension style is ordinate.

If the position is not applicable, this property throws InvalidOperationException.

Notes for SpotDimension:
This property throws InvalidOperationException if dimension has no leader.Setting of this property works differently for leader with and without shoulder.If leader has shoulder, setting is limited by points on line between leader end and shoulder points (projected point is used).Setting of this property also affects TextPosition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Dimension must have leader.
-or-
Thrown when:
SpotDimension style type is SpotSlope.Using equality formula.Dimension style is ordinate.
-or-
Thrown when:
SpotDimension has more than one segments.
-or-

#### Since

2015 Subscription Update

### `P:Autodesk.Revit.DB.Dimension.HasLeader`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.HasLeader`

#### Summary

True if dimension has leader, false otherwise.

#### Since

2021.1

### `P:Autodesk.Revit.DB.Dimension.MultiReferenceAnnotationId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.MultiReferenceAnnotationId`

#### Summary

The multi-reference annotation which owns this dimension.

#### Value

InvalidElementId if this dimension is not part of a multi-reference annotation.

#### Since

2014

### `P:Autodesk.Revit.DB.Dimension.ValueOverride`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.ValueOverride`

#### Summary

The text that replaces the segment's value.

#### Remarks

This property is for use with single-segment dimensions only.
For multi-segment dimensions use the corresponding properties of the
DimensionSegment class.

### `P:Autodesk.Revit.DB.Dimension.Below`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.Below`

#### Summary

The text shown below the segment's value.

#### Remarks

This property is for use with single-segment dimensions only.
For multi-segment dimensions use the corresponding properties of the
DimensionSegment class.

### `P:Autodesk.Revit.DB.Dimension.Above`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.Above`

#### Summary

The text shown above the segment's value.

#### Remarks

This property is for use with single-segmment dimensions only.
For multi-segment dimensions use the corresponding properties of the
DimensionSegment class.

### `P:Autodesk.Revit.DB.Dimension.Suffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.Suffix`

#### Summary

The text shown after the segment's value.

#### Remarks

This property is for use with single-segmment dimensions only.
For multi-segment dimensions use the corresponding properties of the
DimensionSegment class.

### `P:Autodesk.Revit.DB.Dimension.Prefix`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.Prefix`

#### Summary

The text shown before the segment's value.

#### Remarks

This property is for use with single-segmment dimensions only.
For multi-segment dimensions use the corresponding properties of the
DimensionSegment class.

### `P:Autodesk.Revit.DB.Dimension.IsLocked`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.IsLocked`

#### Summary

Indicates if this dimension is locked.

#### Remarks

This property always returns false if the dimension
is a radial or spot dimension.
This property cannot be set if the dimension has been labeled,
or if the dimension shape is arc-length, radial, diameter or spot,
or if the dimension is linear with more than one segment.

### `P:Autodesk.Revit.DB.Dimension.ValueString`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.ValueString`

#### Summary

The dimension value as a user visible string.

#### Remarks

This property always return `null` if this is a spot dimension,
or it is a linear dimension with more than one segments.

### `P:Autodesk.Revit.DB.Dimension.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.Value`

#### Summary

The value of the dimension.

#### Remarks

This nullable property will not have a value for spot dimensions
or for linear dimensions with more than one segment.

### `P:Autodesk.Revit.DB.Dimension.AreSegmentsEqual`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.AreSegmentsEqual`

#### Summary

Indicates if all segments are forced to be equal.

#### Remarks

This property is usable only for linear dimensions with more
than one segment.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the dimension is non-linear or has only one segment.

### `P:Autodesk.Revit.DB.Dimension.Segments`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.Segments`

#### Summary

The segments in the dimension.

#### Remarks

Returns a read only array of segments in the dimension.
The references of the dimension can be mapped to segments in order.
The first segment here wrapped by first and second references;
the nth segment is wrapped by nth and n+1st references.

### `P:Autodesk.Revit.DB.Dimension.NumberOfSegments`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.NumberOfSegments`

#### Summary

The number of segments for the dimension.

### `P:Autodesk.Revit.DB.Dimension.DimensionShape`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.DimensionShape`

#### Summary

The shape of this dimension.

### `P:Autodesk.Revit.DB.Dimension.FamilyLabel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.FamilyLabel`

#### Summary

The family parameter label of the dimension.

#### Remarks

A dimension only can be labeled to a family parameter in a family document.
When the dimension is labeled by a reporting parameter, the dimension value drives the parameter value.
When the parameter is labeled by a non-reporting, the value of the parameter drives the dimension.
If the dimension is multi-segmented, each segment of the dimension is driven by the same parameter value.
Multi-segmented dimensions cannot be labeled by reporting parameters.
To unbind the family parameter, set this property to `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the family parameter's ParameterType is not suitable for this dimension.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when dimension can not be labeled.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when failed to get the BuiltInParameter DIM_LABEL.

#### Since

2014

### `P:Autodesk.Revit.DB.Dimension.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.Name`

#### Summary

Retrieves or changes the name associated with the Dimension.

#### Remarks

The property inherited from element is hidden, a System.InvalidOperationException
is thrown.

### `P:Autodesk.Revit.DB.Dimension.DimensionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.DimensionType`

#### Summary

The dimension style of this dimension.

### `P:Autodesk.Revit.DB.Dimension.View`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.View`

#### Summary

Supplies the view that contains the dimension if the dimension is view specific.

### `P:Autodesk.Revit.DB.Dimension.Curve`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.Curve`

#### Summary

A curve that represents the dimension line.

### `P:Autodesk.Revit.DB.Dimension.References`

Member kind: property
Symbol: `Autodesk.Revit.DB.Dimension.References`

#### Summary

Returns an array of geometric references to which the dimension is attached.

### `T:Autodesk.Revit.DB.Dimension`

Member kind: type
Symbol: `Autodesk.Revit.DB.Dimension`

#### Summary

An object that represents a dimension within the Revit project.

### `P:Autodesk.Revit.DB.Electrical.AnalyticalTransferSwitchData.TotalConnectedCurrent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalTransferSwitchData.TotalConnectedCurrent`

#### Summary

The total connected current of the electrical analytical transfer switch.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalTransferSwitchData.CurrentRating`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalTransferSwitchData.CurrentRating`

#### Summary

The current rating value of the electrical analytical transfer switch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for rating is not a number
-or-
When setting this property: The given value for rating is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for rating must be non-negative.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalTransferSwitchData.Voltage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalTransferSwitchData.Voltage`

#### Summary

The voltage value of the electrical analytical transfer switch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for voltage is not a number
-or-
When setting this property: The given value for voltage is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for voltage must be positive.

#### Since

2023

### `T:Autodesk.Revit.DB.Electrical.AnalyticalTransferSwitchData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalTransferSwitchData`

#### Summary

Represents the data and parameters of electrical analytical transfer switch.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.SetAssociationsChanged`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.SetAssociationsChanged`

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.GetAssociatedElementIds(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.GetAssociatedElementIds(Autodesk.Revit.DB.ElementId)`

#### Summary

Returns ids of the elements which are in association with the element with the given ElementId.

#### Parameter `elementId`

Element id for which we want to get the associated elements.

#### Returns

Ids of the associated elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.GetAssociatedElementId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.GetAssociatedElementId(Autodesk.Revit.DB.ElementId)`

#### Summary

Returns id of the element which is in association with the element with the given ElementId.

#### Parameter `elementId`

Element id for which we want to get the associated element.

#### Returns

Id of the associated element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.RemoveAssociation(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.RemoveAssociation(Autodesk.Revit.DB.ElementId)`

#### Summary

This method will remove the association for the element with the given ElementId.

#### Remarks

If the id does not have any association, an exception is thrown.

#### Parameter `id`

Id of the element for which we want to remove the association.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This element doesn't have an association defined.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.AddAssociation(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.AddAssociation(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Adds a new association between a group of analytical elements and a group of physical elements.

#### Remarks

The arguments must be ids of analytical and of physical elements that don't have other associations, otherwise an exception is thrown.
Physical elements can have one of these categories:
Columns

Curtain Wall Panels

Floors

Generic Models

Mass

Parts

Railings

Ramps

Roofs

Stairs

Structural Columns

Structural Foundation

Structural Framing

Structural Trusses

Structural Beam System

Walls
Analytical elements can have one of these categories:
Analytical Member

Analytical Panel

#### Parameter `analyticalElementIds`

Ids of the analytical elements.

#### Parameter `physicalElementIds`

Ids of the physical elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Analytical id is not valid or has already defined another association.
-or-
Physical id is not valid or has already defined another association.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.AddAssociation(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.AddAssociation(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Adds a new association between an analytical element and a physical element.

#### Remarks

The arguments must be ids of an analytical and of a physical element that don't have other associations, otherwise an exception is thrown.
Physical element can have one of these categories:
Columns

Curtain Wall Panels

Floors

Generic Models

Mass

Parts

Railings

Ramps

Roofs

Stairs

Structural Columns

Structural Foundation

Structural Framing

Structural Trusses

Structural Beam System

Walls
Analytical element can have one of these categories:
Analytical Member

Analytical Panel

#### Parameter `analyticalElementId`

Id of the analytical element.

#### Parameter `physicalElementId`

Id of the physical element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Analytical id is not valid or has already defined another association.
-or-
Physical id is not valid or has already defined another association.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.IsPhysicalElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.IsPhysicalElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns true if the element is a physical element.

#### Parameter `doc`

Revit document.

#### Parameter `id`

The element to be checked.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.IsAnalyticalElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.IsAnalyticalElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns true if the element is an analytical element.

#### Parameter `doc`

Revit document.

#### Parameter `id`

The element to be checked.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.HasAssociation(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.HasAssociation(Autodesk.Revit.DB.ElementId)`

#### Summary

Verifies if the element has already defined an association.

#### Parameter `id`

Id of the element to check.

#### Returns

Returns true if an association has been found, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.GetAnalyticalToPhysicalAssociationManager(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.GetAnalyticalToPhysicalAssociationManager(Autodesk.Revit.DB.Document)`

#### Summary

Returns the AnalyticalToPhysicalAssociationManager for this document.

#### Parameter `doc`

Revit document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.EnableAssistedAssociation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager.EnableAssistedAssociation`

#### Summary

Indicates if associations between Analytical and Physical Elements should be created automatically.

#### Remarks

If this flag is set to true, the associations are made on creation of an analytical element over a physical element.
If it's set to false, then the associations between analytical and physical elements have to be made manually.

#### Since

2023

### `T:Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager`

#### Summary

Class which manages the associations between analytical elements and physical elements.

#### Remarks

An element can be part of only one association at a time.
Physical elements can have one of these categories:
Columns

Curtain Wall Panels

Floors

Generic Models

Mass

Parts

Railings

Ramps

Roofs

Stairs

Structural Columns

Structural Foundation

Structural Framing

Structural Trusses

Structural Beam System

Walls
Analytical elements can have one of these categories:
Analytical Member

Analytical Panel

#### Since

2023

### `P:Autodesk.Revit.DB.ThermalProperties.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalProperties.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ThermalProperties.ThermalMass`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalProperties.ThermalMass`

#### Summary

The calculated thermal mass value.
The unit is kilogram feet-squared per second squared kelvin (kg ft^2/(s^2 K)).

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalProperties.ThermalResistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalProperties.ThermalResistance`

#### Summary

The calculated thermal resistance value (R-Value).
The unit is meter-squared kelvin per watt ((m^2*K)/Watt).

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalProperties.HeatTransferCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalProperties.HeatTransferCoefficient`

#### Summary

The heat transfer coefficient value (U-Value).
The unit is watts per meter-squared kelvin (W/(m^2*K)).

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalProperties.Roughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalProperties.Roughness`

#### Summary

Value of roughness.

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalProperties.Absorptance`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalProperties.Absorptance`

#### Summary

Value of absorptance.

#### Since

2013

### `T:Autodesk.Revit.DB.ThermalProperties`

Member kind: type
Symbol: `Autodesk.Revit.DB.ThermalProperties`

#### Summary

Class specific to thermal properties for assembly types, such as Wall,
Floor, Ceiling, Roof and Building Pad.

#### Since

2013

### `P:Autodesk.Revit.DB.Electrical.AnalyticalPowerSourceData.TotalConnectedCurrent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalPowerSourceData.TotalConnectedCurrent`

#### Summary

The total connected current of the analytical power source.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalPowerSourceData.Voltage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalPowerSourceData.Voltage`

#### Summary

The voltage value of the analytical power source.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for voltage is not a number
-or-
When setting this property: The given value for voltage is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for voltage must be positive.

#### Since

2023

### `T:Autodesk.Revit.DB.Electrical.AnalyticalPowerSourceData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalPowerSourceData`

#### Summary

Represents the data and parameters of analytical power source node.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalPanel.GetAnalyticalOpeningsIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalPanel.GetAnalyticalOpeningsIds`

#### Summary

Returns the Analytical Openings ids of the Analytical Panel.

#### Returns

Set of ElementId.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalPanel.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalPanel.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new instance of an Analytical Panel within the project.

#### Remarks

Profile can be a line, an arc or an ellipse.
In case of arcs and ellipses, the normal should be perpendicular to the profile plane.

#### Parameter `document`

Revit document.

#### Parameter `profile`

Curve which represents the profile of the Analytical Panel.

#### Parameter `normal`

Normal used for the extrusion of the profile.

#### Returns

The newly created AnalyticalPanel instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The profile argument is not valid for analytical panel creation.
-or-
The input profile is not bound.
-or-
The normal argument is not valid for analytical panel creation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the analytical panel.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalPanel.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalPanel.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.CurveLoop)`

#### Summary

Creates a new instance of an Analytical Panel within the project.

#### Remarks

CurveLoop must be planar and not self-intersecting.

#### Parameter `aDoc`

Revit document.

#### Parameter `curveLoop`

CurveLoop for the Analytical Panel.

#### Returns

The newly created AnalyticalPanel instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One of the following requirements is not satisfied :
- curve loop curveLoop is not planar
- curve loop curveLoop is self-intersecting
- curve loop curveLoop contains zero length curves

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.AnalyticalPanel.Thickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalPanel.Thickness`

#### Summary

Panel thickness, in the Revit default units.

#### Since

2023

### `T:Autodesk.Revit.DB.Structure.AnalyticalPanel`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalPanel`

#### Summary

An element that represents a surface in the Structural Analytical Model.

#### Since

2023

### `P:Autodesk.Revit.DB.CurveLoopIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveLoopIterator.CurrentObject`

### `P:Autodesk.Revit.DB.CurveLoopIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveLoopIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.
