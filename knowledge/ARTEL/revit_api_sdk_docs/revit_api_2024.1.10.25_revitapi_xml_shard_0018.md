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
Shard: 18
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `P:Autodesk.Revit.DB.PolymeshFacet.V2`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolymeshFacet.V2`

#### Summary

The second vertex of the facet

#### Value

An index of a vertex of a polymesh.

### `P:Autodesk.Revit.DB.PolymeshFacet.V1`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolymeshFacet.V1`

#### Summary

The first vertex of the facet

#### Value

An index of a vertex of a polymesh.

### `M:Autodesk.Revit.DB.PolymeshFacet.#ctor(System.Int32,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolymeshFacet.#ctor(System.Int32,System.Int32,System.Int32)`

#### Summary

Creates a PolymeshFacet with the supplied vertices.

#### Parameter `v1`

The first vertex.

#### Parameter `v2`

The second vertex.

#### Parameter `v3`

The third vertex.

#### Since

2019.2

### `T:Autodesk.Revit.DB.PolymeshFacet`

Member kind: type
Symbol: `Autodesk.Revit.DB.PolymeshFacet`

#### Summary

A class representing one triangular piece - a facet - in a polymesh topology.

#### Remarks

It can also be used to create TopographySurface.
Each facet is defined by indices of three vertices of the polymesh.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.IsValidFaceSet(System.Collections.Generic.IList{Autodesk.Revit.DB.PolymeshFacet},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.IsValidFaceSet(System.Collections.Generic.IList{Autodesk.Revit.DB.PolymeshFacet},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Identifies whether the facets can construct a valid topography surface.

#### Parameter `facets`

The facets to be checked.

#### Parameter `points`

A collection of points.

#### Returns

True if the facets are valid, otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There are no points in the input points set.
-or-
There were not enough points to form a valid region (at least 3 are required), or the points were collinear ignoring elevation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019.2

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.GetHostedSubRegionIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.GetHostedSubRegionIds`

#### Summary

Gets the ids of all subregion elements hosted on this topography surface.

#### Remarks

This applies to a TopographySurface element (not a SiteSubRegion or a topography surface associated with a BuildingPad).
This applies to TopographySurface and SiteSubRegion elements.

#### Returns

The hosted subregion ids.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This element is not a TopographySurface.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.AsSiteSubRegion`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.AsSiteSubRegion`

#### Summary

Obtains the subregion object represented by this element.

#### Remarks

This applies to TopographySurface and SiteSubRegion elements.

#### Returns

The SiteSubRegion element. If this does not represent a SiteSubRegion, this will be `null` .

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.FindPoints(Autodesk.Revit.DB.Outline)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.FindPoints(Autodesk.Revit.DB.Outline)`

#### Summary

Filters and returns only the points of the topography surface which lie within the input bounding box.

#### Remarks

This applies to TopographySurface, SiteSubRegion, and the topography surface associated with a BuildingPad element.

#### Parameter `boundingBox`

The 3D bounding box.

#### Returns

The result points within the 3D bounding box

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

boundingBox is an empty Outline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.GetInteriorPoints`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.GetInteriorPoints`

#### Summary

Gets all of the points that are not boundary points for the topography surface.

#### Remarks

This applies to TopographySurface, SiteSubRegion, and the topography surface associated with a BuildingPad element.
For a SiteSubRegion, this returns the points inherited from the host TopographySurface.
For the topography surface associated with a BuildingPad element, this returns an empty collection.

#### Returns

The collection of interior points.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.GetBoundaryPoints`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.GetBoundaryPoints`

#### Summary

Gets the points which are on the boundary of the topography surface.

#### Remarks

This applies to TopographySurface, SiteSubRegion, and the topography surface associated with a BuildingPad element.
For a SiteSubRegion, this returns the points from a representation of the region's boundary.
For the topography surface associated with a BuildingPad element, this returns the points from the sketch of this topography surface.

#### Returns

The collection of boundary points.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.ContainsPoint(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.ContainsPoint(Autodesk.Revit.DB.XYZ)`

#### Summary

Identifies whether the given point exists in the topography surface.

#### Remarks

The given point will be evaluated in XYZ. If a point matches the XY location, but not the elevation, this function still returns false.
This applies to TopographySurface and SiteSubRegion elements.

#### Parameter `point`

The point to be checked.

#### Returns

True if the input point exists in the topography surface, otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.IsBoundaryPoint(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.IsBoundaryPoint(Autodesk.Revit.DB.XYZ)`

#### Summary

Identifies whether the given point is an existing boundary point of the current topography surface.

#### Remarks

This applies to TopographySurface, SiteSubRegion, and the topography surface associated with a BuildingPad element.
The given point will be evaluated in XYZ. If a point matches the XY location, but not the elevation, an ArgumentException will be thrown
if this point does not exist in current topography surface.

#### Parameter `point`

The point to be checked.

#### Returns

Returns true if a given point is an existing boundary point.
For TopographySurface and SiteSubRegion elements, it returns false if the given point is an existing interior point of current topography surface.
For the topography surface associated with a BuildingPad element, it always returns true if the point is a part of the element (all points are boundary
points for the topography surface associated with a BuildingPad element).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input point does not exist in the current topography surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.GetPoints`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.GetPoints`

#### Summary

Gets the points that define this topography surface.

#### Remarks

This applies to TopographySurface, SiteSubRegion, and the topography surface associated with a BuildingPad element.
For a SiteSubRegion, this returns the points from a representation of the region's boundary as well as the points inherited from the host TopographySurface.
For the topography surface associated with a BuildingPad element, this returns the points from the sketch of this topography surface(there are no interior points for this topography surface).

#### Returns

The collection of points.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.ArePointsDistinct(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.ArePointsDistinct(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Identify whether the input points are distinct in XY location.

#### Parameter `points`

The points set to be checked.

#### Returns

True if all points are distinct after ignoring the elevations, otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There are no points in the input points set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.IsValidRegion(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.IsValidRegion(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Identify whether the points can construct a valid region for a topography surface.

#### Parameter `points`

The points set to be checked.

#### Returns

True if the size of points is not less than 3 and the points are not collinear after projecting to XY plane, that is, ignoring the elevation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There are no points in the input points set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.ChangePointsElevation(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.ChangePointsElevation(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Double)`

#### Summary

Changes the elevation value for points

#### Remarks

If none of the points in the collection doesn's exist, an exception will be thrown.
This function ignores input points that do not exist, unless all of the input points do not exist, which will result in an exception.
This applies to a TopographySurface element (not a SiteSubRegion or a topography surface associated with a BuildingPad), which shoule be in an active TopographyEditScope.

#### Parameter `points`

The points to be modified.

#### Parameter `elevationValue`

The new elevation value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There are no points in the input points set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for elevationValue must be no more than 30000 feet in absolute value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This element is not a TopographySurface.
-or-
The points of this topography surface are not editable.
-or-
The TopographySurface element is not in an active TopographyEditScope.
Modification cannot be made on this TopographySurface.
-or-
None of the input points exists in the current TopographySurface.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing this TopographySurface is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing this TopographySurface is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing this TopographySurface has no open transaction.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.ChangePointElevation(Autodesk.Revit.DB.XYZ,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.ChangePointElevation(Autodesk.Revit.DB.XYZ,System.Double)`

#### Summary

Changes the elevation value for a point.

#### Remarks

If the point doesn't exist in the current TopographySurface, an exception will be thrown.
This applies to a TopographySurface element (not a SiteSubRegion or a topography surface associated with a BuildingPad), which should be in an active TopographyEditScope.

#### Parameter `point`

The point to be modified.

#### Parameter `elevationValue`

The new elevation value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input point does not exist in the current topography surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for elevationValue must be no more than 30000 feet in absolute value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This element is not a TopographySurface.
-or-
The points of this topography surface are not editable.
-or-
The TopographySurface element is not in an active TopographyEditScope.
Modification cannot be made on this TopographySurface.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing this TopographySurface is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing this TopographySurface is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing this TopographySurface has no open transaction.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.MovePoints(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.MovePoints(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.XYZ)`

#### Summary

Moves a collection of points in a topography surface by a designated vector.

#### Remarks

The points which don't exist in the current TopographySurface will be ignored.
This function ignores input points that do not exist, unless all of the input points do not exist, which will result in an exception.
This applies to a TopographySurface element (not a SiteSubRegion or a topography surface associated with a BuildingPad), which shoule be in an active TopographyEditScope.

#### Parameter `movedPoints`

The points to be moved.

#### Parameter `moveVector`

The vector which describes the distance and direction for the move.
Note that the Z value represents a change in elevation, pass Z=0 to move the point without changing the elevation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There are no points in the input points set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This element is not a TopographySurface.
-or-
The points of this topography surface are not editable.
-or-
The TopographySurface element is not in an active TopographyEditScope.
Modification cannot be made on this TopographySurface.
-or-
None of the input points exists in the current TopographySurface.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing this TopographySurface is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing this TopographySurface is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing this TopographySurface has no open transaction.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.MovePoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.MovePoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Moves a point in a TopographySurface to a new designated location.

#### Remarks

If targetPt exists, the movedPt will be deleted. That means if movedPoint is moved to become a duplicate of an existing
point, movedPoint will be deleted instead becuase both points cannot exist at the same location.
This applies to a TopographySurface element (not a SiteSubRegion or a topography surface associated with a BuildingPad), which shoule be in an active TopographyEditScope.

#### Parameter `movedPoint`

The point to be moved.

#### Parameter `targetPoint`

The new designated location of this point will move to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input point does not exist in the current topography surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This element is not a TopographySurface.
-or-
The points of this topography surface are not editable.
-or-
The TopographySurface element is not in an active TopographyEditScope.
Modification cannot be made on this TopographySurface.
-or-
The input point doesn't exist in the current TopographySurface.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing this TopographySurface is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing this TopographySurface is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing this TopographySurface has no open transaction.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.DeletePoints(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.DeletePoints(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Deletes points from a Topography surface.

#### Remarks

Points will be deleted if they matched in XY.
This function ignores input points that do not exist, unless all of the input points do not exist, which will result in an exception.
This applies to a TopographySurface element (not a SiteSubRegion or a topography surface associated with a BuildingPad), which shoule be in an active TopographyEditScope.

#### Parameter `points`

A collection of points to be deleted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There are no points in the input points set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This element is not a TopographySurface.
-or-
The topography surface is not editable.
-or-
The TopographySurface element is not in an active TopographyEditScope.
Modification cannot be made on this TopographySurface.
-or-
The points of this topography surface are not editable.
-or-
None of the input points exists in the current TopographySurface.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing this TopographySurface is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing this TopographySurface is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing this TopographySurface has no open transaction.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.AddPoints(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.AddPoints(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Adds points to a topography surface.

#### Remarks

If an input point already exists in the surface at the same XY location, the point will not be added.
The document will be regenerated by this function.
This applies to a TopographySurface element (not a SiteSubRegion or a topography surface associated with a BuildingPad), which should be in an active TopographyEditScope.

#### Parameter `points`

A collection of points to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There are no points in the input points set.
-or-
One or more points shared the same XY location (even with different elevations). This is not permitted for topography surfaces.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This element is not a TopographySurface.
-or-
The topography surface is not editable.
-or-
The points of this topography surface are not editable.
-or-
The TopographySurface element is not in an active TopographyEditScope.
Modification cannot be made on this TopographySurface.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing this TopographySurface is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing this TopographySurface is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing this TopographySurface has no open transaction.

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.PolymeshFacet})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.PolymeshFacet})`

#### Summary

Creates a new topography surface element from facets and adds it to the document.

#### Remarks

The document will be regenerated during the creation of this topography surface element.
The topography surface created by facet cannot modify its triangle points and facets.

#### Parameter `document`

The document to be modified.

#### Parameter `points`

A collection of points.
The points represent an enclosed area in the XY plane.

#### Parameter `facets`

Triangle facets composing a polygon mesh.
Every facet contains 3 integers representing vertex indices.

#### Returns

The new topography surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
There are invalid facets. Facets with more than two points with same x, y are not allowed.
-or-
There is(are) reference gap(s) between input arguments: points and facets.

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

2019.2

### `M:Autodesk.Revit.DB.Architecture.TopographySurface.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Creates a new topography surface element and adds it to the document.

#### Remarks

The document will be regenerated during the creation of this topography surface element.

#### Parameter `document`

The document to be modified.

#### Parameter `points`

A collection of points.
The points represent an enclosed area in the XY plane.
There can be only one point in the same XY location.

#### Returns

The new topography surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
There are no points in the input points set.
-or-
There were not enough points to form a valid region (at least 3 are required), or the points were collinear ignoring elevation.
-or-
One or more points shared the same XY location (even with different elevations). This is not permitted for topography surfaces.

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

### `P:Autodesk.Revit.DB.Architecture.TopographySurface.MaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.MaterialId`

#### Summary

The id of the material applied to this element.

#### Remarks

This applies to TopographySurface and SiteSubRegion elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The materialId cannot map to a valid material element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.TopographySurface.AssociatedBuildingPadId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.AssociatedBuildingPadId`

#### Summary

The element id of the building pad which causes this topography surface to be formed.

#### Remarks

InvalidElementId returned signals that there is no associated building pad.

#### Since

2015

### `P:Autodesk.Revit.DB.Architecture.TopographySurface.IsAssociatedWithBuildingPad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.IsAssociatedWithBuildingPad`

#### Summary

Identifies if this element represents a topography surface associated with a building pad.

#### Since

2015

### `P:Autodesk.Revit.DB.Architecture.TopographySurface.IsSiteSubRegion`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.IsSiteSubRegion`

#### Summary

Identifies if this element represents a subregion.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.TopographySurface.ArePointsEditable`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface.ArePointsEditable`

#### Summary

Identifies whether the points of this topography surface can be edited independently.
Topography surfaces created from external data will not allow editing of individual points.

#### Since

2019

### `T:Autodesk.Revit.DB.Architecture.TopographySurface`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.TopographySurface`

#### Summary

Represents a TopographySurface element.

#### Remarks

TopographySurface and related classes have been replaced as of Revit 2024 with `T:Autodesk.Revit.DB.Toposolid` and related classes.
It is recommended that all newly created elements and modifications operate from the new Toposolid class. The TopographySurface element remains in the API for backwards compatibility and upgrade.
A TopographySurface element in the Revit API represents:
An actual topography surface which can have an arbitrary boundary and collection of points.

A SiteSubRegion element bounded by a sketch.

A topography surface created automatically by the introduction of a BuildingPad element.
Identify a subregion with the IsSiteSubRegion property, and access the object that provides interfaces to manipulate the subregion via AsSiteSubRegion().
Identify a topography surface associated with a building pad with the isAssociatedWithBuildingPad property, and access the associated BuildingPad element via the property AssociatedBuildingPadId.
If the element does represent a subregion or a topography surface associated with a building pad, some methods of this class are inapplicable.

### `M:Autodesk.Revit.DB.Architecture.SiteSubRegion.SetBoundary(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.SiteSubRegion.SetBoundary(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Set the given curve loops as the boundary of an existing SiteSubRegion.

#### Parameter `curveLoops`

A collection of curve loops to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve loops cannot compose a valid boundary, that means:
no curve loop is contained in the given collection;
these curve loops intersect with each other for some of them;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the horizontal(XY) plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the Sketch for the boundary of the current Subregion.
-or-
Cannot find an appropriate host topography surface for the SubRegion.
-or-
The given curve loops intersect with curve loops of existing SiteSubRegions hosted on the same TopographySurface.
-or-
The boundary of SubRegion is entirely inside or overlaps at least one existing BuildingPad hosted on the same TopographySurface. This behavior is not allowed.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing this SiteSubRegion is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing this SiteSubRegion is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing this SiteSubRegion has no open transaction.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.SiteSubRegion.GetBoundary`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.SiteSubRegion.GetBoundary`

#### Summary

Gets the boundary of current subregion.

#### Returns

The curve loops that represent the boundary.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.SiteSubRegion.IsValidBoundary(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.SiteSubRegion.IsValidBoundary(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Identifies whether the given curve loops compose a valid boundary.

#### Remarks

The curve loops are valid if they don't intersect with each other; each curve loop is closed;
and each loop is planar and lies on a plane parallel to the horizontal(XY) plane.

#### Parameter `curveLoops`

The curve loops to be checked.

#### Returns

True if the given curve loops don't intersect with each other; each curve loop is closed;
and each loop is planar and lies on a plane parallel to the horizontal(XY) plane.
Any requirement above is not satisfied or no curve loops contained, returns false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.SiteSubRegion.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.SiteSubRegion.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new SiteSubRegion element with assigned TopographySurface to be hosted and adds it to the document.

#### Remarks

This will create a new TopographySurface element which represents a subregion with a host TopographySurface assigned.
If you need access to this Element you can obtain it from the TopographySurface property.
See `P:Autodesk.Revit.DB.Architecture.SiteSubRegion.TopographySurface` for details.

#### Parameter `document`

The document to be modified.

#### Parameter `curveLoops`

The boundary of the subregion.

#### Parameter `hostTopoSurfaceId`

The element id of a TopographySurface assigned to be a host of new created SiteSubRegion.

#### Returns

The new SubRegion surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve loops cannot compose a valid boundary, that means:
no curve loop is contained in the given collection;
these curve loops intersect with each other for some of them;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the horizontal(XY) plane.
-or-
The ElementId hostTopoSurfaceId does not represent a TopographySurface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the Sketch for the boundary of the current Subregion.
-or-
Cannot associate the new subregion with the assigned host because there is no geometric overlap, or they have mismatched design options.
-or-
The given curve loops intersect with curve loops of existing SiteSubRegions hosted on the same TopographySurface.
-or-
The boundary of SubRegion is entirely inside or overlaps at least one existing BuildingPad hosted on the same TopographySurface. This behavior is not allowed.

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

### `M:Autodesk.Revit.DB.Architecture.SiteSubRegion.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.SiteSubRegion.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Creates a new SiteSubRegion element and adds it to the document.

#### Remarks

This will create a new TopographySurface element which represents a subregion.
If you need access to this Element you can obtain it from `P:Autodesk.Revit.DB.Architecture.SiteSubRegion.TopographySurface` .

#### Parameter `document`

The document to be modified.

#### Parameter `curveLoops`

The boundary of the subregion.

#### Returns

The new SubRegion surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve loops cannot compose a valid boundary, that means:
no curve loop is contained in the given collection;
these curve loops intersect with each other for some of them;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the horizontal(XY) plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the Sketch for the boundary of the current Subregion.
-or-
Cannot find an appropriate host TopographySurface for the Subregion.
-or-
The given curve loops intersect with curve loops of existing SiteSubRegions hosted on the same TopographySurface.
-or-
The boundary of SubRegion is entirely inside or overlaps at least one existing BuildingPad hosted on the same TopographySurface. This behavior is not allowed.

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

### `P:Autodesk.Revit.DB.Architecture.SiteSubRegion.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.SiteSubRegion.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.SiteSubRegion.HostId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.SiteSubRegion.HostId`

#### Summary

The element id of the topography surface hosting this SiteSubRegion.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.SiteSubRegion.TopographySurface`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.SiteSubRegion.TopographySurface`

#### Summary

The TopographySurface element which this SiteSubRegion represents.

#### Since

2014

### `T:Autodesk.Revit.DB.Architecture.SiteSubRegion`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.SiteSubRegion`

#### Summary

Represents a proxy class exposing the interfaces needed to access details of a subregion.

#### Remarks

In the Revit database, both TopographySurface elements and subregion elements are represented by the same TopographySurface element subclass.
In the Revit API, this SiteSubRegion class exists to separate the interfaces for subregions from those of topography surfaces.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.TopographyLinkLoadOption.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLinkLoadOption.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.TopographyLinkLoadOption.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLinkLoadOption.#ctor`

#### Summary

default constructor

#### Since

2023

### `T:Autodesk.Revit.DB.Architecture.TopographyLinkLoadOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLinkLoadOption`

#### Summary

Topography Link Load Option

#### Since

2023

### `T:Autodesk.Revit.DB.Architecture.TopographyLinkLoadType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLinkLoadType`

#### Since

2023

#### Summary

Topography Link Type

#### Since

2023

### `F:Autodesk.Revit.DB.Architecture.TopographyLinkLoadType.TLLT_Toposolid`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLinkLoadType.TLLT_Toposolid`

#### Summary

Load type indicating Toposolid members

### `F:Autodesk.Revit.DB.Architecture.TopographyLinkLoadType.TLLT_SiteSurface`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.TopographyLinkLoadType.TLLT_SiteSurface`

#### Summary

Load type indicating SiteSurface members

### `M:Autodesk.Revit.DB.SiteInsertServiceData.GetLinkLoadOption`

Member kind: method
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.GetLinkLoadOption`

#### Summary

Retreives the TopographyLinkLoadOption to indicate creation options of TopographyLink members

#### Since

2018

### `M:Autodesk.Revit.DB.SiteInsertServiceData.SetLinkLoadOption(Autodesk.Revit.DB.Architecture.TopographyLinkLoadOption)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.SetLinkLoadOption(Autodesk.Revit.DB.Architecture.TopographyLinkLoadOption)`

#### Summary

Sets the TopographyLinkLoadOption

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.SiteInsertServiceData.GetLinkLoadResult`

Member kind: method
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.GetLinkLoadResult`

#### Summary

Retrieves the LinkLoadResult of the attempt to load or reload a Topography link.

#### Since

2018

### `M:Autodesk.Revit.DB.SiteInsertServiceData.SetLinkLoadResult(Autodesk.Revit.DB.LinkLoadResult)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.SetLinkLoadResult(Autodesk.Revit.DB.LinkLoadResult)`

#### Summary

Sets the LinkLoadResult

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.SiteInsertServiceData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.SiteInsertServiceData.SessionId`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.SessionId`

#### Since

2018

### `P:Autodesk.Revit.DB.SiteInsertServiceData.DoReloadFrom`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.DoReloadFrom`

#### Summary

Determines whether to reload from.

#### Since

2018

### `P:Autodesk.Revit.DB.SiteInsertServiceData.LinkTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.LinkTypeId`

#### Summary

The ElementId of the TopographyLinkType.

#### Since

2018

### `P:Autodesk.Revit.DB.SiteInsertServiceData.DoReload`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.DoReload`

#### Summary

Determines whether to insert or to reload.

#### Since

2018

### `P:Autodesk.Revit.DB.SiteInsertServiceData.LinkId`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.LinkId`

#### Summary

Id of the created TopographyLink

#### Since

2018

### `P:Autodesk.Revit.DB.SiteInsertServiceData.IsRevitInAPIMode`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.IsRevitInAPIMode`

#### Summary

Determines whether Revit is in API mode or not.

#### Since

2018

### `P:Autodesk.Revit.DB.SiteInsertServiceData.Placement`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.Placement`

#### Summary

Where to place the linked symbol element.
Set this option to place the view at the origin, the center, the base point, or a shared coordinates.

#### Since

2018

### `P:Autodesk.Revit.DB.SiteInsertServiceData.Document`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.Document`

#### Summary

The current document.

#### Since

2018

### `P:Autodesk.Revit.DB.SiteInsertServiceData.FilePath`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData.FilePath`

#### Summary

The path of the inserted file.

#### Since

2018

### `T:Autodesk.Revit.DB.SiteInsertServiceData`

Member kind: type
Symbol: `Autodesk.Revit.DB.SiteInsertServiceData`

#### Summary

The data associated with the site insert service.

#### Since

2018

### `M:Autodesk.Revit.DB.ISiteInsertServerProxy.UpdateSiteData(Autodesk.Revit.DB.SiteInsertServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ISiteInsertServerProxy.UpdateSiteData(Autodesk.Revit.DB.SiteInsertServiceData)`

#### Summary

The method that Revit will invoke to update the site data.

#### Parameter `data`

The site insert data.

#### Returns

Indicates whether the site insert server is executed successfully.

#### Since

2018

### `M:Autodesk.Revit.DB.ISiteInsertServerProxy.Insert(Autodesk.Revit.DB.SiteInsertServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ISiteInsertServerProxy.Insert(Autodesk.Revit.DB.SiteInsertServiceData)`

#### Summary

The method that Revit will invoke to perform site insert.

#### Parameter `data`

The site insert data.

#### Returns

Indicates whether the site insert server is executed successfully.

#### Since

2018

### `M:Autodesk.Revit.DB.ISiteInsertServer.UpdateSiteData(Autodesk.Revit.DB.SiteInsertServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ISiteInsertServer.UpdateSiteData(Autodesk.Revit.DB.SiteInsertServiceData)`

#### Summary

The method that Revit will invoke to update the site data.

#### Parameter `data`

The site insert data.

#### Returns

Indicates whether the site insert server is executed successfully.

#### Since

2018

### `M:Autodesk.Revit.DB.ISiteInsertServer.Insert(Autodesk.Revit.DB.SiteInsertServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ISiteInsertServer.Insert(Autodesk.Revit.DB.SiteInsertServiceData)`

#### Summary

The method that Revit will invoke to perform site insert.

#### Parameter `data`

The site insert data.

#### Returns

Indicates whether the site insert server is executed successfully.

#### Since

2018

### `T:Autodesk.Revit.DB.ISiteInsertServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.ISiteInsertServer`

#### Summary

Interface for external servers implementing site insert.

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalService.SingleServerService.UnsetActiveServer(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.SingleServerService.UnsetActiveServer(Autodesk.Revit.DB.Document)`

#### Summary

Unset the active server for the particular document.

#### Remarks

After unsetting the active server, the document will be using the
application-wide active server, if one was already set.

Note it is not possible to unset a server that acts as an application-wide
active server for a service. On the other hand, there should be no reason
to ever do so, for each and every registered service should have (ideally)
an active server set applicatiton-wide.

For a service which has cref="Autodesk::Revit::DB::ExternalService::SupportActivation" set to false
calling this method will throw exception. For this kind of service only one server can be added,
and it will be marked by default as an application-wide active server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The operation is not allowed because the service is being executed.
-or-
For a service that doesn't support activation, the servers can't be activated/deactivated.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.SingleServerService.SetActiveServer(System.Guid,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.SingleServerService.SetActiveServer(System.Guid,Autodesk.Revit.DB.Document)`

#### Summary

Change the active server for a specific document.

#### Remarks

Only one server per document can be set as active at any given time
in a single-server service. A document does not have to have an explicitly
set active server though - the application-wide active server would be
normally used when the service is executed for such a document.

Having an active server for a document overrules the active server
set for the application. That means if the service gets executed in
this particular document, the document-specific server will be used
instead of the application-wide one.

For a service which has cref="Autodesk::Revit::DB::ExternalService::SupportActivation" set to true
it is possible to set a server as active when another server is already active
for that service in this document. Making a server active will automatically
deactivate the server that was active before this call.

For a service which has cref="Autodesk::Revit::DB::ExternalService::SupportActivation" set to false
calling this method will throw exception. For this kind of service only one server can be added,
and it will be marked by default as an application-wide active server.

#### Parameter `serverId`

Id of the server.

#### Parameter `document`

The document for which the server is being set as active.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given Id is not of a server registered with the service.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The operation is not allowed because the service is being executed.
-or-
For a service that doesn't support activation, the servers can't be activated/deactivated.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.SingleServerService.SetActiveServer(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.SingleServerService.SetActiveServer(System.Guid)`

#### Summary

Set an active server applicable application-wide for the service.

#### Remarks

Only one server can be active at any given time in a single-server service,
but it is possible that no server is active (unless the service is mandatory).

An application-wide active server gets executed when the service is invoked
in the scope of the entire application (i.e. without a specific document),
or if the service is executed in a document but the document does not have
an active server explicitly set.

For a service which has cref="Autodesk::Revit::DB::ExternalService::SupportActivation" set to true
it is possible to set a server as active when another server is already active
for that service. Making a server active will automatically deactivate the server
that was active before this call.

For a service which has cref="Autodesk::Revit::DB::ExternalService::SupportActivation" set to false
calling this method will throw exception. For this kind of service only one server can be added,
and it will be marked by default as active.

#### Parameter `serverId`

Id of the application server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given Id is not of a server registered with the service.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The operation is not allowed because the service is being executed.
-or-
For a service that doesn't support activation, the servers can't be activated/deactivated.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.SingleServerService.GetActiveServerId(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.SingleServerService.GetActiveServerId(Autodesk.Revit.DB.Document)`

#### Summary

Returns the Id of the server currently associated with the given document for the service.

#### Parameter `document`

The document for which the server is being set as active.

#### Returns

The Guid of the active server, or an invalid Guid if there is no active server assigned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.SingleServerService.GetActiveServerId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.SingleServerService.GetActiveServerId`

#### Summary

Returns the Id of the currently active application-level server of the service.

#### Returns

The GUID of the active server, or an invalid GUID if there is no active server assigned.

#### Since

2013

### `T:Autodesk.Revit.DB.ExternalService.SingleServerService`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalService.SingleServerService`

#### Summary

This class represents a single-server service inside Revit application.
It is created when an instance of ISingleServerService is registered with Revit.

#### Since

2013

### `M:Autodesk.Revit.DB.SharedParameterElement.ShouldHideWhenNoValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.SharedParameterElement.ShouldHideWhenNoValue`

#### Summary

Indicates whether the parameter should be hidden from the properties palette if it has no value.

#### Since

2016

### `M:Autodesk.Revit.DB.SharedParameterElement.Lookup(Autodesk.Revit.DB.Document,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SharedParameterElement.Lookup(Autodesk.Revit.DB.Document,System.Guid)`

#### Summary

Finds the shared parameter element that corresponds to the given Guid.

#### Parameter `document`

The document.

#### Parameter `guidValue`

Shared parameter Guid.

#### Returns

The retrieved shared parameter instance, or `null` if the matching element is not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.SharedParameterElement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalDefinition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SharedParameterElement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalDefinition)`

#### Summary

Creates a new shared parameter element in the document representing the parameter stored in the input ExternalDefinition.

#### Parameter `document`

The document.

#### Parameter `sharedParameterDefinition`

Shared parameter definition.

#### Returns

The newly created shared parameter instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

A shared parameter with the assigned GUID is already loaded into the document.

#### Since

2016

### `P:Autodesk.Revit.DB.SharedParameterElement.GuidValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.SharedParameterElement.GuidValue`

#### Summary

The Guid that identifies this shared parameter.

#### Since

2016

### `T:Autodesk.Revit.DB.SharedParameterElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.SharedParameterElement`

#### Summary

An element that stores the definition of a shared parameter which is loaded into the document.

#### Remarks

Shared parameters are user-defined parameters that can be shared by multiple
Revit documents. A shared parameter is identified by a GUID.
Basic information of the shared parameter are accessed through GetDefinition().

#### Since

2016

### `M:Autodesk.Revit.DB.ParameterElement.GetDefinition`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterElement.GetDefinition`

#### Summary

Get the definition representing this parameter element.

#### Returns

The parameter.

#### Since

2016

### `T:Autodesk.Revit.DB.ParameterElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.ParameterElement`

#### Summary

An Element that stores a user-defined parameter.

#### Remarks

Revit supports both built-in and user-defined parameters. Built-in parameters
ship with the application, and they are not stored in Revit documents.
User-defined parameters are dynamically created, and they are stored in the
documents that use them, wrapped in ParameterElement objects. Different
subclasses of ParemeterElement represent different kinds of user-defined
parameters.

#### Since

2016

### `M:Autodesk.Revit.DB.ShapeImporter.SetDefaultLengthUnit(Autodesk.Revit.DB.ImportUnit)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ShapeImporter.SetDefaultLengthUnit(Autodesk.Revit.DB.ImportUnit)`

#### Summary

Sets the length unit to be used when the input is a unitless SAT file.

#### Remarks

Values ImportUnit::Default and ImportUnit::Custom are ignored. ImportUnit::Centimeter is used instead.

#### Parameter `defaultLengthUnit`

The length unit to be used for when the input is a unitless SAT file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017_subscription_update

### `M:Autodesk.Revit.DB.ShapeImporter.IsServiceAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.ShapeImporter.IsServiceAvailable`

#### Summary

Checks whether the data conversion service is available.

#### Remarks

ShapeImporter relies on optional data conversion functionality. This function checks whether it is available.

#### Returns

True if the data conversion service is available, false otherwise.

#### Since

2017

### `M:Autodesk.Revit.DB.ShapeImporter.Convert(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ShapeImporter.Convert(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Converts the geometry stored in the external format into a collection of Revit geometry objects.

#### Parameter `document`

The Revit document where the resulting Revit geometry objects will be used. This document may need to be modified
to store dependent elements such as graphics styles and/or materials.

#### Parameter `filename`

The full path to the input file.

#### Returns

A collection of Revit geometry objects created from the incoming data.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given filename does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Data conversion service is not available.

#### Since

2017

### `P:Autodesk.Revit.DB.ShapeImporter.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ShapeImporter.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ShapeImporter.DefaultLengthUnit`

Member kind: property
Symbol: `Autodesk.Revit.DB.ShapeImporter.DefaultLengthUnit`

#### Summary

The length unit to be used if not specified when the input is a unitless SAT file.

#### Remarks

If the input is a unitless SAT file then this length unit will be used as a backup.

#### Since

2017

### `P:Autodesk.Revit.DB.ShapeImporter.InputFormat`

Member kind: property
Symbol: `Autodesk.Revit.DB.ShapeImporter.InputFormat`

#### Summary

The format of the incoming data.

#### Remarks

If this option is set to Auto (the default), the file name extension will be used to determine the input format. That covers most file-based data import workflows.
Specify the input format explicitly to perform an additional sanity check or if you are using a non-standard file extension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `M:Autodesk.Revit.DB.ShapeImporter.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ShapeImporter.#ctor`

#### Summary

Default constructor. Initializes an instance of ShapeImporter that will automatically recognize the file format from its extension (ShapeImporterSourceFormat.Auto).

#### Since

2017

### `T:Autodesk.Revit.DB.ShapeImporter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ShapeImporter`

#### Summary

A utility class that supports conversion of geometry stored in an external format into a Revit geometry objects.

#### Remarks

See `T:Autodesk.Revit.DB.ShapeImporterSourceFormat` for the list of supported formats.

#### Since

2017

### `T:Autodesk.Revit.DB.ShapeImporterSourceFormat`

Member kind: type
Symbol: `Autodesk.Revit.DB.ShapeImporterSourceFormat`

#### Summary

An enumerated type listing the possible formats supported by the Shapeimporter.

#### Since

2017

#### Since

2017

### `F:Autodesk.Revit.DB.ShapeImporterSourceFormat.STL`

Member kind: field
Symbol: `Autodesk.Revit.DB.ShapeImporterSourceFormat.STL`

#### Summary

The incoming data is in STL format (*.stl).

### `F:Autodesk.Revit.DB.ShapeImporterSourceFormat.OBJ`

Member kind: field
Symbol: `Autodesk.Revit.DB.ShapeImporterSourceFormat.OBJ`

#### Summary

The incoming data is in OBJ format (*.obj).

### `F:Autodesk.Revit.DB.ShapeImporterSourceFormat.SketchUp`

Member kind: field
Symbol: `Autodesk.Revit.DB.ShapeImporterSourceFormat.SketchUp`

#### Summary

The incoming data is in SketchUp format (*.skp).

### `F:Autodesk.Revit.DB.ShapeImporterSourceFormat.Rhino`

Member kind: field
Symbol: `Autodesk.Revit.DB.ShapeImporterSourceFormat.Rhino`

#### Summary

The incoming data is in Rhino format (*.3dm).

### `F:Autodesk.Revit.DB.ShapeImporterSourceFormat.SAT`

Member kind: field
Symbol: `Autodesk.Revit.DB.ShapeImporterSourceFormat.SAT`

#### Summary

The incoming data is in SAT format (*.sat).

### `F:Autodesk.Revit.DB.ShapeImporterSourceFormat.Auto`

Member kind: field
Symbol: `Autodesk.Revit.DB.ShapeImporterSourceFormat.Auto`

#### Summary

The format of the incoming data will be determined from input file extension.

### `M:Autodesk.Revit.DB.SelectionFilterElement.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.SelectionFilterElement.Clear`

#### Summary

Removes all ElementIds from the filter.

#### Since

2013

### `M:Autodesk.Revit.DB.SelectionFilterElement.Contains(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SelectionFilterElement.Contains(Autodesk.Revit.DB.ElementId)`

#### Summary

Returns true if the given ElementId is a member of this filter's set.

#### Parameter `id`

The ElementId to look for.

#### Returns

True if the given ElementId is a member of the filter, otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid ElementId

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.SelectionFilterElement.RemoveSet(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.SelectionFilterElement.RemoveSet(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Removes a set of ElementIds from the filter's set.

#### Parameter `ids`

The set of ElementIds to remove.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.SelectionFilterElement.RemoveSingle(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SelectionFilterElement.RemoveSingle(Autodesk.Revit.DB.ElementId)`

#### Summary

Removes a single ElementId from the filter's set.

#### Parameter `id`

The ElementId to remove.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid ElementId

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.SelectionFilterElement.AddSet(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.SelectionFilterElement.AddSet(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Adds a set of ElementIds to the filter's set.

#### Parameter `ids`

The set of ElementIds to add.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.SelectionFilterElement.AddSingle(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SelectionFilterElement.AddSingle(Autodesk.Revit.DB.ElementId)`

#### Summary

Adds a single ElementId to the filter's set.

#### Parameter `id`

The ElementId to add.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid ElementId

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.SelectionFilterElement.IsEmpty`

Member kind: method
Symbol: `Autodesk.Revit.DB.SelectionFilterElement.IsEmpty`

#### Summary

Determines whether this filter's set is empty or not.

#### Returns

True if the set is empty, otherwise false.

#### Since

2013

### `M:Autodesk.Revit.DB.SelectionFilterElement.GetElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.SelectionFilterElement.GetElementIds`

#### Summary

Returns the set of ElementIds contained by this filter.

#### Returns

The set of ElementIds.

#### Since

2013

### `M:Autodesk.Revit.DB.SelectionFilterElement.SetElementIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.SelectionFilterElement.SetElementIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Replaces the set of ElementIds contained by this filter.

#### Parameter `ids`

The new set of ElementIds.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.SelectionFilterElement.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SelectionFilterElement.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new SelectionFilterElement in the given document.

#### Parameter `document`

The document in which to create the SelectionFilterElement.

#### Parameter `name`

The name for the new SelectionFilterElement.

#### Returns

The new SelectionFilterElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string or contains only whitespace.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
The given value for name is already in use as a filter element name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.SelectionFilterElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.SelectionFilterElement`

#### Summary

A filter element that stores an explicit list of ElementIds.
Only elements whose ElementIds are in this list will pass the filter.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleSortGroupField.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleSortGroupField.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ScheduleSortGroupField.ShowFooterCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleSortGroupField.ShowFooterCount`

#### Summary

Indicates if the footer row should display a count of elements in the group.

#### Remarks

ShowFooterCount can only be enabled if ShowFooter is enabled.

#### Value

True if an element count should be displayed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Display of footer rows is not enabled.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleSortGroupField.ShowFooterTitle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleSortGroupField.ShowFooterTitle`

#### Summary

Indicates if the footer row should display a title.

#### Remarks

The title consists of the value of the field that the
schedule is grouped by.

ShowFooterTitle can only be enabled if ShowFooter is enabled.

#### Value

True if a title should be displayed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Display of footer rows is not enabled.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleSortGroupField.ShowFooter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleSortGroupField.ShowFooter`

#### Summary

Indicates if a footer row should be displayed after each group.

#### Remarks

The footer row displays totals of each field for which
totals are enabled. It can also optionally display a title
(see ShowFooterTitle) and a count of elements
(see ShowFooterCount).

#### Value

True if a footer row should be displayed, false otherwise.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleSortGroupField.ShowBlankLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleSortGroupField.ShowBlankLine`

#### Summary

Indicates if an empty row should be displayed between groups.

#### Remarks

True if an empty row should be displayed, false otherwise.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleSortGroupField.ShowHeader`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleSortGroupField.ShowHeader`

#### Summary

Indicates if a header row should be displayed before each group.

#### Remarks

The header row displays a title consisting of the value of
the field that the schedule is grouped by.

#### Value

True if a header row should be displayed, false otherwise.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleSortGroupField.SortOrder`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleSortGroupField.SortOrder`

#### Summary

Indicates if elements in the schedule will be sorted in
ascending or descending order.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleSortGroupField.FieldId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleSortGroupField.FieldId`

#### Summary

The ID of the field that the schedule will be sorted or grouped by.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleSortGroupField.#ctor(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleSortOrder)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleSortGroupField.#ctor(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleSortOrder)`

#### Summary

Creates a new ScheduleSortGroupField.

#### Parameter `fieldId`

The ID of the field that the schedule will be sorted or grouped by.

#### Parameter `sortOrder`

The sort order, ascending or descending.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleSortGroupField.#ctor(Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleSortGroupField.#ctor(Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Creates a new ScheduleSortGroupField.

#### Parameter `fieldId`

The ID of the field that the schedule will be sorted or grouped by.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleSortGroupField.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleSortGroupField.#ctor`

#### Summary

Creates a new ScheduleSortGroupField.

#### Since

2013

### `T:Autodesk.Revit.DB.ScheduleSortGroupField`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleSortGroupField`

#### Summary

A field that is used for sorting and/or grouping in a schedule.

#### Remarks

A schedule may be sorted or grouped by one or more of the
schedule's fields. The ScheduleSortGroupField class represents
one of the fields that the schedule is sorted or grouped by.

Sorting and grouping are related operations. In either case,
elements appearing in the schedule are sorted based on their values
for the field that the schedule is sorted/grouped by, which automatically
causes elements with identical values to be grouped together.
By enabling extra header, footer, or blank rows, visual separation
between groups can be achieved.

If ScheduleDefinition.IsItemized is false, elements having the
same values for all of the fields used for sorting/grouping will be
combined onto the same row.

A schedule can be sorted or grouped by data that is not displayed
in the schedule by marking the field used for sorting/grouping as hidden
using the ScheduleField.IsHidden property.

#### Since

2013

### `T:Autodesk.Revit.DB.ScheduleSortOrder`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleSortOrder`

#### Summary

Options for sort order of rows in a schedule.

#### Since

2013

### `F:Autodesk.Revit.DB.ScheduleSortOrder.Descending`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleSortOrder.Descending`

#### Summary

Sort in descending order.

### `F:Autodesk.Revit.DB.ScheduleSortOrder.Ascending`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleSortOrder.Ascending`

#### Summary

Sort in ascending order.

### `P:Autodesk.Revit.DB.ScheduleItem.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleItem.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ScheduleItem.SubelementKey`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleItem.SubelementKey`

#### Summary

The subelement key of this schedule item.

### `P:Autodesk.Revit.DB.ScheduleItem.ElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleItem.ElementId`

#### Summary

The element id of this schedule item.

### `P:Autodesk.Revit.DB.ScheduleItem.LinkInstanceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleItem.LinkInstanceId`

#### Summary

If the item is from a linked model, this element id holds the link instance id. Otherwise, is invalid.

### `T:Autodesk.Revit.DB.ScheduleItem`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleItem`

#### Summary

This represents one item from a row of the schedule. On a schedule row can be grouped multiple items.
It can be an element or subelement.

### `M:Autodesk.Revit.DB.ScheduleSheetInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleSheetInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Int32)`

#### Summary

Creates an instance of a schedule segment on a sheet.

#### Remarks

The segment index value could be -1, which means to create an instance for the entire schedule,
see `P:Autodesk.Revit.DB.ScheduleSheetInstance.SegmentIndex` property for more details.

#### Parameter `document`

The document

#### Parameter `viewSheetId`

The id of the sheet where the schedule segment will be placed.

#### Parameter `scheduleId`

The id of the schedule view.

#### Parameter `origin`

Location on the sheet where the schedule segment will be placed.

#### Parameter `segmentIndex`

The schedule segment index of the schedule instance.

#### Returns

The new ScheduleInstance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

scheduleId is not a ViewSchedule that can be added to sheets. "Internal" schedules are not user-visible but are filtered by sheet or used to manage Revisions, which cannot be added to sheets.
-or-
viewSheetId is not a ViewSheet.
-or-
segmentIndex is not a valid segment index.

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

2022.1

### `M:Autodesk.Revit.DB.ScheduleSheetInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleSheetInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

#### Summary

Create an instance of a schedule on a sheet.

#### Parameter `document`

The document

#### Parameter `viewSheetId`

The id of the sheet where the schedule will be placed.

#### Parameter `scheduleId`

The id of the schedule view.

#### Parameter `origin`

Location on the sheet where the schedule will be placed.

#### Returns

The new ScheduleInstance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

scheduleId is not a ViewSchedule that can be added to sheets. "Internal" schedules are not user-visible but are filtered by sheet or used to manage Revisions, which cannot be added to sheets.
-or-
viewSheetId is not a ViewSheet.

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

### `P:Autodesk.Revit.DB.ScheduleSheetInstance.IsTitleblockRevisionSchedule`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleSheetInstance.IsTitleblockRevisionSchedule`

#### Summary

Identifies if this ScheduleSheetInstance is a revision schedule in a titleblock family.

#### Remarks

These schedule instances should not be modified in the project environment. To modify the revision schedule on a titleblock, edit the titleblock family.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleSheetInstance.SegmentIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleSheetInstance.SegmentIndex`

#### Summary

The schedule segment index of this ScheduleSheetInstance.

#### Remarks

This property represents which schedule segment is referred to by this ScheduleSheetInstance. It normally starts with 0 and
is less than the total number of the schedule segments, but there're some speccial cases:
The segment index value could be -1, which means referring to the whole schedule but not a specific segment.

The segment index value 0 should be considered the same as -1 if the referenced schedule is not split in normal cases.

The segment index value must be 0 if the schedule is a revision schedule and in a family.

The segment index value can't be modified if the schedule is filter by sheet. (In fact, The segment
is referenced to is belongs to an internal schedule that only valid in the current view in this case.)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: segmentIndex is not a valid segment index.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The schedule of this ScheduleSheetInstance is a titleblock revision schedule or a sheet specific schedule.

#### Since

2022.1

### `P:Autodesk.Revit.DB.ScheduleSheetInstance.Rotation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleSheetInstance.Rotation`

#### Summary

Rotation of the ScheduleInstance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This operation is prohibited for ScheduleInstances associated with revision schedules in titleblocks.
-or-
When setting this property: This operation is prohibited for ScheduleInstances that are pinned.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleSheetInstance.Point`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleSheetInstance.Point`

#### Summary

Location on the sheet where the ScheduleInstance is placed (in sheet coordinates).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This operation is prohibited for ScheduleInstances associated with revision schedules in titleblocks.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleSheetInstance.ScheduleId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleSheetInstance.ScheduleId`

#### Summary

Id of the primary schedule that generates this ScheduleInstance.

#### Since

2013

### `T:Autodesk.Revit.DB.ScheduleSheetInstance`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleSheetInstance`

#### Summary

An element that represents a particular placement of a schedule on a sheet.

#### Remarks

Use ScheduleSheetInstance.OwnerViewId to find the sheet on which a schedule is placed.

When a schedule is set to filter by sheet and placed on a sheet, it will create a new schedule with elements visible
in the Viewport(s) on that sheet. The instance created belongs to the newly created schedule.

#### Since

2013

### `T:Autodesk.Revit.DB.ViewportRotation`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewportRotation`

#### Summary

Rotation of the viewport

#### Since

2013

### `F:Autodesk.Revit.DB.ViewportRotation.Counterclockwise`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewportRotation.Counterclockwise`

#### Summary

Viewport is rotated 90 degrees counterclockwise.

### `F:Autodesk.Revit.DB.ViewportRotation.Clockwise`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewportRotation.Clockwise`

#### Summary

Viewport is rotated 90 degrees clockwise.

### `F:Autodesk.Revit.DB.ViewportRotation.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewportRotation.None`

#### Summary

Viewport is not rotated.

### `M:Autodesk.Revit.DB.ScheduleFilter.SetValue(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.SetValue(Autodesk.Revit.DB.ElementId)`

#### Summary

Set the filter value to an ElementId.

#### Parameter `id`

The filter value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.SetValue(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.SetValue(System.String)`

#### Summary

Set the filter value to a string.

#### Parameter `string`

The filter value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.SetValue(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.SetValue(System.Double)`

#### Summary

Set the filter value to a double.

#### Parameter `value`

The filter value.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.SetValue(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.SetValue(System.Int32)`

#### Summary

Set the filter value to an integer.

#### Parameter `value`

The filter value.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.SetNullValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.SetNullValue`

#### Summary

Sets the filter to have no specified value (used for HasParameter filters).

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.GetElementIdValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.GetElementIdValue`

#### Summary

Gets the filter value for a filter using an ElementId value.

#### Returns

The filter value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The filter value is not an ElementId.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.GetStringValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.GetStringValue`

#### Summary

Gets the filter value for a filter using a string value.

#### Returns

The filter value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The filter value is not a string.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.GetDoubleValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.GetDoubleValue`

#### Summary

Gets the filter value for a filter using a double value.

#### Returns

The filter value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The filter value is not a double.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.GetIntegerValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.GetIntegerValue`

#### Summary

Gets the filter value for a filter using an integer value.

#### Returns

The filter value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The filter value is not an integer.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleFilter.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleFilter.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ScheduleFilter.IsElementIdValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleFilter.IsElementIdValue`

#### Summary

Indicates if the filter has an ElementId value.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleFilter.IsDoubleValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleFilter.IsDoubleValue`

#### Summary

Indicates if the filter has a double value.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleFilter.IsStringValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleFilter.IsStringValue`

#### Summary

Indicates if the filter has a string value.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleFilter.IsIntegerValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleFilter.IsIntegerValue`

#### Summary

Indicates if the filter has an integer value.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleFilter.IsNullValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleFilter.IsNullValue`

#### Summary

Indicates if the filter has no specified value.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleFilter.FilterType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleFilter.FilterType`

#### Summary

The filter type.

#### Remarks

See ScheduleFilterType for details.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleFilter.FieldId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleFilter.FieldId`

#### Summary

The ID of the field used to filter the schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.#ctor(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFilterType,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.#ctor(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFilterType,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new ScheduleFilter.

#### Parameter `fieldId`

The ID of the field used to filter the schedule.

#### Parameter `filterType`

The filter type.

#### Parameter `value`

The filter value for a filter using an ElementId value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.#ctor(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFilterType,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.#ctor(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFilterType,System.String)`

#### Summary

Creates a new ScheduleFilter.

#### Parameter `fieldId`

The ID of the field used to filter the schedule.

#### Parameter `filterType`

The filter type.

#### Parameter `value`

The filter value for a filter using a string value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.#ctor(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFilterType,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.#ctor(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFilterType,System.Double)`

#### Summary

Creates a new ScheduleFilter.

#### Parameter `fieldId`

The ID of the field used to filter the schedule.

#### Parameter `filterType`

The filter type.

#### Parameter `value`

The filter value for a filter using a double value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.#ctor(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFilterType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.#ctor(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFilterType,System.Int32)`

#### Summary

Creates a new ScheduleFilter.

#### Parameter `fieldId`

The ID of the field used to filter the schedule.

#### Parameter `filterType`

The filter type.

#### Parameter `value`

The filter value for a filter using an integer value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.#ctor(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFilterType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.#ctor(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFilterType)`

#### Summary

Creates a new ScheduleFilter.

#### Parameter `fieldId`

The ID of the field used to filter the schedule.

#### Parameter `filterType`

The filter type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFilter.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFilter.#ctor`

#### Summary

Creates a new ScheduleFilter.

#### Since

2013

### `T:Autodesk.Revit.DB.ScheduleFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleFilter`

#### Summary

A filter in a schedule.

#### Remarks

The ScheduleFilter class represents a single filter in a schedule.
A filter is a condition that must be satisfied for an element to
appear in the schedule. All filters must be satisfied for an element
to appear in the schedule.

A schedule can be filtered by data that is not displayed
in the schedule by marking the field used for filtering as hidden
using the ScheduleField.IsHidden property.

#### Since

2013

### `P:Autodesk.Revit.DB.FilterOperatorAndTextString.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilterOperatorAndTextString.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FilterOperatorAndTextString.FilterOperatorStr`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilterOperatorAndTextString.FilterOperatorStr`

#### Summary

A text string denoting the filter operator.

#### Since

2019

### `P:Autodesk.Revit.DB.FilterOperatorAndTextString.OperatorType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilterOperatorAndTextString.OperatorType`

#### Summary

The filter operator.

#### Since

2019

### `T:Autodesk.Revit.DB.FilterOperatorAndTextString`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterOperatorAndTextString`

#### Summary

An instance of this class holds a filter operator and a text string that denotes
the operator in a particular context. For example, the text string for ScheduleFilterType::LessThan
may be "is less than" for a filter rule based on a parameter with numerical values
or "is below" for a filter rule based on a parameter representing a Level.

#### Since

2019

### `T:Autodesk.Revit.DB.ScheduleFilterType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleFilterType`

#### Summary

Type of schedule filter.

#### Since

2013

### `F:Autodesk.Revit.DB.ScheduleFilterType.HasNoValue`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.HasNoValue`

#### Summary

The element does not have a value for the specified parameter. No value is specified.

### `F:Autodesk.Revit.DB.ScheduleFilterType.HasValue`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.HasValue`

#### Summary

The element has a value for the specified parameter. No value is specified.

### `F:Autodesk.Revit.DB.ScheduleFilterType.IsNotAssociatedWithGlobalParameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.IsNotAssociatedWithGlobalParameter`

#### Summary

The field is not associated with a specified global parameter of a compatible type

### `F:Autodesk.Revit.DB.ScheduleFilterType.IsAssociatedWithGlobalParameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.IsAssociatedWithGlobalParameter`

#### Summary

The field is associated with a specified global parameter of a compatible type

### `F:Autodesk.Revit.DB.ScheduleFilterType.NotEndsWith`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.NotEndsWith`

#### Summary

For a string field, the field value does not end with the specified string.

### `F:Autodesk.Revit.DB.ScheduleFilterType.EndsWith`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.EndsWith`

#### Summary

For a string field, the field value ends with specified string.

### `F:Autodesk.Revit.DB.ScheduleFilterType.NotBeginsWith`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.NotBeginsWith`

#### Summary

For a string field, the field value does not begin with the specified string.

### `F:Autodesk.Revit.DB.ScheduleFilterType.BeginsWith`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.BeginsWith`

#### Summary

For a string field, the field value begins with the specified string.

### `F:Autodesk.Revit.DB.ScheduleFilterType.NotContains`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.NotContains`

#### Summary

For a string field, the field value does not contain the specified string.

### `F:Autodesk.Revit.DB.ScheduleFilterType.Contains`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.Contains`

#### Summary

For a string field, the field value contains the specified string.

### `F:Autodesk.Revit.DB.ScheduleFilterType.LessThanOrEqual`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.LessThanOrEqual`

#### Summary

The field value is less than or equal to the specified value.

### `F:Autodesk.Revit.DB.ScheduleFilterType.LessThan`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.LessThan`

#### Summary

Less The field value is less than to the specified value.

### `F:Autodesk.Revit.DB.ScheduleFilterType.GreaterThanOrEqual`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.GreaterThanOrEqual`

#### Summary

The field value is greater than or equal to the specified value.

### `F:Autodesk.Revit.DB.ScheduleFilterType.GreaterThan`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.GreaterThan`

#### Summary

The field value is greater than the specified value.

### `F:Autodesk.Revit.DB.ScheduleFilterType.NotEqual`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.NotEqual`

#### Summary

The field value is not equal to the specified value.

### `F:Autodesk.Revit.DB.ScheduleFilterType.Equal`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.Equal`

#### Summary

The field value is equal to the specified value.

### `F:Autodesk.Revit.DB.ScheduleFilterType.HasParameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.HasParameter`

#### Summary

The element has the parameter specified by the field. Used with shared parameters. No value is specified for this filter type.

### `F:Autodesk.Revit.DB.ScheduleFilterType.Invalid`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFilterType.Invalid`

#### Summary

An invalid filter. Do not use.

### `M:Autodesk.Revit.DB.ScheduleDefinition.IsSchedulableField(Autodesk.Revit.DB.SchedulableField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.IsSchedulableField(Autodesk.Revit.DB.SchedulableField)`

#### Summary

Checks whether a non-calculated/non-combined field is eligible to be included in
this schedule.

#### Parameter `schedulableField`

The field to check.

#### Returns

True if the field may be included in the schedule, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetSchedulableFields`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetSchedulableFields`

#### Summary

Gets a list of all non-calculated/non-combined fields that are eligible to be
included in this schedule.

#### Returns

A list of SchedulableField objects representing the non-calculated/non-combined
fields that may be included in the schedule.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.CanFilterByGlobalParameters(Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.CanFilterByGlobalParameters(Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Checks whether a field can be used with a global parameter-based filter.

#### Remarks

The global parameter-based filter types are IsAsociatedWith, IsNotAssociatedWith.

Only parameters which have a compatible type with at least one existing global parameter
can be filtered.

#### Parameter `fieldId`

The ID of the field to check.

#### Returns

True if the field can be used with a global parameter-based filter, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fieldId is not the ID of a field in this ScheduleDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.ScheduleDefinition.CanFilterBySubstring(Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.CanFilterBySubstring(Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Checks whether a field can be used with a substring-based filter.

#### Remarks

The substring-based filter types are Contains, NotContains,
BeginsWith, NonBeginsWith, EndsWith and NotEndsWith.

Only string parameters can be filtered by substring.

#### Parameter `fieldId`

The ID of the field to check.

#### Returns

True if the field can be used with a substring-based filter, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fieldId is not the ID of a field in this ScheduleDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.CanFilterByValuePresence(Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.CanFilterByValuePresence(Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Checks whether a field can be used with a value presence-based filter.

#### Remarks

The value presence filter types are HasValue and HasNoValue.

#### Parameter `fieldId`

The ID of the field to check.

#### Returns

True if the field can be used with a value presence filter, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fieldId is not the ID of a field in this ScheduleDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.ScheduleDefinition.CanFilterByValue(Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.CanFilterByValue(Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Checks whether a field can be used with a value-based filter.

#### Remarks

The value-based filter types are Equal, NotEqual,
GreaterThan, GreaterThanOrEqual, LessThan and LessThanOrEqual.

Only certain types of parameters can be filtered by value.

Note that some fields (for example, Workset, Family, Type, Family and Type)
only support Equal, NotEqual, but not GreaterThan, GreaterThanOrEqual, LessThan and LessThanOrEqual.

#### Parameter `fieldId`

The ID of the field to check.

#### Returns

True if the field can be used with a value based filter, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fieldId is not the ID of a field in this ScheduleDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.CanFilterByParameterExistence(Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.CanFilterByParameterExistence(Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Checks whether a field can be used with a HasParameter filter.

#### Remarks

The HasParameter filter type only supports shared parameters,
and only with the Instance or ElementType field types.

#### Parameter `fieldId`

The ID of the field to check.

#### Returns

True if the field can be used with a HasParameter filter, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fieldId is not the ID of a field in this ScheduleDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.CanFilter`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.CanFilter`

#### Summary

Checks whether filters can be added to this ScheduleDefinition.

#### Remarks

Key schedules and revision schedules do not support filters.

#### Returns

True if this ScheduleDefinition supports filters, false otherwise.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.SetFilters(System.Collections.Generic.IList{Autodesk.Revit.DB.ScheduleFilter})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.SetFilters(System.Collections.Generic.IList{Autodesk.Revit.DB.ScheduleFilter})`

#### Summary

Replaces all filters in this ScheduleDefinition.

#### Parameter `filters`

The new list of filters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The resulting filter count would be greater than 8.
-or-
A field ID is not the ID of a field in this ScheduleDefinition.
-or-
A field and filter type cannot be used to filter this ScheduleDefinition.
-or-
A filter value is not valid for the field and filter type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ScheduleDefinition does not support filters.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetFilters`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetFilters`

#### Summary

Gets all filters in this ScheduleDefinition.

#### Returns

A list of all filters.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.SetFilter(System.Int32,Autodesk.Revit.DB.ScheduleFilter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.SetFilter(System.Int32,Autodesk.Revit.DB.ScheduleFilter)`

#### Summary

Replaces a filter.

#### Parameter `index`

The index of the filter to replace.

#### Parameter `filter`

The new filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The field ID is not the ID of a field in this ScheduleDefinition.
-or-
The field and filter type cannot be used to filter this ScheduleDefinition.
-or-
The filter value is not valid for the field and filter type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid filter index.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ScheduleDefinition does not support filters.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetFilter(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetFilter(System.Int32)`

#### Summary

Gets a filter.

#### Parameter `index`

The index of the filter.

#### Returns

A copy of the filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid filter index.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.ClearFilters`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.ClearFilters`

#### Summary

Removes all filters.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ScheduleDefinition does not support filters.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.RemoveFilter(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.RemoveFilter(System.Int32)`

#### Summary

Removes a filter.

#### Parameter `index`

The index of the filter to remove.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid filter index.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ScheduleDefinition does not support filters.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.InsertFilter(Autodesk.Revit.DB.ScheduleFilter,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.InsertFilter(Autodesk.Revit.DB.ScheduleFilter,System.Int32)`

#### Summary

Adds a new filter at the specified position in the list.

#### Parameter `filter`

The filter to add.

#### Parameter `index`

The index in the list of filters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The field ID is not the ID of a field in this ScheduleDefinition.
-or-
The field and filter type cannot be used to filter this ScheduleDefinition.
-or-
The filter value is not valid for the field and filter type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid insert position.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ScheduleDefinition does not support filters.
-or-
The resulting filter count would be greater than 8.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.AddFilter(Autodesk.Revit.DB.ScheduleFilter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.AddFilter(Autodesk.Revit.DB.ScheduleFilter)`

#### Summary

Adds a new filter at the end of the list.

#### Parameter `filter`

The filter to add.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The field ID is not the ID of a field in this ScheduleDefinition.
-or-
The field and filter type cannot be used to filter this ScheduleDefinition.
-or-
The filter value is not valid for the field and filter type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ScheduleDefinition does not support filters.
-or-
The resulting filter count would be greater than 8.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetFilterCount`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetFilterCount`

#### Summary

Gets the number of filters in this ScheduleDefinition.

#### Returns

The number of filters.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.IsValidCategoryForFilterBySheet`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.IsValidCategoryForFilterBySheet`

#### Summary

Checks whether a schedule can be filtered by sheet.

#### Returns

True if the schedule can be filtered by sheet,
false otherwise.

#### Since

2023

### `M:Autodesk.Revit.DB.ScheduleDefinition.CanSortByField(Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.CanSortByField(Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Checks whether a field can be used for sorting/grouping.

#### Remarks

Schedules cannot be sorted/grouped by the Count field, Percentage
fields, or Formula fields that depend on Percentage fields because
those types of fields don't have meaningful values until after
sorting and grouping takes place.

#### Parameter `fieldId`

The ID of the field to check.

#### Returns

True if the field can be used for sorting/grouping, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fieldId is not the ID of a field in this ScheduleDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.SetSortGroupFields(System.Collections.Generic.IList{Autodesk.Revit.DB.ScheduleSortGroupField})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.SetSortGroupFields(System.Collections.Generic.IList{Autodesk.Revit.DB.ScheduleSortGroupField})`

#### Summary

Replaces all sorting/grouping fields in this ScheduleDefinition.

#### Parameter `sortGroupFields`

The new list of sorting/grouping fields.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The resulting sorting/grouping field count would be greater than 4.
-or-
A field ID is not the ID of a field in this ScheduleDefinition.
-or-
A field cannot be used for sorting/grouping.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetSortGroupFields`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetSortGroupFields`

#### Summary

Gets all sorting/grouping fields in this ScheduleDefinition.

#### Returns

A list of all sorting/grouping fields.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.SetSortGroupField(System.Int32,Autodesk.Revit.DB.ScheduleSortGroupField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.SetSortGroupField(System.Int32,Autodesk.Revit.DB.ScheduleSortGroupField)`

#### Summary

Replaces a sorting/grouping field.

#### Parameter `index`

The index of the sorting/grouping field to replace.

#### Parameter `sortGroupField`

The new sorting/grouping field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The field ID is not the ID of a field in this ScheduleDefinition.
-or-
The field cannot be used for sorting/grouping.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid sorting/grouping field index.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetSortGroupField(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetSortGroupField(System.Int32)`

#### Summary

Gets a sorting/grouping field.

#### Parameter `index`

The index of the sorting/grouping field.

#### Returns

A copy of the sorting/grouping field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid sorting/grouping field index.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.ClearSortGroupFields`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.ClearSortGroupFields`

#### Summary

Removes all sorting/grouping fields.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.RemoveSortGroupField(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.RemoveSortGroupField(System.Int32)`

#### Summary

Removes a sorting/grouping field.

#### Parameter `index`

The index of the sorting/grouping field to remove.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid sorting/grouping field index.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.InsertSortGroupField(Autodesk.Revit.DB.ScheduleSortGroupField,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.InsertSortGroupField(Autodesk.Revit.DB.ScheduleSortGroupField,System.Int32)`

#### Summary

Adds a new sorting/grouping field at the specified position in the list.

#### Parameter `sortGroupField`

The sorting/grouping field to add.

#### Parameter `index`

The index in the list of sorting/grouping fields.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The field ID is not the ID of a field in this ScheduleDefinition.
-or-
The field cannot be used for sorting/grouping.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid insert position.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The resulting sorting/grouping field count would be greater than 4.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.AddSortGroupField(Autodesk.Revit.DB.ScheduleSortGroupField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.AddSortGroupField(Autodesk.Revit.DB.ScheduleSortGroupField)`

#### Summary

Adds a new sorting/grouping field at the end of the list.

#### Parameter `sortGroupField`

The sorting/grouping field to add.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The field ID is not the ID of a field in this ScheduleDefinition.
-or-
The field cannot be used for sorting/grouping.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The resulting sorting/grouping field count would be greater than 4.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetSortGroupFieldCount`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetSortGroupFieldCount`

#### Summary

Gets the number of sorting/grouping fields in this ScheduleDefinition.

#### Returns

The number of sorting/grouping fields.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.IsValidFieldId(Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.IsValidFieldId(Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Checks whether a ScheduleFieldId is the ID of a field in this ScheduleDefinition.

#### Parameter `fieldId`

The field ID to check.

#### Returns

True if the field ID is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.IsValidFieldIndex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.IsValidFieldIndex(System.Int32)`

#### Summary

Checks whether an integer is a valid zero-based field index in this ScheduleDefinition.

#### Parameter `index`

The field index to check.

#### Returns

True if the field index is valid, false otherwise.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetFieldIndex(Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetFieldIndex(Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Converts a field ID to the corresponding field index.

#### Parameter `fieldId`

The field ID.

#### Returns

The field index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fieldId is not the ID of a field in this ScheduleDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetFieldId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetFieldId(System.Int32)`

#### Summary

Converts a field index to the corresponding field ID.

#### Parameter `index`

The field index.

#### Returns

The field ID.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid field index in this ScheduleDefinition.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.SetFieldOrder(System.Collections.Generic.IList{Autodesk.Revit.DB.ScheduleFieldId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.SetFieldOrder(System.Collections.Generic.IList{Autodesk.Revit.DB.ScheduleFieldId})`

#### Summary

Reorders the fields in the schedule.

#### Parameter `fieldIds`

The field IDs in a new order.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fieldIds does not contain exactly the same field IDs as this ScheduleDefinition currently contains.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetFieldOrder`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetFieldOrder`

#### Summary

Gets the IDs of the current list of fields in order.

#### Returns

The IDs of the current list of fields.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetField(Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetField(Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Gets a field.

#### Parameter `fieldId`

The ID of the field.

#### Returns

The field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fieldId is not the ID of a field in this ScheduleDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetField(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetField(System.Int32)`

#### Summary

Gets a field.

#### Parameter `index`

The index of the field.

#### Returns

The field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid field index in this ScheduleDefinition.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.ClearFields`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.ClearFields`

#### Summary

Removes all fields.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.RemoveField(Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.RemoveField(Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Removes a field.

#### Parameter `fieldId`

The ID of the field to remove.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fieldId is not the ID of a field in this ScheduleDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.RemoveField(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.RemoveField(System.Int32)`

#### Summary

Removes a field.

#### Parameter `index`

The index of the field to remove.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid field index in this ScheduleDefinition.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.InsertCombinedParameterField(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData},System.String,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.InsertCombinedParameterField(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData},System.String,System.Int32)`

#### Summary

Adds a combined parameter field at the specified position in the list.

#### Parameter `data`

The combined parameters array.

#### Parameter `fieldName`

The field name.

#### Parameter `index`

The index in the list of fields.

#### Returns

The new field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid insert position.

#### Since

2017

### `M:Autodesk.Revit.DB.ScheduleDefinition.IsValidCombinedParameters(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.IsValidCombinedParameters(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

#### Summary

Checks if data is valid for combined parameters

#### Parameter `data`

data is array of TableCellCombinedParameterData to be set as combined parameters

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.ScheduleDefinition.InsertField(Autodesk.Revit.DB.ScheduleFieldType,Autodesk.Revit.DB.ElementId,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.InsertField(Autodesk.Revit.DB.ScheduleFieldType,Autodesk.Revit.DB.ElementId,System.Int32)`

#### Summary

Adds a regular field at the specified position in the list.

#### Parameter `fieldType`

The type of data displayed by the field.

#### Parameter `parameterId`

The ID of the parameter displayed by the field.

#### Parameter `index`

The index in the list of fields.

#### Returns

The new field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid insert position.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The field specified by fieldType and parameterId may not included in this ScheduleDefinition.
-or-
The field specified by fieldType and parameterId is already included in this ScheduleDefinition.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.InsertField(Autodesk.Revit.DB.ScheduleFieldType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.InsertField(Autodesk.Revit.DB.ScheduleFieldType,System.Int32)`

#### Summary

Adds a regular field at the specified position in the list.

#### Parameter `fieldType`

The type of data displayed by the field.

#### Parameter `index`

The index in the list of fields.

#### Returns

The new field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The field specified by fieldType may not included in this ScheduleDefinition.
-or-
The field specified by fieldType is already included in this ScheduleDefinition.
-or-
The fieldType can't be CustomField. To add a CustomField, you should create a Schedulable field and add it.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid insert position.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.InsertField(Autodesk.Revit.DB.SchedulableField,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.InsertField(Autodesk.Revit.DB.SchedulableField,System.Int32)`

#### Summary

Adds a regular field at the specified position in the list.

#### Parameter `schedulableField`

A SchedulableField object representing the field.

#### Parameter `index`

The index in the list of fields.

#### Returns

The new field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The field specified by schedulableField may not included in this ScheduleDefinition.
-or-
The field specified by schedulableField is already included in this ScheduleDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not a valid insert position.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.AddField(Autodesk.Revit.DB.ScheduleFieldType,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.AddField(Autodesk.Revit.DB.ScheduleFieldType,Autodesk.Revit.DB.ElementId)`

#### Summary

Adds a regular field at the end of the list.

#### Parameter `fieldType`

The type of data displayed by the field.

#### Parameter `parameterId`

The ID of the parameter displayed by the field.

#### Returns

The new field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The field specified by fieldType and parameterId may not included in this ScheduleDefinition.
-or-
The field specified by fieldType and parameterId is already included in this ScheduleDefinition.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.AddField(Autodesk.Revit.DB.ScheduleFieldType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.AddField(Autodesk.Revit.DB.ScheduleFieldType)`

#### Summary

Adds a regular field at the end of the list.

#### Parameter `fieldType`

The type of data displayed by the field.

#### Returns

The new field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The field specified by fieldType may not included in this ScheduleDefinition.
-or-
The field specified by fieldType is already included in this ScheduleDefinition.
-or-
The fieldType can't be CustomField. To add a CustomField, you should create a Schedulable field and add it.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.AddField(Autodesk.Revit.DB.SchedulableField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.AddField(Autodesk.Revit.DB.SchedulableField)`

#### Summary

Adds a regular field at the end of the list.

#### Parameter `schedulableField`

A SchedulableField object representing the field.

#### Returns

The new field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The field specified by schedulableField may not included in this ScheduleDefinition.
-or-
The field specified by schedulableField is already included in this ScheduleDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetFieldCount`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetFieldCount`

#### Summary

Gets the number of fields in this ScheduleDefinition.

#### Returns

The number of fields.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.GetValidCategoriesForEmbeddedSchedule`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GetValidCategoriesForEmbeddedSchedule`

#### Summary

Get all categories that can be used for an embedded ScheduleDefinition
in this ScheduleDefinition.

#### Returns

The IDs of all valid categories.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.IsValidCategoryForEmbeddedSchedule(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.IsValidCategoryForEmbeddedSchedule(Autodesk.Revit.DB.ElementId)`

#### Summary

Indicates if a category can be used for an embedded ScheduleDefinition
in this ScheduleDefinition.

#### Parameter `categoryId`

The category ID to check.

#### Returns

True if the category can be used for an embedded ScheduleDefinition,
false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.CanHaveEmbeddedSchedule`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.CanHaveEmbeddedSchedule`

#### Summary

Indicates if this ScheduleDefinition can have an embedded ScheduleDefinition
added.

#### Remarks

Only schedules of the following categories can have an embedded
ScheduleDefinition:

Rooms

Spaces

Electrical Circuits

Duct Systems

Piping Systems

Mechanical Equipment Sets

MEP Fabrication Ductwork

Fabrication Ductwork Stiffeners

Key schedules cannot have embedded schedules.

#### Returns

True if this ScheduleDefinition can have an embedded ScheduleDefinition,
false otherwise.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.RemoveEmbeddedSchedule`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.RemoveEmbeddedSchedule`

#### Summary

Removes the embedded ScheduleDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ScheduleDefinition does not have an embedded ScheduleDefinition.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.AddEmbeddedSchedule(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.AddEmbeddedSchedule(Autodesk.Revit.DB.ElementId)`

#### Summary

Adds an embedded ScheduleDefinition.

#### Parameter `categoryId`

The category ID of elements to display in the embedded schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

categoryId is not the ID of a category that can be used for an embedded
ScheduleDefinition in this ScheduleDefinition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ScheduleDefinition is not a kind of schedule that supports adding an embedded
ScheduleDefinition.
-or-
This ScheduleDefinition already has an embedded ScheduleDefinition.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleDefinition.CanIncludeLinkedFiles`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.CanIncludeLinkedFiles`

#### Summary

Checks whether the schedule is a type that supports
including elements from linked files.

#### Remarks

Elements from linked files can be included in schedules of normal
model elements and in sheet lists, but not in most other specialized
kinds of schedules.

#### Returns

True if elements from linked files can be included, false otherwise.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleDefinition.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ScheduleDefinition.IsFilteredBySheet`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.IsFilteredBySheet`

#### Summary

Indicates if the schedule is set to filter by sheet.

#### Remarks

If the schedule is set to filter by sheet, and it is placed on a particular sheet, the
instance created will present only the elements visible in the Viewport(s) on that sheet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The schedule category is not supported to use filter by sheet.
-or-
When setting this property: The Schedule is split already.

#### Since

2023

### `P:Autodesk.Revit.DB.ScheduleDefinition.ShowGridLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.ShowGridLines`

#### Summary

Indicates if the schedule grid lines will be visible on a sheet.

#### Since

2019.2

### `P:Autodesk.Revit.DB.ScheduleDefinition.ShowHeaders`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.ShowHeaders`

#### Summary

Indicates if the headers will be displayed in the schedule.

#### Since

2015 Subscription Update

### `P:Autodesk.Revit.DB.ScheduleDefinition.ShowTitle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.ShowTitle`

#### Summary

Indicates if the title will be displayed in the schedule.

#### Since

2015 Subscription Update

### `P:Autodesk.Revit.DB.ScheduleDefinition.GrandTotalTitle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.GrandTotalTitle`

#### Summary

The title name is used to display at the grand total row. The name is "Grand total", expressed in the Revit session language, by default.

#### Remarks

GrandTotalTitle can only be set when both ShowGrandTotal and ShowGrandTotalTitle are enabled.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Display of a grand total row is not enabled.
-or-
When setting this property: Display of grand total title is not enabled.

#### Since

2015

### `P:Autodesk.Revit.DB.ScheduleDefinition.ShowGrandTotalCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.ShowGrandTotalCount`

#### Summary

Indicates if the grand total row should display a count of elements
in the schedule.

#### Remarks

ShowGrandTotalCount can only be enabled if ShowGrandTotal is enabled.

#### Value

True if an element count should be displayed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Display of a grand total row is not enabled.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleDefinition.ShowGrandTotalTitle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.ShowGrandTotalTitle`

#### Summary

Indicates if the grand total row should display a title.

#### Remarks

The title consists of the text "Grand total".

ShowGrandTotalTitle can only be enabled if ShowGrandTotal
is enabled.

#### Value

True if a title should be displayed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Display of a grand total row is not enabled.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleDefinition.ShowGrandTotal`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.ShowGrandTotal`

#### Summary

Indicates if a grand total row should be displayed at the bottom of
the schedule.

#### Remarks

The grand total row displays totals of each field for which
totals are enabled. It can also optionally display a title
(see ShowGrandTotalTitle) and a count of elements
(see ShowGrandTotalCount).

#### Value

True if a grand total row should be displayed, false otherwise.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleDefinition.IsEmbedded`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.IsEmbedded`

#### Summary

Indicates if this is an embedded ScheduleDefinition.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleDefinition.HasEmbeddedSchedule`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.HasEmbeddedSchedule`

#### Summary

Indicates if this ScheduleDefinition has an embedded ScheduleDefinition.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleDefinition.EmbeddedDefinition`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.EmbeddedDefinition`

#### Summary

The embedded ScheduleDefinition.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleDefinition.IsItemized`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.IsItemized`

#### Summary

Indicates if the schedule displays each element on a separate row or
combines multiple grouped elements onto the same row.

#### Remarks

In an itemized schedule, each scheduled element is displayed on
a separate row.

In a non-itemized schedule, elements that are grouped together
according to the schedule's grouping criteria are combined onto a
single row. For example, if a schedule is grouped by Level and Type,
elements having the same Level and Type will appear on the same row.
In non-itemized schedules, the Count field can be used to display
the number of elements on the row, and totaled fields will display
the sum of the values from all elements on the row. If a field is
not totaled and the elements on the row have different values for
the field, an empty cell will be displayed.

#### Value

True if the schedule displays each element on a separate row. False
if multiple grouped elements are combined on the same row.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This ScheduleDefinition is a key schedule.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleDefinition.IncludeLinkedFiles`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.IncludeLinkedFiles`

#### Summary

Indicates if the schedule includes elements from linked files.

#### Remarks

For an embedded ScheduleDefinition, this setting is controlled
by the primary ScheduleDefinition and cannot be set in the embedded
ScheduleDefinition.

#### Value

True if elements in linked files should be included, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This ScheduleDefinition does not support including elements from linked files.
-or-
When setting this property: This ScheduleDefinition is an embedded ScheduleDefinition.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleDefinition.IsMaterialTakeoff`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.IsMaterialTakeoff`

#### Summary

Indicates if the schedule is a material takeoff.

#### Remarks

A material takeoff is a schedule that displays information about
the materials that make up elements in the model. Unlike regular
schedules where each row (before grouping) represents a single
element, each row in a material takeoff represents a single
<element, material> pair.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleDefinition.IsKeySchedule`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.IsKeySchedule`

#### Summary

Indicates if the schedule is a key schedule.

#### Remarks

A key schedule displays abstract "key" elements that can be used to
populate parameters of ordinary model elements.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleDefinition.FamilyId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.FamilyId`

#### Summary

In a note block schedule, the ID of the Generic Annotation family
displayed by the schedule.

#### Remarks

A note block is a schedule of the Generic Annotations category
that shows elements of a single family rather than all elements
in the category.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleDefinition.AreaSchemeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.AreaSchemeId`

#### Summary

In an area schedule, the ID of the area scheme to display.

#### Remarks

Schedules of the Areas category show area elements belonging to a single
area scheme.

Key schedules of the Areas category apply to all area schemes, so they
don't have an area scheme ID.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleDefinition.CategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleDefinition.CategoryId`

#### Summary

The category ID of elements appearing in the schedule.

#### Remarks

Most schedules show elements of a single category. In multi-category
schedules, the category ID is InvalidElementId. In key schedules,
the schedule's category is the category of elements that the keys are
associated with.

#### Since

2013

### `T:Autodesk.Revit.DB.ScheduleDefinition`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleDefinition`

#### Summary

Settings that define the contents of a schedule.

#### Remarks

The ScheduleDefinition class contains various settings that
define the contents of a schedule view, including:

The schedule's category and other basic properties that determine the type of schedule.

A set of fields that become the columns of the schedule.

Filters that restrict the set of elements visible in the schedule.

Sorting and grouping criteria.

Most schedules contain a single ScheduleDefinition. In Revit MEP,
schedules of certain categories can contain an "embedded schedule" containing
elements associated with the elements in the primary schedule, for example a
room schedule showing the elements inside each room or a duct system schedule
showing the elements associated with each system. An embedded schedule has
its own category, fields, filters, etc. Those settings are stored in a
second ScheduleDefinition object.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleField.IsCustomFieldWithValidServer`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.IsCustomFieldWithValidServer`

#### Summary

Identifies if this is a `F:Autodesk.Revit.DB.ScheduleFieldType.CustomField`
and if there is added an instance of a `T:Autodesk.Revit.DB.ICustomFieldServer` to the custom field service.

#### Returns

Returns true if this is a `F:Autodesk.Revit.DB.ScheduleFieldType.CustomField`
and if there is added an instance of a `T:Autodesk.Revit.DB.ICustomFieldServer` to the custom field service.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleField.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.GetName`

#### Summary

Gets the name of the field.

#### Returns

The name of the field.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleField.GetSchedulableField`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.GetSchedulableField`

#### Summary

Gets a SchedulableField object representing this field.

#### Remarks

A ScheduleableField cannot be obtained for:
- Calculated fields
- Combined parameters

#### Returns

The SchedulableField object.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This ScheduleField is not a schedulable field by type(non-calculated/non-combined-parameter).

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleField.GetSpecTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.GetSpecTypeId`

#### Summary

The spec describing values of this field, if applicable.

#### Returns

Identifier of the spec, or empty if the field does not represent a number with units.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleField.SetFormatOptions(Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.SetFormatOptions(Autodesk.Revit.DB.FormatOptions)`

#### Summary

Sets the FormatOptions to optionally override the default settings in the Units class.

#### Remarks

See the UnitType property to determine the unit type of this field.

#### Parameter `formatOptions`

The FormatOptions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The display unit in formatOptions is not a valid display unit for the unit type of this ScheduleField, or the rounding method in formatOptions is not set to Nearest. See UnitUtils.IsValidDisplayUnit(UnitType, DisplayUnitType), UnitUtils.GetValidDisplayUnits(UnitType) and FormatOptions.RoundingMethod.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ScheduleField.GetFormatOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.GetFormatOptions`

#### Summary

Gets the FormatOptions to optionally override the default settings in the Units class.

#### Returns

A copy of the FormatOptions.

#### Since

2014

### `M:Autodesk.Revit.DB.ScheduleField.ResetOverride`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.ResetOverride`

#### Summary

Resets the override of this field.

#### Since

2014

### `M:Autodesk.Revit.DB.ScheduleField.SetStyle(Autodesk.Revit.DB.TableCellStyle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.SetStyle(Autodesk.Revit.DB.TableCellStyle)`

#### Summary

Sets the style of this field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ScheduleField.GetStyle`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.GetStyle`

#### Summary

Gets the style of this field.

#### Since

2014

### `M:Autodesk.Revit.DB.ScheduleField.CanDisplayMinMax`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.CanDisplayMinMax`

#### Summary

Indicates if this field can display minimum and maximum values.

#### Returns

True if this field can display minimum and maximum values, false otherwise.

#### Since

2017

### `M:Autodesk.Revit.DB.ScheduleField.CanTotalByAssemblyType`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.CanTotalByAssemblyType`

#### Summary

Indicates if totals by assembly type can be enabled for this field.

#### Returns

True if this field can be totaled by assembly type, false otherwise.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleField.CanTotal`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.CanTotal`

#### Summary

Indicates if totals can be enabled for this field.

#### Returns

True if this field can be totaled, false otherwise.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleField.CreatesCircularReferences(Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.CreatesCircularReferences(Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Checks whether a field ID would create a circular chain of references
when used by the PercentageOf property of this field.

#### Parameter `fieldId`

The field ID to check.

#### Returns

True if the field ID would create a circular chain of references,
false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fieldId is not InvalidScheduleFieldId or the ID of a field that can be
used to calculated percentages.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleField.SetCombinedParameters(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.SetCombinedParameters(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

#### Summary

Sets this field's combine parameter array if applicable

#### Parameter `data`

data is array of TableCellCombinedParameterData to be set as combined parameters

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.ScheduleField.GetCombinedParameters`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.GetCombinedParameters`

#### Summary

Gets this field's combine parameter array if applicable

#### Returns

Gets array of TableCellCombinedParameterData with the combined parameters data

#### Since

2017

### `M:Autodesk.Revit.DB.ScheduleField.IsValidCombinedParameters(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.IsValidCombinedParameters(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

#### Summary

Checks if data is valid for combined parameters

#### Parameter `data`

data is array of TableCellCombinedParameterData to be set as combined parameters

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.ScheduleField.GetCustomFieldData`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleField.GetCustomFieldData`

#### Summary

Gets the data associated with this custom field. If this field isn't a `F:Autodesk.Revit.DB.ScheduleFieldType.CustomField` will return `null` .

#### Returns

Returns the data associated with this custom field. If this field isn't a `F:Autodesk.Revit.DB.ScheduleFieldType.CustomField` will return `null` .

#### Since

2024

### `P:Autodesk.Revit.DB.ScheduleField.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ScheduleField.FieldIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.FieldIndex`

#### Summary

The index of the field in the containing ScheduleDefinition.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.FieldId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.FieldId`

#### Summary

The ID of the field in the containing ScheduleDefinition.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.Definition`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.Definition`

#### Summary

The ScheduleDefinition that this field belongs to.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.Schedule`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.Schedule`

#### Summary

The schedule that this field belongs to.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.HasSchedulableField`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.HasSchedulableField`

#### Summary

Identifies if this ScheduleField object has access to a SchedulableField.
Calculated and combined parameter fields will not have the access.

#### Since

2014

### `P:Autodesk.Revit.DB.ScheduleField.IsCombinedParameterField`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.IsCombinedParameterField`

#### Summary

Indicates if the field is a combined parameter field.

#### Since

2017

### `P:Autodesk.Revit.DB.ScheduleField.IsCalculatedField`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.IsCalculatedField`

#### Summary

Indicates if the field is a calculated field (Formula or Percentage).

#### Since

2014

### `P:Autodesk.Revit.DB.ScheduleField.MultipleValuesCustomText`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.MultipleValuesCustomText`

#### Summary

The custom multiple values text to be used when the schedule field displays multiple element values,
used when `P:Autodesk.Revit.DB.ScheduleField.MultipleValuesDisplayType` is set to `F:Autodesk.Revit.DB.ScheduleFieldMultipleValuesDisplayType.Custom` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.ScheduleField.MultipleValuesText`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.MultipleValuesText`

#### Summary

The multiple values text to be used when the schedule field displays multiple element values,
as specified by the display type `P:Autodesk.Revit.DB.ScheduleField.MultipleValuesDisplayType` .

#### Since

2022

### `P:Autodesk.Revit.DB.ScheduleField.MultipleValuesDisplayType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.MultipleValuesDisplayType`

#### Summary

Determines the type of multiple value indication to be used
when the schedule field displays multiple element values.

#### Remarks

The default display type is `F:Autodesk.Revit.DB.ScheduleFieldMultipleValuesDisplayType.Project` ,
indicating that the project `!:Autodesk::Revit::DB::MultipleValuesIndicationSettings::Value` setting will be used.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `P:Autodesk.Revit.DB.ScheduleField.GridColumnWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.GridColumnWidth`

#### Summary

The width of the column in the editable grid view, measured in feet.

#### Remarks

In a schedule with an embedded ScheduleDefinition, a column may
display two fields, one from each ScheduleDefinition. In that case,
the larger of the two widths is used.

It is always aligned with the SheetColumnWidth.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: gridColumnWidth is negative.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.SheetColumnWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.SheetColumnWidth`

#### Summary

The width of the column on a sheet, measured in feet.

#### Remarks

In a schedule with an embedded ScheduleDefinition, a column may
display two fields, one from each ScheduleDefinition. In that case,
the larger of the two widths is used.

It is always aligned with the GridColumnWidth.

#### Value

The width of the column.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: sheetColumnWidth is negative.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.IsOverridden`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.IsOverridden`

#### Summary

Indicates if the field is overridden or not.

#### Since

2014

### `P:Autodesk.Revit.DB.ScheduleField.HeadingOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.HeadingOrientation`

#### Summary

The orientation of the column heading text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.VerticalAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.VerticalAlignment`

#### Summary

The vertical alignment of the column's data.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.ScheduleField.HorizontalAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.HorizontalAlignment`

#### Summary

The horizontal alignment of the column's data.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.DisplayType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.DisplayType`

#### Summary

Indicates the chosen display type for the field.

#### Remarks

This replaces the hasTotals property from 2017.
The hasTotals = true is same as DisplayType::Totals;
hasTotals = false is the same as DisplayType::Standard.
This also adds the ability to see Min/Max for grouped elements.

#### Value

The display types are:
Standard - standard display type; will not display anything for multiple elements with different values.
Totals - In a non-itemized schedule,
totals are displayed in regular rows when multiple elements appear on the same row.
Min - In a non-itemized schedule,
minimum value is displayed in regular rows when multiple elements appear on the same row.
Max - In a non-itemized schedule,
maximum value is displayed in regular rows when multiple elements appear on the same row.
MinMax - In a non-itemized schedule,
Minimum/Maximum values are displayed in regular rows when multiple elements appear on the same row.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This ScheduleField cannot display minimum and maximum values.
-or-
When setting this property: This ScheduleField cannot be totaled.

#### Since

2017

### `P:Autodesk.Revit.DB.ScheduleField.TotalByAssemblyType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.TotalByAssemblyType`

#### Summary

In an assembly schedule view, indicates if totals are calculated for all
assembly instances of the same type or only for a single instance.

#### Value

True if totals are calculated for all assembly instances. False if totals
are calculated for one instance.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This ScheduleField cannot be totaled by assembly type.
-or-
When setting this property: Totals are not enabled for this ScheduleField.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.ColumnHeading`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.ColumnHeading`

#### Summary

The column heading text.

#### Remarks

On initial creation of a ScheduleField, the column heading is
initialized based on the field name (typically a parameter name).

#### Value

The heading text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.IsHidden`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.IsHidden`

#### Summary

Indicates if the field is hidden in the schedule.

#### Remarks

A hidden field is not displayed in the schedule, but it can be used for
filtering, sorting, grouping, and conditional formatting and can be
referenced by Formula and Percentage fields.

#### Value

True if the field is hidden, false otherwise.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.PercentageBy`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.PercentageBy`

#### Summary

The ID of the grouped schedule field used to calculate percentage totals.

#### Remarks

A Percentage field calculates what percent of the total of another field
each element represents. If PercentageBy is InvalidScheduleFieldId,
the total is of all elements in the schedule. If PercentageBy is the
ID of one of the fields that the schedule is grouped by, the total is
of all elements in that group.

#### Value

InvalidElementId or the ID of the grouped field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: percentageBy is not InvalidScheduleFieldId or the ID of a field that the
schedule is grouped by.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This ScheduleField is not a percentage field.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.PercentageOf`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.PercentageOf`

#### Summary

The ID of the field to calculate percentages of.

#### Remarks

A Percentage field calculates what percent of the total of another field
each element represents. PercentageOf is the ID of the field used to
calculate percentages. If PercentageOf is InvalidScheduleFieldId,
no data is displayed.

Percentages can only be calculated for numeric fields. The Count
field and other percentage fields cannot be used to calculate percentages.

#### Value

The ID of the field, or InvalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: percentageOf is not InvalidScheduleFieldId or the ID of a field that can be
used to calculated percentages.
-or-
When setting this property: percentageOf would create a circular chain of references.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This ScheduleField is not a percentage field.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.ParameterId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.ParameterId`

#### Summary

The ID of the parameter displayed by the field.

#### Remarks

Most field types require a parameter ID. Count, Formula, and Percentage
fields don't have parameter IDs.

#### Since

2013

### `P:Autodesk.Revit.DB.ScheduleField.FieldType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleField.FieldType`

#### Summary

The type of data displayed by the field.

#### Since

2013

### `T:Autodesk.Revit.DB.ScheduleField`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleField`

#### Summary

A field in a schedule.

#### Remarks

The ScheduleField class represents a single field in a ScheduleDefinition's
list of fields. Each (non-hidden) field becomes a column in the schedule.

Most commonly, a field represents an instance or type parameter of
elements appearing in the schedule. Some fields represent parameters
of other related elements, like the room that a scheduled element belongs to.
Fields can also represent data calculated from other fields in the schedule,
specifically Formula and Percentage fields.
Another type of field is Custom Field. For this one, the value for each row is
computed based on the (sub)elements that are grouped on that row and can have a
graphic representation when the schedule is placed on a sheet.

#### Since

2013

### `T:Autodesk.Revit.DB.ScheduleVerticalAlignment`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleVerticalAlignment`

#### Summary

Vertical alignment of data in a schedule.

#### Since

2024

#### Since

2024

### `F:Autodesk.Revit.DB.ScheduleVerticalAlignment.Bottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleVerticalAlignment.Bottom`

#### Summary

Bottom aligned

### `F:Autodesk.Revit.DB.ScheduleVerticalAlignment.Middle`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleVerticalAlignment.Middle`

#### Summary

Middle aligned

### `F:Autodesk.Revit.DB.ScheduleVerticalAlignment.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleVerticalAlignment.Top`

#### Summary

Top aligned

### `T:Autodesk.Revit.DB.ScheduleHorizontalAlignment`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleHorizontalAlignment`

#### Summary

Horizontal alignment of data in a schedule.

#### Since

2013

#### Since

2013

### `F:Autodesk.Revit.DB.ScheduleHorizontalAlignment.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleHorizontalAlignment.Right`

#### Summary

Right aligned

### `F:Autodesk.Revit.DB.ScheduleHorizontalAlignment.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleHorizontalAlignment.Center`

#### Summary

Center aligned

### `F:Autodesk.Revit.DB.ScheduleHorizontalAlignment.Left`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleHorizontalAlignment.Left`

#### Summary

Left aligned

### `T:Autodesk.Revit.DB.ScheduleHeadingOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleHeadingOrientation`

#### Summary

Orientation of schedule heading.

#### Since

2013

#### Since

2013

### `F:Autodesk.Revit.DB.ScheduleHeadingOrientation.Vertical`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleHeadingOrientation.Vertical`

#### Summary

Vertical

### `F:Autodesk.Revit.DB.ScheduleHeadingOrientation.Horizontal`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleHeadingOrientation.Horizontal`

#### Summary

Horizontal

### `T:Autodesk.Revit.DB.ScheduleFieldMultipleValuesDisplayType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleFieldMultipleValuesDisplayType`

#### Summary

Define how the schedule field's multiple value is displayed.

#### Since

2022

### `F:Autodesk.Revit.DB.ScheduleFieldMultipleValuesDisplayType.Custom`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldMultipleValuesDisplayType.Custom`

#### Summary

Display custom text per `!:Autodesk::Revit::DB::ScheduleField` instance,
as defined by the `!:Autodesk::Revit::DB::ScheduleField::MultipleValuesCustomText` property.

### `F:Autodesk.Revit.DB.ScheduleFieldMultipleValuesDisplayType.Varies`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldMultipleValuesDisplayType.Varies`

#### Summary

Display a standard hardcoded text, translated for the active locale.

### `F:Autodesk.Revit.DB.ScheduleFieldMultipleValuesDisplayType.Project`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldMultipleValuesDisplayType.Project`

#### Summary

Display the project setting `!:Autodesk::Revit::DB::MultipleValuesIndicationSettings::Value` .

### `T:Autodesk.Revit.DB.ScheduleFieldDisplayType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleFieldDisplayType`

#### Summary

Display type of schedule field.

#### Since

2017

#### Since

2017

### `F:Autodesk.Revit.DB.ScheduleFieldDisplayType.Min`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldDisplayType.Min`

#### Summary

Calculates and displays the minimum value

### `F:Autodesk.Revit.DB.ScheduleFieldDisplayType.Max`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldDisplayType.Max`

#### Summary

Calculates and displays the maximum value

### `F:Autodesk.Revit.DB.ScheduleFieldDisplayType.MinMax`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldDisplayType.MinMax`

#### Summary

Calculates and displays the minimum and maximum values

### `F:Autodesk.Revit.DB.ScheduleFieldDisplayType.Totals`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldDisplayType.Totals`

#### Summary

Calculates and displays the total value

### `F:Autodesk.Revit.DB.ScheduleFieldDisplayType.Standard`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldDisplayType.Standard`

#### Summary

Standard: field setting for `!:Autodesk::Revit::DB::ScheduleField::MultipleValuesText` is displayed if the values of the elements are different, otherwise, the common value will be displayed

### `M:Autodesk.Revit.DB.CustomFieldData.GetApplicableCategories`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldData.GetApplicableCategories`

#### Summary

Gets the category ids for which this field can be added to the schedule.

#### Returns

Returns the category ids for which this field can be added to the schedule.

#### Since

2024

### `M:Autodesk.Revit.DB.CustomFieldData.GetSpecTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldData.GetSpecTypeId`

#### Summary

Gets the spec describing the data type.

#### Returns

Returns the spec describing the data type.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There should be added an instance of ICustomFieldServer with the stored server id.

#### Since

2024

### `M:Autodesk.Revit.DB.CustomFieldData.IsCustomFieldServerValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldData.IsCustomFieldServerValid`

#### Summary

Identifies if there is added to the CustomFieldService an instance of `T:Autodesk.Revit.DB.ICustomFieldServer` with the stored server id.

#### Returns

Returns true if there is added a `T:Autodesk.Revit.DB.ICustomFieldServer` with the stored server id, false otherwise.

#### Since

2024

### `M:Autodesk.Revit.DB.CustomFieldData.ValidateCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldData.ValidateCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties)`

#### Summary

Validates the custom field properties.

#### Parameter `customFieldProperties`

An instance of `T:Autodesk.Revit.DB.ICustomFieldProperties` which represents the properties of this field.

#### Returns

If the properties are valid, an empty string will be returned.
If the properties are not valid, a non-empty string which describes the error will be returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Can't validate the properties of a CustomFieldData of a SchedulableField (which is not added to a schedule).

#### Since

2024

### `M:Autodesk.Revit.DB.CustomFieldData.SetCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldData.SetCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties)`

#### Summary

Sets an instance of `T:Autodesk.Revit.DB.ICustomFieldProperties` which represents the properties of this field.

#### Parameter `customFieldProperties`

An instance of `T:Autodesk.Revit.DB.ICustomFieldProperties` which represents the properties of this field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input properties are not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Can't set the properties to a CustomFieldData of a SchedulableField (which is not added to a schedule).

#### Since

2024

### `M:Autodesk.Revit.DB.CustomFieldData.GetCustomFieldProperties`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldData.GetCustomFieldProperties`

#### Summary

Gets an instance of `T:Autodesk.Revit.DB.ICustomFieldProperties` which represents the properties of this field.

#### Returns

Returns an instance of `T:Autodesk.Revit.DB.ICustomFieldProperties` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Can't obtain the properties from a CustomFieldData of a SchedulableField (which is not added to a schedule).

#### Since

2024

### `M:Autodesk.Revit.DB.CustomFieldData.GetCustomFieldId`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldData.GetCustomFieldId`

#### Summary

Gets an unique identifier of the custom field.

#### Returns

Returns an unique identifier of type of custom field.

#### Since

2024

### `P:Autodesk.Revit.DB.CustomFieldData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.CustomFieldData.DefaultRowHeightOnSheet`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldData.DefaultRowHeightOnSheet`

#### Summary

Identifies the default row height for this field.

#### Since

2024

### `P:Autodesk.Revit.DB.CustomFieldData.FieldName`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldData.FieldName`

#### Summary

The name of this custom field.

#### Since

2024

### `P:Autodesk.Revit.DB.CustomFieldData.FieldTooltip`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldData.FieldTooltip`

#### Summary

The tooltip that will be shown in the schedule properties dialog for this custom field.

#### Since

2024

### `P:Autodesk.Revit.DB.CustomFieldData.DefaultVerticalAlignmentStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldData.DefaultVerticalAlignmentStyle`

#### Summary

Identifies the default vertical alignment style.
The default alignment styles are used only if `P:Autodesk.Revit.DB.CustomFieldData.HasCustomGraphicRepresentationOnSheet` is true.

#### Since

2024

### `P:Autodesk.Revit.DB.CustomFieldData.DefaultHorizontalAlignmentStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldData.DefaultHorizontalAlignmentStyle`

#### Summary

Identifies the default horizontal alignment style.
The default alignment styles are used only if `P:Autodesk.Revit.DB.CustomFieldData.HasCustomGraphicRepresentationOnSheet` is true.

#### Since

2024

### `P:Autodesk.Revit.DB.CustomFieldData.HasCustomGraphicRepresentationOnSheet`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldData.HasCustomGraphicRepresentationOnSheet`

#### Summary

Identifies if the field has a custom representation when we have a schedule instance placed on the sheet or if its value will be shown as text.

#### Since

2024

### `P:Autodesk.Revit.DB.CustomFieldData.StorageType`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldData.StorageType`

#### Summary

Identifies the storage type.

#### Since

2024

### `T:Autodesk.Revit.DB.CustomFieldData`

Member kind: type
Symbol: `Autodesk.Revit.DB.CustomFieldData`

#### Summary

A class that offer access to the information about a custom field.

#### Since

2024

### `M:Autodesk.Revit.DB.TableData.IsValidZoomLevel(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableData.IsValidZoomLevel(System.Int32)`

#### Summary

Verifies if the value of zoom level is valid.

#### Parameter `zoomLevel`

The value of zoom level.

#### Returns

True if the value of zoom level is inside of the acceptable range, false otherwise.

#### Since

2019.2

### `M:Autodesk.Revit.DB.TableData.GetSectionData(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableData.GetSectionData(System.Int32)`

#### Summary

Returns the section data array element at the specified index.

#### Parameter `nIndex`

The index of section data array. If the index is out of the boundary of section data array,
`null` is returned.

### `M:Autodesk.Revit.DB.TableData.GetSectionData(Autodesk.Revit.DB.SectionType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableData.GetSectionData(Autodesk.Revit.DB.SectionType)`

#### Summary

Returns the pointer to the section data array element at the specified section type.

#### Parameter `sectionType`

The section type of section data array. If the integral value of the section type is out of the boundary of section data array,
null is returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.TableData.IsEqual(Autodesk.Revit.DB.TableData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableData.IsEqual(Autodesk.Revit.DB.TableData)`

#### Summary

Checks if this element is equal in value to the other element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.TableData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TableData.ZoomLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableData.ZoomLevel`

#### Summary

The value of zoom level for corresponding TableView.

#### Remarks

This value is used to change the size of text fonts in tabular views, and then the size of rows, colums and cells
will also be changed to satisfy the text.

Note: This value is only used to improve the text readability in tabular view and will not change the size of texts, rows, columns and cells in sheet views.

Note: This value is temporary setting just for this session.

Note: This value is a percentage number which must be a multiple of 10 in the range of 10 to 400.
A value of 400 indicates the maximum zoom permitted. The default value for new created tabular views is 100.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The value of zoom level must be a multiple of 10 in the range of 10 to 400.

#### Since

2019.2

### `P:Autodesk.Revit.DB.TableData.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableData.Width`

#### Summary

Gets or sets the table width in feet

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The table width is outside of the acceptable range.

### `P:Autodesk.Revit.DB.TableData.WidthInPixels`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableData.WidthInPixels`

#### Summary

Gets the width of the panel schedule in logical pixels

### `P:Autodesk.Revit.DB.TableData.NumberOfSections`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableData.NumberOfSections`

#### Summary

Gets the number of items in section data array.

### `P:Autodesk.Revit.DB.TableData.FreezeColumnsAndRows`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableData.FreezeColumnsAndRows`

#### Summary

set to true if the columns and rows should be unmovable by the slider grips

### `T:Autodesk.Revit.DB.TableData`

Member kind: type
Symbol: `Autodesk.Revit.DB.TableData`

#### Summary

The TableData class is implemented to hold most of the data that describe
the style of the rows, columns, and cells in a table.

### `M:Autodesk.Revit.DB.TableSectionData.SetCellCombinedParameters(System.Int32,System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetCellCombinedParameters(System.Int32,System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

#### Summary

Allows the caller to set combined parameter for a specified column

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.TableSectionData.SetCellCombinedParameters(System.Int32,System.Int32,System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetCellCombinedParameters(System.Int32,System.Int32,System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

#### Summary

Allows the caller to set combined parameter for a specified cell

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.TableSectionData.GetCellCombinedParameters(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellCombinedParameters(System.Int32)`

#### Summary

Returns an array of combined parameter data for the specified column

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.GetCellCombinedParameters(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellCombinedParameters(System.Int32,System.Int32)`

#### Summary

Returns an array of combined parameter data for the specified cell

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.GetCustomFieldId(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCustomFieldId(System.Int32,System.Int32)`

#### Summary

Gets custom field id from the cell.

#### Parameter `row`

The row of the cell.

#### Parameter `col`

The column of the cell.

#### Returns

Returns custom field id from the cell.
If this cell is not of type CellType.CustomField it will return an empty Guid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number row is invalid.
-or-
The given column number col is invalid.

#### Since

2024

### `M:Autodesk.Revit.DB.TableSectionData.SetCellCalculatedValue(System.Int32,Autodesk.Revit.DB.TableCellCalculatedValueData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetCellCalculatedValue(System.Int32,Autodesk.Revit.DB.TableCellCalculatedValueData)`

#### Summary

Allows the caller to set the calculated value for a specified column

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is forbidden for cells in standard schedule header sections.
-or-
This operation is forbidden for cells in standard schedule body sections.

### `M:Autodesk.Revit.DB.TableSectionData.SetCellCalculatedValue(System.Int32,System.Int32,Autodesk.Revit.DB.TableCellCalculatedValueData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetCellCalculatedValue(System.Int32,System.Int32,Autodesk.Revit.DB.TableCellCalculatedValueData)`

#### Summary

Allows the caller to set the calculated value for a specified cell

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is forbidden for cells in standard schedule header sections.
-or-
This operation is forbidden for cells in standard schedule body sections.

### `M:Autodesk.Revit.DB.TableSectionData.GetCellCalculatedValue(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellCalculatedValue(System.Int32)`

#### Summary

Gets the calculated value for the specified column

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.GetCellCalculatedValue(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellCalculatedValue(System.Int32,System.Int32)`

#### Summary

Gets the calculated value for the specified cell

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.SetCellParamIdAndCategoryId(System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetCellParamIdAndCategoryId(System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Sets a column's category and parameter Id

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.
-or-
The paramId or categoryId is not acceptable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is forbidden for cells in standard schedule body sections.

### `M:Autodesk.Revit.DB.TableSectionData.SetCellParamIdAndCategoryId(System.Int32,System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetCellParamIdAndCategoryId(System.Int32,System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Sets a cell's category and parameter Id

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.
-or-
The paramId or categoryId is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.TableSectionData.IsAcceptableParamIdAndCategoryId(System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.IsAcceptableParamIdAndCategoryId(System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if the given parameter id and category id can be assigned to a cell in the given row in this table.

#### Parameter `nRow`

row index

#### Returns

True if the ParamId and CategoryId are all valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.TableSectionData.IsAcceptableParamIdAndCategoryId(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.IsAcceptableParamIdAndCategoryId(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if the given parameter id and category id can be assigned to a cell in this table.

#### Returns

True if the ParamId and CategoryId are all acceptable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.TableSectionData.GetCellCategoryId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellCategoryId(System.Int32)`

#### Summary

Returns a column's ParamId
Associated with the paramId to find the correct element

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.GetCellCategoryId(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellCategoryId(System.Int32,System.Int32)`

#### Summary

Returns a cell's CategoryId and if no CategoryId exists for this cell,
it would come from the column.
Associated with the paramId to find the correct element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.GetCellParamId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellParamId(System.Int32)`

#### Summary

Returns a column's ParamId

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.GetCellParamId(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellParamId(System.Int32,System.Int32)`

#### Summary

Returns a cell's ParamId and if no ParamId exists for this cell,
it would come from the column

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.SetCellFormatOptions(System.Int32,System.Int32,Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetCellFormatOptions(System.Int32,System.Int32,Autodesk.Revit.DB.FormatOptions)`

#### Summary

Sets a cell's FormatOptions.

#### Parameter `nRow`

The row index of the cell

#### Parameter `nCol`

The column index of the cell

#### Parameter `options`

The format option to assign

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.
-or-
The display unit in options is not a valid display unit for the unit type of the cell, or the rounding method in options is not set to Nearest. See UnitUtils.IsValidDisplayUnit(UnitType, DisplayUnitType), UnitUtils.GetValidDisplayUnits(UnitType) and FormatOptions.RoundingMethod.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.GetCellSpec(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellSpec(System.Int32,System.Int32)`

#### Summary

Gets the spec describing values of a cell, if applicable.

#### Parameter `nRow`

The row index of the cell

#### Parameter `nCol`

The column index of the cell

#### Returns

Identifier of the spec, or empty if the cell does not contain a number with units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.IsCellFormattable(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.IsCellFormattable(System.Int32,System.Int32)`

#### Summary

Determines whether the cell is formattable or not

#### Parameter `nRow`

The row index of the cell

#### Parameter `nCol`

The column index of the cell

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.GetCellFormatOptions(System.Int32,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellFormatOptions(System.Int32,Autodesk.Revit.DB.Document)`

#### Summary

Returns a column's cell FormatOptions and if no FormatOptions exists for this column,
it would come from the section.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.TableSectionData.GetCellFormatOptions(System.Int32,System.Int32,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellFormatOptions(System.Int32,System.Int32,Autodesk.Revit.DB.Document)`

#### Summary

Returns a cell's FormatOptions and if no FormatOptions exists for this cell,
it would come from the column, or the row, or the section.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.TableSectionData.SetCellType(System.Int32,Autodesk.Revit.DB.CellType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetCellType(System.Int32,Autodesk.Revit.DB.CellType)`

#### Summary

Sets a column's cell type

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

A CellType.CustomField can't be set.
-or-
The given column number nCol is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is forbidden for cells in standard schedule body sections.

### `M:Autodesk.Revit.DB.TableSectionData.SetCellType(System.Int32,System.Int32,Autodesk.Revit.DB.CellType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetCellType(System.Int32,System.Int32,Autodesk.Revit.DB.CellType)`

#### Summary

Sets a cell's Type

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

A CellType.CustomField can't be set.
-or-
The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is forbidden for cells in standard schedule body sections.

### `M:Autodesk.Revit.DB.TableSectionData.GetCellType(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellType(System.Int32)`

#### Summary

Returns a column's cell type and if no type exists for this column,
it would come from the section

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.GetCellType(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellType(System.Int32,System.Int32)`

#### Summary

Returns a cell's Type and if no Type exists for this cell,
it would come from the column, or the row, or the section

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.ResetCellOverride(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.ResetCellOverride(System.Int32)`

#### Summary

Resets the override of the column.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.ClearCell(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.ClearCell(System.Int32,System.Int32)`

#### Summary

Deletes text or image, or removes parameter of this cell.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is forbidden for cells in standard schedule body sections.

### `M:Autodesk.Revit.DB.TableSectionData.ResetCellOverride(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.ResetCellOverride(System.Int32,System.Int32)`

#### Summary

Resets the override of the cell.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.
-or-
Only allow to override cell style for header section or column header in body section.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.IsCellOverridden(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.IsCellOverridden(System.Int32)`

#### Summary

Indicates if the column is overridden or not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.IsCellOverridden(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.IsCellOverridden(System.Int32,System.Int32)`

#### Summary

Indicates if the cell is overridden or not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.SetCellStyle(Autodesk.Revit.DB.TableCellStyle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetCellStyle(Autodesk.Revit.DB.TableCellStyle)`

#### Summary

Sets a section's style

#### Remarks

For standard schedule, must set the TableCellStyleOverrideOptions in the TableCellStyle to override this section.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.TableSectionData.SetCellStyle(System.Int32,Autodesk.Revit.DB.TableCellStyle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetCellStyle(System.Int32,Autodesk.Revit.DB.TableCellStyle)`

#### Summary

Sets a column's style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.TableSectionData.SetCellStyle(System.Int32,System.Int32,Autodesk.Revit.DB.TableCellStyle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetCellStyle(System.Int32,System.Int32,Autodesk.Revit.DB.TableCellStyle)`

#### Summary

Sets a cell's style

#### Remarks

For standard schedule, must set the TableCellStyleOverrideOptions in the TableCellStyle to override this cell.
The global base format controls any non-overridden characteristics of this cell.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.
-or-
Only allow to override cell style for header section or column header in body section.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.TableSectionData.AllowOverrideCellStyle(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.AllowOverrideCellStyle(System.Int32,System.Int32)`

#### Summary

Identifies if the style can be overridden in the given cell.

#### Returns

True if allow to override cell style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.GetTableCellStyle(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetTableCellStyle(System.Int32,System.Int32)`

#### Summary

Returns a cell's style and if no style exists for this cell,
it would come from the column, or the section

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.MergeCells(Autodesk.Revit.DB.TableMergedCell)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.MergeCells(Autodesk.Revit.DB.TableMergedCell)`

#### Summary

Merges cells for the given area.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given TableMergedCell mergedCell is outside of acceptable range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is forbidden for cells in standard schedule body sections.

### `M:Autodesk.Revit.DB.TableSectionData.SetMergedCell(System.Int32,System.Int32,Autodesk.Revit.DB.TableMergedCell)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetMergedCell(System.Int32,System.Int32,Autodesk.Revit.DB.TableMergedCell)`

#### Summary

Sets the merged cell that this cell is a part of.

#### Parameter `nRow`

The cell row.

#### Parameter `nCol`

The cell column.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.
-or-
The given TableMergedCell mergedCell is outside of acceptable range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is forbidden for cells in standard schedule body sections.

### `M:Autodesk.Revit.DB.TableSectionData.GetMergedCell(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetMergedCell(System.Int32,System.Int32)`

#### Summary

Gets the whole merged cell that this cell is a part of.

#### Parameter `nRow`

The cell row.

#### Parameter `nCol`

The cell column.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.SetCellText(System.Int32,System.Int32,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetCellText(System.Int32,System.Int32,System.String)`

#### Summary

Sets a cell's to display the specified text.

#### Remarks

If this cell's type is not CellType.Text, and the operation is permitted on this cell, the cell type
will be changed to type CellType.Text as a result of this call.

#### Parameter `nRow`

The cell row.

#### Parameter `nCol`

The cell column.

#### Parameter `text`

The text to show in the cell.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is forbidden for cells in standard schedule body sections.

### `M:Autodesk.Revit.DB.TableSectionData.GetCellText(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetCellText(System.Int32,System.Int32)`

#### Summary

Returns the text shown by this cell, if the cell's type is CellType.Text or CellType.ParameterText or CellType.CustomField.

#### Remarks

For standard view schedules, to read the formatted text of the cell regardless of cell type,
use `!:Autodesk::Revit::DB::ViewSchedule::GetCellText()` .

#### Parameter `nRow`

The cell row.

#### Parameter `nCol`

The cell column.

#### Returns

The text in the cell, or an empty string if the type if not CellType.Text or CellType.ParameterText or CellType.CustomField.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.SetRowHeightInPixels(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetRowHeightInPixels(System.Int32,System.Int32)`

#### Summary

This sets a row's height in logical pixels

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The row height is outside of acceptable range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is forbidden for cells in standard schedule body sections.

### `M:Autodesk.Revit.DB.TableSectionData.SetRowHeight(System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetRowHeight(System.Int32,System.Double)`

#### Summary

Sets a row's height in feet

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The row height is outside of acceptable range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is forbidden for cells in standard schedule body sections.

### `M:Autodesk.Revit.DB.TableSectionData.GetRowHeightInPixels(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetRowHeightInPixels(System.Int32)`

#### Summary

This returns a row's height in logical pixels

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.GetRowHeight(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetRowHeight(System.Int32)`

#### Summary

Returns a row's height in feet

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.SetColumnWidthInPixels(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetColumnWidthInPixels(System.Int32,System.Int32)`

#### Summary

This sets a column's width in logical pixels

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.
-or-
The column width is outside of acceptable range.

### `M:Autodesk.Revit.DB.TableSectionData.SetColumnWidth(System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.SetColumnWidth(System.Int32,System.Double)`

#### Summary

Sets a column's width in feet

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.
-or-
The column width is outside of acceptable range.

### `M:Autodesk.Revit.DB.TableSectionData.GetColumnWidthInPixels(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetColumnWidthInPixels(System.Int32)`

#### Summary

This returns a column's width in logical pixels

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.GetColumnWidth(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.GetColumnWidth(System.Int32)`

#### Summary

Returns a column's width in feet

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given column number nCol is invalid.

### `M:Autodesk.Revit.DB.TableSectionData.RemoveColumn(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.RemoveColumn(System.Int32)`

#### Summary

Removes a column data at a specified index.

#### Parameter `nIndex`

An integer index

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

nIndex is invalid index.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is forbidden for cells in standard schedule body sections.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.InsertColumn(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.InsertColumn(System.Int32)`

#### Summary

Inserts a new column at the specified index relative to the current set of columns.

#### Parameter `index`

An integer index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

index is invalid index.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is forbidden for cells in standard schedule body sections.

#### Since

2015

### `M:Autodesk.Revit.DB.TableSectionData.CanRemoveColumn(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.CanRemoveColumn(System.Int32)`

#### Summary

Verifies that if the column at the given index can be removed.

#### Parameter `nIndex`

An integer index.

#### Returns

True if the column can be removed, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.CanInsertColumn(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.CanInsertColumn(System.Int32)`

#### Summary

Verifies if a new column can be inserted at the given index.

#### Parameter `nIndex`

An integer index.

#### Returns

True if the column can be inserted, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.RemoveRow(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.RemoveRow(System.Int32)`

#### Summary

Removes a row data at a specified index.

#### Parameter `nIndex`

An integer index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The row can't be removed because it's an element in linked file, default zone
or it's a row in body section of Material Quantity Take Off Schedule
or it's the last row in header section of standard schedule
or nIndex is invalid index.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.InsertRow(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.InsertRow(System.Int32)`

#### Summary

Inserts a row data at a specified index.

#### Parameter `nIndex`

An integer index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The row can't be inserted in data section of standard schedule except Key Schedule, Sheet List Schedule
or following categories without emdeded schedule: MEP Space, Room, Area.
or nIndex is invalid index.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.CanRemoveRow(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.CanRemoveRow(System.Int32)`

#### Summary

Verifies that if the row at the given index can be removed..

#### Parameter `nIndex`

An integer index.

#### Returns

True if the row can be removed, false otherwise

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.CanInsertRow(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.CanInsertRow(System.Int32)`

#### Summary

Verifies if a new row can be inserted at the given index.

#### Returns

True if the row can be inserted, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.IsValidImageSymbolId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.IsValidImageSymbolId(Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if the element id represents a valid ImageSymbol element.

#### Parameter `imageSymbolId`

The element id of the image symbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.InsertImage(System.Int32,System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.InsertImage(System.Int32,System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Inserts a image in the given cell.

#### Parameter `nRow`

The given row index.

#### Parameter `nColumn`

The given column index.

#### Parameter `imageSymbolId`

The element id of the image symbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given row number nRow is invalid.
-or-
The given column number nColumn is invalid.
-or-
The image symbol id doesn't represent a valid image symbol element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.IsValidRowNumber(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.IsValidRowNumber(System.Int32)`

#### Summary

Verifies if the row number is valid.

#### Parameter `nRow`

The row number.

#### Returns

True if the row number is between FirstRowNumber and LastRowNumber, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.IsValidColumnNumber(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.IsValidColumnNumber(System.Int32)`

#### Summary

Verifies if the column number is valid.

#### Parameter `nCol`

The column number.

#### Returns

True if the column number is between FirstColumnNumber and LastColumnNumber, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.RefreshData`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.RefreshData`

#### Summary

Rebuilds the data in this section if it is out of date.

#### Returns

True if the data is up to date after the refresh.

#### Since

2014

### `M:Autodesk.Revit.DB.TableSectionData.IsDataOutOfDate`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableSectionData.IsDataOutOfDate`

#### Summary

Indicates whether the data in this section is out of date.

#### Remarks

To improve performance, some TableViews may contain TableSections that are only updated on demand. For example,
the body section of a schedule is not updated when the ViewSchedule is closed. In this case, you need to call
RefreshData to avoid getting the stale data.

#### Returns

True if the data in this section is out of date, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TableSectionData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableSectionData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TableSectionData.NeedsRefresh`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableSectionData.NeedsRefresh`

#### Summary

Indicates if the table data need to refresh.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This operation is forbidden for cells in standard schedule body sections.

### `P:Autodesk.Revit.DB.TableSectionData.NumberOfRows`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableSectionData.NumberOfRows`

#### Summary

Gets or sets the number of items in row data array.

#### Remarks

Note that TableSections may use either 0 or 1 as the first row and column indices. To access the rows and columns:
Use FirstRowNumber and LastRowNumber to get the valid range of row indices.

Use FirstColumnNumber and LastColumnNumber to get the valid range of column indices.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This operation is forbidden for cells in standard schedule body sections.

### `P:Autodesk.Revit.DB.TableSectionData.LastRowNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableSectionData.LastRowNumber`

#### Summary

The last row in this section of the table.

#### Since

2014

### `P:Autodesk.Revit.DB.TableSectionData.FirstRowNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableSectionData.FirstRowNumber`

#### Summary

The first row in this section of the table.

#### Remarks

Some table sections have row 0 as their first row while others start with row 1.

#### Since

2014

### `P:Autodesk.Revit.DB.TableSectionData.LastColumnNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableSectionData.LastColumnNumber`

#### Summary

The last column in this section of the table.

#### Since

2014

### `P:Autodesk.Revit.DB.TableSectionData.FirstColumnNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableSectionData.FirstColumnNumber`

#### Summary

The first column in this section of the table.

#### Remarks

Some table sections have column 0 as their first column while others start with column 1.

#### Since

2014

### `P:Autodesk.Revit.DB.TableSectionData.NumberOfColumns`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableSectionData.NumberOfColumns`

#### Summary

Gets or sets the number of items in column data array.

#### Remarks

Note that TableSections may use either 0 or 1 as the first row and column indices. To access the rows and columns:
Use FirstRowNumber and LastRowNumber to get the valid range of row indices.

Use FirstColumnNumber and LastColumnNumber to get the valid range of column indices.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This operation is forbidden for cells in standard schedule body sections.

### `P:Autodesk.Revit.DB.TableSectionData.HideSection`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableSectionData.HideSection`

#### Summary

Whether or not the section is hidden.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This operation is forbidden for cells in standard schedule body sections.

### `T:Autodesk.Revit.DB.TableSectionData`

Member kind: type
Symbol: `Autodesk.Revit.DB.TableSectionData`

#### Summary

The TableSectionData class represents a serialized version of an instance of
section table data. The class holds row, column and cell data.

### `M:Autodesk.Revit.DB.TableCellCalculatedValueData.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableCellCalculatedValueData.GetName`

#### Summary

Gets the name of the calculated value.

### `P:Autodesk.Revit.DB.TableCellCalculatedValueData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellCalculatedValueData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.TableCellCalculatedValueData`

Member kind: type
Symbol: `Autodesk.Revit.DB.TableCellCalculatedValueData`

#### Summary

The TableCellCalculatedValueData stores the data for calculated value

### `M:Autodesk.Revit.DB.TableCellCombinedParameterData.Create`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableCellCombinedParameterData.Create`

#### Summary

construct a TableCellCombinedParameterData

#### Since

2017

### `P:Autodesk.Revit.DB.TableCellCombinedParameterData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellCombinedParameterData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellCombinedParameterData.ParamId`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellCombinedParameterData.ParamId`

#### Summary

The parameter id

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.TableCellCombinedParameterData.CategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellCombinedParameterData.CategoryId`

#### Summary

Category id for this parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.TableCellCombinedParameterData.Separator`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellCombinedParameterData.Separator`

#### Summary

The separator for this parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.TableCellCombinedParameterData.Suffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellCombinedParameterData.Suffix`

#### Summary

The suffix for this parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.TableCellCombinedParameterData.Prefix`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellCombinedParameterData.Prefix`

#### Summary

The prefix for this parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.TableCellCombinedParameterData.SampleValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellCombinedParameterData.SampleValue`

#### Summary

The sample/example value for the parameter in text form

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `T:Autodesk.Revit.DB.TableCellCombinedParameterData`

Member kind: type
Symbol: `Autodesk.Revit.DB.TableCellCombinedParameterData`

#### Summary

The TableCellCombinedParameterData stores the data for combined parameters

### `M:Autodesk.Revit.DB.TableCellStyle.SetCellStyleOverrideOptions(Autodesk.Revit.DB.TableCellStyleOverrideOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableCellStyle.SetCellStyleOverrideOptions(Autodesk.Revit.DB.TableCellStyleOverrideOptions)`

#### Summary

Sets cell style override options of this cell.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.TableCellStyle.GetCellStyleOverrideOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableCellStyle.GetCellStyleOverrideOptions`

#### Summary

Gets cell style override options of this cell.

#### Since

2014

### `M:Autodesk.Revit.DB.TableCellStyle.ResetOverride`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableCellStyle.ResetOverride`

#### Summary

Resets any overrides applied to this cell.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyle.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyle.FontVerticalAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.FontVerticalAlignment`

#### Summary

The vertical alignment style of text font.

#### Value

Alignment style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.TableCellStyle.FontHorizontalAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.FontHorizontalAlignment`

#### Summary

The horizontal alignment style of text font.

#### Value

Alignment style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.TableCellStyle.IsInactivePhaseload`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.IsInactivePhaseload`

#### Summary

Gets or sets whether this is an inactive phase load cell.

#### Value

true if the font is an inactive phase load cell; otherwise false.

### `P:Autodesk.Revit.DB.TableCellStyle.IsFontUnderline`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.IsFontUnderline`

#### Summary

Gets or sets whether the text font is set to Underline of this cell.

#### Value

true if the font is Underline; otherwise false.

### `P:Autodesk.Revit.DB.TableCellStyle.IsFontItalic`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.IsFontItalic`

#### Summary

Gets or sets whether the text font is set to italic of this cell.

#### Value

true if the font is italic; otherwise false.

### `P:Autodesk.Revit.DB.TableCellStyle.IsFontBold`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.IsFontBold`

#### Summary

Gets or sets whether the text font is set to bold of this cell.

#### Value

true if the font is bold; otherwise false.

### `P:Autodesk.Revit.DB.TableCellStyle.IsReadOnly`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.IsReadOnly`

#### Summary

Gets or sets whether this cell is read only.

#### Value

true if this cell is read only; otherwise false.

### `P:Autodesk.Revit.DB.TableCellStyle.IsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.IsEnabled`

#### Summary

Gets or sets the status whether this cell is enabled.

#### Value

True if this cell is enabled; otherwise False.

### `P:Autodesk.Revit.DB.TableCellStyle.IsOverridden`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.IsOverridden`

#### Summary

Indicates if the cell is overridden or not.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyle.BorderRightLineStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.BorderRightLineStyle`

#### Summary

The element id (GraphicsStyle element) for the right line of the cell border.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.TableCellStyle.BorderLeftLineStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.BorderLeftLineStyle`

#### Summary

The element id (GraphicsStyle element) for the left line of the cell border.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.TableCellStyle.BorderBottomLineStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.BorderBottomLineStyle`

#### Summary

The element id (GraphicsStyle element) for the bottom line of the cell border.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.TableCellStyle.BorderTopLineStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.BorderTopLineStyle`

#### Summary

The element id (GraphicsStyle element) for the top line of the cell border.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.TableCellStyle.TextOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.TextOrientation`

#### Summary

The orientation of the cell (for vertical/horizontal text) with input in degrees multiplied by 10

### `P:Autodesk.Revit.DB.TableCellStyle.SheetBackgroundColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.SheetBackgroundColor`

#### Summary

The background color of this cell in the sheet view.

#### Remarks

In most cases the background color on the sheet view is the same as it is in the grid view. The background may be different
if conditional formatting is applied only in the grid view.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyle.BackgroundColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.BackgroundColor`

#### Summary

The background color of this cell in the grid view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.TableCellStyle.TextColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.TextColor`

#### Summary

The text color of this cell.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.TableCellStyle.TextSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.TextSize`

#### Summary

The text size.

### `P:Autodesk.Revit.DB.TableCellStyle.FontName`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyle.FontName`

#### Summary

The font used for this style

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `M:Autodesk.Revit.DB.TableCellStyle.#ctor(Autodesk.Revit.DB.TableCellStyle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableCellStyle.#ctor(Autodesk.Revit.DB.TableCellStyle)`

#### Summary

Constructs a new copy of the input TableCellStyle object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.TableCellStyle.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableCellStyle.#ctor`

#### Summary

Constructs a new TableCellStyle with default settings.

### `T:Autodesk.Revit.DB.TableCellStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.TableCellStyle`

#### Summary

The TableCellStyle class contains the appearance settings for a given table cell, column, or table.

### `M:Autodesk.Revit.DB.TableCellStyleOverrideOptions.SetAllOverrides(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.SetAllOverrides(System.Boolean)`

#### Summary

Sets all overrides to a specific value.

#### Parameter `bOverride`

The value that will be assigned to all the overrides.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.BorderLineStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.BorderLineStyle`

#### Summary

Indicates if the border line style characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.TextOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.TextOrientation`

#### Summary

Indicates if the text orientation characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.Underline`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.Underline`

#### Summary

Indicates if the underline characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.Italics`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.Italics`

#### Summary

Indicates if the italics characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.Bold`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.Bold`

#### Summary

Indicates if the bold characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.VerticalAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.VerticalAlignment`

#### Summary

Indicates if the vertical alignment characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.HorizontalAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.HorizontalAlignment`

#### Summary

Indicates if the horizontal alignment characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.BorderRightLineStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.BorderRightLineStyle`

#### Summary

Indicates if the border right line style characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.BorderLeftLineStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.BorderLeftLineStyle`

#### Summary

Indicates if the border left line style characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.BorderBottomLineStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.BorderBottomLineStyle`

#### Summary

Indicates if the border bottom line style characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.BorderTopLineStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.BorderTopLineStyle`

#### Summary

Indicates if the border top line style characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.BackgroundColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.BackgroundColor`

#### Summary

Indicates if the background color characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.FontColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.FontColor`

#### Summary

Indicates if the font color characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.FontSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.FontSize`

#### Summary

Indicates if the font size characteristic is overridden.

#### Since

2014

### `P:Autodesk.Revit.DB.TableCellStyleOverrideOptions.Font`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.Font`

#### Summary

Indicates if the font name characteristic is overridden.

#### Since

2014

### `M:Autodesk.Revit.DB.TableCellStyleOverrideOptions.#ctor(Autodesk.Revit.DB.TableCellStyleOverrideOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.#ctor(Autodesk.Revit.DB.TableCellStyleOverrideOptions)`

#### Summary

Creates a new instance by copying an existing instance.

#### Parameter `other`

The instance to copy

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.TableCellStyleOverrideOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions.#ctor`

#### Summary

Creates a new instance with no style characteristics overridden.

#### Since

2014

### `T:Autodesk.Revit.DB.TableCellStyleOverrideOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.TableCellStyleOverrideOptions`

#### Summary

This helper class represents the overridden characteristics of the associated cell.

#### Remarks

The user can override the text appearance and cell graphic properties by setting the corresponding flag to true.
The global base format will control the non-overridden characteristics.

#### Since

2014

### `T:Autodesk.Revit.DB.CellType`

Member kind: type
Symbol: `Autodesk.Revit.DB.CellType`

#### Summary

Declares the cell data type.

#### Since

2011

### `F:Autodesk.Revit.DB.CellType.CustomField`

Member kind: field
Symbol: `Autodesk.Revit.DB.CellType.CustomField`

#### Summary

Data bounded to a Schedule Custom Field.

### `F:Autodesk.Revit.DB.CellType.ParameterText`

Member kind: field
Symbol: `Autodesk.Revit.DB.CellType.ParameterText`

#### Summary

Read only parameter which only show formatted string

### `F:Autodesk.Revit.DB.CellType.CalculatedValue`

Member kind: field
Symbol: `Autodesk.Revit.DB.CellType.CalculatedValue`

#### Summary

The type is a calculated value

### `F:Autodesk.Revit.DB.CellType.CombinedParameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.CellType.CombinedParameter`

#### Summary

The type is combined parameter

### `F:Autodesk.Revit.DB.CellType.Inherited`

Member kind: field
Symbol: `Autodesk.Revit.DB.CellType.Inherited`

#### Summary

the type is inherited from the column or section if appropriate

### `F:Autodesk.Revit.DB.CellType.Parameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.CellType.Parameter`

#### Summary

Data bound parameter

### `F:Autodesk.Revit.DB.CellType.Graphic`

Member kind: field
Symbol: `Autodesk.Revit.DB.CellType.Graphic`

#### Summary

Embedded graphic

### `F:Autodesk.Revit.DB.CellType.Text`

Member kind: field
Symbol: `Autodesk.Revit.DB.CellType.Text`

#### Summary

Simple text

### `P:Autodesk.Revit.DB.TableMergedCell.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableMergedCell.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TableMergedCell.Right`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableMergedCell.Right`

#### Summary

Specifies the column index of the bottom-right corner of a table grid.

#### Since

2011

### `P:Autodesk.Revit.DB.TableMergedCell.Bottom`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableMergedCell.Bottom`

#### Summary

Specifies the row index of the bottom-right corner of a table grid.

#### Since

2011

### `P:Autodesk.Revit.DB.TableMergedCell.Left`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableMergedCell.Left`

#### Summary

Specifies the column index of the top-left corner of a table grid.

#### Since

2011

### `P:Autodesk.Revit.DB.TableMergedCell.Top`

Member kind: property
Symbol: `Autodesk.Revit.DB.TableMergedCell.Top`

#### Summary

Specifies the row index of the top-left corner of a table grid.

#### Since

2011

### `M:Autodesk.Revit.DB.TableMergedCell.#ctor(System.Int32,System.Int32,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableMergedCell.#ctor(System.Int32,System.Int32,System.Int32,System.Int32)`

#### Summary

Constructor.

#### Parameter `top`

Row index of the top-left of a table grid.

#### Parameter `left`

Column index of the top-left of a table grid.

#### Parameter `bottom`

Row index of the bottom-right of a table grid.

#### Parameter `right`

Column index of the bottom-right of a table grid.

#### Since

2011

### `M:Autodesk.Revit.DB.TableMergedCell.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.TableMergedCell.#ctor`

#### Summary

Default constructor.

#### Since

2011

### `T:Autodesk.Revit.DB.TableMergedCell`

Member kind: type
Symbol: `Autodesk.Revit.DB.TableMergedCell`

#### Summary

The TableMergedCell class defines a merged area of the upper-left and lower-right of a table grid.

#### Remarks

A TableMergedCell contains member variables that define the top-left and bottom-right row and column indexes of a table grid.
A TableMergedCell object can be passed as a function parameter wherever a TableMergedCell can be passed.

#### Since

2011

### `T:Autodesk.Revit.DB.VerticalAlignmentStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.VerticalAlignmentStyle`

#### Summary

Declares the vertical alignment style of font.

#### Since

2011

### `F:Autodesk.Revit.DB.VerticalAlignmentStyle.Bottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.VerticalAlignmentStyle.Bottom`

#### Summary

Alignment to bottom

### `F:Autodesk.Revit.DB.VerticalAlignmentStyle.Middle`

Member kind: field
Symbol: `Autodesk.Revit.DB.VerticalAlignmentStyle.Middle`

#### Summary

Alignment to middle

### `F:Autodesk.Revit.DB.VerticalAlignmentStyle.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.VerticalAlignmentStyle.Top`

#### Summary

Alignment to top

### `T:Autodesk.Revit.DB.HorizontalAlignmentStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.HorizontalAlignmentStyle`

#### Summary

Declares the horizontal alignment style of font.

#### Since

2011
