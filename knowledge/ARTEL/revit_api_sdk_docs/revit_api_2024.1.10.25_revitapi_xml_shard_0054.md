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
Shard: 54
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.Element.IsPhaseCreatedValid(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.IsPhaseCreatedValid(Autodesk.Revit.DB.ElementId)`

#### Summary

Returns true if createdPhaseId is an allowed value for the property CreatedPhaseId in this Element.

#### Remarks

Acts as a validator for setting the property CreatedPhaseId.

#### Parameter `createdPhaseId`

The id of a Phase.

#### Returns

True if createdPhaseId is an allowed value for the property CreatedPhaseId in this Element, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Element.ArePhasesModifiable`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.ArePhasesModifiable`

#### Summary

Returns true if the properties CreatedPhaseId and DemolishedPhaseId can be modified for this Element.

#### Remarks

Acts as a validator for setting the properties CreatedPhaseId and DemolishedPhaseId.

#### Returns

True if the properties CreatedPhaseId and DemolishedPhaseId can be modified for this Element, false otherwise.

#### Since

2013

### `M:Autodesk.Revit.DB.Element.HasPhases`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.HasPhases`

#### Summary

Returns true if this Element has the properties CreatedPhaseId and DemolishedPhaseId.

#### Remarks

Acts as a validator for setting the properties CreatedPhaseId and DemolishedPhaseId.

#### Returns

True if this Element has the properties CreatedPhaseId and DemolishedPhaseId, false otherwise.

#### Since

2013

### `M:Autodesk.Revit.DB.Element.GetMonitoredLocalElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetMonitoredLocalElementIds`

#### Summary

Provides the local element IDs when the element is monitoring.

#### Returns

The IDs of local element IDs being monitored by this element.

#### Since

2011

### `M:Autodesk.Revit.DB.Element.GetMonitoredLinkElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetMonitoredLinkElementIds`

#### Summary

Provides the link instance IDs when the element is monitoring.

#### Returns

The IDs of linked instances.

#### Since

2011

### `M:Autodesk.Revit.DB.Element.IsMonitoringLocalElement`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.IsMonitoringLocalElement`

#### Summary

Indicate whether an element is monitoring other local elements.

#### Returns

True if this element is monitoring other elements in same project. Otherwise, false will be returned.

#### Since

2011

### `M:Autodesk.Revit.DB.Element.IsMonitoringLinkElement`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.IsMonitoringLinkElement`

#### Summary

Indicate whether an element is monitoring any elements in any linked models.

#### Returns

True if this element is monitoring elements in a linked models. Otherwise, false will be returned.

#### Since

2011

### `M:Autodesk.Revit.DB.Element.GetChangeTypeAny`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetChangeTypeAny`

#### Summary

Returns ChangeType associated with any change in an element.

#### Remarks

Use this change type to trigger an Updater when elements change in any way.
For maximum efficiency, we recommend the use of ChangeTypeParameter and
ChangeTypeGeometry, if applicable, instead.

Caution: Changes to an element by an Updater using this trigger will result
in re-triggering of the Updater. For example, Updater1 triggers on
ChangeTypeAny on Element X. A Revit user modifies parameter A of X.
Updater1 is triggered and modifies X's parameter B. The change in parameter B,
triggers another call to Updater1.Execute(). If Updater1 continues to
modify X, it can run into an infinite loop. Infinite loops are detected by
Revit and result in the Updater being disabled.

Note: This change type will not trigger on newly created or deleted elements or on changes caused by Undo and Redo.

#### Returns

ChangeType that can be used to define a trigger for an Updater,
triggering on any change in an element.

### `M:Autodesk.Revit.DB.Element.GetChangeTypeGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetChangeTypeGeometry`

#### Summary

Returns ChangeType associated with a change in the geometry of an element

#### Remarks

Use this change type to trigger an Updater when the geometry of an element
changes. For example, changes like cutting a hole in a wall or
adjusting its height are considered to be geometric changes.
Note: This change type will not trigger on newly created or deleted elements
or on changes caused by Undo and Redo.

#### Returns

ChangeType that can be used to define a trigger for an Updater,
triggering on a geometry change in an element

### `M:Autodesk.Revit.DB.Element.GetChangeTypeParameter(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetChangeTypeParameter(Autodesk.Revit.DB.ElementId)`

#### Summary

Returns ChangeType associated with a change in a parameter's value

#### Remarks

remarks: Use this change type to trigger an Updater when the value of an element's
parameter changes.
Note: This change type will not trigger on newly created or deleted elements or on changes caused by Undo and Redo.

#### Parameter `parameterId`

ElementId of parameter for the ChangeType to trigger on.

#### Returns

ChangeType that can be used to define a trigger for an Updater,
triggering on parameter value change.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Element.GetChangeTypeElementAddition`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetChangeTypeElementAddition`

#### Summary

Returns ChangeType associated with element addition

#### Remarks

Use this change type to trigger an Updater on the addition of elements
to a document.
Note: This change type will not trigger on changes caused by Undo and Redo.

#### Returns

ChangeType that can be used to define a trigger for an Updater,
triggering on element addition.

### `M:Autodesk.Revit.DB.Element.GetChangeTypeElementDeletion`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetChangeTypeElementDeletion`

#### Summary

Returns ChangeType associated with element deletion.

#### Remarks

ChangeType that can be used to define a trigger for an Updater,
Use this change type to trigger an Updater on the deletion of elements from a document.
Note: This change type will not trigger on changes caused by Undo and Redo.

#### Returns

ChangeType that can be used to define a trigger for an Updater,
triggering on element deletion.

### `M:Autodesk.Revit.DB.Element.GetParameterFormatOptions(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetParameterFormatOptions(Autodesk.Revit.DB.ElementId)`

#### Summary

Returns a FormatOptions override for the element Parameter, or a default FormatOptions if no override exists.

#### Parameter `parameterId`

Id of parameter for which FormatOptions will be returned.

#### Returns

Format options of element parameter. If the UseDefault property is true, then no formatting overrides have been defined in the element for the specified parameter, and the FormatOptions for the parameter should be obtained from the Unit object, which can be obtained from the Document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Element.EvaluateParameterValues(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.EvaluateParameterValues(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Evaluate the parameters' values of the element on the given parameter ID set.

#### Parameter `parameterIds`

Parameter IDs with which the ParameterValue to be retrieved.

#### Returns

List of `T:Autodesk.Revit.DB.EvaluatedParameter` of the element, which does not include those that cannot be retrieved but are passed in through `parameterIds` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Element.EvaluateAllParameterValues`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.EvaluateAllParameterValues`

#### Summary

Evaluates all the parameters' values of the element.

#### Returns

List of `T:Autodesk.Revit.DB.EvaluatedParameter` of the element.

#### Since

2024

### `M:Autodesk.Revit.DB.Element.GetMaterialVolume(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetMaterialVolume(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the volume of the material with the given id.

#### Parameter `materialId`

The material id returned from `M:Autodesk.Revit.DB.Element.GetMaterialIds(System.Boolean)` .

#### Returns

The volume of the material for this element. Returns 0.0 if the material is not a part of this element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

materialId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Element.GetMaterialArea(Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetMaterialArea(Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Gets the area of the material with the given id.

#### Parameter `materialId`

The material id returned from `M:Autodesk.Revit.DB.Element.GetMaterialIds(System.Boolean)` .

#### Parameter `usePaintMaterial`

If true, this material id was returned as a paint material from `M:Autodesk.Revit.DB.Element.GetMaterialIds(System.Boolean)` and the area returned should be calculated from paint applied to the element.
If false, this material id was returned as a non-paint element material from `M:Autodesk.Revit.DB.Element.GetMaterialIds(System.Boolean)` and the area is calculated from the element geometry and layers.

#### Returns

The area of the material for this element. Returns 0.0 if the material id is not a part of this element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

materialId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Element element does not support paint material assignment.

#### Since

2014

### `M:Autodesk.Revit.DB.Element.GetMaterialIds(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetMaterialIds(System.Boolean)`

#### Summary

Gets the element ids of all materials present in the element.

#### Remarks

The returned collection of materials will be empty in any of the following situations:
The returnPaintMaterials flag is false, and the Category.HasMaterialQuantities property of the element's Category is false.

The returnPaintMaterials flag is true, and the the element does not have any painted faces.
Any material ids returned by this method can be used in GetMaterialArea() to get the calculated area associated to the material.
Non-paint materials ids returned by this method can be used in GetMaterialVolume() to get the volume associated to the material.

#### Parameter `returnPaintMaterials`

If true, this returns material ids assigned to element faces by the Paint tools. If false, this returns ids associated to the material through
its geometry or compound structure layers.

#### Returns

The set of material ids.

#### Since

2014

### `M:Autodesk.Revit.DB.Element.GetExternalResourceReferenceExpanded(Autodesk.Revit.DB.ExternalResourceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetExternalResourceReferenceExpanded(Autodesk.Revit.DB.ExternalResourceType)`

#### Summary

Gets the collection of ExternalResourceReference associated with a specified external resource type.

#### Remarks

Use this API for an element which has multiple external resource references
under a specified type, e.g., AppearanceAssetElement.
See also: `!:Autodesk::Revit::DB::Element::getExternalResourceReference` .

#### Parameter `resourceType`

The desired external resource type.

#### Returns

The collection of the ExternalResourceReference associated with a specified external resource type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This Element does not use a resource reference for the specified resource type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Element.GetExternalResourceReference(Autodesk.Revit.DB.ExternalResourceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetExternalResourceReference(Autodesk.Revit.DB.ExternalResourceType)`

#### Summary

Gets the ExternalResourceReference associated with a specified external resource type.

#### Remarks

For an element which has multiple external resource references
under a specified type like AppearanceAssetElement, it will return the first one.
See also: `!:Autodesk::Revit::DB::Element::getExternalResourceReferenceExpanded` .

#### Parameter `resourceType`

The desired external resource type.

#### Returns

The copy of the ExternalResourceReference associated with a specified external resource type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This Element does not use a resource reference for the specified resource type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Element.RefersToExternalResourceReference(Autodesk.Revit.DB.ExternalResourceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.RefersToExternalResourceReference(Autodesk.Revit.DB.ExternalResourceType)`

#### Summary

Determines whether this Element uses external resources associated with
a specified external resource type.

#### Parameter `resourceType`

The desired external resource type.

#### Returns

Returns true if this Element uses external resources associated with
the specified external resource type; otherwise, false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Element.GetExternalResourceReferencesExpanded`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetExternalResourceReferencesExpanded`

#### Summary

Gets the expanded map of the external resource references referenced
by the element.

#### Remarks

The value includes all external resource references under the type.
Use this API for an element which has multiple external resource references
under a specified type, e.g., AppearanceAssetElement.
See also: `!:Autodesk::Revit::DB::Element::getExternalResourceReferences` .

#### Returns

The expanded map of the external resource references referenced by the element.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Element does not use any external resource.

#### Since

2023

### `M:Autodesk.Revit.DB.Element.GetExternalResourceReferences`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetExternalResourceReferences`

#### Summary

Gets the map of the external resource references referenced
by the element.

#### Remarks

For an element which has multiple external resource references
under a specified type like AppearanceAssetElement, the first one will be the value in the map.
See also: `!:Autodesk::Revit::DB::Element::getExternalResourceReferencesExpanded` .

#### Returns

The map of the external resource references referenced by the element.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Element does not use any external resource.

#### Since

2015

### `M:Autodesk.Revit.DB.Element.RefersToExternalResourceReferences`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.RefersToExternalResourceReferences`

#### Summary

Determines whether this Element uses external resources.

#### Remarks

Some elements may contain references to data from external resources.
These elements contain one or more ExternalResourceReferences.

#### Returns

True if this element uses external resources, false if it does not.

#### Since

2015

### `M:Autodesk.Revit.DB.Element.GetExternalFileReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetExternalFileReference`

#### Summary

Gets information pertaining to the external file referenced
by the element.

#### Returns

An object containing path and type information for the external
file referenced by the element.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Element does not represent an external file.

#### Since

2012

### `M:Autodesk.Revit.DB.Element.IsExternalFileReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.IsExternalFileReference`

#### Summary

Determines whether this Element represents an external
file.

#### Remarks

Linked files are references to external files, but
imported files are not, as their data is brought wholly into
Revit.

#### Returns

True if this element contains information about some external
file, false if it does not.

#### Since

2012

### `M:Autodesk.Revit.DB.Element.GetGeometryObjectFromReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetGeometryObjectFromReference(Autodesk.Revit.DB.Reference)`

#### Summary

Retrieve one geometric primitive contained in the element given a reference.

#### Remarks

It will return the last geometric object in the path.
`null` will be returned if related geometric object could not be found in the model.

#### Parameter `reference`

The geometric object referenced by this instance will be retrieved from the model.

#### Returns

The geometric object referenced by the input reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id of this element is not same as that referenced by reference

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The element id held by the input reference is not same as the id of this element.
The geometric information could not be taken for this element.

#### Since

2012

### `M:Autodesk.Revit.DB.Element.GetDependentElements(Autodesk.Revit.DB.ElementFilter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetDependentElements(Autodesk.Revit.DB.ElementFilter)`

#### Summary

Get all elements that, from a logical point of view, are the children of this Element.

#### Remarks

The elements that this method will return:
Will be deleted if the input Element is deleted.

Potentially could report the input Element as a host (there could be other type of
parent/child relationship here: for example view/view-specific elements, etc.)

#### Parameter `filter`

What type of elements we are interested of.
Can be NULL to return all dependent elements.

#### Returns

Logical children of this element

#### Since

2018.1

### `M:Autodesk.Revit.DB.Element.CanDeleteSubelement(Autodesk.Revit.DB.Subelement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.CanDeleteSubelement(Autodesk.Revit.DB.Subelement)`

#### Summary

Checks if given subelement can be removed from the element.

#### Parameter `subelem`

Subelement to check.

#### Returns

True if subelement can be removed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Element.DeleteSubelements(System.Collections.Generic.IList{Autodesk.Revit.DB.Subelement})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.DeleteSubelements(System.Collections.Generic.IList{Autodesk.Revit.DB.Subelement})`

#### Summary

Removes the subelements from the element.

#### Remarks

Depending on implementation for given element as the result, the element
can be deleted - especially if after Subelement deletion there are no Subelement left.
See also: `P:Autodesk.Revit.DB.Element.IsModifiable` .

#### Parameter `subelems`

Subelements to delete.

#### Returns

True if entire element was deleted, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more subelements in subelems do not exist in the element.
-or-
One or more of the subelements subelems cannot be deleted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

This Element is an internal element, such as a component of a
loaded family or a group type.
-or-
The document containing this Element is in Group Edit Mode,
Sketch Edit Mode, or Paste Mode, and the element is not a
member of the group, sketch, or clipboard.
-or-
This Element is a member of a group or sketch, and the document
is not currently editing the group or sketch.

#### Since

2018

### `M:Autodesk.Revit.DB.Element.DeleteSubelement(Autodesk.Revit.DB.Subelement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.DeleteSubelement(Autodesk.Revit.DB.Subelement)`

#### Summary

Removes a subelement from the element.

#### Remarks

Depending on implementation for given element as the result, the element
can be deleted - especially if after subelement deletion there are no subelements left.
See also: `P:Autodesk.Revit.DB.Element.IsModifiable` .

#### Parameter `subelem`

The subelement to delete.

#### Returns

True if entire element was deleted, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The subelement subelem does not exist in the element.
-or-
Subelement subelem cannot be deleted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

This Element is an internal element, such as a component of a
loaded family or a group type.
-or-
The document containing this Element is in Group Edit Mode,
Sketch Edit Mode, or Paste Mode, and the element is not a
member of the group, sketch, or clipboard.
-or-
This Element is a member of a group or sketch, and the document
is not currently editing the group or sketch.

#### Since

2018

### `M:Autodesk.Revit.DB.Element.GetSubelements`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetSubelements`

#### Summary

Returns the collection of element subelements.

#### Remarks

This collection will not include the Element itself.

#### Returns

The collection of element subelements.

#### Since

2018

### `M:Autodesk.Revit.DB.Element.ChangeTypeId(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.ChangeTypeId(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId)`

#### Summary

Changes the type of all elements in the given set.

#### Remarks

In some cases, applying a change in type will result in a new element being created.
The only active examples of this are when applying a normal wall type to a curtain panel, or
converting such a wall back to a curtain panel.
Then return map would have (original element id, new element id) pair(s).
Note: this function needs an open transaction.
Note: this function calls regeneration.

#### Parameter `document`

The document.

#### Parameter `elementIds`

A collection of element IDs.

#### Parameter `typeId`

Identifier of the type to assign to this element.

#### Returns

The map of original element IDs to the new element IDs
if some elements were replaced by new elements
(the map is empty if no elements were replaced)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

At least one of the elements in elementIds does not exist in the document
-or-
Not all elements elementIds can have a type assigned.
-or-
The type typeId is not valid for at least one of the elements in elementIds.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

One or more elements in elementIds is a member of a loaded family.
-or-
One or more elements in elementIds is a member of a group type that is
not being edited.

#### Since

2011

### `M:Autodesk.Revit.DB.Element.GetValidTypes(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetValidTypes(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Obtains a set of types that are valid for all given elements.

#### Parameter `document`

The document.

#### Parameter `elementIds`

A collection of element IDs.

#### Returns

A set of element IDs of types that are valid for these elements or an empty set if any element cannot have a type assigned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when at least one of the elements does not exist in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Element.IsValidType(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.IsValidType(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if given type is valid for the set of elements.

#### Remarks

A type is valid for the set of elements if it is valid for each and every element in the set.

#### Parameter `document`

The document.

#### Parameter `elementIds`

A collection of element IDs.

#### Parameter `typeId`

ElementId of the type to check.

#### Returns

True if all elements can have a type assigned and this type is valid for all elements, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when at least one of the elements does not exist in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Element.CanHaveTypeAssigned(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.CanHaveTypeAssigned(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Checks if all elements in the set can have a type assigned.

#### Parameter `document`

The document.

#### Parameter `elementIds`

A collection of element IDs.

#### Returns

True if all elements in the set can have a type assigned, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when at least one of the elements does not exist in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Element.ChangeTypeId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.ChangeTypeId(Autodesk.Revit.DB.ElementId)`

#### Summary

Changes the type of the element.

#### Remarks

In rare cases, applying a change in type will result in a new element being created.
The only active examples of this are when applying a normal wall type to a curtain panel, or
converting such a wall back to a curtain panel.
In this situation the new element id is returned.
Also, this element becomes invalid.
See also: `P:Autodesk.Revit.DB.Element.IsModifiable` .

#### Parameter `typeId`

Identifier of the type to assign to this element.

#### Returns

The new element id if new element is created, or InvalidElementId if the element's type changed without creating a new element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The type typeId is not valid for this element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Element cannot have type assigned.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

This Element is an internal element, such as a component of a
loaded family or a group type.
-or-
The document containing this Element is in Group Edit Mode,
Sketch Edit Mode, or Paste Mode, and the element is not a
member of the group, sketch, or clipboard.
-or-
This Element is a member of a group or sketch, and the document
is not currently editing the group or sketch.

#### Since

2011

### `M:Autodesk.Revit.DB.Element.GetValidTypes`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetValidTypes`

#### Summary

Obtains a set of types that are valid for this element.

#### Returns

A set of element IDs of types that are valid for this element or an empty set if element cannot have type assigned.

#### Since

2011

### `M:Autodesk.Revit.DB.Element.IsValidType(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.IsValidType(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if given type is valid for this element.

#### Remarks

A type is valid for an element if it can be assigned to the element.

#### Parameter `typeId`

ElementId of the type to check.

#### Returns

True if element can have a type assigned and this type is valid for this element, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Element.CanHaveTypeAssigned`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.CanHaveTypeAssigned`

#### Summary

Identifies if the element can have a type assigned.

#### Remarks

Some elements cannot have type assigned,
in which case invalid element id is considered to be their type id.

#### Returns

True if element can have a type assigned, false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.Element.GetGeneratingElementIds(Autodesk.Revit.DB.GeometryObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetGeneratingElementIds(Autodesk.Revit.DB.GeometryObject)`

#### Summary

Returns the ids of the element(s) that generated the input geometry object.

#### Remarks

This function supports many different types of relationships among elements.
Most of these relationships will return a single element, for example:
Window and door cutting walls

Openings cutting hosts

Face splitting faces

Wall sweep or reveal traversing wall
A few relationships have the potential for returning multiple elements, including:
Walls joining to other wall(s)

Elements extending to roof(s)
If more than one id is returned, one of them (unspecified) is the id of the element that generated the geometry object and the others are ids of related elements. For example, if a wall A is joined to two walls B and C in a way that creates two end faces, and if this function is called for one of the two end faces, it will return the ids of walls B and C.

#### Parameter `geometryObject`

The geometry object whose generating element is requested.

#### Returns

The id(s) of the element(s) that generated (or may have generated) the given geometry object. Empty if no generating elements are found. If the set contains just one id, it is the id of the element that generated the geometry object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input geometryObject is invalid and so cannot be used to obtain the generating element ids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Element.GetTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetTypeId`

#### Summary

Returns the identifier of this element's type.

#### Remarks

Some elements cannot have type assigned,
in which case this method returns invalid element id.

#### Returns

The id of the element's type, or invalid element id if the element cannot have type assigned.

#### Since

2011

### `M:Autodesk.Revit.DB.Element.GetPhaseStatus(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetPhaseStatus(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the status of a given element in the input phase

#### Parameter `phaseId`

Id of the phase.

#### Returns

The status of the element in the phase.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id does not represent a valid phase.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Element.CanBeLocked`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.CanBeLocked`

#### Summary

Identifies if the element can be locked.

#### Returns

True if the element can be locked, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Element.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Element.DemolishedPhaseId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.DemolishedPhaseId`

#### Summary

Id of a Phase at which the Element was demolished.

#### Remarks

After setting the property, DemolishedPhaseId regeneration can fail if CreatedPhaseId and DemolishedPhaseId
are out of order with respect to their index in the property `!:Autodesk::Revit::DB::Document::Phases` .
Can be set to invalid element id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The element does not allow setting the property DemolishedPhaseId to the value of demolishedPhaseId.
-or-
When setting this property: Invalid order of phases: An object cannot be demolished before it was created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The element does not have properties CreatedPhaseId and DemolishedPhaseId.
-or-
When setting this property: The element does not allow setting the properties CreatedPhaseId and DemolishedPhaseId.

#### Since

2013

### `P:Autodesk.Revit.DB.Element.CreatedPhaseId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.CreatedPhaseId`

#### Summary

Id of a Phase at which the Element was created.

#### Remarks

After setting the property CreatedPhaseId, regeneration can fail if CreatedPhaseId and DemolishedPhaseId
are out of order with respect to their index in the property `!:Autodesk::Revit::DB::Document::Phases` .

When Revit is running with UI activated, the default created phase for newly created elements is inherited from the phase of the currently active view.

When Revit is running without its UI, such as when Revit runs on Autodesk Forge Design Automation API for Revit,
the default CreatedPhaseId for newly created elements is the latest phase in `!:Autodesk::Revit::DB::Document::Phases` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The element does not allow setting the property CreatedPhaseId to the value of createdPhaseId.
-or-
When setting this property: Invalid order of phases: An object cannot be demolished before it was created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The element does not have properties CreatedPhaseId and DemolishedPhaseId.
-or-
When setting this property: The element does not allow setting the properties CreatedPhaseId and DemolishedPhaseId.

#### Since

2013

### `P:Autodesk.Revit.DB.Element.OwnerViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.OwnerViewId`

#### Summary

The id of the view that owns the element.

### `P:Autodesk.Revit.DB.Element.ViewSpecific`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.ViewSpecific`

#### Summary

Identifies if the element is owned by a view.

### `P:Autodesk.Revit.DB.Element.AssemblyInstanceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.AssemblyInstanceId`

#### Summary

The id of the assembly instance to which the element belongs.

### `P:Autodesk.Revit.DB.Element.LevelId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.LevelId`

#### Summary

The id of the level associated with the element.

#### Since

2014

### `P:Autodesk.Revit.DB.Element.UniqueId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.UniqueId`

#### Summary

A stable unique identifier for an element within the document.

#### Remarks

The UniqueId can be used to store an identifier in an external database and to retrieve the same element in the future if it still exists.
This id can be passed to the Document's Element property to retrieve the element. The UniqueId is stable across upgrades and workset
operations such as Save To Central, while the `T:Autodesk.Revit.DB.ElementId` property may change.

### `P:Autodesk.Revit.DB.Element.IsTransient`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.IsTransient`

#### Summary

Indicates whether an element is transient or permanent.

#### Remarks

Transient elements are usually created for short term use. This type of element can be created via Document.MakeTransientElements().

Transient and Permanent elements are not allowed to reference each other. A transient element can only refer to other transient elements in the same document.

Transient elements also cannot be selected or scheduled, and will not be saved when the document is saved, and will be discarded when the document is closed.

Modifying a transient element does not require a transaction, because such elements are not part of the model. As an effect of this, however, creation and modification of transients cannot be undone.

Because transient elements are technically not part of the model, they will not be found when using standard element filters, or in any collection of elements Revit returns, such as elements reported in dynamic updaters, etc.

#### Since

2016

### `P:Autodesk.Revit.DB.Element.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.Id`

#### Summary

A unique identifier for an Element in an Autodesk Revit project.

#### Remarks

Returns an object containing the project-wide unique identifier for this Element. The identifier with this id is only unique for the project, it is not unique across separate Autodesk Revit projects.

### `P:Autodesk.Revit.DB.Element.GroupId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.GroupId`

#### Summary

The id of the group to which an element belongs.

#### Since

2014

### `P:Autodesk.Revit.DB.Element.VersionId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.VersionId`

#### Summary

Get the element version Id.

#### Remarks

The VersionId is really the EpisodeId. This has the useful property that it is stable upon
document upgrade, unlike VersionGUID. This is internal API as it exposes the bare integer value.
It is not appropriate to make it public API without changing it to return a hash instead.
Any changes to this property will have impact for the ATF Revit Producer's change keys.

### `P:Autodesk.Revit.DB.Element.IsModifiable`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.IsModifiable`

#### Summary

Identifies if the element is modifiable.

#### Remarks

This is not a permanent state. The value depends on the document state. For example, active edit modes can make IsModifiable false for many elements.

#### Since

2023

### `P:Autodesk.Revit.DB.Element.VersionGuid`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.VersionGuid`

#### Summary

Get the element version Guid.

#### Remarks

If element version Guid is the same for a certain element in two instances of the saved file
then we guarantee that the two elements are identical. One element version covers a period of time
that is larger than a single transaction: it is a period between two saves, synchronize to central and reload latest.
Thus, in an opened document in-between saves or synchronize actions,
this version cannot be used to determine if any particular element has changed. To watch for element changes happening in-session,
use event `!:Autodesk::Revit::ApplicationServices::Application::DocumentChanged` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When the Element is transient or when the Document has no version Guid for this Element.

#### Since

2021

### `P:Autodesk.Revit.DB.Element.WorksetId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.WorksetId`

#### Summary

Get Id of the Workset which owns the element.

#### Remarks

Each element belongs to one and only one workset.

### `P:Autodesk.Revit.DB.Element.Pinned`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.Pinned`

#### Summary

Identifies if the element has been pinned to prevent changes.

#### Remarks

An element which is pinned may not be moved, and warnings will be issued
when an attempt is made to delete it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Element cannot be pinned or unpinned.

### `M:Autodesk.Revit.DB.Element.LookupParameter(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.LookupParameter(System.String)`

#### Summary

Attempts to find a parameter on the element which has the given name.

#### Parameter `name`

The name of the parameter to be retrieved.

#### Returns

The matching parameter. This return may be `null` if there is no matching parameter. If there are multiple matching parameters the first one found is returned.

#### Remarks

This method will attempt to find a parameter on this Element whose name matches the input. The possible results include:
A single matching parameter is found: it will be returned.

No matching parameter is found: `null` is returned.

Multiple matching parameters exist. In this situation the first one encountered will be returned. This match is determined at random and may change in the future.
.
Multiple matches of parameters with the same name can occur because shared parameters or project parameters can be bound to an element category even if there is a built-in parameter with the same name already.

If this method is used to find built-in parameters the code will not be portable to other languages of Revit (because built-in parameter names are translated, and this method matches the translation).

For the reasons above this method should be used sparingly and only when you have a reasonable expectation that only one parameter exists with the given name, and when portability across multiple languages is not a requirement.

Safer approaches include:
`M:Autodesk.Revit.DB.Element.GetParameters(System.String)` to get all the matches with the given name.

`M:Autodesk.Revit.DB.Element.get_Parameter(System.Guid)` to get a shared parameter by stored guid.

`M:Autodesk.Revit.DB.Element.get_Parameter(Autodesk.Revit.DB.BuiltInParameter)` to find a built-in parameter in a language-independent way.

#### Since

2015

### `M:Autodesk.Revit.DB.Element.GetParameters(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetParameters(System.String)`

#### Summary

Retrieves the parameters from the element via the given name.

#### Parameter `name`

The name of the parameter to be retrieved.

#### Returns

A collection containing the parameters having the same given parameter name.

#### Remarks

Multiple matches of parameters with the same name can occur because shared parameters or project parameters can be bound to an element category even if there is a built-in parameter with the same name already.

If this method is used to find built-in parameters the code will not be portable to other languages of Revit (because built-in parameter names are translated, and this method matches the translation).

For the reasons above this method should be used sparingly and when portability across multiple languages is not a requirement.

Safer approaches include:

`M:Autodesk.Revit.DB.Element.get_Parameter(System.Guid)` to get a shared parameter by stored guid.

`M:Autodesk.Revit.DB.Element.get_Parameter(Autodesk.Revit.DB.BuiltInParameter)` to find a built-in parameter in a language-independent way.

#### Since

2015

### `M:Autodesk.Revit.DB.Element.GetOrderedParameters`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetOrderedParameters`

#### Summary

Gets the parameters associated to the element in order.

#### Returns

A collection containing all parameters.

#### Remarks

The collection consists of only visible parameters associated to the element; it returns a different list than Element.Parameters.

The parameters are returned in the order in which they appear in the Revit UI within a given group;
however, parameters of different groups may be mixed within this output.

Currently the Revit UI order is determined first by group and next by the order of the individual parameters.

#### Since

2015

### `M:Autodesk.Revit.DB.Element.GetChangeTypeParameter(Autodesk.Revit.DB.Parameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetChangeTypeParameter(Autodesk.Revit.DB.Parameter)`

#### Summary

Returns ChangeType associated with a change in a parameter's value

#### Remarks

Use this change type to trigger an Updater when the value of an element's parameter changes.
Note: This change type will not trigger on newly created or deleted elements.

#### Parameter `param`

Parameter for the ChangeType to trigger on

#### Returns

ChangeType that can be used to define a trigger for an Updater,
triggering on parameter value change

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was `null`

### `M:Autodesk.Revit.DB.Element.CanBeHidden(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.CanBeHidden(Autodesk.Revit.DB.View)`

#### Summary

Indicates if the element can be hidden in the view.

#### Remarks

See discussion for some types of elements which may not be hidden.
Note: elements in families can only be hidden temporarily.

#### Returns

If the element is not permitted to be hidden, false is returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when argument is `null` .

### `M:Autodesk.Revit.DB.Element.IsHidden(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.IsHidden(Autodesk.Revit.DB.View)`

#### Summary

Identifies if the element has been permanently hidden in the view.

#### Remarks

This does not determine if the element is hidden as a result of temporary hide/isolate,
view sectioning, view crop box, or other operations that can cause elements not to be visible.
To hide or unhide an element, use the Hide() and Unhide() method of `T:Autodesk.Revit.DB.View` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when argument is `null` .

### `P:Autodesk.Revit.DB.Element.BoundingBox(Autodesk.Revit.DB.View)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.BoundingBox(Autodesk.Revit.DB.View)`

#### Summary

Retrieves a box that circumscribes all geometry of the element.

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

### `P:Autodesk.Revit.DB.Element.Geometry(Autodesk.Revit.DB.Options)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.Geometry(Autodesk.Revit.DB.Options)`

#### Summary

Retrieves the geometric representation of the element.

#### Parameter `options`

User preferences for parsing of geometry.

#### Remarks

This call will retrieve 3d representation of the element. `null` will be returned
for symbols, annotations or details. This involves extensive parsing or Revit's data
structures, so try to minimize calls if performance is critical.

Geometry objects provided from this method are obtained directly from the element. When
the element is changed for any reason, the geometry will be recalculated by Revit and geometry
objects obtained before the change are likely to no longer be valid. If you need to preserve
geometry information obtained an element even after changes to that element, you should copy
the geometry objects or save the properties independently.

Although the geometry obtained from this method comes directly from the element, any attempt to modify
any of the geometry objects will operate only on a disconnected copy of the original geometry object from the element.
The modification will not affect the geometry of the original element from which it was obtained -
to change the geometry of the element you must use methods that directly affect the geometry calculated or
stored by Revit for this element.

If you require that the geometry items obtained contain valid
`T:Autodesk.Revit.DB.Reference` , be sure to set the ComputeReferences
property of the Options.

#### Value

An object that provides access to the geometry of the element.

### `P:Autodesk.Revit.DB.Element.DesignOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.DesignOption`

#### Summary

Returns the design option to which the element belongs.

#### Remarks

If the element is not in a design option, i.e. in the main model, then this property will
return `null` .

### `P:Autodesk.Revit.DB.Element.Document`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.Document`

#### Summary

Returns the Document in which the Element resides.

#### Remarks

All elements are contained within a document. An element can be retrieved from this
document by using the id that is returned by the element's id property.

### `P:Autodesk.Revit.DB.Element.Location`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.Location`

#### Summary

This property is used to find the physical location of an element within a project.

#### Remarks

The Location property returns an object that can be used to find the location of an object
within the project. An object may have a point location, such as a table or may have a line location.
A wall is an example of an element that has a line location.

### `P:Autodesk.Revit.DB.Element.ParametersMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.ParametersMap`

#### Summary

Retrieves a map containing all of the parameters that are contained within the element.

#### Remarks

The Parameters can be rapidly accessed by parameter name as a key.
These parameters are displayed in the Element properties dialog in the Autodesk Revit interface.
These parameters can be retrieved and set via the parameter objects stored in this map.

### `P:Autodesk.Revit.DB.Element.Parameters`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.Parameters`

#### Summary

Retrieves a set containing all of the parameters that are contained within the element.

#### Remarks

The Parameters property contains a set of all the parameters that the element supports.
These parameters are displayed in the Element properties dialog in the Autodesk Revit interface.
These parameters can be retrieved and set via the parameter objects stored in this set.

### `P:Autodesk.Revit.DB.Element.Parameter(Autodesk.Revit.DB.BuiltInParameter)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.Parameter(Autodesk.Revit.DB.BuiltInParameter)`

#### Summary

Retrieves a parameter from the element given a parameter id.

#### Parameter `parameterId`

The built in parameter id of the parameter to be retrieved.

#### Remarks

Parameters are a generic form of data storage within elements. The parameters are visible
through the Autodesk Revit user interface in the Element Properties dialog. This method uses a
built in parameter id to access the parameter. Autodesk Revit has a large number of built in
parameters that are available via an enumerated type.

### `M:Autodesk.Revit.DB.Element.GetParameter(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Element.GetParameter(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Retrieves a parameter from the element given identifier.

#### Parameter `parameterTypeId`

Identifier of the built-in parameter.

#### Remarks

Parameters are a generic form of data storage within elements. The parameters are visible
through the Autodesk Revit user interface in the Element Properties dialog. This method uses a
built in parameter identifier to access the parameter. Autodesk Revit has a large number of built in
parameters that are available via static properties.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

parameterTypeId does not identify a built-in parameter. See Parameter.IsBuiltInParameter(ForgeTypeId) and Parameter.GetParameterTypeId(BuiltInParameter).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2022

### `P:Autodesk.Revit.DB.Element.Parameter(Autodesk.Revit.DB.Definition)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.Parameter(Autodesk.Revit.DB.Definition)`

#### Summary

Retrieves a parameter from the element based on its definition.

#### Parameter `definition`

The internal or external definition of the parameter.

#### Remarks

Parameters are a generic form of data storage within elements. The parameters are visible
through the Autodesk Revit user interface in the Element Properties dialog. An element can only
have one instance of a parameter with a specific definition. By using this method you can retrieve that parameter based on definition.

### `P:Autodesk.Revit.DB.Element.Parameter(System.Guid)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.Parameter(System.Guid)`

#### Overloads

Retrieves a parameter from the element given an identifier.

#### Summary

Retrieves a parameter from the element given a GUID for a shared parameter.

#### Parameter `guid`

The unique id associated with the shared parameter.

#### Remarks

Parameters are a generic form of data storage within elements. The parameters are visible
through the Autodesk Revit user interface in the Element Properties dialog. This method is used to
retrieve a parameter for a known shared parameter. When a shared parameter is created it is
assigned a Guid which will not change. This guid can be used to retrieve the piece of data from the
element at a later time.

### `P:Autodesk.Revit.DB.Element.Category`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.Category`

#### Summary

Retrieves a Category object that represents the category or sub category in which the
element resides.

#### Remarks

All category objects can be retrieved from the application by using the Categories property
of the Application.Settings object.

### `P:Autodesk.Revit.DB.Element.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Element.Name`

#### Summary

A human readable name for the Element.

#### Remarks

The Name property is a human readable name for the element, such as Wall.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the name of the element cannot be changed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the element requires a unique name and a non-unique name is set.

### `T:Autodesk.Revit.DB.Element`

Member kind: type
Symbol: `Autodesk.Revit.DB.Element`

#### Summary

Base class for most persistent data within a Revit document.

#### Remarks

The data in a Revit document consists primarily of a collection of
elements. An element usually corresponds to a single component of a
building or drawing, such as a wall, door, or dimension, but it can
also be something more abstract, like a wall type or a view.
Every element in a document has a unique ID, represented by the
ElementId class.

### `M:ServerPath.#ctor`

Member kind: method
Symbol: `ServerPath.#ctor`

#### Summary

A path to a Revit model stored on a Revit server.

### `M:FilePath.#ctor`

Member kind: method
Symbol: `FilePath.#ctor`

#### Summary

A path to a Revit model stored on disk.

### `M:Autodesk.Revit.DB.ForgeTypeId.StrictlyEquals(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeTypeId.StrictlyEquals(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Returns true if the entire typeid string held by this ForgeTypeId is exactly equal to that held by the given
ForgeTypeId.

For the default equality comparison used by the equality operator (==), see
`M:Autodesk.Revit.DB.ForgeTypeId.NameEquals(Autodesk.Revit.DB.ForgeTypeId)` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.ForgeTypeId.NameEquals(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeTypeId.NameEquals(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Returns true if the typeid string held by this ForgeTypeId is equal to that held by the given ForgeTypeId,
excluding the version number. The version number of a typeid string follows a hyphen character. This function
compares the typeid strings up to the first hyphen. This is the default equality comparison method for the
ForgeTypeId class, used by the equality operator (==).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.ForgeTypeId.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeTypeId.Clear`

#### Summary

Sets the typeId to an empty string

#### Since

2021

### `M:Autodesk.Revit.DB.ForgeTypeId.Empty`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeTypeId.Empty`

#### Summary

Checks if the typeId is an empty string

#### Since

2021

### `P:Autodesk.Revit.DB.ForgeTypeId.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeTypeId.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ForgeTypeId.TypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeTypeId.TypeId`

#### Summary

The schema identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.ForgeTypeId.GetHashCode`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeTypeId.GetHashCode`

#### Summary

Returns the hash code for this ForgeTypeId

#### Returns

A 32-bit signed integer hash code.

#### Since

2021

### `M:Autodesk.Revit.DB.ForgeTypeId.Equals(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeTypeId.Equals(System.Object)`

#### Summary

Determines whether this ForgeTypeId is equal to another.

#### Parameter `other`

The ForgeTypeId with which to compare this ForgeTypeId.

#### Returns

True if the given ForgeTypeId is equal to this one, or false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2021

### `M:Autodesk.Revit.DB.ForgeTypeId.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeTypeId.#ctor(System.String)`

#### Summary

Constructs a ForgeTypeId holding the given schema identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.ForgeTypeId.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeTypeId.#ctor`

#### Summary

Constructs a ForgeTypeId holding an empty schema identifier.

#### Since

2021

### `T:Autodesk.Revit.DB.ForgeTypeId`

Member kind: type
Symbol: `Autodesk.Revit.DB.ForgeTypeId`

#### Summary

This class holds a string that uniquely identifies a Forge schema.

#### Since

2021

### `M:Autodesk.Revit.DB.ElementId.op_GreaterThanOrEqual(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.op_GreaterThanOrEqual(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Determines whether one element id is not less than another element id.

#### Parameter `elementId1`

The first ElementId.

#### Parameter `elementId2`

The second ElementId.

#### Returns

True if the first element id is not less than the second element id, otherwise, false.

### `M:Autodesk.Revit.DB.ElementId.op_LessThanOrEqual(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.op_LessThanOrEqual(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Determines whether one element id is not greater than another element id.

#### Parameter `elementId1`

The first ElementId.

#### Parameter `elementId2`

The second ElementId.

#### Returns

True if the first element id is not greater than the second element id, otherwise, false.

### `M:Autodesk.Revit.DB.ElementId.op_GreaterThan(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.op_GreaterThan(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Determines whether one element id is greater than another element id.

#### Parameter `elementId1`

The first ElementId.

#### Parameter `elementId2`

The second ElementId.

#### Returns

True if the first element id is greater than the second element id, otherwise, false.

### `M:Autodesk.Revit.DB.ElementId.op_LessThan(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.op_LessThan(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Determines whether this element id is less than another element id.

#### Parameter `elementId1`

The first ElementId.

#### Parameter `elementId2`

The second ElementId.

#### Returns

True if the first element id is less than the second element id, otherwise, false.

### `M:Autodesk.Revit.DB.ElementId.op_Inequality(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.op_Inequality(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Determines whether these two ElementIds are different.

#### Parameter `first`

The first ElementId.

#### Parameter `second`

The second ElementId.

#### Returns

True if the ElementIds are different; otherwise, false.

### `M:Autodesk.Revit.DB.ElementId.op_Equality(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.op_Equality(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Determines whether these two ElementIds are the same.

#### Parameter `first`

The first ElementId.

#### Parameter `second`

The second ElementId.

#### Returns

True if the ElementIds are the same; otherwise, false.

### `M:Autodesk.Revit.DB.ElementId.TryParse(System.String,Autodesk.Revit.DB.ElementId@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.TryParse(System.String,Autodesk.Revit.DB.ElementId@)`

#### Summary

Parse the string representation of the id into a corresponding ElementId.

#### Remarks

If the string represents `!:Autodesk::Revit::DB::Element::InvalidElementId` the id
will contain it upon return. If the parse fails, the id will be undefined.

#### Parameter `idStr`

The string representation of the id to return.

#### Parameter `id`

Out parameter set to the ElementId represented by the string.

#### Returns

true if the string was successfully parsed into an ElementId, false otherwise.

#### Since

2023

### `M:Autodesk.Revit.DB.ElementId.Parse(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.Parse(System.String)`

#### Summary

Parse the string representation of the id into a corresponding ElementId.

#### Remarks

If the string represents `!:Autodesk::Revit::DB::Element::InvalidElementId` it will be returned.

#### Parameter `idStr`

The string representation of the id to return.

#### Returns

ElementId string represented.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the string cannot be parsed into an ElementId.

#### Since

2023

### `M:Autodesk.Revit.DB.ElementId.Compare(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.Compare(Autodesk.Revit.DB.ElementId)`

#### Summary

Compares two element ids.

#### Parameter `id`

The ElementId to be compared with this ElementId.

#### Returns

-1 if this element id is less than id, 0 if equal, 1 if greater.

### `P:Autodesk.Revit.DB.ElementId.InvalidElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementId.InvalidElementId`

#### Summary

Get the invalid ElementId whose value is -1.

### `M:Autodesk.Revit.DB.ElementId.GetHashCode`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.GetHashCode`

#### Summary

Gets the value of the id as hash code

### `M:Autodesk.Revit.DB.ElementId.Equals(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.Equals(System.Object)`

#### Summary

Determines whether the specified `T:System.Object` is equal to the current `T:System.Object` .

#### Parameter `obj`

Another object.

### `M:Autodesk.Revit.DB.ElementId.ToString`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.ToString`

#### Summary

Gets a String representation of the value of the id.

### `P:Autodesk.Revit.DB.ElementId.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementId.Value`

#### Summary

Provides the value of the element id as a 64-bit integer.

#### Since

2024

### `P:Autodesk.Revit.DB.ElementId.IntegerValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementId.IntegerValue`

#### Summary

Provides the value of the element id as a 32-bit integer.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the value of the element id is too large to be represented as a 32-bit integer.

### `M:Autodesk.Revit.DB.ElementId.#ctor(Autodesk.Revit.DB.BuiltInParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.#ctor(Autodesk.Revit.DB.BuiltInParameter)`

#### Summary

Create an ElementId handle with the given BuiltInParameter id.

#### Parameter `parameterId`

The id.

### `M:Autodesk.Revit.DB.ElementId.#ctor(Autodesk.Revit.DB.BuiltInCategory)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.#ctor(Autodesk.Revit.DB.BuiltInCategory)`

#### Summary

Create an ElementId handle with the given BuiltInCategory id.

#### Parameter `categoryId`

The id.

### `M:Autodesk.Revit.DB.ElementId.#ctor(System.Int64)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.#ctor(System.Int64)`

#### Summary

Create an ElementId handle with the given 64-bit integer id.

#### Parameter `id`

The id.

#### Since

2024

### `M:Autodesk.Revit.DB.ElementId.#ctor(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementId.#ctor(System.Int32)`

#### Summary

Create an ElementId handle with the given 32-bit integer id.

#### Parameter `id`

The id.

### `T:Autodesk.Revit.DB.ElementId`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementId`

#### Summary

The ElementId object is used as a unique identification for an element within a
single project.

#### Remarks

The Value within the ElementId is only unique with a single project. It is not unique
across several projects. The Id can be used to retrieve a specific element from the database
when needed. However ids are subject to change during an Autodesk Revit session and as such
should not be retained and used across repeated calls to external commands. If a manner is
needed to uniquely identify an element beyond this limitation then a shared parameter should
be added to the element containing a unique identifier managed by the external application.

### `T:Autodesk.Revit.DB.BuiltInParameterGroup`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup`

#### Summary

An enumerated type listing all of the built-in parameter groups supported by Autodesk
Revit.

#### Remarks

Parameter groups are used to sort parameters within the Element Properties dialog.

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_TOPOSOLID_SUBDIVISION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_TOPOSOLID_SUBDIVISION`

#### Summary

"Toposolid Subdivision"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_LIFE_SAFETY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_LIFE_SAFETY`

#### Summary

"Life Safety"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ELECTRICAL_ANALYSIS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ELECTRICAL_ANALYSIS`

#### Summary

"Electrical Analysis"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ALTERNATE_UNITS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ALTERNATE_UNITS`

#### Summary

"Alternate Units"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_PRIMARY_UNITS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_PRIMARY_UNITS`

#### Summary

"Primary Units"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_WALL_CROSS_SECTION_DEFINITION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_WALL_CROSS_SECTION_DEFINITION`

#### Summary

"Cross-Section Definition"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ROUTE_ANALYSIS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ROUTE_ANALYSIS`

#### Summary

"Route Analysis"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_GEO_LOCATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_GEO_LOCATION`

#### Summary

"Geolocation"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_STRUCTURAL_SECTION_GEOMETRY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_STRUCTURAL_SECTION_GEOMETRY`

#### Summary

"Structural Section Geometry"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_BLDG_CONS_MTL_THERMAL_PROPS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_BLDG_CONS_MTL_THERMAL_PROPS`

#### Summary

"Material Thermal Properties"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_ROOM_SPACE_DATA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_ROOM_SPACE_DATA`

#### Summary

"Room/Space Data"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_BUILDING_DATA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_BUILDING_DATA`

#### Summary

"Building Data"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_COUPLER_ARRAY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_COUPLER_ARRAY`

#### Summary

"Set"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_ADVANCED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_ADVANCED`

#### Summary

"Advanced"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_RELEASES_MEMBER_FORCES`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_RELEASES_MEMBER_FORCES`

#### Summary

"Releases / Member Forces"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_SECONDARY_END`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_SECONDARY_END`

#### Summary

"Secondary End"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_PRIMARY_END`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_PRIMARY_END`

#### Summary

"Primary End"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_MOMENTS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_MOMENTS`

#### Summary

"Moments"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_FORCES`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_FORCES`

#### Summary

"Forces"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_FABRICATION_PRODUCT_DATA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_FABRICATION_PRODUCT_DATA`

#### Summary

"Fabrication Product Data"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_REFERENCE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_REFERENCE`

#### Summary

"Reference"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_GEOMETRY_POSITIONING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_GEOMETRY_POSITIONING`

#### Summary

"Geometric Position"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_DIVISION_GEOMETRY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_DIVISION_GEOMETRY`

#### Summary

"Division Geometry"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_SEGMENTS_FITTINGS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_SEGMENTS_FITTINGS`

#### Summary

"Segments and Fittings"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CONTINUOUSRAIL_END_TOP_EXTENSION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CONTINUOUSRAIL_END_TOP_EXTENSION`

#### Summary

"Extension (End/Top)"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CONTINUOUSRAIL_BEGIN_BOTTOM_EXTENSION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CONTINUOUSRAIL_BEGIN_BOTTOM_EXTENSION`

#### Summary

"Extension (Beginning/Bottom)"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIRS_WINDERS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIRS_WINDERS`

#### Summary

"Winders"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIRS_SUPPORTS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIRS_SUPPORTS`

#### Summary

"Supports"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIRS_OPEN_END_CONNECTION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIRS_OPEN_END_CONNECTION`

#### Summary

"End Connection"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_SECONDARY_FAMILY_HANDRAILS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_SECONDARY_FAMILY_HANDRAILS`

#### Summary

"Handrail 2"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_TERMINATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_TERMINATION`

#### Summary

"Terminations"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIRS_TREADS_RISERS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIRS_TREADS_RISERS`

#### Summary

"Threads/Risers"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIRS_CALCULATOR_RULES`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIRS_CALCULATOR_RULES`

#### Summary

"Calculation Rules"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_SPLIT_PROFILE_DIMENSIONS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_SPLIT_PROFILE_DIMENSIONS`

#### Summary

"Dimensions (linear units or % of thickness)"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_LENGTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_LENGTH`

#### Summary

"Length"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_NODES`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_NODES`

#### Summary

"Nodes"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ANALYTICAL_PROPERTIES`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ANALYTICAL_PROPERTIES`

#### Summary

"Analytical Properties"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ANALYTICAL_ALIGNMENT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ANALYTICAL_ALIGNMENT`

#### Summary

"Analytical Alignment"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_SYSTEMTYPE_RISEDROP`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_SYSTEMTYPE_RISEDROP`

#### Summary

"Rise / Drop"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_LINING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_LINING`

#### Summary

"Lining"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_INSULATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_INSULATION`

#### Summary

"Insulation"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_OVERALL_LEGEND`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_OVERALL_LEGEND`

#### Summary

"Overall Legend"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_VISIBILITY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_VISIBILITY`

#### Summary

"Visibility"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_SUPPORT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_SUPPORT`

#### Summary

"Supports"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_V_GRID`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_V_GRID`

#### Summary

"V Grid"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_U_GRID`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_U_GRID`

#### Summary

"U Grid"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_POSTS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_POSTS`

#### Summary

"Posts"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_PATTERN_REMAINDER`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_PATTERN_REMAINDER`

#### Summary

"Pattern Remainder"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_PATTERN_REPEAT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_PATTERN_REPEAT`

#### Summary

"Pattern Repeat"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_FAMILY_SEGMENT_PATTERN`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_FAMILY_SEGMENT_PATTERN`

#### Summary

"Segment Pattern (default)"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_FAMILY_HANDRAILS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_FAMILY_HANDRAILS`

#### Summary

"Handrail 1"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_FAMILY_TOP_RAIL`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_RAILING_SYSTEM_FAMILY_TOP_RAIL`

#### Summary

"Top Rail"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CONCEPTUAL_ENERGY_DATA_BUILDING_SERVICES`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CONCEPTUAL_ENERGY_DATA_BUILDING_SERVICES`

#### Summary

"Energy Model - Building Services"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_DATA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_DATA`

#### Summary

"Data"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ELECTRICAL_CIRCUITING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ELECTRICAL_CIRCUITING`

#### Summary

"Electrical - Circuiting"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_GENERAL`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_GENERAL`

#### Summary

"General"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_FLEXIBLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_FLEXIBLE`

#### Summary

"Adaptive Component"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_CONCEPTUAL_MODEL`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_CONCEPTUAL_MODEL`

#### Summary

"Energy Analytical Model"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_DETAILED_MODEL`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_DETAILED_MODEL`

#### Summary

"Detailed Model"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_DETAILED_AND_CONCEPTUAL_MODELS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS_DETAILED_AND_CONCEPTUAL_MODELS`

#### Summary

"Essential"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_FITTING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_FITTING`

#### Summary

"Fittings"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CONCEPTUAL_ENERGY_DATA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CONCEPTUAL_ENERGY_DATA`

#### Summary

"Conceptual Energy Data"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_AREA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_AREA`

#### Summary

"Area"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ADSK_MODEL_PROPERTIES`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ADSK_MODEL_PROPERTIES`

#### Summary

"Model Properties"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID_V`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID_V`

#### Summary

"V Grid"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID_U`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID_U`

#### Summary

"U Grid"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_DISPLAY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_DISPLAY`

#### Summary

"Display"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ANALYSIS_RESULTS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ANALYSIS_RESULTS`

#### Summary

"Analysis Results"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_SLAB_SHAPE_EDIT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_SLAB_SHAPE_EDIT`

#### Summary

"Slab Shape Edit"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_LIGHT_PHOTOMETRICS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_LIGHT_PHOTOMETRICS`

#### Summary

"Photometrics"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_PATTERN_APPLICATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_PATTERN_APPLICATION`

#### Summary

"Pattern Application"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_GREEN_BUILDING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_GREEN_BUILDING`

#### Summary

"Green Building Properties"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_PROFILE_2`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_PROFILE_2`

#### Summary

"Profile 2"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_PROFILE_1`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_PROFILE_1`

#### Summary

"Profile 1"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_PROFILE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_PROFILE`

#### Summary

"Profile"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_TRUSS_FAMILY_BOTTOM_CHORD`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_TRUSS_FAMILY_BOTTOM_CHORD`

#### Summary

"Bottom Chords"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_TRUSS_FAMILY_TOP_CHORD`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_TRUSS_FAMILY_TOP_CHORD`

#### Summary

"Top Chords"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_TRUSS_FAMILY_DIAG_WEB`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_TRUSS_FAMILY_DIAG_WEB`

#### Summary

"Diagonal Webs"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_TRUSS_FAMILY_VERT_WEB`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_TRUSS_FAMILY_VERT_WEB`

#### Summary

"Vertical Webs"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_TITLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_TITLE`

#### Summary

"Title Text"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_FIRE_PROTECTION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_FIRE_PROTECTION`

#### Summary

"Fire Protection"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ROTATION_ABOUT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ROTATION_ABOUT`

#### Summary

"Rotation about"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_TRANSLATION_IN`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_TRANSLATION_IN`

#### Summary

"Translation in"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ANALYTICAL_MODEL`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ANALYTICAL_MODEL`

#### Summary

"Analytical Model"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_REBAR_ARRAY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_REBAR_ARRAY`

#### Summary

"Rebar Set"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_REBAR_SYSTEM_LAYERS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_REBAR_SYSTEM_LAYERS`

#### Summary

"Layers"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID`

#### Summary

"Grid"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_MULLION_2`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_MULLION_2`

#### Summary

"Grid 2 Mullions"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_MULLION_HORIZ`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_MULLION_HORIZ`

#### Summary

"Horizontal Mullions"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_MULLION_1`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_MULLION_1`

#### Summary

"Grid 1 Mullions"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_MULLION_VERT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_MULLION_VERT`

#### Summary

"Vertical Mullions"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID_2`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID_2`

#### Summary

"Grid 2"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID_HORIZ`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID_HORIZ`

#### Summary

"Horizontal Grid"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID_1`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID_1`

#### Summary

"Grid 1"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID_VERT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CURTAIN_GRID_VERT`

#### Summary

"Vertical Grid"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_IFC`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_IFC`

#### Summary

"IFC Parameters"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ELECTRICAL`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ELECTRICAL`

#### Summary

"Electrical"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ENERGY_ANALYSIS`

#### Summary

"Energy Analysis"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_STRUCTURAL_ANALYSIS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_STRUCTURAL_ANALYSIS`

#### Summary

"Structural Analysis"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_MECHANICAL_AIRFLOW`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_MECHANICAL_AIRFLOW`

#### Summary

"Mechanical - Flow"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_MECHANICAL_LOADS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_MECHANICAL_LOADS`

#### Summary

"Mechanical - Loads"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ELECTRICAL_LOADS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ELECTRICAL_LOADS`

#### Summary

"Electrical - Loads"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ELECTRICAL_LIGHTING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ELECTRICAL_LIGHTING`

#### Summary

"Electrical - Lighting"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_TEXT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_TEXT`

#### Summary

"Text"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_VIEW_CAMERA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_VIEW_CAMERA`

#### Summary

"Camera"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_VIEW_EXTENTS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_VIEW_EXTENTS`

#### Summary

"Extents"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_PATTERN`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_PATTERN`

#### Summary

"Pattern"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CONSTRAINTS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CONSTRAINTS`

#### Summary

"Constraints"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_PHASING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_PHASING`

#### Summary

"Phasing"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_MECHANICAL`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_MECHANICAL`

#### Summary

"Mechanical"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_STRUCTURAL`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_STRUCTURAL`

#### Summary

"Structural"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_PLUMBING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_PLUMBING`

#### Summary

"Plumbing"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_ELECTRICAL_ENGINEERING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_ELECTRICAL_ENGINEERING`

#### Summary

"Electrical Engineering"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIR_STRINGERS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIR_STRINGERS`

#### Summary

"Stringers"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIR_RISERS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIR_RISERS`

#### Summary

"Risers"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIR_TREADS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_STAIR_TREADS`

#### Summary

"Treads"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_UNDERLAY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_UNDERLAY`

#### Summary

"Underlay"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_MATERIALS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_MATERIALS`

#### Summary

"Materials and Finishes"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_GRAPHICS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_GRAPHICS`

#### Summary

"Graphics"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_CONSTRUCTION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_CONSTRUCTION`

#### Summary

"Construction"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_GEOMETRY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_GEOMETRY`

#### Summary

"Dimensions"

### `F:Autodesk.Revit.DB.BuiltInParameterGroup.PG_IDENTITY_DATA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameterGroup.PG_IDENTITY_DATA`

#### Summary

"Identity Data"

### `T:Autodesk.Revit.DB.BuiltInParameter`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInParameter`

#### Summary

An enumerated type listing all of the built-in parameter IDs supported by Autodesk
Revit.

#### Remarks

The ID of the parameter can be used to retrieve property values from an Element
by using the Element.Parameter property.
The documentation for each ID includes the parameter name, as found in the
Element Properties dialog in the English version of Autodesk Revit. Note that
multiple distinct parameter ids may map to the same English name; in those case you must
examine the parameters associated with a specific element to determine
which parameter id to use.

### `F:Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_TOP`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_TOP`

#### Summary

"Top"

### `F:Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_RIGHT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_RIGHT`

#### Summary

"Right"

### `F:Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_BOTTOM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_BOTTOM`

#### Summary

"Bottom"

### `F:Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_LEFT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_LEFT`

#### Summary

"Left"

### `F:Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_CENTER_Y`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_CENTER_Y`

#### Summary

"Center Y"

### `F:Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_CENTER_X`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_CENTER_X`

#### Summary

"Center X"

### `F:Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_PARAMS_SHOW`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PLACEMENT_PARAMS_SHOW`

#### Summary

"Enable Position Parameters"

### `F:Autodesk.Revit.DB.BuiltInParameter.EXCHANGE_ENTITY_ID`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.EXCHANGE_ENTITY_ID`

#### Summary

"Exchange Entity ID"

### `F:Autodesk.Revit.DB.BuiltInParameter.EXCHANGE_ID`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.EXCHANGE_ID`

#### Summary

"Exchange ID"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_DETAIL_LEVEL`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_DETAIL_LEVEL`

#### Summary

"Detail Level"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_ANGULAR_DIMENSION_TEXT_POSITION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_ANGULAR_DIMENSION_TEXT_POSITION`

#### Summary

"Angle Text Position"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_SEGMENT_LENGTH_DIMENSION_TEXT_POSITION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_SEGMENT_LENGTH_DIMENSION_TEXT_POSITION`

#### Summary

"Dimension Text Position"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_SEGMENET_REPESENTATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_SEGMENET_REPESENTATION`

#### Summary

"Representation"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_VARYING_REBAR_DIMENSION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_VARYING_REBAR_DIMENSION`

#### Summary

"Varying Rebar Set Dimensions"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_REPESENTATION_FOR_3D_BARS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_REPESENTATION_FOR_3D_BARS`

#### Summary

"View for 3D Shape"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_ANGULAR_DIMENSIONS_MEASUREMENT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_ANGULAR_DIMENSIONS_MEASUREMENT`

#### Summary

"Angle Measurement"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_ANGULAR_DIMENSIONS_FOR_HOOKS_ENABLED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_ANGULAR_DIMENSIONS_FOR_HOOKS_ENABLED`

#### Summary

"Hook Angles"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_BEND_DIAMETER_DIMENSIONS_FOR_HOOKS_ENABLED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_BEND_DIAMETER_DIMENSIONS_FOR_HOOKS_ENABLED`

#### Summary

"Hook Bends"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_BEND_DIAMETER_DIMENSIONS_FOR_SEGMENTS_ENABLED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_BEND_DIAMETER_DIMENSIONS_FOR_SEGMENTS_ENABLED`

#### Summary

"Segment Bends"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SHOW_BAR_BENDING_USING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SHOW_BAR_BENDING_USING`

#### Summary

"Dimension Type"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_DIAMETER_DIMENSION_TYPE_ID`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_DIAMETER_DIMENSION_TYPE_ID`

#### Summary

"Diameter Dimension Style"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_RADIAL_DIMENSION_TYPE_ID`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_RADIAL_DIMENSION_TYPE_ID`

#### Summary

"Radial Dimension Style"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_BEND_DIAMETER_DIMENSIONS_ENABLED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_BEND_DIAMETER_DIMENSIONS_ENABLED`

#### Summary

"Bend Diameter Dimensions"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_ANGULAR_DIMENSION_OFFSET`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_ANGULAR_DIMENSION_OFFSET`

#### Summary

"Angular Dimension Offset"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SHOW_ANGULAR_DIMENSIONS_FOR`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SHOW_ANGULAR_DIMENSIONS_FOR`

#### Summary

"Show for Angles"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_ANGULAR_DIMENSION_TYPE_ID`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_ANGULAR_DIMENSION_TYPE_ID`

#### Summary

"Angular Dimension Style"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_ANGULAR_DIMENSIONS_ENABLED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_ANGULAR_DIMENSIONS_ENABLED`

#### Summary

"Angular Dimensions"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_ORTHOGONAL_AND_OVERALL_DIMESIONS_ENABLED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_ORTHOGONAL_AND_OVERALL_DIMESIONS_ENABLED`

#### Summary

"Other Dimensions"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SEGMENT_LENGTH_DIMENSIONS_FOR_HOOKS_ENABLED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SEGMENT_LENGTH_DIMENSIONS_FOR_HOOKS_ENABLED`

#### Summary

"Hook Lengths"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SEGMENT_LENGTH_DIMENSIONS_OFFSET`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SEGMENT_LENGTH_DIMENSIONS_OFFSET`

#### Summary

"Dimension Offset"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SEGMENT_LENGTHS_DISPLAY_OPTION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SEGMENT_LENGTHS_DISPLAY_OPTION`

#### Summary

"Straight Segment Lengths"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SEGMENT_LENGTHS_FOR_ARCS_DISPLAY_OPTION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SEGMENT_LENGTHS_FOR_ARCS_DISPLAY_OPTION`

#### Summary

"Arc Segment Lengths"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SEGMENT_LENGTH_DIMENSION_TYPE_ID`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SEGMENT_LENGTH_DIMENSION_TYPE_ID`

#### Summary

"Linear Dimension Style"

### `F:Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SEGMENT_LENGTH_DIMENSIONS_ENABLED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BENDING_DETAIL_TYPE_SEGMENT_LENGTH_DIMENSIONS_ENABLED`

#### Summary

"Segment Length Dimensions"

### `F:Autodesk.Revit.DB.BuiltInParameter.LOAD_IS_CONSTRAINED_ON_HOST`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LOAD_IS_CONSTRAINED_ON_HOST`

#### Summary

"Is constrained on host"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_ALIGNMENT_OPTIONS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_ALIGNMENT_OPTIONS`

#### Summary

"Bar Alignment"

### `F:Autodesk.Revit.DB.BuiltInParameter.SCHEDULE_ROW_HEIGHT_INPUT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.SCHEDULE_ROW_HEIGHT_INPUT`

#### Summary

"Row Height"

### `F:Autodesk.Revit.DB.BuiltInParameter.SCHEDULE_RESIZE_ROWS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.SCHEDULE_RESIZE_ROWS`

#### Summary

"Resize Rows"

### `F:Autodesk.Revit.DB.BuiltInParameter.SCHEDULE_ROTATION_ON_SHEET`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.SCHEDULE_ROTATION_ON_SHEET`

#### Summary

"Rotation on Sheet"

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_SCHEDULE_FAMILY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_SCHEDULE_FAMILY`

#### Summary

"Family"

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_IS_VARIABLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_IS_VARIABLE`

#### Summary

"Is Variable"

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_IS_STRUCTURAL_MATERIAL`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_IS_STRUCTURAL_MATERIAL`

#### Summary

"Is Structural Material"

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_IS_CORE_LAYER`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_IS_CORE_LAYER`

#### Summary

"Is Core Layer"

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_COMPOUND_ELEM_TYPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_COMPOUND_ELEM_TYPE`

#### Summary

"Compound Element Type"

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_COMPOUND_ELEM_FAMILY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_COMPOUND_ELEM_FAMILY`

#### Summary

"Compound Element Family"

### `F:Autodesk.Revit.DB.BuiltInParameter.SSE_POINT_ELEVATION_BASE_TYPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.SSE_POINT_ELEVATION_BASE_TYPE`

#### Summary

"Elevation Base Type"

### `F:Autodesk.Revit.DB.BuiltInParameter.SSE_POINT_ELEVATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.SSE_POINT_ELEVATION`

#### Summary

"Elevation"

### `F:Autodesk.Revit.DB.BuiltInParameter.SSE_POINT_OFFSET_FROM_SURFACE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.SSE_POINT_OFFSET_FROM_SURFACE`

#### Summary

"Offset from Surface"

### `F:Autodesk.Revit.DB.BuiltInParameter.SSE_POINT_BASETYPE_ENUM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.SSE_POINT_BASETYPE_ENUM`

#### Summary

"Point Base Type"

### `F:Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_CONTOUR_SUBCATEGORY_ID`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_CONTOUR_SUBCATEGORY_ID`

#### Summary

"Subcategory"

### `F:Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_CONTOUR_DISPLAY_SETTINGS_ID_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_CONTOUR_DISPLAY_SETTINGS_ID_PARAM`

#### Summary

"Contour Display"

### `F:Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_SUBDIVIDE_MATERIAL`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_SUBDIVIDE_MATERIAL`

#### Summary

"Material"

### `F:Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_SUBDIVIDE_HEIGNT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_SUBDIVIDE_HEIGNT`

#### Summary

"Sub-divide Height"

### `F:Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_INHERIT_CONTOURS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_INHERIT_CONTOURS`

#### Summary

"Inherit Contours"

### `F:Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_FUNCTION_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_FUNCTION_PARAM`

#### Summary

"Function"

### `F:Autodesk.Revit.DB.BuiltInParameter.PREFER_PATTERN_ALIGN_UI_FILTER`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PREFER_PATTERN_ALIGN_UI_FILTER`

#### Summary

"Pattern:": This is used by the UI to allow to select the preferred preference of aligning pattern.

### `F:Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_ELEVATION_AT_TOP`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_ELEVATION_AT_TOP`

#### Summary

"Elevation at Top"

### `F:Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_ELEVATION_AT_BOTTOM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_ELEVATION_AT_BOTTOM`

#### Summary

"Elevation at Bottom"

### `F:Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_STRUCTURE_ID_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_STRUCTURE_ID_PARAM`

#### Summary

"Structure"

### `F:Autodesk.Revit.DB.BuiltInParameter.LOWEST_ASSOCIATED_LEVEL`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LOWEST_ASSOCIATED_LEVEL`

#### Summary

"Lowest Associated Level": The lowest level associated with this Analytical Element.

### `F:Autodesk.Revit.DB.BuiltInParameter.HIGHEST_ASSOCIATED_LEVEL`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.HIGHEST_ASSOCIATED_LEVEL`

#### Summary

"Highest Associated Level": The highest level associated with this Analytical Element.

### `F:Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_HEIGHTABOVELEVEL_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_HEIGHTABOVELEVEL_PARAM`

#### Summary

"Height Offset From Level"

### `F:Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_ATTR_THICKNESS_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_ATTR_THICKNESS_PARAM`

#### Summary

"Thickness"

### `F:Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_TYPE_DEFAULT_THICKNESS_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.TOPOSOLID_TYPE_DEFAULT_THICKNESS_PARAM`

#### Summary

"Default Thickness"

### `F:Autodesk.Revit.DB.BuiltInParameter.OFFSET_FROM_REFERENCE_BASE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.OFFSET_FROM_REFERENCE_BASE`

#### Summary

"Offset from Reference Base"

### `F:Autodesk.Revit.DB.BuiltInParameter.REFERENCE_BASE_ON_HOST`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REFERENCE_BASE_ON_HOST`

#### Summary

"Reference Base on Host"

### `F:Autodesk.Revit.DB.BuiltInParameter.OVAL_FRAMING_HEIGHT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.OVAL_FRAMING_HEIGHT`

#### Summary

"Oval Height"

### `F:Autodesk.Revit.DB.BuiltInParameter.OVAL_FRAMING_WIDTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.OVAL_FRAMING_WIDTH`

#### Summary

"Oval Width"

### `F:Autodesk.Revit.DB.BuiltInParameter.CIRCULAR_FRAMING_DIAMETER`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.CIRCULAR_FRAMING_DIAMETER`

#### Summary

"Circular Diameter"

### `F:Autodesk.Revit.DB.BuiltInParameter.LINEAR_FRAMING_LENGTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LINEAR_FRAMING_LENGTH`

#### Summary

"Length"

### `F:Autodesk.Revit.DB.BuiltInParameter.FRAMING_SHAPE_CLASSIFICATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.FRAMING_SHAPE_CLASSIFICATION`

#### Summary

"Framing Shape"

### `F:Autodesk.Revit.DB.BuiltInParameter.STIFFENER_CLASSIFICATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STIFFENER_CLASSIFICATION`

#### Summary

"Classification"

### `F:Autodesk.Revit.DB.BuiltInParameter.FAMILY_SELF_ORIENTING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.FAMILY_SELF_ORIENTING`

#### Summary

"Align to View"

### `F:Autodesk.Revit.DB.BuiltInParameter.COUPLER_ROTATION_ANGLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.COUPLER_ROTATION_ANGLE`

#### Summary

"Coupler Rotation"

### `F:Autodesk.Revit.DB.BuiltInParameter.PREFER_DIM_SIDE_UI_FILTER`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PREFER_DIM_SIDE_UI_FILTER`

#### Summary

"Prefer:": This is used by the UI to allow select prefer dimension side.

### `F:Autodesk.Revit.DB.BuiltInParameter.MULTIPLE_ALIGNMENT_UI_TOGGLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.MULTIPLE_ALIGNMENT_UI_TOGGLE`

#### Summary

"Multiple Alignment": This is used by the UI to allow selection of multiple elements.

### `F:Autodesk.Revit.DB.BuiltInParameter.LOCK_ALIGNMENT_UI_TOGGLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LOCK_ALIGNMENT_UI_TOGGLE`

#### Summary

"Lock": This is used by the UI to allow selection of lock alignment.

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_BASE_EXTENSION_DIS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_BASE_EXTENSION_DIS`

#### Summary

"Base Extension Distance"

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_TOP_EXTENSION_DIS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_TOP_EXTENSION_DIS`

#### Summary

"Top Extension Distance"

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_FUNCTION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_FUNCTION`

#### Summary

"Function": Function

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_MATERIALS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_MATERIALS`

#### Summary

"Material": Material

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_THICKNESS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_THICKNESS`

#### Summary

"Thickness": Thickness

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_AREA_COMPUTED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_AREA_COMPUTED`

#### Summary

"Area"

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_OFFSET_FROM_HOST`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_OFFSET_FROM_HOST`

#### Summary

"Offset From Host"

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_VOLUME_COMPUTED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_VOLUME_COMPUTED`

#### Summary

"Volume"

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_TYPE_MATERIALS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_TYPE_MATERIALS`

#### Summary

"Material": Material

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_TYPE_THICKNESS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_TYPE_THICKNESS`

#### Summary

"Thickness": Thickness

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_BASE_CONSTRAINT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_BASE_CONSTRAINT`

#### Summary

"Base Constraint"

### `F:Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_TOP_CONSTRAINT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.LAYER_ELEM_TOP_CONSTRAINT`

#### Summary

"Top Constraint"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_INSTANCE_BAR_MODEL_DIAMETER`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_INSTANCE_BAR_MODEL_DIAMETER`

#### Summary

"Model Bar Diameter"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_MODEL_BAR_DIAMETER`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_MODEL_BAR_DIAMETER`

#### Summary

"Model Bar Diameter"

### `F:Autodesk.Revit.DB.BuiltInParameter.VIEW_SHOW_GRIDS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.VIEW_SHOW_GRIDS`

#### Summary

"Show Grids"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_MODIFIED_SET`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_MODIFIED_SET`

#### Summary

"Modified Rebar Set"

### `F:Autodesk.Revit.DB.BuiltInParameter.MOVES_WITH_GRID_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.MOVES_WITH_GRID_PARAM`

#### Summary

"Moves With Grids": Disable attachment from grids.

### `F:Autodesk.Revit.DB.BuiltInParameter.DPART_LAYER_INDEX`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.DPART_LAYER_INDEX`

#### Summary

"Layer Index"

### `F:Autodesk.Revit.DB.BuiltInParameter.VOID_CUTS_GEOMETRY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.VOID_CUTS_GEOMETRY`

#### Summary

"Cuts Geometry"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_HOOK_ROTATION_AT_END_SCHEDULES_TAGS_FILTERS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_HOOK_ROTATION_AT_END_SCHEDULES_TAGS_FILTERS`

#### Summary

"Hook Rotation At End"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_HOOK_ROTATION_AT_START_SCHEDULES_TAGS_FILTERS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_HOOK_ROTATION_AT_START_SCHEDULES_TAGS_FILTERS`

#### Summary

"Hook Rotation At Start"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_HOOK_LENGTH_OVERRIDE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_HOOK_LENGTH_OVERRIDE`

#### Summary

"Override Hook Lengths"

### `F:Autodesk.Revit.DB.BuiltInParameter.INFRASTRUCTURE_ALIGNMENT_NAME`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.INFRASTRUCTURE_ALIGNMENT_NAME`

#### Summary

"Name"

### `F:Autodesk.Revit.DB.BuiltInParameter.INFRASTRUCTURE_ALIGNMENT_DESCRIPTION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.INFRASTRUCTURE_ALIGNMENT_DESCRIPTION`

#### Summary

"Description"

### `F:Autodesk.Revit.DB.BuiltInParameter.INFRASTRUCTURE_ALIGNMENT_DISPLAYED_START_STATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.INFRASTRUCTURE_ALIGNMENT_DISPLAYED_START_STATION`

#### Summary

"Displayed Start Station"

### `F:Autodesk.Revit.DB.BuiltInParameter.INFRASTRUCTURE_ALIGNMENT_DISPLAYED_END_STATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.INFRASTRUCTURE_ALIGNMENT_DISPLAYED_END_STATION`

#### Summary

"Displayed End Station"

### `F:Autodesk.Revit.DB.BuiltInParameter.ASSEMBLY_PRECAST_FREEZE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.ASSEMBLY_PRECAST_FREEZE`

#### Summary

"Disable Precast Updates"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_HOOK_ROTATION_AT_END`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_HOOK_ROTATION_AT_END`

#### Summary

"Hook Rotation At End"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_HOOK_ROTATION_AT_START`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_HOOK_ROTATION_AT_START`

#### Summary

"Hook Rotation At Start"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_SHAPE_HOOK_ROTATION_AT_END`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_SHAPE_HOOK_ROTATION_AT_END`

#### Summary

"Hook Rotation At End"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_SHAPE_HOOK_ROTATION_AT_START`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_SHAPE_HOOK_ROTATION_AT_START`

#### Summary

"Hook Rotation At Start"

### `F:Autodesk.Revit.DB.BuiltInParameter.PATH_OF_TRAVEL_FROM_ROOM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PATH_OF_TRAVEL_FROM_ROOM`

#### Summary

"From Room"

### `F:Autodesk.Revit.DB.BuiltInParameter.PATH_OF_TRAVEL_TO_ROOM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PATH_OF_TRAVEL_TO_ROOM`

#### Summary

"To Room"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_ANALYTICAL_TOTAL_COINCIDENT_LOAD`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_ANALYTICAL_TOTAL_COINCIDENT_LOAD`

#### Summary

"Total Coincident Loads"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_NUMBER_OF_CIRCUITS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_NUMBER_OF_CIRCUITS`

#### Summary

"Max Number of Circuits"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PROFILE_VOLUME`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PROFILE_VOLUME`

#### Summary

"Volume"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PROFILE_LENGTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PROFILE_LENGTH`

#### Summary

"Length"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PROFILE_TYPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PROFILE_TYPE`

#### Summary

"Profile Type"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_EDIT_CIRCUIT_NAMING_SETTINGS_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_EDIT_CIRCUIT_NAMING_SETTINGS_PARAM`

#### Summary

"Circuit Naming Settings"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_JUSTIFICATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_JUSTIFICATION`

#### Summary

"Justification"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_PAINT_AREA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_PAINT_AREA`

#### Summary

"Paint Area"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_EXACT_WEIGHT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_EXACT_WEIGHT`

#### Summary

"Exact Weight"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_WEIGHT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_WEIGHT`

#### Summary

"Weight"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_VOLUME`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_VOLUME`

#### Summary

"Volume"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_AREA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_AREA`

#### Summary

"Area"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_WIDTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_WIDTH`

#### Summary

"Width"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_LENGTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_LENGTH`

#### Summary

"Length"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_TYPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_TYPE`

#### Summary

"Type"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_TOTAL_WEIGHT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_TOTAL_WEIGHT`

#### Summary

"Total Weight"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHEARSTUD_TOTAL_WEIGHT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHEARSTUD_TOTAL_WEIGHT`

#### Summary

"Total Weight"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_TOTAL_WEIGHT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_TOTAL_WEIGHT`

#### Summary

"Total Weight"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_ORIENTATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_ORIENTATION`

#### Summary

"Anchor Orientation"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_CUT_LENGTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_CUT_LENGTH`

#### Summary

"Cut Length"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_EXACT_WEIGHT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_EXACT_WEIGHT`

#### Summary

"Exact Weight"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PAINT_AREA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PAINT_AREA`

#### Summary

"Paint Area"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WEIGHT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WEIGHT`

#### Summary

"Weight"

### `F:Autodesk.Revit.DB.BuiltInParameter.PATH_OF_TRAVEL_SPEED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PATH_OF_TRAVEL_SPEED`

#### Summary

"Speed"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_LOCATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_LOCATION`

#### Summary

"Location"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_FINISH_CALCULATION_AT_GAP`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_FINISH_CALCULATION_AT_GAP`

#### Summary

"Finish Calculation At Gap"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_INVERTED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_INVERTED`

#### Summary

"Inverted"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_GRIP_LENGTH_INCREASE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_GRIP_LENGTH_INCREASE`

#### Summary

"Grip Length Increase"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_GRIP_LENGTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_GRIP_LENGTH`

#### Summary

"Grip Length"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_LENGTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_LENGTH`

#### Summary

"Bolt Length"

### `F:Autodesk.Revit.DB.BuiltInParameter.GENERIC_ZONE_NAME`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.GENERIC_ZONE_NAME`

#### Summary

"Name"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_PIPE_BOTTOM_ELEVATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_PIPE_BOTTOM_ELEVATION`

#### Summary

"Lower End Bottom Elevation"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_PIPE_TOP_ELEVATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_PIPE_TOP_ELEVATION`

#### Summary

"Upper End Top Elevation"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_CURRENT_PHASEC`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_CURRENT_PHASEC`

#### Summary

"Feed Through Lugs Current Phase C"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_CURRENT_PHASEB`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_CURRENT_PHASEB`

#### Summary

"Feed Through Lugs Current Phase B"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_CURRENT_PHASEA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_CURRENT_PHASEA`

#### Summary

"Feed Through Lugs Current Phase A"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_APPARENT_LOAD_PHASEC`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_APPARENT_LOAD_PHASEC`

#### Summary

"Feed Through Lugs Apparent Load Phase C"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_APPARENT_LOAD_PHASEB`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_APPARENT_LOAD_PHASEB`

#### Summary

"Feed Through Lugs Apparent Load Phase B"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_APPARENT_LOAD_PHASEA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_APPARENT_LOAD_PHASEA`

#### Summary

"Feed Through Lugs Apparent Load Phase A"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_BRANCH_CIRCUIT_CURRENT_PHASEC`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_BRANCH_CIRCUIT_CURRENT_PHASEC`

#### Summary

"Branch Circuit Current Phase C"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_BRANCH_CIRCUIT_CURRENT_PHASEB`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_BRANCH_CIRCUIT_CURRENT_PHASEB`

#### Summary

"Branch Circuit Current Phase B"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_BRANCH_CIRCUIT_CURRENT_PHASEA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_BRANCH_CIRCUIT_CURRENT_PHASEA`

#### Summary

"Branch Circuit Current Phase A"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_BRANCH_CIRCUIT_APPARENT_LOAD_PHASEC`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_BRANCH_CIRCUIT_APPARENT_LOAD_PHASEC`

#### Summary

"Branch Circuit Apparent Load Phase C"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_BRANCH_CIRCUIT_APPARENT_LOAD_PHASEB`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_BRANCH_CIRCUIT_APPARENT_LOAD_PHASEB`

#### Summary

"Branch Circuit Apparent Load Phase B"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_BRANCH_CIRCUIT_APPARENT_LOAD_PHASEA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_BRANCH_CIRCUIT_APPARENT_LOAD_PHASEA`

#### Summary

"Branch Circuit Apparent Load Phase A"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_DEFINITION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_DEFINITION`

#### Summary

"Hole Definition"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_PANEL_FEED_THRU_LUGS_PARAM`

#### Summary

"Feed Through Lugs"

### `F:Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_CIRCUIT_NUMBERING_TYPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.RBS_ELEC_CIRCUIT_NUMBERING_TYPE`

#### Summary

"Circuit Numbering Option"

### `F:Autodesk.Revit.DB.BuiltInParameter.TAG_ON_PLACEMENT_UI`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.TAG_ON_PLACEMENT_UI`

#### Summary

"Tag on Placement"

### `F:Autodesk.Revit.DB.BuiltInParameter.ROUTE_ANALYSIS_SETTINGS_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.ROUTE_ANALYSIS_SETTINGS_PARAM`

#### Summary

"Route Analysis Settings"

### `F:Autodesk.Revit.DB.BuiltInParameter.PATH_OF_TRAVEL_VIEW_NAME`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PATH_OF_TRAVEL_VIEW_NAME`

#### Summary

"View Name"

### `F:Autodesk.Revit.DB.BuiltInParameter.PATH_OF_TRAVEL_LEVEL_NAME`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PATH_OF_TRAVEL_LEVEL_NAME`

#### Summary

"Level"

### `F:Autodesk.Revit.DB.BuiltInParameter.STRUCTURAL_CONNECTION_OVERRIDE_TYPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STRUCTURAL_CONNECTION_OVERRIDE_TYPE`

#### Summary

"Override by Instance"

### `F:Autodesk.Revit.DB.BuiltInParameter.STRUCTURAL_CONNECTION_EDIT_TYPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STRUCTURAL_CONNECTION_EDIT_TYPE`

#### Summary

"Modify Parameters"

### `F:Autodesk.Revit.DB.BuiltInParameter.PATH_OF_TRAVEL_TIME`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.PATH_OF_TRAVEL_TIME`

#### Summary

"Time"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ZCLIP_TYPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ZCLIP_TYPE`

#### Summary

"Boundary"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COPE_AROUND_AXIS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COPE_AROUND_AXIS`

#### Summary

"Around beam axis"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COPE_AXIS_ANGLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COPE_AXIS_ANGLE`

#### Summary

"Tilt angle"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COPE_Z_ANGLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COPE_Z_ANGLE`

#### Summary

"Plan rotation"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COPE_X_ANGLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COPE_X_ANGLE`

#### Summary

"Cross-section rotation"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COPE_DISTANCE_AXIS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COPE_DISTANCE_AXIS`

#### Summary

"Distance from axis"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COPE_WIDTHX`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COPE_WIDTHX`

#### Summary

"Cutback"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_Y_DISTANCE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_Y_DISTANCE`

#### Summary

"Side 2"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_X_DISTANCE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_X_DISTANCE`

#### Summary

"Side 1"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_CUT_TYPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_CUT_TYPE`

#### Summary

"Type"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_SHORTEN_CUTSTRAIGHT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_SHORTEN_CUTSTRAIGHT`

#### Summary

"Cut straight"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_SHORTEN_SUCTION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_SHORTEN_SUCTION`

#### Summary

"Suction"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_SHORTEN_ANGLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_SHORTEN_ANGLE`

#### Summary

"Angle"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_PREFIX`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_PREFIX`

#### Summary

"Prefix"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_TEXT_MODULE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_TEXT_MODULE`

#### Summary

"Text module"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_DEPTH_OF_BOLT_HEAD`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_DEPTH_OF_BOLT_HEAD`

#### Summary

"Depth of bolt head"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_TAPPING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_TAPPING`

#### Summary

"Right-handed thread"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_BACK_TAPER_THREAD`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_BACK_TAPER_THREAD`

#### Summary

"Back taper thread"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_TAPPING_HOLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_TAPPING_HOLE`

#### Summary

"Tapping hole"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_HEAD_DIAMETER`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_HEAD_DIAMETER`

#### Summary

"Head diameter"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_ANGLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_ANGLE`

#### Summary

"Chamfer angle"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_ALPHA`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_ALPHA`

#### Summary

"Taper Angle"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_DEPTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_DEPTH`

#### Summary

"Hole Depth"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_SLOT_DIRECTION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_SLOT_DIRECTION`

#### Summary

"Along side 1"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_SLOT_LENGTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_SLOT_LENGTH`

#### Summary

"Length of the slot"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_TYPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_TYPE`

#### Summary

"Type"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_DIAMETER`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_HOLE_DIAMETER`

#### Summary

"Diameter"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_NUMBER`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_NUMBER`

#### Summary

"Number"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_RADIUS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_RADIUS`

#### Summary

"Radius"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_EDGE_DISTANCE_Y`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_EDGE_DISTANCE_Y`

#### Summary

"Edge distance on side 2"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_EDGE_DISTANCE_X`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_EDGE_DISTANCE_X`

#### Summary

"Edge distance on side 1"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_INTERMEDIATE_DISTANCE_Y`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_INTERMEDIATE_DISTANCE_Y`

#### Summary

"Intermediate distance on side 2"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_INTERMEDIATE_DISTANCE_X`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_INTERMEDIATE_DISTANCE_X`

#### Summary

"Intermediate distance on side 1"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_TOTAL_WIDTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_TOTAL_WIDTH`

#### Summary

"Length on side 2"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_TOTAL_LENGTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_TOTAL_LENGTH`

#### Summary

"Length on side 1"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_NUMBER_Y`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_NUMBER_Y`

#### Summary

"Number on side 2"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_NUMBER_X`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PATTERN_NUMBER_X`

#### Summary

"Number on side 1"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_PREPDEPTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_PREPDEPTH`

#### Summary

"Double Preparation Depth"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_EFFECTIVETHROAT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_EFFECTIVETHROAT`

#### Summary

"Double Effective Throat"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_ROOTOPENING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_ROOTOPENING`

#### Summary

"Double Root Opening"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_WELDPREP`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_WELDPREP`

#### Summary

"Double Weld preparation"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_SURFACESHAPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_SURFACESHAPE`

#### Summary

"Double Surface Shape"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_TEXT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_TEXT`

#### Summary

"Double Text"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_THICKNESS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_THICKNESS`

#### Summary

"Double Thickness"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_TYPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_DOUBLE_TYPE`

#### Summary

"Double Type"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_PREPDEPTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_PREPDEPTH`

#### Summary

"Main Preparation Depth"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_EFFECTIVETHROAT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_EFFECTIVETHROAT`

#### Summary

"Main Effective Throat"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_ROOTOPENING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_ROOTOPENING`

#### Summary

"Main Root Opening"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_WELDPREP`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_WELDPREP`

#### Summary

"Main Weld preparation"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_SURFACESHAPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_SURFACESHAPE`

#### Summary

"Surface Shape"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_TEXT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_TEXT`

#### Summary

"Main Text"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_PITCH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_PITCH`

#### Summary

"Pitch"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_CONTINUOUS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_CONTINUOUS`

#### Summary

"Continuous"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_LOCATION`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_LOCATION`

#### Summary

"Location"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_LENGTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_LENGTH`

#### Summary

"Length"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_THICKNESS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_THICKNESS`

#### Summary

"Main Thickness"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_TYPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_WELD_MAIN_TYPE`

#### Summary

"Main Type"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PARAM_BORINGOUT`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PARAM_BORINGOUT`

#### Summary

"Boring out"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PARAM_RADIUS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PARAM_RADIUS`

#### Summary

"Radius"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_CONTOUR_SIDE2DIST`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_CONTOUR_SIDE2DIST`

#### Summary

"Boundary distance 2"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_CONTOUR_SIDE1DIST`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_CONTOUR_SIDE1DIST`

#### Summary

"Boundary distance 1"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_CONTOUR_GAP_WIDTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_CONTOUR_GAP_WIDTH`

#### Summary

"Gap Width"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHORTEN_ANGLEZ`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHORTEN_ANGLEZ`

#### Summary

"Angle along width"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHORTEN_ANGLEY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHORTEN_ANGLEY`

#### Summary

"Angle along height"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHORTEN_REFLENGTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHORTEN_REFLENGTH`

#### Summary

"Length"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHEARSTUD_LENGTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHEARSTUD_LENGTH`

#### Summary

"Length"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_COATING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_COATING`

#### Summary

"Coating"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_LENGTH`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_LENGTH`

#### Summary

"Length"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHEARSTUD_DIAMETER`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHEARSTUD_DIAMETER`

#### Summary

"Diameter"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHEARSTUD_GRADE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHEARSTUD_GRADE`

#### Summary

"Grade"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHEARSTUD_STANDARD`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_SHEARSTUD_STANDARD`

#### Summary

"Standard"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_DIAMETER`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_DIAMETER`

#### Summary

"Diameter"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_ASSEMBLY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_ASSEMBLY`

#### Summary

"Assembly"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_GRADE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_GRADE`

#### Summary

"Grade"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_STANDARD`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_ANCHOR_STANDARD`

#### Summary

"Standard"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COATING`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_COATING`

#### Summary

"Coating"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_DIAMETER`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_DIAMETER`

#### Summary

"Diameter"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_ASSEMBLY`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_ASSEMBLY`

#### Summary

"Assembly"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_GRADE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_GRADE`

#### Summary

"Grade"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_STANDARD`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_BOLT_STANDARD`

#### Summary

"Standard"

### `F:Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_THICKNESS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.STEEL_ELEM_PLATE_THICKNESS`

#### Summary

"Thickness"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_WORKSHOP_INSTRUCTIONS`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_WORKSHOP_INSTRUCTIONS`

#### Summary

"Workshop Instructions"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_GEOMETRY_TYPE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_GEOMETRY_TYPE`

#### Summary

"Geometry"

### `F:Autodesk.Revit.DB.BuiltInParameter.BASEPOINT_LATITUDE_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BASEPOINT_LATITUDE_PARAM`

#### Summary

"Lat"

### `F:Autodesk.Revit.DB.BuiltInParameter.BASEPOINT_LONGITUDE_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.BASEPOINT_LONGITUDE_PARAM`

#### Summary

"Lon"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_FREE_FORM_HOOK_END_PLANE_ANGLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_FREE_FORM_HOOK_END_PLANE_ANGLE`

#### Summary

"Hook Orientation At End"

### `F:Autodesk.Revit.DB.BuiltInParameter.REBAR_FREE_FORM_HOOK_START_PLANE_ANGLE`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.REBAR_FREE_FORM_HOOK_START_PLANE_ANGLE`

#### Summary

"Hook Orientation At Start"

### `F:Autodesk.Revit.DB.BuiltInParameter.ROOM_OUTDOOR_AIRFLOW_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.ROOM_OUTDOOR_AIRFLOW_PARAM`

#### Summary

"Outdoor Airflow"

### `F:Autodesk.Revit.DB.BuiltInParameter.ROOM_OUTDOOR_AIRFLOW_STANDARD_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.ROOM_OUTDOOR_AIRFLOW_STANDARD_PARAM`

#### Summary

"Outdoor Air Method"

### `F:Autodesk.Revit.DB.BuiltInParameter.DIRECTCONTEXT3D_SOURCE_ID`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.DIRECTCONTEXT3D_SOURCE_ID`

#### Summary

"Path"

### `F:Autodesk.Revit.DB.BuiltInParameter.DIRECTCONTEXT3D_APPLICATION_ID`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.DIRECTCONTEXT3D_APPLICATION_ID`

#### Summary

"ApplicationId"

### `F:Autodesk.Revit.DB.BuiltInParameter.DIRECTCONTEXT3D_LOADED`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.DIRECTCONTEXT3D_LOADED`

#### Summary

"Loaded"

### `F:Autodesk.Revit.DB.BuiltInParameter.DIRECTCONTEXT3D_SERVER_ID`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.DIRECTCONTEXT3D_SERVER_ID`

#### Summary

"ServerId"

### `F:Autodesk.Revit.DB.BuiltInParameter.DIRECTCONTEXT3D_NAME`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.DIRECTCONTEXT3D_NAME`

#### Summary

"Name"

### `F:Autodesk.Revit.DB.BuiltInParameter.ROOM_AIR_CHANGES_PER_HOUR_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.ROOM_AIR_CHANGES_PER_HOUR_PARAM`

#### Summary

"Air Changes per Hour"

### `F:Autodesk.Revit.DB.BuiltInParameter.ROOM_OUTDOOR_AIR_PER_AREA_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.ROOM_OUTDOOR_AIR_PER_AREA_PARAM`

#### Summary

"Outdoor Air per Area"

### `F:Autodesk.Revit.DB.BuiltInParameter.ROOM_OUTDOOR_AIR_PER_PERSON_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.ROOM_OUTDOOR_AIR_PER_PERSON_PARAM`

#### Summary

"Outdoor Air per Person"

### `F:Autodesk.Revit.DB.BuiltInParameter.ROOM_OUTDOOR_AIR_INFO_PARAM`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuiltInParameter.ROOM_OUTDOOR_AIR_INFO_PARAM`

#### Summary

"Outdoor Air Information"
