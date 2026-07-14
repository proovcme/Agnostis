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
Shard: 39
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `P:Autodesk.Revit.DB.TriangleInShellComponent.VertexIndex1`

Member kind: property
Symbol: `Autodesk.Revit.DB.TriangleInShellComponent.VertexIndex1`

#### Summary

Index of the triangle's second vertex in the TriangulatedShellComponent's array of vertices.

#### Since

2013

### `P:Autodesk.Revit.DB.TriangleInShellComponent.VertexIndex0`

Member kind: property
Symbol: `Autodesk.Revit.DB.TriangleInShellComponent.VertexIndex0`

#### Summary

Index of the triangle's first vertex in the TriangulatedShellComponent's array of vertices.

#### Since

2013

### `M:Autodesk.Revit.DB.TriangleInShellComponent.#ctor(Autodesk.Revit.DB.TriangleInShellComponent)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TriangleInShellComponent.#ctor(Autodesk.Revit.DB.TriangleInShellComponent)`

#### Summary

Creates a copy of the given TriangleInShellComponent

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.TriangleInShellComponent`

Member kind: type
Symbol: `Autodesk.Revit.DB.TriangleInShellComponent`

#### Summary

This class represents a triangle in a TriangulatedShellComponent object. The triangle is
defined by its vertices, which are specified by their indices in the
TriangulatedShellComponent's array of vertices.

#### Remarks

A TriangulatedShellComponent stores an array of TriangleInShellComponent objects
representing the triangles of the triangulation. An external class is used
because the API does not allow the use of a triple of integers. Note that a
TriangleInShellComponent must only be used in the context of a single, fixed
TriangulatedShellComponent.

#### Since

2013

### `M:Autodesk.Revit.DB.FacetingUtils.ConvertTrianglesToQuads(Autodesk.Revit.DB.TriangulationInterface)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FacetingUtils.ConvertTrianglesToQuads(Autodesk.Revit.DB.TriangulationInterface)`

#### Summary

Replaces pairs of adjacent, coplanar triangles by quadrilaterals.

#### Parameter `triangulation`

A triangulated face, shell, or solid.

#### Returns

A collection of triangles and quadrilaterals representing the original triangulated object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation failed.

#### Since

2013

### `T:Autodesk.Revit.DB.FacetingUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.FacetingUtils`

#### Summary

This class is used to convertTrianglesToQuads a triangulated structure into a structure in which some of the triangles
have been consolidated into quadrilaterals.

#### Since

2013

### `M:Autodesk.Revit.DB.TriangulationInterfaceForTriangulatedShellComponent.#ctor(Autodesk.Revit.DB.TriangulatedShellComponent)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TriangulationInterfaceForTriangulatedShellComponent.#ctor(Autodesk.Revit.DB.TriangulatedShellComponent)`

#### Summary

Constructs an interface object for a TriangulatedShellComponent.

#### Parameter `externalTriangulatedShellComponent`

The TriangulatedShellComponent that the interface object represents.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.TriangulationInterfaceForTriangulatedShellComponent`

Member kind: type
Symbol: `Autodesk.Revit.DB.TriangulationInterfaceForTriangulatedShellComponent`

#### Summary

This class is used to call FacetingUtils::convertTrianglesToQuads with a triangulation defined
by a TriangulatedShellComponent.

#### Remarks

Compare to TriangulationInterfaceForTriangulatedSolidOrShell, which treats with the entire solid or shell as
a single triangulated structure.

#### Since

2013

### `M:Autodesk.Revit.DB.TriangulationInterfaceForTriangulatedSolidOrShell.#ctor(Autodesk.Revit.DB.TriangulatedSolidOrShell)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TriangulationInterfaceForTriangulatedSolidOrShell.#ctor(Autodesk.Revit.DB.TriangulatedSolidOrShell)`

#### Summary

Construct an interface object for a TriangulatedSolidOrShell.

#### Parameter `externalTriangulatedSolidOrShell`

The TriangulatedSolidOrShell that the interface object represents.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.TriangulationInterfaceForTriangulatedSolidOrShell`

Member kind: type
Symbol: `Autodesk.Revit.DB.TriangulationInterfaceForTriangulatedSolidOrShell`

#### Summary

This class is used to call FacetingUtils::convertTrianglesToQuads with a triangulation defined
by a TriangulatedSolidOrShell.

#### Remarks

The vertex and triangle indices used by this class treat the triangulated solid or shell as if all
the vertices and triangles of the different shell components were collected into single sets of vertices
and triangles, respectively. For example, if a solid has two shell components and the first has ten vertices
while the second has five vertices, vertexIndex 6 refers to vertex[6] of the first shell component, and
vertexIndex 12 refers to vertex[2] of the second shell component. You can use the class
TriangulationInterfaceForTriangulatedShellComponent to get a faceting of an individual shell component.

#### Since

2013

### `P:Autodesk.Revit.DB.TriangulationInterface.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TriangulationInterface.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.TriangulationInterface`

Member kind: type
Symbol: `Autodesk.Revit.DB.TriangulationInterface`

#### Summary

This abstract class provides an interface for querying a triangulation structure (vertices and triangles).

#### Since

2013

### `M:Autodesk.Revit.DB.TriOrQuadFacet.GetVertexIndex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TriOrQuadFacet.GetVertexIndex(System.Int32)`

#### Summary

Returns the index of the specified vertex of this facet (as an index into the external array
of vertices in the TriangulationInterface that was used to create the list of TriOrQuadFacets).

#### Parameter `index`

Index of the desired vertex in this TriOrQuadFacet (between 0 and NumberOfVertices-1, inclusive).

#### Returns

The index of the specified vertex in the external array of vertices (only valid if NumberOfVertices >= 3).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

index is out of range..

#### Since

2013

### `P:Autodesk.Revit.DB.TriOrQuadFacet.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TriOrQuadFacet.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TriOrQuadFacet.Normal`

Member kind: property
Symbol: `Autodesk.Revit.DB.TriOrQuadFacet.Normal`

#### Summary

A unit normal vector for this facet.

#### Since

2013

### `P:Autodesk.Revit.DB.TriOrQuadFacet.NumberOfVertices`

Member kind: property
Symbol: `Autodesk.Revit.DB.TriOrQuadFacet.NumberOfVertices`

#### Summary

The number of vertices (3 for a triangle, 4 for a quadrilateral, 0 for an unset TriOrQuadFacet).

#### Since

2013

### `T:Autodesk.Revit.DB.TriOrQuadFacet`

Member kind: type
Symbol: `Autodesk.Revit.DB.TriOrQuadFacet`

#### Summary

This class represents a triangle or quadrilateral in a faceted structure.

#### Remarks

This class defines a triangle or quadrilateral with reference to an external triangulation structure.
The vertices of this TriOrQuadFacet are indices into the triangulation structure's array of vertices.

#### Since

2013

### `M:Autodesk.Revit.DB.FaceWall.IsValidFaceReferenceForFaceWall(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceWall.IsValidFaceReferenceForFaceWall(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

#### Summary

Identifies if a reference may be used as the parent of a face wall.

#### Remarks

The reference must represent a face of a massing instance, and
must be planar, and its normal must not be vertical or horizontal.

#### Parameter `document`

The document.

#### Parameter `faceReference`

The reference.

#### Returns

True if the reference is valid as a parent to a face wall, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FaceWall.IsWallTypeValidForFaceWall(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceWall.IsWallTypeValidForFaceWall(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if a wall type may be applied to a face wall.

#### Parameter `document`

The document.

#### Parameter `wallType`

The wall type.

#### Returns

True if the wall type is valid for face wall, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FaceWall.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.WallLocationLine,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceWall.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.WallLocationLine,Autodesk.Revit.DB.Reference)`

#### Summary

Creates a new instance of a wall attached to a non-vertical massing face.

#### Remarks

This method will regenerate the document.

#### Parameter `document`

The document.

#### Parameter `wallType`

The wall type. This must be a wall type accepted by IsWallTypeValidForFaceWall()

#### Parameter `locationLine`

The alignment of the wall location line.

#### Parameter `faceReference`

The reference from the massing face. This must pass IsValidFaceReferenceForFaceWall()

#### Returns

The newly created face wall.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element wallType does not exist in the document
-or-
document is not a project document.
-or-
This wall type cannot be applied to a face wall.
-or-
This reference cannot be applied to a face wall.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

During a dynamic update, the newly created face wall is going to be joined to surrounding structures.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The element is a member of a loaded family.
-or-
The element is a member of a group type that is
not being edited.

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

2011

### `T:Autodesk.Revit.DB.FaceWall`

Member kind: type
Symbol: `Autodesk.Revit.DB.FaceWall`

#### Summary

A wall attached to a non-vertical massing face.

#### Since

2011

### `T:Autodesk.Revit.DB.WallLocationLine`

Member kind: type
Symbol: `Autodesk.Revit.DB.WallLocationLine`

#### Summary

This enumerated type represents the options for alignment of a wall's location line.

#### Since

2011

### `F:Autodesk.Revit.DB.WallLocationLine.CoreInterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallLocationLine.CoreInterior`

#### Summary

The wall location line is aligned to the exterior face of the core.

### `F:Autodesk.Revit.DB.WallLocationLine.CoreExterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallLocationLine.CoreExterior`

#### Summary

The wall location line is aligned to the exterior face of the core.

### `F:Autodesk.Revit.DB.WallLocationLine.FinishFaceInterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallLocationLine.FinishFaceInterior`

#### Summary

The wall location line is aligned to the interior face of the wall.

### `F:Autodesk.Revit.DB.WallLocationLine.FinishFaceExterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallLocationLine.FinishFaceExterior`

#### Summary

The wall location line is aligned to the exterior face of the wall.

### `F:Autodesk.Revit.DB.WallLocationLine.CoreCenterline`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallLocationLine.CoreCenterline`

#### Summary

The wall location line is aligned to the center of the core.

### `F:Autodesk.Revit.DB.WallLocationLine.WallCenterline`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallLocationLine.WallCenterline`

#### Summary

The wall location line is aligned to the center of the wall.

### `M:Autodesk.Revit.DB.FaceSplitter.GetBoundaries`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceSplitter.GetBoundaries`

#### Summary

Gets the boundaries.

#### Returns

The face splitter boundaries.

#### Since

2020

### `P:Autodesk.Revit.DB.FaceSplitter.SplitElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FaceSplitter.SplitElementId`

#### Summary

The id of the element whose face is split by this element.

#### Since

2012

### `T:Autodesk.Revit.DB.FaceSplitter`

Member kind: type
Symbol: `Autodesk.Revit.DB.FaceSplitter`

#### Summary

Represents an element that splits a face.

#### Since

2012

### `M:Autodesk.Revit.DB.FaceSecondDerivatives.GetFaceSecondDerivatives(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceSecondDerivatives.GetFaceSecondDerivatives(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.UV)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.FaceSecondDerivatives.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FaceSecondDerivatives.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FaceSecondDerivatives.MixedDerivative`

Member kind: property
Symbol: `Autodesk.Revit.DB.FaceSecondDerivatives.MixedDerivative`

#### Summary

The mixed derivative.

#### Since

2016

### `P:Autodesk.Revit.DB.FaceSecondDerivatives.VVDerivative`

Member kind: property
Symbol: `Autodesk.Revit.DB.FaceSecondDerivatives.VVDerivative`

#### Summary

The second derivative with respect to V.

#### Since

2016

### `P:Autodesk.Revit.DB.FaceSecondDerivatives.UUDerivative`

Member kind: property
Symbol: `Autodesk.Revit.DB.FaceSecondDerivatives.UUDerivative`

#### Summary

The second derivative with respect to U.

#### Since

2016

### `T:Autodesk.Revit.DB.FaceSecondDerivatives`

Member kind: type
Symbol: `Autodesk.Revit.DB.FaceSecondDerivatives`

#### Summary

Contains second partial derivatives of a face at a specified point.

#### Since

2016

### `M:Autodesk.Revit.DB.FaceAPIUtils.GetFaceEdgesAsCurveLoops(Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceAPIUtils.GetFaceEdgesAsCurveLoops(Autodesk.Revit.DB.Face)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.FaceAPIUtils.FaceXFaceIntersectWithResult(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Curve@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceAPIUtils.FaceXFaceIntersectWithResult(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Curve@)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.FaceAPIUtils.FaceXFaceIntersect(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceAPIUtils.FaceXFaceIntersect(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Face)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.FaceAPIUtils.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FaceAPIUtils.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FaceAPIUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.FaceAPIUtils`

#### Summary

Contains native implementations of face related functions exposed to API.

#### Remarks

All of the static methods contained within logically belong within the API in Face or one of its subclasses.
The internal API wrappers are called directly by the related public API methods.

### `M:Autodesk.Revit.DB.Fabrication.FabricationUtils.OpenFabricationJob(Autodesk.Revit.DB.Document,System.String,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationUtils.OpenFabricationJob(Autodesk.Revit.DB.Document,System.String,System.Boolean)`

#### Summary

Opens fabrication job and adds valid parts found into the current project.

#### Parameter `document`

The document to add parts to.

#### Parameter `filename`

Full filename of fabrication job to open.

#### Parameter `validate`

If true validates all new part connections and disconnects improper ones, with warnings.

#### Returns

Returns element identifiers of new elements that are added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The model must not have any fabrication parts.
-or-
Fabrication configuration is missing.
-or-
Fabrication job did not exist at filename.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Fabrication.FabricationUtils.ExportToPCF(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationUtils.ExportToPCF(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},System.String)`

#### Summary

Exports a list of fabrication parts into PCF format.

#### Parameter `document`

The document.

#### Parameter `ids`

An array of FabricationPart element identifiers. Non-fabrication parts are ignored.

#### Parameter `filename`

The name given to the output file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Fabrication configuration is missing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Fabrication.FabricationUtils.ValidateConnectivity(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationUtils.ValidateConnectivity(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Check if two connectors are valid to connect directly without couplings.

#### Parameter `document`

The document.

#### Parameter `connector1`

First connector to check.

#### Parameter `connector2`

Second connector to check against.

#### Returns

True if connection is valid otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.Fabrication.FabricationUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationUtils`

#### Summary

General utility methods in the Autodesk Revit MEP product for fabrication.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationServiceSettings.HasValidFluidSetting(Autodesk.Revit.DB.FabricationService)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceSettings.HasValidFluidSetting(Autodesk.Revit.DB.FabricationService)`

#### Summary

Is the service associated with a fluid type and temperature?

#### Parameter `service`

The service to lookup.

#### Returns

True if the service is associated with a fluid type and temperature, otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationServiceSettings.GetFluidType(Autodesk.Revit.DB.FabricationService)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceSettings.GetFluidType(Autodesk.Revit.DB.FabricationService)`

#### Summary

Gets the fluid type of the specified service.

#### Parameter `service`

The service to lookup.

#### Returns

The fluid type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

service is not mapped to a fluid type and temperature.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationServiceSettings.GetFluidTemperature(Autodesk.Revit.DB.FabricationService)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceSettings.GetFluidTemperature(Autodesk.Revit.DB.FabricationService)`

#### Summary

Gets the fluid temperature of the specified service.

#### Parameter `service`

The service to lookup.

#### Returns

The temperature in Kelvin.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

service is not mapped to a fluid type and temperature.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationServiceSettings.RemoveFluidSetting(Autodesk.Revit.DB.FabricationService)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceSettings.RemoveFluidSetting(Autodesk.Revit.DB.FabricationService)`

#### Summary

Clears the fluid setting of the specified service if found.

#### Parameter `service`

The service to clear.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationServiceSettings.SetFluidTypeAndTemperature(Autodesk.Revit.DB.FabricationService,Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceSettings.SetFluidTypeAndTemperature(Autodesk.Revit.DB.FabricationService,Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Sets the fluid type and temperature of the specified service.

#### Parameter `service`

The fabrication service to be set.

#### Parameter `fluidId`

The fluid type id.

#### Parameter `temperature`

The temperature in Kelvin.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fluidId is not a fluid type.
-or-
The temperature is not defined for the fluidId fluid type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationServiceSettings.GetFabricationServiceSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceSettings.GetFabricationServiceSettings(Autodesk.Revit.DB.Document)`

#### Summary

Gets the settings element in the document.

#### Parameter `doc`

The document where the settings element is found.

#### Returns

The element which stores the fabrication service settings for the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.FabricationServiceSettings.AirFluidType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationServiceSettings.AirFluidType`

#### Summary

A special fluid type for fabrication HVAC services.

#### Since

2024

### `T:Autodesk.Revit.DB.FabricationServiceSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationServiceSettings`

#### Summary

Represents the settings related to the fabrication services.

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationPartType.GetAllLoadedFabricationPartTypes(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPartType.GetAllLoadedFabricationPartTypes(Autodesk.Revit.DB.Document)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPartType.FindAllFabricationPartTypes(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPartType.FindAllFabricationPartTypes(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPartType.Lookup(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPartType.Lookup(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Int32)`

#### Summary

Looks up an existing fabrication part type based on a specfic fabrication service button and condition.

#### Parameter `document`

The document.

#### Parameter `button`

The fabrication service button.

#### Parameter `condition`

The condition index.

#### Returns

Identifier of the fabrication part type element or invalidElementId if no fabrication part type exist for the
specific fabrication service button and condition

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index condition is not larger or equal to 0 and less than ConditionCount.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPartType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPartType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Int32)`

#### Summary

Creates a fabrication part type element based on a specific fabrication servic button and condition.

#### Parameter `document`

The document.

#### Parameter `button`

The fabrication service button.

#### Parameter `condition`

The condition index.

#### Returns

The created fabrication part type element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Fabrication service button contains invalid fittings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index condition is not larger or equal to 0 and less than ConditionCount.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The fabrication part type already exists.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationPartType.IsLoadedOutOfService`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPartType.IsLoadedOutOfService`

#### Summary

Flag to check if the fabrication part type has been loaded so that it is available out of service.

#### Since

2019

### `P:Autodesk.Revit.DB.FabricationPartType.ItemPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPartType.ItemPath`

#### Summary

The path of the item file.

#### Since

2019

### `T:Autodesk.Revit.DB.FabricationPartType`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationPartType`

#### Summary

Represents a fabrication component type in the Autodesk Revit MEP product.

#### Remarks

For the product-based MAP parts, every size is a new part type in Revit. For others, one part type can have many sizes.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationServiceButton.GetProfileType(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.GetProfileType(System.Int32,System.Int32)`

#### Summary

Gets the profile type of the passed condition index. If there are multiple profile types, this will return invalid.

#### Parameter `condition`

If the condition index is -1 and there is a mixture of profile types, this will return invalid.

#### Parameter `connectorIndex`

If the connector index is -1 and there is a mixture of profile types, this will return invalid.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationServiceButton.GetIsProductList(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.GetIsProductList(System.Int32)`

#### Summary

Checks to see if the passed condition index is a product listed, or catalogue item or not.

#### Parameter `condition`

If the condition index is -1 and there is a mixture of product list and non-product list, this will return false.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationServiceButton.GetDomain(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.GetDomain(System.Int32)`

#### Summary

Gets the domain type for the passed condition index.

#### Parameter `condition`

If the condition index is -1 and there are mixed domains, this will return undefined.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationServiceButton.IsSizeValidForCondition(System.Int32,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.IsSizeValidForCondition(System.Int32,System.Double,System.Double)`

#### Summary

Checks if the condition is valid for specified size.

#### Parameter `condition`

The condition index.

#### Parameter `widthOrDiameter`

The width or diameter of the size to check.

#### Parameter `depth`

The depth of the size to check.

#### Returns

True if the condition is valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index condition is not larger or equal to 0 and less than ConditionCount.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationServiceButton.ContainsFabricationPartType(Autodesk.Revit.DB.FabricationPartType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.ContainsFabricationPartType(Autodesk.Revit.DB.FabricationPartType)`

#### Summary

Checks to see if the fabrication part type exists on one of the button conditions.

#### Parameter `partType`

The fabrication part type to check.

#### Returns

Returns true if the fabrication part type exists on the fabrication service button.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Release

### `M:Autodesk.Revit.DB.FabricationServiceButton.GetConditionName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.GetConditionName(System.Int32)`

#### Summary

Gets the name of the specified condition on the fabrication service button.

#### Parameter `condition`

The condition index.

#### Returns

The name of the specified condition on the fabrication service button.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index condition is not larger or equal to 0 and less than ConditionCount.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationServiceButton.IsExcluded`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.IsExcluded`

#### Summary

Gets if the button's fabrication part content associated with the button is to be excluded from Route and Fill, Design to Fabrication, or Multi-Point Routing commands.

#### Returns

Returns true if the button's parts are excluded.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationServiceButton.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.IsValid`

#### Summary

Checks if the button contains only valid fittings.

#### Returns

True if the button contains only valid fittings.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationServiceButton.IsUnrestrictedCondition(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.IsUnrestrictedCondition(System.Int32)`

#### Summary

Checks if the condition is unrestricted.

#### Parameter `condition`

The condition index.

#### Returns

True if the condition is unrestricted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index condition is not larger or equal to 0 and less than ConditionCount.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationServiceButton.GetConditionUpperValue(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.GetConditionUpperValue(System.Int32)`

#### Summary

Gets the condition upper value (valid if less) for a given condition index.

#### Remarks

A value of -1 indicates an unrestricted value.

#### Parameter `condition`

The condition index.

#### Returns

The condition upper value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index condition is not larger or equal to 0 and less than ConditionCount.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationServiceButton.GetConditionLowerValue(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.GetConditionLowerValue(System.Int32)`

#### Summary

Gets the condition lower value (valid if greater or equal) for a given condition index.

#### Remarks

A value of -1 indicates an unrestricted value.

#### Parameter `condition`

The condition index.

#### Returns

The condition lower value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index condition is not larger or equal to 0 and less than ConditionCount.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationServiceButton.GetConditionDescription(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.GetConditionDescription(System.Int32)`

#### Summary

Gets the description for the condition size range.

#### Parameter `condition`

The index of the condition in the service button.

#### Returns

A user-defined string that describes the condition range, as defined in the fabrication configuration.
For example, this may describe the size of the range or describe the type of fitting.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index condition is not larger or equal to 0 and less than ConditionCount.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationServiceButton.IsValidConditionIndex(Autodesk.Revit.DB.FabricationServiceButton,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.IsValidConditionIndex(Autodesk.Revit.DB.FabricationServiceButton,System.Int32)`

#### Summary

Validates if the given condition index is valid or not.

#### Parameter `button`

The button to check.

#### Parameter `condition`

The condition index.

#### Returns

True if larger or equal to 0 and less than ConditionCount.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationServiceButton.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FabricationServiceButton.IsStraight`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.IsStraight`

#### Summary

Checks if all of the fabrication service button conditions are straights.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationServiceButton.IsAHanger`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.IsAHanger`

#### Summary

Checks if the fabrication service button is hanger.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationServiceButton.ButtonIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.ButtonIndex`

#### Summary

The button index for this button.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationServiceButton.PaletteIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.PaletteIndex`

#### Summary

The palette index for this button.

#### Since

2022

### `P:Autodesk.Revit.DB.FabricationServiceButton.ServiceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.ServiceId`

#### Summary

The fabrication service identifier for the fabrication service this button belongs to.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationServiceButton.ConditionIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.ConditionIndex`

#### Summary

The index of the condition being used.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationServiceButton.ConditionCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.ConditionCount`

#### Summary

The number of conditions.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationServiceButton.Code`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.Code`

#### Summary

The code of the button.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationServiceButton.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.Name`

#### Summary

The name of the button.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationServiceButton.GetConditionImage(System.Int32!System.Runtime.CompilerServices.IsConst)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.GetConditionImage(System.Int32!System.Runtime.CompilerServices.IsConst)`

#### Summary

Gets the image for the specified fabrication service button condition.

#### Parameter `condition`

The condition index.

#### Returns

System.Drawing.Bitmap represents the fabrication service button image. `null` if there is no preview image.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the index condition is not larger or equal to 0 and less than ConditionCount

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationServiceButton.GetImage`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationServiceButton.GetImage`

#### Summary

Gets the image for fabrication service button.

#### Returns

System.Drawing.Bitmap represents the fabrication service button image. `null` if there is no preview image.

#### Since

2016

### `T:Autodesk.Revit.DB.FabricationServiceButton`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationServiceButton`

#### Summary

The object contains information about a fabricaton button.

#### Remarks

A fabrication service button defines what items to use for different conditions. Fabrication service buttons are part of a fabrication service.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationRodInfo.GetRodLength(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.GetRodLength(System.Int32)`

#### Summary

Get the current rod length. If the rod is the length will include structural extension.

#### Parameter `rodIndex`

The rod index.

#### Returns

Returns rod length of hanger for specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the index rodIndex is should be in range of rod count.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationRodInfo.SetRodLength(System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.SetRodLength(System.Int32,System.Double)`

#### Summary

Set the rod length of the hanger for the specified rod index, excluding top extension. The hanger must not be set to be auto-hosted.

#### Parameter `rodIndex`

The rod index.

#### Returns

Returns true if it was successful otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the index rodIndex is should be in range of rod count.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The rod length cannot be set because the hanger is set to automatically host to other elements.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationRodInfo.GetRodStructureExtension(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.GetRodStructureExtension(System.Int32)`

#### Summary

Gets the length of the rod's top extension into structure.

#### Parameter `rodIndex`

The rod index.

#### Returns

Returns the extension length that will be applied if the rod is attached to structure.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the index rodIndex is should be in range of rod count.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationRodInfo.SetRodStructureExtension(System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.SetRodStructureExtension(System.Int32,System.Double)`

#### Summary

Set the length of the rod's top extension into structure. The rod must be attached to structure.

#### Parameter `rodIndex`

The rod index.

#### Parameter `extension`

Distance the rod will extend into the structure.

#### Returns

Returns true if it was successful otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the index rodIndex is should be in range of rod count.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The rods do not attached to any structue.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationRodInfo.SetBearerExtension(System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.SetBearerExtension(System.Int32,System.Double)`

#### Summary

Sets the bearer extension. The method is applicable only for bearer hanger.

#### Parameter `rodIndex`

The index of the rod.

#### Parameter `length`

The new length of bearer extension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the index rodIndex is should be in range of rod count.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The hanger is not a bearer hanger.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationRodInfo.GetBearerExtension(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.GetBearerExtension(System.Int32)`

#### Summary

Gets the bearer extension. The method is applicable only for bearer hanger.

#### Parameter `rodIndex`

The index of the rod.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the index rodIndex is should be in range of rod count.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The hanger is not a bearer hanger.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationRodInfo.SetRodLockedWithHost(System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.SetRodLockedWithHost(System.Int32,System.Boolean)`

#### Summary

Locks the rod with the host. The method is applicable only for bearer hanger.

#### Parameter `rodIndex`

The index of the rod.

#### Parameter `locked`

Locks the rod with the host.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the index rodIndex is should be in range of rod count.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The hanger is not a bearer hanger.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationRodInfo.IsRodLockedWithHost(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.IsRodLockedWithHost(System.Int32)`

#### Summary

Checks if the rod is locked with the host. The method is applicable only for bearer hanger.

#### Parameter `rodIndex`

The index of the rod.

#### Returns

True if the rod is locked with its host.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the index rodIndex is should be in range of rod count.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The hanger is not a bearer hanger.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationRodInfo.AttachToHanger(Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.AttachToHanger(Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.XYZ)`

#### Summary

Attaches the hanger rod to another bearer hanger.

#### Parameter `hangerId`

Identifier of the bearer hanger to which the rod attaches.

#### Parameter `rodIndex`

The index of the rod.

#### Parameter `position`

The position of the rod end. It should be on bearer centerline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The hanger is not a bearer hanger.
-or-
The point is not on hanger bearer centerline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the index rodIndex is should be in range of rod count.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationRodInfo.AttachToStructure`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.AttachToStructure`

#### Summary

Attaches to the nearest structural element.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationRodInfo.SetRodEndPosition(System.Int32,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.SetRodEndPosition(System.Int32,Autodesk.Revit.DB.XYZ)`

#### Summary

Sets the position of the rod end. The method is applicable only for bearer hanger.

#### Parameter `rodIndex`

The index of the rod.

#### Parameter `position`

The position of the rod end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid rod position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the index rodIndex is should be in range of rod count.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The hanger is not a bearer hanger.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationRodInfo.GetRodEndPosition(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.GetRodEndPosition(System.Int32)`

#### Summary

Gets the position of the rod end.

#### Parameter `rodIndex`

The index of the rod.

#### Returns

The position of the rod end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the index rodIndex is should be in range of rod count.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationRodInfo.GetRodAttachedElementId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.GetRodAttachedElementId(System.Int32)`

#### Summary

Gets the identifier of the attached component for the specified rod.

#### Parameter `rodIndex`

The index of the specified rod.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the index rodIndex is should be in range of rod count.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The rods do not attached to any structue.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationRodInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FabricationRodInfo.IsAttachedToStructure`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.IsAttachedToStructure`

#### Summary

Checks if the hanger is attached to structure.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationRodInfo.RodCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.RodCount`

#### Summary

Gets the number of rods.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationRodInfo.CanRodsBeHosted`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationRodInfo.CanRodsBeHosted`

#### Summary

Controls whether the hanger's rod's will be automatically hosted by other elements.

#### Since

2018

### `T:Autodesk.Revit.DB.FabricationRodInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationRodInfo`

#### Summary

The rod information of the fabrication part.

#### Remarks

A fabrication part may have one or more rods. The FabricationRodInfo stores the rod information of the fabrication part.

#### Since

2016

### `P:Autodesk.Revit.DB.Visual.AssetPropertyUInt64.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyUInt64.Value`

#### Summary

Get the value of the property.

### `T:Autodesk.Revit.DB.Visual.AssetPropertyUInt64`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyUInt64`

#### Summary

Represents a property of UInt64 value.

#### Since

2014

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.AllowMultipleServiceSizes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.AllowMultipleServiceSizes`

#### Summary

State flag to allow multiple services to include the same size.

#### Since

2018.2

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.MappedServiceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.MappedServiceId`

#### Summary

The mapped service identifier of the straight.

#### Since

2018.2

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.MappedProfileType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.MappedProfileType`

#### Summary

The mapped shape of the straight.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2018.2

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.IsMappedProductList`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.IsMappedProductList`

#### Summary

Are the mapped sizes for a product listed fabrication part.

#### Since

2018.2

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.MappedDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.MappedDepth`

#### Summary

The mapped size for the depth of the straight.

#### Since

2018.2

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.MappedWidthDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.MappedWidthDiameter`

#### Summary

The mapped size for the width or diameter of the straight.

#### Since

2018.2

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.PaletteId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.PaletteId`

#### Summary

The palette identifier of the straight.

#### Since

2018.2

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.ServiceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.ServiceId`

#### Summary

The service identifier of the straight.

#### Since

2018.2

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.ProfileType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.ProfileType`

#### Summary

The shape of the straight.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2018.2

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.IsProductList`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.IsProductList`

#### Summary

Are the sizes for a product listed fabrication part.

#### Since

2018.2

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.Depth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.Depth`

#### Summary

The depth of the straight.

#### Since

2018.2

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.WidthDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.WidthDiameter`

#### Summary

The width or diameter of the straight.

#### Since

2018.2

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.SizeString`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.SizeString`

#### Summary

The size display string for the straight that can be used by the user interface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2018.2

### `M:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.#ctor(System.String,System.Double,System.Double,System.Boolean,Autodesk.Revit.DB.ConnectorProfileType,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.#ctor(System.String,System.Double,System.Double,System.Boolean,Autodesk.Revit.DB.ConnectorProfileType,System.Int32,System.Int32)`

#### Summary

Creates a new instance of the FabricationPartSizeMap class.

#### Parameter `size`

The size display string for the straight that can be used by the user interface.

#### Parameter `widthDiameter`

The width or diameter of the straight.

#### Parameter `depth`

The depth of the straight.

#### Parameter `isProductList`

Set if the straight a product list or not.

#### Parameter `profileType`

Set the shape of the straight.

#### Parameter `serviceId`

Set the service identifier of the straight.

#### Parameter `paletteId`

Set the palette identifier of the straight.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2018.2

### `M:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.#ctor(System.String,System.Double,System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap.#ctor(System.String,System.Double,System.Double,System.Boolean)`

#### Summary

Creates a new instance of the FabricationPartSizeMap class.

#### Parameter `size`

The size display string for the straight that can be used by the user interface.

#### Parameter `widthDiameter`

The width or diameter of the straight.

#### Parameter `depth`

The depth of the straight.

#### Parameter `isProductList`

Set if the straight a product list or not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018.2

### `T:Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap`

#### Summary

This class represents the fabrication part size map for straights allowing the sizes to be changed from a user interface for multiple straights with diffent sizes.

#### Remarks

This is used as the data container for the FabricationPartSizeMapSet typeDef for crs:Set or Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap for ISet so a list of sizes can be generated to allow the user to select a size and map it to another.

#### Since

2018.2

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetMapOfAllSizesForStraights`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetMapOfAllSizesForStraights`

#### Summary

Get a set of FabricationPartSizeMapSet of all straight sizes for all services.

#### Returns

Returns the map of sizes for straights or an empty map if there are none.

#### Since

2018.2

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.SetMapOfSizesForStraights(System.Collections.Generic.ISet{Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.SetMapOfSizesForStraights(System.Collections.Generic.ISet{Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap})`

#### Summary

Set the mapping for sizes of fabrication part straights to change the sizes to.

#### Parameter `fabricationPartSizeMaps`

The map containing the original straights size to the mapped sizes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018.2

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetInLinePartTypes`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetInLinePartTypes`

#### Summary

Get a set of element identifiers of fabrication part types for in-line parts.

#### Returns

Returns the set of element identifiers for in-line parts or an empty set if there are none.

#### Since

2018.2

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.SetMapOfInLinePartTypes(System.Collections.Generic.IDictionary{Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.SetMapOfInLinePartTypes(System.Collections.Generic.IDictionary{Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId})`

#### Summary

Set the mapping of fabrication part types for in-line parts for the service and palette to change to.

#### Parameter `fabricationPartTypes`

The map containing the original fabrication part type to the fabrication part type to change to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018.2

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.SetRestrictPalette(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.SetRestrictPalette(System.Boolean)`

#### Summary

Restrict the placement of parts to only use parts associated to the passed in fabrication palette identifier.

#### Since

2022

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.SetPaletteId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.SetPaletteId(System.Int32)`

#### Summary

Set the fabrication palette identifier to change the elements to.

#### Since

2022

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.SetServiceId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.SetServiceId(System.Int32)`

#### Summary

Set the fabrication service identifier to change the elements to.

#### Since

2018.2

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.SetSelection(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.SetSelection(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Set the element selection to change the service or size for.

#### Parameter `selection`

The set of element identifiers of fabrication parts to change the service or size for.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018.2

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetElementsThatFailed`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetElementsThatFailed`

#### Summary

Gets the set of fabrication parts that had failures due to either there was no corresponding part in the service, the size was out of range, or a connection could not be made.

#### Remarks

This set of element identifiers is only available after the ChangeService or ChangeSize method has been invoked, and returns FabricationNetworkChangeServiceResult::Enum::PartialFailure.

#### Since

2018.2

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetStraightsThatWereNotChanged`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetStraightsThatWereNotChanged`

#### Summary

Gets the set of fabrication part straights that were not changed due to either there was no corresponding part in the service or the size was out of range.

#### Remarks

This set of element identifiers is only available after the ChangeService or ChangeSize method has been invoked, and returns FabricationNetworkChangeServiceResult::Enum::PartialFailure.

#### Since

2018.2

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.ApplyChange`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.ApplyChange`

#### Summary

Applies the previously set changes to the selection of fabrication parts to change the size, change the service, or both.

#### Remarks

After this method has been invoked, call:
`M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetStraightsThatWereNotChanged` to get a set of fabrication part straight element identifiers that were not changed.`M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetElementsThatFailed` to get a set of fabrication part element identifiers that had failures.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The selection contains invalid elements to change.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

No fabrication configuration is loaded.

#### Since

2018.2

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.ChangeSize(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.Collections.Generic.ISet{Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.ChangeSize(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.Collections.Generic.ISet{Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap})`

#### Summary

Changes the size of the selection of fabrication parts.

#### Remarks

After this method has been invoked, call:
`M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetStraightsThatWereNotChanged` to get a set of fabrication part straight element identifiers that were not changed.`M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetElementsThatFailed` to get a set of fabrication part element identifiers that had failures.

#### Parameter `selection`

The set of element identifiers of fabrication parts to change the size for.

#### Parameter `fabricationPartSizeMaps`

The map containing the original sizes for the straights to the new sizes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The selection contains invalid elements to change.
-or-
The fabrication size map is empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

No fabrication configuration is loaded.

#### Since

2018.2

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.ChangeService(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.Int32,System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.ChangeService(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.Int32,System.Int32,System.Boolean)`

#### Summary

Changes the service of the selection of fabrication parts.

#### Remarks

After this method has been invoked, call:
`M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetStraightsThatWereNotChanged` to get a set of fabrication part straight element identifiers that were not changed.`M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetElementsThatFailed` to get a set of fabrication part element identifiers that had failures.

#### Parameter `selection`

The set of element identifiers of fabrication parts to change the service for.

#### Parameter `serviceId`

The identifier of the fabrication service.

#### Parameter `paletteId`

The identifier of the fabrication palette.

#### Parameter `restrictPalette`

Restrict the placement of parts to the passed in palette identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The selection contains invalid elements to change.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

No fabrication configuration is loaded.

#### Since

2020

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.ChangeService(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.ChangeService(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.Int32,System.Int32)`

#### Summary

Changes the service of the selection of fabrication parts.

#### Remarks

After this method has been invoked, call:
`M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetStraightsThatWereNotChanged` to get a set of fabrication part straight element identifiers that were not changed.`M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetElementsThatFailed` to get a set of fabrication part element identifiers that had failures.

#### Parameter `selection`

The set of element identifiers of fabrication parts to change the service for.

#### Parameter `serviceId`

The identifier of the fabrication service.

#### Parameter `paletteId`

The identifier of the fabrication palette.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The selection contains invalid elements to change.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

No fabrication configuration is loaded.

#### Since

2018.2

### `P:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.#ctor(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.#ctor(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new instance of the FabricationNetworkChangeService class.

#### Parameter `document`

A document in which to change the service or size of the selected fabrication parts.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018.2

### `T:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService`

#### Summary

This class represents the fabrication part change service and change size tools.

#### Remarks

After a new instance of the class is created, call the ChangeService method to change the service of the
fabrication parts or call the ChangeSize method to change the size of the fabrication parts. There is another
workflow allowing for more control, call SetSelection to set the selection of fabrication parts to change. To change
the service, call SetServiceId and SetPaletteId to set the service identifier and palette identifier. Changing
the service there is an optional methods GetInLinePartTypes and SetMapOfSizesForStraights that can be called
to replace in-line valves and dampers to the corresponding parts for the new service. The size can also be changed by calling
GetMapOfAllSizesForStraights that will return a FabricationPartSizeMapSet containing a map of sizes for all straights
found in the selection of fabrication parts. The FabricationPartSizeMapSet can then be modified to set the mapped values for
the new size for the fabrication part straights and then call SetMapOfSizesForStraights set the new sizes that are to
be applied. Finally call ApplyChange to apply the previously set parameters to the selection of fabrication parts.
`M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetStraightsThatWereNotChanged` to get a set of fabrication part straight element identifiers that were not changed.`M:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService.GetElementsThatFailed` to get a set of fabrication part element identifiers that had failures.

#### Since

2018.2

### `T:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult`

#### Summary

Possible results from invoking the FabricationNetworkChangeService.

#### Since

2018.2

### `F:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult.InvalidSelection`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult.InvalidSelection`

#### Summary

The selection of elements was invalid.

### `F:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult.UserAborted`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult.UserAborted`

#### Summary

The change was aborted by the user.

### `F:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult.PartialFailure`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult.PartialFailure`

#### Summary

The change contained partial failures and will need to be fixed manually.

### `F:Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult.Success`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult.Success`

#### Summary

The change was successful.

### `M:Autodesk.Revit.DB.Connector.GetMEPConnectorInfo`

Member kind: method
Symbol: `Autodesk.Revit.DB.Connector.GetMEPConnectorInfo`

#### Summary

Gets MEP connector information.

#### Returns

Returns `null` if there is no MEP connector information associated.

#### Since

2016

### `M:Autodesk.Revit.DB.Connector.GetFabricationConnectorInfo`

Member kind: method
Symbol: `Autodesk.Revit.DB.Connector.GetFabricationConnectorInfo`

#### Summary

Gets fabrication connectivity information.

#### Returns

Returns `null` if there is no fabrication connector information associated.

#### Since

2016

### `P:Autodesk.Revit.DB.Connector.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Connector.PressureDrop`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.PressureDrop`

#### Summary

The pressure drop of the connector.

#### Remarks

Instantaneous pressure drop of this connector, calculated according to system.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This connector does not support flow calculation and associated properties.

### `P:Autodesk.Revit.DB.Connector.Coefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Coefficient`

#### Summary

The coefficient of the connector.

#### Remarks

Instantaneous coefficient of this connector, calculated according to system.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This connector does not support flow calculation and associated properties.

### `P:Autodesk.Revit.DB.Connector.VelocityPressure`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.VelocityPressure`

#### Summary

The velocity pressure of the connector.

#### Remarks

Instantaneous velocity pressure of this connector,calculated according to system.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This connector does not support flow calculation and associated properties.

### `P:Autodesk.Revit.DB.Connector.Direction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Direction`

#### Summary

The direction of the connector.

#### Remarks

Instantaneous direction of this connector, calculated according to system.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This connector does not support flow calculation and associated properties.

### `P:Autodesk.Revit.DB.Connector.Flow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Flow`

#### Summary

The flow of the connector.

#### Remarks

Instantaneous flow at this connector, calculated according to system.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This connector does not support flow calculation and associated properties.

### `P:Autodesk.Revit.DB.Connector.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Id`

#### Summary

A unique identifier to identify this connector.

#### Since

2016

### `P:Autodesk.Revit.DB.Connector.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Description`

#### Summary

The description.

#### Since

2015

### `P:Autodesk.Revit.DB.Connector.Utility`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Utility`

#### Summary

Indicates if the connector is a utility connector.

#### Since

2015

### `P:Autodesk.Revit.DB.Connector.AllowsSlopeAdjustments`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.AllowsSlopeAdjustments`

#### Summary

Indicates if the connector allows the slope adjustment.

#### Since

2015

### `P:Autodesk.Revit.DB.Connector.GasketLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.GasketLength`

#### Summary

Connector gasket length. When applicable, it represents the distance from the end of the fabrication part to the center of the gasket. Otherwise it returns zero.

#### Since

2024

### `P:Autodesk.Revit.DB.Connector.EngagementLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.EngagementLength`

#### Summary

Connector engagement length. When applicable, it represents the inset distance to the end of the fabrication part from the connection point. Otherwise it returns zero.

### `M:Autodesk.Revit.DB.Connector.IsConnectedTo(Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Connector.IsConnectedTo(Autodesk.Revit.DB.Connector)`

#### Summary

Identifies if the connector is connected to the specified connector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the argument is `null` .

### `M:Autodesk.Revit.DB.Connector.DisconnectFrom(Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Connector.DisconnectFrom(Autodesk.Revit.DB.Connector)`

#### Summary

Remove connection between two connectors.

#### Parameter `connector`

Indicate the connector, connection will be removed from.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Argument is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when no connection between these two connector.
Thrown on failure to remove the connection between these two connectors.

### `M:Autodesk.Revit.DB.Connector.ConnectTo(Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Connector.ConnectTo(Autodesk.Revit.DB.Connector)`

#### Summary

Make connection between two connectors.

#### Parameter `connector`

Indicate the connector will be connected to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Argument is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when two connectors with different domain types.
Thrown when these two connectors fail to connect each other.
Thrown when connection already exists.

#### Remarks

Connection success may create a new Fitting between two connectors, if necessary.

### `P:Autodesk.Revit.DB.Connector.IsMovable`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.IsMovable`

#### Summary

whether the connector can be moved.

#### Remarks

Only connectors of type EndConn can be moved.

### `P:Autodesk.Revit.DB.Connector.Angle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Angle`

#### Summary

The angle of the Connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's domain is not DomainHvac, DomainPiping, or DomainCableTrayConduit.
Thrown when set value for the connector not in family instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when setting an invalid value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to set angle.

#### Remarks

Angle may be assigned for connectors of some family instances.
In order to set this property, it must be mapped to a writable instance parameter in the family definition.
For a connector obtained from a non-family instance (for example not a fitting, but instead a pipe, duct, or
cable tray), the value will always be zero. Non-zero angles are only valid for family instance fitting connectors.

### `P:Autodesk.Revit.DB.Connector.AssignedKCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.AssignedKCoefficient`

#### Summary

The assigned kCoefficient of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's domain is not DomainPiping.
Thrown when the connector is not in a family instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when set an invalid value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get or set kCoefficient.

#### Remarks

Assigned kCoefficient may be assigned for connectors of some family instances, for more information.
In order to set this property, it must be mapped to a writable instance parameter in the family definition.

### `P:Autodesk.Revit.DB.Connector.AssignedFixtureUnits`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.AssignedFixtureUnits`

#### Summary

The assigned fixture units of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's domain is not DomainPiping.
Thrown when the connector is not in a family instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when set an invalid value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get or set assigned fixture units.

#### Remarks

Assigned fixture units may be assigned for connectors of some family instances.

### `P:Autodesk.Revit.DB.Connector.AssignedFlow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.AssignedFlow`

#### Summary

The assigned flow of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's domain is not DomainPiping or DomainHvac.
Thrown when the connector is not in a family instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when set an invalid value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get or set assigned flow.

#### Remarks

Assigned flow may be assigned for connectors of some family instances.
In order to set this property, it must be mapped to a writable instance parameter in the family definition.

### `P:Autodesk.Revit.DB.Connector.AssignedPressureDrop`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.AssignedPressureDrop`

#### Summary

The assigned pressure drop of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector is not in a family instance.
Thrown when the connector's domain is not DomainHvac or DomainPiping.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when set an invalid value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get or set assigned pressure drop.

#### Remarks

Assigned pressure drop may be assigned for connectors of some family instances.
In order to set this property, it must be mapped to a writable instance parameter in the family definition.

### `P:Autodesk.Revit.DB.Connector.AssignedPipeLossMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.AssignedPipeLossMethod`

#### Summary

The pipe loss method of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's domain is not DomainPiping.
Thrown when the connector is not in a family instance.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get pipe loss method.

#### Remarks

Assigned duct pipe loss method may be assigned for connectors of some family instances.

### `P:Autodesk.Revit.DB.Connector.AssignedDuctLossMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.AssignedDuctLossMethod`

#### Summary

The duct loss method of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's domain is not DomainHvac.
Thrown when the connector is not in family instance.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get duct loss method.

#### Remarks

Assigned duct loss method may be assigned for connectors of some family instances.

### `P:Autodesk.Revit.DB.Connector.AssignedDuctFlowConfiguration`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.AssignedDuctFlowConfiguration`

#### Summary

The assigned duct flow configuration of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's domain is not DomainHvac.
Thrown when the connector is not in a family instance.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get duct flow configuration.

#### Remarks

Assigned duct flow configuration may be assigned for connectors of some family instances.

### `P:Autodesk.Revit.DB.Connector.AssignedPipeFlowConfiguration`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.AssignedPipeFlowConfiguration`

#### Summary

The pipe flow configuration type of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's domain is not DomainPiping.
Thrown when the connector is not in a family instance.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get pipe flow configuration.

#### Remarks

Assigned pipe flow configuration may be assigned for connectors of some family instances.

### `P:Autodesk.Revit.DB.Connector.AssignedLossCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.AssignedLossCoefficient`

#### Summary

The assigned loss coefficient of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's domain is not DomainHvac.
Thrown when the connector is not in a family instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when set an invalid value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get or set assigned loss coefficient.

#### Remarks

Assigned loss coefficient may be assigned for connectors of some family instances, for more information.
In order to set this property, it must be mapped to a writable instance parameter in the family definition.

### `P:Autodesk.Revit.DB.Connector.AssignedFlowFactor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.AssignedFlowFactor`

#### Summary

The assigned flow factor of this connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when get assigned flow factor from a connector not in family instance.
Thrown when the connector's domain is not DomainHvac or DomainPiping.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Throw when set an invalid value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get or set assigned flow factor.

#### Remarks

Assigned flow factor may be assigned for connectors of some family instances.
In order to set this property, it must be mapped to a writable instance parameter in the family definition.

### `P:Autodesk.Revit.DB.Connector.IsConnected`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.IsConnected`

#### Summary

Identifies if the connector is physically connected to a connector on another element.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's type is LogicalConn.

### `P:Autodesk.Revit.DB.Connector.MEPSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.MEPSystem`

#### Summary

The system of the connector belong to.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get system.

### `P:Autodesk.Revit.DB.Connector.ConnectorManager`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.ConnectorManager`

#### Summary

The connector manager of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get connector manager.

### `P:Autodesk.Revit.DB.Connector.Demand`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Demand`

#### Summary

The demand of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's domain is not DomainPiping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get demand.

#### Remarks

Instantaneous demand at this connector, calculated according to system.

### `P:Autodesk.Revit.DB.Connector.PipeSystemType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.PipeSystemType`

#### Summary

The pipe system type of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's domain is not DomainPiping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get pipe system type.

#### Remarks

Instantaneous system type at this connector, calculated according to system. For unconnected connectors,
system type is undefined.

### `P:Autodesk.Revit.DB.Connector.ElectricalSystemType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.ElectricalSystemType`

#### Summary

The electrical system type of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's domain is not of DomainElectrical.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get electrical system type.

#### Remarks

Instantaneous system type at this connector, calculated according to system. For unconnected connectors,
system type is undefined.

### `P:Autodesk.Revit.DB.Connector.DuctSystemType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.DuctSystemType`

#### Summary

The duct system type of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's domain is not DomainHvac.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get duct system type.

#### Remarks

This is the instantaneous system type at this connector, calculated according to system. For unconnected connectors,
the system type is undefined.

### `P:Autodesk.Revit.DB.Connector.AssignedFlowDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.AssignedFlowDirection`

#### Summary

The assigned flow direction of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector is not in a family instance.
Thrown when the connector's domain is not DomainHvac or DomainPiping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get assigned flow direction.

#### Remarks

Flow direction may be assigned for connectors of some family instances.

### `P:Autodesk.Revit.DB.Connector.Radius`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Radius`

#### Summary

The radius of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's shape is not round.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the argument is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to set radius.

#### Remarks

In order to set this property, it must be mapped to a writable instance parameter in the family definition.

### `P:Autodesk.Revit.DB.Connector.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Height`

#### Summary

The height of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's shape is not rectangular.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the argument is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to set height.

#### Remarks

In order to set this property, it must be mapped to a writable instance parameter in the family definition.

### `P:Autodesk.Revit.DB.Connector.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Width`

#### Summary

The width of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's shape is not rectangular.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the argument is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to set width.

#### Remarks

In order to set this property, it must be mapped to a writable instance parameter in the family definition.

### `P:Autodesk.Revit.DB.Connector.Shape`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Shape`

#### Summary

The shape of the connector.

### `P:Autodesk.Revit.DB.Connector.ConnectorType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.ConnectorType`

#### Summary

The connector type of the connector.

### `P:Autodesk.Revit.DB.Connector.AllRefs`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.AllRefs`

#### Summary

All references of the connector.

#### Remarks

A set of connectors that the connectors is connected to, including both physical connection and logical connection.

### `P:Autodesk.Revit.DB.Connector.Domain`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Domain`

#### Summary

The domain of the connector.

### `P:Autodesk.Revit.DB.Connector.Owner`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Owner`

#### Summary

The host of the connector.

#### Remarks

The element that contains this connector. It may also contain other connectors.

### `P:Autodesk.Revit.DB.Connector.CoordinateSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.CoordinateSystem`

#### Summary

The coordinate system of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector is of logical type.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to get coordinate system.

#### Remarks

The coordinate system's origin is the location of the connector
and the Z-axis is normal to the connector.

### `P:Autodesk.Revit.DB.Connector.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.Connector.Origin`

#### Summary

The location of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when connector's type is NonEndConn.
Thrown when the connector is a part of a family instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the assigned origin is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown on failure to set origin.

#### Remarks

Changing the location of the connector may lead to changes of location
and geometry for the connector's host element and the hosts for other elements
the element is connected to.

### `T:Autodesk.Revit.DB.Connector`

Member kind: type
Symbol: `Autodesk.Revit.DB.Connector`

#### Summary

A connector in an Autodesk Revit MEP project document.

#### Remarks

This connector is an item that is a part of another element (duct, pipe, fitting, or equipment etc.).
This connector does not represent the connector element that can be created inside a family;
for that element, refer to `T:Autodesk.Revit.DB.ConnectorElement` .

### `M:Autodesk.Revit.DB.FabricationHostedInfo.DisconnectFromHost`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationHostedInfo.DisconnectFromHost`

#### Summary

Disconnects the part from the host.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationHostedInfo.GetBearerCenterline`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationHostedInfo.GetBearerCenterline`

#### Summary

Gets the centerline of the bearer. The method is applicable only for bearer hanger.

#### Returns

The centerline of the bearer.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The hanger is not a bearer hanger.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationHostedInfo.PlaceOnHost(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationHostedInfo.PlaceOnHost(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,System.Double,System.Double)`

#### Summary

Places the part on the specified host.

#### Remarks

The document must be regenerated before the fabrication part can be used.
Check `T:ValidationStatus` after regeneration to see if the part is valid for fabrication.

#### Parameter `hostId`

Identifier of the host fabrication part.

#### Parameter `hostConnector`

The connector of the host.

#### Parameter `distance`

The distance from the connector to place the hosted part. Units are in feet (ft).

#### Parameter `axisRotation`

The axis rotation in radians.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid fabrication part host. The host should be a straight fabrication part.
-or-
Invalid connector of fabrication part host.
-or-
The distance is out of range.
-or-
For rectangular and oval parts the axis rotation must be a multiple of PI/2.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationHostedInfo.PlaceOnHost(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationHostedInfo.PlaceOnHost(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,System.Double)`

#### Summary

Places the part on the specified host.

#### Remarks

The document must be regenerated before the fabrication part can be used.
Check `T:ValidationStatus` after regeneration to see if the part is valid for fabrication.

#### Parameter `hostId`

Identifier of the host fabrication part.

#### Parameter `hostConnector`

The connector of the host.

#### Parameter `distance`

The distance from the connector to place the hosted part. Units are in feet (ft).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid fabrication part host. The host should be a straight fabrication part.
-or-
Invalid connector of fabrication part host.
-or-
The distance is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationHostedInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationHostedInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FabricationHostedInfo.HostId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationHostedInfo.HostId`

#### Summary

Returns the identifier of the host.

#### Since

2016

### `T:Autodesk.Revit.DB.FabricationHostedInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationHostedInfo`

#### Summary

The fabrication hosted element information.

#### Remarks

A fabrication part may have a host, the FabricationHostedInfo stores the host information for the fabrication part.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationDimensionDefinition.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationDimensionDefinition.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FabricationDimensionDefinition.IsModifiable`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationDimensionDefinition.IsModifiable`

#### Summary

If the fabrication dimension is modifiable by user.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationDimensionDefinition.UnitType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationDimensionDefinition.UnitType`

#### Summary

Fabrication dimension unit type.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationDimensionDefinition.Type`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationDimensionDefinition.Type`

#### Summary

Fabrication dimension type.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationDimensionDefinition.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationDimensionDefinition.Name`

#### Summary

Fabrication dimension name.

#### Since

2016

### `T:Autodesk.Revit.DB.FabricationDimensionDefinition`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationDimensionDefinition`

#### Summary

Fabricaition dimension definition

#### Since

2016

### `T:Autodesk.Revit.DB.FabricationDimensionUnitType`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationDimensionUnitType`

#### Summary

Fabrication dimension unit type.

#### Since

2016

### `F:Autodesk.Revit.DB.FabricationDimensionUnitType.Angular`

Member kind: field
Symbol: `Autodesk.Revit.DB.FabricationDimensionUnitType.Angular`

#### Summary

Angular.

### `F:Autodesk.Revit.DB.FabricationDimensionUnitType.Linear`

Member kind: field
Symbol: `Autodesk.Revit.DB.FabricationDimensionUnitType.Linear`

#### Summary

Linear.

### `F:Autodesk.Revit.DB.FabricationDimensionUnitType.NoUnits`

Member kind: field
Symbol: `Autodesk.Revit.DB.FabricationDimensionUnitType.NoUnits`

#### Summary

NoUnits.

### `T:Autodesk.Revit.DB.FabricationDimensionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationDimensionType`

#### Summary

Fabrication dimension type.

#### Since

2016

### `F:Autodesk.Revit.DB.FabricationDimensionType.Length`

Member kind: field
Symbol: `Autodesk.Revit.DB.FabricationDimensionType.Length`

#### Summary

Length.

### `F:Autodesk.Revit.DB.FabricationDimensionType.Angle`

Member kind: field
Symbol: `Autodesk.Revit.DB.FabricationDimensionType.Angle`

#### Summary

Angle.

### `F:Autodesk.Revit.DB.FabricationDimensionType.Diameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.FabricationDimensionType.Diameter`

#### Summary

Diameter.

### `F:Autodesk.Revit.DB.FabricationDimensionType.Depth`

Member kind: field
Symbol: `Autodesk.Revit.DB.FabricationDimensionType.Depth`

#### Summary

Depth.

### `F:Autodesk.Revit.DB.FabricationDimensionType.Width`

Member kind: field
Symbol: `Autodesk.Revit.DB.FabricationDimensionType.Width`

#### Summary

Width.

### `F:Autodesk.Revit.DB.FabricationDimensionType.Internal`

Member kind: field
Symbol: `Autodesk.Revit.DB.FabricationDimensionType.Internal`

#### Summary

Internal.

### `M:Autodesk.Revit.DB.FabricationConnectorInfo.HasDoubleWallConnector`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConnectorInfo.HasDoubleWallConnector`

#### Summary

Checks if there are any double wall connectors fabricated.

#### Returns

True if there are any double wall connectors fabricated.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConnectorInfo.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConnectorInfo.IsValid`

#### Summary

Checks if the connector has fabrication parameters associated with it that can be set.

#### Returns

True if the connector has fabrication parameters associated with it that can be set.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationConnectorInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConnectorInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FabricationConnectorInfo.IsDoubleWallConnectorLocked`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConnectorInfo.IsDoubleWallConnectorLocked`

#### Summary

Fabrication double wall connector lock.

#### Remarks

If set this prevents the connector value being overridden by the fabrication specification.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

No double wall connector available.
-or-
When setting this property: the connector cannot be modified on an owned fabrication part.
-or-
When setting this property: the connector is already connected.
-or-
When setting this property: the fabrication part is connected to more than one item.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationConnectorInfo.DoubleWallConnectorId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConnectorInfo.DoubleWallConnectorId`

#### Summary

Fabrication double wall connector Id.

#### Remarks

A reference to the fabrication configuration connectors.
Setting the connector value will also set the connector lock.
A value of 0 indicates no connector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: doubleWallConnectorId is invalid based on the shape and domain.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

No double wall connector available.
-or-
When setting this property: the connector cannot be modified on an owned fabrication part.
-or-
When setting this property: the connector is already connected.
-or-
When setting this property: the fabrication part is connected to more than one item.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationConnectorInfo.FabricationIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConnectorInfo.FabricationIndex`

#### Summary

The index of the connector shown within the fabrication software.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationConnectorInfo.IsBodyConnectorLocked`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConnectorInfo.IsBodyConnectorLocked`

#### Summary

Fabrication body connector lock.

#### Remarks

If set this prevents the connector value being overridden by the fabrication specification.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: the connector cannot be modified on an owned fabrication part.
-or-
When setting this property: the connector is already connected.
-or-
When setting this property: the fabrication part is connected to more than one item.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationConnectorInfo.BodyConnectorId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConnectorInfo.BodyConnectorId`

#### Summary

Fabrication body connector Id.

#### Remarks

A reference to the fabrication configuration connectors.
Setting the connector value will also set the connector lock.
A value of 0 indicates the connector is set to none.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: bodyConnectorId is invalid based on the shape and domain.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: the connector cannot be modified on an owned fabrication part.
-or-
When setting this property: the connector is already connected.
-or-
When setting this property: the fabrication part is connected to more than one item.

#### Since

2016

### `T:Autodesk.Revit.DB.FabricationConnectorInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationConnectorInfo`

#### Summary

Fabrication connector information.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationService.GetButton(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationService.GetButton(System.Int32,System.Int32)`

#### Summary

Gets the service button for a given palette index and button index from the service.

#### Parameter `paletteIndex`

The palette index.

#### Parameter `buttonIndex`

The button index.

#### Returns

The service button.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index paletteIndex is not larger or equal to 0 and less than PaletteCount.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationService.IsValidButtonIndex(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationService.IsValidButtonIndex(System.Int32,System.Int32)`

#### Summary

Validates the button index.

#### Parameter `paletteIndex`

The palette index.

#### Parameter `buttonIndex`

The button index to check.

#### Returns

True if larger or equal to 0 and less than PaletteCount.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationService.GetButtonCount(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationService.GetButtonCount(System.Int32)`

#### Summary

Gets the number of buttons for a given palette in the service.

#### Parameter `palette`

The index of the palette

#### Returns

The number of buttons.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index palette is not larger or equal to 0 and less than PaletteCount.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationService.OverrideServiceButtonExclusion(System.Int32,System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationService.OverrideServiceButtonExclusion(System.Int32,System.Int32,System.Boolean)`

#### Summary

Overrides the default service button exclusions, used by Route and Fill, Design to Fabrication, or Multi Point Routing for the current user and session only.

#### Parameter `paletteIndex`

The index of the service palette to exclude the service button from.

#### Parameter `buttonIndex`

The index of the service button to exclude.

#### Parameter `exclude`

Pass true to exclude from being used by Route and Fill or Design to Fabrication.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index paletteIndex is not larger or equal to 0 and less than PaletteCount.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationService.ResetServiceExclusionOverrides`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationService.ResetServiceExclusionOverrides`

#### Summary

Resets the overridden service palette and button exclusions back to default, as defined by the configuration.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationService.SetServicePaletteExclusions(System.Collections.Generic.IList{System.Int32})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationService.SetServicePaletteExclusions(System.Collections.Generic.IList{System.Int32})`

#### Summary

Sets the service palette exclusions, used by Route and Fill or Design to Fabrication commands, for the current user and session only. This will alter them from the default configuration exclusions to only exclude those palettes passed.

#### Parameter `excludedPalettes`

A list of service palette indexes to be excluded.

#### Returns

Returns true if succeeded to set the exclusions to the specified palette(s).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Palette indices contains an index that is not larger or equal to 0 and less than PaletteCount.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2022

### `M:Autodesk.Revit.DB.FabricationService.IsPaletteExcluded(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationService.IsPaletteExcluded(System.Int32)`

#### Summary

Get whether a service palette is excluded from being used by the Route and Fill, Design to Fabrication, or Multi Point Routing commands. The default configuration values may be overridden by SetServicePaletteExclusions.

#### Parameter `paletteIndex`

The index of the palete.

#### Returns

Returns true if the palette indexed by paletteIndex is currently to be excluded.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index paletteIndex is not larger or equal to 0 and less than PaletteCount.

#### Since

2022

### `M:Autodesk.Revit.DB.FabricationService.IsCompatibleWith(Autodesk.Revit.DB.FabricationService)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationService.IsCompatibleWith(Autodesk.Revit.DB.FabricationService)`

#### Summary

Check whether the service is broadly interchangable with another one without affecting part geometry. The services must have the same fabrication system template and specification.

#### Returns

Returns true if the services are compatible.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationService.GetPaletteName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationService.GetPaletteName(System.Int32)`

#### Summary

Gets the name of a palette based on palette index.

#### Parameter `palette`

The index of the palette.

#### Returns

The name of the palette.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index palette is not larger or equal to 0 and less than PaletteCount.

#### Since

2022

### `M:Autodesk.Revit.DB.FabricationService.IsValidPaletteIndex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationService.IsValidPaletteIndex(System.Int32)`

#### Summary

Validates the palette index.

#### Parameter `paletteIndex`

The palette index to check.

#### Returns

True if larger or equal to 0 and less than PaletteCount.

#### Since

2022

### `P:Autodesk.Revit.DB.FabricationService.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationService.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FabricationService.PartTemplateId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationService.PartTemplateId`

#### Summary

The part template identifier of the service.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationService.ServiceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationService.ServiceId`

#### Summary

The service identifier of the service.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationService.PaletteCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationService.PaletteCount`

#### Summary

The number of palettes in the service.

#### Since

2022

### `P:Autodesk.Revit.DB.FabricationService.FabricationSystemName`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationService.FabricationSystemName`

#### Summary

The fabrication system name of the service.

#### Remarks

A fabrication system in this context is a set of buttons that can be shared across fabrication services.
It has nothing to do with other MEP systems in Revit.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationService.Abbreviation`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationService.Abbreviation`

#### Summary

The short name of service.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationService.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationService.Name`

#### Summary

The name of the service.

#### Since

2016

### `T:Autodesk.Revit.DB.FabricationService`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationService`

#### Summary

This object contains information about a fabrication service.

#### Remarks

A fabrication service defines what fabrication service buttons that can be used. Fabrication services are part of the fabrication configuration.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.ResetPartGuid`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.ResetPartGuid`

#### Summary

force new part GUID

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.IsStraightLengthStandard`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.IsStraightLengthStandard`

#### Summary

Checks if the straight part's length is standard. For machine cut part, False will be returned.

#### Returns

True if the straight part's length is standard.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.FixDuplicateGUIDs(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.FixDuplicateGUIDs(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Eliminate duplicate or blank part GUIDs by assiging new GUIDs to affected parts.

#### Parameter `document`

The document.

#### Parameter `ids`

List of element Ids of fabrication parts to fix. Will attempt to fix all parts in the document if none are passed.

#### Returns

Returns a list of fabrication part element Ids that were changed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.GetInsulationLiningGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetInsulationLiningGeometry`

#### Summary

Gets insulation and lining geometry for this fabrication part.

#### Returns

Returns any insulation and liner geometry.

#### Since

2019.1

### `M:Autodesk.Revit.DB.FabricationPart.IsSameAs(Autodesk.Revit.DB.FabricationPart,System.Collections.Generic.IList{Autodesk.Revit.DB.Fabrication.FabricationPartCompareType})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.IsSameAs(Autodesk.Revit.DB.FabricationPart,System.Collections.Generic.IList{Autodesk.Revit.DB.Fabrication.FabricationPartCompareType})`

#### Summary

Compare this fabrication part with the part passed and checks the pattern dimensions and options. A list of fields that can be ignored in the comparison check can be specified.

#### Parameter `part`

The part to compare this part with.

#### Parameter `ignoreFields`

Array of types of data to ignore from the comparison check.

#### Returns

Returns true if the fabrication parts are the same.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationPart.GetPartAncillaryUsage`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetPartAncillaryUsage`

#### Summary

Gets a list of all ancillary usage information for the part.

#### Returns

Returns array of usage information, one per unique type of ancillary used.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationPart.RemovePartCustomData(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.RemovePartCustomData(System.Int32)`

#### Summary

Remove custom data from the fabrication part.

#### Parameter `customId`

The identifier of the custom data field to remove.

#### Returns

Returns true if the type was found and removed. The type will not be removed if it is not an optional type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The custom data does not exist on the part.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationPart.AddPartCustomData(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.AddPartCustomData(System.Int32)`

#### Summary

Add custom data type to the fabrication part. The new data gets the default value defined by the fabrication configuration.

#### Remarks

The custom id must be positive.

#### Parameter `customId`

The identifier of the custom data field to add.

#### Returns

Returns true if the type was not already present.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The custom data identifier does not exist.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationPart.SetPartCustomDataReal(System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.SetPartCustomDataReal(System.Int32,System.Double)`

#### Summary

Set the custom data real value for the specified custom data.

#### Parameter `customId`

The identifier of the custom data field to set.

#### Parameter `value`

The real value of the custom data. If the data is not a real type the value will be parsed according to the fabrication confifuration rules.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The custom data does not exist on the part.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationPart.SetPartCustomDataInteger(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.SetPartCustomDataInteger(System.Int32,System.Int32)`

#### Summary

Set the custom data integer value for the specified custom data.

#### Parameter `customId`

The identifier of the custom data field to set.

#### Parameter `value`

The integer value of the custom data. If the data is not an integer type the value will be parsed according to the fabrication confifuration rules.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The custom data does not exist on the part.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationPart.SetPartCustomDataText(System.Int32,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.SetPartCustomDataText(System.Int32,System.String)`

#### Summary

Set the custom data real value for the specified custom data.

#### Parameter `customId`

The identifier of the custom data field to set.

#### Parameter `value`

The text value of the custom data. If the data is not a text type the value will be parsed according to the fabrication confifuration rules.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The custom data does not exist on the part.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationPart.GetPartCustomDataReal(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetPartCustomDataReal(System.Int32)`

#### Summary

Get custom data real value for the specified custom data.

#### Parameter `customId`

The identifier of the custom data field to get.

#### Returns

Returns the real number of the custom data. If the data is not a number it will return 0.0.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The custom data does not exist on the part.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationPart.GetPartCustomDataInteger(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetPartCustomDataInteger(System.Int32)`

#### Summary

Get custom data integer value for the specified custom data.

#### Parameter `customId`

The identifier of the custom data field to get.

#### Returns

Returns the integer of the custom data. If the data is not a number it will return 0.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The custom data does not exist on the part.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationPart.GetPartCustomDataText(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetPartCustomDataText(System.Int32)`

#### Summary

Get custom data text for the specified custom data.

#### Parameter `customId`

The identifier of the custom data field to get.

#### Returns

Returns the text of the custom data. If the data is a number it will be formatted according to the fabrication configuration's rules.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The custom data does not exist on the part.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationPart.HasCustomData(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.HasCustomData(System.Int32)`

#### Summary

Check if fabrication part contains custom data already.

#### Parameter `customId`

The identifier of the custom data field to look for.

#### Returns

Returns true if the fabrication part contains the custom data.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationPart.HasNoConnections`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.HasNoConnections`

#### Summary

Checks to see if all the fabrication part's connectors are open.

#### Returns

Returns true if the part has zero connections.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationPart.RotateConnectedPartByConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.RotateConnectedPartByConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,System.Double)`

#### Summary

Rotates a connected fabrication part around the axis of the specified connector.

#### Remarks

Attempts to resize rectangular and oval ends if the angle is a multiple of PI/2.
Taps cannot be rotated.
For rectangular and oval profiles only 90, 180 and 270 degree rotations are valid.

#### Parameter `document`

The document.

#### Parameter `connector`

The connected connector of the fabrication part to be rotated.

#### Parameter `axisRotationBy`

The angle in radians to rotate by.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

For rectangular and oval parts the axis rotation must be a multiple of PI/2.
-or-
The connector does not belong to a fabrication part.
-or-
Connector is not connected.
-or-
Connector belongs to a fabrication part tap.
-or-
Fabrication part cannot be rotated because it is either unable to be re-sized or it is too constrained.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

rotate failed because the fabrication part geometry could not be modified accordingly.

#### Since

2016 Subscription Release

### `M:Autodesk.Revit.DB.FabricationPart.PlaceFittingAsCutIn(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Connector,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.PlaceFittingAsCutIn(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Connector,System.Double)`

#### Summary

Places the fitting on the straight part by cut in, use the fitting's focal point as the insertion position.

#### Parameter `document`

The document.

#### Parameter `straightId`

Identifier of the straight to be cut in.

#### Parameter `fittingId`

Identifier of the fitting to cut in.

#### Parameter `position`

The position to cut in the straight.

#### Parameter `fittingConnector`

The connector of the fitting to align with the primary connector of the straight part.

#### Parameter `axisRotation`

Rotation around the direction of connection - angle between width vectors in radians.

#### Returns

True if cuts in successful.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

For rectangular and oval parts the axis rotation must be a multiple of PI/2.
-or-
The fitting connector is not a connector of the fitting.
-or-
The fitting connector is not valid, it is not within a pair connector for cutting in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to align fitting to the straight to cut in.
-or-
There is no enough room in the run for cut in.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationPart.PlaceAsTap(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.PlaceAsTap(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,System.Double,System.Double,System.Double)`

#### Summary

Places the part by its connector to a specific position on the straight part at the specified distance from the host part connector.

#### Remarks

Tap cannot be placed if it is already connected.

#### Parameter `document`

The document.

#### Parameter `tapPartConnector`

The connector of the part to place.

#### Parameter `hostPartConnector`

The connector of host part.

#### Parameter `distance`

The distance to host part connector where to place the part.

#### Parameter `axisRotation`

The axis rotation in radians.

#### Parameter `secondaryAxisRotation`

The secondary axis rotation in radians.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It is not a valid part to place as tap.
-or-
Tap should be placed on straight part.
-or-
The distance is out of range.
-or-
For rectangular and oval parts the axis rotation must be a multiple of PI/2.
-or-
Invalid tap for host's profile type.
-or-
The fabrication part is connected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

tap is not connected by its primary connector.

#### Exception `!:Autodesk::Revit::Exceptions::InvalidOpertationException`

tap does not fit on the host.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.RotateConnectedTap(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationPart,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.RotateConnectedTap(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationPart,System.Double,System.Double)`

#### Summary

Rotates a connected fabrication tap by the specified angles about the primary and secondary axis.

#### Parameter `document`

The document.

#### Parameter `tap`

The connected fabrication part tap to rotate.

#### Parameter `primaryAxisRotateBy`

The primary axis rotation angle in radians to rotate by.

#### Parameter `secondaryAxisRotateBy`

The secondary axis rotation angle in radians to rotate by.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Is not connected as a fabrication part tap.
-or-
tap cannot be rotated about the primary axis by the specified angle: primaryAxisRotateBy
-or-
tap cannot be rotated about the secondary axis by the specified angle: secondaryAxisRotateBy

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Release

### `M:Autodesk.Revit.DB.FabricationPart.AlignPartByInsertionPointAndCutInToStraight(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.AlignPartByInsertionPointAndCutInToStraight(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Boolean)`

#### Summary

Align the part by its insertion point to a point and rotation on a straight. This will automatically size and connect the part being cut into, if possible.

#### Parameter `document`

The document.

#### Parameter `straightId`

The element identifier of the straight to be cut in to.

#### Parameter `partId`

The element identifier of the part to align and cut in with.

#### Parameter `position`

The position to move the parts insertion point to.

#### Parameter `rotation`

The rotation in radians.

#### Parameter `slope`

The slope value to flex to match if possible in fractional units (eg.1/50). Positive values are up, negative are down. Slopes can only be applied
to fittings, whilst straights will inherit the slope from the piece it is connecting to.

#### Parameter `flip`

Flip the part to allow for flow direction.

#### Returns

True if the alignment succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element is not a fabrication part.
-or-
Not all of the fabrication part's connectors are open.
-or-
The part is not a straight.
-or-
The fabrication parts do not have matching domain types.
-or-
The position is not on the straight.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to align the part to the straight to cut in to.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationPart.AlignPartByConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Fabrication.FabricationPartJustification,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.AlignPartByConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Fabrication.FabricationPartJustification,Autodesk.Revit.DB.Transform)`

#### Summary

Align the part by its connector to a point and rotation in free space.

#### Parameter `document`

The document.

#### Parameter `connector`

The connector to align in free space.

#### Parameter `position`

The position to move the connector to.

#### Parameter `rotation`

The rotation in radians.

#### Parameter `rotationPerpendicular`

The perpendicular rotation for free placement around the Y axis direction of connection - angle in radians.

#### Parameter `slope`

The slope value to flex to match if possible in fractional units (eg.1/50). Positive values are up, negative are down. Slopes can only be applied
to fittings, whilst straights will inherit the slope from the piece it is connecting to.

#### Parameter `justification`

The justification to align eccentric parts.

#### Parameter `trf`

Optional alignment transformation matrix, eg. a Trf that describes plan or side elevation.

#### Returns

True if the alignment succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The connector does not belong to a fabrication part.
-or-
The fabrication part is connected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationPart.AlignPartByInsertionPoint(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Fabrication.FabricationPartJustification,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.AlignPartByInsertionPoint(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Fabrication.FabricationPartJustification,Autodesk.Revit.DB.Transform)`

#### Summary

Align the part by its insertion point to a point and rotation in free space.

#### Parameter `document`

The document.

#### Parameter `partId`

The element identifier of the part to align.

#### Parameter `position`

The position to move the part's insertion point to.

#### Parameter `rotation`

The rotation in radians.

#### Parameter `rotationPerpendicular`

The perpendicular rotation for free placement around the Y axis direction of connection - angle in radians.

#### Parameter `slope`

The slope value to flex to match if possible in fractional units (eg.1/50). Positive values are up, negative are down. Slopes can only be applied
to fittings, whilst straights will inherit the slope from the piece it is connecting to.

#### Parameter `justification`

The justification to align eccentric parts.

#### Parameter `trf`

Optional alignment transformation matrix, eg. a Trf that describes plan or side elevation.

#### Returns

True if the alignment succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element is not a fabrication part.
-or-
Not all of the fabrication part's connectors are open.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationPart.AlignPartByConnectorToConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,System.Double,System.Double,Autodesk.Revit.DB.Fabrication.FabricationPartJustification)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.AlignPartByConnectorToConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,System.Double,System.Double,Autodesk.Revit.DB.Fabrication.FabricationPartJustification)`

#### Summary

Align a part by its connector to another connector. This will replace the FabricationPart::AlignPartByConnectors method.

#### Parameter `document`

The document.

#### Parameter `connector`

The connector of the fabrication part to move by in free space.

#### Parameter `fixedConnector`

The connector for the fabrication part or family connector to align to.

#### Parameter `rotation`

The rotation in radians.

#### Parameter `slope`

The slope value to flex to match if possible in fractional units (eg.1/50). Positive values are up, negative are down. Slopes can only be applied
to fittings, whilst straights will inherit the slope from the piece it is connecting to.

#### Parameter `justification`

The justification to align eccentric parts.

#### Returns

True if the alignment succeeds, false otherwise and the part will not move from the original position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

For rectangular and oval parts the axis rotation must be a multiple of PI/2.
-or-
The connector does not belong to a fabrication part.
-or-
The fabrication part is connected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationPart.AlignPartByConnectors(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.AlignPartByConnectors(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,System.Double)`

#### Summary

Moves fabrication part by one of its connectors and aligns it to another connector.

#### Parameter `document`

The document.

#### Parameter `connector`

The connector of the fabrication part to move and align by.

#### Parameter `toConnector`

The connector of the fabrication part or family to align to.

#### Parameter `axisRotation`

Rotation around the direction of connection - angle between width vectors in radians.

#### Returns

True if alignment succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

For rectangular and oval parts the axis rotation must be a multiple of PI/2.
-or-
The connector does not belong to a fabrication part.
-or-
The fabrication part is connected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.ConnectAndCouple(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.ConnectAndCouple(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Makes a connection between the specified connectors and adds coupling if necessary.

#### Remarks

This function does not place and align the fabrication part. Call `M:Autodesk.Revit.DB.FabricationPart.AlignPartByConnectors(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,System.Double)` before connecting.

#### Parameter `document`

The document.

#### Parameter `connector`

The connector of the fabrication part.

#### Parameter `toConnector`

The connector of the fabrication part or family to connect to.

#### Returns

True if connection succeeded, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The connector does not belong to a fabrication part.
-or-
The fabrication part connectors are not aligned, call `M:Autodesk.Revit.DB.FabricationPart.AlignPartByConnectors(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,System.Double)` to align them.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.Flip`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.Flip`

#### Summary

Flips the fabrication part that is directionally oriented (tees, crosses, valves, dampers, etc.) to the opposite direction.

#### Remarks

Existing connections will be maintained, disconnect warnings will be posted if the connection cannot be maintained.

#### Returns

Returns true if successful otherwise false if the fabrication part cannot be flipped.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

It is not a valid part that can be flipped.

#### Since

2023

### `M:Autodesk.Revit.DB.FabricationPart.CanFlipPart`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.CanFlipPart`

#### Summary

Validates if the fabrication part is one of the supported fabrication part types that can be flipped.

#### Returns

Returns true if valid otherwise false if the fabrication part cannot be flipped.

#### Since

2023

### `M:Autodesk.Revit.DB.FabricationPart.SplitStraight(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.SplitStraight(Autodesk.Revit.DB.XYZ)`

#### Summary

Splits the straight into two at the passed in point.

#### Parameter `position`

The position to split in the straight.

#### Returns

Returns the element identifier of the new straight.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The position is not on the straight.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The part is not a straight.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationPart.SplitStraight(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.SplitStraight(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

#### Summary

Splits the straight into two at the passed in point.

#### Parameter `document`

The document.

#### Parameter `partId`

Identifier of the straight to split.

#### Parameter `position`

The position to split in the straight.

#### Returns

Returns the element identifier of the new straight.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The part is not a straight.
-or-
The position is not on the straight.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationPart.CanSplitStraight(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.CanSplitStraight(Autodesk.Revit.DB.XYZ)`

#### Summary

Validates if the straight can be split into two at the passed in point.

#### Parameter `position`

The position to split in the straight.

#### Returns

Returns true if valid otherwise false if the straight cannot be split.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationPart.Reposition(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.Reposition(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Repositions the fabrication straight part to another end of the run.

#### Parameter `document`

The document.

#### Parameter `partId`

Identifier of the fabrication part to reposition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It is not a straight segment on the end in the run.
-or-
There are locked parts in the run.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

this operation failed.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationPart.OptimizeLengths(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.OptimizeLengths(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Optimizes the length fabrication straight parts.

#### Parameter `document`

The document.

#### Parameter `partIds`

The identifiers of the fabrication parts in a selected fabrication part run.

#### Returns

New and modified fabrication part ids in the optimize

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There are no straight parts to optimize, or all parts are locked or locked by group membership.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

this operation failed.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.GetProductListEntryCount`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetProductListEntryCount`

#### Summary

Gets the number of product entries for this part.

#### Returns

Returns the number of product entries.

#### Since

2016 Subscription Release

### `M:Autodesk.Revit.DB.FabricationPart.GetProductListEntryName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetProductListEntryName(System.Int32)`

#### Summary

Gets the specified product list entry name.

#### Parameter `index`

The product entry index.

#### Returns

Returns the specified product entry name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The product entry index is not larger than 0 and less than GetProductCount.

#### Since

2016 Subscription Release

### `M:Autodesk.Revit.DB.FabricationPart.IsProductList`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.IsProductList`

#### Summary

Gets whether or not the fabrication part is a product list.

#### Returns

Returns true if the fabrication part is a product list.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

the fabrication part is not a product list.

#### Since

2016 Subscription Release

### `M:Autodesk.Revit.DB.FabricationPart.IsATap`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.IsATap`

#### Summary

Checks if it is any sort of tap.

#### Returns

True if it is any sort of tap.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.IsAHanger`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.IsAHanger`

#### Summary

Checks whether it is a hanger.

#### Returns

True if the part is a hanger. False otherwise.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.IsAStraight`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.IsAStraight`

#### Summary

Checks whether it is a straight part.

#### Returns

True if the part is a straight part. False otherwise.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.AdjustEndLength(Autodesk.Revit.DB.Connector,System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.AdjustEndLength(Autodesk.Revit.DB.Connector,System.Double,System.Boolean)`

#### Summary

Adjusts the length for the specified connector.

#### Parameter `connector`

# The connector of the fabrication part to adjust length.

#### Parameter `lengthToAdjust`

The length to adjust.

#### Parameter `totalLengthOnly`

True if adjust the total length only when adjust length.

#### Returns

The adjusted length.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The end of the fabrication part of the connector can not be adjusted.
-or-
Connector is connected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationPart.CanAdjustEndLength(Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.CanAdjustEndLength(Autodesk.Revit.DB.Connector)`

#### Summary

Checks if the end of fabrication part can be adjusted.

#### Parameter `connector`

The connector of the fabrication part to adjust length.

#### Returns

True if the end of fabrication part can be adjusted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationPart.SetCalculatedDimensionValue(Autodesk.Revit.DB.FabricationDimensionDefinition,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.SetCalculatedDimensionValue(Autodesk.Revit.DB.FabricationDimensionDefinition,System.String)`

#### Summary

Sets the calculated dimension value.

#### Remarks

Multiple dimensions may need to be set in order to reach the desired outcome.
The document must be regenerated before the fabrication part can be used.
Check `P:Autodesk.Revit.DB.FabricationPart.ValidationStatus` after regeneration to see if the part is valid for fabrication.

#### Parameter `dim`

The fabrication dimension.

#### Parameter `value`

The calculated dimension value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

value is not a valid calculated fabrication dimension value.
-or-
fabrication dimension is unable to be modified because it is locked or from a product list.
-or-
the fabrication dimension is unable to be modified because it will affect the geometry of a connected end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

the fabrication dimension is unable to be modified because the fabrication part is connected to more than one object.
-or-
the fabrication dimension cannot be set to the option: value.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.GetCalculatedDimensionValue(Autodesk.Revit.DB.FabricationDimensionDefinition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetCalculatedDimensionValue(Autodesk.Revit.DB.FabricationDimensionDefinition)`

#### Summary

Gets the calculated dimension value.

#### Parameter `dim`

The fabrication dimension.

#### Returns

The calculated dimension value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.GetDimensionCalculatedOptions(Autodesk.Revit.DB.FabricationDimensionDefinition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetDimensionCalculatedOptions(Autodesk.Revit.DB.FabricationDimensionDefinition)`

#### Summary

Gets the calculated options of the fabrication dimension.

#### Parameter `dim`

The fabrication dimension.

#### Returns

The calculated options of the fabrication dimension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.IsDimensionCalculated(Autodesk.Revit.DB.FabricationDimensionDefinition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.IsDimensionCalculated(Autodesk.Revit.DB.FabricationDimensionDefinition)`

#### Summary

Checks if the fabrication dimension is calculated.

#### Parameter `dim`

The fabrication dimension.

#### Returns

True if the fabrication dimension is calculated.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.SetDimensionValue(Autodesk.Revit.DB.FabricationDimensionDefinition,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.SetDimensionValue(Autodesk.Revit.DB.FabricationDimensionDefinition,System.Double)`

#### Summary

Sets the fabrication dimension value. The value is in Revit internal units.

#### Remarks

Multiple dimensions may need to be set in order to reach the desired outcome.
The document must be regenerated before the fabrication part can be used.
Check `P:Autodesk.Revit.DB.FabricationPart.ValidationStatus` after regeneration to see if the part is valid for fabrication.

#### Parameter `dim`

The fabrication dimension.

#### Parameter `newValue`

The dimension value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fabrication dimension is unable to be modified because it is locked or from a product list.
-or-
the fabrication dimension is unable to be modified because it will affect the geometry of a connected end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

the fabrication dimension is unable to be modified because the fabrication part is connected to more than one object.
-or-
the fabrication dimension cannot be set to the value: newValue.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.GetDimensionValue(Autodesk.Revit.DB.FabricationDimensionDefinition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetDimensionValue(Autodesk.Revit.DB.FabricationDimensionDefinition)`

#### Summary

Gets the value of the fabrication dimension, returns value in Revit internal units.

#### Parameter `dim`

The fabrication dimension.

#### Returns

The dimension value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.GetDimensions`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetDimensions`

#### Summary

Gets all fabrication dimensions.

#### Returns

Returns an array of fabrication dimensions.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.SetPositionByEnd(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.SetPositionByEnd(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.XYZ)`

#### Summary

Positions the connector of the fabrication part element by the passed point.

#### Parameter `connector`

The connector of the fabrication part element.

#### Parameter `position`

The position to move to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

this operation failed.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.GetTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetTransform`

#### Summary

Gets the transformation matrix of the fabrication part element.

#### Returns

The transformation matrix of the fabrication part element.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.CanASlopeBeApplied`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.CanASlopeBeApplied`

#### Summary

This will test if a slope can be applied to the part and maintain connections with any connected parts.

#### Returns

Returns true if the part can be successfully sloped otherwise false.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationPart.SaveAsFabricationJob(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.String,Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.SaveAsFabricationJob(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.String,Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions)`

#### Summary

Save fabrication parts to an MEP job that can be opened in the fabrication software.

#### Remarks

Only fabrication MAJ files are supported.

#### Parameter `document`

The document.

#### Parameter `ids`

List of element Ids of fabrication parts or assemblies and group elements that contain fabrication parts to save. Non-fabrication part elements will be ignored.

#### Parameter `filename`

The full path and filename of the fabrication job to save.

#### Parameter `saveOptions`

Options for the save operation.

#### Returns

Returns a list of fabrication part element Ids that were saved to the fabrication job.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Fabrication configuration is missing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

the path to the filename must already exist and be writeable

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The destination file name includes one or more invalid characters.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationPart.StretchAndFit(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.StretchAndFit(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId}@)`

#### Summary

Stretch the fabrication part from the specified connector and fit to the target routing end.

#### Remarks

Cannot stretch and fit fabrication part straight, tap or hanger.

#### Parameter `document`

The document in which to perform the stretch and fit.

#### Parameter `stretchConnector`

The connector of the fabrication part to be stretched.

#### Parameter `target`

The target routing end to align and fit to.

#### Parameter `newPartIds`

New fabrication part element identifiers.

#### Returns

Returns FabricationPartFitResult::Success if successful.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Connector does not belong to a fabrication part with a valid fabrication service.
-or-
Connector is connected.
-or-
Connector belongs to a fabrication part straight, tap, or hanger.
-or-
Routing end is valid to route to.
-or-
stretch target end type must be a supported type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

fabrication part is not connected at one end only.
-or-
cannot stretch fabrication part to a different service.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationPart.IsProductListEntryCompatibleSize(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.IsProductListEntryCompatibleSize(System.Int32)`

#### Summary

Checks to see if this part can be changed to the specified product entry without altering any connected dimensions.

#### Parameter `productEntry`

The product entry index.

#### Returns

Returns true if the part can be changed to the specified product entry without altering any connected dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The product entry index is not larger than 0 and less than GetProductCount.

#### Since

2016 Subscription Release

### `M:Autodesk.Revit.DB.FabricationPart.GetRodInfo`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetRodInfo`

#### Summary

Gets the fabrication rod information.

#### Returns

The fabrication rod information. Returns null if the fabrication part does not have any rod.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.GetHostedInfo`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetHostedInfo`

#### Summary

Gets the fabrication hosted element information.

#### Returns

The fabrication hosted element information. Returns null if the fabrication part does not have a host.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.CreateHanger(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.CreateHanger(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a free placed hanger.

#### Parameter `document`

The document.

#### Parameter `button`

The fabrication service button to use.

#### Parameter `condition`

The condition index. If the button has multiple conditions.

#### Parameter `levelId`

The level identifier associated with the level.

#### Returns

The newly-created fabrication hanger.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid fabrication service button.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index condition is not larger or equal to 0 and less than ConditionCount.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationPart.CreateHanger(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.CreateHanger(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,System.Double,System.Boolean)`

#### Summary

Creates a hanger on the fabrication part.

#### Parameter `document`

The document.

#### Parameter `button`

The fabrication service button to use.

#### Parameter `condition`

The condition index. If the button has multiple conditions.

#### Parameter `hostId`

The host part id. The host should be one horizontal straight part.

#### Parameter `hostConnector`

The connector of the host.

#### Parameter `distance`

The distance from the input connector of the host part. Units are in feet (ft).

#### Parameter `attachToStructure`

Attach to the nearest structural element. The structural element might be one of Floor/Roof/Stair/Structural Framing.

#### Returns

The newly-created fabrication hanger.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Hangers may only be placed on straight horizontal fabrication segments and some kind of fittings.
-or-
Invalid fabrication service button.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index condition is not larger or equal to 0 and less than ConditionCount.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

the distance is out of range.
-or-
cannot find suitable fabrication part for the host.
-or-
cannot place hanger on the host.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.CreateHanger(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.CreateHanger(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,System.Double,System.Boolean)`

#### Summary

Creates a hanger on the fabrication part.

#### Parameter `document`

The document.

#### Parameter `button`

The fabrication service button to use. It finds the matching condition automatically if the button has multiple condition.

#### Parameter `hostId`

The host part id. The host should be one horizontal straight part.

#### Parameter `hostConnector`

The connector of the host.

#### Parameter `distance`

The distance from the input connector of the host part. Units are in feet (ft).

#### Parameter `attachToStructure`

Attach to the nearest structural element. The structural element might be one of Floor/Roof/Stair/Structure Framing.

#### Returns

The newly-created fabrication hanger.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Hangers may only be placed on straight horizontal fabrication segments and some kind of fittings.
-or-
Invalid fabrication service button.
-or-
The distance is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

cannot place hanger on the host.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationItemFile,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationItemFile,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a fabrication part element from a fabrication item file.

#### Parameter `document`

The document.

#### Parameter `itemFile`

The fabrication item file.

#### Parameter `levelId`

The element identifier associated with the `T:Autodesk.Revit.DB.Level`
the `T:Autodesk.Revit.DB.FabricationPart` will be created on.

#### Returns

The new fabrication part.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The item file is not valid for use in Revit.
-or-
The item file has not been loaded into the configuration.
-or-
The ElementId levelId is not a Level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationPart.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a fabrication part element based on button.

#### Parameter `document`

The document.

#### Parameter `button`

The fabrication service button to use.

#### Parameter `condition`

The condition index.

#### Parameter `levelId`

The element identifier associated with the `T:Autodesk.Revit.DB.Level`
the `T:Autodesk.Revit.DB.FabricationPart` will be created on.

#### Returns

The new fabrication part.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Fabrication service button contains invalid fittings.
-or-
Please use FabricationPart.CreateHanger to create fabrication hanger.
-or-
The ElementId levelId is not a Level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index condition is not larger or equal to 0 and less than ConditionCount.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The fabrication part type does not exist. Reload the service using FabricationConfiguration.LoadServices.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Double,System.Double,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FabricationServiceButton,System.Double,System.Double,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a fabrication part element based on button and size.

#### Parameter `document`

The document.

#### Parameter `button`

The fabrication service button to use. Matches button condition based on the specified size.

#### Parameter `width`

The width of the part. Units are in feet (ft).

#### Parameter `depth`

The depth of the part. Units are in feet (ft). It should be equal to width for round part.

#### Parameter `levelId`

The element identifier associated with the `T:Autodesk.Revit.DB.Level`
the `T:Autodesk.Revit.DB.FabricationPart` will be created on.

#### Returns

The new fabrication part.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Fabrication service button contains invalid fittings.
-or-
Please use FabricationPart.CreateHanger to create fabrication hanger.
-or-
The ElementId levelId is not a Level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The fabrication part type does not exist. Reload the service using FabricationConfiguration.LoadServices.
-or-
failing to match a button condition based on specific size.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationPart.GetVersionHistory`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationPart.GetVersionHistory`

#### Summary

Gets a history of version change information about the current part.

#### Returns

A list of version information about the current part. The list starts with the most recent changes.

#### Since

2019

### `P:Autodesk.Revit.DB.FabricationPart.ServiceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ServiceType`

#### Summary

The service type identifier of the fabrication part.

#### Since

2018

### `P:Autodesk.Revit.DB.FabricationPart.GeometryChecksum`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.GeometryChecksum`

#### Summary

Gets the geometry checksum of the fabrication part symbol, and it does nothing with the fabrication part instance position.

#### Since

2018.2

### `P:Autodesk.Revit.DB.FabricationPart.NeedToUpdateIsoDrawing`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.NeedToUpdateIsoDrawing`

#### Summary

Changes happened and the iso drawing should be updated.

#### Since

2019

### `P:Autodesk.Revit.DB.FabricationPart.SpoolName`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.SpoolName`

#### Summary

The spool name of the fabrication part.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property:

#### Since

2018

### `P:Autodesk.Revit.DB.FabricationPart.PartGuid`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.PartGuid`

#### Summary

The fabrication part's globally unique identifier.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.FabricationPart.PartStatus`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.PartStatus`

#### Summary

The status identifier for the fabrication part.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.FabricationPart.HangerRodKit`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.HangerRodKit`

#### Summary

Specifies whether an ancillary kit is being used to override support rods, bolts and clips, if any. A value of 0 indicates no override is being used.

#### Remarks

For hangers only. Setting an invalid hanger rod kit will result in the property being unchanged.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.FabricationPart.ValidationStatus`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ValidationStatus`

#### Summary

The validation status of the fabrication part.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationPart.ConnectorManager`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ConnectorManager`

#### Summary

The connector manager of the fabrication part.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationPart.DomainType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.DomainType`

#### Summary

The domain type for the fabrication part.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationPart.ItemCustomId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ItemCustomId`

#### Summary

The item custom identifier for the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.ItemNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ItemNumber`

#### Summary

The item number that is used for identification, re-ordering from shop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property:

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.MaterialGauge`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.MaterialGauge`

#### Summary

The fabrication material gauge identifier.

#### Since

2024

### `P:Autodesk.Revit.DB.FabricationPart.Material`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.Material`

#### Summary

The fabrication material identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: the material is not valid for the fabrication part's specification.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: the material is not able to be modified.
-or-
When setting this property: the fabrication part is connected to more than one item.
-or-
When setting this property: the material fails to be set by identifier: materialId.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationPart.InsulationSpecification`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.InsulationSpecification`

#### Summary

The fabrication part insulation specification identifier.

#### Remarks

A value of 0 indicates the insulation specification is set to off.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: the insulation specification is invalid for the fabrication part.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

-or-
When setting this property: the fabrication part has taps connected.
-or-
When setting this property: the specification fails to be set by identifier: specId.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationPart.Specification`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.Specification`

#### Summary

The fabrication part specification identifier.

#### Remarks

A value of 0 indicates the specification is set to undefined.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: the specification is invalid for the fabrication part.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: the specification is not able to be modified.
-or-
When setting this property: the fabrication part is connected to more than one item.
-or-
When setting this property: the specification fails to be set by identifier: specId.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationPart.ServiceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ServiceId`

#### Summary

The fabrication part service identifier. The service can only be changed to compatible services.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property:

#### Since

2016 Subscription Release

### `P:Autodesk.Revit.DB.FabricationPart.ProductCode`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ProductCode`

#### Summary

The current database id of the part within the fabrication database.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationPart.CenterlineLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.CenterlineLength`

#### Summary

The centerline length of the fabrication part.

#### Since

2018.1

### `P:Autodesk.Revit.DB.FabricationPart.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.Origin`

#### Summary

The origin of the fabrication part element.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationPart.LevelOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.LevelOffset`

#### Summary

The associated level offset that indicates the distance from the center of the fabrication part to the current level.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationPart.ProductInstallType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ProductInstallType`

#### Summary

The product install type of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.ProductOriginalEquipmentManufacture`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ProductOriginalEquipmentManufacture`

#### Summary

The product original equipment manufacture (OEM) of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.ProductDataRange`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ProductDataRange`

#### Summary

The product data range of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.ProductSizeDescription`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ProductSizeDescription`

#### Summary

The product size description of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.ProductMaterialDescription`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ProductMaterialDescription`

#### Summary

The product material description of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.ProductSpecificationDescription`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ProductSpecificationDescription`

#### Summary

The product specification description of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.ProductFinishDescription`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ProductFinishDescription`

#### Summary

The product finish description of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.ProductLongDescription`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ProductLongDescription`

#### Summary

The product long description of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.ProductShortDescription`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ProductShortDescription`

#### Summary

The product short description of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.ProductName`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ProductName`

#### Summary

The product name of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.VendorCode`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.VendorCode`

#### Summary

The vendor code of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.Vendor`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.Vendor`

#### Summary

The vendor of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.Alias`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.Alias`

#### Summary

The alias of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.Notes`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.Notes`

#### Summary

The notes of the fabrication part.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property:

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.IsBoughtOut`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.IsBoughtOut`

#### Summary

True if the fabrication part is bought out.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.ServiceName`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ServiceName`

#### Summary

The name of the service associated with the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.CutType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.CutType`

#### Summary

The cut type of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.DoubleWallMaterialArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.DoubleWallMaterialArea`

#### Summary

The double wall material area of the fabrication part. If the fabrication part is not double walled, returns zero.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.DoubleWallMaterialThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.DoubleWallMaterialThickness`

#### Summary

The double wall material thickness of the fabrication part. If the fabrication part is not double walled, returns zero.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.DoubleWallMaterial`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.DoubleWallMaterial`

#### Summary

The double wall material identifier of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.MaterialThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.MaterialThickness`

#### Summary

The material thickness of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.SheetMetalArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.SheetMetalArea`

#### Summary

The sheet metal area of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.LiningArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.LiningArea`

#### Summary

The lining area of the fabrication part. If the fabrication part is not lined, returns zero.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.LiningThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.LiningThickness`

#### Summary

The lining thickness of the fabrication part. If the fabrication part is not lined, returns zero.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.LiningType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.LiningType`

#### Summary

The lining type of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.InsulationArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.InsulationArea`

#### Summary

The insulation area of the fabrication part. If the fabrication part is not insulated, returns zero.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.InsulationThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.InsulationThickness`

#### Summary

The insulation thickness of the fabrication part. If the fabrication part is not insulated, returns zero.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.InsulationType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.InsulationType`

#### Summary

The insulation type of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.Weight`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.Weight`

#### Summary

The weight of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.FreeSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.FreeSize`

#### Summary

The inner size of the fabrication part.

#### Since

2019

### `P:Autodesk.Revit.DB.FabricationPart.OverallSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.OverallSize`

#### Summary

The overall size of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.Size`

#### Summary

The size of the fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.Slope`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.Slope`

#### Summary

The slope for the straight fabrication part.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.HasLining`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.HasLining`

#### Summary

True if the fabrication part is lined.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.HasInsulation`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.HasInsulation`

#### Summary

True if the fabrication part is insulated.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.HasDoubleWall`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.HasDoubleWall`

#### Summary

True if the fabrication part is double walled.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.ServiceAbbreviation`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ServiceAbbreviation`

#### Summary

The associated service abbreviation for the fabrication service.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.BottomOfPartElevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.BottomOfPartElevation`

#### Summary

The associated elevation to the bottom of fabrication part off of the current level.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.TopOfPartElevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.TopOfPartElevation`

#### Summary

The associated elevation to the top of fabrication part off of the current level.

#### Since

2017

### `P:Autodesk.Revit.DB.FabricationPart.ProductListEntry`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationPart.ProductListEntry`

#### Summary

The product entry index of the fabrication part. A value of -1 indicates the fabrication part is not a product list.

#### Remarks

The product list is a catalog of available sizes for the part and the index refers to the entry on this list.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: modifying the product entry will cause the dimensions of connected ends to change.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The product entry index is not larger than 0 and less than GetProductCount.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property:
-or-
When setting this property: the product entry fails to be set by index: productEntryIndex.

#### Since

2016 Subscription Release

### `T:Autodesk.Revit.DB.FabricationPart`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationPart`

#### Summary

Represents a fabrication component in the Autodesk Revit MEP product.

#### Since

2016

### `T:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType`

#### Summary

Fabrication Part Comparison Types

#### Since

2018

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.ButtonAlias`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.ButtonAlias`

#### Summary

Compare Fabrication Button Alias field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.CustomData`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.CustomData`

#### Summary

Compare all Fabrication Custom Data fields.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.PCFKey`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.PCFKey`

#### Summary

Compare Fabrication PCFKey field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Alias`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Alias`

#### Summary

Compare Fabrication Alias field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Spool`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Spool`

#### Summary

Compare Fabrication Spool name field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Alt`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Alt`

#### Summary

Compare Fabrication Alt field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.ETag`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.ETag`

#### Summary

Compare Fabrication ETag field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Zone`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Zone`

#### Summary

Compare Fabrication Zone field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Drawing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Drawing`

#### Summary

Compare Fabrication Drawing name field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.OrderNo`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.OrderNo`

#### Summary

Compare Fabrication Order Number field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.BoxNo`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.BoxNo`

#### Summary

Compare Fabrication Box Number field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Pallet`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Pallet`

#### Summary

Compare Fabrication Pallet field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Service`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Service`

#### Summary

Compare Fabrication Service.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Status`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Status`

#### Summary

Compare Fabrication Status.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Section`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Section`

#### Summary

Compare Fabrication Section field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.SkinGauge`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.SkinGauge`

#### Summary

Compare Fabrication Double Skin Material Gauge.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.SkinMaterial`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.SkinMaterial`

#### Summary

Compare Fabrication Double Skin Material.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.CID`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.CID`

#### Summary

Compare Fabrication Custom Identifier (CID) number.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Description`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Description`

#### Summary

Compare Fabrication Description Field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Filename`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Filename`

#### Summary

Compare Fabrication Item Filename.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Notes`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Notes`

#### Summary

Compare Fabrication Notes field.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Insulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Insulation`

#### Summary

Compare Fabrication Insulation Material.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.DuctFacing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.DuctFacing`

#### Summary

Compare Fabrication Duct Facing Type.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.MaterialGauge`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.MaterialGauge`

#### Summary

Compare Fabrication Material's Gauge.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.InsulationSpecification`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.InsulationSpecification`

#### Summary

Compare Fabrication Insulation Specification.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Specification`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Specification`

#### Summary

Compare Fabrication Specification.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Material`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.Material`

#### Summary

Compare Fabrication Material.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.CutType`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartCompareType.CutType`

#### Summary

Compare Fabrication Cut Type data.

### `P:Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions.AddHolesForTaps`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions.AddHolesForTaps`

#### Summary

Set true to have holes for taps on straights added to the created fabrication job.

#### Since

2019

### `M:Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions.#ctor(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions.#ctor(System.Boolean)`

#### Summary

Constructor

#### Parameter `addHolesForTaps`

Set true to have holes for taps on straights added to the created fabrication job.

#### Since

2019

### `M:Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions.#ctor`

#### Summary

Default Constructor

#### Since

2019

### `T:Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions`

#### Summary

Options for FabricationPart.SaveAsFabricationJob() method.

#### Since

2019

### `T:Autodesk.Revit.DB.Fabrication.ValidationStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.ValidationStatus`

#### Summary

Lists the validation type of the fabrication part.

#### Since

2016

### `F:Autodesk.Revit.DB.Fabrication.ValidationStatus.NoMaterial`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.ValidationStatus.NoMaterial`

#### Summary

The part has no material being specified.

### `F:Autodesk.Revit.DB.Fabrication.ValidationStatus.InvalidDimensions`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.ValidationStatus.InvalidDimensions`

#### Summary

The part has invalid dimensions.

### `F:Autodesk.Revit.DB.Fabrication.ValidationStatus.Valid`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.ValidationStatus.Valid`

#### Summary

The part is valid to fabrication.

### `T:Autodesk.Revit.DB.Fabrication.FabricationPartFitResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartFitResult`

#### Summary

Fabrication part stretch/fill result.

#### Since

2017

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.Unsupported`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.Unsupported`

#### Summary

Failed due to unsupported routing path.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.OffsetRequired`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.OffsetRequired`

#### Summary

Failed due to additional offset dimensions or fittings being required that weren't available.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.IncompatibleConnection`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.IncompatibleConnection`

#### Summary

Failed due to connectors being incompatible and no couplings found to resolve it.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.SizeMismatch`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.SizeMismatch`

#### Summary

Failed due to size mismatch of fitting ends.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.ShapeMismatch`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.ShapeMismatch`

#### Summary

Failed due to shape mismatch of fitting ends.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.BadDimensions`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.BadDimensions`

#### Summary

Failed due to the required dimension values not being valid to fabricate.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.DimensionLocked`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.DimensionLocked`

#### Summary

Failed due to not being able to change a locked or product listed dimension.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.MisalignedEnds`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.MisalignedEnds`

#### Summary

Failed due to misalignment of fitting ends.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.IncompatibleGeometry`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.IncompatibleGeometry`

#### Summary

Failed because the part didn't have the dimensions required to meet the geometry requirements.

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.Success`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartFitResult.Success`

#### Summary

Operation was successful.

### `M:Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd.CreateFromCenterline(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd.CreateFromCenterline(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ)`

#### Summary

Create fabrication routing end from centerline point on straight element.

#### Parameter `element`

The straight element that the centerline is on.

#### Parameter `ptAt`

A point along the straight element where the fitting to be cut in should be positioned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd.CreateFromConnector(Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd.CreateFromConnector(Autodesk.Revit.DB.Connector)`

#### Summary

Create fabrication routing end from connector end point.

#### Parameter `connnector`

The connector that the route will connect to. The connector cannot have an existing connection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Connector is connected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd`

#### Summary

Class to hold fabrication part routing start or end information.

#### Remarks

To create a new instance, use `M:Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd.CreateFromConnector(Autodesk.Revit.DB.Connector)` to specify a connector,
or `M:Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd.CreateFromCenterline(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ)` to specify the centerline of a straight element,
for the fabrication routing end point.

#### Since

2017

### `T:Autodesk.Revit.DB.Fabrication.FabricationPartPlacementUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartPlacementUtils`

#### Summary

General utility placement methods in the Autodesk Revit MEP product for fabrication.

#### Since

2018

### `T:Autodesk.Revit.DB.Fabrication.FabricationPartJustification`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartJustification`

#### Summary

Fabrication part eccentric justifications for alignment for flat edged parts.

#### Since

2018

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartJustification.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartJustification.Top`

#### Summary

Outside edge justification to the top

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartJustification.Bottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartJustification.Bottom`

#### Summary

Outside edge justification to the bottom

### `F:Autodesk.Revit.DB.Fabrication.FabricationPartJustification.Middle`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationPartJustification.Middle`

#### Summary

Default middle justification to the connector

### `M:Autodesk.Revit.DB.FabricationItemFolder.UpdateItemFiles`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationItemFolder.UpdateItemFiles`

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationItemFolder.UpdateSubFolders`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationItemFolder.UpdateSubFolders`

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationItemFolder.GetItemFiles`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationItemFolder.GetItemFiles`

#### Summary

Gets the item files in this item folder.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationItemFolder.GetSubFolders`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationItemFolder.GetSubFolders`

#### Summary

Gets the item folder's sub folders.

#### Since

2019

### `P:Autodesk.Revit.DB.FabricationItemFolder.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationItemFolder.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FabricationItemFolder.GUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationItemFolder.GUID`

#### Summary

The item folder's globally unique identifier.

#### Since

2019

### `P:Autodesk.Revit.DB.FabricationItemFolder.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationItemFolder.Name`

#### Summary

The item folder's name.

#### Since

2019

### `T:Autodesk.Revit.DB.FabricationItemFolder`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationItemFolder`

#### Summary

A fabrication item folder that can contain sub folders and access to the `T:Autodesk.Revit.DB.FabricationItemFile` s contained within.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationItemFile.IsUsedInternal`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationItemFile.IsUsedInternal`

#### Summary

Checks to see if the item file is already in use in the project.
Note that this method may not provide the current status correctly. For normal case,
use the isUsed propery instead.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationItemFile.IsLoaded`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationItemFile.IsLoaded`

#### Summary

Checks to see if the item file has been loaded into the configuration.

#### Returns

Returns true if the item file has been loaded into the configuration, false otherwise.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationItemFile.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationItemFile.IsValid`

#### Summary

Checks to see if the item file is valid.

#### Returns

Returns true if the item file is valid, false otherwise.

#### Since

2019

### `P:Autodesk.Revit.DB.FabricationItemFile.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationItemFile.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FabricationItemFile.IsUsed`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationItemFile.IsUsed`

#### Summary

Checks to see if the item file is already in use in the project.

#### Since

2019

### `P:Autodesk.Revit.DB.FabricationItemFile.Identifier`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationItemFile.Identifier`

#### Summary

The string identifier for the item file. This string is unique and can be used to compare whether fabrication
item files are the same file.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationItemFile.GetImage`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationItemFile.GetImage`

#### Summary

Gets the image for the fabrication item file.

#### Returns

System.Drawing.Bitmap represents the fabrication item file image. `null` if there is no preview image.

#### Since

2019

### `T:Autodesk.Revit.DB.FabricationItemFile`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationItemFile`

#### Summary

This class holds information about the item file, including whether it is already loaded from disk into Revit.

#### Remarks

This object is created as a result of loading from disk.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetItemFoldersUsedByServices(System.Collections.Generic.IList{System.Int32})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetItemFoldersUsedByServices(System.Collections.Generic.IList{System.Int32})`

#### Summary

Gets a list of every fabrication item folder used by services.

#### Parameter `serviceIds`

list of service identifiers to check.

#### Returns

Returns a list of every fabrication item folder used by services.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The current fabrication configuration is not connected and updated to source configuration. Reload and try again.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.IsDirty`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.IsDirty`

#### Returns

True if the fabrication browser is dirty.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.MarkDirty(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.MarkDirty(System.Boolean)`

#### Summary

Set the flag indicating if the fabrication browser is dirty.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetConnectedUpdateIndex`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetConnectedUpdateIndex`

#### Summary

Returns the baseline index of the last applied update. The configuration must be a connected remote configuration for this call to succeed.

#### Returns

Returns the index of the current updates.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The fabrication configuration is not remote or is not connected.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfiguration.IsConnected`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.IsConnected`

#### Summary

Get whether this config is a remote configuration that is connected.

#### Returns

Returns true if the configuration is remote and connected.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetMaterialThickness(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetMaterialThickness(System.Int32,System.Int32)`

#### Summary

Gets material thickness from its material/gauge identifiers.

#### Parameter `materialId`

The material identifier.

#### Parameter `gaugeId`

The gauge identifier within the specified material.

#### Returns

The thickness of the material/gauge.

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationConfiguration.UnloadServicesAndItemFiles(System.Collections.Generic.IList{System.Int32},System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.UnloadServicesAndItemFiles(System.Collections.Generic.IList{System.Int32},System.Collections.Generic.IList{System.String})`

#### Summary

Unload the specific fabrication service from project.

#### Parameter `serviceIds`

The identifiers of the fabrication services to unload.

#### Parameter `itemFiles`

The relative filenames of the fabrication item files to unload.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Fabrication item files can not be unloaded if they are in use currently.
-or-
Some item files have not been loaded.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The current fabrication configuration is not connected and updated to source configuration. Reload and try again.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.UnloadItemFilesInternal(System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.UnloadItemFilesInternal(System.Collections.Generic.IList{System.String})`

#### Summary

Unload the specified fabrication item files from the project.

#### Parameter `itemFiles`

The fabrication item files to unload.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Fabrication item files can not be unloaded if they are in use currently.
-or-
Some item files have not been loaded.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The current fabrication configuration is not connected and updated to source configuration. Reload and try again.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfiguration.AreItemFilesLoadedInternal(System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.AreItemFilesLoadedInternal(System.Collections.Generic.IList{System.String})`

#### Summary

Checks if the item files have been loaded.

#### Parameter `itemFilePaths`

The paths of the item files.

#### Returns

Returns true if the item files have been loaded, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfiguration.CanUnloadItemFilesInternal(System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.CanUnloadItemFilesInternal(System.Collections.Generic.IList{System.String})`

#### Summary

Checks if the fabrication item files are already in use and should not be unloaded.

#### Parameter `itemFiles`

The fabrication item files to unload.

#### Returns

Returns true if the fabrication item files can be unloaded, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfiguration.LoadItemFilesInternal(System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.LoadItemFilesInternal(System.Collections.Generic.IList{System.String})`

#### Summary

Loads the specified fabrication item files into the project.

#### Parameter `itemFiles`

The relative paths of the fabrication item files to load.

#### Returns

The relative paths of the fabrication item files which failed to load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The current fabrication configuration is not connected and updated to source configuration. Reload and try again.
-or-
this operation failed.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAllUsedItemFilesInternal`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAllUsedItemFilesInternal`

#### Summary

Returns all the used fabrication item files. A fabrication item file is used if any fabrication parts in the model were created from it.

#### Returns

All the relative filenames of the used fabrication item files.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfiguration.FinaliseConfigurationChanges(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.FinaliseConfigurationChanges(System.Boolean)`

#### Summary

Finalise a temporary configuration and make it permanent

#### Parameter `keepChanges`

if true the changes are persisted to the buffer else the configuration is rebuilt from the current buffer.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.BeginConfigurationChanges`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.BeginConfigurationChanges`

#### Summary

Begin temporary configuration changes (optimise recording)

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.SetTemporaryConfiguration(Autodesk.Revit.DB.FabricationConfigurationInfo,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.SetTemporaryConfiguration(Autodesk.Revit.DB.FabricationConfigurationInfo,System.String)`

#### Summary

Set a temporary configuration that can be adjusted before being finalised

#### Parameter `fabricationConfigurationInfo`

The desired fabrication configuration.

#### Parameter `profile`

The desired profile of the fabrication configuration. Use empty string for the global profile.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The fabrication configuration cannot be swapped because the exiting fabrication configuration has already been used in the document.
-or-
Cannot set the configuration.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAllLoadedItemFiles`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAllLoadedItemFiles`

#### Summary

Get list of all loaded fabrication item files.

#### Returns

Returns an array of the loaded fabrication item files.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The fabrication configuration is not set yet.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetItemFolders`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetItemFolders`

#### Summary

Gets a list of every fabrication item folder in the fabrication item folder structure.

#### Returns

Returns a list of every fabrication item folder in the fabrication item folder structure.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The current fabrication configuration is not connected and updated to source configuration. Reload and try again.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetServiceTypeName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetServiceTypeName(System.Int32)`

#### Summary

Gets the service type name.

#### Parameter `serviceTypeId`

The service type identifier.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationConfiguration.IsAncillaryKit(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.IsAncillaryKit(System.Int32)`

#### Summary

Gets whether the specified fabrication ancillary identifier is an ancillary kit or not.

#### Parameter `ancillaryId`

The fabrication ancillary database identifier of the ancillary.

#### Returns

Returns true if the ancillary is a kit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ancillary does not exist.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAncillaryGroupName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAncillaryGroupName(System.Int32)`

#### Summary

Gets the fabrication ancillary group and name for the specified fabrication ancillary identifier.

#### Parameter `ancillaryId`

The fabrication ancillary database identifier of the ancillary.

#### Returns

The group and name of the ancillary.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ancillary does not exist.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAncillaryGroup(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAncillaryGroup(System.Int32)`

#### Summary

Gets the fabrication ancillary group of the specified fabrication ancillary identifier.

#### Parameter `ancillaryId`

The fabrication ancillary database identifier of the ancillary.

#### Returns

The group name of the ancillary.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ancillary does not exist.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAncillaryName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAncillaryName(System.Int32)`

#### Summary

Gets the fabrication ancillary name for the specified fabrication ancillary identifier.

#### Parameter `ancillaryId`

The fabrication ancillary database identifier of the ancillary.

#### Returns

The name of the ancillary.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ancillary does not exist.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAncillaries(Autodesk.Revit.DB.Fabrication.FabricationAncillaryType,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAncillaries(Autodesk.Revit.DB.Fabrication.FabricationAncillaryType,System.Boolean,System.Boolean)`

#### Summary

Gets fabrication ancillaries of the specified type.

#### Parameter `type`

The type of ancillaries to get.

#### Parameter `includeKits`

Whether or not to include ancillary kits as well.

#### Parameter `filterKits`

Whether kits should be filtered to only those that contain the specified ancillary type.

#### Returns

An array of ancillary identifiers.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationConfiguration.AncillaryExists(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.AncillaryExists(System.Int32)`

#### Summary

Checks to see if the specified ancillary exists.

#### Parameter `ancillaryId`

The ancillary identifier.

#### Returns

Returns true if the ancillary exists.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetMaterialGaugeGUID(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetMaterialGaugeGUID(System.Int32,System.Int32)`

#### Summary

Gets the material gauge GUID by its material/gauge identifiers.

#### Parameter `materialId`

The material identifier. The same material gauge GUID could have different material gauge identifiers for different materials.

#### Parameter `gaugeId`

The material gauge identifier.

#### Returns

The material gauge GUID. Returns empty GUID if not found.

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetMaterialGaugeByGUID(System.Guid,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetMaterialGaugeByGUID(System.Guid,System.Int32)`

#### Summary

Gets the material gauge identifier by its GUID and material identifier.

#### Parameter `gaugeGUID`

The material gauge GUID.

#### Parameter `materialId`

The material identifier. The same material gauge GUID could have different material gauge identifiers for different materials.

#### Returns

The gauge identifier. Returns 0 if not found.

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetMaterialGUID(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetMaterialGUID(System.Int32)`

#### Summary

Gets the material GUID by its identifier.

#### Parameter `materialId`

The material identifier.

#### Returns

The material GUID. Returns empty GUID if not found.

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetMaterialByGUID(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetMaterialByGUID(System.Guid)`

#### Summary

Gets the material identifier by its GUID.

#### Parameter `materialGUID`

The material GUID.

#### Returns

The material identifier. Returns 0 if not found.

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetSpecificationGUID(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetSpecificationGUID(System.Int32)`

#### Summary

Gets the specification GUID by its identifier.

#### Parameter `specificationId`

The specification identifier.

#### Returns

The specification GUID. Returns empty GUID if not found.

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetSpecificationByGUID(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetSpecificationByGUID(System.Guid)`

#### Summary

Gets the specification identifier by its GUID.

#### Parameter `specificationGUID`

The specification GUID.

#### Returns

The specification identifier. Returns 0 if not found.

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetServiceGUID(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetServiceGUID(System.Int32)`

#### Summary

Gets the service GUID by its identifier.

#### Parameter `serviceId`

The service identifier.

#### Returns

The service GUID. Returns empty GUID if not found.

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetServiceByGUID(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetServiceByGUID(System.Guid)`

#### Summary

Gets the service identifier by its GUID.

#### Parameter `serviceGUID`

The service GUID.

#### Returns

The service identifier. Returns 0 if not found.

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetFabricationConnectorDomain(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetFabricationConnectorDomain(System.Int32)`

#### Summary

Gets the fabrication connector domain from its identifier.

#### Parameter `fabricationConnectorId`

The fabrication connector identifier.

#### Returns

The fabrication connector's domain.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetFabricationConnectorShape(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetFabricationConnectorShape(System.Int32)`

#### Summary

Gets the fabrication connector shape from its identifier.

#### Parameter `fabricationConnectorId`

The fabrication connector identifier.

#### Returns

The fabrication connector's shape.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetFabricationConnectorGroup(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetFabricationConnectorGroup(System.Int32)`

#### Summary

Gets the fabrication connector group from its identifier.

#### Parameter `fabricationConnectorId`

The fabrication connector identifier.

#### Returns

The fabrication connector's group.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetFabricationConnectorName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetFabricationConnectorName(System.Int32)`

#### Summary

Gets the fabrication connector name from its identifier.

#### Parameter `fabricationConnectorId`

The fabrication connector identifier.

#### Returns

The fabrication connector's name.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.LocateFabricationConnector(System.String,System.String,Autodesk.Revit.DB.ConnectorDomainType,Autodesk.Revit.DB.ConnectorProfileType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.LocateFabricationConnector(System.String,System.String,Autodesk.Revit.DB.ConnectorDomainType,Autodesk.Revit.DB.ConnectorProfileType)`

#### Summary

Gets the fabrication connector identifiers by group and name, filtered by shape and domain.

#### Parameter `group`

The fabrication connector group.

#### Parameter `name`

The fabrication connector name.

#### Parameter `domain`

ConnectorDomainType to filter by. Pass ConnectorDomainType::Undefined to get all connector domains.

#### Parameter `shape`

ConnectorProfileType to filter by. Pass ConnectorProfileType::Invalid to get all shapes.

#### Returns

Return the fabrication connector identifier. Returns -1 if not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAllFabricationConnectorDefinitions(Autodesk.Revit.DB.ConnectorDomainType,Autodesk.Revit.DB.ConnectorProfileType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAllFabricationConnectorDefinitions(Autodesk.Revit.DB.ConnectorDomainType,Autodesk.Revit.DB.ConnectorProfileType)`

#### Summary

Gets fabrication connector identifiers from the fabrication configuration, filtered by shape and domain.

#### Parameter `domain`

ConnectorDomainType to filter by. Pass ConnectorDomainType.Undefined to get all connector domains.

#### Parameter `shape`

ConnectorProfileType to filter by. Pass ConnectorProfileType.Invalid to get all shapes.

#### Returns

All the fabrication connector identifiers, filtered by shape and domain. The return will be empty if no connectors are found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetInsulationSpecificationAbbreviation(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetInsulationSpecificationAbbreviation(System.Int32)`

#### Summary

Gets insulation specification abbreviation.

#### Parameter `insulationSpecificationId`

The insulation specification identifier.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetSpecificationAbbreviation(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetSpecificationAbbreviation(System.Int32)`

#### Summary

Gets specification abbreviation.

#### Parameter `specificationId`

The specification identifier.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetMaterialAbbreviation(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetMaterialAbbreviation(System.Int32)`

#### Summary

Gets the abreviation of the material or the insulation or the double wall material.

#### Parameter `materialId`

The material identifier.

#### Since

2017

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetMaterialName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetMaterialName(System.Int32)`

#### Summary

Gets material name from its identifier.

#### Parameter `materialId`

The material identifier.

#### Returns

The material name without the group.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetMaterialGroup(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetMaterialGroup(System.Int32)`

#### Summary

Gets material group from its identifier.

#### Parameter `materialId`

The material identifier.

#### Returns

The material group.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.LocateMaterial(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.LocateMaterial(System.String,System.String)`

#### Summary

Gets material by group and name.

#### Parameter `group`

The material group.

#### Parameter `name`

The group name.

#### Returns

The material identifier. Returns -1 if not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAllMaterials(Autodesk.Revit.DB.FabricationPart)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAllMaterials(Autodesk.Revit.DB.FabricationPart)`

#### Summary

Gets all material identifiers in the fabrication configuration.

#### Remarks

If a part is passed, only returns materials which are valid for the part, otherwise returns all materials.

#### Parameter `part`

The fabrication part.

#### Returns

An array of material identifiers.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetInsulationSpecificationGroup(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetInsulationSpecificationGroup(System.Int32)`

#### Summary

Gets the insulation specification group from its identifier.

#### Parameter `specId`

The insulation specification identifier.

#### Returns

The insulation specification group.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetInsulationSpecificationName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetInsulationSpecificationName(System.Int32)`

#### Summary

Gets the insulation specification name from its identifier.

#### Parameter `specId`

The insulation specification identifier.

#### Returns

The insulation specification name.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.LocateInsulationSpecification(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.LocateInsulationSpecification(System.String,System.String)`

#### Summary

Gets the insulation specification by group and name.

#### Parameter `group`

The insulation specification group.

#### Parameter `name`

The insulation specification name.

#### Returns

The insulation specification identifier. Returns -1 if not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAllInsulationSpecifications(Autodesk.Revit.DB.FabricationPart)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAllInsulationSpecifications(Autodesk.Revit.DB.FabricationPart)`

#### Summary

Gets all insulation specification identifiers in the fabrication configuration.

#### Remarks

If a part is passed, only returns insulation specification which are valid for the part, otherwise returns all insulation specifications.

#### Parameter `pFabPart`

The fabrication part.

#### Returns

An array of insulation specification identifiers.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetPartCustomDataType(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetPartCustomDataType(System.Int32)`

#### Summary

Gets the custom data type from its identifier. See FabricationCustomDataType enumerator.

#### Parameter `customDataId`

The custom data identifier.

#### Returns

The custom data type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The custom data does not exist.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetPartCustomDataName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetPartCustomDataName(System.Int32)`

#### Summary

Gets the custom data name from its identifier.

#### Parameter `customDataId`

The custom data identifier.

#### Returns

The custom data name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The custom data does not exist.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAllPartCustomData`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAllPartCustomData`

#### Summary

Gets all possible fabrication part custom data identifiers.

#### Returns

An array of custom data identifiers.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationConfiguration.CustomDataExists(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.CustomDataExists(System.Int32)`

#### Summary

Checks to see if the specified custom data exists.

#### Parameter `customDataId`

The custom data identifier.

#### Returns

Returns true if the custom data exists.

#### Since

2018

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetPartStatusDescription(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetPartStatusDescription(System.Int32)`

#### Summary

Gets the status description from its identifier.

#### Parameter `statusId`

The status identifier.

#### Returns

The status description.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAllPartStatuses`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAllPartStatuses`

#### Summary

Gets all possible fabrication part status identifiers.

#### Returns

An array of status identifiers.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationConfiguration.DamperExists(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.DamperExists(System.Int32)`

#### Summary

Checks to see if the specified damper exists.

#### Parameter `damperId`

The damper identifier to check.

#### Returns

Returns true if the damper exists.

#### Since

2018
