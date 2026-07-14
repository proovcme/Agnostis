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
Shard: 40
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetDamperName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetDamperName(System.Int32)`

#### Summary

Gets the damper name from its identifier.

#### Parameter `damperId`

The damper identifier.

#### Returns

The damper name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The damper does not exist.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAllDampers`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAllDampers`

#### Summary

Gets all damper identifiers in the fabrication configuration.

#### Returns

An array of specification identifiers.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetSpecificationGroup(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetSpecificationGroup(System.Int32)`

#### Summary

Gets the specification group from its identifier.

#### Parameter `specId`

The specification identifier.

#### Returns

The specification group.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetSpecificationName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetSpecificationName(System.Int32)`

#### Summary

Gets the specification name from its identifier.

#### Parameter `specId`

The specification identifier.

#### Returns

The specification name;

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.LocateSpecification(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.LocateSpecification(System.String,System.String)`

#### Summary

Gets the specification identifier by group and name.

#### Parameter `group`

The specification group.

#### Parameter `name`

The specification name.

#### Returns

The specification identifier. Returns -1 if not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAllSpecifications(Autodesk.Revit.DB.FabricationPart)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAllSpecifications(Autodesk.Revit.DB.FabricationPart)`

#### Summary

Gets all specification identifiers in the fabrication configuration.

#### Remarks

If a part is passed, only returns specifications which are valid for the part, otherwise returns all specifications.

#### Parameter `part`

The fabrication part.

#### Returns

An array of specification identifiers.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetService(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetService(System.Int32)`

#### Summary

Get the service based on the service identifier from the fabrication configuration in the current document.

#### Parameter `serviceId`

The service identifier.

#### Returns

The service based on the service identifier.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.UnloadItemFiles(System.Collections.Generic.IList{Autodesk.Revit.DB.FabricationItemFile})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.UnloadItemFiles(System.Collections.Generic.IList{Autodesk.Revit.DB.FabricationItemFile})`

#### Summary

Unload the specified fabrication item files from the project.

#### Parameter `itemFiles`

The fabrication item files to unload.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Fabrication item files can not be unloaded if they are currently in use.
-or-
Some fabrication item files have not been loaded.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The current fabrication configuration is not connected and updated to source configuration. Reload and try again.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfiguration.UnloadServices(System.Collections.Generic.IList{System.Int32})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.UnloadServices(System.Collections.Generic.IList{System.Int32})`

#### Summary

Unload the specified fabrication services from the project.

#### Parameter `serviceIds`

The identifiers of the fabrication services to unload.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Fabrication services can not be unloaded if they are in use currently.
-or-
Some services are not loaded yet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The current fabrication configuration is not connected and updated to source configuration. Reload and try again.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.AreItemFilesLoaded(System.Collections.Generic.IList{Autodesk.Revit.DB.FabricationItemFile})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.AreItemFilesLoaded(System.Collections.Generic.IList{Autodesk.Revit.DB.FabricationItemFile})`

#### Summary

Checks if the fabrication item files have been loaded.

#### Parameter `itemFiles`

The fabrication item files.

#### Returns

Returns true if the fabrication item files have been loaded, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfiguration.CanUnloadItemFiles(System.Collections.Generic.IList{Autodesk.Revit.DB.FabricationItemFile})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.CanUnloadItemFiles(System.Collections.Generic.IList{Autodesk.Revit.DB.FabricationItemFile})`

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

### `M:Autodesk.Revit.DB.FabricationConfiguration.LoadItemFiles(System.Collections.Generic.IList{Autodesk.Revit.DB.FabricationItemFile})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.LoadItemFiles(System.Collections.Generic.IList{Autodesk.Revit.DB.FabricationItemFile})`

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

### `M:Autodesk.Revit.DB.FabricationConfiguration.LoadServices(System.Collections.Generic.IList{System.Int32})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.LoadServices(System.Collections.Generic.IList{System.Int32})`

#### Summary

Loads the specified fabrication services into the project.

#### Parameter `serviceIds`

The identifiers of the fabrication services to load.

#### Returns

The identifiers of the fabrication services which failed to load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The current fabrication configuration is not connected and updated to source configuration. Reload and try again.
-or-
this operation failed.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAllUsedItemFiles`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAllUsedItemFiles`

#### Summary

Returns all the used fabrication item files. A fabrication item file is used if any fabrication parts in the model were created from it.

#### Returns

All the used fabrication item files.

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAllUsedServices`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAllUsedServices`

#### Summary

Returns all the used fabrication services. A service is used if any fabrication part in the service is created by user.

#### Returns

All the used fabrication services.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.SetServicesToLoad(System.Collections.Generic.IList{System.Int32})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.SetServicesToLoad(System.Collections.Generic.IList{System.Int32})`

#### Summary

Sets the services which are to be loaded or not next time reloadConfiguration is called. If a service is not included but is currently loaded then it will be unloaded then.

#### Returns

Returns true if successful. May fail if any service currently loaded is not included and is in use so cannot be unloaded.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAllLoadedServices`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAllLoadedServices`

#### Summary

Returns all the loaded fabrication services.

#### Returns

All the loaded fabrication services.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetAllServices`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetAllServices`

#### Summary

Returns all fabrication services in the fabrication configuration.

#### Returns

All fabrication services. The return will be empty if no services are found.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetProfile`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetProfile`

#### Summary

Return the profile of the loaded fabrication configuration. Return empty string for global profile.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.SetConfiguration(Autodesk.Revit.DB.FabricationConfigurationInfo,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.SetConfiguration(Autodesk.Revit.DB.FabricationConfigurationInfo,System.String)`

#### Summary

Set the fabrication configuration with specific profile.

#### Parameter `fabricationConfigurationInfo`

The desired fabrication configuration.

#### Parameter `profile`

The desired profile of the fabrication configuration. Use empty string for the global profile.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The profile "profile" is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The fabrication configuration cannot be swapped because the exiting fabrication configuration has already been used in the document.
-or-
Cannot set the configuration.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.SetConfiguration(Autodesk.Revit.DB.FabricationConfigurationInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.SetConfiguration(Autodesk.Revit.DB.FabricationConfigurationInfo)`

#### Summary

Set the fabrication configuration with global profile.

#### Parameter `fabricationConfigurationInfo`

The desired fabrication configuration.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The fabrication configuration cannot be swapped because the exiting fabrication configuration has already been used in the document.
-or-
Cannot set the configuration.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.ReloadConfiguration`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.ReloadConfiguration`

#### Summary

Reloads the fabrication configuration from its source fabrication configuration.

#### Remarks

The configuration must be reloaded from its source fabrication configuration before loading new fabrication services or additional parts.

#### Returns

The information about the reload of the fabrication configuration.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The fabrication configuration is not set yet.
-or-
The source fabrication configuration could not be found.
-or-
this operation failed.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.CanBeSwapped`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.CanBeSwapped`

#### Summary

Checks if the fabrication configuration can be swapped.

#### Remarks

Swapping configuration is not permitted if the existing configuration has already been used to create fabrication part elements in the document.

#### Returns

True if the fabrication configuration can be swapped, false otherwise.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetFabricationConfigurationInfo`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetFabricationConfigurationInfo`

#### Summary

Gets the information about the fabrication configuration of the project.

#### Returns

The information about the fabrication configuration of the project.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.HasValidConfiguration`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.HasValidConfiguration`

#### Summary

Checks whether a valid fabrication configuration has been set for the project.

#### Returns

True if a valid fabrication configuration has been set for the project.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfiguration.GetFabricationConfiguration(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfiguration.GetFabricationConfiguration(Autodesk.Revit.DB.Document)`

#### Summary

Gets the fabrication configuration element in the document.

#### Parameter `document`

The document.

#### Returns

The fabrication configuration element in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.FabricationConfiguration`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationConfiguration`

#### Summary

This element contains the information about the fabrication configuration settings used by the project.

#### Remarks

The element provides information about the location of the fabrication database, its properties, and settings related to fabrication items.

#### Since

2016

### `M:Autodesk.Revit.DB.ConfigurationReloadInfo.IsValidSwapIndex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConfigurationReloadInfo.IsValidSwapIndex(System.Int32)`

#### Summary

validate swap index.

#### Since

2016

### `M:Autodesk.Revit.DB.ConfigurationReloadInfo.GetOutOfDatePartStatus(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConfigurationReloadInfo.GetOutOfDatePartStatus(System.Int32)`

#### Summary

Access reload information for out of date part.

#### Parameter `index`

The index of the information about the part being reloaded. Must be between 0 and OutOfDatePartCount.

#### Returns

Information about the part being reloaded.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The index is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2019

### `M:Autodesk.Revit.DB.ConfigurationReloadInfo.GetConnectivityValidation`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConfigurationReloadInfo.GetConnectivityValidation`

#### Summary

Returns information about the post-reload connectivity validation.

#### Returns

Information about the post-reload connectivity validation.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2016

### `M:Autodesk.Revit.DB.ConfigurationReloadInfo.GetCustomDataChangedElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConfigurationReloadInfo.GetCustomDataChangedElements`

#### Summary

Gets a list of ElementIds of fabrication parts that had custom data updated during the reload.

#### Returns

A list identifying changed elements.

#### Since

2019

### `P:Autodesk.Revit.DB.ConfigurationReloadInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConfigurationReloadInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ConfigurationReloadInfo.OutOfDatePartCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConfigurationReloadInfo.OutOfDatePartCount`

#### Summary

The number of fabrication part instances that had newer versions and were out of date.

#### Since

2019

### `P:Autodesk.Revit.DB.ConfigurationReloadInfo.ProfileNotAvailable`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConfigurationReloadInfo.ProfileNotAvailable`

#### Summary

The current profile is not available in the disk configuration.

#### Since

2016

### `P:Autodesk.Revit.DB.ConfigurationReloadInfo.Disconnects`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConfigurationReloadInfo.Disconnects`

#### Summary

The number of disconnections caused by the reload.

#### Since

2016

### `M:Autodesk.Revit.DB.ConfigurationReloadInfo.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConfigurationReloadInfo.#ctor`

#### Summary

Constructor.

#### Since

2016

### `T:Autodesk.Revit.DB.ConfigurationReloadInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.ConfigurationReloadInfo`

#### Summary

This object contains information returned by a reload of the fabrication configuration.

#### Since

2016

### `P:Autodesk.Revit.DB.ReloadSwapOutInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReloadSwapOutInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ReloadSwapOutInfo.CurrentVersion`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReloadSwapOutInfo.CurrentVersion`

#### Summary

New version.

#### Since

2019

### `P:Autodesk.Revit.DB.ReloadSwapOutInfo.PreviousVersion`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReloadSwapOutInfo.PreviousVersion`

#### Summary

Previous version.

#### Since

2019

### `P:Autodesk.Revit.DB.ReloadSwapOutInfo.WasSwapped`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReloadSwapOutInfo.WasSwapped`

#### Summary

Whether the swap out was successful.

#### Since

2019

### `P:Autodesk.Revit.DB.ReloadSwapOutInfo.Part`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReloadSwapOutInfo.Part`

#### Summary

The ElementId of part being swapped.

#### Since

2019

### `T:Autodesk.Revit.DB.ReloadSwapOutInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReloadSwapOutInfo`

#### Summary

This object contains information about fabrication parts swapped out during reload.

#### Since

2019

### `P:Autodesk.Revit.DB.FabricationVersionInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationVersionInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FabricationVersionInfo.Reason`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationVersionInfo.Reason`

#### Summary

The user-specified reason for the change.

#### Since

2019

### `P:Autodesk.Revit.DB.FabricationVersionInfo.Version`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationVersionInfo.Version`

#### Summary

The version number of the change.

#### Since

2019

### `T:Autodesk.Revit.DB.FabricationVersionInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationVersionInfo`

#### Summary

The object contains versioning information about fabrication data.

#### Since

2019

### `M:Autodesk.Revit.DB.ConnectionValidationInfo.GetWarning(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectionValidationInfo.GetWarning(System.Int32)`

#### Summary

Access specific warning number of warnings generated by reload.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid index.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2016

### `M:Autodesk.Revit.DB.ConnectionValidationInfo.IsValidWarningIndex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectionValidationInfo.IsValidWarningIndex(System.Int32)`

#### Summary

Validate warning index.

#### Since

2016

### `M:Autodesk.Revit.DB.ConnectionValidationInfo.ManyWarnings`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectionValidationInfo.ManyWarnings`

#### Summary

Returns number of warnings generated by reload.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2016

### `P:Autodesk.Revit.DB.ConnectionValidationInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectionValidationInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.ConnectionValidationInfo.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectionValidationInfo.#ctor`

#### Summary

Constructor.

#### Since

2016

### `T:Autodesk.Revit.DB.ConnectionValidationInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.ConnectionValidationInfo`

#### Summary

This object contains information about fabrication connection validations.

#### Since

2016

### `M:Autodesk.Revit.DB.ConnectionValidationWarning.GetParts`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectionValidationWarning.GetParts`

#### Summary

Get ElementIds of affected parts.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2016

### `P:Autodesk.Revit.DB.ConnectionValidationWarning.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectionValidationWarning.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ConnectionValidationWarning.Reason`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectionValidationWarning.Reason`

#### Summary

Enumeration for reason of warning.

#### Since

2016

### `P:Autodesk.Revit.DB.ConnectionValidationWarning.Resolution`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectionValidationWarning.Resolution`

#### Summary

Enumeration for resolution that was applied.

#### Since

2016

### `M:Autodesk.Revit.DB.ConnectionValidationWarning.#ctor(Autodesk.Revit.DB.ConnectionResolution,Autodesk.Revit.DB.ConnectionWarning,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectionValidationWarning.#ctor(Autodesk.Revit.DB.ConnectionResolution,Autodesk.Revit.DB.ConnectionWarning,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Constructor.

#### Parameter `resolution`

Resolution type.

#### Parameter `reason`

Warning reason.

#### Parameter `part1`

First element Id.

#### Parameter `part2`

Second element Id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `T:Autodesk.Revit.DB.ConnectionValidationWarning`

Member kind: type
Symbol: `Autodesk.Revit.DB.ConnectionValidationWarning`

#### Summary

Contains information about a specific connection validation problem.

#### Since

2016

### `T:Autodesk.Revit.DB.ConnectionWarning`

Member kind: type
Symbol: `Autodesk.Revit.DB.ConnectionWarning`

#### Summary

An enumerated type listing all the reasons for connectivity failure.

#### Since

2016

### `F:Autodesk.Revit.DB.ConnectionWarning.Connectivity`

Member kind: field
Symbol: `Autodesk.Revit.DB.ConnectionWarning.Connectivity`

#### Summary

Value for fabrication Connectivity Mismatch.

### `F:Autodesk.Revit.DB.ConnectionWarning.Shape`

Member kind: field
Symbol: `Autodesk.Revit.DB.ConnectionWarning.Shape`

#### Summary

Value for shapes didn't match.

### `F:Autodesk.Revit.DB.ConnectionWarning.Size`

Member kind: field
Symbol: `Autodesk.Revit.DB.ConnectionWarning.Size`

#### Summary

Value for sizes didn't match.

### `F:Autodesk.Revit.DB.ConnectionWarning.Alignment`

Member kind: field
Symbol: `Autodesk.Revit.DB.ConnectionWarning.Alignment`

#### Summary

Value for parts were moved when rebuilt so that connectors were no longer aligned.

### `F:Autodesk.Revit.DB.ConnectionWarning.Unknown`

Member kind: field
Symbol: `Autodesk.Revit.DB.ConnectionWarning.Unknown`

#### Summary

Value for unknown or unspecified reason.

### `T:Autodesk.Revit.DB.ConnectionResolution`

Member kind: type
Symbol: `Autodesk.Revit.DB.ConnectionResolution`

#### Summary

An enumerated type listing all the possible resolutions for connectivity validation.

#### Since

2016

### `F:Autodesk.Revit.DB.ConnectionResolution.Disconnected`

Member kind: field
Symbol: `Autodesk.Revit.DB.ConnectionResolution.Disconnected`

#### Summary

Value for parts were disconnected.

### `M:Autodesk.Revit.DB.FabricationConfigurationInfo.AddConfig(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.AddConfig(System.Boolean)`

#### Summary

Adds this fabrication configuration.

#### Parameter `bCloudConfig`

Whether to

#### Returns

returns whether the configuration was added successfully.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfigurationInfo.AddCached(System.String,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.AddCached(System.String,System.String,System.String)`

#### Summary

Adds a fabrication configuration.

#### Parameter `name`

The fabrication configuration name.

#### Parameter `path`

The path where fabrication configuration located.

#### Parameter `id`

The cloud Id of the config

#### Returns

returns whether the configuration was added successfully.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfigurationInfo.GetAllFabricationConfigurationsForProducts(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.GetAllFabricationConfigurationsForProducts(System.Int32,System.Int32)`

#### Summary

Gets all added fabrication configurations.

#### Returns

All added fabrication configurations.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfigurationInfo.Compare(Autodesk.Revit.DB.FabricationConfigurationInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.Compare(Autodesk.Revit.DB.FabricationConfigurationInfo)`

#### Summary

Whether one configuration is the same as another one, or may be compatible if not.

#### Returns

return zero for an exact match. Positive values indicate a partial match, with the lower value being closer. Negative values indicate no match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.FabricationConfigurationInfo.IsEqual(Autodesk.Revit.DB.FabricationConfigurationInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.IsEqual(Autodesk.Revit.DB.FabricationConfigurationInfo)`

#### Summary

Checks if the two configuration are the same(e.g. if they have the same GUID and version).

#### Parameter `fc`

The other FabricationConfigurationInfo object to compare.

#### Returns

True if the two configuration are the same.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfigurationInfo.CreateCloudConfig(System.String,System.String,System.Guid,System.Double,Autodesk.Revit.DB.UnitSystem,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.CreateCloudConfig(System.String,System.String,System.Guid,System.Double,Autodesk.Revit.DB.UnitSystem,System.String)`

#### Summary

constructor of FabricationConfigurationInfo for cloud configurations

#### Returns

returns config info for cloud config

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfigurationInfo.GetAllFabricationConfigurations`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.GetAllFabricationConfigurations`

#### Summary

Gets all added fabrication configurations.

#### Returns

All added fabrication configurations.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfigurationInfo.FindSourceFabricationConfiguration(Autodesk.Revit.DB.FabricationConfigurationInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.FindSourceFabricationConfiguration(Autodesk.Revit.DB.FabricationConfigurationInfo)`

#### Summary

Finds the source fabrication configuration on disk which matches the input fabrication configuration.

#### Remarks

Fabrication configuration is matched by configuration GUID and version. The GUIDs are required to be the same.
For version, we first try to match the version exactly. If Revit cannot find an exact match, then it looks for
the closest version later than the input configuration, then the closest earlier version.

#### Parameter `fabricationConfiguration`

The fabrication configuration to match.

#### Returns

The matching source fabrication configuration.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfigurationInfo.GetProfiles`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.GetProfiles`

#### Summary

Return the profiles in the fabrication configuration.

#### Remarks

The global profile name is empty, and is not returned here.

#### Since

2016

### `M:Autodesk.Revit.DB.FabricationConfigurationInfo.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.IsValid`

#### Summary

Checks if the fabrication configuration is valid.

#### Returns

True if the fabrication configuration is valid.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationConfigurationInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FabricationConfigurationInfo.IsCloudConfiguration`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.IsCloudConfiguration`

#### Summary

Whether the cloud configuration is a remote cloud one.

#### Since

2019

### `P:Autodesk.Revit.DB.FabricationConfigurationInfo.Path`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.Path`

#### Summary

The path where the fabrication configuration is located. To populate this property,
you may need to call `M:Autodesk.Revit.DB.FabricationConfigurationInfo.FindSourceFabricationConfiguration(Autodesk.Revit.DB.FabricationConfigurationInfo)` first.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationConfigurationInfo.UnitSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.UnitSystem`

#### Summary

The unit system of the fabrication configuration. Units can be UnitSystem.Metric or UnitSystem.Imperial.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationConfigurationInfo.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.Description`

#### Summary

The description of the fabrication configuration.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationConfigurationInfo.Version`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.Version`

#### Summary

The version of the fabrication configuration.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationConfigurationInfo.GUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.GUID`

#### Summary

The unique identification of the fabrication configuration.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationConfigurationInfo.ProductVersion`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.ProductVersion`

#### Summary

product version of config (0 is current, else year)

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationConfigurationInfo.CloudId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.CloudId`

#### Summary

The identifier of the cloud configuration.

#### Since

2019

### `P:Autodesk.Revit.DB.FabricationConfigurationInfo.IsLocked`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.IsLocked`

#### Summary

Checks whether the fabrication configuration is locked. If true, the configuration is locked and cannot be removed.

#### Since

2016

### `P:Autodesk.Revit.DB.FabricationConfigurationInfo.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo.Name`

#### Summary

The name of the fabrication configuration.

#### Since

2016

### `T:Autodesk.Revit.DB.FabricationConfigurationInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationConfigurationInfo`

#### Summary

Represents an MEP object that holds the properties of an MEP fabrication configuration.

#### Remarks

To populate the Path property, you may need to call
`M:Autodesk.Revit.DB.FabricationConfigurationInfo.FindSourceFabricationConfiguration(Autodesk.Revit.DB.FabricationConfigurationInfo)` first.

#### Since

2016

### `T:Autodesk.Revit.DB.Fabrication.FabricationCustomDataType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationCustomDataType`

#### Summary

An enumerated type listing all fabrication custom data value types.

#### Since

2017 Subscription Update

### `F:Autodesk.Revit.DB.Fabrication.FabricationCustomDataType.Real`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationCustomDataType.Real`

#### Summary

Real number data type.

### `F:Autodesk.Revit.DB.Fabrication.FabricationCustomDataType.Integer`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationCustomDataType.Integer`

#### Summary

Integer data type

### `F:Autodesk.Revit.DB.Fabrication.FabricationCustomDataType.Text`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationCustomDataType.Text`

#### Summary

Text data type

### `P:Autodesk.Revit.DB.FabricationAncillaryUsage.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationAncillaryUsage.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FabricationAncillaryUsage.ProductCode`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationAncillaryUsage.ProductCode`

#### Summary

A unique string code that idnenifies the ancillary in the fabriction database in order to purchase it.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.FabricationAncillaryUsage.Length`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationAncillaryUsage.Length`

#### Summary

Length of required ancillaries.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.FabricationAncillaryUsage.Quantity`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationAncillaryUsage.Quantity`

#### Summary

Quantity of required ancillaries.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.FabricationAncillaryUsage.AncillaryDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationAncillaryUsage.AncillaryDepth`

#### Summary

Depth of required ancillary if it isn't round.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.FabricationAncillaryUsage.AncillaryWidthOrDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationAncillaryUsage.AncillaryWidthOrDiameter`

#### Summary

Width or diameter of required ancillary.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.FabricationAncillaryUsage.AncillaryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationAncillaryUsage.AncillaryId`

#### Summary

Fabrication ancillary database identifier.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.FabricationAncillaryUsage.UsageType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationAncillaryUsage.UsageType`

#### Summary

Fabrication ancillary usage type.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.FabricationAncillaryUsage.Type`

Member kind: property
Symbol: `Autodesk.Revit.DB.FabricationAncillaryUsage.Type`

#### Summary

Fabrication ancillary type.

#### Since

2017 Subscription Update

### `T:Autodesk.Revit.DB.FabricationAncillaryUsage`

Member kind: type
Symbol: `Autodesk.Revit.DB.FabricationAncillaryUsage`

#### Summary

Structure that holds information about the usage of a fabrication ancillary

#### Since

2017 Subscription Update

### `T:Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType`

#### Summary

An enumerated type describing where an ancillary is used on a fabrication part.

#### Since

2017 Subscription Update

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Stiffener`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Stiffener`

#### Summary

Ancillary makes up a fabrication part internal or external stiffener.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Hanger`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Hanger`

#### Summary

Ancillary makes up a fabrication part hanger.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Airturn`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Airturn`

#### Summary

Ancillary makes up a fabrication part airturn or vane.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Splitter`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Splitter`

#### Summary

Ancillary makes up a fabrication part splitter.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Seam`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Seam`

#### Summary

Ancillary is associated with a seam on development(s).

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Connector`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Connector`

#### Summary

Ancillary makes up a fabrication part connector.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Loose`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Loose`

#### Summary

Miscellaneous loose ancillary defined on the part.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType.Undefined`

#### Summary

Undefined usage.

### `T:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType`

#### Summary

An enumerated type listing all fabrication ancillary types.

#### Since

2017 Subscription Update

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.SeamMaterial`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.SeamMaterial`

#### Summary

Ancillary seam material.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Isolator`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Isolator`

#### Summary

Ancillary support isolators. Used inline ancillary support rods.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.AirturnVane`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.AirturnVane`

#### Summary

Ancillary airturn vanes. Used to manage flow through fittings.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.AirturnTrack`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.AirturnTrack`

#### Summary

Ancillary airturn tracks. Used to fasten airturn vanes in place.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.AncillaryMaterial`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.AncillaryMaterial`

#### Summary

Ancillary materials used to support and externally stiffen fittings, eg. angle iron, unistrut.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.SupportRod`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.SupportRod`

#### Summary

Ancillary support drop rod types. Used to support fittings.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Sealant`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Sealant`

#### Summary

Ancillary sealants. Used to seal seams.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Gasket`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Gasket`

#### Summary

Ancillary gaskets. Used to seal connector joints.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.TieRod`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.TieRod`

#### Summary

Ancillary tie rod types. Used to internally stiffen fittings.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Clip`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Clip`

#### Summary

Ancillary clips and washers. Used to additionally fix and clip ancillaries together.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Corner`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Corner`

#### Summary

Ancillary corner joints. Used to join ancillary materials."

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Fixing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Fixing`

#### Summary

Ancillary nuts and bolts. Used to fix and bind other ancillaries.

### `F:Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Unknown`

Member kind: field
Symbol: `Autodesk.Revit.DB.Fabrication.FabricationAncillaryType.Unknown`

#### Summary

Unknown or unsupported ancillary type.

### `M:Autodesk.Revit.DB.Structure.FabricWireType.CreateDefaultFabricWireType(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricWireType.CreateDefaultFabricWireType(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new FabricWireType object with a default name.

#### Parameter `ADoc`

The document.

#### Returns

The newly created type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.FabricWireType.BendDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricWireType.BendDiameter`

#### Summary

Determines the bending diameter of the wire.

#### Value

The value should be positive.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for bendDiameter is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The bending diameter bendDiameter is negative.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.FabricWireType.WireDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricWireType.WireDiameter`

#### Summary

Determines the diameter of the wire.

#### Value

The value should be positive and less than 12 inches/300 mm.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for wireDiameter is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The wire diameter wireDiameter is negative or greater than 12 inches/300 mm.

#### Since

2013

### `T:Autodesk.Revit.DB.Structure.FabricWireType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricWireType`

#### Summary

A Fabric Wire Type object that is used in the generation of Fabric Wire.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricWireItem.Create(System.Double,System.Double,Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricWireItem.Create(System.Double,System.Double,Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Creates a new instance of a single Fabric wire.

#### Parameter `distance`

The distance between this wire and the next wire in the Custom Fabric Sheet

#### Parameter `wireLength`

Length of this wire

#### Parameter `wireType`

The wire type of this wire

#### Parameter `wireOffset`

The offset between two wires in the same line

#### Returns

The newly created Fabric wire instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for distance is not a number
-or-
The given value for wireLength is not a number
-or-
wireType is not a valid Element identifier.
-or-
The given value for wireOffset is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for distance must be between 0 and 30000 feet.
-or-
The given value for wireLength must be greater than 0 and no more than 30000 feet.
-or-
The given value for wireOffset must be between 0 and 30000 feet.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.FabricWireItem.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricWireItem.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.FabricWireItem.OffsetAlongWire`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricWireItem.OffsetAlongWire`

#### Summary

Offset along wire direction
Wire distance should be 0 if we want to be along the same wire

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for offset is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for offset must be between 0 and 30000 feet.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.FabricWireItem.WireLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricWireItem.WireLength`

#### Summary

Wire length for this wire item

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for length is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for length must be greater than 0 and no more than 30000 feet.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.FabricWireItem.WireType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricWireItem.WireType`

#### Summary

The wire type of this wire item

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: wireType is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.FabricWireItem.Distance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricWireItem.Distance`

#### Summary

Distance to the next fabric wire item
Can be 0 to be used with offset along wire.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for distance is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for distance must be between 0 and 30000 feet.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.FabricWireItem`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricWireItem`

#### Summary

Provides implementation for FabricWires stored in a Custom Fabric Sheet

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.FabricSheet.IsSingleFabricSheetWithinHost(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.IsSingleFabricSheetWithinHost(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Transform)`

#### Summary

Identifies if the specified single Fabric Sheet position is within the host.

#### Parameter `hostElement`

A structural element that will host the Fabric Sheet.

#### Parameter `transform`

The transform that defines the placement of the instance single Fabric Sheet.

#### Returns

True if the single Fabric Sheet instance is within the host, false if the single Fabric Sheet instance is out of host.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.FabricSheet.IsCoverOffsetValid(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.IsCoverOffsetValid(System.Double)`

#### Summary

Identifies if the specified value is valid for use as a cover offset.

#### Remarks

The cover offset must be less than or equal to the host thickness.

#### Parameter `coverOffset`

The cover offset value.

#### Returns

True if the value is valid, false if the value is invalid.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.FabricSheet.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

#### Summary

Sets this fabric sheet to be shown unobscured in a view.

#### Parameter `view`

The view element

#### Parameter `unobscured`

True if fabric sheet is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This fabric sheet doesn't have valid visibility data.

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.FabricSheet.IsUnobscuredInView(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.IsUnobscuredInView(Autodesk.Revit.DB.View)`

#### Summary

Checks if this fabric sheet is shown unobscured in a view.

#### Parameter `view`

The view element

#### Returns

True if fabric sheet is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This fabric sheet doesn't have valid visibility data.

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.FabricSheet.SetSegmentLength(Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.SetSegmentLength(Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Sets the value of the bent fabric sheet segment(like A, B, C, D etc.)

#### Parameter `segmentParameterId`

The segment ID of the bent fabric sheet.

#### Parameter `value`

The length value to set

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for value is not a number
-or-

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for value must be between 0 and 30000 feet.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.FabricSheet.GetSegmentParameterIdsAndLengths(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.GetSegmentParameterIdsAndLengths(System.Boolean)`

#### Summary

Returns the array of pairs [parameter ID, length] that correspond to segments of a bent fabric sheet (like A, B, C, D etc.).

#### Remarks

This method does not provide alphabetical nor any other order of returned parameters.

#### Parameter `rounded`

Set to true to return rounded values for segments lengths.

#### Returns

Array of pairs [parameter ID, length] that correspond to segments of a bent fabric sheet (like A, B, C, D etc.) is returned for bend fabric sheet.
For flat fabric sheet (not bent) empty array is returned.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.FabricSheet.SetBendProfile(Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.SetBendProfile(Autodesk.Revit.DB.CurveLoop)`

#### Summary

Sets new profile that defines the shape of the Fabric Sheet bending.

#### Parameter `bendProfile`

A profile that defines the bending shape of the fabric sheet.
The profile can be provided without fillets (eg. for L shape, only two lines not two lines and one arc), if so,
then fillets (in example one arc) will be automatically generated basing on the Bend Diameter parameter defined in the Fabric Wire system family.
If the provided profile has no corners (has a tangent defined at each point except the ends), no fillets will be generated.
The provided profile defines the center-curve of a wire.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the bend profile contains an overlap or intersecting segments.
-or-
Thrown when the bend profile is empty.
-or-
Thrown when the bend profile contains an empty loop.
-or-
Thrown when the bend profile contains multiple loops.
-or-
Thrown when the bend profile contains a closed loop.
-or-
Thrown when the bend profile contains two or more arcs that are not separated from one another by a straight segment.
-or-
Thrown when the bend profile contains too short segments which prevent the fillets from being added. The fillet radius is taken from Bend Diameter parameter defined in the Fabric Wire system family.
-or-
Thrown when the provided profile cannot be used as a bending shape for this fabric sheet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidObjectException`

The data-setting method is not applicable to fabric sheets that are flat.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.FabricSheet.GetBendProfile`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.GetBendProfile`

#### Summary

Returns the profile (not including generated fillets) that defines the shape of the Fabric Sheet bending.

#### Remarks

The returned profile defines the center-curve of a wire.
Note that bent Fabric Sheets can have planar geometry, but flat Fabric Sheets are always planar.

#### Returns

The profile that defines the shape of the fabric sheet bending for bent fabric sheet, for flat fabric sheet `null` will be returned.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.FabricSheet.GetBendProfileWithFillets`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.GetBendProfileWithFillets`

#### Summary

Returns the profile with generated fillets that defines the shape of the Fabric Sheet bending.

#### Remarks

Returned curve loop is created automatically as a result of adding fillets to bend profile.
The returned profile defines the center-curve of a wire.
Note that bent Fabric Sheets can have planar geometry, but flat Fabric Sheets are always planar.

#### Returns

The bend profile with generated fillets that defines the shape of the fabric sheet bending for bent fabric sheet,
for flat fabric sheet `null` will be returned.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.FabricSheet.GetReinforcementRoundingManager`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.GetReinforcementRoundingManager`

#### Summary

Returns an object for managing reinforcement rounding override settings.

#### Returns

The rounding manager.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.FabricSheet.GetSheetLocation`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.GetSheetLocation`

#### Summary

Gets the position and the orientation of the Fabric Sheet instance.

#### Returns

The location of the Fabric Sheet instance.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.FabricSheet.IsValidHost(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.IsValidHost(Autodesk.Revit.DB.Element)`

#### Summary

Checks whether an element is a valid host for fabric sheet.

#### Parameter `host`

The element to check.

#### Returns

True if the element is a valid host for fabric sheet, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheet.IsValidHost(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.IsValidHost(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether an element is a valid host for fabric sheet.

#### Parameter `document`

The document.

#### Parameter `concreteHostElementId`

The elementId to check.

#### Returns

True if the element is a valid host for fabric sheet, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheet.PlaceInHost(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.PlaceInHost(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Transform)`

#### Summary

Inserts the single Fabric Sheet instance into the host element.

#### Parameter `hostElement`

A structural element that will host the Fabric Sheet. The element must support fabric hosting.

#### Parameter `transform`

The transform that defines the placement of the instance single Fabric Sheet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The host Element is not a valid host for Fabric Sheet.
-or-
transform defines the placement out of the host.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

transform is not conformal.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.FabricSheet.GetWireCenterlines`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.GetWireCenterlines`

#### Summary

Gets a list of curves representing the wires centerlines of the Fabric Sheet in the both distribution directions.

#### Returns

The centerline curves.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheet.GetWireCenterlines(Autodesk.Revit.DB.Structure.WireDistributionDirection)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.GetWireCenterlines(Autodesk.Revit.DB.Structure.WireDistributionDirection)`

#### Summary

Gets a list of curves representing the wires centerlines of the Fabric Sheet.

#### Parameter `wireDirection`

The direction of wire distribution in the Fabric Sheet.

#### Returns

The centerline curves.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheet.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.CurveLoop)`

#### Summary

Creates a new instance of a single bent Fabric Sheet element within the project.

#### Parameter `document`

The document in which the fabric sheet is to be created.

#### Parameter `concreteHostElementId`

The element that will host the FabricSheet.
The host can be a Structural Floor, Structural Wall, Structural Slab, Structural Floor Edge, Structural Slab Edge,
Structural Column, Beam and Brace.
Also, host can be a `!:Autodesk::Revit::DB::Part` created from a structural layer of Structural Floor, Structural Wall or Structural Slab.

#### Parameter `fabricSheetTypeId`

The id of the FabricSheetType.

#### Parameter `bendProfile`

A profile that defines the bending shape of the fabric sheet.
The profile can be provided without fillets (eg. for L shape, only two lines not two lines and one arc), if so,
then fillets (in example one arc) will be automatically generated basing on the Bend Diameter parameter defined in the Fabric Wire system family.
If the provided profile has no corners (has a tangent defined at each point except the ends), no fillets will be generated.
The provided profile defines the center-curve of a wire.

#### Returns

The instance of the newly created bent fabric sheet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

concreteHostElementId is not a valid ElementId for the host Fabric Sheet.
-or-
fabricSheetTypeId should refer to an FabricSheetType element.
-or-
Thrown when the bend profile contains an overlap or intersecting segments.
-or-
Thrown when the bend profile is empty.
-or-
Thrown when the bend profile contains an empty loop.
-or-
Thrown when the bend profile contains multiple loops.
-or-
Thrown when the bend profile contains a closed loop.
-or-
Thrown when the bend profile contains two or more arcs that are not separated from one another by a straight segment.
-or-
Thrown when the bend profile contains too short segments which prevent the fillets from being added. The fillet radius is taken from Bend Diameter parameter defined in the Fabric Wire system family.
-or-
Thrown when the provided profile cannot be used as a bending shape for this fabric sheet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.FabricSheet.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of a single flat Fabric Sheet element within the project.

#### Parameter `document`

The document in which the fabric sheet is to be created.

#### Parameter `hostElement`

The element that will host the FabricSheet. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.

#### Parameter `fabricSheetTypeId`

The id of the FabricSheetType.

#### Returns

The newly created single Fabric Sheet instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element hostElement was not found in the given document.
-or-
The host Element is not a valid host for Fabric Sheet.
-or-
fabricSheetTypeId should refer to an FabricSheetType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.FabricSheet.CutOverallWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.CutOverallWidth`

#### Summary

The sheet length after cutting has taken place.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheet.CutOverallLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.CutOverallLength`

#### Summary

The sheet length after cutting has taken place.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheet.FabricNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.FabricNumber`

#### Summary

Specifies the numerical parameter assigned to the fabric sheet and any sheet of the same type, dimension, material, shape, and partition.

#### Remarks

Value of this property corresponds to the Fabric Number parameter of Rebar as available in both the UI and API. Refer to the `!:NumberingSchema` class for details related to numbering Rebar and Fabrics.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.FabricSheet.FabricHostReference`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.FabricHostReference`

#### Summary

Controls if Single Fabric Sheet should be cut by the Host Cover

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.FabricSheet.CoverOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.CoverOffset`

#### Summary

The additional cover offset of the Fabric Sheet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for coverOffset is not a number
-or-
When setting this property: coverOffset is greater then the host thickness.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for coverOffset must be between 0 and 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property:

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.FabricSheet.FabricLocation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.FabricLocation`

#### Summary

The Fabric Sheet location in the host.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property:

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.FabricSheet.FabricAreaOwnerId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.FabricAreaOwnerId`

#### Summary

The Fabric Area Id.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheet.CutSheetMass`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.CutSheetMass`

#### Summary

The sheet mass after cutting has taken place.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheet.HostId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.HostId`

#### Summary

The structure element that contains the Fabric Sheet.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.FabricSheet.IsBent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.IsBent`

#### Summary

The type of fabric sheet. True for bent fabric sheet, false for flat fabric sheet.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.FabricSheet.SketchId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.SketchId`

#### Summary

The id of the Sketch element for this element.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheet.BendFinalLoopOrientationVector`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.BendFinalLoopOrientationVector`

#### Summary

Direction of local Fabric Sheet Y axis in bending polyline LCS.

#### Remarks

Note that bending line may be rotated before it is placed in Fabric Sheet local coordinate system.
This vector allows to calculate rotation angle or Trf.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.FabricSheet.BentFabricLongitudinalCutLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.BentFabricLongitudinalCutLength`

#### Summary

Specifies the cut length of the fabric sheet perpendicular to the bend edge.

#### Remarks

Zero indicates that the fabric sheet is not shortened.
This parameter applies only to bent fabric sheets.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for bentFabricLongitudinalCutLength must be between 0 and 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidObjectException`

When setting this property: The data-setting method is not applicable to fabric sheets that are flat.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.FabricSheet.BentFabricStraightWiresLocation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.BentFabricStraightWiresLocation`

#### Summary

Specifies the location of straight bars with respect to bent bars in the fabric sheet.

#### Remarks

This parameter applies only to bent fabric sheets.
The side on wich straight wires will be loacted is determined by the start and end point of the first bent profile segment that specifies the direction of the curve loop on plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: the data-setting method is not applicable to fabric sheets that are flat

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidObjectException`

When setting this property: The data-setting method is not applicable to fabric sheets that are flat.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.FabricSheet.BentFabricBendDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet.BentFabricBendDirection`

#### Summary

Specifies which wire direction of the fabric sheet is bent.

#### Remarks

This parameter applies only to bent fabric sheets.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: the data-setting method is not applicable to fabric sheets that are flat

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidObjectException`

When setting this property: The data-setting method is not applicable to fabric sheets that are flat.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.FabricSheet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricSheet`

#### Summary

An object that represents an Fabric Sheet Element within the Autodesk Revit project.

#### Remarks

Beginning with Revit 2016, fabric sheets can be either flat or bent.
Both kinds of fabric sheets are implemented by this FabricSheet class.
Fabric sheets are created as either flat or bent. Once created, the kind of a fabric sheet cannot be changed.
The Fabric Sheet element is available only in the Autodesk Revit Structure product.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.GetWireItem(System.Int32,Autodesk.Revit.DB.Structure.WireDistributionDirection)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.GetWireItem(System.Int32,Autodesk.Revit.DB.Structure.WireDistributionDirection)`

#### Summary

Gets the Wire stored in the FabricSheetType at the associated index.

#### Parameter `wireIndex`

Item index in the Fabric Sheet

#### Parameter `direction`

Wire distribution direction of the inquired item

#### Returns

Fabric wire Item

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The item index is either less than 0 or greater than or equal to number of items in this FabricSheetType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Fabric Sheet is not Custom

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.IsCustom`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.IsCustom`

#### Summary

Verifies if the type is Custom Fabric Sheet

#### Returns

True if Layout is set on Custom and if the wireArr is not null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.SetLayoutAsCustomPattern(System.Double,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.FabricWireItem},System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.FabricWireItem})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.SetLayoutAsCustomPattern(System.Double,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.FabricWireItem},System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.FabricWireItem})`

#### Summary

Sets the minor and major layout patterns as Custom, while specifying the needed parameters for this pattern.

#### Remarks

The following properties are not used for custom fabric sheet type:
- MajorDirectionWireType;
- MinorDirectionWireType;
- MajorSpacing;
- MinorSpacing.

#### Parameter `minorStartOverhang`

The distance from the edge of the sheet to the first wire in the minor direction.

#### Parameter `majorStartOverhang`

The distance from the edge of the sheet to the first wire in the major direction.

#### Parameter `minorFabricWireItems`

The fabric wire items in the minor direction.

#### Parameter `majorFabricWireItems`

The fabric wire items in the major direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for minorStartOverhang is not a number
-or-
The given value for majorStartOverhang is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for minorStartOverhang must be between 0 and 30000 feet.
-or-
The given value for majorStartOverhang must be between 0 and 30000 feet.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.SetMinorLayoutAsNumberWithSpacing(System.Double,System.Double,System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.SetMinorLayoutAsNumberWithSpacing(System.Double,System.Double,System.Int32,System.Double)`

#### Summary

Sets the major layout pattern as NumberWithSpacing, while specifying the needed parameters for this pattern.

#### Parameter `overallLength`

The entire length of the wire sheet in the major direction.

#### Parameter `majorStartOverhang`

The distance from the edge of the sheet to the first wire in the major direction.

#### Parameter `numberOfWires`

The number of wires in the minor direction.

#### Parameter `spacing`

The distance between the wires in the minor direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for overallLength is not a number
-or-
The given value for majorStartOverhang is not a number
-or-
numberOfWires must range from 2 to 1000000.
-or-
The given value for spacing is not a number
-or-
The arguments are not consistent, please specify proper input values.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for overallLength must be greater than 0 and no more than 30000 feet.
-or-
The given value for majorStartOverhang must be between 0 and 30000 feet.
-or-
The given value for spacing must be greater than 0 and no more than 30000 feet.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.SetMinorLayoutAsFixedNumber(System.Double,System.Double,System.Double,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.SetMinorLayoutAsFixedNumber(System.Double,System.Double,System.Double,System.Int32)`

#### Summary

Sets the major layout pattern as FixedNumber, while specifying the needed parameters for this pattern.

#### Parameter `overallLength`

The entire length of the wire sheet in the major direction.

#### Parameter `majorStartOverhang`

The distance from the edge of the sheet to the first wire in the major direction.

#### Parameter `majorEndOverhang`

The distance from the last wire to the edge of the sheet in the major direction.

#### Parameter `numberOfWires`

The number of the wires to set in the minor direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for overallLength is not a number
-or-
The given value for majorStartOverhang is not a number
-or-
The given value for majorEndOverhang is not a number
-or-
numberOfWires must range from 2 to 1000000.
-or-
The arguments are not consistent, please specify proper input values.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for overallLength must be greater than 0 and no more than 30000 feet.
-or-
The given value for majorStartOverhang must be between 0 and 30000 feet.
-or-
The given value for majorEndOverhang must be between 0 and 30000 feet.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.SetMinorLayoutAsMaximumSpacing(System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.SetMinorLayoutAsMaximumSpacing(System.Double,System.Double,System.Double,System.Double)`

#### Summary

Sets the major layout pattern as MaximumSpacing, while specifying the needed parameters for this pattern.

#### Parameter `overallLength`

The entire length of the wire sheet in the major direction.

#### Parameter `majorStartOverhang`

The distance from the edge of the sheet to the first wire in the major direction.

#### Parameter `majorEndOverhang`

The distance from the last wire to the edge of the sheet in the major direction.

#### Parameter `spacing`

The distance between the wires in the minor direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for overallLength is not a number
-or-
The given value for majorStartOverhang is not a number
-or-
The given value for majorEndOverhang is not a number
-or-
The given value for spacing is not a number
-or-
The arguments are not consistent, please specify proper input values.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for overallLength must be greater than 0 and no more than 30000 feet.
-or-
The given value for majorStartOverhang must be between 0 and 30000 feet.
-or-
The given value for majorEndOverhang must be between 0 and 30000 feet.
-or-
The given value for spacing must be greater than 0 and no more than 30000 feet.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.SetMinorLayoutAsActualSpacing(System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.SetMinorLayoutAsActualSpacing(System.Double,System.Double,System.Double)`

#### Summary

Sets the minor layout pattern as ActualSpacing, while specifying the needed parameters for this pattern.

#### Parameter `overallLength`

The entire length of the wire sheet in the major direction.

#### Parameter `majorStartOverhang`

The distance from the edge of the sheet to the first wire in the major direction.

#### Parameter `spacing`

The distance between the wires in the minor direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for overallLength is not a number
-or-
The given value for majorStartOverhang is not a number
-or-
The given value for spacing is not a number
-or-
The arguments are not consistent, please specify proper input values.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for overallLength must be greater than 0 and no more than 30000 feet.
-or-
The given value for majorStartOverhang must be between 0 and 30000 feet.
-or-
The given value for spacing must be greater than 0 and no more than 30000 feet.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.SetMajorLayoutAsNumberWithSpacing(System.Double,System.Double,System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.SetMajorLayoutAsNumberWithSpacing(System.Double,System.Double,System.Int32,System.Double)`

#### Summary

Sets the major layout pattern as NumberWithSpacing, while specifying the needed parameters for this pattern.

#### Parameter `overallWidth`

The entire width of the wire sheet in the minor direction.

#### Parameter `minorStartOverhang`

The distance from the edge of the sheet to the first wire in the minor direction.

#### Parameter `numberOfWires`

The number of the wires to set in the major direction.

#### Parameter `spacing`

The distance between the wires in the major direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for overallWidth is not a number
-or-
The given value for minorStartOverhang is not a number
-or-
numberOfWires must range from 2 to 1000000.
-or-
The given value for spacing is not a number
-or-
The arguments are not consistent, please specify proper input values.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for overallWidth must be greater than 0 and no more than 30000 feet.
-or-
The given value for minorStartOverhang must be between 0 and 30000 feet.
-or-
The given value for spacing must be greater than 0 and no more than 30000 feet.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.SetMajorLayoutAsFixedNumber(System.Double,System.Double,System.Double,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.SetMajorLayoutAsFixedNumber(System.Double,System.Double,System.Double,System.Int32)`

#### Summary

Sets the major layout pattern as FixedNumber, while specifying the needed parameters for this pattern.

#### Parameter `overallWidth`

The entire width of the wire sheet in the minor direction.

#### Parameter `minorStartOverhang`

The distance from the edge of the sheet to the first wire in the minor direction.

#### Parameter `minorEndOverhang`

The distance from the last wire to the edge of the sheet in the minor direction.

#### Parameter `numberOfWires`

The number of the wires to set in the major direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for overallWidth is not a number
-or-
The given value for minorStartOverhang is not a number
-or-
The given value for minorEndOverhang is not a number
-or-
numberOfWires must range from 2 to 1000000.
-or-
The arguments are not consistent, please specify proper input values.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for overallWidth must be greater than 0 and no more than 30000 feet.
-or-
The given value for minorStartOverhang must be between 0 and 30000 feet.
-or-
The given value for minorEndOverhang must be between 0 and 30000 feet.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.SetMajorLayoutAsMaximumSpacing(System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.SetMajorLayoutAsMaximumSpacing(System.Double,System.Double,System.Double,System.Double)`

#### Summary

Sets the major layout pattern as MaximumSpacing, while specifying the needed parameters for this pattern.

#### Parameter `overallWidth`

The entire width of the wire sheet in the minor direction.

#### Parameter `minorStartOverhang`

The distance from the edge of the sheet to the first wire in the minor direction.

#### Parameter `minorEndOverhang`

The distance from the last wire to the edge of the sheet in the minor direction.

#### Parameter `spacing`

The distance between the wires in the major direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for overallWidth is not a number
-or-
The given value for minorStartOverhang is not a number
-or-
The given value for minorEndOverhang is not a number
-or-
The given value for spacing is not a number
-or-
The arguments are not consistent, please specify proper input values.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for overallWidth must be greater than 0 and no more than 30000 feet.
-or-
The given value for minorStartOverhang must be between 0 and 30000 feet.
-or-
The given value for minorEndOverhang must be between 0 and 30000 feet.
-or-
The given value for spacing must be greater than 0 and no more than 30000 feet.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.SetMajorLayoutAsActualSpacing(System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.SetMajorLayoutAsActualSpacing(System.Double,System.Double,System.Double)`

#### Summary

Sets the major layout pattern as ActualSpacing, while specifying the needed parameters for this pattern.

#### Parameter `overallWidth`

The entire width of the wire sheet in the minor direction.

#### Parameter `minorStartOverhang`

The distance from the edge of the sheet to the first wire in the minor direction.

#### Parameter `spacing`

The distance between the wires in the major direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for overallWidth is not a number
-or-
The given value for minorStartOverhang is not a number
-or-
The given value for spacing is not a number
-or-
The arguments are not consistent, please specify proper input values.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for overallWidth must be greater than 0 and no more than 30000 feet.
-or-
The given value for minorStartOverhang must be between 0 and 30000 feet.
-or-
The given value for spacing must be greater than 0 and no more than 30000 feet.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.IsValidMinorLapSplice(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.IsValidMinorLapSplice(System.Double)`

#### Summary

Identifies if the input value is valid to be applied as the minor lap splice
value for this FabricSheetType.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.IsValidMajorLapSplice(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.IsValidMajorLapSplice(System.Double)`

#### Summary

Identifies if the input value is valid to be applied as the major lap splice
value for this FabricSheetType.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.GetReinforcementRoundingManager`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.GetReinforcementRoundingManager`

#### Summary

Returns an object for managing reinforcement rounding override settings.

#### Returns

The rounding manager.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.FabricSheetType.CreateDefaultFabricSheetType(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.CreateDefaultFabricSheetType(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new FabricSheetType object with a default name.

#### Parameter `ADoc`

The document.

#### Returns

The newly created type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.Material`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.Material`

#### Summary

The id of the material assigned to wires.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The sheetMaterial cannot map to a valid material element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MinorReinforcementArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MinorReinforcementArea`

#### Summary

The area of fabric divided by the spacing of the wire in the minor direction.
This method does not apply to custom fabric sheet

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MajorReinforcementArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MajorReinforcementArea`

#### Summary

The area of fabric divided by the spacing of the wire in the major direction.
This method does not apply to custom fabric sheet

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.SheetMassUnit`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.SheetMassUnit`

#### Summary

The sheet mass per area unit.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.SheetMass`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.SheetMass`

#### Summary

The sheet mass.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for sheetMass is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for sheetMass must be non-negative.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MinorSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MinorSpacing`

#### Summary

The spacing between the wires in the minor direction (not including the overhangs).

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MinorNumberOfWires`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MinorNumberOfWires`

#### Summary

The number of wires used in the minor direction (includes the 1st and last wires).

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MinorLayoutPattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MinorLayoutPattern`

#### Summary

The layout pattern in the minor direction.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MinorEndOverhang`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MinorEndOverhang`

#### Summary

The distance from the edge of the sheet to the last wire (measured in the minor direction).

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MinorStartOverhang`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MinorStartOverhang`

#### Summary

The distance from the edge of the sheet to the first wire (measured in the minor direction).

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.OverallWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.OverallWidth`

#### Summary

The length of the wire sheet (including overhangs) in the minor direction.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MajorSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MajorSpacing`

#### Summary

The spacing between the wires in the major direction (not including the overhangs).

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MajorNumberOfWires`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MajorNumberOfWires`

#### Summary

The number of wires used in the major direction (includes the first and last wires).

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MajorLayoutPattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MajorLayoutPattern`

#### Summary

The layout pattern in the major direction.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MajorEndOverhang`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MajorEndOverhang`

#### Summary

The distance from the edge of the sheet to the last wire (measured in the major direction).

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MajorStartOverhang`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MajorStartOverhang`

#### Summary

The distance from the edge of the sheet to the first wire (measured in the major direction).

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.OverallLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.OverallLength`

#### Summary

The length of the wire sheet (including overhangs) in the major direction.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MinorLapSpliceLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MinorLapSpliceLength`

#### Summary

The lap splice length in the minor direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: minorLapSpliceLength is greater than the half of the overall width.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MajorLapSpliceLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MajorLapSpliceLength`

#### Summary

The lap splice length in the major direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: majorLapSpliceLength is greater than the half of the overall length.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MinorDirectionWireType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MinorDirectionWireType`

#### Summary

The id of the FabricWireType to be used in the minor direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: the ElementId minorDirectionWireType is either invalid or not a FabricWireType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Fabric Sheet Type is Custom

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricSheetType.MajorDirectionWireType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType.MajorDirectionWireType`

#### Summary

The id of the FabricWireType to be used in the major direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: the ElementId majorDirectionWireType is either invalid or not a FabricWireType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Fabric Sheet Type is Custom

#### Since

2013

### `T:Autodesk.Revit.DB.Structure.FabricSheetType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetType`

#### Summary

Represents a fabric sheet type, used in the generation of fabric wires.

#### Since

2013

### `T:Autodesk.Revit.DB.Structure.WireDistributionDirection`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.WireDistributionDirection`

#### Summary

Defines the direction of the distribution of wires in a Fabric Sheet.

### `F:Autodesk.Revit.DB.Structure.WireDistributionDirection.Minor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.WireDistributionDirection.Minor`

#### Summary

Wires are distributed in the Minor direction.
Uncomment following for 2020.1
text "Minor"

### `F:Autodesk.Revit.DB.Structure.WireDistributionDirection.Major`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.WireDistributionDirection.Major`

#### Summary

Wires are distributed in the Major direction.
Uncomment following for 2020.1
text "Major"

### `M:Autodesk.Revit.DB.Structure.FabricReinSpanSymbol.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricReinSpanSymbol.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

#### Summary

Places a new instance of the Structural Fabric Reinforcement Symbol into the project relative to a particular FabricSheet and View.

#### Parameter `document`

The document.

#### Parameter `viewId`

The id of the view in which the symbol should appear.

#### Parameter `hostId`

The ElementId of FabricSheet (either in the document, or linked from another document).

#### Parameter `point`

The span symbol's head position.

#### Parameter `symbolId`

The id of the family symbol of this symbol.

#### Returns

A reference to the newly-created symbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

hostId should refer to a FabricSheet element.
-or-
viewId does not refer to a valid view type for FabricReinSpanSymbol - only floor plan, reflected ceiling plans and elevations are permitted.
-or-
symbolId should refer to a FamilySymbol of category OST_FabricReinSpanSymbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.Structure.FabricReinSpanSymbol`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricReinSpanSymbol`

#### Summary

Represents an instance of a Structural Fabric Reinforcement Symbol in Autodesk Revit.

#### Since

2013

### `M:Autodesk.Revit.DB.IndependentTag.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ,System.Double)`

#### Summary

Places a tag in a Generic Annotation mode.

#### Parameter `document`

The document to which the tag will be added.

#### Parameter `typeId`

The id for element type.

#### Parameter `ownerDBViewId`

The view in which the tag will be visible.

#### Parameter `reference`

The host reference of the tag. The reference must be local to an element or subelement.

#### Parameter `pnt`

The position of the tag

#### Parameter `angle`

The angle of the tag

#### Returns

If successful the new tag is returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId ownerDBViewId does not correspond to a View.
-or-
The ElementId ownerDBViewId is a view template.
-or-
The ElementId ownerDBViewId is a perspective view.
-or-
The 3D view ownerDBViewId is not locked.
-or-
Invalid ElementType Id.
-or-
Invalid reference.
-or-
Linked reference is not allowed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InternalException`

Tag creation failed.

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

### `M:Autodesk.Revit.DB.IndependentTag.SetIsLeaderVisible(Autodesk.Revit.DB.Reference,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.SetIsLeaderVisible(Autodesk.Revit.DB.Reference,System.Boolean)`

#### Summary

Set tag's leader that points to specified reference to be visible or not. This option can be set only if the LeadersPresentationMode is ShowSpecificLeaders.

#### Parameter `referenceTagged`

The reference which is tagged.

#### Parameter `visible`

True for showing the leader, false to hide it.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The specified reference is not currently tagged.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The IndependentTag object does not have a tag behavior.
-or-
The LeadersPresentationMode should be set to ShowSpecificLeaders.

#### Since

2023

### `M:Autodesk.Revit.DB.IndependentTag.IsLeaderVisible(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.IsLeaderVisible(Autodesk.Revit.DB.Reference)`

#### Summary

Returns if leader that points to specified reference is visible or not.

#### Parameter `referenceTagged`

The reference which is tagged.

#### Returns

Returns true if leader that points to specified reference is visible, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The specified reference is not currently tagged.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The IndependentTag object does not have a tag behavior.

#### Since

2023

### `M:Autodesk.Revit.DB.IndependentTag.GetTaggedReferences`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.GetTaggedReferences`

#### Summary

Get the host references of the tag.
An array of all the tagged references.

#### Remarks

The references can be to an element or subelement in a local or linked document.

#### Since

2022

### `M:Autodesk.Revit.DB.IndependentTag.IsTaggedOnSubelement`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.IsTaggedOnSubelement`

#### Summary

Returns true if the any of the tagged references is a subelement.

#### Since

2018

### `M:Autodesk.Revit.DB.IndependentTag.CanLeaderEndConditionBeAssigned(Autodesk.Revit.DB.LeaderEndCondition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.CanLeaderEndConditionBeAssigned(Autodesk.Revit.DB.LeaderEndCondition)`

#### Summary

Checks whether the LeaderEndCondition can be changed.

#### Remarks

Material tags and material keynotes can only use the free end condition.

#### Parameter `leaderEndCondition`

The leader end condition to check.

#### Returns

True if the leader end condition of the tag can be assigned, or false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.IndependentTag.GetTaggedLocalElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.GetTaggedLocalElements`

#### Summary

Get the tagged local elements, if any.
An Element will be provided for each subelement that is being referenced by the tag.

#### Returns

All tagged elements from the local document, or `null` for orphan tags and tagged elements in linked documents.

#### Since

2022

### `M:Autodesk.Revit.DB.IndependentTag.RemoveReferences(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.RemoveReferences(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

#### Summary

Removes the provided list of references from the tag's list of references.

#### Parameter `referencesToRemove`

References to be removed from tag.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The operation failed. Please verify that the references are all tagged before removing them.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The IndependentTag object does not have a tag behavior.

#### Since

2022

### `M:Autodesk.Revit.DB.IndependentTag.AddReferences(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.AddReferences(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

#### Summary

Adds the provided list of references to the tag's list of references.

#### Remarks

The references must pass the following requirements to be added:
Must not be already tagged.

Must be of the same category when TagMode is TM_ADDBY_CATEGORY.

Must be taggable by this tag type.
If any of the above rules is not fulfilled, the execution will be stopped and an exception will be thrown

#### Parameter `referencesToTag`

References to be tagged.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The operation failed. Please verify that the references are all taggable and that they are not already tagged.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The IndependentTag object does not have a tag behavior.
-or-
This type of tag does not support multiple references.

#### Since

2022

### `M:Autodesk.Revit.DB.IndependentTag.SetLeaderEnd(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.SetLeaderEnd(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

#### Summary

Set the end position of the tag's leader that points to specified reference.

#### Remarks

Tags with attached leaders or no leaders do not support leader ends.
`P:Autodesk.Revit.DB.IndependentTag.LeaderEndCondition` for the tag's leader condition.

#### Parameter `referenceTagged`

The reference which is tagged.

#### Parameter `pointEnd`

Point representing the end position of tag's leader

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There is no leader end because the tag does not use a free end leader or the leader is not visible.
-or-
The specified reference is not currently tagged.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The IndependentTag object does not have a tag behavior.

#### Since

2022

### `M:Autodesk.Revit.DB.IndependentTag.GetLeaderEnd(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.GetLeaderEnd(Autodesk.Revit.DB.Reference)`

#### Summary

Returns the end position of the tag's leader that points to specified reference.

#### Remarks

Tags with attached leaders or no leaders do not support leader ends.
`P:Autodesk.Revit.DB.IndependentTag.LeaderEndCondition` for the tag's leader condition.

#### Parameter `referenceTagged`

The reference which is tagged.

#### Returns

Point representing the end position of tag's leader

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There is no leader end because the tag does not use a free end leader or the leader is not visible.
-or-
The specified reference is not currently tagged.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The IndependentTag object does not have a tag behavior.

#### Since

2022

### `M:Autodesk.Revit.DB.IndependentTag.SetLeaderElbow(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.SetLeaderElbow(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

#### Summary

Set the position of the elbow of the tag's leader that points to specified reference.
If this tag is a multileader tag and the elbows are merged, the input position will be set to all leaders.

#### Remarks

Straight leaders do not have elbow points.

#### Parameter `referenceTagged`

The reference which is tagged.

#### Parameter `elbowPosition`

The position of the elbow.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The specified reference is not currently tagged.
-or-
The leader for the tagged reference isn't visible.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The IndependentTag object does not have a tag behavior.

#### Since

2022

### `M:Autodesk.Revit.DB.IndependentTag.GetLeaderElbow(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.GetLeaderElbow(Autodesk.Revit.DB.Reference)`

#### Summary

Returns the position of the elbow of the tag's leader that points to specified reference.
Position of leader's elbow.

#### Remarks

Straight leaders do not have elbow points.

#### Parameter `referenceTagged`

The reference which is tagged.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The specified reference does not have a leader or its leader is straight.
-or-
The specified reference is not currently tagged.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The IndependentTag object does not have a tag behavior.

#### Since

2022

### `M:Autodesk.Revit.DB.IndependentTag.HasLeaderElbow(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.HasLeaderElbow(Autodesk.Revit.DB.Reference)`

#### Summary

Whether the tag's leader that points to the reference has an elbow point or not.

#### Returns

True if the reference has a leader with an elbow point, or false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The specified reference is not currently tagged.
-or-
The leader for the tagged reference isn't visible.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The IndependentTag object does not have a tag behavior.

#### Since

2022

### `M:Autodesk.Revit.DB.IndependentTag.GetTaggedElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.GetTaggedElementIds`

#### Summary

Returns a set of LinkElementId for all tagged elements, if any. A LinkElementId will be provided for each
subelement that is being referenced by the tag.

#### Remarks

All the returned LinkElementIds will be valid even when `P:Autodesk.Revit.DB.IndependentTag.IsOrphaned` is true.

#### Returns

Set of all the tagged elements ids for both local and linked files.

#### Since

2022

### `M:Autodesk.Revit.DB.IndependentTag.GetTaggedLocalElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.GetTaggedLocalElementIds`

#### Summary

Returns a set of IDs for all tagged local elements, if any. A local element ID will be provided for each
subelement that is being referenced by the tag.
Set of all the element ids in the local file.
For each subelement a local element id will be provided.

#### Since

2022

### `M:Autodesk.Revit.DB.IndependentTag.HasTagBehavior`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.HasTagBehavior`

#### Summary

Checks if the IndependentTag has a tag behavior.

#### Remarks

When the IndependentTag object does not have a tag behavior, functions related to references, leaders and orientation will throw an exception.
In this case, the element may be used for geometry augmentation. `!:Autodesk::Revit::Proxy::DB::IGeometryAugmentationServer`
The list of functions that would fail if not in tag mode:
`M:Autodesk.Revit.DB.IndependentTag.AddReferences(System.Collections.Generic.IList`1{Autodesk.Revit.DB.Reference})` `M:Autodesk.Revit.DB.IndependentTag.GetLeaderElbow(Autodesk.Revit.DB.Reference)` `M:Autodesk.Revit.DB.IndependentTag.GetLeaderEnd(Autodesk.Revit.DB.Reference)` `P:Autodesk.Revit.DB.IndependentTag.HasLeader` `M:Autodesk.Revit.DB.IndependentTag.HasLeaderElbow(Autodesk.Revit.DB.Reference)` `M:Autodesk.Revit.DB.IndependentTag.IsLeaderVisible(Autodesk.Revit.DB.Reference)` `P:Autodesk.Revit.DB.IndependentTag.LeaderEndCondition` `P:Autodesk.Revit.DB.IndependentTag.LeadersPresentationMode` `P:Autodesk.Revit.DB.IndependentTag.MergeElbows` `M:Autodesk.Revit.DB.IndependentTag.RemoveReferences(System.Collections.Generic.IList`1{Autodesk.Revit.DB.Reference})` `M:Autodesk.Revit.DB.IndependentTag.SetIsLeaderVisible(Autodesk.Revit.DB.Reference,System.Boolean)` `M:Autodesk.Revit.DB.IndependentTag.SetLeaderEnd(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)` `M:Autodesk.Revit.DB.IndependentTag.SetLeaderElbow(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)` `P:Autodesk.Revit.DB.IndependentTag.TagOrientation` `P:Autodesk.Revit.DB.IndependentTag.TagText`

#### Since

2024

### `M:Autodesk.Revit.DB.IndependentTag.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Reference,System.Boolean,Autodesk.Revit.DB.TagOrientation,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Reference,System.Boolean,Autodesk.Revit.DB.TagOrientation,Autodesk.Revit.DB.XYZ)`

#### Summary

Places a tag on an element or subelement.

#### Parameter `document`

The document to which the tag will be added.

#### Parameter `symId`

The id for the FamilySymbol which determines the tag's type.

#### Parameter `ownerDBViewId`

The view in which the tag will be visible.

#### Parameter `referenceToTag`

The host reference of the tag. The reference can be to an element or subelement in a local or linked document.

#### Parameter `addLeader`

When true, the tag will be created with a straight leader with an attached end.

#### Parameter `tagOrientation`

The orientation of the tag's head.

#### Parameter `pnt`

For tags without leaders, this point is the position of the tag head.
For tags with leaders, this point is the end point of the leader,
and a leader of default length will be created from this point to the tag head.

#### Returns

If successful the new tag is returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId ownerDBViewId does not correspond to a View.
-or-
The ElementId ownerDBViewId is a view template.
-or-
The ElementId ownerDBViewId is a perspective view.
-or-
The 3D view ownerDBViewId is not locked.
-or-
The ElementId symId does not correspond to a FamilySymbol.
-or-
The reference can not be tagged.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InternalException`

Tag creation failed.

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

2019

### `M:Autodesk.Revit.DB.IndependentTag.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Reference,System.Boolean,Autodesk.Revit.DB.TagMode,Autodesk.Revit.DB.TagOrientation,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IndependentTag.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Reference,System.Boolean,Autodesk.Revit.DB.TagMode,Autodesk.Revit.DB.TagOrientation,Autodesk.Revit.DB.XYZ)`

#### Summary

Places a tag on an element or subelement.

#### Remarks

Single category tags, multi-category tags and material tags can be placed.

#### Parameter `document`

The document to which the tag will be added.

#### Parameter `ownerDBViewId`

The view in which the tag will be visible.

#### Parameter `referenceToTag`

The host reference of the tag. The reference can be to an element or subelement in a local or linked document.

#### Parameter `addLeader`

When true, the tag will be created with a straight leader with an attached end.

#### Parameter `tagMode`

This argument determines the type of tag that will be created. Tag by category, multi-category tag, and material tag are allowed.

#### Parameter `tagOrientation`

The orientation of the tag's head.

#### Parameter `pnt`

For tags without leaders, this point is the position of the tag head.
For tags with leaders, this point is the end point of the leader, and a leader of default length will be created from this point to the tag head.

#### Returns

If successful the new tag is returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId ownerDBViewId does not correspond to a View.
-or-
The ElementId ownerDBViewId is a view template.
-or-
The ElementId ownerDBViewId is a perspective view.
-or-
The 3D view ownerDBViewId is not locked.
-or-
The reference can not be tagged.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InternalException`

Tag creation failed.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no loaded tag type that can be used when tagging referenceToTag with tagMode.

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

### `P:Autodesk.Revit.DB.IndependentTag.MergeElbows`

Member kind: property
Symbol: `Autodesk.Revit.DB.IndependentTag.MergeElbows`

#### Summary

Identifies if the leaders' elbows are merged or not. If they are are merged, all elbows are in the same point and they move together.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The IndependentTag object does not have a tag behavior.
-or-
When setting this property: For this tag leaders are not allowed.
-or-
When setting this property: Can't merge elbows for tags that are part of a multi-reference annotation.

#### Since

2023

### `P:Autodesk.Revit.DB.IndependentTag.LeadersPresentationMode`

Member kind: property
Symbol: `Autodesk.Revit.DB.IndependentTag.LeadersPresentationMode`

#### Summary

Identifies the Presentation Mode that is applied to tag leaders.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The LeadersPresentationMode LeadersPresentationMode.ShowOnlyOne or LeadersPresentationMode.ShowSpecificLeaders can't be set to a tag with only one leader.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The IndependentTag object does not have a tag behavior.
-or-
When setting this property: For this tag leaders are not allowed.

#### Since

2023

### `P:Autodesk.Revit.DB.IndependentTag.RotationAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.IndependentTag.RotationAngle`

#### Summary

The rotation angle of the tag relative to its view

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Angle can only be changed for AnyModelDirection orientation

#### Since

2022

### `P:Autodesk.Revit.DB.IndependentTag.MultiLeader`

Member kind: property
Symbol: `Autodesk.Revit.DB.IndependentTag.MultiLeader`

#### Summary

Returns if the tag if referencing multiple elements and/or sub-elements.

#### Since

2022

### `P:Autodesk.Revit.DB.IndependentTag.LeaderEndCondition`

Member kind: property
Symbol: `Autodesk.Revit.DB.IndependentTag.LeaderEndCondition`

#### Summary

The leader end condition of the tag, such as if the end of the leader is attached to the host or free floating.

#### Remarks

`T:Autodesk.Revit.DB.LeaderEndCondition` enumerates the supported leader end conditions.
Material tags and material keynotes can only use the free end condition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: LeaderEndCondition cannot be assigned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The IndependentTag object does not have a tag behavior.

### `P:Autodesk.Revit.DB.IndependentTag.HasLeader`

Member kind: property
Symbol: `Autodesk.Revit.DB.IndependentTag.HasLeader`

#### Summary

Identifies if a tag has at least one visible leader, or if all leaders are hidden.

#### Value

True if at least one leader is visible, false if all leaders are hidden. Setting the property to true, it will make all leaders visible.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The IndependentTag object does not have a tag behavior.
-or-
When setting this property: For this tag leaders are not allowed.

### `P:Autodesk.Revit.DB.IndependentTag.TagHeadPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.IndependentTag.TagHeadPosition`

#### Summary

The position of the head of tag in model coordinates.

#### Remarks

The depth of the tag head position in the view does not matter
because tags are drawn over model geometry in the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.IndependentTag.TagOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.IndependentTag.TagOrientation`

#### Summary

The tag orientation of the tag's head, such as horizontal or vertical.

#### Remarks

`T:Autodesk.Revit.DB.TagOrientation` for the supported orientations.
Tags from types that have rotate with component turned on ignore the TagOrientation property.
Tags that are not in tag mode ignores the TagOrientation property.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.IndependentTag.IsOrphaned`

Member kind: property
Symbol: `Autodesk.Revit.DB.IndependentTag.IsOrphaned`

#### Summary

Identifies if the tag is orphaned or not.

#### Remarks

Orphaned tags are those tags that are associated with one or more linked host that is missing.
Tags become orphaned when one or more associated linked host is missing from the link.

### `P:Autodesk.Revit.DB.IndependentTag.IsMulticategoryTag`

Member kind: property
Symbol: `Autodesk.Revit.DB.IndependentTag.IsMulticategoryTag`

#### Summary

Identifies if it is a multi-category tag or not.

### `P:Autodesk.Revit.DB.IndependentTag.IsMaterialTag`

Member kind: property
Symbol: `Autodesk.Revit.DB.IndependentTag.IsMaterialTag`

#### Summary

Identifies if it is a material tag or not.

### `P:Autodesk.Revit.DB.IndependentTag.TagText`

Member kind: property
Symbol: `Autodesk.Revit.DB.IndependentTag.TagText`

#### Summary

The text associated with the tag. If there are several strings assiciated with the tag, the strings will be returned concatenated.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The IndependentTag object does not have a tag behavior.
-or-
The tagging element is in the link.

### `P:Autodesk.Revit.DB.IndependentTag.MultiReferenceAnnotationId`

Member kind: property
Symbol: `Autodesk.Revit.DB.IndependentTag.MultiReferenceAnnotationId`

#### Summary

The multi-reference annotation which owns this tag.

#### Remarks

`!:Autodesk::Revit::DB::MultiReferenceAnnotation` for more information.

### `T:Autodesk.Revit.DB.IndependentTag`

Member kind: type
Symbol: `Autodesk.Revit.DB.IndependentTag`

#### Summary

Represents tag annotations in Revit.

#### Remarks

IndependentTag represents single-category tags, multi-category tags, material tags, and zone tags.
IndependentTag is also the base class for other annotations like keynote tags and span symbols.
Room, area and space tags are not derived from IndependentTag. `!:Autodesk::Revit::DB::SpatialElementTag` for more information.

### `T:Autodesk.Revit.DB.TagMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.TagMode`

#### Summary

The modes of tag creation that are supported for IndependentTags.

### `F:Autodesk.Revit.DB.TagMode.TM_ADDBY_MATERIAL`

Member kind: field
Symbol: `Autodesk.Revit.DB.TagMode.TM_ADDBY_MATERIAL`

#### Summary

Add a material tag.

### `F:Autodesk.Revit.DB.TagMode.TM_ADDBY_MULTICATEGORY`

Member kind: field
Symbol: `Autodesk.Revit.DB.TagMode.TM_ADDBY_MULTICATEGORY`

#### Summary

Add a multi-category tag.

### `F:Autodesk.Revit.DB.TagMode.TM_ADDBY_CATEGORY`

Member kind: field
Symbol: `Autodesk.Revit.DB.TagMode.TM_ADDBY_CATEGORY`

#### Summary

Add a single category tag.

### `T:Autodesk.Revit.DB.TagOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.TagOrientation`

#### Summary

An enumerated type listing tag orientation options that are supported by IndependentTags.

### `F:Autodesk.Revit.DB.TagOrientation.AnyModelDirection`

Member kind: field
Symbol: `Autodesk.Revit.DB.TagOrientation.AnyModelDirection`

#### Summary

The orientation of tag is Model.

### `F:Autodesk.Revit.DB.TagOrientation.Vertical`

Member kind: field
Symbol: `Autodesk.Revit.DB.TagOrientation.Vertical`

#### Summary

The Orientation of tag is Vertical.

### `F:Autodesk.Revit.DB.TagOrientation.Horizontal`

Member kind: field
Symbol: `Autodesk.Revit.DB.TagOrientation.Horizontal`

#### Summary

The Orientation of tag is Horizontal.

### `T:Autodesk.Revit.DB.LeadersPresentationMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.LeadersPresentationMode`

#### Since

2023

#### Summary

Leaders Presentation Mode.

#### Since

2023

### `F:Autodesk.Revit.DB.LeadersPresentationMode.ShowSpecificLeaders`

Member kind: field
Symbol: `Autodesk.Revit.DB.LeadersPresentationMode.ShowSpecificLeaders`

#### Summary

Show specific leaders.

### `F:Autodesk.Revit.DB.LeadersPresentationMode.ShowOnlyOne`

Member kind: field
Symbol: `Autodesk.Revit.DB.LeadersPresentationMode.ShowOnlyOne`

#### Summary

Show only one leader.

### `F:Autodesk.Revit.DB.LeadersPresentationMode.HideAll`

Member kind: field
Symbol: `Autodesk.Revit.DB.LeadersPresentationMode.HideAll`

#### Summary

Hide all tag leaders.

### `F:Autodesk.Revit.DB.LeadersPresentationMode.ShowAll`

Member kind: field
Symbol: `Autodesk.Revit.DB.LeadersPresentationMode.ShowAll`

#### Summary

Show all tag leaders.

### `T:Autodesk.Revit.DB.LeaderEndCondition`

Member kind: type
Symbol: `Autodesk.Revit.DB.LeaderEndCondition`

#### Summary

An enumerated type listing Leader end conditions that are supported for IndependentTags.

### `F:Autodesk.Revit.DB.LeaderEndCondition.Free`

Member kind: field
Symbol: `Autodesk.Revit.DB.LeaderEndCondition.Free`

#### Summary

The Leader of the tag is free.

### `F:Autodesk.Revit.DB.LeaderEndCondition.Attached`

Member kind: field
Symbol: `Autodesk.Revit.DB.LeaderEndCondition.Attached`

#### Summary

The Leader of the tag is attached.

### `M:ElementSystemBase.getAddDeleteMembersParentAtoms(Arr<Atom>*)`

Member kind: method
Symbol: `ElementSystemBase.getAddDeleteMembersParentAtoms(Arr<Atom>*)`

### `M:ElementSystemBase.getLayoutParentAtoms(Arr<Atom>*)`

Member kind: method
Symbol: `ElementSystemBase.getLayoutParentAtoms(Arr<Atom>*)`

### `M:ElementSystemBase.getTypeInfos`

Member kind: method
Symbol: `ElementSystemBase.getTypeInfos`

### `M:ElementSystemBase.isAssociatedWithElem(ElementId)`

Member kind: method
Symbol: `ElementSystemBase.isAssociatedWithElem(ElementId)`

### `M:ElementSystemBase.getHeldElem(System.Int32)`

Member kind: method
Symbol: `ElementSystemBase.getHeldElem(System.Int32)`

### `M:ElementSystemBase.purgeUnusedHeldElems`

Member kind: method
Symbol: `ElementSystemBase.purgeUnusedHeldElems`

### `M:ElementSystemBase.getHeldElemsOfTypeFW(Arr<HeldElement**>*,ElementTypeKey)`

Member kind: method
Symbol: `ElementSystemBase.getHeldElemsOfTypeFW(Arr<HeldElement**>*,ElementTypeKey)`

### `M:ElementSystemBase.getHeldElemByIdx(Arr<System.Int32>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `ElementSystemBase.getHeldElemByIdx(Arr<System.Int32>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:ElementSystemBase.getHeldElemByElemId(ElementId)`

Member kind: method
Symbol: `ElementSystemBase.getHeldElemByElemId(ElementId)`

### `M:ElementSystemBase.getHeldElemFW(System.Int32)`

Member kind: method
Symbol: `ElementSystemBase.getHeldElemFW(System.Int32)`

### `F:ElemTypeInfo.m_type`

Member kind: field
Symbol: `ElemTypeInfo.m_type`

### `F:ElemTypeInfo.m_symbolId`

Member kind: field
Symbol: `ElemTypeInfo.m_symbolId`

### `F:ElemTypeInfo.m_oldParamSet`

Member kind: field
Symbol: `ElemTypeInfo.m_oldParamSet`

### `F:ElemTypeInfo.m_paramSet`

Member kind: field
Symbol: `ElemTypeInfo.m_paramSet`

### `F:ElemTypeInfo.m_oldSymbolId`

Member kind: field
Symbol: `ElemTypeInfo.m_oldSymbolId`

### `M:ElemTypeInfo.updateElementProperties(ControlledConstDocAccess!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,HeldElement!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `ElemTypeInfo.updateElementProperties(ControlledConstDocAccess!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,HeldElement!System.Runtime.CompilerServices.IsConst*)`

### `M:ElemTypeInfo.updateElementPosition(ControlledConstDocAccess!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,HeldElement!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `ElemTypeInfo.updateElementPosition(ControlledConstDocAccess!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,HeldElement!System.Runtime.CompilerServices.IsConst*)`

### `M:ElemTypeInfo.createElement(ADocument*,HeldElement*,Element!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `ElemTypeInfo.createElement(ADocument*,HeldElement*,Element!System.Runtime.CompilerServices.IsConst*)`

### `M:ElemTypeInfo.clearOldValues`

Member kind: method
Symbol: `ElemTypeInfo.clearOldValues`

### `M:ElemTypeInfo.hasChanged`

Member kind: method
Symbol: `ElemTypeInfo.hasChanged`

### `T:ElemTypeInfo`

Member kind: type
Symbol: `ElemTypeInfo`

### `F:HeldElement.m_active`

Member kind: field
Symbol: `HeldElement.m_active`

### `F:HeldElement.m_elemId`

Member kind: field
Symbol: `HeldElement.m_elemId`

### `F:HeldElement.m_wholeOffset`

Member kind: field
Symbol: `HeldElement.m_wholeOffset`

### `F:HeldElement.m_instanceInfo`

Member kind: field
Symbol: `HeldElement.m_instanceInfo`

### `M:FamilyInstanceKeeper.changeSymbolId(ElementId!System.Runtime.CompilerServices.IsConst)`

Member kind: method
Symbol: `FamilyInstanceKeeper.changeSymbolId(ElementId!System.Runtime.CompilerServices.IsConst)`

### `M:FamilyInstanceKeeper.getNewValueForStep(ParamStorage*)`

Member kind: method
Symbol: `FamilyInstanceKeeper.getNewValueForStep(ParamStorage*)`

### `P:Autodesk.Revit.DB.Structure.FabricRoundingManager.ApplicableSegmentLengthRoundingMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricRoundingManager.ApplicableSegmentLengthRoundingMethod`

#### Summary

The applicable rounding method for fabric segments.

#### Remarks

IsActiveOnElement property of ReinforcementSettings RebarRoundingManager has to be true.
ApplicableSegmentLengthRoundingMethod is meaningless if ReinforcementSettings RebarRoundingManager IsActiveOnElement is false.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.FabricRoundingManager.ApplicableSegmentLengthRounding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricRoundingManager.ApplicableSegmentLengthRounding`

#### Summary

The applicable rounding for fabric segments.

#### Remarks

IsActiveOnElement property of ReinforcementSettings RebarRoundingManager has to be true.
ApplicableSegmentLengthRounding is meaningless if ReinforcementSettings RebarRoundingManager IsActiveOnElement is false.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.FabricRoundingManager.ApplicableTotalLengthRoundingMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricRoundingManager.ApplicableTotalLengthRoundingMethod`

#### Summary

The applicable rounding method for Cut Overall Length and Cut Overall Width parameters.

#### Remarks

IsActiveOnElement property of ReinforcementSettings FabricRoundingManager has to be true.
ApplicableTotalLengthRoundingMethod is meaningless if ReinforcementSettings FabricRoundingManager IsActiveOnElement is false.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.FabricRoundingManager.ApplicableTotalLengthRounding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricRoundingManager.ApplicableTotalLengthRounding`

#### Summary

The applicable rounding for Cut Overall Length and Cut Overall Width parameters.

#### Remarks

IsActiveOnElement property of ReinforcementSettings FabricRoundingManager has to be true.
ApplicableTotalLengthRounding is meaningless if ReinforcementSettings FabricRoundingManager IsActiveOnElement is false.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.FabricRoundingManager.SegmentLengthRoundingMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricRoundingManager.SegmentLengthRoundingMethod`

#### Summary

Identifies the segment length rounding method

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: IsActiveOnElement property is false.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.FabricRoundingManager.SegmentLengthRounding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricRoundingManager.SegmentLengthRounding`

#### Summary

The rounding for fabric segments.

#### Remarks

IsActiveOnElement property has to be true. SegmentLengthRounding is meaningless if IsActiveOnElement is false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for value is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The rounding value is not a positive value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: IsActiveOnElement property is false.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.FabricRoundingManager.TotalLengthRoundingMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricRoundingManager.TotalLengthRoundingMethod`

#### Summary

Identifies the total length rounding method

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: IsActiveOnElement property is false.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.FabricRoundingManager.TotalLengthRounding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricRoundingManager.TotalLengthRounding`

#### Summary

The rounding for Cut Overall Length and Cut Overall Width parameters.

#### Remarks

IsActiveOnElement property has to be true. TotalLengthRounding is meaningless if IsActiveOnElement is false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for value is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The rounding value is not a positive value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: IsActiveOnElement property is false.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.FabricRoundingManager.ApplicableReinforcementRoundingSource`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricRoundingManager.ApplicableReinforcementRoundingSource`

#### Summary

Identifies the source of the rounding settings for this element.

#### Remarks

For a FabricSheet or FabricArea element, this could be FabricArea, FabricSheetType, or ReinforcementSettings. For a FabricSheetType, this could be FabricSheetType or ReinforcementSettings.
All FabricSheets hosted by common FabricArea must have common reinforcement rounding overrides so at instance level its overrides are in FabricArea, not in FabricSheets.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.FabricRoundingManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricRoundingManager`

#### Summary

Provides access to element reinforcement roundings overrides.

#### Remarks

An instance of this class can be obtained from specific FabricSheetType or individual FabricSheet or FabricArea elements to apply overrides different from the global settings for the project.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarRoundingManager.ApplicableSegmentLengthRoundingMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarRoundingManager.ApplicableSegmentLengthRoundingMethod`

#### Summary

The applicable rounding method for shared parameters used by rebar.

#### Remarks

IsActiveOnElement property of ReinforcementSettings RebarRoundingManager has to be true.
ApplicableSegmentLengthRoundingMethod is meaningless if ReinforcementSettings RebarRoundingManager IsActiveOnElement is false.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarRoundingManager.ApplicableTotalLengthRoundingMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarRoundingManager.ApplicableTotalLengthRoundingMethod`

#### Summary

The applicable rounding method for Bar Length and Total Bar Length parameters.

#### Remarks

IsActiveOnElement property of ReinforcementSettings RebarRoundingManager has to be true.
ApplicableTotalLengthRoundingMethod is meaningless if ReinforcementSettings RebarRoundingManager IsActiveOnElement is false.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarRoundingManager.ApplicableSegmentLengthRounding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarRoundingManager.ApplicableSegmentLengthRounding`

#### Summary

The applicable rounding for shared parameters used by rebar.

#### Remarks

IsActiveOnElement property of ReinforcementSettings RebarRoundingManager has to be true.
ApplicableSegmentLengthRounding is meaningless if ReinforcementSettings RebarRoundingManager IsActiveOnElement is false.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarRoundingManager.ApplicableTotalLengthRounding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarRoundingManager.ApplicableTotalLengthRounding`

#### Summary

The applicable rounding for Bar Length and Total Bar Length parameters.

#### Remarks

IsActiveOnElement property of ReinforcementSettings RebarRoundingManager has to be true.
ApplicableTotalLengthRounding is meaningless if ReinforcementSettings RebarRoundingManager IsActiveOnElement is false.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarRoundingManager.SegmentLengthRoundingMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarRoundingManager.SegmentLengthRoundingMethod`

#### Summary

Identifies the segment length rounding method

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: IsActiveOnElement property is false.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarRoundingManager.SegmentLengthRounding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarRoundingManager.SegmentLengthRounding`

#### Summary

The rounding for shared parameters used by rebar.

#### Remarks

IsActiveOnElement property has to be true. SegmentLengthRounding is meaningless if IsActiveOnElement is false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for value is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The rounding value is not a positive value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: IsActiveOnElement property is false.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarRoundingManager.TotalLengthRoundingMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarRoundingManager.TotalLengthRoundingMethod`

#### Summary

Identifies the total length rounding method

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: IsActiveOnElement property is false.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.RebarRoundingManager.TotalLengthRounding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarRoundingManager.TotalLengthRounding`

#### Summary

The rounding for Bar Length and Total Bar Length parameters.

#### Remarks

IsActiveOnElement property has to be true. TotalLengthRounding is meaningless if IsActiveOnElement is false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for value is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The rounding value is not a positive value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: IsActiveOnElement property is false.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarRoundingManager.ApplicableReinforcementRoundingSource`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarRoundingManager.ApplicableReinforcementRoundingSource`

#### Summary

Identifies the source of the rounding settings for this element.

#### Remarks

For a Rebar or RebarInSystem element, this could be Rebar, RebarType, or ReinforcementSettings. For a RebarType, this could be RebarType or ReinforcementSettings.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarRoundingManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarRoundingManager`

#### Summary

Provides access to element reinforcement roundings overrides.

#### Remarks

An instance of this class can be obtained from specific RebarTypes or individual Rebar or RebarInSystem elements to apply overrides different from the global settings for the project.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.ReinforcementRoundingManager.GetLengthUnitTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementRoundingManager.GetLengthUnitTypeId`

#### Summary

Gets the identifier of the length unit quantifying the reinforcement rounding values.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.ReinforcementRoundingManager.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementRoundingManager.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.ReinforcementRoundingManager.IsActiveOnElement`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementRoundingManager.IsActiveOnElement`

#### Summary

Defines whether reinforcement rounding is activated for the particular element.

#### Remarks

If these overrides relate to ReinforcementSettings, this property is shared for Rebar and Fabric related elements. Toggling this value will toggle the settings for both kinds of Reinforcement elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: Reinforcement rounding overrides for this element cannot be enabled because overrides are not enabled for ReinforcementSettings.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.ReinforcementRoundingManager.Element`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementRoundingManager.Element`

#### Summary

The owner of the reinforcement rounding overrides.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.ReinforcementRoundingManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementRoundingManager`

#### Summary

A base class providing access to reinforcement rounding overrides for structural elements.

#### Remarks

Subclasses of this class are used to access the override settings for Rebar elements and types or Fabric elements and types.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.ReinforcementRoundingSource`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementRoundingSource`

#### Summary

An enumerated type listing the possible sources for reinforcement rounding overrides.

#### Since

2014

#### Since

2014

### `F:Autodesk.Revit.DB.Structure.ReinforcementRoundingSource.Element`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementRoundingSource.Element`

#### Summary

Rounding overrides from Rebar or RebarInSystem or FabricSheet or FabricArea instances are in use.

### `F:Autodesk.Revit.DB.Structure.ReinforcementRoundingSource.Type`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementRoundingSource.Type`

#### Summary

Rounding overrides from the rebar types or fabric types are in use.

### `F:Autodesk.Revit.DB.Structure.ReinforcementRoundingSource.ReinforcementSettings`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementRoundingSource.ReinforcementSettings`

#### Summary

Rounding overrides from the ReinforcementSettings are in use.

### `F:Autodesk.Revit.DB.Structure.ReinforcementRoundingSource.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementRoundingSource.None`

#### Summary

No rounding overrides are in use.

### `M:Autodesk.Revit.DB.Structure.FabricAreaType.CreateDefaultFabricAreaType(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricAreaType.CreateDefaultFabricAreaType(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new FabricAreaType object with a default name.

#### Parameter `aDoc`

The document.

#### Returns

The newly created type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.FabricAreaType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricAreaType`

#### Summary

A FabricAreaType object is used in FabricArea object generation.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricArea.IsCoverOffsetValid(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.IsCoverOffsetValid(System.Double)`

#### Summary

Identifies if the specified value is valid for use as a cover offset.

#### Remarks

The cover offset must be less than or equal to the host thickness.

#### Parameter `coverOffset`

The cover offset value.

#### Returns

True if the value is valid, false if the value is invalid.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricArea.IsValidMinorLapSplice(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.IsValidMinorLapSplice(System.Double)`

#### Summary

Identifies if the specified value is valid for use as a minor lap splice.

#### Remarks

The minor lap splice should be less than or equal to half of the overall width.

#### Parameter `minorLapSplice`

The minor lap splice value.

#### Returns

True if the value is valid, false if the value is invalid.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricArea.IsValidMajorLapSplice(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.IsValidMajorLapSplice(System.Double)`

#### Summary

Identifies if the specified value is valid for use as a major lap splice.

#### Remarks

The major lap splice should be less than or equal to half of the overall length.

#### Parameter `majorLapSplice`

The major lap splice value.

#### Returns

True if the value is valid, false if the value is invalid.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricArea.GetReinforcementRoundingManager`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.GetReinforcementRoundingManager`

#### Summary

Returns an object for managing reinforcement rounding override settings.

#### Returns

The rounding manager.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.FabricArea.RemoveFabricReinforcementSystem(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.FabricArea)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.RemoveFabricReinforcementSystem(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.FabricArea)`

#### Summary

Deletes the specified FabricArea, and converts its FabricSheet elements
to equivalent Single Fabric Sheet elements.

#### Parameter `doc`

The document.

#### Parameter `system`

An FabricArea Reinforcement element in the document.

#### Returns

The ids of the newly created Single Fabric Sheet elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element system was not found in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.FabricArea.GetFabricSheetElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.GetFabricSheetElementIds`

#### Summary

Retrieves the identifiers of all the FabricSheet Elements in the FabricArea.

#### Returns

A collection of ElementIds of FabricSheet elements.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricArea.GetBoundaryCurveIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.GetBoundaryCurveIds`

#### Summary

Retrieves the identifiers of the set of curves forming the boundary of the Fabric Area.

#### Remarks

Each ElementId in the collection is an Id of an Element of type CurveElem.

#### Returns

A collection of ElementIds of FabricAreaCurve elements.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.FabricArea.CopyCurveLoopsInSketch`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.CopyCurveLoopsInSketch`

#### Summary

Creates copies of the CurveLoops in the FabricArea sketch.

#### Returns

The copy of the curve loops.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricArea.GetTotalSheetMass`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.GetTotalSheetMass`

#### Summary

Calculates the total sheet mass: Volume of Wire * Unit Weight.

#### Returns

The total sheet mass.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricArea.GetValidViewsForTags`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.GetValidViewsForTags`

#### Summary

Gets ids of the views where tags and symbols can be placed for the FabricArea and/or FabricSheets

#### Returns

The collection of View ElementIds.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.FabricArea.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a FabricArea based on a host boundary.

#### Parameter `aDoc`

The document.

#### Parameter `hostElement`

The element that will host the FabricArea. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.

#### Parameter `majorDirection`

A vector to define the major direction of the FabricArea.

#### Parameter `fabricAreaTypeId`

The id of the FabricAreaType.

#### Parameter `fabricSheetTypeId`

The id of the FabricSheetType.

#### Returns

The newly created FabricArea.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element hostElement was not found in the given document.
-or-
the host Element is not a valid host for Area Reinforcement, Path Reinforcement, Fabric Area or Fabric Sheet.
-or-
fabricAreaTypeId should refer to an FabricAreaType element.
-or-
fabricSheetTypeId should refer to an FabricSheetType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

majorDirection has zero length.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.FabricArea.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a FabricArea from an array of curves.

#### Parameter `aDoc`

The document.

#### Parameter `hostElement`

The element that will host the FabricArea. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.

#### Parameter `curveLoops`

An array of curves that will define the outline of the FabricArea.
This includes curves defining openings in the interior of the area.

#### Parameter `majorDirection`

A vector to define the major direction of the FabricArea.

#### Parameter `majorDirectionOrigin`

An origin point of the major direction line

#### Parameter `fabricAreaTypeId`

The id of the FabricAreaType.

#### Parameter `fabricSheetTypeId`

The id of the FabricSheetType.

#### Returns

The newly created FabricArea.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Not all curveLoops in curveLoops are closed and continuous.
-or-
Not all curveLoops in curveLoops are in the same plane.
-or-
curveLoops should only contain lines or arcs.
-or-
The element hostElement was not found in the given document.
-or-
the host Element is not a valid host for Area Reinforcement, Path Reinforcement, Fabric Area or Fabric Sheet.
-or-
fabricAreaTypeId should refer to an FabricAreaType element.
-or-
fabricSheetTypeId should refer to an FabricSheetType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

majorDirection has zero length.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.FabricArea.FabricLocation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.FabricLocation`

#### Summary

The Fabric location in the host.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricArea.FabricSheetTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.FabricSheetTypeId`

#### Summary

The id of the Fabric Sheet Type for this element.

#### Remarks

Changing the value of this property causes change of MinorLapSplice and MajorLapSplice properties if needed

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: fabricSheetTypeId is not a Fabric Sheet Type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricArea.MinorSheetAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.MinorSheetAlignment`

#### Summary

The fabric sheet alignment in the fabric distribution in the minor direction.

#### Remarks

Changing the value of this property causes change of MinorLapSplice and LapSplicePosition properties if needed

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricArea.MajorSheetAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.MajorSheetAlignment`

#### Summary

The fabric sheet alignment in the fabric distribution in the major direction.

#### Remarks

Changing the value of this property causes change of MajorLapSplice and LapSplicePosition properties if needed

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricArea.DirectionOrigin`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.DirectionOrigin`

#### Summary

The Origin Point of the Major Direction of the Fabric Area.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.FabricArea.Direction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.Direction`

#### Summary

The Major Direction of the Fabric Area.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricArea.FabricAreaType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.FabricAreaType`

#### Summary

The type of the Fabric Area.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricArea.TagViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.TagViewId`

#### Summary

The element of the view in which to tag new members of this element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: tagViewId is not a valid view for tagging the FabricArea or FabricSheets.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricArea.CoverOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.CoverOffset`

#### Summary

The additional cover offset of the fabric distribution.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricArea.MinorLapSpliceLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.MinorLapSpliceLength`

#### Summary

The fabric lap splice length in the fabric distribution in the minor direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: minorLapSpliceLength is greater than the half of the overall width.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricArea.MajorLapSpliceLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.MajorLapSpliceLength`

#### Summary

The fabric lap splice length in the fabric distribution in the major direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: majorLapSpliceLength is greater than the half of the overall length.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricArea.LapSplicePosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.LapSplicePosition`

#### Summary

The fabric lap splice position in the fabric distribution.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricArea.SketchId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.SketchId`

#### Summary

The id of the Sketch element for this element.

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.FabricArea.HostId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FabricArea.HostId`

#### Summary

The id of the Host element for the fabric area.

#### Since

2013

### `T:Autodesk.Revit.DB.Structure.FabricArea`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricArea`

#### Summary

An object that represents an Fabric Area Distribution within the Autodesk Revit project. It is container for Fabric Sheet elements.

#### Remarks

This object derived from the Element base object and such supports all the
methods of that object such as the ability to retrieve the parameters of that object.
The Fabric Area element is available only in the Autodesk Revit Structure product.

#### Since

2013

### `T:Autodesk.Revit.DB.Structure.BentFabricStraightWiresLocation`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BentFabricStraightWiresLocation`

#### Summary

Bent Fabric straight wires location.
The side on wich straight wires will be loacted is determined by the start and end point of the first bent profile segment that specifies the direction of the curve loop on plane.

#### Since

2017

#### Since

2017

### `F:Autodesk.Revit.DB.Structure.BentFabricStraightWiresLocation.Left`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BentFabricStraightWiresLocation.Left`

#### Summary

Fabric straight wires are located on the left side of bent wires.

### `F:Autodesk.Revit.DB.Structure.BentFabricStraightWiresLocation.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BentFabricStraightWiresLocation.Right`

#### Summary

Fabric straight wires are located on the right side of bent wires.

### `T:Autodesk.Revit.DB.Structure.BentFabricBendDirection`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BentFabricBendDirection`

#### Summary

Direction in which FabricSheet is bent.

#### Since

2016

#### Since

2016

### `F:Autodesk.Revit.DB.Structure.BentFabricBendDirection.Minor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BentFabricBendDirection.Minor`

#### Summary

FabricSheet is bent along minor direction axis.

### `F:Autodesk.Revit.DB.Structure.BentFabricBendDirection.Major`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BentFabricBendDirection.Major`

#### Summary

FabricSheet is bent along major direction axis.

### `T:Autodesk.Revit.DB.Structure.FabricHostReference`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricHostReference`

#### Summary

Controls if Single Fabric Sheet should be cut by the Host Cover.

#### Since

2015

#### Since

2015

### `F:Autodesk.Revit.DB.Structure.FabricHostReference.CutByCover`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricHostReference.CutByCover`

#### Summary

The fabric is cut by the host cover.

### `F:Autodesk.Revit.DB.Structure.FabricHostReference.NotCutByCover`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricHostReference.NotCutByCover`

#### Summary

The fabric is not cut by the host cover.

### `T:Autodesk.Revit.DB.Structure.FabricTagComponentReference`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricTagComponentReference`

#### Summary

How FabricSheet tag text will be aligned to the FabricSheet symbol.

### `F:Autodesk.Revit.DB.Structure.FabricTagComponentReference.Intersection`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricTagComponentReference.Intersection`

#### Summary

Tag and Leader will reference the intersection of the major and minor axes.

### `F:Autodesk.Revit.DB.Structure.FabricTagComponentReference.Diagonal`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricTagComponentReference.Diagonal`

#### Summary

Tag and Leader will reference the symbol diagonal.

### `F:Autodesk.Revit.DB.Structure.FabricTagComponentReference.MinorAxis`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricTagComponentReference.MinorAxis`

#### Summary

Tag and Leader will reference the symbol minor direction axis.

### `F:Autodesk.Revit.DB.Structure.FabricTagComponentReference.MajorAxis`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricTagComponentReference.MajorAxis`

#### Summary

Tag and Leader will reference the symbol major direction axis.

### `T:Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern`

#### Summary

The pattern for how the wires in Fabric Sheet are laid out.

### `F:Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern.QuantitativeSpacing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern.QuantitativeSpacing`

#### Summary

Multiple groups of wires with a specific spacing and diameter

### `F:Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern.NumberWithSpacing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern.NumberWithSpacing`

#### Summary

Both the spacing between the rebars and the number of rebars are constant based on input.

### `F:Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern.MaximumSpacing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern.MaximumSpacing`

#### Summary

The maximum distance between the rebars is specified by input,
and the number of rebars changes based on the length of rebar set.

### `F:Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern.FixedNumber`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern.FixedNumber`

#### Summary

The spacing between the rebars is adjustable,
but the number of bars is constant based on input.

### `F:Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern.ActualSpacing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern.ActualSpacing`

#### Summary

The spacing between the rebars is fixed and specified by input.

### `T:Autodesk.Revit.DB.Structure.FabricSheetAlignment`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetAlignment`

#### Summary

Fabric Sheet alignment in the fabric distribution

#### Since

2013

#### Since

2013

### `F:Autodesk.Revit.DB.Structure.FabricSheetAlignment.BothEdges`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetAlignment.BothEdges`

#### Summary

The fabric sheets are aligned to starting and ending edge.

### `F:Autodesk.Revit.DB.Structure.FabricSheetAlignment.EndingEdge`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetAlignment.EndingEdge`

#### Summary

The fabric sheets are aligned to ending edge.

### `F:Autodesk.Revit.DB.Structure.FabricSheetAlignment.StartingEdge`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetAlignment.StartingEdge`

#### Summary

The fabric sheets are aligned to starting edge.

### `F:Autodesk.Revit.DB.Structure.FabricSheetAlignment.Null`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricSheetAlignment.Null`

#### Summary

The fabric sheets are alignment is not set.

### `T:Autodesk.Revit.DB.Structure.FabricLapSplicePosition`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricLapSplicePosition`

#### Summary

Fabric lap splice position in the fabric distribution

#### Since

2013

#### Since

2013

### `F:Autodesk.Revit.DB.Structure.FabricLapSplicePosition.MinorPassingStagger`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricLapSplicePosition.MinorPassingStagger`

#### Summary

Every second fabric sheet is shifted half way and reversed in minor direction.

### `F:Autodesk.Revit.DB.Structure.FabricLapSplicePosition.MinorHalfwayStagger`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricLapSplicePosition.MinorHalfwayStagger`

#### Summary

Every second fabric sheet is shifted half way in minor direction.

### `F:Autodesk.Revit.DB.Structure.FabricLapSplicePosition.MajorPassingStagger`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricLapSplicePosition.MajorPassingStagger`

#### Summary

Every second fabric sheet is shifted half way and reversed in major direction.

### `F:Autodesk.Revit.DB.Structure.FabricLapSplicePosition.MajorHalfwayStagger`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricLapSplicePosition.MajorHalfwayStagger`

#### Summary

Every second fabric sheet is shifted half way in major direction.

### `F:Autodesk.Revit.DB.Structure.FabricLapSplicePosition.Aligned`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricLapSplicePosition.Aligned`

#### Summary

The fabric sheets are aligned.

### `T:Autodesk.Revit.DB.Structure.FabricLocation`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FabricLocation`

#### Summary

Fabric location in the host

#### Since

2013

#### Since

2013

### `F:Autodesk.Revit.DB.Structure.FabricLocation.BottomOrInternal`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricLocation.BottomOrInternal`

#### Summary

The fabric is on the bottom face of a floor host, or on the internal face of a wall host.

### `F:Autodesk.Revit.DB.Structure.FabricLocation.TopOrExternal`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.FabricLocation.TopOrExternal`

#### Summary

The fabric is on the top face of a floor host, or on the external face of a wall host.

### `M:Autodesk.Revit.DB.FDXJSONExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FDXJSONExportOptions.#ctor`

#### Summary

Constructs a new instance of FDXExportOptions with default values of all properties.

#### Since

2023

### `T:Autodesk.Revit.DB.FDXJSONExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.FDXJSONExportOptions`

#### Summary

The export options used for exporting FDX payload to a local JSON payload.

#### Since

2023

### `M:Autodesk.Revit.DB.FDXExportOptions.GetCustomHeaders`

Member kind: method
Symbol: `Autodesk.Revit.DB.FDXExportOptions.GetCustomHeaders`

#### Summary

Gets the map of a name value pair

#### Since

2023

### `M:Autodesk.Revit.DB.FDXExportOptions.SetCustomHeaders(System.Collections.Generic.IDictionary{System.String,System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FDXExportOptions.SetCustomHeaders(System.Collections.Generic.IDictionary{System.String,System.String})`

#### Summary

Set a map of a name value pair

#### Parameter `customHeaders`

A map of a name value pair

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `P:Autodesk.Revit.DB.FDXExportOptions.SourceFileVersionUrn`

Member kind: property
Symbol: `Autodesk.Revit.DB.FDXExportOptions.SourceFileVersionUrn`

#### Summary

The "sourceFileVersionUrn" parameter to pass during FDX fulfillment creation.

#### Since

2023

### `P:Autodesk.Revit.DB.FDXExportOptions.FulfillmentId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FDXExportOptions.FulfillmentId`

#### Summary

The string ID of an open FDX fulfillment on the specified exchange. If non-empty, the open fulfillment will be used for export.
If empty, Revit will create a new fulfillment and close the fulfillment if export is successful.

#### Since

2023

### `P:Autodesk.Revit.DB.FDXExportOptions.LogOutputPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.FDXExportOptions.LogOutputPath`

#### Summary

Path to write JSON log file of FDX fulfillment. Should have *.json extension. No log is written if path is empty.

#### Since

2023

### `P:Autodesk.Revit.DB.FDXExportOptions.LogVerbosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.FDXExportOptions.LogVerbosity`

#### Summary

Value specifying the level of FDX logging - see FDXLogVerbosity.

#### Since

2023

### `M:Autodesk.Revit.DB.FDXExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FDXExportOptions.#ctor`

#### Summary

Constructs a new instance of FDXExportOptions with default values of all properties.

#### Since

2023

### `T:Autodesk.Revit.DB.FDXExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.FDXExportOptions`

#### Summary

The export options used for publishing to an FDX exchange.

#### Since

2023

### `T:Autodesk.Revit.DB.FDXLogVerbosity`

Member kind: type
Symbol: `Autodesk.Revit.DB.FDXLogVerbosity`

#### Since

2024

#### Summary

An enumeration of log verbosity levels for FDX remote exchange.

#### Since

2024

### `F:Autodesk.Revit.DB.FDXLogVerbosity.All`

Member kind: field
Symbol: `Autodesk.Revit.DB.FDXLogVerbosity.All`

#### Summary

Log all FDX communication and fulfillment statistics. Use only for diagnostic purposes.

### `F:Autodesk.Revit.DB.FDXLogVerbosity.Errors`

Member kind: field
Symbol: `Autodesk.Revit.DB.FDXLogVerbosity.Errors`

#### Summary

In addition to timed statistics, also log all failed requests and responses in their entirety.

### `F:Autodesk.Revit.DB.FDXLogVerbosity.TimedStatistics`

Member kind: field
Symbol: `Autodesk.Revit.DB.FDXLogVerbosity.TimedStatistics`

#### Summary

In addition to basic statistics, also log timing breakdown of requests and events.

### `F:Autodesk.Revit.DB.FDXLogVerbosity.Statistics`

Member kind: field
Symbol: `Autodesk.Revit.DB.FDXLogVerbosity.Statistics`

#### Summary

Log basic information about fulfillment and data sent.

### `F:Autodesk.Revit.DB.FDXLogVerbosity.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.FDXLogVerbosity.None`

#### Summary

No logging output

### `P:Autodesk.Revit.DB.FDXBaseExportOptions.IsIncrementalExport`

Member kind: property
Symbol: `Autodesk.Revit.DB.FDXBaseExportOptions.IsIncrementalExport`

#### Summary

Indicates whether export will be performed incrementally.

#### Since

2023

### `T:Autodesk.Revit.DB.FDXBaseExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.FDXBaseExportOptions`

#### Summary

The base export options used for exporting to an FDX exchange or local JSON payload.

#### Since

2023

### `P:Autodesk.Revit.DB.LocationPoint.Rotation`

Member kind: property
Symbol: `Autodesk.Revit.DB.LocationPoint.Rotation`

#### Summary

The angle of rotation around the insertion point, in radians.

#### Remarks

For view-based elements, the rotation angle is in the plane of the associated view. For model elements,
the rotation angle is measured relative to the default coordinate system. This property is not supported for
some elements supporting LocationPoints, such as AssemblyInstances, Groups, ModelText, Room, and SpotDimensions.

#### Throws

The rotation property is not supported for the Element
related to this LocationPoint.

### `P:Autodesk.Revit.DB.LocationPoint.Point`

Member kind: property
Symbol: `Autodesk.Revit.DB.LocationPoint.Point`

#### Summary

The physical location of the element.

#### Remarks

Setting this property is not supported for
some elements supporting LocationPoints, such as SpotDimensions.

#### Throws

Setting this property is not supported for the Element
related to this LocationPoint.

### `T:Autodesk.Revit.DB.LocationPoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.LocationPoint`

#### Summary

Provides location functionality for all elements that have a single insertion point.

#### Remarks

The location point objects adds additional functionality to its base location object
class. This includes setting the elements location to a specific point and retrieving its
rotation around its insertion point. Inplace families do not have a single insertion point and therefore do not have meaningful LocationPoint data.

### `P:Autodesk.Revit.DB.LocationCurve.JoinType(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.LocationCurve.JoinType(System.Int32)`

#### Summary

Get/change the type of the join at the specified end.

#### Parameter `end`

The end of the location curve driver under question.

#### Remarks

This property allows to get join type of wall and concrete beam and to set wall's join type.
The new join type is expected to be different from the current one for this end.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The element is neither a wall nor a concrete beam when it tries to get the property.
The element is not a wall when it tries to set the property.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

A failure occurred while attempting to set the new type.

### `M:Autodesk.Revit.DB.LocationCurve.set_ElementsAtJoin(System.Int32,Autodesk.Revit.DB.ElementArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LocationCurve.set_ElementsAtJoin(System.Int32,Autodesk.Revit.DB.ElementArray)`

#### Summary

Change the order of elements participating in an end join with this location curve's end

#### Parameter `end`

The end at which we want to change the order of join participants

#### Parameter `elements`

An ordered list of elements

#### Returns

No return value

#### Remarks

The list of elements is expected to be a permutation of the elements already in the join at the end.
It is expected that no new elements will be introduced, and existing ones will not be removed.

### `M:Autodesk.Revit.DB.LocationCurve.get_ElementsAtJoin(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LocationCurve.get_ElementsAtJoin(System.Int32)`

#### Summary

Get all elements joining to the end of this element's location curve

#### Parameter `end`

The end at which the join is to be obtained

#### Returns

An ordered list of element

### `P:Autodesk.Revit.DB.LocationCurve.ElementsAtJoin(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.LocationCurve.ElementsAtJoin(System.Int32)`

#### Summary

Get all elements joining to the end of this element's location curve or change the order of elements participation in the end join with this location curve's end.

#### Parameter `end`

The end at which the join occurs.

#### Remarks

The list of elements is expected to be a permutation of the elements already in the join at the end.
It is expected that no new elements will be introduced, and existing ones will not be removed.

### `P:Autodesk.Revit.DB.LocationCurve.Curve`

Member kind: property
Symbol: `Autodesk.Revit.DB.LocationCurve.Curve`

#### Summary

Provides the ability to get and set the curve of a curve based element.

#### Remarks

This property can be used to set the location of curve based element to any desired
position. Many elements are curve based. Some examples are walls, beams and braces.

### `T:Autodesk.Revit.DB.LocationCurve`

Member kind: type
Symbol: `Autodesk.Revit.DB.LocationCurve`

#### Summary

Provides location functionality for all elements that are based upon a curve.

#### Remarks

The location line objects adds additional functionality to its base location object
class. This includes reading and writing the curve contained within the element.

### `T:Autodesk.Revit.DB.JoinType`

Member kind: type
Symbol: `Autodesk.Revit.DB.JoinType`

#### Summary

The type of join at the end of an element. The join type affects only the graphic treatment, i.e.
cleaning of the end, not the physical join behavior.

### `F:Autodesk.Revit.DB.JoinType.Extension`

Member kind: field
Symbol: `Autodesk.Revit.DB.JoinType.Extension`

#### Summary

Extension Join

### `F:Autodesk.Revit.DB.JoinType.SquareOff`

Member kind: field
Symbol: `Autodesk.Revit.DB.JoinType.SquareOff`

#### Summary

Square-off Join

### `F:Autodesk.Revit.DB.JoinType.Miter`

Member kind: field
Symbol: `Autodesk.Revit.DB.JoinType.Miter`

#### Summary

Miter Join

### `F:Autodesk.Revit.DB.JoinType.Abut`

Member kind: field
Symbol: `Autodesk.Revit.DB.JoinType.Abut`

#### Summary

Abut Join

### `F:Autodesk.Revit.DB.JoinType.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.JoinType.None`

#### Summary

No join type

### `M:Autodesk.Revit.DB.Location.Rotate(Autodesk.Revit.DB.Line,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Location.Rotate(Autodesk.Revit.DB.Line,System.Double)`

#### Summary

Rotate the element within the project by a specified angle around a given axis.

#### Parameter `axis`

An unbounded line that represents the axis of rotation.

#### Parameter `angle`

The angle, in radians, by which the element is to be rotated around the specified axis.

#### Returns

If the element is rotate successfully then the method returns True, otherwise False.

#### Remarks

The rotate method is used to rotate an element within the project. Other elements may also
be rotated when this element is rotated because they are dependent upon the element being rotated. An
unbounded line for the axis can be created by using the Application.Create object and its methods.

### `M:Autodesk.Revit.DB.Location.Move(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Location.Move(Autodesk.Revit.DB.XYZ)`

#### Summary

Move the element within the project by a specified vector.

#### Parameter `translation`

The vector by which the element is to be moved.

#### Returns

If the element is moved successfully then the method return True, otherwise False.

#### Remarks

The move method is used to move an element within the project. Other elements may also be
moved when this element is moved, for example: if the element is wall and it contains windows, the
windows will also be moved.

### `T:Autodesk.Revit.DB.Location`

Member kind: type
Symbol: `Autodesk.Revit.DB.Location`

#### Summary

Provides location functionality for all elements.

#### Remarks

The location object provides the ability to translate and rotate elements. More
detailed location information and control can be found by using the derivatives of this
object, such as LocationPoint or LocationCurve.

### `M:Autodesk.Revit.DB.ConnectorManager.Lookup(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorManager.Lookup(System.Int32)`

#### Summary

Lookup the connector using the unique index value that identify this connector.

#### Parameter `index`

The unique index value.

#### Returns

Returns the connector or null if a connector for the provided unique index value doesn't exist.

#### Since

2016

### `P:Autodesk.Revit.DB.ConnectorManager.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorManager.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ConnectorManager.Owner`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorManager.Owner`

#### Summary

This property is used to retrieve the owner of the Connector Manager.

### `P:Autodesk.Revit.DB.ConnectorManager.UnusedConnectors`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorManager.UnusedConnectors`

#### Summary

Return all the unused Connectors of the Connector Manager.

#### Remarks

This property is used to retrieve the unused Connectors from the Connector Manager.

### `P:Autodesk.Revit.DB.ConnectorManager.Connectors`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorManager.Connectors`

#### Summary

Return all the Connectors of the Connector Manager.

#### Remarks

This property is used to retrieve the Connectors from the Connector Manager.

### `T:Autodesk.Revit.DB.ConnectorManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.ConnectorManager`

#### Summary

Provides access to the Connector Manager

### `M:Autodesk.Revit.DB.Structure.Hub.GetHubConnectorManager`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Hub.GetHubConnectorManager`

#### Summary

Retrieves the ConnectorManager of the Hub.

#### Remarks

The ConnectorManager provides information about elements connected via the Hub.

#### Returns

The ConnectorManager.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.Hub.GetOrigin`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Hub.GetOrigin`

#### Summary

Retrieves position of a Hub if such position is a 3D point.

#### Returns

The origin.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Hub does not have an Origin.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.Hub.HasOrigin`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Hub.HasOrigin`

#### Summary

Provides information if Hub has a specific location at point in 3D space.

#### Returns

True if the Hub has a specific location at point in 3D space.

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.Hub`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.Hub`

#### Summary

Represents a connection between two or more Autodesk Revit Elements.

#### Remarks

Elements connected via a Hub do not refer directly to each other - they each refer to the Hub that keeps all the connectivity information.

Hubs connect only structural Analytical Model Elements.

#### Since

2012

### `M:Autodesk.Revit.DB.HostObjectUtils.GetSideFaces(Autodesk.Revit.DB.HostObject,Autodesk.Revit.DB.ShellLayerType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HostObjectUtils.GetSideFaces(Autodesk.Revit.DB.HostObject,Autodesk.Revit.DB.ShellLayerType)`

#### Summary

Returns the major side faces for this host object.

#### Remarks

This utility supports host objects whose CompoundStructure is nominally oriented vertically. It
outputs faces which are at the boundary of the CompoundStructure (such as Walls and FaceWalls).

#### Parameter `hostObject`

The host object.

#### Parameter `side`

The side of the host object.

#### Returns

An array of references to the faces which are on the given side of this element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This host object does not support access to side faces.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.HostObjectUtils.GetBottomFaces(Autodesk.Revit.DB.HostObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HostObjectUtils.GetBottomFaces(Autodesk.Revit.DB.HostObject)`

#### Summary

Returns the bottom faces for this host object.

#### Remarks

This utility supports host objects whose bottom faces represent one of the boundaries
of CompoundStructure (such as roofs, floors or ceilings).

#### Parameter `hostObject`

The host object.

#### Returns

An array of references to the faces which are at the bottom of this element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This host object does not support access to top or bottom faces.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.HostObjectUtils.GetTopFaces(Autodesk.Revit.DB.HostObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HostObjectUtils.GetTopFaces(Autodesk.Revit.DB.HostObject)`

#### Summary

Returns the top faces for this host object.

#### Remarks

This utility supports host objects whose top faces represent one of the boundaries
of CompoundStructure (such as roofs, floors or ceilings).

#### Parameter `hostObject`

The host object.

#### Returns

An array of references to the faces which are at the top of this element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This host object does not support access to top or bottom faces.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.HostObjectUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.HostObjectUtils`

#### Summary

These are generic host object utilities.

#### Since

2012

### `T:Autodesk.Revit.DB.ShellLayerType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ShellLayerType`

#### Summary

Used to distinguish exterior and interior shell layers.

#### Remarks

Used as an argument to methods of CompoundStructure that deal with shell layers.

#### Since

2012

### `F:Autodesk.Revit.DB.ShellLayerType.Exterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.ShellLayerType.Exterior`

#### Summary

Exterior shell layer.

### `F:Autodesk.Revit.DB.ShellLayerType.Interior`

Member kind: field
Symbol: `Autodesk.Revit.DB.ShellLayerType.Interior`

#### Summary

Interior shell layer.

### `T:Autodesk.Revit.DB.StructDeckEmbeddingType`

Member kind: type
Symbol: `Autodesk.Revit.DB.StructDeckEmbeddingType`

#### Summary

Used in class CompoundStructure to specify the usage of a layer whose function is StructuralDeck.

#### Since

2012

### `F:Autodesk.Revit.DB.StructDeckEmbeddingType.Standalone`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructDeckEmbeddingType.Standalone`

#### Summary

Standalone deck.

### `F:Autodesk.Revit.DB.StructDeckEmbeddingType.MergeWithLayerAbove`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructDeckEmbeddingType.MergeWithLayerAbove`

#### Summary

Bound layer above.

### `F:Autodesk.Revit.DB.StructDeckEmbeddingType.Invalid`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructDeckEmbeddingType.Invalid`

#### Summary

Invalid usage.

### `T:Autodesk.Revit.DB.MaterialFunctionAssignment`

Member kind: type
Symbol: `Autodesk.Revit.DB.MaterialFunctionAssignment`

#### Summary

Used in class CompoundStructure to specify the function of a layer.

#### Remarks

The function is used primarily to determine
layer priority which affects how layers of distinct elements interact at a join. Typically, layers penetrate
lower priority layers and merge with layers of the same priority.

#### Since

2012

### `F:Autodesk.Revit.DB.MaterialFunctionAssignment.StructuralDeck`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialFunctionAssignment.StructuralDeck`

#### Summary

Indicates layer is a structural deck.

### `F:Autodesk.Revit.DB.MaterialFunctionAssignment.Membrane`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialFunctionAssignment.Membrane`

#### Summary

A membrane layer must have thickness 0. It is not represented graphically.

### `F:Autodesk.Revit.DB.MaterialFunctionAssignment.Finish2`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialFunctionAssignment.Finish2`

#### Summary

Priority = 5

### `F:Autodesk.Revit.DB.MaterialFunctionAssignment.Finish1`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialFunctionAssignment.Finish1`

#### Summary

Priority = 4

### `F:Autodesk.Revit.DB.MaterialFunctionAssignment.Insulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialFunctionAssignment.Insulation`

#### Summary

Priority = 3

### `F:Autodesk.Revit.DB.MaterialFunctionAssignment.Substrate`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialFunctionAssignment.Substrate`

#### Summary

Priority = 2

### `F:Autodesk.Revit.DB.MaterialFunctionAssignment.Structure`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialFunctionAssignment.Structure`

#### Summary

Priority = 1 (highest priority)

### `F:Autodesk.Revit.DB.MaterialFunctionAssignment.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.MaterialFunctionAssignment.None`

#### Summary

Priority = 0 This is deprecated and should not be used.

### `T:Autodesk.Revit.DB.CompoundStructureError`

Member kind: type
Symbol: `Autodesk.Revit.DB.CompoundStructureError`

#### Summary

When CompoundStructure::isValid() returns false, it uses these values to indicate precise nature of defect.

#### Remarks

'LayerTooThin' enum value was removed in 2016

#### Since

2012

### `F:Autodesk.Revit.DB.CompoundStructureError.InvalidProfileId`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.InvalidProfileId`

#### Summary

Element id used as profile id does not correspond to a valid deck profile.

### `F:Autodesk.Revit.DB.CompoundStructureError.ExtensibleRegionsNotContiguousAlongBottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.ExtensibleRegionsNotContiguousAlongBottom`

#### Summary

Extension Layers at the bottom of the wall must be adjacent.

### `F:Autodesk.Revit.DB.CompoundStructureError.ExtensibleRegionsNotContiguousAlongTop`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.ExtensibleRegionsNotContiguousAlongTop`

#### Summary

Extension Layers at the top of the wall must be adjacent.

### `F:Autodesk.Revit.DB.CompoundStructureError.InvalidMaterialId`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.InvalidMaterialId`

#### Summary

Element id used as material id does not correspond to an actual MaterialElem.

### `F:Autodesk.Revit.DB.CompoundStructureError.VarThickLayerCantBeZero`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.VarThickLayerCantBeZero`

#### Summary

Variable thickness layer have zero thickness.

### `F:Autodesk.Revit.DB.CompoundStructureError.DeckCantBoundBelow`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.DeckCantBoundBelow`

#### Summary

There is no layer below Structural deck or it is too thin.

### `F:Autodesk.Revit.DB.CompoundStructureError.DeckCantBoundAbove`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.DeckCantBoundAbove`

#### Summary

There is no layer above Structural deck or it is too thin.

### `F:Autodesk.Revit.DB.CompoundStructureError.VerticalWrongOrderMembrane`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.VerticalWrongOrderMembrane`

#### Summary

Membrane Layer have more than one face at any height.

### `F:Autodesk.Revit.DB.CompoundStructureError.VerticalWrongOrderCoreInterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.VerticalWrongOrderCoreInterior`

#### Summary

Interior core boundary have more than one face at any height.

### `F:Autodesk.Revit.DB.CompoundStructureError.VerticalWrongOrderCoreExterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.VerticalWrongOrderCoreExterior`

#### Summary

Exterior core boundary have more than one face at any height.

### `F:Autodesk.Revit.DB.CompoundStructureError.VerticalWrongOrderLayer`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.VerticalWrongOrderLayer`

#### Summary

Layers assigned to the same Row are not on the same side of the Core Boundary.

### `F:Autodesk.Revit.DB.CompoundStructureError.VerticalUnusedLayer`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.VerticalUnusedLayer`

#### Summary

A layer is not membrane layer and the Thickness of layer is zero.

### `F:Autodesk.Revit.DB.CompoundStructureError.ThinOuterLayer`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.ThinOuterLayer`

#### Summary

Thickness of face layer is too thin.

### `F:Autodesk.Revit.DB.CompoundStructureError.BadShellsStructure`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.BadShellsStructure`

#### Summary

The number of shell layers is larger than the total number of layers.

### `F:Autodesk.Revit.DB.CompoundStructureError.NonmembraneTooThin`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.NonmembraneTooThin`

#### Summary

Thickness of non-membrane layer is too thin.

### `F:Autodesk.Revit.DB.CompoundStructureError.MembraneTooThick`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.MembraneTooThick`

#### Summary

Thickness of membrane layer is more than zero.

### `F:Autodesk.Revit.DB.CompoundStructureError.CoreTooThin`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.CoreTooThin`

#### Summary

Core contain a membrane layer or thickness of core is zero.

### `F:Autodesk.Revit.DB.CompoundStructureError.BadShellOrder`

Member kind: field
Symbol: `Autodesk.Revit.DB.CompoundStructureError.BadShellOrder`

#### Summary

Layer Function Priorities ascend from the Core Boundary to the Finish Face.

### `T:Autodesk.Revit.DB.OpeningWrappingCondition`

Member kind: type
Symbol: `Autodesk.Revit.DB.OpeningWrappingCondition`

#### Summary

Used by CompoundStructure to describe which shell layers participate in wrapping at openings.

#### Since

2012

### `F:Autodesk.Revit.DB.OpeningWrappingCondition.ExteriorAndInterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpeningWrappingCondition.ExteriorAndInterior`

#### Summary

Both interior and exterior shell layers participate in wrapping at openings.

### `F:Autodesk.Revit.DB.OpeningWrappingCondition.Interior`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpeningWrappingCondition.Interior`

#### Summary

Only the interior shell layers participate in wrapping at openings.

### `F:Autodesk.Revit.DB.OpeningWrappingCondition.Exterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpeningWrappingCondition.Exterior`

#### Summary

Only the exterior shell layers participate in wrapping at openings.

### `F:Autodesk.Revit.DB.OpeningWrappingCondition.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.OpeningWrappingCondition.None`

#### Summary

None of the shell layers participate in wrapping at openings.

### `T:Autodesk.Revit.DB.EndCapCondition`

Member kind: type
Symbol: `Autodesk.Revit.DB.EndCapCondition`

#### Summary

Used by CompoundStructure to describe which shell layers participate in end wrapping.

#### Since

2012

### `F:Autodesk.Revit.DB.EndCapCondition.NoEndCap`

Member kind: field
Symbol: `Autodesk.Revit.DB.EndCapCondition.NoEndCap`

#### Summary

No end wrapping ability. Floors and roofs must use this enum value.

### `F:Autodesk.Revit.DB.EndCapCondition.Interior`

Member kind: field
Symbol: `Autodesk.Revit.DB.EndCapCondition.Interior`

#### Summary

Only the interior shell layers participate in end wrapping.

### `F:Autodesk.Revit.DB.EndCapCondition.Exterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.EndCapCondition.Exterior`

#### Summary

Only the exterior shell layers participate in end wrapping.

### `F:Autodesk.Revit.DB.EndCapCondition.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.EndCapCondition.None`

#### Summary

None of the shell layers participate in end wrapping.

### `T:Autodesk.Revit.DB.DisableAnalyticalModelCB`

Member kind: type
Symbol: `Autodesk.Revit.DB.DisableAnalyticalModelCB`

#### Summary

Disable the analytical model for a structural wall.

#### Since

2021

### `M:Autodesk.Revit.DB.HostObject.FindInserts(System.Boolean,System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HostObject.FindInserts(System.Boolean,System.Boolean,System.Boolean,System.Boolean)`

#### Summary

Gets the ids of the instances inserted into this host object.

#### Parameter `addRectOpenings`

True if rectangular openings should be included in the return.

#### Parameter `includeShadows`

True if shadows should be included in the return.

#### Parameter `includeEmbeddedWalls`

True if embedded walls should be included in the return.

#### Parameter `includeSharedEmbeddedInserts`

True if shared embedded inserts should be included in the return.

#### Returns

All the insertable instances' ids.

### `T:Autodesk.Revit.DB.HostObject`

Member kind: type
Symbol: `Autodesk.Revit.DB.HostObject`

#### Summary

A base class that provides support for all objects that can host other objects, such as walls roofs, and floors.

### `M:Autodesk.Revit.DB.HigherDLLCallUtils.GetAvaliableLayerModifierTypes(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExportLayerKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HigherDLLCallUtils.GetAvaliableLayerModifierTypes(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExportLayerKey)`

#### Summary

Gets all the avaliable layer modifier types for the layer key.

#### Parameter `document`

A Revit document to retrieve avaliable layer modifier types from.

#### Parameter `exportLayerKey`

The export layer key to specify wich category and subCategory will be used to get the layer modifier types.

#### Returns

The layer modifier types.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.HigherDLLCallUtils.GetAddInNameFromDocument(Autodesk.Revit.DB.AddInId,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HigherDLLCallUtils.GetAddInNameFromDocument(Autodesk.Revit.DB.AddInId,Autodesk.Revit.DB.Document)`

#### Summary

name of application associated with this ApplicationId
First attempts to obtain the name from AddInIds stored in the document.
If unsuccessful, attempts to obtain the name from loaded Third Party AddIns.

#### Parameter `addInId`

addInId

#### Parameter `aDoc`

target document

#### Returns

name of application

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.HigherDLLCallUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.HigherDLLCallUtils`

#### Summary

Used for public apis having higher dll call in proxy layer.

### `T:Autodesk.Revit.DB.HiddenLineViewsType`

Member kind: type
Symbol: `Autodesk.Revit.DB.HiddenLineViewsType`

#### Summary

An enumerated type listing all Hidden Line Views types of Print Setting.

### `F:Autodesk.Revit.DB.HiddenLineViewsType.RasterProcessing`

Member kind: field
Symbol: `Autodesk.Revit.DB.HiddenLineViewsType.RasterProcessing`

#### Summary

The type of Hidden Line Views is Raster Processing.

### `F:Autodesk.Revit.DB.HiddenLineViewsType.VectorProcessing`

Member kind: field
Symbol: `Autodesk.Revit.DB.HiddenLineViewsType.VectorProcessing`

#### Summary

The type of Hidden Line Views is Vector Processing (fast).

### `M:Autodesk.Revit.DB.HermiteSurface.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.HermiteSurface.IsValid`

#### Summary

Checks whether this HermiteSurface object is valid.

#### Remarks

An attempt to access or compute data in an invalid Hermite Surface will cause an exception.

#### Returns

True if this is a valid Hermite Surface, false otherwise.

#### Since

2017

### `M:Autodesk.Revit.DB.HermiteSurface.Create(System.Int32,System.Int32,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HermiteSurface.Create(System.Int32,System.Int32,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean,System.Boolean)`

#### Summary

Create a Hermite surface using a net of 3D points as input. Specify periodicity in U and V direction.

#### Remarks

Points form a net of nU * nV (less one each if periodic) 3D points.

#### Parameter `nU`

Number of points in U direction.

#### Parameter `nV`

Number of points in V direction.

#### Parameter `points`

Array of points. Must contain nU*nV points.

#### Parameter `periodicU`

Periodicity in U direction

#### Parameter `periodicV`

Periodicity in V direction

#### Returns

A Hermite surface object created from input data.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown when the input arguments are inconsistent. The most common case is incorrect number of items in one of the lists.

#### Since

2017

### `M:Autodesk.Revit.DB.HermiteSurface.Create(System.Int32,System.Int32,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.HermiteSurface.Create(System.Int32,System.Int32,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Create a non-periodic Hermite surface using a net of 3D points as input.

#### Remarks

Points form a net of nU * nV 3D points. Suitable defaults will be used for other surface parameters.
See other Create() functions if greater control over input is desired.

#### Parameter `nU`

Number of points in U direction.

#### Parameter `nV`

Number of points in V direction.

#### Parameter `points`

Array of points. Must contain nU*nV points.

#### Returns

A Hermite surface object created from input data.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown when the input arguments are inconsistent. The most common case is incorrect number of items in one of the lists.

#### Since

2017

### `T:Autodesk.Revit.DB.HermiteSurface`

Member kind: type
Symbol: `Autodesk.Revit.DB.HermiteSurface`

#### Summary

A Hermite Surface.

#### Since

2017

### `M:Autodesk.Revit.DB.Lighting.HemisphericalLightDistribution.#ctor(Autodesk.Revit.DB.Lighting.HemisphericalLightDistribution)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.HemisphericalLightDistribution.#ctor(Autodesk.Revit.DB.Lighting.HemisphericalLightDistribution)`

#### Summary

Creates a copy of the given hemispherical light distribution

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.HemisphericalLightDistribution.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.HemisphericalLightDistribution.#ctor`

#### Summary

Creates a hemispherical light distribution object.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.HemisphericalLightDistribution`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.HemisphericalLightDistribution`

#### Summary

This class encapsulates a hemispherical light distribution.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightDistribution.Clone`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightDistribution.Clone`

#### Summary

Creates a copy of the LightDistribution derived object.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.LightDistribution.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.LightDistribution.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Lighting.LightDistribution`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.LightDistribution`

#### Summary

This class is the base class for specifying light distribution.

#### Since

2013

### `P:Autodesk.Revit.DB.Visual.Hardwood.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Hardwood.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "Hardwood" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Hardwood.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Hardwood.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "Hardwood" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Hardwood.HardwoodImperfectionsAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Hardwood.HardwoodImperfectionsAmount`

#### Summary

The property labeled "Amount" from the "Hardwood" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "-10, 10".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Hardwood.HardwoodImperfectionsShader`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Hardwood.HardwoodImperfectionsShader`

#### Summary

The property labeled "Image" from the "Hardwood" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1
