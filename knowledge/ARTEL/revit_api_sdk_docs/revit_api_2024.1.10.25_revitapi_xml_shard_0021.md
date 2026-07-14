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
Shard: 21
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `P:Autodesk.Revit.DB.SweptBlend.TopSketch`

Member kind: property
Symbol: `Autodesk.Revit.DB.SweptBlend.TopSketch`

#### Summary

The top profile sketch of the swept blend.

#### Remarks

If the top profile is based on a family symbol, this property is `null` .

### `T:Autodesk.Revit.DB.SweptBlend`

Member kind: type
Symbol: `Autodesk.Revit.DB.SweptBlend`

#### Summary

A swept blend solid or void form.

### `M:Autodesk.Revit.DB.Sketch.GetAllElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.Sketch.GetAllElements`

#### Summary

Returns all elements which belong to the sketch.

#### Remarks

Following elements can belong to a sketch:
`T:Autodesk.Revit.DB.ModelCurve` ,
`T:Autodesk.Revit.DB.ReferencePlane` ,
`T:Autodesk.Revit.DB.Dimension` .
To get matching between `T:Autodesk.Revit.DB.Curve` from `P:Autodesk.Revit.DB.Sketch.Profile` and `T:Autodesk.Revit.DB.ModelCurve` , use `!:Autodesk::Revit::DB::Curve::Reference::ElementId` .

#### Returns

Returns ids of elements which belong to that sketch.

#### Since

2022

### `P:Autodesk.Revit.DB.Sketch.OwnerId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Sketch.OwnerId`

#### Summary

Returns id of the sketch owner element or invalidElementId if sketch does not build a geometry.

#### Since

2022

### `P:Autodesk.Revit.DB.Sketch.SketchPlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.Sketch.SketchPlane`

#### Summary

Returns the Sketch Plane of the Sketch.

#### Remarks

This property is used to retrieve the Sketch Plane of Sketch.

### `P:Autodesk.Revit.DB.Sketch.Profile`

Member kind: property
Symbol: `Autodesk.Revit.DB.Sketch.Profile`

#### Summary

Returns the Profile of the Sketch.

#### Remarks

This property is used to retrieve the Profile of Sketch.

### `T:Autodesk.Revit.DB.Sketch`

Member kind: type
Symbol: `Autodesk.Revit.DB.Sketch`

#### Summary

Provides access to the Sketch in Autodesk Revit.

### `T:Autodesk.Revit.DB.SketchBase`

Member kind: type
Symbol: `Autodesk.Revit.DB.SketchBase`

#### Summary

Provides access to the SketchBase in Autodesk Revit.

#### Remarks

SketchBase is the base class of Sketch.

### `P:Autodesk.Revit.DB.Blend.TopProfile`

Member kind: property
Symbol: `Autodesk.Revit.DB.Blend.TopProfile`

#### Summary

The curves which make up the top profile of the sketch.

#### Remarks

The indices of the curves in this array match the indices used in the vertex connection map.

### `P:Autodesk.Revit.DB.Blend.BottomProfile`

Member kind: property
Symbol: `Autodesk.Revit.DB.Blend.BottomProfile`

#### Summary

The curves which make up the bottom profile of the sketch.

#### Remarks

The indices of the curves in this array match the indices used in the vertex connection map.

### `M:Autodesk.Revit.DB.Blend.SetVertexConnectionMap(Autodesk.Revit.DB.VertexIndexPairArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Blend.SetVertexConnectionMap(Autodesk.Revit.DB.VertexIndexPairArray)`

#### Summary

Sets the mapping between the vertices in the top and bottom profiles.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"vertexMap"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the input argument-"vertexMap"-is empty.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the document failed to regenerate.

### `M:Autodesk.Revit.DB.Blend.GetVertexConnectionMap`

Member kind: method
Symbol: `Autodesk.Revit.DB.Blend.GetVertexConnectionMap`

#### Summary

Gets the mapping between the vertices in the top and bottom profiles.

#### Remarks

Each vertex refers to the start point of the curve from the top and bottom profiles.

### `P:Autodesk.Revit.DB.Blend.TopOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Blend.TopOffset`

#### Summary

The offset of the top end of the blend relative to the sketch plane.

### `P:Autodesk.Revit.DB.Blend.BottomOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Blend.BottomOffset`

#### Summary

The offset of the bottom end of the blend relative to the sketch plane.

### `P:Autodesk.Revit.DB.Blend.BottomSketch`

Member kind: property
Symbol: `Autodesk.Revit.DB.Blend.BottomSketch`

#### Summary

Returns the Bottom Sketch of the Blend.

#### Remarks

This property is used to retrieve the Bottom Sketch of the Blend.

### `P:Autodesk.Revit.DB.Blend.TopSketch`

Member kind: property
Symbol: `Autodesk.Revit.DB.Blend.TopSketch`

#### Summary

Returns the Top Sketch of the Blend.

#### Remarks

This property is used to retrieve the Top Sketch of the Blend.

### `T:Autodesk.Revit.DB.Blend`

Member kind: type
Symbol: `Autodesk.Revit.DB.Blend`

#### Summary

A blend solid or void form.

### `T:Autodesk.Revit.DB.BeamSystemType`

Member kind: type
Symbol: `Autodesk.Revit.DB.BeamSystemType`

#### Summary

An object that specifies the type of a beam system in Autodesk Revit.

### `P:Autodesk.Revit.DB.LayoutRuleClearSpacing.JustifyType`

Member kind: property
Symbol: `Autodesk.Revit.DB.LayoutRuleClearSpacing.JustifyType`

#### Summary

Get or set the type of justification.

#### Remarks

The justifyType passed in must be a valid object.

### `P:Autodesk.Revit.DB.LayoutRuleClearSpacing.Spacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.LayoutRuleClearSpacing.Spacing`

#### Summary

Get or set the spacing of the beam system.

#### Remarks

The value of spacing must be in [0, 30000), but in fact the spacing
should not be too small or too great.

### `M:Autodesk.Revit.DB.LayoutRuleClearSpacing.#ctor(System.Double,Autodesk.Revit.DB.BeamSystemJustifyType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LayoutRuleClearSpacing.#ctor(System.Double,Autodesk.Revit.DB.BeamSystemJustifyType)`

#### Summary

Constructor of LayoutRuleFixedDistance. Create LayoutRuleFixedDistance with the values passed in.

#### Parameter `spacing`

The value of spacing must be in [0, 30000).

#### Parameter `justifyType`

The type of the justification, it's corresponding to the items in the element properties dialog.

#### Remarks

The value of spacing must be in [0, 30000), but in fact the spacing should not be too small or too great.

### `T:Autodesk.Revit.DB.LayoutRuleClearSpacing`

Member kind: type
Symbol: `Autodesk.Revit.DB.LayoutRuleClearSpacing`

#### Summary

This class indicate the layout rule of a Beam System is Clear-Spacing.

#### Remarks

To use this type of LayoutRule, the distance between the beams and the justify-type must be set.

### `P:Autodesk.Revit.DB.LayoutRuleMaximumSpacing.Spacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.LayoutRuleMaximumSpacing.Spacing`

#### Summary

Get or set the spacing of the beam system.

#### Remarks

The value of spacing must be in (0, 30000), but in fact the spacing
should not be too small or too great.

### `M:Autodesk.Revit.DB.LayoutRuleMaximumSpacing.#ctor(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LayoutRuleMaximumSpacing.#ctor(System.Double)`

#### Summary

Constructor of LayoutRuleMaximumSpacing.

#### Parameter `spacing`

The value of spacing must be in (0, 30000).

#### Remarks

The value of spacing must be in (0, 30000), but in fact the spacing
should not be too small or too great.

### `T:Autodesk.Revit.DB.LayoutRuleMaximumSpacing`

Member kind: type
Symbol: `Autodesk.Revit.DB.LayoutRuleMaximumSpacing`

#### Summary

This class indicate the layout rule of a Beam System is Max-Spacing.

#### Remarks

To use this type of LayoutRule, only the maximum spacing must be set and it must be in (0, 30000).

### `P:Autodesk.Revit.DB.LayoutRuleFixedNumber.NumberOfLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.LayoutRuleFixedNumber.NumberOfLines`

#### Summary

Get or set the number of the beams in a beam system.

#### Remarks

The number must be positive.

### `M:Autodesk.Revit.DB.LayoutRuleFixedNumber.#ctor(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LayoutRuleFixedNumber.#ctor(System.Int32)`

#### Summary

Constructor of LayoutRuleFixedNumber.

#### Parameter `numberOfLines`

The value of numberOfLines must be positive.

#### Remarks

Create a LayoutRuleFixedNumber object with the number of the beams and this number must be positive.

### `T:Autodesk.Revit.DB.LayoutRuleFixedNumber`

Member kind: type
Symbol: `Autodesk.Revit.DB.LayoutRuleFixedNumber`

#### Summary

This class indicate the layout rule of a Beam System is Fixed-Number.

#### Remarks

To use this type of LayoutRule, only the number of the beams must be set.

### `P:Autodesk.Revit.DB.LayoutRuleFixedDistance.JustifyType`

Member kind: property
Symbol: `Autodesk.Revit.DB.LayoutRuleFixedDistance.JustifyType`

#### Summary

Get or set the type of justification.

#### Remarks

The justifyType passed in must be a valid object.

### `P:Autodesk.Revit.DB.LayoutRuleFixedDistance.Spacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.LayoutRuleFixedDistance.Spacing`

#### Summary

Get or set spacing of the Beam System.

#### Remarks

The value of spacing must be between 0 and 30000.

### `M:Autodesk.Revit.DB.LayoutRuleFixedDistance.#ctor(System.Double,Autodesk.Revit.DB.BeamSystemJustifyType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LayoutRuleFixedDistance.#ctor(System.Double,Autodesk.Revit.DB.BeamSystemJustifyType)`

#### Summary

Constructor of LayoutRuleFixedDistance. Create LayoutRuleFixedDistance with the values passed in.

#### Parameter `spacing`

The value of spacing must be between 0 and 30000.

#### Parameter `justifyType`

The type of the justification, it's corresponding to the items in the element properties dialog.

### `T:Autodesk.Revit.DB.LayoutRuleFixedDistance`

Member kind: type
Symbol: `Autodesk.Revit.DB.LayoutRuleFixedDistance`

#### Summary

This class indicate the layout rule of a Beam System is Fixed-Distance.

#### Remarks

To use this type of LayoutRule, the distance between the beams and the justify-type must be set.

### `T:Autodesk.Revit.DB.LayoutRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.LayoutRule`

#### Summary

The LayoutRule object is a base object for all type of layout rules for
Beam System within the Autodesk Revit API.

#### Remarks

This class just used as the base class of those concrete LayoutRule classes.

### `M:Autodesk.Revit.DB.BeamSystem.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Level,System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BeamSystem.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Level,System.Int32,System.Boolean)`

#### Summary

Creates a new BeamSystem with specified profile curves.

#### Parameter `document`

The document in which the new BeamSystem is created.

#### Parameter `profile`

The profile of the BeamSystem.

#### Parameter `level`

The level on which the BeamSystem is to be created.
The work-plane of the BeamSystem will be the sketch plane associated with the Level.
If there is no current sketch plane associated with the level yet, we will create a default one.

#### Parameter `curveIndexForDirection`

Index of the curve in the profile to be used as direction.
'0' means the direction to use the first curve in profile.
The curve from the profile to be used as direction must be a Line.

#### Parameter `is3d`

Whether the BeamSystem is 3D. If the BeamSystem is 3D, the sketchPlane must be a level, otherwise an exception will be thrown.

#### Returns

If successful, a new BeamSystem object will be returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input profile contains at least one helical curve and is not supported for this operation.
-or-
The curve index must be valid and the curve to be used as direction must be a Line.
-or-
The input level does not have associated plan view.
-or-
The plan view associated with the input level is not valid.
-or-
Can not get valid sketch plane from the input level.

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

### `M:Autodesk.Revit.DB.BeamSystem.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Level,Autodesk.Revit.DB.XYZ,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BeamSystem.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Level,Autodesk.Revit.DB.XYZ,System.Boolean)`

#### Summary

Creates a new BeamSystem with specified profile curves.

#### Parameter `document`

The document in which the new BeamSystem is created.

#### Parameter `profile`

The profile of the BeamSystem.

#### Parameter `level`

The level on which the BeamSystem is to be created.
The work-plane of the BeamSystem will be the sketch plane associated with the Level.
If there is no current sketch plane associated with the level yet, we will create a default one.

#### Parameter `direction`

The direction is the direction of the BeamSystem.

#### Parameter `is3d`

Whether the BeamSystem is 3D. If the BeamSystem is 3D, the sketchPlane must be a level, otherwise an exception will be thrown.

#### Returns

If successful, a new BeamSystem object will be returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input profile contains at least one helical curve and is not supported for this operation.
-or-
The input level does not have associated plan view.
-or-
The plan view associated with the input level is not valid.
-or-
Can not get valid sketch plane from the input level.

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

### `M:Autodesk.Revit.DB.BeamSystem.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.XYZ,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BeamSystem.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.XYZ,System.Boolean)`

#### Summary

Creates a new BeamSystem with specified profile curves.

#### Parameter `document`

The document in which the new BeamSystem is created.

#### Parameter `profile`

The profile of the BeamSystem.

#### Parameter `sketchPlane`

The work-plane for the BeamSystem.

#### Parameter `direction`

The direction is the direction of the BeamSystem.

#### Parameter `is3d`

Whether the BeamSystem is 3D. If the BeamSystem is 3D, the sketchPlane must be a level, otherwise an exception will be thrown.

#### Returns

If successful, a new BeamSystem object will be returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

SketchPlane is not valid for BeamSystem creation.
-or-
The input profile contains at least one helical curve and is not supported for this operation.
-or-
The profile curves must be in the sketch plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The BeamSystem is 3D, but the SketchPlane is not a level.

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

### `M:Autodesk.Revit.DB.BeamSystem.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.SketchPlane,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BeamSystem.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.SketchPlane,System.Int32)`

#### Summary

Creates a 2D BeamSystem with specified profile curves.

#### Parameter `document`

The document in which the new BeamSystem is created.

#### Parameter `profile`

The profile of the BeamSystem.

#### Parameter `sketchPlane`

The work-plane for the BeamSystem.

#### Parameter `curveIndexForDirection`

Index of the curve in the profile to be used as direction.
'0' means the default direction-to use the first curve in profile.
The curve from the profile to be used as direction must be a Line.

#### Returns

If successful, a new BeamSystem object will be returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

SketchPlane is not valid for BeamSystem creation.
-or-
The input profile contains at least one helical curve and is not supported for this operation.
-or-
The profile curves must be in the sketch plane.
-or-
The curve index must be valid and the curve to be used as direction must be a Line.

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

### `P:Autodesk.Revit.DB.BeamSystem.Direction`

Member kind: property
Symbol: `Autodesk.Revit.DB.BeamSystem.Direction`

#### Summary

The Direction of the BeamSystem.

### `P:Autodesk.Revit.DB.BeamSystem.LayoutRule`

Member kind: property
Symbol: `Autodesk.Revit.DB.BeamSystem.LayoutRule`

#### Summary

Retrieves or changes the LayoutRule of the BeamSystem.

### `P:Autodesk.Revit.DB.BeamSystem.Profile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BeamSystem.Profile`

#### Summary

Retrieve or set the profile of the BeamSystem.

### `P:Autodesk.Revit.DB.BeamSystem.BeamSystemType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BeamSystem.BeamSystemType`

#### Summary

Retrieves or changes the type of the BeamSystem.

### `P:Autodesk.Revit.DB.BeamSystem.BeamType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BeamSystem.BeamType`

#### Summary

Retrieves or changes the Beam Type of the BeamSystem.

### `P:Autodesk.Revit.DB.BeamSystem.Level`

Member kind: property
Symbol: `Autodesk.Revit.DB.BeamSystem.Level`

#### Summary

Get or change the level of the BeamSystem.
When the level is changed, the elevation is changed to make the
the BeamSystem remain the location.

### `P:Autodesk.Revit.DB.BeamSystem.Elevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.BeamSystem.Elevation`

#### Summary

Retrieves or changes the Elevation of the BeamSystem.

### `M:Autodesk.Revit.DB.BeamSystem.DropBeamSystem(Autodesk.Revit.DB.BeamSystem)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BeamSystem.DropBeamSystem(Autodesk.Revit.DB.BeamSystem)`

#### Summary

Drop beam system, it will disassociate all members from the beam system and delete the beam system.

#### Parameter `beamSystem`

The beam system to be deleted.

#### Since

2011

### `M:Autodesk.Revit.DB.BeamSystem.BeamBelongsTo(Autodesk.Revit.DB.FamilyInstance)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BeamSystem.BeamBelongsTo(Autodesk.Revit.DB.FamilyInstance)`

#### Summary

Find out the BeamSystem to which the beam belongs.

#### Returns

The BeamSystem.

#### Parameter `beam`

The beam want to ask.

### `M:Autodesk.Revit.DB.BeamSystem.GetBeamIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.BeamSystem.GetBeamIds`

#### Summary

Gets all the beams of the BeamSystem.

#### Returns

The beam Ids.

### `T:Autodesk.Revit.DB.BeamSystem`

Member kind: type
Symbol: `Autodesk.Revit.DB.BeamSystem`

#### Summary

An object that represents a BeamSystem within the Autodesk Revit project.

#### Remarks

This object is derived from the Element base object. It can be used to access properties
of a BeamSystem, such as elevation, level, etc. It also provides access to the beams (FamilyInstances) that are created by this BeamSystem.

### `P:Autodesk.Revit.DB.SpecTypeId.WireDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.WireDiameter`

#### Summary

Wire Diameter, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.WeightPerUnitLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.WeightPerUnitLength`

#### Summary

Weight per Unit Length, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Weight`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Weight`

#### Summary

Weight, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Wattage`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Wattage`

#### Summary

Wattage, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.WarpingConstant`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.WarpingConstant`

#### Summary

Warping Constant, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Volume`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Volume`

#### Summary

Volume, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.UnitWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.UnitWeight`

#### Summary

Unit Weight, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Time`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Time`

#### Summary

Time, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ThermalResistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ThermalResistance`

#### Summary

Thermal Resistance, in discipline Energy.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ThermalMass`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ThermalMass`

#### Summary

Thermal Mass, in discipline Energy.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ThermalGradientCoefficientForMoistureCapacity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ThermalGradientCoefficientForMoistureCapacity`

#### Summary

Thermal Gradient Coefficient for Moisture Capacity, in discipline Energy.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ThermalExpansionCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ThermalExpansionCoefficient`

#### Summary

Thermal Expansion Coefficient, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ThermalConductivity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ThermalConductivity`

#### Summary

Thermal Conductivity, in discipline Energy.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.SurfaceAreaPerUnitLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.SurfaceAreaPerUnitLength`

#### Summary

Surface Area per Unit Length, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.StructuralVelocity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.StructuralVelocity`

#### Summary

Velocity, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.StructuralFrequency`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.StructuralFrequency`

#### Summary

Frequency, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Stress`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Stress`

#### Summary

Stress, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.StationingInterval`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.StationingInterval`

#### Summary

Stationing Interval, in discipline Infrastructure.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Stationing`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Stationing`

#### Summary

Stationing, in discipline Infrastructure.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Speed`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Speed`

#### Summary

Speed, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.SpecificHeatOfVaporization`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.SpecificHeatOfVaporization`

#### Summary

Specific Heat of Vaporization, in discipline Energy.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.SpecificHeat`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.SpecificHeat`

#### Summary

Specific Heat, in discipline Energy.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Slope`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Slope`

#### Summary

Slope, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.SiteAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.SiteAngle`

#### Summary

Site Angle, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.SheetLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.SheetLength`

#### Summary

Sheet Length, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.SectionProperty`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.SectionProperty`

#### Summary

Section Property, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.SectionModulus`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.SectionModulus`

#### Summary

Section Modulus, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.SectionDimension`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.SectionDimension`

#### Summary

Section Dimension, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.SectionArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.SectionArea`

#### Summary

Section Area, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.RotationalPointSpringCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.RotationalPointSpringCoefficient`

#### Summary

Rotational Point Spring Coefficient, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.RotationalLineSpringCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.RotationalLineSpringCoefficient`

#### Summary

Rotational Line Spring Coefficient, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.RotationAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.RotationAngle`

#### Summary

Rotation Angle, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Rotation`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Rotation`

#### Summary

Rotation, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ReinforcementVolume`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ReinforcementVolume`

#### Summary

Reinforcement Volume, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ReinforcementSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ReinforcementSpacing`

#### Summary

Reinforcement Spacing, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ReinforcementLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ReinforcementLength`

#### Summary

Reinforcement Length, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ReinforcementCover`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ReinforcementCover`

#### Summary

Reinforcement Cover, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ReinforcementAreaPerUnitLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ReinforcementAreaPerUnitLength`

#### Summary

Reinforcement Area per Unit Length, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ReinforcementArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ReinforcementArea`

#### Summary

Reinforcement Area, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Pulsation`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Pulsation`

#### Summary

Pulsation, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PowerPerLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PowerPerLength`

#### Summary

Power per Length, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PowerPerFlow`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PowerPerFlow`

#### Summary

Power per Flow, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PointSpringCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PointSpringCoefficient`

#### Summary

Point Spring Coefficient, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipingVolume`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipingVolume`

#### Summary

Volume, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipingViscosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipingViscosity`

#### Summary

Dynamic Viscosity, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipingVelocity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipingVelocity`

#### Summary

Velocity, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipingTemperatureDifference`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipingTemperatureDifference`

#### Summary

Temperature Difference, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipingTemperature`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipingTemperature`

#### Summary

Temperature, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipingSlope`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipingSlope`

#### Summary

Slope, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipingRoughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipingRoughness`

#### Summary

Roughness, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipingPressure`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipingPressure`

#### Summary

Pressure, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipingMassPerTime`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipingMassPerTime`

#### Summary

Mass per Time, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipingMass`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipingMass`

#### Summary

Mass, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipingFriction`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipingFriction`

#### Summary

Friction, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipingDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipingDensity`

#### Summary

Density, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipeSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipeSize`

#### Summary

Pipe Size, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipeMassPerUnitLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipeMassPerUnitLength`

#### Summary

Mass per Unit Length, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipeInsulationThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipeInsulationThickness`

#### Summary

Pipe Insulation Thickness, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.PipeDimension`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.PipeDimension`

#### Summary

Pipe Dimension, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Permeability`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Permeability`

#### Summary

Permeability, in discipline Energy.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Period`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Period`

#### Summary

Period, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Number`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Number`

#### Summary

Number, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.MomentScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.MomentScale`

#### Summary

Moment Scale, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.MomentOfInertia`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.MomentOfInertia`

#### Summary

Moment of Inertia, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Moment`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Moment`

#### Summary

Moment, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.MassPerUnitLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.MassPerUnitLength`

#### Summary

Mass per Unit Length, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.MassPerUnitArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.MassPerUnitArea`

#### Summary

Mass per Unit Area, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.MassDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.MassDensity`

#### Summary

Mass Density, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Mass`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Mass`

#### Summary

Mass, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.LuminousIntensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.LuminousIntensity`

#### Summary

Luminous Intensity, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.LuminousFlux`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.LuminousFlux`

#### Summary

Luminous Flux, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Luminance`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Luminance`

#### Summary

Luminance, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.LinearMomentScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.LinearMomentScale`

#### Summary

Linear Moment Scale, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.LinearMoment`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.LinearMoment`

#### Summary

Linear Moment, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.LinearForceScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.LinearForceScale`

#### Summary

Linear Force Scale, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.LinearForce`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.LinearForce`

#### Summary

Linear Force, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.LineSpringCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.LineSpringCoefficient`

#### Summary

Line Spring Coefficient, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Length`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Length`

#### Summary

Length, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.IsothermalMoistureCapacity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.IsothermalMoistureCapacity`

#### Summary

Isothermal Moisture Capacity, in discipline Energy.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Illuminance`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Illuminance`

#### Summary

Illuminance, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HvacViscosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HvacViscosity`

#### Summary

Dynamic Viscosity, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HvacVelocity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HvacVelocity`

#### Summary

Velocity, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HvacTemperatureDifference`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HvacTemperatureDifference`

#### Summary

Temperature Difference, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HvacTemperature`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HvacTemperature`

#### Summary

Temperature, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HvacSlope`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HvacSlope`

#### Summary

Slope, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HvacRoughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HvacRoughness`

#### Summary

Roughness, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HvacPressure`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HvacPressure`

#### Summary

Pressure, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HvacPowerDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HvacPowerDensity`

#### Summary

Power Density, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HvacPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HvacPower`

#### Summary

Power, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HvacMassPerTime`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HvacMassPerTime`

#### Summary

Mass per Time, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HvacFriction`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HvacFriction`

#### Summary

Friction, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HvacEnergy`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HvacEnergy`

#### Summary

Energy, in discipline Energy.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HvacDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HvacDensity`

#### Summary

Density, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HeatingLoadDividedByVolume`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HeatingLoadDividedByVolume`

#### Summary

Heating Load divided by Volume, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HeatingLoadDividedByArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HeatingLoadDividedByArea`

#### Summary

Heating Load divided by Area, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HeatingLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HeatingLoad`

#### Summary

Heating Load, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HeatTransferCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HeatTransferCoefficient`

#### Summary

Coefficient of Heat Transfer, in discipline Energy.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HeatGain`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HeatGain`

#### Summary

Heat Gain, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.HeatCapacityPerArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.HeatCapacityPerArea`

#### Summary

Heat Capacity per Area, in discipline Energy.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ForceScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ForceScale`

#### Summary

Force Scale, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Force`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Force`

#### Summary

Force, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.FlowPerPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.FlowPerPower`

#### Summary

Flow per Power, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Flow`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Flow`

#### Summary

Flow, in discipline Piping.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Factor`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Factor`

#### Summary

Factor, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Energy`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Energy`

#### Summary

Energy, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ElectricalTemperatureDifference`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ElectricalTemperatureDifference`

#### Summary

Temperature Difference, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ElectricalTemperature`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ElectricalTemperature`

#### Summary

Temperature, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ElectricalResistivity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ElectricalResistivity`

#### Summary

Electrical Resistivity, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ElectricalPowerDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ElectricalPowerDensity`

#### Summary

Power Density, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ElectricalPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ElectricalPower`

#### Summary

Power, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ElectricalPotential`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ElectricalPotential`

#### Summary

Electrical Potential, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ElectricalFrequency`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ElectricalFrequency`

#### Summary

Frequency, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Efficacy`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Efficacy`

#### Summary

Efficacy, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.DuctSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.DuctSize`

#### Summary

Duct Size, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.DuctLiningThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.DuctLiningThickness`

#### Summary

Duct Lining Thickness, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.DuctInsulationThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.DuctInsulationThickness`

#### Summary

Duct Insulation Thickness, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Distance`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Distance`

#### Summary

Distance, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Displacement`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Displacement`

#### Summary

Displacement/Deflection, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Diffusivity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Diffusivity`

#### Summary

Diffusivity, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.DemandFactor`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.DemandFactor`

#### Summary

Demand Factor, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.DecimalSheetLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.DecimalSheetLength`

#### Summary

Decimal Sheet Length, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Current`

#### Summary

Current, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Currency`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Currency`

#### Summary

Currency, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.CrossSection`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.CrossSection`

#### Summary

Cross Section, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.CrackWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.CrackWidth`

#### Summary

Crack Width, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.CostRatePower`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.CostRatePower`

#### Summary

Cost Rate Power, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.CostRateEnergy`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.CostRateEnergy`

#### Summary

Cost Rate Energy, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.CostPerArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.CostPerArea`

#### Summary

Cost per Area, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.CoolingLoadDividedByVolume`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.CoolingLoadDividedByVolume`

#### Summary

Cooling Load divided by Volume, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.CoolingLoadDividedByArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.CoolingLoadDividedByArea`

#### Summary

Cooling Load divided by Area, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.CoolingLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.CoolingLoad`

#### Summary

Cooling Load, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ConduitSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ConduitSize`

#### Summary

Conduit Size, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ColorTemperature`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ColorTemperature`

#### Summary

Color Temperature, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.CableTraySize`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.CableTraySize`

#### Summary

Cable Tray Size, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.BarDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.BarDiameter`

#### Summary

Bar Diameter, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.AreaSpringCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.AreaSpringCoefficient`

#### Summary

Area Spring Coefficient, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.AreaForceScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.AreaForceScale`

#### Summary

Area Force Scale, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.AreaForce`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.AreaForce`

#### Summary

Area Force, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.AreaDividedByHeatingLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.AreaDividedByHeatingLoad`

#### Summary

Area divided by Heating Load, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.AreaDividedByCoolingLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.AreaDividedByCoolingLoad`

#### Summary

Area divided by Cooling Load, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Area`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Area`

#### Summary

Area, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ApparentPowerDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ApparentPowerDensity`

#### Summary

Apparent Power Density, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.ApparentPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.ApparentPower`

#### Summary

Apparent Power, in discipline Electrical.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.AngularSpeed`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.AngularSpeed`

#### Summary

Angular Speed, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Angle`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Angle`

#### Summary

Angle, in discipline Common.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.AirFlowDividedByVolume`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.AirFlowDividedByVolume`

#### Summary

Air Flow divided by Volume, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.AirFlowDividedByCoolingLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.AirFlowDividedByCoolingLoad`

#### Summary

Air Flow divided by Cooling Load, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.AirFlowDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.AirFlowDensity`

#### Summary

Air Flow Density, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.AirFlow`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.AirFlow`

#### Summary

Air Flow, in discipline HVAC.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Acceleration`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Acceleration`

#### Summary

Acceleration, in discipline Structural.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Custom`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Custom`

#### Summary

Unrecognized custom spec.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.String.Url`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.String.Url`

#### Summary

URL, in discipline Common.

### `P:Autodesk.Revit.DB.SpecTypeId.String.Text`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.String.Text`

#### Summary

Text, in discipline Common.

### `P:Autodesk.Revit.DB.SpecTypeId.String.MultilineText`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.String.MultilineText`

#### Summary

Multiline Text, in discipline Common.

### `T:Autodesk.Revit.DB.SpecTypeId.String`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpecTypeId.String`

#### Summary

This class contains constants identifying string specs.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Reference.Material`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Reference.Material`

#### Summary

Material, in discipline Common.

### `P:Autodesk.Revit.DB.SpecTypeId.Reference.LoadClassification`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Reference.LoadClassification`

#### Summary

Load Classification, in discipline Electrical.

### `P:Autodesk.Revit.DB.SpecTypeId.Reference.Image`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Reference.Image`

#### Summary

Image, in discipline Common.

### `P:Autodesk.Revit.DB.SpecTypeId.Reference.FillPattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Reference.FillPattern`

#### Summary

Fill Pattern, in discipline Common.

### `T:Autodesk.Revit.DB.SpecTypeId.Reference`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpecTypeId.Reference`

#### Summary

This class contains constants identifying reference specs.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Int.NumberOfPoles`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Int.NumberOfPoles`

#### Summary

Number of Poles, in discipline Electrical.

### `P:Autodesk.Revit.DB.SpecTypeId.Int.Integer`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Int.Integer`

#### Summary

Integer, in discipline Common.

### `T:Autodesk.Revit.DB.SpecTypeId.Int`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpecTypeId.Int`

#### Summary

This class contains constants identifying integer specs.

#### Since

2021

### `P:Autodesk.Revit.DB.SpecTypeId.Boolean.YesNo`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpecTypeId.Boolean.YesNo`

#### Summary

Yes/No, in discipline Common.

### `T:Autodesk.Revit.DB.SpecTypeId.Boolean`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpecTypeId.Boolean`

#### Summary

This class contains constants identifying Boolean specs.

#### Since

2021

### `T:Autodesk.Revit.DB.SpecTypeId`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpecTypeId`

#### Summary

This class contains constants identifying specs.

#### Since

2021

### `T:Autodesk.Revit.DB.AreaTagType`

Member kind: type
Symbol: `Autodesk.Revit.DB.AreaTagType`

#### Summary

An object that represents an Area Tag style.

### `P:Autodesk.Revit.DB.AreaTag.AreaTagType`

Member kind: property
Symbol: `Autodesk.Revit.DB.AreaTag.AreaTagType`

#### Summary

The tag type.

### `P:Autodesk.Revit.DB.AreaTag.Area`

Member kind: property
Symbol: `Autodesk.Revit.DB.AreaTag.Area`

#### Summary

The area that the tag is associated with.

#### Remarks

In rare cases, the tag may not be associated to an area. The property will
be `null` in these situations.

### `T:Autodesk.Revit.DB.AreaTag`

Member kind: type
Symbol: `Autodesk.Revit.DB.AreaTag`

#### Summary

Provides access to the area topology in Autodesk Revit.

#### Remarks

The areaTag object can be queried for its boundary for use in space planning tools.

### `P:Autodesk.Revit.DB.Structure.AreaReinforcementCurve.Curve`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcementCurve.Curve`

#### Summary

Returns the 3D curve forming part of the boundary of an Area Reinforcement element.

### `T:Autodesk.Revit.DB.Structure.AreaReinforcementCurve`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AreaReinforcementCurve`

#### Summary

An object that specifies the type of a floor in Autodesk Revit.

#### Remarks

The structural layers of the floor can be accessed via this object.

### `P:Autodesk.Revit.DB.CurveElement.LineStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveElement.LineStyle`

#### Summary

The line style of this curve element.

#### Remarks

The return of this property will be a `!:Autodesk::Revit::DB::GraphicsStyle` element.
These graphics styles should be associated to subcategories of the BuiltInCategory OST_Lines.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration failed. -- or --
Thrown when fail to get line style.

### `M:Autodesk.Revit.DB.CurveElement.SetSketchPlaneAndCurve(Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElement.SetSketchPlaneAndCurve(Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.Curve)`

#### Summary

Sets the sketch plane and the curve for this CurveElement.

#### Remarks

Unlike the setters of `P:Autodesk.Revit.DB.CurveElement.SketchPlane` and `P:Autodesk.Revit.DB.CurveElement.GeometryCurve` ,
this method will reset relationships between the two properties and with other elements.
To set a geometry curve which belongs to a sketch-based elements, use `P:Autodesk.Revit.DB.CurveElement.GeometryCurve`

#### Parameter `sketchPlane`

The new sketch plane.

#### Parameter `curve`

The new curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown if the argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the CurveElement is CurveByPoints or belongs to a Path3d element. -- or --
Thrown if the sketch plane is set on a DetailCurve. -- or --
Thrown if the sketch plane is not suitable. -- or --
Thrown if the CurveElement belongs to a sketch-based element. -- or --
Thrown if modifying the sketch plane is not allowed. -- or --
Thrown if the CurveElement cannot be moved out of its sketch plane. -- or --
Thrown if the input curve is of a type different from the current. -- or --
Thrown if the input curve is bound and the current is not or vice versa. -- or --
Thrown if the input curve is helical. -- or --
Thrown if the input curve lies outside of the SketchPlane of the current curve.

#### Since

2015

### `P:Autodesk.Revit.DB.CurveElement.SketchPlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveElement.SketchPlane`

#### Summary

The sketch plane the curve element lies in.

#### Remarks

The new sketch plane must be parallel to the existing sketch plane. Setting this property
is not permitted for detail curves because they must be placed only on view-specific planes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown if the argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the CurveElement is CurveByPoints or belongs to a Path3d element. -- or --
Thrown if the sketch plane is set on a DetailCurve. --or--
Thrown if the sketch plane is not parallel to the existing plane. -- or --
Thrown if the sketch plane is not suitable. -- or --
Thrown if the CurveElement belongs to a sketch-based element. -- or --
Thrown if modifying the sketch plane is not allowed. -- or --
Thrown if the CurveElement cannot be moved out of its sketch plane.

### `P:Autodesk.Revit.DB.CurveElement.CenterPointReference`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveElement.CenterPointReference`

#### Summary

Centerpoint reference of curve element. Curves such as circles, arcs, ellipses, and partial ellipses support this property.

#### Remarks

Use this reference property when using the API to dimension between centerpoints of curves.

### `M:Autodesk.Revit.DB.CurveElement.SetGeometryCurve(Autodesk.Revit.DB.Curve,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElement.SetGeometryCurve(Autodesk.Revit.DB.Curve,System.Boolean)`

#### Summary

Sets the geometry of the curve element.
After the curve geometry is set, other nearby curves may join to the new curve geometry.

#### Parameter `curve`

The new curve.

#### Parameter `overrideJoins`

An option to specify whether or not existing joins will affect setting the geometry of the CurveElement.
Setting this parameter to false is essentially the same as directly setting the `P:Autodesk.Revit.DB.CurveElement.GeometryCurve` property.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown if the argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the input curve is of a type different from the current. -- or --
Thrown if the input curve is bound and the current is not or vice versa. -- or --
Thrown if the input curve is helical. -- or --
Thrown if the input curve lies outside of the SketchPlane of the current curve and the CurveElement is not CurveByPoints.

#### Since

2015

### `P:Autodesk.Revit.DB.CurveElement.GeometryCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveElement.GeometryCurve`

#### Summary

Geometry curve of the curve element.

#### Remarks

When setting this property, any curves that this curve is currently joined to will affect the result -
the final geometry of this curve and of the joined curves may change.
To avoid the effect of existing joins, use `M:Autodesk.Revit.DB.CurveElement.SetGeometryCurve(Autodesk.Revit.DB.Curve,System.Boolean)` with true passed ot overrideJoins.
After the curve geometry is set, other nearby curves may join to the new curve geometry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown if the argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown if the argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the input curve is of a type different from the current. -- or --
Thrown if the input curve is bound and the current is not or vice versa. -- or --
Thrown if the input curve is helical. -- or --
Thrown if the input curve lies outside of the SketchPlane of the current curve and the CurveElement is not CurveByPoints.

### `P:Autodesk.Revit.DB.Leader.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Leader.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Leader.LeaderShape`

Member kind: property
Symbol: `Autodesk.Revit.DB.Leader.LeaderShape`

#### Summary

Geometric style of the leader

#### Remarks

While this property cannot be changed directly, it can change, with limitations,
as an effect of other changes to either the leader itself or the annotation element
the leader is associated with. For example, straight-line leaders have no elbow
points; but if an elbow point is set for a straight leader, which is allowed, it will
effectively change the leader's shape to a kinked line.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The leader is not currently owned by a valid element. A probable reason for that
could be if the element has been independently deleted, or the leader has never
been properly initialized.

#### Since

2016

### `P:Autodesk.Revit.DB.Leader.Anchor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Leader.Anchor`

#### Summary

Anchor point of the Leader

#### Remarks

Anchor is the leader's point that is attached to an annotation (a tag, note, etc.)
This is a read-only property, for the this point gets always computed based on various
properties of the annotation element.

#### Since

2016

### `P:Autodesk.Revit.DB.Leader.Elbow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Leader.Elbow`

#### Summary

Elbow point of the Leader.

#### Remarks

This is the mid-point of the leader and its purpose depends on the
shape of the leader. For arc-shaped leaders it defines the radius
of the arc. For a kinked leader it divides the leader line and
shoulder line.

Note that straight-line leaders do not have an actual elbow; however,
the value can still be obtained, although it will always equal the current
anchor point. Consequently, an elbow point can be set even on a straight-line
leader, but doing so will automatically change the leader's shape property.

It is allowed to set the Elbow point of a kinked leader to equal either
the end point or anchor point of the leader. Doing so will effectively
change the leader's shape to a straight line. However, the elbow of an arc
leader is never allowed to be placed on either the end or anchor point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: A valid point must not be father then 10 miles (approx. 16 km) from the origin.
-or-
When setting this property: An arc leader may not have its Elbow point placed at the current position of the leader's Anchor or End point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The leader is not currently owned by a valid element. A probable reason for that
could be if the element has been independently deleted, or the leader has never
been properly initialized.

### `P:Autodesk.Revit.DB.Leader.End`

Member kind: property
Symbol: `Autodesk.Revit.DB.Leader.End`

#### Summary

End point of the Leader.

#### Remarks

The End point is the leader's end that points to the object being annotated.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: A valid point must not be father then 10 miles (approx. 16 km) from the origin.
-or-
When setting this property: The leader's End point may not be placed at the current position of the Anchor or Elbow point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The leader is not currently owned by a valid element. A probable reason for that
could be if the element has been independently deleted, or the leader has never
been properly initialized.

### `T:Autodesk.Revit.DB.Leader`

Member kind: type
Symbol: `Autodesk.Revit.DB.Leader`

#### Summary

A leader object that can be attached to annotation elements such as text notes.

#### Remarks

For information on how to attach or get leaders to/from a text annotation
refer to corresponding methods of `!:Autodesk::Revit::DB::TextNote` class.

### `T:Autodesk.Revit.DB.LeaderShape`

Member kind: type
Symbol: `Autodesk.Revit.DB.LeaderShape`

#### Since

2016

#### Summary

Supported geometric shapes of annotation leaders.

#### Remarks

Although the `T:Autodesk.Revit.DB.Leader` class supports
all available shapes, not all types of leaders may have the option to
change its shape. For example, leaders of text annotations can be of
any shape, while leaders of level lines are never curved.

#### Since

2016

### `F:Autodesk.Revit.DB.LeaderShape.Arc`

Member kind: field
Symbol: `Autodesk.Revit.DB.LeaderShape.Arc`

#### Summary

An arc between between the end point and anchor point.
In this shape the elbow point controls the arc's radius.

### `F:Autodesk.Revit.DB.LeaderShape.Kinked`

Member kind: field
Symbol: `Autodesk.Revit.DB.LeaderShape.Kinked`

#### Summary

A kinked line with a shoulder defined by an elbow point.

### `F:Autodesk.Revit.DB.LeaderShape.Straight`

Member kind: field
Symbol: `Autodesk.Revit.DB.LeaderShape.Straight`

#### Summary

A single straight line between the end point and anchor point.

### `T:Autodesk.Revit.DB.AnnotationSymbolType`

Member kind: type
Symbol: `Autodesk.Revit.DB.AnnotationSymbolType`

#### Summary

An object that represents an annotation style.

### `M:Autodesk.Revit.DB.AnnotationSymbol.removeLeader`

Member kind: method
Symbol: `Autodesk.Revit.DB.AnnotationSymbol.removeLeader`

#### Summary

remove a leader of this annotation symbol.

### `M:Autodesk.Revit.DB.AnnotationSymbol.addLeader`

Member kind: method
Symbol: `Autodesk.Revit.DB.AnnotationSymbol.addLeader`

#### Summary

add a leader to this annotation symbol.

### `P:Autodesk.Revit.DB.AnnotationSymbol.AnnotationSymbolType`

Member kind: property
Symbol: `Autodesk.Revit.DB.AnnotationSymbol.AnnotationSymbolType`

#### Summary

The AnnotationSymbol style of this AnnotationSymbol.

#### Remarks

The AnnotationSymbolType property can be used to retrieve the kind of the symbol.
This property can also be used to change the type of an annotation by setting it to a different type.
All the annotation symbol types in the project can be found using
the Document.AnnotationSymbolTypes property.

### `M:Autodesk.Revit.DB.AnnotationSymbol.GetLeaders`

Member kind: method
Symbol: `Autodesk.Revit.DB.AnnotationSymbol.GetLeaders`

#### Summary

Returns a collection of leaders currently attached to the annotation.

#### Remarks

This method supersedes an older Leaders property which has been deprecated.

#### Since

2016

### `M:Autodesk.Revit.DB.AnnotationSymbol.duplicate`

Member kind: method
Symbol: `Autodesk.Revit.DB.AnnotationSymbol.duplicate`

#### Summary

Duplicate this annotation symbol.

#### Returns

Pointer to the new annotation symbol.

### `T:Autodesk.Revit.DB.AnnotationSymbol`

Member kind: type
Symbol: `Autodesk.Revit.DB.AnnotationSymbol`

#### Summary

This object represents a symbol of the Generic Annotation.

### `P:Autodesk.Revit.DB.GroupTypeId.WallCrossSectionDefinition`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.WallCrossSectionDefinition`

#### Summary

Cross-Section Definition.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Visibility`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Visibility`

#### Summary

Visibility.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.ViewExtents`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.ViewExtents`

#### Summary

Extents.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.ViewCamera`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.ViewCamera`

#### Summary

Camera.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Underlay`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Underlay`

#### Summary

Underlay.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.TrussFamilyVertWeb`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.TrussFamilyVertWeb`

#### Summary

Vertical Webs.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.TrussFamilyTopChord`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.TrussFamilyTopChord`

#### Summary

Top Chords.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.TrussFamilyDiagWeb`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.TrussFamilyDiagWeb`

#### Summary

Diagonal Webs.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.TrussFamilyBottomChord`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.TrussFamilyBottomChord`

#### Summary

Bottom Chords.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.TranslationIn`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.TranslationIn`

#### Summary

Translation in.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.ToposolidSubdivision`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.ToposolidSubdivision`

#### Summary

Sub-Division.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Title`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Title`

#### Summary

Title Text.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Text`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Text`

#### Summary

Text.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Termination`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Termination`

#### Summary

Terminations.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.SystemtypeRisedrop`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.SystemtypeRisedrop`

#### Summary

Rise / Drop.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Support`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Support`

#### Summary

Supports.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.StructuralSectionGeometry`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.StructuralSectionGeometry`

#### Summary

Structural Section Geometry.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.StructuralSectionDimensions`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.StructuralSectionDimensions`

#### Summary

Structural Section Dimensions.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.StructuralAnalysis`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.StructuralAnalysis`

#### Summary

Structural Analysis.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Structural`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Structural`

#### Summary

Structural.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.StairsWinders`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.StairsWinders`

#### Summary

Winders.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.StairsTreadsRisers`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.StairsTreadsRisers`

#### Summary

Threads/Risers.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.StairsSupports`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.StairsSupports`

#### Summary

Supports.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.StairsOpenEndConnection`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.StairsOpenEndConnection`

#### Summary

End Connection.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.StairsCalculatorRules`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.StairsCalculatorRules`

#### Summary

Calculation Rules.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.StairTreads`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.StairTreads`

#### Summary

Treads.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.StairStringers`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.StairStringers`

#### Summary

Stringers.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.StairRisers`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.StairRisers`

#### Summary

Risers.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.SplitProfileDimensions`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.SplitProfileDimensions`

#### Summary

Dimensions (linear units or % of thickness).

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.SlabShapeEdit`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.SlabShapeEdit`

#### Summary

Slab Shape Edit.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.SegmentsFittings`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.SegmentsFittings`

#### Summary

Segments and Fittings.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.SecondaryEnd`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.SecondaryEnd`

#### Summary

Secondary End.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.RouteAnalysis`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.RouteAnalysis`

#### Summary

Route Analysis.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.RotationAbout`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.RotationAbout`

#### Summary

Rotation about.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.ReleasesMemberForces`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.ReleasesMemberForces`

#### Summary

Releases / Member Forces.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Reference`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Reference`

#### Summary

Reference.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.RebarSystemLayers`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.RebarSystemLayers`

#### Summary

Layers.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.RebarArray`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.RebarArray`

#### Summary

Rebar Set.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.RailingSystemSegmentVGrid`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.RailingSystemSegmentVGrid`

#### Summary

V Grid.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.RailingSystemSegmentUGrid`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.RailingSystemSegmentUGrid`

#### Summary

U Grid.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.RailingSystemSegmentPosts`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.RailingSystemSegmentPosts`

#### Summary

Posts.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.RailingSystemSegmentPatternRepeat`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.RailingSystemSegmentPatternRepeat`

#### Summary

Pattern Repeat.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.RailingSystemSegmentPatternRemainder`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.RailingSystemSegmentPatternRemainder`

#### Summary

Pattern Remainder.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.RailingSystemSecondaryFamilyHandrails`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.RailingSystemSecondaryFamilyHandrails`

#### Summary

Handrail 2.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.RailingSystemFamilyTopRail`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.RailingSystemFamilyTopRail`

#### Summary

Top Rail.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.RailingSystemFamilySegmentPattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.RailingSystemFamilySegmentPattern`

#### Summary

Segment Pattern (default).

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.RailingSystemFamilyHandrails`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.RailingSystemFamilyHandrails`

#### Summary

Handrail 1.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Profilen2`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Profilen2`

#### Summary

Profile 2.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Profilen1`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Profilen1`

#### Summary

Profile 1.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Profile`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Profile`

#### Summary

Profile.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.PrimaryUnits`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.PrimaryUnits`

#### Summary

Primary Units.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.PrimaryEnd`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.PrimaryEnd`

#### Summary

Primary End.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Plumbing`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Plumbing`

#### Summary

Plumbing.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Phasing`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Phasing`

#### Summary

Phasing.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.PatternApplication`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.PatternApplication`

#### Summary

Pattern Application.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Pattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Pattern`

#### Summary

Pattern.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.OverallLegend`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.OverallLegend`

#### Summary

Overall Legend.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Nodes`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Nodes`

#### Summary

Nodes.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Moments`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Moments`

#### Summary

Moments.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.MechanicalLoads`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.MechanicalLoads`

#### Summary

Mechanical - Loads.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.MechanicalAirflow`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.MechanicalAirflow`

#### Summary

Mechanical - Flow.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Mechanical`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Mechanical`

#### Summary

Mechanical.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Materials`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Materials`

#### Summary

Materials and Finishes.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Lining`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Lining`

#### Summary

Lining.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.LightPhotometrics`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.LightPhotometrics`

#### Summary

Photometrics.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.LifeSafety`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.LifeSafety`

#### Summary

Life Safety.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Length`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Length`

#### Summary

Length.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Insulation`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Insulation`

#### Summary

Insulation.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Ifc`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Ifc`

#### Summary

IFC Parameters.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.IdentityData`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.IdentityData`

#### Summary

Identity Data.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.GreenBuilding`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.GreenBuilding`

#### Summary

Green Building Properties.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Graphics`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Graphics`

#### Summary

Graphics.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.GeometryPositioning`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.GeometryPositioning`

#### Summary

Geometric Position.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.GeoLocation`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.GeoLocation`

#### Summary

Geolocation.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.General`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.General`

#### Summary

General.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Forces`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Forces`

#### Summary

Forces.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Flexible`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Flexible`

#### Summary

Adaptive Component.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Fitting`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Fitting`

#### Summary

Fittings.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.FireProtection`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.FireProtection`

#### Summary

Fire Protection.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.FabricationProductData`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.FabricationProductData`

#### Summary

Fabrication Product Data.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisRoomSpaceData`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisRoomSpaceData`

#### Summary

Room/Space Data.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisDetailedModel`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisDetailedModel`

#### Summary

Detailed Model.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisDetailedAndConceptualModels`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisDetailedAndConceptualModels`

#### Summary

Essential.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisConceptualModel`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisConceptualModel`

#### Summary

Energy Analytical Model.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisBuildingData`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisBuildingData`

#### Summary

Building Data.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisBldgConsMtlThermalProps`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisBldgConsMtlThermalProps`

#### Summary

Material Thermal Properties.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisAdvanced`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.EnergyAnalysisAdvanced`

#### Summary

Advanced.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.EnergyAnalysis`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.EnergyAnalysis`

#### Summary

Energy Analysis.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.ElectricalLoads`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.ElectricalLoads`

#### Summary

Electrical - Loads.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.ElectricalLighting`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.ElectricalLighting`

#### Summary

Electrical - Lighting.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.ElectricalEngineering`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.ElectricalEngineering`

#### Summary

Electrical Engineering.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.ElectricalCircuiting`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.ElectricalCircuiting`

#### Summary

Electrical - Circuiting.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.ElectricalAnalysis`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.ElectricalAnalysis`

#### Summary

Electrical Analysis.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Electrical`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Electrical`

#### Summary

Electrical.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.DivisionGeometry`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.DivisionGeometry`

#### Summary

Division Geometry.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Display`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Display`

#### Summary

Display.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Data`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Data`

#### Summary

Data.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.CurtainMullionn2`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.CurtainMullionn2`

#### Summary

Grid 2 Mullions.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.CurtainMullionn1`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.CurtainMullionn1`

#### Summary

Grid 1 Mullions.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.CurtainMullionVert`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.CurtainMullionVert`

#### Summary

Vertical Mullions.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.CurtainMullionHoriz`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.CurtainMullionHoriz`

#### Summary

Horizontal Mullions.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.CurtainGridn2`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.CurtainGridn2`

#### Summary

Grid 2.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.CurtainGridn1`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.CurtainGridn1`

#### Summary

Grid 1.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.CurtainGridVert`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.CurtainGridVert`

#### Summary

Vertical Grid.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.CurtainGridV`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.CurtainGridV`

#### Summary

V Grid.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.CurtainGridU`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.CurtainGridU`

#### Summary

U Grid.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.CurtainGridHoriz`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.CurtainGridHoriz`

#### Summary

Horizontal Grid.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.CurtainGrid`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.CurtainGrid`

#### Summary

Grid.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.CouplerArray`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.CouplerArray`

#### Summary

Set.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.ContinuousrailEndTopExtension`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.ContinuousrailEndTopExtension`

#### Summary

Extension (End/Top).

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.ContinuousrailBeginBottomExtension`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.ContinuousrailBeginBottomExtension`

#### Summary

Extension (Beginning/Bottom).

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Construction`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Construction`

#### Summary

Construction.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Constraints`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Constraints`

#### Summary

Constraints.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.ConceptualEnergyDataBuildingServices`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.ConceptualEnergyDataBuildingServices`

#### Summary

Energy Model - Building Services.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.ConceptualEnergyData`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.ConceptualEnergyData`

#### Summary

Conceptual Energy Data.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Area`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Area`

#### Summary

Area.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.AnalyticalProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.AnalyticalProperties`

#### Summary

Analytical Properties.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.AnalyticalModel`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.AnalyticalModel`

#### Summary

Analytical Model.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.AnalyticalAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.AnalyticalAlignment`

#### Summary

Analytical Alignment.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.AnalysisResults`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.AnalysisResults`

#### Summary

Analysis Results.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.AlternateUnits`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.AlternateUnits`

#### Summary

Alternate Units.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.AdskModelProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.AdskModelProperties`

#### Summary

Model Properties.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupTypeId.Geometry`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupTypeId.Geometry`

#### Summary

Geometry.

#### Since

2024

### `T:Autodesk.Revit.DB.GroupTypeId`

Member kind: type
Symbol: `Autodesk.Revit.DB.GroupTypeId`

#### Summary

This class contains constants identifying parameter groups.

#### Since

2024

### `M:Autodesk.Revit.DB.MultiSegmentGrid.GetGridIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiSegmentGrid.GetGridIds`

#### Summary

Get the element ids of the Grids that make up this MultiSegmentGrid.

#### Returns

Element ids of Grids that make up this MultiSegmentGrid.

#### Since

2013

### `M:Autodesk.Revit.DB.MultiSegmentGrid.IsValidCurveLoop(Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiSegmentGrid.IsValidCurveLoop(Autodesk.Revit.DB.CurveLoop)`

#### Summary

Identifies whether the specified curve loop is valid for creation of a MultiSegmentGrid.

#### Parameter `curveLoop`

The curve loop.

#### Returns

True if the curve loop is an open curve loop consisting of lines and arcs, and false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.MultiSegmentGrid.IsValidSketchPlaneId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiSegmentGrid.IsValidSketchPlaneId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies whether provided element id corresponds to a SketchPlane that is valid for GridChain creation.

#### Parameter `document`

The document.

#### Parameter `elemId`

Element id.

#### Returns

True if elemId is the element id of a horizontal SketchPlane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.MultiSegmentGrid.AreGridsInSameMultiSegmentGrid(Autodesk.Revit.DB.Grid,Autodesk.Revit.DB.Grid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiSegmentGrid.AreGridsInSameMultiSegmentGrid(Autodesk.Revit.DB.Grid,Autodesk.Revit.DB.Grid)`

#### Summary

Determine whether two Grids are members of the same GridChain.

#### Parameter `grid1`

A Grid.

#### Parameter `grid2`

A Grid.

#### Returns

Returns true if both of the specified Grids are associated to the same MultiSegmentGrid,
i.e. getMultiSegementGridId returns the same valid element id for both Grids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.MultiSegmentGrid.GetMultiSegementGridId(Autodesk.Revit.DB.Grid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiSegmentGrid.GetMultiSegementGridId(Autodesk.Revit.DB.Grid)`

#### Summary

Retrieve the element id of the MultiSegmentGrid of which the specified Grid is a member.

#### Parameter `grid`

A Grid.

#### Returns

The element id of the associated GridChain. If the Grid is not associated to a GridChain,
this will return invalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.MultiSegmentGrid.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiSegmentGrid.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.ElementId)`

#### Summary

Create a MultiSegmentGrid element from the specified curve loop.

#### Remarks

For each curve in the curve loop, a corresponding Grid will be created.

#### Parameter `document`

The document in which to create the MultiSegmentGrid.

#### Parameter `typeId`

Element id of a GridType element.

#### Parameter `curveLoop`

An open curve loop consisting of lines and arcs.

#### Parameter `sketchPlaneId`

Element id of a SketchPlane for the curves elements that will be created from the curveLoop.

#### Returns

The element id of the new MultiSegmentGrid element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id should refer to a valid horizontal SketchPlane.
-or-
The element id should refer to a GridType element.
-or-
The curve loop should be an open loop consisting of lines and arcs.

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

2013

### `P:Autodesk.Revit.DB.MultiSegmentGrid.Text`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiSegmentGrid.Text`

#### Summary

name shared by grids in this MultiSegmentGrid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.MultiSegmentGrid`

Member kind: type
Symbol: `Autodesk.Revit.DB.MultiSegmentGrid`

#### Summary

This element acts as a multi-segmented Grid. The individual grids associated to
the MultiSegmentGrid behave as a single unit and all share the same text. They inherit
their type (GridType) from the MultiSegmentGrid.

#### Since

2013

### `M:Autodesk.Revit.DB.Grid.GetExtents`

Member kind: method
Symbol: `Autodesk.Revit.DB.Grid.GetExtents`

#### Summary

Gets the extents of the grid in the model.

#### Returns

The extents are the 3D bounding box surrounding the grid. The Z coordinates of the box are used by
Revit to determine if the grid should be displayed in a corresponding view plan (if the grid is linear). The
extents are not used for arc grids.

#### Since

2013

### `M:Autodesk.Revit.DB.Grid.SetVerticalExtents(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Grid.SetVerticalExtents(System.Double,System.Double)`

#### Summary

Adjusts the grid to extend through only the vertical range between bottom and top.

#### Parameter `bottom`

The bottom range of the grid extents. It must be a valid number and below the top range.

#### Parameter `top`

The top range of the grid extents. It must be a valid number and above the bottom range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The bottom and top ranges are reversed for the extents.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for bottom must be no more than 30000 feet in absolute value.
-or-
The given value for top must be no more than 30000 feet in absolute value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Couldn't change the extents of the grid.

#### Since

2016

### `M:Autodesk.Revit.DB.Grid.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Arc)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Grid.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Arc)`

#### Summary

Creates a new radial grid line.

#### Remarks

The arc should be on a horizontal plane.

#### Parameter `document`

The document in which the new instance is created.

#### Parameter `arc`

An arc object that represents the location of the new grid line.

#### Returns

The newly created grid line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The input arc is not on horizontal plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Grid.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Line)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Grid.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Line)`

#### Summary

Creates a new grid line.

#### Remarks

The line should be on a horizontal plane.

#### Parameter `document`

The document in which the new instance is created.

#### Parameter `line`

A line which represents the location of the grid line.

#### Returns

The newly created grid line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The input line is not on horizontal plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.Grid.IsCurved`

Member kind: property
Symbol: `Autodesk.Revit.DB.Grid.IsCurved`

#### Summary

Identifies if the grid line is curved or straight.

#### Remarks

A value of True is returned if the grid line is an arc or False if the grid line is
straight. Use the Curve property to retrieve an object that represents the geometry of the grid
line.

### `P:Autodesk.Revit.DB.Grid.Curve`

Member kind: property
Symbol: `Autodesk.Revit.DB.Grid.Curve`

#### Summary

Retrieves an object that represents the geometry of the grid line.

#### Remarks

The geometry can either be an arc or a curve. The IsCurved property can be used to determine
this.

### `T:Autodesk.Revit.DB.Grid`

Member kind: type
Symbol: `Autodesk.Revit.DB.Grid`

#### Summary

Represents a single grid line within Autodesk Revit.

#### Remarks

A Grid is a DatumPlane, so it is actually a three dimensional surface. It can be either a plane parallel to
the project z-axis, or else a cylinder whose axis is parallel to the project z-xis. `!:Autodesk::Revit::DatumPlane`

### `T:Autodesk.Revit.DB.GridType`

Member kind: type
Symbol: `Autodesk.Revit.DB.GridType`

#### Summary

An object that represents a grid type.

### `P:Autodesk.Revit.DB.Visual.Gradient.TextureVRepeat`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.TextureVRepeat`

#### Summary

The property labeled "V Repeat" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.TextureURepeat`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.TextureURepeat`

#### Summary

The property labeled "U Repeat" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.TextureScaleLock`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.TextureScaleLock`

#### Summary

The property labeled "Scale Lock" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.TextureRealWorldScaleY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.TextureRealWorldScaleY`

#### Summary

The property labeled "Size Y" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyDistance" with a minimum of "0.01".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.TextureRealWorldScaleX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.TextureRealWorldScaleX`

#### Summary

The property labeled "Size X" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyDistance" with a minimum of "0.01".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.TextureWAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.TextureWAngle`

#### Summary

The property labeled "Angle" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 360".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.TextureOffsetLock`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.TextureOffsetLock`

#### Summary

The property labeled "Offset Lock" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.TextureRealWorldOffsetY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.TextureRealWorldOffsetY`

#### Summary

The property labeled "Offset Y" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.TextureRealWorldOffsetX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.TextureRealWorldOffsetX`

#### Summary

The property labeled "Offset X" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.TextureLinkTextureTransforms`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.TextureLinkTextureTransforms`

#### Summary

The property labeled "Link Transforms" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.GradientType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.GradientType`

#### Summary

The property labeled "Gradient Type" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "GradientType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.GradientPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.GradientPosition`

#### Summary

The property labeled "Position" from the "Gradient" schema.

#### Remarks

This property is a "AssetPropertyList" of type "AssetPropertyDouble".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.GradientNoiseSmooth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.GradientNoiseSmooth`

#### Summary

The property labeled "Smooth" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.GradientNoiseSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.GradientNoiseSize`

#### Summary

The property labeled "Size" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1000000000".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.GradientNoisePhase`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.GradientNoisePhase`

#### Summary

The property labeled "Phase" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1000000000".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.GradientNoiseLow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.GradientNoiseLow`

#### Summary

The property labeled "Low" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.GradientNoiseLevels`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.GradientNoiseLevels`

#### Summary

The property labeled "Levels" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "1, 10".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.GradientNoiseHigh`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.GradientNoiseHigh`

#### Summary

The property labeled "High" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.GradientNoiseAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.GradientNoiseAmount`

#### Summary

The property labeled "Amount" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.GradientNoise`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.GradientNoise`

#### Summary

The property labeled "Noise Type" from the "Gradient" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "GradientNoiseType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.GradientInterpolation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.GradientInterpolation`

#### Summary

The property labeled "Interpolation" from the "Gradient" schema.

#### Remarks

This property is a "AssetPropertyList" of type "AssetPropertyInteger".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Gradient.GradientColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Gradient.GradientColor`

#### Summary

The property labeled "Color" from the "Gradient" schema.

#### Remarks

This property is a "AssetPropertyList" of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Gradient`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Gradient`

#### Summary

A static class that provides access to the property names that appear in the Gradient visual asset schema.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Glazing.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Glazing.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "Glazing" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Glazing.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Glazing.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "Glazing" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Glazing.GlazingNoLevels`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Glazing.GlazingNoLevels`

#### Summary

The property labeled "Sheets of Glass" from the "Glazing" schema.

#### Remarks

This property is of type "AssetPropertyInteger" within the range of "1, 6".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Glazing.GlazingReflectance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Glazing.GlazingReflectance`

#### Summary

The property labeled "Reflectance" from the "Glazing" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Glazing.GlazingColorByObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Glazing.GlazingColorByObject`

#### Summary

The property labeled "Color By Object" from the "Glazing" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Glazing.GlazingTransmittanceMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Glazing.GlazingTransmittanceMap`

#### Summary

The property labeled "Custom Color" from the "Glazing" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Glazing.GlazingTransmittanceColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Glazing.GlazingTransmittanceColor`

#### Summary

The property labeled "Color" from the "Glazing" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "GlazingTransmittanceColorType".

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Glazing`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Glazing`

#### Summary

A static class that provides access to the property names that appear in the Glazing visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.ForgeDM.CloudProject.GetFolders`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudProject.GetFolders`

#### Summary

Gets all top-level folders that are available to current login user from this Project.

#### Returns

The list of Folders.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

Could be any reasons related to network.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the specified cloud project.

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudProject.GetHub`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudProject.GetHub`

#### Summary

Gets ForgeDM Hub of this Project.

#### Since

2022

### `P:Autodesk.Revit.DB.ForgeDM.CloudProject.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudProject.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ForgeDM.CloudProject.GUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudProject.GUID`

#### Summary

RCM Project GUID of this Project.

#### Since

2022

### `P:Autodesk.Revit.DB.ForgeDM.CloudProject.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudProject.Name`

#### Summary

Name of this Project.

#### Since

2022

### `P:Autodesk.Revit.DB.ForgeDM.CloudProject.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudProject.Id`

#### Summary

Identifier of this Project.

#### Remarks

Forge Project id = "b." + BIM 360 Docs or Autodesk Docs Project id. For example, b.b0524685-6a33-4004-9537-0e0535c58624

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudProject.#ctor(Autodesk.Revit.DB.ForgeDM.CloudHub,System.String,System.String,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudProject.#ctor(Autodesk.Revit.DB.ForgeDM.CloudHub,System.String,System.String,System.Guid)`

#### Summary

Constructor for CloudProject.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudProject.#ctor(System.String,System.String,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudProject.#ctor(System.String,System.String,System.Guid)`

#### Summary

Constructor for CloudProject.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudProject.#ctor(Autodesk.Revit.DB.ForgeDM.CloudProject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudProject.#ctor(Autodesk.Revit.DB.ForgeDM.CloudProject)`

#### Summary

For communication between Revit and Collaborate add-in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.ForgeDM.CloudProject`

Member kind: type
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudProject`

#### Summary

This class represents a Project from ForgeDM

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudHub.GetProjects`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudHub.GetProjects`

#### Summary

Gets all projects that are available to current login user from this Hub.

#### Remarks

The empty projects or the projects which are associated with the current Revit version will be returned.

#### Returns

The list of Projects. Returns an empty list if there is no project in this Hub
or the user doesn't have permission to access to the projects in this Hub.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

Could be any reasons related to network.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the specified cloud hub.

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudHub.GetAllHubs`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudHub.GetAllHubs`

#### Summary

Gets all hubs (of the supported regions) that are available to current login user.

#### Returns

The list of Hubs. Returns an empty list if the current user doesn't have any hub.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

Could be any reasons related to network.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Since

2022

### `P:Autodesk.Revit.DB.ForgeDM.CloudHub.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudHub.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ForgeDM.CloudHub.Region`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudHub.Region`

#### Summary

Region of this Hub.
Please see the reference values, like `!:Autodesk::Revit::DB::ModelPathUtils::CloudRegionUS`
and `!:Autodesk::Revit::DB::ModelPathUtils::CloudRegionEMEA` ,
and the new regions from release note.

#### Since

2022

### `P:Autodesk.Revit.DB.ForgeDM.CloudHub.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudHub.Name`

#### Summary

Name of this Hub.

#### Since

2022

### `P:Autodesk.Revit.DB.ForgeDM.CloudHub.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudHub.Id`

#### Summary

Identifier of this Hub.

#### Remarks

Forge Hub id = "b." + BIM 360 Docs or Autodesk Docs Account id. For example, b.d12cb5fa-96cd-483b-8acb-46ef9a4b74d7

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudHub.#ctor(System.String,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudHub.#ctor(System.String,System.String,System.String)`

#### Summary

Constructor for CloudHub.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudHub.#ctor(Autodesk.Revit.DB.ForgeDM.CloudHub)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudHub.#ctor(Autodesk.Revit.DB.ForgeDM.CloudHub)`

#### Summary

For communication between Revit and Collaborate add-in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.ForgeDM.CloudHub`

Member kind: type
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudHub`

#### Summary

This class represents a Hub from ForgeDM.

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudModel.GetModelPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudModel.GetModelPath`

#### Summary

Gets ModelPath of this model.

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudModel.GetHub`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudModel.GetHub`

#### Summary

Gets ForgeDM hub of this model.

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudModel.GetProject`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudModel.GetProject`

#### Summary

Gets ForgeDM project of this model.

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudModel.GetFolder`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudModel.GetFolder`

#### Summary

Gets ForgeDM folder of this model.

#### Since

2022

### `P:Autodesk.Revit.DB.ForgeDM.CloudModel.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudModel.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ForgeDM.CloudModel.IsWorkshared`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudModel.IsWorkshared`

#### Summary

Indicates if the model is workshared or not.

#### Since

2022

### `P:Autodesk.Revit.DB.ForgeDM.CloudModel.GUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudModel.GUID`

#### Summary

Revit cloud model GUID.

#### Since

2022

### `P:Autodesk.Revit.DB.ForgeDM.CloudModel.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudModel.Name`

#### Summary

Model name.

#### Since

2022

### `P:Autodesk.Revit.DB.ForgeDM.CloudModel.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudModel.Id`

#### Summary

Model identifier.

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudModel.#ctor(Autodesk.Revit.DB.ForgeDM.CloudFolder,System.String,System.String,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudModel.#ctor(Autodesk.Revit.DB.ForgeDM.CloudFolder,System.String,System.String,System.Guid)`

#### Summary

Default constructor for CloudModel.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudModel.#ctor(System.String,System.String,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudModel.#ctor(System.String,System.String,System.Guid)`

#### Summary

Default constructor for CloudModel.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudModel.#ctor(Autodesk.Revit.DB.ForgeDM.CloudModel)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudModel.#ctor(Autodesk.Revit.DB.ForgeDM.CloudModel)`

#### Summary

For communication between Revit and Collaborate add-in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.ForgeDM.CloudModel`

Member kind: type
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudModel`

#### Summary

Revit Cloud Model from Forge Data Management/BIM 360 Docs or Autodesk Docs.

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudFolder.GetModels`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudFolder.GetModels`

#### Summary

Gets all Revit Cloud Models that are available to current login user from this Folder.

#### Returns

The list of Revit Cloud Models.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

Could be any reasons related to network.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the specified cloud folder.

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudFolder.GetFolders`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudFolder.GetFolders`

#### Summary

Gets all folders that are available to current login user from this Folder.

#### Returns

The list of Folders.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

Could be any reasons related to network.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the specified cloud folder.

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudFolder.GetHub`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudFolder.GetHub`

#### Summary

Gets ForgeDM Hub of this Folder.

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudFolder.GetProject`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudFolder.GetProject`

#### Summary

Gets ForgeDM Project of this Folder.

#### Since

2022

### `P:Autodesk.Revit.DB.ForgeDM.CloudFolder.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudFolder.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ForgeDM.CloudFolder.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudFolder.Name`

#### Summary

Name of this Folder.

#### Since

2022

### `P:Autodesk.Revit.DB.ForgeDM.CloudFolder.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudFolder.Id`

#### Summary

Identifier of this Folder.

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudFolder.#ctor(Autodesk.Revit.DB.ForgeDM.CloudProject,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudFolder.#ctor(Autodesk.Revit.DB.ForgeDM.CloudProject,System.String,System.String)`

#### Summary

Constructor for CloudFolder.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudFolder.#ctor(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudFolder.#ctor(System.String,System.String)`

#### Summary

Constructor for CloudFolder.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ForgeDM.CloudFolder.#ctor(Autodesk.Revit.DB.ForgeDM.CloudFolder)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudFolder.#ctor(Autodesk.Revit.DB.ForgeDM.CloudFolder)`

#### Summary

For communication between Revit and Collaborate add-in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.ForgeDM.CloudFolder`

Member kind: type
Symbol: `Autodesk.Revit.DB.ForgeDM.CloudFolder`

#### Summary

This class represents a Folder from ForgeDM (Data Management, see https://developer.autodesk.com/en/docs/data/v2/overview/).

#### Since

2022

### `P:Autodesk.Revit.DB.VertexPair.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.VertexPair.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.VertexPair.Second`

Member kind: property
Symbol: `Autodesk.Revit.DB.VertexPair.Second`

#### Summary

Identifies the second index of VertexPair.

#### Since

2012

### `P:Autodesk.Revit.DB.VertexPair.First`

Member kind: property
Symbol: `Autodesk.Revit.DB.VertexPair.First`

#### Summary

Identifies the first index of VertexPair.

#### Since

2012

### `M:Autodesk.Revit.DB.VertexPair.#ctor(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.VertexPair.#ctor(System.Int32,System.Int32)`

#### Summary

Constructs a new VertexPair from a pair of indices in the curve loops.

#### Since

2012

### `T:Autodesk.Revit.DB.VertexPair`

Member kind: type
Symbol: `Autodesk.Revit.DB.VertexPair`

#### Summary

Indices of a pair of vertices in two CurveLoops(one vertex in each loop).

#### Remarks

A vertex is specified by the index in the CurveLoop of the curve having that vertex as its start point. Indexes start at 0.

#### Since

2012

### `M:Autodesk.Revit.DB.GeometryAugmentationRegistry.ValidateElement(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryAugmentationRegistry.ValidateElement(Autodesk.Revit.DB.Element)`

#### Summary

Checks if an element can be used with a geometry augmentation server.

#### Parameter `targetElement`

The target element.

#### Returns

True is the element can be used with a geometry augmentation server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.GeometryAugmentationRegistry.ValidateServerCanBeDetached(Autodesk.Revit.DB.Element,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryAugmentationRegistry.ValidateServerCanBeDetached(Autodesk.Revit.DB.Element,System.Guid)`

#### Summary

Checks if the element has an geometry augmentation server attached.

#### Parameter `targetElement`

The target element where the server is attached.

#### Parameter `drawingServerGUID`

Geometry server GUID.

#### Returns

True if the element has a geometry augmentation server attached. False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.GeometryAugmentationRegistry.ValidateServer(Autodesk.Revit.DB.Element,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryAugmentationRegistry.ValidateServer(Autodesk.Revit.DB.Element,System.Guid)`

#### Summary

Checks if the element supports geometry servers and if the geometry server is valid.

#### Parameter `targetElement`

The target element where the server will be attached.

#### Parameter `drawingServerGUID`

Geometry server GUID.

#### Returns

True if the element supports geometry servers and if the geometry server is valid. False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.GeometryAugmentationRegistry.UnregisterFromServer(Autodesk.Revit.DB.Element,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryAugmentationRegistry.UnregisterFromServer(Autodesk.Revit.DB.Element,System.Guid)`

#### Summary

Removes the association between a drawing server and this element.

#### Parameter `targetElement`

The target element where the server is attached.

#### Parameter `drawingServerGUID`

Geometry server GUID.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Geometry augmentation servers can't be used in family owned documents.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The element does not have a geometry augmentation server attached.

#### Since

2024

### `M:Autodesk.Revit.DB.GeometryAugmentationRegistry.RegisterToServer(Autodesk.Revit.DB.Element,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryAugmentationRegistry.RegisterToServer(Autodesk.Revit.DB.Element,System.Guid)`

#### Summary

Associates this element with a drawing server that will be able to add extra geometry for this element

#### Remarks

For view-specific geometry server providers, see `!:Autodesk::Revit::DB::IGeometryAugmentationServer`

#### Parameter `targetElement`

The target element where the server will be attached

#### Parameter `drawingServerGUID`

Geometry server GUID.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Geometry augmentation servers can't be used in family owned documents.
-or-
The target element can't be used with the geometry augmentation system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The GUID provided does not point to any geometry server or the element does not support geometry servers.

#### Since

2024

### `T:Autodesk.Revit.DB.GeometryAugmentationRegistry`

Member kind: type
Symbol: `Autodesk.Revit.DB.GeometryAugmentationRegistry`

#### Summary

A static class that contains methods for interacting with GeometryAugmentation servers.

This is part of the Geometry Augmentation system implementation.
This class was designed to be public_api but in the end it was decided to be moved to public_api_internal
because an element enhanced with this system created by a third party can't be computed when publish the
rvt file into the cloud.
The computation of the value and graphics is done in generateGrep and if the addon the defines the server is not
present it the cell will be empty.
Decision can be found here:
https://autodesk.slack.com/archives/C02KQUH4519/p1673018478447789
https://wiki.autodesk.com/display/aeceng/Public+availability+of+the+Custom+Graphics+API#decision_framework-1761429744

#### Since

2024

### `T:Autodesk.Revit.DB.Structure.ZJustification`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ZJustification`

#### Summary

The justification of the framing element in Z.

#### Since

2014

#### Since

2014

### `F:Autodesk.Revit.DB.Structure.ZJustification.Bottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ZJustification.Bottom`

#### Summary

Justification to the bottom of the element.

### `F:Autodesk.Revit.DB.Structure.ZJustification.Origin`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ZJustification.Origin`

#### Summary

Justification to the origin of the element.

### `F:Autodesk.Revit.DB.Structure.ZJustification.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ZJustification.Center`

#### Summary

Justification to the geometrical center of element.

### `F:Autodesk.Revit.DB.Structure.ZJustification.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ZJustification.Top`

#### Summary

Justification to the top of the element.

### `T:Autodesk.Revit.DB.Structure.YJustification`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.YJustification`

#### Summary

The justification of the framing element in Y.

#### Since

2014

#### Since

2014

### `F:Autodesk.Revit.DB.Structure.YJustification.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.YJustification.Right`

#### Summary

Justification to the right of the element.

### `F:Autodesk.Revit.DB.Structure.YJustification.Origin`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.YJustification.Origin`

#### Summary

Justification to the origin of the element.

### `F:Autodesk.Revit.DB.Structure.YJustification.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.YJustification.Center`

#### Summary

Justification to the geometrical center of the element.

### `F:Autodesk.Revit.DB.Structure.YJustification.Left`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.YJustification.Left`

#### Summary

Justification to the left of the element.

### `T:Autodesk.Revit.DB.Structure.YZJustificationOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.YZJustificationOption`

#### Summary

The option for whether a framing element has independent or uniform justification on its ends.

#### Since

2014

#### Since

2014

### `F:Autodesk.Revit.DB.Structure.YZJustificationOption.Independent`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.YZJustificationOption.Independent`

#### Summary

Independent justification settings applied to the element ends.

### `F:Autodesk.Revit.DB.Structure.YZJustificationOption.Uniform`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.YZJustificationOption.Uniform`

#### Summary

Uniform justification settings applied to the element ends.

### `P:Autodesk.Revit.DB.ProjectPosition.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectPosition.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ProjectPosition.Angle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectPosition.Angle`

#### Summary

Angle from True North.

#### Remarks

This is the angle difference between project north and true north measured in
radians. It can have a value from -PI to PI.
If the parameter value is outside that range, it
will be shifted by 2*PI until it falls into range.

### `P:Autodesk.Revit.DB.ProjectPosition.Elevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectPosition.Elevation`

#### Summary

Elevation above ground level.

#### Remarks

Negative values are allowed. Measured in decimal feet.

### `P:Autodesk.Revit.DB.ProjectPosition.NorthSouth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectPosition.NorthSouth`

#### Summary

North/South offset

#### Remarks

The offset of the project location from the site location in
the north/south direction. Measured in decimal feet.

### `P:Autodesk.Revit.DB.ProjectPosition.EastWest`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectPosition.EastWest`

#### Summary

East/West offset.

#### Remarks

The offset of the project location from the site location in
the east/west direction. Measured in decimal feet.

### `M:Autodesk.Revit.DB.ProjectPosition.#ctor(System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectPosition.#ctor(System.Double,System.Double,System.Double,System.Double)`

#### Summary

Construct a new ProjectPosition with the specified
East/West offset, North/South offset, elevation offset,
and angle of rotation.

#### Remarks

The angle parameter must be in the range of -PI to PI.
If the parameter value is outside that range, it
will be shifted by 2*PI until it falls into range.

#### Parameter `ew`

East/West offset

#### Parameter `ns`

North/South offset

#### Parameter `elevation`

Elevation offset

#### Parameter `angle`

Rotation from true north, in radians

### `M:Autodesk.Revit.DB.ProjectPosition.#ctor(Autodesk.Revit.DB.ProjectPosition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectPosition.#ctor(Autodesk.Revit.DB.ProjectPosition)`

#### Summary

Creates a copy of the ProjectPosition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.ProjectPosition`

Member kind: type
Symbol: `Autodesk.Revit.DB.ProjectPosition`

#### Summary

ProjectPosition is a class used to represent a geographical offset and rotation. It can be used to represent the
position of a project.

### `M:Autodesk.Revit.DB.SiteLocation.SaveToLinkType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SiteLocation.SaveToLinkType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String,System.String)`

#### Summary

Save the site into specific LinkType, if the type has one already, it will be updated

#### Parameter `document`

The document of the LinkType.

#### Parameter `linkTypeId`

The LinkType to be saved into.

#### Parameter `geoSiteName`

The site name to save.

#### Parameter `geoCoordinateSystem`

The coordinate system name to save.

#### Returns

The saved site.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The element linkTypeId does not exist in the document
-or-
geoSiteName cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".

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

2019

### `M:Autodesk.Revit.DB.SiteLocation.GetCoordinateDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.SiteLocation.GetCoordinateDescription`

#### Summary

Get the description of Coordinates

#### Since

2018

### `M:Autodesk.Revit.DB.SiteLocation.DownloadWeatherFile(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SiteLocation.DownloadWeatherFile(System.String)`

#### Summary

Downloads the weather file at this site location, used for systems energy analysis.

#### Parameter `weatherFolder`

The folder location where the downloaded weather file will be stored.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

No weather station is within 500 nautical miles of this site location.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

Fail to download the weather file.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Unable to access the weather service. Try again later.

#### Since

2020.1

### `M:Autodesk.Revit.DB.SiteLocation.IsCompatibleWith(Autodesk.Revit.DB.SiteLocation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SiteLocation.IsCompatibleWith(Autodesk.Revit.DB.SiteLocation)`

#### Summary

Checks whether the geographic coordinate system of this site is compatible with the given site .
True if he geographic coordinate system of this site is compatible with the given site, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.SiteLocation.SetGeoCoordinateSystem(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SiteLocation.SetGeoCoordinateSystem(System.String)`

#### Summary

Set the geographic coordinate system for this site. Similar to acquire coordinate system from a link in the UI.

#### Remarks

The ID, WKT or Autodesk coordinate system xml representation of the coordinate reference system definition.
The xml representation is the same format get via RealDWG's API - AcDbGeoData::coordinateSystem.
Optionally, the string can be prefixed by the ID's namespace and a colon (:) where the following are supported: ADSK, EPSG.
If no namespace has been specified, the ID is assumed to be a default Autodesk coordinate system identifier.
If no definition exists with such a code and if it consists of numbers only, the ID string is considered an EPSG code.

Valid examples are:
LL84 > Autodesk identifier (default)ADSK:LL84 > Autodesk identifierEPSG:4326 > EPSG identifier4326 > EPSG identifierGEOGCS["WGS 84", DATUM["WGS_1984", SPHEROID[...]]] > WKT

#### Parameter `coordSystem`

The coordinate system to set for the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

coordSystem is an empty string or contains only whitespace.
-or-
The coordinate system is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InternalException`

Fail to update coordinate system.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The site location does not come from the project.

#### Since

2019.2

### `P:Autodesk.Revit.DB.SiteLocation.GeoCoordinateSystemDefinition`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteLocation.GeoCoordinateSystemDefinition`

#### Summary

The XML string which describes the geographic coordinate system.

#### Remarks

If the site does not have a geographic coordinate system, it returns an empty string for this property.

#### Since

2018

### `P:Autodesk.Revit.DB.SiteLocation.GeoCoordinateSystemId`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteLocation.GeoCoordinateSystemId`

#### Summary

The geographic coordinate system ID, such as "AMG-50" and "Beijing1954/a.GK3d-40".

#### Remarks

If the site does not have a geographic coordinate system, it returns an empty string for this property.

#### Since

2018

### `P:Autodesk.Revit.DB.SiteLocation.Elevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteLocation.Elevation`

#### Summary

The elevation of the site location.

#### Since

2014 UR2

### `P:Autodesk.Revit.DB.SiteLocation.WeatherStationName`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteLocation.WeatherStationName`

#### Summary

The name of the weather station at the site location.

#### Since

2014 UR2

### `P:Autodesk.Revit.DB.SiteLocation.PlaceName`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteLocation.PlaceName`

#### Summary

The place name of the site.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.SiteLocation.TimeZone`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteLocation.TimeZone`

#### Summary

The time-zone for the site.

#### Remarks

A property that returns the time zone in which the site resides.
The value is in hours, ranging from +12 hours to -12 hours with 0 being GMT.
If the input value is not in the valid range, it will be shifted by multiples
of 24 until it is in range.

Set this property directly if for your desired latitude and longitude, Revit's calculation
does not match with the actual time zone for your location. Note that there are no restrictions
preventing you from setting this to an incorrect value for the site location, and incorrect
times for Solar Studies may result.

#### Value

Hours ranging from -12 to +12. 0 represents GMT. Note that if the input value is
not in the valid range, it will be shifted by multiples of 24 until it is in range.
