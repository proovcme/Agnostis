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
Shard: 30
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinition.HasParameter(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition.HasParameter(Autodesk.Revit.DB.ElementId)`

#### Summary

Whether the definition stores the parameter.

#### Parameter `paramId`

Id of a parameter.

#### Returns

True if the definition stores the parameter, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinition.GetParameters`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition.GetParameters`

#### Summary

Return the Ids of the shared parameters in the Definition.

#### Returns

List of parameters as ElementIds.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinition.AddFormulaParameter(Autodesk.Revit.DB.ElementId,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition.AddFormulaParameter(Autodesk.Revit.DB.ElementId,System.String)`

#### Summary

Add a formula-driven parameter to the shape definition.

#### Remarks

Like AddParameter(), this function introduces a parameter into
the shape definition, but the parameter's value is driven by a formula.
Formula parameters cannot be used in constraints to drive the shape.
The formula is in the same format as in Revit families.
The formula is allowed to refer to other parameters that are
already in the definition, plus the builtin parameters REBAR_INSTANCE_BAR_DIAMETER (bar nominal diameter), REBAR_INSTANCE_BAR_MODEL_DIAMETER (bar model diameter),
REBAR_INSTANCE_BEND_DIAMETER, REBAR_SHAPE_START_HOOK_LENGTH, REBAR_SHAPE_START_HOOK_OFFSET,
REBAR_SHAPE_PARAM_START_HOOK_TAN_LEN, REBAR_SHAPE_PARAM_END_HOOK_TAN_LEN,
REBAR_SHAPE_END_HOOK_LENGTH, REBAR_SHAPE_END_HOOK_OFFSET, REBAR_ELEM_LENGTH,
REBAR_ELEM_TOTAL_LENGTH, and REBAR_ELEM_QUANTITY_OF_BARS.

#### Parameter `paramId`

The parameter. To obtain the id of a shared parameter,
call RebarShapeParameters.GetElementIdForExternalDefinition.

#### Parameter `formula`

The formula expressed as a string. The string is exactly what a user would
type into the Family Types dialog, e.g. "Total Length*3.14159*(Bar Diameter/2)*(Bar Diameter/2)"

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not the id of a shared parameter in the current document,
or its unit type is not UT_Reinforcement_Length or UT_Angle.
-or-
The name of a shared parameter identified by paramId
was already used by another shared parameter of the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinition.AddParameter(Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition.AddParameter(Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Add a parameter to the shape definition.

#### Remarks

A shape parameter must be a shared parameter and have value type double.
A parameter must be added to the definition before it can be used to
drive the shape in a RebarShapeConstraint object.
A parameter that does not drive a constraint is legal and will
simply become an editable parameter on any Rebar that is an instance of this RebarShape.

#### Parameter `paramId`

The parameter. To obtain the id of a shared parameter,
call RebarShapeParameters.GetElementIdForExternalDefinition.

#### Parameter `defaultValue`

A default value for this parameter in shapes. The default values
should be chosen carefully, because they are required to be consistent as a set of constraints.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not the id of a shared parameter in the current document,
or its unit type is not UT_Reinforcement_Length or UT_Angle.
-or-
The name of a shared parameter identified by paramId
was already used by another shared parameter of the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.RebarShapeDefinition.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarShapeDefinition.IsPlanar`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition.IsPlanar`

#### Summary

Reports whether the shape definition lies within a plane: false if a spiral,
true in all other cases.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeDefinition.Complete`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition.Complete`

#### Summary

Report whether the shape definition is fully
constrained.

#### Since

2009

### `T:Autodesk.Revit.DB.Structure.RebarShapeDefinition`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition`

#### Summary

A class to assist in defining rebar shapes.
A RebarShape element needs exactly one RebarShapeDefinition.

#### Remarks

A RebarShapeDefinition stores a set of Rebar Shape parameters. Each parameter
may be associated with:
One or more RebarShapeConstraints; orA formula; orNeither of the above.
Each shape instance (Rebar object) will have its own values for these parameters.
The RebarShapeDefinition also stores a default value for each parameter,
which is ignored if the parameter is associated with a formula.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarReinforcementData.Create(Autodesk.Revit.DB.ElementId,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarReinforcementData.Create(Autodesk.Revit.DB.ElementId,System.Int32)`

#### Summary

Creates a new instance of RebarReinforcementData, or `null` if the operation fails.

#### Parameter `rebarId`

the Id of the rebar

#### Parameter `iEnd`

The end of rebar where the coupler stays. This should be 0 or 1

#### Returns

Creates a new instance of RebarReinforcementData

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.RebarReinforcementData.End`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarReinforcementData.End`

#### Summary

The end of the rebar. The end should be 0 or 1.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.RebarReinforcementData.RebarId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarReinforcementData.RebarId`

#### Summary

The id of the Rebar

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.RebarReinforcementData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarReinforcementData`

#### Summary

class containing the id and the end of rebar on which the coupler stays

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.RebarPropagation.AlignByFace(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.Rebar},Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarPropagation.AlignByFace(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.Rebar},Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference)`

#### Summary

It will copy the source rebars, will align them to the destination face based on the source face and adapt them to destination host.

#### Remarks

The source and destination hosts represented by the source and destination references can be the same element or can be difereent elements. They can also be of different categories

The destination host must be able to host rebar.

The source rebars should not be gourp members.

This method uses its own transaction, so it's not permitted to be invoked in an active transaction.

#### Parameter `doc`

A document.

#### Parameter `sourceRebars`

The rebars that will be propagated. All of them must be from the same host as the source face reference.

#### Parameter `sourceFaceReference`

A reference to a face in the source host.

#### Parameter `destinationFaceReference`

A reference to a face in the destions host.

#### Returns

The newly created rebars.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element that contains the destinationFaceReference is not a valid rebar host.
-or-
The rebars should be from the same host as the source face reference.
-or-
The rebars that are group members can't be propagated.
-or-
The references should represent faces that have same type of surface.
-or-
The source and destination face references should be different.
-or-
This method uses its own transaction, so it's not permitted to be invoked in an active transaction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.RebarPropagation.AlignByHost(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.Rebar},Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarPropagation.AlignByHost(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.Rebar},Autodesk.Revit.DB.Element)`

#### Summary

It will copy the source rebars, will align them in the same way as how the source host is aligned to destination host and will adapt them to the destinaion host.

#### Remarks

The source and destination hosts should be of the same category.

The source and destination hosts should be different elements.

The destination host must be able to host rebar.

The source rebars should not be gourp members.

This method uses its own transaction, so it's not permitted to be invoked in an active transaction.

#### Parameter `doc`

A document.

#### Parameter `sourceRebars`

The rebars that will be propagated. All of them must be from the same host.

#### Parameter `destinationHost`

The destination host where the new rebar will be created.

#### Returns

The newly created rebars.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There are no source rebars to propagate.
-or-
The rebars should be from the same host.
-or-
The rebars that are group members can't be propagated.
-or-
destinationHost is not a valid rebar host.
-or-
The source and destination hosts should be of the same category.
-or-
The source and destination hosts must be different elements.
-or-
This method uses its own transaction, so it's not permitted to be invoked in an active transaction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `T:Autodesk.Revit.DB.Structure.RebarPropagation`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarPropagation`

#### Summary

An utility class containing functions that can be used to propagate rebar elements.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.CanEditIndividualBars`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.CanEditIndividualBars`

#### Summary

Checks if individual bars can be moved, excluded or included.

#### Remarks

Individual bars can be moved, exlucded or included only for RebarInSystem that is owned by PathReinforcement. For RebarInSystem owned by AreaReinforcement these operations are not supported.

#### Returns

True if individual bars can be moved, excluded or included, false otherwise.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.GetBarIndexFromReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.GetBarIndexFromReference(Autodesk.Revit.DB.Reference)`

#### Summary

Given a reference that represents a part of a bar, this method will return the bar index.

#### Remarks

The method returns an index between 0 and NumberOfBarPositions - 1 if it the given reference represents a part of a bar.
Otherwise will return -1.

#### Parameter `barReference`

The Reference of the RebarInSystem element.

#### Returns

The bar index the reference refers to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.ResetMovedBarTransform(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.ResetMovedBarTransform(System.Int32)`

#### Summary

Reset the transformation representing the movement of the bar relative to its default position along the distribution path.
The moved bar transform will be set to Identity.

#### Parameter `barPositionIndex`

The bar index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

For this RebarInSystem element individual bars can't be moved, excluded or included.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.GetMovedBarTransform(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.GetMovedBarTransform(System.Int32)`

#### Summary

Returns a transform representing the movement of the bar relative to its default position along the distribution path.

#### Remarks

For a RebarInSystem for which individual bars can't be edited (the ones owned by AreaReinforcement) the identity transform is returned.

#### Parameter `barPositionIndex`

The bar index.

#### Returns

The transform representing the movement of the bar relative to its default position along the distribution path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.MoveBarInSet(System.Int32,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.MoveBarInSet(System.Int32,Autodesk.Revit.DB.Transform)`

#### Summary

This method applies the transformation matrix to the rebar bar at the desired position in the rebar set.
If the bar was already moved, the method will concatenate the transformation matrix with the existing movement.

#### Parameter `barPositionIndex`

The bar index of the rebar to apply the transformation.

#### Parameter `moveTransform`

The transformation matrix to apply to the specified rebar bar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

For this RebarInSystem element individual bars can't be moved, excluded or included.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.DoesBarExistAtPosition(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.DoesBarExistAtPosition(System.Int32)`

#### Summary

Checks whether a bar is included at the specified position.

#### Parameter `barPosition`

A bar position index between 0 and NumberOfBarPositions-1.

#### Returns

Returns true if the bar at the specified position is included, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPosition is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.SetBarIncluded(System.Boolean,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.SetBarIncluded(System.Boolean,System.Int32)`

#### Summary

Sets if the bar at the desired index is included or not.

#### Parameter `include`

True to include the bar, false to exclude the bar.

#### Parameter `barPositionIndex`

The bar index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

For this RebarInSystem element individual bars can't be moved, excluded or included.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.GetHookTypeId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.GetHookTypeId(System.Int32)`

#### Summary

Get the id of the RebarHookType to be applied to the rebar.

#### Parameter `end`

0 for the start hook, 1 for the end hook.

#### Returns

The id of a RebarHookType, or invalidElementId if the rebar has
no hook at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.GetBendData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.GetBendData`

#### Summary

Gets the RebarBendData, containing bar and hook information, of the instance.

#### Remarks

Internally, the bend data is used by many RebarShape methods to generate shape geometry.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

#### Summary

Sets RebarInSystem element to be shown unobscured in a view.

#### Parameter `view`

The view element

#### Parameter `unobscured`

True if RebarInSystem element is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This element doesn't have valid visibility data.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.IsUnobscuredInView(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.IsUnobscuredInView(Autodesk.Revit.DB.View)`

#### Summary

Checks if this rebar element is shown unobscured in a view.

#### Parameter `view`

The view element

#### Returns

True if rebar is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.GetHostId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.GetHostId`

#### Summary

The element that contains the rebar.

#### Returns

The element that the rebar object belongs to, such as a structural
wall, floor, foundation, beam, brace or column.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.CanApplyPresentationMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.CanApplyPresentationMode(Autodesk.Revit.DB.View)`

#### Summary

Checks if a presentation mode can be applied for this rebar in the given view.

#### Parameter `dBView`

The view in which presentation mode will be applied.

#### Returns

True if a presentation mode can be applied for the given view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.ClearPresentationMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.ClearPresentationMode(Autodesk.Revit.DB.View)`

#### Summary

Sets the presentation mode for this rebar set to the default (either for a single view, or for all views).

#### Parameter `dBView`

The view where the presentation mode will be cleared. NULL for all views

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.FindMatchingPredefinedPresentationMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.FindMatchingPredefinedPresentationMode(Autodesk.Revit.DB.View)`

#### Summary

Determines if there is a matching RebarPresentationMode for the current set of selected hidden and unhidden bars assigned to the given view.

#### Remarks

If the presentation mode is not PresentationMode.Select for the view, this function returns the current mode.

#### Parameter `dBView`

The view.

#### Returns

The presentation mode that matches the current set of selected hidden and unhidden bars.
If there is no better match, this returns RebarPresentationMode.Select.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.GetPresentationMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.GetPresentationMode(Autodesk.Revit.DB.View)`

#### Summary

Gets the presentaion mode for this rebar set when displayed in the given view.

#### Parameter `dBView`

The view.

#### Returns

The presentation mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.SetPresentationMode(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Structure.RebarPresentationMode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.SetPresentationMode(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Structure.RebarPresentationMode)`

#### Summary

Sets the presentation mode for this rebar set when displayed in the given view.

#### Parameter `dBView`

The view.

#### Parameter `presentationMode`

The presentation mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This rebar cannot have a presentation mode applied for dBView, as the view is not valid for rebar presentation,
or the orientation of the view matches the normal direction of the rebar element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.HasPresentationOverrides(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.HasPresentationOverrides(Autodesk.Revit.DB.View)`

#### Summary

Identifies if this RebarInSystem has overridden default presentation settings for the given view.

#### Remarks

Default presentation settings can be overriden using `M:Autodesk.Revit.DB.Structure.RebarInSystem.SetBarHiddenStatus(Autodesk.Revit.DB.View,System.Int32,System.Boolean)` , `M:Autodesk.Revit.DB.Structure.RebarInSystem.SetPresentationMode(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Structure.RebarPresentationMode)` methods

#### Parameter `dBView`

The view.

#### Returns

True if this RebarInSystem has overriden default presentation settings, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.IsRebarInSection(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.IsRebarInSection(Autodesk.Revit.DB.View)`

#### Summary

Identifies if this RebarInSystem is cut by the view plane of the given view.

#### Remarks

This method applies only for elevations and sections. For any other view types will return false.

#### Parameter `dBView`

The view.

#### Returns

True if this RebarInSystem is cut by the view plane, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.IsBarHidden(Autodesk.Revit.DB.View,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.IsBarHidden(Autodesk.Revit.DB.View,System.Int32)`

#### Summary

Identifies if a given bar in this rebar set is hidden in this view.

#### Parameter `view`

The view.

#### Parameter `barIndex`

The index of the bar from this rebar set.

#### Returns

True if the bar is hidden in this view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.SetBarHiddenStatus(Autodesk.Revit.DB.View,System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.SetBarHiddenStatus(Autodesk.Revit.DB.View,System.Int32,System.Boolean)`

#### Summary

Sets the bar in this rebar set to be hidden or unhidden in the given view.

#### Remarks

Individual bars of a rebar set can be hidden in a view only
if the presentation mode is RebarPresentationMode.Select.
If that is not the presentation mode assigned for this set in the view,
this method will also change it.

#### Parameter `view`

The view.

#### Parameter `barIndex`

The index of the bar from this set.

#### Parameter `hide`

True to hide this bar in the view, false to unhide the bar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This rebar cannot have a presentation mode applied for view, as the view is not valid for rebar presentation,
or the orientation of the view matches the normal direction of the rebar element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.GetReinforcementRoundingManager`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.GetReinforcementRoundingManager`

#### Summary

Returns an object for managing reinforcement rounding override settings.

#### Returns

The rounding manager.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.GetBarPositionTransform(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.GetBarPositionTransform(System.Int32)`

#### Summary

Return a transform representing the relative position of any
individual bar in the set.

#### Remarks

The transform is a translation along the distribution path.
It can be applied to the results of GetCenterlineCurves() to
produce any bar in the rebar set. For barPositionIndex=0,
the identity transform is always returned.

#### Parameter `barPositionIndex`

An index between 0 and (NumberOfBarPositions-1).

#### Returns

The position of a bar in the set relative to the first position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.GetDistributionPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.GetDistributionPath`

#### Summary

The distribution path of a rebar set.

#### Returns

A line beginning at (0, 0, 0) and representing the direction and
length of the set.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.GetTransformedCenterlineCurves(System.Boolean,System.Boolean,System.Boolean,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.GetTransformedCenterlineCurves(System.Boolean,System.Boolean,System.Boolean,System.Int32)`

#### Summary

A chain of curves representing the centerline of the rebar.

#### Remarks

This method will return the centerline curves for bar at barPositionIndex even if this bar isn't included.
The curves are in the final position. The BarPositionTransform (representing the relative position of any individual bar in the set - a translation along the distribution path)
and MovedBarTransform (representing the movement of the bar relative to its default position along the distribution path) will be applied to the returned curves.

#### Parameter `adjustForSelfIntersection`

If the curves overlap, as in a planar stirrup, this parameter controls
whether they should be adjusted to avoid intersection (as in fine views),
or kept in a single plane for simplicity (as in coarse views).

#### Parameter `suppressHooks`

Identifies if the chain will include hooks curves.

#### Parameter `suppressBendRadius`

Identifies if the connected chain will include unfilleted curves.

#### Parameter `barPositionIndex`

The bar index.

#### Returns

The centerline curves or empty array if the curves cannot be computed because
the parameters values are inconsistent
with the constraints of the RebarShape definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.RebarInSystem.GetCenterlineCurves(System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.GetCenterlineCurves(System.Boolean,System.Boolean,System.Boolean)`

#### Summary

A chain of curves representing the centerline of the rebar.

#### Remarks

This method will return the centerline curves for the first bar in set even if this bar isn't included.

#### Parameter `adjustForSelfIntersection`

If the curves overlap, as in a planar stirrup, this parameter controls
whether they should be adjusted to avoid intersection (as in fine views),
or kept in a single plane for simplicity (as in coarse views).

#### Parameter `suppressHooks`

Identifies if the chain will include hooks curves.

#### Parameter `suppressBendRadius`

Identifies if the connected chain will include unfilleted curves.

#### Returns

The centerline curves or empty array if the curves cannot be computed because
the parameters values are inconsistent
with the constraints of the RebarShape definition.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.RebarInSystem.NumberOfBarPositions`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.NumberOfBarPositions`

#### Summary

The number of bar positions available in the rebar.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.RebarInSystem.RebarShapeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.RebarShapeId`

#### Summary

The RebarShape element that defines the shape of the rebar.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.RebarInSystem.Volume`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.Volume`

#### Summary

The volume of an individual bar multiplied by Quantity.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.RebarInSystem.TotalLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.TotalLength`

#### Summary

The length of an individual bar multiplied by Quantity.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.RebarInSystem.LayoutRule`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.LayoutRule`

#### Summary

Identifies the layout rule of rebar set.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.RebarInSystem.MaxSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.MaxSpacing`

#### Summary

Identifies the maximum spacing between rebar in rebar set.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.RebarInSystem.Quantity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.Quantity`

#### Summary

Identifies the number of bars in rebar set.

#### Remarks

Quantity is equal to NumberOfBarPositions if all the bars are included.
If any bars are excluded, they are not counted in the Quantity.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.RebarInSystem.ArrayLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.ArrayLength`

#### Summary

Identifies the distribution path length of rebar set.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.RebarInSystem.BarsOnNormalSide`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.BarsOnNormalSide`

#### Summary

Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal.
For the current implementation of RebarInSystem, this property will always return true,
but it is included in the RebarInSystem interface for consistency with the Rebar class.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.RebarInSystem.Normal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.Normal`

#### Summary

A unit-length vector normal to the plane of the rebar

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.RebarInSystem.ScheduleMark`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.ScheduleMark`

#### Summary

The Schedule Mark parameter. On creation, the Schedule Mark is set
to a value that is unique to the host, but it can be set to
any value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.RebarInSystem.SystemId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem.SystemId`

#### Summary

The Id of an AreaReinforcement or PathReinforcement element that owns
this element.

#### Since

2013

### `T:Autodesk.Revit.DB.Structure.RebarInSystem`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarInSystem`

#### Summary

Represents a rebar element that is part of a system.

#### Remarks

A RebarInSystem element is part of another element, the "system",
which controls most of its properties. The system elements
are AreaReinforcement and PathReinforcement.
Only a few properties of RebarInSystem
are modifiable. Otherwise, the appearance and behavior of RebarInSystem
elements is identical to Rebar elements. RebarInSystem elements may be
converted to Rebar elements by removing the system element.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.IsValidAlternatingBarOrientation(Autodesk.Revit.DB.Structure.ReinforcementBarOrientation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.IsValidAlternatingBarOrientation(Autodesk.Revit.DB.Structure.ReinforcementBarOrientation)`

#### Summary

Checks if orientation for alternating bars is valid.

#### Parameter `orientation`

An orientation.

#### Returns

True if orientation for alternating bars are valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.IsValidPrimaryBarOrientation(Autodesk.Revit.DB.Structure.ReinforcementBarOrientation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.IsValidPrimaryBarOrientation(Autodesk.Revit.DB.Structure.ReinforcementBarOrientation)`

#### Summary

Checks if orientation for primary bars is valid.

#### Parameter `orientation`

An orientation.

#### Returns

True if orientation for primary bars are valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.IsValidRebarShapeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.IsValidRebarShapeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies whether an element id corresponds to a Rebar Shape element which can be used in Path Reinforcement.

#### Remarks

The Rebar Shape has to be two dimensional shape only
and its neighbouring segments may form only right angles.

#### Parameter `aDoc`

The document.

#### Parameter `elementId`

An element id.

#### Returns

True if the specified element id corresponds to a Rebar Shape element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.IsAlternatingLayerEnabled`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.IsAlternatingLayerEnabled`

#### Summary

Checks if alternating bars are present in Path Reinforcement.

#### Returns

True if the alternating bars exist in Path Reinforcement instance.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

#### Summary

Sets Path Reinforcement to be shown unobscured in a view.

#### Parameter `view`

The view element

#### Parameter `unobscured`

True if Path Reinforcement is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This element doesn't have valid visibility data.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.IsUnobscuredInView(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.IsUnobscuredInView(Autodesk.Revit.DB.View)`

#### Summary

Checks if Path Reinforcement is shown unobscured in a view.

#### Parameter `view`

The view element

#### Returns

True if Path Reinforcement is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This element doesn't have valid visibility data.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.GetHostId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.GetHostId`

#### Summary

The element that contains the Path Reinforcement.

#### Returns

The element that the Path Reinforcement object belongs to, such as a structural
wall, floor or foundation.

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.GetCurveElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.GetCurveElementIds`

#### Summary

Retrieves the set of ElementIds of curves forming the boundary of the Path Reinforcement.

#### Remarks

Each ElementId in the collection is an Id of an Element of type ModelCurve.

#### Returns

A collection of ElementIds of ModelCurve elements.

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.ConvertRebarInSystemToRebars(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.PathReinforcement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.ConvertRebarInSystemToRebars(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.PathReinforcement)`

#### Summary

Converts all RebarInSystem elements owned by the input PathReinforcement to equivalent Rebar elements.

#### Parameter `doc`

The document.

#### Parameter `system`

A PathReinforcement element in the document.

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

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.RemovePathReinforcementSystem(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.PathReinforcement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.RemovePathReinforcementSystem(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.PathReinforcement)`

#### Summary

Deletes the specified PathReinforcement, and converts its RebarInSystem
elements to equivalent Rebar elements.

#### Parameter `doc`

The document.

#### Parameter `system`

A PathReinforcement element in the document.

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

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.GetRebarInSystemIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.GetRebarInSystemIds`

#### Summary

Returns the ids of the RebarInSystem elements owned by the PathReinforcement
element.

#### Remarks

The RebarInSystem elements are only created if
ReinforcementSettings.HostStructuralRebar is set to true. If that setting
is false, this function returns an empty array.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.GetOrCreateDefaultRebarShape(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.GetOrCreateDefaultRebarShape(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new RebarShape object with a default name or
returns existing one which fulfills Path Reinforcement bending data requirements.

#### Parameter `document`

The document.

#### Parameter `rebarBarTypeId`

The id of the RebarBarType.

#### Parameter `startRebarHookTypeId`

The id of the RebarHookType for the start of the bar.
If this parameter is InvalidElementId, it means to create a rebar with no start hook.

#### Parameter `endRebarHookTypeId`

The id of the RebarHookType for the end of the bar.
If this parameter is InvalidElementId, it means to create a rebar with no end hook.

#### Returns

Rebar Shape id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

rebarBarTypeId should refer to an RebarBarType element.
-or-
startRebarHookTypeId should be invalid or refer to an RebarHookType element.
-or-
endRebarHookTypeId should be invalid or refer to an RebarHookType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},System.Boolean,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},System.Boolean,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new PathReinforcement object from an array of curves and given Rebar Shape id.

#### Remarks

The method sets Rebar Shape of primary bars only.

#### Parameter `document`

The document.

#### Parameter `hostElement`

The element that will host the PathReinforcement. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.

#### Parameter `curveArray`

An array of curves that will define the outline of the PathReinforcement.

#### Parameter `flip`

A flag controlling the bars relative to the curves.

#### Parameter `pathReinforcementTypeId`

The id of the PathReinforcementType.

#### Parameter `rebarBarTypeId`

The id of the RebarBarType.

#### Parameter `startRebarHookTypeId`

The id of the RebarHookType for the start of the bar.
If this parameter is InvalidElementId, it means to create a rebar with no start hook.

#### Parameter `endRebarHookTypeId`

The id of the RebarHookType for the end of the bar.
If this parameter is InvalidElementId, it means to create a rebar with no end hook.

#### Parameter `rebarShapeId`

The id of the RebarShape element that defines the shape of the rebars in the object.

#### Returns

The newly created PathReinforcement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curveArray is empty.
-or-
The input curveArray contains at least one helical curve and is not supported for this operation.
-or-
The element hostElement was not found in the given document.
-or-
the host Element is not a valid host for Area Reinforcement, Path Reinforcement, Fabric Area or Fabric Sheet.
-or-
The structural rebar is not within area and path reinforcement.
-or-
curves in curveArray are not continuous and open.
-or-
pathReinforcementTypeId should refer to an Path Reinforcement Type element.
-or-
rebarBarTypeId should refer to an RebarBarType element.
-or-
startRebarHookTypeId should be invalid or refer to an RebarHookType element.
-or-
endRebarHookTypeId should be invalid or refer to an RebarHookType element.
-or-
rebarShapeId should refer to two dimensional Rebar Shape element with segments forming only right angles.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

startRebarHookTypeId cannot be set for given rebar shape.
-or-
endRebarHookTypeId cannot be set for given rebar shape.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.PathReinforcement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},System.Boolean,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},System.Boolean,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new PathReinforcement object from an array of curves. The newly created object will use a default Rebar Shape.

#### Remarks

The method sets Rebar Shape of primary bars only.

#### Parameter `document`

The document.

#### Parameter `hostElement`

The element that will host the PathReinforcement. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.

#### Parameter `curveArray`

An array of curves that will define the outline of the PathReinforcement.

#### Parameter `flip`

A flag controlling the bars relative to the curves.

#### Parameter `pathReinforcementTypeId`

The id of the PathReinforcementType.

#### Parameter `rebarBarTypeId`

The id of the RebarBarType.

#### Parameter `startRebarHookTypeId`

The id of the RebarHookType for the start of the bar.
If this parameter is InvalidElementId, it means to create a rebar with no start hook.

#### Parameter `endRebarHookTypeId`

The id of the RebarHookType for the end of the bar.
If this parameter is InvalidElementId, it means to create a rebar with no end hook.

#### Returns

The newly created PathReinforcement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curveArray is empty.
-or-
The input curveArray contains at least one helical curve and is not supported for this operation.
-or-
The element hostElement was not found in the given document.
-or-
the host Element is not a valid host for Area Reinforcement, Path Reinforcement, Fabric Area or Fabric Sheet.
-or-
curves in curveArray are not continuous and open.
-or-
pathReinforcementTypeId should refer to an Path Reinforcement Type element.
-or-
rebarBarTypeId should refer to an RebarBarType element.
-or-
startRebarHookTypeId should be invalid or refer to an RebarHookType element.
-or-
endRebarHookTypeId should be invalid or refer to an RebarHookType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.PathReinforcement.AlternatingBarShapeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.AlternatingBarShapeId`

#### Summary

The RebarShape element that defines the shape of the alternating bars of the Path Reinforcement.

#### Remarks

Changing the value of this property causes the Path Reinforcement to choose values for its
shape parameters.
Before calling this method, alternating bars have to be enabled in the Path Reinforcement by setting PATH_REIN_ALTERNATING BuiltInParameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: shapeId should refer to two dimensional Rebar Shape element with segments forming only right angles.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This Path Reinforcement does not have alternating bars enabled.
-or-
When setting this property: This PathReinforcement does not host Rebar.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.PathReinforcement.PrimaryBarShapeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.PrimaryBarShapeId`

#### Summary

The RebarShape element that defines the shape of the primary bars of the Path Reinforcement.

#### Remarks

Changing the value of this property causes the Path Reinforcement to choose values for its
shape parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: shapeId should refer to two dimensional Rebar Shape element with segments forming only right angles.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This PathReinforcement does not host Rebar.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.PathReinforcement.AdditionalOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.AdditionalOffset`

#### Summary

Additional offset of rebars in the Path Reinforcement.

#### Remarks

The method moves both primary and alternating bars.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for offset must be no more than 30000 feet in absolute value.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.PathReinforcement.PathReinforcementType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.PathReinforcementType`

#### Summary

Retrieves the type of the Path Reinforcement.

### `P:Autodesk.Revit.DB.Structure.PathReinforcement.AlternatingBarOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.AlternatingBarOrientation`

#### Summary

Orientation of alternating bars of Path Reinforcement.

#### Remarks

The orientation corresponds to the bars' rotation in the Path Reinforcement element.
It indicates the postion of the major segment of the alternating Rebar Shape relative to the edges of a rectangular region
which bounds the Path Reinforcement, where the top/exterior and bottom/interior come from the cover boundaries of the host,
the near side edge is defined by the Path Reinforcement sketch line, and the far side edge is derived from bar length (defaulting to 5').

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: This orientation is not allowed for alternating bars.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.PathReinforcement.PrimaryBarOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement.PrimaryBarOrientation`

#### Summary

Orientation of primary bars of Path Reinforcement.

#### Remarks

The orientation corresponds to the bars' rotation in the Path Reinforcement element.
It indicates the postion of the major segment of the primary Rebar Shape relative to the edges of a rectangular region
which bounds the Path Reinforcement, where the top/exterior and bottom/interior come from the cover boundaries of the host,
the near side edge is defined by the Path Reinforcement sketch line, and the far side edge is derived from bar length (defaulting to 5').

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: This orientation is not allowed for primary bars.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.PathReinforcement`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcement`

#### Summary

An object that represents an Path Reinforcement within the Autodesk Revit project.

#### Remarks

This object derived from the Element base object and such supports all the
methods of that object such as the ability to retrieve the parameters of that object.

### `M:Autodesk.Revit.DB.Structure.RebarHostData.GetRebarContainersInHost`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.GetRebarContainersInHost`

#### Summary

Returns all RebarContainer elements hosted by the referenced element.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarHostData.GetFabricAreasInHost`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.GetFabricAreasInHost`

#### Summary

Returns all FabricArea elements hosted by the referenced element.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.RebarHostData.GetFabricSheetsInHost`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.GetFabricSheetsInHost`

#### Summary

Returns all FabricSheet elements hosted by the referenced element.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.RebarHostData.GetPathReinforcementsInHost`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.GetPathReinforcementsInHost`

#### Summary

Returns all PathReinforcement elements hosted by the referenced element.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarHostData.GetAreaReinforcementsInHost`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.GetAreaReinforcementsInHost`

#### Summary

Returns all AreaReinforcement elements hosted by the referenced element.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarHostData.GetRebarsInHost`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.GetRebarsInHost`

#### Summary

Returns all Rebar elements hosted by the referenced element.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarHostData.SetCommonCoverType(Autodesk.Revit.DB.Structure.RebarCoverType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.SetCommonCoverType(Autodesk.Revit.DB.Structure.RebarCoverType)`

#### Summary

Associate a single CoverType with all exposed faces of the host element.

#### Parameter `coverType`

A CoverType object to be applied to all faces.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarHostData.GetCommonCoverType`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.GetCommonCoverType`

#### Summary

If all exposed faces of the host have the same associated CoverType,
return that CoverType; otherwise, return `null` .

#### Returns

The common CoverType for all exposed faces, or `null`
if there are multiple CoverTypes.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarHostData.SetCoverType(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Structure.RebarCoverType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.SetCoverType(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Structure.RebarCoverType)`

#### Summary

Associates the specified CoverType with the specified face of the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

In this element, face does not have an associated CoverType, because
it is not exposed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarHostData.GetCoverType(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.GetCoverType(Autodesk.Revit.DB.Reference)`

#### Summary

Gets the CoverType associated with a face of the element.

#### Returns

The cover associated with the face, if it is an exposed face.
If the face is concealed, returns `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarHostData.IsFaceExposed(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.IsFaceExposed(Autodesk.Revit.DB.Reference)`

#### Summary

Checks whether the specified face is considered exposed, and
therefore has an associated CoverType.

#### Remarks

This method replaces the method HasCoverTypeForReference() from
the 2011 Revit API.

#### Returns

True if %face% is exposed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarHostData.GetExposedFaces`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.GetExposedFaces`

#### Summary

Returns all the exposed faces, that is, those that have an associated CoverType.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarHostData.IsReferenceContainedByAValidHost(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.IsReferenceContainedByAValidHost(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

#### Summary

Identifies whether an element that contains the given reference can host reinforcement.

#### Remarks

Many different elements are allowed to host reinforcement,
for example, beams, walls, columns, or parts.
Often there are specific restrictions about whether an element
can host rebar beyond its type or category.
For example, the material type of the element may determine this.
Or for parts, the part must have been created from layers
that have their role set to Structure.

#### Parameter `doc`

A document.

#### Parameter `reference`

The reference that is part of the element that will be checked.

#### Returns

True if the input Element can host reinforcement elements,
false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.RebarHostData.IsValidHost(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.IsValidHost(Autodesk.Revit.DB.Element)`

#### Summary

Identifies whether a given element can host reinforcement.

#### Remarks

Many different elements are allowed to host reinforcement,
for example, beams, walls, columns, or parts.
Often there are specific restrictions about whether an element
can host rebar beyond its type or category.
For example, the material type of the element may determine this.
Or for parts, the part must have been created from layers
that have their role set to Structure.

#### Parameter `element`

The element to check.

#### Returns

True if the input Element can host reinforcement elements,
false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.RebarHostData.IsValidHost`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.IsValidHost`

#### Summary

Reports whether the element is a valid rebar host.

#### Remarks

If GetRebarHostData() returns a RebarHostData object,
but RebarHostData.IsValidHost() returns false, this means
that the element can be made
a valid rebar host, generally by setting a property
like FLOOR_PARAM_IS_STRUCTURAL or by changing the
element's physical material to concrete. On the other
hand, if GetRebarHostData() returns `null` , the element
cannot be made into a rebar host.

#### Returns

True if the referenced Element can currently host Rebar elements,
false otherwise.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarHostData.GetRebarHostData(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.GetRebarHostData(Autodesk.Revit.DB.Element)`

#### Summary

Gets a RebarHostData object referring to the specified
rebar host element.

#### Remarks

Returns `null` for elements that cannot ever be rebar hosts,
such as levels.

#### Parameter `host`

An element to host rebar.

#### Returns

A RebarHostData object, or `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.Structure.RebarHostData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarHostData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarHostData`

#### Summary

Interface to rebar-specific data stored in each valid rebar host element.

#### Remarks

Rebar host elements keep track of the "exposed faces," those that are not completely
concealed by another rebar host. Faces may be concealed by joins; for instance,
the top face of a beam that supports a slab is concealed. Faces can also be concealed
by adjacency; for instance, the bottom face of a column that is supported by a
foundation. Each exposed face of a rebar host must have a valid CoverType associated
with it.

Rebar hosts also have cover parameters, providing a limited interface
to the `M:Autodesk.Revit.DB.Structure.RebarHostData.GetCoverType(Autodesk.Revit.DB.Reference)` and `M:Autodesk.Revit.DB.Structure.RebarHostData.SetCoverType(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Structure.RebarCoverType)`
methods.
Each parameter simply gets or sets the cover setting associated with one or more
particular faces of the host.

CLEAR_COVER_EXTERIOR (walls only)

CLEAR_COVER_INTERIOR (walls only)

CLEAR_COVER_OTHER (all hosts except in-place families and stairs)

CLEAR_COVER (in-place families and stairs)

CLEAR_COVER_TOP (all hosts except walls, in-place families, and stairs)

CLEAR_COVER_BOTTOM (all hosts except walls, in-place families, and stairs)

### `M:RebarCoupler.getTargets`

Member kind: method
Symbol: `RebarCoupler.getTargets`

### `P:Autodesk.Revit.DB.Structure.ReinforcementData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.ReinforcementData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementData`

#### Summary

Abstract class for various reinforcement data

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.RebarCoupler.GetCouplerQuantity`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCoupler.GetCouplerQuantity`

#### Summary

Identifies the number of couplers in a set.

#### Returns

Returns the number of couplers in a set.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.RebarCoupler.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCoupler.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

#### Summary

Sets this rebar coupler element to be shown unobscured in a view.

#### Parameter `view`

The view element

#### Parameter `unobscured`

True if rebar coupler is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar coupler element doesn't have valid visibility data

#### Since

2018.3

### `M:Autodesk.Revit.DB.Structure.RebarCoupler.IsUnobscuredInView(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCoupler.IsUnobscuredInView(Autodesk.Revit.DB.View)`

#### Summary

Checks if this rebar coupler element is shown unobscured in a view.

#### Parameter `view`

The view element

#### Returns

True if rebar coupler is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar coupler element doesn't have valid visibility data

#### Since

2018.3

### `M:Autodesk.Revit.DB.Structure.RebarCoupler.GetCouplerPositionTransform(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCoupler.GetCouplerPositionTransform(System.Int32)`

#### Summary

Return a transform representing the relative position of the coupler at index couplerPositionIndex in the set.

#### Parameter `couplerPositionIndex`

An index between 0 and (CouplerQuantity-1).

#### Returns

Returns a transformation that is composed from :
- a translation from (0, 0, 0) to coupler origin
- a rotation that will align the coupler with the bar segment on which it stays.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

couplerPositionIndex is not in the range [ 0, CouplerQuantity-1 ].

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.RebarCoupler.GetPointsForPlacement`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCoupler.GetPointsForPlacement`

#### Summary

gets the point (or points in case of rebar set) where the coupler is placed

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.RebarCoupler.GetCoupledReinforcementData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCoupler.GetCoupledReinforcementData`

#### Summary

gets the reinforcement data. The returned list will have size = 2. If coupler stays on only one bar one element in this list will be null.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.RebarCoupler.CouplerLinkTwoBars`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCoupler.CouplerLinkTwoBars`

#### Summary

returns true if the coupler sits on two rebar and false otherwise

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.RebarCoupler.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.ReinforcementData,Autodesk.Revit.DB.Structure.ReinforcementData,Autodesk.Revit.DB.Structure.RebarCouplerError@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCoupler.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.ReinforcementData,Autodesk.Revit.DB.Structure.ReinforcementData,Autodesk.Revit.DB.Structure.RebarCouplerError@)`

#### Summary

Creates a new instance of a Rebar Coupler element within the project.

#### Parameter `doc`

A document.

#### Parameter `typeId`

type id for coupler

#### Parameter `pFirstData`

information about the first reinforcement to be coupled

#### Parameter `pSecondData`

information about the second reinforcement to be coupled;
if a nullptr is passed in the coupler is placed on one reinforcement

#### Parameter `error`

will be ValidationSuccesfully(0) if ok, otherwise the failure reason

#### Returns

The newly created Rebar Coupler instance, or `null` if the operation fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.RebarCoupler.RotationAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarCoupler.RotationAngle`

#### Summary

Indetifies the rotation angle of the coupler around its axis.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The rotation parameter cannot be set or get for Self-Orienting rebar coupler families ( rebar coupler families with FAMILY_SELF_ORIENTING parameter = 1 ).

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.RebarCoupler.CouplerMark`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarCoupler.CouplerMark`

#### Summary

gets and sets the coupler mark

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.RebarCoupler`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarCoupler`

#### Summary

Represents a rebar coupler element in Autodesk Revit.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.RebarCouplerError`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError`

#### Summary

Error states for the Rebar Coupler

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.ArcToStraightSegment`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.ArcToStraightSegment`

#### Summary

Cannot connect by coupler a straight segment with an arc segment.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.ArcsHaveDifferentCenters`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.ArcsHaveDifferentCenters`

#### Summary

Cannot place rebar couplers on arcs with different centers.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.ArcsHaveDifferentRadii`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.ArcsHaveDifferentRadii`

#### Summary

Cannot place rebar couplers on arcs with different radii.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.VaryingDistanceBetweenDistributionsBars`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.VaryingDistanceBetweenDistributionsBars`

#### Summary

All the bars from the selected sets, which need to be connected, must be separated by the same distance.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.BarSegmentSmallerThanEngagement`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.BarSegmentSmallerThanEngagement`

#### Summary

The selected leg is shorter than the bar engagement.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.CurvesOtherThanLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.CurvesOtherThanLine`

#### Summary

Cannot place rebar couplers on circular legs.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.InvalidDiameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.InvalidDiameter`

#### Summary

The selected coupler type cannot be applied to the selected bar size(s).

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.InconsistentShape`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.InconsistentShape`

#### Summary

One of the selected bars has an incorrect shape.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.BarSegmentsAreNotOnSameLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.BarSegmentsAreNotOnSameLine`

#### Summary

The selected legs are not aligned.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.BarSegementsAreNotParallel`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.BarSegementsAreNotParallel`

#### Summary

The selected legs are not aligned.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.IncorrectEndTreatmentCoupler`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.IncorrectEndTreatmentCoupler`

#### Summary

The coupler cannot be placed at an end that already has a coupler.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.IncorrectEndTreatmentHook`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.IncorrectEndTreatmentHook`

#### Summary

The coupler cannot be placed at an end that already has a hook.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.BarsNotTouching`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.BarsNotTouching`

#### Summary

The selected ends of the bars are too far apart.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.DifferentLayout`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.DifferentLayout`

#### Summary

The rebar sets have different numbers of bars.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.IncorrectInputData`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.IncorrectInputData`

#### Summary

Cannot place rebar coupler.

### `F:Autodesk.Revit.DB.Structure.RebarCouplerError.ValidationSuccessfuly`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarCouplerError.ValidationSuccessfuly`

#### Summary

Bars can be coupled

### `M:Autodesk.Revit.DB.Structure.RebarContainerType.GetOrCreateRebarContainerType(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerType.GetOrCreateRebarContainerType(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates or returns a RebarContainerType object with a given name.

#### Parameter `aDoc`

The document.

#### Parameter `name`

Name of the type.

#### Returns

The type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerType.CreateDefaultRebarContainerType(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerType.CreateDefaultRebarContainerType(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new RebarContainerType object with a default name.

#### Parameter `aDoc`

The document.

#### Returns

The newly created type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.RebarContainerType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerType`

#### Summary

Represents a Rebar Container Type, used in the generation of Rebar Container.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.AddSharedParameterAsOverride(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.AddSharedParameterAsOverride(Autodesk.Revit.DB.ElementId)`

#### Summary

Adds a shared parameter as one of the parameter overrides stored by this Rebar Container element.

#### Parameter `paramId`

The id of the shared parameter element

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not a valid Element identifier.
-or-
paramId is not the id of a shared parameter in the current document,
or its name was already used by another shared parameter of the element.
-or-
paramId is already a Rebar Container parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.IsRebarContainerParameter(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.IsRebarContainerParameter(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the parameter is a Rebar Container parameter

#### Parameter `paramId`

The id of the parameter element

#### Returns

True if the parameter is a Rebar Container parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.IsParameterOverridden(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.IsParameterOverridden(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the parameter has an override

#### Parameter `paramId`

The id of the parameter element

#### Returns

True if the parameter has an override

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.IsOverriddenParameterModifiable(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.IsOverriddenParameterModifiable(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if overridden parameter is modifiable.

#### Parameter `paramId`

Overridden parameter id

#### Returns

True if the parameter is modifiable, false if the parameter is readonly.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId has no override

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.SetOverriddenParameterModifiable(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.SetOverriddenParameterModifiable(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets this overridden parameter to be modifiable.

#### Parameter `paramId`

Overridden parameter id

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId has no override

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.SetOverriddenParameterReadonly(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.SetOverriddenParameterReadonly(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets this overridden parameter to be readonly.

#### Parameter `paramId`

Overridden parameter id

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId has no override

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.ClearOverrides`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.ClearOverrides`

#### Summary

Clears any overridden values from all parameters of the associated RebarContainer element.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.RemoveOverride(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.RemoveOverride(Autodesk.Revit.DB.ElementId)`

#### Summary

Removes an overridden value from the given parameter.

#### Parameter `paramId`

The id of the parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId has no override

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.GetElementIdOverrideValue(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.GetElementIdOverrideValue(Autodesk.Revit.DB.ElementId)`

#### Summary

Get the ElementId value for an overriden parameter.

#### Parameter `paramId`

The id of the parameter

#### Returns

The override value of the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not the id of a parameter in the current document,
or its value type is not ElementId.
-or-
paramId is not a Rebar Container parameter
-or-
paramId has no override

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.GetStringOverrideValue(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.GetStringOverrideValue(Autodesk.Revit.DB.ElementId)`

#### Summary

Get the string value for an overriden parameter.

#### Parameter `paramId`

The id of the parameter

#### Returns

The override value of the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not the id of a parameter in the current document,
or its value type is not sring.
-or-
paramId is not a Rebar Container parameter
-or-
paramId has no override

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.GetIntOverrideValue(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.GetIntOverrideValue(Autodesk.Revit.DB.ElementId)`

#### Summary

Get the integer value for an overriden parameter.

#### Parameter `paramId`

The id of the parameter

#### Returns

The override value of the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not the id of a parameter in the current document,
or its value type is not integer.
-or-
paramId is not a Rebar Container parameter
-or-
paramId has no override

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.GetDoubleOverrideValue(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.GetDoubleOverrideValue(Autodesk.Revit.DB.ElementId)`

#### Summary

Get the double value for an overriden parameter.

#### Parameter `paramId`

The id of the parameter

#### Returns

The override value of the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not the id of a parameter in the current document,
or its value type is not double.
-or-
paramId is not a Rebar Container parameter
-or-
paramId has no override

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.AddOverride(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.AddOverride(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Adds an override for the given parameter as its value will be displayed for the Rebar Container element.

#### Parameter `paramId`

The id of the parameter

#### Parameter `value`

The override value of the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not the id of a parameter in the current document,
or its value type is not ElementId.
-or-
paramId is not a Rebar Container parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.AddOverride(Autodesk.Revit.DB.ElementId,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.AddOverride(Autodesk.Revit.DB.ElementId,System.String)`

#### Summary

Adds an override for the given parameter as its value will be displayed for the Rebar Container element.

#### Parameter `paramId`

The id of the parameter

#### Parameter `value`

The override value of the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not the id of a parameter in the current document,
or its value type is not sring.
-or-
paramId is not a Rebar Container parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.AddOverride(Autodesk.Revit.DB.ElementId,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.AddOverride(Autodesk.Revit.DB.ElementId,System.Int32)`

#### Summary

Adds an override for the given parameter as its value will be displayed for the Rebar Container element.

#### Parameter `paramId`

The id of the parameter

#### Parameter `value`

The override value of the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not the id of a parameter in the current document,
or its value type is not integer.
-or-
paramId is not a Rebar Container parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.AddOverride(Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.AddOverride(Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Adds an override for the given parameter as its value will be displayed for the Rebar Container element.

#### Parameter `paramId`

The id of the parameter

#### Parameter `value`

The override value of the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not the id of a parameter in the current document,
or its value type is not double.
-or-
paramId is not a Rebar Container parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarContainerParameterManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerParameterManager`

#### Summary

Provides implementation of RebarContainer parameters overrides.

#### Remarks

When a new override is created, by default, the parameter will show the overridden value as read-only.
You can control whether or not the parameter is modifiable using `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.SetOverriddenParameterReadonly(Autodesk.Revit.DB.ElementId)` and `M:Autodesk.Revit.DB.Structure.RebarContainerParameterManager.SetOverriddenParameterModifiable(Autodesk.Revit.DB.ElementId)` .a

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.CanApplyPresentationMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.CanApplyPresentationMode(Autodesk.Revit.DB.View)`

#### Summary

Checks if a presentation mode can be applied for this rebar in the given view.

#### Parameter `dBView`

The view in which presentation mode will be applied.

#### Returns

True if presentation mode can be applied for this view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.FindMatchingPredefinedPresentationMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.FindMatchingPredefinedPresentationMode(Autodesk.Revit.DB.View)`

#### Summary

Determines if there is a matching RebarPresentationMode for the current set of selected hidden and unhidden bars assigned to the given view.

#### Remarks

If the presentation mode is not PresentationMode.Select for the view, this function returns the current mode.

#### Parameter `dBView`

The view.

#### Returns

The presentation mode that matches the current set of selected hidden and unhidden bars.
If there is no better match, this returns RebarPresentationMode.Select.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.GetPresentationMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.GetPresentationMode(Autodesk.Revit.DB.View)`

#### Summary

Gets the presentaion mode for this rebar set when displayed in the given view.

#### Parameter `dBView`

The view.

#### Returns

The presentation mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetPresentationMode(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Structure.RebarPresentationMode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.SetPresentationMode(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Structure.RebarPresentationMode)`

#### Summary

Sets the presentation mode for this rebar set when displayed in the given view.

#### Parameter `dBView`

The view.

#### Parameter `presentationMode`

The presentation mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This rebar cannot have a presentation mode applied for dBView, as the view is not valid for rebar presentation,
or the orientation of the view matches the normal direction of the rebar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.ClearPresentationMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.ClearPresentationMode(Autodesk.Revit.DB.View)`

#### Summary

Sets the presentation mode for this rebar set to the default (either for a single view, or for all views).

#### Parameter `dBView`

The view where the presentation mode will be cleared. NULL for all views

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.HasPresentationOverrides(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.HasPresentationOverrides(Autodesk.Revit.DB.View)`

#### Summary

Identifies if this rebar set has overridden default presentation settings for the given view.

#### Remarks

Default presentation settings can be overriden using `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetBarHiddenStatus(Autodesk.Revit.DB.View,System.Int32,System.Boolean)` , `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetPresentationMode(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Structure.RebarPresentationMode)` methods

#### Parameter `dBView`

The view.

#### Returns

True if this rebar set has overriden default presentation settings, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.IsRebarInSection(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.IsRebarInSection(Autodesk.Revit.DB.View)`

#### Summary

Identifies if this rebar set is shown as a cross-section in the given view.

#### Parameter `dBView`

The view.

#### Returns

True if this rebar set is shown as a cross-section, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.IsBarHidden(Autodesk.Revit.DB.View,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.IsBarHidden(Autodesk.Revit.DB.View,System.Int32)`

#### Summary

Identifies if a given bar in this rebar set is hidden in this view.

#### Parameter `view`

The view.

#### Parameter `barIndex`

The index of the bar from this rebar set.

#### Returns

True if the bar is hidden in this view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetBarHiddenStatus(Autodesk.Revit.DB.View,System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.SetBarHiddenStatus(Autodesk.Revit.DB.View,System.Int32,System.Boolean)`

#### Summary

Sets the bar in this rebar set to be hidden or unhidden in the given view.

#### Remarks

Individual bars of a rebar set can be hidden in a view only
if the presentation mode is RebarPresentationMode.Select.
If that is not the presentation mode assigned for this set in the view,
this method will also change it.

#### Parameter `view`

The view.

#### Parameter `barIndex`

The index of the bar from this set.

#### Parameter `hide`

True to hide this bar in the view, false to unhide the bar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This rebar cannot have a presentation mode applied for view, as the view is not valid for rebar presentation,
or the orientation of the view matches the normal direction of the rebar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.CanUseHookType(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.CanUseHookType(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the specified RebarHookType id is of a valid RebarHookType for the Rebar's RebarBarType

#### Remarks

Also, checks that the Style of the Hook matches that of the Rebar's RebarShape

#### Parameter `proposedHookId`

The Id of the RebarHookType

#### Returns

Returns true if the id is of a valid RebarHookType for the Rebar element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetHookOrientation(System.Int32,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.SetHookOrientation(System.Int32,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

#### Summary

Defines the orientation of the hook plane at the start or at the end of the rebar with respect to the orientation of the first or the last curve and the plane normal.

#### Remarks

If RebarShapeDefinesHooks property of ReinforcementSettings is true (non-European shapes), setHookOrientation method does nothing.

#### Parameter `iEnd`

0 for the start hook, 1 for the end hook.

#### Parameter `hookOrientation`

Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

iEnd must be 0 or 1.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.GetHookOrientation(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.GetHookOrientation(System.Int32)`

#### Summary

Returns the orientation of the hook plane at the start or at the end of the rebar with respect to the orientation of the first or the last curve and the plane normal.

#### Parameter `iEnd`

0 for the start hook, 1 for the end hook.

#### Returns

Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

iEnd must be 0 or 1.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.DoesBarExistAtPosition(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.DoesBarExistAtPosition(System.Int32)`

#### Summary

Checks whether a bar exists at the specified position.

#### Remarks

Returns true, unless the bar position is the first or last
in the set and it is suppressed by IncludeFirstBar or
IncludeLastBar.

#### Parameter `barPosition`

A bar position index between 0 and NumberOfBarPositions-1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPosition is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetHookTypeId(System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.SetHookTypeId(System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Set the id of the RebarHookType to be applied to the rebar.

#### Parameter `end`

0 for the start hook, 1 for the end hook.

#### Parameter `hookTypeId`

The id of a RebarHookType element, or invalidElementId if
the rebar should have no hook at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the rebar hook type id hookTypeId is not valid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.GetHookTypeId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.GetHookTypeId(System.Int32)`

#### Summary

Get the id of the RebarHookType to be applied to the rebar.

#### Parameter `end`

0 for the start hook, 1 for the end hook.

#### Returns

The id of a RebarHookType, or invalidElementId if the rebar has
no hook at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.GetBendData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.GetBendData`

#### Summary

Gets the RebarBendData, containing bar and hook information, of the instance.

#### Remarks

Internally, the bend data is used by many RebarShape methods to generate shape geometry.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetLayoutAsMinimumClearSpacing(System.Double,System.Double,System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.SetLayoutAsMinimumClearSpacing(System.Double,System.Double,System.Boolean,System.Boolean,System.Boolean)`

#### Summary

Sets the Layout Rule property of rebar set to MinimumClearSpacing

#### Remarks

When changing the layout rule to MinimumClearSpacing, you must also simultaneously set Spacing,
SetLength, BarsOnNormalSide, IncludeFirstBar, and IncludeLastBar properties.

#### Parameter `spacing`

The maximum spacing between rebar in rebar set

#### Parameter `arrayLength`

The distribution length of rebar set

#### Parameter `barsOnNormalSide`

Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal

#### Parameter `includeFirstBar`

Identifies if the first bar in rebar set is shown

#### Parameter `includeLastBar`

Identifies if the last bar in rebar set is shown

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The spacing isn't bigger than 0.0.
-or-
the set length arrayLength isn't acceptable.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This RebarContainerItem is an instance of a spiral or multiplanar shape.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetLayoutAsNumberWithSpacing(System.Int32,System.Double,System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.SetLayoutAsNumberWithSpacing(System.Int32,System.Double,System.Boolean,System.Boolean,System.Boolean)`

#### Summary

Sets the Layout Rule property of rebar set to NumberWithSpacing

#### Remarks

When changing the layout rule to NumberWithSpacing, you must also simultaneously set NumberOfBarPositions,
Spacing, BarsOnNormalSide, IncludeFirstBar, and IncludeLastBar properties.

#### Parameter `numberOfBarPositions`

The number of bar positions in rebar set

#### Parameter `spacing`

The maximum spacing between rebar in rebar set

#### Parameter `barsOnNormalSide`

Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal

#### Parameter `includeFirstBar`

Identifies if the first bar in rebar set is shown

#### Parameter `includeLastBar`

Identifies if the last bar in rebar set is shown

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the number of bar positions numberOfBarPositions is less than 1 or more than 1002.
-or-
The spacing isn't bigger than 0.0.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This RebarContainerItem is an instance of a spiral or multiplanar shape.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetLayoutAsMaximumSpacing(System.Double,System.Double,System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.SetLayoutAsMaximumSpacing(System.Double,System.Double,System.Boolean,System.Boolean,System.Boolean)`

#### Summary

Sets the Layout Rule property of rebar set to MaximumSpacing

#### Remarks

When changing the layout rule to MaximumSpacing, you must also simultaneously set Spacing,
SetLength, BarsOnNormalSide, IncludeFirstBar, and IncludeLastBar properties.

#### Parameter `spacing`

The maximum spacing between rebar in rebar set

#### Parameter `arrayLength`

The distribution length of rebar set

#### Parameter `barsOnNormalSide`

Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal

#### Parameter `includeFirstBar`

Identifies if the first bar in rebar set is shown

#### Parameter `includeLastBar`

Identifies if the last bar in rebar set is shown

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The spacing isn't bigger than 0.0.
-or-
the set length arrayLength isn't acceptable.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This RebarContainerItem is an instance of a spiral or multiplanar shape.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetLayoutAsFixedNumber(System.Int32,System.Double,System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.SetLayoutAsFixedNumber(System.Int32,System.Double,System.Boolean,System.Boolean,System.Boolean)`

#### Summary

Sets the Layout Rule property of rebar set to FixedNumber.

#### Remarks

When changing the layout rule to FixedNumber, you must also simultaneously set NumberOfBarPositions,
SetLength, BarsOnNormalSide, IncludeFirstBar, and IncludeLastBar properties.

#### Parameter `numberOfBarPositions`

The number of bar positions in rebar set

#### Parameter `arrayLength`

The distribution length of rebar set

#### Parameter `barsOnNormalSide`

Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal

#### Parameter `includeFirstBar`

Identifies if the first bar in rebar set is shown

#### Parameter `includeLastBar`

Identifies if the last bar in rebar set is shown

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the number of bar positions numberOfBarPositions is less than 1 or more than 1002.
-or-
the set length arrayLength isn't acceptable.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This RebarContainerItem is an instance of a spiral or multiplanar shape.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetLayoutAsSingle`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.SetLayoutAsSingle`

#### Summary

Sets the Layout Rule property of rebar set to Single.

#### Remarks

Only one bar will remain, which is at the position of rebar plane

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.ComputeDrivingCurves`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.ComputeDrivingCurves`

#### Summary

Compute the driving curves.

#### Remarks

The driving curves are the ones that appear in rebar sketch
mode. They include lines and arcs that drive the shape, but
exclude fillets and hooks. They always lie in a plane--
if the bar is 3D, these curves are a subset or a projection.
They are also used for shape matching.

#### Returns

Returns an empty array if an error is encountered.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.GetBarPositionTransform(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.GetBarPositionTransform(System.Int32)`

#### Summary

Return a transform representing the relative position of any
individual bar in the set.

#### Remarks

The transform is a translation along the distribution path.
It can be applied to the results of GetCenterlineCurves() to
produce any bar in the rebar set. For barPositionIndex=0,
the identity transform is always returned.

#### Parameter `barPositionIndex`

An index between 0 and (NumberOfBarPositions-1).

#### Returns

The position of a bar in the set relative to the first position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.GetDistributionPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.GetDistributionPath`

#### Summary

The distribution path of a rebar set.

#### Returns

A line beginning at (0, 0, 0) and representing the direction and
length of the set.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.GetCenterlineCurves(System.Boolean,System.Boolean,System.Boolean,Autodesk.Revit.DB.Structure.MultiplanarOption)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.GetCenterlineCurves(System.Boolean,System.Boolean,System.Boolean,Autodesk.Revit.DB.Structure.MultiplanarOption)`

#### Summary

A chain of curves representing the centerline of the rebar.

#### Remarks

If the Rebar is a set, meaning GetLayoutRule() does not return Single,
this method returns the first rebar in the set, even if the
first bar is suppressed by IncludeFirstBar being false.

#### Parameter `adjustForSelfIntersection`

If the curves overlap, as in a planar stirrup, this parameter controls
whether they should be adjusted to avoid intersection (as in fine views),
or kept in a single plane for simplicity (as in coarse views).

#### Parameter `suppressHooks`

Identifies if the chain will include hooks curves.

#### Parameter `suppressBendRadius`

Identifies if the connected chain will include unfilleted curves.

#### Parameter `multiplanarOption`

If the Rebar is a multi-planar shape, this parameter controls whether to generate only
the curves in the primary plane (IncludeOnlyPlanarCurves), or to generate all curves,
(IncludeAllMultiplanarCurves) including the out-of-plane connector segments as well as
multi-planar copies of the primary plane curves.
This argument is ignored for planar shapes.

#### Returns

The centerline curves or empty array if the curves cannot be computed because
the parameters values are inconsistent
with the constraints of the RebarShape definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.GetCenterlineCurves(System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.GetCenterlineCurves(System.Boolean,System.Boolean,System.Boolean)`

#### Summary

A chain of curves representing the centerline of the rebar.

#### Remarks

If the Rebar is a set, meaning GetLayoutRule() does not return Single,
this method returns the first rebar in the set, even if the
first bar is suppressed by IncludeFirstBar being false.

#### Parameter `adjustForSelfIntersection`

If the curves overlap, as in a planar stirrup, this parameter controls
whether they should be adjusted to avoid intersection (as in fine views),
or kept in a single plane for simplicity (as in coarse views).

#### Parameter `suppressHooks`

Identifies if the chain will include hooks curves.

#### Parameter `suppressBendRadius`

Identifies if the connected chain will include unfilleted curves.

#### Returns

The centerline curves or empty array if the curves cannot be computed because
the parameters values are inconsistent
with the constraints of the RebarShape definition.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetFromCurvesAndShape(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.SetFromCurvesAndShape(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

#### Summary

Set an instance of a RebarContainerItem element according to the parameters list.
The instance will have the default shape parameters from the RebarShape.
If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to true,
then both the curves and hooks must match the RebarShape definition.
Otherwise, the hooks can be different than the defaults specified in the RebarShape

#### Parameter `rebarShape`

A RebarShape element that defines the shape of the rebar.
A RebarShape element matches curves and hooks.
A RebarShape element provides RebarStyle of the rebar.

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `startHook`

A RebarHookType element that defines the hook for the start of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `endHook`

A RebarHookType element that defines the hook for the end of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `norm`

The normal to the plane that the rebar curves lie on.

#### Parameter `curves`

An array of curves that define the shape of the rebar curves.
They must belong to the plane defined by the normal and origin.
Bends and hooks should not be included in the array of curves.

#### Parameter `startHookOrient`

Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `endHookOrient`

Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curves is empty.
-or-
The input curves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
curves do not form a valid CurveLoop.
-or-
The input curves contains at least one helical curve and is not supported for this operation.
-or-
The rebarShape has End Treatments

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

norm has zero length.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

curves contains non-fillet arcs with radii that are less than the
minimum bend radius for the RebarBarType and RebarShape style.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

rebarShape does not match curves.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetFromRebarShape(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.SetFromRebarShape(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Set an instance of a RebarContainerItem element, as an instance of a RebarShape.
The instance will have the default shape parameters from the RebarShape,
and its location is based on the bounding box of the shape in the shape definition.
Hooks are removed from the shape before computing its bounding box.
If appropriate hooks can be found in the document, they will be assigned arbitrarily.

#### Parameter `rebarShape`

A RebarShape element that defines the shape of the rebar.

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `origin`

The lower-left corner of the shape's bounding box will be placed at this point in the project.

#### Parameter `xVec`

The x-axis in the shape definition will be mapped to this direction in the project.

#### Parameter `yVec`

The y-axis in the shape definition will be mapped to this direction in the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The rebarShape has End Treatments

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

xVec has zero length.
-or-
yVec has zero length.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetFromCurves(Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.SetFromCurves(Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Boolean,System.Boolean)`

#### Summary

Set an instance of a RebarContainerItem element according to the parameters list.

#### Parameter `style`

The usage of the bar, "standard" or "stirrup/tie".

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `startHook`

A RebarHookType element that defines the hook for the start of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `endHook`

A RebarHookType element that defines the hook for the end of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `norm`

The normal to the plane that the rebar curves lie on.

#### Parameter `curves`

An array of curves that define the shape of the rebar curves.
They must belong to the plane defined by the normal and origin.
Bends and hooks should not be included in the array of curves.

#### Parameter `startHookOrient`

Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `endHookOrient`

Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `useExistingShapeIfPossible`

Attempts to assign a RebarShape from those existing in the document. If no shape matches, NewRebar returns or creates a new shape, according to the parameter createNewShape.
When both parameters are "true", the behavior is the same as sketching rebar in the UI. At least one of these parameters must be "true".
If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to false, and a RebarShape cannot be found with both matching curves and hooks,
then this method will perform a second search, ignoring hook information.

#### Parameter `createNewShape`

Creates a shape in the document to match the curves, hooks, and style specified, and assigns it to the new rebar instance.
Shape creation will not succeed unless one or more other shapes already exist in the document, and these shapes
have enough shape parameters to define a shape for these curves.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curves is empty.
-or-
The input curves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
curves do not form a valid CurveLoop.
-or-
The input curves contains at least one helical curve and is not supported for this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

norm has zero length.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Both useExistingShapeIfPossible and createNewShape are false.
-or-
curves contains non-fillet arcs with radii that are less than the
minimum bend radius for the RebarBarType and bar style.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerItem.SetFromRebar(Autodesk.Revit.DB.Structure.Rebar)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.SetFromRebar(Autodesk.Revit.DB.Structure.Rebar)`

#### Summary

Set an instance of a RebarContainerItem element according to a Rebar parameters.
Will throw exception if given rebar is not shape driven.
Will throw exception if given rebar has moved bars in set.

#### Parameter `rebar`

The Rebar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The RebarShape of rebar has End Treatments
-or-
Can't create container from free-form rebar.
-or-
Can't create container from Rebar with moved bars.
-or-
Can't create container from Rebar which has excluded bars other than the first and last one.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.ItemIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.ItemIndex`

#### Summary

The index of this item in its associated RebarContainer.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.NumberOfBarPositions`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.NumberOfBarPositions`

#### Summary

The number of potential bars in the set.

#### Remarks

The number of positions is equal to the number of actual
bars (the Quantity), plus one or two more positions depending
on IncludeFistBar and IncludeLastBar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: the number of bar positions numberOfBarPositions is less than 1 or more than 1002.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: This rebar element represents a single bar (the layout rule is Single).

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.RebarShapeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.RebarShapeId`

#### Summary

The RebarShape element that defines the shape of the rebar.

#### Remarks

Changing the value of this property causes the Rebar instance to choose values for its
shape parameters to preserve its previous shape as closely as possible

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: shapeId is not the id of a RebarShape in the document.
-or-
When setting this property: The RebarShape has End Treatments

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.Volume`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.Volume`

#### Summary

The volume of an individual bar multiplied by Quantity.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.TotalLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.TotalLength`

#### Summary

The length of an individual bar multiplied by Quantity.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.MultiplanarDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.MultiplanarDepth`

#### Summary

For a multiplanar rebar, the depth of the instance.

#### Remarks

Applicable only when an instance of a RebarShape with
a RebarShapeMultiplanarDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: multiplanarDepth must be positive.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarContainerItem is not an instance of a multiplanar shape.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.Pitch`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.Pitch`

#### Summary

For a spiral, the pitch, or vertical distance traveled in one rotation.

#### Remarks

Applies only to instances where RebarShape.Definition is of type
RebarShapeDefinitionByArc, and its Type property is equal to the value
RebarShapeDefinitionByArcType.Spiral.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: pitch must be positive.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarContainerItem is not an instance of a spiral shape.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.TopFinishingTurns`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.TopFinishingTurns`

#### Summary

For a spiral, the number of finishing turns at the upper end of the spiral.

#### Remarks

Applies only to instances where RebarShape.Definition is of type
RebarShapeDefinitionByArc, and its Type property is equal to the value
RebarShapeDefinitionByArcType.Spiral.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: turns must be between 0 and 100.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarContainerItem is not an instance of a spiral shape.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.BaseFinishingTurns`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.BaseFinishingTurns`

#### Summary

For a spiral, the number of finishing turns at the lower end of the spiral.

#### Remarks

Applies only to instances where RebarShape.Definition is of type
RebarShapeDefinitionByArc, and its Type property is equal to the value
RebarShapeDefinitionByArcType.Spiral.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: turns must be between 0 and 100.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarContainerItem is not an instance of a spiral shape.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.Height`

#### Summary

For a spiral, the overall height.

#### Remarks

Applies only to instances where RebarShape.Definition is of type
RebarShapeDefinitionByArc, and its Type property is equal to the value
RebarShapeDefinitionByArcType.Spiral.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: height must be positive.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarContainerItem is not an instance of a spiral shape.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.IncludeLastBar`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.IncludeLastBar`

#### Summary

Identifies if the last bar in rebar set is shown.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.IncludeFirstBar`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.IncludeFirstBar`

#### Summary

Identifies if the first bar in rebar set is shown.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.LayoutRule`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.LayoutRule`

#### Summary

Identifies the layout rule of rebar set.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.MaxSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.MaxSpacing`

#### Summary

Identifies the maximum spacing between rebar in rebar set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The maxSpacing isn't bigger than 0.0.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.Quantity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.Quantity`

#### Summary

Identifies the number of bars in rebar set.

#### Remarks

Quantity is equal to NumberOfBarPositions if IncludeFirstBar and IncludeLastBar are set.
If any end bars are excluded, they are not counted in the Quantity.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.ArrayLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.ArrayLength`

#### Summary

Identifies the distribution path length of rebar set.

#### Value

The distribution path length of rebar set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: the set length arrayLength isn't acceptable.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.BarsOnNormalSide`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.BarsOnNormalSide`

#### Summary

Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal.

#### Value

True if the bars of rebar set are on the same side of the rebar plane indicated by the normal,
and false if the bars are on the opposite side.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.Normal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.Normal`

#### Summary

A unit-length vector normal to the plane of the rebar

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerItem.BarTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem.BarTypeId`

#### Summary

The identifier of the rebar bar type.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.RebarContainerItem`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerItem`

#### Summary

Provides implementation for Rebar stored in RebarContainer.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerIterator.CurrentObject`

### `P:Autodesk.Revit.DB.Structure.RebarContainerIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.Structure.RebarContainerIterator.GetCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerIterator.GetCurrent`

#### Summary

Returns the current rebar container item.

#### Returns

The current rebar container item.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainerIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerIterator.MoveNext`

#### Summary

Increments the iterator to the next item.

#### Remarks

After an enumerator is created or after the Reset method is called, an enumerator is positioned before the first element of the collection,
and the first call to the MoveNext method moves the enumerator over the first element of the collection.

#### Returns

True if there is a next available item in this iterator.
False if the iterator has completed all available items.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainerIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarContainerIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarContainerIterator`

#### Summary

An iterator to a Rebar Container.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Structure.RebarContainer.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Structure.RebarContainer.GetRebarContainerIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.GetRebarContainerIterator`

#### Summary

Returns a Rebar Container Iterator that iterates through the Rebar Container Items.

#### Returns

A Rebar Container Iterator object that can be used to iterate through Rebar Container Items in the collection.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.SetHostId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.SetHostId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

The element that contains the rebar.

#### Parameter `doc`

The document containing both this element and the host element.

#### Parameter `hostId`

The element that the rebar object belongs to, such as a structural
wall, floor, foundation, beam, brace or column. The rebar does not need
to be strictly inside the host, but it must be assigned to one host
element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

hostId is not a legal Rebar Container host.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.GetHostId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.GetHostId`

#### Summary

The element that contains the rebar.

#### Returns

The element that the rebar object belongs to, such as a structural
wall, floor, foundation, beam, brace or column.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

#### Summary

Sets this rebar container element to be shown unobscured in a view.

#### Parameter `view`

The view element

#### Parameter `unobscured`

True if rebar is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar container element doesn't have valid visibility data.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.IsUnobscuredInView(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.IsUnobscuredInView(Autodesk.Revit.DB.View)`

#### Summary

Checks if this rebar container element is shown unobscured in a view.

#### Parameter `view`

The view element

#### Returns

True if rebar is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar container element doesn't have valid visibility data.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.Contains(Autodesk.Revit.DB.Structure.RebarContainerItem)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.Contains(Autodesk.Revit.DB.Structure.RebarContainerItem)`

#### Summary

Checks if the RebarContainer has this item as one of its members.

#### Parameter `pItem`

The item to be checked if RebarContainer has it as one of its members

#### Returns

True if RebarContainer has this item as one of its members, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.IsItemHidden(Autodesk.Revit.DB.View,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.IsItemHidden(Autodesk.Revit.DB.View,System.Int32)`

#### Summary

Identifies if a given RebarContainerItem is hidden in this view.

#### Parameter `view`

The view.

#### Parameter `itemIndex`

Item index in the Rebar Container.

#### Returns

True if the RebarContainerItem is hidden in this view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The item index is either less than 0 or graeter than or equal to number of items in this Rebar Container element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.RebarContainer.SetItemHiddenStatus(Autodesk.Revit.DB.View,System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.SetItemHiddenStatus(Autodesk.Revit.DB.View,System.Int32,System.Boolean)`

#### Summary

Sets the RebarContainerItem to be hidden or unhidden in the given view.

#### Parameter `view`

The view.

#### Parameter `itemIndex`

Item index in the Rebar Container.

#### Parameter `hide`

True to hide this RebarContainerItem in the view, false to unhide the item.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The item index is either less than 0 or graeter than or equal to number of items in this Rebar Container element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.RebarContainer.CanApplyPresentationMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.CanApplyPresentationMode(Autodesk.Revit.DB.View)`

#### Summary

Checks if a presentation mode can be applied for this RebarContainer in the given view.

#### Parameter `dBView`

The view in which presentation mode will be applied.

#### Returns

True if presentation mode can be applied for this view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.HasPresentationOverrides(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.HasPresentationOverrides(Autodesk.Revit.DB.View)`

#### Summary

Identifies if any RebarContainerItem of this RebarContainer has overridden default presentation settings for the given view.

#### Remarks

Default presentation settings can be overriden using `!:Autodesk::Revit::DB::Structure::RebarContainerItem::SetBarHiddenStatus` , `!:Autodesk::Revit::DB::Structure::RebarContainerItem::SetPresentationMode` methods

#### Parameter `dBView`

The view.

#### Returns

True if if any RebarContainerItem of this RebarContainer has overridden default presentation settings, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.GetReinforcementRoundingManager`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.GetReinforcementRoundingManager`

#### Summary

Returns an object for managing reinforcement rounding override settings.

#### Returns

The rounding manager.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.GetParametersManager`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.GetParametersManager`

#### Summary

Returns an object used to manage parameters of the Rebar Container.

#### Returns

The parameters manager.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.GetItem(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.GetItem(System.Int32)`

#### Summary

Gets the item stored in the RebarContainer at the associated index.

#### Parameter `itemIndex`

Item index in the Rebar Container

#### Returns

Rebar Container Item

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The item index is either less than 0 or graeter than or equal to number of items in this Rebar Container element.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.RemoveItem(Autodesk.Revit.DB.Structure.RebarContainerItem)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.RemoveItem(Autodesk.Revit.DB.Structure.RebarContainerItem)`

#### Summary

Removes Item from the Rebar Container.

#### Parameter `pItem`

Item to be removed from this Rebar Container

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The item is not a member of this Rebar Container element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.AppendItemFromCurvesAndShape(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.AppendItemFromCurvesAndShape(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

#### Summary

Appends an Item to the RebarContainer. Fills its data on base of the Rebar.

#### Parameter `rebarShape`

A RebarShape element that defines the shape of the rebar.
A RebarShape element matches curves and hooks.
A RebarShape element provides RebarStyle of the rebar.

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `startHook`

A RebarHookType element that defines the hook for the start of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `endHook`

A RebarHookType element that defines the hook for the end of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `normal`

The normal to the plane that the rebar curves lie on.

#### Parameter `curves`

An array of curves that define the shape of the rebar curves.
They must belong to the plane defined by the normal and origin.
Bends and hooks should not be included in the array of curves.

#### Parameter `startHookOrient`

Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `endHookOrient`

Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Returns

The Rebar Container Item.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curves is empty.
-or-
The input curves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
curves do not form a valid CurveLoop.
-or-
The input curves contains at least one helical curve and is not supported for this operation.
-or-
The rebarShape has End Treatments

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

normal has zero length.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

curves contains non-fillet arcs with radii that are less than the
minimum bend radius for the RebarBarType and RebarShape style.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

rebarShape does not match curves.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.AppendItemFromRebarShape(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.AppendItemFromRebarShape(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Appends an Item to the RebarContainer. Fills its data on base of the Rebar.

#### Parameter `rebarShape`

A RebarShape element that defines the shape of the rebar.

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `origin`

The lower-left corner of the shape's bounding box will be placed at this point in the project.

#### Parameter `xVector`

The x-axis in the shape definition will be mapped to this direction in the project.

#### Parameter `yVector`

The y-axis in the shape definition will be mapped to this direction in the project.

#### Returns

The Rebar Container Item.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The rebarShape has End Treatments

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

xVector has zero length.
-or-
yVector has zero length.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.AppendItemFromCurves(Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.AppendItemFromCurves(Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Boolean,System.Boolean)`

#### Summary

Appends an Item to the RebarContainer. Fills its data on base of the Rebar.

#### Parameter `style`

The usage of the bar, "standard" or "stirrup/tie".

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `startHook`

A RebarHookType element that defines the hook for the start of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `endHook`

A RebarHookType element that defines the hook for the end of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `normal`

The normal to the plane that the rebar curves lie on.

#### Parameter `curves`

An array of curves that define the shape of the rebar curves.
They must belong to the plane defined by the normal and origin.
Bends and hooks should not be included in the array of curves.

#### Parameter `startHookOrient`

Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `endHookOrient`

Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `useExistingShapeIfPossible`

Attempts to assign a RebarShape from those existing in the document. If no shape matches, NewRebar returns or creates a new shape, according to the parameter createNewShape.
When both parameters are "true", the behavior is the same as sketching rebar in the UI. At least one of these parameters must be "true".
If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to false, and a RebarShape cannot be found with both matching curves and hooks,
then this method will perform a second search, ignoring hook information.

#### Parameter `createNewShape`

Creates a shape in the document to match the curves, hooks, and style specified, and assigns it to the new rebar instance.
Shape creation will not succeed unless one or more other shapes already exist in the document, and these shapes
have enough shape parameters to define a shape for these curves.

#### Returns

The Rebar Container Item.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curves is empty.
-or-
The input curves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
curves do not form a valid CurveLoop.
-or-
The input curves contains at least one helical curve and is not supported for this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

normal has zero length.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Both useExistingShapeIfPossible and createNewShape are false.
-or-
curves contains non-fillet arcs with radii that are less than the
minimum bend radius for the RebarBarType and bar style.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.AppendItemFromRebar(Autodesk.Revit.DB.Structure.Rebar)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.AppendItemFromRebar(Autodesk.Revit.DB.Structure.Rebar)`

#### Summary

Appends an Item to the RebarContainer. Fills its data on base of the Rebar.
Will throw exception if given rebar is not shape driven.
Will throw exception if given rebar has moved bars in set.

#### Parameter `rebar`

The Rebar.

#### Returns

The Rebar Container Item.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The RebarShape of rebar has End Treatments
-or-
Can't create container from free-form rebar.
-or-
Can't create container from Rebar with moved bars.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.ClearItems`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.ClearItems`

#### Summary

Clears all the Items stored in this Rebar Container element.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarContainer.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of a Rebar Container element within the project.

#### Remarks

Created Rebar Container starts out empty.
Use appendItemFromRebar, appendItemFromCurves, appendItemFromRebarShape, appendItemFromCurvesAndShape to fill its content.

#### Parameter `aDoc`

A document.

#### Parameter `hostElement`

The element that will host the RebarContainer.

#### Parameter `rebarContainerTypeId`

The id of the RebarContainerType.

#### Returns

The newly created Rebar Container instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element hostElement was not found in the given document.
-or-
hostElement is not a valid rebar host.
-or-
the ElementId rebarContainerTypeId is either invalid or not a RebarContainerType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainer.ItemsCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.ItemsCount`

#### Summary

The count of Items in this Rebar Container.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarContainer.PresentItemsAsSubelements`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.PresentItemsAsSubelements`

#### Summary

Identifies if Items should be presented in schedules and tags as separate subelements.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.RebarContainer.ScheduleMark`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer.ScheduleMark`

#### Summary

The Schedule Mark parameter. On creation, the Schedule Mark is set
to a value that is unique to the host, but it can be set to
any value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.RebarContainer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarContainer`

#### Summary

An object that represents an Rebar Container Element within the Autodesk Revit project.

#### Remarks

This object is derived from the Element base object and such supports all the
methods of that object such as the ability to retrieve the parameters of that object.
The Rebar Container element is available only in the Autodesk Revit Structure product.
It is a collection of rebar sets. Every rebar set can be modified separately.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarCoverType.Create(Autodesk.Revit.DB.Document,System.String,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCoverType.Create(Autodesk.Revit.DB.Document,System.String,System.Double)`

#### Summary

Creates a new CoverType in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

coverDistance cannot be negative.

### `P:Autodesk.Revit.DB.Structure.RebarCoverType.CoverDistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarCoverType.CoverDistance`

#### Summary

A distance that can be used as a concrete cover value in a document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: coverDistance cannot be negative.

### `T:Autodesk.Revit.DB.Structure.RebarCoverType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarCoverType`

#### Summary

A named value for a clear cover distance.

#### Remarks

In Revit Structure, CoverTypes are the rows in the Rebar Cover Settings dialog.

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.HasAnEdgeNumber`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.HasAnEdgeNumber`

#### Summary

Checks if the getTargetRebarEdgeNumber method can be called for the RebarConstraint.

#### Remarks

The RebarConstraintType of the RebarConstraint must be 'ToOtherRebar,' and the
RebarTargetConstraintType must be 'Edge' or 'BarBend.'

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.TargetIsHookBend`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.TargetIsHookBend`

#### Summary

Returns true if the RebarTargetConstraintType of the RebarConstraint is 'HookBend'.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.TargetIsBarBend`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.TargetIsBarBend`

#### Summary

Returns true if the RebarTargetConstraintType of the RebarConstraint is 'BarBend'.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.TargetRebarConstraintTypeIsEdge`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.TargetRebarConstraintTypeIsEdge`

#### Summary

Returns true if the RebarConstraintType of the RebarConstraint is 'ToOtherRebar,'
and the RebarConstraint is attached to an edge of the other Rebar Element.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.IsToHostFaceOrCover`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.IsToHostFaceOrCover`

#### Summary

Returns true if the RebarConstraintType of the RebarConstraint is either 'FixedDistanceToHostFace' or 'ToCover.'

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.ConstrainsRebarEnds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.ConstrainsRebarEnds`

#### Summary

Returns true if this constraint constrains two rebar ends.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.IsToOtherRebar`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.IsToOtherRebar`

#### Summary

Returns true if the RebarConstraintType of the RebarConstraint is 'ToOtherRebar.'

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.IsToCover`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.IsToCover`

#### Summary

Returns true if the RebarConstraintType of the RebarConstraint is 'ToCover.'

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.IsFixedDistanceToHostFace`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.IsFixedDistanceToHostFace`

#### Summary

Returns true if the RebarConstraintType of the RebarConstraint is 'FixedDistanceToHostFace.'

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.IsValid`

#### Summary

Checks that the RebarConstraint still has access to valid Rebar constraint data
and that its RebarConstraintsManager is still valid.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetPositiveOffsetDirectionForToOtherRebarConstraint`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetPositiveOffsetDirectionForToOtherRebarConstraint`

#### Summary

Returns the positive offset direction vector.

#### Remarks

This is available only for constraints of type `F:Autodesk.Revit.DB.Structure.RebarConstraintType.ToOtherRebar` .

Valid `T:Autodesk.Revit.DB.Structure.TargetRebarConstraintType` are:

`F:Autodesk.Revit.DB.Structure.TargetRebarConstraintType.RebarPlane`

`F:Autodesk.Revit.DB.Structure.TargetRebarConstraintType.Edge`

`F:Autodesk.Revit.DB.Structure.TargetRebarConstraintType.OutOfPlaneExtent`

`F:Autodesk.Revit.DB.Structure.TargetRebarConstraintType.StartOfBar` , only if the RebarShape has a definition of `T:Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition` with `!:RebarShapeMultiplanarDefinition::IsStartConnectorPressent`

`F:Autodesk.Revit.DB.Structure.TargetRebarConstraintType.EndOfBar` , only if the RebarShape has a definition of `T:Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition` with `!:RebarShapeMultiplanarDefinition::IsEndConnectorPressent`

#### Returns

The positive offset direction vector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToOtherRebar.'
-or-
The TargetRebarConstraintType is not valid.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.FlipHandleOverTarget`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.FlipHandleOverTarget`

#### Summary

Flips the RebarConstrainedHandle to the other side of the target bar handle, maintaining the distance in absolute value.

#### Remarks

Throw exception if constraint type is not 'ToOtherRebar', or for constraints involving bar/hook bend handle.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToOtherRebar.'
-or-
The RebarTargetConstraintType is 'HookBend' or 'BarBend'.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.SetToUseClearBarSpacing(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.SetToUseClearBarSpacing(System.Boolean)`

#### Summary

Sets whether the RebarConstrainedHandle to target offset is the clear bar distance, or is measured between bar centers.

#### Remarks

Throw exception if it's used on start/end handle to start/end handle constraint, and on constraints involving bar/hook bend handle.

#### Parameter `useClearBarSpacing`

True if the RebarConstrainedHandle to target offset is the clear bar distance, false if the offset is measured between bar centers.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToOtherRebar.'
-or-
The RebarConstraint constrain two Rebar ends.
-or-
The RebarTargetConstraintType is 'HookBend' or 'BarBend'.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.IsUsingClearBarSpacing`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.IsUsingClearBarSpacing`

#### Summary

Returns true if the RebarConstrainedHandle to target offset is the clear bar distance, false if the offset is measured between bar centers.

#### Remarks

Throw exception if it's used on start/end handle to start/end handle constraint, and on constraints involving bar/hook bend handle.

#### Returns

Returns true if the RebarConstrainedHandle to target offset is the clear bar distance, false if the offset is measured between bar centers.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToOtherRebar.'
-or-
The RebarConstraint constrain two Rebar ends.
-or-
The RebarTargetConstraintType is 'HookBend' or 'BarBend'.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.SetToBindHandleWithTarget(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.SetToBindHandleWithTarget(System.Boolean)`

#### Summary

Sets the relationship between two RebarConstrainedHandles.

#### Remarks

Throws exception for any type of constraint other than 'ToOtherRebar' or if the RebarTargetConstraintType of the constraint is 'HookBend' or 'BarBend'.
Will also throw if the target Rebar has the 'Number with Spacing' layout rule and the RebarTargetConstraintType of the constraint is 'OutOfPlaneExtent'.

#### Parameter `bindsHandleWithTarget`

False if only the constrained RebarConstrainedHandle follows the target. True if the constrained RebarConstrainedHandle and the target bar handle will be bound and move together.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToOtherRebar.'
-or-
The RebarTargetConstraintType is 'HookBend' or 'BarBend'.
-or-
The RebarTargetConstraintType is 'OutOfPlaneExtent' and the rebar target layout is 'Number with Spacing'.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.IsBindingHandleWithTarget`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.IsBindingHandleWithTarget`

#### Summary

Gets the relationship between two RebarConstrainedHandles.

#### Remarks

Throws exception for any type of constraint other than 'ToOtherRebar' or if the RebarTargetConstraintType of the constraint is 'HookBend' or 'BarBend'.
Will also throw if the target Rebar has the 'Number with Spacing' layout rule and the RebarTargetConstraintType of the constraint is 'OutOfPlaneExtent'.

#### Returns

Returns False if only the constrained RebarConstrainedHandle follows the target. Returns True if the constrained RebarConstrainedHandle and the target bar handle are bound and move together.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToOtherRebar.'
-or-
The RebarTargetConstraintType is 'HookBend' or 'BarBend'.
-or-
The RebarTargetConstraintType is 'OutOfPlaneExtent' and the rebar target layout is 'Number with Spacing'.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.SetDistanceToTargetRebar(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.SetDistanceToTargetRebar(System.Double)`

#### Summary

Sets the offset distance between the constrained RebarConstrainedHandle and its target Rebar handle surface.

#### Remarks

Throws exception if the constraint is not to other rebar or if the target constraint is to bar bend or hook bend.

#### Parameter `distanceToTargetRebar`

The distance is given as an offset value, the sign of which depends on the target bar handle direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for distanceToTargetRebar must be no more than 30000 feet in absolute value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToOtherRebar.'
-or-
The RebarTargetConstraintType is 'HookBend' or 'BarBend'.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetDistanceToTargetRebar`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetDistanceToTargetRebar`

#### Summary

Gets the distance from the RebarConstrainedHandle to the target Rebar handle surface.
The RebarConstraintType of the RebarConstraint must be 'ToOtherRebar.'

#### Remarks

Throws exception if the constraint is not to other rebar or if the target constraint is to bar bend or hook bend.

#### Returns

Returns the distance from the RebarConstrainedHandle to the target Rebar handle surface.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToOtherRebar.'
-or-
The RebarTargetConstraintType is 'HookBend' or 'BarBend'.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.IsReferenceValidForConstraint(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.IsReferenceValidForConstraint(Autodesk.Revit.DB.Reference)`

#### Summary

Checks if the reference provided can be used in creating Rebar constraints

#### Remarks

Reference is valid if it points to an uncut face of a structural that can host rebar.

#### Parameter `targetReference`

The reference to be checked

#### Returns

returns true if reference can be used in a constraint, false otherwise

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019.1

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.ReplaceReferenceTargets(Autodesk.Revit.DB.Structure.RebarConstrainedHandle,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference},System.Boolean,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.ReplaceReferenceTargets(Autodesk.Revit.DB.Structure.RebarConstrainedHandle,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference},System.Boolean,System.Double)`

#### Summary

Replaces the current set of references, the type of constraint and the offset value, with the newly provided ones.
Will throw exception if this is a constraint for Shape Driven Rebar.

#### Parameter `handle`

The RebarConstrainedHandle that has this constraint.

#### Parameter `targetReferences`

The references to which the rebar handle will be constrained.
This collection must contain one or more references to faces of elements that can host rebar.

#### Parameter `isConstraintToCover`

If true the RebarConstraintType will be set to ToCover, otherwise RebarConstraintType will be set to FixedDistanceToHostFace.

#### Parameter `offsetValue`

The distance from references to the rebar handle.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

handle is no longer valid.
-or-
targetReferences is empty.
-or-
targetReferences do not represent faces from structurals that can host rebar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Constrained rebar is a shape driven rebar element.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetCustomHandleTag`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetCustomHandleTag`

#### Summary

Returns the handle tag of the RebarConstrainedHandle.
This is valid only for Free Form Rebar.

#### Returns

Returns the handle tag of the RebarConstrainedHandle.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Constrained rebar is a shape driven rebar element.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.Create(Autodesk.Revit.DB.Structure.RebarConstrainedHandle,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference},System.Boolean,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.Create(Autodesk.Revit.DB.Structure.RebarConstrainedHandle,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference},System.Boolean,System.Double)`

#### Summary

This method creates a constraint for a given Rebar Constrained Handle Tag.
Will throw exception if used for Shape Driven Rebar.

#### Parameter `handle`

The handle of the rebar that will be constrained.

#### Parameter `targetReferences`

The references to which the rebar handle will be constrained.
This collection must contain one or more references to faces of elements that can host rebar.

#### Parameter `isConstraintToCover`

If true the RebarConstraintType will be set to ToCover, otherwise RebarConstraintType will be set to FixedDistanceToHostFace.

#### Parameter `offsetValue`

The distance from references to the rebar handle.

#### Returns

Returns the newly created RebarConstraint.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Constrained rebar is a shape driven rebar element.
-or-
handle is no longer valid.
-or-
targetReferences is empty.
-or-
targetReferences do not represent faces from structurals that can host rebar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.IsEqual(Autodesk.Revit.DB.Structure.RebarConstraint)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.IsEqual(Autodesk.Revit.DB.Structure.RebarConstraint)`

#### Summary

Returns true if the specified RebarConstraint is the same as 'this.' The method
can be used to determine which of the RebarConstraint candidates offered by the
RebarConstraintsManager is currently active.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

other is no longer valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetRebarAngleOnBarOrHookBend`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetRebarAngleOnBarOrHookBend`

#### Summary

Returns the angular increment along a bar or hook bend to which the RebarConstraint is attached.

#### Remarks

Only applies to RebarConstraints with TargetRebarConstraintType BarBend or HookBend.
For HookBends, values can be 0, 1, 2, 3 or 4, representing angular locations of 0, 45, 90, 135,
and 180 degrees around the hook, starting at the 'base' of the hook (or end of the bar without hook).
For interior BarBends, values can 0 or 1, where 0 means at the intersection of the bar bend and the edge
specified by getTargetRebarEdgeNumber, and 1 means the mid-point of the bend arc.
Rebar must be Shape Driven Rebar element.

#### Returns

The angular increment relative to the reference bar edge.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToOtherRebar.'
-or-
The RebarTargetConstraintType is not 'HookBend' or 'BarBend'.
-or-
Constrained rebar is a free form rebar element.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetRebarHookBarEnd`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetRebarHookBarEnd`

#### Summary

Returns 0 or 1 to indicate which end hook on the other Rebar Element to which this RebarConstraint is attached.
The RebarConstraint must be of RebarConstraintType 'ToOtherRebar,' and the TargetRebarConstraintType
must be 'HookBend.'
Rebar must be Shape Driven Rebar element.

#### Remarks

0 means start of the bar, and 1 indicates end of the bar.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToOtherRebar.'
-or-
The RebarTargetConstraintType is not 'HookBend'
-or-
Constrained rebar is a free form rebar element.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetRebarBendNumber`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetRebarBendNumber`

#### Summary

Returns the number of the bend on the other Rebar Element to which this RebarConstraint is attached.
The RebarConstraint must be of RebarConstraintType 'ToOtherRebar,' and the TargetRebarConstraintType
must be 'BarBend.'
Rebar must be Shape Driven Rebar element.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToOtherRebar.'
-or-
The RebarTargetConstraintType is not 'BarBend'
-or-
Constrained rebar is a free form rebar element.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetRebarEdgeNumber`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetRebarEdgeNumber`

#### Summary

Returns the number of the edge on the other Rebar Element to which this RebarConstraint is attached.
The RebarConstraint must be of RebarConstraintType 'ToOtherRebar,' and the TargetRebarConstraintType
must be 'Edge.'
Rebar must be Shape Driven Rebar element.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToOtherRebar.'
-or-
The RebarConstraint is not attached to an edge, or bend, or hook bend of another Rebar Element.
-or-
Constrained rebar is a free form rebar element.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetRebarConstraintType`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetRebarConstraintType`

#### Summary

Returns the TargetRebarConstraintType of the handle on the other Rebar Element
to which this RebarConstraint is attached. The RebarConstraintType of the
RebarConstraint must be 'ToOtherRebar.'
Rebar must be Shape Driven Rebar element.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToOtherRebar.'
-or-
Constrained rebar is a free form rebar element.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.SetDistanceToTargetCover(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.SetDistanceToTargetCover(System.Double)`

#### Summary

Sets the distance from the RebarConstrainedHandle to the target Host Cover Element surface.
The RebarConstraintType of the RebarConstraint must be 'ToCover.'

#### Parameter `distanceToTargetCover`

The distance is given as an offset value, the sign of which depends on Host Cover direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for distanceToTargetCover must be no more than 30000 feet in absolute value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToCover.'

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetDistanceToTargetCover`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetDistanceToTargetCover`

#### Summary

Returns the distance from the RebarConstrainedHandle to the target Host Cover Element surface.
The RebarConstraintType of the RebarConstraint must be 'ToCover.'

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'ToCover.'

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.SetDistanceToTargetHostFace(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.SetDistanceToTargetHostFace(System.Double)`

#### Summary

Sets the distance from the RebarConstrainedHandle to the target Host Element surface.
The RebarConstraintType of the RebarConstraint must be 'FixedDistanceToHostFace.'

#### Parameter `offset`

The distance is given as an offset value, the sign of which depends on Host Face direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for offset must be no more than 30000 feet in absolute value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'FixedDistanceToHostFace.'

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetDistanceToTargetHostFace`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetDistanceToTargetHostFace`

#### Summary

Returns the distance from the RebarConstrainedHandle to the target Host Element surface.
The RebarConstraintType of the RebarConstraint must be 'FixedDistanceToHostFace.'

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'FixedDistanceToHostFace.'

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetHostFaceReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetHostFaceReference`

#### Summary

Returns a reference to the host Element face to which the RebarConstraint is attached.
The RebarConstraintType of the RebarConstraint must be 'FixedDistanceToHostFace' or 'ToCover.'
Will throw exception if it's a multi target constraint.

#### Returns

Requested reference.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'FixedDistanceToHostFace' or 'ToCover.'
-or-
Multi target constraint. Consider using the indexed version of the method.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetHostFaceReference(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetHostFaceReference(System.Int32)`

#### Summary

Returns a reference that corresponds to the face to which the RebarConstraint is attached specified by the targetIndex.
The RebarConstraintType of the RebarConstraint must be 'FixedDistanceToHostFace' or 'ToCover.'

#### Parameter `targetIndex`

The index of the target. Should be between 0 and NumberOfTargets().

#### Returns

Requested reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

targetIndex is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'FixedDistanceToHostFace' or 'ToCover.'

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetCoverType(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetCoverType(System.Int32)`

#### Summary

Returns the RebarCoverType for the face specified by targetIndex. Returns null if no RebarHostData is present for target element.

#### Parameter `targetIndex`

The index of the target. Should be between 0 and NumberOfTargets().

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

targetIndex is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'FixedDistanceToHostFace' or 'ToCover.'

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetHostFaceAndTransform(System.Int32,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetHostFaceAndTransform(System.Int32,Autodesk.Revit.DB.Transform)`

#### Summary

Returns the face to which the RebarConstraint is attached associated to the given target index.
The RebarConstraintType of the RebarConstraint must be 'FixedDistanceToHostFace' or 'ToCover.'

#### Parameter `targetIndex`

The index of the target. Should be between 0 and NumberOfTargets().

#### Parameter `faceTransform`

Returns the transform that is associated to the face's element geometry.

#### Returns

Requested Face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

targetIndex is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'FixedDistanceToHostFace' or 'ToCover.'

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetRebarConstraintTargetHostFaceType`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetRebarConstraintTargetHostFaceType`

#### Summary

Returns the RebarConstraintTargetHostFaceType of the host Element face to which
the RebarConstraint is attached. The RebarConstraintType of the RebarConstraint
must be 'FixedDistanceToHostFace' or 'ToCover.'
Will throw exception if it's a multi target constraint.

#### Returns

Returns the RebarConstraintTargetHostFaceType of the host Element face to which the RebarConstraint is attached.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'FixedDistanceToHostFace' or 'ToCover.'
-or-
Multi target constraint. Consider using the indexed version of the method.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetRebarConstraintTargetHostFaceType(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetRebarConstraintTargetHostFaceType(System.Int32)`

#### Summary

Returns the RebarConstraintTargetHostFaceType of the host Element face to which
the RebarConstraint is attached. The RebarConstraintType of the RebarConstraint
must be 'FixedDistanceToHostFace' or 'ToCover.'

#### Parameter `targetIndex`

The index of the target. Should be between 0 and NumberOfTargets().

#### Returns

Returns the RebarConstraintTargetHostFaceType of the host Element face to which the RebarConstraint is attached.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

targetIndex is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
The RebarConstraint is not of RebarConstraintType 'FixedDistanceToHostFace' or 'ToCover.'

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.AreGeometryTargetsTheSame(Autodesk.Revit.DB.Structure.RebarConstraint)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.AreGeometryTargetsTheSame(Autodesk.Revit.DB.Structure.RebarConstraint)`

#### Summary

Returns true if the gemetrical targets (ex. face references, other rebar segment references) of "this" constriant are the same as the targets of the "other" constraint.
Returns false otherwise.
Only the reference to the target piece of geometry is taken into account(ex. only face references, only other rebar segment references).
Target Element (elementId) is not taken into account.
Distance to target is not taken into account.

#### Parameter `otherConstraint`

Returns the Element object (either Host or Rebar) which provides the constraint.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetElement`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetElement`

#### Summary

Gets the Element object (either Host or Rebar) which provides the constraint.
Will throw exception if it's a multi target constraint.

#### Returns

Returns the Element object (either Host or Rebar) which provides the constraint.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.
-or-
Multi target constraint. Consider using the indexed version of the method.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetElement(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetTargetElement(System.Int32)`

#### Summary

Gets the Element object (either Host or Rebar) which provides the constraint. Will return the Element which contains the face at targetIndex.

#### Parameter `targetIndex`

The index of the target. Should be between 0 and NumberOfTargets().

#### Returns

Returns the Element object (either Host or Rebar) which provides the constraint. Will return the Element which contains the face at targetIndex.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

targetIndex is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarConstraint.GetConstraintType`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.GetConstraintType`

#### Summary

Returns the RebarConstraintType of a RebarConstraint.

#### Returns

The RebarConstraintType of the specified RebarConstraint.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstraint is no longer valid.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarConstraint.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarConstraint.NumberOfTargets`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint.NumberOfTargets`

#### Summary

Identifies the number of references associated to the rebar handle.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.RebarConstraint`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraint`

#### Summary

A class representing a constraint on a handle of a rebar element.

#### Remarks

For Shape Driven Rebar Constraints:

Each handle on a rebar is defined by a plane, and can be constrained along the
direction perpendicular to the plane. Rebar constraints work by locking the
handle planes to planar references, or 'targets.' These targets can be:
planar surfaces of host elements, or

the handle planes of stirrup bars (only applies to standard style bars).

For planar host element surfaces, a rebar handle can either be locked at a constant
distance, or, if the host surface has a specified cover, then the handle can be
joined directly to the cover of the surface.

Standard style bars can be locked to the handle planes of stirrup style rebar.
In the special case of a straight, standard style bar, running perpendicular
to the plane of the stirrup bar, the bar can constrain itself to distinct locations
along bends in stirrup bars - points located at 0 degrees, 45 degrees, 90 degrees,
etc. around each bend. This is done by simultaneously locking both the straight
bar's edge handle and its planar position handle to one or both of the stirrup edges
adjacent to the bend in the stirrup.

Usually, to form a constraint, the handle plane and the reference plane must be parallel.
However, bar end handles can be constrained to planes at angles up to 60 degrees.
Arc-shaped rebar is a special case, and can form constraints to concentric host surfaces.

RebarConstraints can only be constructed internally by Revit. They are
available to the API by querying a rebar element's RebarConstraintsManager.

For Free Form Rebar Constraints:

Each handle of the Rebar can be constrained to multiple host faces or to the face cover.

In order to create a Free Form Rebar Constraint you will need:
RebarConstraintsManager which will manage the constraint.

The rebar handle you want to constraint.

A list of target references which must be element faces to which this handle is constrained.

A Boolean value specifying that the constraint is to cover or directly to face. It will be the same value for all target references

A double value that represent the offset distance from the rebar handle to target references.

RebarConstraints for Free Form Rebar should be created using the Create method and then added to
the RebarConstraintsManager using the method SetPreferredConstraintForHandle.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType`

#### Summary

A type to help identify the individual face on a host element to which a Rebar handle
is constrained.

#### Remarks

For some types of host, it is possible to describe the face in terms of recognizable
topology (i.e. Top, Bottom, etc.). However, for most elements, the face can only be
identified by integer tag. In all cases, a Pick to the host face can be obtained
by calling RebarConstraint.GetTargetHostFaceReference().

#### Since

2014

#### Since

2014

### `F:Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.Side1`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.Side1`

#### Summary

Face forms the interior surface of the host geometry.

### `F:Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.Side0`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.Side0`

#### Summary

Face forms the exterior surface of the host geometry.

### `F:Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.End1`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.End1`

#### Summary

Face forms the end surface of the host geometry.

### `F:Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.End0`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.End0`

#### Summary

Face forms the starting end surface of the host geometry.

### `F:Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.Bottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.Bottom`

#### Summary

Face forms the bottom surface of the host geometry.

### `F:Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.Top`

#### Summary

Face forms the top surface of the host geometry.

### `F:Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.FaceWithTagId`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType.FaceWithTagId`

#### Summary

Face identified by integer tag.

### `T:Autodesk.Revit.DB.Structure.TargetRebarConstraintType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.TargetRebarConstraintType`

#### Summary

A type used to identify the particular part of a Stirrup style rebar to which
a Standard style rebar's handle is constrained.

#### Remarks

Most of the range of values for this type are the same as those of RebarHandleType,
since it is usually the handles on the Stirrup which constrain the Standard bar.
However, two additional values - BarBend and HookBend - are used to identify the
special case of a Standard style, straight bar, running perpendicular to the plane
of the Stirrup, and constrained to a bend (or hook) arc on the Stirrup.

#### Since

2014

#### Since

2014

### `F:Autodesk.Revit.DB.Structure.TargetRebarConstraintType.HookBend`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.TargetRebarConstraintType.HookBend`

#### Summary

Handle is constrained to fillet of the hook of the other Rebar.

### `F:Autodesk.Revit.DB.Structure.TargetRebarConstraintType.BarBend`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.TargetRebarConstraintType.BarBend`

#### Summary

Handle is constrained to fillet of the edge of the other Rebar.

### `F:Autodesk.Revit.DB.Structure.TargetRebarConstraintType.OutOfPlaneExtent`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.TargetRebarConstraintType.OutOfPlaneExtent`

#### Summary

Handle is constrained to the extent of a three-dimensional Rebar out of
its primary plane. This includes the length of a Rebar Set, the
out-of-plane length of a multi-planar Rebar, and the length of a
spiral Rebar.

### `F:Autodesk.Revit.DB.Structure.TargetRebarConstraintType.Edge`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.TargetRebarConstraintType.Edge`

#### Summary

Handle is constrained to location of a single edge segment of the other Rebar.
Drives the edge in the direction perpendicular to the edge and
in the Rebar's primary plane.

### `F:Autodesk.Revit.DB.Structure.TargetRebarConstraintType.EndOfBar`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.TargetRebarConstraintType.EndOfBar`

#### Summary

Handle is constrained to end point of the other Rebar.

### `F:Autodesk.Revit.DB.Structure.TargetRebarConstraintType.StartOfBar`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.TargetRebarConstraintType.StartOfBar`

#### Summary

Handle is constrained to start point of the other Rebar.

### `F:Autodesk.Revit.DB.Structure.TargetRebarConstraintType.RebarPlane`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.TargetRebarConstraintType.RebarPlane`

#### Summary

Handle is constrained to the location of the other Rebar's primary plane.
Drives location of the entire Rebar along the direction of its normal.

### `T:Autodesk.Revit.DB.Structure.RebarConstraintType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintType`

#### Summary

The various types of constraints that can be applied to a RebarConstrainedHandle.

#### Since

2014

#### Since

2014

### `F:Autodesk.Revit.DB.Structure.RebarConstraintType.ToOtherRebar`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintType.ToOtherRebar`

#### Summary

Handle is attached to a handle on another Rebar Element. Only applies to
Standard style bars, which can be constrained to Stirrup style bars.

### `F:Autodesk.Revit.DB.Structure.RebarConstraintType.ToCover`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintType.ToCover`

#### Summary

Handle is attached to the cover of a host Element surface.

### `F:Autodesk.Revit.DB.Structure.RebarConstraintType.FixedDistanceToHostFace`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintType.FixedDistanceToHostFace`

#### Summary

Handle is constrained to remain a fixed distance from a host Element surface.

### `M:Autodesk.Revit.DB.Structure.RebarConstrainedHandle.IsCustomHandle`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstrainedHandle.IsCustomHandle`

#### Summary

Returns true if the RebarHandleType of the RebarConstrainedHandle is 'CustomHandle'.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarConstrainedHandle.IsEdgeHandle`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstrainedHandle.IsEdgeHandle`

#### Summary

Returns true if the RebarHandleType of the RebarConstrainedHandle is 'Edge'.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstrainedHandle.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstrainedHandle.IsValid`

#### Summary

Checks that the RebarConstrainedHandle still has access to valid Rebar handle data
and that its RebarConstraintsManager is still valid.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstrainedHandle.GetHandleName`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstrainedHandle.GetHandleName`

#### Summary

Gets the name of the handle.

#### Returns

Returns the name of the handle. In case of handles of CustomHandle type it can return null if the .dll that contains the server is not loaded.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstrainedHandle is no longer valid.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarConstrainedHandle.GetCustomHandleTag`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstrainedHandle.GetCustomHandleTag`

#### Summary

Returns the tag of the handle. The type of the handle should be 'CustomHandle'.

#### Returns

Returns the tag of custom handle.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstrainedHandle is no longer valid.
-or-
The RebarConstrainedHandle is not of RebarHandleType 'CustomHandle'.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarConstrainedHandle.GetEdgeNumber`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstrainedHandle.GetEdgeNumber`

#### Summary

If the RebarConstrainedHandle's RebarHandleType is 'Edge',
then this function will return the number of the edge that is
driven by the handle.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstrainedHandle is no longer valid.
-or-
The RebarConstrainedHandle is not of RebarHandleType 'Edge'.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstrainedHandle.GetHandleType`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstrainedHandle.GetHandleType`

#### Summary

Returns the RebarHandleType of a RebarConstrainedHandle.

#### Returns

The RebarHandleType of the specified RebarConstrainedHandle.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

RebarConstrainedHandle is no longer valid.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarConstrainedHandle.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarConstrainedHandle.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarConstrainedHandle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarConstrainedHandle`

#### Summary

A class representing a handle on a Rebar that can be joined to a reference, such
as a host Element's surface or cover, or another Rebar's handle.

#### Remarks

A rebar element's flexible geometry is controlled by several handles. The shape
of the bar is controlled by a handle at each end of the bar (blue circle controls)
and a handle each edge (blue triangle controls). Another handle is used to
control the location of the plane in which the rebar lies. An additional handle
controls the length of a set of rebar.

RebarConstrainedHandles can only be constructed internally by Revit. They are
available to the API by querying a rebar element's RebarConstraintsManager.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarHandleType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarHandleType`

#### Summary

The various types of handles on a Rebar instance that can be joined to References

#### Since

2014

#### Since

2014

### `F:Autodesk.Revit.DB.Structure.RebarHandleType.CustomHandle`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHandleType.CustomHandle`

#### Summary

Custom handle used in API constraints. The handle itself and the behavior of this type of handle
is defined in the API (see `T:Autodesk.Revit.DB.Structure.IRebarUpdateServer` ).
This handle defines a symbolic part of the rebar
and is not tied to a specific segment or part of the rebar.
Handles that represent the start and end of a bar should not be of this type.

### `F:Autodesk.Revit.DB.Structure.RebarHandleType.OutOfPlaneExtent`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHandleType.OutOfPlaneExtent`

#### Summary

Handle controlling the extent of a three-dimensional Rebar out of
its primary plane. This includes the length of a Rebar Set, the
out-of-plane length of a multi-planar Rebar, and the length of a
spiral Rebar.

### `F:Autodesk.Revit.DB.Structure.RebarHandleType.Edge`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHandleType.Edge`

#### Summary

Handle controlling location of a single edge segment of the Rebar.
Drives the edge in the direction perpendicular to the edge and
in the Rebar's primary plane.

### `F:Autodesk.Revit.DB.Structure.RebarHandleType.EndOfBar`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHandleType.EndOfBar`

#### Summary

Handle controlling end point of the Rebar.

### `F:Autodesk.Revit.DB.Structure.RebarHandleType.StartOfBar`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHandleType.StartOfBar`

#### Summary

Handle controlling start point of the Rebar.

### `F:Autodesk.Revit.DB.Structure.RebarHandleType.RebarPlane`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHandleType.RebarPlane`

#### Summary

Handle controlling the location of the Rebar's primary plane.
Drives location of the entire Rebar along the direction of its normal.

### `F:Autodesk.Revit.DB.Structure.RebarHandleType.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHandleType.Undefined`

#### Summary

represents an undefined handle. if this value is returned, then the handle cannot find it's type

### `M:Autodesk.Revit.DB.Structure.RebarBendingDetailType.Create(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.Create(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new RebarBendingDetailType object.

#### Parameter `Document`

Document to which the new element should be added.

#### Returns

The new RebarBendingDetailType object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.BendDiameterDimensionsForHooksEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.BendDiameterDimensionsForHooksEnabled`

#### Summary

Identifies if radial or diameter dimensions will be shown for hook fillets.
This property has a meaning only if `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.BendDiameterDimensionsEnabled` is set to true.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.BendDiameterDimensionsForSegmentsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.BendDiameterDimensionsForSegmentsEnabled`

#### Summary

Identifies if radial or diameter dimensions will be shown for the bends between segments.
Radial or diameter dimesions for arc segments will be shown by default.
This property has a menaning only if `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.BendDiameterDimensionsEnabled` is set to true.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.BendDiameterDimensionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.BendDiameterDimensionType`

#### Summary

Identifies what type of bend diameter dimensions will be shown (radial or diameter).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.DiameterDimensionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.DiameterDimensionTypeId`

#### Summary

Identifies the Id of the diameter dimension type which is used to show dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property:

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.RadialDimensionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.RadialDimensionTypeId`

#### Summary

Identifies the Id of the radial dimension type which is used to show dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property:

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.BendDiameterDimensionsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.BendDiameterDimensionsEnabled`

#### Summary

Identifies if any radial or diameter dimensions will be shown or not.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionsMeasurementOptions`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionsMeasurementOptions`

#### Summary

Identifies the measurement option for angular dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionTextPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionTextPosition`

#### Summary

Identifies the text position with respect to dimension line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionsForHooksEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionsForHooksEnabled`

#### Summary

Identifies if the angular dimensions which has a reference set on a hook will be shown or not.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionsOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionsOffset`

#### Summary

Identifies the offset of the angular dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for angularDimensionsOffset must be between 0 and 30000 feet.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionsDisplayOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionsDisplayOption`

#### Summary

Identifies the angular dimensions display options.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionTypeId`

#### Summary

Identifies the Id of the angular dimension type which is used to show dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property:

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.AngularDimensionsEnabled`

#### Summary

Identifies if any angular dimensions will be shown or not.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.OrthogonalAndOverallDimesionsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.OrthogonalAndOverallDimesionsEnabled`

#### Summary

Identifies if orthogonal and overall dimensions are displayed.

#### Remarks

Orthogonal segment length dimensions are dimensions defining the slope of a bar segment.
Overall dimensions are dimensions that spans over multiple segments.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthDimensionsForHooksEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthDimensionsForHooksEnabled`

#### Summary

Identifies if segment length dimensions for hooks will be shown or not.
If this property is true, the `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthDimensionsEnabled` should also be true to see segment length dimensions for hooks.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthDimensionsOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthDimensionsOffset`

#### Summary

Identifies the offset of the segment length dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for segmentLengthDimensionsOffset must be between 0 and 30000 feet.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthDimensionTextPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthDimensionTextPosition`

#### Summary

Identifies the text position with respect to dimension line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthsForArcsDisplayOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthsForArcsDisplayOption`

#### Summary

Identifies if the arc segment lengths are represented using dimensions or just as text.
Only RebarShapes whose definition is RebarShapeDefinitionByArc are considered that have arc segments.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthsDisplayOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthsDisplayOption`

#### Summary

Identifies if the segment lengths are represented using dimensions or just as text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthDimensionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthDimensionTypeId`

#### Summary

Identifies the Id of the linear dimension type which is used to show segments length.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property:

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthDimensionsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentLengthDimensionsEnabled`

#### Summary

Identifies if any segment length dimensions will be shown or not.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.DetailLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.DetailLevel`

#### Summary

Identifies the level of detail in which the Bending Detail will be represented.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.MultipleValuesIndicatorOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.MultipleValuesIndicatorOption`

#### Summary

Identifies the option of how multiple values will be represented.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.RepresentaionOf3DShapes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.RepresentaionOf3DShapes`

#### Summary

Identifies how the Bending Detail will represent the 3D shapes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentsRepresentation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType.SegmentsRepresentation`

#### Summary

Identifies how the bending detail will represent the segments of the bar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `T:Autodesk.Revit.DB.Structure.RebarBendingDetailType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetailType`

#### Summary

Type for rebar bending detail elements.

#### Since

2024

### `T:Autodesk.Revit.DB.Structure.BendingDetailLevelOfDetail`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailLevelOfDetail`

#### Summary

Describes the level of detail in which the Bending Detail will be represented.

#### Since

2024

#### Since

2024

### `F:Autodesk.Revit.DB.Structure.BendingDetailLevelOfDetail.Fine`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailLevelOfDetail.Fine`

#### Summary

Ribbon representation of Bending Detail.

### `F:Autodesk.Revit.DB.Structure.BendingDetailLevelOfDetail.Coarse`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailLevelOfDetail.Coarse`

#### Summary

Centerline representation of the Bending Detail.

### `F:Autodesk.Revit.DB.Structure.BendingDetailLevelOfDetail.ByView`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailLevelOfDetail.ByView`

#### Summary

The level detail is taken from the view.

### `T:Autodesk.Revit.DB.Structure.BendingDetailTypeMultipleValuesIndicatorOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailTypeMultipleValuesIndicatorOptions`

#### Summary

Describes how the parameters with multiple values will be represented.

#### Since

2024

#### Since

2024

### `F:Autodesk.Revit.DB.Structure.BendingDetailTypeMultipleValuesIndicatorOptions.MinimumMaximum`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailTypeMultipleValuesIndicatorOptions.MinimumMaximum`

#### Summary

The values will be obtained from all included bars in the rebar set and it will be shown in a form like minimumValue...maximumValue.

### `F:Autodesk.Revit.DB.Structure.BendingDetailTypeMultipleValuesIndicatorOptions.FromOneBar`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailTypeMultipleValuesIndicatorOptions.FromOneBar`

#### Summary

Obtain parameter value from only one bar.

### `M:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AreEqualTo(Autodesk.Revit.DB.ICustomFieldProperties)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AreEqualTo(Autodesk.Revit.DB.ICustomFieldProperties)`

#### Summary

Identifies if the custom field properties are equal or not.

#### Parameter `otherProperties`

The other properties.

#### Returns

Returns true if the custom field properties are equal, false otherwise.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.ValidateProperties(Autodesk.Revit.DB.ViewSchedule)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.ValidateProperties(Autodesk.Revit.DB.ViewSchedule)`

#### Summary

A validation is done, and if there are any errors a string indicating the error will be returned.
If the properties are valid, a

#### Parameter `schedule`

The schedule that contains this field whose properties are tested.

#### Returns

Returns a string which describes which data are incorrect.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.BendDiameterDimensionsForSegmentsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.BendDiameterDimensionsForSegmentsEnabled`

#### Summary

Identifies if radial or diameter dimensions will be shown for the bends between segments.
Radial or diameter dimesions for arc segments will be shown by default.
This property has a menaning only if `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.BendDiameterDimensionsEnabled` is set to true.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.BendDiameterDimensionsForHooksEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.BendDiameterDimensionsForHooksEnabled`

#### Summary

Identifies if radial or diameter dimensions will be shown for hook fillets
This property has a meaning only if `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.BendDiameterDimensionsEnabled` is set to true.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.BendDiameterDimensionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.BendDiameterDimensionType`

#### Summary

Identifies what type of bend diameter dimensions will be shown (radial or diameter).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.BendDiameterDimensionsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.BendDiameterDimensionsEnabled`

#### Summary

Identifies if any radial or diameter dimensions will be shown or not.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.DiameterDimensionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.DiameterDimensionTypeId`

#### Summary

Identifies the Id of the diameter dimension type which is used to show dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The diameterDimensionTypeId should be an id of a diameter dimension type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.RadialDimensionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.RadialDimensionTypeId`

#### Summary

Identifies the Id of the radial dimension type which is used to show dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The radialDimensionTypeId should be an id of a radial dimension type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionsMeasurementOptions`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionsMeasurementOptions`

#### Summary

Identifies the measurement option for angular dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionsOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionsOffset`

#### Summary

Identifies the offset of the angular dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for angularDimensionsOffset must be between 0 and 30000 feet.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionsForHooksEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionsForHooksEnabled`

#### Summary

Identifies if the angular dimensions which has a reference set on a hook will be shown or not.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionsDisplayOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionsDisplayOption`

#### Summary

Identifies the angular dimensions display options.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionTextPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionTextPosition`

#### Summary

Identifies the text position with respect to dimension line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionsEnabled`

#### Summary

Identifies if any angular dimensions will be shown or not.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.AngularDimensionTypeId`

#### Summary

Identifies the Id of the angular dimension type which is used to show dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The angularDimensionTypeId should be an id of an angular dimension type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.OrthogonalAndOverallDimesionsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.OrthogonalAndOverallDimesionsEnabled`

#### Summary

Identifies if orthogonal and overall dimensions are displayed.

#### Remarks

Orthogonal segment length dimensions are dimensions defining the slope of a bar segment.
Overall dimensions are dimensions that spans over multiple segments.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthsForArcsDisplayOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthsForArcsDisplayOption`

#### Summary

Identifies if the arc segment lengths are represented using dimensions or just as text.
Only RebarShapes whose definition is RebarShapeDefinitionByArc are considered that have arc segments.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthsDisplayOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthsDisplayOption`

#### Summary

Identifies if the segment lengths are represented using dimensions or just as text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthDimensionTextPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthDimensionTextPosition`

#### Summary

Identifies the text position with respect to dimension line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthDimensionsOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthDimensionsOffset`

#### Summary

Identifies the offset of the segment length dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for segmentLengthDimensionsOffset must be between 0 and 30000 feet.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthDimensionsForHooksEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthDimensionsForHooksEnabled`

#### Summary

Identifies if segment length dimensions for hooks will be shown or not.
If this property is true, the `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthDimensionsEnabled` should also be true to see segment length dimensions for hooks.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthDimensionsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthDimensionsEnabled`

#### Summary

Identifies if any segment length dimensions will be shown or not.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthDimensionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentLengthDimensionTypeId`

#### Summary

Identifies the Id of the linear dimension type which is used to show segments length.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The segmentLengthDimensionTypeId should be an id of a linear dimension type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.MultipleValuesIndicatorOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.MultipleValuesIndicatorOption`

#### Summary

Identifies how the Bending Detail will represent the varying rebar dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.RepresentaionOf3DShapes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.RepresentaionOf3DShapes`

#### Summary

Identifies how the Bending Detail will represent the 3D shapes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentsRepresentation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.SegmentsRepresentation`

#### Summary

Identifies how the bending detail will represent the segments of the bar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.ParametersDisplayOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.ParametersDisplayOption`

#### Summary

Identifies how the parameters will be represented.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.LineStyleId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.LineStyleId`

#### Summary

Identifies the line style that is used for drawing Bending Detail curves.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The lineStyleId should be an id of a line style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.#ctor(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties.#ctor(Autodesk.Revit.DB.Document)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `T:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties`

#### Summary

Represents the properties of a Bending Detail Custom Field.

#### Since

2024

### `T:Autodesk.Revit.DB.Structure.BendingDetailDimensionTextPosition`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailDimensionTextPosition`

#### Summary

Describes how the text will be positioned with respect to dimension line.

#### Since

2024

#### Since

2024

### `F:Autodesk.Revit.DB.Structure.BendingDetailDimensionTextPosition.OutsideOfDimensionLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailDimensionTextPosition.OutsideOfDimensionLine`

#### Summary

The text will be positioned on the outside of the dimension line, where inside is represented by the bar curves.

### `F:Autodesk.Revit.DB.Structure.BendingDetailDimensionTextPosition.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailDimensionTextPosition.Default`

#### Summary

The text will be positioned according to the default behavior.

### `T:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldMultipleValuesIndicatorOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldMultipleValuesIndicatorOptions`

#### Summary

Describes how the parameters with multiple values will be represented.

#### Since

2024

#### Since

2024

### `F:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldMultipleValuesIndicatorOptions.MinimumMaximum`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldMultipleValuesIndicatorOptions.MinimumMaximum`

#### Summary

The values will be obtained from all included bars in the rebar set and it will be shown in a form like minimumValue...maximumValue.

### `F:Autodesk.Revit.DB.Structure.BendingDetailCustomFieldMultipleValuesIndicatorOptions.Varying`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailCustomFieldMultipleValuesIndicatorOptions.Varying`

#### Summary

The values will be obtained from all included bars in the rebar set and it will be shown the multiple varies indicator if they are different.

### `T:Autodesk.Revit.DB.Structure.BendingDetailFor3DShapesOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailFor3DShapesOptions`

#### Summary

Describes how the Bending Detail will be represented for 3D shapes.

#### Since

2024

#### Since

2024

### `F:Autodesk.Revit.DB.Structure.BendingDetailFor3DShapesOptions.PlanView`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailFor3DShapesOptions.PlanView`

#### Summary

The bending detail will represent the bar as in a plan view where the view plane is parallel with bar plane.

### `F:Autodesk.Revit.DB.Structure.BendingDetailFor3DShapesOptions.IsometricView`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailFor3DShapesOptions.IsometricView`

#### Summary

The bending detail will represent the bar as in an isometric view.

### `T:Autodesk.Revit.DB.Structure.BendingDetailSegmentsRepresentation`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailSegmentsRepresentation`

#### Summary

Describes how the Bending Detail will represent the bar segments.

#### Since

2024

#### Since

2024

### `F:Autodesk.Revit.DB.Structure.BendingDetailSegmentsRepresentation.Offset`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailSegmentsRepresentation.Offset`

#### Summary

Some of the bar segments will be lengthened so there is no intersection between them.

### `F:Autodesk.Revit.DB.Structure.BendingDetailSegmentsRepresentation.Unfold`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailSegmentsRepresentation.Unfold`

#### Summary

Some of the bar segments will be unfolded so there is no intersection between them.

### `F:Autodesk.Revit.DB.Structure.BendingDetailSegmentsRepresentation.Standard`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailSegmentsRepresentation.Standard`

#### Summary

The Bending Detail will represent the bar segments as they are.

### `T:Autodesk.Revit.DB.Structure.BendingDetailDisplayParametersOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailDisplayParametersOptions`

#### Summary

Describes how the parameters will be represented.

#### Since

2024

#### Since

2024

### `F:Autodesk.Revit.DB.Structure.BendingDetailDisplayParametersOptions.ByName`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailDisplayParametersOptions.ByName`

#### Summary

Dimensions that are shown will be labeled using the parameters names.

### `F:Autodesk.Revit.DB.Structure.BendingDetailDisplayParametersOptions.ByValue`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailDisplayParametersOptions.ByValue`

#### Summary

Dimensions that are shown will be labeled using the parameters values.

### `T:Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsMeasurementOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsMeasurementOptions`

#### Since

2024

#### Summary

Describes the angular dimension measurement options.

#### Since

2024

### `F:Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsMeasurementOptions.Outside`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsMeasurementOptions.Outside`

#### Summary

Measure the angle outside of the segments.

### `F:Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsMeasurementOptions.Inside`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsMeasurementOptions.Inside`

#### Summary

Measure the angle inside the segments.

### `T:Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsDisplayOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsDisplayOptions`

#### Since

2024

#### Summary

Describes the angular dimensions display options.

#### Since

2024

### `F:Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsDisplayOptions.Exclude90Degrees`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsDisplayOptions.Exclude90Degrees`

#### Summary

Display for all angle values except the 90 degree.

### `F:Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsDisplayOptions.AllAngles`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsDisplayOptions.AllAngles`

#### Summary

Display for all angle values.

### `T:Autodesk.Revit.DB.Structure.BendingDetailSegmentLengthsDisplayOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailSegmentLengthsDisplayOptions`

#### Since

2024

#### Summary

Describes if the segment lengths are represented using dimensions or just as text.

#### Since

2024

### `F:Autodesk.Revit.DB.Structure.BendingDetailSegmentLengthsDisplayOptions.Dimension`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailSegmentLengthsDisplayOptions.Dimension`

#### Summary

Display as dimensions

### `F:Autodesk.Revit.DB.Structure.BendingDetailSegmentLengthsDisplayOptions.Text`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailSegmentLengthsDisplayOptions.Text`

#### Summary

Display as texts

### `T:Autodesk.Revit.DB.Structure.BendingDetailBendDiameterDimensionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailBendDiameterDimensionType`

#### Summary

Describes the dimension type for bend diameter.

#### Since

2024

#### Since

2024

### `F:Autodesk.Revit.DB.Structure.BendingDetailBendDiameterDimensionType.Diameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailBendDiameterDimensionType.Diameter`

#### Summary

Diameter Dimension Type

### `F:Autodesk.Revit.DB.Structure.BendingDetailBendDiameterDimensionType.Radial`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailBendDiameterDimensionType.Radial`

#### Summary

Radial Dimension Type

### `M:Autodesk.Revit.DB.ICustomFieldPropertiesProxy.AreEqualTo(Autodesk.Revit.DB.ICustomFieldProperties)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldPropertiesProxy.AreEqualTo(Autodesk.Revit.DB.ICustomFieldProperties)`

#### Summary

Identifies if the custom field properties are equal or not.

#### Parameter `otherProperties`

The other properties.

#### Returns

Returns true if the custom field properties are equal, false otherwise.

#### Since

2024

### `M:Autodesk.Revit.DB.ICustomFieldProperties.AreEqualTo(Autodesk.Revit.DB.ICustomFieldProperties)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldProperties.AreEqualTo(Autodesk.Revit.DB.ICustomFieldProperties)`

#### Summary

Identifies if the custom field properties are equal or not.

#### Parameter `otherProperties`

The other properties.

#### Returns

Returns true if the custom field properties are equal, false otherwise.

#### Since

2024

### `T:Autodesk.Revit.DB.ICustomFieldProperties`

Member kind: type
Symbol: `Autodesk.Revit.DB.ICustomFieldProperties`

#### Summary

Represents the base class for the properties of a custom field.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.RebarBendingDetail.IsBendingDetail(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetail.IsBendingDetail(Autodesk.Revit.DB.Element)`

#### Summary

Checks if the input element is a bending detail.

#### Parameter `bendingDetail`

The element that will be checked.

#### Returns

Returns true if the input element is a bending detail, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The bendingDetail should be a bending detail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.RebarBendingDetail.SetRotation(Autodesk.Revit.DB.Element,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetail.SetRotation(Autodesk.Revit.DB.Element,System.Double)`

#### Summary

Sets the rotation angle in radians for the bending detail relative to its view.

#### Parameter `bendingDetail`

The bending detail for which we want to get the rotation.

#### Parameter `rotation`

The new rotation angle of the bending detail relative to its view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

-or-
The given value for rotation is not a number
-or-
The given value for rotation is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.RebarBendingDetail.SetPosition(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetail.SetPosition(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ)`

#### Summary

Sets the position for this bending detail relative to its view.

#### Parameter `bendingDetail`

The bending detail for which we want to get the position.

#### Parameter `position`

The new position for this bending detail relative to its view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.RebarBendingDetail.GetRotation(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetail.GetRotation(Autodesk.Revit.DB.Element)`

#### Summary

Gets the rotation angle in radians for the bending detail relative to its view.

#### Parameter `bendingDetail`

The bending detail for which we want to get the rotation.

#### Returns

Returns the rotation angle in radians for the bending detail relative to its view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.RebarBendingDetail.GetPosition(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetail.GetPosition(Autodesk.Revit.DB.Element)`

#### Summary

Gets the position of the bending detail relative to its view.

#### Parameter `bendingDetail`

The bending detail for which we want to get the position.

#### Returns

Returns the position of the bending detail relative to its view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.RebarBendingDetail.GetHost(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetail.GetHost(Autodesk.Revit.DB.Element)`

#### Summary

Gets a reference to the reinforcement element that this bending detail represent.

#### Parameter `bendingDetail`

The bending detail for which we want to get the host.

#### Returns

Returns a reference pointing to the reinforcement element represented by the input bending detail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.RebarBendingDetail.SetHost(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetail.SetHost(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Reference)`

#### Summary

Sets the reinforcement element that will be represented by the input bending detail.

#### Parameter `bendingDetail`

The bending detail for which we want to set the host.

#### Parameter `reference`

Reference pointing to the reinforcement element that will be represented by the input bending detail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.RebarBendingDetail.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.Structure.RebarBendingDetailType,Autodesk.Revit.DB.XYZ,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetail.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.Structure.RebarBendingDetailType,Autodesk.Revit.DB.XYZ,System.Double)`

#### Summary

Creates a new instance of a bending detail.

#### Parameter `document`

Document to which the new element should be added.

#### Parameter `viewId`

The id of the view in which the new element should be added.

#### Parameter `reinforcementElementId`

The reinforcement element Id that this object will represent.

#### Parameter `reinforcementElementSubelementKey`

The index of the sub-element from the reinforcement element that this object will represent.

#### Parameter `bendingDetailType`

The bending details type used with the resulting object.

#### Parameter `position`

The initial position in the view where this object will be created.

#### Parameter `rotation`

The initial rotation in the view for this element.

#### Returns

Returns an instance of a bending detail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `T:Autodesk.Revit.DB.Structure.RebarBendingDetail`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarBendingDetail`

#### Summary

Utility class with methods needed for the bending details in view.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.FlipRebarSet`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.FlipRebarSet`

#### Summary

Flips the rebar set by changing the RebarPlane with the OutOfPlaneExtent and vice versa.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2023.1

### `M:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.SetLayoutAsMinimumClearSpacing(System.Double,System.Double,System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.SetLayoutAsMinimumClearSpacing(System.Double,System.Double,System.Boolean,System.Boolean,System.Boolean)`

#### Summary

Sets the Layout Rule property of rebar set to MinimumClearSpacing

#### Remarks

When changing the layout rule to MinimumClearSpacing, you must also simultaneously set Spacing,
SetLength, BarsOnNormalSide, IncludeFirstBar, and IncludeLastBar properties.

#### Parameter `spacing`

The maximum spacing between rebar in rebar set

#### Parameter `arrayLength`

The distribution length of rebar set

#### Parameter `barsOnNormalSide`

Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal

#### Parameter `includeFirstBar`

Identifies if the first bar in rebar set is shown

#### Parameter `includeLastBar`

Identifies if the last bar in rebar set is shown

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The spacing isn't bigger than 0.0.
-or-
the set length arrayLength isn't acceptable.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This RebarShapeDrivenAccessor is an instance of a spiral or multiplanar shape.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.SetLayoutAsNumberWithSpacing(System.Int32,System.Double,System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.SetLayoutAsNumberWithSpacing(System.Int32,System.Double,System.Boolean,System.Boolean,System.Boolean)`

#### Summary

Sets the Layout Rule property of rebar set to NumberWithSpacing

#### Remarks

When changing the layout rule to NumberWithSpacing, you must also simultaneously set NumberOfBarPositions,
Spacing, BarsOnNormalSide, IncludeFirstBar, and IncludeLastBar properties.

#### Parameter `numberOfBarPositions`

The number of bar positions in rebar set

#### Parameter `spacing`

The maximum spacing between rebar in rebar set

#### Parameter `barsOnNormalSide`

Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal

#### Parameter `includeFirstBar`

Identifies if the first bar in rebar set is shown

#### Parameter `includeLastBar`

Identifies if the last bar in rebar set is shown

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the number of bar positions numberOfBarPositions is less than 1 or more than 1002.
-or-
The spacing isn't bigger than 0.0.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This RebarShapeDrivenAccessor is an instance of a spiral or multiplanar shape.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.SetLayoutAsMaximumSpacing(System.Double,System.Double,System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.SetLayoutAsMaximumSpacing(System.Double,System.Double,System.Boolean,System.Boolean,System.Boolean)`

#### Summary

Sets the Layout Rule property of rebar set to MaximumSpacing

#### Remarks

When changing the layout rule to MaximumSpacing, you must also simultaneously set Spacing,
SetLength, BarsOnNormalSide, IncludeFirstBar, and IncludeLastBar properties.

#### Parameter `spacing`

The maximum spacing between rebar in rebar set

#### Parameter `arrayLength`

The distribution length of rebar set

#### Parameter `barsOnNormalSide`

Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal

#### Parameter `includeFirstBar`

Identifies if the first bar in rebar set is shown

#### Parameter `includeLastBar`

Identifies if the last bar in rebar set is shown

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The spacing isn't bigger than 0.0.
-or-
the set length arrayLength isn't acceptable.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This RebarShapeDrivenAccessor is an instance of a spiral or multiplanar shape.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.SetLayoutAsFixedNumber(System.Int32,System.Double,System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.SetLayoutAsFixedNumber(System.Int32,System.Double,System.Boolean,System.Boolean,System.Boolean)`

#### Summary

Sets the Layout Rule property of rebar set to FixedNumber.

#### Remarks

When changing the layout rule to FixedNumber, you must also simultaneously set NumberOfBarPositions,
SetLength, BarsOnNormalSide, IncludeFirstBar, and IncludeLastBar properties.

#### Parameter `numberOfBarPositions`

The number of bar positions in rebar set

#### Parameter `arrayLength`

The distribution length of rebar set

#### Parameter `barsOnNormalSide`

Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal

#### Parameter `includeFirstBar`

Identifies if the first bar in rebar set is shown

#### Parameter `includeLastBar`

Identifies if the last bar in rebar set is shown

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the number of bar positions numberOfBarPositions is less than 1 or more than 1002.
-or-
the set length arrayLength isn't acceptable.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This RebarShapeDrivenAccessor is an instance of a spiral or multiplanar shape.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.SetLayoutAsSingle`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.SetLayoutAsSingle`

#### Summary

Sets the Layout Rule property of rebar set to Single.

#### Remarks

Only one bar will remain, which is at the position of rebar plane

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.SetRebarShapeId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.SetRebarShapeId(Autodesk.Revit.DB.ElementId)`

#### Summary

Changes the RebarShape element that defines the shape of the rebar.
Changing the value of this member causes the Rebar instance to choose values for its
shape parameters to preserve its previous shape as closely as possible

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

shapeId is not the id of a RebarShape in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.ScaleToBoxFor3D(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.ScaleToBoxFor3D(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Double)`

#### Summary

Move and resize a spiral or multiplanar instance to fit within a specified box.
The arguments are interpreted as an arbitrary rectangle in 3D with
vertices: origin, origin+xVec, origin+xVec+yVec, origin+yVec. One end of the
rebar shape is inscribed in this rectangle following the procedure described
for the ScaleToBox method. The other end is placed in the parallel plane at
distance (center-to-center) given by the height argument, in the
direction of (xVec x yVec).
Note that spiral shapes interpret the input arguments using a different convention
than multiplanar shapes. For spiral shapes, the spiral start will be placed in
the rectangle defined by origin, xVec, yVec, and the end of the spiral will be
placed in the parallel plane. For multiplanar shapes, the rebar is placed with
its primary shape definition located in the parallel plane defined by the height
argument, and its connector segments extending in the direction opposite (xVec x yVec).
This method replaces ScaleToBoxForSpiral() from prior releases.

#### Parameter `origin`

One corner of the rectangle.

#### Parameter `xVec`

Vector representing the first edge of the rectangle. The length
must be positive.

#### Parameter `yVec`

Vector representing the second edge of the rectangle. Must
be perpendicular to xVec.

#### Parameter `height`

New value for the Height or MultiplanarDepth property.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

xVec has zero length.
-or-
yVec has zero length.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor is not an instance of a spiral or multiplanar shape.
-or-
This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.
-or-
The operation has failed for geometric reasons, such as the box being too small
given the bar diameter.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.ScaleToBox(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.ScaleToBox(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Move and resize the bar to fit within a specified box.
The arguments are interpreted as an arbitrary
rectangle in 3D with vertices: origin, origin+xVec,
origin+xVec+yVec, origin+yVec. The algorithm then
proceeds as follows. First the bar is given the
default values of the shape parameters from the shape
definition. Then, if it is possible to do so without
violating the shape definition, the parameter values
are scaled so that the width and height of the shape
(including bar thickness) match the lengths of xVec and yVec.
If there is no way to do this within the shape definition
due to overconstraining, a compromise is attempted, such as
scaling the whole shape until either the width or the
height is correct. Finally the shape is rotated to
match the coordinate system of the box. The algorithm
is the same one used in one-click placement.

#### Parameter `origin`

One corner of the rectangle.

#### Parameter `xVec`

Vector representing the first edge of the rectangle. The length
must be positive.

#### Parameter `yVec`

Vector representing the second edge of the rectangle. Must
be perpendicular to xVec.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

xVec has zero length.
-or-
yVec has zero length.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This RebarShapeDrivenAccessor is an instance of a spiral or multiplanar shape.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.
-or-
The operation has failed for geometric reasons, such as the box being too small
given the bar diameter.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.GetBarPositionTransform(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.GetBarPositionTransform(System.Int32)`

#### Summary

Return a transform representing the relative position of any
individual bar in the set.

#### Remarks

The transform is a translation along the distribution path.
It can be applied to the results of GetCenterlineCurves() to
produce any bar in the rebar set. For barPositionIndex=0,
the identity transform is always returned.

#### Parameter `barPositionIndex`

An index between 0 and (NumberOfBarPositions-1).

#### Returns

The position of a bar in the set relative to the first position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.ComputeDrivingCurves`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.ComputeDrivingCurves`

#### Summary

Compute the driving curves.

#### Remarks

The driving curves are the ones that appear in rebar sketch
mode. They include lines and arcs that drive the shape, but
exclude fillets and hooks. They always lie in a plane--
if the bar is 3D, these curves are a subset or a projection.
They are also used for shape matching.

#### Returns

Returns an empty array if an error is encountered.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.GetDistributionPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.GetDistributionPath`

#### Summary

The distribution path of a rebar set.

#### Returns

A line beginning at (0, 0, 0) and representing the direction and
length of the set.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.Pitch`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.Pitch`

#### Summary

For a spiral, the pitch, or vertical distance traveled in one rotation.

#### Remarks

Applies only to instances where RebarShape.Definition is of type
RebarShapeDefinitionByArc, and its Type property is equal to the value
RebarShapeDefinitionByArcType.Spiral.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: pitch must be positive.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor is not an instance of a spiral shape.
-or-
This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.TopFinishingTurns`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.TopFinishingTurns`

#### Summary

For a spiral, the number of finishing turns at the upper end of the spiral.

#### Remarks

Applies only to instances where RebarShape.Definition is of type
RebarShapeDefinitionByArc, and its Type property is equal to the value
RebarShapeDefinitionByArcType.Spiral.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: turns must be between 0 and 100.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor is not an instance of a spiral shape.
-or-
This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.MultiplanarDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.MultiplanarDepth`

#### Summary

For a multiplanar rebar, the depth of the instance.

#### Remarks

Applicable only when an instance of a RebarShape with
a RebarShapeMultiplanarDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: multiplanarDepth must be positive.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor is not an instance of a multiplanar shape.
-or-
This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.BaseFinishingTurns`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.BaseFinishingTurns`

#### Summary

For a spiral, the number of finishing turns at the lower end of the spiral.

#### Remarks

Applies only to instances where RebarShape.Definition is of type
RebarShapeDefinitionByArc, and its Type property is equal to the value
RebarShapeDefinitionByArcType.Spiral.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: turns must be between 0 and 100.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor is not an instance of a spiral shape.
-or-
This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.ArrayLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.ArrayLength`

#### Summary

Identifies the distribution path length of rebar set.

#### Value

The distribution path length of rebar set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: the set length arrayLength isn't acceptable.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.Height`

#### Summary

For a spiral, the overall height.

#### Remarks

Applies only to instances where RebarShape.Definition is of type
RebarShapeDefinitionByArc, and its Type property is equal to the value
RebarShapeDefinitionByArcType.Spiral.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: height must be positive.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor is not an instance of a spiral shape.
-or-
This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.BarsOnNormalSide`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.BarsOnNormalSide`

#### Summary

Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal.

#### Value

True if the bars of rebar set are on the same side of the rebar plane indicated by the normal,
and false if the bars are on the opposite side.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.Normal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor.Normal`

#### Summary

A unit-length vector normal to the plane of the rebar

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarShapeDrivenAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor`

#### Summary

A class that is used to access the properties and capabilities of shape-driven Rebar.

#### Remarks

Obtain an instance of this class from `M:Autodesk.Revit.DB.Structure.Rebar.GetShapeDrivenAccessor` .
The accessor includes a reference to the Rebar element.
If the referenced Rebar element is deleted, using the methods form this class will throw exception.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarShape.GetParamDefinedBySpiralDiameterFormula`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.GetParamDefinedBySpiralDiameterFormula`

#### Summary

Gets the shared parameters that are defined as forumulas that are equal to spiral diameter.

#### Returns

Returns the shared parameters that are defined as forumulas that are equal to spiral diameter.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShape.GetParamDefinedBySpiralPitchFormula`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.GetParamDefinedBySpiralPitchFormula`

#### Summary

Gets the shared parameters that are defined as forumulas that are equal to spiral pitch.

#### Returns

Returns the shared parameters that are defined as forumulas that are equal to spiral pitch.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShape.GetParamDefinedBySpiralHeightFormula`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.GetParamDefinedBySpiralHeightFormula`

#### Summary

Gets the shared parameters that are defined as forumulas that are equal to spiral height.

#### Returns

Returns the shared parameters that are defined as forumulas that are equal to spiral height.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShape.GetParamsDefinedByHookFormulasAtEnd(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.GetParamsDefinedByHookFormulasAtEnd(System.Int32)`

#### Summary

Gets the shared parameters that are defined as forumulas that are equal to hook at length, hook offset, hook tanglent length at the specified end.

#### Returns

Returns the shared parameters that are defined as forumulas that are equal to hook at length, hook offset, hook tanglent length at the specified end.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShape.HasEndTreatment`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.HasEndTreatment`

#### Summary

Identifies if the rebar shape has end treatment at at least one end.

#### Returns

Returns true if the rebar shape has end treatment for at least one end, false otherwise.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.RebarShape.SetEndTreatmentTypeId(Autodesk.Revit.DB.ElementId,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.SetEndTreatmentTypeId(Autodesk.Revit.DB.ElementId,System.Int32)`

#### Summary

Sets the EndTreatmentType id at the specified rebar shape end.

#### Parameter `endTreatmentId`

The id of an EndTreatmentType element, or invalidElementId if the rebar shape should have no end treatment at the specified end.

#### Parameter `iEnd`

0 for the start end treatment, 1 for the end end treatment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

iEnd not a valid shape end
-or-
the parameter endTreatmentId is not an EndTreatmentType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.RebarShape.GetEndTreatmentTypeId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.GetEndTreatmentTypeId(System.Int32)`

#### Summary

Gets the id of the EndTreatmentType at the specified rebar shape end.

#### Parameter `iEnd`

0 for the start end treatment, 1 for the end end treatment.

#### Returns

Returns the id of an EndTreatmentType, or invalidElementId if the rebar shape has no end treatment at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

iEnd not a valid shape end

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.RebarShape.IsSameShapeIgnoringHooks(Autodesk.Revit.DB.Structure.RebarShape)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.IsSameShapeIgnoringHooks(Autodesk.Revit.DB.Structure.RebarShape)`

#### Summary

Test whether two shapes have equivalent definitions by comparing
the RebarShapeDefinition and MultiplanarDefinition properties.

#### Remarks

This method will return true if the definitions are exactly
equivalent, or if they are equivalent but have the opposite
start/end orientation.
Replaces the property RebarShape.SameShapeIgnoringHooks from prior releases.

#### Parameter `otherShape`

Another shape to be compared to this one.

#### Returns

True if the shape definitions match, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShape.SetHookRotationAngle(System.Double,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.SetHookRotationAngle(System.Double,System.Int32)`

#### Summary

Sets the out of plane hook rotation angle at the specified end.

#### Parameter `hookRotationAngle`

The out of plane hook rotation angle at the specified end.

#### Parameter `iEnd`

0 for the start , 1 for the end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

iEnd must be 0 or 1.

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.RebarShape.GetHookRotationAngle(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.GetHookRotationAngle(System.Int32)`

#### Summary

Gets the out of plane hook rotation angle at the specified end.

#### Parameter `iEnd`

0 for the start , 1 for the end.

#### Returns

Returns the out of plane hook rotation angle at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

iEnd must be 0 or 1.

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.RebarShape.GetCurvesForBrowser`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.GetCurvesForBrowser`

#### Summary

Generate curves for the shape, as used in the shape browser.

#### Returns

An array of curves representing the shape with its default parameters.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShape.GetDefaultHookOrientation(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.GetDefaultHookOrientation(System.Int32)`

#### Summary

Get the hook orientation.

#### Remarks

Replaces the method GetHookOrientation() from prior releases.

#### Parameter `index`

0 for the starting hook, 1 for the ending hook.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index must be 0 or 1.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarShape.GetDefaultHookAngle(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.GetDefaultHookAngle(System.Int32)`

#### Summary

Get the hook angle, expressed as an integral number of degrees (common values are 0, 90, 135, and 180).

#### Remarks

Replaces the method GetHookAngle() from prior releases.

#### Parameter `index`

0 for the starting hook, 1 for the ending hook.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index must be 0 or 1.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarShape.GetAllowed(Autodesk.Revit.DB.Structure.RebarBarType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.GetAllowed(Autodesk.Revit.DB.Structure.RebarBarType)`

#### Summary

Check whether a bar type can be used with this RebarShape. Bar types are allowed by default.

#### Parameter `barType`

A bar type in the same document as this shape.

#### Returns

True if this shape may be combined with this barType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShape.SetAllowed(Autodesk.Revit.DB.Structure.RebarBarType,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.SetAllowed(Autodesk.Revit.DB.Structure.RebarBarType,System.Boolean)`

#### Summary

Specify which bar types can be used with this RebarShape. Bar types are allowed by default.

#### Parameter `barType`

A bar type in the same document as this shape.

#### Parameter `allowed`

Whether this shape may be combined with barType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShape.GetMultiplanarDefinition`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.GetMultiplanarDefinition`

#### Summary

The optional 3D structure of the shape.

#### Returns

A copy of the multiplanar definition. Changes will not affect the RebarShape.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShape.GetRebarShapeDefinition`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.GetRebarShapeDefinition`

#### Summary

Return the definition of the RebarShape.

#### Remarks

Replaces the property RebarShape.Definition from previous releases.

#### Returns

A copy of the definition. Changes will not affect the RebarShape.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShape.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarShapeDefinition,Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition,Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.StirrupTieAttachmentType,System.Int32,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Int32,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Int32,System.Double,System.Double,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarShapeDefinition,Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition,Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.StirrupTieAttachmentType,System.Int32,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Int32,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Int32,System.Double,System.Double,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Create a new instance of a Rebar Shape, which defines the shape of a rebar.

#### Parameter `doc`

A document to contain the RebarShape.

#### Parameter `definition`

The definition of the rebar shape, as a set of curves in a plane
driven by parameters.

#### Parameter `multiplanarDefinition`

If not `null` , the created RebarShape will be a 3D shape. The shape
is built out of the planar RebarShapeDefinition, with additional
out-of-plane segments defined by the RebarShapeMultiplanarDefinition
object. Not supported in conjunction with RebarShapeDefinitionByArc
of type Spiral or LappedCircle.

#### Parameter `style`

Whether the shape is to be used as a standard bar or a stirrup/tie.

#### Parameter `attachmentType`

When the style is stirrup/tie, specify whether it will attach to the
interior of cover (cover is measured to the stirrups), or to the
exterior of cover (cover is measured to the standard bars).
Ignored when the style is Standard.

#### Parameter `startHookAngle`

The start hook angle, expressed as an integral number of degrees.
If 0, the shape will have no start hook. Common values are 0, 90, 135, and 180.

#### Parameter `startHookOrientation`

The orientation of the start hook.
Ignored when startHookAngle is 0.

#### Parameter `endHookAngle`

The end hook angle, expressed as an integral number of degrees.
If 0, the shape will have no end hook. Common values are 0, 90, 135, and 180.

#### Parameter `endHookOrientation`

The orientation of the end hook.
Ignored when endHookAngle is 0.

#### Parameter `higherEnd`

When the rebar crosses itself, one end will be "lifted" to avoid self-intersection.
Specify which end should be lifted: 0 for start, 1 for end.

#### Parameter `hookRotationAngleAtStart`

The out of plane hook rotation angle at the start of the bar.

#### Parameter `hookRotationAngleAtEnd`

The out of plane hook rotation angle at the end of the bar.

#### Parameter `endTreatmentTypeIdAtStart`

The end treatment type id at the start of the bar.

#### Parameter `endTreatmentTypeIdAtEnd`

The end treatment type id at the end of the bar.

#### Returns

A new RebarShape instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

definition is linked to a Document other than doc.
-or-
A multiplanar definition is specified when the given RebarShapeDefinition
does not support it. The following RebarShapeDefinitions do not support
multiplanar: a simple line; spiral; lapped circle.
-or-
The DepthParamId property of multiplanarDefinition
is invalid or has not been added to definition.
-or-
the parameter endTreatmentTypeIdAtStart is not an EndTreatmentType element.
-or-
the parameter endTreatmentTypeIdAtEnd is not an EndTreatmentType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

startHookAngle must be at least 0 and no more than 180.
-or-
endHookAngle must be at least 0 and no more than 180.
-or-
higherEnd must be 0 or 1.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.RebarShape.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarShapeDefinition,Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition,Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.StirrupTieAttachmentType,System.Int32,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Int32,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarShapeDefinition,Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition,Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.StirrupTieAttachmentType,System.Int32,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Int32,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Int32)`

#### Summary

Create a new instance of a Rebar Shape, which defines the shape of a rebar.

#### Parameter `doc`

A document to contain the RebarShape.

#### Parameter `definition`

The definition of the rebar shape, as a set of curves in a plane
driven by parameters.

#### Parameter `multiplanarDefinition`

If not null, the created RebarShape will be a 3D shape. The shape
is built out of the planar RebarShapeDefinition, with additional
out-of-plane segments defined by the RebarShapeMultiplanarDefinition
object. Not supported in conjunction with RebarShapeDefinitionByArc
of type Spiral or LappedCircle.

#### Parameter `style`

Whether the shape is to be used as a standard bar or a stirrup/tie.

#### Parameter `attachmentType`

When the style is stirrup/tie, specify whether it will attach to the
interior of cover (cover is measured to the stirrups), or to the
exterior of cover (cover is measured to the standard bars).
Ignored when the style is Standard.

#### Parameter `startHookAngle`

The start hook angle, expressed as an integral number of degrees.
If 0, the shape will have no start hook. Common values are 0, 90, 135, and 180.

#### Parameter `startHookOrientation`

The orientation of the start hook.
Ignored when startHookAngle is 0.

#### Parameter `endHookAngle`

The end hook angle, expressed as an integral number of degrees.
If 0, the shape will have no end hook. Common values are 0, 90, 135, and 180.

#### Parameter `endHookOrientation`

The orientation of the end hook.
Ignored when endHookAngle is 0.

#### Parameter `higherEnd`

When the rebar crosses itself, one end will be "lifted" to avoid self-intersection.
Specify which end should be lifted: 0 for start, 1 for end.

#### Returns

A new RebarShape instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

definition is linked to a Document other than doc.
-or-
A multiplanar definition is specified when the given RebarShapeDefinition
does not support it. The following RebarShapeDefinitions do not support
multiplanar: a simple line; spiral; lapped circle.
-or-
The DepthParamId property of multiplanarDefinition
is invalid or has not been added to definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

startHookAngle must be at least 0 and no more than 180.
-or-
endHookAngle must be at least 0 and no more than 180.
-or-
higherEnd must be 0 or 1.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShape.ShapeFamilyId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.ShapeFamilyId`

#### Summary

Get and return the rebar shape family id.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.RebarShape.HigherEnd`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.HigherEnd`

#### Summary

Defines the higher end of rebar shape.

#### Remarks

Change this property will make rebar shape's start and end hooks swap.

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.RebarShape.HasOnlyPerpendicularSegments`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.HasOnlyPerpendicularSegments`

#### Summary

Identifies if any two adjacent segments are perpendicular or not. If the bar segments are other than lines, this property is false.

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.RebarShape.StirrupTieAttachment`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.StirrupTieAttachment`

#### Summary

The attachment type of stirrup ties and rebars.

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.RebarShape.RebarStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.RebarStyle`

#### Summary

Whether the shape represents a standard bar or a stirrup.

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.RebarShape.SimpleArc`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.SimpleArc`

#### Summary

Check whether this shape consists of a single arc, possibly with hooks.

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.RebarShape.SimpleLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShape.SimpleLine`

#### Summary

Check whether this shape consists of a single straight segment, possibly with hooks.

#### Since

2009

### `T:Autodesk.Revit.DB.Structure.RebarShape`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShape`

#### Summary

RebarShape specifies the shape type for a Rebar instance.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetReportedShape(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetReportedShape(Autodesk.Revit.DB.ElementId)`

#### Summary

This method changes the RebarShape of a Free Form Rebar that is using RebarWorkInstructions.Straight property to the provided RebarShape.

#### Remarks

The Rebar element RebarWorkInstructions property should be Straight.
The rebarShapeId parameter should be the id of a straight RebarShape (single straight segment, no RebarHookType, no EndTreatmentType).
Moreover the straight RebarShape RebarStyle should match ( if the current RebarShape RebarStyle is Standard then the RebarShape cannot be changed to a straigh RebarShape using the RebarStyle Stirrup/Tie ).
If current RebarShape and the provided rebarShapeId has Stirrup/Tie RebarStyle then also the StirrupTieAttachmentType should match ( both InteriorFace or ExteriorFace ).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

rebarShapeId cannot be set as a reporting RebarShape for this Rebar element.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.DisconnectFromServer`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.DisconnectFromServer`

#### Summary

Sets the GUID of the API server to invalid value and removes all the server related data from the Rebar (ex. the current constraints and the handle tags are removed).
Calling this method will result in a Rebar that will not react to host changes anymore, however it will still have all the properties that it used to have.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetServerGUID`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetServerGUID`

#### Summary

Returns the GUID of the API server.

#### Returns

The GUID of the API server

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor doesn't contain a valid rebar reference.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetCurves(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetCurves(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Set the curves into a free form Rebar. Will throw exception if the rebar has valid constraints.

#### Remarks

This function can fail due to following reasons:

The array of CurveLoops is empty.

At least one CurveLoop is empty.

At least one CurveLoop contains an unbounded curve.

A rebar constructed from curves can't be bent according to the bending radius.

#### Parameter `curves`

Each curve loop represents a bar in the set.

#### Returns

Returns Success if everything is ok, otherwise the failure reason.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor Rebar is constrained.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetCurves(System.Collections.Generic.IList{System.Collections.Generic.IList{Autodesk.Revit.DB.Curve}})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetCurves(System.Collections.Generic.IList{System.Collections.Generic.IList{Autodesk.Revit.DB.Curve}})`

#### Summary

Set the curves into a free form Rebar. Will throw exception if the rebar has valid constraints.

#### Remarks

This function can fail due to following reasons:

One or more of the input curves was null.

One or more of the input curves was unbounded.

Curves doesn't form a valid curve loop, it forms 0, 2 or more curve loops.

A rebar constructed from curves can't be bent according to the bending radius.

#### Parameter `curves`

Each array of curves represent a bar in the set.

#### Returns

Returns Success(0) if everything is ok, otherwise the failure reason.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor Rebar is constrained.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.CanBeHookNormal(System.Int32,System.Int32,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.CanBeHookNormal(System.Int32,System.Int32,Autodesk.Revit.DB.XYZ)`

#### Summary

A vector can be hook normal if for a bar specified by index, the bar direction is not parallel with the vector.

#### Parameter `barIndex`

The index of bar for which it will try to see if hook normal is applicable.

#### Parameter `end`

The end of bar. Should be 0 for start, 1 for end.

#### Parameter `normal`

The hook plane normal that will be tested.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetHookOrientationAngle(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetHookOrientationAngle(System.Int32)`

#### Summary

Get the hook orientation angle at end.

#### Parameter `end`

The end of bar. Should be 0 for start or 1 for end.

#### Returns

The hook orientation angle at end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Invalid end.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetHookOrientationAngle(System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetHookOrientationAngle(System.Int32,System.Double)`

#### Summary

Set the hook orientation angle at end. Will throw exception if the rebar has valid constraints.

#### Parameter `end`

The end of bar. Should be 0 for start or 1 for end.

#### Parameter `angle`

The hook orientation angle at end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Invalid end.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor Rebar is constrained.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetHookPlaneNormalForBarIdx(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetHookPlaneNormalForBarIdx(System.Int32,System.Int32)`

#### Summary

Returns the normal of plane in which the hook at end of bar with index barPositionIndex will stay.

#### Parameter `end`

The end of bar. Should be 0 for start or 1 for end.

#### Parameter `barPositionIndex`

An index between 0 and (NumberOfBarPositions-1).

#### Returns

The normal of plane in which the hook at end of bar with index barPositionIndex will stay.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].
-or-
Invalid end.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetHookPlaneNormalForBarIdx(System.Int32,System.Int32,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetHookPlaneNormalForBarIdx(System.Int32,System.Int32,Autodesk.Revit.DB.XYZ)`

#### Summary

Set the normal of plane in which the hook at end of bar with index barPositionIndex will stay. Will throw exception if the rebar has valid constraints.

#### Parameter `end`

The end of bar. Should be 0 for start or 1 for end.

#### Parameter `barPositionIndex`

An index between 0 and (NumberOfBarPositions-1).

#### Parameter `hookNormal`

The normal of plane in which the hook at end of bar with index barPositionIndex will stay.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Normal hookNormal for end end isn't a valid normal for bar with index barPositionIndex

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].
-or-
Invalid end.
-or-
hookNormal has zero length.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor Rebar is constrained.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.IsUnconstrained`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.IsUnconstrained`

#### Summary

Returns true if the current rebar doesn't contains a valid server GUID, or contains a valid server GUID and no valid constraints.

#### Returns

Returns true if the current rebar doesn't contains a valid server GUID, or contains a valid server GUID and no valid constraints.
Returns false if the current rebar contains a valid server GUID and has valid constraints.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.HasValidAlignedServer`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.HasValidAlignedServer`

#### Summary

Returns true if the current rebar is created with the Aligned Free Form rebar server, false otherwise.

#### Returns

Returns true if the current rebar is created with the Aligned Free Form rebar server, false otherwise.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.HasValidServer`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.HasValidServer`

#### Summary

Returns true if the current rebar contains a valid server GUID, false otherwise.

#### Returns

Returns true if the current rebar contains a valid server GUID, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetUpdatingSharedParameters`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetUpdatingSharedParameters`

#### Summary

Get the shared parameters listed as dependencies in the calculation of the rebar curves

#### Returns

Returns the elementIds of the shared parameters

#### Since

2020

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.RemoveUpdatingSharedParameter(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.RemoveUpdatingSharedParameter(Autodesk.Revit.DB.ElementId)`

#### Summary

Remove existing shared parameter as a dependency for the calculation of the rebar curves.

#### Remarks

The input parameter needs to be bound to the Rebar element

The rebar element needs to have a valid external server

#### Parameter `parameterId`

ElementId of the shared parameter to be removed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor Rebar doesn't contain a valid server GUID.
-or-
parameterId is a parameter that is not bound to the Rebar element category.

#### Since

2020

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.AddUpdatingSharedParameter(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.AddUpdatingSharedParameter(Autodesk.Revit.DB.ElementId)`

#### Summary

Add existing shared parameter as a dependency for the calculation of the rebar curves.

#### Remarks

The input parameter needs to be bound to the Rebar element

The rebar element needs to have a valid external server

#### Parameter `parameterId`

ElementId of the shared parameter to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor Rebar doesn't contain a valid server GUID.
-or-
parameterId is a parameter that is not bound to the Rebar element category.

#### Since

2020

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetEndTreatmentTypeIdAtIndex(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetEndTreatmentTypeIdAtIndex(System.Int32,System.Int32)`

#### Summary

Gets the id of the EndTreatmentType that is applied to the bar with index barPositionIndex at the specified end.

#### Remarks

If this Rebar has Workshop Instructions set to Straight will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as Rebar.GetEndTreatmentTypeId(int end).

If this Rebar has Workshop Instructions set to Bent there are different cases:
All bars are matched exactly with a shape. In this case will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as Rebar.GetEndTreatmentTypeId(int end).

All bars are matched in reversed order with a shape. In this case will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as Rebar.GetEndTreatmentTypeId(int end).

Some bars are matched in reversed order and the others are matched exactly with a shape. In this case for bars that are matched reversed will return the id of the EndTreatmentType at the opposite end. For the others bars will return the same as Rebar.GetEndTreatmentTypeId(int end).

#### Parameter `barPositionIndex`

An index between 0 and (NumberOfBarPositions-1).

#### Parameter `end`

0 for the start hook, 1 for the end hook.

#### Returns

Returns the the id of the EndTreatmentType at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.
-or-
barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetCouplerIdAtIndex(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetCouplerIdAtIndex(System.Int32,System.Int32)`

#### Summary

Gets the id of the Rebar Coupler that is applied to the bar with index barPositionIndex at the specified end.

#### Remarks

If this Rebar has Workshop Instructions set to Straight will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as Rebar.GetCouplerId(int end).

If this Rebar has Workshop Instructions set to Bent there are different cases:
All bars are matched exactly with a shape. In this case will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as Rebar.GetCouplerId(int end).

All bars are matched in reversed order with a shape. In this case will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as Rebar.GetCouplerId(int end).

Some bars are matched in reversed order and the others are matched exactly with a shape. In this case for bars that are matched reversed will return the id of the Rebar Coupler at the opposite end. For the others bars will return the same as Rebar.GetCouplerId(int end).

#### Parameter `barPositionIndex`

An index between 0 and (NumberOfBarPositions-1).

#### Parameter `end`

0 for the start hook, 1 for the end hook.

#### Returns

Returns id of the Rebar Coupler at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.
-or-
barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetHookOrientationAtIndex(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetHookOrientationAtIndex(System.Int32,System.Int32)`

#### Summary

Gets the hook orientation that is applied to this Rebar at the bar with index barPositionIndex at the specified end.

#### Remarks

If this Rebar has Workshop Instructions set to Straight will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as Rebar.GetHookOrientation(int end).

If this Rebar has Workshop Instructions set to Bent there are different cases:
All bars are matched exactly with a shape. In this case will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as Rebar.GetHookOrientation(int end).

All bars are matched in reversed order with a shape. In this case will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as Rebar.GetHookOrientation(int end).

Some bars are matched in reversed order and the others are matched exactly with a shape. In this case for bars that are matched reversed will return the hook orientation at the opposite end. For the others bars will return the same as Rebar.GetHookOrientation(int end).

#### Parameter `barPositionIndex`

An index between 0 and (NumberOfBarPositions-1).

#### Parameter `end`

0 for the start hook, 1 for the end hook.

#### Returns

Returns the hook orientation at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.
-or-
barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetHookOrientationAngleAtIndex(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetHookOrientationAngleAtIndex(System.Int32,System.Int32)`

#### Summary

Gets the hook orientation angle that is applied to this Rebar at the bar with index barPositionIndex at the specified end.

#### Remarks

If this Rebar has Workshop Instructions set to Straight will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as RebarFreeFormAccessor.GetHookOrientationAngle(int end).

If this Rebar has Workshop Instructions set to Bent there are different cases:
All bars are matched exactly with a shape. In this case will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as RebarFreeFormAccessor.GetHookOrientationAngle(int end).

All bars are matched in reversed order with a shape. In this case will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as RebarFreeFormAccessor.GetHookOrientationAngle(int end).

Some bars are matched in reversed order and the others are matched exactly with a shape. In this case for bars that are matched reversed will return the hook orientation angle at the opposite end. For the others bars will return the same as RebarFreeFormAccessor.GetHookOrientationAngle(int end).

#### Parameter `barPositionIndex`

An index between 0 and (NumberOfBarPositions-1).

#### Parameter `end`

0 for the start hook, 1 for the end hook.

#### Returns

Returns the hook orientation angle at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.
-or-
barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetHookTypeIdAtIndex(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetHookTypeIdAtIndex(System.Int32,System.Int32)`

#### Summary

Gets the id of the RebarHookType that is applied to this Rebar at the bar with index barPositionIndex at the specified end.

#### Remarks

If this Rebar has Workshop Instructions set to Straight will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as Rebar.GetHookTypeId(int end).

If this Rebar has Workshop Instructions set to Bent there are different cases:
All bars are matched exactly with a shape. In this case will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as Rebar.GetHookTypeId(int end).

All bars are matched in reversed order with a shape. In this case will return the same value for all barPositionIndex between 0 and (NumberOfBarPositions-1). This value will be the same as Rebar.GetHookTypeId(int end).

Some bars are matched in reversed order and the others are matched exactly with a shape. In this case for bars that are matched reversed will return the id of the RebarHookType at the opposite end. For the others bars will return the same as Rebar.GetHookTypeId(int end).

#### Parameter `barPositionIndex`

An index between 0 and (NumberOfBarPositions-1).

#### Parameter `end`

0 for the start hook, 1 for the end hook.

#### Returns

The id of a RebarHookType, or invalidElementId if the rebar has no hook at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.
-or-
barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.IsBarMatchedWithShapeInReverseOrder(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.IsBarMatchedWithShapeInReverseOrder(System.Int32)`

#### Summary

Checks if the bar at index barPositionIndex it's matched in reversed order with its shape.

#### Remarks

If this Rebar has Workshop Instructions set to Straight will return false for all barPositionIndex between 0 and (NumberOfBarPositions-1).

If this Rebar has Workshop Instructions set to Bent there are different cases:
All bars are matched exactly with a shape. In this case will return false for all barPositionIndex between 0 and (NumberOfBarPositions-1).

All bars are matched in reversed order with a shape. In this case the Rebar will be reversed and will return false for all barPositionIndex between 0 and (NumberOfBarPositions-1).

Some bars are matched in reversed order and the others are matched exactly with a shape. For the bars matched in reversed order will return true and for the others will return false

#### Parameter `barPositionIndex`

An index between 0 and (NumberOfBarPositions-1).

#### Returns

Returns true if the bar is matched in reversed order with its shape, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetShapeIdAtIndex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetShapeIdAtIndex(System.Int32)`

#### Summary

Gets the Rebar Shape id for the bar with index barPositionIndex.

#### Remarks

If this function is called for a bar that isn't included, this function will throw exception.

#### Parameter `barPositionIndex`

An index between 0 and (NumberOfBarPositions-1).

#### Returns

Gets the ElementId of the Rebar Shape for the bar with index barPositionIndex.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].
-or-
The bar at barPositionIndex index is excluded.

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetLayoutAsMinimumClearSpacing(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetLayoutAsMinimumClearSpacing(System.Double)`

#### Summary

Sets the Layout Rule property of rebar set to Minimum Clear Spacing.

#### Parameter `spacing`

The maximum spacing of bars in set.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor doesn't contain a valid rebar reference.
-or-
This RebarFreeFormAccessor Rebar doesn't contain a valid server GUID.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetLayoutAsMaximumSpacing(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetLayoutAsMaximumSpacing(System.Double)`

#### Summary

Sets the Layout Rule property of rebar set to Maximum Spacing.

#### Parameter `spacing`

The maximum spacing of bars in set.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor doesn't contain a valid rebar reference.
-or-
This RebarFreeFormAccessor Rebar doesn't contain a valid server GUID.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetLayoutAsFixedNumber(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetLayoutAsFixedNumber(System.Int32)`

#### Summary

Sets the Layout Rule property of rebar set to Fixed Number.

#### Parameter `numberOfBars`

The number of bars in set.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor doesn't contain a valid rebar reference.
-or-
This RebarFreeFormAccessor Rebar doesn't contain a valid server GUID.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetLayoutAsNumberWithSpacing(System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetLayoutAsNumberWithSpacing(System.Int32,System.Double)`

#### Summary

Sets the Layout Rule property of rebar set to Number With Spacing.

#### Parameter `numberOfBars`

The number of bars in set.

#### Parameter `spacing`

The spacing of bars in set.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor doesn't contain a valid rebar reference.
-or-
This RebarFreeFormAccessor Rebar doesn't contain a valid server GUID.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetLayoutAsSingle`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.SetLayoutAsSingle`

#### Summary

Sets the Layout Rule property of rebar set to Single.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor doesn't contain a valid rebar reference.
-or-
This RebarFreeFormAccessor Rebar doesn't contain a valid server GUID.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetCustomDistributionPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.GetCustomDistributionPath`

#### Summary

Gets the custom distribution path for free form rebar set.

#### Remarks

For a free form rebar set the distance between two consecutive bars may be different if it is calculated between different points on bars.
The distribution path is an array of curves with the property that based on these curves the set was calculated to respect the layout rule and number of bars or spacing.

#### Returns

Returns an array of curves that represent the distribution path.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor doesn't contain a valid rebar reference.
-or-
This RebarFreeFormAccessor Rebar doesn't contain a valid server GUID.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.AlignedFreeFormSetOrientationOptions`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.AlignedFreeFormSetOrientationOptions`

#### Summary

Orientation options for an Aligned Free Form Rebar set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor doesn't contain a valid rebar reference.
-or-
This RebarFreeFormAccessor Rebar is not created with the Aligned Free Form rebar server.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.CycleCounter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.CycleCounter`

#### Summary

Identifies the cycle counter. It can be zero or a pozitive number.

Its value is changed when the free form Rebar element is selected and the user press Space key
-or- through the setter of this property
-or- by the server if it considers that the counter reaches the maximum value and reset it (set it to 0).
This property can be accessed just for Rebars that are controlled by a server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for cycleCounter is negative.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RebarFreeFormAccessor doesn't contain a valid rebar reference.
-or-
This RebarFreeFormAccessor Rebar doesn't contain a valid server GUID.

#### Since

2024
