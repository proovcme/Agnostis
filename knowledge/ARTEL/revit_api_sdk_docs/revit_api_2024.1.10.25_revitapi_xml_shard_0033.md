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
Shard: 33
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.FilterStringGreaterOrEqual.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterStringGreaterOrEqual.#ctor`

#### Summary

Constructs an instance of FilterStringGreaterOrEqual.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterStringGreaterOrEqual`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterStringGreaterOrEqual`

#### Summary

Tests whether string values from the document would sort after or match a certain string.

#### Remarks

All string comparisons in this class are performed in the case-insensitive manner.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterStringGreater.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterStringGreater.#ctor`

#### Summary

Constructs an instance of FilterStringGreater.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterStringGreater`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterStringGreater`

#### Summary

Tests whether string values from the document would sort after a certain string.

#### Remarks

All string comparisons in this class are performed in the case-insensitive manner.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterStringEquals.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterStringEquals.#ctor`

#### Summary

Constructs an instance of FilterStringEquals.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterStringEquals`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterStringEquals`

#### Summary

Tests whether string values from the document match a certain string.

#### Remarks

All string comparisons in this class are performed in the case-insensitive manner.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterStringContains.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterStringContains.#ctor`

#### Summary

Constructs an instance of FilterStringContains.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterStringContains`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterStringContains`

#### Summary

Tests whether string values from the document contain a certain string.

#### Remarks

All string comparisons in this class are performed in the case-insensitive manner.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterStringEndsWith.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterStringEndsWith.#ctor`

#### Summary

Constructs an instance of FilterStringEndsWith.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterStringEndsWith`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterStringEndsWith`

#### Summary

Tests whether string values from the document end with a certain string.

#### Remarks

All string comparisons in this class are performed in the case-insensitive manner.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterStringBeginsWith.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterStringBeginsWith.#ctor`

#### Summary

Constructs an instance of FilterStringBeginsWith.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterStringBeginsWith`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterStringBeginsWith`

#### Summary

Tests whether string values from the document begin with a certain string.

#### Remarks

All string comparisons in this class are performed in the case-insensitive manner.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterStringRuleEvaluator.Evaluate(System.String,System.String,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterStringRuleEvaluator.Evaluate(System.String,System.String,System.Boolean)`

#### Summary

Derived classes override this method to implement the test that determines
whether the two given string values satisfy the desired condition or not.

#### Remarks

The arguments may be thought of as the left and right operands of a
binary expression; for example, "a < b", "x >= 100", etc. The left
operand comes from an element in the Revit document (e.g., the value
of a parameter.) The right operand is supplied by the user when
creating the filter that contains the rule that uses this evaluator.

#### Parameter `lhs`

A value from an element in the document.

#### Parameter `rhs`

The user-supplied value against which values from the document are tested.

#### Parameter `caseSensitive`

If true, string comparisons are done case-sensitively.

#### Returns

True if the given arguments satisfy the condition, otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.FilterStringRuleEvaluator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilterStringRuleEvaluator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FilterStringRuleEvaluator`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterStringRuleEvaluator`

#### Summary

Base for all classes that compare string values from Revit to a user-supplied filter value

#### Since

2011

### `T:Autodesk.Revit.DB.FilterValueRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterValueRule`

#### Summary

A rule that filters on a particular value of an element.

#### Since

2011

### `P:Autodesk.Revit.DB.ParameterValueProvider.Parameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterValueProvider.Parameter`

#### Summary

The parameter used to provide a string, integer, double-precision, or ElementId
value on request for a given element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ParameterValueProvider.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterValueProvider.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs an instance of ParameterValueProvider.

#### Parameter `parameter`

The parameter used to provide a string, integer, and double-precision, or ElementId
value on request for a given element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.ParameterValueProvider`

Member kind: type
Symbol: `Autodesk.Revit.DB.ParameterValueProvider`

#### Summary

Gets the value of a parameter from any element passed to GetStringValue,
GetDoubleValue, GetIntegerValue, or GetElementIdValue.

#### Remarks

For any parameter, only one of isStringValueSupported, isDoubleValueSupported,
isIntegerValueSupported, isElementIdValueSupported will return true. No attempt
to convert between types is made. For example, calling GetStringValue, passing
the identifier of a numeric-typed parameter will give an empty string. No
exception will be thrown, and ParameterValueProvider will not attempt to convert
the numeric value to a string.

If an element doesn't have the requested parameter or the element's parameter doesn't have a valid value,
ParameterValueProvider will attempt to get the parameter value from the element's type -
see `M:Autodesk.Revit.DB.Element.GetTypeId` .

#### Since

2011

### `M:Autodesk.Revit.DB.FilterableValueProvider.GetAssociatedGlobalParameterValue(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterableValueProvider.GetAssociatedGlobalParameterValue(Autodesk.Revit.DB.Element)`

#### Summary

Gets a global parameter value associated with a parameter from the given element.

#### Parameter `element`

The element to query.

#### Returns

The associated global parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterableValueProvider.IsElementIdValueSupported(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterableValueProvider.IsElementIdValueSupported(Autodesk.Revit.DB.Element)`

#### Summary

Determines whether the provide can provide an ElementId value for the given element.

#### Parameter `element`

The element to query.

#### Returns

True if the provider can return an ElementId value for the given element, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterableValueProvider.GetElementIdValue(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterableValueProvider.GetElementIdValue(Autodesk.Revit.DB.Element)`

#### Summary

Gets an ElementId value from the given element.

#### Parameter `element`

The element to query.

#### Returns

The ElementId value from the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterableValueProvider.IsIntegerValueSupported(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterableValueProvider.IsIntegerValueSupported(Autodesk.Revit.DB.Element)`

#### Summary

Determines whether the provide can provide an integer value for the given element.

#### Parameter `element`

The element to query.

#### Returns

True if the provider can return an integer value for the given element, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterableValueProvider.GetIntegerValue(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterableValueProvider.GetIntegerValue(Autodesk.Revit.DB.Element)`

#### Summary

Gets an integer value from the given element.

#### Parameter `element`

The element to query.

#### Returns

The integer value from the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterableValueProvider.IsDoubleValueSupported(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterableValueProvider.IsDoubleValueSupported(Autodesk.Revit.DB.Element)`

#### Summary

Determines whether the provide can provide a double-precision numeric value for the given element.

#### Parameter `element`

The element to query.

#### Returns

True if the provider can return a double-precision numeric value for the given element, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterableValueProvider.GetDoubleValue(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterableValueProvider.GetDoubleValue(Autodesk.Revit.DB.Element)`

#### Summary

Gets a double-precision numeric value from the given element.

#### Parameter `element`

The element to query.

#### Returns

The double-precision numeric value from the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterableValueProvider.IsStringValueSupported(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterableValueProvider.IsStringValueSupported(Autodesk.Revit.DB.Element)`

#### Summary

Determines whether the provide can provide a string value for the given element.

#### Parameter `element`

The element to query.

#### Returns

True if the provider can return a string value for the given element, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterableValueProvider.GetStringValue(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterableValueProvider.GetStringValue(Autodesk.Revit.DB.Element)`

#### Summary

Gets a string value from the given element.

#### Parameter `element`

The element to query.

#### Returns

The string value from the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.FilterableValueProvider.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilterableValueProvider.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FilterableValueProvider`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterableValueProvider`

#### Summary

Defines the interface for classes that extract values from elements
in a Revit project for testing against filter rules.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterInverseRule.SetInnerRule(Autodesk.Revit.DB.FilterRule)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterInverseRule.SetInnerRule(Autodesk.Revit.DB.FilterRule)`

#### Summary

Gets the rule being inverted.

#### Parameter `innerRule`

The rule to invert.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterInverseRule.GetInnerRule`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterInverseRule.GetInnerRule`

#### Summary

Gets the rule being inverted.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterInverseRule.#ctor(Autodesk.Revit.DB.FilterRule)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterInverseRule.#ctor(Autodesk.Revit.DB.FilterRule)`

#### Summary

Constructs a new instance of FilterInverseRule.

#### Parameter `innerRule`

The rule to invert.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.FilterInverseRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterInverseRule`

#### Summary

A filter rule that inverts the boolean values returned by the rule it contains.

#### Remarks

FilterInverse rule performs a logical "not" operation on its inner rule's
"elementPasses()" method.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterRule.GetRuleParameter`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterRule.GetRuleParameter`

#### Summary

Returns the ElementId of the parameter associated to this FilterRule if there is one,
or invalidElementId if there is no associated parameter.

#### Returns

The parameter id if there is an associated parameter, or invalidElementId if not.

#### Since

2019

### `M:Autodesk.Revit.DB.FilterRule.ElementPasses(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterRule.ElementPasses(Autodesk.Revit.DB.Element)`

#### Summary

Derived classes override this method to implement the test that determines
whether the given element passes this rule or not.

#### Parameter `element`

The element to test against the rule.

#### Returns

True if the element satisfies the rule, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.FilterRule.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilterRule.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FilterRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterRule`

#### Summary

Defines a boolean operation that can be used to cull elements from a document.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterElement.IsNameUnique(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterElement.IsNameUnique(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Determines whether the given name could be applied to a new FilterElement,
or if it could not be applied because the name is already in use.

#### Parameter `aDocument`

The document in which the name is being tested for uniqueness.

#### Parameter `name`

The name tested for uniqueness.

#### Returns

Returns true if the name is unique, and false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterElement.IsNameUnique(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterElement.IsNameUnique(System.String)`

#### Summary

Determines whether a potential filter element name is unique.

#### Parameter `name`

The candidate name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.FilterElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterElement`

#### Summary

The base class for filter elements in the document.

#### Since

2011

### `M:Autodesk.Revit.DB.FilledRegionType.IsValidLineWeight(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegionType.IsValidLineWeight(System.Int32)`

#### Summary

Indicates whether the given line weight value is valid.

#### Parameter `lineWeight`

The line weight.

#### Returns

True if it is a valid line weight value, false otherwise.

#### Since

2013

### `M:Autodesk.Revit.DB.FilledRegionType.IsValidMasking(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegionType.IsValidMasking(System.Boolean)`

#### Summary

Check that in a family the FillRegionType is always masking.

#### Parameter `isMasking`

The isMasking value to check.

#### Returns

True if the IsMasking property can be set to the new value.

#### Since

2024

### `M:Autodesk.Revit.DB.FilledRegionType.IsValidFillPatternId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegionType.IsValidFillPatternId(Autodesk.Revit.DB.ElementId)`

#### Summary

Check if the id is a FillPatternElement or an invalidElementId

#### Parameter `patternId`

Element id of the FillPatternElement

#### Returns

True if the id is InvalidElementId, or if the element is a FillPatternElement.
False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.FilledRegionType.IsValidSolidFillPatternId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegionType.IsValidSolidFillPatternId(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the id is valid for a background pattern

#### Parameter `patternId`

Element id of the FillPatternElement

#### Returns

False if in a family and the id is a solid fill pattern and 'isMasking' is masking is false.
True otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.FilledRegionType.IsValidBackgroundPatternId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegionType.IsValidBackgroundPatternId(Autodesk.Revit.DB.ElementId)`

#### Summary

Check if the id is valid for a background pattern

#### Remarks

The FillPatternElement must be a 'Drafting' pattern.

#### Parameter `patternId`

Element id of the FillPatternElement

#### Returns

False if the FillPatternElement is a model pattern.
True otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.FilledRegionType.IsValidForegroundPatternId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegionType.IsValidForegroundPatternId(Autodesk.Revit.DB.ElementId)`

#### Summary

Check if the id is valid for a foreground pattern

#### Remarks

In a family the FillPatternElement must be a 'Drafting' pattern.

#### Parameter `patternId`

Element id of the FillPatternElement

#### Returns

False if in a family, and the id is a FillPatternElement that targets 'Drafting'.
True otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.FilledRegionType.BackgroundPatternColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilledRegionType.BackgroundPatternColor`

#### Summary

The background fill pattern color.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.FilledRegionType.ForegroundPatternColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilledRegionType.ForegroundPatternColor`

#### Summary

The foreground fill pattern color.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.FilledRegionType.LineWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilledRegionType.LineWeight`

#### Summary

The line weight of the fill pattern.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: lineWeight is not a valid line weight value (it must be within the range of 1-16).

#### Since

2013

### `P:Autodesk.Revit.DB.FilledRegionType.IsMasking`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilledRegionType.IsMasking`

#### Summary

If true then the FilledRegion will cover the lines and edges of objects behind it.
If false then lines and edges will remain visible.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: In a family a FilledRegionType with a solid fill pattern isMasking must always be true.

#### Since

2019

### `P:Autodesk.Revit.DB.FilledRegionType.BackgroundPatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilledRegionType.BackgroundPatternId`

#### Summary

The background fill pattern Id.

#### Remarks

The FillPattern used for a background pattern must have a 'Drafting' target.
This applies to both project and family elements.
In addition, when the FilledRegionAttributes element is in a family, the pattern
cannot be the solid fill pattern unless the 'IsMasking' property is set to true.
InvalidElementId is used when there is no background pattern

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The patternId must either be InvalidElementId or represent a valid FillPatternElement.
-or-
When setting this property: The patternId must be a 'Drafting' pattern.
-or-
When setting this property: In a family the patternId can not be a solid fill pattern if the 'IsMasking' property is false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.FilledRegionType.ForegroundPatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilledRegionType.ForegroundPatternId`

#### Summary

The foreground fill pattern Id.

#### Remarks

When the FilledRegionAttributes element is in a family then
the FillPattern used for a foreground pattern must have a 'Drafting' target.
In addition, when the FilledRegionAttributes element is in a family, the pattern
cannot be the solid fill pattern unless the 'IsMasking' property is set to true.
InvalidElementId is used when there is no foreground pattern

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The patternId must either be InvalidElementId or represent a valid FillPatternElement.
-or-
When setting this property: In a family the patternId must be a 'Drafting' pattern.
-or-
When setting this property: In a family the patternId can not be a solid fill pattern if the 'IsMasking' property is false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `T:Autodesk.Revit.DB.FilledRegionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilledRegionType`

#### Summary

A filled region attributes element.
Note, the forground pattern color is stored in the parent class

#### Since

2013

### `M:Autodesk.Revit.DB.FilledRegion.IsRegionCreationEnabledInView(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegion.IsRegionCreationEnabledInView(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Parameter `document`

The document.

#### Parameter `viewId`

The view Id.

#### Returns

True if region creation is enabled.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.FilledRegion.IsValidFilledRegionTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegion.IsValidFilledRegionTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Indicates whether the given Id is a valid filled region type Id.

#### Parameter `document`

The document.

#### Parameter `typeId`

The filled region type Id.

#### Returns

True if it is a valid filled region type Id, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.FilledRegion.IsValidLineStyleIdForFilledRegion(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegion.IsValidLineStyleIdForFilledRegion(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Indicates whether the given Id is a valid line style Id.

#### Parameter `document`

The document.

#### Parameter `lineStyleId`

The line style Id.

#### Returns

True if it is a valid line style Id, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.FilledRegion.GetValidLineStyleIdsForFilledRegion(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegion.GetValidLineStyleIdsForFilledRegion(Autodesk.Revit.DB.Document)`

#### Summary

Gets the line style Ids which are permitted to be assigned to a filled region.

#### Parameter `document`

The document.

#### Returns

The valid line style Ids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.FilledRegion.SetLineStyleId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegion.SetLineStyleId(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the line style Id for all boundaries.

#### Parameter `lineStyleId`

The line style Id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

lineStyleId is not a valid line style Id for a filled region.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.FilledRegion.GetBoundaries`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegion.GetBoundaries`

#### Summary

Gets the boundaries.

#### Returns

The filled region boundaries.

#### Since

2013

### `M:Autodesk.Revit.DB.FilledRegion.CreateMaskingRegion(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.SketchPlane,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegion.CreateMaskingRegion(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.SketchPlane,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Creates a masking region on a sketch plane in a 3d model family.

#### Remarks

If the sketch plane is currently in use, then a copy of the sketch plane will be created and used.
The sketch plane normal must be parallel to the model's X, Y or Z axis.
The sketch plane can be a planar face reference to model geometry.
The line style of the boundaries will be set to thin lines by default.

#### Parameter `document`

The family document in which to create the masking region.

#### Parameter `sketchPlane`

The sketch plane for use with the masking region.

#### Parameter `boundaries`

The masking region boundaries, which will be projected onto the sketch plane.

#### Returns

The new masking region.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document is not a 3d model family.
-or-
Filled regions can't be created in this document or view.
-or-
The sketch plane is not suitable for model elements.
-or-
The sketch plane normal is not parallel to the model's X, Y or Z axis.
-or-
The input curve loops cannot compose a valid boundary, that means:
the "curveLoops" collection is empty;
or some curve loops intersect with each other;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the sketch plane;
or input curves contain at least one helical curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.FilledRegion.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.SketchPlane,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegion.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.SketchPlane,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Creates a filled region on a sketch plane in a 3d model family.

#### Remarks

If the sketch plane is currently in use, then a copy of the sketch plane will be created and used.
The sketch plane normal must be parallel to the model's X, Y or Z axis.
The sketch plane can be a planar face reference to model geometry.
The line style of the boundaries will be set to thin lines by default.

#### Parameter `document`

The family document in which to create the filled region.

#### Parameter `typeId`

The filled region type Id.

#### Parameter `sketchPlane`

The sketch plane for use with the filled region.

#### Parameter `boundaries`

The filled region boundaries, which will be projected onto the sketch plane.

#### Returns

The new filled region.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document is not a 3d model family.
-or-
The Id typeId is invalid.
-or-
Filled regions can't be created in this document or view.
-or-
The sketch plane is not suitable for model elements.
-or-
The sketch plane normal is not parallel to the model's X, Y or Z axis.
-or-
The input curve loops cannot compose a valid boundary, that means:
the "curveLoops" collection is empty;
or some curve loops intersect with each other;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the sketch plane;
or input curves contain at least one helical curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.FilledRegion.CreateMaskingRegion(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegion.CreateMaskingRegion(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Creates a view-specific masking region from the given boundaries.

#### Remarks

View-specific masking regions can be created in models and 2d families.
The line style of the boundaries will be set to thin lines by default.

#### Parameter `document`

The document in which to create the masking region.

#### Parameter `viewId`

The view Id.

#### Parameter `boundaries`

The boundaries.

#### Returns

The newly created masking region.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document is a 3d model family.
-or-
Details can't be drawn in the view.
-or-
Masking regions and Filled regions can't be created in this document or view.
-or-
The input curve loops cannot compose a valid boundary, that means:
the "curveLoops" collection is empty;
or some curve loops intersect with each other;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the view's detail sketch plane;
or input curves contain at least one helical curve.
-or-
Thrown if the viewId is invalid, or the view does not support
the detail items creation, or if the boundaries are empty, open, or self-intersecting.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.FilledRegion.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilledRegion.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Creates a view-specific filled region from the given boundaries.

#### Remarks

View-specific filled regions can be created in models and 2d families.
The line style of the boundaries will be set to thin lines by default.

#### Parameter `document`

The document in which to create the filled region.

#### Parameter `typeId`

The filled region type Id.

#### Parameter `viewId`

The view Id.

#### Parameter `boundaries`

The boundaries.

#### Returns

The newly created filled region.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document is a 3d model family.
-or-
The Id typeId is invalid.
-or-
Details can't be drawn in the view.
-or-
Masking regions and Filled regions can't be created in this document or view.
-or-
The input curve loops cannot compose a valid boundary, that means:
the "curveLoops" collection is empty;
or some curve loops intersect with each other;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the view's detail sketch plane;
or input curves contain at least one helical curve.
-or-
Thrown if the viewId or typeId is invalid, or the view does not support
the detail items creation, or if the boundaries are empty, open, or self-intersecting.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.FilledRegion.IsMasking`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilledRegion.IsMasking`

#### Summary

Indicates whether this element is a 'Filled Region or a 'Masking Region'.

#### Since

2012

### `T:Autodesk.Revit.DB.FilledRegion`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilledRegion`

#### Summary

A filled region element.

#### Since

2012

### `M:Autodesk.Revit.DB.FillPatternElement.GetFillPatternElementByName(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FillPatternTarget,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPatternElement.GetFillPatternElementByName(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FillPatternTarget,System.String)`

#### Summary

Retrieves the FillPatternElement by its name.

#### Parameter `document`

The document in which to retrieve the FillPatternElement.

#### Parameter `target`

The FillPatternTarget of the FillPatternElement.

#### Parameter `name`

The name of the FillPatternElement.

#### Returns

The FillPatternElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

target must be Model or Drafting.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.FillPatternElement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FillPattern)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPatternElement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.FillPattern)`

#### Summary

Creates a new FillPatternElement.

#### Parameter `document`

The document in which to create the FillPatternElement.

#### Parameter `fillPattern`

The FillPattern associated to the newly created FillPatternElement.

#### Returns

The newly created FillPatternElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fillPattern does not have a valid Target.
-or-
fillPattern does not have a valid Name.
-or-
fillPattern is a solid fill pattern.
-or-
fillPattern contains FillGrids with a zero Offset.
-or-
The name of the fillPattern already exists.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.FillPatternElement.SetFillPattern(Autodesk.Revit.DB.FillPattern)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPatternElement.SetFillPattern(Autodesk.Revit.DB.FillPattern)`

#### Summary

Sets the FillPattern associated to this element.

#### Remarks

The data stored inside the input FillPattern will be copied into this element.
The input FillPattern itself will not be associated with the element.

#### Parameter `newFillPattern`

The new FillPattern object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

newFillPattern does not have a valid Target.
-or-
newFillPattern does not have a valid Name.
-or-
newFillPattern is a solid fill pattern.
-or-
newFillPattern contains FillGrids with a zero Offset.
-or-
The name of the newFillPattern already exists.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The element is the build-in solid fill pattern element and can not be modified.

#### Since

2012

### `M:Autodesk.Revit.DB.FillPatternElement.GetFillPattern`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPatternElement.GetFillPattern`

#### Summary

Gets the FillPattern associated to this element.

#### Returns

A copy of FillPattern object.

#### Since

2012

### `T:Autodesk.Revit.DB.FillPatternElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.FillPatternElement`

#### Summary

An element that represents a fill pattern.

#### Remarks

The FillPatternElement represents a fill pattern in a project.
It enables the user to retrieve, modify or create a fill pattern in a project.

#### Since

2012

### `M:Autodesk.Revit.DB.FillPattern.ExpandDots`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPattern.ExpandDots`

#### Summary

Corrects pattern dots to make them be drawn properly for Revit.

#### Returns

Indicates whether any dots were in fact expanded.

### `M:Autodesk.Revit.DB.FillPattern.IsEqual(Autodesk.Revit.DB.FillPattern)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPattern.IsEqual(Autodesk.Revit.DB.FillPattern)`

#### Summary

Check if the contents and the name of the fill pattern is the same as the name and contents of this fill pattern.

#### Parameter `other`

The fill pattern to be compared.

#### Returns

True for equal, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.FillPattern.SetFillGrids(System.Collections.Generic.IList{Autodesk.Revit.DB.FillGrid})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPattern.SetFillGrids(System.Collections.Generic.IList{Autodesk.Revit.DB.FillGrid})`

#### Summary

Set the fill grids in this fill pattern.

#### Parameter `fillGrids`

The fill grids to be used.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.FillPattern.GetFillGrids`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPattern.GetFillGrids`

#### Summary

Gets all fill grids in this fill pattern

#### Returns

The fill grids.

### `M:Autodesk.Revit.DB.FillPattern.SetFillGrid(System.Int32,Autodesk.Revit.DB.FillGrid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPattern.SetFillGrid(System.Int32,Autodesk.Revit.DB.FillGrid)`

#### Summary

Sets the fill grid.

#### Parameter `gridIdx`

The index of the fill grid.

#### Parameter `fillGrid`

The fill grid to be used.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.FillPattern.GetFillGrid(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPattern.GetFillGrid(System.Int32)`

#### Summary

Gets the specified fill grid.

#### Parameter `gridIdx`

The index of the fill grid.

#### Returns

The fill grid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The index of the FillGrid is not valid.

### `P:Autodesk.Revit.DB.FillPattern.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillPattern.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FillPattern.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillPattern.Name`

#### Summary

The name of the fill pattern.

#### Remarks

The name of solid fill patterns cannot be changed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.FillPattern.LinesPerLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillPattern.LinesPerLength`

#### Summary

Gets the number of solid lines that placed in unit length.

### `P:Autodesk.Revit.DB.FillPattern.StrokesPerArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillPattern.StrokesPerArea`

#### Summary

Gets the number of strokes that placed on unit area.

### `P:Autodesk.Revit.DB.FillPattern.LengthPerArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillPattern.LengthPerArea`

#### Summary

Gets length of all lines that placed on unit area.

### `P:Autodesk.Revit.DB.FillPattern.IsSolidFill`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillPattern.IsSolidFill`

#### Summary

Check if the fill pattern is a solid fill pattern.

### `P:Autodesk.Revit.DB.FillPattern.GridCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillPattern.GridCount`

#### Summary

Gets the count of the fill grids in this fill pattern.

### `P:Autodesk.Revit.DB.FillPattern.Target`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillPattern.Target`

#### Summary

Target of this fill pattern applied to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.FillPattern.HostOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillPattern.HostOrientation`

#### Summary

Orientation to host layer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.FillPattern.#ctor(System.String,Autodesk.Revit.DB.FillPatternTarget,Autodesk.Revit.DB.FillPatternHostOrientation,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPattern.#ctor(System.String,Autodesk.Revit.DB.FillPatternTarget,Autodesk.Revit.DB.FillPatternHostOrientation,System.Double,System.Double,System.Double)`

#### Summary

Creates a simple crosshatch fill pattern based on the given name, angle, spacing, FillPatternTarget and FillPatternHostOrientation.

#### Parameter `name`

The name.

#### Parameter `target`

The fill pattern target.

#### Parameter `orientation`

The fill pattern orientation.

#### Parameter `angle`

The angle.

#### Parameter `spacing1`

The spacing.

#### Parameter `spacing2`

The spacing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.FillPattern.#ctor(System.String,Autodesk.Revit.DB.FillPatternTarget,Autodesk.Revit.DB.FillPatternHostOrientation,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPattern.#ctor(System.String,Autodesk.Revit.DB.FillPatternTarget,Autodesk.Revit.DB.FillPatternHostOrientation,System.Double,System.Double)`

#### Summary

Creates a simple hatch fill pattern based on the given name, angle, spacing, FillPatternTarget and FillPatternHostOrientation.

#### Parameter `name`

The name.

#### Parameter `target`

The fill pattern target.

#### Parameter `orientation`

The fill pattern orientation.

#### Parameter `angle`

The angle.

#### Parameter `spacing1`

The spacing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.FillPattern.#ctor(System.String,Autodesk.Revit.DB.FillPatternTarget,Autodesk.Revit.DB.FillPatternHostOrientation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPattern.#ctor(System.String,Autodesk.Revit.DB.FillPatternTarget,Autodesk.Revit.DB.FillPatternHostOrientation)`

#### Summary

Creates a fill pattern based on the given name, FillPatternTarget and FillPatternHostOrientation.

#### Parameter `name`

The name.

#### Parameter `target`

The fill pattern target.

#### Parameter `orientation`

The fill pattern orientation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.FillPattern.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPattern.#ctor`

#### Summary

Creates a fill pattern with FillPatternHostOrientation::FPORIENTATION_TO_VIEW and FillPatternTarget::FPTARGET_NONE.

### `M:Autodesk.Revit.DB.FillPattern.#ctor(Autodesk.Revit.DB.FillPattern)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillPattern.#ctor(Autodesk.Revit.DB.FillPattern)`

#### Summary

Constructs a new copy of the input FillPattern object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.FillPattern`

Member kind: type
Symbol: `Autodesk.Revit.DB.FillPattern`

#### Summary

Represents a fill pattern object.

#### Remarks

Fill patterns control the appearance of surfaces that are cut or shown in projection.
A simple fill pattern consists of a series of parallel or orthogonal lines.
Note - Dots are coded as zero-length dashes in the fill pattern definition.
When the Revit graphic engine encounters a zero-length line it simply ignores it and doesn't draw anything.
So call ExpandDots() for the patterns you construct to convert dots to small dashes, so that the rendering of the FillPattern is correct.

### `M:Autodesk.Revit.DB.FillGrid.GetPointLineZone(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillGrid.GetPointLineZone(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV@)`

#### Summary

Gets the index of fill grid line and the point on the grid line nearest to the input point.

#### Parameter `point`

Input point.

#### Parameter `nearestPoint`

The point on the grid line nearest to the input point.

#### Returns

The index of fill grid line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.FillGrid.GetPointLineZone(Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillGrid.GetPointLineZone(Autodesk.Revit.DB.UV)`

#### Summary

Gets the index of fill grid line closest to the input 2d point.

#### Parameter `point`

Input point.

#### Returns

The index of fill grid line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.FillGrid.GetSegmentDirection`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillGrid.GetSegmentDirection`

#### Summary

Provides the segment direction.

#### Returns

The direction of segment.

#### Since

2012

### `M:Autodesk.Revit.DB.FillGrid.GetHatchingDirection`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillGrid.GetHatchingDirection`

#### Summary

Provides the hatching propagation. Hatching is inverted.

#### Returns

The direction of hatching.

#### Since

2012

### `M:Autodesk.Revit.DB.FillGrid.CalculateLinesPerLength`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillGrid.CalculateLinesPerLength`

#### Summary

Calculates the number of solid lines of the pattern per unit length.

#### Returns

The solid lines per length.

#### Since

2012

### `M:Autodesk.Revit.DB.FillGrid.CalculateStrokesPerArea`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillGrid.CalculateStrokesPerArea`

#### Summary

Calculates the number of the segments of the pattern per unit area.

#### Returns

The strokes per area.

#### Since

2012

### `M:Autodesk.Revit.DB.FillGrid.CalculateLengthPerArea`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillGrid.CalculateLengthPerArea`

#### Summary

Calculates length of the pattern per unit area.

#### Returns

The length per area.

#### Since

2012

### `M:Autodesk.Revit.DB.FillGrid.IsEqual(Autodesk.Revit.DB.FillGrid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillGrid.IsEqual(Autodesk.Revit.DB.FillGrid)`

#### Summary

Check if two fill grids are equal.

#### Parameter `other`

The fill grid to be compared.

#### Returns

True if the two fill grids are equal, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.FillGrid.SetSegments(System.Collections.Generic.IList{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillGrid.SetSegments(System.Collections.Generic.IList{System.Double})`

#### Summary

Sets the segments to the fill grid.

#### Parameter `segArr`

The segments to be used.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.FillGrid.GetSegments`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillGrid.GetSegments`

#### Summary

Gets the segments of the fill grid.

#### Returns

The segments.

#### Since

2012

### `P:Autodesk.Revit.DB.FillGrid.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillGrid.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FillGrid.Shift`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillGrid.Shift`

#### Summary

Gets and sets the shift of the fill grid.

#### Remarks

Shift moves the pattern of dashes and spaces along the length of each new parallel line.
Shift is ignored if the line is solid.

#### Value

The shift of the fill grid.

#### Since

2012

### `P:Autodesk.Revit.DB.FillGrid.Offset`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillGrid.Offset`

#### Summary

Gets and sets the offset of the fill grid.

#### Remarks

Offset defines the distance between parallel lines. A zero offset is not allowed.

#### Value

The offset of the fill grid.

#### Since

2012

### `P:Autodesk.Revit.DB.FillGrid.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillGrid.Origin`

#### Summary

Gets and sets the origin of the fill grid.

#### Value

The origin of the fill grid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.FillGrid.Angle`

Member kind: property
Symbol: `Autodesk.Revit.DB.FillGrid.Angle`

#### Summary

Gets and sets the angle of the fill grid.

#### Since

2012

### `M:Autodesk.Revit.DB.FillGrid.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillGrid.#ctor(System.Double,System.Double)`

#### Summary

Creates a simple fill grid with given angle and offset.

#### Parameter `angle`

The angle.

#### Parameter `offset`

The offset represents the spacing between the lines.

#### Since

2012

### `M:Autodesk.Revit.DB.FillGrid.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillGrid.#ctor`

#### Summary

Creates a simple fill grid.

#### Since

2012

### `M:Autodesk.Revit.DB.FillGrid.#ctor(Autodesk.Revit.DB.FillGrid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FillGrid.#ctor(Autodesk.Revit.DB.FillGrid)`

#### Summary

Constructs a new FillGrid with default settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.FillGrid`

Member kind: type
Symbol: `Autodesk.Revit.DB.FillGrid`

#### Summary

Represents a grid line in a fill pattern.

#### Remarks

A grid line is described in the two dimensions of a face as follows:
angle, origin, shift, offset, segments
Angle specifies the direction, in degrees, of the grid line relative to the x-axis.

Parallel lines are drawn as specified by Offset and Shift to fill the entire face.
Offset defines the distance between parallel lines. Zero Offset is not allowed.
Shift moves the pattern of dashes and spaces along the length of each new parallel line.
Shift is ignored if the line is solid.

The segments defines a repeating pattern of dashes and spaces for the grid line. If it is
omitted, the line is solid. Positive numbers define dashes, negative numbers define spaces, and
zero specifies a dot. If you begin a pattern with a space, do not alternate dashes and spaces,
or do not end with a space, Revit will introduce tiny dashes or spaces to compensate. Revit
expands dots and very short dashes into dashes of a minimum size.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.FieldValues.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.FieldValues.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.Analysis.FieldValues.#ctor(Autodesk.Revit.DB.Analysis.FieldValues)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.FieldValues.#ctor(Autodesk.Revit.DB.Analysis.FieldValues)`

#### Summary

Creates a copy of the given FieldValues instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.FieldValues.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.VectorAtPoint})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.FieldValues.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.VectorAtPoint})`

#### Summary

Creates object from an array of domain point vectors

#### Parameter `vectorAtPoint`

Array of vectors, each corresponding to a domain point

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Members of vectorAtPoint contain different numbers of measurements

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.FieldValues.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.ValueAtPoint},Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.FieldValues.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.ValueAtPoint},Autodesk.Revit.DB.XYZ)`

#### Summary

Creates object from an array of domain point values

#### Parameter `valueAtPoint`

Array of values, each corresponding to a domain point

#### Parameter `unitDirection`

Unit vector that gives the same direction for values (for diagrams)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Members of valueAtPoint contain different numbers of measurements
-or-
unitDirection is not a unit vector

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.FieldValues.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.ValueAtPoint})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.FieldValues.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.ValueAtPoint})`

#### Summary

Creates object from an array of domain point values

#### Parameter `valueAtPoint`

Array of values, each corresponding to a domain point

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

valueAtPoint array contains members with different numbers of measurements

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.FieldValues`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.FieldValues`

#### Summary

Contains values corresponding to domain points.
Each domain point may have an array of values, each corresponding to a separate "measurement" for which this value was calculated.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.VectorAtPoint.#ctor(Autodesk.Revit.DB.Analysis.VectorAtPoint)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.VectorAtPoint.#ctor(Autodesk.Revit.DB.Analysis.VectorAtPoint)`

#### Summary

Creates a copy of the given VectorAtPoint instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.VectorAtPoint.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.VectorAtPoint.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Creates object from an array of vectors

#### Parameter `vectors`

Array of vectors, each corresponding to "measurement"

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when supplied vectors contain invalid (infinite or non-number) coordinates

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.VectorAtPoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.VectorAtPoint`

#### Summary

Stores vectors at one domain point.
Each vector corresponds to a "measurement" for which this vector was calculated.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.ValueAtPoint.#ctor(Autodesk.Revit.DB.Analysis.ValueAtPoint)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ValueAtPoint.#ctor(Autodesk.Revit.DB.Analysis.ValueAtPoint)`

#### Summary

Creates a copy of the given ValueAtPoint instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.ValueAtPoint.#ctor(System.Collections.Generic.IList{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.ValueAtPoint.#ctor(System.Collections.Generic.IList{System.Double})`

#### Summary

Creates object from an array of values

#### Parameter `values`

Array of values, each corresponding to "measurement"

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when supplied values contain invalid (infinite or non-number) doubles

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.ValueAtPoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.ValueAtPoint`

#### Summary

Stores values at one domain point.
Each value corresponds to a "measurement" for which this value was calculated.

#### Since

2011

### `M:Autodesk.Revit.DB.ValueAtPointBase.GetFlags(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ValueAtPointBase.GetFlags(System.Int32)`

#### Summary

Returns flags for the given measurement.

#### Parameter `measurement`

Measurement number for which flags are returned.

#### Returns

Flags value for the measurement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for measurement is negative.

#### Since

2012

### `M:Autodesk.Revit.DB.ValueAtPointBase.ClearFlagsAt(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ValueAtPointBase.ClearFlagsAt(System.Int32)`

#### Summary

Sets flags for the given measurement to ValueAtPointFlags::None.

#### Parameter `measurement`

Measurement for which to clear flags.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for measurement is negative.

#### Since

2012

### `M:Autodesk.Revit.DB.ValueAtPointBase.ClearAllFlags`

Member kind: method
Symbol: `Autodesk.Revit.DB.ValueAtPointBase.ClearAllFlags`

#### Summary

Sets flags for all measurements to ValueAtPointFlags::None.

#### Since

2012

### `M:Autodesk.Revit.DB.ValueAtPointBase.SetFlags(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ValueAtPointBase.SetFlags(System.Int32,System.Int32)`

#### Summary

Sets the flags associated to a given measurement.

#### Parameter `flags`

The value of the flags to set.
Flags values are defined in the enumerated class ValueAtPointFlags and are combined into the int value.

#### Parameter `measurement`

Measurement for which to set flags.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for measurement is negative.

#### Since

2014

### `M:Autodesk.Revit.DB.ValueAtPointBase.SetFlags(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ValueAtPointBase.SetFlags(System.Int32)`

#### Summary

Sets the flags associated to all measurements to the same value.

#### Parameter `flags`

Value of flags, uniform for all measurements.
Flags values are defined in the enumerated class ValueAtPointFlags and are combined into the int value.

#### Since

2012

### `M:Autodesk.Revit.DB.ValueAtPointBase.SetFlags(System.Collections.Generic.IList{System.Int32})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ValueAtPointBase.SetFlags(System.Collections.Generic.IList{System.Int32})`

#### Summary

Independently sets the flags associated to all measurements.

#### Remarks

If you set the array of flags to only contain one value, this flags value will apply to all measurements

#### Parameter `flags`

An array of flags values. Each member corresponds to a measurement.
Flags values are defined in the enumerated class ValueAtPointFlags and are combined into the int value.
Number of measurements is set at creation of SpatialFieldManager in method createSpatialFieldManager.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.ValueAtPointBase.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ValueAtPointBase.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ValueAtPointBase`

Member kind: type
Symbol: `Autodesk.Revit.DB.ValueAtPointBase`

#### Summary

A base class representing storage of values at a given point.

#### Remarks

This class stores a set of measurements and corresponding mapped flags.
The flags are defined in the enumerated type ValueAtPointFlags.

#### Since

2012

### `T:Autodesk.Revit.DB.ValueAtPointFlags`

Member kind: type
Symbol: `Autodesk.Revit.DB.ValueAtPointFlags`

#### Summary

Enumerated type containing flags related to the display on particular points.
Enumerated type that stores bit values of flags that can be set at any domain point.

#### Since

2012

### `F:Autodesk.Revit.DB.ValueAtPointFlags.DisplayFence`

Member kind: field
Symbol: `Autodesk.Revit.DB.ValueAtPointFlags.DisplayFence`

#### Summary

Show fence for the point if allowed by display style (applies only to diagram display style)

### `F:Autodesk.Revit.DB.ValueAtPointFlags.DisplayText`

Member kind: field
Symbol: `Autodesk.Revit.DB.ValueAtPointFlags.DisplayText`

#### Summary

Show text marker for the point if allowed by display style (applies only to certain display styles)

### `F:Autodesk.Revit.DB.ValueAtPointFlags.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.ValueAtPointFlags.None`

#### Summary

No flags set

### `M:Autodesk.Revit.DB.Analysis.FieldDomainPointsByXYZ.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.FieldDomainPointsByXYZ.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Creates object from an array of three-dimensional point coordinates

#### Parameter `points`

Array of three-dimensional point coordinates representing domain points

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when supplied array points contain too many members (over 1000)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.FieldDomainPointsByXYZ`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.FieldDomainPointsByXYZ`

#### Summary

Represents a set of three-dimensional point coordinates

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.FieldDomainPointsByUV.SetGridCoordinates(System.Collections.Generic.ICollection{System.Double},System.Collections.Generic.ICollection{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.FieldDomainPointsByUV.SetGridCoordinates(System.Collections.Generic.ICollection{System.Double},System.Collections.Generic.ICollection{System.Double})`

#### Summary

Set u and v coordinates that specify a grid on the surface.
The display of the grid is controlled by AnalysisDisplayColoredSurfaceSettings::getShowGridLines().
If AnalysisDisplayColoredSurfaceSettings::getShowGridLines() returns true and both sets are empty
then a grid will be displayed using a default spacing; if only one of the sets is non-empty, then
only the corresponding set of grid lines will be displayed, i.e. the grid will consist solely of
parallel lines at the specified coordinates.

#### Parameter `uCoordinates`

Set of u coordinates at which to draw grid lines

#### Parameter `vCoordinates`

Set of v coordinates at which to draw grid lines

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.FieldDomainPointsByUV.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.UV},System.Collections.Generic.ICollection{System.Double},System.Collections.Generic.ICollection{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.FieldDomainPointsByUV.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.UV},System.Collections.Generic.ICollection{System.Double},System.Collections.Generic.ICollection{System.Double})`

#### Summary

Creates object from an array of two-dimensional point coordinates

#### Parameter `points`

Array of two-dimensional point coordinates representing domain points (usually on surface)

#### Parameter `uCoordinates`

Set of u coordinates at which to draw grid lines on the surface

#### Parameter `vCoordinates`

Set of v coordinates at which to draw grid lines on the surface

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.FieldDomainPointsByUV.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.UV})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.FieldDomainPointsByUV.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.UV})`

#### Summary

Creates object from an array of two-dimensional point coordinates

#### Parameter `points`

Array of two-dimensional point coordinates representing domain points (usually on surface)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.FieldDomainPointsByUV`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.FieldDomainPointsByUV`

#### Summary

Represents a set of two-dimensional point coordinates (defined usually on surface)

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.FieldDomainPointsByParameter.#ctor(System.Collections.Generic.IList{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.FieldDomainPointsByParameter.#ctor(System.Collections.Generic.IList{System.Double})`

#### Summary

Creates object from an array of one-dimensional point coordinates

#### Parameter `points`

Array of one-dimensional point coordinates representing domain points (using raw parameters when on a curve)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.FieldDomainPointsByParameter`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.FieldDomainPointsByParameter`

#### Summary

Represents a set of one-dimensional point coordinates (defined usually on curve)

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.FieldDomainPoints.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.FieldDomainPoints.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Analysis.FieldDomainPoints`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.FieldDomainPoints`

#### Summary

Abstract base class for various classes of field domain points

#### Since

2011

### `M:Autodesk.Revit.DB.FamilyUtils.GetProfileSymbols(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ProfileFamilyUsage,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyUtils.GetProfileSymbols(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ProfileFamilyUsage,System.Boolean)`

#### Summary

Gets the profile Family Symbols of the document.

#### Parameter `document`

The document.

#### Parameter `profileFamilyUsage`

The profile family usage.

#### Parameter `oneCurveLoopOnly`

Whether or not to return only profiles with one curve loop.

#### Returns

The set of profile Family Symbol element ids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.FamilyUtils.FamilyCanConvertToFaceHostBased(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyUtils.FamilyCanConvertToFaceHostBased(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Indicates whether the family can be converted to face host based.

#### Parameter `document`

The document.

#### Parameter `familyId`

The element id of the family.

#### Returns

True if the family can be converted to face-based.
Otherwise false, which will be returned if there any family instances exist in the project, the family is already face-based, or the family does not have a host.
Also, false is returned if the family does not belong to one of the following categories:
OST_CommunicationDevices

OST_DataDevices

OST_DuctTerminal

OST_ElectricalEquipment

OST_ElectricalFixtures

OST_FireAlarmDevices

OST_LightingDevices

OST_LightingFixtures

OST_MechanicalControlDevices

OST_MechanicalEquipment

OST_NurseCallDevices

OST_PlumbingEquipment

OST_PlumbingFixtures

OST_SecurityDevices

OST_Sprinklers

OST_TelephoneDevices

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.FamilyUtils.ConvertFamilyToFaceHostBased(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyUtils.ConvertFamilyToFaceHostBased(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Converts a family to be face host based.

#### Remarks

Converts a family hosted by some element other than a face to be hosted by a face. This is done by replacing the existing host (wall, roof, ceiling, floor) with a face.
Conversion can succeed only if FamilyUtils.FamilyCanConvertToFaceHostBased() returns true.

#### Parameter `document`

The document containing the family to be converted.

#### Parameter `familyId`

The family id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input familyId cannot be converted to face host based.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to convert the family to face host based.
-or-
The family is already unhosted.

### `T:Autodesk.Revit.DB.FamilyUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyUtils`

#### Summary

Contains utilities related to family operations.

### `T:Autodesk.Revit.DB.ProfileFamilyUsage`

Member kind: type
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage`

#### Summary

An enumerated type listing all types of profile families.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.StairSupport`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.StairSupport`

#### Summary

Stair Support.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.StairRiser`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.StairRiser`

#### Summary

Stair Riser.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.StairTread`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.StairTread`

#### Summary

Stair Tread.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.ContinuousFooting`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.ContinuousFooting`

#### Summary

Continuous Footing.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.SlabMetalDeck`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.SlabMetalDeck`

#### Summary

Slab Metal Deck.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.Mullion`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.Mullion`

#### Summary

Mullion.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.StairNosing`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.StairNosing`

#### Summary

Stair Nosing.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.Railing`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.Railing`

#### Summary

Railing.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.SlabEdge`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.SlabEdge`

#### Summary

Slab edge.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.Gutter`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.Gutter`

#### Summary

Gutter.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.Fascia`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.Fascia`

#### Summary

Fascia.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.Reveal`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.Reveal`

#### Summary

Reveal.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.WallSweep`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.WallSweep`

#### Summary

Wall sweep.

### `F:Autodesk.Revit.DB.ProfileFamilyUsage.Any`

Member kind: field
Symbol: `Autodesk.Revit.DB.ProfileFamilyUsage.Any`

#### Summary

Any type of profile family.

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.ShearAreaWeakAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.ShearAreaWeakAxis`

#### Summary

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.ShearAreaStrongAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.ShearAreaStrongAxis`

#### Summary

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.WarpingConstant`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.WarpingConstant`

#### Summary

Warping constant (Cw, Iomega, H)

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.TorsionalModulus`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.TorsionalModulus`

#### Summary

Section modulus for calculations of torsion stresses (Ct)

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.TorsionalMomentOfInertia`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.TorsionalMomentOfInertia`

#### Summary

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.PlasticModulusWeakAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.PlasticModulusWeakAxis`

#### Summary

Plastic section modulus in bending about main weak axis.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.PlasticModulusStrongAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.PlasticModulusStrongAxis`

#### Summary

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.ElasticModulusWeakAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.ElasticModulusWeakAxis`

#### Summary

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.ElasticModulusStrongAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.ElasticModulusStrongAxis`

#### Summary

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.MomentOfInertiaWeakAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.MomentOfInertiaWeakAxis`

#### Summary

Moment of Inertia about main weak axis (I).

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.MomentOfInertiaStrongAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.MomentOfInertiaStrongAxis`

#### Summary

Moment of Inertia about main strong axis (I).

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.NominalWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.NominalWeight`

#### Summary

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.Perimeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.Perimeter`

#### Summary

Painting surface of the unit length.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.SectionArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.SectionArea`

#### Summary

Cross section area.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.PrincipalAxesAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.PrincipalAxesAngle`

#### Summary

Rotation angle between the principal axes and cross section reference planes.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of StructuralSectionAnalysisParams.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams.#ctor`

#### Summary

Creates a new instance of StructuralSectionAnalysisParams.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams`

#### Summary

Defines common set of parameters for structural analysis.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.GetBoundarySize`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.GetBoundarySize`

#### Summary

Returns size of the section boundary.

#### Returns

Size of the section boundary.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.ShearAreaWeakAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.ShearAreaWeakAxis`

#### Summary

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.ShearAreaStrongAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.ShearAreaStrongAxis`

#### Summary

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.WarpingConstant`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.WarpingConstant`

#### Summary

Warping constant (Cw, Iomega, H).

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.TorsionalModulus`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.TorsionalModulus`

#### Summary

Section modulus for calculations of torsion stresses (Ct).

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.TorsionalMomentOfInertia`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.TorsionalMomentOfInertia`

#### Summary

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.PlasticModulusWeakAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.PlasticModulusWeakAxis`

#### Summary

Plastic section modulus in bending about main weak axis.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.PlasticModulusStrongAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.PlasticModulusStrongAxis`

#### Summary

Plastic section modulus in bending about main strong axis (Z, Wpl).

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.ElasticModulusWeakAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.ElasticModulusWeakAxis`

#### Summary

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.ElasticModulusStrongAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.ElasticModulusStrongAxis`

#### Summary

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.MomentOfInertiaWeakAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.MomentOfInertiaWeakAxis`

#### Summary

Moment of Inertia about main weak axis (I).

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.MomentOfInertiaStrongAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.MomentOfInertiaStrongAxis`

#### Summary

Moment of Inertia about main strong axis (I).

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.NominalWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.NominalWeight`

#### Summary

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.Perimeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.Perimeter`

#### Summary

Painting surface of the unit length.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.SectionArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.SectionArea`

#### Summary

Cross section area.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.PrincipalAxesAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.PrincipalAxesAngle`

#### Summary

Rotation angle between the principal axes and cross section reference planes.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.StructuralSectionShapeName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.StructuralSectionShapeName`

#### Summary

A human readable string representing the structural section shape.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.StructuralSectionGeneralShape`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.StructuralSectionGeneralShape`

#### Summary

The general type of structural section shape.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.StructuralSectionShape`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.StructuralSectionShape`

#### Summary

The type of structural section shape.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.AnalysisParams`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.AnalysisParams`

#### Summary

Common set of parameters for structural analysis.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.SectionNameKey`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection.SectionNameKey`

#### Summary

A parameter in structural families which allows for family type identification.
This will be used for data mapping during model exchange with another program, namely Advance Steel.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection`

#### Summary

The base class for StructuralSection specific classes, designed to provide common parameters and ability to differentiate between different structural section shapes.

#### Since

2015

### `M:Autodesk.Revit.DB.FamilySizeTableManager.GetFamilySizeTableManager(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTableManager.GetFamilySizeTableManager(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets a FamilySizeTableManager from a Family

#### Parameter `document`

Family owned document or a project document

#### Parameter `familyId`

ElementId of the Family.

#### Returns

The FamilySizeTableManager of the Family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FamilySizeTableManager.CreateFamilySizeTableManager(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTableManager.CreateFamilySizeTableManager(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Adds FamilySizeTableManager to a Family.
A FamilySizeTableManager and FamilySizeTables are only needed when
importing, exporting, or removing size data previously stored in CSV files.

#### Parameter `document`

Family owned document or project document.

#### Parameter `familyId`

ElementId of the Family.

#### Returns

True if successful, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FamilySizeTableManager.RemoveSizeTable(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTableManager.RemoveSizeTable(System.String)`

#### Summary

Removes the FamilySizeTable of a given name.

#### Parameter `tableName`

The FamilySizeTable name.

#### Returns

True if successful, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FamilySizeTableManager.ExportSizeTable(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTableManager.ExportSizeTable(System.String,System.String)`

#### Summary

Exports the size table to aCSV file.

#### Parameter `tableName`

The bool name to export.

#### Parameter `filePath`

The CSV file to export to.

#### Returns

True if successful, false otherwise..

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FamilySizeTableManager.ImportSizeTable(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.FamilySizeTableErrorInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTableManager.ImportSizeTable(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.FamilySizeTableErrorInfo)`

#### Summary

Imports a FamilySizeTable from a CSV file.

#### Parameter `document`

Family owned document or project document.

#### Parameter `filePath`

The CSV file path.

#### Parameter `errorInfo`

An error object to be written to if errors occur.

#### Returns

True if successful, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FamilySizeTableManager.HasSizeTable(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTableManager.HasSizeTable(System.String)`

#### Summary

Checks if a FamilySizeTable of a given name exists.

#### Parameter `tableName`

The name of the FamilySizeTable.

#### Returns

True if the FamilySizeTable exists, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FamilySizeTableManager.GetSizeTable(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTableManager.GetSizeTable(System.String)`

#### Summary

Get a FamilySizeTable by name.

#### Parameter `tableName`

The FamilySizeTable name.

#### Returns

The FamilySizeTable of a given name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FamilySizeTableManager.GetAllSizeTableNames`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTableManager.GetAllSizeTableNames`

#### Summary

Get the FamilySizeTable names in a family.

#### Returns

Array of size table names.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySizeTableManager.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySizeTableManager.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySizeTableManager.NumberOfSizeTables`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySizeTableManager.NumberOfSizeTables`

#### Summary

The number of FamilySizeTables in a family.

#### Since

2014

### `T:Autodesk.Revit.DB.FamilySizeTableManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilySizeTableManager`

#### Summary

Manages importing, exporting, and querying size data through the FamilySizeTable class.

#### Since

2014

### `M:Autodesk.Revit.DB.FamilySizeTable.AsValueString(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTable.AsValueString(System.Int32,System.Int32)`

#### Summary

Gets the table cell value as a string.

#### Parameter `row`

The table row.

#### Parameter `column`

The table column.

#### Returns

The table cell value as a string.

#### Since

2014

### `M:Autodesk.Revit.DB.FamilySizeTable.IsValidColumnIndex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTable.IsValidColumnIndex(System.Int32)`

#### Summary

Checks if the column index is valid.

#### Parameter `index`

The index of the column.

#### Returns

True if the column index is valid, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.FamilySizeTable.GetColumnHeader(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTable.GetColumnHeader(System.Int32)`

#### Summary

Gets a column of the table at at given index.

#### Parameter `index`

Index of the column.

#### Returns

The column at the given index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The column index is out of range.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySizeTable.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySizeTable.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySizeTable.NumberOfColumns`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySizeTable.NumberOfColumns`

#### Summary

Number of columns in the table.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySizeTable.NumberOfRows`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySizeTable.NumberOfRows`

#### Summary

Number of rows in the table.

#### Since

2014

### `T:Autodesk.Revit.DB.FamilySizeTable`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilySizeTable`

#### Summary

Contains size information for a family.

#### Since

2014

### `M:Autodesk.Revit.DB.FamilySizeTableColumn.GetUnitTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTableColumn.GetUnitTypeId`

#### Summary

Gets the identifier of the unit quantifying values in the column.

#### Returns

Identifier of the unit.

#### Since

2014

### `M:Autodesk.Revit.DB.FamilySizeTableColumn.GetSpecTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTableColumn.GetSpecTypeId`

#### Summary

Gets the identifier of the spec describing values in the column.

#### Returns

Identifier of the spec.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySizeTableColumn.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySizeTableColumn.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySizeTableColumn.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySizeTableColumn.Name`

#### Summary

The column name.

#### Since

2014

### `T:Autodesk.Revit.DB.FamilySizeTableColumn`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilySizeTableColumn`

#### Summary

Contains column information for a FamilySizeTable.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySizeTableErrorInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySizeTableErrorInfo.InvalidRowIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorInfo.InvalidRowIndex`

#### Summary

The index of the invalid row.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySizeTableErrorInfo.InvalidColumnIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorInfo.InvalidColumnIndex`

#### Summary

The index of the invalid column.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySizeTableErrorInfo.InvalidHeaderText`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorInfo.InvalidHeaderText`

#### Summary

The invalid header text.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySizeTableErrorInfo.FilePath`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorInfo.FilePath`

#### Summary

The path of the imported CSV file.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySizeTableErrorInfo.FamilySizeTableErrorType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorInfo.FamilySizeTableErrorType`

#### Summary

The error type.

#### Since

2014

### `M:Autodesk.Revit.DB.FamilySizeTableErrorInfo.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorInfo.#ctor`

#### Summary

Constructs a new FamilySizeTableErrorInfo with default settings.

#### Since

2014

### `T:Autodesk.Revit.DB.FamilySizeTableErrorInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorInfo`

#### Summary

Error information generated from the CSV file import of a FamilySizeTable.

#### Since

2014

### `T:Autodesk.Revit.DB.FamilySizeTableErrorType`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorType`

#### Summary

The set of errors that can be returned when importing a FamilySizeTable from a CSV file.

#### Since

2014

#### Since

2014

### `F:Autodesk.Revit.DB.FamilySizeTableErrorType.IncorrectNumberOfColumns`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorType.IncorrectNumberOfColumns`

#### Summary

The number of columns in the header row of the FamilySizeTable CSV file is different than the number of columns of data.

### `F:Autodesk.Revit.DB.FamilySizeTableErrorType.CannotParseColumnHeader`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorType.CannotParseColumnHeader`

#### Summary

Failed to parse the column header of the FamilySizeTable CSV file.

### `F:Autodesk.Revit.DB.FamilySizeTableErrorType.InvalidHeaderSeparator`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorType.InvalidHeaderSeparator`

#### Summary

The CSV file header separator is not invalid. Valid header separators are comma(,), semicolon(;), colon(:), and pipe (|).

### `F:Autodesk.Revit.DB.FamilySizeTableErrorType.CannotReadFile`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorType.CannotReadFile`

#### Summary

Failed to read the FamilySizeTable CSV file.

### `F:Autodesk.Revit.DB.FamilySizeTableErrorType.CannotOpenFile`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorType.CannotOpenFile`

#### Summary

Failed to open the FamilySizeTable CSV file.

### `F:Autodesk.Revit.DB.FamilySizeTableErrorType.FileNotFound`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorType.FileNotFound`

#### Summary

The FamilySize Table CSV file was not found.

### `F:Autodesk.Revit.DB.FamilySizeTableErrorType.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilySizeTableErrorType.Undefined`

#### Summary

Undefined error.

### `M:Autodesk.Revit.DB.FamilyPointLocation.GetLocation`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyPointLocation.GetLocation`

#### Summary

Gets the location of the point.

#### Returns

The location of the point.

#### Since

2017

### `P:Autodesk.Revit.DB.FamilyPointLocation.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyPointLocation.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilyPointLocation.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyPointLocation.Name`

#### Summary

The name of the corresponding reference point in the Family document.

### `T:Autodesk.Revit.DB.FamilyPointLocation`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyPointLocation`

#### Summary

Data corresponding to the point locations in certain types of Family Symbols.

#### Remarks

Examples of FamilySymbol objects that contain placement references are Panels and Flexible Components.

### `T:Autodesk.Revit.DB.FamilyHostingBehavior`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyHostingBehavior`

#### Summary

Types of hosts into/onto which a family can be hosted.
For informative purposes only. Does not affect anything in Revit!

#### Since

2011

### `M:Autodesk.Revit.DB.FamilyThermalProperties.Find(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyThermalProperties.Find(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Finds the thermal properties by the 'id' property of a constructionType node in Constructions.xml.

#### Parameter `pADoc`

The document.

#### Parameter `constructionId`

The 'id' property of a constructionType node in Constructions.xml

#### Returns

The thermal properties found, or `null` if no match was found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.FamilyThermalProperties.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyThermalProperties.IsValid`

#### Summary

Confirms that the thermal properties are correctly set for assignment to a FamilySymbol.

#### Returns

True if the thermal properties are valid, false otherwise.

#### Since

2015

### `P:Autodesk.Revit.DB.FamilyThermalProperties.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyThermalProperties.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilyThermalProperties.ThermalResistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyThermalProperties.ThermalResistance`

#### Summary

The calculated thermal resistance value (R-Value).
The units are meter-squared kelvin per watt ((m^2*K)/Watt).

#### Since

2013

### `P:Autodesk.Revit.DB.FamilyThermalProperties.AnalyticConstructionName`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyThermalProperties.AnalyticConstructionName`

#### Summary

The construction gbXML name.
This value corresponds to the 'Name' property of a constructionType node in Constructions.xml.

#### Since

2013

### `P:Autodesk.Revit.DB.FamilyThermalProperties.AnalyticConstructionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyThermalProperties.AnalyticConstructionTypeId`

#### Summary

The construction gbXML type.
This value corresponds to the 'id' property of a constructionType node in Constructions.xml.

#### Since

2013

### `P:Autodesk.Revit.DB.FamilyThermalProperties.VisualLightTransmittance`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyThermalProperties.VisualLightTransmittance`

#### Summary

The visual light transmittance.

#### Since

2013

### `P:Autodesk.Revit.DB.FamilyThermalProperties.SolarHeatGainCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyThermalProperties.SolarHeatGainCoefficient`

#### Summary

The solar heat gain coefficient.

#### Since

2013

### `P:Autodesk.Revit.DB.FamilyThermalProperties.HeatTransferCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyThermalProperties.HeatTransferCoefficient`

#### Summary

The heat transfer coefficient value (U-Value).
The units are watts per meter-squared kelvin (W/(m^2*K)).

#### Since

2013

### `M:Autodesk.Revit.DB.FamilyThermalProperties.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyThermalProperties.#ctor`

#### Summary

Constructs a new FamilyThermalProperties with default settings.

#### Since

2013

### `T:Autodesk.Revit.DB.FamilyThermalProperties`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyThermalProperties`

#### Summary

A class that contains thermal properties for specific types of families
(doors, windows, and curtain wall panels).

#### Since

2013

### `M:Autodesk.Revit.DB.FailuresAccessor.JournalFailures(System.Collections.Generic.IList{Autodesk.Revit.DB.FailureMessageAccessor})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.JournalFailures(System.Collections.Generic.IList{Autodesk.Revit.DB.FailureMessageAccessor})`

#### Summary

Allows to record information about failures in the journal.

#### Remarks

Records information about failure messages and elements involved in the failures.
If this method not invoked, journal does not contain any information about failures
resolved by (pre)processing.

#### Parameter `failures`

Accessors to the failures to journal.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.RollBackPendingTransaction`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.RollBackPendingTransaction`

#### Summary

Finishes pending failures processing by rolling back the pending transaction.

#### Returns

Result of attempt to roll back the pending transaction.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).
-or-
The processing of the failures is not in the pending state.

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.CommitPendingTransaction`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.CommitPendingTransaction`

#### Summary

Finishes pending failures processing by committing the pending transaction.

#### Returns

Result of attempt to commit the pending transaction.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).
-or-
The processing of the failures is not in the pending state.
-or-
There is no pending transaction or transaction is not allowed to be committed.

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.IsPending`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.IsPending`

#### Summary

Checks if the failure processing is pending.

#### Remarks

The failure processing is pending after failures processor has returned WaitForUserInput
and until pending state is finished by either committing or rolling back of the pending transaction.

#### Returns

True if the failures processing is in the pending state.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.CanRollBackPendingTransaction`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.CanRollBackPendingTransaction`

#### Summary

Checks if pending failure processing can be finished by rolling back a pending transaction.

#### Remarks

Check makes sense only if the failure processing is pending.

#### Returns

True if there is a pending transaction and this transaction is allowed to be rolled back

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.CanCommitPendingTransaction`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.CanCommitPendingTransaction`

#### Summary

Checks if pending failure processing can be finished by committing a pending transaction.

#### Remarks

Check makes sense only if the failure processing is pending.

#### Returns

True if there is a pending transaction and this transaction is allowed to be committed.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.GetAttemptedResolutionTypes(Autodesk.Revit.DB.FailureMessageAccessor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.GetAttemptedResolutionTypes(Autodesk.Revit.DB.FailureMessageAccessor)`

#### Summary

Returns list of the failure resolution types attempted for the failure in the current transaction.

#### Remarks

In some cases attempt to resolve a failure has no impact or failure gets reposted during next round of the end of transaction checks
after being resolved. Knowing if any failure resolutions were attempted for the failure allows failures processor
to prevent infinite loop.

#### Parameter `failure`

The failure.

#### Returns

The list of the types of failure resolutions attempted for the failure.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

failure has not been properly initialized.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.DeleteElements(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.DeleteElements(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Resolves failures by deletion of elements related to the failures.

#### Parameter `idsToDelete`

Ids of elements to be deleted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Resolution of the failures by deleting idsToDelete is not permitted

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.ResolveFailures(System.Collections.Generic.IList{Autodesk.Revit.DB.FailureMessageAccessor})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.ResolveFailures(System.Collections.Generic.IList{Autodesk.Revit.DB.FailureMessageAccessor})`

#### Summary

Resolves one or more failures using last set failure resolution type for each of the failures.
If failure resolution type was not set for some of failures, default failure resolution type will be used.

#### Remarks

After execution of the failure resolutions the failures will not be removed from the document automatically. To
prevent failure from being delivered to the user, failures (pre)processor should return ProceedWithCommit.
It will cause failures to be regenerated and failure resolution process to be restarted.
If attempt to resolve failure was not successful, and the same failure is present on repetitive calls
of the failures (pre)processor, the preprocessor code should take care to attempt
a different resolution the next time the failure appears, to avoid an infinite loop.

#### Parameter `failures`

The accessors to the failures to be resolved.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Default resolution of one of the failures is not permitted or not applicable.
-or-
One of the failures was already attempted to resolve twice with that resolution type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).
-or-
Resolution of failures is not permitted in the current state of the document.

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.ResolveFailure(Autodesk.Revit.DB.FailureMessageAccessor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.ResolveFailure(Autodesk.Revit.DB.FailureMessageAccessor)`

#### Summary

Resolves one failure using the failure resolution type last set for it.

#### Remarks

If failure resolution type was not set, the default failure resolution type will be used.
After execution of the failure resolution the failure will not be removed from the document automatically. To
prevent the failure from being delivered to the user, failures (pre)processor should return ProceedWithCommit.
It will cause failures to be regenerated and failure resolution process to be restarted.
If attempt to resolve failure was not successful, and the same failure is present on repetitive calls
of the failures (pre)processor, the preprocessor code should take care to attempt
a different resolution the next time the failure appears, to avoid an infinite loop.

#### Parameter `failure`

The accessor to the failure to be resolved.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

failure has not been properly initialized.
-or-
failure does not have any resolutions.
-or-
Default resolution of failure is not permitted or not applicable.
-or-
The failure was already attempted to resolve twice with that resolution type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).
-or-
Resolution of failures is not permitted in the current state of the document.

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.DeleteAllWarnings`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.DeleteAllWarnings`

#### Summary

Deletes all FailureMessages of severity "Warning" currently posted in a document.

#### Remarks

Warnings are deleted immediately and will not be accessible by any further failures processing.
Any accessors for these failure messages become invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.DeleteWarning(Autodesk.Revit.DB.FailureMessageAccessor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.DeleteWarning(Autodesk.Revit.DB.FailureMessageAccessor)`

#### Summary

Deletes one specific failure message of severity "Warning".

#### Parameter `failure`

The accessor to the warning to be deleted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

failure has not been properly initialized.
-or-
Severity of failure is not FailureSeverity::Warning.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.PostFailure(Autodesk.Revit.DB.FailureMessage)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.PostFailure(Autodesk.Revit.DB.FailureMessage)`

#### Summary

Posts an additional failure message to be processed for the current transaction.

#### Remarks

Should be used during failures processing instead of a similar method in a document class.
Using method of the document class with the same name during failures processing is prohibited.

#### Parameter `failure`

Failure message to post.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.ReplaceFailures(Autodesk.Revit.DB.FailureMessage)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.ReplaceFailures(Autodesk.Revit.DB.FailureMessage)`

#### Summary

Deletes all failure messages currently posted in a document and replaces them with one "generic" failure.

#### Remarks

If analysis done by Failures Processing code concludes that in a given context delivering
of the posted failures to the user makes no sense, this method can be used to discard all posted failures
and substitute one "generic" one, that will be delivered to the user and then transaction
forced to be aborted.
After the call, (pre)processing of failures should return ProceedWithRollback.

#### Parameter `failure`

FailureMessage that should replace all currently posted messages. It must have severity DocumentCorruption.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Severity of failure must be FailureSeverity::DocumentCorruption.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.SetFailureHandlingOptions(Autodesk.Revit.DB.FailureHandlingOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.SetFailureHandlingOptions(Autodesk.Revit.DB.FailureHandlingOptions)`

#### Summary

Sets failure handling options for the transaction currently being finished.

#### Remarks

If used with returning ProceedWithRollback from (pre)processing, allows to dismiss errors and roll back transaction
without any further failures processing and silently for the user.

#### Parameter `options`

The failure handling options to be set for the transaction currently being finished.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.GetFailureHandlingOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.GetFailureHandlingOptions`

#### Summary

Provides access to the failure handling options for the transaction currently being finished.

#### Returns

The failure handling options for transaction currently being finished.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.IsElementsDeletionPermitted(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},System.String@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.IsElementsDeletionPermitted(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},System.String@)`

#### Summary

Checks if resolution of the failures by deleting given collection of elements is permitted.

#### Remarks

Method does not confirm if deletion of the elements will or may resolve the failure - it simply verifies
that given elements can be deleted in the current state of the document.

#### Parameter `idsToDelete`

The Ids of elements to be deleted.

#### Parameter `reason`

A localized string explaining reason why the elements cannot be deleted.

#### Returns

True if resolution of the failures by deleting given elements is permitted

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.IsElementsDeletionPermitted(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.IsElementsDeletionPermitted(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Checks if resolution of the failures by deleting given collection of elements is permitted.

#### Remarks

Method does not confirm if deletion of the elements will or may resolve the failure - it simply verifies
that given elements exist and can be deleted in the current state of the document.

#### Parameter `idsToDelete`

The Ids of elements to be deleted.

#### Returns

True if resolution of the failures by deleting given elements is permitted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.IsElementsDeletionPermitted`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.IsElementsDeletionPermitted`

#### Summary

Checks if resolution of the failures by deleting failure elements is permitted.

#### Returns

True if resolution of the failures by deleting failure elements is permitted.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.IsFailureResolutionPermitted(Autodesk.Revit.DB.FailureMessageAccessor,Autodesk.Revit.DB.FailureResolutionType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.IsFailureResolutionPermitted(Autodesk.Revit.DB.FailureMessageAccessor,Autodesk.Revit.DB.FailureResolutionType)`

#### Summary

Checks if resolution of the failure using given resolution type is permitted.

#### Parameter `failure`

Accessor to the failure to be resolved.

#### Parameter `resolutionType`

Type of the failure resolution to be used.

#### Returns

True if resolution of the failure using given resolution type is permitted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

failure has not been properly initialized.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.IsFailureResolutionPermitted(Autodesk.Revit.DB.FailureMessageAccessor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.IsFailureResolutionPermitted(Autodesk.Revit.DB.FailureMessageAccessor)`

#### Summary

Checks if default resolution of the failure is permitted.

#### Parameter `failure`

The accessor to the failure to be resolved.

#### Returns

True if default resolution of the failure is permitted

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

failure has not been properly initialized.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.IsFailureResolutionPermitted`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.IsFailureResolutionPermitted`

#### Summary

Checks if resolution of failures is permitted.

#### Returns

True if resolutions of failures is permitted.

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.IsTransactionBeingCommitted`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.IsTransactionBeingCommitted`

#### Summary

Checks if the transaction for which failures are processed is being committed or rolled back.

#### Remarks

A transaction is considered as "being committed" if a caller has requested the transaction to be committed and
no previous failure processing operation requested the transaction to be rolled back.

#### Returns

True if current transaction is being committed, false if the transaction is being rolled back.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.GetFailureMessages(Autodesk.Revit.DB.FailureSeverity)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.GetFailureMessages(Autodesk.Revit.DB.FailureSeverity)`

#### Summary

Provides access to the individual failure messages if a given severity currently posted in the document.

#### Parameter `severity`

The failure severity for which failure messages are requested.
If the requested severity is None, an empty collection is returned.

#### Returns

Accessors to the individual failure messages of a given severity posted in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.GetFailureMessages`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.GetFailureMessages`

#### Summary

Provides access to the individual failure messages currently posted in the document.

#### Remarks

Returned set of messages will be ordered from more severe to less severe.

#### Returns

The accessors to the individual failure messages posted in the document.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.SetTransactionName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.SetTransactionName(System.String)`

#### Summary

Changes the name of the transaction for which failures are being processed.

#### Remarks

If the transaction will be committed by or after failures processing it can change its name to reflect
results of processing of the failures. For example, if the original transaction name was "review warnings" and
some of the warnings were resolved by deleting of the relevant elements, failures processor may
change the name of the transaction to "delete elements".

#### Parameter `transactionName`

The name of the transaction to set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

transactionName is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.GetTransactionName`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.GetTransactionName`

#### Summary

Retrieves the name of the transaction for which failures are being processed.

#### Returns

The name of the transaction for which failures are being processed.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.GetSeverity`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.GetSeverity`

#### Summary

Provides access to the current failure severity.

#### Returns

The highest severity of a failure message currently posted in the document.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.GetDocument`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.GetDocument`

#### Summary

Provides access to a document for which failures are being processed or preprocessed.

#### Returns

The document for which failures preprocessing or processing is being performed.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FailuresAccessor is inactive (is used outside of failures processing).

#### Since

2011

### `M:Autodesk.Revit.DB.FailuresAccessor.IsActive`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailuresAccessor.IsActive`

#### Summary

Method allows to check if this instance of the accessor is currently active.

#### Remarks

Generally, this instance is active when it is passed to any of interfaces used in the process of failure resolution,
and becomes inactive after returning control to Revit.
The only special case is if failures processor returns WaitForUserInput,
in which case document stays in the FailureMode and instance of failures accessor stays active till FailureMode is ended.

#### Returns

True if this instance is currently active and can be used.

#### Since

2011

### `P:Autodesk.Revit.DB.FailuresAccessor.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FailuresAccessor.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FailuresAccessor`

Member kind: type
Symbol: `Autodesk.Revit.DB.FailuresAccessor`

#### Summary

An interface class that provides access to failure information posted in a document and methods to resolve these failures.

#### Remarks

An instance of this class can be obtained only as an argument passed to interfaces used in the process of failure resolution
and is the only available interface to fetch information about failures in a document.
While reading from a document during failure processing is allowed, the only way to modify document during failure resolution is via methods
provided by this class.
After returning from failure processing, the instance of the class is deactivated and cannot be used any longer.

#### Since

2011

### `T:Autodesk.Revit.DB.TransactionStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.TransactionStatus`

#### Summary

An enumerated type listing the possible statuses associated with a Transaction, TransactionGroup, or SubTransaction,
or the result of a particular method call on one of those objects.

#### Since

2011

### `F:Autodesk.Revit.DB.TransactionStatus.Proceed`

Member kind: field
Symbol: `Autodesk.Revit.DB.TransactionStatus.Proceed`

#### Summary

while still in error handling (internal status)

### `F:Autodesk.Revit.DB.TransactionStatus.Error`

Member kind: field
Symbol: `Autodesk.Revit.DB.TransactionStatus.Error`

#### Summary

error while committing or rolling back

### `F:Autodesk.Revit.DB.TransactionStatus.Pending`

Member kind: field
Symbol: `Autodesk.Revit.DB.TransactionStatus.Pending`

#### Summary

returned from error handling that took over managing the transaction

### `F:Autodesk.Revit.DB.TransactionStatus.Committed`

Member kind: field
Symbol: `Autodesk.Revit.DB.TransactionStatus.Committed`

#### Summary

simply committed, ended an empty transaction, flushed all, or undo is disabled

### `F:Autodesk.Revit.DB.TransactionStatus.RolledBack`

Member kind: field
Symbol: `Autodesk.Revit.DB.TransactionStatus.RolledBack`

#### Summary

rolled back (aborted)

### `F:Autodesk.Revit.DB.TransactionStatus.Started`

Member kind: field
Symbol: `Autodesk.Revit.DB.TransactionStatus.Started`

#### Summary

transaction has begun (until committed or rolled back)

### `F:Autodesk.Revit.DB.TransactionStatus.Uninitialized`

Member kind: field
Symbol: `Autodesk.Revit.DB.TransactionStatus.Uninitialized`

#### Summary

initial value, the transaction has not been started yet in this status

### `M:Autodesk.Revit.DB.FailureMessageKey.IsEqual(Autodesk.Revit.DB.FailureMessageKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureMessageKey.IsEqual(Autodesk.Revit.DB.FailureMessageKey)`

#### Summary

Checks it this key is equal to the other.

#### Parameter `other`

The key to compare with.

#### Returns

True if keys are equal, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FailureMessageKey.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureMessageKey.IsValid`

#### Summary

Checks if the failure message key is valid

#### Returns

True if the failure message key is valid

#### Since

2011

### `P:Autodesk.Revit.DB.FailureMessageKey.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FailureMessageKey.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.FailureMessageKey.GetHashCode`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureMessageKey.GetHashCode`

#### Summary

Gets the integer value of the id as hash code

### `M:Autodesk.Revit.DB.FailureMessageKey.Equals(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureMessageKey.Equals(System.Object)`

#### Summary

Determines whether the specified `T:System.Object` is equal to the current `T:System.Object` .

#### Parameter `obj`

Another object.

### `M:Autodesk.Revit.DB.FailureMessageKey.op_Inequality(Autodesk.Revit.DB.FailureMessageKey,Autodesk.Revit.DB.FailureMessageKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureMessageKey.op_Inequality(Autodesk.Revit.DB.FailureMessageKey,Autodesk.Revit.DB.FailureMessageKey)`

#### Summary

Determines whether two FailureMessageKeys are different.

#### Parameter `first`

The first FailureMessageKey.

#### Parameter `second`

The second FailureMessageKey.

#### Returns

True if the FailureMessageKeys are different; otherwise, false.

### `M:Autodesk.Revit.DB.FailureMessageKey.op_Equality(Autodesk.Revit.DB.FailureMessageKey,Autodesk.Revit.DB.FailureMessageKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureMessageKey.op_Equality(Autodesk.Revit.DB.FailureMessageKey,Autodesk.Revit.DB.FailureMessageKey)`

#### Summary

Determines whether two FailureMessageKeys are the same.

#### Parameter `first`

The first FailureMessageKey.

#### Parameter `second`

The second FailureMessageKey.

#### Returns

True if the FailureMessageKeys are the same; otherwise, false.

### `M:Autodesk.Revit.DB.FailureMessageKey.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureMessageKey.#ctor`

#### Summary

Constructs a new FailureMessageKey with default settings.

#### Since

2011

### `T:Autodesk.Revit.DB.FailureMessageKey`

Member kind: type
Symbol: `Autodesk.Revit.DB.FailureMessageKey`

#### Summary

A unique key assigned to each posted failure message

#### Remarks

When a failure message is posted, it gets a unique key assigned and returned to the caller. The key is guaranteed to be unique in the Revit session.
The key can be used to unpost (delete) previously posted failure message if it is no longer valid.

#### Since

2011

### `M:Autodesk.Revit.DB.ITransactionFinalizerProxy.OnRolledBack(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ITransactionFinalizerProxy.OnRolledBack(Autodesk.Revit.DB.Document,System.String)`

#### Summary

This method is called at the end of rolling back a transaction

#### Parameter `document`

The document associated with the transaction

#### Parameter `strTransactionName`

The transaction's name

#### Since

2011

### `M:Autodesk.Revit.DB.ITransactionFinalizerProxy.OnCommitted(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ITransactionFinalizerProxy.OnCommitted(Autodesk.Revit.DB.Document,System.String)`

#### Summary

This method is called at the end of committing a transaction

#### Parameter `document`

The document associated with the transaction

#### Parameter `strTransactionName`

The transaction's name

#### Since

2011

### `M:Autodesk.Revit.DB.ITransactionFinalizer.OnRolledBack(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ITransactionFinalizer.OnRolledBack(Autodesk.Revit.DB.Document,System.String)`

#### Summary

This method is called at the end of rolling back a transaction

#### Parameter `document`

The document associated with the transaction

#### Parameter `strTransactionName`

The transaction's name

#### Since

2011

### `M:Autodesk.Revit.DB.ITransactionFinalizer.OnCommitted(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ITransactionFinalizer.OnCommitted(Autodesk.Revit.DB.Document,System.String)`

#### Summary

This method is called at the end of committing a transaction

#### Parameter `document`

The document associated with the transaction

#### Parameter `strTransactionName`

The transaction's name

#### Since

2011

### `T:Autodesk.Revit.DB.ITransactionFinalizer`

Member kind: type
Symbol: `Autodesk.Revit.DB.ITransactionFinalizer`

#### Summary

An interface that may be used to perform a custom action at the end of a transaction.
A method of the interface will be called when a transaction is either committed or rolled back.

#### Since

2011

### `P:Autodesk.Revit.DB.BuiltInFailures.ZoneFailures.ZonesOverlapWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ZoneFailures.ZonesOverlapWarning`

#### Summary

Zone overlap to another zone or another room.

### `P:Autodesk.Revit.DB.BuiltInFailures.ZoneFailures.ZoneNotEnclosed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ZoneFailures.ZoneNotEnclosed`

#### Summary

Zone not enclosed totally.

### `P:Autodesk.Revit.DB.BuiltInFailures.ZoneFailures.ZoneExistsNotEnclosedRoom`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ZoneFailures.ZoneExistsNotEnclosedRoom`

#### Summary

Zone has a room not enclosed.

### `T:Autodesk.Revit.DB.BuiltInFailures.ZoneFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ZoneFailures`

#### Summary

Failures about Zone.

### `P:Autodesk.Revit.DB.BuiltInFailures.WorksharingFailures.SeriousElementReferenceCorruption`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WorksharingFailures.SeriousElementReferenceCorruption`

#### Summary

Element references are seriously corrupt.

### `P:Autodesk.Revit.DB.BuiltInFailures.WorksharingFailures.MissingUpdaterLatestOrCentralSingular`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WorksharingFailures.MissingUpdaterLatestOrCentralSingular`

#### Summary

The file [File Name] you are trying to synchronize was modified by the third-party updater [Updater Name(s)] which is not
currently installed. \n\r \n\r If you continue to Synchronize with Central or Reload Latest, data maintained by this updater
will not be updated properly. This may create problems when [File Name] is later opened when [Updater Name(s)] is present.

### `P:Autodesk.Revit.DB.BuiltInFailures.WorksharingFailures.MissingUpdaterLatestOrCentralPlural`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WorksharingFailures.MissingUpdaterLatestOrCentralPlural`

#### Summary

The file [File Name] you are trying to synchronize was modified by the third-party updaters [Updater Name(s)] which are
not currently installed. \n\r \n\r If you continue to Synchronize with Central or Reload Latest, data maintained
by these updaters will not be updated properly. This may create problems when [File Name] is later opened when
[Updater Name(s)] are present.

### `P:Autodesk.Revit.DB.BuiltInFailures.WorksharingFailures.DuplicateNamesChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WorksharingFailures.DuplicateNamesChanged`

#### Summary

These elements' names were automatically changed to eliminate duplicates.

### `T:Autodesk.Revit.DB.BuiltInFailures.WorksharingFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WorksharingFailures`

#### Summary

Failures about WorksharingFailures.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallJoinRoofFailures.WallNotCoveredByRoof`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallJoinRoofFailures.WallNotCoveredByRoof`

#### Summary

The highlighted wall(s) cannot be joined to the highlighted roof because the roof does not entirely cover the wall(s).

### `P:Autodesk.Revit.DB.BuiltInFailures.WallJoinRoofFailures.WallMeetsRoofTangentially`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallJoinRoofFailures.WallMeetsRoofTangentially`

#### Summary

The highlighted wall cannot be joined to the highlighted roof because the wall meets the roof tangentially.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallJoinRoofFailures.NotCoveredAtAllByTarget`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallJoinRoofFailures.NotCoveredAtAllByTarget`

#### Summary

Highlighted walls are attached to, but miss, the highlighted targets.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallJoinRoofFailures.NoUptoRoofForWall`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallJoinRoofFailures.NoUptoRoofForWall`

#### Summary

Highlighted wall is set to be "Up to roof", however there is no roof above it that can be used.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallJoinRoofFailures.NoFromRoofForWall`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallJoinRoofFailures.NoFromRoofForWall`

#### Summary

Highlighted wall is set to be "From roof", however there is no roof below it that can be used.

### `T:Autodesk.Revit.DB.BuiltInFailures.WallJoinRoofFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallJoinRoofFailures`

#### Summary

Failures about WallJoinRoof.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallJoinFailures.FailedToChangeWallJointsTypeFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallJoinFailures.FailedToChangeWallJointsTypeFailure`

#### Summary

Some of the joints you have selected can only have one wall joint type, so these joints haven't been changed.

### `T:Autodesk.Revit.DB.BuiltInFailures.WallJoinFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallJoinFailures`

#### Summary

Failures about WallJoin.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.WallTypeIncompatibleWithTapered`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.WallTypeIncompatibleWithTapered`

#### Summary

This wall's type is not compatible with the Tapered cross-section. Tapered walls require a variable thickness layer.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.WallSettingsChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.WallSettingsChanged`

#### Summary

Default wall settings will be changed (Base Constraint: [Base Level], Base Offset: [Base Offset], Top Constraint: [Top Level], Top Offset: [Top Offset])

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.WallNegativeHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.WallNegativeHeight`

#### Summary

The top of the Wall is lower than the base of the Wall.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.WallLacksCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.WallLacksCurve`

#### Summary

Wall does not have both a curve driver and a curve!!!!

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.WallCutoutForInsertionFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.WallCutoutForInsertionFailure`

#### Summary

Can't cut wall for inserted objects

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.VerticalLayerExtensionFailureError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.VerticalLayerExtensionFailureError`

#### Summary

Cannot extend layer(s) of the highlighted vertically compound wall.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.VerticalLayerExtensionFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.VerticalLayerExtensionFailure`

#### Summary

Cannot extend layer(s) of the highlighted vertically compound wall.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.UnjoinOnEditWallChange`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.UnjoinOnEditWallChange`

#### Summary

Line associated with a joined face has been moved. This action will cause the other walls to become disjoined from this face. [Description]

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.UnableToDeleteWallForPanel`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.UnableToDeleteWallForPanel`

#### Summary

Unable to delete curtain panel wall.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.UnableToCreateWallForPanel`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.UnableToCreateWallForPanel`

#### Summary

Unable to create wall for curtain wall panel.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.TooShortStackedWall`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.TooShortStackedWall`

#### Summary

Stacked wall instance is too short.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.TaperedWallAnglesControlledByType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.TaperedWallAnglesControlledByType`

#### Summary

Cannot set angles on a tapered wall which has angles controlled by the type.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.SubwallOfStackedWallDeleted`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.SubwallOfStackedWallDeleted`

#### Summary

This stacked wall will be deleted because a subwall could not be created.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.StackedWallNeedsUnjoin`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.StackedWallNeedsUnjoin`

#### Summary

A subwall of this stacked wall is unjoined from its neighbors because it was pulled too far.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.ShouldAdjustWallParameters`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.ShouldAdjustWallParameters`

#### Summary

The best way to control top and base of the Wall is to modify the Constraints and Offset Parameters in Properties dialog.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.ShorterThanMinWallFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.ShorterThanMinWallFailure`

#### Summary

Wall is shorter than minimum height allowed by its type.\nIt is [Length] and must be at least [Length].

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.ShorterThanMinWallError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.ShorterThanMinWallError`

#### Summary

Wall is shorter than minimum height allowed by its type.\nIt is [Length] and must be at least [Length].

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.ShorterThanMinWall`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.ShorterThanMinWall`

#### Summary

Wall is shorter than minimum height allowed by its type.\nIt is [Length] and must be at least [Length].

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.RemapConstrainLocationLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.RemapConstrainLocationLine`

#### Summary

Existing locked constraints to the Location Line will be transferred to the new Location Line position. Press "Unconstrain" to remove the constraint rather than transferring it.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.RecursionParameterIgnored`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.RecursionParameterIgnored`

#### Summary

Parameter-defined type of curtain panels defined in a circular way and will be ignored.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.ParameterChangeNotAffectingGeometry`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.ParameterChangeNotAffectingGeometry`

#### Summary

Changing this element's parameter has no effect on its current position or geometry. Check to see if the element is constrained either in the project view or in the element's sketch.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.LostEditsJoinsRedoFaceBased`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.LostEditsJoinsRedoFaceBased`

#### Summary

Previous edits and /or wall joins will not be preserved on this operation.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.InvalidTopConstraintForLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.InvalidTopConstraintForLevel`

#### Summary

Top Constraint is invalid for the Level.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.InvalidTargetPositionError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.InvalidTargetPositionError`

#### Summary

Joining the highlighted wall to the highlighted element moves the wall's top below its bottom or its bottom above its top, or interferes with wall joins or holes in the wall.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.InvalidTargetPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.InvalidTargetPosition`

#### Summary

Joining the highlighted wall to the highlighted element moves the wall's top below its bottom or its bottom above its top, or interferes with wall joins or holes in the wall.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.InvalidCompoundStructure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.InvalidCompoundStructure`

#### Summary

Invalid compound structure.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.InvalidBaseConstraintForLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.InvalidBaseConstraintForLevel`

#### Summary

Base Constraint is invalid for the Level.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.FailedToStoreSideFace`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.FailedToStoreSideFace`

#### Summary

Failed to store wall side face. Wall sweeps on this wall will fail to regenerate.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.FailedToChangeInstSymbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.FailedToChangeInstSymbol`

#### Summary

Failed to change symbol of instance.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.FailedConvertWallToPanel`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.FailedConvertWallToPanel`

#### Summary

Unable to convert wall to panel.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceWallMissingFace`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceWallMissingFace`

#### Summary

No picked face found.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceWallFailedToMake`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceWallFailedToMake`

#### Summary

Can't make Face Wall shape.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceWallComplexType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceWallComplexType`

#### Summary

Vertically compound wall type features sweeps, reveals, or split layers are not supported on non-vertical face. Consider using a simplified type.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceWallBadType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceWallBadType`

#### Summary

Wall type '[Type Name]' is incompatible with picked face. Only basic wall types are accepted.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceIsNoLongerVertical`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceIsNoLongerVertical`

#### Summary

Face defining this vertical Wall is no longer vertical.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceIsNoGoodForWall`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceIsNoGoodForWall`

#### Summary

Defining face is not suitable for walls.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceBecameVertical`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.FaceBecameVertical`

#### Summary

Face defining this non-vertical Wall is vertical.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.ExtrudedWallDisallowedForCrossSectionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.ExtrudedWallDisallowedForCrossSectionType`

#### Summary

Edited profiles are not allowed for this wall's cross-section type.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.EmbeddedButShouldNotBe`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.EmbeddedButShouldNotBe`

#### Summary

Conditions for wall embedding are no longer satisfied.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.DisallowedPathCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.DisallowedPathCurve`

#### Summary

Cannot create stacked elliptical wall with offsets.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.CurtainOrStackedWallDisallowedForCrossSectionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.CurtainOrStackedWallDisallowedForCrossSectionType`

#### Summary

Curtain wall types and Stacked wall types are not allowed for this wall's cross-section type.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.ContFootingRadiusTooSmall`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.ContFootingRadiusTooSmall`

#### Summary

Can't display the Wall Foundation, because the Wall's radius is too small. Please increase the radius to display the Wall Foundation.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.ContFootingCannotJoin`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.ContFootingCannotJoin`

#### Summary

Miter plane for Wall Foundation join is too far away; Bisecting plane will be used instead.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.ConstrainedToWallError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.ConstrainedToWallError`

#### Summary

Sketch Lines created with Pick Wall must remain parallel to the Wall.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.ConstrainedToWall`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.ConstrainedToWall`

#### Summary

Sketch Lines created with Pick Wall must remain parallel to the Wall.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.ChangingWallsweepType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.ChangingWallsweepType`

#### Summary

This wall sweep instance has different profile or material than its type. You may delete the sweep, or if you ignore this warning, it will be regenerated according to its type.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotUpdateWallPanel`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotUpdateWallPanel`

#### Summary

Unable to update wall panel.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotToSplitWallPanels`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotToSplitWallPanels`

#### Summary

Unable to split wall panel(s).

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotSplitVerticallyCompoundWall`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotSplitVerticallyCompoundWall`

#### Summary

Can't divide Wall's face to assign different materials to a vertically compound Wall.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotSplitJoinHostsInplaceFamilies`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotSplitJoinHostsInplaceFamilies`

#### Summary

Can't split/join this host because there are instances of In-place Families that cut openings into it. Edit or delete instances first so they don't cut into the host to be split or joined.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotSlantStackedWallError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotSlantStackedWallError`

#### Summary

Cannot slant a stacked wall with rectangular openings. Please delete the openings first.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotRedoFaceRoof`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotRedoFaceRoof`

#### Summary

"Faces defining this Roof cannot be reacquired. Either delete the Roof or leave as it is.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotRedoFaceBasedWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotRedoFaceBasedWarn`

#### Summary

Faces defining this Element cannot be reacquired.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotRedoFaceBased`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotRedoFaceBased`

#### Summary

Faces defining this Element cannot be reacquired.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotMirrorWallPanel`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotMirrorWallPanel`

#### Summary

Cannot mirror wall panels.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotMaintainKeyReference`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotMaintainKeyReference`

#### Summary

Can't maintain the position of the Location Line in this Wall.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotChangeTypeOfOldCurtainPanel`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotChangeTypeOfOldCurtainPanel`

#### Summary

Cannot change the type of curtain panels in walls created with early versions of Revit. To change the panels of this curtain wall, wall must be recreated.

### `P:Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotChangeSubwall`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures.CannotChangeSubwall`

#### Summary

Changing the type of a subwall is not allowed. Edit the stacked wall type instead.

### `T:Autodesk.Revit.DB.BuiltInFailures.WallFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.WallFailures`

#### Summary

Failures about Wall.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures.ViewportCantContainEmptyView`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures.ViewportCantContainEmptyView`

#### Summary

Sheet views cannot contain empty view "%1!s!".

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures.ViewOnASheetMustBeUniqueWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures.ViewOnASheetMustBeUniqueWarn`

#### Summary

Sheet views cannot contain more than one instance of "%1!s!."

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures.ViewOnASheetMustBeUnique`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures.ViewOnASheetMustBeUnique`

#### Summary

Sheet views cannot contain more than one instance of "%1!s!."

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures.ViewOnASheetCannotBeUncropped3DPerspectiveView`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures.ViewOnASheetCannotBeUncropped3DPerspectiveView`

#### Summary

Sheets do not support uncropped perspective views.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures.ViewInAModelMustBeUniqueWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures.ViewInAModelMustBeUniqueWarn`

#### Summary

Sheet views in this model cannot contain more than one instance of "%1!s!."

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures.ViewInAModelMustBeUnique`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures.ViewInAModelMustBeUnique`

#### Summary

Sheet views in this model cannot contain more than one instance of "%1!s!."

### `T:Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewSheetFailures`

#### Summary

Failures about placing viewports on sheets.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.ZeroLengthViewRegionsRemoved`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.ZeroLengthViewRegionsRemoved`

#### Summary

Some View Regions were removed. When the size of a View Region becomes zero, it is removed from the view.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.ZeroLengthViewBreaksRemoved`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.ZeroLengthViewBreaksRemoved`

#### Summary

Some View Regions were consolidated. When the size of a View Break between View Regions becomes zero, the View Break
is removed and the adjacent View Regions are joined.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.ViewPublishFailed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.ViewPublishFailed`

#### Summary

The following views could not be published.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.TurnCropRegionOffRemovesViewBreaks`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.TurnCropRegionOffRemovesViewBreaks`

#### Summary

Turning off the Crop Region of the view will remove all View Breaks. If the Crop Region is turned on at a later time,
any desired View Breaks must be created again.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.ReloadLatestDeletedLastOpenView`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.ReloadLatestDeletedLastOpenView`

#### Summary

The only open view has been deleted because of changes from the Central Model. Open another view and Reload Latest or Synchronize with Central again.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.NothingToApplyWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.NothingToApplyWarning`

#### Summary

Start and end elevations are the same, nothing to Apply.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.NothingToApplyError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.NothingToApplyError`

#### Summary

Start and end elevations are the same, nothing to Apply.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.NoTargetsForDependentViewPropagation`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.NoTargetsForDependentViewPropagation`

#### Summary

There are no valid views. Only views without dependents can be used.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.InvalidDBviewScopeBox`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.InvalidDBviewScopeBox`

#### Summary

The scope box and view must have parallel vertical axes.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.InsertComponentViewFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.InsertComponentViewFailure`

#### Summary

This type of Component cannot be placed in Elevation or Section view

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.InsertComponentViewError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.InsertComponentViewError`

#### Summary

This type of Component cannot be placed in Elevation or Section view

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.InsertColumnViewFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.InsertColumnViewFailure`

#### Summary

Column cannot be placed in Elevation or Section view

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.InsertColumnViewError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.InsertColumnViewError`

#### Summary

Column cannot be placed in Elevation or Section view

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.InitialViewDeleted`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.InitialViewDeleted`

#### Summary

The starting view for the project has been deleted.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.DetailNumberEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.DetailNumberEmpty`

#### Summary

Detail Number is empty

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.DetailNumberDuplicate`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.DetailNumberDuplicate`

#### Summary

Detail Number is already in use. Enter a unique number.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.CannotToggleToPerspective`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.CannotToggleToPerspective`

#### Summary

Cannot toggle to perspective view because the view contains annotations.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.CannotPasteViewReferences`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.CannotPasteViewReferences`

#### Summary

Cannot paste view references into the view they reference or into unrelated views

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.CanNotDeleteLastOpenView`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.CanNotDeleteLastOpenView`

#### Summary

Deleting of all open views in a project is not allowed.

### `P:Autodesk.Revit.DB.BuiltInFailures.ViewFailures.BadViewDirectionSetting`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures.BadViewDirectionSetting`

#### Summary

Plan view DBViewType has invalid view direction parameter.

### `T:Autodesk.Revit.DB.BuiltInFailures.ViewFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ViewFailures`

#### Summary

Failures about ViewFailures.

### `P:Autodesk.Revit.DB.BuiltInFailures.UniqueElementFailures.ProhibitUniqueElementDeletion`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.UniqueElementFailures.ProhibitUniqueElementDeletion`

#### Summary

Internal setting '%1!s!' is required by Revit and has been deleted.

### `P:Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussUserDefinedMemberNotJoined`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussUserDefinedMemberNotJoined`

#### Summary

Both start and end of web must intersect the truss.

### `P:Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussUserDefinedMemberDeleted`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussUserDefinedMemberDeleted`

#### Summary

A user-defined structural member was deleted due to missing or deleted references.

### `P:Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussNotJoinedWebs`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussNotJoinedWebs`

#### Summary

The current edits are causing some webs to disjoin. The truss layout family requires additional constraints to maintain these joins.

### `P:Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussLayoutOverlapedCurves`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussLayoutOverlapedCurves`

#### Summary

The current transformation of this specific truss layout will some sub members to overlap.

### `P:Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussLayoutNonSympleTopChord`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussLayoutNonSympleTopChord`

#### Summary

This truss layout family defines an offset or non horizontal top chord. This may conflict with attachment or profile editing.

### `P:Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussIsAttachedTo`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussIsAttachedTo`

#### Summary

Revit cannot attach to the chosen Roof/Slab. The truss cannot project to a surface or the attachment creates an invalid profile.

### `P:Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussInvalidSymbolGeom`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussInvalidSymbolGeom`

#### Summary

Truss is unable to generate any members due to layout family error.

### `P:Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussDuplicateEngineeringType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussDuplicateEngineeringType`

#### Summary

Elements have duplicate 'Engineering Type' values.

### `P:Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussChordUntransformable`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussChordUntransformable`

#### Summary

Unable to maintain user changes to unpinned Chord. Restoring Truss-defined shape.

### `P:Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussBadTransformation`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures.TrussBadTransformation`

#### Summary

Revit cannot transform the truss Layout Family to the Truss as oriented in the project.

### `P:Autodesk.Revit.DB.BuiltInFailures.TrussFailures.RemoveTrussSketch`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures.RemoveTrussSketch`

#### Summary

Remove Sketch

### `P:Autodesk.Revit.DB.BuiltInFailures.TrussFailures.InvalidWorkplaneForStructuralFraming`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures.InvalidWorkplaneForStructuralFraming`

#### Summary

Workplane not valid for Structural Framing component "[Family Name]"

### `P:Autodesk.Revit.DB.BuiltInFailures.TrussFailures.IncorrectWallUsageWithAttachedStruct`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures.IncorrectWallUsageWithAttachedStruct`

#### Summary

A structural framing element is attached to a wall whose Structural Usage is set to [Usage].

### `T:Autodesk.Revit.DB.BuiltInFailures.TrussFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TrussFailures`

#### Summary

Failures about Truss.

### `P:Autodesk.Revit.DB.BuiltInFailures.ToggleViewFailures.LoseSavedOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ToggleViewFailures.LoseSavedOrientation`

#### Summary

The stored orientation will be lost.

### `T:Autodesk.Revit.DB.BuiltInFailures.ToggleViewFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ToggleViewFailures`

#### Summary

Failures about ToggleView.

### `P:Autodesk.Revit.DB.BuiltInFailures.TilePatternTileFailures.TilePatternTile_InvalidFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TilePatternTileFailures.TilePatternTile_InvalidFamily`

#### Summary

Family not appropriate for Divided Surface component.

### `T:Autodesk.Revit.DB.BuiltInFailures.TilePatternTileFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TilePatternTileFailures`

#### Summary

Failures related to tile pattern tile.

### `P:Autodesk.Revit.DB.BuiltInFailures.TextFailures.ModeltextIsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TextFailures.ModeltextIsEmpty`

#### Summary

Model Text deleted because it consists entirely of spaces and/or carriage returns.

### `P:Autodesk.Revit.DB.BuiltInFailures.TextFailures.CannotCreateModeltext`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TextFailures.CannotCreateModeltext`

#### Summary

Can't create Model Text.

### `T:Autodesk.Revit.DB.BuiltInFailures.TextFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TextFailures`

#### Summary

Failures about Text.

### `P:Autodesk.Revit.DB.BuiltInFailures.TagFailures.TagsCannotBePlacedInUnlocked3dViews`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TagFailures.TagsCannotBePlacedInUnlocked3dViews`

#### Summary

Tags can't be pasted into Unlocked 3D views.

### `P:Autodesk.Revit.DB.BuiltInFailures.TagFailures.RemoveTagWithNoLeaders`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TagFailures.RemoveTagWithNoLeaders`

#### Summary

The Tag was deleted because it was no longer pointing to any elements.

### `P:Autodesk.Revit.DB.BuiltInFailures.TagFailures.MultiCategoryTagFilterParamNotFoundInElement`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TagFailures.MultiCategoryTagFilterParamNotFoundInElement`

#### Summary

The filter specified by Multi-Category Tag can't be used with the tagged object.

### `P:Autodesk.Revit.DB.BuiltInFailures.TagFailures.ElementCategoryChangeInvalidatesTagUpgrade`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TagFailures.ElementCategoryChangeInvalidatesTagUpgrade`

#### Summary

During upgrade, Revit discovered that the highlighted elements were marked with tags of the wrong category. These tags were deleted.

### `P:Autodesk.Revit.DB.BuiltInFailures.TagFailures.ElementCategoryChangeInvalidatesTag`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TagFailures.ElementCategoryChangeInvalidatesTag`

#### Summary

Elements have changed category. Tags for these elements are now of the wrong category and will be deleted.

### `P:Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotRemapTagReference`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotRemapTagReference`

#### Summary

The tag reference was not remapped.

### `P:Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotPasteTag`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotPasteTag`

#### Summary

Can't find new element to tag. Tag won't be copied.

### `P:Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotPasteOrphanTagsWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotPasteOrphanTagsWarn`

#### Summary

Orphaned tags cannot be pasted.

### `P:Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotPasteOrphanTags`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotPasteOrphanTags`

#### Summary

Orphaned tags cannot be pasted.

### `P:Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotPasteAssociate`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotPasteAssociate`

#### Summary

Can't find new associated element. Element won't be copied.

### `P:Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotCopyTagWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotCopyTagWarn`

#### Summary

A tag cannot be arrayed without copying the associated element.

### `P:Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotCopyTag`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TagFailures.CannotCopyTag`

#### Summary

A tag cannot be arrayed without copying the associated element.

### `T:Autodesk.Revit.DB.BuiltInFailures.TagFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.TagFailures`

#### Summary

Failures about Tag.

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.SelectedElementsArePartOfOtherSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.SelectedElementsArePartOfOtherSystem`

#### Summary

You have selected elements that are already part of other System. They will be removed from the original Systems and added to this one.

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.PastePartsWithInvalidService`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.PastePartsWithInvalidService`

#### Summary

Parts were not pasted because fabrication configuration is not available or service is not valid in the type properties for the system.

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.MismatchSystemType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.MismatchSystemType`

#### Summary

Cannot add [Element] to System. The System Type for the available connector does not match the System Type ([Type Name]) for the System.

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.FamilyDoesntMatchSystemPropertiesWasDisconnected`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.FamilyDoesntMatchSystemPropertiesWasDisconnected`

#### Summary

The family no longer matches the properties for the System. Disconnect the family from the System?

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.FamilyDoesntMatchSystemProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.FamilyDoesntMatchSystemProperties`

#### Summary

The family no longer matches the properties for the System. Disconnect the family from the System?

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.ElementsBelongToOtherSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.ElementsBelongToOtherSystem`

#### Summary

You have selected elements that are already part of other Systems that have assigned Equipment. The elements you selected cannot be added to this System.

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.DefaultSystemOver50Elems`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.DefaultSystemOver50Elems`

#### Summary

The default system "[Element Name]" is now over 50 elements. To improve performance, Revit is no longer calculating the critical path pressure drop and the more complex duct sizing has been disabled. If you want to use these features, you must define logical systems in the model instead of using the default system.

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.CreatePartsWithoutDabasebase`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.CreatePartsWithoutDabasebase`

#### Summary

Parts were not created because fabrication configuration is not available.

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.CreatePartsWithInvalidSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.CreatePartsWithInvalidSystem`

#### Summary

Parts were not created because the element does not have a valid system.

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.CreatePartsWithInvalidService`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.CreatePartsWithInvalidService`

#### Summary

Parts were not created because a system's service is undefined.

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.CircuitWorksetClosedWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.CircuitWorksetClosedWarning`

#### Summary

The workset of the circuit is closed so the circuit path will not be displayed.

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.AddingOtherConnectedMembersToSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemsFailures.AddingOtherConnectedMembersToSystem`

#### Summary

"You have selected elements that are connected to other elements. These elements will also be added to the System."

### `T:Autodesk.Revit.DB.BuiltInFailures.SystemsFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemsFailures`

#### Summary

Failures about System.

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemNavigatorFailures.MultipleSelectNumberIsWrong`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemNavigatorFailures.MultipleSelectNumberIsWrong`

#### Summary

The selected tree nodes number of system browser is wrong.

### `P:Autodesk.Revit.DB.BuiltInFailures.SystemNavigatorFailures.CannottFindCorrectTreeNode`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemNavigatorFailures.CannottFindCorrectTreeNode`

#### Summary

Can't find the correct tree node in system browser according to the node index.

### `T:Autodesk.Revit.DB.BuiltInFailures.SystemNavigatorFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SystemNavigatorFailures`

#### Summary

Failures related with the system browser.

### `P:Autodesk.Revit.DB.BuiltInFailures.SweptBlendFailures.CannotDrawSweptblend`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SweptBlendFailures.CannotDrawSweptblend`

#### Summary

Can't create swept blend.

### `T:Autodesk.Revit.DB.BuiltInFailures.SweptBlendFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SweptBlendFailures`

#### Summary

Failures about SweptBlend.

### `P:Autodesk.Revit.DB.BuiltInFailures.SweepFailures.WallSweepInconsistent`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SweepFailures.WallSweepInconsistent`

#### Summary

The model contains corrupt elements. Delete the corrupt elements to proceed or cancel the action without deleting the elements.

### `P:Autodesk.Revit.DB.BuiltInFailures.SweepFailures.SweepFailedError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SweepFailures.SweepFailedError`

#### Summary

Proper sweep geometry creation failed.

### `P:Autodesk.Revit.DB.BuiltInFailures.SweepFailures.SweepFailed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SweepFailures.SweepFailed`

#### Summary

Proper sweep geometry creation failed.

### `P:Autodesk.Revit.DB.BuiltInFailures.SweepFailures.ProfileLoopEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SweepFailures.ProfileLoopEmpty`

#### Summary

Profile sketch is empty!

### `P:Autodesk.Revit.DB.BuiltInFailures.SweepFailures.ComplexPathWithComplexProfile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SweepFailures.ComplexPathWithComplexProfile`

#### Summary

Sweep cannot have a path with ellipse or spline segments and a profile with non-straight lines.

### `P:Autodesk.Revit.DB.BuiltInFailures.SweepFailures.CannotDrawSweep`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SweepFailures.CannotDrawSweep`

#### Summary

Can't create sweep.

### `T:Autodesk.Revit.DB.BuiltInFailures.SweepFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SweepFailures`

#### Summary

Failures about Sweep.

### `P:Autodesk.Revit.DB.BuiltInFailures.SubRegionFailures.SubDivisionPhaseMismatch`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SubRegionFailures.SubDivisionPhaseMismatch`

#### Summary

Sub-division must have the same Phase Created parameter and Phase Demolished parameter as the host Toposolid. Sub-division phase will be set to match the Toposolid.

### `P:Autodesk.Revit.DB.BuiltInFailures.SubRegionFailures.NoHostForToposolidSubregion`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SubRegionFailures.NoHostForToposolidSubregion`

#### Summary

This sub-division now does not appear to overlap any Toposolid with an appropriate Phase and Design Option.

### `P:Autodesk.Revit.DB.BuiltInFailures.SubRegionFailures.CreateSubRegionFailed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.SubRegionFailures.CreateSubRegionFailed`

#### Summary

Create sub-division failed.

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralLoadFailures.HostChangeDisallowsLoadOrBoundaryConditions`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralLoadFailures.HostChangeDisallowsLoadOrBoundaryConditions`

#### Summary

Some Hosted Loads or BoundaryConditions lost their References. They will be deleted.

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralLoadFailures.CannotPlaceBoundaryConditions`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralLoadFailures.CannotPlaceBoundaryConditions`

#### Summary

A boundary condition is already created on the selected element. Duplicate boundary conditions are not allowed. Click the Replace button to delete previous definition of boundary condition or cancel the operation.

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralLoadFailures.CannotMoveBoundaryCondition`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralLoadFailures.CannotMoveBoundaryCondition`

#### Summary

Can't move Boundary Conditions

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralLoadFailures.CannotMirrorBoundaryCondition`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralLoadFailures.CannotMirrorBoundaryCondition`

#### Summary

Can't mirror Boundary Conditions

### `T:Autodesk.Revit.DB.BuiltInFailures.StructuralLoadFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralLoadFailures`

#### Summary

Failures about Load.

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralCustomConnectionFailures.StructuralCustomConnectionWrongType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralCustomConnectionFailures.StructuralCustomConnectionWrongType`

#### Summary

Structural Custom Connection has an inappropriate type assigned.

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralCustomConnectionFailures.StructuralCustomConnectionEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralCustomConnectionFailures.StructuralCustomConnectionEmpty`

#### Summary

Structural Custom Connection cannot be empty.

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralCustomConnectionFailures.StructuralCustomConnectionComponentsRelationship`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralCustomConnectionFailures.StructuralCustomConnectionComponentsRelationship`

#### Summary

Cannot create custom connection due to relationships to external elements.

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralCustomConnectionFailures.StructuralCannotCreateCustomConnection`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralCustomConnectionFailures.StructuralCannotCreateCustomConnection`

#### Summary

Could not create a custom connection.

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralCustomConnectionFailures.SimpleConnectionTooFarRefs`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralCustomConnectionFailures.SimpleConnectionTooFarRefs`

#### Summary

Simple Structural Connection Handler cannot connect too far elements

### `T:Autodesk.Revit.DB.BuiltInFailures.StructuralCustomConnectionFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralCustomConnectionFailures`

#### Summary

Failures about StructuralConnectionHandler.

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralSectionHasIncompleteDefinition`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralSectionHasIncompleteDefinition`

#### Summary

Structural Section has incomplete definition

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralConnectionWrongType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralConnectionWrongType`

#### Summary

Structural Connection has an inappropriate type assigned.

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralConnectionTypeInfoNotAvailable`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralConnectionTypeInfoNotAvailable`

#### Summary

There is no add-on installed which supports Structural Connection type.

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralConnectionTypeChangedToGeneric`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralConnectionTypeChangedToGeneric`

#### Summary

Structural Connection had an inappropriate type, which has been changed to 'Generic Connection'.

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralConnectionTooFarRefs`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralConnectionTooFarRefs`

#### Summary

Structural Connection Handler cannot connect too far elements

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralConnectionTooFarNotEnoughRefs`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralConnectionTooFarNotEnoughRefs`

#### Summary

Structural Connection Handler cannot connect too far elements

### `P:Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralConnectionSetOfRefsChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.StructuralConnectionFailures.StructuralConnectionSetOfRefsChanged`

#### Summary

The set of input elements was changed and the connection has been adjusted.
