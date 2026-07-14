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
Shard: 43
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.CurveLoopIterator.GetCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoopIterator.GetCurrent`

#### Summary

Returns the current curve.

#### Returns

The current curve.

#### Since

2013

### `M:Autodesk.Revit.DB.CurveLoopIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoopIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2013

### `M:Autodesk.Revit.DB.CurveLoopIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoopIterator.MoveNext`

#### Summary

Increments the iterator to the next item.

#### Remarks

After an enumerator is created or after the Reset method is called, an enumerator is positioned before the first element of the collection,
and the first call to the MoveNext method moves the enumerator over the first element of the collection.

#### Returns

True if there is a next available item in this iterator.
False if the iterator has completed all available items.

#### Since

2013

### `P:Autodesk.Revit.DB.CurveLoopIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveLoopIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.CurveLoopIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveLoopIterator`

#### Summary

An iterator to a curve loop.

#### Since

2013

### `M:Autodesk.Revit.DB.CurveLoop.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.CurveLoop.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.CurveLoop.NumberOfCurves`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.NumberOfCurves`

#### Summary

Returns the number of curves in the curve loop.

#### Returns

The number of curves in the curve loop.

#### Since

2019.1

### `M:Autodesk.Revit.DB.CurveLoop.GetCurveLoopIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.GetCurveLoopIterator`

#### Summary

Returns a curve that iterates through the curve loop.

#### Returns

A curve loop iterator object that can be used to iterate through key-value pairs in the collection.

#### Since

2013

### `M:Autodesk.Revit.DB.CurveLoop.CreateViaOffset(Autodesk.Revit.DB.CurveLoop,System.Collections.Generic.IList{System.Double},Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.CreateViaOffset(Autodesk.Revit.DB.CurveLoop,System.Collections.Generic.IList{System.Double},Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new curve loop that is an offset of the existing curve loop.

#### Remarks

For each curve i in the curve loop, the offset curve is theoretically defined by translating every point of the original curve by the
vector offsetDist[i] * (curveTan x normal) where curveTan is the curve's unit tangent vector at the given point. The curves are then
trimmed to create a continuous curve loop. For a planar curve loop, this amounts to pushing each point "to the right" of the curve
loop by the signed offset distance offsetDist, within the plane of the curve loop. The "right" side of the curve loop at a given
point on the curve loop is defined with reference to normal being thought of as the upward direction and curveTan being thought of
as the forward direction, as if you are walking along the curve loop. It follows that if offsetDist[i] is positive, points will be
offset to the right of the curve loop, whereas if offsetDist[i] is negative, points will be offset to the left of the curve loop.

If the curve loop contains curves such as elliptical segments or splines, it is possible the offset creation will fail if
Revit will not be able to trim contiguous curves to meet one another. If the offset is successful, offsets of those curve types
will be created as HermiteSplines.

#### Parameter `original`

The original curve loop.

#### Parameter `offsetDists`

The signed offset distances for each curve. The size of this array must match the size of the curve loop.
Curve at position i will be offset with offsetDists[i].

#### Parameter `normal`

The normal of the offset plane.

#### Returns

The offset curve loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the curve loop could not be offset.

#### Since

2019.1

### `M:Autodesk.Revit.DB.CurveLoop.CreateViaOffset(Autodesk.Revit.DB.CurveLoop,System.Double,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.CreateViaOffset(Autodesk.Revit.DB.CurveLoop,System.Double,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new curve loop that is an offset of the existing curve loop.

#### Remarks

For each curve in the curve loop, the offset curve is theoretically defined by translating every point of the original curve by the
vector offsetDist * (curveTan x normal) where curveTan is the curve's unit tangent vector at the given point. The curves are then
trimmed to create a continuous curve loop. For a planar curve loop, this amounts to pushing each point "to the right" of the curve
loop by the signed offset distance offsetDist, within the plane of the curve loop. The "right" side of the curve loop at a given
point on the curve loop is defined with reference to normal being thought of as the upward direction and curveTan being thought of
as the forward direction, as if you are walking along the curve loop. It follows that if offsetDist is positive, points will be
offset to the right of the curve loop, whereas if offsetDist is negative, points will be offset to the left of the curve loop.

If the curve loop contains curves such as elliptical segments or splines, it is possible the offset creation will fail if
Revit will not be able to trim contiguous curves to meet one another. If the offset is successful, offsets of those curve types
will be created as HermiteSplines.

#### Parameter `original`

The original curve loop.

#### Parameter `offsetDist`

The signed offset distance.

#### Parameter `normal`

The normal of the offset plane.

#### Returns

The offset curve loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the curve loop could not be offset.

#### Since

2015

### `M:Autodesk.Revit.DB.CurveLoop.CreateViaCopy(Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.CreateViaCopy(Autodesk.Revit.DB.CurveLoop)`

#### Summary

Creates a new curve loop as a copy of the input.

#### Parameter `original`

The original curve loop.

#### Returns

The copied curve loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.CurveLoop.Flip`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.Flip`

#### Summary

Reverses the orientation of the curve loop.

#### Since

2012

### `M:Autodesk.Revit.DB.CurveLoop.IsCounterclockwise(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.IsCounterclockwise(Autodesk.Revit.DB.XYZ)`

#### Summary

Determines if this CurveLoop is oriented counter-clockwise (CCW) or clockwise (CW) with
respect to the specified 3D direction.

#### Remarks

CCW means that the projection of the CurveLoop onto a plane having "normal" as its oriented normal is CCW.
This method should only be called if the loop is closed and has a non-singular projection onto the plane
(i.e., the projection should have no self-intersections and should not be degenerate or even
nearly degenerate). The return value in other cases is indeterminate.

#### Parameter `normal`

The normal vector to the plane used for this determination.

#### Returns

True if the curve loop is oriented counter-clockwise with respect to the specified 3D direction,
false if the loop is oriented clockwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The curve loop is open or consists of a single unbound curve; counterclockwise determination has no meaning.

#### Since

2012

### `M:Autodesk.Revit.DB.CurveLoop.IsOpen`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.IsOpen`

#### Summary

Returns whether the curve loop is open or closed, as determined by an internal flag.

#### Remarks

Some routines in Revit may set the CurveLoop to be marked "open" or "closed" in spite of the actual geometry of the curves.
In these special cases, the CurveLoop class does not require that the CurveLoop is correctly marked.

#### Returns

True if the CurveLoop is marked open, false if marked closed.

#### Since

2012

### `M:Autodesk.Revit.DB.CurveLoop.Transform(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.Transform(Autodesk.Revit.DB.Transform)`

#### Summary

Transforms this curve loop and all of its component curves by the supplied transformation.

#### Remarks

The modified CurveLoop is guaranteed to be valid with all consituent curves contiguous (assuming
that the curves were contiguous in the input curve loop).

#### Parameter `transform`

The transformation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

transform is not conformal.
-or-
transform has a scale that is negative or zero.

#### Since

2016

### `M:Autodesk.Revit.DB.CurveLoop.CreateViaTransform(Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.CreateViaTransform(Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.Transform)`

#### Summary

Creates a new curve loop as a transformed copy of the input curve loop.

#### Remarks

The newly created CurveLoop is guaranteed to be valid with all consituent curves contiguous (assuming
that the curves were contiguous in the input curve loop).

#### Parameter `curveLoop`

The input curve loop.

#### Parameter `transform`

The transformation.

#### Returns

The new curve loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

transform is not conformal.
-or-
transform has a scale that is negative or zero.

#### Since

2016

### `M:Autodesk.Revit.DB.CurveLoop.CreateViaThicken(Autodesk.Revit.DB.CurveLoop,System.Double,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.CreateViaThicken(Autodesk.Revit.DB.CurveLoop,System.Double,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new closed curve loop by thickening the input open curve loop with respect to a given plane.

#### Remarks

The new loop will be created via
offsets of the input curve loop (in the plane of the normal vector) with the endpoints
connected with lines.The original curve loop will be at the center of the new loop.

If the curve loop contains curves such as elliptical segments or splines, it is possible the offset creation will fail if
Revit will not be able to trim contiguous curves to meet one another. If the offset is successful, offsets of those curve types
will be created as HermiteSplines.

#### Parameter `curveLoop`

The input curve loop.

#### Parameter `thickness`

The distance between the offset curves created on either side of the input curve.

#### Parameter `normal`

The normal vector to the plane used for thickening.

#### Returns

The new curve loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input thickness is too short for a curve.
-or-
the curve loop is not marked as open.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Throws if the input curve could not be thickened.

#### Since

2015

### `M:Autodesk.Revit.DB.CurveLoop.CreateViaThicken(Autodesk.Revit.DB.Curve,System.Double,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.CreateViaThicken(Autodesk.Revit.DB.Curve,System.Double,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new closed curve loop by thickening the input curve with respect to a given plane.

#### Remarks

The new loop will be created via
offsets of the input curve (in the plane of the normal vector) with the endpoints
connected with lines.The original curve will be at the center of the new loop.

Note that for input elliptical fragments and NurbSpline curves, any offsets will be created as HermiteSplines.

#### Parameter `pCurve`

The input curve.

#### Parameter `thickness`

The distance between the offset curves created on either side of the input curve.

#### Parameter `normal`

The normal vector to the plane used for thickening.

#### Returns

The new curve loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input thickness is too short for a curve.
-or-
The input pCurve points to a helical curve and is not supported for this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Throws if the input curve could not be thickened.

#### Since

2012

### `M:Autodesk.Revit.DB.CurveLoop.GetRectangularHeight(Autodesk.Revit.DB.Plane)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.GetRectangularHeight(Autodesk.Revit.DB.Plane)`

#### Summary

Returns the width of a curve loop if it is rectangular with respect to the projection plane.

#### Remarks

The height is determined by the V extents of the UV curve created by from the curve loop plane.

#### Parameter `plane`

The plane to which the curves will be projected.

#### Returns

The height.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The curve loop is not rectangular when projected to the input plane.

#### Since

2012

### `M:Autodesk.Revit.DB.CurveLoop.GetRectangularWidth(Autodesk.Revit.DB.Plane)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.GetRectangularWidth(Autodesk.Revit.DB.Plane)`

#### Summary

Returns the width of a curve loop if it is rectangular with respect to the projection plane.

#### Remarks

The width is determined by the U extents of the UV curve created by from the curve loop plane.

#### Parameter `plane`

The plane to which the curves will be projected.

#### Returns

The width.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The curve loop is not rectangular when projected to the input plane.

#### Since

2012

### `M:Autodesk.Revit.DB.CurveLoop.IsRectangular(Autodesk.Revit.DB.Plane)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.IsRectangular(Autodesk.Revit.DB.Plane)`

#### Summary

Identifies if the curve loop is rectangular with respect to a given projection plane.

#### Parameter `plane`

The plane to which the curves will be projected to determine if they represent a rectangle.

#### Returns

True if the curve loop is rectangular, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.CurveLoop.GetExactLength`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.GetExactLength`

#### Summary

Returns the sum of exact lengths of all curves in the loop.

#### Returns

The total length of the curves in the loop.

#### Since

2012

### `M:Autodesk.Revit.DB.CurveLoop.HasPlane`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.HasPlane`

#### Summary

Identifies if the CurveLoop is planar.

#### Returns

True if the curve loop is planar, false otherwise.

#### Since

2013

### `M:Autodesk.Revit.DB.CurveLoop.GetPlane`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.GetPlane`

#### Summary

Gets the plane of the curve loop, if it is planar.

#### Returns

The plane of the curve loop.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The curve loop does not lie in a single plane.

#### Since

2012

### `M:Autodesk.Revit.DB.CurveLoop.Append(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.Append(Autodesk.Revit.DB.Curve)`

#### Summary

Append the curve to this loop.

#### Parameter `curve`

The curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve points to a helical curve and is not supported for this operation.
-or-
Throws if the input curve makes the loop not contiguous.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.CurveLoop.Create(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.Create(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

#### Summary

Creates a new curve loop.

#### Parameter `curves`

The curves.

#### Returns

The curve loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curves contains at least one helical curve and is not supported for this operation.
-or-
Throws if the input curves are not contiguous.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.CurveLoop.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveLoop.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.CurveLoop.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveLoop.#ctor`

#### Summary

Constructs a new empty curve loop.

#### Since

2012

### `T:Autodesk.Revit.DB.CurveLoop`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveLoop`

#### Summary

A class that represents a chain of curves.

#### Remarks

There are specific requirements for how valid CurveLoops must be formed:
The curves should typically be contiguous.

The CurveLoop may be either closed (where the start and end points coincide) or open.

There should be no self-intersections.
A CurveLoop is said to be "continuous" if either:
the loop contains at most one curve

the end of each curve coincides with the start of the next one (if there is a next curve).

Many geometry utilities require CurveLoops to be continuous, but discontinuous CurveLoops are sometimes used. For example, the curves
in a continuous CurveLoop may be offset, resulting in a discontinuous loop if the offset curves overlap or do not meet, and the offset
curves might then be extended or trimmed to form a continuous CurveLoop.

A CurveLoop is said to be "closed" if it is non-empty, continuous, and if either:
the loop contains just one curve, which is unbounded and periodic

the loop's end point coincides with its start point
For example, a CurveLoop comprising four lines forming a rectangle, listed in order around the rectangle, with each curve oriented in direction
in which the curves are listed is closed. As another example, a CurveLoop consisting of just one unbounded circle is closed.

A CurveLoop is said to be "open" if it is not closed. For example, a CurveLoop consisting of a single line is open, as is the "offset CurveLoop"
mentioned above. Note that an open CurveLoop may be continuous or discontinuous, and a continuous CurveLoop may be open or closed. The definitions
imply that a discontinuous CurveLoop is necessarily open and an empty CurveLoop is open.

It should also be noted that these definitions take the order of the curves and the curves' directions into account. For example, a CurveLoop
comprising the four edges of a rectangle in the order {bottom, top, left, right} is discontinuous. Similarly, a CurveLoop comprising the four
edges of a rectangle in the order {bottom, right, top, left}, with three of the lines oriented in the counter-clockwise direction of
the rectangle and the fourth oriented in the clockwise direction, is discontinuous.

Finally, note that some routines in Revit may set the CurveLoop to be marked "open" or "closed" in spite of the actual geometry of the curves.
In these special cases, the CurveLoop class does not require that the CurveLoop is correctly marked.

In the API, the members of the CurveLoop may be directly iterated, as the class implements IEnumerable<Curve>. The iteration
provides copies of the curves directly contained in the loop; modification of the curves will not affect the curves that are contained in the loop.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.AnalyticalOpening.IsCurveLoopValidForAnalyticalOpening(Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalOpening.IsCurveLoopValidForAnalyticalOpening(Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if curve loop is valid for Analytical Opening.

#### Parameter `loop`

The curve loop to be checked.

#### Parameter `aDoc`

Revit document.

#### Parameter `panelId`

ElementId of the AnalyticalPanel on which we create the Opening.

#### Returns

Returns true if curve loop is ok, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalOpening.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalOpening.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of an Analytical Opening within the project.

#### Remarks

CurveLoop must be planar, not self-intersecting and in the same plane as the Analytical Panel.
CurveLoop must intersect or to be inside the AnalyticalPanel contour.
PanelId must be the ElementId of an AnalyticalPanel otherwise an exception is thrown.

#### Parameter `aDoc`

Revit document.

#### Parameter `curveLoop`

CurveLoop for the Analytical Opening.

#### Parameter `panelId`

ElementId of the AnalyticalPanel on which we create the Opening.

#### Returns

The newly created AnalyticalOpening instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One of the following requirements is not satisfied :
- curve loop curveLoop is not planar
- curve loop curveLoop is self-intersecting
- curve loop curveLoop contains zero length curves
- curve loop curveLoop is not inside or does not intersect the AnalyticalPanel on which we want to create the Opening.
- panelId is not the ElementId of an AnalyticalPanel
- curve loop curveLoop is not in the same plane as the Analytical Panel

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

### `P:Autodesk.Revit.DB.Structure.AnalyticalOpening.PanelId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalOpening.PanelId`

#### Summary

ElementId of the AnalyticalPanel parent.

#### Since

2023

### `T:Autodesk.Revit.DB.Structure.AnalyticalOpening`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalOpening`

#### Summary

An element that represents an Opening in an Analytical Panel element.

#### Remarks

It can cut only one Analytical Panel at a time.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase.IsCurveLoopValid(Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase.IsCurveLoopValid(Autodesk.Revit.DB.CurveLoop)`

#### Summary

Checks if curve loop is valid for Analytical Panel.

#### Parameter `profile`

The curve loop to be checked.

#### Returns

Returns true if curve loop is ok, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase.SetOuterContour(Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase.SetOuterContour(Autodesk.Revit.DB.CurveLoop)`

#### Summary

Sets the Curve Loop that defines the geometry of the Analytical Surface element.

#### Remarks

Curve Loop must be planar and not self-intersecting.

#### Parameter `outerContour`

New Curve Loop for the Analytical Surface element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One of the following requirements is not satisfied :
- curve loop outerContour is not planar
- curve loop outerContour is self-intersecting
- curve loop outerContour contains zero length curves

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Only planar surfaces can be edited.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase.GetOuterContour`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase.GetOuterContour`

#### Summary

Returns the Curve Loop that defines the geometry of the Analytical Surface element.

#### Returns

CurveLoop associated with Analytical Surface element.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase.SketchId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase.SketchId`

#### Summary

Sketch associated to this Revit element.

#### Remarks

Analytical Element may not have a valid sketch.
To edit the sketch profile you can use `M:Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase.SetOuterContour(Autodesk.Revit.DB.CurveLoop)` or `!:Autodesk::Revit::DB::SketchEditScope` .

#### Since

2023

### `T:Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase`

#### Summary

This is the base class for analytical surface elements.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalNodeData.GetAnalyticalNodeData(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalNodeData.GetAnalyticalNodeData(Autodesk.Revit.DB.Element)`

#### Summary

Returns AnalyticalNodeData associated with this element, if it exists.

#### Remarks

If the input element doesn't have AnalyticalNodeData than it retuns `null` .
The input element should be a ReferencePoint.

#### Parameter `element`

The element from which we try to obtain AnalyticalNodeData.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.AnalyticalNodeData.GetConnectionStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalNodeData.GetConnectionStatus`

#### Summary

Returns the Connection Status for this Analytical Node.

#### Since

2021

### `P:Autodesk.Revit.DB.Structure.AnalyticalNodeData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalNodeData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.AnalyticalNodeData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalNodeData`

#### Summary

This class holds information related to analytical model.

#### Remarks

This class is attached to a ReferencePoint.

#### Since

2021

### `T:Autodesk.Revit.DB.Structure.SurfaceElementExtension`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.SurfaceElementExtension`

#### Summary

Presets for given Analytical Extension.

### `F:Autodesk.Revit.DB.Structure.SurfaceElementExtension.Plane`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.SurfaceElementExtension.Plane`

#### Summary

Use a Plane for extension (e.g., Grid, Level).

### `F:Autodesk.Revit.DB.Structure.SurfaceElementExtension.BottomOrTop`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.SurfaceElementExtension.BottomOrTop`

#### Summary

Bottom or Top of physical element.

### `T:Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ`

#### Summary

Presets for given Analytical Projection Z.

### `F:Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ.Plane`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ.Plane`

#### Summary

Use a Plane for projection (e.g., Grid, Level).

### `F:Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ.CenterOfCore`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ.CenterOfCore`

#### Summary

Center of core.
Applicable for wall analytical model only.

### `F:Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ.BottomOrExterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ.BottomOrExterior`

#### Summary

Bottom for floor or Exterior Face for wall element.

### `F:Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ.CenterOfElement`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ.CenterOfElement`

#### Summary

Center of element.

### `F:Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ.TopOrInterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ.TopOrInterior`

#### Summary

Top for floor or Interior Face for wall element.

### `T:Autodesk.Revit.DB.Structure.AnalyticalNodeConnectionStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalNodeConnectionStatus`

#### Summary

Indicates the Connections Status for an Analytical Node.

#### Since

2023

#### Since

2023

### `F:Autodesk.Revit.DB.Structure.AnalyticalNodeConnectionStatus.Connected`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalNodeConnectionStatus.Connected`

#### Summary

Connected

### `F:Autodesk.Revit.DB.Structure.AnalyticalNodeConnectionStatus.Unconnected`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalNodeConnectionStatus.Unconnected`

#### Summary

Unconnected node (only one connected element)

### `P:Autodesk.Revit.DB.Structure.ReleaseConditions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReleaseConditions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.ReleaseConditions.Mz`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReleaseConditions.Mz`

#### Summary

Gets or Sets the Mz of the release type.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.ReleaseConditions.My`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReleaseConditions.My`

#### Summary

Gets or Sets the My of the release type.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.ReleaseConditions.Mx`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReleaseConditions.Mx`

#### Summary

Gets or Sets the Mx of the release type.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.ReleaseConditions.Fz`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReleaseConditions.Fz`

#### Summary

Gets or Sets the Fz of the release type.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.ReleaseConditions.Fy`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReleaseConditions.Fy`

#### Summary

Gets or Sets the Fy of the release type.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.ReleaseConditions.Fx`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReleaseConditions.Fx`

#### Summary

Gets or Sets the Fx of the release type.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.ReleaseConditions.Start`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReleaseConditions.Start`

#### Summary

Gets or Sets the position of release type. True for start, false for end.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.ReleaseConditions.#ctor(System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReleaseConditions.#ctor(System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)`

#### Summary

Creates a new instance of ReleaseConditions.

#### Parameter `start`

The position on analytical element. True for start, false for end.

#### Parameter `fx`

Fx of the release type.

#### Parameter `fy`

Fy of the release type.

#### Parameter `fz`

Fz of the release type.

#### Parameter `mx`

Mx of the release type.

#### Parameter `my`

My of the release type.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.ReleaseConditions.#ctor(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReleaseConditions.#ctor(System.Boolean)`

#### Summary

Creates a new instance of ReleaseConditions.

#### Parameter `start`

The position on analytical element. True for start, false for end.

#### Since

2023

### `T:Autodesk.Revit.DB.Structure.ReleaseConditions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ReleaseConditions`

#### Summary

An object that represents a Release Conditions on analytical element.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.MemberForces.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.MemberForces.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.MemberForces.Moment`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.MemberForces.Moment`

#### Summary

The rotational forces at relative point position of the element.

#### Remarks

The x value of XYZ object represents moment about x-axis of the analytical element coordinate system, y about y-axis, z about z-axis respectively.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.MemberForces.Force`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.MemberForces.Force`

#### Summary

The translational forces at relative point position of the element.

#### Remarks

The x value of XYZ object represents moment about x-axis of the analytical element coordinate system, y about y-axis, z about z-axis respectively.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.MemberForces.Start`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.MemberForces.Start`

#### Summary

Member Forces position on analytical element. True for start, false for end.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.MemberForces.#ctor(System.Boolean,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.MemberForces.#ctor(System.Boolean,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new instance of MemberForces.

#### Parameter `start`

Member Forces position on analytical element. True for start, false for end.

#### Parameter `force`

The Translational forces at specified position of the element.
The x value of XYZ object represents force along x-axis of the analytical element coordinate system, y along y-axis, z along z-axis respectively.

#### Parameter `moment`

The Rotational forces at specified position of the element.
The x value of XYZ object represents moment about x-axis of the analytical element coordinate system, y about y-axis, z about z-axis respectively.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.MemberForces`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.MemberForces`

#### Summary

An object that represents a member forces on analytical element.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.FlipCurve`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.FlipCurve`

#### Summary

Flip the Analytical Member

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.SetMemberForces(Autodesk.Revit.DB.Structure.MemberForces)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.SetMemberForces(Autodesk.Revit.DB.Structure.MemberForces)`

#### Summary

Sets Member Forces to Analytical Member.

#### Remarks

If element already have member forces defined for that end, newly provided values replace current one.
Member forces are strictly related with releases. This means that setting member forces values is reasonable only for directions that have releases set to false.

#### Parameter `memberForces`

End to which member forces will be added is defined by setting `!:Autodesk::Revit::DB::Structure::MemberForces::Position`
property in provided Member Forces object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.SetMemberForces(System.Boolean,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.SetMemberForces(System.Boolean,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Sets Member Forces to Analytical Member.

#### Remarks

If Analytical Member already have member forces defined for that end, newly provided values replace current one.
Member forces are strictly related with releases. This means that setting member forces values is reasonable only for directions that have releases set to false.

#### Parameter `start`

Member Forces position on Analytical Member. True for start, false for end.

#### Parameter `force`

The translational forces at specified position of the element.
The x value of XYZ object represents force along x-axis of the Analytical Member coordinate system, y along y-axis, z along z-axis respectively.

#### Parameter `moment`

The rotational forces at specified position of the element.
The x value of XYZ object represents moment about x-axis of the Analytical Member coordinate system, y about y-axis, z about z-axis respectively.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.GetMemberForces`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.GetMemberForces`

#### Summary

Gets the member forces associated with this Analytical Member.

#### Remarks

Member forces are strictly related with releases. This means that we can obtain member forces values only for directions that have releases set to false.
Force or moment component on direction that have release set to true is skipped (zeroed) during getting.

#### Returns

Returns a collection of Member Forces associated with this Analytical Member. Empty collection will be returned if Analytical Member doesn't have any Member Forces.
To find out with which end member forces are associated use `!:Autodesk::Revit::DB::Structure::MemberForces::Position`
property to obtain a position of Member Forces on element.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.SetReleaseConditions(Autodesk.Revit.DB.Structure.ReleaseConditions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.SetReleaseConditions(Autodesk.Revit.DB.Structure.ReleaseConditions)`

#### Summary

Sets Release Conditions to Analytical Member.

#### Remarks

If element already have release conditions defined for that end, newly provided values replace current one.
The ReleaseType will be set to UserDefined.

#### Parameter `releaseConditions`

End to which release conditions will be added is defined by setting `!:Autodesk::Revit::DB::Structure::ReleaseConditions::Position`
property in provided release conditions object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.GetReleaseConditions`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.GetReleaseConditions`

#### Summary

Gets the release conditions associated with this Analytical Member.

#### Returns

Returns a collection of Release Conditions associated with this Analytical Member. Empty collection will be returned if Analytical Member doesn't have any Release Conditions.
End to which release conditions will be added is defined by setting `!:Autodesk::Revit::DB::Structure::ReleaseConditions::Position`
property in provided release conditions object.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.SetReleaseType(System.Boolean,Autodesk.Revit.DB.Structure.ReleaseType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.SetReleaseType(System.Boolean,Autodesk.Revit.DB.Structure.ReleaseType)`

#### Summary

Sets the release type.

#### Parameter `start`

The position on Analytical Member element. True for start, false for end.

#### Parameter `releaseType`

The type of release.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.GetReleaseType(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.GetReleaseType(System.Boolean)`

#### Summary

Gets the release type.

#### Parameter `start`

The position on Analytical Member element. True for start, false for end.

#### Returns

The type of release.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.IsValidCurve(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.IsValidCurve(Autodesk.Revit.DB.Curve)`

#### Summary

Verifies if the curve is valid for an Analytical Member.

#### Parameter `curve`

The curve to be verified.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.IsValidSectionTypeId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.IsValidSectionTypeId(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the family symbol id is allowed for
Analytical Member as Section Type property.

#### Parameter `familySymbolId`

Family symbol id which has to be checked.

#### Returns

True if %familySymbolId% is invalidElementId; or if it is
the id of a FamilySymbol of category "Structural Framing"
(OST_StructuralFraming) or "Structural Columns" (OST_StructuralColumns)
Returns false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.Split(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.Split(System.Double)`

#### Summary

Splits the analytical member at a point on its defining curve.

#### Remarks

Analytical members that are not a line or an arc are not permitted.
See `M:Autodesk.Revit.DB.Structure.AnalyticalMember.CanSplit` to determine if the analytical member is allowed to be split by this method.

#### Parameter `parameter`

The normalized parameter value along the element (should be greater than 0 and less than 1).

#### Returns

The newly created analytical member id.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Analytical member cannot be split.

#### Since

2024.1

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.CanSplit`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.CanSplit`

#### Summary

Identifies whether a particular analytical member can be split at a point on it's defining curve (by `M:Autodesk.Revit.DB.Structure.AnalyticalMember.Split(System.Double)` ).

#### Returns

True if the analytical member can be split, otherwise false.

#### Since

2024.1

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.SetCurve(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.SetCurve(Autodesk.Revit.DB.Curve)`

#### Summary

Sets the curve for the Analytical Member.

#### Remarks

End nodes connection will be lost if the curve changes position.
The curve must be bounded.
The curve can be:
Line

Arc

Ellipse

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve is not bound.
-or-
The provided curve is not supported.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalMember.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Curve)`

#### Summary

Creates a new instance of an Analytical Member within the project.

#### Remarks

The curve must be bounded.
The curve can be:
Line

Arc

Ellipse

#### Parameter `aDoc`

A Revit document.

#### Parameter `curve`

Curve of the analytical member.

#### Returns

The newly created Analytical Member instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve is not bound.
-or-
The provided curve is not supported.

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

### `P:Autodesk.Revit.DB.Structure.AnalyticalMember.StructuralSectionShape`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.StructuralSectionShape`

#### Summary

The structural section shape of the Analytical Member.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.AnalyticalMember.SectionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.SectionTypeId`

#### Summary

The id of the type from the structural Family assigned to the Analytical Member.

#### Remarks

The type must be of category "Structural Framing"
(OST_StructuralFraming) or "Structural Columns" (OST_StructuralColumns)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: sectionTypeId is the id of some element that is not a
FamilySymbol or is not of the category "Structural Framing"
(OST_StructuralFraming) or "Structural Columns" (OST_StructuralColumns)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.AnalyticalMember.CrossSectionRotation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember.CrossSectionRotation`

#### Summary

This represents the cross-section rotation, in radians.

#### Since

2023

### `T:Autodesk.Revit.DB.Structure.AnalyticalMember`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalMember`

#### Summary

Represents a linear element in the structural analytical model.

#### Since

2023

### `T:Autodesk.Revit.DB.Structure.ReleaseType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ReleaseType`

#### Summary

The release type.

#### Since

2016

#### Since

2016

### `F:Autodesk.Revit.DB.Structure.ReleaseType.UserDefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReleaseType.UserDefined`

#### Summary

User Defined.

### `F:Autodesk.Revit.DB.Structure.ReleaseType.BendingMoment`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReleaseType.BendingMoment`

#### Summary

Bending Moment.

### `F:Autodesk.Revit.DB.Structure.ReleaseType.Pinned`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReleaseType.Pinned`

#### Summary

Pinned.

### `F:Autodesk.Revit.DB.Structure.ReleaseType.Fixed`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReleaseType.Fixed`

#### Summary

Fixed.

### `T:Autodesk.Revit.DB.Structure.StickElementExtension`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StickElementExtension`

#### Summary

Presets for given Analytical Extension.

### `F:Autodesk.Revit.DB.Structure.StickElementExtension.Varies`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementExtension.Varies`

#### Summary

Extension types are different at each end.

### `F:Autodesk.Revit.DB.Structure.StickElementExtension.Plane`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementExtension.Plane`

#### Summary

Use a Plane for extension (e.g., Grid, Level).

### `F:Autodesk.Revit.DB.Structure.StickElementExtension.ReferenceLevel`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementExtension.ReferenceLevel`

#### Summary

Bottom or top Reference Level.

### `F:Autodesk.Revit.DB.Structure.StickElementExtension.BottomOrTop`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementExtension.BottomOrTop`

#### Summary

Bottom or Top of physical element.

### `T:Autodesk.Revit.DB.Structure.StickElementProjectionZ`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionZ`

#### Summary

Presets for given Analytical Projection.

### `F:Autodesk.Revit.DB.Structure.StickElementProjectionZ.Varies`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionZ.Varies`

#### Summary

Projection types are different at each end.

### `F:Autodesk.Revit.DB.Structure.StickElementProjectionZ.Plane`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionZ.Plane`

#### Summary

Use a Plane for projection (e.g., Grid, Level).

### `F:Autodesk.Revit.DB.Structure.StickElementProjectionZ.Bottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionZ.Bottom`

#### Summary

Horizontally, corresponds to bottom of physical model.

### `F:Autodesk.Revit.DB.Structure.StickElementProjectionZ.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionZ.Center`

#### Summary

Horizontally, center of physical model.

### `F:Autodesk.Revit.DB.Structure.StickElementProjectionZ.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionZ.Top`

#### Summary

Horizontally, corresponds to top of physical model.

### `F:Autodesk.Revit.DB.Structure.StickElementProjectionZ.LocationLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionZ.LocationLine`

#### Summary

Location Line.

### `T:Autodesk.Revit.DB.Structure.StickElementProjectionY`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionY`

#### Summary

Presets for given Analytical Projection.

### `F:Autodesk.Revit.DB.Structure.StickElementProjectionY.Varies`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionY.Varies`

#### Summary

Projection types are different at each end.

### `F:Autodesk.Revit.DB.Structure.StickElementProjectionY.Plane`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionY.Plane`

#### Summary

Use a Plane for projection (e.g., Grid, Level).

### `F:Autodesk.Revit.DB.Structure.StickElementProjectionY.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionY.Right`

#### Summary

Horizontally, corresponds to right side of physical model.

### `F:Autodesk.Revit.DB.Structure.StickElementProjectionY.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionY.Center`

#### Summary

Horizontally, center of physical model.

### `F:Autodesk.Revit.DB.Structure.StickElementProjectionY.Left`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionY.Left`

#### Summary

Horizontally, corresponds to left side of physical model.

### `F:Autodesk.Revit.DB.Structure.StickElementProjectionY.LocationLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StickElementProjectionY.LocationLine`

#### Summary

Location Line.

### `M:Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.GetDemandLoadCalculationDetailsData(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.GetDemandLoadCalculationDetailsData(Autodesk.Revit.DB.ElementId)`

#### Summary

This function is used to get AnalyticalDemandLoadCalculationDetailsData by given Load Scenario.
The returned temporary data provides detailed information of the current demand load calculation results of the node. Whenever you modify any parameters, the data will not
be automatically updated. You need to use this API to get another new data.
The given load scenario id can be invalidElementId if you don't need to take load scenario into consideration.

#### Parameter `loadScenarioId`

Load Scenario id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id is not a valid electrical analytical load scenario.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.GetLoadClassificationIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.GetLoadClassificationIds`

#### Summary

Get all the Load Classification ids which collected from all the Electrical Analytical Loads in current node.

### `M:Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.GetLoadClassificationDemandCurrent(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.GetLoadClassificationDemandCurrent(Autodesk.Revit.DB.ElementId)`

#### Summary

Get the demand current of given load classification.

#### Parameter `loadClassificationId`

The load classification id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id is not a valid electrical load classification.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.GetLoadClassificationDemandLoad(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.GetLoadClassificationDemandLoad(Autodesk.Revit.DB.ElementId)`

#### Summary

Get the demand load of given load classification.

#### Parameter `loadClassificationId`

The load classification id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id is not a valid electrical load classification.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.GetLoadClassificationTotalCurrent(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.GetLoadClassificationTotalCurrent(Autodesk.Revit.DB.ElementId)`

#### Summary

Get the total current of given load classification.

#### Parameter `loadClassificationId`

The load classification id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id is not a valid electrical load classification.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.GetLoadClassificationTotalLoad(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.GetLoadClassificationTotalLoad(Autodesk.Revit.DB.ElementId)`

#### Summary

Get the total load of given load classification.

#### Parameter `loadClassificationId`

The load classification id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id is not a valid electrical load classification.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.ContainLoadClassification(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.ContainLoadClassification(Autodesk.Revit.DB.ElementId)`

#### Summary

Check whether load classification contains.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id is not a valid electrical load classification.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadClassificationData`

#### Summary

Represents the electrical analytical load classification data.

### `M:Autodesk.Revit.DB.Electrical.AnalyticalDemandLoadCalculationDetailsData.GetLoadScenarioId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalDemandLoadCalculationDetailsData.GetLoadScenarioId`

#### Summary

Get the load scenario of the current demand load calculation data.

#### Returns

The load scenario id of the current demand load calculation data.

### `M:Autodesk.Revit.DB.Electrical.AnalyticalDemandLoadCalculationDetailsData.GetDemandFactorsOfLoadClassification(Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalDemandLoadCalculationDetailsData.GetDemandFactorsOfLoadClassification(Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue}@)`

#### Summary

This function will get all the descendant electrical analytical loads of the current node, and get computed demand factor for each of them.

#### Parameter `demandFactorValuesInLoadRange`

Computed total ElectricalDemandFactorValues of given Load Classification. A computed temporary ElectricalDemandFactorValue is used to represent demand factor in
a certain load range, for example demand factor is 0.85 from 0kVA to 500kVA.
The array will be empty if the demand factor rule of the Load Classification isn't LoadTable or LoadTablePerPortion.

#### Returns

The map of the electrical analytical load id and its demand factor value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id is not a valid electrical load classification.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Electrical.AnalyticalDemandLoadCalculationDetailsData.GetDemandFactorOfLoad(Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalDemandLoadCalculationDetailsData.GetDemandFactorOfLoad(Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue}@)`

#### Summary

Get the demand factor of the given electrical analytical load. The electrical analytical load must a descendant of the current node.

#### Remarks

Electrical Analytical Load including Electrical Analytical Equipment Load and Electrical Analytical Area Based Load. Electrical Analytical Equipment Load is an ElectricalAnalyticalNode, and it has
an AnalyticalEquipmentLoadData. Electrical Analytical Area Based Load is a ZoneEquipment, and it has an AreaBasedLoadData.

#### Parameter `loadId`

The electrical analytical load id.

#### Parameter `demandFactorValuesInLoadRange`

Computed ElectricalDemandFactorValues. A computed temporary ElectricalDemandFactorValue is used to represent demand factor in
a certain load range, for example demand factor is 0.85 from 0kVA to 500kVA.
The array will be empty if the demand factor rule of the electrical analytical load's Load Classification isn't LoadTable or LoadTablePerPortion.

#### Returns

The demand factor value of the given electrical analytical load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id is not a valid electrical analytical load.
-or-
The id is not a descendant electrical analytical load of the current node.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Electrical.AnalyticalDemandLoadCalculationDetailsData.GetLoadScenarioFactorOfLoad(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalDemandLoadCalculationDetailsData.GetLoadScenarioFactorOfLoad(Autodesk.Revit.DB.ElementId)`

#### Summary

Get the load scenario factor of the given electrical analytical load. The load scenario factor is the usage factor of the given electrical analytical load at the load scenario this data reported.
If the electrical analytical load is in a LoadSet, it will return the LoadSet's load scenario factor at the load scenario this data reported.

#### Remarks

Electrical Analytical Load including Electrical Analytical Equipment Load and Electrical Analytical Area Based Load. Electrical Analytical Equipment Load is an ElectricalAnalyticalNode, and it has
an AnalyticalEquipmentLoadData. Electrical Analytical Area Based Load is a ZoneEquipment, and it has an AreaBasedLoadData.
Only Electrical Analytical Equipment Load can be added into a LoadSet.

#### Parameter `loadId`

The electrical analytical load id.

#### Returns

The load scenario factor of the given electrical analytical load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id is not a valid electrical analytical load.
-or-
The id is not a descendant electrical analytical load of the current node.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.Electrical.AnalyticalDemandLoadCalculationDetailsData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalDemandLoadCalculationDetailsData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Electrical.AnalyticalDemandLoadCalculationDetailsData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalDemandLoadCalculationDetailsData`

#### Summary

The functions in this class are aimed to provide demand load calculation detailed data and so that to help users
understand how the total demand load of each Load Classifcation is calculated.

#### Remarks

This class provides detailed data presentation of the current demand load calculation results of the node such as the electrical equipment load's load scenario factor and demand factor.
Please note whenever you modify any parameters, the data will not be automatically updated. You need to use API GetDemandLoadCalculationDetailsData to get another new data.
The demand load calculation rule of one electrical analytical load is: (apparent load of the load) * (load scenario factor of the load) * (demand factor of the load). You can get apparent load of the
electrical analytical equipment load by AnalyticalEquipmentLoadData.ApparentLoad, and get electrical analytical area based load's apparent load by AreaBasedLoadData.ApparentLoad.

### `M:Autodesk.Revit.DB.Electrical.AnalyticalLoadScenario.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadScenario.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a load scenario.

#### Parameter `document`

The document in which to create the load scenario.

#### Parameter `name`

The name of new load scenario. The actual name may be post-fixed if already exists.

#### Returns

The newly created load scenario.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
name is an empty string or contains only whitespace.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).

### `T:Autodesk.Revit.DB.Electrical.AnalyticalLoadScenario`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadScenario`

#### Summary

Represents the data and parameters of electrical analytical load scenario.

### `M:Autodesk.Revit.DB.Structure.AnalyticalLinkType.IsValidAnalyticalFixityState(Autodesk.Revit.DB.Structure.AnalyticalFixityState)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLinkType.IsValidAnalyticalFixityState(Autodesk.Revit.DB.Structure.AnalyticalFixityState)`

#### Summary

Returns whether the input fixity state is valid for Analytical Link Type parameters.

#### Parameter `fixityState`

The fixity state value to check.

#### Returns

True if valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.AnalyticalLinkType.RotationZ`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLinkType.RotationZ`

#### Summary

Fixity of rotation around Z.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The fixity state rotationZ is not valid for Analytical Link Type parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.AnalyticalLinkType.RotationY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLinkType.RotationY`

#### Summary

Fixity of rotation around Y.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The fixity state rotationY is not valid for Analytical Link Type parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.AnalyticalLinkType.RotationX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLinkType.RotationX`

#### Summary

Fixity of rotation around X.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The fixity state rotationX is not valid for Analytical Link Type parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.AnalyticalLinkType.TranslationZ`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLinkType.TranslationZ`

#### Summary

Fixity of translation along Z.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The fixity state translationZ is not valid for Analytical Link Type parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.AnalyticalLinkType.TranslationY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLinkType.TranslationY`

#### Summary

Fixity of translation along Y.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The fixity state translationY is not valid for Analytical Link Type parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.AnalyticalLinkType.TranslationX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLinkType.TranslationX`

#### Summary

Fixity of translation along X.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The fixity state translationX is not valid for Analytical Link Type parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `T:Autodesk.Revit.DB.Structure.AnalyticalLinkType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLinkType`

#### Summary

An object that specifies the analysis properties for an AnalyticalLink element.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.AnalyticalLink.IsAutoGenerated`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLink.IsAutoGenerated`

#### Summary

Specifies whether or not an AnalyticalLink was created by an Analytical Element.

#### Returns

True if AnalyticalLink was created by an Analytical Element, false otherwise.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.AnalyticalLink.IsValidHub(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLink.IsValidHub(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether input hub is valid for an AnalyticalLink.

#### Parameter `doc`

Hubs's document.

#### Parameter `hubId`

Hub to test for validity.

#### Returns

True is returned when provided hubId points hub that is valid for AnalyticalLink, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.AnalyticalLink.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLink.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of a AnalyticalLink element between two Hubs.

#### Parameter `doc`

Document to which new AnalyticalLink should be added.

#### Parameter `type`

AnalyticalLinkType for the new AnalyticalLink.

#### Parameter `startHubId`

Hub at start of AnalyticalLink.

#### Parameter `endHubId`

Hub at end of AnalyticalLink.

#### Returns

The newly created AnalyticalLink instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

startHubId is not a valid Hub ID for an AnalyticalLink element.
-or-
endHubId is not a valid Hub ID for an AnalyticalLink element.
-or-
Thrown if startHubId or endHubId do not represent ids of Hubs.
-or-
Thrown if startHubId == endHubId.
-or-
Thrown if type does not represent an id of an AnalyticalLinkType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.AnalyticalLink.EndHubId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLink.EndHubId`

#### Summary

Hub ID at end of AnalyticalLink.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.AnalyticalLink.StartHubId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLink.StartHubId`

#### Summary

Hub ID at start of AnalyticalLink.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.AnalyticalLink.OwnerId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLink.OwnerId`

#### Summary

ElementId of Analytical Element which created the AnalyticalLink (if any)
invalidElementId if this Analytical Link was created by the User or API

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.AnalyticalLink.End`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLink.End`

#### Summary

The point at the end of the AnalyticalLink.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.AnalyticalLink.Start`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLink.Start`

#### Summary

The point at the start of the AnalyticalLink.

#### Since

2013

### `T:Autodesk.Revit.DB.Structure.AnalyticalLink`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLink`

#### Summary

An analytical link element that is used to create connections between other Analytical Elements.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.AnalyticalModelSelector.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalModelSelector.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.AnalyticalModelSelector.CurveSelector`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalModelSelector.CurveSelector`

#### Summary

The portion of the curve to be selected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.AnalyticalModelSelector.#ctor(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalModelSelector.#ctor(Autodesk.Revit.DB.Curve)`

#### Summary

Creates a selector based on a specific analytical curve.

#### Parameter `curve`

The curve upon which this selector acts.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve points to a helical curve and is not supported for this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.AnalyticalModelSelector.#ctor(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.Structure.AnalyticalCurveSelector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalModelSelector.#ctor(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.Structure.AnalyticalCurveSelector)`

#### Summary

Creates a selector based on one portion of a specific analytical curve.

#### Parameter `curve`

The curve upon which this selector acts.

#### Parameter `inCurveSelector`

Portion of the analytical curve in which the client is interested.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve points to a helical curve and is not supported for this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.AnalyticalModelSelector.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalModelSelector.#ctor`

#### Summary

Creates a selector for the analytical model geometry.

#### Remarks

This version is useful for single-curve or single-point analytical models.
Additionally, this only acts with respect to the entire curve or point.

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.AnalyticalModelSelector.#ctor(Autodesk.Revit.DB.Structure.AnalyticalCurveSelector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalModelSelector.#ctor(Autodesk.Revit.DB.Structure.AnalyticalCurveSelector)`

#### Summary

Creates a selector for the analytical model geometry.

#### Remarks

This version is useful for single-curve or single-point analytical models.

#### Parameter `inCurveSelector`

Portion of the analytical curve in which the client has interest.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `T:Autodesk.Revit.DB.Structure.AnalyticalModelSelector`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalModelSelector`

#### Summary

Defines a portion of an Analytical Model for an Element.

#### Remarks

This is used to identify the portion of an analytical model of interest to a client.
To identify the portion of the analytical model, the client must identify
the curve in question, by using one of the following:
The specific curve within the analytical model.

The index of the curve within the analytical model.

If a specific part of that curve is of interest, the client needs to identify that by
specifying one of the following:
The start of the curve.

The end of the curve.

The entire curve. This is the default behavior, so this does not need specifying.

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.AnalyticalElement.IsValidStructuralRole(Autodesk.Revit.DB.Structure.AnalyticalStructuralRole)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElement.IsValidStructuralRole(Autodesk.Revit.DB.Structure.AnalyticalStructuralRole)`

#### Summary

Checks whether the value set for Analytical Structural Role is valid for an Analytical Element.

#### Parameter `structuralRole`

The value set to be verified.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalElement.IsValidAnalyzeAs(Autodesk.Revit.DB.Structure.AnalyzeAs)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElement.IsValidAnalyzeAs(Autodesk.Revit.DB.Structure.AnalyzeAs)`

#### Summary

Checks whether the value set for Analyze As is valid for an Analytical Element.

#### Parameter `analyzeAs`

The value set to be verified.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalElement.IsSingleCurve`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElement.IsSingleCurve`

#### Summary

Indicates if the Analytical Element can be expressed as a single curve.

#### Returns

True if Analytical Element can be expressed as a single curve, false otherwise.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalElement.GetCurve`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElement.GetCurve`

#### Summary

Returns the curve of the Analytical Element.

#### Remarks

If the Analytical Element cannot be expressed as a single curve, an exception is thrown.

#### Returns

The curve of the Analytical Element.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This AnalyticalElement contains more than one single curve.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalElement.GetReference(Autodesk.Revit.DB.Structure.AnalyticalModelSelector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElement.GetReference(Autodesk.Revit.DB.Structure.AnalyticalModelSelector)`

#### Summary

Returns a reference to a given curve within the Analytical Element.

#### Parameter `selector`

Specifies where in the Analytical Element the reference lies.

#### Returns

Requested reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

selector is not valid for this AnalyticalElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalElement.IsValidSelector(Autodesk.Revit.DB.Structure.AnalyticalModelSelector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElement.IsValidSelector(Autodesk.Revit.DB.Structure.AnalyticalModelSelector)`

#### Summary

Indicates if the input selector is valid for the Analytical Element.

#### Parameter `selector`

Portion of the Analytical Element geometry.

#### Returns

True if selector is valid for this Analytical Element, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.AnalyticalElement.GetTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElement.GetTransform`

#### Summary

Returns the transform which reflects Analytical Element orientation.

#### Returns

The orientation of the Analytical Element.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.AnalyticalElement.StructuralRole`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElement.StructuralRole`

#### Summary

The enum value depicting structural role asigned to the Analytical Element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The provided AnalyticalStructuralRole is not supported

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.AnalyticalElement.AnalyzeAs`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElement.AnalyzeAs`

#### Summary

This represents the Analyze As parameter assigned to Analytical Element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The provided AnalyzeAs is not supported

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.AnalyticalElement.MaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElement.MaterialId`

#### Summary

Defines the Material Id for the Analytical Element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The provided MaterialId is not supported

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2023

### `T:Autodesk.Revit.DB.Structure.AnalyticalElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElement`

#### Summary

Base class for a structural analytical elements.
AnalyticalElement represents the analytical portion of a given Structural Element.

#### Since

2023

### `T:Autodesk.Revit.DB.Structure.AnalyticalStructuralRole`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalStructuralRole`

#### Summary

Indicates the structural role for the analytical elements.

#### Since

2023

#### Since

2023

### `F:Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRolePanel`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRolePanel`

#### Summary

Member plays role of structural panel.

### `F:Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRoleWall`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRoleWall`

#### Summary

Member plays role of structural wall.

### `F:Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRoleFloor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRoleFloor`

#### Summary

Member plays role of structural floor.

### `F:Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRoleGirder`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRoleGirder`

#### Summary

Member plays role of structural girder.

### `F:Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRoleMember`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRoleMember`

#### Summary

Member plays role of structural member.

### `F:Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRoleColumn`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRoleColumn`

#### Summary

Member plays role of structural column.

### `F:Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRoleBeam`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.StructuralRoleBeam`

#### Summary

Member plays role of structural beam.

### `F:Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.Unset`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalStructuralRole.Unset`

#### Summary

No structural role by default.

### `T:Autodesk.Revit.DB.Structure.AnalyticalFixityState`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalFixityState`

#### Summary

Specifies the fixity setting of individual degrees of freedom in analytical release conditions.

### `F:Autodesk.Revit.DB.Structure.AnalyticalFixityState.Spring`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalFixityState.Spring`

#### Summary

Degree of freedom has a Spring coefficient.

### `F:Autodesk.Revit.DB.Structure.AnalyticalFixityState.Released`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalFixityState.Released`

#### Summary

Degree of freedom is Released.

### `F:Autodesk.Revit.DB.Structure.AnalyticalFixityState.Fixed`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalFixityState.Fixed`

#### Summary

Degree of freedom is Fixed.

### `T:Autodesk.Revit.DB.Structure.AnalyticalLoopType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLoopType`

#### Summary

Specifies kind of analytical model loop.

#### Since

2013

#### Since

2013

### `F:Autodesk.Revit.DB.Structure.AnalyticalLoopType.Void`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLoopType.Void`

#### Summary

Loops that are empty inside.
In the case of multiple nested loops, this will return a series of loops starting from second most external and every second heading into the most internal.
In the view returned loops are presented as external outline of openings.

### `F:Autodesk.Revit.DB.Structure.AnalyticalLoopType.Filled`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLoopType.Filled`

#### Summary

Loops that are filled inside.
In the case of multiple nested loops, this will return the most external and every second loop going from external to internal.
In the view, returned loops are presented as external outline of solids.

### `F:Autodesk.Revit.DB.Structure.AnalyticalLoopType.Internal`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLoopType.Internal`

#### Summary

An internal loop is a loop that is inside another loop.
In the case of multiple nested loops, this will return all loops except the most external loop.

### `F:Autodesk.Revit.DB.Structure.AnalyticalLoopType.External`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLoopType.External`

#### Summary

Loops outside all other loops.
In case of multiple nested loops, this will return the most external loop.

### `F:Autodesk.Revit.DB.Structure.AnalyticalLoopType.All`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalLoopType.All`

#### Summary

All analytical loops of analytical model surface elements (floor, slab, wall).

### `T:Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod`

#### Summary

Specifies how analytical model is being aligned in space

### `F:Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod.Varies`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod.Varies`

#### Summary

Alignment types are different at each end.

### `F:Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod.ManuallyAdjusted`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod.ManuallyAdjusted`

#### Summary

Reports if analytical model has been manually adjusted, this value can only set internally by Revit.

### `F:Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod.Projection`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod.Projection`

#### Summary

Manually set projections for analytical model using projection parameters.

### `F:Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod.AutoDetect`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod.AutoDetect`

#### Summary

Auto-detect projections for analytical model.

### `T:Autodesk.Revit.DB.Structure.AnalyticalRigidLinksOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalRigidLinksOption`

#### Summary

Specifies how Rigid Links will be made for the Analytical Model.

#### Remarks

Rigid Links are curves connecting neighboring Structural Beams and Structural Columns.

### `F:Autodesk.Revit.DB.Structure.AnalyticalRigidLinksOption.FromColumn`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalRigidLinksOption.FromColumn`

#### Summary

For a structural beam, this indicates that the structural column setting should be used to determine rigid link formation.
This value is not applicable to structural columns.

### `F:Autodesk.Revit.DB.Structure.AnalyticalRigidLinksOption.Disabled`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalRigidLinksOption.Disabled`

#### Summary

For a structural column, this disables rigid Link formation, unless the neighboring structural beam overrides the setting.
For a structural beam, this disables rigid Link formation, overriding the neighboring structural column's setting.

### `F:Autodesk.Revit.DB.Structure.AnalyticalRigidLinksOption.Enabled`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalRigidLinksOption.Enabled`

#### Summary

For a structural column, enables rigid link formation, unless the neighboring structural beam overrides the setting.
For a structural beam, enables rigid link formation, overriding the neighboring structural column's setting.

### `T:Autodesk.Revit.DB.Structure.AnalyticalElementSelector`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElementSelector`

#### Summary

Specifies a portion of an Analytical Element or the whole element.

### `F:Autodesk.Revit.DB.Structure.AnalyticalElementSelector.Whole`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElementSelector.Whole`

#### Summary

Entire element

### `F:Autodesk.Revit.DB.Structure.AnalyticalElementSelector.EndOrTop`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElementSelector.EndOrTop`

#### Summary

End or top of element (corresponds to end = 1).

### `F:Autodesk.Revit.DB.Structure.AnalyticalElementSelector.StartOrBase`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalElementSelector.StartOrBase`

#### Summary

Start or base of element (corresponds to end = 0).

### `T:Autodesk.Revit.DB.Structure.AnalyticalCurveSelector`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalCurveSelector`

#### Summary

Specifies which portion of an Analytical Curve is of interest.

### `F:Autodesk.Revit.DB.Structure.AnalyticalCurveSelector.WholeCurve`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalCurveSelector.WholeCurve`

#### Summary

Entire curve.

### `F:Autodesk.Revit.DB.Structure.AnalyticalCurveSelector.EndPoint`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalCurveSelector.EndPoint`

#### Summary

End of curve (corresponds to end = 1).

### `F:Autodesk.Revit.DB.Structure.AnalyticalCurveSelector.StartPoint`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalCurveSelector.StartPoint`

#### Summary

Start of curve (corresponds to end = 0).

### `T:Autodesk.Revit.DB.Structure.AnalyzeAs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyzeAs`

#### Summary

Analyze As has various functions within the Analytical Model, and is Element-dependent.
"Not for Analysis" usually means that there will not be an Analytical Model generated.
The others indicate how the Analytical Model behavior will treat the Element in question.
For instance "Hanger" columns have different support expectations than "Gravity" columns.

### `F:Autodesk.Revit.DB.Structure.AnalyzeAs.GravityLateral`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyzeAs.GravityLateral`

#### Summary

Wall interpreted as Gravity and Lateral

### `F:Autodesk.Revit.DB.Structure.AnalyzeAs.SlabTwoWay`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyzeAs.SlabTwoWay`

#### Summary

Floor interpreted as Slab Two-Way.

### `F:Autodesk.Revit.DB.Structure.AnalyzeAs.NotApplicable`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyzeAs.NotApplicable`

#### Summary

Analyze As is not applicable.

### `F:Autodesk.Revit.DB.Structure.AnalyzeAs.NotForAnalysis`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyzeAs.NotForAnalysis`

#### Summary

Element is not for Analysis.

### `F:Autodesk.Revit.DB.Structure.AnalyzeAs.SlabOnGrade`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyzeAs.SlabOnGrade`

#### Summary

Floor interpreted as Slab on a Grade.

### `F:Autodesk.Revit.DB.Structure.AnalyzeAs.Mat`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyzeAs.Mat`

#### Summary

Floor interpreted as Mat Foundation, or general foundation.

### `F:Autodesk.Revit.DB.Structure.AnalyzeAs.SlabOneWay`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyzeAs.SlabOneWay`

#### Summary

Floor interpreted as Slab One-Way.

### `F:Autodesk.Revit.DB.Structure.AnalyzeAs.Lateral`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyzeAs.Lateral`

#### Summary

Interpreted as Lateral (support going across).

### `F:Autodesk.Revit.DB.Structure.AnalyzeAs.Gravity`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyzeAs.Gravity`

#### Summary

Interpreted as Gravity (support going down).

### `F:Autodesk.Revit.DB.Structure.AnalyzeAs.Hanger`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyzeAs.Hanger`

#### Summary

A hanging Element.

### `T:Autodesk.Revit.DB.Structure.AnalyticalCurveType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalCurveType`

#### Summary

Identifies what type of Analytical Model curves should be extracted.

### `F:Autodesk.Revit.DB.Structure.AnalyticalCurveType.AllRigidLinks`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalCurveType.AllRigidLinks`

#### Summary

All Rigid Link curves.
Rigid Link at end 0 (head) will be in the first entry.
Rigid Link at end 1 (tail) will be in the last entry.

### `F:Autodesk.Revit.DB.Structure.AnalyticalCurveType.BaseCurve`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalCurveType.BaseCurve`

#### Summary

Default Analytical Model curve of linear elements (beams, braces, columns).

### `F:Autodesk.Revit.DB.Structure.AnalyticalCurveType.ApproximatedCurves`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalCurveType.ApproximatedCurves`

#### Summary

Curves approximated using linear segments.

### `F:Autodesk.Revit.DB.Structure.AnalyticalCurveType.ActiveCurves`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalCurveType.ActiveCurves`

#### Summary

Curves displayed on screen (not including Rigid Links).

### `F:Autodesk.Revit.DB.Structure.AnalyticalCurveType.RigidLinkTail`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalCurveType.RigidLinkTail`

#### Summary

Rigid Link at end 1 (tail) of the Beam.

### `F:Autodesk.Revit.DB.Structure.AnalyticalCurveType.RigidLinkHead`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalCurveType.RigidLinkHead`

#### Summary

Rigid Link at end 0 (head) of the Beam.

### `F:Autodesk.Revit.DB.Structure.AnalyticalCurveType.RawCurves`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalCurveType.RawCurves`

#### Summary

Base Analytical Model curves generated.

### `T:Autodesk.Revit.DB.Structure.AnalyticalSupportType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalSupportType`

#### Summary

Indicates what kind of support another Element provides -- Point, Surface, or Curve.

### `F:Autodesk.Revit.DB.Structure.AnalyticalSupportType.SurfaceSupport`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalSupportType.SurfaceSupport`

#### Summary

Support along a surface.

### `F:Autodesk.Revit.DB.Structure.AnalyticalSupportType.CurveSupport`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalSupportType.CurveSupport`

#### Summary

Support along a curve.

### `F:Autodesk.Revit.DB.Structure.AnalyticalSupportType.PointSupport`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalSupportType.PointSupport`

#### Summary

Support at just one point.

### `F:Autodesk.Revit.DB.Structure.AnalyticalSupportType.UnknownSupport`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalSupportType.UnknownSupport`

#### Summary

Support has not been determined.

### `T:Autodesk.Revit.DB.Structure.AnalyticalSupportPriority`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalSupportPriority`

#### Summary

Defines how "highly" another Element is giving support for one Element.

#### Remarks

For instance, a Column may be a higher priority for a Beam than another Beam.
This is useful to find the best supports for a given Element.

### `F:Autodesk.Revit.DB.Structure.AnalyticalSupportPriority.UnknownPriority`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalSupportPriority.UnknownPriority`

#### Summary

Priority has not been determined.

### `T:Autodesk.Revit.DB.Structure.AnalyticalDirection`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalDirection`

#### Summary

Specifies a direction for manipulating analytical model.

### `F:Autodesk.Revit.DB.Structure.AnalyticalDirection.Z`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalDirection.Z`

#### Summary

Change in Z direction

### `F:Autodesk.Revit.DB.Structure.AnalyticalDirection.Y`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalDirection.Y`

#### Summary

Change in Y direction

### `F:Autodesk.Revit.DB.Structure.AnalyticalDirection.X`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalDirection.X`

#### Summary

Change in X direction

### `F:Autodesk.Revit.DB.Structure.AnalyticalDirection.Any`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalDirection.Any`

#### Summary

Any change, including vertical and horizontal.

### `F:Autodesk.Revit.DB.Structure.AnalyticalDirection.HorizontalEnd`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalDirection.HorizontalEnd`

#### Summary

Horizontal change, corresponding to end of Curve Driver.

### `F:Autodesk.Revit.DB.Structure.AnalyticalDirection.HorizontalStart`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalDirection.HorizontalStart`

#### Summary

Horizontal change, corresponding to start of Curve Driver.

### `F:Autodesk.Revit.DB.Structure.AnalyticalDirection.Horizontal`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalDirection.Horizontal`

#### Summary

Change in horizontal direction only (no elevation change).

### `F:Autodesk.Revit.DB.Structure.AnalyticalDirection.VerticalBottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalDirection.VerticalBottom`

#### Summary

Vertical change, for bottom of Element's analytical model.

### `F:Autodesk.Revit.DB.Structure.AnalyticalDirection.VerticalTop`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalDirection.VerticalTop`

#### Summary

Vertical change, for top of Element's analytical model.

### `F:Autodesk.Revit.DB.Structure.AnalyticalDirection.Vertical`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalDirection.Vertical`

#### Summary

Change in vertical direction only.

### `T:Autodesk.Revit.DB.Structure.AnalyticalProjectionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType`

#### Summary

Presets for given Analytical Projection. Combined with AnalyticalDirection, this abstracts
Analytical Projections for all Structural Elements

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.Varies`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.Varies`

#### Summary

Projection types are different at each end.

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.LocationLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.LocationLine`

#### Summary

Location Line.

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.CenterOfCore`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.CenterOfCore`

#### Summary

Center of wall core.

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.Default`

#### Summary

Element-specific default value.

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.NotApplicable`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.NotApplicable`

#### Summary

None of the other projection types apply.

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.DatumPlane`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.DatumPlane`

#### Summary

Use a Datum Plane for projection (e.g., Grid, Level).

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.SketchCurve`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.SketchCurve`

#### Summary

For sketch-based analytical models.

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.Invalid`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.Invalid`

#### Summary

Set to a bad setting. Should only be set at this very rarely (i.e., at initial creation).

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.AutoDetect`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.AutoDetect`

#### Summary

Auto-detect projections for analytical model.

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.SideTwo`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.SideTwo`

#### Summary

Horizontally, corresponds to second side (e.g., exterior).

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.SideOne`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.SideOne`

#### Summary

Horizontally, corresponds to first side (e.g., interior).

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.Bottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.Bottom`

#### Summary

Vertically, bottom of physical model.

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.Center`

#### Summary

Vertically, center of physical model.

### `F:Autodesk.Revit.DB.Structure.AnalyticalProjectionType.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AnalyticalProjectionType.Top`

#### Summary

Vertically, on top of physical model.

### `P:Autodesk.Revit.DB.Electrical.AnalyticalBusData.TotalConnectedCurrent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalBusData.TotalConnectedCurrent`

#### Summary

The total connected current of the analytical bus.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalBusData.CurrentRating`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalBusData.CurrentRating`

#### Summary

The current rating value of the analytical bus.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for rating is not a number
-or-
When setting this property: The given value for rating is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for rating must be non-negative.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalBusData.Voltage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalBusData.Voltage`

#### Summary

The voltage value of the analytical bus.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for voltage is not a number
-or-
When setting this property: The given value for voltage is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for voltage must be positive.

#### Since

2023

### `T:Autodesk.Revit.DB.Electrical.AnalyticalBusData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalBusData`

#### Summary

Represents the data and parameters of analytical bus node.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData.WorstLoadScenario`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData.WorstLoadScenario`

#### Summary

The coincident load applied load case.
Will be set appropriately after computation.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData.TotalDemandLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData.TotalDemandLoad`

#### Summary

The Total Demand Load

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData.NumberOfPhases`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData.NumberOfPhases`

#### Summary

The number of phases.

#### Since

2023

### `T:Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData`

#### Summary

Represents the data and parameters of electrical analytical node.

#### Since

2023

### `M:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.GetUnitsMultiplier(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.GetUnitsMultiplier(System.Int32)`

#### Summary

returns units multiplier by index

#### Parameter `index`

index of unit in the list

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.GetUnitsName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.GetUnitsName(System.Int32)`

#### Summary

returns units name by index

#### Parameter `index`

index of unit in the list

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.GetNumberOfUnits`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.GetNumberOfUnits`

#### Summary

returns number of possible units

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.SetUnits(System.Collections.Generic.IList{System.String},System.Collections.Generic.IList{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.SetUnits(System.Collections.Generic.IList{System.String},System.Collections.Generic.IList{System.Double})`

#### Summary

Sets names and multipliers of all units for result visualization

#### Parameter `names`

Unit names for all units (e.g., "Lb" and "Kg")

#### Parameter `multipliers`

Numerical coefficients mapped to unit names.
They adjust measurement values shown in the legend and display (e.g., 1.0 and 0.451 - if actual measurements are in Lb)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

names is zero-length or contains duplicate or empty names
-or-
multipliers contains non-positive numbers, or its length is not equal to the length of names

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisResultSchema)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisResultSchema)`

#### Summary

Determines if the input object is equivalent to this AnalysisResultSchema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.Scale`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.Scale`

#### Summary

Multiplier used for displaying diagram or vector values in view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: scale is zero or negative

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.CurrentUnits`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.CurrentUnits`

#### Summary

Stores the index in the array of applicable units

#### Remarks

Must be between 0 and (number of applicable units - 1)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: currentUnits is not in the range from 0 to (number of applicable units - 1)

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.IsVisible`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.IsVisible`

#### Summary

If true analysis result is visible in view

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.AnalysisDisplayStyleId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.AnalysisDisplayStyleId`

#### Summary

ElementId of analysis display style overriding the style set for view; -1 if the style is not overridden

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.Description`

#### Summary

Description of analysis result in view

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.Name`

#### Summary

Name of analysis result in view

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.#ctor(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.#ctor(System.String,System.String)`

#### Summary

Creates object and assigns name and description

#### Parameter `name`

Name of the result schema

#### Parameter `description`

Description of the result schema

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisResultSchema.#ctor(Autodesk.Revit.DB.Analysis.AnalysisResultSchema)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema.#ctor(Autodesk.Revit.DB.Analysis.AnalysisResultSchema)`

#### Summary

Constructs a new copy of the input AnalysisResultSchema object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.AnalysisResultSchema`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisResultSchema`

#### Summary

Contains all information about one analysis result. Each result may contain several measurements.

#### Remarks

In order to take effect, the AnalysisResultSchema object has to be registered by calling SpatialFieldManager::RegisterResult, which returns result index for future references;
to make changes to the properties of an already registered object, use method SpatialFieldManager::SetResultSchema and supply result index and replacing object.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.IsTextTypeIdValid(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.IsTextTypeIdValid(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document)`

#### Summary

Verify if text type id is valid.

#### Parameter `textTypeId`

Text type id to be validated.

#### Parameter `doc`

Document for which %textTypeId% is validated.

#### Returns

True if text type id is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetDeformedShapeSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetDeformedShapeSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings)`

#### Summary

Set deformed shape settings object for the style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Deformed shape settings were not created with the object.

#### Since

2013

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetDeformedShapeSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetDeformedShapeSettings`

#### Summary

Get deformed shape settings object from the style.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

deformed shape settings were not created with the object.

#### Since

2013

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.HasDeformedShapeSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.HasDeformedShapeSettings`

#### Summary

If true style has deformed shape settings.

#### Since

2013

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetVectorSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetVectorSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings)`

#### Summary

Set vector settings object for the style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Vector settings were not created with the object.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetVectorSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetVectorSettings`

#### Summary

Get vector settings object from the style.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

vector settings were not created with the object.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.HasVectorSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.HasVectorSettings`

#### Summary

If true style has vector settings.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetDiagramSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetDiagramSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings)`

#### Summary

Set diagram settings object for the style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

diagram settings were not created with the object.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetDiagramSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetDiagramSettings`

#### Summary

Get diagram settings object from the style.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

diagram settings were not created with the object.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.HasDiagramSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.HasDiagramSettings`

#### Summary

If true style has diagram settings.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetMarkersAndTextSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetMarkersAndTextSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings)`

#### Summary

Set markers and text settings object for the style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

markers and text settings were not created with the object.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetMarkersAndTextSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetMarkersAndTextSettings`

#### Summary

Get markers and text settings object from the style.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

markers and text settings were not created with the object.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.HasMarkersAndTextSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.HasMarkersAndTextSettings`

#### Summary

If true style has markers and text settings.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetColoredSurfaceSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetColoredSurfaceSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings)`

#### Summary

Set colored surface settings object for the style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

colored surface settings were not created with the object.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetColoredSurfaceSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetColoredSurfaceSettings`

#### Summary

Get colored surface settings object from the style.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

colored surface settings were not created with the object.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.HasColoredSurfaceSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.HasColoredSurfaceSettings`

#### Summary

If true style has colored surface settings.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetLegendSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetLegendSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

#### Summary

Set legend settings object for the style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetLegendSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetLegendSettings`

#### Summary

Get legend settings object from the style.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetColorSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetColorSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings)`

#### Summary

Set color settings object for the style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

for Diagram display style, colorSettings must have type SolidColorRanges and exactly one intermediate entry with zero value

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetColorSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetColorSettings`

#### Summary

Get color settings object from the style.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.IsNameUnique(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.IsNameUnique(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle)`

#### Summary

Verify the uniqueness of the name among all analysis display style elements of the document.

#### Parameter `document`

Document in which name uniqueness is verified.

#### Parameter `name`

Name to verify uniqueness of.

#### Parameter `excludedElement`

Element to be excluded from uniqueness verification (for renaming of an existing element).

#### Returns

True if name is unique, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.SetName(System.String)`

#### Summary

Set name of analysis display style element.

#### Parameter `name`

Analysis display style element name to be set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is not unique in document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.FindByName(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.FindByName(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Finds analysis display style by name.

#### Parameter `document`

Document in which to look for analysis display style element.

#### Parameter `name`

Name of analysis display style to look for.

#### Returns

Element id of the found analysis display style, invalidElementId if not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetElements(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.GetElements(Autodesk.Revit.DB.Document)`

#### Summary

Returns set of all analysis display styles elements in the given document.

#### Parameter `document`

Document from which analysis display style elements are retrieved.

#### Returns

All analysis display style elements existing in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.CreateAnalysisDisplayStyle(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.CreateAnalysisDisplayStyle(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

#### Summary

Factory method - creates analysis display style object of type Deformed Shape for the given document.

#### Parameter `document`

Document for which analysis display style object is created.

#### Parameter `name`

Name of the analysis display style within the %document%.

#### Parameter `deformedShapeSettings`

Deformed Shape settings for the style.

#### Parameter `colorSettings`

Color settings for the style.

#### Parameter `legendSettings`

Legend settings for the style.

#### Returns

New analysis display style object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

document is a family.
-or-
name is not unique in document.

#### Since

2013

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.CreateAnalysisDisplayStyle(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.CreateAnalysisDisplayStyle(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

#### Summary

Factory method - creates analysis display style object of type Vectors for the given document.

#### Parameter `document`

Document for which analysis display style object is created.

#### Parameter `name`

Name of the analysis display style within the %document%.

#### Parameter `vectorSettings`

Vector settings for the style.

#### Parameter `colorSettings`

Color settings for the style.

#### Parameter `legendSettings`

Legend settings for the style.

#### Returns

New analysis display style object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

document is a family.
-or-
name is not unique in document.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.CreateAnalysisDisplayStyle(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.CreateAnalysisDisplayStyle(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

#### Summary

Factory method - creates analysis display style object of type Diagram for the given document.

#### Parameter `document`

Document for which analysis display style object is created.

#### Parameter `name`

Name of the analysis display style within the %document%.

#### Parameter `diagramSettings`

Diagram settings for the style.

#### Parameter `colorSettings`

Color settings for the style.

#### Parameter `legendSettings`

Legend settings for the style.

#### Returns

New analysis display style object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

document is a family.
-or-
name is not unique in document.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.CreateAnalysisDisplayStyle(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.CreateAnalysisDisplayStyle(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

#### Summary

Factory method - creates analysis display style object of type Markers and Text for the given document.

#### Parameter `document`

Document for which analysis display style object is created.

#### Parameter `name`

Name of the analysis display style within the %document%.

#### Parameter `markersAndTextSettings`

Markers and text settings for the style.

#### Parameter `colorSettings`

Color settings for the style.

#### Parameter `legendSettings`

Legend settings for the style.

#### Returns

New analysis display style object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

document is a family.
-or-
name is not unique in document.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.CreateAnalysisDisplayStyle(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle.CreateAnalysisDisplayStyle(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings,Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

#### Summary

Factory method - creates analysis display style object of type Colored Surface for the given document.

#### Parameter `document`

Document for which analysis display style object is created.

#### Parameter `name`

Name of the analysis display style within the %document%.

#### Parameter `coloredSurfaceSettings`

Colored surface settings for the style.

#### Parameter `colorSettings`

Color settings for the style.

#### Parameter `legendSettings`

Legend settings for the style.

#### Returns

New analysis display style object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

document is a family.
-or-
name is not unique in document.

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle`

#### Summary

Exposes API for manipulation of analysis display style.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings)`

#### Summary

Compares two deformed shape settings objects.

#### Parameter `other`

Deformed shape settings object to compare with.

#### Returns

True if objects are equal, false otherwise.

#### Since

2013

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.Transparency`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.Transparency`

#### Summary

Transparency percentage of deformed shape color fill on surfaces

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: transparency is less than 0 or greater than 100

#### Since

2013

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.GridLineWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.GridLineWeight`

#### Summary

Line weight of grid lines.

#### Since

2013

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.GridColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.GridColor`

#### Summary

Color of grid lines.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.Rounding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.Rounding`

#### Summary

Increment to which numeric values of analysis results are rounded in deformed shape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: rounding is not positive

#### Since

2013

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.TextLabelType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.TextLabelType`

#### Summary

Type of deformed shape text visualization.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.TextTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.TextTypeId`

#### Summary

Element id of text associated with the settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.ShowContourLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.ShowContourLines`

#### Summary

If true, show contour lines in the analysis display.

#### Since

2013

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.ShowGridLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.ShowGridLines`

#### Summary

If true, show grid lines in the analysis display.

#### Since

2013

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.#ctor`

#### Summary

Constructs a default instance of deformed shape settings.

#### Since

2013

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings)`

#### Summary

Constructs a new copy of the input AnalysisDisplayDeformedShapeSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings`

#### Summary

Contains deformed shape settings for analysis display style element.

#### Since

2013

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDeformedShapeTextLabelType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDeformedShapeTextLabelType`

#### Summary

Defines text visualization types for deformed shape settings of analysis display style.

#### Since

2013

#### Since

2013

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDeformedShapeTextLabelType.ShowPredefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDeformedShapeTextLabelType.ShowPredefined`

#### Summary

Show deformed shape text label only for points that have flag ValueAtPointFlags::DisplayText

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDeformedShapeTextLabelType.ShowNone`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDeformedShapeTextLabelType.ShowNone`

#### Summary

Don't show deformed shape text labels

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDeformedShapeTextLabelType.ShowAll`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDeformedShapeTextLabelType.ShowAll`

#### Summary

Show vector text label for each point

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings)`

#### Summary

Compares two vector settings objects.

#### Parameter `other`

Vector settings object to compare with.

#### Returns

True if objects are equal, false otherwise.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.ArrowLineWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.ArrowLineWeight`

#### Summary

Line weight assigned to arrow lines for vectors.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.Rounding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.Rounding`

#### Summary

Increment to which numeric values of analysis results are rounded in vectors.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: rounding is not positive

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.VectorOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.VectorOrientation`

#### Summary

Vector orientation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.VectorPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.VectorPosition`

#### Summary

Vector position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.ArrowheadScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.ArrowheadScale`

#### Summary

Type of arrow head scaling.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.VectorTextType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.VectorTextType`

#### Summary

Type of vector text visualization.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.TextTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.TextTypeId`

#### Summary

Element id of text associated with the settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.#ctor`

#### Summary

Constructs a default instance of vector settings.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings)`

#### Summary

Constructs a new copy of the input AnalysisDisplayVectorSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings`

#### Summary

Contains vector settings for analysis display style element.

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorOrientation`

#### Summary

Defines vector orientation for vector settings of analysis display style.

#### Since

2012

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorPosition`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorPosition`

#### Summary

Defines vector position for vector settings of analysis display style.

#### Since

2012

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorArrowheadScale`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorArrowheadScale`

#### Summary

Defines arrow head scaling for vector settings of analysis display style.

#### Since

2012

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorTextType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorTextType`

#### Summary

Defines text visualization types for vector settings of analysis display style.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorTextType.ShowPredefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorTextType.ShowPredefined`

#### Summary

Show vector text label only for points that have flag ValueAtPointFlags::DisplayText

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorTextType.ShowNone`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorTextType.ShowNone`

#### Summary

Don't show vector text labels

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorTextType.ShowAll`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorTextType.ShowAll`

#### Summary

Show vector text label for each point

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings)`

#### Summary

Compares two diagram settings objects.

#### Parameter `other`

Diagram settings object to compare with.

#### Returns

True if objects are equal, false otherwise.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.OutlineLineWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.OutlineLineWeight`

#### Summary

Line weight of outline and fence lines in the diagram.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.OutlineColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.OutlineColor`

#### Summary

Color of outline and fence lines in the diagram.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.Transparency`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.Transparency`

#### Summary

Transparency percentage of diagram color fill

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: transparency is less than 0 or greater than 100

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.Rounding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.Rounding`

#### Summary

Increment to which numeric values of analysis results are rounded in diagram.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: rounding is not positive

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.TextLabelType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.TextLabelType`

#### Summary

Type of diagram text label visualization.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.FenceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.FenceType`

#### Summary

Type of diagram fence visualization.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.TextTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.TextTypeId`

#### Summary

Element id of text associated with the settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.#ctor`

#### Summary

Constructs a default instance of diagram settings.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings)`

#### Summary

Constructs a new copy of the input AnalysisDisplayDiagramSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings`

#### Summary

Contains diagram settings for analysis display style element.

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramTextLabelType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramTextLabelType`

#### Summary

Defines text label visualization types for diagram settings of analysis display style.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramTextLabelType.ShowPredefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramTextLabelType.ShowPredefined`

#### Summary

Show diagram text label only for points that have flag ValueAtPointFlags::DisplayText

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramTextLabelType.ShowNone`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramTextLabelType.ShowNone`

#### Summary

Don't show diagram text labels

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramTextLabelType.ShowAll`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramTextLabelType.ShowAll`

#### Summary

Show diagram text label for each point

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramFenceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramFenceType`

#### Summary

Defines fence visualization types for diagram settings of analysis display style.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramFenceType.ShowPredefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramFenceType.ShowPredefined`

#### Summary

Show fence only for points that have flag ValueAtPointFlags::DisplayFence

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramFenceType.ShowNone`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramFenceType.ShowNone`

#### Summary

Don't show fence

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramFenceType.ShowAll`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramFenceType.ShowAll`

#### Summary

Show fence for each point

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings)`

#### Summary

Compares two colored surface settings objects.

#### Parameter `other`

Markers and text settings object to compare with.

#### Returns

True if objects are equal, false otherwise.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.Rounding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.Rounding`

#### Summary

Increment to which numeric values of analysis results are rounded in markers.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: rounding is not positive

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.MarkerSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.MarkerSize`

#### Summary

Size of marker.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: markerSize is negative

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.TextLabelType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.TextLabelType`

#### Summary

Type of diagram text label visualization.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.MarkerType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.MarkerType`

#### Summary

Type of marker.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.TextTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.TextTypeId`

#### Summary

Element id of text associated with the settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.#ctor`

#### Summary

Constructs a default instance of markers and text settings.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings)`

#### Summary

Constructs a new copy of the input AnalysisDisplayMarkersAndTextSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings`

#### Summary

Contains markers and text settings for analysis display style element.

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerTextLabelType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerTextLabelType`

#### Summary

Text label visualization types for Markers and Text settings of analysis display style.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerTextLabelType.ShowPredefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerTextLabelType.ShowPredefined`

#### Summary

Show text markers only for points that have flag ValueAtPointFlags::DisplayText

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerTextLabelType.ShowNone`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerTextLabelType.ShowNone`

#### Summary

Don't show text markers

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerTextLabelType.ShowAll`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerTextLabelType.ShowAll`

#### Summary

Show text markers for each point

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerType`

#### Summary

Marker types for Markers and Text settings of analysis display style.

#### Since

2011

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings)`

#### Summary

Compares two colored surface settings objects.

#### Parameter `other`

Colored surface settings object to compare with.

#### Returns

True if objects are equal, false otherwise.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.Transparency`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.Transparency`

#### Summary

Transparency percentage of colored surface

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: transparency is less than 0 or greater than 100

#### Since

2019

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.GridLineWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.GridLineWeight`

#### Summary

Line weight of grid lines.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.GridColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.GridColor`

#### Summary

Color of grid lines.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.ShowContourLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.ShowContourLines`

#### Summary

If true, show contour lines in the analysis display.

#### Since

2013

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.ShowGridLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.ShowGridLines`

#### Summary

If true, show grid lines in the analysis display.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.#ctor`

#### Summary

Constructs a default instance of colored surface settings.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings)`

#### Summary

Constructs a new copy of the input AnalysisDisplayColoredSurfaceSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings`

#### Summary

Contains colored surface settings for analysis display style element.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

#### Summary

Compares two legend settings objects.

#### Parameter `other`

Legend settings object to compare to.

#### Returns

True if objects are equal, false otherwise.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.NumberForScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.NumberForScale`

#### Summary

A fixed value to display on the legend scale (0 by default; 0 means width of legend scale is calculated dynamically).

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ScaleHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ScaleHeight`

#### Summary

Height of scale (for Diagram display). Measured in paperspace units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: scaleHeight is greater than 10000 or less than 0

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ColorRangeHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ColorRangeHeight`

#### Summary

Height of color range (for Colored Surface, Markers and Text, and Vector display). Measured in paperspace units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: colorRangeHeight is greater than 10000 or less than 0

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ColorRangeWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ColorRangeWidth`

#### Summary

Width of color range (for Colored Surface, Markers and Text, and Vector display). Measured in paperspace units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: colorRangeWidth is greater than 10000 or less than 0

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.NumberOfSteps`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.NumberOfSteps`

#### Summary

Number of steps (values between minimum and maximum) to be shown in legend.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: numberOfSteps is greater than 1000 or less than 0

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.Rounding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.Rounding`

#### Summary

Rounding increment for numeric values of analysis results.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: rounding is not positive

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ShowDataDescription`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ShowDataDescription`

#### Summary

If true, data description is shown in the legend.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ShowDataName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ShowDataName`

#### Summary

If true, data name is shown in the legend.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ShowUnits`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ShowUnits`

#### Summary

If true, units are shown in the legend.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ShowLegend`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.ShowLegend`

#### Summary

If true, legend is shown in the view.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.HeadingTextTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.HeadingTextTypeId`

#### Summary

Element id of text associated with legend heading.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.TextTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.TextTypeId`

#### Summary

Element id of text associated with legend body.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.#ctor`

#### Summary

Constructs a default instance of legend settings.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings)`

#### Summary

Constructs a new copy of the input AnalysisDisplayLegendSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings`

#### Summary

Contains legend settings for analysis display style element.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings)`

#### Summary

Compares two color settings objects.

#### Parameter `other`

Color settings object to compare to.

#### Returns

True if objects are equal, false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.Colors`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.Colors`

#### Summary

Get number of colors, including min, max and intermediate.

#### Returns

Number of colors, including min, max and intermediate.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.SetIntermediateColors(System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.SetIntermediateColors(System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry})`

#### Summary

Set intermediate color entries (other than the minimum and maximum settings).

#### Parameter `map`

Array of intermediate color entries.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

intermediate color entries with specific values are not ordered by value (min to max) or too many intermediate colors (>100).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.AreIntermediateColorsValid(System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.AreIntermediateColorsValid(System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry})`

#### Summary

Verify intermediate color entries

#### Parameter `map`

Array of intermediate color entries.

#### Returns

True if intermediate colors are valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.GetIntermediateColors`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.GetIntermediateColors`

#### Summary

Get intermediate color entries (other than the minimum and maximum settings).

#### Returns

Array of intermediate color entries.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.ColorSettingsType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.ColorSettingsType`

#### Summary

Stores type of color settings

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.MinColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.MinColor`

#### Summary

Color assigned to the minimum value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.MaxColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.MaxColor`

#### Summary

Color assigned to the maximum value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.#ctor`

#### Summary

Constructs a default instance of color settings.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings.#ctor(Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings)`

#### Summary

Constructs a new copy of the input AnalysisDisplayColorSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings`

#### Summary

Contains color settings for analysis display style element.

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleColorSettingsType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleColorSettingsType`

#### Summary

Defines types for color settings of analysis display style.

#### Since

2011

#### Since

2011

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleColorSettingsType.SolidColorRanges`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleColorSettingsType.SolidColorRanges`

#### Summary

Intermediate and min/max color settings define ranges in which the color is constant.

### `F:Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleColorSettingsType.GradientColor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleColorSettingsType.GradientColor`

#### Summary

Intermediate and min/max color settings are used to interpolate color for values between adjacent entries.

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.HasValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.HasValue`

#### Summary

Check if color entry has associated value.

#### Returns

True if entry has a value associated with it, false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry)`

#### Summary

Compare color entries.

#### Parameter `other`

Color entry to compare to.

#### Returns

True if color entries are equal, false otherwise.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.Color`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.Color`

#### Summary

Color associated with color entry.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.Value`

#### Summary

Value associated with color entry.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.#ctor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.#ctor(Autodesk.Revit.DB.Color)`

#### Summary

Constructs a color entry with no value assigned.

#### Parameter `color`

Color assigned to the entry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.#ctor(Autodesk.Revit.DB.Color,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.#ctor(Autodesk.Revit.DB.Color,System.Double)`

#### Summary

Constructs a color entry with a specific value assigned.

#### Parameter `color`

Color assigned to the entry.

#### Parameter `value`

Value assigned to the entry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry.#ctor`

#### Summary

Constructs a new AnalysisDisplayColorEntry with default settings.

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry`

#### Summary

Contains one entry of intermediate colors in color settings for analysis display style.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegend.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegend.Height`

#### Summary

The height, in sheet size, of the legend's rectangle

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.AnalysisDisplayLegend`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisDisplayLegend`

#### Summary

The legend that describes an Analysis Visualization.

#### Since

2011

### `T:Autodesk.Revit.DB.AlternateUnits`

Member kind: type
Symbol: `Autodesk.Revit.DB.AlternateUnits`

#### Summary

An enumerated type listing the locations where Alternate units may be displayed in dimensions.

### `F:Autodesk.Revit.DB.AlternateUnits.Below`

Member kind: field
Symbol: `Autodesk.Revit.DB.AlternateUnits.Below`

#### Summary

Alternative units display below the primary units.

### `F:Autodesk.Revit.DB.AlternateUnits.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.AlternateUnits.Right`

#### Summary

Alternative units display to the right of the primary units.

### `F:Autodesk.Revit.DB.AlternateUnits.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.AlternateUnits.None`

#### Summary

No alternative units.

### `T:Autodesk.Revit.DB.AllowedValues`

Member kind: type
Symbol: `Autodesk.Revit.DB.AllowedValues`

#### Since

2014

#### Summary

A range of allowed values.

#### Since

2014

### `F:Autodesk.Revit.DB.AllowedValues.Positive`

Member kind: field
Symbol: `Autodesk.Revit.DB.AllowedValues.Positive`

#### Summary

Only positive values are allowed. A tolerance of 1.0e-9 is used, so very small positive numbers are rejected.

### `F:Autodesk.Revit.DB.AllowedValues.All`

Member kind: field
Symbol: `Autodesk.Revit.DB.AllowedValues.All`

#### Summary

All values are allowed.

### `F:Autodesk.Revit.DB.AllowedValues.NonNegative`

Member kind: field
Symbol: `Autodesk.Revit.DB.AllowedValues.NonNegative`

#### Summary

Only non-negative values are allowed. A tolerance of 1.0e-9 is used, so very small negative numbers are accepted.

### `M:Autodesk.Revit.DB.AlignmentStationLabelSetOptionDefaults.GetDefaultOffsetValue(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AlignmentStationLabelSetOptionDefaults.GetDefaultOffsetValue(Autodesk.Revit.DB.Document)`

#### Summary

Get the default offset value for the current length unit type in the document.
The return value is in internal units (standard imperial feet).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021.1

### `M:Autodesk.Revit.DB.AlignmentStationLabelSetOptionDefaults.GetDefaultIntervalValue(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AlignmentStationLabelSetOptionDefaults.GetDefaultIntervalValue(Autodesk.Revit.DB.Document)`

#### Summary

Get the default interval value for the current stationing unit type in the document.
The return value is in internal units (standard imperial feet).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021.1

### `T:Autodesk.Revit.DB.AlignmentStationLabelSetOptionDefaults`

Member kind: type
Symbol: `Autodesk.Revit.DB.AlignmentStationLabelSetOptionDefaults`

#### Summary

An utility class for querying the default values of alignment station label set options.

#### Since

2021.1

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Status`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Status`

#### Summary

The request execution status for the service.

#### Since

2021

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Perpendicular`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Perpendicular`

#### Summary

Perpendicular to the instanteneous tangent at point on geometry to pass

#### Since

2021

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Tangent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Tangent`

#### Summary

Instanteneous tangent at point on geometry to pass

#### Since

2021

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.PointOnGeometry`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.PointOnGeometry`

#### Summary

Point on geometry to pass

#### Since

2021

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Point`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Point`

#### Summary

Point to pass

#### Since

2021

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Station`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Station`

#### Summary

Station value to pass

#### Since

2021

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Distance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Distance`

#### Summary

Distance value to pass

#### Since

2021

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Document`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Document`

#### Summary

Document containing alignment

#### Since

2021

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.DefaultLabelSetTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.DefaultLabelSetTypeId`

#### Summary

Default type for label set creation

#### Since

2021

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.ElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.ElementId`

#### Summary

Element associated with the Alignment

#### Since

2021

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Request`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.Request`

#### Summary

The request type for the service.

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData.#ctor`

#### Summary

Initializes to a default, unusable state; Revit needs to make it usable
before passing it to the IInfrastructureAlignmentServer instance.

#### Since

2021

### `T:Autodesk.Revit.DB.Infrastructure.AlignmentServiceData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceData`

#### Summary

This is a data container used to collect information from an IAlignmentServer
for a given Alignment

#### Since

2021

### `T:Autodesk.Revit.DB.Infrastructure.AlignmentServiceStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceStatus`

#### Summary

An enumerated type containing possible request processing statuses for an IAlignmentServer

#### Since

2021

#### Since

2021

### `F:Autodesk.Revit.DB.Infrastructure.AlignmentServiceStatus.ErrorOutsideGeometryRange`

Member kind: field
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceStatus.ErrorOutsideGeometryRange`

#### Summary

Request provided data outside geometry range

### `F:Autodesk.Revit.DB.Infrastructure.AlignmentServiceStatus.Failure`

Member kind: field
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceStatus.Failure`

#### Summary

Request failed

### `F:Autodesk.Revit.DB.Infrastructure.AlignmentServiceStatus.Success`

Member kind: field
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceStatus.Success`

#### Summary

Request executed successfully

### `T:Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest`

Member kind: type
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest`

#### Summary

An enumerated type containing possible requests for an IAlignmentServer

#### Since

2021

#### Since

2021

### `F:Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest.GetOrCreateDefaultLabelSetType`

Member kind: field
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest.GetOrCreateDefaultLabelSetType`

#### Summary

Get the type with default settings for creating a label set.
If one does not exist, create it.

### `F:Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest.SetInSessionDefaultLabelSetTypeId`

Member kind: field
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest.SetInSessionDefaultLabelSetTypeId`

#### Summary

Set in-session default type for creating a label set

### `F:Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest.GetInSessionDefaultLabelSetTypeId`

Member kind: field
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest.GetInSessionDefaultLabelSetTypeId`

#### Summary

Get in-session default type for creating a label set

### `F:Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest.GetValuesByStation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest.GetValuesByStation`

#### Summary

Get distance and point on geometry by station

### `F:Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest.GetValuesByPoint`

Member kind: field
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest.GetValuesByPoint`

#### Summary

Get distance, station value and point on geometry by point

### `F:Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest.GetValuesByDistance`

Member kind: field
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServiceRequest.GetValuesByDistance`

#### Summary

Get station value and point on geometry by alignment distance

### `M:Autodesk.Revit.DB.Infrastructure.AlignmentCell.SetDisplayedEndStation(Autodesk.Revit.DB.Element,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentCell.SetDisplayedEndStation(Autodesk.Revit.DB.Element,System.Double)`

#### Summary

An internal setter for the alignment's "Displayed End Station" parameter.
Supports setting the member variable and touching the appropriate atom.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.AlignmentCell.SetDisplayedStartStation(Autodesk.Revit.DB.Element,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentCell.SetDisplayedStartStation(Autodesk.Revit.DB.Element,System.Double)`

#### Summary

An internal setter for the alignment's "Displayed Start Station" parameter.
Supports setting the member variable and touching the appropriate atom.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.AlignmentCell.SetDescription(Autodesk.Revit.DB.Element,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentCell.SetDescription(Autodesk.Revit.DB.Element,System.String)`

#### Summary

An internal setter for the alignment's "Description" parameter.
Supports setting the member variable and touching the appropriate atom.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.AlignmentCell.SetName(Autodesk.Revit.DB.Element,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentCell.SetName(Autodesk.Revit.DB.Element,System.String)`

#### Summary

An internal setter for the alignment's "Name" parameter.
Supports setting the member variable and touching the appropriate atom.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.AlignmentCell.AttachCell(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentCell.AttachCell(Autodesk.Revit.DB.Element)`

#### Summary

An internal creation method to create and attach cell to the specified DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentCell.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentCell.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Infrastructure.AlignmentCell`

Member kind: type
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentCell`

#### Summary

A cell to customize the behavior of elements of category OST_Alignments.

#### Since

2021

### `P:Autodesk.Revit.DB.Mechanical.AirSystemData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.AirSystemData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.AirSystemData.AirFanType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.AirSystemData.AirFanType`

#### Summary

The fan type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.AirSystemData.ChilledWaterLoopId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.AirSystemData.ChilledWaterLoopId`

#### Summary

The chilled water loop used for the chilled water option of cooling coil.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.AirSystemData.CoolingCoilType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.AirSystemData.CoolingCoilType`

#### Summary

The cooling coil type. Note this property change would reset the chilled water loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.AirSystemData.HeatingHotWaterLoopId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.AirSystemData.HeatingHotWaterLoopId`

#### Summary

The water loop element id for the hot-water heating coil.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.AirSystemData.HeatingCoilType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.AirSystemData.HeatingCoilType`

#### Summary

The heating coil type. Note this property change would reset the heating water loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.AirSystemData.PreheatHotWaterLoopId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.AirSystemData.PreheatHotWaterLoopId`

#### Summary

The water loop element id for the hot-water preheat coil.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.AirSystemData.PreheatCoilType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.AirSystemData.PreheatCoilType`

#### Summary

The preheat coil type. Note this property change would reset the preheat water loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.AirSystemData.HeatExchangerType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.AirSystemData.HeatExchangerType`

#### Summary

The type of heat exchanger.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020.1

### `T:Autodesk.Revit.DB.Mechanical.AirSystemData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.AirSystemData`

#### Summary

Represents the data and parameter of analytical air system.

#### Since

2020.1

### `T:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType`

#### Summary

The type of electrical analytical node.

#### Since

2023

### `F:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType.EquipmentLoad`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType.EquipmentLoad`

#### Summary

Equipment Load

### `F:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType.TransferSwitch`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType.TransferSwitch`

#### Summary

Transfer Switch

### `F:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType.Transformer`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType.Transformer`

#### Summary

Transformer

### `F:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType.Bus`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType.Bus`

#### Summary

Bus

### `F:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType.PowerSource`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType.PowerSource`

#### Summary

Power Source

### `T:Autodesk.Revit.DB.Mechanical.ZoneEquipmentBehavior`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentBehavior`

#### Summary

The behavior of zone equipment associated with spaces.

#### Since

2020

### `T:Autodesk.Revit.DB.Mechanical.ZoneEquipmentHvacType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentHvacType`

#### Summary

The type of zone equipment.

#### Since

2020

### `T:Autodesk.Revit.DB.Mechanical.AirFanType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.AirFanType`

#### Summary

The type of air fan.

#### Since

2020

### `T:Autodesk.Revit.DB.Mechanical.AirCoolingCoilType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.AirCoolingCoilType`

#### Summary

The type of air cooling coil.

#### Since

2020

### `T:Autodesk.Revit.DB.Mechanical.AirHeatingCoilType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.AirHeatingCoilType`

#### Summary

The type of air heating coil.

#### Since

2020

### `T:Autodesk.Revit.DB.Mechanical.AirHeatExchangerType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.AirHeatExchangerType`

#### Summary

The type of air loop.

#### Since

2020

### `T:Autodesk.Revit.DB.Mechanical.WaterChillerType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.WaterChillerType`

#### Summary

The type of water chiller.

#### Since

2020

### `T:Autodesk.Revit.DB.Mechanical.WaterLoopType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.WaterLoopType`

#### Summary

The type of water loop.

#### Since

2020

### `T:Autodesk.Revit.DB.Mechanical.AnalyticalSystemDomain`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.AnalyticalSystemDomain`

#### Summary

The domain type of analytical system.

#### Since

2020
