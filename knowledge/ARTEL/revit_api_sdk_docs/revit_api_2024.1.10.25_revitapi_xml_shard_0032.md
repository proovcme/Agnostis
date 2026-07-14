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
Shard: 32
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `T:Autodesk.Revit.DB.Mechanical.DuctSizeSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettings`

#### Summary

Duct sizes settings

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.CurrentObject`

### `P:Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.GetValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.GetValue`

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.GetKey`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.GetKey`

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.HasCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.HasCurrent`

#### Summary

Identifies whether the iterator has a current item.
There is no current item if the iterator has not started yet or has been done.

#### Returns

True if there is a current item.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.MoveNext`

#### Summary

Increments the enumerator to the next item.

#### Returns

True if there is a next available item in this enumerator.
False if the enumerator has completed all available items.

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator`

#### Summary

An iterator to a set of items from DuctSizeSettings. Each item is a KeyValuePair(DuctShape::Enum, DuctSizes).

#### Since

2013

### `T:Autodesk.Revit.DB.Mechanical.DuctShape`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctShape`

#### Summary

Enumerated type listing possible shapes for ducts.

#### Since

2013

### `F:Autodesk.Revit.DB.Mechanical.DuctShape.Oval`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.DuctShape.Oval`

#### Summary

Oval duct shape.

### `F:Autodesk.Revit.DB.Mechanical.DuctShape.Rectangular`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.DuctShape.Rectangular`

#### Summary

Rectangular duct shape.

### `F:Autodesk.Revit.DB.Mechanical.DuctShape.Round`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.DuctShape.Round`

#### Summary

Round duct shape.

### `M:Autodesk.Revit.DB.Mechanical.DuctSizes.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizes.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Mechanical.DuctSizes.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizes.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Mechanical.DuctSizes.GetDuctSizesIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizes.GetDuctSizesIterator`

#### Summary

Returns a DuctSizeIterator to the MEP duct sizes.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizes.Contains(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizes.Contains(System.Double)`

#### Summary

Checks whether a duct size with the nominal diameter exists.

#### Parameter `nominalDiameter`

Nominal diameter.

#### Returns

True if a duct size with the nominal diameter exists.

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.DuctSizes.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizes.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSizes.Count`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizes.Count`

#### Summary

Count of the items contained in the collection.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizes.GetDuctSizeIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizes.GetDuctSizeIterator`

#### Summary

Returns a DuctSizeIterator that iterates through the collection.

#### Returns

A DuctSizeIterator object that can be used to iterate through key-value pairs in the collection.

### `T:Autodesk.Revit.DB.Mechanical.DuctSizes`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizes`

#### Summary

Class RbsDuctSizes being used to store the duct sizes

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.DuctSizeIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeIterator.CurrentObject`

### `P:Autodesk.Revit.DB.Mechanical.DuctSizeIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeIterator.HasCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeIterator.HasCurrent`

#### Summary

Identifies if the iterator has a current item.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Returns

True if there is a current item.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeIterator.GetCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeIterator.GetCurrent`

#### Summary

Returns the current MEPSize.

#### Returns

The current MEPSize.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeIterator.MoveNext`

#### Summary

Increments the iterator to the next item.

#### Returns

True if there is a next available item in this iterator.
False if the iterator has completed all available items.

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.DuctSizeIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Mechanical.DuctSizeIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeIterator`

#### Summary

An iterator to a set of MEP duct sizes from DuctSizes.

#### Since

2013

### `M:Autodesk.Revit.DB.MEPCalculationServerInfo.GetMEPCalculationServerInfo(Autodesk.Revit.DB.FamilyInstance)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPCalculationServerInfo.GetMEPCalculationServerInfo(Autodesk.Revit.DB.FamilyInstance)`

#### Summary

Gets a MEPCalculationServerInfo by family instance.

#### Parameter `famInst`

The family instance.

#### Returns

The MEPCalculationServerInfo.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.MEPCalculationServerInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCalculationServerInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.MEPCalculationServerInfo.PipeUseDefinitionOnTypeGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCalculationServerInfo.PipeUseDefinitionOnTypeGUID`

#### Summary

The guid value ("3BF616F9-6B98-4A21-80FF-DA1120C8F6D6") of Use Definition On Type. It is not a server id, but a guid to tell if the loss method is "Use Definition On Type" or not.
If the loss method is "Use Definition On Type", we use the loss method of the family type to calculate.

### `P:Autodesk.Revit.DB.MEPCalculationServerInfo.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCalculationServerInfo.Description`

#### Summary

The Description of the server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.MEPCalculationServerInfo.ServerName`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCalculationServerInfo.ServerName`

#### Summary

The Name of the server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.MEPCalculationServerInfo.ServerId`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCalculationServerInfo.ServerId`

#### Summary

The Id of the server.

### `M:Autodesk.Revit.DB.MEPCalculationServerInfo.#ctor(Autodesk.Revit.DB.MEPCalculationServerInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPCalculationServerInfo.#ctor(Autodesk.Revit.DB.MEPCalculationServerInfo)`

#### Summary

Constructs a new copy of the input MEPCalculationServerInfo object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.MEPCalculationServerInfo.#ctor(Autodesk.Revit.DB.ExternalService.IExternalServer)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPCalculationServerInfo.#ctor(Autodesk.Revit.DB.ExternalService.IExternalServer)`

#### Summary

Create a new MEPCalculationServerInfo by an external server.

#### Parameter `server`

The external server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.MEPCalculationServerInfo.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPCalculationServerInfo.#ctor`

#### Summary

Constructs a new MEPCalculationServerInfo with default settings.

### `T:Autodesk.Revit.DB.MEPCalculationServerInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.MEPCalculationServerInfo`

#### Summary

a struct to hold the information about a MEP calucation servers

### `T:Autodesk.Revit.DB.FittingAndAccessoryCalculationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.FittingAndAccessoryCalculationType`

#### Summary

The MEP fitting and accessory pressure drop calculation type.

#### Summary

Enum of fitting and accessory pressure drop calculation type.

### `F:Autodesk.Revit.DB.FittingAndAccessoryCalculationType.ValidateCurrentSettings`

Member kind: field
Symbol: `Autodesk.Revit.DB.FittingAndAccessoryCalculationType.ValidateCurrentSettings`

#### Summary

To validate the current settings of the fitting and accessory.

### `F:Autodesk.Revit.DB.FittingAndAccessoryCalculationType.CalculateDefaultSettings`

Member kind: field
Symbol: `Autodesk.Revit.DB.FittingAndAccessoryCalculationType.CalculateDefaultSettings`

#### Summary

To calculate the default settings of the fitting and accessory.

### `F:Autodesk.Revit.DB.FittingAndAccessoryCalculationType.CalculatePressureDrop`

Member kind: field
Symbol: `Autodesk.Revit.DB.FittingAndAccessoryCalculationType.CalculatePressureDrop`

#### Summary

To calculate the pressure drop of the fitting and accessory.

### `F:Autodesk.Revit.DB.FittingAndAccessoryCalculationType.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.FittingAndAccessoryCalculationType.Undefined`

#### Summary

Undefined fitting and accessory pressure drop calculation type.

### `M:Autodesk.Revit.DB.Mechanical.DuctSettings.IsNetworkBasedCalculationsEnabled(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.IsNetworkBasedCalculationsEnabled(Autodesk.Revit.DB.Document)`

#### Summary

Indicates whether network based calculations for duct networks is enabled in the specified document.

#### Parameter `document`

The document.

#### Returns

Returns true if network based calculations for duct networks is enabled, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.DuctSettings.SetPressLossCalculationServerInfo(Autodesk.Revit.DB.MEPCalculationServerInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.SetPressLossCalculationServerInfo(Autodesk.Revit.DB.MEPCalculationServerInfo)`

#### Summary

Set the MEPServerInfo of the current pipe pressure loss calculation server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.DuctSettings.GetPressLossCalculationServerInfo`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.GetPressLossCalculationServerInfo`

#### Summary

Get the MEPServerInfo of the current pipe pressure loss calculation server.

#### Returns

The MEPServerInfo of the current pipe pressure loss calculation server

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.DuctSettings.IsValidSpecificFittingAngle(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.IsValidSpecificFittingAngle(System.Double)`

#### Summary

Checks that the given value is a valid specific fitting angle. The specific fitting angles are angles of 90, 60, 45, 30, 22.5 or 11.25 degrees.

#### Parameter `angle`

The angle value (in degree).

#### Returns

True if the given value is a valid specific fitting angle.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.DuctSettings.GetSpecificFittingAngleStatus(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.GetSpecificFittingAngleStatus(System.Double)`

#### Summary

Gets the status of given specific angle.

#### Parameter `angle`

The specific fitting angle (in degree) that must be one of 90, 60, 45, 30, 22.5 or 11.25 degrees.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for angle must be 90, 60, 45, 30, 22.5 or 11.25 degrees.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.DuctSettings.SetSpecificFittingAngleStatus(System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.SetSpecificFittingAngleStatus(System.Double,System.Boolean)`

#### Summary

Sets the status of given specific angle.

#### Parameter `angle`

The specific angle (in degree) that must be one of 60, 45, 30, 22.5 or 11.25 degrees.

#### Parameter `useInLayout`

Status, true - using the given angle during the duct layout.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for angle must be 90, 60, 45, 30, 22.5 or 11.25 degrees.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Can not set an angle status for an invalid angle.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.DuctSettings.GetSpecificFittingAngles`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.GetSpecificFittingAngles`

#### Summary

Gets the list of specific fitting angles.

#### Remarks

Revit will only use the angles specified during the pipe layout or modifying the pipe layout.
When laying out the pipes, if the angle between two pipes is close to the allowed angle,
the specific angle is used for that pipe fitting.

#### Returns

Angles (in degrees).

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.DuctSettings.GetDuctSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.GetDuctSettings(Autodesk.Revit.DB.Document)`

#### Summary

Get the duct settings of the project.

#### Parameter `document`

The document.

#### Returns

The duct settings of the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.NetworkBasedCalculations`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.NetworkBasedCalculations`

#### Summary

Indicates whether to enable network based calculations for duct networks.

#### Since

2024

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.UseAnnotationScaleForSingleLineFittings`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.UseAnnotationScaleForSingleLineFittings`

#### Summary

Indicates whether use annotation scale for single line fittings or not.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.FittingAngleUsage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.FittingAngleUsage`

#### Summary

Determine how to use fitting angle during duct layout or modifying layout.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.RiseDropAnnotationSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.RiseDropAnnotationSize`

#### Summary

The rise drop annotation size.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.FittingAnnotationSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.FittingAnnotationSize`

#### Summary

The value of fitting annotation size.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for fittingAnnotationSize must be no more than 30000 feet in absolute value.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.AirViscosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.AirViscosity`

#### Summary

The kinematic viscosity of air in ft^2/s.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.AirDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.AirDensity`

#### Summary

The air density in kg/ft^3.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.Centerline`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.Centerline`

#### Summary

The abbreviation of the Centerline (=) string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.SetDownFromBottom`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.SetDownFromBottom`

#### Summary

The abbreviation of the Set Down from bottom (BD) of fitting string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.SetUpFromBottom`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.SetUpFromBottom`

#### Summary

The abbreviation of the Set Up from bottom (BU) of fitting string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.SetDown`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.SetDown`

#### Summary

The abbreviation of the Set Down from top (TD) of fitting string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.SetUp`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.SetUp`

#### Summary

The abbreviation of the Set Up from top (TU) of fitting string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.FlatOnBottom`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.FlatOnBottom`

#### Summary

The abbreviation of the Flat On Bottom (FOB) string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.FlatOnTop`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.FlatOnTop`

#### Summary

The abbreviation of the Flat On Top (FOT) string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.OvalDuctSizeSuffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.OvalDuctSizeSuffix`

#### Summary

The oval duct size suffix string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.OvalDuctSizeSeparator`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.OvalDuctSizeSeparator`

#### Summary

The oval duct size separator string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.ConnectorSeparator`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.ConnectorSeparator`

#### Summary

The duct connector separator string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.RoundDuctSizePrefix`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.RoundDuctSizePrefix`

#### Summary

The round duct size prefix string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.RoundDuctSizeSuffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.RoundDuctSizeSuffix`

#### Summary

The round duct size suffix string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.RectangularDuctSizeSuffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.RectangularDuctSizeSuffix`

#### Summary

The rectangular duct size suffix string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSettings.RectangularDuctSizeSeparator`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings.RectangularDuctSizeSeparator`

#### Summary

The rectangular duct size separator string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.Mechanical.DuctSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSettings`

#### Summary

The duct setting class.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.DuctLiningType.IsValidRoughness(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctLiningType.IsValidRoughness(System.Double)`

#### Summary

Identifies if the input roughness is valid.

#### Remarks

Roughness should be at least equal to or larger than 0.

#### Parameter `roughness`

The roughness to check.

#### Returns

True if the value is acceptable, false otherwise.

#### Since

2012

### `P:Autodesk.Revit.DB.Mechanical.DuctLiningType.Roughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctLiningType.Roughness`

#### Summary

The roughness of Duct Lining.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The roughness value should be at least equal to or larger than 0.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2012

### `T:Autodesk.Revit.DB.Mechanical.DuctLiningType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctLiningType`

#### Summary

This class represents a duct lining type in Autodesk Revit.

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.DuctLining.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctLining.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Creates a new instance of duct lining.

#### Parameter `document`

The document.

#### Parameter `ductOrContentElementId`

The duct, fitting or accessory ElementId to which lining will be added.

#### Parameter `ductLiningTypeId`

The duct lining type.
If the input duct lining type is InvalidElementId, the default lining type from the document will be used.

#### Parameter `Thickness`

The thickness of the lining.

#### Returns

The newly created duct lining.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This id does not represent a duct, fitting, or accessory element.
-or-
This duct Lining type is invalid.
-or-
Thickness is not valid for assignment to insulation or lining elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

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

2012

### `T:Autodesk.Revit.DB.Mechanical.DuctLining`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctLining`

#### Summary

Represents Lining applied to the inside of a given duct, fitting or accessory.

#### Since

2012

### `T:Autodesk.Revit.DB.Mechanical.DuctInsulationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctInsulationType`

#### Summary

This class represents a duct insulation type in Autodesk Revit.

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.DuctInsulation.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctInsulation.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Creates a new instance of duct insulation.

#### Parameter `document`

The document.

#### Parameter `ductOrContentElementId`

The duct , fitting or accessory ElementId to which insulation will be added.

#### Parameter `ductInsulationTypeId`

The duct insulation type.
If the input duct insulation type is InvalidElementId, the default insulation type from the document will be used.

#### Parameter `Thickness`

The thickness of the insulation.

#### Returns

The newly created duct insulation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This id does not represent a duct, fitting, or accessory element.
-or-
This duct insulation type is invalid.
-or-
Thickness is not valid for assignment to insulation or lining elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

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

2012

### `T:Autodesk.Revit.DB.Mechanical.DuctInsulation`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctInsulation`

#### Summary

Represents insulation applied to the outside of a given duct , fitting or accessory.

#### Since

2012

### `M:Autodesk.Revit.DB.InsulationLiningBase.IsValidThickness(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InsulationLiningBase.IsValidThickness(System.Double)`

#### Summary

Identifies if the given thickness value is valid for assignment to insulation or lining elements.

#### Parameter `thickness`

Thickness of the insulation and lining elements.

#### Returns

True if the thickness is valid, false otherwise.

#### Since

2012

### `M:Autodesk.Revit.DB.InsulationLiningBase.GetLiningIds(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InsulationLiningBase.GetLiningIds(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns the ids of the lining elements associated to a given element.

#### Parameter `document`

The document.

#### Parameter `elemId`

The element.

#### Returns

A collection of the ids of the lining elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This id does not represent a duct, fitting, or accessory element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.InsulationLiningBase.GetInsulationIds(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InsulationLiningBase.GetInsulationIds(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns the ids of the insulation elements associated to a given element.

#### Parameter `document`

The document.

#### Parameter `elemId`

The element.

#### Returns

A collection of the ids of the insulation elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This id does not represent a valid host for insulation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.InsulationLiningBase.HostElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.InsulationLiningBase.HostElementId`

#### Summary

The id of the host element for the insulation or lining element.

#### Since

2012

### `P:Autodesk.Revit.DB.InsulationLiningBase.Thickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.InsulationLiningBase.Thickness`

#### Summary

Thickness of the insulation or lining element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: Thickness is not valid for assignment to insulation or lining elements.

#### Since

2012

### `T:Autodesk.Revit.DB.InsulationLiningBase`

Member kind: type
Symbol: `Autodesk.Revit.DB.InsulationLiningBase`

#### Summary

Acts as the base class for duct insulation, pipe insulation and duct lining elements.

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.Duct.IsDuctTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.Duct.IsDuctTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if given type is valid duct type.

#### Remarks

A type is valid for duct if it can be used to the duct element.

#### Parameter `document`

The document.

#### Parameter `ductTypeId`

ElementId of the duct type to check.

#### Returns

True if duct type can used for this duct, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Mechanical.Duct.IsHvacSystemTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.Duct.IsHvacSystemTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if given type is valid HVAC system type.

#### Parameter `document`

The document.

#### Parameter `systemTypeId`

ElementId of the HVAC system type to check.

#### Returns

True if the given systemTypeId is the HVAC system type, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.Duct.SetSystemType(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.Duct.SetSystemType(Autodesk.Revit.DB.ElementId)`

#### Summary

Updates the associated system type for the duct.

#### Remarks

If the duct previously did not have a system associated to it, this will create a new system.

#### Parameter `systemTypeId`

The ElementId of the hvac system type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The systemTypeId is not valid HVAC system type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2017

### `M:Autodesk.Revit.DB.Mechanical.Duct.CreatePlaceholder(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.Duct.CreatePlaceholder(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new placeholder duct.

#### Parameter `document`

The document.

#### Parameter `systemTypeId`

The id of the HVAC system type.

#### Parameter `ductTypeId`

The id of the duct type.

#### Parameter `levelId`

The level id for the duct.

#### Parameter `startPoint`

The first point of the placeholder line.

#### Parameter `endPoint`

The second point of the placeholder line.

#### Returns

The created placeholder duct.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The systemTypeId is not valid HVAC system type.
-or-
The duct type ductTypeId is not valid duct type.
-or-
The ElementId levelId is not a Level.
-or-
The points of startPoint and endPoint are too close: for MEPCurve, the minimum length is 1/10 inch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.Duct.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.Duct.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Creates a new duct that connects to two connectors.

#### Remarks

The new duct will have the same diameter and system type as the start connector. The creation will also connect the new duct
to two component who owns the specified connectors. If necessary, additional fitting(s) are included to make a valid connection.
If the new duct can not be connected to the next component (e.g., mismatched direction, no valid fitting, and etc), the new duct
will still be created at the specified connector position, and an InvalidOperationException is thrown.

#### Parameter `document`

The document.

#### Parameter `ductTypeId`

The ElementId of the new duct type.

#### Parameter `levelId`

The level ElementId for the new duct.

#### Parameter `startConnector`

The first connector where the new duct starts.

#### Parameter `endConnector`

The second point of the new duct.

#### Returns

The created duct.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The duct type ductTypeId is not valid duct type.
-or-
The ElementId levelId is not a Level.
-or-
The connector's domain is not Domain.â€‹DomainHvac.
-or-
The points of startConnector and endConnector are too close: for MEPCurve, the minimum length is 1/10 inch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the new duct fails to connect with the connector.

#### Since

2017

### `M:Autodesk.Revit.DB.Mechanical.Duct.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.Duct.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new duct that connects to the connector.

#### Remarks

The new duct will have the same diameter and system type as the specified connector. The creation will also connect the new duct
to the component who owns the specified connector. If necessary, additional fitting(s) are included to make a valid connection.
If the new duct can not be connected to the next component (e.g., mismatched direction, no valid fitting, and etc), the new duct
will still be created at the specified connector position, and an InvalidOperationException is thrown.

#### Parameter `document`

The document.

#### Parameter `ductTypeId`

The ElementId of the new duct type.

#### Parameter `levelId`

The level id for the new duct.

#### Parameter `startConnector`

The first connector where the new duct starts.

#### Parameter `endPoint`

The second point of the new duct.

#### Returns

The created duct.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The duct type ductTypeId is not valid duct type.
-or-
The ElementId levelId is not a Level.
-or-
The connector's domain is not Domain.â€‹DomainHvac.
-or-
The points of startConnector and endPoint are too close: for MEPCurve, the minimum length is 1/10 inch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the new duct fails to connect with the connector.

#### Since

2017

### `M:Autodesk.Revit.DB.Mechanical.Duct.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.Duct.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new duct from two points.

#### Parameter `document`

The document.

#### Parameter `systemTypeId`

The id of the HVAC system type.

#### Parameter `ductTypeId`

The id of the duct type.

#### Parameter `levelId`

The level ElementId for the duct.

#### Parameter `startPoint`

The start point of the duct.

#### Parameter `endPoint`

The end point of the duct.

#### Returns

The created duct.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The systemTypeId is not valid HVAC system type.
-or-
The duct type ductTypeId is not valid duct type.
-or-
The ElementId levelId is not a Level.
-or-
The points of startPoint and endPoint are too close: for MEPCurve, the minimum length is 1/10 inch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.Duct.IsPlaceholder`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Duct.IsPlaceholder`

#### Summary

Identifies if the duct is a placeholder or not.

### `P:Autodesk.Revit.DB.Mechanical.Duct.DuctType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Duct.DuctType`

#### Summary

The duct type of this duct.

### `T:Autodesk.Revit.DB.Mechanical.Duct`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.Duct`

#### Summary

A duct in the Autodesk Revit MEP product.

#### Remarks

The duct is only available in the Autodesk Revit MEP product.

### `P:Autodesk.Revit.DB.MEPCurve.MEPSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurve.MEPSystem`

#### Summary

The system of the MEP curve.

#### Remarks

Returns the system of this MEP curve.
If the curve does not belong to any systems, the value will be `null` .
If the curve belongs to more than one system, the first available value is returned.

### `P:Autodesk.Revit.DB.MEPCurve.ReferenceLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurve.ReferenceLevel`

#### Summary

The reference level of the MEP curve.

#### Remarks

This property is used to retrieve the reference level of the MEP curve.
If the curve is not in a horizontal plane, this value will be the start point's reference level.

### `P:Autodesk.Revit.DB.MEPCurve.LevelOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurve.LevelOffset`

#### Summary

The offset of the MEP curve.

#### Remarks

This property is used to retrieve the offset of the MEP curve.
If the curve is not in a horizontal plane, this value will be the start point's offset.

### `P:Autodesk.Revit.DB.MEPCurve.Diameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurve.Diameter`

#### Summary

The diameter of the MEP curve.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the MEP curve's Shape is not round.

#### Remarks

This property is used to retrieve the diameter of the MEP curve.

### `P:Autodesk.Revit.DB.MEPCurve.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurve.Height`

#### Summary

The height of the MEP curve.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the MEP curve's Shape is not rectangular.

#### Remarks

This property is used to retrieve the height of the MEP curve.

### `P:Autodesk.Revit.DB.MEPCurve.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurve.Width`

#### Summary

The width of the MEP curve.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the MEP curve's shape is not rectangular.

#### Remarks

This property is used to retrieve the width of the MEP curve.

### `P:Autodesk.Revit.DB.MEPCurve.ConnectorManager`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurve.ConnectorManager`

#### Summary

The connector manager of this MEP curve.

### `T:Autodesk.Revit.DB.MEPCurve`

Member kind: type
Symbol: `Autodesk.Revit.DB.MEPCurve`

#### Summary

A curve object for duct or pipe blend elements.

#### Remarks

The curve object is only available in the Autodesk Revit MEP product.

### `M:Autodesk.Revit.DB.RoutingPreferenceManager.GetSharedSizes(System.Double,Autodesk.Revit.DB.ConnectorProfileType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingPreferenceManager.GetSharedSizes(System.Double,Autodesk.Revit.DB.ConnectorProfileType)`

#### Summary

Gets a list of all segments of a given profile shape that define a given size.

#### Parameter `size`

The size to search for.

#### Parameter `shape`

The profile shape of segment object.

#### Returns

A list of all segments that define a given size.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingPreferenceManager.GetMEPPartId(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType,Autodesk.Revit.DB.RoutingConditions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingPreferenceManager.GetMEPPartId(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType,Autodesk.Revit.DB.RoutingConditions)`

#### Summary

Gets a fitting or segment id of given routing preference group that meets the specified routing conditions.

#### Parameter `groupType`

The routing preference group

#### Parameter `conditions`

A set of routing conditions

#### Returns

The Id of the fitting or segment that met the given routing conditions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingPreferenceManager.RemoveRule(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingPreferenceManager.RemoveRule(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType,System.Int32)`

#### Summary

Removes an existing routing preference rule.
Thrown if the index is out of bounds.

#### Parameter `groupType`

The routing preference group type in which the rule should be removed.

#### Parameter `index`

The index position of removed routing preference rule in the group.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

index is not a valid zero-based index within groupType.
-or-

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingPreferenceManager.AddRule(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType,Autodesk.Revit.DB.RoutingPreferenceRule,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingPreferenceManager.AddRule(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType,Autodesk.Revit.DB.RoutingPreferenceRule,System.Int32)`

#### Summary

Adds a new routing preference rule to the specified position in the rule group.

#### Parameter `groupType`

The routing preference group type in which the rule should be added.

#### Parameter `rule`

The new rule to be added.

#### Parameter `index`

The zero-based index position where the new rule will be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

index is not a valid zero-based index within groupType.
-or-
The rule cannot be added to the groupType.
-or-
Thrown if the index is out of bounds, or the rule is not valid for this group (e.g. an elbow may not be added to the junction group).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingPreferenceManager.AddRule(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType,Autodesk.Revit.DB.RoutingPreferenceRule)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingPreferenceManager.AddRule(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType,Autodesk.Revit.DB.RoutingPreferenceRule)`

#### Summary

Adds a new routing preference rule to the rule group.

#### Parameter `groupType`

The routing preference group in which the rule should be added.

#### Parameter `rule`

The new rule to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The rule cannot be added to the groupType.
-or-
Thrown if the index is out of bounds, or the rule is not valid for this group (e.g. an elbow may not be added to the junction group).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingPreferenceManager.GetRule(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingPreferenceManager.GetRule(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType,System.Int32)`

#### Summary

Gets the specified rule.

#### Parameter `groupType`

The routing preference group type from which the rule should be returned.

#### Parameter `index`

The zero-based index where the rule should be returned.

#### Returns

The rule at the specified group and zero-based index position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

index is not a valid zero-based index within groupType.
-or-
Thrown if the index is out of bounds

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingPreferenceManager.GetNumberOfRules(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingPreferenceManager.GetNumberOfRules(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType)`

#### Summary

The number of RoutingPreference rules in a group.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.RoutingPreferenceManager.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingPreferenceManager.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RoutingPreferenceManager.OwnerId`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingPreferenceManager.OwnerId`

#### Summary

The Id of the MEPCurveType that owns the RoutingPreferenceManager

#### Since

2013

### `P:Autodesk.Revit.DB.RoutingPreferenceManager.PreferredJunctionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingPreferenceManager.PreferredJunctionType`

#### Summary

The preferred junction type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `T:Autodesk.Revit.DB.RoutingPreferenceManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.RoutingPreferenceManager`

#### Summary

Manages default pipe segments, fittings, and selection criteria for a given MEPCurveType

#### Remarks

MEPCurveTypes contain a RoutingPreferenceManager property.
The RoutingPreferenceManager contains rules for selecting segment types and sizes as well as fitting types based on user selection criteria.

#### Since

2013

### `T:Autodesk.Revit.DB.PreferredJunctionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.PreferredJunctionType`

#### Since

2013

#### Summary

Enumerated type representing the possible options for the preferred junction for a routine preference rule.

#### Since

2013

### `F:Autodesk.Revit.DB.PreferredJunctionType.Tap`

Member kind: field
Symbol: `Autodesk.Revit.DB.PreferredJunctionType.Tap`

#### Summary

Tap junction type.

### `F:Autodesk.Revit.DB.PreferredJunctionType.Tee`

Member kind: field
Symbol: `Autodesk.Revit.DB.PreferredJunctionType.Tee`

#### Summary

Tee junction type.

### `T:Autodesk.Revit.DB.RoutingPreferenceRuleGroupType`

Member kind: type
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRuleGroupType`

#### Since

2013

#### Summary

Add more rule group type here.

#### Since

2013

### `F:Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Caps`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Caps`

#### Summary

The cap types

### `F:Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.TransitionsOvalToRound`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.TransitionsOvalToRound`

#### Summary

The multi-shape transition from the oval profile to the round profile.

### `F:Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.TransitionsRectangularToOval`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.TransitionsRectangularToOval`

#### Summary

The multi-shape transition from the rectangular profile to the oval profile.

### `F:Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.TransitionsRectangularToRound`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.TransitionsRectangularToRound`

#### Summary

The multi-shape transition from the rectangular profile to the round profile.

### `F:Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.MechanicalJoints`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.MechanicalJoints`

#### Summary

The mechanical joint types that connect fitting to fitting, segment to fitting, or segment to segment.

### `F:Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Unions`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Unions`

#### Summary

The union types that connect two segments together.

### `F:Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Transitions`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Transitions`

#### Summary

The transition types (Note that the multi-shape transitions may have their own groups).

### `F:Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Crosses`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Crosses`

#### Summary

The cross types.

### `F:Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Junctions`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Junctions`

#### Summary

The junction types (e.g. takeoff, tee, wye, tap).

### `F:Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Elbows`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Elbows`

#### Summary

The elbow types.

### `F:Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Segments`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Segments`

#### Summary

The segment types (e.g. pipe stocks)

### `F:Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRuleGroupType.Undefined`

#### Summary

The undefined group type, the default initial value.

### `P:Autodesk.Revit.DB.MEPCurveType.Shape`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurveType.Shape`

#### Summary

The shape of the profile.

#### Since

2019

### `P:Autodesk.Revit.DB.MEPCurveType.RoutingPreferenceManager`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurveType.RoutingPreferenceManager`

#### Summary

The RoutingPreferenceManager for the MEPCurveType

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `P:Autodesk.Revit.DB.MEPCurveType.MultiShapeTransition`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurveType.MultiShapeTransition`

#### Summary

The default multi shape transition fitting of the MEP curve type.

#### Remarks

This property is used to retrieve the default multi shape transition fitting of the MEP curve type,
and can be `null` if there is no default value.
Use `T:Autodesk.Revit.DB.RoutingPreferenceManager` to set this property for PipeType MEPCurves.

### `P:Autodesk.Revit.DB.MEPCurveType.Elbow`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurveType.Elbow`

#### Summary

The default elbow fitting of the MEP curve type.

#### Remarks

This property is used to retrieve the default elbow fitting of the MEP curve type,
and can be `null` if there is no default value.
Use `T:Autodesk.Revit.DB.RoutingPreferenceManager` to set this property for PipeType MEPCurves.

### `P:Autodesk.Revit.DB.MEPCurveType.Cross`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurveType.Cross`

#### Summary

The default cross fitting of the MEP curve type.

#### Remarks

This property is used to retrieve the default cross fitting of the MEP curve type,
and can be `null` if there is no default value.
Use `T:Autodesk.Revit.DB.RoutingPreferenceManager` to set this property for PipeType MEPCurves.

### `P:Autodesk.Revit.DB.MEPCurveType.Union`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurveType.Union`

#### Summary

The default union fitting of the MEP curve type.

#### Remarks

This property is used to retrieve the default union fitting of the MEP curve type,
and can be `null` if there is no default value.
Use `T:Autodesk.Revit.DB.RoutingPreferenceManager` to set this property for PipeType MEPCurves.

### `P:Autodesk.Revit.DB.MEPCurveType.Transition`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurveType.Transition`

#### Summary

The default transition fitting of the MEP curve type.

#### Remarks

This property is used to retrieve the default transition fitting of the MEP curve type,
and can be `null` if there is no default value.
Use `T:Autodesk.Revit.DB.RoutingPreferenceManager` to set this property for PipeType MEPCurves.

### `P:Autodesk.Revit.DB.MEPCurveType.Tap`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurveType.Tap`

#### Summary

The default tap fitting of the MEP curve type.

#### Remarks

This property is used to retrieve the default tap fitting of the MEP curve type,
and can be `null` if there is no default value.
Use `T:Autodesk.Revit.DB.RoutingPreferenceManager` to set this property for PipeType MEPCurves.

### `P:Autodesk.Revit.DB.MEPCurveType.Tee`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurveType.Tee`

#### Summary

The default tee fitting of the MEP curve type.

#### Remarks

This property is used to retrieve the default tee fitting of the MEP curve type,
and can be `null` if there is no default value.
Use `T:Autodesk.Revit.DB.RoutingPreferenceManager` to set this property for PipeType MEPCurves.

### `P:Autodesk.Revit.DB.MEPCurveType.PreferredJunctionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurveType.PreferredJunctionType`

#### Summary

The preferred junction type of the MEP curve type.

#### Remarks

Use `T:Autodesk.Revit.DB.RoutingPreferenceManager` to set this property for PipeType MEPCurves.

### `P:Autodesk.Revit.DB.MEPCurveType.Roughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPCurveType.Roughness`

#### Summary

The roughness of the MEP curve type. For PipeTypes, please use Segment::Roughness

### `T:Autodesk.Revit.DB.MEPCurveType`

Member kind: type
Symbol: `Autodesk.Revit.DB.MEPCurveType`

#### Summary

The base type class for MEP curves, such as ducts, pipes, cable trays and conduits.

### `T:Autodesk.Revit.DB.Architecture.RailIndex`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailIndex`

#### Summary

The continuous rail position index.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailIndex.RightSecondary`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailIndex.RightSecondary`

#### Summary

The rail is a secondary rail on the right.

### `F:Autodesk.Revit.DB.Architecture.RailIndex.LeftSecondary`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailIndex.LeftSecondary`

#### Summary

The rail is a secondary rail on the left.

### `F:Autodesk.Revit.DB.Architecture.RailIndex.RightPrimary`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailIndex.RightPrimary`

#### Summary

The rail is a primary rail on the right.

### `F:Autodesk.Revit.DB.Architecture.RailIndex.LeftPrimary`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailIndex.LeftPrimary`

#### Summary

The rail is a primary rail on the left.

### `F:Autodesk.Revit.DB.Architecture.RailIndex.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailIndex.Top`

#### Summary

The rail is located on the top of the railing.

### `T:Autodesk.Revit.DB.Architecture.RailingPathCurveJoinOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailingPathCurveJoinOption`

#### Summary

The join type of the railing path.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailingPathCurveJoinOption.NoConnector`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailingPathCurveJoinOption.NoConnector`

#### Summary

No connector.

### `F:Autodesk.Revit.DB.Architecture.RailingPathCurveJoinOption.AddVerticalOrHorizontalSegments`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailingPathCurveJoinOption.AddVerticalOrHorizontalSegments`

#### Summary

Add vertical or horizontal segments.

### `F:Autodesk.Revit.DB.Architecture.RailingPathCurveJoinOption.ExtendRailsToMeet`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailingPathCurveJoinOption.ExtendRailsToMeet`

#### Summary

Extend rails to meet.

### `F:Autodesk.Revit.DB.Architecture.RailingPathCurveJoinOption.ByType`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailingPathCurveJoinOption.ByType`

#### Summary

The rails will be joined according to the settings in the rail type.

### `T:Autodesk.Revit.DB.Architecture.RailTagentJoinOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailTagentJoinOption`

#### Summary

The tangent joins of the rails.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailTagentJoinOption.ExtendRailsToMeet`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailTagentJoinOption.ExtendRailsToMeet`

#### Summary

Extend rails to meet.

### `F:Autodesk.Revit.DB.Architecture.RailTagentJoinOption.NoConnector`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailTagentJoinOption.NoConnector`

#### Summary

No connector.

### `F:Autodesk.Revit.DB.Architecture.RailTagentJoinOption.AddVerticalOrHorizontalSegments`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailTagentJoinOption.AddVerticalOrHorizontalSegments`

#### Summary

Add vertical or horizontal segments.

### `T:Autodesk.Revit.DB.Architecture.RailAngledJoinOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailAngledJoinOption`

#### Summary

The angled joins of the rails.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailAngledJoinOption.NoConnector`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailAngledJoinOption.NoConnector`

#### Summary

No connector.

### `F:Autodesk.Revit.DB.Architecture.RailAngledJoinOption.AddVerticalOrHorizontalSegments`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailAngledJoinOption.AddVerticalOrHorizontalSegments`

#### Summary

Add vertical or horizontal segments.

### `T:Autodesk.Revit.DB.Architecture.RailingSlopeOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailingSlopeOption`

#### Summary

The option determines the slope of the railing.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailingSlopeOption.Sloped`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailingSlopeOption.Sloped`

#### Summary

The slope of the railing will be specified by users.

### `F:Autodesk.Revit.DB.Architecture.RailingSlopeOption.Flat`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailingSlopeOption.Flat`

#### Summary

The slope of the railing will be kept flat.

### `F:Autodesk.Revit.DB.Architecture.RailingSlopeOption.ByHost`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailingSlopeOption.ByHost`

#### Summary

The slope of the railing is determined by its host.

### `T:Autodesk.Revit.DB.Architecture.RailingHeightCorrectionOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailingHeightCorrectionOption`

#### Summary

Railing height correction option.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailingHeightCorrectionOption.Custom`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailingHeightCorrectionOption.Custom`

#### Summary

User needs to define the height value of the railing.

### `F:Autodesk.Revit.DB.Architecture.RailingHeightCorrectionOption.ByType`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailingHeightCorrectionOption.ByType`

#### Summary

Railing height is determined by railing type.

### `T:Autodesk.Revit.DB.Architecture.RailingPlacementPosition`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailingPlacementPosition`

#### Summary

Railing placement position.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailingPlacementPosition.Stringer`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailingPlacementPosition.Stringer`

#### Summary

Places railing on stringer.

### `F:Autodesk.Revit.DB.Architecture.RailingPlacementPosition.Treads`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailingPlacementPosition.Treads`

#### Summary

Places railing on treads.

### `F:Autodesk.Revit.DB.Architecture.RailingPlacementPosition.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailingPlacementPosition.Undefined`

#### Summary

No railing placement.

### `T:Autodesk.Revit.DB.Architecture.RailTransitionOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailTransitionOption`

#### Summary

The transition type of the continuous rail.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailTransitionOption.Simple`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailTransitionOption.Simple`

#### Summary

Simple

### `F:Autodesk.Revit.DB.Architecture.RailTransitionOption.Gooseneck`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailTransitionOption.Gooseneck`

#### Summary

Gooseneck.

### `F:Autodesk.Revit.DB.Architecture.RailTransitionOption.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailTransitionOption.None`

#### Summary

No transition.

### `T:Autodesk.Revit.DB.Architecture.HandRailPosition`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.HandRailPosition`

#### Summary

The position of the hand rail.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.HandRailPosition.LeftAndRight`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.HandRailPosition.LeftAndRight`

#### Summary

The handrail is on both sides of the railing.

### `F:Autodesk.Revit.DB.Architecture.HandRailPosition.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.HandRailPosition.Right`

#### Summary

The hand rail is on the right side of railing.

### `F:Autodesk.Revit.DB.Architecture.HandRailPosition.Left`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.HandRailPosition.Left`

#### Summary

The hand rail is on the left side of railing.

### `F:Autodesk.Revit.DB.Architecture.HandRailPosition.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.HandRailPosition.None`

#### Summary

No hand rail

### `T:Autodesk.Revit.DB.Architecture.RailSupportJustification`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailSupportJustification`

#### Summary

The justification of the rail supports.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailSupportJustification.End`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailSupportJustification.End`

#### Summary

Supports are justified to the end of the rail.

### `F:Autodesk.Revit.DB.Architecture.RailSupportJustification.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailSupportJustification.Center`

#### Summary

Supports are justified to the center of the rail.

### `F:Autodesk.Revit.DB.Architecture.RailSupportJustification.Begin`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailSupportJustification.Begin`

#### Summary

Supports are justified to the beginning of the rail.

### `T:Autodesk.Revit.DB.Architecture.RailSupportsLayout`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailSupportsLayout`

#### Summary

The layout of the rail supports.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailSupportsLayout.MinSpacing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailSupportsLayout.MinSpacing`

#### Summary

The rail supports are laid out with a minimum spacing.

### `F:Autodesk.Revit.DB.Architecture.RailSupportsLayout.MaxSpacing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailSupportsLayout.MaxSpacing`

#### Summary

The rail supports are laid out with a maximum spacing.

### `F:Autodesk.Revit.DB.Architecture.RailSupportsLayout.FixedNumber`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailSupportsLayout.FixedNumber`

#### Summary

The rail supports are laid out with a specified fixed number.

### `F:Autodesk.Revit.DB.Architecture.RailSupportsLayout.AlignWithRailingPosts`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailSupportsLayout.AlignWithRailingPosts`

#### Summary

The rail supports are laid out aligned with the railing posts.

### `F:Autodesk.Revit.DB.Architecture.RailSupportsLayout.FixedDistance`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailSupportsLayout.FixedDistance`

#### Summary

The rail supports are laid out on a fixed distance spacing.

### `F:Autodesk.Revit.DB.Architecture.RailSupportsLayout.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailSupportsLayout.None`

#### Summary

No rail support.

### `T:Autodesk.Revit.DB.Architecture.RailConnectionOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailConnectionOption`

#### Summary

The connections between rails.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailConnectionOption.Weld`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailConnectionOption.Weld`

#### Summary

Rails will be joined in a manner as close to a miter as possible.

### `F:Autodesk.Revit.DB.Architecture.RailConnectionOption.Trim`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailConnectionOption.Trim`

#### Summary

Rails will be trimmed and cut with a vertical plane.

### `T:Autodesk.Revit.DB.Architecture.RailTypeDefaultJoinOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailTypeDefaultJoinOption`

#### Summary

The default join type of the rail.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailTypeDefaultJoinOption.Fillet`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailTypeDefaultJoinOption.Fillet`

#### Summary

The rails will be joined by a fillet connection.

### `F:Autodesk.Revit.DB.Architecture.RailTypeDefaultJoinOption.Miter`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailTypeDefaultJoinOption.Miter`

#### Summary

The rails will be joined by a miter connection.

### `T:Autodesk.Revit.DB.Architecture.RailJoinOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailJoinOption`

#### Summary

The join type of the system rails.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailJoinOption.Fillet`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailJoinOption.Fillet`

#### Summary

The rails will be joined by a fillet connection.

### `F:Autodesk.Revit.DB.Architecture.RailJoinOption.Miter`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailJoinOption.Miter`

#### Summary

The rails will be joined by a miter connection.

### `F:Autodesk.Revit.DB.Architecture.RailJoinOption.ByType`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailJoinOption.ByType`

#### Summary

The rails will be joined according to the settings in the rail type.

### `T:Autodesk.Revit.DB.Architecture.RailExtensionStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailExtensionStyle`

#### Summary

The extension style of the rail.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RailExtensionStyle.Post`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailExtensionStyle.Post`

#### Summary

The rail extends to post.

### `F:Autodesk.Revit.DB.Architecture.RailExtensionStyle.Floor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailExtensionStyle.Floor`

#### Summary

The rail extends to floor.

### `F:Autodesk.Revit.DB.Architecture.RailExtensionStyle.Wall`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailExtensionStyle.Wall`

#### Summary

The rail extends to wall.

### `F:Autodesk.Revit.DB.Architecture.RailExtensionStyle.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RailExtensionStyle.None`

#### Summary

The rail extends to nothing

### `M:Autodesk.Revit.DB.RadialArray.IsRotationAngleValid(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RadialArray.IsRotationAngleValid(System.Double)`

#### Summary

This indicates whether the input angle is valid.

#### Parameter `angle`

The angle.

#### Returns

True if the value of angle is not zero, false otherwise.

### `M:Autodesk.Revit.DB.RadialArray.IsValidArraySize(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RadialArray.IsValidArraySize(System.Int32)`

#### Summary

This indicates whether the input count is valid.

#### Parameter `count`

The count.

#### Returns

True if the input count is between 3 and 200, false otherwise.

### `M:Autodesk.Revit.DB.RadialArray.ArrayElementWithoutAssociation(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.Line,System.Double,Autodesk.Revit.DB.ArrayAnchorMember)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RadialArray.ArrayElementWithoutAssociation(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.Line,System.Double,Autodesk.Revit.DB.ArrayAnchorMember)`

#### Summary

Creates a new radial array from a single element based
on an input rotation axis.

#### Remarks

The resulting elements will not be associated with an array element.

#### Parameter `aDoc`

The view. If it is a 2d view, translation vector must be in the view plane if the element is a view-specific element.

#### Parameter `dBView`

The view.

#### Parameter `id`

The element to array. The position of the rotation
axis is determined by the center of the element's bounding boxes.

#### Parameter `count`

The number of array members to create. The accepted range is from 3 to 200.

#### Parameter `axis`

The rotation axis.

#### Parameter `angle`

The angle in radians of the rotation.

#### Parameter `anchorMember`

Indicates if the translation vector specifies the location of the second member
of the array, or the last member of the array.

#### Returns

The elements created by the operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id does not exist in the document
-or-
id is not arrayable.
-or-
count must be between 3 and 200.
-or-
The view is invalid for specific view elements array.
-or-
The rotation axis is invalid to array the element.
-or-
Angle value must be not zero.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the radial array.

### `M:Autodesk.Revit.DB.RadialArray.ArrayElementsWithoutAssociation(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Int32,Autodesk.Revit.DB.Line,System.Double,Autodesk.Revit.DB.ArrayAnchorMember)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RadialArray.ArrayElementsWithoutAssociation(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Int32,Autodesk.Revit.DB.Line,System.Double,Autodesk.Revit.DB.ArrayAnchorMember)`

#### Summary

Creates a new radial array from a set of elements based
on an input rotation axis.

#### Remarks

The resulting elements will not be associated with an array element.

#### Parameter `aDoc`

The document.

#### Parameter `dBView`

The view. If it is a 2d view, translation vector must be in the view plane if elements include view-specific elements.
If elements include view-specific elements, they must belong to this view.

#### Parameter `ids`

The set of elements to array. The position of the rotation
axis is determined by the cumulative center of the elements' bounding boxes.

#### Parameter `count`

The number of array members to create. The accepted range is from 3 to 200.

#### Parameter `axis`

The rotation axis.

#### Parameter `angle`

The angle in radians of the rotation.

#### Parameter `anchorMember`

Indicates if the translation vector specifies the location of the second member
of the array, or the last member of the array.

#### Returns

The elements created by the operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element id set is empty.
-or-
One or more elements in ids do not exist in the document.
-or-
One or more elements in ids is owned by different views and thus cannot be arrayed together.
-or-
One or more elements in ids is not arrayable.
-or-
count must be between 3 and 200.
-or-
The view is invalid for specific view elements array.
-or-
The rotation axis is invalid to array the elements.
-or-
Angle value must be not zero.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the radial array.

### `M:Autodesk.Revit.DB.RadialArray.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.Line,System.Double,Autodesk.Revit.DB.ArrayAnchorMember)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RadialArray.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.Line,System.Double,Autodesk.Revit.DB.ArrayAnchorMember)`

#### Summary

Creates a new radial array element from a single element based
on an input rotation axis.

#### Parameter `aDoc`

The document.

#### Parameter `dBView`

The view. If it is a 2d view, translation vector must be in the view plane if the element is a view-specific element.

#### Parameter `id`

The element to array. The position of the rotation
axis is determined by the center of the element's bounding boxes.

#### Parameter `count`

The number of array members to create. The accepted range is from 3 to 200.

#### Parameter `axis`

The rotation axis.

#### Parameter `angle`

The angle in radians of the rotation.

#### Parameter `anchorMember`

Indicates if the translation vector specifies the location of the second member
of the array, or the last member of the array.

#### Returns

The new radial array element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id does not exist in the document
-or-
id is not arrayable.
-or-
count must be between 3 and 200.
-or-
The view is invalid for specific view elements array.
-or-
The rotation axis is invalid to array the element.
-or-
Angle value must be not zero.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the radial array.

### `M:Autodesk.Revit.DB.RadialArray.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Int32,Autodesk.Revit.DB.Line,System.Double,Autodesk.Revit.DB.ArrayAnchorMember)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RadialArray.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Int32,Autodesk.Revit.DB.Line,System.Double,Autodesk.Revit.DB.ArrayAnchorMember)`

#### Summary

Creates a new radial array element from a set of elements based
on an input rotation axis.

#### Parameter `aDoc`

The document.

#### Parameter `dBView`

The view. If it is a 2d view, translation vector must be in the view plane if elements include view-specific elements.
If elements include view-specific elements, they must belong to this view.

#### Parameter `ids`

The set of elements to array. The position of the rotation
axis is determined by the cumulative center of the elements' bounding boxes.

#### Parameter `count`

The number of array members to create. The accepted range is from 3 to 200.

#### Parameter `axis`

The rotation axis.

#### Parameter `angle`

The angle in radians of the rotation.

#### Parameter `anchorMember`

Indicates if the translation vector specifies the location of the second member
of the array, or the last member of the array.

#### Returns

The new radial array element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element id set is empty.
-or-
One or more elements in ids do not exist in the document.
-or-
One or more elements in ids is owned by different views and thus cannot be arrayed together.
-or-
One or more elements in ids is not arrayable.
-or-
count must be between 3 and 200.
-or-
The view is invalid for specific view elements array.
-or-
The rotation axis is invalid to array the elements.
-or-
Angle value must be not zero.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the radial array.

### `M:Autodesk.Revit.DB.RadialArray.GetCopiedMemberIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.RadialArray.GetCopiedMemberIds`

#### Summary

Retrieves the copied member Ids of the Array.

#### Returns

The copied member Ids of the Array

#### Since

2013

### `M:Autodesk.Revit.DB.RadialArray.GetOriginalMemberIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.RadialArray.GetOriginalMemberIds`

#### Summary

Retrieves the original member Ids of the Array.

#### Returns

The original member Ids of the Array

#### Since

2013

### `P:Autodesk.Revit.DB.RadialArray.NumMembers`

Member kind: property
Symbol: `Autodesk.Revit.DB.RadialArray.NumMembers`

#### Summary

Retrieves or changes the number of the arrayed members.

### `T:Autodesk.Revit.DB.RadialArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.RadialArray`

#### Summary

An object that represents an Array created along a circle arc within the Revit project.

### `M:Autodesk.Revit.DB.LinearArray.IsElementArrayable(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinearArray.IsElementArrayable(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Indicates whether the input element is arrayable.

#### Parameter `aDoc`

The document.

#### Parameter `id`

The element id.

#### Returns

True if the input element is arrayable, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.LinearArray.IsValidArraySize(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinearArray.IsValidArraySize(System.Int32)`

#### Summary

This indicates whether the input count is valid.

#### Parameter `count`

The count.

#### Returns

True if the input count is between 2 and 200, false otherwise.

### `M:Autodesk.Revit.DB.LinearArray.ArrayElementWithoutAssociation(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ArrayAnchorMember)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinearArray.ArrayElementWithoutAssociation(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ArrayAnchorMember)`

#### Summary

Creates a new linear array from a single element.

#### Remarks

The resulting elements will not be associated with an array element.

#### Parameter `aDoc`

The document.

#### Parameter `dBView`

The view. If it is a 2d view, translation vector must be in the view plane if the element is a view-specific element.

#### Parameter `id`

The element to array.

#### Parameter `count`

The number of array members to create including the initial
element grouping. Must between 2 and 200.

#### Parameter `translationToAnchorMember`

The translation vector for the array.

#### Parameter `anchorMember`

Indicates if the translation vector specifies the location of the second member
of the array, or the last member of the array.

#### Returns

The ids of the elements created during the operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id does not exist in the document
-or-
id is not arrayable.
-or-
count must be between 2 and 200.
-or-
The view is invalid for specific view elements array.
-or-
The translation point vector is invalid to array the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the linear array.

### `M:Autodesk.Revit.DB.LinearArray.ArrayElementsWithoutAssociation(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Int32,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ArrayAnchorMember)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinearArray.ArrayElementsWithoutAssociation(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Int32,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ArrayAnchorMember)`

#### Summary

Creates a new linear array from a set of elements.

#### Remarks

The resulting elements will not be associated with an array element.

#### Parameter `aDoc`

The document.

#### Parameter `dBView`

The view. If it is a 2d view, translation vector must be in the view plane if elements include view-specific elements.
If elements include view-specific elements, they must belong to this view.

#### Parameter `ids`

The elements to array.

#### Parameter `count`

The number of array members to create including the initial
element grouping. Must between 2 and 200.

#### Parameter `translationToAnchorMember`

The translation vector for the array.

#### Parameter `anchorMember`

Indicates if the translation vector specifies the location of the second member
of the array, or the last member of the array.

#### Returns

The ids of the elements created during the operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element id set is empty.
-or-
One or more elements in ids do not exist in the document.
-or-
One or more elements in ids is owned by different views and thus cannot be arrayed together.
-or-
One or more elements in ids is not arrayable.
-or-
count must be between 2 and 200.
-or-
The view is invalid for specific view elements array.
-or-
The translation point vector is invalid to array the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the linear array.

### `M:Autodesk.Revit.DB.LinearArray.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ArrayAnchorMember)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinearArray.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ArrayAnchorMember)`

#### Summary

Creates a new linear array element from a single element.

#### Parameter `aDoc`

The document.

#### Parameter `dBView`

The view. If it is a 2d view, translation vector must be in the view plane if the element is a view-specific element.

#### Parameter `id`

The element to array.

#### Parameter `count`

The number of array members to create including the initial
element grouping. Must between 2 and 200.

#### Parameter `translationToAnchorMember`

The translation vector for the array.

#### Parameter `anchorMember`

Indicates if the translation vector specifies the location of the second member
of the array, or the last member of the array.

#### Returns

The new linear array element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id does not exist in the document
-or-
id is not arrayable.
-or-
count must be between 2 and 200.
-or-
The view is invalid for specific view elements array.
-or-
The translation point vector is invalid to array the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the linear array.

### `M:Autodesk.Revit.DB.LinearArray.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Int32,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ArrayAnchorMember)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinearArray.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Int32,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ArrayAnchorMember)`

#### Summary

Creates a new linear array element from a set of elements.

#### Parameter `aDoc`

The document.

#### Parameter `dBView`

The view. If it is a 2d view, translation vector must be in the view plane if elements include view-specific elements.
If elements include view-specific elements, they must belong to this view.

#### Parameter `ids`

The elements to array.

#### Parameter `count`

The number of array members to create including the initial
element grouping. Must between 2 and 200.

#### Parameter `translationToAnchorMember`

The translation vector for the array.

#### Parameter `anchorMember`

Indicates if the translation vector specifies the location of the second member
of the array, or the last member of the array.

#### Returns

The new linear array element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element id set is empty.
-or-
One or more elements in ids do not exist in the document.
-or-
One or more elements in ids is owned by different views and thus cannot be arrayed together.
-or-
One or more elements in ids is not arrayable.
-or-
count must be between 2 and 200.
-or-
The view is invalid for specific view elements array.
-or-
The translation point vector is invalid to array the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the linear array.

### `M:Autodesk.Revit.DB.LinearArray.GetCopiedMemberIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinearArray.GetCopiedMemberIds`

#### Summary

Retrieves the copied member Ids of the Array.

#### Returns

The copied member Ids of the Array

#### Since

2013

### `M:Autodesk.Revit.DB.LinearArray.GetOriginalMemberIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinearArray.GetOriginalMemberIds`

#### Summary

Retrieves the original member Ids of the Array.

#### Returns

The original member Ids of the Array

#### Since

2013

### `P:Autodesk.Revit.DB.LinearArray.NumMembers`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinearArray.NumMembers`

#### Summary

Retrieves or changes the number of the arrayed members.

### `T:Autodesk.Revit.DB.LinearArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinearArray`

#### Summary

An object that represents an Array created linearly within the Revit project.

### `T:Autodesk.Revit.DB.ArrayAnchorMember`

Member kind: type
Symbol: `Autodesk.Revit.DB.ArrayAnchorMember`

#### Summary

Represents the possible choices for how the translation or rotation is used to place each member of the array.

#### Since

2012

### `F:Autodesk.Revit.DB.ArrayAnchorMember.Last`

Member kind: field
Symbol: `Autodesk.Revit.DB.ArrayAnchorMember.Last`

#### Summary

The translation or rotation value specifies the location of the last member of the array.

### `F:Autodesk.Revit.DB.ArrayAnchorMember.Second`

Member kind: field
Symbol: `Autodesk.Revit.DB.ArrayAnchorMember.Second`

#### Summary

The translation or rotation value specifies the location of the second member of the array.

### `M:Autodesk.Revit.DB.FreeFormElement.UpdateSolidGeometry(Autodesk.Revit.DB.Solid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FreeFormElement.UpdateSolidGeometry(Autodesk.Revit.DB.Solid)`

#### Summary

Updates the geometry of the FreeForm element to the given shape preserving References to the existing geometry where possible (see remarks for rules).

#### Remarks

Rules for preserving References:
First preserve faces as Reference when exclusively coincident with existing faces.

Then preserve faces as Reference if exclusively parallel to existing faces.

Then preserve faces as Reference if exclusive at small angle to the existing faces.

Any other faces are will not be preserved as a Reference.
Edges are preserved as References if and only if exclusively bound to faces that are also preserved as References.

#### Parameter `newGeometry`

The new geometry to set in the FreeForm element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.FreeFormElement.CanOffsetFace(Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FreeFormElement.CanOffsetFace(Autodesk.Revit.DB.Face)`

#### Summary

Determines if the input face of the FreeFormElement can be offset.

#### Parameter `face`

The face to be checked.

#### Returns

True if the face can be offset, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FreeFormElement.SetFaceOffset(Autodesk.Revit.DB.Face,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FreeFormElement.SetFaceOffset(Autodesk.Revit.DB.Face,System.Double)`

#### Summary

Offsets a planar face of the free form element a certain distance in the normal direction.

#### Parameter `face`

The face to offset.

#### Parameter `offset`

The magnitude of the offset. A positive value offsets out of the input solid. A negative value offsets into the solid shape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

face does not belong to the solid.
-or-
The face to be offset should be planar and satisfy constraints of its parent element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FreeFormElement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Solid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FreeFormElement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Solid)`

#### Summary

Creates a new FreeFormElement from a copy of the input geometry.

#### Parameter `document`

The document in which the element is to be created.

#### Parameter `geometry`

The input geometry.

#### Returns

returns a new FreeFormElement

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a family document, nor a document editing an in-place family.

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

### `T:Autodesk.Revit.DB.FreeFormElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.FreeFormElement`

#### Summary

A Free Form Element that contains non-parametric geometry created from an input solid outline.

#### Remarks

The element can participate in joins and void cuts with other combinable elements.

#### Since

2014

### `M:Autodesk.Revit.DB.Frame.IsRightHanded`

Member kind: method
Symbol: `Autodesk.Revit.DB.Frame.IsRightHanded`

#### Summary

Determine if this frame's basis is right-handed.

#### Remarks

The three basis vectors are "right-handed" if the triple vector product [vecX, vecY, vecZ]
is positive, or equivalently if dot(vecX x vecY, vecZ) is positive, where "dot" represents the dot product.

#### Returns

True if this frame's basis is right-handed, false if not.

#### Since

2012

### `M:Autodesk.Revit.DB.Frame.IsOrthonormal`

Member kind: method
Symbol: `Autodesk.Revit.DB.Frame.IsOrthonormal`

#### Summary

Determines if this frame's basis vectors are orthonormal.

#### Remarks

"Orthonormal" means that the three vectors are orthogonal and each of them has unit length.

#### Returns

True if this frame's basis vectors are orthonormal, false if not.

#### Since

2012

### `M:Autodesk.Revit.DB.Frame.IsOrthogonal`

Member kind: method
Symbol: `Autodesk.Revit.DB.Frame.IsOrthogonal`

#### Summary

Determines if this frame's basis vectors are orthogonal.

#### Returns

True if this frame's basis vectors are orthogonal, false if not.

#### Since

2012

### `M:Autodesk.Revit.DB.Frame.Transform(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Frame.Transform(Autodesk.Revit.DB.Transform)`

#### Summary

Applies the input transform to this frame.

#### Parameter `trf`

The transform to apply to the frame.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

this operation failed.

#### Since

2012

### `M:Autodesk.Revit.DB.Frame.CanDefineRevitGeometry(Autodesk.Revit.DB.Frame)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Frame.CanDefineRevitGeometry(Autodesk.Revit.DB.Frame)`

#### Summary

Tests whether the supplied Frame object may be used to define a Revit curve or surface.
In order to satisfy the requirements the Frame must be orthonormal
and its origin is expected to lie within the Revit design limits `M:Autodesk.Revit.DB.XYZ.IsWithinLengthLimits(Autodesk.Revit.DB.XYZ)` .

#### Remarks

Certain Revit curve and surface types are defined using a local frame of reference.

#### Parameter `frameOfReference`

Frame to be validated.

#### Returns

True if this Frame may be used as a local frame of reference, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Frame.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Frame.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Frame.BasisZ`

Member kind: property
Symbol: `Autodesk.Revit.DB.Frame.BasisZ`

#### Summary

The third basis vector of the frame.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Frame.BasisY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Frame.BasisY`

#### Summary

The second basis vector of the frame.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Frame.BasisX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Frame.BasisX`

#### Summary

The first basis vector of the frame.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Frame.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.Frame.Origin`

#### Summary

The frame's base point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Frame.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Frame.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Constructor that takes the frame's base point and three basis vectors.

#### Parameter `origin`

The frame's base point.

#### Parameter `vec1`

The frame's first basis vector.

#### Parameter `vec2`

The frame's second basis vector.

#### Parameter `vec3`

The frame's third basis vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Frame.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Frame.#ctor`

#### Summary

Default constructor. Uses global origin and standard basis vectors.

#### Since

2012

### `T:Autodesk.Revit.DB.Frame`

Member kind: type
Symbol: `Autodesk.Revit.DB.Frame`

#### Summary

A Frame comprises three vectors at a base point in 3D space.

#### Remarks

A Frame consists of three vectors at a base point in 3D space.
The vectors need not be orthogonal, have unit length, or even be linearly
independent, although in practice Frames will usually have linearly
independent vectors.
Frames may be used to represent a coordinate frame of reference,
a moving frame field on a curve, or for other purposes.

#### Since

2012

### `M:Autodesk.Revit.DB.FormulaManager.GetOperators`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormulaManager.GetOperators`

#### Summary

Gets list of operator names supported by formula engine

### `M:Autodesk.Revit.DB.FormulaManager.GetFunctions`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormulaManager.GetFunctions`

#### Summary

Gets list of function names supported by formula engine

### `M:Autodesk.Revit.DB.FormulaManager.Validate(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormulaManager.Validate(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document,System.String)`

#### Summary

Validates the formuls

#### Remarks

It validates formula using list of global or family parameters depends on document type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.FormulaManager.Evaluate(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormulaManager.Evaluate(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document,System.String)`

#### Summary

Evaluates value of the formula

#### Remarks

It evaluates formula using list of global or family parameters depends on document type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.FormulaManager.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormulaManager.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FormulaManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.FormulaManager`

#### Summary

A class to access and query information about formula engine in Revit models.

#### Remarks

Formula manager

### `P:Autodesk.Revit.DB.TextRange.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextRange.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.TextRange.End`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextRange.End`

#### Summary

The index of the first character after the end of the range

#### Since

2017

### `P:Autodesk.Revit.DB.TextRange.Length`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextRange.Length`

#### Summary

The length of the range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for length is negative.

#### Since

2017

### `P:Autodesk.Revit.DB.TextRange.Start`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextRange.Start`

#### Summary

The start index of a range within the `T:Autodesk.Revit.DB.FormattedText` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for start is negative.

#### Since

2017

### `M:Autodesk.Revit.DB.TextRange.#ctor(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextRange.#ctor(System.Int32,System.Int32)`

#### Summary

Constructs a TextRange with input start and length.

#### Remarks

The input value for start as well as length should not be negative.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for start is negative.
-or-
The given value for length is negative.

#### Since

2017

### `M:Autodesk.Revit.DB.TextRange.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextRange.#ctor`

#### Summary

Constructs a TextRange with default values for start and length.

#### Remarks

The start and length are set to be 0 by default.

#### Since

2017

### `M:Autodesk.Revit.DB.TextRange.#ctor(Autodesk.Revit.DB.TextRange)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextRange.#ctor(Autodesk.Revit.DB.TextRange)`

#### Summary

Constructs a copy of the input TextRange object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.TextRange`

Member kind: type
Symbol: `Autodesk.Revit.DB.TextRange`

#### Summary

An object that is used to identify a range of characters in a
`T:Autodesk.Revit.DB.FormattedText` .

#### Remarks

A TextRange consists of a start, which is a zero-based index into the text,
and a length, which is the number of characters in the range. The length can be zero.

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetIndentLevel(Autodesk.Revit.DB.TextRange,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetIndentLevel(Autodesk.Revit.DB.TextRange,System.Int32)`

#### Summary

Sets the number of tab stops that the paragraph should be indented.

#### Remarks

The indent level is the number of tab stops by which each paragraph will be indented.

Note that adjoining paragraphs that have the same indent level
and have a list type other than `F:Autodesk.Revit.DB.ListType.None`
are considered part of a numbered list.
Changing the indent level of paragraphs that are bulleted or numbered
(i.e. paragraphs that have a list type other than `F:Autodesk.Revit.DB.ListType.None` )
may cause other changes to the document as the changed paragraphs
may join or leave a list. Which will cause the other paragraphs in those lists
to be renumbered.

This function applies the nesting level to all paragraphs contained in the given range.
The level set on the paragraph cannot be negative and cannot be larger than the value returned by
`M:Autodesk.Revit.DB.FormattedText.GetMaximumIndentLevel` .

#### Parameter `textRange`

The given text range.

#### Parameter `level`

The level set on the paragraph.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.
-or-
This level is too large to set on a paragraph.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for level is negative.

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetMaximumIndentLevel`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetMaximumIndentLevel`

#### Summary

Returns the maximum allowed indent level

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetIndentLevel(Autodesk.Revit.DB.TextRange)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetIndentLevel(Autodesk.Revit.DB.TextRange)`

#### Summary

Returns the indent level of the paragraphs in the text range.

#### Remarks

Returns -1 if the range contains multiple paragraphs with different indent levels.

#### Parameter `textRange`

The given text range.

#### Returns

The indentation level of the paragraphs in the range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetListStartNumber(Autodesk.Revit.DB.TextRange,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetListStartNumber(Autodesk.Revit.DB.TextRange,System.Int32)`

#### Summary

Sets the list start number on the paragraphs in a given text range.

#### Remarks

List start number is the number of the first paragraph in a numbered list.

List start number can be set on paragraphs of type `F:Autodesk.Revit.DB.ListType.ArabicNumbers` ,
`F:Autodesk.Revit.DB.ListType.LowerCaseLetters` and `F:Autodesk.Revit.DB.ListType.UpperCaseLetters` .
List start number can only be set for top-level paragraphs in a list;
that is, they cannot be set to paragraphs which are part of a sub-list.

For paragraphs of type `F:Autodesk.Revit.DB.ListType.LowerCaseLetters` and `F:Autodesk.Revit.DB.ListType.UpperCaseLetters`
the list start number represents the letter in the order it appears in the alphabet.
For example, for paragraphs of type `F:Autodesk.Revit.DB.ListType.LowerCaseLetters` ,
list start number of 2 will result in a list start "b.";
list start number of 27 will result in a list start "aa.".

Adjoining paragraphs which have a list type other than `F:Autodesk.Revit.DB.ListType.None`
are considered part of a numbered list.
Changing the list start number of numbered paragraphs
will cause changes to the numbers of the rest of the paragraphs in the same list.

This function applies the list start number to the given range.
The list start number must be in the range given by the methods
`M:Autodesk.Revit.DB.FormattedText.GetMinimumListStartNumber` and
`M:Autodesk.Revit.DB.FormattedText.GetMaximumListStartNumber` .

#### Parameter `textRange`

The given text range.

#### Parameter `value`

The list start number to be set on the text range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.
-or-
This list start number is not valid.
A valid value must be in the range given by the methods
`M:Autodesk.Revit.DB.FormattedText.GetMinimumListStartNumber` and
`M:Autodesk.Revit.DB.FormattedText.GetMaximumListStartNumber` .
-or-
Cannot set list start number on this text range. The range contains paragraphs on which list start number cannot be set.
List start number can be set on pararaphs of type `F:Autodesk.Revit.DB.ListType.ArabicNumbers` ,
`F:Autodesk.Revit.DB.ListType.LowerCaseLetters` and `F:Autodesk.Revit.DB.ListType.UpperCaseLetters` .
List start number can only be set for top-level paragraphs in a list;
that is, they cannot be set to paragraphs which are part of a sub-list.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetMinimumListStartNumber`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetMinimumListStartNumber`

#### Summary

Returns the minumum allowed list start number.

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetMaximumListStartNumber`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetMaximumListStartNumber`

#### Summary

Returns the maximum allowed list start number.

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetListStartNumber(Autodesk.Revit.DB.TextRange)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetListStartNumber(Autodesk.Revit.DB.TextRange)`

#### Summary

Returns the list start number of the paragraphs in a given text range.

#### Remarks

Returns -1 if there is a mix of list start values in the range or
if there are paragraphs in different lists or sub-lists in the range or
if there are paragraphs of type `F:Autodesk.Revit.DB.ListType.None` or `F:Autodesk.Revit.DB.ListType.Bullet` in the range.

#### Parameter `textRange`

The given text range.

#### Returns

The list start number of the text range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetListType(Autodesk.Revit.DB.TextRange,Autodesk.Revit.DB.ListType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetListType(Autodesk.Revit.DB.TextRange,Autodesk.Revit.DB.ListType)`

#### Summary

Sets the `T:Autodesk.Revit.DB.ListType` of a paragraph.

#### Remarks

This function applies the `T:Autodesk.Revit.DB.ListType`
to all paragraphs contained in the given range.

The following `T:Autodesk.Revit.DB.ListType` options are available:
`F:Autodesk.Revit.DB.ListType.Bullet`

`F:Autodesk.Revit.DB.ListType.ArabicNumbers`

`F:Autodesk.Revit.DB.ListType.LowerCaseLetters`

`F:Autodesk.Revit.DB.ListType.UpperCaseLetters`

Set the list type to `F:Autodesk.Revit.DB.ListType.None`
if the paragraph should not be in a list.

The list type cannot be set to `F:Autodesk.Revit.DB.ListType.Mixed` .

Paragraphs with a `T:Autodesk.Revit.DB.ListType` other than `F:Autodesk.Revit.DB.ListType.None` are considered
to be 'list' paragraphs.

Consecutive list paragraphs with the same indentation level are treated as part of the same list.
A list ends when a list paragraph is followed by
a paragraph that has `F:Autodesk.Revit.DB.ListType.None`

or a list paragraph that has a lower indentation level, (i.e. is indented less)
Note that a list will continue uninterrupted after list paragraphs that have higher indentation level.
These paragraphs are considered a 'sub-list'.
Using `M:Autodesk.Revit.DB.FormattedText.SetIndentLevel(Autodesk.Revit.DB.TextRange,System.Int32)` it is therefore possible to create multi-level lists.
Note that sub-lists can have their own sub-sub-lists.
The nesting level is only limited by the maximum indent level.

FormattedText will keep lists consistent.
That means that numbered paragraphs will automatically get sequential numbers or letters.
It also means that if the list type of one paragraphs in the list
is changed then that change is propagated to all the paragraphs in that list.
Even if those paragraphs were not in the input text range.
Note that this will not affect the list type of any nested sub-lists.

Use a vertical tab character ('\v') to insert a line without a bullet or number.
Since this does not end the paragraph this will allow the list to continue to the next paragraph.

#### Parameter `textRange`

The given text range.

#### Parameter `listType`

The `T:Autodesk.Revit.DB.ListType` to set on the paragraph.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.
-or-
This list type is not valid to set on a paragraph.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetListType(Autodesk.Revit.DB.TextRange)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetListType(Autodesk.Revit.DB.TextRange)`

#### Summary

Returns the `T:Autodesk.Revit.DB.ListType` of a paragraph.

#### Remarks

This function returns the list type of all paragraphs contained in the given range.
Returns `F:Autodesk.Revit.DB.ListType.None` if the paragraph is not in a list.
Returns `F:Autodesk.Revit.DB.ListType.Mixed` if the list types don't match between the paragraphs.

#### Parameter `textRange`

The given text range.

#### Returns

The `T:Autodesk.Revit.DB.ListType` of the paragraph.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetAllCapsStatus(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetAllCapsStatus(System.Boolean)`

#### Summary

Sets the characters in the entire text to be in all caps or not.

#### Parameter `isAllCaps`

The desired all caps status of characters in the entire text.
True to set all capped, false to set not all capped.

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetSuperscriptStatus(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetSuperscriptStatus(System.Boolean)`

#### Summary

Sets the characters in the entire text to be superscript or not superscript.

#### Remarks

If the characters are set to be superscript, they cannot be subscript.
This sets the subscript status to false.

#### Parameter `isSuperscript`

The desired superscript status of characters in the entire text.
True to set superscript, false to set not superscript.

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetSubscriptStatus(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetSubscriptStatus(System.Boolean)`

#### Summary

Sets the characters in the entire text to be subscript or not subscript.

#### Remarks

If the characters are set to be subscript, they cannot be superscript.
This sets the superscript status to false.

#### Parameter `isSubscript`

The desired subscript status of characters in the entire text.
True to set subscript, false to set not subscript.

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetUnderlineStatus(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetUnderlineStatus(System.Boolean)`

#### Summary

Sets the characters in the entire text to be underlined or not underlined.

#### Parameter `isUnderlined`

The desired underline status of characters in the entire text.
True to set underlined, false to set not underlined.

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetItalicStatus(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetItalicStatus(System.Boolean)`

#### Summary

Sets the characters in the entire text to be italic or not italic.

#### Parameter `isItalic`

The desired italic status of characters in the entire text.
True to set italic, false to set not italic.

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetBoldStatus(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetBoldStatus(System.Boolean)`

#### Summary

Sets the characters in the entire text to be bold or not bold.

#### Parameter `isBold`

The desired bold status of characters in the entire text.
True to set bold, false to set not bold.

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetAllCapsStatus(Autodesk.Revit.DB.TextRange,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetAllCapsStatus(Autodesk.Revit.DB.TextRange,System.Boolean)`

#### Summary

Sets the characters in a given text range to be in all caps or not.

#### Remarks

Removing the all caps status will revert the characters back to their
original case. It will not make them lower case.

The given text range should not be empty.

#### Parameter `textRange`

The given text range.

#### Parameter `isAllCaps`

The desired all caps status of characters in the given text range.
True will render all characters in all caps.
False will revert the characters back to their original mixed case.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetSuperscriptStatus(Autodesk.Revit.DB.TextRange,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetSuperscriptStatus(Autodesk.Revit.DB.TextRange,System.Boolean)`

#### Summary

Sets the characters in a given text range to be superscript or not superscript.

#### Remarks

Superscript and subscript are mutually exclusive.
Applying the superscript status will automatically remove the subscript status.

The given text range should not be empty.

#### Parameter `textRange`

The given text range.

#### Parameter `isSuperscript`

The desired superscript status of characters in the given text range.
True to set superscript, false to set not superscript.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetSubscriptStatus(Autodesk.Revit.DB.TextRange,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetSubscriptStatus(Autodesk.Revit.DB.TextRange,System.Boolean)`

#### Summary

Sets the characters in a given text range to be subscript or not subscript.

#### Remarks

Superscript and subscript are mutually exclusive.
Applying the subscript status will automatically remove the superscript status.

The given text range should not be empty.

#### Parameter `textRange`

The given text range.

#### Parameter `isSubscript`

The desired subscript status of characters in the given text range.
True to set subscript, false to set not subscript.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetUnderlineStatus(Autodesk.Revit.DB.TextRange,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetUnderlineStatus(Autodesk.Revit.DB.TextRange,System.Boolean)`

#### Summary

Sets the characters in a given text range to be underlined or not underlined.

#### Remarks

Bullets, numbers, or letters of a list can not be underlined.

The given text range should not be empty.

#### Parameter `textRange`

The given text range.

#### Parameter `isUnderlined`

The desired underline status of characters in the given text range.
True to set underlined, false to set not underlined.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetItalicStatus(Autodesk.Revit.DB.TextRange,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetItalicStatus(Autodesk.Revit.DB.TextRange,System.Boolean)`

#### Summary

Sets the characters in a given text range to be italic or not italic.

#### Remarks

To make the numbers or letters in a list italic, apply the italic status to
the carriage return character that ends the list paragraph.

The given text range should not be empty.

#### Parameter `textRange`

The given text range.

#### Parameter `isItalic`

The desired italic status of characters in the given text range.
True to set italic, false to set not italic.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetBoldStatus(Autodesk.Revit.DB.TextRange,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetBoldStatus(Autodesk.Revit.DB.TextRange,System.Boolean)`

#### Summary

Sets the characters in a given text range to be bold or not bold.

#### Remarks

To make the numbers or letters in a list bold, apply the bold status to
the carriage return character that ends the list paragraph.

The given text range should not be empty.

#### Parameter `textRange`

The given text range.

#### Parameter `isBold`

The desired bold status of characters in the given text range.
True to set bold, false to set not bold.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetAllCapsStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetAllCapsStatus`

#### Summary

Returns whether `F:Autodesk.Revit.DB.FormatStatus.All` , `F:Autodesk.Revit.DB.FormatStatus.None` or a `F:Autodesk.Revit.DB.FormatStatus.Mixed` of characters in the entire text are in all caps.

#### Remarks

This function only returns `F:Autodesk.Revit.DB.FormatStatus.All` or `F:Autodesk.Revit.DB.FormatStatus.None` if the entire text contains one character.

#### Returns

The format status of all caps on characters `T:Autodesk.Revit.DB.FormatStatus` .

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetSuperscriptStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetSuperscriptStatus`

#### Summary

Returns whether `F:Autodesk.Revit.DB.FormatStatus.All` , `F:Autodesk.Revit.DB.FormatStatus.None` or a `F:Autodesk.Revit.DB.FormatStatus.Mixed` of characters in the entire text are superscripted.

#### Remarks

This function only returns `F:Autodesk.Revit.DB.FormatStatus.All` or `F:Autodesk.Revit.DB.FormatStatus.None` if the entire text contains one character.

#### Returns

The format status of superscript on characters `T:Autodesk.Revit.DB.FormatStatus` .

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetSubscriptStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetSubscriptStatus`

#### Summary

Returns whether `F:Autodesk.Revit.DB.FormatStatus.All` , `F:Autodesk.Revit.DB.FormatStatus.None` or a `F:Autodesk.Revit.DB.FormatStatus.Mixed` of characters in the entire text are subscripted.

#### Remarks

This function only returns `F:Autodesk.Revit.DB.FormatStatus.All` or `F:Autodesk.Revit.DB.FormatStatus.None` if the entire text contains one character.

#### Returns

The format status of subscript on characters `T:Autodesk.Revit.DB.FormatStatus` .

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetUnderlineStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetUnderlineStatus`

#### Summary

Returns whether `F:Autodesk.Revit.DB.FormatStatus.All` , `F:Autodesk.Revit.DB.FormatStatus.None` or a `F:Autodesk.Revit.DB.FormatStatus.Mixed` of characters in the entire text are underlined.

#### Remarks

This function only returns All or None if the entire text contains one character.

#### Returns

The format status of underline on characters `T:Autodesk.Revit.DB.FormatStatus` .

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetItalicStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetItalicStatus`

#### Summary

Returns whether `F:Autodesk.Revit.DB.FormatStatus.All` , `F:Autodesk.Revit.DB.FormatStatus.None` or a `F:Autodesk.Revit.DB.FormatStatus.Mixed` of characters in the entire text are italic.

#### Remarks

This function only returns `F:Autodesk.Revit.DB.FormatStatus.All` or `F:Autodesk.Revit.DB.FormatStatus.None` if the entire text contains one character.

#### Returns

The format status of italic on characters `T:Autodesk.Revit.DB.FormatStatus` .

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetBoldStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetBoldStatus`

#### Summary

Returns whether `F:Autodesk.Revit.DB.FormatStatus.All` , `F:Autodesk.Revit.DB.FormatStatus.None` or a `F:Autodesk.Revit.DB.FormatStatus.Mixed` of characters in the entire text are bold.

#### Remarks

This function only returns `F:Autodesk.Revit.DB.FormatStatus.All` or `F:Autodesk.Revit.DB.FormatStatus.None` if the entire text contains one character.

#### Returns

The format status of bold on characters `T:Autodesk.Revit.DB.FormatStatus` .

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetAllCapsStatus(Autodesk.Revit.DB.TextRange)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetAllCapsStatus(Autodesk.Revit.DB.TextRange)`

#### Summary

Returns whether `F:Autodesk.Revit.DB.FormatStatus.All` , `F:Autodesk.Revit.DB.FormatStatus.None` or a `F:Autodesk.Revit.DB.FormatStatus.Mixed` set of characters in a given text range are in all caps.

#### Remarks

This function only returns `F:Autodesk.Revit.DB.FormatStatus.All` or `F:Autodesk.Revit.DB.FormatStatus.None` if the text contains one character.
The given text range should not be empty.

#### Parameter `textRange`

The given text range.

#### Returns

The format status of all caps on characters `T:Autodesk.Revit.DB.FormatStatus` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetSuperscriptStatus(Autodesk.Revit.DB.TextRange)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetSuperscriptStatus(Autodesk.Revit.DB.TextRange)`

#### Summary

Returns whether `F:Autodesk.Revit.DB.FormatStatus.All` , `F:Autodesk.Revit.DB.FormatStatus.None` or a `F:Autodesk.Revit.DB.FormatStatus.Mixed` set of characters in a given text range are superscripted.

#### Remarks

This function only returns `F:Autodesk.Revit.DB.FormatStatus.All` or `F:Autodesk.Revit.DB.FormatStatus.None` if the text contains one character.
The given text range should not be empty.

#### Parameter `textRange`

The given text range.

#### Returns

The format status of superscript on characters `T:Autodesk.Revit.DB.FormatStatus` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetSubscriptStatus(Autodesk.Revit.DB.TextRange)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetSubscriptStatus(Autodesk.Revit.DB.TextRange)`

#### Summary

Returns whether `F:Autodesk.Revit.DB.FormatStatus.All` , `F:Autodesk.Revit.DB.FormatStatus.None` or a `F:Autodesk.Revit.DB.FormatStatus.Mixed` set of characters in a given text range are subscripted.

#### Remarks

This function only returns `F:Autodesk.Revit.DB.FormatStatus.All` or `F:Autodesk.Revit.DB.FormatStatus.None` if the text contains one character.
The given text range should not be empty.

#### Parameter `textRange`

The given text range.

#### Returns

The format status of subscript on characters `T:Autodesk.Revit.DB.FormatStatus` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetUnderlineStatus(Autodesk.Revit.DB.TextRange)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetUnderlineStatus(Autodesk.Revit.DB.TextRange)`

#### Summary

Returns whether `F:Autodesk.Revit.DB.FormatStatus.All` , `F:Autodesk.Revit.DB.FormatStatus.None` or a `F:Autodesk.Revit.DB.FormatStatus.Mixed` set of characters in a given text range are underlined.

#### Remarks

This function only returns `F:Autodesk.Revit.DB.FormatStatus.All` or `F:Autodesk.Revit.DB.FormatStatus.None` if the text contains one character.
The given text range should not be empty.

#### Parameter `textRange`

The given text range.

#### Returns

The format status of underline on characters `T:Autodesk.Revit.DB.FormatStatus` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetItalicStatus(Autodesk.Revit.DB.TextRange)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetItalicStatus(Autodesk.Revit.DB.TextRange)`

#### Summary

Returns whether `F:Autodesk.Revit.DB.FormatStatus.All` , `F:Autodesk.Revit.DB.FormatStatus.None` or a `F:Autodesk.Revit.DB.FormatStatus.Mixed` set of characters in a given text range are italic.

#### Remarks

This function only returns `F:Autodesk.Revit.DB.FormatStatus.All` or `F:Autodesk.Revit.DB.FormatStatus.None` if the text contains one character.
The given text range should not be empty.

#### Parameter `textRange`

The given text range.

#### Returns

The format status of italic on characters `T:Autodesk.Revit.DB.FormatStatus` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetBoldStatus(Autodesk.Revit.DB.TextRange)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetBoldStatus(Autodesk.Revit.DB.TextRange)`

#### Summary

Returns whether `F:Autodesk.Revit.DB.FormatStatus.All` , `F:Autodesk.Revit.DB.FormatStatus.None` or a `F:Autodesk.Revit.DB.FormatStatus.Mixed` set of characters in a given text range are bold.

#### Remarks

This function only returns `F:Autodesk.Revit.DB.FormatStatus.All` or `F:Autodesk.Revit.DB.FormatStatus.None` if the text contains one character.
The given text range should not be empty.

#### Parameter `textRange`

The given text range.

#### Returns

The format status of bold on characters `T:Autodesk.Revit.DB.FormatStatus` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This text range is empty.
-or-
This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetPlainText(Autodesk.Revit.DB.TextRange,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetPlainText(Autodesk.Revit.DB.TextRange,System.String)`

#### Summary

Sets the text with the given text in a plain text form in a range.

#### Remarks

Any individual formatting present in the range before will be lost after applying this function
and the text in the range will have uniform formatting.
The given text will be inserted if the given text range is empty.
The given text should have no more than 30,000 characters.
The the resulting text may not exceed 30,000 characters.
Newline characters ('\n') are not allowed.

#### Parameter `textRange`

The given text range.

#### Parameter `plainText`

The given text in a plain text form.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.
-or-
plainText contains invalid characters such as a newline character.
-or-
plainText (excluding a carriage return character ('\r') at the end) has more than 30,000 characters.
-or-
Replacing the text in textRange with plainText will exceed 30,000 characters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.SetPlainText(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.SetPlainText(System.String)`

#### Summary

Sets the entire text with the given text in a plain text form.

#### Remarks

Any individual formatting present before will be lost after applying this function
and the text will have uniform formatting.
If the text does not end with a carriage return character ('\r') one will be added.
An empty string is allowed.
The given text should have no more than 30,000 characters, not counting a terminating carriage return character ('\r').
Newline characters ('\n') are not allowed.

#### Parameter `plainText`

The given text in a plain text form.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

plainText (excluding a carriage return character ('\r') at the end) has more than 30,000 characters.
-or-
plainText contains invalid characters such as a newline character.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetPlainText(Autodesk.Revit.DB.TextRange)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetPlainText(Autodesk.Revit.DB.TextRange)`

#### Summary

Returns a substring of the text in a plain text form. The start and end of the substring is identified
by a given `T:Autodesk.Revit.DB.TextRange` .

#### Parameter `textRange`

The given `T:Autodesk.Revit.DB.TextRange` .

#### Returns

The substring of the text in a plain text form.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This start index of this text range is not within the text range identifying the entire text.
-or-
The end of this text range is not within the text range identifying the entire text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.GetPlainText`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.GetPlainText`

#### Summary

Returns the entire text in a plain text form.

#### Remarks

The text includes a carriage return character ('\r') that is always present.
As a result this method will never return an empty string.

#### Returns

The entire text in a plain text form.

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.AsTextRange`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.AsTextRange`

#### Summary

Returns a `T:Autodesk.Revit.DB.TextRange` object that represents the entire text.

#### Remarks

This range includes a carriage return character ('\r') that is always present.
As a result the range can never be an empty range.

#### Returns

The `T:Autodesk.Revit.DB.TextRange` object that represents the entire text.

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.Find(System.String,System.Int32,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.Find(System.String,System.Int32,System.Boolean,System.Boolean)`

#### Summary

Returns a text range identifying the first occurrence of the given string within the text,
starting from a given index.

#### Remarks

Returns an empty text range:
if the given string cannot be found in the text.

if the given start index is beyond the length of the entire text.
The search can be case-sensitive or case-insensitive.
The search can be set to match whole words or part of words.

#### Parameter `searchString`

The text to search for.

#### Parameter `startIndex`

The start index to search within the text.

#### Parameter `matchCase`

True if the case must match when searching the formatted text, false to search in a case-insensitive manner.

#### Parameter `matchWholeWord`

True if the match must be a whole word when searching the formatted text, false otherwise.

#### Returns

The text range identified.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

searchString is an empty string.
-or-
searchString contains invalid characters such as a newline character.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for startIndex is negative.

#### Since

2017

### `P:Autodesk.Revit.DB.FormattedText.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormattedText.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.FormattedText.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.#ctor(System.String)`

#### Summary

Creates a new FormattedText object with unformatted text.

#### Remarks

The given text should have no more than 30,000 characters.
Line feed characters ('/n') are not allowed.
An empty string is allowed.

#### Parameter `plainText`

The text in a plain text form.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

plainText (excluding a carriage return character ('\r') at the end) has more than 30,000 characters.
-or-
plainText contains invalid characters such as a newline character.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FormattedText.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormattedText.#ctor`

#### Summary

Creates a new default FormattedText object, which contains only a carriage return character and has no formatting.

#### Since

2017

### `T:Autodesk.Revit.DB.FormattedText`

Member kind: type
Symbol: `Autodesk.Revit.DB.FormattedText`

#### Summary

FormattedText is used to create, edit and format text in a `T:Autodesk.Revit.DB.TextNote`
or to query the text and format properties of a `T:Autodesk.Revit.DB.TextNode`

#### Remarks

An instance of FormattedText can be obtained from a `T:Autodesk.Revit.DB.TextNote`
(See TextNote.GetFormattedText())
or from a `T:Autodesk.Revit.DB.TextNode`
(See TextNode.GetFormattedText())

It is also possible to create a new instance of FormattedText and assign it
to a `T:Autodesk.Revit.DB.TextNote`
(See TextNote.SetFormattedText())
This will result in a `T:Autodesk.Revit.DB.TextNote` with text with the specified formatting applied

Formatted text can be used to:
Create formatted text for a new `T:Autodesk.Revit.DB.TextNote`

Edit, Find and Replace text in an existing `T:Autodesk.Revit.DB.TextNote`

Modify formatting of text in an existing `T:Autodesk.Revit.DB.TextNote`

Or query the text and formatting a `T:Autodesk.Revit.DB.TextNote` or a `T:Autodesk.Revit.DB.TextNode`

Formatted text can be populated with plain text by using its
constructor `M:Autodesk.Revit.DB.FormattedText.#ctor(System.String)` that takes a string,
or by using the `M:Autodesk.Revit.DB.FormattedText.SetPlainText(System.String)` method.

In addition, selected ranges of text can be added, removed, or replaced with the
`M:Autodesk.Revit.DB.FormattedText.SetPlainText(Autodesk.Revit.DB.TextRange,System.String)` method
by specifying a `T:Autodesk.Revit.DB.TextRange` .

Use the `M:Autodesk.Revit.DB.FormattedText.Find(System.String,System.Int32,System.Boolean,System.Boolean)` method to find the location of existing text.

Formatted text can have up to 30,000 characters.
All characters, except the linefeed character ('\n'), are allowed.
This means that you should not use the 'Environment.NewLine' property, since that includes a linefeed character.
Use the carriage return character ('\r') to terminate a paragraph.
And use a vertical tab character ('\v') to create a new line without terminating the paragraph.

Formatted text allows for individual characters to be formatted.
The following formatting can be applied.
Bold

Italic

Underline

Superscript/Subscript

All Caps
Use `M:Autodesk.Revit.DB.FormattedText.SetBoldStatus(Autodesk.Revit.DB.TextRange,System.Boolean)` )
, `M:Autodesk.Revit.DB.FormattedText.SetItalicStatus(Autodesk.Revit.DB.TextRange,System.Boolean)` )
, `M:Autodesk.Revit.DB.FormattedText.SetUnderlineStatus(Autodesk.Revit.DB.TextRange,System.Boolean)` )
, `M:Autodesk.Revit.DB.FormattedText.SetSuperscriptStatus(Autodesk.Revit.DB.TextRange,System.Boolean)` )
, `M:Autodesk.Revit.DB.FormattedText.SetSubscriptStatus(Autodesk.Revit.DB.TextRange,System.Boolean)` )
, or `M:Autodesk.Revit.DB.FormattedText.SetAllCapsStatus(Autodesk.Revit.DB.TextRange,System.Boolean)` )
to set the character formatting on a range of text.

Use `M:Autodesk.Revit.DB.FormattedText.GetBoldStatus(Autodesk.Revit.DB.TextRange)` )
, `M:Autodesk.Revit.DB.FormattedText.GetItalicStatus(Autodesk.Revit.DB.TextRange)` )
, `M:Autodesk.Revit.DB.FormattedText.GetUnderlineStatus(Autodesk.Revit.DB.TextRange)` )
, `M:Autodesk.Revit.DB.FormattedText.GetSuperscriptStatus(Autodesk.Revit.DB.TextRange)` )
, `M:Autodesk.Revit.DB.FormattedText.GetSubscriptStatus(Autodesk.Revit.DB.TextRange)` )
, or `M:Autodesk.Revit.DB.FormattedText.GetAllCapsStatus(Autodesk.Revit.DB.TextRange)` )
to get the character formatting of a range of text.

Text can be broken up in paragraphs. Paragraphs are terminated by a carriage return character ('\r').

Each paragraph can be indented several levels deep.
For each additional level the indentation increments by one tab size.
The total indentation is the product of a tab size and the indent level.
Use `M:Autodesk.Revit.DB.FormattedText.SetIndentLevel(Autodesk.Revit.DB.TextRange,System.Int32)` to set the level of indenting
up to a maximum indent level that can be obtained from
`M:Autodesk.Revit.DB.FormattedText.GetMaximumIndentLevel`
Use `M:Autodesk.Revit.DB.FormattedText.GetIndentLevel(Autodesk.Revit.DB.TextRange)` to find the indent level of a given range of text.

Note that the tab size is determined by the object that will contain the FormattedText.

In the case of a `T:Autodesk.Revit.DB.TextNote` the tab size is a property of the `T:Autodesk.Revit.DB.TextNoteType`
returned from TextNote.TextNoteType.
The tab size can be found by calling the `P:Autodesk.Revit.DB.Element.Parameter(System.Guid)`
with `F:Autodesk.Revit.DB.BuiltInParameter.TEXT_TAB_SIZE` on the `T:Autodesk.Revit.DB.TextNoteType` obtained from the `T:Autodesk.Revit.DB.TextNote`

In the case of a `T:Autodesk.Revit.DB.TextNode` the tab size can be obtained from its TabSize property

Formatted text can also be used to create numbered or bulleted paragraphs with the
`M:Autodesk.Revit.DB.FormattedText.SetListType(Autodesk.Revit.DB.TextRange,Autodesk.Revit.DB.ListType)` method.

The following `T:Autodesk.Revit.DB.ListType` options are available:
`F:Autodesk.Revit.DB.ListType.Bullet`

`F:Autodesk.Revit.DB.ListType.ArabicNumbers`

`F:Autodesk.Revit.DB.ListType.LowerCaseLetters`

`F:Autodesk.Revit.DB.ListType.UpperCaseLetters`
Paragraphs with a `T:Autodesk.Revit.DB.ListType` other than `F:Autodesk.Revit.DB.ListType.None` are considered
to be 'list' paragraphs.
Consecutive list paragraphs with the same indentation level are treated as part of the same list.
A list ends when a list paragraph is followed by
a paragraph that has `F:Autodesk.Revit.DB.ListType.None`

or a list paragraph that has a lower indentation level, i.e. is indented less.
(See `M:Autodesk.Revit.DB.FormattedText.GetIndentLevel(Autodesk.Revit.DB.TextRange)` )
Note that a list will continue uninterrupted after list paragraphs that have higher indentation level.
These paragraphs form a 'sub-list' of the list they interrupt.
Sub-lists can have their own sub-sub-lists.
The nesting level is only limited by the maximum indent level.
Using `M:Autodesk.Revit.DB.FormattedText.SetIndentLevel(Autodesk.Revit.DB.TextRange,System.Int32)` it is therefore possible to create multi-level lists.

FormattedText will keep lists consistent.
That means that list paragraphs will automatically get sequential numbers or letters.
It also means that if the list type of one of the paragraphs in a list
is changed then that change is propagated to all the paragraphs in that list.
Note that this will not affect the list type of any nested sub-lists.

Use a vertical tab character ('\v') to insert a line without a bullet or number.
Since this does not end the paragraph this will allow the list to continue to the next paragraph.

#### Since

2017

### `T:Autodesk.Revit.DB.ListType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ListType`

#### Summary

An enumerated type indicating the style of list item
for paragraphs that are part of ordered or unordered lists
in `T:FormattedText` .

#### Since

2017

### `F:Autodesk.Revit.DB.ListType.UpperCaseLetters`

Member kind: field
Symbol: `Autodesk.Revit.DB.ListType.UpperCaseLetters`

#### Summary

The paragraph is a part of an ordered list with upper-case letter headings.

### `F:Autodesk.Revit.DB.ListType.LowerCaseLetters`

Member kind: field
Symbol: `Autodesk.Revit.DB.ListType.LowerCaseLetters`

#### Summary

The paragraph is a part of an ordered list with lower-case letter headings.

### `F:Autodesk.Revit.DB.ListType.ArabicNumbers`

Member kind: field
Symbol: `Autodesk.Revit.DB.ListType.ArabicNumbers`

#### Summary

The paragraph is a part of an ordered list with Arabic number headings.

### `F:Autodesk.Revit.DB.ListType.Bullet`

Member kind: field
Symbol: `Autodesk.Revit.DB.ListType.Bullet`

#### Summary

The paragraph is a part of a bulleted list.

### `F:Autodesk.Revit.DB.ListType.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.ListType.None`

#### Summary

The paragraph is not a part of a list.

### `F:Autodesk.Revit.DB.ListType.Mixed`

Member kind: field
Symbol: `Autodesk.Revit.DB.ListType.Mixed`

#### Summary

This value may be returned by FormattedText.GetListType()
when there are multiple list types in the selected range.

### `T:Autodesk.Revit.DB.FormatStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.FormatStatus`

#### Remarks

The character formatting includes
Bold

Italic

Underline

SuperScript

Subscript

All Caps

#### Since

2017

#### Summary

An enumerated type indicating the formatting status of a range of characters
in `T:FormattedText`

#### Since

2017

### `F:Autodesk.Revit.DB.FormatStatus.Mixed`

Member kind: field
Symbol: `Autodesk.Revit.DB.FormatStatus.Mixed`

#### Summary

The characters in the format have mixed formatting.

### `F:Autodesk.Revit.DB.FormatStatus.All`

Member kind: field
Symbol: `Autodesk.Revit.DB.FormatStatus.All`

#### Summary

All of the characters in the range have the specified format.

### `F:Autodesk.Revit.DB.FormatStatus.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.FormatStatus.None`

#### Summary

None of the characters in the range has the specified format.

### `M:Autodesk.Revit.DB.FormatValueOptions.GetFormatOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatValueOptions.GetFormatOptions`

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

### `M:Autodesk.Revit.DB.FormatValueOptions.SetFormatOptions(Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatValueOptions.SetFormatOptions(Autodesk.Revit.DB.FormatOptions)`

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

### `P:Autodesk.Revit.DB.FormatValueOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormatValueOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FormatValueOptions.AppendUnitSymbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormatValueOptions.AppendUnitSymbol`

#### Summary

Indicates if a unit symbol should be appended regardless of the settings in the FormatOptions.

#### Value

True to force a unit symbol to be appended; false to use the settings specified by the FormatOptions. The default is false.

#### Since

2014

### `M:Autodesk.Revit.DB.FormatValueOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatValueOptions.#ctor`

#### Summary

Creates a new FormatValueOptions object with default settings.

#### Since

2014

### `T:Autodesk.Revit.DB.FormatValueOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.FormatValueOptions`

#### Summary

Options for formatting numbers with units into strings.

#### Since

2014

### `M:Autodesk.Revit.DB.FormUtils.CanBeDissolved(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormUtils.CanBeDissolved(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Validates that input contains one or more form elements or geom combinations containing form elements.

#### Parameter `ADoc`

The document.

#### Parameter `elements`

A collection of elements.

#### Returns

True if inputs contain one or more form elements. Non-form element inputs are ignored.
False if none of the inputs are form elements or do not contain form elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.FormUtils.DissolveForms(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormUtils.DissolveForms(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Dissolves a collection of form elements into their defining elements.

#### Parameter `ADoc`

The document

#### Parameter `elements`

A collection of element IDs of Forms and GeomCombinations that contain Forms that will be dissolved.

#### Returns

A collection of curve element ids from the profiles and paths of the dissolved forms.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The elements do not include Forms that can be dissolved.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.FormUtils.DissolveForms(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormUtils.DissolveForms(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId}@)`

#### Summary

Dissolves a collection of form elements into their defining elements.

#### Remarks

Profile origin points define the workplane of form profiles and paths and their curves.
The profile origin point represents a coordinate system with an origin (reference point) which
can be manipulated to move the curves of a profile together as a unit after dissolve.
Profile origin points may themselves be constrained to other parts of the model or parts of the form,
based on how the form was created/constructed. This is done through the reference point hosting
mechanism.

#### Parameter `ADoc`

The document

#### Parameter `elements`

A collection of element IDs of Forms and GeomCombinations that contain Forms that will be dissolved.

#### Parameter `ProfileOriginPointSet`

A collection of the point element ids that represent the 'origin' of the profiles

#### Returns

A collection of curve element ids from the profiles and paths of the dissolved forms.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The elements do not include Forms that can be dissolved.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.FormUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.FormUtils`

#### Summary

Define Form utility functions

### `M:Autodesk.Revit.DB.Visual.FormItAssetInternalUtils.ConvertToAsset(System.IntPtr)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.FormItAssetInternalUtils.ConvertToAsset(System.IntPtr)`

#### Summary

Used by FormIt

#### Since

2017

### `T:Autodesk.Revit.DB.Visual.FormItAssetInternalUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.FormItAssetInternalUtils`

#### Summary

A collection of utilities for the FormIt Converter AddIn can use this code.

#### Since

2017

### `M:Autodesk.Revit.DB.ForgeSchemaClosure.GetBindings`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeSchemaClosure.GetBindings`

#### Summary

Returns the bindings.

### `M:Autodesk.Revit.DB.ForgeSchemaClosure.GetDependencies`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeSchemaClosure.GetDependencies`

#### Summary

Returns the dependencies.
A collection of all schemas that the primary schema depends upon, directly or indirectly. Each schema in this
map is indexed by its identifier.

### `P:Autodesk.Revit.DB.ForgeSchemaClosure.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeSchemaClosure.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ForgeSchemaClosure.IsHidden`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeSchemaClosure.IsHidden`

#### Summary

Is parameter hidden.

### `P:Autodesk.Revit.DB.ForgeSchemaClosure.IsInstance`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeSchemaClosure.IsInstance`

#### Summary

Parameter's instance vs type.

### `P:Autodesk.Revit.DB.ForgeSchemaClosure.GroupTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeSchemaClosure.GroupTypeId`

#### Summary

Parameter's group typeId.

### `P:Autodesk.Revit.DB.ForgeSchemaClosure.Schema`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeSchemaClosure.Schema`

#### Summary

The primary schema.

### `P:Autodesk.Revit.DB.ForgeSchemaClosure.TypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ForgeSchemaClosure.TypeId`

#### Summary

The primary schema's identifier.

### `M:Autodesk.Revit.DB.ForgeSchemaClosure.#ctor(System.String,System.String,System.Collections.Generic.IDictionary{System.String,System.String},System.Collections.Generic.IList{System.String},System.String,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ForgeSchemaClosure.#ctor(System.String,System.String,System.Collections.Generic.IDictionary{System.String,System.String},System.Collections.Generic.IList{System.String},System.String,System.Boolean,System.Boolean)`

#### Summary

Constructs a ForgeTypeId holding the given schema identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.ForgeSchemaClosure`

Member kind: type
Symbol: `Autodesk.Revit.DB.ForgeSchemaClosure`

#### Summary

Contains a Forge schema with the full closure of other schemas that it depends upon.

### `P:Autodesk.Revit.DB.FloorType.ThermalProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.FloorType.ThermalProperties`

#### Summary

The calculated and settable thermal properties of the FloorType

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

the floor does not have thermal properties.

#### Since

2013

### `P:Autodesk.Revit.DB.FloorType.StructuralMaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FloorType.StructuralMaterialId`

#### Summary

Returns the identifier of the material that defines the element's structural analysis properties.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: the floor does not have a structural material

#### Since

2014

### `P:Autodesk.Revit.DB.FloorType.IsFoundationSlab`

Member kind: property
Symbol: `Autodesk.Revit.DB.FloorType.IsFoundationSlab`

#### Summary

Returns whether the element FloorAttributes type is FoundationSlab.

### `T:Autodesk.Revit.DB.FloorType`

Member kind: type
Symbol: `Autodesk.Revit.DB.FloorType`

#### Summary

An object that specifies the type of a floor in Autodesk Revit.

#### Remarks

The structural layers of the floor can be accessed via this object.

### `M:Autodesk.Revit.DB.HostObjAttributes.SetCompoundStructure(Autodesk.Revit.DB.CompoundStructure)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HostObjAttributes.SetCompoundStructure(Autodesk.Revit.DB.CompoundStructure)`

#### Summary

Sets the compound structure of the element.

### `M:Autodesk.Revit.DB.HostObjAttributes.GetCompoundStructure`

Member kind: method
Symbol: `Autodesk.Revit.DB.HostObjAttributes.GetCompoundStructure`

#### Summary

Returns an object that represents the compound structure of the element.

#### Remarks

A copy of the compound structure is returned and changes made to it will not apply to the type until SetCompoundStructure is called.
From this object the layers of a compound structure can be accessed. If the element does
not have a compound structure then this method will return `null` .

### `T:Autodesk.Revit.DB.HostObjAttributes`

Member kind: type
Symbol: `Autodesk.Revit.DB.HostObjAttributes`

#### Summary

An object that represents characteristics of several kinds of type.

#### Remarks

This object provides access to structural layering components for any object
derived from it, such as wall types and floor types.

### `M:Autodesk.Revit.DB.Floor.GetSlabShapeEditor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Floor.GetSlabShapeEditor`

#### Summary

Gets a SlabShapeEditor that can be used to add or modify points of this Floor.

#### Returns

The SlabShapeEditor object

### `M:Autodesk.Revit.DB.Floor.GetDefaultFloorType(Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Floor.GetDefaultFloorType(Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

Returns id of default floor type.

#### Parameter `document`

The document.

#### Parameter `isFoundation`

True to return id of foundation floor type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.Floor.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Floor.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of architectural floor within the project.

#### Remarks

To validate curve loop profile use `T:Autodesk.Revit.DB.BoundaryValidation` .
To get default floor type use `M:Autodesk.Revit.DB.Floor.GetDefaultFloorType(Autodesk.Revit.DB.Document,System.Boolean)` .

#### Parameter `document`

The document in which the new floor is created.

#### Parameter `profile`

An array of planar curve loops that represent the profile of the floor.

#### Parameter `floorTypeId`

Id of the floor type to be used by the new Floor.

#### Parameter `levelId`

Id of the level on which the floor is to be placed.

#### Returns

If successful a new floor object within the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId levelId is not a Level.
-or-
The floorTypeId does not correspond to a FloorType.
-or-
The input curve loops cannot compose a valid boundary, that means:
the "curveLoops" collection is empty;
or some curve loops intersect with each other;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the horizontal(XY) plane;
or input curves contain at least one helical curve.
-or-
Input curves build invalid sketch.
-or-
Failed to create curve elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot generate a sketch.
-or-
Failed to create new element.

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

2022

### `M:Autodesk.Revit.DB.Floor.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean,Autodesk.Revit.DB.Line,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Floor.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean,Autodesk.Revit.DB.Line,System.Double)`

#### Summary

Creates a new instance of floor within the project.

#### Remarks

To validate curve loop profile use `T:Autodesk.Revit.DB.BoundaryValidation` .
To get default floor type use `M:Autodesk.Revit.DB.Floor.GetDefaultFloorType(Autodesk.Revit.DB.Document,System.Boolean)` .

#### Parameter `document`

The document in which the new floor is created.

#### Parameter `profile`

An array of planar curve loops that represent the profile of the floor.

#### Parameter `floorTypeId`

Id of the floor type to be used by the new Floor.

#### Parameter `levelId`

Id of the level on which the floor is to be placed.

#### Parameter `isStructural`

True if new floor should be structural, false if architectural.

#### Parameter `slopeArrow`

A line used to control the slope angle of the Floor. It must be horizontal.
If slopeArrow is `null` , the horizontal floor will be created.

#### Parameter `slope`

The slope angle. If slopeArrow is `null` , this parameter will be ignored.

#### Returns

If successful a new floor object within the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId levelId is not a Level.
-or-
The floorTypeId does not correspond to a FloorType.
-or-
The input curve loops cannot compose a valid boundary, that means:
the "curveLoops" collection is empty;
or some curve loops intersect with each other;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the horizontal(XY) plane;
or input curves contain at least one helical curve.
-or-
The slopeArrow must be a horizontal line.
-or-
Input curves build invalid sketch.
-or-
Failed to create curve elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot generate a sketch.
-or-
Failed to create new element.

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

2022

### `P:Autodesk.Revit.DB.Floor.SketchId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Floor.SketchId`

#### Summary

Returns id of the sketch.

#### Since

2022

### `P:Autodesk.Revit.DB.Floor.SpanDirectionAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Floor.SpanDirectionAngle`

#### Summary

Retrieve the span direction angle of the floor.

#### Remarks

The angle returned is in radians. An exception will be thrown if the floor is non structural.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property:

### `P:Autodesk.Revit.DB.Floor.FloorType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Floor.FloorType`

#### Summary

Retrieves/sets an object that represents the type of the floor.

#### Remarks

The floor type can be used to access the multi layered structure of a floor.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: Floor type is not valid for this floor.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `M:Autodesk.Revit.DB.Floor.GetSpanDirectionSymbolIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Floor.GetSpanDirectionSymbolIds`

#### Summary

Retrieves span direction symbol ElementIds.

#### Returns

A collection of Element Ids of span direction symbol elements

#### Remarks

The element types of the Ids of these symbols
determine if the floor has one way or two way span direction graphics.

#### Since

2013

### `M:Autodesk.Revit.DB.Floor.GetNormalAtVerticalProjectionPoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FloorFace)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Floor.GetNormalAtVerticalProjectionPoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FloorFace)`

#### Summary

Return a surface normal on either the top or bottom face of a floor slab at a point corresponding to the vertical
projection of an arbitrary point in project space.

#### Parameter `modelLocation`

A point in project coordinates whose vertical projection will determine the location at which
the normal will be taken.

#### Parameter `floorFace`

A flag determining whether the top or bottom face of the floor should be used.

#### Returns

Normal vector on the slab at the projection point.

#### Remarks

If the floor is shape edited, the floor location at which we attempt to take the normal must be within the boundaries
of a face on the slab. Otherwise the method will return `null` .

### `M:Autodesk.Revit.DB.Floor.GetVerticalProjectionPoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FloorFace)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Floor.GetVerticalProjectionPoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FloorFace)`

#### Summary

Return a surface point on either the top or bottom face of a floor slab corresponding to the vertical projection
of an arbitrary point in project space.

#### Parameter `modelLocation`

A point in project coordinates that will be projected to the slab top or bottom face.

#### Parameter `floorFace`

A flag determining whether the top or bottom face of the floor should be used.

#### Returns

Slab surface point for the vertically projected model point.

#### Remarks

If the floor is shape edited, the surface location must be within the boundaries of a face on the slab.
Otherwise the method will return `null` .

### `P:Autodesk.Revit.DB.Floor.SlabShapeEditor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Floor.SlabShapeEditor`

#### Summary

Get the SlabShapeEditor used for slab shape editing.

#### Remarks

Only flat and horizontal floor is valid for slab shape edit. Otherwise, ShapeEditor will be `null` .

### `T:Autodesk.Revit.DB.Floor`

Member kind: type
Symbol: `Autodesk.Revit.DB.Floor`

#### Summary

An object that represents a Floor within the Autodesk Revit project.

#### Remarks

This object derived from the Element base object and such supports all the
methods of that object such as the ability to retrieve the parameters of that object.

### `T:Autodesk.Revit.DB.FloorFace`

Member kind: type
Symbol: `Autodesk.Revit.DB.FloorFace`

#### Summary

An enumerated type listing floor face types (top or bottom)

### `T:Autodesk.Revit.DB.CeilingAndFloor`

Member kind: type
Symbol: `Autodesk.Revit.DB.CeilingAndFloor`

#### Summary

A base class that provides support for all ceiling and floor objects.

### `T:Autodesk.Revit.DB.FittingAngleUsage`

Member kind: type
Symbol: `Autodesk.Revit.DB.FittingAngleUsage`

#### Summary

An enumerated type representing the options for how to limit the angle values applicable to fitting content.

#### Since

2014

### `F:Autodesk.Revit.DB.FittingAngleUsage.UseSpecificAngles`

Member kind: field
Symbol: `Autodesk.Revit.DB.FittingAngleUsage.UseSpecificAngles`

#### Summary

Uses only the angles specified.

### `F:Autodesk.Revit.DB.FittingAngleUsage.UseAnAngleIncrement`

Member kind: field
Symbol: `Autodesk.Revit.DB.FittingAngleUsage.UseAnAngleIncrement`

#### Summary

Uses the increment to determine the angle value.

### `F:Autodesk.Revit.DB.FittingAngleUsage.UseAnyAngle`

Member kind: field
Symbol: `Autodesk.Revit.DB.FittingAngleUsage.UseAnyAngle`

#### Summary

Uses any angle supported by fitting content.

### `P:Autodesk.Revit.DB.WorksetKindFilter.WorksetKind`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksetKindFilter.WorksetKind`

#### Summary

The WorksetKind.

#### Since

2012

### `M:Autodesk.Revit.DB.WorksetKindFilter.#ctor(Autodesk.Revit.DB.WorksetKind,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetKindFilter.#ctor(Autodesk.Revit.DB.WorksetKind,System.Boolean)`

#### Summary

Constructs a new instance of WorksetKindFilter filter to match worksets of the given WorksetKind.

#### Parameter `worksetKind`

The WorksetKind to match.

#### Parameter `inverted`

True if the filter should match all worksets which are not of the given WorksetKind.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.WorksetKindFilter.#ctor(Autodesk.Revit.DB.WorksetKind)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetKindFilter.#ctor(Autodesk.Revit.DB.WorksetKind)`

#### Summary

Constructs a new instance of WorksetKindFilter filter to match worksets of the given WorksetKind.

#### Parameter `worksetKind`

The WorksetKind to match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.WorksetKindFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.WorksetKindFilter`

#### Summary

A filter used to match worksets of the given WorksetKind.

#### Remarks

This filter is a quick filter.

#### Since

2012

### `P:Autodesk.Revit.DB.WorksetFilter.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksetFilter.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.WorksetFilter.IncludeStandaloneWorksetsOnly`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksetFilter.IncludeStandaloneWorksetsOnly`

#### Summary

True if the results of the filter only match stand-alone worksets; worksets that are not stand-alone will be rejected.

#### Since

2012

### `P:Autodesk.Revit.DB.WorksetFilter.Inverted`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksetFilter.Inverted`

#### Summary

True if the results of the filter are inverted; worksets that would normally be accepted by this filter will be rejected,
and worksets that would normally be rejected will be accepted.

#### Since

2012

### `T:Autodesk.Revit.DB.WorksetFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.WorksetFilter`

#### Summary

A base class for a type of filter that accepts or rejects worksets based upon criteria.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetCollector.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.FilteredWorksetCollector.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.FilteredWorksetCollector.GetFilteredWorksetCollectorIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.GetFilteredWorksetCollectorIterator`

#### Summary

Returns a FilteredWorksetIterator to the worksets passing the filters.

#### Remarks

Calling this when you have an active iterator to this same collector will result in the first iterator being
stopped by this call. Once you've used the collector to get another iterator or set of passing worksets, the original open iterator is defunct and can't be used again, attempts to call moveNext() or to reset it will throw exceptions.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of worksets is not permitted without a filter.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetCollector.GetWorksetIdIteratorInternal`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.GetWorksetIdIteratorInternal`

#### Summary

Returns a FilteredWorksetIdIterator to the worksets passing the filters.

#### Remarks

Calling this when you have an active iterator to this same collector will result in the first iterator being
stopped by this call. Once you've used the collector to get another iterator or set of passing worksets, the original open iterator is defunct and can't be used again, attempts to call moveNext() or to reset it will throw exceptions.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of worksets is not permitted without a filter.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetCollector.FirstWorkset`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.FirstWorkset`

#### Summary

Returns the first workset to pass the filter(s).

#### Remarks

This will reset the collector to the beginning and find the first workset that passes the applied filter(s).
If you have an active iterator to this same collector it will be stopped by this call.

#### Returns

The first workset.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of worksets is not permitted without a filter.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetCollector.FirstWorksetId`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.FirstWorksetId`

#### Summary

Returns the id of the first workset to pass the filter(s).

#### Remarks

This will reset the collector to the beginning and find the first workset that passes the applied filter(s).
If you have an active iterator to this same collector it will be stopped by this call.

#### Returns

The first workset id.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of worksets is not permitted without a filter.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetCollector.ToWorksets`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.ToWorksets`

#### Summary

Returns the complete set of worksets that pass the filter(s).

#### Remarks

This will reset the collector to the beginning and extract all worksets that pass the applied filter(s).
If you have an active iterator to this same collector it will be stopped by this call.

#### Returns

The complete array of worksets.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of worksets is not permitted without a filter.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetCollector.ToWorksetIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.ToWorksetIds`

#### Summary

Returns the complete set of workset ids that pass the filter(s).

#### Remarks

This will reset the collector to the beginning and extract all worksets that pass the applied filter(s).
If you have an active iterator to this same collector it will be stopped by this call.

#### Returns

The complete set of workset ids.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of worksets is not permitted without a filter.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetCollector.OfKind(Autodesk.Revit.DB.WorksetKind)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.OfKind(Autodesk.Revit.DB.WorksetKind)`

#### Summary

Applies a WorksetKindFilter to the collector.

#### Remarks

Only worksets whose WorksetKind is an exact match to the input WorksetKind will pass the collector.

If you have an active iterator to this collector it will be stopped by this call.

#### Parameter `worksetKind`

The WorksetKind of the workset.

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetCollector.WherePasses(Autodesk.Revit.DB.WorksetFilter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.WherePasses(Autodesk.Revit.DB.WorksetFilter)`

#### Summary

Applies a workset filter to the collector.

#### Remarks

The filter will be added as an additional condition that all filtered worksets must pass.
If you have an active iterator to this collector it will be stopped by this call.

#### Parameter `filter`

The workset filter.

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.FilteredWorksetCollector.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.FilteredWorksetCollector.GetWorksetIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.GetWorksetIterator`

#### Summary

Returns a FilteredWorksetIterator to the worksets passing the current filter.

#### Remarks

Calling this when you have an active iterator to this same collector will result in the first iterator being
stopped by this call.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetCollector.GetWorksetIdIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.GetWorksetIdIterator`

#### Summary

Returns a FilteredWorksetIdIterator to the worksets passing the current filter.

#### Remarks

Calling this when you have an active iterator to this same collector will result in the first iterator being
stopped by this call.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetCollector.#ctor(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector.#ctor(Autodesk.Revit.DB.Document)`

#### Summary

Constructs a new FilteredWorksetCollector that will search and filter the set of worksets in a document.

#### Parameter `document`

The document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.FilteredWorksetCollector`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilteredWorksetCollector`

#### Summary

This class is used to search, filter and iterate through a set of worksets.

#### Remarks

Developers can assign a condition to filter the worksets that are returned.
If no condition is applied, it attempts to access all the worksets in the document.

The collector will reset if you call another method to
extract worksets. Thus, if you have previously obtained an iterator, it will be stopped and traverse no more
worksets if you call another method to extract worksets.

#### Since

2012

### `P:Autodesk.Revit.DB.FilteredWorksetIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredWorksetIterator.CurrentObject`

### `P:Autodesk.Revit.DB.FilteredWorksetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredWorksetIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.FilteredWorksetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetIterator.Reset`

#### Summary

Resets the iterator to the beginning.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The FilteredWorksetCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more matching worksets. False if there are more worksets to be iterated.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The FilteredWorksetCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetIterator.MoveNext`

#### Summary

Increments the iterator to the next workset passing the filter.

#### Returns

True if there is another available workset passing the filter in this iterator.
False if the iterator has completed all available worksets.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The FilteredWorksetCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetIterator.GetCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetIterator.GetCurrent`

#### Summary

The current workset found by the iterator.

#### Returns

The workset.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There are no more worksets in the iterator.
-or-
The FilteredWorksetCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.

#### Since

2012

### `P:Autodesk.Revit.DB.FilteredWorksetIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredWorksetIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FilteredWorksetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilteredWorksetIterator`

#### Summary

An iterator to a set of worksets filtered by the settings of a FilteredWorksetCollector.

#### Since

2012

### `P:Autodesk.Revit.DB.FilteredWorksetIdIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredWorksetIdIterator.CurrentObject`

### `P:Autodesk.Revit.DB.FilteredWorksetIdIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredWorksetIdIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.FilteredWorksetIdIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetIdIterator.Reset`

#### Summary

Resets the iterator to the beginning.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The FilteredWorksetCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetIdIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetIdIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more matching worksets. False if there are more workset ids to be iterated.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The FilteredWorksetCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetIdIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetIdIterator.MoveNext`

#### Summary

Increments the iterator to the next workset id passing the filter.

#### Returns

True if there is another available workset id passing the filter in this iterator.
False if the iterator has completed all available workset ids.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The FilteredWorksetCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredWorksetIdIterator.GetCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredWorksetIdIterator.GetCurrent`

#### Summary

The current workset id found by the iterator.

#### Returns

The workset id.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There are no more workset ids in the iterator.
-or-
The FilteredWorksetCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.

#### Since

2012

### `P:Autodesk.Revit.DB.FilteredWorksetIdIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredWorksetIdIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FilteredWorksetIdIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilteredWorksetIdIterator`

#### Summary

An iterator to a set of workset ids filtered by the settings of a FilteredWorksetCollector.

#### Since

2012

### `M:Autodesk.Revit.DB.FilteredElementCollector.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.FilteredElementCollector.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.FilteredElementCollector.GetFilteredElementCollectorIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.GetFilteredElementCollectorIterator`

#### Summary

Returns an element iterator to the elements passing the filters.

#### Remarks

Calling this when you have an active iterator to this same collector will result in the first iterator being
stopped by this call.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of elements is not permitted without a filter.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.GetElementIdIteratorInternal`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.GetElementIdIteratorInternal`

#### Summary

Returns an element id iterator to the elements passing the filters.

#### Remarks

Calling this when you have an active iterator to this same collector will result in the first iterator being
stopped by this call.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of elements is not permitted without a filter.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.IsViewValidForElementIteration(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.IsViewValidForElementIteration(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if the particular element is valid for iteration of drawn elements.

#### Remarks

Views that have no way of representing drawn elements, such as many view templates, fail this check.

#### Parameter `document`

The document.

#### Parameter `viewId`

The view id.

#### Returns

True if the element is valid for iteration.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.FirstElement`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.FirstElement`

#### Summary

Returns the first element to pass the filter(s).

#### Remarks

This will reset the collector to the beginning and find the first element that passes the applied filter(s).
If you have an active iterator to this same collector it will be stopped by this call.

#### Returns

The first element.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of elements is not permitted without a filter.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.FirstElementId`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.FirstElementId`

#### Summary

Returns the id of the first element to pass the filter(s).

#### Remarks

This will reset the collector to the beginning and find the first element that passes the applied filter(s).
If you have an active iterator to this same collector it will be stopped by this call.

#### Returns

The first element id.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of elements is not permitted without a filter.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.ToElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.ToElements`

#### Summary

Returns the complete set of elements that pass the filter(s).

#### Remarks

This will reset the collector to the beginning and extract all elements that pass the applied filter(s).
If you have an active iterator to this same collector it will be stopped by this call.

#### Returns

The complete set of element ids.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of elements is not permitted without a filter.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.ToElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.ToElementIds`

#### Summary

Returns the complete set of element ids that pass the filter(s).

#### Remarks

This will reset the collector to the beginning and extract all elements that pass the applied filter(s).
If you have an active iterator to this same collector it will be stopped by this call.

#### Returns

The complete set of element ids.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of elements is not permitted without a filter.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.GetElementCount`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.GetElementCount`

#### Summary

Gets the number of elements in your current filter.

#### Remarks

Does not require a filter, if called on a new FilteredElementCollector it will return a count of all the elements.

#### Returns

The number of elements

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.Excluding(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.Excluding(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Applies an ExclusionFilter to the collector.

#### Remarks

Elements passed to this filter will be automatically excluded from the results.
If you have an active iterator to this collector it will be stopped by this call.

#### Parameter `idsToExclude`

The ids to exclude from the results.

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input collection of ids was empty, or its contents were not valid for iteration.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.WhereElementIsCurveDriven`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.WhereElementIsCurveDriven`

#### Summary

Applies an ElementIsCurveDrivenFilter to the collector.

#### Remarks

Only elements that are curve driven will pass the collector.
If you have an active iterator to this collector it will be stopped by this call.

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.ContainedInDesignOption(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.ContainedInDesignOption(Autodesk.Revit.DB.ElementId)`

#### Summary

Applies an ElementDesignOptionFilter to the collector.

#### Remarks

Only elements that are contained by this particular design option will pass the collector.
If you have an active iterator to this collector it will be stopped by this call.

#### Parameter `designOptionId`

The design option id.

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.WhereElementIsViewIndependent`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.WhereElementIsViewIndependent`

#### Summary

Applies an ElementOwnerViewFilter to the collector.

#### Remarks

Only elements that are view independent will pass the collector.
If you have an active iterator to this collector it will be stopped by this call.

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.OwnedByView(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.OwnedByView(Autodesk.Revit.DB.ElementId)`

#### Summary

Applies an ElementOwnerViewFilter to the collector.

#### Remarks

Only elements that are owned by this particular view will pass the collector.
If you have an active iterator to this collector it will be stopped by this call.

#### Parameter `viewId`

The view id of the owner view.

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.WhereElementIsNotElementType`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.WhereElementIsNotElementType`

#### Summary

Applies an inverted ElementIsElementTypeFilter to the collector.

#### Remarks

Only elements that are not element types will pass the collector.
If you have an active iterator to this collector it will be stopped by this call.

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.WhereElementIsElementType`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.WhereElementIsElementType`

#### Summary

Applies an ElementIsElementTypeFilter to the collector.

#### Remarks

Only elements that are ElementTypes will pass the collector.
If you have an active iterator to this collector it will be stopped by this call.

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.OfCategoryId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.OfCategoryId(Autodesk.Revit.DB.ElementId)`

#### Summary

Applies an ElementCategoryFilter to the collector.

#### Remarks

Only elements of this category id will pass the collector.
If you have an active iterator to this collector it will be stopped by this call.

#### Parameter `categoryId`

The category id.

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.OfClass(System.Type)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.OfClass(System.Type)`

#### Summary

Applies an ElementClassFilter to the collector.

#### Remarks

Only elements whose class is an exact match to the input class,
or elements whose type is derived from the input class will pass the collector.

There is a small subset of Element subclasses in the API that are not supported
by this filter. These classes exist in the API, but not in Revit's native object model,
which means that this filter doesn't support them. In order to use a class filter to
find elements of these types, it is necessary to use a higher level class and then
process the results further to find elements matching only the subclass. For a list
of subclasses affected by this restriction, consult the documentation for ElementClassFilter.

If you have an active iterator to this collector it will be stopped by this call.

#### Parameter `type`

The element type.

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input type is not a subclass of Element.
-or-
The input type is of an element type that exists in the API, but not in Revit's native object model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.UnionWith(Autodesk.Revit.DB.FilteredElementCollector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.UnionWith(Autodesk.Revit.DB.FilteredElementCollector)`

#### Summary

Unites the set of elements passing the filter in this collector
with the set of elements passing the filter in another collector.

#### Remarks

The result will be the same as using a LogicalOrFilter to connect this filter with another.
If you have an active iterator to this collector it will be stopped by this call.

#### Parameter `other`

The other collector

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The collector does not have a filter applied. Extraction or iteration of elements is not permitted without a filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of elements is not permitted without a filter.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.IntersectWith(Autodesk.Revit.DB.FilteredElementCollector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.IntersectWith(Autodesk.Revit.DB.FilteredElementCollector)`

#### Summary

Intersects the set of elements passing the filter in this collector
with the set of elements passing the filter in another collector.

#### Remarks

The result will be the same as using a LogicalAndFilter to connect this filter with another.
If you have an active iterator to this collector it will be stopped by this call.

#### Parameter `other`

The other collector

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The collector does not have a filter applied. Extraction or iteration of elements is not permitted without a filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of elements is not permitted without a filter.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.WherePasses(Autodesk.Revit.DB.ElementFilter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.WherePasses(Autodesk.Revit.DB.ElementFilter)`

#### Summary

Applies an element filter to the collector.

#### Remarks

The filter will be added as an additional condition that all filtered elements must pass.
If you have an active iterator to this collector it will be stopped by this call.

#### Parameter `filter`

The element filter.

#### Returns

A handle to this collector. This is the same collector that has just been modified, returned
so you can chain multiple calls together in one line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.FilteredElementCollector.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.FilteredElementCollector.GetElementIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.GetElementIterator`

#### Summary

Returns an element iterator to the elements passing the filters.

#### Remarks

Calling this when you have an active iterator to this same collector will result in the first iterator being
stopped by this call.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of elements is not permitted without a filter.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.GetElementIdIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.GetElementIdIterator`

#### Summary

Returns an element id iterator to the elements passing the filters.

#### Remarks

Calling this when you have an active iterator to this same collector will result in the first iterator being
stopped by this call.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The collector does not have a filter applied. Extraction or iteration of elements is not permitted without a filter.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.OfCategory(Autodesk.Revit.DB.BuiltInCategory)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.OfCategory(Autodesk.Revit.DB.BuiltInCategory)`

#### Summary

Applies an ElementCategoryFilter to the collector.

#### Remarks

Only elements of this category id will pass the collector.

#### Parameter `category`

The category.

#### Returns

This collector.

### `M:Autodesk.Revit.DB.FilteredElementCollector.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a new FilteredElementCollector that will search and filter the visible elements from
a Revit link in a host document view.

#### Remarks

Only visible elements belonging to the link instance will be returned. Other instances of
that link may have different element visibility in a given view.

Elements that will be passed by the collector have graphics that may be visible in
the input view. Some elements may still be hidden because they are obscured by other elements.

For elements which are outside of a crop region, they may still be passed by the collector because
Revit relies on later processing to eliminate the elements hidden by the crop.
This effect may more easily occur for non-rectangular crop regions, but may also happen even for rectangular crops.
You can compare the boundary of the region with the element's boundary if more precise results are required.

Accessing these visible elements may require Revit to rebuild the geometry of the view.
The first time your code constructs a collector for a given view, or the first time
your code constructs a collector for a view whose display settings have just been changed,
you may experience a significant performance degradation.

#### Parameter `hostDocument`

The document that owns the view.

#### Parameter `viewId`

The view id in the host document.

#### Parameter `linkId`

The Revit link instance id in the host document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

viewId is not a view.
-or-
linkId does not refer to a valid link document.
-or-
viewId is not valid for element iteration, because it has no way of representing drawn elements. Many view templates
will fail this check.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.FilteredElementCollector.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a new FilteredElementCollector that will search and filter the visible elements in a view.

#### Remarks

Elements that will be passed by the collector have graphics that may be visible in
the input view. Some elements may still be hidden because they are obscured by other elements.

For elements which are outside of a crop region, they may still be passed by the collector because
Revit relies on later processing to eliminate the elements hidden by the crop.
This effect may more easily occur for non-rectangular crop regions, but may also happen even for rectangular crops.
You can compare the boundary of the region with the element's boundary if more precise results are required.

Accessing these visible elements may require Revit to rebuild the geometry of the view.
The first time your code constructs a collector for a given view, or the first time
your code constructs a collector for a view whose display settings have just been changed,
you may experience a significant performance degradation.

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

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.#ctor(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.#ctor(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Constructs a new FilteredElementCollector that will search and filter a specified set of elements.

#### Parameter `document`

The document that owns the elements matching the element ids.

#### Parameter `elementIds`

The input set of element ids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input collection of ids was empty, or its contents were not valid for iteration.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementCollector.#ctor(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementCollector.#ctor(Autodesk.Revit.DB.Document)`

#### Summary

Constructs a new FilteredElementCollector that will search and filter the set of elements in a document.

#### Parameter `document`

The document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.FilteredElementCollector`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilteredElementCollector`

#### Summary

This class is used to search, filter and iterate through a set of elements.

#### Remarks

Developers can assign a variety of conditions to filter the elements that are returned.
This class requires that at least one condition be set before making the attempt to access the elements.

Revit will attempt to organize the filters in order to minimize expansion of elements regardless of
the order in which conditions and filters are applied.

There are three groups of methods that you can use on a given collector once you have applied filter(s)
to it. One group provides collections of all passing elements, a second finds the first match of the given
filter(s), and a third provides an iterator that is evaluated lazily (each element is tested by the filter
only when the iterator reaches it). You should only use
one of the methods from these group at a time; the collector will reset if you call another method to
extract elements. Thus, if you have previously obtained an iterator, it will be stopped and traverse no more
elements if you call another method to extract elements.

In .NET, this class supports the IEnumerable interface for Elements. You can use this class with
LINQ queries and operations to process lists of elements. Note that because the ElementFilters
and the shortcut methods offered by this class process elements in native code before their
managed wrappers are generated, better performance will be obtained by using as many native filters
as possible on the collector before attempting to process the results using LINQ queries.

One special consideration when using this class in .NET: the debugger will attempt
to traverse the members of the collector because of its implementation of IEnumerable. You may see strange
results if you also attempt to extract the first element or all elements from the collector while the debugger
is also looking at the contents of the collector.

#### Since

2011

### `P:Autodesk.Revit.DB.FilteredElementIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredElementIterator.CurrentObject`

### `P:Autodesk.Revit.DB.FilteredElementIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredElementIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.FilteredElementIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementIterator.Reset`

#### Summary

Resets the iterator to the beginning.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The FilteredElementCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more matching elements. False if there are more element ids to be iterated.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The FilteredElementCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementIterator.MoveNext`

#### Summary

Increments the iterator to the next element passing the filter.

#### Returns

True if there is another available element passing the filter in this iterator.
False if the iterator has completed all available elements.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The FilteredElementCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.
-or-
The iterator cannot proceed due to changes made to the Element table in Revit's database (typically,
This can be the result of an Element deletion).

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementIterator.GetCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementIterator.GetCurrent`

#### Summary

The current element found by the iterator.

#### Returns

The element.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There are no more element ids in the iterator.
-or-
The FilteredElementCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.
-or-
The iterator cannot proceed due to changes made to the Element table in Revit's database (typically,
This can be the result of an Element deletion).

#### Since

2011

### `P:Autodesk.Revit.DB.FilteredElementIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredElementIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FilteredElementIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilteredElementIterator`

#### Summary

An iterator to a set of elements filtered by the settings of a FilteredElementCollector.

#### Since

2011

### `P:Autodesk.Revit.DB.FilteredElementIdIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredElementIdIterator.CurrentObject`

### `P:Autodesk.Revit.DB.FilteredElementIdIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredElementIdIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.FilteredElementIdIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementIdIterator.Reset`

#### Summary

Resets the iterator to the beginning.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The FilteredElementCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementIdIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementIdIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more matching elements. False if there are more element ids to be iterated.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The FilteredElementCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementIdIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementIdIterator.MoveNext`

#### Summary

Increments the iterator to the next element id passing the filter.

#### Returns

True if there is another available element id passing the filter in this iterator.
False if the iterator has completed all available element ids.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The FilteredElementCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.
-or-
The iterator cannot proceed due to changes made to the Element table in Revit's database (typically, this can be the result of an Element deletion).

#### Since

2011

### `M:Autodesk.Revit.DB.FilteredElementIdIterator.GetCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilteredElementIdIterator.GetCurrent`

#### Summary

The current element id found by the iterator.

#### Returns

The element id.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There are no more element ids in the iterator.
-or-
The FilteredElementCollector that yielded this iterator has been reset by another operation.
No further iteration is permitted with this iterator.
-or-
The iterator cannot proceed due to changes made to the Element table in Revit's database (typically, this can be the result of an Element deletion).

#### Since

2011

### `P:Autodesk.Revit.DB.FilteredElementIdIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilteredElementIdIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FilteredElementIdIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilteredElementIdIterator`

#### Summary

An iterator to a set of element ids filtered by the settings of a FilteredElementCollector.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterCategoryRule.AllCategoriesFilterable(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterCategoryRule.AllCategoriesFilterable(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Checks that all of the given categories are filterable.

#### Parameter `categories`

The set of categories to check.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FilterCategoryRule.SetCategories(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterCategoryRule.SetCategories(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets the rule's categories.

#### Parameter `categories`

The categories.

#### Returns

True if the set of categories was changed, false if no change was necessary.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One of the given categories is not filterable

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FilterCategoryRule.GetCategories`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterCategoryRule.GetCategories`

#### Summary

Gets the rule's categories.

#### Since

2014

### `M:Autodesk.Revit.DB.FilterCategoryRule.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterCategoryRule.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Constructs a new instance of FilterCategoryRule.

#### Parameter `categories`

The set of categories.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.FilterCategoryRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterCategoryRule`

#### Summary

A filter rule that matches elements of a set of categories.

#### Since

2014

### `P:Autodesk.Revit.DB.FilterGlobalParameterAssociationRule.RuleValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilterGlobalParameterAssociationRule.RuleValue`

#### Summary

The user-supplied global parameter value against which values from a Revit document will be tested.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.FilterGlobalParameterAssociationRule.#ctor(Autodesk.Revit.DB.FilterableValueProvider,Autodesk.Revit.DB.FilterNumericRuleEvaluator,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterGlobalParameterAssociationRule.#ctor(Autodesk.Revit.DB.FilterableValueProvider,Autodesk.Revit.DB.FilterNumericRuleEvaluator,Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs an instance of FilterGlobalParameterAssociationRule.

#### Parameter `valueProvider`

A pointer to a "value provider" object that will extract values from a Revit document.

#### Parameter `evaluator`

A pointer to the filter rule evaluator object that implements the desired test.
The built-in evaluators implement commonly used tests such as less-than, greater-than
less-than-or-equal-to, equal, etc.

#### Parameter `ruleValue`

The user-supplied global parameter value against which values from a Revit document will be tested.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.FilterGlobalParameterAssociationRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterGlobalParameterAssociationRule`

#### Summary

A filter rule that operates on global parameters ElementId values in a Revit project.

#### Since

2017

### `M:Autodesk.Revit.DB.FilterElementIdRule.UsesLevelFiltering(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterElementIdRule.UsesLevelFiltering(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

This function checks if a parameter uses level filtering.

#### Remarks

When level-filtering parameters are compared, the comparisons will
first compare the values of the levels' elevations, then compare the
levels' names, and finally the levels' element ids to rank and sort the levels.

#### Parameter `doc`

The document which owns the parameter.

#### Parameter `parameterId`

The id of the parameter that will be tested to see if it uses level filtering.

#### Returns

True if the parameter uses level filtering, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.FilterElementIdRule.RuleValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilterElementIdRule.RuleValue`

#### Summary

The user-supplied value against which values from a Revit document will be tested.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterElementIdRule.#ctor(Autodesk.Revit.DB.FilterableValueProvider,Autodesk.Revit.DB.FilterNumericRuleEvaluator,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterElementIdRule.#ctor(Autodesk.Revit.DB.FilterableValueProvider,Autodesk.Revit.DB.FilterNumericRuleEvaluator,Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs an instance of FilterElementIdRule.

#### Parameter `valueProvider`

A pointer to a "value provider" object that will extract values from a Revit document.

#### Parameter `evaluator`

A pointer to the filter rule evaluator object that implements the desired test.
The built-in evaluators implement commonly used tests such as less-than, greater-than
less-than-or-equal-to, equal, etc.

#### Parameter `ruleValue`

The user-supplied value against which values from a Revit document will be tested.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.FilterElementIdRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterElementIdRule`

#### Summary

A filter rule that operates on ElementId values in a Revit project.

#### Remarks

When `M:Autodesk.Revit.DB.FilterRule.GetRuleParameter` returns a parameter
that `M:Autodesk.Revit.DB.FilterElementIdRule.UsesLevelFiltering(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)` ,
then the comparisons will first compare the values of the levels' elevations, then compare
the levels' names, and finally the levels' element ids to rank and sort the levels.

#### Since

2011

### `P:Autodesk.Revit.DB.FilterIntegerRule.RuleValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilterIntegerRule.RuleValue`

#### Summary

The user-supplied value against which values from a Revit document will be tested.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterIntegerRule.#ctor(Autodesk.Revit.DB.FilterableValueProvider,Autodesk.Revit.DB.FilterNumericRuleEvaluator,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterIntegerRule.#ctor(Autodesk.Revit.DB.FilterableValueProvider,Autodesk.Revit.DB.FilterNumericRuleEvaluator,System.Int32)`

#### Summary

Constructs an instance of FilterIntegerRule.

#### Parameter `valueProvider`

A pointer to a "value provider" object that will extract values from a Revit document.

#### Parameter `evaluator`

A pointer to the filter rule evaluator object that implements the desired test.
The built-in evaluators implement commonly used tests such as less-than, greater-than
less-than-or-equal-to, equal, etc.

#### Parameter `ruleValue`

The user-supplied value against which values from a Revit document will be tested.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.FilterIntegerRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterIntegerRule`

#### Summary

A filter rule that operates on integer values in a Revit project.

#### Since

2011

### `P:Autodesk.Revit.DB.FilterDoubleRule.Epsilon`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilterDoubleRule.Epsilon`

#### Summary

The tolerance within which two floating-point values may be considered equal.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for epsilon is not finite
-or-
When setting this property: The given value for epsilon is not a number

#### Since

2011

### `P:Autodesk.Revit.DB.FilterDoubleRule.RuleValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilterDoubleRule.RuleValue`

#### Summary

The user-supplied value against which values from a Revit document will be tested.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for ruleValue is not finite
-or-
When setting this property: The given value for ruleValue is not a number

#### Since

2011

### `M:Autodesk.Revit.DB.FilterDoubleRule.#ctor(Autodesk.Revit.DB.FilterableValueProvider,Autodesk.Revit.DB.FilterNumericRuleEvaluator,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterDoubleRule.#ctor(Autodesk.Revit.DB.FilterableValueProvider,Autodesk.Revit.DB.FilterNumericRuleEvaluator,System.Double,System.Double)`

#### Summary

Constructs an instance of FilterDoubleRule.

#### Parameter `valueProvider`

A pointer to a "value provider" object that will extract values from a Revit document.

#### Parameter `evaluator`

A pointer to the filter rule evaluator object that implements the desired test.
The built-in evaluators implement commonly used tests such as less-than, greater-than
less-than-or-equal-to, equal, etc.

#### Parameter `ruleValue`

The user-supplied value against which values from a Revit document will be tested.

#### Parameter `epsilon`

The tolerance within which two floating-point values may be considered equal.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for ruleValue is not finite
-or-
The given value for ruleValue is not a number
-or-
The given value for epsilon is not finite
-or-
The given value for epsilon is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.FilterDoubleRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterDoubleRule`

#### Summary

A filter rule that operates on double-precision numeric values in a Revit project.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterNumericValueRule.SetEvaluator(Autodesk.Revit.DB.FilterNumericRuleEvaluator)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterNumericValueRule.SetEvaluator(Autodesk.Revit.DB.FilterNumericRuleEvaluator)`

#### Summary

Sets the evaluator that implements the test for this rule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterNumericValueRule.GetEvaluator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterNumericValueRule.GetEvaluator`

#### Summary

Gets the evaluator that implements the test for this rule.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterNumericValueRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterNumericValueRule`

#### Summary

Base for all classes that use a FilterNumericRuleEvaluator to perform their comparisons

#### Since

2011

### `M:Autodesk.Revit.DB.FilterNumericEquals.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterNumericEquals.#ctor`

#### Summary

Constructs an instance of FilterNumericEquals.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterNumericEquals`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterNumericEquals`

#### Summary

Tests whether numeric values from the document are equal to a certain value

#### Since

2011

### `M:Autodesk.Revit.DB.FilterNumericGreaterOrEqual.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterNumericGreaterOrEqual.#ctor`

#### Summary

Constructs an instance of FilterNumericGreaterOrEqual.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterNumericGreaterOrEqual`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterNumericGreaterOrEqual`

#### Summary

Tests whether numeric values from the document are greater than or equal to a certain value

#### Since

2011

### `M:Autodesk.Revit.DB.FilterNumericGreater.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterNumericGreater.#ctor`

#### Summary

Constructs an instance of FilterNumericGreater.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterNumericGreater`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterNumericGreater`

#### Summary

Tests whether numeric values from the document are greater than a certain value

#### Since

2011

### `M:Autodesk.Revit.DB.FilterNumericLessOrEqual.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterNumericLessOrEqual.#ctor`

#### Summary

Constructs an instance of FilterNumericLessOrEqual.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterNumericLessOrEqual`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterNumericLessOrEqual`

#### Summary

Tests whether numeric values from the document are less than or equal to a certain value

#### Since

2011

### `M:Autodesk.Revit.DB.FilterNumericLess.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterNumericLess.#ctor`

#### Summary

Constructs an instance of FilterNumericLess.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterNumericLess`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterNumericLess`

#### Summary

Tests whether numeric values from the document are less than a certain value

#### Since

2011

### `M:Autodesk.Revit.DB.FilterNumericRuleEvaluator.Evaluate(System.Int64,System.Int64)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterNumericRuleEvaluator.Evaluate(System.Int64,System.Int64)`

#### Summary

Derived classes should override this method to implement the desired test.

#### Parameter `lhs`

A value from an element in the document.

#### Parameter `rhs`

The user-supplied value against which values from the document are tested.

#### Returns

True if lhs, rhs satisfy the condition implemented by this evaluator.

#### Since

2024

### `M:Autodesk.Revit.DB.FilterNumericRuleEvaluator.Evaluate(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterNumericRuleEvaluator.Evaluate(System.Int32,System.Int32)`

#### Summary

Derived classes should override this method to implement the desired test.

#### Parameter `lhs`

A value from an element in the document.

#### Parameter `rhs`

The user-supplied value against which values from the document are tested.

#### Returns

True if lhs, rhs satisfy the condition implemented by this evaluator.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterNumericRuleEvaluator.Evaluate(System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterNumericRuleEvaluator.Evaluate(System.Double,System.Double,System.Double)`

#### Summary

Derived classes override this method to implement the test that determines
whether the two given double-precision values satisfy the desired condition or not.

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

#### Parameter `epsilon`

Defines the tolerance within which two values may be considered equal.

#### Returns

True if the given arguments satisfy the condition, otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for lhs is not finite
-or-
The given value for lhs is not a number
-or-
The given value for rhs is not finite
-or-
The given value for rhs is not a number
-or-
The given value for epsilon is not finite
-or-
The given value for epsilon is not a number

#### Since

2011

### `P:Autodesk.Revit.DB.FilterNumericRuleEvaluator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilterNumericRuleEvaluator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FilterNumericRuleEvaluator`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterNumericRuleEvaluator`

#### Summary

Base for all classes that compare numeric values from Revit to a user-supplied filter value.

#### Remarks

A class derived from FilterNumericRuleEvaluator must handle both integer and double-precision types.
For double-precision comparisons, an epsilon value is given. The evaluator class should use this
value in a manner appropriate to the comparison being implemented.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterStringRule.SetEvaluator(Autodesk.Revit.DB.FilterStringRuleEvaluator)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterStringRule.SetEvaluator(Autodesk.Revit.DB.FilterStringRuleEvaluator)`

#### Summary

Sets the evaluator that implements the test for this rule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterStringRule.GetEvaluator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterStringRule.GetEvaluator`

#### Summary

Gets the evaluator that implements the test for this rule.

#### Since

2011

### `P:Autodesk.Revit.DB.FilterStringRule.RuleString`

Member kind: property
Symbol: `Autodesk.Revit.DB.FilterStringRule.RuleString`

#### Summary

The user-supplied string against which strings from a Revit document will be tested.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FilterStringRule.#ctor(Autodesk.Revit.DB.FilterableValueProvider,Autodesk.Revit.DB.FilterStringRuleEvaluator,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterStringRule.#ctor(Autodesk.Revit.DB.FilterableValueProvider,Autodesk.Revit.DB.FilterStringRuleEvaluator,System.String)`

#### Summary

Constructs an instance of FilterStringRule.

#### Parameter `valueProvider`

A pointer to a "value provider" object that will extract values from a Revit document.

#### Parameter `evaluator`

A pointer to the filter rule evaluator object that implements the desired test.
The built-in evaluators implement commonly used tests for strings such as begins-with,
ends-with, contains, equal, etc.

#### Parameter `ruleString`

The user-supplied string against which strings from a Revit document will be tested.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.FilterStringRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterStringRule`

#### Summary

A filter rule that operates on string values in a Revit project.

#### Remarks

All string comparisons in this class are performed in the case-insensitive manner.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterStringLessOrEqual.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterStringLessOrEqual.#ctor`

#### Summary

Constructs an instance of FilterStringLessOrEqual.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterStringLessOrEqual`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterStringLessOrEqual`

#### Summary

Tests whether string values from the document would sort before or match a certain string.

#### Remarks

All string comparisons in this class are performed in the case-insensitive manner.

#### Since

2011

### `M:Autodesk.Revit.DB.FilterStringLess.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilterStringLess.#ctor`

#### Summary

Constructs an instance of FilterStringLess.

#### Since

2011

### `T:Autodesk.Revit.DB.FilterStringLess`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilterStringLess`

#### Summary

Tests whether string values from the document would sort before a certain string.

#### Remarks

All string comparisons in this class are performed in the case-insensitive manner.

#### Since

2011
