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
Shard: 41
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `P:Autodesk.Revit.DB.Visual.Hardwood.HardwoodImperfections`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Hardwood.HardwoodImperfections`

#### Summary

The property labeled "Relief Pattern" from the "Hardwood" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "HardwoodImperfectionsType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Hardwood.HardwoodApplication`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Hardwood.HardwoodApplication`

#### Summary

The property labeled "Used For" from the "Hardwood" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "HardwoodApplicationType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Hardwood.HardwoodFinish`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Hardwood.HardwoodFinish`

#### Summary

The property labeled "Finish" from the "Hardwood" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "HardwoodFinishType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Hardwood.HardwoodTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Hardwood.HardwoodTintColor`

#### Summary

The property labeled "Stain Color" from the "Hardwood" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Hardwood.HardwoodTintEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Hardwood.HardwoodTintEnabled`

#### Summary

The property labeled "Stain" from the "Hardwood" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "HardwoodTintEnabledType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Hardwood.HardwoodColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Hardwood.HardwoodColor`

#### Summary

The property labeled "Image" from the "Hardwood" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Hardwood`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Hardwood`

#### Summary

A static class that provides access to the property names that appear in the Hardwood visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.IsValidTime(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.IsValidTime(System.String)`

#### Summary

Check if the string can be parsed to a valid time for opening time and closing time. A valid string can be "16:30" or "4:30 PM";

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.IsNameUnique(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.IsNameUnique(System.String)`

#### Summary

Determines whether a potential building type name is unique.

#### Parameter `name`

The candidate name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.IsNameUnique(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.IsNameUnique(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Determines whether a potential building type name is unique.

#### Parameter `document`

The document.

#### Parameter `name`

The candidate name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a building type element.

#### Parameter `document`

The document.

#### Parameter `name`

The building type name.

#### Returns

The new building type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string or contains only whitespace.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
The given value for name is already in use as a building type name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.UnoccupiedCoolingSetPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.UnoccupiedCoolingSetPoint`

#### Summary

The unoccupied cooling set point of the building type with unit kelvin (K).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The value should be between (273.15, 373.15] with unit kelvin (K).

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.ClosingTime`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.ClosingTime`

#### Summary

The closing time of the building type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: It is not a valid time, can be something like "16:30" or "4:30 PM".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.OpeningTime`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.OpeningTime`

#### Summary

The opening time of the building type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: It is not a valid time, can be something like "16:30" or "4:30 PM".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.BuildingTypeName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadBuildingType.BuildingTypeName`

#### Summary

The building type name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: name is an empty string or contains only whitespace.
-or-
When setting this property: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
When setting this property: The given value for name is already in use as a building type name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2018

### `T:Autodesk.Revit.DB.Analysis.HVACLoadBuildingType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadBuildingType`

#### Summary

The type element of building.

#### Since

2018

### `M:Autodesk.Revit.DB.Analysis.HVACLoadSpaceType.IsNameUnique(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadSpaceType.IsNameUnique(System.String)`

#### Summary

Determines whether a potential space type name is unique.

#### Parameter `name`

The candidate name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Analysis.HVACLoadSpaceType.IsNameUnique(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadSpaceType.IsNameUnique(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Determines whether a potential space type name is unique.

#### Parameter `document`

The document.

#### Parameter `name`

The candidate name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Analysis.HVACLoadSpaceType.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadSpaceType.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a space type.

#### Parameter `document`

The document.

#### Parameter `name`

The space type name.

#### Returns

The new space type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string or contains only whitespace.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
The given value for name is already in use as a space type name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadSpaceType.SpaceTypeName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadSpaceType.SpaceTypeName`

#### Summary

The space type name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: name is an empty string or contains only whitespace.
-or-
When setting this property: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
When setting this property: The given value for name is already in use as a space type name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadSpaceType.IsPlenum`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadSpaceType.IsPlenum`

#### Summary

True if the space type is plenum.

#### Since

2018

### `T:Autodesk.Revit.DB.Analysis.HVACLoadSpaceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadSpaceType`

#### Summary

The type element of space.

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.DehumidificationSetPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.DehumidificationSetPoint`

#### Summary

The dehumidification set point as a number between 0 and 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property:

#### Since

2021.1

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.HumidificationSetPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.HumidificationSetPoint`

#### Summary

The humidification set point as a number between 0 and 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property:

#### Since

2021.1

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.CoolingSetPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.CoolingSetPoint`

#### Summary

The cooling temperature set point in unit Kelvin (K).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property:

#### Since

2021.1

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.HeatingSetPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.HeatingSetPoint`

#### Summary

The heating temperature set point in unit Kelvin (K).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property:

#### Since

2021.1

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.OutdoorAirFlowStandard`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.OutdoorAirFlowStandard`

#### Summary

The outdoor airflow standard.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.AirChangesPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.AirChangesPerHour`

#### Summary

The air changes per hour.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The value should be between [0.0,10000].

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.OutdoorAirPerArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.OutdoorAirPerArea`

#### Summary

The outdoor air per area.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The value should be between [0.0,166.66].

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.OutdoorAirPerPerson`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.OutdoorAirPerPerson`

#### Summary

The outdoor air per person.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The value should be between [0.0,166.66].

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.PlenumLighting`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.PlenumLighting`

#### Summary

The percentage of plenum lighting contribution.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The value should be between [0.0,1.0].

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.PowerLoadDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.PowerLoadDensity`

#### Summary

The power load density.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The value should be between [0.0,500000.0].

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.LightingLoadDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.LightingLoadDensity`

#### Summary

The lighting load density.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The value should be between [0.0,500000.0].

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.LatentHeatGainPerPerson`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.LatentHeatGainPerPerson`

#### Summary

The latent heat gain per person.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The value should be between [0.0,5381.9].

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.SensibleHeatGainPerPerson`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.SensibleHeatGainPerPerson`

#### Summary

The sensible heat gain per person.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The value should be between [0.0,5381.9].

#### Since

2018

### `P:Autodesk.Revit.DB.Analysis.HVACLoadType.AreaPerPerson`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType.AreaPerPerson`

#### Summary

The area per person.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for value must be non-negative.

#### Since

2018

### `T:Autodesk.Revit.DB.Analysis.HVACLoadType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadType`

#### Summary

The base class for building type and space type.

#### Since

2018

### `T:Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard`

#### Summary

An enumerated type listing all the possible outdoor airflow standard for a space type.

#### Since

2018

### `F:Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard.MaxByACH_ByArea_ByPeople`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard.MaxByACH_ByArea_ByPeople`

#### Summary

Maximum(by ACH, by area, by people).

### `F:Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard.MaxByACH_ByPeopleByArea`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard.MaxByACH_ByPeopleByArea`

#### Summary

Maximum(by ACH, by people and by area).

### `F:Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard.MaxByPeople_ByArea`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard.MaxByPeople_ByArea`

#### Summary

Maximum(by people, by area).

### `F:Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard.ByACH`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard.ByACH`

#### Summary

By ACH.

### `F:Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard.ByPeopleAndByArea`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard.ByPeopleAndByArea`

#### Summary

By people and by area.

### `M:Autodesk.Revit.DB.PointCloudType.GetPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointCloudType.GetPath`

#### Summary

Gets the path of the link source from which the points are loaded.

#### Returns

Returns the file path for a file based point cloud or null for the non-file based point cloud.

#### Since

2016

### `M:Autodesk.Revit.DB.PointCloudType.Create(Autodesk.Revit.DB.Document,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointCloudType.Create(Autodesk.Revit.DB.Document,System.String,System.String)`

#### Summary

Creates a new point cloud type for a given point cloud engine.

#### Remarks

A list of supported engine identifiers and whether they are file-based or not can be
obtained from PointCloudEngineRegistry. The method GetSupportedEngines() returns a list
of the identifiers registered for engines.

#### Parameter `document`

The document in which to create the point cloud.

#### Parameter `engineIdentifier`

The string identifying the engine to be invoked.
It should be the file extension or engine identifier registered by the third party.

#### Parameter `typeIdentifier`

The file name or the identification string for a non-file based engine.

#### Returns

The newly created PointCloudType object to be used to create instances of
this point cloud.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The engine identifier was not found in the Revit session.
-or-
document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

The external file could not be found or loaded.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Unable to create a point cloud from the third party engine.

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

### `P:Autodesk.Revit.DB.PointCloudType.FoundStatus`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointCloudType.FoundStatus`

#### Summary

Shows whether the Point Cloud external file could be found.

#### Since

2012

### `P:Autodesk.Revit.DB.PointCloudType.ColorEncoding`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointCloudType.ColorEncoding`

#### Summary

The color encoding used by points extracted from instances of this point cloud.

#### Since

2012

### `P:Autodesk.Revit.DB.PointCloudType.Offset`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointCloudType.Offset`

#### Summary

Returns the offset stored in the point cloud.

#### Remarks

All points are assumed to be offset by the same offset vector.
The offset will be used by Revit if the user chooses to place an instance
relative to another point cloud (the "Auto - Origin To Last Placed" placement option).

#### Since

2012

### `P:Autodesk.Revit.DB.PointCloudType.Scale`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointCloudType.Scale`

#### Summary

The multiplier applied to the points in all instances of this point cloud.

#### Remarks

Scale converts the units in which the coordinates of individual points
of the point cloud are interpreted.

#### Since

2012

### `P:Autodesk.Revit.DB.PointCloudType.EngineIdentifier`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointCloudType.EngineIdentifier`

#### Summary

The identifier of the engine responsible for handling of the point cloud.

#### Remarks

The built-in engine provides "rcs" and "rcp" here.

#### Since

2012

### `M:Autodesk.Revit.DB.PointCloudType.GetReCapProject`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointCloudType.GetReCapProject`

#### Summary

This method provides a direct entry point to get access to an object from the ReCap SDK (ReCapWrapper.RCProject) from Revit. This object represents the point cloud from the RC file path stored in PointCloudType. The ReCap assembly AdskRcManaged.dll will need to be included into code using this method.

#### Remarks

The coordinate system in RCProject is defined by Point Cloud. Please refer to ReCap SDK document for RCProject::getCoordinateSystem.
If you need points converted to the modeling coordinate system in Revit, you can obtain the transformation matrix from PointCloudInstance `M:Autodesk.Revit.DB.Instance.GetTransform` .

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The file or PointCloudEngine is not ReCap based.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Exception happens when ReCap loading the project.

#### Since

2022

### `T:Autodesk.Revit.DB.PointCloudType`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointCloudType`

#### Summary

Represents a type of point cloud loaded into a Revit document. Each PointCloudType maps to
a single file or identifier (depending upon the type of Point Cloud Engine which governs it).

#### Since

2012

### `T:Autodesk.Revit.DB.PointCloudFoundStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointCloudFoundStatus`

#### Summary

Enumerated type representing the possible states related to searching for a point cloud file.

#### Since

2012

### `F:Autodesk.Revit.DB.PointCloudFoundStatus.FoundOK`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointCloudFoundStatus.FoundOK`

#### Summary

File-based Point Cloud has been located and can be loaded.

### `F:Autodesk.Revit.DB.PointCloudFoundStatus.NotFound`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointCloudFoundStatus.NotFound`

#### Summary

File-based Point Cloud cannot be located and hence can't be loaded.

### `F:Autodesk.Revit.DB.PointCloudFoundStatus.Unknown`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointCloudFoundStatus.Unknown`

#### Summary

Initial state. Loading of the Point Cloud hasn't been attempted.

### `M:Autodesk.Revit.DB.PointClouds.PointCloudEngineRegistry.UnregisterPointCloudEngine(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudEngineRegistry.UnregisterPointCloudEngine(System.String)`

#### Summary

Unregisters the point cloud engine associated to a particular identifier.

#### Parameter `identifier`

The identifier of the engine to be unregistered.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointCloudEngineRegistry.IsEngineFileBased(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudEngineRegistry.IsEngineFileBased(System.String)`

#### Summary

Identifies if a given engine is file-based.

#### Parameter `identifier`

The engine identifier.

#### Returns

True if the engine is file-based, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointCloudEngineRegistry.GetSupportedEngines`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudEngineRegistry.GetSupportedEngines`

#### Summary

Returns a list of the identifiers supported by point cloud engines registered to Revit.

#### Returns

The list of identifiers.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointCloudEngineRegistry.RegisterPointCloudEngine(System.String,Autodesk.Revit.DB.PointClouds.IPointCloudEngine,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudEngineRegistry.RegisterPointCloudEngine(System.String,Autodesk.Revit.DB.PointClouds.IPointCloudEngine,System.Boolean)`

#### Summary

Registers a new point cloud engine and associates it to a particular file extension.

#### Parameter `identifier`

A string that distinguishes the engine being registered. If isFileBased is true,
this should be the file extension (e.g. "rcs" or "rcp"). If isFileBased is false, this
identifier is used only by API calls and should be unique.

#### Parameter `engine`

The point cloud engine that governs point clouds matching the input identifier.

#### Parameter `isFileBased`

Indicates to Revit if a single Point Cloud corresponds to a single file on disk.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The same identifier has already been registered by another engine.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.PointClouds.PointCloudEngineRegistry`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudEngineRegistry`

#### Summary

This class supports registration of custom Point Cloud Engines in a Revit session.

#### Remarks

This class is the start point for engine providers. A custom engine implementation consists of the following:
An implementation of IPointCloudEngine registered to Revit via the PointCloudEngineRegistry.

An implementation of IPointCloudAccess coded to respond to inquiries from Revit regarding the
properties of a single point cloud.

An implementation of IPointSetIterator code to return sets of points to Revit when requested.

Engine implementations may be file-based or non-file-based:
File-based implementations require that
each point cloud be mapped to a single file on disk. Revit will allow users to create new point
cloud instances in a document directly by selecting point cloud files whose extension matches
the engine identifier. These files are treated as external links in Revit and may be reloaded and remapped
when necessary from the Manage Links dialog.

Non-file-based engine implementations may obtain point clouds from anywhere (e.g. from a database,
from a server, or from one part of a larger aggregate file). Because there is no file that the user may select,
Revit's user interface will not allow a user to create a point cloud of this type. The engine provider should supply
a custom command using PointCloudType.Create() and PointCloudInstance.Create() to create and place point clouds of
this type. The Manage Links dialog will show the point clouds of this type, but since there is no file
associated to the point cloud, the user cannot manage, reload or remap point clouds of this type.

Regardless of the type of engine used, the implementation must supply enough information to Revit to
display the contents of the point cloud. There are two ReadPoints methods which must be implemented:
IPointCloudAccess.ReadPoints() - this provides a single set of points in a one-time call from Revit. Revit uses
this during some display activities including selection prehighlighting. It is also possible for API clients
to call this method directly (via PointCloudInstance.GetPoints()).

IPointSetIterator.ReadPoints() - this provides a subset of points as a part of a larger iteration of points
in the cloud. Revit uses this method during normal display of the point cloud; quantities of points will be
requested repeatedly until it obtains enough points or until something in the display changes. The engine
implementation must keep track of which points have been returned to Revit during any given point set iteration.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudEngineProxy.Free`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudEngineProxy.Free`

#### Summary

Revit will call this method when done using the engine.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudEngineProxy.CreatePointCloudAccess(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudEngineProxy.CreatePointCloudAccess(System.String)`

#### Summary

Implement this method to construct the IPointCloudAccess interface for the point cloud designated by
the identifier. This method is called once during the creation of a PointCloudType.

#### Remarks

The instance of the returned IPointCloudAccess is then used by Revit to
display instances of the point cloud in Revit graphics and in the user interface.

#### Parameter `identifier`

An identifier unique to the point cloud. This will be a file name if the
engine was registered as file-based, or an arbitrary identifier if the engine is not file-based.

#### Returns

The object that can be used to create iterators and interrogate the
point cloud for its features.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudEngine.Free`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudEngine.Free`

#### Summary

Revit will call this method when done using the engine.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudEngine.CreatePointCloudAccess(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudEngine.CreatePointCloudAccess(System.String)`

#### Summary

Implement this method to construct the IPointCloudAccess interface for the point cloud designated by
the identifier. This method is called once during the creation of a PointCloudType.

#### Remarks

The instance of the returned IPointCloudAccess is then used by Revit to
display instances of the point cloud in Revit graphics and in the user interface.

#### Parameter `identifier`

An identifier unique to the point cloud. This will be a file name if the
engine was registered as file-based, or an arbitrary identifier if the engine is not file-based.

#### Returns

The object that can be used to create iterators and interrogate the
point cloud for its features.

#### Since

2012

### `T:Autodesk.Revit.DB.PointClouds.IPointCloudEngine`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudEngine`

#### Summary

An interface that controls the behavior of the link from Revit to a custom Point Cloud Engine.

#### Remarks

An instance of this interface should be created by the engine provider
and registered with the PointCloudEnginesRegistry. The engine may associated
with a particular file name extension during registration (for example,
Revit supplies a built-in engine for working with files with the extension "rcs" or "rcp").
Alternatively, the engine may be associated with an identifier which is not expected
to the be the extension of a particular file.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.Free`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.Free`

#### Summary

Completes the lifetime of the object providing this interface.

#### Remarks

Calling this function indicates that the IPointCloudAccess interface is not going to be used
after the call returns, and the provider of the interface can dispose of all allocated resources.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.GetColorEncoding`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.GetColorEncoding`

#### Summary

Returns the encoding used by points in this point cloud.

#### Returns

The encoding.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.GetName`

#### Summary

Implement this method to return the name of the point cloud that will be used when Revit needs to
refer to the point cloud type, e.g. in the Manage Links dialog or in the
Type Properties dialog.

#### Returns

The name of the point cloud for Revit's user interface.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.GetExtent`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.GetExtent`

#### Summary

Implement this method to returns an object that contains the bounding box of the entire
point cloud, aligned to the point cloud coordinate system.

#### Remarks

The extents should reflect the maximum and minimum coordinates of the stored points, and
not incorporate the offset.

#### Returns

The bounding box of the point cloud.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.GetOffset`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.GetOffset`

#### Summary

Implement this method to return the offset stored in the point cloud.

#### Remarks

All points are assumed to be offset by the same offset vector. The offset should be
expressed in the same units as used by the point coordinates (the scale conversion factor
is not applied). The offset will be used by Revit if the user chooses to place an instance
relative to another point cloud (the "Auto - Origin To Last Placed" placement option).

#### Returns

The offset vector of this point cloud's coordinate system.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.ReadPoints(Autodesk.Revit.DB.PointClouds.PointCloudFilter,Autodesk.Revit.DB.ElementId,System.IntPtr,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.ReadPoints(Autodesk.Revit.DB.PointClouds.PointCloudFilter,Autodesk.Revit.DB.ElementId,System.IntPtr,System.Int32)`

#### Summary

Implement this method so that on successive invocations it will return distinct subsets of
points which meet the criterion.

#### Parameter `rFilter`

The filter used to process cloud points and determine which ones lie with the target volume.

#### Parameter `viewId`

The view id for the current view passed as auxiliary information to allow the
engine to optimize retrieval of points. If viewId == InvalidElementId, the
query is not for a view display operation.

#### Parameter `buffer`

Memory buffer into which the points should be written. The buffer was allocated
by Revit and it is guaranteed to be valid for the duration of the call.

#### Parameter `nBufferSize`

The maximum number of CloudPoint objects that may be copied into the buffer.

#### Returns

The actual number of CloudPoint objects placed in the buffer (can be less than the
length of the buffer). If there are no points available that match the filter criteria, return 0.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.CreatePointSetIterator(Autodesk.Revit.DB.PointClouds.PointCloudFilter,System.Double,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.CreatePointSetIterator(Autodesk.Revit.DB.PointClouds.PointCloudFilter,System.Double,Autodesk.Revit.DB.ElementId)`

#### Summary

Implement this method to return an iterator for iterating over blocks of this point cloud.

#### Parameter `rFilter`

The filter used to process cloud points and determine which ones lie with the target volume.

#### Parameter `density`

Desired number of points per unit area. Area is computed in native units of the point cloud.
Another iterator, created with the same density and a more restrictive
filter, should return a subset of the points returned by this iterator.

#### Parameter `viewId`

The view id for the current view passed as auxiliary information to allow the
engine to optimize retrieval of points. If viewId == InvalidElementId, the
query is not for a view display operation.

#### Returns

The newly created iterator.

#### Since

2013

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.CreatePointSetIterator(Autodesk.Revit.DB.PointClouds.PointCloudFilter,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.CreatePointSetIterator(Autodesk.Revit.DB.PointClouds.PointCloudFilter,Autodesk.Revit.DB.ElementId)`

#### Summary

Implement this method to return an iterator for iterating over blocks of this point cloud.

#### Parameter `rFilter`

The filter used to process cloud points and determine which ones lie with the target volume.

#### Parameter `viewId`

The view id for the current view passed as auxiliary information to allow the
engine to optimize retrieval of points. If viewId == InvalidElementId, the
query is not for a view display operation.

#### Returns

The newly created iterator.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.GetUnitsToFeetConversionFactor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccessProxy.GetUnitsToFeetConversionFactor`

#### Summary

Implement this method to return the conversion factor from the units of the point cloud to feet.

#### Returns

The multiplication factor to convert coordinates of points in this cloud to feet.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccess.Free`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccess.Free`

#### Summary

Completes the lifetime of the object providing this interface.

#### Remarks

Calling this function indicates that the IPointCloudAccess interface is not going to be used
after the call returns, and the provider of the interface can dispose of all allocated resources.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccess.GetColorEncoding`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccess.GetColorEncoding`

#### Summary

Returns the encoding used by points in this point cloud.

#### Returns

The encoding.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccess.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccess.GetName`

#### Summary

Implement this method to return the name of the point cloud that will be used when Revit needs to
refer to the point cloud type, e.g. in the Manage Links dialog or in the
Type Properties dialog.

#### Returns

The name of the point cloud for Revit's user interface.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccess.GetExtent`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccess.GetExtent`

#### Summary

Implement this method to returns an object that contains the bounding box of the entire
point cloud, aligned to the point cloud coordinate system.

#### Remarks

The extents should reflect the maximum and minimum coordinates of the stored points, and
not incorporate the offset.

#### Returns

The bounding box of the point cloud.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccess.GetOffset`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccess.GetOffset`

#### Summary

Implement this method to return the offset stored in the point cloud.

#### Remarks

All points are assumed to be offset by the same offset vector. The offset should be
expressed in the same units as used by the point coordinates (the scale conversion factor
is not applied). The offset will be used by Revit if the user chooses to place an instance
relative to another point cloud (the "Auto - Origin To Last Placed" placement option).

#### Returns

The offset vector of this point cloud's coordinate system.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccess.ReadPoints(Autodesk.Revit.DB.PointClouds.PointCloudFilter,Autodesk.Revit.DB.ElementId,System.IntPtr,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccess.ReadPoints(Autodesk.Revit.DB.PointClouds.PointCloudFilter,Autodesk.Revit.DB.ElementId,System.IntPtr,System.Int32)`

#### Summary

Implement this method so that on successive invocations it will return distinct subsets of
points which meet the criterion.

#### Parameter `rFilter`

The filter used to process cloud points and determine which ones lie with the target volume.

#### Parameter `viewId`

The view id for the current view passed as auxiliary information to allow the
engine to optimize retrieval of points. If viewId == InvalidElementId, the
query is not for a view display operation.

#### Parameter `buffer`

Memory buffer into which the points should be written. The buffer was allocated
by Revit and it is guaranteed to be valid for the duration of the call.

#### Parameter `nBufferSize`

The maximum number of CloudPoint objects that may be copied into the buffer.

#### Returns

The actual number of CloudPoint objects placed in the buffer (can be less than the
length of the buffer). If there are no points available that match the filter criteria, return 0.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccess.CreatePointSetIterator(Autodesk.Revit.DB.PointClouds.PointCloudFilter,System.Double,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccess.CreatePointSetIterator(Autodesk.Revit.DB.PointClouds.PointCloudFilter,System.Double,Autodesk.Revit.DB.ElementId)`

#### Summary

Implement this method to return an iterator for iterating over blocks of this point cloud.

#### Parameter `rFilter`

The filter used to process cloud points and determine which ones lie with the target volume.

#### Parameter `density`

Desired number of points per unit area. Area is computed in native units of the point cloud.
Another iterator, created with the same density and a more restrictive
filter, should return a subset of the points returned by this iterator.

#### Parameter `viewId`

The view id for the current view passed as auxiliary information to allow the
engine to optimize retrieval of points. If viewId == InvalidElementId, the
query is not for a view display operation.

#### Returns

The newly created iterator.

#### Since

2013

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccess.CreatePointSetIterator(Autodesk.Revit.DB.PointClouds.PointCloudFilter,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccess.CreatePointSetIterator(Autodesk.Revit.DB.PointClouds.PointCloudFilter,Autodesk.Revit.DB.ElementId)`

#### Summary

Implement this method to return an iterator for iterating over blocks of this point cloud.

#### Parameter `rFilter`

The filter used to process cloud points and determine which ones lie with the target volume.

#### Parameter `viewId`

The view id for the current view passed as auxiliary information to allow the
engine to optimize retrieval of points. If viewId == InvalidElementId, the
query is not for a view display operation.

#### Returns

The newly created iterator.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointCloudAccess.GetUnitsToFeetConversionFactor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccess.GetUnitsToFeetConversionFactor`

#### Summary

Implement this method to return the conversion factor from the units of the point cloud to feet.

#### Returns

The multiplication factor to convert coordinates of points in this cloud to feet.

#### Since

2012

### `T:Autodesk.Revit.DB.PointClouds.IPointCloudAccess`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.IPointCloudAccess`

#### Summary

An interface that provides functionality for working with an individual
Point Cloud.

#### Remarks

An instance of this interface is obtained from the associated point cloud
engine when the engine's CreatePointCloudAccess method is called.

An instance of this class will be requested by Revit when drawing the point cloud in the view. For performance reasons,
when rendering every frame Revit asks the engine to fetch the necessary points split into multiple batches.
The number of batches requested depends on the view: the smaller the projection of the cloud bounding box on the screen
the fewer batches Revit requests. Revit assumes that each batch contains points uniformly distributed over the visible part of
the cloud ("visible" as defined by the filter). Thus, the points supplied by the engine should not be geometrically distinct (e.g.
divided into multiple independent volumes, because at distant zoom levels Revit will only request a few batches and only part
of the cloud will be displayed.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointSetIteratorProxy.ReadPoints(System.IntPtr,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointSetIteratorProxy.ReadPoints(System.IntPtr,System.Int32)`

#### Summary

Implement this method to fill the provided buffer with points up to the number of maximum points for
which the buffer was allocated.

#### Parameter `buffer`

Memory buffer into which the points should be written. The buffer was allocated
by Revit and it is guaranteed to be valid for the duration of the call.

#### Parameter `bufferSize`

The maximum number of CloudPoint objects that may be copied into the buffer.

#### Returns

The actual number of CloudPoint objects placed in the buffer (can be less than the
length of the buffer). If there are no more points available, return 0.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointSetIteratorProxy.Free`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointSetIteratorProxy.Free`

#### Summary

Use this method to discard any resources consumed by the iterator. Revit will call it when done using the iterator.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointSetIterator.ReadPoints(System.IntPtr,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointSetIterator.ReadPoints(System.IntPtr,System.Int32)`

#### Summary

Implement this method to fill the provided buffer with points up to the number of maximum points for
which the buffer was allocated.

#### Parameter `buffer`

Memory buffer into which the points should be written. The buffer was allocated
by Revit and it is guaranteed to be valid for the duration of the call.

#### Parameter `bufferSize`

The maximum number of CloudPoint objects that may be copied into the buffer.

#### Returns

The actual number of CloudPoint objects placed in the buffer (can be less than the
length of the buffer). If there are no more points available, return 0.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.IPointSetIterator.Free`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.IPointSetIterator.Free`

#### Summary

Use this method to discard any resources consumed by the iterator. Revit will call it when done using the iterator.

#### Since

2012

### `T:Autodesk.Revit.DB.PointClouds.IPointSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.IPointSetIterator`

#### Summary

An interface that Revit will call when iterating through sets of points on the engine.

#### Remarks

An instance of this interface is obtained from the Point Cloud
engine when the engine's CreatePointSetIterator method is called.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointCollection.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCollection.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.PointClouds.PointCollection.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCollection.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.PointClouds.PointCollection.GetPointCollectionIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCollection.GetPointCollectionIterator`

#### Summary

Creates and returns an iterator for the points contained in this collection.

#### Returns

New iterator created, make sure to call 'free' on it when finished using it.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointCollection.GetPointBufferPointer`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCollection.GetPointBufferPointer`

#### Summary

Returns an unsafe pointer to the buffer in which this collection stores the points.

#### Returns

The pointer to the collection's storage.

#### Since

2012

### `P:Autodesk.Revit.DB.PointClouds.PointCollection.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointClouds.PointCollection.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.PointClouds.PointCollection.Count`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointClouds.PointCollection.Count`

#### Summary

The number of points in this collection.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointCollection.GetPointIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCollection.GetPointIterator`

#### Summary

Creates and returns an iterator for the points contained in this collection.

#### Returns

New iterator created, make sure to call 'free' on it when finished using it.

#### Since

2012

### `T:Autodesk.Revit.DB.PointClouds.PointCollection`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.PointCollection`

#### Summary

A class that represents a set of points created and returned by Revit in response to a query.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointIterator.Free`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointIterator.Free`

#### Summary

Completes lifetime of the iterator. Call it when done using the iterator.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointIterator.Reset`

#### Summary

Resets the iterator to the beginning of the collection.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointIterator.IsDone`

#### Summary

Identifies if the iteration has reached the end of the collection.

#### Returns

True if the iteration has reached the end, false otherwise.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointIterator.MoveNext`

#### Summary

Increments the iterator to the next point in the collection.

#### Returns

True if there is another available point in this iterator.
False if the iterator has completed all available points.

#### Since

2012

### `P:Autodesk.Revit.DB.PointClouds.PointIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointClouds.PointIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.PointClouds.PointIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.PointIterator`

#### Summary

A class used to iterate individual points in a PointCollection.

#### Remarks

Points may be iterated in two different ways:
In the traditional IEnumerable interface, you can iterate the resulting points directly from the PointCollection.

In an unsafe interface usable only from C# and C++/CLI, you can get a pointer to the point storage of the collection and access the points directly in memory.
Although you must deal with pointers directly, there may be performance improvements when traversing large buffers of points.
Regardless of the approach used to obtain the points, the points are reported in the coordinate system of the point cloud. If you need the
points in the coordinate system of the model, you will need to transform the point in those coordinates. The most direct way to do this
is to obtain the transformation matrix from the PointCloudInstance (GetTransform()), convert the CloudPoint to an XYZ
using the implicit conversion operator, and use Transform.OfPoint(XYZ).

#### Since

2012

### `T:Autodesk.Revit.DB.PointClouds.PointCloudColorEncoding`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudColorEncoding`

#### Since

2012

#### Summary

The color encodings supported by Revit point clouds.

#### Since

2012

### `F:Autodesk.Revit.DB.PointClouds.PointCloudColorEncoding.ABGR`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudColorEncoding.ABGR`

#### Summary

The point cloud uses colors arranged in ABGR format (common in Windows).

### `F:Autodesk.Revit.DB.PointClouds.PointCloudColorEncoding.ARGB`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudColorEncoding.ARGB`

#### Summary

The point cloud uses colors arranged in ARGB format.

### `F:Autodesk.Revit.DB.PointClouds.CloudPoint.Color`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointClouds.CloudPoint.Color`

#### Summary

The color

### `F:Autodesk.Revit.DB.PointClouds.CloudPoint.Z`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointClouds.CloudPoint.Z`

#### Summary

The Z coordinate

### `F:Autodesk.Revit.DB.PointClouds.CloudPoint.Y`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointClouds.CloudPoint.Y`

#### Summary

The Y coordinate

### `F:Autodesk.Revit.DB.PointClouds.CloudPoint.X`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointClouds.CloudPoint.X`

#### Summary

The X coordinate

### `M:Autodesk.Revit.DB.PointClouds.CloudPoint.op_Implicit(Autodesk.Revit.DB.PointClouds.CloudPoint)~Autodesk.Revit.DB.XYZ`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.CloudPoint.op_Implicit(Autodesk.Revit.DB.PointClouds.CloudPoint)~Autodesk.Revit.DB.XYZ`

#### Summary

Creates an XYZ object from this point cloud.

### `M:Autodesk.Revit.DB.PointClouds.CloudPoint.#ctor(System.Single,System.Single,System.Single,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.CloudPoint.#ctor(System.Single,System.Single,System.Single,System.Int32)`

#### Summary

Creates a new cloud point.

#### Parameter `x`

The X coordinate.

#### Parameter `y`

The Y coordinate.

#### Parameter `z`

The Z coordinate.

#### Parameter `color`

The color.

### `T:Autodesk.Revit.DB.PointClouds.CloudPoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.CloudPoint`

#### Summary

Represents a point obtained from a Point cloud.

#### Since

2012

### `M:Autodesk.Revit.DB.IFamilyLoadOptionsProxy.OnSharedFamilyFound(Autodesk.Revit.DB.Family,System.Boolean,Autodesk.Revit.DB.FamilySource@,System.Boolean@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFamilyLoadOptionsProxy.OnSharedFamilyFound(Autodesk.Revit.DB.Family,System.Boolean,Autodesk.Revit.DB.FamilySource@,System.Boolean@)`

#### Summary

A method called when the shared family was found in the target document.

#### Remarks

Triggered only when the family is both loaded and changed.

#### Parameter `sharedFamily`

The shared family in the current family document.

#### Parameter `familyInUse`

Indicates if one or more instances of the family is placed in the project.

#### Parameter `source`

This indicates if the family will load from
the project or the current family.

#### Parameter `overwriteParameterValues`

This indicates whether or not to overwrite the parameter
values of existing types.

#### Returns

Return true to continue loading the family, false to cancel.

### `M:Autodesk.Revit.DB.IFamilyLoadOptionsProxy.OnFamilyFound(System.Boolean,System.Boolean@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFamilyLoadOptionsProxy.OnFamilyFound(System.Boolean,System.Boolean@)`

#### Summary

A method called when the family was found in the target document.

#### Remarks

Triggered only when the family is both loaded and changed.

#### Parameter `familyInUse`

Indicates if one or more instances of the family is placed in the project.

#### Parameter `overwriteParameterValues`

This determines whether or not to overwrite the parameter
values of existing types. The default value is false.

#### Returns

Return true to continue loading the family, false to cancel.

### `M:Autodesk.Revit.DB.IFamilyLoadOptions.OnSharedFamilyFound(Autodesk.Revit.DB.Family,System.Boolean,Autodesk.Revit.DB.FamilySource@,System.Boolean@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFamilyLoadOptions.OnSharedFamilyFound(Autodesk.Revit.DB.Family,System.Boolean,Autodesk.Revit.DB.FamilySource@,System.Boolean@)`

#### Summary

A method called when the shared family was found in the target document.

#### Remarks

Triggered only when the family is both loaded and changed.

#### Parameter `sharedFamily`

The shared family in the current family document.

#### Parameter `familyInUse`

Indicates if one or more instances of the family is placed in the project.

#### Parameter `source`

This indicates if the family will load from
the project or the current family.

#### Parameter `overwriteParameterValues`

This indicates whether or not to overwrite the parameter
values of existing types.

#### Returns

Return true to continue loading the family, false to cancel.

### `M:Autodesk.Revit.DB.IFamilyLoadOptions.OnFamilyFound(System.Boolean,System.Boolean@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFamilyLoadOptions.OnFamilyFound(System.Boolean,System.Boolean@)`

#### Summary

A method called when the family was found in the target document.

#### Remarks

Triggered only when the family is both loaded and changed.

#### Parameter `familyInUse`

Indicates if one or more instances of the family is placed in the project.

#### Parameter `overwriteParameterValues`

This determines whether or not to overwrite the parameter
values of existing types. The default value is false.

#### Returns

Return true to continue loading the family, false to cancel.

### `T:Autodesk.Revit.DB.IFamilyLoadOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.IFamilyLoadOptions`

#### Summary

An interface class which provide the callback for family load options.

#### Remarks

If the family is not loaded, or if the family is loaded but unchanged, the situation will never trigger and `M:Autodesk.Revit.DB.IFamilyLoadOptions.OnFamilyFound(System.Boolean,System.Boolean@)` and `M:Autodesk.Revit.DB.IFamilyLoadOptions.OnSharedFamilyFound(Autodesk.Revit.DB.Family,System.Boolean,Autodesk.Revit.DB.FamilySource@,System.Boolean@)` will not be called.
Only if the family is loaded and changed should the interface methods be called.

### `P:Autodesk.Revit.DB.Macros.VendorIdAttribute.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.Macros.VendorIdAttribute.Value`

#### Summary

AddInId VendorId value.

#### Since

2012

### `M:Autodesk.Revit.DB.Macros.VendorIdAttribute.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Macros.VendorIdAttribute.#ctor(System.String)`

#### Summary

Constructs a new VendorIdAttribute.

#### Since

2012

### `T:Autodesk.Revit.DB.Macros.VendorIdAttribute`

Member kind: type
Symbol: `Autodesk.Revit.DB.Macros.VendorIdAttribute`

#### Summary

The custom VendorId attribute for Macros macros use only.

#### Since

2012

### `P:Autodesk.Revit.DB.Macros.DocumentEntryPoint.AddinFolder`

Member kind: property
Symbol: `Autodesk.Revit.DB.Macros.DocumentEntryPoint.AddinFolder`

#### Summary

The full path to the Revit Macros module.

#### Remarks

This path should be used instead of the .NET GetExecutingAssembly() result, because
the Macros module is loaded in such a way to make that result unreliable.

#### Since

2014

### `M:Autodesk.Revit.DB.Macros.DocumentEntryPoint.OnShutdownEO`

Member kind: method
Symbol: `Autodesk.Revit.DB.Macros.DocumentEntryPoint.OnShutdownEO`

#### Summary

For Revit Macros internal use only.

#### Since

2014

### `M:Autodesk.Revit.DB.Macros.DocumentEntryPoint.FinishInitializationEO`

Member kind: method
Symbol: `Autodesk.Revit.DB.Macros.DocumentEntryPoint.FinishInitializationEO`

#### Summary

For Revit Macros internal use only.

#### Since

2014

### `M:Autodesk.Revit.DB.Macros.DocumentEntryPoint.Initialize(System.Object,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Macros.DocumentEntryPoint.Initialize(System.Object,System.String)`

#### Summary

For Revit Macros internal use only.

#### Since

2014

### `T:Autodesk.Revit.DB.Macros.DocumentEntryPoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.Macros.DocumentEntryPoint`

#### Summary

For Revit Macros use only.

#### Since

2014

### `P:Autodesk.Revit.DB.Macros.ApplicationEntryPoint.AddinFolder`

Member kind: property
Symbol: `Autodesk.Revit.DB.Macros.ApplicationEntryPoint.AddinFolder`

#### Summary

The full path to the Revit Macros module.

#### Remarks

This path should be used instead of the .NET GetExecutingAssembly() result, because
the Macros module is loaded in such a way to make that result unreliable.

#### Since

2014

### `M:Autodesk.Revit.DB.Macros.ApplicationEntryPoint.OnShutdownEO`

Member kind: method
Symbol: `Autodesk.Revit.DB.Macros.ApplicationEntryPoint.OnShutdownEO`

#### Summary

For Revit Macros internal use only.

#### Since

2014

### `M:Autodesk.Revit.DB.Macros.ApplicationEntryPoint.FinishInitializationEO`

Member kind: method
Symbol: `Autodesk.Revit.DB.Macros.ApplicationEntryPoint.FinishInitializationEO`

#### Summary

For Revit Macros internal use only.

#### Since

2014

### `M:Autodesk.Revit.DB.Macros.ApplicationEntryPoint.Initialize(System.Object,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Macros.ApplicationEntryPoint.Initialize(System.Object,System.String)`

#### Summary

For Revit Macros internal use only.

#### Since

2014

### `T:Autodesk.Revit.DB.Macros.ApplicationEntryPoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.Macros.ApplicationEntryPoint`

#### Summary

For Revit Macros use only.

#### Since

2014

### `T:Autodesk.Revit.DB.Macros.IEntryPoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.Macros.IEntryPoint`

#### Summary

The interface supporting Document and Application level entry point classes for macros.

### `P:Autodesk.Revit.DB.Macros.AddInIdAttribute.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.Macros.AddInIdAttribute.Value`

#### Summary

AddInId guid value.

#### Since

2011

### `M:Autodesk.Revit.DB.Macros.AddInIdAttribute.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Macros.AddInIdAttribute.#ctor(System.String)`

#### Summary

Constructs a new AddInIdAttribute.

#### Since

2011

### `T:Autodesk.Revit.DB.Macros.AddInIdAttribute`

Member kind: type
Symbol: `Autodesk.Revit.DB.Macros.AddInIdAttribute`

#### Summary

The custom AddInId attribute for Macros macros use only.

#### Since

2011

### `M:Autodesk.Revit.DB.SketchPlane.GetPlaneReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.SketchPlane.GetPlaneReference`

#### Summary

Returns a reference to this element as a plane.

#### Remarks

The object returned here can be used with the `T:Autodesk.Revit.DB.PointOnPlane` class.

#### Returns

The reference.

#### Since

2014

### `M:Autodesk.Revit.DB.SketchPlane.GetPlane`

Member kind: method
Symbol: `Autodesk.Revit.DB.SketchPlane.GetPlane`

#### Summary

Returns the corresponding Plane.

#### Returns

The plane upon which elements created with this sketch plane will lie.

#### Since

2014

### `M:Autodesk.Revit.DB.SketchPlane.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SketchPlane.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a sketch plane from a grid, reference plane, or level.

#### Parameter `document`

The document.

#### Parameter `datumId`

The id of the grid, reference plane, or level.

#### Returns

The newly created sketch plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

datumId is not a valid Element identifier.
-or-
ElementId must correspond to a grid, reference plane, or level.
-or-
ElementId must correspond to a non-curved datum.
-or-
Sketch plane creation is not allowed in this family.

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

### `M:Autodesk.Revit.DB.SketchPlane.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SketchPlane.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

#### Summary

Creates a new sketch plane from a reference to a planar face.

#### Remarks

A reference relationship will be created between the face and the sketch plane.

#### Parameter `document`

The document.

#### Parameter `planarFaceReference`

The reference of the planar face where the sketch plane will be created.

#### Returns

The newly created sketch plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Sketch plane creation is not allowed in this family.
-or-
The reference is not a planar face.

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

### `M:Autodesk.Revit.DB.SketchPlane.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Plane)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SketchPlane.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Plane)`

#### Summary

Creates a new sketch plane from a geometric plane.

#### Remarks

There will not be a reference relationship established from the sketch plane to the input face. To create a SketchPlane with a reference to other geometry,
use the overload with a Reference input.

#### Parameter `document`

The document.

#### Parameter `plane`

The geometry plane where the sketch plane will be created.

#### Returns

The newly created sketch plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Sketch plane creation is not allowed in this family.

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

### `P:Autodesk.Revit.DB.SketchPlane.IsSuitableForModelElements`

Member kind: property
Symbol: `Autodesk.Revit.DB.SketchPlane.IsSuitableForModelElements`

#### Summary

Identifies if the sketch plane can be assigned to model elements.

#### Remarks

Sketch planes with this property set to true are suitable to be used to create model elements. Planes where this property is false will be rejected when used to create model curves, symbolic curves, generic forms, or other sketched elements.

### `T:Autodesk.Revit.DB.SketchPlane`

Member kind: type
Symbol: `Autodesk.Revit.DB.SketchPlane`

#### Summary

Represents a sketch plane or work plane.

#### Remarks

A SketchPlane object is used as an input to creation of sketch-referencing elements such as Model Curves or sketch-owning elements such as Generic Forms. The SketchPlane can be obtained from an existing element or created from a geometric plane or planar face. Note that the sketch plane element passed as input to create an element may not be the actual sketch plane assigned to that element; Revit may look for a geometrically equivalent plane to use, or may create a new one if the input plane is already used for other purposes. Some sketch planes (such as those obtained from detail curves) are suitable only for use in creating detail elements; they will be rejected when used for other element types.

### `M:Autodesk.Revit.DB.GeometryElement.GetTransformed(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryElement.GetTransformed(Autodesk.Revit.DB.Transform)`

#### Summary

Returns a transformed copy of the geometry in this element.

#### Parameter `transform`

The transformation to apply to the geometry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Transform is not conformal

### `P:Autodesk.Revit.DB.GeometryElement.MaterialElement`

Member kind: property
Symbol: `Autodesk.Revit.DB.GeometryElement.MaterialElement`

#### Summary

Element describing the material from which this element is composed.

### `M:Autodesk.Revit.DB.GeometryElement.AddForTransientDisplay(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryElement.AddForTransientDisplay(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.ElementId)`

#### Summary

Adds collection of GeometryObjects to the transient (temporary) element for application display which will not be saved with the model.

#### Returns

Resulting GeometryElement after adding collection

#### Since

2015

### `M:Autodesk.Revit.DB.GeometryElement.SetForTransientDisplay(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryElement.SetForTransientDisplay(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject},Autodesk.Revit.DB.ElementId)`

#### Summary

Creates or set geometry of transient (temporary) element for application display which will not be saved with the model.

#### Returns

The element id of the created element.

#### Since

2015

### `M:Autodesk.Revit.DB.GeometryElement.GetEnumeratorNG`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryElement.GetEnumeratorNG`

#### Summary

Returns an enumerator that iterates through the collection.

#### Returns

An IEnumerator(GeometryObject) object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.GeometryElement.GetBoundingBox`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryElement.GetBoundingBox`

#### Summary

Retrieves a box that encloses the geometry element.

#### Returns

The bounding box.

#### Remarks

Note: If the GeometryElement was obtained via Element.get_Geometry from an Element containing 2D geometry
but no 3D geometry, the bounding box returned by this function may not be empty because it takes the 2D geometry into account.

#### Since

2013

### `M:Autodesk.Revit.DB.GeometryElement.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryElement.GetEnumerator`

#### Summary

Returns an enumerator that iterates through the collection.

#### Returns

An IEnumerator(GeometryObject) object that can be used to iterate through the collection.

### `T:Autodesk.Revit.DB.GeometryElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.GeometryElement`

#### Summary

Geometric representation of an element.

#### Remarks

This class contains geometric primitives that are generated from the
parametric description of the element. The member geometric primitives can be obtained
directly from this object using the capabilities of IEnumerable.

### `M:Autodesk.Revit.DB.Structure.TrussMemberInfo.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.TrussMemberInfo.#ctor`

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never
be created by the developer.

### `P:Autodesk.Revit.DB.Structure.TrussMemberInfo.memberTypeKey`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.TrussMemberInfo.memberTypeKey`

#### Summary

Kind of the member in the truss.

### `P:Autodesk.Revit.DB.Structure.TrussMemberInfo.lockedToTruss`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.TrussMemberInfo.lockedToTruss`

#### Summary

Whether the member is locked to the host truss.

### `P:Autodesk.Revit.DB.Structure.TrussMemberInfo.hostTrussId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.TrussMemberInfo.hostTrussId`

#### Summary

The host truss' ElementId of the member.

### `T:Autodesk.Revit.DB.Structure.TrussMemberInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.TrussMemberInfo`

#### Summary

Provides access to the information of a truss member in Autodesk Revit.

#### Remarks

A struct TrussMemberInfo that contains an element's host truss, whether to lock to the truss, usage type, etc.

### `T:Autodesk.Revit.DB.FamilySource`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilySource`

#### Summary

Describes which version of the family to be loaded.

### `F:Autodesk.Revit.DB.FamilySource.Family`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilySource.Family`

#### Summary

Loading the family from current family document.

### `F:Autodesk.Revit.DB.FamilySource.Project`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilySource.Project`

#### Summary

Loading the family from target project document.

### `P:Autodesk.Revit.DB.FamilyElementVisibility.IsShownInFine`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyElementVisibility.IsShownInFine`

#### Summary

Indicates if the instance is display with Fine detail level in the view
of project document.

#### Remarks

This property cannot be set to false if the other two detail levels are also false.

### `P:Autodesk.Revit.DB.FamilyElementVisibility.IsShownInMedium`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyElementVisibility.IsShownInMedium`

#### Summary

Indicates if the instance is display with Medium detail level in the view
of project document.

#### Remarks

This property cannot be set to false if the other two detail levels are also false.

### `P:Autodesk.Revit.DB.FamilyElementVisibility.IsShownInCoarse`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyElementVisibility.IsShownInCoarse`

#### Summary

Indicates if the instance is display with Coarse detail level in the view
of project document.

#### Remarks

This property cannot be set to false if the other two detail levels are also false.

### `P:Autodesk.Revit.DB.FamilyElementVisibility.IsShownInLeftRight`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyElementVisibility.IsShownInLeftRight`

#### Summary

Indicates if the instance is display in Left/Right view of project document.

#### Remarks

This property matters for objects whose visibility type is Model.

### `P:Autodesk.Revit.DB.FamilyElementVisibility.IsShownInFrontBack`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyElementVisibility.IsShownInFrontBack`

#### Summary

Indicates if the instance is display in Front/Back view of project document.

#### Remarks

This property matters for objects whose visibility type is Model.

### `P:Autodesk.Revit.DB.FamilyElementVisibility.IsShownInTopBottom`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyElementVisibility.IsShownInTopBottom`

#### Summary

Indicates if the instance is display in Plan/RCP view of project document.

#### Remarks

This property matters for objects whose visibility type is Model.

### `P:Autodesk.Revit.DB.FamilyElementVisibility.IsShownInPlanRCPCut`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyElementVisibility.IsShownInPlanRCPCut`

#### Summary

Indicates if the instance is displayed when cut in Plan/RCP (if the category permits).

#### Remarks

controls whether the Model Family Element is shown when a FamilyInstance
of that Family is cut in a Plan/RCP view, i.e. the cut plane passes through the
bounding box of the instance. It only has a meaning for categories that are "cut in the symbol". For
non-cuttable categories it is always false and for ones that are "cuttable in the
instance" it is the same as the IsShownInTopBottom.

### `P:Autodesk.Revit.DB.FamilyElementVisibility.IsShownOnlyWhenCut`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyElementVisibility.IsShownOnlyWhenCut`

#### Summary

Indicates if the instance is displayed only if it has been cut.

#### Remarks

This property matters for objects which visibility type is ViewSpecific.

### `P:Autodesk.Revit.DB.FamilyElementVisibility.VisibilityType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyElementVisibility.VisibilityType`

#### Summary

Indicates if the instance is Model or View specific.

### `T:Autodesk.Revit.DB.FamilyElementVisibility`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyElementVisibility`

#### Summary

Provides access to the visibility parameters of family elements in family document.

### `T:Autodesk.Revit.DB.FamilyElementVisibilityType`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyElementVisibilityType`

#### Summary

Indicates the Visibility type of generic forms.

#### Remarks

Use this enum to indicate the visibility type
of new forms.

### `F:Autodesk.Revit.DB.FamilyElementVisibilityType.ViewSpecific`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyElementVisibilityType.ViewSpecific`

#### Summary

The element will be displayed only in the view where it is created. This
applies to items like detail components, annotations, and view-specific imports.

### `F:Autodesk.Revit.DB.FamilyElementVisibilityType.Model`

Member kind: field
Symbol: `Autodesk.Revit.DB.FamilyElementVisibilityType.Model`

#### Summary

The element will be displayed in 3D views and model other model views.

### `M:Autodesk.Revit.DB.DimensionSegment.ResetTextPosition`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionSegment.ResetTextPosition`

#### Summary

Resets the text position of the segment to the initial position determined by its type and parameters.

#### Remarks

The initial point is the text location when dimension is created.

#### Since

2015 Subscription Update

### `P:Autodesk.Revit.DB.DimensionSegment.TextPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegment.TextPosition`

#### Summary

The position of the dimension text's drag point.

#### Remarks

This property is not applicable to all dimensions.
For example, it is not available for spot dimensions,
dimensions using equality formula, and when dimension style is ordinate.

If the position is not applicable, this property returns NULL
and will not allow setting a value.

#### Exception `T:Autodesk.Revit.Exceptions.ApplicationException`

Thrown when the dimension text is unavailable.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when:
The dimension text is a SpotElevationWhen using equality formula.When dimension style is ordinate..

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.DB.DimensionSegment.IsTextPositionAdjustable`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionSegment.IsTextPositionAdjustable`

#### Summary

Indicates if this dimension is supported to set/get TextPosition/LeaderPosition.

#### Returns

True if this dimension is supported to set/get TextPosition/LeaderPosition, false otherwise.

#### Since

2015 Subscription Update

### `P:Autodesk.Revit.DB.DimensionSegment.LeaderEndPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegment.LeaderEndPosition`

#### Summary

The position of the dimension leader end point.

#### Remarks

This property is not applicable to all dimensions.
For example, it is not available for spot dimensions,
dimensions using equality formula, and when dimension style is ordinate.

If the position is not applicable, this property returns NULL
and will not allow setting a value.

#### Since

2015 Subscription Update.

#### Exception `T:Autodesk.Revit.Exceptions.ApplicationException`

Thrown when the dimension text is unavailable.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when:
The dimension text is a SpotElevationWhen using equality formula.When dimension style is ordinate.

### `P:Autodesk.Revit.DB.DimensionSegment.ValueOverride`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegment.ValueOverride`

#### Summary

The text that replaces the segment's value.

### `P:Autodesk.Revit.DB.DimensionSegment.Below`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegment.Below`

#### Summary

The text shown below the segment's value.

### `P:Autodesk.Revit.DB.DimensionSegment.Above`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegment.Above`

#### Summary

The text shown above the segment's value.

### `P:Autodesk.Revit.DB.DimensionSegment.Suffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegment.Suffix`

#### Summary

The text shown after the segment's value.

### `P:Autodesk.Revit.DB.DimensionSegment.Prefix`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegment.Prefix`

#### Summary

The text shown before the segment's value.

### `P:Autodesk.Revit.DB.DimensionSegment.IsLocked`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegment.IsLocked`

#### Summary

Indicates if this segment is locked.

#### Remarks

This property always returns false if the dimension
is a radial or spot dimension.
This property cannot be set if the segment has been labeled, or
the dimension shape is a radial or spot dimension.

### `P:Autodesk.Revit.DB.DimensionSegment.ValueString`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegment.ValueString`

#### Summary

The displayed value shown for the dimension segment.

### `P:Autodesk.Revit.DB.DimensionSegment.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegment.Value`

#### Summary

The length of the segment.

### `P:Autodesk.Revit.DB.DimensionSegment.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegment.Origin`

#### Summary

The segment origin.

#### Remarks

The origin will be the midpoint of the line that
makes up the segment.

### `T:Autodesk.Revit.DB.DimensionSegment`

Member kind: type
Symbol: `Autodesk.Revit.DB.DimensionSegment`

#### Summary

A segment of a dimension within the Autodesk Revit project.

### `M:Autodesk.Revit.DB.SlabShapeEditor.DeletePoint(Autodesk.Revit.DB.SlabShapeVertex)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeEditor.DeletePoint(Autodesk.Revit.DB.SlabShapeVertex)`

#### Summary

Delete a SlabShapeVertex from the element.

#### Remarks

Corner vertices are created right after the SlabShapeEditor is enabled.
They are tied with the boundaries so that they could not be deleted individually.
They can only be deleted using ResetSlabShape.

#### Parameter `vertex`

The SlabShapeVertex to be deleted.

#### Returns

True if the vertex is successfully deleted.
False if the vertex is not found or could not be deleted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024.1

### `M:Autodesk.Revit.DB.SlabShapeEditor.CreateCreasesFromFoldingLines(Autodesk.Revit.DB.Element,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeEditor.CreateCreasesFromFoldingLines(Autodesk.Revit.DB.Element,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

#### Summary

Convert selected folding lines to split lines

#### Parameter `hostObj`

object that hosts the SlabShapeEditor

#### Parameter `references`

References of selected folding lines.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

this operation failed.

#### Since

2023

### `P:Autodesk.Revit.DB.SlabShapeEditor.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeEditor.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.SlabShapeEditor.PickSupport(Autodesk.Revit.DB.Line)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeEditor.PickSupport(Autodesk.Revit.DB.Line)`

#### Summary

Picks an element to support the slab. This method will define split lines and create constant bearing lines for the slab.

#### Parameter `gLine`

A line from a support element such as a beam.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input line is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input line is invalid.

### `M:Autodesk.Revit.DB.SlabShapeEditor.ResetSlabShape`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeEditor.ResetSlabShape`

#### Summary

Removes the modifications made during editing and resets the element geometry back to the unmodified state.

#### Remarks

Calling this method will reset the slab back to its original state and disable Slab Shape Editing. If further
editing is needed, call Enable again.

### `M:Autodesk.Revit.DB.SlabShapeEditor.DrawSplitLine(Autodesk.Revit.DB.SlabShapeVertex,Autodesk.Revit.DB.SlabShapeVertex)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeEditor.DrawSplitLine(Autodesk.Revit.DB.SlabShapeVertex,Autodesk.Revit.DB.SlabShapeVertex)`

#### Summary

Draws a split line on the corresponding slab, roof or floor.

#### Remarks

Drawing a split line may result in multiple creases, for example when the line crosses existing creases or boundary edges.

#### Parameter `startVertex`

The vertex to start the split line.

#### Parameter `endVertex`

The vertex to end the split line.

#### Returns

The newly created creases.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input vertex is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input vertex is invalid.

### `M:Autodesk.Revit.DB.SlabShapeEditor.DrawPoint(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeEditor.DrawPoint(Autodesk.Revit.DB.XYZ)`

#### Summary

Adds a point to the corresponding slab, roof or floor.

#### Remarks

If the input location is not on the top face of the slab, this function will return `null` .
Drawing a point on boundary crease may increase the number of creases.
This method will regenerate the document even in manual regeneration mode.

#### Parameter `location`

The location of the point.

#### Returns

The newly created vertex.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the location is `null` .

### `M:Autodesk.Revit.DB.SlabShapeEditor.ModifySubElement(Autodesk.Revit.DB.SlabShapeCrease,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeEditor.ModifySubElement(Autodesk.Revit.DB.SlabShapeCrease,System.Double)`

#### Summary

Manipulates the crease on the corresponding slab, roof or floor.

#### Parameter `crease`

The crease.

#### Parameter `offset`

The new value of the crease offset, which is the average of offsets of its ends.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the crease is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the crease is invalid.

### `M:Autodesk.Revit.DB.SlabShapeEditor.ModifySubElement(Autodesk.Revit.DB.SlabShapeVertex,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeEditor.ModifySubElement(Autodesk.Revit.DB.SlabShapeVertex,System.Double)`

#### Overloads

Manipulates an entity on the corresponding slab, roof or floor.

#### Summary

Manipulates the vertex on the corresponding slab, roof or floor.

#### Parameter `vertex`

The vertex.

#### Parameter `offset`

The new value of the vertex offset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the vertex is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the vertex is invalid.

### `P:Autodesk.Revit.DB.SlabShapeEditor.SlabShapeCreases`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeEditor.SlabShapeCreases`

#### Summary

All of the creases that can be edited.

### `P:Autodesk.Revit.DB.SlabShapeEditor.SlabShapeVertices`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeEditor.SlabShapeVertices`

#### Summary

All of the vertices that can be edited.

### `M:Autodesk.Revit.DB.SlabShapeEditor.Enable`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeEditor.Enable`

#### Summary

Enables the slab shape editing functionality.

### `P:Autodesk.Revit.DB.SlabShapeEditor.IsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeEditor.IsEnabled`

#### Summary

Identifies if the slab shape editing functionality is enabled.

#### Remarks

If true, the creases and vertices are accessible and modifiable.
If false, no creases and vertices are accessible.

### `T:Autodesk.Revit.DB.SlabShapeEditor`

Member kind: type
Symbol: `Autodesk.Revit.DB.SlabShapeEditor`

#### Summary

An object used for Slab Shape Editing.

#### Remarks

The SlabShapeEditor can be obtained from a slab object, such as a roof or floor.

### `T:Autodesk.Revit.DB.CurvedEdgeConditionParam`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurvedEdgeConditionParam`

#### Summary

The allowed values for the HOST_SSE_CURVED_EDGE_CONDITION_PARAM parameter.

### `F:Autodesk.Revit.DB.CurvedEdgeConditionParam.ProjectToSideFace`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurvedEdgeConditionParam.ProjectToSideFace`

#### Summary

Project to side

### `F:Autodesk.Revit.DB.CurvedEdgeConditionParam.ConformToCurve`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurvedEdgeConditionParam.ConformToCurve`

#### Summary

Conform to curve

### `F:Autodesk.Revit.DB.CurvedEdgeConditionParam.NotApplicable`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurvedEdgeConditionParam.NotApplicable`

#### Summary

Not Applicable

### `P:Autodesk.Revit.DB.SlabShapeVertex.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeVertex.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.SlabShapeVertex.Position`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeVertex.Position`

#### Summary

The vertex position

### `P:Autodesk.Revit.DB.SlabShapeVertex.VertexType`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeVertex.VertexType`

#### Summary

The vertex type

### `M:Autodesk.Revit.DB.SlabShapeVertex.#ctor(Autodesk.Revit.DB.SlabShapeEditor,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeVertex.#ctor(Autodesk.Revit.DB.SlabShapeEditor,System.Int32)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.SlabShapeVertex`

Member kind: type
Symbol: `Autodesk.Revit.DB.SlabShapeVertex`

#### Summary

Represents a vertex of a slab shape edited element.

### `T:Autodesk.Revit.DB.SlabShapeVertexType`

Member kind: type
Symbol: `Autodesk.Revit.DB.SlabShapeVertexType`

#### Summary

The type of a SlabShapeVertex

### `M:SSE.initSnappableTagCache`

Member kind: method
Symbol: `SSE.initSnappableTagCache`

### `M:SSE.getPickEntityType(Element!System.Runtime.CompilerServices.IsConst*,Pick!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `SSE.getPickEntityType(Element!System.Runtime.CompilerServices.IsConst*,Pick!System.Runtime.CompilerServices.IsConst*)`

### `M:SSE.getVertexTagsOfEdge(System.Int32,System.Int32(*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)[N2])`

Member kind: method
Symbol: `SSE.getVertexTagsOfEdge(System.Int32,System.Int32(*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)[N2])`

### `M:SSE.getUnderlyingRefPlane(Pick!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Double!System.Runtime.CompilerServices.IsConst*,Plane!System.Runtime.CompilerServices.IsConst*,Plane*,Arr<Atom>*)`

Member kind: method
Symbol: `SSE.getUnderlyingRefPlane(Pick!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Double!System.Runtime.CompilerServices.IsConst*,Plane!System.Runtime.CompilerServices.IsConst*,Plane*,Arr<Atom>*)`

### `M:SSE.hasEditableThickness(System.Double*)`

Member kind: method
Symbol: `SSE.hasEditableThickness(System.Double*)`

### `M:SSE.hasConstantThickness(System.Double*)`

Member kind: method
Symbol: `SSE.hasConstantThickness(System.Double*)`

### `M:SSE.hasConstantOffset(System.Double*)`

Member kind: method
Symbol: `SSE.hasConstantOffset(System.Double*)`

### `M:SSE.transform(Trf!System.Runtime.CompilerServices.IsConst*,Arr<Atom>*)`

Member kind: method
Symbol: `SSE.transform(Trf!System.Runtime.CompilerServices.IsConst*,Arr<Atom>*)`

### `M:SSE.augmentGRep(DBView!System.Runtime.CompilerServices.IsConst*,GRep**)`

Member kind: method
Symbol: `SSE.augmentGRep(DBView!System.Runtime.CompilerServices.IsConst*,GRep**)`

### `M:SSE.getDetermRegenSteps(Arr<RegenStep**>*)`

Member kind: method
Symbol: `SSE.getDetermRegenSteps(Arr<RegenStep**>*)`

### `M:SSE.getAtom`

Member kind: method
Symbol: `SSE.getAtom`

### `M:SSE.isMyPick(Pick!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `SSE.isMyPick(Pick!System.Runtime.CompilerServices.IsConst*)`

### `M:SSE.setOffset(System.Int32,System.Double,System.Boolean)`

Member kind: method
Symbol: `SSE.setOffset(System.Int32,System.Double,System.Boolean)`

### `M:SSE.getEntityInfo(System.Int32,XYZUtils.XYZ*,System.Double*,System.Boolean*,System.Boolean*)`

Member kind: method
Symbol: `SSE.getEntityInfo(System.Int32,XYZUtils.XYZ*,System.Double*,System.Boolean*,System.Boolean*)`

### `M:SSE.getOriginalFaceHeight`

Member kind: method
Symbol: `SSE.getOriginalFaceHeight`

### `M:SSE.isApplicable`

Member kind: method
Symbol: `SSE.isApplicable`

### `M:SSE.isStepDormant`

Member kind: method
Symbol: `SSE.isStepDormant`

### `M:SSE.setEditMode(ElementId)`

Member kind: method
Symbol: `SSE.setEditMode(ElementId)`

### `M:SSE.isEnabled`

Member kind: method
Symbol: `SSE.isEnabled`

### `M:SSE.recomputeGRep(Element*)`

Member kind: method
Symbol: `SSE.recomputeGRep(Element*)`

### `M:SSE.recomputeApplicableStatus(Element*)`

Member kind: method
Symbol: `SSE.recomputeApplicableStatus(Element*)`

### `M:SSE.addSlabShapeEditGStep(Element*,System.Boolean)`

Member kind: method
Symbol: `SSE.addSlabShapeEditGStep(Element*,System.Boolean)`

### `P:Autodesk.Revit.DB.SlabShapeCrease.EndPoints`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeCrease.EndPoints`

#### Summary

The vertices of the crease.

### `P:Autodesk.Revit.DB.SlabShapeCrease.CreaseType`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeCrease.CreaseType`

#### Summary

The type of the crease.

### `P:Autodesk.Revit.DB.SlabShapeCrease.Curve`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeCrease.Curve`

#### Summary

The geometry of the crease.

### `T:Autodesk.Revit.DB.SlabShapeCrease`

Member kind: type
Symbol: `Autodesk.Revit.DB.SlabShapeCrease`

#### Summary

A crease used in Slab Shape Editing.

### `M:getShortFileName(AString!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `getShortFileName(AString!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `T:Autodesk.Revit.DB.BoxPlacement`

Member kind: type
Symbol: `Autodesk.Revit.DB.BoxPlacement`

#### Summary

An enumerated type containing possible constraint types for Adaptive Points.

### `F:Autodesk.Revit.DB.BoxPlacement.BottomLeft`

Member kind: field
Symbol: `Autodesk.Revit.DB.BoxPlacement.BottomLeft`

#### Summary

Placement of a box by its bottom left corner.

### `F:Autodesk.Revit.DB.BoxPlacement.BottomRight`

Member kind: field
Symbol: `Autodesk.Revit.DB.BoxPlacement.BottomRight`

#### Summary

Placement of a box by its bottom right corner.

### `F:Autodesk.Revit.DB.BoxPlacement.TopRight`

Member kind: field
Symbol: `Autodesk.Revit.DB.BoxPlacement.TopRight`

#### Summary

Placement of a box by its top right corner.

### `F:Autodesk.Revit.DB.BoxPlacement.TopLeft`

Member kind: field
Symbol: `Autodesk.Revit.DB.BoxPlacement.TopLeft`

#### Summary

Placement of a box by its top left corner.

### `F:Autodesk.Revit.DB.BoxPlacement.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.BoxPlacement.Center`

#### Summary

Placement of a box by its center point

### `M:Autodesk.Revit.DB.GBXMLImportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.GBXMLImportOptions.#ctor`

#### Summary

Default constructor. Sets all options to their default values.

### `T:Autodesk.Revit.DB.GBXMLImportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.GBXMLImportOptions`

#### Summary

Import options for Green-Building XML format.

#### Remarks

Not used currently. Reserved for future use.

### `P:Autodesk.Revit.DB.GenericImportOptions.RefPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.GenericImportOptions.RefPoint`

#### Summary

Reference point (in Revit) to which the image is going to be inserted.

#### Remarks

If `null` , the image will be inserted to the Revit's origin.

### `T:Autodesk.Revit.DB.GenericImportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.GenericImportOptions`

#### Summary

Generic Import options.

### `T:Autodesk.Revit.DB.PropertyLine`

Member kind: type
Symbol: `Autodesk.Revit.DB.PropertyLine`

#### Summary

Represents kinds of PropertyLines.

### `M:Autodesk.Revit.DB.BasePoint.GetSurveyPoint(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BasePoint.GetSurveyPoint(Autodesk.Revit.DB.Document)`

#### Summary

Gets the survey point for the document.

#### Parameter `cda`

The document from which to get the survey point.

#### Returns

The survey point of the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020.2

### `M:Autodesk.Revit.DB.BasePoint.GetProjectBasePoint(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BasePoint.GetProjectBasePoint(Autodesk.Revit.DB.Document)`

#### Summary

Gets the project base point for the document.

#### Parameter `cda`

The document from which to get the project base point.

#### Returns

The project base point of the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020.2

### `P:Autodesk.Revit.DB.BasePoint.SharedPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasePoint.SharedPosition`

#### Summary

Shared position of the BasePoint based on the active ProjectLocation of its belonging Document.
To get the shared position under other ProjectLocations, please use ProjectLocation.GetProjectPosition(BasePoint.Position).

#### Since

2019.2

### `P:Autodesk.Revit.DB.BasePoint.Clipped`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasePoint.Clipped`

#### Summary

Clipped state of the survey point (shared BasePoint). Change its state to clipped or unclipped, depending on how you want to move the survey point.
To move the survey coordinate system in relation to the model, move the clipped survey point.
To change the survey point to another location in the survey coordinate system, move the unclipped survey point.
For project base point (non-shared BasePoint), this property will always return false. Trying to set the property will get an InvalidOperationException.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This operation is only available for a shared BasePoint.

#### Since

2021.1

### `P:Autodesk.Revit.DB.BasePoint.Position`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasePoint.Position`

#### Summary

Position of the BasePoint.

#### Since

2019.2

### `P:Autodesk.Revit.DB.BasePoint.IsShared`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasePoint.IsShared`

#### Summary

Indicates whether the BasePoint is shared. The project's survey point
is a BasePoint which is shared.

### `T:Autodesk.Revit.DB.BasePoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.BasePoint`

#### Summary

A class representing the Project Base Point and Survey Point. Each Revit project
contains one project base point and one survey point. The project base point represents the
origin of the project coordinate system. The survey point represents the origin of
the shared coordinate system.

### `P:Autodesk.Revit.DB.Area.AreaScheme`

Member kind: property
Symbol: `Autodesk.Revit.DB.Area.AreaScheme`

#### Summary

The area scheme.

### `P:Autodesk.Revit.DB.Area.IsGrossInterior`

Member kind: property
Symbol: `Autodesk.Revit.DB.Area.IsGrossInterior`

#### Summary

The boolean value that indicates whether the area is gross interior.

### `T:Autodesk.Revit.DB.Area`

Member kind: type
Symbol: `Autodesk.Revit.DB.Area`

#### Summary

Provides access to the area topology in Autodesk Revit.

#### Remarks

The area object can be queried for its boundary for use in space planning tools.

### `P:Autodesk.Revit.DB.FBXExportOptions.WithoutBoundaryEdges`

Member kind: property
Symbol: `Autodesk.Revit.DB.FBXExportOptions.WithoutBoundaryEdges`

#### Summary

True to export without boundary edges, false otherwise.

#### Value

The default value is false.

#### Since

2013

### `P:Autodesk.Revit.DB.FBXExportOptions.LevelsOfDetailValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.FBXExportOptions.LevelsOfDetailValue`

#### Summary

The value of the levels of detail.

#### Value

To use this option, UseLevelsOfDetail should be set to true. And the value should be in the range [0, 15].
It will be calculated based on the settings of current view if it's not assigned a valid value.

#### Since

2013

### `P:Autodesk.Revit.DB.FBXExportOptions.UseLevelsOfDetail`

Member kind: property
Symbol: `Autodesk.Revit.DB.FBXExportOptions.UseLevelsOfDetail`

#### Summary

True to use levels of detail, false otherwise.

#### Value

The default value is false.

#### Since

2013

### `P:Autodesk.Revit.DB.FBXExportOptions.StopOnError`

Member kind: property
Symbol: `Autodesk.Revit.DB.FBXExportOptions.StopOnError`

#### Summary

Whether export process should stop when a view fails to export.

#### Remarks

If set to false, the export would continue until all views are processed.
This option has an effect only when a set of more than one view is specified.

### `M:Autodesk.Revit.DB.FBXExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FBXExportOptions.#ctor`

#### Summary

Default constructor. Sets all options to their default values.

### `T:Autodesk.Revit.DB.FBXExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.FBXExportOptions`

#### Summary

3D-Studio Max (FBX) Export options.

### `M:Autodesk.Revit.DB.DWFXExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DWFXExportOptions.#ctor`

#### Summary

Default constructor. Sets all options to their default values.

### `T:Autodesk.Revit.DB.DWFXExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DWFXExportOptions`

#### Summary

DWFX Export options.

### `P:Autodesk.Revit.DB.DWFExportOptions.ExportOnlyViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.DWFExportOptions.ExportOnlyViewId`

#### Summary

Only export the specified view.

#### Remarks

Export only the specified view, but the data of the other views is still used, e. g. the hyperlink information.

#### Since

2019

### `P:Autodesk.Revit.DB.DWFExportOptions.CropBoxVisible`

Member kind: property
Symbol: `Autodesk.Revit.DB.DWFExportOptions.CropBoxVisible`

#### Summary

Whether to export crop box.

#### Remarks

The default value is false.

#### Since

2015

### `P:Autodesk.Revit.DB.DWFExportOptions.ImageQuality`

Member kind: property
Symbol: `Autodesk.Revit.DB.DWFExportOptions.ImageQuality`

#### Summary

Image quality level when compressed raster format(JPEG) is used.

#### Remarks

The default value is Default.

### `P:Autodesk.Revit.DB.DWFExportOptions.ImageFormat`

Member kind: property
Symbol: `Autodesk.Revit.DB.DWFExportOptions.ImageFormat`

#### Summary

Controls the compression level of images embedded.

#### Remarks

ImageQuality is ignored when ImageFormat is set to "PNG"-the standard format.

### `P:Autodesk.Revit.DB.DWFExportOptions.PortraitLayout`

Member kind: property
Symbol: `Autodesk.Revit.DB.DWFExportOptions.PortraitLayout`

#### Summary

Paper orientation - Portrait/Landscape.

### `P:Autodesk.Revit.DB.DWFExportOptions.PaperFormat`

Member kind: property
Symbol: `Autodesk.Revit.DB.DWFExportOptions.PaperFormat`

#### Summary

Standard paper format.

### `P:Autodesk.Revit.DB.DWFExportOptions.StopOnError`

Member kind: property
Symbol: `Autodesk.Revit.DB.DWFExportOptions.StopOnError`

#### Summary

Whether export process should stop when a view fails to export.

#### Remarks

If set to false, the export would continue until all views are processed.
This option has an effect only when a set of more than one view is specified.

### `P:Autodesk.Revit.DB.DWFExportOptions.ExportObjectData`

Member kind: property
Symbol: `Autodesk.Revit.DB.DWFExportOptions.ExportObjectData`

#### Summary

Whether to include properties associated with elements.

#### Remarks

ExportObjectData must be enabled (true) in order to also
enable exporting rooms and areas (ExportingAreas). If ExportObjectData
is disabled, the ExportingAreas property will be ignored.

### `P:Autodesk.Revit.DB.DWFExportOptions.MergedViews`

Member kind: property
Symbol: `Autodesk.Revit.DB.DWFExportOptions.MergedViews`

#### Summary

Whether to merge all views in one file.

### `P:Autodesk.Revit.DB.DWFExportOptions.ExportTexture`

Member kind: property
Symbol: `Autodesk.Revit.DB.DWFExportOptions.ExportTexture`

#### Summary

Whether to export texture.

#### Remarks

The default value is true. This property only take effect to 3D DWF.

#### Since

2015 Subscription Update

### `P:Autodesk.Revit.DB.DWFExportOptions.ExportingAreas`

Member kind: property
Symbol: `Autodesk.Revit.DB.DWFExportOptions.ExportingAreas`

#### Summary

Whether to also export areas and rooms' geometry.

### `M:Autodesk.Revit.DB.DWFExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DWFExportOptions.#ctor`

#### Summary

Default constructor. Sets all options to their default values.

### `T:Autodesk.Revit.DB.DWFExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DWFExportOptions`

#### Summary

DWF Export options.

### `T:Autodesk.Revit.DB.CADExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.CADExportOptions`

#### Summary

Generic CAD Export options.

### `T:Autodesk.Revit.DB.ServiceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ServiceType`

#### Summary

This enumeration is used for specifying the most predominant service for the building or space.

#### Remarks

This enumerated list corresponds to the serviceType attribute in the gbXML (Green Building XML) schema
and is primarily used for energy analysis.

### `F:Autodesk.Revit.DB.ServiceType.kSplitSystemsWithMechanicalVentilationWithCooling`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kSplitSystemsWithMechanicalVentilationWithCooling`

#### Summary

Service Type is SplitSystemsWithMechanicalVentilationWithCooling.

### `F:Autodesk.Revit.DB.ServiceType.kSplitSystemsWithMechanicalVentilation`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kSplitSystemsWithMechanicalVentilation`

#### Summary

Service Type is SplitSystemsWithMechanicalVentilation.

### `F:Autodesk.Revit.DB.ServiceType.kSplitSystemsWithNaturalVentilation`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kSplitSystemsWithNaturalVentilation`

#### Summary

Service Type is SplitSystemsWithNaturalVentilation.

### `F:Autodesk.Revit.DB.ServiceType.kVariableRefrigerantFlow`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kVariableRefrigerantFlow`

#### Summary

Service Type is VariableRefrigerantFlow.

### `F:Autodesk.Revit.DB.ServiceType.kWaterLoopHeatPump`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kWaterLoopHeatPump`

#### Summary

Service Type is WaterLoopHeatPump.

### `F:Autodesk.Revit.DB.ServiceType.kActiveChilledBeams`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kActiveChilledBeams`

#### Summary

Service Type is ActiveChilledBeams.

### `F:Autodesk.Revit.DB.ServiceType.kRadiantCooledCeilings`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kRadiantCooledCeilings`

#### Summary

Service Type is RadiantCooledCeilings.

### `F:Autodesk.Revit.DB.ServiceType.kConstantVolumeDualDuct`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kConstantVolumeDualDuct`

#### Summary

Service Type is ConstantVolumeDualDuct.

### `F:Autodesk.Revit.DB.ServiceType.kMultizoneHotDeckColdDeck`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kMultizoneHotDeckColdDeck`

#### Summary

Service Type is MultizoneHotDeckColdDeck.

### `F:Autodesk.Revit.DB.ServiceType.kConstantVolumeTerminalReheat`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kConstantVolumeTerminalReheat`

#### Summary

Service Type is ConstantVolumeTerminalReheat.

### `F:Autodesk.Revit.DB.ServiceType.kConstantVolumeVariableOA`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kConstantVolumeVariableOA`

#### Summary

Service Type is ConstantVolumeVariableOA.

### `F:Autodesk.Revit.DB.ServiceType.kConstantVolumeFixedOA`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kConstantVolumeFixedOA`

#### Summary

Service Type is ConstantVolumeFixedOA.

### `F:Autodesk.Revit.DB.ServiceType.kInductionSystem`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kInductionSystem`

#### Summary

Service Type is InductionSystem.

### `F:Autodesk.Revit.DB.ServiceType.kFanCoilSystem`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kFanCoilSystem`

#### Summary

Service Type is FanCoilSystem.

### `F:Autodesk.Revit.DB.ServiceType.kVAVTerminalReheat`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kVAVTerminalReheat`

#### Summary

Service Type is VAVTerminalReheat.

### `F:Autodesk.Revit.DB.ServiceType.kVAVIndoorPackagedCabinet`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kVAVIndoorPackagedCabinet`

#### Summary

Service Type is VAVIndoorPackagedCabinet.

### `F:Autodesk.Revit.DB.ServiceType.kVAVDualDuct`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kVAVDualDuct`

#### Summary

Service Type is VAVDualDuct.

### `F:Autodesk.Revit.DB.ServiceType.kVAVSingleDuct`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kVAVSingleDuct`

#### Summary

Service Type is VAVSingleDuct.

### `F:Autodesk.Revit.DB.ServiceType.kForcedConvectionHeaterNoFlue`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kForcedConvectionHeaterNoFlue`

#### Summary

Service Type is ForcedConvectionHeaterNoFlue.

### `F:Autodesk.Revit.DB.ServiceType.kForcedConvectionHeaterFlue`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kForcedConvectionHeaterFlue`

#### Summary

Service Type is ForcedConvectionHeaterFlue.

### `F:Autodesk.Revit.DB.ServiceType.kRadiantHeaterMultiburner`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kRadiantHeaterMultiburner`

#### Summary

Service Type is RadiantHeaterMultiburner.

### `F:Autodesk.Revit.DB.ServiceType.kRadiantHeaterNoFlue`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kRadiantHeaterNoFlue`

#### Summary

Service Type is RadiantHeaterNoFlue.

### `F:Autodesk.Revit.DB.ServiceType.kRadiantHeaterFlue`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kRadiantHeaterFlue`

#### Summary

Service Type is RadiantHeaterFlue.

### `F:Autodesk.Revit.DB.ServiceType.kOtherRoomHeater`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kOtherRoomHeater`

#### Summary

Service Type is OtherRoomHeater.

### `F:Autodesk.Revit.DB.ServiceType.kCentralHeatingHotAir`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kCentralHeatingHotAir`

#### Summary

Service Type is CentralHeatingHotAir.

### `F:Autodesk.Revit.DB.ServiceType.kCentralHeatingRadiantFloor`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kCentralHeatingRadiantFloor`

#### Summary

Service Type is CentralHeatingRadiantFloor.

### `F:Autodesk.Revit.DB.ServiceType.kCentralHeatingConvectors`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kCentralHeatingConvectors`

#### Summary

Service Type is CentralHeatingConvectors.

### `F:Autodesk.Revit.DB.ServiceType.kCentralHeatingRadiators`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kCentralHeatingRadiators`

#### Summary

Service Type is CentralHeatingRadiators.

### `F:Autodesk.Revit.DB.ServiceType.kNoServiceType`

Member kind: field
Symbol: `Autodesk.Revit.DB.ServiceType.kNoServiceType`

#### Summary

Service Type is NoServiceType.

### `T:Autodesk.Revit.DB.BuildingType`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuildingType`

#### Summary

This enumeration is used for specifying the most predominant building use type.

#### Remarks

This enumerated list corresponds to the buildingType attribute in the gbXML (Green Building XML) schema
and is primarily used for energy analysis.

### `F:Autodesk.Revit.DB.BuildingType.kWorkshop`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kWorkshop`

#### Summary

Building Type is Workshop.

### `F:Autodesk.Revit.DB.BuildingType.kWarehouse`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kWarehouse`

#### Summary

Building Type is Warehouse.

### `F:Autodesk.Revit.DB.BuildingType.kTransportation`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kTransportation`

#### Summary

Building Type is Transportation.

### `F:Autodesk.Revit.DB.BuildingType.kTownHall`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kTownHall`

#### Summary

Building Type is TownHall.

### `F:Autodesk.Revit.DB.BuildingType.kSportsArena`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kSportsArena`

#### Summary

Building Type is SportsArena.

### `F:Autodesk.Revit.DB.BuildingType.kSchoolOrUniversity`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kSchoolOrUniversity`

#### Summary

Building Type is SchoolOrUniversity.

### `F:Autodesk.Revit.DB.BuildingType.kRetail`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kRetail`

#### Summary

Building Type is Retail.

### `F:Autodesk.Revit.DB.BuildingType.kReligiousBuilding`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kReligiousBuilding`

#### Summary

Building Type is ReligiousBuilding.

### `F:Autodesk.Revit.DB.BuildingType.kPostOffice`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kPostOffice`

#### Summary

Building Type is PostOffice.

### `F:Autodesk.Revit.DB.BuildingType.kPoliceStation`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kPoliceStation`

#### Summary

Building Type is PoliceStation.

### `F:Autodesk.Revit.DB.BuildingType.kPerformingArtsTheater`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kPerformingArtsTheater`

#### Summary

Building Type is PerformingArtsTheater.

### `F:Autodesk.Revit.DB.BuildingType.kPenitentiary`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kPenitentiary`

#### Summary

Building Type is Penitentiary.

### `F:Autodesk.Revit.DB.BuildingType.kParkingGarage`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kParkingGarage`

#### Summary

Building Type is ParkingGarage.

### `F:Autodesk.Revit.DB.BuildingType.kOffice`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kOffice`

#### Summary

Building Type is Office.

### `F:Autodesk.Revit.DB.BuildingType.kMuseum`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kMuseum`

#### Summary

Building Type is Museum.

### `F:Autodesk.Revit.DB.BuildingType.kMultiFamily`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kMultiFamily`

#### Summary

Building Type is MultiFamily.

### `F:Autodesk.Revit.DB.BuildingType.kMotionPictureTheatre`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kMotionPictureTheatre`

#### Summary

Building Type is MotionPictureTheatre.

### `F:Autodesk.Revit.DB.BuildingType.kMotel`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kMotel`

#### Summary

Building Type is Motel.

### `F:Autodesk.Revit.DB.BuildingType.kManufacturing`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kManufacturing`

#### Summary

Building Type is Manufacturing.

### `F:Autodesk.Revit.DB.BuildingType.kLibrary`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kLibrary`

#### Summary

Building Type is Library.

### `F:Autodesk.Revit.DB.BuildingType.kHotel`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kHotel`

#### Summary

Building Type is Hotel.

### `F:Autodesk.Revit.DB.BuildingType.kHospitalOrHealthcare`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kHospitalOrHealthcare`

#### Summary

Building Type is HospitalOrHealthcare.

### `F:Autodesk.Revit.DB.BuildingType.kGymnasium`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kGymnasium`

#### Summary

Building Type is Gymnasium.

### `F:Autodesk.Revit.DB.BuildingType.kFireStation`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kFireStation`

#### Summary

Building Type is FireStation.

### `F:Autodesk.Revit.DB.BuildingType.kExerciseCenter`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kExerciseCenter`

#### Summary

Building Type is ExerciseCenter.

### `F:Autodesk.Revit.DB.BuildingType.kDormitory`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kDormitory`

#### Summary

Building Type is Dormitory.

### `F:Autodesk.Revit.DB.BuildingType.kDiningFamily`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kDiningFamily`

#### Summary

Building Type is DiningFamily.

### `F:Autodesk.Revit.DB.BuildingType.kDiningCafeteriaFastFood`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kDiningCafeteriaFastFood`

#### Summary

Building Type is DiningCafeteriaFastFood.

### `F:Autodesk.Revit.DB.BuildingType.kDiningBarLoungeOrLeisure`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kDiningBarLoungeOrLeisure`

#### Summary

Building Type is DiningBarLoungeOrLeisure.

### `F:Autodesk.Revit.DB.BuildingType.kCourthouse`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kCourthouse`

#### Summary

Building Type is Courthouse.

### `F:Autodesk.Revit.DB.BuildingType.kConventionCenter`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kConventionCenter`

#### Summary

Building Type is ConventionCenter.

### `F:Autodesk.Revit.DB.BuildingType.kAutomotiveFacility`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kAutomotiveFacility`

#### Summary

Building Type is AutomotiveFacility.

### `F:Autodesk.Revit.DB.BuildingType.kNoOfBuildingTypes`

Member kind: field
Symbol: `Autodesk.Revit.DB.BuildingType.kNoOfBuildingTypes`

#### Summary

Building Type is NoOfBuildingTypes.

### `M:Autodesk.Revit.DB.Structure.BoundaryConditions.GetLoops`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditions.GetLoops`

#### Summary

Returns curve loops that define geometry of the area boundary conditions.

#### Remarks

Boundary conditions should be BoundaryConditionsType::Area type. Otherwise exception is thrown.

#### Returns

The curve loop collection.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidObjectException`

Thrown when BoundaryConditions is not a BoundaryConditionsType::Area type.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.BoundaryConditions.GetCurve`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditions.GetCurve`

#### Summary

Returns curve that define geometry of the line boundary conditions.

#### Remarks

Boundary conditions should be BoundaryConditionsType::Line type. Otherwise exception is thrown.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidObjectException`

Thrown when BoundaryConditions is not a BoundaryConditionsType::Line type.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.BoundaryConditions.GetDegreesOfFreedomCoordinateSystem`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditions.GetDegreesOfFreedomCoordinateSystem`

#### Summary

Gets the origin and rotation of coordinate system that is used by translation and rotation parameters, like X Translation or Z Rotation.

#### Returns

The coordinate system. Origin contains the position of the start of the boundary conditions. BasisX, BasisY and BasisZ contain the directions of the axes in the global coordinate system.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.BoundaryConditions.SetOrientTo(Autodesk.Revit.DB.Structure.BoundaryConditionsOrientTo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditions.SetOrientTo(Autodesk.Revit.DB.Structure.BoundaryConditionsOrientTo)`

#### Summary

Sets the boundary condition orientation option.

#### Parameter `orientTo`

The new orientation option.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.BoundaryConditions.GetOrientTo`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditions.GetOrientTo`

#### Summary

Returns the boundary conditions orientation option.

#### Returns

The orientation option.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.BoundaryConditions.GetBoundaryConditionsType`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditions.GetBoundaryConditionsType`

#### Summary

Returns the boundary conditions type.

#### Returns

The boundary conditions type.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.BoundaryConditions.Point`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditions.Point`

#### Summary

Returns the position of point boundary conditions.

#### Remarks

Boundary conditions should be BoundaryConditionsType::Point type. Otherwise exception is thrown.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidObjectException`

Thrown when BoundaryConditions is not a BoundaryConditionsType::Point type.

### `P:Autodesk.Revit.DB.Structure.BoundaryConditions.AssociatedLoadId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditions.AssociatedLoadId`

#### Summary

The Id of the internal load element associated with a boundary conditions.

#### Remarks

ElementId may be set if the internal load exists and it's type fit the BoundaryConditions type only (Point, Line and Area).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: elementId is not a valid Element identifier.
-or-
When setting this property: Throws when the ElementId does not refer to the internal load with appropriate type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.BoundaryConditions.HostElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditions.HostElementId`

#### Summary

The host element Id for the boundary conditions.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.BoundaryConditions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditions`

#### Summary

An object that represents a force applied across an area.

### `T:Autodesk.Revit.DB.Structure.TranslationRotationValue`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.TranslationRotationValue`

#### Summary

Specifies the type of condition applied to the translation or rotation parameter.

### `F:Autodesk.Revit.DB.Structure.TranslationRotationValue.Spring`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.TranslationRotationValue.Spring`

#### Summary

The type of condition is Spring.

### `F:Autodesk.Revit.DB.Structure.TranslationRotationValue.Release`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.TranslationRotationValue.Release`

#### Summary

The type of condition is Release.

### `F:Autodesk.Revit.DB.Structure.TranslationRotationValue.Fixed`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.TranslationRotationValue.Fixed`

#### Summary

The type of condition is Fixed.

### `T:Autodesk.Revit.DB.Structure.BoundaryConditionsOrientTo`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditionsOrientTo`

#### Summary

Specifies boundary condition orientation.

#### Since

2015

#### Since

2015

### `F:Autodesk.Revit.DB.Structure.BoundaryConditionsOrientTo.HostLocalCoordinateSystem`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditionsOrientTo.HostLocalCoordinateSystem`

#### Summary

Boundary condition is oriented in respect to it analytical host element coordinate system and will follow host changes.

### `F:Autodesk.Revit.DB.Structure.BoundaryConditionsOrientTo.Project`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditionsOrientTo.Project`

#### Summary

Boundary condition is oriented in respect to project global coordinate system, that is X to East, Y to North, and Z to up.

### `T:Autodesk.Revit.DB.Structure.BoundaryConditionsType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditionsType`

#### Summary

This enum declares type of BoundaryConditions.

#### Since

2011

### `F:Autodesk.Revit.DB.Structure.BoundaryConditionsType.Area`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditionsType.Area`

#### Summary

Area Boundary Conditions

### `F:Autodesk.Revit.DB.Structure.BoundaryConditionsType.Line`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditionsType.Line`

#### Summary

Line Boundary Conditions

### `F:Autodesk.Revit.DB.Structure.BoundaryConditionsType.Point`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BoundaryConditionsType.Point`

#### Summary

Point Boundary Conditions

### `M:Autodesk.Revit.DB.BooleanOperationsUtils.CutWithHalfSpaceModifyingOriginalSolidInternal(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Plane,Autodesk.Revit.DB.SolidOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BooleanOperationsUtils.CutWithHalfSpaceModifyingOriginalSolidInternal(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Plane,Autodesk.Revit.DB.SolidOptions)`

#### Summary

Modifies the input Solid preserving only the volume on the positive side of the given Plane. The positive side of the plane is the side to which Plane.Normal points.

#### Parameter `solid`

The input Solid to be cut.

#### Parameter `plane`

The cut plane. The space on the positive side of the normal of the plane will be intersected with the input Solid.

#### Parameter `solidOptions`

The optional information to control the properties of the Solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.BooleanOperationsUtils.CutWithHalfSpaceModifyingOriginalSolidInternal(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Plane)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BooleanOperationsUtils.CutWithHalfSpaceModifyingOriginalSolidInternal(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Plane)`

#### Summary

Modifies the input Solid preserving only the volume on the positive side of the given Plane. The positive side of the plane is the side to which Plane.Normal points.

#### Parameter `solid`

The input Solid to be cut.

#### Parameter `plane`

The cut plane. The space on the positive side of the normal of the plane will be intersected with the input Solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.BooleanOperationsUtils.ExecuteBooleanOperationModifyingOriginalSolidInternal(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.BooleanOperationsType,Autodesk.Revit.DB.SolidOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BooleanOperationsUtils.ExecuteBooleanOperationModifyingOriginalSolidInternal(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.BooleanOperationsType,Autodesk.Revit.DB.SolidOptions)`

#### Summary

Perform a boolean geometric operation between two solids, and modify the original solid to represent the result.

#### Remarks

This operation modifies the original input Geometry object.

#### Parameter `solid0`

The original solid object, can only be the GeometryCreationUtils geometry.

#### Parameter `solid1`

The second solid object. A copy will be taken of the input object, so any solid whether obtained from a Revit element or not would be accepted.

#### Parameter `booleanType`

boolean operation type.

#### Parameter `solidOptions`

The optional information to control the properties of the Solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to perform the Boolean operation for the two solids. This may be due to geometric inaccuracies in the solids, such as slightly misaligned faces or edges.
If so, eliminating the inaccuracies by making sure the solids are accurately aligned may solve the problem. This also may be due to one or both solids having
complexities such as more than two faces geometrically meeting along a single edge, or two coincident edges, etc. Eliminating such conditions, or performing a
sequence of Boolean operations in an order that avoids such conditions, may solve the problem.

#### Since

2012

### `M:Autodesk.Revit.DB.BooleanOperationsUtils.ExecuteBooleanOperationModifyingOriginalSolidInternal(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.BooleanOperationsType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BooleanOperationsUtils.ExecuteBooleanOperationModifyingOriginalSolidInternal(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.BooleanOperationsType)`

#### Summary

Perform a boolean geometric operation between two solids, and modify the original solid to represent the result.

#### Remarks

This operation modifies the original input Geometry object.

#### Parameter `solid0`

The original solid object, can only be the GeometryCreationUtils geometry.

#### Parameter `solid1`

The second solid object. A copy will be taken of the input object, so any solid whether obtained from a Revit element or not would be accepted.

#### Parameter `booleanType`

boolean operation type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to perform the Boolean operation for the two solids. This may be due to geometric inaccuracies in the solids, such as slightly misaligned faces or edges.
If so, eliminating the inaccuracies by making sure the solids are accurately aligned may solve the problem. This also may be due to one or both solids having
complexities such as more than two faces geometrically meeting along a single edge, or two coincident edges, etc. Eliminating such conditions, or performing a
sequence of Boolean operations in an order that avoids such conditions, may solve the problem.

#### Since

2012

### `M:Autodesk.Revit.DB.BooleanOperationsUtils.CutWithHalfSpace(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Plane)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BooleanOperationsUtils.CutWithHalfSpace(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Plane)`

#### Summary

Creates a new Solid which is the intersection of the input Solid with the half-space on the positive side of the given Plane. The positive side of the plane is the side to which Plane.Normal points.

#### Parameter `solid`

The input Solid to be cut.

#### Parameter `plane`

The cut plane. The space on the positive side of the normal of the plane will be intersected with the input Solid.

#### Returns

The newly created Solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.BooleanOperationsUtils.ExecuteBooleanOperation(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.BooleanOperationsType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BooleanOperationsUtils.ExecuteBooleanOperation(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.BooleanOperationsType)`

#### Summary

Perform a boolean geometric operation between two solids, and return a new solid to represent the result.

#### Parameter `solid0`

The first solid object. A copy will be taken of the input object, so any solid whether obtained from a Revit element or not would be accepted.

#### Parameter `solid1`

The second solid object. A copy will be taken of the input object, so any solid whether obtained from a Revit element or not would be accepted.

#### Parameter `booleanType`

boolean operation type.

#### Returns

The result geometry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to perform the Boolean operation for the two solids. This may be due to geometric inaccuracies in the solids, such as slightly misaligned faces or edges.
If so, eliminating the inaccuracies by making sure the solids are accurately aligned may solve the problem. This also may be due to one or both solids having
complexities such as more than two faces geometrically meeting along a single edge, or two coincident edges, etc. Eliminating such conditions, or performing a
sequence of Boolean operations in an order that avoids such conditions, may solve the problem.

#### Since

2012

### `P:Autodesk.Revit.DB.BooleanOperationsUtils.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BooleanOperationsUtils.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.BooleanOperationsUtils.CutWithHalfSpaceModifyingOriginalSolid(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Plane)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BooleanOperationsUtils.CutWithHalfSpaceModifyingOriginalSolid(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Plane)`

#### Summary

Modifies the input Solid preserving only the volume on the positive side of the given Plane. The positive side of the plane is the side to which Plane.Normal points.

#### Remarks

This operation modifies the original input Geometry objects.

#### Parameter `solid`

The input Solid to be cut. This object cannot be obtained directly from a Revit element.
This means that `P:Autodesk.Revit.DB.GeometryObject.IsElementGeometry` cannot be true.

#### Parameter `plane`

The cut plane. The space on the positive side of the normal of the plane will be intersected with the input Solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the original solid object is the geometry of the Revit model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2016

### `M:Autodesk.Revit.DB.BooleanOperationsUtils.ExecuteBooleanOperationModifyingOriginalSolid(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.BooleanOperationsType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BooleanOperationsUtils.ExecuteBooleanOperationModifyingOriginalSolid(Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.Solid,Autodesk.Revit.DB.BooleanOperationsType)`

#### Summary

Perform a boolean geometric operation between two solids, and modify the original solid to represent the result.

#### Remarks

This operation modifies the original input Geometry objects.

#### Parameter `solid0`

The original solid object. This object cannot be obtained directly from a Revit element.
This means that `P:Autodesk.Revit.DB.GeometryObject.IsElementGeometry` cannot be true.

#### Parameter `solid1`

The second solid object. A copy will be taken of the input object, so any solid whether obtained from a Revit element or not would be accepted.

#### Parameter `booleanType`

boolean operation type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the original solid object is the geometry of the Revit model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to perform the Boolean operation for the two solids. This may be due to geometric inaccuracies in the solids, such as slightly misaligned faces or edges.
If so, eliminating the inaccuracies by making sure the solids are accurately aligned may solve the problem. This also may be due to one or both solids having
complexities such as more than two faces geometrically meeting along a single edge, or two coincident edges, etc. Eliminating such conditions, or performing a
sequence of Boolean operations in an order that avoids such conditions, may solve the problem."

#### Since

2012

### `T:Autodesk.Revit.DB.BooleanOperationsUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.BooleanOperationsUtils`

#### Summary

These utilities are applicable for the geometry created by GeometryCreationUtilities and the geometry of Revit model.

#### Since

2012

### `T:Autodesk.Revit.DB.BooleanOperationsType`

Member kind: type
Symbol: `Autodesk.Revit.DB.BooleanOperationsType`

#### Summary

An enumerated type listing boolean types that are supported for boolean operation.

#### Since

2012

### `F:Autodesk.Revit.DB.BooleanOperationsType.Intersect`

Member kind: field
Symbol: `Autodesk.Revit.DB.BooleanOperationsType.Intersect`

#### Summary

Intersect.

### `F:Autodesk.Revit.DB.BooleanOperationsType.Difference`

Member kind: field
Symbol: `Autodesk.Revit.DB.BooleanOperationsType.Difference`

#### Summary

Difference.

### `F:Autodesk.Revit.DB.BooleanOperationsType.Union`

Member kind: field
Symbol: `Autodesk.Revit.DB.BooleanOperationsType.Union`

#### Summary

Union.

### `P:Autodesk.Revit.DB.IConnector.Radius`

Member kind: property
Symbol: `Autodesk.Revit.DB.IConnector.Radius`

#### Summary

The radius of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's shape is not round.

#### Remarks

This property is used to retrieve the radius of the connector.

### `P:Autodesk.Revit.DB.IConnector.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.IConnector.Height`

#### Summary

The height of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's shape is not rectangular.

#### Remarks

This property is used to retrieve the height of the connector.

### `P:Autodesk.Revit.DB.IConnector.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.IConnector.Width`

#### Summary

The width of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the connector's shape is not rectangular.

#### Remarks

This property is used to retrieve the width of the connector.

### `P:Autodesk.Revit.DB.IConnector.Shape`

Member kind: property
Symbol: `Autodesk.Revit.DB.IConnector.Shape`

#### Summary

The shape of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Throw when this connector has no shape.

#### Remarks

This property is used to retrieve the shape of the connector.

### `P:Autodesk.Revit.DB.IConnector.Domain`

Member kind: property
Symbol: `Autodesk.Revit.DB.IConnector.Domain`

#### Summary

The domain of the connector.

#### Remarks

This property is used to retrieve the domain of the connector.

### `P:Autodesk.Revit.DB.IConnector.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.IConnector.Origin`

#### Summary

The location of the connector in family document.

#### Remarks

This property is used to retrieve the origin of the connector.

### `P:Autodesk.Revit.DB.IConnector.CoordinateSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.IConnector.CoordinateSystem`

#### Summary

The coordinate system of the connector.

#### Remarks

The Z axis of the coordinate system is the normal to the plane of the connector.

### `T:Autodesk.Revit.DB.IConnector`

Member kind: type
Symbol: `Autodesk.Revit.DB.IConnector`

#### Summary

An interface which provides access to connector in Autodesk Revit MEP document.

#### Remarks

This interface is shared by `T:Autodesk.Revit.DB.Connector` ,
`T:Autodesk.Revit.DB.ConnectorElement` .

### `P:Autodesk.Revit.Attributes.RegenerationAttribute.Option`

Member kind: property
Symbol: `Autodesk.Revit.Attributes.RegenerationAttribute.Option`

#### Summary

Regeneration option.

#### Since

2011

### `M:Autodesk.Revit.Attributes.RegenerationAttribute.#ctor(Autodesk.Revit.Attributes.RegenerationOption)`

Member kind: method
Symbol: `Autodesk.Revit.Attributes.RegenerationAttribute.#ctor(Autodesk.Revit.Attributes.RegenerationOption)`

#### Summary

Constructs a new RegenerationAttribute.

#### Since

2011

### `T:Autodesk.Revit.Attributes.RegenerationAttribute`

Member kind: type
Symbol: `Autodesk.Revit.Attributes.RegenerationAttribute`

#### Summary

The custom regeneration attribute to control the regeneration behavior of the external command or external application.

#### Since

2011

### `T:Autodesk.Revit.Attributes.RegenerationOption`

Member kind: type
Symbol: `Autodesk.Revit.Attributes.RegenerationOption`

#### Summary

All regeneration options supported by Revit external commands and external applications.

#### Since

2011

### `F:Autodesk.Revit.Attributes.RegenerationOption.Manual`

Member kind: field
Symbol: `Autodesk.Revit.Attributes.RegenerationOption.Manual`

#### Summary

The API framework will not regenerate after every model level change. Instead, you may use the regeneration APIs to force
update of the document after a group of changes. SuspendUpdating blocks are unnecessary and should not be used. Performance of
multiple modifications of the Revit document should be faster than RegenerationOption.Automatic. Because this mode suspends all
updates to the document, your application should not read data from the document after it has been modified until the document
has been regenerated, or it runs the risk of accessing stale data. This mode will be only option in a future release.

### `M:Autodesk.Revit.DB.Structure.AcceptImportedElements.Create(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.AcceptImportedElements.Create(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Creates an AcceptImportedElements failure resolution.

#### Parameter `tempModelLineIds`

The temporary graphics created for showing deleted Revit beams.
If none, pass in an empty ElementIdArr

#### Returns

The newly created AcceptImportedElements instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.Structure.AcceptImportedElements`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AcceptImportedElements`

#### Summary

Allows the import of valid connections if errors occured from others.

### `M:Autodesk.Revit.DB.DeleteElements.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DeleteElements.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates an instance of the DeleteElements resolution.

#### Parameter `document`

The document which owns the element to delete.

#### Parameter `id`

The id of the element that will be deleted when this resolution is chosen.

#### Returns

The instance of the DeletedElements resolution.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input id is not valid for deletion.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.DeleteElements.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DeleteElements.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Creates an instance of the DeleteElements resolution.

#### Parameter `document`

The document which owns the elements to delete.

#### Parameter `ids`

The ids of the elements that will be deleted when this resolution is chosen.

#### Returns

The instance of the DeleteElements resolution.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input ids is empty or contains an invalid element id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.DeleteElements.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DeleteElements.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Creates an instance of the DeleteElements resolution.

#### Parameter `document`

The document which owns the elements to delete.

#### Parameter `ids`

The ids of the elements that will be deleted when this resolution is chosen.

#### Returns

The instance of the DeleteElements resolution.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input ids is empty or contains an invalid element id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.DeleteElements`

Member kind: type
Symbol: `Autodesk.Revit.DB.DeleteElements`

#### Summary

Deletes element(s) related to the failure.

#### Since

2011

### `P:Autodesk.Revit.DB.FailureResolution.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FailureResolution.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FailureResolution`

Member kind: type
Symbol: `Autodesk.Revit.DB.FailureResolution`

#### Summary

Defines a resolution for a failure.

#### Remarks

A failure could have several permitted resolutions. List of applicable resolution types for the specific failure
is defined by the FailureDefinition, actual FailureResolutions are instantiated with the FailureMessage before it is posted.
Multiple resolutions per failure are allowed, although Revit UI only uses default resolution.

#### Since

2011

### `M:Autodesk.Revit.DB.ViewNavigationToolSettings.GetHomeCamera`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewNavigationToolSettings.GetHomeCamera`

#### Summary

Gets a copy of the structure containing information about the store Home view orientation.

#### Returns

A copy of the structure containing information about the store Home view orientation, or
`null` if there is no home view set for this document.

#### Since

2016

### `M:Autodesk.Revit.DB.ViewNavigationToolSettings.IsHomeCameraSet`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewNavigationToolSettings.IsHomeCameraSet`

#### Summary

Checks if the home view is set in the settings.

#### Returns

Returns true if home view is set, otherwise false.

#### Since

2016

### `M:Autodesk.Revit.DB.ViewNavigationToolSettings.GetViewNavigationToolSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewNavigationToolSettings.GetViewNavigationToolSettings(Autodesk.Revit.DB.Document)`

#### Summary

Gets the instance of the settings for the given document.

#### Parameter `pADoc`

The document.

#### Returns

The instance of the settings for the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.ViewNavigationToolSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewNavigationToolSettings`

#### Summary

Represents the settings contained in the document associated to the View Navigation tools (such as the View Cube).

#### Since

2016

### `P:Autodesk.Revit.DB.HomeCamera.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.HomeCamera.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.HomeCamera.ViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.HomeCamera.ViewId`

#### Summary

The id of the view which is associated to this document's Home view orientation.

#### Remarks

A view can be associated to the document's Home view orientation by the View Cube menu option "Set Current View as Home".
Only one view is associated to the Home view orientation at any given time in the document.

#### Since

2016

### `P:Autodesk.Revit.DB.HomeCamera.OrthogonalProjectionHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.HomeCamera.OrthogonalProjectionHeight`

#### Summary

The height of orthogonal projection view volume.

#### Since

2016

### `P:Autodesk.Revit.DB.HomeCamera.OrthogonalProjectionWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.HomeCamera.OrthogonalProjectionWidth`

#### Summary

The width of orthogonal projection view volume.

#### Since

2016

### `P:Autodesk.Revit.DB.HomeCamera.BottomAngleOfFieldOfView`

Member kind: property
Symbol: `Autodesk.Revit.DB.HomeCamera.BottomAngleOfFieldOfView`

#### Summary

The bottom angle of the field of view.

#### Since

2016

### `P:Autodesk.Revit.DB.HomeCamera.TopAngleOfFieldOfView`

Member kind: property
Symbol: `Autodesk.Revit.DB.HomeCamera.TopAngleOfFieldOfView`

#### Summary

The top angle of the field of view.

#### Since

2016

### `P:Autodesk.Revit.DB.HomeCamera.RightAngleOfFieldOfView`

Member kind: property
Symbol: `Autodesk.Revit.DB.HomeCamera.RightAngleOfFieldOfView`

#### Summary

The right angle of the field of view.

#### Since

2016

### `P:Autodesk.Revit.DB.HomeCamera.LeftAngleOfFieldOfView`

Member kind: property
Symbol: `Autodesk.Revit.DB.HomeCamera.LeftAngleOfFieldOfView`

#### Summary

The left angle of the field of view.

#### Since

2016

### `P:Autodesk.Revit.DB.HomeCamera.Pivot`

Member kind: property
Symbol: `Autodesk.Revit.DB.HomeCamera.Pivot`

#### Summary

The pivot point.

#### Since

2016

### `P:Autodesk.Revit.DB.HomeCamera.UpDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.HomeCamera.UpDirection`

#### Summary

The up direction vector.

#### Since

2016

### `P:Autodesk.Revit.DB.HomeCamera.Center`

Member kind: property
Symbol: `Autodesk.Revit.DB.HomeCamera.Center`

#### Summary

The zoom or orbit center.

#### Since

2016

### `P:Autodesk.Revit.DB.HomeCamera.EyePosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.HomeCamera.EyePosition`

#### Summary

The eye position point.

#### Since

2016

### `M:Autodesk.Revit.DB.HomeCamera.#ctor(Autodesk.Revit.DB.HomeCamera)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HomeCamera.#ctor(Autodesk.Revit.DB.HomeCamera)`

#### Summary

Constructs a new copy of the input HomeCamera object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.HomeCamera`

Member kind: type
Symbol: `Autodesk.Revit.DB.HomeCamera`

#### Summary

A structure that contains information about the camera and view for the Home view orientation stored in the model.

#### Since

2016

### `T:Autodesk.Revit.DB.Visual.WaveDistributionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.WaveDistributionType`

#### Summary

The enumerated type representing the permitted values for the asset property "WaveDistribution" from the "Wave" schema.

### `T:Autodesk.Revit.DB.Visual.TileBrickType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.TileBrickType`

#### Summary

The enumerated type representing the permitted values for the asset property "TileBrickType" from the "Tile" schema.

### `T:Autodesk.Revit.DB.Visual.NoiseType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.NoiseType`

#### Summary

The enumerated type representing the permitted values for the asset property "NoiseType" from the "Noise" schema.

### `T:Autodesk.Revit.DB.Visual.GradientType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.GradientType`

#### Summary

The enumerated type representing the permitted values for the asset property "GradientType" from the "Gradient" schema.

### `T:Autodesk.Revit.DB.Visual.GradientNoiseType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.GradientNoiseType`

#### Summary

The enumerated type representing the permitted values for the asset property "GradientNoise" from the "Gradient" schema.

### `T:Autodesk.Revit.DB.Visual.GradientInterpolationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.GradientInterpolationType`

#### Summary

The enumerated type representing the permitted values for the asset property "GradientInterpolation" from the "Gradient" schema.

### `T:Autodesk.Revit.DB.Visual.BumpmapType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.BumpmapType`

#### Summary

The enumerated type representing the permitted values for the asset property "BumpmapType" from the "BumpMap" schema.

### `T:Autodesk.Revit.DB.Visual.WaterTintEnableType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.WaterTintEnableType`

#### Summary

The enumerated type representing the permitted values for the asset property "WaterTintEnable" from the "Water" schema.

### `T:Autodesk.Revit.DB.Visual.WaterType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.WaterType`

#### Summary

The enumerated type representing the permitted values for the asset property "WaterType" from the "Water" schema.

### `T:Autodesk.Revit.DB.Visual.WallpaintApplicationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.WallpaintApplicationType`

#### Summary

The enumerated type representing the permitted values for the asset property "WallpaintApplication" from the "WallPaint" schema.

### `T:Autodesk.Revit.DB.Visual.WallpaintFinishType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.WallpaintFinishType`

#### Summary

The enumerated type representing the permitted values for the asset property "WallpaintFinish" from the "WallPaint" schema.

### `T:Autodesk.Revit.DB.Visual.StonePatternType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.StonePatternType`

#### Summary

The enumerated type representing the permitted values for the asset property "StonePattern" from the "Stone" schema.

### `T:Autodesk.Revit.DB.Visual.StoneBumpType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.StoneBumpType`

#### Summary

The enumerated type representing the permitted values for the asset property "StoneBump" from the "Stone" schema.

### `T:Autodesk.Revit.DB.Visual.StoneApplicationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.StoneApplicationType`

#### Summary

The enumerated type representing the permitted values for the asset property "StoneApplication" from the "Stone" schema.

### `T:Autodesk.Revit.DB.Visual.SolidglassBumpEnableType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.SolidglassBumpEnableType`

#### Summary

The enumerated type representing the permitted values for the asset property "SolidglassBumpEnable" from the "SolidGlass" schema.

### `T:Autodesk.Revit.DB.Visual.SolidglassTransmittanceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.SolidglassTransmittanceType`

#### Summary

The enumerated type representing the permitted values for the asset property "SolidglassTransmittance" from the "SolidGlass" schema.

### `T:Autodesk.Revit.DB.Visual.PlasticvinylPatternType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.PlasticvinylPatternType`

#### Summary

The enumerated type representing the permitted values for the asset property "PlasticvinylPattern" from the "PlasticVinyl" schema.

### `T:Autodesk.Revit.DB.Visual.PlasticvinylBumpType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.PlasticvinylBumpType`

#### Summary

The enumerated type representing the permitted values for the asset property "PlasticvinylBump" from the "PlasticVinyl" schema.

### `T:Autodesk.Revit.DB.Visual.PlasticvinylApplicationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.PlasticvinylApplicationType`

#### Summary

The enumerated type representing the permitted values for the asset property "PlasticvinylApplication" from the "PlasticVinyl" schema.

### `T:Autodesk.Revit.DB.Visual.PlasticvinylType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.PlasticvinylType`

#### Summary

The enumerated type representing the permitted values for the asset property "PlasticvinylType" from the "PlasticVinyl" schema.

### `T:Autodesk.Revit.DB.Visual.MetallicpaintFinishType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.MetallicpaintFinishType`

#### Summary

The enumerated type representing the permitted values for the asset property "MetallicpaintFinish" from the "MetallicPaint" schema.

### `T:Autodesk.Revit.DB.Visual.MetallicpaintTopcoatType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.MetallicpaintTopcoatType`

#### Summary

The enumerated type representing the permitted values for the asset property "MetallicpaintTopcoat" from the "MetallicPaint" schema.

### `T:Autodesk.Revit.DB.Visual.MetallicpaintPearlType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.MetallicpaintPearlType`

#### Summary

The enumerated type representing the permitted values for the asset property "MetallicpaintPearl" from the "MetallicPaint" schema.

### `T:Autodesk.Revit.DB.Visual.MetallicpaintFlecksType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.MetallicpaintFlecksType`

#### Summary

The enumerated type representing the permitted values for the asset property "MetallicpaintFlecks" from the "MetallicPaint" schema.

### `T:Autodesk.Revit.DB.Visual.MetalPerforationsType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.MetalPerforationsType`

#### Summary

The enumerated type representing the permitted values for the asset property "MetalPerforations" from the "Metal" schema.

### `T:Autodesk.Revit.DB.Visual.MetalPatternType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.MetalPatternType`

#### Summary

The enumerated type representing the permitted values for the asset property "MetalPattern" from the "Metal" schema.

### `T:Autodesk.Revit.DB.Visual.MetalFinishType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.MetalFinishType`

#### Summary

The enumerated type representing the permitted values for the asset property "MetalFinish" from the "Metal" schema.

### `T:Autodesk.Revit.DB.Visual.MetalType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.MetalType`

#### Summary

The enumerated type representing the permitted values for the asset property "MetalType" from the "Metal" schema.

### `T:Autodesk.Revit.DB.Visual.MasonryCMUPatternType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.MasonryCMUPatternType`

#### Summary

The enumerated type representing the permitted values for the asset property "MasonryCMUPattern" from the "MasonryCMU" schema.

### `T:Autodesk.Revit.DB.Visual.MasonryCMUApplicationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.MasonryCMUApplicationType`

#### Summary

The enumerated type representing the permitted values for the asset property "MasonryCMUApplication" from the "MasonryCMU" schema.

### `T:Autodesk.Revit.DB.Visual.MasonryCMUType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.MasonryCMUType`

#### Summary

The enumerated type representing the permitted values for the asset property "MasonryCMUType" from the "MasonryCMU" schema.

### `T:Autodesk.Revit.DB.Visual.HardwoodImperfectionsType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.HardwoodImperfectionsType`

#### Summary

The enumerated type representing the permitted values for the asset property "HardwoodImperfections" from the "Hardwood" schema.

### `T:Autodesk.Revit.DB.Visual.HardwoodApplicationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.HardwoodApplicationType`

#### Summary

The enumerated type representing the permitted values for the asset property "HardwoodApplication" from the "Hardwood" schema.

### `T:Autodesk.Revit.DB.Visual.HardwoodFinishType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.HardwoodFinishType`

#### Summary

The enumerated type representing the permitted values for the asset property "HardwoodFinish" from the "Hardwood" schema.

### `T:Autodesk.Revit.DB.Visual.HardwoodTintEnabledType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.HardwoodTintEnabledType`

#### Summary

The enumerated type representing the permitted values for the asset property "HardwoodTintEnabled" from the "Hardwood" schema.

### `T:Autodesk.Revit.DB.Visual.GlazingTransmittanceColorType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.GlazingTransmittanceColorType`

#### Summary

The enumerated type representing the permitted values for the asset property "GlazingTransmittanceColor" from the "Glazing" schema.

### `T:Autodesk.Revit.DB.Visual.ConcreteBrightmodeType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.ConcreteBrightmodeType`

#### Summary

The enumerated type representing the permitted values for the asset property "ConcreteBrightmode" from the "Concrete" schema.

### `T:Autodesk.Revit.DB.Visual.ConcreteFinishType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.ConcreteFinishType`

#### Summary

The enumerated type representing the permitted values for the asset property "ConcreteFinish" from the "Concrete" schema.

### `T:Autodesk.Revit.DB.Visual.ConcreteSealantType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.ConcreteSealantType`

#### Summary

The enumerated type representing the permitted values for the asset property "ConcreteSealant" from the "Concrete" schema.

### `T:Autodesk.Revit.DB.Visual.CommonSharedAssetType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.CommonSharedAssetType`

#### Summary

The enumerated type representing the permitted values for the asset property "CommonSharedAsset" from the "Ceramic" schema.

### `T:Autodesk.Revit.DB.Visual.CeramicPatternType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.CeramicPatternType`

#### Summary

The enumerated type representing the permitted values for the asset property "CeramicPattern" from the "Ceramic" schema.

### `T:Autodesk.Revit.DB.Visual.CeramicBumpType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.CeramicBumpType`

#### Summary

The enumerated type representing the permitted values for the asset property "CeramicBump" from the "Ceramic" schema.

### `T:Autodesk.Revit.DB.Visual.CeramicApplicationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.CeramicApplicationType`

#### Summary

The enumerated type representing the permitted values for the asset property "CeramicApplication" from the "Ceramic" schema.

### `T:Autodesk.Revit.DB.Visual.CeramicType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.CeramicType`

#### Summary

The enumerated type representing the permitted values for the asset property "CeramicType" from the "Ceramic" schema.

### `T:Autodesk.Revit.DB.Visual.WoodPoreType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.WoodPoreType`

#### Summary

The enumerated type representing the permitted values for the asset property "WoodPoreType" from the "AdvancedLayered" schema.

### `T:Autodesk.Revit.DB.Visual.SurfaceNdfType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.SurfaceNdfType`

#### Summary

The enumerated type representing the permitted values for the asset property "SurfaceNdfType" from the "AdvancedLayered" schema.

### `T:Autodesk.Revit.DB.Visual.LayeredNdfType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.LayeredNdfType`

#### Summary

The enumerated type representing the permitted values for the asset property "LayeredNdfType" from the "AdvancedLayered" schema.

### `M:Autodesk.Revit.DB.ViewSection.IsSplitSection`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSection.IsSplitSection`

#### Summary

Sections can be split (jog) so that they cut at >1 plane.

#### Returns

True if the section is split.

#### Since

2021

### `M:Autodesk.Revit.DB.ViewSection.CreateReferenceSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSection.CreateReferenceSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new reference section.

#### Remarks

The reference section will assume the ViewFamilyType of the view it references.

#### Parameter `document`

The document to which the reference section will be added.

#### Parameter `parentViewId`

The view in which the new reference section marker will appear.
Reference sections can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation,
Drafting, and Detail views.

#### Parameter `viewIdToReference`

Detail, Drafting and Section views can be referenced.
The ViewFamilyType of the referenced view will be used by the new reference section.

#### Parameter `headPoint`

Determines the location of the section marker's head in the parent view.

#### Parameter `tailPoint`

Determines the location of the section marker's tail in the parent view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId viewIdToReference does not correspond to a View.
-or-
The ElementId parentViewId does not correspond to a View.
-or-
The parent view and the referenced view must be different views.
-or-
Can't create a new reference sections in parentViewId. Parent views must be
FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, Drafting, or Detail views.
-or-
The viewIdToReference cannot be referenced by reference sections. Only Detail, Drafting and Section views can be referenced.
-or-
headPoint and tailPoint do not differ when projected onto a plane perpendicular to the view direction.
-or-
Reference section view creation is not allowed in this family.

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

### `M:Autodesk.Revit.DB.ViewSection.CreateReferenceCallout(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSection.CreateReferenceCallout(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new reference callout.

#### Remarks

The reference callout will assume the ViewFamilyType of the view it references.
The corners of the callout symbol will be determined by the two point arguments.
The sides of the callout symbol will be aligned to the sides of the parent view's crop region.

#### Parameter `document`

The document to which the new reference callout will be added.

#### Parameter `parentViewId`

The view in which the callout symbol appears.
Callouts can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation,
Drafting, and Detail views.

#### Parameter `viewIdToReference`

The view which will be referenced. The ViewFamilyType of the referenced view will be used
by the new reference callout.
Only cropped views can be referenced, unless the referenced view is a Drafting view.
Drafting views can always be referenced regardless of the parent view type.
Elevation views can be referenced from Elevation and Drafting parent views.
Section views can be referenced from Section and Drafting parent views.
Detail views can be referenced from all parent views except for in FloorPlan, CeilingPlan and
StructuralPlan parent views where only horizontally-oriented Detail views can be referenced.
FloorPlan, CeilingPlan and StructuralPlan views can be referenced from FloorPlan, CeilingPlan
and StructuralPlan parent views.

#### Parameter `point1`

One corner of the callout symbol in the parent view.

#### Parameter `point2`

The other diagonally opposed corner of the callout symbol in the parent view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId viewIdToReference does not correspond to a View.
-or-
The ElementId parentViewId does not correspond to a View.
-or-
The parent view and the referenced view must be different views.
-or-
The parent view does not support reference callouts to views of the ViewFamily used by viewIdToReference.
-or-
point1 and point2 do not differ when projected onto a plane perpendicular to the view direction.
-or-
Callout view creation is not allowed in this family.

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

### `M:Autodesk.Revit.DB.ViewSection.IsViewFamilyTypeValidForCallout(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSection.IsViewFamilyTypeValidForCallout(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

This validator checks that the ViewFamilyType is appropriate for callout views in the
input parent view.

#### Parameter `document`

The document which contains the ViewFamilyType and parent view.

#### Parameter `viewFamilyTypeId`

The id of the ViewFamilyType which will be used by the new callout ViewSection.
Detail ViewFamilyTypes can be used in all parent views except for CeilingPlan and Drafting views.
FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, and Detail ViewFamilyTypes may be
be used in parent views that also use a type with the same ViewFamily enum value.
For example, in StructuralPlan views both StructuralPlan and Detail ViewFamilyTypes are allowed.

#### Parameter `parentViewId`

The view in which the new callout will appear.
Callouts can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation,
and Detail views.

#### Returns

True if the ViewFamilyType can be used for callout views in the parent view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ViewSection.IsParentViewValidForCallout(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSection.IsParentViewValidForCallout(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

This validator checks that the parent view is appropriate for callout views.

#### Parameter `document`

The document which contains the ViewFamilyType and parent view.

#### Parameter `parentViewId`

The view in which the new callout will appear.
Callouts can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation,
and Detail views.

#### Returns

True if the ViewFamilyType can be used for callout views in the parent view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ViewSection.CreateCallout(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSection.CreateCallout(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new callout view.

#### Remarks

The extents of new callout are determined by using the two argument points as the
opposing corners of a rectangle which is aligned to the directions of the parent view.
The callout's near and far cut planes will match those of the parent view.
The new view will receive a unique name.

#### Parameter `document`

The document to which the new callout will be added.

#### Parameter `parentViewId`

The view in which the callout appears.
Callouts can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation,
and Detail views.

#### Parameter `viewFamilyTypeId`

The id of the ViewFamilyType which will be used by the new callout ViewSection.
Detail ViewFamilyTypes can be used in all parent views except for CeilingPlan and Drafting views.
FloorPlan, CeilingPlan, StructuralPlan, Section, and Elevation ViewFamilyTypes may be
be used in parent views that also use a type with the same ViewFamily enum value.
For example, in StructuralPlan parent views both StructuralPlan and Detail ViewFamilyTypes are allowed.

#### Parameter `point1`

Determines the extents of the callout symbol in the parent view.

#### Parameter `point2`

Determine the extents of the callout symbol in the parent view.

#### Returns

The new callout view. The view will be either a ViewSection, ViewPlan or ViewDetail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Non-reference callouts are not allowed in parent views of this type.
-or-
Callouts of the supplied ViewFamilyType are not allowed in the parent view.
-or-
point1 and point2 do not differ when projected onto a plane perpendicular to the view direction.
-or-
Callout view creation is not allowed in this family.

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

### `M:Autodesk.Revit.DB.ViewSection.CreateDetail(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.BoundingBoxXYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSection.CreateDetail(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.BoundingBoxXYZ)`

#### Summary

Returns a new detail ViewSection.

#### Remarks

Create a detail ViewSection whose view volume corresponds geometrically with the specified sectionBox.
The view direction of the resulting section will be sectionBox.Transform.BasisZ and the up direction will
be sectionBox.Transform.BasisY. The right hand direction will be computed so that (right, up, view direction)
form a left handed coordinate system.

The resulting view will be cropped, and far clipping will be active.
The crop region will correspond to the projections of BoundingBoxXYZ.Min and BoundingBoxXYZ.Max onto the view's cut plane.
The far clip distance will be equal to the difference of the z-coordinates of BoundingBoxXYZ.Min and BoundingBoxXYZ.Max.

The new detail ViewSection will receive a unique view name.

#### Parameter `document`

The document to which the new detail ViewSection will be added.

#### Parameter `viewFamilyTypeId`

The id of the ViewFamilyType which will be used by the new detail ViewSection. The type needs to be a Detail ViewFamily.

#### Parameter `sectionBox`

The BoundingBoxXYZ which specifies the new ViewSection's view direction and extents.

#### Returns

The new detail ViewSection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ViewFamilyType must be a Detail ViewFamily.
-or-
The BoundingBoxXYZ is not appropriate for detail views.
The basis vectors of must be unit length and orthonormal.
The near and far bound offsets cannot be reversed or too close to each other.
MinEnabled and MaxEnabled must be set to true for all three directions.
-or-
Detail section view creation is not allowed in this family.

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

### `M:Autodesk.Revit.DB.ViewSection.CreateSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.BoundingBoxXYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSection.CreateSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.BoundingBoxXYZ)`

#### Summary

Returns a new section ViewSection.

#### Remarks

Create a section whose view volume corresponds geometrically with the specified sectionBox.
The view direction of the resulting section will be sectionBox.Transform.BasisZ and the up direction will
be sectionBox.Transform.BasisY. The right hand direction will be computed so that (right, up, view direction)
form a left handed coordinate system.

The resulting view will be cropped, and far clipping will be active.
The crop region will correspond to the projections of BoundingBoxXYZ.Min and BoundingBoxXYZ.Max onto the view's cut plane.
The far clip distance will be equal to the difference of the z-coordinates of BoundingBoxXYZ.Min and BoundingBoxXYZ.Max.

The new section ViewSection will receive a unique view name.

#### Parameter `document`

The document to which the new section ViewSection will be added.

#### Parameter `viewFamilyTypeId`

The id of the ViewFamilyType which will be used by the new section ViewSection. The type needs to be a Section ViewFamily.

#### Parameter `sectionBox`

The BoundingBoxXYZ which specifies the new ViewSection's view direction and extents.

#### Returns

The new section ViewSection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ViewFamilyType must be a Section ViewFamily.
-or-
The BoundingBoxXYZ is not appropriate for detail views.
The basis vectors of must be unit length and orthonormal.
The near and far bound offsets cannot be reversed or too close to each other.
MinEnabled and MaxEnabled must be set to true for all three directions.
-or-
Section view creation is not allowed in this family.

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

### `T:Autodesk.Revit.DB.ViewSection`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewSection`

#### Summary

ViewSection covers sections, details, elevations, and callouts, all in their reference and non-reference variations.

#### Remarks

The creation functions for elevations can be found in the ElevationMarker class.

### `M:Autodesk.Revit.DB.ReferenceableViewUtils.ChangeReferencedView(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceableViewUtils.ChangeReferencedView(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Changes a particular reference view (such as a reference section or reference callout) to refer to a different View.

#### Remarks

Reference views may not refer to a View in which their own graphics (such as the section or callout
graphics) will appear. If the reference view's ViewFamilyType is not appropriate
for the new View, Revit will automatically change the ViewFamilyType during regeneration. This
typically occurs when the referenced view is changed from a model View to a drafting View or
vice-versa.

#### Parameter `document`

The document containing the elements.

#### Parameter `referenceId`

The reference view that will be changed to refer to a different View.

#### Parameter `desiredViewId`

The id of the View that the reference section or callout will refer to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

referenceId is not a valid reference view.
-or-
desiredViewId is not a view that can be referenced by referenceId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ReferenceableViewUtils.GetReferencedViewId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceableViewUtils.GetReferencedViewId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the id of the view referenced by a reference view (such as a reference section or reference callout).

#### Parameter `document`

The document containing the elements.

#### Parameter `referenceId`

The reference view that will be changed to refer to a different View.

#### Returns

The id of the referenced view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

referenceId is not a valid reference view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.ReferenceableViewUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReferenceableViewUtils`

#### Summary

Utilities related to reference views such as reference sections and reference callouts.

#### Since

2015

### `M:Autodesk.Revit.DB.ViewSchedule.GetTableData`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetTableData`

#### Summary

Gets the writable table data object.

#### Returns

The schedule data object.

#### Since

2014

### `M:Autodesk.Revit.DB.ViewSchedule.IsValidTextTypeId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.IsValidTextTypeId(Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if the input id represents a valid text type id for use in the schedule properties.

#### Parameter `textTypeId`

The element id of the text type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ViewSchedule.Export(System.String,System.String,Autodesk.Revit.DB.ViewScheduleExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.Export(System.String,System.String,Autodesk.Revit.DB.ViewScheduleExportOptions)`

#### Summary

Exports the schedule data to a text file.

#### Parameter `folder`

Path to the location where the file will be saved.

#### Parameter `name`

Name of file.

#### Parameter `options`

Options that relate to schedule export.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

NullOrEmpty
-or-
Contains invalid characters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The path indicated could not be accessed.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The folder does not exist.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewSchedule.SetStripedRowsColor(Autodesk.Revit.DB.StripedRowPattern,Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.SetStripedRowsColor(Autodesk.Revit.DB.StripedRowPattern,Autodesk.Revit.DB.Color)`

#### Summary

Sets the color applied to part of the pattern for a schedule with striped rows.

#### Parameter `index`

The part of the striped row pattern.

#### Parameter `color`

The color which will be used in striped row pattern.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2021

### `M:Autodesk.Revit.DB.ViewSchedule.GetStripedRowsColor(Autodesk.Revit.DB.StripedRowPattern)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetStripedRowsColor(Autodesk.Revit.DB.StripedRowPattern)`

#### Summary

Gets the color applied to part of the pattern for a schedule with striped rows.

#### Parameter `index`

The part of the striped row pattern.

#### Returns

The applied color of the pattern part.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2021

### `M:Autodesk.Revit.DB.ViewSchedule.HasImageField`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.HasImageField`

#### Summary

Checks whether the schedule definition includes any image-related fields and if any elements in the schedule actually have images in those fields.

#### Remarks

This method may return an incorrect value if the data of the schedule view is out of date. Check `!:IsDataOutOfData()` ,
and call `M:Autodesk.Revit.DB.ViewSchedule.RefreshData` to ensure that the return value is correct.

#### Returns

True if the schedule has at least one image field showing at least one image, false otherwise.

#### Since

2015

### `M:Autodesk.Revit.DB.ViewSchedule.RestoreImageSize`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.RestoreImageSize`

#### Summary

Restores all images to their original sizes.

#### Remarks

All images in the schedule will be restored to their original sizes when viewed as a ScheduleSheetInstance on a ViewSheet.
This reverts any changes made by setting `P:Autodesk.Revit.DB.ViewSchedule.RowHeight` . Calling this method has no effect if HasImageField is false.

In the schedule view the column widths will be adjusted to match the image sizes, but only the name of the image will be shown.
For example, the users can attach different images to the kinds of rebar instances. These images may have different sizes.
When the users create the rebar schedule with this image field, by default the column width of this image field is equal to other fields,
which means it is not associated with the image original sizes during the schedule creation.

#### Since

2015

### `M:Autodesk.Revit.DB.ViewSchedule.UngroupHeaders(System.Int32,System.Int32,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.UngroupHeaders(System.Int32,System.Int32,System.Int32,System.Int32)`

#### Summary

Ungroups selected headers of schedule.

#### Parameter `top`

The index of the top row of the selected headers.

#### Parameter `left`

The index of the left column of the selected headers.

#### Parameter `bottom`

The index of the bottom row of the selected headers.

#### Parameter `right`

The index of the right column of the selected headers.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Headers could not be ungrouped.

#### Since

2014

### `M:Autodesk.Revit.DB.ViewSchedule.CanUngroupHeaders(System.Int32,System.Int32,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.CanUngroupHeaders(System.Int32,System.Int32,System.Int32,System.Int32)`

#### Summary

Indicates if selected headers can be ungrouped.

#### Parameter `top`

The index of the top row of the selected headers.

#### Parameter `left`

The index of the left column of the selected headers.

#### Parameter `bottom`

The index of the bottom row of the selected headers.

#### Parameter `right`

The index of the right column of the selected headers.

#### Returns

True if the selected headers can be grouped, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.ViewSchedule.GroupHeaders(System.Int32,System.Int32,System.Int32,System.Int32,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GroupHeaders(System.Int32,System.Int32,System.Int32,System.Int32,System.String)`

#### Summary

Groups schedule header cells.

#### Parameter `top`

The index of the top row of the selected headers.

#### Parameter `left`

The index of the left column of the selected headers.

#### Parameter `bottom`

The index of the bottom row of the selected headers.

#### Parameter `right`

The index of the right column of the selected headers.

#### Parameter `caption`

The header caption.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Headers could not be grouped.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ViewSchedule.CanGroupHeaders(System.Int32,System.Int32,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.CanGroupHeaders(System.Int32,System.Int32,System.Int32,System.Int32)`

#### Summary

Indicates if selected headers can be grouped for this schedule.

#### Parameter `top`

The index of the top row of the selected headers.

#### Parameter `left`

The index of the left column of the selected headers.

#### Parameter `bottom`

The index of the bottom row of the selected headers.

#### Parameter `right`

The index of the right column of the selected headers.

#### Returns

True if the selected headers can be grouped, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.ViewSchedule.GetScheduleHeightsOnSheet`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetScheduleHeightsOnSheet`

#### Summary

Gets the heights of schedule title, column header and each schedule body row.

#### Remarks

The height is Revit's internal units value.

#### Returns

The ScheduleHeightsOnSheet which contains heights information of a schedule on sheet.

#### Since

2022.1

### `M:Autodesk.Revit.DB.ViewSchedule.MergeSegments(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.MergeSegments(System.Int32,System.Int32)`

#### Summary

Merges two adjacent segments into one.

#### Remarks

Only adjacent segments can be merged. The moved segment will be deleted with all its instances
on sheet and all the data will be merged into the target segment with height expanded.

#### Parameter `movedSegmentIndex`

The index of the moved segment.

#### Parameter `targetSegmentIndex`

The index of the target segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Only two adjacent segments can be merged.
-or-
The segment index should start from 0 and be less than the total segment count.

#### Since

2022.1

### `M:Autodesk.Revit.DB.ViewSchedule.GetScheduleInstances(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetScheduleInstances(System.Int32)`

#### Summary

Gets the instances ids of schedule or schedule segment.

#### Remarks

The segment index value could be -1, it means to get schedule instances for the entire schedule.

When a (primary) schedule is set to filter by sheet and placed on a sheet, it will create a new schedule with elements visible
in the Viewport(s) on that sheet. The instance created belongs to the newly created schedule. Calls to GetScheduleInstances()
will return instances of the newly created schedule but no instances of the primary schedule.

#### Parameter `segmentIndex`

Index of the segment.

#### Returns

The array of schedule sheet instance element ids of schedule or schedule segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The segment index should start from -1 and be less than the total segment count.

#### Since

2022.1

### `M:Autodesk.Revit.DB.ViewSchedule.GetSegmentHeight(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetSegmentHeight(System.Int32)`

#### Summary

Gets the segment height.

#### Remarks

The height is Revit's internal units value of schedule header and segment body.
The real height of segment on sheet may be less than the segment height get here.
It is the border height of segment instance on sheet.
The last segment height get here is the max value of double as the last segment height is not set
to a fix value. It will be determined by whole schedule height and other segments' heights. And the border for it is max value of double.

#### Parameter `segmentIndex`

Zero-based index of the segment.

#### Returns

The segment height value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The segment index should start from 0 and be less than the total segment count.

#### Since

2022.1

### `M:Autodesk.Revit.DB.ViewSchedule.SetSegmentHeight(System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.SetSegmentHeight(System.Int32,System.Double)`

#### Summary

Sets the segment height.

#### Remarks

The height is Revit's internal units value of schedule header and segment body.
The last segment can not set height. Its height will be determined by whole schedule height and other segments' heights.
The height will not be the exact segment height on sheet. It will be the border height of the instance. The real height
will be determined by the segment content. If the row cannot be shown within the instance boder, it will flow to the next segment.

#### Parameter `segmentIndex`

Index of the segment.

#### Parameter `height`

New height for the segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

segmentIndex must be between 0 and the last second of all segments.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for height must be greater than 0 and no more than 30000 feet.

#### Since

2022.1

### `M:Autodesk.Revit.DB.ViewSchedule.GetSegmentCount`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.GetSegmentCount`

#### Summary

Gets the total count of schedule segments.

#### Remarks

There will be at least one segment for a schedule.

#### Returns

The total count of schedule segments. 1 means the schedule is not split yet.

#### Since

2022.1

### `M:Autodesk.Revit.DB.ViewSchedule.DeleteSegment(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.DeleteSegment(System.Int32)`

#### Summary

Deletes a schedule segment.

#### Remarks

If the last segment is deleted, the previous one will be the last one and its height will be modified to unlimited.
If one segment is deleted when there are only two segments, all the instances will be deleted and the schedule
will become unsplit again.

#### Parameter `segmentIndex`

Zero-based index of the segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The segment index should start from 0 and be less than the total segment count.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ViewSchedule is not split yet.

#### Since

2022.1

### `M:Autodesk.Revit.DB.ViewSchedule.SplitSegment(System.Int32,System.Collections.Generic.IList{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.SplitSegment(System.Int32,System.Collections.Generic.IList{System.Double})`

#### Summary

Splits the schedule segment by the given heights of new segments.

#### Remarks

The height values are used to set the height of schedule instance for each segment shown on sheet view.
Each input height must be greater than 0 and the total height must be less than the height of the split segment.

#### Parameter `segmentIndex`

The index of segment, starting with 0.

#### Parameter `segmentHeights`

An array contains the height for each new segment except the last segment.
The height of the last segment will be determined by the height of previous new segments and the height of the split segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The height of a schedule segment must be greater than 0. The total height must be less than the split segment height.
The total segment count must be greater than 0 and less than 10000.
-or-
The segment index should start from 0 and be less than the total segment count.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ViewSchedule is not split yet.

#### Since

2022.1

### `M:Autodesk.Revit.DB.ViewSchedule.Split(System.Collections.Generic.IList{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.Split(System.Collections.Generic.IList{System.Double})`

#### Summary

Splits the schedule into several segments by given height of each segment.

#### Remarks

A schedule can be split only when it is not split yet.

A titleblock revision schedule cannot be split.

Once a sheet specific schedule, i.e., the schedule is filtered by sheet, is split,
the segments will be placed on its sheet view immediately.
The height values are used to set the height limits of the schedule instances of each segment
except the last segment shown on the sheet view.

The height limit of the last segment cannot be set, because the height of the schedule instances of the last segment
will be determined by the schedule instances of previous segments and the height of the whole schedule.

All height values must be greater than 0.

Also check `!:setSegmentHeight` .

#### Parameter `segmentHeights`

An array contains the height limit of each segment except the last segment.
The height is the value for segment body.
The height is Revit's internal units value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The height of a schedule segment must be greater than 0 and no more than 30000 feet. The total segment count must be greater than 0 and less than 10000.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Revision schedules cannot be split.
-or-
A schedule filtered by sheet can't be split.
-or-
This ViewSchedule is split.

#### Since

2022.1

### `M:Autodesk.Revit.DB.ViewSchedule.Split(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.Split(System.Int32)`

#### Summary

Splits the schedule into several segments by given segment number.

#### Remarks

The segment number must be greater than 0.

A schedule can be split only when it is not split yet.

A titleblock revision schedule cannot be split.

Once a sheet specific schedule, i.e., the schedule is filtered by sheet, is split,
the segments will be placed on its sheet view immediately.
After split, all segments will have even height limits based on the schedule height and segment number
except the last segment shown on the sheet view.

The height limit of the last segment cannot be set, because the height of the schedule
instances of the last segment will be determined by the schedule instances of previous
segments and the height of the whole schedule.

Check `M:Autodesk.Revit.DB.ViewSchedule.SetSegmentHeight(System.Int32,System.Double)` to see more about segment height.

#### Parameter `segmentNumber`

The segment number.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The segment number must be greater than 1.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Revision schedules cannot be split.
-or-
A schedule filtered by sheet can't be split.
-or-
This ViewSchedule is split.

#### Since

2022.1

### `M:Autodesk.Revit.DB.ViewSchedule.IsSplit`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.IsSplit`

#### Summary

Checks if the schedule is split.

#### Returns

True if the schedule is split. Otherwise false.

#### Since

2022.1

### `M:Autodesk.Revit.DB.ViewSchedule.RefreshData`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSchedule.RefreshData`

#### Summary

Rebuilds the schedule data if it is out of date.

#### Returns

True if the data is up to date after the refresh.

#### Since

2014
