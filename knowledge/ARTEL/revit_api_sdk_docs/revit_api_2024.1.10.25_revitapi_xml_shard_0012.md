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
Shard: 12
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.Viewport.HasViewportTransforms`

Member kind: method
Symbol: `Autodesk.Revit.DB.Viewport.HasViewportTransforms`

#### Summary

Indicates if the viewport has transforms.

#### Remarks

Not all viewports have transforms. For example,
viewports for schedules and legends do not have transforms.

#### Returns

True if the viewport has transforms, false otherwise.

#### Since

2023

### `M:Autodesk.Revit.DB.Viewport.GetLabelOutline`

Member kind: method
Symbol: `Autodesk.Revit.DB.Viewport.GetLabelOutline`

#### Summary

Gets the outline viewport's label on the sheet.

#### Returns

The outline of the viewport's label on the sheet.
The outline may be empty if there is no label.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The viewport is not on a sheet.

#### Since

2013

### `M:Autodesk.Revit.DB.Viewport.SetBoxCenter(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Viewport.SetBoxCenter(Autodesk.Revit.DB.XYZ)`

#### Summary

Moves this viewport so that the center of the box outline (excluding the viewport label) is at a given point.

#### Parameter `newCenterPoint`

The desired center for the box outline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The viewport is not on a sheet.

#### Since

2014

### `M:Autodesk.Revit.DB.Viewport.GetBoxCenter`

Member kind: method
Symbol: `Autodesk.Revit.DB.Viewport.GetBoxCenter`

#### Summary

Returns the center of the outline of the viewport on the sheet, excluding the viewport label.

#### Returns

The center of the outline of the viewport on the sheet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The viewport is not on a sheet.

#### Since

2014

### `M:Autodesk.Revit.DB.Viewport.GetBoxOutline`

Member kind: method
Symbol: `Autodesk.Revit.DB.Viewport.GetBoxOutline`

#### Summary

Returns the outline of the viewport on the sheet, excluding the viewport label.

#### Returns

The outline of the viewport on the sheet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The viewport is not on a sheet.

#### Since

2013

### `M:Autodesk.Revit.DB.Viewport.IsViewIdValidForViewport(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Viewport.IsViewIdValidForViewport(Autodesk.Revit.DB.ElementId)`

#### Summary

Verifies that the Viewport can change it's view id to the input %viewId%.

#### Parameter `viewId`

The view which will be checked to see if it can be applied to Viewport.

#### Returns

True if the %viewId% is valid for the viewport, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Viewport.CanAddViewToSheet(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Viewport.CanAddViewToSheet(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Verifies that the view can be added to the ViewSheet.

#### Remarks

Schedule views are not handled by the Viewport class. Refer to `!:Autodesk::Revit::DB::ScheduleSheetInstance::Create()` for information about adding schedules to sheets.

#### Parameter `document`

The document in which the views reside.

#### Parameter `viewSheetId`

The ViewSheet on which the view will be placed.

#### Parameter `viewId`

The view which will be checked to see if it can be placed on the sheet.

#### Returns

True if the view can be added to the ViewSheet, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Viewport.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Viewport.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new Viewport at a given location on a sheet.

#### Remarks

Use `!:Autodesk::Revit::DB::ScheduleSheetInstance::Create()` to add schedules to sheets.

#### Parameter `document`

The document to which the new Viewport will be added.

#### Parameter `viewSheetId`

The ViewSheet on which the new Viewport will be placed.

#### Parameter `viewId`

The view shown in the Viewport.

#### Parameter `point`

The new Viewport will be centered on this point.

#### Returns

The new Viewport.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

viewSheetId is not a ViewSheet.
-or-
viewId cannot be added to the ViewSheet.
-or-
Plan view creation is not allowed in this family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

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

### `P:Autodesk.Revit.DB.Viewport.LabelOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Viewport.LabelOffset`

#### Summary

The offset is a two-dimensional vector from left bottom corner of the viewport with Rotation set to None to the left end of the viewport label line. The Z coordinate is ignored.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.Viewport.LabelLineLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Viewport.LabelLineLength`

#### Summary

The length of the viewport label line in sheet space, measured in feet.

#### Remarks

It can be negative. The sign depends on the direction of the label line.

#### Since

2022

### `P:Autodesk.Revit.DB.Viewport.Rotation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Viewport.Rotation`

#### Summary

The rotation of the viewport on the sheet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.Viewport.SheetId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Viewport.SheetId`

#### Summary

The element id of the ViewSheet on which the viewport appears,
or InvalidElementId if this viewport does not associate a view
with placement onto a sheet.

#### Since

2013

### `P:Autodesk.Revit.DB.Viewport.ViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Viewport.ViewId`

#### Summary

The element id of the associated View.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Viewport.ViewportPositioning`

Member kind: property
Symbol: `Autodesk.Revit.DB.Viewport.ViewportPositioning`

#### Summary

Specifies the method the viewport will be positioned on the sheet when swapped to another view. Default is set to ViewportPositioning::ViewportCenter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2023

### `T:Autodesk.Revit.DB.Viewport`

Member kind: type
Symbol: `Autodesk.Revit.DB.Viewport`

#### Summary

An element that establishes the placement of a view on a sheet.

#### Remarks

Viewports are used in Revit for purposes other than placement of
views on sheets. Thus iteration of viewport elements in the model may
locate viewports which are not assigned to sheets; you can use the
SheetId property to filter these out.

#### Since

2013

### `T:Autodesk.Revit.DB.ViewportPositioning`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewportPositioning`

#### Since

2023

#### Summary

An enumerated type listing of viewport positioning options on the sheet when swapped to another view.

#### Since

2023

### `F:Autodesk.Revit.DB.ViewportPositioning.ViewOrigin`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewportPositioning.ViewOrigin`

#### Summary

When swapping to another view, the viewport location will be based on the view origin.

### `F:Autodesk.Revit.DB.ViewportPositioning.ViewportCenter`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewportPositioning.ViewportCenter`

#### Summary

When swapping to another view, the center of the viewport will be maintained.

### `M:Autodesk.Revit.DB.ViewDrafting.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewDrafting.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new ViewDrafting in the model.

#### Parameter `document`

The document in which the new drafting view will be created.

#### Parameter `viewFamilyTypeId`

The id of the ViewFamilyType that should be assigned to the new drafting view.

#### Returns

The newly created drafting view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

viewFamilyTypeId is not a valid ViewFamilyType for a drafting view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.ViewDrafting`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewDrafting`

#### Summary

ViewDrafting represents a drafting view within the model.

### `P:Autodesk.Revit.DB.ViewDisplayModel.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayModel.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplayModel.SmoothEdges`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayModel.SmoothEdges`

#### Summary

True to enable "smooth edge" (anti-aliasing) effect. False to disable it.

#### Since

2015

### `P:Autodesk.Revit.DB.ViewDisplayModel.ShowHiddenLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayModel.ShowHiddenLines`

#### Summary

True to enable hidden lines. False to disable showing them.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `P:Autodesk.Revit.DB.ViewDisplayModel.SilhouetteEdgesGStyleId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayModel.SilhouetteEdgesGStyleId`

#### Summary

Style ID for silhouette edges

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.ViewDisplayModel.EnableSilhouettes`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayModel.EnableSilhouettes`

#### Summary

True to show silhouettes edges. False to disable showing them.

#### Since

2015

### `P:Autodesk.Revit.DB.ViewDisplayModel.Transparency`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayModel.Transparency`

#### Summary

The percentage (0..100) of surface transparency
0 means the surfaces are opaque, 100 means they are fully transparent

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value is invalid. The valid range is 0 through 100

#### Since

2015

### `T:Autodesk.Revit.DB.ViewDisplayModel`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewDisplayModel`

#### Summary

Represents the settings for displaying model graphics.
version 2: m_showHiddenLines type changed bool -> ShowHiddenLinesValues::Enum

#### Since

2015

### `T:Autodesk.Revit.DB.ShowHiddenLinesValues`

Member kind: type
Symbol: `Autodesk.Revit.DB.ShowHiddenLinesValues`

#### Summary

Provides options for display of hidden lines in a given view.

### `F:Autodesk.Revit.DB.ShowHiddenLinesValues.All`

Member kind: field
Symbol: `Autodesk.Revit.DB.ShowHiddenLinesValues.All`

#### Summary

Show all hidden lines.

### `F:Autodesk.Revit.DB.ShowHiddenLinesValues.ByDiscipline`

Member kind: field
Symbol: `Autodesk.Revit.DB.ShowHiddenLinesValues.ByDiscipline`

#### Summary

Show hidden lines according to discipline.

### `F:Autodesk.Revit.DB.ShowHiddenLinesValues.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.ShowHiddenLinesValues.None`

#### Summary

Do not show any hidden lines.

### `P:Autodesk.Revit.DB.ViewDisplaySketchyLines.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplaySketchyLines.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplaySketchyLines.Extension`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplaySketchyLines.Extension`

#### Summary

The extension scale value. Controls the magnitude of line's extension.
Values between 0 and 10.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The extension value is not valid. The valid range is 0 to 10.

#### Since

2015

### `P:Autodesk.Revit.DB.ViewDisplaySketchyLines.EnableSketchyLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplaySketchyLines.EnableSketchyLines`

#### Summary

True to enable sketchy lines visibility. False to disable it.

#### Since

2015

### `P:Autodesk.Revit.DB.ViewDisplaySketchyLines.Jitter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplaySketchyLines.Jitter`

#### Summary

The jitter defines jitteriness of the line.
Values between 0 and 10.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The jitter value is not valid. The valid range is 0 to 10.

#### Since

2015

### `T:Autodesk.Revit.DB.ViewDisplaySketchyLines`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewDisplaySketchyLines`

#### Summary

Represents the settings for sketchy lines.

#### Since

2015

### `M:Autodesk.Revit.DB.ViewDisplayDepthCueing.SetStartEndPercentages(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewDisplayDepthCueing.SetStartEndPercentages(System.Int32,System.Int32)`

#### Summary

Sets start and end percentages.

#### Parameter `startPercentage`

The start percentage defines where depth cueing starts.

#### Parameter `endPercentage`

The end percentage defines where depth cueing ends.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The start and end percentages values are not valid. The valid range is 0 to 100 and start is smaller than end.

#### Since

2017

### `P:Autodesk.Revit.DB.ViewDisplayDepthCueing.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayDepthCueing.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplayDepthCueing.FadeTo`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayDepthCueing.FadeTo`

#### Summary

The fade to defines the maximum fading in per cent.
Values between 0 and 100.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The fade to value is not valid. The valid range is 0 to 100.

#### Since

2017

### `P:Autodesk.Revit.DB.ViewDisplayDepthCueing.EndPercentage`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayDepthCueing.EndPercentage`

#### Summary

The end percentage defines where depth cueing ends.
Values between 0 and 100.

#### Since

2017

### `P:Autodesk.Revit.DB.ViewDisplayDepthCueing.StartPercentage`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayDepthCueing.StartPercentage`

#### Summary

The start percentage defines where depth cueing starts.
Values between 0 and 100.

#### Since

2017

### `P:Autodesk.Revit.DB.ViewDisplayDepthCueing.EnableDepthCueing`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayDepthCueing.EnableDepthCueing`

#### Summary

True to enable depth cueing. False to disable it.

#### Since

2017

### `T:Autodesk.Revit.DB.ViewDisplayDepthCueing`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewDisplayDepthCueing`

#### Summary

Represents the settings for depth cueing.

#### Since

2017

### `M:Autodesk.Revit.DB.ViewDisplayBackground.CreateSky`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.CreateSky`

#### Summary

Creates an object that can be passed to `M:Autodesk.Revit.DB.View.SetBackground(Autodesk.Revit.DB.ViewDisplayBackground)` method
to set the background of the SunAndClouds type.

#### Returns

New background object to pass to `M:Autodesk.Revit.DB.View.SetBackground(Autodesk.Revit.DB.ViewDisplayBackground)` .

#### Since

2014

### `M:Autodesk.Revit.DB.ViewDisplayBackground.CreateImage(System.String,Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags,Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.CreateImage(System.String,Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags,Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV)`

#### Summary

Creates an object that can be passed to `M:Autodesk.Revit.DB.View.SetBackground(Autodesk.Revit.DB.ViewDisplayBackground)` method
to set the background of the Image type.

#### Parameter `imagePath`

File path with the image to be used.

#### Parameter `flags`

Combination of flags (binary) that control how image is displayed in relation
to the view/crop boundary.

#### Parameter `imageOffsets`

Horizontal (u) and vertical (v) offsets of the image.

#### Parameter `imageScales`

Horizontal (u) and vertical (v) scales of the image (1 == no change).

#### Returns

New background object to pass to `M:Autodesk.Revit.DB.View.SetBackground(Autodesk.Revit.DB.ViewDisplayBackground)` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The file specified by imagePath is not an image file.
A valid image file should be in one of the following formats: bmp, jpg, jpeg, png, tif.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file specified by imagePath doesn't exist.

#### Since

2014

### `M:Autodesk.Revit.DB.ViewDisplayBackground.CreateGradient(Autodesk.Revit.DB.Color,Autodesk.Revit.DB.Color,Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.CreateGradient(Autodesk.Revit.DB.Color,Autodesk.Revit.DB.Color,Autodesk.Revit.DB.Color)`

#### Summary

Creates an object that can be passed to `M:Autodesk.Revit.DB.View.SetBackground(Autodesk.Revit.DB.ViewDisplayBackground)` method
to set the background of the Gradient type.

#### Parameter `skyColor`

The top of the sky gradient if the sky is visible.

#### Parameter `horizonColor`

The bottom or the sky gradient if the sky is visible,
or the top of the ground gradient otherwise.

#### Parameter `groundColor`

The ground color if the sky is visible (ground shown in uniform color),
or the bottom of the ground gradient if the sky is not visible.

#### Returns

New background object to pass to `M:Autodesk.Revit.DB.View.SetBackground(Autodesk.Revit.DB.ViewDisplayBackground)` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplayBackground.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplayBackground.VerticalImageScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.VerticalImageScale`

#### Summary

The vertical scale of the background image; the scale of 1.0 puts the image pixel-to-pixel.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplayBackground.HorizontalImageScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.HorizontalImageScale`

#### Summary

The horizontal scale of the background image; the scale of 1.0 puts the image pixel-to-pixel.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplayBackground.VerticalImageOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.VerticalImageOffset`

#### Summary

The distance between the bottom viewport boundary and the bottom edge of the background image.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplayBackground.HorizontalImageOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.HorizontalImageOffset`

#### Summary

The distance between the left viewport boundary and the left edge of the background image.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplayBackground.ImageFlags`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.ImageFlags`

#### Summary

The image alignment indicators when the type is 'Image'.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplayBackground.ImagePath`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.ImagePath`

#### Summary

The path to the image file when the type is 'Image'.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplayBackground.SkyColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.SkyColor`

#### Summary

The color of the sky when the type is 'Gradient'.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplayBackground.BackgroundColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.BackgroundColor`

#### Summary

The color of the horizon when the type is 'Gradient'.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplayBackground.GroundColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.GroundColor`

#### Summary

The color of the ground when the type is 'Gradient' or 'SunAndClouds'.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewDisplayBackground.Type`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground.Type`

#### Summary

The type of the background.

#### Since

2014

### `T:Autodesk.Revit.DB.ViewDisplayBackground`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewDisplayBackground`

#### Summary

Set of values that control how background is drawn in a view.
Background can only be set for a 3d view or for a section or elevation view.

#### Since

2014

### `T:Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags`

#### Summary

A collection of bit flags that control how the background image is positioned
in relation to the crop region (or the view boundary).

#### Since

2014

### `F:Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags.UseTiling`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags.UseTiling`

#### Summary

The pixels of the background are filled by tiling of the image.

### `F:Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags.FixedAspectRatio`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags.FixedAspectRatio`

#### Summary

The image is stretched but the ratio of its height to width is preserved.

### `F:Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags.FitToScreen`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags.FitToScreen`

#### Summary

The image is stretched in both directions

### `F:Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags.None`

#### Summary

The image is displayed pixel-to-pixel

### `T:Autodesk.Revit.DB.ViewDisplayBackgroundType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewDisplayBackgroundType`

#### Summary

A collection of settings defining the type of the view background

#### Since

2014

### `F:Autodesk.Revit.DB.ViewDisplayBackgroundType.SunAndClouds`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewDisplayBackgroundType.SunAndClouds`

#### Summary

Best approximation to the colors of the sky and the visible sun disk.
The position of the visible sun disk is calculated based on the "sun and shadow settings"
(see 'ViewBackgroundLighting' object).

### `F:Autodesk.Revit.DB.ViewDisplayBackgroundType.Image`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewDisplayBackgroundType.Image`

#### Summary

User-specified image is drawn in the background either stretched
vertically/horizontally/in both directions, or as is (pixel-to-pixel).

### `F:Autodesk.Revit.DB.ViewDisplayBackgroundType.Gradient`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewDisplayBackgroundType.Gradient`

#### Summary

Three-color simulated sky-horizon-ground combination. The sky is
drawn in gradually changing color from the top (the "sky" color) to the
bottom (the "horizon" color). The ground is either drawn in the single
(the "ground") color, if the sky is visible, or in a gradient from the top
(the "horizon") color to the bottom (the "ground") color.

### `F:Autodesk.Revit.DB.ViewDisplayBackgroundType.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewDisplayBackgroundType.None`

#### Summary

No background defined - the color from Options is used to fill it.

### `T:Autodesk.Revit.DB.ViewDisplayEdges`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewDisplayEdges`

#### Summary

A collection of settings defining how visible edges are displayed

#### Since

2014

### `F:Autodesk.Revit.DB.ViewDisplayEdges.Simple`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewDisplayEdges.Simple`

#### Summary

The edges are visible and drawn according to style

### `F:Autodesk.Revit.DB.ViewDisplayEdges.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewDisplayEdges.None`

#### Summary

The edges are invisible

### `M:Autodesk.Revit.DB.ViewCropRegionShapeManager.GetAnnotationCropShape`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.GetAnnotationCropShape`

#### Summary

Gets the annotation crop box assigned to the view.

#### Remarks

Currently, this method returns only the rectangular annotation crop box.

#### Returns

The annotation crop boundary.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

View is not allowed to have an annotation crop.

#### Since

2016

### `M:Autodesk.Revit.DB.ViewCropRegionShapeManager.GetCropShape`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.GetCropShape`

#### Summary

Gets the crop boundaries that are curently active.

#### Remarks

This method returns a representation of the boundaries of the currently active crop for the associated view.
If the view crop has a non-rectangular shape, the method returns that shape.
Otherwise, if the view crop has been split, the method returns the multiple rectangular boundaries visible in the crop -
note that this does not reflect any offsets that may have been applied to the boundary regions.
If the crop is not split, this returns a single rectangle representing the crop.
All coordinates are in the coordinate frame of the view.

#### Returns

The crop boundaries.

#### Since

2016

### `M:Autodesk.Revit.DB.ViewCropRegionShapeManager.GetSplitRegionOffset(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.GetSplitRegionOffset(System.Int32)`

#### Summary

Returns the offset for the specified split crop region.

#### Remarks

The points in the split crop region's boundary are not in model space.
Add the offset returned by this method to each point in the crop region's
boundary to transform the points into model space coordinates.

#### Parameter `regionIndex`

Index of the split crop region (numbering starts with 0).

#### Returns

A vector in model space representing the offset which is applied to the split crop region's boundary.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The provided region index is invalid.

#### Since

2021

### `M:Autodesk.Revit.DB.ViewCropRegionShapeManager.GetSplitRegionMaximum(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.GetSplitRegionMaximum(System.Int32)`

#### Summary

Returns the proportional location of the maximum boundary of the specified split crop region.

#### Parameter `regionIndex`

Index of split crop region (numbering starts with 0).

#### Returns

A value from 0 to 1 representing the maximum location for the region's split boundary.
This number represents the location as a ratio along the non-split rectangular crop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The provided region index is invalid.

#### Since

2016

### `M:Autodesk.Revit.DB.ViewCropRegionShapeManager.GetSplitRegionMinimum(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.GetSplitRegionMinimum(System.Int32)`

#### Summary

Returns the proportional location of the minimum boundary of the specified split crop region.

#### Parameter `regionIndex`

Index of split crop region (numbering starts with 0).

#### Returns

A value from 0 to 1 representing the minimum location for the region's split boundary.
This number represents the location as a ratio along the non-split rectangular crop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The provided region index is invalid.

#### Since

2016

### `M:Autodesk.Revit.DB.ViewCropRegionShapeManager.SplitRegionHorizontally(System.Int32,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.SplitRegionHorizontally(System.Int32,System.Double,System.Double)`

#### Summary

Splits horizontally one region in split crop.

#### Remarks

This function splits the crop into two regions: one occupying the left quarter of the crop, and the other the right quarter of the crop.

#### Parameter `regionIndex`

Index of region to be split horizontally (numbering starts with 0).

#### Parameter `leftPart`

Relative portion of the original region to become the new left region (0 to 1).

#### Parameter `rightPart`

Relative portion of the original region to become the new right region (0 to 1).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The provided view region proportions are not valid.
-or-
The provided region index is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The crop of the associated view is not permitted to have multiple regions.
-or-
The view has non-rectangular crop shape set.
-or-
The view crop is already split vertically.

#### Since

2016

### `M:Autodesk.Revit.DB.ViewCropRegionShapeManager.SplitRegionVertically(System.Int32,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.SplitRegionVertically(System.Int32,System.Double,System.Double)`

#### Summary

Splits vertically one region in split crop.

#### Remarks

This function splits the crop into two regions: one occupying the top quarter of the crop, and the other the bottom quarter of the crop.

#### Parameter `regionIndex`

Index of region to be split vertically (numbering starts with 0).

#### Parameter `topPart`

Relative portion of the original region to become the new top region (0 to 1).

#### Parameter `bottomPart`

Relative portion of the original region to become the new bottom region (0 to 1).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The provided view region proportions are not valid.
-or-
The provided region index is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The crop of the associated view is not permitted to have multiple regions.
-or-
The view has non-rectangular crop shape set.
-or-
The view crop is already split horizontally.

#### Since

2016

### `M:Autodesk.Revit.DB.ViewCropRegionShapeManager.RemoveSplitRegion(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.RemoveSplitRegion(System.Int32)`

#### Summary

Removes one region in split crop.

#### Parameter `regionIndex`

Index of region to be deleted (numbering starts with 0).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The provided region index cannot be deleted.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The crop of the associated view is not permitted to have multiple regions.
-or-
The view has non-rectangular crop shape set.

#### Since

2016

### `M:Autodesk.Revit.DB.ViewCropRegionShapeManager.RemoveSplit`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.RemoveSplit`

#### Summary

Removes any split applied to the view's crop.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The crop of the associated view is not permitted to have multiple regions.

#### Since

2014

### `M:Autodesk.Revit.DB.ViewCropRegionShapeManager.RemoveCropRegionShape`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.RemoveCropRegionShape`

#### Summary

Removes any non-rectangular boundary of the view's crop.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The crop of the associated view is not permitted to have a non-rectangular shape.

#### Since

2014

### `M:Autodesk.Revit.DB.ViewCropRegionShapeManager.SetCropShape(Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.SetCropShape(Autodesk.Revit.DB.CurveLoop)`

#### Summary

Sets the boundary of the view's crop to the specified shape.

#### Remarks

Depending on the shape of the argument, view's crop is set to be either rectangular or non-rectangular.
If the crop is set to be rectangular and it is also split, then the multiple view regions will be displayed for the view,
with the same proportions as the split prior to the change, but adjusted to the new rectangular shape.

This Method is reserved for setting crop shape in views that allow non-rectangular crop shapes - see property `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.CanHaveShape` .
For views that don't allow non-rectangular crop shapes (e.g. `T:Autodesk.Revit.DB.View3D` ), please use property `P:Autodesk.Revit.DB.View.CropBox` for that purpose.

#### Parameter `boundary`

The crop boundary.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Boundary in boundary should represent one closed curve loop without self-intersections,
consisting of non-zero length straight lines in a plane parallel to the view plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The crop of the associated view is not permitted to have a non-rectangular shape.

#### Since

2014

### `M:Autodesk.Revit.DB.ViewCropRegionShapeManager.IsCropRegionShapeValid(Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.IsCropRegionShapeValid(Autodesk.Revit.DB.CurveLoop)`

#### Summary

Verifies that boundary represents one closed curve loop without self-intersections,
consisting of non-zero length straight lines in a plane parallel to the view plane.

#### Remarks

Curves in boundary use model coordinates.

#### Parameter `boundary`

The crop boundary.

#### Returns

True if the passed crop boundary represents one closed curve loop without self-intersections,
consisting of non-zero length straight lines in a plane parallel to the view plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.RightAnnotationCropOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.RightAnnotationCropOffset`

#### Summary

The offset from the right of the view crop that determines the location of the annotation crop right boundary.

#### Remarks

This value must be a non-negative length in view units.
Default value is 1/12' (1"), minimal value is 1/96' (1/8").
To get offset in model units, multiply the value by the view scale.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for offset must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

View is not allowed to have an annotation crop.

#### Since

2016

### `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.LeftAnnotationCropOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.LeftAnnotationCropOffset`

#### Summary

The offset from the left of the view crop that determines the location of the annotation crop left boundary.

#### Remarks

This value must be a non-negative length in view units.
Default value is 1/12' (1"), minimal value is 1/96' (1/8").
To get offset in model units, multiply the value by the view scale.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for offset must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

View is not allowed to have an annotation crop.

#### Since

2016

### `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.BottomAnnotationCropOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.BottomAnnotationCropOffset`

#### Summary

The offset from the bottom of the view crop that determines the location of the annotation crop bottom boundary.

#### Remarks

This value must be a non-negative length in view units.
Default value is 1/12' (1"), minimal value is 1/96' (1/8").
To get offset in model units, multiply the value by the view scale.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for offset must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

View is not allowed to have an annotation crop.

#### Since

2016

### `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.TopAnnotationCropOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.TopAnnotationCropOffset`

#### Summary

The offset from the top of the view crop that determines the location of the annotation crop top boundary.

#### Remarks

This value must be a non-negative length in view units.
Default value is 1/12' (1"), minimal value is 1/96' (1/8").
To get offset in model units, multiply the value by the view scale.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for offset must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

View is not allowed to have an annotation crop.

#### Since

2016

### `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.CanHaveAnnotationCrop`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.CanHaveAnnotationCrop`

#### Summary

Verifies that the view is allowed to have an annotation crop.

#### Since

2016

### `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.IsSplitVertically`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.IsSplitVertically`

#### Summary

Whether or not the view's crop is split (and the split is vertical).

#### Since

2016

### `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.IsSplitHorizontally`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.IsSplitHorizontally`

#### Summary

Whether or not the view's crop is split (and the split is horizontal).

#### Since

2016

### `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.NumberOfSplitRegions`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.NumberOfSplitRegions`

#### Summary

The number of split crop regions (1 if the crop is not currently split).

#### Since

2016

### `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.ShapeSet`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.ShapeSet`

#### Summary

Whether or not the view crop has a non-rectangular shape set.

#### Remarks

This property reflects the actual shape of the crop region.
Thus, if this property is true the view Split property is false.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.Split`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.Split`

#### Summary

Whether or not the view crop is split.

#### Remarks

This property reflects the actual visual split of the crop region.
Thus, if the view has non-rectangular crop shape set, this property is false.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.CanBeSplit`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.CanBeSplit`

#### Summary

Verifies that the crop of the associated view is permitted to have multiple regions.

#### Since

2016

### `P:Autodesk.Revit.DB.ViewCropRegionShapeManager.CanHaveShape`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager.CanHaveShape`

#### Summary

Verifies that the crop of the associated view is permitted to have a non-rectangular shape.

#### Since

2016

### `T:Autodesk.Revit.DB.ViewCropRegionShapeManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewCropRegionShapeManager`

#### Summary

A class that provides access to settings related to the crop assigned to a view or a reference callout.

#### Remarks

This class manages all the settings that make up the model and annotation crop geometry for a given view or reference callout.
You can obtain the settings for a view from `M:Autodesk.Revit.DB.View.GetCropRegionShapeManager` .
Obtain the settings for a reference callout from `M:Autodesk.Revit.DB.View.GetCropRegionShapeManagerForReferenceCallout(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)` .

The model crop region crops model elements, detail elements (such as insulation and detail lines), section boxes,
and scope boxes at the model crop boundary.
Visible crop boundaries of other related views are also cropped at the model crop boundary.
The model crop region can be set as a polygonal boundary, a rectangular boundary,
or rectangular boundary with one or more splits applied either horizontally or vertically.
If a split is applied to the rectangular crop each resulting rectangular region is identified by a region index and occupies
a percentage of the original crop rectangle. The regions may possibly be moved relative to one another.

The annotation crop region fully crops annotation elements when it touches any portion of the annotation element,
so that no partial annotations are drawn.
Annotations (such as symbols, tags, keynotes, and dimensions) that reference hidden or cropped model elements do not display in the view,
even if they are inside the annotation crop region.
The annotation crop region is always rectangular and at minimum occupies the same area as the rectangular model crop
(or the corresponding rectangular boundary around the non-rectangular model crop),
but can be offset to be bigger than the model crop in order to display more annotations.

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrides.ArePointCloudOverrideSettingsValid(System.String,Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides.ArePointCloudOverrideSettingsValid(System.String,Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings)`

#### Summary

Checks if PointCloudOverrideSettings are valid

#### Parameter `tag`

The tag identifying the particular scan/region within the PointCloudInstance element.
Tags can be obtained from PointCloudInstance via method getScans/getRegions.

#### Parameter `settings`

Override settings to be checked.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrides.SetPointCloudRegionOverrideSettings(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings,System.String,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides.SetPointCloudRegionOverrideSettings(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings,System.String,Autodesk.Revit.DB.Document)`

#### Summary

Assigns override settings to a particular region within a PointCloudInstance element.

#### Parameter `elementId`

Id of the element to be overridden.

#### Parameter `newSettings`

Override settings to be assigned.

#### Parameter `regionTag`

The tag identifying the particular region within the PointCloudInstance element.
Tags can be obtained from PointCloudInstance via method getRegions.

#### Parameter `doc`

Document containing the element to be overridden.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when supplied regionTag is not empty while doc is NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The override settings are not valid.

#### Since

2017

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrides.SetPointCloudScanOverrideSettings(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings,System.String,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides.SetPointCloudScanOverrideSettings(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings,System.String,Autodesk.Revit.DB.Document)`

#### Summary

Assigns scan override settings to a particular scan within a PointCloudInstance element.

#### Parameter `elementId`

Id of the element to be overridden.

#### Parameter `newSettings`

Override settings to be assigned.

#### Parameter `scanTag`

The tag identifying the particular scan within the PointCloudInstance element.
Tags can be obtained from PointCloudInstance via method getScans.

#### Parameter `doc`

Document containing the element to be overridden.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when supplied scanTag is not empty while doc is NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The override settings are not valid.

#### Since

2017

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrides.GetPointCloudRegionOverrideSettings(Autodesk.Revit.DB.ElementId,System.String,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides.GetPointCloudRegionOverrideSettings(Autodesk.Revit.DB.ElementId,System.String,Autodesk.Revit.DB.Document)`

#### Summary

Gets override settings assigned to a particular region within a PointCloudInstance element.

#### Parameter `elementId`

Id of the overridden element.

#### Parameter `regionTag`

The tag identifying the particular region within the PointCloudInstance element.
Tags can be obtained from PointCloudInstance via method getRegions.

#### Parameter `doc`

Document containing the overridden element.

#### Returns

The override settings assigned to the region, if present, or a default override settings if nothing was found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when supplied regionTag is not empty while doc is NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrides.GetPointCloudScanOverrideSettings(Autodesk.Revit.DB.ElementId,System.String,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides.GetPointCloudScanOverrideSettings(Autodesk.Revit.DB.ElementId,System.String,Autodesk.Revit.DB.Document)`

#### Summary

Gets override settings assigned to a particular scan within a PointCloudInstance element.

#### Parameter `elementId`

Id of the overridden element.

#### Parameter `scanTag`

The tag identifying the particular scan within the PointCloudInstance element.
Tags can be obtained from PointCloudInstance via method getScans.

#### Parameter `doc`

Document containing the overridden element.

#### Returns

The override settings assigned to the scan, if present, or a default override settings if nothing was found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when supplied scanTag is not empty while doc is NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrides.SetPointCloudRegionOverrideSettings(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides.SetPointCloudRegionOverrideSettings(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings)`

#### Summary

Assigns region override settings to the whole PointCloudInstance element.

#### Parameter `elementId`

Id of the element to be overridden.

#### Parameter `newSettings`

Override settings to be assigned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrides.SetPointCloudScanOverrideSettings(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides.SetPointCloudScanOverrideSettings(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings)`

#### Summary

Assigns scan override settings to the whole PointCloudInstance element.

#### Parameter `elementId`

Id of the element to be overridden.

#### Parameter `newSettings`

Override settings to be assigned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrides.GetPointCloudRegionOverrideSettings(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides.GetPointCloudRegionOverrideSettings(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets region override settings assigned to the whole PointCloudInstance element.

#### Parameter `elementId`

Id of the overridden element.

#### Returns

The override settings assigned to the element, if present, or a default override settings if nothing was found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrides.GetPointCloudScanOverrideSettings(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides.GetPointCloudScanOverrideSettings(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets scan override settings assigned to the whole PointCloudInstance element.

#### Parameter `elementId`

Id of the overridden element.

#### Returns

The override settings assigned to the element, if present, or a default override settings if nothing was found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrides.Assign(Autodesk.Revit.DB.PointClouds.PointCloudOverrides)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides.Assign(Autodesk.Revit.DB.PointClouds.PointCloudOverrides)`

#### Summary

Assigns values of the source overrides to this object.

#### Parameter `other`

The source overrides.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrides.IsEqual(Autodesk.Revit.DB.PointClouds.PointCloudOverrides)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides.IsEqual(Autodesk.Revit.DB.PointClouds.PointCloudOverrides)`

#### Summary

Check if the contents of two overrides are equal.

#### Parameter `other`

The overrides to be compared.

#### Returns

True for equal, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.PointClouds.PointCloudOverrides.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrides.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides.#ctor`

#### Summary

Constructs empty overrides object.

#### Since

2014

### `T:Autodesk.Revit.DB.PointClouds.PointCloudOverrides`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrides`

#### Summary

Graphic overrides that are stored by a view to be applied to a PointCloudInstance element, or a scan within the element.

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.GetModeOverride(Autodesk.Revit.DB.PointCloudColorMode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.GetModeOverride(Autodesk.Revit.DB.PointCloudColorMode)`

#### Summary

Lookup color settings for the given color mode.

#### Parameter `mode`

Color mode for which to lookup the color settings.

#### Returns

Color settings stored for the given color mode or default color settings if nothing is stored for the given color mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.SetModeOverride(Autodesk.Revit.DB.PointCloudColorMode,Autodesk.Revit.DB.PointClouds.PointCloudColorSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.SetModeOverride(Autodesk.Revit.DB.PointCloudColorMode,Autodesk.Revit.DB.PointClouds.PointCloudColorSettings)`

#### Summary

Sets color settings for the given color mode.

#### Parameter `mode`

Color mode for which color settings are set.

#### Parameter `colorSettings`

Color settings to be set for the given color mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.IsEqual(Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.IsEqual(Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings)`

#### Summary

Checks if the contents of two settings are equal.

#### Parameter `other`

The settings to be compared.

#### Returns

True for equal, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.Assign(Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.Assign(Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings)`

#### Summary

Assigns values of the source settings to this object.

#### Parameter `other`

The source settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.ColorMode`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.ColorMode`

#### Summary

The current color mode for the PointCloudInstance element or its scan.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.Visible`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.Visible`

#### Summary

Visibility flag for point cloud scans.

#### Remarks

This flag is used only for visibility of point cloud scans
because the visibility of the whole point cloud element is managed as for other elements hidden in the view.

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.#ctor(Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.#ctor(Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings)`

#### Summary

Constructs a copy of source object.

#### Parameter `other`

Source object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings.#ctor`

#### Summary

Constructs a settings object with default values.

#### Since

2014

### `T:Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings`

#### Summary

The graphic override settings for one PointCloudInstance element or one of its scans.

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.IsEqual(Autodesk.Revit.DB.PointClouds.PointCloudColorSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.IsEqual(Autodesk.Revit.DB.PointClouds.PointCloudColorSettings)`

#### Summary

Check if the contents of two settings are equal.

#### Parameter `other`

The settings to be compared.

#### Returns

True for equal, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.Assign(Autodesk.Revit.DB.PointClouds.PointCloudColorSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.Assign(Autodesk.Revit.DB.PointClouds.PointCloudColorSettings)`

#### Summary

Assigns values of the source settings to this object.

#### Parameter `other`

The source settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.Color2`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.Color2`

#### Summary

Color 2

#### Since

2014

### `P:Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.Color1`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.Color1`

#### Summary

Color 1

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.#ctor(Autodesk.Revit.DB.PointClouds.PointCloudColorSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.#ctor(Autodesk.Revit.DB.PointClouds.PointCloudColorSettings)`

#### Summary

Constructs a copy of source object.

#### Parameter `other`

Source object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.#ctor(Autodesk.Revit.DB.Color,Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.#ctor(Autodesk.Revit.DB.Color,Autodesk.Revit.DB.Color)`

#### Summary

Constructs color settings object from given colors.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.#ctor(Autodesk.Revit.DB.PointCloudColorMode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.#ctor(Autodesk.Revit.DB.PointCloudColorMode)`

#### Summary

Constructs color settings object with default color for given color mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudColorSettings.#ctor`

#### Summary

Constructs color settings object with default colors.

#### Since

2014

### `T:Autodesk.Revit.DB.PointClouds.PointCloudColorSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudColorSettings`

#### Summary

The color settings which are applied to a PointCloudInstance element, or one of its scans.

#### Remarks

For different color modes (PointCloudColorMode), the color settings mean different things:
for single color, color1 means the display color

for other modes (intensity, elevation), color1 and color2 form a gradient from min to max

for no overrides and normals, color1 and color2 are not used

#### Since

2014

### `T:Autodesk.Revit.DB.PointCloudColorMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointCloudColorMode`

#### Summary

Color mode of a point cloud or part of a point cloud

#### Since

2014

### `F:Autodesk.Revit.DB.PointCloudColorMode.Normals`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointCloudColorMode.Normals`

#### Summary

Color by normal vectors

### `F:Autodesk.Revit.DB.PointCloudColorMode.Intensity`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointCloudColorMode.Intensity`

#### Summary

Color by intensity (reflectivity)

### `F:Autodesk.Revit.DB.PointCloudColorMode.Elevation`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointCloudColorMode.Elevation`

#### Summary

Color by elevation

### `F:Autodesk.Revit.DB.PointCloudColorMode.FixedColor`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointCloudColorMode.FixedColor`

#### Summary

Show a single color

### `F:Autodesk.Revit.DB.PointCloudColorMode.NoOverride`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointCloudColorMode.NoOverride`

#### Summary

Show the actual colors

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetCutBackgroundPatternId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetCutBackgroundPatternId(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the ElementId of the cut face background pattern override.
The fill pattern must be a drafting pattern.
A value of InvalidElementId means no override is set.

#### Parameter `fillPatternId`

Value of the cut face background fill pattern override.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetCutForegroundPatternId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetCutForegroundPatternId(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the ElementId of the cut face foreground pattern override.
The fill pattern must be a drafting pattern.
A value of InvalidElementId means no override is set.

#### Parameter `fillPatternId`

Value of the cut face foreground fill pattern override.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceBackgroundPatternId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceBackgroundPatternId(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the ElementId of the surface background pattern override.
The fill pattern must be a drafting pattern.
A value of InvalidElementId means no override is set.

#### Parameter `fillPatternId`

Value of the surface background fill pattern override.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceForegroundPatternId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceForegroundPatternId(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the ElementId of the surface foreground pattern override.
The fill pattern must be a drafting pattern.
A value of InvalidElementId means no override is set.

#### Parameter `fillPatternId`

Value of the surface foreground fill pattern override.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetCutBackgroundPatternColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetCutBackgroundPatternColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the override color of the background pattern of cut faces.

#### Parameter `color`

Value of the cut face background color for the override. InvalidColorValue means no override is set.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetCutForegroundPatternColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetCutForegroundPatternColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the override color of the foreground pattern of cut faces.

#### Parameter `color`

Value of the cut face foreground color for the override. InvalidColorValue means no override is set.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceBackgroundPatternColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceBackgroundPatternColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the override color of the surface background pattern.

#### Parameter `color`

Value of the surface background color for the override. InvalidColorValue means no override is set.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceForegroundPatternColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceForegroundPatternColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the override color of the surface foreground pattern.

#### Parameter `color`

Value of the surface foreground color for the override. InvalidColorValue means no override is set.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetCutBackgroundPatternVisible(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetCutBackgroundPatternVisible(System.Boolean)`

#### Summary

Sets the visibility of the cut face background fill pattern.

#### Parameter `fillPatternVisible`

Value of the visibility of the cut face background fill pattern.

#### Returns

Reference to the changed object.

#### Since

2019

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetCutForegroundPatternVisible(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetCutForegroundPatternVisible(System.Boolean)`

#### Summary

Sets the visibility of the cut face foreground fill pattern.

#### Parameter `fillPatternVisible`

Value of the visibility of the cut face foreground fill pattern.

#### Returns

Reference to the changed object.

#### Since

2019

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceBackgroundPatternVisible(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceBackgroundPatternVisible(System.Boolean)`

#### Summary

Sets the visibility of the surface background fill pattern.

#### Parameter `fillPatternVisible`

Value of the visibility of the surface background fill pattern.

#### Returns

Reference to the changed object.

#### Since

2019

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceForegroundPatternVisible(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceForegroundPatternVisible(System.Boolean)`

#### Summary

Sets the visibility of the surface foreground fill pattern.

#### Parameter `fillPatternVisible`

Value of the visibility of the surface foreground fill pattern.

#### Returns

Reference to the changed object.

#### Since

2019

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetCutLinePatternId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetCutLinePatternId(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the ElementId of the cut surface line pattern.

#### Parameter `linePatternId`

ElementId of the cut surface line pattern for the override. InvalidElementId means no override is set.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetCutLineColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetCutLineColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the cut surface line color.

#### Parameter `color`

Value of the cut surface line color for the override. InvalidColorValue means no override is set.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetCutLineWeight(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetCutLineWeight(System.Int32)`

#### Summary

Sets the cut surface line weight.

#### Parameter `lineWeight`

Value of the cut surface line weight for the override. InvalidPenNumber means no override is set.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Line weight must be a positive integer less than 17 or invalidPenNumber.

#### Since

2014

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceTransparency(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetSurfaceTransparency(System.Int32)`

#### Summary

Sets the projection surface transparency.

#### Parameter `transparency`

Value of the transparency of the projection surface (0 = opaque, 100 = fully transparent).

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Transparency must be greater than 0 and less than 100.

#### Since

2014

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetProjectionLinePatternId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetProjectionLinePatternId(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the ElementId of the projection surface line pattern.

#### Parameter `linePatternId`

ElementId of the projection surface line pattern for the override. InvalidElementId means no override is set.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetProjectionLineColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetProjectionLineColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the projection surface line color.

#### Parameter `color`

Value of the projection surface line color for the override. InvalidColorValue means no override is set.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetProjectionLineWeight(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetProjectionLineWeight(System.Int32)`

#### Summary

Sets the projection surface line weight.

#### Parameter `lineWeight`

Value of the projection surface line weight for the override. InvalidPenNumber means no override is set.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Line weight must be a positive integer less than 17 or invalidPenNumber.

#### Since

2014

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetDetailLevel(Autodesk.Revit.DB.ViewDetailLevel)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetDetailLevel(Autodesk.Revit.DB.ViewDetailLevel)`

#### Summary

Sets the detail level.

#### Parameter `detailLevel`

Value of the detail level. ViewDetailLevel.Undefined means no override is set.

#### Returns

Reference to the changed object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.SetHalftone(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SetHalftone(System.Boolean)`

#### Summary

Sets the halftone value.

#### Parameter `halftone`

True if the override displays in halftone, false otherwise.

#### Returns

Reference to the changed object.

#### Since

2014

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.InvalidPenNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.InvalidPenNumber`

#### Summary

The invalidPenNumber for clearing line weight overrides.

#### Since

2014

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.CutBackgroundPatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.CutBackgroundPatternId`

#### Summary

The ElementId of the cut face background fill pattern override.
A value of InvalidElementId means no override is set.

#### Since

2019

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.CutForegroundPatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.CutForegroundPatternId`

#### Summary

The ElementId of the cut face foreground fill pattern override.
A value of InvalidElementId means no override is set.

#### Since

2019

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.SurfaceBackgroundPatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SurfaceBackgroundPatternId`

#### Summary

The ElementId of the surface background fill pattern override.
A value of InvalidElementId means no override is set.

#### Since

2019

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.SurfaceForegroundPatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SurfaceForegroundPatternId`

#### Summary

The ElementId of the surface foreground fill pattern override.
A value of InvalidElementId means no override is set.

#### Since

2019

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.CutBackgroundPatternColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.CutBackgroundPatternColor`

#### Summary

The override color of the background pattern of cut faces.

#### Since

2019

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.CutForegroundPatternColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.CutForegroundPatternColor`

#### Summary

The override color of the foreground pattern of cut faces.

#### Since

2019

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.SurfaceBackgroundPatternColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SurfaceBackgroundPatternColor`

#### Summary

The override color of the surface background pattern.

#### Since

2019

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.SurfaceForegroundPatternColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.SurfaceForegroundPatternColor`

#### Summary

The override color of the surface foreground pattern.

#### Since

2019

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.IsCutBackgroundPatternVisible`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.IsCutBackgroundPatternVisible`

#### Summary

The visibility of the cut face background fill pattern.

#### Since

2019

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.IsCutForegroundPatternVisible`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.IsCutForegroundPatternVisible`

#### Summary

The visibility of the cut face foreground fill pattern.

#### Since

2019

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.IsSurfaceBackgroundPatternVisible`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.IsSurfaceBackgroundPatternVisible`

#### Summary

The visibility of the surface background fill pattern.

#### Since

2019

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.IsSurfaceForegroundPatternVisible`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.IsSurfaceForegroundPatternVisible`

#### Summary

The visibility of the surface foreground fill pattern.

#### Since

2019

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.CutLinePatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.CutLinePatternId`

#### Summary

ElementId of the cut surface line pattern.

#### Since

2014

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.CutLineColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.CutLineColor`

#### Summary

Cut surface line color.

#### Since

2014

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.CutLineWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.CutLineWeight`

#### Summary

Cut surface line weight.

#### Since

2014

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.Transparency`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.Transparency`

#### Summary

Transparency of surfaces.

#### Since

2014

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.ProjectionLinePatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.ProjectionLinePatternId`

#### Summary

Id of the projection surface line pattern.

#### Since

2014

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.ProjectionLineColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.ProjectionLineColor`

#### Summary

Projection surface line color.

#### Since

2014

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.ProjectionLineWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.ProjectionLineWeight`

#### Summary

The projection surface line weight.

#### Since

2014

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.DetailLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.DetailLevel`

#### Summary

The detail level.

#### Since

2014

### `P:Autodesk.Revit.DB.OverrideGraphicSettings.Halftone`

Member kind: property
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.Halftone`

#### Summary

Value of the halftone override.

#### Since

2014

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.#ctor(Autodesk.Revit.DB.OverrideGraphicSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.#ctor(Autodesk.Revit.DB.OverrideGraphicSettings)`

#### Summary

Creates a new instance of an OverrideGraphicSettings object based on an existing OverrideGraphicSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.OverrideGraphicSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings.#ctor`

#### Summary

Creates a new instance of an OverrideGraphicSettings object.

#### Since

2014

### `T:Autodesk.Revit.DB.OverrideGraphicSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.OverrideGraphicSettings`

#### Summary

Settings to override display of elements in a view.

#### Since

2014

### `T:Autodesk.Revit.DB.OverridePermissions`

Member kind: type
Symbol: `Autodesk.Revit.DB.OverridePermissions`

#### Summary

Types of overrides that can be applied to a category.

#### Since

2014

### `F:Autodesk.Revit.DB.OverridePermissions.Surfaces`

Member kind: field
Symbol: `Autodesk.Revit.DB.OverridePermissions.Surfaces`

#### Summary

Surface transparency

### `F:Autodesk.Revit.DB.OverridePermissions.ProjectionFills`

Member kind: field
Symbol: `Autodesk.Revit.DB.OverridePermissions.ProjectionFills`

#### Summary

Projection fills

### `F:Autodesk.Revit.DB.OverridePermissions.ProjectionLines`

Member kind: field
Symbol: `Autodesk.Revit.DB.OverridePermissions.ProjectionLines`

#### Summary

Projection lines

### `F:Autodesk.Revit.DB.OverridePermissions.CutFills`

Member kind: field
Symbol: `Autodesk.Revit.DB.OverridePermissions.CutFills`

#### Summary

Cut fills

### `F:Autodesk.Revit.DB.OverridePermissions.CutLines`

Member kind: field
Symbol: `Autodesk.Revit.DB.OverridePermissions.CutLines`

#### Summary

Cut lines

### `F:Autodesk.Revit.DB.OverridePermissions.Halftone`

Member kind: field
Symbol: `Autodesk.Revit.DB.OverridePermissions.Halftone`

#### Summary

Halftone

### `F:Autodesk.Revit.DB.OverridePermissions.ViewDetailLevel`

Member kind: field
Symbol: `Autodesk.Revit.DB.OverridePermissions.ViewDetailLevel`

#### Summary

View detail level

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides.SetDirectContext3DHandleSettings(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides.SetDirectContext3DHandleSettings(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings)`

#### Summary

Assigns override settings associated with a DirectContext3D handle instance or type.

#### Parameter `aDoc`

Document where elementId resides.

#### Parameter `elementId`

Id of the element to be overridden.

#### Parameter `newSettings`

The override settings to be assigned to the handle element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId elementId is not a valid DirectContext3D handle instance or type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides.GetDirectContext3DHandleSettings(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides.GetDirectContext3DHandleSettings(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets override settings associated with a DirectContext3D handle instance or type.

#### Parameter `aDoc`

Document where elementId resides.

#### Parameter `elementId`

Id of the overridden element.

#### Returns

The override settings assigned to the handle element, if present, or a default override settings if nothing was found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId elementId is not a valid DirectContext3D handle instance or type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides.Assign(Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides.Assign(Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides)`

#### Summary

Assigns values of the source overrides to this object.

#### Parameter `other`

The source overrides.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides.IsEqual(Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides.IsEqual(Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides)`

#### Summary

Check if the contents of two overrides are equal.

#### Parameter `other`

The overrides to be compared.

#### Returns

True for equal, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides`

#### Summary

A set of DirectContext3DHandleSettings that are stored by a view.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.GetTransparency`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.GetTransparency`

#### Summary

Gets the transparency value of the handle and the associated DirectContext3D graphics.

#### Returns

The transparency value (in percentage)

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.SetTransparency(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.SetTransparency(System.Int32)`

#### Summary

Sets the transparency value of the handle and the associated DirectContext3D graphics.

#### Parameter `transparency`

The transparency value to apply (in percentage)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The value is invalid. The valid range is 0 through 100

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.IsEqual(Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.IsEqual(Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings)`

#### Summary

Check if the contents of two instances of settings are equal.

#### Parameter `other`

The settings to be compared.

#### Returns

True for equal, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.Assign(Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.Assign(Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings)`

#### Summary

Assigns values of the source settings to this object.

#### Parameter `other`

The source settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.Visibility`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.Visibility`

#### Summary

Visibility of the handle and the associated DirectContext3D graphics.
A value of true means that the graphics are visible.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.#ctor(Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.#ctor(Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings)`

#### Summary

Constructs a copy of source object.

#### Parameter `other`

Source object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.#ctor(System.Boolean,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.#ctor(System.Boolean,System.Int32)`

#### Summary

Constructs an instance of settings with provided values.

#### Parameter `visibility`

Source visibility.

#### Parameter `transparency`

Source transparency.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The value is invalid. The valid range is 0 through 100

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings.#ctor`

#### Summary

Constructs an instance of settings with default values.

#### Since

2018

### `T:Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings`

#### Summary

Overriding settings applied to DirectContext3DHandles through the Visibility dialog.

#### Remarks

DirectContext3D graphics can be displayed with or without an associated DirectContext3D handle
element. For DirectContext3D graphics that utilize the handle element, the visibility and appearance of
the graphics can be adjusted through the Visibility/Graphics dialog.

#### Since

2018

### `P:Autodesk.Revit.Attributes.TransactionAttribute.Mode`

Member kind: property
Symbol: `Autodesk.Revit.Attributes.TransactionAttribute.Mode`

#### Summary

Transaction mode.

#### Since

2011

### `M:Autodesk.Revit.Attributes.TransactionAttribute.#ctor(Autodesk.Revit.Attributes.TransactionMode)`

Member kind: method
Symbol: `Autodesk.Revit.Attributes.TransactionAttribute.#ctor(Autodesk.Revit.Attributes.TransactionMode)`

#### Summary

Constructs a new TransactionAttribute.

#### Since

2011

### `T:Autodesk.Revit.Attributes.TransactionAttribute`

Member kind: type
Symbol: `Autodesk.Revit.Attributes.TransactionAttribute`

#### Summary

The custom transaction attribute to control the transaction behavior of the external command.

#### Since

2011

### `T:Autodesk.Revit.Attributes.TransactionMode`

Member kind: type
Symbol: `Autodesk.Revit.Attributes.TransactionMode`

#### Summary

All transaction modes supported by Revit external commands.

#### Since

2011

### `F:Autodesk.Revit.Attributes.TransactionMode.ReadOnly`

Member kind: field
Symbol: `Autodesk.Revit.Attributes.TransactionMode.ReadOnly`

#### Summary

No transaction (nor group) will be created, and no transaction may be created for the lifetime of the command.
The External command may use methods that only read from the model, but not methods that write anything to it.
Exceptions will be thrown if the command either tries to start a transaction (or group) or attempts to write to the model.

#### Remarks

A command with this transaction mode should not be associated to a command visible when there is no active document.
The command will not be permitted to be started.

### `F:Autodesk.Revit.Attributes.TransactionMode.Manual`

Member kind: field
Symbol: `Autodesk.Revit.Attributes.TransactionMode.Manual`

#### Summary

The API framework will not create a transaction (but will create an outer group to roll back all changes
if the external command returns a failure status). Instead, you may use combinations of transactions, sub-transactions,
and groups. You will have to follow all rules regarding use of transactions and related classes.
You will have to give your transactions names, which will then appear in the undo menu.
Revit will check that all transactions (also groups and sub-transaction) are properly closed upon return from an external command.
If not, it will discard all changes to the model.

### `M:Autodesk.Revit.DB.Transform1D.TransformParameterDomain(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform1D.TransformParameterDomain(System.Double,System.Double)`

#### Summary

Performs a transform of the parameter range defined by domain, and ensures that the domain is ordered correctly.

#### Remarks

If the domain is empty it is unchanged.

#### Parameter `domainStart`

The original parameter domain start.

#### Parameter `domainEnd`

The original parameter domain end.

#### Since

2021

### `M:Autodesk.Revit.DB.Transform1D.GetInverse`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform1D.GetInverse`

#### Summary

Gets the inverse transformation of this transformation.

#### Remarks

The transformation matrix A is invertible if there exists a transformation matrix B such that A*B = B*A = I (identity).

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This transformation is singular.

#### Since

2021

### `M:Autodesk.Revit.DB.Transform1D.OfVector(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform1D.OfVector(System.Double)`

#### Summary

Applies the transformation to the 1-dimensional vector (a "tangent vector" on the real line) and returns the result.

#### Remarks

Transformation of a vector is not affected by the translational part of the transformation.

#### Parameter `vector`

The vector to transform.

#### Returns

The transformed vector.

#### Since

2021

### `M:Autodesk.Revit.DB.Transform1D.OfPoint(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform1D.OfPoint(System.Double)`

#### Summary

Applies the transformation to the 1-dimensional point and returns the result.

#### Remarks

Transformation of a point is affected by the translational part of the transformation.

#### Parameter `point`

The point to transform.

#### Returns

The transformed point.

#### Since

2021

### `M:Autodesk.Revit.DB.Transform1D.Multiply(Autodesk.Revit.DB.Transform1D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform1D.Multiply(Autodesk.Revit.DB.Transform1D)`

#### Summary

Multiplies this transformation by the specified transformation and returns the result.

#### Remarks

The combined transformation has the same effect as applying the input transformation first, and this transformation, second. So, (T1(T2(p)) = (T1 * T2) (p).

#### Parameter `right`

The input transformation.

#### Returns

The transformation equal to the composition of the two transformations.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Transform1D.SetToIdentity`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform1D.SetToIdentity`

#### Summary

Set this TrfUV to the identity transform

#### Returns

Returns a pointer to "this" `T:Autodesk.Revit.DB.Transform1D` .

#### Since

2021

### `M:Autodesk.Revit.DB.Transform1D.Assign(Autodesk.Revit.DB.Transform1D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform1D.Assign(Autodesk.Revit.DB.Transform1D)`

#### Summary

Assigns values from the input transformation to this transformation.

#### Parameter `from`

The transformation to use as input.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Transform1D.AlmostEqual(Autodesk.Revit.DB.Transform1D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform1D.AlmostEqual(Autodesk.Revit.DB.Transform1D)`

#### Summary

Determines whether this transformation and the specified transformation are the same within the tolerance (1.0e-09).

#### Remarks

The tolerance is applied memberwise for comparison.

#### Parameter `right`

The transformation to compare with this transformation.

#### Returns

True if the two transformations are equal, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `P:Autodesk.Revit.DB.Transform1D.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform1D.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Transform1D.Determinant`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform1D.Determinant`

#### Summary

The determinant of this transformation.

#### Since

2021

### `P:Autodesk.Revit.DB.Transform1D.IsIdentity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform1D.IsIdentity`

#### Summary

The boolean value that indicates whether this transformation is an identity.

#### Remarks

The identity transformation does not change a point or a vector that it is applied to.

#### Since

2021

### `P:Autodesk.Revit.DB.Transform1D.Translation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform1D.Translation`

#### Summary

The translational part of this transformation.

#### Since

2021

### `P:Autodesk.Revit.DB.Transform1D.Scale`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform1D.Scale`

#### Summary

The real number that represents the scale of this transformation.

#### Since

2021

### `M:Autodesk.Revit.DB.Transform1D.#ctor(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform1D.#ctor(System.Double)`

#### Summary

Constructs the transformation by specifying the scale only.

#### Remarks

The translation is set to zero.
1D space is tranformed according to the following formula: t --> scale*t + translation
This constructor sets translation to zero.

#### Parameter `scale`

The scale of the transformation.

#### Since

2021

### `M:Autodesk.Revit.DB.Transform1D.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform1D.#ctor(System.Double,System.Double)`

#### Summary

Constructs the transformation by specifying the scale and the translation.

#### Remarks

1D space is tranformed according to the following formula: t --> scale*t + translation

#### Parameter `scale`

The scale of the transformation.

#### Parameter `translation`

The translational part of the transformation.

#### Since

2021

### `M:Autodesk.Revit.DB.Transform1D.#ctor(Autodesk.Revit.DB.Transform1D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform1D.#ctor(Autodesk.Revit.DB.Transform1D)`

#### Summary

The copy constructor.

#### Parameter `other`

The transformation to use as input.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `T:Autodesk.Revit.DB.Transform1D`

Member kind: type
Symbol: `Autodesk.Revit.DB.Transform1D`

#### Summary

An affine transform of 1D Euclidean space.

#### Remarks

An affine transform is a linear transform plus a translation (which may be zero).
1D space is tranformed according to the following formula: t -> A*t + B where A and B are constants.
Some functions only accept certain kinds of transform (e.g., rigid motion, conformal, non-singular, etc.).

#### Since

2021

### `M:Autodesk.Revit.DB.TransmissionData.DocumentIsNotTransmitted(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransmissionData.DocumentIsNotTransmitted(Autodesk.Revit.DB.ModelPath)`

#### Summary

Determines whether the document at a given file location
is not transmitted.

#### Parameter `filePath`

The path to the document whose transmitted state will be checked.

#### Returns

False if the document is a transmitted file, true otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.TransmissionData.IsDocumentTransmitted(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransmissionData.IsDocumentTransmitted(Autodesk.Revit.DB.ModelPath)`

#### Summary

Determines whether the document at a given file location
is transmitted.

#### Parameter `filePath`

The path to the document whose transmitted state will be checked.

#### Returns

True if the document is a transmitted file, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.TransmissionData.WriteTransmissionData(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.TransmissionData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransmissionData.WriteTransmissionData(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.TransmissionData)`

#### Summary

Writes the given TransmissionData into the Revit file at the
given location.

#### Remarks

This function will overwrite the existing TransmissionData
in the file.

This function will not support models on Revit Server. References
may be to Revit Server, but the host model must be local.

This function must be called on a closed document.

This function cannot be used to convert a reference from
a local file to an external server.

#### Parameter `path`

A ModelPath indicating the file Revit should write
the TransmissionData of.
This ModelPath must be a file path and an absolute path.

#### Parameter `data`

The TransmissionData to be written into the document.
Note that Revit will not check that the ElementIds in
the TransmissionData correspond to real Elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

There is not a valid Revit file at path's location

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Operation is not valid for Revit Server models.
-or-
This function cannot be called on an opened document.

#### Since

2012

### `M:Autodesk.Revit.DB.TransmissionData.ReadTransmissionData(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransmissionData.ReadTransmissionData(Autodesk.Revit.DB.ModelPath)`

#### Summary

Reads the TransmissionData associated with the
file at the given location.

#### Remarks

The TransmissionData returned by this function contains
data about all ExternalFileReferences in the document.
ExternalResourceReferences to extenal servers will not
be returned by this function. TransmissionData contains
information about local or Revit Server references only.

#### Parameter `path`

A ModelPath indicating the file Revit should read
the TransmissionData of.
If this ModelPath is a file path, it must be an absolute path.

#### Returns

The TransmissionData containing external file
information for the file at the given location.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model are locked by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

The central model is missing.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

There is not a valid Revit file at path's location

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Since

2012

### `M:Autodesk.Revit.DB.TransmissionData.SetDesiredReferenceData(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.PathType,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransmissionData.SetDesiredReferenceData(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.PathType,System.Boolean)`

#### Summary

Sets the ExternalFileReference information which
Revit should use the next time it opens the document
which this TransmissionData belongs to.

#### Remarks

There must already be a reference associated with
the given id for this function to be valid. New
references cannot be created in a closed file.
See the documentation for a particular reference
type to see its creation API.

#### Parameter `elemId`

The id of the element associated with this reference.

#### Parameter `path`

A ModelPath indicating the location to load the external
file reference from.

#### Parameter `pathType`

A PathType value indicating what type of path the ModelPath is.

#### Parameter `shouldLoad`

True if the external file should be loaded the next time Revit
opens the document. False if it should be unloaded.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

elemId does not correspond to an ExternalFileReference
contained in this TransmissionData.
-or-
These inputs will not produce a valid ExternalFileReference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.TransmissionData.GetDesiredReferenceData(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransmissionData.GetDesiredReferenceData(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the ExternalFileReference representing path
and load status information to be used the next time
this TransmissionData's document is loaded.

#### Parameter `elemId`

The ElementId of the Element which the external file
reference is a component of.

#### Returns

An ExternalFileReference containing the requested
path and load status information for an external file

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

elemId does not correspond to an ExternalFileReference
contained in this TransmissionData.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.TransmissionData.GetLastSavedReferenceData(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransmissionData.GetLastSavedReferenceData(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the ExternalFileReference representing path
and load status information concerning the most
recent time this TransmissionData's document was opened.

#### Parameter `elemId`

The ElementId of the Element which the external file
reference is a component of.

#### Returns

An ExternalFileReference containing the previous
path and load status information for an external file

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

elemId does not correspond to an ExternalFileReference
contained in this TransmissionData.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.TransmissionData.GetAllExternalFileReferenceIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransmissionData.GetAllExternalFileReferenceIds`

#### Summary

Gets the ids of all ExternalFileReferences.

#### Returns

The ids of all ExternalFileReferences.

#### Since

2012

### `P:Autodesk.Revit.DB.TransmissionData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TransmissionData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TransmissionData.Version`

Member kind: property
Symbol: `Autodesk.Revit.DB.TransmissionData.Version`

#### Summary

The format version for TransmissionData

#### Since

2012

### `P:Autodesk.Revit.DB.TransmissionData.UserData`

Member kind: property
Symbol: `Autodesk.Revit.DB.TransmissionData.UserData`

#### Summary

A string which users can store notes in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.TransmissionData.IsTransmitted`

Member kind: property
Symbol: `Autodesk.Revit.DB.TransmissionData.IsTransmitted`

#### Summary

Determines whether this file has been transmitted or not.

#### Remarks

"Transmitted" files have been moved from one place to another and
are considered to be in a not-final state. Revit will read the
TransmissionData on file open and overwrite any data stored in the
external file reference elements themselves.

#### Since

2012

### `M:Autodesk.Revit.DB.TransmissionData.#ctor(Autodesk.Revit.DB.TransmissionData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransmissionData.#ctor(Autodesk.Revit.DB.TransmissionData)`

#### Summary

Constructs a TransmissionData from another TransmissionData

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.TransmissionData`

Member kind: type
Symbol: `Autodesk.Revit.DB.TransmissionData`

#### Summary

A class representing information on all external file references
in a document.

#### Remarks

TransmissionData stores information on both the previous state
and requested state of an external file reference.
This means that it stores the load state and path of the reference
from the most recent time this TransmissionData's document was opened.
It also stores load state and path information for what Revit should
do the next time the document is opened.

As such, TransmissionData can be used to perform operations on external
file references without having to open the entire associated Revit
document. The methods ReadTransmissionData and WriteTransmissionData
can be used to obtain information about external references, or to
change that information. For example, calling WriteTransmissionData
with a TransmissionData object which has had all references set to
LinkedFileStatus.Unloaded would cause no references to be loaded
upon next opening the document.

TransmissionData cannot add or remove references to
external files. If, on file open, Revit discovers information
in the TransmissionData which does not correspond to an
existing external file reference,
the information will be ignored on file load.

The TransmissionData for a document does not contain information
about references which come from external servers. TransmissionData only
contains references to local files or Revit links on Revit Server.
TransmissionData cannot
be used to change a reference from a local file reference to an external
server reference.

Note that TransmissionData objects must be set to "transmitted" for
the requested reference data to be meaningful. Revit ignores the
TransmissionData for non-transmitted files. Marking a file as
transmitted has other effects - workshared files are opened as
detached from the central model, and creation of new local files
is prohibited, until the file is in its final location and the
file has been marked as no longer transmitted.

#### Since

2012

### `M:Autodesk.Revit.DB.TransientGRepKeeper.AddToGRepKeeperForTransientDisplay(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransientGRepKeeper.AddToGRepKeeperForTransientDisplay(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.ElementId)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.TransientGRepKeeper.SetGRepKeeperForTransientDisplay(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransientGRepKeeper.SetGRepKeeperForTransientDisplay(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.ElementId)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.TransientGRepKeeper.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TransientGRepKeeper.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.TransientGRepKeeper`

Member kind: type
Symbol: `Autodesk.Revit.DB.TransientGRepKeeper`

#### Summary

Contains native implementations of setting transient element with GRep needed to be viewed in context of the model

#### Remarks

Contains native implementations of setting transient element with GRep needed to be viewed in context of the model
The internal API wrappers are called directly by the related public API methods.

### `M:Autodesk.Revit.DB.TransformWithBoundary.GetBoundary`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransformWithBoundary.GetBoundary`

#### Summary

Returns the boundary for the model space to view projection space transform.

#### Remarks

Before you transform a model point to view projection space using the transform returned by `M:Autodesk.Revit.DB.TransformWithBoundary.GetModelToProjectionTransform` ,
test to make sure the model point is visible through this 2D boundary. The model space to view projection space transform is only valid for points in 3D model
space that can be seen through the 2D boundary, when looking in the direction of `!:View.ViewDirection` .

The boundary is one enclosed region of the view's crop.

For uncropped views 'null' is returned.

For cropped views that do not have split crop regions, the boundary is the shape of the view crop. Typically the boundary is
rectangular, but more complex shapes are supported.

For cropped views that have split crop regions, the boundary is one rectangular region of the split view crop.

Even though the boundary represents the view crop - a 2D polygon drawn on the view's cut plane - any point in 3D model space
that can be seen through the boundary when looking in the direction of the view (see `!:View.ViewDirection` ) is considered
to be inside the boundary and can be transformed using the model space to view projection space transform returned by
`M:Autodesk.Revit.DB.TransformWithBoundary.GetModelToProjectionTransform` . For example, if the shape of the CurveLoop is a circle, then there is an infinite
cylinder in 3D model space and any point inside that cylinder can be transformed with the model space to view projection space transform.

To test if a point in 3D model space is within the boundary, first project the point and the CurveLoop onto a
plane which is perpendicular to the view direction. Then use a point-in-polygon algorithm to check if the projected
point is inside the polygon described by the CurveLoop.

It is guaranteed that the boundary CurveLoop lies on a plane which is perpendicular to `!:View.ViewDirection` and
that the CurveLoop does not self-intersect and is closed. It is also guaranteed that the boundaries of different
TransformWithBoundary regions of the same view don't overlap with each other.

#### Returns

A closed loop in model space representing the region of model space to which the model space to view projection space transform applies.

#### Since

2023

### `M:Autodesk.Revit.DB.TransformWithBoundary.GetModelToProjectionTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransformWithBoundary.GetModelToProjectionTransform`

#### Summary

Gets the model space to view projection space transform.

#### Remarks

The transform can be used to transform points from model space to view projection space.

Model space is the global 3D coordinate space in which the 3D geometry of the model lives.

View projection space is the 3D Euclidean space with a coordinate system such that
X and Y are horizontal and vertical directions in the view projection plane and Z
is the cross product of X and Y. Distances in the projection space are the same as
would be measured on paper if the view is printed without additional scaling.

For uncropped views all model space points can be transformed to projection space using
the this transform.

For cropped views only model points which lie inside the boundary returned by `M:Autodesk.Revit.DB.TransformWithBoundary.GetBoundary`
should be transformed to projection space using this transform.

#### Returns

The model space to view projection space transformation.

#### Since

2023

### `P:Autodesk.Revit.DB.TransformWithBoundary.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TransformWithBoundary.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.TransformWithBoundary.#ctor(Autodesk.Revit.DB.TransformWithBoundary)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransformWithBoundary.#ctor(Autodesk.Revit.DB.TransformWithBoundary)`

#### Summary

Constructs a new copy of the input TransformWithBoundary object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `T:Autodesk.Revit.DB.TransformWithBoundary`

Member kind: type
Symbol: `Autodesk.Revit.DB.TransformWithBoundary`

#### Summary

This class contains the transform from model space to projection space for a view and the
boundary in model space in which the transform is valid.

#### Remarks

Use the model-to-projection transform returned by `M:Autodesk.Revit.DB.TransformWithBoundary.GetModelToProjectionTransform` to transform model points to
the view's projection space. The model-to-projection transform is only valid for points in 3D model space that that can be seen
through the 2D boundary returned by `M:Autodesk.Revit.DB.TransformWithBoundary.GetBoundary` , when looking in the direction of `!:View.ViewDirection` .

For views that are placed on sheets, you can combine the View's model-to-projection transform and the Viewport's
projection-to-sheet transform to transform model points to sheet space:

sheetXYZ = projectionToSheetTransform * modelToProjectionTransform * modelXYZ

Model space is the global 3D coordinate space in which the 3D geometry of the model lives.

View projection space is the 3D Euclidean space with a coordinate system such that
X and Y are horizontal and vertical directions in the view projection plane and Z
is the cross product of X and Y. Distances in the projection space are the same as
would be measured on paper if the view is printed without additional scaling.

Sheet space is the coordinate space of one sheet. This is the space in which viewports and
titleblocks are arranged on the sheet.

#### Since

2021

### `M:Autodesk.Revit.DB.TransactionGroup.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactionGroup.GetName`

#### Summary

Returns the transaction group's name. It could be an empty string.

#### Returns

The transaction group's current name.

#### Since

2011

### `M:Autodesk.Revit.DB.TransactionGroup.SetName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactionGroup.SetName(System.String)`

#### Summary

Sets the transaction group's name.

#### Remarks

Transaction group only needs a name if it is going to be assimilated at the end.

#### Parameter `name`

A name for the transaction group.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.TransactionGroup.HasEnded`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactionGroup.HasEnded`

#### Summary

Determines whether the transaction group has ended already.

#### Remarks

A transaction is ended by completing either the `M:Autodesk.Revit.DB.TransactionGroup.Commit`
or `M:Autodesk.Revit.DB.TransactionGroup.RollBack` or `M:Autodesk.Revit.DB.TransactionGroup.Assimilate` method.
Another way of testing whether a transaction group has ended is by testing
its current status returned from (see `M:Autodesk.Revit.DB.TransactionGroup.GetStatus` ). It must be either
'TransactionStatus.Committed' or 'TransactionStatus.RolledBack'

#### Returns

True if the transaction group has already been committed or rolled back, False otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.TransactionGroup.HasStarted`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactionGroup.HasStarted`

#### Summary

Determines whether the transaction has been started yet.

#### Remarks

A transaction group is considered being started after the `M:Autodesk.Revit.DB.TransactionGroup.Start`
method was called and until the transaction group is either completely committed
or rolled back. A transaction group can only be Started when HasStarted returns false.

#### Returns

True if the transaction group has already started, False otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.TransactionGroup.GetStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactionGroup.GetStatus`

#### Summary

Gets the current status of the transaction group.

#### Returns

The current status of the transaction group.

#### Since

2011

### `M:Autodesk.Revit.DB.TransactionGroup.RollBack`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactionGroup.RollBack`

#### Summary

Rolls back the transaction group, which effectively undoes all transactions committed inside the group.

#### Remarks

Note that once a group is rolled back, the undone transactions cannot be redone.

RollBack can be called only when all inner transaction groups and transactions are finished,
i.e. after they were either committed or rolled back.

#### Returns

If finished successfully, this method returns TransactionStatus.RolledBack.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Transaction group has not been started (its status is not 'Started')..
-or-
The transaction's document is currently in failure mode.
Transaction groups cannot be closed until failure handling is finished.
You may use a transaction finalizer to close a group after the failure handling ends.

#### Since

2011

### `M:Autodesk.Revit.DB.TransactionGroup.Assimilate`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactionGroup.Assimilate`

#### Summary

Assimilates all inner transactions by merging them into a single undo item.

#### Remarks

After a successful assimilation the transaction group is committed.

All transactions committed inside this group will be merged into one
single transaction. The resulting undo item will bear this group's name.

Assimilate can be called only when all inner transaction groups and transactions
are finished, i.e. after they were either committed or rolled back.

#### Returns

If finished successfully, this method returns TransactionStatus.Committed.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Transaction group has not been started (its status is not 'Started')..
-or-
The transaction's document is currently in failure mode.
Transaction groups cannot be closed until failure handling is finished.
You may use a transaction finalizer to close a group after the failure handling ends.

#### Since

2011

### `M:Autodesk.Revit.DB.TransactionGroup.Commit`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactionGroup.Commit`

#### Summary

Commits the transaction group.

#### Remarks

Committing a group does not change the model.
It only confirms the commitment of all inner groups and transactions.

Commit can be called only when all inner transaction groups and transactions are finished,
i.e. after they were either committed or rolled back. If there is still a transaction or an inner
transaction group open, an attempt to commit this outer group will cause an exception.

#### Returns

If finished successfully, this method returns TransactionStatus.Committed.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Transaction group has not been started (its status is not 'Started')..
-or-
The transaction's document is currently in failure mode.
Transaction groups cannot be closed until failure handling is finished.
You may use a transaction finalizer to close a group after the failure handling ends.

#### Since

2011

### `M:Autodesk.Revit.DB.TransactionGroup.Start(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactionGroup.Start(System.String)`

#### Summary

Starts the transaction group with an assigned name.

#### Remarks

A transaction group can be started only when there is no transaction started currently.
It can be started inside another transaction group though. With such group nesting
it is required that inner transaction groups are finished (i.e. rolled back, committed,
or assimilated) before outer groups are.

#### Parameter `transGroupName`

Name of the group.
The name will be used only for a group that is `M:Autodesk.Revit.DB.TransactionGroup.Assimilate` at the end.

#### Returns

If started successfully, this method returns TransactionStatus.Started.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot modify the document for either a read-only external command is being executed, or changes to the document are temporarily disabled.
-or-
Transaction group cannot be started during an active transaction.
-or-
The Transaction group has already been started.

#### Since

2011

### `M:Autodesk.Revit.DB.TransactionGroup.Start`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactionGroup.Start`

#### Summary

Starts the transaction group

#### Remarks

A transaction group can be started only when there is no transaction started currently.
It can be started inside another transaction group. When groups are nested inside each other
it is required that inner transaction groups are finished (i.e. rolled back, committed,
or assimilated) before outer groups are.

#### Returns

If started successfully, this method returns TransactionStatus.Started.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot modify the document for either a read-only external command is being executed, or changes to the document are temporarily disabled.
-or-
Transaction group cannot be started during an active transaction.
-or-
The Transaction group has already been started.

#### Since

2011

### `P:Autodesk.Revit.DB.TransactionGroup.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TransactionGroup.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TransactionGroup.IsFailureHandlingForcedModal`

Member kind: property
Symbol: `Autodesk.Revit.DB.TransactionGroup.IsFailureHandlingForcedModal`

#### Summary

Forces all transactions finished inside this group to use modal failure handling
regardless of what failure handling options are set for those transactions.

#### Remarks

This property is ignored during events, when failure handling is always modal.

#### Since

2013

### `M:Autodesk.Revit.DB.TransactionGroup.#ctor(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactionGroup.#ctor(Autodesk.Revit.DB.Document,System.String)`

#### Summary

It constructs a transaction group object

#### Remarks

The group does not start until its Start method is called.

#### Parameter `document`

The document for which this transaction group is being used.

#### Parameter `transGroupName`

Name of the group.
The name will be used only for a group that is `M:Autodesk.Revit.DB.TransactionGroup.Assimilate` at the end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.TransactionGroup.#ctor(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactionGroup.#ctor(Autodesk.Revit.DB.Document)`

#### Summary

Constructs a transaction group object.

#### Remarks

The group does not start until its Start method is called.

#### Parameter `document`

The document for which this transaction group is being used.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.TransactionGroup`

Member kind: type
Symbol: `Autodesk.Revit.DB.TransactionGroup`

#### Summary

Transaction groups aggregate a number of transactions.

#### Remarks

A transaction group controls whether transactions committed inside the group should
stay committed or should be all discarded. If the group is committed, all the transactions
remain committed, but if the transaction group is rolled back instead, all the inner,
already committed transactions will be undone (and removed).

There are two ways of committing a group - Commit and Assimilate. By committing,
all transactions committed inside a group stay as they are, while by assimilating,
all inner transactions will be merged into a single transaction.

A transaction group can only be started when no transaction is active,
and must be closed only after the last transaction started inside the group is finished,
i.e. after it was either committed or rolled back.

Transaction groups may be nested inside each other with the restriction
that every nested transaction group is entirely contained (opened and closed)
in the parent transaction group.

If a transaction group was started and not finished yet by the time the TransactionGroup object
is about to be, the default destructor will roll it back automatically, thus all
changes made to the document while this transaction group was open will be discarded.
It is not recommended to rely on this default behavior though. Instead, it is advised
to always call either `M:Autodesk.Revit.DB.TransactionGroup.Commit` , `M:Autodesk.Revit.DB.TransactionGroup.RollBack` ,
or `M:Autodesk.Revit.DB.TransactionGroup.Assimilate` explicitly before the group object gets destroyed.
Please note that unless invoked explicitly the actual destruction of an object
in managed code might not happen until the object is collected by the garbage collector.

#### Since

2011

### `M:Autodesk.Revit.DB.ToposolidType.GetContourSetting`

Member kind: method
Symbol: `Autodesk.Revit.DB.ToposolidType.GetContourSetting`

#### Summary

Get the contour setting object from the current toposolid type.

#### Returns

The contour setting object.

#### Since

2024

### `T:Autodesk.Revit.DB.ToposolidType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ToposolidType`

#### Summary

An object that specifies the type of a Toposolid in Autodesk Revit.

#### Since

2024

### `M:Autodesk.Revit.DB.Toposolid.Simplify(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Toposolid.Simplify(System.Double)`

#### Summary

Simplifies the toposolid by reducing the number of inner vertices to the given percentage.

#### Remarks

At low percentages, the inner vertices may not be reduced to the exact percentage to keep a rough semblance of the original shape.
Call this method again if you want to keep removing inner vertices.

#### Parameter `percentage`

The ratio of the number of inner vertices after simplify to the original number.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input percentage should be greater than 0 and less than 1.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

this operation failed.

#### Since

2024

### `M:Autodesk.Revit.DB.Toposolid.Split(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Toposolid.Split(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Split the toposolid by the given curve loops.

#### Parameter `splitCurveLoops`

An array of planar curve loops that are used to split the toposolid.
All of the curve loops should lie on the sketch plane of the toposolid.

#### Returns

An array of newly created toposolid ids after split.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The split curve loops should all lie on the sketch plane of the toposolid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Toposolid.GetSubDivisionIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Toposolid.GetSubDivisionIds`

#### Summary

Get all element ids of toposolid subdivisions with the current toposolid as its host.

#### Returns

The array of toposolid subdivision ids.

#### Since

2024

### `M:Autodesk.Revit.DB.Toposolid.CreateSubDivision(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Toposolid.CreateSubDivision(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Create a toposolid subdivision element with the current toposolid as its host.

#### Parameter `document`

The document in which the new toposolid is created.

#### Parameter `profiles`

An array of planar curve loops that represent the profiles of the toposolid.

#### Returns

The toposolid subdivision object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve loops cannot compose a valid boundary, that means:
the "curveLoops" collection is empty;
or some curve loops intersect with each other;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the horizontal(XY) plane;
or input curves contain at least one helical curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Toposolid.GetSlabShapeEditor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Toposolid.GetSlabShapeEditor`

#### Summary

Gets a SlabShapeEditor that can be used to add or modify points of this Toposolid.

#### Returns

The SlabShapeEditor object

#### Since

2024

### `M:Autodesk.Revit.DB.Toposolid.CreateFromTopographySurface(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Toposolid.CreateFromTopographySurface(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a toposolid element from a host TopographySurface, and toposolid sub-divisions from its subregions.

#### Parameter `document`

The document in which the new toposolid is created.

#### Parameter `hostSurfaceId`

Id of the host TopogarphySurface element.

#### Parameter `topoTypeId`

Id of the toposolid type to be used by the new toposolid.

#### Parameter `levelId`

Id of the level on which the toposolid is to be placed.

#### Returns

A new toposolid object within the project if successful.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Toposolid.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Toposolid.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of toposolid within the project.

#### Parameter `document`

The document in which the new toposolid is created.

#### Parameter `profiles`

An array of planar curve loops that represent the profiles of the toposolid.

#### Parameter `points`

An array of points that used to construct the top face of the toposolid.

#### Parameter `topoTypeId`

Id of the toposolid type to be used by the new toposolid.

#### Parameter `levelId`

Id of the level on which the toposolid is to be placed.

#### Returns

A new toposolid object within the project if successful.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve loops cannot compose a valid boundary, that means:
the "curveLoops" collection is empty;
or some curve loops intersect with each other;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the horizontal(XY) plane;
or input curves contain at least one helical curve.
-or-
The input point array size is less than 3.
-or-
The ElementId levelId is not a Level.
-or-
Toposolid type is not valid for this toposolid.
-or-
Input curves build invalid sketch.
-or-
Failed to create curve elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot generate a sketch.
-or-
Failed to create new element.

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

2024

### `M:Autodesk.Revit.DB.Toposolid.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Toposolid.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of toposolid within the project.

#### Parameter `document`

The document in which the new toposolid is created.

#### Parameter `points`

An array of points that used to construct the top face of the toposolid.

#### Parameter `topoTypeId`

Id of the toposolid type to be used by the new toposolid.

#### Parameter `levelId`

Id of the level on which the toposolid is to be placed.

#### Returns

A new toposolid object within the project if successful.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input point array size is less than 3.
-or-
The ElementId levelId is not a Level.
-or-
Toposolid type is not valid for this toposolid.
-or-
Input curves build invalid sketch.
-or-
Failed to create curve elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot generate a sketch.
-or-
Failed to create new element.

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

2024

### `M:Autodesk.Revit.DB.Toposolid.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Toposolid.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of toposolid within the project.

#### Parameter `document`

The document in which the new toposolid is created.

#### Parameter `profiles`

An array of planar curve loops that represent the profiles of the toposolid.

#### Parameter `topoTypeId`

Id of the toposolid type to be used by the new toposolid.

#### Parameter `levelId`

Id of the level on which the toposolid is to be placed.

#### Returns

A new toposolid object within the project if successful.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve loops cannot compose a valid boundary, that means:
the "curveLoops" collection is empty;
or some curve loops intersect with each other;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the horizontal(XY) plane;
or input curves contain at least one helical curve.
-or-
The ElementId levelId is not a Level.
-or-
Toposolid type is not valid for this toposolid.
-or-
Input curves build invalid sketch.
-or-
Failed to create curve elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot generate a sketch.
-or-
Failed to create new element.

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

2024

### `P:Autodesk.Revit.DB.Toposolid.SketchId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Toposolid.SketchId`

#### Summary

Returns id of the sketch.

#### Since

2024

### `P:Autodesk.Revit.DB.Toposolid.HostTopoId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Toposolid.HostTopoId`

#### Summary

The host toposolid id of the current toposolid subdivision.
If the object is not a toposolid subdivision, hostTopoId will be InvalidElementId.

#### Since

2024

### `T:Autodesk.Revit.DB.Toposolid`

Member kind: type
Symbol: `Autodesk.Revit.DB.Toposolid`

#### Summary

An object that represents a Toposolid within the Autodesk Revit project.

#### Since

2024

### `M:Autodesk.Revit.DB.Architecture.ToposurfaceData.GetIdentifier`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.ToposurfaceData.GetIdentifier`

#### Summary

Gets the unique identifier of the Toposurface.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.ToposurfaceData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ToposurfaceData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.ToposurfaceData.#ctor(System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Collections.Generic.IList{System.Int32}})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.ToposurfaceData.#ctor(System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Collections.Generic.IList{System.Int32}})`

#### Summary

Creates a new ToposurfaceData class.

#### Parameter `name`

The surface name.

#### Parameter `points`

The surface points.

#### Parameter `facets`

The surface facets.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `T:Autodesk.Revit.DB.Architecture.ToposurfaceData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.ToposurfaceData`

#### Summary

Represents a Toposurface's data.

#### Remarks

The data of Toposurface includes name, points, facets, etc.

#### Since

2019

### `M:Autodesk.Revit.DB.Architecture.TopographyLinkType.UpdateFileSize(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLinkType.UpdateFileSize(System.Double)`

#### Summary

updates the file size

#### Since

2019.2

### `M:Autodesk.Revit.DB.Architecture.TopographyLinkType.UpdateToposurfaceDataIfNecessary(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLinkType.UpdateToposurfaceDataIfNecessary(System.Boolean)`

#### Summary

Updates the external transform and toposurface data for topography link type if the original geometry is far away from the origin.

#### Remarks

If the original geometry is farther away from the origin, it should be translated/transformed and the transform should be saved in the TopographyLinkType using this method. This ensures correct reporting of shared coordinates.

#### Parameter `useOldExternalTrans`

Use the old transform

#### Since

2019.2

### `M:Autodesk.Revit.DB.Architecture.TopographyLinkType.SetSurfacesData(System.Collections.Generic.IList{Autodesk.Revit.DB.Architecture.ToposurfaceData})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLinkType.SetSurfacesData(System.Collections.Generic.IList{Autodesk.Revit.DB.Architecture.ToposurfaceData})`

#### Summary

Sets the surfaces' data.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019.2

### `M:Autodesk.Revit.DB.Architecture.TopographyLinkType.ReloadInternal(System.String,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLinkType.ReloadInternal(System.String,System.Boolean)`

#### Summary

Reloads the link from curently-stored location.

#### Parameter `path`

The path of the link file.

#### Parameter `isFromAPI`

True if this method is called by API, otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to reload the type.

#### Since

2019.2

### `M:Autodesk.Revit.DB.Architecture.TopographyLinkType.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.LinkLoadResult@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLinkType.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.LinkLoadResult@)`

#### Summary

Creates a new Topography link type.

#### Parameter `aDoc`

The document in which to create the Topography Link.

#### Parameter `linkFilePath`

The path of the link file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

aDoc is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

Fail to access the link file.

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

2019.2

### `M:Autodesk.Revit.DB.Architecture.TopographyLinkType.Reload`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLinkType.Reload`

#### Summary

Loads or reloads the link from its currently-stored location. If the link is an
external resource, Revit will contact the IExternalResourceServer to get the latest version
of the link.

#### Returns

An object containing the ElementId of the link
and an enum value indicating any
errors which occurred while trying to load.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The element "this TopographyLinkType" is in a read-only document.

#### Since

2019.2

### `T:Autodesk.Revit.DB.Architecture.TopographyLinkType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLinkType`

#### Summary

This class represents the site file brought into the current Revit document.

#### Since

2019.2

### `M:Autodesk.Revit.DB.Architecture.TopographyLink.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Architecture.TopographyLinkLoadOption,System.Collections.Generic.IList{System.String}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLink.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Architecture.TopographyLinkLoadOption,System.Collections.Generic.IList{System.String}@)`

#### Summary

Creates a new instance of a topography link element within the project.

#### Parameter `document`

The document in which the new instance should be created.

#### Parameter `topographyLinkTypeId`

The element id of the TopographyLink type.

#### Parameter `options`

Options used to create members of the topography link

#### Parameter `invalidSurfaces`

Return the invalid surface names

#### Returns

The newly created topography link.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create new SiteSurface.

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

2019

### `T:Autodesk.Revit.DB.Architecture.TopographyLink`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLink`

#### Summary

Represents a TopographyLink element.

#### Since

2019

### `M:Autodesk.Revit.DB.Architecture.TopographyEditScope.Start(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographyEditScope.Start(Autodesk.Revit.DB.ElementId)`

#### Summary

Starts a topography surface edit mode for an existing TopographySurface element.

#### Remarks

The application will need to start a transaction to actually make changes to the TopographySurface element.
TopographyEditScope can only be started when there is no transaction active, thus it does not
work for commands running in automatic transaction mode.
Like all Start methods in any edit scope object this too returns an Id of the element in the edit session,
even though in this case here it always equals to the given topoSurfaceId.

#### Parameter `topoSurfaceId`

The TopographySurface element to be edited.

#### Returns

The Id of the topography Surface being edited.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId topoSurfaceId does not represent a TopographySurface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This TopographyEditScope is not permitted to start at this moment for one of the following possible reasons:
The document is in read-only state, or the document is currently modifiable,
or there already is another edit mode active in the document.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographyEditScope.#ctor(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographyEditScope.#ctor(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Instantiates a TopographyEditScope object.

#### Parameter `document`

The document for which this TopographyEditScope is going to be used.

#### Parameter `transactionName`

The name that will appear in the Undo menu in Revit after the TopographyEditScope is successfully committed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a primary document, it is a linked document.
-or-
document is not a project document.
-or-
transactionName is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.Architecture.TopographyEditScope`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.TopographyEditScope`

#### Summary

A TopographyEditScope allows an application to create and maintain an editing session for a TopographySurface.

#### Remarks

Start/end of a TopographyEditScope will start/end a transaction group. After a TopographyEditScope is started, an application can start transactions and edit the topography surface.
Individual transactions the application creates inside TopographyEditScope will not appear in the undo menu.
All transactions committed during the edit mode will be merged into a single one which will bear the given name passed into TopographyEditScope constructor.

#### Since

2014

### `P:Autodesk.Revit.DB.Visual.Tile.TextureVRepeat`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TextureVRepeat`

#### Summary

The property labeled "V Repeat" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TextureURepeat`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TextureURepeat`

#### Summary

The property labeled "U Repeat" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TextureScaleLock`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TextureScaleLock`

#### Summary

The property labeled "Scale Lock" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TextureRealWorldScaleY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TextureRealWorldScaleY`

#### Summary

The property labeled "Size Y" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDistance" with a minimum of "0.01".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TextureRealWorldScaleX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TextureRealWorldScaleX`

#### Summary

The property labeled "Size X" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDistance" with a minimum of "0.01".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TextureWAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TextureWAngle`

#### Summary

The property labeled "Angle" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 360".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TextureOffsetLock`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TextureOffsetLock`

#### Summary

The property labeled "Offset Lock" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TextureRealWorldOffsetY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TextureRealWorldOffsetY`

#### Summary

The property labeled "Offset Y" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TextureRealWorldOffsetX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TextureRealWorldOffsetX`

#### Summary

The property labeled "Offset X" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TextureLinkTextureTransforms`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TextureLinkTextureTransforms`

#### Summary

The property labeled "Link Transforms" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileChangeColumn`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileChangeColumn`

#### Summary

The property labeled "Amount" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 5".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TilePerColumn`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TilePerColumn`

#### Summary

The property labeled "Every" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyInteger" within the range of "0, 50".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileUseColumnEdit`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileUseColumnEdit`

#### Summary

The property labeled "Column Modify" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileChangeRow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileChangeRow`

#### Summary

The property labeled "Amount" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 5".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TilePerRow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TilePerRow`

#### Summary

The property labeled "Every" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyInteger" within the range of "0, 50".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileUseRowEdit`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileUseRowEdit`

#### Summary

The property labeled "Row Modify" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileRandomShift`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileRandomShift`

#### Summary

The property labeled "Random" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 100".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileLineShift`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileLineShift`

#### Summary

The property labeled "Line Shift" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 100".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileEdgeRoughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileEdgeRoughness`

#### Summary

The property labeled "Roughness" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 200".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileVerticalGap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileVerticalGap`

#### Summary

The property labeled "Vert" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 100".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileHorizontalGap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileHorizontalGap`

#### Summary

The property labeled "Gap Width" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 100".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileMortarColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileMortarColor`

#### Summary

The property labeled "Grout Color" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileRandomSeed`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileRandomSeed`

#### Summary

The property labeled "Randomize" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with a minimum of "0".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileFadeVariance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileFadeVariance`

#### Summary

The property labeled "Fade Variance" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 100".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileColorVariance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileColorVariance`

#### Summary

The property labeled "Color Variance" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 100".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileBrickColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileBrickColor`

#### Summary

The property labeled "Tile Color" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileVerticalCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileVerticalCount`

#### Summary

The property labeled "tile_VerticalCount" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 100".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileHorizontalCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileHorizontalCount`

#### Summary

The property labeled "Tile Count" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 100".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Tile.TileBrickType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Tile.TileBrickType`

#### Summary

The property labeled "Type" from the "Tile" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "TileBrickType".

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Tile`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Tile`

#### Summary

A static class that provides access to the property names that appear in the Tile visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.ThermalAsset.EqualsThermalOnly(Autodesk.Revit.DB.ThermalAsset)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ThermalAsset.EqualsThermalOnly(Autodesk.Revit.DB.ThermalAsset)`

#### Summary

Determines whether this thermal asset is equal to another, but ignore data from base class.

#### Parameter `other`

The thermal asset to compare with this one.

#### Returns

True if the given thermal asset is equal to this one, otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ThermalAsset.Equals(Autodesk.Revit.DB.ThermalAsset)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ThermalAsset.Equals(Autodesk.Revit.DB.ThermalAsset)`

#### Summary

Determines whether this thermal asset is equal to another.

#### Parameter `other`

The thermal asset to compare with this one.

#### Returns

True if the given thermal asset is equal to this one, otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ThermalAsset.Copy`

Member kind: method
Symbol: `Autodesk.Revit.DB.ThermalAsset.Copy`

#### Summary

Produces a copy of the asset.

#### Returns

A copy of the asset.

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ThermalAsset.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.Name`

#### Summary

The name of the thermal asset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.Behavior`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.Behavior`

#### Summary

Flag indicating whether elements of this material behave isotropically or orthotropically.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.ThermalConductivity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.ThermalConductivity`

#### Summary

The thermal conductivity of the asset.

#### Remarks

Values are in feet-kilograms per Kelvin-cubed-second ((ft Â· kg)/(K Â· sÂ³)) and must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for thermalConductivity must be non-negative.

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.Density`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.Density`

#### Summary

The density of the asset.

#### Remarks

Values are in kilograms per cubed feet (kg/ftÂ³) and must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for density must be non-negative.

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.ElectricalResistivity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.ElectricalResistivity`

#### Summary

The electrical resistivity of the asset.

#### Remarks

Values are in ohm-meters and must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for electricalResistivity must be non-negative.

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.Reflectivity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.Reflectivity`

#### Summary

The reflectivity of the asset.

#### Remarks

Values must be in the range 0 to 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for reflectivity is out of range

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.Porosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.Porosity`

#### Summary

The porosity of the asset.

#### Remarks

Values must be in the range 0 to 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for porosity is out of range

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.Permeability`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.Permeability`

#### Summary

The permeability of the asset.

#### Remarks

Values are in seconds per foot (s/ft) and must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for permeability must be non-negative.

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.TransmitsLight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.TransmitsLight`

#### Summary

A boolean flag that indicates whether or not the asset transmits light.

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.VaporPressure`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.VaporPressure`

#### Summary

The vapor pressure of the asset.

#### Remarks

Values are in kilograms per feet, squared-second (kg/(ft Â· sÂ²)) and must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for vaporPressure must be non-negative.

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.SpecificHeat`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.SpecificHeat`

#### Summary

The specific heat of the asset.

#### Remarks

Values are in squared-feet per Kelvin, squared-second (ftÂ²/(K Â· sÂ²)) and must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for specificHeat must be non-negative.

#### Since

2014

### `P:Autodesk.Revit.DB.ThermalAsset.SpecificHeatOfVaporization`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.SpecificHeatOfVaporization`

#### Summary

The specific heat of vaporization of the asset.

#### Remarks

Values are in feet per squared-second (ft/sÂ²) and must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for specificHeatOfVaporization must be non-negative.

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.LiquidViscosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.LiquidViscosity`

#### Summary

The liquid viscosity of the asset.

#### Remarks

Values are in kilograms per feet-second (kg/(ft Â· s)) and must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for liquidViscosity must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the asset must be liquid to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.Compressibility`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.Compressibility`

#### Summary

The compressibility of the asset.

#### Remarks

Values must be in the range 0 to 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for compressibility is out of range

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.GasViscosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.GasViscosity`

#### Summary

The gas viscosity of the asset.

#### Remarks

Values are in kilograms per feet-second (kg/(ft Â· s)) and must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for gasViscosity must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the asset must be gas to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.Emissivity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.Emissivity`

#### Summary

The emissivity of the asset.

#### Remarks

Values must be in the range 0 to 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for emissivity is out of range

#### Since

2013

### `P:Autodesk.Revit.DB.ThermalAsset.ThermalMaterialType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ThermalAsset.ThermalMaterialType`

#### Summary

The type of material that this thermal asset describes (e.g. solid, liquid, gas.)

#### Since

2013

### `M:Autodesk.Revit.DB.ThermalAsset.#ctor(System.String,Autodesk.Revit.DB.ThermalMaterialType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ThermalAsset.#ctor(System.String,Autodesk.Revit.DB.ThermalMaterialType)`

#### Summary

Constructs an instance of ThermalAsset.

#### Parameter `name`

The name of the asset.

#### Parameter `materialType`

The type of thermal material that this asset will describe.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `T:Autodesk.Revit.DB.ThermalAsset`

Member kind: type
Symbol: `Autodesk.Revit.DB.ThermalAsset`

#### Summary

Represents the properties of a material pertinent to energy analysis.

#### Since

2013

### `T:Autodesk.Revit.DB.ThermalMaterialType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ThermalMaterialType`

#### Since

2013

#### Summary

Represents the thermal material type.

#### Since

2013

### `F:Autodesk.Revit.DB.ThermalMaterialType.Solid`

Member kind: field
Symbol: `Autodesk.Revit.DB.ThermalMaterialType.Solid`

#### Summary

Thermal material type is solid.

### `F:Autodesk.Revit.DB.ThermalMaterialType.Liquid`

Member kind: field
Symbol: `Autodesk.Revit.DB.ThermalMaterialType.Liquid`

#### Summary

Thermal material type is liquid.

### `F:Autodesk.Revit.DB.ThermalMaterialType.Gas`

Member kind: field
Symbol: `Autodesk.Revit.DB.ThermalMaterialType.Gas`

#### Summary

Thermal material type is gas.

### `F:Autodesk.Revit.DB.ThermalMaterialType.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.ThermalMaterialType.Undefined`

#### Summary

Thermal material type is undefined.

### `M:Autodesk.Revit.DB.TextNote.SetFormattedText(Autodesk.Revit.DB.FormattedText)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextNote.SetFormattedText(Autodesk.Revit.DB.FormattedText)`

#### Summary

Sets the text and associated formatting of the text of in this text note with
a given FormattedText object.

#### Parameter `formattedText`

The FormattedText object containing the text and associated formatting of the text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.TextNote.GetFormattedText`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextNote.GetFormattedText`

#### Summary

Returns an object that contains text and associated formatting of this note.

#### Remarks

The returned object is not attached to the text note and modifying it will not modify the contents of the text note.
After changes are made to the FormattedText, use `M:Autodesk.Revit.DB.TextNote.SetFormattedText(Autodesk.Revit.DB.FormattedText)`
apply those changes to the TextNote.

#### Returns

The object that contains the text and associated formatting of of the text in this text note.

#### Since

2017

### `M:Autodesk.Revit.DB.TextNote.RemoveLeaders`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextNote.RemoveLeaders`

#### Summary

Removes all leaders currently attached to the text note.

### `M:Autodesk.Revit.DB.TextNote.AddLeader(Autodesk.Revit.DB.TextNoteLeaderTypes)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextNote.AddLeader(Autodesk.Revit.DB.TextNoteLeaderTypes)`

#### Summary

Adds a leader to the text note.

#### Remarks

If the geometric type of the new leader (line vs arc.) differs
from the type of existing leaders, then the type of the existing
leaders will be changed to match the type of the newly created leader.

#### Parameter `leaderType`

Type of the leader being added.

#### Returns

The newly added leader.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.TextNote.GetLeaders`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextNote.GetLeaders`

#### Summary

Returns a collection of leaders currently attached to the text note.

#### Remarks

This method supersedes an older Leaders property which has been deprecated.

#### Since

2016

### `M:Autodesk.Revit.DB.TextNote.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Double,System.String,Autodesk.Revit.DB.TextNoteOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextNote.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Double,System.String,Autodesk.Revit.DB.TextNoteOptions)`

#### Summary

Creates a new line-wrapping text note element of the given width and properties.

#### Remarks

As a view-specific element the text note will be visible only in the specified view.

The new text note will be created using the give text type, which defines the style.
The currently default style can be obtained from the Document.GetDefaultElementTypeId method.

#### Parameter `document`

A valid Revit document that is currently modifiable (i.e. with an open transaction).

#### Parameter `viewId`

Id of the graphic view in which the note is to be created.

#### Parameter `position`

A model position of the new note.

Note that the position's relation to the text's bounding box depends on the requested text alignment
(set via the Options argument). It will be the box' top-left corner for a left-aligned text,
the top-right corner for a right-aligned text, and middle-top point if the text is to be centered.

#### Parameter `width`

Width [ft] of the text in paper space (i.e. as it is measured when printed.)
If a line of text is longer than the given specified Width, the text will be automatically wrapped.
If a a zero Width is supplied then this method will create an unwrapped text note element.

#### Parameter `text`

Text to populate the text note with.

#### Parameter `options`

Options to control behavior and appearance of the text note.

#### Returns

The newly created text note.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document is a family that cannot contain text notes.
-or-
The viewId does not represent a valid graphic view element in the given document.
-or-
The options structure does not contain a valid text type to use for a new text note in the given document.
-or-
A valid point must not be father then 10 miles (approx. 16 km) from the origin.
-or-
The given width is not valid. A valid value must be within the range
returned by static methods GetMinimumWidthLimit and GetMaximumWidthLimit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.TextNote.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Double,System.String,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextNote.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Double,System.String,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new line-wrapping text note element of the given width and properties.

#### Remarks

As a view-specific element the text note will be visible only in the specified view.

The new text note will be created using the given text type, which defines the style.
The currently default style can be obtained from the Document.GetDefaultElementTypeId method.

#### Parameter `document`

A valid Revit document that is currently modifiable (i.e. with an open transaction).

#### Parameter `viewId`

Id of the graphic view in which the note is to be created.

#### Parameter `position`

A model position of the new note.

For a left-aligned text (default), the origin is set at the top-left corner of the note's bounding box.

#### Parameter `width`

Width [ft] of the text in paper space (i.e. as it is measured when printed.)
If a line of text is longer than the specified Width, the text will be automatically wrapped.
If a a zero Width is supplied then this method will create an unwrapped text note element.

#### Parameter `text`

Text to populate the text note with.

#### Parameter `typeId`

Id of the text type to use for the new text note.
The text type allows its font name parameter to be set to a font unavailable on the current system.
However, any text note created with or set to this font type will be displayed in a default substituted font (e.g. Arial)
and the UI will show a blank value in the text type font name parameter.
Once the document is opened on a system which has the font set on the text type,
the text note will display with that font and the UI will show that font in the text type font name parameter.

#### Returns

The newly created text note.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document is a family that cannot contain text notes.
-or-
The viewId does not represent a valid graphic view element in the given document.
-or-
The typeId does not represent a valid text type in the given document.
-or-
A valid point must not be father then 10 miles (approx. 16 km) from the origin.
-or-
The given width is not valid. A valid value must be within the range
returned by the static methods GetMinimumAllowedWidth and GetMaximumAllowedWidth.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.TextNote.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.String,Autodesk.Revit.DB.TextNoteOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextNote.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.String,Autodesk.Revit.DB.TextNoteOptions)`

#### Summary

Creates a new unwrapped text note element with the given properties.

#### Remarks

The new text note will consist of a single line of text unless there
are line-break characters (CR) in the given string. Once the text note is
created its width gets adjusted to fit the longest (or the single one) line of text.

As a view-specific element the text note will be visible only in the specified view.

The new text note will be created using the given text type, which defines the style.
The currently default style can be obtained from the Document.GetDefaultElementTypeId method.

#### Parameter `document`

A valid Revit document that is currently modifiable (i.e. with an open transaction).

#### Parameter `viewId`

Id of the graphic view in which the note is to be created.

#### Parameter `position`

A model position of the new note.

Note that the position's relation to the text's bounding box depends on the requested text alignment
(set via the Options argument). It will be the box' top-left corner for a left-aligned text,
the top-right corner for a right-aligned text, and middle-top point if the text is to be centered.

#### Parameter `text`

Text to populate the text note with.

#### Parameter `options`

Options to control behavior and appearance of the text note.

#### Returns

The newly created text note.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document is a family that cannot contain text notes.
-or-
The viewId does not represent a valid graphic view element in the given document.
-or-
The options structure does not contain a valid text type to use for a new text note in the given document.
-or-
A valid point must not be father then 10 miles (approx. 16 km) from the origin.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.TextNote.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.String,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextNote.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.String,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new unwrapped TextNote element with the given properties.

#### Remarks

The new TextNote will consist of a single line of text unless there
are carriage return ('\r') or vertical tab ('\v') characters in the given string. Once the text note is
created its width gets adjusted to fit the longest (or the single one) line of text.

As a view-specific element the TextNote will be visible only in the specified view.

The new TextNote will be created using the given text type, which defines the style.
The currently default style can be obtained from the Document.GetDefaultElementTypeId method.

#### Parameter `document`

A valid Revit document that is currently modifiable (i.e. with an open transaction).

#### Parameter `viewId`

Id of the graphic view in which the note is to be created.

#### Parameter `position`

A model position of the new note.

For a left-aligned text (default), the origin is set at the top-left corner of the note's bounding box.

#### Parameter `text`

Text to populate the text note with.

#### Parameter `typeId`

Id of the text type to use for the new text note.

#### Returns

The newly created text note.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document is a family that cannot contain text notes.
-or-
The viewId does not represent a valid graphic view element in the given document.
-or-
The typeId does not represent a valid text type in the given document.
-or-
A valid point must not be father then 10 miles (approx. 16 km) from the origin.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.TextNote.LeaderRightAttachment`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNote.LeaderRightAttachment`

#### Summary

Attachment position of leaders on the right side of the text note.

#### Remarks

The property controls the vertical position of leaders attached to the right side of the note.

Change of the value will affect all leaders currently attached to the right side.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `P:Autodesk.Revit.DB.TextNote.LeaderLeftAttachment`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNote.LeaderLeftAttachment`

#### Summary

Attachment position of leaders on the left side of the text note.

#### Remarks

The property controls the vertical position of leaders attached to the left side of the note.

Change of the value will affect all leaders currently attached to the left side.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `P:Autodesk.Revit.DB.TextNote.LeaderCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNote.LeaderCount`

#### Summary

Number of leader objects currently attached to the text note.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNote.TextNoteType`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNote.TextNoteType`

#### Summary

Access the type of the TextNote object.

#### Remarks

The type of the TextNote object can be retrieved or changed.

### `T:Autodesk.Revit.DB.TextNote`

Member kind: type
Symbol: `Autodesk.Revit.DB.TextNote`

#### Summary

A class representing text note annotations in Revit.

### `P:Autodesk.Revit.DB.TextNoteOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNoteOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TextNoteOptions.KeepRotatedTextReadable`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNoteOptions.KeepRotatedTextReadable`

#### Summary

Flag controling whether a rotate text is to stay oriented to be always readable.

#### Remarks

Default value is True.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNoteOptions.VerticalAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNoteOptions.VerticalAlignment`

#### Summary

Vertical alignment of the text.

#### Remarks

Default is Top alignment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `P:Autodesk.Revit.DB.TextNoteOptions.HorizontalAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNoteOptions.HorizontalAlignment`

#### Summary

Horizontal alignment of the text.

#### Remarks

Default is Left alignment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `P:Autodesk.Revit.DB.TextNoteOptions.Rotation`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNoteOptions.Rotation`

#### Summary

Base line angle of a text note, in radians.

#### Remarks

Default value is 0.0.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNoteOptions.TypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNoteOptions.TypeId`

#### Summary

Id of a text type that defines the style of a text note.

#### Remarks

No default value. A valid type element Id must be set prior using the options.
The text type allows its font name parameter to be set to a font unavailable on the current system.
However, any text note created with or set to this font type will be displayed in a default substituted font (e.g. Arial)
and the UI will show a blank value in the text type font name parameter.
Once the document is opened on a system which has the font set on the text type,
the text note will display with that font and the UI will show that font in the text type font name parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.TextNoteOptions.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextNoteOptions.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs text options to create text of the given type.

#### Remarks

Except for the TypeId, all other properties of the option class will be populated with their respective default values.

#### Parameter `typeId`

Id of a text type that defines the style of a text note.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.TextNoteOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextNoteOptions.#ctor`

#### Summary

Default constructor; populates the options with their respective default values.

#### Remarks

The constructed options need to be given a typeId before it can be used to create a text note.

#### Since

2016

### `T:Autodesk.Revit.DB.TextNoteOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.TextNoteOptions`

#### Summary

Options to use when creating a new text note element.

#### Remarks

Use an instance of this class as an argument in the TextNote.Create methods.

#### Since

2016

### `M:Autodesk.Revit.DB.TessellatedShapeBuilder.GetBuildResult`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.GetBuildResult`

#### Summary

Get the built geometry, build status and other data stored in TessellatedShapeBuilderResult. Clears the stored data.

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedShapeBuilder.CreateMeshByExtrusion(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ,System.Double,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.CreateMeshByExtrusion(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ,System.Double,Autodesk.Revit.DB.ElementId)`

#### Summary

Builds a mesh by extruding curve loop(s) along extrusion distance.

#### Remarks

This function supports creation of a mesh given a collection
of continuous curve loops, which are processed independently
from each other. Loops with gaps or with curves with
wrong flips will be split before processing.

#### Parameter `profileLoops`

The profile loops to be extruded. The loops will not be modified.

#### Parameter `extrusionDirection`

Direction of extrusion. The length of this vector is ignored.

#### Parameter `extrusionDistance`

The positive distance by which the loops are extruded in the
direction of the input extrusionDir.

#### Parameter `materialId`

Material which should be used by a constructed mesh.

#### Returns

Returns a mesh, which was constructed, and some additional
information.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input value cannot be used as thickness for an extrusion,
or blend, or wall layer, or similar geometric construct.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

extrusionDirection has zero length.

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedShapeBuilder.Build`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.Build`

#### Summary

Builds the designated geometrical objects from the stored face sets. Stores the result in this TessellatedShapeBuilder object.

#### Remarks

The behavior of this function is affected by Target, Fallback and GStyleId properties of this TessellatedShapeBuilder object.
Currently only "Solid/Abort", "AnyGeometry/Mesh" and
"Mesh/Salvage" target/fallback combinations are supported.
Note that this function does not erase the face sets stored in the builder.
If the same builder is used to construct geometrical objects for different
collections of face sets, ( `M:Autodesk.Revit.DB.TessellatedShapeBuilder.Clear` ) should be called
while switching from one collection to another.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Throws if data in the stored face sets are so inconsistent, that
they cannot be used in their entirety, or if an attempt is made to create unacceptable geometry
with too many facets.

#### Since

2017

### `M:Autodesk.Revit.DB.TessellatedShapeBuilder.AreTargetAndFallbackCompatible(Autodesk.Revit.DB.TessellatedShapeBuilderTarget,Autodesk.Revit.DB.TessellatedShapeBuilderFallback)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.AreTargetAndFallbackCompatible(Autodesk.Revit.DB.TessellatedShapeBuilderTarget,Autodesk.Revit.DB.TessellatedShapeBuilderFallback)`

#### Summary

Checks whether this combination of fallback and target parameters
can be used as a valid combination of inputs.

#### Parameter `target`

What kind of geometrical objects should be built.

#### Parameter `fallback`

What should be done if a geometrical object described by 'target'
parameter cannot be built using all data from all stored face sets.

#### Returns

True if the combination of fallback and target are a valid combination, false
otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedShapeBuilder.AddFace(Autodesk.Revit.DB.TessellatedFace)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.AddFace(Autodesk.Revit.DB.TessellatedFace)`

#### Summary

Adds a face to the currently open connected face set.

#### Parameter `face`

Face to add. The 'face' parameter can be added only once, as its
boundary loops will be cleared while adding and 'face' will become unusable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The 'face' does not have enough loops and/or vertices to be valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

A face set is closed and faces cannot be added to it.

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedShapeBuilder.DoesFaceHaveEnoughLoopsAndVertices(Autodesk.Revit.DB.TessellatedFace)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.DoesFaceHaveEnoughLoopsAndVertices(Autodesk.Revit.DB.TessellatedFace)`

#### Summary

Checks whether 'face' has enough loops and vertcies to be valid.

#### Remarks

Face 'face' is not modified.

#### Parameter `face`

The face to check.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedShapeBuilder.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.Clear`

#### Summary

Erases all face set and clears the logs, if any.

#### Remarks

This function can be safely called upon builder without an open face set.

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedShapeBuilder.CancelConnectedFaceSet`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.CancelConnectedFaceSet`

#### Summary

Cancels the current face set - i.e., all data from it will be lost
and the builder will have no open connected face set anymore.

#### Remarks

This function can be safely called upon builder without an open face set.

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedShapeBuilder.CloseConnectedFaceSet`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.CloseConnectedFaceSet`

#### Summary

Closes the currently open connected face set.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

A face set is empty and cannot be closed until some faces are added.

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedShapeBuilder.OpenConnectedFaceSet(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.OpenConnectedFaceSet(System.Boolean)`

#### Summary

Opens a new connected face set.

#### Parameter `isSolid`

Whether the face set, which is being open, should be build as a solid or as a void.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

A face set is open and a geometry cannot be build until it is closed.

#### Since

2015

### `P:Autodesk.Revit.DB.TessellatedShapeBuilder.NumberOfCompletedFaceSets`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.NumberOfCompletedFaceSets`

#### Summary

Number of completed face sets.

#### Since

2015

### `P:Autodesk.Revit.DB.TessellatedShapeBuilder.OwnerInfo`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.OwnerInfo`

#### Summary

String used for logging, if any. Usually describes the element or object, which
either defined or will own the geoemtrical objects to be built.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.TessellatedShapeBuilder.LogInteger`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.LogInteger`

#### Summary

Integer value used for logging, if it is performed. Usually
the number of the face set(s) in the IFC file, from which they
are imported. Any value is acceptable.

#### Since

2015

### `P:Autodesk.Revit.DB.TessellatedShapeBuilder.LogString`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.LogString`

#### Summary

String used for logging, if any. Usually the name of the file from which
face sets were imported.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.TessellatedShapeBuilder.GraphicsStyleId`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.GraphicsStyleId`

#### Summary

Optional - if set, the built geometry will use that graphics style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.TessellatedShapeBuilder.Fallback`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.Fallback`

#### Summary

Defines acceptable fallback if the desired type of geometry can't be built.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `P:Autodesk.Revit.DB.TessellatedShapeBuilder.Target`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.Target`

#### Summary

Requests the type of geometry to be built.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `P:Autodesk.Revit.DB.TessellatedShapeBuilder.IsFaceSetOpen`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.IsFaceSetOpen`

#### Summary

Flag whether the current set of connected faces is open and
additional tessellation faces can be added to it.

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedShapeBuilder.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder.#ctor`

#### Summary

Constructs a new instance of a TessellatedShapeBuilder.

#### Since

2015

### `T:Autodesk.Revit.DB.TessellatedShapeBuilder`

Member kind: type
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilder`

#### Summary

A class that permits structured building of geometry or
a mesh from a collection of connected faces.
Contains all closed face sets and custom precisions.

#### Remarks

Creates a geometry populated with faces defined by TessellatedFace objects
stored in the input connected face sets.
The faces defined by each connected face set may form an open shell or
the boundary of a solid 3D region.
All faces are planar and have polyline boundaries, defined
as sequences of 3d coordinates.
Faces are added to the builder as a part of connected face sets,
representing faces which share edges.
Order of faces in the sets is irrelevant. Faces can only
be added to the builder when a face set has been opened and is available
to take in faces (use `M:Autodesk.Revit.DB.TessellatedShapeBuilder.OpenConnectedFaceSet(System.Boolean)` to open a new face set).
Before attempting to build Revit geometry from the builder
the current face set should be closed
( `M:Autodesk.Revit.DB.TessellatedShapeBuilder.CloseConnectedFaceSet` ).
The builder allows for the possibility of multiple face sets.
The builder will try to create a geometry valid in Revit despite
inconsistencies or omissions in the input data.
For each connected face set, it will check the face orientations and
change them wherever needed so that the orientations of the faces
in that set are consistent.

If a connected face set is closed, it will check if the face normals
point outward. If not, it will reverse the orientations of all faces.
That means, each closed connected face set will represent a solid.
Limitations in the current implementation:
It does not support the definition of a "void", even if the user had
set the orientations of the faces to define a "void".

If there is more than one connected face set, it does not check if they
intersect or overlap each other.

#### Since

2015

### `M:Autodesk.Revit.DB.MeshFromGeometryOperationResult.GetIssues`

Member kind: method
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationResult.GetIssues`

#### Summary

Returns the array of issues encountered while building a mesh.

#### Returns

Array of issues encountered while building a mesh.

#### Since

2015

### `M:Autodesk.Revit.DB.MeshFromGeometryOperationResult.GetMesh`

Member kind: method
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationResult.GetMesh`

#### Summary

This returns a valid mesh only for the first call. Later calls
will throw an exception as the mesh is no longer valid in this object.

#### Returns

Mesh which built.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Mesh has already been accessed by a previous GetMesh() call, and is no longer available for use.

#### Since

2015

### `P:Autodesk.Revit.DB.MeshFromGeometryOperationResult.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationResult.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.MeshFromGeometryOperationResult.IsMeshAvailable`

Member kind: property
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationResult.IsMeshAvailable`

#### Summary

Shows whether the result still contains the mesh
which was constructed, if any, or whether it has been
relinquished by 'getMesh'.
The former is true, the later is false.

#### Since

2015

### `P:Autodesk.Revit.DB.MeshFromGeometryOperationResult.Tessellated`

Member kind: property
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationResult.Tessellated`

#### Summary

Whether while constructing a mesh, it was necessary
to extrude polylines instead of non-linear curves
from the profile loops.

#### Since

2015

### `P:Autodesk.Revit.DB.MeshFromGeometryOperationResult.HasInvalidData`

Member kind: property
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationResult.HasInvalidData`

#### Summary

Whether the provided data for which this result was
obtained were internally inconsistent and could not be
used in its entirety. For example, for extrusion
operation, profile loops were degenerate
or improperly oriented with respect to the extrsuion
direction.

#### Remarks

This variable does not capture presence or absence
of intersections between different profile loops.

#### Since

2015

### `T:Autodesk.Revit.DB.MeshFromGeometryOperationResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationResult`

#### Summary

Describes what `T:TessellatedShapeBuilder` has
built.

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedShapeBuilderResult.GetIssuesForFaceSet(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderResult.GetIssuesForFaceSet(System.Int32)`

#### Summary

Returns the array of issues encountered while processing
a face set with index 'setIndex'.

#### Parameter `setIndex`

Index of the face set.

#### Returns

Array of issues encountered while processing a face set
with index 'setIndex'.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

'SetIndex' is a valid face set index for the results stored in 'this'.

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedShapeBuilderResult.GetNumberOfFaceSets`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderResult.GetNumberOfFaceSets`

#### Summary

Gets number of face sets for which 'this' result was obtained.

#### Returns

The number of face sets.

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedShapeBuilderResult.GetGeometricalObjects`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderResult.GetGeometricalObjects`

#### Summary

When called the first time, returns geometrical objects which were built.
Later calls will throw exceptions.

#### Remarks

Normally an array contains a single geometrical object
corresponding to either 'target' or 'fallback' type', but if
multiple face sets are being built with target/fallback of "AnyGeometry/Mesh",
then a two-element array with both geometry as the 1st element and mesh
as the 2nd can be returned. It happens if some of the face sets require a
fallback processing and some do not.

#### Returns

Geometrical object which were built.

#### Since

2015

### `P:Autodesk.Revit.DB.TessellatedShapeBuilderResult.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderResult.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TessellatedShapeBuilderResult.AreObjectsAvailable`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderResult.AreObjectsAvailable`

#### Summary

Shows whether 'issues' still contains the original data or whether
these data have already been relinquished by 'getGeometricalObjects'.
The former is true, the later is false.

#### Since

2015

### `P:Autodesk.Revit.DB.TessellatedShapeBuilderResult.Outcome`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderResult.Outcome`

#### Summary

What kinds of geometrical objects were built.

#### Since

2015

### `P:Autodesk.Revit.DB.TessellatedShapeBuilderResult.HasInvalidData`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderResult.HasInvalidData`

#### Summary

Whether there were any inconsistencies in the face sets,
stored in the tessellated shape builder while building
geometrical objects.

#### Since

2015

### `T:Autodesk.Revit.DB.TessellatedShapeBuilderResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderResult`

#### Summary

Describes what `T:TessellatedShapeBuilder` has
construct.

#### Since

2015

### `T:Autodesk.Revit.DB.TessellatedShapeBuilderOutcome`

Member kind: type
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderOutcome`

#### Summary

Describes the outcome of `T:TessellatedShapeBuilder` attempt
to build geometrical objects.

#### Since

2015

### `F:Autodesk.Revit.DB.TessellatedShapeBuilderOutcome.Sheet`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderOutcome.Sheet`

#### Summary

An open sheet was created.

### `F:Autodesk.Revit.DB.TessellatedShapeBuilderOutcome.Solid`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderOutcome.Solid`

#### Summary

A solid geometry was created.

### `F:Autodesk.Revit.DB.TessellatedShapeBuilderOutcome.Nothing`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderOutcome.Nothing`

#### Summary

Nothing was built.

### `F:Autodesk.Revit.DB.TessellatedShapeBuilderOutcome.Mixed`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderOutcome.Mixed`

#### Summary

A geometry and a mesh were created

### `F:Autodesk.Revit.DB.TessellatedShapeBuilderOutcome.Mesh`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderOutcome.Mesh`

#### Summary

A mesh was created

### `T:Autodesk.Revit.DB.TessellatedShapeBuilderFallback`

Member kind: type
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderFallback`

#### Summary

Describes what `T:TessellatedShapeBuilder` function
should do, if it cannot build a requested `T:Autodesk.Revit.DB.TessellatedShapeBuilderTarget` .

#### Since

2015

### `F:Autodesk.Revit.DB.TessellatedShapeBuilderFallback.Mesh`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderFallback.Mesh`

#### Summary

If a requested geometrical object cannot be built using all data from the
face set(s), create a mesh while using as much data from the face
set(s) as possible.

### `F:Autodesk.Revit.DB.TessellatedShapeBuilderFallback.Salvage`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderFallback.Salvage`

#### Summary

Ignore invalid data, and use all valid data. Note that if a complete set
of data describes a solid and some data are ignored, then the result
will be a sheet and not a solid.

### `F:Autodesk.Revit.DB.TessellatedShapeBuilderFallback.Abort`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderFallback.Abort`

#### Summary

Do nothing.

### `T:Autodesk.Revit.DB.TessellatedShapeBuilderTarget`

Member kind: type
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderTarget`

#### Summary

Describes what `T:TessellatedShapeBuilder`
should generate, if possible.

#### Since

2015

### `F:Autodesk.Revit.DB.TessellatedShapeBuilderTarget.Mesh`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderTarget.Mesh`

#### Summary

A mesh.

### `F:Autodesk.Revit.DB.TessellatedShapeBuilderTarget.AnyGeometry`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderTarget.AnyGeometry`

#### Summary

A Geometry, which depending on input data can be a Solid or a 'sheet',
where there is no fully enclosed volume formed by the generated faces.

### `F:Autodesk.Revit.DB.TessellatedShapeBuilderTarget.Solid`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedShapeBuilderTarget.Solid`

#### Summary

A solid, i.e., a Geometry, where all edges are shared by two and
only two faces and which divides all 3d space into bounded inner
and infinite outer area(s).

### `M:Autodesk.Revit.DB.TessellatedFace.GetBoundaryLoops`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedFace.GetBoundaryLoops`

#### Summary

Get loops bounding the face.

#### Since

2015

### `P:Autodesk.Revit.DB.TessellatedFace.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedFace.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TessellatedFace.MaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedFace.MaterialId`

#### Summary

Material of the face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedFace.#ctor(System.Collections.Generic.IList{System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ}},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedFace.#ctor(System.Collections.Generic.IList{System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ}},Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a tessellated face, which, may be, have holes. Face data
is always set, even if the input data are invalid (e.g., describes
a wildly non-planar face). A TessellatedShepeBuilder's function is
used to check the data and heal them if possible.

#### Parameter `allLoopVertices`

Boundary vertices without duplication of the ends - i.e., a
boundary of a triangular face consists of 3 (and NOT 4) vertices.
The first array describes the outer loop, the following arrays,
if any - inner loops.
It is expected that vertices of outer boundary are listed in CCW
order with respect to the face normal in the solid, while the
vertices of inner loops - in CW order. The vertices listed in the
wrong order will still be handled by TessellatedShapeBuilder, but
performance may deteriorate. Contents of this parameter will be
changed while constructing the face.

#### Parameter `materialId`

Material of the face to be used when the result is a Solid or a Sheet.
If the result is a Mesh, a material will be assigned to the entire Mesh.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedFace.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedFace.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a tessellated face without holes. Face data is always set,
even if the input data are invalid (e.g., describes a wildly non-planar
face). A TessellatedShepeBuilder's function is used to check
the data and heal them if possible.

#### Parameter `outerLoopVertices`

Boundary vertices without duplication of the ends - i.e., a
boundary of a triangular face consists of 3 (and NOT 4) vertices.
It is expected that boundaries are in CCW order with respect to
the face normal in the solid. Boundaries in CW order will still
be handled by TessellatedShapeBuilder, but performance may
deteriorate. Contents of this parameter will be changed while
constructing the face.

#### Parameter `materialId`

Material of the face to be used when the result is a Solid or a Sheet.
If the result is a Mesh, a material will be assigned to the entire Mesh.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.TessellatedFace`

Member kind: type
Symbol: `Autodesk.Revit.DB.TessellatedFace`

#### Summary

Defines a planar face bounded by a polyline in 3d space. A face
consists of a single connected component and can have holes.

#### Since

2015

### `T:Autodesk.Revit.DB.MeshFromGeometryOperationIssue`

Member kind: type
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue`

#### Summary

Issues encountered while constructing meshes as fallbacks
for geometrical operations.

#### Since

2015

#### Summary

Issues, which can be encountered while building a mesh as a
fallback for geometrical operations.

#### Since

2015

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.NumberOfIssueTypes`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.NumberOfIssueTypes`

#### Summary

Not a code of some issue, but the number of known types of issues.
Issues of this type should not be
present in TessellatedShapeBuilderResult. Please notify
Autodesk support if encountered

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.NotSetYet`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.NotSetYet`

#### Summary

An issue has not been set yet.

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.InternalError`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.InternalError`

#### Summary

An internal Revit problem. Issues of this type should not
normally be present in MeshFromGeometryOperationResult.
Please notify Autodesk support if encountered.

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.InternalMissingError`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.InternalMissingError`

#### Summary

An internal Revit problem. Issues of this type should not be
present in TessellatedShapeBuilderResult. Please notify
Autodesk support if encountered.

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.InternalUtilityError`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.InternalUtilityError`

#### Summary

An internal Revit problem. Issues of this type should not
normally be present in MeshFromGeometryOperationResult.
Please notify Autodesk support if encountered.

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.MissingCurvesInInputLoop`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.MissingCurvesInInputLoop`

#### Summary

An input curve loop has missing curves.

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.NonContinuousInputCurveLoop`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.NonContinuousInputCurveLoop`

#### Summary

A non-continuous input curve loop. Either wrong curve flips
or genuine gaps.

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.InputCurveLoopWrongOpenFlag`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.InputCurveLoopWrongOpenFlag`

#### Summary

An input curve has incorrect open flag.

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.InputCurveLoopProblemWithFallback`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.InputCurveLoopProblemWithFallback`

#### Summary

An unidentified problem with an input curve loop. A fallback
is attempted.

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.NonPlanarProfileLoop`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.NonPlanarProfileLoop`

#### Summary

Among curve loops expected as input parameters while building
a mesh, some are not planar.

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.CurveLoopsWithoutCurvesInInput`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.CurveLoopsWithoutCurvesInInput`

#### Summary

Among curve loops expected as input parameters while building
a mesh, some are not empty, but do not have any curves.

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.EmptyCurveLoopsInInput`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.EmptyCurveLoopsInInput`

#### Summary

Among curve loops expected as input parameters while building
a mesh, some are empty.

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.MissingCurveLoopsInInput`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.MissingCurveLoopsInInput`

#### Summary

While several curve loops were expected as one of the input
parameters while building a mesh, some of them were not provided.

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.NoUsableCurveLoopsInInput`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.NoUsableCurveLoopsInInput`

#### Summary

While one or more curve loops were expected as one of the input
parameters while building a mesh, no loops containing curves were
provided.

### `F:Autodesk.Revit.DB.MeshFromGeometryOperationIssue.AllFine`

Member kind: field
Symbol: `Autodesk.Revit.DB.MeshFromGeometryOperationIssue.AllFine`

#### Summary

No issues were encountered. Issues of this type should not
be present in MeshFromGeometryOperationResult.

### `M:Autodesk.Revit.DB.TessellatedBuildIssue.ReportIssueToDataSource`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssue.ReportIssueToDataSource`

#### Summary

Reports whether this issue should be reported to the
company which wrote the software which produced the face set data
(true), or to Autodesk (false).

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedBuildIssue.MakesDataUnusable`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssue.MakesDataUnusable`

#### Summary

Reports whether this issue makes some data unusable ('true')
or is only shows that data format conventions were broken,
but the data are still usable (false).

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedBuildIssue.GetIssueDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssue.GetIssueDescription`

#### Summary

Gets a string describing the issue. If the issue does
not present a problem, then an empty string is returned.

#### Returns

Description of the issue.

#### Since

2015

### `M:Autodesk.Revit.DB.TessellatedBuildIssue.IsValidIssue`

Member kind: method
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssue.IsValidIssue`

#### Summary

Reports whether the issue is well-formed, valid and does
describe a real problem.

#### Returns

Whether the issue is well formed and does describe a real problem.

#### Since

2015

### `P:Autodesk.Revit.DB.TessellatedBuildIssue.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssue.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TessellatedBuildIssue.NumberEncountered`

Member kind: property
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssue.NumberEncountered`

#### Summary

How many times this issue was encountered in its face set
during the face set processing. This number can be less
than the total number of such issues in the face set, as
the face set processing could be aborted due to
the presence of the issues which could not be handled.

#### Since

2015

### `T:Autodesk.Revit.DB.TessellatedBuildIssue`

Member kind: type
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssue`

#### Summary

Types of issues encountered while constructing geometrical objects
from the tessellated face sets.

#### Since

2015

### `T:Autodesk.Revit.DB.TessellatedBuildIssueType`

Member kind: type
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType`

#### Summary

Types of issues encountered while constructing geometrical objects
from the tessellatted face sets.

#### Since

2015

#### Summary

Issues, which can be encountered while building a polymesh,
or a shell, or a solid from data, describing
tessellated shapes.

#### Since

2015

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.NumberOfIssueTypes`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.NumberOfIssueTypes`

#### Summary

Not a code of some issue, but the number of known types of issues.
Issues of this type should not be
present in TessellatedShapeBuilderResult. Please notify
Autodesk support if encountered

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.NotSetYet`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.NotSetYet`

#### Summary

An issue has not been set yet.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.UnarticulatedNonManifoldEdge`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.UnarticulatedNonManifoldEdge`

#### Summary

An input face is mising an edge conecting two non-adjacent vertices
from its boundaries, which are adjacent in the boundaries of
some other face(s). If such an edge would be added, it would
split the face and result in 'NonManifoldEdge' or other issues.
Associated numbers are indices of a face which misses an edge
and indices of one or two faces in which boundaries such edge is
present.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.InternalMissingError`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.InternalMissingError`

#### Summary

An internal Revit problem. Issues of this type should not be
present in TessellatedShapeBuilderResult. Please notify
Autodesk support if encountered.
Associated number is face index.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.InternalLightError`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.InternalLightError`

#### Summary

An internal Revit problem. Issues of this type should not be
present in TessellatedShapeBuilderResult. Please notify
Autodesk support if encountered.
Associated number is face index.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.InternalError`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.InternalError`

#### Summary

An internal Revit problem. Issues of this type should not be
present in TessellatedShapeBuilderResult. Please notify
Autodesk support if encountered.
Associated number is face index.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.InternalUtilityError`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.InternalUtilityError`

#### Summary

An internal Revit problem. Issues of this type should not be
present in TessellatedShapeBuilderResult. Please notify
Autodesk support if encountered.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.TooSmallVertexSegementDistInFinalLoop`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.TooSmallVertexSegementDistInFinalLoop`

#### Summary

A face loop with too small vertex-segment distance.
Associated numbers are face, loop, segment and vertex
indices respectively

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.InconsitentMultiEdgeTraversalForFlip`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.InconsitentMultiEdgeTraversalForFlip`

#### Summary

A face edge with topological problems.
Associated numbers are indices of the involved faces.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.EdgeTraversalForFlip`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.EdgeTraversalForFlip`

#### Summary

A face edge with topological problems.
Associated numbers are indices of the face, loop and vertex and an index
of another involved face respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.PartitionPointsTooFarFromTrueEdge`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.PartitionPointsTooFarFromTrueEdge`

#### Summary

Points representing partitions of input points are too far from
the true edge.
Associated numbers are face and loop indices, an index of the
vertex in the beginning of the segment which is too far from
the corresponding true edge, an index of another involved face
respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.OverlappingAdjacentFaces`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.OverlappingAdjacentFaces`

#### Summary

Adjacent faces which either exactly overlaps or have a too
acute angle between them. This issue can be reported for face
sets with duplicate faces as well.
Associated numbers are face and loop indices of one face and
face and loop indices of another face respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.NonManifoldEdge`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.NonManifoldEdge`

#### Summary

Same edge is used by more than two faces.
This issue can be posted for topologically impossible face sets
as well as for face sets with duplicate faces.
Associated numbers are face and loop in which the problem became
obvious indices respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.EdgeTwiceUsedByFace`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.EdgeTwiceUsedByFace`

#### Summary

A face with an edge encountered in the loops multiple times.
Associated numbers are face and loop in which the problem became
obvious indices respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.InconsistentInnerOuterOriginalLoopCCW`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.InconsistentInnerOuterOriginalLoopCCW`

#### Summary

A face where the CCW of inner loop is inconsistent with CCW of the
outer loop.
Associated numbers are face and inner loop indices respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.DegenOriginalLoop`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.DegenOriginalLoop`

#### Summary

A degenerate face loop is degenerate.
Associated numbers are face and loop indices respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.OuterLoopIsNotFirst`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.OuterLoopIsNotFirst`

#### Summary

A face have multiple loops, but the outer loop is not listed as the
very first one.
Associated numbers are face and loop indices respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.OriginalLoopsProximity`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.OriginalLoopsProximity`

#### Summary

A face with excessive proximity between face loops.
Associated numbers are face and two loop indices respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.FaceWithIslands`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.FaceWithIslands`

#### Summary

A face which has a loop inside a loop inside a loop.
Associated numbers are face and three loop indices respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.IntersectingOriginalLoops`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.IntersectingOriginalLoops`

#### Summary

A face whose loops intersect.
Associated numbers are face and two loop indices respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.LoopOnBestFitSelfIntersects`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.LoopOnBestFitSelfIntersects`

#### Summary

A face loop whose projection of the best-fit-plane self-intersects.
Associated numbers are face, loop, and two segments
indices respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.TooSmallVertexSegementDistInOriginalLoop`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.TooSmallVertexSegementDistInOriginalLoop`

#### Summary

A face loop with too small vertex-segment distance.
Associated numbers are face, loop, segment and vertex
indices respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.OriginalPointsTooFarFromTheirPlane`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.OriginalPointsTooFarFromTheirPlane`

#### Summary

A face whose original points taken together do define a plane, but some of
them lie to far from it.
An associated number is face index.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.NonPlanarFace`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.NonPlanarFace`

#### Summary

A face which is not planar.
An associated number is face index.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.LostAllLoops`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.LostAllLoops`

#### Summary

A face, which originally had enough loops lost all of
them during purges.
An associated number is face index.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.OriginalLoopMeshAcuteAngle`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.OriginalLoopMeshAcuteAngle`

#### Summary

A face loop with a too acute angle between adjacent segments.
This condition is not relevant for polymesh construction.
Associated numbers are face, loop and point between segments
indices respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.OriginalLoopGeomAcuteAngle`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.OriginalLoopGeomAcuteAngle`

#### Summary

A face loop with a too acute angle between adjacent segments.
This condition is not relevant for polymesh construction.
Associated numbers are face, loop and point between segments
indices respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.LostTooManyLoopVertices`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.LostTooManyLoopVertices`

#### Summary

A face loop, which originally had enough vertices, but lost too
many of them, while purging pseudo-duplicates.
Associated numbers are face index and loop index respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.TooShortOriginalLoopGeomSegment`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.TooShortOriginalLoopGeomSegment`

#### Summary

A face loop, containing a segment which is too short for a geometry,
but not for a mesh.
Associated numbers are face, loop and point indices respectively
(the segment goes from the previous point to this one).

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.TooShortOriginalLoopMeshSegment`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.TooShortOriginalLoopMeshSegment`

#### Summary

A face loop, containing a segment which is too short even for a mesh.
Associated numbers are face, loop and point indices respectively
(the segment goes from the previous point to this one).

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.TooFewOriginalVertices`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.TooFewOriginalVertices`

#### Summary

A face loop, which from the very beginning does not have enough points.
Associated numbers are face index and loop index respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.EmptyLoop`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.EmptyLoop`

#### Summary

A face loop which does not have any points.
Associated numbers are face index and loop index respectively.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.EmptyFace`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.EmptyFace`

#### Summary

A face which does not have any loops.
An associated number is face index.

### `F:Autodesk.Revit.DB.TessellatedBuildIssueType.AllFine`

Member kind: field
Symbol: `Autodesk.Revit.DB.TessellatedBuildIssueType.AllFine`

#### Summary

No issues were encountered. Issues of this type should not
be present in TessellatedShapeBuilderResult.

### `M:Autodesk.Revit.DB.TemporaryViewModes.IsCustomized`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.IsCustomized`

#### Summary

Identifies if a custom temporary view mode is currently active.
A custom mode is active if there is a non-empty string set for `P:Autodesk.Revit.DB.TemporaryViewModes.CustomTitle` .

#### Returns

Returns true a custom temporary view mode is currently active, false otherwise.
A custom mode is active if there is a non-empty string set for `P:Autodesk.Revit.DB.TemporaryViewModes.CustomTitle` .

#### Since

2020.1

### `M:Autodesk.Revit.DB.TemporaryViewModes.RemoveCustomization`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.RemoveCustomization`

#### Summary

Removes all customized values for the TemporaryViewProperties mode.

#### Since

2020.1

### `M:Autodesk.Revit.DB.TemporaryViewModes.IsValidState(Autodesk.Revit.DB.PreviewFamilyVisibilityMode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.IsValidState(Autodesk.Revit.DB.PreviewFamilyVisibilityMode)`

#### Summary

Tests whether the given state is valid for the associated view and the context the view is currently in.

#### Remarks

As long as the PreviewFamilyVisibility mode is available and enabled in the associated view,
the Off and On states are always valid. However, the Uncut state is only
valid in plan views and reflected ceilings.

#### Parameter `state`

A state of the PreviewFamilyVisibilityMode

#### Returns

Returns True if the state is applicable for the view; False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.TemporaryViewModes.IsModeEnabled(Autodesk.Revit.DB.TemporaryViewMode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.IsModeEnabled(Autodesk.Revit.DB.TemporaryViewMode)`

#### Summary

Tests whether a temporary view mode is currently enabled in the associated view.

#### Remarks

Most of temporary modes are enabled in a specific context only.
A programmer who wants to use a mode needs to first test whether
it is currently available and enabled, or not.

#### Parameter `mode`

The mode to evaluate

#### Returns

True if the requested mode is available and enabled in the associated view; False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.TemporaryViewModes.IsModeAvailable(Autodesk.Revit.DB.TemporaryViewMode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.IsModeAvailable(Autodesk.Revit.DB.TemporaryViewMode)`

#### Summary

Tests whether a temporary view mode is currently available in the associated view.

#### Remarks

Not every mode is available in all views at all times.
Some of the modes are only available in certain views,
or only at certain time/context. Modes that are not available
will not be visible on the view's tool bar in the UI.

Even modes that are available do not have to be currently
enabled in the current context. Before using a mode its
applicability should be tested by calling
`M:Autodesk.Revit.DB.TemporaryViewModes.IsModeEnabled(Autodesk.Revit.DB.TemporaryViewMode)` .

#### Parameter `mode`

The mode to evaluate

#### Returns

True of the temporary mode is currently available in the associated view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.TemporaryViewModes.DeactivateAllModes`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.DeactivateAllModes`

#### Summary

Deactivates all temporary modes that are currently active.

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.TemporaryViewModes.DeactivateMode(Autodesk.Revit.DB.TemporaryViewMode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.DeactivateMode(Autodesk.Revit.DB.TemporaryViewMode)`

#### Summary

Deactivates the given temporary mode.

#### Remarks

The method has no effect on modes that are already deactivated.

#### Parameter `mode`

The mode to deactivate

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The temporary mode is not available in the associated view.
The view is either of a type that does not support this mode,
or is currently in a context that makes the mode presently inapplicable.
-or-
The temporary mode is presently not enabled in the associated view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016 Subscription Update
