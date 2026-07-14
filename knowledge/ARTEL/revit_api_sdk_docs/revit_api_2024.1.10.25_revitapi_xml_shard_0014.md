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
Shard: 14
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.TransformAPIUtils.CreateRotation(Autodesk.Revit.DB.XYZ,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.TransformAPIUtils.CreateRotation(Autodesk.Revit.DB.XYZ,System.Double)`

#### Summary

Creates a transform that represents a rotation about the given axis at (0, 0, 0).

#### Parameter `axis`

The rotation axis.

#### Parameter `angle`

The angle.

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

### `M:Autodesk.Revit.TransformAPIUtils.CreateTranslation(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.TransformAPIUtils.CreateTranslation(Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a transform that represents a translation via the specified vector.

#### Parameter `vector`

The translation vector.

#### Returns

The new transform.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.TransformAPIUtils.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.TransformAPIUtils.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.TransformAPIUtils`

Member kind: type
Symbol: `Autodesk.Revit.TransformAPIUtils`

#### Summary

Contains native implementations of transform related functions exposed to API.

#### Remarks

All of the static methods contained within logically belong within the API in Transform.
The internal API wrappers are called directly by the related public API methods.

#### Since

2014

### `P:Autodesk.Revit.DB.RuledFace.IsExtruded`

Member kind: property
Symbol: `Autodesk.Revit.DB.RuledFace.IsExtruded`

#### Summary

Determines if this is an extruded ruled surface.

#### Since

2017

### `P:Autodesk.Revit.DB.RuledFace.RulingsAreParallel`

Member kind: property
Symbol: `Autodesk.Revit.DB.RuledFace.RulingsAreParallel`

#### Summary

Determines if the rulings of this ruled surface are parallel.

#### Since

2014

### `P:Autodesk.Revit.DB.RuledFace.Point(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.RuledFace.Point(System.Int32)`

#### Summary

Profile points of the surface.

### `P:Autodesk.Revit.DB.RuledFace.Curve(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.RuledFace.Curve(System.Int32)`

#### Summary

Profile curves of the surface.

### `T:Autodesk.Revit.DB.RuledFace`

Member kind: type
Symbol: `Autodesk.Revit.DB.RuledFace`

#### Summary

A ruled face of a 3d solid or open shell.

#### Remarks

A ruled surface is created by sweeping a line between two profile curves or between a curve and a point (a point and a curve).
For details on the parameterization, refer to the documentation for `T:Autodesk.Revit.DB.RuledSurface` .

### `P:Autodesk.Revit.DB.RevolvedFace.Curve`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevolvedFace.Curve`

#### Summary

Profile curve of the surface.

### `P:Autodesk.Revit.DB.RevolvedFace.Radius(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevolvedFace.Radius(System.Int32)`

#### Summary

Radius of the surface.

### `P:Autodesk.Revit.DB.RevolvedFace.Axis`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevolvedFace.Axis`

#### Summary

Axis of the surface.

### `P:Autodesk.Revit.DB.RevolvedFace.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevolvedFace.Origin`

#### Summary

Origin of the surface.

### `T:Autodesk.Revit.DB.RevolvedFace`

Member kind: type
Symbol: `Autodesk.Revit.DB.RevolvedFace`

#### Summary

A revolved face of a 3d solid or open shell.

#### Remarks

Revolved faces are defined by a profile curve and a local coordinate system.
For details on the parameterization, refer to the documentation for `T:Autodesk.Revit.DB.RevolvedSurface`

### `M:Autodesk.Revit.DB.PolyLine.Create(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolyLine.Create(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Creates a polyline with coordinate points provided.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the count of coordinates is less than 2.

### `M:Autodesk.Revit.DB.PolyLine.Clone`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolyLine.Clone`

#### Summary

Returns a copy of this polyline.

### `M:Autodesk.Revit.DB.PolyLine.GetTransformed(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolyLine.GetTransformed(Autodesk.Revit.DB.Transform)`

#### Summary

Gets the copy of the polyline which is applied the specified transformation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the transform is `null` .

### `M:Autodesk.Revit.DB.PolyLine.GetOutline`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolyLine.GetOutline`

#### Summary

Gets the outline of the polyline.

### `M:Autodesk.Revit.DB.PolyLine.GetCoordinates`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolyLine.GetCoordinates`

#### Summary

Gets the coordinate points of the polyline.

### `M:Autodesk.Revit.DB.PolyLine.GetCoordinate(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolyLine.GetCoordinate(System.Int32)`

#### Summary

Gets the coordinate point of the specified index.

#### Parameter `index`

The index of the coordinates.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the index value is out of range.

### `M:Autodesk.Revit.DB.PolyLine.Evaluate(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolyLine.Evaluate(System.Double)`

#### Summary

Evaluates a parameter on the polyline.

#### Parameter `param`

The parameter to be evaluated. It is expected to be in [0,1] interval mapped to the bounds of the whole polyline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the param value is not between 0.0 and 1.0.

### `P:Autodesk.Revit.DB.PolyLine.NumberOfCoordinates`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolyLine.NumberOfCoordinates`

#### Summary

Gets the number of the coordinate points.

### `T:Autodesk.Revit.DB.PolyLine`

Member kind: type
Symbol: `Autodesk.Revit.DB.PolyLine`

#### Summary

A polyline.

#### Remarks

A polyline in space is defined by a set of coordinate points.

### `P:Autodesk.Revit.DB.PlanarFace.YVector`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanarFace.YVector`

#### Summary

The Y-vector of the planar face.

#### Remarks

Note that the cross product of X-vector and Y-vector may result in the reverse of the FaceNormal vector
depending upon how Revit has structured this particular face.

### `P:Autodesk.Revit.DB.PlanarFace.XVector`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanarFace.XVector`

#### Summary

The X-vector of the planar face.

#### Remarks

Note that the cross product of X-vector and Y-vector may result in the reverse of the FaceNormal vector
depending upon how Revit has structured this particular face.

### `P:Autodesk.Revit.DB.PlanarFace.FaceNormal`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanarFace.FaceNormal`

#### Summary

Normal of the planar face.

#### Remarks

This property is the "face normal" vector, and thus should return a vector consistently pointing out of
the solid that this face is a boundary for (if it is a part of a solid).

### `P:Autodesk.Revit.DB.PlanarFace.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanarFace.Origin`

#### Summary

Origin of the surface.

### `T:Autodesk.Revit.DB.PlanarFace`

Member kind: type
Symbol: `Autodesk.Revit.DB.PlanarFace`

#### Summary

A bounded face of a 3d solid or open shell.

#### Remarks

Planar faces are defined by planes bounded by edge loops.
The planes provide natural UV parameterization to the faces.
S(u, v) = Origin + u*Vector[0] + v*Vector[1]

### `M:Autodesk.Revit.DB.GeometryInstance.GetInstanceGeometry(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryInstance.GetInstanceGeometry(Autodesk.Revit.DB.Transform)`

#### Summary

Computes a transformation of the geometric representation of the instance.

#### Returns

An element which contains the computed geometry for the transformed instance.

#### Parameter `transform`

The transformation to apply to the geometry.

#### Remarks

The context of the instance object (such as effective material) will be applied to the symbol.

Note that this method involves extensive parsing or Revit's data structures, so try to
minimize calls if performance is critical.

Geometry will be parsed with the same options as those used when this object was retrieved.

This method returns a copy of the Revit geometry. It is suitable for use in a tool which extracts
geometry to another format or carries out a geometric analysis; however, because it returns a copy
the references found in the geometry objects contained in this element are not suitable for
creating new Revit elements referencing the original element (for example, dimensioning).
Only the geometry returned by GetSymbolGeometry() with no transform can be used for that purpose.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Transform is not conformal

### `M:Autodesk.Revit.DB.GeometryInstance.GetInstanceGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryInstance.GetInstanceGeometry`

#### Summary

Computes the geometric representation of the instance.

#### Returns

An element which contains the computed geometry for the instance.

#### Remarks

The geometry will be in the coordinate system of the model that owns this instance.

The context of the instance object (such as effective material) will be applied to the symbol.

Note that this method involves extensive parsing or Revit's data structures, so try to
minimize calls if performance is critical.

Geometry will be parsed with the same options as those used when this object was retrieved.

This method returns a copy of the Revit geometry. It is suitable for use in a tool which extracts
geometry to another format or carries out a geometric analysis; however, because it returns a copy
the references found in the geometry objects contained in this element are not suitable for
creating new Revit elements referencing the original element (for example, dimensioning).
Only the geometry returned by GetSymbolGeometry() with no transform can be used for that purpose.

### `M:Autodesk.Revit.DB.GeometryInstance.GetSymbolGeometry(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryInstance.GetSymbolGeometry(Autodesk.Revit.DB.Transform)`

#### Summary

Computes a transformation of the geometric representation of the symbol
which generates this instance.

#### Parameter `transform`

The transformation to apply to the geometry.

#### Returns

An element which contains the computed geometry for the transformed symbol.

#### Remarks

The context of this instance object (such as effective material)
will be applied to the symbol.

Note that this method involves extensive parsing or Revit's data structures, so try to
minimize calls if performance is critical.

Geometry will be parsed with the same options as those used when this object was retrieved.

This method returns a copy of the Revit geometry. It is suitable for use in a tool which extracts
geometry to another format or carries out a geometric analysis; however, because it returns a copy
the references found in the geometry objects contained in this element are not suitable for
creating new Revit elements referencing the original element (for example, dimensioning).
Only the geometry returned by GetSymbolGeometry() with no transform can be used for that purpose.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Transform is not conformal

### `M:Autodesk.Revit.DB.GeometryInstance.GetSymbolGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryInstance.GetSymbolGeometry`

#### Summary

Computes the geometric representation of the symbol which generates this instance.

#### Returns

An element which contains the computed geometry for the symbol.

#### Remarks

The geometry will be in the local coordinate space of the symbol.

The context of this instance object (such as effective material) will be applied to the symbol.

Note that this method involves extensive parsing or Revit's data structures, so try to
minimize calls if performance is critical.

Geometry will be parsed with the same options as those used when this object was retrieved.

The results of the method and the value of the SymbolGeometry property are identical.

This method returns the actual Revit geometry. Unlike other methods which extract transformed
copies of the geometry, the return value of this method is suitable for
creating new Revit elements referencing the original element (for example, dimensioning).

### `P:Autodesk.Revit.DB.GeometryInstance.SymbolGeometry`

Member kind: property
Symbol: `Autodesk.Revit.DB.GeometryInstance.SymbolGeometry`

#### Summary

The geometric representation of the symbol which generates this instance.

#### Remarks

The geometry will be in the local coordinate space of the symbol.

The context of this instance object (such as effective material) will be applied to the symbol.

Note that retrieving the value of this property involves extensive parsing or Revit's data
structures, so try to minimize calls if performance is critical.

Geometry will be parsed with the same options as those used when this object was retrieved.

The value of this property and the results of the method GetSymbolGeometry(void) are identical.

### `M:Autodesk.Revit.DB.GeometryInstance.GetDocument`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryInstance.GetDocument`

#### Summary

Gets the document that contains the symbol of this instance.

#### Returns

Returns the document that contains the symbol of this instance.

#### Since

2023

### `M:Autodesk.Revit.DB.GeometryInstance.GetSymbolGeometryId`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryInstance.GetSymbolGeometryId`

#### Summary

Gets the SymbolGeometryId that contains data about the symbol of this instance.

#### Returns

Returns the SymbolGeometryId that contains data about the symbol of this instance.

#### Remarks

Use the strings returned by SymbolGeometryId.AsIdentifier(bool) to check if two GeometryInstance point to the same geometry of the symbol.

#### Since

2023

### `P:Autodesk.Revit.DB.GeometryInstance.Transform`

Member kind: property
Symbol: `Autodesk.Revit.DB.GeometryInstance.Transform`

#### Summary

The affine transformation from the local coordinate space of the symbol into the
coordinate space of the instance.

### `T:Autodesk.Revit.DB.GeometryInstance`

Member kind: type
Symbol: `Autodesk.Revit.DB.GeometryInstance`

#### Summary

An instance of another element (symbol), specially positioned by this
element.

#### Remarks

A GeometryInstance represents a set of geometry stored by Revit in a default configuration, and then transformed
into the proper location as a result of the properties of the element. The most common situation where
GeometryInstances are encountered is in Family instances. Revit uses GeometryInstances to allow it to store a
single copy of the geometry for a given family and reuse it in multiple instances.

Note that not all Family instances will include GeometryInstances. When Revit needs to make a unique copy of the
family geometry for a given instance (because of the effect of local joins, intersections, and other factors
related to the instance placement) no GeometryInstance will be encountered; instead the Solid geometry will be found
at the top level of the hierarchy.

Another example of GeometryInstance usage is in Rebar element visible in fine 3D Views. Here, each segement of a rebar is a GeometryInstance.
In this case the Symbol Element is contaning all the geometries that are instanced.

A GeometryInstance offers the ability to read its geometry through the GetSymbolGeometry() and
GetInstanceGeometry() methods. These methods return another Autodesk.Revit.DB.GeometryElement
which can be parsed just like the first level return.

### `M:Autodesk.Revit.DB.HermiteSpline.Create(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean,Autodesk.Revit.DB.HermiteSplineTangents)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HermiteSpline.Create(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean,Autodesk.Revit.DB.HermiteSplineTangents)`

#### Summary

Creates a Hermite spline with specified tangency at its endpoints.

#### Parameter `controlPoints`

The control points of the Hermite spline.

#### Parameter `periodic`

True if the Hermite spline is to be periodic, false otherwise.

#### Parameter `tangents`

The object which indicates tangency at the start, the end, or both ends of the curve.

#### Returns

The new HermiteSpline object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The control points array is invalid, because it doesn't contain the minimum number of points (2).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Unable to construct valid HermiteSpline from given inputs.

#### Since

2014

### `M:Autodesk.Revit.DB.HermiteSpline.Create(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HermiteSpline.Create(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean)`

#### Summary

Creates a Hermite spline with default tangency at its endpoints.

#### Remarks

The tangents at the ends of the spline are computed from the control points.

#### Parameter `controlPoints`

The control points of the Hermite spline.

#### Parameter `periodic`

True if the Hermite spline is to be periodic, false otherwise.

#### Returns

The new HermiteSpline object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The control points array is invalid, because it doesn't contain the minimum number of points (2).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Unable to construct valid HermiteSpline from given inputs.

#### Since

2014

### `P:Autodesk.Revit.DB.HermiteSpline.Parameters`

Member kind: property
Symbol: `Autodesk.Revit.DB.HermiteSpline.Parameters`

#### Summary

Returns the params of the Hermite spline.

### `P:Autodesk.Revit.DB.HermiteSpline.Tangents`

Member kind: property
Symbol: `Autodesk.Revit.DB.HermiteSpline.Tangents`

#### Summary

Returns the tangents of the Hermite spline.

### `P:Autodesk.Revit.DB.HermiteSpline.ControlPoints`

Member kind: property
Symbol: `Autodesk.Revit.DB.HermiteSpline.ControlPoints`

#### Summary

The control points of the Hermite spline.

### `P:Autodesk.Revit.DB.HermiteSpline.IsPeriodic`

Member kind: property
Symbol: `Autodesk.Revit.DB.HermiteSpline.IsPeriodic`

#### Summary

Returns whether the Hermite spline is periodic or not.

### `T:Autodesk.Revit.DB.HermiteSpline`

Member kind: type
Symbol: `Autodesk.Revit.DB.HermiteSpline`

#### Summary

A Hermite spline.

#### Remarks

The Hermite spline lies in the plane defined by control points.

### `P:Autodesk.Revit.DB.HermiteFace.MixedDerivs`

Member kind: property
Symbol: `Autodesk.Revit.DB.HermiteFace.MixedDerivs`

#### Summary

Mixed derivatives of the surface.

### `P:Autodesk.Revit.DB.HermiteFace.Tangents(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.HermiteFace.Tangents(System.Int32)`

#### Summary

Tangents of the surface.

### `P:Autodesk.Revit.DB.HermiteFace.Points`

Member kind: property
Symbol: `Autodesk.Revit.DB.HermiteFace.Points`

#### Summary

Interpolation points of the surface.

### `P:Autodesk.Revit.DB.HermiteFace.Params(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.HermiteFace.Params(System.Int32)`

#### Summary

Parameters of the surface.

### `T:Autodesk.Revit.DB.HermiteFace`

Member kind: type
Symbol: `Autodesk.Revit.DB.HermiteFace`

#### Summary

A cubic hermite spline face of a 3d solid or open shell.

#### Remarks

Hermite faces are defined by cubic hermite spline surfaces bounded by edge loops.
The surfaces provide natural UV parameterization to the faces.

### `M:computeCurvatureOfSurfInt(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,EdgePntVec!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,TessEpsCntrl!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Double*,System.Double*,System.Double*)`

Member kind: method
Symbol: `computeCurvatureOfSurfInt(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,EdgePntVec!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,TessEpsCntrl!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Double*,System.Double*,System.Double*)`

### `M:uniformizeSurfIntPnts(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,Arr<EdgePnt>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,Arr<EdgePnt>*,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `uniformizeSurfIntPnts(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,Arr<EdgePnt>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,Arr<EdgePnt>*,System.Boolean,System.Boolean)`

### `M:computePrincipalCurvatures(Surface!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Double*,UVUtils.UV*,System.Double(*)[N3])`

Member kind: method
Symbol: `computePrincipalCurvatures(Surface!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Double*,UVUtils.UV*,System.Double(*)[N3])`

### `M:computeFundamentalForms(Surface!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Double!System.Runtime.CompilerServices.IsConst*,System.Double(*)[N2],System.Double(*)[N2])`

Member kind: method
Symbol: `computeFundamentalForms(Surface!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Double!System.Runtime.CompilerServices.IsConst*,System.Double(*)[N2],System.Double(*)[N2])`

### `M:sameSingularPoint(Surface!System.Runtime.CompilerServices.IsConst*,System.Double!System.Runtime.CompilerServices.IsConst*,System.Double!System.Runtime.CompilerServices.IsConst*,System.Double!System.Runtime.CompilerServices.IsConst)`

Member kind: method
Symbol: `sameSingularPoint(Surface!System.Runtime.CompilerServices.IsConst*,System.Double!System.Runtime.CompilerServices.IsConst*,System.Double!System.Runtime.CompilerServices.IsConst*,System.Double!System.Runtime.CompilerServices.IsConst)`

### `M:createSurfaceFromCurves(GCurve!System.Runtime.CompilerServices.IsConst*,GCurve!System.Runtime.CompilerServices.IsConst*,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `createSurfaceFromCurves(GCurve!System.Runtime.CompilerServices.IsConst*,GCurve!System.Runtime.CompilerServices.IsConst*,System.Boolean,System.Boolean)`

### `M:projectSurfEnvToCurve(Surface!System.Runtime.CompilerServices.IsConst*,Plane!System.Runtime.CompilerServices.IsConst*,Owner<GCurve>*,Envelope*)`

Member kind: method
Symbol: `projectSurfEnvToCurve(Surface!System.Runtime.CompilerServices.IsConst*,Plane!System.Runtime.CompilerServices.IsConst*,Owner<GCurve>*,Envelope*)`

### `M:findSurfIntDirs(Surface!System.Runtime.CompilerServices.IsConst*,UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,Surface!System.Runtime.CompilerServices.IsConst*,UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,Arr<EdgePntVec>*,Arr<XYZUtils.XYZ>*,TangentSurfIntInfo*)`

Member kind: method
Symbol: `findSurfIntDirs(Surface!System.Runtime.CompilerServices.IsConst*,UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,Surface!System.Runtime.CompilerServices.IsConst*,UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,Arr<EdgePntVec>*,Arr<XYZUtils.XYZ>*,TangentSurfIntInfo*)`

### `F:TangentSurfIntInfo.m_secondDeriv`

Member kind: field
Symbol: `TangentSurfIntInfo.m_secondDeriv`

### `M:TangentSurfIntInfo.estimateDeviations(System.Double,System.Double*,System.Double*)`

Member kind: method
Symbol: `TangentSurfIntInfo.estimateDeviations(System.Double,System.Double*,System.Double*)`

### `M:TangentSurfIntInfo.degenerateIntersection`

Member kind: method
Symbol: `TangentSurfIntInfo.degenerateIntersection`

### `M:TangentSurfIntInfo.tangentIntersection`

Member kind: method
Symbol: `TangentSurfIntInfo.tangentIntersection`

### `M:TangentSurfIntInfo.set(System.Boolean,System.Double*)`

Member kind: method
Symbol: `TangentSurfIntInfo.set(System.Boolean,System.Double*)`

### `T:TangentSurfIntInfo`

Member kind: type
Symbol: `TangentSurfIntInfo`

### `M:intersectSurfacesBetweenPoints(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,EdgePnt!System.Runtime.CompilerServices.IsConst*,System.Double!System.Runtime.CompilerServices.IsConst(*)[N2],EdgePnt!System.Runtime.CompilerServices.IsConst*,TessEpsCntrl!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,Arr<EdgePnt>*,System.Boolean*,Owner<GCurve>*)`

Member kind: method
Symbol: `intersectSurfacesBetweenPoints(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,EdgePnt!System.Runtime.CompilerServices.IsConst*,System.Double!System.Runtime.CompilerServices.IsConst(*)[N2],EdgePnt!System.Runtime.CompilerServices.IsConst*,TessEpsCntrl!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,Arr<EdgePnt>*,System.Boolean*,Owner<GCurve>*)`

### `M:surfacesAreEquivalent(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,Trf!System.Runtime.CompilerServices.IsConst*,TessEpsCntrl!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `surfacesAreEquivalent(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,Trf!System.Runtime.CompilerServices.IsConst*,TessEpsCntrl!System.Runtime.CompilerServices.IsConst*)`

### `M:surfacesAreCoincident(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,Trf!System.Runtime.CompilerServices.IsConst*,System.Boolean*,TrfUV*,System.Boolean*,TessEpsCntrl!System.Runtime.CompilerServices.IsConst*,System.Boolean*,PlaneDataCache*,PlaneDataCache*)`

Member kind: method
Symbol: `surfacesAreCoincident(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,Trf!System.Runtime.CompilerServices.IsConst*,System.Boolean*,TrfUV*,System.Boolean*,TessEpsCntrl!System.Runtime.CompilerServices.IsConst*,System.Boolean*,PlaneDataCache*,PlaneDataCache*)`

### `M:intersectPlaneWithLine(Plane!System.Runtime.CompilerServices.IsConst*,GLine!System.Runtime.CompilerServices.IsConst*,System.Boolean,System.Boolean,System.Double*,System.Double*,System.Double*)`

Member kind: method
Symbol: `intersectPlaneWithLine(Plane!System.Runtime.CompilerServices.IsConst*,GLine!System.Runtime.CompilerServices.IsConst*,System.Boolean,System.Boolean,System.Double*,System.Double*,System.Double*)`

### `M:intersectSurfWithCurveNearEnd(Surface!System.Runtime.CompilerServices.IsConst*,GCurve!System.Runtime.CompilerServices.IsConst*,System.Int32,System.Double*,System.Double*,System.Boolean)`

Member kind: method
Symbol: `intersectSurfWithCurveNearEnd(Surface!System.Runtime.CompilerServices.IsConst*,GCurve!System.Runtime.CompilerServices.IsConst*,System.Int32,System.Double*,System.Double*,System.Boolean)`

### `M:intersectSurfWithCurve(Surface!System.Runtime.CompilerServices.IsConst*,GCurve!System.Runtime.CompilerServices.IsConst*,System.Boolean,System.Boolean,Arr<UVUtils.UV>*,Arr<System.Double>*,Arr<XYZUtils.XYZ>*,Err*,crs.Map<GCurve!System.Runtime.CompilerServices.IsConst**,Arr<XYZUtils.XYZ>,std.less<GCurve!System.Runtime.CompilerServices.IsConst**>,tnallc<std.pair<GCurve!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsConst,Arr<XYZUtils.XYZ>>>>*,Owner<GCurve>*)`

Member kind: method
Symbol: `intersectSurfWithCurve(Surface!System.Runtime.CompilerServices.IsConst*,GCurve!System.Runtime.CompilerServices.IsConst*,System.Boolean,System.Boolean,Arr<UVUtils.UV>*,Arr<System.Double>*,Arr<XYZUtils.XYZ>*,Err*,crs.Map<GCurve!System.Runtime.CompilerServices.IsConst**,Arr<XYZUtils.XYZ>,std.less<GCurve!System.Runtime.CompilerServices.IsConst**>,tnallc<std.pair<GCurve!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsConst,Arr<XYZUtils.XYZ>>>>*,Owner<GCurve>*)`

### `M:intersectSurfacesThroughPoint(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,TessEpsCntrl!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Boolean,Owner<GCurve>*,System.Double*,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `intersectSurfacesThroughPoint(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,TessEpsCntrl!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Boolean,Owner<GCurve>*,System.Double*,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*)`

### `M:intersectSurfaces(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,OwnerArr<GCurve>*,System.Boolean)`

Member kind: method
Symbol: `intersectSurfaces(Surface!System.Runtime.CompilerServices.IsConst*,Surface!System.Runtime.CompilerServices.IsConst*,OwnerArr<GCurve>*,System.Boolean)`

### `M:Autodesk.Revit.DB.Mesh.ComputeCentroid`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mesh.ComputeCentroid`

#### Summary

Computes and returns the centroid of the mesh, if it is topologically closed and its volume is not zero.
The centroid corresponds to the center of mass of the mesh, if its interior were
filled by a material of uniform density.

#### Returns

XYZ value representing the position of the center of mass.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The mesh is not topologically closed, or has zero volume.
Check Mesh.IsClosed to determine if the mesh is closed.

#### Since

2024

### `M:Autodesk.Revit.DB.Mesh.ComputeVolume`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mesh.ComputeVolume`

#### Summary

Computes and returns the volume enclosed by the mesh, if it is topologically closed.

#### Returns

A double, representing the volume.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The mesh is not topologically closed. Check Mesh.IsClosed to determine if the mesh is closed.

#### Since

2024

### `M:Autodesk.Revit.DB.Mesh.ComputeSurfaceArea`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mesh.ComputeSurfaceArea`

#### Summary

Computes and returns the surface area of the mesh. The surface area is the sum of the areas of the
constituent facets of the mesh.

#### Returns

A double, representing the surface area.

#### Since

2024

### `M:Autodesk.Revit.DB.Mesh.GetNormals`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mesh.GetNormals`

#### Summary

Returns all normals assigned to the mesh.

#### Returns

An array of XYZ values, each representing a normal unit vector.

#### Since

2021

### `M:Autodesk.Revit.DB.Mesh.GetNormal(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mesh.GetNormal(System.Int32)`

#### Summary

Returns a normal unit vector at the given index.

#### Parameter `idx`

A zero-based index. It must be consistent with the DistributionOfNormals.

#### Returns

XYZ value representing a normal unit vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value is not a valid index of a normal of the mesh.
A valid value is not negative and is smaller than the number of normals in the mesh.

#### Since

2021

### `P:Autodesk.Revit.DB.Mesh.IsClosed`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mesh.IsClosed`

#### Summary

Indicates whether the mesh is closed.

#### Remarks

Every time this property is accessed, it is computed from scratch,
so accessing it multiple times will come at a performance cost.
A mesh is closed when each of its edges has two (or more) faces.
If an edge has more than two faces (meaning that it's a non-manifold edge),
the mesh still may be closed.

#### Since

2022

### `P:Autodesk.Revit.DB.Mesh.DistributionOfNormals`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mesh.DistributionOfNormals`

#### Summary

Indicates the distribution of normal vectors along the tessellated mesh surface.

#### Since

2021

### `P:Autodesk.Revit.DB.Mesh.NumberOfNormals`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mesh.NumberOfNormals`

#### Summary

The number of normals associated with the mesh.

#### Remarks

The number is always equal either to '1', or the number of facets,
or the number of points. The DistributionOfNormals property indicates
how normals are distributed along the polymesh. If there is only one normal available,
it applies to the entire mesh. Curved surfaces have normal vectors associated
with either every facet or every point/vertex of the tessellated polymesh.

#### Since

2021

### `P:Autodesk.Revit.DB.Mesh.Transformed(Autodesk.Revit.DB.Transform)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mesh.Transformed(Autodesk.Revit.DB.Transform)`

#### Summary

Transforms this mesh and returns the result.

#### Parameter `transform`

The transformation used to transform the profile.

#### Returns

The transformed mesh.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the handle of the specified transformation is `null` .

### `P:Autodesk.Revit.DB.Mesh.MaterialElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mesh.MaterialElementId`

#### Summary

Element ID of the material from which this mesh is composed.

### `P:Autodesk.Revit.DB.Mesh.Vertices`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mesh.Vertices`

#### Summary

Retrieves all vertices used to define this mesh. Intended for indexed access.

### `P:Autodesk.Revit.DB.Mesh.Triangle(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mesh.Triangle(System.Int32)`

#### Summary

Retrieves a specific triangle.

#### Parameter `idx`

Index of the triangle, must be in [0, NumTriangles).

### `P:Autodesk.Revit.DB.Mesh.NumTriangles`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mesh.NumTriangles`

#### Summary

The number of triangles that the mesh contains.

### `T:Autodesk.Revit.DB.Mesh`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mesh`

#### Summary

A triangular mesh.

#### Remarks

Meshes are generated during triangulation of faces. They can also be encountered directly in Revit geometry (typically imported geometry).
Meshes contain a single array of `P:Autodesk.Revit.DB.Mesh.Vertices` , and a corresponding array of triangles. Triangles can be accessed by index from
`P:Autodesk.Revit.DB.Mesh.Triangle(System.Int32)` , and reference 3 vertices from the `P:Autodesk.Revit.DB.Mesh.Vertices` array.

### `P:Autodesk.Revit.DB.MeshTriangle.Vertex(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.MeshTriangle.Vertex(System.Int32)`

#### Summary

A vertex of the triangle.

#### Parameter `idx`

Index of the vertex in the triangle: 0, 1 or 2.

#### Throws

The triangle only contains values at index 0, 1 or 2.

### `P:Autodesk.Revit.DB.MeshTriangle.Index(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.MeshTriangle.Index(System.Int32)`

#### Summary

The index of the vertex in the Vertices array of the mesh, for indexed access.

#### Parameter `idx`

Index of the vertex in the triangle: 0, 1 or 2.

#### Throws

The triangle only contains values at index 0, 1 or 2.

### `T:Autodesk.Revit.DB.MeshTriangle`

Member kind: type
Symbol: `Autodesk.Revit.DB.MeshTriangle`

#### Summary

One triangle of a mesh.

### `M:Autodesk.Revit.DB.CylindricalHelix.getGCylindricalHelix`

Member kind: method
Symbol: `Autodesk.Revit.DB.CylindricalHelix.getGCylindricalHelix`

### `P:Autodesk.Revit.DB.CylindricalHelix.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalHelix.Height`

#### Summary

Height of the cylindrical helix.

#### Remarks

It is the length of the span of the helix along the axis direction.
The height is defined only if the helix is bounded.
That is, its start and end angles (parameters) are specified.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

Height is not defined for unbounded helix.

### `P:Autodesk.Revit.DB.CylindricalHelix.IsRightHanded`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalHelix.IsRightHanded`

#### Summary

True if the helix is right handed, false if the helix is left handed.

### `P:Autodesk.Revit.DB.CylindricalHelix.Pitch`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalHelix.Pitch`

#### Summary

The pitch of the cylindrical helix.

#### Remarks

It is the distance moved along the axis direction when a point makes one rotation about the axis.
Pitch can be positive or negative.

### `P:Autodesk.Revit.DB.CylindricalHelix.ZVector`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalHelix.ZVector`

#### Summary

The Z direction vector, which is same as the axis direction vector.

### `P:Autodesk.Revit.DB.CylindricalHelix.YVector`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalHelix.YVector`

#### Summary

The Y direction vector.

### `P:Autodesk.Revit.DB.CylindricalHelix.XVector`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalHelix.XVector`

#### Summary

The X direction vector.

### `P:Autodesk.Revit.DB.CylindricalHelix.Radius`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalHelix.Radius`

#### Summary

The radius of the cylindrical helix.

### `P:Autodesk.Revit.DB.CylindricalHelix.BasePoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalHelix.BasePoint`

#### Summary

The base point of the axis of the cylindrical helix.

### `M:Autodesk.Revit.DB.CylindricalHelix.Create(Autodesk.Revit.DB.XYZ,System.Double,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CylindricalHelix.Create(Autodesk.Revit.DB.XYZ,System.Double,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double)`

#### Summary

Create a cylindrical helix.

#### Parameter `basePoint`

Base point of the axis. It can be any point in 3d.

#### Parameter `radius`

Radius. It should be a positive number.

#### Parameter `xVector`

X vector. Should be Non-zero vector.

#### Parameter `zVector`

Z vector = axis direction. Should be non-zero and orthogonal to X Vector.

#### Parameter `pitch`

Pitch. It should be non-zero number, can be positive or negative.
Positive means right handed and negative means left handed.

#### Parameter `startAngle`

Start angle. It specifies the start point of the Helix.

#### Parameter `endAngle`

End angle. It specifies the end point of the Helix.
End angle should not be equal to start angle.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The radius is negative -or-
the pitch is zero -or-
the xVector or zVector is zero length -or-
zVector is not orthogonal to xVector -or-
endAngle is equal to startAngle.

### `T:Autodesk.Revit.DB.CylindricalHelix`

Member kind: type
Symbol: `Autodesk.Revit.DB.CylindricalHelix`

#### Summary

A cylindrical helix.

#### Remarks

The helix winds around a cylinder making constant angle with the axis of the cylinder.
In this release, CylindricalHelix curves are used only in specific applications in
stairs and railings, and should not be used or encountered when accessing curves of
other Revit elements and geometry.

#### Since

2013

### `P:Autodesk.Revit.DB.CylindricalFace.Radius(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalFace.Radius(System.Int32)`

#### Summary

Radii of the surface.

### `P:Autodesk.Revit.DB.CylindricalFace.Axis`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalFace.Axis`

#### Summary

Axis of the surface.

### `P:Autodesk.Revit.DB.CylindricalFace.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.CylindricalFace.Origin`

#### Summary

Origin of the surface.

### `T:Autodesk.Revit.DB.CylindricalFace`

Member kind: type
Symbol: `Autodesk.Revit.DB.CylindricalFace`

#### Summary

A cylindrical face of a 3d solid or open shell.

#### Remarks

For details on the parameterization, refer to the documentation for `T:Autodesk.Revit.DB.CylindricalSurface` .

### `P:Autodesk.Revit.DB.IntersectionResult.EdgeParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntersectionResult.EdgeParameter`

#### Summary

Parameter of a point on the edge closest to the point of intersection.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown in the getter when this property has not been set by the method providing the result.

### `P:Autodesk.Revit.DB.IntersectionResult.EdgeObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntersectionResult.EdgeObject`

#### Summary

Edge of the face close to the point of intersection.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown in the getter when this property has not been set by the method providing the result.

### `P:Autodesk.Revit.DB.IntersectionResult.Distance`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntersectionResult.Distance`

#### Summary

Distance from the original object to located point.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown in the getter when this property has not been set by the method providing the result.

### `P:Autodesk.Revit.DB.IntersectionResult.Parameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntersectionResult.Parameter`

#### Summary

1d parameter of the point of intersection.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown in the getter when this property has not been set by the method providing the result.

### `P:Autodesk.Revit.DB.IntersectionResult.UVPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntersectionResult.UVPoint`

#### Summary

2d (or two 1d) parameters of the point of intersection.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown in the getter when this property has not been set by the method providing the result.

### `P:Autodesk.Revit.DB.IntersectionResult.XYZPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntersectionResult.XYZPoint`

#### Summary

Point of intersection in local 3d coordinates.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown in the getter when this property has not been set by the method providing the result.

### `T:Autodesk.Revit.DB.IntersectionResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.IntersectionResult`

#### Summary

This class captures results of intersecting geometric entities. "Intersecting" is meant
in generalized sense, so the same class will be used for projection, containment, etc.
Refer to the documentation of the method providing the result for the precise meaning of properties.

### `P:Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.Distance`

Member kind: property
Symbol: `Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.Distance`

#### Summary

Distance from point on first curve to the point on second curve.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The property has not been set by the method providing the result.

#### Since

2018.1

### `P:Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.ParameterOnSecondCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.ParameterOnSecondCurve`

#### Summary

1d raw (not normalized) parameter of the point on the second curve.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The property has not been set by the method providing the result.

#### Since

2018.1

### `P:Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.ParameterOnFirstCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.ParameterOnFirstCurve`

#### Summary

1d raw (not normalized) parameter of the point on the first curve.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The property has not been set by the method providing the result.

#### Since

2018.1

### `P:Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.XYZPointOnSecondCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.XYZPointOnSecondCurve`

#### Summary

Point on the second curve in 3d coordinates.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The property has not been set by the method providing the result.

#### Since

2018.1

### `P:Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.XYZPointOnFirstCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.XYZPointOnFirstCurve`

#### Summary

Point on the first curve in 3d coordinates.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The property has not been set by the method providing the result.

#### Since

2018.1

### `M:Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.#ctor`

#### Summary

Obtain a new instance of ClosestPointsPairBetweenTwoCurves class.

#### Since

2018.1

### `M:Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.#ctor(Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves.#ctor(Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves)`

#### Summary

Creates a copy of the ClosestPointsPairBetweenTwoCurves.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018.1

### `T:Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves`

Member kind: type
Symbol: `Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves`

#### Summary

This class captures results of computation of closest points between two generic curves.

#### Since

2018.1

### `P:Autodesk.Revit.DB.ConicalFace.HalfAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConicalFace.HalfAngle`

#### Summary

Half angle of the surface.

### `P:Autodesk.Revit.DB.ConicalFace.Radius(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConicalFace.Radius(System.Int32)`

#### Summary

Radii of the surface.

### `P:Autodesk.Revit.DB.ConicalFace.Axis`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConicalFace.Axis`

#### Summary

Axis of the surface.

### `P:Autodesk.Revit.DB.ConicalFace.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConicalFace.Origin`

#### Summary

Origin of the surface.

### `T:Autodesk.Revit.DB.ConicalFace`

Member kind: type
Symbol: `Autodesk.Revit.DB.ConicalFace`

#### Summary

A conical face of a 3d solid or open shell.

#### Remarks

For details on the parameterization, refer to the documentation for `T:Autodesk.Revit.DB.ConicalSurface` .

### `P:Autodesk.Revit.DB.HermiteSplineTangents.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.HermiteSplineTangents.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.HermiteSplineTangents.EndTangent`

Member kind: property
Symbol: `Autodesk.Revit.DB.HermiteSplineTangents.EndTangent`

#### Summary

The tangent vector at the end of the curve.

#### Value

This must be a nomalized unit vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: endTangent has zero length.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The end tangent value is not set.

#### Since

2014

### `P:Autodesk.Revit.DB.HermiteSplineTangents.StartTangent`

Member kind: property
Symbol: `Autodesk.Revit.DB.HermiteSplineTangents.StartTangent`

#### Summary

The tangent vector at the start of the curve.

#### Value

This must be a nomalized unit vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: startTangent is not length 1.0.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The start tangent value is not set.

#### Since

2014

### `M:Autodesk.Revit.DB.HermiteSplineTangents.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.HermiteSplineTangents.#ctor`

#### Summary

Constructs a new default instance of the class, with tangent vectors uninitialized.

#### Since

2014

### `T:Autodesk.Revit.DB.HermiteSplineTangents`

Member kind: type
Symbol: `Autodesk.Revit.DB.HermiteSplineTangents`

#### Summary

This class indicates tangency at the start, the end, or both ends of the curve.

#### Remarks

Initially, the tangent vectors will not be set, and no tangency condition will be imposed when the
curve is created.

#### Since

2014

### `M:Autodesk.Revit.CurveAPIUtils.CreateHermiteSpline(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean,Autodesk.Revit.DB.HermiteSplineTangents)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateHermiteSpline(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean,Autodesk.Revit.DB.HermiteSplineTangents)`

#### Summary

Creates a Hermite spline with specified tangency at its endpoints.

#### Parameter `controlPoints`

The control points of the Hermite spline.

#### Parameter `periodic`

True if the Hermite spline is to be periodic, false otherwise.

#### Parameter `tangents`

The object which indicates tangency at the start, the end, or both ends of the curve.

#### Returns

The new HermiteSpline object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The control points array is invalid, because it doesn't contain the minimum number of points (2).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Unable to construct valid HermiteSpline from given inputs.

#### Since

2014

### `M:Autodesk.Revit.CurveAPIUtils.CreateHermiteSpline(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateHermiteSpline(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean)`

#### Summary

Creates a Hermite spline with default tangency at its endpoints.

#### Remarks

The tangents at the ends of the spline are computed from the control points.

#### Parameter `controlPoints`

The control points of the Hermite spline.

#### Parameter `periodic`

True if the Hermite spline is to be periodic, false otherwise.

#### Returns

The new HermiteSpline object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The control points array is invalid, because it doesn't contain the minimum number of points (2).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Unable to construct valid HermiteSpline from given inputs.

#### Since

2014

### `M:Autodesk.Revit.CurveAPIUtils.CreateNurbSpline(Autodesk.Revit.DB.HermiteSpline)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateNurbSpline(Autodesk.Revit.DB.HermiteSpline)`

#### Summary

Creates a new geometric NurbSpline by converting the given HermiteSpline.

#### Parameter `hermiteSpline`

The HermiteSpline that will be converted.

#### Returns

The new NURBSpline object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given hermite spline has to be non-periodic.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.CurveAPIUtils.CreateNurbsCurve(Autodesk.Revit.DB.HermiteSpline)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateNurbsCurve(Autodesk.Revit.DB.HermiteSpline)`

#### Summary

Creates a new geometric Curve object by converting the given HermiteSpline.
The created curve may be a NURBSpline or a simpler curve such as line or arc.

#### Remarks

The function does not support periodic Hermite curve.

#### Parameter `hermiteSpline`

The HermiteSpline that will be converted.

#### Returns

The new Curve object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given hermite spline has to be non-periodic.
-or-
Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.CurveAPIUtils.CreateNurbsCurve(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateNurbsCurve(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Double})`

#### Summary

Creates a new geometric Curve object from NURBS curve data containing just control points and weights.
The created curve may be a NURBSpline or a simpler curve such as line or arc.

#### Remarks

There must be at least 2 control points.
The number of weights must be equal to the the number of control points.
The values of all weights must be positive.

#### Parameter `controlPoints`

The control points of the NURBSpline.

#### Parameter `weights`

The weights of the NURBSpline.

#### Returns

The new Curve object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The number of control points must be at least 2.
-or-
The number of weights must be the same as the number of control points and all weights must be positive.
-or-
Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.CurveAPIUtils.CreateNurbsCurve(System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateNurbsCurve(System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Double})`

#### Summary

Creates a new geometric Curve object from NURBS curve data, which includes weights.
The created curve may be a NURBSpline or a simpler curve such as line or arc.

#### Remarks

Degree must be 1 or greater.
The number of control points must be greater than degree.
The number of knots must equal the sum of degree, number of controlPoints and 1.
The distinct knot values (ignoring multiplicities) must be in increasing order.
The start and end knots must have multiplicity equal to degree + 1.
The multiplicities of other interior knots must be at most degree - 2.
The number of weights must be equal to the the number of control points.
The values of all weights must be positive.

#### Parameter `degree`

The degree of the NURBSpline.

#### Parameter `knots`

The knots of the NURBSpline.

#### Parameter `controlPoints`

The control points of the NURBSpline.

#### Parameter `weights`

The weights of the NURBSpline.

#### Returns

The new Curve object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The degree must be at least 1.
-or-
The number of control points must be greater than degree.
-or-
The number of knots must equal the sum of number of control points, degree and 1.
-or-
An interior knot must not repeat itself more than degree times.
-or-
The number of weights must be the same as the number of control points and all weights must be positive.
-or-
Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.CurveAPIUtils.CreateNurbsCurve(System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateNurbsCurve(System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Creates a new geometric Curve object from NURBS curve data, which does not include weights.
The created curve may be a NURBSpline or a simpler curve such as line or arc.

#### Remarks

Degree must be 1 or greater.
The number of control points must be greater than degree.
The number of knots must equal the sum of degree, number of controlPoints and 1.
The distinct knot values (ignoring multiplicities) must be in increasing order.
The start and end knots must have multiplicity equal to degree + 1.
The multiplicities of other interior knots must be at most degree - 2.

#### Parameter `degree`

The degree of the NURBSpline.

#### Parameter `knots`

The knots of the NURBSpline.

#### Parameter `controlPoints`

The control points of the NURBSpline.

#### Returns

The new Curve object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The degree must be at least 1.
-or-
The number of control points must be greater than degree.
-or-
The number of knots must equal the sum of number of control points, degree and 1.
-or-
An interior knot must not repeat itself more than degree times.
-or-
Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.CurveAPIUtils.CreateEllipse(Autodesk.Revit.DB.XYZ,System.Double,System.Double,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateEllipse(Autodesk.Revit.DB.XYZ,System.Double,System.Double,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Boolean)`

#### Summary

Creates a new geometric ellipse or elliptical arc object.

#### Remarks

If the angle range is equal to or greater than 2 * PI, the curve will be
automatically converted to an unbounded ellipse.
If allowSimplification is true and the xRadius and yRadius parameters are almost
equal, it will return an arc instead of an ellipse.

#### Parameter `center`

The center.

#### Parameter `xRadius`

The x vector radius of the ellipse.

#### Parameter `yRadius`

The y vector radius of the ellipse.

#### Parameter `xAxis`

The x axis to define the ellipse plane. Must be normalized.

#### Parameter `yAxis`

The y axis to define the ellipse plane. Must be normalized.

#### Parameter `startParameter`

The raw parameter value at the start of the ellipse.

#### Parameter `endParameter`

The raw parameter value at the end of the ellipse.

#### Parameter `allowSimplification`

If true, create an arc if xRadius and yRadius are almost equal.

#### Returns

The new ellipse or elliptical arc.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for xRadius must be greater than 0 and no more than 30000 feet.
-or-
The given value for yRadius must be greater than 0 and no more than 30000 feet.
-or-
xAxis is not length 1.0.
-or-
yAxis is not length 1.0.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The vectors xAxis and yAxis are not perpendicular.
-or-
Start parameter must be less than end parameter.
-or-
Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Since

2014

### `M:Autodesk.Revit.CurveAPIUtils.CreateArc(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateArc(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

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

A non-optional argument was null

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

### `M:Autodesk.Revit.CurveAPIUtils.CreateArc(Autodesk.Revit.DB.Plane,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateArc(Autodesk.Revit.DB.Plane,System.Double,System.Double,System.Double)`

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

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for radius must be greater than 0 and no more than 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Start angle must be less than end angle.
-or-
Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Since

2014

### `M:Autodesk.Revit.CurveAPIUtils.CreateArc(Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateArc(Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

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

A non-optional argument was null

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

### `M:Autodesk.Revit.CurveAPIUtils.CreateUnboundLine(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateUnboundLine(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new instance of an unbound linear curve.

#### Parameter `origin`

The origin of the unbound line.

#### Parameter `direction`

The direction of the unbound line.

#### Returns

The new unbound line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

direction has zero length.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Vector and origin cannot form a proper unbound line.

#### Since

2014

### `M:Autodesk.Revit.CurveAPIUtils.CreateBoundLine(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateBoundLine(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new instance of a bound linear curve.

#### Parameter `endpoint1`

The first line endpoint.

#### Parameter `endpoint2`

The second line endpoint.

#### Returns

The new bound line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Since

2014

### `M:Autodesk.Revit.CurveAPIUtils.CreateTransformed(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.CreateTransformed(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.Transform)`

#### Summary

Crates a new instance of a curve as a transformation of an input curve.

#### Parameter `curve`

The curve to be copied and transformed.

#### Parameter `transform`

The transform to apply.

#### Returns

The new curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

transform is not conformal.

#### Since

2014

### `M:Autodesk.Revit.CurveAPIUtils.ComputeCurveDerivatives(Autodesk.Revit.DB.Curve,System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.ComputeCurveDerivatives(Autodesk.Revit.DB.Curve,System.Double,System.Boolean)`

#### Summary

Returns the vectors describing the curve at the specified parameter.

#### Remarks

The following is the meaning of the transformation members:
Origin is the point on the curve (equivalent to Evaluate).

BasisX is the tangent vector (the first derivative).

BasisY is the second derivative. Note that for curves where this cannot be uniquely determined (e.g. lines), this will be a Zero vector.

BasisZ is the bi-normal vector (tangent x normal). Note that for curves where normal cannot be uniquely determined (e.g. lines), this will be a Zero vector.
None of the vectors are normalized.

#### Parameter `curve`

The curve.

#### Parameter `parameter`

The parameter to be evaluated.

#### Parameter `normalized`

If false, param is interpreted as natural parameterization of the curve.
If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.

#### Returns

The transformation containing the point on the curve, the tangent vector, derivative of tangent vector, and bi-normal vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for parameter is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The curve cannot be evaluated as normalized because it is unbound.
-or-
The parameter is not a valid value for normalized evaluation.

### `M:Autodesk.Revit.CurveAPIUtils.EvaluateCurve(Autodesk.Revit.DB.Curve,System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.EvaluateCurve(Autodesk.Revit.DB.Curve,System.Double,System.Boolean)`

#### Summary

Evaluates and returns the point that matches a parameter along the curve.

#### Parameter `curve`

The curve.

#### Parameter `parameter`

The parameter to be evaluated.

#### Parameter `normalized`

If false, param is interpreted as natural parameterization of the curve.
If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.

#### Returns

The point evaluated along the curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for parameter is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The curve cannot be evaluated as normalized because it is unbound.
-or-
The parameter is not a valid value for normalized evaluation.

### `M:Autodesk.Revit.CurveAPIUtils.GetCurveEndParameter(Autodesk.Revit.DB.Curve,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.GetCurveEndParameter(Autodesk.Revit.DB.Curve,System.Int32)`

#### Summary

Returns the raw parameter value at the start or end of this curve.

#### Remarks

The start and end value of the parameter can be any value (as it is determined by Revit based on the parameterization of related geometry, or
based on calculations necessary to produce the geometry).
For curves with regular curvature like lines and arcs, the raw parameter can be used to measure along the curve in Revit's default units (feet).
Raw parameters are also the only way to evaluate points along unbound curves.

#### Parameter `curve`

The curve.

#### Parameter `index`

0 for the start or 1 for end of the curve.

#### Returns

The parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve is not bound.
-or-
index must be 0 for the start of the curve or 1 for the end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.CurveAPIUtils.GetCurveEndpoint(Autodesk.Revit.DB.Curve,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.CurveAPIUtils.GetCurveEndpoint(Autodesk.Revit.DB.Curve,System.Int32)`

#### Summary

Returns the 3D point at the start or end of this curve.

#### Parameter `curve`

The curve.

#### Parameter `index`

0 for the start or 1 for end of the curve.

#### Returns

The curve endpoint.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve is not bound.
-or-
index must be 0 for the start of the curve or 1 for the end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.CurveAPIUtils.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.CurveAPIUtils.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.CurveAPIUtils`

Member kind: type
Symbol: `Autodesk.Revit.CurveAPIUtils`

#### Summary

Contains native implementations of curve related functions exposed to API.

#### Remarks

All of the static methods contained within logically belong within the API in Curve or one of its subclasses.
The internal API wrappers are called directly by the related public API methods.

### `M:Autodesk.Revit.DB.InventorLink.HasInventorLinkAppInfo(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InventorLink.HasInventorLinkAppInfo(Autodesk.Revit.DB.Document)`

#### Summary

Checks whether an ADocument has InventorLinkAppInfo added.

#### Returns

True if an ADocument has InventorLinkAppInfo added, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.InventorLink.GetTranslationInfo(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InventorLink.GetTranslationInfo(Autodesk.Revit.DB.Document)`

#### Summary

Retrieves "TranslationInfo" from the InventorLinkAppInfo.

#### Parameter `ADoc`

ADocument that contains InventorLinkAppInfo.

#### Returns

Returns the serialized XML data that contains snapshot stream, model service settings
and other data related to the translation (named "TranslationInfo" in ATFRevitRCE Host/Broker).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input ADocument has no InventorLinkAppInfo added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.InventorLink.SetTranslationInfo(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InventorLink.SetTranslationInfo(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Sets "TranslationInfo" to the InventorLinkAppInfo.

#### Parameter `ADoc`

ADocument that contains InventorLinkAppInfo.

#### Parameter `translationInfo`

The serialized XML data that contains snapshot stream, model service settings
and other data related to the translation (named "TranslationInfo" in ATFRevitRCE Host/Broker).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.InventorLink`

Member kind: type
Symbol: `Autodesk.Revit.DB.InventorLink`

#### Summary

This class contains methods that can set the serialized XML data named
"TranslationInfo" to the InventorLinkAppInfo from the ATFRevitRCE Host/Broker
and can retrieve the "TranslationInfo" that is stored in the InventorLinkAppInfo.

#### Since

2022

### `M:Autodesk.Revit.DB.ElevationMarker.HasElevations`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElevationMarker.HasElevations`

#### Summary

Returns true if the ElevationMarker has at least one elevation view, false otherwise.

#### Returns

True if the ElevationMarker has at least one elevation view, false otherwise.

#### Since

2013

### `M:Autodesk.Revit.DB.ElevationMarker.IsAvailableIndex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElevationMarker.IsAvailableIndex(System.Int32)`

#### Summary

Returns true if a new elevation ViewSection can be placed at %index%, returns false otherwise.

#### Remarks

False will be returned if the %index% is already occupied or if %index% is out of range for the ElevationMarker.

#### Parameter `index`

The index of the ElevationMarker which will be checked.

#### Returns

True if an elevation can be created at %index%, false otherwise.

#### Since

2013

### `M:Autodesk.Revit.DB.ElevationMarker.GetViewId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElevationMarker.GetViewId(System.Int32)`

#### Summary

Returns the ViewSection id for the index of the ElevationMarker.

#### Parameter `index`

The index of the ElevationMarker for which a ViewSection id will be returned.

#### Returns

ViewSection id of the view at the ElevationMarker index, invalid element id otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The index index is out of range for this ElevationMarker.

#### Since

2013

### `M:Autodesk.Revit.DB.ElevationMarker.CreateReferenceElevation(Autodesk.Revit.DB.Document,System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElevationMarker.CreateReferenceElevation(Autodesk.Revit.DB.Document,System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a reference elevation on the ElevationMarker at the desired index.

#### Parameter `document`

The document to which the new reference elevation will be added.

#### Parameter `index`

The index on the ElevationMarker where the reference elevation will be placed.

#### Parameter `viewIdToReference`

The view which will be referenced.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId viewIdToReference does not correspond to a View.
-or-
This view cannot be referenced by elevations.
-or-
index is occupied or out of range.
-or-
Elevation view creation is not allowed in this family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Only reference elevations can be hosted on this ElevationMarker.

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

### `M:Autodesk.Revit.DB.ElevationMarker.CreateElevation(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElevationMarker.CreateElevation(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Int32)`

#### Summary

Creates a new elevation ViewSection on the ElevationMarker at the desired index.

#### Remarks

The ViewFamilyType for the new elevation ViewSection is inherited from the ElevationMarker.
The new elevation ViewSection will receive a unique view name.

#### Parameter `document`

The document to which the new elevation ViewSection will be added.

#### Parameter `viewPlanId`

The id of a ViewPlan in which the ElevationMarker is visible. The new elevation ViewSection will derive its extents
and inherit settings from the ViewPlan.

#### Parameter `index`

The index on the ElevationMarker where the new elevation ViewSection will be placed.
The index on the ElevationMarker must be valid and unused.
View direction is determined by the index.

#### Returns

The new elevation ViewSection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId viewPlanId does not correspond to a ViewPlan.
-or-
index is occupied or out of range.
-or-
Elevation view creation is not allowed in this family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Only reference elevations can be hosted on this ElevationMarker.

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

### `M:Autodesk.Revit.DB.ElevationMarker.CreateReferenceElevationMarker(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElevationMarker.CreateReferenceElevationMarker(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new ElevationMarker.

#### Parameter `document`

The document to which the new ElevationMarker will be added.

#### Parameter `viewFamilyTypeId`

This ViewFamilyType will be used by all elevations hosted on the new ElevationMarker.

#### Parameter `origin`

The desired origin for the ElevationMarker.

#### Parameter `viewPlanId`

The ViewPlan in which the reference ElevationMarker will appear. Reference ElevationMarkers only appear in one view.

#### Returns

The new ElevationMarker.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId viewPlanId does not correspond to a ViewPlan.
-or-
This view family type is not appropriate for ElevationMarkers.
-or-
Elevation view creation is not allowed in this family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ElevationMarker.CreateElevationMarker(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElevationMarker.CreateElevationMarker(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Int32)`

#### Summary

Creates a new ElevationMarker.

#### Parameter `document`

The document to which the new ElevationMarker will be added.

#### Parameter `viewFamilyTypeId`

This ViewFamilyType will be used by all elevations hosted on the new ElevationMarker.

#### Parameter `origin`

The desired origin for the ElevationMarker.

#### Parameter `initialViewScale`

This view scale will be automatically applied to new elevations created on the ElevationMarker.
The scale is the ratio of true model size to paper size.

#### Returns

The new ElevationMarker.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This view family type is not appropriate for ElevationMarkers.
-or-
The denominator X of the view scale 1/X must be in the range 1 to 24,000.
-or-
Elevation view creation is not allowed in this family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.ElevationMarker.IsReference`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElevationMarker.IsReference`

#### Summary

Indicates if this is a reference ElevationMarker.
Only reference elevations can be hosted by reference ElevationMarkers.

#### Since

2013

### `P:Autodesk.Revit.DB.ElevationMarker.MaximumViewCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElevationMarker.MaximumViewCount`

#### Summary

The maximum number of views that can be hosted by this ElevationMarker.

#### Since

2013

### `P:Autodesk.Revit.DB.ElevationMarker.CurrentViewCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElevationMarker.CurrentViewCount`

#### Summary

The current number of views hosted by this ElevationMarker.

#### Since

2013

### `T:Autodesk.Revit.DB.ElevationMarker`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElevationMarker`

#### Summary

ElevationMarkers either host elevation ViewSection views or view references.

#### Remarks

ElevationMarkers store the ViewFamilyType which will be used by all elevations
hosted on the ElevationMarker.
The orientation of an ElevationMarker is determined by the orientation of the views
it hosts. You can check the orientation of any view by getting View.ViewDirection.
To reorient the ElevationMarker and all of the views it hosts, call
ElementTransformUtils.RotateElement with the ElevationMarker as an argument.

#### Since

2013

### `P:Autodesk.Revit.DB.IntegerRange.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntegerRange.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.IntegerRange.High`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntegerRange.High`

#### Summary

The upper limit of the range

#### Since

2015

### `P:Autodesk.Revit.DB.IntegerRange.Low`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntegerRange.Low`

#### Summary

The lower limit of the range

#### Since

2015

### `T:Autodesk.Revit.DB.IntegerRange`

Member kind: type
Symbol: `Autodesk.Revit.DB.IntegerRange`

#### Summary

A class to define a range of a sequence of consecutive integer numbers

#### Since

2015

### `M:Autodesk.Revit.DB.InstanceVoidCutUtils.GetCuttingVoidInstances(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InstanceVoidCutUtils.GetCuttingVoidInstances(Autodesk.Revit.DB.Element)`

#### Summary

Return ids of the instances with unattached voids cutting the element.

#### Parameter `element`

The element being cut

#### Returns

Ids of instances with unattached voids that cut this element

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.InstanceVoidCutUtils.GetElementsBeingCut(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InstanceVoidCutUtils.GetElementsBeingCut(Autodesk.Revit.DB.Element)`

#### Summary

Return ids of the elements being cut by the instance

#### Parameter `cuttingInstance`

The cutting family instance

#### Returns

Ids of elements being cut by cuttingInstance

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.InstanceVoidCutUtils.InstanceVoidCutExists(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InstanceVoidCutUtils.InstanceVoidCutExists(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Check whether the instance is cutting the element

#### Parameter `element`

The element being cut

#### Parameter `cuttingInstance`

The cutting family instance

#### Returns

Returns true if the instance is cutting the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.InstanceVoidCutUtils.RemoveInstanceVoidCut(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InstanceVoidCutUtils.RemoveInstanceVoidCut(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Remove a cut applied to the element by a cutting instance with unattached voids.

#### Parameter `document`

The document containing the two elements

#### Parameter `element`

The element being cut

#### Parameter `cuttingInstance`

The cutting family instance

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

No instance void cut exists between the two elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to remove the instance cut from the element

#### Since

2011

### `M:Autodesk.Revit.DB.InstanceVoidCutUtils.AddInstanceVoidCut(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InstanceVoidCutUtils.AddInstanceVoidCut(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Add a cut to an element using the unattached voids inside a cutting instance.

#### Parameter `document`

The document containing the two elements

#### Parameter `element`

The element to be cut

#### Parameter `cuttingInstance`

The cutting family instance

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element cannot be cut with a void instance.
-or-
The element is not a family instance with an unattached void that can cut.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to cut element with the instances

#### Since

2011

### `M:Autodesk.Revit.DB.InstanceVoidCutUtils.IsVoidInstanceCuttingElement(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InstanceVoidCutUtils.IsVoidInstanceCuttingElement(Autodesk.Revit.DB.Element)`

#### Summary

Indicates if the element is a family instance with unattached voids that can cut other elements.

#### Remarks

A family instance can cut if the family has unattached voids and the family's parameter
"Cut with Voids When Loaded" is checked.

#### Parameter `element`

The cutting family instance

#### Returns

Returns true if the element is a family instance with unattached voids that can cut other elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.InstanceVoidCutUtils.CanBeCutWithVoid(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InstanceVoidCutUtils.CanBeCutWithVoid(Autodesk.Revit.DB.Element)`

#### Summary

Indicates if the element can be cut by an instance with unattached voids.

#### Remarks

Elements in a project can be cut if they are host elements or family instances
with a category Generic Model or one of the structural categories.

#### Parameter `element`

The element to be cut

#### Returns

Returns true if the element can be cut by an instance with unattached voids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.InstanceVoidCutUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.InstanceVoidCutUtils`

#### Summary

Utilities for cutting elements by unattached voids in family instances.

#### Since

2011

### `T:Autodesk.Revit.DB.InsertOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.InsertOrientation`

#### Summary

The allowed values for the INSERT_ORIENTATION parameter.

### `F:Autodesk.Revit.DB.InsertOrientation.Interior`

Member kind: field
Symbol: `Autodesk.Revit.DB.InsertOrientation.Interior`

#### Summary

Insert is aligned with the Tapered wall's interior face.

### `F:Autodesk.Revit.DB.InsertOrientation.Exterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.InsertOrientation.Exterior`

#### Summary

Insert is aligned with the Tapered wall's exterior face.

### `F:Autodesk.Revit.DB.InsertOrientation.Slanted`

Member kind: field
Symbol: `Autodesk.Revit.DB.InsertOrientation.Slanted`

#### Summary

Insert is aligned with the Slanted wall's slant direction.

### `F:Autodesk.Revit.DB.InsertOrientation.Vertical`

Member kind: field
Symbol: `Autodesk.Revit.DB.InsertOrientation.Vertical`

#### Summary

Insert is vertical regardless of the wall's slant.

### `P:Autodesk.Revit.DB.Lighting.InitialWattageIntensity.Wattage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.InitialWattageIntensity.Wattage`

#### Summary

The wattage value.

#### Value

The wattage value in W as a numerical value between 0 and 1e+30.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The wattage value is not valid because it is not between 0 and 1e+30.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.InitialWattageIntensity.Efficacy`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.InitialWattageIntensity.Efficacy`

#### Summary

The efficacy value.

#### Value

The efficacy value in lm/W as a numerical value greater than 0.0 and less than 1.0e+10.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The efficacy value is not valid because it is not between 0 and 1e+30.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.InitialWattageIntensity.#ctor(Autodesk.Revit.DB.Lighting.InitialWattageIntensity)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.InitialWattageIntensity.#ctor(Autodesk.Revit.DB.Lighting.InitialWattageIntensity)`

#### Summary

Creates a copy of the given initial wattage intensity object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.InitialWattageIntensity.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.InitialWattageIntensity.#ctor(System.Double,System.Double)`

#### Summary

Creates an initial wattage intensity object with the given values.

#### Parameter `efficacy`

The universal unit efficacy value as a numerical value between 0 and 1e+30.

#### Parameter `wattage`

The universal unit wattage value as a numerical value between 0 and 1e+30.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The efficacy value is not valid because it is not between 0 and 1e+30.
-or-
The wattage value is not valid because it is not between 0 and 1e+30.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.InitialWattageIntensity`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.InitialWattageIntensity`

#### Summary

This class encapsulates initial wattage intensity calculation.

#### Since

2013

### `M:Autodesk.Revit.DB.StartingViewSettings.IsAcceptableStartingView(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StartingViewSettings.IsAcceptableStartingView(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the given Id is an acceptable starting view. InvalidElementId corresponds to "Last Viewed" and is therefore also acceptable.

#### Remarks

Model views (such as plans, ceiling plans, sections, elevations, and 3d views) are acceptable.
In addition, drafting views, sheets, legends, schedules, and graphical column schedules are generally acceptable.
Special views such as the project browser, system navigator, reports, revision schedules, internal schedules,
sheets that are not actually in use, and views that belong to a family are not acceptable.

#### Parameter `viewId`

The Id of the element to check.

#### Returns

True if the view is acceptable, False if it is not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.StartingViewSettings.GetStartingViewSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StartingViewSettings.GetStartingViewSettings(Autodesk.Revit.DB.Document)`

#### Summary

Returns the starting view settings for the specified document.

#### Parameter `doc`

The document to get the settings from, which must be a project document.

#### Returns

The starting view settings for the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

doc is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.StartingViewSettings.ViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.StartingViewSettings.ViewId`

#### Summary

Indicates the specific view that will be opened when the model is loaded. InvalidElementId indicates
that no view has been specified. In that case, Revit will open the last views that were open at the
time the file was saved.

#### Remarks

Note that InvalidElementId will cause Revit to open the same view it would have used
in Revit 2011 and prior releases.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: viewId is not an acceptable starting view for this model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.StartingViewSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.StartingViewSettings`

#### Summary

The initial view settings for a document dictate which view will initially be open when this model
is opened. These settings are available for all Revit project documents.

#### Remarks

If worksharing is enabled, the same settings will be used by the central model and all
local files and the settings will live in the Project Info workset.

#### Since

2012

### `P:Autodesk.Revit.DB.Lighting.InitialLuminousIntensity.Luminosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.InitialLuminousIntensity.Luminosity`

#### Summary

The luminosity value.

#### Value

The luminosity value in cd as a numerical value between 0 and 1e+30.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The luminosity value is not valid because it is not between 0 and 1e+30.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.InitialLuminousIntensity.#ctor(Autodesk.Revit.DB.Lighting.InitialLuminousIntensity)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.InitialLuminousIntensity.#ctor(Autodesk.Revit.DB.Lighting.InitialLuminousIntensity)`

#### Summary

Creates a copy of the given initial luminous intensity object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.InitialLuminousIntensity.#ctor(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.InitialLuminousIntensity.#ctor(System.Double)`

#### Summary

Creates an initial luminous intensity object with the given document and luminosity values.

#### Parameter `luminosity`

The luminosity value in cd as a numerical value between 0 and 1e+30.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The luminosity value is not valid because it is not between 0 and 1e+30.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.InitialLuminousIntensity`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.InitialLuminousIntensity`

#### Summary

This class encapsulates initial luminous intensity calculation.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity.Illuminance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity.Illuminance`

#### Summary

The illuminance intensity value.

#### Value

The illuminance value in lx as a numerical value between 0 and 1e+30.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The illuminance value is not valid because it is not between 0 and 1e+30.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity.Distance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity.Distance`

#### Summary

The illuminance intensity distance value.

#### Value

The illuminance distance value in feet as a numerical value between 0 and 1e+30.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The distance value is not valid because it is not between 0 and 1e+30.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity.#ctor(Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity.#ctor(Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity)`

#### Summary

Creates a copy of the given initial illuminance intensity object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity.#ctor(System.Double,System.Double)`

#### Summary

Creates an initial illuminance intensity object with the given document and illuminance values.

#### Parameter `distance`

The illuminance distance value in feet as a numerical value between 0 and 1e+30.

#### Parameter `illuminance`

The illuminance value in lx as a numerical value between 0 and 1e+30.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The distance value is not valid because it is not between 0 and 1e+30.
-or-
The illuminance value is not valid because it is not between 0 and 1e+30.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity`

#### Summary

This class encapsulates initial illuminance intensity calculation.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.InitialFluxIntensity.Flux`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.InitialFluxIntensity.Flux`

#### Summary

The flux intensity value.

#### Value

The flux value in lm as a numerical value between 0 and 1e+30.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The flux intensity value is not valid because it is not between 0 and 1e+30.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.InitialFluxIntensity.#ctor(Autodesk.Revit.DB.Lighting.InitialFluxIntensity)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.InitialFluxIntensity.#ctor(Autodesk.Revit.DB.Lighting.InitialFluxIntensity)`

#### Summary

Creates a copy of the given initial flux intensity object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.InitialFluxIntensity.#ctor(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.InitialFluxIntensity.#ctor(System.Double)`

#### Summary

Creates an initial flux intensity object with the given document and flux values.

#### Parameter `flux`

The flux value in lm as a numerical value between 0 and 1e+30.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The flux intensity value is not valid because it is not between 0 and 1e+30.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.InitialFluxIntensity`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.InitialFluxIntensity`

#### Summary

This class encapsulates initial flux intensity calculation.

#### Since

2013

### `P:Autodesk.Revit.DB.InCanvasControlData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.InCanvasControlData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.InCanvasControlData.ImagePath`

Member kind: property
Symbol: `Autodesk.Revit.DB.InCanvasControlData.ImagePath`

#### Summary

The path to the image file to be used.
This must be an absolute path to a location on disk.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The file format specified by imagePath is an unsupported format - only *.bmp files are supported.
-or-
When setting this property: The file path specified by imagePath is not absolute.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

When setting this property: The file specified by imagePath doesn't exist.

#### Since

2022

### `P:Autodesk.Revit.DB.InCanvasControlData.Position`

Member kind: property
Symbol: `Autodesk.Revit.DB.InCanvasControlData.Position`

#### Summary

The position of the in-canvas control in model coordinates.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.InCanvasControlData.#ctor(System.String,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InCanvasControlData.#ctor(System.String,Autodesk.Revit.DB.XYZ)`

#### Summary

Constructs an InCanvasControlData with specific values assigned.

#### Parameter `imagePath`

File path with the image to be used.
This must be an absolute path to a location on disk.

#### Parameter `position`

The position to be used.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The file format specified by imagePath is an unsupported format - only *.bmp files are supported.
-or-
The file path specified by imagePath is not absolute.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file specified by imagePath doesn't exist.

#### Since

2022

### `M:Autodesk.Revit.DB.InCanvasControlData.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InCanvasControlData.#ctor(System.String)`

#### Summary

Constructs an InCanvasControlData with specific values assigned.

#### Parameter `imagePath`

File path with the image to be used.
This must be an absolute path to a location on disk.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The file format specified by imagePath is an unsupported format - only *.bmp files are supported.
-or-
The file path specified by imagePath is not absolute.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file specified by imagePath doesn't exist.

#### Since

2022

### `T:Autodesk.Revit.DB.InCanvasControlData`

Member kind: type
Symbol: `Autodesk.Revit.DB.InCanvasControlData`

#### Summary

Represents a collection of data which is used by `!:Autodesk::Revit::DB::TemporaryGraphicsManager` to create and update an in-canvas control.

#### Remarks

So far, only bitmap file is supported for `P:Autodesk.Revit.DB.InCanvasControlData.ImagePath` . The rendered image is the same size
in pixel dimensions as the original one. To get a better result, the caller should prepare the image with proper size, for exmaple: 32x32 or 64x64 in pixels,
before use. To achive a "transparent" backgound color effect over the provided bitmap, the bitmap should use color RGB(0, 128, 128) as its background and
it will be cleared during rendering by Revit.

#### Since

2022

### `M:Autodesk.Revit.DB.ImportIFCOptions.GetImportIFCOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportIFCOptions.GetImportIFCOptions`

#### Summary

Returns the current Revit instance's ImportIFCOptions.

#### Returns

The ImportIFCOptions for the current Revit instance.

#### Since

2024

### `P:Autodesk.Revit.DB.ImportIFCOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImportIFCOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ImportIFCOptions.LinkProcessor`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImportIFCOptions.LinkProcessor`

#### Summary

Specifies the engine to use while doing a Link IFC operation.

#### Remarks

This setting allows the user to revert to the legacy Revit link IFC code
when linking in IFC files, to preserve old behavior. There are three supported
options:
Default: let Revit decide the best processor.
Legacy: use only the legacy Revit Link IFC processor.
AnyCAD: use AnyCAD to help Link IFC files.
Any other value (or no entry) will behave as "Default".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `T:Autodesk.Revit.DB.ImportIFCOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImportIFCOptions`

#### Summary

Provides access to settings that control linking and opening IFC files.

#### Remarks

These settings are stored in the Revit.ini file. All documents in Revit instances which use this Revit.ini will follow these settings.

#### Since

2024

### `M:Autodesk.Revit.DB.ImportAXMUtil.AppendShapesToImportSymbol(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},System.Collections.Generic.IList{System.String},System.Collections.Generic.IList{Autodesk.Revit.DB.Transform},System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportAXMUtil.AppendShapesToImportSymbol(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},System.Collections.Generic.IList{System.String},System.Collections.Generic.IList{Autodesk.Revit.DB.Transform},System.Collections.Generic.IList{System.String})`

#### Summary

Append geometries to primary import symbol.
Support to reuse the same part of geometries as secondary import symbol
and instatiate with different transforms.
The id of primary import symbol.
The unique name of secondary import symbol.
The geometries to append.
The array of all geometries' layer name.
The array of all instances' transform.
The array of all instances' layer name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.ImportAXMUtil`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImportAXMUtil`

#### Summary

ImportAXMUtil contains some helper functions exposed to FormItConverter.

### `M:Autodesk.Revit.DB.ImageTypeOptions.IsValid(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageTypeOptions.IsValid(Autodesk.Revit.DB.Document)`

#### Summary

If true the ImageTypeOptions can be used to create or reload an ImageType.

#### Remarks

This method returns true if all the following checks are true:
The Path points to a file that is a supported image file type.The Path points to a file that is not encrypted, which can happen for PDF files.The Path points to a file that contains the specified PageNumber.Only imported images are allowed in family documents.

#### Parameter `document`

The document.

#### Returns

Returns True if the options can be used to create or reload an ImageType. False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.ImageTypeOptions.SetExternalResourceReference(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageTypeOptions.SetExternalResourceReference(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Update the external resource reference to an image.

#### Parameter `resourceReference`

An external resource reference to an image.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.ImageTypeOptions.SetPath(System.String,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageTypeOptions.SetPath(System.String,System.Boolean)`

#### Summary

Update the path of the file that specifies the image to be used.

The provided string path must specify a local file. The path can be absolute or relative
to the project's location.

Additionally, indicate whether the path used by ImageType should be absolute or relative.

#### Parameter `path`

The file path that specifies the image to be used.

#### Parameter `useRelativePath`

True if ImageType should use a relative path, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.ImageTypeOptions.SetPath(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageTypeOptions.SetPath(System.String)`

#### Summary

Update the path of the file that specifies the image to be used.

The provided string path must specify a local file. The path can be absolute or relative
to the project's location. ImageType will respectively use an absolute or relative path.

#### Parameter `path`

The file path that specifies the image to be used.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `P:Autodesk.Revit.DB.ImageTypeOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageTypeOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ImageTypeOptions.SourceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageTypeOptions.SourceType`

#### Summary

Indicates whether the image type is a link or an import.

#### Remarks

Use this property with the method ImageType::Create to create a linked image type.
Use this property with the method ImageType::ReloadFrom to convert an import image type to a link and vice versa.
Valid values are 'Import' and 'Link'.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The ImageType source is not correct. Only Link or Import values are allowed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2021

### `P:Autodesk.Revit.DB.ImageTypeOptions.Resolution`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageTypeOptions.Resolution`

#### Summary

The Resolution of the image is expressed in dots-per-inch and hence determines the size of a pixel in the image.

#### Remarks

For raster based image formats (*.bmp, *.jpg, *.jpeg, *.png, *.tif)
the Resolution is used to calculate the size of the image from the number
of pixels in the horizontal and vertical directions.

For PDF files, which have a known paper size, the Resolution is used
to control the amount of detail to capture in the image.
Increasing the Resolution of PDF based images will add more
detail to the image, but will also increase the amount of
data stored in the project file.

The default value of this property is 72 dpi.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for resolution must be positive.

#### Since

2020

### `P:Autodesk.Revit.DB.ImageTypeOptions.PageNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageTypeOptions.PageNumber`

#### Summary

The page in the file to be used for the image

#### Remarks

The default value of this property is 1. This default is appropriate for most file types.
This should be used for files, such as PDF files, that can have multiple pages.
Valid values range from 1 to the number of pages in the file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for pageNumber is not positive.

#### Since

2020

### `P:Autodesk.Revit.DB.ImageTypeOptions.Path`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageTypeOptions.Path`

#### Summary

The path of the file that specifies the image to be used.

#### Since

2020

### `M:Autodesk.Revit.DB.ImageTypeOptions.#ctor(Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ImageTypeSource)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageTypeOptions.#ctor(Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ImageTypeSource)`

#### Summary

Constructs a new instance of the ImageTypeOptions object.

#### Remarks

ImageTypeOptions uses an external resource reference to determine the local path that will be used
to open the image file. The operation to obtain the local path requires the resource to be loaded and is
performed at a later time when the local path is needed, for example, for validation. See also
LoadResource method of `T:Autodesk.Revit.DB.IExternalResourceServer` .

When the provided external resource reference contains a local file path, the information can include
an indication that the path should be treated as a relative path.

#### Parameter `resourceReference`

An external resource reference to an image.

#### Parameter `sourceType`

Specifies the image type source. Valid values are 'Import' and 'Link'.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ImageType source is not correct. Only Link or Import values are allowed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020

### `M:Autodesk.Revit.DB.ImageTypeOptions.#ctor(System.String,System.Boolean,Autodesk.Revit.DB.ImageTypeSource)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageTypeOptions.#ctor(System.String,System.Boolean,Autodesk.Revit.DB.ImageTypeSource)`

#### Summary

Constructs a new instance of the ImageTypeOptions object.

The provided string path must specify a local file. The path can be absolute or relative
to the project's location.

This constructor saves an additional setting that indicates whether the imagetype
will be a link or an import.

#### Parameter `path`

The file path that specifies the image to be used.

#### Parameter `useRelativePath`

True if ImageType should use a relative path, false otherwise.

#### Parameter `sourceType`

Specifies the image type source. Valid values are 'Import' and 'Link'.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ImageType source is not correct. Only Link or Import values are allowed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2021

### `T:Autodesk.Revit.DB.ImageTypeOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImageTypeOptions`

#### Summary

Represents the options used in `M:Autodesk.Revit.DB.ImageType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ImageTypeOptions)`
and `M:Autodesk.Revit.DB.ImageType.ReloadFrom(Autodesk.Revit.DB.ImageTypeOptions)` methods.

#### Remarks

ImageTypeOptions are used to describe how an ImageType should be created from
an image file.

ImageTypeOptions are used to specify the location of the image file to use for the image
using either a string path or an `T:Autodesk.Revit.DB.ExternalResourceReference` .

ImageTypeOptions are used to specify if the file path should be stored as an absolute path,
or a relative path. A relative path is relative to the location of the project file,
unless the file is workshared, in which case the relative path is relative to the location of the central file.
Note that the relative path option is only available if the project file has been saved.

ImageTypeOptions are used to specify whether the image should be imported or linked.
For imported images the image data is added to the Revit project file.
For linked images the image data is reloaded everytime the project file is opened.
Linked images are only available if they were reloaded successfully, while imported images are always available.

For PDF files the ImageTypeOptions can be used to specify which page in the PDF file to use for the image.
For raster based image files the page number must be 1 (the default).

ImageTypeOptions can be used to specify the resolution (in pixels per inch) to use for the image.
For PDF files the resolution is used to determine how many pixels to use
when rasterizing the PDF page. Using a higher resolution will increase the number of pixels.
This will add more detail, but it will also make rendering the image slower.
In addition, it will likely increase the amount of data stored in the project when the image is imported.

Raster based images have a fixed number of pixels.
As a result, the resolution has no effect on the amount of detail or the amount of data that is stored.
The resolution is only used to determine the size of image.
Doubling the resolution will make the image appear half the size.

When a file is accessed with the help of an external server, it is likely that a local cache of the file will
be created temporarily. ImageTypeOptions may refer to the cached copy of the file internally. For this
reason, ImageTypeOptions should be treated as a transient object whose purpose is to become an argument to
`M:Autodesk.Revit.DB.ImageType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ImageTypeOptions)`
or `M:Autodesk.Revit.DB.ImageType.ReloadFrom(Autodesk.Revit.DB.ImageTypeOptions)` .
An application should not create an ImageTypeOptions object and hold onto it for a long time.

#### Since

2020

### `P:Autodesk.Revit.DB.ImagePlacementOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImagePlacementOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ImagePlacementOptions.PlacementPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImagePlacementOptions.PlacementPoint`

#### Summary

Identifies which point of the `T:Autodesk.Revit.DB.ImageInstance` will be aligned to the `P:Autodesk.Revit.DB.ImagePlacementOptions.Location`

#### Remarks

The location of the corners of the image in the model depends on the size and orientation of the `T:Autodesk.Revit.DB.ImageInstance`
and the orientation of the view it is placed in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020

### `P:Autodesk.Revit.DB.ImagePlacementOptions.Location`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImagePlacementOptions.Location`

#### Summary

The location in the model where a point of the `T:Autodesk.Revit.DB.ImageInstance` , determined by the `P:Autodesk.Revit.DB.ImagePlacementOptions.PlacementPoint` property, is going to be inserted.

#### Remarks

The location represents a point in the model where the `T:Autodesk.Revit.DB.ImageInstance` will be placed.
The location of the image in the view is determined by the projection of this
point onto the plane of the view.
This means that in a plan view, for example, the z-coordinate has no effect.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.ImagePlacementOptions.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.BoxPlacement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImagePlacementOptions.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.BoxPlacement)`

#### Summary

Constructs a new ImagePlacementOptions for placing an `T:Autodesk.Revit.DB.ImageInstance`

#### Parameter `location`

The location where the image will be placed

#### Parameter `placementPoint`

The point of the image that will be aligned to the location in the view

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020

### `M:Autodesk.Revit.DB.ImagePlacementOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImagePlacementOptions.#ctor`

#### Summary

Constructs a new ImagePlacementOptions that will place an `T:Autodesk.Revit.DB.ImageInstance` with its center at the origin of the model

#### Since

2020

### `T:Autodesk.Revit.DB.ImagePlacementOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImagePlacementOptions`

#### Summary

ImagePlacementOptions are used to describe where an `T:Autodesk.Revit.DB.ImageInstance` should be placed in a view

#### Since

2020

### `M:Autodesk.Revit.DB.ImageInstance.IsValidView(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageInstance.IsValidView(Autodesk.Revit.DB.View)`

#### Summary

Check that the view is a valid view for ImageInstance elements

#### Parameter `view`

The view to validate

#### Returns

True if the view can contain ImageInstance elements. False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.ImageInstance.SetLocation(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.BoxPlacement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageInstance.SetLocation(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.BoxPlacement)`

#### Summary

Moves the ImageInstance to the specified location

#### Parameter `newLocation`

The new location of the specified point

#### Parameter `placementPoint`

The placementPoint specifies which point of the ImageInstance should be placed at the given location.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given newLocation is more than 10 miles from the origin of the model

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020

### `M:Autodesk.Revit.DB.ImageInstance.GetLocation(Autodesk.Revit.DB.BoxPlacement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageInstance.GetLocation(Autodesk.Revit.DB.BoxPlacement)`

#### Summary

Returns the location of one of the points of the ImageInstance

#### Parameter `placementPoint`

The placementPoint specifies for which point of the ImageInstance the location should be returned.

#### Returns

The location of the specified point

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020

### `M:Autodesk.Revit.DB.ImageInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ImagePlacementOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ImagePlacementOptions)`

#### Summary

Creates a new ImageInstance element placed in a view.

#### Parameter `document`

The document.

#### Parameter `view`

The view in which the image will be placed.

#### Parameter `imageTypeId`

The id of the `T:Autodesk.Revit.DB.ImageType` element for this ImageInstance.

#### Parameter `placementOptions`

Options that specify where the ImageInstance should be placed.

#### Returns

The new ImageInstance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given view cannot contain ImageInstance elements
-or-
The given imageTypeId can not be used as a ImageType for ImageInstance elements
-or-
The given placementOptions specify a location that is more than 10 miles from the origin of the model.

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

2020

### `P:Autodesk.Revit.DB.ImageInstance.CanHaveSnaps`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageInstance.CanHaveSnaps`

#### Summary

When true the ImageInstance has snaps that can be enabled with the `P:Autodesk.Revit.DB.ImageInstance.EnableSnaps` property

#### Remarks

Snaps are only available for images based on PDF files that are vector based.

#### Since

2020

### `P:Autodesk.Revit.DB.ImageInstance.EnableSnaps`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageInstance.EnableSnaps`

#### Summary

When true the ImageInstance will have its snaps enabled, but only if `P:Autodesk.Revit.DB.ImageInstance.CanHaveSnaps` is true

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The image does not have snaps

#### Since

2020

### `P:Autodesk.Revit.DB.ImageInstance.DrawLayer`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageInstance.DrawLayer`

#### Summary

The layer the ImageInstance will be drawn in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020

### `P:Autodesk.Revit.DB.ImageInstance.LockProportions`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageInstance.LockProportions`

#### Summary

When true the proportion of `P:Autodesk.Revit.DB.ImageInstance.Width` to `P:Autodesk.Revit.DB.ImageInstance.Height` will be maintained

#### Since

2020

### `P:Autodesk.Revit.DB.ImageInstance.HeightScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageInstance.HeightScale`

#### Summary

The factor applied to the `T:Autodesk.Revit.DB.ImageType` to calculate the `P:Autodesk.Revit.DB.ImageInstance.Height` of the ImageInstance.

#### Remarks

If `P:Autodesk.Revit.DB.ImageInstance.LockProportions` is true, then changes to the `P:Autodesk.Revit.DB.ImageInstance.HeightScale` will also result in changes to the `P:Autodesk.Revit.DB.ImageInstance.WidthScale` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for heightScale results in a height that is more than 30000 feet.
-or-
When setting this property: The given value for heightScale results in a width that is more than 30000 feet because LockProportions is set to true.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for heightScale must be non-negative.

#### Since

2020

### `P:Autodesk.Revit.DB.ImageInstance.WidthScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageInstance.WidthScale`

#### Summary

The factor applied to the width of the `T:Autodesk.Revit.DB.ImageType` to calculate the `P:Autodesk.Revit.DB.ImageInstance.Width` of the ImageInstance.

#### Remarks

If `P:Autodesk.Revit.DB.ImageInstance.LockProportions` is true, then changes to the `P:Autodesk.Revit.DB.ImageInstance.WidthScale` will also result in changes to the `P:Autodesk.Revit.DB.ImageInstance.HeightScale` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for widthScale results in a width that is more than 30000 feet.
-or-
When setting this property: The given value for widthScale results in a height that is more than 30000 feet because LockProportions is set to true.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for widthScale must be non-negative.

#### Since

2020

### `P:Autodesk.Revit.DB.ImageInstance.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageInstance.Height`

#### Summary

The height of the ImageInstance.

#### Remarks

If `P:Autodesk.Revit.DB.ImageInstance.LockProportions` is true, then changes to the `P:Autodesk.Revit.DB.ImageInstance.Height` will also result in changes to the `P:Autodesk.Revit.DB.ImageInstance.Width` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for height results in a width that is more than 30000 feet because LockProportions is set to true.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for height must be between 0 and 30000 feet.

#### Since

2020

### `P:Autodesk.Revit.DB.ImageInstance.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageInstance.Width`

#### Summary

The width of the ImageInstance.

#### Remarks

If `P:Autodesk.Revit.DB.ImageInstance.LockProportions` is true, then changes to the `P:Autodesk.Revit.DB.ImageInstance.Width` will also result in changes to the `P:Autodesk.Revit.DB.ImageInstance.Height` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for width results in a height that is more than 30000 feet because LockProportions is set to true.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for width must be between 0 and 30000 feet.

#### Since

2020

### `T:Autodesk.Revit.DB.ImageInstance`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImageInstance`

#### Summary

An element that represents an instance of an image placed in a view

#### Since

2020

### `T:Autodesk.Revit.DB.DrawLayer`

Member kind: type
Symbol: `Autodesk.Revit.DB.DrawLayer`

#### Summary

An enumerated type containing possible DrawLayer options.

#### Since

2020

#### Since

2020

### `F:Autodesk.Revit.DB.DrawLayer.Background`

Member kind: field
Symbol: `Autodesk.Revit.DB.DrawLayer.Background`

#### Summary

Draw in the background layer

### `F:Autodesk.Revit.DB.DrawLayer.Foreground`

Member kind: field
Symbol: `Autodesk.Revit.DB.DrawLayer.Foreground`

#### Summary

Draw in the foreground layer

### `M:Autodesk.Revit.DB.ImageExportOptions.GetViewsAndSheets`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageExportOptions.GetViewsAndSheets`

#### Summary

Gets a list of views and sheets to be exported. Used only when ExportRange is SetOfViews.

#### Returns

The ids of the views and sheets.

#### Since

2011

### `M:Autodesk.Revit.DB.ImageExportOptions.SetViewsAndSheets(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageExportOptions.SetViewsAndSheets(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets a list of views and sheets to be exported. Used only when ExportRange is SetOfViews.

#### Parameter `viewsAndSheets`

The ids of the views and sheets.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ImageExportOptions.GetFileName(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageExportOptions.GetFileName(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the file name that will be produced when exporting a view to an image.

#### Parameter `aDoc`

The document that owns the view.

#### Parameter `dbViewId`

View which is to be exported as image.

#### Returns

The generated exported image file name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ImageExportOptions.IsValidFileName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageExportOptions.IsValidFileName(System.String)`

#### Summary

Verify if File name is valid

#### Parameter `filePath`

File path to be tested for valid file name

#### Returns

True if File name is valid; false otherwise

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ImageExportOptions.IsValidForSaveToProjectAsImage(Autodesk.Revit.DB.ImageExportOptions,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageExportOptions.IsValidForSaveToProjectAsImage(Autodesk.Revit.DB.ImageExportOptions,Autodesk.Revit.DB.Document)`

#### Summary

Verify if ImageExportOptions object is valid for calling saveToProjectAsImage

#### Parameter `options`

ImageExportOptions object to be validated

#### Parameter `doc`

Document for view name verification

#### Returns

True if ImageExportOptions object is valid for calling saveToProjectAsImage; false otherwise

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.ImageExportOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageExportOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ImageExportOptions.ExportRange`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageExportOptions.ExportRange`

#### Summary

The export range defining which view(s) will be exported.

#### Remarks

Note that SetOfViews is not an acceptable value if these options are used to save an image to a project as a new view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.ImageExportOptions.ShouldCreateWebSite`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageExportOptions.ShouldCreateWebSite`

#### Summary

Whether or not to create a web site with a page for each export. Used only when ExportRange is SetOfViews.

#### Remarks

The default is false.
This field is ignored if used to save an image to a project as a new view.

#### Since

2011

### `P:Autodesk.Revit.DB.ImageExportOptions.FilePath`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageExportOptions.FilePath`

#### Summary

The file name and path for the exported file.

#### Remarks

If ExportRange is SetOfViews, the name of each view or sheet will be
appended to the name provided for each exported file.
This field is ignored if used to save an image to a project as a new view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input file path is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.ImageExportOptions.ViewName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageExportOptions.ViewName`

#### Summary

The name of the view to be created.

#### Remarks

This field is used only to save an image to a project as a new view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.ImageExportOptions.FitDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageExportOptions.FitDirection`

#### Summary

The fit direction. Used only if ZoomType is FitToPage.

#### Remarks

The default is Horizontal.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.ImageExportOptions.HLRandWFViewsFileType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageExportOptions.HLRandWFViewsFileType`

#### Summary

File type for exported HLR and wireframe views.

#### Remarks

The default is JPEGMedium.
This field is ignored if used to save an image to a project as a new view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.ImageExportOptions.ShadowViewsFileType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageExportOptions.ShadowViewsFileType`

#### Summary

The file type for exported shadow views.

#### Remarks

The default is JPEGMedium.
This field is ignored if used to save an image to a project as a new view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.ImageExportOptions.ImageResolution`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageExportOptions.ImageResolution`

#### Summary

The image resolution in dots per inch.

#### Remarks

The default is DPI_72.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.ImageExportOptions.PixelSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageExportOptions.PixelSize`

#### Summary

The pixel size of an image in one direction. Used only if ZoomType is FitToPage.

#### Remarks

The default is 512 pixels.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The PixelSize value is outside the permitted range.

#### Since

2011

### `P:Autodesk.Revit.DB.ImageExportOptions.Zoom`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageExportOptions.Zoom`

#### Summary

The value for Zoom (as a percentage). Used only when ZoomType is Zoom.

#### Remarks

The default is 50.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The Zoom value is outside the permitted range.

#### Since

2011

### `P:Autodesk.Revit.DB.ImageExportOptions.ZoomType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageExportOptions.ZoomType`

#### Summary

The zoom type, which defines how the image size is determined.

#### Remarks

The default is FitToPage.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.ImageExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageExportOptions.#ctor`

#### Summary

Constructs a new instance of the options class used to produce images.

#### Since

2011

### `T:Autodesk.Revit.DB.ImageExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImageExportOptions`

#### Summary

This class defines options for exporting views and sheets as an image.

#### Since

2011

### `T:Autodesk.Revit.DB.ImageResolution`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImageResolution`

#### Summary

This enum is used to define image resolution in order to calculate the image size.

#### Remarks

This is used only if the Zoom option for ZoomType is set.

#### Since

2011

### `F:Autodesk.Revit.DB.ImageResolution.DPI_600`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageResolution.DPI_600`

#### Summary

600 dpi

### `F:Autodesk.Revit.DB.ImageResolution.DPI_300`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageResolution.DPI_300`

#### Summary

300 dpi

### `F:Autodesk.Revit.DB.ImageResolution.DPI_150`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageResolution.DPI_150`

#### Summary

150 dpi

### `F:Autodesk.Revit.DB.ImageResolution.DPI_72`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageResolution.DPI_72`

#### Summary

72 dpi

### `T:Autodesk.Revit.DB.ZoomFitType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ZoomFitType`

#### Summary

This enum is used to define type of zoom.

#### Since

2011

### `F:Autodesk.Revit.DB.ZoomFitType.Zoom`

Member kind: field
Symbol: `Autodesk.Revit.DB.ZoomFitType.Zoom`

#### Summary

Calculate the size of the image using physical size of the view, zoom value and resolution.

### `F:Autodesk.Revit.DB.ZoomFitType.FitToPage`

Member kind: field
Symbol: `Autodesk.Revit.DB.ZoomFitType.FitToPage`

#### Summary

Fit the whole view into a specific image size.

### `T:Autodesk.Revit.DB.FitDirectionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.FitDirectionType`

#### Summary

This enum is used to define the direction to fit the number of pixels defined by PixelSize.

#### Since

2011

### `F:Autodesk.Revit.DB.FitDirectionType.Vertical`

Member kind: field
Symbol: `Autodesk.Revit.DB.FitDirectionType.Vertical`

#### Summary

Fit a specific number of pixels in vertical direction.

### `F:Autodesk.Revit.DB.FitDirectionType.Horizontal`

Member kind: field
Symbol: `Autodesk.Revit.DB.FitDirectionType.Horizontal`

#### Summary

Fit a specific number of pixels in horizontal direction.

### `T:Autodesk.Revit.DB.ImageFileType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImageFileType`

#### Summary

This enum is used to define exported file type.

#### Since

2011

### `F:Autodesk.Revit.DB.ImageFileType.TIFF`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageFileType.TIFF`

#### Summary

TIFF

### `F:Autodesk.Revit.DB.ImageFileType.TARGA`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageFileType.TARGA`

#### Summary

TARGA

### `F:Autodesk.Revit.DB.ImageFileType.PNG`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageFileType.PNG`

#### Summary

PNG

### `F:Autodesk.Revit.DB.ImageFileType.JPEGSmallest`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageFileType.JPEGSmallest`

#### Summary

JPEG with lower quality picture and small file size

### `F:Autodesk.Revit.DB.ImageFileType.JPEGMedium`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageFileType.JPEGMedium`

#### Summary

JPEG with medium quality picture

### `F:Autodesk.Revit.DB.ImageFileType.JPEGLossless`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageFileType.JPEGLossless`

#### Summary

JPEG with high quality picture

### `F:Autodesk.Revit.DB.ImageFileType.BMP`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageFileType.BMP`

#### Summary

BMP

### `M:Autodesk.Revit.DB.ITransientElementMakerProxy.Execute`

Member kind: method
Symbol: `Autodesk.Revit.DB.ITransientElementMakerProxy.Execute`

#### Summary

Implement this method to create transient elements.

#### Since

2016

### `M:Autodesk.Revit.DB.ITransientElementMaker.Execute`

Member kind: method
Symbol: `Autodesk.Revit.DB.ITransientElementMaker.Execute`

#### Summary

Implement this method to create transient elements.

#### Since

2016

### `T:Autodesk.Revit.DB.ITransientElementMaker`

Member kind: type
Symbol: `Autodesk.Revit.DB.ITransientElementMaker`

#### Summary

The interface to be implemented by an application that creates transient element(s) in Revit.

#### Remarks

An instance of the implemented interface is passed as an argument to the Document.MakeTransientElements() method, which will call back the Execute method of the interface.

During the execution of the method Revit will allow creation of certain elements, such as DirectShape, and will make them automatically transient . See ( `P:Autodesk.Revit.DB.Element.IsTransient` for more details about transient elements.)

The code within the Execute method is not allowed to modify the model in any other way. An attempt to change the model or create elements of other kinds will result in an exception. This indirectly means that methods using a transaction internally are not allowed either. Such methods include document Save and SaveAs, certain import and export methods, creating links, syncing with central, etc.

Regenerating the model is also not allowed for the entire duration of the Execute method.

This interface is passed to `M:Autodesk.Revit.DB.Document.MakeTransientElements(Autodesk.Revit.DB.ITransientElementMaker)` which does the actual transient element creation.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.IStructuralSectionsServerProxy.StructuralSectionsUpdate(Autodesk.Revit.DB.Structure.StructuralSectionsServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IStructuralSectionsServerProxy.StructuralSectionsUpdate(Autodesk.Revit.DB.Structure.StructuralSectionsServiceData)`

#### Summary

The server's method that will be called when Revit User clicks the Section Type parameter's button in the family dialog.

#### Remarks

The server provides UI way for Revit user to view and modify the detail data corresponding with the parameter value.
The server may also modify the section type parameter value itself during the execution.
The method should always return 'true' if the server is successfully executed, no matter whether the server changes anything.
Return 'false' or if the server throws, indicates a failed case, all changes made by the server will be discarded.

#### Parameter `data`

The Section Type data.

#### Returns

Indicates whether the section type parameter server is executed successfully.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.IStructuralSectionsServer.StructuralSectionsUpdate(Autodesk.Revit.DB.Structure.StructuralSectionsServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IStructuralSectionsServer.StructuralSectionsUpdate(Autodesk.Revit.DB.Structure.StructuralSectionsServiceData)`

#### Summary

The server's method that will be called when Revit User clicks the Section Type parameter's button in the family dialog.

#### Remarks

The server provides UI way for Revit user to view and modify the detail data corresponding with the parameter value.
The server may also modify the section type parameter value itself during the execution.
The method should always return 'true' if the server is successfully executed, no matter whether the server changes anything.
Return 'false' or if the server throws, indicates a failed case, all changes made by the server will be discarded.

#### Parameter `data`

The Section Type data.

#### Returns

Indicates whether the section type parameter server is executed successfully.

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.IStructuralSectionsServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.IStructuralSectionsServer`

#### Summary

Interface for the section type parameter server to implement.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.IRebarUpdateServerProxy.GetHandlesPosition(Autodesk.Revit.DB.Structure.RebarHandlePositionData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IRebarUpdateServerProxy.GetHandlesPosition(Autodesk.Revit.DB.Structure.RebarHandlePositionData)`

#### Summary

This function is supposed to provide the positions of handles defined in GetCustomHandles(). These positions will be shown on screen when the bar constraints are edited.
If a position for a handle isn't provided, that handle will not be represented on screen while edit constraints.

This function is called when edit constraints command is lunched or during edit constraints after a constraint was changed and the curve calculation was done.

#### Parameter `handlePositionData`

Use the members of this class to access the inputs and define the handle positions for this free form rebar.

#### Returns

Returns true if calculation of handle positions was successful, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.IRebarUpdateServerProxy.TrimExtendCurves(Autodesk.Revit.DB.Structure.RebarTrimExtendData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IRebarUpdateServerProxy.TrimExtendCurves(Autodesk.Revit.DB.Structure.RebarTrimExtendData)`

#### Summary

This function is supposed to trim or extend curves that were obtained from calling GenerateCurves(). Also in this function can be set new constraints for start and end handles.

#### Remarks

This function is called in the regeneration context when at least one data in trimExtendData parameter was changed. It is called immediately after GenerateCurves() and only if GenerateCurves() returns true.

If new constraints were created for start or end handle, a new regeneration will take place and the new constraints will become the rebar's actual constraints.

If new curves will be added by calling TrimExtendData.AddBarGeometry(), the existing curves in Rebar element will be replaced with these curves. It will not add curves to the existing ones.

#### Parameter `trimExtendData`

Use the members of this class to access the inputs and define any trim/extend actions to be taken for bars in the free form rebar.

#### Returns

Returns true if the trim/extend was successful, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.IRebarUpdateServerProxy.GenerateCurves(Autodesk.Revit.DB.Structure.RebarCurvesData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IRebarUpdateServerProxy.GenerateCurves(Autodesk.Revit.DB.Structure.RebarCurvesData)`

#### Summary

This function is supposed to calculate the bars in set based on data received in curvesData parameter.

#### Remarks

This function is called in the regeneration context when at least one data in curvesData parameter was changed.

#### Parameter `curvesData`

Use the members of this class to access the inputs and define the output curves that make up the free form rebar.

#### Returns

Returns true if the curve generation was successful, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.IRebarUpdateServerProxy.GetCustomHandleName(Autodesk.Revit.DB.Structure.RebarHandleNameData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IRebarUpdateServerProxy.GetCustomHandleName(Autodesk.Revit.DB.Structure.RebarHandleNameData)`

#### Summary

This function should return the name of the handle.

#### Remarks

This function is called during edit constraints command when the mouse is over a handle or the funtion RebarConstrainedHandle.GetCustomHandleName() is called.

#### Parameter `handleNameData`

The class used to output the rebarHandle name.

#### Returns

Returns true if the handle name is defined successfully, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.IRebarUpdateServerProxy.GetCustomHandles(Autodesk.Revit.DB.Structure.RebarHandlesData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IRebarUpdateServerProxy.GetCustomHandles(Autodesk.Revit.DB.Structure.RebarHandlesData)`

#### Summary

This function should define all handles that the Rebar has. This function is called when the Rebar is created.

#### Remarks

Revit consider the execution failed if we have duplicate tags for custom, start and end handles.

#### Parameter `handlesInfoData`

Use the methods on this class to define the handles for the free form rebar. Revit will use these handles to create appropriate RebarConstraints.

#### Returns

Returns true if the handles were defined successfully, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.IRebarUpdateServer.GetHandlesPosition(Autodesk.Revit.DB.Structure.RebarHandlePositionData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IRebarUpdateServer.GetHandlesPosition(Autodesk.Revit.DB.Structure.RebarHandlePositionData)`

#### Summary

This function is supposed to provide the positions of handles defined in GetCustomHandles(). These positions will be shown on screen when the bar constraints are edited.
If a position for a handle isn't provided, that handle will not be represented on screen while edit constraints.

This function is called when edit constraints command is lunched or during edit constraints after a constraint was changed and the curve calculation was done.

#### Parameter `handlePositionData`

Use the members of this class to access the inputs and define the handle positions for this free form rebar.

#### Returns

Returns true if calculation of handle positions was successful, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.IRebarUpdateServer.TrimExtendCurves(Autodesk.Revit.DB.Structure.RebarTrimExtendData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IRebarUpdateServer.TrimExtendCurves(Autodesk.Revit.DB.Structure.RebarTrimExtendData)`

#### Summary

This function is supposed to trim or extend curves that were obtained from calling GenerateCurves(). Also in this function can be set new constraints for start and end handles.

#### Remarks

This function is called in the regeneration context when at least one data in trimExtendData parameter was changed. It is called immediately after GenerateCurves() and only if GenerateCurves() returns true.

If new constraints were created for start or end handle, a new regeneration will take place and the new constraints will become the rebar's actual constraints.

If new curves will be added by calling TrimExtendData.AddBarGeometry(), the existing curves in Rebar element will be replaced with these curves. It will not add curves to the existing ones.

#### Parameter `trimExtendData`

Use the members of this class to access the inputs and define any trim/extend actions to be taken for bars in the free form rebar.

#### Returns

Returns true if the trim/extend was successful, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.IRebarUpdateServer.GenerateCurves(Autodesk.Revit.DB.Structure.RebarCurvesData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IRebarUpdateServer.GenerateCurves(Autodesk.Revit.DB.Structure.RebarCurvesData)`

#### Summary

This function is supposed to calculate the bars in set based on data received in curvesData parameter.

#### Remarks

This function is called in the regeneration context when at least one data in curvesData parameter was changed.

#### Parameter `curvesData`

Use the members of this class to access the inputs and define the output curves that make up the free form rebar.

#### Returns

Returns true if the curve generation was successful, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.IRebarUpdateServer.GetCustomHandleName(Autodesk.Revit.DB.Structure.RebarHandleNameData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IRebarUpdateServer.GetCustomHandleName(Autodesk.Revit.DB.Structure.RebarHandleNameData)`

#### Summary

This function should return the name of the handle.

#### Remarks

This function is called during edit constraints command when the mouse is over a handle or the funtion RebarConstrainedHandle.GetCustomHandleName() is called.

#### Parameter `handleNameData`

The class used to output the rebarHandle name.

#### Returns

Returns true if the handle name is defined successfully, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.IRebarUpdateServer.GetCustomHandles(Autodesk.Revit.DB.Structure.RebarHandlesData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IRebarUpdateServer.GetCustomHandles(Autodesk.Revit.DB.Structure.RebarHandlesData)`

#### Summary

This function should define all handles that the Rebar has. This function is called when the Rebar is created.

#### Remarks

Revit consider the execution failed if we have duplicate tags for custom, start and end handles.

#### Parameter `handlesInfoData`

Use the methods on this class to define the handles for the free form rebar. Revit will use these handles to create appropriate RebarConstraints.

#### Returns

Returns true if the handles were defined successfully, false otherwise.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.IRebarUpdateServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.IRebarUpdateServer`

#### Summary

Represents an interface that should be overridden to allow the generation and update of free form rebar geometry.

#### Remarks

This interface should be overridden in order to create a free form rebar with constraints and to allow generation and update of its geometry.

Once a rebar is created with a server, it will be called `M:Autodesk.Revit.DB.Structure.IRebarUpdateServer.GetCustomHandles(Autodesk.Revit.DB.Structure.RebarHandlesData)` function. In the execution on this function should be defined the handles of the rebar.

Based on these handles rebar constraints can be defined. Once the constraints are defined a regeneration should be triggered in order to generate the bar geometry.

During the regeneration the functions `M:Autodesk.Revit.DB.Structure.IRebarUpdateServer.GenerateCurves(Autodesk.Revit.DB.Structure.RebarCurvesData)` and `M:Autodesk.Revit.DB.Structure.IRebarUpdateServer.TrimExtendCurves(Autodesk.Revit.DB.Structure.RebarTrimExtendData)` will be called.
For GenerateCurves() it is supposed to calculate bars in set based on constraints.
For TrimExtendCurves() it is supposed to trim or extend curves that were obtained from GenerateCurves(). Also in this function new constraints
for start and end bar handles can be created.
After the execution of these two functions the bar should appear on screen.

Every time when a constraint is modified a new regeneration is triggered and the functions GenerateCurves() and TrimExtendCurves() are called again.

We also can edit constraints for this rebar. When user starts to do this, the function `M:Autodesk.Revit.DB.Structure.IRebarUpdateServer.GetHandlesPosition(Autodesk.Revit.DB.Structure.RebarHandlePositionData)` will be called
and it is supposed to return positions of handles defined in GetCustomHandles(). This positions will be shown on screen.
While editing constraints if the mouse is over a position that was specified, the function `M:Autodesk.Revit.DB.Structure.IRebarUpdateServer.GetCustomHandleName(Autodesk.Revit.DB.Structure.RebarHandleNameData)`
will be called in order to obtain the name of that handle.

While editing constraints an user will modify constraints (e.g. add a new reference or remove one) a regeneration will be triggered
and the functions GenerateCurves() and TrimExtendCurves() will be called again.

#### Since

2018

### `M:Autodesk.Revit.DB.PointClouds.PointCloudFilter.Clone`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudFilter.Clone`

#### Summary

Returns a copy of the filter. The engine is permitted to copy the filter multiple times e.g. to parallelize filtering.

#### Returns

A copy of the original filter.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointCloudFilter.PrepareForCell(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudFilter.PrepareForCell(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Int32)`

#### Summary

Informs the filter that a series of points within a given cell is about to be checked.

#### Remarks

This is a performance hook that the filter can use to minimize computational work per TestPoint() call
within a given cell.
The engine should guarantee that all points passed to TestPoint() calls
will fall inside the (min, max) box specified here. This promise must be in effect until
the next PrepareForCell() call.

#### Parameter `min`

The lower corner of the cell.

#### Parameter `max`

The upper corner of the cell.

#### Parameter `numTests`

The engine's estimate of the number of TestPoint() calls it is going to make for this cell.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointCloudFilter.TestCell(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudFilter.TestCell(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Checks whether a given cell, i.e. a box aligned with the XYZ axes, is inside, outside
or on the border of the volume of interest.

#### Parameter `min`

The lower corner of the cell.

#### Parameter `max`

The upper corner of the cell.

#### Returns

-1 -- The cell is entirely rejected.

0 -- The cell partially belongs to the volume of interest. Use PrepareForCell() and TestPoint() to
evaluate individual points.

1 -- The cell is fully accepted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.PointClouds.PointCloudFilter.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudFilter.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.PointClouds.PointCloudFilter.TestPoint(Autodesk.Revit.DB.PointClouds.CloudPoint)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudFilter.TestPoint(Autodesk.Revit.DB.PointClouds.CloudPoint)`

#### Summary

Checks if a point is inside the volume of interest.

#### Parameter `point`

The point to be tested.

#### Returns

If true, the point is accepted, if false, the point is not accepted.

### `T:Autodesk.Revit.DB.PointClouds.PointCloudFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudFilter`

#### Summary

A class used to describe the criteria an application desires when obtaining members of a point cloud.

#### Remarks

Client applications which wish to obtain points from a point cloud will have to create a
PointCloudFilter to define the volume of interest (see PointCloudFilterFactory).
Engine implementations will need to use the methods contained within the point cloud to determine
which points to return to Revit.

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.KLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.KLevel`

#### Summary

The system calculation level.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.CategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.CategoryId`

#### Summary

The category id of pipe curves. It will be OST_PipeCurves, OST_FlexPipeCurves, or OST_PlaceHolderPipes.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.Viscosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.Viscosity`

#### Summary

The viscosity of the pipe. Units: (kg/(ftÂ·s)).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.Density`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.Density`

#### Summary

The density of the pipe. Units: (kg/ftÂ³).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.NominalDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.NominalDiameter`

#### Summary

The nominal diameter of the pipe. Units: (ft).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.OutsideDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.OutsideDiameter`

#### Summary

The outside diameter of the pipe. Units: (ft).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.InsideDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.InsideDiameter`

#### Summary

The inside diameter of the pipe. Units: (ft).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.Flow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.Flow`

#### Summary

The flow of the pipe. Units: (ftÂ³/s).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.Length`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.Length`

#### Summary

The length of the pipe. Units: (ft).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.Roughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.Roughness`

#### Summary

The roughness of the pipe. Units: (ft).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.PressureDrop`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.PressureDrop`

#### Summary

The pressure drop of the pipe. Units: (kg/(ftÂ·sÂ²)).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.Coefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.Coefficient`

#### Summary

The coefficient of the pipe.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.VelocityPressure`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.VelocityPressure`

#### Summary

The velocity pressure of the pipe. Units: (kg/(ftÂ·sÂ²))

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.Velocity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.Velocity`

#### Summary

The velocity of the pipe. Units: (ft/s) .

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.FrictionFactor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.FrictionFactor`

#### Summary

The friction factor of the pipe.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.Friction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.Friction`

#### Summary

The friction of the pipe. Units: (kg/(ftÂ²Â·sÂ²)).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.FlowState`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.FlowState`

#### Summary

The flowState of the pipe.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.ReynoldsNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.ReynoldsNumber`

#### Summary

The reynolds number of the pipe.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePressureDropData.RelativeRoughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData.RelativeRoughness`

#### Summary

The relative roughness of the pipe.

#### Since

2014

### `T:Autodesk.Revit.DB.Plumbing.PipePressureDropData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipePressureDropData`

#### Summary

The input and output data used by external servers for calculation of the pipe pressure drop.

#### Remarks

Roughness, Length, Flow, Diameter, Density, and Viscosity field values are input data for the calculation. ReynoldsNumber, FlowStatus, Friction, FrictionFactor, Velocity, Coefficient, and PressureDrop are output values.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipePressureDropServerProxy.GetHtmlDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePressureDropServerProxy.GetHtmlDescription`

#### Summary

The method that Revit will invoke to get an HTML formatted description of the server.

#### Remarks

The HTML description is used by Revit unless it is empty or the server is not available, in which case, Revit will use the plain text description from IExternalServer.GetDescription().

#### Returns

The HTML format description of the server.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipePressureDropServerProxy.GetInformationLink`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePressureDropServerProxy.GetInformationLink`

#### Summary

The method that Revit will invoke to obtain a URL address which provides more information about the server.

#### Returns

The URL providing server information.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipePressureDropServerProxy.Calculate(Autodesk.Revit.DB.Plumbing.PipePressureDropData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePressureDropServerProxy.Calculate(Autodesk.Revit.DB.Plumbing.PipePressureDropData)`

#### Summary

Calculate the pipe pressure drop.

#### Parameter `data`

The input and output data of the calculation.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipePressureDropServer.GetHtmlDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePressureDropServer.GetHtmlDescription`

#### Summary

The method that Revit will invoke to get an HTML formatted description of the server.

#### Remarks

The HTML description is used by Revit unless it is empty or the server is not available, in which case, Revit will use the plain text description from IExternalServer.GetDescription().

#### Returns

The HTML format description of the server.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipePressureDropServer.GetInformationLink`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePressureDropServer.GetInformationLink`

#### Summary

The method that Revit will invoke to obtain a URL address which provides more information about the server.

#### Returns

The URL providing server information.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipePressureDropServer.Calculate(Autodesk.Revit.DB.Plumbing.PipePressureDropData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePressureDropServer.Calculate(Autodesk.Revit.DB.Plumbing.PipePressureDropData)`

#### Summary

Calculate the pipe pressure drop.

#### Parameter `data`

The input and output data of the calculation.

#### Since

2014

### `T:Autodesk.Revit.DB.Plumbing.IPipePressureDropServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePressureDropServer`

#### Summary

Interface for external servers implementing pipe pressure drop calculation.

#### Remarks

A typical way to use the external server can be:
Implement a server class that derives from this interface

Create a new server object and register it with the service, see `!:Autodesk.Revit.DB.ExternalService.ExternalServiceRegistry` .

Assign server for the pipe pressure drop calculation in `!:Autodesk.Revit.DB.Plumbing.PipeSettings` .

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData.DimensionFlow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData.DimensionFlow`

#### Summary

The dimension flow which is used to calculate flow of the pipe. Units: (gal/min).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData.FlowConversionMode`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData.FlowConversionMode`

#### Summary

The flow conversion mode of the pipe.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData.FixtureUnits`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData.FixtureUnits`

#### Summary

The fixture units of the pipe.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData.FlowConfiguration`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData.FlowConfiguration`

#### Summary

The flow configuration mode of the pipe.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData.Flow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData.Flow`

#### Summary

The actual flow of the plumbing fixture converted from dimension flow or fixture unit. Units: (gal/min).

#### Since

2014

### `T:Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData`

#### Summary

The input and output data used by external servers for calculation of the pipe plumbing fixture flow.

#### Remarks

FlowConfiguration, FixtureUnits, FlowConversionMode, and DimensionFlow are input field values for the calculation. Flow is output field value for the calculation.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServerProxy.GetHtmlDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServerProxy.GetHtmlDescription`

#### Summary

The method that Revit will invoke to get an HTML formatted description of the server.

#### Remarks

The HTML description is used by Revit unless it is empty or the server is not available, in which case, Revit will use the plain text description from IExternalServer.GetDescription().

#### Returns

The HTML format description of the server.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServerProxy.GetInformationLink`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServerProxy.GetInformationLink`

#### Summary

The method that Revit will invoke to obtain a URL address which provides more information about the server.

#### Returns

The URL providing server information.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServerProxy.Calculate(Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServerProxy.Calculate(Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData)`

#### Summary

Calculate the pipe plumbing fixture flow.

#### Parameter `data`

The input and output data of the calculation.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServer.GetHtmlDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServer.GetHtmlDescription`

#### Summary

The method that Revit will invoke to get an HTML formatted description of the server.

#### Remarks

The HTML description is used by Revit unless it is empty or the server is not available, in which case, Revit will use the plain text description from IExternalServer.GetDescription().

#### Returns

The HTML format description of the server.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServer.GetInformationLink`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServer.GetInformationLink`

#### Summary

The method that Revit will invoke to obtain a URL address which provides more information about the server.

#### Returns

The URL providing server information.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServer.Calculate(Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServer.Calculate(Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData)`

#### Summary

Calculate the pipe plumbing fixture flow.

#### Parameter `data`

The input and output data of the calculation.

#### Since

2014

### `T:Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServer`

#### Summary

Interface class for external servers implementing Pipe plumbing fixture flow calculation.

#### Remarks

A typical way to use the external server can be:
Implement a server class that derives from this interface

Create a new server object and register it with the service, see `!:Autodesk.Revit.DB.ExternalService.ExternalServiceRegistry` .

Assign server for the plumbing flow conversion in `!:Autodesk.Revit.DB.Plumbing.PipeSettings` .

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData.SetDefaultEntity(Autodesk.Revit.DB.ExtensibleStorage.Entity)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData.SetDefaultEntity(Autodesk.Revit.DB.ExtensibleStorage.Entity)`

#### Summary

Stores the default entity in the data.

#### Parameter `defaultEntity`

The Entity to be stored.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Writing of Entities of this Schema is not allowed to the current add-in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData.GetPresureDropItems`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData.GetPresureDropItems`

#### Summary

Returns the pressure drop items

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData.GetPipeFittingAndAccessoryData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData.GetPipeFittingAndAccessoryData`

#### Summary

Returns the fitting and accessory information

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData.IsCurrentEntityValid`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData.IsCurrentEntityValid`

#### Summary

True if the current settings stored in the entity is valid.

#### Since

2017

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData.CalculationType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData.CalculationType`

#### Summary

The calculation type, a bitmask of FittingAndAccessoryCalculationType.

#### Since

2014

### `T:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData`

#### Summary

The input and output data used by external servers for calculation of the pipe fitting and pipe accessory pressure drop.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropItem.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropItem.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropItem.Coefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropItem.Coefficient`

#### Summary

The coefficient between the begin connector and end connector, Units: (kg/(ftÂ·sÂ²)).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropItem.VelocityPressure`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropItem.VelocityPressure`

#### Summary

The velocity pressure, for converting between coefficient and pressure drop on this flow path. Units: (kg/(ftÂ·sÂ²)).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropItem.EndConnectorIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropItem.EndConnectorIndex`

#### Summary

The index of the end conector of the flow path

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropItem.BeginConnectorIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropItem.BeginConnectorIndex`

#### Summary

The index of the begin connector of the flow path

#### Since

2014

### `T:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropItem`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropItem`

#### Summary

A flow path of the pipe/pipe fitting and accessory. It is defined by the begin connector and end connector

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServerProxy.GetDataSchema`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServerProxy.GetDataSchema`

#### Summary

Obtains the schema of the ESEntity.

#### Returns

Null if the server has no data.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServerProxy.IsApplicable(Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServerProxy.IsApplicable(Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData)`

#### Summary

Check if the server is applicable for the pipe fitting or pipe accessory.

#### Parameter `data`

The input data of the calculation.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServerProxy.Calculate(Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServerProxy.Calculate(Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData)`

#### Summary

Calculate the pipe fitting and pipe accessory coefficient.

#### Parameter `data`

The input and output data of the calculation.

#### Returns

True if calculation succeeds.
False if calculation fails.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServer.GetDataSchema`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServer.GetDataSchema`

#### Summary

Obtains the schema of the ESEntity.

#### Returns

Null if the server has no data.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServer.IsApplicable(Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServer.IsApplicable(Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData)`

#### Summary

Check if the server is applicable for the pipe fitting or pipe accessory.

#### Parameter `data`

The input data of the calculation.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServer.Calculate(Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServer.Calculate(Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData)`

#### Summary

Calculate the pipe fitting and pipe accessory coefficient.

#### Parameter `data`

The input and output data of the calculation.

#### Returns

True if calculation succeeds.
False if calculation fails.

#### Since

2014

### `T:Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServer`

#### Summary

Interface class for external servers implementing pipe fitting and pipe accessory coefficient calculation.

#### Remarks

A typical way to use the external server can be:
Implement a server class that derives from this interface

Create a new server object and register it with the service, see `!:Autodesk.Revit.DB.ExternalService.ExternalServiceRegistry` .

Assign server to pipe fitting instance.

#### Since

2014

### `M:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.SetStatus(System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.SetStatus(System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus})`

#### Summary

Sets the result status of the calculation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.GetStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.GetStatus`

#### Summary

Returns array of result statuses for the paths.

#### Returns

Resulting array of end points.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.GetPathOfTravelPoints`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.GetPathOfTravelPoints`

#### Summary

Retrieves the source or calculated points passed between Revit and calculation server.

#### Remarks

Source points are start and end points plus all possible waypoints between them.
Calculated points are actual points of the PathOfTravel that are displayed in the view.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.SetPathOfTravelPoints(System.Collections.Generic.IList{System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ}})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.SetPathOfTravelPoints(System.Collections.Generic.IList{System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ}})`

#### Summary

Sets the source or calculated points passed between Revit and calculation server.

#### Remarks

Source points are start and end points plus all possible waypoints between them.
Calculated points are actual points of the PathOfTravel that are displayed in the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.SetEndPoints(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.SetEndPoints(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.GetEndPoints`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.GetEndPoints`

#### Summary

Returns array of the end points for the paths.

#### Returns

Resulting array of end points.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.SetStartPoints(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.SetStartPoints(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.GetStartPoints`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.GetStartPoints`

#### Summary

Returns array of the start points for the paths.

#### Returns

Resulting array of start points.

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.TemporaryMode`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.TemporaryMode`

#### Summary

True if temporary mode is ON for the view, false otherwise.

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.OutlineArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.OutlineArea`

#### Summary

Area of the view outline.

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.LineCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.LineCount`

#### Summary

Number of lines in the view.

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.Request`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.Request`

#### Summary

The request type for the calculation.

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.View`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.View`

#### Summary

Gets the View which the path of travel is being calculated for.
Sets the View which the path of travel is being calculated for.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData.#ctor`

#### Summary

Initializes PathOfTravelCalculationServiceData to a default, unusable state; Revit needs to make it usable
before passing it to the IPathOfTravelCalculationServer instance.

#### Since

2020

### `T:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData`

#### Summary

This is a container for data and some functions which is passed from Revit to an instance of
IPathOfCalculationServer.

#### Since

2020

### `T:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus`

#### Summary

An enumerated type containing possible results of the Path of Travel calculation.

#### Since

2020

#### Since

2020

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.TemporaryModeFailureWireframe`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.TemporaryModeFailureWireframe`

#### Summary

Temporary mode cannot be set for the view because wireframe display style is set for the view.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.TemporaryModeFailureDataExist`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.TemporaryModeFailureDataExist`

#### Summary

Temporary mode cannot be set for the view because analysis data exist in the view.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.RevealObstaclesModeFailureWireframe`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.RevealObstaclesModeFailureWireframe`

#### Summary

Reveal Obstacles mode cannot be set for the view because wireframe display style is set for the view.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.RevealObstaclesModeFailureDataExist`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.RevealObstaclesModeFailureDataExist`

#### Summary

Reveal Obstacles mode cannot be set for the view because analysis data exist in the view.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.TooMuchGeometry`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.TooMuchGeometry`

#### Summary

The view is exporting too much geometry. Calculation of the path of travel cannot be performed.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.PointOutsideActiveCrop`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.PointOutsideActiveCrop`

#### Summary

Start or end point is outside the active view crop.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.StartAndEndPointsTooClose`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.StartAndEndPointsTooClose`

#### Summary

Distance between adjacent points of path of travel (start, end and way points) is less than the value of `!:Autodesk::Revit::DB::Analysis::RouteAnalysisSettings::MinimumLength` .

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.ResultAffectedByCrop`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.ResultAffectedByCrop`

#### Summary

The view has an active crop region set. If `!:Autodesk::Revit::DB::Analysis::PathOfTravel::GetCurveLoop` contains no points,
no path of travel was found inside the crop region, but a valid path may exist outside of it.
If `!:Autodesk::Revit::DB::Analysis::PathOfTravel::GetCurveLoop` contains valid points, a path of travel was found inside the
crop region, but a better option may exist outside of it.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.SplitView`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.SplitView`

#### Summary

The view is split. Calculation of the path of travel cannot be performed.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.AreaTooLarge`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.AreaTooLarge`

#### Summary

The view outline is too large. Calculation of the path of travel cannot be performed.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.NoPathOfTravel`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.NoPathOfTravel`

#### Summary

There is no valid path between the two points.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.Success`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus.Success`

#### Summary

A valid path of travel between the two points was found. Use `!:Autodesk::Revit::DB::Analysis::PathOfTravel::GetCurveLoop`
to retrieve the calculated points of path of travel.

### `T:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType`

#### Summary

An enumerated type containing possible requests for the Path of Travel calculation.

#### Since

2020

#### Since

2020

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.CalculateShortestPathsToMultipleDestinations`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.CalculateShortestPathsToMultipleDestinations`

#### Summary

Calculate paths from given start points to the closest of given destinations.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.SetDistanceMapModeInView`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.SetDistanceMapModeInView`

#### Summary

Sets distance map mode in the view.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.GetDistanceMapModeInView`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.GetDistanceMapModeInView`

#### Summary

Determine if distance map mode is on or off in the view.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.CalculateForPathsWithWaypoints`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.CalculateForPathsWithWaypoints`

#### Summary

Calculate paths of travel between corresponding pairs of start and end points with possible intermediate waypoints.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.UnlockCache`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.UnlockCache`

#### Summary

Allow changes to internal caches

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.LockCache`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.LockCache`

#### Summary

Lock changes to internal caches

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.SetRevealObstaclesModeInView`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.SetRevealObstaclesModeInView`

#### Summary

Sets reveal obstacles mode in the view.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.GetRevealObstaclesModeInView`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.GetRevealObstaclesModeInView`

#### Summary

Determine if reveal obstacles mode is on or off in the view.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.CalculateFarthestPointsToMultipleDestinations`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.CalculateFarthestPointsToMultipleDestinations`

#### Summary

Calculate points with farthest distance to the closest of given destinations.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.CalculateForAllPossibleStartEndPairs`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.CalculateForAllPossibleStartEndPairs`

#### Summary

Calculate paths of travel between all possible pairs of start and end points.

### `F:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.CalculateForCorrespondingStartEndPairs`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationRequestType.CalculateForCorrespondingStartEndPairs`

#### Summary

Calculate paths of travel between corresponding pairs of start and end points.

### `M:Autodesk.Revit.DB.Analysis.IPathOfTravelCalculationServerProxy.Calculate(Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.IPathOfTravelCalculationServerProxy.Calculate(Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData)`

#### Summary

Calculate the path of travel.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.IPathOfTravelCalculationServer.Calculate(Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.IPathOfTravelCalculationServer.Calculate(Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServiceData)`

#### Summary

Calculate the path of travel.

#### Since

2020

### `T:Autodesk.Revit.DB.Analysis.IPathOfTravelCalculationServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.IPathOfTravelCalculationServer`

#### Summary

Interface class for external servers implementing Path of travel calculations.

#### Remarks

A typical way to use the external server can be:
Implement a server class that derives from this interface

Create a new server object and register it with the service, see `!:Autodesk.Revit.DB.ExternalService.ExternalServiceRegistry` .

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServerIds.DefaultPathOfTravelCalculationGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServerIds.DefaultPathOfTravelCalculationGUID`

#### Summary

GUID to represent the default calculation server id.

#### Since

2020

### `T:Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServerIds`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServerIds`

#### Summary

Ids for external servers implementing path of travel calculations.

#### Since

2020

### `M:Autodesk.Revit.DB.IPDFParametersProviderProxy.OnPageSize(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.BoundingBoxUV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPDFParametersProviderProxy.OnPageSize(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.BoundingBoxUV)`

#### Summary

Receiving the PDF page size, in PDF user space coordinates, which is the same as the PDF media box size.

#### Parameter `viewId`

The ElementId of the view to be exported.

#### Parameter `mediaBox`

The PDF page size for the view to be exported, in PDF user space coordinates.

#### Since

2022

### `M:Autodesk.Revit.DB.IPDFParametersProviderProxy.ProvideParameter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPDFParametersProviderProxy.ProvideParameter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Transform)`

#### Summary

Provide Tag and Properties for a PDF container's Marked Content of a Revit view region.

#### Parameter `document`

The document which PDF exporter is exporting. And it should be the host document if there are links.

#### Parameter `viewId`

The view id which PDF exporter is processing.

#### Parameter `viewRegionIndex`

The index of the view region which PDF exporter is processing, starting from -1.

#### Parameter `viewportId`

The viewport of the view region.

#### Parameter `viewRegionTransform`

The "model to PDF page" transform of the view region.

#### Returns

The parameter to the PDF container of the Revit element.

#### Since

2022

### `M:Autodesk.Revit.DB.IPDFParametersProviderProxy.ProvideParameter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPDFParametersProviderProxy.ProvideParameter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Provide Tag and Properties for a PDF container's Marked Content of a Revit element.

#### Parameter `document`

The document which PDF exporter is exporting. And it should be the host document if there are links.

#### Parameter `elemId`

The ElementId of the element which PDF exporter is processing. It might be the ElementId of the linked document.

#### Parameter `linkInstanceId`

The ElementId of the link instance which the element belongs to, or invalidElementId when the element belongs to the host document.

#### Parameter `viewId`

The view id which the element belongs to.

#### Returns

The parameter to the PDF container of the Revit element.

#### Since

2022

### `M:Autodesk.Revit.DB.IPDFParametersProvider.OnPageSize(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.BoundingBoxUV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPDFParametersProvider.OnPageSize(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.BoundingBoxUV)`

#### Summary

Receiving the PDF page size, in PDF user space coordinates, which is the same as the PDF media box size.

#### Parameter `viewId`

The ElementId of the view to be exported.

#### Parameter `mediaBox`

The PDF page size for the view to be exported, in PDF user space coordinates.

#### Since

2022

### `M:Autodesk.Revit.DB.IPDFParametersProvider.ProvideParameter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPDFParametersProvider.ProvideParameter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Transform)`

#### Summary

Provide Tag and Properties for a PDF container's Marked Content of a Revit view region.

#### Parameter `document`

The document which PDF exporter is exporting. And it should be the host document if there are links.

#### Parameter `viewId`

The view id which PDF exporter is processing.

#### Parameter `viewRegionIndex`

The index of the view region which PDF exporter is processing, starting from -1.

#### Parameter `viewportId`

The viewport of the view region.

#### Parameter `viewRegionTransform`

The "model to PDF page" transform of the view region.

#### Returns

The parameter to the PDF container of the Revit element.

#### Since

2022

### `M:Autodesk.Revit.DB.IPDFParametersProvider.ProvideParameter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPDFParametersProvider.ProvideParameter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Provide Tag and Properties for a PDF container's Marked Content of a Revit element.

#### Parameter `document`

The document which PDF exporter is exporting. And it should be the host document if there are links.

#### Parameter `elemId`

The ElementId of the element which PDF exporter is processing. It might be the ElementId of the linked document.

#### Parameter `linkInstanceId`

The ElementId of the link instance which the element belongs to, or invalidElementId when the element belongs to the host document.

#### Parameter `viewId`

The view id which the element belongs to.

#### Returns

The parameter to the PDF container of the Revit element.

#### Since

2022

### `T:Autodesk.Revit.DB.IPDFParametersProvider`

Member kind: type
Symbol: `Autodesk.Revit.DB.IPDFParametersProvider`

#### Summary

Callback class providing parameters to be embedded into PDF for each Revit element.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFParameter.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFParameter.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.PDFParameter.Properties`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFParameter.Properties`

#### Summary

Properties of the parameter.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFParameter.Tag`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFParameter.Tag`

#### Summary

Name of the parameter.

#### Since

2022

### `M:Autodesk.Revit.DB.PDFParameter.#ctor(System.String,Autodesk.Revit.DB.PDFParameterDictionary)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PDFParameter.#ctor(System.String,Autodesk.Revit.DB.PDFParameterDictionary)`

#### Summary

Initialized a PDF parameter.

#### Parameter `tag`

Tag of the parameter.

#### Parameter `properties`

Properties of the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.PDFParameter`

Member kind: type
Symbol: `Autodesk.Revit.DB.PDFParameter`

#### Summary

Name-value pair in PDF that sets a container's Tag and Properties of its Marked Content.

#### Since

2022

### `M:Autodesk.Revit.DB.PDFParameterDictionary.SetValue(System.String,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PDFParameterDictionary.SetValue(System.String,Autodesk.Revit.DB.Transform)`

#### Summary

Set a transform property.

#### Parameter `key`

Key to the property.

#### Parameter `value`

Value to the property.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.PDFParameterDictionary.SetValue(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PDFParameterDictionary.SetValue(System.String,System.String)`

#### Summary

Set a string property.

#### Parameter `key`

Key to the property.

#### Parameter `value`

Value to the property.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.PDFParameterDictionary.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFParameterDictionary.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.PDFParameterDictionary.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PDFParameterDictionary.#ctor`

#### Summary

Initialize an empty dictionary.

#### Since

2022

### `T:Autodesk.Revit.DB.PDFParameterDictionary`

Member kind: type
Symbol: `Autodesk.Revit.DB.PDFParameterDictionary`

#### Summary

Dictionary in PDF that map string keys to a various types of values.

#### Since

2022

### `M:Autodesk.Revit.DB.NavisworksExportOptions.SetSelectedElementIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.SetSelectedElementIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets the element ids of the elements to export. Used only when ExportScope = SelectedElements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.NavisworksExportOptions.GetSelectedElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.GetSelectedElementIds`

#### Summary

Returns the element ids of the elements to export. Empty by default.

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.ConvertLinkedCADFormats`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.ConvertLinkedCADFormats`

#### Summary

True to convert linked CAD formats, false otherwise.
Default value is true.

#### Since

2020

### `P:Autodesk.Revit.DB.NavisworksExportOptions.ConvertLights`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.ConvertLights`

#### Summary

True to convert lights, false otherwise.
Default value is false.

#### Since

2020

### `P:Autodesk.Revit.DB.NavisworksExportOptions.FacetingFactor`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.FacetingFactor`

#### Summary

Faceting factor.
Default value is 1.0.

#### Since

2020

### `P:Autodesk.Revit.DB.NavisworksExportOptions.DivideFileIntoLevels`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.DivideFileIntoLevels`

#### Summary

True to divide file into levels, false otherwise.
Default value is true.

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.ConvertElementProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.ConvertElementProperties`

#### Summary

True to convert element properties, false otherwise.
Default value is false.

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.FindMissingMaterials`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.FindMissingMaterials`

#### Summary

True if the file exporter looks for a match for the materials missing from the export, false otherwise.
Default value is true.

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.ExportRoomGeometry`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.ExportRoomGeometry`

#### Summary

True to export Revit room geometry, false otherwise.
Default value is true.

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.ViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.ViewId`

#### Summary

The element id of the view to export. InvalidElementId by default. Used only when ExportScope = View.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.ExportScope`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.ExportScope`

#### Summary

Options which specifies the export scope of Navisworks Exporter.
Default value is Model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.Coordinates`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.Coordinates`

#### Summary

Options which specifies the coordinates of Navisworks Exporter.
Default value is Shared.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.ExportUrls`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.ExportUrls`

#### Summary

True to export URL parameters, false otherwise.
Default value is true.

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.ExportRoomAsAttribute`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.ExportRoomAsAttribute`

#### Summary

True to export data for each room converts into a single shared room attribute, false otherwise.
Default value is true.

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.ExportLinks`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.ExportLinks`

#### Summary

True to export Revit links found in the main model, false to skip links.
Default value is false.

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.Parameters`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.Parameters`

#### Summary

Options which specifies the parameter conversion of Navisworks Exporter.
Default value is All.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.ExportElementIds`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.ExportElementIds`

#### Summary

True to export Revit element ids, false to skip these values.
Default value is true.

#### Since

2014

### `P:Autodesk.Revit.DB.NavisworksExportOptions.ExportParts`

Member kind: property
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.ExportParts`

#### Summary

True to export Revit part elements, false to export the original parent elements.
Default value is false.

#### Since

2014

### `M:Autodesk.Revit.DB.NavisworksExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions.#ctor`

#### Summary

Create an instance of Navisworks Export Options set with default values.

#### Since

2014

### `T:Autodesk.Revit.DB.NavisworksExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.NavisworksExportOptions`

#### Summary

Options which controls the Navisworks export.

#### Since

2014

### `T:Autodesk.Revit.DB.NavisworksExportScope`

Member kind: type
Symbol: `Autodesk.Revit.DB.NavisworksExportScope`

#### Since

2014

#### Summary

An enumerated type listing possible "Element Scopes" of Navisworks Exporter.

#### Since

2014

### `F:Autodesk.Revit.DB.NavisworksExportScope.SelectedElements`

Member kind: field
Symbol: `Autodesk.Revit.DB.NavisworksExportScope.SelectedElements`

#### Summary

Export the selected elements.

### `F:Autodesk.Revit.DB.NavisworksExportScope.View`

Member kind: field
Symbol: `Autodesk.Revit.DB.NavisworksExportScope.View`

#### Summary

Export the elements in a view.

### `F:Autodesk.Revit.DB.NavisworksExportScope.Model`

Member kind: field
Symbol: `Autodesk.Revit.DB.NavisworksExportScope.Model`

#### Summary

Export all elements in the document.

### `T:Autodesk.Revit.DB.NavisworksCoordinates`

Member kind: type
Symbol: `Autodesk.Revit.DB.NavisworksCoordinates`

#### Since

2014

#### Summary

An enumerated type listing possible Coordinates of Navisworks Exporter.

#### Since

2014

### `F:Autodesk.Revit.DB.NavisworksCoordinates.Shared`

Member kind: field
Symbol: `Autodesk.Revit.DB.NavisworksCoordinates.Shared`

#### Summary

Shared coordinates can be viewed and modified outside of Revit.

### `F:Autodesk.Revit.DB.NavisworksCoordinates.Internal`

Member kind: field
Symbol: `Autodesk.Revit.DB.NavisworksCoordinates.Internal`

#### Summary

Use Revit internal coordinates.

### `T:Autodesk.Revit.DB.NavisworksParameters`

Member kind: type
Symbol: `Autodesk.Revit.DB.NavisworksParameters`

#### Since

2014

#### Summary

An enumerated type listing possible "Parameter conversions" of Navisworks Exporter.

#### Since

2014

### `F:Autodesk.Revit.DB.NavisworksParameters.All`

Member kind: field
Symbol: `Autodesk.Revit.DB.NavisworksParameters.All`

#### Summary

The file exporter converts parameters for all found elements, including the referenced elements.
As a result, extra property tabs are available in Autodesk Navisworks.

### `F:Autodesk.Revit.DB.NavisworksParameters.Elements`

Member kind: field
Symbol: `Autodesk.Revit.DB.NavisworksParameters.Elements`

#### Summary

The file exporter converts parameters for all found elements.

### `F:Autodesk.Revit.DB.NavisworksParameters.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.NavisworksParameters.None`

#### Summary

The file exporter does not convert parameters.

### `M:Autodesk.Revit.DB.INavisworksExporterProxy.ValidateExportOptions(Autodesk.Revit.DB.Document,System.String,System.String,Autodesk.Revit.DB.NavisworksExportOptions,System.String@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.INavisworksExporterProxy.ValidateExportOptions(Autodesk.Revit.DB.Document,System.String,System.String,Autodesk.Revit.DB.NavisworksExportOptions,System.String@)`

#### Summary

Determines if the inputs are valid, and returns an error message if not.

#### Parameter `document`

The document to export.

#### Parameter `folder`

The folder path.

#### Parameter `name`

The file name.

#### Parameter `options`

The export options.

#### Parameter `exceptionMessage`

The message to show in the exception thrown. This is not an end-user visible message, it is a
developer message, and does not have to be localized. Ignored if the function returns true.

#### Returns

True if the options are valid, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.INavisworksExporterProxy.Export(Autodesk.Revit.DB.Document,System.String,System.String,Autodesk.Revit.DB.NavisworksExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.INavisworksExporterProxy.Export(Autodesk.Revit.DB.Document,System.String,System.String,Autodesk.Revit.DB.NavisworksExportOptions)`

#### Summary

The method that Revit will invoke to perform an export to Navisworks.

#### Parameter `document`

The document to export.

#### Parameter `folder`

The folder path.

#### Parameter `name`

The file name.

#### Parameter `options`

The export options.

#### Since

2014

### `M:Autodesk.Revit.DB.INavisworksExporter.ValidateExportOptions(Autodesk.Revit.DB.Document,System.String,System.String,Autodesk.Revit.DB.NavisworksExportOptions,System.String@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.INavisworksExporter.ValidateExportOptions(Autodesk.Revit.DB.Document,System.String,System.String,Autodesk.Revit.DB.NavisworksExportOptions,System.String@)`

#### Summary

Determines if the inputs are valid, and returns an error message if not.

#### Parameter `document`

The document to export.

#### Parameter `folder`

The folder path.

#### Parameter `name`

The file name.

#### Parameter `options`

The export options.

#### Parameter `exceptionMessage`

The message to show in the exception thrown. This is not an end-user visible message, it is a
developer message, and does not have to be localized. Ignored if the function returns true.

#### Returns

True if the options are valid, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.INavisworksExporter.Export(Autodesk.Revit.DB.Document,System.String,System.String,Autodesk.Revit.DB.NavisworksExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.INavisworksExporter.Export(Autodesk.Revit.DB.Document,System.String,System.String,Autodesk.Revit.DB.NavisworksExportOptions)`

#### Summary

The method that Revit will invoke to perform an export to Navisworks.

#### Parameter `document`

The document to export.

#### Parameter `folder`

The folder path.

#### Parameter `name`

The file name.

#### Parameter `options`

The export options.

#### Since

2014

### `T:Autodesk.Revit.DB.INavisworksExporter`

Member kind: type
Symbol: `Autodesk.Revit.DB.INavisworksExporter`

#### Summary

The interface used to implement a Navisworks exporter.

#### Remarks

Implement this interface and register an instance of the derived class with the Navisworks external service.

#### Since

2014

### `M:Autodesk.Revit.DB.IModelAccessValidationServerProxy.IsAllowedToInitiate(System.String,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IModelAccessValidationServerProxy.IsAllowedToInitiate(System.String,System.Guid)`

#### Summary

Check if a project in the region is allowed to initiate a model.

#### Parameter `region`

The hub region to which a model would be saved.

#### Parameter `projectGUID`

The cloud project to which a model will be attached.

#### Since

2019

### `M:Autodesk.Revit.DB.IModelAccessValidationServerProxy.IsAllowedToAccess(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IModelAccessValidationServerProxy.IsAllowedToAccess(Autodesk.Revit.DB.ModelPath)`

#### Summary

Check if a model path is allowed to access.

#### Remarks

Currently, the model path passed in could be a ServerPath, a CloudPath, a FilePath
or even an invalid one. Consider it when implementing this function.

#### Parameter `modelPath`

The model path to validate.

#### Since

2019

### `M:Autodesk.Revit.DB.IModelAccessValidationServer.IsAllowedToInitiate(System.String,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IModelAccessValidationServer.IsAllowedToInitiate(System.String,System.Guid)`

#### Summary

Check if a project in the region is allowed to initiate a model.

#### Parameter `region`

The hub region to which a model would be saved.

#### Parameter `projectGUID`

The cloud project to which a model will be attached.

#### Since

2019

### `M:Autodesk.Revit.DB.IModelAccessValidationServer.IsAllowedToAccess(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IModelAccessValidationServer.IsAllowedToAccess(Autodesk.Revit.DB.ModelPath)`

#### Summary

Check if a model path is allowed to access.

#### Remarks

Currently, the model path passed in could be a ServerPath, a CloudPath, a FilePath
or even an invalid one. Consider it when implementing this function.

#### Parameter `modelPath`

The model path to validate.

#### Since

2019

### `T:Autodesk.Revit.DB.IModelAccessValidationServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.IModelAccessValidationServer`

#### Summary

The interface of external server which validates the access to Revit model such as Revit Cloud model.

#### Remarks

Implement this interface and register an instance of the derived class with ModelAccessValidationService.

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.IMemberForcesServerProxy.MemberForcesUpdate(Autodesk.Revit.DB.Structure.MemberForcesServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IMemberForcesServerProxy.MemberForcesUpdate(Autodesk.Revit.DB.Structure.MemberForcesServiceData)`

#### Summary

The server's method that will be called when Revit User clicks Member Forces button in the MPP.

#### Remarks

The server provides UI way for Revit user to view and modify the detail data corresponding with the parameter value.
The server may also modify the section type parameter value itself during the execution.
The method should always return 'true' if the server is successfully executed, no matter whether the server changes anything.
Return 'false' or if the server throws, indicates a failed case, all changes made by the server will be discarded.

#### Parameter `data`

The Moment Forces data.

#### Returns

Indicates whether themember forces parameter server is executed successfully.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.IMemberForcesServer.MemberForcesUpdate(Autodesk.Revit.DB.Structure.MemberForcesServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IMemberForcesServer.MemberForcesUpdate(Autodesk.Revit.DB.Structure.MemberForcesServiceData)`

#### Summary

The server's method that will be called when Revit User clicks Member Forces button in the MPP.

#### Remarks

The server provides UI way for Revit user to view and modify the detail data corresponding with the parameter value.
The server may also modify the section type parameter value itself during the execution.
The method should always return 'true' if the server is successfully executed, no matter whether the server changes anything.
Return 'false' or if the server throws, indicates a failed case, all changes made by the server will be discarded.

#### Parameter `data`

The Moment Forces data.

#### Returns

Indicates whether themember forces parameter server is executed successfully.

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.IMemberForcesServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.IMemberForcesServer`

#### Summary

Interface for the Member Forces server to implement.

#### Since

2015

### `M:Autodesk.Revit.DB.IGeometryAugmentationServerProxy.GetAllUsableReferences(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IGeometryAugmentationServerProxy.GetAllUsableReferences(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Provides a list of all the ExternalGeometryId that are going to be used with this element.

#### Remarks

This function is called when input is required from the external application.

#### Parameter `document`

The document where the target element exists.

#### Parameter `target`

The ID for the element requested to be attached to this server.

#### Returns

Set containing all the ExternalGeometryIds that are going to be used with this element.

#### Since

2024

### `M:Autodesk.Revit.DB.IGeometryAugmentationServerProxy.ValidateElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IGeometryAugmentationServerProxy.ValidateElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Called when a new element is requested to be attached to this server.

#### Remarks

This function is called when input is required from the external application.

#### Parameter `document`

The document where the target element exists.

#### Parameter `target`

The ID for the element requested to be attached to this server.

#### Returns

Set to true if the server can work with this element, false otherwise.

#### Since

2024

### `M:Autodesk.Revit.DB.IGeometryAugmentationServerProxy.GetExtraSpecTypeDependencies(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IGeometryAugmentationServerProxy.GetExtraSpecTypeDependencies(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the list of specs that this server depends on for the generation of the graphics appended for this element.

#### Parameter `document`

The document where the target element exists.

#### Parameter `target`

The id of the element that will be redrawn if one of the elements that has an id in the returned list changed.

#### Returns

Returns the list of specs that this server depends on for the generation of the graphics appended for this element.

#### Since

2024

### `M:Autodesk.Revit.DB.IGeometryAugmentationServerProxy.GetExtraAppearanceDependencies(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IGeometryAugmentationServerProxy.GetExtraAppearanceDependencies(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns the IDs for the elements that will determine determine a redraw request from this server on the target element.

#### Remarks

This function is called when input is required from the external application.

#### Parameter `document`

The document where the target element exists.

#### Parameter `target`

The id of the element that will be redrawn if one of the elements that has an id in the returned list changed.

#### Returns

A list of element IDs for elements that if changed will force a redraw for the target element.

#### Since

2024

### `M:Autodesk.Revit.DB.IGeometryAugmentationServerProxy.AugmentGeometry(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IGeometryAugmentationServerProxy.AugmentGeometry(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns the graphic data that will be added to the element with the target id.

#### Remarks

This function is called when graphics data is required from the external application.

#### Parameter `document`

The document where the target element exists.

#### Parameter `viewId`

The id of the view-port where this element will be drawn.

#### Parameter `target`

The id for the element that will have the extra representation added by this server.

#### Returns

Graphics data used by Revit to draw the extra data that the server requires.

#### Since

2024

### `M:Autodesk.Revit.DB.IGeometryAugmentationServer.GetAllUsableReferences(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IGeometryAugmentationServer.GetAllUsableReferences(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Provides a list of all the ExternalGeometryId that are going to be used with this element.

#### Remarks

This function is called when input is required from the external application.

#### Parameter `document`

The document where the target element exists.

#### Parameter `target`

The ID for the element requested to be attached to this server.

#### Returns

Set containing all the ExternalGeometryIds that are going to be used with this element.

#### Since

2024

### `M:Autodesk.Revit.DB.IGeometryAugmentationServer.ValidateElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IGeometryAugmentationServer.ValidateElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Called when a new element is requested to be attached to this server.

#### Remarks

This function is called when input is required from the external application.

#### Parameter `document`

The document where the target element exists.

#### Parameter `target`

The ID for the element requested to be attached to this server.

#### Returns

Set to true if the server can work with this element, false otherwise.

#### Since

2024

### `M:Autodesk.Revit.DB.IGeometryAugmentationServer.GetExtraSpecTypeDependencies(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IGeometryAugmentationServer.GetExtraSpecTypeDependencies(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the list of specs that this server depends on for the generation of the graphics appended for this element.

#### Parameter `document`

The document where the target element exists.

#### Parameter `target`

The id of the element that will be redrawn if one of the elements that has an id in the returned list changed.

#### Returns

Returns the list of specs that this server depends on for the generation of the graphics appended for this element.

#### Since

2024

### `M:Autodesk.Revit.DB.IGeometryAugmentationServer.GetExtraAppearanceDependencies(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IGeometryAugmentationServer.GetExtraAppearanceDependencies(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns the IDs for the elements that will determine determine a redraw request from this server on the target element.

#### Remarks

This function is called when input is required from the external application.

#### Parameter `document`

The document where the target element exists.

#### Parameter `target`

The id of the element that will be redrawn if one of the elements that has an id in the returned list changed.

#### Returns

A list of element IDs for elements that if changed will force a redraw for the target element.

#### Since

2024

### `M:Autodesk.Revit.DB.IGeometryAugmentationServer.AugmentGeometry(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IGeometryAugmentationServer.AugmentGeometry(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns the graphic data that will be added to the element with the target id.

#### Remarks

This function is called when graphics data is required from the external application.

#### Parameter `document`

The document where the target element exists.

#### Parameter `viewId`

The id of the view-port where this element will be drawn.

#### Parameter `target`

The id for the element that will have the extra representation added by this server.

#### Returns

Graphics data used by Revit to draw the extra data that the server requires.

#### Since

2024

### `T:Autodesk.Revit.DB.IGeometryAugmentationServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.IGeometryAugmentationServer`

#### Summary

Represents an interface that should be overridden by servers that can generate and update data for associated elements.

This is part of the Geometry Augmentation system implementation.
This server was designed to be public_api but in the end it was decided to be moved to public_api_internal
because an element enhanced with this system created by a third party can't be computed when publish the
rvt file into the cloud.
The computation of the value and graphics is done in generateGrep and if the addon the defines the server is not
present it the cell will be empty.
Decision can be found here:
https://autodesk.slack.com/archives/C02KQUH4519/p1673018478447789
https://wiki.autodesk.com/display/aeceng/Public+availability+of+the+Custom+Graphics+API#decision_framework-1761429744

#### Remarks

Server interface to drive extra graphics from an external application on elements that attached to it using `!:Autodesk::Revit::DB::GeometryAugmentationRegistry::registerToServer` .

#### Since

2024

### `M:Autodesk.Revit.DB.ParameterDownloadOptions.SetGroupTypeId(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterDownloadOptions.SetGroupTypeId(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Set properties palette group identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.ParameterDownloadOptions.GetGroupTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterDownloadOptions.GetGroupTypeId`

#### Summary

Get properties palette group identifier.

#### Since

2024

### `M:Autodesk.Revit.DB.ParameterDownloadOptions.SetCategories(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterDownloadOptions.SetCategories(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Set categories for binding.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.ParameterDownloadOptions.GetCategories`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterDownloadOptions.GetCategories`

#### Summary

Get categories for binding.

#### Since

2024

### `P:Autodesk.Revit.DB.ParameterDownloadOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterDownloadOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ParameterDownloadOptions.Visible`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterDownloadOptions.Visible`

#### Summary

True if the parameter is visible to the user, false if it is hidden and accessible only via the API.

#### Since

2024

### `P:Autodesk.Revit.DB.ParameterDownloadOptions.IsInstance`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterDownloadOptions.IsInstance`

#### Summary

True if binding to Element instances, false if binding to Element types.

#### Since

2024

### `M:Autodesk.Revit.DB.ParameterDownloadOptions.#ctor(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.Boolean,System.Boolean,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterDownloadOptions.#ctor(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.Boolean,System.Boolean,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Creates a new ParameterDownloadOptions instance.
Category bindings are represented by an ElementIdSet populated with category identifiers.

#### Parameter `categories`

The category identifiers.

#### Parameter `isInstance`

True if binding to Element instances, false if binding to Element types.

#### Parameter `visible`

True if the parameter is visible to the user, false if it is hidden and accessible only via the API.

#### Parameter `groupTypeId`

Properties palette group identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.ParameterDownloadOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterDownloadOptions.#ctor`

#### Summary

Default constructor.

#### Since

2024
