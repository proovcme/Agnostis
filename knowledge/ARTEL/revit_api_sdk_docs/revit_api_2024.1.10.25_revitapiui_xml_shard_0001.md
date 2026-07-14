# ARTEL Revit API 2024 XML Documentation

Product: ARTEL
Document type: REVIT_API_SDK_DOC
Source kind: Revit SDK XML documentation
Revit API version: 2024.1.10.25
Assembly: RevitAPIUI
Source file: RevitAPIUI.xml
Source XML SHA-256: 6ad274f5fb15a6f8b1d145fd485ff977695b72b99039fa1ff55779bcb47a91f1
Package URL: https://api.nuget.org/v3-flatcontainer/autodesk.revit.sdk/2024.1.10.25/autodesk.revit.sdk.2024.1.10.25.nupkg
Package SHA-256: 72e2be30d84f438e6d9d9eeb92ff99a7674dfbcbe906c2dcaf9229b75c5cff43
Shard: 1
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPIUI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.UI.ViewSheetSetUI.LaunchDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.IntPtr)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUI.LaunchDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.IntPtr)`

#### Summary

Launches the UI managing the ViewSheetSet.

#### Parameter `document`

Document to manage ViewSheetSet for.

#### Parameter `defaultViewSheetSetId`

The default view sheet set id.

#### Parameter `parentHwnd`

The hwnd of parent window for dialog

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.UI.ViewSheetSetUI.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.ViewSheetSetUI.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.UI.ViewSheetSetUI`

Member kind: type
Symbol: `Autodesk.Revit.UI.ViewSheetSetUI`

#### Summary

The UI on managing ViewSheetSet.

### `M:Autodesk.Revit.UI.UIPlumbingUtils.PrepareDataForPipeEditor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIPlumbingUtils.PrepareDataForPipeEditor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Prepare data for pipe editor.

#### Parameter `typeId`

The pipe type id.

#### Parameter `systemTypeId`

The system type id.

#### Parameter `diameter`

The pipe size, the value is a pre-defined list in Revit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017.2

### `T:Autodesk.Revit.UI.UIPlumbingUtils`

Member kind: type
Symbol: `Autodesk.Revit.UI.UIPlumbingUtils`

#### Summary

General UI utility methods in Revit UI.

#### Since

2017.2

### `M:Autodesk.Revit.UI.UIFabricationUtils.ResetChangeServiceMappings(Autodesk.Revit.DB.Document,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.ResetChangeServiceMappings(Autodesk.Revit.DB.Document,System.Int32)`

#### Summary

Resets the mappings associated to the passed in service identifier.

#### Parameter `document`

The document.

#### Parameter `serviceId`

The fabrication service identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetChangeServiceDeleteFailuresState(Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetChangeServiceDeleteFailuresState(Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

Sets the state for change service to either keep or delete parts that encounter errors.

#### Parameter `document`

The document.

#### Parameter `state`

The state is either true to delete or false keep parts that encounter errors.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetChangeServiceMappingState(Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetChangeServiceMappingState(Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

Sets the state for change service mappings to either use or ignore the mappings.

#### Parameter `document`

The document.

#### Parameter `state`

The state is either true to ignore or false to use the mappings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.GetCanFinishChangeService(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.GetCanFinishChangeService(Autodesk.Revit.DB.Document)`

#### Summary

Checks if Change Service can finish or not.

#### Parameter `doc`

The document.

#### Returns

Gets whether Change Service can finish or not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetCanFinishChangeService(Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetCanFinishChangeService(Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

Sets if finishing Change Service is allowed or not.

#### Parameter `doc`

The document.

#### Parameter `canFinish`

Sets whether we can finish Change Service or not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.CancelSwapOutMode`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.CancelSwapOutMode`

#### Summary

Cancels the service and size swap out modes.

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.FinishSwapOutMode`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.FinishSwapOutMode`

#### Summary

Finishes the service and size swap out modes.

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetServiceSwapOutShapeForMouseOver(Autodesk.Revit.DB.Document,System.Int32,Autodesk.Revit.DB.ConnectorProfileType)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetServiceSwapOutShapeForMouseOver(Autodesk.Revit.DB.Document,System.Int32,Autodesk.Revit.DB.ConnectorProfileType)`

#### Summary

Sets the shape information to select the elements in the model from moused-over shapes.

#### Parameter `document`

The document.

#### Parameter `serviceId`

The fabrication service identifier.

#### Parameter `shape`

The shape of the parts to be selected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.ServiceSwapOutPartTypeMouseOver(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.ServiceSwapOutPartTypeMouseOver(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the required information to select the part types in the model from the moused-over fittings.

#### Parameter `document`

The document.

#### Parameter `partTypeId`

The part type Id. Pass InvalidElementId to select none.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetServiceSwapOutServiceIdForMouseOver(Autodesk.Revit.DB.Document,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetServiceSwapOutServiceIdForMouseOver(Autodesk.Revit.DB.Document,System.Int32)`

#### Summary

Sets the service id to select the elements in the model from the moused-over service.

#### Parameter `document`

The document.

#### Parameter `serviceId`

The service id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetServiceSwapOutSizesForMouseOver(Autodesk.Revit.DB.Document,System.Int32,Autodesk.Revit.DB.ConnectorProfileType,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetServiceSwapOutSizesForMouseOver(Autodesk.Revit.DB.Document,System.Int32,Autodesk.Revit.DB.ConnectorProfileType,System.Double,System.Double)`

#### Summary

Sets the required information to select the elements in the model from the moused-over sizes.

#### Parameter `document`

The document.

#### Parameter `serviceId`

The fabrication service identifier.

#### Parameter `profileType`

The shape of the parts to be selected.

#### Parameter `widthOrDiameter`

The width or diameter of the parts to be selected.

#### Parameter `depth`

The depth of the parts to be selected. Pass 0 if the profile type is Round.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetServiceSwapOutSizeMappings(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap})`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetServiceSwapOutSizeMappings(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap})`

#### Summary

Sets the service swap out size mappings

#### Parameter `document`

The document.

#### Parameter `mappings`

The service swap out size mappings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetServiceSwapOutPartTypeMappings(Autodesk.Revit.DB.Document,System.Collections.Generic.IDictionary{Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetServiceSwapOutPartTypeMappings(Autodesk.Revit.DB.Document,System.Collections.Generic.IDictionary{Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId})`

#### Summary

Sets the service swap out part type mappings

#### Parameter `document`

The document.

#### Parameter `mappings`

The service swap out part type mappings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetRestrictServicePaletteForSwapOut(Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetRestrictServicePaletteForSwapOut(Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

Sets the restrict service palette state for service swap out.

#### Parameter `document`

The document.

#### Parameter `restrictPalette`

The restrict service palette state, when enabled the service swap out will only use the assigned palette index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetServicePaletteForSwapOut(Autodesk.Revit.DB.Document,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetServicePaletteForSwapOut(Autodesk.Revit.DB.Document,System.Int32)`

#### Summary

Sets the service palette for service swap out.

#### Parameter `document`

The document.

#### Parameter `paletteIndex`

The service palette index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetServiceForSwapOut(Autodesk.Revit.DB.Document,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetServiceForSwapOut(Autodesk.Revit.DB.Document,System.Int32)`

#### Summary

Sets the service for service swap out.

#### Parameter `document`

The document.

#### Parameter `serviceId`

The service id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.GetConditionSizeDescription(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Int32,Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.GetConditionSizeDescription(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Int32,Autodesk.Revit.DB.FormatOptions)`

#### Summary

Gets the condition description for a service button's sizing condition.

#### Parameter `document`

The document used to extract unit information from.

#### Parameter `button`

The fabrication service button to query.

#### Parameter `conditionIndex`

The condition index of the fabrication service button to query.

#### Parameter `formatOptions`

The formatting options to use to format size text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.UI.UIFabricationUtils.RouteAndFillPartBrowserOnMouseLeave(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.RouteAndFillPartBrowserOnMouseLeave(Autodesk.Revit.DB.Document)`

#### Summary

The mouse leaves the fabrication route and fill part browser.

#### Parameter `document`

The document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.RouteAndFillPartBrowserOnPartTypeChanged(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.RouteAndFillPartBrowserOnPartTypeChanged(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

The fabrication route and fill part types are changed from the fabrication part browser, so the available solutions are needed to updated.

#### Parameter `doc`

The document.

#### Parameter `requiredTypeId`

The fabrication part type id that must be included in the route and fill solutions.If the id is invalid, it will be ignored.

#### Parameter `optionalTypeId`

The fabrication part type id that may or mat not be included from the route and fill solutions. If the id is invalid, will be ignored.

#### Parameter `selectedTypeId`

The fabrication part type id that is currently selected in the Fabrication Part Browser.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetupFabricationPrinters(Autodesk.Revit.DB.Document,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetupFabricationPrinters(Autodesk.Revit.DB.Document,System.Int32)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetFabricationPrinterToDefault(Autodesk.Revit.DB.Document,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetFabricationPrinterToDefault(Autodesk.Revit.DB.Document,System.Int32)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.GetFabricationPrinterFile(Autodesk.Revit.DB.Document,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.GetFabricationPrinterFile(Autodesk.Revit.DB.Document,System.Int32)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.ExportFabricationData(Autodesk.Revit.DB.Document,Autodesk.Revit.FabricationExportType,System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.ExportFabricationData(Autodesk.Revit.DB.Document,Autodesk.Revit.FabricationExportType,System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Parameter `file`

full path, as returned by getFabricationExports

#### Parameter `partIds`

the parts that will be exported.

#### Returns

whether the export was successful

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetupFabricationExports(Autodesk.Revit.DB.Document,Autodesk.Revit.FabricationExportType,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetupFabricationExports(Autodesk.Revit.DB.Document,Autodesk.Revit.FabricationExportType,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

shows modal UI to setup all fabrication exports of the specified type.

#### Parameter `partIds`

used if user clicks 'export now'

#### Returns

returns whether the user completed the UI successfully.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.GetFabricationExports(Autodesk.Revit.DB.Document,Autodesk.Revit.FabricationExportType)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.GetFabricationExports(Autodesk.Revit.DB.Document,Autodesk.Revit.FabricationExportType)`

#### Returns

dictionary of path / description pairs, where path is the unique key.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetupFabricationReports(Autodesk.Revit.DB.Document,Autodesk.Revit.FabricationReportType,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetupFabricationReports(Autodesk.Revit.DB.Document,Autodesk.Revit.FabricationReportType,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.PrintFabricationReports(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.PrintFabricationReports(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Returns

returns if any reports were printed

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetReportBinaryPath(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetReportBinaryPath(Autodesk.Revit.DB.Document,System.String)`

#### Summary

set path where qrcode and barcode Dlls can be found

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.EditConfiguration(Autodesk.Revit.DB.Document,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.EditConfiguration(Autodesk.Revit.DB.Document,System.String,System.String)`

#### Returns

returns if the configuration was changed

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.RebuildLoadedDatabase(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.RebuildLoadedDatabase(Autodesk.Revit.DB.Document)`

#### Summary

we need the for fabrication setting form when user clicked sync with source and cancel the form. when the internal rebuildLoadedDatabase is not called
because transaction was rolled back, but we need the reload the workspace

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.IsFabConfigConnectedToSource(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.IsFabConfigConnectedToSource(Autodesk.Revit.DB.Document)`

#### Summary

checks if the fabrication is connected to source

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.IsAllowedToPlacePart(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.IsAllowedToPlacePart(Autodesk.Revit.DB.Document)`

#### Summary

Checks if placing part is allowed or not.
For example, placing part is not allowed if the document is not allowed to change.

#### Parameter `doc`

The document.

#### Returns

True if placing part is allowed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.GetIsLT`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.GetIsLT`

#### Summary

Checks if the current product discipline is LT.

#### Returns

returns whether LT is the current product discipline.

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.GetIsMPR(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.GetIsMPR(Autodesk.Revit.DB.Document)`

#### Summary

Checks if starting MPR is currently active

#### Parameter `doc`

The document.

#### Returns

returns whether MPR is currently active

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetIsMPR(Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetIsMPR(Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

Sets if MPR is currently active or not.

#### Parameter `doc`

The document.

#### Parameter `isMPR`

sets whether MPR is valid for the current service palette.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.GetCanMPR(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.GetCanMPR(Autodesk.Revit.DB.Document)`

#### Summary

Checks if starting MPR is allowed or not.

#### Parameter `doc`

The document.

#### Returns

gets whether MPR is valid for the current service palette.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetCanMPR(Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetCanMPR(Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

Sets if starting MPR is allowed or not.

#### Parameter `doc`

The document.

#### Parameter `canMPR`

sets whether MPR is valid for the current service palette.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.IsJournalReplaying`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.IsJournalReplaying`

#### Summary

Indicates whether it is in journal replaying mode.

#### Returns

True if it is in journal replaying mode, false otherwise.

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.RestartMPR(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.RestartMPR(Autodesk.Revit.DB.Document)`

#### Summary

Call to restart multi point routing service.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.RouteFabricationService(Autodesk.Revit.DB.Document,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.RouteFabricationService(Autodesk.Revit.DB.Document,System.Int32,System.Int32)`

#### Summary

Call to start routing fabrication service.

#### Parameter `serviceId`

The Fabrication service.

#### Parameter `paletteIndex`

The Fabrication service palette index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

checks the service palette is valid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.PlaceFabricationPart(Autodesk.Revit.DB.Document,System.Int32,Autodesk.Revit.DB.FabricationItemFile)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.PlaceFabricationPart(Autodesk.Revit.DB.Document,System.Int32,Autodesk.Revit.DB.FabricationItemFile)`

#### Summary

Call to place a fabrication part from an item file.

#### Parameter `doc`

The document.

#### Parameter `serviceId`

The service Id to associate with the item file.

#### Parameter `itemFile`

The item file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.PlaceFabricationPart(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.PlaceFabricationPart(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton)`

#### Summary

Call to place a fabrication part.

#### Parameter `serviceButton`

The Fabrication service button.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

checks the service id, tab index and button index and makes sure they are valid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetCurrentServiceInfo(Autodesk.Revit.DB.Document,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetCurrentServiceInfo(Autodesk.Revit.DB.Document,System.Int32,System.Int32)`

#### Summary

call to initialise what service / palette will be used if MPR command is initiated from outside the part browser.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.UIFabricationUtils.GetOpenConnectorIndicatorAwayColor`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.GetOpenConnectorIndicatorAwayColor`

#### Summary

Gets the color of the open connector indicator in away direction.

#### Since

2017

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetOpenConnectorIndicatorAwayColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetOpenConnectorIndicatorAwayColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the color of the open connector indicator in away direction

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.UI.UIFabricationUtils.GetOpenConnectorIndicatorTowardsColor`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.GetOpenConnectorIndicatorTowardsColor`

#### Summary

Gets the color of the open connector indicator in towards direction.

#### Since

2017

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetOpenConnectorIndicatorTowardsColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetOpenConnectorIndicatorTowardsColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the color of the open connector indicator in towards direction

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.UI.UIFabricationUtils.GetOpenConnectorIndicatorPlanColor`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.GetOpenConnectorIndicatorPlanColor`

#### Summary

Gets the color of the open connector indicator in plan view.

#### Since

2017

### `M:Autodesk.Revit.UI.UIFabricationUtils.SetOpenConnectorIndicatorPlanColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIFabricationUtils.SetOpenConnectorIndicatorPlanColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the color of the open connector indicator in plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.UI.UIFabricationUtils`

Member kind: type
Symbol: `Autodesk.Revit.UI.UIFabricationUtils`

#### Summary

General Fabrication UI utility methods in Revit UI.

#### Since

2016

### `T:Autodesk.Revit.FabricationExportType`

Member kind: type
Symbol: `Autodesk.Revit.FabricationExportType`

#### Summary

Types of Fabrication Exports

### `F:Autodesk.Revit.FabricationExportType.LinearNest`

Member kind: field
Symbol: `Autodesk.Revit.FabricationExportType.LinearNest`

#### Summary

Linear Nest Export type

### `F:Autodesk.Revit.FabricationExportType.Ancillary`

Member kind: field
Symbol: `Autodesk.Revit.FabricationExportType.Ancillary`

#### Summary

Ancillary export type

### `F:Autodesk.Revit.FabricationExportType.Item`

Member kind: field
Symbol: `Autodesk.Revit.FabricationExportType.Item`

#### Summary

Item export type

### `T:Autodesk.Revit.FabricationReportType`

Member kind: type
Symbol: `Autodesk.Revit.FabricationReportType`

#### Summary

Types of Fabrication Reports

### `F:Autodesk.Revit.FabricationReportType.LinearNestReportPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.LinearNestReportPrint`

#### Summary

linear nest reports

### `F:Autodesk.Revit.FabricationReportType.DrawableWorksheetPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.DrawableWorksheetPrint`

#### Summary

3D worksheets

### `F:Autodesk.Revit.FabricationReportType.AncillaryReportPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.AncillaryReportPrint`

#### Summary

ancillary reports

### `F:Autodesk.Revit.FabricationReportType.PartWorksheetPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.PartWorksheetPrint`

#### Summary

part worksheets

### `F:Autodesk.Revit.FabricationReportType.AirturnLabelPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.AirturnLabelPrint`

#### Summary

airturn labels

### `F:Autodesk.Revit.FabricationReportType.DecoilerLabelPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.DecoilerLabelPrint`

#### Summary

decoiler labels

### `F:Autodesk.Revit.FabricationReportType.NestLabelPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.NestLabelPrint`

#### Summary

nest labels

### `F:Autodesk.Revit.FabricationReportType.ItemWorksheetPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.ItemWorksheetPrint`

#### Summary

item worksheets

### `F:Autodesk.Revit.FabricationReportType.ItemLabelPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.ItemLabelPrint`

#### Summary

item labels

### `F:Autodesk.Revit.FabricationReportType.OversizedLabelPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.OversizedLabelPrint`

#### Summary

oversize labels

### `F:Autodesk.Revit.FabricationReportType.MachineUseReportPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.MachineUseReportPrint`

#### Summary

machine usage

### `F:Autodesk.Revit.FabricationReportType.PartReportPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.PartReportPrint`

#### Summary

nest prints

### `F:Autodesk.Revit.FabricationReportType.NestReportPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.NestReportPrint`

#### Summary

nest prints

### `F:Autodesk.Revit.FabricationReportType.PartLabelPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.PartLabelPrint`

#### Summary

part labels

### `F:Autodesk.Revit.FabricationReportType.ItemReportPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.ItemReportPrint`

#### Summary

item reports

### `F:Autodesk.Revit.FabricationReportType.NestPrint`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.NestPrint`

#### Summary

nest prints

### `F:Autodesk.Revit.FabricationReportType.Unknown`

Member kind: field
Symbol: `Autodesk.Revit.FabricationReportType.Unknown`

#### Summary

Unknown report type

### `P:Autodesk.Revit.UI.UISaveAsOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.UISaveAsOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.UISaveAsOptions.ShowOverwriteWarning`

Member kind: property
Symbol: `Autodesk.Revit.UI.UISaveAsOptions.ShowOverwriteWarning`

#### Summary

Identifies if UI should show an overwrite warning dialog.

#### Value

True if the UI should show a warning dialog prompting the user to overwrite a file if it exists, False if it should not.
Default is false.

#### Since

2016

### `M:Autodesk.Revit.UI.UISaveAsOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.UI.UISaveAsOptions.#ctor`

#### Summary

Default constructor.

#### Since

2016

### `T:Autodesk.Revit.UI.UISaveAsOptions`

Member kind: type
Symbol: `Autodesk.Revit.UI.UISaveAsOptions`

#### Summary

This class contains UI options available for saving a document to disk with a new filename.

#### Since

2016

### `P:Autodesk.Revit.UI.ThinLinesOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.ThinLinesOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.ThinLinesOptions.AreThinLinesEnabled`

Member kind: property
Symbol: `Autodesk.Revit.UI.ThinLinesOptions.AreThinLinesEnabled`

#### Summary

A static property defining if the 'Thin Lines' setting is on or off in current Revit Application Session.

#### Remarks

If user started multiple Revit sessions, and the 'Thin Lines' setting might be different in each session.
Revit.ini file stores the lastest setting no matter what the Revit session is. The setting will be writen to Revit.ini if user set the value.

#### Since

2015 Subscription Update

### `T:Autodesk.Revit.UI.ThinLinesOptions`

Member kind: type
Symbol: `Autodesk.Revit.UI.ThinLinesOptions`

#### Summary

A utility class containing setting related to the Thin Lines option which affects the display in the UI.

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.UI.TextEditorOptions.GetTextEditorOptions`

Member kind: method
Symbol: `Autodesk.Revit.UI.TextEditorOptions.GetTextEditorOptions`

#### Summary

Returns the current Revit instance's TextEditorOptions.

#### Returns

The TextEditorOptions for the current Revit instance.

#### Since

2017

### `P:Autodesk.Revit.UI.TextEditorOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.TextEditorOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.TextEditorOptions.ShowOpaqueBackground`

Member kind: property
Symbol: `Autodesk.Revit.UI.TextEditorOptions.ShowOpaqueBackground`

#### Summary

Show opaque background behind the text during editing.

#### Remarks

If false, the background will be opaque or not depending on the edited text note's type Background setting.
If true, the background behind the text will always be opaque during editing.

#### Since

2017

### `P:Autodesk.Revit.UI.TextEditorOptions.ShowBorder`

Member kind: property
Symbol: `Autodesk.Revit.UI.TextEditorOptions.ShowBorder`

#### Summary

Show the border box around the text during editing.

#### Remarks

If false, the border will appear or not depending on the edited text note's type Show Border setting.
If true, the border will always appear during editing regardless of type settings.

#### Since

2017

### `T:Autodesk.Revit.UI.TextEditorOptions`

Member kind: type
Symbol: `Autodesk.Revit.UI.TextEditorOptions`

#### Summary

Provides access to settings that control Revit's Text Editor appearance and functionality.

#### Remarks

These settings are stored in the Revit.ini file. All documents in Revit instances which use this Revit.ini will follow these settings.

#### Since

2017

### `M:Autodesk.Revit.UI.TableViewUIUtils.TestCellAndPromptToEditTypeParameter(Autodesk.Revit.DB.TableView,Autodesk.Revit.DB.SectionType,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.TableViewUIUtils.TestCellAndPromptToEditTypeParameter(Autodesk.Revit.DB.TableView,Autodesk.Revit.DB.SectionType,System.Int32,System.Int32)`

#### Summary

Prompts the end-user to control whether a type parameter contained in the specified table cell should be allowed edited.

#### Remarks

If the specified cell contains an instance parameter, the method automatically returns true without prompting the user.
For type parameters, a task dialog will be shown and the user's choice will be returned.

#### Parameter `tableView`

The table view.

#### Parameter `sectionType`

The section the row lies in.

#### Parameter `row`

The row index in the section.

#### Parameter `column`

The column index in the section.

#### Returns

Returns true if editing the cell is allowed; otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given row number row is invalid.
-or-
The given column number column is invalid.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `T:Autodesk.Revit.UI.TableViewUIUtils`

Member kind: type
Symbol: `Autodesk.Revit.UI.TableViewUIUtils`

#### Summary

This utility class contains members that involve the Revit UI and operate on schedule views or MEP electrical panel schedules.

#### Since

2016

### `M:Autodesk.Revit.UI.SelectionUIOptions.ElementSelectsAsPinned(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.UI.SelectionUIOptions.ElementSelectsAsPinned(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element)`

#### Summary

Checks whether the specified element will be treated as pinned for the purposes of selection.

#### Remarks

To improve usability, the option to disable pinned selection has some additional intelligence
beyond simply checking the pinned status. For example, if a model group is pinned, the corresponding
attached detail group will also be treated as pinned for the purposes of selection. If this method
returns true, the specified element will not be selectable when selection of pinned elements is
disabled.

#### Parameter `document`

The document containing the element.

#### Parameter `element`

The element to check.

#### Returns

True if the specified element should be treated as pinned for selection purposes, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.UI.SelectionUIOptions.GetSelectionUIOptions`

Member kind: method
Symbol: `Autodesk.Revit.UI.SelectionUIOptions.GetSelectionUIOptions`

#### Summary

Returns the current user's SelectionOptions.

#### Returns

The SelectionOptions for the current user.

#### Since

2016

### `P:Autodesk.Revit.UI.SelectionUIOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.SelectionUIOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.SelectionUIOptions.ActivateControlsAndDimensionsOnMultiSelect`

Member kind: property
Symbol: `Autodesk.Revit.UI.SelectionUIOptions.ActivateControlsAndDimensionsOnMultiSelect`

#### Summary

Indicates whether controls and temporary dimensions are activated on selection of multiple elements.

#### Remarks

Revit always shows certain controls and temporary dimensions for a single selected element
When this option is set Revit also shows these controls and dimensions when multiple elements are selected.
Note that this setting takes effect on the next selection change.
To have this change take effect immediately use `Selection.SetElementIds(Selection.GetElementIds());`

#### Since

2016

### `P:Autodesk.Revit.UI.SelectionUIOptions.SelectPinned`

Member kind: property
Symbol: `Autodesk.Revit.UI.SelectionUIOptions.SelectPinned`

#### Summary

Indicates whether pinned elements can be selected.

#### Remarks

When this setting is false, the user cannot select most pinned elements in canvas. This option
helps users avoid accidentally moving important pinned objects such as levels and grids. When
this option is true, the user can select pinned elements directly.

Note that to improve usability, the behavior of this option has some added intelligence
beyond simply checking whether the element is pinned. For example, if a model group is pinned,
the corresponding attached detail group is not selectable if selection of pinned elements is
disabled. To check whether a particular element is pinned for purposes of this setting, see
`M:Autodesk.Revit.UI.SelectionUIOptions.ElementSelectsAsPinned(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element)` .

#### Since

2016

### `P:Autodesk.Revit.UI.SelectionUIOptions.DragOnSelection`

Member kind: property
Symbol: `Autodesk.Revit.UI.SelectionUIOptions.DragOnSelection`

#### Summary

Indicates whether elements can be dragged immediately when they are selected.

#### Remarks

When this setting is false, the user must click once to select an element and then must
explicitly click again in order to drag the element. This option helps users avoid accidentally
moving elements. When this setting is true, the user can click on an element to select it
and drag the element immediately by holding down the mouse.

#### Since

2016

### `P:Autodesk.Revit.UI.SelectionUIOptions.SelectUnderlay`

Member kind: property
Symbol: `Autodesk.Revit.UI.SelectionUIOptions.SelectUnderlay`

#### Summary

Indicates whether elements that are displayed as underlay can be selected.

#### Remarks

When this setting is false, if an element is displayed as underlay in a view then the user will
not be able to select it in that view. The element may still be selected in views where it
is not displayed as underlay. When this setting is true, elements that are displayed as underlay
may still be selected.

#### Since

2016

### `P:Autodesk.Revit.UI.SelectionUIOptions.SelectLinks`

Member kind: property
Symbol: `Autodesk.Revit.UI.SelectionUIOptions.SelectLinks`

#### Summary

Indicates whether Revit and CAD link instances can be selected.

#### Remarks

When this setting is false, users cannot directly select link instances or elements within them in the
canvas. This makes it easy for the user to avoid accidentally selecting and moving
links. When this setting is true, users can select link instances.

#### Since

2016

### `P:Autodesk.Revit.UI.SelectionUIOptions.SelectFaces`

Member kind: property
Symbol: `Autodesk.Revit.UI.SelectionUIOptions.SelectFaces`

#### Summary

Indicates whether elements can be selected by clicking on the interior of a face.

#### Remarks

When this setting is false, users must click on an edge or vertex of an element
in order to select the corresponding element. When it is true, users may also select elements by clicking
on the interior of a face of an element.

#### Since

2016

### `T:Autodesk.Revit.UI.SelectionUIOptions`

Member kind: type
Symbol: `Autodesk.Revit.UI.SelectionUIOptions`

#### Summary

Provides access to user settings related to how selection will behave in Revit's UI.

#### Remarks

The settings in this class define how selection will behave when the user is
selecting one or more elements in a graphical view. These settings do not affect programmatic selection behavior.
Some UI commands may override the user's settings while the command is active.

These settings are per user and will affect the selection behavior in all
projects and families. The settings are not stored in the project.

#### Since

2016

### `M:Autodesk.Revit.UI.Selection.SelectableInViewFilter.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.SelectableInViewFilter.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Constructs a new instance of an SelectableInViewFilter, with the option to pass all non-selectable elements.

#### Parameter `document`

The document that owns the view.

#### Parameter `viewId`

The view id.

#### Parameter `inverted`

True if the filter should match all elements not selectable in the given view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

viewId is not a view.
-or-
viewId is not valid for element iteration, because it has no way of representing drawn elements. Many view templates
will fail this check.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.UI.Selection.SelectableInViewFilter.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.SelectableInViewFilter.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a new instance of an SelectableInViewFilter.

#### Parameter `document`

The document that owns the view.

#### Parameter `viewId`

The view id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

viewId is not a view.
-or-
viewId is not valid for element iteration, because it has no way of representing drawn elements. Many view templates
will fail this check.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.UI.Selection.SelectableInViewFilter`

Member kind: type
Symbol: `Autodesk.Revit.UI.Selection.SelectableInViewFilter`

#### Summary

A filter that passes elements that are selectable in the given view.

#### Remarks

This filter is a slow filter. Slow filters require that the Element be obtained and expanded in memory first.
Thus it is preferable to couple this filter with at least one ElementQuickFilter,
which should minimize the number of Elements that are expanded.
This filter is designed to operate on a list of elements visible in the given view.
This can be obtained from a FilteredElementCollector constructed with the view id.
This filter may not correctly restrict elements which are not a part of the visible elements of the view.

#### Since

2015

### `M:Autodesk.Revit.UI.RevitLinkUIUtils.ReportLinkLoadResults(Autodesk.Revit.DB.Document,System.Collections.Generic.IDictionary{System.String,Autodesk.Revit.DB.LinkLoadResult})`

Member kind: method
Symbol: `Autodesk.Revit.UI.RevitLinkUIUtils.ReportLinkLoadResults(Autodesk.Revit.DB.Document,System.Collections.Generic.IDictionary{System.String,Autodesk.Revit.DB.LinkLoadResult})`

#### Summary

This function reports any errors which were encountered
when loading the Revit links represented by the given
LinkLoadResult map.

#### Remarks

If all links succeeded in loading, the function does
nothing. If any links failed to load, this function
will display the Unresolved References dialog, giving
the user the option to open the Manage Links dialog
to correct any problems.

To ensure the dialog fits on the screen, Revit will
only list up to ten link names. Additional links will
be mentioned as, "And >number< additional links." This
is the same behavior Revit's user interface uses.

#### Parameter `doc`

The document containing the links.

#### Parameter `loadResults`

A map from the display name of a link to the LinkLoadResult
for that link.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.UI.RevitLinkUIUtils`

Member kind: type
Symbol: `Autodesk.Revit.UI.RevitLinkUIUtils`

#### Summary

A class containing functions for displaying user interface related to
Revit links.

#### Since

2015

### `P:Autodesk.Revit.UI.RibbonButtonOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonButtonOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.UI.RibbonButtonOptions`

Member kind: type
Symbol: `Autodesk.Revit.UI.RibbonButtonOptions`

#### Summary

A utility class containing the Revit.ini options settings related to ribbon buttons

#### Since

2020.1

### `M:Autodesk.Revit.UI.RecentFileProvider.GetDefaultLocalSavingFolder`

Member kind: method
Symbol: `Autodesk.Revit.UI.RecentFileProvider.GetDefaultLocalSavingFolder`

#### Summary

Returns the default saving folder when open a central file.

#### Since

2019

### `M:Autodesk.Revit.UI.RecentFileProvider.IsRecentFilePageDisabled`

Member kind: method
Symbol: `Autodesk.Revit.UI.RecentFileProvider.IsRecentFilePageDisabled`

#### Summary

Indicates if recent file is disabled.

#### Returns

Returns true if recent file is disabled, otherwise returns false.

#### Since

2019

### `M:Autodesk.Revit.UI.RecentFileProvider.GetAllSampleFiles`

Member kind: method
Symbol: `Autodesk.Revit.UI.RecentFileProvider.GetAllSampleFiles`

#### Summary

Returns sample files of Revit

#### Since

2019

### `M:Autodesk.Revit.UI.RecentFileProvider.GetAllRecentFiles(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.RecentFileProvider.GetAllRecentFiles(System.Boolean)`

#### Summary

Returns most recent files of Revit

#### Parameter `generateThumbnails`

true to generate and return thumbnails paths as part of return, false to leave blank.

#### Since

2019

### `T:Autodesk.Revit.UI.RecentFileProvider`

Member kind: type
Symbol: `Autodesk.Revit.UI.RecentFileProvider`

#### Summary

A class contains data of Most Recent File .

#### Since

2019

### `M:Autodesk.Revit.UI.RevitFileInfo.SetLocalPath(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.RevitFileInfo.SetLocalPath(System.String)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.UI.RevitFileInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitFileInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.RevitFileInfo.IsCloud`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitFileInfo.IsCloud`

#### Summary

If it is a cloud file.

#### Since

2019

### `P:Autodesk.Revit.UI.RevitFileInfo.IsWorkshared`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitFileInfo.IsWorkshared`

#### Summary

If it is a workshared file.

#### Since

2019

### `P:Autodesk.Revit.UI.RevitFileInfo.Size`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitFileInfo.Size`

#### Summary

The size of the recent file.

#### Since

2019

### `P:Autodesk.Revit.UI.RevitFileInfo.ModelType`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitFileInfo.ModelType`

#### Summary

The model type of the recent file.

#### Since

2019

### `P:Autodesk.Revit.UI.RevitFileInfo.LastModifiedTime`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitFileInfo.LastModifiedTime`

#### Summary

The last modified time of the recent file.

#### Since

2019

### `P:Autodesk.Revit.UI.RevitFileInfo.ThumbnailPath`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitFileInfo.ThumbnailPath`

#### Summary

The path of the thumbnail file.

#### Since

2019

### `P:Autodesk.Revit.UI.RevitFileInfo.ExtensionType`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitFileInfo.ExtensionType`

#### Summary

The extension type of the recent file.
such as .rfa /.rvt

#### Since

2019

### `P:Autodesk.Revit.UI.RevitFileInfo.LocalPath`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitFileInfo.LocalPath`

#### Summary

The path of the cached file.
If a cloud file, the path looks like "%USERPROFILE%\AppData\Local
\Autodesk\Revit\{Revit Version}\CollaborationCache\YZVYJQWWXXXX
{GUID}\{GUID}.rvt"
if a local file, localPath and path are the same.

#### Since

2019

### `P:Autodesk.Revit.UI.RevitFileInfo.Path`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitFileInfo.Path`

#### Summary

The path of the recent file.
If a cloud file, the path looks like "cld://region/{GUID}Shanghai%20Design%20Center/{GUID}4walls.rvt"
If a local file, the path looks like "c:\4wall.rvt".

#### Since

2019

### `P:Autodesk.Revit.UI.RevitFileInfo.Name`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitFileInfo.Name`

#### Summary

The name of the recent file.
If a cloud file, it looks like "Autodesk Docs://Shanghai Design Center/4walls.rvt"
If a local file, path, localPath and name are all the same.

#### Since

2019

### `P:Autodesk.Revit.UI.RevitFileInfo.DisplayName`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitFileInfo.DisplayName`

#### Summary

The display Name of the recent file.
such as 4walls (no extention)

#### Since

2019

### `T:Autodesk.Revit.UI.RevitFileInfo`

Member kind: type
Symbol: `Autodesk.Revit.UI.RevitFileInfo`

#### Summary

A class contains data of Revit File.

#### Since

2019

### `M:Autodesk.Revit.UI.ProjectBrowserOptions.GetProjectBrowserOptions`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserOptions.GetProjectBrowserOptions`

#### Summary

Returns the current Revit instance's ProjectBrowserOptions.

#### Returns

The ProjectBrowserOptions for the current Revit instance.

#### Since

2023

### `P:Autodesk.Revit.UI.ProjectBrowserOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.ProjectBrowserOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.ProjectBrowserOptions.ShowViewPlacementOnSheetStatusIcons`

Member kind: property
Symbol: `Autodesk.Revit.UI.ProjectBrowserOptions.ShowViewPlacementOnSheetStatusIcons`

#### Summary

Show the icons indicating view placement on sheet status.

#### Remarks

If true, the icons indicating view placement on sheet status will be shown at every view or schedule node in the Project Browser.
If false, the icons indicating view placement on sheet status will not be shown.

#### Since

2023

### `T:Autodesk.Revit.UI.ProjectBrowserOptions`

Member kind: type
Symbol: `Autodesk.Revit.UI.ProjectBrowserOptions`

#### Summary

Provides access to settings that control Revit's Project Browser appearance and functionality.

#### Remarks

These settings are stored in the Revit.ini file. All documents in Revit instances which use this Revit.ini will follow these settings.

#### Since

2023

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.IsAddinPBEnable`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.IsAddinPBEnable`

#### Summary

Returns if web project browser is enabled

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.CreateContextMenu(Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.CreateContextMenu(Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

create context menu

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.EndLabelEdit(Autodesk.Revit.DB.Document,System.Int32,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.EndLabelEdit(Autodesk.Revit.DB.Document,System.Int32,System.String)`

#### Summary

End tree item name editing

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.Rename`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.Rename`

#### Summary

Rename tree item

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.UpdateBrowserData(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.UpdateBrowserData(Autodesk.Revit.DB.Document)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.ShouldRefreshProjectBrowser`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.ShouldRefreshProjectBrowser`

#### Summary

Returns if web project browser should refresh

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.IsBrowserDataClean(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.IsBrowserDataClean(Autodesk.Revit.DB.Document)`

#### Summary

Returns if project browser data clean

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.OnDoubleClick(Autodesk.Revit.DB.Document,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.OnDoubleClick(Autodesk.Revit.DB.Document,System.Int32)`

#### Summary

Double-click a tree item

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.DropTreeItem(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.DropTreeItem(System.Int32)`

#### Summary

Drop tree item

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.BeginDragTreeItem`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.BeginDragTreeItem`

#### Summary

Drag tree item

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.ExpandOrCollapse(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{System.Int32},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.ExpandOrCollapse(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{System.Int32},System.Boolean)`

#### Summary

Set the selected tree item as expanded

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.SelectBrowserItems(System.Collections.Generic.IList{System.Int32})`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.SelectBrowserItems(System.Collections.Generic.IList{System.Int32})`

#### Summary

Set the selected tree items in UI to internal

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.SetFirstVisibleItemIndex(Autodesk.Revit.DB.Document,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.SetFirstVisibleItemIndex(Autodesk.Revit.DB.Document,System.Int32)`

#### Summary

Set the first visible item Index for scrolling

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.GetFirstVisibleItemIndex(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.GetFirstVisibleItemIndex(Autodesk.Revit.DB.Document)`

#### Summary

Returns the first visible item Index for scrolling

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.GetAllExpandedItemsIndex(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.GetAllExpandedItemsIndex(Autodesk.Revit.DB.Document)`

#### Summary

Returns all project browser expanded items' index

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.GetAllActiveItemsIndex(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.GetAllActiveItemsIndex(Autodesk.Revit.DB.Document)`

#### Summary

Returns all project browser active items' index

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.GetAllSelectedItemsIndex(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.GetAllSelectedItemsIndex(Autodesk.Revit.DB.Document)`

#### Summary

Returns all project browser items' index

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserDataProvider.GetAllBrowserItems(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider.GetAllBrowserItems(Autodesk.Revit.DB.Document)`

#### Summary

Returns all project browser items

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `T:Autodesk.Revit.UI.ProjectBrowserDataProvider`

Member kind: type
Symbol: `Autodesk.Revit.UI.ProjectBrowserDataProvider`

#### Summary

A class provides ProjectBrowser data.

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserItemInfo.IsEdited(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserItemInfo.IsEdited(Autodesk.Revit.DB.Document)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserItemInfo.CanExpandByDoubleClick`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserItemInfo.CanExpandByDoubleClick`

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserItemInfo.GetTypeForImage(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserItemInfo.GetTypeForImage(Autodesk.Revit.DB.Document)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserItemInfo.GetStateImgIndex(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserItemInfo.GetStateImgIndex(Autodesk.Revit.DB.Document)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserItemInfo.GetItemType`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserItemInfo.GetItemType`

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserItemInfo.GetParentIndex`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserItemInfo.GetParentIndex`

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserItemInfo.GetIndex`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserItemInfo.GetIndex`

#### Since

2024

### `M:Autodesk.Revit.UI.ProjectBrowserItemInfo.GetName`

Member kind: method
Symbol: `Autodesk.Revit.UI.ProjectBrowserItemInfo.GetName`

#### Since

2024

### `P:Autodesk.Revit.UI.ProjectBrowserItemInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.ProjectBrowserItemInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.UI.ProjectBrowserItemInfo`

Member kind: type
Symbol: `Autodesk.Revit.UI.ProjectBrowserItemInfo`

#### Summary

A class visit data of ProjectBrowser Item.

#### Since

2024

### `M:Autodesk.Revit.UI.PointCloudSnappingUtilities.GetARCQueryForActiveView(Autodesk.Revit.DB.PointCloudType)`

Member kind: method
Symbol: `Autodesk.Revit.UI.PointCloudSnappingUtilities.GetARCQueryForActiveView(Autodesk.Revit.DB.PointCloudType)`

#### Summary

Gets ARCQuery corresponding to the type and active view.

#### Parameter `type`

PointCloudType from which to get the ARCQuery

#### Returns

The returned pointer can be NULL if the ARCQuery is NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.PointCloudSnappingUtilities.GetVisibleScanGUIDs(Autodesk.Revit.DB.PointCloudInstance,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.UI.PointCloudSnappingUtilities.GetVisibleScanGUIDs(Autodesk.Revit.DB.PointCloudInstance,Autodesk.Revit.DB.View)`

#### Summary

Given a PointCloudInstance, get those of its scans which are visible in the given view.

#### Parameter `pointCloudInstance`

The PointCloudInstance to get scans from.

#### Parameter `dbView`

The view in which we search for visible scans of the PointCloudInstance.

#### Returns

The GUIDs of the scans of the given PointCloudInstance visible in the given view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.PointCloudSnappingUtilities.GetPlanes(Autodesk.Revit.DB.PointCloudInstance,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.UI.PointCloudSnappingUtilities.GetPlanes(Autodesk.Revit.DB.PointCloudInstance,Autodesk.Revit.DB.View)`

#### Summary

Gets the bounding planes for the given point cloud and view.

#### Parameter `pointCloudInstance`

The point cloud to find the bounding planes for.

#### Parameter `dbView`

The view in which to find the bounding planes for point cloud.

#### Returns

The bounding planes for the given point cloud and view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.UI.PointCloudSnappingUtilities.GetReCapNativeAccess(Autodesk.Revit.DB.PointCloudType)`

Member kind: method
Symbol: `Autodesk.Revit.UI.PointCloudSnappingUtilities.GetReCapNativeAccess(Autodesk.Revit.DB.PointCloudType)`

#### Summary

Returns native pointer to IRCData object that corresponds to
a loaded and open point cloud in ReCap SDK

#### Remarks

The returned pointer can be NULL if the point cloud has been unloaded
or if this point cloud uses different engine than ReCap

#### Parameter `type`

PointCloudType from which to get the IRCData

#### Returns

The access pointer

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `T:Autodesk.Revit.UI.PointCloudSnappingUtilities`

Member kind: type
Symbol: `Autodesk.Revit.UI.PointCloudSnappingUtilities`

#### Summary

This is a utilities class for accessing PointClouds.

#### Since

2024

### `M:Autodesk.Revit.UI.LicensingUtils.CheckExtensionLicense(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.UI.LicensingUtils.CheckExtensionLicense(System.Guid)`

#### Summary

Checks if the user has a valid extension license for given product.

#### Remarks

This call is silent, only check the Entitlement of the currently logged in account.
A valid license must be released by calling `M:Autodesk.Revit.UI.LicensingUtils.ReleaseLicense(System.Guid)` before Revit shuts down.

#### Parameter `productId`

Product id.

#### Returns

Entitlement status

#### Since

2021

### `M:Autodesk.Revit.UI.LicensingUtils.ReleaseLicense(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.UI.LicensingUtils.ReleaseLicense(System.Guid)`

#### Summary

Releases a license for a given product obtained by `M:Autodesk.Revit.UI.LicensingUtils.CheckLicense(System.Guid)` .

#### Parameter `productId`

Product id.

#### Since

2021

### `M:Autodesk.Revit.UI.LicensingUtils.CheckLicense(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.UI.LicensingUtils.CheckLicense(System.Guid)`

#### Summary

Checks if the user has a valid license for given product.

#### Remarks

This call will launch a sign in dialog and require the user to sign in order to complete the check if the user is not currently signed in.
A valid license must be released by calling `M:Autodesk.Revit.UI.LicensingUtils.ReleaseLicense(System.Guid)` when Revit shuts down.

#### Parameter `productId`

Product id.

#### Returns

True if the license for the given product is valid.

#### Since

2021

### `M:Autodesk.Revit.UI.LicensingUtils.GetProductId(System.String,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.LicensingUtils.GetProductId(System.String,System.String,System.String)`

#### Summary

Registers a product with the licensing component and returns an id of the product to be used when checking for a valid license.

#### Parameter `productName`

Product name.

#### Parameter `productKey`

Product id.

#### Parameter `featureId`

Feature id.

#### Returns

Id of the product.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `T:Autodesk.Revit.UI.LicensingUtils`

Member kind: type
Symbol: `Autodesk.Revit.UI.LicensingUtils`

#### Summary

A collection of functions related to a product license checking.

#### Since

2021

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.Create(System.String,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.Create(System.String,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Create a new view sheet set in auto sort mode

#### Parameter `name`

View sheet set name to be created.

#### Parameter `sheetSchemaId`

Sheet schema id to be sorted with.

#### Parameter `viewSchemaId`

View schema id to be sorted with.

#### Parameter `viewIds`

View id(s) to be saved with.

#### Returns

ElementId is invalid if creates failed

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string or contains only whitespace.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.Create(System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.Create(System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Create a new view sheet set in manual sort mode

#### Parameter `name`

View sheet set name to be created.

#### Parameter `viewIds`

View id(s) with order to be created with.

#### Returns

ElementId is invalid if creates failed

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string or contains only whitespace.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.Save(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.Save(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Save the changes for the current view sheet set in auto sort mode

#### Parameter `elementId`

The view sheet set to be saved.

#### Parameter `sheetSchemaId`

Sheet schema id to be sorted with.

#### Parameter `viewSchemaId`

View schema id to be sorted with.

#### Parameter `viewIds`

View id(s) to be saved with.

#### Returns

False if Save operation fails, otherwise True.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.Save(Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.Save(Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Save the changes for the current view sheet set in manual sort mode

#### Parameter `elementId`

The view sheet set to be saved.

#### Parameter `viewIds`

View id(s) with order to be saved with.

#### Returns

False if Save operation fails, otherwise True.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.Rename(Autodesk.Revit.DB.ElementId,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.Rename(Autodesk.Revit.DB.ElementId,System.String)`

#### Summary

Rename the current view sheet set.

#### Parameter `elementId`

The view sheet set to be renamed.

#### Parameter `newName`

View sheet set name to be renamed as.

#### Returns

False if Rename operation fails, otherwise True.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

newName is an empty string or contains only whitespace.
-or-
newName cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.Delete(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.Delete(Autodesk.Revit.DB.ElementId)`

#### Summary

Delete the view sheet set

#### Parameter `elementId`

The view sheet set to be deleted.

#### Returns

False if Delete operation fails, otherwise True.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.UseCurrentElement`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.UseCurrentElement`

#### Summary

Call NamedElemData::useCurrentElement for ViewSheetSet

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.SetDefaultViewSheetSetId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.SetDefaultViewSheetSetId(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the id of default view sheet set.

#### Parameter `elementId`

The default view sheet set id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.GetDefaultViewSheetSetId`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.GetDefaultViewSheetSetId`

#### Summary

Gets the id of default view sheet set.
If default is in-session, the id is -1

#### Returns

The default view sheet set id.

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.SetInSessionAutoSortSchemas(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.SetInSessionAutoSortSchemas(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the set of in-session to auto sort mode with schemas' id.

#### Parameter `sheetSchemaId`

Sheet schema id to be sorted with.

#### Parameter `viewSchemaId`

View schema id to be sorted with.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.GetInSessionViewSchemaId`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.GetInSessionViewSchemaId`

#### Summary

Gets the id of in-session set's view schema.

#### Returns

View schema id.

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.GetInSessionSheetSchemaId`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.GetInSessionSheetSchemaId`

#### Summary

Gets the id of in-session set's sheet schema.

#### Returns

Sheet schema id.

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.SetInSessionViewIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.SetInSessionViewIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets the set of in-session's views' id.

#### Parameter `elementIds`

The in-session view id set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.GetInSessionViewIds`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.GetInSessionViewIds`

#### Summary

Update and get the set of in-session views's id.

#### Returns

The in-session view Id set.

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.SetInSessionIsAutoSortMode(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.SetInSessionIsAutoSortMode(System.Boolean)`

#### Summary

Set in session set's sort mode

#### Parameter `isAutoSort`

True if in auto sort mode

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.GetInSessionIsAutoSortMode`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.GetInSessionIsAutoSortMode`

#### Summary

Gets if in session set is in auto sort mode

#### Returns

True if in auto sort mode

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.SetParentHwnd(System.IntPtr)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.SetParentHwnd(System.IntPtr)`

#### Summary

Sets the parent hwnd

### `M:Autodesk.Revit.UI.ViewSheetSetUIData.GetParentHwnd`

Member kind: method
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.GetParentHwnd`

#### Summary

Gets the parent hwnd

#### Returns

The hwnd of parent window

### `P:Autodesk.Revit.UI.ViewSheetSetUIData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.UI.ViewSheetSetUIData`

Member kind: type
Symbol: `Autodesk.Revit.UI.ViewSheetSetUIData`

#### Summary

UI data wrapper for ViewSheetSetData.

### `M:Autodesk.Revit.UI.IViewSheetSetUIServerProxy.ShowDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.UI.ViewSheetSetUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IViewSheetSetUIServerProxy.ShowDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.UI.ViewSheetSetUIData)`

#### Summary

Shows dialog on managing ViewSheetSet.

#### Parameter `document`

The associated document.

#### Parameter `data`

The data on initializing the dialog as well as getting the result.

#### Returns

Whether or not the dialog launches successfully.

### `M:Autodesk.Revit.UI.IViewSheetSetUIServer.ShowDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.UI.ViewSheetSetUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IViewSheetSetUIServer.ShowDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.UI.ViewSheetSetUIData)`

#### Summary

Shows dialog on managing ViewSheetSet.

#### Parameter `document`

The associated document.

#### Parameter `data`

The data on initializing the dialog as well as getting the result.

#### Returns

Whether or not the dialog launches successfully.

### `T:Autodesk.Revit.UI.IViewSheetSetUIServer`

Member kind: type
Symbol: `Autodesk.Revit.UI.IViewSheetSetUIServer`

#### Summary

The interface used to provide UI on managing ViewSheetSet.

### `P:Autodesk.Revit.UI.TemporaryGraphicsCommandData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.TemporaryGraphicsCommandData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.TemporaryGraphicsCommandData.Index`

Member kind: property
Symbol: `Autodesk.Revit.UI.TemporaryGraphicsCommandData.Index`

#### Summary

The unique index of the temporary graphics object managed by `T:Autodesk.Revit.DB.TemporaryGraphicsManager` .

#### Since

2022

### `P:Autodesk.Revit.UI.TemporaryGraphicsCommandData.Document`

Member kind: property
Symbol: `Autodesk.Revit.UI.TemporaryGraphicsCommandData.Document`

#### Summary

The document.

#### Since

2022

### `M:Autodesk.Revit.UI.TemporaryGraphicsCommandData.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.UI.TemporaryGraphicsCommandData.#ctor`

#### Since

2022

### `T:Autodesk.Revit.UI.TemporaryGraphicsCommandData`

Member kind: type
Symbol: `Autodesk.Revit.UI.TemporaryGraphicsCommandData`

#### Summary

The context data that can be provided to `M:Autodesk.Revit.UI.ITemporaryGraphicsHandler.OnClick(Autodesk.Revit.UI.TemporaryGraphicsCommandData)` .

#### Since

2022

### `M:Autodesk.Revit.UI.ITemporaryGraphicsHandlerProxy.OnClick(Autodesk.Revit.UI.TemporaryGraphicsCommandData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ITemporaryGraphicsHandlerProxy.OnClick(Autodesk.Revit.UI.TemporaryGraphicsCommandData)`

#### Summary

Handles mouse click event on a given temporary graphics object managed by `T:Autodesk.Revit.DB.TemporaryGraphicsManager` .

#### Parameter `data`

The context data of the click event.

#### Since

2022

### `M:Autodesk.Revit.UI.ITemporaryGraphicsHandler.OnClick(Autodesk.Revit.UI.TemporaryGraphicsCommandData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ITemporaryGraphicsHandler.OnClick(Autodesk.Revit.UI.TemporaryGraphicsCommandData)`

#### Summary

Handles mouse click event on a given temporary graphics object managed by `T:Autodesk.Revit.DB.TemporaryGraphicsManager` .

#### Parameter `data`

The context data of the click event.

#### Since

2022

### `T:Autodesk.Revit.UI.ITemporaryGraphicsHandler`

Member kind: type
Symbol: `Autodesk.Revit.UI.ITemporaryGraphicsHandler`

#### Summary

Interface class for external server of `P:Autodesk.Revit.DB.ExternalService.ExternalServices.BuiltInExternalServices.TemporaryGraphicsHandlerService` .

#### Since

2022

### `M:Autodesk.Revit.UI.SnappingServiceData.GetWorkPlane`

Member kind: method
Symbol: `Autodesk.Revit.UI.SnappingServiceData.GetWorkPlane`

#### Summary

Returns a copy of the current sketch plane

### `M:Autodesk.Revit.UI.SnappingServiceData.GetInPoint`

Member kind: method
Symbol: `Autodesk.Revit.UI.SnappingServiceData.GetInPoint`

#### Summary

Gets the point to snap near.

#### Returns

The point to snap near

#### Since

2017

### `M:Autodesk.Revit.UI.SnappingServiceData.GetLocalToPage(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.UI.SnappingServiceData.GetLocalToPage(Autodesk.Revit.DB.XYZ)`

#### Summary

Transforms local coordinates of a point to page coordinates.

#### Parameter `Inpoint`

Input the point local coordinates

#### Returns

Return the transformed coordinates

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.SnappingServiceData.AddPointSnaps(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.SnappingServiceData.AddPointSnaps(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.ElementId)`

#### Summary

Takes point snaps from the instance of ISnappingServer and passes them to Revit.

#### Parameter `pointSnaps`

The points to add as snaps.

#### Parameter `elemId`

Id of the element providing snap points.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.SnappingServiceData.AddBoundedLineSnaps(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.SnappingServiceData.AddBoundedLineSnaps(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean,Autodesk.Revit.DB.ElementId)`

#### Summary

Takes line snaps from the instance of ISnappingServer and passes them to Revit.

#### Parameter `lineSnaps`

Lines are represented by two XYZs: start point, end point.

#### Parameter `projectToWorkPlane`

Whether to project the lines to the work plane. For instance, if the line snaps represent
planes, we want to project them. If they represent cylinders, we do not.

#### Parameter `elemId`

Id of the element providing snap points.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the array lineSnaps has an odd number of entries and is hence not a valid line snap
array, since lines are represented as an origin XYZ followed by a direction XYZ.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.SnappingServiceData.AddLineSnaps(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.SnappingServiceData.AddLineSnaps(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean,Autodesk.Revit.DB.ElementId)`

#### Summary

Takes line snaps from the instance of ISnappingServer and passes them to Revit.

#### Parameter `lineSnaps`

Lines are represented by two XYZs: first an origin, then a direction.

#### Parameter `projectToWorkPlane`

Whether to project the lines to the work plane. For instance, if the line snaps represent
planes, we want to project them. If they represent cylinders, we do not. If we project
to the work plane, we also verify that the line is parallel to the work plane.

#### Parameter `elemId`

Id of the element providing snap points.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the array lineSnaps has an odd number of entries and is hence not a valid line snap
array, since lines are represented as an origin XYZ followed by a direction XYZ.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.SnappingServiceData.GetViewRectangle`

Member kind: method
Symbol: `Autodesk.Revit.UI.SnappingServiceData.GetViewRectangle`

#### Summary

Returns the view rectangle in local coordinates.

#### Returns

The view rectangle in local coordinates.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

the View in which snapping is being done is not in a usable state (e.g. it is not
finished drawing).

### `M:Autodesk.Revit.UI.SnappingServiceData.GetPointSnappingRadius`

Member kind: method
Symbol: `Autodesk.Revit.UI.SnappingServiceData.GetPointSnappingRadius`

#### Summary

The size of the sampling region for the nearest best point detection.

#### Returns

The size of the sampling region for the nearest best point detection.

### `M:Autodesk.Revit.UI.SnappingServiceData.GetViewDirection`

Member kind: method
Symbol: `Autodesk.Revit.UI.SnappingServiceData.GetViewDirection`

#### Summary

A unit vector from the eye to the point around which to detect features.

#### Returns

A unit vector from the eye to the point around which to detect features.

### `M:Autodesk.Revit.UI.SnappingServiceData.GetScreenMMToModelMM`

Member kind: method
Symbol: `Autodesk.Revit.UI.SnappingServiceData.GetScreenMMToModelMM`

#### Summary

Returns the conversion factor between mm on the screen and mm in the model.

#### Returns

The conversion factor between mm on the screen and mm in the model.

### `M:Autodesk.Revit.UI.SnappingServiceData.GetScreenMMToModelUnits`

Member kind: method
Symbol: `Autodesk.Revit.UI.SnappingServiceData.GetScreenMMToModelUnits`

#### Summary

Returns the conversion factor between mm on the screen and model units.

#### Returns

The conversion factor between mm on the screen and model units.

### `P:Autodesk.Revit.UI.SnappingServiceData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.SnappingServiceData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.SnappingServiceData.InPoint`

Member kind: property
Symbol: `Autodesk.Revit.UI.SnappingServiceData.InPoint`

#### Summary

Gets the point to snap near.

### `P:Autodesk.Revit.UI.SnappingServiceData.DBView`

Member kind: property
Symbol: `Autodesk.Revit.UI.SnappingServiceData.DBView`

#### Summary

Gets the View in which snapping is being done.

### `P:Autodesk.Revit.UI.SnappingServiceData.SnappingServers`

Member kind: property
Symbol: `Autodesk.Revit.UI.SnappingServiceData.SnappingServers`

#### Summary

Gets the snapping servers that are enabled.

### `T:Autodesk.Revit.UI.SnappingServiceData`

Member kind: type
Symbol: `Autodesk.Revit.UI.SnappingServiceData`

#### Summary

This is a container for data and some functions which is passed from Revit to an instance of
ISnappingServer.

#### Remarks

The snapping server reads the data and uses the functions to assist in finding snaps, then
sends the snaps back to SnappingServiceData using AddLineSnaps() and AddPointSnaps(), which
gives them back to Revit.

### `T:Autodesk.Revit.UI.SnappingServers`

Member kind: type
Symbol: `Autodesk.Revit.UI.SnappingServers`

#### Summary

Snapping Servers for elements like Point Clouds or Coordination Models.

#### Since

2024

#### Since

2024

### `F:Autodesk.Revit.UI.SnappingServers.CoordinationModel`

Member kind: field
Symbol: `Autodesk.Revit.UI.SnappingServers.CoordinationModel`

#### Summary

Snapping to Coordination Models elements is enabled.

### `F:Autodesk.Revit.UI.SnappingServers.PointCloud`

Member kind: field
Symbol: `Autodesk.Revit.UI.SnappingServers.PointCloud`

#### Summary

Snapping to Point Cloud elements is enabled.

### `F:Autodesk.Revit.UI.SnappingServers.None`

Member kind: field
Symbol: `Autodesk.Revit.UI.SnappingServers.None`

#### Summary

No element snaps enabled.

### `M:Autodesk.Revit.UI.ISnappingServerProxy.FindSnaps(Autodesk.Revit.UI.SnappingServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ISnappingServerProxy.FindSnaps(Autodesk.Revit.UI.SnappingServiceData)`

#### Summary

Finds snaps to the nearest point and to planes perpendicular to the work plane.

### `M:Autodesk.Revit.UI.ISnappingServer.FindSnaps(Autodesk.Revit.UI.SnappingServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ISnappingServer.FindSnaps(Autodesk.Revit.UI.SnappingServiceData)`

#### Summary

Finds snaps to the nearest point and to planes perpendicular to the work plane.

### `T:Autodesk.Revit.UI.ISnappingServer`

Member kind: type
Symbol: `Autodesk.Revit.UI.ISnappingServer`

#### Summary

An interface that all servers of SnappingService implement.

### `P:Autodesk.Revit.UI.SiteLinkerUIData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.SiteLinkerUIData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.SiteLinkerUIData.LevelId`

Member kind: property
Symbol: `Autodesk.Revit.UI.SiteLinkerUIData.LevelId`

#### Summary

TopographyLink member element level id.

#### Since

2019

### `P:Autodesk.Revit.UI.SiteLinkerUIData.ElemTypeId`

Member kind: property
Symbol: `Autodesk.Revit.UI.SiteLinkerUIData.ElemTypeId`

#### Summary

TopographyLink member element type id.

#### Since

2019

### `P:Autodesk.Revit.UI.SiteLinkerUIData.FilePath`

Member kind: property
Symbol: `Autodesk.Revit.UI.SiteLinkerUIData.FilePath`

#### Summary

The path of file to link.

#### Since

2019

### `T:Autodesk.Revit.UI.SiteLinkerUIData`

Member kind: type
Symbol: `Autodesk.Revit.UI.SiteLinkerUIData`

#### Summary

The data associated with the site insert service.

#### Since

2019

### `M:Autodesk.Revit.UI.ISiteLinkerUIServerProxy.ShowLinkDlg(Autodesk.Revit.DB.Document,System.Boolean,Autodesk.Revit.UI.SiteLinkerUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ISiteLinkerUIServerProxy.ShowLinkDlg(Autodesk.Revit.DB.Document,System.Boolean,Autodesk.Revit.UI.SiteLinkerUIData)`

#### Summary

The method that Revit will invoke to show link topography dialog.

#### Parameter `document`

The associated document.

#### Parameter `popSignin`

Popup the sign in dialog when user is not signed in.

#### Parameter `data`

The site linker ui data.

#### Returns

Indicates whether the site linker ui server is executed successfully.

#### Since

2019

### `M:Autodesk.Revit.UI.ISiteLinkerUIServerProxy.GetDBServerId`

Member kind: method
Symbol: `Autodesk.Revit.UI.ISiteLinkerUIServerProxy.GetDBServerId`

#### Summary

Implement this method to return the id of the server which is associated with this UI server.

#### Remarks

If there's no DB server associated with this UI server, an empty GUID value will be returned.

#### Returns

The id of the associated DB server.

#### Since

2019

### `M:Autodesk.Revit.UI.ISiteLinkerUIServer.ShowLinkDlg(Autodesk.Revit.DB.Document,System.Boolean,Autodesk.Revit.UI.SiteLinkerUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ISiteLinkerUIServer.ShowLinkDlg(Autodesk.Revit.DB.Document,System.Boolean,Autodesk.Revit.UI.SiteLinkerUIData)`

#### Summary

The method that Revit will invoke to show link topography dialog.

#### Parameter `document`

The associated document.

#### Parameter `popSignin`

Popup the sign in dialog when user is not signed in.

#### Parameter `data`

The site linker ui data.

#### Returns

Indicates whether the site linker ui server is executed successfully.

#### Since

2019

### `M:Autodesk.Revit.UI.ISiteLinkerUIServer.GetDBServerId`

Member kind: method
Symbol: `Autodesk.Revit.UI.ISiteLinkerUIServer.GetDBServerId`

#### Summary

Implement this method to return the id of the server which is associated with this UI server.

#### Remarks

If there's no DB server associated with this UI server, an empty GUID value will be returned.

#### Returns

The id of the associated DB server.

#### Since

2019

### `T:Autodesk.Revit.UI.ISiteLinkerUIServer`

Member kind: type
Symbol: `Autodesk.Revit.UI.ISiteLinkerUIServer`

#### Summary

The interface used to provide UI of link topography.

#### Since

2019

### `M:Autodesk.Revit.UI.RevisionsOnSheetUIServiceData.GetRevitElementIds`

Member kind: method
Symbol: `Autodesk.Revit.UI.RevisionsOnSheetUIServiceData.GetRevitElementIds`

#### Summary

return the list of revit Element Ids

### `M:Autodesk.Revit.UI.RevisionsOnSheetUIServiceData.GetParentHwnd`

Member kind: method
Symbol: `Autodesk.Revit.UI.RevisionsOnSheetUIServiceData.GetParentHwnd`

#### Summary

return the parent handle

### `P:Autodesk.Revit.UI.RevisionsOnSheetUIServiceData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevisionsOnSheetUIServiceData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.RevisionsOnSheetUIServiceData.Document`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevisionsOnSheetUIServiceData.Document`

#### Summary

return the document

### `P:Autodesk.Revit.UI.RevisionsOnSheetUIServiceData.IsReset`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevisionsOnSheetUIServiceData.IsReset`

#### Summary

flag to indicate the value has been reset

### `P:Autodesk.Revit.UI.RevisionsOnSheetUIServiceData.ParamId`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevisionsOnSheetUIServiceData.ParamId`

#### Summary

the parameter id

### `T:Autodesk.Revit.UI.RevisionsOnSheetUIServiceData`

Member kind: type
Symbol: `Autodesk.Revit.UI.RevisionsOnSheetUIServiceData`

#### Summary

UI data wrapper for RevisionsOnSheetUIService.

### `M:Autodesk.Revit.UI.IRevisionsOnSheetUIServerProxy.ShowDialog(Autodesk.Revit.UI.RevisionsOnSheetUIServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IRevisionsOnSheetUIServerProxy.ShowDialog(Autodesk.Revit.UI.RevisionsOnSheetUIServiceData)`

#### Summary

Shows dialog on managing RevisionsOnSheetUI.

#### Parameter `data`

The data on initializing the dialog as well as getting the result.

#### Returns

Whether or not the dialog launches successfully

#### Since

2024

### `M:Autodesk.Revit.UI.IRevisionsOnSheetUIServer.ShowDialog(Autodesk.Revit.UI.RevisionsOnSheetUIServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IRevisionsOnSheetUIServer.ShowDialog(Autodesk.Revit.UI.RevisionsOnSheetUIServiceData)`

#### Summary

Shows dialog on managing RevisionsOnSheetUI.

#### Parameter `data`

The data on initializing the dialog as well as getting the result.

#### Returns

Whether or not the dialog launches successfully

#### Since

2024

### `T:Autodesk.Revit.UI.IRevisionsOnSheetUIServer`

Member kind: type
Symbol: `Autodesk.Revit.UI.IRevisionsOnSheetUIServer`

#### Summary

The interface used to provide UI for sheet's Revisions On Sheet property.

#### Since

2024

### `M:Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIData.GetUIDataItems`

Member kind: method
Symbol: `Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIData.GetUIDataItems`

#### Summary

Gets all UI data items stored in the UI data.

#### Returns

An array of UI data items.

#### Since

2014

### `M:Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIData.GetUnits`

Member kind: method
Symbol: `Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIData.GetUnits`

#### Summary

Gets units.

#### Returns

The Units object.

#### Since

2014

### `P:Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIData`

Member kind: type
Symbol: `Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIData`

#### Summary

The input and output data used by external UI servers for storing UI settings.

#### Since

2014

### `M:Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIDataItem.GetPipeFittingAndAccessoryData`

Member kind: method
Symbol: `Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIDataItem.GetPipeFittingAndAccessoryData`

#### Summary

Gets the fitting data stored in the UI data item.

#### Returns

The fitting data stored in the UI data item.

#### Since

2014

### `M:Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIDataItem.SetEntity(Autodesk.Revit.DB.ExtensibleStorage.Entity)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIDataItem.SetEntity(Autodesk.Revit.DB.ExtensibleStorage.Entity)`

#### Summary

Stores the entity in the UI data item.

#### Parameter `entity`

The Entity to be stored.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Writing of Entities of this Schema is not allowed to the current add-in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIDataItem.GetEntity`

Member kind: method
Symbol: `Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIDataItem.GetEntity`

#### Summary

Returns the entity set by UI server.
or an invalid entity otherwise.

#### Remarks

The Entity that is returned is a copy of the stored data (with copy-on-write optimization).
Modifying it is allowed (even with restricted write), but to save your changes you must call SetEntity.

#### Returns

The returned Entity.

#### Since

2014

### `P:Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIDataItem.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIDataItem.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIDataItem`

Member kind: type
Symbol: `Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIDataItem`

#### Summary

The input and output data used by external UI servers for initializing and storing the UI settings.

#### Remarks

One family instance has one UI data item.
The UI data item contains a corresponding PipeFittingAndAccessoryData which is used for initialing the UI settings and an entity which is used for storing the UI settings.

#### Since

2014

### `M:Autodesk.Revit.UI.Plumbing.IPipeFittingAndAccessoryPressureDropUIServerProxy.ShowSettings(Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Plumbing.IPipeFittingAndAccessoryPressureDropUIServerProxy.ShowSettings(Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIData)`

#### Summary

Shows the settings UI.

#### Parameter `data`

The input data of the calculation.

#### Returns

True if the user makes any changes in the UI, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.UI.Plumbing.IPipeFittingAndAccessoryPressureDropUIServerProxy.GetDBServerId`

Member kind: method
Symbol: `Autodesk.Revit.UI.Plumbing.IPipeFittingAndAccessoryPressureDropUIServerProxy.GetDBServerId`

#### Summary

Returns the Id of the corresponding DB server for which this server provides an optional UI.

#### Remarks

Note that there may be only one UI server assigned to a DB calculation server.

#### Returns

The Id of the DB server.

#### Since

2014

### `M:Autodesk.Revit.UI.Plumbing.IPipeFittingAndAccessoryPressureDropUIServer.ShowSettings(Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Plumbing.IPipeFittingAndAccessoryPressureDropUIServer.ShowSettings(Autodesk.Revit.UI.Plumbing.PipeFittingAndAccessoryPressureDropUIData)`

#### Summary

Shows the settings UI.

#### Parameter `data`

The input data of the calculation.

#### Returns

True if the user makes any changes in the UI, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.UI.Plumbing.IPipeFittingAndAccessoryPressureDropUIServer.GetDBServerId`

Member kind: method
Symbol: `Autodesk.Revit.UI.Plumbing.IPipeFittingAndAccessoryPressureDropUIServer.GetDBServerId`

#### Summary

Returns the Id of the corresponding DB server for which this server provides an optional UI.

#### Remarks

Note that there may be only one UI server assigned to a DB calculation server.

#### Returns

The Id of the DB server.

#### Since

2014

### `T:Autodesk.Revit.UI.Plumbing.IPipeFittingAndAccessoryPressureDropUIServer`

Member kind: type
Symbol: `Autodesk.Revit.UI.Plumbing.IPipeFittingAndAccessoryPressureDropUIServer`

#### Summary

Interface for external servers providing optional UI for pipe fitting and pipe accessory coefficient calculation.

#### Remarks

This service works with pipe fitting and accessory pressure drop service. It provides the settings for the pipe fitting and accessory pressure drop server if needed;
and it also provides UI for user to input the settings in Revit.
A typical way to use the external server can be:
Implement a server class that derives from this interface

Create a new server object and register it with the service.

#### Since

2014

### `M:Autodesk.Revit.UI.IIFCEntityTreeUIServerProxy.ShowDialog(Autodesk.Revit.UI.IFCExternalServiceUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IIFCEntityTreeUIServerProxy.ShowDialog(Autodesk.Revit.UI.IFCExternalServiceUIData)`

#### Summary

Shows dialog on managing IFCEntityTreeUI.

#### Parameter `data`

The data on initializing the dialog as well as getting the result.

#### Returns

Whether or not the dialog launches successfully

#### Since

2023

### `M:Autodesk.Revit.UI.IIFCEntityTreeUIServer.ShowDialog(Autodesk.Revit.UI.IFCExternalServiceUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IIFCEntityTreeUIServer.ShowDialog(Autodesk.Revit.UI.IFCExternalServiceUIData)`

#### Summary

Shows dialog on managing IFCEntityTreeUI.

#### Parameter `data`

The data on initializing the dialog as well as getting the result.

#### Returns

Whether or not the dialog launches successfully

#### Since

2023

### `T:Autodesk.Revit.UI.IIFCEntityTreeUIServer`

Member kind: type
Symbol: `Autodesk.Revit.UI.IIFCEntityTreeUIServer`

#### Summary

The interface used to provide UI on IFC Entity selection.

#### Since

2023

### `M:Autodesk.Revit.UI.IFCExternalServiceUIData.GetRevitElementIds`

Member kind: method
Symbol: `Autodesk.Revit.UI.IFCExternalServiceUIData.GetRevitElementIds`

#### Summary

return the list of revit Element Ids

#### Since

2023

### `M:Autodesk.Revit.UI.IFCExternalServiceUIData.GetParentHwnd`

Member kind: method
Symbol: `Autodesk.Revit.UI.IFCExternalServiceUIData.GetParentHwnd`

#### Summary

return the parent handle

#### Since

2023

### `P:Autodesk.Revit.UI.IFCExternalServiceUIData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.IFCExternalServiceUIData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.IFCExternalServiceUIData.Document`

Member kind: property
Symbol: `Autodesk.Revit.UI.IFCExternalServiceUIData.Document`

#### Summary

return the document

### `P:Autodesk.Revit.UI.IFCExternalServiceUIData.IsReset`

Member kind: property
Symbol: `Autodesk.Revit.UI.IFCExternalServiceUIData.IsReset`

#### Summary

flag to indicate the value has been reset

### `P:Autodesk.Revit.UI.IFCExternalServiceUIData.ParamId`

Member kind: property
Symbol: `Autodesk.Revit.UI.IFCExternalServiceUIData.ParamId`

#### Summary

the parameter id

### `P:Autodesk.Revit.UI.IFCExternalServiceUIData.SelectedIFCItem`

Member kind: property
Symbol: `Autodesk.Revit.UI.IFCExternalServiceUIData.SelectedIFCItem`

#### Summary

The selected IFC Item (can be IFC Entity, or PredefinedType)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `T:Autodesk.Revit.UI.IFCExternalServiceUIData`

Member kind: type
Symbol: `Autodesk.Revit.UI.IFCExternalServiceUIData`

#### Summary

UI data wrapper for IFCExternalServiceUIData.

### `M:Autodesk.Revit.UI.IExternalResourceUIServerProxy.HandleBrowseResult(Autodesk.Revit.DB.ExternalResourceUIBrowseResultType,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalResourceUIServerProxy.HandleBrowseResult(Autodesk.Revit.DB.ExternalResourceUIBrowseResultType,System.String)`

#### Summary

Implement this method to handle results from browsing external resources
in the UI. It is recommended that the server only respond in the case of a critical error.

#### Remarks

This method will be called automatically when the user browses for external resources,
such as listing folders and resources of an external server or a subfolder,
or choosing an external resource in the add resource dialog.

#### Parameter `resultType`

The result of the browsing operation.

#### Parameter `browsingItemPath`

The absolute path of the current item being browsed.

#### Since

2015

### `M:Autodesk.Revit.UI.IExternalResourceUIServerProxy.HandleLoadResourceResults(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ExternalResourceLoadData})`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalResourceUIServerProxy.HandleLoadResourceResults(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ExternalResourceLoadData})`

#### Summary

Implement this method to display any UI related to messages or errors that result when the DB server
associated with this UI server attempts to load an external resource.

#### Remarks

This method will be called automatically by Revit after the external resource load process is complete.

Note that automatic loads can occur in the context of other operations such as opening a file.
During automatic loads, it is therefore recommended that the server only display UI that is critical
for the user to see (such as error message).

The loading operation type is Explicit when the user is specifically trying to reload the resource.
During explicit loads, it may be desirable to provide more feedback to the user, such as specific feedback
that the load operation succeeded.

The loading operation type can be accessed through `T:Autodesk.Revit.DB.ExternalResourceLoadContext` .

Note that providing messages and other UI feedback for Revit links is more complicated,
because links can be nested. The UI server may wish to provide different messages and take
different actions, depending on whether a link loaded from the DB server was a "top-level" link,
or was nested. For example, while it may be possible to correct an error that occurred with a
top-level link by loading it directly, this cannot be done with a nested link, as Revit will throw
an exception.

To complicate things further, the same Revit document may appear more than once in a tree of nested
links, and the UI server should avoid repeatedly posting the same message for instances of that
document.

To help UI servers handle situations where a nested tree of links is loaded:
Each UI server whose DB server loaded one or more links in the tree will only be called once.The collection of ExternalResourceLoadData objects passed into this method will include
only those for links loaded by this server's DB server.The LinkLoadResults object contained in all ExternalResourceLoadData objects will always
be the results for the top-level link, even if the top-level link was not loaded by this
server's DB server. The LinkLoadResults class contains methods for navigating the full tree of
load results (starting with the top node), so the UI server will be able to determine the complete
context in which one of its DB server's resources was loaded.Servers should only report results for their own link, whether they are nested or not.

#### Parameter `document`

The document into which resources were loaded.

#### Parameter `loadData`

A collection of ExternalResourceLoadData objects containing information about an attempt to load one or more
external resources,
including:
the load request Id

the type of resource that was loaded

information to identify the particular resource that was loaded

the actual content obtained during the load attempt

the context of the load operations, e.g. LoadOperationType::Explicit for an explicit loading, LoadOperationType::Automatic for an automatic loading

a settable property indicating whether the server reported any errors for the resource
The ExternalResourceLoadData contains a property, ErrorsReported, which the server can
use to indicate whether it handled any errors for the resource.

For Revit links specifically, Revit will check this value to see
if it should report errors about a given link in the Unresolved
References dialog. An IExternalResourceUIServer can set this value
to true to avoid redundant messages.

Note that it is possible for Revit to encounter errors internally
even if the server successfully provides a reference. In general, this
value should only be set to true if the server has reported an
error condition.

#### Since

2015

### `M:Autodesk.Revit.UI.IExternalResourceUIServerProxy.GetDBServerId`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalResourceUIServerProxy.GetDBServerId`

#### Summary

Implement this method to return the id of the server which is associated with this UI server.

#### Remarks

If there's no DB server associated with this UI server, an empty GUID value will be returned.

#### Returns

The id of the associated DB server.

#### Since

2015

### `M:Autodesk.Revit.UI.IExternalResourceUIServer.HandleBrowseResult(Autodesk.Revit.DB.ExternalResourceUIBrowseResultType,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalResourceUIServer.HandleBrowseResult(Autodesk.Revit.DB.ExternalResourceUIBrowseResultType,System.String)`

#### Summary

Implement this method to handle results from browsing external resources
in the UI. It is recommended that the server only respond in the case of a critical error.

#### Remarks

This method will be called automatically when the user browses for external resources,
such as listing folders and resources of an external server or a subfolder,
or choosing an external resource in the add resource dialog.

#### Parameter `resultType`

The result of the browsing operation.

#### Parameter `browsingItemPath`

The absolute path of the current item being browsed.

#### Since

2015

### `M:Autodesk.Revit.UI.IExternalResourceUIServer.HandleLoadResourceResults(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ExternalResourceLoadData})`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalResourceUIServer.HandleLoadResourceResults(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ExternalResourceLoadData})`

#### Summary

Implement this method to display any UI related to messages or errors that result when the DB server
associated with this UI server attempts to load an external resource.

#### Remarks

This method will be called automatically by Revit after the external resource load process is complete.

Note that automatic loads can occur in the context of other operations such as opening a file.
During automatic loads, it is therefore recommended that the server only display UI that is critical
for the user to see (such as error message).

The loading operation type is Explicit when the user is specifically trying to reload the resource.
During explicit loads, it may be desirable to provide more feedback to the user, such as specific feedback
that the load operation succeeded.

The loading operation type can be accessed through `T:Autodesk.Revit.DB.ExternalResourceLoadContext` .

Note that providing messages and other UI feedback for Revit links is more complicated,
because links can be nested. The UI server may wish to provide different messages and take
different actions, depending on whether a link loaded from the DB server was a "top-level" link,
or was nested. For example, while it may be possible to correct an error that occurred with a
top-level link by loading it directly, this cannot be done with a nested link, as Revit will throw
an exception.

To complicate things further, the same Revit document may appear more than once in a tree of nested
links, and the UI server should avoid repeatedly posting the same message for instances of that
document.

To help UI servers handle situations where a nested tree of links is loaded:
Each UI server whose DB server loaded one or more links in the tree will only be called once.The collection of ExternalResourceLoadData objects passed into this method will include
only those for links loaded by this server's DB server.The LinkLoadResults object contained in all ExternalResourceLoadData objects will always
be the results for the top-level link, even if the top-level link was not loaded by this
server's DB server. The LinkLoadResults class contains methods for navigating the full tree of
load results (starting with the top node), so the UI server will be able to determine the complete
context in which one of its DB server's resources was loaded.Servers should only report results for their own link, whether they are nested or not.

#### Parameter `document`

The document into which resources were loaded.

#### Parameter `loadData`

A collection of ExternalResourceLoadData objects containing information about an attempt to load one or more
external resources,
including:
the load request Id

the type of resource that was loaded

information to identify the particular resource that was loaded

the actual content obtained during the load attempt

the context of the load operations, e.g. LoadOperationType::Explicit for an explicit loading, LoadOperationType::Automatic for an automatic loading

a settable property indicating whether the server reported any errors for the resource
The ExternalResourceLoadData contains a property, ErrorsReported, which the server can
use to indicate whether it handled any errors for the resource.

For Revit links specifically, Revit will check this value to see
if it should report errors about a given link in the Unresolved
References dialog. An IExternalResourceUIServer can set this value
to true to avoid redundant messages.

Note that it is possible for Revit to encounter errors internally
even if the server successfully provides a reference. In general, this
value should only be set to true if the server has reported an
error condition.

#### Since

2015

### `M:Autodesk.Revit.UI.IExternalResourceUIServer.GetDBServerId`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalResourceUIServer.GetDBServerId`

#### Summary

Implement this method to return the id of the server which is associated with this UI server.

#### Remarks

If there's no DB server associated with this UI server, an empty GUID value will be returned.

#### Returns

The id of the associated DB server.

#### Since

2015

### `T:Autodesk.Revit.UI.IExternalResourceUIServer`

Member kind: type
Symbol: `Autodesk.Revit.UI.IExternalResourceUIServer`

#### Summary

The interface used to provide custom handling of UI operations related to external resources.

#### Remarks

IExternalResourceUIServer is the UI server associated with IExternalResourceServer.
IExternalResourceServer provides an interface for loading an external resource (such as a Revit
link or the keynote data) from a source outside of Revit. IExternalResourceUIServer provides
an interface for displaying the results of such an operation to the Revit user.

IExternalResourceUIServers must be associated with an IExternalResourceServer in order
to display any UI. Implement `M:Autodesk.Revit.UI.IExternalResourceUIServer.GetDBServerId` to declare a relationship
between an IExternalResourceUIServer and an IExternalResourceServer.

The primary method in IExternalResourceUIServer is `M:Autodesk.Revit.UI.IExternalResourceUIServer.HandleLoadResourceResults(Autodesk.Revit.DB.Document,System.Collections.Generic.IList`1{Autodesk.Revit.DB.ExternalResourceLoadData})` .
After an IExternalResourceServer loads an external resource, Revit will call
HandleLoadResourceResults() on the IExternalResourceUIServer, so that it may display any
related UI. Revit will provide an ExternalResourceLoadData to the UI server, which will
contain information about the resource which was loaded, information about the context of
the load operation, and any Revit-side errors.

The ExternalResourceLoadData passed to HandleLoadResourceResults will also contain a GUID
to uniquely identify the load request. This identifier can help IExternalResourceUIServers
query their IExternalResourceServers for additional information about errors that occurred
during specific load operations. Particularly, the IExternalResourceUIServer may wish to
ask the IExternalResourceServer about errors which Revit is not aware of. For example,
if the IExternalResourceServer includes a website and the user is not logged in, Revit
will not have any information about this error.

#### Since

2015

### `M:Autodesk.Revit.UI.Electrical.IElectricalAnalyticalLoadSetUIServerProxy.ShowDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Electrical.IElectricalAnalyticalLoadSetUIServerProxy.ShowDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData)`

#### Summary

Shows dialog on managing Electrical Analytical Load Set.

#### Parameter `document`

The associated document.

#### Parameter `data`

The data on initializing the dialog as well as getting the result.

#### Returns

Whether or not the dialog launches successfully.

### `M:Autodesk.Revit.UI.Electrical.IElectricalAnalyticalLoadSetUIServer.ShowDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Electrical.IElectricalAnalyticalLoadSetUIServer.ShowDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData)`

#### Summary

Shows dialog on managing Electrical Analytical Load Set.

#### Parameter `document`

The associated document.

#### Parameter `data`

The data on initializing the dialog as well as getting the result.

#### Returns

Whether or not the dialog launches successfully.

### `T:Autodesk.Revit.UI.Electrical.IElectricalAnalyticalLoadSetUIServer`

Member kind: type
Symbol: `Autodesk.Revit.UI.Electrical.IElectricalAnalyticalLoadSetUIServer`

#### Summary

The interface used to provide UI on managing Electrical Analytical Load Set.

### `M:Autodesk.Revit.UI.Electrical.IElectricalAnalyticalLoadCombinationUIServerProxy.ShowDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadCombinationUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Electrical.IElectricalAnalyticalLoadCombinationUIServerProxy.ShowDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadCombinationUIData)`

#### Summary

Shows dialog on managing Electrical Analytical Load Combination.

#### Parameter `document`

The associated document.

#### Parameter `data`

The data on initializing the dialog as well as getting the result.

#### Returns

Whether or not the dialog launches successfully.

### `M:Autodesk.Revit.UI.Electrical.IElectricalAnalyticalLoadCombinationUIServer.ShowDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadCombinationUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Electrical.IElectricalAnalyticalLoadCombinationUIServer.ShowDialog(Autodesk.Revit.DB.Document,Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadCombinationUIData)`

#### Summary

Shows dialog on managing Electrical Analytical Load Combination.

#### Parameter `document`

The associated document.

#### Parameter `data`

The data on initializing the dialog as well as getting the result.

#### Returns

Whether or not the dialog launches successfully.

### `T:Autodesk.Revit.UI.Electrical.IElectricalAnalyticalLoadCombinationUIServer`

Member kind: type
Symbol: `Autodesk.Revit.UI.Electrical.IElectricalAnalyticalLoadCombinationUIServer`

#### Summary

The interface used to provide UI on managing Electrical Analytical Load Combination.

### `M:Autodesk.Revit.UI.Mechanical.IDuctFittingAndAccessoryPressureDropUIServerProxy.ShowSettings(Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Mechanical.IDuctFittingAndAccessoryPressureDropUIServerProxy.ShowSettings(Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIData)`

#### Summary

Shows the settings UI.

#### Parameter `data`

The input data of the calculation.

#### Returns

True if the user makes any changes in the UI, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.UI.Mechanical.IDuctFittingAndAccessoryPressureDropUIServerProxy.GetDBServerId`

Member kind: method
Symbol: `Autodesk.Revit.UI.Mechanical.IDuctFittingAndAccessoryPressureDropUIServerProxy.GetDBServerId`

#### Summary

Returns the Id of the corresponding DB server for which this server provides an optional UI.

#### Remarks

Note that there may be only one UI server assigned to a DB calculation server.

#### Returns

The Id of the DB server.

#### Since

2014

### `M:Autodesk.Revit.UI.Mechanical.IDuctFittingAndAccessoryPressureDropUIServer.ShowSettings(Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Mechanical.IDuctFittingAndAccessoryPressureDropUIServer.ShowSettings(Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIData)`

#### Summary

Shows the settings UI.

#### Parameter `data`

The input data of the calculation.

#### Returns

True if the user makes any changes in the UI, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.UI.Mechanical.IDuctFittingAndAccessoryPressureDropUIServer.GetDBServerId`

Member kind: method
Symbol: `Autodesk.Revit.UI.Mechanical.IDuctFittingAndAccessoryPressureDropUIServer.GetDBServerId`

#### Summary

Returns the Id of the corresponding DB server for which this server provides an optional UI.

#### Remarks

Note that there may be only one UI server assigned to a DB calculation server.

#### Returns

The Id of the DB server.

#### Since

2014

### `T:Autodesk.Revit.UI.Mechanical.IDuctFittingAndAccessoryPressureDropUIServer`

Member kind: type
Symbol: `Autodesk.Revit.UI.Mechanical.IDuctFittingAndAccessoryPressureDropUIServer`

#### Summary

Interface for external servers providing optional UI for duct fitting and duct accessory coefficient calculation.

#### Remarks

This service works with duct fitting and accessory pressure drop service. It provides the settings for the duct fitting and accessory pressure drop server if needed;
and it also provides UI for user to input the settings in Revit.
A typical way to use the external server can be:
Implement a server class that derives from this interface

Create a new server object and register it with the service.

#### Since

2014

### `M:Autodesk.Revit.UI.ICustomFieldEditPropertiesServerProxy.EditProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField,System.IntPtr)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ICustomFieldEditPropertiesServerProxy.EditProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField,System.IntPtr)`

#### Summary

Override this function to start editing the custom field properties.
When this function is called it should launch the properties dialog which will allow the user to
modify the values for the input properties.
The edited properties should not be written into the Revit document during the call of this function,
they should just be returned. Once that the parent dialog is closed by pressing the OK button
it will be called `M:Autodesk.Revit.DB.ICustomFieldServer.SetCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField)` .
which will have as an argument the properties returned by this function.
If the parent dialog is closed by pressing the Cancel button, the edited properties will be
discarded (they will not be saved into the document).

#### Parameter `customFieldPropertiesToBeEdited`

The prioperties that needs to be edited.
By default, these properties are the ones saved for the custom field.
They will be obtained by calling `M:Autodesk.Revit.DB.ICustomFieldServer.GetCustomFieldProperties(Autodesk.Revit.DB.ScheduleField)` .
Once that the properties are edited and returned by this function they will be used as an input for
the next call to this function until the parent dialog will be closed.

#### Parameter `scheduleField`

The field that is controlled by this server.

#### Parameter `parentWindowHandle`

The handle of the current opened window.

#### Returns

Returns an instance of `T:Autodesk.Revit.DB.ICustomFieldProperties` which
represent the edited properties (with the new values).
If the properties were not edited, it should return `null` . For example, if the user
close the edit custom field properties dialog by pressing Cancel button, it should return `null` .

### `M:Autodesk.Revit.UI.ICustomFieldEditPropertiesServerProxy.GetCustomFieldServerId`

Member kind: method
Symbol: `Autodesk.Revit.UI.ICustomFieldEditPropertiesServerProxy.GetCustomFieldServerId`

#### Summary

Gets the id of the server that defines the custom field whose properties are edited.

#### Returns

Returns the id of the server that defines the custom field whose properties are edited.

### `M:Autodesk.Revit.UI.ICustomFieldEditPropertiesServer.EditProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField,System.IntPtr)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ICustomFieldEditPropertiesServer.EditProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField,System.IntPtr)`

#### Summary

Override this function to start editing the custom field properties.
When this function is called it should launch the properties dialog which will allow the user to
modify the values for the input properties.
The edited properties should not be written into the Revit document during the call of this function,
they should just be returned. Once that the parent dialog is closed by pressing the OK button
it will be called `M:Autodesk.Revit.DB.ICustomFieldServer.SetCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField)` .
which will have as an argument the properties returned by this function.
If the parent dialog is closed by pressing the Cancel button, the edited properties will be
discarded (they will not be saved into the document).

#### Parameter `customFieldPropertiesToBeEdited`

The prioperties that needs to be edited.
By default, these properties are the ones saved for the custom field.
They will be obtained by calling `M:Autodesk.Revit.DB.ICustomFieldServer.GetCustomFieldProperties(Autodesk.Revit.DB.ScheduleField)` .
Once that the properties are edited and returned by this function they will be used as an input for
the next call to this function until the parent dialog will be closed.

#### Parameter `scheduleField`

The field that is controlled by this server.

#### Parameter `parentWindowHandle`

The handle of the current opened window.

#### Returns

Returns an instance of `T:Autodesk.Revit.DB.ICustomFieldProperties` which
represent the edited properties (with the new values).
If the properties were not edited, it should return `null` . For example, if the user
close the edit custom field properties dialog by pressing Cancel button, it should return `null` .

### `M:Autodesk.Revit.UI.ICustomFieldEditPropertiesServer.GetCustomFieldServerId`

Member kind: method
Symbol: `Autodesk.Revit.UI.ICustomFieldEditPropertiesServer.GetCustomFieldServerId`

#### Summary

Gets the id of the server that defines the custom field whose properties are edited.

#### Returns

Returns the id of the server that defines the custom field whose properties are edited.

### `T:Autodesk.Revit.UI.ICustomFieldEditPropertiesServer`

Member kind: type
Symbol: `Autodesk.Revit.UI.ICustomFieldEditPropertiesServer`

#### Summary

Represents an interface that should be overridden to allow the possibility to edit through
a dialog the custom field properties.

This is part of the Schedule Custom Field implementation.
This server was designed to be public_api but in the end it was decided to be moved to public_api_internal
because the a custom field defined by a third party can't be computed when publish the rvt file into the cloud.
The computation of the value and graphics is done in generateGrep and if the addon the defines the server is not
present it the cell will be empty.
Decision can be found here:
https://autodesk.slack.com/archives/C02KQUH4519/p1673018478447789
https://wiki.autodesk.com/display/aeceng/Public+availability+of+the+Custom+Graphics+API#decision_framework-1761429744

### `M:Autodesk.Revit.UI.FilterDialog.Show`

Member kind: method
Symbol: `Autodesk.Revit.UI.FilterDialog.Show`

#### Summary

Shows the FilterDialog editing dialog to the user.

#### Remarks

If an existing FilterElement id was set during construction of the object or through the FilterToSelect property,
that FilterElement will be selected for editing.

If a new filter name was set during construction of the object or through the NewFilterName property,
a new ParameterFilterElement will be created and that new element will be selected for editing.
If this option was chosen, the id of the explicitly create new filter will be stored in the NewFilterId property.

Note that the user may opt to add, delete or edit any of the available filter elements (or make no changes at all).
To monitor which filters have been changed, use other Revit API mechanisms such as Dynamic Update or the DocumentChanged event.

#### Since

2015

### `P:Autodesk.Revit.UI.FilterDialog.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.FilterDialog.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.FilterDialog.NewFilterName`

Member kind: property
Symbol: `Autodesk.Revit.UI.FilterDialog.NewFilterName`

#### Summary

The name of the new ParameterFilterElement to be created and selected once Show is invoked.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: newFilterName is an empty string.
-or-
When setting this property: newFilterName cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
When setting this property: The supplied filter name newFilterName is not unique.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.UI.FilterDialog.FilterToSelect`

Member kind: property
Symbol: `Autodesk.Revit.UI.FilterDialog.FilterToSelect`

#### Summary

The filter element to be selected once Show is invoked.

#### Value

The default is InvalidElementId, resulting in selecting the first available (if any) FilterElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The supplied ElementId id is not of a FilterElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.UI.FilterDialog.NewFilterId`

Member kind: property
Symbol: `Autodesk.Revit.UI.FilterDialog.NewFilterId`

#### Summary

The ElementId of the new filter created.
The value is populated after Show method is executed.

#### Since

2015

### `M:Autodesk.Revit.UI.FilterDialog.#ctor(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.FilterDialog.#ctor(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Constructs a new instance of the FilterDialog class,
while setting the name of the new ParameterFilterElement to be created and selected for editing.

#### Remarks

Show the dialog with the Show() method after setting the desired options.

#### Parameter `doc`

The document that owns the FilterElements displayed and edited in the dialog.

#### Parameter `name`

The user-visible name for the new ParameterFilterElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
The given value for name is already in use as a filter element name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.UI.FilterDialog.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.FilterDialog.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a new instance of the FilterDialog class,
while setting the id of the FilterElement to be selected when the dialog is shown.

#### Remarks

Show the dialog with the Show() method after setting the desired options.

#### Parameter `doc`

The document that owns the FilterElements displayed and edited in the dialog.

#### Parameter `filterToSelect`

The FilterElement to be selected.
If InvalidElementId, then the first (if any) available FilterElement will be selected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The supplied ElementId filterToSelect is not of a FilterElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.UI.FilterDialog`

Member kind: type
Symbol: `Autodesk.Revit.UI.FilterDialog`

#### Summary

Allows display of the dialog used to create and edit FilterElements in Autodesk Revit.

#### Remarks

The class provides the option to launch the dialog by selecting an existing FilterElement,
or automatically creating a new ParameterFilterElement.
In both cases the affected element will be selected for editing.
Note that the user may opt to add, delete or edit any of the available filter elements (or make no changes at all).

#### Since

2015

### `P:Autodesk.Revit.UI.FileSaveDialog.EnableCloudWorkflow`

Member kind: property
Symbol: `Autodesk.Revit.UI.FileSaveDialog.EnableCloudWorkflow`

#### Summary

Indicates if the File Save Dialog should enable working with files in the cloud.

#### Since

2017

### `P:Autodesk.Revit.UI.FileSaveDialog.InitialFileName`

Member kind: property
Symbol: `Autodesk.Revit.UI.FileSaveDialog.InitialFileName`

#### Summary

The initial file name to be shown for this save operation.

#### Value

This would typically be a name derived by the application that matches the purpose of the save operation
it intends to do. The user is permitted to alter the initial file name.

If the extension is not included, the file would be given the selected file extension
for the active filter (when saved). If the extension is included, it will be ignored if the extension does
not match one of the possible filter extensions. When not set, the file name entry field in the dialog will
be blank and the user will have to enter a file name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: initialFileName cannot include prohibited unprintable characters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.UI.FileSaveDialog.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.FileSaveDialog.#ctor(System.String)`

#### Summary

Constructs a new instance of a File Save dialog.

#### Parameter `filter`

The filter string. See the remarks for `P:Autodesk.Revit.UI.FileDialog.Filter` for details.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input filter string does not meet the minimal requirements for a valid filter string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.UI.FileSaveDialog`

Member kind: type
Symbol: `Autodesk.Revit.UI.FileSaveDialog`

#### Summary

This class allows an add-in to prompt the user with the Revit dialog used to navigate to and select an existing
or new file path. This dialog is typically used to enter a file name for saving or exporting.

#### Remarks

The behavior and appearance of this dialog matches the Revit "Save as" dialog. This is a general-purpose dialog
for saving any given file type, and the Options shown in the dialog for Revit projects and families will not be
shown. To prompt the user to save the active Revit document specifically, use UIDocument.SaveAs(UISaveAsOptions) instead.

The user will be requested to select or enter a file name matching the corresponding filter.
If an existing file is selected, there will be
a default prompt about overwriting the file shown, where the user can confirm or cancel this file selection.

The folder location shown when the dialog is displayed defaults to the most recently used file location
for saving or exporting.

Use of this dialog does not actually save an existing file, but it will provide the selected file path
back to the caller to take any action necessary.

#### Since

2017

### `P:Autodesk.Revit.UI.FileOpenDialog.ShowPreview`

Member kind: property
Symbol: `Autodesk.Revit.UI.FileOpenDialog.ShowPreview`

#### Summary

Identifies if the dialog should include a region showing a preview of the selected file.

#### Value

The default value is false, to not show the preview area in the dialog. If set to true, note that
Revit may not be able to show a preview of all possible file types.

#### Since

2017

### `M:Autodesk.Revit.UI.FileOpenDialog.#ctor(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.FileOpenDialog.#ctor(System.String,System.String)`

#### Summary

Constructs a new instance of a File Open dialog with initial folder.

#### Parameter `filter`

The filter string. See the remarks for `P:Autodesk.Revit.UI.FileDialog.Filter` for details.

#### Parameter `initialFolder`

Initial folder to browse to when showing the dialog.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input filter string does not meet the minimal requirements for a valid filter string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.UI.FileOpenDialog.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.FileOpenDialog.#ctor(System.String)`

#### Summary

Constructs a new instance of a File Open dialog.

#### Parameter `filter`

The filter string. See the remarks for `P:Autodesk.Revit.UI.FileDialog.Filter` for details.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input filter string does not meet the minimal requirements for a valid filter string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.UI.FileOpenDialog`

Member kind: type
Symbol: `Autodesk.Revit.UI.FileOpenDialog`

#### Summary

This class allows an add-in to prompt the user with the Revit dialog used to navigate to and select an existing
file path. This dialog is typically used to select a file for opening or importing.

#### Remarks

The behavior and appearance of this dialog matches the Revit "Open" dialog. This is a general-purpose dialog
for opening any given file type, and options to configure settings like worksharing options will not be included.

The user will be prompted to select an existing file that matches one of the provided filters. The user may not
enter a file name that does not exist.

The folder location shown when the dialog is displayed defaults to the most recently used file location
for opening or importing.

Use of this dialog does not actually open an existing file, but it will provide the selected file path
back to the caller to take any action necessary.

#### Since

2017

### `M:Autodesk.Revit.UI.FedRampSupportService.CheckFedRampEnvironment(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.FedRampSupportService.CheckFedRampEnvironment(System.Boolean)`

#### Summary

Checks whether the current Revit process is running in FedRAMP environment.

#### Parameter `toShowFeatureNotAvailable`

To show a standard error message indicating featureas are not available in RedRAMP environment.

#### Since

2024

### `P:Autodesk.Revit.UI.FedRampSupportService.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.FedRampSupportService.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.UI.FedRampSupportService`

Member kind: type
Symbol: `Autodesk.Revit.UI.FedRampSupportService`

#### Summary

UI service guarding accesses to cloud features in FedRAMP environment.

#### Since

2024

### `P:Autodesk.Revit.UI.FamilyInstancePlacingArgs.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.FamilyInstancePlacingArgs.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.FamilyInstancePlacingArgs.TooltipMessage`

Member kind: property
Symbol: `Autodesk.Revit.UI.FamilyInstancePlacingArgs.TooltipMessage`

#### Summary

The message to be shown via tooltip

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.UI.FamilyInstancePlacingArgs.StatusMessage`

Member kind: property
Symbol: `Autodesk.Revit.UI.FamilyInstancePlacingArgs.StatusMessage`

#### Summary

The message to be shown on the status bar

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.UI.FamilyInstancePlacingArgs.IsBanned`

Member kind: property
Symbol: `Autodesk.Revit.UI.FamilyInstancePlacingArgs.IsBanned`

#### Summary

Indicates if the cursor is banned or not.

#### Since

2017

### `P:Autodesk.Revit.UI.FamilyInstancePlacingArgs.ActiveView`

Member kind: property
Symbol: `Autodesk.Revit.UI.FamilyInstancePlacingArgs.ActiveView`

#### Summary

The active view

#### Since

2017

### `T:Autodesk.Revit.UI.FamilyInstancePlacingArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.FamilyInstancePlacingArgs`

#### Summary

The class is used to access necessary data during the placement of a FamilyInstance.

#### Since

2017

### `M:Autodesk.Revit.UI.ElemAttribDialogUtil.ShowEnergyDataSettingsDialog(Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ElemAttribDialogUtil.ShowEnergyDataSettingsDialog(Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

Shows the Energy Data Settings dialog.

#### Parameter `doc`

The document of energy data settings to be displayed.

#### Parameter `isAdvanced`

Indicates if the dialog is for the advanced option.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.UI.ElemAttribDialogUtil`

Member kind: type
Symbol: `Autodesk.Revit.UI.ElemAttribDialogUtil`

#### Summary

Provides internal utility methods that display the element attribute dialog.

#### Since

2022

### `M:Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.GetEditedLoadSetId`

Member kind: method
Symbol: `Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.GetEditedLoadSetId`

#### Summary

Get current edited load set.

### `M:Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.SetEditedLoadSetId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.SetEditedLoadSetId(Autodesk.Revit.DB.ElementId)`

#### Summary

Set current edited load set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.SetCurrentLoads(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.SetCurrentLoads(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Set current loads in current load set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.GetCurrentLoads`

Member kind: method
Symbol: `Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.GetCurrentLoads`

#### Summary

Get current loads in current load set.

### `M:Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.SetAvailableLoads(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.SetAvailableLoads(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Set all the available loads that can be added to current load set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.GetAvailableLoadMap`

Member kind: method
Symbol: `Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.GetAvailableLoadMap`

#### Summary

Get the available load map contains all the loads that can be added to current load set, and
its current corresponding LoadSet id.

### `P:Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData`

Member kind: type
Symbol: `Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadSetUIData`

#### Summary

The input and output data used by external UI servers for storing UI settings.
TODO: Change to ElementIdSet after getLoadSet exposed as public api in PointLoadData.

### `M:Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadCombinationUIData.GetLoadLoadSetMap`

Member kind: method
Symbol: `Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadCombinationUIData.GetLoadLoadSetMap`

#### Summary

Get the mapping of Load and the LoadSet it belongs to(will be invalidElementId
if the Load doesn't belong to any LoadSets).

### `M:Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadCombinationUIData.Initialize(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadCombinationUIData.Initialize(Autodesk.Revit.DB.Document)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadCombinationUIData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadCombinationUIData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadCombinationUIData`

Member kind: type
Symbol: `Autodesk.Revit.UI.Electrical.ElectricalAnalyticalLoadCombinationUIData`

#### Summary

The input and output data used by external UI servers for storing UI settings.
Load and its belonged LoadSet mapping.

### `M:Trf.#ctor(Trf!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `Trf.#ctor(Trf!System.Runtime.CompilerServices.IsConst*)`

### `M:Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIData.GetUIDataItems`

Member kind: method
Symbol: `Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIData.GetUIDataItems`

#### Summary

Gets all UI data items stored in the UI data.

#### Returns

An array of UI data items.

#### Since

2014

### `M:Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIData.GetUnits`

Member kind: method
Symbol: `Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIData.GetUnits`

#### Summary

Gets units.

#### Returns

The Units object.

#### Since

2014

### `P:Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIData`

Member kind: type
Symbol: `Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIData`

#### Summary

The input and output data used by external UI servers for storing UI settings.

#### Since

2014

### `M:Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIDataItem.GetDuctFittingAndAccessoryData`

Member kind: method
Symbol: `Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIDataItem.GetDuctFittingAndAccessoryData`

#### Summary

Gets the fitting data stored in the UI data item.

#### Returns

The fitting data stored in the UI data item.

#### Since

2014

### `M:Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIDataItem.SetEntity(Autodesk.Revit.DB.ExtensibleStorage.Entity)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIDataItem.SetEntity(Autodesk.Revit.DB.ExtensibleStorage.Entity)`

#### Summary

Stores the entity in the UI data item.

#### Parameter `entity`

The Entity to be stored.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Writing of Entities of this Schema is not allowed to the current add-in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIDataItem.GetEntity`

Member kind: method
Symbol: `Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIDataItem.GetEntity`

#### Summary

Returns the entity set by UI server.
or an invalid entity otherwise.

#### Remarks

The Entity that is returned is a copy of the stored data (with copy-on-write optimization).
Modifying it is allowed (even with restricted write), but to save your changes you must call SetEntity.

#### Returns

The returned Entity.

#### Since

2014

### `P:Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIDataItem.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIDataItem.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIDataItem`

Member kind: type
Symbol: `Autodesk.Revit.UI.Mechanical.DuctFittingAndAccessoryPressureDropUIDataItem`

#### Summary

Each duct fitting or duct accessory FamilyInstance has one DuctFittingAndAccessoryPressureDropUIDataItem.

#### Remarks

One family instance has one UI data item.
The UI data item contains a corresponding DuctFittingAndAccessoryData which is used for initialing the UI settings and an entity which is used for storing the UI settings.

#### Since

2014

### `M:Autodesk.Revit.UI.DoubleClickOptions.IsSupportedAction(Autodesk.Revit.UI.DoubleClickTarget,Autodesk.Revit.UI.DoubleClickAction)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DoubleClickOptions.IsSupportedAction(Autodesk.Revit.UI.DoubleClickTarget,Autodesk.Revit.UI.DoubleClickAction)`

#### Summary

Checks whether the specified double-click target supports the specified action.

#### Parameter `target`

The double-click target to check.

#### Parameter `action`

The desired double-click action.

#### Returns

True if the target supports the specified action, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.UI.DoubleClickOptions.SetAction(Autodesk.Revit.UI.DoubleClickTarget,Autodesk.Revit.UI.DoubleClickAction)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DoubleClickOptions.SetAction(Autodesk.Revit.UI.DoubleClickTarget,Autodesk.Revit.UI.DoubleClickAction)`

#### Summary

Changes the double-click action associated with a specified target.

#### Remarks

This change will be stored in the user's profile and will affect future sessions of Revit in
addition to the current session.

#### Parameter `target`

The double-click target whose action will be changed.

#### Parameter `action`

The action to assign to the target.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The specified action is not valid for the target element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.UI.DoubleClickOptions.GetAction(Autodesk.Revit.UI.DoubleClickTarget)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DoubleClickOptions.GetAction(Autodesk.Revit.UI.DoubleClickTarget)`

#### Summary

Returns the active user's desired action for a particular double-click target.

#### Parameter `target`

The target to check.

#### Returns

The user's desired action for the specified target.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.UI.DoubleClickOptions.SetRenameOnSlowDoubleClickInProjectBrowser(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DoubleClickOptions.SetRenameOnSlowDoubleClickInProjectBrowser(System.Boolean)`

#### Summary

Sets whether the desired action is to rename item in project browser on slow double-click.

#### Since

2016

### `M:Autodesk.Revit.UI.DoubleClickOptions.GetRenameOnSlowDoubleClickInProjectBrowser`

Member kind: method
Symbol: `Autodesk.Revit.UI.DoubleClickOptions.GetRenameOnSlowDoubleClickInProjectBrowser`

#### Summary

Returns the user's desire to rename item in project browser on slow double-click.

#### Since

2016

### `M:Autodesk.Revit.UI.DoubleClickOptions.GetDoubleClickOptions`

Member kind: method
Symbol: `Autodesk.Revit.UI.DoubleClickOptions.GetDoubleClickOptions`

#### Summary

Returns the current user's DoubleClickOptions.

#### Returns

The DoubleClickOptions for the current user.

#### Since

2016

### `P:Autodesk.Revit.UI.DoubleClickOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.DoubleClickOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.UI.DoubleClickOptions`

Member kind: type
Symbol: `Autodesk.Revit.UI.DoubleClickOptions`

#### Summary

Provides access to settings that control what happens when the current user double-clicks on an element.

#### Remarks

These settings are stored on a per-user basis. Revit will follow these settings for all projects and families for this user.

#### Since

2016

### `T:Autodesk.Revit.UI.DoubleClickAction`

Member kind: type
Symbol: `Autodesk.Revit.UI.DoubleClickAction`

#### Since

2016

#### Summary

Possible actions Revit can take in response to the user double-clicking on an element.

#### Since

2016

### `F:Autodesk.Revit.UI.DoubleClickAction.DeactivateView`

Member kind: field
Symbol: `Autodesk.Revit.UI.DoubleClickAction.DeactivateView`

#### Summary

Double-click should deactivate the active view.

### `F:Autodesk.Revit.UI.DoubleClickAction.EnterEditMode`

Member kind: field
Symbol: `Autodesk.Revit.UI.DoubleClickAction.EnterEditMode`

#### Summary

Double-click will enter a specific edit mode for the element.

### `F:Autodesk.Revit.UI.DoubleClickAction.ActivateView`

Member kind: field
Symbol: `Autodesk.Revit.UI.DoubleClickAction.ActivateView`

#### Summary

Double-click should activate the view or schedule.

### `F:Autodesk.Revit.UI.DoubleClickAction.EditType`

Member kind: field
Symbol: `Autodesk.Revit.UI.DoubleClickAction.EditType`

#### Summary

Double-click should take the user to the edit type dialog.

### `F:Autodesk.Revit.UI.DoubleClickAction.EditFamily`

Member kind: field
Symbol: `Autodesk.Revit.UI.DoubleClickAction.EditFamily`

#### Summary

Double-click should open the family for editing.

### `F:Autodesk.Revit.UI.DoubleClickAction.NoAction`

Member kind: field
Symbol: `Autodesk.Revit.UI.DoubleClickAction.NoAction`

#### Summary

Double-clicks should be ignored.

### `T:Autodesk.Revit.UI.DoubleClickTarget`

Member kind: type
Symbol: `Autodesk.Revit.UI.DoubleClickTarget`

#### Since

2016

#### Summary

Elements that support double-click in Revit. Note that this is meant to cover cases
where the element itself is a double-click target. Individual controls that are targets
are handled separately.

#### Since

2016

### `F:Autodesk.Revit.UI.DoubleClickTarget.OutsideViewOnSheet`

Member kind: field
Symbol: `Autodesk.Revit.UI.DoubleClickTarget.OutsideViewOnSheet`

#### Summary

Outside active view on sheet

### `F:Autodesk.Revit.UI.DoubleClickTarget.ComponentStairs`

Member kind: field
Symbol: `Autodesk.Revit.UI.DoubleClickTarget.ComponentStairs`

#### Summary

Component-based stairs

### `F:Autodesk.Revit.UI.DoubleClickTarget.Group`

Member kind: field
Symbol: `Autodesk.Revit.UI.DoubleClickTarget.Group`

#### Summary

Groups

### `F:Autodesk.Revit.UI.DoubleClickTarget.Assembly`

Member kind: field
Symbol: `Autodesk.Revit.UI.DoubleClickTarget.Assembly`

#### Summary

Assemblies

### `F:Autodesk.Revit.UI.DoubleClickTarget.ViewOnSheet`

Member kind: field
Symbol: `Autodesk.Revit.UI.DoubleClickTarget.ViewOnSheet`

#### Summary

Views on sheets

### `F:Autodesk.Revit.UI.DoubleClickTarget.SketchedElement`

Member kind: field
Symbol: `Autodesk.Revit.UI.DoubleClickTarget.SketchedElement`

#### Summary

Sketch-based elements

### `F:Autodesk.Revit.UI.DoubleClickTarget.Family`

Member kind: field
Symbol: `Autodesk.Revit.UI.DoubleClickTarget.Family`

#### Summary

Family instances

### `P:Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.ViewBrowser`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.ViewBrowser`

#### Summary

The View browser pane.

### `P:Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.SystemNavigator`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.SystemNavigator`

#### Summary

The system browser pane.

### `P:Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.RebarBrowser`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.RebarBrowser`

#### Summary

The rebar browser pane.

### `P:Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.PropertiesPalette`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.PropertiesPalette`

#### Summary

The properties palette pane.

### `P:Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.ProjectBrowser`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.ProjectBrowser`

#### Summary

The project browser pane.

### `P:Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.PnIdModelerBrowser`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.PnIdModelerBrowser`

#### Summary

The P&ID modeler browser pane.

### `P:Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.HostByLinkNavigator`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.HostByLinkNavigator`

#### Summary

The host by link navigator pane.

### `P:Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.FabricationPartBrowser`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.FabricationPartBrowser`

#### Summary

The Fabrication part browser pane.

### `P:Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.ElementView`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.ElementView`

#### Summary

The element view pane.

### `P:Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.ContentDelivery`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.ContentDelivery`

#### Summary

The content delivery pane.

### `T:Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes`

Member kind: type
Symbol: `Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes`

#### Summary

A collection of ids of the dockable panes provided by Revit.

#### Since

2014

### `T:Autodesk.Revit.UI.DockablePanes`

Member kind: type
Symbol: `Autodesk.Revit.UI.DockablePanes`

#### Summary

Provides a container of all Revit built-in DockablePaneId instances.

### `M:Autodesk.Revit.UI.DocTranslateUIUtil.RegenAll(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DocTranslateUIUtil.RegenAll(Autodesk.Revit.DB.Document,System.String)`

#### Summary

RegenAll a family doocumment and saveas in the give folder

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.UI.DocTranslateUIUtil.UpgradeFamilies(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DocTranslateUIUtil.UpgradeFamilies(System.String)`

#### Summary

Upgrade all family documents in the give folder.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.UI.DocTranslateUIUtil`

Member kind: type
Symbol: `Autodesk.Revit.UI.DocTranslateUIUtil`

#### Summary

This utility is used to translate content files

#### Since

2017

### `M:Autodesk.Revit.UI.DocTestHandlersUtil.FamRetrival(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DocTestHandlersUtil.FamRetrival(System.String)`

#### Summary

famRetrival all family documents in the give folder. default metric always

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.UI.DocTestHandlersUtil.LoadSave(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DocTestHandlersUtil.LoadSave(System.String)`

#### Summary

loadSave all family documents in the give folder. default metric always

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.UI.DocTestHandlersUtil`

Member kind: type
Symbol: `Autodesk.Revit.UI.DocTestHandlersUtil`

#### Summary

This utility is used to translate content files

#### Since

2017

### `M:Autodesk.Revit.UI.ColorSelectionDialog.Show`

Member kind: method
Symbol: `Autodesk.Revit.UI.ColorSelectionDialog.Show`

#### Summary

Shows the Revit Color dialog as a modal dialog.

#### Returns

A status indicating whether the user selected a color or cancelled the dialog without making a selection.

#### Since

2017

### `P:Autodesk.Revit.UI.ColorSelectionDialog.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.ColorSelectionDialog.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.ColorSelectionDialog.OriginalColor`

Member kind: property
Symbol: `Autodesk.Revit.UI.ColorSelectionDialog.OriginalColor`

#### Summary

The original color.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.UI.ColorSelectionDialog.SelectedColor`

Member kind: property
Symbol: `Autodesk.Revit.UI.ColorSelectionDialog.SelectedColor`

#### Summary

The new color selected by the user.

#### Since

2017

### `M:Autodesk.Revit.UI.ColorSelectionDialog.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.UI.ColorSelectionDialog.#ctor`

#### Summary

Default constructor.

#### Since

2017

### `T:Autodesk.Revit.UI.ColorSelectionDialog`

Member kind: type
Symbol: `Autodesk.Revit.UI.ColorSelectionDialog`

#### Summary

Allows display of the Revit Color dialog.

#### Remarks

The class provides the option to launch the Revit Color dialog to select the color.

#### Since

2017

### `P:Autodesk.Revit.UI.UIThemeManager.CurrentCanvasTheme`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIThemeManager.CurrentCanvasTheme`

#### Summary

current canvas theme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.UI.UIThemeManager.FollowSystemColorTheme`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIThemeManager.FollowSystemColorTheme`

#### Summary

Indicate if the overall theme follows operating system color theme.

#### Since

2024

### `P:Autodesk.Revit.UI.UIThemeManager.CurrentTheme`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIThemeManager.CurrentTheme`

#### Summary

The current overall theme which impacts the Revit frame and canvas.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.UI.UIThemeManager.DefaultTheme`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIThemeManager.DefaultTheme`

#### Summary

The default theme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.UI.UIThemeManager.GetCurrentFrameBackgroundColor`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIThemeManager.GetCurrentFrameBackgroundColor`

#### Summary

Return the frame background color from the given theme.

#### Since

2014

### `M:Autodesk.Revit.UI.UIThemeManager.GetThemeName(Autodesk.Revit.UI.UITheme)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIThemeManager.GetThemeName(Autodesk.Revit.UI.UITheme)`

#### Summary

Gets the theme name for the given theme type.

#### Parameter `frameTheme`

The theme.

#### Returns

The name of the theme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `T:Autodesk.Revit.UI.UIThemeManager`

Member kind: type
Symbol: `Autodesk.Revit.UI.UIThemeManager`

#### Summary

Manager object for the UITheme class.

#### Since

2014

### `T:Autodesk.Revit.UI.UITheme`

Member kind: type
Symbol: `Autodesk.Revit.UI.UITheme`

#### Summary

The application frame theme.

#### Since

2014

### `F:Autodesk.Revit.UI.UITheme.Light`

Member kind: field
Symbol: `Autodesk.Revit.UI.UITheme.Light`

#### Summary

Light.

### `F:Autodesk.Revit.UI.UITheme.Dark`

Member kind: field
Symbol: `Autodesk.Revit.UI.UITheme.Dark`

#### Summary

Dark.

### `P:Autodesk.Revit.UI.AddLinkDialog.Positioning`

Member kind: property
Symbol: `Autodesk.Revit.UI.AddLinkDialog.Positioning`

#### Since

2024

### `M:Autodesk.Revit.UI.AddLinkDialog.#ctor(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.AddLinkDialog.#ctor(System.String,System.String)`

#### Summary

Constructs a new instance of a File Open dialog.

#### Parameter `filter`

The filter string. See the remarks for `P:Autodesk.Revit.UI.FileDialog.Filter` for details.

#### Parameter `initialFolder`

Initial path to browse to when showing the dialog.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input filter string does not meet the minimal requirements for a valid filter string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `T:Autodesk.Revit.UI.AddLinkDialog`

Member kind: type
Symbol: `Autodesk.Revit.UI.AddLinkDialog`

#### Summary

This class allows an add-in to prompt the user with the Revit dialog used to navigate to and select an existing
file path, with additional options for linking the selected file in the Revit model (for now the postioning).

#### Remarks

The behavior and appearance of this dialog matches the Revit "FileOpen" dialog. This is a general-purpose dialog
for opening a given file type, with the purpose of adding a link of that file to the Revit model.

In addition to the selected file path, this dialog can provide the user with the selected desired positioning
of the link in the Revit model.

Since the positioning options can differ between link types, the corresponding field is an int to increase
reusability.

#### Since

2024

### `M:Autodesk.Revit.UI.FileDialog.IsValidFilterString(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.FileDialog.IsValidFilterString(System.String)`

#### Summary

Determines if the input string is acceptable as input for a FileDialog filter string.

#### Parameter `filterString`

The filter string.

#### Returns

True of the filter string meets the minimal requirements to be a valid filter string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.UI.FileDialog.Show`

Member kind: method
Symbol: `Autodesk.Revit.UI.FileDialog.Show`

#### Summary

Shows the dialog using the stored settings.

#### Returns

A status indicating whether the user selected a file name or cancelled the dialog without making a selection.

#### Since

2017

### `M:Autodesk.Revit.UI.FileDialog.GetSelectedModelPath`

Member kind: method
Symbol: `Autodesk.Revit.UI.FileDialog.GetSelectedModelPath`

#### Summary

Returns the selected file path chosen by the user.

#### Returns

The selected file path, or `null` if the dialog has not been shown or selection was cancelled.

#### Since

2017

### `P:Autodesk.Revit.UI.FileDialog.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.FileDialog.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.FileDialog.HelpTopic`

Member kind: property
Symbol: `Autodesk.Revit.UI.FileDialog.HelpTopic`

#### Summary

A string representation of the help topic.

#### Since

2017

### `P:Autodesk.Revit.UI.FileDialog.DefaultFilterEntry`

Member kind: property
Symbol: `Autodesk.Revit.UI.FileDialog.DefaultFilterEntry`

#### Summary

The default entry (from the filter) to be selected in the dialog.

#### Value

This string value should be found in the string that makes up the right hand side of the filter entry.
If a match is found, that entry from the filter will be shown by default when the dialog is shown.
If this value is not set, or it cannot match any of the entries in the filter,
it will be ignored, and the first entry in the filter will be used instead.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: defaultFilterEntry cannot include prohibited unprintable characters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.UI.FileDialog.Title`

Member kind: property
Symbol: `Autodesk.Revit.UI.FileDialog.Title`

#### Summary

The title to show on the dialog.

#### Value

If not set, a default title will be used for the dialog. For open, this will be something similar to
"Select File" and for save, "Save As".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: title cannot include prohibited unprintable characters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.UI.FileDialog.Filter`

Member kind: property
Symbol: `Autodesk.Revit.UI.FileDialog.Filter`

#### Summary

The filter string representing a collection of extensions allowed by the dialog.

#### Value

The required format for this string is a collection of one or more filter labels (representing the text
the user will see in the Files of Type pulldown) plus an associated file matching string separated by the
'|' character.
Some examples of valid filter strings:
"Revit Files (*.rvt)|*.rvt

"Revit Projects (*.rvt)|*.rvt|Revit Families (*.rfa)|*.rfa"

"All files|*.*"

"All Revit files (*.rvt, *.rfa, *.rte, *.rft)|*.rvt;*.rfa;*.rte;*.rft"

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input filter string does not meet the minimal requirements for a valid filter string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.UI.FileDialog`

Member kind: type
Symbol: `Autodesk.Revit.UI.FileDialog`

#### Summary

Base class supporting display of the dialog used to navigate to and select a file from Autodesk Revit.

#### Since

2017

### `T:Autodesk.Revit.UI.ItemSelectionDialogResult`

Member kind: type
Symbol: `Autodesk.Revit.UI.ItemSelectionDialogResult`

#### Since

2017

#### Summary

An enumerated type listing the possible responses from a prompted dialog where the
user is asked to select one or more items.

#### Since

2017

### `F:Autodesk.Revit.UI.ItemSelectionDialogResult.Canceled`

Member kind: field
Symbol: `Autodesk.Revit.UI.ItemSelectionDialogResult.Canceled`

#### Summary

The user canceled the prompted dialog. No selected item(s) are available from
the dialog interfaces.

### `F:Autodesk.Revit.UI.ItemSelectionDialogResult.Confirmed`

Member kind: field
Symbol: `Autodesk.Revit.UI.ItemSelectionDialogResult.Confirmed`

#### Summary

The user selected one or more item(s) from the prompted dialog and
confirmed the selection. The selected item(s) are available
from the dialog interfaces.

### `P:Autodesk.Revit.UI.Macros.DocumentEntryPoint.AddinFolder`

Member kind: property
Symbol: `Autodesk.Revit.UI.Macros.DocumentEntryPoint.AddinFolder`

#### Summary

The full path to the Revit Macros module.

#### Remarks

This path should be used instead of the .NET GetExecutingAssembly() result, because
the Macros module is loaded in such a way to make that result unreliable.

### `M:Autodesk.Revit.UI.Macros.DocumentEntryPoint.OnShutdownEO`

Member kind: method
Symbol: `Autodesk.Revit.UI.Macros.DocumentEntryPoint.OnShutdownEO`

#### Summary

For Revit Macros internal use only.

### `M:Autodesk.Revit.UI.Macros.DocumentEntryPoint.FinishInitializationEO`

Member kind: method
Symbol: `Autodesk.Revit.UI.Macros.DocumentEntryPoint.FinishInitializationEO`

#### Summary

For Revit Macros internal use only.

### `M:Autodesk.Revit.UI.Macros.DocumentEntryPoint.Initialize(System.Object,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Macros.DocumentEntryPoint.Initialize(System.Object,System.String)`

#### Summary

For Revit Macros internal use only.

### `T:Autodesk.Revit.UI.Macros.DocumentEntryPoint`

Member kind: type
Symbol: `Autodesk.Revit.UI.Macros.DocumentEntryPoint`

#### Summary

For Revit Macros use only.

### `M:Autodesk.Revit.UI.PreviewControl.viewControl_UnLoaded(System.Object,System.Windows.RoutedEventArgs)`

Member kind: method
Symbol: `Autodesk.Revit.UI.PreviewControl.viewControl_UnLoaded(System.Object,System.Windows.RoutedEventArgs)`

#### Summary

This is the unloaded event handler and raised when the control is removed from within
an element tree of loaded elements (dispose the control explicitly by users).

### `M:Autodesk.Revit.UI.PreviewControl.Dispose`

Member kind: method
Symbol: `Autodesk.Revit.UI.PreviewControl.Dispose`

#### Summary

This method is called if the user explicitly disposes of the
object (by calling the Dispose method in other managed languages,
or the destructor in C++).

### `P:Autodesk.Revit.UI.PreviewControl.ScrollbarVisibility`

Member kind: property
Symbol: `Autodesk.Revit.UI.PreviewControl.ScrollbarVisibility`

#### Summary

The visibility of the preview view scrollbars.

#### Since

2014

### `P:Autodesk.Revit.UI.PreviewControl.UIView`

Member kind: property
Symbol: `Autodesk.Revit.UI.PreviewControl.UIView`

#### Summary

The UI view representing the preview view.

#### Remarks

Use this handle to manipulate the zoom and pan of the view.

#### Since

2014

### `P:Autodesk.Revit.UI.PreviewControl.ViewId`

Member kind: property
Symbol: `Autodesk.Revit.UI.PreviewControl.ViewId`

#### Summary

The view Id.

#### Since

2013

### `M:Autodesk.Revit.UI.PreviewControl.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.PreviewControl.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a preview control.

#### Parameter `document`

The document.

#### Parameter `viewId`

The view id want to browse in this control.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when dbDocument or viewId is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the given document is a linked document or the given viewId is invalid or the view is a schedule
or other non-graphical view such as schedule views or the project browser view.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when there is an active preview control already.

#### Since

2013

### `T:Autodesk.Revit.UI.PreviewControl`

Member kind: type
Symbol: `Autodesk.Revit.UI.PreviewControl`

#### Summary

Presents a preview control to browse the Revit model.

#### Remarks

The dialog or form or window host this preview control must be modal.
The view can be any graphical view but not a non-graphical view. And only one can be active.
The view can be manipulated by embedded view cube and the visibility and graphical settings
set on the view will be evident in the preview control.

#### Since

2013

### `P:Autodesk.Revit.UI.PreviewHwndHost.ScrollbarVisibility`

Member kind: property
Symbol: `Autodesk.Revit.UI.PreviewHwndHost.ScrollbarVisibility`

#### Summary

The visibility of the preview view scrollbars.

### `M:Autodesk.Revit.UI.PreviewHwndHost.destroyHwndWindow`

Member kind: method
Symbol: `Autodesk.Revit.UI.PreviewHwndHost.destroyHwndWindow`

#### Summary

Destroy the window and release the modal scope and update the active view to NULL.

### `M:Autodesk.Revit.UI.PreviewHwndHost.BuildWindowCore(System.Runtime.InteropServices.HandleRef)`

Member kind: method
Symbol: `Autodesk.Revit.UI.PreviewHwndHost.BuildWindowCore(System.Runtime.InteropServices.HandleRef)`

#### Summary

Creates the Hwnd of given db view as the child of hwndParent.

### `M:Autodesk.Revit.UI.PreviewHwndHost.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.PreviewHwndHost.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs the Preview host window to interop with win32 control.

### `T:Autodesk.Revit.UI.PreviewHwndHost`

Member kind: type
Symbol: `Autodesk.Revit.UI.PreviewHwndHost`

#### Summary

Hosts a Win32 window as an element within Windows Presentation Foundation (WPF) content.

### `T:Autodesk.Revit.UI.ScrollbarVisibility`

Member kind: type
Symbol: `Autodesk.Revit.UI.ScrollbarVisibility`

#### Summary

Lists all the visibility types of the scrollbar in the preview view.

#### Since

2014

### `F:Autodesk.Revit.UI.ScrollbarVisibility.Both`

Member kind: field
Symbol: `Autodesk.Revit.UI.ScrollbarVisibility.Both`

#### Summary

The both scrollbars are visible.

### `F:Autodesk.Revit.UI.ScrollbarVisibility.Vertical`

Member kind: field
Symbol: `Autodesk.Revit.UI.ScrollbarVisibility.Vertical`

#### Summary

The vertical scrollbar is visible.

### `F:Autodesk.Revit.UI.ScrollbarVisibility.Horizontal`

Member kind: field
Symbol: `Autodesk.Revit.UI.ScrollbarVisibility.Horizontal`

#### Summary

The horizontal scrollbar is visible.

### `F:Autodesk.Revit.UI.ScrollbarVisibility.None`

Member kind: field
Symbol: `Autodesk.Revit.UI.ScrollbarVisibility.None`

#### Summary

No scrollbars are visible.

### `M:getShortFileName(AString!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `getShortFileName(AString!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:Autodesk.Revit.UI.DockablePaneId.op_Inequality(Autodesk.Revit.UI.DockablePaneId,Autodesk.Revit.UI.DockablePaneId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePaneId.op_Inequality(Autodesk.Revit.UI.DockablePaneId,Autodesk.Revit.UI.DockablePaneId)`

#### Summary

Compares two DockablePaneId instances.

#### Parameter `first`

The first DockablePaneId.

#### Parameter `second`

The second DockablePaneId.

#### Returns

True if the inputs are different, false if they are identical.

### `M:Autodesk.Revit.UI.DockablePaneId.op_Equality(Autodesk.Revit.UI.DockablePaneId,Autodesk.Revit.UI.DockablePaneId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePaneId.op_Equality(Autodesk.Revit.UI.DockablePaneId,Autodesk.Revit.UI.DockablePaneId)`

#### Summary

Compares two DockablePaneId instances.

#### Parameter `first`

The first DockablePaneId.

#### Parameter `second`

The second DockablePaneId.

#### Returns

True if the inputs are identical, false if they are different.

### `M:Autodesk.Revit.UI.DockablePaneId.#ctor(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePaneId.#ctor(System.Guid)`

#### Summary

Creates a new DockablePaneId instance.

#### Parameter `guid`

The identifier for the DockablePaneId.

### `T:Autodesk.Revit.UI.DockablePaneId`

Member kind: type
Symbol: `Autodesk.Revit.UI.DockablePaneId`

#### Summary

Identifier for a pane that participates in the Revit docking window system.

#### Since

2014

### `M:Autodesk.Revit.UI.TaskDialog.EnableDoNotShowAgain(System.String,System.Boolean,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.TaskDialog.EnableDoNotShowAgain(System.String,System.Boolean,System.String)`

#### Summary

Enables the "Do not show again" for a task dialog.

#### Parameter `dialogId`

The non localized dialog identifier. It is used to store in Revit.ini the choice the user made the last time the dialog was shown.

#### Parameter `enableDoNotShow`

The boolean to enable or disable the do not show me again functionality.

#### Parameter `doNotShowText`

The customized localized string that shows along with the do not show again checkbox.

#### Remarks

Thrown if the TaskDialog also has VerificationText set as the two cannot coincide in the same TaskDialog.

When enabled, the TaskDialog will contain a checkbox with the text specified to not show the task dialog again.

By default a task dialog will not have this check box.

If the user checks the check box, the next call to Show() for the indicated dialog id returns the choice the user made the last time the dialog was shown.

#### Since

2020

### `M:Autodesk.Revit.UI.TaskDialog.WasExtraCheckBoxChecked`

Member kind: method
Symbol: `Autodesk.Revit.UI.TaskDialog.WasExtraCheckBoxChecked`

#### Summary

Gets the status of the extra checkbox.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the task dialog does not have an extra checkbox or the task dialog is not shown yet.

#### Returns

Whether the extra checkbox is checked.

#### Since

2017

### `M:Autodesk.Revit.UI.TaskDialog.Show(System.String,System.String,Autodesk.Revit.UI.TaskDialogCommonButtons,Autodesk.Revit.UI.TaskDialogResult)`

Member kind: method
Symbol: `Autodesk.Revit.UI.TaskDialog.Show(System.String,System.String,Autodesk.Revit.UI.TaskDialogCommonButtons,Autodesk.Revit.UI.TaskDialogResult)`

#### Summary

Shows a task dialog with title, main instruction, common buttons and default buttons.

#### Parameter `title`

The title of the task dialog.

#### Parameter `mainInstruction`

The main instruction of the task dialog.

#### Parameter `buttons`

The common buttons to be shown the task dialog.

#### Parameter `defaultButton`

The default button of the task dialog.

#### Returns

The user's response to the task dialog.

#### Since

2011

### `M:Autodesk.Revit.UI.TaskDialog.Show(System.String,System.String,Autodesk.Revit.UI.TaskDialogCommonButtons)`

Member kind: method
Symbol: `Autodesk.Revit.UI.TaskDialog.Show(System.String,System.String,Autodesk.Revit.UI.TaskDialogCommonButtons)`

#### Summary

Shows a task dialog with title, main instruction and common buttons.

#### Parameter `title`

The title of the task dialog.

#### Parameter `mainInstruction`

The main instruction of the task dialog.

#### Parameter `buttons`

The common buttons to be shown the task dialog.

#### Returns

The user's response to the task dialog.

#### Since

2011

### `M:Autodesk.Revit.UI.TaskDialog.Show(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.TaskDialog.Show(System.String,System.String)`

#### Overloads

Shows a task dialog.

#### Summary

Shows a task dialog with title, main instruction and a Close button.

#### Parameter `title`

The title of the task dialog.

#### Parameter `mainInstruction`

The main instruction of the task dialog.

#### Returns

The user's response to the task dialog.

#### Since

2011

### `M:Autodesk.Revit.UI.TaskDialog.WasVerificationChecked`

Member kind: method
Symbol: `Autodesk.Revit.UI.TaskDialog.WasVerificationChecked`

#### Summary

Gets the status of the verification checkbox.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the task dialog does not have verification checkbox or the task dialog is not shown yet.

#### Returns

Whether the verification checkbox is checked.

#### Since

2011

### `M:Autodesk.Revit.UI.TaskDialog.Show`

Member kind: method
Symbol: `Autodesk.Revit.UI.TaskDialog.Show`

#### Summary

Shows the task dialog.

#### Returns

The user's response to the task dialog.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when
the task dialog is shown out of main thread of Revit or when an extra checkbox and a verification checkbox are enabled at the same time.

#### Since

2011

### `M:Autodesk.Revit.UI.TaskDialog.AddCommandLink(Autodesk.Revit.UI.TaskDialogCommandLinkId,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.TaskDialog.AddCommandLink(Autodesk.Revit.UI.TaskDialogCommandLinkId,System.String)`

#### Summary

Adds a CommandLink associated to the given id, displaying the indicating main content.

#### Parameter `id`

The id of the CommandLink. This corresponds to the value returned by Show() when the link is chosen by the user.

#### Parameter `mainContent`

The main content of the CommandLink.

#### Remarks

Parameter mainContent cannot contain newlines.

If the id has already been set to the task dialog, the new CommandLink definition overrides the old one.

CommandLinks will always be shown in the dialog in the order of their ids.

#### Since

2011

### `M:Autodesk.Revit.UI.TaskDialog.AddCommandLink(Autodesk.Revit.UI.TaskDialogCommandLinkId,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.TaskDialog.AddCommandLink(Autodesk.Revit.UI.TaskDialogCommandLinkId,System.String,System.String)`

#### Overloads

Adds a CommandLink to the TaskDialog.

#### Summary

Adds a CommandLink associated to the given id, displaying the indicating main and supporting content.

#### Parameter `id`

The id of the CommandLink. This corresponds to the value returned by Show() when the link is chosen by the user.

#### Parameter `mainContent`

The main content of the CommandLink.

#### Parameter `supportingContent`

The main content of the CommandLink.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when mainContent is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when mainContent is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the mainContent contains newline characters.

#### Remarks

Parameter mainContent cannot contain newlines.

If the id has already been set to the task dialog, the new CommandLink definition overrides the old one.

CommandLinks will always be shown in the dialog in the order of their ids.

#### Since

2011

### `P:Autodesk.Revit.UI.TaskDialog.EnableMarqueeProgressBar`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.EnableMarqueeProgressBar`

#### Summary

Enables a marquee style progress bar to be displayed in the TaskDialog.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the TaskDialog also has ExtraCheckBoxText set as the two cannot coincide in the same TaskDialog.

#### Remarks

When true, the TaskDialog will display a progress bar that has an indeterminate start and stop.

A progress bar is a window that an application can use to indicate the progress of a lengthy operation.

It consists of a rectangle that is animated as an operation progresses. The animation continues until the TaskDialog is closed.

The default value is false.

#### Since

2020

### `P:Autodesk.Revit.UI.TaskDialog.TitleAutoPrefix`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.TitleAutoPrefix`

#### Summary

Whether the TaskDialog's title will automatically have the add-in name added as a prefix.

#### Remarks

The default value is true.

#### Since

2011

### `P:Autodesk.Revit.UI.TaskDialog.CommonButtons`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.CommonButtons`

#### Summary

The push buttons displayed in the task dialog.

#### Remarks

If no common button or CommandLink is added to the task dialog, the dialog will contain the Close common button by default.

Revit task dialogs are following these conventions for commit button usage:
Use a single Close button instead of a single OK button on informational messages.

Use a question at the end of the Main Instruction with a Yes/No combo (or Yes/No/Cancel) instead of OK/Cancel. This should work 99% of the time. For example: "Are you sure you want to overwrite the file?" and use Yes/No buttons.

Do not customize the button names unless there is a very good reason to do so. For example, "Are you sure you want to save the file?" would use Yes/No buttons and not Save/No or Save/Cancel.

#### Since

2011

### `P:Autodesk.Revit.UI.TaskDialog.MainIcon`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.MainIcon`

#### Summary

The icon shown in the task dialog.

#### Remarks

There is no icon by default.

Task dialogs in Revit rarely use icons, to reduce the visual clutter shown to the user. Only one icon can be used
in the task dialog, the Warning (!) icon, and it should be used only when there is a risk of data loss or
significant time lost. If there is no data loss or time lost as a possible result of the message, do not use the icon.

#### Since

2011

### `P:Autodesk.Revit.UI.TaskDialog.DefaultButton`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.DefaultButton`

#### Summary

The default button for the dialog.

#### Remarks

If DefaultButton is TaskDialogResult.None or its value does not correspond to any CommonButton or CommandLink in the dialog,
then the first button in the dialog will be the default.

#### Since

2011

### `P:Autodesk.Revit.UI.TaskDialog.AllowCancellation`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.AllowCancellation`

#### Summary

Whether the task dialog can be cancelled if no cancel button is specified.

#### Remarks

The default value is true. If there is a cancel button in the task dialog, the it always can be cancelled.

#### Since

2011

### `P:Autodesk.Revit.UI.TaskDialog.FooterText`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.FooterText`

#### Summary

FooterText is used in the footer area of the task dialog.

#### Remarks

HTML Hyperlink tags can be used when specifying Footertext. These will work like normal hyperlinks
where clicking them will launch the default browser to the location specified.
Revit special cases hyperlinks containing the single character '#' to indicate to launch Revit's
contextual help for the dialog. The Topic passed for the contextul help takes the form H[id] where
id is the Id for the task dialog.

#### Since

2011

### `P:Autodesk.Revit.UI.TaskDialog.ExtraCheckBoxText`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.ExtraCheckBoxText`

#### Summary

ExtraCheckBoxText is used to label the extra checkbox.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the TaskDialog also has EnableMarqueeProgressBar set as the two cannot coincide in the same TaskDialog.

#### Remarks

If ExtraCheckBoxText is set, a checkbox with the text will be shown. You can get the response of checkbox by checking the return value of the WasExtraCheckBoxChecked() method.

#### Since

2017

### `P:Autodesk.Revit.UI.TaskDialog.VerificationText`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.VerificationText`

#### Summary

VerificationText is used to label the verification checkbox.

#### Remarks

Thrown if the TaskDialog has already enabled the Do not show message as the two cannot coincide in the same TaskDialog.
If VerificationText is set, a checkbox with the text will be shown. You can get the response of checkbox by checking the return value of the WasVerificationChecked() method.

#### Since

2011

### `P:Autodesk.Revit.UI.TaskDialog.ExpandedContent`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.ExpandedContent`

#### Summary

ExpandedContent is hidden by default and will display at the bottom of the task dialog when the "Show details" button is pressed.

#### Remarks

If added to a dialog, a Show/Hide toggle button displays at the bottom of the task dialog. The Expanded Content is hidden by default.
This area is used when even more information needs to be relayed to the user than space allows. It is rarely used, but can be used for showing technical
information passed through in a variable, for example back-end error information, lists of files, etc.
Variable information should always be introduced with a lead-in sentence.

#### Since

2011

### `P:Autodesk.Revit.UI.TaskDialog.MainContent`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.MainContent`

#### Summary

MainContent is the smaller text that appears just below the main instructions.

#### Remarks

The Main Content is optional. It should be used to give further explanation to the user, such as how to correct the problem or work around the situation.
It displays in a smaller black font below the main instructions. Follow these guidelines:
Text should be clear and jargon free.

Main content should not simply restate the main instructions in a different way, they should contain additional information
that builds upon or reinforces the main instructions.

Main content should be written in sentence format (normal capitalization and punctuation).

Address the user directly as "you" when needed.

#### Since

2011

### `P:Autodesk.Revit.UI.TaskDialog.Id`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.Id`

#### Summary

The Id of the task dialog.

#### Remarks

Id is used as follows:
TaskDialogShowingEventArgs.DialogId for DialogBoxShowing eventsAs part of the Contextual Help Topic when invoking Revit contextual help

#### Since

2011

### `P:Autodesk.Revit.UI.TaskDialog.MainInstruction`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.MainInstruction`

#### Summary

The large primary text that appears at the top of a task dialog.

#### Remarks

It should concisely sum up the problem or situation that is causing the message to display. Follow these guidelines:
Every task dialog includes a main instruction.

Text should not exceed three lines.

Text should use plain language and be jargon free.

Main instructions should be written in sentence format – normal capitalization and punctuation.

Address the user directly as "you" when appropriate.

When presented with multiple command link options the standard final line for the main instructions should be,
"What do you want to do?"

Revit will automatically break lines to make the message fit well. "\n" also breaks down to the next line. For a paragraph break, use "\n\n".

Hyperlinks added to the main instructions will not be enabled when the dialog is shown on Vista.

#### Since

2011

### `P:Autodesk.Revit.UI.TaskDialog.Title`

Member kind: property
Symbol: `Autodesk.Revit.UI.TaskDialog.Title`

#### Summary

Title of the task dialog.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when setting the value to `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when setting the value to an empty string or string contains newline characters.

#### Remarks

Titles of task dialogs should be unique. Do not reuse the same title for multiple task dialogs.

Newline characters are not allowed in Title.

When the dialogs is shown, Revit will put "External Command Name –" or "External Application –" in the front of the value by default. Examples:
Plug-in Name – No Rooms to Calculate

Plug-in Name – Invalid Value for Length
You can suppress it by setting TitleAutoPrefix to false.

Titles should describe the nature of the problem or state the situation that currently exists.
The title tells the user why they are getting the message, not what they are supposed to do.

#### Since

2011

### `M:Autodesk.Revit.UI.TaskDialog.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.TaskDialog.#ctor(System.String)`

#### Summary

Creates a task dialog with title.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when title is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when title is an empty string.

#### Since

2011

### `T:Autodesk.Revit.UI.TaskDialog`

Member kind: type
Symbol: `Autodesk.Revit.UI.TaskDialog`

#### Summary

A task dialog is a dialog box that can be used to display information and receive simple input from the user. It has a common set of controls
that are arranged in a standard order to assure consistent look and feel.

#### Remarks

There are two ways to create and show a task dialog to the user. The first option is to construct the TaskDialog, set its properties individually, and use
the instance method Show() to show it to the user. The second is to use one of the static Show() methods to construct and show the dialog in one step.
When you use the static methods only a subset of the options can be specified.

Please follow Revit standards to create task dialogs. The standards are listed in the remarks of each property or method.

#### Since

2011

### `T:Autodesk.Revit.UI.TaskDialogIcon`

Member kind: type
Symbol: `Autodesk.Revit.UI.TaskDialogIcon`

#### Summary

Standard icons to be used in the task dialog.

#### Since

2011

### `F:Autodesk.Revit.UI.TaskDialogIcon.TaskDialogIconShield`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogIcon.TaskDialogIconShield`

#### Summary

Shield icon.

#### Since

2018

### `F:Autodesk.Revit.UI.TaskDialogIcon.TaskDialogIconInformation`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogIcon.TaskDialogIconInformation`

#### Summary

Information icon.

#### Since

2018

### `F:Autodesk.Revit.UI.TaskDialogIcon.TaskDialogIconError`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogIcon.TaskDialogIconError`

#### Summary

Error icon.

#### Since

2018

### `F:Autodesk.Revit.UI.TaskDialogIcon.TaskDialogIconWarning`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogIcon.TaskDialogIconWarning`

#### Summary

Warning icon.

### `F:Autodesk.Revit.UI.TaskDialogIcon.TaskDialogIconNone`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogIcon.TaskDialogIconNone`

#### Summary

No icon.

### `T:Autodesk.Revit.UI.TaskDialogResult`

Member kind: type
Symbol: `Autodesk.Revit.UI.TaskDialogResult`

#### Summary

Enum to specify the task dialog result.

#### Since

2011

### `F:Autodesk.Revit.UI.TaskDialogResult.CommandLink4`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogResult.CommandLink4`

#### Summary

The return value for CommandLink whose Id is TaskDialogCommmandLinkId.CommandLink4.

### `F:Autodesk.Revit.UI.TaskDialogResult.CommandLink3`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogResult.CommandLink3`

#### Summary

The return value for CommandLink whose Id is TaskDialogCommmandLinkId.CommandLink3.

### `F:Autodesk.Revit.UI.TaskDialogResult.CommandLink2`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogResult.CommandLink2`

#### Summary

The return value for CommandLink whose Id is TaskDialogCommmandLinkId.CommandLink2.

### `F:Autodesk.Revit.UI.TaskDialogResult.CommandLink1`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogResult.CommandLink1`

#### Summary

The return value for CommandLink whose Id is TaskDialogCommmandLinkId.CommandLink1.

### `F:Autodesk.Revit.UI.TaskDialogResult.Close`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogResult.Close`

#### Summary

The return value for TaskDialogCommonButtons.Close.

### `F:Autodesk.Revit.UI.TaskDialogResult.No`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogResult.No`

#### Summary

The return value for TaskDialogCommonButtons.No.

### `F:Autodesk.Revit.UI.TaskDialogResult.Yes`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogResult.Yes`

#### Summary

The return value for TaskDialogCommonButtons.Yes.

### `F:Autodesk.Revit.UI.TaskDialogResult.Retry`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogResult.Retry`

#### Summary

The return value for TaskDialogCommonButtons.Retry.

### `F:Autodesk.Revit.UI.TaskDialogResult.Cancel`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogResult.Cancel`

#### Summary

The return value for TaskDialogCommonButtons.Cancel or the task dialog is cancelled by ESC, Alt+F4 or the X close button.

### `F:Autodesk.Revit.UI.TaskDialogResult.Ok`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogResult.Ok`

#### Summary

The return value for TaskDialogCommonButtons.Ok.

### `F:Autodesk.Revit.UI.TaskDialogResult.None`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogResult.None`

#### Summary

Nothing is returned from the task dialog.

### `T:Autodesk.Revit.UI.TaskDialogCommandLinkId`

Member kind: type
Symbol: `Autodesk.Revit.UI.TaskDialogCommandLinkId`

#### Summary

Enum to specify the Id of CommandLink.

#### Since

2011

### `F:Autodesk.Revit.UI.TaskDialogCommandLinkId.CommandLink4`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogCommandLinkId.CommandLink4`

#### Summary

CommandLink4.

### `F:Autodesk.Revit.UI.TaskDialogCommandLinkId.CommandLink3`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogCommandLinkId.CommandLink3`

#### Summary

CommandLink3.

### `F:Autodesk.Revit.UI.TaskDialogCommandLinkId.CommandLink2`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogCommandLinkId.CommandLink2`

#### Summary

CommandLink2.

### `F:Autodesk.Revit.UI.TaskDialogCommandLinkId.CommandLink1`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogCommandLinkId.CommandLink1`

#### Summary

CommandLink1.

### `T:Autodesk.Revit.UI.TaskDialogCommonButtons`

Member kind: type
Symbol: `Autodesk.Revit.UI.TaskDialogCommonButtons`

#### Summary

A enumerated type containing the standard buttons available for Task Dialogs.

#### Since

2011

### `F:Autodesk.Revit.UI.TaskDialogCommonButtons.Close`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogCommonButtons.Close`

#### Summary

Close button.

### `F:Autodesk.Revit.UI.TaskDialogCommonButtons.Retry`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogCommonButtons.Retry`

#### Summary

Retry button.

### `F:Autodesk.Revit.UI.TaskDialogCommonButtons.Cancel`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogCommonButtons.Cancel`

#### Summary

Cancel button.

### `F:Autodesk.Revit.UI.TaskDialogCommonButtons.No`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogCommonButtons.No`

#### Summary

No button.

### `F:Autodesk.Revit.UI.TaskDialogCommonButtons.Yes`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogCommonButtons.Yes`

#### Summary

Yes button.

### `F:Autodesk.Revit.UI.TaskDialogCommonButtons.Ok`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogCommonButtons.Ok`

#### Summary

OK button.

### `F:Autodesk.Revit.UI.TaskDialogCommonButtons.None`

Member kind: field
Symbol: `Autodesk.Revit.UI.TaskDialogCommonButtons.None`

#### Summary

No common button.

### `P:Autodesk.Revit.UI.Events.MessageBoxData.DialogType`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.MessageBoxData.DialogType`

#### Summary

An integer that describes the standard windows type of the dialog box.

### `P:Autodesk.Revit.UI.Events.MessageBoxData.Message`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.MessageBoxData.Message`

#### Summary

The message that has been displayed in the dialog box.

### `T:Autodesk.Revit.UI.Events.MessageBoxData`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.MessageBoxData`

#### Summary

An object that represents a simple message box that prompts the user
for some action.

#### Remarks

When the application receives this object, a simple message box is displayed in Revit that
requires user interaction. The OverrideResult function can be used to cause the dialog
to be dismissed and return a desired result code.

### `M:Autodesk.Revit.UI.Events.DialogBoxData.OverrideResult(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.DialogBoxData.OverrideResult(System.Int32)`

#### Summary

Call this method to cause the Autodesk Revit dialog to be dismissed with the specified return value.

#### Parameter `result`

The result code you wish the Revit dialog to return.

#### Returns

Returns true if the result code was accepted.
