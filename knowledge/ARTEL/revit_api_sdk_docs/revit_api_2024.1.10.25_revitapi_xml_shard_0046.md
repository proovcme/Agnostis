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
Shard: 46
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `P:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.PointCloud`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.PointCloud`

#### Summary

An external resource type representing Point Clouds.
This type is reserved for future expansion but not yet implemented.

### `P:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.MaterialTexture`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.MaterialTexture`

#### Summary

An external resource type representing material texture images.

### `P:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.KeynoteTable`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.KeynoteTable`

#### Summary

An external resource type representing keynote data.

### `P:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.Image`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.Image`

#### Summary

An external resource type representing images.

### `P:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.IFCLink`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.IFCLink`

#### Summary

An external resource type representing IFC links.

### `P:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.FabricationConfiguration`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.FabricationConfiguration`

#### Summary

An external resource type representing an MEP fabrication configuration.

### `P:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.DecalMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.DecalMap`

#### Summary

An external resource type representing Decal linked data for diffuse.
This type is reserved for future expansion but not yet implemented.

### `P:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.DecalImage`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.DecalImage`

#### Summary

An external resource type representing decal images.

### `P:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.DecalCutOut`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.DecalCutOut`

#### Summary

An external resource type representing Decal linked data for cut out opacity.
This type is reserved for future expansion but not yet implemented.

### `P:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.DecalBumpMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.DecalBumpMap`

#### Summary

An external resource type representing Decal linked data for bump map.
This type is reserved for future expansion but not yet implemented.

### `P:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.DWFMarkup`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.DWFMarkup`

#### Summary

An external resource type representing DWF markups data.
This type is reserved for future expansion but not yet implemented.

### `P:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.CADLink`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.CADLink`

#### Summary

An external resource type representing CAD Links data.

### `P:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.AssemblyCodeTable`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes.AssemblyCodeTable`

#### Summary

An external resource type representing assembly code data.

### `T:Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes.BuiltInExternalResourceTypes`

#### Summary

A collection of ids of the ExternalResourceTypes provided by Revit.

### `T:Autodesk.Revit.DB.ExternalResourceTypes`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceTypes`

#### Summary

Provides a container of all Revit built-in ExternalResourceType instances.

### `M:Autodesk.Revit.DB.ExternalResourceServiceUtils.GetServers`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceServiceUtils.GetServers`

#### Summary

Gets registered external resource servers

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceServiceUtils.GetServersByType(Autodesk.Revit.DB.ExternalResourceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceServiceUtils.GetServersByType(Autodesk.Revit.DB.ExternalResourceType)`

#### Summary

Gets registered external resource servers which support the external resource type.

#### Parameter `type`

The external resource type for the servers to match

#### Returns

A list of matched external resource servers

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.ExternalResourceServiceUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceServiceUtils`

#### Summary

Contains utilities related to external resource service.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceServerUtils.ServerSupportsIFCLinks(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceServerUtils.ServerSupportsIFCLinks(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Checks that the server referenced by the given ExternalResourceReference supports
IFC links.

#### Parameter `extRef`

The ExternalResourceReference to check.

#### Returns

True if the ExternalResourceReference refers to a server that supports IFC links. False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalResourceServerUtils.ServerSupportsCADLinks(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceServerUtils.ServerSupportsCADLinks(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Checks that the server referenced by the given ExternalResourceReference supports
CAD links.

#### Parameter `extRef`

The ExternalResourceReference to check.

#### Returns

True if the ExternalResourceReference refers to a server that supports CAD links. False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalResourceServerUtils.ServerSupportsRevitLinks(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceServerUtils.ServerSupportsRevitLinks(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Checks that the server referenced by the given ExternalResourceReference supports
Revit links.

#### Parameter `extRef`

The ExternalResourceReference to check.

#### Returns

True if the ExternalResourceReference refers to a server that supports Revit links. False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceServerUtils.ServerSupportsAssemblyCodeData(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceServerUtils.ServerSupportsAssemblyCodeData(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Checks that the server referenced by the given ExternalResourceReference supports
AssemblyCodeData.

#### Parameter `extRef`

The ExternalResourceReference to check.

#### Returns

True if the ExternalResourceReference refers to a server that supports AssemblyCodeData. False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceServerUtils.ServerSupportsKeynotes(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceServerUtils.ServerSupportsKeynotes(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Checks that the server referenced by the given ExternalResourceReference supports
KeynoteTable data.

#### Parameter `extRef`

The ExternalResourceReference to check.

#### Returns

True if the ExternalResourceReference refers to a server that supports keynotes. False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceServerUtils.IsValidShortName(System.Guid,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceServerUtils.IsValidShortName(System.Guid,System.String)`

#### Summary

Checks whether the name is a valid short name for the external resource server.

#### Remarks

A valid short name should match the restrictions documented in `M:Autodesk.Revit.DB.IExternalResourceServer.GetShortName` .

#### Parameter `serverId`

The id of the external resource server.

#### Parameter `serverName`

The short name of the external resource server.

#### Returns

True if the name is a valid short name, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.ExternalResourceServerUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceServerUtils`

#### Summary

Contains utilities related to external resource server.

#### Since

2015

### `M:Autodesk.Revit.DB.RevitLinkOperations.SetGetLocalPathForOpenCallback(Autodesk.Revit.DB.IGetLocalPathForOpenCallback)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkOperations.SetGetLocalPathForOpenCallback(Autodesk.Revit.DB.IGetLocalPathForOpenCallback)`

#### Summary

Sets the IGetLocalPathForOpenCallback that will support the "Open (and Unload)" command for Revit links
obtained from an IExternalResourceServer.

#### Parameter `makeLocalCopyForOpen`

The IGetLocalPathForOpenCallback that will support the "Open (and Unload)" command.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.RevitLinkOperations`

Member kind: type
Symbol: `Autodesk.Revit.DB.RevitLinkOperations`

#### Summary

This class is used to extend the IExternalResourceServer interface with methods to support operations
specifically related to Revit links.

#### Remarks

The class owns single-method interfaces which are used as callbacks to perform specific operations
on Revit link external resources.

An empty RevitLinkOperations instance is passed to an IExternalResourceServer (inside an
ExternalResourceServerExtensions object) via the GetTypeSpecificServerOperations method. The server
provider can then add their own implemented interface objects to the RevitLinkOperations, thus
making them available to Revit to use as callbacks.

Supporting these additional, type-specific operations is not absolutely required, but is strongly
recommended in order for users to be able to perform all the same operations they would with
locally-accessed Revit links.

#### Since

2015

### `T:Autodesk.Revit.DB.CADLinkOperations`

Member kind: type
Symbol: `Autodesk.Revit.DB.CADLinkOperations`

#### Summary

This class is used to extend the IExternalResourceServer interface with methods to support operations
specifically related to DWG links.

#### Remarks

The class owns single-method interfaces which are used as callbacks to perform specific operations
on DWG link external resources.

An empty CADLinkOperations instance is passed to an IExternalResourceServer (inside an
ExternalResourceServerExtensions object) via the GetTypeSpecificServerOperations method. The server
provider can then add their own implemented interface objects to the CADLinkOperations, thus
making them available to Revit to use as callbacks.

Supporting these additional, type-specific operations is not absolutely required, but is strongly
recommended in order for users to be able to perform all the same operations they would with
locally-accessed links.

#### Since

2018

### `M:Autodesk.Revit.DB.LinkOperations.SetOnLocalLinkSharedCoordinatesSavedCallback(Autodesk.Revit.DB.IOnLocalLinkSharedCoordinatesSavedCallback)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkOperations.SetOnLocalLinkSharedCoordinatesSavedCallback(Autodesk.Revit.DB.IOnLocalLinkSharedCoordinatesSavedCallback)`

#### Summary

Sets the callback that will be called when the Revit user saves new shared coordinate
settings to a linked document obtained from an IExternalResourceServer.

#### Parameter `onLocalLinkSharedCoordinatesSaved`

An IOnLocalLinkSharedCoordinatesSavedCallback object that can respond when the user
saves new shared coordinates to a Revit link document obtained from IExternalResourceServer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.LinkOperations.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinkOperations.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.LinkOperations`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinkOperations`

#### Summary

This class is used to extend the IExternalResourceServer interface with methods to support operations
for elements that are LinkTypes.

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalResourceServerExtensions.GetCADLinkOperations`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceServerExtensions.GetCADLinkOperations`

#### Summary

Gets the specific methods supported by external resource CAD Links.

#### Returns

The specific methods supported by external resource CAD Links.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceServerExtensions.GetRevitLinkOperations`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceServerExtensions.GetRevitLinkOperations`

#### Summary

Gets the specific methods supported by the external resource of Revit Links.

#### Returns

The specific methods supported by the external resource of Revit Links.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalResourceServerExtensions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceServerExtensions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ExternalResourceServerExtensions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceServerExtensions`

#### Summary

An object that contains overrides for external resource-specific methods.

#### Remarks

This class permits assignment of some specific operations related to a type of
external resource, such as what to do when "Open (and Unload)" happens, or when
"Shared Coordinates update" happens for Revit or CAD links.

There is no feedback to the UI server for ExternalResourceServerExtensions.
Revit will use standard, common message dialogs to handle any error conditions.

#### Since

2015

### `M:Autodesk.Revit.DB.FailureDefinitionId.op_Inequality(Autodesk.Revit.DB.FailureDefinitionId,Autodesk.Revit.DB.FailureDefinitionId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureDefinitionId.op_Inequality(Autodesk.Revit.DB.FailureDefinitionId,Autodesk.Revit.DB.FailureDefinitionId)`

#### Summary

Compares two FailureDefinitionId instances.

#### Parameter `first`

The first FailureDefinitionId.

#### Parameter `second`

The second FailureDefinitionId.

#### Returns

True if the inputs are different, false if they are identical.

### `M:Autodesk.Revit.DB.FailureDefinitionId.op_Equality(Autodesk.Revit.DB.FailureDefinitionId,Autodesk.Revit.DB.FailureDefinitionId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureDefinitionId.op_Equality(Autodesk.Revit.DB.FailureDefinitionId,Autodesk.Revit.DB.FailureDefinitionId)`

#### Summary

Compares two FailureDefinitionId instances.

#### Parameter `first`

The first FailureDefinitionId.

#### Parameter `second`

The second FailureDefinitionId.

#### Returns

True if the inputs are identical, false if they are different.

### `M:Autodesk.Revit.DB.FailureDefinitionId.#ctor(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureDefinitionId.#ctor(System.Guid)`

#### Summary

Creates a new FailureDefinitionId instance.

#### Parameter `guid`

The identifier for the FailureDefinitionId.

### `T:Autodesk.Revit.DB.FailureDefinitionId`

Member kind: type
Symbol: `Autodesk.Revit.DB.FailureDefinitionId`

#### Summary

The unique identifier of a FailureDefinition.

#### Remarks

Each possible failure in Revit must be defined and registered during Revit application startup
by creating a FailureDefinition object.
Unique FailureDefinitionId must be used as a key to register FailureDefinition.
Those unique FailureDefinitionId should be created using GUID generation tool.
Later FailureDefinitionId can be used to lookup FailureDefinition
in FailureDefinitionRegistry, and create and post FailureMessages.

#### Since

2011

### `P:Autodesk.Revit.DB.ExternalResourceReferenceUpdatedDataForWorksharing.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceReferenceUpdatedDataForWorksharing.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.ExternalResourceReferenceUpdatedDataForWorksharing.#ctor(Autodesk.Revit.DB.FailureDefinitionId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReferenceUpdatedDataForWorksharing.#ctor(Autodesk.Revit.DB.FailureDefinitionId)`

#### Summary

Constructor data from failure id.

#### Parameter `failureId`

The failure id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalResourceReferenceUpdatedDataForWorksharing.#ctor(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReferenceUpdatedDataForWorksharing.#ctor(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Constructor data from updated resource.

#### Parameter `updatedReference`

The updated resource.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `T:Autodesk.Revit.DB.ExternalResourceReferenceUpdatedDataForWorksharing`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceReferenceUpdatedDataForWorksharing`

#### Summary

The data to be returned by `!:IExternalResourceServerInternal::getUpdatedResourceDataForWorksharing()`
If a valid `!:failureId` is returned then that failure is posted so a user can delete the element.
If not, the ExternalResourceReference is copied to the Element. The resource must be well formed and the interface
`!:IExternalResourceServerInternal::resourceNeedsUpdateForWorksharing()` should return true for that
resource.

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.DumpMessage(System.String,System.Boolean,System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.DumpMessage(System.String,System.Boolean,System.Boolean,System.Boolean,System.Boolean)`

#### Summary

Dump logs to journals, dump file, std out.

#### Parameter `message`

The message

#### Parameter `bOutputToScreen`

The dumps to output screen, if true.

#### Parameter `bOutputToStdFile`

The dumps to standard file, if true.

#### Parameter `bOutputToJournal`

The dumps to journal file, if true.

#### Parameter `timeStamp`

Prepend time stamp to the message.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.UseVersionFromDesktopConnector`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.UseVersionFromDesktopConnector`

#### Summary

Resource will use the version from desktop connector instead of file timestamp.

#### Returns

True to use.

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.ForceNoPermanentIdForDesktopConnector`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.ForceNoPermanentIdForDesktopConnector`

#### Summary

Disables permanent ids for desktop connector.

#### Returns

True to disable warning.

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.PostDebugWarnMessage(System.String,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.PostDebugWarnMessage(System.String,System.String,System.String)`

#### Summary

Post debug warning message from internal API code

#### Parameter `message`

The message

#### Parameter `owner`

The owner

#### Parameter `date`

The date

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.ThrowAutodeskDriveNeedsUpdateException`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.ThrowAutodeskDriveNeedsUpdateException`

#### Summary

Throws AutodeskDriveNeedsUpdate exception, which is no way to be triggered before AutodeskDrive and Revit are shipped.

#### Returns

True to throw AutodeskDriveNeedsUpdate exception.

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.ThrowRevitNeedsUpdateException`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.ThrowRevitNeedsUpdateException`

#### Summary

Throws RevitNeedsUpdate exception, which is no way to be triggered before AutodeskDrive and Revit are shipped.

#### Returns

True to throw RevitNeedsUpdate exception.

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.AllowAutodeskDriveLogger`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceReferenceDebugModes.AllowAutodeskDriveLogger`

#### Summary

Checks if debug mode is turned on.

#### Returns

True if the DebugMode is on.

#### Since

2018

### `T:Autodesk.Revit.DB.ExternalResourceReferenceDebugModes`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceReferenceDebugModes`

#### Summary

This class is an interface to debug modes that are related to ExternalResourceReference.

#### Remarks

This class is an interface to debug modes that are related to ExternalResourceReference.

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalResourceLoadData.SetExternalResourceReference(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadData.SetExternalResourceReference(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Returns the ExternalResourceReference resulting from this load operation.

#### Remarks

This object contains the ExternalResourceReference produced by the loading operation onIExternalResourceServer.

#### Parameter `resourceRef`

A reference to an ExternalResourceReference object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceLoadData.GetLoadContext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadData.GetLoadContext`

#### Summary

Returns an object containing information about the context of the load operation.

#### Returns

An object containing information about the context of the load operation.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceLoadData.GetLoadRequestId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadData.GetLoadRequestId`

#### Summary

Returns the load operation GUID.

#### Remarks

This Id uniquely identifies the load request. IExternalResourceServers can use it as a key to store
and retrieve information (such as errors) that is relevant to a specific load operation.

#### Returns

The load operation GUID.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceLoadData.GetLoadContent`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadData.GetLoadContent`

#### Summary

Returns the ExternalResourceLoadContent resulting from this load operation.

#### Remarks

This object contains the content produced by the call to the IExternalResourceServer's
LoadResource method.

#### Returns

A reference to an ExternalResourceLoadContent object.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceLoadData.GetExternalResourceReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadData.GetExternalResourceReference`

#### Summary

Returns the ExternalResourceReference that identifies which resource should be loaded.

#### Remarks

Information in this object tells the server from which specific resource Revit
expects to receive the external data.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalResourceLoadData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExternalResourceLoadData.LoadStatus`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadData.LoadStatus`

#### Summary

The success or failure status of the load attempt.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalResourceLoadData.ExternalResourceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadData.ExternalResourceType`

#### Summary

The ExternalResourceType for which Revit is requesting data from the server.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalResourceLoadData.ErrorsReported`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadData.ErrorsReported`

#### Summary

Indicates whether the IExternalResourceUIServer has reported errors
for this ExternalResourceLoadData. This value can be set by the
IExternalResourceUIServer in HandleLoadResourceResults().

#### Remarks

For Revit links specifically, Revit will check this value to see
if it should report errors about a given link in the Unresolved
References dialog. An IExternalResourceUIServer can set this value
to true to avoid redundant messages.

Note that it is possible for Revit to encounter errors internally
even if the server successfully provides a reference. In general, this
value should only be set to true if the server has reported an
error condition.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceLoadData.#ctor(Autodesk.Revit.DB.ExternalResourceLoadData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadData.#ctor(Autodesk.Revit.DB.ExternalResourceLoadData)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.ExternalResourceLoadData`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadData`

#### Summary

This class contains the input and output data resulting from invoking an IExternalResourceServer's LoadResource method.

After the call to LoadResource, the resulting ExternalResourceLoadData will be passed into
IExternalResourceServer.HandleLoadResourceResults() so that appropriate UI can be displayed.

Server providers can inspect the ExternalResourceLoadData to get an ExternalResourceLoadContent
object of the subclass appropriate to the external resource. The class also contains a copy of the
ExternalResourceReference, and information about the context of the load operation.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceLoadContext.CallingDocumentHasModelPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadContext.CallingDocumentHasModelPath`

#### Summary

Indicates whether the document requesting the external resource has a defined
ModelPath.

#### Remarks

A project that is detached, or has not been saved to disk yet, will not have a ModelPath.

#### Returns

True if the document has a defined ModelPath.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceLoadContext.GetCallingDocumentModelPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadContext.GetCallingDocumentModelPath`

#### Summary

Returns a copy of the ModelPath of the document that is requesting
the external resource.

#### Returns

A copy of the ModelPath of the document that is requesting the external
resource.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document requesting the external resource does not have a ModelPath, either because
it is detached, or because it has not been saved to disk yet.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceLoadContext.GetCurrentlyLoadedReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadContext.GetCurrentlyLoadedReference`

#### Summary

Returns a copy of the ExternalResourceReference currently
in use by the containing element.

#### Remarks

A server may use to wish this information to, for example,
tell whether the Revit user was previously using their
server or not.

This reference may be `null` if there is no current
value. For example, a newly-created link being loaded for the first
time would have no currently-loaded reference.

#### Returns

A copy of the ExternalResourceReference currently in use
by the containing element.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalResourceLoadContext.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadContext.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExternalResourceLoadContext.LoadOperationType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadContext.LoadOperationType`

#### Summary

An enum value indicating whether the resource load was triggered by an
automatic event (such as file open) or an explicit user action.

#### Since

2015

### `T:Autodesk.Revit.DB.ExternalResourceLoadContext`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadContext`

#### Summary

This class contains data describing the context related
to an external resource load operation.

#### Remarks

Note that automatic loads can occur in the context of other operations such as opening a file.
During automatic loads, it is therefore recommended that the server only display UI that is critical
for the user to see (such as error message).

The loading operation type is Explicit when the user is specifically trying to reload the resource.
During explicit loads, it may be desirable to provide more feedback to the user, such as specific feedback
that the load operation succeeded.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceLoadContent.SetIsDownloaded(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadContent.SetIsDownloaded(System.Boolean)`

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceLoadContent.Sync(Autodesk.Revit.DB.ExternalResourceLoadContent)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadContent.Sync(Autodesk.Revit.DB.ExternalResourceLoadContent)`

#### Summary

Syncs version and loadStatus with a given ExternalResourceLoadContent.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalResourceLoadContent.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadContent.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExternalResourceLoadContent.LoadStatus`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadContent.LoadStatus`

#### Summary

A value to indicate the status of an external resource load operation. IExternalResourceServers
should set this in the LoadResource() method.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The ExternalResourceLoadContent does not contain all the necessary
data. To see the requirements for this particular resource type,
please see the documentation for the specific subclass of
ExternalResourceLoadContent.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalResourceLoadContent.Version`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadContent.Version`

#### Summary

The version of the external data that the server is providing in this object.

#### Remarks

When its LoadResource() method is invoked, an IExternalResourceServer can
indicate the version of the data that it is providing to Revit by setting
this property. Doing so will improve performance, because Revit will use
the version information to avoid unnecessary reloads.

See `M:Autodesk.Revit.DB.IExternalResourceServer.GetResourceVersionStatus(Autodesk.Revit.DB.ExternalResourceReference)` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.ExternalResourceLoadContent`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceLoadContent`

#### Summary

This class contains the actual content data and other results of an external resource load operation that are
returned by an IExternalResourceServer to Revit.

#### Remarks

When Revit calls the LoadResource method for an IExternalResourceServer, Revit will provide an object that is a
sub-class of ExternalResourceLoadContent. The IExternalResourceServer will use this object to return the content
Revit should use for the external resource. The server can also add information about any errors that occurred
during the load operation. This error information will be stored by Revit and later passed to the
associated IExternalResourceUIServer (if any) that designates the IExternalResourceServer as its "DBServer"
(see the IExternalResourceUIServer.GetDBServerId() method). The IExternalResourceUIServer can then generate
any UI that is required for handling the errors that occurred.

Note that since different kinds of external resources are expected to return different kinds of data to Revit,
a number of ExternalResourceLoadContent sub-classes have been created to handle the data for specific ExternalResourceTypes.
This base class contains only a string to indicate the version of the resource data that is being supplied
by the server and a status variable to indicate the outcome of a load operation. Revit will always
provide the server with an instance of the appropriate sub-class of ExternalResourceLoadContent, with internal
data that are relevant to the particular ExternalResourceType that is being loaded.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServerProxy.GetInformationLink`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerProxy.GetInformationLink`

#### Summary

The method that Revit will invoke to obtain a URL address which provides more information about the server.

#### Returns

The URL providing server information.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServerProxy.GetTypeSpecificServerOperations(Autodesk.Revit.DB.ExternalResourceServerExtensions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerProxy.GetTypeSpecificServerOperations(Autodesk.Revit.DB.ExternalResourceServerExtensions)`

#### Summary

Implement this method to get operations supported by the external server for a particular type of external resource.

#### Remarks

Through this method, some specific operations for a paritcular type of external resource, such as Open(and Unload)
and shared coordinates for Revit Link, can be set in a class ExternalResourceServerExtensions.

ExternalResourceServerExtensions is able to own sub-interface classes, each of which has methods
related to a particular type of external resource.

#### Parameter `extensions`

The class which owns sub-interface classes, each of which has methods related to a particular type of external resource.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServerProxy.GetShortName`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerProxy.GetShortName`

#### Summary

Implement this method to return the short name of the server.

#### Remarks

The name is a unique path prefix included in full paths to external resources provided by this server.
It is recommended that the short name length is at least 3 characters to make it useful for
users to identify the server easily.

To ensure the server can be registered successfully, the name should match restrictions below:
The name cannot be empty or consist of only whitespace characters.

The name should not include any invalid characters such as \/:*?"<>|.

The name cannot duplicate any other external resource server names.

The name should not duplicate a Revit reserved path prefix(case insensitive), including:
RSN, A360, buzzsaw, vault, redspark, ftp, http, https, files, file.

#### Returns

The short name of the server.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServerProxy.GetIconPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerProxy.GetIconPath`

#### Summary

Implement this method to return the path to an icon file which will be displayed in Revit
user interfaces associated to this server.

#### Remarks

The specified image will be displayed in the browser dialogs when the user is selecting
a resource of a compatible type.

The return must be the full path to an icon file containing 48x48, 32x32 and 16x16 pixel images.

If this method returns anything other than a valid icon file, a default image will be used for the server.

#### Returns

The image file of the server.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServerProxy.SetupBrowserData(Autodesk.Revit.DB.ExternalResourceBrowserData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerProxy.SetupBrowserData(Autodesk.Revit.DB.ExternalResourceBrowserData)`

#### Summary

Implement this method to setup external resource browser data which will be accessed in Revit external resource browser UI.

#### Remarks

If errors occur during setup, store this information externally, and then retrieve and deal
with the errors during the call to HandleBrowseResult() of your IExternalResourceUIServer.

#### Parameter `browseData`

The input context to match the external resources and browser results returned by the server.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServerProxy.AreSameResources(System.Collections.Generic.IDictionary{System.String,System.String},System.Collections.Generic.IDictionary{System.String,System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerProxy.AreSameResources(System.Collections.Generic.IDictionary{System.String,System.String},System.Collections.Generic.IDictionary{System.String,System.String})`

#### Summary

Implement this method to indicate whether two given resources are the same.

#### Returns

True if two given resources are the same; otherwise false.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServerProxy.GetResourceVersionStatus(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerProxy.GetResourceVersionStatus(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Implement this method to indicate whether the given version of a resource is the most
current version of the data.

#### Remarks

If Revit already has a version of this resource loaded, Revit will invoke this method
to check whether the resource's data will change if `M:Autodesk.Revit.DB.IExternalResourceServerProxy.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)` is called. If this method
returns ResourceVersionStatus.Current, then Revit will improve model performance
by not calling `M:Autodesk.Revit.DB.IExternalResourceServerProxy.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)` .

Note that this method may also be invoked to determine the behavior of certain
elements within the user interface. For example, it may be used to warn the user if they
are about to execute certain expensive operations (such as printing) with an outdated
version of this resource.

Servers which encounter errors should return ResourceVersionStatus.Unknown. Revit
will reload resources whose version status is unknown, but will not display
out-of-date warnings to the user on printing.

#### Parameter `reference`

The ExternalResourceReference to check.

#### Returns

An enum indicating whether the resource is current, out of date, or of unknown status.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServerProxy.GetInSessionPath(Autodesk.Revit.DB.ExternalResourceReference,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerProxy.GetInSessionPath(Autodesk.Revit.DB.ExternalResourceReference,System.String)`

#### Summary

Implement this method to provide the path that should be used for display and browsing to a given ExternalResourceReference
during this Revit session.

#### Remarks

This method allows an IExternalResourceServer to override the path that is used within this Revit
session to display and browse to a specific ExternalResourceReference. This method is provided
to accommodate IExternalResourceServers that may present different paths under different circumstances.
For example, an IExternalResourceServer might implement this method to return a display path
that uses the appropriate language for the user's current locale. An IExternalResourceServer
could also use this method to present the appropriate name if the user has renamed this
resource since the last time it was loaded. If the IExternalResourceServer does not need to
customize the display path, it can return the originalDisplayPath parameter.

Revit will invoke this method when the model is first loaded or before calling `M:Autodesk.Revit.DB.IExternalResourceServerProxy.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)`
and cache the result in the ExternalResourceReference.

Do not rely on this path to look up an ExternalResourceReference, as the path is neither unique nor stable. It isn't unique
because multiple servers might use the same server name and display name format. It isn't stable because some servers allow renaming,
and because a server might change its name at some point.

#### Parameter `reference`

The ExternalResourceReference for which Revit is requesting the in session display path.

#### Parameter `originalDisplayPath`

The path that was provided for the resource when the resource was originally loaded into the model.

#### Returns

The display path that should be used for this resource for this session of Revit.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServerProxy.IsResourceWellFormed(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerProxy.IsResourceWellFormed(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Implement this method to check whether the given ExternalResourceReference is formatted
correctly for this server.

#### Remarks

Different servers will have different requirements.

A server which loads references from a website might
require that the reference map contain a key called "URL"
and a value that is a valid URL.

A server which loads references from a network drive
might require a key called "Drive" with a value that
represents a drive name, plus a key called "Path" with
a value that corresponds to a path relative to the root
of the drive.

This function should not check that the resource exists
on the server. It should only check that the resource is
formatted correctly.

#### Parameter `extRef`

The ExternalResourceReference to check.

#### Returns

True if the ExternalResourceReference represents a well-formed
resource. False otherwise.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServerProxy.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerProxy.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)`

#### Summary

Implement this method to load the requested resource.

#### Remarks

This method will be invoked when Revit needs to load a resource supplied by this server.

Revit provides four key pieces of information to the server:

A GUID identifying the load request.

The type of external resource that Revit is requesting, such as keynote data, linked Revit/CAD files, etc.

An ExternalResourceReference object, which contains information, such as a filename, the version, or other data,
that identifies the specific resource that Revit needs from the server.

An ExternalResourceLoadContext object, which contains information about the context of the load request. For
example, the ExternalResourceLoadContext contains information describing whether the load came about as a result of
a user action or an automatic action.

The server returns the results of the load request back to Revit via the loadResults argument, which will be a
sub-class of ExternalResourceLoadContent. This object will contain appropriate data structures to hold the actual resource
data (content) required by Revit for the specified ExternalResourceType.

Server authors may also wish to display UI related to the resource load operation, particularly when errors occur while
loading or creating the content. The UI should not be created by the IExternalResourceServer. Instead, the server
author should implement an IExternalResourcesUIServer which will handle all UI-related tasks. The external services framework
supports data sharing between, and coordinates the actions of, the two types of servers as follows:

Each ExternalResourceLoadContent sub-class is designed to hold data related to errors that may have occurred while
loading or creating the content the specified ExternalResourceType. The IExternalResourceServer should set this data as
needed in the `M:Autodesk.Revit.DB.IExternalResourceServerProxy.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)` method.

The error data, along with ExternalResourceReference and other information associated with the attempt to load the external
resource, is stored internally by Revit until a time when it is appropriate to display UI.

When appropriate, the framework will invoke the HandleLoadResourceResults method of any IExternalResourceUIServer
that is associated with the IExternalResourceServer, and will pass the error data and other information to the UIServer
for possible display in the Revit UI.

Note that instead of using the ExternalResourceLoadContent object, the IExternalResourceServer can store its own error
information. Subsequently, when the external services framework invokes the IExternalResourceUIServer's HandleLoadResourceResults
method, the IExternalResourceUIServer can communicate directly with its associated IExternalResourceServer - using whatever interface
the server developer has implemented - to retrieve the required messages and error data for display in the UI. Revit provides
a GUID to `M:Autodesk.Revit.DB.IExternalResourceServerProxy.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)` , to facilitate identification of individual load requests.

#### Parameter `loadRequestId`

The id uniquely identifying the load request.

#### Parameter `resourceType`

The type of resource requested.

#### Parameter `desiredResource`

The specific resource that should be loaded.

#### Parameter `loadContext`

A class containing info about the context of the load request.

#### Parameter `loadResults`

The data returned by the server as a result of this load operation.
Revit will ensure that this argument is the appropriate subclass of ExternalResourceLoadContent for the type of data.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServerProxy.SupportsExternalResourceType(Autodesk.Revit.DB.ExternalResourceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerProxy.SupportsExternalResourceType(Autodesk.Revit.DB.ExternalResourceType)`

#### Summary

Implement this method to indicate whether the server can provide data for a specified type of external resource.

#### Parameter `type`

The ExternalResourceType of interest to the caller. For example, KeynoteTable - to determine
if the server provides data for Revit's keynote table.

#### Returns

True if the server supports the specified type of external resource

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServer.GetInformationLink`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServer.GetInformationLink`

#### Summary

The method that Revit will invoke to obtain a URL address which provides more information about the server.

#### Returns

The URL providing server information.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServer.GetTypeSpecificServerOperations(Autodesk.Revit.DB.ExternalResourceServerExtensions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServer.GetTypeSpecificServerOperations(Autodesk.Revit.DB.ExternalResourceServerExtensions)`

#### Summary

Implement this method to get operations supported by the external server for a particular type of external resource.

#### Remarks

Through this method, some specific operations for a paritcular type of external resource, such as Open(and Unload)
and shared coordinates for Revit Link, can be set in a class ExternalResourceServerExtensions.

ExternalResourceServerExtensions is able to own sub-interface classes, each of which has methods
related to a particular type of external resource.

#### Parameter `extensions`

The class which owns sub-interface classes, each of which has methods related to a particular type of external resource.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServer.GetShortName`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServer.GetShortName`

#### Summary

Implement this method to return the short name of the server.

#### Remarks

The name is a unique path prefix included in full paths to external resources provided by this server.
It is recommended that the short name length is at least 3 characters to make it useful for
users to identify the server easily.

To ensure the server can be registered successfully, the name should match restrictions below:
The name cannot be empty or consist of only whitespace characters.

The name should not include any invalid characters such as \/:*?"<>|.

The name cannot duplicate any other external resource server names.

The name should not duplicate a Revit reserved path prefix(case insensitive), including:
RSN, A360, buzzsaw, vault, redspark, ftp, http, https, files, file.

#### Returns

The short name of the server.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServer.GetIconPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServer.GetIconPath`

#### Summary

Implement this method to return the path to an icon file which will be displayed in Revit
user interfaces associated to this server.

#### Remarks

The specified image will be displayed in the browser dialogs when the user is selecting
a resource of a compatible type.

The return must be the full path to an icon file containing 48x48, 32x32 and 16x16 pixel images.

If this method returns anything other than a valid icon file, a default image will be used for the server.

#### Returns

The image file of the server.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServer.SetupBrowserData(Autodesk.Revit.DB.ExternalResourceBrowserData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServer.SetupBrowserData(Autodesk.Revit.DB.ExternalResourceBrowserData)`

#### Summary

Implement this method to setup external resource browser data which will be accessed in Revit external resource browser UI.

#### Remarks

If errors occur during setup, store this information externally, and then retrieve and deal
with the errors during the call to HandleBrowseResult() of your IExternalResourceUIServer.

#### Parameter `browseData`

The input context to match the external resources and browser results returned by the server.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServer.AreSameResources(System.Collections.Generic.IDictionary{System.String,System.String},System.Collections.Generic.IDictionary{System.String,System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServer.AreSameResources(System.Collections.Generic.IDictionary{System.String,System.String},System.Collections.Generic.IDictionary{System.String,System.String})`

#### Summary

Implement this method to indicate whether two given resources are the same.

#### Returns

True if two given resources are the same; otherwise false.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServer.GetResourceVersionStatus(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServer.GetResourceVersionStatus(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Implement this method to indicate whether the given version of a resource is the most
current version of the data.

#### Remarks

If Revit already has a version of this resource loaded, Revit will invoke this method
to check whether the resource's data will change if `M:Autodesk.Revit.DB.IExternalResourceServer.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)` is called. If this method
returns ResourceVersionStatus.Current, then Revit will improve model performance
by not calling `M:Autodesk.Revit.DB.IExternalResourceServer.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)` .

Note that this method may also be invoked to determine the behavior of certain
elements within the user interface. For example, it may be used to warn the user if they
are about to execute certain expensive operations (such as printing) with an outdated
version of this resource.

Servers which encounter errors should return ResourceVersionStatus.Unknown. Revit
will reload resources whose version status is unknown, but will not display
out-of-date warnings to the user on printing.

#### Parameter `reference`

The ExternalResourceReference to check.

#### Returns

An enum indicating whether the resource is current, out of date, or of unknown status.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServer.GetInSessionPath(Autodesk.Revit.DB.ExternalResourceReference,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServer.GetInSessionPath(Autodesk.Revit.DB.ExternalResourceReference,System.String)`

#### Summary

Implement this method to provide the path that should be used for display and browsing to a given ExternalResourceReference
during this Revit session.

#### Remarks

This method allows an IExternalResourceServer to override the path that is used within this Revit
session to display and browse to a specific ExternalResourceReference. This method is provided
to accommodate IExternalResourceServers that may present different paths under different circumstances.
For example, an IExternalResourceServer might implement this method to return a display path
that uses the appropriate language for the user's current locale. An IExternalResourceServer
could also use this method to present the appropriate name if the user has renamed this
resource since the last time it was loaded. If the IExternalResourceServer does not need to
customize the display path, it can return the originalDisplayPath parameter.

Revit will invoke this method when the model is first loaded or before calling `M:Autodesk.Revit.DB.IExternalResourceServer.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)`
and cache the result in the ExternalResourceReference.

Do not rely on this path to look up an ExternalResourceReference, as the path is neither unique nor stable. It isn't unique
because multiple servers might use the same server name and display name format. It isn't stable because some servers allow renaming,
and because a server might change its name at some point.

#### Parameter `reference`

The ExternalResourceReference for which Revit is requesting the in session display path.

#### Parameter `originalDisplayPath`

The path that was provided for the resource when the resource was originally loaded into the model.

#### Returns

The display path that should be used for this resource for this session of Revit.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServer.IsResourceWellFormed(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServer.IsResourceWellFormed(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Implement this method to check whether the given ExternalResourceReference is formatted
correctly for this server.

#### Remarks

Different servers will have different requirements.

A server which loads references from a website might
require that the reference map contain a key called "URL"
and a value that is a valid URL.

A server which loads references from a network drive
might require a key called "Drive" with a value that
represents a drive name, plus a key called "Path" with
a value that corresponds to a path relative to the root
of the drive.

This function should not check that the resource exists
on the server. It should only check that the resource is
formatted correctly.

#### Parameter `extRef`

The ExternalResourceReference to check.

#### Returns

True if the ExternalResourceReference represents a well-formed
resource. False otherwise.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServer.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServer.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)`

#### Summary

Implement this method to load the requested resource.

#### Remarks

This method will be invoked when Revit needs to load a resource supplied by this server.

Revit provides four key pieces of information to the server:

A GUID identifying the load request.

The type of external resource that Revit is requesting, such as keynote data, linked Revit/CAD files, etc.

An ExternalResourceReference object, which contains information, such as a filename, the version, or other data,
that identifies the specific resource that Revit needs from the server.

An ExternalResourceLoadContext object, which contains information about the context of the load request. For
example, the ExternalResourceLoadContext contains information describing whether the load came about as a result of
a user action or an automatic action.

The server returns the results of the load request back to Revit via the loadResults argument, which will be a
sub-class of ExternalResourceLoadContent. This object will contain appropriate data structures to hold the actual resource
data (content) required by Revit for the specified ExternalResourceType.

Server authors may also wish to display UI related to the resource load operation, particularly when errors occur while
loading or creating the content. The UI should not be created by the IExternalResourceServer. Instead, the server
author should implement an IExternalResourcesUIServer which will handle all UI-related tasks. The external services framework
supports data sharing between, and coordinates the actions of, the two types of servers as follows:

Each ExternalResourceLoadContent sub-class is designed to hold data related to errors that may have occurred while
loading or creating the content the specified ExternalResourceType. The IExternalResourceServer should set this data as
needed in the `M:Autodesk.Revit.DB.IExternalResourceServer.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)` method.

The error data, along with ExternalResourceReference and other information associated with the attempt to load the external
resource, is stored internally by Revit until a time when it is appropriate to display UI.

When appropriate, the framework will invoke the HandleLoadResourceResults method of any IExternalResourceUIServer
that is associated with the IExternalResourceServer, and will pass the error data and other information to the UIServer
for possible display in the Revit UI.

Note that instead of using the ExternalResourceLoadContent object, the IExternalResourceServer can store its own error
information. Subsequently, when the external services framework invokes the IExternalResourceUIServer's HandleLoadResourceResults
method, the IExternalResourceUIServer can communicate directly with its associated IExternalResourceServer - using whatever interface
the server developer has implemented - to retrieve the required messages and error data for display in the UI. Revit provides
a GUID to `M:Autodesk.Revit.DB.IExternalResourceServer.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)` , to facilitate identification of individual load requests.

#### Parameter `loadRequestId`

The id uniquely identifying the load request.

#### Parameter `resourceType`

The type of resource requested.

#### Parameter `desiredResource`

The specific resource that should be loaded.

#### Parameter `loadContext`

A class containing info about the context of the load request.

#### Parameter `loadResults`

The data returned by the server as a result of this load operation.
Revit will ensure that this argument is the appropriate subclass of ExternalResourceLoadContent for the type of data.

#### Since

2015

### `M:Autodesk.Revit.DB.IExternalResourceServer.SupportsExternalResourceType(Autodesk.Revit.DB.ExternalResourceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServer.SupportsExternalResourceType(Autodesk.Revit.DB.ExternalResourceType)`

#### Summary

Implement this method to indicate whether the server can provide data for a specified type of external resource.

#### Parameter `type`

The ExternalResourceType of interest to the caller. For example, KeynoteTable - to determine
if the server provides data for Revit's keynote table.

#### Returns

True if the server supports the specified type of external resource

#### Since

2015

### `T:Autodesk.Revit.DB.IExternalResourceServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.IExternalResourceServer`

#### Summary

The interface used to provide custom implementation to provide access to external resources (such as linked files) from arbitrary locations.

#### Remarks

Certain resources used in a Revit model are stored outside of the .rvt file. For example, the data used
for keynotes, images used as decals during rendering, CAD links, and Revit links are all stored outside
the model. Creating a new implementation of this server allows the server to supply one or more types of such resources from
an arbitrary source. For example, a server could provide the keynote data from a database or from
a file format that Revit does not support.

If a model references resources supplied by this server, Revit will request the resource from the server
when it is required. Most external resources are loaded into memory at the time the model is loaded. The
server will also be invoked if the resource is explicitly reloaded.

IExternalResourceServer can declare that a resource is already up-to-date via
`M:Autodesk.Revit.DB.IExternalResourceServer.GetResourceVersionStatus(Autodesk.Revit.DB.ExternalResourceReference)` If the resource is
up-to-date, Revit will skip loading to improve performance.

Each resource load request will be associated with a GUID, so that server implementers can uniquely identify
a given load request. This may be useful to, for example, store server-side errors associated with an
attempt to load a particular resource.

If your server handles Revit or CAD links, you must take special care with link paths. When one of these
file types is uploaded to your server, any nested references should be brought to the server along with the
main link. Your server will need to repath any nested reference itself; Revit will not handle this automatically.

In the case of DWG links, your server will also need to download and possibly repath any xrefs when
LoadResource is called for the top-level link. Revit will only request the top-level link directly.

In the case of Revit links, the ExternalResourceReferences for any nested links will also
need to be modified in the host document. The host document should reference the Revit links at their
server locations, not their local file locations. Revit may not be able to find links if the
paths are not set up correctly. See `!:Autodesk::Revit::DB::TransmissionData::ReadTransmissionData`
to inspect the set of links contained within a Revit model. See
`!:Autodesk::Revit::DB::RevitLinkType::LoadFrom` to reload a Revit link from a server version.

Here is an example which uses nested Revit links: A user has a Revit model containing one link, Link.rvt, which
contains one nested link, Nest.rvt. The user uploads Link.rvt to a server, using an add-in provided by that
server. The server provider must also take Nest.rvt. Further, the server provider must open Link.rvt and modify
the reference to Nest.rvt so that it references the version on the server. Otherwise, Revit will not be able to
find Nest.rvt when another user tries to load Link.rvt from the server.

The external resource framework has been designed to allow server authors to display UI related to the resource
load operation and UI browse operation. No UI should be displayed directly from an IExternalResourceServer.
Instead, developers should create an IExternalResourceUIServer which will handle UI tasks on behalf of the IExternalResourceServer.
For more information, see the documentation for the `M:Autodesk.Revit.DB.IExternalResourceServer.LoadResource(System.Guid,Autodesk.Revit.DB.ExternalResourceType,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ExternalResourceLoadContext,Autodesk.Revit.DB.ExternalResourceLoadContent)` and `M:Autodesk.Revit.DB.IExternalResourceServer.SetupBrowserData(Autodesk.Revit.DB.ExternalResourceBrowserData)` methods.

#### Since

2015

### `M:Autodesk.Revit.DB.ServerPath.#ctor(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ServerPath.#ctor(System.String,System.String)`

#### Summary

Constructs a ServerPath

#### Parameter `centralServerLocation`

The name of the central Revit server

#### Parameter `path`

The path of the model. This path must be relative.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.ServerPath`

Member kind: type
Symbol: `Autodesk.Revit.DB.ServerPath`

#### Summary

This class represents a path to a Revit Server location, rather than a
location on disk or a network drive.

#### Remarks

ServerPaths must refer to Revit models.

ServerPaths are relative to the central server location, and
are of the form "RSN://{HostNodeName}/{model_path}".

The {model_path} portion is a relative path to a Revit model.
For example, the following are valid server paths:

RSN://EXS/hospital.rvt

RSN://EXS.autodesk.com/Old Files/hotel2.rvt

RSN://EXS.autodesk.com/Old Files/Last Week/Tuesday\hotel2.rvt
The following would not be valid server paths:
//EXS/Old Files/.rvt

EXS/hospital

#### Since

2012

### `M:Autodesk.Revit.DB.FilePath.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FilePath.#ctor(System.String)`

#### Summary

Constructs a FilePath

#### Parameter `path`

The path to the file. This path does not
have to be a full path; it can be relative.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.FilePath`

Member kind: type
Symbol: `Autodesk.Revit.DB.FilePath`

#### Summary

This class represents a path on a disk or network location, but
not a path to a Revit server location.

#### Since

2012

### `M:Autodesk.Revit.DB.ModelPath.SetVersionUrn(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPath.SetVersionUrn(System.String)`

#### Summary

An URN identifying the Forge DM (Data Management, see https://developer.autodesk.com/en/docs/data/v2/overview/) model version.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ModelPath.GetVersionUrn`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPath.GetVersionUrn`

#### Summary

An URN identifying the Forge DM (Data Management, see https://developer.autodesk.com/en/docs/data/v2/overview/) model version.

#### Since

2012

### `M:Autodesk.Revit.DB.ModelPath.SetFolderId(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPath.SetFolderId(System.String)`

#### Summary

An URN identifying the Forge DM (Data Management, see https://developer.autodesk.com/en/docs/data/v2/overview/) model folder.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ModelPath.GetFolderId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPath.GetFolderId`

#### Summary

An URN identifying the Forge DM (Data Management, see https://developer.autodesk.com/en/docs/data/v2/overview/) model folder.

#### Since

2012

### `M:Autodesk.Revit.DB.ModelPath.GetPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPath.GetPath`

#### Since

2012

### `M:Autodesk.Revit.DB.ModelPath.GetModelGUID`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPath.GetModelGUID`

#### Summary

A GUID identifying the Revit cloud model.

#### Since

2012

### `M:Autodesk.Revit.DB.ModelPath.GetProjectGUID`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPath.GetProjectGUID`

#### Summary

A GUID identifying the BIM 360 Docs or Autodesk Docs project to which the model is associated.

#### Since

2012

### `M:Autodesk.Revit.DB.ModelPath.Compare(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPath.Compare(Autodesk.Revit.DB.ModelPath)`

#### Summary

Compares this ModelPath with another

#### Remarks

The comparison is case-insensitive.

#### Parameter `otherPath`

The path to compare against.

#### Returns

A signed integer indicating the lexical relationship between
two ModelPaths. Value is less than zero if this path is less than
the given path; zero if the two are the same; and more than zero otherwise

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.ModelPath.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelPath.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ModelPath.Region`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelPath.Region`

#### Summary

The region of the BIM 360 Docs or Autodesk Docs account and project which contains this model.

#### Since

2021

### `P:Autodesk.Revit.DB.ModelPath.CloudPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelPath.CloudPath`

#### Summary

Whether this path represents a path on an Autodesk server such as BIM360.

#### Since

2019

### `P:Autodesk.Revit.DB.ModelPath.ServerPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelPath.ServerPath`

#### Summary

Whether this path is a server path (as opposed to a file path or cloud path)

#### Since

2012

### `P:Autodesk.Revit.DB.ModelPath.Empty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelPath.Empty`

#### Summary

Whether this path is empty

#### Since

2015

### `P:Autodesk.Revit.DB.ModelPath.CentralServerPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelPath.CentralServerPath`

#### Summary

The path to the location of the central Revit server or cloud.

#### Since

2012

### `T:Autodesk.Revit.DB.ModelPath`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelPath`

#### Summary

A path to a file stored on a disk or on a server.

#### Remarks

ModelPaths are paths to another file. They can
refer to Revit models, or to any of Revit's external
file references (DWG links, for example.)

Paths can be relative or absolute, but they must
include an extension indicating what kind of file it is.
Relative paths are generally relative to the currently
opened document. If the current document is workshared,
paths will be treated as relative to the central model.

To create a ModelPath, use the derived classes FilePath
, ServerPath, or use
`!:Autodesk::Revit::DB::ModelPathUtils::ConvertCloudGUIDsToCloudPath(System::Guid, System::Guid)`
for a cloud model path.

The class ModelPathUtils contains utility functions for
converting ModelPaths to and from strings.

#### Since

2012

### `P:Autodesk.Revit.DB.ExternalResourceSubFolder.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceSubFolder.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExternalResourceSubFolder.IconPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceSubFolder.IconPath`

#### Summary

The path of the resource icon.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019.1

### `P:Autodesk.Revit.DB.ExternalResourceSubFolder.FolderName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceSubFolder.FolderName`

#### Summary

Folder displayed name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019.1

### `M:Autodesk.Revit.DB.ExternalResourceSubFolder.#ctor(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceSubFolder.#ctor(System.String,System.String)`

#### Summary

Constructs a new ExternalResourceSubFolder with custom values for folder name and icon path.

#### Parameter `folderName`

Folder displayed name.

#### Parameter `iconPath`

The path of the resource icon.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019.1

### `M:Autodesk.Revit.DB.ExternalResourceSubFolder.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceSubFolder.#ctor`

#### Summary

Constructs a new ExternalResourceSubFolder with default values for folder name and icon path.

#### Since

2019.1

### `T:Autodesk.Revit.DB.ExternalResourceSubFolder`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceSubFolder`

#### Summary

Data that describes a remote folder to be shown in the file browser dialog

#### Since

2019.1

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.CallingDocumentHasModelPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.CallingDocumentHasModelPath`

#### Summary

Indicates whether the document requesting the external resource browser data has a defined ModelPath.

#### Remarks

A project that is detached, or has not been saved to disk yet, will not have a ModelPath.

#### Returns

True if the document has a defined ModelPath.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.GetCallingDocumentModelPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.GetCallingDocumentModelPath`

#### Summary

Returns a copy of the ModelPath of the document that is requesting the external resource browser data.

#### Returns

A copy of the ModelPath of the document that is requesting the external resource browser data.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document requesting the external resource browser data does not have a ModelPath, either because
it is detached, or because it has not been saved to disk yet, or no document specified.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.IsValidFolderName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.IsValidFolderName(System.String)`

#### Summary

Checks whether the folder name is valid.

#### Parameter `folderName`

The folder name to check.

#### Returns

True if the name is a valid folder name, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.IsValidResourceName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.IsValidResourceName(System.String)`

#### Summary

Checks whether the resource name is valid.

#### Parameter `resourceName`

The resource name to check.

#### Returns

True if the name is a valid resource name, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.GetSubFoldersData`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.GetSubFoldersData`

#### Summary

Gets the subfolders data under the folder path of the browser data.

#### Returns

The subfolders data under folder path of the browser data.

#### Since

2019.1

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.GetResources`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.GetResources`

#### Summary

Gets the external resources under the folder path of the browser data.

#### Returns

The external resources under current folder of the browser data.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.GetMatchOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.GetMatchOptions`

#### Summary

Gets the match options used to filter external resources.

#### Returns

The external resource match options.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.AddSubFolder(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.AddSubFolder(System.String,System.String)`

#### Summary

Adds a subfolder to the folder path with the given name and icon type.

#### Parameter `folderName`

The name of the folder.

#### Parameter `iconPath`

Icon path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The folderName is not a valid folder name used to display in Revit external resource browse UI.
The name should be a unique non-empty short name and it should not contain any invalid character of \\/:*?"<>|.
The length of combined path(server name + folder path) should not exceeds 259.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019.1

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.AddSubFolder(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.AddSubFolder(System.String)`

#### Summary

Adds a subfolder to the folder path with the given name.

#### Parameter `folderName`

The name of the folder.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The folderName is not a valid folder name used to display in Revit external resource browse UI.
The name should be a unique non-empty short name and it should not contain any invalid character of \\/:*?"<>|.
The length of combined path(server name + folder path) should not exceeds 259.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.AddResource(System.String,System.String,System.Collections.Generic.IDictionary{System.String,System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.AddResource(System.String,System.String,System.Collections.Generic.IDictionary{System.String,System.String})`

#### Summary

Adds an external resource to the folder path by supplying the resource name, version and reference information.

#### Parameter `resourceName`

The unique short name of external resource.

#### Parameter `version`

The version of external resource.

#### Parameter `referenceInformation`

The (String, String) map containing reference or lookup information that will
be stored in Revit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The resourceName is not a valid resource name used to display in Revit external resource browse UI.
The name should be a unique non-empty short name and it should not contain any invalid character of \\/:*?"<>|.
The length of combined path(server name + folder path + resourceName) should not exceeds 259.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.AddResource(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.AddResource(System.String,System.String)`

#### Summary

Adds an external resource to the folder path by supplying the resource name and version.

#### Parameter `resourceName`

The unique short name of external resource.

#### Parameter `version`

The version of external resource.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The resourceName is not a valid resource name used to display in Revit external resource browse UI.
The name should be a unique non-empty short name and it should not contain any invalid character of \\/:*?"<>|.
The length of combined path(server name + folder path + resourceName) should not exceeds 259.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.AddResource(System.String,System.Collections.Generic.IDictionary{System.String,System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.AddResource(System.String,System.Collections.Generic.IDictionary{System.String,System.String})`

#### Summary

Adds an external resource to the folder path by supplying the resource name and reference information.

#### Parameter `resourceName`

The unique short name of external resource.

#### Parameter `referenceInformation`

The (String, String) map containing reference or lookup information that will
be stored in Revit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The resourceName is not a valid resource name used to display in Revit external resource browse UI.
The name should be a unique non-empty short name and it should not contain any invalid character of \\/:*?"<>|.
The length of combined path(server name + folder path + resourceName) should not exceeds 259.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.AddResource(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.AddResource(System.String)`

#### Summary

Adds an external resource to the folder path by supplying the resource name.

#### Parameter `resourceName`

The unique short name of external resource.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The resourceName is not a valid resource name used to display in Revit external resource browse UI.
The name should be a unique non-empty short name and it should not contain any invalid character of \\/:*?"<>|.
The length of combined path(server name + folder path + resourceName) should not exceeds 259.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalResourceBrowserData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExternalResourceBrowserData.FolderPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.FolderPath`

#### Summary

The current folder path to which the new resources and subfolder belong.

#### Since

2015

### `P:Autodesk.Revit.DB.ExternalResourceBrowserData.ServerId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.ServerId`

#### Summary

The Id of IExternalResourceServer which handles the external resource load.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalResourceBrowserData.#ctor(Autodesk.Revit.DB.Document,System.Guid,System.String,Autodesk.Revit.DB.ExternalResourceMatchOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData.#ctor(Autodesk.Revit.DB.Document,System.Guid,System.String,Autodesk.Revit.DB.ExternalResourceMatchOptions)`

#### Summary

Constructs a new ExternalResourceBrowserData using the given document(optional), server id, folder path and match options.

#### Parameter `document`

The document for which the external resource browser data is requested.
The document can be `null` , if so, the getCallingDocumentModelPath() will not return ModelPath.

#### Parameter `serverId`

The id of IExternalResourceServer which handles the external resource browsing and loading.

#### Parameter `folderPath`

The folder path to which the external resources and subfolders belong.

The folder separator should always be "/" and "/" always represents the root folder for the server.

The interpretation of what a folder represents is up to the server.
For example, the folder "/English/Keynote" might be a physical folder on a disk, or a table or key in a database.

#### Parameter `matchOptions`

The options to match the external resources and folders.

Generally, the returned resources should match the options, otherwise the resource may be regarded
as invalid which may not be available in browser dialogs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.ExternalResourceBrowserData`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalResourceBrowserData`

#### Summary

Represents a collection of external resources and external resource folders to be presented as
the content of a folder in the file browser in Revit.

#### Remarks

This data represents the contents to be shown to the user while they are browsing a specific folder in Revit.

The folder path can be obtained from the `P:Autodesk.Revit.DB.ExternalResourceBrowserData.FolderPath` property.

The external resource server is expected to populate all of the available resources and subfolders
that should appear in the Revit file browser while the browser is open to this particular folder.

If the user navigates to another folder, a different ExternalResourceBrowserData object will be
provided to allow the server to populate resources at that location.

When adding resource and subfolder, the resource and subfolder should not be added recursively.

When adding resource and subfolder, the name should be unique short name(without folder).

The name of resource and subfolder should not contain any invalid character of \/:*?"<>|.

The length of resource combined path(server name + folder path + resource name) should not exceed 259;
The length of subfolder also has same restriction.

#### Since

2015

### `M:Autodesk.Revit.DB.ExternalGeometryId.IsValidExternalGeometryId(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalGeometryId.IsValidExternalGeometryId(System.String)`

#### Summary

Checks whether a given string represents a valid ExternalGeometryId or not.

#### Remarks

Any non-empty string is a valid ExternalGeometryId.

#### Parameter `externalGeometryId`

A string that represents an identifier for an external geometry.

#### Returns

True if the string represents a valid ExternalGeometryId, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.ExternalGeometryId.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalGeometryId.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExternalGeometryId.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalGeometryId.Id`

#### Summary

External geometry identifier.

#### Since

2022

### `M:Autodesk.Revit.DB.ExternalGeometryId.GetHashCode`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalGeometryId.GetHashCode`

#### Summary

Gets the hash code.

### `M:Autodesk.Revit.DB.ExternalGeometryId.Equals(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalGeometryId.Equals(System.Object)`

#### Summary

Determines whether the specified `T:System.Object` is equal to the current `T:System.Object` .

#### Parameter `obj`

Another object.

### `M:Autodesk.Revit.DB.ExternalGeometryId.op_Inequality(Autodesk.Revit.DB.ExternalGeometryId,Autodesk.Revit.DB.ExternalGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalGeometryId.op_Inequality(Autodesk.Revit.DB.ExternalGeometryId,Autodesk.Revit.DB.ExternalGeometryId)`

#### Summary

Determines whether two ExternalGeometryIds are different.

#### Parameter `first`

The first ExternalGeometryId.

#### Parameter `second`

The second ExternalGeometryId.

#### Returns

True if the ExternalGeometryIds are different; otherwise, false.

### `M:Autodesk.Revit.DB.ExternalGeometryId.op_Equality(Autodesk.Revit.DB.ExternalGeometryId,Autodesk.Revit.DB.ExternalGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalGeometryId.op_Equality(Autodesk.Revit.DB.ExternalGeometryId,Autodesk.Revit.DB.ExternalGeometryId)`

#### Summary

Determines whether two ExternalGeometryIds are the same.

#### Parameter `first`

The first ExternalGeometryId.

#### Parameter `second`

The second ExternalGeometryId.

#### Returns

True if the ExternalGeometryIds are the same; otherwise, false.

### `M:Autodesk.Revit.DB.ExternalGeometryId.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalGeometryId.#ctor(System.String)`

#### Summary

Constructs an ExternalGeometryId object holding the given external geometry identifier.

#### Parameter `externalGeometryId`

A string that represents an identifier for an external geometry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

externalGeometryId is not a valid ExternalGeometryId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.ExternalGeometryId`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalGeometryId`

#### Summary

This class represents an identifier for geometry from external sources.

#### Since

2022

### `M:Autodesk.Revit.DB.ExternalFileUtils.GetBaseForRelativePathFromDocument(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalFileUtils.GetBaseForRelativePathFromDocument(Autodesk.Revit.DB.Document)`

#### Summary

Gets the path that is the basis for relative paths from a document

#### Remarks

This is the path to the central model if this is a workshared document.
Otherwise it is the path to the model file itself.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ExternalFileUtils.GetFileBasedTempFolder(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalFileUtils.GetFileBasedTempFolder(System.String)`

#### Summary

Gets a temp folder based on the given file name

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ExternalFileUtils.GetAllExternalFileReferences(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalFileUtils.GetAllExternalFileReferences(Autodesk.Revit.DB.Document)`

#### Summary

Gets the ids of all elements which are external file references.

#### Remarks

This function will not return the ids of nested Revit links;
it only returns top-level references.

#### Parameter `aDoc`

A Revit Document.

#### Returns

The ids of all elements which are external file references.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ExternalFileUtils.GetExternalFileReference(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalFileUtils.GetExternalFileReference(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the external file referencing data for the given element.

#### Parameter `aDoc`

A Revit Document.

#### Parameter `elemId`

The element whose external file reference we want.

#### Returns

An object containing path and type information for the given element's external file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elemId does not exist in the document
-or-
elemId does not represent an external file reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ExternalFileUtils.IsExternalFileReference(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalFileUtils.IsExternalFileReference(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Determines whether the given element represents an external file.

#### Remarks

CAD imports are not external file references, as their
data is brought fully into Revit. No connection is maintained
to the original file.

A link may be an external resource without being an external file.

#### Parameter `aDoc`

A Revit Document.

#### Parameter `elemId`

The element to be checked for an external file reference.

#### Returns

True if the given element represents an external file; false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elemId does not exist in the document

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.ExternalFileUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalFileUtils`

#### Summary

A utility class containing functions related to external file references.

#### Remarks

Elements which are external file references refer to files outside of the base .rvt file.
Examples include Revit links, CAD links, the element which stores the location
of the keynote file, and rendering decals.

#### Since

2012

### `P:Autodesk.Revit.DB.ExtensibleStorage.ExtensibleStorageFilter.SchemaGuid`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.ExtensibleStorageFilter.SchemaGuid`

#### Summary

Schema id used to filter elements with extensible storage data

#### Since

2014

### `M:Autodesk.Revit.DB.ExtensibleStorage.ExtensibleStorageFilter.#ctor(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.ExtensibleStorageFilter.#ctor(System.Guid)`

#### Summary

Constructs a new instance of a filter to match elements with extensible storage data based on specific Schema id.

#### Parameter `schemaGuid`

Schema id used to filter elements with extensible storage data

#### Since

2014

### `T:Autodesk.Revit.DB.ExtensibleStorage.ExtensibleStorageFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExtensibleStorage.ExtensibleStorageFilter`

#### Summary

A filter used to filter elements with extensible storage data based on specific Schema id.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.IExtElemChangeBeamSectionProxy.ChangeSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IExtElemChangeBeamSectionProxy.ChangeSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

The method that will be called when user wants to change beam section

#### Parameter `doc`

Revit document

#### Parameter `idElem`

id of the selected element

#### Returns

Indicates whether the operation succeeded or not

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.IExtElemChangeBeamSection.ChangeSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IExtElemChangeBeamSection.ChangeSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

The method that will be called when user wants to change beam section

#### Parameter `doc`

Revit document

#### Parameter `idElem`

id of the selected element

#### Returns

Indicates whether the operation succeeded or not

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.IExtElemChangeBeamSection`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.IExtElemChangeBeamSection`

#### Summary

Interface Change Beam section functionality to be implemented in add-ins

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.ExtElemChangeBeamSectionRegistry.Unregister`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ExtElemChangeBeamSectionRegistry.Unregister`

#### Summary

Unregisters IExtElemChangeBeamSection.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no valid Connections Provider registered.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.ExtElemChangeBeamSectionRegistry.RegisterInterface(Autodesk.Revit.DB.Structure.IExtElemChangeBeamSection)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ExtElemChangeBeamSectionRegistry.RegisterInterface(Autodesk.Revit.DB.Structure.IExtElemChangeBeamSection)`

#### Summary

Registers a IExtElemChangeBeamSection

#### Parameter `provider`

IExtElemChangeBeamSection to be registered.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The provider object is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is already registered Connections Provider.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.ExtElemChangeBeamSectionRegistry.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ExtElemChangeBeamSectionRegistry.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.ExtElemChangeBeamSectionRegistry`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ExtElemChangeBeamSectionRegistry`

#### Summary

An object that stores IExtElemChangeBeamSection

#### Since

2018

### `M:Autodesk.Revit.DB.NurbsSurfaceData.GetWeights`

Member kind: method
Symbol: `Autodesk.Revit.DB.NurbsSurfaceData.GetWeights`

#### Summary

Get the list of weights.

#### Since

2016

### `M:Autodesk.Revit.DB.NurbsSurfaceData.GetControlPoints`

Member kind: method
Symbol: `Autodesk.Revit.DB.NurbsSurfaceData.GetControlPoints`

#### Summary

Get the list of control points.

#### Since

2016

### `M:Autodesk.Revit.DB.NurbsSurfaceData.GetKnotsV`

Member kind: method
Symbol: `Autodesk.Revit.DB.NurbsSurfaceData.GetKnotsV`

#### Summary

Get the list of knots in the v-direction.

#### Since

2016

### `M:Autodesk.Revit.DB.NurbsSurfaceData.GetKnotsU`

Member kind: method
Symbol: `Autodesk.Revit.DB.NurbsSurfaceData.GetKnotsU`

#### Summary

Get the list of knots in the u-direction.

#### Since

2016

### `M:Autodesk.Revit.DB.NurbsSurfaceData.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.NurbsSurfaceData.IsValid`

#### Summary

Check if the object contains a valid NurbsSurfaceData.

#### Returns

True if it is a valid NurbsSurfaceData, false otherwise.

#### Since

2016

### `M:Autodesk.Revit.DB.NurbsSurfaceData.Create(System.Int32,System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Double},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NurbsSurfaceData.Create(System.Int32,System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Double},System.Boolean)`

#### Summary

Construct NurbsSurfaceData based on NURBS surface data, where the weights are supplied.
The NURBS surface will be (piecewise) polynomial if all the weights are equal, rational if not.
Note: A rational polynomial is a quotient of two polynomials; this includes a polynomial,
which can be thought of as a quotient with denominator equal to 1.

#### Parameter `degreeU`

The degree of the spline in the u-direction; must be positive.

#### Parameter `degreeV`

The degree of the spline in the v-direction; must be positive.

#### Parameter `knotsU`

Knot values in the u-direction.
The number of knots in the u-direction must be at least 2 * (degreeU + 1).

#### Parameter `knotsV`

Knot values in the v-direction.
The number of knots in the v-direction must be at least 2 * (degreeV + 1).

#### Parameter `controlPoints`

One dimensional array of points representing the two dimensional net of control points
of the NURBS surface in u and v directions.

The total number of control points must equal numControlPtsU times numControlPtsV,
where numControlPtsU and numControlPtsV are the numbers of control points in u and v directions,
and they must satisfy the following conditions:
numControlPtsU = number of knots in u - degreeU - 1.

numControlPtsV = number of knots in v - degreeV - 1.
The convention for 2d (idxU, idxV) to 1d (idx) conversion of array indexes: idxV first.
That is, idxU is outer loop and idxV is inner loop. In other words,
idx = idxU * numControlPtsV + idxV.

#### Parameter `weights`

Array of weights assigned to the control points.
The number of weights must equal the number of control points.
All weights should be greater than zero.

#### Parameter `bReverseOrientation`

If true, the surface's orientation is opposite to the canonical parametric orientation, otherwise it is the same.
The canonical parametric orientation is a counter-clockwise sense of rotation in the uv-parameter plane.
Extrinsically, the oriented normal vector for the canonical parametric orientation points in the direction of
the cross product dS/du x dS/dv, which S(u, v) is the parameterized surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The U-degree value must be at least 1.
-or-
The V-degree value must be at least 1.
-or-
The number of knots in the U direction must be at least 2 times the U-degree plus 1.
-or-
The number of knots in the V direction must be at least 2 times the V-degree plus 1.
-or-
The number of control points must equal (number of U-knots - U-degree - 1) * (number of V-knots - V-degree - 1).
-or-
The number of weights must be the same as the number of control points and all weights must be positive or all zero.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.NurbsSurfaceData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.NurbsSurfaceData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.NurbsSurfaceData.ReverseOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.NurbsSurfaceData.ReverseOrientation`

#### Summary

If true, the surface's orientation is opposite to the canonical parametric orientation, otherwise it is the same.
The canonical parametric orientation is a counter-clockwise sense of rotation in the uv-parameter plane.
Extrinsically, the oriented normal vector for the canonical parametric orientation points in the direction of
the cross product dS/du x dS/dv, which S(u, v) is the parameterized surface.

#### Since

2016

### `P:Autodesk.Revit.DB.NurbsSurfaceData.IsRational`

Member kind: property
Symbol: `Autodesk.Revit.DB.NurbsSurfaceData.IsRational`

#### Summary

Tells if the spline is rational or not.
If it is true (rational), then the NURBS is a piecewise rational polynomial function.
If it is false (non-rational), then the NURBS is a piecewise polynomial function.

#### Since

2016

### `P:Autodesk.Revit.DB.NurbsSurfaceData.DegreeV`

Member kind: property
Symbol: `Autodesk.Revit.DB.NurbsSurfaceData.DegreeV`

#### Summary

The degree of the spline in the v-direction.

#### Since

2016

### `P:Autodesk.Revit.DB.NurbsSurfaceData.DegreeU`

Member kind: property
Symbol: `Autodesk.Revit.DB.NurbsSurfaceData.DegreeU`

#### Summary

The degree of the spline in the u-direction.

#### Since

2016

### `M:Autodesk.Revit.DB.NurbsSurfaceData.#ctor(Autodesk.Revit.DB.NurbsSurfaceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NurbsSurfaceData.#ctor(Autodesk.Revit.DB.NurbsSurfaceData)`

#### Summary

Copy constructor.

#### Parameter `other`

The NurbsSurfaceData to copy.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.NurbsSurfaceData`

Member kind: type
Symbol: `Autodesk.Revit.DB.NurbsSurfaceData`

#### Summary

A class used to represent the definition of a NURBS surface.

#### Since

2016

### `M:Autodesk.Revit.DB.ExportUtils.GetNurbsSurfaceDataForSurface(Autodesk.Revit.DB.Surface)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportUtils.GetNurbsSurfaceDataForSurface(Autodesk.Revit.DB.Surface)`

#### Summary

Returns the necessary information to define a NURBS surface
for a given `!:Autodesk::Revit::DB::HermiteSuface` or `!:Autodesk::Revit::DB::RuledSuface` .

#### Remarks

This function is intended for export purposes.

#### Parameter `surface`

The HermiteSurface or RuledSurface to be converted.

#### Returns

A class containing the necessary data to define a NURBS surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This surface type is not supported for this function.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Couldn't get NURBS data from surface.

#### Since

2021

### `M:Autodesk.Revit.DB.ExportUtils.GetGBXMLDocumentId(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportUtils.GetGBXMLDocumentId(Autodesk.Revit.DB.Document)`

#### Summary

Retrieves the GUID representing this document in exported gbXML files.

#### Remarks

This id can be used to cross-reference different gbXML exports from the same document.

#### Parameter `document`

The document.

#### Returns

The value of the GUID representing this document in gbXML export.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportUtils.GetExportId(Autodesk.Revit.DB.Subelement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportUtils.GetExportId(Autodesk.Revit.DB.Subelement)`

#### Summary

Retrieves the GUID representing the subelement in DWF and IFC export.

#### Remarks

This id is used in the contents of DWF export and IFC export and it should be used
only when cross-referencing to the contents of these export formats.
When storing Ids that will need to be mapped back to subelements in future sessions,
`P:Autodesk.Revit.DB.Subelement.UniqueId` must be used.

#### Parameter `subelement`

The subelement.

#### Returns

The value of the GUID representing the subelement in the export context.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.ExportUtils.GetExportId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportUtils.GetExportId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Retrieves the GUID representing this element in DWF and IFC export.

#### Remarks

This id is used in the contents of DWF export and IFC export and it should be used
only when cross-referencing to the contents of these export formats.
When storing Ids that will need to be mapped back to elements in future sessions,
`P:Autodesk.Revit.DB.Element.UniqueId` must be used.

#### Parameter `document`

The document.

#### Parameter `elementId`

The id of the element.

#### Returns

The value of the GUID representing the element in the export context.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.ExportUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportUtils`

#### Summary

This class provides utilities related to document export.

#### Since

2011

### `T:Autodesk.Revit.DB.ExportResolution`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportResolution`

#### Since

2023

#### Summary

An enumerated type listing possible options to control the tessellation quality.

#### Since

2023

### `F:Autodesk.Revit.DB.ExportResolution.Coarse`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportResolution.Coarse`

#### Summary

Tessellated export with coarse resolution.

### `F:Autodesk.Revit.DB.ExportResolution.Medium`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportResolution.Medium`

#### Summary

Tessellated export with medium resolution.

### `F:Autodesk.Revit.DB.ExportResolution.Fine`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportResolution.Fine`

#### Summary

Tessellated export with fine resolution.

### `F:Autodesk.Revit.DB.ExportResolution.Custom`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportResolution.Custom`

#### Summary

Tessellated export with custom resolution (all tessellation parameters have default values).

### `T:Autodesk.Revit.DB.ExportRange`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportRange`

#### Summary

This enum is used to define what view, part of the view, or list of views will be exported.

#### Since

2011

### `F:Autodesk.Revit.DB.ExportRange.SetOfViews`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportRange.SetOfViews`

#### Summary

Export a set of views (set in ViewsAndSheets).

### `F:Autodesk.Revit.DB.ExportRange.VisibleRegionOfCurrentView`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportRange.VisibleRegionOfCurrentView`

#### Summary

Export the visible region of the current view.

### `F:Autodesk.Revit.DB.ExportRange.CurrentView`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportRange.CurrentView`

#### Summary

Export the current view only (zoom to fit of the current view).

### `M:Autodesk.Revit.DB.ExportPatternTable.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTable.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.ExportPatternTable.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTable.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.ExportPatternTable.GetExportPatternTableIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTable.GetExportPatternTableIterator`

#### Summary

Returns a ExportPatternTableIterator to the pattern table.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternTable.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTable.Clear`

#### Summary

Removes all contents stored in the table.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternTable.Remove(Autodesk.Revit.DB.ExportPatternKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTable.Remove(Autodesk.Revit.DB.ExportPatternKey)`

#### Summary

Removes the pair (key, info) by pattern key.

#### Parameter `exportPatternKey`

The export pattern key.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternTable.Add(Autodesk.Revit.DB.ExportPatternKey,Autodesk.Revit.DB.ExportPatternInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTable.Add(Autodesk.Revit.DB.ExportPatternKey,Autodesk.Revit.DB.ExportPatternInfo)`

#### Summary

Inserts a (key,info) pair into Export pattern table.

#### Parameter `exportPatternKey`

The export pattern key to be added.

#### Parameter `exportPatternInfo`

The export pattern info to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The key already exists in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternTable.GetValues`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTable.GetValues`

#### Summary

Returns all the values stored in the map.

#### Returns

Return the info array.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternTable.GetKeys`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTable.GetKeys`

#### Summary

Gets all the keys stored in the map.

#### Returns

Return the key array.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternTable.GetExportPatternInfo(Autodesk.Revit.DB.ExportPatternKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTable.GetExportPatternInfo(Autodesk.Revit.DB.ExportPatternKey)`

#### Summary

Gets a copy of the pattern info associated to the input pattern key.

#### Parameter `exportPatternKey`

The export pattern Key.

#### Returns

Return the patternInfo for this key.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

An entry with the given key is not present in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternTable.ContainsKey(Autodesk.Revit.DB.ExportPatternKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTable.ContainsKey(Autodesk.Revit.DB.ExportPatternKey)`

#### Summary

Checks whether a pattern key exists in the table.

#### Parameter `exportpatternKey`

The export pattern Key.

#### Returns

True if the pattern key exists in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ExportPatternTable.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportPatternTable.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportPatternTable.Count`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportPatternTable.Count`

#### Summary

Count of the items contained in the collection.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportPatternTable.default(Autodesk.Revit.DB.ExportPatternKey)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportPatternTable.default(Autodesk.Revit.DB.ExportPatternKey)`

#### Summary

A copy of the `T:Autodesk.Revit.DB.ExportPatternInfo` for the pattern's `T:Autodesk.Revit.DB.ExportPatternKey` .

#### Remarks

When getting this property, it returns a copy of the `T:Autodesk.Revit.DB.ExportPatternInfo` from the table. In order to
make changes to the `T:Autodesk.Revit.DB.ExportPatternInfo` and use those settings during export, set the modified
`T:Autodesk.Revit.DB.ExportPatternInfo` back into the table using the same key.

#### Parameter `exportPatternKey`

The key.

#### Returns

A copy of the `T:Autodesk.Revit.DB.ExportPatternInfo` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When getting this property:
An entry with the given key is not present in the table.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternTable.GetPatternTableIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTable.GetPatternTableIterator`

#### Summary

Returns a PatternTableIterator that iterates through the collection.

#### Returns

A PatternTableIterator object that can be used to iterate through key-value pairs in the collection.

### `M:Autodesk.Revit.DB.ExportPatternTable.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTable.#ctor`

#### Summary

Constructs a new ExportPatternTable with default values.

#### Since

2014

### `T:Autodesk.Revit.DB.ExportPatternTable`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportPatternTable`

#### Summary

A table supporting a mapping of FillPatterns in Revit to pattern names that will be set
in the target export format.

#### Remarks

This table is structured as a mapping from `T:Autodesk.Revit.DB.ExportPatternKey` to
`T:Autodesk.Revit.DB.ExportPatternInfo` members. The `T:Autodesk.Revit.DB.ExportPatternKey`
contains the identification information for the pattern table: the Revit fill pattern type and name. The
`T:Autodesk.Revit.DB.ExportPatternInfo` contains the pattern name to use in the export format.

The table can be accessed via direct iteration as a collection of KeyValuePairs, or by traversal of the stored keys
obtained from GetKeys(), or via specific lookup of a key constructed externally. In all cases, the
`T:Autodesk.Revit.DB.ExportPatternInfo` returned will be a copy of the `T:Autodesk.Revit.DB.ExportPatternInfo`
from the table. In order to make changes to the `T:Autodesk.Revit.DB.ExportPatternInfo` and use those settings during export,
set the modified `T:Autodesk.Revit.DB.ExportPatternInfo` back into the table using the same key.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportPatternTableIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportPatternTableIterator.CurrentObject`

### `P:Autodesk.Revit.DB.ExportPatternTableIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportPatternTableIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.ExportPatternTableIterator.GetValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTableIterator.GetValue`

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternTableIterator.GetKey`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTableIterator.GetKey`

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternTableIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTableIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternTableIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTableIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternTableIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternTableIterator.MoveNext`

#### Summary

Increments the iterator to the next item.

#### Returns

True if there is a next available item in this iterator.
False if the iterator has completed all available items.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportPatternTableIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportPatternTableIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ExportPatternTableIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportPatternTableIterator`

#### Summary

An iterator to a set of Pattern table.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportPatternInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportPatternInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportPatternInfo.DestinationPatternName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportPatternInfo.DestinationPatternName`

#### Summary

The destination pattern name (the name of the pattern in the exported format).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternInfo.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternInfo.#ctor(System.String)`

#### Summary

Constructs a new ExportPatternInfo using the destination pattern name as input.

#### Parameter `destinationPatternName`

The destination pattern name (the name of the pattern in the exported format).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternInfo.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternInfo.#ctor`

#### Summary

Constructs a new default ExportPatternInfo.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternInfo.#ctor(Autodesk.Revit.DB.ExportPatternInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternInfo.#ctor(Autodesk.Revit.DB.ExportPatternInfo)`

#### Summary

Constructs a new copy of the input ExportPatternInfo object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.ExportPatternInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportPatternInfo`

#### Summary

A value used to represent the info stored in the `T:Autodesk.Revit.DB.ExportPatternTable` .

#### Since

2014

### `P:Autodesk.Revit.DB.ExportPatternKey.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportPatternKey.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportPatternKey.OriginalFillPatternName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportPatternKey.OriginalFillPatternName`

#### Summary

The original FillPattern name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ExportPatternKey.OriginalFillPatternType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportPatternKey.OriginalFillPatternType`

#### Summary

The original FillPattern type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternKey.#ctor(Autodesk.Revit.DB.FillPatternTarget,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternKey.#ctor(Autodesk.Revit.DB.FillPatternTarget,System.String)`

#### Summary

Constructs a new ExportPatternKey using the original fill pattern type and name as input.

#### Parameter `originalFillPatternType`

The original FillPattern type.

#### Parameter `originalFillPatternName`

The original FillPattern name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternKey.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternKey.#ctor`

#### Summary

Constructs a new default ExportPatternKey.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportPatternKey.#ctor(Autodesk.Revit.DB.ExportPatternKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPatternKey.#ctor(Autodesk.Revit.DB.ExportPatternKey)`

#### Summary

Constructs a new copy of the input ExportPatternKey object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.ExportPatternKey`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportPatternKey`

#### Summary

A key used to represent an item stored in an `T:Autodesk.Revit.DB.ExportPatternTable` .

#### Since

2014

### `T:Autodesk.Revit.DB.FillPatternHostOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.FillPatternHostOrientation`

#### Summary

The types of orientations for fill patterns.

#### Since

2012

### `F:Autodesk.Revit.DB.FillPatternHostOrientation.ToHost`

Member kind: field
Symbol: `Autodesk.Revit.DB.FillPatternHostOrientation.ToHost`

#### Summary

Patterns align with the host and compute a origin to fit the host.

### `F:Autodesk.Revit.DB.FillPatternHostOrientation.AsText`

Member kind: field
Symbol: `Autodesk.Revit.DB.FillPatternHostOrientation.AsText`

#### Summary

Mimics the behavior of text. Patterns align with the host and share the same origin with respect to view.

### `F:Autodesk.Revit.DB.FillPatternHostOrientation.ToView`

Member kind: field
Symbol: `Autodesk.Revit.DB.FillPatternHostOrientation.ToView`

#### Summary

All patterns share the same orientation and origin with respect to view, so they perfectly align at element transitions.

### `T:Autodesk.Revit.DB.FillPatternTarget`

Member kind: type
Symbol: `Autodesk.Revit.DB.FillPatternTarget`

#### Summary

The type of the fill pattern.

#### Since

2012

### `F:Autodesk.Revit.DB.FillPatternTarget.Model`

Member kind: field
Symbol: `Autodesk.Revit.DB.FillPatternTarget.Model`

#### Summary

Represents an actual element appearance on a building.

### `F:Autodesk.Revit.DB.FillPatternTarget.Drafting`

Member kind: field
Symbol: `Autodesk.Revit.DB.FillPatternTarget.Drafting`

#### Summary

Represents a material in symbolic form.

### `M:Autodesk.Revit.DB.PDFExportOptions.SetPdfParameterProvider(Autodesk.Revit.DB.IPDFParametersProvider)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PDFExportOptions.SetPdfParameterProvider(Autodesk.Revit.DB.IPDFParametersProvider)`

#### Summary

Sets PdfParameterProvider.

#### Parameter `pParameterProvider`

Set to `nullptr` to remove ParameterProvider.

#### Since

2022

### `M:Autodesk.Revit.DB.PDFExportOptions.GetPdfParameterProvider`

Member kind: method
Symbol: `Autodesk.Revit.DB.PDFExportOptions.GetPdfParameterProvider`

#### Summary

Gets PdfParameterProvider.

#### Since

2022

### `M:Autodesk.Revit.DB.PDFExportOptions.IsValidNamingRule(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PDFExportOptions.IsValidNamingRule(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

#### Summary

Whether naming rule is valid or not.

#### Remarks

If true, this naming rule is a valid.
If false, this naming rule is not valid for empty naming rule or illegal characters, such as `\ / : * ? " < > |` .

#### Parameter `namingRule`

The naming rule to be validated.

#### Returns

Whether or not the name is valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.PDFExportOptions.SetNamingRule(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PDFExportOptions.SetNamingRule(System.Collections.Generic.IList{Autodesk.Revit.DB.TableCellCombinedParameterData})`

#### Summary

Sets the naming rule.

#### Parameter `namingRule`

The naming rule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The namingRule is empty or contains illegal characters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.PDFExportOptions.GetNamingRule`

Member kind: method
Symbol: `Autodesk.Revit.DB.PDFExportOptions.GetNamingRule`

#### Summary

Gets a copy of the naming rule.

#### Returns

The naming rule.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.PDFExportOptions.Combine`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.Combine`

#### Summary

Whether export all views and sheets into one PDF file or multiple files.

#### Remarks

If `true` , all exported views and sheets will be exported into one PDF file, whose file name would be specified by `P:Autodesk.Revit.DB.PDFExportOptions.FileName` .
If `false` , each exported view and sheet will have its own PDF file created, whose file name would be generated with `!:NamingRule` .

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.StopOnError`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.StopOnError`

#### Summary

Whether export process should stop when a view fails to export

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.ReplaceHalftoneWithThinLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.ReplaceHalftoneWithThinLines`

#### Summary

Whether to replace halftone with thin lines.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.MaskCoincidentLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.MaskCoincidentLines`

#### Summary

Whether to mask coincident lines.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.HideScopeBoxes`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.HideScopeBoxes`

#### Summary

Whether to hide scope boxes.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.HideUnreferencedViewTags`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.HideUnreferencedViewTags`

#### Summary

Whether to hide unreferenced view tags.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.HideReferencePlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.HideReferencePlane`

#### Summary

Whether to hide reference/work planes.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.HideCropBoundaries`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.HideCropBoundaries`

#### Summary

Whether to hide crop boundaries.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.ViewLinksInBlue`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.ViewLinksInBlue`

#### Summary

Whether set view links blue.

#### Remarks

If true, links will be visible as blue.
If false, they retain their default text color.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.OriginOffsetY`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.OriginOffsetY`

#### Summary

Offset between bottom sides of pdf content and paper. Always stored in unit of Feet.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.OriginOffsetX`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.OriginOffsetX`

#### Summary

Offset between left sides of pdf content and paper. Always stored in unit of Feet.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.PaperPlacement`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.PaperPlacement`

#### Summary

Paper placement of either center or offset from corner.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.ColorDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.ColorDepth`

#### Summary

Color depth of either black/white, gray scale or color.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.ExportQuality`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.ExportQuality`

#### Summary

The preferred export quality (DPI).

#### Remarks

This quality setting is the equivalent of printer resolution found in advanced printer settings.
An effect of the setting is to control tessellation quality.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.RasterQuality`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.RasterQuality`

#### Summary

The preferred raster quality (DPI).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.ZoomPercentage`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.ZoomPercentage`

#### Summary

Percentage of the zoom for the view.

#### Remarks

This property would be ignored if the ZoomType is FitToPage.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.ZoomType`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.ZoomType`

#### Summary

Zoom type of either fit to page or on a specific percentage.

#### Remarks

This property would be ignored if the PaperFormat is Default.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.AlwaysUseRaster`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.AlwaysUseRaster`

#### Summary

If true completely use raster processing for graphics,
otherwise use vector processing as much as possible.

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.PaperFormat`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.PaperFormat`

#### Summary

Paper format.

#### Remarks

When the PaperFormat is ExportPaperFormat.Default, which means "Use Sheet Size".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The input paper format is invalid

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.PaperOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.PaperOrientation`

#### Summary

Paper orientation - Portrait/Landscape/Auto

#### Remarks

Ignored when the PaperFormat is ExportPaperFormat.Default, which means "Use Sheet Size".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `P:Autodesk.Revit.DB.PDFExportOptions.FileName`

Member kind: property
Symbol: `Autodesk.Revit.DB.PDFExportOptions.FileName`

#### Summary

File name of the PDF when `P:Autodesk.Revit.DB.PDFExportOptions.Combine` is `true` .

#### Remarks

PDF file extension (".pdf") would be automatically appended to the result file.
When `P:Autodesk.Revit.DB.PDFExportOptions.Combine` is `false` , this would be ignored.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.PDFExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PDFExportOptions.#ctor`

#### Summary

Creates a default options object.

#### Since

2022

### `T:Autodesk.Revit.DB.PDFExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.PDFExportOptions`

#### Summary

Options for PDF export

#### Since

2022

### `T:Autodesk.Revit.DB.PDFExportQualityType`

Member kind: type
Symbol: `Autodesk.Revit.DB.PDFExportQualityType`

#### Summary

An enumerated type listing the options for PDF export quality.

### `T:Autodesk.Revit.DB.ZoomType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ZoomType`

#### Summary

An enumerated type listing all Zoom types of Print Setting.

### `F:Autodesk.Revit.DB.ZoomType.Zoom`

Member kind: field
Symbol: `Autodesk.Revit.DB.ZoomType.Zoom`

#### Summary

The type of Zoom is user defined.

### `F:Autodesk.Revit.DB.ZoomType.FitToPage`

Member kind: field
Symbol: `Autodesk.Revit.DB.ZoomType.FitToPage`

#### Summary

The type of Zoom is Fit To Page.

### `T:Autodesk.Revit.DB.RasterQualityType`

Member kind: type
Symbol: `Autodesk.Revit.DB.RasterQualityType`

#### Summary

An enumerated type listing the options for raster quality.

### `F:Autodesk.Revit.DB.RasterQualityType.Presentation`

Member kind: field
Symbol: `Autodesk.Revit.DB.RasterQualityType.Presentation`

#### Summary

The type of Raster Quality is Presentation.

### `F:Autodesk.Revit.DB.RasterQualityType.High`

Member kind: field
Symbol: `Autodesk.Revit.DB.RasterQualityType.High`

#### Summary

The type of Raster Quality is High.

### `F:Autodesk.Revit.DB.RasterQualityType.Medium`

Member kind: field
Symbol: `Autodesk.Revit.DB.RasterQualityType.Medium`

#### Summary

The type of Raster Quality is Medium.

### `F:Autodesk.Revit.DB.RasterQualityType.Low`

Member kind: field
Symbol: `Autodesk.Revit.DB.RasterQualityType.Low`

#### Summary

The type of Raster Quality is Low.

### `T:Autodesk.Revit.DB.PaperPlacementType`

Member kind: type
Symbol: `Autodesk.Revit.DB.PaperPlacementType`

#### Summary

An enumerated type listing all Paper Placement types of Print Setting.

### `F:Autodesk.Revit.DB.PaperPlacementType.Margins`

Member kind: field
Symbol: `Autodesk.Revit.DB.PaperPlacementType.Margins`

#### Summary

The type of Paper Placement is Margins. It's obsolete, use LowerLeft instead.

### `F:Autodesk.Revit.DB.PaperPlacementType.LowerLeft`

Member kind: field
Symbol: `Autodesk.Revit.DB.PaperPlacementType.LowerLeft`

#### Summary

The type of Paper Placement is LowerLeft.

### `F:Autodesk.Revit.DB.PaperPlacementType.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.PaperPlacementType.Center`

#### Summary

The type of Paper Placement is Center.

### `T:Autodesk.Revit.DB.PageOrientationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.PageOrientationType`

#### Summary

An enumerated type listing all Page Orientation types of Print Setting

### `F:Autodesk.Revit.DB.PageOrientationType.Auto`

Member kind: field
Symbol: `Autodesk.Revit.DB.PageOrientationType.Auto`

#### Summary

Auto Page Orientation

### `F:Autodesk.Revit.DB.PageOrientationType.Landscape`

Member kind: field
Symbol: `Autodesk.Revit.DB.PageOrientationType.Landscape`

#### Summary

The type of Page Orientation is Landscape

### `F:Autodesk.Revit.DB.PageOrientationType.Portrait`

Member kind: field
Symbol: `Autodesk.Revit.DB.PageOrientationType.Portrait`

#### Summary

The type of Page Orientation is Portrait

### `T:Autodesk.Revit.DB.ColorDepthType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ColorDepthType`

#### Summary

An enumerated type listing all Color Depth types of Print Setting.

### `F:Autodesk.Revit.DB.ColorDepthType.Color`

Member kind: field
Symbol: `Autodesk.Revit.DB.ColorDepthType.Color`

#### Summary

The type of Color Depth is Color.

### `F:Autodesk.Revit.DB.ColorDepthType.GrayScale`

Member kind: field
Symbol: `Autodesk.Revit.DB.ColorDepthType.GrayScale`

#### Summary

The type of Color Depth is Gray Scale.

### `F:Autodesk.Revit.DB.ColorDepthType.BlackLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.ColorDepthType.BlackLine`

#### Summary

The type of Color Depth is Black Line.

### `M:Autodesk.Revit.DB.ExportPDFSettings.SetOptions(Autodesk.Revit.DB.PDFExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPDFSettings.SetOptions(Autodesk.Revit.DB.PDFExportOptions)`

#### Summary

Sets options for exporting.

#### Parameter `options`

Other options.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ExportPDFSettings.GetOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPDFSettings.GetOptions`

#### Summary

Gets a copy of options from settings for exporting.
Modification on this options would not change the element.

#### Remarks

Since the `!:PDFExportOptions.FileName` is not serialized, when `!:Combine`
is `true` (which means all the views would be exported into one PDF file, whose
file name is specified by `!:PDFExportOptions.FileName` ), the returned `T:Autodesk.Revit.DB.PDFExportOptions`
would have `!:PDFExportOptions.FileName` as an empty string. The user has to
set the `!:PDFExportOptions.FileName` before calling the `!:Document.Export(string, IList{ElementId}, PDFExportOption)`
API exporting a "combined" PDF file.

#### Returns

The options.

#### Since

2022

### `M:Autodesk.Revit.DB.ExportPDFSettings.GetActivePredefinedSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPDFSettings.GetActivePredefinedSettings(Autodesk.Revit.DB.Document)`

#### Summary

Gets the active settings element in the document.

#### Parameter `document`

The document to find the active settings.

#### Returns

The active settings, or `nullptr` if none.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ExportPDFSettings.FindByName(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPDFSettings.FindByName(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Returns settings element by name.

#### Parameter `document`

The document to find the settings with the specified name.

#### Parameter `name`

Name of the settings to find.

#### Returns

The settings element, or `nullptr` if not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ExportPDFSettings.IsValidName(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPDFSettings.IsValidName(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Returns result that the proposed name is valid and not exist in the specified document.

#### Remarks

Name can't contains following characters, such as { } [ ] | ; < > ? ` ~ \ : \r \n \f \t \v.
Name can't be blank.
If true, the name is valid and not exist in specified document.
If false, the name is not a valid name which means it does not exist in specified document.

#### Parameter `document`

Document to check

#### Parameter `name`

Name to check.

#### Returns

Whether or not the name is valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ExportPDFSettings.ListNames(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPDFSettings.ListNames(Autodesk.Revit.DB.Document)`

#### Summary

Returns all the names of the settings instances in the document.

#### Parameter `document`

Document where the settings to be found.

#### Returns

List of names.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ExportPDFSettings.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.PDFExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportPDFSettings.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.PDFExportOptions)`

#### Summary

Returns an new created ExportPDFSettings element in the document with specified settings.

#### Parameter `document`

Document where the settings will be created.

#### Parameter `name`

Name to the settings.

#### Parameter `options`

The options to be set.

#### Returns

New instance of ExportPDFSettings just created in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string or contains only whitespace.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
Setting name.

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

2022

### `T:Autodesk.Revit.DB.ExportPDFSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportPDFSettings`

#### Summary

Settings for PDF export

#### Since

2022

### `T:Autodesk.Revit.DB.ExportPaperFormat`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportPaperFormat`

#### Summary

Paper formats supported by export

### `F:Autodesk.Revit.DB.ExportPaperFormat.ARCH_E3`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ARCH_E3`

#### Summary

ARCH E3, 27 x 39 in

### `F:Autodesk.Revit.DB.ExportPaperFormat.ARCH_E2`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ARCH_E2`

#### Summary

ARCH E2, 26 x 38 in

### `F:Autodesk.Revit.DB.ExportPaperFormat.ARCH_E1`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ARCH_E1`

#### Summary

ARCH E1, 30 x 42 in

### `F:Autodesk.Revit.DB.ExportPaperFormat.ARCH_E`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ARCH_E`

#### Summary

ARCH E, 36 x 48 in

### `F:Autodesk.Revit.DB.ExportPaperFormat.ARCH_D`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ARCH_D`

#### Summary

ARCH D, 24 x 36 in

### `F:Autodesk.Revit.DB.ExportPaperFormat.ARCH_C`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ARCH_C`

#### Summary

ARCH C, 18 x 24 in

### `F:Autodesk.Revit.DB.ExportPaperFormat.ARCH_B`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ARCH_B`

#### Summary

ARCH B, 12 x 18 in

### `F:Autodesk.Revit.DB.ExportPaperFormat.ARCH_A`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ARCH_A`

#### Summary

ARCH A, 9 x 12 in

### `F:Autodesk.Revit.DB.ExportPaperFormat.ISO_B1`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ISO_B1`

#### Summary

ISO B1, 707 x 1000 mm

### `F:Autodesk.Revit.DB.ExportPaperFormat.ISO_B2`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ISO_B2`

#### Summary

ISO B2, 500 x 707 mm

### `F:Autodesk.Revit.DB.ExportPaperFormat.ISO_B3`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ISO_B3`

#### Summary

ISO B3, 353 x 500 mm

### `F:Autodesk.Revit.DB.ExportPaperFormat.ISO_B4`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ISO_B4`

#### Summary

ISO B4, 250 x 353 mm

### `F:Autodesk.Revit.DB.ExportPaperFormat.ISO_A0`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ISO_A0`

#### Summary

ISO A0, 841 x 1189 mm

### `F:Autodesk.Revit.DB.ExportPaperFormat.ISO_A1`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ISO_A1`

#### Summary

ISO A1, 594 x 841 mm

### `F:Autodesk.Revit.DB.ExportPaperFormat.ISO_A2`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ISO_A2`

#### Summary

ISO A2, 420 x 594 mm

### `F:Autodesk.Revit.DB.ExportPaperFormat.ISO_A3`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ISO_A3`

#### Summary

ISO A3, 297 x 420 mm

### `F:Autodesk.Revit.DB.ExportPaperFormat.ISO_A4`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ISO_A4`

#### Summary

ISO A4, 210 x 297 mm

### `F:Autodesk.Revit.DB.ExportPaperFormat.ANSI_E`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ANSI_E`

#### Summary

ANSI E, 34 x 44 in

### `F:Autodesk.Revit.DB.ExportPaperFormat.ANSI_D`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ANSI_D`

#### Summary

ANSI D, 22 x 34 in

### `F:Autodesk.Revit.DB.ExportPaperFormat.ANSI_C`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ANSI_C`

#### Summary

ANSI C, 17 x 22 in

### `F:Autodesk.Revit.DB.ExportPaperFormat.ANSI_B`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ANSI_B`

#### Summary

ANSI B, 11 x 17 in

### `F:Autodesk.Revit.DB.ExportPaperFormat.ANSI_A`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.ANSI_A`

#### Summary

ANSI A, 8.5 x 11 in

### `F:Autodesk.Revit.DB.ExportPaperFormat.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportPaperFormat.Default`

#### Summary

Default paper format.

#### Remarks

Default size depends on the sheet set going to
be exported. If all sheets are of type DrawingSheet, then
paper sizes are properly adjusted to their respective
content with zoom level set to 100%. If views of type other
than DrawingSheet are in the export set, the default paper
size is UI-Letter and zoom is set to fit-the-page.

### `M:Autodesk.Revit.DB.ExportLineweightTable.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.ExportLineweightTable.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.ExportLineweightTable.GetExportLineweightTableIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.GetExportLineweightTableIterator`

#### Summary

Returns a line weight table iterator to the line weight table.

### `M:Autodesk.Revit.DB.ExportLineweightTable.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.Clear`

#### Summary

Removes all contents stored in Export line weight table.

### `M:Autodesk.Revit.DB.ExportLineweightTable.Remove(Autodesk.Revit.DB.ExportLineweightKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.Remove(Autodesk.Revit.DB.ExportLineweightKey)`

#### Summary

Removes the pair (key, info) corresponding to the given ExportLineweightKey.

#### Parameter `exportLineweightKey`

The export line weight key

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ExportLineweightTable.Add(Autodesk.Revit.DB.ExportLineweightKey,Autodesk.Revit.DB.ExportLineweightInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.Add(Autodesk.Revit.DB.ExportLineweightKey,Autodesk.Revit.DB.ExportLineweightInfo)`

#### Summary

Inserts a (key, info) pair into Export line weight table.

#### Parameter `exportLineweightKey`

The export line weight Key to be added.

#### Parameter `exportLineweightInfo`

The export line weight info to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The key already exists in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ExportLineweightTable.GetValues`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.GetValues`

#### Summary

Returns all the values stored in the map.

#### Returns

The info.

### `M:Autodesk.Revit.DB.ExportLineweightTable.GetKeys`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.GetKeys`

#### Summary

Gets all the keys stored in the map.

#### Returns

The keys.

### `M:Autodesk.Revit.DB.ExportLineweightTable.GetExportLineweightInfo(Autodesk.Revit.DB.ExportLineweightKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.GetExportLineweightInfo(Autodesk.Revit.DB.ExportLineweightKey)`

#### Summary

Gets a copy of the ExportLineweightInfo corresponding to the given ExportLineweightKey.

#### Parameter `exportLineweightKey`

The export line weight Key.

#### Returns

Returns the line weight info for this key.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

An entry with the given key is not present in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ExportLineweightTable.ContainsKey(Autodesk.Revit.DB.ExportLineweightKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.ContainsKey(Autodesk.Revit.DB.ExportLineweightKey)`

#### Summary

Checks whether a line weight key exists in the table.

#### Parameter `exportLineweightKey`

The export line weight key.

#### Returns

True if the line weight exists in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.ExportLineweightTable.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLineweightTable.Count`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.Count`

#### Summary

Count of the items contained in the collection.

### `P:Autodesk.Revit.DB.ExportLineweightTable.default(Autodesk.Revit.DB.ExportLineweightKey)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.default(Autodesk.Revit.DB.ExportLineweightKey)`

#### Summary

A copy of the `T:Autodesk.Revit.DB.ExportLineweightInfo` for the line weight's `T:Autodesk.Revit.DB.ExportLineweightKey` .

#### Remarks

When getting this property, it returns a copy of the `T:Autodesk.Revit.DB.ExportLineweightInfo` from the table. In order to
make changes to the `T:Autodesk.Revit.DB.ExportLineweightInfo` and use those settings during export, set the modified
`T:Autodesk.Revit.DB.ExportLineweightInfo` back into the table using the same key.

#### Parameter `ExportLineweightKey`

The key.

#### Returns

A copy of the `T:Autodesk.Revit.DB.ExportLineweightInfo` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When getting this property:
An entry with the given key is not present in the table.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLineweightTable.GetLineweightTableIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.GetLineweightTableIterator`

#### Summary

Returns a ExportLineweightTableIterator that iterates through the collection.

#### Returns

A ExportLineweightTableIterator object that can be used to iterate through key-value pairs in the collection.

### `M:Autodesk.Revit.DB.ExportLineweightTable.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.#ctor`

#### Summary

Constructs a new ExportLineweightTable with default settings.

### `T:Autodesk.Revit.DB.ExportLineweightTable`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportLineweightTable`

#### Summary

A table supporting a mapping of line weights in Revit to line weight names that will be set
in the target export format.

#### Remarks

This table is structured as a mapping from `T:Autodesk.Revit.DB.ExportLineweightKey` to
`T:Autodesk.Revit.DB.ExportLineweightInfo` members. The `T:Autodesk.Revit.DB.ExportLineweightKey`
contains the identification information for the pattern table: the Revit line weight. The
`T:Autodesk.Revit.DB.ExportLineweightInfo` contains the line weight to use in the export format.

The table can be accessed via direct iteration as a collection of KeyValuePairs, or by traversal of the stored keys
obtained from GetKeys(), or via specific lookup of a key constructed externally. In all cases, the
`T:Autodesk.Revit.DB.ExportLineweightInfo` returned will be a copy of the `T:Autodesk.Revit.DB.ExportLineweightInfo`
from the table. In order to make changes to the `T:Autodesk.Revit.DB.ExportLineweightInfo` and use those settings during export,
set the modified `T:Autodesk.Revit.DB.ExportLineweightInfo` back into the table using the same key.

### `P:Autodesk.Revit.DB.ExportLineweightTableIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLineweightTableIterator.CurrentObject`

### `P:Autodesk.Revit.DB.ExportLineweightTableIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLineweightTableIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.ExportLineweightTableIterator.GetValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTableIterator.GetValue`

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLineweightTableIterator.GetKey`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTableIterator.GetKey`

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLineweightTableIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTableIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLineweightTableIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTableIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLineweightTableIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightTableIterator.MoveNext`

#### Summary

Increments the iterator to the next item.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLineweightTableIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLineweightTableIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ExportLineweightTableIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportLineweightTableIterator`

#### Summary

An iterator to a set of line weight table.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLineweightInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLineweightInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLineweightInfo.DestinationLineweightName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLineweightInfo.DestinationLineweightName`

#### Summary

The destination lineweight name (the name of the line weight in the exported format)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLineweightInfo.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightInfo.#ctor(System.String)`

#### Summary

Constructs a new ExportLineweightInfo using the destination line weight name as input.

#### Parameter `destinationLineweightName`

The destination line weight name (the name of the line weight in the exported format).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLineweightInfo.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightInfo.#ctor`

#### Summary

Constructs a new default ExportLineweightInfo.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLineweightInfo.#ctor(Autodesk.Revit.DB.ExportLineweightInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightInfo.#ctor(Autodesk.Revit.DB.ExportLineweightInfo)`

#### Summary

Constructs a new copy of the input ExportLineweightInfo object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.ExportLineweightInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportLineweightInfo`

#### Summary

A value used to represent the info stored in the `T:Autodesk.Revit.DB.ExportLineweightTable` .

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLineweightKey.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLineweightKey.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLineweightKey.OriginalLineweight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLineweightKey.OriginalLineweight`

#### Summary

The original line weight.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLineweightKey.#ctor(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightKey.#ctor(System.Int32)`

#### Summary

Constructs a new default ExportLineweightKey using the original line weight as input.

#### Parameter `originalLineweight`

The original line weight.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLineweightKey.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightKey.#ctor`

#### Summary

Constructs a new default ExportLineweightKey.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLineweightKey.#ctor(Autodesk.Revit.DB.ExportLineweightKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLineweightKey.#ctor(Autodesk.Revit.DB.ExportLineweightKey)`

#### Summary

Constructs a new copy of the input ExportLineweightKey object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.ExportLineweightKey`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportLineweightKey`

#### Summary

A key used to represent an item stored in an `T:Autodesk.Revit.DB.ExportLineweightTable` .

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLinetypeTable.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.ExportLinetypeTable.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.ExportLinetypeTable.GetExportLinetypeTableIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.GetExportLinetypeTableIterator`

#### Summary

Returns a line type table iterator to the line type table.

### `M:Autodesk.Revit.DB.ExportLinetypeTable.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.Clear`

#### Summary

Removes all contents stored in Export line type table.

### `M:Autodesk.Revit.DB.ExportLinetypeTable.Remove(Autodesk.Revit.DB.ExportLinetypeKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.Remove(Autodesk.Revit.DB.ExportLinetypeKey)`

#### Summary

Removes the pair (key, info) corresponding to the given ExportLinetypeKey.

#### Parameter `exportLinetypeKey`

The export line type key

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ExportLinetypeTable.Add(Autodesk.Revit.DB.ExportLinetypeKey,Autodesk.Revit.DB.ExportLinetypeInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.Add(Autodesk.Revit.DB.ExportLinetypeKey,Autodesk.Revit.DB.ExportLinetypeInfo)`

#### Summary

Inserts a (key, info) pair into Export line type table.

#### Parameter `exportLinetypeKey`

The export line type Key to be added.

#### Parameter `exportLinetypeInfo`

The export line type info to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The key already exists in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ExportLinetypeTable.GetValues`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.GetValues`

#### Summary

Returns all the values stored in the map.

#### Returns

The info.

### `M:Autodesk.Revit.DB.ExportLinetypeTable.GetKeys`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.GetKeys`

#### Summary

Gets all the keys stored in the map.

#### Returns

The keys.

### `M:Autodesk.Revit.DB.ExportLinetypeTable.GetExportLinetypeInfo(Autodesk.Revit.DB.ExportLinetypeKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.GetExportLinetypeInfo(Autodesk.Revit.DB.ExportLinetypeKey)`

#### Summary

Gets a copy of the ExportLinetypeInfo corresponding to the given ExportLinetypeKey.

#### Parameter `exportLinetypeKey`

The export line type Key.

#### Returns

Returns the line type info for this key.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

An entry with the given key is not present in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ExportLinetypeTable.ContainsKey(Autodesk.Revit.DB.ExportLinetypeKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.ContainsKey(Autodesk.Revit.DB.ExportLinetypeKey)`

#### Summary

Checks whether a pattern key exists in the table.

#### Parameter `exportLinetypeKey`

The export line type key.

#### Returns

True if the line type exists in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.ExportLinetypeTable.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLinetypeTable.Count`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.Count`

#### Summary

Count of the items contained in the collection.

### `P:Autodesk.Revit.DB.ExportLinetypeTable.default(Autodesk.Revit.DB.ExportLinetypeKey)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.default(Autodesk.Revit.DB.ExportLinetypeKey)`

#### Summary

A copy of the `T:Autodesk.Revit.DB.ExportLinetypeInfo` for the linetype's `T:Autodesk.Revit.DB.ExportLinetypeKey` .

#### Remarks

When getting this property, it returns a copy of the `T:Autodesk.Revit.DB.ExportLinetypeInfo` from the table. In order to
make changes to the `T:Autodesk.Revit.DB.ExportLinetypeInfo` and use those settings during export, set the modified
`T:Autodesk.Revit.DB.ExportLinetypeInfo` back into the table using the same key.

#### Parameter `exportLinetypeKey`

The key.

#### Returns

A copy of the `T:Autodesk.Revit.DB.ExportLinetypeInfo` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When getting this property:
An entry with the given key is not present in the table.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLinetypeTable.GetLinetypeTableIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.GetLinetypeTableIterator`

#### Summary

Returns a ExportLinetypeTableIterator that iterates through the collection.

#### Returns

A ExportLinetypeTableIterator object that can be used to iterate through key-value pairs in the collection.

### `M:Autodesk.Revit.DB.ExportLinetypeTable.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.#ctor`

#### Summary

Constructs a new ExportLinetypeTable with default values.

### `T:Autodesk.Revit.DB.ExportLinetypeTable`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable`

#### Summary

A table supporting a mapping of linetypes in Revit to linetype names that will be set
in the target export format.

#### Remarks

This table is structured as a mapping from `T:Autodesk.Revit.DB.ExportLinetypeKey` to
`T:Autodesk.Revit.DB.ExportLinetypeInfo` members. The `T:Autodesk.Revit.DB.ExportLinetypeKey`
contains the identification information for the pattern table: the Revit linetype name. The
`T:Autodesk.Revit.DB.ExportLinetypeInfo` contains the linetype name to use in the export format.

The table can be accessed via direct iteration as a collection of KeyValuePairs, or by traversal of the stored keys
obtained from GetKeys(), or via specific lookup of a key constructed externally. In all cases, the
`T:Autodesk.Revit.DB.ExportLinetypeInfo` returned will be a copy of the `T:Autodesk.Revit.DB.ExportLinetypeInfo`
from the table. In order to make changes to the `T:Autodesk.Revit.DB.ExportLinetypeInfo` and use those settings during export,
set the modified `T:Autodesk.Revit.DB.ExportLinetypeInfo` back into the table using the same key.

### `P:Autodesk.Revit.DB.ExportLinetypeTableIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLinetypeTableIterator.CurrentObject`

### `P:Autodesk.Revit.DB.ExportLinetypeTableIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLinetypeTableIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.ExportLinetypeTableIterator.GetValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTableIterator.GetValue`

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLinetypeTableIterator.GetKey`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTableIterator.GetKey`

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLinetypeTableIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTableIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLinetypeTableIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTableIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLinetypeTableIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeTableIterator.MoveNext`

#### Summary

Increments the iterator to the next item.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLinetypeTableIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLinetypeTableIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ExportLinetypeTableIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportLinetypeTableIterator`

#### Summary

An iterator to a set of line type table.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLinetypeInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLinetypeInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLinetypeInfo.DestinationLinetypeName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLinetypeInfo.DestinationLinetypeName`

#### Summary

The destination linetype name (the name of the linetype in the exported format).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLinetypeInfo.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeInfo.#ctor(System.String)`

#### Summary

Constructs a new ExportLinetypeInfo using the destination linetype name as input.

#### Parameter `destinationLinetypeName`

The destination line type name (the name of the linetype in the exported format).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLinetypeInfo.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeInfo.#ctor`

#### Summary

Constructs a new default ExportLinetypeInfo.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLinetypeInfo.#ctor(Autodesk.Revit.DB.ExportLinetypeInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeInfo.#ctor(Autodesk.Revit.DB.ExportLinetypeInfo)`

#### Summary

Constructs a new copy of the input ExportLinetypeInfo object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.ExportLinetypeInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportLinetypeInfo`

#### Summary

A value used to represent the info stored in the `T:Autodesk.Revit.DB.ExportLinetypeTable` .

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLinetypeKey.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLinetypeKey.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLinetypeKey.OriginalLinetypeName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLinetypeKey.OriginalLinetypeName`

#### Summary

The original linetype name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLinetypeKey.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeKey.#ctor(System.String)`

#### Summary

Constructs a new default ExportLinetypeKey using the original line type name as input.

#### Parameter `originalLinetypeName`

The original line type name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLinetypeKey.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeKey.#ctor`

#### Summary

Constructs a new default ExportLinetypeKey.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLinetypeKey.#ctor(Autodesk.Revit.DB.ExportLinetypeKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLinetypeKey.#ctor(Autodesk.Revit.DB.ExportLinetypeKey)`

#### Summary

Constructs a new copy of the input ExportLinetypeKey object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.ExportLinetypeKey`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportLinetypeKey`

#### Summary

A key used to represent an item stored in an `T:Autodesk.Revit.DB.ExportLinetypeTable` .

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTable.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTable.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.ExportLayerTable.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTable.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.ExportLayerTable.GetExportLayerTableIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTable.GetExportLayerTableIterator`

#### Summary

Returns a LayerTableIterator to the pattern table.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTable.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTable.Clear`

#### Summary

Removes all contents stored in the table.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTable.Remove(Autodesk.Revit.DB.ExportLayerKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTable.Remove(Autodesk.Revit.DB.ExportLayerKey)`

#### Summary

Removes the pair (key, info) by pattern key.

#### Parameter `exportLayerKey`

The export pattern key.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTable.Add(Autodesk.Revit.DB.ExportLayerKey,Autodesk.Revit.DB.ExportLayerInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTable.Add(Autodesk.Revit.DB.ExportLayerKey,Autodesk.Revit.DB.ExportLayerInfo)`

#### Summary

Inserts a (key,info) pair into Export layer table.

#### Parameter `exportLayerKey`

The export layer key to be added.

#### Parameter `exportLayerInfo`

The export layer info to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The key already exists in the table.
-or-
The layer info does not contain the Category as a modifier type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTable.GetValues`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTable.GetValues`

#### Summary

Returns all the values stored in the map.

#### Returns

Return the info array.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTable.GetKeys`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTable.GetKeys`

#### Summary

Gets all the keys stored in the map.

#### Returns

Return the key array.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTable.GetExportLayerInfo(Autodesk.Revit.DB.ExportLayerKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTable.GetExportLayerInfo(Autodesk.Revit.DB.ExportLayerKey)`

#### Summary

Gets a copy of the layer info associated to the input pattern key.

#### Parameter `exportLayerKey`

The export layer Key.

#### Returns

Return the layerInfo for this key.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

An entry with the given key is not present in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTable.ContainsKey(Autodesk.Revit.DB.ExportLayerKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTable.ContainsKey(Autodesk.Revit.DB.ExportLayerKey)`

#### Summary

Checks whether a layer key exists in the table.

#### Parameter `exportlayerKey`

The export layer Key.

#### Returns

True if the layer key exists in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerTable.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerTable.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerTable.Count`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerTable.Count`

#### Summary

Count of the items contained in the collection.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTable.GetAvaliableLayerModifierTypes(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExportLayerKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTable.GetAvaliableLayerModifierTypes(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExportLayerKey)`

#### Summary

Gets all the avaliable layer modifier types for the layer key.

#### Parameter `document`

A Revit document to retrieve avaliable layer modifier types from.

#### Parameter `exportLayerKey`

The export layer key to specify wich category and subCategory will be used to get the layer modifier types.

#### Returns

The layer modifier types.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerTable.default(Autodesk.Revit.DB.ExportLayerKey)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerTable.default(Autodesk.Revit.DB.ExportLayerKey)`

#### Summary

A copy of the `T:Autodesk.Revit.DB.ExportLayerInfo` item that corresponds to the layer's
`T:Autodesk.Revit.DB.ExportLayerKey` .

#### Remarks

When getting this property, it returns a copy of the `T:Autodesk.Revit.DB.ExportLayerInfo` from the table. In order to
make changes to the `T:Autodesk.Revit.DB.ExportLayerInfo` and use those settings during export, set the modified
`T:Autodesk.Revit.DB.ExportLayerInfo` back into the table using the same key.

#### Parameter `ExportLayerKey`

The key.

#### Returns

A copy of the `T:Autodesk.Revit.DB.ExportLayerInfo` for the layer Key.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When getting this property:
An entry with the given key is not present in the table.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTable.GetLayerTableIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTable.GetLayerTableIterator`

#### Summary

Returns a LayerTableIterator that iterates through the collection.

#### Returns

A LayerTableIterator object that can be used to iterate through key-value pairs in the collection.

### `M:Autodesk.Revit.DB.ExportLayerTable.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTable.#ctor`

#### Summary

Constructs a new ExportLayerTable with default values.

#### Since

2014

### `T:Autodesk.Revit.DB.ExportLayerTable`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportLayerTable`

#### Summary

A table supporting a mapping of category and subcategory to layer name and other layer properties that will be set
in the target export format.

#### Remarks

This table is structured as a mapping from `T:Autodesk.Revit.DB.ExportLayerKey` to
`T:Autodesk.Revit.DB.ExportLayerInfo` members. The `T:Autodesk.Revit.DB.ExportLayerKey`
contains the identification information for the layer table: the Revit category and subcategory names. In addition,
the key contains a `T:Autodesk.Revit.DB.SpecialType` member used only to represent non-Revit categories
that can be assigned specific layer information on export. The `T:Autodesk.Revit.DB.ExportLayerInfo`
contains the exported layer name, color name, and layer modifiers for standard and cut representations.

The table can be accessed via direct iteration as a collection of KeyValuePairs, or by traversal of the stored keys
obtained from GetKeys(), or via specific lookup of a key constructed externally. In all cases, the
`T:Autodesk.Revit.DB.ExportLayerInfo` returned will be a copy of the `T:Autodesk.Revit.DB.ExportLayerInfo`
from the table. In order to make changes to the `T:Autodesk.Revit.DB.ExportLayerInfo` and use those settings during export,
set the modified `T:Autodesk.Revit.DB.ExportLayerInfo` back into the table using the same key.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerTableIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerTableIterator.CurrentObject`

### `P:Autodesk.Revit.DB.ExportLayerTableIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerTableIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.ExportLayerTableIterator.GetValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTableIterator.GetValue`

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTableIterator.GetKey`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTableIterator.GetKey`

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTableIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTableIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTableIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTableIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerTableIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerTableIterator.MoveNext`

#### Summary

Increments the iterator to the next item.

#### Returns

True if there is a next available item in this iterator.
False if the iterator has completed all available items.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerTableIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerTableIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ExportLayerTableIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportLayerTableIterator`

#### Summary

An iterator to a set of Layer table.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerInfo.SetCutLayerModifiers(System.Collections.Generic.IList{Autodesk.Revit.DB.LayerModifier})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.SetCutLayerModifiers(System.Collections.Generic.IList{Autodesk.Revit.DB.LayerModifier})`

#### Summary

Sets a cut layer modifier array to the layer info.

#### Parameter `cutLayermodifiers`

The cut layer modifier array.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerInfo.SetLayerModifiers(System.Collections.Generic.IList{Autodesk.Revit.DB.LayerModifier})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.SetLayerModifiers(System.Collections.Generic.IList{Autodesk.Revit.DB.LayerModifier})`

#### Summary

Sets a project layer modifier array to the layer info.

#### Parameter `layermodifiers`

The project layer modifier array.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerInfo.GetCutLayerModifiers`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.GetCutLayerModifiers`

#### Summary

Gets all the cut layer modifiers from the layer info.

#### Returns

The cut layer modifier array.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerInfo.GetLayerModifiers`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.GetLayerModifiers`

#### Summary

Gets all the project layer modifiers from the layer info.

#### Returns

The project layer modifier array.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerInfo.ClearCutLayerModifiers`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.ClearCutLayerModifiers`

#### Summary

Clears all the cut layer modifiers stored in the layer info.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerInfo.ClearLayerModifiers`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.ClearLayerModifiers`

#### Summary

Clears all the project layer modifiers stored in the layer info.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerInfo.RemoveCutLayerModifier(Autodesk.Revit.DB.LayerModifier)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.RemoveCutLayerModifier(Autodesk.Revit.DB.LayerModifier)`

#### Summary

Removes a cut layer modifier from the layer info.

#### Parameter `layerModifier`

The cut layer modifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerInfo.RemoveLayerModifier(Autodesk.Revit.DB.LayerModifier)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.RemoveLayerModifier(Autodesk.Revit.DB.LayerModifier)`

#### Summary

Removes a project layer modifier from the layer info.

#### Parameter `layerModifier`

The project layer modifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerInfo.AddCutLayerModifier(Autodesk.Revit.DB.LayerModifier)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.AddCutLayerModifier(Autodesk.Revit.DB.LayerModifier)`

#### Summary

Adds a cut layer modifier to the layer info.

#### Parameter `layerModifier`

The cut layer modifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The separator string contains one or more prohibited characters.
-or-
The modifier type already exists in the cut layer info.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerInfo.AddLayerModifier(Autodesk.Revit.DB.LayerModifier)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.AddLayerModifier(Autodesk.Revit.DB.LayerModifier)`

#### Summary

Adds a project layer modifier to the layer info.

#### Parameter `layerModifier`

The project layer modifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The separator string contains one or more prohibited characters.
-or-
The modifier type already exists in the layer info.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerInfo.CutColorNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.CutColorNumber`

#### Summary

The cut color number stored in value.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerInfo.ColorNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.ColorNumber`

#### Summary

The color number stored in value.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerInfo.CutLayerName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.CutLayerName`

#### Summary

The cut layer name stored in value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerInfo.LayerName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.LayerName`

#### Summary

The layer name stored in value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerInfo.ColorName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.ColorName`

#### Summary

The color name stored in value.
For IFC export, the naming is to match the "colornumber" setting -- really, this stores a string
that generates the colorNumber (for formats that don't use the color but need a second entry.)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerInfo.CategoryType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.CategoryType`

#### Summary

The category type which this layer belongs to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerInfo.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerInfo.#ctor`

#### Summary

Constructs a new ExportLayerInfo with default values.

#### Since

2014

### `T:Autodesk.Revit.DB.ExportLayerInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportLayerInfo`

#### Summary

A value used to represent the info stored in the `T:Autodesk.Revit.DB.ExportLayerTable` .

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerKey.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerKey.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerKey.SpecialType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerKey.SpecialType`

#### Summary

The special type for layer key.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerKey.SubCategoryName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerKey.SubCategoryName`

#### Summary

The subcategrory Name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerKey.CategoryName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerKey.CategoryName`

#### Summary

The category name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerKey.#ctor(System.String,System.String,Autodesk.Revit.DB.SpecialType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerKey.#ctor(System.String,System.String,Autodesk.Revit.DB.SpecialType)`

#### Summary

Constructs a new ExportLayerKey with categoryName, subCategoryName and a special type.

#### Parameter `categoryName`

The category name for the layer key.

#### Parameter `subCategoryName`

The subCategoryName for the layer key.

#### Parameter `num`

The special type for layer key.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.ExportLayerKey.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportLayerKey.#ctor`

#### Summary

Constructs a new ExportLayerKey with default values.

#### Since

2014

### `T:Autodesk.Revit.DB.ExportLayerKey`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportLayerKey`

#### Summary

A key used to represent an item stored in an `T:Autodesk.Revit.DB.ExportLayerTable` .

#### Since

2014

### `P:Autodesk.Revit.DB.LayerModifier.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.LayerModifier.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.LayerModifier.ModifierType`

Member kind: property
Symbol: `Autodesk.Revit.DB.LayerModifier.ModifierType`

#### Summary

The modifier type of LayerModifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.LayerModifier.Separator`

Member kind: property
Symbol: `Autodesk.Revit.DB.LayerModifier.Separator`

#### Summary

The separator string that will follow this modifier in the export layer name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.LayerModifier.#ctor(Autodesk.Revit.DB.ModifierType,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LayerModifier.#ctor(Autodesk.Revit.DB.ModifierType,System.String)`

#### Summary

Constructs a new LayerModifier with modifierType and separator.

#### Parameter `modifierType`

The modifier type.

#### Parameter `separator`

The separator string that will follow this modifier in the export layer name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The provided separator contains invalid characters (most special characters are invalid).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.LayerModifier.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.LayerModifier.#ctor`

#### Summary

Constructs a new LayerModifier with default values.

#### Since

2014

### `T:Autodesk.Revit.DB.LayerModifier`

Member kind: type
Symbol: `Autodesk.Revit.DB.LayerModifier`

#### Summary

A modifier used to designate extra strings to appear in the exported layer name.

#### Remarks

A modifier consists of a type (from `T:Autodesk.Revit.DB.ModifierType` and an optional separator.
Apply a modifier to one or more `T:Autodesk.Revit.DB.ExportLayerInfo` objects to modify the layer name that
will be assigned when a Revit object is exported.

#### Since

2014

### `T:Autodesk.Revit.DB.LayerCategoryType`

Member kind: type
Symbol: `Autodesk.Revit.DB.LayerCategoryType`

#### Since

2014

#### Summary

An enumerated type listing category types supported in an ExportLayerTable.

#### Since

2014

### `F:Autodesk.Revit.DB.LayerCategoryType.Modifier`

Member kind: field
Symbol: `Autodesk.Revit.DB.LayerCategoryType.Modifier`

#### Summary

A special value related to modifiers.

### `F:Autodesk.Revit.DB.LayerCategoryType.Imported`

Member kind: field
Symbol: `Autodesk.Revit.DB.LayerCategoryType.Imported`

#### Summary

Imported categories.

### `F:Autodesk.Revit.DB.LayerCategoryType.AnalyticalModel`

Member kind: field
Symbol: `Autodesk.Revit.DB.LayerCategoryType.AnalyticalModel`

#### Summary

AnalyticalModel categories.

### `F:Autodesk.Revit.DB.LayerCategoryType.Annotation`

Member kind: field
Symbol: `Autodesk.Revit.DB.LayerCategoryType.Annotation`

#### Summary

Annotation categories.

### `F:Autodesk.Revit.DB.LayerCategoryType.Model`

Member kind: field
Symbol: `Autodesk.Revit.DB.LayerCategoryType.Model`

#### Summary

Model categories.

### `F:Autodesk.Revit.DB.LayerCategoryType.Unsorted`

Member kind: field
Symbol: `Autodesk.Revit.DB.LayerCategoryType.Unsorted`

#### Summary

A default unsorted type.

### `T:Autodesk.Revit.DB.SpecialType`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpecialType`

#### Since

2014

#### Summary

An enumerated type listing special types that can appear in an `T:Autodesk.Revit.DB.ExportLayerTable` .
These types do not represent an independent category in Revit, but can be mapped to specific layers on export.

#### Since

2014

### `F:Autodesk.Revit.DB.SpecialType.RetainingWall`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpecialType.RetainingWall`

#### Summary

The special type representing retaining walls.

### `F:Autodesk.Revit.DB.SpecialType.FoundationWall`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpecialType.FoundationWall`

#### Summary

The special type representing foundation walls.

### `F:Autodesk.Revit.DB.SpecialType.ExteriorWall`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpecialType.ExteriorWall`

#### Summary

The special type representing exterior walls.

### `F:Autodesk.Revit.DB.SpecialType.InteriorWall`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpecialType.InteriorWall`

#### Summary

The special type representing interior walls.

### `F:Autodesk.Revit.DB.SpecialType.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpecialType.Default`

#### Summary

The default value for most Revit categories and subcategories.

### `T:Autodesk.Revit.DB.ModifierType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModifierType`

#### Since

2014

#### Summary

An enumerated type listing options to appear in the exported layer name.

#### Since

2014

### `F:Autodesk.Revit.DB.ModifierType.FabricationService`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.FabricationService`

#### Summary

Signals that the fabrication service will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.DomainType`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.DomainType`

#### Summary

Signals that the domain type will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.SystemClassification`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.SystemClassification`

#### Summary

Signals that the system classification will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.AnalyzesAs`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.AnalyzesAs`

#### Summary

Signals that the value of the AnalyzesAs parameter will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.Workset`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.Workset`

#### Summary

Signals that the name of the workset will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.ViewType`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.ViewType`

#### Summary

Signals that the view type will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.Underlay`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.Underlay`

#### Summary

Signals that the name of the underlay will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.SystemType`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.SystemType`

#### Summary

Signals that the system type will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.SystemName`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.SystemName`

#### Summary

Signals that the system name will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.StructuralUsage`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.StructuralUsage`

#### Summary

Signals that the value of structural usage will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.StructuralMaterialType`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.StructuralMaterialType`

#### Summary

Signals that the value of structural material type will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.PhaseStatus`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.PhaseStatus`

#### Summary

Signals that the value of of phase status will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.PhaseDemolished`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.PhaseDemolished`

#### Summary

Signals that the name of the demolition phase will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.PhaseCreated`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.PhaseCreated`

#### Summary

Signals that the name of the created phase will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.Level`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.Level`

#### Summary

Signals that the name of the level will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.Function`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.Function`

#### Summary

Signals that the value of function will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.FireRating`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.FireRating`

#### Summary

Signals that the value of fire rating will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.Custom3`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.Custom3`

#### Summary

Signals that the third custom string will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.Custom2`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.Custom2`

#### Summary

Signals that the second custom string will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.Custom1`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.Custom1`

#### Summary

Signals that the first custom string will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.Category`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.Category`

#### Summary

Signals that the name of the category will appear in the layer name.

### `F:Autodesk.Revit.DB.ModifierType.UnknownType`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModifierType.UnknownType`

#### Summary

An unknown (default) type of modifier, not acceptable for assignment.

### `M:Autodesk.Revit.DB.ExportFontTable.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTable.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.ExportFontTable.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTable.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.ExportFontTable.GetExportFontTableIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTable.GetExportFontTableIterator`

#### Summary

Returns a FontTableIterator to the font table.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontTable.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTable.Clear`

#### Summary

Removes all contents stored in the table.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontTable.Remove(Autodesk.Revit.DB.ExportFontKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTable.Remove(Autodesk.Revit.DB.ExportFontKey)`

#### Summary

Removes the pair (key, info) by font key.

#### Parameter `exportFontKey`

The export font key.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontTable.Add(Autodesk.Revit.DB.ExportFontKey,Autodesk.Revit.DB.ExportFontInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTable.Add(Autodesk.Revit.DB.ExportFontKey,Autodesk.Revit.DB.ExportFontInfo)`

#### Summary

Inserts a (key,info) pair into Export font table.

#### Parameter `exportFontKey`

The export font key to be added.

#### Parameter `exportFontInfo`

The export font info to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The key already exists in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontTable.GetValues`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTable.GetValues`

#### Summary

Returns a collection of the values stored in this table.

#### Returns

The collection of values.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontTable.GetKeys`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTable.GetKeys`

#### Summary

Returns a collection of the keys stored in this table.

#### Returns

The collection of keys.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontTable.GetExportFontInfo(Autodesk.Revit.DB.ExportFontKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTable.GetExportFontInfo(Autodesk.Revit.DB.ExportFontKey)`

#### Summary

Gets a copy of the font info associated to the input font key.

#### Parameter `exportFontKey`

The export font Key.

#### Returns

Returns the fontInfo for this key.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

An entry with the given key is not present in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontTable.ContainsKey(Autodesk.Revit.DB.ExportFontKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTable.ContainsKey(Autodesk.Revit.DB.ExportFontKey)`

#### Summary

Checks whether a font key exists in the table.

#### Parameter `exportfontKey`

The export font Key.

#### Returns

True if the font key exists in the table.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.ExportFontTable.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportFontTable.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportFontTable.Count`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportFontTable.Count`

#### Summary

Count of the items contained in the collection.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportFontTable.default(Autodesk.Revit.DB.ExportFontKey)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportFontTable.default(Autodesk.Revit.DB.ExportFontKey)`

#### Summary

A copy of the `T:Autodesk.Revit.DB.ExportFontInfo` for the font's `T:Autodesk.Revit.DB.ExportFontKey` .

#### Remarks

When getting this property, it returns a copy of the `T:Autodesk.Revit.DB.ExportFontInfo` from the table. In order to
make changes to the `T:Autodesk.Revit.DB.ExportFontInfo` and use those settings during export, set the modified
`T:Autodesk.Revit.DB.ExportFontInfo` back into the table using the same key.

#### Parameter `exportPatternKey`

The key.

#### Returns

A copy of the `T:Autodesk.Revit.DB.ExportFontInfo` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When getting this property:
An entry with the given key is not present in the table.

#### Since

2014
