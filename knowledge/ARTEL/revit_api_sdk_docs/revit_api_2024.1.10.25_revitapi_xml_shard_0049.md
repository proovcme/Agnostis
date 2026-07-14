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
Shard: 49
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.GetSpecificFittingAngles`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.GetSpecificFittingAngles`

#### Summary

Gets the list of specific fitting angles.

#### Remarks

Revit will only use the angles specified during the cable tray or conduit layout or modifying the layout.
When laying out the cable tray or conduit, if the angle between two cable trays or conduits is close to the allowed angle,
The specific angle is used for that cable tray or conduit fitting.

#### Returns

Angles (in degrees).

#### Since

2014

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.GetCircuitNamingSchemeSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.GetCircuitNamingSchemeSettings(Autodesk.Revit.DB.Document)`

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

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.GetElectricalSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.GetElectricalSettings(Autodesk.Revit.DB.Document)`

#### Summary

Get the electrical settings of the project.

#### Parameter `document`

The document.

#### Returns

The electrical settings of the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitSequence`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitSequence`

#### Summary

The sequence in which power circuits are created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015 Subscription Update

### `P:Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitLoadCalculationMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitLoadCalculationMethod`

#### Summary

The method to calculate circuit load

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `P:Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitPathOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitPathOffset`

#### Summary

The default circuit path offset for newly created circuit.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitRating`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitRating`

#### Summary

The default circuit rating for newly created circuit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The circuit rating should be non-negative.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitNamePhaseC`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitNamePhaseC`

#### Summary

Circuit Naming by Phase - Phase C Label.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015 Subscription Update

### `P:Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitNamePhaseB`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitNamePhaseB`

#### Summary

Circuit Naming by Phase - Phase B Label.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015 Subscription Update

### `P:Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitNamePhaseA`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.CircuitNamePhaseA`

#### Summary

Circuit Naming by Phase - Phase A Label.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.RemoveWireType(Autodesk.Revit.DB.Electrical.WireType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.RemoveWireType(Autodesk.Revit.DB.Electrical.WireType)`

#### Summary

Remove wire type definition from project.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Wire type can be removed only if it is not used, otherwise an exception will be thrown.

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.AddWireType(System.String,Autodesk.Revit.DB.Electrical.WireMaterialType,Autodesk.Revit.DB.Electrical.TemperatureRatingType,Autodesk.Revit.DB.Electrical.InsulationType,Autodesk.Revit.DB.Electrical.WireSize,System.Double,System.Boolean,Autodesk.Revit.DB.Electrical.NeutralMode,Autodesk.Revit.DB.Electrical.WireConduitType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.AddWireType(System.String,Autodesk.Revit.DB.Electrical.WireMaterialType,Autodesk.Revit.DB.Electrical.TemperatureRatingType,Autodesk.Revit.DB.Electrical.InsulationType,Autodesk.Revit.DB.Electrical.WireSize,System.Double,System.Boolean,Autodesk.Revit.DB.Electrical.NeutralMode,Autodesk.Revit.DB.Electrical.WireConduitType)`

#### Summary

Add a new wire type to project.

#### Parameter `name`

Name of the new wire type.

#### Parameter `materialType`

Wire material of new wire type.

#### Parameter `temperatureRating`

Temperature rating type information of new wire type.

#### Parameter `insulation`

Insulation of new wire type.

#### Parameter `maxSize`

Max wire size of new wire type.

#### Parameter `neutralMultiplier`

Neutral multiplier of new wire type.

#### Parameter `neutralRequired`

Specify whether neutral point is required.

#### Parameter `neutralMode`

Specify neutral mode.

#### Parameter `conduit`

Conduit type of new wire type.

#### Returns

New added wire type object.

#### Remarks

Parameter of temperatureRating should be retrieved from parameter of materialType,
and parameters such as insulation and maxSize should be retrieved from temperatureRating.
otherwise, this add operation is most likely to fail.

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.RemoveWireMaterialType(Autodesk.Revit.DB.Electrical.WireMaterialType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.RemoveWireMaterialType(Autodesk.Revit.DB.Electrical.WireMaterialType)`

#### Summary

Remove the wire material type from project.

#### Parameter `materialType`

The wire material type to be removed.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Wire material type can be removed only if it is not currently assigned to any wire type,
and the last one wire material type can't be removed, otherwise an exception will be thrown.

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.AddWireMaterialType(System.String,Autodesk.Revit.DB.Electrical.WireMaterialType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.AddWireMaterialType(System.String,Autodesk.Revit.DB.Electrical.WireMaterialType)`

#### Summary

Add a new type of wire material.

#### Parameter `name`

Name of new material type.

#### Parameter `baseMaterial`

Specify an existing material type which New material will be constructed based on.

#### Returns

New added wire material type object.

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.RemoveDistributionSysType(Autodesk.Revit.DB.Electrical.DistributionSysType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.RemoveDistributionSysType(Autodesk.Revit.DB.Electrical.DistributionSysType)`

#### Summary

Remove an existing distribution system type from the project.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Distribution system type can be removed only if it is not currently assigned to any devices, otherwise an exception will be thrown.

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.AddDistributionSysType(System.String,Autodesk.Revit.DB.Electrical.ElectricalPhase,Autodesk.Revit.DB.Electrical.ElectricalPhaseConfiguration,System.Int32,Autodesk.Revit.DB.Electrical.VoltageType,Autodesk.Revit.DB.Electrical.VoltageType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.AddDistributionSysType(System.String,Autodesk.Revit.DB.Electrical.ElectricalPhase,Autodesk.Revit.DB.Electrical.ElectricalPhaseConfiguration,System.Int32,Autodesk.Revit.DB.Electrical.VoltageType,Autodesk.Revit.DB.Electrical.VoltageType)`

#### Summary

Add a new distribution system type to project.

#### Parameter `name`

The name of new added distribution system type

#### Parameter `phase`

Single or three phase this type is

#### Parameter `phaseConfig`

Configuration property of given phase

#### Parameter `numWire`

Wire number of this distribution system

#### Parameter `volLineToLine`

Type of line to line voltage in this system

#### Parameter `volLineToGround`

Type of line to ground voltage in this system

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The name can't be `null` , empty string, or equal with any existing one,
phaseConfig should be defined and numWire can only be 3 or 4 in case of three phase,
numWire can only be 2 or 3 in case of single phase,
otherwise exception will be thrown.

#### Returns

New added distribution system type object.

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.RemoveVoltageType(Autodesk.Revit.DB.Electrical.VoltageType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.RemoveVoltageType(Autodesk.Revit.DB.Electrical.VoltageType)`

#### Summary

Remove the voltage type from project.

#### Parameter `voltageType`

Specify the voltage type to be removed.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Voltage type can be removed only if it isn't in service with any distribution systems.

### `M:Autodesk.Revit.DB.Electrical.ElectricalSetting.AddVoltageType(System.String,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.AddVoltageType(System.String,System.Double,System.Double,System.Double)`

#### Summary

Add a new type definition of voltage into project.

#### Parameter `name`

Specify voltage type name

#### Parameter `actualValue`

Specify actual value of voltage type.

#### Parameter `minValue`

Specify acceptable minimum value of the voltage type.

#### Parameter `maxValue`

Specify acceptable maximum value of the voltage type.

#### Returns

New added voltage type object.

### `P:Autodesk.Revit.DB.Electrical.ElectricalSetting.WireConduitTypes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.WireConduitTypes`

#### Summary

Get electrical conduit types information of the project.

### `P:Autodesk.Revit.DB.Electrical.ElectricalSetting.WireMaterialTypes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.WireMaterialTypes`

#### Summary

Get electrical wire material types information of the project.

### `P:Autodesk.Revit.DB.Electrical.ElectricalSetting.DistributionSysTypes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.DistributionSysTypes`

#### Summary

Get all distribution system types of the project.

### `P:Autodesk.Revit.DB.Electrical.ElectricalSetting.WireTypes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.WireTypes`

#### Summary

Get all wire type definition information of the project.

### `P:Autodesk.Revit.DB.Electrical.ElectricalSetting.VoltageTypes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting.VoltageTypes`

#### Summary

Get all voltage type definitions information of the project.

### `T:Autodesk.Revit.DB.Electrical.ElectricalSetting`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSetting`

#### Summary

The ElectricalSetting class represents an instance of element of electrical settings.

#### Since

2011

### `T:Autodesk.Revit.DB.Electrical.CircuitLoadCalculationMethod`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CircuitLoadCalculationMethod`

#### Summary

Methods to calculate circuit loads

#### Since

2017

### `F:Autodesk.Revit.DB.Electrical.CircuitLoadCalculationMethod.SumApparentLoad`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.CircuitLoadCalculationMethod.SumApparentLoad`

#### Summary

Sum apparent load.

### `F:Autodesk.Revit.DB.Electrical.CircuitLoadCalculationMethod.SumTrueLoadAndReactiveLoad`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.CircuitLoadCalculationMethod.SumTrueLoadAndReactiveLoad`

#### Summary

Sum true load and reactive load.

### `T:Autodesk.Revit.DB.Electrical.CircuitSequence`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CircuitSequence`

#### Summary

Options of circuit sequence for assigning circuit to circuits across panel.

#### Since

2015 Subscription Update

### `F:Autodesk.Revit.DB.Electrical.CircuitSequence.OddThenEven`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.CircuitSequence.OddThenEven`

#### Summary

Create new circuits odd then even (1,3,5,7,9,11 / 2,4,6,8,10,12).

### `F:Autodesk.Revit.DB.Electrical.CircuitSequence.GroupByPhase`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.CircuitSequence.GroupByPhase`

#### Summary

Create new circuits group by phase (1,3,5 / 2,4,6 / 7,9,11 / 8,10,12).

### `F:Autodesk.Revit.DB.Electrical.CircuitSequence.Numerical`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.CircuitSequence.Numerical`

#### Summary

Create new circuits numerically (1,2,3,4,5,6,7,8,9,10,11,12).

### `T:Autodesk.Revit.DB.Electrical.CapitalizationForLoadNames`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CapitalizationForLoadNames`

#### Summary

Enumerated type listing the options for how electrical load names should be capitalized.

#### Since

2012

### `F:Autodesk.Revit.DB.Electrical.CapitalizationForLoadNames.Upper`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.CapitalizationForLoadNames.Upper`

#### Summary

Capitalize all letters of every word in the load name.

### `F:Autodesk.Revit.DB.Electrical.CapitalizationForLoadNames.Sentence`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.CapitalizationForLoadNames.Sentence`

#### Summary

Capitalize only the first letter of the first word in the load name.

### `F:Autodesk.Revit.DB.Electrical.CapitalizationForLoadNames.Initial`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.CapitalizationForLoadNames.Initial`

#### Summary

Capitalize the first letter of each word in the load name.

### `F:Autodesk.Revit.DB.Electrical.CapitalizationForLoadNames.SourceParameters`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.CapitalizationForLoadNames.SourceParameters`

#### Summary

Use the capitalization formatting taken from the parameters that create the load name (Revit 2011 and previous).

### `P:Autodesk.Revit.DB.Electrical.WireType.IsInUse`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireType.IsInUse`

#### Summary

Indicates whether the wire type is in use.

### `P:Autodesk.Revit.DB.Electrical.WireType.Conduit`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireType.Conduit`

#### Summary

The conduit type of the wire type.

### `P:Autodesk.Revit.DB.Electrical.WireType.NeutralSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireType.NeutralSize`

#### Summary

The maximum neutral size of the wire type.

### `P:Autodesk.Revit.DB.Electrical.WireType.NeutralRequired`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireType.NeutralRequired`

#### Summary

Whether or not the neutral point is required.

### `P:Autodesk.Revit.DB.Electrical.WireType.NeutralMultiplier`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireType.NeutralMultiplier`

#### Summary

The neutral multiplier type of the wire type.

### `P:Autodesk.Revit.DB.Electrical.WireType.MaxSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireType.MaxSize`

#### Summary

The max size of the wire type.

### `P:Autodesk.Revit.DB.Electrical.WireType.Insulation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireType.Insulation`

#### Summary

The insulation type.

### `P:Autodesk.Revit.DB.Electrical.WireType.TemperatureRating`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireType.TemperatureRating`

#### Summary

The temperature rating type of the wire type.

#### Remarks

Should retrieved from relevant WireMaterial object.

### `P:Autodesk.Revit.DB.Electrical.WireType.WireMaterial`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireType.WireMaterial`

#### Summary

The material type of the wire type.

### `T:Autodesk.Revit.DB.Electrical.WireType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireType`

#### Summary

Represents a specific wire type.

### `T:Autodesk.Revit.DB.Electrical.NeutralMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.NeutralMode`

#### Summary

An enumerated type to list the neutral mode for wire type.

### `F:Autodesk.Revit.DB.Electrical.NeutralMode.UnbalancedCurrent`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.NeutralMode.UnbalancedCurrent`

#### Summary

Neutral Mode is UnbalancedCurrent.

### `F:Autodesk.Revit.DB.Electrical.NeutralMode.HotConductorSize`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.NeutralMode.HotConductorSize`

#### Summary

Neutral Mode is HotConductorSize.

### `T:Autodesk.Revit.DB.Electrical.WireConduitType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitType`

#### Summary

Represents a specific conduit type of wire type.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialType.RemoveGroundConductorSize(Autodesk.Revit.DB.Electrical.GroundConductorSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialType.RemoveGroundConductorSize(Autodesk.Revit.DB.Electrical.GroundConductorSize)`

#### Summary

Remove an existing ground conductor size from this material type.

#### Parameter `grdConductorSize`

The ground size type to be removed.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialType.AddGroundConductorSize(System.Int64,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialType.AddGroundConductorSize(System.Int64,System.String)`

#### Summary

Add new electrical ground conductor size type into this material type.

#### Parameter `ampacity`

Ampacity of ground conductor size to be added.

#### Parameter `size`

Size of ground conductor size to be added.

#### Returns

New added ground conductor size.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialType.RemoveTemperatureRatingType(Autodesk.Revit.DB.Electrical.TemperatureRatingType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialType.RemoveTemperatureRatingType(Autodesk.Revit.DB.Electrical.TemperatureRatingType)`

#### Summary

Remove an existing temperature rating type from this material type.

#### Parameter `temperatureRating`

The temperature rating type to be removed.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The last temperature rating type of project and any one used by a wire type can't be removed.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialType.AddTemperatureRatingType(System.String,Autodesk.Revit.DB.Electrical.TemperatureRatingType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialType.AddTemperatureRatingType(System.String,Autodesk.Revit.DB.Electrical.TemperatureRatingType)`

#### Summary

Add a new temperature rating type into material type.

#### Parameter `name`

Name of temperature type to be added.

#### Parameter `baseOn`

The new temperature rating will be created base on this existing temperature rating type.

#### Returns

New constructed temperature rating type.

### `P:Autodesk.Revit.DB.Electrical.WireMaterialType.IsInUse`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialType.IsInUse`

#### Summary

Indicate whether the wire material type is in use.

### `P:Autodesk.Revit.DB.Electrical.WireMaterialType.GroundConductorSizes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialType.GroundConductorSizes`

#### Summary

Get all ground conductor size types defined in this wire material type.

### `P:Autodesk.Revit.DB.Electrical.WireMaterialType.TemperatureRatings`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialType.TemperatureRatings`

#### Summary

Get all temperature rating type definitions defined in this wire material type.

### `P:Autodesk.Revit.DB.Electrical.WireMaterialType.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialType.Name`

#### Summary

Get name of wire material type.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Set name can't be supported.

### `T:Autodesk.Revit.DB.Electrical.WireMaterialType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialType`

#### Summary

Represents electrical wire material type definition information of wire type.

#### Remarks

All the other properties of wire type are based on wire material type.
Only the wire material types which are retrieved from ElectricalSetting can work well, so don't retrieve it from Revit project directly.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingType.RemoveCorrectionFactor(Autodesk.Revit.DB.Electrical.CorrectionFactor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingType.RemoveCorrectionFactor(Autodesk.Revit.DB.Electrical.CorrectionFactor)`

#### Summary

Remove an existing correction factor from this temperature rating type in Revit MEP project.

#### Parameter `correctionFactor`

The correction factor to be removed.

#### Returns

New constructed correction factor.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingType.AddCorrectionFactor(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingType.AddCorrectionFactor(System.Double,System.Double)`

#### Summary

Add a new electrical correction factor type to this temperature rating type. The given temperature
value should be quantified in the document's selected unit of electrical temperature.

#### Parameter `temperature`

Temperature of correction factor to be added in the document's selected unit of electrical temperature.

#### Parameter `factor`

Factor of correction factor to be added.

#### Returns

New constructed correction factor.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingType.RemoveWireSize(Autodesk.Revit.DB.Electrical.WireSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingType.RemoveWireSize(Autodesk.Revit.DB.Electrical.WireSize)`

#### Summary

Remove an existing wire size type from this temperature rating type.

#### Parameter `wireSize`

The wire size type to be removed.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingType.AddWireSize(System.String,System.Int64,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingType.AddWireSize(System.String,System.Int64,System.Double)`

#### Summary

Add a new kind of wire size type into this temperature rating type.

#### Parameter `size`

Size of wire size.

#### Parameter `ampacity`

Ampacity of wire size to be added.

#### Parameter `diameter`

Diameter of wire size to be added.

#### Returns

Constructed wire size type.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingType.RemoveInsulationType(Autodesk.Revit.DB.Electrical.InsulationType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingType.RemoveInsulationType(Autodesk.Revit.DB.Electrical.InsulationType)`

#### Summary

Remove an existing insulation type from this temperature rating type.

#### Parameter `insulationType`

Insulation type to be removed.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The last one insulation type of project and any one which is in use by a wire type can't be removed.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingType.AddInsulationType(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingType.AddInsulationType(System.String)`

#### Summary

Add a new kind of insulation type into this temperature rating type.

#### Parameter `name`

Name of insulation type symbol to be constructed and added.

#### Returns

Constructed insulation type instance.

### `P:Autodesk.Revit.DB.Electrical.TemperatureRatingType.IsInUse`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingType.IsInUse`

#### Summary

Indicate whether the temperature rating type is in use.

### `P:Autodesk.Revit.DB.Electrical.TemperatureRatingType.CorrectionFactors`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingType.CorrectionFactors`

#### Summary

Get all correction factors defined in this temperature rating type and its corresponding material type.

### `P:Autodesk.Revit.DB.Electrical.TemperatureRatingType.WireSizes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingType.WireSizes`

#### Summary

Get all electrical wire sizes defined in this temperature rating type and its corresponding material type.

### `P:Autodesk.Revit.DB.Electrical.TemperatureRatingType.InsulationTypes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingType.InsulationTypes`

#### Summary

Get all insulation types defined in this temperature rating type and its corresponding material type.

### `P:Autodesk.Revit.DB.Electrical.TemperatureRatingType.MaterialType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingType.MaterialType`

#### Summary

Get the material type information which this temperature rating type belongs to.

### `P:Autodesk.Revit.DB.Electrical.TemperatureRatingType.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingType.Name`

#### Summary

Get name of temperature rating type.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Set name can't be supported.

### `T:Autodesk.Revit.DB.Electrical.TemperatureRatingType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingType`

#### Summary

Represents temperature rating type definition information.

#### Remarks

Temperature rating type is defined based on corresponding wire material type.
It includes type information such as wire size, insulation type, correction factor, etc.
Only the temperature rating types which are retrieved from WireMaterialType can work well, so don't retrieve it from Revit document directly.

### `P:Autodesk.Revit.DB.Electrical.InsulationType.IsInUse`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.InsulationType.IsInUse`

#### Summary

Indicate whether the insulation type is in use.

### `P:Autodesk.Revit.DB.Electrical.InsulationType.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.InsulationType.Name`

#### Summary

Get name of Insulation type.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Set name can't be supported.

### `T:Autodesk.Revit.DB.Electrical.InsulationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.InsulationType`

#### Summary

Represents electrical insulation type definition information.

#### Remarks

Insulation type is defined based on corresponding wire material type and temperature rating type.

### `P:Autodesk.Revit.DB.Electrical.GroundConductorSize.ConductorSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSize.ConductorSize`

#### Summary

Get conductor size corresponding to specific ampacity.

### `P:Autodesk.Revit.DB.Electrical.GroundConductorSize.Ampacity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSize.Ampacity`

#### Summary

Get ampacity which is used for specifying size, the unit is ampere.

### `P:Autodesk.Revit.DB.Electrical.GroundConductorSize.MaterialBelongTo`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSize.MaterialBelongTo`

#### Summary

Get the material type which include this ground conductor size information.

### `T:Autodesk.Revit.DB.Electrical.GroundConductorSize`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSize`

#### Summary

Represents electrical ground conductor size definition information.

#### Remarks

Ground conductor size is defined based on corresponding wire material type.

### `P:Autodesk.Revit.DB.Electrical.CorrectionFactor.Factor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactor.Factor`

#### Summary

Get factor value of wire correction factor.

### `M:Autodesk.Revit.DB.Electrical.CorrectionFactor.GetTemperature`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactor.GetTemperature`

#### Summary

Get temperature which is used for specifying correction factor. The value returned is quantified in
the document's selected unit of electrical temperature.

### `T:Autodesk.Revit.DB.Electrical.CorrectionFactor`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactor`

#### Summary

Represents electrical correction factor information.

#### Remarks

Correction factor is defined based on corresponding wire material type and temperature rating type.

### `P:Autodesk.Revit.DB.Electrical.WireSize.InUse`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireSize.InUse`

#### Summary

Get or set whether the size can be used in sizing.

### `P:Autodesk.Revit.DB.Electrical.WireSize.Diameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireSize.Diameter`

#### Summary

Get diameter of wire.

### `P:Autodesk.Revit.DB.Electrical.WireSize.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireSize.Size`

#### Summary

Get size symbol of wire.

### `P:Autodesk.Revit.DB.Electrical.WireSize.Ampacity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireSize.Ampacity`

#### Summary

Get ampacity which be used for specifying size, the unit is ampere.

### `T:Autodesk.Revit.DB.Electrical.WireSize`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireSize`

#### Summary

Represents specific electrical wire size information.

#### Remarks

Wire size is defined based on corresponding wire material type and temperature rating type.

### `M:Autodesk.Revit.DB.Electrical.AreaBasedLoadType.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadType.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates an area based load type.

#### Parameter `document`

The document in which to create the area based load type.

#### Parameter `name`

The name of new area based load type. The actual name may be post-fixed if already exists.

#### Returns

The newly created area based load type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
name is an empty string or contains only whitespace.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".

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

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadType.LoadClassification`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadType.LoadClassification`

#### Summary

The load classification of area based load type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The id is not a load classification id .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadType.LoadDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadType.LoadDensity`

#### Summary

The load density of area based load type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for value is not a number
-or-
When setting this property: The given value for value is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for value must be non-negative.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadType.ApparentPowerDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadType.ApparentPowerDensity`

#### Summary

The apparent power density of area based load type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for value is not a number
-or-
When setting this property: The given value for value is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for value must be non-negative.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AreaBasedLoadType.PowerFactor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadType.PowerFactor`

#### Summary

The power factor of area based load type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for power factor must be between 0 and 1.

#### Since

2023

### `T:Autodesk.Revit.DB.Electrical.AreaBasedLoadType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.AreaBasedLoadType`

#### Summary

This class represents an area based load type in Autodesk Revit.

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new instance of load classification and adds it to the document.

#### Parameter `ADoc`

The document where the element will be created and added.

#### Parameter `strName`

The name of the electrical load classification to be created.

#### Returns

The newly created load classification element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.Spare`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.Spare`

#### Summary

Indicates if this load classification is to be used for spare.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.Other`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.Other`

#### Summary

Indicates if it is the default load classification, and its name is Other.

#### Since

2024

### `P:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.Motor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.Motor`

#### Summary

Indicates if this load classification is to be used for motors.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.Abbreviation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.Abbreviation`

#### Summary

The abbreviation of the load classification name

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: abbreviation is an empty string or contains only whitespace.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2021

### `P:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.ActualElectricalLoadLabel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.ActualElectricalLoadLabel`

#### Summary

The name template for the actual load parameter on the load classification.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: actualElectricalLoadLabel is not a valid globalization format string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.PanelEstimatedCurrentLabel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.PanelEstimatedCurrentLabel`

#### Summary

The name template for the estimated current parameter on the load classification.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: panelEstimatedCurrentLabel is not a valid globalization format string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.PanelConnectedCurrentLabel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.PanelConnectedCurrentLabel`

#### Summary

The name template for the connected current parameter on the load classification.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: panelConnectedCurrentLabel is not a valid globalization format string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.PanelEstimatedLabel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.PanelEstimatedLabel`

#### Summary

The name template for the estimated demand parameter on the load classification.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: panelEstimatedLabel is not a valid globalization format string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.PanelConnectedLabel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.PanelConnectedLabel`

#### Summary

The name template for the connected load parameter of the load classification.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: panelConnectedLabel is not a valid globalization format string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.LoadSummaryDemandFactorLabel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.LoadSummaryDemandFactorLabel`

#### Summary

The name template for the demand factor parameter of the load classification.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: loadSummaryDemandFactorLabel is not a valid globalization format string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.SpaceLoadClass`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.SpaceLoadClass`

#### Summary

The electrical load class associated with a space.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.DemandFactorId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification.DemandFactorId`

#### Summary

The demand factor definition this load classification element uses.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The element id elemId is not a valid ElectricalDemandFactorDefinition element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.Electrical.ElectricalLoadClassification`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassification`

#### Summary

The ElectricalLoadClassification class represents a serialized version of an instance of
load classification.

#### Since

2011

### `T:Autodesk.Revit.DB.Electrical.ElectricalLoadClassificationSpace`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassificationSpace`

#### Summary

This enum is used by the ElectricalLoadClassification to specify the load class for use with spaces.

#### Since

2011

### `T:Autodesk.Revit.DB.Electrical.ElectricalLoadClassificationData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadClassificationData`

#### Summary

This enum is used by the ElectricalLoadClassification class as additional data whenever
data members changed. It is used as the additional data when the atom corresponding to each
data member is touched.

#### Since

2011

### `M:AreaPlanTopologiesInterface.getDuplicateRoomIdToRepresentativeRoomIdByLevelId`

Member kind: method
Symbol: `AreaPlanTopologiesInterface.getDuplicateRoomIdToRepresentativeRoomIdByLevelId`

### `M:AreaPlanTopologiesInterface.updateRedundantRoomsAtLevel(ElementId,crs.Map<Topology.Space,crs_impl.Set<ElementId,std.less<ElementId>,tnallc<ElementId>>,std.less<Topology.Space>,tnallc<std.pair<Topology.Space!System.Runtime.CompilerServices.IsConst,crs_impl.Set<ElementId,std.less<ElementId>,tnallc<ElementId>>>>>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `AreaPlanTopologiesInterface.updateRedundantRoomsAtLevel(ElementId,crs.Map<Topology.Space,crs_impl.Set<ElementId,std.less<ElementId>,tnallc<ElementId>>,std.less<Topology.Space>,tnallc<std.pair<Topology.Space!System.Runtime.CompilerServices.IsConst,crs_impl.Set<ElementId,std.less<ElementId>,tnallc<ElementId>>>>>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:AreaPlanTopologiesInterface.hasRedundantRoomsAtLevel(ElementId)`

Member kind: method
Symbol: `AreaPlanTopologiesInterface.hasRedundantRoomsAtLevel(ElementId)`

### `M:AreaPlanTopologiesInterface.getDuplicateRoomIdToRepresentativeRoomIdAtLevel(ElementId)`

Member kind: method
Symbol: `AreaPlanTopologiesInterface.getDuplicateRoomIdToRepresentativeRoomIdAtLevel(ElementId)`

### `M:AreaPlanTopologiesInterface.roomAtLevelIsRepresentedBy(ElementId,ElementId)`

Member kind: method
Symbol: `AreaPlanTopologiesInterface.roomAtLevelIsRepresentedBy(ElementId,ElementId)`

### `M:AreaPlanTopologiesInterface.roomAtLevelIsRepresentative(ElementId,ElementId)`

Member kind: method
Symbol: `AreaPlanTopologiesInterface.roomAtLevelIsRepresentative(ElementId,ElementId)`

### `M:AreaPlanTopologiesInterface.roomAtLevelIsRedundant(ElementId,ElementId)`

Member kind: method
Symbol: `AreaPlanTopologiesInterface.roomAtLevelIsRedundant(ElementId,ElementId)`

### `M:Autodesk.Revit.DB.Electrical.ElectricalLoadAreaData.CreateElectricalLoadAreas(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadAreaData.CreateElectricalLoadAreas(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates electrical load areas on all the empty plan circuits of the given level.

#### Remarks

Use the `M:Autodesk.Revit.DB.Electrical.ElectricalLoadAreaData.HasCircuitsWithoutElectricalLoadAreas(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)` to check whether there are empty plan circuits in which there are no electrical load areas, if there are empty plan circuits, this API will create electrical load areas on each of them, otherwise, it will create nothing.
In most cases, the electrical load areas will be created, updated and deleted automatically, but in some cases, there are some empty plan circuits and need to create electrical load areas on each of them.

#### Parameter `doc`

The document where the created electrical load areas are.

#### Parameter `levelId`

The base level on which the created electrical load areas exist.

#### Parameter `phaseId`

The associated phase in which the created electrical load areas exist.

#### Returns

The created electrical load areas.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

doc is not a project document.
-or-
The ElementId levelId is not a Level.
-or-
The id does not represent a valid phase.

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

2023

### `M:Autodesk.Revit.DB.Electrical.ElectricalLoadAreaData.HasCircuitsWithoutElectricalLoadAreas(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadAreaData.HasCircuitsWithoutElectricalLoadAreas(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether there are any empty plan circuits in which there are no electrical load areas.

#### Parameter `doc`

The document to check.

#### Parameter `levelId`

The base level on which the empty plan circuits to check.

#### Parameter `phaseId`

The associated phase in which the empty plan circuits to check.

#### Returns

True if there are empty plan circuits in which there are no electrical load areas, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

doc is not a project document.
-or-
The ElementId levelId is not a Level.
-or-
The id does not represent a valid phase.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.ElectricalLoadAreaData.GetAreaBasedLoadIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadAreaData.GetAreaBasedLoadIds`

#### Summary

Gets the area based load ids of the electrical load area to be included.

#### Since

2023

### `T:Autodesk.Revit.DB.Electrical.ElectricalLoadAreaData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalLoadAreaData`

#### Summary

Represents the electrical load area data.

#### Since

2023

### `P:Autodesk.Revit.DB.SpatialElementDomainData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementDomainData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.SpatialElementDomainData`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpatialElementDomainData`

#### Summary

A base class for specific domain requirements for a spatial element.

#### Since

2023

### `M:Autodesk.Revit.DB.FamilyInstance.GetReferenceName(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.GetReferenceName(Autodesk.Revit.DB.Reference)`

#### Summary

Gets the name of the reference plane in the family corresponding to the given family instance reference.

#### Remarks

If the given family reference corresponds to a named reference plane in the instance's family, the name of that reference plane will be returned.
Otherwise, an empty string will be returned.

#### Parameter `reference`

The family instance reference.

#### Returns

Returns the name of the reference plane in the family corresponding to the given family instance reference.
If the reference doesn't correspond to a named reference plane, returns an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.FamilyInstance.GetReferenceByName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.GetReferenceByName(System.String)`

#### Summary

Gets the family instance reference corresponding to the named reference plane in the instance's family.

#### Remarks

If there is a reference plane in the instance's family that has the given name, and the plane's "Is Reference" property is not "Not a Reference",
there will be a corresponding reference in the family's instance. This function returns that reference.

#### Parameter `name`

The name of the reference plane in the family.

#### Returns

Returns the family instance reference corresponding to the named reference plane in the instance's family.
Returns null if there is no reference plane with this name in the family, or if the plane exists but its "Is Reference" property is "Not a Reference",
or if the input string is empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.FamilyInstance.GetReferenceType(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.GetReferenceType(Autodesk.Revit.DB.Reference)`

#### Summary

Gets the type of the reference plane or reference line in the instance's family corresponding to the given family instance reference.

#### Parameter `reference`

The family instance reference.

#### Returns

Returns the type of the reference plane or reference line in the instance's family corresponding to the given family instance reference.
Returns FamilyInstanceReferenceType.NotAReference if the instance reference doesn't correspond to a reference plane or line in the family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.FamilyInstance.GetReferences(Autodesk.Revit.DB.FamilyInstanceReferenceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.GetReferences(Autodesk.Revit.DB.FamilyInstanceReferenceType)`

#### Summary

Gets family instance references corresponding to the reference planes or reference lines of the given reference type in the instance's family.

#### Remarks

Reference planes from the instance's family that have their "Is Reference" property set to "Not a Reference" do not create references in the family instance.

#### Parameter `referenceType`

The family reference type.

#### Returns

Returns all the family instance references corresponding to reference planes and reference lines of the given reference type.
Returns null if there are no family instance references of the given reference type, or if the input reference type is FamilyInstanceReferenceType.NotAReference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2018

### `P:Autodesk.Revit.DB.FamilyInstance.UsesInstanceGeometry`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.UsesInstanceGeometry`

#### Summary

Identifies if this FamilyInstance has its own geometry.

#### Returns

True if this FamilyInstance has the own geometry, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.FamilyInstance.UseInstanceGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.UseInstanceGeometry`

#### Summary

Adds own geometry to a this FamilyInstance.

#### Remarks

Using instance geometry means that FamilyInstance has its own geometry that may be different from family. This takes more memory but can be used e.g. to assign instance specific materials to the instance faces.

#### Since

2018

### `M:Autodesk.Revit.DB.FamilyInstance.GetSweptProfile`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.GetSweptProfile`

#### Summary

Gets the object that describes the profile that is swept along the driving curve for this instance.

#### Returns

A swept profile.

#### Since

2016

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

Thrown if this instance does not have a swept profile.

### `M:Autodesk.Revit.DB.FamilyInstance.HasSweptProfile`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.HasSweptProfile`

#### Summary

Indicates if this instance can be represented as a swept profile.

#### Returns

True if the instance can be represented as a swept profile, false otherwise.

#### Since

2016

### `M:Autodesk.Revit.DB.FamilyInstance.HasModifiedGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.HasModifiedGeometry`

#### Summary

Identifies if the geometry of this FamilyInstance
has been modified from the automatically generated default.

#### Remarks

This method returns true if the geometry has been modified
from post-processing activity in Revit such as joining, cutting,
coping, extension, adaptive component modification, or other similar activity.

#### Since

2016

### `M:Autodesk.Revit.DB.FamilyInstance.GetSpatialElementFromToCalculationPoints`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.GetSpatialElementFromToCalculationPoints`

#### Summary

Gets the locations for the calculation points for this instance.

#### Returns

A list of 3d points.

#### Remarks

For a family instance which connects two rooms or spaces, such as a door or window, the points determine which room or space is considered the "from" and which is considered the "to".

#### Remarks

See `P:Autodesk.Revit.DB.FamilyInstance.HasSpatialElementFromToCalculationPoints` for reference.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if this instance does not have from/to calculation points..

#### Since

2016

### `M:Autodesk.Revit.DB.FamilyInstance.GetSpatialElementCalculationPoint`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.GetSpatialElementCalculationPoint`

#### Summary

Gets the location of the calculation point for this instance.

#### Returns

A 3d point.

#### Remarks

See `P:Autodesk.Revit.DB.FamilyInstance.HasSpatialElementCalculationPoint` for reference.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if this instance does not have a single calculation point.

#### Since

2016

### `P:Autodesk.Revit.DB.FamilyInstance.HasSpatialElementFromToCalculationPoints`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.HasSpatialElementFromToCalculationPoints`

#### Summary

Identifies if this instance has a pair of SpatialElementCalculationPoints used as the search points for Revit to identify if the instance lies between up to two rooms or spaces.

#### Returns

True if this instance has a pair of SpatialElementCalculationPoints used as the search points, false otherwise.

#### Remarks

The points determine which room or space is considered the "from" and which is considered the "to" for a family instance which connects two rooms or spaces, such as a door or window.

#### Since

2016

### `P:Autodesk.Revit.DB.FamilyInstance.HasSpatialElementCalculationPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.HasSpatialElementCalculationPoint`

#### Summary

Identifies if this instance has a single SpatialElementCalculationPoint used as the search point for Revit to identify if the instance is inside a room or space.

#### Returns

True if this instance has a single SpatialElementCalculationPoint used as the search point, false otherwise.

#### Since

2016

### `P:Autodesk.Revit.DB.FamilyInstance.IsWorkPlaneFlipped`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.IsWorkPlaneFlipped`

#### Summary

Identifies if the instance's work plane is flipped.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

Work plane cannot be flipped for this instance.

### `P:Autodesk.Revit.DB.FamilyInstance.CanFlipWorkPlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.CanFlipWorkPlane`

#### Summary

Identifies if the instance can flip its work plane.

### `M:Autodesk.Revit.DB.FamilyInstance.GetOriginalGeometry(Autodesk.Revit.DB.Options)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.GetOriginalGeometry(Autodesk.Revit.DB.Options)`

#### Summary

Returns the original geometry of the instance, before the instance is modified by
joins, cuts, coping, extensions, or other post-processing.

#### Remarks

This method returns the original geometry of the instance. The instance's geometry
will reflect the values of all instance level parameters (e.g. reference levels for columns) and
of the placement conditions (so a beam placed along a 20' long line will be 20' long). It excludes
all modifications made to the geometry due to operations like joining, cutting, openings, coping,
or extensions.

The geometry will not include the GeometryInstance typically returned when you access the geometry
of a FamilyInstance via Element.Geometry. But GeometryInstances may be encountered if there
are nested family instances within the family.

The geometry is returned in the coordinates of the FamilySymbol, not the coordinates of the
instance. If needed, you can transform the returned GeometryElement using the GetTransformed()
method, passing the results from GetTransform(), or some other user-defined transformation.

The geometry returned is from Revit's internal computations and does not represent actual
Revit geometry. Thus, you cannot use it as a reference for other geometry.

#### Parameter `options`

The options used to obtain the geometry. Note that ComputeReferences may not
be set to true.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the options are not
valid for this operation (ComputeReferences == true)

### `P:Autodesk.Revit.DB.FamilyInstance.IsSlantedColumn`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.IsSlantedColumn`

#### Summary

Indicates if the family instance is a slanted column.

#### Remarks

If the family instance is a slanted column, it returns true, otherwise returns false.

### `M:Autodesk.Revit.DB.FamilyInstance.GetFamilyPointPlacementReferences`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.GetFamilyPointPlacementReferences`

#### Summary

Returns the Point Placement References for the Family Instance.

#### Remarks

If a family instance has point placement references then they are returned by this method,
otherwise an empty collection is returned. Examples of FamilyInstance objects that contain placement
references are Panels and Flexible Components.

#### Since

2011

### `M:Autodesk.Revit.DB.FamilyInstance.RemoveCoping(Autodesk.Revit.DB.FamilyInstance)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.RemoveCoping(Autodesk.Revit.DB.FamilyInstance)`

#### Summary

Removes a coping (cut) from a steel beam.

#### Remarks

This function corresponds to Tools -> Remove coping in Revit Structure.

#### Parameter `cutter`

A steel beam or column for which this beam currently has a coping cut. May not be `null` or itself.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when 'cutter' is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when 'cutter' refers to this instance.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration fails.

### `M:Autodesk.Revit.DB.FamilyInstance.AddCoping(Autodesk.Revit.DB.FamilyInstance)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.AddCoping(Autodesk.Revit.DB.FamilyInstance)`

#### Summary

Adds a coping (cut) to a steel beam.

#### Remarks

This beam will be cut to fit another element, the cutter. The cut will include an offset
determined by the parameter STRUCTURAL_COPING_DISTANCE. The parameter affects all copings
on this element. This function corresponds to Tools -> Coping in Revit Structure.

#### Parameter `cutter`

A steel beam or column. May not be `null` or itself.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when 'cutter' is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when 'cutter' refers to this instance.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration fails.

### `M:Autodesk.Revit.DB.FamilyInstance.SetCopingIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.SetCopingIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Specifies the set of coping cutters on this element.

#### Parameter `cutters`

A set of coping cutters (steel beams and steel columns).

#### Remarks

The set may be `null` or empty, but may not contain the element being coped.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when 'cutters' contains this instance.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration fails or if a cutter element is not a FamilyInstance.

### `M:Autodesk.Revit.DB.FamilyInstance.GetCopingIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.GetCopingIds`

#### Summary

Lists the elements currently used as coping cutters for this element.

#### Returns

The coping ElementIds

#### Summary

Lists the elements currently used as coping cutters for this element.

### `P:Autodesk.Revit.DB.FamilyInstance.ExtensionUtility`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.ExtensionUtility`

#### Summary

Property to check whether the instance can be extended and return the interface for extension operation.

#### Remarks

If the family instance can not support extension operation, it returns `null`

### `P:Autodesk.Revit.DB.FamilyInstance.SuperComponent`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.SuperComponent`

#### Summary

Property to get the super component of current family instance.

#### Remarks

When the FamilyInstance has no super component, it returns `null`

### `M:Autodesk.Revit.DB.FamilyInstance.GetSubComponentIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.GetSubComponentIds`

#### Summary

Gets the sub component ElementIds of the current family instance.

#### Returns

The subcomponent ElementIDs

### `M:Autodesk.Revit.DB.FamilyInstance.FlipFromToRoom`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.FlipFromToRoom`

#### Summary

Flips the settings of "From Room" and "To Room" for the door or window instance.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the FamilyInstance is neither a door nor a window.

### `P:Autodesk.Revit.DB.FamilyInstance.ToRoom(Autodesk.Revit.DB.Phase!System.Runtime.CompilerServices.IsByValue)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.ToRoom(Autodesk.Revit.DB.Phase!System.Runtime.CompilerServices.IsByValue)`

#### Summary

The "To Room" set for the door or window in the given phase of the project.

#### Remarks

Revit automatically calculates the "To Room" for a given door or window. This is the default shown when creating a door or window
schedule and adding the "To Room" properties. The user can opt to swap the "From Room" and "To Room" values via the schedule if they choose.
The method `M:Autodesk.Revit.DB.FamilyInstance.FlipFromToRoom` also can be used to swap the values.

#### Value

The "To Room" set for the door or window in the given phase of the project.
`null` if the FamilyInstance is neither a door nor a window, or if the door or window leads to a space
where there is no room (an exterior space or interior space with no room defined). Also `null` if there is no
target room assigned to the given phase, or phase does not apply to this FamilyInstance.

#### Parameter `phase`

Phase of the project.

### `P:Autodesk.Revit.DB.FamilyInstance.ToRoom`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.ToRoom`

#### Overloads

The "To Room" set for the door or window.

#### Summary

The "To Room" set for the door or window in the last phase of the project.

#### Remarks

Revit automatically calculates the "To Room" for a given door or window. This is the default shown when creating a door or window
schedule and adding the "To Room" properties. The user can opt to swap the "From Room" and "To Room" values via the schedule if they choose.
The method `M:Autodesk.Revit.DB.FamilyInstance.FlipFromToRoom` also can be used to swap the values.

#### Value

The "To Room" set for the door or window in the last phase of the project.
`null` if the FamilyInstance is neither a door nor a window, or if the door or window leads to a space
where there is no room (an exterior space or interior space with no room defined). Also `null` if there is no
target room assigned to the last phase, or phase does not apply to this FamilyInstance.

### `P:Autodesk.Revit.DB.FamilyInstance.FromRoom(Autodesk.Revit.DB.Phase!System.Runtime.CompilerServices.IsByValue)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.FromRoom(Autodesk.Revit.DB.Phase!System.Runtime.CompilerServices.IsByValue)`

#### Summary

The "From Room" set for the door or window in the given phase of the project.

#### Remarks

Revit automatically calculates the "From Room" for a given door or window. This is the default shown when creating a door or window
schedule and adding the "From Room" properties. The user can opt to swap the "From Room" and "To Room" values via the schedule if they choose.
The method `M:Autodesk.Revit.DB.FamilyInstance.FlipFromToRoom` also can be used to swap the values.

#### Value

The "From Room" set for the door or window in the given phase of the project.
`null` if the FamilyInstance is neither a door nor a window, or if the door or window leads to a space
where there is no room (an exterior space or interior space with no room defined). Also `null` if there is no
target room assigned to the given phase, or phase does not apply to this FamilyInstance.

#### Parameter `phase`

Phase of the project.

### `P:Autodesk.Revit.DB.FamilyInstance.FromRoom`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.FromRoom`

#### Overloads

The "From Room" set for the door or window.

#### Summary

The "From Room" set for the door or window in the last phase of the project.

#### Remarks

Revit automatically calculates the "From Room" for a given door or window. This is the default shown when creating a door or window
schedule and adding the "From Room" properties. The user can opt to swap the "From Room" and "To Room" values via the schedule if they choose.
The method `M:Autodesk.Revit.DB.FamilyInstance.FlipFromToRoom` also can be used to swap the values.

#### Value

The "From Room" set for the door or window in the last phase of the project.
`null` if the FamilyInstance is neither a door nor a window, or if the door or window leads to a space
where there is no room (an exterior space or interior space with no room defined). Also `null` if there is no
target room assigned to the last phase, or phase does not apply to this FamilyInstance.

### `M:Autodesk.Revit.DB.FamilyInstance.Split(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.Split(System.Double)`

#### Summary

Splits the family instance element at a point on its defining curve.

#### Remarks

Splitting is permitted for architectural and structural columns, beams and braces. Beams and braces that are not a line or an arc is not permitted. See `P:Autodesk.Revit.DB.FamilyInstance.CanSplit` to determine if the family instance is allowed to be split by this method.

Splitting modifies this family instance and adds a second family instance to the model.

#### Parameter `param`

The normalized parameter value along the element (should be greater than 0 and less than 1).

#### Returns

The newly created family instance id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when parameter is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family instance element cannot be split.

### `P:Autodesk.Revit.DB.FamilyInstance.CanSplit`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.CanSplit`

#### Summary

Identifies whether a particular family instance can be split at a point on it's defining curve (by `M:Autodesk.Revit.DB.FamilyInstance.Split(System.Double)` ).

#### Value

True if the family instance can be split, otherwise false.

### `M:Autodesk.Revit.DB.FamilyInstance.rotate`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.rotate`

#### Summary

The family instance will be flipped by 180 degrees. If it can not be rotated, return false, otherwise return true.

### `M:Autodesk.Revit.DB.FamilyInstance.flipFacing`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.flipFacing`

#### Summary

The orientation of family instance facing will be flipped. If it can not be flipped, return false, otherwise return true.

### `M:Autodesk.Revit.DB.FamilyInstance.flipHand`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstance.flipHand`

#### Summary

The orientation of family instance hand will be flipped. If it can not be flipped, return false, otherwise return true.

### `P:Autodesk.Revit.DB.FamilyInstance.CanRotate`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.CanRotate`

#### Summary

Property to test whether the family instance can be rotated by 180 degrees.

### `P:Autodesk.Revit.DB.FamilyInstance.CanFlipFacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.CanFlipFacing`

#### Summary

Property to test whether the orientation of family instance facing can be flipped.

### `P:Autodesk.Revit.DB.FamilyInstance.CanFlipHand`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.CanFlipHand`

#### Summary

Property to test whether the orientation of family instance hand can be flipped.

### `P:Autodesk.Revit.DB.FamilyInstance.Mirrored`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.Mirrored`

#### Summary

Property to test whether the family instance is mirrored. (only one axis is flipped)

### `P:Autodesk.Revit.DB.FamilyInstance.Invisible`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.Invisible`

#### Summary

Property to test whether the family instance is invisible.

### `P:Autodesk.Revit.DB.FamilyInstance.FacingFlipped`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.FacingFlipped`

#### Summary

Property to test whether the orientation of family instance facing is flipped.

### `P:Autodesk.Revit.DB.FamilyInstance.HandFlipped`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.HandFlipped`

#### Summary

Property to test whether the orientation of family instance hand is flipped.

### `P:Autodesk.Revit.DB.FamilyInstance.FacingOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.FacingOrientation`

#### Summary

Property to get the orientation of family instance facing.

### `P:Autodesk.Revit.DB.FamilyInstance.HandOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.HandOrientation`

#### Summary

Property to get the orientation of family instance hand.

### `P:Autodesk.Revit.DB.FamilyInstance.HostFace`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.HostFace`

#### Summary

Property to get the reference to the host face of family instance.

#### Value

If the instance is placed on a work plane, this property will return the reference to the geometry face underlying the work plane.
If the work plane is not referencing other geometry, this property will return `null` .
If the instance is not hosted on a face or work plane, this property will return `null` .

### `P:Autodesk.Revit.DB.FamilyInstance.HostParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.HostParameter`

#### Summary

If the instance is hosted by a wall, this property returns the parameter value of the insertion
point of the instance along the wall's location curve, as long as the family of the instance isn't work plane based.

#### Remarks

This works for instances with a host element that is of type Wall or is in the OST_Walls category only,
including in-place ones.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Only hosted instances whose family is not work plane based can support this functionality.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Only hosted instances of type Wall or in-place elements of category OST_Walls can support this functionality.

### `P:Autodesk.Revit.DB.FamilyInstance.Host`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.Host`

#### Summary

If the instance is contained within another element, this property returns the containing
element. An instance that is face hosted will return the element containing the face.

#### Remarks

An example of an instance that is contained is a window. In this case the host property
would return the wall in which the window is contained. Another example is an instance that is hosted
to a planar or curved face in a Mass element will return the Mass element.

### `P:Autodesk.Revit.DB.FamilyInstance.Location`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.Location`

#### Summary

This property is used to find the physical location of an instance within project.

#### Remarks

The Location property returns an object that can be used to find the location of an instance
within the project. An instance may have a point location, such as a footing or may have a line location.
A beam is an example of an instance that has a line location.

### `P:Autodesk.Revit.DB.FamilyInstance.Space(Autodesk.Revit.DB.Phase!System.Runtime.CompilerServices.IsByValue)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.Space(Autodesk.Revit.DB.Phase!System.Runtime.CompilerServices.IsByValue)`

#### Summary

The space in which the instance is located in the given phase of the project.

#### Parameter `phase`

The phase in which to look for a space that contains the instance.

#### Remarks

This property will be the first space encountered that contains the instance. If more than
one space includes this point in its volume only the first one is returned.
If no space is found that contains the instance, or if phase does not apply to this FaimlyInstance,
this property is `null` .

### `P:Autodesk.Revit.DB.FamilyInstance.Space`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.Space`

#### Overloads

The space in which the instance is located.

#### Summary

The space in which the instance is located (during the last phase of the project).

#### Remarks

This property will be the first space encountered that contains the instance. If more than
one space includes this point in its volume only the first one is returned.
If no space is found that contains the instance, or if phase does not apply to this FaimlyInstance,
this property is `null` .

### `P:Autodesk.Revit.DB.FamilyInstance.Room(Autodesk.Revit.DB.Phase!System.Runtime.CompilerServices.IsByValue)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.Room(Autodesk.Revit.DB.Phase!System.Runtime.CompilerServices.IsByValue)`

#### Summary

The room in which the instance is located in the given phase of the project.

#### Parameter `phase`

The phase in which to look for a room that contains the instance.

#### Remarks

This property will be the first room encountered that contains the instance. If more than
one room includes this point in its volume only the first one is returned.
If no room is found that contains the instance, or if phase does not apply to this FaimlyInstance,
this property is `null` .
This property should not be used for door or window instances, which are placed on the boundary or
between rooms. Use the `P:Autodesk.Revit.DB.FamilyInstance.FromRoom` and `P:Autodesk.Revit.DB.FamilyInstance.ToRoom` properties instead.

### `P:Autodesk.Revit.DB.FamilyInstance.Room`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.Room`

#### Overloads

The room in which the instance is located.

#### Summary

The room in which the instance is located (during the last phase of the project).

#### Remarks

This property will be the first room encountered that contains the instance. If more than
one room includes this point in its volume only the first one is returned.
If no room is found that contains the instance, or if phase does not apply to this FaimlyInstance,
this property is `null` .
This property should not be used for door or window instances, which are placed on the boundary or
between rooms. Use the `P:Autodesk.Revit.DB.FamilyInstance.FromRoom` and `P:Autodesk.Revit.DB.FamilyInstance.ToRoom` properties instead.

### `P:Autodesk.Revit.DB.FamilyInstance.StructuralType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.StructuralType`

#### Summary

Provides the primary structural type of the instance, such as beam or column etc.

### `P:Autodesk.Revit.DB.FamilyInstance.StructuralUsage`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.StructuralUsage`

#### Summary

Provides the primary structural usage of the instance, such as brace, girder etc.

### `P:Autodesk.Revit.DB.FamilyInstance.StructuralMaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.StructuralMaterialId`

#### Summary

Identifies the material that defines the instance's structural analysis properties.

### `P:Autodesk.Revit.DB.FamilyInstance.StructuralMaterialType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.StructuralMaterialType`

#### Summary

This property returns the physical material from which the instance is made.

#### Remarks

Values of this property can be Steel, Concrete, Wood or some other material.
Different from Revit materials that geometry really consists of, this property is a family parameter
defining family behavior and can not be set per instance. Its value is the same with the type of the
instance's family. For example, the instances of different kind of column families(Steel, Concrete or
Wood) have different material values and can't be changed int the UI or RevitAPI.

### `P:Autodesk.Revit.DB.FamilyInstance.MEPModel`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.MEPModel`

#### Summary

Retrieves the MEP model for the family instance.

#### Remarks

If the family instance has a MEP model it is returned by this method, otherwise `null` is
returned. Different types of MEP model will be returned based on the type of the instance, for
example - if the instance is a lighting device then a lighting device model will be returned.
This property will only function with the Autodesk Revit MEP product.

### `P:Autodesk.Revit.DB.FamilyInstance.Symbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstance.Symbol`

#### Summary

Returns or changes the FamilySymbol object that represents the type of the instance.

#### Remarks

Setting this property will result in the type of the instance being changed. Related types
can be found by examining the Family to which the symbol belongs.

### `T:Autodesk.Revit.DB.FamilyInstance`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyInstance`

#### Summary

This object represents a single instance of a family type, such as a single I beam.

#### Remarks

Examples of FamilyInstance objects within Autodesk Revit are Beams, Columns,
Braces and Desks. The FamilyInstance object provides more detailed properties that
enable the type of the family instance to be changed, thus changing their appearance
within the project.

### `M:Autodesk.Revit.DB.SweptProfile.GetSweptProfile`

Member kind: method
Symbol: `Autodesk.Revit.DB.SweptProfile.GetSweptProfile`

#### Summary

Returns an object that describes the profile that is swept along the driving curve.

#### Remarks

The profile is swept perpendicular to the driving curve.

#### Returns

A geometric profile object.

#### Since

2016

### `M:Autodesk.Revit.DB.SweptProfile.GetDrivingCurve`

Member kind: method
Symbol: `Autodesk.Revit.DB.SweptProfile.GetDrivingCurve`

#### Summary

Provides access to the curve that dictates the path of the swept profile.

#### Remarks

The profile may not be swept the entire length of this curve. One should check the
set back properties on this object to locate how far the actual sweep is from the ends of the curve.

#### Returns

A curve that defines the path of the swept profile.

#### Since

2016

### `P:Autodesk.Revit.DB.SweptProfile.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SweptProfile.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.SweptProfile.EndSetBack`

Member kind: property
Symbol: `Autodesk.Revit.DB.SweptProfile.EndSetBack`

#### Summary

The distance from the end of the driving curve to the point where the sweep actually ends.

#### Since

2016

### `P:Autodesk.Revit.DB.SweptProfile.StartSetBack`

Member kind: property
Symbol: `Autodesk.Revit.DB.SweptProfile.StartSetBack`

#### Summary

The distance from the start of the driving curve to the point where the sweep actually begins.

#### Since

2016

### `T:Autodesk.Revit.DB.SweptProfile`

Member kind: type
Symbol: `Autodesk.Revit.DB.SweptProfile`

#### Summary

Represents an extruded profile swept along a driving curve.

#### Remarks

Elements such as beams may be formed from a profile that has been swept
along a curve. This class represents such a form and is used to access the
cross section and the underlying curve that make up the Element.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralInstanceUsage`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage`

#### Since

2011

#### Summary

Represents the structural usage of a family instance.

#### Since

2011

### `F:Autodesk.Revit.DB.Structure.StructuralInstanceUsage.TrussWeb`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage.TrussWeb`

#### Summary

Structural usage is as truss web.

### `F:Autodesk.Revit.DB.Structure.StructuralInstanceUsage.TrussChord`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage.TrussChord`

#### Summary

Structural usage is as truss chord.

### `F:Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Automatic`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Automatic`

#### Summary

Structural usage is automatic.

### `F:Autodesk.Revit.DB.Structure.StructuralInstanceUsage.KickerBracing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage.KickerBracing`

#### Summary

Structural usage is as kicker bracing.

### `F:Autodesk.Revit.DB.Structure.StructuralInstanceUsage.HorizontalBracing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage.HorizontalBracing`

#### Summary

Structural usage is as horizontal bracing.

### `F:Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Brace`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Brace`

#### Summary

Structural usage is as brace.

### `F:Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Other`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Other`

#### Summary

Structural usage is as "other".

### `F:Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Purlin`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Purlin`

#### Summary

Structural usage is as purlin.

### `F:Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Joist`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Joist`

#### Summary

Structural usage is as joist.

### `F:Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Girder`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Girder`

#### Summary

Structural usage is as girder.

### `F:Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Column`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Column`

#### Summary

Structural usage is as column.

### `F:Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Wall`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Wall`

#### Summary

Structural usage is as wall.

### `F:Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsage.Undefined`

#### Summary

indicates automatic

### `M:Autodesk.Revit.DB.FamilySymbol.CanHaveStructuralSection`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySymbol.CanHaveStructuralSection`

#### Summary

Identifies if this FamilySymbol can have a structural section.

#### Returns

True if the FamilySymbol can have structural section, false otherwise.

#### Since

2016

### `M:Autodesk.Revit.DB.FamilySymbol.SetStructuralSection(Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySymbol.SetStructuralSection(Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection)`

#### Summary

Sets the structural section in element.

#### Remarks

Only beams, braces and structural columns can have a structural section.
To check if the element can have structural section use the `!:Family.HasStructuralSection()` method.

#### Parameter `structuralSection`

Structural section with values that will be set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FamilySymbol cannot have a structural section.

#### Since

2015

### `M:Autodesk.Revit.DB.FamilySymbol.GetStructuralSection`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySymbol.GetStructuralSection`

#### Summary

Gets the structural section from element.

#### Remarks

Only beams, braces and structural columns can have a structural section.
To check if the element can have structural section use the `!:Family.HasStructuralSection()` method.

#### Returns

The structural section. `null` if the family symbol does not contain a structural section.

#### Since

2015

### `M:Autodesk.Revit.DB.FamilySymbol.HasThermalProperties`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySymbol.HasThermalProperties`

#### Summary

Identifies if this FamilySymbol can include thermal properties.

#### Returns

True if the FamilySymbol can include thermal properties, false otherwise.

#### Since

2015

### `M:Autodesk.Revit.DB.FamilySymbol.SetThermalProperties(Autodesk.Revit.DB.FamilyThermalProperties)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySymbol.SetThermalProperties(Autodesk.Revit.DB.FamilyThermalProperties)`

#### Summary

Sets the thermal properties for the given FamilySymbol.

#### Parameter `thermalProperties`

The new thermal properties. If `null` , this unsets custom thermal properties for this FamilySymbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The thermal properties are not valid for assignment.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This FamilySymbol does not contain thermal properties.

#### Since

2013

### `M:Autodesk.Revit.DB.FamilySymbol.GetThermalProperties`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySymbol.GetThermalProperties`

#### Summary

Gets the thermal properties for the given FamilySymbol.

#### Remarks

Doors, windows, and curtain wall panels will have thermal properties.

#### Returns

The thermal properties. `null` if the family symbol does not contain thermal properties.

#### Since

2013

### `M:Autodesk.Revit.DB.FamilySymbol.Activate`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySymbol.Activate`

#### Summary

Activates the symbol to ensure that its geometry is accessible.

#### Remarks

Symbols that are not used in the document may be deactivated to conserve memory and regeneration time.
When the symbol is inactive, its geometry is empty and should not be accessed.
In order to access geometry of a symbol that is not active in the document, first check its `P:Autodesk.Revit.DB.FamilySymbol.IsActive`
property. Note that until the document is regenerated, the newly activated symbol's geometry
will still be empty.

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySymbol.IsActive`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySymbol.IsActive`

#### Summary

Identifies whether the symbol is active.

#### Remarks

Symbols that are not used in the document may be deactivated to conserve memory and regeneration time.
When the symbol is inactive, its geometry is empty and cannot be accessed.
In order to access the geometry of a symbol that is not active in the document,
the symbol should first be activated by calling `M:Autodesk.Revit.DB.FamilySymbol.Activate` .

#### Since

2014

### `P:Autodesk.Revit.DB.FamilySymbol.Family`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySymbol.Family`

#### Summary

The Family object to which the symbol belongs.

### `M:Autodesk.Revit.DB.FamilySymbol.GetFamilyPointLocations`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySymbol.GetFamilyPointLocations`

#### Summary

Returns the Point Locations for the Family Symbol.

#### Remarks

If a family symbol has point references then their locations are returned by this method,
otherwise an empty collection is returned. Examples of FamilySymbol objects that contain point
location are Panels and Flexible Components.

#### Since

2011

### `P:Autodesk.Revit.DB.FamilySymbol.StructuralMaterialType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySymbol.StructuralMaterialType`

#### Summary

This property returns the physical material from which the type is made.

#### Remarks

Values of this property can be Steel, Concrete, Wood or some other material.

### `T:Autodesk.Revit.DB.FamilySymbol`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilySymbol`

#### Summary

An element that represents a single type with a Family.

#### Remarks

Custom families within the Revit API represented by three objects - Family, `T:Autodesk.Revit.DB.FamilySymbol`
and `T:Autodesk.Revit.DB.FamilyInstance` .
Each object plays a significant part in the structure of families. The Family element represents the entire family
that consists of a collection of types, such as an 'I Beam'. You can think of that object as representing the entire
family file. The Family object contains a number of `T:Autodesk.Revit.DB.FamilySymbol` elements. The
`T:Autodesk.Revit.DB.FamilySymbol` object represents a specific set
of family settings within that Family and represents what is known in the Revit user interface as a
Type, such as 'W14x32'. The `T:Autodesk.Revit.DB.FamilyInstance` object represents an actual instance of that
type placed the Autodesk Revit project. For example the `T:Autodesk.Revit.DB.FamilyInstance` would
be a single instance of a W14x32 column within the project.

### `T:Autodesk.Revit.DB.InsertableObject`

Member kind: type
Symbol: `Autodesk.Revit.DB.InsertableObject`

#### Summary

A base class you all types that are insertable.

### `M:Autodesk.Revit.DB.Instance.GetTotalTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.Instance.GetTotalTransform`

#### Summary

Gets the total transform, which includes the true north transform for instances like import instances.

#### Remarks

For most of other instances, it simply returns the inherent transform.

#### Returns

The calculated total transform.

#### Since

2012

### `M:Autodesk.Revit.DB.Instance.GetTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.Instance.GetTransform`

#### Summary

Gets the transform of the instance.

#### Returns

The inherent transform.

#### Since

2012

### `T:Autodesk.Revit.DB.Instance`

Member kind: type
Symbol: `Autodesk.Revit.DB.Instance`

#### Summary

The base class for all instance objects.

### `T:Autodesk.Revit.DB.FamilyInstanceReferenceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyInstanceReferenceType`

#### Since

2018

#### Summary

Corresponds to the possible values of parameter "Is Reference" of reference planes and parameter "Reference" of reference lines in families.
This enum is used to identify references of family instances corresponding to reference planes and reference lines in the family.

#### Since

2018

### `F:Autodesk.Revit.DB.FamilyInstanceReferenceType.NotAReference`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyInstanceReferenceType.NotAReference`

#### Summary

This value is returned from FamilyInstance::getReferenceType if the reference does not correspond to any reference plane
or reference line in the family.

### `F:Autodesk.Revit.DB.FamilyInstanceReferenceType.WeakReference`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyInstanceReferenceType.WeakReference`

#### Summary

Reference plane whose "Is Reference" parameter is set to "Weak Reference", or reference line whose "Reference" parameter is set to "Weak Reference".
There may be multiple such reference planes and lines in the family.
These references are not stable: if there is a dimension to such reference, and the instance's family is replaced,
the dimension is not guaranteed to survive.

### `F:Autodesk.Revit.DB.FamilyInstanceReferenceType.StrongReference`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyInstanceReferenceType.StrongReference`

#### Summary

Reference plane whose "Is Reference" parameter is set to "Strong Reference", or reference line whose "Reference" parameter is set to "Strong Reference".
There may be multiple such reference planes and lines in the family.
These references are not stable: if there is a dimension to such reference, and the instance's family is replaced,
the dimension is not guaranteed to survive.

### `F:Autodesk.Revit.DB.FamilyInstanceReferenceType.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyInstanceReferenceType.Top`

#### Summary

Reference plane whose "Is Reference" parameter is set to "Top". There may be no more than one such reference plane in the family.
This reference is stable: if there is a dimension to this reference of an instance, and the instance's type or family is replaced,
the dimension will survive.

### `F:Autodesk.Revit.DB.FamilyInstanceReferenceType.CenterElevation`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyInstanceReferenceType.CenterElevation`

#### Summary

Reference plane whose "Is Reference" parameter is set to "Center (Elevation)". There may be no more than one such reference plane in the family.
This reference is stable: if there is a dimension to this reference of an instance, and the instance's type or family is replaced,
the dimension will survive.

### `F:Autodesk.Revit.DB.FamilyInstanceReferenceType.Bottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyInstanceReferenceType.Bottom`

#### Summary

Reference plane whose "Is Reference" parameter is set to "Bottom". There may be no more than one such reference plane in the family.
This reference is stable: if there is a dimension to this reference of an instance, and the instance's type or family is replaced,
the dimension will survive.

### `F:Autodesk.Revit.DB.FamilyInstanceReferenceType.Back`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyInstanceReferenceType.Back`

#### Summary

Reference plane whose "Is Reference" parameter is set to "Back". There may be no more than one such reference plane in the family.
This reference is stable: if there is a dimension to this reference of an instance, and the instance's type or family is replaced,
the dimension will survive.

### `F:Autodesk.Revit.DB.FamilyInstanceReferenceType.CenterFrontBack`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyInstanceReferenceType.CenterFrontBack`

#### Summary

Reference plane whose "Is Reference" parameter is set to "Center (Front/Back)". There may be no more than one such reference plane in the family.
This reference is stable: if there is a dimension to this reference of an instance, and the instance's type or family is replaced,
the dimension will survive.

### `F:Autodesk.Revit.DB.FamilyInstanceReferenceType.Front`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyInstanceReferenceType.Front`

#### Summary

Reference plane whose "Is Reference" parameter is set to "Front". There may be no more than one such reference plane in the family.
This reference is stable: if there is a dimension to this reference of an instance, and the instance's type or family is replaced,
the dimension will survive.

### `F:Autodesk.Revit.DB.FamilyInstanceReferenceType.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyInstanceReferenceType.Right`

#### Summary

Reference plane whose "Is Reference" parameter is set to "Right". There may be no more than one such reference plane in the family.
This reference is stable: if there is a dimension to this reference of an instance, and the instance's type or family is replaced,
the dimension will survive.

### `F:Autodesk.Revit.DB.FamilyInstanceReferenceType.CenterLeftRight`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyInstanceReferenceType.CenterLeftRight`

#### Summary

Reference plane whose "Is Reference" parameter is set to "Center (Left/Right)". There may be no more than one such reference plane in the family.
This reference is stable: if there is a dimension to this reference of an instance, and the instance's type or family is replaced,
the dimension will survive.

### `F:Autodesk.Revit.DB.FamilyInstanceReferenceType.Left`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyInstanceReferenceType.Left`

#### Summary

Reference plane whose "Is Reference" parameter is set to "Left". There may be no more than one such reference plane in the family.
This reference is stable: if there is a dimension to this reference of an instance, and the instance's type or family is replaced,
the dimension will survive.

### `P:Autodesk.Revit.DB.Electrical.DistributionSysType.IsInUse`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysType.IsInUse`

#### Summary

Get the value which indicates whether this distribution system is in service now.

### `P:Autodesk.Revit.DB.Electrical.DistributionSysType.VoltageLineToGround`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysType.VoltageLineToGround`

#### Summary

Get or set line to ground voltage of distribution system type.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The voltage retrieved here is read only and actions to modify its properties it will throw an System.InvalidOperationException.

### `P:Autodesk.Revit.DB.Electrical.DistributionSysType.VoltageLineToLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysType.VoltageLineToLine`

#### Summary

Get or set line to line voltage type of distribution system type.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The voltage retrieved here is read only and actions to modify its properties it will throw an System.InvalidOperationException.

### `P:Autodesk.Revit.DB.Electrical.DistributionSysType.NumWires`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysType.NumWires`

#### Summary

Get or set number of wires of distribution system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

While assign a negative value to NumWires.

### `P:Autodesk.Revit.DB.Electrical.DistributionSysType.ElectricalPhase`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysType.ElectricalPhase`

#### Summary

Get or set electrical phase (single, triple or undefined) of distribution system.

### `P:Autodesk.Revit.DB.Electrical.DistributionSysType.ElectricalPhaseConfiguration`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysType.ElectricalPhaseConfiguration`

#### Summary

Get or set electrical phase configuration (Y, delta or undefined) of distribution system.

### `T:Autodesk.Revit.DB.Electrical.DistributionSysType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysType`

#### Summary

Represents a specific type of distribution system.

### `M:Autodesk.Revit.DB.Electrical.VoltageType.SetVoltageValue(System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.VoltageType.SetVoltageValue(System.Double,System.Double,System.Double)`

#### Summary

Assign new values to modify voltage type, all of the unit are volt.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Actual value can't be more than minValue or less than maxValue, and all of them can't be negative,
otherwise the exception will be thrown.

### `P:Autodesk.Revit.DB.Electrical.VoltageType.IsInUse`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.VoltageType.IsInUse`

#### Summary

Indicates whether this voltage type is in service now, such as by other distribution system.

### `P:Autodesk.Revit.DB.Electrical.VoltageType.MinValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.VoltageType.MinValue`

#### Summary

Get lower boundary of voltage value of this voltage definition, the unit is volt.

### `P:Autodesk.Revit.DB.Electrical.VoltageType.MaxValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.VoltageType.MaxValue`

#### Summary

Get upper boundary of voltage value of this voltage definition, the unit is volt.

### `P:Autodesk.Revit.DB.Electrical.VoltageType.ActualValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.VoltageType.ActualValue`

#### Summary

Get actual voltage value of this voltage definition, the unit is volt.

### `T:Autodesk.Revit.DB.Electrical.VoltageType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.VoltageType`

#### Summary

Represents electrical voltage type. An electrical voltage type define a range of voltages,
and circuits can be created between components with rated voltages that do not precisely match the voltage definition value.

#### Remarks

Actual, minimum and maximum value of voltage type can retrieved through properties, but only can
be modified through SetVoltageValue method. All the unit of voltage properties in this class is volt.

### `M:Autodesk.Revit.DB.Electrical.ElectricalEquipment.SetCircuitNamingSchemeType(Autodesk.Revit.DB.Electrical.CircuitNaming)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalEquipment.SetCircuitNamingSchemeType(Autodesk.Revit.DB.Electrical.CircuitNaming)`

#### Summary

Sets the circuit naming scheme for Electrical Equipment.

#### Remarks

The following circuit naming scheme type can be set:

CircuitNaming::Prefixed

CircuitNaming::Standard

CircuitNaming::PanelName

CircuitNaming::Phase

CircuitNaming::ProjectSetting

For a customized circuit naming scheme, set its id directly with SetCircuitNamingSchemeId method.

#### Parameter `circuitNamingType`

The enumerated type of circuit naming scheme to be set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The circuit naming scheme enumerated type is invalid for the Electrical Equipment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2021

### `M:Autodesk.Revit.DB.Electrical.ElectricalEquipment.GetCircuitNamingSchemeType`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalEquipment.GetCircuitNamingSchemeType`

#### Summary

Gets enumerated type of the circuit naming scheme used with Electrical Equipment.

#### Returns

The enumerated type of circuit naming scheme.

#### Since

2021

### `M:Autodesk.Revit.DB.Electrical.ElectricalEquipment.IsValidCircuitNamingSchemeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalEquipment.IsValidCircuitNamingSchemeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Verifies that the circuit naming scheme id can be used with Electrical Equipment.

#### Parameter `aDocument`

The document.

#### Parameter `circuitNamingSchemeId`

The circuit naming scheme id to be checked.

#### Returns

True if the circuit naming scheme id is valid for Electrical Equipment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Electrical.ElectricalEquipment.IsValidDistributionSystem(Autodesk.Revit.DB.Electrical.DistributionSysType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalEquipment.IsValidDistributionSystem(Autodesk.Revit.DB.Electrical.DistributionSysType)`

#### Summary

Verifies that the Distribution System can be assigned to the Electrical Equipment.

#### Parameter `distributionSystem`

The Distribution System to be checked.

#### Returns

True if the Distribution System can be assigned to the Electrical Equipment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `P:Autodesk.Revit.DB.Electrical.ElectricalEquipment.IsSwitchboard`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalEquipment.IsSwitchboard`

#### Summary

The electrical equipment is a switchboard or not.
This property returns true if the electrical equipment is a switchboard.

#### Since

2021

### `P:Autodesk.Revit.DB.Electrical.ElectricalEquipment.MaxNumberOfCircuits`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalEquipment.MaxNumberOfCircuits`

#### Summary

The maximum number of circuits for switchboard.
The quantity of circuits can be assigned to switchboard through breaker.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input max number of circuits value is invalid for switchboard.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The electrical equipment is not a switchboard equipment.

#### Since

2021

### `P:Autodesk.Revit.DB.Electrical.ElectricalEquipment.CircuitNamingSchemeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalEquipment.CircuitNamingSchemeId`

#### Summary

The CircuitNamingSchemeId used in the Electrical Equipment.
The CircuitNamingSchemeId is used to retrieve the circuit naming scheme id of the Electrical Equipment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The circuit naming scheme id is invalid for the Electrical Equipment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2021

### `P:Autodesk.Revit.DB.Electrical.ElectricalEquipment.DistributionSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalEquipment.DistributionSystem`

#### Summary

get or set the Distribution System for the Electrical Equipment.

#### Remarks

This property returns a Distribution System which is assigned to the Electrical Equipment.
If there are no Distribution System assigned to this Electrical Equipment,
this property will be `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The Distribution System can not be assigned to the Electrical Equipment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `M:Autodesk.Revit.DB.Electrical.ElectricalEquipment.#ctor(Autodesk.Revit.DB.FamilyInstance)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalEquipment.#ctor(Autodesk.Revit.DB.FamilyInstance)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.Electrical.ElectricalEquipment`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalEquipment`

#### Summary

Provides access to the Electrical Equipment in Autodesk Revit.

### `M:Autodesk.Revit.DB.MEPModel.GetAssignedElectricalSystems`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPModel.GetAssignedElectricalSystems`

#### Summary

Retrieves the electrical systems this electrical panel currently is assigned to.

#### Remarks

This property returns a set of Electrical Systems. If there are no electrical systems created
for this model, this property will be an empty set.
This method supersedes an older AssignedElectricalSystems property which has been deprecated.

#### Since

2021

### `M:Autodesk.Revit.DB.MEPModel.GetElectricalSystems`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPModel.GetElectricalSystems`

#### Summary

Retrieves the electrical systems that are currently created using this MEPModel.

#### Remarks

This property returns a set of Electrical Systems. If there are no electrical systems created
for this model, this property will be an empty set.
This method supersedes an older ElectricalSystems property which has been deprecated.

#### Since

2021

### `P:Autodesk.Revit.DB.MEPModel.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPModel.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.MEPModel.ConnectorManager`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPModel.ConnectorManager`

#### Summary

Retrieves the Connector Manager from this MEPModel.

### `M:Autodesk.Revit.DB.MEPModel.#ctor(Autodesk.Revit.DB.FamilyInstance)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPModel.#ctor(Autodesk.Revit.DB.FamilyInstance)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.MEPModel`

Member kind: type
Symbol: `Autodesk.Revit.DB.MEPModel`

#### Summary

Supports all MEP models that are persistent within the Autodesk Revit project.

### `M:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.SetMaxRangeToUnlimited`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.SetMaxRangeToUnlimited`

#### Summary

Sets the max range on the value to unlimited

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.MaxRange`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.MaxRange`

#### Summary

The maximum range for this demand factor value. For example, objects 1 to 3 can have 100% demand factor.
In the example above, the maximum range will be 3.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.MinRange`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.MinRange`

#### Summary

The minimum range for this demand factor value. For example, objects 1 to 3 can have 100% demand factor.
In the example above, the minimum range will be 1.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.Factor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.Factor`

#### Summary

The demand factor for this demand factor value. For example, objects 1 to 3 can have 100% demand factor.
In the example above, the demand factor will be 1.0.

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.#ctor(System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.#ctor(System.Double,System.Double,System.Double)`

#### Summary

Constructor. Initializes factor, minimum range and maximum range to values passed in.

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue.#ctor`

#### Summary

Default constructor. Initializes factor to 1.0 or 100%. Min and max range are set to 0.0

#### Since

2011

### `T:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue`

#### Summary

This class represents values used by a particular demand factor definition. Each instance
corresponds to a row in a table of values. These values are part of the ElectricalDemandFactorDefinition
class.

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.GetApplicableDemandFactor(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.GetApplicableDemandFactor(System.Double)`

#### Summary

This method will return the applicable demand factor for the specified number
of devices or load.

#### Parameter `numberOrLoad`

The number of devices or load for which the demand factor should be looked up.

#### Returns

The applicable demand factor.

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.GetValuesCount`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.GetValuesCount`

#### Summary

Returns the number of values in the set.

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.GetValues`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.GetValues`

#### Summary

Provides access to the value set stored with this demand factor definition

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.SetValues(System.Collections.Generic.ICollection{Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.SetValues(System.Collections.Generic.ICollection{Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue})`

#### Summary

Sets the value set to the demand factor definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.RemoveValue(Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.RemoveValue(Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue)`

#### Summary

Removes a value to the value set for this demand factor definition

#### Parameter `dfValue`

Value to remove from the set

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.AddValue(Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.AddValue(Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue)`

#### Summary

Adds a value to the value set for this demand factor definition

#### Parameter `dfValue`

Value to add to the set

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.ClearValues`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.ClearValues`

#### Summary

Clears all the values stored for this demand factor definition.

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new instance of a demand factor definition.

#### Parameter `ADoc`

The document where the element will be created and added.

#### Parameter `strName`

The name of the electrical demand factor definition to be created.

#### Returns

The newly created demand factor definition element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.IncludeAdditionalLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.IncludeAdditionalLoad`

#### Summary

Should the additional load (if set) be included in demand load calculations.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.RuleType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.RuleType`

#### Summary

The rule type for this demand factor definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.AdditionalLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.AdditionalLoad`

#### Summary

Additional load to be included during demand load calculation.

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition.#ctor`

#### Summary

Constructs a new ElectricalDemandFactorDefinition with default settings.

#### Since

2011

### `T:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition`

#### Summary

The ElectricalDemandFactorDef class represents a serialized version of an instance of
demand factor definition. It has a name, rule type, and values for the rules that are serialized.

#### Since

2011

### `T:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule`

#### Summary

This enum describes the different demand factor rule types available to the application.
Within a demand factor a rule will be referenced and the user will have to enter values
corresponding to that rule.

#### Since

2011

### `F:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule.LoadTablePerPortion`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule.LoadTablePerPortion`

#### Summary

This rule will apply the demand factor differently for each row in the table.
For example, the 3000kVA will have a 100% demand factor applied, the next 9000 will have a 35% factor applied,
and the remaining items will have a 25% factor applied.

### `F:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule.QuantityTablePerPortion`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule.QuantityTablePerPortion`

#### Summary

This rule will apply the demand factor differently for each row in the table.
For example, the first two (largest) items will have a 125% demand factor applied and the
remaining items will have a 75% factor applied.

### `F:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule.LoadTable`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule.LoadTable`

#### Summary

This rule will apply the demand factor for the total load of attached objects to a panel.
It is purely a look-up table. For example, if there are 5000 kVA, the user can specify 125% value is applied.
If there are 20,000 kVA, the user can specify 100% value is applied.

### `F:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule.QuantityTable`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule.QuantityTable`

#### Summary

This rule will apply the demand factor for the total quantity of attached objects to a panel.
It is purely a look-up table. For example, the user can specify that 0 to 2 objects get 100% and
2 to 4 objects get 85% and so on.

### `F:Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule.Constant`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule.Constant`

#### Summary

This rule will apply a constant demand factor to the loads, regardless of values.
It will also be the default for any newly created demand factor, and the default used if a
demand factor cannot be found for a load classification.

### `M:Autodesk.Revit.DB.Electrical.AnalyticalLoadScenariosData.GetLoadScenarioFactor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadScenariosData.GetLoadScenarioFactor(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the load scenario factor.

#### Parameter `loadScenarioId`

The load scenario id.

#### Returns

The load scenario factor.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId loadScenarioId is not an Analytical LoadScenario.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Electrical.AnalyticalLoadScenariosData.SetLoadScenarioFactor(Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadScenariosData.SetLoadScenarioFactor(Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Sets load scenario factor.

#### Parameter `loadScenarioId`

The load scenario id.

#### Parameter `dFactor`

The value of load scenario factor.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId loadScenarioId is not an Analytical LoadScenario.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for factor must be between 0 and 100.

### `P:Autodesk.Revit.DB.Electrical.AnalyticalLoadScenariosData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadScenariosData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Electrical.AnalyticalLoadScenariosData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalLoadScenariosData`

#### Summary

Represents the electrical analytical load scenarios data.
The map used to cache load case values modified by user.
If the load case uses default values, it won't be exist in this map.

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet.GetAnalyticalLoadScenariosData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet.GetAnalyticalLoadScenariosData`

#### Summary

Gets the electrical analytical load scenarios data.

#### Returns

The electrical analytical load scenarios data.

#### Since

2024

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet.GetLoadIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet.GetLoadIds`

#### Summary

Gets Equipment Load ids in the LoadSet.

#### Returns

The Equipment Load ids.

#### Since

2024

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates an electrical analytical load set.

#### Parameter `document`

The document where the new element will be created.

#### Parameter `name`

The name of new electrical analytical load set. The actual name may be post-fixed if already exists.

#### Returns

The newly created electrical analytical loadset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
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

2024

### `P:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet.TotalQuantity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet.TotalQuantity`

#### Summary

The total count of the Equipment Loads in the LoadSet.

#### Since

2024

### `P:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet.QuantityOnStandBy`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet.QuantityOnStandBy`

#### Summary

The number of Equipment Loads that are not operational at any time.

#### Remarks

The equipment loads with smaller load value within the set are considered on standby.
Must be between 0 and (total count of the Equipment Loads in the LoadSet)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The number is greater than the total count of the Equipment Loads in the LoadSet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for number is negative.

#### Since

2024

### `T:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet`

#### Summary

Represents the electrical analytical load set, it can contain a set of Electrical Analytical Equipment Loads.

#### Since

2024

### `M:Autodesk.Revit.DB.IFailuresPreprocessorProxy.PreprocessFailures(Autodesk.Revit.DB.FailuresAccessor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFailuresPreprocessorProxy.PreprocessFailures(Autodesk.Revit.DB.FailuresAccessor)`

#### Summary

This method is called when there have been failures found at the end of a transaction and Revit is about to start processing them.

#### Parameter `failuresAccessor`

The Interface class that provides access to the failure information.

#### Returns

Notifies end of transaction code about further actions required. Return values are interpreted as follows:
Continue - the failure processing will continue. Failures will be shown to the user, even if they were addressed by this method.

ProceedWithCommit - end of transaction checks and failure processing will restart from the beginning.
If some failures were resolved here, they will be removed and not delivered to the user.
ProceedWithCommit cannot be returned if transaction is being rolled back.

ProceedWithRollBack - the failure processing will continue. Failures will be shown to the user, but user will have no option
to resolve or ignore them - only cancel option will be available. If intent is to roll back transaction without showing failures to the user,
it can be achieved by setting failure handling option to remove failures before returning ProceedWithRollBack.
Other return values are not allowed.

#### Since

2011

### `M:Autodesk.Revit.DB.IFailuresPreprocessor.PreprocessFailures(Autodesk.Revit.DB.FailuresAccessor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFailuresPreprocessor.PreprocessFailures(Autodesk.Revit.DB.FailuresAccessor)`

#### Summary

This method is called when there have been failures found at the end of a transaction and Revit is about to start processing them.

#### Parameter `failuresAccessor`

The Interface class that provides access to the failure information.

#### Returns

Notifies end of transaction code about further actions required. Return values are interpreted as follows:
Continue - the failure processing will continue. Failures will be shown to the user, even if they were addressed by this method.

ProceedWithCommit - end of transaction checks and failure processing will restart from the beginning.
If some failures were resolved here, they will be removed and not delivered to the user.
ProceedWithCommit cannot be returned if transaction is being rolled back.

ProceedWithRollBack - the failure processing will continue. Failures will be shown to the user, but user will have no option
to resolve or ignore them - only cancel option will be available. If intent is to roll back transaction without showing failures to the user,
it can be achieved by setting failure handling option to remove failures before returning ProceedWithRollBack.
Other return values are not allowed.

#### Since

2011

### `T:Autodesk.Revit.DB.IFailuresPreprocessor`

Member kind: type
Symbol: `Autodesk.Revit.DB.IFailuresPreprocessor`

#### Summary

An interface that may be used to perform a preprocessing step to either filter out anticipated transaction failures
or to mark certain failures as non-continuable.

#### Remarks

This interface, if provided, is invoked when there are failures found at the end of a transaction.
An instance of this interface can be set in the failure handling options of transaction object.

#### Since

2011

### `M:Autodesk.Revit.DB.EditScope.Commit(Autodesk.Revit.DB.IFailuresPreprocessor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.EditScope.Commit(Autodesk.Revit.DB.IFailuresPreprocessor)`

#### Summary

Finishes the edit scope.

#### Remarks

All the changes made after starting the EditScope will be committed. Changes will be merged into one transaction.

#### Parameter `failurePreprocessor`

Callback to be invoked in the beginning of failure processing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

EditScope is not active. EditScope can only be committed or cancelled when it is active.
-or-
EditScope cannot be closed, for there is a transaction or transaction group still open in the document.

#### Since

2014

### `M:Autodesk.Revit.DB.EditScope.Cancel`

Member kind: method
Symbol: `Autodesk.Revit.DB.EditScope.Cancel`

#### Summary

Cancels the edit scope.

#### Remarks

All the changes made after starting the EditScope will be rolled back.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

EditScope is not active. EditScope can only be committed or cancelled when it is active.
-or-
EditScope cannot be closed, for there is a transaction or transaction group still open in the document.

#### Since

2014

### `P:Autodesk.Revit.DB.EditScope.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.EditScope.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.EditScope.IsPermitted`

Member kind: property
Symbol: `Autodesk.Revit.DB.EditScope.IsPermitted`

#### Summary

Tells if the edit scope is permitted to start.

#### Remarks

The edit scope is not permitted to start for one of the following possible reasons:
The document is in read-only state, or the document is currently modifiable,
or there already is another edit mode active in the document.

#### Since

2014

### `P:Autodesk.Revit.DB.EditScope.IsActive`

Member kind: property
Symbol: `Autodesk.Revit.DB.EditScope.IsActive`

#### Summary

Tells if the EditScope is active. In other words, the EditScope has started but not committed/canceled yet.

#### Remarks

Starting the edit scope is not permitted when it is active.
Canceling/committing is not allowed when the edit scope is not active.

#### Since

2014

### `T:Autodesk.Revit.DB.EditScope`

Member kind: type
Symbol: `Autodesk.Revit.DB.EditScope`

#### Summary

The base class for a scope object that provides special access and limitations related to editing certain elements.

#### Remarks

Derivations of this class provide specific functionality to manage edit modes for specific purposes.

#### Since

2014

### `P:Autodesk.Revit.DB.ExtensibleStorage.SchemaAccessOverride.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaAccessOverride.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaAccessOverride.#ctor(System.Guid,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaAccessOverride.#ctor(System.Guid,System.String)`

#### Summary

Activate the scope for the client/vendor.

#### Parameter `clientId`

GUID representing the client

#### Parameter `vendorId`

Id of the vendor.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021.1

### `T:Autodesk.Revit.DB.ExtensibleStorage.SchemaAccessOverride`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaAccessOverride`

#### Summary

Provide a mechanism to override schema access for a specified client and vendor.

#### Remarks

Access levels to schema data is controlled by the active client and associated vendor
id's at time of access.

By default, this gets set based on what client or addin is reacting to an event or
command.

SchemaAccessOverride allows overriding of schema access by specifying the
client guid and vendor id to override with. The override lasts for scope of the object.

#### Since

2021.1

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.AcceptableName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.AcceptableName(System.String)`

#### Summary

Checks whether a string is an acceptable name for a Schema or a Field.

#### Remarks

For interoperability, names are required to be usable as C++ identifiers.
The allowable characters are ASCII letters, numbers (except the first character) and
underscore. The length must be between 1 and 247 characters.

#### Parameter `name`

The string to check.

#### Returns

True if the name is acceptable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.Ready`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.Ready`

#### Summary

Checks whether the builder may be used.

#### Remarks

All newly constructed SchemaBuilders are usable until the call to the Finish method.

#### Returns

True if the SchemaBuilder has not yet been finished.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.Finish`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.Finish`

#### Summary

Registers and returns the created Schema object.

#### Returns

The newly created Schema.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The SchemaBuilder has already finished building the Schema.
-or-
A different Schema with a matching identity already exists.
-or-
Two fields with the same name are detected.
-or-
At least one field has invalid units.
-or-
SchemaName is not set.
-or-
VendorId is not set for a restricted access level.
-or-
ApplicationGUID is not set for an application access level.
-or-
More than 256 fields were added to the schema.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.SetVendorId(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.SetVendorId(System.String)`

#### Summary

Sets the ID of the third-party vendor that may access entities of this Schema under the
Vendor acess level, and to generally identify the owner of this Schema.

#### Remarks

This method throws an ArgumentException if the given vendor ID string is not valid.
To understand the validity requirements for vendor ID strings, see the documentation
for the ESSchemaBuilder method vendorIdIsValid().

Since vendor IDs are not case sensitive, the string will be converted to upper case
before it is stored in the schema.

#### Parameter `vendorId`

The vendor id.

#### Returns

The SchemaBuilder object may be used to add more settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The vendorId is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The SchemaBuilder has already finished building the Schema.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.SetApplicationGUID(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.SetApplicationGUID(System.Guid)`

#### Summary

Sets the GUID of the application or add-in that may access entities of this Schema under
the Application acess level.

#### Parameter `applicationGUID`

The application id.

#### Returns

The SchemaBuilder object may be used to add more settings.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The SchemaBuilder has already finished building the Schema.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.SetDocumentation(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.SetDocumentation(System.String)`

#### Summary

Sets the documentation string for the Schema.

#### Remarks

While Entities may be hidden using access levels, Schemas and Fields are visible to
clients and other developers. In the interest of clarity and interoperability, you are
very strongly encouraged to provide good documentation with your Schemas.

Explain the intent of the data and how it is meant to be interpreted. It is not
useful to repeat information that can be observed directly (e.g. types and units).

Note that documentation, like all other contents of Schemas and Fields is immutable
once the add-in using the Schema is published.

#### Parameter `documentation`

The documentation string.

#### Returns

The SchemaBuilder object may be used to add more settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The SchemaBuilder has already finished building the Schema.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.SetSchemaName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.SetSchemaName(System.String)`

#### Summary

Sets the name of the Schema.

#### Remarks

The name is a user-friendly identifier of the Schema. GUIDs are used exclusively
for Schema identity, but the name is useful to identify the Schema during development
or in an error message.

This field is required.

#### Parameter `schemaName`

The name for the Schema.

#### Returns

The SchemaBuilder object may be used to add more settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The parameter schemaName is not acceptable for naming Extensible Storage objects.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The SchemaBuilder has already finished building the Schema.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.SetWriteAccessLevel(Autodesk.Revit.DB.ExtensibleStorage.AccessLevel)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.SetWriteAccessLevel(Autodesk.Revit.DB.ExtensibleStorage.AccessLevel)`

#### Summary

Sets top level write access (for entities)

#### Parameter `writeAccessLevel`

Write access level value to be set

#### Returns

The SchemaBuilder object may be used to add more settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The SchemaBuilder has already finished building the Schema.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.SetReadAccessLevel(Autodesk.Revit.DB.ExtensibleStorage.AccessLevel)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.SetReadAccessLevel(Autodesk.Revit.DB.ExtensibleStorage.AccessLevel)`

#### Summary

Sets top level read access (for entities)

#### Parameter `readAccessLevel`

Read access level value to be set

#### Returns

The SchemaBuilder object may be used to add more settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The SchemaBuilder has already finished building the Schema.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.AddMapField(System.String,System.Type,System.Type)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.AddMapField(System.String,System.Type,System.Type)`

#### Summary

Creates a field containing an ordered key-value map in the Schema, with given name and
type of contained values.

#### Remarks

The supported types for the keys are Boolean, Byte, Int16, Int32, Int64, ElementId,
GUID and String. Floating-point types (Float, Double, XYZ and UV) are not supported
because round-off errors frequently cause numeric instability. Subentities are not
supported because they require a custom comparison operator. The suggested workarounds
are either placing key values into an Array and using array indices for keys, or
just using an Array of subentities.

Natural comparison of contained types is used for sorting.

The supported types for values are the same as for simple fields.
See `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.AddSimpleField(System.String,System.Type)` for details.

Note that a schema may contain a maximum of 256 fields.

#### Parameter `fieldName`

The name of the new field.

#### Parameter `keyType`

The type of the keys for the new field.

#### Parameter `valueType`

The type of the values for the new field.

#### Returns

The FieldBuilder object may be used to add more details to the field. Make sure to set
the unit type if the field contains floating-point values.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The parameter fieldName is not acceptable for naming Extensible Storage objects.
-or-
The field type is not supported.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The combination of key and value types is not supported.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The SchemaBuilder has already finished building the Schema.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.AddArrayField(System.String,System.Type)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.AddArrayField(System.String,System.Type)`

#### Summary

Creates a field containing an array of values in the Schema, with given name and type
of contained values.

#### Remarks

The supported types for the contents are the same as for simple fields.
See `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.AddSimpleField(System.String,System.Type)` for details.

Note that a schema may contain a maximum of 256 fields.

#### Parameter `fieldName`

The name of the new field.

#### Parameter `fieldType`

The type of the contents in the new field.

#### Returns

The FieldBuilder object may be used to add more details to the field. Make sure to set
the unit type if the field contains floating-point values.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The parameter fieldName is not acceptable for naming Extensible Storage objects.
-or-
The field type is not supported.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The SchemaBuilder has already finished building the Schema.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.AddSimpleField(System.String,System.Type)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.AddSimpleField(System.String,System.Type)`

#### Summary

Creates a field containing a single value in the Schema, with given name and type.

#### Remarks

The supported types are Boolean, Byte, Int16, Int32, Int64, Float, Double, ElementId,
GUID, String, XYZ, UV and Entity.

Note that data of type ElementId is not copied to new elements that are created via copy/paste or a linear or radial array.

Note that a schema may contain a maximum of 256 fields.

#### Parameter `fieldName`

The name of the new field.

#### Parameter `fieldType`

The type of the new field.

#### Returns

The FieldBuilder object may be used to add more details to the field. Make sure to set
the unit type if the field contains floating-point values.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The parameter fieldName is not acceptable for naming Extensible Storage objects.
-or-
The field type is not supported.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The SchemaBuilder has already finished building the Schema.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.VendorIdIsValid(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.VendorIdIsValid(System.String)`

#### Summary

Checks whether the given vendor ID string is valid. A valid vendor ID string:
1. Has a length of at least 4 characters and no more than 253 characters, and
2. Contains only letters, digits, or any of the following special characters:
! " # & \ ( ) + , . - : ; < = > ? _ ` | ~

#### Parameter `vendorId`

The vendor ID to check.

#### Returns

True if the vendor ID is valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.GUIDIsValid(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.GUIDIsValid(System.Guid)`

#### Summary

Checks whether the supplied GUID value is valid.

#### Parameter `guid`

The GUID to check

#### Returns

True if the GUID is valid

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.#ctor(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder.#ctor(System.Guid)`

#### Summary

Constructs a new SchemaBuilder where the resulting Schema will use the input GUID.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The guid value is invalid.

#### Since

2012

### `T:Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder`

#### Summary

This class is used to create Schemas in the Extensible Storage framework.

#### Remarks

Named parameter idiom: Methods that set up the Schema return a reference to the builder so
you can invoke multiple methods in a chain
(e.g., builder.setReadAccessLevel(...).setWriteAccessLevel(...)).
Methods that add fields return a FieldBuilder instead.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.NeedsSubSchemaGUID`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.NeedsSubSchemaGUID`

#### Summary

Checks whether the SubSchema GUID needs to be explicitly specified for this field type.

#### Returns

True if SubSchemaGUID is required.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.NeedsUnits`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.NeedsUnits`

#### Summary

Checks whether the field type requires explicit unit conversions.

#### Returns

True if units are required.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.Ready`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.Ready`

#### Summary

Checks whether the builder may be used.

#### Remarks

All newly constructed FieldBuilders are usable until the call to the Finish method
of the constructing SchemaBuilder.

#### Returns

True if the SchemaBuilder has not yet been finished.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.SetDocumentation(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.SetDocumentation(System.String)`

#### Summary

Sets the documentation string for the Field.

#### Remarks

While Entities may be hidden using access levels, Schemas and Fields are visible to
clients and other developers. In the interest of clarity and interoperability, you are
very strongly encouraged to provide good documentation with your Schemas.

Explain the intent of the data and how it is meant to be interpreted. It is not
useful to repeat information that can be observed directly (e.g. types and units).

Note that documentation, like all other contents of Schemas and Fields is immutable
once the add-in using the Schema is published.

#### Parameter `documentation`

The documentation string.

#### Returns

The FieldBuilder object may be used to add more details to the field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The SchemaBuilder has already finished building the Schema.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.SetSubSchemaGUID(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.SetSubSchemaGUID(System.Guid)`

#### Summary

Sets the GUID of the Schema of the Entities that are intended to be stored in this field.

#### Remarks

Fields of type Entity - subentities - need to specify their Schema. The framework
will prevent subentities with incorrect schemas from being stored in the entity.
Additionally, the access level of the subschema will be checked against the
currently executing add-in and access to restricted subentities will be prevented.

#### Parameter `guid`

The GUID of the subschema.

#### Returns

The FieldBuilder object may be used to add more details to the field.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The SchemaBuilder has already finished building the Schema.
-or-
The field type does not utilize SubSchemas.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.SetSpec(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.SetSpec(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Sets the spec describing the field's values.

#### Parameter `specTypeId`

Identifier of the spec.

#### Returns

The FieldBuilder object may be used to add more details to the field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The SchemaBuilder has already finished building the Schema.
-or-
The field type does not utilize unit conversions.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.#ctor(Autodesk.Revit.DB.ExtensibleStorage.Field,Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.#ctor(Autodesk.Revit.DB.ExtensibleStorage.Field,Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder)`

#### Summary

Constructs a new FieldBuilder using the field and associated SchemaBuilder object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.#ctor(Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder.#ctor(Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder)`

#### Summary

Constructs a new copy of the input ESFieldBuilder object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder`

#### Summary

This class is used to create Fields in the Extensible Storage framework.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Schema.WriteAccessGranted`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.WriteAccessGranted`

#### Summary

Checks whether Entities of this Schema may be stored by the current add-in.

#### Returns

True if write access is allowed.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Schema.ReadAccessGranted`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.ReadAccessGranted`

#### Summary

Checks whether Entities of this Schema may be retrieved by the current add-in.

#### Returns

True if read access is allowed.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Schema.ListFields`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.ListFields`

#### Summary

The complete list of fields in the Schema, sorted by name.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Reading of Entities of this Schema is not allowed to the current add-in.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Schema.GetField(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.GetField(System.String)`

#### Summary

Gets a Field of a given name from the Schema.

#### Parameter `name`

The Field name

#### Returns

The Field

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Reading of Entities of this Schema is not allowed to the current add-in.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Schema.ListSchemas`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.ListSchemas`

#### Summary

Lists all schemas in memory.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Schema.Lookup(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.Lookup(System.Guid)`

#### Summary

Finds the Schema corresponding to the GUID in memory.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Schema.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExtensibleStorage.Schema.Documentation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.Documentation`

#### Summary

The overall description of the Schema.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Schema.VendorId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.VendorId`

#### Summary

The id of the third-party vendor that may access entities of this Schema under the
Vendor access level.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Schema.ApplicationGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.ApplicationGUID`

#### Summary

The GUID of the application or add-in that may access entities of this Schema under the
Application access level.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Schema.WriteAccessLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.WriteAccessLevel`

#### Summary

Write access level of the schema.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Schema.ReadAccessLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.ReadAccessLevel`

#### Summary

Read access level of the schema.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Schema.SchemaName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.SchemaName`

#### Summary

The user-friendly name of the Schema.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Schema.GUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema.GUID`

#### Summary

The identifier of the Schema.
Setter made unavailable, because it would violate set-correctness

#### Since

2012

### `T:Autodesk.Revit.DB.ExtensibleStorage.Schema`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Schema`

#### Summary

The description of a single object (Entity) in the Extensible Storage framework. Contains
identity information, documentation and the list of fields to be stored in the Entity.

#### Remarks

A Schema is similar to a class in most object-oriented languages, or to a C struct,
while an Entity is an object of that class.

The Schema object is immutable. To create and populate a Schema, use the SchemaBuilder
class. Schemas are stored in the memory of the running instance of Revit and may be
retrieved with the Lookup method.

When a document containing Entities of a Schema is saved, the Schema is saved with the
document too. Opening that document reintroduces the Schema into memory.

As you plan to store your data in Revit, please be aware that the data will be
stored in Revit elements. Overwhelming the Revit database will impact performance and
stability, and will make the user unhappy. Also, remember that multiple add-ins may be
storing their data simultaneously. Several kB per element or several MB per file
are reasonable maximums for one add-in. If you have larger requirements, consider storing
them in a separate database (such as SQLite) and storing keys into that database in Revit.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.Clear(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.Clear(System.String)`

#### Summary

Resets the field to its default value.

#### Remarks

The default value is zero for numeric fields, invalid value for identifiers and
entities, and empty for strings and containers.

This method is a shortcut that will look up the field by name. If you want to call it
on many entities, it is faster if you look up the field yourself.

#### Parameter `fieldName`

The name of the field to clear.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The name matches no field in this Entity's Schema.
-or-
This field's subschema prevents writing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Entity is invalid.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.Clear(Autodesk.Revit.DB.ExtensibleStorage.Field)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.Clear(Autodesk.Revit.DB.ExtensibleStorage.Field)`

#### Summary

Resets the field to its default value.

#### Remarks

The default value is zero for numeric fields, invalid value for identifiers and
entities, and empty for strings and containers.

#### Parameter `field`

The field to clear.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The Field belongs to a different Schema from this Entity, or this Entity is invalid.
-or-
This field's subschema prevents writing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.RecognizedField(Autodesk.Revit.DB.ExtensibleStorage.Field)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.RecognizedField(Autodesk.Revit.DB.ExtensibleStorage.Field)`

#### Summary

Checks whether a Field belongs to the same Schema as this Entity.

#### Parameter `field`

The Field to check.

#### Returns

True if the Field belongs to the same Schema as this Entity.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.WriteAccessGranted`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.WriteAccessGranted`

#### Summary

Checks whether this Entity may be stored by the current add-in.

#### Returns

True if write access is allowed.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.ReadAccessGranted`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.ReadAccessGranted`

#### Summary

Checks whether this Entity may be retrieved by the current add-in.

#### Returns

True if read access is allowed.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.IsValid`

#### Summary

Checks whether this Entity has a live Schema corresponding to it.

#### Remarks

Invalid entities may be used as token values. E.g., setting an invalid subentity
is equivalent to deleting the stored one.

#### Returns

True if the Entity is valid.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Entity.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExtensibleStorage.Entity.SchemaGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.SchemaGUID`

#### Summary

The GUID of the Schema describing this Entity.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Entity.Schema`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.Schema`

#### Summary

The Schema describing this Entity.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.Set``1(System.String,``0,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.Set``1(System.String,``0,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Stores the value of the field in the entity.

#### Remarks

The template parameter must match the type of the field (specified when creating the
Schema) exactly; this method does not perform data type conversions. The types for containers are
IList for arrays and
IDictionary for maps.

This method only modifies your copy of the Entity. Store the Entity in an element or
another Entity to save the new value. Write access check is not performed on each call
to Set. Instead, write access is checked when you try to save the Entity in an Element
or another Entity.

This method is a shortcut that will look up the field by name. If you want to call it
on many entities, it is faster if you look up the field yourself.

#### Parameter `fieldName`

The name of the field to update.

#### Parameter `unitTypeId`

Identifier of the unit from which the value will be converted before storing. Must be compatible with the spec
specified when creating the Schema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Field belongs to a different Schema from this Entity, or this Entity is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Requested type does not match the field type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The name matches no field in this Entity's Schema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The unitTypeId value is not compatible with the field description.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This field's subschema prevents writing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid floating-point value.

#### Since

2012

#### Type parameter `FieldType`

The type of the field

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.Set``1(Autodesk.Revit.DB.ExtensibleStorage.Field,``0,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.Set``1(Autodesk.Revit.DB.ExtensibleStorage.Field,``0,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Stores the value of the field in the entity.

#### Remarks

The template parameter must match the type of the field (specified when creating the
Schema) exactly; this method does not perform data type conversions. The types for containers are
IList for arrays and
IDictionary for maps.

This method only modifies your copy of the Entity. Store the Entity in an element or
another Entity to save the new value. Write access check is not performed on each call
to Set. Instead, write access is checked when you try to save the Entity in an Element
or another Entity.

#### Parameter `field`

The field to update.

#### Parameter `unitTypeId`

Identifier of the unit from which the value will be converted before storing. Must be compatible with the spec
specified when creating the Schema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Field belongs to a different Schema from this Entity, or this Entity is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Requested type does not match the field type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The unitTypeId value is not compatible with the field description.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This field's subschema prevents writing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid floating-point value.

#### Since

2012

#### Type parameter `FieldType`

The type of the field

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.Set``1(System.String,``0)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.Set``1(System.String,``0)`

#### Summary

Stores the value of the field in the entity.

#### Remarks

The template parameter must match the type of the field (specified when creating the
Schema) exactly; this method does not perform data type conversions. The types for containers are
IList for arrays and
IDictionary for maps.

Note that when string values are specified as map keys,
they are case-insensitive.

This method only modifies your copy of the Entity. Store the Entity in an element or
another Entity to save the new value. Write access check is not performed on each call
to Set. Instead, write access is checked when you try to save the Entity in an Element
or another Entity.

This method is a shortcut that will look up the field by name. If you want to call it
on many entities, it is faster if you look up the field yourself.

#### Parameter `fieldName`

The name of the field to update.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Field belongs to a different Schema from this Entity, or this Entity is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Requested type does not match the field type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The name matches no field in this Entity's Schema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

For floating-point fields, use the overload taking a ForgeTypeId parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This field's subschema prevents writing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid floating-point value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

String is too long; exceeds max length of 16mb characters.

#### Since

2012

#### Type parameter `FieldType`

The type of the field

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.Set``1(Autodesk.Revit.DB.ExtensibleStorage.Field,``0)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.Set``1(Autodesk.Revit.DB.ExtensibleStorage.Field,``0)`

#### Summary

Stores the value of the field in the entity.

#### Remarks

The template parameter must match the type of the field (specified when creating the
Schema) exactly; this method does not perform data type conversions. The types for containers are
IList for arrays and
IDictionary for maps.

Note that when string values are specified as map keys,
they are case-insensitive.

This method only modifies your copy of the Entity. Store the Entity in an element or
another Entity to save the new value. Write access check is not performed on each call
to Set. Instead, write access is checked when you try to save the Entity in an Element
or another Entity.

#### Parameter `field`

The field to update.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Field belongs to a different Schema from this Entity, or this Entity is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Requested type does not match the field type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

For floating-point fields, use the overload taking a ForgeTypeId parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This field's subschema prevents writing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid floating-point value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

String is too long; exceeds max length of 16mb characters.

#### Since

2012

#### Type parameter `FieldType`

The type of the field

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.Get``1(System.String,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.Get``1(System.String,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Retrieves the value of the field in the entity.

#### Remarks

The template parameter must match the type of the field (specified when creating the
Schema) exactly; this method does not perform data type conversions. The types for containers are
IList for arrays and
IDictionary for maps.

This method is a shortcut that will look up the field by name. If you want to call it
on many entities, it is faster if you look up the field yourself.

#### Parameter `fieldName`

The name of the field to retrieve.

#### Parameter `unitTypeId`

Identifier of the unit to which the value will be converted before returning. Must be compatible with the spec
specified when creating the Schema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Field belongs to a different Schema from this Entity, or this Entity is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Requested type does not match the field type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The name matches no field in this Entity's Schema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The unitTypeId value is not compatible with the field description.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This field's subschema prevents reading.

#### Since

2012

#### Type parameter `FieldType`

The type of the field

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.Get``1(Autodesk.Revit.DB.ExtensibleStorage.Field,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.Get``1(Autodesk.Revit.DB.ExtensibleStorage.Field,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Retrieves the value of the field in the entity.

#### Remarks

The template parameter must match the type of the field (specified when creating the
Schema) exactly; this method does not perform data type conversions. The types for containers are
IList for arrays and
IDictionary for maps.

#### Parameter `field`

The field to retrieve.

#### Parameter `unitTypeId`

Identifier of the unit to which the value will be converted before returning. Must be compatible with the spec
specified when creating the Schema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Field belongs to a different Schema from this Entity, or this Entity is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Requested type does not match the field type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The unitTypeId value is not compatible with the field description.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This field's subschema prevents reading.

#### Since

2012

#### Type parameter `FieldType`

The type of the field

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.Get``1(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.Get``1(System.String)`

#### Summary

Retrieves the value of the field in the entity.

#### Remarks

The template parameter must match the type of the field (specified when creating the
Schema) exactly; this method does not perform data type conversions. The types for containers are
IList for arrays and
IDictionary for maps.

This method is a shortcut that will look up the field by name. If you want to call it
on many entities, it is faster if you look up the field yourself.

#### Parameter `fieldName`

The name of the field to retrieve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Field belongs to a different Schema from this Entity, or this Entity is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Requested type does not match the field type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The name matches no field in this Entity's Schema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

For floating-point fields, use the overload taking a ForgeTypeId parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This field's subschema prevents reading.

#### Since

2012

#### Type parameter `FieldType`

The type of the field

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.Get``1(Autodesk.Revit.DB.ExtensibleStorage.Field)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.Get``1(Autodesk.Revit.DB.ExtensibleStorage.Field)`

#### Summary

Retrieves the value of the field in the entity.

#### Remarks

The template parameter must match the type of the field (specified when creating the
Schema) exactly; this method does not perform data type conversions. The types for containers are
IList for arrays and
IDictionary for maps.

#### Parameter `field`

The field to retrieve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Field belongs to a different Schema from this Entity, or this Entity is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Requested type does not match the field type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

For floating-point fields, use the overload taking a ForgeTypeId parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This field's subschema prevents reading.

#### Since

2012

#### Type parameter `FieldType`

The type of the field

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.#ctor(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.#ctor(System.Guid)`

#### Summary

Creates a new Entity corresponding to the Schema of the specified GUID.

#### Remarks

You can store the newly created Entity in an Element or in another Entity.
If you do not have write access to the Schema, an exception will be thrown.
If the GUID does not correspond to a known Schema, the Entity will be invalid
and an exception will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The GUID does not correspond to any Schema in memory.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Writing of Entities of this Schema is not allowed to the current add-in.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.#ctor(Autodesk.Revit.DB.ExtensibleStorage.Schema)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.#ctor(Autodesk.Revit.DB.ExtensibleStorage.Schema)`

#### Summary

Creates a new Entity corresponding to the Schema.

#### Remarks

You can store the newly created Entity in an Element or in another Entity.
If you do not have write access to the Schema, an exception will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Writing of Entities of this Schema is not allowed to the current add-in.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.#ctor`

#### Summary

The default-constructed Entity is invalid.

#### Remarks

Invalid entities may be used as token values. E.g., setting an invalid subentity
is equivalent to deleting the stored one.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Entity.#ctor(Autodesk.Revit.DB.ExtensibleStorage.Entity)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity.#ctor(Autodesk.Revit.DB.ExtensibleStorage.Entity)`

#### Summary

Constructs a new copy of the input ESEntity object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.ExtensibleStorage.Entity`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Entity`

#### Summary

An object stored in the Extensible Storage framework. An Entity is described by a Schema,
which serves both to identify an Entity, and to describe its contents (Fields).

#### Remarks

An Entity is similar to an object in most object-oriented languages, while a Schema is the
class of that object.

The Get and Set methods are central - they provide access to the fields of the Entity.

Note that an unitialized Entity retrieved from an Element or another Entity (if it has not
been created yet) will be represented as an invalid entity, not `null` .

If an Element containing an Entity is split (e.g., a wall split), the Entity and its data will exist
in both new Elements.

If an Element containing an Entity is copied, the Element copy will also contain a copy of the Entity and its data.

If an Entity stores an ElementId, and the Element with that ElementId is deleted, the stored
ElementId will automatically be set to ElementId.InvalidElementId (-1).

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Field.GetSpecTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field.GetSpecTypeId`

#### Summary

Gets the spec describing the values stored in this field.

#### Returns

Identifier of the spec.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Field.SubEntityWriteAccessGranted`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field.SubEntityWriteAccessGranted`

#### Summary

Checks whether there is write access to subentities storable in this field.

#### Returns

True if subentities are writable.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Field.SubEntityReadAccessGranted`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field.SubEntityReadAccessGranted`

#### Summary

Checks whether there is read access to subentities storable in this field.

#### Returns

True if subentities are readable.

#### Since

2012

### `M:Autodesk.Revit.DB.ExtensibleStorage.Field.CompatibleUnit(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field.CompatibleUnit(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks if the specified unit is compatible with the field description.

#### Parameter `unitTypeId`

The unit to check.

#### Returns

True if the unit is compatible, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Field.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExtensibleStorage.Field.SubSchema`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field.SubSchema`

#### Summary

The Schema describing the subentity (or subentities) stored in this Field.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Field.KeyType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field.KeyType`

#### Summary

The type of the keys stored in the field.

#### Remarks

For key-value maps, this is the key type. For all other field, this is NULL.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Field.ValueType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field.ValueType`

#### Summary

The type of the values stored in the field.

#### Remarks

For key-value maps, this is the value type.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Field.Documentation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field.Documentation`

#### Summary

The overall description of the Field.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Field.ContainerType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field.ContainerType`

#### Summary

Reports whether this is a simple field containing one value,
or a container of multiple values.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Field.SubSchemaGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field.SubSchemaGUID`

#### Summary

The GUID of the Schema describing the subentity (or subentities) stored in this Field.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Field.Schema`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field.Schema`

#### Summary

The Schema to which this Field belongs.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.Field.FieldName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field.FieldName`

#### Summary

The name of the field.

#### Since

2012

### `T:Autodesk.Revit.DB.ExtensibleStorage.Field`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.Field`

#### Summary

The description of a field within a Schema in the Extensible Storage framework. Contains
the field's name, type, access control and documentation.

#### Since

2012

### `T:Autodesk.Revit.DB.ExtensibleStorage.ContainerType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.ContainerType`

#### Summary

An enumerated type indicating if the field represents a single value or a container of multiple values.

### `F:Autodesk.Revit.DB.ExtensibleStorage.ContainerType.Map`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.ContainerType.Map`

#### Summary

An ordered map from keys to values

### `F:Autodesk.Revit.DB.ExtensibleStorage.ContainerType.Array`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.ContainerType.Array`

#### Summary

An expandable array of values

### `F:Autodesk.Revit.DB.ExtensibleStorage.ContainerType.Simple`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.ContainerType.Simple`

#### Summary

One instance of the value included directly

### `T:Autodesk.Revit.DB.ExtensibleStorage.AccessLevel`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.AccessLevel`

#### Summary

Defines access levels to objects in the Extensible Storage framework.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.ExtensibleStorage.AccessLevel.Application`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.AccessLevel.Application`

#### Summary

Only application that created the object has access to it.

### `F:Autodesk.Revit.DB.ExtensibleStorage.AccessLevel.Vendor`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.AccessLevel.Vendor`

#### Summary

Only object vendor has access to it.

### `F:Autodesk.Revit.DB.ExtensibleStorage.AccessLevel.Public`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.AccessLevel.Public`

#### Summary

Anybody has access to the object.

### `T:Autodesk.Revit.DB.InternalDefinitions`

Member kind: type
Symbol: `Autodesk.Revit.DB.InternalDefinitions`

#### Summary

This object blocks attempts to create new internal definitions as they are not permitted.

### `T:Autodesk.Revit.DB.ExternalDefinitions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalDefinitions`

#### Summary

Supports the creation of new shared parameters definitions.

### `M:Autodesk.Revit.DB.Definitions.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Definitions.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Definitions.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Definitions.GetEnumerator`

#### Summary

Retrieves an enumerator to the collection.

#### Returns

The enumerator.

### `P:Autodesk.Revit.DB.Definitions.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Definitions.Size`

#### Summary

The number of definitions in the collection.

### `P:Autodesk.Revit.DB.Definitions.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Definitions.IsEmpty`

#### Summary

Identifies if the definitions collection is empty.

### `M:Autodesk.Revit.DB.Definitions.Contains(Autodesk.Revit.DB.Definition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Definitions.Contains(Autodesk.Revit.DB.Definition)`

#### Summary

Tests for the existence of a definition within the set.

#### Returns

True if the definition was found, false otherwise.

#### Parameter `definition`

The definition to look for.

### `M:Autodesk.Revit.DB.Definitions.Create(Autodesk.Revit.DB.ExternalDefinitionCreationOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Definitions.Create(Autodesk.Revit.DB.ExternalDefinitionCreationOptions)`

#### Summary

Creates a new parameter definition using specified options.

#### Parameter `option`

The options used to create the new parameter definition.

#### Returns

If successful a reference to the new parameter definition is returned, otherwise `null` .

#### Remarks

This method only supports creation of new external definitions (shared parameters).

#### Throws

options.Name cannot include non-printable characters.

#### Throws

options.Name is already present in the associated shared parameter definitions.

#### Throws

options.GUID is already present in the associated shared parameter definitions.

#### Since

2015

### `P:Autodesk.Revit.DB.Definitions.Item(System.String)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Definitions.Item(System.String)`

#### Summary

Retrieves a definition by a given name.

#### Parameter `name`

The name of the parameter definition for which to search.

#### Remarks

If the definition is not found then `null` will be returned.

### `M:Autodesk.Revit.DB.Definitions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Definitions.#ctor`

#### Summary

Constructs an empty set of parameter definitions.

### `T:Autodesk.Revit.DB.Definitions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Definitions`

#### Summary

A base class that supports the addition of new parameter definitions.

#### Remarks

There are two derivations of this class, one of which handles external parameters
and another which handles internal parameters.

### `M:Autodesk.Revit.DB.DefinitionGroups.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionGroups.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.DefinitionGroups.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionGroups.GetEnumerator`

#### Summary

Retrieves an enumerator to the collection.

#### Returns

The enumerator.

### `P:Autodesk.Revit.DB.DefinitionGroups.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefinitionGroups.Size`

#### Summary

The number of definition groups in the collection.

### `P:Autodesk.Revit.DB.DefinitionGroups.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefinitionGroups.IsEmpty`

#### Summary

Identifies if the definition groups collection is empty.

### `M:Autodesk.Revit.DB.DefinitionGroups.Contains(Autodesk.Revit.DB.DefinitionGroup)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionGroups.Contains(Autodesk.Revit.DB.DefinitionGroup)`

#### Summary

Tests for the existence of a definition group within the collection.

#### Returns

True if the definition group was found, false otherwise.

#### Parameter `definitionGroup`

The definition group to look for.

### `M:Autodesk.Revit.DB.DefinitionGroups.Create(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionGroups.Create(System.String)`

#### Summary

Create a new parameter definition group using the name provided.

#### Parameter `name`

The name of the group to be created.

#### Returns

If successful a reference to the new parameter group is returned, otherwise `null` .

#### Remarks

If a group with the same name already exists then an exception will be thrown.

### `P:Autodesk.Revit.DB.DefinitionGroups.Item(System.String)`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefinitionGroups.Item(System.String)`

#### Summary

Retrieve a definition group by name.

#### Parameter `groupName`

The name of the group for which to search.

#### Remarks

If the group is not found then `null` will be returned.

### `T:Autodesk.Revit.DB.DefinitionGroups`

Member kind: type
Symbol: `Autodesk.Revit.DB.DefinitionGroups`

#### Summary

A specialized set of definition groups that allows creation of new groups.

### `P:Autodesk.Revit.DB.DefinitionFile.Filename`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefinitionFile.Filename`

#### Summary

This property returns the physical filename of the shared parameters file on disk.

### `P:Autodesk.Revit.DB.DefinitionFile.Groups`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefinitionFile.Groups`

#### Summary

Return a map of shared parameter definition groups contained within the file.

#### Remarks

A particular group can be found by Name, using the Item property on the DefinitionGroups
object. A new group can be created by using the Create method on the DefinitionGroups Object.
The Create method takes the name of the new group, as a string, as its input parameter, returning
a reference to a new definition group object as its result.

### `T:Autodesk.Revit.DB.DefinitionFile`

Member kind: type
Symbol: `Autodesk.Revit.DB.DefinitionFile`

#### Summary

The DefinitionFile object represents a shared parameters file on disk.

#### Remarks

Shared Parameters are parameter definitions that are stored in a text file
external to the Autodesk Revit project. These definitions can be used in multiple projects
and are identifiable by a unique identifier generated when they are created. API access to
shared parameters consist of a number of objects, the first of which is an object that
represents the shared parameters file on disk. That object then contains a number of Group
objects. Shared parameters are grouped for easier management. These groups then contain the
shared parameter definitions. The groups support the ability to create new shared
parameter definitions. The DefinitionFile object can be retrieved by the
Application.OpenSharedParameterFile method.

### `P:Autodesk.Revit.DB.DefinitionGroup.Definitions`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefinitionGroup.Definitions`

#### Summary

The Definitions property returns an object that contains all the shared parameter
definitions within the group.

#### Remarks

A known definition can be retrieved, by name, using the Item property on the Definitions
object. A new definition can be created by using the Create method. The Create method takes two
parameters, a string for name and a type. If the creation of the definition was successful then
an object representing the definition is returned by the Create method.

### `P:Autodesk.Revit.DB.DefinitionGroup.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefinitionGroup.Name`

#### Summary

Returns the name of the parameter group.

### `T:Autodesk.Revit.DB.DefinitionGroup`

Member kind: type
Symbol: `Autodesk.Revit.DB.DefinitionGroup`

#### Summary

The DefinitionGroup is a container that is used to hold shared parameter definitions on disk.

#### Remarks

Groups are used for logical arrangement of the shared parameters into meaningful sets.
Through the DefinitionGroup object new shared parameter definitions can be made.

### `P:Autodesk.Revit.DB.Settings.TilePatterns`

Member kind: property
Symbol: `Autodesk.Revit.DB.Settings.TilePatterns`

#### Summary

Retrieves an object that provides access to the TilePattern objects in
the document.

### `P:Autodesk.Revit.DB.Settings.ElectricalSetting`

Member kind: property
Symbol: `Autodesk.Revit.DB.Settings.ElectricalSetting`

#### Summary

Retrieves an object that provides access to all the electrical settings include voltage type, distribution system type,
demand factor, wire type in the Autodesk Revit application and project.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Electrical settings can be accessed only if Revit MEP product is available.

### `P:Autodesk.Revit.DB.Settings.Categories`

Member kind: property
Symbol: `Autodesk.Revit.DB.Settings.Categories`

#### Summary

Retrieves an object that provides access to all the categories contained in the Autodesk
Revit application and project.

### `T:Autodesk.Revit.DB.Settings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Settings`

#### Summary

The settings object provides access to general components of the Autodesk Revit
application, such as Categories.

### `M:Autodesk.Revit.DB.TypeBinding.#ctor(Autodesk.Revit.DB.CategorySet)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TypeBinding.#ctor(Autodesk.Revit.DB.CategorySet)`

#### Summary

Constructs a type binding with the set of categories passed.

#### Remarks

Categories can be set or changed at a later time by using the Categories property of this object.

### `M:Autodesk.Revit.DB.TypeBinding.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.TypeBinding.#ctor`

#### Summary

Constructs an empty type binding.

#### Remarks

Categories can be set a later time by using the Categories property of this object.

### `T:Autodesk.Revit.DB.TypeBinding`

Member kind: type
Symbol: `Autodesk.Revit.DB.TypeBinding`

#### Summary

TypeBinding objects are used to bind a property to a Revit type, such as a wall type.

#### Remarks

This differs from Instance bindings in that the property is then shared by all
instances that use that type. Changing the parameter for one type affects all other
instances that use that type.

### `M:Autodesk.Revit.DB.InstanceBinding.#ctor(Autodesk.Revit.DB.CategorySet)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InstanceBinding.#ctor(Autodesk.Revit.DB.CategorySet)`

#### Summary

Constructs an instance binding with the set of categories passed.

#### Remarks

Categories can be set or changed at a later time by using the Categories property of this object.

### `M:Autodesk.Revit.DB.InstanceBinding.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.InstanceBinding.#ctor`

#### Summary

Constructs an empty instance binding.

#### Remarks

Categories can be set a later time by using the Categories property of this object.

### `T:Autodesk.Revit.DB.InstanceBinding`

Member kind: type
Symbol: `Autodesk.Revit.DB.InstanceBinding`

#### Summary

The InstanceBinding object is used to signify a binding between a parameter
definition and a parameter on each instance of an element, such as a wall.

#### Remarks

Once bound the parameter will appear on all instance of the element and changing
the parameter on any one single instance will not change the value on any other instance.

### `P:Autodesk.Revit.DB.ElementBinding.Categories`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementBinding.Categories`

#### Summary

Retrieve or set the categories to which a parameter definition will be bound.

#### Remarks

The Categories property is used to set the categories to which the definition will
be bound when it is added to the document bindings. This property can also be read from existing
bindings to interrogate to which categories a parameter has been bound.

### `T:Autodesk.Revit.DB.ElementBinding`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementBinding`

#### Summary

A base class for all types of binding that attach to an element.

#### Remarks

This base class provides methods that are common to all types of binding that
work with elements.

### `M:Autodesk.Revit.DB.ExternalDefinitionCreationOptions.SetDataType(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalDefinitionCreationOptions.SetDataType(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Sets the parameter's data type.

#### Parameter `dataType`

The identifier of either a spec or a category.
A category identifier indicates a Family Type parameter of that category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given identifier is neither a spec nor a category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalDefinitionCreationOptions.GetDataType`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalDefinitionCreationOptions.GetDataType`

#### Summary

Gets the identifier describing the parameter's data type.
The identifier may belong to either a spec or a category.
If it is a category, the parameter is a Family Type parameter of that
category.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalDefinitionCreationOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinitionCreationOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExternalDefinitionCreationOptions.HideWhenNoValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinitionCreationOptions.HideWhenNoValue`

#### Summary

This property indicates whether this parameter should be hidden from the properties palette
when it doesn't have a value.

#### Value

True if the parameter should be hidden when it has no value, False if the parameter should
remain visible in the properties palette even when it doesn't have a value.
The default is false

#### Since

2020

### `P:Autodesk.Revit.DB.ExternalDefinitionCreationOptions.UserModifiable`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinitionCreationOptions.UserModifiable`

#### Summary

This property indicates whether this parameter can be modified by UI user or not.

#### Value

True if the parameter will be modifiable by the user in the user interface, false if the parameter will display as read-only.
The default is true.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalDefinitionCreationOptions.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinitionCreationOptions.Description`

#### Summary

The description of the parameter definition to be created. The description will be used as tooltip in the
Revit UI including in the properties palette.
The default is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalDefinitionCreationOptions.GUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinitionCreationOptions.GUID`

#### Summary

The GUID to use for this parameter definition.
If not explicitly set, a random GUID is used.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalDefinitionCreationOptions.Visible`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinitionCreationOptions.Visible`

#### Summary

True if the parameter is visible to the user, false if it is hidden and accessible only via the API.
The default is true.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalDefinitionCreationOptions.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinitionCreationOptions.Name`

#### Summary

The name of the parameter definition to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalDefinitionCreationOptions.#ctor(System.String,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalDefinitionCreationOptions.#ctor(System.String,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Constructs the options using a specified name and type.

#### Parameter `name`

The name of the parameter definition to be created.

#### Parameter `dataType`

The identifier of either a spec or a category.
A category identifier indicates a Family Type parameter of that category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given identifier is neither a spec nor a category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.ExternalDefinitionCreationOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalDefinitionCreationOptions`

#### Summary

An option class used for creating a new shared parameter definition, including options such as name, type, visibility,
Guid description and modifiable flag.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalDefinition.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinition.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExternalDefinition.HideWhenNoValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinition.HideWhenNoValue`

#### Summary

Indicates whether this parameter should be hidden from the properties palette when it has no value.

#### Remarks

Even when hidden, the parameter can still be accessed directly via the API.

#### Value

If true, the parameter will be hidden from the properties palette when it has no value.
If false, the parameter will always be shown in the properties palette, no matter if it has a value
or not.

#### Since

2020

### `P:Autodesk.Revit.DB.ExternalDefinition.UserModifiable`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinition.UserModifiable`

#### Summary

Indicates whether the parameter can be modified by the user interface.

#### Remarks

If true, the user can edit the value of this parameter. If false, the user cannot edit this value
(it will appear grayed out). However, any API application can modify the value of this parameter.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalDefinition.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinition.Description`

#### Summary

The description of the parameter. The description will be used as tooltip in the Revit UI including in the properties palette.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalDefinition.OwnerGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinition.OwnerGroup`

#### Summary

Returns or change the group ID of the external parameter definition.

#### Remarks

If failed When set the group, an InvalidOperationException will be thrown.

### `P:Autodesk.Revit.DB.ExternalDefinition.ParameterGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinition.ParameterGroup`

#### Summary

Returns the group ID of the parameter definition.

### `M:Autodesk.Revit.DB.ExternalDefinition.GetGroupTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalDefinition.GetGroupTypeId`

#### Summary

Returns the identifier of the parameter definition's parameter group.

### `P:Autodesk.Revit.DB.ExternalDefinition.Visible`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinition.Visible`

#### Summary

Indicates if the parameter is visible in the Autodesk Revit user interface.

#### Remarks

The visible property controls whether a shared parameter is hidden from the user. This
is useful if you wish to add data to an element that is only meaningful to your application and
not to the user. This value can only be set when the shared parameter definition is created.

### `P:Autodesk.Revit.DB.ExternalDefinition.GUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinition.GUID`

#### Summary

Returns the GUID associated with the shared parameter definition.

#### Remarks

Each shared parameter when created is issued a unique identifier. This identifier can then
be used at a later time to retrieve the parameter from the Element ensuring that the correct
parameter is always retrieved.

### `P:Autodesk.Revit.DB.ExternalDefinition.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalDefinition.Name`

#### Summary

The user visible name for the parameter.

### `T:Autodesk.Revit.DB.ExternalDefinition`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalDefinition`

#### Summary

The ExternalDefinition object adds properties specific to Autodesk Revit shared parameter definitions.

#### Remarks

The ExternalDefinition object can be created by a definition Group object from a shared parameters file.
External parameter definition must belong to a Group which is nothing more than a collection of shared
parameter definitions. The following process should be followed to add a parameter to an
element: Open the shared parameters file, via the Application.OpenSharedParameterFile() method.
Access an existing or create a new group, via the DefinitionFile.Groups property. Access
an existing or create a new external parameter definition, via the
DefinitionGroup.Definitions property. Create a new Binding object with the categories to
which the parameter will be bound using an InstanceBinding or a TypeBinding object. Finally
add the binding and definition to the document using the Document.ParameterBindings object.

Shared parameters added to elements are typically visible to interactive users. To add data to elements that
is never visible to interactive users, use Extensible Storage to construct and populate the needed structured
data.

### `M:Autodesk.Revit.DB.Categories.NewSubcategory(Autodesk.Revit.DB.Category,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Categories.NewSubcategory(Autodesk.Revit.DB.Category,System.String)`

#### Summary

Add a new subcategory into the Autodesk Revit document.

#### Returns

If successful, the newly created subcategory.

#### Parameter `parentCategory`

The parent category.

#### Parameter `name`

The new category name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"parentCategory" or "name"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"parentCategory"-cannot add subcategory.
Thrown when the input argument-"name"-is an illegal name.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when subcategory creation failed.

### `M:Autodesk.Revit.DB.Categories.Insert(System.String,Autodesk.Revit.DB.Category)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Categories.Insert(System.String,Autodesk.Revit.DB.Category)`

#### Summary

Inserts the specified category with the specified name into the map.

#### Parameter `key`

The name to be used for inserting the category into the map.

#### Parameter `item`

The category to be inserted into the map.

#### Returns

Whether or not the category was inserted into the map.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Always thrown; this list is read only.

### `M:Autodesk.Revit.DB.Categories.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Categories.ReverseIterator`

#### Summary

Retrieves a backward moving iterator to the map.

#### Returns

A backward moving iterator to the map.

### `M:Autodesk.Revit.DB.Categories.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Categories.GetEnumerator`

#### Summary

Retrieves a forward moving iterator to the map.

#### Returns

A forward moving iterator to the map.

### `M:Autodesk.Revit.DB.Categories.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Categories.ForwardIterator`

#### Summary

Retrieves a forward moving iterator to the map.

#### Returns

A forward moving iterator to the map.

### `P:Autodesk.Revit.DB.Categories.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Categories.IsEmpty`

#### Summary

Whether or not the list of top-level categories is empty.

### `P:Autodesk.Revit.DB.Categories.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Categories.Size`

#### Summary

The total number of top-level categories in the document.

### `P:Autodesk.Revit.DB.Categories.Item(System.String)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Categories.Item(System.String)`

#### Summary

Gets a category which has the specified name from this list of top-level categories.

#### Parameter `name`

The name of the category to be retrieved.

#### Value

The category with the specified name.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the category list does not contain the category with this name.
Thrown when trying to set an item to this list of categories; this list is read only.

### `M:Autodesk.Revit.DB.Categories.Contains(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Categories.Contains(System.String)`

#### Summary

Identifies if a category which has the specified name is in the list of top-level categories.

#### Parameter `name`

The name of the category to be retrieved.

#### Value

Whether the category exists in the list of top-level categories.

### `P:Autodesk.Revit.DB.Categories.Item(Autodesk.Revit.DB.BuiltInCategory)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Categories.Item(Autodesk.Revit.DB.BuiltInCategory)`

#### Overloads

Retrieves a category object matching an identifier.

#### Summary

Retrieves a category object corresponding to a BuiltInCategory id.

#### Remarks

Unlike the method that obtains categories by name, this routine will obtain
the handle even of built-in subcategories.
Since 2016 it is advised to use either `!:​Autodesk::​Revit::DB::​Category::​GetCategory(​Document,​BuiltIn​Category)`
or `!:​Autodesk::​Revit::DB::​Category::​GetCategory(​Document,​ElementId)` ​ method from Category class.

### `T:Autodesk.Revit.DB.Categories`

Member kind: type
Symbol: `Autodesk.Revit.DB.Categories`

#### Summary

The Categories object is a map that contains all the top-level Category objects within the Document.

#### Remarks

Use this object to retrieve categories by name or by BuiltInCategory id.

### `M:Autodesk.Revit.DB.BindingMap.Erase(Autodesk.Revit.DB.Definition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BindingMap.Erase(Autodesk.Revit.DB.Definition)`

#### Summary

This method is used to erase one item in the map.

#### Remarks

The method Erase inherited from base class is not permitted for this class.
A Autodesk::Revit::Exceptions::InvalidOperationException will be thrown. Use Remove() instead to remove the binding
from the Revit session and from the map.

### `M:Autodesk.Revit.DB.BindingMap.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.BindingMap.Clear`

#### Summary

This method is used to remove all the items in the map.

#### Remarks

The method Clear inherited from base class is not permitted for this class.
A Autodesk::Revit::Exceptions::InvalidOperationException will be thrown.

### `P:Autodesk.Revit.DB.BindingMap.Item(Autodesk.Revit.DB.Definition)`

Member kind: property
Symbol: `Autodesk.Revit.DB.BindingMap.Item(Autodesk.Revit.DB.Definition)`

#### Summary

The get_Item method will get the binding item related to the input key.

#### Parameter `key`

A parameter definition which can be an existing definition or one from a shared parameters file.

#### Value

The returned value of get_Item is an InstanceBinding or TypeBinding object
that contains the set of categories to which the parameter is bound.
The input item is an InstanceBinding or TypeBinding object which contains the set of categories
to which the parameter should be bound.

#### Remarks

set_Item is not permitted for this class. A Autodesk::Revit::Exceptions::InvalidOperationException will be thrown.
Instead use Insert, Remove and ReInsert to modify the bindings in the document.

### `M:Autodesk.Revit.DB.BindingMap.Contains(Autodesk.Revit.DB.Definition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BindingMap.Contains(Autodesk.Revit.DB.Definition)`

#### Summary

The Contains method is used to check if the parameter binding exists for one definition.

#### Parameter `key`

A parameter definition which can be an existing definition or one from a shared parameters file.

### `M:Autodesk.Revit.DB.BindingMap.Remove(Autodesk.Revit.DB.Definition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BindingMap.Remove(Autodesk.Revit.DB.Definition)`

#### Summary

The Remove method is used to remove a parameter binding.

#### Parameter `key`

A parameter definition which can be an existing definition or one from a shared parameters file.

### `M:Autodesk.Revit.DB.BindingMap.ReInsert(Autodesk.Revit.DB.Definition,Autodesk.Revit.DB.Binding,Autodesk.Revit.DB.BuiltInParameterGroup)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BindingMap.ReInsert(Autodesk.Revit.DB.Definition,Autodesk.Revit.DB.Binding,Autodesk.Revit.DB.BuiltInParameterGroup)`

#### Summary

Removes an existing parameter and creates a new binding for a given parameter in a specified group.

#### Parameter `key`

A parameter definition which can be an existing definition or one from a shared parameters file.

#### Parameter `item`

An InstanceBinding or TypeBinding object which contains the set of categories to which the parameter should be bound.

#### Parameter `parameterGroup`

The GroupID of the parameter definition, or INVALID if the parameter is not to be associated with any predefined group.

#### Remarks

Note the type of the binding object dictates whether the parameter is bound to all
instances or just types. A parameter definition cannot be bound to both instances and types.
If the parameter binding already exists, remove the binding, create a new parameter binding.
If the parameter binding related to the input key doesn't exist in the database,
ReInsert will fail and false will be returned. In this case, Insert should be called.

### `M:Autodesk.Revit.DB.BindingMap.ReInsert(Autodesk.Revit.DB.Definition,Autodesk.Revit.DB.Binding,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BindingMap.ReInsert(Autodesk.Revit.DB.Definition,Autodesk.Revit.DB.Binding,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Removes an existing parameter and creates a new binding for a given parameter in a specified group.

#### Parameter `key`

A parameter definition which can be an existing definition or one from a shared parameters file.

#### Parameter `item`

An InstanceBinding or TypeBinding object which contains the set of categories to which the parameter should be bound.

#### Parameter `groupTypeId`

The identifier of the parameter definition's parameter group, or empty if the parameter is not to be associated with any predefined group.

#### Remarks

Note the type of the binding object dictates whether the parameter is bound to all
instances or just types. A parameter definition cannot be bound to both instances and types.
If the parameter binding already exists, remove the binding, create a new parameter binding.
If the parameter binding related to the input key doesn't exist in the database,
ReInsert will fail and false will be returned. In this case, Insert should be called.

### `M:Autodesk.Revit.DB.BindingMap.ReInsert(Autodesk.Revit.DB.Definition,Autodesk.Revit.DB.Binding)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BindingMap.ReInsert(Autodesk.Revit.DB.Definition,Autodesk.Revit.DB.Binding)`

#### Overloads

Removes an existing parameter and creates a new binding for a given parameter.

#### Summary

Removes an existing parameter and creates a new binding for a given parameter.

#### Parameter `key`

A parameter definition which can be an existing definition or one from a shared parameters file.

#### Parameter `item`

An InstanceBinding or TypeBinding object which contains the set of categories to which the parameter should be bound.

#### Remarks

Note the type of the binding object dictates whether the parameter is bound to all
instances or just types. A parameter definition cannot be bound to both instances and types.
If the parameter binding already exists, remove the binding, create a new parameter binding.

### `M:Autodesk.Revit.DB.BindingMap.Insert(Autodesk.Revit.DB.Definition,Autodesk.Revit.DB.Binding,Autodesk.Revit.DB.BuiltInParameterGroup)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BindingMap.Insert(Autodesk.Revit.DB.Definition,Autodesk.Revit.DB.Binding,Autodesk.Revit.DB.BuiltInParameterGroup)`

#### Summary

Creates a new parameter binding between a parameter and a set of categories in a specified group.

#### Parameter `key`

A parameter definition which can be an existing definition or one from a shared parameters file.

#### Parameter `item`

An InstanceBinding or TypeBinding object which contains the set of categories to which the parameter should be bound.

#### Parameter `parameterGroup`

The GroupID of the parameter definition, or INVALID if the parameter is not to be associated with any predefined group.

#### Remarks

Note the type of the binding object dictates whether the parameter is bound to all
instances or just types. A parameter definition cannot be bound to both instances and types.
If the Parameter binding already exists, post an error and return false

### `M:Autodesk.Revit.DB.BindingMap.Insert(Autodesk.Revit.DB.Definition,Autodesk.Revit.DB.Binding,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BindingMap.Insert(Autodesk.Revit.DB.Definition,Autodesk.Revit.DB.Binding,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Creates a new parameter binding between a parameter and a set of categories in a specified group.

#### Parameter `key`

A parameter definition which can be an existing definition or one from a shared parameters file.

#### Parameter `item`

An InstanceBinding or TypeBinding object which contains the set of categories to which the parameter should be bound.

#### Parameter `groupTypeId`

The identifier of the parameter definition's parameter group, or empty if the parameter is not to be associated with any predefined group.

#### Remarks

Note the type of the binding object dictates whether the parameter is bound to all
instances or just types. A parameter definition cannot be bound to both instances and types.
If the Parameter binding already exists, post an error and return false

### `M:Autodesk.Revit.DB.BindingMap.Insert(Autodesk.Revit.DB.Definition,Autodesk.Revit.DB.Binding)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BindingMap.Insert(Autodesk.Revit.DB.Definition,Autodesk.Revit.DB.Binding)`

#### Overloads

Creates a new parameter binding.

#### Summary

Creates a new parameter binding between a parameter and a set of categories.

#### Parameter `key`

A parameter definition which can be an existing definition or one from a shared parameters file.

#### Parameter `item`

An InstanceBinding or TypeBinding object which contains the set of categories to which the parameter should be bound.

#### Remarks

Note the type of the binding object dictates whether the parameter is bound to all
instances or just types. A parameter definition cannot be bound to both instances and types.
If the parameter binding already exists, post an error and return false.

### `T:Autodesk.Revit.DB.BindingMap`

Member kind: type
Symbol: `Autodesk.Revit.DB.BindingMap`

#### Summary

The parameters BindingMap contains all the parameter bindings that exist in the
Autodesk Revit project.

#### Remarks

The ParameterBindingsMap is available from the Document.ParameterBindings property. A
parameter binding is the way that a parameter definition is bound to elements within one
or more categories. This map can be used to interrogate existing bindings, but it can also
be used to generate new parameter bindings by using the Insert method.

### `M:Autodesk.Revit.DB.InternalDefinition.SetAllowVaryBetweenGroups(Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InternalDefinition.SetAllowVaryBetweenGroups(Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

Whether or not the parameter values can vary across group members.

#### Remarks

When a parameter is set to not vary between groups Revit will automatically align the parameter values
of any elements that actually varied between group instances.

#### Parameter `document`

The document of this parameter.

#### Parameter `allowVaryBetweenGroups`

Whether this parameter should be allowed to vary between groups.

#### Returns

The ids of elements that were updated to align the values between groups.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This parameter does not support the specified value of allowVaryBetweenGroups.
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

2014

### `M:Autodesk.Revit.DB.InternalDefinition.GetTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.InternalDefinition.GetTypeId`

#### Summary

Gets the identifier of the parameter.

### `P:Autodesk.Revit.DB.InternalDefinition.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.InternalDefinition.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.InternalDefinition.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.InternalDefinition.Id`

#### Summary

The id of the parameter.

#### Since

2017

### `P:Autodesk.Revit.DB.InternalDefinition.VariesAcrossGroups`

Member kind: property
Symbol: `Autodesk.Revit.DB.InternalDefinition.VariesAcrossGroups`

#### Summary

Whether or not the parameter values can vary across group members.

#### Value

True if the values of this parameter can vary across the related members of group instances. False
if the values will be consistent across the related members in group instances.

#### Since

2014

### `P:Autodesk.Revit.DB.InternalDefinition.Visible`

Member kind: property
Symbol: `Autodesk.Revit.DB.InternalDefinition.Visible`

#### Summary

Indicates if the parameter is visible in the Autodesk Revit user interface.

#### Remarks

The visible property controls whether a shared parameter is hidden from the user. This
is useful if you wish to add data to an element that is only meaningful to your application and
not to the user. This value can only be set when the shared parameter definition is created.

### `P:Autodesk.Revit.DB.InternalDefinition.BuiltInParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.InternalDefinition.BuiltInParameter`

#### Summary

Tests whether this definition identifies a built-in parameter or not.

#### Remarks

For a build-in parameter this property equals one of the BuiltInParameter enumerated values.
For custom-defined parameters, such as shared, global, or family parameters the value is always BuiltInParameter.INVALID.

### `M:Autodesk.Revit.DB.InternalDefinition.GetParameterTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.InternalDefinition.GetParameterTypeId`

#### Summary

Tests whether this definition identifies a built-in parameter or not.

#### Remarks

For a built-in parameter this method returns one of the ParameterTypeId static properties.
For custom-defined parameters, such as shared, global, or family parameters the value is null.

### `P:Autodesk.Revit.DB.InternalDefinition.ParameterGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.InternalDefinition.ParameterGroup`

#### Summary

Id of a built-in parameter group to which the parameter defined by this definition belongs.

#### Remarks

The parameter group can be changed, but only for parameters that are not built in.
In other words: Modifying the value of this property is only valid for parameter definitions
whose BuiltInParameter property returns BuiltInParameter.INVALID, e.g. Global Parameters.

### `M:Autodesk.Revit.DB.InternalDefinition.SetGroupTypeId(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.InternalDefinition.SetGroupTypeId(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Sets the built-in parameter group to which the parameter defined by this definition belongs.

#### Remarks

The parameter group can be changed, but only for parameters that are not built in.
In other words: This method is only valid for parameter definitions for which
GetParameterTypeId() returns a null identifier.

#### Parameter `groupTypeId`

Identifier of the built-in parameter group.

### `M:Autodesk.Revit.DB.InternalDefinition.GetGroupTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.InternalDefinition.GetGroupTypeId`

#### Summary

Gets the identifier of the built-in parameter group to which the parameter defined by this definition belongs.

### `P:Autodesk.Revit.DB.InternalDefinition.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.InternalDefinition.Name`

#### Summary

The user-visible name for the parameter.

### `T:Autodesk.Revit.DB.InternalDefinition`

Member kind: type
Symbol: `Autodesk.Revit.DB.InternalDefinition`

#### Summary

This object represents a parameter definition in an Autodesk Revit model.

### `T:ModelIdentity`

Member kind: type
Symbol: `ModelIdentity`

#### Summary

Model Identity with GUID

### `M:ObjectFactoryUtils.#ctor`

Member kind: method
Symbol: `ObjectFactoryUtils.#ctor`

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never
be created by the developer.

### `T:ObjectFactoryUtils`

Member kind: type
Symbol: `ObjectFactoryUtils`

#### Summary

Provides access to the ImportInstance in Autodesk Revit.

#### Remarks

The Import Instance object can be generated by Import operation.

### `E:Autodesk.Revit.ApplicationServices.Application.ProjectBrowserDataChanged`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ProjectBrowserDataChanged`

#### Summary

Subscribe to the ProjectBrowserDataChanged event to be notified when the ProjectBrowser data is changed.

#### Since

2024

### `E:Autodesk.Revit.ApplicationServices.Application.ExternalDataTypeServerFailureResolutionExecuting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ExternalDataTypeServerFailureResolutionExecuting`

#### Summary

Subscribe to the ExternalDataTypeServerFailureResolutionExecuting event to be notified when the ExternalDataTypeServerFailureResolution is executing in Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.Application.ExternalDataInstanceRemovedFromDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ExternalDataInstanceRemovedFromDocument`

#### Summary

Subscribe to the ExternalDataInstanceRemovedFromDocument event to be notified when an ExternalDataInstance has been removed from Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.Application.ExternalDataInstanceRemovingFromDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ExternalDataInstanceRemovingFromDocument`

#### Summary

Subscribe to the ExternalDataInstanceRemovingFromDocument event to be notified when an ExternalDataInstance is being removed from Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.Application.ExternalDataInstanceAddedIntoDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ExternalDataInstanceAddedIntoDocument`

#### Summary

Subscribe to the ExternalDataInstanceAddedIntoDocument event to be notified when a new ExternalDataInstance has been added to Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.Application.ExternalDataInstanceAddingIntoDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ExternalDataInstanceAddingIntoDocument`

#### Summary

Subscribe to the ExternalDataInstanceAddingIntoDocument event to be notified when a new ExternalDataInstance is being added to Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentReloadedLatest`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentReloadedLatest`

#### Summary

Subscribe to the DocumentReloadedLatestEventArgs event to be notified immediately after Revit has finished reloading a document with central model.

#### Remarks

This event is raised immediately after Revit has finished reloading latest changes from a central model.
It is raised even when document reloading latest changes from a central model failed or was cancelled (during DocumentReloadingLatest event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of reloading latest changes from a central model has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2021

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentReloadingLatest`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentReloadingLatest`

#### Summary

Subscribe to the DocumentReloadingLatestEventArgs event to be notified when Revit is just about to reload latest changes from a central model.

#### Remarks

This event is raised when Revit is just about to reload latest changes from a central model.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.DocumentReloadingLatest` event will be raised immediately after latest changes reloading from a central model
is finished.

#### Since

2021
