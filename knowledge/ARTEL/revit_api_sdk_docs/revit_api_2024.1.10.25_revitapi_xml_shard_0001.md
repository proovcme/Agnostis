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
Shard: 1
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.OffsetSurface.IsOrientationSameAsBasisSurface`

Member kind: method
Symbol: `Autodesk.Revit.DB.OffsetSurface.IsOrientationSameAsBasisSurface`

#### Summary

Indicates whether the orientation of the OffsetSurface is same as that of its basis surface,
in the sense that their oriented normals at any (u, v) have the same direction.

#### Returns

True if the orientation of the OffsetSurface is same as that of its basis surface, false otherwise.

#### Since

2021

### `M:Autodesk.Revit.DB.OffsetSurface.GetOffsetDistance`

Member kind: method
Symbol: `Autodesk.Revit.DB.OffsetSurface.GetOffsetDistance`

#### Summary

Returns offset distance of this OffsetSurface.

#### Returns

Offset distance of this OffsetSurface.

#### Since

2021

### `M:Autodesk.Revit.DB.OffsetSurface.GetBasisSurface`

Member kind: method
Symbol: `Autodesk.Revit.DB.OffsetSurface.GetBasisSurface`

#### Summary

Returns a copy of basis surface of this OffsetSurface.

#### Returns

Basis surface of this OffsetSurface.

#### Since

2021

### `T:Autodesk.Revit.DB.OffsetSurface`

Member kind: type
Symbol: `Autodesk.Revit.DB.OffsetSurface`

#### Summary

A mathematical representation of an offset surface.

Definition of offset surface, quoted from the STEP manual ISO 10303-42:2000(E):
This is a procedural definition of a simple offset surface at a normal distance from the originating surface.
Distance may be positive, negative, or zero to indicate the preferred side of the surface.
The offset surface takes its parametrization directly from that of its basis surface, corresponding points having
identical parameter values. The offset surface is parametrized as O(u, v) = S(u, v) + d*N(u, v),
where N(u, v) is the oriented unit normal vector of the basis surface S at parameter value (u, v), and d is the signed offset distance.

In Revit, we restrict the types of basis surfaces for which an OffsetSurf can be created for the following reasons:
The offsets of Plane, CylindricalSurface, ConicalSurface and RevolvedSurface are of the same type as the original surface and they have closed form solutions.
So those surfaces are not taken as basis surfaces of the OffsetSurface class. That leaves HermiteSurface and RuledSurface.

As a Revit surface, we require the OffsetSurface to be C2 continuous. That implies that the basis surface should be C3 continuous.
That is because the OffsetSurface evaluation involves the normal of the basis surface and the order of continuity of the normal
is one less than that of the surface.

HermiteSurfaces in general are not C3 continuous, even though some of them can be.
A RuledSurface will be C3 continuous if its parametric curves are C3 continuous.
So we don't allow a HermiteSurface to be a basis surface and allow only RuledSurfaces whose parametric curves are C3 continuous
as basis surfaces of the OffsetSurface class.
The OffsetSurface class will own a copy of the basis surface and use it for many of its methods, which may implicitly assume that
the OffsetSurface and the basis surface have the same envelope. So we keep the envelopes of the OffsetSurf and its basis surface in sync.

#### Since

2021

### `M:Autodesk.Revit.DB.ElementComparerByParameter.Compare(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerByParameter.Compare(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Implement this method to identify the relation of the two
object for the purpose of sorting them.

#### Remarks

If the comparer is for some reason unable to identify
the relations between the two object it should return value of
ElementComparisonResult.Incomparable. Such a situation is believed
to be rather rare though.

#### Parameter `first`

One of the elements to be compared

#### Parameter `second`

The other element to be compared

#### Returns

The result of comparison. ElementComparisonResult.Incomparable if elements cannot be compared.

#### Since

2015

### `M:Autodesk.Revit.DB.ElementComparerByParameter.GetDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerByParameter.GetDescription`

#### Summary

Implement this method to return a description of the comparer.

#### Remarks

The purpose of this string is to describe the comparer
in more details than just a short name alone could do.
The intended use is to show the string to the end user in the UI.

#### Returns

Description of the comparer.

#### Since

2015

### `M:Autodesk.Revit.DB.ElementComparerByParameter.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerByParameter.GetName`

#### Summary

Implement this method to return the name of the comparer.

#### Remarks

Although a comparer is uniquely identified by its Id,
the Name can help to identify it to the end user in the UI.

#### Returns

Name of the comparer.

#### Since

2015

### `M:Autodesk.Revit.DB.ElementComparerByParameter.GetId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerByParameter.GetId`

#### Summary

Implement this method to return the id of the comparer.

#### Remarks

The Id must uniquely identify the comparer.

#### Returns

The id of the comparer.

#### Since

2015

### `M:Autodesk.Revit.DB.ElementComparerByParameter.GetComparerId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerByParameter.GetComparerId`

#### Summary

A static method to obtain the Id this class of a comparer.

#### Returns

The Id as a GUID value

#### Since

2015

### `P:Autodesk.Revit.DB.ElementComparerByParameter.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementComparerByParameter.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ElementComparerByParameter.Data`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementComparerByParameter.Data`

#### Summary

Data that controls the behavior of the comparer.

#### Since

2015

### `M:Autodesk.Revit.DB.ElementComparerByParameter.#ctor(Autodesk.Revit.DB.ElementComparerByParameterData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerByParameter.#ctor(Autodesk.Revit.DB.ElementComparerByParameterData)`

#### Summary

Creates an instance of this comparer initiated by the given data object

#### Parameter `data`

The data defining the parameter to compare by and sorting order

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.ElementComparerByParameter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementComparerByParameter`

#### Summary

The class defining a comparer that sortes by an element's parameter.

#### Since

2015

### `P:Autodesk.Revit.DB.ElementComparerByParameterData.ParameterId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementComparerByParameterData.ParameterId`

#### Summary

Id of the parameter of which value is used when comparing two elements for sorting

#### Since

2015

### `P:Autodesk.Revit.DB.ElementComparerByParameterData.Order`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementComparerByParameterData.Order`

#### Summary

The order in which objects are to be sorted.

#### Since

2015

### `M:Autodesk.Revit.DB.ElementComparerByParameterData.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerByParameterData.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Constructor to instantiate a data with the given parameter Id and default sorting order.

#### Remarks

Use the Order property to change the direction of sorting order as desired.

#### Parameter `parameterId`

Id of the parameter used for comparison

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.ElementComparerByParameterData`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementComparerByParameterData`

#### Summary

Data class that defines behavior of a comparer that uses a parameter
to compare elements when sorting them in order to assign numbers to them.

#### Since

2015

### `M:Autodesk.Revit.DB.ElementComparerById.Compare(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerById.Compare(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Implement this method to identify the relation of the two
object for the purpose of sorting them.

#### Remarks

If the comparer is for some reason unable to identify
the relations between the two object it should return value of
ElementComparisonResult.Incomparable. Such a situation is believed
to be rather rare though.

#### Parameter `first`

One of the elements to be compared

#### Parameter `second`

The other element to be compared

#### Returns

The result of comparison. ElementComparisonResult.Incomparable if elements cannot be compared.

#### Since

2015

### `M:Autodesk.Revit.DB.ElementComparerById.GetDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerById.GetDescription`

#### Summary

Implement this method to return a description of the comparer.

#### Remarks

The purpose of this string is to describe the comparer
in more details than just a short name alone could do.
The intended use is to show the string to the end user in the UI.

#### Returns

Description of the comparer.

#### Since

2015

### `M:Autodesk.Revit.DB.ElementComparerById.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerById.GetName`

#### Summary

Implement this method to return the name of the comparer.

#### Remarks

Although a comparer is uniquely identified by its Id,
the Name can help to identify it to the end user in the UI.

#### Returns

Name of the comparer.

#### Since

2015

### `M:Autodesk.Revit.DB.ElementComparerById.GetId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerById.GetId`

#### Summary

Implement this method to return the id of the comparer.

#### Remarks

The Id must uniquely identify the comparer.

#### Returns

The id of the comparer.

#### Since

2015

### `M:Autodesk.Revit.DB.ElementComparerById.GetComparerId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerById.GetComparerId`

#### Summary

A static method to obtain the Id this class of a comparer.

#### Returns

The Id as a GUID value

#### Since

2015

### `P:Autodesk.Revit.DB.ElementComparerById.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementComparerById.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ElementComparerById.Data`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementComparerById.Data`

#### Summary

Data that controls the behavior of the comparer.

#### Since

2015

### `M:Autodesk.Revit.DB.ElementComparerById.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerById.#ctor`

#### Summary

Default constructor

#### Remarks

Creates an instance of this comparer with properties set to their
default values. Use the Data property to set values differently.

#### Since

2015

### `T:Autodesk.Revit.DB.ElementComparerById`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementComparerById`

#### Summary

The class defining the default element comparer.

#### Remarks

An instance of this class is to be used if no other comparer
is explicitly set when sorting a collection of objects for the purpose
of numbering them (i.e. assigning an identifying number to them.)

#### Since

2015

### `P:Autodesk.Revit.DB.ElementComparerByIdData.Order`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementComparerByIdData.Order`

#### Summary

The order in which objects are to be sorted.

#### Since

2015

### `M:Autodesk.Revit.DB.ElementComparerByIdData.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementComparerByIdData.#ctor`

#### Summary

Default constructor

#### Remarks

Creates an instance of the data class set for ascending order.
Use the Order property to change the direction of sorting order.

#### Since

2015

### `T:Autodesk.Revit.DB.ElementComparerByIdData`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementComparerByIdData`

#### Summary

Data class that defines behavior of a comparer that uses Element Ids
to compare elements when sorting them in order to assign numbers to them.

#### Remarks

This comparer is used by default if no other comparer is explicitly specified.

#### Since

2015

### `P:Autodesk.Revit.DB.ElementComparerData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementComparerData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ElementComparerData`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementComparerData`

#### Summary

The base class from which all built-in comparer data classes derive from

#### Since

2015

### `M:Autodesk.Revit.DB.IElementComparerProxy.Compare(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IElementComparerProxy.Compare(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Implement this method to identify the relation of the two
object for the purpose of sorting them.

#### Remarks

If the comparer is for some reason unable to identify
the relations between the two object it should return value of
ElementComparisonResult.Incomparable. Such a situation is believed
to be rather rare though.

#### Parameter `first`

One of the elements to be compared

#### Parameter `second`

The other element to be compared

#### Returns

The result of comparison. ElementComparisonResult.Incomparable if elements cannot be compared.

#### Since

2015

### `M:Autodesk.Revit.DB.IElementComparerProxy.GetDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.IElementComparerProxy.GetDescription`

#### Summary

Implement this method to return a description of the comparer.

#### Remarks

The purpose of this string is to describe the comparer
in more details than just a short name alone could do.
The intended use is to show the string to the end user in the UI.

#### Returns

Description of the comparer.

#### Since

2015

### `M:Autodesk.Revit.DB.IElementComparerProxy.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.IElementComparerProxy.GetName`

#### Summary

Implement this method to return the name of the comparer.

#### Remarks

Although a comparer is uniquely identified by its Id,
the Name can help to identify it to the end user in the UI.

#### Returns

Name of the comparer.

#### Since

2015

### `M:Autodesk.Revit.DB.IElementComparerProxy.GetId`

Member kind: method
Symbol: `Autodesk.Revit.DB.IElementComparerProxy.GetId`

#### Summary

Implement this method to return the id of the comparer.

#### Remarks

The Id must uniquely identify the comparer.

#### Returns

The id of the comparer.

#### Since

2015

### `M:Autodesk.Revit.DB.IElementComparer.Compare(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IElementComparer.Compare(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Implement this method to identify the relation of the two
object for the purpose of sorting them.

#### Remarks

If the comparer is for some reason unable to identify
the relations between the two object it should return value of
ElementComparisonResult.Incomparable. Such a situation is believed
to be rather rare though.

#### Parameter `first`

One of the elements to be compared

#### Parameter `second`

The other element to be compared

#### Returns

The result of comparison. ElementComparisonResult.Incomparable if elements cannot be compared.

#### Since

2015

### `M:Autodesk.Revit.DB.IElementComparer.GetDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.IElementComparer.GetDescription`

#### Summary

Implement this method to return a description of the comparer.

#### Remarks

The purpose of this string is to describe the comparer
in more details than just a short name alone could do.
The intended use is to show the string to the end user in the UI.

#### Returns

Description of the comparer.

#### Since

2015

### `M:Autodesk.Revit.DB.IElementComparer.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.IElementComparer.GetName`

#### Summary

Implement this method to return the name of the comparer.

#### Remarks

Although a comparer is uniquely identified by its Id,
the Name can help to identify it to the end user in the UI.

#### Returns

Name of the comparer.

#### Since

2015

### `M:Autodesk.Revit.DB.IElementComparer.GetId`

Member kind: method
Symbol: `Autodesk.Revit.DB.IElementComparer.GetId`

#### Summary

Implement this method to return the id of the comparer.

#### Remarks

The Id must uniquely identify the comparer.

#### Returns

The id of the comparer.

#### Since

2015

### `T:Autodesk.Revit.DB.IElementComparer`

Member kind: type
Symbol: `Autodesk.Revit.DB.IElementComparer`

#### Summary

An interface which Element Comparers are derived from.

#### Remarks

Comparers affect the way elements in Revit models
are sorted for the purpose of numbering them.

#### Since

2015

### `T:Autodesk.Revit.DB.ElementComparisonResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementComparisonResult`

#### Summary

Enumerated values of the result of comparing two objects for sorting purposes.

#### Since

2015

### `F:Autodesk.Revit.DB.ElementComparisonResult.Incomparable`

Member kind: field
Symbol: `Autodesk.Revit.DB.ElementComparisonResult.Incomparable`

#### Summary

Two objects cannot be compared due to their different type or incompatible nature.

### `F:Autodesk.Revit.DB.ElementComparisonResult.Reversed`

Member kind: field
Symbol: `Autodesk.Revit.DB.ElementComparisonResult.Reversed`

#### Summary

Two objects differ and are in reversed order, meaning the first one is bigger than the second one.

### `F:Autodesk.Revit.DB.ElementComparisonResult.Ordered`

Member kind: field
Symbol: `Autodesk.Revit.DB.ElementComparisonResult.Ordered`

#### Summary

Two objects differ, but are correctly ordered, meaning the first one is smaller than the second one.

### `F:Autodesk.Revit.DB.ElementComparisonResult.Equal`

Member kind: field
Symbol: `Autodesk.Revit.DB.ElementComparisonResult.Equal`

#### Summary

Two objects being compared are considered equal.

### `M:Autodesk.Revit.DB.VisibleInViewFilter.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.VisibleInViewFilter.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Constructs a new instance of a VisibleInViewFilter, with the option to pass all non-visible elements.

#### Parameter `document`

The document that owns the view.

#### Parameter `viewId`

The view id.

#### Parameter `inverted`

True if the filter should match all elements not visible in the given view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

viewId is not a view.
-or-
viewId is not valid for element iteration, because it has no way of representing drawn elements. Many view templates
will fail this check.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.VisibleInViewFilter.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.VisibleInViewFilter.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a new instance of a VisibleInViewFilter.

#### Parameter `document`

The document that owns the view.

#### Parameter `viewId`

The view id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

viewId is not a view.
-or-
viewId is not valid for element iteration, because it has no way of representing drawn elements. Many view templates
will fail this check.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `T:Autodesk.Revit.DB.VisibleInViewFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.VisibleInViewFilter`

#### Summary

A quick filter that passes elements that are most likely visible in the given view.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.
In some situations (for example, when the element geometry is not yet calculated for the input view)
this filter may return true even though the element may not actually be visible when geometry is calculated.

#### Since

2021

### `T:Autodesk.Revit.DB.ViewTemplateApplicationOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewTemplateApplicationOption`

#### Summary

Options for applying view templates

#### Since

2013

#### Since

2013

### `F:Autodesk.Revit.DB.ViewTemplateApplicationOption.AllParametersAndStickIfNone`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewTemplateApplicationOption.AllParametersAndStickIfNone`

#### Summary

Apply all parameters controlled by template and if none is currently assigned make it view template

### `F:Autodesk.Revit.DB.ViewTemplateApplicationOption.UncontrolledParameters`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewTemplateApplicationOption.UncontrolledParameters`

#### Summary

Apply only parameters controlled by template and not controlled by currently assigned view template

### `F:Autodesk.Revit.DB.ViewTemplateApplicationOption.AllParameters`

Member kind: field
Symbol: `Autodesk.Revit.DB.ViewTemplateApplicationOption.AllParameters`

#### Summary

Apply all parameters controlled by template

### `M:Autodesk.Revit.DB.ViewShapeBuilder.ValidatePoint(Autodesk.Revit.DB.Point)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.ValidatePoint(Autodesk.Revit.DB.Point)`

#### Summary

Validates point to be added to the view-specific shape being constructed. Called by AddPoint() to validate input.

#### Remarks

This function may be used to pre-validate the geometry being added to avoid AddPoint() throwing an InvalidArgumentException
Validation conditions depend on the type of view for which the shape representation is intended.
The current validation condition is that the point lies within a 60000' cube centered at origin.
The size of this cube is determined by the const double MAX_LENGTH, currently set at 30000'.

#### Parameter `GPoint`

Point object to be validated.

#### Returns

True is %GPoint% is acceptable as a part of view-specific shape representation being built.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021.1

### `M:Autodesk.Revit.DB.ViewShapeBuilder.ValidatePolyLine(Autodesk.Revit.DB.PolyLine)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.ValidatePolyLine(Autodesk.Revit.DB.PolyLine)`

#### Summary

Validates polyline to be added to the view-specific shape being constructed. Called by AddPolyLine() to validate input.

#### Remarks

This function may be used to pre-validate the geometry being added to avoid AddPolyLine() throwing an InvalidArgumentException
Validation conditions depend on the type of view for which the shape representation is intended.
For plan views, a polyline is expected to be planar and non-degenerate (e.g., NOT a circle of zero radius).

#### Parameter `GPolyLine`

Polyline object to be validated.

#### Returns

True is %GPolyLine% is acceptable as a part of view-specific shape representation being built.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.ViewShapeBuilder.AddPoint(Autodesk.Revit.DB.Point)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.AddPoint(Autodesk.Revit.DB.Point)`

#### Summary

Add a point to the GRep associated to this ViewShapeBuilder.

#### Parameter `GPoint`

The point to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021.1

### `M:Autodesk.Revit.DB.ViewShapeBuilder.AddPolyLine(Autodesk.Revit.DB.PolyLine)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.AddPolyLine(Autodesk.Revit.DB.PolyLine)`

#### Summary

Add a curve to the GRep associated to this ViewShapeBuilder.

#### Parameter `GPolyLine`

The PolyLine to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

GPolyLine is not acceptable for view-specific shape representation that is currently being built.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.ViewShapeBuilder.ValidateShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.DirectShapeTargetViewType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.ValidateShape(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.DirectShapeTargetViewType)`

#### Summary

Validates a shape represented as a collection of geometry objects for use as a view-specific shape.
The objects are expected to be either points, curves or polylines.
Curves are expected to be flat and lie in a plane perpendicular to view normal as defined by view type.

#### Returns

Returns true if %shape% may be used as a view-specific shape representation, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

targetViewType is not DirectShapeTargetViewType::Plan

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `M:Autodesk.Revit.DB.ViewShapeBuilder.ValidateViewType(Autodesk.Revit.DB.DirectShapeTargetViewType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.ValidateViewType(Autodesk.Revit.DB.DirectShapeTargetViewType)`

#### Summary

Validates the incoming view type. As of today, the only allowed view type is Plan.

#### Returns

True if %targetViewType% is DirectShapeTargetViewType::Plan

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.ViewShapeBuilder.ValidateCurve(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.DirectShapeTargetViewType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.ValidateCurve(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.DirectShapeTargetViewType)`

#### Summary

Validates curve to be added to the view-specific shape being constructed. Called by AddCurve() to validate input.
This function may be used to pre-validate the geometry being added to avoid AddCurve() throwing an InvalidArgumentException

#### Remarks

Validation conditions depend on the type of view for which the shape representation is intended.
For plan views, a curve is expected to be planar and non-degenerate (e.g., NOT a circle of zero radius).

#### Parameter `GCurve`

Curve object to be validated.

#### Parameter `targetViewType`

View type for which this curve is intended.

#### Returns

True is %GCurve% is acceptable as a part of view-specific shape representation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.ViewShapeBuilder.ValidateCurve(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.ValidateCurve(Autodesk.Revit.DB.Curve)`

#### Summary

Validates curve to be added to the view-specific shape being constructed. Called by AddCurve() to validate input. Expects a valid view normal to be set prior to the call.

#### Remarks

This function may be used to pre-validate the geometry being added to avoid AddCurve() throwing an InvalidArgumentException
Validation conditions depend on the type of view for which the shape representation is intended.
For plan views, a curve is expected to be planar and non-degenerate (e.g., NOT a circle of zero radius).

#### Parameter `GCurve`

Curve object to be validated.

#### Returns

True is %GCurve% is acceptable as a part of view-specific shape representation being built.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ViewShapeBuilder.AddCurve(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.AddCurve(Autodesk.Revit.DB.Curve)`

#### Summary

Add a curve to the GRep associated to this ViewShapeBuilder.

#### Parameter `GCurve`

The curve to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

GCurve is not acceptable for view-specific shape representation that is currently being built.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ViewShapeBuilder.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.Reset`

#### Summary

Clears the accumulated geometry and resets other ViewShapeBuilder parameters to invalid values.

#### Since

2015

### `P:Autodesk.Revit.DB.ViewShapeBuilder.ViewType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.ViewType`

#### Summary

View type where the view-specific shape currently being built will be used

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `P:Autodesk.Revit.DB.ViewShapeBuilder.ViewNormal`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.ViewNormal`

#### Summary

Normal of the view that will display the shape being built. Must be set explicitly before adding any geometry. Must be a unit vector.
This is used to validate incoming geometry - it must be orthogonal to the viewNormal.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: viewNormal is not length 1.0.

#### Since

2015

### `M:Autodesk.Revit.DB.ViewShapeBuilder.#ctor(Autodesk.Revit.DB.DirectShapeTargetViewType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.#ctor(Autodesk.Revit.DB.DirectShapeTargetViewType)`

#### Summary

A constructor for an ViewShapeBuilder object that takes a view type. It will infer the view normal from view type.
View normal and view type are used to validate the geometry to be stored as a view-specific shape representation of a DirectShape object.

#### Parameter `targetViewType`

View type for which this shape representation is intended. Currently limited to Plan Views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

targetViewType is not DirectShapeTargetViewType::Plan

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.ViewShapeBuilder.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder.#ctor`

#### Summary

Default constructor for an ViewShapeBuilder object.

#### Since

2015

### `T:Autodesk.Revit.DB.ViewShapeBuilder`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewShapeBuilder`

#### Summary

Builds and verifies a view-specific shape representation that would typically be stored in a DirectShape object.
Currently limited to curve-based representations for plan and elevation views.

#### Remarks

The validation functionality is used by DirectShape to validate the incoming shape.

#### Since

2015

### `M:Autodesk.Revit.DB.UpdaterRegistry.GetRegisteredUpdaterInfos`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.GetRegisteredUpdaterInfos`

#### Summary

Returns UpdaterInfos for all the application-wide updaters.

#### Returns

List of UpdaterInfo structures

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.GetRegisteredUpdaterInfos(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.GetRegisteredUpdaterInfos(Autodesk.Revit.DB.Document)`

#### Summary

Returns information about all updaters applicable to the given document.

#### Remarks

The list of data includes information about all updaters explicitly registered
for the document as well as information about all application-wide registered
updaters (which are applicable to all documents).

#### Parameter `document`

The document to which sought updaters are applicable to.

#### Returns

List of UpdaterInfo structures

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.IsUpdaterEnabled(Autodesk.Revit.DB.UpdaterId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.IsUpdaterEnabled(Autodesk.Revit.DB.UpdaterId)`

#### Summary

Checks if the updater is enabled or not.

#### Remarks

Even when an updater is enabled it could still be suspended for misbehaving, in which case it would not
be executed regardless of its enable/disable status.

#### Parameter `id`

The updater id.

#### Returns

Returns true if the updater is enabled, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Updater with this Id is not currently registered in Revit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.UpdaterRegistry.DisableUpdater(Autodesk.Revit.DB.UpdaterId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.DisableUpdater(Autodesk.Revit.DB.UpdaterId)`

#### Summary

Disables the updater.

#### Parameter `id`

The updater id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Updater with this Id is not currently registered in Revit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.UpdaterRegistry.EnableUpdater(Autodesk.Revit.DB.UpdaterId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.EnableUpdater(Autodesk.Revit.DB.UpdaterId)`

#### Summary

Enables the updater.

#### Remarks

Even when an updater is enabled it could still be suspended for misbehaving, in which case it would not
be executed regardless of its enable/disable status.

#### Parameter `id`

The updater id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Updater with this Id is not currently registered in Revit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.UpdaterRegistry.SetIsUpdaterOptional(Autodesk.Revit.DB.UpdaterId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.SetIsUpdaterOptional(Autodesk.Revit.DB.UpdaterId,System.Boolean)`

#### Summary

Sets a flag indicating whether an updater is optional or not.

#### Remarks

This flag controls whether an updater is going to be required next time a document in which
it had been used is opened. If a non-optional updater is not found (currently not registered)
in a document, the end user will be presented with a warning and choices to resolve
the situation.

#### Parameter `id`

Id of the updater

#### Parameter `isOptional`

Use True to make the updater optional, false to make it a mandatory updater.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Updater with this Id is not currently registered in Revit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.GetIsUpdaterOptional(Autodesk.Revit.DB.UpdaterId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.GetIsUpdaterOptional(Autodesk.Revit.DB.UpdaterId)`

#### Summary

Check if the updater is optional or not.

#### Remarks

This flag controls whether an updater is going to be required next time a document in which
it had been used is opened. If a non-optional updater is not found (currently not registered)
in a document, the end user will be presented with a warning and choices to resolve
the situation.

#### Parameter `id`

Id of the updater to check

#### Returns

Returns True if the updater is optional, False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Updater with this Id is not currently registered in Revit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.RemoveDocumentTriggers(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.RemoveDocumentTriggers(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.Document)`

#### Summary

Removes all triggers associated with specified document and Updater
Does not unregister updater.

#### Parameter `id`

Id of specified updater

#### Parameter `document`

Document for which to remove triggers

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The updater's owner's AddIn does not match the currently active AddIn.
-or-
RemoveDocumentTriggers called while executing an updater.

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.RemoveAllTriggers(Autodesk.Revit.DB.UpdaterId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.RemoveAllTriggers(Autodesk.Revit.DB.UpdaterId)`

#### Summary

Removes all triggers associated with Updater with specified UpdaterId.
Does not unregister updater.

#### Parameter `id`

Id of specified updater

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The updater's owner's AddIn does not match the currently active AddIn.
-or-
RemoveAllTriggers called while executing an updater.

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.AddTrigger(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.ElementFilter,Autodesk.Revit.DB.ChangeType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.AddTrigger(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.ElementFilter,Autodesk.Revit.DB.ChangeType)`

#### Summary

Adds trigger with the specified element filter and ChangeType for all documents associated with this Updater

#### Remarks

This method only works with CategoryFilter and ParameterFilter.

#### Parameter `id`

Id of updater that trigger should be added to

#### Parameter `filter`

Element filter that defines elements that affect this trigger

#### Parameter `change`

ChangeType associated with this trigger

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The updater's owner's AddIn does not match the currently active AddIn.
-or-
The id does not correspond to any registered Updaters.
-or-
AddTrigger called while executing an updater.

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.AddTrigger(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementFilter,Autodesk.Revit.DB.ChangeType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.AddTrigger(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementFilter,Autodesk.Revit.DB.ChangeType)`

#### Summary

Adds trigger with the specified element filter and ChangeType for the specified document

#### Remarks

This method only works with CategoryFilter and ParameterFilter.

#### Parameter `id`

Id of updater that trigger should be added to

#### Parameter `document`

Document that elements in 'elements' are contained in

#### Parameter `filter`

Element filter that defines elements that affect this trigger

#### Parameter `change`

ChangeType associated with this trigger

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The updater's owner's AddIn does not match the currently active AddIn.
-or-
The id does not correspond to any registered Updaters
-or-
AddTrigger called while executing an updater.

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.AddTrigger(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ChangeType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.AddTrigger(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ChangeType)`

#### Summary

Adds a trigger to an updater with specified set of elements and ChangeType

#### Parameter `id`

Id of updater that trigger should be added to

#### Parameter `document`

Document that elements in 'elements' are contained in

#### Parameter `elements`

Set of elements which define this trigger

#### Parameter `change`

ChangeType associated with this trigger

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

updater's owner AddIn does not match the currently active AddIn
-or-
id does not correspond to any registered Updaters
-or-
AddTrigger called while executing an updater.

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.SetExecutionOrder(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.UpdaterId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.SetExecutionOrder(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.UpdaterId)`

#### Summary

Forces execution order between two updaters
Execution order: first before second

#### Parameter `first`

Id of first Updater

#### Parameter `second`

Id of second Updater

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or both inputs are not valid UpdaterIds
-or-
One or both of the Updaters are not registered
-or-
first and second are the same id

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The updaters do not report the same ChangePriority

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.IsUpdaterRegistered(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.IsUpdaterRegistered(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.Document)`

#### Summary

Checks whether updater with the given id is registered in a document.

#### Parameter `id`

Id of the updater being tested.

#### Parameter `document`

Document in which this updater is tested whether it's registered or not.

#### Returns

Returns True if the updater is registered in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UpdaterRegistry.IsUpdaterRegistered(Autodesk.Revit.DB.UpdaterId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.IsUpdaterRegistered(Autodesk.Revit.DB.UpdaterId)`

#### Summary

Checks whether updater with the given id is registered

#### Parameter `id`

Id of the updater being tested.

#### Returns

Returns true if the updater is registered.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.UnregisterUpdater(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.UnregisterUpdater(Autodesk.Revit.DB.UpdaterId,Autodesk.Revit.DB.Document)`

#### Summary

Unregisters an updater for the given document.

#### Remarks

Unregistering an updater from a document is only permitted if
the updater was explicitly registered for that document.

If the updater was registered in other documents too,
the remaining documents will still have the updater assigned.

However, if after unregistering from the document the updater is found
not registered in any other (currently open) documents, the updater
will be completely removed from the registry including its triggers.
Should the updater be registered again later, the triggers need
to be re-applied.

#### Parameter `id`

Id of updater to be unregistered.

#### Parameter `document`

Document for which this updater is to be unregistered.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Updater with this Id is not currently registered in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The updater's owner's AddIn does not match the currently active AddIn,
i.e. IUpdater.GetUpdaterId().GetAddInId() differs from the addInId field
in the manifest file of the currently executing external application.
-or-
Attempting to unregister an updater that is currently being executed.

#### Since

2014

### `M:Autodesk.Revit.DB.UpdaterRegistry.UnregisterUpdater(Autodesk.Revit.DB.UpdaterId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.UnregisterUpdater(Autodesk.Revit.DB.UpdaterId)`

#### Summary

Removes the updater associated with the input id from the UpdaterRegistry.
Also removes all triggers associated with the Updater.

#### Remarks

This methods works regardless of how the updater was registered.
Whether the updater was registered application-wide or for a document
(or a set of document), it will be removed from the registry and
any connections with documents will also be lost.

#### Parameter `id`

Id of updater to be removed

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Updater with this Id is not currently registered in Revit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The updater's owner's AddIn does not match the currently active AddIn,
i.e. IUpdater.GetUpdaterId().GetAddInId() differs from the addInId field
in the manifest file of the currently executing external application.
-or-
Attempting to unregister an updater that is currently being executed.

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.RegisterUpdater(Autodesk.Revit.DB.IUpdater,Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.RegisterUpdater(Autodesk.Revit.DB.IUpdater,Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

Registers the updater for a specified document, which means
the updater can only be triggered by changes made in that document.

#### Remarks

An updater may be registered in more then one document, but an updater
may not be registered for a document and also for the entire application at
the same time. If an updater has already been registered application-wide,
an attempt to register it for a document will cause an exception.

#### Parameter `updater`

Updater to be registered.

#### Parameter `document`

Document for which this updater is to be registered.

#### Parameter `isOptional`

This argument controls whether the updater should be required next time a document
is open in which the updater had been previously used. If a non-optional updater is
not found (i.e. currently not registered), the end user will be presented with a warning
and choices to resolve the situation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Updater with the the same Id has already been registered on the application level.
-or-
Updater with the the same Id has already been registered either in the given document or on the application level.
-or-
Updater's Id is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Method is not allowed during execution of a dynamic update.
-or-
The updater's owner's AddIn does not match the currently active AddIn,
i.e. IUpdater.GetUpdaterId().GetAddInId() differs from the addInId field
in the manifest file of the currently executing external application.

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.RegisterUpdater(Autodesk.Revit.DB.IUpdater,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.RegisterUpdater(Autodesk.Revit.DB.IUpdater,System.Boolean)`

#### Summary

Registers an updater application-wide, which means
the updater may get triggered in any open document.

#### Remarks

By registering an updater application-wide, any previous registration explicitly made
for particular documents will be voided. That means the updater will no longer be connected
with just those documents, and the methodIsUpdaterRegistered(id,document) will also
return False. Consequently, any attempt to either register or unregister this updater
to (or from, respectively) a document will cause an exception to be thrown.

#### Parameter `updater`

Updater to be registered

#### Parameter `isOptional`

This argument controls whether the updater should be required next time a document
is open in which the updater had been previously used. If a non-optional updater is
not found (i.e. currently not registered), the end user will be presented with a warning
and choices to resolve the situation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Updater with the the same Id has already been registered on the application level.
-or-
Updater's Id is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Method is not allowed during execution of a dynamic update.
-or-
The updater's owner's AddIn does not match the currently active AddIn,
i.e. IUpdater.GetUpdaterId().GetAddInId() differs from the addInId field
in the manifest file of the currently executing external application.

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.RegisterUpdater(Autodesk.Revit.DB.IUpdater,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.RegisterUpdater(Autodesk.Revit.DB.IUpdater,Autodesk.Revit.DB.Document)`

#### Summary

Registers the updater for a specified document, which means
the updater can only be triggered by changes made in that document.

#### Remarks

An updater may be registered in more than one document, but an updater
may not be registered for a document and also for the entire application at
the same time. If an updater has already been registered application-wide,
an attempt to register it for a document will cause an exception.

#### Parameter `updater`

Updater to be registered

#### Parameter `document`

Document for which this updater is to be registered

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Updater with the the same Id has already been registered on the application level.
-or-
Updater with the the same Id has already been registered either in the given document or on the application level.
-or-
Updater's Id is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Method is not allowed during execution of a dynamic update.
-or-
The updater's owner's AddIn does not match the currently active AddIn,
i.e. IUpdater.GetUpdaterId().GetAddInId() differs from the addInId field
in the manifest file of the currently executing external application.

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterRegistry.RegisterUpdater(Autodesk.Revit.DB.IUpdater)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.RegisterUpdater(Autodesk.Revit.DB.IUpdater)`

#### Summary

Registers an updater application-wide, which means
the updater may get triggered in any open document.

#### Remarks

By registering an updater application-wide, any previous registration explicitly made
for particular documents will be voided. That means the updater will no longer be connected
with just those documents, and the methodIsUpdaterRegistered(id,document) will also
return False. Consequently, any attempt to either register or unregister this updater
to (or from, respectively) a document will cause an exception to be thrown.

#### Parameter `updater`

Updater to be registered

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Updater with the the same Id has already been registered on the application level.
-or-
Updater's Id is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Method is not allowed during execution of a dynamic update.
-or-
The updater's owner's AddIn does not match the currently active AddIn,
i.e. IUpdater.GetUpdaterId().GetAddInId() differs from the addInId field
in the manifest file of the currently executing external application.

#### Since

2011

### `P:Autodesk.Revit.DB.UpdaterRegistry.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.UpdaterRegistry.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.UpdaterRegistry`

Member kind: type
Symbol: `Autodesk.Revit.DB.UpdaterRegistry`

#### Summary

An object that stores and manages all updaters registered in the current session.

#### Remarks

The registry is an application-wide singleton. It maintains all dynamic
updaters currently registered, and also invokes them per their respective
trigger condition during subsequent transactions.

Please note that only the application (an add-in, typically) which registered
an updater is allowed to modify it later, including unregistering it.
Also, an application is not allowed to register an updater with an Id,
that is based on another application's Id.

#### Since

2011

### `P:Autodesk.Revit.DB.UpdaterInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.UpdaterInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.UpdaterInfo.IsOptional`

Member kind: property
Symbol: `Autodesk.Revit.DB.UpdaterInfo.IsOptional`

#### Summary

Whether the updater is optional or not.

#### Since

2012

### `P:Autodesk.Revit.DB.UpdaterInfo.ApplicationName`

Member kind: property
Symbol: `Autodesk.Revit.DB.UpdaterInfo.ApplicationName`

#### Summary

Name of the application that owns the updater.

#### Since

2012

### `P:Autodesk.Revit.DB.UpdaterInfo.AdditionalInformation`

Member kind: property
Symbol: `Autodesk.Revit.DB.UpdaterInfo.AdditionalInformation`

#### Summary

Additional information about the updater.

#### Since

2012

### `P:Autodesk.Revit.DB.UpdaterInfo.UpdaterName`

Member kind: property
Symbol: `Autodesk.Revit.DB.UpdaterInfo.UpdaterName`

#### Summary

Name of the updater.

#### Since

2012

### `T:Autodesk.Revit.DB.UpdaterInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.UpdaterInfo`

#### Summary

Information of an updater, such as: Name, AdditionalInformation, name of the application that owns the updater, etc.

#### Since

2012

### `M:Autodesk.Revit.DB.UpdaterId.GetAddInId`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterId.GetAddInId`

#### Summary

AddInId of the UpdaterId

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterId.GetGUID`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterId.GetGUID`

#### Summary

GUID value of the UpdaterId

#### Since

2011

### `P:Autodesk.Revit.DB.UpdaterId.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.UpdaterId.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.UpdaterId.#ctor(Autodesk.Revit.DB.AddInId,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterId.#ctor(Autodesk.Revit.DB.AddInId,System.Guid)`

#### Summary

creates an instance of UpdaterId for given AddInId and a given GUID value

#### Parameter `addInId`

Id of addin that registers an Updater

#### Parameter `val`

a GUID identifying the Updater within addin

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

addInId is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.UpdaterId`

Member kind: type
Symbol: `Autodesk.Revit.DB.UpdaterId`

#### Summary

A unique identifier of an Updater

#### Remarks

UpdaterID used as a key to register and unregister Updaters and UpdateTriggers in Revit application

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterData.GetDocument`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterData.GetDocument`

#### Summary

Returns document associated with this UpdaterData

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterData.IsChangeTriggered(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ChangeType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterData.IsChangeTriggered(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ChangeType)`

#### Summary

Allows updater to check if specific change has happened to an element.
Compares input type to the types that caused Updater::execute() to be triggered.
If input type was not registered as a trigger for the associated Updater, this
method will always return false for that ChangeType.
For example, if the only trigger registered for UpdaterX is ChangeTypeAny for Element A,
then passing in ChangeTypeGeometry will return false even if the geometry of A changed because
the registered trigger was ChangeTypeAny. However, passing in ChangeTypeAny will return true.

#### Parameter `id`

Id of element to check

#### Parameter `type`

ChangeType to check

#### Returns

True if ChangeType happened to specified element

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterData.GetModifiedElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterData.GetModifiedElementIds`

#### Summary

Returns set of elements that were modified.
This set is mutually exclusive of elements returned by getAddedElementIds() and getDeletedElementIds().

#### Returns

Set of elements that were modified in the document and triggered the call to execute()
Note: This set only contains modified elements (i.e. it is mutually exclusive of elements returned
by getAddedElementIds() and getDeletedElementIds()). It does not contain any elements that were
added to or deleted from the document during the current transaction.
Newly added/deleted elements will be reported by getAddedElementIds()/getDeletedElementIds(),
even if they were also modified during the same transaction, but only if ChangeTypeElementAddition/Deletion
is registered as a trigger for the current Updater. I.e. Element creation and modification in
the same transaction is considered to be "creation" only. Newly created elements are not considered to be
"modified" and are therefore not returned as part of getModifiedElementIds()

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterData.GetDeletedElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterData.GetDeletedElementIds`

#### Summary

Returns set of elements that were deleted from the document.
This set is mutually exclusive of elements returned by getAddedElementIds() and getModifiedElementIds().

#### Returns

Set of elements that were deleted from the document and triggered the call to execute()
Note: This will only return elements if the trigger registered for the associated updater
contains the ChangeType returned by Element::getChangeTypeElementDeletion()

#### Since

2011

### `M:Autodesk.Revit.DB.UpdaterData.GetAddedElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.UpdaterData.GetAddedElementIds`

#### Summary

Returns set of elements newly added to the document.
This set is mutually exclusive of elements returned by getDeletedElementIds() and getModifiedElementIds().

#### Returns

Set of elements that were added to the document and triggered the call to execute()
Note: This will only return elements if the trigger registered for the associated updater
contains the ChangeType returned by Element::getChangeTypeElementAddition()

#### Since

2011

### `P:Autodesk.Revit.DB.UpdaterData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.UpdaterData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.UpdaterData`

Member kind: type
Symbol: `Autodesk.Revit.DB.UpdaterData`

#### Summary

Service class that is passed to an Updater to prove access to update execution context

#### Since

2011

### `M:Autodesk.Revit.DB.IUpdaterProxy.GetAdditionalInformation`

Member kind: method
Symbol: `Autodesk.Revit.DB.IUpdaterProxy.GetAdditionalInformation`

#### Summary

Auxiliary text that Revit will use to inform the end user
when the Updater is not loaded

#### Since

2011

### `M:Autodesk.Revit.DB.IUpdaterProxy.GetUpdaterName`

Member kind: method
Symbol: `Autodesk.Revit.DB.IUpdaterProxy.GetUpdaterName`

#### Summary

Returns a name that the Updater can be identified by to the user

#### Since

2011

### `M:Autodesk.Revit.DB.IUpdaterProxy.GetChangePriority`

Member kind: method
Symbol: `Autodesk.Revit.DB.IUpdaterProxy.GetChangePriority`

#### Summary

Identifies the nature of the change the Updater will be performing
Used to identify order of execution of updaters
Called once during registration of the updater

#### Since

2011

### `M:Autodesk.Revit.DB.IUpdaterProxy.GetUpdaterId`

Member kind: method
Symbol: `Autodesk.Revit.DB.IUpdaterProxy.GetUpdaterId`

#### Summary

Returns globally unique updater id - used to identify the Updater
Called once during registration of the updater

#### Since

2011

### `M:Autodesk.Revit.DB.IUpdaterProxy.Execute(Autodesk.Revit.DB.UpdaterData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IUpdaterProxy.Execute(Autodesk.Revit.DB.UpdaterData)`

#### Summary

The method that Revit will invoke to perform an update.

#### Remarks

The purpose of this method is to allow your updater to react to changes that have been made to the document,
and make appropriate related changes to the same document. Although it can be used to also update data
outside of the document, such changes will not become part of the original transaction and will not be
subject to undo or redo when the original transaction is undone or redone. If you do use this method to
modify data outside of the document, you should also subscribe to the DocumentChanged event to update your
data when the original transaction is undone or redone.

The method is invoked by Revit at the end of a document transaction in which elements that matched
the UpdateTrigger for this Updater were added, changed or deleted. The method may be invoked more than
once for the same transaction due to changes made by other Updaters.

All changes to the document made during the invocation of this method will become a part of the invoking
transaction, and maintained for undo and redo operations. When implementing this method you may not
open any new transactions (an exception will be thrown), but you may use sub-transactions as required.

The following methods may not be called while executing an Updater, because they introduce cross references
between elements. A ForbiddenForDynamicUpdateException will be thrown when an updater attempts to call any
of these methods:
void Autodesk.Revit.DB.ViewSheet.AddView(Autodesk.Revit.DB.View, Autodesk.Revit.DB.UV)Autodesk.Revit.DB.Family Autodesk.Revit.DB.Document.LoadFamily(Autodesk.Revit.DB.Document, Autodesk.Revit.DB.IFamilyLoadOptions)Autodesk.Revit.DB.Structure.AreaReinforcement Autodesk.Revit.Creation.Document.NewAreaReinforcement(Autodesk.Revit.DB.Element, Autodesk.Revit.DB.CurveArray, Autodesk.Revit.DB.XYZ)Autodesk.Revit.DB.Structure.PathReinforcement Autodesk.Revit.Creation.Document.NewPathReinforcement(Autodesk.Revit.DB.Element, Autodesk.Revit.DB.CurveArray, bool)void Autodesk.Revit.DB.MEPSystem.Add(Autodesk.Revit.DB.ConnectorSet)

Although the following methods are allowed during execution of an updater, they can also throw
ForbiddenForDynamicUpdateException when cross-references between elements are established as a result of the
call. One such example could be creating a face wall that intersect with an existing face wall, so those
two would have to be joined together. Apply caution when calling these methods from an updater:
Autodesk.Revit.DB.ElementSet Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstances(System.Collections.Generic.List<Autodesk.Revit.Creation.FamilyInstanceCreationData>)Autodesk.Revit.DB.FamilyInstance Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ, Autodesk.Revit.DB.FamilySymbol, Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)Autodesk.Revit.DB.FamilyInstance Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ, Autodesk.Revit.DB.FamilySymbol, Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)Autodesk.Revit.DB.FamilyInstance Autodesk.Revit.Creation.Document.NewFamilyInstance(Autodesk.Revit.DB.XYZ, Autodesk.Revit.DB.FamilySymbol, Autodesk.Revit.DB.Element, Autodesk.Revit.DB.Level, Autodesk.Revit.DB.Structure.StructuralType)Autodesk.Revit.DB.FaceWall Autodesk.Revit.DB.FaceWall.Create(Autodesk.Revit.DB.Document, Autodesk.Revit.DB.ElementId, Autodesk.Revit.DB.WallLocationLine, Autodesk.Revit.DB.Reference)

Some UI methods may not be called while executing an Updater too, otherwise ForbiddenForDynamicUpdateException will be thrown.
Such methods include: PickObject, PickObjects, PickElementsByRectangle, PickPoint, PickOne and WindowSelect.

Also, most of the methods of the UpdaterRegistry class may not be called during an updater's execution otherwise an InvalidOperationException would be thrown.

In addition to the forbidden methods listed above, other API methods that require documents to be in transaction-free state may not be called either.
Such methods include but are not limited to Save, SaveAs, Close, LoadFamily, etc. Please refer to the documentation of the respective methods for more information.

#### Parameter `data`

Provides all necessary data needed to perform the update, including the document and information about
the changes that triggered the update.

#### Since

2011

### `M:Autodesk.Revit.DB.IUpdater.GetAdditionalInformation`

Member kind: method
Symbol: `Autodesk.Revit.DB.IUpdater.GetAdditionalInformation`

#### Summary

Auxiliary text that Revit will use to inform the end user
when the Updater is not loaded

#### Since

2011

### `M:Autodesk.Revit.DB.IUpdater.GetUpdaterName`

Member kind: method
Symbol: `Autodesk.Revit.DB.IUpdater.GetUpdaterName`

#### Summary

Returns a name that the Updater can be identified by to the user

#### Since

2011

### `M:Autodesk.Revit.DB.IUpdater.GetChangePriority`

Member kind: method
Symbol: `Autodesk.Revit.DB.IUpdater.GetChangePriority`

#### Summary

Identifies the nature of the change the Updater will be performing
Used to identify order of execution of updaters
Called once during registration of the updater

#### Since

2011

### `M:Autodesk.Revit.DB.IUpdater.GetUpdaterId`

Member kind: method
Symbol: `Autodesk.Revit.DB.IUpdater.GetUpdaterId`

#### Summary

Returns globally unique updater id - used to identify the Updater
Called once during registration of the updater

#### Since

2011

### `M:Autodesk.Revit.DB.IUpdater.Execute(Autodesk.Revit.DB.UpdaterData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IUpdater.Execute(Autodesk.Revit.DB.UpdaterData)`

#### Summary

The method that Revit will invoke to perform an update.

#### Remarks

The purpose of this method is to allow your updater to react to changes that have been made to the document,
and make appropriate related changes to the same document. Although it can be used to also update data
outside of the document, such changes will not become part of the original transaction and will not be
subject to undo or redo when the original transaction is undone or redone. If you do use this method to
modify data outside of the document, you should also subscribe to the DocumentChanged event to update your
data when the original transaction is undone or redone.

The method is invoked by Revit at the end of a document transaction in which elements that matched
the UpdateTrigger for this Updater were added, changed or deleted. The method may be invoked more than
once for the same transaction due to changes made by other Updaters.

All changes to the document made during the invocation of this method will become a part of the invoking
transaction, and maintained for undo and redo operations. When implementing this method you may not
open any new transactions (an exception will be thrown), but you may use sub-transactions as required.

The following methods may not be called while executing an Updater, because they introduce cross references
between elements. A ForbiddenForDynamicUpdateException will be thrown when an updater attempts to call any
of these methods:
void Autodesk.Revit.DB.ViewSheet.AddView(Autodesk.Revit.DB.View, Autodesk.Revit.DB.UV)Autodesk.Revit.DB.Family Autodesk.Revit.DB.Document.LoadFamily(Autodesk.Revit.DB.Document, Autodesk.Revit.DB.IFamilyLoadOptions)Autodesk.Revit.DB.Structure.AreaReinforcement Autodesk.Revit.Creation.Document.NewAreaReinforcement(Autodesk.Revit.DB.Element, Autodesk.Revit.DB.CurveArray, Autodesk.Revit.DB.XYZ)Autodesk.Revit.DB.Structure.PathReinforcement Autodesk.Revit.Creation.Document.NewPathReinforcement(Autodesk.Revit.DB.Element, Autodesk.Revit.DB.CurveArray, bool)void Autodesk.Revit.DB.MEPSystem.Add(Autodesk.Revit.DB.ConnectorSet)

Although the following methods are allowed during execution of an updater, they can also throw
ForbiddenForDynamicUpdateException when cross-references between elements are established as a result of the
call. One such example could be creating a face wall that intersect with an existing face wall, so those
two would have to be joined together. Apply caution when calling these methods from an updater:
Autodesk.Revit.DB.ElementSet Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstances(System.Collections.Generic.List<Autodesk.Revit.Creation.FamilyInstanceCreationData>)Autodesk.Revit.DB.FamilyInstance Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ, Autodesk.Revit.DB.FamilySymbol, Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)Autodesk.Revit.DB.FamilyInstance Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ, Autodesk.Revit.DB.FamilySymbol, Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)Autodesk.Revit.DB.FamilyInstance Autodesk.Revit.Creation.Document.NewFamilyInstance(Autodesk.Revit.DB.XYZ, Autodesk.Revit.DB.FamilySymbol, Autodesk.Revit.DB.Element, Autodesk.Revit.DB.Level, Autodesk.Revit.DB.Structure.StructuralType)Autodesk.Revit.DB.FaceWall Autodesk.Revit.DB.FaceWall.Create(Autodesk.Revit.DB.Document, Autodesk.Revit.DB.ElementId, Autodesk.Revit.DB.WallLocationLine, Autodesk.Revit.DB.Reference)

Some UI methods may not be called while executing an Updater too, otherwise ForbiddenForDynamicUpdateException will be thrown.
Such methods include: PickObject, PickObjects, PickElementsByRectangle, PickPoint, PickOne and WindowSelect.

Also, most of the methods of the UpdaterRegistry class may not be called during an updater's execution otherwise an InvalidOperationException would be thrown.

In addition to the forbidden methods listed above, other API methods that require documents to be in transaction-free state may not be called either.
Such methods include but are not limited to Save, SaveAs, Close, LoadFamily, etc. Please refer to the documentation of the respective methods for more information.

#### Parameter `data`

Provides all necessary data needed to perform the update, including the document and information about
the changes that triggered the update.

#### Since

2011

### `T:Autodesk.Revit.DB.IUpdater`

Member kind: type
Symbol: `Autodesk.Revit.DB.IUpdater`

#### Summary

The interface used to create an updater capable of reacting to changes in the Revit model.

#### Remarks

Implement this interface and register an instance of the derived class with the UpdaterRegistry.

#### Since

2011

### `P:Autodesk.Revit.DB.UnitTypeId.WattsPerSquareMeterKelvin`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.WattsPerSquareMeterKelvin`

#### Summary

Watts per square meter kelvin.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.WattsPerSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.WattsPerSquareMeter`

#### Summary

Watts per square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.WattsPerSquareFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.WattsPerSquareFoot`

#### Summary

Watts per square foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.WattsPerMeterKelvin`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.WattsPerMeterKelvin`

#### Summary

Watts per meter kelvin.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.WattsPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.WattsPerMeter`

#### Summary

Watts per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.WattsPerFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.WattsPerFoot`

#### Summary

Watts per foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.WattsPerCubicMeterPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.WattsPerCubicMeterPerSecond`

#### Summary

Watts per cubic meter per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.WattsPerCubicMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.WattsPerCubicMeter`

#### Summary

Watts per cubic meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.WattsPerCubicFootPerMinute`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.WattsPerCubicFootPerMinute`

#### Summary

Watts per cubic foot per minute.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.WattsPerCubicFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.WattsPerCubicFoot`

#### Summary

Watts per cubic foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Watts`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Watts`

#### Summary

Watts.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Volts`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Volts`

#### Summary

Volts.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.VoltAmperesPerSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.VoltAmperesPerSquareMeter`

#### Summary

Volt amperes per square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.VoltAmperesPerSquareFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.VoltAmperesPerSquareFoot`

#### Summary

Volt amperes per square foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.VoltAmperes`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.VoltAmperes`

#### Summary

Volt amperes.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.UsTonnesMass`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.UsTonnesMass`

#### Summary

US tonnes mass.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.UsTonnesForce`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.UsTonnesForce`

#### Summary

US tonnes force.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.UsSurveyFeet`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.UsSurveyFeet`

#### Summary

US survey feet.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.UsGallonsPerMinute`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.UsGallonsPerMinute`

#### Summary

US gallons per minute.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.UsGallonsPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.UsGallonsPerHour`

#### Summary

US gallons per hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.UsGallons`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.UsGallons`

#### Summary

US gallons.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.TonsOfRefrigeration`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.TonsOfRefrigeration`

#### Summary

Tons of refrigeration.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.TonnesForcePerSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.TonnesForcePerSquareMeter`

#### Summary

Tonnes force per square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.TonnesForcePerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.TonnesForcePerMeter`

#### Summary

Tonnes force per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.TonnesForce`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.TonnesForce`

#### Summary

Tonnes force.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Tonnes`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Tonnes`

#### Summary

Tonnes.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.TonneForceMetersPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.TonneForceMetersPerMeter`

#### Summary

Tonne force meters per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.TonneForceMeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.TonneForceMeters`

#### Summary

Tonne force meters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.ThousandBritishThermalUnitsPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.ThousandBritishThermalUnitsPerHour`

#### Summary

Thousand British thermal units per hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Therms`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Therms`

#### Summary

Therms.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareMillimetersPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareMillimetersPerMeter`

#### Summary

Square millimeters per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareMillimeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareMillimeters`

#### Summary

Square millimeters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareMetersPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareMetersPerSecond`

#### Summary

Square meters per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareMetersPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareMetersPerMeter`

#### Summary

Square meters per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareMetersPerKilowatt`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareMetersPerKilowatt`

#### Summary

Square meters per kilowatt.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareMetersPerKilonewton`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareMetersPerKilonewton`

#### Summary

Square meters per kilonewton.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareMeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareMeters`

#### Summary

Square meters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareMeterKelvinsPerWatt`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareMeterKelvinsPerWatt`

#### Summary

Square meter kelvins per watt.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareInchesPerFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareInchesPerFoot`

#### Summary

Square inches per foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareInches`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareInches`

#### Summary

Square inches.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareFeetPerTonOfRefrigeration`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareFeetPerTonOfRefrigeration`

#### Summary

Square feet per ton of refrigeration.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareFeetPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareFeetPerSecond`

#### Summary

Square feet per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareFeetPerKip`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareFeetPerKip`

#### Summary

Square feet per kip.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareFeetPerFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareFeetPerFoot`

#### Summary

Square feet per foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareFeetPer1000BritishThermalUnitsPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareFeetPer1000BritishThermalUnitsPerHour`

#### Summary

Square feet per thousand British thermal units per hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareFeet`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareFeet`

#### Summary

Square feet.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareCentimetersPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareCentimetersPerMeter`

#### Summary

Square centimeters per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SquareCentimeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SquareCentimeters`

#### Summary

Square centimeters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Seconds`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Seconds`

#### Summary

Seconds.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.RiseDividedBy1Foot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.RiseDividedBy1Foot`

#### Summary

Rise / 1 foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.RiseDividedBy12Inches`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.RiseDividedBy12Inches`

#### Summary

Rise / 12 inches.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.RiseDividedBy120Inches`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.RiseDividedBy120Inches`

#### Summary

Rise / 120 inches.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.RiseDividedBy10Feet`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.RiseDividedBy10Feet`

#### Summary

Rise / 10 feet.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.RiseDividedBy1000Millimeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.RiseDividedBy1000Millimeters`

#### Summary

Rise / 1000 millimeters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.RevolutionsPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.RevolutionsPerSecond`

#### Summary

Revolutions per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.RevolutionsPerMinute`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.RevolutionsPerMinute`

#### Summary

Revolutions per minute.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.RatioTo12`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.RatioTo12`

#### Summary

Ratio : 12.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.RatioTo10`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.RatioTo10`

#### Summary

Ratio : 10.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.RatioTo1`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.RatioTo1`

#### Summary

Ratio : 1.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.RankineInterval`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.RankineInterval`

#### Summary

Rankine interval.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Rankine`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Rankine`

#### Summary

Rankine.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.RadiansPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.RadiansPerSecond`

#### Summary

Radians per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Radians`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Radians`

#### Summary

Radians.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsMassPerSquareFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsMassPerSquareFoot`

#### Summary

Pounds mass per square foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsMassPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsMassPerSecond`

#### Summary

Pounds mass per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsMassPerPoundDegreeFahrenheit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsMassPerPoundDegreeFahrenheit`

#### Summary

Pounds mass per pound degree Fahrenheit.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsMassPerMinute`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsMassPerMinute`

#### Summary

Pounds mass per minute.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsMassPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsMassPerHour`

#### Summary

Pounds mass per hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsMassPerFootSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsMassPerFootSecond`

#### Summary

Pounds mass per foot second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsMassPerFootHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsMassPerFootHour`

#### Summary

Pounds mass per foot hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsMassPerFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsMassPerFoot`

#### Summary

Pounds mass per foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsMassPerCubicInch`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsMassPerCubicInch`

#### Summary

Pounds mass per cubic inch.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsMassPerCubicFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsMassPerCubicFoot`

#### Summary

Pounds mass per cubic foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsMass`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsMass`

#### Summary

Pounds mass.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsForcePerSquareInch`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsForcePerSquareInch`

#### Summary

Pounds force per square inch.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsForcePerSquareFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsForcePerSquareFoot`

#### Summary

Pounds force per square foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsForcePerFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsForcePerFoot`

#### Summary

Pounds force per foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsForcePerCubicFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsForcePerCubicFoot`

#### Summary

Pounds force per cubic foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundsForce`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundsForce`

#### Summary

Pounds force.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundForceSecondsPerSquareFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundForceSecondsPerSquareFoot`

#### Summary

Pound force seconds per square foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundForceFeetPerFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundForceFeetPerFoot`

#### Summary

Pound force feet per foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PoundForceFeet`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PoundForceFeet`

#### Summary

Pound force feet.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Pi`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Pi`

#### Summary

Multiples of Ï€.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Percentage`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Percentage`

#### Summary

Percentage.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PerMille`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PerMille`

#### Summary

Per mille.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PascalsPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PascalsPerMeter`

#### Summary

Pascals per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Pascals`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Pascals`

#### Summary

Pascals.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.PascalSeconds`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.PascalSeconds`

#### Summary

Pascal seconds.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.OneToRatio`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.OneToRatio`

#### Summary

1 : Ratio.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.OhmMeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.OhmMeters`

#### Summary

Ohm meters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.NewtonsPerSquareMillimeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.NewtonsPerSquareMillimeter`

#### Summary

Newtons per square millimeter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.NewtonsPerSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.NewtonsPerSquareMeter`

#### Summary

Newtons per square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.NewtonsPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.NewtonsPerMeter`

#### Summary

Newtons per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Newtons`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Newtons`

#### Summary

Newtons.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.NewtonSecondsPerSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.NewtonSecondsPerSquareMeter`

#### Summary

Newton seconds per square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.NewtonMetersPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.NewtonMetersPerMeter`

#### Summary

Newton meters per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.NewtonMeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.NewtonMeters`

#### Summary

Newton meters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.NanogramsPerPascalSecondSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.NanogramsPerPascalSecondSquareMeter`

#### Summary

Nanograms per pascal second square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Minutes`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Minutes`

#### Summary

Minutes.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Millivolts`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Millivolts`

#### Summary

Millivolts.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Milliseconds`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Milliseconds`

#### Summary

Milliseconds.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MillimetersToTheSixthPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MillimetersToTheSixthPower`

#### Summary

Millimeters to the sixth power.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MillimetersToTheFourthPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MillimetersToTheFourthPower`

#### Summary

Millimeters to the fourth power.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MillimetersOfWaterColumnPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MillimetersOfWaterColumnPerMeter`

#### Summary

Millimeters of water column per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MillimetersOfWaterColumn`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MillimetersOfWaterColumn`

#### Summary

Millimeters of water column.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MillimetersOfMercury`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MillimetersOfMercury`

#### Summary

Millimeters of mercury.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Millimeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Millimeters`

#### Summary

Millimeters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Milliamperes`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Milliamperes`

#### Summary

Milliamperes.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MilesPerSecondSquared`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MilesPerSecondSquared`

#### Summary

Miles per second squared.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MilesPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MilesPerHour`

#### Summary

Miles per hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MicrometersPerMeterDegreeCelsius`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MicrometersPerMeterDegreeCelsius`

#### Summary

Micrometers per meter degree Celsius.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MicroinchesPerInchDegreeFahrenheit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MicroinchesPerInchDegreeFahrenheit`

#### Summary

Microinches per inch degree Fahrenheit.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MetersToTheSixthPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MetersToTheSixthPower`

#### Summary

Meters to the sixth power.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MetersToTheFourthPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MetersToTheFourthPower`

#### Summary

Meters to the fourth power.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MetersPerSecondSquared`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MetersPerSecondSquared`

#### Summary

Meters per second squared.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MetersPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MetersPerSecond`

#### Summary

Meters per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MetersPerKilonewton`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MetersPerKilonewton`

#### Summary

Meters per kilonewton.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MetersOfWaterColumnPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MetersOfWaterColumnPerMeter`

#### Summary

Meters of water column per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MetersOfWaterColumn`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MetersOfWaterColumn`

#### Summary

Meters of water column.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Meters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Meters`

#### Summary

Meters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Megapascals`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Megapascals`

#### Summary

Megapascals.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MeganewtonsPerSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MeganewtonsPerSquareMeter`

#### Summary

Meganewtons per square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MeganewtonsPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MeganewtonsPerMeter`

#### Summary

Meganewtons per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Meganewtons`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Meganewtons`

#### Summary

Meganewtons.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MeganewtonMetersPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MeganewtonMetersPerMeter`

#### Summary

Meganewton meters per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MeganewtonMeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MeganewtonMeters`

#### Summary

Meganewton meters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Lux`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Lux`

#### Summary

Lux.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.LumensPerWatt`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.LumensPerWatt`

#### Summary

Lumens per watt.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Lumens`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Lumens`

#### Summary

Lumens.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.LitersPerSecondSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.LitersPerSecondSquareMeter`

#### Summary

Liters per second square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.LitersPerSecondKilowatt`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.LitersPerSecondKilowatt`

#### Summary

Liters per second kilowatt.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.LitersPerSecondCubicMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.LitersPerSecondCubicMeter`

#### Summary

Liters per second cubic meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.LitersPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.LitersPerSecond`

#### Summary

Liters per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.LitersPerMinute`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.LitersPerMinute`

#### Summary

Liters per minute.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.LitersPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.LitersPerHour`

#### Summary

Liters per hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Liters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Liters`

#### Summary

Liters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KipsPerSquareInch`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KipsPerSquareInch`

#### Summary

Kips per square inch.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KipsPerSquareFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KipsPerSquareFoot`

#### Summary

Kips per square foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KipsPerInch`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KipsPerInch`

#### Summary

Kips per inch.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KipsPerFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KipsPerFoot`

#### Summary

Kips per foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KipsPerCubicInch`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KipsPerCubicInch`

#### Summary

Kips per cubic inch.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KipsPerCubicFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KipsPerCubicFoot`

#### Summary

Kips per cubic foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Kips`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Kips`

#### Summary

Kips.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KipFeetPerFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KipFeetPerFoot`

#### Summary

Kip feet per foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KipFeetPerDegreePerFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KipFeetPerDegreePerFoot`

#### Summary

Kip feet per degree per foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KipFeetPerDegree`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KipFeetPerDegree`

#### Summary

Kip feet per degree.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KipFeet`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KipFeet`

#### Summary

Kip feet.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Kilowatts`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Kilowatts`

#### Summary

Kilowatts.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilowattHours`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilowattHours`

#### Summary

Kilowatt hours.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Kilovolts`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Kilovolts`

#### Summary

Kilovolts.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilovoltAmperes`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilovoltAmperes`

#### Summary

Kilovolt amperes.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Kilopascals`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Kilopascals`

#### Summary

Kilopascals.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilonewtonsPerSquareMillimeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilonewtonsPerSquareMillimeter`

#### Summary

Kilonewtons per square millimeter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilonewtonsPerSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilonewtonsPerSquareMeter`

#### Summary

Kilonewtons per square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilonewtonsPerSquareCentimeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilonewtonsPerSquareCentimeter`

#### Summary

Kilonewtons per square centimeter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilonewtonsPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilonewtonsPerMeter`

#### Summary

Kilonewtons per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilonewtonsPerCubicMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilonewtonsPerCubicMeter`

#### Summary

Kilonewtons per cubic meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Kilonewtons`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Kilonewtons`

#### Summary

Kilonewtons.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilonewtonMetersPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilonewtonMetersPerMeter`

#### Summary

Kilonewton meters per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilonewtonMetersPerDegreePerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilonewtonMetersPerDegreePerMeter`

#### Summary

Kilonewton meters per degree per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilonewtonMetersPerDegree`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilonewtonMetersPerDegree`

#### Summary

Kilonewton meters per degree.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilonewtonMeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilonewtonMeters`

#### Summary

Kilonewton meters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilometersPerSecondSquared`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilometersPerSecondSquared`

#### Summary

Kilometers per second squared.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilometersPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilometersPerHour`

#### Summary

Kilometers per hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilojoulesPerSquareMeterKelvin`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilojoulesPerSquareMeterKelvin`

#### Summary

Kilojoules per square meter Kelvin.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilojoulesPerKelvin`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilojoulesPerKelvin`

#### Summary

Kilojoules per Kelvin.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Kilojoules`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Kilojoules`

#### Summary

Kilojoules.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramsPerSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramsPerSquareMeter`

#### Summary

Kilograms per square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramsPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramsPerSecond`

#### Summary

Kilograms per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramsPerMinute`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramsPerMinute`

#### Summary

Kilograms per minute.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramsPerMeterSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramsPerMeterSecond`

#### Summary

Kilograms per meter second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramsPerMeterHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramsPerMeterHour`

#### Summary

Kilograms per meter hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramsPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramsPerMeter`

#### Summary

Kilograms per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramsPerKilogramKelvin`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramsPerKilogramKelvin`

#### Summary

Kilograms per kilogram kelvin.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramsPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramsPerHour`

#### Summary

Kilograms per hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramsPerCubicMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramsPerCubicMeter`

#### Summary

Kilograms per cubic meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramsForcePerSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramsForcePerSquareMeter`

#### Summary

Kilograms force per square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramsForcePerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramsForcePerMeter`

#### Summary

Kilograms force per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramsForce`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramsForce`

#### Summary

Kilograms force.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Kilograms`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Kilograms`

#### Summary

Kilograms.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramForceMetersPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramForceMetersPerMeter`

#### Summary

Kilogram force meters per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilogramForceMeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilogramForceMeters`

#### Summary

Kilogram force meters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KilocaloriesPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KilocaloriesPerSecond`

#### Summary

Kilocalories per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Kilocalories`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Kilocalories`

#### Summary

Kilocalories.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Kiloamperes`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Kiloamperes`

#### Summary

Kiloamperes.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.KelvinInterval`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.KelvinInterval`

#### Summary

Kelvin interval.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Kelvin`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Kelvin`

#### Summary

Kelvin.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.JoulesPerSquareMeterKelvin`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.JoulesPerSquareMeterKelvin`

#### Summary

Joules per square meter Kelvin.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.JoulesPerKilogramDegreeCelsius`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.JoulesPerKilogramDegreeCelsius`

#### Summary

Joules per kilogram degree Celsius.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.JoulesPerKelvin`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.JoulesPerKelvin`

#### Summary

Joules per Kelvin.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.JoulesPerGramDegreeCelsius`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.JoulesPerGramDegreeCelsius`

#### Summary

Joules per gram degree Celsius.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.JoulesPerGram`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.JoulesPerGram`

#### Summary

Joules per gram.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Joules`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Joules`

#### Summary

Joules.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.InverseKips`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.InverseKips`

#### Summary

Inverse kips.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.InverseKilonewtons`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.InverseKilonewtons`

#### Summary

Inverse kilonewtons.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.InverseDegreesFahrenheit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.InverseDegreesFahrenheit`

#### Summary

Inverse degrees Fahrenheit.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.InverseDegreesCelsius`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.InverseDegreesCelsius`

#### Summary

Inverse degrees Celsius.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.InchesToTheSixthPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.InchesToTheSixthPower`

#### Summary

Inches to the sixth power.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.InchesToTheFourthPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.InchesToTheFourthPower`

#### Summary

Inches to the fourth power.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.InchesPerSecondSquared`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.InchesPerSecondSquared`

#### Summary

Inches per second squared.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.InchesOfWater60DegreesFahrenheitPer100Feet`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.InchesOfWater60DegreesFahrenheitPer100Feet`

#### Summary

Inches of water (60 Â°F) per 100 feet.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.InchesOfWater60DegreesFahrenheit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.InchesOfWater60DegreesFahrenheit`

#### Summary

Inches of water (60 Â°F).

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.InchesOfMercury32DegreesFahrenheit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.InchesOfMercury32DegreesFahrenheit`

#### Summary

Inches of mercury (32 Â°F).

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Inches`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Inches`

#### Summary

Inches.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Hours`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Hours`

#### Summary

Hours.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.HourSquareFootDegreesFahrenheitPerBritishThermalUnit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.HourSquareFootDegreesFahrenheitPerBritishThermalUnit`

#### Summary

Hour square foot degrees Fahrenheit per British thermal unit.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Horsepower`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Horsepower`

#### Summary

Horsepower.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Hertz`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Hertz`

#### Summary

Hertz.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Hectares`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Hectares`

#### Summary

Hectares.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.GrainsPerHourSquareFootInchMercury`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.GrainsPerHourSquareFootInchMercury`

#### Summary

Grains per hour square foot inch mercury.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Gradians`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Gradians`

#### Summary

Gradians.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.General`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.General`

#### Summary

General.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Footlamberts`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Footlamberts`

#### Summary

Footlamberts.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Footcandles`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Footcandles`

#### Summary

Footcandles.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Fixed`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Fixed`

#### Summary

Fixed.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.FeetToTheSixthPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.FeetToTheSixthPower`

#### Summary

Feet to the sixth power.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.FeetToTheFourthPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.FeetToTheFourthPower`

#### Summary

Feet to the fourth power.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.FeetPerSecondSquared`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.FeetPerSecondSquared`

#### Summary

Feet per second squared.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.FeetPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.FeetPerSecond`

#### Summary

Feet per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.FeetPerMinute`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.FeetPerMinute`

#### Summary

Feet per minute.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.FeetPerKip`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.FeetPerKip`

#### Summary

Feet per kip.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.FeetOfWater39_2DegreesFahrenheitPer100Feet`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.FeetOfWater39_2DegreesFahrenheitPer100Feet`

#### Summary

Feet of water (39.2 Â°F) per 100 feet.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.FeetOfWater39_2DegreesFahrenheit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.FeetOfWater39_2DegreesFahrenheit`

#### Summary

Feet of water (39.2 Â°F).

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Feet`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Feet`

#### Summary

Feet.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.FahrenheitInterval`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.FahrenheitInterval`

#### Summary

Fahrenheit interval.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Fahrenheit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Fahrenheit`

#### Summary

Fahrenheit.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.DekanewtonsPerSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.DekanewtonsPerSquareMeter`

#### Summary

Dekanewtons per square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.DekanewtonsPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.DekanewtonsPerMeter`

#### Summary

Dekanewtons per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Dekanewtons`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Dekanewtons`

#### Summary

Dekanewtons.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.DekanewtonMetersPerMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.DekanewtonMetersPerMeter`

#### Summary

Dekanewton meters per meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.DekanewtonMeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.DekanewtonMeters`

#### Summary

Dekanewton meters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Degrees`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Degrees`

#### Summary

Degrees.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Decimeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Decimeters`

#### Summary

Decimeters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CyclesPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CyclesPerSecond`

#### Summary

Cycles per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CurrencyPerWattHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CurrencyPerWattHour`

#### Summary

Cost per watt hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CurrencyPerWatt`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CurrencyPerWatt`

#### Summary

Cost per watt.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CurrencyPerSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CurrencyPerSquareMeter`

#### Summary

Cost per square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CurrencyPerSquareFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CurrencyPerSquareFoot`

#### Summary

Cost per square foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CurrencyPerBritishThermalUnitPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CurrencyPerBritishThermalUnitPerHour`

#### Summary

Cost per British thermal unit per hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CurrencyPerBritishThermalUnit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CurrencyPerBritishThermalUnit`

#### Summary

Cost per British thermal unit.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Currency`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Currency`

#### Summary

Currency.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicYards`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicYards`

#### Summary

Cubic yards.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicMillimeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicMillimeters`

#### Summary

Cubic millimeters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicMetersPerWattSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicMetersPerWattSecond`

#### Summary

Cubic meters per watt second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicMetersPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicMetersPerSecond`

#### Summary

Cubic meters per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicMetersPerKilonewton`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicMetersPerKilonewton`

#### Summary

Cubic meters per kilonewton.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicMetersPerKilogram`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicMetersPerKilogram`

#### Summary

Cubic meters per kilogram.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicMetersPerHourSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicMetersPerHourSquareMeter`

#### Summary

Cubic meters per hour square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicMetersPerHourCubicMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicMetersPerHourCubicMeter`

#### Summary

Cubic meters per hour cubic meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicMetersPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicMetersPerHour`

#### Summary

Cubic meters per hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicMeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicMeters`

#### Summary

Cubic meters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicInches`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicInches`

#### Summary

Cubic inches.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicFeetPerPoundMass`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicFeetPerPoundMass`

#### Summary

Cubic feet per pound mass.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicFeetPerMinuteTonOfRefrigeration`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicFeetPerMinuteTonOfRefrigeration`

#### Summary

Cubic feet per minute ton of refrigeration.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicFeetPerMinuteSquareFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicFeetPerMinuteSquareFoot`

#### Summary

Cubic feet per minute square foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicFeetPerMinutePerBritishThermalUnitPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicFeetPerMinutePerBritishThermalUnitPerHour`

#### Summary

Cubic feet per minute per British thermal unit per hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicFeetPerMinuteCubicFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicFeetPerMinuteCubicFoot`

#### Summary

Cubic feet per minute cubic foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicFeetPerMinute`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicFeetPerMinute`

#### Summary

Cubic feet per minute.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicFeetPerKip`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicFeetPerKip`

#### Summary

Cubic feet per kip.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicFeetPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicFeetPerHour`

#### Summary

Cubic feet per hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicFeet`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicFeet`

#### Summary

Cubic feet.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CubicCentimeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CubicCentimeters`

#### Summary

Cubic centimeters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Centipoises`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Centipoises`

#### Summary

Centipoises.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CentimetersToTheSixthPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CentimetersToTheSixthPower`

#### Summary

Centimeters to the sixth power.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CentimetersToTheFourthPower`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CentimetersToTheFourthPower`

#### Summary

Centimeters to the fourth power.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CentimetersPerMinute`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CentimetersPerMinute`

#### Summary

Centimeters per minute.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Centimeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Centimeters`

#### Summary

Centimeters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CelsiusInterval`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CelsiusInterval`

#### Summary

Celsius interval.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Celsius`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Celsius`

#### Summary

Celsius.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CandelasPerSquareMeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CandelasPerSquareMeter`

#### Summary

Candelas per square meter.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CandelasPerSquareFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CandelasPerSquareFoot`

#### Summary

Candelas per square foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Candelas`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Candelas`

#### Summary

Candelas.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.CaloriesPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.CaloriesPerSecond`

#### Summary

Calories per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Calories`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Calories`

#### Summary

Calories.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerSquareFootDegreeFahrenheit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerSquareFootDegreeFahrenheit`

#### Summary

British thermal units per square foot degree Fahrenheit.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerSecond`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerSecond`

#### Summary

British thermal units per second.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerPoundDegreeFahrenheit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerPoundDegreeFahrenheit`

#### Summary

British thermal units per pound degree Fahrenheit.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerPound`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerPound`

#### Summary

British thermal units per pound.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerHourSquareFootDegreeFahrenheit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerHourSquareFootDegreeFahrenheit`

#### Summary

British thermal units per hour square foot degree Fahrenheit.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerHourSquareFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerHourSquareFoot`

#### Summary

British thermal units per hour square foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerHourFootDegreeFahrenheit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerHourFootDegreeFahrenheit`

#### Summary

British thermal units per hour foot degree Fahrenheit.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerHourCubicFoot`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerHourCubicFoot`

#### Summary

British thermal units per hour cubic foot.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerHour`

#### Summary

British thermal units per hour.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerDegreeFahrenheit`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.BritishThermalUnitsPerDegreeFahrenheit`

#### Summary

British thermal units per degree Fahrenheit.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.BritishThermalUnits`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.BritishThermalUnits`

#### Summary

British thermal units.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Bars`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Bars`

#### Summary

Bars.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Atmospheres`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Atmospheres`

#### Summary

Atmospheres.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Amperes`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Amperes`

#### Summary

Amperes.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Acres`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Acres`

#### Summary

Acres.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.StationingSurveyFeet`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.StationingSurveyFeet`

#### Summary

US survey feet.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.StationingMeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.StationingMeters`

#### Summary

Meters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.StationingFeet`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.StationingFeet`

#### Summary

Feet.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.SlopeDegrees`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.SlopeDegrees`

#### Summary

Degrees.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.MetersCentimeters`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.MetersCentimeters`

#### Summary

Meters and centimeters.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.FractionalInches`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.FractionalInches`

#### Summary

Fractional inches.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.FeetFractionalInches`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.FeetFractionalInches`

#### Summary

Feet and fractional inches.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.DegreesMinutes`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.DegreesMinutes`

#### Summary

Degrees minutes seconds.

#### Since

2021

### `P:Autodesk.Revit.DB.UnitTypeId.Custom`

Member kind: property
Symbol: `Autodesk.Revit.DB.UnitTypeId.Custom`

#### Summary

Unrecognized custom unit.

#### Since

2021

### `T:Autodesk.Revit.DB.UnitTypeId`

Member kind: type
Symbol: `Autodesk.Revit.DB.UnitTypeId`

#### Summary

This class contains constants identifying units of measurement.

#### Since

2021

### `M:Autodesk.Revit.DB.ValueParsingOptions.GetFormatOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.ValueParsingOptions.GetFormatOptions`

#### Summary

Gets the FormatOptions to optionally override the default settings in the Units class.

#### Remarks

By default, the FormatOptions represents default formatting
(UseDefault is true) and the FormatOptions in the Units class will
be used.

#### Returns

A copy of the FormatOptions.

#### Since

2014

### `M:Autodesk.Revit.DB.ValueParsingOptions.SetFormatOptions(Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ValueParsingOptions.SetFormatOptions(Autodesk.Revit.DB.FormatOptions)`

#### Summary

Sets the FormatOptions to optionally override the default settings in the Units class.

#### Remarks

By default, the FormatOptions represents default formatting
(UseDefault is true) and the FormatOptions in the Units class will
be used.

#### Parameter `formatOptions`

The FormatOptions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ValueParsingOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ValueParsingOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ValueParsingOptions.AllowedValues`

Member kind: property
Symbol: `Autodesk.Revit.DB.ValueParsingOptions.AllowedValues`

#### Summary

The allowable range of values to be parsed.

#### Value

The allowable range of values. The default is All.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.ValueParsingOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ValueParsingOptions.#ctor`

#### Summary

Creates a new ValueParsingOptions object with default settings.

#### Since

2014

### `T:Autodesk.Revit.DB.ValueParsingOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ValueParsingOptions`

#### Summary

Options for parsing strings into numbers with units.

#### Since

2014

### `M:Autodesk.Revit.DB.UnitFormatUtils.TryParse(Autodesk.Revit.DB.Units,Autodesk.Revit.DB.ForgeTypeId,System.String,System.Double@,System.String@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitFormatUtils.TryParse(Autodesk.Revit.DB.Units,Autodesk.Revit.DB.ForgeTypeId,System.String,System.Double@,System.String@)`

#### Summary

Parses a formatted string into a number with units if possible.

#### Parameter `units`

The units formatting settings, typically obtained from `M:Autodesk.Revit.DB.Document.GetUnits` .

#### Parameter `specTypeId`

Identifier of the target spec for the value.

#### Parameter `stringToParse`

The string to parse.

#### Parameter `value`

The parsed value. Ignore this value if the function returns false.

#### Parameter `message`

A localized message that, if the parsing fails, explains the reason for failure.

#### Returns

True if the string can be parsed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitFormatUtils.TryParse(Autodesk.Revit.DB.Units,Autodesk.Revit.DB.ForgeTypeId,System.String,System.Double@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitFormatUtils.TryParse(Autodesk.Revit.DB.Units,Autodesk.Revit.DB.ForgeTypeId,System.String,System.Double@)`

#### Summary

Parses a formatted string into a number with units if possible.

#### Parameter `units`

The units formatting settings, typically obtained from `M:Autodesk.Revit.DB.Document.GetUnits` .

#### Parameter `specTypeId`

Identifier of the target spec for the value.

#### Parameter `stringToParse`

The string to parse.

#### Parameter `value`

The parsed value. Ignore this value if the function returns false.

#### Returns

True if the string can be parsed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitFormatUtils.TryParse(Autodesk.Revit.DB.Units,Autodesk.Revit.DB.ForgeTypeId,System.String,Autodesk.Revit.DB.ValueParsingOptions,System.Double@,System.String@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitFormatUtils.TryParse(Autodesk.Revit.DB.Units,Autodesk.Revit.DB.ForgeTypeId,System.String,Autodesk.Revit.DB.ValueParsingOptions,System.Double@,System.String@)`

#### Summary

Parses a formatted string into a number with units if possible.

#### Parameter `units`

The units formatting settings, typically obtained from `M:Autodesk.Revit.DB.Document.GetUnits` .

#### Parameter `specTypeId`

Identifier of the target spec for the value.

#### Parameter `stringToParse`

The string to parse.

#### Parameter `valueParsingOptions`

Additional parsing options.

#### Parameter `value`

The parsed value. Ignore this value if the function returns false.

#### Parameter `message`

A localized message that, if the parsing fails, explains the reason for failure.

#### Returns

True if the string can be parsed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).
-or-
The unit in the FormatOptions in valueParsingOptions is not a valid unit for specTypeId. See UnitUtils.IsValidUnit(ForgeTypeId, ForgeTypeId) and UnitUtils.GetValidUnits(ForgeTypeId).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitFormatUtils.TryParse(Autodesk.Revit.DB.Units,Autodesk.Revit.DB.ForgeTypeId,System.String,Autodesk.Revit.DB.ValueParsingOptions,System.Double@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitFormatUtils.TryParse(Autodesk.Revit.DB.Units,Autodesk.Revit.DB.ForgeTypeId,System.String,Autodesk.Revit.DB.ValueParsingOptions,System.Double@)`

#### Summary

Parses a formatted string into a number with units if possible.

#### Parameter `units`

The units formatting settings, typically obtained from `M:Autodesk.Revit.DB.Document.GetUnits` .

#### Parameter `specTypeId`

Identifier of the target spec for the value.

#### Parameter `stringToParse`

The string to parse.

#### Parameter `valueParsingOptions`

Additional parsing options.

#### Parameter `value`

The parsed value. Ignore this value if the function returns false.

#### Returns

True if the string can be parsed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).
-or-
The unit in the FormatOptions in valueParsingOptions is not a valid unit for specTypeId. See UnitUtils.IsValidUnit(ForgeTypeId, ForgeTypeId) and UnitUtils.GetValidUnits(ForgeTypeId).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitFormatUtils.Format(Autodesk.Revit.DB.Units,Autodesk.Revit.DB.ForgeTypeId,System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitFormatUtils.Format(Autodesk.Revit.DB.Units,Autodesk.Revit.DB.ForgeTypeId,System.Double,System.Boolean)`

#### Summary

Formats a number with units into a string.

#### Parameter `units`

The units formatting settings, typically obtained from `M:Autodesk.Revit.DB.Document.GetUnits` .

#### Parameter `specTypeId`

Identifier of the spec of the value to format.

#### Parameter `value`

The value to format, in Revit's internal units.

#### Parameter `forEditing`

True if the formatting should be modified as necessary so that the formatted string can be successfully parsed, for example by suppressing digit grouping. False if unmodified settings should be used, suitable for display only.

#### Returns

The formatted string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).
-or-
The given value for value is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitFormatUtils.Format(Autodesk.Revit.DB.Units,Autodesk.Revit.DB.ForgeTypeId,System.Double,System.Boolean,Autodesk.Revit.DB.FormatValueOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitFormatUtils.Format(Autodesk.Revit.DB.Units,Autodesk.Revit.DB.ForgeTypeId,System.Double,System.Boolean,Autodesk.Revit.DB.FormatValueOptions)`

#### Summary

Formats a number with units into a string.

#### Parameter `units`

The units formatting settings, typically obtained from `M:Autodesk.Revit.DB.Document.GetUnits` .

#### Parameter `specTypeId`

Identifier of the spec of the value to format.

#### Parameter `value`

The value to format, in Revit's internal units.

#### Parameter `forEditing`

True if the formatting should be modified as necessary so that the formatted string can be successfully parsed, for example by suppressing digit grouping. False if unmodified settings should be used, suitable for display only.

#### Parameter `formatValueOptions`

Additional formatting options.

#### Returns

The formatted string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).
-or-
The given value for value is not finite
-or-
The unit in the FormatOptions in formatValueOptions is not a valid unit for specTypeId. See UnitUtils.IsValidUnit(ForgeTypeId, ForgeTypeId) and UnitUtils.GetValidUnits(ForgeTypeId).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.UnitFormatUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.UnitFormatUtils`

#### Summary

A utility class for formatting and parsing numbers with units.

#### Since

2014

### `P:Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureVRepeat`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureVRepeat`

#### Summary

The property labeled "V Repeat" from the "UnifiedBitmap" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018

### `P:Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureURepeat`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureURepeat`

#### Summary

The property labeled "U Repeat" from the "UnifiedBitmap" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018

### `P:Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureScaleLock`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureScaleLock`

#### Summary

The property labeled "Scale Lock" from the "UnifiedBitmap" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018

### `P:Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureRealWorldScaleY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureRealWorldScaleY`

#### Summary

The property labeled "Size Y" from the "UnifiedBitmap" schema.

#### Remarks

This property is of type "AssetPropertyDistance" with a minimum of "0.01".

#### Since

2018

### `P:Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureRealWorldScaleX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureRealWorldScaleX`

#### Summary

The property labeled "Size X" from the "UnifiedBitmap" schema.

#### Remarks

This property is of type "AssetPropertyDistance" with a minimum of "0.01".

#### Since

2018

### `P:Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureWAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureWAngle`

#### Summary

The property labeled "Angle" from the "UnifiedBitmap" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 360".

#### Since

2018

### `P:Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureOffsetLock`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureOffsetLock`

#### Summary

The property labeled "Offset Lock" from the "UnifiedBitmap" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018

### `P:Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureRealWorldOffsetY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureRealWorldOffsetY`

#### Summary

The property labeled "Offset Y" from the "UnifiedBitmap" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018

### `P:Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureRealWorldOffsetX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureRealWorldOffsetX`

#### Summary

The property labeled "Offset X" from the "UnifiedBitmap" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018

### `P:Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureLinkTextureTransforms`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap.TextureLinkTextureTransforms`

#### Summary

The property labeled "Link texture Transforms" from the "UnifiedBitmap" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018

### `P:Autodesk.Revit.DB.Visual.UnifiedBitmap.UnifiedbitmapInvert`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap.UnifiedbitmapInvert`

#### Summary

The property labeled "Invert Image" from the "UnifiedBitmap" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018

### `P:Autodesk.Revit.DB.Visual.UnifiedBitmap.UnifiedbitmapRGBAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap.UnifiedbitmapRGBAmount`

#### Summary

The property labeled "Brightness" from the "UnifiedBitmap" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018

### `P:Autodesk.Revit.DB.Visual.UnifiedBitmap.UnifiedbitmapBitmap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap.UnifiedbitmapBitmap`

#### Summary

The property labeled "Source" from the "UnifiedBitmap" schema.

#### Remarks

This property is of type "AssetPropertyString" and will contain a relative path.

#### Since

2018

### `T:Autodesk.Revit.DB.Visual.UnifiedBitmap`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.UnifiedBitmap`

#### Summary

A static class that provides access to the property names that appear in the UnifiedBitmap visual asset schema.

#### Since

2018

### `M:Autodesk.Revit.DB.Transaction.SetFailureHandlingOptions(Autodesk.Revit.DB.FailureHandlingOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.SetFailureHandlingOptions(Autodesk.Revit.DB.FailureHandlingOptions)`

#### Summary

Sets options for handling failures to be used when the transaction is being committed or rolled back.

#### Remarks

Options can be set at any time before the transaction is either committed or rolled back.
See `T:Autodesk.Revit.DB.FailureHandlingOptions` for details about available options.
Once committed or rolled back, the transaction object will reset its options to their default values.

#### Parameter `options`

An instance of FailureHandlingOptions to be applied to the transaction

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Transaction.GetFailureHandlingOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.GetFailureHandlingOptions`

#### Summary

Returns the current failure handling options.

#### Remarks

The returned instance is a copy of the options.
If changes are made to the options, the new version can be set back to
the transaction by calling the `M:Autodesk.Revit.DB.Transaction.SetFailureHandlingOptions(Autodesk.Revit.DB.FailureHandlingOptions)` method.

#### Returns

An instance of FailureHandlingOptions

### `M:Autodesk.Revit.DB.Transaction.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.GetName`

#### Summary

Returns the transaction's name.

#### Returns

The transaction's current name.

### `M:Autodesk.Revit.DB.Transaction.SetName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.SetName(System.String)`

#### Summary

Sets the transaction's name.

#### Remarks

A transaction needs a name before it can be started, i.e. before one
of the 'Start' method is invoked for this transaction object.
The name will later appear in the Undo menu in Revit after a transaction
is successfully committed.

Another ways of setting the name is either during construction
or during the `M:Autodesk.Revit.DB.Transaction.Start(System.String)` method.

#### Parameter `name`

A name for the transaction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The name argument is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Transaction.HasEnded`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.HasEnded`

#### Summary

Determines whether the transaction has ended already.

#### Remarks

A transaction is ended by completing either the 'Commit' or 'RollBack' method.
Another way of testing whether a transaction has ended is by testing
the current status (see `M:Autodesk.Revit.DB.Transaction.GetStatus` ). It must be either
'TransactionStatus.Committed' or 'TransactionStatus.RolledBack'

#### Returns

True if the transaction has already been committed or rolled back, False otherwise.

### `M:Autodesk.Revit.DB.Transaction.HasStarted`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.HasStarted`

#### Summary

Determines whether the transaction has been started yet.

#### Remarks

A transaction is considered being started after a 'Start' method was called
and until the transaction is either completely committed or rolled back.

HasStarted may return True even after 'Commit' or 'RollBack' was called
if the method returned the TransactionStatus.Pending value.

A transaction can only be Started when HasStarted returns false.

#### Returns

True if the transaction has already started, False otherwise.

### `M:Autodesk.Revit.DB.Transaction.GetStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.GetStatus`

#### Summary

Returns the current status of the transaction.

#### Remarks

If the status was set to TransactionStatus.Pending as the result of calling
Commit or RollBack, the status will be changed later to either 'Committed'
or 'RolledBack' after failure handling is finished. That status change will
be made asynchronously.

#### Returns

The current status of the transaction.

### `M:Autodesk.Revit.DB.Transaction.RollBack(Autodesk.Revit.DB.FailureHandlingOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.RollBack(Autodesk.Revit.DB.FailureHandlingOptions)`

#### Summary

Rolls back all changes made to the model during the transaction.

#### Remarks

By rolling back a transaction, all changes made to the model are discarded.
RollBack may only be called for a transaction that has been started.
(Use the `M:Autodesk.Revit.DB.Transaction.GetStatus` method to check the current state.)
Be aware that rolling back may be delayed (as a result of failure handling.)
Callers should always check the returned status to test whether a transaction
was rolled back successfully. Only after rolling back is fully completed,
the transaction may be started again.

#### Parameter `options`

A set of `T:Autodesk.Revit.DB.FailureHandlingOptions`
to be used for handling eventual failures during this call.

The options are only used temporarily during this rolling back process. After
the transaction is finished, the options will be reset to their default values.

#### Returns

If finished successfully, this method returns TransactionStatus.RolledBack.

Be aware that the returned status does not have to be necessarily the same like
the status returned by `M:Autodesk.Revit.DB.Transaction.GetStatus` even when the method is called
immediately after rolling back the transaction. Such difference may happen due to actions
made by a transaction finalizer, if there was one set.
(See `T:Autodesk.Revit.DB.FailureHandlingOptions` for more details.)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The current status of the transaction is not 'Started'.
Transaction must be started before calling Commit or Rollback.
-or-
The transaction's document is currently in failure mode.
No transaction operations are permitted until failure handling is finished.

### `M:Autodesk.Revit.DB.Transaction.RollBack`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.RollBack`

#### Summary

Rolls back all changes made to the model during the transaction.

#### Remarks

By rolling back a transaction, all changes made to the model are discarded.
RollBack may only be called for a transaction that has been started.
(Use the `M:Autodesk.Revit.DB.Transaction.GetStatus` method to check the current state.)
Be aware that rolling back may be delayed (as a result of failure handling.)
Callers should always check the returned status to test whether a transaction
was rolled back successfully. Only after rolling back is fully completed,
the transaction may be started again.

#### Returns

If finished successfully, this method returns TransactionStatus.RolledBack.

Be aware that the returned status does not have to be necessarily the same like
the status returned by `M:Autodesk.Revit.DB.Transaction.GetStatus` even when the method is called
immediately after rolling back the transaction. Such difference may happen due to actions
made by a transaction finalizer, if there was one set.
(See `T:Autodesk.Revit.DB.FailureHandlingOptions` for more details.)

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The current status of the transaction is not 'Started'.
Transaction must be started before calling Commit or Rollback.
-or-
The transaction's document is currently in failure mode.
No transaction operations are permitted until failure handling is finished.

### `M:Autodesk.Revit.DB.Transaction.Commit(Autodesk.Revit.DB.FailureHandlingOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.Commit(Autodesk.Revit.DB.FailureHandlingOptions)`

#### Summary

Commits all changes made to the model during the transaction.

#### Parameter `options`

A set of `T:Autodesk.Revit.DB.FailureHandlingOptions`
to be used for handling eventual failures during this call.

The options are only used temporarily during the commitment process. After
the transaction is finished, the options will be reset to their default values.

#### Returns

If finished successfully, this method returns TransactionStatus.Committed

Note it is possible the RolledBack status is returned instead as an outcome
of failure handling. If TransactionStatus.Pending is returned it means that
failure handling has not been finalized yet and Revit awaits user's actions.
Until committing is fully finalized, no changes to the document can be made
(including starting of new transactions).

Be aware that the returned status does not have to be necessarily the same like
the status returned by `M:Autodesk.Revit.DB.Transaction.GetStatus` even when the method is called
immediately after committing the transaction. Such difference may happen due to actions
made by a transaction finalizer, if there was one set.
(See `T:Autodesk.Revit.DB.FailureHandlingOptions` for more details.)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The current status of the transaction is not 'Started'.
Transaction must be started before calling Commit or Rollback.
-or-
The transaction's document is currently in failure mode.
No transaction operations are permitted until failure handling is finished.

### `M:Autodesk.Revit.DB.Transaction.Commit`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.Commit`

#### Summary

Commits all changes made to the model during the transaction.

#### Remarks

By committing a transaction, all changes made to the model during the transaction
are accepted. A new undo item will appear in the Undo menu in Revit, which allows
the user to undo the changes. The undo item will have this transaction's name.
Commit may only be called for a transaction that has been started.
(Use the `M:Autodesk.Revit.DB.Transaction.GetStatus` method to check the current state.)
Be aware that committing may fail or can be delayed (as a result of failure handling.)
Callers should always check the returned status to test whether a transaction was
committed successfully. Only after a transaction is successfully committed (or rolled
back as a result of handling transaction failures), it may be started again.

#### Returns

If finished successfully, this method returns TransactionStatus.Committed.

Note it is possible the RolledBack status is returned instead as an outcome
of failure handling. If TransactionStatus::Pending is returned it means that
failure handling has not been finalized yet and Revit awaits a user actions.
Until committing is fully finalized, no changes to the document can be made
(including starting of new transactions).

The returned status does not have to be necessarily the same as
the status returned by `M:Autodesk.Revit.DB.Transaction.GetStatus` even when the method is called
immediately after committing the transaction. Such a difference may happen due to actions
made by a transaction finalizer, if there was one set.
(See `T:Autodesk.Revit.DB.FailureHandlingOptions` for more details.)

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The current status of the transaction is not 'Started'.
Transaction must be started before calling Commit or Rollback.
-or-
The transaction's document is currently in failure mode.
No transaction operations are permitted until failure handling is finished.

### `M:Autodesk.Revit.DB.Transaction.Start(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.Start(System.String)`

#### Summary

Starts the transaction with an assigned name.

#### Remarks

A transaction may be started only after it was instantiated or after it
was previously committed or rolled back.

Be aware that every time a transaction starts,
`T:Autodesk.Revit.DB.FailureHandlingOptions`
will be reset to their default values. If a specific failure handling
is required, programmers need to use `M:Autodesk.Revit.DB.Transaction.SetFailureHandlingOptions(Autodesk.Revit.DB.FailureHandlingOptions)`
before the transaction is committed or rolled back.

#### Parameter `name`

Name of the transaction; If the transaction already has name, this new one will preplace it.
The name will appear on the Undo menu in Revit if the transaction is successfully committed.

#### Returns

If finished successfully, this method returns TransactionStatus.Started.
Note that unless starting is successful, changes cannot be made to the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The name argument is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot modify the document for either a read-only external command is being executed, or changes to the document are temporarily disabled.
-or-
The transaction's document is currently in failure mode.
No transaction operations are permitted until failure handling is finished.
-or-
The transaction started already and has not been completed yet.
-or-
Starting a new transaction is not permitted. It could be because
another transaction already started and has not been completed yet,
or the document is in a state in which it cannot start a new transaction
(e.g. during failure handling or a read-only mode, which could be either permanent or temporary).

### `M:Autodesk.Revit.DB.Transaction.Start`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.Start`

#### Summary

Starts the transaction.

#### Remarks

A transaction may be started only after it was instantiated or after it
was previously committed or rolled back. In order to start a transaction,
it must have a name assigned. If the name was not specified when the
transaction object was instantiated, it has to be set by calling
the `M:Autodesk.Revit.DB.Transaction.SetName(System.String)` method.

Be aware that every time a transaction starts,
`T:Autodesk.Revit.DB.FailureHandlingOptions`
will be reset to their default values. If a specific failure handling
is required, programmers need to use `M:Autodesk.Revit.DB.Transaction.SetFailureHandlingOptions(Autodesk.Revit.DB.FailureHandlingOptions)`
before the transaction is committed or rolled back.

#### Returns

If finished successfully, this method returns TransactionStatus.Started.
Note that unless starting is successful, changes cannot be made to the document.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot modify the document for either a read-only external command is being executed, or changes to the document are temporarily disabled.
-or-
The transaction's document is currently in failure mode.
No transaction operations are permitted until failure handling is finished.
-or-
The transaction started already and has not been completed yet.
-or-
Starting a new transaction is not permitted. It could be because
another transaction already started and has not been completed yet,
or the document is in a state in which it cannot start a new transaction
(e.g. during failure handling or a read-only mode, which could be either permanent or temporary).
-or-
The transaction does not have a valid name assigned yet.

### `P:Autodesk.Revit.DB.Transaction.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transaction.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.Transaction.#ctor(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.#ctor(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Instantiates a transaction object

#### Remarks

The transaction does not start by creating a transaction object.
One of the 'Start' methods will need to be called in order to start
this transaction.

#### Parameter `document`

The document for which this transaction is going to be used.

#### Parameter `name`

The name of the transaction. This name will appear in the undo menu
once the transaction is successfully committed. The name must not be empty.
The name can be reset later by either calling `M:Autodesk.Revit.DB.Transaction.SetName(System.String)` or
by using the name argument in the `M:Autodesk.Revit.DB.Transaction.Start(System.String)` method.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The name argument is an empty string.
-or-
Document is a linked file. Transactions can only be used in primary documents (projects or families.)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Transaction.#ctor(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transaction.#ctor(Autodesk.Revit.DB.Document)`

#### Summary

Instantiates a transaction object.

#### Remarks

The transaction does not start by creating a transaction object.
One of the 'Start' methods will need to be called in order to start
this transaction.

A transaction cannot start unless is has a valid (non-empty) name.
Because this constructor does not take a name, a name must be assigned later
before or during the 'Start' method.

#### Parameter `document`

The document for which this transaction is going to be used.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Document is a linked file. Transactions can only be used in primary documents (projects or families.)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.Transaction`

Member kind: type
Symbol: `Autodesk.Revit.DB.Transaction`

#### Summary

Transactions are context-like objects that guard any changes made to a Revit model

#### Remarks

Any change to a document can only be made while there is an active transaction
open for that document. Changes do not become part of the document until the
active transaction is `M:Autodesk.Revit.DB.Transaction.Commit` . Consequently, all
changes made in a transaction can be `M:Autodesk.Revit.DB.Transaction.RollBack`
either explicitly or implicitly by the transaction's destructor.

A document can have only one transaction open at any given time.

Transactions cannot be started when the document is in read-only mode,
either permanently or temporarily. See the Document class methods IsReadOnly
and IsModifiable for more details.

Transactions in linked documents are not permitted,
for linked documents are not allowed to be modified.

If a transaction was started and not finished yet by the time the Transaction object
is about to be disposed, the default destructor will roll it back automatically, thus all
changes made to the document while this transaction was open will be discarded.
It is not recommended to rely on this default behavior though. Instead,
it is advised to always call either `M:Autodesk.Revit.DB.Transaction.Commit`
or `M:Autodesk.Revit.DB.Transaction.RollBack` explicitly before the transaction
object gets disposed.
Please note that unless invoked explicitly the actual destruction of an object
in managed code might not happen until the object is collected by the garbage collector.

### `M:Autodesk.Revit.DB.JoinGeometryUtils.GetJoinedElements(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.JoinGeometryUtils.GetJoinedElements(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element)`

#### Summary

Returns all elements joined to given element.

#### Remarks

This functionality is not available for family documents.

#### Parameter `document`

The document containing the element.

#### Parameter `element`

The element.

#### Returns

The set of elements that are joined to the given element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The element element was not found in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.JoinGeometryUtils.IsCuttingElementInJoin(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.JoinGeometryUtils.IsCuttingElementInJoin(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Determines whether the first of two joined elements is cutting the second element.

#### Remarks

This functionality is not available for family documents.

#### Parameter `document`

The document containing the two elements.

#### Parameter `firstElement`

The first element.

#### Parameter `secondElement`

The second element.

#### Returns

True if the secondElement is cut by the firstElement, false if the secondElement is cut by the firstElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The element firstElement was not found in the given document.
-or-
The element secondElement was not found in the given document.
-or-
The elements are not joined.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.JoinGeometryUtils.AreElementsJoined(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.JoinGeometryUtils.AreElementsJoined(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Determines whether two elements are joined.

#### Remarks

This functionality is not available for family documents.

#### Parameter `document`

The document containing the two elements.

#### Parameter `firstElement`

The first element.

#### Parameter `secondElement`

The second element.

#### Returns

True if the two elements are joined.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The element firstElement was not found in the given document.
-or-
The element secondElement was not found in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.JoinGeometryUtils.SwitchJoinOrder(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.JoinGeometryUtils.SwitchJoinOrder(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Reverses the order in which two elements are joined.

#### Remarks

The cutting element becomes the cut element and vice versa after the join order is switched.
This functionality is not available for family documents.

#### Parameter `document`

The document containing the two elements.

#### Parameter `firstElement`

The first element.

#### Parameter `secondElement`

The second element. This element must be joined to the first element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The element firstElement was not found in the given document.
-or-
The element secondElement was not found in the given document.
-or-
The elements are not joined.
-or-
The elements cannot be joined.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Unable to switch the join order of these elements.

#### Since

2014

### `M:Autodesk.Revit.DB.JoinGeometryUtils.UnjoinGeometry(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.JoinGeometryUtils.UnjoinGeometry(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Removes a join between two elements.

#### Remarks

This functionality is not available for family documents.

#### Parameter `document`

The document containing the two elements.

#### Parameter `firstElement`

The first element to be unjoined.

#### Parameter `secondElement`

The second element to be unjoined. This element must be joined to the fist element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The element firstElement was not found in the given document.
-or-
The element secondElement was not found in the given document.
-or-
The elements are not joined.
-or-
The elements cannot be unjoined.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Please remove or add segments on curtain grids instead of joining or unjoining geometry of the panels.

#### Since

2014

### `M:Autodesk.Revit.DB.JoinGeometryUtils.JoinGeometry(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.JoinGeometryUtils.JoinGeometry(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Creates clean joins between two elements that share a common face.

#### Remarks

The visible edge between joined elements is removed. The joined elements then share the same line weight and fill pattern.
This functionality is not available for family documents.

#### Parameter `document`

The document containing the two elements.

#### Parameter `firstElement`

The first element to be joined.

#### Parameter `secondElement`

The second element to be joined. This element must not be joined to the first element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The element firstElement was not found in the given document.
-or-
The element secondElement was not found in the given document.
-or-
The elements are already joined.
-or-
The elements cannot be joined.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Please remove or add segments on curtain grids instead of joining or unjoining geometry of the panels.

#### Since

2014

### `T:Autodesk.Revit.DB.JoinGeometryUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.JoinGeometryUtils`

#### Summary

Utilities for joining and unjoining elements, and for managing the order in which elements are joined.

#### Since

2014

### `M:Autodesk.Revit.DB.IExternalDBApplication.OnShutdown(Autodesk.Revit.ApplicationServices.ControlledApplication)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalDBApplication.OnShutdown(Autodesk.Revit.ApplicationServices.ControlledApplication)`

#### Summary

Implement this method to execute some tasks when Autodesk Revit shuts down.

#### Parameter `application`

Handle to the Revit Application object.

#### Returns

Indicates if the external db application completes its work successfully.

### `M:Autodesk.Revit.DB.IExternalDBApplication.OnStartup(Autodesk.Revit.ApplicationServices.ControlledApplication)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalDBApplication.OnStartup(Autodesk.Revit.ApplicationServices.ControlledApplication)`

#### Summary

Implement this method to execute some tasks when Autodesk Revit starts.

#### Parameter `application`

Handle to the Revit Application object.

#### Remarks

Typically, event handlers and updaters are registered in this method.

#### Returns

Indicates if the external db application completes its work successfully.

### `T:Autodesk.Revit.DB.IExternalDBApplication`

Member kind: type
Symbol: `Autodesk.Revit.DB.IExternalDBApplication`

#### Summary

An interface that supports addition of DB-level external applications to Revit, to subscribe to DB-level events and updaters.

#### Remarks

DB-level applications are permitted to add DB-level events and updaters to the session.
They cannot create or modify UI.

### `T:Autodesk.Revit.DB.ExternalDBApplicationResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalDBApplicationResult`

#### Summary

Informs Autodesk Revit of the status of your external db application after execution.

### `F:Autodesk.Revit.DB.ExternalDBApplicationResult.Succeeded`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalDBApplicationResult.Succeeded`

#### Summary

The external db application completed successfully. Autodesk Revit will keep this object
during the entire Revit session.

### `F:Autodesk.Revit.DB.ExternalDBApplicationResult.Failed`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalDBApplicationResult.Failed`

#### Summary

The external db application was unable to complete its task.

### `M:Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.IsDataCompleted`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.IsDataCompleted`

#### Summary

Is the required data completed for this zone equipment?

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.AirSystemId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.AirSystemId`

#### Summary

The air system used for this zone equipment, if applicable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.VRFLoopId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.VRFLoopId`

#### Summary

The Varible Refrigerant Flow loop for the VRF fan coil equipment type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.ChilledWaterLoopId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.ChilledWaterLoopId`

#### Summary

The chilled water loop used for the chilled water option of cooling coil.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.CondenserWaterLoopId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.CondenserWaterLoopId`

#### Summary

The condenser water loop used for the direction expansion water cooled option of cooling coil.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.HotWaterLoopId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.HotWaterLoopId`

#### Summary

The water loop element id for the hot-water heating coil.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.CoolingCoilType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.CoolingCoilType`

#### Summary

The type of cooling coil. Note this property change would reset the chilled water loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.HeatingCoilType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.HeatingCoilType`

#### Summary

The type of heating coil. Note this property change would reset the hot water loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.EquipmentBehavior`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.EquipmentBehavior`

#### Summary

The behavior of how zone equipment is allocated with assigned spaces.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.EquipmentType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentData.EquipmentType`

#### Summary

The type of zone equipment. Note this property would reset other properties.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020.1

### `T:Autodesk.Revit.DB.Mechanical.ZoneEquipmentData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipmentData`

#### Summary

Represents the data and parameters of analytical zone equipment.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Mechanical.ZoneEquipment.GetAssociatedZoneEquipment(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipment.GetAssociatedZoneEquipment(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Gets the associated zone equipment of all specified analytical spaces.

#### Parameter `document`

The document where the analytical spaces and zone equipment exist.

#### Parameter `spaces`

The specified analytical spaces.

#### Returns

All associated zone equipment, either explicitly assigned or implicitly assigned via system-zone.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020.1

### `M:Autodesk.Revit.DB.Mechanical.ZoneEquipment.GetAssociatedZoneEquipment(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipment.GetAssociatedZoneEquipment(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the associated zone equipment of the specified analytical space.

#### Parameter `document`

The document where the analytical spaces and zone equipment exist.

#### Parameter `spaceElementId`

The specified analytical spaces.

#### Returns

All associated zone equipment, either explicitly assigned or implicitly assigned via system-zone.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020.1

### `M:Autodesk.Revit.DB.Mechanical.ZoneEquipment.MoveSpaceToEquipment(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipment.MoveSpaceToEquipment(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Moves the selected analytical spaces from the identified zone equipment to another target zone equipment.

#### Parameter `document`

The document where the zone equipment and the analytical spaces exist.

#### Parameter `analyticalSpaceSet`

The specified analytical spaces to move.

#### Parameter `originalZoneEquipmentId`

The original equipment where the analytical spaces will be removed. If passing invalidElementId, the existing zone equipment is not removed.

#### Parameter `targetZoneEquipmentId`

The target zone equipment where the analytical spaces will be associated. If passing invalidElementId, the analytical spaces will not be assigned to any new zone equipment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020.1

### `M:Autodesk.Revit.DB.Mechanical.ZoneEquipment.GetZoneEquipmentData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipment.GetZoneEquipmentData`

#### Summary

Gets the zone equipment data.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Mechanical.ZoneEquipment.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipment.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new zone equipment

#### Parameter `document`

The document where the new element will be created.

#### Parameter `name`

The name of new zone equipment. The actual name may be post-fixed if already exists.

#### Returns

The newly created zone equipment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
name is an empty string.

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

### `T:Autodesk.Revit.DB.Mechanical.ZoneEquipment`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.ZoneEquipment`

#### Summary

Represents an early-stage equipment placeholder that provides heating or cooling to part of air system or water loop.

#### Remarks

A zone equipment is different from physical equipment.
Depending on its behavior type, it may be mapped to multiple physical equipment later.

#### Since

2020.1

### `P:Autodesk.Revit.DB.NumberingSchemaTypes.StructuralNumberingSchemas.ReinforcementFabric`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumberingSchemaTypes.StructuralNumberingSchemas.ReinforcementFabric`

#### Summary

Built-in schema used for numbering fabric reinforcement elements

### `P:Autodesk.Revit.DB.NumberingSchemaTypes.StructuralNumberingSchemas.RebarCoupler`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumberingSchemaTypes.StructuralNumberingSchemas.RebarCoupler`

#### Summary

Built-in schema used for numbering rebar coupler elements

### `P:Autodesk.Revit.DB.NumberingSchemaTypes.StructuralNumberingSchemas.Rebar`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumberingSchemaTypes.StructuralNumberingSchemas.Rebar`

#### Summary

Built-in schema used for numbering rebar elements

### `T:Autodesk.Revit.DB.NumberingSchemaTypes.StructuralNumberingSchemas`

Member kind: type
Symbol: `Autodesk.Revit.DB.NumberingSchemaTypes.StructuralNumberingSchemas`

#### Summary

A collection of types of built-in Numbering Schemas that are used for numbering structure elements.

#### Since

2015

### `T:Autodesk.Revit.DB.NumberingSchemaTypes`

Member kind: type
Symbol: `Autodesk.Revit.DB.NumberingSchemaTypes`

#### Summary

Provides a container of all Revit built-in NumberingSchemaType instances.

### `M:Autodesk.Revit.DB.NumberingSchemaType.op_Inequality(Autodesk.Revit.DB.NumberingSchemaType,Autodesk.Revit.DB.NumberingSchemaType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchemaType.op_Inequality(Autodesk.Revit.DB.NumberingSchemaType,Autodesk.Revit.DB.NumberingSchemaType)`

#### Summary

Compares two NumberingSchemaType instances.

#### Parameter `first`

The first NumberingSchemaType.

#### Parameter `second`

The second NumberingSchemaType.

#### Returns

True if the inputs are different, false if they are identical.

### `M:Autodesk.Revit.DB.NumberingSchemaType.op_Equality(Autodesk.Revit.DB.NumberingSchemaType,Autodesk.Revit.DB.NumberingSchemaType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchemaType.op_Equality(Autodesk.Revit.DB.NumberingSchemaType,Autodesk.Revit.DB.NumberingSchemaType)`

#### Summary

Compares two NumberingSchemaType instances.

#### Parameter `first`

The first NumberingSchemaType.

#### Parameter `second`

The second NumberingSchemaType.

#### Returns

True if the inputs are identical, false if they are different.
