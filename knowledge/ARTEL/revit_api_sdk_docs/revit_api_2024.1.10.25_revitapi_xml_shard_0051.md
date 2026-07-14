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
Shard: 51
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.GlobalParametersManager.CanElementParameterBeAssociated(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.CanElementParameterBeAssociated(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Tests whether a given parameter of an element can be associated with a global parameter.

#### Remarks

Only properties defined as parametrizable can be associated with global parameters.
That excludes any read-only and formula-driven parameters, as well as those that
have other explicit or implicit restrictions imposed by Revit.

#### Parameter `document`

Document containing the given element and its parameter

#### Parameter `elementId`

Id of an element in the given document

#### Parameter `parameterId`

Id of the given element's parameter

#### Returns

True if the given parameter can be associated (is parametrizable); False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementId does not exist in the document

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.GlobalParametersManager.MoveParameterDownOrder(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.MoveParameterDownOrder(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Moves given paramerer Down in the current order.

#### Remarks

A parameter can only be moved within its parameter group, meaning that
repeated moving a parameter will not push the parameter out of and into
the next (in order) parameter group. When a parameter can no longer move
because it is at the boundary of its group, this method returns False.

This operation has no effect on the global parameters themselves.
The rearranged order is only visible in the standard Global Parameters
dialog. However, the order of parameters is serialized in the document,
thus available on the DB level as well.

#### Parameter `document`

Document containing the give global parameter

#### Parameter `parameterId`

The parameter to move Down

#### Returns

Indicates whether the parameter could be moved Down in order or not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Global parameters are not supported in the given document.
A possible cause is that it is not a project document,
for global parameters are not supported in Revit families.
-or-
The input parameterId is not of a valid global parameter of the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.GlobalParametersManager.MoveParameterUpOrder(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.MoveParameterUpOrder(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Moves given paramerer Up in the current order.

#### Remarks

A parameter can only be moved within its parameter group, meaning that
repeated moving a parameter will not push the parameter out of and into
the next (in order) parameter group. When a parameter can no longer move
because it is at the boundary of its group, this method returns False.

This operation has no effect on the global parameters themselves.
The rearranged order is only visible in the standard Global Parameters
dialog. However, the order of parameters is serialized in the document,
thus available on the DB level as well.

#### Parameter `document`

Document containing the give global parameter

#### Parameter `parameterId`

The parameter to move up

#### Returns

Indicates whether the parameter could be moved Up in order or not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Global parameters are not supported in the given document.
A possible cause is that it is not a project document,
for global parameters are not supported in Revit families.
-or-
The input parameterId is not of a valid global parameter of the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.GlobalParametersManager.SortParameters(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ParametersOrder)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.SortParameters(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ParametersOrder)`

#### Summary

Sorts global parameters in the desired order.

#### Remarks

All global parameters are sorted, but only within the range
of their respective parameter group.

This operation has no effect on the global parameters themselves.
The sorted order is only visible in the standard Global Parameters
dialog. However, the order of parameters is serialized in the document,
thus available on the DB level as well.

#### Parameter `document`

Document containing the global parameters to be sorted

#### Parameter `order`

Desired sorting order

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Global parameters are not supported in the given document.
A possible cause is that it is not a project document,
for global parameters are not supported in Revit families.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `M:Autodesk.Revit.DB.GlobalParametersManager.GetGlobalParametersOrdered(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.GetGlobalParametersOrdered(Autodesk.Revit.DB.Document)`

#### Summary

Returns all global paramters in an ordered array.

#### Remarks

The order of the items coresponds to the order at which global parameters
appear in Revit UI when shown in the standard Global Parameters dialog.
However, the order of parameters is serialized in the document,
thus available on the DB level as well.

#### Parameter `document`

Document containing the requested global parameters

#### Returns

An array of Element Ids of all Global Parameters in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Global parameters are not supported in the given document.
A possible cause is that it is not a project document,
for global parameters are not supported in Revit families.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.GlobalParametersManager.IsUniqueName(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.IsUniqueName(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Tests whether a name is unique among existing global parameters of a given document.

#### Remarks

Typically, this method is used before a new global parameters is created, for
all global parameters must have their names unique in the scope of a document.

#### Parameter `document`

Document in which a new parameter is to be added.

#### Parameter `name`

A name of a parameter being added.

#### Returns

True if the given %name% does not exist yet among existing global parameters nof the document; False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.GlobalParametersManager.IsValidGlobalParameter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.IsValidGlobalParameter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Tests whether an ElementId is of a global parameter in the given document.

#### Parameter `document`

The document containing the global parameter.

#### Parameter `parameterId`

Id of a global parameter

#### Returns

Returns True if the Id is of a valid global parameter; False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.GlobalParametersManager.FindByName(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.FindByName(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Finds whether a global parameter with the given name exists in the input document.

#### Remarks

No exception is thrown when no parameter with such a name exists in the document;
instead, the method returns an ElementId.InvalidElementId.

#### Parameter `document`

The document expected to contain the global parameter.

#### Parameter `name`

Name of the global parameter

#### Returns

ElementId of the parameter element, or InvalidElementId if it was not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.GlobalParametersManager.GetAllGlobalParameters(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.GetAllGlobalParameters(Autodesk.Revit.DB.Document)`

#### Summary

Returns all global parameters available in the given document.

#### Parameter `document`

The document containing the global parameters

#### Returns

A collection of Element Ids of global parameter elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Global parameters are not supported in the given document.
A possible cause is that it is not a project document,
for global parameters are not supported in Revit families.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.GlobalParametersManager.AreGlobalParametersAllowed(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.AreGlobalParametersAllowed(Autodesk.Revit.DB.Document)`

#### Summary

Tests whether global parameters are allowed in the given document.

#### Remarks

First of all, global parameters can be had in main project documents only;
they are not supported in family documents. However, there may also be other
circumstances due to which global parameters may be disallowed in a particular
project, either temporarily or permanently.

#### Parameter `document`

A revit document of interest.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `P:Autodesk.Revit.DB.GlobalParametersManager.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.GlobalParametersManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.GlobalParametersManager`

#### Summary

A class to access and query information about global parameters in Revit models.

#### Remarks

This class provides access to general information and data of Global Parameter
elements in a particular model. First of all, it is important to know that global
parameters can be had in main project document; there are not supported in family
documents. Availability of global parameters in a document can be tested by calling
`M:Autodesk.Revit.DB.GlobalParametersManager.AreGlobalParametersAllowed(Autodesk.Revit.DB.Document)` method.

Global Parameter in a document can be obtained by calling either
`M:Autodesk.Revit.DB.GlobalParametersManager.GetAllGlobalParameters(Autodesk.Revit.DB.Document)` or `M:Autodesk.Revit.DB.GlobalParametersManager.FindByName(Autodesk.Revit.DB.Document,System.String)` .
The former returns a set of all global parameters in the document,
while the latter returns just the requested one, providing it exists.

Each global parameters must be created with a valid name that is unique
in the scope of the document. To test whether a particular name is unique,
programmer can use the `M:Autodesk.Revit.DB.GlobalParametersManager.IsUniqueName(Autodesk.Revit.DB.Document,System.String)` method.

More details about creating and manipulating global parameters can be found
in the description of the `T:Autodesk.Revit.DB.GlobalParameter` class.

#### Since

2016 Subscription Update

### `T:Autodesk.Revit.DB.ParametersOrder`

Member kind: type
Symbol: `Autodesk.Revit.DB.ParametersOrder`

#### Summary

The order of the parameters.

#### Since

2015

#### Since

2015

### `F:Autodesk.Revit.DB.ParametersOrder.Descending`

Member kind: field
Symbol: `Autodesk.Revit.DB.ParametersOrder.Descending`

#### Summary

Sort parameters are in descending(Z-A) order.

### `F:Autodesk.Revit.DB.ParametersOrder.Ascending`

Member kind: field
Symbol: `Autodesk.Revit.DB.ParametersOrder.Ascending`

#### Summary

Sort parameters are in ascending(A-Z) order.

### `P:Autodesk.Revit.DB.Category.IsVisibleInUI`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.IsVisibleInUI`

#### Summary

Identifies if the category is visible to the user and should be displayed in UI.

#### Value

True if the category should be displayed in UI.

#### Since

2020

### `P:Autodesk.Revit.DB.Category.BuiltInCategory`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.BuiltInCategory`

#### Summary

Gets the `P:Autodesk.Revit.DB.Category.BuiltInCategory` value for this category.

#### Value

BuiltInCategory value for the category or `!:Autodesk::Revit::DB::Category::BuiltInCategory::INVALID`
if the category is not a built-in category.

#### Since

2023

### `P:Autodesk.Revit.DB.Category.CategoryType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.CategoryType`

#### Summary

Gets the category type of this category.

#### Remarks

The category type determines if the category is shown in the Visibility/Graphics settings
grouped with the model,annotation, or analytical model categories.
Note that import categories are also "model" but will be shown separately in the dialog.
Some categories not shown in the dialog and will return Internal for the category type.

#### Since

2015

### `P:Autodesk.Revit.DB.Category.IsTagCategory`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.IsTagCategory`

#### Summary

Identifies if the category is associated with a type of tag for a different category.

#### Value

True if the category is associated with a type of tag for a different category, false if not.

#### Since

2015

### `P:Autodesk.Revit.DB.Category.HasMaterialQuantities`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.HasMaterialQuantities`

#### Summary

Identifies if elements of the category are able to report what materials they contain in what quantities.

#### Remarks

Get materials via the Element' property Materials;
Get quantities via methods GetMaterialArea and GetMaterialVolume.

### `P:Autodesk.Revit.DB.Category.AllowsVisibilityControl(Autodesk.Revit.DB.View)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.AllowsVisibilityControl(Autodesk.Revit.DB.View)`

#### Summary

Whether the visibility can be controlled by the user for this category in this view.

#### Remarks

There are some categories in Revit that are hidden to users in the Object Styles and
Visibility dialog. Their visibility cannot be controlled for a particular view. This property
identifies if the category allows visibility control (and thus allows the Visible property to
be set).

#### Parameter `view`

The view where visibility control might be allowed.

### `P:Autodesk.Revit.DB.Category.AllowsBoundParameters`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.AllowsBoundParameters`

#### Summary

To check if the category can have project parameters.

### `P:Autodesk.Revit.DB.Category.Visible(Autodesk.Revit.DB.View)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.Visible(Autodesk.Revit.DB.View)`

#### Summary

Retrieves or changes the visibility of the category in the active view.

#### Remarks

This affects only if the category is set visible or invisible individually. Other Revit mechanisms
may also affect the visibility of elements of this category, including:
the category classes settings for
model categories, annotation categories, import categories or analytical model categories.

view filters
Thus setting this value may not affect the actual visibility of elements of this category in the view.

### `P:Autodesk.Revit.DB.Category.Material`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.Material`

#### Summary

Retrieves or changes the material of the category.

#### Value

`null` if this category does not have a material.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: material cannot be set for annotation categories.

### `P:Autodesk.Revit.DB.Category.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.Id`

#### Summary

Returns the category id associated with the category object.

### `P:Autodesk.Revit.DB.Category.Parent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.Parent`

#### Summary

Returns the parent category of this category.

#### Returns

`null` if this category a not a subcategory

### `P:Autodesk.Revit.DB.Category.SubCategories`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.SubCategories`

#### Summary

Returns a map containing all of the subcategories of this category.

#### Returns

An empty map if the category has no subcategories.

### `M:Autodesk.Revit.DB.Category.IsBuiltInCategory(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Category.IsBuiltInCategory(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether a ForgeTypeId identifies a built-in category.

#### Remarks

A ForgeTypeId identifies a built-in category if it corresponds to a valid
BuiltInCategory value according to
`M:Autodesk.Revit.DB.Category.IsBuiltInCategoryValid(Autodesk.Revit.DB.BuiltInCategory)` and
`M:Autodesk.Revit.DB.Category.GetBuiltInCategoryTypeId(Autodesk.Revit.DB.BuiltInCategory)` .

#### Parameter `categoryTypeId`

The identifier to check.

#### Returns

True if the ForgeTypeId identifies a built-in category, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.Category.GetBuiltInCategory(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Category.GetBuiltInCategory(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the BuiltInCategory value corresponding to the given built-in category identifier.

#### Remarks

A ForgeTypeId identifies a built-in category if it corresponds to a valid
BuiltInCategory value according to
`M:Autodesk.Revit.DB.Category.IsBuiltInCategory(Autodesk.Revit.DB.ForgeTypeId)` and
`M:Autodesk.Revit.DB.Category.GetBuiltInCategoryTypeId(Autodesk.Revit.DB.BuiltInCategory)` .

#### Parameter `categoryTypeId`

The built-in category identifier.

#### Returns

The BuiltInCategory value corresponding to the given built-in category identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

categoryTypeId is not a built-in category identifier. See Category.IsBuiltInCategory(ForgeTypeId) and Category.GetBuiltInCategoryTypeId(BuiltInCategory).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.Category.GetBuiltInCategoryTypeId(Autodesk.Revit.DB.BuiltInCategory)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Category.GetBuiltInCategoryTypeId(Autodesk.Revit.DB.BuiltInCategory)`

#### Summary

Gets the ForgeTypeId identifying the given built-in category.

#### Remarks

The given BuiltInCategory value must be valid according to
`M:Autodesk.Revit.DB.Category.IsBuiltInCategoryValid(Autodesk.Revit.DB.BuiltInCategory)` .

#### Parameter `categoryId`

The built-in category.

#### Returns

The identifier of the given built-in category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

categoryId is not a valid built-in category. See Category.IsBuiltInCategoryValid(BuiltInCategory).

#### Since

2022

### `M:Autodesk.Revit.DB.Category.IsBuiltInCategoryValid(Autodesk.Revit.DB.BuiltInCategory)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Category.IsBuiltInCategoryValid(Autodesk.Revit.DB.BuiltInCategory)`

#### Summary

Checks if a Category exists for a given BuiltInCategory.

#### Parameter `builtInCategory`

The BuiltInCategory to check.

#### Remarks

Some BuiltInCategory values are obsolete and are kept for upgrade reasons. For those no Category exists.

#### Since

2020

### `M:Autodesk.Revit.DB.Category.GetCategory(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Category.GetCategory(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Retrieves a category object corresponding to the category id.

#### Parameter `document`

The document.

#### Parameter `categoryId`

An category id.

#### Returns

Returns a category object corresponding to the category id.

#### Since

2016

### `M:Autodesk.Revit.DB.Category.GetCategory(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.BuiltInCategory)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Category.GetCategory(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.BuiltInCategory)`

#### Summary

Retrieves a category object corresponding to a BuiltInCategory id.

#### Parameter `document`

The document.

#### Parameter `categoryId`

A built in category id.

#### Returns

Returns a category object corresponding to a BuiltInCategory id.

#### Since

2016

### `M:Autodesk.Revit.DB.Category.GetGraphicsStyle(Autodesk.Revit.DB.GraphicsStyleType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Category.GetGraphicsStyle(Autodesk.Revit.DB.GraphicsStyleType)`

#### Summary

Gets the graphics style associated with this category for the given graphics style type.

#### Parameter `graphicsStyleType`

The type of graphics style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument-"graphicsStyleType"-is out of range.

### `M:Autodesk.Revit.DB.Category.SetLinePatternId(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.GraphicsStyleType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Category.SetLinePatternId(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.GraphicsStyleType)`

#### Summary

Sets the line pattern id associated with this category for the given graphics style type.

#### Remarks

The line pattern id will be one of the following:

A negative value (representing a built-in line pattern); this value can only be obtained via GetLinePatternId

The id of a LinePatternElement

#### Parameter `linePatternId`

The line pattern id for the graphics style.

#### Parameter `graphicsStyleType`

The type of graphics style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument "linePatternId" is an illegal id.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this category does not have stored line pattern id for this graphics style type.

#### Since

2017

### `M:Autodesk.Revit.DB.Category.GetLinePatternId(Autodesk.Revit.DB.GraphicsStyleType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Category.GetLinePatternId(Autodesk.Revit.DB.GraphicsStyleType)`

#### Summary

Gets the line pattern id associated with this category for the given graphics style type.

#### Remarks

The line pattern id will be one of the following:

A negative value (representing a built-in line pattern)

The id of a LinePatternElement

InvalidElementId, indicating that this category does not have a stored line pattern id for this graphics style type.

#### Parameter `graphicsStyleType`

The type of graphics style.

#### Returns

Returns the line pattern id associated with this category for the given graphics style type.

#### Since

2017

### `M:Autodesk.Revit.DB.Category.SetLineWeight(System.Int32,Autodesk.Revit.DB.GraphicsStyleType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Category.SetLineWeight(System.Int32,Autodesk.Revit.DB.GraphicsStyleType)`

#### Summary

Sets the line weight for the given graphics style type.

#### Parameter `graphicsStyleType`

The type of graphics style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument-"lineWeight" or "graphicsStyleType"-is out of range.

### `M:Autodesk.Revit.DB.Category.GetLineWeight(Autodesk.Revit.DB.GraphicsStyleType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Category.GetLineWeight(Autodesk.Revit.DB.GraphicsStyleType)`

#### Summary

Retrieves the line weight assigned to the category for the given graphics style type.

#### Parameter `graphicsStyleType`

The type of graphics style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument-"graphicsStyleType"-is out of range.

### `P:Autodesk.Revit.DB.Category.CanAddSubcategory`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.CanAddSubcategory`

#### Summary

Indicates if subcategories can be assigned to the category.

### `P:Autodesk.Revit.DB.Category.IsCuttable`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.IsCuttable`

#### Summary

Indicates if the category is cuttable or not.

### `P:Autodesk.Revit.DB.Category.LineColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.LineColor`

#### Summary

The color of lines shown for elements of this category.

### `P:Autodesk.Revit.DB.Category.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.Name`

#### Summary

The category name.

### `P:Autodesk.Revit.DB.Category.IsValid`

Member kind: property
Symbol: `Autodesk.Revit.DB.Category.IsValid`

#### Summary

Indicates if the Category is valid or not.

#### Remarks

A valid Category is one which is present in the Document's Categories.

#### Since

2023.1

### `T:Autodesk.Revit.DB.Category`

Member kind: type
Symbol: `Autodesk.Revit.DB.Category`

#### Summary

Represents the category or subcategory to which an element belongs.

#### Remarks

Categories are an important tool within Revit for identifying the inferred type of an
element, such as anything in the Walls category should be considered as a wall. The API
exposes access to the built in categories within Revit via the Document.Settings.Categories
property.

### `M:Autodesk.Revit.DB.Material.ClearMaterialAspect(Autodesk.Revit.DB.MaterialAspect)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Material.ClearMaterialAspect(Autodesk.Revit.DB.MaterialAspect)`

#### Summary

Removes an aspect from the material.

#### Parameter `aspect`

The material aspect.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.Material.SetMaterialAspectByPropertySet(Autodesk.Revit.DB.MaterialAspect,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Material.SetMaterialAspectByPropertySet(Autodesk.Revit.DB.MaterialAspect,Autodesk.Revit.DB.ElementId)`

#### Summary

Sets an aspect of the material to a shared property set.

#### Parameter `aspect`

The material aspect.

#### Parameter `propertySetId`

Identifier of a shared property set (an instance of PropertySetElement).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.Material.Duplicate(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Material.Duplicate(System.String)`

#### Summary

Duplicates the material

#### Remarks

If duplication fails for reasons unrelated to the name, `null` will be returned.

#### Parameter `name`

Name of the new material - this name must be correctly structured for Revit use and not duplicate the name
of another material in the document.

#### Returns

The new material.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
The given value for name is already in use as a material element name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Material.IsNameUnique(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Material.IsNameUnique(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Validates whether the material name is unique in document.

#### Parameter `aDocument`

The document in which the name is being tested for uniqueness.

#### Parameter `name`

The name tested for uniqueness.

#### Returns

Returns true if the name is unique, and false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Material.IsMaterialOrValidDefault(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Material.IsMaterialOrValidDefault(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.ElementId)`

#### Summary

Validates whether the specified element id is a material element.

#### Parameter `pElem`

An element which will be applied the material

#### Parameter `materialId`

The element id to be checked.

#### Returns

True if the element a material element or invalidElementId, which means take material from category, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Material.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Material.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new material.

#### Parameter `document`

The document in which to create the material.

#### Parameter `name`

The name of the new material.

#### Returns

Identifier of the new material.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
The given value for name is already in use as a material element name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.Material.MaterialCategory`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.MaterialCategory`

#### Summary

The name of the material category, e.g. 'Wood'

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.Material.MaterialClass`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.MaterialClass`

#### Summary

The name of the general material type, e.g. 'Wood.'

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.Material.ThermalAssetId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.ThermalAssetId`

#### Summary

The ElementId of the thermal PropertySetElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.Material.StructuralAssetId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.StructuralAssetId`

#### Summary

The ElementId of the structural PropertySetElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.Material.AppearanceAssetId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.AppearanceAssetId`

#### Summary

The ElementId of the AppearanceAssetElement.

#### Remarks

This is the id to the element that contains visual material information used for rendering.
In some cases where the material is created without setting up custom render appearance properties
(for example, when the material is created via an import, or when it is created by the API),
this property will be InvalidElementId. In that situation the standard material properties such as
`P:Autodesk.Revit.DB.Material.Color` and `P:Autodesk.Revit.DB.Material.Transparency` will dictate the appearance of the material during rendering.

#### Value

The id of the AppearanceAssetElement, or InvalidElementId if the material does not have an associated
appearance asset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Material.SurfaceBackgroundPatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.SurfaceBackgroundPatternId`

#### Summary

The id of the FillPatternElement used as the background pattern of faces with this material in normal views.

#### Remarks

The FillPattern used for a background pattern must have a 'Drafting' target.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The element id must represent a valid FillPatternElement.
-or-
When setting this property: The FillPattern target must be a drafting pattern.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Material.CutBackgroundPatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.CutBackgroundPatternId`

#### Summary

The id of the FillPatternElement used as the background pattern of faces with this material in cut views.

#### Remarks

The FillPattern used for a cut pattern must have a 'Drafting' target.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The element id must represent a valid FillPatternElement.
-or-
When setting this property: The FillPattern target must be a drafting pattern.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Material.SurfaceForegroundPatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.SurfaceForegroundPatternId`

#### Summary

The id of the FillPatternElement used as the foreground pattern of faces with this material in normal views.

#### Remarks

The FillPattern used for a surface foreground pattern can have a 'Drafting' or a 'Model' target.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The element id must represent a valid FillPatternElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Material.CutForegroundPatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.CutForegroundPatternId`

#### Summary

The id of the FillPatternElement used as the foreground pattern of faces with this material in cut views.

#### Remarks

The FillPattern used for a cut foreground pattern must have a 'Drafting' target.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The element id must represent a valid FillPatternElement.
-or-
When setting this property: The FillPattern target must be a drafting pattern.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Material.CutBackgroundPatternColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.CutBackgroundPatternColor`

#### Summary

The color of the material cut background pattern.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Material.SurfaceBackgroundPatternColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.SurfaceBackgroundPatternColor`

#### Summary

The color of the material surface background pattern.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Material.CutForegroundPatternColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.CutForegroundPatternColor`

#### Summary

The color of the material cut foreground pattern.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Material.SurfaceForegroundPatternColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.SurfaceForegroundPatternColor`

#### Summary

The color of the material surface foreground pattern.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Material.Color`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.Color`

#### Summary

The color of the material.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.Material.Transparency`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.Transparency`

#### Summary

The transparency of the material.

#### Value

The value ranges from 0 to 100.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: values for shininess must be between 0 and 128

### `P:Autodesk.Revit.DB.Material.Smoothness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.Smoothness`

#### Summary

The smoothness of the material.

#### Value

The value ranges from 0 to 100.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: values for shininess must be between 0 and 128

### `P:Autodesk.Revit.DB.Material.Shininess`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.Shininess`

#### Summary

The shininess of the material.

#### Value

The value ranges from 0 to 128.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: values for shininess must be between 0 and 128

### `P:Autodesk.Revit.DB.Material.UseRenderAppearanceForShading`

Member kind: property
Symbol: `Autodesk.Revit.DB.Material.UseRenderAppearanceForShading`

#### Summary

True to use the render appearance settings for shaded view appearance;
false to use the material's color and transparency value for shaded view appearance.

#### Since

2015

### `T:Autodesk.Revit.DB.Material`

Member kind: type
Symbol: `Autodesk.Revit.DB.Material`

#### Summary

Represents a material element within an Autodesk Revit project.

### `T:Autodesk.Revit.DB.MaterialAspect`

Member kind: type
Symbol: `Autodesk.Revit.DB.MaterialAspect`

#### Summary

A list of all material aspects that a material can store PropertySetElements for.

#### Since

2012

### `F:Autodesk.Revit.DB.MaterialAspect.Thermal`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialAspect.Thermal`

#### Summary

Thermal

### `F:Autodesk.Revit.DB.MaterialAspect.Structural`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialAspect.Structural`

#### Summary

Structural

### `P:Autodesk.Revit.DB.GraphicsStyle.GraphicsStyleType`

Member kind: property
Symbol: `Autodesk.Revit.DB.GraphicsStyle.GraphicsStyleType`

#### Summary

The graphics style type.

### `P:Autodesk.Revit.DB.GraphicsStyle.GraphicsStyleCategory`

Member kind: property
Symbol: `Autodesk.Revit.DB.GraphicsStyle.GraphicsStyleCategory`

#### Summary

The graphics style category.

### `T:Autodesk.Revit.DB.GraphicsStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.GraphicsStyle`

#### Summary

The graphics style instance in Autodesk Revit document.

### `T:Autodesk.Revit.DB.GraphicsStyleType`

Member kind: type
Symbol: `Autodesk.Revit.DB.GraphicsStyleType`

#### Summary

Describes the type of graphics style.

### `F:Autodesk.Revit.DB.GraphicsStyleType.Cut`

Member kind: field
Symbol: `Autodesk.Revit.DB.GraphicsStyleType.Cut`

#### Summary

Cut.

### `F:Autodesk.Revit.DB.GraphicsStyleType.Projection`

Member kind: field
Symbol: `Autodesk.Revit.DB.GraphicsStyleType.Projection`

#### Summary

Projection.

### `T:Autodesk.Revit.DB.CategoryType`

Member kind: type
Symbol: `Autodesk.Revit.DB.CategoryType`

#### Since

2015

#### Summary

The type of category.

#### Since

2015

### `F:Autodesk.Revit.DB.CategoryType.AnalyticalModel`

Member kind: field
Symbol: `Autodesk.Revit.DB.CategoryType.AnalyticalModel`

#### Summary

An analytical model element category.

### `F:Autodesk.Revit.DB.CategoryType.Internal`

Member kind: field
Symbol: `Autodesk.Revit.DB.CategoryType.Internal`

#### Summary

The category is for internal usage.

### `F:Autodesk.Revit.DB.CategoryType.Annotation`

Member kind: field
Symbol: `Autodesk.Revit.DB.CategoryType.Annotation`

#### Summary

An annotation element category.

### `F:Autodesk.Revit.DB.CategoryType.Model`

Member kind: field
Symbol: `Autodesk.Revit.DB.CategoryType.Model`

#### Summary

A model element category.

### `F:Autodesk.Revit.DB.CategoryType.Invalid`

Member kind: field
Symbol: `Autodesk.Revit.DB.CategoryType.Invalid`

#### Summary

The category type is invalid.

### `M:Autodesk.Revit.DB.Units.GetModifiableSpecs`

Member kind: method
Symbol: `Autodesk.Revit.DB.Units.GetModifiableSpecs`

#### Summary

Gets all specs for which the default FormatOptions can be modified.

#### Returns

Identifiers of the specs for which the FormatOptions can be modified.

#### Since

2014

### `M:Autodesk.Revit.DB.Units.IsModifiableSpec(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Units.IsModifiableSpec(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether the default FormatOptions can be modified for a given spec.

#### Remarks

The Units class stores a FormatOptions object for every spec, but
not all of them can be directly modified. Some have fixed
definitions.

#### Parameter `specTypeId`

Identifier of the spec to check.

#### Returns

True if the FormatOptions can be modified, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Units.SetFormatOptions(Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Units.SetFormatOptions(Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.FormatOptions)`

#### Summary

Sets the default FormatOptions for a spec.

#### Parameter `specTypeId`

Identifier of the spec.

#### Parameter `options`

The FormatOptions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).
-or-
FormatOptions cannot be modified for specTypeId. See Units.IsModifiableSpec(ForgeTypeId) and Units.GetModifiableSpecs().
-or-
UseDefault is true in options.
-or-
The unit in options is not valid for specTypeId. See UnitUtils.IsValidUnit(ForgeTypeId, ForgeTypeId) and UnitUtils.GetValidUnits(ForgeTypeId).
-or-
The rounding method in options is not set to Nearest.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Units.GetFormatOptions(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Units.GetFormatOptions(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the default FormatOptions for a spec.

#### Parameter `specTypeId`

Identifier of the spec.

#### Returns

A copy of the FormatOptions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Units.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Units.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Units.DigitGroupingAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Units.DigitGroupingAmount`

#### Summary

The number of digits in each group when numbers are formatted with digit grouping.

#### Remarks

This setting only has an effect when the UseDigitGrouping property
is set to true in the FormatOptions object for the unit type being
formatted.

#### Value

The number of digits in each group. The default is Three.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.Units.DigitGroupingSymbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.Units.DigitGroupingSymbol`

#### Summary

The symbol used to separate groups of digits when numbers are formatted with digit grouping.

#### Remarks

This setting only has an effect when the UseDigitGrouping property
is set to true in the FormatOptions object for the unit type being
formatted.

#### Value

The digit grouping symbol. The default is Comma.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.Units.DecimalSymbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.Units.DecimalSymbol`

#### Summary

The symbol used to separate the integer and fractional parts of a number.

#### Value

The decimal symbol. The default is Dot.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.Units.#ctor(Autodesk.Revit.DB.UnitSystem)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Units.#ctor(Autodesk.Revit.DB.UnitSystem)`

#### Summary

Creates a new Units object with default settings for Metric or Imperial units.

#### Parameter `unitSystem`

Indicates whether the Units object should be initialized with default settings for Metric or Imperial units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `T:Autodesk.Revit.DB.Units`

Member kind: type
Symbol: `Autodesk.Revit.DB.Units`

#### Summary

A document's default settings for formatting numbers with units.

#### Remarks

The Units class represents a document's default settings for
formatting numbers with units as strings. It contains a
`T:Autodesk.Revit.DB.FormatOptions` object for each unit
type as well as settings related to decimal symbol and digit
grouping.

The Units class stores a FormatOptions object for every valid
unit type, but not all of them can be directly modified. Some, like
UT_Number and UT_SiteAngle, have fixed definitions. Others have
definitions which are automatically derived from other unit types.
For example, UT_SheetLength is derived from UT_Length and
UT_ForceScale is derived from UT_Force. See
`!:IsModifiableUnitType` and
`!:GetModifiableUnitTypes` .

#### Since

2014

### `T:Autodesk.Revit.DB.UnitSystem`

Member kind: type
Symbol: `Autodesk.Revit.DB.UnitSystem`

#### Since

2014

#### Summary

A system of measurement: Metric or Imperial units.

#### Since

2014

### `F:Autodesk.Revit.DB.UnitSystem.Imperial`

Member kind: field
Symbol: `Autodesk.Revit.DB.UnitSystem.Imperial`

#### Summary

Imperial units.

### `F:Autodesk.Revit.DB.UnitSystem.Metric`

Member kind: field
Symbol: `Autodesk.Revit.DB.UnitSystem.Metric`

#### Summary

Metric units.

### `T:Autodesk.Revit.DB.DigitGroupingSymbol`

Member kind: type
Symbol: `Autodesk.Revit.DB.DigitGroupingSymbol`

#### Since

2014

#### Summary

The symbol used to separate groups of digits when numbers are formatted with digit grouping.

#### Since

2014

### `F:Autodesk.Revit.DB.DigitGroupingSymbol.Tick`

Member kind: field
Symbol: `Autodesk.Revit.DB.DigitGroupingSymbol.Tick`

#### Summary

An apostrophe ("'"). This value is deprecated in Revit 2015. Use DigitGroupingSymbol.Apostrophe instead.

### `F:Autodesk.Revit.DB.DigitGroupingSymbol.Apostrophe`

Member kind: field
Symbol: `Autodesk.Revit.DB.DigitGroupingSymbol.Apostrophe`

#### Summary

An apostrophe ("'").

### `F:Autodesk.Revit.DB.DigitGroupingSymbol.Space`

Member kind: field
Symbol: `Autodesk.Revit.DB.DigitGroupingSymbol.Space`

#### Summary

A space (" ").

### `F:Autodesk.Revit.DB.DigitGroupingSymbol.Comma`

Member kind: field
Symbol: `Autodesk.Revit.DB.DigitGroupingSymbol.Comma`

#### Summary

A comma (",").

### `F:Autodesk.Revit.DB.DigitGroupingSymbol.Dot`

Member kind: field
Symbol: `Autodesk.Revit.DB.DigitGroupingSymbol.Dot`

#### Summary

A dot (".").

### `T:Autodesk.Revit.DB.DigitGroupingAmount`

Member kind: type
Symbol: `Autodesk.Revit.DB.DigitGroupingAmount`

#### Since

2014

#### Summary

The number of digits in each group when numbers are formatted with digit grouping.

#### Since

2014

### `F:Autodesk.Revit.DB.DigitGroupingAmount.Three`

Member kind: field
Symbol: `Autodesk.Revit.DB.DigitGroupingAmount.Three`

#### Summary

Digits are in groups of three.

### `F:Autodesk.Revit.DB.DigitGroupingAmount.Two`

Member kind: field
Symbol: `Autodesk.Revit.DB.DigitGroupingAmount.Two`

#### Summary

Digits are in groups of two, with the exception of the first group to the left of the decimal symbol which contains three digits.

### `T:Autodesk.Revit.DB.DecimalSymbol`

Member kind: type
Symbol: `Autodesk.Revit.DB.DecimalSymbol`

#### Since

2014

#### Summary

The symbol used to separate the integer and fractional parts of a number.

#### Since

2014

### `F:Autodesk.Revit.DB.DecimalSymbol.Comma`

Member kind: field
Symbol: `Autodesk.Revit.DB.DecimalSymbol.Comma`

#### Summary

A comma (",").

### `F:Autodesk.Revit.DB.DecimalSymbol.Dot`

Member kind: field
Symbol: `Autodesk.Revit.DB.DecimalSymbol.Dot`

#### Summary

A dot (".").

### `M:Autodesk.Revit.DB.Parameter.GetAssociatedGlobalParameter`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.GetAssociatedGlobalParameter`

#### Summary

Returns a global parameter, if any, currently associated with this parameter.

#### Remarks

InvalidElementId is returned in case this parameter is not associated with any global parameter.
InvalidElementId is also returned if called for a parameter that cannot even be associated
with a global parameters (i.e. a non-parametrizable parameter or parameter with a formula).

#### Returns

Id of a global parameter or InvalidElemetnId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This parameter does not exist in the document anymore.

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.Parameter.CanBeAssociatedWithGlobalParameters`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.CanBeAssociatedWithGlobalParameters`

#### Summary

Tests whether this parameter can be associated with any global parameter.

#### Remarks

Only properties defined as parametrizable can be associated with global parameters.
That excludes any read-only and formula-driven parameters, as well as those that
have other explicit or implicit restrictions imposed by Revit.

#### Returns

True if the given parameter can be associated (is parametrizable); False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This parameter does not exist in the document anymore.

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.Parameter.CanBeAssociatedWithGlobalParameter(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.CanBeAssociatedWithGlobalParameter(Autodesk.Revit.DB.ElementId)`

#### Summary

Tests whether this parameter can be associated with the given global parameter.

#### Remarks

Only properties defined as parametrizable can be associated with global parameters.
That excludes any read-only and formula-driven parameters, as well as those that
have other explicit or implicit restrictions imposed by Revit.

#### Parameter `gpId`

Id of a global parameter contained in this parameter's document

#### Returns

True if this parameter can be associated with the given global parameter; False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input gpId is not of a valid global parameter of the given document.
-or-
This parameter does not exist in the document anymore.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.Parameter.DissociateFromGlobalParameter`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.DissociateFromGlobalParameter`

#### Summary

Dissociates this parameter from a global parameter.

#### Remarks

It is assumed this parameter has been previously associated with the global parameter
by using the `!:AssociateWithGlobalParameter(Revit::DB::ElementId^)` method.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This parameter does not exist in the document anymore.
-or-
This parameter is either not parameterizable or does not match the type of the global parameter.

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.Parameter.AssociateWithGlobalParameter(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.AssociateWithGlobalParameter(Autodesk.Revit.DB.ElementId)`

#### Summary

Associates this parameter with a global parameter in the same document.

#### Remarks

The parameter must be parameterizable, meaning it cannot be read-only,
driven by a formula, or have any other restrictions imposed by Revit.

The parameter's value type must match the type of the global parameter.

Once associated property can be later dissociated by calling the
`M:Autodesk.Revit.DB.Parameter.DissociateFromGlobalParameter` method

#### Parameter `gpId`

Id of a global parameter contained in this parameter's document

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input gpId is not of a valid global parameter of the given document.
-or-
This parameter does not exist in the document anymore.
-or-
This parameter is either not parameterizable or does not match the type of the global parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2016 Subscription Update

### `P:Autodesk.Revit.DB.Parameter.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.Parameter.Id`

#### Summary

The id of the parameter.

#### Since

2011

### `P:Autodesk.Revit.DB.Parameter.GUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.Parameter.GUID`

#### Summary

The Guid for a shared parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the parameter is not a shared parameter.

#### Since

2011

### `P:Autodesk.Revit.DB.Parameter.IsShared`

Member kind: property
Symbol: `Autodesk.Revit.DB.Parameter.IsShared`

#### Summary

Identifies if the parameter is a shared parameter.

#### Since

2011

### `P:Autodesk.Revit.DB.Parameter.Element`

Member kind: property
Symbol: `Autodesk.Revit.DB.Parameter.Element`

#### Summary

The element to which this parameter belongs.

### `M:Autodesk.Revit.DB.Parameter.ClearValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.ClearValue`

#### Summary

Clears the parameter to its initial value.

#### Returns

The ClearValue method will return True if the parameter was successfully cleared to its initial value, otherwise false.

#### Remarks

This method will only succeed for Shared parameters that have their HideWhenNoValue property set to true.

#### Since

2020

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The parameter is read-only, or the parameter is not a shared parameter,
or the shared parameter has HideWhenNoValue set to false.

### `M:Autodesk.Revit.DB.Parameter.Set(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.Set(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the parameter to a new element id.

#### Parameter `value`

The new element id to which the parameter is to be set.

#### Returns

The Set method will return True if the parameter was successfully set to the new value, otherwise false.

#### Remarks

You should only use this method if the StorageType property reports the type of the
parameter as an ElementId.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The parameter is read-only.

### `M:Autodesk.Revit.DB.Parameter.Set(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.Set(System.Double)`

#### Summary

Sets the parameter to a new real number value.

#### Parameter `value`

The new double value to which the parameter is to be set.

#### Returns

The Set method will return True if the parameter was successfully set to the new value, otherwise false.

#### Remarks

You should only use this method if the StorageType property reports the type of the
parameter as a Double.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The parameter is read-only.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Value must be a finite number.

### `M:Autodesk.Revit.DB.Parameter.Set(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.Set(System.Int32)`

#### Summary

Sets the parameter to a new integer value.

#### Parameter `value`

The new integer value to which the parameter is to be set.

#### Returns

The Set method will return True if the parameter was successfully set to the new value, otherwise false.

#### Remarks

You should only use this method if the StorageType property reports the type of the
parameter as an integer.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The parameter is read-only.

### `M:Autodesk.Revit.DB.Parameter.Set(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.Set(System.String)`

#### Overloads

Sets the parameter to a new value.

#### Summary

Sets the parameter to a new string of text.

#### Parameter `value`

The new text value to which the parameter is to be set.

#### Returns

The Set method will return True if the parameter was successfully set to the new value, otherwise false.

#### Remarks

You should only use this method if the StorageType property reports the type of the
parameter as a String.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The parameter is read-only.

### `M:Autodesk.Revit.DB.Parameter.AsElementId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.AsElementId`

#### Summary

Provides access to the Autodesk::Revit::DB::ElementId^ stored within the parameter.

#### Returns

The Autodesk::Revit::DB::ElementId^ contained in the parameter.

#### Remarks

The AsAutodesk::Revit::DB::ElementId^ method should only be used if the StorageType property returns that the
internal contents of the parameter is an ElementId.

### `M:Autodesk.Revit.DB.Parameter.SetMultiple(System.Collections.Generic.IList{System.Tuple{Autodesk.Revit.DB.Parameter,Autodesk.Revit.DB.ParameterValue}})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.SetMultiple(System.Collections.Generic.IList{System.Tuple{Autodesk.Revit.DB.Parameter,Autodesk.Revit.DB.ParameterValue}})`

#### Summary

Sets multiple parameters to new values.

#### Parameter `values`

A list of pairs of parameters and their corresponding values.

#### Returns

The list of parameters that were not set successfully, if any.

#### Remarks

This method is provided as a performance optimization. Note that it will throw an
exception if any parameter would throw an exception, so validate ahead of time.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The parameter is read-only.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Value must be a finite number.

### `M:Autodesk.Revit.DB.Parameter.AsDoubleInForgeStorageUnit`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.AsDoubleInForgeStorageUnit`

#### Summary

Provides access to the double precision number within the parameter, converted to the Forge storage
unit of the parameter's data type.

#### Remarks

This method should only be used if the StorageType property returns that the internal
contents of the parameter is a double.

#### Returns

The double value contained in the parameter quantified in its Forge storage unit.

### `M:Autodesk.Revit.DB.Parameter.AsDouble`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.AsDouble`

#### Summary

Provides access to the double precision number within the parameter.

#### Returns

The double value contained in the parameter.

#### Remarks

The AsDouble method should only be used if the StorageType property returns that the
internal contents of the parameter is a double.

### `M:Autodesk.Revit.DB.Parameter.AsInteger`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.AsInteger`

#### Summary

Provides access to the integer number within the parameter.

#### Returns

The integer value contained in the parameter.

#### Remarks

The AsInteger method should only be used if the StorageType property returns that the
internal contents of the parameter is an integer.

### `M:Autodesk.Revit.DB.Parameter.AsString`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.AsString`

#### Summary

Provides access to the string contents of the parameter.

#### Returns

The string contained in the parameter.

#### Remarks

The AsString method should only be used if the StorageType property returns that the
internal contents of the parameter is a string.

### `M:Autodesk.Revit.DB.Parameter.GetUnitTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.GetUnitTypeId`

#### Summary

Gets the identifier of the unit quantifying the parameter value.

#### Returns

Identifier of the unit of the parameter.

#### Remarks

The property only applies to parameters of value types.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if this parameter is not of value type.

### `M:Autodesk.Revit.DB.Parameter.SetValueString(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.SetValueString(System.String)`

#### Summary

Set the parameter value according to the input string.

#### Parameter `valueString`

The string that represents the parameter value.

#### Returns

Indicates whether the parameter value is successfully set.

#### Remarks

The method only applies to parameters of value types.

### `M:Autodesk.Revit.DB.Parameter.AsValueString(Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.AsValueString(Autodesk.Revit.DB.FormatOptions)`

#### Summary

Get the parameter value as a string with units.

#### Returns

The string that represents the parameter value.

#### Since

2014

#### Parameter `formatOptions`

Options for formatting the string.

### `M:Autodesk.Revit.DB.Parameter.AsValueString`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.AsValueString`

#### Summary

Get the parameter value as a string with units.

#### Returns

The string that represents the parameter value.

### `M:Autodesk.Revit.DB.Parameter.GetTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Parameter.GetTypeId`

#### Summary

Gets the identifier of the parameter.

#### Since

2022

### `P:Autodesk.Revit.DB.Parameter.HasValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.Parameter.HasValue`

#### Summary

Identifies if the parameter has an assigned value.

#### Since

2012

### `P:Autodesk.Revit.DB.Parameter.UserModifiable`

Member kind: property
Symbol: `Autodesk.Revit.DB.Parameter.UserModifiable`

#### Summary

Indicates whether the interactive user can modify the value of this parameter.

#### Since

2015

#### Remarks

Note that for shared parameters IsReadOnly can return false for shared parameters whose UserModifiable property is
also false, because the value of those parameters can be modified by the API. If a parameter is governed by a formula,
IsReadOnly would return true, even if the flag for UserModifiable was set to true when the shared parameter was created.

### `P:Autodesk.Revit.DB.Parameter.IsReadOnly`

Member kind: property
Symbol: `Autodesk.Revit.DB.Parameter.IsReadOnly`

#### Summary

Get the readonly property of the parameter.

#### Remarks

This function can be used to check if the parameter is read-only.

### `P:Autodesk.Revit.DB.Parameter.StorageType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Parameter.StorageType`

#### Summary

Describes the type that is used internally within the parameter to store its value.

#### Remarks

The property will return one of the following possibilities: String, Integer, Double
or ElementId. Based on the value of this property the correct access and set methods should be used
to retrieve and set the parameter's data value.

### `P:Autodesk.Revit.DB.Parameter.Definition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Parameter.Definition`

#### Summary

Returns the Definition object that describes the data type, name and other details of the
parameter.

#### Remarks

This will always be an `T:Autodesk.Revit.DB.InternalDefinition` object.
If you want the Guid for a shared parameter, use `P:Autodesk.Revit.DB.Parameter.GUID` .

### `T:Autodesk.Revit.DB.Parameter`

Member kind: type
Symbol: `Autodesk.Revit.DB.Parameter`

#### Summary

The parameter object contains the value data assigned to that parameter.

#### Remarks

The piece of data contained within the parameter can be either a Double, Integer,
String or ElementId. The parameter object can be retrieved from any Element object using
either a built in id, definition object or shared parameter guid. All Elements within
Autodesk Revit contain Parameters. These are options that can be accessed in a generic
fashion. Revit contains many built in parameter types but users and now developers, via the
API, can add their own parameters in the form of shared parameters. The developer should
become familiar with the Revit user interface for added and managing parameters and shared
parameters before using this API. The user interface components can be found in the following
locations: Element Properties dialog, Shared Parameters dialog (available from the File menu),
Project Parameters dialog (available from the Settings menu), Family Types dialog (available
from the Settings menu when editing a family). There are several relationships between the
objects that make up the APIs exposure of parameters. The parameter object contains the data
value. Parameter objects can be retrieved from Elements if you know its built-in id,
its definition or its shared parameter guid. Each parameter has a definition. New parameters
can be added to Elements by adding a ParameterBinding object to the Document object.

### `M:Autodesk.Revit.DB.FamilyType.HasValue(Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyType.HasValue(Autodesk.Revit.DB.FamilyParameter)`

#### Summary

Indicates if this family parameter has an assigned value or not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the input argument-"familyParameter"-is invalid.

### `M:Autodesk.Revit.DB.FamilyType.AsValueString(Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyType.AsValueString(Autodesk.Revit.DB.FamilyParameter)`

#### Summary

Provides access to value as a string with unit in the given family parameter.

#### Returns

The string that represents the parameter value with unit.

#### Remarks

The method only applies to parameters of value types. If the parameter has no value or does not contain a numeric value,
the method returns `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the input argument-"familyParameter"-is invalid.

### `M:Autodesk.Revit.DB.FamilyType.AsElementId(Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyType.AsElementId(Autodesk.Revit.DB.FamilyParameter)`

#### Summary

Provides access to the Autodesk::Revit::DB::ElementId^ stored in the given family parameter.

#### Returns

The Autodesk::Revit::DB::ElementId^ contained in the parameter.Returns an invalid element id
if the storage type of the input argument is Autodesk::Revit::DB::ElementId^ type or this parameter has no value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the input argument-"familyParameter"-is invalid,

### `M:Autodesk.Revit.DB.FamilyType.AsDouble(Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyType.AsDouble(Autodesk.Revit.DB.FamilyParameter)`

#### Summary

Provides access to the double precision number of the given family parameter.

#### Returns

The double value contained in the parameter. Returns `null`
if the storage type of the input argument is not double type or this parameter has no value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the input argument-"familyParameter"-is invalid,

### `M:Autodesk.Revit.DB.FamilyType.AsInteger(Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyType.AsInteger(Autodesk.Revit.DB.FamilyParameter)`

#### Summary

Provides access to the integer number of the given family parameter.

#### Returns

The integer value contained in the parameter. Returns `null`
if the storage type of the input argument is not integer type or this parameter has no value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the input argument-"familyParameter"-is invalid,

### `M:Autodesk.Revit.DB.FamilyType.AsString(Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyType.AsString(Autodesk.Revit.DB.FamilyParameter)`

#### Summary

Provides access to the string contents of the given family parameter.

#### Returns

The string contained in the parameter. Returns `null` if the storage type of the input
argument is not string type or this parameter has no value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the input argument-"familyParameter"-is invalid,

### `P:Autodesk.Revit.DB.FamilyType.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyType.Name`

#### Summary

The name of the family type.

### `T:Autodesk.Revit.DB.FamilyType`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyType`

#### Summary

The family type object provides read access to the values of family parameters for this type.

### `M:Autodesk.Revit.DB.Definition.GetDataType`

Member kind: method
Symbol: `Autodesk.Revit.DB.Definition.GetDataType`

#### Summary

Gets a ForgeTypeId identifying the data type describing values of the parameter.

#### Remarks

The returned ForgeTypeId may be empty or may identify either a spec or a
category. When it is a category, it indicates a Family Type
parameter of that category. See
Parameter.IsSpec(ForgeTypeId),
UnitUtils.IsMeasurableSpec(ForgeTypeId),
Category.IsBuiltInCategory(ForgeTypeId), and
Parameter.IsValidDataType(ForgeTypeId).

Some built-in parameters, such as those for color or level, have special data types which are not
available for use with user-defined parameters and which have no representation in the Revit user
interface or API. For these built-in parameters, this method returns an empty ForgeTypeId instance.

#### Returns

A ForgeTypeId identifying the data type of the parameter or an empty ForgeTypeId.

#### Since

2022

### `P:Autodesk.Revit.DB.Definition.ParameterGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.Definition.ParameterGroup`

#### Summary

Returns the group ID of the parameter definition.

### `M:Autodesk.Revit.DB.Definition.GetGroupTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Definition.GetGroupTypeId`

#### Summary

Returns the identifier of the parameter definition's parameter group.

### `P:Autodesk.Revit.DB.Definition.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Definition.Name`

#### Summary

The user visible name for the parameter.

### `T:Autodesk.Revit.DB.Definition`

Member kind: type
Symbol: `Autodesk.Revit.DB.Definition`

#### Summary

The Definition object is a base object for all type of parameter definitions within the Autodesk Revit API.

#### Remarks

This object supports properties and methods that report the name and type of a
particular parameter. There are two kinds of definition object derived from this:
InternalDefinition which represents all kinds of definitions existing entirely within the
Autodesk Revit database. ExternalDefinitions represent definitions stored on disk in a
shared parameters file. Most of the time code should be written to utilize this Definition
base class as then the code will be applicable to both internal and external parameter
definitions.

### `E:Autodesk.Revit.DB.Document.DocumentClosing`

Member kind: event
Symbol: `Autodesk.Revit.DB.Document.DocumentClosing`

#### Summary

Subscribe to the DocumentClosing event to be notified when Revit is just about to close a document.

#### Remarks

This event is raised when Revit is just about to close a document.

This event is cancellable, except when it is raised as part of application closing.
Check the 'Cancellable' property of event's argument to see whether it is cancellable or not.
When it is cancellable, call the 'Cancel()' method of event's argument to True to cancel it.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The document may not be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another Autodesk::Revit::ApplicationServices::Application::DocumentClosed event will be raised immediately after document is closed.

#### Since

2010

### `E:Autodesk.Revit.DB.Document.ViewPrinted`

Member kind: event
Symbol: `Autodesk.Revit.DB.Document.ViewPrinted`

#### Summary

Subscribe to the ViewPrinted event to be notified immediately after Revit has finished printing a view of the document.

#### Remarks

This event is raised immediately after Revit has finished printing a view of the document.
If multiple views are combined to a single file, this event will be raised only once.
It is raised even when view printing failed.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action was successful or not.

This event is not cancellable, for the process of view printing has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.DB.Document.ViewPrinting`

Member kind: event
Symbol: `Autodesk.Revit.DB.Document.ViewPrinting`

#### Summary

Subscribe to the ViewPrinting event to be notified when Revit is just about to print a view of the document.

#### Remarks

This event is raised when Revit is just about to print a view of the document.
If multiple views are combined to a single file, this event will be raised only once.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Export()Autodesk.Revit.DB.Document.Print()`M:Autodesk.Revit.DB.View.Print` and similar overloads.`M:Autodesk.Revit.DB.PrintManager.SubmitPrint` and similar overloads.`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another event `E:Autodesk.Revit.DB.Document.ViewPrinted` will be raised immediately after view printing
is finished.

#### Since

2010

### `E:Autodesk.Revit.DB.Document.DocumentPrinted`

Member kind: event
Symbol: `Autodesk.Revit.DB.Document.DocumentPrinted`

#### Summary

Subscribe to the DocumentPrinted event to be notified immediately after Revit has finished printing a view or ViewSet of the document.

#### Remarks

This event is raised immediately after Revit has finished printing a view or ViewSet of the document.
It is raised even when document printing failed or was cancelled (during DocumentPriting event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of printing has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.DB.Document.DocumentPrinting`

Member kind: event
Symbol: `Autodesk.Revit.DB.Document.DocumentPrinting`

#### Summary

Subscribe to the DocumentPrinting event to be notified when Revit is just about to print a view or ViewSet of the document.

#### Remarks

This event is raised when Revit is just about to print a view or ViewSet of the document.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is cancellable. To cancel it, call the 'Cancel()' method of event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for current document during this event:
All overloads of Autodesk.Revit.DB.Document.Export()Autodesk::Revit::DB::Document::Print`M:Autodesk.Revit.DB.View.Print` and similar overloads.`M:Autodesk.Revit.DB.PrintManager.SubmitPrint` and similar overloads.`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

After this event, for each view being printed, `E:Autodesk.Revit.DB.Document.ViewPrinting` and `E:Autodesk.Revit.DB.Document.ViewPrinted` events will be raised.
Another event `E:Autodesk.Revit.DB.Document.DocumentPrinted` will be raised immediately after document printing
is finished.

#### Since

2010

### `E:Autodesk.Revit.DB.Document.DocumentSavedAs`

Member kind: event
Symbol: `Autodesk.Revit.DB.Document.DocumentSavedAs`

#### Summary

Subscribe to the DocumentSavedAs event to be notified immediately after Revit has finished saving document with a new file name.

#### Remarks

This event is raised immediately after Revit has finished saving document with a new file name.
Note that the first save of a newly created document will raise DocumentSavedAs rather than `E:Autodesk.Revit.DB.Document.DocumentSaved` event.
It is raised even when document saving failed or was cancelled (during DocumentSavingAs event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' property in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of saving document has already been finished.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.DB.Document.DocumentSavingAs`

Member kind: event
Symbol: `Autodesk.Revit.DB.Document.DocumentSavingAs`

#### Summary

Subscribe to the DocumentSavingAs event to be notified when Revit is just about to save the document with a new file name.

#### Remarks

This event is raised when Revit is just about to save the document with a new file name.
Note that the first save of a newly created document will raise DocumentSavingAs rather than `E:Autodesk.Revit.DB.Document.DocumentSaving` event.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

This event is cancellable, except when it is raised during close of the application.
Check the 'Cancellable' property of event's argument to see whether it is cancellable or not.
When it is cancellable, call the 'Cancel()' method of event's argument to cancel it.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another event `E:Autodesk.Revit.DB.Document.DocumentSavedAs` will be raised immediately after the document has been saved with a new file name.

#### Since

2010

### `E:Autodesk.Revit.DB.Document.DocumentSaved`

Member kind: event
Symbol: `Autodesk.Revit.DB.Document.DocumentSaved`

#### Summary

Subscribe to the DocumentSaved event to be notified immediately after Revit has finished saving a document.

#### Remarks

This event is raised immediately after Revit has finished saving a document.
Note that the first save of a newly created document will raise `E:Autodesk.Revit.DB.Document.DocumentSavedAs`
rather than the DocumentSaved event.
It is raised even when document saving failed or was cancelled (during DocumentSaving event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' property in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of saving document has already been finished.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.DB.Document.DocumentSaving`

Member kind: event
Symbol: `Autodesk.Revit.DB.Document.DocumentSaving`

#### Summary

Subscribe to the DocumentSaving event to be notified when Revit is just about to save a document.

#### Remarks

This event is raised when Revit is just about to save the document.
Note that the first save of a newly created document will raise `E:Autodesk.Revit.DB.Document.DocumentSavingAs`
rather than the DocumentSaving event.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

This event is cancellable, except when it is raised during close of the application.
Check the 'Cancellable' property of event's argument to see whether it is cancellable or not.
When it is cancellable, call the 'Cancel()' method of event's argument to cancel it.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another event `E:Autodesk.Revit.DB.Document.DocumentSaved` will be raised immediately after the document has been saved.

#### Since

2010

### `M:Autodesk.Revit.DB.Document.CanODBCFileExport`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.CanODBCFileExport`

#### Summary

Returns whether ODBC supports export.

### `M:Autodesk.Revit.DB.Document.RemoveUsedServiceRecord(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.RemoveUsedServiceRecord(System.Guid)`

#### Summary

Removes the record of a used service.

#### Remarks

The intention is to use this in document updates only.

#### Parameter `serviceId`

Id of the service the record of which is to be removed.

### `M:Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.AXMImportOptions,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.AXMImportOptions,Autodesk.Revit.DB.View)`

#### Summary

Links an AXM file into the document.
Link isn't supported for family documents. Please use import instead.

#### Parameter `file`

Full path of the file to link. File must exist and must be a valid AXM file.

#### Parameter `options`

Various link options applicable to the AXM format. If `null` , all options will be set to their respective default values.
Link FormIt support Preserve color mode, center-to-center and origin-to-origin placement. Other options are not supported.
Link FormIt does not support this view only option.
Link FormIt does not support import levels.

#### Parameter `pDBView`

View used to aid placement of the linked file. If the options specify center-to-center placement, this argument is required and the linked
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked
file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.

#### Returns

Returns the element Id of the linked instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for AXM import (.axm files are valid).
-or-
The provided view is not valid for the options provided.
-or-
Visible layer only option is not false or layers are specified in SetLayerSelection.
-or-
Import levels is not supported for AXM link.
-or-
Not all AXM import option settings are valid. For more details, please refer to AXMImportOptions.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The AXM Import/Link module is not available in the installed Revit.

#### Since

2023

### `M:Autodesk.Revit.DB.Document.Update(System.String,Autodesk.Revit.DB.ATFXImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Update(System.String,Autodesk.Revit.DB.ATFXImportOptions)`

#### Summary

Updates the current Revit project document which was created by an import of an ATFX file.

#### Parameter `file`

Full path of the file to update. File must exist and must be a valid ATFX file.

#### Parameter `options`

Various import options applicable to the ATFX format.

#### Returns

Returns the element Ids of the created DirectShapes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for ATFX import (.atfxz files are valid).
-or-
NullOrEmpty

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
Document this Document may not contain DirectShape or DirectShapeType objects.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The ShapeImporter functionality is not available in the installed Revit.

#### Since

2023

### `M:Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.ATFXImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.ATFXImportOptions)`

#### Summary

Imports an ATFX file into the document.

#### Parameter `file`

Full path of the file to import. File must exist and must be a valid ATFX file.

#### Parameter `options`

Various import options applicable to the ATFX format. If `null` , all options will be set to their respective default values.

#### Returns

Returns the element Ids of the created DirectShapes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for ATFX import (.atfxz files are valid).
-or-
NullOrEmpty

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
Document this Document may not contain DirectShape or DirectShapeType objects.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The ShapeImporter functionality is not available in the installed Revit.

#### Since

2023

### `M:Autodesk.Revit.DB.Document.Update(System.String,Autodesk.Revit.DB.FDXImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Update(System.String,Autodesk.Revit.DB.FDXImportOptions)`

#### Summary

Updates data from a cloud data exchange that was previously imported into the document.

#### Parameter `getExchangeUrl`

GET exchanges URL of the file hosting an existing FDX exchange.

#### Parameter `options`

Various import options applicable to the Data Exchange format.

#### Returns

Returns the element Ids of the created DirectShapes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Options are not valid for the given Document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
Document this Document may not contain DirectShape or DirectShapeType objects.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The FDX Import module is not available in the installed Revit.

#### Since

2024

### `M:Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.FDXImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.FDXImportOptions)`

#### Summary

Imports data from cloud data exchange into the document.

#### Parameter `getExchangeUrl`

GET exchanges URL of the file hosting an existing FDX exchange.

#### Parameter `options`

Various import options applicable to the Data Exchange format. If `null` , all options will be set to their respective default values.

#### Returns

Returns the element Ids of the created DirectShapes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
Document this Document may not contain DirectShape or DirectShapeType objects.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The FDX Import module is not available in the installed Revit.

#### Since

2024

### `M:Autodesk.Revit.DB.Document.Update(System.String,Autodesk.Revit.DB.ATFIFCImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Update(System.String,Autodesk.Revit.DB.ATFIFCImportOptions)`

#### Summary

Updates data from an IFC file that was previously imported into the document.

#### Parameter `file`

Full path of the file to import. File must exist and must be a valid IFC file.

#### Parameter `options`

Various import options applicable to the IFC format. If `null` , all options will be set to their respective default values.

#### Returns

Returns the element Ids of the created DirectShapes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for IFC import.
-or-
NullOrEmpty

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
Document this Document may not contain DirectShape or DirectShapeType objects.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The IFC Import/Link module is not available in the installed Revit.

### `M:Autodesk.Revit.DB.Document.Update(System.String,Autodesk.Revit.DB.ATFXMLImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Update(System.String,Autodesk.Revit.DB.ATFXMLImportOptions)`

#### Summary

Updates the current Revit project document which was created by an import of an ATF XML file.

#### Parameter `file`

Full path of the file to update. File must exist and must be a valid ATF XML file.

#### Parameter `options`

Various import options applicable to the ATF XML format.

#### Returns

Returns the element Ids of the created DirectShapes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for ATFXML import (.atfx files are valid).
-or-
NullOrEmpty

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
Document this Document may not contain DirectShape or DirectShapeType objects.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The ShapeImporter functionality is not available in the installed Revit.

#### Since

2022

### `M:Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.ATFXMLImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.ATFXMLImportOptions)`

#### Summary

Imports an ATF XML file into the project document.

#### Parameter `file`

Full path of the file to import. File must exist and must be a valid ATF XML file.

#### Parameter `options`

Various import options applicable to the ATF XML format. If `null` , all options will be set to their respective default values.

#### Returns

Returns the element Ids of the created DirectShapes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

NullOrEmpty

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
Document this Document may not contain DirectShape or DirectShapeType objects.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The ShapeImporter functionality is not available in the installed Revit.

#### Since

2022

### `M:Autodesk.Revit.DB.Document.Export(System.String,Autodesk.Revit.DB.FDXExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,Autodesk.Revit.DB.FDXExportOptions)`

#### Summary

Exports the view specified in the export options to an FDX cloud data exchange.

#### Parameter `getExchangesUrl`

GET exchanges URL of the file hosting an existing FDX exchange.

#### Parameter `options`

Various options applicable to the FDX format.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The provided options do not specify a printable 3D view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Export is temporarily disabled.
-or-
Exporting is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The ShapeExporter functionality is not available in the installed Revit, or the Material Library is missing.

#### Since

2023

### `M:Autodesk.Revit.DB.Document.Export(System.String,Autodesk.Revit.DB.FDXJSONExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,Autodesk.Revit.DB.FDXJSONExportOptions)`

#### Summary

Exports the view specified in the export options to FDX payload, as a JSON file and associated binary files.

#### Parameter `folder`

Output folder into which the files will be exported. The folder must exist.

#### Parameter `options`

Various options applicable to the FDX format.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

NullOrEmpty
-or-
The provided options do not specify a printable 3D view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DirectoryNotEmptyException`

The folder is not empty.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Export is temporarily disabled.
-or-
Exporting is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The folder does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The ShapeExporter functionality is not available in the installed Revit, or the Material Library is missing.

#### Since

2023

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.ATFXExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.ATFXExportOptions)`

#### Summary

Exports the document to the ATFX format.

#### Parameter `folder`

Output folder into which the file will be exported. The folder must exist.

#### Parameter `name`

Indicates the name of the ATFX file to export. If it doesn't end with ".atfxz", this extension will be added automatically.
The name cannot contain any of the following characters: \/:*?"<>|. Empty name is not acceptable.

#### Parameter `options`

Various options applicable to the ATFX format.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

NullOrEmpty
-or-
Contains invalid characters.
-or-
The provided options do not specify a printable 3D view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Export is temporarily disabled.
-or-
Exporting is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The folder does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The ShapeExporter functionality is not available in the installed Revit, or the Material Library is missing.

#### Since

2023

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.ATFXMLExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.ATFXMLExportOptions)`

#### Summary

Exports the document to the ATF XML format.

#### Parameter `folder`

Output folder into which the file will be exported. The folder must exist.

#### Parameter `name`

Indicates the name of the ATF XML file to export. If it doesn't end with ".atfx", this extension will be added automatically.
The name cannot contain any of the following characters: \/:*?"<>|. Empty name is not acceptable.

#### Parameter `options`

Various options applicable to the ATF XML format.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

NullOrEmpty
-or-
Contains invalid characters.
-or-
The provided options do not specify a printable 3D view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Export is temporarily disabled.
-or-
Exporting is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The folder does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The ShapeExporter functionality is not available in the installed Revit, or the Material Library is missing.

#### Since

2021

### `M:Autodesk.Revit.DB.Document.SaveLocalSharedModel(System.Guid,System.Guid,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.SaveLocalSharedModel(System.Guid,System.Guid,System.String)`

#### Summary

After execution, document will represent a local model whose central file resides in A360.

#### Remarks

Assumes that worksharing has been enabled for this document and that user is currently signed in
to A360.

#### Parameter `projectGUID`

Identifies the cloud project to which this model will be attached.

#### Parameter `assignedModelGUID`

Identifies the model file on the server

#### Parameter `modelName`

The name by which the model will be identified in A360.

#### Returns

The guid that identifies the model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Document.WorkshareCloudModel(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.WorkshareCloudModel(System.String)`

#### Summary

Enables worksharing for this document. Journal messages match saveAsCloudSharedModel

#### Remarks

Assumes that user is currently signed in to Autodesk 360.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Document.SaveAsCloudModel(Autodesk.Revit.DB.ForgeDM.CloudFolder,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.SaveAsCloudModel(Autodesk.Revit.DB.ForgeDM.CloudFolder,System.String)`

#### Summary

Saves current non-workshared or workshared model as a cloud model or workshared cloud model in BIM 360 Docs or Autodesk Docs.

#### Remarks

Assumes that user is currently signed in BIM 360 Docs or Autodesk Docs and has access to Autodesk cloud services.
This operation will create a model on cloud and then create a local cache of the cloud model.
This method cannot be used when current document is already in cloud.

You can use one of the following methods to save a local model as a workshared cloud model in BIM 360 Docs or Autodesk Docs.
If the local model is a workshared model, then it will be a workshared cloud model after you use this method successfully.

If the local model is a non-workshared model, you can enable the workset with `M:Autodesk.Revit.DB.Document.EnableWorksharing(System.String,System.String)` and then save as a workshared cloud model.

If the local model is a non-workshared model, and you have already saved it as a non-workshared cloud model in BIM 360 Docs or Autodesk Docs, you can still enable the workset with
`M:Autodesk.Revit.DB.Document.EnableCloudWorksharing` to convert it to a workshared cloud model.

You cannot save a local workshared model as a non-workshared cloud model in BIM 360 Docs or Autodesk Docs.

#### Parameter `cloudFolder`

The Folder from ForgeDM to save the model.

#### Parameter `modelName`

Model name in BIM 360 Docs or Autodesk Docs to save the model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

modelName is an empty string.
-or-
The input file name "modelName" does not represent a valid file name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelMissingException`

Failed due to the region of the input CloudFolder is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

SaveAs may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Saving is not allowed in the current application mode.
-or-
This Document is not a project document.
-or-
This Document is in an edit mode.
-or-
This Document is not a primary document, it is a linked document.
-or-
SaveAs is temporarily disabled.
-or-
This Document is a cloud model, cannot be saved as a cloud model.
-or-
There is a transaction phase left open (such as a transaction, sub-transaction of transaction group) at the time of invoking this method.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

Could be for any of the reasons related to network.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

Failed due to the input CloudFolder containing a BIM 360 Docs or Autodesk Docs account Id or project Id is invalid or unmatched.
-or-
Could be for any of the reasons that saveAs fails with RevitServerInternalException.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerModelAlreadyExistsException`

Failed due to there is a model with the same name already exists at the specified location.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerModelNameBreaksConventionException`

Failed due to the model name is breaking project naming convention.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

You don't have the entitlement to perform the operation to this this Document.
-or-
User is not authorized to access the specified cloud project.

#### Since

2022

### `M:Autodesk.Revit.DB.Document.IsValidNameForCloudSharedModel(System.String,System.Guid,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.IsValidNameForCloudSharedModel(System.String,System.Guid,System.String)`

#### Summary

Checks whether there is already a model with the specified name attached to the specified A360 project.

#### Parameter `region`

Identifies the account region

#### Parameter `projectGUID`

Identifies the A360 project to which this model will be attached.

#### Parameter `modelName`

The name by which the model will be identified in A360.

#### Returns

True if there is not already a model with the specified name attached to the specified project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Document.GetUnitsElementId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetUnitsElementId`

#### Summary

Gets the id of the units element (object of UnitsElem) of the Revit units settings

#### Returns

The element id of UnitsElem object.

#### Since

2021.1

### `M:Autodesk.Revit.DB.Document.EraseSchemaAndAllEntities(Autodesk.Revit.DB.ExtensibleStorage.Schema)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.EraseSchemaAndAllEntities(Autodesk.Revit.DB.ExtensibleStorage.Schema)`

#### Summary

Erases Schema and all its Entities from the document.

#### Remarks

The Schema remains in memory.

#### Parameter `schema`

The Schema to erase.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

No write access to this Schema.

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

2021

### `M:Autodesk.Revit.DB.Document.IsBackgroundCalculationInProgress`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.IsBackgroundCalculationInProgress`

#### Summary

Indicates whether there are any background calculations in progress for this document.

#### Remarks

When a document has background calculations in progress, users cannot perform the following operations:
Save/Close the document.

Export/Print the document.

Synchronize to central, in worksharing environment.

Create a steel element.

Copy/Mirror/Rotate a steel element.

Edit the sketch of plate element.

Edit a custom connection.

#### Returns

Returns true if the document has any data calculation in progress and false otherwise.

#### Since

2019.1

### `M:Autodesk.Revit.DB.Document.ResetSharedCoordinates`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.ResetSharedCoordinates`

#### Summary

Reset shared coordinates for the host model/file.

#### Remarks

When you reset shared coordinates, the shared coordinates of the host model will be erased.
The shared relationship with all the linked models will be eliminated.
Survey point will be reset back to startup location, where it coincides with the Internal Origin.
The rotation angle between Project North and True North will be reset back to 0.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a primary document, it is a linked document.
-or-
This Document is not a project document.
-or-
This Document is in an edit mode.

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

2021.1

### `M:Autodesk.Revit.DB.Document.PublishCoordinates(Autodesk.Revit.DB.LinkElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.PublishCoordinates(Autodesk.Revit.DB.LinkElementId)`

#### Summary

Publish coordinates to the specified ProjectLocation of the link instance.

#### Remarks

The host project's True North and shared origin are recorded in the linked project, based on the current position of the linked instance.
This location is now named in both the host project and the linked project. More than one position of the link can be recorded.

When you publish shared coordinates from a host Revit project to a linked DWG, this changes the linked DWG. The origin of the host Revit
project's shared coordinate system becomes the origin of a new User Coordinate System (UCS) in the DWG file. The Y axis of the new UCS corresponds
to the host project's True North. You can name the UCS when you publish coordinates. It is not recommended that you change this name after
publishing coordinates.

Note: Currently, only `!:Autodesk.Revit.DB.RevitLinkInstance` is supported. DWG link instance, which is
`!:Autodesk.Revit.DB.ImportInstance` is not supported now. Passing in an locationId that points to an ImportInstance
would result an `!:Autodesk.Revit.Exceptions.ArgumentException` .

#### Parameter `locationId`

The `!:Autodesk.Revit.DB.ElementId` of the `!:Autodesk.Revit.DB.ProjectLocation` in the
linked document, to which the transform would be published to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

locationId does not contain a valid linkInstanceId.
-or-
Only RevitLinkInstance is supported through API for publish coordinates.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a project document.
-or-
This Document is in an edit mode.
-or-
Attempting to publish shared coordinates to a cloud based link which is treated as read-only.
-or-
Failed to publish coordinates to the specified ProjectLocation of the link instance.

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

### `M:Autodesk.Revit.DB.Document.AcquireCoordinates(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.AcquireCoordinates(Autodesk.Revit.DB.ElementId)`

#### Summary

Acquires coordinates from the specified link instance.

#### Remarks

When you acquire coordinates from the linked model, the shared coordinates of the linked model become the
shared coordinates of the host model, based on the position of the linked model instance in the host model.
There is no change to the host model's internal coordinates.

The host model also acquires True North from the linked model. The origin of the linked model's shared
coordinates becomes the origin of the host model's shared coordinates.

When a Revit model acquires coordinates from a linked DWG file, the World Coordinate System (WCS) of the
selected linked DWG file becomes the shared coordinate system of the host Revit model, based on the position
of the linked DWG instance. The Y axis of the DWG becomes True North, and the origin of the DWG becomes the
origin of the shared coordinate system of the Revit model.

On acquiring coordinates from a geo-referenced model, the geolocation information will be pulled from the linked
model to the host model.

Unlike UI operation Acquire Coordinates, calling the API would always overwrite the geolocation information in the
host model even if it is different from the one in the linked model, or the linked model has empty geolocation information
(in which case the geolocation information in the host model would be removed).

#### Parameter `linkInstanceId`

The `!:Autodesk.Revit.DB.ElementId` of the link instance (such as
`!:Autodesk.Revit.DB.RevitLinkInstance` or `!:Autodesk.Revit.DB.ImportInstance` )
from which the coordinates would be acquired.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element linkInstanceId does not exist in the document

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a project document.
-or-
This Document is in an edit mode.
-or-
The coordinate system of the selected model are the same as the host model.
-or-
Cannot acquire coordinates from a model placed multiple times.
-or-
Failed to acquire coordinates from the link instance.

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

### `M:Autodesk.Revit.DB.Document.IsValidVersionGUID(Autodesk.Revit.DB.Document,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.IsValidVersionGUID(Autodesk.Revit.DB.Document,System.Guid)`

#### Summary

Checks whether the GUID is valid for the given document. Empty GUID is allowed.

#### Parameter `document`

Target document.

#### Parameter `versionGUID`

The GUID to check.

#### Returns

True if the GUID is valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Document.GetChangedElements(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetChangedElements(System.Guid)`

#### Summary

Extracts a collection containing the ids of elements that have been created, modified or deleted between the input baseVersion and the document's current version.

#### Parameter `baseVersionGUID`

GUID of base version(excluded) to compare. This GUID should be retrieved from property `!:Autodesk::Revit::DB::DocumentVersion::VersoinGUID` .
Empty GUID is allowed to retrieve changes of each version in the document.

#### Returns

An object containing collections of the created, modified and deleted ids between the input version and current version.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This GUID is invalid in the given document.

#### Since

2023

### `M:Autodesk.Revit.DB.Document.GetDocumentVersion(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetDocumentVersion(Autodesk.Revit.DB.Document)`

#### Summary

Gets the DocumentVersion that corresponds to a document.

#### Remarks

This function can be combined with `P:Autodesk.Revit.DB.Document.IsModified`
to see whether a document in memory is different from a version on disk. The documents
are different if the document is modified or if the two DocumentVersions differ.

#### Parameter `doc`

The document whose DocumentVersion will be returned.

#### Returns

The DocumentVersion corresponding to the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Document.Delete(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Delete(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Deletes a set of elements from the document.

#### Remarks

This method will delete the elements and any elements that are totally dependent upon that element. Any references to the deleted elements will become invalid and hence cause an exception to be thrown if they are accessed.
The elements will be deleted with no prompts for user confirmation. Pinned elements will be deleted with no warnings.

Note: in a family document, the predefined elements (those elements inherited from its family template file) can't be deleted by this method.

#### Parameter `elementIds`

The ids of the elements to delete.

#### Returns

The deleted element id set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more elements in elementIds do not exist in the document.
-or-
One or more of the elementIds cannot be deleted.

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

### `M:Autodesk.Revit.DB.Document.Delete(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Delete(Autodesk.Revit.DB.ElementId)`

#### Summary

Deletes an element from the document given the id of that element.

#### Remarks

This method will delete the element and any elements that are totally dependent upon that element. Any references to the deleted elements will become invalid and hence cause an exception to be thrown if they are accessed.
The elements will be deleted with no prompts for user confirmation. Pinned elements will be deleted with no warnings.

Note: in a family document, the predefined elements (those elements inherited from its family template file) can't be deleted by this method.

#### Parameter `elementId`

Id of the element to delete.

#### Returns

The deleted element id set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementId does not exist in the document
-or-
ElementId cannot be deleted.

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

### `M:Autodesk.Revit.DB.Document.RemovePaint(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.RemovePaint(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Face)`

#### Summary

Remove the material painted on the element's face.
If the face is currently not painted,it will do nothing.

#### Parameter `elementId`

The element that the painted face belongs to.

#### Parameter `face`

The painted element's face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementId does not exist in the document
-or-
The face doesn't belong to the element

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Document.Paint(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Face,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Paint(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Face,Autodesk.Revit.DB.ElementId)`

#### Summary

Paint the element's face with specified material.

#### Parameter `elementId`

The element that the face belongs to.

#### Parameter `face`

The painted element's face.

#### Parameter `materialId`

The material to be painted on the face

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementId does not exist in the document
-or-
The element materialId does not exist in the document
-or-
The face doesn't belong to the element
-or-
The materialId doesn't specify a material element.
-or-
The element's face cannot be painted.

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

### `M:Autodesk.Revit.DB.Document.GetPaintedMaterial(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetPaintedMaterial(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Face)`

#### Summary

Get the material painted on the element's face. Returns invalidElementId if the face is not painted.

#### Parameter `elementId`

The element that the face belongs to.

#### Parameter `face`

The painted element's face.

#### Returns

The material's Id painted on the element's face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementId does not exist in the document
-or-
The face doesn't belong to the element

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Document.IsPainted(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.IsPainted(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Face)`

#### Summary

Checks if the element's face is painted with a material.

#### Parameter `elementId`

The element that the face belongs to.

#### Parameter `face`

The painted element's face.

#### Returns

True if the element's face is painted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementId does not exist in the document
-or-
The face doesn't belong to the element

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Document.SynchronizeWithCentral(Autodesk.Revit.DB.TransactWithCentralOptions,Autodesk.Revit.DB.SynchronizeWithCentralOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.SynchronizeWithCentral(Autodesk.Revit.DB.TransactWithCentralOptions,Autodesk.Revit.DB.SynchronizeWithCentralOptions)`

#### Summary

Performs reload latest until the model in the current session is up to date and then saves changes back to central.
A save to central is performed even if no changes were made.

#### Parameter `transactOptions`

Options to customize behavior accessing the central model.

#### Parameter `syncOptions`

Options to customize behavior of SynchronizeWithCentral.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralFileCommunicationException`

The file-based central model could not be reached, because e.g. the network is down or the file server is down.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied due to lack of access privileges.
-or-
Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model is locked by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Username does not match the one used to create the local file.
-or-
Revit could not save all of the worksets that have been changed. Try again.
-or-
Some of the elements you changed in this model are now editable by someone else, or you checked out worksets that were at risk
or relinquished in the central model but not this file. You cannot synchronize with the central model until the other user
relinquishes these elements without making changes.
-or-
The central model has been replaced by a local model.
-or-
Local incompatible because it was closed without saving after synchronizing with central.
-or-
The central model is missing.
-or-
The central model is incompatible.
-or-
The central model is corrupt or not an RVT file.
-or-
The central model was rolled back.
-or-
The central model's elements have been relinquished
-or-
Your data or permissions saving is aborted by another user.
-or-
The central model is overritten by other user.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

Cannot access the local file.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a primary document, it is a linked document.
-or-
This Document is read-only: It cannot be modified.
-or-
This Document has an open editing transaction and is accepting changes.
-or-
This Document is not a project document.
-or-
This Document is in an edit mode.
-or-
Saving is not allowed in the current application mode.
-or-
This Document does not have a central location: Worksharing needs to be enabled and central model saved.
-or-
This Document is a local file that is not owned by the current user, who therefore is not allowed to modify it.
-or-
The local file is read-only.
It can not be saved before or after synchronizing with central.
-or-
This Document is not a workshared document.
-or-
Saving local before first reload latest and after saving changes to central
in Synchronize with Central is mandatory for server-based local models.
-or-
Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Synchronize With Central was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be reached
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

The disk space is running low on server, please contact the server administrator.
-or-
An internal error happened on the server, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the specified A360 project.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.HasAllChangesFromCentral`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.HasAllChangesFromCentral`

#### Summary

Returns whether the model in the current session is up to date with central.

#### Returns

True means up to date; false means out of date.

If central is locked but Revit can determine that
the model in the current session is out of date
without opening central, this method will return false
instead of throwing CentralModelContentionException.

#### Exception `T:Autodesk.Revit.Exceptions.CentralFileCommunicationException`

The file-based central model could not be reached, because e.g. the network is down or the file server is down.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied due to lack of access privileges.
-or-
Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model is locked by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Username does not match the one used to create the local file.
-or-
The central model has been replaced by a local model.
-or-
Local incompatible because it was closed without saving after synchronizing with central.
-or-
The central model is missing.
-or-
The central model is incompatible.
-or-
The central model is corrupt or not an RVT file.
-or-
The central model was rolled back.
-or-
The central model's elements have been relinquished
-or-
The central model is overritten by other user.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

Cannot access the local file.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a workshared document.
-or-
This Document is a local file that is not owned by the current user, who therefore is not allowed to modify it.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the specified A360 project.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.ReloadLatest(Autodesk.Revit.DB.ReloadLatestOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.ReloadLatest(Autodesk.Revit.DB.ReloadLatestOptions)`

#### Summary

Fetches changes from central (due to one or more synchronizations with central)
and merges them into the current session.

#### Remarks

After this call finishes, use hasAllChangesFromCentral to confirm that there were no
Synchronizations with Central performed during execution of ReloadLatest.

#### Parameter `reloadOptions`

Various options to control behavior of reloadLatest.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralFileCommunicationException`

The file-based central model could not be reached, because e.g. the network is down or the file server is down.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied due to lack of access privileges.
-or-
Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model is locked by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Username does not match the one used to create the local file.
-or-
Revit could not save all of the worksets that have been changed. Try again.
-or-
The central model has been replaced by a local model.
-or-
Local incompatible because it was closed without saving after synchronizing with central.
-or-
The central model is missing.
-or-
The central model is incompatible.
-or-
The central model is corrupt or not an RVT file.
-or-
The central model was rolled back.
-or-
The central model's elements have been relinquished
-or-
The central model is overritten by other user.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

Cannot access the local file.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a primary document, it is a linked document.
-or-
This Document is not a local model: it is not workshared or is central.
-or-
This Document is read-only: It cannot be modified.
-or-
This Document has an open editing transaction and is accepting changes.
-or-
This Document is not a project document.
-or-
This Document is in an edit mode.
-or-
This Document is a local file that is not owned by the current user, who therefore is not allowed to modify it.
-or-
Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Reload Latest was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the specified A360 project.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.GetSubelement(Autodesk.Revit.DB.ElementId,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetSubelement(Autodesk.Revit.DB.ElementId,System.Int32)`

#### Summary

Gets the subelement referenced by a parent id and subelement id.

#### Remarks

`null` will be returned if the input id string doesn't reference to a valid element or subelement.

#### Parameter `id`

Id of the element.

#### Parameter `subId`

Id of the sub element.

#### Returns

The subelement referenced by the input argument.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Document.GetSubelement(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetSubelement(System.String)`

#### Summary

Gets the subelement referenced by a unique id string.

#### Remarks

`null` will be returned if the input id string doesn't reference to a valid element or subelement.

#### Parameter `uniqueId`

The unique id that identifies element or subelement.
`P:Autodesk.Revit.DB.Element.UniqueId`

#### Returns

The subelement referenced by the input argument.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Document.GetSubelement(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetSubelement(Autodesk.Revit.DB.Reference)`

#### Summary

Gets the subelement referenced by the input reference.

#### Parameter `reference`

The reference that identifies element or subelement.

#### Returns

The subelement referenced by the input argument.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reference does not identify a valid element or subelement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Document.GetElement(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetElement(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the Element referenced by the input ElementId.

#### Remarks

`null` will be returned if the input ElementId doesn't reference to a valid Element.

#### Parameter `id`

The ElementId, whose referenced Element will be retrieved from the model.

#### Returns

The element referenced by the input argument.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Document.GetElement(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetElement(System.String)`

#### Summary

Gets the Element referenced by a unique id string.

#### Remarks

`null` will be returned if the input id string doesn't reference to a valid Element.

#### Parameter `uniqueId`

The element unique id, whose referenced Element will be retrieved from the model.
`P:Autodesk.Revit.DB.Element.UniqueId`

#### Returns

The element referenced by the input argument.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Document.GetElement(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetElement(Autodesk.Revit.DB.Reference)`

#### Summary

Gets the Element referenced by the input reference.

#### Remarks

`null` will be returned if the input reference doesn't reference to a valid Element.

#### Parameter `reference`

The reference, whose referenced Element will be retrieved from the model.

#### Returns

The element referenced by the input argument.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Document.MakeTransientElements(Autodesk.Revit.DB.ITransientElementMaker)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.MakeTransientElements(Autodesk.Revit.DB.ITransientElementMaker)`

#### Summary

This method encapsulates the process of creating transient elements in the document.

#### Remarks

The method establishes a context within which transient elements will be created and then invokes the given maker object to create the elements. For more information refer to the `P:Autodesk.Revit.DB.Element.IsTransient` method.

#### Parameter `maker`

An instance of a class that implements the `T:Autodesk.Revit.DB.ITransientElementMaker` interface.
The maker will be called to create element(s) which would become transient.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document has an open editing transaction and is accepting changes.
-or-
This Document is read-only: It cannot be modified.

### `M:Autodesk.Revit.DB.Document.GetDocumentPreviewSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetDocumentPreviewSettings`

#### Summary

Returns the preview settings for the given document.

#### Returns

The preview settings.

### `M:Autodesk.Revit.DB.Document.GetAllUnusedElements(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetAllUnusedElements(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Returns the list of element ids that are not used. The list of unused element ids may include elements that can't be deleted.

#### Remarks

This method returns unused element ids that are available in the Purge Unused window in the Revit, including elements that can't be deleted.
To get unused elements that do not have a category assigned add
`F:Autodesk.Revit.DB.BuiltInCategory.INVALID` to the collection of categories.
If the input categories collection is empty, the method returns all unused elements in the document.

#### Parameter `categories`

Collection of categories to check for unused elements.

#### Returns

Unused element ids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Document.GetUnusedElements(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetUnusedElements(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Returns the list of element ids that are not used and can be deleted from the document.

#### Remarks

This method returns unused element ids that are available in the Purge Unused window in the Revit.
To get unused elements that do not have a category assigned add
`F:Autodesk.Revit.DB.BuiltInCategory.INVALID` to the collection of categories.
If the input categories collection is empty, the method returns all unused elements in the document.

#### Parameter `categories`

Collection of categories to check for unused elements.

#### Returns

Unused elements that can be deleted from the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Document.IsDefaultFamilyTypeIdValid(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.IsDefaultFamilyTypeIdValid(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the family type id is valid for the give family category.

#### Parameter `familyCategoryId`

The family category id.

#### Parameter `familyTypeId`

The default family type id.

#### Returns

True if the family type id is valid for the give family category, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Document.SetDefaultFamilyTypeId(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.SetDefaultFamilyTypeId(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the default family type id for the given family category.

#### Parameter `familyCategoryId`

The family category id.

#### Parameter `familyTypeId`

The default family type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The family type id familyTypeId is invalid for the give family category familyCategoryId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Document.GetDefaultFamilyTypeId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetDefaultFamilyTypeId(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the default family type id with the given family category id.

#### Parameter `familyCategoryId`

The family category id.

#### Returns

The default family type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Document.IsDefaultElementTypeIdValid(Autodesk.Revit.DB.ElementTypeGroup,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.IsDefaultElementTypeIdValid(Autodesk.Revit.DB.ElementTypeGroup,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the element type id is valid for the give DefaultElmentType id.

#### Parameter `defaultTypeId`

The default element type id.

#### Parameter `typeId`

The element type id.

#### Returns

True if the element type id is valid for the give DefaultElmentType id, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.Document.SetDefaultElementTypeId(Autodesk.Revit.DB.ElementTypeGroup,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.SetDefaultElementTypeId(Autodesk.Revit.DB.ElementTypeGroup,Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the default element type id of the given DefaultElementType id.

#### Parameter `defaultTypeId`

The default element type id.

#### Parameter `typeId`

The element type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element type id typeId is invalid for the give DefaultElementType id defaultTypeId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.Document.GetDefaultElementTypeId(Autodesk.Revit.DB.ElementTypeGroup)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetDefaultElementTypeId(Autodesk.Revit.DB.ElementTypeGroup)`

#### Summary

Gets the default element type id with the given DefaultElementType id.

#### Parameter `defaultTypeId`

The default element type id.

#### Returns

The element type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.Document.GetCloudFolderId(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetCloudFolderId(System.Boolean)`

#### Summary

Gets ForgeDM folder id where the model locates.

#### Remarks

It is empty for non-cloud model;
It is cached in Revit model opened session after getting it if forceRefresh is false;
ForgeDM folder id can be changed during Revit model opened session, set forceRefresh as 'true' to get new value.

#### Parameter `forceRefresh`

Cached value will be refreshed by sending a service call when forceRefresh is true.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

Thrown when cannot get data from ForgeDM for Revit cloud model.

#### Since

2022

### `M:Autodesk.Revit.DB.Document.GetProjectId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetProjectId`

#### Summary

Gets ForgeDM project id where the model locates.

#### Remarks

It is empty for non-cloud model;
It is cached in Revit model opened session after getting it;

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

Thrown when cannot get data from ForgeDM for Revit cloud model.

#### Since

2022

### `M:Autodesk.Revit.DB.Document.GetHubId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetHubId`

#### Summary

Gets ForgeDM hub id where the model locates. It is cached in session.

#### Remarks

It is empty for non-cloud model;
It is cached in Revit model opened session after getting it;

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

Thrown when cannot get data from ForgeDM for Revit cloud model.

#### Since

2022

### `M:Autodesk.Revit.DB.Document.GetCloudModelUrn`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetCloudModelUrn`

#### Summary

A ForgeDM Urn identifying the model.

#### Remarks

It is empty for non-cloud model;
It is cached in Revit model opened session after getting it;

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

Thrown when cannot get data from ForgeDM.

#### Since

2022

### `M:Autodesk.Revit.DB.Document.GetCloudModelPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetCloudModelPath`

#### Summary

Gets the cloud model path of the cloud model.

#### Returns

The cloud model path

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is a not cloud model, cannot execute this operation.

#### Since

2019.1

### `M:Autodesk.Revit.DB.Document.GetWorksharingCentralModelPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetWorksharingCentralModelPath`

#### Summary

Gets the central model path of the worksharing model.

#### Returns

The central model path, or null if the document is not workshared.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a workshared document.

#### Since

2013

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.GBXMLExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.GBXMLExportOptions)`

#### Summary

Export the model in gbXML (green-building) format.

#### Remarks

This export operation will operate on the main EnergyAnalysisDetailModel in the document, if it exists (see EnergyAnalysisDetailModel.GetMainEnergyAnalysisDetailModel()).
If it does not exist, or if the requested ExportEnergyModelType does not match the type of the main EnergyAnalysisDetailModel, this function will fail.
If you need to export a model with different settings or type than the current main energy model in the document, you should delete the current main energy model, update the EnergyAnalysisSettings, and regenerate the energy model.

#### Parameter `folder`

Indicates the path of a folder where to export the gbXML file.

#### Parameter `name`

Indicates the name of the gbXML file to export. If it doesn't end with ".xml", extension ".xml" will be added automatically. The name cannot contain any of the following characters: \/:*?"<>|. Empty name is not acceptable.

#### Parameter `options`

Options which control the contents of the export.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The path is not valid for exporting gbXML files.
-or-
The name is empty or not valid for exporting gbXML files.
-or-
Analysis type is invalid. For AnalysisMode.ConceptualMasses, use Document.Export(String, String, MassGBXMLExportOptions).
-or-
There is no main EnergyAnalysisDetailModel in the document, or the current main EnergyAnalysisDetailModel is not compatible with the option set in the GBXMLExportOptions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Exporting is not allowed in the current application mode.
-or-
Export is temporarily disabled.

### `M:Autodesk.Revit.DB.Document.GetWarnings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetWarnings`

#### Summary

Returns list of failure messages generated from persistent (reviewable) warnings accumulated in the document.

#### Remarks

Function returns list of failure messages identical to the list displayed in a warning dialog when command
Manage tab->Inquiry pane->Review Warnings is issued through the UI. Operations performed on the returned list by the caller
do not impact information about warnings stored in the document.

#### Returns

List of failure messages representing warnings accumulated in the document.

#### Since

2018

### `M:Autodesk.Revit.DB.Document.PostFailure(Autodesk.Revit.DB.FailureMessage)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.PostFailure(Autodesk.Revit.DB.FailureMessage)`

#### Summary

Posts a failure to be displayed to the user at the end of transaction.

#### Remarks

If code inside transaction detects a problem that needs to be communicated to the user,
it should report these conditions via this method. Failures will be validated and possibly
resolved at the end of transaction.
Warnings posted via this method will not be stored in the document after they are resolved.
A unique key returned by postFailure can be stored for the lifetime of transaction and used to
remove failure message if it is no longer relevant.

#### Parameter `failure`

The failure to be posted.

#### Returns

A unique key that identifies posted failure message in a document. If exactly the same error is posted more than once,
and not removed between the postings, returned key will be the same every time.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Document must be in state of accepting posted failures and the failures must be appropriate
for that current state.

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

### `M:Autodesk.Revit.DB.Document.UnpostFailure(Autodesk.Revit.DB.FailureMessageKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.UnpostFailure(Autodesk.Revit.DB.FailureMessageKey)`

#### Summary

Deletes the posted failure message associated with a given FailureMessageKey.

#### Remarks

If code that previously has posted a failure is executed again or otherwise detects
that failure conditions do not exist anymore and the failure is not longer relevant,
it should delete a failure message in order to let transaction to be committed.
In order to delete the failure, it should invoke this method with a message key
that was returned when the failure was posted.

#### Parameter `messageKey`

The key of the FailureMessage to be deleted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

messageKey is invalid

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

2011

### `M:Autodesk.Revit.DB.Document.SaveToProjectAsImage(Autodesk.Revit.DB.ImageExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.SaveToProjectAsImage(Autodesk.Revit.DB.ImageExportOptions)`

#### Summary

Creates an image view from the currently active view.

#### Parameter `options`

The options which govern the image creation.

#### Returns

Id of the newly created view if the operation succeeded, invalid element id otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

options object is invalid: the ExportRange is invalid, must be CurrentView or VisibleRegionOfCurrentView, or the ViewName is invalid, must be non-empty, unique and should not contain prohibited characters.
-or-
The current view cannot be exported as an image

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.AXMImportOptions,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.AXMImportOptions,Autodesk.Revit.DB.View)`

#### Summary

Imports an AXM file into the document.

#### Parameter `file`

Full path of the file to import. File must exist and must be a valid AXM file.

#### Parameter `options`

Various import options applicable to the AXM format. If `null` , all options will be set to their respective default values.
Import FormIt support Preserve color mode, center-to-center and origin-to-origin placement, other options are not supported.
Import FormIt does not support orient to view and this view only option.

#### Parameter `pDBView`

View used to aid placement of the imported file. If the options specify center-to-center placement, this argument is required and the imported
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported
file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.

#### Returns

Returns the element Id of the imported instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for AXM import (.axm files are valid).
-or-
The provided view is not valid for the options provided.
-or-
Visible layer only option is not false or layers are specified in SetLayerSelection.
-or-
Import levels is only supported in project document or conceptual mass document for AXM import.
-or-
Not all AXM import option settings are valid. For more details, please refer to AXMImportOptions.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The AXM Import/Link module is not available in the installed Revit.

#### Since

2022.1

### `M:Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.DWFImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.DWFImportOptions)`

#### Summary

Links Markups in a DWF file into the project document.

#### Remarks

Link isn't supported for family documents. Please use import instead.

#### Parameter `file`

Full path of the file to link. File must exist and must be a valid DWF file.

#### Parameter `options`

Various link options applicable to the DWF format.

#### Returns

A collection of link instance element ids created by the markup link.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for DWF import (.dwf or.dwfx files are valid).
-or-
Some of the views are not importable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
This Document is not a project document.

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

### `M:Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.DGNImportOptions,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.DGNImportOptions,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId@)`

#### Summary

Links a DGN file into the project document.

#### Remarks

Link isn't supported for family documents. Please use import instead.

#### Parameter `file`

Full path of the file to link. File must exist and must be a valid DGN file.

#### Parameter `options`

Various import options applicable to the DGN format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked
file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.

#### Parameter `elementId`

The id of linked instance after a successful link.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for DGN import (.dgn files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.
-or-
Empty DGN model view name characters.
-or-
Visible layer only option must be set to false for DGN import.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The DGN Import/Link module is not available in the installed Revit.

#### Since

2013

### `M:Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.DGNImportOptions,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.DGNImportOptions,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId@)`

#### Summary

Imports a DGN file to the document.

#### Parameter `file`

Full path of the file to import. File must exist and must be a valid DGN file.

#### Parameter `options`

Various options applicable to the DGN format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported
file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.

#### Parameter `elementId`

The id of imported instance after a successful import.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for DGN import (.dgn files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.
-or-
Empty DGN model view name characters.
-or-
Visible layer only option must be set to false for DGN import.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The DGN Import/Link module is not available in the installed Revit.

#### Since

2013

### `M:Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.ImportOptions3DM,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.ImportOptions3DM,Autodesk.Revit.DB.View)`

#### Summary

Links a 3DM file into the project document.

#### Remarks

Link isn't supported for family documents. Please use import instead.

#### Parameter `file`

Full path of the file to link. File must exist and must be a valid 3DM file.

#### Parameter `options`

Various import options applicable to the 3DM format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked
file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.

#### Returns

Returns the element Id of the linked instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for 3DM import (.3dm files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The 3DM Import/Link module is not available in the installed Revit.

#### Since

2022

### `M:Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.ImportOptions3DM,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.ImportOptions3DM,Autodesk.Revit.DB.View)`

#### Summary

Imports a 3DM file into the document.

#### Parameter `file`

Full path of the file to import. File must exist and must be a valid 3DM file.

#### Parameter `options`

Various import options applicable to the 3DM format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported
file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.

#### Returns

Returns the element Id of the imported instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for 3DM import (.3dm files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The 3DM Import/Link module is not available in the installed Revit.

#### Since

2022

### `M:Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.STLImportOptions,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.STLImportOptions,Autodesk.Revit.DB.View)`

#### Summary

Links an STL file into the project document.

#### Remarks

Link isn't supported for family documents. Please use import instead.

#### Parameter `file`

Full path of the file to link. File must exist and must be a valid STL file.

#### Parameter `options`

Various import options applicable to the STL format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked
file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.

#### Returns

Returns the element Id of the linked instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for STL import (.stl files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The STL Import/Link module is not available in the installed Revit.

#### Since

2023

### `M:Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.STLImportOptions,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.STLImportOptions,Autodesk.Revit.DB.View)`

#### Summary

Imports an STL file into the document.

#### Parameter `file`

Full path of the file to import. File must exist and must be a valid STL file.

#### Parameter `options`

Various import options applicable to the STL format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported
file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.

#### Returns

Returns the element Id of the imported instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for STL import (.stl files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The STL Import/Link module is not available in the installed Revit.

#### Since

2022.1

### `M:Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.OBJImportOptions,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.OBJImportOptions,Autodesk.Revit.DB.View)`

#### Summary

Links an OBJ file into the project document.

#### Remarks

Link isn't supported for family documents. Please use import instead.

#### Parameter `file`

Full path of the file to link. File must exist and must be a valid OBJ file.

#### Parameter `options`

Various import options applicable to the OBJ format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked
file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.

#### Returns

Returns the element Id of the linked instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for OBJ import (.obj files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The OBJ Import/Link module is not available in the installed Revit.

#### Since

2023

### `M:Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.OBJImportOptions,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.OBJImportOptions,Autodesk.Revit.DB.View)`

#### Summary

Imports an OBJ file into the document.

#### Parameter `file`

Full path of the file to import. File must exist and must be a valid OBJ file.

#### Parameter `options`

Various import options applicable to the OBJ format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported
file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.

#### Returns

Returns the element Id of the imported instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for OBJ import (.obj files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The OBJ Import/Link module is not available in the installed Revit.

#### Since

2022.1

### `M:Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.SKPImportOptions,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.SKPImportOptions,Autodesk.Revit.DB.View)`

#### Summary

Links a SKP file into the project document.

#### Remarks

Link isn't supported for family documents. Please use import instead.

#### Parameter `file`

Full path of the file to link. File must exist and must be a valid SKP file.

#### Parameter `options`

Various import options applicable to the SKP format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked
file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.

#### Returns

Returns the element Id of the linked instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for SKP import (.skp files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The SKP Import/Link module is not available in the installed Revit.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.SKPImportOptions,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.SKPImportOptions,Autodesk.Revit.DB.View)`

#### Summary

Imports a SKP file into the document.

#### Parameter `file`

Full path of the file to import. File must exist and must be a valid SKP file.

#### Parameter `options`

Various import options applicable to the SKP format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported
file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.

#### Returns

Returns the element Id of the imported instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for SKP import (.skp files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The SKP Import/Link module is not available in the installed Revit.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.SATImportOptions,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.SATImportOptions,Autodesk.Revit.DB.View)`

#### Summary

Links an SAT file into the project document.

#### Remarks

Link isn't supported for family documents. Please use import instead.

#### Parameter `file`

Full path of the file to link. File must exist and must be a valid SAT file.

#### Parameter `options`

Various import options applicable to the SAT format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked
file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.

#### Returns

Returns the element Id of the linked instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for SAT import (.sat files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The SAT Import/Link module is not available in the installed Revit.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.SATImportOptions,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.SATImportOptions,Autodesk.Revit.DB.View)`

#### Summary

Imports an SAT file into the document.

#### Parameter `file`

Full path of the file to import. File must exist and must be a valid SAT file.

#### Parameter `options`

Various import options applicable to the SAT format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported
file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.

#### Returns

Returns the element Id of the imported instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for SAT import (.sat files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The SAT Import/Link module is not available in the installed Revit.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.DWGImportOptions,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Link(System.String,Autodesk.Revit.DB.DWGImportOptions,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId@)`

#### Summary

Links a DWG or DXF file into the project document.

#### Remarks

Link isn't supported for family documents. Please use import instead.

#### Parameter `file`

Full path of the file to link. File must exist and must be a valid DWG or DXF file.

#### Parameter `options`

Various import options applicable to the DWG or DXF format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked
file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.

#### Parameter `elementId`

The id of linked instance after a successful link.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for DWG import (.dwg and .dxf files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The line weights are not valid; either it contains an invalid number of line weights, or a line weight outside the valid range.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The DWG Import/Link module is not available in the installed Revit.

### `M:Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.DWGImportOptions,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.DWGImportOptions,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId@)`

#### Summary

Imports a DWG or DXF file to the document.

#### Parameter `file`

Full path of the file to import. File must exist and must be a valid DWG or DXF file.

#### Parameter `options`

Various options applicable to the DWG or DXF format. If `null` , all options will be set to their respective default values.

#### Parameter `pDBView`

View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file
will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported
file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported
file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.

#### Parameter `elementId`

The id of imported instance after a successful import.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not a valid file for DWG import (.dwg and .dxf files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
The provided view is not valid for the options provided.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The line weights are not valid; either it contains an invalid number of line weights, or a line weight outside the valid range.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
NullOrEmpty
-or-
The view is not printable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given file does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Import is temporarily disabled.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The DWG Import/Link module is not available in the installed Revit.

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.PDFExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.PDFExportOptions)`

#### Summary

Exports a selection of views in PDF format.

#### Parameter `folder`

Output folder, into which file(s) will be exported. The folder must exist.

#### Parameter `viewIds`

Selection of ordered views to be exported.
The list must contain at least one valid view.

#### Parameter `options`

Various options applicable to the PDF format.

#### Returns

True if all specified views are exported successfully,
False if exporting of any view fails, even if some views might have been exported successfully.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

non empty list of views must be provided.
-or-
NullOrEmpty
-or-
There are duplicate views in viewIds
-or-
some of the views are not printable (exportable).
-or-
Thrown when one or more input arguments are invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

Thrown when the target PDF file is inaccessible, e.g. already opened.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Export is temporarily disabled.
-or-
Exporting is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The folder does not exist.

#### Since

2022

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.NavisworksExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.NavisworksExportOptions)`

#### Summary

Exports a Revit project to the Navisworks .nwc format.

#### Remarks

This is an optional functionality that does not have to be installed. The method "OptionalFunctionalityUtils.isNavisworksExporterAvailable()" can be called to check if the exporter is present.

#### Parameter `folder`

The name of the folder for the exported file.

#### Parameter `name`

The name of the exported file. If it doesn't end in '.nwc', this extension will be added automatically.

#### Parameter `options`

Options which control the contents of the export.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

NullOrEmpty
-or-
Contains invalid characters.
-or-
The input options were not valid. Check the exception message for specific details.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Export is temporarily disabled.
-or-
Exporting is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The folder does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

The export operation is cancelled in event handler.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

A Navisworks Exporter is not available in the installed Revit.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.OBJExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.OBJExportOptions)`

#### Summary

Exports a view specified in the export options to the OBJ format.

#### Parameter `folder`

Output folder into which the file will be exported. The folder must exist.

#### Parameter `name`

Indicates the name of the OBJ file to export. If it doesn't end with ".obj", this extension will be added automatically.
The name cannot contain any of the following characters: \/:*?"<>|. Empty name is not acceptable.

#### Parameter `options`

Various options applicable to the OBJ format.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

NullOrEmpty
-or-
Contains invalid characters.
-or-
The provided options do not specify a printable 3D view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Export is temporarily disabled.
-or-
Exporting is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The folder does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The ShapeExporter functionality is not available in the installed Revit, or the Material Library is missing.

#### Since

2023

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.STLExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.STLExportOptions)`

#### Summary

Exports a view specified in the export options to the STL format.

#### Parameter `folder`

Output folder into which the file will be exported. The folder must exist.

#### Parameter `name`

Indicates the name of the STL file to export. If it doesn't end with ".stl", this extension will be added automatically.
The name cannot contain any of the following characters: \/:*?"<>|. Empty name is not acceptable.

#### Parameter `options`

Various options applicable to the STL format.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

NullOrEmpty
-or-
Contains invalid characters.
-or-
The provided options do not specify a printable 3D view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Export is temporarily disabled.
-or-
Exporting is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The folder does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The ShapeExporter functionality is not available in the installed Revit, or the Material Library is missing.

#### Since

2021.1

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.IFCExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.IFCExportOptions)`

#### Summary

Exports the document to the Industry Standard Classes (IFC) format.

#### Remarks

Exporting to IFC requires that document is modifiable, therefore there must be a transaction already open when this method is called.

This method may not be invoked during dynamic update, for the internal routine might need to modify the existing transaction.

#### Parameter `folder`

Output folder into which the file will be exported. The folder must exist.

#### Parameter `name`

Either the name of a single file or a prefix for a set of files.
If empty, automatic naming will be used.

#### Parameter `options`

Various options applicable to the IFC format.
If `null` , all options will be set to their respective default values.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

NullOrEmpty
-or-
Contains invalid characters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The IFCExportOptions FamilyMappingFile does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Export is temporarily disabled.
-or-
Exporting is not allowed in the current application mode.
-or-
This Document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The folder does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The IFC module is not available in the installed Revit.

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.SATExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.SATExportOptions)`

#### Summary

Exports the current view or a selection of views in SAT format.

#### Remarks

All the views must be 3D views for the Export to succeed.

#### Parameter `folder`

Output folder, into which file(s) will be exported. The folder must exist.

#### Parameter `name`

Either the name of a single file or a prefix for a set of files.
If empty, automatic naming will be used.

#### Parameter `views`

Selection of views to be exported. The set must contain at least one valid view.

#### Parameter `options`

Various options applicable to the SAT format.For now, this option is empty.
If `null` , all options will be set to their respective default values.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

NullOrEmpty
-or-
Contains invalid characters.
-or-
non empty list of views must be provided.
-or-
At least one provided viewId does not correspond to a printable 3D view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DirectoryNotFoundException`

Thrown when the directory does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Export is temporarily disabled.
-or-
Exporting is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The folder does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The ShapeExporter functionality is not available in the installed Revit, or the Material Library is missing.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.DGNExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.DGNExportOptions)`

#### Summary

Exports a selection of views in DGN format.

#### Remarks

All the views must be printable for the Export to succeed.
It can be assured by checking the CanBePrinted property of each view.

#### Parameter `folder`

Output folder, into which file(s) will be exported. The folder must exist.

#### Parameter `name`

Either the name of a single file or a prefix for a set of files.
If empty, automatic naming will be used.
If `null` , throw ArgumentException.

#### Parameter `views`

Selection of views to be exported. The set must contain at least one valid view.

#### Parameter `options`

Various options applicable to the DGN format.
If `null` , all options will be set to their respective default values.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

NullOrEmpty
-or-
Contains invalid characters.
-or-
non empty list of views must be provided.
-or-
some of the views are not printable (exportable).
-or-
Thrown when the options in DGNExportOptions is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DirectoryNotFoundException`

Thrown when the directory does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Export is temporarily disabled.
-or-
Exporting is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The folder does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The DWG module is not available in the installed Revit.
-or-
The Graphics module is not available in the installed Revit.

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.DXFExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.DXFExportOptions)`

#### Summary

Exports a selection of views in DXF format.

#### Remarks

All the views must be printable for the Export to succeed.
It can be assured by checking the CanBePrinted property of each view.

#### Parameter `folder`

Output folder, into which file(s) will be exported. The folder must exist.

#### Parameter `name`

Either the name of a single file or a prefix for a set of files.
If empty, automatic naming will be used.

#### Parameter `views`

Selection of views to be exported. The set must contain at least one valid view.

#### Parameter `options`

Various options applicable to the DXF format.
If `null` , all options will be set to their respective default values.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

NullOrEmpty
-or-
Contains invalid characters.
-or-
non empty list of views must be provided.
-or-
some of the views are not printable (exportable).
-or-
Thrown when the options in DWGExportOptions is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DirectoryNotFoundException`

Thrown when the directory does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Export is temporarily disabled.
-or-
Exporting is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The folder does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The DXF module is not available in the installed Revit.
-or-
The Graphics module is not available in the installed Revit.

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.DWGExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.DWGExportOptions)`

#### Summary

Exports a selection of views in DWG format.

#### Remarks

All the views must be printable for the Export to succeed.
It can be assured by checking the CanBePrinted property of each view.

#### Parameter `folder`

Output folder, into which file(s) will be exported. The folder must exist.

#### Parameter `name`

Either the name of a single file or a prefix for a set of files.
If empty, automatic naming will be used.
If `null` , throw ArgumentException.

#### Parameter `views`

Selection of views to be exported. The set must contain at least one valid view.

#### Parameter `options`

Various options applicable to the DWG format.
If `null` , all options will be set to their respective default values.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

NullOrEmpty
-or-
Contains invalid characters.
-or-
non empty list of views must be provided.
-or-
some of the views are not printable (exportable).
-or-
The modifiers set in layer info must be valid.
-or-
Thrown when the options in DWGExportOptions is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DirectoryNotFoundException`

Thrown when the directory does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Export is temporarily disabled.
-or-
Exporting is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The folder does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The DWG module is not available in the installed Revit.
-or-
The Graphics module is not available in the installed Revit.

### `M:Autodesk.Revit.DB.Document.ExportImage(Autodesk.Revit.DB.ImageExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.ExportImage(Autodesk.Revit.DB.ImageExportOptions)`

#### Summary

Exports a view or set of views into an image file.

#### Parameter `options`

The options which govern the image export.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The current view cannot be exported as an image

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The path indicated could not be accessed.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

The path indicated could not be found.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Exporting is not allowed in the current application mode.
-or-
Failed to export image due to an error with the inputs.
-or-
Failed to export image due to an issue where the DirectX Device was lost.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The Graphics module is not available in the installed Revit.

#### Since

2011

### `M:Autodesk.Revit.DB.Document.EnableCloudWorksharing`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.EnableCloudWorksharing`

#### Summary

Enables cloud worksharing for a cloud model

#### Remarks

This operation will convert an existing cloud model to a workshared cloud model.
This method cannot be used if current model is not a cloud model.
This method cannot be used if the current user doesn't have the workshared cloud model entitlement.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the cloud model was denied due to lack of access privileges.
-or-
Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model is locked by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

The model in cloud is missing.
-or-
The model in cloud is incompatible.
-or-
The model in cloud is corrupt or not an RVT file.
-or-
The model in cloud was rolled back.
-or-
An internal error happened on the model in cloud , please contact the administrator.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

Cannot access the local cache.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a primary document, it is a linked document.
-or-
This Document is read-only: It cannot be modified.
-or-
This Document has an open editing transaction and is accepting changes.
-or-
This Document is not a project document.
-or-
This Document is in an edit mode.
-or-
Saving is not allowed in the current application mode.
-or-
This Document does not have a central location: Worksharing needs to be enabled and central model saved.
-or-
The file is read-only, can not be saved.
-or-
The cloud model does not allow cloud worksharing to be enabled.
-or-
Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

Could be for any of the reasons related to network.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

Could be for any of the reasons that conversion fails with RevitServerInternalException.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

You do not have workshared cloud model entitlement to access this resource in cloud
-or-
User is not authorized to access the specified cloud project.

#### Since

2019.2

### `M:Autodesk.Revit.DB.Document.SaveAsCloudModel(System.Guid,System.Guid,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.SaveAsCloudModel(System.Guid,System.Guid,System.String,System.String)`

#### Summary

Saves current non-workshared or workshared model as a cloud model or workshared cloud model in BIM 360 Docs or Autodesk Docs.

#### Remarks

Assumes that user is currently signed in BIM 360 Docs or Autodesk Docs and has access to Autodesk cloud services.
This operation will create a model on cloud and then create a local cache of the cloud model.
This method cannot be used when current document is already in cloud.

You can use one of the following methods to save a local model as a workshared cloud model in BIM 360 Docs or Autodesk Docs.
If the local model is a workshared model, then it will be a workshared cloud model after you use this method successfully.

If the local model is a non-workshared model, you can enable the workset with `M:Autodesk.Revit.DB.Document.EnableWorksharing(System.String,System.String)` and then save as a workshared cloud model.

If the local model is a non-workshared model, and you have already saved it as a non-workshared cloud model in BIM 360 Docs or Autodesk Docs, you can still enable the workset with
`M:Autodesk.Revit.DB.Document.EnableCloudWorksharing` to convert it to a workshared cloud model.

You cannot save a local workshared model as a non-workshared cloud model in BIM 360 Docs or Autodesk Docs.

#### Parameter `accountId`

The BIM 360 Docs or Autodesk Docs account Id.
You can use one of the following methods to get this Id:
If you get the hub Id with Forge Data Management API, remove the prefix "b." of the Id string and convert the rest to a Guid.

If you get the account Id with Forge BIM 360 Docs or Autodesk Docs API, just convert the Id string to a Guid.

#### Parameter `projectId`

The BIM 360 Docs or Autodesk Docs project Id.
You can use one of the following methods to get this Id:
If you get the project Id with Forge Data Management API, remove the prefix "b." of the Id string and convert the rest to a Guid.

If you get the project Id with Forge BIM 360 Docs or Autodesk Docs API, just convert the Id string to a Guid.

#### Parameter `folderId`

Folder identity in BIM 360 Docs or Autodesk Docs to save the model.
You can use one of the following methods to get this Id:
The folder Id string from Forge Data Management API.

The folder Id string from Forge BIM 360 Docs or Autodesk Docs API.

#### Parameter `modelName`

Model name in BIM 360 Docs or Autodesk Docs to save the model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

folderId is an empty string.
-or-
modelName is an empty string.
-or-
The input file name "modelName" does not represent a valid file name.
-or-
Thrown when the input BIM 360 Docs or Autodesk Docs account Id or project Id is invalid or unmatched.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

SaveAs may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Saving is not allowed in the current application mode.
-or-
This Document is not a project document.
-or-
This Document is in an edit mode.
-or-
This Document is not a primary document, it is a linked document.
-or-
SaveAs is temporarily disabled.
-or-
This Document is a cloud model, cannot be saved as a cloud model.
-or-
There is a transaction phase left open (such as a transaction, sub-transaction of transaction group) at the time of invoking this method.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

Could be for any of the reasons related to network.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

Could be for any of the reasons that saveAs fails with RevitServerInternalException.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerModelAlreadyExistsException`

Failed due to there is a model with the same name already exists at the specified location.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerModelNameBreaksConventionException`

Failed due to the model name is breaking project naming convention.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

You don't have the entitlement to perform the operation to this this Document.
-or-
User is not authorized to access the specified cloud project.

#### Since

2021

### `M:Autodesk.Revit.DB.Document.SaveCloudModel`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.SaveCloudModel`

#### Summary

Saves cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Could be for any of the reasons that related to access to the cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model is locked by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Could be for any of the reasons that fails with CentralModelException, for example, a central model with that name
is already associated to the specified cloud project.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

Cannot access the local file.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a primary document, it is a linked document.
-or-
This Document is read-only: It cannot be modified.
-or-
This Document has an open editing transaction and is accepting changes.
-or-
This Document is not a project document.
-or-
This Document is in an edit mode.
-or-
Saving is not allowed in the current application mode.
-or-
This Document does not have a central location: Worksharing needs to be enabled and central model saved.
-or-
The file is read-only, can not be saved.
-or-
This Document is a not cloud model, cannot execute this operation.
-or-
This Document is a workshared document.
-or-
Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Synchronize With Central was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

Could be for any of the reasons related to network.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

Could be for any of the reasons that save fails with RevitServerInternalException.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the specified cloud project.

#### Since

2019.2

### `M:Autodesk.Revit.DB.Document.SaveAs(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.SaveAsOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.SaveAs(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.SaveAsOptions)`

#### Summary

Saves the document to a given path.

#### Remarks

This method may not be called unless all transactions, sub-transactions, and transaction groups
that were opened by the API code were closed.
That also implies that this method cannot be called during dynamic updates.
Event handlers are not allowed to save document that are currently in modifiable state.

If options.rename is true, then the document's title in Revit's title bar
will be updated automatically to reflect the file's new name.

#### Parameter `path`

Name and path to be saved as. For a file path, either a relative or absolute path can be provided.

#### Parameter `options`

Options to govern the SaveAs operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The path is empty.
-or-
The specified filepath is invalid.
-or-
options.PreviewViewId is not valid for generation of a preview.
-or-
The document is not workshared,
so no WorksharingSaveAsOptions are allowed to be set for SaveAs.
-or-
The document just had worksharing enabled or was opened detached,
so WorksharingSaveAsOptions.SaveAsCentral must be set to true for SaveAs.
-or-
Revit cannot clear the transmitted flag. This is not a transmitted document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model is being accessed by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

The central model is overwritten by other user.
-or-
The central model is missing.
-or-
The central model is incompatible.
-or-
Your data or permissions saving is aborted by another user.
-or-
The central model was saved in a different version of Revit.
-or-
Revit encountered errors while saving to the new central model. Resave again as a new central model.
-or-
Incompatible servers for external services.
-or-
Overwrite old-version model is not supported for server-based.
-or-
An internal error happened on the central model, please contact the server administrator.
-or-
Username does not match the one used to create the local file.
-or-
Revit could not save all of the worksets that have been changed. Try again.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The file at the given path location could not be accessed or saved.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

The given file, path or network location could not be found during save.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

SaveAs may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to save the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a primary document, it is a linked document.
-or-
SaveAs is temporarily disabled.
-or-
options.overwriteExistingFile is 'false' but there is an existing file at path.
-or-
options.overwriteExistingFile is 'true' but the target file at path is read only.
-or-
There is already a central at path; Revit Server does not allow overwrite.
-or-
Revit Server only supports RVT model.
-or-
Saving is not allowed in the current application mode.
-or-
Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.
-or-
Saving failed.
-or-
The file path is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Saving was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.OutdatedDirectlyOpenedCentralException`

Other users have modified the central model while you had it opened. Resave your document as a local file and then synchronize with central again.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

The disk space is running low on server, please contact the server administrator.
-or-
An internal error happened on the server, please contact the server administrator.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.SaveAs(System.String,Autodesk.Revit.DB.SaveAsOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.SaveAs(System.String,Autodesk.Revit.DB.SaveAsOptions)`

#### Summary

Saves the document to a given file path.

#### Remarks

This method may not be called unless all transactions, sub-transactions, and transaction groups
that were opened by the API code were closed.
That also implies that this method cannot be called during dynamic updates.
Event handlers are not allowed to save document that are currently in modifiable state.

If options.rename is true, then the document's title in Revit's title bar
will be updated automatically to reflect the file's new name.

#### Parameter `filepath`

File name and path to be saved as. Either a relative or absolute path can be provided.

#### Parameter `options`

Options to govern the SaveAs operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

filepath is an empty string.
-or-
The specified filepath is invalid.
-or-
options.PreviewViewId is not valid for generation of a preview.
-or-
The document is not workshared,
so no WorksharingSaveAsOptions are allowed to be set for SaveAs.
-or-
The document just had worksharing enabled or was opened detached,
so WorksharingSaveAsOptions.SaveAsCentral must be set to true for SaveAs.
-or-
Revit cannot clear the transmitted flag. This is not a transmitted document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Central model is missing.
-or-
Central model is incompatible.
-or-
The central model was saved in a different version of Revit.
-or-
Revit encountered errors while saving to the new central model. Resave again as a new central model.
-or-
Incompatible servers for external services.
-or-
Username does not match the one used to create the local file.
-or-
Revit could not save all of the worksets that have been changed. Try again.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The file at the given path location could not be accessed or saved.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

The given file, path or network location could not be found during save.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

SaveAs may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to save the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a primary document, it is a linked document.
-or-
SaveAs is temporarily disabled.
-or-
options.overwriteExistingFile is 'false' but there is an existing file at filepath.
-or-
options.overwriteExistingFile is 'true' but the target file at filepath is read only.
-or-
Saving is not allowed in the current application mode.
-or-
Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.
-or-
Revit cannot clear the transmitted flag. This is not a transmitted document.
-or-
Saving failed.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Saving was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.OutdatedDirectlyOpenedCentralException`

Other users have modified the central model while you had it opened. Resave your document as a local file and then synchronize with central again.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.SaveAs(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.SaveAs(System.String)`

#### Summary

Saves the document to a given file path.

#### Remarks

The document's title in Revit's title bar
will be updated automatically to reflect the file's new name.

#### Parameter `filepath`

File name and path to be saved as. Either a relative or absolute path can be provided.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

filepath is an empty string.
-or-
The filepath is not a valid file path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Central model is missing.
-or-
Central model is incompatible.
-or-
The central model was saved in a different version of Revit.
-or-
Revit encountered errors while saving to the new central model. Resave again as a new central model.
-or-
Incompatible servers for external services.
-or-
Username does not match the one used to create the local file.
-or-
Revit could not save all of the worksets that have been changed. Try again.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The file at the given path location could not be accessed or saved.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

The given file, path or network location could not be found during save.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

SaveAs may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to save the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a primary document, it is a linked document.
-or-
SaveAs is temporarily disabled.
-or-
There is an existing file at filepath.
-or-
Saving is not allowed in the current application mode.
-or-
The document just had worksharing enabled or was opened detached,
so SaveAsOptions must be passed in SaveAs
with WorksharingSaveAsOptions.SaveAsCentral set to true.
-or-
Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.
-or-
Saving failed.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Saving was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.OutdatedDirectlyOpenedCentralException`

Other users have modified the central model while you had it opened. Resave your document as a local file and then synchronize with central again.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.Save(Autodesk.Revit.DB.SaveOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Save(Autodesk.Revit.DB.SaveOptions)`

#### Summary

Saves the document.

#### Remarks

If the document was created in this current session and has not been saved to a file yet,
it needs to be first saved using the SaveAs method instead.

This method may not be called unless all transactions, sub-transactions, and transaction groups
that were opened by the API code were closed.
That also implies that this method cannot be called during dynamic updates.
Event handlers are not allowed to save document that are currently in modifiable state.

#### Parameter `options`

Options to control the Save operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

options.PreviewViewId is not valid for generation of a preview.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Central model is missing.
-or-
Central model is incompatible.
-or-
The central model was saved in a different version of Revit.
-or-
Revit encountered errors while saving to the new central model. Resave again as a new central model.
-or-
Incompatible servers for external services.
-or-
Username does not match the one used to create the local file.
-or-
Revit could not save all of the worksets that have been changed. Try again.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Save may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to save the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a primary document, it is a linked document.
-or-
Save is temporarily disabled.
-or-
Saving is not allowed in the current application mode.
-or-
File path must be already set to be able to save the document.It needs to be first saved using the SaveAs method instead.
-or-
The file is read-only, can not be saved.
-or-
Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.
-or-
Saving failed.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Saving was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.OutdatedDirectlyOpenedCentralException`

Other users have modified the central model while you had it opened. Resave your document as a local file and then synchronize with central again.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.Save`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Save`

#### Summary

Saves the document.

#### Remarks

If the document was created in this current session and has not been saved to a file yet,
it needs to be first saved using the SaveAs method instead.

This method may not be called unless all transactions, sub-transactions, and transaction groups
that were opened by the API code were closed.
That also implies that this method cannot be called during dynamic updates.
Event handlers are not allowed to save document that are currently in modifiable state.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Central model is missing.
-or-
Central model is incompatible.
-or-
The central model was saved in a different version of Revit.
-or-
Revit encountered errors while saving to the new central model. Resave again as a new central model.
-or-
Incompatible servers for external services.
-or-
Username does not match the one used to create the local file.
-or-
Revit could not save all of the worksets that have been changed. Try again.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Save may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to save the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Document is not a primary document, it is a linked document.
-or-
Save is temporarily disabled.
-or-
Saving is not allowed in the current application mode.
-or-
File path must be already set to be able to save the document.It needs to be first saved using the SaveAs method instead.
-or-
The file is read-only, can not be saved.
-or-
Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.
-or-
Saving failed.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Saving was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.OutdatedDirectlyOpenedCentralException`

Other users have modified the central model while you had it opened. Resave your document as a local file and then synchronize with central again.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.GetWorksetId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetWorksetId(Autodesk.Revit.DB.ElementId)`

#### Summary

Get Id of the Workset which owns the element.

#### Remarks

Each element belongs to one and only one workset.

#### Parameter `id`

Id of the element.

#### Returns

Id of the Workset which owns the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Document.EnableWorksharing(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.EnableWorksharing(System.String,System.String)`

#### Summary

Enables worksharing in the document.

#### Remarks

The document's Undo history will be cleared by this command. As a result, this command and others executed before it cannot be undone.

All transaction phases (e.g. transactions transaction groups and sub-transaction) that were explicitly started must be finished prior to calling this method.

#### Parameter `worksetNameGridLevel`

Name of workset for grids and levels.

#### Parameter `worksetName`

Name of workset for all other elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

worksetNameGridLevel is an empty string.
-or-
worksetName is an empty string.
-or-
worksetNameGridLevel cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
worksetName cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

This method may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document does not allow worksharing to be enabled.
-or-
This Document is in an edit mode.
-or-
This Document is a workshared document.
-or-
There is a transaction phase left open (such as a transaction, sub-transaction of transaction group) at the time of invoking this method.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Enabling worksharing was cancelled.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.CanEnableWorksharing`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.CanEnableWorksharing`

#### Summary

Checks if worksharing can be enabled in the document.

#### Returns

True if worksharing can be enabled in the document, False otherwise.

#### Since

2015

### `M:Autodesk.Revit.DB.Document.CanEnableCloudWorksharing`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.CanEnableCloudWorksharing`

#### Summary

Checks if cloud worksharing can be enabled for the cloud model.

#### Returns

True if cloud worksharing can be enabled in the document, which also means the current document is a single user cloud model, False otherwise.

#### Since

2019.2

### `M:Autodesk.Revit.DB.Document.SetUnits(Autodesk.Revit.DB.Units)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.SetUnits(Autodesk.Revit.DB.Units)`

#### Summary

Sets the units.

#### Parameter `units`

The units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Document.GetUnits`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetUnits`

#### Summary

Gets the Units object.

#### Returns

The Units object.

#### Since

2014

### `M:Autodesk.Revit.DB.Document.GetWorksetTable`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetWorksetTable`

#### Summary

Get the WorksetTable of this document.

#### Remarks

There is one WorksetTable for each document.
There will be at least one workset in the table, even if sharing has not yet been enabled for this document.

#### Returns

The WorksetTable of this document.

### `P:Autodesk.Revit.DB.Document.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Document.CreationGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.CreationGUID`

#### Summary

A unique identifier generated when the Document was first created.

#### Since

2024

### `P:Autodesk.Revit.DB.Document.MassDisplayTemporaryOverride`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.MassDisplayTemporaryOverride`

#### Summary

This setting controls temporary display in views of objects with mass category or subcategories.

#### Remarks

This setting is temporary and is not stored in the document.
The mass display overrides allow mass category and certain mass subcategories
to be displayed in all views, regardless of the visibility settings of that view.
The settings that show certain mass subcategories will also force the other mass
subcategories to be hidden.

#### Value

The MassDisplayTemporaryOverrideType that is active.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The MassDisplayTemporaryOverrideType::Enum value is not in the proper range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.Document.WorksharingProjectGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.WorksharingProjectGUID`

#### Summary

The central GUID of the A360 project to which the central model is associated.

#### Remarks

This is only valid if the central model is cloud-based.

#### Since

2015

### `P:Autodesk.Revit.DB.Document.CloudModelGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.CloudModelGUID`

#### Summary

The GUID of the cloud model.

#### Remarks

This is only valid if the model is cloud-based.

#### Since

2019.1

### `P:Autodesk.Revit.DB.Document.WorksharingCentralGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.WorksharingCentralGUID`

#### Summary

The central GUID of the server-based model.

#### Remarks

The central model of this document that is file-based model or saved in a release prior to Revit 2013 did not have this GUID.
Only the central model saved in Revit 2013 or later and stored on Revit Server will be able to provide this value.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

Thrown when the central model of this document is not a server-based model that created in Revit 2013 or later release.

#### Since

2013

### `P:Autodesk.Revit.DB.Document.IsModelInCloud`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.IsModelInCloud`

#### Summary

Identifies if document is stored on Autodesk cloud services.

#### Since

2019.1

### `P:Autodesk.Revit.DB.Document.IsDetached`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.IsDetached`

#### Summary

Identifies if a workshared document is detached.
Also, see `P:Autodesk.Revit.DB.Document.IsWorkshared`

#### Remarks

Note that `P:Autodesk.Revit.DB.Document.Title` and `P:Autodesk.Revit.DB.Document.PathName` will be empty strings if a document is detached.

#### Since

2015

### `P:Autodesk.Revit.DB.Document.IsCentralModel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.IsCentralModel`

#### Summary

Identifies whether this is a central model.

### `P:Autodesk.Revit.DB.Document.IsLocalModel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.IsLocalModel`

#### Summary

Identifies whether this is a local model.

### `P:Autodesk.Revit.DB.Document.IsWorkshared`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.IsWorkshared`

#### Summary

Identifies if worksharing (i.e. editing permissions and multiple worksets) have been enabled in the document.
Also, see `P:Autodesk.Revit.DB.Document.IsDetached`

### `P:Autodesk.Revit.DB.Document.IsLinked`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.IsLinked`

#### Summary

Identifies if a document is a linked RVT.

#### Since

2014

### `P:Autodesk.Revit.DB.Document.IsReadOnlyFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.IsReadOnlyFile`

#### Summary

Signals whether the document was opened from a read-only file.

#### Remarks

A document could be opened this way when, for example, at the time of opening
the file was being used by another Revit user, or if the disk file has the read-only attribute set.

Although it will still be possible to modify the opened document,
any changes made there will not be possible to save into the original file.
If the changes are to be preserved, the document must be saved under a different
name using the SaveAs() method.

### `P:Autodesk.Revit.DB.Document.IsReadOnly`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.IsReadOnly`

#### Summary

Identifies if the document is read-only or can possibly be modified.

#### Remarks

Like the `P:Autodesk.Revit.DB.Document.IsModifiable` , IsReadOnly is also a dynamic property.
It's value can change depending on the state a document is currently in.
There are various factors that may affect this property.
The most probable reason for this property to return 'true' is when Revit is currently processing failures (recoverable or not).
Another possibility is when an external command is executed in read-only mode.
If a document is in a read-only state, then not only the model cannot be modified at the moment, but even a new transaction may not be started.
Attempting to do so will raise an InvalidOperationException.

### `P:Autodesk.Revit.DB.Document.IsModified`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.IsModified`

#### Summary

The state of changes made to the document.

### `P:Autodesk.Revit.DB.Document.IsModifiable`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.IsModifiable`

#### Summary

Identifies if the document is modifiable.

#### Remarks

This is not a permanent state such as, for example `P:Autodesk.Revit.DB.Document.IsReadOnlyFile` .
Value of this property changes dynamically multiple times within the life-time of an open document.
Regardless of the mode a document is opened with, the model can only be modified inside an open transaction.
Furthermore, even with a transaction open, the model is not always modifiable.
Though this is rather a rare situation, it can happen, most likely during model regeneration, failure processing, or some events.
An attempt to modify a non-modifiable document will result in throwing a ModificationOutsideTransactionException.
See also `P:Autodesk.Revit.DB.Document.IsReadOnly`

### `P:Autodesk.Revit.DB.Document.Title`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.Title`

#### Summary

The document's title.

#### Remarks

Title is derived from the document's filename, not including the filename extension.
Note that returned title will be defaulted if no document saved.
Note that returned string may be empty if a document is detached. See `P:Autodesk.Revit.DB.Document.IsDetached` .

### `P:Autodesk.Revit.DB.Document.PathName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.PathName`

#### Summary

The fully qualified path of the document's disk file.

#### Remarks

This string is empty if the project has not been saved
or does not have a disk file associated with it yet.
Note that the pathname will be empty if a document is detached. See `P:Autodesk.Revit.DB.Document.IsDetached` .

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.ViewSet,Autodesk.Revit.DB.DWFXExportOptions,System.Collections.Generic.IList{System.String}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.ViewSet,Autodesk.Revit.DB.DWFXExportOptions,System.Collections.Generic.IList{System.String}@)`

#### Summary

Exports the current view or a selection of views in DWFX format.

#### Parameter `folder`

Output folder, into which file(s) will be exported. The folder must exist.

#### Parameter `name`

Either the name of a single file or a prefix for a set of files.
If `null` or empty, automatic naming will be used.

#### Parameter `views`

Selection of views to be exported.

#### Parameter `options`

Various options applicable to the DWFX format.
If `null` , all options will be set to their respective default values.

#### Parameter `uniqueIds`

Output elements' unique ids container, all these elements which can be seen in views would be exported.

#### Returns

Function returns true only if all specified views are exported successfully.
The function returns False if exporting of any view fails, even if some views might have been exported successfully.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input views is `null`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input views is an empty ViewSet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current document is not modifiable.

#### Remarks

All the views must be printable in order for the Export to succeed.
It can be assured by checking the CanBePrinted property of each view.

### `M:Autodesk.Revit.DB.Document.Paint(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Face,Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Paint(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Face,Autodesk.Revit.DB.FamilyParameter)`

#### Summary

Paint the element's face with specified material.

#### Parameter `elementId`

The element that the face belongs to.

#### Parameter `face`

The painted element's face.

#### Parameter `familyParameter`

The family parameter associated with a material.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementId does not exist in the document.
-or-
The element materialId does not exist in the document.
-or-
The face doesn't belongs to the element.
-or-
The family parameter doesn't specify a material element.
-or-
The element's face cannot be painted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This document is not modifiable.
-or-
This operation is valid only in family.

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

### `M:Autodesk.Revit.DB.Document.AutoJoinElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.AutoJoinElements`

#### Summary

Forces the elements in the Revit document to automatically join to their neighbors where appropriate.

#### Exception `T:Autodesk.Revit.Exceptions.AutoJoinFailedException`

Thrown when the operation fails.

#### Remarks

Use this method to force elements in the document to automatically join to their neighbors. Note that when a transaction
is committed there is an automatic call to automatically join elements.

### `M:Autodesk.Revit.DB.Document.Regenerate`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Regenerate`

#### Summary

Updates the elements in the Revit document to reflect all changes.

#### Exception `T:Autodesk.Revit.Exceptions.RegenerationFailedException`

Thrown when the operation fails.
If regeneration fails, there is posted error of severity DocumentCorruption that will be delivered to the end user
at the end of transaction explaining what specifically has happened.

If regeneration has failed, document is corrupted and even reading from it is illegal.

Code that called regeneration and got this exception should not catch and ignore it - instead, it should do nothing
but internal cleanup and return control to the owner of currently active transaction/subtransaction, which must be aborted.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Modification of the document is forbidden. Typically,
this is because there is no open transaction; consult documentation for Document.IsModified for other possible causes.

#### Remarks

Use this method to force update to the document after a group of changes. Note that when a transaction is committed
there is an automatic call to regenerate the document.

### `M:Autodesk.Revit.DB.Document.ConvertSymbolicToModelCurves(Autodesk.Revit.DB.View,Autodesk.Revit.DB.SymbolicCurveArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.ConvertSymbolicToModelCurves(Autodesk.Revit.DB.View,Autodesk.Revit.DB.SymbolicCurveArray)`

#### Summary

Converts a group of SymbolicCurves to equivalent ModelCurves.

#### Parameter `view`

The view where the new lines will be created.
The lines are projected on the view workplane.
The view workplane must be parallel to the view plane.

#### Parameter `symbolicCurve`

The symbolic curve array to be converted.

#### Exception `T:System.ArgumentNullException`

Thrown when the input argument is `null` .

#### Exception `T:System.InvalidOperationException`

Thrown when one or more curves could not be successfully converted.

#### Remarks

This operation will create new ModelCurves with the symbolicCurves' geometry curves and delete the SymbolicCurve in the array.

### `M:Autodesk.Revit.DB.Document.ConvertModelToSymbolicCurves(Autodesk.Revit.DB.View,Autodesk.Revit.DB.ModelCurveArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.ConvertModelToSymbolicCurves(Autodesk.Revit.DB.View,Autodesk.Revit.DB.ModelCurveArray)`

#### Summary

Converts a group of ModelCurves to equivalent SymbolicCurves.

#### Parameter `view`

The view where the new lines will be created.
The lines are projected on the view workplane.
The view workplane must be parallel to the view plane.
If the lines are not parallel to the view plane, lines are foreshortened and arcs are converted to ellipses.
Splines are modified.

#### Parameter `modelCurves`

The model curve array to be converted.

#### Exception `T:System.ArgumentNullException`

Thrown when the input argument is `null` .

#### Exception `T:System.ArgumentException`

Thrown when view is invalid to create SymbolicCurves on it.

#### Exception `T:System.InvalidOperationException`

Thrown when current document is a family.
Thrown when one or more curves could not be successfully converted, perhaps because some of the input curves could not be projected onto the active workplane of the view.

#### Remarks

This operation will create new SymbolicCurves with the modelCurves' geometry curves and delete the ModelCurve in the array.
If modelCurves are not parallel to the workplane, they will be projected to the workplane and create new SymbolicCurves with the projected curves.

### `M:Autodesk.Revit.DB.Document.ConvertDetailToModelCurves(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DetailCurveArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.ConvertDetailToModelCurves(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DetailCurveArray)`

#### Summary

Converts a group of DetailCurves to equivalent ModelCurves.

#### Parameter `view`

The view where the new lines will be created.
The lines are projected on the view workplane.
The view workplane must be parallel to the view plane.

#### Parameter `detailCurves`

The detail curve array to be converted.

#### Exception `T:System.ArgumentNullException`

Thrown when the input argument is `null` .

#### Exception `T:System.ArgumentException`

Thrown when the given detail lines are not visible in the given view.
Thrown when the detail lines are not in the same view or not parallel to the given view.

#### Exception `T:System.InvalidOperationException`

Thrown when one or more curves could not be successfully converted.

#### Remarks

This operation will create new ModelCurves with the same geometry of the original detail curves' geometry. The detail curves will be deleted from the document.

### `M:Autodesk.Revit.DB.Document.ConvertModelToDetailCurves(Autodesk.Revit.DB.View,Autodesk.Revit.DB.ModelCurveArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.ConvertModelToDetailCurves(Autodesk.Revit.DB.View,Autodesk.Revit.DB.ModelCurveArray)`

#### Summary

Converts a group of ModelCurves to equivalent DetailCurves.

#### Parameter `view`

The view where the new lines will be created.
The lines are projected on the view plane.
If the lines are not parallel to the view plane, lines are foreshortened and arcs are converted to ellipses.
Splines are modified.

#### Parameter `modelCurves`

The model curve array to be converted.

#### Exception `T:System.ArgumentNullException`

Thrown when the input argument is `null` .

#### Exception `T:System.ArgumentException`

Thrown when view is invalid to create DetailCurves on it.

#### Exception `T:System.InvalidOperationException`

Thrown when current document is a family.
Thrown when one or more curves could not be successfully converted, perhaps because some of the input curves could not be projected onto the active workplane of the view.

#### Remarks

This operation will create new DetailCurves with the same geometry of the original model curves' geometry. The model curves will be deleted from the document.
If the model curves do not lie in a plane parallel to the view, their geometry will be projected to the view.

### `P:Autodesk.Revit.DB.Document.Application`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.Application`

#### Summary

Returns the Application in which the Document resides.

### `M:Autodesk.Revit.DB.Document.SeparateElements(Autodesk.Revit.DB.CombinableElementArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.SeparateElements(Autodesk.Revit.DB.CombinableElementArray)`

#### Summary

Separate a set of combinable elements out of combinations they currently belong to.

#### Parameter `members`

A list of combinable elements to be separated.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when members is empty.
Thrown when members contains `null` elements.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when separation failed.

#### Remarks

If geometry combination elements are passed as input, they will be completely separated and deleted.
If generic forms that happen to belong to combination elements are passed, these forms will be removed from
their geometry combination. The handles of geometry combinations completely removed by this operation are no longer valid.

### `M:Autodesk.Revit.DB.Document.CombineElements(Autodesk.Revit.DB.CombinableElementArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.CombineElements(Autodesk.Revit.DB.CombinableElementArray)`

#### Summary

Combine a set of combinable elements into a geometry combination.

#### Parameter `members`

A list of combinable elements to be combined.

#### Returns

If successful, the newly created geometry combination is returned, otherwise an
exception with error information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when members contains less than two elements.
Thrown when members contains `null` elements.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when creation of the combination failed.

#### Remarks

If one or more existing geometry combinations are included as input, the return value may be one of those pre-existing
combinations. The rest of the pre-existing geometry combinations will be consumed into the new combination; those handles are no longer valid.

### `P:Autodesk.Revit.DB.Document.OwnerFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.OwnerFamily`

#### Summary

Get the Family of this Family Document.

#### Return

The owner family of this document.

#### Remarks

Only available if the current document is family document.

### `P:Autodesk.Revit.DB.Document.IsFamilyDocument`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.IsFamilyDocument`

#### Summary

Identifies if the current document is a family document.

### `M:Autodesk.Revit.DB.Document.GetSpaceAtPoint(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetSpaceAtPoint(Autodesk.Revit.DB.XYZ)`

#### Summary

Gets a space containing the point.

#### Parameter `point`

Point to be checked.

#### Returns

The space containing the point.

#### Remarks

Surveys only the spaces from the final phase of the project. The first one found will be returned. If there is no space containing the point, it returns `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the point is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the coordinates of the point are not number or are Double::MaxValue or Double::MinValue.

### `M:Autodesk.Revit.DB.Document.GetSpaceAtPoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Phase)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetSpaceAtPoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Phase)`

#### Overloads

Gets a space containing the point.

#### Summary

Gets a space containing the point.

#### Parameter `point`

Point to be checked.

#### Parameter `phase`

Phase in which the space exists.

#### Returns

The space containing the point.

#### Remarks

If phase is `null` , it will get the space of the last phase.The first one found will be returned. If there is no space containing the point, it returns `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the point is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the coordinates of the point are not number or are Double::MaxValue or Double::MinValue.

### `M:Autodesk.Revit.DB.Document.GetRoomAtPoint(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetRoomAtPoint(Autodesk.Revit.DB.XYZ)`

#### Summary

Gets a room containing the point.

#### Parameter `point`

Point to be checked.

#### Returns

The room containing the point.

#### Remarks

Surveys only the rooms from the final phase of the project. The first one found will be returned. If there is no room containing the point, it returns `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the point is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the coordinates of the point are not number or are Double::MaxValue or Double::MinValue.

### `M:Autodesk.Revit.DB.Document.GetRoomAtPoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Phase)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetRoomAtPoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Phase)`

#### Overloads

Gets a room containing the point.

#### Summary

Gets a room containing the point.

#### Parameter `point`

Point to be checked.

#### Parameter `phase`

Phase in which the room exists.

#### Returns

The room containing the point.

#### Remarks

If phase is `null` , it will get the room of the last phase.The first one found will be returned. If there is no room containing the point, it returns `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the point is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the coordinates of the point are not number or are Double::MaxValue or Double::MinValue.

### `M:Autodesk.Revit.DB.Document.GetPrintSettingIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetPrintSettingIds`

#### Summary

Retrieves all Print Settings of current project.

#### Returns

The ElementIds of all print setting elements

### `P:Autodesk.Revit.DB.Document.PrintManager`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.PrintManager`

#### Summary

Retrieve the PrintManager of current project.

### `P:Autodesk.Revit.DB.Document.SiteLocation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.SiteLocation`

#### Summary

Returns the site location information.

#### Remarks

The SiteLocation property returns an object that contains the site location
for the entire project.

### `P:Autodesk.Revit.DB.Document.ActiveProjectLocation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.ActiveProjectLocation`

#### Summary

Retrieve the active project location.

#### Remarks

Getting this property returns the currently active project location that
the user is currently working with. Setting this property can be used to change
the active project location.

### `P:Autodesk.Revit.DB.Document.ProjectLocations`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.ProjectLocations`

#### Summary

Retrieve all the project locations associated with this project

#### Remarks

This property returns all the locations of the project. A project can have one
site location but many project locations within that site. Each project location object
is an offset and rotation from the site location.

### `P:Autodesk.Revit.DB.Document.ActiveView`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.ActiveView`

#### Summary

The document's active view.

#### Value

The active view is the view that last had focus in the UI.
`null` if no view is considered active.

### `P:Autodesk.Revit.DB.Document.FamilyManager`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.FamilyManager`

#### Summary

The family manager object provides access to family types and parameters.

#### Remarks

This property is available when the document is a family document.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current document is project document.

### `P:Autodesk.Revit.DB.Document.FamilyCreate`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.FamilyCreate`

#### Summary

An object that can be used to create new instances of Autodesk Revit API elements
within a family document.

#### Value

This object is used to create new instances of family
elements within the Autodesk Revit API, such as Extrusion or Reference lines.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current document is project document.

### `P:Autodesk.Revit.DB.Document.Create`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.Create`

#### Summary

An object that can be used to create new instances of Autodesk Revit API elements
within a project.

#### Value

This object is used to create new instances of project
elements within the Autodesk Revit API, such as FamilyInstances or groups.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current document is family document.

### `M:Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.GBXMLImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Import(System.String,Autodesk.Revit.DB.GBXMLImportOptions)`

#### Summary

Imports a Green-Building XML file into the document.

#### Parameter `file`

Full path of the file to import. File must exist.

#### Parameter `options`

Various options applicable to GBXml import. If `null` , all options will be set to their respective default values.

#### Remarks

This method is available only in MEP.
Though the 'options' argument is not currently used, an object still must be provided (may be `null` ).
The method will return False if not succeed. e.g when the input xml file does not contain any result elements.

#### Returns

True if successful, otherwise False.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when file argument is `null` or empty.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

Thrown when the file specified does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when no file is specified or if the file is not a valid gbXML file or does not contain any result elements.

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.ViewSet,Autodesk.Revit.DB.FBXExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.ViewSet,Autodesk.Revit.DB.FBXExportOptions)`

#### Summary

Exports the document in 3D-Studio Max (FBX) format.

#### Parameter `folder`

Output folder, into which file(s) will be exported. The folder must exist.

#### Parameter `name`

Either the name of a single file or a prefix for a set of files.
If `null` or empty, automatic naming will be used.

#### Parameter `views`

Selection of views to be exported.Only 3D views are allowed.

#### Parameter `options`

Options applicable to the FBX format.

#### Remarks

Though the 'options' argument is not currently used,
an object still must be provided (may be `null` ).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input views is `null`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input views is an empty ViewSet.
Thrown if any view in the views is not a 3D view.

#### Returns

Function returns true only if all specified views are exported successfully.
The function returns False if exporting of any view fails, even if some views might have been exported successfully.

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.ViewSet,Autodesk.Revit.DB.DWFXExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.ViewSet,Autodesk.Revit.DB.DWFXExportOptions)`

#### Summary

Exports the current view or a selection of views in DWFX format.

#### Parameter `folder`

Output folder, into which file(s) will be exported. The folder must exist.

#### Parameter `name`

Either the name of a single file or a prefix for a set of files.
If `null` or empty, automatic naming will be used.

#### Parameter `views`

Selection of views to be exported.

#### Parameter `options`

Various options applicable to the DWFX format.
If `null` , all options will be set to their respective default values.

#### Returns

Function returns true only if all specified views are exported successfully.
The function returns False if exporting of any view fails, even if some views might have been exported successfully.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input views is `null`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input views is an empty ViewSet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current document is not modifiable.

#### Remarks

All the views must be printable in order for the Export to succeed.
It can be assured by checking the CanBePrinted property of each view.

### `M:Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.ViewSet,Autodesk.Revit.DB.DWFExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Export(System.String,System.String,Autodesk.Revit.DB.ViewSet,Autodesk.Revit.DB.DWFExportOptions)`

#### Summary

Exports the current view or a selection of views in DWF format.

#### Parameter `folder`

Output folder, into which file(s) will be exported. The folder must exist.

#### Parameter `name`

Either the name of a single file or a prefix for a set of files.
If `null` or empty, automatic naming will be used.

#### Parameter `views`

Selection of views to be exported.

#### Parameter `options`

Various options applicable to the DWF format.
If `null` , all options will be set to their respective default values.

#### Returns

Function returns true only if all specified views are exported successfully. Returns False if exporting of any view fails,
even if some views might have been exported successfully.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input views is `null`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input views is an empty ViewSet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current document is not modifiable.

#### Remarks

All the views must be printable in order for the Export to succeed.
It can be assured by checking the CanBePrinted property of each view.

### `M:Autodesk.Revit.DB.Document.Close`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Close`

#### Summary

Closes the document, save the changes if there are.

#### Returns

False if either closing procedure fails or if saving of a modified document failed.
Also returns False if closing is cancelled by an external application during 'DocumentClosing' event.
When function succeeds, True is returned.

#### Remarks

The currently active document may not be closed by this function. It can only be closed via Revit's UI.

The changes will saved automatically, the document will not be closed if failed to save changes.
If the document was created in this current session and has not been saved to a file yet, it needs to call Revit::UI::UIDocument::SaveAndClose() method instead.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when attempting to close the currently active document.
Thrown if there are any transactions, sub-transactions or transaction groups which
were opened by the API code, and not closed. All of these items must be handled
before attempting to close the document.
Thrown if the PathName is not set yet.
Thrown if the saving target file is read only.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if this a linked file.

### `M:Autodesk.Revit.DB.Document.Close(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Close(System.Boolean)`

#### Overloads

Closes the document.

#### Summary

Closes the document with the option to save.

#### Parameter `saveModified`

Indicates if the current document should be saved before close operation.

#### Returns

False if closing procedure fails or if saving of a modified document was requested (saveModified = True) but failed.
Also returns False if closing is cancelled by an external application during 'DocumentClosing' event.
When function succeeds, True is returned.

#### Remarks

The currently active document may not be closed by this function. It can only be closed via Revit's UI.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when attempting to close the currently active document.
Thrown if there are any transactions, sub-transactions or transaction groups which
were opened by the API code, and not closed. All of these items must be handled
before attempting to close the document.
Thrown if saveModified is 'true' and the PathName is not set yet.
Thrown if saveModified is 'true' and the saving target file is read only.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if this a linked file.

### `P:Autodesk.Revit.DB.Document.PlanTopologies(Autodesk.Revit.DB.Phase)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.PlanTopologies(Autodesk.Revit.DB.Phase)`

#### Summary

Gets the PlanTopologies of the current project in a given phase.

#### Parameter `phase`

The phase of the Plan Topology.

#### Remarks

Accessing plan topologies requires that document is modifiable as it will actually trigger calculating plan topologies if they have not been calculated yet.
The time necessary for the calculations may be significant and should be considered.

### `P:Autodesk.Revit.DB.Document.PlanTopologies`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.PlanTopologies`

#### Overloads

Gets the PlanTopologies of the current project.

#### Summary

Get the PlanTopologies of the current project in the last phase.

#### Remarks

Accessing plan topologies requires that document is modifiable as it will actually trigger calculating plan topologies if they have not been calculated yet.
The time necessary for the calculations may be significant and should be considered.

### `P:Autodesk.Revit.DB.Document.PlanTopology(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Phase)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.PlanTopology(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Phase)`

#### Summary

Get the PlanTopology of a given level in a given phase.

#### Parameter `level`

The level of the Plan Topology.

#### Parameter `phase`

The phase of the Plan Topology.

#### Remarks

Accessing plan topology requires that document is modifiable as it will actually trigger calculating plan topology if they have not been calculated yet.
The time necessary for the calculations may be significant and should be considered.

### `P:Autodesk.Revit.DB.Document.PlanTopology(Autodesk.Revit.DB.Level)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.PlanTopology(Autodesk.Revit.DB.Level)`

#### Overloads

Gets the PlanTopology of a given level.

#### Summary

Get the PlanTopology of a given level in the last phase.

#### Parameter `level`

The level of the Plan Topology.

#### Remarks

Accessing plan topology requires that document is modifiable as it will actually trigger calculating plan topology if they have not been calculated yet.
The time necessary for the calculations may be significant and should be considered.

### `M:Autodesk.Revit.DB.Document.Print(Autodesk.Revit.DB.ViewSet,Autodesk.Revit.DB.View,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Print(Autodesk.Revit.DB.ViewSet,Autodesk.Revit.DB.View,System.Boolean)`

#### Summary

Prints a set of views with a specified view template and default print settings.

#### Parameter `views`

The set of views which need to be printed.

#### Parameter `viewTemplate`

The view template which apply to the set of views.

#### Parameter `useCurrentPrintSettings`

If true, print the view with the current print setting,
otherwise with the print setting of the document of the view.

#### Remarks

If one view in the set can not be printed successfully then an exception will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when printing is not allowed in the current application mode.
Or when at least one view from the view set is not a printable view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the view set to be printed is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the view set contains a `null` element.

#### Exception `T:Autodesk.Revit.Exceptions.ApplicationException`

Thrown when at least one view from the view set could not be printed.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when print is cancelled by event handler.

### `M:Autodesk.Revit.DB.Document.Print(Autodesk.Revit.DB.ViewSet,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Print(Autodesk.Revit.DB.ViewSet,Autodesk.Revit.DB.View)`

#### Summary

Prints a set of views with a specified view template and default print settings.

#### Parameter `views`

The set of views which need to be printed.

#### Parameter `viewTemplate`

The view template which apply to the set of views.

#### Remarks

If one view in the set can not be printed successfully then an exception will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when printing is not allowed in the current application mode.
Or when at least one view from the view set is not a printable view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the view set to be printed is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the view set contains a `null` element.

#### Exception `T:Autodesk.Revit.Exceptions.ApplicationException`

Thrown when at least one view from the view set could not be printed.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when print is cancelled by event handler.

### `M:Autodesk.Revit.DB.Document.Print(Autodesk.Revit.DB.ViewSet,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Print(Autodesk.Revit.DB.ViewSet,System.Boolean)`

#### Summary

Prints a set of views with default view template and default print settings.

#### Parameter `views`

The set of views which need to be printed.

#### Parameter `useCurrentPrintSettings`

If true, print the view with the current print setting,
otherwise with the print setting of the document of the view.

#### Remarks

If one view in the set can not be printed successfully then an exception will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when printing is not allowed in the current application mode.
Or when at least one view from the view set is not a printable view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the view set to be printed is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the view set contains a `null` element.

#### Exception `T:Autodesk.Revit.Exceptions.ApplicationException`

Thrown when at least one view from the view set could not be printed.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when print is cancelled by event handler.

### `M:Autodesk.Revit.DB.Document.Print(Autodesk.Revit.DB.ViewSet)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Print(Autodesk.Revit.DB.ViewSet)`

#### Overloads

Prints a set of views.

#### Summary

Prints a set of views with default view template and default print settings.

#### Parameter `views`

The set of views which need to be printed.

#### Remarks

If one view in the set can not be printed successfully then an exception will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when printing is not allowed in the current application mode.
Or when at least one view from the view set is not a printable view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the view set to be printed is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the view set contains a `null` element.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when at least one view from the view set could not be printed.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when print is cancelled by event handler.

### `M:Autodesk.Revit.DB.Document.LoadFamilySymbol(System.String,System.String,Autodesk.Revit.DB.IFamilyLoadOptions,Autodesk.Revit.DB.FamilySymbol@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.LoadFamilySymbol(System.String,System.String,Autodesk.Revit.DB.IFamilyLoadOptions,Autodesk.Revit.DB.FamilySymbol@)`

#### Summary

Loads only the specified family type/symbol from a family file into the document and
provides a reference to the loaded family symbol.

#### Parameter `filename`

The fully qualified filename of the Family file, usually ending in .rfa.

#### Parameter `name`

The name of the type/symbol to be loaded, such as "W11x14".

#### Parameter `familyLoadOptions`

The interface implementation to use when loading a family into the document.

#### Parameter `symbol`

A reference to the family symbol that was loaded if successful, otherwise Nothing.

#### Returns

True if the family type/symbol was loaded successfully into the project, otherwise False.

#### Remarks

This function supports loading of types/symbols stored in the family, or those available in the family Type Catalog file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when filename or name is `null` or empty.

#### Since

2011

### `M:Autodesk.Revit.DB.Document.LoadFamilySymbol(System.String,System.String,Autodesk.Revit.DB.FamilySymbol@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.LoadFamilySymbol(System.String,System.String,Autodesk.Revit.DB.FamilySymbol@)`

#### Summary

Loads only the specified family type/symbol from a family file into the document and
provides a reference to the loaded family symbol.

#### Parameter `filename`

The fully qualified filename of the Family file, usually ending in .rfa.

#### Parameter `name`

The name of the type/symbol to be loaded, such as "W11x14".

#### Parameter `symbol`

A reference to the family symbol that was loaded if successful, otherwise `null` .

#### Returns

True if the family type/symbol was loaded successfully into the project, otherwise False.

#### Remarks

This function supports loading of types/symbols stored in the family, or those available in the family Type Catalog file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when filename or name is `null` or empty.

### `M:Autodesk.Revit.DB.Document.LoadFamilySymbol(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.LoadFamilySymbol(System.String,System.String)`

#### Overloads

Loads only a specified family type/symbol from a family file into the document.

#### Summary

Loads only a specified family type/symbol from a family file into the document.

#### Parameter `filename`

The fully qualified filename of the Family file, usually ending in .rfa.

#### Parameter `name`

The name of the type/symbol to be loaded, such as "W11x14".

#### Returns

True if the family type/symbol was loaded successfully into the project, otherwise False.

#### Remarks

This function supports loading of types/symbols stored in the family, or those available in the family Type Catalog file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when filename or name is `null` or empty.

### `M:Autodesk.Revit.DB.Document.EditFamily(Autodesk.Revit.DB.Family)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.EditFamily(Autodesk.Revit.DB.Family)`

#### Summary

Gets the document of a loaded family to edit.

#### Parameter `loadedFamily`

The loaded family in current document.

#### Returns

Reference of the document of the family.

#### Remarks

This creates an independent copy of the family for editing.
To apply the changes back to the family stored in the document, use the LoadFamily overload
accepting `T:Autodesk.Revit.DB.IFamilyLoadOptions` .

This method may not be called if the document is currently modifiable (has an open transaction)
or is in a read-only state. The method may not be called during dynamic updates. To test the
document's current status, check the values of IsModifiable and IsReadOnly properties.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"loadedFamily"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"loadedFamily"-is an in-place family or a non-editable family.
(This can be checked with the IsInPlace and IsEditable properties of the Family class.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family is already being edited.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if this method is called while the document is modifiable (i.e. it has an unfinished transaction.)

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if this method is currently in a read-only state.

### `M:Autodesk.Revit.DB.Document.LoadFamily(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.IFamilyLoadOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.LoadFamily(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.IFamilyLoadOptions)`

#### Summary

Loads the contents of this family document into another document.

#### Parameter `targetDocument`

The target document which the family will be loaded into.

#### Parameter `familyLoadOptions`

The interface implementation to use when responding to conflicts during the load operation.

#### Returns

Reference of the family in the target document.

#### Remarks

If you are reloading an edited family back into the source document from which it was extracted, use this overload.
This is because this overload allows you to respond to possible conflicts due to families already being present in the target document.
The Revit API offers one automatic overload: RevitUIFamilyLoadOptions, which will show the same prompts to the user as seen during an
interactive load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"targetDocument" or "familyLoadOptions"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current document is not a family document,
or when the target document is modifiable (e.g. there is an uncommitted transaction) or doesn't support load of this kind of families (e.g. loading a model family to detail family is disallowed),
or the load was cancelled due to a conflict and a False return from one of the interface methods,
or this document is currently in a read-only state.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

### `M:Autodesk.Revit.DB.Document.LoadFamily(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.LoadFamily(Autodesk.Revit.DB.Document)`

#### Summary

Loads the contents of this family document into another document.

#### Parameter `targetDocument`

The target document where the family will be loaded.

#### Returns

Reference of the family in the target document.

#### Remarks

If you are reloading an edited family back into the source document from which it was extracted, this method will always fail.
This is because this method automatically suppresses the prompts Revit typically uses to deal with conflicts between families, and
assumes that any such conflict should prevent the loading. If you want to be able to reload the same family into the source document,
you should use the LoadFamily() overload accepting `T:Autodesk.Revit.DB.IFamilyLoadOptions` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"targetDocument"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current document is not a family document,
or when the target document is modifiable (e.g. there is an uncommitted transaction) or doesn't support load of this kind of families (e.g. loading a model family to detail family is disallowed),
or when this family was found in the target document already and the conflict caused an automatic abort of the load operation,
or when a shared family in this family was found in the target document already
and the conflict caused an automatic abort of the load operation,
or this document is currently in a read-only state.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

### `M:Autodesk.Revit.DB.Document.LoadFamily(System.String,Autodesk.Revit.DB.IFamilyLoadOptions,Autodesk.Revit.DB.Family@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.LoadFamily(System.String,Autodesk.Revit.DB.IFamilyLoadOptions,Autodesk.Revit.DB.Family@)`

#### Summary

Loads an entire family and all its types/symbols into the document and provides a reference
to the loaded family.

#### Parameter `filename`

The fully qualified filename of the Family file, usually ending in .rfa.

#### Parameter `familyLoadOptions`

The interface implementation to use when loading a family into the document.

#### Parameter `family`

A reference to the family that was loaded if successful, otherwise Nothing.

#### Returns

True if the entire family was loaded successfully into the project, otherwise False.

#### Remarks

Loading an entire family may take a considerable amount of time and memory. It is
recommended that you use one of the LoadFamilySymbol() methods
and only load those symbols that you need.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when filename is `null` or empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument "familyLoadOptions" is `null` .

#### Since

2011

### `M:Autodesk.Revit.DB.Document.LoadFamily(System.String,Autodesk.Revit.DB.Family@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.LoadFamily(System.String,Autodesk.Revit.DB.Family@)`

#### Summary

Loads an entire family and all its types/symbols into the document and provides a reference
to the loaded family.

#### Parameter `filename`

The fully qualified filename of the Family file, usually ending in .rfa.

#### Parameter `family`

A reference to the family that was loaded if successful, otherwise `null` .

#### Returns

True if the entire family was loaded successfully into the project, otherwise False.

#### Remarks

Loading an entire family may take a considerable amount of time and memory. It is
recommended that you use one of the LoadFamilySymbol() methods
and only load those symbols that you need.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when filename is `null` or empty.

### `M:Autodesk.Revit.DB.Document.LoadFamily(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.LoadFamily(System.String)`

#### Overloads

Loads a family and all its types/symbols into the document.

#### Summary

Loads an entire family and all its types/symbols into the document.

#### Parameter `filename`

The fully qualified filename of the Family file, usually ending in .rfa.

#### Returns

True if the entire family was loaded successfully into the project, otherwise False.

#### Remarks

Loading an entire family may take a considerable amount of time and memory. It is
recommended that you use one of the LoadFamilySymbol() methods
and only load those symbols that you need.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when filename is `null` or empty.

### `P:Autodesk.Revit.DB.Document.ProjectInformation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.ProjectInformation`

#### Returns

Autodesk::Revit::DB::ProjectInfo

#### Summary

Return the Project Information of the current project.

### `P:Autodesk.Revit.DB.Document.ReactionsAreUpToDate`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.ReactionsAreUpToDate`

#### Summary

Reports if the analytical model has regenerated in a document with reaction loads.

#### Remarks

Revit sets this property to False after regeneration of the analytical model if the document contains loads that have isReaction=True.
This results in a user-visible warning that exists until there are no longer loads with isReaction=True.

### `P:Autodesk.Revit.DB.Document.Phases`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.Phases`

#### Summary

Retrieves all of the phases in the document.

#### Remarks

The phases are returned in order from earliest phase to latest phase.

When Revit is running with UI activated, the default created phase for newly created elements is inherited from the phase of the currently active view.

When Revit is running without its UI, such as when Revit runs on Autodesk Forge Design Automation API for Revit,
the default phase for newly created elements is the latest phase in the document.

### `P:Autodesk.Revit.DB.Document.PanelTypes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.PanelTypes`

#### Summary

Retrieves a set of PanelType objects that contains all the panel types that are currently loaded into the
project.

#### Remarks

This property returns a set of panelType objects. These objects can be used change the type of a panel from one type to another.

### `P:Autodesk.Revit.DB.Document.MullionTypes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.MullionTypes`

#### Summary

This property is used to retrieve all the mullion types in current system.

#### Remarks

This property returns a set of MullionType objects. These objects can be used change the type of a mullion from one type to another.

### `P:Autodesk.Revit.DB.Document.ParameterBindings`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.ParameterBindings`

#### Summary

Retrieves an object from which mappings between parameter definitions and categories can
be found.

#### Remarks

Returns a mapping between parameter definitions and parameter bindings. New bindings can
be added to the Revit Document by using this object.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When the document is a family document.

### `P:Autodesk.Revit.DB.Document.DisplayUnitSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.DisplayUnitSystem`

#### Summary

Provides access to display unit type with in the document.

#### Remarks

Return the display unit type, metric or imperial.

### `P:Autodesk.Revit.DB.Document.Settings`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.Settings`

#### Summary

Provides access to general application settings, such as Categories.

#### Remarks

Returns an object that provides access to various settings within Autodesk Revit.
The Settings property returns an object that provides access to the categories within the Autodesk
Revit project.

### `P:Autodesk.Revit.DB.Document.TypeOfStorage(Autodesk.Revit.DB.BuiltInParameter)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Document.TypeOfStorage(Autodesk.Revit.DB.BuiltInParameter)`

#### Summary

Get the storage type of the specified BuiltInParameter.

### `M:Autodesk.Revit.DB.Document.GetTypeOfStorage(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetTypeOfStorage(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Get the storage type of the identified built-in parameter.

#### Parameter `parameterTypeId`

Identifier of the built-in parameter.

#### Returns

Storage type of the built-in parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

parameterTypeId does not identify a built-in parameter. See Parameter.IsBuiltInParameter(ForgeTypeId) and Parameter.GetParameterTypeId(BuiltInParameter).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2022

### `M:Autodesk.Revit.DB.Document.GetHashCode`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.GetHashCode`

#### Summary

Gets the hash code of this document instance.

#### Remarks

The hash code is the same for document instances that represent the same document currently opened in the Revit session.
The hash code is generated when a Revit file is opened or created in session.
If the same Revit file is opened later (in the same session or a different session) the hash code will not be the same.

### `M:Autodesk.Revit.DB.Document.Equals(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Document.Equals(System.Object)`

#### Summary

Determines whether the specified `T:System.Object` equals to this `T:System.Object` .

#### Remarks

Two document instances are considered equal if they represent the same document currently opened in the Revit session.

### `T:Autodesk.Revit.DB.Document`

Member kind: type
Symbol: `Autodesk.Revit.DB.Document`

#### Summary

An object that represents an open Autodesk Revit project.

#### Remarks

The Document object represents an Autodesk Revit project. Revit can have multiple
projects open and multiple views to those projects. The active or top most view will be the
active project and hence the active document which is available from the Application object.

### `P:Autodesk.Revit.DB.FamilySymbolProfile.IsFlipped`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySymbolProfile.IsFlipped`

#### Summary

Indicates if the symbol profile is flipped or not.

### `P:Autodesk.Revit.DB.FamilySymbolProfile.Angle`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySymbolProfile.Angle`

#### Summary

The angle of the rotation of the profile in radians.

### `P:Autodesk.Revit.DB.FamilySymbolProfile.YOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySymbolProfile.YOffset`

#### Summary

The offset of the profile to the origin of the sketch plane in the Y direction.

### `P:Autodesk.Revit.DB.FamilySymbolProfile.XOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySymbolProfile.XOffset`

#### Summary

The offset of the profile to the origin of the sketch plane in the X direction.

### `P:Autodesk.Revit.DB.FamilySymbolProfile.Profile`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySymbolProfile.Profile`

#### Summary

Returns the family symbol of the profile.

#### Remarks

The symbol must of the category BuiltInCategory.OST_ProfileFamilies.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the category of argument is not BuiltInCategory.OST_ProfileFamilies.

### `T:Autodesk.Revit.DB.FamilySymbolProfile`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilySymbolProfile`

#### Summary

Represents a family symbol based profile for sweep or swept blend elements.

#### Remarks

Use objects of this type in methods as NewSweep() and NewSweptBlend() in `T:Autodesk.Revit.Creation.FamilyItemFactory`
to create the profile.

### `P:Autodesk.Revit.DB.CurveLoopsProfile.Profile`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveLoopsProfile.Profile`

#### Summary

Returns the curve loops of the profile.

#### Remarks

This property is used to retrieve the curve loops of profile.

### `T:Autodesk.Revit.DB.CurveLoopsProfile`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveLoopsProfile`

#### Summary

Represents a curve loop based profile for sweep or swept blend elements.

#### Remarks

Use objects of this type in methods as NewSweep() and NewSweptBlend() in `T:Autodesk.Revit.Creation.FamilyItemFactory`
to create the profile.

### `T:Autodesk.Revit.DB.SweepProfile`

Member kind: type
Symbol: `Autodesk.Revit.DB.SweepProfile`

#### Summary

Represents a profile for sweep or swept blend elements.

### `M:Autodesk.Revit.DB.PrintManager.Apply`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrintManager.Apply`

#### Summary

Apply the local print settings to global for all documents.

#### Remarks

This method will change the settings for the current printer to match what is set in the
Print Manager. When the user attempts to print with this printer in the future, the changes
made by the API session will be visible.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this operation is not allowed in the current application mode,
or the print resource is occupied by others.

### `M:Autodesk.Revit.DB.PrintManager.SubmitPrint(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrintManager.SubmitPrint(Autodesk.Revit.DB.View)`

#### Summary

Print a view with the current PrintManager settings.

#### Parameter `view`

The User-assigned view.

#### Returns

True if successful, otherwise False.

#### Remarks

PrintManager will apply the local settings to global and print the user-assigned view with the current settings.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this operation is not allowed in the current application mode,
or the print resource is occupied by others.

### `M:Autodesk.Revit.DB.PrintManager.SubmitPrint`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrintManager.SubmitPrint`

#### Overloads

Print with the current PrintManager settings.

#### Summary

Print the views and sheets defined in the current local PrintManager settings.

#### Returns

True if successful, otherwise False.

#### Remarks

PrintManager will apply the local settings to global and print the view/views/sheets which user defined with the current settings.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this operation is not allowed in the current application mode,
or the print resource is occupied by others.

### `M:Autodesk.Revit.DB.PrintManager.SelectNewPrintDriver(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrintManager.SelectNewPrintDriver(System.String)`

#### Summary

Select a new printer.

#### Parameter `strPrinterName`

The name string of new printer.

#### Remarks

This property is the global print setting property for all documents.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-strPrinterName-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the assigned new printer is invalid,
or the print resource is occupied by others.

### `P:Autodesk.Revit.DB.PrintManager.PaperSources`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintManager.PaperSources`

#### Summary

Get all print sources of current printer.

#### Remarks

These are the valid paper source for the current printer.

### `P:Autodesk.Revit.DB.PrintManager.PaperSizes`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintManager.PaperSizes`

#### Summary

Get all print sizes of current printer.

#### Remarks

These are the valid paper sizes for the current printer.

### `P:Autodesk.Revit.DB.PrintManager.IsVirtual`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintManager.IsVirtual`

#### Summary

The virtual type in Autodesk Revit.

### `P:Autodesk.Revit.DB.PrintManager.Collate`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintManager.Collate`

#### Summary

Indicates whether to collate of the current print.

#### Remarks

The value of this property represents the global print setting property used for print operations on any document.
In order to make a change to this property, after setting it call the Apply() method, or one of the SubmitPrint() methods, which
save the local changes as modifications to the global print settings.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when there is only one view or only one copy in the current settings.

### `P:Autodesk.Revit.DB.PrintManager.PrintOrderReverse`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintManager.PrintOrderReverse`

#### Summary

Indicates whether to reverse the print order of the current print.

#### Remarks

The value of this property represents the global print setting property used for print operations on any document.
In order to make a change to this property, after setting it call the Apply() method, or one of the SubmitPrint() methods, which
save the local changes as modifications to the global print settings.

### `P:Autodesk.Revit.DB.PrintManager.CopyNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintManager.CopyNumber`

#### Summary

The copy number.

#### Remarks

Returns 0 if current printer does not support CopyNumber property.
The value of this property represents the global print setting property used for print operations on any document.
In order to make a change to this property, after setting it call the Apply() method, or one of the SubmitPrint() methods, which
save the local changes as modifications to the global print settings.

### `P:Autodesk.Revit.DB.PrintManager.PrintRange`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintManager.PrintRange`

#### Summary

The print range.

#### Remarks

The value of this property represents the global print setting property used for print operations on any document.
In order to make a change to this property, after setting it call the Apply() method, or one of the SubmitPrint() methods, which
save the local changes as modifications to the global print settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the argument is out of range.

### `P:Autodesk.Revit.DB.PrintManager.PrintToFileName`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintManager.PrintToFileName`

#### Summary

The file name when printing to file.

#### Remarks

A default file name will be used when the PrintToFile is true and PrintToFileName is not be set.

The value of this property represents the global print setting property used for print operations on any document.
In order to make a change to this property, after setting it call the Apply() method, or one of the SubmitPrint() methods, which
save the local changes as modifications to the global print settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input file name is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input file name is an invalid string.

### `P:Autodesk.Revit.DB.PrintManager.CombinedFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintManager.CombinedFile`

#### Summary

Indicates whether to combine multiple selected views/sheets into a single file.

#### Remarks

The value of this property represents the global print setting property used for print operations on any document.
In order to make a change to this property, after setting it call the Apply() method, or one of the SubmitPrint() methods, which
save the local changes as modifications to the global print settings.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current printer is not a virtual printer.

### `P:Autodesk.Revit.DB.PrintManager.PrintToFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintManager.PrintToFile`

#### Summary

Indicates whether to print to file.

#### Remarks

The value of this property represents the global print setting property used for print operations on any document.
In order to make a change to this property, after setting it call the Apply() method, or one of the SubmitPrint() methods, which
save the local changes as modifications to the global print settings.

### `P:Autodesk.Revit.DB.PrintManager.ViewSheetSetting`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintManager.ViewSheetSetting`

#### Summary

The ViewSheetSetting which manages the view/sheet set information of current document, and you can change the default view/sheet
set for current project.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the print range is not selected views/sheets.

### `P:Autodesk.Revit.DB.PrintManager.PrintSetup`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintManager.PrintSetup`

#### Summary

The PrintSetup which manages the print settings of current document.

#### Remarks

PrintSetup is an interface cluster just like File->Print->Settings->Setup or File->Print Setup in UI.

### `P:Autodesk.Revit.DB.PrintManager.PrinterName`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintManager.PrinterName`

#### Summary

The name of the current printer.

### `T:Autodesk.Revit.DB.PrintManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.PrintManager`

#### Summary

The PrintManager object is used to configure the global print settings.

#### Remarks

Global print settings include PrintToFile, CombinedFile, PrintToFileName, PrintRange, CopyNumber, PrintOrderReverse, Collate.
Once PrintManager is acquired from a document, changes of its global print setting properties are not automatically
applied toward the global print setting. Should the local setting be used, the user needs to call the Apply method.
If the user calls SubmitPrint methods, not only that printing will use the current state of properties of the (local) print manager,
but the setting will also be applied to the global settings.

### `M:Autodesk.Revit.DB.PrintSetup.Revert`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrintSetup.Revert`

#### Summary

Revert the current print setting.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current print setting is In-Session.

### `M:Autodesk.Revit.DB.PrintSetup.Delete`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrintSetup.Delete`

#### Summary

Delete the current print setting, and make the In-Session setting as the current one.

#### Returns

False if Delete operation fails, otherwise true.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current print setting is In-Session.

### `M:Autodesk.Revit.DB.PrintSetup.Rename(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrintSetup.Rename(System.String)`

#### Summary

Rename the current print setting with the specified name.

#### Parameter `newName`

print setting name to be renamed as.

#### Returns

False if Rename operation fails, otherwise true.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the input newName already exists in current print setting list.

### `M:Autodesk.Revit.DB.PrintSetup.SaveAs(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrintSetup.SaveAs(System.String)`

#### Summary

Save the current print setting to another print setting with the specified name.

#### Parameter `newName`

print setting name to be saved as.

#### Returns

False if Save As operation fails, otherwise true.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the input newName already exists in current print setting list.

### `M:Autodesk.Revit.DB.PrintSetup.Save`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrintSetup.Save`

#### Summary

Save the changes for the current print setting.

#### Returns

False if save operation fails, otherwise True.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current print setting is In-Session
or the current print setting has not changed.

### `P:Autodesk.Revit.DB.PrintSetup.InSession`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintSetup.InSession`

#### Summary

The in-session Print Setting of Print Setup.

### `P:Autodesk.Revit.DB.PrintSetup.CurrentPrintSetting`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintSetup.CurrentPrintSetting`

#### Summary

The current Print Setting of Print Setup.

### `T:Autodesk.Revit.DB.PrintSetup`

Member kind: type
Symbol: `Autodesk.Revit.DB.PrintSetup`

#### Summary

Represents the Print Setup (Application Menu->Print->Print Setup) within Autodesk Revit.

#### Remarks

The Print Setup object can only get from PrintManager object.

### `P:Autodesk.Revit.DB.FamilyParameter.UserModifiable`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameter.UserModifiable`

#### Summary

Indicates whether the interactive user can modify the value of this parameter.

#### Since

2015

#### Remarks

Note that for shared parameters IsReadOnly can return false for shared parameters whose UserModifiable property is
also false, because the value of those parameters can be modified by the API. If a parameter is governed by a formula,
IsReadOnly would return true, even if the flag for UserModifiable was set to true when the shared parameter was created.

### `P:Autodesk.Revit.DB.FamilyParameter.IsReadOnly`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameter.IsReadOnly`

#### Summary

Identifies if the object is read-only or modifiable.

#### Value

If true, the object may not be modified. If false, the object's contents may be modified.

### `P:Autodesk.Revit.DB.FamilyParameter.IsShared`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameter.IsShared`

#### Summary

Identifies if the parameter is a shared parameter.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilyParameter.GUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameter.GUID`

#### Summary

The globally unique identifier

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the parameter is not a shared parameter.

#### Since

2012

### `P:Autodesk.Revit.DB.FamilyParameter.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameter.Id`

#### Summary

The id of the family parameter.

#### Since

2011

### `P:Autodesk.Revit.DB.FamilyParameter.AssociatedParameters`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameter.AssociatedParameters`

#### Summary

The parameters from elements in the family which are associated to this parameter.

### `M:Autodesk.Revit.DB.FamilyParameter.GetUnitTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyParameter.GetUnitTypeId`

#### Summary

Gets the identifier of the unit quantifying the parameter value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if this parameter is not of value type.

### `P:Autodesk.Revit.DB.FamilyParameter.Formula`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameter.Formula`

#### Summary

The formula.

#### Remarks

Returns `null` if there is no formula governing this parameter.

### `P:Autodesk.Revit.DB.FamilyParameter.CanAssignFormula`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameter.CanAssignFormula`

#### Summary

Indicates if this parameter can be assigned a formula.

### `P:Autodesk.Revit.DB.FamilyParameter.IsDeterminedByFormula`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameter.IsDeterminedByFormula`

#### Summary

Indicates if the parameter is determined by formula.

#### Remarks

The parameter is read only if it is determined by formula.

### `P:Autodesk.Revit.DB.FamilyParameter.IsReporting`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameter.IsReporting`

#### Summary

Indicates if the parameter is a reporting parameter.

#### Remarks

If true, the parameter is a reporting parameter associated to a dimension value,
and cannot be modified. If false, the parameter is a driving parameter and if associated
to a dimension, can modify the dimension it labels.

#### Since

2011

### `P:Autodesk.Revit.DB.FamilyParameter.IsInstance`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameter.IsInstance`

#### Summary

Indicates if the parameter is instance or type.

### `P:Autodesk.Revit.DB.FamilyParameter.StorageType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameter.StorageType`

#### Summary

The storage type describes the type that is used internally within the parameter to store its value.

#### Remarks

The property will return one of the following possibilities: String, Integer, Double
or ElementId. Based on the value of this property the correct access and set methods should be used
to retrieve and set the parameter's data value.

### `P:Autodesk.Revit.DB.FamilyParameter.Definition`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameter.Definition`

#### Summary

The definition.

### `T:Autodesk.Revit.DB.FamilyParameter`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyParameter`

#### Summary

The family parameter object.

### `T:Autodesk.Revit.DB.StorageType`

Member kind: type
Symbol: `Autodesk.Revit.DB.StorageType`

#### Summary

An enumerated type listing all of the internal parameter data storage types that Autodesk Revit supports.

### `F:Autodesk.Revit.DB.StorageType.ElementId`

Member kind: field
Symbol: `Autodesk.Revit.DB.StorageType.ElementId`

#### Summary

The data type represents an element and is stored as the id of the element.

### `F:Autodesk.Revit.DB.StorageType.String`

Member kind: field
Symbol: `Autodesk.Revit.DB.StorageType.String`

#### Summary

The internal data will be stored in the form of a string of characters.

### `F:Autodesk.Revit.DB.StorageType.Double`

Member kind: field
Symbol: `Autodesk.Revit.DB.StorageType.Double`

#### Summary

The data will be stored internally in the form of an 8 byte floating point number.

### `F:Autodesk.Revit.DB.StorageType.Integer`

Member kind: field
Symbol: `Autodesk.Revit.DB.StorageType.Integer`

#### Summary

The internal data is stored in the form of a signed 32 bit integer.

### `F:Autodesk.Revit.DB.StorageType.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.StorageType.None`

#### Summary

None represents an invalid storage type. This value should not be used.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewCurveByPoints(Autodesk.Revit.DB.ReferencePointArray)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewCurveByPoints(Autodesk.Revit.DB.ReferencePointArray)`

#### Summary

Create a 3d curve through two or more points in an Autodesk
Revit family document.

#### Returns

The newly created curve.

#### Parameter `points`

Two or more PointElements. The curve will interpolate
these points.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when points is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when points does not contain at least two PointElements.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family is not a Conceptual Mass Family.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewReferencePoint(Autodesk.Revit.DB.PointElementReference)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewReferencePoint(Autodesk.Revit.DB.PointElementReference)`

#### Summary

Create a reference point on an existing reference in an Autodesk
Revit family document.

#### Returns

The newly created ReferencePoint.

#### Remarks

The location and coordinate system of the point is
determined by the particular PointReference subclass, and
the point will remain constrained to that
reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family is not a Conceptual Mass Family.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewReferencePoint(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewReferencePoint(Autodesk.Revit.DB.Transform)`

#### Summary

Create a reference point at a given location and with a given
coordinate system in an Autodesk Revit family document.

#### Returns

The newly created ReferencePoint.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family is not a Conceptual Mass Family.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewReferencePoint(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewReferencePoint(Autodesk.Revit.DB.XYZ)`

#### Overloads

Creates a reference point.

#### Summary

Create a reference point at a given location in an Autodesk
Revit family document.

#### Returns

The newly created ReferencePoint.

#### Remarks

The ReferencePoint will have a default coordinate system
corresponding to the global coordinate system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family is not a Conceptual Mass Family.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewSymbolicCurve(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.SketchPlane)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewSymbolicCurve(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.SketchPlane)`

#### Summary

Create a symbolic curve in an Autodesk Revit family document.

#### Returns

The newly created symbolic curve.

#### Parameter `curve`

The geometry curve of the newly created symbolic curve.

#### Parameter `sketchPlane`

The sketch plane for the symbolic curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration failed.
Thrown when symbolic curve creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewControl(Autodesk.Revit.DB.ControlShape,Autodesk.Revit.DB.View,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewControl(Autodesk.Revit.DB.ControlShape,Autodesk.Revit.DB.View,Autodesk.Revit.DB.XYZ)`

#### Summary

Add a new control into the Autodesk Revit family document.

#### Returns

If successful, the newly created control is returned, otherwise an
exception with error information will be thrown.

#### Parameter `controlShape`

The shape of the control.

#### Parameter `view`

The view in which the control is to be visible. It
must be a FloorPlan view or a CeilingPlan view.

#### Parameter `origin`

The origin of the control.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"view" or "position"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"view"-is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument-"controlType"-is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when control creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewModelText(System.String,Autodesk.Revit.DB.ModelTextType,Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.HorizontalAlign,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewModelText(System.String,Autodesk.Revit.DB.ModelTextType,Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.HorizontalAlign,System.Double)`

#### Summary

Create a model text in the Autodesk Revit family document.

#### Returns

If successful, the newly created model text is returned, otherwise an
exception with error information will be thrown.

#### Parameter `text`

The text to be displayed.

#### Parameter `modelTextType`

The type of model text. If this parameter is `null` , the default type will be used.

#### Parameter `sketchPlane`

The sketch plane of the model text. The direction of model text is determined by the normal of the sketch plane.
To extrude in the other direction set the depth value to negative.

#### Parameter `position`

The position of the model text. The position must lie in the sketch plane.

#### Parameter `horizontalAlign`

The horizontal alignment.

#### Parameter `depth`

The depth of the model text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument text, sketchPlane or XYZ is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when input argument text is an empty string.
Thrown when input argument horizontalAlign or depth is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when model text creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewOpening(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.CurveArray)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewOpening(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.CurveArray)`

#### Summary

Create an opening to cut the wall or ceiling.

#### Returns

If successful, the newly created opening is returned, otherwise an
exception with error information will be thrown.

#### Parameter `host`

Host elements that new opening would lie in. The host can only be a wall or a ceiling.

#### Parameter `profile`

The profile of the newly created opening. This may contain more
than one curve loop. Each loop must be a fully closed curve loop and the loops may not
intersect. The profiles will be projected into the host plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument host or profile is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when host isn't a wall or a ceiling.
Thrown when profile doesn't contain any loops.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when opening creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewRadialDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.DimensionType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewRadialDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.DimensionType)`

#### Summary

Generate a new radial dimension object using a specified dimension type.

#### Parameter `view`

The view in which the dimension is to be visible.

#### Parameter `arcRef`

Geometric reference of the arc to which the dimension is to be bound.

#### Parameter `origin`

The point where the witness line of the radial dimension will lie.

#### Parameter `dimensionType`

The dimension style to be used for the dimension.

#### Returns

If creation was successful the new arc length dimension is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

The dimension will be created on default place.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when any input argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the argument arcRef/dimensionType is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewDiameterDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewDiameterDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

#### Overloads

Creates a new diameter dimension object.

#### Summary

Creates a new diameter dimension object using the default dimension type.

#### Parameter `view`

The view in which the dimension is to be visible.

#### Parameter `arcRef`

Geometric reference of the arc to which the dimension is to be bound.

#### Parameter `origin`

The point where the witness line of the diameter dimension will lie.

#### Returns

If creation was successful the new diameter dimension is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

The currently user set default style is used for the created dimension.

#### Remarks

The dimension will be created on default place.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when any input argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the argument arcRef is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewRadialDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewRadialDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

#### Overloads

Creates a new radial dimension object.

#### Summary

Creates a new radial dimension object using the default dimension type.

#### Parameter `view`

The view in which the dimension is to be visible.

#### Parameter `arcRef`

Geometric reference of the arc to which the dimension is to be bound.

#### Parameter `origin`

The point where the witness line of the radial dimension will lie.

#### Returns

If creation was successful the new arc length dimension is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

The currently user set default style is used for the created dimension.

#### Remarks

The dimension will be created on default place.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when any input argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the argument arcRef is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewArcLengthDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.DimensionType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewArcLengthDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.DimensionType)`

#### Summary

Creates a new arc length dimension object using the specified dimension type.

#### Parameter `view`

The view in which the dimension is to be visible.

#### Parameter `arc`

The extension arc of the dimension.

#### Parameter `arcRef`

Geometric reference of the arc to which the dimension is to be bound.
This reference must be parallel to the extension arc.

#### Parameter `firstRef`

The first geometric reference to which the dimension is to be bound.
This reference must intersect the arcRef reference.

#### Parameter `secondRef`

The second geometric reference to which the dimension is to be bound.
This reference must intersect the arcRef reference.

#### Parameter `dimensionType`

The dimension style to be used for the dimension.

#### Returns

If creation was successful the new arc length dimension is returned,
otherwise an exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when any input argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the argument arcRef/ref1/ref2/dimensionType is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewArcLengthDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewArcLengthDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference)`

#### Overloads

Creates a new arc length dimension object.

#### Summary

Creates a new arc length dimension object using the default dimension type.

#### Parameter `view`

The view in which the dimension is to be visible.

#### Parameter `arc`

The extension arc of the dimension.

#### Parameter `arcRef`

Geometric reference of the arc to which the dimension is to be bound.
This reference must be parallel to the extension arc.

#### Parameter `firstRef`

The first geometric reference to which the dimension is to be bound.
This reference must intersect the arcRef reference.

#### Parameter `secondRef`

The second geometric reference to which the dimension is to be bound.
This reference must intersect the arcRef reference.

#### Returns

If creation was successful the new arc length dimension is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

The currently user set default style is used for the created dimension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when any input argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the argument arcRef/ref1/ref2 is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewAngularDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.DimensionType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewAngularDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.DimensionType)`

#### Summary

Creates a new angular dimension object using the specified dimension type.

#### Parameter `view`

The view in which the dimension is to be visible.

#### Parameter `arc`

The extension arc of the dimension.

#### Parameter `firstRef`

The first geometric reference to which the dimension is to be bound.
The reference must be perpendicular to the extension arc.

#### Parameter `secondRef`

The second geometric reference to which the dimension is to be bound.
The reference must be perpendicular to the extension arc.

#### Parameter `dimensionType`

The dimension style to be used for the dimension.

#### Returns

If creation was successful the new angular dimension is returned,
otherwise an exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when any input argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the argument firstRef/secondRef/dimensionType is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewAngularDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewAngularDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Arc,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference)`

#### Overloads

Creates a new angular dimension object.

#### Summary

Creates a new angular dimension object using the default dimension type.

#### Parameter `view`

The view in which the dimension is to be visible.

#### Parameter `arc`

The extension arc of the dimension.

#### Parameter `firstRef`

The first geometric reference to which the dimension is to be bound.
The reference must be perpendicular to the extension arc.

#### Parameter `secondRef`

The second geometric reference to which the dimension is to be bound.
The reference must be perpendicular to the extension arc.

#### Returns

If creation was successful the new angular dimension is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

The currently user set default style is used for the created dimension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when any input argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the argument is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewLinearDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.DimensionType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewLinearDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.DimensionType)`

#### Summary

Creates a new linear dimension object using the specified dimension type.

#### Parameter `view`

The view in which the dimension is to be visible.

#### Parameter `line`

The extension line of the dimension.

#### Parameter `references`

An array of geometric references to which the dimension is to be bound.
You must supply at least two references, and all references supplied must be parallel to each other
and perpendicular to the extension line.

#### Parameter `dimensionType`

The dimension style to be used for the dimension.

#### Returns

If creation was successful the new linear dimension is returned,
otherwise an exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when any input argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the argument is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewLinearDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.ReferenceArray)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewLinearDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.ReferenceArray)`

#### Overloads

Creates a new linear dimension object.

#### Summary

Generate a new linear dimension object using the default dimension type.

#### Parameter `view`

The view in which the dimension is to be visible.

#### Parameter `line`

The extension line of the dimension.

#### Parameter `references`

An array of geometric references to which the dimension is to be bound.
You must supply at least two references, and all references supplied must be parallel to each other
and perpendicular to the extension line.

#### Returns

If creation was successful the new linear dimension is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

The currently user set default style is used for the created dimension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when any input argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the argument "references" is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewFormByThickenSingleSurface(System.Boolean,Autodesk.Revit.DB.Form,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewFormByThickenSingleSurface(System.Boolean,Autodesk.Revit.DB.Form,Autodesk.Revit.DB.XYZ)`

#### Summary

Create a new Form element by thickening a single-surface form, and add it into the Autodesk Revit family document.

#### Parameter `isSolid`

Indicates if the Form is Solid or Void.

#### Parameter `singleSurfaceForm`

The single-surface form element. It can have one top/bottom face or one side face.

#### Parameter `thickenDir`

The offset of capped solid.

#### Returns

This function will modify the input singleSurfaceForm and return the same element.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewFormByCap(System.Boolean,Autodesk.Revit.DB.ReferenceArray)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewFormByCap(System.Boolean,Autodesk.Revit.DB.ReferenceArray)`

#### Summary

Create new Form element by cap operation (to create a single-surface form), and add it into the Autodesk Revit family document.

#### Parameter `isSolid`

Indicates if the Form is Solid or Void.

#### Parameter `profile`

The profile of the newly created cap. It should consist of only one curve loop.

#### Returns

If creation was successful new form is returned.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewRevolveForms(System.Boolean,Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.Reference,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewRevolveForms(System.Boolean,Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.Reference,System.Double,System.Double)`

#### Summary

Create new Form elements by revolve operation, and add them into the Autodesk Revit family document.

#### Parameter `isSolid`

Indicates if the Form is Solid or Void.

#### Parameter `profile`

The profile of the newly created revolution. It should consist of only one curve loop.
The profile must be in the same plane as the axis.

#### Parameter `axis`

The axis of revolution. The axis is a line that must lie in the same plane as the curves in the profile.

#### Parameter `startAngle`

The start angle of Revolution in radians.

#### Parameter `endAngle`

The end angle of Revolution in radians.

#### Returns

If creation was successful new forms are returned.

#### Remarks

Typically this operation produces only a single form, but some combinations of arguments will create multiple forms from a single profile.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewSweptBlendForm(System.Boolean,Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.ReferenceArrayArray)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewSweptBlendForm(System.Boolean,Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.ReferenceArrayArray)`

#### Summary

Create new Form element by swept blend operation, and add it into the Autodesk Revit family document.

#### Parameter `isSolid`

Indicates if the Form is Solid or Void.

#### Parameter `path`

The path of the swept blend. The path should be 2D, where all input curves lie in one plane. If there's more than one profile, the path should be a single curve.
It's required to reference existing geometry.

#### Parameter `profiles`

The profile set of the newly created swept blend. Each profile should consist of only one curve loop.
Each profile must be in a plane that intersects with the path and is perpendicular to the path at the point of intersection.

#### Returns

If creation was successful new form is returned.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewExtrusionForm(System.Boolean,Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewExtrusionForm(System.Boolean,Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.XYZ)`

#### Summary

Create new Form element by Extrude operation, and add it into the Autodesk Revit family document.

#### Parameter `isSolid`

Indicates if the Form is Solid or Void.

#### Parameter `profile`

The profile of extrusion. It should consist of only one curve loop.

#### Parameter `direction`

The direction of extrusion, with its length the length of the extrusion. The direction must be perpendicular to the plane determined by profile. The length of vector must be non-zero.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when creation is attempted in Conceptual Mass, 2D, or other family where extrusions cannot be created.

#### Returns

If creation was successful new form is returned.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewLoftForm(System.Boolean,Autodesk.Revit.DB.ReferenceArrayArray)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewLoftForm(System.Boolean,Autodesk.Revit.DB.ReferenceArrayArray)`

#### Summary

Create new Form element by Loft operation, and add it into the Autodesk Revit family document.

#### Parameter `isSolid`

Indicates if the Form is Solid or Void.

#### Parameter `profiles`

The profile set of the newly created loft. Each profile should consist of only one curve loop.

#### Returns

If creation was successful form is are returned.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewSweptBlend(System.Boolean,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.SweepProfile,Autodesk.Revit.DB.SweepProfile)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewSweptBlend(System.Boolean,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.SweepProfile,Autodesk.Revit.DB.SweepProfile)`

#### Summary

Adds a new swept blend into the family document, using a selected reference as the path.

#### Parameter `isSolid`

Indicates if the swept blend is Solid or Void.

#### Parameter `path`

The path of the swept blend. The path might be a reference of single curve or edge obtained from existing geometry.
Or the path can be a single sketched curve, and the curve is not required to reference existing geometry.

#### Parameter `bottomProfile`

The bottom profile of the newly created Swept blend. It should consist of only one curve loop.
the input profile must be in one plane.

#### Parameter `topProfile`

The top profile of the newly created Swept blend. It should consist of only one curve loop.
The profile must lie in the XY plane, and it will be transformed to the profile plane automatically.

#### Returns

If creation was successful the new Swept blend is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This method creates a swept blend in a family document. The swept blend will trace from bottom profile
to the top along the path. Revit will determine an appropriate default mapping for the vertices of the
two profiles. If the input profile is to be a cyclic profile (curve or ellipse) it must be split into at
least two segments, so that Revit can find vertices to use for mapping the swept blend.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input arguments-path/bottomProfile/topProfile-are `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-bottomProfile/topProfile-is a curve based profile and the profile
is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-bottomProfile/topProfile-is a curve based profile and the profile
contains `null` or more than one curve loops.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-bottomProfile/topProfile-is a family symbol based profile and the
family symbol profile is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewSweptBlend(System.Boolean,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.SweepProfile,Autodesk.Revit.DB.SweepProfile)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewSweptBlend(System.Boolean,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.SweepProfile,Autodesk.Revit.DB.SweepProfile)`

#### Overloads

Adds a new swept blend into the family document.

#### Summary

Add a new swept blend into the family document, using a curve as the path.

#### Parameter `isSolid`

Indicates if the swept blend is Solid or Void.

#### Parameter `path`

The path of the swept blend. The path should be a single curve.
Or the path can be a single sketched curve, and the curve is not required to reference existing geometry.

#### Parameter `pathPlane`

The sketch plane for the path. Use this when you want to create
a 2D path that resides on an existing planar face. Optional, can be `null` for a path curve obtained from geometry or
for 2D paths where the path should not reference an existing edge.

#### Parameter `bottomProfile`

The bottom profile of the newly created Swept blend. It should consist of only one curve loop.
The profile must lie in the XY plane, and it will be transformed to the profile plane automatically.

#### Parameter `topProfile`

The top profile of the newly created Swept blend. It should consist of only one curve loop.
The profile must lie in the XY plane, and it will be transformed to the profile plane automatically.

#### Returns

If creation was successful the new Swept blend is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This method creates a swept blend in a family document. The swept blend will trace from bottom profile
to the top along the path. Revit will determine an appropriate default mapping for the vertices of the
two profiles. If the input profile is to be a cyclic profile (curve or ellipse) it must be split into at
least two segments, so that Revit can find vertices to use for mapping the swept blend.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input arguments-path/bottomProfile/topProfile-are `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-bottomProfile/topProfile-is a curve based profile and the profile
is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-bottomProfile/topProfile-is a curve based profile and the profile
contains `null` or more than one curve loops.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-bottomProfile/topProfile-is a family symbol based profile and the
family symbol profile is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when creation is attempted in Conceptual Mass, 2D, or other family where swept blends cannot be created.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewSweep(System.Boolean,Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.SweepProfile,System.Int32,Autodesk.Revit.DB.ProfilePlaneLocation)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewSweep(System.Boolean,Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.SweepProfile,System.Int32,Autodesk.Revit.DB.ProfilePlaneLocation)`

#### Summary

Adds a new sweep form into the family document, using an array of selected references as a 3D path.

#### Parameter `isSolid`

Indicates if the Sweep is Solid or Void.

#### Parameter `path`

The path of the sweep. The path should be reference of curve or edge obtained from existing geometry.

#### Parameter `profile`

The profile to create the new Sweep. The profile must lie in the XY plane, and it will be
transformed to the profile plane automatically. This may contain more than one curve loop or a profile family.
Each loop must be a fully closed curve loop and the loops must not intersect.
The loop can be a unbound circle or ellipse, but its geometry will be split in two in
order to satisfy requirements for sketches used in extrusions.

#### Parameter `profileLocationCurveIndex`

The index of the path curves. The curve upon which the profile
plane will be determined.

#### Parameter `profilePlaneLocation`

The location on the profileLocationCurve where the profile
plane will be determined.

#### Returns

If creation was successful the new Sweep is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This method creates a sweep in a family document. The sweep will trace the profile along the path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-path-is `null` or empty or an unsupported curve type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-profile-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument-profileLocationCurveIndex-is out of index bounds.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument-profilePlaneLocation-does not exist in the ProfilePlaneLocation enumeration.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewSweep(System.Boolean,Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.SweepProfile,System.Int32,Autodesk.Revit.DB.ProfilePlaneLocation)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewSweep(System.Boolean,Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.SweepProfile,System.Int32,Autodesk.Revit.DB.ProfilePlaneLocation)`

#### Overloads

Adds a new sweep form to the family document.

#### Summary

Adds a new sweep form to the family document, using a path of curve elements.

#### Parameter `isSolid`

Indicates if the Sweep is Solid or Void.

#### Parameter `path`

The path of the sweep. The path should be 2D, where all input curves lie in one plane, and the curves are not
required to reference existing geometry.

#### Parameter `pathPlane`

The sketch plane for the path. Use this when you want to create
a 2D path that resides on an existing planar face. Optional, can be `null` for 3D paths or
for 2D paths where the path should not reference an existing face.

#### Parameter `profile`

The profile of the newly created Sweep. This may contain
more than one curve loop or a profile family. The profile must lie in the XY plane, and it will be
transformed to the profile plane automatically. Each loop must be a fully closed curve loop and the loops
must not intersect.
The loop can be a unbound circle or ellipse, but its geometry will be split in two in
order to satisfy requirements for sketches used in extrusions.

#### Parameter `profileLocationCurveIndex`

The index of the path curves. The curve upon which the profile
plane will be determined.

#### Parameter `profilePlaneLocation`

The location on the profileLocationCurve where the profile
plane will be determined.

#### Returns

If creation was successful the new Sweep is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This method creates a sweep in a family document. The sweep will trace the profile along the path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-path-is `null` or empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-profile-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument-profileLocationCurveIndex-is out of index bounds.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument-profilePlaneLocation-does not exist in the ProfilePlaneLocation enumeration.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when creation is attempted in Conceptual Mass, 2D, or other family where sweeps cannot be created.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewRevolution(System.Boolean,Autodesk.Revit.DB.CurveArrArray,Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.Line,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewRevolution(System.Boolean,Autodesk.Revit.DB.CurveArrArray,Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.Line,System.Double,System.Double)`

#### Summary

Add a new Revolution instance into the Autodesk Revit family document.

#### Parameter `isSolid`

Indicates if the Revolution is Solid or Void.

#### Parameter `profile`

The profile of the newly created revolution. This may contain
more than one curve loop. Each loop must be a fully closed curve loop and the loops
must not intersect. All loops must lie in the same plane.
The loop can be a unbound circle or ellipse, but its geometry will be split in two in
order to satisfy requirements for sketches used in extrusions.

#### Parameter `sketchPlane`

The sketch plane for the revolution. The direction of revolution
is determined by the normal for the sketch plane.

#### Parameter `axis`

The axis of revolution. This axis must lie in the same plane as the curve loops.

#### Parameter `startAngle`

The start angle of Revolution in radians.

#### Parameter `endAngle`

The end angle of Revolution in radians.

#### Returns

If creation was successful the new revolution is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This method creates an Revolution in a family document. The Revolution will be
rotated the plane of the Revolution profile about the Axis.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-profile-is `null` or empty array.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-sketchPlane-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-sketchPlane-is an invalid sketch plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-axis-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when creation is attempted in Conceptual Mass, 2D, or other family where revolutions cannot be created.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewBlend(System.Boolean,Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.SketchPlane)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewBlend(System.Boolean,Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.SketchPlane)`

#### Summary

Add a new Blend instance into the Autodesk Revit family document.

#### Parameter `isSolid`

Indicates if the Blend is Solid or Void.

#### Parameter `profile1`

The first blend section. It should represent a single, planar curve loop.

#### Parameter `profile2`

The second blend section. It should represent a single, planar curve loop
lying in a plane parallel to that of the first blend section.

#### Parameter `sketchPlane`

The sketch plane for the first profile. Use this to associate the
"base" of the blend to geometry from another element. Optional, it can be `null` if you want Revit
to derive a new sketch plane from the geometry of the base profile.

#### Returns

If creation was successful the new blend is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This method creates a blend in a family document. Revit will determine an appropriate
default mapping for the vertices of the two profiles.
A profile loop cannot contain just one closed curve - in such a case, the curve must be
split into at least two segments, so that Revit can find vertices to use for mapping the blend.

Caution: several aspects of the Blend are not (easily) predictable from the input arguments.
For example, the Blend's TopOffset may be less than its BottomOffset in some cases,
depending on the orientations of the profile loops and the orientation of the sketch plane
(if a sketch plane is provided). Also, such orientations can affect whether the first or
second profile lies in the sketch plane (if a sketch plane is provided).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the argument is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when creation is attempted in Conceptual Mass, 2D, or other family where blends cannot be created.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `M:Autodesk.Revit.Creation.FamilyItemFactory.NewExtrusion(System.Boolean,Autodesk.Revit.DB.CurveArrArray,Autodesk.Revit.DB.SketchPlane,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory.NewExtrusion(System.Boolean,Autodesk.Revit.DB.CurveArrArray,Autodesk.Revit.DB.SketchPlane,System.Double)`

#### Summary

Add a new Extrusion instance into the Autodesk Revit family document.

#### Parameter `isSolid`

Indicates if the Extrusion is Solid or Void.

#### Parameter `profile`

The profile of the newly created Extrusion. This may contain more
than one curve loop. Each loop must be a fully closed curve loop and the loops may not
intersect. All input curves must lie in the same plane.
The loop can be a unbound circle or ellipse, but its geometry will be split in two in
order to satisfy requirements for sketches used in extrusions.

#### Parameter `sketchPlane`

The sketch plane for the extrusion. The direction of extrusion
is determined by the normal for the sketch plane. To extrude in the other direction set
the end value to negative.

#### Parameter `end`

The length of the extrusion.

#### Returns

If creation was successful the new Extrusion is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This method creates an extrusion in a family document. The extrusion will be
extended perpendicular to the sketch plane of the extrusion profile.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-profile-is `null` or empty array.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-sketchPlane-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-sketchPlane-is an invalid sketch plane.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the creation failed.

### `T:Autodesk.Revit.Creation.FamilyItemFactory`

Member kind: type
Symbol: `Autodesk.Revit.Creation.FamilyItemFactory`

#### Summary

The Family Item Factory object is used to create new instances of elements within the
Autodesk Revit Family.

#### Remarks

The Family Item Factory object is a utility object that is used to create new
instances of elements within the Autodesk Revit Family Document. This object should be used to
create elements instead of using New. This
object ensures that the elements created are added to the family document correctly.

### `P:Autodesk.Revit.DB.Sweep.MaxSegmentAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Sweep.MaxSegmentAngle`

#### Summary

The maximum segment angle of the sweep in radians.

#### Remarks

This property is used to retrieve/set the maximum segment angle of the sweep. It
is settable only when the trajectory segmentation is enabled.

### `P:Autodesk.Revit.DB.Sweep.IsTrajectorySegmentationEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Sweep.IsTrajectorySegmentationEnabled`

#### Summary

The trajectory segmentation option for the sweep.

#### Remarks

This property is used to retrieve/set the trajectory segmentation state of the sweep.
if return is true, means user can control the MaxSegmentAngle, otherwise is disable.

### `P:Autodesk.Revit.DB.Sweep.Path3d`

Member kind: property
Symbol: `Autodesk.Revit.DB.Sweep.Path3d`

#### Summary

The selected curves used for the sweep path.

#### Remarks

If the sweep is based on a sketched path, this property is `null` .

### `P:Autodesk.Revit.DB.Sweep.PathSketch`

Member kind: property
Symbol: `Autodesk.Revit.DB.Sweep.PathSketch`

#### Summary

The sketched path for the sweep.

#### Remarks

If the sweep is based on selected 3d curves, this property is `null` .

### `P:Autodesk.Revit.DB.Sweep.ProfileSymbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.Sweep.ProfileSymbol`

#### Summary

The family symbol profile details for the sweep.

#### Remarks

If the profile is not based on a profile family, this property is `null` .

### `P:Autodesk.Revit.DB.Sweep.ProfileSketch`

Member kind: property
Symbol: `Autodesk.Revit.DB.Sweep.ProfileSketch`

#### Summary

The profile sketch of the sweep.

#### Remarks

If the profile is not based on sketched curves, this property is `null` .

### `T:Autodesk.Revit.DB.Sweep`

Member kind: type
Symbol: `Autodesk.Revit.DB.Sweep`

#### Summary

A sweep solid or void form.

### `T:Autodesk.Revit.DB.ProfilePlaneLocation`

Member kind: type
Symbol: `Autodesk.Revit.DB.ProfilePlaneLocation`

#### Summary

Indicates the location of Sweep profile plane on the path curve.

#### Remarks

Use this enum in the NewSweep() method to create generic forms.

### `F:Autodesk.Revit.DB.ProfilePlaneLocation.End`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfilePlaneLocation.End`

#### Summary

Indicates the profile plane located at the End of the path curve.

### `F:Autodesk.Revit.DB.ProfilePlaneLocation.MidPoint`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfilePlaneLocation.MidPoint`

#### Summary

Indicates the profile plane located at the Middle point of the path curve.

### `F:Autodesk.Revit.DB.ProfilePlaneLocation.Start`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfilePlaneLocation.Start`

#### Summary

Indicates the profile plane located at the start of the path curve.

### `P:Autodesk.Revit.DB.GenericForm.Subcategory`

Member kind: property
Symbol: `Autodesk.Revit.DB.GenericForm.Subcategory`

#### Summary

The subcategory.

#### Remarks

The subcategory can be set to either the family category or one of its subcategories.

### `M:Autodesk.Revit.DB.GenericForm.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GenericForm.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

#### Summary

Sets the visibility for the generic form.

#### Remarks

The visibility of the generic form geometry can be changed for different
types of views and detail levels in the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when visibility is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration failed.

### `M:Autodesk.Revit.DB.GenericForm.GetVisibility`

Member kind: method
Symbol: `Autodesk.Revit.DB.GenericForm.GetVisibility`

#### Summary

Gets the visibility for the generic form.

#### Returns

A copy of visibility settings for the generic form.

### `P:Autodesk.Revit.DB.GenericForm.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.GenericForm.Name`

#### Summary

Get and Set the Name property

#### Remarks

The method set is override to forbid the user to change the Name. When the user tries
to call the method set for GenericForm object, an InvalidOperationException will be thrown.

### `P:Autodesk.Revit.DB.GenericForm.IsSolid`

Member kind: property
Symbol: `Autodesk.Revit.DB.GenericForm.IsSolid`

#### Summary

Identifies if the GenericForm is a solid or a void element.

#### Value

True if the form is a solid, false if the solid is a void element.

### `P:Autodesk.Revit.DB.GenericForm.Visible`

Member kind: property
Symbol: `Autodesk.Revit.DB.GenericForm.Visible`

#### Summary

The visibility of the GenericForm.

#### Value

True if the form is visible, false if it is hidden.

### `T:Autodesk.Revit.DB.GenericForm`

Member kind: type
Symbol: `Autodesk.Revit.DB.GenericForm`

#### Summary

Provides access to the Generic Form model in Autodesk Revit.

#### Remarks

The Generic Form object can be queried for a generic form for use in family modeling and
massing. It is the base class of Sweep, Blend, Extrusion, Revolution.

### `P:Autodesk.Revit.DB.CombinableElement.Combinations`

Member kind: property
Symbol: `Autodesk.Revit.DB.CombinableElement.Combinations`

#### Summary

The geometry combinations that this element belongs to.

#### Remarks

If this combinable element does not belong to any geometry combination,
this value is an empty collection. A solid combinable element may belong to at most
one combination, while a void combinable element may belong to multiple combinations.

### `T:Autodesk.Revit.DB.CombinableElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.CombinableElement`

#### Summary

An element that can be added to a geometry combination.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewAlignment(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewAlignment(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference)`

#### Summary

Add a new locked alignment into the Autodesk Revit document.

#### Parameter `view`

The view that determines the orientation of the alignment.

#### Parameter `reference1`

The first reference.

#### Parameter `reference2`

The second reference.

#### Returns

If creation was successful the new locked alignment dimension is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

These two references must be one of the following combinations:
2 planar facesplanar face and reference plane2 linesline and pointline and reference plane2 arcs2 cylindrical faces
These references must be already geometrically aligned (this function will
not force them to become aligned).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"view" or "headerReference" or "otherReference"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"headerReference" or "otherReference"-is invalid.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.PlaceGroup(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.GroupType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.PlaceGroup(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.GroupType)`

#### Summary

Place an instance of a Model Group into the Autodesk Revit document, using a location
and a group type.

#### Parameter `location`

The physical location where the group is to be placed.

#### Parameter `groupType`

A GroupType object that represents the type of group that is to be placed.

#### Returns

If creation was successful then an instance to the new group is returned, otherwise `null` .

#### Remarks

This method is used to place a new instance of an existing group type within the document.
The group's origin will placed at the point specified by the location. All group types within the
document can be found by iterating over the document and looking for elements of type
`T:Autodesk.Revit.DB.GroupType` .

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewReferencePlane2(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewReferencePlane2(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.View)`

#### Summary

Creates a new instance of ReferencePlane.

#### Parameter `bubbleEnd`

The bubble end applied to reference plane.

#### Parameter `freeEnd`

The free end applied to reference plane.

#### Parameter `thirdPnt`

A third point needed to define the reference plane.

#### Parameter `pView`

The specific view apply to the Reference plane.

#### Returns

The newly created reference plane.

#### Remarks

The specific view is applied to the Reference plane only for certain view types:
`F:Autodesk.Revit.DB.ViewType.Legend` `F:Autodesk.Revit.DB.ViewType.DraftingView` `F:Autodesk.Revit.DB.ViewType.DrawingSheet`

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewReferencePlane(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewReferencePlane(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.View)`

#### Summary

Creates a new instance of ReferencePlane.

#### Parameter `bubbleEnd`

The bubble end applied to reference plane.

#### Parameter `freeEnd`

The free end applied to reference plane.

#### Parameter `cutVec`

The cut vector apply to reference plane, should perpendicular
to the vector (bubbleEnd-freeEnd).

#### Parameter `pView`

The specific view apply to the Reference plane.

#### Returns

The newly created reference plane.

#### Remarks

The specific view is applied to the Reference plane only for certain view types:
`F:Autodesk.Revit.DB.ViewType.Legend` `F:Autodesk.Revit.DB.ViewType.DraftingView` `F:Autodesk.Revit.DB.ViewType.DrawingSheet`

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewModelCurveArray(Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.SketchPlane)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewModelCurveArray(Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.SketchPlane)`

#### Summary

Creates an array of new model line elements.

#### Parameter `geometryCurveArray`

An array containing the internal geometry curves for model lines.

#### Returns

If successful an array of new model line elements. Otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when curve is not in the plane

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewModelCurve(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.SketchPlane)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewModelCurve(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.SketchPlane)`

#### Summary

Creates a new model line element.

#### Parameter `geometryCurve`

The internal geometry curve for model line.

#### Parameter `sketchPlane`

The sketch plane this new model line resides in.

#### Returns

If successful a new model line element. Otherwise `null` .

#### Remarks

Different type of model curve element will be returned according to the type of geometry curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when curve is not in the plane

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewGroup(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewGroup(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Creates a new type of group.

#### Parameter `elementIds`

A set of elements which will be made into the new group.

#### Returns

A new instance of a group containing the elements specified.

#### Remarks

The new group may contain more members than just the set input to this method. Elements
which are closely connected with the inputs (such as sketch and sketch plane) will also be added to
the group.

Initially the group will have a generic name, such as Group 1. This can be changed by
changing the name of the group type as follows: `newGroup.GroupType.Name = newName` .

If a newly-created element is being added to a group, calling document.Regenerate() may be needed to avoid
a warning visible in the UI that the group has changed outside group edit mode.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstances2(System.Collections.Generic.List{Autodesk.Revit.Creation.FamilyInstanceCreationData})`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstances2(System.Collections.Generic.List{Autodesk.Revit.Creation.FamilyInstanceCreationData})`

#### Summary

Creates Family instances within the document.

#### Parameter `dataList`

A list of FamilyInstanceCreationData which wraps the creation arguments of the families to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

If FamilyInstanceCreationData's 'curve' or 'symbol' member is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If regeneration fails at the end of the batch creation.

#### Returns

If the creation is successful, a set of ElementIds which contains the Family instances should be returned, otherwise the exception will be thrown.

#### Remarks

Note: ForbiddenForDynamicUpdateException might be thrown during a dynamic update if the inserted instance establishes a mutual dependency with another structure.

Note: if the created family instance includes nested instances, the API framework will automatically regenerate
the document during this method call.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.Line,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.Line,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.View)`

#### Summary

Add a line based detail family instance into the Autodesk Revit document,
using an line and a view where the instance should be placed.

#### Parameter `line`

The line location of family instance. The line must in the plane of the view.

#### Parameter `symbol`

A family symbol object that represents the type of the instance that is to be inserted.

#### Parameter `specView`

A 2D view in which to display the family instance.

#### Remarks

This overload applies only to 2D family line based detail symbols.
The type/symbol that is used must be loaded into the document before this method is called.
Families and their symbols can be loaded using the Document.LoadFamily
or Document.LoadFamilySymbol methods.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when input argument line or symbol or specView is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when input argument line or symbol or specView is invalid,
or cannot make such type in the specView,
or the line is not in the plane of specView.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when failed to create the instance.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when attempting to place a model-based family. Only 2D detail families can be placed in views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if The symbol is not active.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.View)`

#### Summary

Add a new family instance into the Autodesk Revit document,
using an origin and a view where the instance should be placed.

#### Parameter `origin`

The origin of family instance. If created on a `T:Autodesk.Revit.DB.ViewPlan` ,
the origin will be projected onto the `T:Autodesk.Revit.DB.ViewPlan` .

#### Parameter `symbol`

A family symbol object that represents the type of the instance that is to be inserted.

#### Parameter `specView`

The 2D view in which to place the family instance.

#### Returns

If creation was successful then an instance to the new object is returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

One or more required arguments was `null`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input family PlacementType was not ViewBased, the input view was not 2D,
Thrown if The symbol is not active.
or instances of the input FamilySymbol are not permitted on a view of this type.

#### Remarks

This overload applies only to 2D family symbols (detail components, annotation symbols, titleblocks, etc.).
The type/symbol that is used must be loaded into the document before this method is called.
Families and their symbols can be loaded using the Document.LoadFamily or Document.LoadFamilySymbol methods.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.FamilySymbol)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.FamilySymbol)`

#### Summary

Inserts a new instance of a family onto a face referenced by the input Reference instance,
using a line on that face for its position, and a type/symbol.

#### Parameter `reference`

A reference to a face.

#### Parameter `position`

A line on the face defining where the symbol is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.
Note that this symbol must represent a family whose `P:Autodesk.Revit.DB.Family.FamilyPlacementType`
is WorkPlaneBased or CurveBased.

#### Returns

An instance of the new object if creation was successful, otherwise `null` .

#### Remarks

Use this method to insert one family instance on a face of another element,
using a line on the face to define the position and direction of the new symbol.

The type/symbol that is used must be loaded into the document before this method
is called. Families and their symbols can be loaded using the Document.LoadFamily or
Document.LoadFamilySymbol methods.

The host object must support insertion of instances, otherwise this method
will fail. If the instance fails to be created an exception may be thrown.

Note: if the created family instance includes nested instances, the API framework will automatically regenerate
the document during this method call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when a non-optional argument was null.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the function
cannot get a face from the reference, or, when the family
cannot be placed as line-based on an input face reference, because its FamilyPlacementType is not WorkPlaneBased or
CurveBased

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown when the family cannot be placed on
this line as it does not coincide with the input face.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when Revit is unable to place the family
instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if The symbol is not active.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol)`

#### Summary

Inserts a new instance of a family onto a face referenced by the input Reference instance,
using a location, reference direction, and a type/symbol.

#### Parameter `reference`

A reference to a face.

#### Parameter `location`

Point on the face where the instance is to be placed.

#### Parameter `referenceDirection`

A vector that defines the direction of the family instance.
Note that this direction defines the rotation of the instance on the face, and thus cannot be parallel
to the face normal.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.
Note that this symbol must represent a family whose `P:Autodesk.Revit.DB.Family.FamilyPlacementType`
is WorkPlaneBased.

#### Returns

An instance of the new object if creation was successful, otherwise `null` .

#### Remarks

Use this method to insert one family instance on a face of another element,
using a point on the face and a vector to define the position and direction of the new symbol.

The type/symbol that is used must be loaded into the document before this method is called.
Families and their symbols can be loaded using the Document.LoadFamily or
Document.LoadFamilySymbol methods.

The host object must support insertion of instances, otherwise this method
will fail. If the instances fails to be created an exception may be thrown.

Some Families, such as Beams, have more than one endpoint and are inserted
in the same manner as single point instances. Once inserted, these linear family instances
can have their endpoints changed by using the instance's Element.Location property.

Note: if the created family instance includes nested instances, the API framework will automatically regenerate
the document during this method call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when a non-optional argument was null.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the function cannot get the face from
the reference, or, when the Family cannot be placed as line-based on an input face reference, because its FamilyPlacementType
is not WorkPlaneBased

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown when reference direction is
parallel to face normal at insertion point.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when Revit is unable to place the family
instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if The symbol is not active.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.FamilySymbol)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.FamilySymbol)`

#### Summary

Inserts a new instance of a family onto a face of an existing element,
using a line on that face for its position, and a type/symbol.

#### Parameter `face`

A face of a geometry object.

#### Parameter `position`

A line on the face defining where the symbol is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.
Note that this symbol must represent a family whose `P:Autodesk.Revit.DB.Family.FamilyPlacementType`
is WorkPlaneBased or CurveBased.

#### Returns

An instance of the new object if creation was successful, otherwise `null` .

#### Remarks

Use this method to insert one family instance on a face of another element,
using a line on the face to define the position and direction of the new symbol.

The type/symbol that is used must be loaded into the document before this method
is called. Families and their symbols can be loaded using the Document.LoadFamily or
Document.LoadFamilySymbol methods.

The host object must support insertion of instances, otherwise this method
will fail. If the instance fails to be created an exception may be thrown.

Note: if the created family instance includes nested instances, the API framework will automatically regenerate
the document during this method call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when a non-optional argument was null.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the function cannot get the Reference
from the face, or, Family cannot be placed as line-based on an input face reference, because its FamilyPlacementType
is not WorkPlaneBased or CurveBased

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown when the family cannot be placed on
this line as it does not coincide with the input face.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when Revit is unable to place the family
instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if The symbol is not active.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol)`

#### Summary

Inserts a new instance of a family onto a face of an existing element,
using a location, reference direction, and a type/symbol.

#### Parameter `face`

A face of a geometry object.

#### Parameter `location`

Point on the face where the instance is to be placed.

#### Parameter `referenceDirection`

A vector that defines the direction of the family instance.
Note that this direction defines the rotation of the instance on the face, and thus cannot be parallel
to the face normal.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.
Note that this symbol must represent a family whose `P:Autodesk.Revit.DB.Family.FamilyPlacementType`
is WorkPlaneBased.

#### Returns

An instance of the new object if creation was successful, otherwise `null` .

#### Remarks

Use this method to insert one family instance on a face of another element,
using a point on the face and a vector to define the position and direction of the new symbol.

The type/symbol that is used must be loaded into the document before this method is called.
Families and their symbols can be loaded using the Document.LoadFamily or
Document.LoadFamilySymbol methods.

The host object must support insertion of instances, otherwise this method
will fail. If the instances fails to be created an exception may be thrown.

Some Families, such as Beams, have more than one endpoint and are inserted
in the same manner as single point instances. Once inserted, these linear family instances
can have their endpoints changed by using the instance's Element.Location property.

Note: if the created family instance includes nested instances, the API framework will automatically regenerate
the document during this method call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when a non-optional argument was null.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the function cannot get the Reference
from the face, or, when the Family cannot be placed as line-based on an input face reference, because its FamilyPlacementType
is not WorkPlaneBased

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown when reference direction is
parallel to face normal at insertion point.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when Revit is unable to place the family
instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if The symbol is not active.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Structure.StructuralType)`

#### Summary

Inserts a new instance of a family into the document, using a location and a
type/symbol.

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `structuralType`

If structural then specify the type of the component.

#### Returns

A valid instance of the given family if the creation is successful. An exception will be thrown otherwise.

#### Remarks

Use this method to insert a family instance that does not require a host element or level.
For creating instances of level-based families use one of the NewFamilyInstance methods of the Revit.Creation.Document class.

The type/symbol that is used must be loaded into the document before this method is called.
Families and their symbols can be loaded using the Document.LoadFamily or
Document.LoadFamilySymbol methods.

Some Families, such as Beams, have more than one endpoint
and are inserted in the same manner as single point instances. Once inserted these linear family
instances can have their endpoints changed by using the instance's Element.Location property.

Note: if the created family instance includes nested instances, the API framework will automatically regenerate
the document during this method call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the symbol is not active.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the family is level-based, for new instances of such families require a valid level to be supplied at the time of creation.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

#### Summary

Inserts a new instance of a family into the document,
using a location, type/symbol, and the level.

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `level`

The level onto which the FamilyInstance is to be placed.

#### Parameter `structuralType`

If structural then specify the type of the component.

#### Returns

If creation was successful then an instance to the new object is returned, otherwise `null` .

#### Remarks

This method is used to place a family instance onto a level. If the instance fails to be created an exception may be thrown.

The type/symbol that is used must be loaded into the document
before this method is called. Families and their symbols can be loaded using the Document.LoadFamily
or Document.LoadFamilySymbol methods.

Some Families, such as Beams, have more than one endpoint
and are inserted in the same manner as single point instances. Once inserted these linear family
instances can have their endpoints changed by using the instance's Element.Location property.

Note: ForbiddenForDynamicUpdateException might be thrown during a dynamic update if the inserted instance establishes a mutual dependency with another structure.

Note: if the created family instance includes nested instances, the API framework will automatically regenerate
the document during this method call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the family symbol does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the level does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if The symbol is not active.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)`

#### Summary

Inserts a new instance of a family into the document,
using a location, type/symbol, and the host element.

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `host`

The object into which the FamilyInstance is to be inserted, often known as the host.

#### Parameter `structuralType`

If structural then specify the type of the component.

#### Returns

If creation was successful then an instance to the new object is returned, otherwise `null` .

#### Remarks

This method is used to insert one family instance into another element, such as inserting a
window into a wall. If the instance fails to be created an exception may be thrown.

The type/symbol that is used must be loaded into the document
before this method is called. Families and their symbols can be loaded using the Document.LoadFamily
or Document.LoadFamilySymbol methods.

The host object must be one that supports insertion of
instances otherwise this method will fail.

Some Families, such as Beams, have more than one endpoint
and are inserted in the same manner as single point instances. Once inserted these linear family
instances can have their endpoints changed by using the instance's Element.Location property.

Note: ForbiddenForDynamicUpdateException might be thrown during a dynamic update if the inserted instance establishes a mutual dependency with another structure.

Note: if the created family instance includes nested instances, the API framework will automatically regenerate
the document during this method call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if The symbol is not active.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewFamilyInstance(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)`

#### Overloads

Inserts a new instance of a family into the document.

#### Summary

Inserts a new instance of a family into the document,
using a location, type/symbol, the host element and a reference direction.

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `referenceDirection`

A vector that dictates the direction of certain family instances.

#### Parameter `host`

A host object into which the instance will be embedded

#### Parameter `structuralType`

If structural then specify the type of the component.

#### Returns

If creation was successful then an instance to the new object is returned, otherwise `null` .

#### Remarks

This method allows you to create FamilyInstance objects that require both a location and direction.
If the instance fails to be created an exception may be thrown.

The type/symbol that is used must be loaded into the document
before this method is called. Families and their symbols can be loaded using the Document.LoadFamily
or Document.LoadFamilySymbol methods.

Some Families, such as Beams, have more than one endpoint and
are inserted in the same manner as single point instances. Once inserted these linear family instances
can have their endpoints changed by using the instance's Element.Location property.

Note: if the created family instance includes nested instances, the API framework will automatically regenerate
the document during this method call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if The symbol is not active.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.DimensionType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.DimensionType)`

#### Summary

Creates a new linear dimension object using the specified dimension style.

#### Parameter `view`

The view in which the dimension is to be visible.
The view must be `null` if the document is in `!:Autodesk::Revit::DB::SketchEditScope` .

#### Parameter `line`

The line drawn for the dimension.

#### Parameter `references`

An array of geometric references to which the dimension is to be bound.

#### Parameter `dimensionType`

The dimension style to be used for the dimension.

#### Returns

If successful a new dimension object, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when references are not geometric references.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.ReferenceArray)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewDimension(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.ReferenceArray)`

#### Overloads

Creates a new linear dimension object.

#### Summary

Creates a new linear dimension object using the default dimension style.

#### Parameter `view`

The view in which the dimension is to be visible.
The view must be `null` if the document is in `!:Autodesk::Revit::DB::SketchEditScope` .

#### Parameter `line`

The line drawn for the dimension.

#### Parameter `references`

An array of geometric references to which the dimension is to be bound.

#### Returns

If successful a new dimension object, otherwise `null` .

#### Remarks

The currently user set default style is used for the created dimension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when references are not geometric references.

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewDetailCurveArray(Autodesk.Revit.DB.View,Autodesk.Revit.DB.CurveArray)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewDetailCurveArray(Autodesk.Revit.DB.View,Autodesk.Revit.DB.CurveArray)`

#### Summary

Creates an array of new detail curve elements.

#### Parameter `view`

The view in which the detail curves are to be visible.

#### Parameter `geometryCurveArray`

An array containing the internal geometry curves for detail lines.
The curve in array should be bound curve.

#### Returns

If successful an array of new detail curve elements. Otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when curve is not in plane of the view

### `M:Autodesk.Revit.Creation.ItemFactoryBase.NewDetailCurve(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase.NewDetailCurve(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Curve)`

#### Summary

Creates a new detail curve element.

#### Parameter `view`

The view in which the detail curve is to be visible.

#### Parameter `geometryCurve`

The internal geometry curve for detail curve. It should be a bound curve.

#### Returns

If successful a new detail curve element. Otherwise `null` .

#### Remarks

Different type of detail curve element will be returned according to the type of geometry curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when curve is not in plane of the view

### `T:Autodesk.Revit.Creation.ItemFactoryBase`

Member kind: type
Symbol: `Autodesk.Revit.Creation.ItemFactoryBase`

#### Summary

The ItemFactoryBase object is used to create new instances of elements within the
Autodesk Revit document.

#### Remarks

The ItemFactoryBase object is a utility object that is used to create new
instances of elements within the Autodesk Revit document.
This class holds common methods used in both project documents and family documents.

### `T:Autodesk.Revit.DB.TextBaselineStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.TextBaselineStyle`

#### Since

2016

#### Summary

Supported styles of text position relative to the normal baseline.

#### Since

2016

### `F:Autodesk.Revit.DB.TextBaselineStyle.Superscript`

Member kind: field
Symbol: `Autodesk.Revit.DB.TextBaselineStyle.Superscript`

#### Summary

Indicates a superscript text.

### `F:Autodesk.Revit.DB.TextBaselineStyle.Subscript`

Member kind: field
Symbol: `Autodesk.Revit.DB.TextBaselineStyle.Subscript`

#### Summary

Indicates a subsript text.

### `F:Autodesk.Revit.DB.TextBaselineStyle.Normal`

Member kind: field
Symbol: `Autodesk.Revit.DB.TextBaselineStyle.Normal`

#### Summary

Indicates a normal text with letters positioned on the baseline.

### `T:Autodesk.Revit.DB.TextListStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.TextListStyle`

#### Since

2016

#### Summary

Supported styles of text list paragraphs.

#### Since

2016

### `F:Autodesk.Revit.DB.TextListStyle.NumberRomanUppercase`

Member kind: field
Symbol: `Autodesk.Revit.DB.TextListStyle.NumberRomanUppercase`

#### Summary

Indicates a list that uses uppercase Roman numbers.

### `F:Autodesk.Revit.DB.TextListStyle.NumberRomanLowercase`

Member kind: field
Symbol: `Autodesk.Revit.DB.TextListStyle.NumberRomanLowercase`

#### Summary

Indicates a list that uses lowercase Roman numbers.

### `F:Autodesk.Revit.DB.TextListStyle.LetterUppercase`

Member kind: field
Symbol: `Autodesk.Revit.DB.TextListStyle.LetterUppercase`

#### Summary

Indicates a list that uses uppercase letters.

### `F:Autodesk.Revit.DB.TextListStyle.LetterLowercase`

Member kind: field
Symbol: `Autodesk.Revit.DB.TextListStyle.LetterLowercase`

#### Summary

Indicates a list that uses lowercase letters.

### `F:Autodesk.Revit.DB.TextListStyle.NumberArabic`

Member kind: field
Symbol: `Autodesk.Revit.DB.TextListStyle.NumberArabic`

#### Summary

Indicates a list that uses arabic numbers.

### `F:Autodesk.Revit.DB.TextListStyle.Bullet`

Member kind: field
Symbol: `Autodesk.Revit.DB.TextListStyle.Bullet`

#### Summary

Indicates a list that uses standard bullets.

### `F:Autodesk.Revit.DB.TextListStyle.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.TextListStyle.None`

#### Summary

Indicates that the paragraph is not a list.

### `T:Autodesk.Revit.DB.LeaderAtachement`

Member kind: type
Symbol: `Autodesk.Revit.DB.LeaderAtachement`

#### Since

2016

#### Summary

Supported types of vertical attachments of a leader to a text note.

#### Since

2016

### `F:Autodesk.Revit.DB.LeaderAtachement.BottomLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.LeaderAtachement.BottomLine`

#### Summary

Leaders are attached at the position of the bottom (last) line of the text box,
and, unless the text's border is visible, the leader's shoulder line extends
all the way to the text, minus the current value of text border offset.

### `F:Autodesk.Revit.DB.LeaderAtachement.Midpoint`

Member kind: field
Symbol: `Autodesk.Revit.DB.LeaderAtachement.Midpoint`

#### Summary

Leaders are aligned vertically with the midpoint of the text box and their shoulder line
always ends at the box' border regardless of whether the border is visible on not.

### `F:Autodesk.Revit.DB.LeaderAtachement.TopLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.LeaderAtachement.TopLine`

#### Summary

Leaders are attached at the position of the top (first) line of the text box,
and, unless the text's border is visible, the leader's shoulder line extends
all the way to the text, minus the current value of text border offset.

### `T:Autodesk.Revit.DB.VerticalTextAlignment`

Member kind: type
Symbol: `Autodesk.Revit.DB.VerticalTextAlignment`

#### Since

2016

#### Summary

Supported types of vertical alignment of a text element.

#### Since

2016

### `F:Autodesk.Revit.DB.VerticalTextAlignment.Middle`

Member kind: field
Symbol: `Autodesk.Revit.DB.VerticalTextAlignment.Middle`

#### Summary

The horizontal center line of the text box remains in place as the height of the text changes.

### `F:Autodesk.Revit.DB.VerticalTextAlignment.Bottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.VerticalTextAlignment.Bottom`

#### Summary

Bottom of the text box remains in place as the height of the text changes.

### `F:Autodesk.Revit.DB.VerticalTextAlignment.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.VerticalTextAlignment.Top`

#### Summary

Top of the text box remains in place as the height of the text changes.

### `T:Autodesk.Revit.DB.HorizontalTextAlignment`

Member kind: type
Symbol: `Autodesk.Revit.DB.HorizontalTextAlignment`

#### Since

2016

#### Summary

Supported types of horizontal alignment of a text element and text justification within the text containing box.

#### Since

2016

### `F:Autodesk.Revit.DB.HorizontalTextAlignment.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.HorizontalTextAlignment.Center`

#### Summary

Text is Center justified inside the containing text box, and the center side of the text box remains in place as the width changes.

### `F:Autodesk.Revit.DB.HorizontalTextAlignment.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.HorizontalTextAlignment.Right`

#### Summary

Text is Right justified inside the containing text box, and the right side of the text box remains in place as the width changes.

### `F:Autodesk.Revit.DB.HorizontalTextAlignment.Left`

Member kind: field
Symbol: `Autodesk.Revit.DB.HorizontalTextAlignment.Left`

#### Summary

Text is Left justified inside the containing text box, and the left side of the text box remains in place as the width changes.
