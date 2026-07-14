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
Shard: 11
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.DirectShapeType.GetExternallyTaggedReference(Autodesk.Revit.DB.ExternalGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.GetExternallyTaggedReference(Autodesk.Revit.DB.ExternalGeometryId)`

#### Summary

Retrieve a Reference to reference geometry of the DirectShapeType that is associated with a particular ExternalGeometryId.

#### Parameter `externalId`

The ExternalGeometryId of the requested reference object.

#### Returns

A Reference to the externally tagged reference GeometryObject having the provided external ID
or `null` if there is no reference geometry having the external ID.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.DirectShapeType.HasExternallyTaggedReference(Autodesk.Revit.DB.ExternalGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.HasExternallyTaggedReference(Autodesk.Revit.DB.ExternalGeometryId)`

#### Summary

Checks if the externally tagged reference is already present in this DirectShapeType.

#### Parameter `externalId`

The external ID of the tagged reference to check for.

#### Returns

True if the DirectShapeType holds a reference with the specified ExternalGeometryId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.DirectShapeType.CanCreateParts`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.CanCreateParts`

#### Summary

Indicates if it is possible to create parts from this DirectShapeType element.

#### Remarks

While it is generally possible to create parts from DirectShape elements, some characteristics make parts creation impossible.
This property is re-evaluated every time the DirectShapeType's geometry is modified (via a call to SetShape or AppendShape).
Invalid configurations include: DirectShapeTypes containing a polymesh, or an open geometry, as well as DirectShapeTypes
not containing any solids and DirectShapeTypes configured as NotReferenceable (via a call to SetOptions).
Finally, if a DirectShapeType has other DirectShapeType instances in its geometry, and one of those other DirectShapeTypes
has a configuration that is incompatible with parts creation, the host DirectShapeType will also be incompatible
with parts creation.

#### Returns

True if it is possible to create parts from this DirectShapeType.

#### Since

2020

### `M:Autodesk.Revit.DB.DirectShapeType.IsValidShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.DirectShapeTargetViewType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.IsValidShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.DirectShapeTargetViewType)`

#### Summary

Validates view-specific shape to be stored in a DirectShapeType. Expects a non-default view type.

#### Parameter `shape`

Shape of this object expressed as a collection of GeometryObjects.
For viewType = DirectShapeTargetViewType::Default, the supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point, Curve and PolyLine.
For viewType = DirectShapeTargetViewType::Plan, the supported types of GeometryObjects are: Point and Curve.

#### Parameter `viewType`

The view type this shape is intended for.

#### Returns

True if the supplied shape passes the validation criteria.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `M:Autodesk.Revit.DB.DirectShapeType.IsValidShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.IsValidShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

#### Summary

Validates shape to be stored in a DirectShapeType.

#### Remarks

This function calls IsValidShape(GeometryObject) to validate each object in the list.

#### Parameter `shape`

Shape to be validated represented as a collection of GeometryObjects.
The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point, Curve and PolyLine.

#### Returns

True if the supplied shape passes the validation criteria.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectShapeType.AppendShape(Autodesk.Revit.DB.ShapeBuilder)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.AppendShape(Autodesk.Revit.DB.ShapeBuilder)`

#### Summary

Append shape built by the supplied ShapeBuilderObject to shape representation stored in this DirectShapeType.
The data stored in the supplied ShapeBuilder object will be cleared.

#### Remarks

The existing shape will not be cleared by this function, and intersecting or overlapped geometry will not be
joined with the appended geometry. It is up to the caller to ensure that the combination of geometry
will have teh correct appearance in Revit.
This function will bypass extra geometry validation because the built geometry has already been validated by the ShapeBuilder.
It is therefore slightly more efficient than the AppendShape() routine that accepts GeometryObjects directly as input.

#### Parameter `ShapeBuilder`

The ShapeBuilder object that was used to build the shape to be appended.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.DirectShapeType.AppendShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.DirectShapeTargetViewType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.AppendShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.DirectShapeTargetViewType)`

#### Summary

Appends the collection of GeometryObjects into the model or view specific shape representation stored in this DirectShapeType.
Passing DirectShapeTargetViewType.Default as view type will cause the model shape to be updated.

#### Remarks

The existing shape will not be cleared by this function, and intersecting or overlapped geometry will not be
joined with the appended geometry. It is up to the caller to ensure that the combination of geometry
will have the correct appearance in Revit.

#### Parameter `pGeomArr`

Shape expressed as a collection of GeometryObjects.
For viewType = DirectShapeTargetViewType::Default, the supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point, Curve and PolyLine.
For viewType = DirectShapeTargetViewType::Plan, the supported types of GeometryObjects are: Point and Curve.

#### Parameter `viewType`

Passing DirectShapeTargetViewType.Default as view type will cause the default shape to be appended.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

At least one member of pGeomArr does not satisfy DirectShapeType validation criteria.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.DirectShapeType.AppendShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.AppendShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

#### Summary

Appends the collection of GeometryObjects into the model shape representation stored in this DirectShape.

#### Remarks

The existing shape will not be cleared by this function, and intersecting or overlapped geometry will not be
joined with the appended geometry. It is up to the caller to ensure that the combination of geometry
will have the correct appearance in Revit.

#### Parameter `pGeomArr`

Shape expressed as a collection of GeometryObjects.
The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point, Curve and PolyLine.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

At least one member of pGeomArr does not satisfy DirectShapeType validation criteria.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.DirectShapeType.SetShape(Autodesk.Revit.DB.ShapeBuilder)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.SetShape(Autodesk.Revit.DB.ShapeBuilder)`

#### Summary

Sets the shape of this object to the one accumulated in the supplied Builder object.
If the new shape is identical to the old one, the old shape will be kept.

#### Remarks

This function will bypass extra geometry validation because the built geometry has already been validated by the ShapeBuilder.
It is therefore slightly more efficient than the SetShape() routine that accepts GeometryObjects directly as input.
Supplying a ViewShapeBuilder object as argument will cause the view-specific shape of this DirectShapeType to be updated.
Supplying other ShapeBuilder types will update the model shape.

#### Parameter `pBuilder`

A ShapeBuilder object that was used to successfully build geometry to store in this DirectShapeType. The built shape will be
transferred to the DirectShapeType, and the ShapeBuilder object will be reset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.DirectShapeType.SetShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.SetShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

#### Summary

Builds the type shape from the supplied collection of GeometryObjects. The objects are copied.
If the new shape is identical to the old one, the old shape will be kept.

#### Parameter `pGeomArr`

Shape of this object expressed as a collection of GeometryObjects. These will be copied.
Shape and Category should be consistent: geometry supplied as shape should be valid for the Category
the type object is associated with.
The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point, Curve and PolyLine.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

At least one member of pGeomArr does not satisfy DirectShapeType validation criteria.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShapeType.CanChangeFamilyName`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.CanChangeFamilyName`

#### Summary

Checks whether the DirectShapeType supports a custom family name.

#### Returns

True if a custom family name is supported, false otherwise.

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShapeType.SetFamilyName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.SetFamilyName(System.String)`

#### Summary

Sets the family name for the DirectShapeType.

#### Remarks

By default the family name is either Direct Shape or a category-specific name. When a
category-specific name is used the family name cannot be set.

#### Parameter `name`

Family name for the DirectShapeType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element type name was empty, contained invalid characters, or was invalid for the specific element type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The given DirectShapeType has a category which does not support a custom family name.

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShapeType.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.DirectShapeTypeOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.DirectShapeTypeOptions)`

#### Summary

Creates a DirectShapeType element.

#### Parameter `document`

Document to which the created element will be added.

#### Parameter `name`

Name of the DirectShapeType.

#### Parameter `categoryId`

Id of the category assigned to this DirectShapeType. Must be a valid category id.

#### Parameter `options`

Options that can be used to control the behavior of DirectShapeType being created.

#### Returns

The new DirectShapeType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Document document may not contain DirectShape or DirectShapeType objects.
-or-
Element id categoryId may not be used as a DirectShape category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.DirectShapeType.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeType.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a DirectShapeType element.

#### Parameter `document`

Document to which the created element will be added. Must be a project document.

#### Parameter `name`

Name of the DirectShapeType.

#### Parameter `categoryId`

Id of the category assigned to this DirectShapeType. Must be a valid category id.

#### Returns

The new DirectShapeType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
Document document may not contain DirectShape or DirectShapeType objects.
-or-
Element id categoryId may not be used as a DirectShape category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.DirectShapeType.UserAssignability`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShapeType.UserAssignability`

#### Summary

An option controlling the ability of DirectShapes to assign this DirectShapeType as its type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2023

### `T:Autodesk.Revit.DB.DirectShapeType`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectShapeType`

#### Summary

The type element associated with a DirectShape element. This element includes data reused by DirectShape elements of the same type.

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShapeLibrary.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeLibrary.Reset`

#### Summary

Removes all definitions from library. This is useful when importing several self-contained data sets within one session.
Once a data set is imported, keeping the definitions specific to that data set will slow down the searches.

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShapeLibrary.ContainsType(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeLibrary.ContainsType(System.String)`

#### Summary

A quick check whether a definition type already exists in the library. Checks for type objects only.

#### Parameter `name`

Definition id

#### Returns

True if a geometry definition exists, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShapeLibrary.Contains(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeLibrary.Contains(System.String)`

#### Summary

A quick check whether a definition already exists in the library. Checks for stored geometry objects only.

#### Parameter `id`

Definition id

#### Returns

True if a geometry definition exists, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShapeLibrary.FindDefinitionType(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeLibrary.FindDefinitionType(System.String)`

#### Summary

Find a DirectShapeType element by definition id. The element will be used for creating instances of that definition.

#### Parameter `id`

Definition id. Expected to be unique.

#### Returns

Element id of a DirectShapeTypeElement

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShapeLibrary.FindDefinition(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeLibrary.FindDefinition(System.String)`

#### Summary

Find a definition by id

#### Parameter `id`

Definition id. Expecected to be unique

#### Returns

List of geometry objects that together define a shape

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShapeLibrary.AddDefinitionType(System.String,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeLibrary.AddDefinitionType(System.String,Autodesk.Revit.DB.ElementId)`

#### Summary

Add a definition to be reused by instances. Adding a definition type will change how the instances are created.
When asked to create a definition, the library object will look for a corresponding type object.
If one is found, it will create an instance of geometry stored in the type object. If it is not found,
the library will look for a list of geometry objects stored as definition, and will copy and transform these
to create an instance.

#### Parameter `id`

ID of the definition to be added. Must be unique.

#### Parameter `typeId`

Element id of the DirectShapeType element that will be used as a definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShapeLibrary.AddDefinition(System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeLibrary.AddDefinition(System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

#### Summary

Add a definition to be reused by instances. A definition is a collection of geometry objects.

#### Parameter `id`

ID of the definition to be added. Must be unique.

#### Parameter `GNodes`

Definition as a list of Geometry objects

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShapeLibrary.AddDefinition(System.String,Autodesk.Revit.DB.GeometryObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeLibrary.AddDefinition(System.String,Autodesk.Revit.DB.GeometryObject)`

#### Summary

Add a definition to be reused by instances. A definition is a single geometry object.

#### Parameter `id`

ID of the definition to be added. Must be unique.

#### Parameter `GNode`

Definition as a single Geometry object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShapeLibrary.GetDirectShapeLibrary(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeLibrary.GetDirectShapeLibrary(Autodesk.Revit.DB.Document)`

#### Summary

Get the currently active Library object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.DirectShapeLibrary.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShapeLibrary.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.DirectShapeLibrary`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectShapeLibrary`

#### Summary

DirectShapeLibrary is used to store pre-created geometry for further referencing via the definition/instance mechanism.
It is not persistent: the scope of a library object is usually a single data creation session.
DirectShape::createGeometryInstance and DirectShape::CreateElementInstance will use the current DirectShapeLibrary to
look up the definitions.
store a collection of GNodes as definition
end class DirectShapeDefinition

#### Remarks

There are two ways to add a definition to the library. The first is to add the definition as an array of geometry objects.
A DirectShape created as an instance of that definition will hold a copy of predefined geometry, transformed as requested.
If the definition was added as a DirectShapeType, a DirectShape object created as an instance of that definition will reference the type.
Its geometry would be an instance of type geometry.

#### Since

2015

### `T:Autodesk.Revit.DB.DirectShapeTypeUserAssignability`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectShapeTypeUserAssignability`

#### Since

2023

#### Summary

Options for a DirectShapeType which affect whether or not it can be assigned as the type of a DirectShape.

#### Remarks

Only DirectShapeTypes which permit assignability will be shown in the type selector dialog.
A DirectShape which uses a DirectShapeType which is not assignable can be copied.

#### Since

2023

### `F:Autodesk.Revit.DB.DirectShapeTypeUserAssignability.Nonassignable`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectShapeTypeUserAssignability.Nonassignable`

#### Summary

The DirectShapeType cannot be used to replace the type of an existing DirectShape.

### `F:Autodesk.Revit.DB.DirectShapeTypeUserAssignability.Assignable`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectShapeTypeUserAssignability.Assignable`

#### Summary

The DirectShapeType can be used to replace the type of an existing DirectShape.

### `M:Autodesk.Revit.DB.DirectShapeReferenceOptions.GetExternalGeometryId`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeReferenceOptions.GetExternalGeometryId`

#### Summary

Retrieves the ExternalGeometryId associated with the reference object.

#### Remarks

If an ExternalGeometryId has not been set, this method returns `null` .

#### Since

2024

### `M:Autodesk.Revit.DB.DirectShapeReferenceOptions.SetExternalGeometryId(Autodesk.Revit.DB.ExternalGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeReferenceOptions.SetExternalGeometryId(Autodesk.Revit.DB.ExternalGeometryId)`

#### Summary

Sets the ExternalGeometryId associated with the reference object.
The ID must be non-empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

externalId cannot be used as an ExternalGeometryId for a direct shape reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.DirectShapeReferenceOptions.IsValidExternalGeometryId(Autodesk.Revit.DB.ExternalGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeReferenceOptions.IsValidExternalGeometryId(Autodesk.Revit.DB.ExternalGeometryId)`

#### Summary

Validates that the input ExternalGeometryId can be assigned to a direct shape reference.

#### Parameter `externalId`

The ExternalGeometryId to assign to the reference.

#### Returns

True if the provided ExternalGeometryId is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.DirectShapeReferenceOptions.IsValidReferenceName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeReferenceOptions.IsValidReferenceName(System.String)`

#### Summary

Validates that the input name can be assigned to a direct shape reference.

#### Parameter `name`

The name to assign to the reference.

#### Returns

True if the input name is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.DirectShapeReferenceOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShapeReferenceOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.DirectShapeReferenceOptions.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShapeReferenceOptions.Name`

#### Summary

The name associated with the reference object.
The name does not need to be unique.
The name must not be empty and must contain valid characters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: value cannot be used as a name for the direct shape reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShapeReferenceOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeReferenceOptions.#ctor`

#### Summary

Constructs a new DirectShapeRefOptions instance with default settings.

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShapeReferenceOptions.#ctor(Autodesk.Revit.DB.DirectShapeReferenceOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShapeReferenceOptions.#ctor(Autodesk.Revit.DB.DirectShapeReferenceOptions)`

#### Summary

Constructs a new copy of the input DirectShapeRefOptions object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.DirectShapeReferenceOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectShapeReferenceOptions`

#### Summary

This class is used to control the behavior of DirectShape and DirectShapeType reference objects.

#### Since

2022

### `P:Autodesk.Revit.DB.DirectShapeOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShapeOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.DirectShapeOptions.PresentationType`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShapeOptions.PresentationType`

#### Summary

Identifies the DirectShape's GRep presentation type, used to determine its drawing order.
Before exposing to public_api: note that non-default presentation types may not make sense
for DirectShapes which consist of solids.

#### Since

2016

### `P:Autodesk.Revit.DB.DirectShapeOptions.AllowsTagAlongCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShapeOptions.AllowsTagAlongCurve`

#### Summary

Identifies whether the generic category tag for this DirectShape can be placed
by letting its leader slide along the DirectShape's curves,
as opposed to attach to the GRep's BBox center (default behavior).
Currently, tag along curve is only implemented for plan views.
Before exposing to public_api: note that enabling tag along curve behavior may not make sense
for DirectShapes which consist of solids.

#### Since

2016

### `P:Autodesk.Revit.DB.DirectShapeOptions.AllowsLock`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShapeOptions.AllowsLock`

#### Summary

Identifies whether the DirectShape can be locked.

#### Since

2016

### `P:Autodesk.Revit.DB.DirectShapeOptions.AllowsCopy`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShapeOptions.AllowsCopy`

#### Summary

Identifies whether the DirectShape can be copied.

#### Since

2016

### `P:Autodesk.Revit.DB.DirectShapeOptions.AllowsMove`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShapeOptions.AllowsMove`

#### Summary

Identifies whether the DirectShape is allowed to be moved or rotated.

#### Since

2016

### `P:Autodesk.Revit.DB.DirectShapeOptions.AllowsChangeTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShapeOptions.AllowsChangeTypeId`

#### Summary

Identifies whether the DirectShape allows for changes to its type id.

#### Since

2016

### `P:Autodesk.Revit.DB.DirectShapeOptions.RoomBoundingOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShapeOptions.RoomBoundingOption`

#### Summary

Identifies whether the DirectShape supports an option for the "Room Bounding" parameter to permit participation in room boundary calculations.

#### Since

2016

### `P:Autodesk.Revit.DB.DirectShapeOptions.ReferencingOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShapeOptions.ReferencingOption`

#### Summary

Whether or not the geometry stored in a DirectShape object may be referenced.

#### Remarks

If the geometry is not referenceable, it may not be used for dimensioning, snapping, alignment, or face-hosting.
The element may still be selected by the user for operations which do not reference individual geometry objects.

#### Value

The default value is Referenceable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `T:Autodesk.Revit.DB.DirectShapeOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectShapeOptions`

#### Summary

This class is used to control behavior of a DirectShape object.

#### Remarks

Use Enable/Disable functions to change the default behavior.
Use DirectShape.SetOptions to modify that object's behavior.

#### Since

2016

### `T:Autodesk.Revit.DB.DirectShapeReferencingOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectShapeReferencingOption`

#### Summary

An enumerated type containing possible referencing options for DirectShapes.

#### Since

2016

#### Since

2016

### `F:Autodesk.Revit.DB.DirectShapeReferencingOption.Referenceable`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectShapeReferencingOption.Referenceable`

#### Summary

The associated DirectShape may be dimensioned and/or otherwise referenced.

### `F:Autodesk.Revit.DB.DirectShapeReferencingOption.NotReferenceable`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectShapeReferencingOption.NotReferenceable`

#### Summary

The associated DirectShape shall not be referenceable.

### `T:Autodesk.Revit.DB.DirectShapeRoomBoundingOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectShapeRoomBoundingOption`

#### Summary

An enumerated type containing possible room bounding settings for DirectShapes.

#### Since

2016

#### Since

2016

### `F:Autodesk.Revit.DB.DirectShapeRoomBoundingOption.SetByParameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectShapeRoomBoundingOption.SetByParameter`

#### Summary

The associated DirectShape has a room bounding parameter which is which is writeable and defaults to on.
If can be toggled by a user or the API (by accessing the parameter WALL_ATTR_ROOM_BOUNDING).

### `F:Autodesk.Revit.DB.DirectShapeRoomBoundingOption.NotApplicable`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectShapeRoomBoundingOption.NotApplicable`

#### Summary

The associated DirectShape doesn't have a room bounding parameter, and isn't allowed to.
Trying to change to this value will result in an exception.
Trying to change from this value is restricted to DirectShapes that can be room bounding.

### `T:Autodesk.Revit.DB.PresentationTypeInternal`

Member kind: type
Symbol: `Autodesk.Revit.DB.PresentationTypeInternal`

#### Since

2021

#### Summary

An enumerated type which specifies options for the drawing order of a GRep.

#### Since

2021

### `F:Autodesk.Revit.DB.PresentationTypeInternal.DefinedByGrep`

Member kind: field
Symbol: `Autodesk.Revit.DB.PresentationTypeInternal.DefinedByGrep`

#### Summary

The drawing order is determined by the GRep's object type.

### `F:Autodesk.Revit.DB.PresentationTypeInternal.Detail`

Member kind: field
Symbol: `Autodesk.Revit.DB.PresentationTypeInternal.Detail`

#### Summary

The GRep draws on top of model elements and under annotations.

### `F:Autodesk.Revit.DB.PresentationTypeInternal.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.PresentationTypeInternal.Default`

#### Summary

The drawing order is determined by the GRep's object type.

### `M:Autodesk.Revit.DB.DirectShape.GetDirectContextTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.GetDirectContextTransform`

#### Summary

Gets the transform representing the transformation needed to transform the orginal
DirectContext3D in this DirectShape from its original position and orientation to its
current position and orientation.

#### Returns

The transform.

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShape.CanCreateParts`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.CanCreateParts`

#### Summary

Indicates if it is possible to create parts from this DirectShape element.

#### Remarks

While it is generally possible to create parts from DirectShape elements, some characteristics make parts creation impossible.
This property is re-evaluated every time the element's geometry is modified (via a call to SetShape or AppendShape).
Invalid configurations include: DirectShape elements containing a polymesh, or an open geometry, as well as DirectShape elements
not containing any solids and DirectShape elements configured as NotReferenceable (via a call to SetOptions).
Finally, if a DirectShape element has DirectShapeType instances in its geometry, and one of those DirectShapeTypes has a configuration
that is incompatible with parts creation, the DirectShape element will also be incompatible with parts creation.

#### Returns

True if it is possible to create parts from this DirectShape.

#### Since

2020

### `M:Autodesk.Revit.DB.DirectShape.IsValidShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.DirectShapeTargetViewType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.IsValidShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.DirectShapeTargetViewType)`

#### Summary

Validates view-specific shape to be stored in a DirectShape. Expects a non-default view type.

#### Parameter `shape`

Shape of this object expressed as a collection of GeometryObjects.
For viewType = DirectShapeTargetViewType::Default, the supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve.
For viewType = DirectShapeTargetViewType::Plan, the supported types of GeometryObjects are: Point and Curve.

#### Parameter `viewType`

The view type this shape is intended for.

#### Returns

True if the supplied shape passes the validation criteria.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `M:Autodesk.Revit.DB.DirectShape.IsValidShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.IsValidShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

#### Summary

Validates shape to be stored in a DirectShape. Supercedes and extends IsValidGeometry().

#### Remarks

This function calls IsValidShape(GeometryObject) to validate each object in the list.

#### Parameter `shape`

Shape to be validated represented as a collection of GeometryObjects.
The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve.

#### Returns

True if the supplied shape passes the validation criteria.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectShape.IsValidGeometry(Autodesk.Revit.DB.Solid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.IsValidGeometry(Autodesk.Revit.DB.Solid)`

#### Summary

Validates geometry to be stored in a DirectShape. Suitable geometry validation is performed. Additionally, the geometry
must make sense as a shape representation for the category assigned to this DirectShape object.

#### Parameter `Geom`

GeometryObject to be validated.

#### Returns

True if the supplied GeometryObject passes the validation criteria.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShape.IsValidTypeId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.IsValidTypeId(Autodesk.Revit.DB.ElementId)`

#### Summary

Tests the type id to make sure it satisfies the following conditions
It is a valid element id.

It corresponds to a valid DirectShapeType.

The DirectShapeType has the same category assigned.
Additionally, this functions tests that the current type id in this DirectShape is invalid.
The type id is initialized to invalidElementId by the create functions. Once it is set, it may no longer be changed.

#### Parameter `typeId`

Type id to be tested.

#### Returns

False unless typeId satisfies the conditions listed above and the type id of this object was not set previously.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShape.IsSupportedDocument(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.IsSupportedDocument(Autodesk.Revit.DB.Document)`

#### Summary

Tests whether a DirectShape or a DirectShapeType may be created in this document.

#### Remarks

Some types of Document, such as 2D families, can't support DirectShape functionality.

#### Parameter `document`

Document to be tested.

#### Returns

True if a DirectShape or a DirectShapeType object can be created in this document, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectShape.IsValidCategoryId(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.IsValidCategoryId(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document)`

#### Summary

Test the category id to make sure the category is allowed for a DirectShape or DirectShapeType.

#### Parameter `categoryId`

Category id to be tested.

#### Parameter `doc`

Document to look up the category by id.

#### Returns

True if the category is allowed for a DirectShape or DirectShapeType, false if not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShape.GetOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.GetOptions`

#### Summary

Gets a copy of the current options for this DirectShape.

#### Returns

Options currently set for this DirectShape.

#### Since

2016

### `M:Autodesk.Revit.DB.DirectShape.SetOptions(Autodesk.Revit.DB.DirectShapeOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.SetOptions(Autodesk.Revit.DB.DirectShapeOptions)`

#### Summary

Sets the options to use for this DirectShape.

#### Remarks

The new options take effect immediately.
If this DirectShape relies on a DirectShapeType for references, the options stored in DirectShapeType take precedence.
Note that changing options affects how the object interacts with Revit. E.g., switching references off will disable
existing constraints applied to that object.

#### Parameter `options`

Options to use for this DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The DirectShapeOptions provided are not valid for this DirectShape.
-or-
The DirectShapeOptions provided are not valid for this transient DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.DirectShape.AreOptionsValidForTransientDirectShape(Autodesk.Revit.DB.DirectShapeOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AreOptionsValidForTransientDirectShape(Autodesk.Revit.DB.DirectShapeOptions)`

#### Summary

Validates that the given DirectShapeOptions are allowed if this DirectShape is transient.

#### Parameter `options`

The options object.

#### Returns

True if the DirectShapeOptions are valid; false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.DirectShape.AreOptionsValid(Autodesk.Revit.DB.DirectShapeOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AreOptionsValid(Autodesk.Revit.DB.DirectShapeOptions)`

#### Summary

Validates that the given DirectShapeOptions are allowed for this particular DirectShape.

#### Parameter `options`

The options object.

#### Returns

True if the DirectShapeOptions are valid; false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.DirectShape.HasExternalGeometry(Autodesk.Revit.DB.ExternalGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.HasExternalGeometry(Autodesk.Revit.DB.ExternalGeometryId)`

#### Summary

Checks whether the externally tagged geometry is already present in this DirectShape.

#### Parameter `externalId`

The external ID of the externally tagged geometry to check.

#### Returns

True if such an externally tagged geometry is already present in this DirectShape, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.ResetExternallyTaggedGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.ResetExternallyTaggedGeometry`

#### Summary

Removes all of the externally tagged geometry in this DirectShape.

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.RemoveExternallyTaggedGeometry(Autodesk.Revit.DB.ExternalGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.RemoveExternallyTaggedGeometry(Autodesk.Revit.DB.ExternalGeometryId)`

#### Summary

Removes the externally tagged geometry object by its external ID from this DirectShape.

#### Parameter `externalId`

The external ID of the externally tagged geometry that should be removed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The externally tagged geometry with the input externalId is not present in this DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.UpdateExternallyTaggedGeometry(Autodesk.Revit.DB.ExternallyTaggedGeometryObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.UpdateExternallyTaggedGeometry(Autodesk.Revit.DB.ExternallyTaggedGeometryObject)`

#### Summary

Updates the externally tagged geometry object in the DirectShape.

#### Parameter `externallyTaggedGeometry`

The externally tagged geometry that should be updated in the DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input shape does not satisfy DirectShape validation criteria.
-or-
A previous version of the externally tagged geometry is not present in this DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.GetExternallyTaggedGeometry(Autodesk.Revit.DB.ExternalGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.GetExternallyTaggedGeometry(Autodesk.Revit.DB.ExternalGeometryId)`

#### Summary

Gets the externally tagged geometry by its external ID that is stored in this DirectShape.

#### Parameter `externalId`

The external ID of the externally tagged geometry that should be obtained.

#### Returns

The externally tagged geometry.
Or `null` if there is no such an externally tagged geometry in the DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.AddExternallyTaggedGeometry(Autodesk.Revit.DB.ExternallyTaggedGeometryObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AddExternallyTaggedGeometry(Autodesk.Revit.DB.ExternallyTaggedGeometryObject)`

#### Summary

Adds the externally tagged geometry object to the DirectShape.

#### Parameter `externallyTaggedGeometry`

The externally tagged geometry that should be added to the DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input shape does not satisfy DirectShape validation criteria.
-or-
The input geometry does not have a permitted usage.
-or-
The externallyTaggedGeometry has already been added to this DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.IsValidUsage(Autodesk.Revit.DB.ExternallyTaggedGeometryObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.IsValidUsage(Autodesk.Revit.DB.ExternallyTaggedGeometryObject)`

#### Summary

Validates that the ExternallyTaggedGeometryObject's usage is set to an allowed value for a DirectShape.

#### Parameter `externallyTaggedGeometry`

The geometry to check.

#### Returns

True if the usage is permitted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.DirectShape.IsValidShape(Autodesk.Revit.DB.ExternallyTaggedGeometryObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.IsValidShape(Autodesk.Revit.DB.ExternallyTaggedGeometryObject)`

#### Summary

Validates shape to be stored in a DirectShape.

#### Remarks

This function uses the same criteria as IsValidShape(GeometryObject).

#### Parameter `externallyTaggedGeometry`

The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve.

#### Returns

True if the supplied shape passes the validation criteria.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.DirectShape.IsValidReferencePlaneBoundingBoxUV(Autodesk.Revit.DB.BoundingBoxUV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.IsValidReferencePlaneBoundingBoxUV(Autodesk.Revit.DB.BoundingBoxUV)`

#### Summary

Validates that the input BoundingBoxUV is suitable for bounding a reference plane surface.
The input BoundingBoxUV must be set and not degenerate.

#### Parameter `boundingBoxUV`

The reference plane BoundingBoxUV to test.

#### Returns

True if the input BoundingBoxUV is valid for reference plane surfaces, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.IsValidReferenceCurve(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.IsValidReferenceCurve(Autodesk.Revit.DB.Curve)`

#### Summary

Validates that the input curve is suitable for creating a direct shape reference curve.
Bounded and unbounded lines are accepted.
Other bounded and unbounded curve types with natural bounds are accepted if they are not closed.
Unbounded periodic curves are not allowed.

#### Parameter `curve`

The curve to test.

#### Returns

True if the input curve point can be used to create a direct shape reference curve, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.AreValidDirectShapeReferenceOptions(Autodesk.Revit.DB.DirectShapeReferenceOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AreValidDirectShapeReferenceOptions(Autodesk.Revit.DB.DirectShapeReferenceOptions)`

#### Summary

Validates that the input DirectShapeReferenceOptions are suitable for creating a direct shape reference object.
If the options specify an ExternalGeometryId, it must not correspond to any existing reference object
belonging to the DirectShape.

#### Parameter `options`

The options to test.

#### Returns

True if the options can be used to add a reference object to this DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.DirectShape.RemoveAllReferenceObjects`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.RemoveAllReferenceObjects`

#### Summary

Removes all reference objects (if any) from the DirectShape.

#### Since

2024

### `M:Autodesk.Revit.DB.DirectShape.RemoveReferenceObject(Autodesk.Revit.DB.ExternalGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.RemoveReferenceObject(Autodesk.Revit.DB.ExternalGeometryId)`

#### Summary

Removes any reference object associated with the provided ExternalGeometryId from the DirectShape.
Nothing is done if no reference object has the given external ID or if the external ID is an empty string.

#### Parameter `externalId`

The ExternalGeometryId of the reference object to be removed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.DirectShape.RemoveReferenceObject(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.RemoveReferenceObject(System.String)`

#### Summary

Removes any reference objects with the given name from the DirectShape.
Nothing is done if no reference objects have the given name or if the name is the empty string.

#### Parameter `refName`

The name of the reference object(s) to be removed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.DirectShape.AddReferencePoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.DirectShapeReferenceOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AddReferencePoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.DirectShapeReferenceOptions)`

#### Summary

Adds a reference point to the DirectShape.

#### Parameter `refPoint`

The coordinates of the new reference point.

#### Parameter `options`

The options that are used to configure the new reference point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input point lies outside of Revit design limits.
-or-
options cannot be used to add a reference object to this DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.AddReferencePoint(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AddReferencePoint(Autodesk.Revit.DB.XYZ)`

#### Summary

Adds a reference point to the DirectShape.

#### Parameter `refPoint`

The coordinates of the new reference point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input point lies outside of Revit design limits.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.AddReferencePlane(Autodesk.Revit.DB.Plane,Autodesk.Revit.DB.BoundingBoxUV,Autodesk.Revit.DB.DirectShapeReferenceOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AddReferencePlane(Autodesk.Revit.DB.Plane,Autodesk.Revit.DB.BoundingBoxUV,Autodesk.Revit.DB.DirectShapeReferenceOptions)`

#### Summary

Adds a reference plane to the DirectShape. The reference plane can either be bounded or unbounded.

#### Parameter `refPlane`

The geometry of the new reference plane.

#### Parameter `boundingBoxUV`

If boundingBoxUV is set, the resulting reference plane that is added to the DirectShape will be displayed
with those bounds. Note that the specified bounds must not be degenerate.
If boundingBoxUV is not set, reasonable bounds are automatically calculated and applied to the input plane.
The automatic bounds are based on the host direct shape's geometry.

#### Parameter `options`

The options that are used to configure the new reference plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

boundingBoxUV cannot be used as a BoundingBoxUV for the reference plane surface.
-or-
options cannot be used to add a reference object to this DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.AddReferencePlane(Autodesk.Revit.DB.Plane,Autodesk.Revit.DB.DirectShapeReferenceOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AddReferencePlane(Autodesk.Revit.DB.Plane,Autodesk.Revit.DB.DirectShapeReferenceOptions)`

#### Summary

Adds a reference plane to the DirectShape. The reference plane can either be bounded or unbounded.

#### Parameter `refPlane`

The geometry of the new reference plane.

#### Parameter `options`

The options that are used to configure the new reference plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

options cannot be used to add a reference object to this DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.AddReferencePlane(Autodesk.Revit.DB.Plane,Autodesk.Revit.DB.BoundingBoxUV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AddReferencePlane(Autodesk.Revit.DB.Plane,Autodesk.Revit.DB.BoundingBoxUV)`

#### Summary

Adds a reference plane to the DirectShape. The reference plane can either be bounded or unbounded.

#### Parameter `refPlane`

The geometry of the new reference plane.

#### Parameter `boundingBoxUV`

If boundingBoxUV is set, the resulting reference plane that is added to the DirectShape will be displayed
with those bounds. Note that the specified bounds must not be degenerate.
If boundingBoxUV is not set, reasonable bounds are automatically calculated and applied to the input plane.
The automatic bounds are based on the host direct shape's geometry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

boundingBoxUV cannot be used as a BoundingBoxUV for the reference plane surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.AddReferencePlane(Autodesk.Revit.DB.Plane)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AddReferencePlane(Autodesk.Revit.DB.Plane)`

#### Summary

Adds a reference plane to the DirectShape. The reference plane can either be bounded or unbounded.

#### Parameter `refPlane`

The geometry of the new reference plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.AddReferenceCurve(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.DirectShapeReferenceOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AddReferenceCurve(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.DirectShapeReferenceOptions)`

#### Summary

Adds a reference curve to the DirectShape.

#### Parameter `refCurve`

The geometry of the new reference curve.
First case: The input curve's bounds are set. The resulting reference curve that is added to the
DirectShape will be displayed with those bounds. Note that the specified bounds must not be degenerate.
Second case: The input curve is unbounded. Reasonable bounds are therefore automatically calculated
and applied to the input curve. The automatic bounds are based on the host direct shape's geometry.
Note that only lines and splines may be unbounded. You must specify valid bounds for all other curve types.

#### Parameter `options`

The options that are used to configure the new reference curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

refCurve cannot be used for creating a reference curve.
-or-
options cannot be used to add a reference object to this DirectShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.AddReferenceCurve(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AddReferenceCurve(Autodesk.Revit.DB.Curve)`

#### Summary

Adds a reference curve to the DirectShape.

#### Parameter `refCurve`

The geometry of the new reference curve.
First case: The input curve's bounds are set. The resulting reference curve that is added to the
DirectShape will be displayed with those bounds. Note that the specified bounds must not be degenerate.
Second case: The input curve is unbounded. Reasonable bounds are therefore automatically calculated
and applied to the input curve. The automatic bounds are based on the host direct shape's geometry.
Note that only lines and splines may be unbounded. You must specify valid bounds for all other curve types.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

refCurve cannot be used for creating a reference curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.DirectShape.GetExternallyTaggedReference(Autodesk.Revit.DB.ExternalGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.GetExternallyTaggedReference(Autodesk.Revit.DB.ExternalGeometryId)`

#### Summary

Retrieve a Reference to reference geometry of the DirectShape that is associated with a particular ExternalGeometryId.

#### Parameter `externalId`

The ExternalGeometryId of the requested reference object.

#### Returns

A Reference to the externally tagged reference GeometryObject having the provided external ID
or `null` if there is no reference geometry having the external ID.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.DirectShape.HasExternallyTaggedReference(Autodesk.Revit.DB.ExternalGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.HasExternallyTaggedReference(Autodesk.Revit.DB.ExternalGeometryId)`

#### Summary

Checks if the externally tagged reference is already present in this DirectShape.

#### Parameter `externalId`

The external ID of the tagged reference to check for.

#### Returns

True if the DirectShape holds a reference with the specified ExternalGeometryId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.DirectShape.AppendShape(Autodesk.Revit.DB.ShapeBuilder)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AppendShape(Autodesk.Revit.DB.ShapeBuilder)`

#### Summary

Appends shape built by the supplied ShapeBuilderObject to shape representation stored in this DirectShape.
The data stored in the supplied ShapeBuilder object will be cleared.

#### Remarks

The existing shape will not be cleared by this function, and intersecting or overlapped geometry will not be
joined with the appended geometry. It is up to the caller to ensure that the combination of geometry
will have the correct appearance in Revit.
This function will bypass extra geometry validation because the built geometry has already been validated by the ShapeBuilder.
It is therefore slightly more efficient than the AppendShape() routine that accepts GeometryObjects directly as input.

#### Parameter `ShapeBuilder`

The ShapeBuilder object that was used to build the shape to be appended.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.DirectShape.AppendShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.DirectShapeTargetViewType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AppendShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.DirectShapeTargetViewType)`

#### Summary

Appends the collection of GeometryObjects into the model or view specific shape representation stored in this DirectShape.
Passing DirectShapeTargetViewType.Default as view type will cause the model shape to be updated.

#### Remarks

The existing shape will not be cleared by this function, and intersecting or overlapped geometry will not be
joined with the appended geometry. It is up to the caller to ensure that the combination of geometry
will have the correct appearance in Revit.

#### Parameter `pGeomArr`

Shape expressed as a collection of GeometryObjects.
For viewType = DirectShapeTargetViewType::Default, the supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve.
For viewType = DirectShapeTargetViewType::Plan, the supported types of GeometryObjects are: Point and Curve.

#### Parameter `viewType`

Passing DirectShapeTargetViewType.Default as view type will cause the default shape to be appended.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

At least one member of pGeomArr does not satisfy DirectShape validation criteria.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.DirectShape.AppendShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.AppendShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

#### Summary

Appends the collection of GeometryObjects into the model shape representation stored in this DirectShape.

#### Remarks

The existing shape will not be cleared by this function, and intersecting or overlapped geometry will not be
joined with the appended geometry. It is up to the caller to ensure that the combination of geometry
will have the correct appearance in Revit.

#### Parameter `pGeomArr`

Shape expressed as a collection of GeometryObjects.
The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

At least one member of pGeomArr does not satisfy DirectShape validation criteria.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.DirectShape.SetShape(Autodesk.Revit.DB.ShapeBuilder)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.SetShape(Autodesk.Revit.DB.ShapeBuilder)`

#### Summary

Sets the shape of this object to the one accumulated in the supplied Builder object.
If the new shape is identical to the old one, the old shape will be kept.

#### Remarks

This function will bypass extra geometry validation because the built geometry has already been validated by the ShapeBuilder.
It is therefore slightly more efficient than the SetShape() routine that accepts GeometryObjects directly as input.
Supplying a ViewShapeBuilder object as argument will cause the view-specific shape of this DirectShape to be updated.
Supplying other ShapeBuilder types will update the model shape.

#### Parameter `pBuilder`

A ShapeBuilder object that was used to successfully build geometry to store in this DirectShape.
The built shape will be transferred to the DirectShape, and the ShapeBuilder object will be reset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.DirectShape.SetShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.DirectShapeTargetViewType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.SetShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.DirectShapeTargetViewType)`

#### Summary

Builds the shape of this object from the supplied collection of GeometryObjects. The objects are copied.
If the new shape is identical to the old one, the old shape will be kept.

#### Parameter `pGeomArr`

Shape of this object expressed as a collection of GeometryObjects.
For viewType = DirectShapeTargetViewType::Default, the supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve.
For viewType = DirectShapeTargetViewType::Plan, the supported types of GeometryObjects are: Point and Curve.

#### Parameter `viewType`

Optional: set a view-specific shape representation that will be used in views of that type only.
Passing DirectShapeTargetViewType::Default as view type will cause the default shape to be set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

At least one member of pGeomArr does not satisfy DirectShape validation criteria.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShape.SetShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.SetShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

#### Summary

Builds the shape of this object from the supplied collection of GeometryObjects. The objects are copied.
If the new shape is identical to the old one, the old shape will be kept.

#### Parameter `pGeomArr`

Shape of this object expressed as a collection of GeometryObjects.
The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

At least one member of pGeomArr does not satisfy DirectShape validation criteria.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShape.SetName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.SetName(System.String)`

#### Summary

Sets the name for the DirectShape element.

#### Parameter `name`

The name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShape.SetTypeId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.SetTypeId(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the DirectShapeType for the DirectShape element.

#### Parameter `typeId`

The ID of the type corresponding to this DirectShape element. May only be set once.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

typeId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShape.CreateElementInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.String,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.CreateElementInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.String,Autodesk.Revit.DB.Transform)`

#### Summary

Creates a DirectShape object and adds it to document.

#### Remarks

This function is included for convenience. It essentially combines CreateGeometryInstance and CreateElement.
The shape stored in the element is either a reference or a copy of a definition shape that was created earlier.
How the definitions are stored will determine whether an instance or a copy of the shape will be created.
The intended use is to support a definition/instance pattern common in CAD formats - DWG blocks, STEP MAPPED_ITEM, IFC IfcMappedItem.
Use DirectShapeLibrary class to store definitions prior to using them here.

#### Parameter `document`

Document to which the created element will be added.

#### Parameter `typeId`

Element id of a DirectShapeType element.

#### Parameter `categoryId`

Id of the category assigned to this DirectShape. Must be a valid category id.

#### Parameter `definitionId`

Id of the shape definition that was created earlier and stored via DirectShapeLibrary.

#### Parameter `trf`

Transform to be applied to the definition.

#### Returns

The created DirectShape object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Document document may not contain DirectShape or DirectShapeType objects.
-or-
Element id categoryId may not be used as a DirectShape category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectShape.CreateGeometryInstance(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.CreateGeometryInstance(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Transform)`

#### Summary

Creates a copy of a definition shape that was created earlier.

#### Remarks

Use DirectShapeLibrary class to store definitions prior to using them here.
How the definitions are stored will determine whether an instance or a copy of the shape will be created.
Use the output of this function as input to CreateElement to make the created shape persistent.
This is intended to support a definition/instance pattern common in CAD formats - DWG blocks, STEP MAPPED_ITEM, IFC IfcMappedItem.

#### Parameter `document`

Document to which the created element will be added

#### Parameter `definition_id`

ID of the shape definition that was created earlier and stored via DirectShapeLibrary

#### Parameter `trf`

Transform to be applied to the definition

#### Returns

A collection of GeometryObjects representing a placed instance of the pre-defined shape
The caller function takes ownership

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.DirectShape.CreateElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectShape.CreateElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a DirectShape object and adds it to document.

#### Parameter `document`

Document to which the created element will be added.

#### Parameter `categoryId`

Id of the category assigned to this DirectShape. Must be a valid category id.

#### Returns

The created DirectShape object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Document document may not contain DirectShape or DirectShapeType objects.
-or-
Element id categoryId may not be used as a DirectShape category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.DirectShape.ApplicationDataId`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShape.ApplicationDataId`

#### Summary

A text string that identifies the data to the creating application.

#### Remarks

The intended use is to enable the creating application to identify the native data that was the source of this DirectShape.
However, the creating application may use any text string as appropriate for its purposes, or leave this property unset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.DirectShape.ApplicationId`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShape.ApplicationId`

#### Summary

A text string that identifies the creating application.

#### Remarks

The creating application may use any text string as appropriate for its purposes, or leave this property unset.
One option is to use Application.ActiveAddInId for a unique application id, or concatenate it with an application name for a more informative, but still unique id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.DirectShape.TypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectShape.TypeId`

#### Summary

Element id of a DirectShapeType object that holds properties to be shared by this element. Optional.

#### Since

2015

### `T:Autodesk.Revit.DB.DirectShape`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectShape`

#### Summary

This class is used to store externally created geometric shapes. Primary intended use is for importing shapes from other data formats such as IFC or STEP.
A DirectShape object may be assigned a category. That will affect how that object is displayed in Revit.

#### Remarks

DirectShape is not a replacement for "real" Wall, Roof, Window, etc. It would typically be used where there is not enough information
to create, e.g., a Wall, or full functionality of a Wall object is not needed. Some category-specific functionality may be available.

If you need to modify a shape held by a DirectShape object, use Revit Geometry API, and then store the modified shape back to the DirectShape object.

#### Since

2015

### `T:Autodesk.Revit.DB.DirectShapeTargetViewType`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectShapeTargetViewType`

#### Summary

View types for which DirectShape objects are allowed to have alternative shape representations

#### Since

2015

#### Summary

View types for which DirectShape objects are allowed to have alternative shape representations. Currently limited to Plan Views.

#### Since

2015

### `F:Autodesk.Revit.DB.DirectShapeTargetViewType.Plan`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectShapeTargetViewType.Plan`

#### Summary

The alternate representation will be used only in Revit Plan views

### `F:Autodesk.Revit.DB.DirectShapeTargetViewType.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectShapeTargetViewType.Default`

#### Summary

Shape to be used in all views for which a view-specific shape was not provided

### `F:Autodesk.Revit.DB.DirectShapeTargetViewType.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectShapeTargetViewType.Undefined`

#### Summary

Invalid value

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.UpdateHandleTypeSourceId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.UpdateHandleTypeSourceId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String)`

#### Summary

Updates a DirectContext3D handle type element based on the information reported by the corresponding DirectContext3D server.

#### Parameter `aDocument`

The document.

#### Parameter `handleTypeId`

The ID of the handle type element.

#### Parameter `sourceId`

The navisworks file path

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the Element ID handleTypeId does not correspond to a valid DirectContext3D handle type.

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

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.RegenerateHandleType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.RegenerateHandleType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Updates a DirectContext3D handle type element based on the information reported by the corresponding DirectContext3D server.

#### Parameter `aDocument`

The document.

#### Parameter `handleTypeId`

The ID of the handle type element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the Element ID handleTypeId does not correspond to a valid DirectContext3D handle type.

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

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.CreateDirectContext3DHandleInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.CreateDirectContext3DHandleInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a DirectContext3D handle instance element based on the specified handle type element.

#### Parameter `aDocument`

The document.

#### Parameter `handleTypeId`

The ID of the handle type element.

#### Returns

The created handle instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the Element ID handleTypeId does not correspond to a valid DirectContext3D handle type.
-or-
aDocument is not a project document.
-or-
aDocument is not a primary document, it is a linked document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the handle instance could not be created based on the specified handle type element.

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

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.CreateDirectContext3DHandleType(Autodesk.Revit.DB.Document,System.String,System.String,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.CreateDirectContext3DHandleType(Autodesk.Revit.DB.Document,System.String,System.String,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a DirectContext3D handle type element based on the information provided by the specified DirectContext3D server.

#### Parameter `aDocument`

The document.

#### Parameter `sourceId`

The source of directContext data.

#### Parameter `applicationId`

The ID of the application that will supply the server

#### Parameter `handleCategory`

The DirectContext3D handle category to assign to the new handle.

#### Returns

The created handle type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the category ID handleCategory is not valid for DirectContext3D handles.
-or-
aDocument is not a project document.
-or-
aDocument is not a primary document, it is a linked document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if handle type geometry could not be created based on the bounding box provided by the DirectContext3D server.

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

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.GetDirectContext3DHandleInstances(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.GetDirectContext3DHandleInstances(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns all DirectContext3D handle instances of the given category in the document.

#### Parameter `aDocument`

The document.

#### Parameter `handleCategory`

A category of DirectContext3D handles.

#### Returns

The set of DirectContext3D handle instances of the given category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the category ID handleCategory is not valid for DirectContext3D handles.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.GetDirectContext3DHandleTypes(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.GetDirectContext3DHandleTypes(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns all DirectContext3D handle types of the given category in the document.

#### Parameter `aDocument`

The document.

#### Parameter `handleCategory`

A category of DirectContext3D handles.

#### Returns

The set of DirectContext3D handle types of the given category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the category ID handleCategory is not valid for DirectContext3D handles.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.IsADirectContext3DHandleInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.IsADirectContext3DHandleInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the provided Element ID corresponds to a DirectContext3D handle instance element.

#### Remarks

DirectContext3D handle instances are DirectShapes.

#### Parameter `aDocument`

The document.

#### Parameter `elementId`

The ID of the element to check.

#### Returns

True, if the element is a valid DirectContext3D handle instance, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

aDocument is not a project document.
-or-
elementId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.IsADirectContext3DHandleType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.IsADirectContext3DHandleType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the provided Element ID corresponds to a DirectContext3D handle type element.

#### Remarks

DirectContext3D handle types are DirectShapeTypes.

#### Parameter `aDocument`

The document.

#### Parameter `elementId`

The ID of the element to check.

#### Returns

True, if the element is a valid DirectContext3D handle type, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

aDocument is not a project document.
-or-
elementId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.IsADirectContext3DHandleCategory(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils.IsADirectContext3DHandleCategory(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the provided category ID is one of the categories used by DirectContext3D handle elements.

#### Parameter `categoryId`

The category ID to check.

#### Returns

True, if the category is valid for DirectContext3D handle elements, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `T:Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils`

#### Summary

The methods provided by this utility class support the use of DirectContext3D and storage of DirectContext3D handle elements in Revit documents.

#### Remarks

DirectContext3D graphics can be displayed without storing the graphics in elements. However, the reference to the externally generated
graphics will not persist beyond the current session, and there will be no capabilities for the user to select and interact with the graphics.
The utility methods in this class support creation and updating of DirectContext3D handle and handle instance elements (which for this release are
`!:Autodesk::Revit::DB::DirectShapeType` and `!:Autodesk::Revit::DB::DirectShape` instances, however this may not always be the
case). The capabilities provided by these handle elements include:
A special geometry object remembers the existence and source location of the external graphics.

A generated 3D bounding box surrounds the provided graphics. This box is set to be selectable but its properties are mostly not modifiable.
However, the user can reposition the box and the associated external graphics with it.

The type and instance relationship between DirectContext3D handles and handle instances allows one DirectContext3D server to act as the provider
of one set of graphics (the type) that the API displays in multiple locations, as determined by the handle instances.

The handle element will be associated to a specified category. The only currently valid category is OST_Coordination_Model.

The application is required to update the handle type element using `!:UpdateDirectContext3DHandleType()` whenever the source data
changes. It also is required that the application update the handle during initial load of the document containing this element.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.Camera.Transform(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.Transform(Autodesk.Revit.DB.Transform)`

#### Summary

Transforms the camera

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.Camera.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.DirectContext3D.Camera.FarDistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.FarDistance`

#### Summary

Distance to far clipping plane

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.Camera.NearDistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.NearDistance`

#### Summary

Distance to near clipping plane

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.Camera.VerticalOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.VerticalOffset`

#### Summary

Vertical offset of the camera's view center from target, measured at target distance.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.Camera.VerticalExtent`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.VerticalExtent`

#### Summary

Vertical extent of the camera's view, measured at target distance.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.Camera.HorizontalOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.HorizontalOffset`

#### Summary

Horizontal offset of the camera's view center from target, measured at target distance.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.Camera.HorizontalExtent`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.HorizontalExtent`

#### Summary

Horizontal extent of the camera's view, measured at target distance.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.Camera.TargetDistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.TargetDistance`

#### Summary

Distance from camera to its target

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.Camera.ProjectionMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.ProjectionMethod`

#### Summary

Projection method

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.Camera.UpDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.UpDirection`

#### Summary

Up direction of the camera

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.Camera.ViewDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.ViewDirection`

#### Summary

Direction that the camera is facing

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.Camera.EyePosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.EyePosition`

#### Summary

Camera's position in the world

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.Camera.#ctor(Autodesk.Revit.DB.DirectContext3D.Camera)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera.#ctor(Autodesk.Revit.DB.DirectContext3D.Camera)`

#### Summary

Camera

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.Camera`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.Camera`

#### Summary

A collection of camera settings for the current view.

#### Remarks

The current Camera can be obtained from `T:Autodesk.Revit.DB.DirectContext3D.DrawContext`

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.ProjectionMethod`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.ProjectionMethod`

#### Summary

Projection method

#### Since

2017

### `F:Autodesk.Revit.DB.DirectContext3D.ProjectionMethod.Perspective`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectContext3D.ProjectionMethod.Perspective`

#### Summary

Perspective

### `F:Autodesk.Revit.DB.DirectContext3D.ProjectionMethod.Orthographic`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectContext3D.ProjectionMethod.Orthographic`

#### Summary

Orthographic

### `M:Autodesk.Revit.DB.DirectContext3D.DrawContext.IsAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DrawContext.IsAvailable`

#### Summary

Checks whether the facilities of this class are available for use in the current scope.

#### Remarks

This class can perform drawing operations and access the state of parameters related to drawing only
in lock-step with rendering inside of Revit. As a consequence, the facilities of this class are not available for
use outside of the scope determined by the callback `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.RenderScene(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DisplayStyle)` .
Certain methods of other DirectContext3D objects, e.g., VertexBuffer::Map() are similarly restricted by the same scope.

#### Returns

True if the DrawContext is available for rendering, false otherwise.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.DrawContext.SetWorldTransform(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DrawContext.SetWorldTransform(Autodesk.Revit.DB.Transform)`

#### Summary

Sets the world transformation that will be applied to geometry during rendering.

#### Parameter `trf`

The transformation matrix.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This DrawContext is not available because Revit is not currently rendering. In general, this DrawContext must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.DrawContext.GetOverrideTransparency(System.Double@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DrawContext.GetOverrideTransparency(System.Double@)`

#### Summary

Returns override transparency that will be applied to geometry during rendering.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.DrawContext.GetOverrideColor(Autodesk.Revit.DB.Color@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DrawContext.GetOverrideColor(Autodesk.Revit.DB.Color@)`

#### Summary

Returns override color that will be applied to geometry during rendering.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.DrawContext.IsTransparentPass`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DrawContext.IsTransparentPass`

#### Summary

Determines whether the current rendering pass is for transparent objects.

#### Remarks

Opaque and transparent geometry should be submitted for rendering separately.
See `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.UseInTransparentPass(Autodesk.Revit.DB.View)` .

#### Returns

True when the server should be submitting transparent objects for rendering, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This DrawContext is not available because Revit is not currently rendering. In general, this DrawContext must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.DrawContext.GetCamera`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DrawContext.GetCamera`

#### Summary

Gets the camera corresponding to the Revit view where rendering takes place.

#### Returns

The camera.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This DrawContext is not available because Revit is not currently rendering. In general, this DrawContext must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.DrawContext.GetClipPlanes`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DrawContext.GetClipPlanes`

#### Summary

Gets the clipping planes for the Revit view where rendering takes place.
Clipping planes control the 3D extent of a view and can be set using Section Box in Revit.

#### Returns

The array of clipping planes, which is empty if none are set.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This DrawContext is not available because Revit is not currently rendering. In general, this DrawContext must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.DrawContext.GetClipRectangle`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DrawContext.GetClipRectangle`

#### Summary

Gets the clip rectangle for the Revit view where rendering takes place. The clip rectangle
is the area currently being redrawn, which may be smaller than the view rectangle.

#### Returns

The clip rectangle.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This DrawContext is not available because Revit is not currently rendering. In general, this DrawContext must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.DrawContext.GetViewRectangle`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DrawContext.GetViewRectangle`

#### Summary

Gets the rectangle that represents the extent (in 2D) of the Revit view where rendering takes place.

#### Returns

The view rectangle.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This DrawContext is not available because Revit is not currently rendering. In general, this DrawContext must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.DrawContext.IsInterrupted`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DrawContext.IsInterrupted`

#### Summary

Checks whether the current rendering pass has been interrupted.

#### Returns

True if the current rendering pass has been interrupted before its completion, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This DrawContext is not available because Revit is not currently rendering. In general, this DrawContext must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.DrawContext.FlushBuffer(Autodesk.Revit.DB.DirectContext3D.VertexBuffer,System.Int32,Autodesk.Revit.DB.DirectContext3D.IndexBuffer,System.Int32,Autodesk.Revit.DB.DirectContext3D.VertexFormat,Autodesk.Revit.DB.DirectContext3D.EffectInstance,Autodesk.Revit.DB.DirectContext3D.PrimitiveType,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.DrawContext.FlushBuffer(Autodesk.Revit.DB.DirectContext3D.VertexBuffer,System.Int32,Autodesk.Revit.DB.DirectContext3D.IndexBuffer,System.Int32,Autodesk.Revit.DB.DirectContext3D.VertexFormat,Autodesk.Revit.DB.DirectContext3D.EffectInstance,Autodesk.Revit.DB.DirectContext3D.PrimitiveType,System.Int32,System.Int32)`

#### Summary

Submits geometry for rendering.

#### Parameter `vertexBuffer`

The vertex buffer that contains vertex data.

#### Parameter `vertexCount`

The number of vertices in the vertex buffer.

#### Parameter `indexBuffer`

The index buffer that contains indices into the vertex buffer.

#### Parameter `indexCount`

The number of indices in the index buffer.

#### Parameter `vertexFormat`

The format of the vertices in the vertex buffer.

#### Parameter `effectInstance`

The effect instance to be used for drawing this piece of geometry.

#### Parameter `primitiveType`

The type of geometry primitive used in the index buffer.

#### Parameter `start`

The first index to use for drawing.

#### Parameter `primitiveCount`

The number of primitives to draw.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

A change in the graphics state has made the vertex buffer vertexBuffer invalid for rendering.
-or-
A change in the graphics state has made the index buffer indexBuffer invalid for rendering.
-or-
A change in the graphics state has made the vertex format vertexFormat invalid for rendering.
-or-
A change in the graphics state has made the effect instance effectInstance invalid for rendering.
-or-
The vertex format vertexFormat and the effect instance effectInstance do not match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This DrawContext is not available because Revit is not currently rendering. In general, this DrawContext must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.DrawContext`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.DrawContext`

#### Summary

A class that provides drawing functionality for use by `T:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer` servers

#### Remarks

The drawing facility of this class is conceptually similar to a low-level graphics API.
The functionality operates on a set of geometry primitives such as triangles, lines, and points, which are encoded into
a set of vertex and index buffers.

Aside from submission of geometry in buffers, a major part of the drawing process is
responding to certain changes in graphics state. For example, users of this class can implement progressive rendering
of geometry by testing whether there have been interruptions that should prevent the drawing from being completed.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.ClipPlane.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.ClipPlane.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.DirectContext3D.ClipPlane.Normal`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.ClipPlane.Normal`

#### Summary

The plane's normal vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.ClipPlane.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.ClipPlane.Origin`

#### Summary

The plane's origin.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.ClipPlane.#ctor(Autodesk.Revit.DB.DirectContext3D.ClipPlane)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.ClipPlane.#ctor(Autodesk.Revit.DB.DirectContext3D.ClipPlane)`

#### Summary

Constructs a copy of the clip plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.ClipPlane`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.ClipPlane`

#### Summary

A set of parameters representing a clip plane in DirectContext3D.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.PrimitiveType`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.PrimitiveType`

#### Summary

Type of geometry primitive represented as a number.

#### Since

2017

### `F:Autodesk.Revit.DB.DirectContext3D.PrimitiveType.PointList`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectContext3D.PrimitiveType.PointList`

#### Summary

Geometry consisting of a list of points.

### `F:Autodesk.Revit.DB.DirectContext3D.PrimitiveType.LineList`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectContext3D.PrimitiveType.LineList`

#### Summary

Geometry consisting of a list of line segments.

### `F:Autodesk.Revit.DB.DirectContext3D.PrimitiveType.TriangleList`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectContext3D.PrimitiveType.TriangleList`

#### Summary

Geometry consisting of a list of triangles.

### `M:Autodesk.Revit.DB.DirectContext3D.VertexFormat.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexFormat.IsValid`

#### Summary

Tests whether the vertex format specification is valid for rendering.

#### Remarks

The vertex format specifications are internally associated with low-level graphics state and may become invalidated when
the state changes. Therefore, an application should test each vertex format object for validity before using it when
submitting geometry. If the vertex format object becomes invalid, the application should re-create it.

#### Returns

True if the vertex format specification is valid for rendering, false otherwise.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.VertexFormat.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexFormat.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.DirectContext3D.VertexFormat.#ctor(Autodesk.Revit.DB.DirectContext3D.VertexFormatBits)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexFormat.#ctor(Autodesk.Revit.DB.DirectContext3D.VertexFormatBits)`

#### Summary

Constructs the specification of vertex format from a numerical representation.

#### Parameter `vertexFormatBits`

The numerical representation of the vertex format.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This VertexFormat is not available because Revit is not currently rendering. In general, this VertexFormat must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.VertexFormat`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexFormat`

#### Summary

A specification of the format of vertex data contained in a piece of geometry.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetTransparency(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetTransparency(System.Double)`

#### Summary

Sets the transparency parameter of the effect instance.

#### Parameter `transparency`

The transparency value.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetGlossiness(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetGlossiness(System.Double)`

#### Summary

Sets the glossiness parameter of the effect instance.

#### Parameter `glossiness`

The glossiness value.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetSpecularColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetSpecularColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the specular color parameter of the effect instance.

#### Parameter `color`

The specular color value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetEmissiveColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetEmissiveColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the emissive color parameter of the effect instance.

#### Parameter `color`

The emissive color value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetDiffuseColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetDiffuseColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the diffuse color parameter of the effect instance.

#### Parameter `color`

The diffuse color value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetAmbientColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetAmbientColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the ambient color parameter of the effect instance.

#### Parameter `color`

The ambient color value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetColor(Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetColor(Autodesk.Revit.DB.Color)`

#### Summary

Sets the color parameter of the effect instance.

#### Parameter `color`

The color value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.MatchesFormat(Autodesk.Revit.DB.DirectContext3D.VertexFormat)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.EffectInstance.MatchesFormat(Autodesk.Revit.DB.DirectContext3D.VertexFormat)`

#### Summary

Tests whether the effect instance is appropriate for the given vertex format.

#### Remarks

The vertex format may define vertex data that are not used by the effect instance. However, the effect
instance can not reference vertex data that do not exist in the vertex format.

#### Parameter `vertexFormat`

A vertex format.

#### Returns

True if the effect instance is valid for use with the specified vertex format.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.EffectInstance.IsValid`

#### Summary

Tests whether the effect instance is valid for rendering.

#### Remarks

The effect instances are internally associated with low-level graphics state and may become invalidated when
the state changes. Therefore, an application should test each effect instance for validity before using it when
submitting geometry. If the effect instance becomes invalid, the application should re-create it.

#### Returns

True if the effect instance is valid for rendering, false otherwise.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.EffectInstance.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.EffectInstance.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.#ctor(Autodesk.Revit.DB.DirectContext3D.VertexFormatBits)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.EffectInstance.#ctor(Autodesk.Revit.DB.DirectContext3D.VertexFormatBits)`

#### Summary

Constructs the effect instance for geometry having the specified vertex format.

#### Parameter `vertexFormatBits`

The vertex format of the geometry to be used with this effect instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This EffectInstance is not available because Revit is not currently rendering. In general, this EffectInstance must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.EffectInstance`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.EffectInstance`

#### Summary

An effect instance that controls the appearance of geometry.

#### Remarks

Each effect instance should be used with geometry of a matching vertex format. Only a subset of effect instance
parameters is relevant to geometry of a particular vertex format.
If the vertex format does not specify vertex color
( `T:Autodesk.Revit.DB.DirectContext3D.VertexPosition` or `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal` )
the following parameters should be set:
`M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetColor(Autodesk.Revit.DB.Color)`

`M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetTransparency(System.Double)`
If the vertex format specifies vertex normals
( `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal` or `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored` )
the following parameters should be set:
`M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetAmbientColor(Autodesk.Revit.DB.Color)`

`M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetDiffuseColor(Autodesk.Revit.DB.Color)`

`M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetSpecularColor(Autodesk.Revit.DB.Color)`

`M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetAmbientColor(Autodesk.Revit.DB.Color)`

`M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetEmissiveColor(Autodesk.Revit.DB.Color)`

`M:Autodesk.Revit.DB.DirectContext3D.EffectInstance.SetTransparency(System.Double)`
If the vertex format specifies a color, then the geometry will be colored according to the color of each
vertex. Otherwise, the geometry's color will come from the effect instance parameters. Similarly, the transparency parameter
affects all of the geometry associated with the effect, while the transparency of the individual vertices can also
be controlled via the transparency component of their colors.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.VertexFormatBits`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexFormatBits`

#### Summary

Vertex format (i.e., the type of data associated with a vertex) represented as a number.

#### Remarks

VertexFormatBits can be used to specify the vertex format in the creation of the following objects:
`T:Autodesk.Revit.DB.DirectContext3D.EffectInstance`

`T:Autodesk.Revit.DB.DirectContext3D.VertexFormat`
VertexFormatBits is not to be confused with VertexFormat. The latter type of object is associated with low-level graphics
functionality and may become invalid. VertexFormat is needed to submit a set of vertex and index buffers for rendering (see
`T:Autodesk.Revit.DB.DirectContext3D.DrawContext` ).

#### Since

2017

### `F:Autodesk.Revit.DB.DirectContext3D.VertexFormatBits.PositionNormalColored`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexFormatBits.PositionNormalColored`

#### Summary

Vertex format consisting of a position, a normal vector, and a color.

### `F:Autodesk.Revit.DB.DirectContext3D.VertexFormatBits.PositionColored`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexFormatBits.PositionColored`

#### Summary

Vertex format consisting of a position and a color.

### `F:Autodesk.Revit.DB.DirectContext3D.VertexFormatBits.PositionNormal`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexFormatBits.PositionNormal`

#### Summary

Vertex format consisting of a position and a normal vector.

### `F:Autodesk.Revit.DB.DirectContext3D.VertexFormatBits.Position`

Member kind: field
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexFormatBits.Position`

#### Summary

Vertex format consisting of a position.

### `M:Autodesk.Revit.DB.DirectContext3D.IndexBuffer.GetMappedHandle`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexBuffer.GetMappedHandle`

#### Summary

Gets a handle to the buffer's memory that has been mapped. Writing data to the buffer using the handle is an alternative to using stream objects.

#### Returns

The handle to the mapped memory or nullptr when the buffer is not mapped.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexBuffer.GetIndexStreamTriangle`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexBuffer.GetIndexStreamTriangle`

#### Summary

Gets a stream that can be used to write `T:Autodesk.Revit.DB.DirectContext3D.IndexTriangle` primitives into the buffer.

#### Returns

The stream that can be used to write into this buffer.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the buffer is not mapped.
-or-
Thrown if the buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexBuffer.GetIndexStreamLine`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexBuffer.GetIndexStreamLine`

#### Summary

Gets a stream that can be used to write `T:Autodesk.Revit.DB.DirectContext3D.IndexLine` segment primitives into the buffer.

#### Returns

The stream that can be used to write into this buffer.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the buffer is not mapped.
-or-
Thrown if the buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexBuffer.GetIndexStreamPoint`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexBuffer.GetIndexStreamPoint`

#### Summary

Gets a stream that can be used to write `T:Autodesk.Revit.DB.DirectContext3D.IndexPoint` primitives into the buffer.

#### Returns

The stream that can be used to write into this buffer.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the buffer is not mapped.
-or-
Thrown if the buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexBuffer.Unmap`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexBuffer.Unmap`

#### Summary

Unmaps the buffer so that it can be used for rendering.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This IndexBuffer is not available because Revit is not currently rendering. In general, this IndexBuffer must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexBuffer.Map(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexBuffer.Map(System.Int32)`

#### Summary

Maps a portion of the index buffer into memory, so that indices can be written into it.
see `T:Autodesk.Revit.DB.DirectContext3D.IndexStream` .

#### Parameter `sizeInShortInts`

The size of the part of the buffer to be mapped, measured in short integers.
Must be less than or equal to the size of the `T:Autodesk.Revit.DB.DirectContext3D.IndexBuffer`

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This IndexBuffer is not available because Revit is not currently rendering. In general, this IndexBuffer must be used in the scope of the RenderScene() callback of IDirectContext3DServer.
-or-
Thrown if the buffer is smaller than sizeInShortInts.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexBuffer.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexBuffer.IsValid`

#### Summary

Tests whether the buffer is valid for rendering.

#### Remarks

The buffers are internally associated with low-level graphics state and may become invalidated when
the state changes. Therefore, an application should test each buffer for validity before submitting its
contents for rendering. If the buffer becomes invalid, the application should re-create its contents and
write them to a new buffer.

#### Returns

True if the buffer is valid for rendering, false otherwise.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.IndexBuffer.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexBuffer.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.DirectContext3D.IndexBuffer.#ctor(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexBuffer.#ctor(System.Int32)`

#### Summary

Constructs the index buffer with the given capacity, measured in short integers.

#### Parameter `sizeInShortInts`

The number of short integers that the buffer can contain.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This IndexBuffer is not available because Revit is not currently rendering. In general, this IndexBuffer must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.IndexBuffer`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexBuffer`

#### Summary

A buffer that stores vertex indices for rendering.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexStreamTriangle.AddTriangles(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.IndexTriangle})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexStreamTriangle.AddTriangles(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.IndexTriangle})`

#### Summary

Inserts multiple `T:Autodesk.Revit.DB.DirectContext3D.IndexTriangle` instances into the stream and associated buffer.

#### Parameter `triangles`

The triangles to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexStreamTriangle.AddTriangle(Autodesk.Revit.DB.DirectContext3D.IndexTriangle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexStreamTriangle.AddTriangle(Autodesk.Revit.DB.DirectContext3D.IndexTriangle)`

#### Summary

Inserts a `T:Autodesk.Revit.DB.DirectContext3D.IndexTriangle` into the stream and associated buffer.

#### Parameter `triangle`

The triangle to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.IndexStreamTriangle`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexStreamTriangle`

#### Summary

A stream that can be used to write `T:Autodesk.Revit.DB.DirectContext3D.IndexTriangle`
primitives into an `T:Autodesk.Revit.DB.DirectContext3D.IndexBuffer`

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexStreamLine.AddLines(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.IndexLine})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexStreamLine.AddLines(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.IndexLine})`

#### Summary

Inserts multiple `T:Autodesk.Revit.DB.DirectContext3D.IndexLine` segments into the stream and associated buffer.

#### Parameter `lines`

The line segments to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexStreamLine.AddLine(Autodesk.Revit.DB.DirectContext3D.IndexLine)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexStreamLine.AddLine(Autodesk.Revit.DB.DirectContext3D.IndexLine)`

#### Summary

Inserts a `T:Autodesk.Revit.DB.DirectContext3D.IndexLine` segment into the stream and associated buffer.

#### Parameter `line`

The line segment to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.IndexStreamLine`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexStreamLine`

#### Summary

A stream that can be used to write `T:Autodesk.Revit.DB.DirectContext3D.IndexLine`
primitives into an `T:Autodesk.Revit.DB.DirectContext3D.IndexBuffer`

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexStreamPoint.AddPoints(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.IndexPoint})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexStreamPoint.AddPoints(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.IndexPoint})`

#### Summary

Inserts multiple `T:Autodesk.Revit.DB.DirectContext3D.IndexPoint` instances into the stream and associated buffer.

#### Parameter `points`

The points to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexStreamPoint.AddPoint(Autodesk.Revit.DB.DirectContext3D.IndexPoint)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexStreamPoint.AddPoint(Autodesk.Revit.DB.DirectContext3D.IndexPoint)`

#### Summary

Inserts a `T:Autodesk.Revit.DB.DirectContext3D.IndexPoint` into the stream and associated buffer.

#### Parameter `point`

The point to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.IndexStreamPoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexStreamPoint`

#### Summary

A stream that can be used to write `T:Autodesk.Revit.DB.DirectContext3D.IndexPoint`
primitives into an `T:Autodesk.Revit.DB.DirectContext3D.IndexBuffer`

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.IndexStream.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexStream.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.DirectContext3D.IndexStream`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexStream`

#### Summary

The base class for DirectContext3D index streams, which are used to write vertex indices into buffers.

#### Remarks

This base class cannot be used directly. Instead, a steam that is specific for each type of
primitive (point, line, or triangle) must be used.
Use `T:Autodesk.Revit.DB.DirectContext3D.IndexStreamPoint` to insert `T:Autodesk.Revit.DB.DirectContext3D.IndexPoint` instances.

Use `T:Autodesk.Revit.DB.DirectContext3D.IndexStreamLine` to insert `T:Autodesk.Revit.DB.DirectContext3D.IndexLine` instances.

Use `T:Autodesk.Revit.DB.DirectContext3D.IndexStreamTriangle` to insert `T:Autodesk.Revit.DB.DirectContext3D.IndexTriangle` instances.

The process of putting vertex indices into a buffer involves using a stream-buffer pair as follows:
Map the index buffer (see `T:Autodesk.Revit.DB.DirectContext3D.IndexBuffer` ).

Get a stream for the appropriate primitive type from the buffer.

Add sequences of indices corresponding to primitives of the same type to the stream. The indices will be written into the buffer that was used to create the stream.

Unmap the buffer.
As an alternative to using streams, it is possible to write data into a buffer using a handle to its mapped memory.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexTriangle.GetSizeInShortInts`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexTriangle.GetSizeInShortInts`

#### Summary

Gets the amount of storage that the primitive takes up in a buffer, measured in short integers.

#### Returns

The number of short integers occupied by the primitive.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.IndexTriangle.Index2`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexTriangle.Index2`

#### Summary

The index of the triangle's third vertex.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.IndexTriangle.Index1`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexTriangle.Index1`

#### Summary

The index of the triangle's second vertex.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.IndexTriangle.Index0`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexTriangle.Index0`

#### Summary

The index of the triangle's first vertex.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexTriangle.#ctor(System.Int32,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexTriangle.#ctor(System.Int32,System.Int32,System.Int32)`

#### Summary

Constructs the triangle primitive.

#### Parameter `index0`

The index of the triangle's first vertex.

#### Parameter `index1`

The index of the triangle's second vertex.

#### Parameter `index2`

The index of the triangle's third vertex.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.IndexTriangle`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexTriangle`

#### Summary

A triangle primitive consisting of three indices.

#### Remarks

Indices of a triangle's vertices can be listed in either the clockwise or counterclockwise winding order,
according to the triangle's orientation in space. A DirectContext3D triangle faces the viewer if its vertices
are in counterclockwise order from the viewer's point of view.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexLine.GetSizeInShortInts`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexLine.GetSizeInShortInts`

#### Summary

Gets the amount of storage that the primitive takes up in a buffer, measured in short integers.

#### Returns

The number of short integers occupied by the primitive.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.IndexLine.Index1`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexLine.Index1`

#### Summary

The index of the line segment's second vertex.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.IndexLine.Index0`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexLine.Index0`

#### Summary

The index of the line segment's first vertex.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexLine.#ctor(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexLine.#ctor(System.Int32,System.Int32)`

#### Summary

Constructs the line segment primitive.

#### Parameter `index0`

The index of the line segment's first vertex.

#### Parameter `index1`

The index of the line segment's second vertex.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.IndexLine`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexLine`

#### Summary

A line segment primitive consisting of two indices.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexPoint.GetSizeInShortInts`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexPoint.GetSizeInShortInts`

#### Summary

Gets the amount of storage that the primitive takes up in a buffer, measured in short integers.

#### Returns

The number of short integers occupied by the primitive.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.IndexPoint.Index`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexPoint.Index`

#### Summary

The index of the point's vertex.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.IndexPoint.#ctor(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexPoint.#ctor(System.Int32)`

#### Summary

Constructs the point primitive.

#### Parameter `index`

The index of the point's vertex.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.IndexPoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexPoint`

#### Summary

A point primitive consisting of one index.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.IndexPrimitive.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexPrimitive.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.DirectContext3D.IndexPrimitive`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.IndexPrimitive`

#### Summary

The base class for index buffer primitives.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexBuffer.GetMappedHandle`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexBuffer.GetMappedHandle`

#### Summary

Gets a handle to the buffer's memory that has been mapped. Writing data to the buffer using the handle is an alternative to using stream objects.

#### Returns

The handle to the mapped memory or nullptr when the buffer is not mapped.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexBuffer.GetVertexStreamPositionNormalColored`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexBuffer.GetVertexStreamPositionNormalColored`

#### Summary

Gets a stream that can be used to write vertices of type `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored` into the buffer.

#### Returns

The stream that can be used to write into this buffer.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the buffer is not mapped.
-or-
Thrown if the buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexBuffer.GetVertexStreamPositionColored`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexBuffer.GetVertexStreamPositionColored`

#### Summary

Gets a stream that can be used to write vertices of type `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionColored` into the buffer.

#### Returns

The stream that can be used to write into this buffer.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the buffer is not mapped.
-or-
Thrown if the buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexBuffer.GetVertexStreamPositionNormal`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexBuffer.GetVertexStreamPositionNormal`

#### Summary

Gets a stream that can be used to write vertices of type `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal` into the buffer.

#### Returns

The stream that can be used to write into this buffer.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the buffer is not mapped.
-or-
Thrown if the buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexBuffer.GetVertexStreamPosition`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexBuffer.GetVertexStreamPosition`

#### Summary

Gets a stream that can be used to write vertices of type `T:Autodesk.Revit.DB.DirectContext3D.VertexPosition` into the buffer.

#### Returns

The stream that can be used to write into this buffer.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the buffer is not mapped.
-or-
Thrown if the buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexBuffer.Unmap`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexBuffer.Unmap`

#### Summary

Unmaps the buffer, so that it can be used for rendering.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This VertexBuffer is not available because Revit is not currently rendering. In general, this VertexBuffer must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexBuffer.Map(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexBuffer.Map(System.Int32)`

#### Summary

Maps a portion of the buffer into memory, so that vertex data can be written into it.
(see `T:Autodesk.Revit.DB.DirectContext3D.VertexStream` ).

#### Parameter `sizeInFloats`

The size of the part of the buffer to be mapped, measured in floats.
Must be less than or equal to the size of the `T:Autodesk.Revit.DB.DirectContext3D.VertexBuffer`

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This VertexBuffer is not available because Revit is not currently rendering. In general, this VertexBuffer must be used in the scope of the RenderScene() callback of IDirectContext3DServer.
-or-
Thrown if the buffer is smaller than sizeInFloats.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexBuffer.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexBuffer.IsValid`

#### Summary

Tests whether the buffer is valid for rendering.

#### Remarks

The buffers are internally associated with low-level graphics state and may become invalidated when
the state changes. Therefore, an application should test each buffer for validity before submitting its
contents for rendering. If the buffer becomes invalid, the application should re-create its contents and
write them to a new buffer.

#### Returns

True if the buffer is valid for rendering, false otherwise.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.VertexBuffer.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexBuffer.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.DirectContext3D.VertexBuffer.#ctor(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexBuffer.#ctor(System.Int32)`

#### Summary

Constructs the vertex buffer with the given capacity, measured in floats.

#### Parameter `sizeInFloats`

The number of floats that the buffer can contain.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This VertexBuffer is not available because Revit is not currently rendering. In general, this VertexBuffer must be used in the scope of the RenderScene() callback of IDirectContext3DServer.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.VertexBuffer`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexBuffer`

#### Summary

A buffer that stores vertex data for rendering.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormalColored.AddVertices(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormalColored.AddVertices(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored})`

#### Summary

Inserts multiple `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormalColored` instances into the stream and associated buffer.

#### Parameter `vertices`

The vertices to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormalColored.AddVertex(Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormalColored.AddVertex(Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored)`

#### Summary

Inserts a `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormalColored` into the stream and associated buffer.

#### Parameter `vertex`

The vertex to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormalColored`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormalColored`

#### Summary

A stream that can be used to write vertices of type `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored`
into a buffer (see `T:Autodesk.Revit.DB.DirectContext3D.VertexBuffer` ).

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionColored.AddVertices(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.VertexPositionColored})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionColored.AddVertices(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.VertexPositionColored})`

#### Summary

Inserts multiple `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionColored` instances into the stream and associated buffer.

#### Parameter `vertices`

The vertices to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionColored.AddVertex(Autodesk.Revit.DB.DirectContext3D.VertexPositionColored)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionColored.AddVertex(Autodesk.Revit.DB.DirectContext3D.VertexPositionColored)`

#### Summary

Inserts a `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionColored` into the stream and associated buffer.

#### Parameter `vertex`

The vertex to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionColored`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionColored`

#### Summary

A stream that can be used to write vertices of type `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionColored`
into a buffer (see `T:Autodesk.Revit.DB.DirectContext3D.VertexBuffer` ).

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormal.AddVertices(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormal.AddVertices(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal})`

#### Summary

Inserts multiple `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormal` instances into the stream and associated buffer.

#### Parameter `vertices`

The vertices to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormal.AddVertex(Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormal.AddVertex(Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal)`

#### Summary

Inserts a `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormal` into the stream and associated buffer.

#### Parameter `vertex`

The vertex to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormal`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormal`

#### Summary

A stream that can be used to write vertices of type `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal`
into a buffer (see `T:Autodesk.Revit.DB.DirectContext3D.VertexBuffer` ).

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexStreamPosition.AddVertices(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.VertexPosition})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStreamPosition.AddVertices(System.Collections.Generic.IList{Autodesk.Revit.DB.DirectContext3D.VertexPosition})`

#### Summary

Inserts multiple `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPosition` instances into the stream and associated buffer.

#### Parameter `vertices`

The vertices to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexStreamPosition.AddVertex(Autodesk.Revit.DB.DirectContext3D.VertexPosition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStreamPosition.AddVertex(Autodesk.Revit.DB.DirectContext3D.VertexPosition)`

#### Summary

Inserts a `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPosition` into the stream and associated buffer.

#### Parameter `vertex`

The vertex to be inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the associated buffer is not mapped.
-or-
Thrown if the associated buffer has insufficient space.

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPosition`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStreamPosition`

#### Summary

A stream that can be used to write vertices of type `T:Autodesk.Revit.DB.DirectContext3D.VertexPosition`
into a buffer (see `T:Autodesk.Revit.DB.DirectContext3D.VertexBuffer` ).

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.VertexStream.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStream.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.DirectContext3D.VertexStream`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexStream`

#### Summary

The base class for DirectContext3D vertex streams, which are used to write vertex data into buffers.

#### Remarks

This base class cannot be used directly. Instead, a steam that is specific for each type of
vertex must be used.
Use `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPosition` to insert `T:Autodesk.Revit.DB.DirectContext3D.VertexPosition` instances.

Use `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionColored` to insert `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionColored` instances.

Use `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormal` to insert `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal` instances.

Use `T:Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormalColored` to insert `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored` instances.
The process of putting vertex data into a buffer involves using a stream-buffer pair as follows:
Map the vertex buffer.

Get a stream of the appropriate type from the buffer.

Add vertices of the same type to the stream. They will be written into the buffer that was used to create the stream.

Unmap the buffer.
As an alternative to using streams, it is possible to write data into a buffer using a handle to its mapped memory.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored.GetSizeInFloats`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored.GetSizeInFloats`

#### Summary

Gets the amount of storage that the vertex takes up in a buffer, measured in floats.

#### Returns

The number of floats occupied by one vertex of this type.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored.SetColor(Autodesk.Revit.DB.ColorWithTransparency)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored.SetColor(Autodesk.Revit.DB.ColorWithTransparency)`

#### Summary

Sets the vertex's color.

#### Parameter `color`

The vertex's color.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored.GetColor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored.GetColor`

#### Summary

Gets the vertex's color.

#### Returns

The vertex's color.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored.Normal`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored.Normal`

#### Summary

The vertex's normal vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored.Position`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored.Position`

#### Summary

The vertex's position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ColorWithTransparency)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ColorWithTransparency)`

#### Summary

Constructs the vertex from a point, a normal vector, and a color.

#### Parameter `position`

The vertex's position.

#### Parameter `normal`

The vertex's normal vector.

#### Parameter `color`

The vertex's color.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored`

#### Summary

A geometry vertex specified as a position in space with a normal vector and a color.

#### Remarks

The color of these vertices includes a transparency component
In order to render them as transparent they must be rendered in the transparent pass
See the 'IsTransparentPass' method of `T:Autodesk.Revit.DB.DirectContext3D.DrawContext`

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexPositionColored.GetSizeInFloats`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionColored.GetSizeInFloats`

#### Summary

Gets the amount of storage that the vertex takes up in a buffer, measured in floats.

#### Returns

The number of floats occupied by one vertex of this type.

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexPositionColored.SetColor(Autodesk.Revit.DB.ColorWithTransparency)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionColored.SetColor(Autodesk.Revit.DB.ColorWithTransparency)`

#### Summary

Sets the vertex's color.

#### Parameter `color`

The vertex's color.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexPositionColored.GetColor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionColored.GetColor`

#### Summary

Gets the vertex's color.

#### Returns

The vertex's color.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.VertexPositionColored.Position`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionColored.Position`

#### Summary

The vertex's position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexPositionColored.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ColorWithTransparency)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionColored.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ColorWithTransparency)`

#### Summary

Constructs the vertex from a point and a color.

#### Parameter `position`

The vertex's position.

#### Parameter `color`

The vertex's color.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionColored`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionColored`

#### Summary

A geometry vertex specified as a position in space with a color.

#### Remarks

The color of these vertices includes a transparency component
In order to render them as transparent they must be rendered in the transparent pass
See the 'IsTransparentPass' method of `T:Autodesk.Revit.DB.DirectContext3D.DrawContext`

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal.GetSizeInFloats`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal.GetSizeInFloats`

#### Summary

Gets the amount of storage that the vertex takes up in a buffer, measured in floats.

#### Returns

The number of floats occupied by one vertex of this type.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal.Normal`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal.Normal`

#### Summary

The vertex's normal vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal.Position`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal.Position`

#### Summary

The vertex's position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Constructs the vertex from a point and a normal vector.

#### Parameter `position`

The vertex's position.

#### Parameter `normal`

The vertex's normal vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal`

#### Summary

A geometry vertex specified as a position in space with a normal vector.

#### Remarks

Since these vertices do not have a color
their color is obtained from the `T:Autodesk.Revit.DB.DirectContext3D.EffectInstance`

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexPosition.GetSizeInFloats`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPosition.GetSizeInFloats`

#### Summary

Gets the amount of storage that the vertex takes up in a buffer, measured in floats.

#### Returns

The number of floats occupied by one vertex of this type.

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.VertexPosition.Position`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPosition.Position`

#### Summary

The vertex's position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.DirectContext3D.VertexPosition.#ctor(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPosition.#ctor(Autodesk.Revit.DB.XYZ)`

#### Summary

Constructs the vertex from a point.

#### Parameter `position`

The vertex's position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.DirectContext3D.VertexPosition`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.VertexPosition`

#### Summary

A geometry vertex specified as a position in space.

#### Remarks

Since these vertices do not have a color
their color is obtained from the `T:Autodesk.Revit.DB.DirectContext3D.EffectInstance`

#### Since

2017

### `P:Autodesk.Revit.DB.DirectContext3D.Vertex.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DirectContext3D.Vertex.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.DirectContext3D.Vertex`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.Vertex`

#### Summary

The base class for DirectContext3D vertices.

#### Since

2017

### `T:Autodesk.Revit.DB.DimensionLeaderArrowType`

Member kind: type
Symbol: `Autodesk.Revit.DB.DimensionLeaderArrowType`

#### Summary

An enumerated type containing possible arrow types for dimension leader

#### Since

2021.1

#### Since

2021.1

### `F:Autodesk.Revit.DB.DimensionLeaderArrowType.FilledArrow25Deg`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionLeaderArrowType.FilledArrow25Deg`

#### Summary

Outdated, converted to Arrow in upgrade function

### `F:Autodesk.Revit.DB.DimensionLeaderArrowType.Arrow25Deg`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionLeaderArrowType.Arrow25Deg`

#### Summary

Outdated, converted to Arrow in upgrade function

### `F:Autodesk.Revit.DB.DimensionLeaderArrowType.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionLeaderArrowType.None`

#### Summary

Outdated -- things that used it now use a LeaderStyle choice None

### `F:Autodesk.Revit.DB.DimensionLeaderArrowType.WideArrow`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionLeaderArrowType.WideArrow`

#### Summary

Outdated, converted to Arrow in upgrade function

### `F:Autodesk.Revit.DB.DimensionLeaderArrowType.NarrowArrow`

Member kind: field
Symbol: `Autodesk.Revit.DB.DimensionLeaderArrowType.NarrowArrow`

#### Summary

Outdated, converted to Arrow in upgrade function

### `P:Autodesk.Revit.DB.OrdinateDimensionSetting.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.OrdinateDimensionSetting.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.OrdinateDimensionSetting.OriginVisibility`

Member kind: property
Symbol: `Autodesk.Revit.DB.OrdinateDimensionSetting.OriginVisibility`

#### Summary

Specifies thevisibility of the origin witness line for the ordinate dimension (this is the first witness line in the string).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.OrdinateDimensionSetting.TextPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.OrdinateDimensionSetting.TextPosition`

#### Summary

Specifies the dimension text position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.OrdinateDimensionSetting.TextOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.OrdinateDimensionSetting.TextOrientation`

#### Summary

Specifies where to align the dimension text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.OrdinateDimensionSetting.DimensionLineStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.OrdinateDimensionSetting.DimensionLineStyle`

#### Summary

Specifies the dimension line style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.OrdinateDimensionSetting.OriginTickMarkId`

Member kind: property
Symbol: `Autodesk.Revit.DB.OrdinateDimensionSetting.OriginTickMarkId`

#### Summary

Specifies the id of the tick mark element to use for the dimension origin.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.OrdinateDimensionSetting.DimensionLineLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.OrdinateDimensionSetting.DimensionLineLength`

#### Summary

Specifies the dimension line segment length. This setting is enabled when Dimension Line Style is Segmented.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for dimensionLineLength must be greater than 0 and no more than 30000 feet.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.OrdinateDimensionSetting.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.OrdinateDimensionSetting.#ctor`

#### Summary

Constructs a new OrdinateDimensionSetting object with default settings.

#### Since

2017 Subscription Update

### `T:Autodesk.Revit.DB.OrdinateDimensionSetting`

Member kind: type
Symbol: `Autodesk.Revit.DB.OrdinateDimensionSetting`

#### Summary

Represents a collection of Ordinate Dimension settings that can be associated to an ordinate DimensionType.

#### Since

2017 Subscription Update

### `T:Autodesk.Revit.DB.OrdinateOriginVisibility`

Member kind: type
Symbol: `Autodesk.Revit.DB.OrdinateOriginVisibility`

#### Summary

The ordinate origin visibility.

#### Since

2017 Subscription Update

#### Since

2017 Subscription Update

### `F:Autodesk.Revit.DB.OrdinateOriginVisibility.WitnessLineOnly`

Member kind: field
Symbol: `Autodesk.Revit.DB.OrdinateOriginVisibility.WitnessLineOnly`

#### Summary

Shows the origin witness line and tick mark.

### `F:Autodesk.Revit.DB.OrdinateOriginVisibility.WitnessLineWithText`

Member kind: field
Symbol: `Autodesk.Revit.DB.OrdinateOriginVisibility.WitnessLineWithText`

#### Summary

Shows the origin witness line, tick mark and text (0'-0").

### `F:Autodesk.Revit.DB.OrdinateOriginVisibility.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.OrdinateOriginVisibility.None`

#### Summary

Does not show the origin witness line, tick mark, or text (0'-0").

### `T:Autodesk.Revit.DB.OrdinateTextPosition`

Member kind: type
Symbol: `Autodesk.Revit.DB.OrdinateTextPosition`

#### Summary

The ordinate dimension text position.

#### Since

2017 Subscription Update

#### Since

2017 Subscription Update

### `F:Autodesk.Revit.DB.OrdinateTextPosition.NextToWitnessLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.OrdinateTextPosition.NextToWitnessLine`

#### Summary

The dimension text position will be next to witness line.

### `F:Autodesk.Revit.DB.OrdinateTextPosition.EndOfWitnessLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.OrdinateTextPosition.EndOfWitnessLine`

#### Summary

The dimension text position will be at the end of witness line.

### `T:Autodesk.Revit.DB.OrdinateTextOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.OrdinateTextOrientation`

#### Summary

The ordinate dimension text orientation.

#### Since

2017 Subscription Update

#### Since

2017 Subscription Update

### `F:Autodesk.Revit.DB.OrdinateTextOrientation.ParallelToWitnessLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.OrdinateTextOrientation.ParallelToWitnessLine`

#### Summary

The dimension text orientation will be parallel to witness line.

### `F:Autodesk.Revit.DB.OrdinateTextOrientation.ParallelToDimensionLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.OrdinateTextOrientation.ParallelToDimensionLine`

#### Summary

The dimension text orientation will be parallel to dimension line.

### `T:Autodesk.Revit.DB.OrdinateDimensionLineStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.OrdinateDimensionLineStyle`

#### Summary

The ordinate dimension line style.

#### Since

2017 Subscription Update

#### Since

2017 Subscription Update

### `F:Autodesk.Revit.DB.OrdinateDimensionLineStyle.Segmented`

Member kind: field
Symbol: `Autodesk.Revit.DB.OrdinateDimensionLineStyle.Segmented`

#### Summary

Segments the dimension line. Specify the length of the segments with the DimensionLineLength property.

### `F:Autodesk.Revit.DB.OrdinateDimensionLineStyle.Continuous`

Member kind: field
Symbol: `Autodesk.Revit.DB.OrdinateDimensionLineStyle.Continuous`

#### Summary

Displays the dimension line as continuous.

### `F:Autodesk.Revit.DB.OrdinateDimensionLineStyle.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.OrdinateDimensionLineStyle.None`

#### Summary

Shows no dimension line. When you select the dimension line in the drawing area, a hidden line displays.

### `M:Autodesk.Revit.DB.DimensionEqualityLabelFormatting.IsValidFormatOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionEqualityLabelFormatting.IsValidFormatOptions`

#### Summary

Checks whether a FormatOptions object is valid for the LabelType.

#### Remarks

Only objects whose LabelType is LengthOfSegment or TotalLength can have FormatOptions assigned.

#### Returns

True if the FormatOptions object is valid, false otherwise.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.DimensionEqualityLabelFormatting.SetFormatOptions(Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionEqualityLabelFormatting.SetFormatOptions(Autodesk.Revit.DB.FormatOptions)`

#### Summary

Sets the format options used to show the parameter value.

#### Parameter `formatOptions`

The format options to be set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This DimensionEqualityLabelFormatting uses a LabelType which does not support assignment of FormatOptions.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.DimensionEqualityLabelFormatting.GetFormatOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionEqualityLabelFormatting.GetFormatOptions`

#### Summary

Gets the format options used to show the parameter value.

#### Returns

A copy of the format options.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.DimensionEqualityLabelFormatting.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionEqualityLabelFormatting.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.DimensionEqualityLabelFormatting.Suffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionEqualityLabelFormatting.Suffix`

#### Summary

The suffix to include after the parameter value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.DimensionEqualityLabelFormatting.Prefix`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionEqualityLabelFormatting.Prefix`

#### Summary

The prefix to include before the parameter value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.DimensionEqualityLabelFormatting.LeadingSpaces`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionEqualityLabelFormatting.LeadingSpaces`

#### Summary

The number of spaces to include before the parameter value.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.DimensionEqualityLabelFormatting.LabelType`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionEqualityLabelFormatting.LabelType`

#### Summary

The parameter value to be shown.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.DimensionEqualityLabelFormatting.#ctor(System.Int32,System.String,Autodesk.Revit.DB.LabelType,System.String,Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionEqualityLabelFormatting.#ctor(System.Int32,System.String,Autodesk.Revit.DB.LabelType,System.String,Autodesk.Revit.DB.FormatOptions)`

#### Summary

Constructs a new instance of a DimensionEqualityLabelFormatting object with specified settings.

#### Parameter `leadingSpaces`

The number of spaces to include before the parameter value.

#### Parameter `prefix`

The prefix to include before the parameter value.

#### Parameter `labelType`

The parameter value to be shown.

#### Parameter `suffix`

The suffix to include after the parameter value.

#### Parameter `formatOptions`

The format options to use for the parameter value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017 Subscription Update

### `T:Autodesk.Revit.DB.DimensionEqualityLabelFormatting`

Member kind: type
Symbol: `Autodesk.Revit.DB.DimensionEqualityLabelFormatting`

#### Summary

Instances of this class represent individual parameters used to make up a dimension equality formula for continuous linear or angular dimensions.

#### Since

2017 Subscription Update

### `T:Autodesk.Revit.DB.LabelType`

Member kind: type
Symbol: `Autodesk.Revit.DB.LabelType`

#### Summary

The label type in dimension equality formats.

#### Since

2017 Subscription Update

#### Since

2017 Subscription Update

### `F:Autodesk.Revit.DB.LabelType.TotalLength`

Member kind: field
Symbol: `Autodesk.Revit.DB.LabelType.TotalLength`

#### Summary

The total length of the dimension.

### `F:Autodesk.Revit.DB.LabelType.LengthOfSegment`

Member kind: field
Symbol: `Autodesk.Revit.DB.LabelType.LengthOfSegment`

#### Summary

The length of segments of the dimension.

### `F:Autodesk.Revit.DB.LabelType.NumberOfSegments`

Member kind: field
Symbol: `Autodesk.Revit.DB.LabelType.NumberOfSegments`

#### Summary

The number of segments of the dimension.

### `F:Autodesk.Revit.DB.LabelType.NumberOfWitnessLines`

Member kind: field
Symbol: `Autodesk.Revit.DB.LabelType.NumberOfWitnessLines`

#### Summary

The number of witness lines of the dimension.

### `M:Autodesk.Revit.DB.ArcLengthDimensionGeometryOptions.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DimensionType,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.Line)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ArcLengthDimensionGeometryOptions.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DimensionType,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.Line)`

#### Summary

Creates an instance of `T:Autodesk.Revit.DB.ArcLengthDimensionGeometryOptions` with the specified parameters.

#### Parameter `view`

The view whose properties will be used to compute the dimension geometry.

#### Parameter `dimensionType`

The `T:Autodesk.Revit.DB.DimensionType` of the dimension.

#### Parameter `extensionArc`

The extension arc of the dimension.

#### Parameter `arcRef`

The arc to which the dimension is to be bound. This arc must be parallel to the extension arc.

#### Parameter `firstLine`

The first reference line to which the dimension is to be bound. This reference must intersect the arcRef reference.

#### Parameter `secondLine`

The second reference line to which the dimension is to be bound. This reference must intersect the arcRef reference.

#### Returns

Returns an instance of `T:Autodesk.Revit.DB.ArcLengthDimensionGeometryOptions` with the specified parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.ArcLengthDimensionGeometryOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ArcLengthDimensionGeometryOptions`

#### Summary

A class that encapsulates the options needed to create the Arc Length Dimension geometry.

### `M:Autodesk.Revit.DB.DiameterDimensionGeometryOptions.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DimensionType,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DiameterDimensionGeometryOptions.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DimensionType,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates an instance of `T:Autodesk.Revit.DB.DiameterDimensionGeometryOptions` with the specified parameters.

#### Parameter `view`

The view whose properties will be used to compute the dimension geometry.

#### Parameter `dimensionType`

The `T:Autodesk.Revit.DB.DimensionType` of the dimension.

#### Parameter `arc`

The arc to which the dimension is to be bound.

#### Parameter `origin`

The point where the witness line of the radial dimension will lie.

#### Returns

Returns an instance of `T:Autodesk.Revit.DB.DiameterDimensionGeometryOptions` with the specified parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input point lies outside of Revit design limits.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.DiameterDimensionGeometryOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DiameterDimensionGeometryOptions`

#### Summary

A class that encapsulates the options needed to create the Diameter Dimension geometry.

### `M:Autodesk.Revit.DB.RadialDimensionGeometryOptions.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DimensionType,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RadialDimensionGeometryOptions.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DimensionType,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates an instance of `T:Autodesk.Revit.DB.RadialDimensionGeometryOptions` with the specified parameters.

#### Parameter `view`

The view whose properties will be used to compute the dimension geometry.

#### Parameter `dimensionType`

The `T:Autodesk.Revit.DB.DimensionType` of the dimension.

#### Parameter `arc`

The arc to which the dimension is to be bound.

#### Parameter `origin`

The point where the witness line of the radial dimension will lie.

#### Returns

Returns an instance of `T:Autodesk.Revit.DB.RadialDimensionGeometryOptions` with the specified parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.RadialDimensionGeometryOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.RadialDimensionGeometryOptions`

#### Summary

A class that encapsulates the options needed to create the Radial Dimension geometry.

### `M:Autodesk.Revit.DB.AngularDimensionGeometryOptions.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DimensionType,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.Line)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AngularDimensionGeometryOptions.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DimensionType,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.Line)`

#### Summary

Creates an instance of `T:Autodesk.Revit.DB.AngularDimensionGeometryOptions` with the specified parameters.

#### Parameter `view`

The view whose properties will be used to compute the dimension geometry.

#### Parameter `dimensionType`

The `T:Autodesk.Revit.DB.DimensionType` of the dimension.

#### Parameter `arc`

The extension arc of the dimension.

#### Parameter `firstLine`

The first reference line to which the dimension is to be bound.

#### Parameter `secondLine`

The second reference line to which the dimension is to be bound. The line must not be parallel with the first reference line.

#### Returns

Returns an instance of `T:Autodesk.Revit.DB.AngularDimensionGeometryOptions` with the specified parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The provided reference lines are parallel.

### `T:Autodesk.Revit.DB.AngularDimensionGeometryOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.AngularDimensionGeometryOptions`

#### Summary

A class that encapsulates the options needed to create the Angular Dimension geometry.

### `M:Autodesk.Revit.DB.LinearDimensionGeometryOptions.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DimensionType,System.Collections.Generic.IList{Autodesk.Revit.DB.Line},Autodesk.Revit.DB.Line)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinearDimensionGeometryOptions.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DimensionType,System.Collections.Generic.IList{Autodesk.Revit.DB.Line},Autodesk.Revit.DB.Line)`

#### Summary

Creates an instance of `T:Autodesk.Revit.DB.LinearDimensionGeometryOptions` with the specified parameters.

#### Parameter `view`

The view whose properties will be used to compute the dimension geometry.

#### Parameter `dimensionType`

The `T:Autodesk.Revit.DB.DimensionType` of the dimension.

#### Parameter `dimensionReferences`

An array of reference lines to which the dimension is to be bound. You must supply at least two lines, and all lines supplied must be parallel to each other and perpendicular to the extension line.

#### Parameter `extensionLine`

The extension line of the dimension.

#### Returns

Returns an instance of `T:Autodesk.Revit.DB.LinearDimensionGeometryOptions` with the specified parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Invalid number of references.
-or-
The provided reference lines are not parallel.
-or-
The provided reference lines are not perpendicullar to the extension line.

### `T:Autodesk.Revit.DB.LinearDimensionGeometryOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinearDimensionGeometryOptions`

#### Summary

A class that encapsulates the options needed to create the Linear Dimension geometry.

### `M:Autodesk.Revit.DB.DimensionGeometryOptions.ClearTextOverrideForSegment(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionGeometryOptions.ClearTextOverrideForSegment(System.Int32)`

#### Summary

Removes any text override for the specified DimensionSegment.

#### Parameter `segmentIndex`

The DimensionSegment index.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Index out of range.

### `M:Autodesk.Revit.DB.DimensionGeometryOptions.SetTextOverrideForSegment(System.String,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionGeometryOptions.SetTextOverrideForSegment(System.String,System.Int32)`

#### Summary

The text which will override the computed value from the Dimension, for the indicated DimensionSegment.

#### Parameter `text`

The override text.

#### Parameter `segmentIndex`

The DimensionSegment index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Index out of range.

### `M:Autodesk.Revit.DB.DimensionGeometryOptions.SetView(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionGeometryOptions.SetView(Autodesk.Revit.DB.View)`

#### Summary

Fills in the view in which the dimension is drawn.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.DimensionGeometryOptions.SetDimensionStyle(Autodesk.Revit.DB.DimensionType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionGeometryOptions.SetDimensionStyle(Autodesk.Revit.DB.DimensionType)`

#### Summary

Fills in the dimension style.

### `P:Autodesk.Revit.DB.DimensionGeometryOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionGeometryOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.DimensionGeometryOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DimensionGeometryOptions`

#### Summary

The base class that encapsulates common options needed to create various Dimension geometry.

### `M:Autodesk.Revit.DB.DetailElementOrderUtils.AreDetailElements(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailElementOrderUtils.AreDetailElements(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Indicates if the elements are all detail elements that participate in detail draw ordering in the view.

#### Parameter `document`

The document.

#### Parameter `view`

The view in which the details appear.

#### Parameter `detailElementIds`

The details to check.

#### Returns

True if the detail elements are orderable in the view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.DetailElementOrderUtils.IsDetailElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailElementOrderUtils.IsDetailElement(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

#### Summary

Indicates if the element is a detail element that participates in detail draw ordering in the view.

#### Parameter `document`

The document.

#### Parameter `view`

The view in which the detail appears.

#### Parameter `detailElementId`

The detail element.

#### Returns

True if the detail element is orderable in the view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.DetailElementOrderUtils.GetDrawOrderForDetails(Autodesk.Revit.DB.View,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailElementOrderUtils.GetDrawOrderForDetails(Autodesk.Revit.DB.View,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Returns the given detail elements according to the currently specified draw order for the detail elements in a given view.

#### Remarks

The sort order is from back to front, with earlier elements drawing first and appearing under later elements.

#### Parameter `view`

The view in which the details appear.

#### Parameter `detailIdsToSort`

The detail to be sorted by draw order.

#### Returns

The detail ids sorted from back to front, with earlier elements drawing first and appearing under later elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order.
-or-
detailIdsToSort is empty or it contains elements are not visible in the view.
-or-
detailIdsToSort is empty or it contains elements that do not participate in detail draw ordering. Details must be visible in the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.DetailElementOrderUtils.SendBackward(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailElementOrderUtils.SendBackward(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Moves the given detail instances one step closer to the back with relation to all other detail
instances in the view, while keeping the order of the given ones.

#### Parameter `document`

The document.

#### Parameter `view`

The view in which the details appear.

#### Parameter `detailElementIds`

The details to move backward.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order.
-or-
detailElementIds is empty or it contains elements that do not participate in detail draw ordering. Details must be visible in the view.
-or-
In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.DetailElementOrderUtils.SendBackward(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailElementOrderUtils.SendBackward(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

#### Summary

Moves the given detail instance one step closer to the back of all other detail instances in the view.

#### Parameter `document`

The document.

#### Parameter `view`

The view in which the detail appears.

#### Parameter `detailElementId`

The detail to move backward.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order.
-or-
The element detailElementId is not a detail or it does not participate in detail draw ordering. Details must be visible in the view.
-or-
In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.DetailElementOrderUtils.SendToBack(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailElementOrderUtils.SendToBack(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Places the given detail instances behind all other detail instances in the view, while keeping
the order of the given ones.

#### Parameter `document`

The document.

#### Parameter `view`

The view in which the details appear.

#### Parameter `detailElementIds`

The details to send to back.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order.
-or-
detailElementIds is empty or it contains elements that do not participate in detail draw ordering. Details must be visible in the view.
-or-
In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.DetailElementOrderUtils.SendToBack(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailElementOrderUtils.SendToBack(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

#### Summary

Places the given detail instance behind all detail instances in the view.

#### Parameter `document`

The document.

#### Parameter `view`

The view in which the detail appears.

#### Parameter `detailElementId`

The detail to send to back.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order.
-or-
The element detailElementId is not a detail or it does not participate in detail draw ordering. Details must be visible in the view.
-or-
In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.DetailElementOrderUtils.BringForward(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailElementOrderUtils.BringForward(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Moves the given detail instances one step closer to the front of all other detail instances in the view,
while keeping the order of the given ones.

#### Parameter `document`

The document.

#### Parameter `view`

The view in which the details appear.

#### Parameter `detailElementIds`

The details to bring forward.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order.
-or-
detailElementIds is empty or it contains elements that do not participate in detail draw ordering. Details must be visible in the view.
-or-
In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.DetailElementOrderUtils.BringForward(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailElementOrderUtils.BringForward(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

#### Summary

Moves the given detail instance one step closer to the front of all other detail instances in the view.

#### Parameter `document`

The document.

#### Parameter `view`

The view in which the detail appears.

#### Parameter `detailElementId`

The detail to bring forward.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order.
-or-
The element detailElementId is not a detail or it does not participate in detail draw ordering. Details must be visible in the view.
-or-
In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.DetailElementOrderUtils.BringToFront(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailElementOrderUtils.BringToFront(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Places the given detail instances in the front of all other detail instances in the view, while
keeping the order of the given ones.

#### Parameter `document`

The document.

#### Parameter `view`

The view in which the details appear.

#### Parameter `detailElementIds`

The details to bring to front.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order.
-or-
detailElementIds is empty or it contains elements that do not participate in detail draw ordering. Details must be visible in the view.
-or-
In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.DetailElementOrderUtils.BringToFront(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailElementOrderUtils.BringToFront(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId)`

#### Summary

Places the given detail instance in the front of all other detail instances in the view.

#### Parameter `document`

The document.

#### Parameter `view`

The view in which the detail appears.

#### Parameter `detailElementId`

The detail element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order.
-or-
The element detailElementId is not a detail or it does not participate in detail draw ordering. Details must be visible in the view.
-or-
In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.DetailElementOrderUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.DetailElementOrderUtils`

#### Summary

A utility class that arranges the draw order of the detail elements.

#### Since

2013

### `M:Autodesk.Revit.DB.DesktopConnectorVerboseOptions.GetDesktopConnectorVerboseOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.DesktopConnectorVerboseOptions.GetDesktopConnectorVerboseOptions`

#### Summary

Returns the current user's DesktopConnectorVerboseOptions.

#### Returns

The DesktopConnectorVerboseOptions for the current user.

#### Since

2022

### `P:Autodesk.Revit.DB.DesktopConnectorVerboseOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DesktopConnectorVerboseOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.DesktopConnectorVerboseOptions.DesktopConnectorVerboseMode`

Member kind: property
Symbol: `Autodesk.Revit.DB.DesktopConnectorVerboseOptions.DesktopConnectorVerboseMode`

#### Summary

Returns whether the user wants Desktop Connector verbose mode.

#### Since

2022

### `M:Autodesk.Revit.DB.DesktopConnectorVerboseOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DesktopConnectorVerboseOptions.#ctor`

#### Since

2022

### `T:Autodesk.Revit.DB.DesktopConnectorVerboseOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DesktopConnectorVerboseOptions`

#### Summary

A utility class containing the Revit.ini options settings related to Desktop Connector Verbose mode for journal debugging

#### Since

2022

### `M:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetDesignElementAndFabricationPartsWithDifferentOffsets`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetDesignElementAndFabricationPartsWithDifferentOffsets`

#### Summary

Gets the collection of design elements that failed to convert and the associated set of fabrication parts with different offsets.

#### Remarks

This set of element identifiers is only available after the Convert method has been invoked, and returns DesignToFabricationConverterResult::Enum::PartialFailure.

#### Returns

A map of design element identifiers that were not converted and the associated set fabrication parts left with different offsets.

#### Since

2017

### `M:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetDesignElementAndFabricationPartsWithOpenConnectors`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetDesignElementAndFabricationPartsWithOpenConnectors`

#### Summary

Gets the collection of design elements that failed to convert and the associated set of fabrication parts with open connectors.

#### Remarks

This set of element identifiers is only available after the Convert method has been invoked, and returns DesignToFabricationConverterResult::Enum::PartialFailure.

#### Returns

A map of design element identifiers that were not converted and the associated set fabrication parts left with open connectors.

#### Since

2017

### `M:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetConvertedFabricationPartsWithInvalidConnections`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetConvertedFabricationPartsWithInvalidConnections`

#### Summary

Gets the collection of converted fabrication parts with invalid connections.

#### Remarks

This set of element identifiers is only available after the Convert method has been invoked, and returns DesignToFabricationConverterResult::Enum::PartialFailure.

#### Since

2017

### `M:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetElementsWithOpenConnector`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetElementsWithOpenConnector`

#### Summary

Gets the set of fabrication part or MEP design element identifiers with open connectors, caused by fittings failing to convert.

#### Remarks

This set of element identifiers is only available after the Convert method has been invoked, and returns DesignToFabricationConverterResult::Enum::PartialFailure.

#### Since

2017

### `M:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetConvertedFabricationParts`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetConvertedFabricationParts`

#### Summary

Gets the set of element identifiers for newly created fabrication parts.

#### Remarks

This set of element identifiers is only available after the Convert method has been invoked.

#### Since

2017

### `M:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetPartialConvertFailureResults`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetPartialConvertFailureResults`

#### Summary

Gets the partial failure results.

#### Remarks

After the Convert method has been invoked and returned the DesignToFabricationConverterResult::Enum::PartialFailure, calls this method to get partial failure results.

#### Since

2017

### `M:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.SetMapForFamilySymbolToFabricationPartType(System.Collections.Generic.IDictionary{Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.SetMapForFamilySymbolToFabricationPartType(System.Collections.Generic.IDictionary{Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId})`

#### Summary

Set a map for the conversion of in line family symbols to similar fabrication part types.

#### Parameter `typeMappings`

The map containing the family symbol element identifiers to the fabrication part type element identifiers to convert to.

#### Returns

If the mapping is properly structured, DesignToFabricationMappingResult.Success is returned. Otherwise, consult the members of DesignToFabricationMappingResult to understand why this call failed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.Convert(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.Convert(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.Int32)`

#### Summary

Converts the set of MEP design elements into fabrication parts.

#### Remarks

After this method has been invoked, call:
`M:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetConvertedFabricationParts` to get a set of element identifiers for the newly created fabrication parts.`M:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetElementsWithOpenConnector` to get a set of fabrication part or MEP design element identifiers with open connectors, caused by fittings failing to convert.

#### Parameter `selection`

The set of element identifiers to convert from MEP design elements to fabrication parts.

#### Parameter `serviceId`

The identifier of the fabrication service.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the selection contains invalid elements to convert.
-or-
the specified fabrication service is not valid for all domains in the selection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

no fabrication configuration is loaded.

#### Since

2017

### `P:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.#ctor(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.#ctor(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new instance of the DesignToFabricationConverter class.

#### Parameter `document`

A document in which to convert MEP design elements into fabrication parts.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter`

#### Summary

This class represents the MEP design to fabrication part convert tool.

#### Remarks

After a new instance of the class is created, call the Convert method to convert the MEP design elements into
fabrication parts. Use the method SetMapForFamilySymbolToFabricationPartType to optionally convert family content
to fabrication parts prior to calling Convert by providing a mapping of family symbols to fabrication parts types.
If not set, then during conversion these families will remain and any connections to other converted elements will be
maintained. After the convert method has been invoked, query the class to obtain more information about the conversion:
`M:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetConvertedFabricationParts` to get a set of element identifiers for the newly created fabrication parts.`M:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter.GetElementsWithOpenConnector` to get a set of fabrication part or MEP design element identifiers with open connectors, caused by fittings failing to convert.

#### Since

2017

### `T:Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult`

#### Summary

Possible results from setting the mapping from Family symbols to Fabrication part types.

#### Since

2022

### `F:Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult.UnsupportedFabricationPartType`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult.UnsupportedFabricationPartType`

#### Summary

Failed due to attempting to convert an unsupported Fabrication part type. It is expected to be either valve, strainer, damper, smoke detector, end cap, or other in line component.

### `F:Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult.UnsupportedFamilySymbol`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult.UnsupportedFamilySymbol`

#### Summary

Failed due to attempting to convert an unsupported Family symbol. It is expected to be either valve, strainer, damper, smoke detector, end cap, or other in line component.

### `F:Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult.InvalidFabricationPartType`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult.InvalidFabricationPartType`

#### Summary

Failed because there was an invalid Fabrication part type identifier or an identifier that did not exist in the mappings.

### `F:Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult.InvalidFamilySymbol`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult.InvalidFamilySymbol`

#### Summary

Failed because there was an invalid Family symbol identifier or an identifier that did not exist in the mappings.

### `F:Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult.Undefined`

#### Summary

Failed because the map contained no entries.

### `F:Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult.Success`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult.Success`

#### Summary

Setting the mappings for conversion was successful.

### `T:Autodesk.Revit.DB.Fabrication.PartialFailureResults`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.PartialFailureResults`

#### Summary

Possible results of the partial failure from invoking the DesignToFabricationConverter.

#### Since

2017

### `F:Autodesk.Revit.DB.Fabrication.PartialFailureResults.NoMatchingSize`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.PartialFailureResults.NoMatchingSize`

#### Summary

There are no matching sizes found.

### `F:Autodesk.Revit.DB.Fabrication.PartialFailureResults.HaveDifferentOffsets`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.PartialFailureResults.HaveDifferentOffsets`

#### Summary

Converted fabrication parts have different offsets.

### `F:Autodesk.Revit.DB.Fabrication.PartialFailureResults.HaveOpenConnectors`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.PartialFailureResults.HaveOpenConnectors`

#### Summary

Converted fabrication parts have open ends.

### `F:Autodesk.Revit.DB.Fabrication.PartialFailureResults.InvalidConnections`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.PartialFailureResults.InvalidConnections`

#### Summary

The connections are invalid.

### `F:Autodesk.Revit.DB.Fabrication.PartialFailureResults.NotAllPartsConverted`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.PartialFailureResults.NotAllPartsConverted`

#### Summary

Not all design elements were converted.

### `T:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverterResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverterResult`

#### Summary

Possible results from invoking the DesignToFabricationConverter.

#### Since

2017

### `F:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverterResult.PartialFailure`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverterResult.PartialFailure`

#### Summary

Conversion contained partial failures and will need to be fixed manually.

### `F:Autodesk.Revit.DB.Fabrication.DesignToFabricationConverterResult.Success`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.DesignToFabricationConverterResult.Success`

#### Summary

Conversion was successful.

### `M:Autodesk.Revit.DB.DefaultDivideSettings.SetSurfaceDistance(Autodesk.Revit.DB.UVGridlineType,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefaultDivideSettings.SetSurfaceDistance(Autodesk.Revit.DB.UVGridlineType,System.Double)`

#### Summary

Sets the default Divided Surface distance for a fixed, minimum, or maximum distance layout for U or V gridlines.

#### Parameter `gridlines`

U-gridlines or V-gridlines.

#### Parameter `distance`

A default distance for a layout.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for distance must be positive.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.DefaultDivideSettings.GetSurfaceDistance(Autodesk.Revit.DB.UVGridlineType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefaultDivideSettings.GetSurfaceDistance(Autodesk.Revit.DB.UVGridlineType)`

#### Summary

Gets the default Divided Surface distance for a fixed, minimum, or maximum distance layout for U or V gridlines.

#### Parameter `gridlines`

U-gridlines or V-gridlines.

#### Returns

The default distance for the layout.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.DefaultDivideSettings.SetSurfaceNumber(Autodesk.Revit.DB.UVGridlineType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefaultDivideSettings.SetSurfaceNumber(Autodesk.Revit.DB.UVGridlineType,System.Int32)`

#### Summary

Sets the default Divided Surface number for a fixed number layout for U or V gridlines.

#### Parameter `gridlines`

U-gridlines or V-gridlines.

#### Parameter `number`

A default number for a fixed number layout.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for number is not positive.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.DefaultDivideSettings.GetSurfaceNumber(Autodesk.Revit.DB.UVGridlineType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefaultDivideSettings.GetSurfaceNumber(Autodesk.Revit.DB.UVGridlineType)`

#### Summary

Gets the default Divided Surface number for a fixed number layout for U or V gridlines.

#### Parameter `gridlines`

U-gridlines or V-gridlines.

#### Returns

The default number for a fixed number layout.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.DefaultDivideSettings.SetSurfaceLayout(Autodesk.Revit.DB.UVGridlineType,Autodesk.Revit.DB.SpacingRuleLayout)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefaultDivideSettings.SetSurfaceLayout(Autodesk.Revit.DB.UVGridlineType,Autodesk.Revit.DB.SpacingRuleLayout)`

#### Summary

Sets the default Divided Surface layout for U or V gridlines.

#### Parameter `gridlines`

U-gridlines or V-gridlines.

#### Parameter `layout`

A layout spacing rule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.DefaultDivideSettings.GetSurfaceLayout(Autodesk.Revit.DB.UVGridlineType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefaultDivideSettings.GetSurfaceLayout(Autodesk.Revit.DB.UVGridlineType)`

#### Summary

Gets the default Divided Surface layout for U or V gridlines.

#### Parameter `gridlines`

U-gridlines or V-gridlines.

#### Returns

The layout spacing rule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.DefaultDivideSettings.GetDefaultDivideSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefaultDivideSettings.GetDefaultDivideSettings(Autodesk.Revit.DB.Document)`

#### Summary

Obtains the DefaultDivideSettings object for the specified document.

#### Parameter `cda`

A document.

#### Returns

The DefaultDivideSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.DefaultDivideSettings.PathMeasurementType`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefaultDivideSettings.PathMeasurementType`

#### Summary

A default Divided Path measurement type for distance layouts.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `P:Autodesk.Revit.DB.DefaultDivideSettings.PathDistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefaultDivideSettings.PathDistance`

#### Summary

A default Divided Path distance for a fixed, minimum, or maximum distance layout.

#### Since

2015

### `P:Autodesk.Revit.DB.DefaultDivideSettings.PathNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefaultDivideSettings.PathNumber`

#### Summary

A default Divided Path number for a fixed number layout.

#### Since

2015

### `P:Autodesk.Revit.DB.DefaultDivideSettings.PathLayout`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefaultDivideSettings.PathLayout`

#### Summary

A default Divided Path layout.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `T:Autodesk.Revit.DB.DefaultDivideSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.DefaultDivideSettings`

#### Summary

Provides access to project-wide divide settings.

#### Since

2014

### `T:Autodesk.Revit.DB.UVGridlineType`

Member kind: type
Symbol: `Autodesk.Revit.DB.UVGridlineType`

#### Since

2014

#### Summary

A choice between U-gridlines or V-gridlines of a divided surface
U Gridlines
V Gridlines

#### Since

2014

### `T:Autodesk.Revit.DB.DividedPathMeasurementType`

Member kind: type
Symbol: `Autodesk.Revit.DB.DividedPathMeasurementType`

#### Since

2013

#### Summary

DividedPath measurement type.

#### Since

2013

### `F:Autodesk.Revit.DB.DividedPathMeasurementType.SegmentLength`

Member kind: field
Symbol: `Autodesk.Revit.DB.DividedPathMeasurementType.SegmentLength`

#### Summary

Distances between two points are measured along the path segment between the points.

### `F:Autodesk.Revit.DB.DividedPathMeasurementType.ChordLength`

Member kind: field
Symbol: `Autodesk.Revit.DB.DividedPathMeasurementType.ChordLength`

#### Summary

Distances between two points are measured along a straight line between the points.

### `M:Autodesk.Revit.DB.DatasmithRevitExporterOptions.IsOptionSet(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatasmithRevitExporterOptions.IsOptionSet(System.String)`

#### Summary

Returns the true if the option is set and false otherwise.

#### Parameter `optionName`

The option name.

#### Returns

Returns the true if the option is set and false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.DatasmithRevitExporterOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DatasmithRevitExporterOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.DatasmithRevitExporterOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DatasmithRevitExporterOptions`

#### Summary

A utility class containing the Revit.ini options settings related to DatasmithRevitExporterOptions.

#### Since

2024

### `M:Autodesk.Revit.DB.DatasmithRevitExporterHelper.IsGPUMemoryEnough`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatasmithRevitExporterHelper.IsGPUMemoryEnough`

#### Summary

Returns if there is enough GPU memory to support Twinmotion.

#### Returns

Returns true if we have enough GPU memory. Returns false if there isn't.

#### Since

2024

### `T:Autodesk.Revit.DB.DatasmithRevitExporterHelper`

Member kind: type
Symbol: `Autodesk.Revit.DB.DatasmithRevitExporterHelper`

#### Summary

A utility class containing helpers related to the TwinmotionForRevit Addin.

#### Since

2024

### `M:Autodesk.Revit.DB.ExtensibleStorage.DataStorage.Create(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.DataStorage.Create(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new DataStorage element and adds it to the document.

#### Parameter `doc`

Document to which the new element should be added.

#### Returns

The newly created DataStorage element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.ExtensibleStorage.DataStorage`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.DataStorage`

#### Summary

An element which allows an API applications to organize and store data.

#### Remarks

Applications can create instances of these elements to logically organize
different sets of ExtensibleStorage entities into separate elements.
This allows an application to update one set of data in a local
workshared project without locking other elements.

#### Since

2013

### `P:Autodesk.Revit.DB.DataConversionMonitorScope.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DataConversionMonitorScope.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.DataConversionMonitorScope.#ctor(Autodesk.Revit.DB.IDataConversionMonitor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DataConversionMonitorScope.#ctor(Autodesk.Revit.DB.IDataConversionMonitor)`

#### Summary

The only constructor. Expects a valid pointer to IDataConversionMonitor.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.DataConversionMonitorScope`

Member kind: type
Symbol: `Autodesk.Revit.DB.DataConversionMonitorScope`

#### Summary

This class is used to regsiter an application-supplied object that implements IDataConversionMonitor.
Creating the object registers an implementation of IDataConversionMonitor supplied as constructor argument.
When the scope object is destroyed, that object is unregistered.

#### Since

2016

### `M:Autodesk.Revit.DB.PartMaker.SetSourceElementIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMaker.SetSourceElementIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Set the source elements for the PartMaker.

#### Parameter `sourceElementIds`

Elements to be the sources for this PartMaker.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more element ids was not permitted to be a source for this PartMaker
Elements should be Parts that have no PartMaker yet

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartMaker.GetSourceElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMaker.GetSourceElementIds`

#### Summary

Get the source elements for the PartMaker.

#### Returns

Elements that are the sources for this PartMaker.

#### Since

2013

### `M:Autodesk.Revit.DB.PartMaker.IsSourceElement(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMaker.IsSourceElement(Autodesk.Revit.DB.ElementId)`

#### Summary

Is the element a source for this PartMaker

#### Returns

Returns true if elemId is among the source elements of this PartMaker

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.PartMaker`

Member kind: type
Symbol: `Autodesk.Revit.DB.PartMaker`

#### Summary

PartMaker is an element which takes some source elements (e.g., a wall
with all its layers) and creates one or more Parts out of it. The logic
according to which these Parts are created is non-trivial and PartMaker
uses various PartMakerMethods which represents these logics.
This element manages the strategy to make Part elements for one or more original elements.

#### Since

2012

### `M:Autodesk.Revit.DB.Part.GetSourceElementOriginalCategoryIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Part.GetSourceElementOriginalCategoryIds`

#### Summary

Gets the category ids of the source elements which were used to form this part.

#### Returns

The category ids.

#### Since

2013

### `M:Autodesk.Revit.DB.Part.GetSourceElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Part.GetSourceElementIds`

#### Summary

Gets a collection of elements from which this Part is created by the PartMaker.
May return more than one source only if there is merge involved somewhere in the history of this Part.

#### Remarks

A source element is one of the elements in the original file that the PartMaker uses to create a Part.
For example, a floor or a wall used to create a Part can be called a source element.

#### Returns

The collection of elements

#### Since

2013

### `M:Autodesk.Revit.DB.Part.ResetFaceOffset(Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Part.ResetFaceOffset(Autodesk.Revit.DB.Face)`

#### Summary

Resets the offset applied to the given part face.

#### Parameter `face`

The face whose offset needs to be reset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

face does not belong to the part.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Part.ResetPartShape`

Member kind: method
Symbol: `Autodesk.Revit.DB.Part.ResetPartShape`

#### Summary

Resets all face offsets applied to part faces.

#### Since

2012

### `M:Autodesk.Revit.DB.Part.GetFaceOffset(Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Part.GetFaceOffset(Autodesk.Revit.DB.Face)`

#### Summary

Get face offset of the given part face.

#### Parameter `face`

The face whose offset is required.

#### Returns

Returns the value of the offset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

face does not belong to the part.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Part.SetFaceOffset(Autodesk.Revit.DB.Face,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Part.SetFaceOffset(Autodesk.Revit.DB.Face,System.Double)`

#### Summary

Offsets the given part face in the direction that points out of the solid shape with the specified amount.
Negative value will offset the face into the solid shape.

#### Parameter `face`

The face to offset.

#### Parameter `offset`

The magnitude of the offset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

face does not belong to the part.
-or-
The face to be offset should be planar and satisfy constraints of its parent element

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Part.CanOffsetFace(Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Part.CanOffsetFace(Autodesk.Revit.DB.Face)`

#### Summary

Checks if it is possible to offset the given face.

#### Parameter `face`

face to be checked.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Part.PartMaker`

Member kind: property
Symbol: `Autodesk.Revit.DB.Part.PartMaker`

#### Summary

The PartMaker that created this Part.

#### Since

2012

### `P:Autodesk.Revit.DB.Part.Excluded`

Member kind: property
Symbol: `Autodesk.Revit.DB.Part.Excluded`

#### Summary

True if the part is excluded, false otherwise

#### Since

2013

### `P:Autodesk.Revit.DB.Part.OriginalCategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Part.OriginalCategoryId`

#### Summary

The category Id of the original element corresponding to this Part.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: dPartOriginalCategoryId is not an available member of the original category ids of the elements which formed this Part.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.Part`

Member kind: type
Symbol: `Autodesk.Revit.DB.Part`

#### Summary

This element represents a part of another element.

#### Remarks

A part is associated with a PartMaker element that creates it.

#### Since

2012

### `M:Autodesk.Revit.DB.ViewFamilyType.IsValidDefaultTemplate(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewFamilyType.IsValidDefaultTemplate(Autodesk.Revit.DB.ElementId)`

#### Summary

Verifies that the input can be used as a default template for this view type.

#### Remarks

The id must represent a template view that is compatible with this view type, or InvalidElementId.

#### Parameter `templateId`

Id to be validated as default template.

#### Returns

True if %templateId% is valid as default template, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.ViewFamilyType.ViewFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewFamilyType.ViewFamily`

#### Summary

The ViewFamily for this view type.

#### Since

2013

### `P:Autodesk.Revit.DB.ViewFamilyType.DefaultTemplateId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewFamilyType.DefaultTemplateId`

#### Summary

The default template id assigned to this view type.

#### Remarks

This value will be the view template for all newly created instances of this view type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: val is not valid as a default template id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.ViewFamilyType.PlanViewDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewFamilyType.PlanViewDirection`

#### Summary

The PlanViewDirection of this view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: PlanViewDirection cannot be set to Undefined

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: View must be a Structural Plan

#### Since

2013

### `T:Autodesk.Revit.DB.ViewFamilyType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewFamilyType`

#### Summary

Represents a type of a Revit view.

#### Remarks

ViewFamilyTypes represent possible types for a Revit view and contain view type related properties and options such as the default template associated to views
created from this type. They are commonly input to new View creation methods in the Revit API.

#### Since

2013

### `T:Autodesk.Revit.DB.ViewFamily`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewFamily`

#### Summary

An enumerated type that corresponds to the type of a Revit view.

#### Since

2013

### `F:Autodesk.Revit.DB.ViewFamily.SystemsAnalysisReport`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.SystemsAnalysisReport`

#### Summary

Systems analysis report.

### `F:Autodesk.Revit.DB.ViewFamily.StructuralPlan`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.StructuralPlan`

#### Summary

Structural plan view.

### `F:Autodesk.Revit.DB.ViewFamily.GraphicalColumnSchedule`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.GraphicalColumnSchedule`

#### Summary

Graphical column schedule.

### `F:Autodesk.Revit.DB.ViewFamily.PanelSchedule`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.PanelSchedule`

#### Summary

Panel schedule.

### `F:Autodesk.Revit.DB.ViewFamily.Legend`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.Legend`

#### Summary

Legend view.

### `F:Autodesk.Revit.DB.ViewFamily.PressureLossReport`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.PressureLossReport`

#### Summary

Pressure loss report.

### `F:Autodesk.Revit.DB.ViewFamily.LoadsReport`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.LoadsReport`

#### Summary

HVAC load report.

### `F:Autodesk.Revit.DB.ViewFamily.Elevation`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.Elevation`

#### Summary

Elevation view.

### `F:Autodesk.Revit.DB.ViewFamily.Detail`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.Detail`

#### Summary

Detail view.

### `F:Autodesk.Revit.DB.ViewFamily.Section`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.Section`

#### Summary

Section view.

### `F:Autodesk.Revit.DB.ViewFamily.CeilingPlan`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.CeilingPlan`

#### Summary

Ceiling plan view.

### `F:Autodesk.Revit.DB.ViewFamily.AreaPlan`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.AreaPlan`

#### Summary

Area plan view.

### `F:Autodesk.Revit.DB.ViewFamily.FloorPlan`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.FloorPlan`

#### Summary

Floor plan view.

### `F:Autodesk.Revit.DB.ViewFamily.Drafting`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.Drafting`

#### Summary

Drafting view.

### `F:Autodesk.Revit.DB.ViewFamily.Sheet`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.Sheet`

#### Summary

Sheet view.

### `F:Autodesk.Revit.DB.ViewFamily.CostReport`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.CostReport`

#### Summary

Cost report view (obsolete).

### `F:Autodesk.Revit.DB.ViewFamily.Schedule`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.Schedule`

#### Summary

Schedule view.

### `F:Autodesk.Revit.DB.ViewFamily.ImageView`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.ImageView`

#### Summary

Rendering view.

### `F:Autodesk.Revit.DB.ViewFamily.Walkthrough`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.Walkthrough`

#### Summary

Walkthrough view.

### `F:Autodesk.Revit.DB.ViewFamily.ThreeDimensional`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.ThreeDimensional`

#### Summary

3D view.

### `F:Autodesk.Revit.DB.ViewFamily.Invalid`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewFamily.Invalid`

#### Summary

Invalid view type.

### `T:Autodesk.Revit.DB.PlanViewDirection`

Member kind: type
Symbol: `Autodesk.Revit.DB.PlanViewDirection`

#### Summary

This enumerated type represents the possible directions for a plan view.

#### Since

2013

### `F:Autodesk.Revit.DB.PlanViewDirection.Up`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewDirection.Up`

#### Summary

Revit looks up to the plan view

### `F:Autodesk.Revit.DB.PlanViewDirection.Down`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewDirection.Down`

#### Summary

Revit looks down onto the plan view

### `F:Autodesk.Revit.DB.PlanViewDirection.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewDirection.Undefined`

#### Summary

View does not use Plan View Direction

### `M:Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.GenerateReportConfigFile(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.GenerateReportConfigFile(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Generates the report configuration json file based on the document unit and locale.

#### Parameter `doc`

The document where the configuration is based upon.

#### Parameter `outputFileName`

The output json file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020.1

### `M:Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.GetReportContent`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.GetReportContent`

#### Summary

Gets the report content in this view.

#### Remarks

The report shows "Calculating..." if the background calculation is still going on.
You may call isAnalysisCompleted() to check if the calculation is completed.

#### Returns

The content of the report as displayed in the view, or the referenced file name.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.IsAnalysisCompleted`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.IsAnalysisCompleted`

#### Summary

Indicates if the background systems analysis has completed or not.

#### Returns

True if completed, otherwise false.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.GetLatestSystemsAnalysisReport(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.GetLatestSystemsAnalysisReport(Autodesk.Revit.DB.Document)`

#### Summary

Gets the latest report of systems analysis.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020.1

### `M:Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.CancelSystemsAnalysis(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.CancelSystemsAnalysis(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Cancels the systems analysis based on the report element id.

#### Parameter `document`

The document where the report element existed.

#### Parameter `reportElement`

The report element that identifies the analysis.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.RequestSystemsAnalysis(Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.RequestSystemsAnalysis(Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions)`

#### Summary

Requests a new systems analysis in the background.

#### Parameter `options`

The additional options to run systems analysis. If empty, use the default value in the view element.
The request may download the weather file at current site location if not specified in the options.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

No weather station is within 500 nautical miles of this site location.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

Fail to download the weather file.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

A valid energy model is required for systems analysis.
-or-
Unable to access the weather service. Try again later.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new view for the systems analysis report.

#### Remarks

A report instance is typically created to request a new systems analysis. The default values include the weather file "USA_CO_Denver.Intl.AP.725650_TMY3.epw" and
the workflow file "HVAC Systems Loads and Sizing.osw". Both are part of the Revit installation. The default output folder is the system TEMP folder.

#### Parameter `document`

The document where the view is to be created.

#### Parameter `viewName`

The name of the new report view.

#### Returns

The newly created view instance, or `null` if the operation fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

viewName cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
viewName is an empty string.

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

2020.1

### `P:Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.AnalysisDateAndTime`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.AnalysisDateAndTime`

#### Summary

Identifies the analysis date and time when it was requested.

#### Since

2020.1

### `P:Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.ReportStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.ReportStyle`

#### Summary

The report style that specifies the display content.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `P:Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.SystemsAnalysisOutputFolder`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.SystemsAnalysisOutputFolder`

#### Summary

The full path of the output folder for systems analysis

#### Since

2020.1

### `P:Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.WeatherFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.WeatherFile`

#### Summary

The full path name of the weather file used for the systems analysis.

#### Since

2020.1

### `P:Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.SystemsAnalysisWorkflowFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport.SystemsAnalysisWorkflowFile`

#### Summary

The full path name of the original system analysis workflow file.

#### Since

2020.1

### `T:Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport`

#### Summary

Represents a report instance of the systems analysis.

#### Since

2020.1

### `T:Autodesk.Revit.DB.Analysis.SystemsAnalysisReportStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.SystemsAnalysisReportStyle`

#### Summary

The report style of systems analysis.

#### Since

2022

### `F:Autodesk.Revit.DB.Analysis.SystemsAnalysisReportStyle.Loads`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.SystemsAnalysisReportStyle.Loads`

#### Summary

The loads report style.

### `F:Autodesk.Revit.DB.Analysis.SystemsAnalysisReportStyle.Detailed`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.SystemsAnalysisReportStyle.Detailed`

#### Summary

The detailed report style.

### `P:Autodesk.Revit.DB.ViewScheduleExportOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewScheduleExportOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewScheduleExportOptions.Title`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewScheduleExportOptions.Title`

#### Summary

Whether or not to export the schedule title. Default is true.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewScheduleExportOptions.HeadersFootersBlanks`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewScheduleExportOptions.HeadersFootersBlanks`

#### Summary

Whether to export group headers, footers, and blank lines. Default is true.

#### Since

2013

### `P:Autodesk.Revit.DB.ViewScheduleExportOptions.FieldDelimiter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewScheduleExportOptions.FieldDelimiter`

#### Summary

How to delimit fields. Default is Tab.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.ViewScheduleExportOptions.ColumnHeaders`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewScheduleExportOptions.ColumnHeaders`

#### Summary

How to export column headers. Default is MultipleRows.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.ViewScheduleExportOptions.TextQualifier`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewScheduleExportOptions.TextQualifier`

#### Summary

How to qualify text fields. Default is DoubleQuote.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.ViewScheduleExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewScheduleExportOptions.#ctor`

#### Summary

Constructs a new instance of the ViewScheduleExportOptions class

#### Since

2013

### `M:Autodesk.Revit.DB.ViewScheduleExportOptions.#ctor(Autodesk.Revit.DB.ViewScheduleExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewScheduleExportOptions.#ctor(Autodesk.Revit.DB.ViewScheduleExportOptions)`

#### Summary

Constructs a new copy of the input ViewScheduleExportOptions object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.ViewScheduleExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewScheduleExportOptions`

#### Summary

The export options used to export schedule views.

#### Since

2013

### `T:Autodesk.Revit.DB.ExportTextQualifier`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportTextQualifier`

#### Summary

Options for the text qualifier character in schedule view export.

#### Since

2013

### `F:Autodesk.Revit.DB.ExportTextQualifier.DoubleQuote`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportTextQualifier.DoubleQuote`

#### Summary

The quote character - " - is used to qualify text.

### `F:Autodesk.Revit.DB.ExportTextQualifier.Quote`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportTextQualifier.Quote`

#### Summary

The quote character - ' - is used to qualify text.

### `F:Autodesk.Revit.DB.ExportTextQualifier.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportTextQualifier.None`

#### Summary

No text qualifier.

### `T:Autodesk.Revit.DB.ExportColumnHeaders`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportColumnHeaders`

#### Summary

Options for exporting column headers in schedule view export.

#### Since

2013

### `F:Autodesk.Revit.DB.ExportColumnHeaders.MultipleRows`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportColumnHeaders.MultipleRows`

#### Summary

Both column headers and grouped header cells are exported.

### `F:Autodesk.Revit.DB.ExportColumnHeaders.OneRow`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportColumnHeaders.OneRow`

#### Summary

Export the column headers only.

### `F:Autodesk.Revit.DB.ExportColumnHeaders.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportColumnHeaders.None`

#### Summary

Do not export column headers.

### `M:Autodesk.Revit.DB.ImageView.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ImageTypeOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageView.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ImageTypeOptions)`

#### Summary

Create an ImageView containing an image imported from disk.

#### Parameter `document`

The document in which to create the view.

#### Parameter `options`

Options that specify what image to load.

#### Returns

The newly created view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The image filename is an empty string.
-or-
The image file is not a supported image file type.
-or-
The image file is password protected.
-or-
The image file does not contain the requested page number.
-or-
The image file could not be read and may be corrupt.
-or-
An error occurred while handling the external resource corresponding to the image.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The image file does not exist.

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

### `P:Autodesk.Revit.DB.ImageView.ImageInstanceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageView.ImageInstanceId`

#### Summary

Id of the image in the view.

### `T:Autodesk.Revit.DB.ImageView`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImageView`

#### Summary

Class for ImageView views

### `M:Autodesk.Revit.DB.PlanViewRange.SetOffset(Autodesk.Revit.DB.PlanViewPlane,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanViewRange.SetOffset(Autodesk.Revit.DB.PlanViewPlane,System.Double)`

#### Summary

Set the offset value associated with a View Depth plane

#### Parameter `planViewPlane`

View Depth plane

#### Parameter `offset`

Offset value

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.PlanViewRange.GetOffset(Autodesk.Revit.DB.PlanViewPlane)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanViewRange.GetOffset(Autodesk.Revit.DB.PlanViewPlane)`

#### Summary

Get the offset value associated with a View Depth plane

#### Parameter `planViewPlane`

View Depth plane

#### Returns

Offset value

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.PlanViewRange.SetLevelId(Autodesk.Revit.DB.PlanViewPlane,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanViewRange.SetLevelId(Autodesk.Revit.DB.PlanViewPlane,Autodesk.Revit.DB.ElementId)`

#### Summary

Set the level for a View Depth plane

#### Parameter `planViewPlane`

The View Depth plane

#### Parameter `id`

Id of the level

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.PlanViewRange.GetLevelId(Autodesk.Revit.DB.PlanViewPlane)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanViewRange.GetLevelId(Autodesk.Revit.DB.PlanViewPlane)`

#### Summary

Get the element id of the level for a View Depth plane

#### Parameter `planViewPlane`

The plane whose level will be returned

#### Returns

Id of the level

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.PlanViewRange.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanViewRange.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.PlanViewRange.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanViewRange.Current`

#### Summary

View range for the current plane

#### Since

2013

### `P:Autodesk.Revit.DB.PlanViewRange.LevelBelow`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanViewRange.LevelBelow`

#### Summary

View range for the level below the specified plane

#### Since

2013

### `P:Autodesk.Revit.DB.PlanViewRange.LevelAbove`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanViewRange.LevelAbove`

#### Summary

View range for the level above the specified plane

#### Since

2013

### `P:Autodesk.Revit.DB.PlanViewRange.Unlimited`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanViewRange.Unlimited`

#### Summary

View range is unlimited

#### Since

2013

### `T:Autodesk.Revit.DB.PlanViewRange`

Member kind: type
Symbol: `Autodesk.Revit.DB.PlanViewRange`

#### Summary

This class represents the view range of a plan view or a plan region.
It records the element ids of the levels which a plane is relative to
and the offset of each plane from that level.

#### Since

2013

### `T:Autodesk.Revit.DB.PlanViewPlane`

Member kind: type
Symbol: `Autodesk.Revit.DB.PlanViewPlane`

#### Summary

Locations where view range offsets can be specified.

#### Since

2013

### `F:Autodesk.Revit.DB.PlanViewPlane.UnderlayBottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewPlane.UnderlayBottom`

#### Summary

Underlay Bottom Plane

### `F:Autodesk.Revit.DB.PlanViewPlane.ViewDepthPlane`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewPlane.ViewDepthPlane`

#### Summary

View Depth Plane

### `F:Autodesk.Revit.DB.PlanViewPlane.BottomClipPlane`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewPlane.BottomClipPlane`

#### Summary

Bottom Clip Plane

### `F:Autodesk.Revit.DB.PlanViewPlane.TopClipPlane`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewPlane.TopClipPlane`

#### Summary

Top Clip Plane

### `F:Autodesk.Revit.DB.PlanViewPlane.CutPlane`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewPlane.CutPlane`

#### Summary

Cut Plane

### `M:Autodesk.Revit.DB.Viewport.GetProjectionToSheetTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.Viewport.GetProjectionToSheetTransform`

#### Summary

Returns the transform from the view's projection space to the sheet space.

#### Remarks

This transform accounts for the position and rotation of a
viewport on a sheet.

The transforms from the model space to the view projection space
are returned by `!:View.GetModelToProjectionTransforms()` .

#### Returns

The transform from the view's projection space to the sheet space.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The viewport is not on a sheet.
-or-
The viewport does not have transforms.

#### Since

2023
