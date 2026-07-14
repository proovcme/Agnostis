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
Shard: 48
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.Curve.SetGraphicsStyleId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.SetGraphicsStyleId(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the graphics style id for this curve.

#### Remarks

If the curve is marked as read-only (because it was extracted directly from
a Revit element or collection/aggregation object), calling this method
causes the object to be changed to carry a disconnected copy of the original curve. The
modification will not affect the original curve or the object that supplied it.

Many methods in the Revit API will not use the graphics style associated to this curve. For
example, curves used as portions of the sketch of an element will not read this property.
Newly created curve elements
will not use this value either, as they inherit their graphical properties from their associated category.

#### Parameter `id`

The id of the GraphicsStyle element from which to apply the curve properties.

### `M:Autodesk.Revit.DB.Curve.Clone`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.Clone`

#### Summary

Returns a copy of this curve.

#### Returns

A copy of this curve.

### `M:Autodesk.Revit.DB.Curve.Project(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.Project(Autodesk.Revit.DB.XYZ)`

#### Summary

Projects the specified point on this curve.

#### Parameter `point`

The point to be projected.

#### Returns

Geometric information if projection is successful.

#### Remarks

The following is the meaning of every IntersectionResult's members:
XYZPoint is the nearest point on the curve;

Parameter is the unnormalized parameter on the curve (use ComputeNormalizedParameter to compute the normalized value)

Distance is the distance from the point to the curve (equivalent to Distance).

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the curve is an arc and either its radius is zero or the input point is the center of the arc.
Thrown when the curve is an elliptical arc and the input point is one of the foci of the elliptical arc.

### `M:Autodesk.Revit.DB.Curve.Intersect(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.IntersectionResultArray@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.Intersect(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.IntersectionResultArray@)`

#### Summary

Calculates the intersection of this curve with the specified curve and returns the intersection results.

#### Parameter `curve`

The specified curve to intersect with this curve.

#### Parameter `resultArray`

Provides more information about the intersection.

#### Returns

SetComparisonResult.Overlap - One or more intersections were encountered. The output argument has the details.

SetComparisonResult.Subset - The inputs are parallel lines with only one common intersection point, or
the curve used to invoke the intersection check is a line entirely within the unbound line passed as argument curve.
If the former, the output argument has the details of the intersection point.

SetComparisonResult.Superset - The input curve is entirely within the unbound line used to invoke the intersection check.

SetComparisonResult.Disjoint - There is no intersection found between the two curves.

SetComparisonResult.Equal - The two curves are identical.

#### Remarks

The array of the intersection results contains one entry for each point where curves intersect.
The following is the meaning of IntersectionResult members:
XYZPoint is the evaluated intersection point

UVPoint.U is the unnormalized parameter on this curve (use ComputeNormalizedParameter to compute the normalized value).

UVPoint.V is the unnormalized parameter on the specified curve (use ComputeNormalizedParameter to compute the normalized value).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the specified curve is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when failed to calculate the intersection.

### `M:Autodesk.Revit.DB.Curve.Intersect(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.Intersect(Autodesk.Revit.DB.Curve)`

#### Overloads

Calculates the intersection of this curve with the specified curve.

#### Summary

Calculates the intersection of this curve with the specified curve.

#### Parameter `curve`

The specified curve to intersect with this curve.

#### Returns

SetComparisonResult.Overlap - One or more intersections were encountered.

SetComparisonResult.Subset - The inputs are parallel lines with only one common intersection point, or
the curve used to invoke the intersection check is a line entirely within the unbound line passed as argument curve.

SetComparisonResult.Superset - The input curve is entirely within the unbound line used to invoke the intersection check.

SetComparisonResult.Disjoint - There is no intersection found between the two curves.

SetComparisonResult.Equal - The two curves are identical.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

The specified curve is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to calculate the intersection.

### `M:Autodesk.Revit.DB.Curve.IsInside(System.Double,System.Int32@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.IsInside(System.Double,System.Int32@)`

#### Summary

Indicates whether the specified parameter value is within this curve's bounds and outputs the end index.

#### Parameter `parameter`

The raw curve parameter to be evaluated.

#### Parameter `end`

The end index is equal to 0 for the start point, 1 for the end point, or -1 if the parameter is not at the end.

#### Returns

True if the parameter is within the curve's bounds, otherwise false.

#### Remarks

Always returns true if this curve is unbound.

### `M:Autodesk.Revit.DB.Curve.IsInside(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.IsInside(System.Double)`

#### Overloads

Indicates whether the specified parameter value is within this curve's bounds.

#### Summary

Indicates whether the specified parameter value is within this curve's bounds.

#### Parameter `parameter`

The raw curve parameter to be evaluated.

#### Returns

True if the parameter is within the bounds, otherwise false.

#### Remarks

Always returns true if this curve is unbound.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the specified parameter is infinite.

### `M:Autodesk.Revit.DB.Curve.ComputeDerivatives(System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.ComputeDerivatives(System.Double,System.Boolean)`

#### Summary

Returns the vectors describing the curve at the specified parameter.

#### Remarks

The following is the meaning of the transformation members:
Origin is the point on the curve (equivalent to `M:Autodesk.Revit.DB.Curve.Evaluate(System.Double,System.Boolean)` ).

BasisX is the tangent vector (the first derivative).

BasisY is the second derivative. Note that for curves where this cannot be uniquely determined (e.g. lines), this will be a Zero vector.

BasisZ is the bi-normal vector (tangent x normal). Note that for curves where normal cannot be uniquely determined (e.g. lines), this will be a Zero vector.
None of the vectors are normalized.

#### Parameter `parameter`

The parameter to be evaluated.

#### Parameter `normalized`

If false, param is interpreted as natural parameterization of the curve.
If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.

#### Returns

The transformation containing the point on the curve, the tangent vector, derivative of tangent vector, and bi-normal vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for parameter is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The curve cannot be evaluated as normalized because it is unbound.
-or-
The parameter is not a valid value for normalized evaluation.

### `M:Autodesk.Revit.DB.Curve.CreateOffset(System.Double,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.CreateOffset(System.Double,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new curve that is an offset of the existing curve.

#### Remarks

The offset curve is obtained by moving the points of the given curve by a certain distance (not necessarily the input distance)
to the right relative to the reference vector. If the distance is negative, then the offset will be actually on the left side.
The precise role played by the reference vector depends on the curve type in an inconsistent way,
as specified in detail below. We plan to update this function to have a more consistent and understandable behavior.

For Line, HermiteSpline, NurbSpline and Cylindrical Helix, the right direction
is along the cross product of the tangent at that point and the reference vector.
In other words, the "right" side of the curve at a given point on the curve is defined with the reference vector
being thought of as the upward direction and curve tangent being thought of as the forward direction,
as if you are walking along the curve with your body aligned to the reference vector.

For Arc and Ellipse, the right direction is defined relative to the axis of the arc or ellipse
in conjunction with the reference vector. If the dot product of the reference vector with the axis is positive,
then the right direction is along the cross product of the curve tangent the axis.
If the dot product is negetive, then it is in the other way.
If the dot product is zero, then it is an input error.

More details of the behavior depending on the type of curve:
Line:
For a Line, a vecPerp is computed as the cross product of the line direction and the reference vector.
The offset is obtained by moving the line by the given distance along the direction of the vecPerp.
Note: vecPerp can be zero vector if the reference vector is parallel to the line direction.
In that case, the offset is simply a copy of the given line. No error is reported.

Arc:
For an Arc, the offset is done in the plane of the arc.
The resulting offset is another arc in the same plane as the given arc and with the same center.
The radius is increased or decreased by the offset distance depending on the offset is to the right or left.
The reference vector is used to determine if the offset is to be done to the right or left of the arc,
based on the dot product of the reference vector with the axis (normal vector) of the arc.
If the dot product is positive then the offset is to the right relative to the axis of the arc; if not, it is to the left.
If the dot product is zero, that is, reference vector is perpendicular to the axis, the function will return NULL and report an error.

Ellipse:
An Ellipse is also a planar curve like the Arc. The offset is done in the plane of the ellipse.
Note that the offset of an ellipse is not an ellipse in general. It will be approximated by a Hermite spline curve.
The offset curve is obtained by offsetting the points of the ellipse, by the given offset distance, to the
right or left relative to the axis (normal vector) of the ellipse.
The reference vector is used to determine if the offset is to be done to the right or left of the ellipse,
based on the dot product of the reference vector with the axis of the ellipse.
If the dot product is positive then the offset is to the right relative to the axis of the ellipse; if not, it is to the left.
If the dot product is zero, that is, reference vector is perpendicular to the axis, the function will return NULL and report an error.

HermiteSpline, NurbSpline and Cylindrical Helix:
A Hermite or Nurbs spline curve can be planar or non-planar; a cylindrical helix is non-planar.
For these three types of curves, the offset is computed in a general way as follows:
Let P be a point on the given curve and let T be the unit tangent vector at P, assuming that the derivative
of the curve at P is not zero. The offset vector at P is the cross product of T and the reference vector.
Then the offset point Q corresponding to P is computed as:
Q = P + (offset distance) * (offset vector at P).
The offset depends on the magnitude as well as the direction of the reference vector.
If the magnitude of the reference vector is not one, then the actual distance moved will not be the given offset distance.
NOTE: If the curve is a planar Hermite or Nurbs spline curve, the offset curve may not lie on the same plane –
unlike the case of arc and ellipse.

#### Parameter `offsetDist`

The signed distance that controls the offset.

#### Parameter `referenceVector`

A reference vector to define the offset direction.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot create the offset of the curve.

#### Returns

The new curve.

#### Since

2015

### `M:Autodesk.Revit.DB.Curve.CreateReversed`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.CreateReversed`

#### Summary

Creates a new curve with the opposite orientation of the existing curve.

#### Returns

The new curve.

#### Since

2015

### `M:Autodesk.Revit.DB.Curve.CreateTransformed(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.CreateTransformed(Autodesk.Revit.DB.Transform)`

#### Summary

Crates a new instance of a curve as a transformation of this curve.

#### Parameter `transform`

The transform to apply.

#### Returns

The new curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

transform is not conformal.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2014

### `P:Autodesk.Revit.DB.Curve.Period`

Member kind: property
Symbol: `Autodesk.Revit.DB.Curve.Period`

#### Summary

The period of this curve.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the curve is not cyclic.

### `P:Autodesk.Revit.DB.Curve.IsCyclic`

Member kind: property
Symbol: `Autodesk.Revit.DB.Curve.IsCyclic`

#### Summary

The boolean value that indicates whether this curve is cyclic.

#### Returns

True if this curve is cyclic; otherwise, false.

### `M:Autodesk.Revit.DB.Curve.Distance(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.Distance(Autodesk.Revit.DB.XYZ)`

#### Summary

Returns the shortest distance from the specified point to this curve.

#### Parameter `point`

The specified point.

#### Returns

The real number equal to the shortest distance.

#### Remarks

Returns the distance from the closest point on the curve to the specified point.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when failed to find the closest point on the curve.

### `P:Autodesk.Revit.DB.Curve.Length`

Member kind: property
Symbol: `Autodesk.Revit.DB.Curve.Length`

#### Summary

The exact length of the curve.

#### Remarks

Computes the length of the curve using analytical or numeric
integration. There is no performance hit for lines and arcs.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the curve is unbound and not periodic.

### `P:Autodesk.Revit.DB.Curve.ApproximateLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Curve.ApproximateLength`

#### Summary

The approximate length of the curve.

#### Remarks

Quickly estimates the length of the curve, may deviate by a factor of 2 in some cases.
The computation is exact for lines and arcs.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the curve is unbound and not periodic.

### `M:Autodesk.Revit.DB.Curve.ComputeRawParameter(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.ComputeRawParameter(System.Double)`

#### Summary

Computes the raw parameter from the normalized parameter.

#### Parameter `normalizedParameter`

The normalized parameter.

#### Returns

The real number equal to the raw curve parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when normalizedParameter is infinite.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the curve is unbound.

### `M:Autodesk.Revit.DB.Curve.ComputeNormalizedParameter(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.ComputeNormalizedParameter(System.Double)`

#### Summary

Computes the normalized curve parameter from the raw parameter.

#### Parameter `rawParameter`

The raw parameter.

#### Returns

The real number equal to the normalized curve parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when rawParameter is infinite.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the curve is unbound.

### `M:Autodesk.Revit.DB.Curve.MakeUnbound`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.MakeUnbound`

#### Summary

Makes this curve unbound.

#### Remarks

If the curve is marked as read-only (because it was extracted directly from
a Revit element or collection/aggregation object), calling this method
causes the object to be changed to carry a disconnected copy of the original curve. The
modification will not affect the original curve or the object that supplied it.

### `M:Autodesk.Revit.DB.Curve.MakeBound(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.MakeBound(System.Double,System.Double)`

#### Summary

Changes the bounds of this curve to the specified values.

#### Remarks

If the curve is marked as read-only (because it was extracted directly from
a Revit element or collection/aggregation object), calling this method
causes the object to be changed to carry a disconnected copy of the original curve. The
modification will not affect the original curve or the object that supplied it.

#### Parameter `startParameter`

The new parameter of the start point.

#### Parameter `endParameter`

The new parameter of the end point.

#### Remarks

This method changes this curve to bound.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the specified values are infinite.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when endParameter is smaller than startParameter.

### `M:Autodesk.Revit.DB.Curve.GetEndParameter(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.GetEndParameter(System.Int32)`

#### Summary

Returns the raw parameter value at the start or end of this curve.

#### Remarks

The start and end value of the parameter can be any value (as it is determined by the system based on the inputs).
For curves with regular curvature like lines and arcs, the raw parameter can be used to measure along the curve in Revit's default units (feet).
Raw parameters are also the only way to evaluate points along unbound curves.

#### Parameter `index`

0 for the start or 1 for end of the curve.

#### Returns

The parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

curve is unbound and does not have start and end points.
-or-
index must be 0 for the start of the curve or 1 for the end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2014

### `M:Autodesk.Revit.DB.Curve.GetEndPointReference(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.GetEndPointReference(System.Int32)`

#### Summary

Returns a stable reference to the start point or the end point of the curve.

#### Parameter `index`

Use 0 for the start point; 1 for the end point.

#### Returns

Reference to the point or `null` if reference cannot be obtained.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the specified index is not 0 or 1.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the object is internally marked as read-only or this curve is unbound.

#### Since

2014

### `M:Autodesk.Revit.DB.Curve.GetEndPoint(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.GetEndPoint(System.Int32)`

#### Summary

Returns the 3D point at the start or end of this curve.

#### Parameter `index`

0 for the start or 1 for end of the curve.

#### Returns

The curve endpoint.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

curve is unbound and does not have start and end points.
-or-
index must be 0 for the start of the curve or 1 for the end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2014

### `P:Autodesk.Revit.DB.Curve.Reference`

Member kind: property
Symbol: `Autodesk.Revit.DB.Curve.Reference`

#### Summary

Returns a stable reference to the curve.

#### Value

This value is set for curve geometry obtained from Revit elements.
`null` if the curve was created via parameters, copying, transform, or other operations.

#### Remarks

This value is also if the corresponding geometry object does not permit referencing.

### `M:Autodesk.Revit.DB.Curve.Evaluate(System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.Evaluate(System.Double,System.Boolean)`

#### Summary

Evaluates and returns the point that matches a parameter along the curve.

#### Parameter `parameter`

The parameter to be evaluated.

#### Parameter `normalized`

If false, param is interpreted as natural parameterization of the curve.
If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.

#### Returns

The point evaluated along the curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for parameter is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The curve cannot be evaluated as normalized because it is unbound.
-or-
The parameter is not a valid value for normalized evaluation.

### `M:Autodesk.Revit.DB.Curve.Tessellate`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.Tessellate`

#### Summary

Valid only if the curve is bound. Returns a polyline approximation to the curve.

#### Remarks

Tolerance of approximation is defined internally by Revit to be adequate for
display purposes.

### `P:Autodesk.Revit.DB.Curve.IsClosed`

Member kind: property
Symbol: `Autodesk.Revit.DB.Curve.IsClosed`

#### Summary

Describes whether the curve is closed.

#### Remarks

A curve is "closed" if it is bounded and its start and end points coincide (to within Revit's 3D tolerance),
or if it is unbounded and periodic.

#### Since

2021

### `P:Autodesk.Revit.DB.Curve.IsBound`

Member kind: property
Symbol: `Autodesk.Revit.DB.Curve.IsBound`

#### Summary

Describes whether the parameter of the curve is restricted to a particular interval.

### `T:Autodesk.Revit.DB.Curve`

Member kind: type
Symbol: `Autodesk.Revit.DB.Curve`

#### Summary

A parametric curve.

#### Remarks

The concrete curves are defined by parametric equations. If the curve is
bound, it is only defined for an interval in parameterization. Otherwise, it is
defined for all values of the parameter.

### `M:Autodesk.Revit.DB.CopyPasteOptions.SetDuplicateTypeNamesHandler(Autodesk.Revit.DB.IDuplicateTypeNamesHandler)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CopyPasteOptions.SetDuplicateTypeNamesHandler(Autodesk.Revit.DB.IDuplicateTypeNamesHandler)`

#### Summary

Sets a custom duplicate type names handler. If this value is not set, the default handler is used.
By default, Revit displays a modal dialog with options to either copy new types only, or cancel the operation.

#### Parameter `handler`

The duplicate type names handler.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.CopyPasteOptions.GetDuplicateTypeNamesHandler`

Member kind: method
Symbol: `Autodesk.Revit.DB.CopyPasteOptions.GetDuplicateTypeNamesHandler`

#### Summary

Returns current duplicate type names handler or `null` if none is set.

#### Since

2014

### `P:Autodesk.Revit.DB.CopyPasteOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CopyPasteOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.CopyPasteOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CopyPasteOptions.#ctor`

#### Summary

Creates a new instance of a CopyPasteOptions object.

#### Since

2014

### `T:Autodesk.Revit.DB.CopyPasteOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.CopyPasteOptions`

#### Summary

Settings to control the behavior of a copy-paste operation.

#### Since

2014

### `M:Autodesk.Revit.DB.ElementTransformUtils.GetTransformFromViewToView(Autodesk.Revit.DB.View,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementTransformUtils.GetTransformFromViewToView(Autodesk.Revit.DB.View,Autodesk.Revit.DB.View)`

#### Summary

Returns a transformation that is applied to elements when copying from one view to another view.

#### Remarks

Both source and destination views must be 2D graphics views capable of drawing details and view-specific elements (floor and ceiling plans, elevations, sections, drafting views.)
The result is a transformation needed to copy an element from drawing plane of the source view to the drawing plane of the destination view.
The destination view can be in the same document as the source view.
The destination view can be the same as the source view.

#### Parameter `sourceView`

The source view

#### Parameter `destinationView`

The destination view

#### Returns

The transformation from source view to destination view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The specified view cannot be used as a source or destination for copying elements between two views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ElementTransformUtils.CopyElements(Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.View,Autodesk.Revit.DB.Transform,Autodesk.Revit.DB.CopyPasteOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementTransformUtils.CopyElements(Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.View,Autodesk.Revit.DB.Transform,Autodesk.Revit.DB.CopyPasteOptions)`

#### Summary

Copies a set of elements from source view to destination view.

#### Remarks

This method can be used for both view-specific and model elements.

Both source and destination views must be 2D graphics views capable of drawing details and view-specific elements (floor and ceiling plans, elevations, sections, drafting views.)
Drafting views cannot be used as a destination for model elements.

The pasted elements are repositioned to ensure proper placement in the destination view (e.g. elevation is changed when copying from a level to a different level.)
Additional transformation within the destination view can be performed by providing additionalTransform argument. This additional transformation must be within the plane of the destination view.

The destination view can be in the same document as the source view.

The destination view can be the same as the source view.

All view-specific elements in the set must be specific to the source view. Elements specific to views other than the source view or to multiple views cannot be copied.

This method performs rehosting of elements where applicable.

#### Parameter `sourceView`

The view in the source document that contains the elements to copy.

#### Parameter `elementsToCopy`

The set of elements to copy.

#### Parameter `destinationView`

The view in the destination document that the elements will be pasted into.

#### Parameter `additionalTransform`

The transform for the new elements, in addition to the transformation between the source and destination views. Can be `null` if no transform is required. The transformation must be within the plane of the destination view.

#### Parameter `options`

Optional settings. Can be `null` if default settings should be used.

#### Returns

The ids of the newly created copied elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element id set is empty.
-or-
The specified view cannot be used as a source or destination for copying elements between two views.
-or-
Some of the elements cannot be copied, because they belong to a different document.
-or-
Some of the elements cannot be copied, because they belong to a different view.
-or-
The elements cannot be copied into the destination view. Drafting views cannot contain model elements.
-or-
The transformation is not within the plane of the destination view.
-or-
The input set of elements contains Sketch members along with other elements and the Sketch Id of those members isn't in the set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

It is not allowed to copy Sketch members between non-parallel sketches.
-or-
The elements cannot be copied.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

User cancelled the operation.

#### Since

2014

### `M:Autodesk.Revit.DB.ElementTransformUtils.CopyElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Transform,Autodesk.Revit.DB.CopyPasteOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementTransformUtils.CopyElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Transform,Autodesk.Revit.DB.CopyPasteOptions)`

#### Summary

Copies a set of elements from source document to destination document.

#### Remarks

Copies are placed at their respective original locations or locations specified by the optional transformation.

This method can be used for copying non-view specific elements only. For copying view-specific elements, use the view-specific form of the CopyElements method.

The destination document can be the same as the source document.

This method performs rehosting of elements where applicable.

#### Parameter `sourceDocument`

The document that contains the elements to copy.

#### Parameter `elementsToCopy`

The set of elements to copy.

#### Parameter `destinationDocument`

The destination document to paste the elements into.

#### Parameter `transform`

The transform for the new elements. Can be `null` if no transform is required.

#### Parameter `options`

Optional settings. Can be `null` if default settings should be used.

#### Returns

The ids of the newly created copied elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element id set is empty.
-or-
One or more elements in elementsToCopy do not exist in the document.
-or-
Some of the elements cannot be copied, because they are view-specific.
-or-
The input set of elements contains Sketch members along with other elements or there is no active Sketch edit mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

It is not allowed to copy Sketch members between non-parallel sketches.
-or-
The elements cannot be copied.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

User cancelled the operation.

#### Since

2014

### `M:Autodesk.Revit.DB.ElementTransformUtils.RotateElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Line,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementTransformUtils.RotateElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Line,System.Double)`

#### Summary

Rotates an element about the given axis and angle.

#### Parameter `document`

The document that owns the elements.

#### Parameter `elementToRotate`

The element to rotate.

#### Parameter `axis`

The axis of rotation.

#### Parameter `angle`

The angle of rotation in radians.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementToRotate does not exist in the document

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ElementTransformUtils.RotateElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.Line,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementTransformUtils.RotateElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.Line,System.Double)`

#### Summary

Rotates a set of elements about the given axis and angle.

#### Parameter `document`

The document that owns the elements.

#### Parameter `elementsToRotate`

The set of elements to rotate.

#### Parameter `axis`

The axis of rotation.

#### Parameter `angle`

The angle of rotation in radians.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element id set is empty.
-or-
One or more elements in elementsToRotate do not exist in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ElementTransformUtils.MirrorElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Plane)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementTransformUtils.MirrorElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Plane)`

#### Summary

Creates a mirrored copy of an element about a given plane.

#### Parameter `document`

The document that owns the element.

#### Parameter `elementToMirror`

The element to mirror.

#### Parameter `plane`

The mirror plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

elementToMirror cannot be mirrored.
-or-
The element elementToMirror does not exist in the document
-or-
The input element is a Sketch member and there is no Sketch in the edit mode to place this element in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ElementTransformUtils.MirrorElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.Plane,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementTransformUtils.MirrorElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.Plane,System.Boolean)`

#### Summary

Mirrors a set of elements about a given plane.

#### Remarks

Optionally, copies of the elements can be created prior to the operation and mirroring is then performed on the copies instead of the original elements.

#### Parameter `document`

The document that owns the elements.

#### Parameter `elementsToMirror`

The set of elements to mirror.

#### Parameter `plane`

The mirror plane.

#### Parameter `mirrorCopies`

True if mirroring should be performed on copies of the elements, leaving the original elements intact.
False if no copies should be created and the elements should be mirrored directly.

#### Returns

A collection of ids of newly created elements - mirrored copies. It is empty if the mirrorCopies arguments is false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

elementsToMirror cannot be mirrored.
-or-
The given element id set is empty.
-or-
One or more elements in elementsToMirror do not exist in the document.
-or-
Some of the elements cannot be copied, because they belong to different views.
-or-
The input set of elements contains Sketch members along with other elements or there is no active Sketch edit mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the elements cannot be moved (e.g. due to some of the elements being pinned).

#### Since

2016

### `M:Autodesk.Revit.DB.ElementTransformUtils.CopyElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementTransformUtils.CopyElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

#### Summary

Copies an element and places the copy at a location indicated by a given transformation.

#### Parameter `document`

The document that owns the element.

#### Parameter `elementToCopy`

The id of the element to copy.

#### Parameter `translation`

The translation vector for the new element.

#### Returns

The ids of the newly created copied elements. More than one element may be created due to dependencies.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementToCopy does not exist in the document
-or-
The input element is a Sketch member and there is no Sketch in the edit mode to place this element in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

It is not allowed to copy Sketch member to non-parallel sketch.
-or-
If we are not able to copy the element.

#### Since

2012

### `M:Autodesk.Revit.DB.ElementTransformUtils.CopyElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementTransformUtils.CopyElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.XYZ)`

#### Summary

Copies a set of elements and places the copies at a location indicated by a given translation.

#### Remarks

This method is not suitable for elements that are hosted in other elements as it does not perform rehosting. If you need to rehost your elements in addition
to copying them, use one of the other CopyElements() overloads.

#### Parameter `document`

The document that owns the elements.

#### Parameter `elementsToCopy`

The set of elements to copy.

#### Parameter `translation`

The translation vector for the new elements.

#### Returns

The ids of the newly created copied elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element id set is empty.
-or-
One or more elements in elementsToCopy do not exist in the document.
-or-
Some of the elements cannot be copied, because they belong to different views.
-or-
The input set of elements contains Sketch members along with other elements or there is no active Sketch edit mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

It is not allowed to copy Sketch members between non-parallel sketches.
-or-
If we are not able to copy all the elements.

#### Since

2012

### `M:Autodesk.Revit.DB.ElementTransformUtils.MoveElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementTransformUtils.MoveElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

#### Summary

Moves one element by a given transformation.

#### Parameter `document`

The document that owns the elements.

#### Parameter `elementToMove`

The id of the element to move.

#### Parameter `translation`

The translation vector for the elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementToMove does not exist in the document

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If we are not able to move the element (for example, if it is pinned).
-or-
Move operation failed.

#### Since

2012

### `M:Autodesk.Revit.DB.ElementTransformUtils.MoveElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementTransformUtils.MoveElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.XYZ)`

#### Summary

Moves a set of elements by a given transformation.

#### Parameter `document`

The document that owns the elements.

#### Parameter `elementsToMove`

The set of elements to move.

#### Parameter `translation`

The translation vector for the elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element id set is empty.
-or-
One or more elements in elementsToMove do not exist in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If we are not able to move all the elements (for example, if one or more elements is pinned).
-or-
Move operation failed.

#### Since

2012

### `M:Autodesk.Revit.DB.ElementTransformUtils.CanMirrorElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementTransformUtils.CanMirrorElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Determines whether element can be mirrored.

#### Parameter `ADoc`

The document where the element reside.

#### Parameter `elemId`

The element identified by id.

#### Returns

True if the element can be mirrored.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ElementTransformUtils.CanMirrorElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementTransformUtils.CanMirrorElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Determines whether elements can be mirrored.

#### Parameter `ADoc`

The document where the elements reside.

#### Parameter `elemIds`

The elements identified by id.

#### Returns

True if the elements can be mirrored.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.ElementTransformUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementTransformUtils`

#### Summary

A collection of utilities allowing transformation of elements (e.g. move, rotate, mirror and copy).

#### Since

2012

### `M:Autodesk.Revit.DB.Outline.GetDiagonalLength`

Member kind: method
Symbol: `Autodesk.Revit.DB.Outline.GetDiagonalLength`

#### Summary

Get the length of outline's diagonal. If called on empty outline, 0.
is returned

#### Returns

The length of the diagonal.

#### Since

2011

### `M:Autodesk.Revit.DB.Outline.ContainsOtherOutline(Autodesk.Revit.DB.Outline,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Outline.ContainsOtherOutline(Autodesk.Revit.DB.Outline,System.Double)`

#### Summary

Determine if this Outline contains another Outline to within tolerance.

#### Remarks

If the tolerance is positive, the other Outline may extend the tolerance distance outside of this Outline in each coordinate.
If the tolerance is negative, the other Outline must lie at least the tolerance distance inside of this Outline in each coordinate to be a match.

#### Parameter `otherOutline`

The outline to test for containment.

#### Parameter `tolerance`

The tolerance to use when determining whether the point is contained. Defaults to zero.

#### Returns

True if this outline contains the given outline, or false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Outline.Contains(Autodesk.Revit.DB.XYZ,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Outline.Contains(Autodesk.Revit.DB.XYZ,System.Double)`

#### Summary

Determine if this Outline contains the specified point to within a tolerance.

#### Remarks

If the tolerance is positive, the point may lie up to the tolerance amount outside the outline in each coordinate.
If the tolerance is negative, the point must lie at least the tolerance amount inside the outline in each coordinate.

#### Parameter `point`

The point to test for containment.

#### Parameter `tolerance`

The tolerance to use when determining whether the point is contained. Defaults to zero.

#### Returns

True if this outline contains the given point, or false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Outline.Intersects(Autodesk.Revit.DB.Outline,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Outline.Intersects(Autodesk.Revit.DB.Outline,System.Double)`

#### Summary

Determine if this Outline intersects the input Outline to within a specified tolerance.

#### Remarks

If the tolerance is positive, the outlines may be separated by the tolerance distance in each coordinate.
If the tolerance is negative, the outlines must overlap by at least the tolerance distance in each coordinate.

#### Parameter `outline`

The outline to test for intersection with this one.

#### Parameter `tolerance`

The tolerance to use when determining intersection. Defaults to zero.

#### Returns

True if the given outline intersects this outline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Outline.AddPoint(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Outline.AddPoint(Autodesk.Revit.DB.XYZ)`

#### Summary

Adds a point to the bounding box, expanding it if the point is outside the existing boundary.

#### Parameter `point`

The point to add.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Outline.IsScaleValid(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Outline.IsScaleValid(System.Double)`

#### Summary

Checks if given scale is valid. Should be greater than zero.

#### Parameter `scale`

The scale.

#### Returns

True if the scale is valid, false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.Outline.Scale(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Outline.Scale(System.Double)`

#### Summary

Scales the bounding box by given scale.

#### Parameter `scale`

The scale value. It should be greater than zero.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The scale is invalid.

#### Since

2011

### `P:Autodesk.Revit.DB.Outline.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Outline.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Outline.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Outline.IsEmpty`

#### Summary

Identifies if the outline represents an empty outline.

#### Since

2011

### `P:Autodesk.Revit.DB.Outline.MaximumPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Outline.MaximumPoint`

#### Summary

The maximum point of the bounding box.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Outline.MinimumPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Outline.MinimumPoint`

#### Summary

The minimum point of the bounding box.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Outline.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Outline.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Constructor that uses a minimum and maximum XYZ point to initialize the outline.

#### Parameter `minimumPoint`

The minimum point

#### Parameter `maximumPoint`

The maximum point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Outline.#ctor(Autodesk.Revit.DB.Outline)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Outline.#ctor(Autodesk.Revit.DB.Outline)`

#### Summary

Constructs a new copy of the input Outline object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `T:Autodesk.Revit.DB.Outline`

Member kind: type
Symbol: `Autodesk.Revit.DB.Outline`

#### Summary

Outline is a generic object that provides a bounding box/bounding outline. It supports
operations to scale and transform. It also supports intersections and contains operations.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementRecord.GetBoundingBox`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementRecord.GetBoundingBox`

#### Summary

Gets the bounding box of the element record.

#### Returns

The bounding box outline. `null` if there is no bounding box for this element.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementRecord.HasBoundingBox`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementRecord.HasBoundingBox`

#### Summary

Determines whether this element record has a bounding box.

#### Returns

True if the element record has a bounding box or false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementRecord.IsCurveDriven`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementRecord.IsCurveDriven`

#### Summary

Identifies if the element is curve driven.

#### Returns

True if the element is curve driven.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementRecord.GetDesignOptionId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementRecord.GetDesignOptionId`

#### Summary

Gets the design option id of the element record.

#### Returns

The design option id.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementRecord.GetOwnerViewId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementRecord.GetOwnerViewId`

#### Summary

Gets the element id of the owner view record.

#### Returns

The view record element id.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementRecord.IsAnElementType`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementRecord.IsAnElementType`

#### Summary

Identifies if the element record represents an ElementType.

#### Returns

True if the element record represents an ElementType.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementRecord.GetCategoryId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementRecord.GetCategoryId`

#### Summary

Gets the category id of the element record.

#### Returns

The category id.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementRecord.GetId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementRecord.GetId`

#### Summary

Gets the id of the element record.

#### Returns

The element id.

#### Since

2011

### `P:Autodesk.Revit.DB.ElementRecord.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementRecord.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ElementRecord.WorksetId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementRecord.WorksetId`

#### Summary

Get Id of the workset which owns the element.

#### Remarks

Each element belongs to one and only one workset.

#### Since

2011

### `T:Autodesk.Revit.DB.ElementRecord`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementRecord`

#### Summary

A record in the Revit database representing an element.

#### Remarks

The record is used to extract basic information about an element before
the element is fully expanded in memory.

#### Since

2011

### `T:Autodesk.Revit.DB.ElementQuickFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementQuickFilter`

#### Summary

A base class for a type of filter that operates on element records.

#### Remarks

Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2011

### `M:Autodesk.Revit.DB.LogicalOrFilter.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementFilter})`

Member kind: method
Symbol: `Autodesk.Revit.DB.LogicalOrFilter.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementFilter})`

#### Summary

Constructs a new instance of the logical filter with any number of input filters.

#### Parameter `filters`

A collection of input filters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The filter collection is empty, or contains invalid inputs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.LogicalOrFilter.#ctor(Autodesk.Revit.DB.ElementFilter,Autodesk.Revit.DB.ElementFilter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LogicalOrFilter.#ctor(Autodesk.Revit.DB.ElementFilter,Autodesk.Revit.DB.ElementFilter)`

#### Summary

Constructs a new instance of the logical filter with two input filters.

#### Parameter `filter1`

The first filter.

#### Parameter `filter2`

The second filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.LogicalOrFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.LogicalOrFilter`

#### Summary

A filter that contains a set of filters. The filter passes when any filter in the set passes.

#### Remarks

The component filters may be reordered by Revit to cause the quickest acting filters to be evaluated first.

#### Since

2011

### `M:Autodesk.Revit.DB.LogicalAndFilter.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementFilter})`

Member kind: method
Symbol: `Autodesk.Revit.DB.LogicalAndFilter.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementFilter})`

#### Summary

Constructs a new instance of the logical filter with any number of input filters.

#### Remarks

The input filters will be copied.

#### Parameter `filters`

A collection of input filters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The filter collection is empty, or contains invalid inputs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.LogicalAndFilter.#ctor(Autodesk.Revit.DB.ElementFilter,Autodesk.Revit.DB.ElementFilter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LogicalAndFilter.#ctor(Autodesk.Revit.DB.ElementFilter,Autodesk.Revit.DB.ElementFilter)`

#### Summary

Constructs a new instance of the logical filter with two input filters.

#### Remarks

The input filters will be copied.

#### Parameter `filter1`

The first filter.

#### Parameter `filter2`

The second filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.LogicalAndFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.LogicalAndFilter`

#### Summary

A filter that contains a set of filters. The filter passes when all filters in the set pass.

#### Remarks

The component filters may be reordered by Revit to cause the quickest acting filters to be evaluated first.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementLogicalFilter.SetFilters(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementFilter})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementLogicalFilter.SetFilters(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementFilter})`

#### Summary

Replaces current filters in the logical filter with any number of input filters.

#### Remarks

The input filters will be copied.

#### Parameter `filters`

A collection of input filters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The filter collection is empty, or contains invalid inputs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.ElementLogicalFilter.GetFilters`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementLogicalFilter.GetFilters`

#### Summary

Returns an array of copies of the filters that are logically combined by this ElementLogicalFilter.

#### Returns

Copies of the filters that are logically combined by this ElementLogicalFilter.

#### Since

2019

### `T:Autodesk.Revit.DB.ElementLogicalFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementLogicalFilter`

#### Summary

A filter used to logically combine two or more filters.

#### Remarks

The component filters may be reordered by Revit to cause the quickest acting filters to be evaluated first.

#### Since

2011

### `M:Autodesk.Revit.DB.Solid.getGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.Solid.getGeometry`

#### Summary

Returns the Geometry object for this solid.

### `M:Autodesk.Revit.DB.Solid.GetBoundingBox`

Member kind: method
Symbol: `Autodesk.Revit.DB.Solid.GetBoundingBox`

#### Summary

Retrieves a box that circumscribes the solid geometry.

#### Remarks

The bounding box information is stored as bounds in local coordinates and a transform.
So the transform is to be taken in to account when using the bounds.
This is different from the bounding box returned by Element.BoundingBox in that the bounding box
returned by that routine stores the bounds in modeling coordinates with an identity transform.

#### Since

2014

### `M:Autodesk.Revit.DB.Solid.IntersectWithCurve(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.SolidCurveIntersectionOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Solid.IntersectWithCurve(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.SolidCurveIntersectionOptions)`

#### Summary

Calculates and returns the intersection between a curve and this solid.

#### Parameter `curve`

The curve.

#### Parameter `options`

The options. If NULL, the default options will be used.

#### Returns

The intersection results.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve is not bound.
-or-
The input solid is not a closed volume.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2013

### `M:Autodesk.Revit.DB.Solid.ComputeCentroid`

Member kind: method
Symbol: `Autodesk.Revit.DB.Solid.ComputeCentroid`

#### Summary

Returns the Centroid of this solid.

#### Remarks

Calculates the centroid of the solid using an approximation, with an accuracy suitable for architectural purposes.
This will correspond only with the center of gravity if the solid represents a homogeneous structure of a single material.

#### Returns

The XYZ point of the Centroid of this solid.

### `P:Autodesk.Revit.DB.Solid.Volume`

Member kind: property
Symbol: `Autodesk.Revit.DB.Solid.Volume`

#### Summary

Returns the signed volume of this solid.

#### Returns

The real number equal to the signed volume of this solid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this solid is not a valid Geometry object or the volume calculation failed.

#### Remarks

Revit attempts to compute the volume analytically, if possible. If an analytical solution is not possible,
it uses tessellated faces to calculate a reasonable approximation for the volume.
The calculated volume may be slightly underestimated or overestimated if curved surfaces are present.

### `P:Autodesk.Revit.DB.Solid.SurfaceArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Solid.SurfaceArea`

#### Summary

Returns the total surface area of this solid.

#### Returns

The real number equal to the total area of this solid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this solid is not a valid Geometry object.

#### Remarks

Calculates the surface area by adding together the areas of faces comprising this solid.
Will slightly underestimate if curved surfaces are present.

### `P:Autodesk.Revit.DB.Solid.Faces`

Member kind: property
Symbol: `Autodesk.Revit.DB.Solid.Faces`

#### Summary

The faces that belong to the solid.

#### Remarks

A face may be degenerate. This can be determined with the Face property IsTwoSided.

### `P:Autodesk.Revit.DB.Solid.Edges`

Member kind: property
Symbol: `Autodesk.Revit.DB.Solid.Edges`

#### Summary

The edges that belong to the solid.

### `T:Autodesk.Revit.DB.Solid`

Member kind: type
Symbol: `Autodesk.Revit.DB.Solid`

#### Summary

A 3d solid.

#### Remarks

A solid is defined by the faces and edges that form its boundary.

### `M:Autodesk.Revit.DB.ElementIntersectsSolidFilter.GetSolid`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIntersectsSolidFilter.GetSolid`

#### Summary

Gets the target solid geometry.

#### Returns

The solid geometry.

#### Since

2012

### `M:Autodesk.Revit.DB.ElementIntersectsSolidFilter.#ctor(Autodesk.Revit.DB.Solid,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIntersectsSolidFilter.#ctor(Autodesk.Revit.DB.Solid,System.Boolean)`

#### Summary

Constructs a filter to match elements which intersect the given element, with the
option to match all elements not intersecting the given element.

#### Parameter `solid`

The solid geometry to check for intersection.

#### Parameter `inverted`

True if the filter should match all elements which do not intersect the given
element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ElementIntersectsSolidFilter.#ctor(Autodesk.Revit.DB.Solid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIntersectsSolidFilter.#ctor(Autodesk.Revit.DB.Solid)`

#### Summary

Constructs a filter to match elements which intersect the given element.

#### Parameter `solid`

The solid geometry to check for intersection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.ElementIntersectsSolidFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementIntersectsSolidFilter`

#### Summary

A filter to find elements that intersect the given solid geometry.

#### Remarks

The input solid used for this filter can be obtained from an existing element, created from scratch
using the routines in GeometryCreationUtilities or builder classes, or the generated from the result of a
secondary operation such as a Boolean operation. Similar to the `T:Autodesk.Revit.DB.ElementIntersectsElementFilter` ,
this filter will not detect as intersecting elements which lack solid geometry, such as Rebar.

This filter is a slow filter.
Slow filters require that the Element be obtained and expanded in memory first.
Thus it is preferable to couple this filter with at least one ElementQuickFilter,
which should minimize the number of Elements that are expanded.

#### Since

2012

### `M:Autodesk.Revit.DB.ElementIntersectsElementFilter.GetElement`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIntersectsElementFilter.GetElement`

#### Summary

Gets the target element.

#### Returns

The element.

#### Since

2012

### `M:Autodesk.Revit.DB.ElementIntersectsElementFilter.#ctor(Autodesk.Revit.DB.Element,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIntersectsElementFilter.#ctor(Autodesk.Revit.DB.Element,System.Boolean)`

#### Summary

Constructs a filter to match elements which intersect the given element, with the
option to match all elements not intersecting the given element.

#### Parameter `element`

The element to check for intersection.

#### Parameter `inverted`

True if the filter should match all elements which do not intersect the given
element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The category of the element is not supported for element intersection filters.
-or-
The element is not supported for element intersection filters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ElementIntersectsElementFilter.#ctor(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIntersectsElementFilter.#ctor(Autodesk.Revit.DB.Element)`

#### Summary

Constructs a filter to match elements which intersect the given element.

#### Parameter `element`

The element to check for intersection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The category of the element is not supported for element intersection filters.
-or-
The element is not supported for element intersection filters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.ElementIntersectsElementFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementIntersectsElementFilter`

#### Summary

A filter to find elements that intersect the solid geometry of a given element.

#### Remarks

The target object is another element. The intersection is determined with the same logic used by Revit
to determine if an interference exists during generation of an Interference Report. (This means that some
combinations of elements will never be detected as intersecting by this filter, such as concrete members which are automatically
joined at their intersections). Also, elements which have no solid geometry, such as Rebar, will never be detected
as intersecting by this filter.

This filter is a slow filter.
Slow filters require that the Element be obtained and expanded in memory first.
Thus it is preferable to couple this filter with at least one ElementQuickFilter,
which should minimize the number of Elements that are expanded.

#### Since

2012

### `M:Autodesk.Revit.DB.ElementIntersectsFilter.IsElementSupported(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIntersectsFilter.IsElementSupported(Autodesk.Revit.DB.Element)`

#### Summary

Identifies if the input element is supported by element intersection filters.

#### Parameter `element`

The element.

#### Returns

True if the element is supported, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ElementIntersectsFilter.IsCategorySupported(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIntersectsFilter.IsCategorySupported(Autodesk.Revit.DB.Element)`

#### Summary

Identifies if the input element is of a category supported by element intersection filters.

#### Parameter `element`

The element.

#### Returns

True if the element category is supported, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.ElementIntersectsFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementIntersectsFilter`

#### Summary

A base class for filters used to match elements which intersect with geometry.

#### Since

2012

### `T:Autodesk.Revit.DB.ElementSlowFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementSlowFilter`

#### Summary

A base class for a type of filter that operates on expanded elements.

#### Remarks

Slow filters require that the Element be obtained and expanded in memory first.
Thus it is preferable to couple slow filters with at least one ElementQuickFilter,
which should minimize the number of Elements that are expanded in order to evaluate
against the criteria set by this filter.

#### Since

2011

### `M:Autodesk.Revit.DB.IDuplicateTypeNamesHandlerProxy.OnDuplicateTypeNamesFound(Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IDuplicateTypeNamesHandlerProxy.OnDuplicateTypeNamesFound(Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs)`

#### Summary

Called when the destination document contains types with the same names as the types being copied.

#### Parameter `args`

The information about the types with duplicate names.

#### Returns

The action to be taken: copy only types with unique names or cancel the operation.

#### Since

2014

### `M:Autodesk.Revit.DB.IDuplicateTypeNamesHandler.OnDuplicateTypeNamesFound(Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IDuplicateTypeNamesHandler.OnDuplicateTypeNamesFound(Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs)`

#### Summary

Called when the destination document contains types with the same names as the types being copied.

#### Parameter `args`

The information about the types with duplicate names.

#### Returns

The action to be taken: copy only types with unique names or cancel the operation.

#### Since

2014

### `T:Autodesk.Revit.DB.IDuplicateTypeNamesHandler`

Member kind: type
Symbol: `Autodesk.Revit.DB.IDuplicateTypeNamesHandler`

#### Summary

An interface for custom handlers of duplicate type names encountered during a paste operation. When the destination document
contains types that have the same names as the types being copied, but different internals, a decision must be made on how to proceed - whether to
cancel the operation or continue, but only copy types with unique names.

#### Since

2014

### `M:Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs.GetTypeIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs.GetTypeIds`

#### Summary

Returns ids of the types with duplicate names.

#### Since

2014

### `P:Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs.Document`

Member kind: property
Symbol: `Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs.Document`

#### Summary

The document that contains the types with duplicate names.

#### Since

2014

### `T:Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs`

#### Summary

A structure that provides information about an attempt to copy types with names that already exist in the destination document.

#### Since

2014

### `T:Autodesk.Revit.DB.DuplicateTypeAction`

Member kind: type
Symbol: `Autodesk.Revit.DB.DuplicateTypeAction`

#### Summary

This enumerated type defines the action to be taken when there are types with the same name being pasted.

#### Since

2013

### `F:Autodesk.Revit.DB.DuplicateTypeAction.Abort`

Member kind: field
Symbol: `Autodesk.Revit.DB.DuplicateTypeAction.Abort`

#### Summary

Cancel the paste operation.

### `F:Autodesk.Revit.DB.DuplicateTypeAction.UseDestinationTypes`

Member kind: field
Symbol: `Autodesk.Revit.DB.DuplicateTypeAction.UseDestinationTypes`

#### Summary

Proceed with the paste operation and use the types with the same name in the destination document.

### `M:Autodesk.Revit.DB.GroupType.LoadFrom(System.String,Autodesk.Revit.DB.GroupLoadOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupType.LoadFrom(System.String,Autodesk.Revit.DB.GroupLoadOptions)`

#### Summary

Replaces the group with the contents of the input file.

#### Parameter `fileName`

The file to be used for the replacment.

#### Parameter `options`

Group load options.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid RVT file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given fileName does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The element "this GroupType" is in a document which is in an edit mode or is in family mode.
-or-
The element "this GroupType" does not belong to a project document.
-or-
The GroupType is not a Model group type and can't be reloaded.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing this GroupType is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing this GroupType is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing this GroupType has no open transaction.

#### Since

2024

### `M:Autodesk.Revit.DB.GroupType.GetAvailableAttachedDetailGroupTypeIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupType.GetAvailableAttachedDetailGroupTypeIds`

#### Summary

Returns the attached detail groups available for this element group type.

#### Returns

Returns the collection of attached detail group Ids that match this group's type.

#### Since

2019.1

### `P:Autodesk.Revit.DB.GroupType.Groups`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupType.Groups`

#### Summary

Retrieve a set of all the groups that have this type.

#### Returns

A set of group objects that all share this group type.

#### Remarks

All groups returned by this property belong to this group type. A groups type can be
changed by using the GroupType property on the group object, in which case it will no longer
belong to this type but it will belong to the new type instead.

### `T:Autodesk.Revit.DB.GroupType`

Member kind: type
Symbol: `Autodesk.Revit.DB.GroupType`

#### Summary

An element representing a group of elements that may be placed many times in a project or family.

#### Remarks

Grouping elements is useful when you need to create entities that represent repeating layouts
or are common to many building projects, such as hotel rooms, apartments, or repeating floors.

### `M:Autodesk.Revit.DB.GroupLoadOptions.SetDuplicateTypeNamesHandler(Autodesk.Revit.DB.IDuplicateTypeNamesHandler)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupLoadOptions.SetDuplicateTypeNamesHandler(Autodesk.Revit.DB.IDuplicateTypeNamesHandler)`

#### Summary

Sets a custom duplicate type names handler. If this value is not set, the default handler is used.
By default, Revit displays a modal dialog with options to either copy new types only, or cancel the operation.

#### Parameter `handler`

The duplicate type names handler.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.GroupLoadOptions.GetDuplicateTypeNamesHandler`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupLoadOptions.GetDuplicateTypeNamesHandler`

#### Summary

Returns current duplicate type names handler or `null` if none is set.

#### Since

2024

### `P:Autodesk.Revit.DB.GroupLoadOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupLoadOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.GroupLoadOptions.ReplaceDuplicatedGroups`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupLoadOptions.ReplaceDuplicatedGroups`

#### Summary

If there are groups with the same names in source and destination documents set this property to `true` to replace existing groups,
otherwise the operation will be canceled. The default value is `false` .

#### Since

2024

### `P:Autodesk.Revit.DB.GroupLoadOptions.IncludeGrids`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupLoadOptions.IncludeGrids`

#### Summary

True if grids should be brought in from the input file, false otherwise.
The default value is `false` .

#### Since

2024

### `P:Autodesk.Revit.DB.GroupLoadOptions.IncludeLevels`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupLoadOptions.IncludeLevels`

#### Summary

True if levels should be brought in from the input file, false otherwise.
The default value is `false` .

#### Since

2024

### `P:Autodesk.Revit.DB.GroupLoadOptions.IncludeAttachedDetails`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupLoadOptions.IncludeAttachedDetails`

#### Summary

True if attached detail groups should be included, false otherwise.
The default value is `true` .

#### Since

2024

### `M:Autodesk.Revit.DB.GroupLoadOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupLoadOptions.#ctor`

#### Summary

Creates a new instance of a GroupLoadOptions object.

#### Since

2024

### `T:Autodesk.Revit.DB.GroupLoadOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.GroupLoadOptions`

#### Summary

A class containing options for loading a group from a file.

#### Since

2024

### `M:Autodesk.Revit.DB.Group.IsCompatibleAttachedDetailGroupType(Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Group.IsCompatibleAttachedDetailGroupType(Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the orientation of the input attached detail group matches the input view's orientation.

#### Remarks

Currently, detail groups in perpendicular elevation views (for example, North and East views)
are considered compatible. When showing these detail groups, an error (FailureMessage) based on
id can be generated if the orientation of the annotations do not match the orientation of the
target view (for example, the failure definition DimensionPerpendicularToView). To prevent
displaying detail groups in the wrong view, you can check the OwnerViewId of a detail group
to make sure it matches the view in which you are trying to display it.

#### Parameter `view`

The view that the input attached detail group must be compatible with.

#### Parameter `detailGroupTypeId`

The attached detail group that will be checked for compatibility with the input view.

#### Returns

Returns true if the input attached detail group is compatible with the input view and false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The input group is not a model group and can therefore not have attached detail groups.

#### Since

2019.1

### `M:Autodesk.Revit.DB.Group.GetAvailableAttachedDetailGroupTypeIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Group.GetAvailableAttachedDetailGroupTypeIds`

#### Summary

Returns the attached detail groups available for this group type.

#### Returns

Returns the collection of attached detail group Ids that match this group's type.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The input group is not a model group and can therefore not have attached detail groups.

#### Since

2019.1

### `M:Autodesk.Revit.DB.Group.GetShownAttachedDetailGroupTypeIds(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Group.GetShownAttachedDetailGroupTypeIds(Autodesk.Revit.DB.View)`

#### Summary

Returns the attached detail groups which have displayed instances for
this group type in the input view.

#### Parameter `view`

The view in which the attached detail groups are displayed.

#### Returns

The collection of attached detail group Ids that match this group's type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The input group is not a model group and can therefore not have attached detail groups.

#### Since

2019.1

### `M:Autodesk.Revit.DB.Group.HideAllAttachedDetailGroups(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Group.HideAllAttachedDetailGroups(Autodesk.Revit.DB.View)`

#### Summary

Hides all the available attached detail groups for this element group type that
are compatible with the input view type.

#### Parameter `view`

The view that the attached detail groups must be compatible with.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The input group is not a model group and can therefore not have attached detail groups.

#### Since

2019.1

### `M:Autodesk.Revit.DB.Group.HideAttachedDetailGroups(Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Group.HideAttachedDetailGroups(Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

#### Summary

Hides the element group's attached detail groups of the input group type that
are compatible with the input view.

#### Parameter `view`

The view that the attached detail groups must be compatible with.

#### Parameter `detailGroupTypeId`

Only attached detail groups of this type will be hidden.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The attached detail group detailGroupTypeId does not match the input view's orientation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The input group is not a model group and can therefore not have attached detail groups.

#### Since

2019.1

### `M:Autodesk.Revit.DB.Group.ShowAllAttachedDetailGroups(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Group.ShowAllAttachedDetailGroups(Autodesk.Revit.DB.View)`

#### Summary

Shows all the available attached detail groups for this element group type that
are compatible with the input view type.

#### Remarks

Currently, perpendicular elevation views (for example, North and East views) are considered
compatible when deciding whether or not to allow a detail group to be displayed in a view.
The show operation may generate an error (FailureMessage) based on id if the orientation of the
annotations do not match the orientation of the target view (for example, the failure definition
DimensionPerpendicularToView). To prevent displaying detail groups in the wrong view, you can
check the OwnerViewId of a detail group to make sure it matches the view in which you are trying
to display it.

#### Parameter `view`

The view that the attached detail groups must be compatible with.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The input group is not a model group and can therefore not have attached detail groups.
-or-
This exception is thrown if this group's attached detail groups cannot be found in the current document.

#### Since

2019.1

### `M:Autodesk.Revit.DB.Group.ShowAttachedDetailGroups(Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Group.ShowAttachedDetailGroups(Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

#### Summary

Shows the element group's attached detail groups of the input group type that
are compatible with the input view.

#### Remarks

Currently, perpendicular elevation views (for example, North and East views) are considered
compatible when deciding whether or not to allow a detail group to be displayed in a view.
The show operation may generate an error (FailureMessage) based on id if the orientation of the
annotations do not match the orientation of the target view (for example, the failure definition
DimensionPerpendicularToView). To prevent displaying detail groups in the wrong view, you can
check the OwnerViewId of a detail group to make sure it matches the view in which you are trying
to display it.

#### Parameter `view`

The view that the attached detail groups must be compatible with.

#### Parameter `detailGroupTypeId`

Only attached detail groups of this type will be shown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The attached detail group detailGroupTypeId does not match the input view's orientation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The input group is not a model group and can therefore not have attached detail groups.
-or-
This exception is thrown if the input attached detail group cannot be found in the current document.

#### Since

2019.1

### `P:Autodesk.Revit.DB.Group.AttachedParentId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Group.AttachedParentId`

#### Summary

Indicates the Id of the parent group this group is attached to.

#### Since

2019.1

### `P:Autodesk.Revit.DB.Group.IsAttached`

Member kind: property
Symbol: `Autodesk.Revit.DB.Group.IsAttached`

#### Summary

Indicates wether or not this group is attached to a parent group.

#### Since

2019.1

### `M:Autodesk.Revit.DB.Group.GetMemberIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Group.GetMemberIds`

#### Summary

Retrieves all the member ElementIds of the group.

#### Returns

An ordered list of the members within the group. The order of this
list can be used to match members between other instances of the group.

#### Since

2013

### `M:Autodesk.Revit.DB.Group.UngroupMembers`

Member kind: method
Symbol: `Autodesk.Revit.DB.Group.UngroupMembers`

#### Summary

Ungroups the group.

#### Returns

If successful, the ids of the members of group are returned.

#### Remarks

Removes all the members from the group and deletes the group. Note that the reference to this group object will become invalid once this method
is called.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the group cannot be ungrouped.

### `P:Autodesk.Revit.DB.Group.Location`

Member kind: property
Symbol: `Autodesk.Revit.DB.Group.Location`

#### Summary

This property is used to find the physical location of a group within project.

#### Remarks

The Location property returns an object that can be used to find the location of an object
within the project. Groups return a point location object.

### `P:Autodesk.Revit.DB.Group.GroupType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Group.GroupType`

#### Summary

Get or set the type of the group.

#### Remarks

By setting this property the group can be swapped to a different kind of group.

### `T:Autodesk.Revit.DB.Group`

Member kind: type
Symbol: `Autodesk.Revit.DB.Group`

#### Summary

An element representing a single instance of a group of elements that may be placed many times in a project or family.

#### Remarks

Grouping elements is useful when you need to create entities that represent repeating layouts
or are common to many building projects, such as hotel rooms, apartments, or repeating floors.

### `M:Autodesk.Revit.DB.WorksetId.op_GreaterThanOrEqual(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksetId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetId.op_GreaterThanOrEqual(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksetId)`

#### Summary

Determines whether one WorksetId is not less than another WorksetId.

#### Parameter `WorksetId1`

The first WorksetId.

#### Parameter `WorksetId2`

The second WorksetId.

#### Returns

True if the first WorksetId is not less than the second WorksetId, otherwise, false.

### `M:Autodesk.Revit.DB.WorksetId.op_LessThanOrEqual(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksetId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetId.op_LessThanOrEqual(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksetId)`

#### Summary

Determines whether one WorksetId is not greater than another WorksetId.

#### Parameter `WorksetId1`

The first WorksetId.

#### Parameter `WorksetId2`

The second WorksetId.

#### Returns

True if the first WorksetId is not greater than the second WorksetId, otherwise, false.

### `M:Autodesk.Revit.DB.WorksetId.op_GreaterThan(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksetId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetId.op_GreaterThan(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksetId)`

#### Summary

Determines whether one WorksetId is greater than another WorksetId.

#### Parameter `WorksetId1`

The first WorksetId.

#### Parameter `WorksetId2`

The second WorksetId.

#### Returns

True if the first WorksetId is greater than the second WorksetId, otherwise, false.

### `M:Autodesk.Revit.DB.WorksetId.op_LessThan(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksetId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetId.op_LessThan(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksetId)`

#### Summary

Determines whether this WorksetId is less than another WorksetId.

#### Parameter `WorksetId1`

The first WorksetId.

#### Parameter `WorksetId2`

The second WorksetId.

#### Returns

True if the first WorksetId is less than the second WorksetId, otherwise, false.

### `M:Autodesk.Revit.DB.WorksetId.op_Inequality(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksetId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetId.op_Inequality(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksetId)`

#### Summary

Determines whether these two WorksetIds are different.

#### Parameter `first`

The first WorksetId.

#### Parameter `second`

The second WorksetId.

#### Returns

True if the WorksetIds are different; otherwise, false.

### `M:Autodesk.Revit.DB.WorksetId.op_Equality(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksetId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetId.op_Equality(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksetId)`

#### Summary

Determines whether these two WorksetIds are the same.

#### Parameter `first`

The first WorksetId.

#### Parameter `second`

The second WorksetId.

#### Returns

True if the WorksetIds are the same; otherwise, false.

### `M:Autodesk.Revit.DB.WorksetId.Compare(Autodesk.Revit.DB.WorksetId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetId.Compare(Autodesk.Revit.DB.WorksetId)`

#### Summary

Compares two WorksetIds.

#### Parameter `id`

The WorksetId to be compared with this WorksetId.

#### Returns

-1 if this WorksetId is less than id, 0 if equal, 1 if greater.

### `P:Autodesk.Revit.DB.WorksetId.InvalidWorksetId`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksetId.InvalidWorksetId`

#### Summary

Get the invalid WorksetId whose IntegerValue is -1.

### `M:Autodesk.Revit.DB.WorksetId.GetHashCode`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetId.GetHashCode`

#### Summary

Gets the integer value of the id as hash code

### `M:Autodesk.Revit.DB.WorksetId.Equals(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetId.Equals(System.Object)`

#### Summary

Determines whether the specified `T:System.Object` is equal to the current `T:System.Object` .

#### Parameter `obj`

Another object.

### `M:Autodesk.Revit.DB.WorksetId.ToString`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetId.ToString`

#### Summary

Gets a String representation of the integer value of the id.

### `P:Autodesk.Revit.DB.WorksetId.IntegerValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksetId.IntegerValue`

#### Summary

Provides the value of the WorksetId as an integer.

### `M:Autodesk.Revit.DB.WorksetId.#ctor(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetId.#ctor(System.Int32)`

#### Summary

Create an WorksetId handle with the given integer id.

#### Parameter `id`

The id.

### `T:Autodesk.Revit.DB.WorksetId`

Member kind: type
Symbol: `Autodesk.Revit.DB.WorksetId`

#### Summary

WorksetId identifies a workset within a single document.

#### Remarks

WorksetId is not guaranteed to be unique.
It is only valid within one model and its value may change when the model is synchronized with central.
If unique identification of a workset is needed, the workset's GUID should be used instead.

### `M:Autodesk.Revit.DB.Subelement.CanHaveTypeAssigned`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.CanHaveTypeAssigned`

#### Summary

Identifies if the subelement can have a type assigned.

#### Remarks

Some subelements cannot have type assigned,
in which case invalid element id is considered to be their type id.

#### Returns

True if subelement can have a type assigned, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.Subelement.IsValidSubelementReference(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.IsValidSubelementReference(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

#### Summary

Checks if given Reference identifies either a valid element or subelement.

#### Remarks

A reference to an element or subelement in a linked document is acceptable.

#### Parameter `aDoc`

The document.

#### Parameter `reference`

The reference that identifies an element or subelement.

#### Returns

True if %reference% identifies a valid element or subelement, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Subelement.HasParameter(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.HasParameter(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if this subelement have given parameter.

#### Parameter `parameterId`

Parameter id.

#### Returns

True if %parameterId% identifies valid parameter of this subelement, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Subelement.GetReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.GetReference`

#### Summary

Obtains the reference to this subelement.

#### Returns

The reference to this subelement.

#### Since

2018

### `M:Autodesk.Revit.DB.Subelement.GetBoundingBox(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.GetBoundingBox(Autodesk.Revit.DB.View)`

#### Summary

Retrieves a box that circumscribes all geometry of the subelement.

#### Remarks

Pass in a view to query view-specific (e.g., cut) geometry or `null` for model
geometry. If the view box is not known or cannot be calculated, this will return the model box;
if the model box is not known,
this will return `null` . The box will always be aligned to the default axes of the
model coordinate system (thus no rotation should be applied to the return value).
Also note that this bounding box volume
may enclose geometry that is not obvious. For example, the "flip controls" that
could be part of a family will be included in the computation of the bounding box even
though they are not always visible in the family instance of the family.

#### Parameter `dbView`

The view for view-specific geometry or `null` for model geometry.

#### Returns

The bounding box.

#### Since

2018

### `M:Autodesk.Revit.DB.Subelement.GetGeometryObject(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.GetGeometryObject(Autodesk.Revit.DB.View)`

#### Summary

Retrieve one geometric primitive representing given subelement.

#### Remarks

In case of whole element, geometric object representing element and its subelements will be returned.
`null` will be returned if related geometric object could not be found in the model.

#### Parameter `dbView`

The view for view-specific geometry or `null` for model geometry.

#### Returns

The geometric object representing this subelement.

#### Since

2018

### `M:Autodesk.Revit.DB.Subelement.IsParameterModifiable(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.IsParameterModifiable(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if given parameter of this subelement is modifiable.

#### Parameter `parameterId`

Parameter id.

#### Returns

True if given parameter of this subelement is modifiable, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Subelement.SetParameterValue(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ParameterValue)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.SetParameterValue(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ParameterValue)`

#### Summary

Sets a new parameter value of this subelement given a parameter id.

#### Parameter `parameterId`

Parameter id.

#### Parameter `pValue`

New value for the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

parameterId does not identify a valid parameter of this subelement.
-or-
The parameter parameterId is not modifiable for this subelement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Subelement.GetParameterValue(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.GetParameterValue(Autodesk.Revit.DB.ElementId)`

#### Summary

Obtains the current parameter value of this subelement given a parameter id.

#### Parameter `parameterId`

Parameter id.

#### Returns

Parameter value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

parameterId does not identify a valid parameter of this subelement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Subelement.GetAllParameters`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.GetAllParameters`

#### Summary

Returns all parameters of this subelement.

#### Since

2018

### `M:Autodesk.Revit.DB.Subelement.ChangeTypeId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.ChangeTypeId(Autodesk.Revit.DB.ElementId)`

#### Summary

Changes the type of the subelement.

#### Remarks

In rare cases, applying a change in type will result in a new element being created.
The only active examples of this are when:
Applying a normal wall type to a curtain panel.

Converting such a wall back to a curtain panel.

Applying a new type to a railing subelement.
In this situation this subelement object will be redirected to the new element.

#### Parameter `typeId`

Identifier of the type to assign to this subelement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The type typeId is not valid for this subelement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Subelement cannot have type assigned.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

This Subelement is an internal element, such as a component of a
loaded family or a group type.
-or-
The document containing this Subelement is in Group Edit Mode,
Sketch Edit Mode, or Paste Mode, and the element is not a
member of the group, sketch, or clipboard.
-or-
This Subelement is a member of a group or sketch, and the document
is not currently editing the group or sketch.

#### Since

2018

### `M:Autodesk.Revit.DB.Subelement.GetValidTypes`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.GetValidTypes`

#### Summary

Obtains a set of types that are valid for this subelement.

#### Remarks

A type is valid for a subelement if it can be assigned to the subelement.

#### Returns

A set of element IDs of types that are valid for this subelement or an empty set if subelement cannot have type assigned.

#### Since

2018

### `M:Autodesk.Revit.DB.Subelement.IsValidType(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.IsValidType(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if given type is valid for this subelement.

#### Remarks

A type is valid for a subelement if it can be assigned to the subelement.

#### Parameter `typeId`

ElementId of the type to check.

#### Returns

True if subelement can have a type assigned and this type is valid for this subelement, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Subelement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Subelement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

#### Summary

Creates an object representing element or subelement.

#### Remarks

If %reference% points to linked document:
The `M:Autodesk.Revit.DB.Subelement.GetReference` method of the newly created subelement will return the local reference in the linked document.

The `P:Autodesk.Revit.DB.Subelement.Document` property of the newly created subelement will return the linked document.

#### Parameter `aDoc`

The document.

#### Parameter `reference`

The reference that identifies element or subelement.

#### Returns

The newly created subelement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reference does not identify a valid element or subelement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.Subelement.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Subelement.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Subelement.UniqueId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Subelement.UniqueId`

#### Summary

A stable unique identifier for this subelement within the document.

#### Since

2018

### `P:Autodesk.Revit.DB.Subelement.Element`

Member kind: property
Symbol: `Autodesk.Revit.DB.Subelement.Element`

#### Summary

The element in which the subelement resides.

#### Remarks

If subelement refers to whole element, this element is returned.

#### Since

2018

### `P:Autodesk.Revit.DB.Subelement.Document`

Member kind: property
Symbol: `Autodesk.Revit.DB.Subelement.Document`

#### Summary

The document in which the subelement resides.

#### Since

2018

### `P:Autodesk.Revit.DB.Subelement.TypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Subelement.TypeId`

#### Summary

The identifier of this subelement's type.

#### Remarks

Some subelements cannot have type assigned,
in which case this method returns invalid element id.

#### Since

2018

### `P:Autodesk.Revit.DB.Subelement.Category`

Member kind: property
Symbol: `Autodesk.Revit.DB.Subelement.Category`

#### Summary

Retrieves a Category object that represents the category or sub category of the subelement.

#### Remarks

All category objects can be retrieved from the application by using the Categories property
of the Application.Settings object.

### `T:Autodesk.Revit.DB.Subelement`

Member kind: type
Symbol: `Autodesk.Revit.DB.Subelement`

#### Summary

An object that represents an element or a subelement within the Autodesk Revit project.

#### Remarks

Subelements provide a way for parts of an element to behave as though they were real elements without incurring the overhead of adding more full elements to the model.

Many Revit features (for example parameters, schedules, and tags) were designed to operate on Elements.
As a result, the Revit code needs to represent objects as Elements for them to participate in those features. This can lead to scalability problems,
because every Element adds overhead and adding many Elements may decrease the performance of the model. An alternative is to use Subelements. An element
can expose a set of "Subelements" that it contains, specifying characteristics like their category and parameters,
and certain Revit capabilities will treat those Subelements the same as ordinary Elements. For example, a Subelement may contribute geometry to the main element
and may be able to be selected independently of its parent Element. It will possibly have its own (settable) type as well as an assigned category which
can be different from its parent Element.

In the API, the new Subelement class is used to refer to either an Element or a specific subelement of a given Element.
It is typically directly related to a Reference to either the Element or the specific subelement.
Note that creation of new Subelements for a given element is not done generically. Instead, the given Element may provide the ability to modify it's definition,
resulting in the creation of new Subelements.

Examples of Elements which may have Subelements in practice include:
`T:Autodesk.Revit.DB.Structure.RebarContainer`

`T:Autodesk.Revit.DB.Structure.Rebar`

`T:Autodesk.Revit.DB.Structure.FabricSheet`

`T:Autodesk.Revit.DB.Architecture.Stairs` elements which make up `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` elements

`T:Autodesk.Revit.DB.Architecture.Railing`

`!:Autodesk::Revit::DB::Architecture::ContinuousRail`

To get access to a particular Subelement, you may use any of the following:
`M:Autodesk.Revit.DB.Subelement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

`M:Autodesk.Revit.DB.Subelement.IsValidSubelementReference(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Autodesk.Revit.DB.Document.GetSubelement(Autodesk.Revit.DB.Reference) if you have a Reference to a Subelement.

Autodesk.Revit.DB.Document.GetSubelement(String) if you have a unique id of a Subelement.

`M:Autodesk.Revit.DB.Element.GetSubelements`

#### Since

2018

### `M:Autodesk.Revit.DB.Reference.Refresh`

Member kind: method
Symbol: `Autodesk.Revit.DB.Reference.Refresh`

#### Summary

Attempts to refresh the geometry object stored in this reference.

#### Remarks

After a change has been made to Revit geometry, the stored geometry object in
a Reference handle may become invalid. This method attempts to re-obtain the geometry
object from the current geometry.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Unable to refresh geometry object for this Reference.
This may be because the geometry object referred to no longer exists in the current Revit geometry.

### `M:Autodesk.Revit.DB.Reference.Contains(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Reference.Contains(Autodesk.Revit.DB.Reference)`

#### Summary

Checks if given reference identifies part of object identified by this reference.

#### Remarks

Can be used to check:
If given Reference is a part of a particular Subelement identified by this Reference.

If given Reference is a part of a particular Element identified by this Reference.
The input reference can refer to a subelement or a specific geometric item from an element or subelement.

#### Parameter `reference`

Another reference.

#### Returns

Returns true if given reference identifies part of object identified by this reference, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when argument is `null` .

#### Since

2018

### `M:Autodesk.Revit.DB.Reference.EqualTo(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Reference.EqualTo(Autodesk.Revit.DB.Reference)`

#### Summary

Checks if given reference is equal to this reference.

#### Parameter `reference`

Another reference.

#### Returns

Returns true if given reference is equal to this reference, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when argument is `null` .

#### Since

2018

### `M:Autodesk.Revit.DB.Reference.ParseFromStableRepresentation(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Reference.ParseFromStableRepresentation(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Converts a stable String representation of a reference to a Reference object.

#### Remarks

Use `M:Autodesk.Revit.DB.Reference.ConvertToStableRepresentation(Autodesk.Revit.DB.Document)` to obtain the representation.
The Reference will have only the following information set:
`P:Autodesk.Revit.DB.Reference.ElementReferenceType`

`P:Autodesk.Revit.DB.Reference.ElementId`
You will also be able to pass the reference to Document.GetElement(reference) and Element.GetGeometryObjectFromReference(reference)
to obtain the element and geometry object referred to.

#### Parameter `document`

The document.

#### Parameter `representation`

The reference representation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

One or more arguments was `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Reference representation could not be successfully parsed, or element id obtained
from reference representation could not be found in this document.

### `M:Autodesk.Revit.DB.Reference.ConvertToStableRepresentation(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Reference.ConvertToStableRepresentation(Autodesk.Revit.DB.Document)`

#### Summary

Converts the reference to a stable String representation.

#### Remarks

The stable representation can be used to preserve and restore the reference later in the
same Revit session or even in a different session where the same document is present. Use
`M:Autodesk.Revit.DB.Reference.ParseFromStableRepresentation(Autodesk.Revit.DB.Document,System.String)` to restore the reference.
The representation is based on the internal Revit structure and is not intended to be parsed expect by
`M:Autodesk.Revit.DB.Reference.ParseFromStableRepresentation(Autodesk.Revit.DB.Document,System.String)` .

#### Parameter `document`

The document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

document was `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidObjectException`

Reference contained element ids not found in this document.

### `P:Autodesk.Revit.DB.Reference.UVPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Reference.UVPoint`

#### Summary

The UV parameters of the reference, if the reference contains a face.

#### Remarks

This value is valid only for references of type REFERENCE_TYPE_SURFACE.
It is `null` for all other types.

### `P:Autodesk.Revit.DB.Reference.GlobalPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Reference.GlobalPoint`

#### Summary

The position on which the reference is hit.

#### Remarks

When using a plan view, the Z-value of a GlobalPoint is not meaningful.

#### Returns

`null` if the reference doesn't have a global point.

### `P:Autodesk.Revit.DB.Reference.ElementReferenceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Reference.ElementReferenceType`

#### Summary

The type of reference.

### `P:Autodesk.Revit.DB.Reference.LinkedElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Reference.LinkedElementId`

#### Summary

The id of the top-level element in the linked document that is referred to by this reference.

#### Remarks

InvalidElementId will be returned for references that don't refer to an element in a linked RVT file.

#### Since

2014

### `P:Autodesk.Revit.DB.Reference.ElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Reference.ElementId`

#### Summary

The element id for this reference.

#### Remarks

InvalidElementId will be returned for references that don't refer to a particular element.

#### Since

2012

### `M:Autodesk.Revit.DB.Reference.CreateReferenceInLink`

Member kind: method
Symbol: `Autodesk.Revit.DB.Reference.CreateReferenceInLink`

#### Summary

Creates a Reference in an RVT Link from a Reference in the RVT host file.

#### Since

2014

### `M:Autodesk.Revit.DB.Reference.CreateLinkReference(Autodesk.Revit.DB.RevitLinkInstance)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Reference.CreateLinkReference(Autodesk.Revit.DB.RevitLinkInstance)`

#### Summary

Creates a Reference from a Reference in an RVT Link.

#### Parameter `revitLinkInstance`

Id of the RevitLinkInstance that contains the reference.

#### Remarks

The reference that is returned can be used to create a family instance on a face in an RVT link.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when revitLinkInstance is `null` .

#### Since

2014

### `M:Autodesk.Revit.DB.Reference.#ctor(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Reference.#ctor(Autodesk.Revit.DB.Element)`

#### Summary

Creates a Reference with the supplied element.

#### Parameter `element`

The element to create a reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the parameter is `null` .

#### Since

2011

### `T:Autodesk.Revit.DB.Reference`

Member kind: type
Symbol: `Autodesk.Revit.DB.Reference`

#### Summary

A stable reference to a geometric object in a Revit model.

### `M:Autodesk.Revit.DB.Architecture.Room.IsPointInRoom(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Room.IsPointInRoom(Autodesk.Revit.DB.XYZ)`

#### Summary

Determines if a point lies within the volume of the room.

#### Parameter `point`

Point to be checked.

#### Return

Returns true if the point is in the room, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the point is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The coordinates of the point is not a number.

### `M:Autodesk.Revit.DB.Architecture.Room.Unplace`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Room.Unplace`

#### Summary

Remove the room from its location, but the project still contains the room.
The room can be placed in another location after unplaced.

#### Remarks

Note that current room is changed to unplaced and all corresponding rooms which in other group instance are deleted
when in group edit mode.

### `P:Autodesk.Revit.DB.Architecture.Room.Volume`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Room.Volume`

#### Summary

Get the Volume of the Room.

#### Remarks

This property is used to get the Volume of the Room.

### `P:Autodesk.Revit.DB.Architecture.Room.UnboundedHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Room.UnboundedHeight`

#### Summary

Get the Unbounded Height of the Room.

#### Remarks

This property is used to get the Unbounded Height of the Room.

### `P:Autodesk.Revit.DB.Architecture.Room.BaseOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Room.BaseOffset`

#### Summary

Get or Set the Base Offset of the Room.

#### Remarks

This property is used to get or set the Base Offset of the Room.

### `P:Autodesk.Revit.DB.Architecture.Room.LimitOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Room.LimitOffset`

#### Summary

Get or Set the Limit Offset of the Room.

#### Remarks

This property is used to get or set the Limit Offset of the Room.

### `P:Autodesk.Revit.DB.Architecture.Room.UpperLimit`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Room.UpperLimit`

#### Summary

Get or Set the Upper Limit of the Room.

#### Remarks

This property is used to get or set the Upper Limit of the Room.

### `P:Autodesk.Revit.DB.Architecture.Room.ClosedShell`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Room.ClosedShell`

#### Summary

Return the closedShell of the Room.

### `T:Autodesk.Revit.DB.Architecture.Room`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.Room`

#### Summary

Provides access to the room topology in Autodesk Revit.

#### Remarks

The room object can be queried for its boundary for use in space planning tools.

### `M:Autodesk.Revit.DB.SpatialElement.GetSpatialElementDomainData`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElement.GetSpatialElementDomainData`

#### Summary

Gets the domain data for the spatial element. The domain data contains information of different spatial elements, such as electrical load area. Currently room/space/area don't have domain data.

#### Returns

Returns a pointer to the base class for specific domain requirements for the spatial element.

#### Since

2023

### `P:Autodesk.Revit.DB.SpatialElement.SpatialElementType`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElement.SpatialElementType`

#### Summary

The spatial element type.

#### Since

2023

### `P:Autodesk.Revit.DB.SpatialElement.Perimeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElement.Perimeter`

#### Summary

The perimeter.

### `P:Autodesk.Revit.DB.SpatialElement.Area`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElement.Area`

#### Summary

The area.

### `P:Autodesk.Revit.DB.SpatialElement.Location`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElement.Location`

#### Summary

The location of the element.

#### Remarks

This is the location of the room within the level. The
Z location should be the elevation of the level and not changeable.

### `P:Autodesk.Revit.DB.SpatialElement.Number`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElement.Number`

#### Summary

The number.

### `M:Autodesk.Revit.DB.SpatialElement.GetBoundarySegments(Autodesk.Revit.DB.SpatialElementBoundaryOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElement.GetBoundarySegments(Autodesk.Revit.DB.SpatialElementBoundaryOptions)`

#### Summary

Returns the boundary segments.

#### Parameter `options`

The SpatialElementBoundaryOptions.

#### Remarks

This method is used to retrieve the segments that constitute the boundary of the spatial element.
Each spatial element may have several regions, each of which have several segments hence the data is returned
in the form of an array of boundary segment arrays. See the BoundarySegment object for more
details about the segments that make up the spatial element topology.

#### Since

2012

### `P:Autodesk.Revit.DB.SpatialElement.Level`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElement.Level`

#### Summary

Gets the level of the room.

### `P:Autodesk.Revit.DB.SpatialElement.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElement.Name`

#### Summary

A human readable name for the Element.

#### Remarks

The Name property is a human readable name for the element, such as Wall.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the name of the element cannot be changed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the element requires a unique name and a non-unique name is set.

### `T:Autodesk.Revit.DB.SpatialElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpatialElement`

#### Summary

Represents an enclosed area or volume in the Revit model.

### `M:Autodesk.Revit.DB.BoundarySegment.GetCurve`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundarySegment.GetCurve`

#### Summary

Get a copy of the curve that is formed along this boundary.

#### Returns

A copy of the curve.

#### Since

2016

### `P:Autodesk.Revit.DB.BoundarySegment.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundarySegment.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.BoundarySegment.ElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundarySegment.ElementId`

#### Summary

Retrieve the id of the element that produces this boundary segment.
If the segment is created from an element in a link, this is the id of the RevitLinkInstance.

#### Since

2016

### `P:Autodesk.Revit.DB.BoundarySegment.LinkElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundarySegment.LinkElementId`

#### Summary

Retrieve the element id of the element in a link instance that forms this boundary.

#### Since

2016

### `T:Autodesk.Revit.DB.BoundarySegment`

Member kind: type
Symbol: `Autodesk.Revit.DB.BoundarySegment`

#### Summary

An object that represents a segment of an area boundary.

#### Remarks

These objects define the exterior boundary of an area. The geometry of the
segment can be retrieved along with the id of the element that is responsible for producing that boundary.

### `P:Autodesk.Revit.DB.SpatialElementBoundaryOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementBoundaryOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.SpatialElementBoundaryOptions.SpatialElementBoundaryLocation`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementBoundaryOptions.SpatialElementBoundaryLocation`

#### Summary

The boundary of spatial element for geometry calculation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.SpatialElementBoundaryOptions.StoreFreeBoundaryFaces`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementBoundaryOptions.StoreFreeBoundaryFaces`

#### Summary

Indicates whether to include the free boundary faces in the result.

#### Remarks

A free subface is a portion of a spatial element face that is not (partially) coincident with a face of a bounding element.

#### Since

2012

### `M:Autodesk.Revit.DB.SpatialElementBoundaryOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementBoundaryOptions.#ctor`

#### Summary

Constructs default options for calculation of the geometry of spatial elements (rooms, spaces).

#### Since

2012

### `T:Autodesk.Revit.DB.SpatialElementBoundaryOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpatialElementBoundaryOptions`

#### Summary

Options that can be passed to a SpatialElementBoundaryCalculator to influence the results of the calculation.

#### Since

2012

### `M:Autodesk.Revit.DB.AreaVolumeSettings.SetSpatialElementBoundaryLocation(Autodesk.Revit.DB.SpatialElementBoundaryLocation,Autodesk.Revit.DB.SpatialElementType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AreaVolumeSettings.SetSpatialElementBoundaryLocation(Autodesk.Revit.DB.SpatialElementBoundaryLocation,Autodesk.Revit.DB.SpatialElementType)`

#### Summary

Sets the spatial element boundary location of a spatial element type.

#### Parameter `spatialElementBoundaryLocation`

The boundary location.

#### Parameter `spType`

The spatial element type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Currently only SpatialElementType.Room is permitted when setting the boundary location.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.AreaVolumeSettings.GetSpatialElementBoundaryLocation(Autodesk.Revit.DB.SpatialElementType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AreaVolumeSettings.GetSpatialElementBoundaryLocation(Autodesk.Revit.DB.SpatialElementType)`

#### Summary

Gets the spatial element boundary location based on spatial element type.

#### Parameter `spType`

The spatial element type.

#### Returns

The boundary location.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.AreaVolumeSettings.GetAreaVolumeSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AreaVolumeSettings.GetAreaVolumeSettings(Autodesk.Revit.DB.Document)`

#### Summary

Get the area and volume settings of the project.

#### Parameter `aDoc`

The document.

#### Returns

The area and volume settings of the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.AreaVolumeSettings.ComputeVolumes`

Member kind: property
Symbol: `Autodesk.Revit.DB.AreaVolumeSettings.ComputeVolumes`

#### Summary

True to enable volume computation. False to disable it.

#### Remarks

When this setting is False, rooms and spaces will be treated as simple extrusions of their 2d boundaries.
The volume parameter will report "not computed".
When this setting is True, the geometry of rooms and spaces will be trimmed
when it intersects elements such as ceilings, roofs, and floors.

#### Since

2014

### `T:Autodesk.Revit.DB.AreaVolumeSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.AreaVolumeSettings`

#### Summary

This class provides access to settings related to volume and area computations.

#### Since

2014

### `T:Autodesk.Revit.DB.SpatialElementBoundaryLocation`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpatialElementBoundaryLocation`

#### Summary

An enumerated type listing boundary options of spatial element geometry calculation.

### `F:Autodesk.Revit.DB.SpatialElementBoundaryLocation.CoreCenter`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpatialElementBoundaryLocation.CoreCenter`

#### Summary

Spatial element core center.

### `F:Autodesk.Revit.DB.SpatialElementBoundaryLocation.CoreBoundary`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpatialElementBoundaryLocation.CoreBoundary`

#### Summary

Spatial element core boundary.

### `F:Autodesk.Revit.DB.SpatialElementBoundaryLocation.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpatialElementBoundaryLocation.Center`

#### Summary

Spatial element centerline.

### `F:Autodesk.Revit.DB.SpatialElementBoundaryLocation.Finish`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpatialElementBoundaryLocation.Finish`

#### Summary

Spatial element finish face.

### `T:Autodesk.Revit.DB.SpatialElementType`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpatialElementType`

#### Summary

An enumerated type listing types of spaces.

#### Since

2014

### `F:Autodesk.Revit.DB.SpatialElementType.ElectricalLoadArea`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpatialElementType.ElectricalLoadArea`

#### Summary

Electrical Load Area

### `F:Autodesk.Revit.DB.SpatialElementType.Space`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpatialElementType.Space`

#### Summary

Space

### `F:Autodesk.Revit.DB.SpatialElementType.Area`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpatialElementType.Area`

#### Summary

Area

### `F:Autodesk.Revit.DB.SpatialElementType.Room`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpatialElementType.Room`

#### Summary

Room

### `M:Autodesk.Revit.DB.RevitLinkInstance.MoveOriginToHostOrigin(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkInstance.MoveOriginToHostOrigin(System.Boolean)`

#### Summary

Moves this link instance so that the internal origin
of the linked document is aligned to the internal origin
of the host document. This is a one-time movement and does not
set up any shared coordinates relationship.

If the rotation angle of the link instance was changed after insertion,
the rotation angle can be preserved or reset to the original insertion angle.

#### Remarks

This operation can only be performed on instances of top-level links.
The internal origin is not necessarily the same location as the Project
Base Point. See `M:Autodesk.Revit.DB.RevitLinkInstance.MoveBasePointToHostBasePoint(System.Boolean)` .

#### Parameter `resetToOriginalRotation`

Sets to true if:

restoring the original insertion angle of the link instance after it is moved
if there was a rotation \ mirror transform on the link instance.

there was no a rotation \ mirror transform on the link instance.

Sets to false to retain the current angle of the link instance after it is moved
if there was a rotation \ mirror transform on the link instance.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RevitLinkInstance is not an instance of a loaded RevitLinkType.
-or-
This RevitLinkInstance is not an instance of a top-level RevitLinkType.
-or-
The operation is not permitted because the element is pinned.

#### Since

2016 SubscriptionUpdate

### `M:Autodesk.Revit.DB.RevitLinkInstance.MoveBasePointToHostBasePoint(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkInstance.MoveBasePointToHostBasePoint(System.Boolean)`

#### Summary

Moves this link instance so that the base point in
the linked document is aligned to the base point in the
host document. This is a one-time movement and does not
set up any shared coordinates relationship.

If the rotation angle of this link instance was changed after insertion,
the rotation angle can be preserved or reset to the original insertion angle.

#### Remarks

The link must be loaded for Revit to find the location of the link's base point.
This operation can only be performed on instances of top-level links.

#### Parameter `resetToOriginalRotation`

Sets to true if:

restoring the original insertion angle of the link instance after it is moved
if there was a rotation \ mirror transform on the link instance.

there was no a rotation \ mirror transform on the link instance.

Sets to false to retain the current angle of the link instance after it is moved
if there was a rotation \ mirror transform on the link instance.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RevitLinkInstance is not an instance of a loaded RevitLinkType.
-or-
This RevitLinkInstance is not an instance of a top-level RevitLinkType.
-or-
The operation is not permitted because the element is pinned.

#### Since

2016 SubscriptionUpdate

### `M:Autodesk.Revit.DB.RevitLinkInstance.GetLinkDocument`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkInstance.GetLinkDocument`

#### Summary

The document associated with the Revit link.

#### Remarks

Operations that require a transaction or modify the document's status in memory (such as Save and Close) cannot be performed on this document.

#### Since

2014

### `M:Autodesk.Revit.DB.RevitLinkInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ImportPlacement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ImportPlacement)`

#### Summary

Creates a new instance of a linked Revit project (RevitLinkType).

#### Remarks

Instances will be placed origin-to-origin or by shared coordinates.

This function cannot be used to create instances
of nested links.

#### Parameter `document`

The document in which the new instance should be created.

#### Parameter `revitLinkTypeId`

The element id of the RevitLinkType.

#### Parameter `placement`

The mode where to place the RevitLinkInstance.
Set this option to place the view at the origin or by shared coordinates.

#### Returns

The newly-created RevitLinkInstance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

revitLinkTypeId isn't a RevitLinkType.
-or-
revitLinkTypeId is not a top-level link.
-or-
revitLinkTypeId is not a loaded RevitLinkType
-or-
document is not a project document.
-or-
placement isn't supported.Only Origin or Shared placement is supported.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The placement is Shared, and the host model and the link do not share the same coordinate system.
Or the placement is Shared, and the shared coordinates of the host model do not match the GIS coordinate system of the linked file.

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

2018

### `M:Autodesk.Revit.DB.RevitLinkInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of a linked Revit project (RevitLinkType).

#### Remarks

Instances will be placed origin-to-origin.

This function cannot be used to create instances
of nested links.

#### Parameter `document`

The document in which the new instance should be created.

#### Parameter `revitLinkTypeId`

The element id of the RevitLinkType.

#### Returns

The newly-created RevitLinkInstance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

revitLinkTypeId isn't a RevitLinkType.
-or-
revitLinkTypeId is not a top-level link.
-or-
revitLinkTypeId is not a loaded RevitLinkType
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

### `T:Autodesk.Revit.DB.RevitLinkInstance`

Member kind: type
Symbol: `Autodesk.Revit.DB.RevitLinkInstance`

#### Summary

Represents an instance of a RevitLinkType.

#### Since

2013

### `P:Autodesk.Revit.DB.AXMImportOptions.CreateMassfloors`

Member kind: property
Symbol: `Autodesk.Revit.DB.AXMImportOptions.CreateMassfloors`

#### Summary

Indicate if mass floors are to be created.
False by default.
Make sure that levels have been created before open this option.
Or you can set importLevels true at the same time.

#### Since

2022.1

### `P:Autodesk.Revit.DB.AXMImportOptions.ImportLevels`

Member kind: property
Symbol: `Autodesk.Revit.DB.AXMImportOptions.ImportLevels`

#### Summary

Indicate if levels are to be imported.
False by default.

#### Since

2022.1

### `M:Autodesk.Revit.DB.AXMImportOptions.#ctor(Autodesk.Revit.DB.AXMImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AXMImportOptions.#ctor(Autodesk.Revit.DB.AXMImportOptions)`

#### Summary

Constructs a new instance of AXMImportOptions as a copy of the provided import options.

#### Parameter `option`

The AXM import options to be copied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022.1

### `M:Autodesk.Revit.DB.AXMImportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.AXMImportOptions.#ctor`

#### Summary

Constructs a new instance of AXMImportOptions with default values of all properties.

#### Since

2022.1

### `T:Autodesk.Revit.DB.AXMImportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.AXMImportOptions`

#### Summary

The import options used to import AXM format files.

#### Since

2022.1

### `M:Autodesk.Revit.DB.ImportOptions3DM.#ctor(Autodesk.Revit.DB.ImportOptions3DM)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportOptions3DM.#ctor(Autodesk.Revit.DB.ImportOptions3DM)`

#### Summary

Constructs a new instance of ImportOptions3DM as a copy of the provided import options.

#### Parameter `option`

The 3DM import options to be copied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ImportOptions3DM.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportOptions3DM.#ctor`

#### Summary

Constructs a new instance of ImportOptions3DM with default values of all properties.

#### Since

2022

### `T:Autodesk.Revit.DB.ImportOptions3DM`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImportOptions3DM`

#### Summary

The import options used to import 3DM format files.

#### Since

2022

### `M:Autodesk.Revit.DB.STLImportOptions.#ctor(Autodesk.Revit.DB.STLImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.STLImportOptions.#ctor(Autodesk.Revit.DB.STLImportOptions)`

#### Summary

Constructs a new instance of STLImportOptions as a copy of the import options.

#### Parameter `option`

The STL options to be copied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022.1

### `M:Autodesk.Revit.DB.STLImportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.STLImportOptions.#ctor`

#### Summary

Constructs a new instance of STLImportOptions with default values of all properties.

#### Since

2022.1

### `T:Autodesk.Revit.DB.STLImportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.STLImportOptions`

#### Summary

The import options used to import STL format files.

#### Since

2022.1

### `M:Autodesk.Revit.DB.OBJImportOptions.#ctor(Autodesk.Revit.DB.OBJImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.OBJImportOptions.#ctor(Autodesk.Revit.DB.OBJImportOptions)`

#### Summary

Constructs a new instance of OBJImportOptions as a copy of the import options.

#### Parameter `option`

The OBJ options to be copied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022.1

### `M:Autodesk.Revit.DB.OBJImportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.OBJImportOptions.#ctor`

#### Summary

Constructs a new instance of OBJImportOptions with default values of all properties.

#### Since

2022.1

### `T:Autodesk.Revit.DB.OBJImportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.OBJImportOptions`

#### Summary

The import options used to import OBJ format files.

#### Since

2022.1

### `M:Autodesk.Revit.DB.SKPImportOptions.#ctor(Autodesk.Revit.DB.SKPImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SKPImportOptions.#ctor(Autodesk.Revit.DB.SKPImportOptions)`

#### Summary

Constructs a new instance of SKPImportOptions as a copy of the import options.

#### Parameter `option`

The SKP options to be copied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.SKPImportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.SKPImportOptions.#ctor`

#### Summary

Constructs a new instance of SKPImportOptions with default values of all properties.

#### Since

2014

### `T:Autodesk.Revit.DB.SKPImportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.SKPImportOptions`

#### Summary

The import options used to import SKP format files.

#### Since

2014

### `M:Autodesk.Revit.DB.DWFImportOptions.GetSheetViews`

Member kind: method
Symbol: `Autodesk.Revit.DB.DWFImportOptions.GetSheetViews`

#### Summary

Get sheet views where DWF markups are imported.

#### Returns

An array of sheet views

#### Since

2014

### `M:Autodesk.Revit.DB.DWFImportOptions.SetSheetViews(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DWFImportOptions.SetSheetViews(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Set sheet views where DWF markups are imported.

#### Parameter `sheetViews`

An array of imported sheet views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.DWFImportOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DWFImportOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.DWFImportOptions.#ctor(Autodesk.Revit.DB.DWFImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DWFImportOptions.#ctor(Autodesk.Revit.DB.DWFImportOptions)`

#### Summary

Constructs a new instance of DWFImportOptions as a copy of the import options.

#### Parameter `option`

The options to be copied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.DWFImportOptions.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DWFImportOptions.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Constructs a new instance of DWFImportOptions with an array of imported sheet views.

#### Parameter `views`

These sheet views where DWF markups are imported.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.DWFImportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DWFImportOptions`

#### Summary

The import options used by importing DWF or DWFx format file.

#### Since

2014

### `M:Autodesk.Revit.DB.SATImportOptions.#ctor(Autodesk.Revit.DB.SATImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SATImportOptions.#ctor(Autodesk.Revit.DB.SATImportOptions)`

#### Summary

Constructs a new instance of SATImportOptions as a copy of the import options.

#### Parameter `option`

The SAT options to be copied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.SATImportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.SATImportOptions.#ctor`

#### Summary

Constructs a new instance of SATImportOptions with default values of all properties.

#### Since

2014

### `T:Autodesk.Revit.DB.SATImportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.SATImportOptions`

#### Summary

The import options used to import SAT format files.

#### Since

2014

### `P:Autodesk.Revit.DB.DGNImportOptions.DGNModelViewName`

Member kind: property
Symbol: `Autodesk.Revit.DB.DGNImportOptions.DGNModelViewName`

#### Summary

The model view name to be imported.
Need user give a model view name to specify which model view need to be imported into Revit

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.DGNImportOptions.IgnoreUnsupportedElementWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.DGNImportOptions.IgnoreUnsupportedElementWarning`

#### Summary

If true, ignore warning messages about unsupported elements in the DGN file.
If false, the import process is aborted if imported dgn files have unsupported elements.

#### Since

2013

### `M:Autodesk.Revit.DB.DGNImportOptions.#ctor(Autodesk.Revit.DB.DGNImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DGNImportOptions.#ctor(Autodesk.Revit.DB.DGNImportOptions)`

#### Summary

Constructs a new instance of DGNImportOptions as a copy of the import options.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.DGNImportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DGNImportOptions.#ctor`

#### Summary

Constructs a new instance of DGNImportOptions with default values of all properties.

#### Since

2013

### `T:Autodesk.Revit.DB.DGNImportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DGNImportOptions`

#### Summary

The import options used to import DGN format files.

#### Since

2013

### `M:Autodesk.Revit.DB.DWGImportOptions.GetLineWeights`

Member kind: method
Symbol: `Autodesk.Revit.DB.DWGImportOptions.GetLineWeights`

#### Summary

Gets array of line weights.

#### Since

2013

### `M:Autodesk.Revit.DB.DWGImportOptions.SetLineWeights(System.Collections.Generic.IList{System.Int32})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DWGImportOptions.SetLineWeights(System.Collections.Generic.IList{System.Int32})`

#### Summary

Set array of line weights.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.DWGImportOptions.#ctor(Autodesk.Revit.DB.DWGImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DWGImportOptions.#ctor(Autodesk.Revit.DB.DWGImportOptions)`

#### Summary

Constructs a new instance of DWGImportOptions as a copy of the import options.

#### Parameter `option`

The options to be copied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.DWGImportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DWGImportOptions.#ctor`

#### Summary

Constructs a new instance of DWGImportOptions with default values of all properties.

#### Since

2013

### `T:Autodesk.Revit.DB.DWGImportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DWGImportOptions`

#### Summary

The import options used by importing DWG or DXF format file.

#### Since

2013

### `M:Autodesk.Revit.DB.BaseImportOptions.GetLayerSelection`

Member kind: method
Symbol: `Autodesk.Revit.DB.BaseImportOptions.GetLayerSelection`

#### Summary

Get all set layers name which user want to import into Revit.

#### Returns

The layers' name.

#### Since

2013

### `M:Autodesk.Revit.DB.BaseImportOptions.SetLayerSelection(System.Collections.Generic.ICollection{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.BaseImportOptions.SetLayerSelection(System.Collections.Generic.ICollection{System.String})`

#### Summary

Set the layers name which user want to import into Revit.

#### Remarks

If user don't set any layer selection, all layers would be imported into Revit for dgn.
But for dwg|dxf, all layers (or visible layers, it is up to visibleLayersOnly was set or not) would be imported into Revit.

#### Parameter `layerSelection`

The layers imported into Revit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.BaseImportOptions.SetDefaultLengthUnit(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BaseImportOptions.SetDefaultLengthUnit(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Set the default length unit used for importing unitless files.

#### Parameter `specTypeId`

The default length unit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given specTypeId is not a supported unit of length.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022.1

### `M:Autodesk.Revit.DB.BaseImportOptions.GetDefaultLengthUnit`

Member kind: method
Symbol: `Autodesk.Revit.DB.BaseImportOptions.GetDefaultLengthUnit`

#### Summary

Get the default length unit used for importing unitless files.

#### Since

2022.1

### `P:Autodesk.Revit.DB.BaseImportOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseImportOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.BaseImportOptions.ReferencePoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseImportOptions.ReferencePoint`

#### Summary

The 3D point in the document where the imported instance will be inserted.
If not explicitly set, the instance will be inserted at the document origin.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.BaseImportOptions.AutoCorrectAlmostVHLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseImportOptions.AutoCorrectAlmostVHLines`

#### Summary

Correct almost-vertical lines and almost-horizontal lines for import model
if option is set to true, the almost-vertical lines would be vertical lines and almost-horizontal lines would be horizontal lines.

#### Since

2013

### `P:Autodesk.Revit.DB.BaseImportOptions.VisibleLayersOnly`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseImportOptions.VisibleLayersOnly`

#### Summary

Only import the visible layers.

#### Remarks

If this option is set to true, only visible layers are imported.
For dgn import, this option is unsupported.

#### Since

2013

### `P:Autodesk.Revit.DB.BaseImportOptions.CustomScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseImportOptions.CustomScale`

#### Summary

Scaling the import.
If this is defined and a valid value (> 0.0), it takes priority over units.

#### Since

2013

### `P:Autodesk.Revit.DB.BaseImportOptions.OrientToView`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseImportOptions.OrientToView`

#### Summary

Place the import at the same orientation as the view that was passed into the import method.
This option can only be used when not importing into a single view.(i.e. ThisViewOnly is set to false)

#### Since

2013

### `P:Autodesk.Revit.DB.BaseImportOptions.ThisViewOnly`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseImportOptions.ThisViewOnly`

#### Summary

Imports drawings into the view that was passed into the import method.
This option is not available in 3D views.

#### Since

2013

### `P:Autodesk.Revit.DB.BaseImportOptions.Placement`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseImportOptions.Placement`

#### Summary

Where to place the import.
Set this option to place the view at the origin or the center, or a shared coordinates.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.BaseImportOptions.ColorMode`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseImportOptions.ColorMode`

#### Summary

Color mode for the import.
Three modes are supported. Black and White, Preserve Colors, and Invert Colors.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.BaseImportOptions.Unit`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseImportOptions.Unit`

#### Summary

The unit of measure for imported geometry.

#### Remarks

Units are used to calculate the import scale unless scale is defined explicitly using CustomScale, in which case Units will be ignored.
Feet, inches, meters, centimeters, decimeters, millimeters are all supported. If Default unit is set, Revit will read and use the units
from the file. If units are not available or accessible there, Revit will default to %overrideUnit%.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `T:Autodesk.Revit.DB.BaseImportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.BaseImportOptions`

#### Summary

A base class containing import options used during import of several formats.

#### Since

2013

### `T:Autodesk.Revit.DB.ImportPlacement`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImportPlacement`

#### Since

2013

#### Summary

An enumerated type listing possible placement modes for imported drawings.

#### Since

2013

### `F:Autodesk.Revit.DB.ImportPlacement.Shared`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportPlacement.Shared`

#### Summary

Placement with respect to the shared coordinates.
Revit Building places the imported geometry according to its location
with respect to the shared coordinates between the two files.
There must be shared coordinates in a Revit document in order for this option to be valid.

### `F:Autodesk.Revit.DB.ImportPlacement.Centered`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportPlacement.Centered`

#### Summary

Placement at the Center.
If reference point is provided, then the import is placed
so the point is at the model's center. If no point is provided,
then the document's center is matched with the model's origin.

### `F:Autodesk.Revit.DB.ImportPlacement.Origin`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportPlacement.Origin`

#### Summary

Placement at the Origin.
If reference point is provided, then the import is placed
so the point is at the model's origin. If no point is provided,
then the document's origin is matched with the model's origin.

### `F:Autodesk.Revit.DB.ImportPlacement.Site`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportPlacement.Site`

#### Summary

Placement at Base Point. Useful for Revit links only.
There must be a reference point in order for this option to be valid.

### `T:Autodesk.Revit.DB.ImportColorMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImportColorMode`

#### Since

2013

#### Summary

An enumerated type listing how colors are handled in an import process.

#### Since

2013

### `F:Autodesk.Revit.DB.ImportColorMode.BlackAndWhite`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportColorMode.BlackAndWhite`

#### Summary

Colors in the imported drawing are converted to Black and White.

### `F:Autodesk.Revit.DB.ImportColorMode.Inverted`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportColorMode.Inverted`

#### Summary

Colors in the imported drawing are inverted.

### `F:Autodesk.Revit.DB.ImportColorMode.Preserved`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportColorMode.Preserved`

#### Summary

Colors in the imported drawing are preserved.

### `T:Autodesk.Revit.DB.ImportUnit`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImportUnit`

#### Since

2013

#### Summary

An enumerated type listing possible target units for CAD Import.

#### Since

2013

### `F:Autodesk.Revit.DB.ImportUnit.USSurveyFoot`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportUnit.USSurveyFoot`

#### Summary

US survey feet as decimal values

### `F:Autodesk.Revit.DB.ImportUnit.Custom`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportUnit.Custom`

#### Summary

Custom values as decimal values

### `F:Autodesk.Revit.DB.ImportUnit.Meter`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportUnit.Meter`

#### Summary

Meters as decimal values.

### `F:Autodesk.Revit.DB.ImportUnit.Decimeter`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportUnit.Decimeter`

#### Summary

Decimeters as decimal values.

### `F:Autodesk.Revit.DB.ImportUnit.Centimeter`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportUnit.Centimeter`

#### Summary

Centimeters as decimal values.

### `F:Autodesk.Revit.DB.ImportUnit.Millimeter`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportUnit.Millimeter`

#### Summary

Millimeters as decimal values.

### `F:Autodesk.Revit.DB.ImportUnit.Foot`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportUnit.Foot`

#### Summary

Feet and Inches in fractional notation.

### `F:Autodesk.Revit.DB.ImportUnit.Inch`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportUnit.Inch`

#### Summary

Inches in fractional notation.

### `F:Autodesk.Revit.DB.ImportUnit.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportUnit.Default`

#### Summary

Unit (if available) from the document that is getting imported.

### `M:Autodesk.Revit.DB.ExternalFileReference.IsValidPathTypeForExternalFileReference(Autodesk.Revit.DB.PathType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalFileReference.IsValidPathTypeForExternalFileReference(Autodesk.Revit.DB.PathType)`

#### Summary

Checks whether a PathType enum value will be valid to
use with this ExternalFileReference.

#### Remarks

PathType.Server is only valid for ExternalFileReferences of type ExternalFileReferenceType.RevitLink

PathType.Content is only valid for ExternalFileReferences of type ExternalFileReferenceType.KeynoteTable,
ExternalFileReferenceType.AssemblyCodeTable and ExternalFileReferenceType.Decal

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.ExternalFileReference.IsValidExternalFileReference(Autodesk.Revit.DB.ExternalFileReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalFileReference.IsValidExternalFileReference(Autodesk.Revit.DB.ExternalFileReference)`

#### Summary

Checks an ExternalFileReference to see if it is
properly created.

#### Remarks

The following restrictions exist:
PathType.Server is only valid for ExternalFileReferences of type ExternalFileReferenceType.RevitLink

PathType.Content is only valid for ExternalFileReferences of type ExternalFileReferenceType.KeynoteTable,
ExternalFileReferenceType.AssemblyCodeTable or ExternalFileReferenceType.Decal

Keynote tables, assembly code tables and Decals (ExternalFileReferenceType.KeynoteTable,
ExternalFileReferenceType.AssemblyCodeTable and ExternalFileReferenceType.Decal) may only be
LinkedFileStatus.Loaded or LinkedFileStatus.NotFound.

#### Parameter `data`

The ExternalFileReference to be checked

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ExternalFileReference.GetReferencingId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalFileReference.GetReferencingId`

#### Summary

Gets the ElementId corresponding to the element which
this ExternalFileReference is associated with.

#### Since

2012

### `M:Autodesk.Revit.DB.ExternalFileReference.GetLinkedFileStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalFileReference.GetLinkedFileStatus`

#### Summary

Returns a LinkedFileStatus.Enum corresponding to the
load status of the referenced file.

#### Remarks

Options are Invalid,
Loaded, Unloaded, NotFound, or Imported.

#### Since

2012

### `M:Autodesk.Revit.DB.ExternalFileReference.GetAbsolutePath`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalFileReference.GetAbsolutePath`

#### Summary

Returns an absolute path to the referenced file,
regardless of whether the PathType.Enum is relative or absolute.

#### Remarks

ExternalFileReferences which are taken from a closed document will
report their absolute path as of the last time the document was saved.

#### Returns

A full path to the linked model.

#### Since

2012

### `M:Autodesk.Revit.DB.ExternalFileReference.GetPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalFileReference.GetPath`

#### Summary

Gets the path of the link, relative or absolute according
to the link's settings

#### Returns

The path of the link. This path will be relative for
relatively-pathed links.

#### Since

2012

### `P:Autodesk.Revit.DB.ExternalFileReference.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalFileReference.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExternalFileReference.ExternalFileReferenceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalFileReference.ExternalFileReferenceType`

#### Summary

The type of external file which this object
references.

#### Since

2012

### `P:Autodesk.Revit.DB.ExternalFileReference.PathType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalFileReference.PathType`

#### Summary

The path type of the link (relative, absolute, or server).

#### Since

2012

### `T:Autodesk.Revit.DB.ExternalFileReference`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalFileReference`

#### Summary

A class that contains the details of a reference to a file outside of a given document.

#### Since

2012

### `T:Autodesk.Revit.DB.MaterialPropertyPathType`

Member kind: type
Symbol: `Autodesk.Revit.DB.MaterialPropertyPathType`

#### Summary

Enum class indicating kinds of paths which ExternalFileReferenceType.Material
references can have.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.MaterialPropertyPathType.Weathering`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialPropertyPathType.Weathering`

#### Summary

Weathering image, for concrete materials

### `F:Autodesk.Revit.DB.MaterialPropertyPathType.ReliefPattern`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialPropertyPathType.ReliefPattern`

#### Summary

Relief pattern, for various material types

### `F:Autodesk.Revit.DB.MaterialPropertyPathType.FinishBumps`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialPropertyPathType.FinishBumps`

#### Summary

Finish bumps, pattern for various material types

### `F:Autodesk.Revit.DB.MaterialPropertyPathType.Bump`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialPropertyPathType.Bump`

#### Summary

Bump pattern, for generic materials

### `F:Autodesk.Revit.DB.MaterialPropertyPathType.Cutouts`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialPropertyPathType.Cutouts`

#### Summary

Cutouts image, for generic or metal materials

### `F:Autodesk.Revit.DB.MaterialPropertyPathType.Transparency`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialPropertyPathType.Transparency`

#### Summary

Transparency image, for generic materials

### `F:Autodesk.Revit.DB.MaterialPropertyPathType.General`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialPropertyPathType.General`

#### Summary

General image, for various material types

### `T:Autodesk.Revit.DB.ExternalFileReferenceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalFileReferenceType`

#### Summary

Enum class indicating kinds of external file references

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.ExternalFileReferenceType.SystemsAnalysisReport`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalFileReferenceType.SystemsAnalysisReport`

#### Summary

Systems analysis report file path

### `F:Autodesk.Revit.DB.ExternalFileReferenceType.AssemblyCodeTable`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalFileReferenceType.AssemblyCodeTable`

#### Summary

The assembly code table (The file which contains assembly code information.)

### `F:Autodesk.Revit.DB.ExternalFileReferenceType.Material`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalFileReferenceType.Material`

#### Summary

Materials are not included as ExternalFileReferences in the 2012 release

### `F:Autodesk.Revit.DB.ExternalFileReferenceType.Decal`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalFileReferenceType.Decal`

#### Summary

Decals (images which appear only during rendering)

### `F:Autodesk.Revit.DB.ExternalFileReferenceType.KeynoteTable`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalFileReferenceType.KeynoteTable`

#### Summary

The keynote table (The file which contains keynote information.)

### `F:Autodesk.Revit.DB.ExternalFileReferenceType.DWFMarkup`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalFileReferenceType.DWFMarkup`

#### Summary

DWF markup files

### `F:Autodesk.Revit.DB.ExternalFileReferenceType.CADLink`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalFileReferenceType.CADLink`

#### Summary

Linked CAD files

### `F:Autodesk.Revit.DB.ExternalFileReferenceType.RevitLink`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalFileReferenceType.RevitLink`

#### Summary

Revit linked files

### `F:Autodesk.Revit.DB.ExternalFileReferenceType.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalFileReferenceType.None`

#### Summary

Uninitialized value

### `M:Autodesk.Revit.DB.GeometryObject.getReferenceForAPIUser`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryObject.getReferenceForAPIUser`

#### Summary

This overload powers the Reference properties which return the reference directly to the user.

### `M:Autodesk.Revit.DB.GeometryObject.GetHashCode`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryObject.GetHashCode`

#### Summary

Gets the integer value of the geometry object as hash code

### `M:Autodesk.Revit.DB.GeometryObject.Equals(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryObject.Equals(System.Object)`

#### Summary

Determines whether the specified `T:System.Object` is equal to the current `T:System.Object` .

#### Remarks

This compares the internal identifiers of the geometry, and doesn't compare them geometrically.

#### Parameter `obj`

Another object.

### `M:Autodesk.Revit.DB.GeometryObject.op_Inequality(Autodesk.Revit.DB.GeometryObject,Autodesk.Revit.DB.GeometryObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryObject.op_Inequality(Autodesk.Revit.DB.GeometryObject,Autodesk.Revit.DB.GeometryObject)`

#### Summary

Determines whether two GeometryObjects are different.

#### Remarks

This compares the internal identifiers of the geometry, and doesn't compare them geometrically.

#### Parameter `first`

The first GeometryObject.

#### Parameter `second`

The second GeometryObject.

#### Returns

True if the GeometryObjects are different; otherwise, false.

### `M:Autodesk.Revit.DB.GeometryObject.op_Equality(Autodesk.Revit.DB.GeometryObject,Autodesk.Revit.DB.GeometryObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryObject.op_Equality(Autodesk.Revit.DB.GeometryObject,Autodesk.Revit.DB.GeometryObject)`

#### Summary

Determines whether two GeometryObjects are the same.

#### Remarks

This compares the internal identifiers of the geometry, and doesn't compare them geometrically.

#### Parameter `first`

The first GeometryObject.

#### Parameter `second`

The second GeometryObject.

#### Returns

True if the GeometryObjects are the same; otherwise, false.

### `P:Autodesk.Revit.DB.GeometryObject.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.GeometryObject.Id`

#### Summary

A unique integer identifying the GeometryObject in its associated non view-specific GeometryElement.

#### Remarks

This id can be stored and used for future referencing. The reference should be stable between minor geometric changes and modifications,
but may not remain valid if there are major changes to the element or its surroundings.
Note that the id may be negative(and thus invalid for referencing) if obtained from view - specific geometry,
or if obtained from most GeometryObjects created in memory by the API. Negative ids cannot be used for referencing.
These integer ids should not be used for comparison purposes(other than to check if they are equivalent or not).
Nothing should be assumed about rules about how an element populates the sequence of different numeric values as this may change based on the element's definition.

#### Since

2021

### `P:Autodesk.Revit.DB.GeometryObject.IsElementGeometry`

Member kind: property
Symbol: `Autodesk.Revit.DB.GeometryObject.IsElementGeometry`

#### Summary

Indicates whether this geometry is obtained directly from an Element.

#### Since

2012

### `P:Autodesk.Revit.DB.GeometryObject.GraphicsStyleId`

Member kind: property
Symbol: `Autodesk.Revit.DB.GeometryObject.GraphicsStyleId`

#### Summary

The ElementId of the GeometryObject's GraphicsStyle

#### Remarks

This property provides the id of the GraphicsStyle assigned to the GeometryObject.
This can be used to find the category of the object.

#### Since

2012

### `M:Autodesk.Revit.DB.GeometryObject.set_Visibility(Autodesk.Revit.DB.Visibility)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryObject.set_Visibility(Autodesk.Revit.DB.Visibility)`

#### Since

2024

### `P:Autodesk.Revit.DB.GeometryObject.Visibility`

Member kind: property
Symbol: `Autodesk.Revit.DB.GeometryObject.Visibility`

#### Summary

The visibility.

#### Remarks

The visibility of this object has no effect on the visibility of objects contained within this object.
For example, the visibility of a Solid may be Contextual but the faces within that solid may still be Visible.

### `T:Autodesk.Revit.DB.GeometryObject`

Member kind: type
Symbol: `Autodesk.Revit.DB.GeometryObject`

#### Summary

The common base class for all geometric primitives.

### `T:Autodesk.Revit.DB.Visibility`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visibility`

#### Summary

Describes the visibility of a particular geometry object.

### `F:Autodesk.Revit.DB.Visibility.Invisible`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visibility.Invisible`

#### Summary

The geometry object is never visible. This type of geometry is never returned by
`P:Autodesk.Revit.DB.Element.Geometry(Autodesk.Revit.DB.Options)` but may be obtained by other
API operations.

### `F:Autodesk.Revit.DB.Visibility.Contextual`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visibility.Contextual`

#### Summary

The geometry object is visible in some contexts, but not in others. This type of geometry is always returned by
`P:Autodesk.Revit.DB.Element.Geometry(Autodesk.Revit.DB.Options)` ,
even when Revit is in a context where the geometry should not be visible, but only if
`P:Autodesk.Revit.DB.Options.IncludeNonVisibleObjects` is true.
Examples of geometry of this class include Solids representing insulation and lining for MEP ducts and pipes.

### `F:Autodesk.Revit.DB.Visibility.Highlight`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visibility.Highlight`

#### Summary

The geometry object is visible, but is affected by highlight or prehighlight special coloration.
This type of geometry is returned by `P:Autodesk.Revit.DB.Element.Geometry(Autodesk.Revit.DB.Options)`
if `P:Autodesk.Revit.DB.Options.IncludeNonVisibleObjects` is true.

### `F:Autodesk.Revit.DB.Visibility.Visible`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visibility.Visible`

#### Summary

The geometry object is always visible. This type of geometry is always returned by
`P:Autodesk.Revit.DB.Element.Geometry(Autodesk.Revit.DB.Options)`

### `M:Autodesk.Revit.DB.Options.set_CanComputeReferences(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Options.set_CanComputeReferences(System.Boolean)`

#### Summary

Enables computing of references to geometric objects.

### `M:Autodesk.Revit.DB.Options.get_CanComputeReferences`

Member kind: method
Symbol: `Autodesk.Revit.DB.Options.get_CanComputeReferences`

#### Summary

Checks whether references to geometric objects are computed.

### `P:Autodesk.Revit.DB.Options.CanComputeReferences`

Member kind: property
Symbol: `Autodesk.Revit.DB.Options.CanComputeReferences`

#### Summary

Determines whether or not references to geometric objects are allowed.

### `P:Autodesk.Revit.DB.Options.IncludeNonVisibleObjects`

Member kind: property
Symbol: `Autodesk.Revit.DB.Options.IncludeNonVisibleObjects`

#### Summary

Whether to extract element geometry objects not set as Visible. The default is false.

### `M:Autodesk.Revit.DB.Options.set_View(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Options.set_View(Autodesk.Revit.DB.View)`

#### Summary

Sets the view that drives extraction of geometry.

### `M:Autodesk.Revit.DB.Options.get_View`

Member kind: method
Symbol: `Autodesk.Revit.DB.Options.get_View`

#### Summary

Retrieves the view that was set for this object.

### `P:Autodesk.Revit.DB.Options.View`

Member kind: property
Symbol: `Autodesk.Revit.DB.Options.View`

#### Summary

The view used for geometry extraction.

#### Remarks

If a view-specific version of an element exists, it will be extracted in the
retrieval of geometry. Also, the detail level of the geometry will be taken from the
view's detail level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when setting this property with a `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when setting this property,
if DetailLevel is already set. When DetailLevel is set view-specific geometry can't be
extracted.

### `M:Autodesk.Revit.DB.Options.set_ComputeReferences(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Options.set_ComputeReferences(System.Boolean)`

#### Summary

Enables computing of references to geometric objects.

### `M:Autodesk.Revit.DB.Options.get_ComputeReferences`

Member kind: method
Symbol: `Autodesk.Revit.DB.Options.get_ComputeReferences`

#### Summary

Checks whether references to geometric objects are computed.

### `P:Autodesk.Revit.DB.Options.ComputeReferences`

Member kind: property
Symbol: `Autodesk.Revit.DB.Options.ComputeReferences`

#### Summary

Determines whether or not references to geometric objects are computed.

### `M:Autodesk.Revit.DB.Options.set_DetailLevel(Autodesk.Revit.DB.ViewDetailLevel)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Options.set_DetailLevel(Autodesk.Revit.DB.ViewDetailLevel)`

#### Summary

Sets the preferred detail level.

### `M:Autodesk.Revit.DB.Options.get_DetailLevel`

Member kind: method
Symbol: `Autodesk.Revit.DB.Options.get_DetailLevel`

#### Summary

Returns the preferred detail level.

### `P:Autodesk.Revit.DB.Options.DetailLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Options.DetailLevel`

#### Summary

The detail level for the geometry extracted with these options.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when setting this property,
if View is already set. When View is set the detail level of the view is used.

### `M:Autodesk.Revit.DB.Options.#ctor(Autodesk.Revit.DB.Options)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Options.#ctor(Autodesk.Revit.DB.Options)`

#### Summary

Copy constructor.

### `M:Autodesk.Revit.DB.Options.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Options.#ctor`

#### Summary

Creates a default Options object.

#### Remarks

Defaults to medium detail, no references and no view.

### `T:Autodesk.Revit.DB.Options`

Member kind: type
Symbol: `Autodesk.Revit.DB.Options`

#### Summary

User preferences for parsing of geometry.

#### Remarks

This class determines the output of the Element.Geometry property.

### `P:Autodesk.Revit.DB.ExternalResourceMatchOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceMatchOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExternalResourceMatchOptions.ResourceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceMatchOptions.ResourceType`

#### Summary

The desired resource type which external resources should match.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceMatchOptions.#ctor(Autodesk.Revit.DB.ExternalResourceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceMatchOptions.#ctor(Autodesk.Revit.DB.ExternalResourceType)`

#### Summary

Constructs new instance with specified resource type.

#### Parameter `resourceType`

The desired resource type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.ExternalResourceMatchOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceMatchOptions`

#### Summary

Represents match options used to filter external resources when listing them from external resource server.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceType.op_Inequality(Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceType.op_Inequality(Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceType)`

#### Summary

Compares two ExternalResourceType instances.

#### Parameter `first`

The first ExternalResourceType.

#### Parameter `second`

The second ExternalResourceType.

#### Returns

True if the inputs are different, false if they are identical.

### `M:Autodesk.Revit.DB.ExternalResourceType.op_Equality(Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceType.op_Equality(Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceType)`

#### Summary

Compares two ExternalResourceType instances.

#### Parameter `first`

The first ExternalResourceType.

#### Parameter `second`

The second ExternalResourceType.

#### Returns

True if the inputs are identical, false if they are different.

### `M:Autodesk.Revit.DB.ExternalResourceType.#ctor(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceType.#ctor(System.Guid)`

#### Summary

Creates a new ExternalResourceType instance.

#### Parameter `guid`

The identifier for the ExternalResourceType.

### `T:Autodesk.Revit.DB.ExternalResourceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceType`

#### Summary

A type class used to distinguish between different kinds of external resource.

#### Remarks

Revit elements can consume multiple types of external resource data, provided by one or more
external servers. Conversely, external servers can support one, or more than one, type of
external resource.

#### Since

2015

### `M:Autodesk.Revit.DB.GuidEnum.GetHashCode`

Member kind: method
Symbol: `Autodesk.Revit.DB.GuidEnum.GetHashCode`

#### Summary

Generates a hash code for this Guid-based enum object.

### `M:Autodesk.Revit.DB.GuidEnum.Equals(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GuidEnum.Equals(System.Object)`

#### Summary

Compares two Guid-based enum object based on their concrete class and GUID value.

### `P:Autodesk.Revit.DB.GuidEnum.Guid`

Member kind: property
Symbol: `Autodesk.Revit.DB.GuidEnum.Guid`

#### Summary

The Guid of GUID-based enum object.

### `M:Autodesk.Revit.DB.GuidEnum.#ctor(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GuidEnum.#ctor(System.Guid)`

#### Summary

Creates an Guid-based enum instance with the supplied name and GUID.
GUID-based enum instance can be compared by this guid value.

#### Parameter `guid`

The GUID of this GUID-based enum.

### `T:Autodesk.Revit.DB.GuidEnum`

Member kind: type
Symbol: `Autodesk.Revit.DB.GuidEnum`

#### Summary

Base class of all GUID-based enum classes.

### `M:Autodesk.Revit.DB.ExternalResourceReference.CreateFromCloudPath(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReference.CreateFromCloudPath(Autodesk.Revit.DB.ModelPath)`

#### Summary

Creates an ExternalResourceReference from a cloud path.

#### Parameter `path`

A cloud path.

#### Returns

The newly-created reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given path path is not a cloud path which is not supported in this method.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The model is not allowed to access.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the cloud model.

#### Since

2022

### `M:Autodesk.Revit.DB.ExternalResourceReference.HasValidDisplayPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReference.HasValidDisplayPath`

#### Summary

Checks whether this external Resource has a valid display path.

#### Remarks

For an external resource, such as a Revit link loaded from an external server, the valid display path
should be like "My Server://Nested/Nested_1.rvt".
For an external resource, such as a Revit link loaded from the "built-in" server, the valid display path
should be like "c:\LocalLinks\Link_1.rvt".

#### Returns

True if the this external Resource has a valid display path. False otherwise.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceReference.GetResourceShortDisplayName`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReference.GetResourceShortDisplayName`

#### Summary

Gets the short display name of the external resource.

#### Remarks

For an external resource, such as a Rvt Link loaded from an external server, which has a full display path
such as "My Server://Nested/Nested_1.rvt", this function returns "Nested_1.rvt".
For an external resource, such as a Rvt Link loaded from the "built-in" server, which has a full display path
such as "c:\LocalLinks\Link_1.rvt", this function returns "Link_1.rvt".

#### Returns

The short display name of the external resource.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The ExternalResourceReference (this ExternalResourceReference) is has no valid display path.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceReference.GetResourceVersionStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReference.GetResourceVersionStatus`

#### Summary

Checks whether this ExternalResourceReference corresponds to the current version of the resource.

#### Remarks

This method should only be called if the ExternalResourceServer that provides the resource
is present.

#### Returns

An enum indicating whether this reference represents the most recent version
of the resource.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The server referenced by the ExternalResourceReference does not exist or
does not implement IExternalResourceServer.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceReference.IsValidReference(Autodesk.Revit.DB.ExternalResourceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReference.IsValidReference(Autodesk.Revit.DB.ExternalResourceType)`

#### Summary

Checks whether the reference is in a valid format.

#### Remarks

This function checks:
The server id corresponds to a valid server which
implements IExternalResourceServer.The server supports the given ExternalResourceType.The reference information is well-formed.
This function does not check whether the resource exists
on the server.

#### Parameter `resourceType`

The type of resource which the ExternalResourceReference should
correspond to.

#### Returns

True if this is a valid ExternalResourceReference. False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceReference.GetReferenceInformation`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReference.GetReferenceInformation`

#### Summary

Returns a copy of an object containing previously-stored reference or lookup
information about the specific resource provided by the server.

#### Returns

A copy of a (String, String) map containing previously-stored reference or
lookup information.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceReference.CreateLocalResource(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.PathType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReference.CreateLocalResource(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.PathType)`

#### Summary

Creates an ExternalResourceReference representing a local file managed
by Revit's built-in server.

#### Parameter `doc`

The document containing the reference. If the PathType is relative,
the path will be made relative to the location of this Document. (If
this Document belongs to a workshared model,
the reference will be relative to the central model.)

#### Parameter `resourceType`

The type of the external resource.

#### Parameter `path`

A path to the external file. This path must be absolute. If the PathType is
relative, then Revit will relativize the path according to the location
of the given Document.

#### Parameter `pathType`

An enum indicating the type of path which the ExternalResourceReference should use.
The PathType must be PathType.Server if the reference is to a Revit model on
Revit Server. The PathType must be PathType.Absolute if the reference is local
but the host model or host's central model are on Revit Server.

#### Returns

The newly-created ExternalResourceReference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The PathType.Enum value is not valid for this resource type or Document location.
PathType.Content is not valid for Revit links. The PathType must be PathType.Server
if the resource is on Revit Server and is only valid for Revit links. The PathType
must be PathType.Absolute if the host document or the host document's central model
are on Revit Server.
-or-
The given path path is a cloud path which is not supported in this method.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The model is not allowed to access.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalResourceReference.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceReference.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExternalResourceReference.InSessionPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceReference.InSessionPath`

#### Summary

The path stores the full display path which includes the server name plus the path provided by ExternalResourceServer.

The path that Revit will present for user recognizing and browsing to this resource during one session of Revit.

This property allows ExternalResourceServers to handle cases where the path to a resource may vary between Revit sessions.
For example, if this ExternalResourceReference refers to a resource in a folder,
this property can be used to store the current path of the resource. If the resource is moved to another folder later,
the ExternalResourceServer could calculate the correct path for the resource from resource identification information
when it is loaded and store it in this property,
so that it will work correctly even if the rvt file is opened in a different location.

Do not rely on this path to look up an ExternalResourceReference, as the path is neither unique nor stable. It isn't unique
because multiple servers might use the same server name and display name format. It isn't stable because some servers allow renaming,
and because a server might change its name at some point.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalResourceReference.Version`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceReference.Version`

#### Summary

The version of the external data that was most recently loaded in Revit.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalResourceReference.ServerId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceReference.ServerId`

#### Summary

The id of the server that Revit is expecting to provide the external resource.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceReference.#ctor(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReference.#ctor(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Creates a new ExternalResourceReference from the given ExternalResourceReference.

#### Parameter `other`

The ExternalResourceReference to copy.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceReference.#ctor(System.Guid,System.Collections.Generic.IDictionary{System.String,System.String},System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReference.#ctor(System.Guid,System.Collections.Generic.IDictionary{System.String,System.String},System.String,System.String)`

#### Summary

Creates a new ExternalResourceReference from the given data.

#### Parameter `serverId`

The id of the server associated with this
ExternalResourceReference. The server must implement
IExternalResourceServer.

#### Parameter `referenceInformation`

The (String, String) map containing reference or lookup information that will
be stored in Revit.

#### Parameter `version`

The version of the external data.

#### Parameter `inSessionPath`

The path that identifies a resource in server. ExternalResourceServer must provide this path which should not contain the server name.
Revit internally will construct and store the full display path which includes the server name plus this path at the time a resource
is loaded into the model for use if the server is missing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The file is not allowed to access.

#### Since

2015

### `T:Autodesk.Revit.DB.ExternalResourceReference`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceReference`

#### Summary

This class identifies an external resource provided by an IExternalResourceServer.

#### Remarks

The class contains:

The id of the IExternalResourceServer from which the resource was obtained.

A (String, String) map containing information that is meaningful to the server for accessing the desired data.
This could be something as simple as "4" to indicate that Revit wants option 4 from a range of several choices, or
something more detailed, such as a filename or directory path.

A String indicating the version of the resource that was most recently loaded in Revit.

A (String, String) map containing "in session" information that is meaningful to the server, but
which does not need to be saved permanently in the document on disk.

When calling an IExternalResourceServer, Revit will provide an ExternalResourceReference to
identify the specific resource that Revit is using from that server. The server can then use the
relevant information in the (String, String) maps to retrieve the data from the correct source.

#### Since

2015

### `T:Autodesk.Revit.DB.LinkOriginFileType`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinkOriginFileType`

#### Summary

Enum determining whether the source type of a temporary rvt link is an ifc.

#### Since

2022

#### Since

2022

### `F:Autodesk.Revit.DB.LinkOriginFileType.IFC`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkOriginFileType.IFC`

#### Summary

The original link file is an ifc file.

### `F:Autodesk.Revit.DB.LinkOriginFileType.RVT`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkOriginFileType.RVT`

#### Summary

Default RVT, curently only support ifc.

### `T:Autodesk.Revit.DB.SaveModifiedLinksOptionsForUnloadLocally`

Member kind: type
Symbol: `Autodesk.Revit.DB.SaveModifiedLinksOptionsForUnloadLocally`

#### Summary

Class giving options when saving linked files which are unloaded locally and have been modified
in-memory by shared coordinates operations.

#### Since

2017

#### Since

2017

### `F:Autodesk.Revit.DB.SaveModifiedLinksOptionsForUnloadLocally.DoNotSaveLinks`

Member kind: field
Symbol: `Autodesk.Revit.DB.SaveModifiedLinksOptionsForUnloadLocally.DoNotSaveLinks`

#### Summary

Any modified linked files will not be saved. The links will return to their previous
position the next time the file is loaded.

### `F:Autodesk.Revit.DB.SaveModifiedLinksOptionsForUnloadLocally.SaveLinks`

Member kind: field
Symbol: `Autodesk.Revit.DB.SaveModifiedLinksOptionsForUnloadLocally.SaveLinks`

#### Summary

Any modified linked files will be saved.

### `T:Autodesk.Revit.DB.SaveModifiedLinksOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.SaveModifiedLinksOptions`

#### Summary

Class giving options when saving linked files which have been modified
in-memory by shared coordinates operations.

#### Since

2014

#### Since

2014

### `F:Autodesk.Revit.DB.SaveModifiedLinksOptions.DisableSharedPositioning`

Member kind: field
Symbol: `Autodesk.Revit.DB.SaveModifiedLinksOptions.DisableSharedPositioning`

#### Summary

Any modified linked files will not be saved. Additionally, stop using shared
positioning with any modified files.

### `F:Autodesk.Revit.DB.SaveModifiedLinksOptions.DoNotSaveLinks`

Member kind: field
Symbol: `Autodesk.Revit.DB.SaveModifiedLinksOptions.DoNotSaveLinks`

#### Summary

Any modified linked files will not be saved. The links will return to their previous
position the next time the file is loaded.

### `F:Autodesk.Revit.DB.SaveModifiedLinksOptions.SaveLinks`

Member kind: field
Symbol: `Autodesk.Revit.DB.SaveModifiedLinksOptions.SaveLinks`

#### Summary

Any modified linked files will be saved.

### `T:Autodesk.Revit.DB.LinkLoadResultType`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinkLoadResultType`

#### Summary

Enum listing the possible results after loading a linked model.

#### Remarks

For all values except LinkLoadResultType.LinkLoaded, the linked model
is not loaded and no new link is created (if Revit was trying to create a link).

#### Since

2013

#### Since

2013

### `F:Autodesk.Revit.DB.LinkLoadResultType.UsedExisting`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkLoadResultType.UsedExisting`

#### Summary

Revit already has a link with the input location, so the same link is been reused.

### `F:Autodesk.Revit.DB.LinkLoadResultType.CouldNotChangeViewReference`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkLoadResultType.CouldNotChangeViewReference`

#### Summary

The link previously had an invalid view reference and either
no new view was provided or the input view was not usable
for linking CAD files.

### `F:Autodesk.Revit.DB.LinkLoadResultType.LinkExists`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkLoadResultType.LinkExists`

#### Summary

Revit already has a link with the input location, so no new link
can be created.

### `F:Autodesk.Revit.DB.LinkLoadResultType.ExternalServerMissing`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkLoadResultType.ExternalServerMissing`

#### Summary

The external add-in required to load this link model could not be found.

### `F:Autodesk.Revit.DB.LinkLoadResultType.LinkMayBeUpgraded`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkLoadResultType.LinkMayBeUpgraded`

#### Summary

Point cloud link loaded correctly but is obsolete and may be upgraded.

### `F:Autodesk.Revit.DB.LinkLoadResultType.LinkNotLoadedOtherError`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkLoadResultType.LinkNotLoadedOtherError`

#### Summary

An unknown error occurred.

### `F:Autodesk.Revit.DB.LinkLoadResultType.SameCentralModelAsHost`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkLoadResultType.SameCentralModelAsHost`

#### Summary

Either the linked model and its host document are both locals of the same
central model, or one is a local and the other is its central.

### `F:Autodesk.Revit.DB.LinkLoadResultType.SameModelAsHost`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkLoadResultType.SameModelAsHost`

#### Summary

The linked model has the same path as the currently active document.

### `F:Autodesk.Revit.DB.LinkLoadResultType.LinkOpenAsHost`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkLoadResultType.LinkOpenAsHost`

#### Summary

The linked model is already opened directly in Revit.

### `F:Autodesk.Revit.DB.LinkLoadResultType.LinkNotOpenable`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkLoadResultType.LinkNotOpenable`

#### Summary

An error occurred trying to read the linked model. It could happen if
a wrong link type is trying to be loaded.

### `F:Autodesk.Revit.DB.LinkLoadResultType.LinkNotFound`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkLoadResultType.LinkNotFound`

#### Summary

The linked model could not be found.

### `F:Autodesk.Revit.DB.LinkLoadResultType.LinkLoaded`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkLoadResultType.LinkLoaded`

#### Summary

The linked model loaded correctly.

### `F:Autodesk.Revit.DB.LinkLoadResultType.Uninitialized`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkLoadResultType.Uninitialized`

#### Summary

Revit has not tried to load the link, possibly because it is a nested
link and its parent failed to load.

### `T:Autodesk.Revit.DB.TransmittedModelOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.TransmittedModelOptions`

#### Summary

Enum giving desired behavior when opening or saving a transmitted
workshared model.

#### Since

2013

#### Since

2013

### `F:Autodesk.Revit.DB.TransmittedModelOptions.CancelOperation`

Member kind: field
Symbol: `Autodesk.Revit.DB.TransmittedModelOptions.CancelOperation`

#### Summary

Cancel the save or load operation.

### `F:Autodesk.Revit.DB.TransmittedModelOptions.KeepAsTransmitted`

Member kind: field
Symbol: `Autodesk.Revit.DB.TransmittedModelOptions.KeepAsTransmitted`

#### Summary

The model will remain marked as transmitted; users will not be able to
create locals until it is saved as a new central.

### `F:Autodesk.Revit.DB.TransmittedModelOptions.SaveAsNewCentral`

Member kind: field
Symbol: `Autodesk.Revit.DB.TransmittedModelOptions.SaveAsNewCentral`

#### Summary

The model should be saved as a new central. (On open, it will be
saved as a new central in its current location. On save, it will be
saved as central but the user can choose a location.)

### `T:Autodesk.Revit.DB.AttachmentType`

Member kind: type
Symbol: `Autodesk.Revit.DB.AttachmentType`

#### Summary

Enum determining whether a link is an attachment or an overlay

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.AttachmentType.Attachment`

Member kind: field
Symbol: `Autodesk.Revit.DB.AttachmentType.Attachment`

#### Summary

The link is an attachment. If the host file is linked into
another file, the link will also be brought along.

### `F:Autodesk.Revit.DB.AttachmentType.Overlay`

Member kind: field
Symbol: `Autodesk.Revit.DB.AttachmentType.Overlay`

#### Summary

The link is an overlay, only meant to be seen in this file.
If the host is linked into another file, the link will not
be brought along.

### `T:Autodesk.Revit.DB.PathType`

Member kind: type
Symbol: `Autodesk.Revit.DB.PathType`

#### Summary

Enum determining what kind of path a given external file
reference path is.
Paths are valid for all types of external file references
unless otherwise specified.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.PathType.Content`

Member kind: field
Symbol: `Autodesk.Revit.DB.PathType.Content`

#### Summary

The path is relative to a location in the Revit content libraries.
This value is only valid for ExternalFileReferenceType.KeynoteTable,
ExternalFileReferenceType.AssemblyCodeTable or ExternalFileReferenceType.Decal.

### `F:Autodesk.Revit.DB.PathType.Server`

Member kind: field
Symbol: `Autodesk.Revit.DB.PathType.Server`

#### Summary

The path is to a Revit Server location. This value is only
valid for ExternalFileReferenceType.RevitLink.

### `F:Autodesk.Revit.DB.PathType.Absolute`

Member kind: field
Symbol: `Autodesk.Revit.DB.PathType.Absolute`

#### Summary

The path is an absolute path to a location on disk or the
network.

### `F:Autodesk.Revit.DB.PathType.Relative`

Member kind: field
Symbol: `Autodesk.Revit.DB.PathType.Relative`

#### Summary

The path is relative to the host file's location, or
to the central model's location if the host is workshared.

### `T:Autodesk.Revit.DB.LinkedFileStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinkedFileStatus`

#### Summary

Enum displaying the loaded status of a linked file

#### Since

2012

### `F:Autodesk.Revit.DB.LinkedFileStatus.LocallyUnloaded`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkedFileStatus.LocallyUnloaded`

#### Summary

The linked file is unloaded for the specific user.
(If the linked file is both unloaded for the specific user
and unloaded for all users, the link will report LinkedFileStatus.Unloaded.)

### `F:Autodesk.Revit.DB.LinkedFileStatus.InClosedWorkset`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkedFileStatus.InClosedWorkset`

#### Summary

The linked file is in a closed workset and will not be displayed.

### `F:Autodesk.Revit.DB.LinkedFileStatus.CanBeUpgraded`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkedFileStatus.CanBeUpgraded`

#### Summary

The linked point cloud file is obsolete and can be indexed into new format.

### `F:Autodesk.Revit.DB.LinkedFileStatus.NotFound`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkedFileStatus.NotFound`

#### Summary

The linked file was not able to be found the
last time Revit tried to load it.

### `F:Autodesk.Revit.DB.LinkedFileStatus.Imported`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkedFileStatus.Imported`

#### Summary

The element represented by this value was imported
into Revit rather than linked into Revit.

### `F:Autodesk.Revit.DB.LinkedFileStatus.Unloaded`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkedFileStatus.Unloaded`

#### Summary

The link is unloaded.

### `F:Autodesk.Revit.DB.LinkedFileStatus.Loaded`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkedFileStatus.Loaded`

#### Summary

The link is loaded.

### `F:Autodesk.Revit.DB.LinkedFileStatus.Invalid`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinkedFileStatus.Invalid`

#### Summary

This value is the uninitialized value for the enum.
It indicates that the link has not been properly
initialized.

### `T:Autodesk.Revit.DB.ResourceVersionStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.ResourceVersionStatus`

#### Summary

An enum indicating whether a resource is current or out of date.

### `F:Autodesk.Revit.DB.ResourceVersionStatus.Unknown`

Member kind: field
Symbol: `Autodesk.Revit.DB.ResourceVersionStatus.Unknown`

#### Summary

It is not known whether the resource is current.

### `F:Autodesk.Revit.DB.ResourceVersionStatus.OutOfDate`

Member kind: field
Symbol: `Autodesk.Revit.DB.ResourceVersionStatus.OutOfDate`

#### Summary

This is not the most recent version of the resource.

### `F:Autodesk.Revit.DB.ResourceVersionStatus.Current`

Member kind: field
Symbol: `Autodesk.Revit.DB.ResourceVersionStatus.Current`

#### Summary

The resource is up-to-date; this is is the most recent version of the resource.

### `T:Autodesk.Revit.DB.LoadOperationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.LoadOperationType`

#### Summary

An enum indicating whether a resource load operation was triggered by
a user action or an automatic process.

#### Remarks

This enum is provided so that an external resource server can
decide how much feedback it wishes to provide to the user.

For example, Revit automatically loads all resources on file open.
This may cause many external resources to load at once. The server
may wish to provide truncated error messages.

Reload() and LoadFrom() operations from the API are considered to
be LoadOperationType.Explicit.

### `F:Autodesk.Revit.DB.LoadOperationType.Explicit`

Member kind: field
Symbol: `Autodesk.Revit.DB.LoadOperationType.Explicit`

#### Summary

The load operation was triggered by an explicit reload action on the part
of the user.

### `F:Autodesk.Revit.DB.LoadOperationType.Automatic`

Member kind: field
Symbol: `Autodesk.Revit.DB.LoadOperationType.Automatic`

#### Summary

The load operation was triggered automatically by another operation.

### `T:Autodesk.Revit.DB.ExternalResourceLoadStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadStatus`

#### Summary

A flag to indicate the status of an ExternalResource load request.

#### Remarks

This flag is returned by the LoadResource method of the IExternalResourceServer
class to inform callers whether the load operation succeeded, or encountered
an error.

### `F:Autodesk.Revit.DB.ExternalResourceLoadStatus.ServerThrewException`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadStatus.ServerThrewException`

#### Summary

The server identified by the ExternalResourceReference threw an exception while attempting to load a resource.

### `F:Autodesk.Revit.DB.ExternalResourceLoadStatus.CannotFindServer`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadStatus.CannotFindServer`

#### Summary

The server identified by the ExternalResourceReference could not be found, and may not be registered.

### `F:Autodesk.Revit.DB.ExternalResourceLoadStatus.ResourceAlreadyCurrent`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadStatus.ResourceAlreadyCurrent`

#### Summary

The current version of the resource is already loaded into Revit so no changes were made to the model.

### `F:Autodesk.Revit.DB.ExternalResourceLoadStatus.Uninitialized`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadStatus.Uninitialized`

#### Summary

The load operation is in an incomplete state.
Revit will treat this result as a failure.

### `F:Autodesk.Revit.DB.ExternalResourceLoadStatus.Failure`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadStatus.Failure`

#### Summary

The load operation failed.

### `F:Autodesk.Revit.DB.ExternalResourceLoadStatus.Success`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadStatus.Success`

#### Summary

The load operation was successful.

### `M:Autodesk.Revit.DB.EvaluatedParameter.AsDoubleInForgeStorageUnit`

Member kind: method
Symbol: `Autodesk.Revit.DB.EvaluatedParameter.AsDoubleInForgeStorageUnit`

#### Summary

Provides access to the double precision number within the parameter,
converted to the Forge storage unit of the parameter's data type.

#### Remarks

This method should only be used if the Definition's StorageType property returns that
the internal contents of the parameter is a double.

#### Returns

The double value contained in the parameter quantified in its Forge storage unit.

#### Since

2024

### `M:Autodesk.Revit.DB.EvaluatedParameter.AsValueString(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.EvaluatedParameter.AsValueString(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FormatOptions)`

#### Summary

Get the parameter value as a string with units.

#### Parameter `doc`

The document to be used to obtain information about the parameter.

#### Parameter `options`

Options for formatting the string.

#### Returns

The string that represents the parameter value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.EvaluatedParameter.AsValueString(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.EvaluatedParameter.AsValueString(Autodesk.Revit.DB.Document)`

#### Summary

Get the parameter value as a string with units.

#### Parameter `doc`

The document to be used to obtain information about the parameter.

#### Returns

The string that represents the parameter value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.EvaluatedParameter.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.EvaluatedParameter.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.EvaluatedParameter.StorageType`

Member kind: property
Symbol: `Autodesk.Revit.DB.EvaluatedParameter.StorageType`

#### Summary

The storage type describes the type that is used internally within the parameter to store its value.

#### Remarks

The property will return one of the following possibilities: String, Integer, Double or ElementId.
Based on the value of this property the correct access and set methods should be used to retrieve
and set the parameter's data value.

#### Since

2024

### `P:Autodesk.Revit.DB.EvaluatedParameter.HasValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.EvaluatedParameter.HasValue`

#### Summary

This property is true when the parameter value was successfully obtained, false otherwise.

#### Since

2024

### `P:Autodesk.Revit.DB.EvaluatedParameter.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.EvaluatedParameter.Value`

#### Summary

Evaluated value of the parameter.

#### Since

2024

### `P:Autodesk.Revit.DB.EvaluatedParameter.Definition`

Member kind: property
Symbol: `Autodesk.Revit.DB.EvaluatedParameter.Definition`

#### Summary

Definition of the parameter.

#### Since

2024

### `T:Autodesk.Revit.DB.EvaluatedParameter`

Member kind: type
Symbol: `Autodesk.Revit.DB.EvaluatedParameter`

#### Summary

Hold the evaluated `T:Autodesk.Revit.DB.ParameterValue` and `P:Autodesk.Revit.DB.EvaluatedParameter.Definition` of a parameter.

#### Since

2024

### `M:Autodesk.Revit.DB.ElementFilter.PassesFilter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementFilter.PassesFilter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Applies the filter to a given element.

#### Parameter `document`

The document.

#### Parameter `id`

The element id.

#### Returns

True if the element is accepted by the filter. False if the element is rejected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ElementFilter.PassesFilter(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementFilter.PassesFilter(Autodesk.Revit.DB.Element)`

#### Summary

Applies the filter to a given element.

#### Parameter `element`

The element.

#### Returns

True if the element is accepted by the filter. False if the element is rejected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.ElementFilter.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementFilter.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ElementFilter.Inverted`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementFilter.Inverted`

#### Summary

True if the results of the filter are inverted; elements that would normally be accepted by this filter will be rejected,
and elements that would normally be rejected will be accepted.

#### Since

2011

### `T:Autodesk.Revit.DB.ElementFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementFilter`

#### Summary

A base class for a type of filter that accepts or rejects elements based upon criteria.

#### Since

2011

### `M:Autodesk.Revit.DB.ChangeType.Contains(Autodesk.Revit.DB.ChangeType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ChangeType.Contains(Autodesk.Revit.DB.ChangeType)`

#### Summary

Checks whether this ChangeType contains the input ChangeType

#### Returns

True if input changeType is contained by this ChangeType

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ChangeType.IsIdentical(Autodesk.Revit.DB.ChangeType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ChangeType.IsIdentical(Autodesk.Revit.DB.ChangeType)`

#### Summary

Compares if two ChangeTypes are identical

#### Parameter `changeType`

Input ChangeType to be compared

#### Returns

True if the this ChangeType and input ChangeType are identical

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ChangeType.ConcatenateChangeTypes(Autodesk.Revit.DB.ChangeType,Autodesk.Revit.DB.ChangeType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ChangeType.ConcatenateChangeTypes(Autodesk.Revit.DB.ChangeType,Autodesk.Revit.DB.ChangeType)`

#### Summary

Creates a ChangeType that is a union of the two input ChangeTypes

#### Parameter `changeType1`

First input ChangeType to be concatenated

#### Parameter `changeType2`

Second input ChangeType to be concatenated

#### Returns

A new ChangeType that is a concatenation/union of the input change types

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.ChangeType.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ChangeType.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ChangeType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ChangeType`

#### Summary

A class representing a change that can be detected and tracked during Dynamic Update.

#### Remarks

ChangeTypes for specific changes can be obtained from the static methods available on
`T:Autodesk.Revit.DB.Element` .

#### Since

2011

### `T:Autodesk.Revit.DB.ChangePriority`

Member kind: type
Symbol: `Autodesk.Revit.DB.ChangePriority`

#### Summary

Enum used to specify the priority of an Updater during execution.

#### Remarks

The enumeration values are ordered in the order in which updaters associated to each
priority will be run. For example, updaters associated to priority GridsLevelsReferencePlanes
will run first, while updaters associated to priority Annotations will run last.

#### Since

2011

### `F:Autodesk.Revit.DB.ChangePriority.Annotations`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.Annotations`

#### Summary

Updater will modify annotations

### `F:Autodesk.Revit.DB.ChangePriority.DetailComponents`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.DetailComponents`

#### Summary

Updater will modify detail components and symbolic lines

### `F:Autodesk.Revit.DB.ChangePriority.Views`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.Views`

#### Summary

Updater will modify views

### `F:Autodesk.Revit.DB.ChangePriority.MEPSystems`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.MEPSystems`

#### Summary

Updater will modify MEP systems or circuits

### `F:Autodesk.Revit.DB.ChangePriority.MEPAccessoriesFittingsSegmentsWires`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.MEPAccessoriesFittingsSegmentsWires`

#### Summary

Updater will modify MEP elements such as segments, fittings and wires

### `F:Autodesk.Revit.DB.ChangePriority.Rebar`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.Rebar`

#### Summary

Updater will modify rebar

### `F:Autodesk.Revit.DB.ChangePriority.Connections`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.Connections`

#### Summary

Updater will modify connections

### `F:Autodesk.Revit.DB.ChangePriority.FreeStandingComponents`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.FreeStandingComponents`

#### Summary

Updater will modify standalone components

### `F:Autodesk.Revit.DB.ChangePriority.MEPCalculations`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.MEPCalculations`

#### Summary

Updater will update MEP calculated values

### `F:Autodesk.Revit.DB.ChangePriority.RoomsSpacesZones`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.RoomsSpacesZones`

#### Summary

Updater will modify Rooms, MEP spaces or zones

### `F:Autodesk.Revit.DB.ChangePriority.MEPFixtures`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.MEPFixtures`

#### Summary

Updater will modify MEP fixtures such as lights, sinks, equipment, etc.

### `F:Autodesk.Revit.DB.ChangePriority.DoorsOpeningsWindows`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.DoorsOpeningsWindows`

#### Summary

Updater will modify family instances that cut their hosts like doors and windows

### `F:Autodesk.Revit.DB.ChangePriority.InteriorWalls`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.InteriorWalls`

#### Summary

Updater will modify interior/partition walls

### `F:Autodesk.Revit.DB.ChangePriority.Structure`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.Structure`

#### Summary

Updater will modify structural elements like beams, braces, columns and trusses

### `F:Autodesk.Revit.DB.ChangePriority.FloorsRoofsStructuralWalls`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.FloorsRoofsStructuralWalls`

#### Summary

Updater will modify exterior shell of the building or floor slabs

### `F:Autodesk.Revit.DB.ChangePriority.Masses`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.Masses`

#### Summary

Updater will modify masses

### `F:Autodesk.Revit.DB.ChangePriority.GridsLevelsReferencePlanes`

Member kind: field
Symbol: `Autodesk.Revit.DB.ChangePriority.GridsLevelsReferencePlanes`

#### Summary

Updater will modify core datums and major reference planes

### `M:Autodesk.Revit.DB.Electrical.CircuitNamingSchemeSettings.IsValidCircuitNamingSchemeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CircuitNamingSchemeSettings.IsValidCircuitNamingSchemeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Verifies that the circuit naming scheme id can be used with CircuitNamingSchemeSettings.

#### Parameter `aDocument`

The document.

#### Parameter `circuitNamingSchemeId`

The circuit naming scheme id to be checked.

#### Returns

True if the circuit naming scheme id is valid for CircuitNamingSchemeSettings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Electrical.CircuitNamingSchemeSettings.GetCircuitNamingSchemeSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CircuitNamingSchemeSettings.GetCircuitNamingSchemeSettings(Autodesk.Revit.DB.Document)`

#### Summary

Gets the circuit naming scheme settings of the project.

#### Parameter `cda`

The document.

#### Returns

The circuit naming scheme settings of the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `P:Autodesk.Revit.DB.Electrical.CircuitNamingSchemeSettings.CircuitNamingSchemeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CircuitNamingSchemeSettings.CircuitNamingSchemeId`

#### Summary

The circuit naming scheme id set in CircuitNamingSchemeSettings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The circuit naming scheme id is invalid for the CircuitNamingSchemeSettings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2021

### `T:Autodesk.Revit.DB.Electrical.CircuitNamingSchemeSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CircuitNamingSchemeSettings`

#### Summary

This class represents a circuit naming scheme settings in Autodesk Revit.

#### Since

2021

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.IsValidSpecificFittingAngle(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.IsValidSpecificFittingAngle(System.Double)`

#### Summary

Checks that the given value is a valid specific fitting angle. The specific fitting angles are angles of 90, 60, 45, 30, 22.5 or 11.25 degrees.

#### Parameter `angle`

The angle value (in degree).

#### Returns

True if the given value is a valid specific fitting angle.

#### Since

2014

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.GetSpecificFittingAngleStatus(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.GetSpecificFittingAngleStatus(System.Double)`

#### Summary

Gets the status of given specific fitting angle.

#### Parameter `angle`

The specific fitting angle (in degree) that must be one of 90, 60, 45, 30, 22.5 or 11.25 degrees.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for angle must be 90, 60, 45, 30, 22.5 or 11.25 degrees.

#### Since

2014

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.SetSpecificFittingAngleStatus(System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.SetSpecificFittingAngleStatus(System.Double,System.Boolean)`

#### Summary

Sets the status of given specific angle.

#### Parameter `angle`

The specific angle (in degree) that must be 60, 45, 30, 22.5 or 11.25 degrees.

#### Parameter `bStatus`

Status, true - using the given angle during the pipe layout.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for angle must be 90, 60, 45, 30, 22.5 or 11.25 degrees.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Can not set an angle status for an invalid angle.

#### Since

2014
