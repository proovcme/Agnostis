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
Shard: 13
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.TemporaryViewModes.IsModeActive(Autodesk.Revit.DB.TemporaryViewMode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.IsModeActive(Autodesk.Revit.DB.TemporaryViewMode)`

#### Summary

Tests whether a given mode is currently active or not.

#### Parameter `mode`

The mode being tested

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.TemporaryViewModes.GetCaption(Autodesk.Revit.DB.TemporaryViewMode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.GetCaption(Autodesk.Revit.DB.TemporaryViewMode)`

#### Summary

A text caption to use for the given mode.

#### Remarks

The text appears in the UI on the temporary frame when the view is in the temporary mode.

#### Parameter `mode`

The mode to get a caption for.

#### Returns

Text of the caption. The text is localized.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016 Subscription Update

### `P:Autodesk.Revit.DB.TemporaryViewModes.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TemporaryViewModes.CustomColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.CustomColor`

#### Summary

Custom color for the TemporaryViewProperties mode.

#### Remarks

If custom title is not empty, Temporary View Properties mode displays the colored view frame in custom color.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.TemporaryViewModes.CustomTitle`

Member kind: property
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.CustomTitle`

#### Summary

Custom title for the TemporaryViewProperties mode.

#### Remarks

If custom title is not empty, Temporary View Properties mode displays it in the upper left corner of colored view frame.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.TemporaryViewModes.RevealHiddenElements`

Member kind: property
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.RevealHiddenElements`

#### Summary

The current state of the RevealHiddenElements mode in the associated view.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The RevealHiddenElements mode is either disabled or inapplicable in the associated view.

#### Since

2016 Subscription Update

### `P:Autodesk.Revit.DB.TemporaryViewModes.WorksharingDisplay`

Member kind: property
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.WorksharingDisplay`

#### Summary

The current state of the WorksharingDisplay mode in the associated view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The WorksharingDisplay mode is either disabled or inapplicable in the associated view.

#### Since

2016 Subscription Update

### `P:Autodesk.Revit.DB.TemporaryViewModes.RevealConstraints`

Member kind: property
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.RevealConstraints`

#### Summary

The current state of the RevealConstraints mode in the associated view.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The RevealConstraints mode is either disabled or inapplicable in the associated view.

#### Since

2016 Subscription Update

### `P:Autodesk.Revit.DB.TemporaryViewModes.PreviewFamilyVisibilityDefaultUncutState`

Member kind: property
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.PreviewFamilyVisibilityDefaultUncutState`

#### Summary

Controls the default type of the On state of the PreviewFamilyVisibility mode in cut-able views.

#### Remarks

Newly opened views which can have both Cut and Uncut preview will use
this default cut/uncut state as long as the default On state is set to True.
To control the default state of the PreviewFamilyVisibility in all views refer to
the `P:Autodesk.Revit.DB.TemporaryViewModes.PreviewFamilyVisibilityDefaultOnState`
property.

The settings is applicable to the whole application rather than to
individual family documents; the value persists between Revit sessions.
Although the value is allowed to be set at any time, any changes made after
the Revit application has been initialized will not have effect until the next
session of Revit.

After a view is opened with the default family preview state applied,
its PreviewFamilyVisibility mode may be independently modified through the
`P:Autodesk.Revit.DB.TemporaryViewModes.PreviewFamilyVisibility` property. Once explicitly modified,
the settings stays in effect for the respective view even after the view
is closed and later reopened again.

#### Value

A Boolean value to control whether to use a non-cut preview
in applicable views, such as floor and ceiling plan views.

#### Since

2016 Subscription Update

### `P:Autodesk.Revit.DB.TemporaryViewModes.PreviewFamilyVisibilityDefaultOnState`

Member kind: property
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.PreviewFamilyVisibilityDefaultOnState`

#### Summary

Controls the default state of the PreviewFamilyVisibility mode in all views.

#### Remarks

This flag controls whether each newly opened view is to have the
PreviewFamilyVisibility mode turned On by default or not. This property is applicable to all
types of views. Views that support both Cut and Non-cut preview (such as floor plans) can be
controlled further via the `P:Autodesk.Revit.DB.TemporaryViewModes.PreviewFamilyVisibilityDefaultUncutState`
property.

The settings is applicable to the whole application rather than to
individual family documents; the value persists between Revit sessions.
Although the value is allowed to be set at any time, any changes made after
the Revit application has been initialized will not have effect until the next
session of Revit.

After a view is opened with the default family preview state applied,
its PreviewFamilyVisibility mode may be independently modified through the
`P:Autodesk.Revit.DB.TemporaryViewModes.PreviewFamilyVisibility` property. Once explicitly modified,
the settings stays in effect for the respective view even after the view
is closed and later reopened again.

#### Value

A boolean value to control whether the PreviewFamilyVisibility mode
is to be turned On or Off in all views newly opened in a family editor.

#### Since

2016 Subscription Update

### `P:Autodesk.Revit.DB.TemporaryViewModes.PreviewFamilyVisibility`

Member kind: property
Symbol: `Autodesk.Revit.DB.TemporaryViewModes.PreviewFamilyVisibility`

#### Summary

The current state of the PreviewFamilyVisibility mode in the associated view.

#### Remarks

The state of the PreviewFamilyVisibility mode can be set only if the mode
is currently available and enabled in the view. Even in such a condition,
however, not all states are valid in all views. To ensure that the state
to be applied is valid in the view, call the `M:Autodesk.Revit.DB.TemporaryViewModes.IsValidState(Autodesk.Revit.DB.PreviewFamilyVisibilityMode)` method
first.

Even views which generally support temporary modes will have this particular
mode available only when the document of the view is in the environment of the
family editor.

This property affect only the view associated with this instance of TemporaryViewModes.
When a view is opened for the first time, its state of the PreviewFamilyVisibility mode
is determined based on the default settings which is controlled through the properties
`P:Autodesk.Revit.DB.TemporaryViewModes.PreviewFamilyVisibilityDefaultOnState` and
`P:Autodesk.Revit.DB.TemporaryViewModes.PreviewFamilyVisibilityDefaultUncutState` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given PreviewFamilyVisibilityMode is not applicable in the associated view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The PreviewFamilyVisibility mode is either disabled or inapplicable in the associated view.

#### Since

2016 Subscription Update

### `T:Autodesk.Revit.DB.TemporaryViewModes`

Member kind: type
Symbol: `Autodesk.Revit.DB.TemporaryViewModes`

#### Summary

A data structure containing data related to temporary view modes.

#### Remarks

The class contains methods and properties to manipulate states
of various temporary view modes that may or may not be avilable
in any of visible views of a Revit document. The temporary modes are
enumerated in the `T:Autodesk.Revit.DB.TemporaryViewMode`
class.

Every view that supports temporary view modes owns an instance
of this TemporaryViewModes class, which can be obtained by
accessing the `P:Autodesk.Revit.DB.View.TemporaryViewModes`
property of the `T:Autodesk.Revit.DB.View` class.
Note that views which do not support temporary modes will have that
property's value be Null.

Multiple temporary view modes can coexist.
Also, TemporaryViewProperties mode can be customized to display custom title and custom color.
Setting custom title and color affects only TemporaryViewProperties mode for the specific view.
`P:Autodesk.Revit.DB.TemporaryViewModes.CustomTitle``P:Autodesk.Revit.DB.TemporaryViewModes.CustomColor``M:Autodesk.Revit.DB.TemporaryViewModes.IsCustomized``M:Autodesk.Revit.DB.TemporaryViewModes.RemoveCustomization`

#### Since

2016 Subscription Update

### `T:Autodesk.Revit.DB.PreviewFamilyVisibilityMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.PreviewFamilyVisibilityMode`

#### Summary

Modes that control visibility of family elements depending on
the currently applied Element Visibility Settings of a view.

#### Remarks

Values of this mode can be set or obtained for any view that supports it by accessing
the `!:Autodesk::Revit::DB::TemporaryViewModes::PreviewFamilyVisibility`
property.

#### Since

2016 Subscription Update

### `F:Autodesk.Revit.DB.PreviewFamilyVisibilityMode.Uncut`

Member kind: field
Symbol: `Autodesk.Revit.DB.PreviewFamilyVisibilityMode.Uncut`

#### Summary

Element Visibility of a view is applied to show elements visible if instance is not cut.
Note that this state is only available in certain views, such as floor plan and ceilings.

### `F:Autodesk.Revit.DB.PreviewFamilyVisibilityMode.On`

Member kind: field
Symbol: `Autodesk.Revit.DB.PreviewFamilyVisibilityMode.On`

#### Summary

Element Visibility of a view is applied to show visible elements only.
Elements that are cut by a reference plane will be shown with their respective cut geometry.

### `F:Autodesk.Revit.DB.PreviewFamilyVisibilityMode.Off`

Member kind: field
Symbol: `Autodesk.Revit.DB.PreviewFamilyVisibilityMode.Off`

#### Summary

Element Visibility is not applied. All family elements visible.

### `M:Autodesk.Revit.DB.TemporaryGraphicsManager.SetVisibility(System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryGraphicsManager.SetVisibility(System.Int32,System.Boolean)`

#### Summary

Changes the visibility of temporary graphics object.

#### Parameter `index`

Unique index of the temporary graphics object to be updated.

#### Parameter `visible`

if true, it will make the temporary graphics object visible.
if false, it will make the temporary graphics object invisible.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

index is out of range of TemporaryGraphicsManager managed objects, or the indexed object has been removed from the document.

#### Since

2022

### `M:Autodesk.Revit.DB.TemporaryGraphicsManager.UpdateControl(System.Int32,Autodesk.Revit.DB.InCanvasControlData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryGraphicsManager.UpdateControl(System.Int32,Autodesk.Revit.DB.InCanvasControlData)`

#### Summary

Updates the in-canvas control identified by the unique index.

#### Parameter `index`

Unique index of the control to be updated.

#### Parameter `data`

data to generate in-canvas control appearance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

index is out of range of TemporaryGraphicsManager managed objects, or the indexed object has been removed from the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to load the image from specified path.

#### Since

2022

### `M:Autodesk.Revit.DB.TemporaryGraphicsManager.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryGraphicsManager.Clear`

#### Summary

Clear all temporary graphics objects managed by this manager.

#### Since

2022

### `M:Autodesk.Revit.DB.TemporaryGraphicsManager.GetAll`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryGraphicsManager.GetAll`

#### Summary

Returns all temporary graphics object indexes managed by this manager.

#### Returns

Collection of temporary graphics object indexes managed by this manager.

#### Since

2022

### `M:Autodesk.Revit.DB.TemporaryGraphicsManager.RemoveControl(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryGraphicsManager.RemoveControl(System.Int32)`

#### Summary

Deletes the existing control identified by the unique index.

#### Parameter `index`

Unique index of the control to be deleted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

index is out of range of TemporaryGraphicsManager managed objects, or the indexed object has been removed from the document.

#### Since

2022

### `M:Autodesk.Revit.DB.TemporaryGraphicsManager.AddControl(Autodesk.Revit.DB.InCanvasControlData,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryGraphicsManager.AddControl(Autodesk.Revit.DB.InCanvasControlData,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates an in-canvas control.

#### Remarks

This method can perform drawing an image (supplied by the caller) as an in-canvas control in the view(s). The control can react on click
by invoking a callback defined in `!:Autodesk::Revit::UI::ITemporaryGraphicsHandler::OnClick(TemporaryGraphicsCommandData)` .
The caller can use the returned index to update the control (changing image/location), delete and change visibility (hide/unhide) in
response to any events later.

#### Parameter `data`

Data to generate in-canvas control appearance.

#### Parameter `ownerViewId`

The view in which the control appears. It will show in all views if the id is invalidElementId.

#### Returns

Unique index of control for future references.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ownerViewId provided is not an id of a view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to load the image from specified path.

#### Since

2022

### `M:Autodesk.Revit.DB.TemporaryGraphicsManager.GetTemporaryGraphicsManager(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TemporaryGraphicsManager.GetTemporaryGraphicsManager(Autodesk.Revit.DB.Document)`

#### Summary

Gets a TemporaryGraphicsManager reference of the document.

#### Parameter `document`

The document.

#### Returns

Instance of TemporaryGraphicsManager.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.TemporaryGraphicsManager.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TemporaryGraphicsManager.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.TemporaryGraphicsManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.TemporaryGraphicsManager`

#### Summary

A class that provides functionality to create temporary graphics in a Revit model.

#### Remarks

The graphics created by this class are temporary or transient. They are not subject to undo and are not saved. It's caller's
responsiblity to manage their lifetime, creation and destruction, though Revit will destroy all of them when closing the model.

#### Since

2022

### `M:Autodesk.Revit.DB.CylindricalSurface.GetFrameOfReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.CylindricalSurface.GetFrameOfReference`

#### Summary

Returns frame of reference associated with this CylindricalSurface.

#### Remarks

This is an equivalent of new Frame(Origin, XDir, YDir, Axis).

#### Returns

Frame of reference associated with this CylindricalSurface.

#### Since

2017

### `M:Autodesk.Revit.DB.CylindricalSurface.Create(Autodesk.Revit.DB.Frame,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CylindricalSurface.Create(Autodesk.Revit.DB.Frame,System.Double)`

#### Summary

Construct a cylindrical surface defined by a local coordinate system and a radius.

#### Remarks

The parametric equation of the cylinder is S(u, v) = Frame.Origin + radius*cos(u)*Frame.BasisX + radius*sin(u)*Frame.BasisY + v*Frame.BasisZ.
This implies the following facts:
Frame.BasisX points from the axis point to the point on the cylinder with coordinates (0, 0).

Frame.BasisY points in the direction of the partial derivative dS/du at (0, 0).

Frame.BasisZ points in the direction of the partial derivative dS/dv at (0, 0).

#### Parameter `frameOfReference`

frameOfReference is an orthonormal frame that defines a local coordinate system for the cylinder.
Frame.Origin is a point on the cylinder's axis.

Frame.BasisZ points along the axis, while Frame.BasisX and Frame.BasisY are orthogonal to the axis.

The frame may be either left-handed or right-handed (see Frame.IsRightHanded). Note that
the "handedness" of the frame does not, by itself, determine the surface's orientation.

#### Parameter `radius`

Radius of the circle that defines the base of the cylindrical surface.

#### Returns

The created CylindricalSurface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This Frame object may not be used as a local frame of reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for radius must be greater than 0 and no more than 30000 feet.

#### Since

2017

### `P:Autodesk.Revit.DB.CylindricalSurface.Radius`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalSurface.Radius`

#### Summary

Radius of the circle that defines the base of this cylinder.

#### Since

2017

### `P:Autodesk.Revit.DB.CylindricalSurface.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalSurface.Origin`

#### Summary

Center of the circle that defines the base of the cylinder. This is the origin of the local coordinate system associated with this cylinder.

#### Since

2017

### `P:Autodesk.Revit.DB.CylindricalSurface.YDir`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalSurface.YDir`

#### Summary

Y axis of the local coordinate system associated with this cylinder.

#### Since

2017

### `P:Autodesk.Revit.DB.CylindricalSurface.XDir`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalSurface.XDir`

#### Summary

X axis of the local coordinate system associated with this cylinder.

#### Since

2017

### `P:Autodesk.Revit.DB.CylindricalSurface.Axis`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalSurface.Axis`

#### Summary

Axis of the cylinder. This is the Z axis of the local coordinate system associated with this cylinder.

#### Since

2017

### `T:Autodesk.Revit.DB.CylindricalSurface`

Member kind: type
Symbol: `Autodesk.Revit.DB.CylindricalSurface`

#### Summary

A cylindrical surface.

#### Remarks

The parametric equation of the cylinder is S(u, v) = center + radius*cos(u)*xVec + radius*sin(u)*yVec + v*zVec.

#### Since

2017

### `P:Autodesk.Revit.DB.Lighting.CustomInitialColor.Temperature`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.CustomInitialColor.Temperature`

#### Summary

The custom color temperature value.

#### Value

The color temperature in Kelvin as a numerical value between 1800 and 20000

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The color temperature is not valid because it is not in the range of 1800 to 20000.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.CustomInitialColor.#ctor(Autodesk.Revit.DB.Lighting.CustomInitialColor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.CustomInitialColor.#ctor(Autodesk.Revit.DB.Lighting.CustomInitialColor)`

#### Summary

Creates a copy of the given custom initial color

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.CustomInitialColor.#ctor(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.CustomInitialColor.#ctor(System.Double)`

#### Summary

Creates a custom initial color set to the given color

#### Parameter `temperature`

The color temperature in Kelvin as a numerical value between 1800 and 20000

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The color temperature is not valid because it is not in the range of 1800 to 20000.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.CustomInitialColor`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.CustomInitialColor`

#### Summary

This class encapsulates a custom initial lighting color.

#### Remarks

This color is called an initial color because a color filter can also be added to modify the color.

#### Since

2013

### `M:Autodesk.Revit.DB.CurveElement.SetSketchPlaneAndCurve_DontCall(Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElement.SetSketchPlaneAndCurve_DontCall(Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.Curve)`

#### Summary

Sets a new curve and its plane.

#### Remarks

Unlike setting either just the sketch plane or just the curve,
this method reestablishes the relationships between those two,
as well as it resets their relationship to other elements.

#### Parameter `plane`

New sketch plane.

#### Parameter `curve`

New curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.CurveElement.GetAreaBasedLoadBoundaryLineData`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElement.GetAreaBasedLoadBoundaryLineData`

#### Summary

Gets the area based load boundary line data from this curve, if applicable.

#### Remarks

Will return `null` if curve element isn't an area based load boundary line.

#### Returns

The area based load boundary line data, if this is an area based load boundary,
or `null` otherwise.

#### Since

2023

### `M:Autodesk.Revit.DB.CurveElement.CreateAreaBasedLoadBoundaryLines(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElement.CreateAreaBasedLoadBoundaryLines(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.ElementId)`

#### Summary

Creates area based load boundary lines.

#### Parameter `document`

The document in which to create the area based load boundary lines.

#### Parameter `curves`

The curves.

#### Parameter `levelId`

The id of level.

#### Returns

The newly created area based load boundary lines.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The input curves contains a null pointer or a curve that is not bounded.
-or-
The input curves contains at least one curve which is degenerate (its length is too close to zero).
-or-
The ElementId levelId is not a Level.
-or-
The input curves contains a curve doesn't lie in the plane of the level.

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

2023

### `M:Autodesk.Revit.DB.CurveElement.CreateAreaBasedLoadBoundaryLine(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElement.CreateAreaBasedLoadBoundaryLine(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates an area based load boundary line.

#### Parameter `document`

The document in which to create the area based load boundary line.

#### Parameter `curve`

The curve.

#### Parameter `levelId`

The id of level.

#### Returns

The newly created area based load boundary line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The input curve is not bound.
-or-
The curve is degenerate (its length is too close to zero).
-or-
The ElementId levelId is not a Level.
-or-
The curve doesn't lie in the plane of the level.

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

2023

### `M:Autodesk.Revit.DB.CurveElement.SetTangentLock(System.Int32,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElement.SetTangentLock(System.Int32,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Sets a new status for an existing tangent join with another curve element at the given end-point.

#### Remarks

The input status indicates whether the tangent join is to be locked or unlocked.
Note that the status can be set only if this and the other curve element are currently
joined and tangent at the given point.

Locking a tangent join between elements of a family will make the family parametric.
A parametric family needs to utilize a geometry solver in order to determine final
shapes of its instances. Using the solver in families which contain large sketches
may cause regenerations of such families to become significantly slower.
To determine whether a particular family falls into such a category, programmers
can query `P:Autodesk.Revit.DB.Family.IsParametric` property
and `!:Autodesk::Revit::DB::Family::DoesContainLargeSketches()`
method of the `T:Autodesk.Revit.DB.Family` class.

#### Parameter `end`

Index of one of the curve's ends. Values '0' and '1' indicate the start or end point, respectively.

#### Parameter `other`

ElementId of another Curve Element from the same document.

#### Parameter `state`

Requested new state of the lock; True to lock it, False to unlock it.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given Id does not represent any of the two end-points of a curve element.
A valid value of either '0' or '1' is expected.
-or-
The given ElementId (%elementId) is not of a valid Curve Element.
A valid Curve Element must be in the same document and must be
diferent than this curve elements self.
-or-
This element has no tangent join with the input element at the given end-point.
-or-
The element other does not exist in the document containing this CurveElement

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This curve element does not support tangent joins with other elements.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

This CurveElement is an internal element, such as a component of a
loaded family or a group type.
-or-
The document containing this CurveElement is in Group Edit Mode,
Sketch Edit Mode, or Paste Mode, and the element is not a
member of the group, sketch, or clipboard.
-or-
This CurveElement is a member of a group or sketch, and the document
is not currently editing the group or sketch.
-or-
other is an internal element, such as a component of a
loaded family or a group type.
-or-
The document containing other is in Group Edit Mode,
Sketch Edit Mode, or Paste Mode, and the element is not a
member of the group, sketch, or clipboard.
-or-
other is a member of a group or sketch, and the document
is not currently editing the group or sketch.

#### Since

2017

### `M:Autodesk.Revit.DB.CurveElement.GetTangentLock(System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElement.GetTangentLock(System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns the state of a tangent join between this and another curve element at the given end-point.

#### Remarks

The return value indicates whether there is such tangent join and if it is currently locked.
A negative value indicates that there either is no tangent join with the other element
at the given end-point, or the join between those two curve element is not currently locked.

#### Parameter `end`

Index of one of the curve's end. Values '0' and '1' indicate the start or end point, respectively.

#### Parameter `other`

ElementId of another Curve Element from the same document.

#### Returns

Returns True if this curve element has a tangent joint with the other input element and the join is curently locked; returns False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given Id does not represent any of the two end-points of a curve element.
A valid value of either '0' or '1' is expected.
-or-
The given ElementId (%elementId) is not of a valid Curve Element.
A valid Curve Element must be in the same document and must be
diferent than this curve elements self.
-or-
This element has no tangent join with the input element at the given end-point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.CurveElement.HasTangentLocks(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElement.HasTangentLocks(System.Int32)`

#### Summary

Tests whether this curve element has any locked tangent joins at the given end-point.

#### Remarks

Note that tangent locks between two elements at their joined ends are always kept in
sync with each other. It means that if one curve element is locked to another curve,
the other curve will be automatically locked to the first curve at the shared join.

#### Parameter `end`

Index of one of the curve's end. Values '0' and '1' indicate the start or end point, respectively.

#### Returns

Returns True if the curve element is tangentially locked to at least one other curve element at the given end-point; returns False otherwise.

#### Since

2017

### `M:Autodesk.Revit.DB.CurveElement.HasTangentJoin(System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElement.HasTangentJoin(System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Tests whether this curve element and the input curve element have common tangent join at the given end-point.

#### Parameter `end`

Index of one of the curve's end. Values '0' and '1' indicate the start or end point, respectively.

#### Parameter `other`

ElementId of another Curve Element from the same document.

#### Returns

Returns True if the two curve elements have a tangent join at the given end-point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.CurveElement.IsAdjoinedCurveElement(System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElement.IsAdjoinedCurveElement(System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

This method tests whether this and the given curve elements are joined at the given end.

#### Remarks

The input end is relative to this curve element.
The other curve element can be joined at any of its end-points.

#### Parameter `end`

Index of one of the curve's end. Values '0' and '1' indicate the start or end point, respectively.

#### Parameter `other`

ElementId of another Curve Element from the same document.

#### Returns

Returns True if the input curve element joins This curve element at the given end-point; returns False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given Id does not represent any of the two end-points of a curve element.
A valid value of either '0' or '1' is expected.
-or-
The given ElementId (%elementId) is not of a valid Curve Element.
A valid Curve Element must be in the same document and must be
diferent than this curve elements self.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.CurveElement.GetAdjoinedCurveElements(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElement.GetAdjoinedCurveElements(System.Int32)`

#### Summary

Returns elements that are joining with this curve element at the given end point.

#### Parameter `end`

Id of one the curve's end. Value '0' indicates start and '1' indicates the end of the curve, respectively.

#### Returns

Collection of Ids of Curve Elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given Id does not represent any of the two end-points of a curve element.
A valid value of either '0' or '1' is expected.

#### Since

2017

### `M:Autodesk.Revit.DB.CurveElement.GetLineStyleIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElement.GetLineStyleIds`

#### Summary

Ids of all line style Elements that are applicable to this curve element.

#### Remarks

The elements are of the `!:Autodesk::Revit::DB::GraphicsStyle` class.

#### Returns

A collection of Ids of line style elements.

### `P:Autodesk.Revit.DB.CurveElement.SupportsTangentLocks`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveElement.SupportsTangentLocks`

#### Summary

Indicates whether or not this curve element can have a locked tangent
join at either of its end-points shared with another curve element.

### `P:Autodesk.Revit.DB.CurveElement.CurveElementType`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveElement.CurveElementType`

#### Summary

Type of the curve element.

### `T:Autodesk.Revit.DB.CurveElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveElement`

#### Summary

Class representing curve elements.

#### Remarks

As a base class of several specialized curved elements
(such as ModelCurve, ModelLine, CurveByPoints, etc.)
CurveElement exposes methods and properties of general use
applicable to most kinds of curves.

### `M:Autodesk.Revit.DB.CurveByPointsUtils.CreateArcThroughPoints(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ReferencePoint,Autodesk.Revit.DB.ReferencePoint,Autodesk.Revit.DB.ReferencePoint)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsUtils.CreateArcThroughPoints(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ReferencePoint,Autodesk.Revit.DB.ReferencePoint,Autodesk.Revit.DB.ReferencePoint)`

#### Summary

Creates an arc through the given reference points.

#### Remarks

The interiorPoint determines the orientation of the arc while startPoint and endPoint determine
the angle parameters at the ends.

#### Parameter `document`

The Document.

#### Parameter `startPoint`

The start point of the arc.

#### Parameter `endPoint`

The end end of the arc.

#### Parameter `interiorPoint`

The interior point on the arc.

#### Returns

The CurveElement to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Can't create an arc from the given points

#### Since

2014

### `M:Autodesk.Revit.DB.CurveByPointsUtils.CreateRectangle(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ReferencePoint,Autodesk.Revit.DB.ReferencePoint,Autodesk.Revit.DB.CurveProjectionType,System.Boolean,System.Boolean,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId}@,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsUtils.CreateRectangle(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ReferencePoint,Autodesk.Revit.DB.ReferencePoint,Autodesk.Revit.DB.CurveProjectionType,System.Boolean,System.Boolean,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId}@,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId}@)`

#### Summary

Creates rectangle on face or sketchplane for two given diagonal points.

#### Remarks

This array contains the ElementIds of the two additional corner points that are created to complete the rectangle.

#### Parameter `document`

The Document.

#### Parameter `startPoint`

First diagonal point of rectangle.

#### Parameter `endPoint`

Second diagonal point of rectangle.

#### Parameter `projectionType`

Projection type of rectangle's boundary curves.
If the rectangle input points are Face hosted, and CurveProjectionType::ParallelToLevel is requested,
and the Face normal at the location of the start point is at a less than 45 degree angle with the level
planes, then the projectionType will be set to FromTopDown, even if ParallelToLevel was requested.

#### Parameter `boundaryReferenceLines`

True if rectangle's boundary curves should be reference lines, false otherwise.

#### Parameter `boundaryCurvesFollowSurface`

True if rectangle's boundary curves should follow surface, false otherwise.

#### Parameter `createdCurvesIds`

Created rectangle's boundary curves ids.

#### Parameter `createdCornersIds`

Ids of two newly created corner points.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Unexpected projection type.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Unable to create rectangle.

#### Since

2012

### `M:Autodesk.Revit.DB.CurveByPointsUtils.GetFaceRegions(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsUtils.GetFaceRegions(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

#### Summary

Gets the FaceRegions in the existing face.

#### Parameter `cda`

The Document.

#### Parameter `referenceOfFace`

The Reference of the existing face.

#### Returns

The FaceRegions in the existing face, or an empty collection if no FaceRegions are found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The Reference is not a Face Reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.CurveByPointsUtils.GetHostFace(Autodesk.Revit.DB.CurveElement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsUtils.GetHostFace(Autodesk.Revit.DB.CurveElement)`

#### Summary

Gets the host face to which the CurveElement is added.

#### Parameter `curveElem`

The CurveElement.

#### Returns

The host face to which the CurveElement is added, or an empty Reference if the host is not a face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input CurveElement is not a CurveByPoints.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.CurveByPointsUtils.AddCurvesToFaceRegion(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsUtils.AddCurvesToFaceRegion(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Adds The CurveElements to one or more FaceRegions.

#### Remarks

The CurveElements that are input may produce an arbitrary number of regions.

#### Parameter `document`

The Document.

#### Parameter `curveElemIds`

The ElementIds of CurveElements which are to define the FaceRegion.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

All the input CurveElements must be CurveByPoints, with the sketchOnSurface attribute set to True, and for each CurveElement, the defining
ReferencePoints must be hosted on References related to a common Face or Edge.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to add curves to FaceRegion.

#### Since

2012

### `M:Autodesk.Revit.DB.CurveByPointsUtils.ValidateCurveElementIdArrayForFaceRegions(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsUtils.ValidateCurveElementIdArrayForFaceRegions(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Validates that the input CurveElements can define FaceRegions.
The CurveElements must be CurveByPoints. Each curve must be entirely hosted by a single Face or hosts related to a common
Face (for example, Edges of a common Face, other CurveElements hosted by a common Face). To be added to the FaceRegion definition,
a CurveElement must have the SketchOnSurface attribute set.

#### Parameter `document`

The Document.

#### Parameter `curveElemIds`

The CurveElements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.CurveByPointsUtils.SetSketchOnSurface(Autodesk.Revit.DB.CurveElement,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsUtils.SetSketchOnSurface(Autodesk.Revit.DB.CurveElement,System.Boolean)`

#### Summary

Sets the relationship between the CurveElement and face.

#### Parameter `curveElem`

The CurveElement.

#### Parameter `sketchOnSurface`

Whether or not the CurveElement should lie on the face and be able to be added to the face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input CurveElement is not a CurveByPoints.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.CurveByPointsUtils.GetSketchOnSurface(Autodesk.Revit.DB.CurveElement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsUtils.GetSketchOnSurface(Autodesk.Revit.DB.CurveElement)`

#### Summary

Gets the relationship between the CurveElement and face.

#### Parameter `curveElem`

The CurveElement.

#### Returns

Whether or not the CurveElement should lie on the face and be able to be added to the face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input CurveElement is not a CurveByPoints.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.CurveByPointsUtils.SetProjectionType(Autodesk.Revit.DB.CurveElement,Autodesk.Revit.DB.CurveProjectionType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsUtils.SetProjectionType(Autodesk.Revit.DB.CurveElement,Autodesk.Revit.DB.CurveProjectionType)`

#### Summary

Sets the projection type of the CurveElement.

#### Parameter `curveElem`

The CurveElement.

#### Parameter `value`

The input projection type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input CurveElement is not a CurveByPoints.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.CurveByPointsUtils.GetProjectionType(Autodesk.Revit.DB.CurveElement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsUtils.GetProjectionType(Autodesk.Revit.DB.CurveElement)`

#### Summary

Gets the projection type of the CurveElement.

#### Parameter `curveElem`

The CurveElement.

#### Returns

The projection type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input CurveElement is not a CurveByPoints.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.CurveByPointsUtils.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveByPointsUtils.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.CurveByPointsUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveByPointsUtils`

#### Summary

A static class that contains methods for processing curves driven by points.

#### Since

2012

### `T:Autodesk.Revit.DB.CurveProjectionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveProjectionType`

#### Summary

This attribute indicates how the curve will be projected to the surface if the curve is sketched on the surface.

#### Since

2011

### `F:Autodesk.Revit.DB.CurveProjectionType.FollowSurfaceUV`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveProjectionType.FollowSurfaceUV`

#### Summary

The curve is generated on to lie on the surface based on its endpoints/control points on the surface, its curve type, and depending on the surface type,
either projecting to the surface based on projecting tessellation points of the curve to the target surface,
or by interpreting the equation produced by the curve type and user defined control points in the surface uv.
In some ways, this is the most robust way to generate the curve on the surface,
but for some surface shapes, it can make it difficult to obtain the desired appearance from a particular perspective in the model.

### `F:Autodesk.Revit.DB.CurveProjectionType.ParallelToLevel`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveProjectionType.ParallelToLevel`

#### Summary

The curves are projected to their target surface in a projection direction that is parallel to level.
The exact vector of projection also considers the endpoints of the curve being projected or endpoints in a loop of curves it belongs to (if any).
But the vector is always parallel to the level.
This is used to create curves on the building that retain a particular sketched shape based on elevation perspective,
regardless of target surface contours.
Sketching windows is an example where this is useful.

### `F:Autodesk.Revit.DB.CurveProjectionType.FromTopDown`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveProjectionType.FromTopDown`

#### Summary

Projects curve in a direction parallel to the height of the project or family (projects in an upwardly or downwardly direction).
For example, would be used to project curves to a surface that represented a roof or site,
where the goal was for the curves to look from above as they were sketched,
even though they are being mapped to the surface.

### `M:Autodesk.Revit.DB.InternalOrigin.Get(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InternalOrigin.Get(Autodesk.Revit.DB.Document)`

#### Summary

Gets the internal origin for the document.

#### Parameter `document`

Revit document from which to get the internal origin.

#### Returns

The internal origin of the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020.2

### `P:Autodesk.Revit.DB.InternalOrigin.SharedPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.InternalOrigin.SharedPosition`

#### Summary

The position of the InternalOrigin relative to the active ProjectLocation set for the document.

#### Since

2020.2

### `P:Autodesk.Revit.DB.InternalOrigin.Position`

Member kind: property
Symbol: `Autodesk.Revit.DB.InternalOrigin.Position`

#### Summary

The position of the InternalOrigin.

#### Since

2020.2

### `T:Autodesk.Revit.DB.InternalOrigin`

Member kind: type
Symbol: `Autodesk.Revit.DB.InternalOrigin`

#### Summary

A class representing the origin of internal coordinate system.
Each Revit project contains one InternalOrigin.

#### Remarks

The internal origin cannot be selected (e.g. as a reference) nor can it be modified.

#### Since

2020.2

### `P:Autodesk.Revit.DB.ContourSettingItem.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ContourSettingItem.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ContourSettingItem.SubCategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ContourSettingItem.SubCategoryId`

#### Summary

The contour line style subcategory id.

#### Since

2024

### `P:Autodesk.Revit.DB.ContourSettingItem.Step`

Member kind: property
Symbol: `Autodesk.Revit.DB.ContourSettingItem.Step`

#### Summary

The increment elevation of the contour range.

#### Since

2024

### `P:Autodesk.Revit.DB.ContourSettingItem.Stop`

Member kind: property
Symbol: `Autodesk.Revit.DB.ContourSettingItem.Stop`

#### Summary

The contour range stop elevation.

#### Since

2024

### `P:Autodesk.Revit.DB.ContourSettingItem.Start`

Member kind: property
Symbol: `Autodesk.Revit.DB.ContourSettingItem.Start`

#### Summary

The contour range start elevation.

#### Since

2024

### `T:Autodesk.Revit.DB.ContourSettingItem`

Member kind: type
Symbol: `Autodesk.Revit.DB.ContourSettingItem`

#### Summary

Contour setting item that stores the information of a single contour or a set of contours.

#### Since

2024

### `M:Autodesk.Revit.DB.ContourSetting.GetContourSettingItems`

Member kind: method
Symbol: `Autodesk.Revit.DB.ContourSetting.GetContourSettingItems`

#### Summary

Get all contour setting items.

#### Returns

An array of contour setting items.

#### Since

2024

### `M:Autodesk.Revit.DB.ContourSetting.EnableItem(Autodesk.Revit.DB.ContourSettingItem)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ContourSetting.EnableItem(Autodesk.Revit.DB.ContourSettingItem)`

#### Summary

Enable a contour setting item of the current contour setting so that the item will be used to draw contours.

#### Remarks

Contour setting will not be changed if the item could not be found.

#### Parameter `item`

The contour setting item to be enabled.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.ContourSetting.DisableItem(Autodesk.Revit.DB.ContourSettingItem)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ContourSetting.DisableItem(Autodesk.Revit.DB.ContourSettingItem)`

#### Summary

Disable a contour setting item of the current contour setting so that the item will not be used to draw contours.

#### Remarks

Contour setting will not be changed if the item could not be found.

#### Parameter `item`

The contour setting item to be disabled.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.ContourSetting.RemoveItem(Autodesk.Revit.DB.ContourSettingItem)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ContourSetting.RemoveItem(Autodesk.Revit.DB.ContourSettingItem)`

#### Summary

Remove a contour setting item from the current contour setting.

#### Remarks

Contour setting will not be changed if the item could not be found.

#### Parameter `item`

The contour setting item to be removed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.ContourSetting.GetItemIndex(Autodesk.Revit.DB.ContourSettingItem)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ContourSetting.GetItemIndex(Autodesk.Revit.DB.ContourSettingItem)`

#### Summary

Get the index of a contour setting item of the current contour setting

#### Parameter `item`

The contour setting item.

#### Returns

The index of the input contour setting item.
-1 if the item is not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.ContourSetting.AddContourRange(System.Double,System.Double,System.Double,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ContourSetting.AddContourRange(System.Double,System.Double,System.Double,Autodesk.Revit.DB.ElementId)`

#### Summary

Add a set of contours as a contour setting item to the current contour setting.

#### Parameter `start`

The contour range start elevation.

#### Parameter `stop`

The contour range stop elevation.
Should be greater than start elevation.

#### Parameter `step`

The increment elevation of the contour range.
Should be greater than zero.

#### Parameter `subcategoryId`

The contour line style subcategory id.

#### Returns

The newly added contour setting item.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for start is not finite
-or-
The given value for stop is not finite
-or-
The given value for step is not finite
-or-
The input subcategory id is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The input contour spacing information is not valid.

#### Since

2024

### `M:Autodesk.Revit.DB.ContourSetting.AddSingleContour(System.Double,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ContourSetting.AddSingleContour(System.Double,Autodesk.Revit.DB.ElementId)`

#### Summary

Add a single contour as a contour setting item to the current contour setting.

#### Parameter `elevation`

The contour elevation.

#### Parameter `subcategoryId`

The contour line style subcategory id.

#### Returns

The newly added contour setting item.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for elevation is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.ContourSetting.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ContourSetting.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ContourSetting`

Member kind: type
Symbol: `Autodesk.Revit.DB.ContourSetting`

#### Summary

Contour setting object that handles the contour information used to draw contours on elements.

#### Since

2024

### `M:Autodesk.Revit.DB.ConicalSurface.IsValidConeAngle(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConicalSurface.IsValidConeAngle(System.Double)`

#### Summary

Checks whether the input value lies is not 0, greater than -PI/2 and lesser than PI/2.

#### Parameter `halfAngle`

Cone half-angle parameter.

#### Returns

True if input is not 0, lesser than PI/2 and greater than -PI/2, false otherwise.

#### Since

2017

### `M:Autodesk.Revit.DB.ConicalSurface.GetFrameOfReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConicalSurface.GetFrameOfReference`

#### Summary

Returns frame of reference associated with this ConicalSurface.

#### Remarks

This is an equivalent of new Frame(Origin, XDir, YDir, Axis).

#### Returns

Frame of reference associated with this ConicalSurface.

#### Since

2017

### `M:Autodesk.Revit.DB.ConicalSurface.Create(Autodesk.Revit.DB.Frame,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConicalSurface.Create(Autodesk.Revit.DB.Frame,System.Double)`

#### Summary

Creates a conical surface defined by a local reference frame and a half angle.

#### Remarks

The parametric equation of the cone is S(u, v) = Frame.Origin + v*[sin(halfAngle)(cos(u)*Frame.BasisX + sin(u)*Frame.BasisY) + cos(halfAngle)*Frame.BasisZ]
This implies the following facts:
Frame.BasisX points from the axis point to the point on the cylinder with coordinates (0, 0).

Frame.BasisY points in the direction of the partial derivative dS/du at (0, 0).

Frame.BasisZ points in the direction of the partial derivative dS/dv at (0, 0).
Only the branch of the cone with v >= 0 should be used.

#### Parameter `frameOfReference`

frameOfReference is an orthonormal frame that defines a local coordinate system for the cone.
Frame.Origin is a point on the cylinder's axis.

Frame.BasisZ points along the axis, while Frame.BasisX and Frame.BasisY are orthogonal to the axis.

The frame may be either left-handed or right-handed (see Frame.IsRightHanded). Note that
the "handedness" of the frame does not, by itself, determine the surface's orientation.

#### Parameter `halfAngle`

Cone angle. Must be not 0, lesser than PI/2 and greater than -PI/2.

#### Returns

The created ConicalSurface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This Frame object may not be used as a local frame of reference.
-or-
The supplied value must be not 0, lesser than PI/2 and greater than -PI/2.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.ConicalSurface.HalfAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConicalSurface.HalfAngle`

#### Summary

Cone angle.

#### Since

2017

### `P:Autodesk.Revit.DB.ConicalSurface.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConicalSurface.Origin`

#### Summary

Apex of the cone. This is the origin of the local coordinate system associated with this cone.

#### Since

2017

### `P:Autodesk.Revit.DB.ConicalSurface.YDir`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConicalSurface.YDir`

#### Summary

X axis of the local coordinate system associated with this cone.

#### Since

2017

### `P:Autodesk.Revit.DB.ConicalSurface.XDir`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConicalSurface.XDir`

#### Summary

X axis of the local coordinate system associated with this cone.

#### Since

2017

### `P:Autodesk.Revit.DB.ConicalSurface.Axis`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConicalSurface.Axis`

#### Summary

Axis of the cone. This is the Z axis of the local coordinate system associated with this cone.

#### Since

2017

### `T:Autodesk.Revit.DB.ConicalSurface`

Member kind: type
Symbol: `Autodesk.Revit.DB.ConicalSurface`

#### Summary

A Conical Surface.

#### Remarks

The parametric equation of the cone is S(u, v) = center + v*[sin(halfAngle)(cos(u)*xVec + sin(u)*yVec) + cos(halfAngle)*zVec]. Only the branch of the cone with v >= 0 should be used.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitType.IsWithFitting`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitType.IsWithFitting`

#### Summary

Whether this conduit type is with fitting

#### Remarks

True if this conduit type is with fitting type.

### `T:Autodesk.Revit.DB.Electrical.ConduitType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ConduitType`

#### Summary

This class represents a conduit type in Autodesk Revit.

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettings.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettings.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettings.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettings.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettings.GetConduitSizeSettingsIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettings.GetConduitSizeSettingsIterator`

#### Summary

Returns a ConduitSizeSettingIterator to the conduit size settings.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettings.RemoveConduitStandardType(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettings.RemoveConduitStandardType(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Erases the existing ConduitSizes with this conduit standard name; the consuit standard type can not be removed if it is in use.

#### Parameter `pADoc`

The document.

#### Parameter `standardName`

The conduit standard name.

#### Returns

True if removing success; otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The conduit standard is already in use.
-or-
The conduit standard is the last one.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettings.DoesConduitStandardTypeExist(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettings.DoesConduitStandardTypeExist(System.String)`

#### Summary

Checks if the specified conduit standard exist.

#### Parameter `standardName`

The conduit standard name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettings.CreateConduitStandardTypeFromExisingStandardType(Autodesk.Revit.DB.Document,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettings.CreateConduitStandardTypeFromExisingStandardType(Autodesk.Revit.DB.Document,System.String,System.String)`

#### Summary

Creates one conduit standard type with the new name and assign the conduit sizes to it from the existing standard type.

#### Parameter `pADoc`

The document.

#### Parameter `newStandardName`

The new conduit standard name.

#### Parameter `existingStandardName`

The existing conduit standard name.

#### Returns

True if creating success; otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The conduit standard name already exists.
-or-
The conduit standard name does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettings.RemoveSize(System.String,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettings.RemoveSize(System.String,System.Double)`

#### Summary

Erase the existing ConduitSize with this nominal diameter. The conduit standard name determines the location of the size in the size table.

#### Remarks

Does nothing if there is no existing ConduitSize with this nominal diameter.

#### Parameter `standardName`

The conduit standard name.

#### Parameter `nominalDiameter`

Nominal diameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for nominalDiameter must be greater than 0 and no more than 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The function is called during iterating the size set.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettings.AddSize(System.String,Autodesk.Revit.DB.Electrical.ConduitSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettings.AddSize(System.String,Autodesk.Revit.DB.Electrical.ConduitSize)`

#### Summary

Inserts a new ConduitSize in to the conduit size settings. The conduit standard name determines the location of the new size in the size table.

#### Parameter `standardName`

The conduit standard name.

#### Parameter `sizeInfo`

The new ConduitSize to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The conduit standard name does not exist.
-or-
The conduit size already exists.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The function is called during iterating the size set.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettings.GetSizeCount(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettings.GetSizeCount(System.String)`

#### Summary

Gets the size count of the conduit size table. The conduit standard name the location of the size in the size table.

#### Parameter `standardName`

The conduit standard name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettings.GetConduitSizeSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettings.GetConduitSizeSettings(Autodesk.Revit.DB.Document)`

#### Summary

Gets the conduit size settings of the project.

#### Parameter `aDoc`

The document.

#### Returns

The conduit size settings of the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.Electrical.ConduitSizeSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettings`

#### Summary

Conduit sizes settings

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.CurrentObject`

### `P:Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.GetValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.GetValue`

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.GetKey`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.GetKey`

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.HasCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.HasCurrent`

#### Summary

Identifies whether the iterator has a current item.
There is no current item if the iterator has not started yet or has been done.

#### Returns

True if there is a current item.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.MoveNext`

#### Summary

Increments the enumerator to the next item.

#### Returns

True if there is a next available item in this enumerator.
False if the enumerator has completed all available items.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator`

#### Summary

An iterator to a set of items from ConduitSizeSettings. Each item is a KeyValuePair(System::String^, ConduitSizes).
ElementId is the id of the conduit standard type.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizes.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizes.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Electrical.ConduitSizes.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizes.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Electrical.ConduitSizes.GetConduitSizesIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizes.GetConduitSizesIterator`

#### Summary

Returns a ConduitSizeIterator to the conduit sizes.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizes.Contains(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizes.Contains(System.Double)`

#### Summary

Checks whether a conduit size with the nominal diameter exists.

#### Parameter `nominalDiameter`

Nominal diameter.

#### Returns

True if a conduit size with the nominal diameter exists.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for nominalDiameter must be greater than 0 and no more than 30000 feet.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSizes.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizes.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Electrical.ConduitSizes.Count`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizes.Count`

#### Summary

Count of the items contained in the collection.

#### Since

2017

### `T:Autodesk.Revit.DB.Electrical.ConduitSizes`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizes`

#### Summary

Class ConduitSizeSet being used to store the conduit sizes.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSizeIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeIterator.CurrentObject`

### `P:Autodesk.Revit.DB.Electrical.ConduitSizeIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeIterator.HasCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeIterator.HasCurrent`

#### Summary

Identifies if the iterator has a current item.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Returns

True if there is a current item.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeIterator.GetCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeIterator.GetCurrent`

#### Summary

Returns the current ConduitSize.

#### Returns

The current ConduitSize.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSizeIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeIterator.MoveNext`

#### Summary

Increments the iterator to the next item.

#### Returns

True if there is a next available item in this iterator.
False if the iterator has completed all available items.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSizeIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Electrical.ConduitSizeIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSizeIterator`

#### Summary

An iterator to a set of conduit sizes from ConduitSizes.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSize.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSize.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Electrical.ConduitSize.UsedInSizing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSize.UsedInSizing`

#### Summary

Whether is used in sizing.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSize.UsedInSizeLists`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSize.UsedInSizeLists`

#### Summary

Whether it is used in size lists.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSize.BendRadius`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSize.BendRadius`

#### Summary

Minimum bend radius

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSize.OuterDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSize.OuterDiameter`

#### Summary

Outer diameter

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSize.InnerDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSize.InnerDiameter`

#### Summary

Inner diameter

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSize.NominalDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSize.NominalDiameter`

#### Summary

Nominal diameter

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSize.#ctor(System.Double,System.Double,System.Double,System.Double,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSize.#ctor(System.Double,System.Double,System.Double,System.Double,System.Boolean,System.Boolean)`

#### Summary

Constructs an object that stores the basic size information for conduit.

#### Parameter `nominalDiameter`

Nominal diameter. The value should be a valid, positive Revit length.

#### Parameter `innerDiameter`

Inner diameter. The value should be a valid, positive Revit length.

#### Parameter `outerDiameter`

Outer diameter. The value should be a valid, positive Revit length.

#### Parameter `bendRadius`

Minimum bend radius. The value should be a valid, positive Revit length.

#### Parameter `usedInSizeLists`

Whether it is used in size lists.

#### Parameter `usedInSizing`

Whether is used in sizing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for nominalDiameter must be greater than 0 and no more than 30000 feet.
-or-
The given value for innerDiameter must be greater than 0 and no more than 30000 feet.
-or-
The given value for outerDiameter must be greater than 0 and no more than 30000 feet.
-or-
The given value for bendRadius must be greater than 0 and no more than 30000 feet.

#### Since

2017

### `T:Autodesk.Revit.DB.Electrical.ConduitSize`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSize`

#### Summary

Stores the basic size information for a conduit.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.ConduitSettings.GetConduitSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSettings.GetConduitSettings(Autodesk.Revit.DB.Document)`

#### Summary

Gets the conduit settings of the project.

#### Parameter `document`

The document.

#### Returns

The conduit settings of the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSettings.UseAnnotationScaleForSingleLineFittings`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSettings.UseAnnotationScaleForSingleLineFittings`

#### Summary

Indicates whether use annotation scale for single line fittings or not.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSettings.RiseDropAnnotationSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSettings.RiseDropAnnotationSize`

#### Summary

The rise drop annotation size.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for riseDropAnnotationSize must be between 0 and 30000 feet.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSettings.FittingAnnotationSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSettings.FittingAnnotationSize`

#### Summary

The value of fitting annotation size.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for fittingAnnotationSize must be between 0 and 30000 feet.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSettings.ConnectorSeparator`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSettings.ConnectorSeparator`

#### Summary

The conduit connector separator string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSettings.SizePrefix`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSettings.SizePrefix`

#### Summary

The conduit size prefix string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ConduitSettings.SizeSuffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSettings.SizeSuffix`

#### Summary

The conduit size suffix string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.Electrical.ConduitSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ConduitSettings`

#### Summary

The conduit settings.

#### Since

2017

### `T:Autodesk.Revit.DB.Electrical.ConduitRun`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ConduitRun`

#### Summary

This class represents a conduit run in Autodesk Revit.

#### Remarks

This class is mainly for calculating length of a conduit run.
A conduit run contains connected straight conduit segments and bends between the straight segments with same type and size.

### `M:Autodesk.Revit.DB.Electrical.Conduit.IsValidConduitType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.Conduit.IsValidConduitType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if a conduit type is valid.

#### Parameter `document`

The document.

#### Parameter `conduitType`

The conduit type.

#### Returns

True if the conduit type is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Electrical.Conduit.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.Conduit.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of conduit.

#### Remarks

This method will regenerate the document.

#### Parameter `document`

The document.

#### Parameter `conduitType`

The conduit type. This must be a conduit type accepted by isValidConduitType().
If the input conduit type is InvalidElementId, the default conduit type from the document will be used.

#### Parameter `startPoint`

The start point of the conduit location line.

#### Parameter `endPoint`

The end point of the conduit location line.

#### Parameter `levelId`

The element id of the level which this conduit based.
If the input level id is invalidElementId = -1, the nearest level will be used.

#### Returns

The newly created conduit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This conduit type is invalid.
-or-
This level id is invalid.
-or-
The points of startPoint and endPoint are too close: for MEPCurve, the minimum length is 1/10 inch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

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

### `T:Autodesk.Revit.DB.Electrical.Conduit`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.Conduit`

#### Summary

This class represents a conduit in Autodesk Revit.

### `P:Autodesk.Revit.DB.Visual.Concrete.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Concrete.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "Concrete" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Concrete.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Concrete.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "Concrete" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Concrete.ConcreteBmMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Concrete.ConcreteBmMap`

#### Summary

The property labeled "Image" from the "Concrete" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Concrete.ConcreteBrightmode`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Concrete.ConcreteBrightmode`

#### Summary

The property labeled "Weathering" from the "Concrete" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "ConcreteBrightmodeType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Concrete.ConcreteBumpAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Concrete.ConcreteBumpAmount`

#### Summary

The property labeled "Amount" from the "Concrete" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 2".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Concrete.ConcreteBumpMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Concrete.ConcreteBumpMap`

#### Summary

The property labeled "Image" from the "Concrete" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Concrete.ConcreteFinish`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Concrete.ConcreteFinish`

#### Summary

The property labeled "Type" from the "Concrete" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "ConcreteFinishType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Concrete.ConcreteSealant`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Concrete.ConcreteSealant`

#### Summary

The property labeled "Sealant" from the "Concrete" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "ConcreteSealantType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Concrete.ConcreteColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Concrete.ConcreteColor`

#### Summary

The property labeled "Color" from the "Concrete" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Concrete`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Concrete`

#### Summary

A static class that provides access to the property names that appear in the Concrete visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Analysis.ConceptualSurfaceType.GetConstructionTypeIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualSurfaceType.GetConstructionTypeIds`

#### Summary

The element ids of the ConceptualConstructionType's associated with this ConceptualSurfaceType.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualSurfaceType.GetAllMassSubCategoryIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualSurfaceType.GetAllMassSubCategoryIds`

#### Summary

Get all the mass subcategory ids for which there are ConceptualSurfaceType's.

#### Returns

Returns an array of element id of mass subcategories for which there are ConceptualSurfaceType's.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualSurfaceType.GetByMassSubCategoryId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualSurfaceType.GetByMassSubCategoryId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Get the ConceptualSurfaceType by its mass subcategory id.

#### Parameter `cda`

The document.

#### Parameter `massSubCategoryId`

The mass subcategory id to get the ConceptualSurfaceType for.

#### Returns

Returns ConceptualSurfaceType associated with input id or NULL.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The mass sub-category is none of the
OST_MassInteriorWall,
OST_MassExteriorWall,
OST_MassExteriorWallUnderground,
OST_MassRoof,
OST_MassFloor,
OST_MassSlab,
OST_MassShade,
OST_MassGlazing,
OST_MassSkylights,
or OST_MassOpening.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.ConceptualSurfaceType.DefaultConstructionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualSurfaceType.DefaultConstructionTypeId`

#### Summary

The element id of the user specified ConceptualConstructionType to be used by default on creation for mass faces of this mass subcategory.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input element is not a constructionType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.ConceptualSurfaceType.MassSubCategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualSurfaceType.MassSubCategoryId`

#### Summary

The mass subcategory id of the ConceptualSurfaceType.

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.ConceptualSurfaceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualSurfaceType`

#### Summary

This element represents a conceptual BIM object category to assign to faces in Mass geometries.
There is one ConceptualSurfaceType element for each of the Mass Surface Subcategories.
for serialization

#### Remarks

When Conceptual Energy Analysis is enabled in Revit Projects, massing faces will be assigned
to the subcategories of Mass category that these ConceptualSurfaceType's are associated with.
A default ConceptualConstructionType is associated with the ConceptualSurfaceType. This
default ConceptualConstructionType is assigned to Mass faces with the corresponding subcategory.
Changing the default ConceptualConstructionType associated with the ConceptualSurfaceType
will update the ConceptualConstruction type for all Mass faces of that subcategory which the
user has not specifically provided an override value for.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.IsValidSubcategoryForMassSurfaceDatas(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.IsValidSubcategoryForMassSurfaceDatas(Autodesk.Revit.DB.ElementId)`

#### Summary

Validate if a subcategory is appropriate for assignment to Massing surfaces (MassSurfaceData).
This is the list of acceptable values:
OST_MassInteriorWall

OST_MassExteriorWall

OST_MassExteriorWallUnderground

OST_MassRoof

OST_MassFloor

OST_MassSlab

OST_MassShade

OST_MassGlazing

OST_MassSkylights

OST_MassOpening

#### Remarks

This excludes sub-categories which are not actually sub-categories that
can be assigned to surfaces, such as OST_MassWallsAll for example.

#### Parameter `massSubCategoryId`

The mass sub-category to be checked.

#### Returns

True if the mass sub-category falls within the list, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetGBSId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetGBSId(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the Green Building Studio identifier associated with the construction.

#### Remarks

Sometimes the GBSId is different for the same ConceptualConstructionType depending on the
mass subcategory it is related to. This is usually the case, for example, for window and skylight
constructions, which do not share GBSid's even when they share ConceptualConstructionTypes.

#### Parameter `massSurfaceSubCategoryId`

The ElementId of a valid Mass subcategory of a MassSurfaceData.

#### Returns

Returns the integer id used to represent the ConceptualConstructionType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input Element massSurfaceSubCategoryId is not a valid subcategory value for MassSurfaceData.
-or-
The ElementId massSurfaceSubCategoryId is not appropriate for this ConceptualConstructionType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.IsValidConceptualConstructionIdForCategory(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.IsValidConceptualConstructionIdForCategory(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Indicate if a ConceptualConstruction is appropriate to assign to a MassSurfaceData of a particular Mass subcategory.

#### Parameter `ccda`

The document.

#### Parameter `constructionTypeId`

The ElementId of the ConceptualConstructionType.

#### Parameter `massSubcategoryId`

The ElementId of the Mass subcategory.

#### Returns

Returns true if valid, false otherwise

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId constructionTypeId is not an id of a ConceptualConstructionType.
-or-
The mass sub-category is none of the
OST_MassInteriorWall,
OST_MassExteriorWall,
OST_MassExteriorWallUnderground,
OST_MassWallsAll,
OST_MassRoof,
OST_MassFloor,
OST_MassSlab,
OST_MassFloorsAll,
OST_MassShade,
OST_MassGlazing,
OST_MassSkylights,
OST_MassGlazingAll
or OST_MassOpening.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.IsValidSurfaceSubcategoryForConstruction(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.IsValidSurfaceSubcategoryForConstruction(Autodesk.Revit.DB.ElementId)`

#### Summary

Indicates if this ConceptualConstructionType is appropriate for the input MassSurfaceData subcategory.

#### Parameter `massSurfaceSubcategoryId`

The ElementId of a Mass subcategory of a MassSurfaceData.

#### Returns

Returns true if appropriate for the input subcategory, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input Element massSurfaceSubcategoryId is not a valid subcategory value for MassSurfaceData.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.IsValidConceptualConstructionId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.IsValidConceptualConstructionId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Indicates if the ElementId is an id of a ConceptualConstructionType.

#### Parameter `ccda`

The document.

#### Parameter `constructionTypeId`

The ElementId of the ConceptualConstructionType.

#### Returns

Returns true if is an id of a ConceptualConstructionType, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetAllConceptualConstructionsForCategory(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetAllConceptualConstructionsForCategory(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Get all the ids of constructions applicable to the input massSubCategory

#### Parameter `ccda`

The document.

#### Parameter `massSubCategoryId`

The ElementId of the mass subcategory.

#### Returns

Returns a set of ElementIds that for the ConceptualConstructionTypes that are appropriate for the subcategory.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The mass sub-category is none of the
OST_MassInteriorWall,
OST_MassExteriorWall,
OST_MassExteriorWallUnderground,
OST_MassWallsAll,
OST_MassRoof,
OST_MassFloor,
OST_MassSlab,
OST_MassFloorsAll,
OST_MassShade,
OST_MassGlazing,
OST_MassSkylights,
OST_MassGlazingAll
or OST_MassOpening.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetOpeningConstructionType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.ConceptualConstructionOpeningType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetOpeningConstructionType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.ConceptualConstructionOpeningType)`

#### Summary

Get an Opening ConceptualConstructionType by its ConceptualConstructionOpeningType.

#### Parameter `ccda`

The Document.

#### Parameter `typeEnum`

The ConceptualConstructionOpeningType to get the ConceptualConstructionType for.

#### Returns

Returns ElementId of a ConceptualConstructionType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The enum is invalid for ConceptualConstructionOpeningType.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetShadeConstructionType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.ConceptualConstructionShadeType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetShadeConstructionType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.ConceptualConstructionShadeType)`

#### Summary

Get a Shade ConceptualConstructionType by its ConceptualConstructionShadeType.

#### Parameter `ccda`

The Document.

#### Parameter `typeEnum`

The ConceptualConstructionShadeType to get the ConceptualConstructionType for.

#### Returns

Returns ElementId of a ConceptualConstructionType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The enum is invalid for ConceptualConstructionShadeType.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetWindowOrSkylightConstructionType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetWindowOrSkylightConstructionType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType)`

#### Summary

Get a Window or Skylight ConceptualConstructionType by its ConceptualConstructionWindowSkylightType.

#### Parameter `ccda`

The Document.

#### Parameter `typeEnum`

The ConceptualConstructionWindowSkylightType to get the ConceptualConstructionType for.

#### Returns

Returns ElementId of a ConceptualConstructionType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The enum is invalid for ConceptualConstructionWindowSkylightType.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetFloorOrSlabConstructionType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetFloorOrSlabConstructionType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType)`

#### Summary

Get a Floor or Slab ConceptualConstructionType by its ConceptualConstructionFloorSlabType.

#### Parameter `ccda`

The Document.

#### Parameter `typeEnum`

The ConceptualConstructionFloorSlabType to get the ConceptualConstructionType for.

#### Returns

Returns ElementId of a ConceptualConstructionType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The enum is invalid for ConceptualConstructionFloorSlabType.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetRoofConstructionType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetRoofConstructionType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType)`

#### Summary

Get a Roof ConceptualConstructionType by its ConceptualConstructionRoofType.

#### Parameter `ccda`

The Document.

#### Parameter `typeEnum`

The ConceptualConstructionRoofType to get the ConceptualConstructionType for.

#### Returns

Returns ElementId of a ConceptualConstructionType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The enum is invalid for ConceptualConstructionRoofType.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetWallConstructionType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.GetWallConstructionType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType)`

#### Summary

Get a Wall ConceptualConstructionType by its ConceptualConstructionWallType.

#### Parameter `ccda`

The Document.

#### Parameter `typeEnum`

The ConceptualConstructionWallType to get the ConceptualConstructionType for.

#### Returns

Returns ElementId of a ConceptualConstructionType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The enum is invalid for ConceptualConstructionWallType.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.MassSurfaceSubCategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.MassSurfaceSubCategoryId`

#### Summary

The surface type subcategory element id associated with the ConceptualConstructionType.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.ConceptualConstructionType.MaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType.MaterialId`

#### Summary

Material used for visualization of this construction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input element materialId is not a material element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.ConceptualConstructionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionType`

#### Summary

This element is used to describe the conceptual physical, construction, and energy properties in a manner
that can be understood by both the Revit BIM model and Green Building Studio/Green Building XML.
For serialization

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.ConceptualConstructionOpeningType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionOpeningType`

#### Summary

ConceptualConstructionType values for Openings.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionOpeningType.NumOpeningTypeConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionOpeningType.NumOpeningTypeConstruction`

#### Summary

Total Number of Opening Type Constructions

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionOpeningType.Air`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionOpeningType.Air`

#### Summary

Air Opening

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionOpeningType.InvalidOpeningTypeConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionOpeningType.InvalidOpeningTypeConstruction`

#### Summary

Invalid value/not set Opening Type Construction

### `T:Autodesk.Revit.DB.Analysis.ConceptualConstructionShadeType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionShadeType`

#### Summary

ConceptualConstructionType values for Shades.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionShadeType.NumShadeTypeConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionShadeType.NumShadeTypeConstruction`

#### Summary

Total Number of Shade Type Constructions

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionShadeType.BasicShade`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionShadeType.BasicShade`

#### Summary

Basic Shade

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionShadeType.InvalidShadeTypeConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionShadeType.InvalidShadeTypeConstruction`

#### Summary

Invalid value/not set Shade Type Construction

### `T:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType`

#### Summary

ConceptualConstructionType values for Windows and Skylights

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.NumWindowSkylightTypeConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.NumWindowSkylightTypeConstruction`

#### Summary

Total Number of Window or Skylight Type Constructions

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.QuadPaneClearLowEHotOrColdClimate`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.QuadPaneClearLowEHotOrColdClimate`

#### Summary

Quad Pane Clear Low Energy Hot Or Cold Climate Window or Skylight

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.TriplePaneClearLowEHotOrColdClimate`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.TriplePaneClearLowEHotOrColdClimate`

#### Summary

Triple Pane Clear Low Energy Hot or Cold Climate Window or Skylight

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.DoublePaneClearHighestPerformanceLowEHighVisTransLowSHGC`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.DoublePaneClearHighestPerformanceLowEHighVisTransLowSHGC`

#### Summary

Double Pane Clear Highest Performance Low Window or Skylight

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.DoublePaneClearLowEHotClimateLowSHGC`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.DoublePaneClearLowEHotClimateLowSHGC`

#### Summary

Double Pane Clear Low Energy Hot Climate Low Solar Heat Gain Coefficient Window or Skylight

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.DoublePaneClearLowEColdClimateHighSHGC`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.DoublePaneClearLowEColdClimateHighSHGC`

#### Summary

Double Pane Clear Low Energy Cold Climate High Solar Heat Gain Coefficient Window or Skylight

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.DoublePaneReflective`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.DoublePaneReflective`

#### Summary

Double Pane Reflective Window or Skylight

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.DoublePaneTinted`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.DoublePaneTinted`

#### Summary

Double Pane Tinted Window or Skylight

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.DoublePaneClearNoCoating`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.DoublePaneClearNoCoating`

#### Summary

Double Pane Clear No Coating Window or Skylight

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.SinglePaneReflective`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.SinglePaneReflective`

#### Summary

Single Pane Reflective Window or Skylight

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.SinglePaneTinted`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.SinglePaneTinted`

#### Summary

Single Pane Tinted Window or Skylight

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.SinglePaneClearNoCoating`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.SinglePaneClearNoCoating`

#### Summary

Single Pane Clear No Coating Window or Skylight

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.InvalidWindowSkylightTypeConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType.InvalidWindowSkylightTypeConstruction`

#### Summary

Invalid value/not set Window or Skylight Type Construction

### `T:Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType`

#### Summary

ConceptualConstructionType values for Floors.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.NumFloorSlabTypeConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.NumFloorSlabTypeConstruction`

#### Summary

Total number of Floor/Slab Constructions

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.HighMassConstructionTypicalNoInsulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.HighMassConstructionTypicalNoInsulation`

#### Summary

High Mass Construction Typical No Insulation Slab

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.HighMassConstructionColdClimateSlabInsulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.HighMassConstructionColdClimateSlabInsulation`

#### Summary

High Mass Construction Cold Climate Insulation Slab

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.HighMassConstructionFrigidClimateSlabInsulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.HighMassConstructionFrigidClimateSlabInsulation`

#### Summary

High Mass Construction Frigid Climate Insulation Slab

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.LightweightConstructionNoInsulationInterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.LightweightConstructionNoInsulationInterior`

#### Summary

Lightweight Construction No Insulation Interior Floor

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.LightweightConstructionLowInsulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.LightweightConstructionLowInsulation`

#### Summary

Lightweight Construction Low Insulation Floor

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.LightweightConstructionTypicalInsulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.LightweightConstructionTypicalInsulation`

#### Summary

Lightweight Construction Typical Insulation Floor

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.LightweightConstructionHighInsulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.LightweightConstructionHighInsulation`

#### Summary

Lightweight Construction High Insulation Floor

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.InvalidFloorSlabTypeConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType.InvalidFloorSlabTypeConstruction`

#### Summary

Invalid/not set Floor or Slab Type construction value

### `T:Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType`

#### Summary

ConceptualConstructionType values for Roofs.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.NumRoofTypeConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.NumRoofTypeConstruction`

#### Summary

Total Number of Roof Type Constructions

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.NoInsulationDarkRoof`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.NoInsulationDarkRoof`

#### Summary

No Insulation Dark Roof

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.LowInsulationDarkRoof`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.LowInsulationDarkRoof`

#### Summary

Low Insulation Dark Roof

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.LowInsulationCoolRoof`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.LowInsulationCoolRoof`

#### Summary

Low Insulation Cool Roof

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.TypicalInsulationDarkRoof`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.TypicalInsulationDarkRoof`

#### Summary

Typical Insulation Dark Roof

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.TypicalInsulationCoolRoof`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.TypicalInsulationCoolRoof`

#### Summary

Typical Insulation Cool Roof

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.HighInsulationDarkRoof`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.HighInsulationDarkRoof`

#### Summary

High Insulation Dark Roof

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.HighInsulationCoolRoof`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.HighInsulationCoolRoof`

#### Summary

High Insulation Cool Roof

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.InvalidRoofTypeConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType.InvalidRoofTypeConstruction`

#### Summary

Invalid value/not set Roof Type Construction value

### `T:Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType`

#### Summary

ConceptualConstructionType values for Walls.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.NumWallTypeConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.NumWallTypeConstruction`

#### Summary

Total Number of Wall Type Constructions

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.HighMassConstructionNoInsulationInterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.HighMassConstructionNoInsulationInterior`

#### Summary

High Mass Construction No Insulation Interior Wall

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.HighMassConstructionTypicalMildClimateInsulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.HighMassConstructionTypicalMildClimateInsulation`

#### Summary

High Mass Construction Typical Mild Climate Insulation Wall

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.HighMassConstructionTypicalColdClimateInsulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.HighMassConstructionTypicalColdClimateInsulation`

#### Summary

High Mass Construction Typical Cold Climate Insulation Wall

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.HighMassConstructionHighInsulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.HighMassConstructionHighInsulation`

#### Summary

High Mass Construction High Insulation Wall

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.LightweightConstructionNoInsulationInterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.LightweightConstructionNoInsulationInterior`

#### Summary

Lightweight Construction No Insulation Interior Wall

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.LightweightConstructionLowInsulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.LightweightConstructionLowInsulation`

#### Summary

Lightweight Construction Low Insulation Wall

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.LightweightConstructionTypicalMildClimateInsulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.LightweightConstructionTypicalMildClimateInsulation`

#### Summary

Lightweight Construction Typical Mild Climate Insulation Wall

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.LightweightConstructionTypicalColdClimateInsulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.LightweightConstructionTypicalColdClimateInsulation`

#### Summary

Lightweight Construction Typical Cold Climate Insulation Wall

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.LightweightConstructionHighInsulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.LightweightConstructionHighInsulation`

#### Summary

Lightweight Construction High Insulation Wall

### `F:Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.InvalidExteriorWallTypeConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType.InvalidExteriorWallTypeConstruction`

#### Summary

Invalid value/not set Roof Type Construction value

### `M:Autodesk.Revit.DB.ComponentRepeaterSlot.MakeDefault`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeaterSlot.MakeDefault`

#### Summary

Populates the slot with an instance of the default family type of the component repeater.

#### Since

2014

### `M:Autodesk.Revit.DB.ComponentRepeaterSlot.MakeEmpty`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeaterSlot.MakeEmpty`

#### Summary

Makes the slot empty by removing the instance currently held by the slot.

#### Since

2014

### `M:Autodesk.Revit.DB.ComponentRepeaterSlot.IsTypeValidForSlot(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeaterSlot.IsTypeValidForSlot(Autodesk.Revit.DB.ElementId)`

#### Summary

Determines whether instance of given family type can be used in the component repeater slot.

#### Parameter `typeId`

The element id of the type.

#### Returns

True if the family type can be used in the component repeater slot.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ComponentRepeaterSlot.FamilyType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ComponentRepeaterSlot.FamilyType`

#### Summary

The id of the family type of the component in the slot, or invalid id if the slot is empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: Invalid type for the slot. The type must be an adaptive family with no shape handles.
In addition, it must have same category and same number of placement points as the current type of the repeater.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ComponentRepeaterSlot.IsDefault`

Member kind: property
Symbol: `Autodesk.Revit.DB.ComponentRepeaterSlot.IsDefault`

#### Summary

A flag indicating whether the slot currently holds an instance of the default family type of the component repeater.

#### Since

2014

### `P:Autodesk.Revit.DB.ComponentRepeaterSlot.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ComponentRepeaterSlot.IsEmpty`

#### Summary

A flag indicating whether the slot is currently empty.

#### Since

2014

### `T:Autodesk.Revit.DB.ComponentRepeaterSlot`

Member kind: type
Symbol: `Autodesk.Revit.DB.ComponentRepeaterSlot`

#### Summary

Represents a slot that holds one repeated component in a component repeater.

#### Remarks

Each slot can be in one of the following states:
Empty.

Occupied by an instance of the default family of the repeater that contains the slot.

Occupied by an instance of another family.
Initially, every occupied slot holds an instance of the default family of the repeater, based on the original
element that was repeated.

#### Since

2014

### `P:Autodesk.Revit.DB.ComponentRepeaterIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ComponentRepeaterIterator.CurrentObject`

### `P:Autodesk.Revit.DB.ComponentRepeaterIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ComponentRepeaterIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.ComponentRepeaterIterator.GetCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeaterIterator.GetCurrent`

#### Summary

Returns the current repeater slot.

#### Returns

The current slot.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2014

### `M:Autodesk.Revit.DB.ComponentRepeaterIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeaterIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2014

### `M:Autodesk.Revit.DB.ComponentRepeaterIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeaterIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2014

### `M:Autodesk.Revit.DB.ComponentRepeaterIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeaterIterator.MoveNext`

#### Summary

Increments the iterator to the next item.

#### Returns

True if there is a next available item in this iterator.
False if the iterator has completed all available items.

#### Since

2014

### `P:Autodesk.Revit.DB.ComponentRepeaterIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ComponentRepeaterIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ComponentRepeaterIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ComponentRepeaterIterator`

#### Summary

A slot iterator for ComponentRepeater.

#### Since

2014

### `M:Autodesk.Revit.DB.ComponentRepeater.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeater.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.ComponentRepeater.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeater.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.ComponentRepeater.GetComponentRepeaterIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeater.GetComponentRepeaterIterator`

#### Summary

Returns an iterator to the slot collection.

#### Returns

The slot iterator.

#### Since

2014

### `M:Autodesk.Revit.DB.ComponentRepeater.RemoveRepeaters(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeater.RemoveRepeaters(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Removes component repeaters from the document,
but leaves the individual repeated components in their respective locations and
hosted on their original hosts.

#### Remarks

In addition to the component repeaters the component repeater slots
are also removed from the document.

#### Parameter `document`

The document that contains the component repeaters to remove.

#### Parameter `elementIds`

The set of component repeaters that should be removed.

#### Returns

A collection of components that were previously repeated by the component repeater.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element id set is empty.
-or-
One or more elements in elementIds do not exist in the document.
-or-
Not all given elements are component repeaters.

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

2015 Subscription Update

### `M:Autodesk.Revit.DB.ComponentRepeater.RepeatElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeater.RepeatElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Repeats a set of adaptive component hosted on one or more repeating references.

#### Remarks

All elements must be adaptive family instances and have no shape handles.
At least one placement point must be hosted on a 1D or 2D repeating reference.
All other placement points can be hosted on a 0D, 1D or 2D repeating reference,
or must be unhosted.
Use `M:Autodesk.Revit.DB.ComponentRepeater.CanElementBeRepeated(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)` to test whether an element meets these conditions.

#### Parameter `document`

The document that contains the elements.

#### Parameter `elementIds`

The set of adaptive components used as an input pattern for the repeating operation.

#### Returns

One or more component repeater objects representing the result pattern of the repeating operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document does not allow creation of a component repeater.
-or-
The given element id set is empty.
-or-
One or more elements in elementIds do not exist in the document.
-or-
Not all given elements can be repeated. All elements must be adaptive family instances, have no shape handles, and have at least one placement
point hosted on a 1D or 2D repeating reference. The remaining placement points must be either unhosted or hosted on another repeating reference.

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

2014

### `M:Autodesk.Revit.DB.ComponentRepeater.CanElementBeRepeated(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeater.CanElementBeRepeated(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Determines whether an element can be repeated using the RepeatElements method.

#### Remarks

The element must be an adaptive family instance and have no shape handles.
At least one placement point must be hosted on a 1D or 2D repeating reference.
All other placement points can be hosted on a 0D, 1D or 2D repeating reference,
or must be unhosted.

#### Parameter `ADoc`

The document containing the element.

#### Parameter `elementId`

The element to be tested.

#### Returns

True if the element can be repeated.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.DB.ComponentRepeater.IsTypeValidForRepeater(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ComponentRepeater.IsTypeValidForRepeater(Autodesk.Revit.DB.ElementId)`

#### Summary

Determines whether given family type can be used as the default type for the repeater.

#### Parameter `typeId`

The element id of the type.

#### Returns

True if the family type can be used as the default type for the repeater.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ComponentRepeater.DimensionCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.ComponentRepeater.DimensionCount`

#### Summary

The dimension count of the component repeater.

#### Since

2014

### `P:Autodesk.Revit.DB.ComponentRepeater.DefaultFamilyType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ComponentRepeater.DefaultFamilyType`

#### Summary

The default family type for the component repeater.

#### Remarks

The default family type is the type of the instances in default slots. This includes slots that are added when the repeater grows.
When setting this property, all slots with instances of the default type will change their components to an instance of the new default type.
Empty slots will remain unchanged.
Slots with non-default family instances will remain unchanged.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: Invalid type for the repeater. The type must be an adaptive family with no shape handles.
In addition, it must have same category and same number of placement points as the current type of the repeater.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.ComponentRepeater`

Member kind: type
Symbol: `Autodesk.Revit.DB.ComponentRepeater`

#### Summary

An element that contains and manages a set of repeated components.

#### Remarks

Component repeaters can be used to replicate (repeat) elements hosted on repeating references.
The result of the repeating operation is a collection of slots. Each slot contains one repeated component.
The ComponentRepeater class provides the repeating functionality and access to the slots.

Each repeating reference is capable of hosting one point of an adaptive component. An initial pattern can be created
by populating one or more repeating references with such points. Component repeaters can then be used
to replicate the pattern to fill the rest of the repeating references in the particular repeating reference source.

The repeating references in repeating reference source are arranged in one or two dimensional arrays,
allowing for different kinds of repeating:
One dimensional source allows for repeating along a path.

Two dimensional source allows for repeating across a grid.

It is also possible to host a point on a zero dimensional reference (a point). This point will be shared by all slots.
A zero dimensional source allows for repeating around a single point. It should not be used alone, but together
with at least one other repeating reference source (typically one dimensional.) The point hosted on the zero dimensional
source serves as a central point around which other points can be repeated on their respective repeating reference
sources.

Multiple adaptive components may be hosted on one repeating reference source, and different points of one
adaptive component may be hosted on different repeating reference sources, effectively allowing different points
of an adaptive component to be repeated using different patterns.

Following is a typical component repeater creation workflow:
Get the default repeating reference source from a point element, divided path or divided surface.
(See `M:Autodesk.Revit.DB.RepeatingReferenceSource.HasRepeatingReferenceSource(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`
and `M:Autodesk.Revit.DB.RepeatingReferenceSource.GetDefaultRepeatingReferenceSource(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)` .)

Query the bounds of the repeating reference source to find a range of valid coordinates.
(See `P:Autodesk.Revit.DB.RepeatingReferenceSource.DimensionCount`
and `M:Autodesk.Revit.DB.RepeatingReferenceSource.GetBounds` .)

Create one or more instances of adaptive families that will be repeated.

Host the individual points of an adaptive component on one or more repeating references.
(See `M:Autodesk.Revit.DB.RepeatingReferenceSource.GetReference(Autodesk.Revit.DB.RepeaterCoordinates)` .)

Repeat the set of adaptive components using the RepeatElements() method.

Component repeaters can only be used in Massing families (the conceptual design environment).

#### Since

2014

### `P:Autodesk.Revit.DB.Visual.SchemaCommon.Category`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SchemaCommon.Category`

#### Summary

The property labeled "Category" common to all visual Asset types.

#### Remarks

This property is of type "AssetPropertyString".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SchemaCommon.Keyword`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SchemaCommon.Keyword`

#### Summary

The property labeled "Keyword" common to all visual Asset types.

#### Remarks

This property is of type "AssetPropertyString".
Use ":" to add several keywords.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SchemaCommon.UIName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SchemaCommon.UIName`

#### Summary

The property labeled "UIName" common to all visual Asset types.

#### Remarks

This property is of type "AssetPropertyString".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SchemaCommon.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SchemaCommon.Description`

#### Summary

The property labeled "Description" common to all visual Asset types.

#### Remarks

This property is of type "AssetPropertyString".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SchemaCommon.Thumbnail`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SchemaCommon.Thumbnail`

#### Summary

The property labeled "Thumbnail" common to all visual Asset types.

#### Remarks

This property is a "AssetPropertyList" of type "AssetPropertyString".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SchemaCommon.BaseSchema`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SchemaCommon.BaseSchema`

#### Summary

The property labeled "BaseSchema" common to all visual Asset types.

#### Remarks

This property is of type "AssetPropertyString".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SchemaCommon.VersionGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SchemaCommon.VersionGUID`

#### Summary

The property labeled "VersionGUID" common to all visual Asset types.

#### Remarks

This property is of type "AssetPropertyString" and will contain a uuid.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SchemaCommon.Hidden`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SchemaCommon.Hidden`

#### Summary

The property labeled "Hidden" common to all visual Asset types.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.SchemaCommon`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.SchemaCommon`

#### Summary

A static class that provides access to the property names that appear in all the visual Asset types.

#### Since

2018.1

### `M:Autodesk.Revit.DB.ColumnAttachment.SetJustification(Autodesk.Revit.DB.ColumnAttachmentJustification)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColumnAttachment.SetJustification(Autodesk.Revit.DB.ColumnAttachmentJustification)`

#### Summary

Setter of ColumnAttachmentJustification

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.ColumnAttachment.RemoveColumnAttachment(Autodesk.Revit.DB.FamilyInstance,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColumnAttachment.RemoveColumnAttachment(Autodesk.Revit.DB.FamilyInstance,Autodesk.Revit.DB.ElementId)`

#### Summary

Removes any attachment of the column to the specified target.

#### Remarks

This method modifies both column and target elements.

#### Parameter `column`

A column.

#### Parameter `targetId`

Id of a target element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ColumnAttachment.RemoveColumnAttachment(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColumnAttachment.RemoveColumnAttachment(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

#### Summary

Removes an attachment at the top or base of a column, if there is one.

#### Remarks

This method modifies both column and target elements.

#### Parameter `column`

A column.

#### Parameter `baseOrTop`

0 for base, 1 for top.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

baseOrTop must be either 0 or 1.

### `M:Autodesk.Revit.DB.ColumnAttachment.GetColumnAttachment(Autodesk.Revit.DB.FamilyInstance,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColumnAttachment.GetColumnAttachment(Autodesk.Revit.DB.FamilyInstance,Autodesk.Revit.DB.ElementId)`

#### Summary

Look up a column attachment by specifying the target id.

#### Remarks

May return either a top or base attachment.

#### Parameter `column`

A column.

#### Parameter `targetId`

Id of a target element.

#### Returns

The column attachment attaching the column to the target, or `null` if there
is no such attachment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ColumnAttachment.GetColumnAttachment(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColumnAttachment.GetColumnAttachment(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

#### Summary

Look up a column attachment. There is at most one attachment on
the base and one on the top.

#### Parameter `column`

A column.

#### Parameter `baseOrTop`

0 for base, 1 for top.

#### Returns

The column attachment for the base or top of the column, or `null` if that end
of the column is unattached.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

baseOrTop must be either 0 or 1.

### `M:Autodesk.Revit.DB.ColumnAttachment.AddColumnAttachment(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FamilyInstance,Autodesk.Revit.DB.Element,System.Int32,Autodesk.Revit.DB.ColumnAttachmentCutStyle,Autodesk.Revit.DB.ColumnAttachmentJustification,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColumnAttachment.AddColumnAttachment(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FamilyInstance,Autodesk.Revit.DB.Element,System.Int32,Autodesk.Revit.DB.ColumnAttachmentCutStyle,Autodesk.Revit.DB.ColumnAttachmentJustification,System.Double)`

#### Summary

Attaches the column to the target. If an attachment already
exists with the same "baseOrTop" value, no attachment is made.

#### Remarks

This method modifies both column and target elements.

#### Parameter `doc`

The document containing column and target.

#### Parameter `column`

A column.

#### Parameter `target`

A target element.

#### Parameter `baseOrTop`

0 to attach the column base, 1 to attach the column top.

#### Parameter `cutColumnStyle`

Control the handling of columns that intersect their targets.

#### Parameter `justification`

Control the column extent in cases where the target is not a uniform height.

#### Parameter `attachOffset`

An additional offset for the bottom. If positive, the column base or top will
be higher than the attachment point; if negative, lower.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

column is not a column that supports ColumnAttachments.
-or-
target is not a valid target for ColumnAttachments.
-or-
column already has an attachment at its base or top as specified by baseOrTop.
-or-
column already has an attachment to target.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

baseOrTop must be either 0 or 1.
-or-
The given value for attachOffset must be no more than 30000 feet in absolute value.
-or-
A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.ColumnAttachment.IsValidTarget(System.Boolean,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColumnAttachment.IsValidTarget(System.Boolean,Autodesk.Revit.DB.Element)`

#### Summary

Says whether the element can be used as a target for a new attachment.

#### Remarks

Valid targets are roofs, floors, ceilings, levels. Beams and braces
are valid targets, except for slanted columns.

#### Parameter `forSlantedColumn`

If true, check whether the target is valid for a slanted column;
if false, check whether the target is valid for a vertical column.

#### Parameter `target`

A proposed target element for a column attachment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ColumnAttachment.IsValidTarget(Autodesk.Revit.DB.FamilyInstance,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColumnAttachment.IsValidTarget(Autodesk.Revit.DB.FamilyInstance,Autodesk.Revit.DB.Element)`

#### Summary

Says whether the element can be used as a target for a new attachment.

#### Remarks

Valid targets are roofs, floors, and ceilings. Beams and braces
are also valid targets, except for slanted columns.

#### Parameter `column`

The column to attach. If the target is a beam or brace, the column
will be checked to see if it is slanted. Otherwise, this argument
is not used and may be omitted.

#### Parameter `target`

A proposed target element for a column attachment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ColumnAttachment.IsValidColumn(Autodesk.Revit.DB.FamilyInstance)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColumnAttachment.IsValidColumn(Autodesk.Revit.DB.FamilyInstance)`

#### Summary

Says whether a FamilyInstance supports column attachments.

#### Remarks

In-place columns do not support attachments.

#### Parameter `familyInstance`

A column.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.ColumnAttachment.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColumnAttachment.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ColumnAttachment.CutStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColumnAttachment.CutStyle`

#### Summary

Identifies whether the column, or the attached element should be cut (or if neither should be cut).

### `P:Autodesk.Revit.DB.ColumnAttachment.Justification`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColumnAttachment.Justification`

#### Summary

Identifies the type of justification to apply to this ColumnAttachment.

### `P:Autodesk.Revit.DB.ColumnAttachment.BaseOrTop`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColumnAttachment.BaseOrTop`

#### Summary

Identifies if this ColumnAttachment is at the base or top of the column.

### `P:Autodesk.Revit.DB.ColumnAttachment.TargetId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColumnAttachment.TargetId`

#### Summary

The id of the element that is attached to the column and is described by this ColumnAttachment.

### `P:Autodesk.Revit.DB.ColumnAttachment.AttachOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColumnAttachment.AttachOffset`

#### Summary

The offset of the column attachment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for attachOffset must be no more than 30000 feet in absolute value.

### `T:Autodesk.Revit.DB.ColumnAttachment`

Member kind: type
Symbol: `Autodesk.Revit.DB.ColumnAttachment`

#### Summary

An object representing the attachment of the top or bottom of a column to some target:
a floor, roof, ceiling, beam, or brace.

#### Remarks

Call IsValidColumn() and IsValidTarget() to verify that specific elements support
column attachments. A column has at most one top attachment and one bottom
attachment.

### `T:Autodesk.Revit.DB.ColumnAttachmentCutStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.ColumnAttachmentCutStyle`

#### Summary

Control the handling of columns that intersect their targets.

### `T:Autodesk.Revit.DB.ColumnAttachmentJustification`

Member kind: type
Symbol: `Autodesk.Revit.DB.ColumnAttachmentJustification`

#### Summary

Control the column extent in cases where the target is not a uniform height.

### `F:Autodesk.Revit.DB.ColumnAttachmentJustification.Tangent`

Member kind: field
Symbol: `Autodesk.Revit.DB.ColumnAttachmentJustification.Tangent`

#### Summary

For slanted columns only. Extend the column until its driving curve contacts the target, then cut the column
with a plane tangent to the target at that contact point.

### `F:Autodesk.Revit.DB.ColumnAttachmentJustification.Maximum`

Member kind: field
Symbol: `Autodesk.Revit.DB.ColumnAttachmentJustification.Maximum`

#### Summary

Extend the column until it is completely covered by the target, intersecting it if necessary.

### `F:Autodesk.Revit.DB.ColumnAttachmentJustification.Midpoint`

Member kind: field
Symbol: `Autodesk.Revit.DB.ColumnAttachmentJustification.Midpoint`

#### Summary

Extend the column until its midpoint contacts the target.

### `F:Autodesk.Revit.DB.ColumnAttachmentJustification.Minimum`

Member kind: field
Symbol: `Autodesk.Revit.DB.ColumnAttachmentJustification.Minimum`

#### Summary

Minimize the column extent, so that it comes in contact with the target but does not intersect.

### `M:Autodesk.Revit.DB.ColorWithTransparency.SetTransparency(System.UInt32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorWithTransparency.SetTransparency(System.UInt32)`

#### Summary

set transparency

#### Parameter `transparency`

transparency

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The value is not valid. The valid range is 0 to 255.

#### Since

2017

### `M:Autodesk.Revit.DB.ColorWithTransparency.GetTransparency`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorWithTransparency.GetTransparency`

#### Summary

get transparency

#### Returns

transparency

#### Since

2017

### `M:Autodesk.Revit.DB.ColorWithTransparency.SetBlue(System.UInt32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorWithTransparency.SetBlue(System.UInt32)`

#### Summary

set blue

#### Parameter `blue`

blue

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The value is not valid. The valid range is 0 to 255.

#### Since

2017

### `M:Autodesk.Revit.DB.ColorWithTransparency.GetBlue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorWithTransparency.GetBlue`

#### Summary

get blue

#### Returns

blue

#### Since

2017

### `M:Autodesk.Revit.DB.ColorWithTransparency.SetGreen(System.UInt32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorWithTransparency.SetGreen(System.UInt32)`

#### Summary

set green

#### Parameter `green`

green

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The value is not valid. The valid range is 0 to 255.

#### Since

2017

### `M:Autodesk.Revit.DB.ColorWithTransparency.GetGreen`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorWithTransparency.GetGreen`

#### Summary

get green

#### Returns

green

#### Since

2017

### `M:Autodesk.Revit.DB.ColorWithTransparency.SetRed(System.UInt32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorWithTransparency.SetRed(System.UInt32)`

#### Summary

set red

#### Parameter `red`

red

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The value is not valid. The valid range is 0 to 255.

#### Since

2017

### `M:Autodesk.Revit.DB.ColorWithTransparency.GetRed`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorWithTransparency.GetRed`

#### Summary

get red

#### Returns

red

#### Since

2017

### `M:Autodesk.Revit.DB.ColorWithTransparency.SetColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorWithTransparency.SetColor(Autodesk.Revit.DB.Color)`

#### Summary

set color

#### Parameter `color`

color

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.ColorWithTransparency.GetColor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorWithTransparency.GetColor`

#### Summary

get color

#### Returns

color

#### Since

2017

### `P:Autodesk.Revit.DB.ColorWithTransparency.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorWithTransparency.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.ColorWithTransparency.#ctor(System.UInt32,System.UInt32,System.UInt32,System.UInt32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorWithTransparency.#ctor(System.UInt32,System.UInt32,System.UInt32,System.UInt32)`

#### Summary

color

#### Parameter `red`

red

#### Parameter `green`

green

#### Parameter `blue`

blue

#### Parameter `transparency`

transparency

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The value is not valid. The valid range is 0 to 255.

#### Since

2017

### `M:Autodesk.Revit.DB.ColorWithTransparency.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorWithTransparency.#ctor`

#### Summary

color

#### Since

2017

### `T:Autodesk.Revit.DB.ColorWithTransparency`

Member kind: type
Symbol: `Autodesk.Revit.DB.ColorWithTransparency`

#### Summary

Color with transparency

#### Since

2017

### `M:Autodesk.Revit.DB.ColorOptions.GetColorOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorOptions.GetColorOptions`

#### Summary

Returns the current Revit instance's ColorOptions.

#### Returns

The ColorOptions for the current Revit instance.

#### Since

2020.1

### `P:Autodesk.Revit.DB.ColorOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ColorOptions.EditingColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorOptions.EditingColor`

#### Summary

The color of the current canvas theme used to render elements when editing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.ColorOptions.CalculatingColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorOptions.CalculatingColor`

#### Summary

The color of the current canvas theme used to render elements when some aspect of their properties is currently being recalculated.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.ColorOptions.AlertColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorOptions.AlertColor`

#### Summary

The color of the current canvas theme used to highlight elements when a special alert is required.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.ColorOptions.PreselectionColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorOptions.PreselectionColor`

#### Summary

The color of the current canvas theme used to highlight candidates for selection before they are selected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.ColorOptions.SelectionSemitransparent`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorOptions.SelectionSemitransparent`

#### Summary

Indicates whether or not selections will be shown in a semi-transparent manner in current canvas theme.

#### Since

2020.1

### `P:Autodesk.Revit.DB.ColorOptions.SelectionColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorOptions.SelectionColor`

#### Summary

The color of the current canvas theme used to highlight selected elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.ColorOptions.BackgroundColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorOptions.BackgroundColor`

#### Summary

The background color of the current canvas theme applied to views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `T:Autodesk.Revit.DB.ColorOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ColorOptions`

#### Summary

A class providing access to color settings which affect the colors applied to specific views.

#### Remarks

ColorOptions are managed and stored along with other global application options and thus impact the application as a whole.

#### Since

2020.1

### `M:Autodesk.Revit.DB.ColorFillScheme.CanDefineByRange`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.CanDefineByRange`

#### Summary

Checks whether the scheme entries can be explained by range.

#### Returns

Returns true ifthe scheme entries can be explained by range, false otherwise.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.IsValidParameterDefinitionId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.IsValidParameterDefinitionId(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the input parameter id can be applied to the scheme.

#### Returns

Returns true if the input parameter id can be set to this scheme, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.IsValidSchemeName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.IsValidSchemeName(System.String)`

#### Summary

Checks whether the name is valid for new generated scheme.

#### Remarks

The name should not be empty, or all spaces, or include prohibited characters or duplicated with existing schemes.

#### Returns

Returns true if the name is valid for new generated scheme, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.CanUpdateEntry(Autodesk.Revit.DB.ColorFillSchemeEntry)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.CanUpdateEntry(Autodesk.Revit.DB.ColorFillSchemeEntry)`

#### Summary

Checks whether entry exists in the scheme and not the same as input one.

#### Parameter `entry`

The entry to be updated.

#### Returns

Returns true if entry exist in scheme and not the same as input one, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.CanRemoveEntry(Autodesk.Revit.DB.ColorFillSchemeEntry)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.CanRemoveEntry(Autodesk.Revit.DB.ColorFillSchemeEntry)`

#### Summary

Checks whether entry can be removed from the scheme.

#### Remarks

An entry cannot be removed if it is in use or does not exist in the scheme.

#### Parameter `entry`

The entry to remove.

#### Returns

Returns true if entry can be removed from the scheme, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.Duplicate(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.Duplicate(System.String)`

#### Summary

Generates a copy of current scheme.

#### Parameter `name`

The desired name of copied scheme.

#### Returns

The id of copied scheme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The name is not valid for new generated scheme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.RemoveEntry(Autodesk.Revit.DB.ColorFillSchemeEntry)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.RemoveEntry(Autodesk.Revit.DB.ColorFillSchemeEntry)`

#### Summary

Removes an entry whose parameter value is the same as the input from the scheme

#### Remarks

The entry can not be removed if it is in use.

#### Parameter `entry`

The entry to remove.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The entry cannot be removed from the scheme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.SortEntries`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.SortEntries`

#### Summary

Sorts the scheme entries ascending.

#### Remarks

If the scheme parameter value storage type is ElementId, then
the order of entries would be based on the name of the elements.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.AreEntriesConsistentWithScheme(System.Collections.Generic.IList{Autodesk.Revit.DB.ColorFillSchemeEntry})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.AreEntriesConsistentWithScheme(System.Collections.Generic.IList{Autodesk.Revit.DB.ColorFillSchemeEntry})`

#### Summary

Checks whether the entries can be set to the scheme or not.

#### Parameter `entries`

The entries to check.

#### Returns

The state of the entries and scheme consistency.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.IsEntryConsistentWithScheme(Autodesk.Revit.DB.ColorFillSchemeEntry)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.IsEntryConsistentWithScheme(Autodesk.Revit.DB.ColorFillSchemeEntry)`

#### Summary

Checks whether an entry can be added to the scheme or not.

#### Parameter `entry`

The entry to check.

#### Returns

The state of entry and scheme consistency.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.AddEntry(Autodesk.Revit.DB.ColorFillSchemeEntry)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.AddEntry(Autodesk.Revit.DB.ColorFillSchemeEntry)`

#### Summary

Adds new entry to the scheme.

#### Remarks

To make sure that entry can be added to the scheme, call `M:Autodesk.Revit.DB.ColorFillScheme.IsEntryConsistentWithScheme(Autodesk.Revit.DB.ColorFillSchemeEntry)` first.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There already exists an entry with the same value in the scheme.
-or-
The entry value is out of range.
-or-
The scheme and the entry have different parameter storage type.
-or-
The fill pattern id is not valid for scheme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.GetSupportedParameterIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.GetSupportedParameterIds`

#### Summary

Retrieves collection of all parameters supported by the scheme.

#### Remarks

Supported parameters depends on `P:Autodesk.Revit.DB.ColorFillScheme.CategoryId` property.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.SetFormatOptions(Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.SetFormatOptions(Autodesk.Revit.DB.FormatOptions)`

#### Summary

Sets the FormatOptions of the scheme.

#### Remarks

This method will set the FormatOptions if the scheme is by range, otherwise do nothing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.GetFormatOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.GetFormatOptions`

#### Summary

Returns the FormatOptions of the scheme.

#### Remarks

This method will return the default FormatOptions if the scheme is by value.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.SetEntries(System.Collections.Generic.IList{Autodesk.Revit.DB.ColorFillSchemeEntry})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.SetEntries(System.Collections.Generic.IList{Autodesk.Revit.DB.ColorFillSchemeEntry})`

#### Summary

Update scheme entries in batch mode.

#### Remarks

For by range scheme:

If there is only one entry in the input, Revit will generate another one automatically.

If the first existing entry is found in the input, it will be updated, otherwise keep not changed.

If the other existing entries are found in the input, they will be updated, otherwise removed.

For by value scheme:

For an existing entry that is in use, it will be updated if it can be found in the input, otherwise keep not changed.

For an existing entry that is no in use, it will be updated if it can be found in the input, otherwise removed.

If an entry in the input cannot be found in the existing entries, it will be added to the scheme.

To make sure that entry can be added to the scheme, call `M:Autodesk.Revit.DB.ColorFillScheme.AreEntriesConsistentWithScheme(System.Collections.Generic.IList`1{Autodesk.Revit.DB.ColorFillSchemeEntry})` first.

#### Parameter `entries`

Collection of new entries.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There exists entries whose values are duplicated in the input entries.
-or-
There exists at lease one entry whose value is invalid for the scheme in the input entries.
-or-
There exists at least one entry in the input entries whose storage type is different with the scheme.
-or-
There exists at least one entry in the input entries whose fill pattern is invalid for color fill scheme.
-or-
There exists some inconsistent in the input entries.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.UpdateEntry(Autodesk.Revit.DB.ColorFillSchemeEntry)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.UpdateEntry(Autodesk.Revit.DB.ColorFillSchemeEntry)`

#### Summary

Updates the scheme entry with the same parameter value as the input entry.

#### Remarks

The following entry fields can be updated:

Color

FillPattenId

Caption

IsVisible/

#### Parameter `entry`

The entry to be updated.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The entry does not exist or the same as input one.
-or-
The entry does not exist or all the updating fields are the same as existing one.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillScheme.GetEntries`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillScheme.GetEntries`

#### Summary

Retrieves copies of all entries.

#### Remarks

This method recalculates entries based on the current parameter values of the elements colored by the scheme.

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillScheme.ParameterDefinition`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillScheme.ParameterDefinition`

#### Summary

Represents the parameter of the elements that this scheme could be used to color.

#### Remarks

When this property changed, all existing scheme entries will be removed from the scheme,
and the value of `P:Autodesk.Revit.DB.ColorFillScheme.IsByRange` property will be set to false if the parameter
storage type is not numeric.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The paramId cannot be applied to the scheme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillScheme.AreaSchemeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillScheme.AreaSchemeId`

#### Summary

Represents the id of AreaScheme of area plan views that this scheme could be applied to.

#### Remarks

Only meaningful if the `P:Autodesk.Revit.DB.ColorFillScheme.CategoryId` is OST_Areas.

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillScheme.IsLinkedFilesIncluded`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillScheme.IsLinkedFilesIncluded`

#### Summary

Represent if the scheme includes entries whose parameter values are based on elements from linked files.

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillScheme.IsByRange`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillScheme.IsByRange`

#### Summary

Represents if the parameter values in entries are treated as value range or not.

#### Remarks

Notes:

Only numeric parameter values could be treated as by range.

There will exist at least two entries if the scheme is by range,
and the first entry value should be always Int.MinValue or -Double.MaxValue.

The entries will always be sorted by ascending in the scheme if it is by range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The scheme entries cannot be explained by range.

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillScheme.StorageType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillScheme.StorageType`

#### Summary

Represents the type of parameter values stored in entries.

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillScheme.CategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillScheme.CategoryId`

#### Summary

Represents the element category that can be colored by this scheme.

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillScheme.Title`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillScheme.Title`

#### Summary

Represents the title displayed in `T:Autodesk.Revit.DB.ColorFillLegend` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.ColorFillScheme`

Member kind: type
Symbol: `Autodesk.Revit.DB.ColorFillScheme`

#### Summary

Represents a color scheme could be used to colorfy elements in floor plan views and section views.

#### Remarks

A color scheme is based on element category and one of the category parameter, it contains a
set of `T:Autodesk.Revit.DB.ColorFillSchemeEntry` which stores parameter value,
color, fill pattern and other entry data. The entry paramater values may be a range or a single value,
based on the `P:Autodesk.Revit.DB.ColorFillScheme.IsByRange` property. Then elements with the specified category
could be colored with the color and fill pattern of matching entry whose parameter value or value range
matches the element parameter value.

You can retrieve the entries with `M:Autodesk.Revit.DB.ColorFillScheme.GetEntries` , or modify entries with
`M:Autodesk.Revit.DB.ColorFillScheme.AddEntry(Autodesk.Revit.DB.ColorFillSchemeEntry)` , `M:Autodesk.Revit.DB.ColorFillScheme.RemoveEntry(Autodesk.Revit.DB.ColorFillSchemeEntry)` , `M:Autodesk.Revit.DB.ColorFillScheme.UpdateEntry(Autodesk.Revit.DB.ColorFillSchemeEntry)` and `M:Autodesk.Revit.DB.ColorFillScheme.SetEntries(System.Collections.Generic.IList`1{Autodesk.Revit.DB.ColorFillSchemeEntry})` .

Unlike most of the other elements, the color scheme works in an "asynchronous" way in UI:

If document elements change, the color scheme will not be updated immediately.

If color schemes changes, the document elements will not be updated immediately too.

API works slightly different with UI:

`M:Autodesk.Revit.DB.ColorFillScheme.GetEntries` will return the entries corresponding to the latest document elements status immediately.

The entries modification operation will retrieve the latest entries with `M:Autodesk.Revit.DB.ColorFillScheme.GetEntries` at first, and then modify
those entries by request, but document elements will still not be updated immediately.

To modify multiple entries, it's better to use `M:Autodesk.Revit.DB.ColorFillScheme.SetEntries(System.Collections.Generic.IList`1{Autodesk.Revit.DB.ColorFillSchemeEntry})` but not modify them one by one with other methods
for better performance.

Notes:

To apply a color scheme whose `P:Autodesk.Revit.DB.ColorFillScheme.CategoryId` property is OST_Areas to an area plan view,
the `P:Autodesk.Revit.DB.ColorFillScheme.AreaSchemeId` property must be the same as the view if it is not used as a template.

To generate a new color scheme, you have to use `M:Autodesk.Revit.DB.ColorFillScheme.Duplicate(System.String)` method to duplicate form an existing one.

There should not exist two entries values that are the same in a color scheme. if the `P:Autodesk.Revit.DB.ColorFillScheme.StorageType` property is Double,
then the value accuracy should be based on `T:Autodesk.Revit.DB.FormatOptions` property.

#### Since

2022

### `T:Autodesk.Revit.DB.EntryAndSchemeConsistency`

Member kind: type
Symbol: `Autodesk.Revit.DB.EntryAndSchemeConsistency`

#### Summary

Enumeration used to specify why an entry is inconsistent with a scheme or another entry.

#### Since

2022

#### Since

2022

### `F:Autodesk.Revit.DB.EntryAndSchemeConsistency.InvalidFillPatternId`

Member kind: field
Symbol: `Autodesk.Revit.DB.EntryAndSchemeConsistency.InvalidFillPatternId`

#### Summary

The fill pattern id is not valid.

### `F:Autodesk.Revit.DB.EntryAndSchemeConsistency.ValueDuplicated`

Member kind: field
Symbol: `Autodesk.Revit.DB.EntryAndSchemeConsistency.ValueDuplicated`

#### Summary

There already exists another entry with the same value.

### `F:Autodesk.Revit.DB.EntryAndSchemeConsistency.ValueOutOfRange`

Member kind: field
Symbol: `Autodesk.Revit.DB.EntryAndSchemeConsistency.ValueOutOfRange`

#### Summary

The value stored in the entry is out of the scheme parameter range.

### `F:Autodesk.Revit.DB.EntryAndSchemeConsistency.InconsistentStorageType`

Member kind: field
Symbol: `Autodesk.Revit.DB.EntryAndSchemeConsistency.InconsistentStorageType`

#### Summary

The type of value stored in the entry is different from the type of the scheme parameter.

### `F:Autodesk.Revit.DB.EntryAndSchemeConsistency.Consistent`

Member kind: field
Symbol: `Autodesk.Revit.DB.EntryAndSchemeConsistency.Consistent`

#### Summary

The scheme entry can be applied to the scheme.

### `M:Autodesk.Revit.DB.ColorFillLegend.SetColumnWidths(System.Collections.Generic.IList{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillLegend.SetColumnWidths(System.Collections.Generic.IList{System.Double})`

#### Summary

Sets array of column widths.

#### Remarks

Input array length must be the same as what `M:Autodesk.Revit.DB.ColorFillLegend.GetColumnWidths` returns. It can only contain positive values.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Array is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillLegend.GetColumnWidths`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillLegend.GetColumnWidths`

#### Summary

Returns array of column widths in the legend.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillLegend.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillLegend.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates new instance of ColorFillLegend.

#### Remarks

Use `M:Autodesk.Revit.DB.View.SupportedColorFillCategoryIds` to get list of supported categories.

#### Parameter `document`

The document.

#### Parameter `viewId`

The id of the view to place legend in.

#### Parameter `catetoryId`

The id of category that color fill scheme belongs to.

#### Parameter `origin`

The origin point of the legend, must be on the view plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
There's no valid color fill scheme applied for catetoryId in viewId.
-or-
The origin is not on the view plane.

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

2022

### `P:Autodesk.Revit.DB.ColorFillLegend.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillLegend.Origin`

#### Summary

The top left corner of the color fill legend.

#### Remarks

The origin point must be on the view plane this legend is placed on.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The origin is not on the view plane that this legend is placed on.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillLegend.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillLegend.Height`

#### Summary

The height of the legend.

#### Remarks

Changing the height may result in a change in the count of columns.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for height must be positive.

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillLegend.ColorFillCategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillLegend.ColorFillCategoryId`

#### Summary

Returns the id of color fill category that this legend is created for.

#### Since

2022

### `T:Autodesk.Revit.DB.ColorFillLegend`

Member kind: type
Symbol: `Autodesk.Revit.DB.ColorFillLegend`

#### Summary

Represents color fill legend.

#### Remarks

Color fill legend is a 2D annotation element, it can be created through `M:Autodesk.Revit.DB.ColorFillLegend.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)` with specified category of color fill scheme,
if there exists a valid color fill scheme activated for the category in the view. After a legend is created, its content and layout will
keep consistent with the active color fill scheme of the view. You can adjust its position through `P:Autodesk.Revit.DB.ColorFillLegend.Origin` property,
or manually maintain its layout through `P:Autodesk.Revit.DB.ColorFillLegend.Height` property and `M:Autodesk.Revit.DB.ColorFillLegend.GetColumnWidths` / `M:Autodesk.Revit.DB.ColorFillLegend.SetColumnWidths(System.Collections.Generic.IList`1{System.Double})` methods.

Notes:

`M:Autodesk.Revit.DB.View.GetColorFillSchemeId(Autodesk.Revit.DB.ElementId)` could be used to retrieve the corresponding color fill scheme of this legend, through the
`!:Autodesk::Revit::DB::View::ColorFillCategoryId` and `P:Autodesk.Revit.DB.Element.OwnerViewId` properties. Note that there could only exist one active scheme for all spatial categories
(rooms, areas, and zones) in one view.

Once the height and column widths are explicitly set, they will be fixed even if the contents of the legend change.

To retrieve correct height and column widths, it's better to manually retrieve the geometry of legend for nonvisible views.
(Because color fill legend is a view specific element.)

The value of `P:Autodesk.Revit.DB.ColorFillLegend.Height` property does not contain the line that displays "Calculating...".

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillSchemeEntry.CanSetValue(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.CanSetValue(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` of entry is ElementId.

#### Parameter `value`

New ElementId value.

#### Returns

True if `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` of the entry is ElementId and the entry, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillSchemeEntry.CanSetValue(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.CanSetValue(System.Double)`

#### Summary

Checks whether `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` of entry is Double and the value is no less than 0.0.

#### Parameter `value`

New Double value.

#### Returns

True if `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` of the entry is Double and the value is finite, false otherwise.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillSchemeEntry.CanSetValue(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.CanSetValue(System.Int32)`

#### Summary

Checks whether `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` of entry is Integer.

#### Parameter `value`

New Integer value.

#### Returns

True if `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` of the entry is Integer, false otherwise.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillSchemeEntry.SetElementIdValue(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.SetElementIdValue(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets new ElementId value of entry.

#### Remarks

You should only use this method if the `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` property reports the type of the entry as a ElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The entry has different storage type with ElementId.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillSchemeEntry.SetDoubleValue(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.SetDoubleValue(System.Double)`

#### Summary

Sets new Double value of entry.

#### Remarks

You should only use this method if the `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` property reports the type of the entry as a Double.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The entry has different storage type with Double, or value is not finite.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillSchemeEntry.SetIntegerValue(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.SetIntegerValue(System.Int32)`

#### Summary

Sets new Integer value of entry.

#### Remarks

You should only use this method if the `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` property reports the type of the entry as a Integer.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The entry has different storage type with Integer.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillSchemeEntry.SetStringValue(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.SetStringValue(System.String)`

#### Summary

Sets new String value of entry.

#### Remarks

This method should only be used if the `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` property reports the type of the entry as a String.
New value should be not empty and valid for Revit name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The entry has different storage type with String, or the value is empty, or contains forbidden characters.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillSchemeEntry.GetElementIdValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.GetElementIdValue`

#### Summary

Gets the ElementId value stored within the entry.

#### Remarks

This method should only be used if the `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` property reports the type of the entry as a ElementId.

#### Returns

The ElementId contained in the entry.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillSchemeEntry.GetDoubleValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.GetDoubleValue`

#### Summary

Gets the Double value stored within the entry.

#### Remarks

This method should only be used if the `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` property reports the type of the entry as a Double.

#### Returns

The Double value contained in the entry.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillSchemeEntry.GetIntegerValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.GetIntegerValue`

#### Summary

Gets the Integer value stored within the entry.

#### Remarks

This method should only be used if the `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` property reports the type of the entry as a Integer.

#### Returns

The Integer value contained in the entry.

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillSchemeEntry.GetStringValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.GetStringValue`

#### Summary

Gets the String value stored within the entry.

#### Remarks

This method should only be used if the `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType` property reports the type of the entry as a String.

#### Returns

The String contained in the entry.

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillSchemeEntry.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ColorFillSchemeEntry.Caption`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.Caption`

#### Summary

The text displayed in `!:Autodesk::Revit::DB::ColorFillLegend` for this entry.

#### Remarks

This property is only meaningful for by range scheme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: newCaption is an empty string or contains only whitespace.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.StorageType`

#### Summary

The storage type of the value stored in this entry.

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillSchemeEntry.IsVisible`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.IsVisible`

#### Summary

Represents if the element colored based on this entry is visible in views.

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillSchemeEntry.IsInUse`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.IsInUse`

#### Summary

Represents if there exists at least one element colored based on this entry in the document.

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillSchemeEntry.FillPatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.FillPatternId`

#### Summary

The id of fill pattern element of this entry.

#### Remarks

InvalidElementid represents no pattern, that means
there would be nothing to be filled for elements colored based on this entry.

Only fill pattern elements whose fill pattern target is drafting is valid for color fill scheme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.ColorFillSchemeEntry.Color`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.Color`

#### Summary

The filling color of this entry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ColorFillSchemeEntry.#ctor(Autodesk.Revit.DB.StorageType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry.#ctor(Autodesk.Revit.DB.StorageType)`

#### Summary

Creates new ColorFillSchemeEntry.

#### Remarks

A new created ColorFillSchemeEntry should be assigned proper value before it is applied to a
`!:Autodesk::Revit::DB::ColorFillScheme` . If the `P:Autodesk.Revit.DB.ColorFillSchemeEntry.Color` and
`P:Autodesk.Revit.DB.ColorFillSchemeEntry.Caption` properties are not set, Revit will generate them automatically
after the ColorFillSchemeEntry is applied to the ColorFillScheme.

#### Parameter `storageType`

The type of data that could be stored into this entry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `T:Autodesk.Revit.DB.ColorFillSchemeEntry`

Member kind: type
Symbol: `Autodesk.Revit.DB.ColorFillSchemeEntry`

#### Summary

Represents an entry of a `!:Autodesk::Revit::DB::ColorFillScheme` .

#### Since

2022

### `M:CloudPath.#ctor`

Member kind: method
Symbol: `CloudPath.#ctor`

#### Summary

A path to a Revit model stored on a Revit server.

### `M:Autodesk.Revit.DB.CloudPath.IsValidName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CloudPath.IsValidName(System.String)`

#### Summary

A valid name contains at most getMaximumLengthForNames() characters and
does not contain any invalid characters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.CloudPath.DefaultRegion`

Member kind: property
Symbol: `Autodesk.Revit.DB.CloudPath.DefaultRegion`

#### Since

2019

### `M:Autodesk.Revit.DB.CloudPath.#ctor(System.String,System.Guid,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CloudPath.#ctor(System.String,System.Guid,System.Guid)`

#### Summary

Constructs a CloudPath which represents a specified central model
in a specified cloud project.

#### Parameter `region`

The region of the cloud project which contains the model.

#### Parameter `projectId`

The GUID of the cloud project which contains the model.

#### Parameter `modelId`

The GUID of the cloud .rvt model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.CloudPath.#ctor(System.String,System.Guid,System.String,System.Guid,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CloudPath.#ctor(System.String,System.Guid,System.String,System.Guid,System.String)`

#### Summary

Constructs a CloudPath which represents a specified central model
in a specified cloud project.

#### Parameter `region`

The region of the cloud project which contains the model.

#### Parameter `projectId`

The GUID of the cloud project which contains the model.

#### Parameter `projectName`

The name of the cloud project which contains the model.

#### Parameter `modelId`

The GUID of the cloud .rvt model.

#### Parameter `modelName`

The name of the cloud .rvt model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `T:Autodesk.Revit.DB.CloudPath`

Member kind: type
Symbol: `Autodesk.Revit.DB.CloudPath`

#### Summary

This class represents a location in the cloud, rather than a
location on disk, network drive or a Revit Server location.

#### Remarks

CloudPaths must refer to Revit models.

#### Since

2019

### `M:Autodesk.Revit.DB.ClassificationEntries.LoadClassificationEntriesFromFile(System.String,Autodesk.Revit.DB.KeyBasedTreeEntriesLoadContent)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ClassificationEntries.LoadClassificationEntriesFromFile(System.String,Autodesk.Revit.DB.KeyBasedTreeEntriesLoadContent)`

#### Summary

Loads the contents of a classification text file into the provided KeyBasedTreeEntriesLoadContent.

#### Remarks

The entries read from the file will be added to any existing entries read from other files before this reading operation
in the provided KeyBasedTreeEntriesLoadContent.
if file A was read, and then file B was failed to read, all the entries from file A will still be there to build KeynoteEntries object.

#### Parameter `filePath`

The full path of the existing classification file.

#### Parameter `loadContent`

The classification entries read from the filePath will be added to this object.
A KeyBasedTreeEntriesLoadContent object will also be updated to contain status information,
including information about any errors that occurred while reading the keynote entries from
the specified file.

#### Returns

True if reading the keynote file succeeds; False if the classification file cannot be read.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

filePath is an empty string.
-or-
The KeyBasedTreeEntries object owned by this KeyBasedTreeEntriesLoadContent object is built already.
Adding more KeyBasedTreeEntries as well as repeated building, is not supported.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The destination file name includes one or more invalid characters.

#### Since

2015

### `T:Autodesk.Revit.DB.ClassificationEntries`

Member kind: type
Symbol: `Autodesk.Revit.DB.ClassificationEntries`

#### Summary

A collection of ClassificationEntry objects that make up the classification table.

#### Since

2015

### `M:Autodesk.Revit.DB.ClassificationEntry.HasInvalidKey`

Member kind: method
Symbol: `Autodesk.Revit.DB.ClassificationEntry.HasInvalidKey`

#### Summary

Checks if the key matches the level and parent key.

#### Returns

True if the key doesn't matach the level and parent key.
False otherwise.

#### Since

2015

### `M:Autodesk.Revit.DB.ClassificationEntry.HasBadCategoryId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ClassificationEntry.HasBadCategoryId`

#### Summary

Checks if the category id is Revit BuiltInCategory id.

#### Returns

True if the category id is not Revit BuiltInCategory id.
False otherwise.

#### Since

2015

### `M:Autodesk.Revit.DB.ClassificationEntry.HasBadLevel`

Member kind: method
Symbol: `Autodesk.Revit.DB.ClassificationEntry.HasBadLevel`

#### Summary

Checks if the level is an integer in range between 1 and 5 inclusive.

#### Returns

True if the level is not an integer from 1 to 5 inclusive. False otherwise.

#### Since

2015

### `P:Autodesk.Revit.DB.ClassificationEntry.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.ClassificationEntry.Description`

#### Summary

The description associated with this entry.

#### Since

2015

### `P:Autodesk.Revit.DB.ClassificationEntry.CategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ClassificationEntry.CategoryId`

#### Summary

The id of the category associated with this entry.

#### Since

2015

### `P:Autodesk.Revit.DB.ClassificationEntry.Level`

Member kind: property
Symbol: `Autodesk.Revit.DB.ClassificationEntry.Level`

#### Summary

The entry level in the classification table. The expected range is between 1 and 5 inclusive.

#### Since

2015

### `M:Autodesk.Revit.DB.ClassificationEntry.#ctor(System.String,System.String,System.String,System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ClassificationEntry.#ctor(System.String,System.String,System.String,System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a ClassificationEntry object

#### Parameter `key`

The key of this ClassificationEntry.

#### Parameter `parentKey`

The parent key of this ClassificationEntry.

#### Parameter `description`

The description associated with this ClassificationEntry.

#### Parameter `level`

The level of this ClassficationEntry.

#### Parameter `categoryId`

The category id of this ClassificationEntry.
The category can be invalidElementId, otherwise it must represent Revit existing category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

key is an empty string.
-or-
The categoryId is not appropriate category id for classfication entry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.ClassificationEntry`

Member kind: type
Symbol: `Autodesk.Revit.DB.ClassificationEntry`

#### Summary

Represents an entry in the classification table.

#### Since

2015

### `M:Autodesk.Revit.DB.Electrical.CircuitNamingScheme.SetCombinedParameters(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CircuitNamingScheme.SetCombinedParameters(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

#### Summary

Sets combined parameters array.

#### Remarks

Currently the following parameters are supported:

Project Parameters

Shared Parameters

RBS_ELEC_CIRCUIT_NAME

RBS_ELEC_CIRCUIT_PANEL_PARAM

RBS_ELEC_CIRCUIT_TYPE

CIRCUIT_LOAD_CLASSIFICATION_ABBREVIATION_PARAM

RBS_ELEC_CIRCUIT_NAMING_INDEX

RBS_ELEC_NUMBER_OF_POLES

RBS_ELEC_CIRCUIT_RATING_PARAM

RBS_ELEC_CIRCUIT_FRAME_PARAM

RBS_ELEC_VOLTAGE

CIRCUIT_PHASE_PARAM

CIRCUIT_WAYS_PARAM

RBS_ELEC_CIRCUIT_SLOT_INDEX

#### Parameter `data`

The array of TableCellCombinedParameterData to be set as combined parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The data contains invalid parameter id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Electrical.CircuitNamingScheme.GetCombinedParameters`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CircuitNamingScheme.GetCombinedParameters`

#### Summary

Gets the combined parameters.

#### Returns

Gets array of TableCellCombinedParameterData with the combined parameters data.

#### Since

2021

### `M:Autodesk.Revit.DB.Electrical.CircuitNamingScheme.IsNameUnique(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CircuitNamingScheme.IsNameUnique(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Validates whether the CircuitNamingScheme name is unique in document.

#### Parameter `aDocument`

The document in which the name is being tested for uniqueness.

#### Parameter `name`

The name tested for uniqueness.

#### Returns

Returns true if the name is unique, and false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Electrical.CircuitNamingScheme.IsValidCombinedParameters(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CircuitNamingScheme.IsValidCombinedParameters(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

#### Summary

Validates whether the combined parameters is valid.

#### Remarks

Currently the following parameters are supported:

Shared Parameters

RBS_ELEC_CIRCUIT_NAME

RBS_ELEC_CIRCUIT_PANEL_PARAM

RBS_ELEC_CIRCUIT_TYPE

CIRCUIT_LOAD_CLASSIFICATION_ABBREVIATION_PARAM

RBS_ELEC_CIRCUIT_NAMING_INDEX

RBS_ELEC_NUMBER_OF_POLES

RBS_ELEC_CIRCUIT_RATING_PARAM

RBS_ELEC_CIRCUIT_FRAME_PARAM

RBS_ELEC_VOLTAGE

CIRCUIT_PHASE_PARAM

CIRCUIT_WAYS_PARAM

RBS_ELEC_CIRCUIT_SLOT_INDEX

#### Parameter `aDocument`

The document.

#### Parameter `data`

The array of TableCellCombinedParameterData to be set as combined parameters.

#### Returns

Returns true if the combined parameters are valid, and false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Electrical.CircuitNamingScheme.Create(Autodesk.Revit.DB.Document,System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CircuitNamingScheme.Create(Autodesk.Revit.DB.Document,System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

#### Summary

Creates a new CircuitNamingScheme.

#### Parameter `document`

The document in which to create the CircuitNamingScheme.

#### Parameter `name`

The name of CircuitNamingScheme.

#### Parameter `data`

The array of TableCellCombinedParameterData to be set as combined parameters.

#### Returns

The newly created CircuitNamingScheme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string or contains only whitespace.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
The given value for name is already in use as a CircuitNamingScheme name.
-or-
The data contains invalid parameter id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `T:Autodesk.Revit.DB.Electrical.CircuitNamingScheme`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CircuitNamingScheme`

#### Summary

This class represents a circuit naming scheme in Autodesk Revit.

#### Since

2021

### `P:Autodesk.Revit.DB.Lighting.CircleLightShape.EmitDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.CircleLightShape.EmitDiameter`

#### Summary

The emit diameter.

#### Value

The emit diameter as a numerical value in feet between 1.0e-9 and 30000.0

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The shape dimension is not valid because it is not between 1.0e-9 and 30000.0.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.CircleLightShape.#ctor(Autodesk.Revit.DB.Lighting.CircleLightShape)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.CircleLightShape.#ctor(Autodesk.Revit.DB.Lighting.CircleLightShape)`

#### Summary

Creates a copy of the given circle light shape

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.CircleLightShape.#ctor(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.CircleLightShape.#ctor(System.Double)`

#### Summary

Creates a circle light shape object with the given emit diameter.

#### Parameter `emitDiameter`

The emit diameter as a numerical value in feet between 1.0e-9 and 30000.0

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The shape dimension is not valid because it is not between 1.0e-9 and 30000.0.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.CircleLightShape.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.CircleLightShape.#ctor`

#### Summary

Creates a circle light shape object with 2.0' emit diameter.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.CircleLightShape`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.CircleLightShape`

#### Summary

This class encapsulates a circle light shape.

#### Since

2013

### `P:Autodesk.Revit.DB.Visual.Checker.TextureVRepeat`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Checker.TextureVRepeat`

#### Summary

The property labeled "V Repeat" from the "Checker" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Checker.TextureURepeat`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Checker.TextureURepeat`

#### Summary

The property labeled "U Repeat" from the "Checker" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Checker.TextureScaleLock`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Checker.TextureScaleLock`

#### Summary

The property labeled "Scale Lock" from the "Checker" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Checker.TextureRealWorldScaleY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Checker.TextureRealWorldScaleY`

#### Summary

The property labeled "Size Y" from the "Checker" schema.

#### Remarks

This property is of type "AssetPropertyDistance" with a minimum of "0.01".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Checker.TextureRealWorldScaleX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Checker.TextureRealWorldScaleX`

#### Summary

The property labeled "Size X" from the "Checker" schema.

#### Remarks

This property is of type "AssetPropertyDistance" with a minimum of "0.01".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Checker.TextureWAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Checker.TextureWAngle`

#### Summary

The property labeled "Rotation" from the "Checker" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 360".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Checker.TextureOffsetLock`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Checker.TextureOffsetLock`

#### Summary

The property labeled "Offset Lock" from the "Checker" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Checker.TextureRealWorldOffsetY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Checker.TextureRealWorldOffsetY`

#### Summary

The property labeled "Offset Y" from the "Checker" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Checker.TextureRealWorldOffsetX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Checker.TextureRealWorldOffsetX`

#### Summary

The property labeled "Offset X" from the "Checker" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Checker.TextureLinkTextureTransforms`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Checker.TextureLinkTextureTransforms`

#### Summary

The property labeled "Link Transforms" from the "Checker" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Checker.CheckerSoften`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Checker.CheckerSoften`

#### Summary

The property labeled "Soften" from the "Checker" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 5".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Checker.CheckerColor2`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Checker.CheckerColor2`

#### Summary

The property labeled "Color 2" from the "Checker" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Checker.CheckerColor1`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Checker.CheckerColor1`

#### Summary

The property labeled "Color 1" from the "Checker" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Checker`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Checker`

#### Summary

A static class that provides access to the property names that appear in the Checker visual asset schema.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Ceramic.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Ceramic.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "Ceramic" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Ceramic.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Ceramic.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "Ceramic" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Ceramic.CeramicPatternAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Ceramic.CeramicPatternAmount`

#### Summary

The property labeled "Amount" from the "Ceramic" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 2".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Ceramic.CeramicPatternMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Ceramic.CeramicPatternMap`

#### Summary

The property labeled "Image" from the "Ceramic" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Ceramic.CeramicPattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Ceramic.CeramicPattern`

#### Summary

The property labeled "Relief Pattern" from the "Ceramic" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "CeramicPatternType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Ceramic.CeramicBumpAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Ceramic.CeramicBumpAmount`

#### Summary

The property labeled "Amount" from the "Ceramic" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Ceramic.CeramicBumpMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Ceramic.CeramicBumpMap`

#### Summary

The property labeled "Image" from the "Ceramic" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Ceramic.CeramicBump`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Ceramic.CeramicBump`

#### Summary

The property labeled "Type" from the "Ceramic" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "CeramicBumpType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Ceramic.CeramicApplication`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Ceramic.CeramicApplication`

#### Summary

The property labeled "Finish" from the "Ceramic" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "CeramicApplicationType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Ceramic.CeramicColorByObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Ceramic.CeramicColorByObject`

#### Summary

The property labeled "Color" from the "Ceramic" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Ceramic.CeramicColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Ceramic.CeramicColor`

#### Summary

The property labeled "Color" from the "Ceramic" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Ceramic.CeramicType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Ceramic.CeramicType`

#### Summary

The property labeled "Type" from the "Ceramic" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "CeramicType".

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Ceramic`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Ceramic`

#### Summary

A static class that provides access to the property names that appear in the Ceramic visual asset schema.

#### Since

2018.1

### `P:Autodesk.Revit.DB.CeilingType.ThermalProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.CeilingType.ThermalProperties`

#### Summary

The calculated and settable thermal properties of the CeilingType

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The ceiling does not have thermal properties.

#### Since

2013

### `T:Autodesk.Revit.DB.CeilingType`

Member kind: type
Symbol: `Autodesk.Revit.DB.CeilingType`

#### Summary

Represents a ceiling type in Autodesk Revit.

### `M:Autodesk.Revit.DB.Ceiling.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Ceiling.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of ceiling within the project.

#### Remarks

To validate curve loop profile use `T:Autodesk.Revit.DB.BoundaryValidation` .

#### Parameter `document`

The document in which the new ceiling is created.

#### Parameter `curveLoops`

An array of planar curve loops that represent the profile of the ceiling.

#### Parameter `ceilingTypeId`

Id of the ceiling type to be used by the new ceiling. If InvalidElementId is passed, the default type will be used.

#### Parameter `levelId`

Id of the level on which the ceiling is to be placed.

#### Returns

If successful a new ceiling object within the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId levelId is not a Level.
-or-
The ElementId ceilingTypeId does not correspond to a CeilingType.
-or-
The input curve loops cannot compose a valid boundary, that means:
the "curveLoops" collection is empty;
or some curve loops intersect with each other;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the horizontal(XY) plane;
or input curves contain at least one helical curve.
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

2022

### `M:Autodesk.Revit.DB.Ceiling.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Line,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Ceiling.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Line,System.Double)`

#### Summary

Creates a new instance of ceiling within the project.

#### Remarks

To validate curve loop profile use `T:Autodesk.Revit.DB.BoundaryValidation` .

#### Parameter `document`

The document in which the new ceiling is created.

#### Parameter `curveLoops`

An array of planar curve loops that represent the profile of the ceiling.

#### Parameter `ceilingTypeId`

Id of the ceiling type to be used by the new ceiling. If InvalidElementId is passed, the default type will be used.

#### Parameter `levelId`

Id of the level on which the ceiling is to be placed.

#### Parameter `slopeArrow`

A line used to control the slope angle of the Ceiling. It must be horizontal.

#### Parameter `slope`

The slope angle.

#### Returns

If successful a new ceiling object within the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId levelId is not a Level.
-or-
The ElementId ceilingTypeId does not correspond to a CeilingType.
-or-
The input curve loops cannot compose a valid boundary, that means:
the "curveLoops" collection is empty;
or some curve loops intersect with each other;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the horizontal(XY) plane;
or input curves contain at least one helical curve.
-or-
The slopeArrow must be a horizontal line.
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

2022

### `P:Autodesk.Revit.DB.Ceiling.SketchId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Ceiling.SketchId`

#### Summary

Returns id of the sketch.

#### Since

2022

### `T:Autodesk.Revit.DB.Ceiling`

Member kind: type
Symbol: `Autodesk.Revit.DB.Ceiling`

#### Summary

Represents a ceiling in Autodesk Revit.

#### Since

2013

### `M:Autodesk.Revit.DB.CancellationListener.IsCancelled`

Member kind: method
Symbol: `Autodesk.Revit.DB.CancellationListener.IsCancelled`

#### Summary

Returns true if the operation associated with this instance has been cancelled.

#### Since

2017

### `P:Autodesk.Revit.DB.CancellationListener.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CancellationListener.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.CancellationListener`

Member kind: type
Symbol: `Autodesk.Revit.DB.CancellationListener`

#### Summary

Allows clients to poll the cancellation status of a background operation. Revit instantiates
CancellationListener objects for internal background operation implementations only. As such,
third-party developers are not expected to instantiate or handle CancellationListener objects.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.CableTrayType.IsValidBendMultiplier(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayType.IsValidBendMultiplier(System.Double)`

#### Summary

Identifies if the input bend multiplier is valid.

#### Parameter `bendMultiplier`

The bend multiplier to check.

#### Returns

True if the value is acceptable, false otherwise.

### `P:Autodesk.Revit.DB.Electrical.CableTrayType.IsWithFitting`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayType.IsWithFitting`

#### Summary

Whether this cable tray type is with fitting

#### Remarks

True if this cable tray type is with fitting type.

### `P:Autodesk.Revit.DB.Electrical.CableTrayType.ShapeType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayType.ShapeType`

#### Summary

Shape of this cable tray type.

### `P:Autodesk.Revit.DB.Electrical.CableTrayType.BendMultiplier`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayType.BendMultiplier`

#### Summary

Bend multiplier.

#### Remarks

This should be positive and less than 3000.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The bend multiplier value should be positive and less than 3000.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

### `T:Autodesk.Revit.DB.Electrical.CableTrayType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayType`

#### Summary

This class represents a cable tray type in Autodesk Revit.

### `M:Autodesk.Revit.DB.Electrical.CableTraySizes.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizes.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Electrical.CableTraySizes.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizes.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Electrical.CableTraySizes.GetCableTraySizesIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizes.GetCableTraySizesIterator`

#### Summary

Returns a CableTraySizeIterator to the MEP cable tray sizes.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.CableTraySizes.ClearAll`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizes.ClearAll`

#### Summary

Removes all MEPSizes in the cable tray sizes.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.CableTraySizes.RemoveSize(Autodesk.Revit.DB.MEPSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizes.RemoveSize(Autodesk.Revit.DB.MEPSize)`

#### Summary

Erases the existing MEPSize.
For cable tray, the nominal diameter is used in MEPSize.

#### Remarks

Does nothing if there is no existing MEPSize with the specified nominal diameter.

#### Parameter `sizeInfo`

The MEPSize to be removed..

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Throws if the function is called during iterating the size set.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.CableTraySizes.AddSize(Autodesk.Revit.DB.MEPSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizes.AddSize(Autodesk.Revit.DB.MEPSize)`

#### Summary

Inserts a new MEPSize into the cable tray sizes.
For cable tray, the nominal diameter of MEPSize is used .

#### Parameter `sizeInfo`

The new MEPSize to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There is already the same size in the size set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The function is called during iterating the size set.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.CableTraySizes.GetCableTraySizes(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizes.GetCableTraySizes(Autodesk.Revit.DB.Document)`

#### Summary

Gets the cable tray sizes of the project.

#### Parameter `aDoc`

The document.

#### Returns

The cable tray sizes of the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.CableTraySizes.Contains(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizes.Contains(System.Double)`

#### Summary

Checks whether a cable tray size with the nominal diameter exists.

#### Parameter `nominalDiameter`

Nominal diameter.

#### Returns

True if a cable tray size with the nominal diameter exists.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.CableTraySizes.GetSizeCount`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizes.GetSizeCount`

#### Summary

Gets the size count of the cable tray size table.

#### Since

2017

### `T:Autodesk.Revit.DB.Electrical.CableTraySizes`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizes`

#### Summary

Cable tray sizes.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.CableTraySizeIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizeIterator.CurrentObject`

### `P:Autodesk.Revit.DB.Electrical.CableTraySizeIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizeIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.Electrical.CableTraySizeIterator.HasCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizeIterator.HasCurrent`

#### Summary

Identifies if the iterator has a current item.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Returns

True if there is a current item.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.CableTraySizeIterator.GetCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizeIterator.GetCurrent`

#### Summary

Returns the current MEPSize.

#### Returns

The current MEPSize.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.CableTraySizeIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizeIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.CableTraySizeIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizeIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.CableTraySizeIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizeIterator.MoveNext`

#### Summary

Increments the iterator to the next item.

#### Returns

True if there is a next available item in this iterator.
False if the iterator has completed all available items.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.CableTraySizeIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizeIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Electrical.CableTraySizeIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySizeIterator`

#### Summary

An iterator to a set of MEP cable tray sizes from CableTraySizes.

#### Since

2017

### `M:Autodesk.Revit.DB.Electrical.CableTraySettings.GetCableTraySettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySettings.GetCableTraySettings(Autodesk.Revit.DB.Document)`

#### Summary

Gets the cable tray settings of the project.

#### Parameter `document`

The document.

#### Returns

The cable tray settings of the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.CableTraySettings.UseAnnotationScaleForSingleLineFittings`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySettings.UseAnnotationScaleForSingleLineFittings`

#### Summary

Indicates whether use annotation scale for single line fittings or not.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.CableTraySettings.RiseDropAnnotationSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySettings.RiseDropAnnotationSize`

#### Summary

The rise drop annotation size.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for riseDropAnnotationSize must be between 0 and 30000 feet.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.CableTraySettings.FittingAnnotationSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySettings.FittingAnnotationSize`

#### Summary

The value of fitting annotation size.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for fittingAnnotationSize must be between 0 and 30000 feet.

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.CableTraySettings.ConnectorSeparator`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySettings.ConnectorSeparator`

#### Summary

The cable tray connector separator string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.CableTraySettings.SizeSuffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySettings.SizeSuffix`

#### Summary

The cable tray size suffix string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.CableTraySettings.SizeSeparator`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySettings.SizeSeparator`

#### Summary

The cable tray size separator string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.Electrical.CableTraySettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CableTraySettings`

#### Summary

The cable tray settings.

#### Since

2017

### `T:Autodesk.Revit.DB.Electrical.CableTrayRun`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayRun`

#### Summary

This class represents a cable tray run in Autodesk Revit.

#### Remarks

This class is mainly for calculating length of a cable tray run.
A cable tray run contains connected straight cable tray segments and bends between the straight segments with same type and size.

### `P:Autodesk.Revit.DB.Electrical.CableTrayConduitRunBase.Length`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayConduitRunBase.Length`

#### Summary

The length of the whole (cable tray or conduit) run
default 0.0

### `T:Autodesk.Revit.DB.Electrical.CableTrayConduitRunBase`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayConduitRunBase`

#### Summary

The base class for a cable tray or conduit run in Autodesk Revit.

### `M:Autodesk.Revit.DB.Electrical.CableTray.IsValidRungSpace(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTray.IsValidRungSpace(System.Double)`

#### Summary

Identifies if the input rung space is valid.

#### Remarks

rung space should be at least equal to or larger than rang width which is 1 inch.

#### Parameter `rungSpace`

The rung space to check.

#### Returns

True if the value is acceptable, false otherwise.

### `M:Autodesk.Revit.DB.Electrical.CableTray.GetShapeType`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTray.GetShapeType`

#### Summary

Returns the shape type for the cable tray.

#### Returns

The shape type.

### `M:Autodesk.Revit.DB.Electrical.CableTray.IsValidCableTrayType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTray.IsValidCableTrayType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if a cable tray type is valid.

#### Parameter `document`

The document.

#### Parameter `cabletrayType`

The cable tray type.

#### Returns

True if the cable tray type is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Electrical.CableTray.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTray.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of cable tray.

#### Remarks

This method will regenerate the document.

#### Parameter `document`

The document.

#### Parameter `cabletrayType`

The cable tray type. This must be a cable tray type accepted by isValidCableTrayType().
If the input cable tray type is InvalidElementId, the default cable tray type from the document will be used.

#### Parameter `startPoint`

The start point of the cable tray location line.

#### Parameter `endPoint`

The end point of the cable tray location line.

#### Parameter `levelId`

The element id of the level which this cable tray based.
If the input level id is invalidElementId = -1, the nearest level will be used.

#### Returns

The newly created cable tray.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This cable tray type is invalid.
-or-
This level id is invalid.
-or-
The points of startPoint and endPoint are too close: for MEPCurve, the minimum length is 1/10 inch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

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

### `P:Autodesk.Revit.DB.Electrical.CableTray.CurveNormal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTray.CurveNormal`

#### Summary

The up-direction vector of the cable tray.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2014

### `P:Autodesk.Revit.DB.Electrical.CableTray.RungSpace`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTray.RungSpace`

#### Summary

Distance between two rungs for the ladder cable tray.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The rung space value should be at least equal to or larger than rang width which is 1 inch.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

### `T:Autodesk.Revit.DB.Electrical.CableTray`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CableTray`

#### Summary

This class represents a cable tray in Autodesk Revit.

### `T:Autodesk.Revit.DB.Electrical.CableTrayShape`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayShape`

#### Summary

Shape types enum of cable tray

#### Summary

Enum of cable tray shape

### `F:Autodesk.Revit.DB.Electrical.CableTrayShape.Ladder`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayShape.Ladder`

#### Summary

Ladder cable tray shape.

### `F:Autodesk.Revit.DB.Electrical.CableTrayShape.Channel`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayShape.Channel`

#### Summary

Channel cable tray shape.

### `F:Autodesk.Revit.DB.Electrical.CableTrayShape.Invalid`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayShape.Invalid`

#### Summary

Invalid cable tray shape.

### `M:Autodesk.Revit.DB.Electrical.CableTrayConduitBase.IsValidEndPoints(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayConduitBase.IsValidEndPoints(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Identifies if two end points are valid.

#### Remarks

The two points should not be too close.

#### Parameter `startPoint`

The start point of the location line.

#### Parameter `endPoint`

The end point of the location line.

#### Returns

True if the two end points are valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Electrical.CableTrayConduitBase.IsValidLevelId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayConduitBase.IsValidLevelId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if a level id is valid.

#### Parameter `document`

The document.

#### Parameter `levelId`

The level id.

#### Returns

True if the level id is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Electrical.CableTrayConduitBase.IsWithFitting`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayConduitBase.IsWithFitting`

#### Summary

Return whether its cable tray/conduit type is with fitting

#### Returns

return true if its type is with fitting type.

### `P:Autodesk.Revit.DB.Electrical.CableTrayConduitBase.RunId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayConduitBase.RunId`

#### Summary

The id of the run to which this element belongs.

### `T:Autodesk.Revit.DB.Electrical.CableTrayConduitBase`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CableTrayConduitBase`

#### Summary

The CableTrayConduitBase class is implemented as the base class for cable tray or conduit

### `P:Autodesk.Revit.DB.CADLinkOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CADLinkOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.CADLinkOptions.ViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.CADLinkOptions.ViewId`

#### Summary

The id of the view to use as the link's reference view, if the
reference view has been deleted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.CADLinkOptions.PreserveOverrides`

Member kind: property
Symbol: `Autodesk.Revit.DB.CADLinkOptions.PreserveOverrides`

#### Summary

Whether Revit should preserve the link's graphic overrides on reload.

#### Since

2018

### `M:Autodesk.Revit.DB.CADLinkOptions.#ctor(System.Boolean,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CADLinkOptions.#ctor(System.Boolean,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a CADLinkOptions object, specifying whether to preserve
graphic overrides, and what view to use if the link's view has been
deleted.

#### Parameter `preserveOverrides`

True if Revit should preserve the link's graphic overrides on reload.
False otherwise.

#### Parameter `viewId`

The id of the view to use as the link's reference view, if the reference
view has been deleted. Revit will ignore this value if the reference
view is still in place.

The value may be ElementId.InvalidElementId, although Revit will
cancel the load if the reference view is deleted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.CADLinkOptions.#ctor(Autodesk.Revit.DB.CADLinkOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CADLinkOptions.#ctor(Autodesk.Revit.DB.CADLinkOptions)`

#### Summary

Constructs a new copy of the input CADLinkOptions object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `T:Autodesk.Revit.DB.CADLinkOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.CADLinkOptions`

#### Summary

This class contains the options in use when
or reloading a CAD link type (DWG, DXF, etc.)

#### Since

2018

### `M:Autodesk.Revit.TransformAPIUtils.CreateReflection(Autodesk.Revit.DB.Plane)`

Member kind: method
Symbol: `Autodesk.Revit.TransformAPIUtils.CreateReflection(Autodesk.Revit.DB.Plane)`

#### Summary

Creates a transform that represents a reflection across the given plane.

#### Parameter `plane`

The plane.

#### Returns

The new transform.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.TransformAPIUtils.CreateRotationAtPoint(Autodesk.Revit.DB.XYZ,System.Double,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.TransformAPIUtils.CreateRotationAtPoint(Autodesk.Revit.DB.XYZ,System.Double,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a transform that represents a rotation about the given axis at the specified point.

#### Parameter `axis`

The rotation axis.

#### Parameter `angle`

The angle.

#### Parameter `origin`

The origin point.

#### Returns

The new transform.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for angle is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

axis has zero length.

#### Since

2014
