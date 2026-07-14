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
Shard: 15
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `T:Autodesk.Revit.DB.ParameterDownloadOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ParameterDownloadOptions`

#### Summary

An option class used for downloading parameters from the Parameters Service.

#### Since

2024

### `M:Autodesk.Revit.DB.IForgeSchemaServerProxy.GetAccountDetails(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IForgeSchemaServerProxy.GetAccountDetails(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Returns details about the account that owns the given parameter schema identifier.

### `M:Autodesk.Revit.DB.IForgeSchemaServerProxy.GetBindings(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IForgeSchemaServerProxy.GetBindings(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Returns the category bindings, group bindings, and visibility assigned to the given parameter schema.

### `M:Autodesk.Revit.DB.IForgeSchemaServerProxy.GetSchema(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IForgeSchemaServerProxy.GetSchema(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Returns the requested schema as a JSON string.

### `M:Autodesk.Revit.DB.IForgeSchemaServer.GetAccountDetails(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IForgeSchemaServer.GetAccountDetails(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Returns details about the account that owns the given parameter schema identifier.

### `M:Autodesk.Revit.DB.IForgeSchemaServer.GetBindings(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IForgeSchemaServer.GetBindings(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Returns the category bindings, group bindings, and visibility assigned to the given parameter schema.

### `M:Autodesk.Revit.DB.IForgeSchemaServer.GetSchema(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IForgeSchemaServer.GetSchema(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Returns the requested schema as a JSON string.

### `T:Autodesk.Revit.DB.IForgeSchemaServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.IForgeSchemaServer`

#### Summary

The external server interface for interacting with the Forge Schema Service.

### `P:Autodesk.Revit.DB.AccountDownloadResult.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.AccountDownloadResult.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.AccountDownloadResult.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AccountDownloadResult.#ctor(System.String)`

#### Summary

Indicates that the requested account details were downloaded successfully.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.AccountDownloadResult.#ctor(Autodesk.Revit.DB.ParameterDownloadStatus,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AccountDownloadResult.#ctor(Autodesk.Revit.DB.ParameterDownloadStatus,System.String)`

#### Summary

Indicates an unsuccessful download.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `T:Autodesk.Revit.DB.AccountDownloadResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.AccountDownloadResult`

#### Summary

Indicates the result of attempting to retrieve account details.

### `P:Autodesk.Revit.DB.BindingsDownloadResult.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BindingsDownloadResult.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.BindingsDownloadResult.#ctor(Autodesk.Revit.DB.ParameterDownloadOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BindingsDownloadResult.#ctor(Autodesk.Revit.DB.ParameterDownloadOptions)`

#### Summary

Indicates that the requested bindings were downloaded successfully.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.BindingsDownloadResult.#ctor(Autodesk.Revit.DB.ParameterDownloadStatus,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BindingsDownloadResult.#ctor(Autodesk.Revit.DB.ParameterDownloadStatus,System.String)`

#### Summary

Indicates an unsuccessful download.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `T:Autodesk.Revit.DB.BindingsDownloadResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.BindingsDownloadResult`

#### Summary

Indicates the result of attempting to retrieve parameter bindings.

### `P:Autodesk.Revit.DB.SchemaDownloadResult.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SchemaDownloadResult.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.SchemaDownloadResult.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SchemaDownloadResult.#ctor(System.String)`

#### Summary

Indicates that the given schema was downloaded successfully.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.SchemaDownloadResult.#ctor(Autodesk.Revit.DB.ParameterDownloadStatus)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SchemaDownloadResult.#ctor(Autodesk.Revit.DB.ParameterDownloadStatus)`

#### Summary

Indicates an unsuccessful download.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `T:Autodesk.Revit.DB.SchemaDownloadResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.SchemaDownloadResult`

#### Summary

Indicates the result of an attempt to download a schema.

### `T:Autodesk.Revit.DB.ParameterDownloadStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.ParameterDownloadStatus`

#### Summary

Status codes for parameter download scenarios.

### `M:Autodesk.Revit.DB.IFCExportOptions.AddOption(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFCExportOptions.AddOption(System.String,System.String)`

#### Summary

Adds a new named option to the options structure.

#### Remarks

Named options can be used to set options not accessible through the standard IFC export user interface.
It is up to the implementation of the IExporterIFC interface to customize export behavior based on these options.

#### Parameter `name`

The option name.

#### Parameter `value`

The option value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.IFCExportOptions.Assign(Autodesk.Revit.DB.IFCExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFCExportOptions.Assign(Autodesk.Revit.DB.IFCExportOptions)`

#### Summary

Assigns the values of the IFCExportOptions to this options object.

#### Parameter `sourceOptions`

The source IFCExportOptions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.IFCExportOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFCExportOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.IFCExportOptions.FilterViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFCExportOptions.FilterViewId`

#### Summary

Id of the view whose visibility settings will govern the contents in the exported IFC file.

#### Value

This should be set to the id of the view, or InvalidElementId if there is to be no special filtering applied (all model elements
will be exported). Default is InvalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.IFCExportOptions.SpaceBoundaryLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFCExportOptions.SpaceBoundaryLevel`

#### Summary

Level of space boundaries exported in IFC file.

#### Remarks

There are three valid values for this integer:
0 = export no space boundaries. This can save space if the receiving application doesn't use them.
1 = export 1st level space boundaries. This is the default.
2 = export 2nd level space boundaries. This is primarily for use in energy analysis programs, and the GSA.
Default is 1.

#### Since

2011

### `P:Autodesk.Revit.DB.IFCExportOptions.FamilyMappingFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFCExportOptions.FamilyMappingFile`

#### Summary

Path to a file containing family mapping.

#### Remarks

The file, if specified, contains data describing how to map
generic family instances to IFC containers (element types). This property
may be empty, in which case the current mapping will be used.
The default is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.IFCExportOptions.ExportBaseQuantities`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFCExportOptions.ExportBaseQuantities`

#### Summary

Option to export IFC standard quantities currently supported by Revit.

#### Remarks

IFC has created a list of common quantities (e.g. length, area, volume, etc.)
that can optionally be exported along with the 3D representation for many element
types (e.g. walls, columns, doors). Setting this option to true will cause the export
procedure to include the set of IFC quantities that Revit currently supports.
Default is false.

#### Since

2011

### `P:Autodesk.Revit.DB.IFCExportOptions.WallAndColumnSplitting`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFCExportOptions.WallAndColumnSplitting`

#### Summary

Option to allow division of multi-level walls and columns by levels.

#### Remarks

This option will always be considered true when FileVersion is IFC-BCA.
For other File Versions, default is false.

#### Since

2011

### `P:Autodesk.Revit.DB.IFCExportOptions.FileVersion`

Member kind: property
Symbol: `Autodesk.Revit.DB.IFCExportOptions.FileVersion`

#### Summary

IFC file version.

#### Remarks

Default is IFCVersion.Default.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.IFCExportOptions.#ctor(Autodesk.Revit.DB.IFCExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFCExportOptions.#ctor(Autodesk.Revit.DB.IFCExportOptions)`

#### Summary

Creates a copy of an IFCExportOptions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.IFCExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.IFCExportOptions.#ctor`

#### Summary

Default constructor. Initializes FileVersion to Default.
WallAndColumnSplitting and ExportBaseQuantities are set to false.
FamilyMappingFile is set to empty.

#### Since

2011

### `T:Autodesk.Revit.DB.IFCExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.IFCExportOptions`

#### Summary

IFC Export options.

#### Since

2011

### `T:Autodesk.Revit.DB.IFCVersion`

Member kind: type
Symbol: `Autodesk.Revit.DB.IFCVersion`

#### Summary

An enumerated type listing available IFC file versions into which a file may be exported.

### `F:Autodesk.Revit.DB.IFCVersion.IFCSG`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCVersion.IFCSG`

#### Summary

IFC-SG MVD based on IFC4

### `F:Autodesk.Revit.DB.IFCVersion.IFC4x3`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCVersion.IFC4x3`

#### Summary

IFC4x3 file format

### `F:Autodesk.Revit.DB.IFCVersion.IFC2x3BFM`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCVersion.IFC2x3BFM`

#### Summary

IFC2x3 Basic FM Handover View

### `F:Autodesk.Revit.DB.IFCVersion.IFC4DTV`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCVersion.IFC4DTV`

#### Summary

IFC4 Design Transfer View

### `F:Autodesk.Revit.DB.IFCVersion.IFC4RV`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCVersion.IFC4RV`

#### Summary

IFC4 Reference View

### `F:Autodesk.Revit.DB.IFCVersion.IFC2x3FM`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCVersion.IFC2x3FM`

#### Summary

IFC2x3 Extended FM Handover View

### `F:Autodesk.Revit.DB.IFCVersion.IFC4`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCVersion.IFC4`

#### Summary

IFC 4 file format.

### `F:Autodesk.Revit.DB.IFCVersion.IFCCOBIE`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCVersion.IFCCOBIE`

#### Summary

IFC GSA COBIE 2010 file format. This is a variant of IFC 2x3 used for
submitting files that are COBIE 2010-complaint.

### `F:Autodesk.Revit.DB.IFCVersion.IFC2x3CV2`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCVersion.IFC2x3CV2`

#### Summary

IFC 2x3 Coordination View 2.0 file format. This is a variant of IFC 2x3 used for
exporting files using the Coordination View 2.0 model view.

### `F:Autodesk.Revit.DB.IFCVersion.IFCBCA`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCVersion.IFCBCA`

#### Summary

IFC BCA file format. This is a certified variant of IFC 2x2 used for
submitting files to the Singapore BCA ePlan Check Server.

### `F:Autodesk.Revit.DB.IFCVersion.IFC2x3`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCVersion.IFC2x3`

#### Summary

IFC 2x3 file format.

### `F:Autodesk.Revit.DB.IFCVersion.IFC2x2`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCVersion.IFC2x2`

#### Summary

IFC 2x2 file format.

### `F:Autodesk.Revit.DB.IFCVersion.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCVersion.Default`

#### Summary

The Autodesk Revit application's default export format. Note that this may change
as the defaults change in the Revit user interface.

### `T:Autodesk.Revit.DB.IFCExportElementType`

Member kind: type
Symbol: `Autodesk.Revit.DB.IFCExportElementType`

#### Summary

An enumerated type defining if an element type is exported to IFC or not.

### `F:Autodesk.Revit.DB.IFCExportElementType.No`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCExportElementType.No`

#### Summary

Don't export element type to IFC regardless of category or Revit element settings.

### `F:Autodesk.Revit.DB.IFCExportElementType.Yes`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCExportElementType.Yes`

#### Summary

Export element type to IFC regardless of category or Revit element settings.

### `F:Autodesk.Revit.DB.IFCExportElementType.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCExportElementType.Default`

#### Summary

Export element type to IFC according to category or Revit element settings.

### `T:Autodesk.Revit.DB.IFCExportElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.IFCExportElement`

#### Summary

An enumerated type defining if an element is exported to IFC or not.

### `F:Autodesk.Revit.DB.IFCExportElement.No`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCExportElement.No`

#### Summary

Don't export element to IFC regardless of type or category settings.

### `F:Autodesk.Revit.DB.IFCExportElement.Yes`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCExportElement.Yes`

#### Summary

Export element to IFC regardless of type or category settings.

### `F:Autodesk.Revit.DB.IFCExportElement.ByType`

Member kind: field
Symbol: `Autodesk.Revit.DB.IFCExportElement.ByType`

#### Summary

Export element to IFC according to type settings.

### `M:Autodesk.Revit.DB.IExternalResourceServerInternalProxy.RootBelongsToServer(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternalProxy.RootBelongsToServer(System.String)`

#### Summary

Returns true if the path root belongs to the server.

#### Parameter `rootName`

The path root to be tested.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternalProxy.HasCustomServerNameForSessionPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternalProxy.HasCustomServerNameForSessionPath`

#### Summary

Implement this method to specify if the server has custom server name for session path (something other than GetShortName()).

#### Remarks

Return true if the server name specified in GetInSessionPath() is different from GetShortName().

#### Returns

Return true if the server name specified in GetInSessionPath() is different from GetShortName().

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternalProxy.SupportBatchLoad`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternalProxy.SupportBatchLoad`

#### Summary

Implement this method to indicate whether this sever can do a batch load for multiple resources.

#### Remarks

Some external servers, e.g. AutodeskDrive Server, can do a batch load for multiple resources.

#### Returns

True if this sever can do a batch load for multiple resources.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternalProxy.PreProcessResources(System.Collections.Generic.IList{Autodesk.Revit.DB.ExternalResourceLoadData})`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternalProxy.PreProcessResources(System.Collections.Generic.IList{Autodesk.Revit.DB.ExternalResourceLoadData})`

#### Summary

Pre-processes resources by the server which will downloads the files from A360, if necessary.

#### Parameter `loadData`

The data returned by the server as a result of this load operation.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternalProxy.GetCacheRoot`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternalProxy.GetCacheRoot`

#### Summary

Get the root location for locally cached files used
by this server.
Return "" if there is no local cache or if there is no
one root location.

#### Returns

The local cache root for this server, or the empty
string if there is no local cache.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternalProxy.IsHiddenInUI`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternalProxy.IsHiddenInUI`

#### Summary

Implement this method to indicate whether this sever is hidden in the user interface,
e.g. through External Resource icon.

#### Returns

True if this sever is hidden in the user interface; false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternalProxy.GetUpdatedResourceDataForWorksharing(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternalProxy.GetUpdatedResourceDataForWorksharing(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Implement this method to update the resource when attempting to save to workshared file.

#### Remarks

Will be called when attempting to save to workshared file only if `!:resourceNeedsUpdateForWorksharing()` returned true.

#### Parameter `resource`

The resource to update.

#### Returns

Updated resource or failure definition id.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternalProxy.ResourceNeedsUpdateForWorksharing(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternalProxy.ResourceNeedsUpdateForWorksharing(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Implement this method to indicate whether a given resource needs an update to be shared by multiple users.

#### Remarks

If true `!:updateResourceForWorksharing()` will be called.

#### Parameter `resource`

The resource to check.

#### Returns

True if the resource needs to be updated for worksharing.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternalProxy.GetFullPathFromJournalPath(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternalProxy.GetFullPathFromJournalPath(System.String)`

#### Summary

Implement this method to convert a given URI path (if applicable) to the cache path on disk.

#### Remarks

This function is called for the case only a URI path is known.

#### Parameter `displayPath`

The URI path to the resource.

#### Returns

The cache path converted with the given URI path.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternalProxy.GetExternalResourceReferenceFromModelPath(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ExternalResourceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternalProxy.GetExternalResourceReferenceFromModelPath(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ExternalResourceType)`

#### Summary

Implement this method to convert a given ModelPath (could be file path or cloud path) to an ExternalResourceReference.

#### Remarks

This funcion is called only if `!:canHandleModelPath()` returns true.
If the local path cannot be handled by this server, null ExternalResourceReference will be returned.

#### Parameter `modelPath`

The path to the external resource.

#### Parameter `resourceType`

The external resource type should be matched by the ModelPath.

#### Returns

The ExternalResourceReference converted with the given ModelPath.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternalProxy.CanHandleModelPath(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ExternalResourceType,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternalProxy.CanHandleModelPath(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ExternalResourceType,System.Boolean)`

#### Summary

Implement this method to indicate whether this sever can handle a given ModelPath (could be file path or cloud path),
which matches a given external resource type, if necessary.

#### Remarks

A server cannot handle a given ModelPath, such as `!:getExternalResourceReferenceFromModelPath()`
if the given local path is outside of its cached path or the given one is invalid.

#### Parameter `modelPath`

The path to the external resource.

#### Parameter `resourceType`

The external resource type should be matched by the ModelPath.

#### Parameter `isForFileOpen`

True if the operation is for Opening file; false if the operation is for linking.

#### Returns

True if the server can handle a given ModelPath; false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternal.RootBelongsToServer(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternal.RootBelongsToServer(System.String)`

#### Summary

Returns true if the path root belongs to the server.

#### Parameter `rootName`

The path root to be tested.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternal.HasCustomServerNameForSessionPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternal.HasCustomServerNameForSessionPath`

#### Summary

Implement this method to specify if the server has custom server name for session path (something other than GetShortName()).

#### Remarks

Return true if the server name specified in GetInSessionPath() is different from GetShortName().

#### Returns

Return true if the server name specified in GetInSessionPath() is different from GetShortName().

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternal.SupportBatchLoad`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternal.SupportBatchLoad`

#### Summary

Implement this method to indicate whether this sever can do a batch load for multiple resources.

#### Remarks

Some external servers, e.g. AutodeskDrive Server, can do a batch load for multiple resources.

#### Returns

True if this sever can do a batch load for multiple resources.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternal.PreProcessResources(System.Collections.Generic.IList{Autodesk.Revit.DB.ExternalResourceLoadData})`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternal.PreProcessResources(System.Collections.Generic.IList{Autodesk.Revit.DB.ExternalResourceLoadData})`

#### Summary

Pre-processes resources by the server which will downloads the files from A360, if necessary.

#### Parameter `loadData`

The data returned by the server as a result of this load operation.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternal.GetCacheRoot`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternal.GetCacheRoot`

#### Summary

Get the root location for locally cached files used
by this server.
Return "" if there is no local cache or if there is no
one root location.

#### Returns

The local cache root for this server, or the empty
string if there is no local cache.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternal.IsHiddenInUI`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternal.IsHiddenInUI`

#### Summary

Implement this method to indicate whether this sever is hidden in the user interface,
e.g. through External Resource icon.

#### Returns

True if this sever is hidden in the user interface; false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternal.GetUpdatedResourceDataForWorksharing(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternal.GetUpdatedResourceDataForWorksharing(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Implement this method to update the resource when attempting to save to workshared file.

#### Remarks

Will be called when attempting to save to workshared file only if `!:resourceNeedsUpdateForWorksharing()` returned true.

#### Parameter `resource`

The resource to update.

#### Returns

Updated resource or failure definition id.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternal.ResourceNeedsUpdateForWorksharing(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternal.ResourceNeedsUpdateForWorksharing(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Implement this method to indicate whether a given resource needs an update to be shared by multiple users.

#### Remarks

If true `!:updateResourceForWorksharing()` will be called.

#### Parameter `resource`

The resource to check.

#### Returns

True if the resource needs to be updated for worksharing.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternal.GetFullPathFromJournalPath(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternal.GetFullPathFromJournalPath(System.String)`

#### Summary

Implement this method to convert a given URI path (if applicable) to the cache path on disk.

#### Remarks

This function is called for the case only a URI path is known.

#### Parameter `displayPath`

The URI path to the resource.

#### Returns

The cache path converted with the given URI path.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternal.GetExternalResourceReferenceFromModelPath(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ExternalResourceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternal.GetExternalResourceReferenceFromModelPath(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ExternalResourceType)`

#### Summary

Implement this method to convert a given ModelPath (could be file path or cloud path) to an ExternalResourceReference.

#### Remarks

This funcion is called only if `!:canHandleModelPath()` returns true.
If the local path cannot be handled by this server, null ExternalResourceReference will be returned.

#### Parameter `modelPath`

The path to the external resource.

#### Parameter `resourceType`

The external resource type should be matched by the ModelPath.

#### Returns

The ExternalResourceReference converted with the given ModelPath.

#### Since

2018

### `M:Autodesk.Revit.DB.IExternalResourceServerInternal.CanHandleModelPath(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ExternalResourceType,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternal.CanHandleModelPath(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ExternalResourceType,System.Boolean)`

#### Summary

Implement this method to indicate whether this sever can handle a given ModelPath (could be file path or cloud path),
which matches a given external resource type, if necessary.

#### Remarks

A server cannot handle a given ModelPath, such as `!:getExternalResourceReferenceFromModelPath()`
if the given local path is outside of its cached path or the given one is invalid.

#### Parameter `modelPath`

The path to the external resource.

#### Parameter `resourceType`

The external resource type should be matched by the ModelPath.

#### Parameter `isForFileOpen`

True if the operation is for Opening file; false if the operation is for linking.

#### Returns

True if the server can handle a given ModelPath; false otherwise.

#### Since

2018

### `T:Autodesk.Revit.DB.IExternalResourceServerInternal`

Member kind: type
Symbol: `Autodesk.Revit.DB.IExternalResourceServerInternal`

#### Summary

Extends the interface of IExternalResourceServer and enable more functionality for external resource servers.

#### Remarks

Currently, this extention allows the server to handle worksharing and applicable local paths.
it also enables the server to be hidden in UI.

#### Since

2018

### `M:Autodesk.Revit.DB.ProjectParameterAccess.MarkCompanyInfo(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectParameterAccess.MarkCompanyInfo(System.String,System.String)`

#### Summary

Records the given friendly name for the given company account identifier. The name is not written to the Revit
document until the next call to CommitUpdates() on this object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ProjectParameterAccess.MarkUploadedParameterIdentifier(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectParameterAccess.MarkUploadedParameterIdentifier(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Records the given ForgeTypeId as the identifier of a new schema uploaded to Forge to represent the local
parameter with the given ElementId. The local parameter's ForgeTypeId identifier is not changed until the next
call to CommitUpdates() on this object.

After calling this method, GetForgeParametersInActiveModel() may return different results, reflecting that
local parameters have been updated with their new Forge parameter identifiers.

#### Parameter `parameterId`

Local parameter for which to record a new identifier.

#### Parameter `newSchemaIdentifier`

Identifier of a schema uploaded to represent the local parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ProjectParameterAccess.GetLocalParameterData`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectParameterAccess.GetLocalParameterData`

#### Summary

Returns a list of JSON strings serializing objects detailing local (non-Forge) project shared parameters
present in the active model. Each serialized JSON object in the array has these properties:
- bindings: Object specifying the parameter's category and group bindings.
- id: ElementId integer identifying the shared parameter element in the Revit project.
- guid: The GUID identifying the shared parameter in the Revit project.
- schema: Parameter definition object.

#### Returns

Array of JSON-serialized objects detailing local (non-Forge) project shared parameters in the active model.

### `M:Autodesk.Revit.DB.ProjectParameterAccess.GetForgeParametersInActiveModel`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectParameterAccess.GetForgeParametersInActiveModel`

#### Summary

Returns a list of the identifiers of Forge parameters present in the active model. Local parameters that do not
correspond to any definition on Forge are omitted from this list.

Identifiers are provided here as raw strings instead of ForgeTypeId to enable direct serialization to JSON for
use in a JavaScript web app.

#### Returns

The identifiers of Forge parameters in the active model.

### `P:Autodesk.Revit.DB.ProjectParameterAccess.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectParameterAccess.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ProjectParameterAccess`

Member kind: type
Symbol: `Autodesk.Revit.DB.ProjectParameterAccess`

#### Summary

Provides a view of the parameters loaded in a given Revit project and supports ForgeTypeId identifier migration
for parameters uploaded to Forge.

### `M:Autodesk.Revit.DB.IExternalParameterServerProxy.ManageParameters(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ProjectParameterAccess)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalParameterServerProxy.ManageParameters(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ProjectParameterAccess)`

#### Summary

call the service to manage parameters in Revit

#### Parameter `projectParameters`

Provides access to view and upgrade parameters already in the project.

### `M:Autodesk.Revit.DB.IExternalParameterServerProxy.SelectParameterProhibitingDataTypes(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeTypeId},Autodesk.Revit.DB.ProjectParameterAccess,System.Collections.Generic.IList{System.String},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalParameterServerProxy.SelectParameterProhibitingDataTypes(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeTypeId},Autodesk.Revit.DB.ProjectParameterAccess,System.Collections.Generic.IList{System.String},System.Boolean)`

#### Summary

Returns the identity of a shared parameter that does not use any of the given prohibited data types.
If the given set of prohibited data types is empty, the shared parameter can have any data type.

#### Parameter `requiresCategoryBinding`

Provides access to view and upgrade parameters already in the project while selecting parameters to add.

### `M:Autodesk.Revit.DB.IExternalParameterServerProxy.SelectParameterWithDataType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ProjectParameterAccess,System.Collections.Generic.IList{System.String},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalParameterServerProxy.SelectParameterWithDataType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ProjectParameterAccess,System.Collections.Generic.IList{System.String},System.Boolean)`

#### Summary

Returns a selection of parameters with the given data type.
If the given data type is an empty identifier, the selected parameters can have any data type.

#### Parameter `requiresCategoryBinding`

Provides access to view and upgrade parameters already in the project while selecting parameters to add.

### `M:Autodesk.Revit.DB.IExternalParameterServer.ManageParameters(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ProjectParameterAccess)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalParameterServer.ManageParameters(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ProjectParameterAccess)`

#### Summary

call the service to manage parameters in Revit

#### Parameter `projectParameters`

Provides access to view and upgrade parameters already in the project.

### `M:Autodesk.Revit.DB.IExternalParameterServer.SelectParameterProhibitingDataTypes(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeTypeId},Autodesk.Revit.DB.ProjectParameterAccess,System.Collections.Generic.IList{System.String},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalParameterServer.SelectParameterProhibitingDataTypes(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeTypeId},Autodesk.Revit.DB.ProjectParameterAccess,System.Collections.Generic.IList{System.String},System.Boolean)`

#### Summary

Returns the identity of a shared parameter that does not use any of the given prohibited data types.
If the given set of prohibited data types is empty, the shared parameter can have any data type.

#### Parameter `requiresCategoryBinding`

Provides access to view and upgrade parameters already in the project while selecting parameters to add.

### `M:Autodesk.Revit.DB.IExternalParameterServer.SelectParameterWithDataType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ProjectParameterAccess,System.Collections.Generic.IList{System.String},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExternalParameterServer.SelectParameterWithDataType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ProjectParameterAccess,System.Collections.Generic.IList{System.String},System.Boolean)`

#### Summary

Returns a selection of parameters with the given data type.
If the given data type is an empty identifier, the selected parameters can have any data type.

#### Parameter `requiresCategoryBinding`

Provides access to view and upgrade parameters already in the project while selecting parameters to add.

### `T:Autodesk.Revit.DB.IExternalParameterServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.IExternalParameterServer`

#### Summary

The service class for shared parameter selection.

### `P:Autodesk.Revit.DB.ParameterSelectionResult.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterSelectionResult.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.ParameterSelectionResult.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeSchemaClosure})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterSelectionResult.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeSchemaClosure})`

#### Summary

Indicates that the given schemas were selected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ParameterSelectionResult.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterSelectionResult.#ctor`

#### Summary

Indicates that selection was unsuccessful or canceled.

### `T:Autodesk.Revit.DB.ParameterSelectionResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.ParameterSelectionResult`

#### Summary

Indicates the result of a parameter selection.

### `P:Autodesk.Revit.DB.CameraInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CameraInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.CameraInfo.UpOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.CameraInfo.UpOffset`

#### Summary

Distance that the target plane is offset in the direction of
the Up direction. This offset shifts both top and bottom planes.

#### Since

2014

### `P:Autodesk.Revit.DB.CameraInfo.RightOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.CameraInfo.RightOffset`

#### Summary

Distance that the target plane is offset towards the right
where right is normal to both Up direction and View direction.
This offset shifts both left and right planes.

#### Since

2014

### `P:Autodesk.Revit.DB.CameraInfo.TargetDistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.CameraInfo.TargetDistance`

#### Summary

Distance from eye point along view direction to target plane.

#### Remarks

This value is appropriate for perspective views only.
Attempts to get this value for an orthographic view can
be made, but the obtained value is to be ignored.

#### Since

2014

### `P:Autodesk.Revit.DB.CameraInfo.NearDistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.CameraInfo.NearDistance`

#### Summary

Distance from eye point to near plane of view frustum along the view direction.

#### Remarks

This property together with FarDistance determines the depth restrictions of a view frustum.

#### Since

2014

### `P:Autodesk.Revit.DB.CameraInfo.FarDistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.CameraInfo.FarDistance`

#### Summary

Distance from eye point to far plane of view frustum along the view direction.

#### Remarks

This property together with NearDistance determines the depth restrictions of a view frustum.

#### Since

2014

### `P:Autodesk.Revit.DB.CameraInfo.HorizontalExtent`

Member kind: property
Symbol: `Autodesk.Revit.DB.CameraInfo.HorizontalExtent`

#### Summary

Distance between left and right planes on the target plane.

#### Since

2014

### `P:Autodesk.Revit.DB.CameraInfo.VerticalExtent`

Member kind: property
Symbol: `Autodesk.Revit.DB.CameraInfo.VerticalExtent`

#### Summary

Distance between top and bottom planes on the target plane.

#### Since

2014

### `P:Autodesk.Revit.DB.CameraInfo.IsPerspective`

Member kind: property
Symbol: `Autodesk.Revit.DB.CameraInfo.IsPerspective`

#### Summary

Identifies whether the projection is orthographic or perspective

#### Since

2016

### `P:Autodesk.Revit.DB.CameraInfo.IsPespective`

Member kind: property
Symbol: `Autodesk.Revit.DB.CameraInfo.IsPespective`

#### Summary

Identifies whether the projection is orthographic or perspective

#### Since

2014

### `T:Autodesk.Revit.DB.CameraInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.CameraInfo`

#### Summary

An object holding information about the projection mapping of a 3D view.

#### Remarks

CameraInfo can be obtained directly from a `T:Autodesk.Revit.DB.ViewNode`
If camera info is not available, an orthographic view should be assumed.

See also: `M:Autodesk.Revit.DB.IExportContext.OnViewBegin(Autodesk.Revit.DB.ViewNode)` .

#### Since

2014

### `P:Autodesk.Revit.DB.ElementNode.LinkInstanceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementNode.LinkInstanceId`

#### Summary

The Id of the link instance for the element.

#### Since

2020

### `P:Autodesk.Revit.DB.ElementNode.Document`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementNode.Document`

#### Summary

Gets the document associated with the element.

#### Remarks

The document is in read-only state. Transactions are not allowed in it.

#### Since

2020

### `P:Autodesk.Revit.DB.ElementNode.ElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementNode.ElementId`

#### Summary

The Id of the element.

#### Since

2020

### `T:Autodesk.Revit.DB.ElementNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementNode`

#### Summary

A render node that represents an element, including the host document containing the element.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContext2D.OnElementBegin2D(Autodesk.Revit.DB.ElementNode)` .
See also: `M:Autodesk.Revit.DB.IExportContext2D.OnElementEnd2D(Autodesk.Revit.DB.ElementNode)` .

#### Since

2020

### `M:Autodesk.Revit.DB.MaterialNode.GetColorWithTransparency`

Member kind: method
Symbol: `Autodesk.Revit.DB.MaterialNode.GetColorWithTransparency`

#### Summary

Returns material color with transparency.

#### Remarks

The value may differ from the default color property of the material,
because it might have been overridden by rendering settings.
And could also be differ from Color property of the same material node
When override transparency is specificed since Color will be marked as invalid in this case

#### Returns

An instance of a ColorWithTransparency.

#### Since

2014

### `M:Autodesk.Revit.DB.MaterialNode.GetAppearanceOverride`

Member kind: method
Symbol: `Autodesk.Revit.DB.MaterialNode.GetAppearanceOverride`

#### Summary

Returns appearance properties that override the preset appearance of the material.

#### Remarks

The returned instance of an Asset is valid only if there is an overide, which happens
if there are decals applied to the face that has the base material. In such cases the
rendering engine takes the asset of the material and merges it with the decal,
which results to this override asset. If there are no decals, this instance is null
and the HasOverriddenAppearance returns False.

#### Returns

An instance of a rendering material asset, of null if there is no override.

#### Since

2014

### `M:Autodesk.Revit.DB.MaterialNode.GetAppearance`

Member kind: method
Symbol: `Autodesk.Revit.DB.MaterialNode.GetAppearance`

#### Summary

Appearance properties associated with the material.

#### Remarks

Properties and attributes of the material's appearance
can be accessed using the standard interface of the Asset class.

The structure of the properties, including their types and names
is proprietary and as such it is not always useful to anyone who
is not familiar with the particular schema. Also, the structure
is not standardized and may change over time, therefore it is not
recommended relaying on any appearance property to be present.

#### Returns

An instance of a rendering material asset

#### Since

2014

### `P:Autodesk.Revit.DB.MaterialNode.ThumbnailFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.MaterialNode.ThumbnailFile`

#### Summary

The path if a file that contains a thumbnail image of the material.

#### Since

2014

### `P:Autodesk.Revit.DB.MaterialNode.Glossiness`

Member kind: property
Symbol: `Autodesk.Revit.DB.MaterialNode.Glossiness`

#### Summary

The level of glossiness of the material

#### Since

2014

### `P:Autodesk.Revit.DB.MaterialNode.Smoothness`

Member kind: property
Symbol: `Autodesk.Revit.DB.MaterialNode.Smoothness`

#### Summary

The level of smoothness of the material.

#### Since

2014

### `P:Autodesk.Revit.DB.MaterialNode.Color`

Member kind: property
Symbol: `Autodesk.Revit.DB.MaterialNode.Color`

#### Summary

The color the material is being rendered at

#### Remarks

The value may differ from the default color property of the material,
because it might have been overridden by rendering settings.

#### Since

2014

### `P:Autodesk.Revit.DB.MaterialNode.Transparency`

Member kind: property
Symbol: `Autodesk.Revit.DB.MaterialNode.Transparency`

#### Summary

The value of transparency the material is being rendered with

#### Since

2014

### `P:Autodesk.Revit.DB.MaterialNode.MaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.MaterialNode.MaterialId`

#### Summary

The Id of the element assocated with this material in the model.

#### Remarks

It is possible that no specific material is applied to a face, in which case
the default material is used, and this property returns an InvalidElementId.

#### Since

2014

### `P:Autodesk.Revit.DB.MaterialNode.HasOverriddenAppearance`

Member kind: property
Symbol: `Autodesk.Revit.DB.MaterialNode.HasOverriddenAppearance`

#### Summary

Identifies if the default rendering appearance the material has is being overridden.

#### Since

2014

### `T:Autodesk.Revit.DB.MaterialNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.MaterialNode`

#### Summary

This class represents a change of material during a model-exporting process.

#### Remarks

Output nodes following this node are to be assumed using the material.
The material remains in effect until another material node is sent to the output.

See also: `M:Autodesk.Revit.DB.IExportContext.OnMaterial(Autodesk.Revit.DB.MaterialNode)` .

#### Since

2014

### `M:Autodesk.Revit.DB.TextNode.GetFormattedText`

Member kind: method
Symbol: `Autodesk.Revit.DB.TextNode.GetFormattedText`

#### Summary

Returns an `T:Autodesk.Revit.DB.FormattedText` object that contains text and associated formatting of this TextNode.

#### Returns

The object that contains the text and associated formatting of of the text in this text note.

#### Since

2017

### `P:Autodesk.Revit.DB.TextNode.VerticalAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.VerticalAlignment`

#### Summary

Indicates default vertical alignment of the text.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.HorizontalAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.HorizontalAlignment`

#### Summary

Indicates default horizontal alignment of the text.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.IsKeptReadable`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.IsKeptReadable`

#### Summary

Indicates text behavior inside a rotated text object.

#### Remarks

If the property is True then the text inside the text box gets oriented
so it is readable when looking straight up at the sheet or from its right side;
in other words, the text would never be upside down.

If the value is False, however, the text's orientation strictly follows
the rotation of the text box, which means the text may be upside down when
viewed on screen or printed on a sheet.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.IsTransparent`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.IsTransparent`

#### Summary

Indicates whether the text background is transparent or opaque.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.IsUnderlined`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.IsUnderlined`

#### Summary

Indicates whether the default formatting is set to underlined text.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.IsItalic`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.IsItalic`

#### Summary

Indicates whether the default formatting is set to italic text.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.IsBold`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.IsBold`

#### Summary

Indicates whether the default formatting is set to bold text.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.TabSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.TabSize`

#### Summary

The size [ft] of the interval between tab stops, in model space.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.FontHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.FontHeight`

#### Summary

Height [ft] of the text font, in model space.

#### Remarks

This is the height of the 'M' glyph in the text font.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.Height`

#### Summary

Height [ft] of the area of the text content in model space.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.WidthScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.WidthScale`

#### Summary

Scale applied to the width of the text.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.Width`

#### Summary

Width [ft] of the area of the text content in model space.

#### Remarks

Specifies the actual width of the text, that is essentially the width of the longest line, including any spaces.
The value represents the width after the width scale has been applied.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.UpDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.UpDirection`

#### Summary

Direction along the vertical axis of letters of the text object in model space.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.BaseDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.BaseDirection`

#### Summary

Direction of the base line of the text object in model space.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.Position`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.Position`

#### Summary

Position of the text in model coordinates.

#### Remarks

The relation of the position point with respect
to the text area depends on the text alignment.

For example:
For Left-Top-aligned text the point is at the Left-Top corner of the box.

For Center-Bottom aligned text the point is at the Center-Bottom corner of the box.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.Text`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.Text`

#### Summary

The content of the text annotation as a plain string stripped of all formatting.

#### Remarks

The text may contain new-lines if there are any in the text annotation.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.FontName`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.FontName`

#### Summary

The name of the text font.

#### Since

2016

### `P:Autodesk.Revit.DB.TextNode.Color`

Member kind: property
Symbol: `Autodesk.Revit.DB.TextNode.Color`

#### Summary

The color of the text.

#### Since

2016

### `T:Autodesk.Revit.DB.TextNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.TextNode`

#### Summary

This class represents a text annotation object in a model-exporting process.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContextBase.OnText(Autodesk.Revit.DB.TextNode)` .

#### Since

2016

### `T:Autodesk.Revit.DB.LightNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.LightNode`

#### Summary

This class represents a Light element in a model-exporting process.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContext.OnLight(Autodesk.Revit.DB.LightNode)` .

#### Since

2014

### `T:Autodesk.Revit.DB.RPCNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.RPCNode`

#### Summary

This class represents an RPC content in a model-exporting process.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContext.OnRPC(Autodesk.Revit.DB.RPCNode)` .

#### Since

2014

### `M:Autodesk.Revit.DB.ContentNode.GetAsset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ContentNode.GetAsset`

#### Summary

Returns an an instance of an Asset object, which contains definitions of the content node.

#### Remarks

Properties and attributes of the node can be accessed using the standard interface of the Asset class.

#### Since

2014

### `M:Autodesk.Revit.DB.ContentNode.GetTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.ContentNode.GetTransform`

#### Summary

A transformation matrix associated with the node.

#### Since

2014

### `T:Autodesk.Revit.DB.ContentNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.ContentNode`

#### Summary

This class represents a generic content node in a model-exporting process.

#### Remarks

Members of this class implement properties and methods
common to all content classes, such as RPC and Light nodes.
Attributes of a content note can be accessed via an Asset object.

#### Since

2014

### `M:Autodesk.Revit.DB.PolylineSegments.GetVertices`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolylineSegments.GetVertices`

#### Summary

Returns an array of vertices of the polyline segments.

#### Returns

Array of XYZ points.

#### Since

2016

### `P:Autodesk.Revit.DB.PolylineSegments.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolylineSegments.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.PolylineSegments.LineProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolylineSegments.LineProperties`

#### Summary

Access to the line (pen) properties of the polyline

#### Since

2016

### `P:Autodesk.Revit.DB.PolylineSegments.IsFilled`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolylineSegments.IsFilled`

#### Summary

Indicates whether the area enclosed by the polyline is to be filled or not.

#### Since

2016

### `P:Autodesk.Revit.DB.PolylineSegments.EndLocalParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolylineSegments.EndLocalParameter`

#### Summary

Local parameter associated with the end point.

#### Since

2016

### `P:Autodesk.Revit.DB.PolylineSegments.StartLocalParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolylineSegments.StartLocalParameter`

#### Summary

Local parameter associated with the start point.

#### Since

2016

### `P:Autodesk.Revit.DB.PolylineSegments.EndParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolylineSegments.EndParameter`

#### Summary

Parameter associated with the end point.

#### Since

2016

### `P:Autodesk.Revit.DB.PolylineSegments.StartParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolylineSegments.StartParameter`

#### Summary

Parameter associated with the start point.

#### Since

2016

### `T:Autodesk.Revit.DB.PolylineSegments`

Member kind: type
Symbol: `Autodesk.Revit.DB.PolylineSegments`

#### Summary

An output node that represents a tessellated polyline segments.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContextBase.OnPolylineSegments(Autodesk.Revit.DB.PolylineSegments)` .

#### Since

2016

### `P:Autodesk.Revit.DB.LineSegment.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.LineSegment.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.LineSegment.LineProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.LineSegment.LineProperties`

#### Summary

Access to the line (pen) properties of the line

#### Since

2016

### `P:Autodesk.Revit.DB.LineSegment.EndParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.LineSegment.EndParameter`

#### Summary

Parameter associated with the end point.

#### Since

2016

### `P:Autodesk.Revit.DB.LineSegment.StartParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.LineSegment.StartParameter`

#### Summary

Parameter associated with the start point.

#### Since

2016

### `P:Autodesk.Revit.DB.LineSegment.EndPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.LineSegment.EndPoint`

#### Summary

End point of the line segment.

#### Since

2016

### `P:Autodesk.Revit.DB.LineSegment.StartPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.LineSegment.StartPoint`

#### Summary

Start point of the line segment.

#### Since

2016

### `T:Autodesk.Revit.DB.LineSegment`

Member kind: type
Symbol: `Autodesk.Revit.DB.LineSegment`

#### Summary

An output node that represents a tessellated line segment.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContextBase.OnLineSegment(Autodesk.Revit.DB.LineSegment)` .

#### Since

2016

### `M:Autodesk.Revit.DB.FaceSilhouetteNode.GetFace`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceSilhouetteNode.GetFace`

#### Summary

Returns the Face object corresponding to the node.

#### Returns

The face.

#### Since

2020

### `T:Autodesk.Revit.DB.FaceSilhouetteNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.FaceSilhouetteNode`

#### Summary

An output node that represents a Face edge.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContext2D.OnFaceSilhouette2D(Autodesk.Revit.DB.FaceSilhouetteNode)` .

#### Since

2020

### `M:Autodesk.Revit.DB.FaceEdgeNode.GetFaceEdge`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceEdgeNode.GetFaceEdge`

#### Summary

Returns the Face edge object corresponding to the node.

#### Returns

The face edge.

#### Since

2020

### `T:Autodesk.Revit.DB.FaceEdgeNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.FaceEdgeNode`

#### Summary

An output node that represents a Face edge.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContext2D.OnFaceEdge2D(Autodesk.Revit.DB.FaceEdgeNode)` .

#### Since

2020

### `M:Autodesk.Revit.DB.FaceDetailNode.GetInstanceTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceDetailNode.GetInstanceTransform`

#### Summary

Returns instance transform of the object being drawn.

#### Since

2020

### `M:Autodesk.Revit.DB.FaceDetailNode.GetLinkTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceDetailNode.GetLinkTransform`

#### Summary

Returns link transform of the object being drawn.

#### Since

2020

### `P:Autodesk.Revit.DB.FaceDetailNode.LineProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.FaceDetailNode.LineProperties`

#### Summary

Access to the line (pen) properties of the curve being drawn.

#### Since

2020

### `T:Autodesk.Revit.DB.FaceDetailNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.FaceDetailNode`

#### Summary

A base class of output nodes that represent face edges and face silhouettes.

#### Since

2020

### `M:Autodesk.Revit.DB.PointNode.GetPoint`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointNode.GetPoint`

#### Summary

Returns the point object corresponding to the node.

#### Returns

The point instance.

#### Since

2016

### `T:Autodesk.Revit.DB.PointNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointNode`

#### Summary

An output node that represents a 3D point.

#### Remarks

See also: `M:Autodesk.Revit.DB.IModelExportContext.OnPoint(Autodesk.Revit.DB.PointNode)` .

#### Since

2016

### `M:Autodesk.Revit.DB.PolylineNode.GetPolyline`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolylineNode.GetPolyline`

#### Summary

Returns the polyline object corresponding to the node.

#### Returns

The polyline instance.

#### Since

2016

### `T:Autodesk.Revit.DB.PolylineNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.PolylineNode`

#### Summary

An output node that represents a 3D polyline.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContextBase.OnPolyline(Autodesk.Revit.DB.PolylineNode)` .

#### Since

2016

### `M:Autodesk.Revit.DB.CurveNode.GetCurve`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveNode.GetCurve`

#### Summary

Returns the geometric curve object corresponding to the node.

#### Returns

The curve.

#### Since

2016

### `T:Autodesk.Revit.DB.CurveNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveNode`

#### Summary

An output node that represents a model curve.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContextBase.OnCurve(Autodesk.Revit.DB.CurveNode)` .

#### Since

2016

### `P:Autodesk.Revit.DB.ModelCurveNode.LineProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelCurveNode.LineProperties`

#### Summary

Access to the line (pen) properties of the curve being drawn

#### Since

2016

### `T:Autodesk.Revit.DB.ModelCurveNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelCurveNode`

#### Summary

A base class of output nodes that represent various model curves.

#### Since

2016

### `P:Autodesk.Revit.DB.LineProperties.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.LineProperties.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.LineProperties.PatternId`

Member kind: property
Symbol: `Autodesk.Revit.DB.LineProperties.PatternId`

#### Summary

Id of the current Line pattern element used when drawing lines/curves.

#### Since

2016

### `P:Autodesk.Revit.DB.LineProperties.LineWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.LineProperties.LineWidth`

#### Summary

The current width (thickness) of the pen stroke when drawing lines/curves.

#### Since

2016

### `P:Autodesk.Revit.DB.LineProperties.Transparency`

Member kind: property
Symbol: `Autodesk.Revit.DB.LineProperties.Transparency`

#### Summary

The current transparency level to be applied to the current color.

#### Since

2016

### `P:Autodesk.Revit.DB.LineProperties.Color`

Member kind: property
Symbol: `Autodesk.Revit.DB.LineProperties.Color`

#### Summary

The current color used when drawing lines/curves.

#### Since

2016

### `T:Autodesk.Revit.DB.LineProperties`

Member kind: type
Symbol: `Autodesk.Revit.DB.LineProperties`

#### Summary

A structure that has access to the pen properties of lines/curves
that are currently being drawn/exported via an export context
during a custom export process.

#### Remarks

For more about using properties of this class refer to the interface
`T:Autodesk.Revit.DB.IModelExportContext` and its methods
which handle geometric objects such as `M:Autodesk.Revit.DB.IExportContextBase.OnCurve(Autodesk.Revit.DB.CurveNode)` ,
`M:Autodesk.Revit.DB.IExportContextBase.OnLineSegment(Autodesk.Revit.DB.LineSegment)` , etc.
LineProperties are available as a read-only property on the respective output nodes,
i.e. `T:Autodesk.Revit.DB.CurveNode` , `T:Autodesk.Revit.DB.LineSegment` , etc.

#### Since

2016

### `M:Autodesk.Revit.DB.FaceNode.GetFace`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceNode.GetFace`

#### Summary

Returns the Face object corresponding to the node.

#### Returns

The face.

#### Since

2014

### `T:Autodesk.Revit.DB.FaceNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.FaceNode`

#### Summary

An output node that represents a Face.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContext.OnFaceBegin(Autodesk.Revit.DB.FaceNode)` .

#### Since

2014

### `M:Autodesk.Revit.DB.SolidNode.GetSolid`

Member kind: method
Symbol: `Autodesk.Revit.DB.SolidNode.GetSolid`

#### Summary

Returns the Revit Solid.

#### Returns

Instance of a GBRep

#### Since

2021

### `T:Autodesk.Revit.DB.SolidNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.SolidNode`

#### Summary

An output node that represents a Solid.

#### Remarks

See also: `!:Autodesk::Revit::DB::IExportContext::OnSolidBegin` .

#### Since

2021

### `M:Autodesk.Revit.DB.LinkNode.GetDocument`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkNode.GetDocument`

#### Summary

Returns the document associated with the link.

#### Remarks

The document is in read-only state. Transactions are not allowed in it.

#### Returns

Instance of a Document

#### Since

2014

### `P:Autodesk.Revit.DB.LinkNode.SymbolId`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinkNode.SymbolId`

#### Summary

Identifies the Id of the symbol associated with the node.

#### Since

2023

### `T:Autodesk.Revit.DB.LinkNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinkNode`

#### Summary

An output node that represents a linked Revit document.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContext.OnLinkBegin(Autodesk.Revit.DB.LinkNode)` .

#### Since

2014

### `M:Autodesk.Revit.DB.InstanceNode.GetGNodeTag`

Member kind: method
Symbol: `Autodesk.Revit.DB.InstanceNode.GetGNodeTag`

#### Summary

Returns the GTag of the GInstance.

#### Since

2014

### `M:Autodesk.Revit.DB.InstanceNode.GetSymbolGeometryId`

Member kind: method
Symbol: `Autodesk.Revit.DB.InstanceNode.GetSymbolGeometryId`

#### Summary

Gets the SymbolGeometryId associated with the node.

#### Remarks

Use the strings returned by SymbolGeometryId.AsIdentifier(bool) to check if two nodes point to the same geometry of the symbol.

#### Since

2023

### `T:Autodesk.Revit.DB.InstanceNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.InstanceNode`

#### Summary

An output node that represents an instance of a geometry. It can be an instance of FamilyInstance, or it can be and instance of a part of symbol's geometry.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContext.OnInstanceBegin(Autodesk.Revit.DB.InstanceNode)` .
The `T:Autodesk.Revit.DB.SymbolGeometryId` . contains the data for comparing if two InstanceNode points to the same geometry.

#### Since

2014

### `M:Autodesk.Revit.DB.GroupNode.GetTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupNode.GetTransform`

#### Summary

A transformation matrix associated with the node.

#### Since

2014

### `T:Autodesk.Revit.DB.GroupNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.GroupNode`

#### Summary

A node that represents set of individual elements grouped together
in some form, such as an instance of a family or linked Revit file, or an instance of a part of symbol's geometry.

#### Since

2014

### `M:Autodesk.Revit.DB.ViewNode.GetCameraInfo`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewNode.GetCameraInfo`

#### Summary

Information about the observation point (the camera) of the view.

#### Returns

An instance of CameraInfo or `null` if there is no info associated with the view

#### Since

2014

### `P:Autodesk.Revit.DB.ViewNode.ViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewNode.ViewId`

#### Summary

The Id of the view element.

#### Since

2014

### `P:Autodesk.Revit.DB.ViewNode.LevelOfDetail`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewNode.LevelOfDetail`

#### Summary

The level of detail the view is going to be rendered at.

#### Remarks

The value is an integer number in range of [0,15] (inclusive),
or a value {-1}. If the value is positive, Revit will use the
suggested level of detail when tessellating faces; otherwise it will
use its default algorithm, which is based on output resolution.

If an explicit level of detail is requested (i.e. a positive value),
using a value close to the middle of the valid range yields a very
reasonable tessellation. Revit uses level 8 as its 'normal' LoD.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The level of detail is not in valid range.
It must be a number between -1 and 15, all inclusive.

#### Since

2014

### `T:Autodesk.Revit.DB.ViewNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewNode`

#### Summary

A render node that represents a view.

#### Remarks

See also: `M:Autodesk.Revit.DB.IExportContext.OnViewBegin(Autodesk.Revit.DB.ViewNode)` .

#### Since

2014

### `P:Autodesk.Revit.DB.RenderNode.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderNode.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RenderNode.NodeName`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderNode.NodeName`

#### Summary

A readable name of the output node.

#### Since

2014

### `T:Autodesk.Revit.DB.RenderNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.RenderNode`

#### Summary

This is the base class of all render nodes in a model-exporting process.

#### Remarks

A node can be both geometric (such as an element, light, etc.) or non-geometric (e.g. material).
Some types of nodes are container modes, which include other render nodes.

#### Since

2014

### `M:Autodesk.Revit.DB.PolymeshTopology.AsMesh`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolymeshTopology.AsMesh`

#### Summary

If possible, returns an underlying GPolyMesh.

#### Returns

Underlying GPolyMesh or null if not applicable.

#### Since

2014

### `M:Autodesk.Revit.DB.PolymeshTopology.GetNormals`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolymeshTopology.GetNormals`

#### Summary

Returns all normals assigned to the polymesh

#### Returns

An array of XYZ values, each representing a normal vector

#### Since

2014

### `M:Autodesk.Revit.DB.PolymeshTopology.GetNormal(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolymeshTopology.GetNormal(System.Int32)`

#### Summary

Returns a normal vector at the given index

#### Parameter `idx`

A zero-based index

#### Returns

XYZ value representing a normal vector

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value is not a valid index of a normal of the polymesh.
A valid valure is not negative and is smaller than the number of normals in the polymesh.

#### Since

2014

### `M:Autodesk.Revit.DB.PolymeshTopology.GetUVs`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolymeshTopology.GetUVs`

#### Summary

Returns all UV coordinates assigned to the polymesh

#### Returns

An array of UV coordinates

#### Since

2014

### `M:Autodesk.Revit.DB.PolymeshTopology.GetUV(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolymeshTopology.GetUV(System.Int32)`

#### Summary

Returns one UV coordinate at the given index.

#### Parameter `idx`

A zero-based index of a UV coordinate

#### Returns

UV coordinates at the given index

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value is not a valid index of a UV coordinate of the polymesh.
A valid valure is not negative and is smaller than the number of UV coordinates in the polymesh.

#### Since

2014

### `M:Autodesk.Revit.DB.PolymeshTopology.GetPoints`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolymeshTopology.GetPoints`

#### Summary

Returns all points of the polymesh.

#### Returns

An array of XYZ coordinates

#### Since

2014

### `M:Autodesk.Revit.DB.PolymeshTopology.GetPoint(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolymeshTopology.GetPoint(System.Int32)`

#### Summary

Returns one point at the given index.

#### Parameter `idx`

A zero-based index of a polymesh point

#### Returns

XYZ coordinates of the point

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value is not a valid index of a point of the polymesh.
A valid valure is not negative and is smaller than the number of points in the polymesh.

#### Since

2014

### `M:Autodesk.Revit.DB.PolymeshTopology.GetFacets`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolymeshTopology.GetFacets`

#### Summary

Returns a definitions of all facets of the polymesh

#### Returns

An array of PolymeshFacet instances, each of which represents
one facet defined by 3 vertices of the polymesh.

#### Since

2014

### `M:Autodesk.Revit.DB.PolymeshTopology.GetFacet(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolymeshTopology.GetFacet(System.Int32)`

#### Summary

Returns a definition of one facet

#### Parameter `idx`

A zero-based index of the facet

#### Returns

An instance of PolymeshFacet that represents
one facet defined by 3 vertices of the polymesh.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value is not a valid index of a facet of the polymesh.
A valid value is not negative and is smaller than the number of facets in the polymesh.

#### Since

2014

### `P:Autodesk.Revit.DB.PolymeshTopology.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolymeshTopology.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.PolymeshTopology.NumberOfUVs`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolymeshTopology.NumberOfUVs`

#### Summary

The number of UV coordinates available for the polymesh.

#### Remarks

Normally, the number of UV coordinates corresponds to the number of points in a polymesh,
but a polymesh does not have to have UVs assigned, in which case the value of this property is 0.

#### Since

2014

### `P:Autodesk.Revit.DB.PolymeshTopology.NumberOfNormals`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolymeshTopology.NumberOfNormals`

#### Summary

The number of normals associated with the polymesh

#### Remarks

The number is always equal either to '1', or the number of facets,
or the number of points. The DistributionOfNormals property indicates
how normals are distributed along the polymesh. If there is only one normal available,
it applies to the entire mesh. Curved surfaces have normal vectors associated
with either every facet or every point/vertex of the tessellated polymesh.

#### Since

2014

### `P:Autodesk.Revit.DB.PolymeshTopology.NumberOfPoints`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolymeshTopology.NumberOfPoints`

#### Summary

The number of points in the polymesh

#### Since

2014

### `P:Autodesk.Revit.DB.PolymeshTopology.NumberOfFacets`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolymeshTopology.NumberOfFacets`

#### Summary

The number of facet in the polymesh.

#### Since

2014

### `P:Autodesk.Revit.DB.PolymeshTopology.DistributionOfNormals`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolymeshTopology.DistributionOfNormals`

#### Summary

Indicates the distribution of normal vectors along the tessellated polymesh surface.

#### Since

2014

### `T:Autodesk.Revit.DB.PolymeshTopology`

Member kind: type
Symbol: `Autodesk.Revit.DB.PolymeshTopology`

#### Summary

A class representing topology of a polymesh.

#### Remarks

Topology of a polymesh consists of a number of points and triangular facets formed
by the points. Each facet is determined by three indices to the array of points.
A polymesh may have UV coordinates assigned, and always has at least one normal associated.
There may be more than one normal available for a non-planar polymesh; there may be as many
normals as there are either facets or points in the polymesh. The DistributionOfNormals
property indicates how normals are distributed along the polymesh.

#### Since

2014

### `T:Autodesk.Revit.DB.DistributionOfNormals`

Member kind: type
Symbol: `Autodesk.Revit.DB.DistributionOfNormals`

#### Since

2014

#### Summary

An enumeration containing the choices of how normal vectors are assigned
and distributed along the surface of a polymesh. Planar faces would typically
have only normal vector associated, but curved faces can have a different
normal either for each facet (triangle) or each point of the tessellated polymesh.

#### Since

2014

### `F:Autodesk.Revit.DB.DistributionOfNormals.OnEachFacet`

Member kind: field
Symbol: `Autodesk.Revit.DB.DistributionOfNormals.OnEachFacet`

#### Summary

There is one normal vector per each facet of the polymesh.

### `F:Autodesk.Revit.DB.DistributionOfNormals.OnePerFace`

Member kind: field
Symbol: `Autodesk.Revit.DB.DistributionOfNormals.OnePerFace`

#### Summary

There is only one common normal vector assigned to the face/polymesh.

### `F:Autodesk.Revit.DB.DistributionOfNormals.AtEachPoint`

Member kind: field
Symbol: `Autodesk.Revit.DB.DistributionOfNormals.AtEachPoint`

#### Summary

One normal vector is assigned to each vertex of the polymesh.

### `M:Autodesk.Revit.DB.IExportContext2DProxy.OnFaceSilhouette2D(Autodesk.Revit.DB.FaceSilhouetteNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext2DProxy.OnFaceSilhouette2D(Autodesk.Revit.DB.FaceSilhouetteNode)`

#### Summary

This method is called when a Face silhouette is being output.

#### Remarks

Note that this method is invoked only if the custom exporter
was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

Note: if the export is performed for the view in non-Wireframe display style
this method will be called regardless of whether the object will be eventially output,
i.e. even if it's occluded by another element.

#### Parameter `node`

An output node that represents a Face silhouette.

#### Returns

Return RenderNodeAction.Proceed if you wish to receive tessellated geometry
(line or polyline segments) for this face silhouette, or otherwise return RenderNodeAction.Skip.

Note: if the export is performed for the view in non-Wireframe display style
tesselated geometry will be output regardless of the return value.

#### Since

2020

### `M:Autodesk.Revit.DB.IExportContext2DProxy.OnFaceEdge2D(Autodesk.Revit.DB.FaceEdgeNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext2DProxy.OnFaceEdge2D(Autodesk.Revit.DB.FaceEdgeNode)`

#### Summary

This method is called when a Face edge is being output.

#### Remarks

Note that this method is invoked only if the custom exporter
was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

Note: if the export is performed for the view in non-Wireframe display style
this method will be called regardless of whether the object will be eventially output,
i.e. even if it's occluded by another element.

#### Parameter `node`

An output node that represents a Face edge.

#### Returns

Return RenderNodeAction.Proceed if you wish to receive tessellated geometry
(line or polyline segments) for this face edge, or otherwise return RenderNodeAction.Skip.

Note: if the export is performed for the view in non-Wireframe display style
tesselated geometry will be output regardless of the return value.

#### Since

2020

### `M:Autodesk.Revit.DB.IExportContext2DProxy.OnElementEnd2D(Autodesk.Revit.DB.ElementNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext2DProxy.OnElementEnd2D(Autodesk.Revit.DB.ElementNode)`

#### Summary

This method marks the end of an element being exported.

#### Remarks

For views having non-Wireframe display style, geometry of elements is output outside of view, instance and link begin/end brackets.
Therefore the argument to this method is ElementNode that has both element ID and the host document.

#### Parameter `node`

An output node that represents an element.

#### Since

2020

### `M:Autodesk.Revit.DB.IExportContext2DProxy.OnElementBegin2D(Autodesk.Revit.DB.ElementNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext2DProxy.OnElementBegin2D(Autodesk.Revit.DB.ElementNode)`

#### Summary

This method marks the beginning of an element to be exported.

#### Remarks

For views having non-Wireframe display style, geometry of elements is output outside of view, instance and link begin/end brackets.
Therefore the argument to this method is ElementNode that has both element ID and the host document.

#### Parameter `node`

Node representing the element that is about to start being exported. Contains element ID and document.

#### Returns

Return RenderNodeAction.Skip if you wish to skip exporting this element,
or return RenderNodeAction.Proceed otherwise.

#### Since

2020

### `M:Autodesk.Revit.DB.IExportContext2D.OnFaceSilhouette2D(Autodesk.Revit.DB.FaceSilhouetteNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext2D.OnFaceSilhouette2D(Autodesk.Revit.DB.FaceSilhouetteNode)`

#### Summary

This method is called when a Face silhouette is being output.

#### Remarks

Note that this method is invoked only if the custom exporter
was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

Note: if the export is performed for the view in non-Wireframe display style
this method will be called regardless of whether the object will be eventially output,
i.e. even if it's occluded by another element.

#### Parameter `node`

An output node that represents a Face silhouette.

#### Returns

Return RenderNodeAction.Proceed if you wish to receive tessellated geometry
(line or polyline segments) for this face silhouette, or otherwise return RenderNodeAction.Skip.

Note: if the export is performed for the view in non-Wireframe display style
tesselated geometry will be output regardless of the return value.

#### Since

2020

### `M:Autodesk.Revit.DB.IExportContext2D.OnFaceEdge2D(Autodesk.Revit.DB.FaceEdgeNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext2D.OnFaceEdge2D(Autodesk.Revit.DB.FaceEdgeNode)`

#### Summary

This method is called when a Face edge is being output.

#### Remarks

Note that this method is invoked only if the custom exporter
was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

Note: if the export is performed for the view in non-Wireframe display style
this method will be called regardless of whether the object will be eventially output,
i.e. even if it's occluded by another element.

#### Parameter `node`

An output node that represents a Face edge.

#### Returns

Return RenderNodeAction.Proceed if you wish to receive tessellated geometry
(line or polyline segments) for this face edge, or otherwise return RenderNodeAction.Skip.

Note: if the export is performed for the view in non-Wireframe display style
tesselated geometry will be output regardless of the return value.

#### Since

2020

### `M:Autodesk.Revit.DB.IExportContext2D.OnElementEnd2D(Autodesk.Revit.DB.ElementNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext2D.OnElementEnd2D(Autodesk.Revit.DB.ElementNode)`

#### Summary

This method marks the end of an element being exported.

#### Remarks

For views having non-Wireframe display style, geometry of elements is output outside of view, instance and link begin/end brackets.
Therefore the argument to this method is ElementNode that has both element ID and the host document.

#### Parameter `node`

An output node that represents an element.

#### Since

2020

### `M:Autodesk.Revit.DB.IExportContext2D.OnElementBegin2D(Autodesk.Revit.DB.ElementNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext2D.OnElementBegin2D(Autodesk.Revit.DB.ElementNode)`

#### Summary

This method marks the beginning of an element to be exported.

#### Remarks

For views having non-Wireframe display style, geometry of elements is output outside of view, instance and link begin/end brackets.
Therefore the argument to this method is ElementNode that has both element ID and the host document.

#### Parameter `node`

Node representing the element that is about to start being exported. Contains element ID and document.

#### Returns

Return RenderNodeAction.Skip if you wish to skip exporting this element,
or return RenderNodeAction.Proceed otherwise.

#### Since

2020

### `T:Autodesk.Revit.DB.IExportContext2D`

Member kind: type
Symbol: `Autodesk.Revit.DB.IExportContext2D`

#### Summary

An interface that is used in custom export to export 2D views of a Revit model.

#### Remarks

An instance of a class that implements this interface is passed in as a
parameter of the `T:Autodesk.Revit.DB.CustomExporter` constructor.
The interface methods are then called at times of drawing entities that are
currently visible in the view being exported.

With this type of export context used to perform a custom export,
Revit will traverse the model and output the model's geometry
as if in the process of regular displaying or exporting a 2D View.
It means that any geometry which is visible in an open view
(taking any current visibility setting applicable to the view)
will be processed and output.
Optionally, annotation objects are also output.

Note 1. Curves passed to calls `M:Autodesk.Revit.DB.IExportContext2D.OnFaceEdge2D(Autodesk.Revit.DB.FaceEdgeNode)` and `M:Autodesk.Revit.DB.IExportContext2D.OnFaceSilhouette2D(Autodesk.Revit.DB.FaceSilhouetteNode)` may be partially duplicating each other.

Note 2. If element E is a FamilyInstance and it contains an imported instance then:
between the calls to OnElementBegin2D/OnElementEnd2D for element E there will be calls to OnInstanceBegin/OnInstanceEnd with the "node" argument pointing to the element with its symbol being of category BuiltInCategories.OST_ImportObjectStylesall geometry exported for the element E has to be additionally subject to the transform T=E.GetTotalTransform()

#### Since

2020

### `M:Autodesk.Revit.DB.IModelExportContextWithSolidProxy.OnSolidEnd(Autodesk.Revit.DB.SolidNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IModelExportContextWithSolidProxy.OnSolidEnd(Autodesk.Revit.DB.SolidNode)`

#### Summary

This method marks the end of the current Solid being exported.

#### Parameter `node`

An output node that represents a Solid.

#### Since

2021

### `M:Autodesk.Revit.DB.IModelExportContextWithSolidProxy.OnSolidBegin(Autodesk.Revit.DB.SolidNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IModelExportContextWithSolidProxy.OnSolidBegin(Autodesk.Revit.DB.SolidNode)`

#### Summary

This method is called when a Solid is being output.

#### Remarks

Note that this method is invoked only if the custom exporter
was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

#### Parameter `node`

An output node that represents a Solid.

#### Returns

Return RenderNodeAction.Proceed if you wish to receive low-level geometry
(faces) for this Solid, or otherwise return RenderNodeAction.Skip.

#### Since

2021

### `M:Autodesk.Revit.DB.IModelExportContextWithSolid.OnSolidEnd(Autodesk.Revit.DB.SolidNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IModelExportContextWithSolid.OnSolidEnd(Autodesk.Revit.DB.SolidNode)`

#### Summary

This method marks the end of the current Solid being exported.

#### Parameter `node`

An output node that represents a Solid.

#### Since

2021

### `M:Autodesk.Revit.DB.IModelExportContextWithSolid.OnSolidBegin(Autodesk.Revit.DB.SolidNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IModelExportContextWithSolid.OnSolidBegin(Autodesk.Revit.DB.SolidNode)`

#### Summary

This method is called when a Solid is being output.

#### Remarks

Note that this method is invoked only if the custom exporter
was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

#### Parameter `node`

An output node that represents a Solid.

#### Returns

Return RenderNodeAction.Proceed if you wish to receive low-level geometry
(faces) for this Solid, or otherwise return RenderNodeAction.Skip.

#### Since

2021

### `T:Autodesk.Revit.DB.IModelExportContextWithSolid`

Member kind: type
Symbol: `Autodesk.Revit.DB.IModelExportContextWithSolid`

#### Summary

An interface that is used in custom export to export 3D views of a Revit model with Solids.

#### Remarks

An instance of a class that implements this interface is passed in as a
parameter of the `T:Autodesk.Revit.DB.CustomExporter` constructor.
The interface methods are then called at times of drawing entities that are
currently visible in the view being exported.

With this type of export context used to perform a custom export,
Revit will traverse the model and output the model's geometry
as if in the process of regular displaying or exporting a 3D View.
It means that any geometry which is visible in an open view
(taking any current visibility setting applicable to the view)
will be processed and output.

#### Since

2021

### `M:Autodesk.Revit.DB.IModelExportContextProxy.OnPoint(Autodesk.Revit.DB.PointNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IModelExportContextProxy.OnPoint(Autodesk.Revit.DB.PointNode)`

#### Summary

This method is called when a Point is being output.

#### Remarks

Note that this method is invoked only if the custom exporter
was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

#### Parameter `node`

An output node that represents a Point.

#### Returns

Return RenderNodeAction.Proceed if you wish to receive low-level geometry
(line segments) for this point, or otherwise return RenderNodeAction.Skip.

#### Since

2016

### `M:Autodesk.Revit.DB.IModelExportContext.OnPoint(Autodesk.Revit.DB.PointNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IModelExportContext.OnPoint(Autodesk.Revit.DB.PointNode)`

#### Summary

This method is called when a Point is being output.

#### Remarks

Note that this method is invoked only if the custom exporter
was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

#### Parameter `node`

An output node that represents a Point.

#### Returns

Return RenderNodeAction.Proceed if you wish to receive low-level geometry
(line segments) for this point, or otherwise return RenderNodeAction.Skip.

#### Since

2016

### `T:Autodesk.Revit.DB.IModelExportContext`

Member kind: type
Symbol: `Autodesk.Revit.DB.IModelExportContext`

#### Summary

An interface that is used in custom export to export 3D views of a Revit model.

#### Remarks

An instance of a class that implements this interface is passed in as a
parameter of the `T:Autodesk.Revit.DB.CustomExporter` constructor.
The interface methods are then called at times of drawing entities that are
currently visible in the view being exported.

With this type of export context used to perform a custom export,
Revit will traverse the model and output the model's geometry
as if in the process of regular displaying or exporting a 3D View.
It means that any geometry which is visible in an open view
(taking any current visibility setting applicable to the view)
will be processed and output.

#### Since

2016

### `M:Autodesk.Revit.DB.IExportContextBaseProxy.OnText(Autodesk.Revit.DB.TextNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextBaseProxy.OnText(Autodesk.Revit.DB.TextNode)`

#### Summary

This method is called when a text annotation object is being output.

#### Parameter `node`

An output node that represents a text annotation.

### `M:Autodesk.Revit.DB.IExportContextBaseProxy.OnPolylineSegments(Autodesk.Revit.DB.PolylineSegments)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextBaseProxy.OnPolylineSegments(Autodesk.Revit.DB.PolylineSegments)`

#### Summary

This method is called after unhandled curve was tessellated to polyline segments and sent to the output.

Note for 2D export: if the export is performed for the view in non-Wireframe display style, then
this method is called outside of view, instance and link begin/end calls but still between OnElementBegin2D/OnElementEnd2D callsthis method is never called for annotation elements, i.e. their geometry should be processed in methods OnCurve and OnPolyline

#### Parameter `segments`

A structure describing the polyline segments.

### `M:Autodesk.Revit.DB.IExportContextBaseProxy.OnLineSegment(Autodesk.Revit.DB.LineSegment)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextBaseProxy.OnLineSegment(Autodesk.Revit.DB.LineSegment)`

#### Summary

This method is called after unhandled curve was tessellated to line segments and sent to the output.

Note for 2D export: if the export is performed for the view in non-Wireframe display style, then
this method is called outside of view, instance and link begin/end calls but still between OnElementBegin2D/OnElementEnd2D callsthis method is never called for annotation elements, i.e. their geometry should be processed in methods OnCurve and OnPolyline

#### Parameter `segment`

A structure describing the line segment.

### `M:Autodesk.Revit.DB.IExportContextBaseProxy.OnPolyline(Autodesk.Revit.DB.PolylineNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextBaseProxy.OnPolyline(Autodesk.Revit.DB.PolylineNode)`

#### Summary

This method is called when a Polyline is being output.

#### Remarks

Note that this method is invoked only if the custom exporter
was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

Note for 2D export: if the export is performed for the view in non-Wireframe display style
this method will be called regardless of whether the object will be eventially output,
i.e. even if it's occluded by another element.

#### Parameter `node`

An output node that represents a Polyline.

#### Returns

Return RenderNodeAction.Proceed if you wish to receive tessellated geometry
(polyline segments) for this polyline, or otherwise return RenderNodeAction.Skip.

Note for 2D export: if the export is performed for the view in non-Wireframe display style
tesselated geometry will be output regardless of the return value.

### `M:Autodesk.Revit.DB.IExportContextBaseProxy.OnCurve(Autodesk.Revit.DB.CurveNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextBaseProxy.OnCurve(Autodesk.Revit.DB.CurveNode)`

#### Summary

This method is called when a Curve is being output.

#### Remarks

Note that this method is invoked only if the custom exporter
was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

The curve can be one of the geometric object that derive from the Curve class, e.g. Line, Arc,
NurbeSpline, etc. To get to the specific properties of the particular class, the curve
obtained from the input node first needs to be cast accordingly depending on the curve's
actual type.

Note for 2D export: if the export is performed for the view in non-Wireframe display style
this method will be called regardless of whether the object will be eventially output,
i.e. even if it's occluded by another element.

#### Parameter `node`

An output node that represents a Curve.

#### Returns

Return RenderNodeAction.Proceed if you wish to receive tessellated geometry
(line or polyline segments) for this curve, or otherwise return RenderNodeAction.Skip.

Note for 2D export: if the export is performed for the view in non-Wireframe display style
tesselated geometry will be output regardless of the return value.

### `M:Autodesk.Revit.DB.IExportContextBase.OnText(Autodesk.Revit.DB.TextNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextBase.OnText(Autodesk.Revit.DB.TextNode)`

#### Summary

This method is called when a text annotation object is being output.

#### Parameter `node`

An output node that represents a text annotation.

### `M:Autodesk.Revit.DB.IExportContextBase.OnPolylineSegments(Autodesk.Revit.DB.PolylineSegments)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextBase.OnPolylineSegments(Autodesk.Revit.DB.PolylineSegments)`

#### Summary

This method is called after unhandled curve was tessellated to polyline segments and sent to the output.

Note for 2D export: if the export is performed for the view in non-Wireframe display style, then
this method is called outside of view, instance and link begin/end calls but still between OnElementBegin2D/OnElementEnd2D callsthis method is never called for annotation elements, i.e. their geometry should be processed in methods OnCurve and OnPolyline

#### Parameter `segments`

A structure describing the polyline segments.

### `M:Autodesk.Revit.DB.IExportContextBase.OnLineSegment(Autodesk.Revit.DB.LineSegment)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextBase.OnLineSegment(Autodesk.Revit.DB.LineSegment)`

#### Summary

This method is called after unhandled curve was tessellated to line segments and sent to the output.

Note for 2D export: if the export is performed for the view in non-Wireframe display style, then
this method is called outside of view, instance and link begin/end calls but still between OnElementBegin2D/OnElementEnd2D callsthis method is never called for annotation elements, i.e. their geometry should be processed in methods OnCurve and OnPolyline

#### Parameter `segment`

A structure describing the line segment.

### `M:Autodesk.Revit.DB.IExportContextBase.OnPolyline(Autodesk.Revit.DB.PolylineNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextBase.OnPolyline(Autodesk.Revit.DB.PolylineNode)`

#### Summary

This method is called when a Polyline is being output.

#### Remarks

Note that this method is invoked only if the custom exporter
was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

Note for 2D export: if the export is performed for the view in non-Wireframe display style
this method will be called regardless of whether the object will be eventially output,
i.e. even if it's occluded by another element.

#### Parameter `node`

An output node that represents a Polyline.

#### Returns

Return RenderNodeAction.Proceed if you wish to receive tessellated geometry
(polyline segments) for this polyline, or otherwise return RenderNodeAction.Skip.

Note for 2D export: if the export is performed for the view in non-Wireframe display style
tesselated geometry will be output regardless of the return value.

### `M:Autodesk.Revit.DB.IExportContextBase.OnCurve(Autodesk.Revit.DB.CurveNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextBase.OnCurve(Autodesk.Revit.DB.CurveNode)`

#### Summary

This method is called when a Curve is being output.

#### Remarks

Note that this method is invoked only if the custom exporter
was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

The curve can be one of the geometric object that derive from the Curve class, e.g. Line, Arc,
NurbeSpline, etc. To get to the specific properties of the particular class, the curve
obtained from the input node first needs to be cast accordingly depending on the curve's
actual type.

Note for 2D export: if the export is performed for the view in non-Wireframe display style
this method will be called regardless of whether the object will be eventially output,
i.e. even if it's occluded by another element.

#### Parameter `node`

An output node that represents a Curve.

#### Returns

Return RenderNodeAction.Proceed if you wish to receive tessellated geometry
(line or polyline segments) for this curve, or otherwise return RenderNodeAction.Skip.

Note for 2D export: if the export is performed for the view in non-Wireframe display style
tesselated geometry will be output regardless of the return value.

### `T:Autodesk.Revit.DB.IExportContextBase`

Member kind: type
Symbol: `Autodesk.Revit.DB.IExportContextBase`

#### Summary

An interface that as common base for IModelExportContext and IExportContext2D.

### `T:Autodesk.Revit.DB.IPhotoRenderContext`

Member kind: type
Symbol: `Autodesk.Revit.DB.IPhotoRenderContext`

#### Summary

An interface that is used in custom export to render 3D views of a Revit model.

#### Remarks

An instance of a class that implements this interface is passed in as a
parameter of the `T:Autodesk.Revit.DB.CustomExporter` constructor.
The interface methods are then called at times of rendering entities that are
currently visible in the view being rendered.

With this type of export context used to perform a custom export,
Revit will traverse the model and output the model's geometry
as if processing the Render command invoked via the UI. It means
that only such elements that have actual geometry and are suitable
to appear in a rendered view will be processed and output.

#### Since

2016

### `M:Autodesk.Revit.DB.IExportContextProxy.OnPolymesh(Autodesk.Revit.DB.PolymeshTopology)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnPolymesh(Autodesk.Revit.DB.PolymeshTopology)`

#### Summary

This method is called when a tessellated polymesh of a 3d face is being output.

#### Parameter `node`

A node representing topology of the polymesh

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.OnMaterial(Autodesk.Revit.DB.MaterialNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnMaterial(Autodesk.Revit.DB.MaterialNode)`

#### Summary

This method marks a change of the material.

#### Parameter `node`

A node describing the current material.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.OnLight(Autodesk.Revit.DB.LightNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnLight(Autodesk.Revit.DB.LightNode)`

#### Summary

This method marks the beginning of export of a light which is enabled for rendering.

#### Remarks

This method is only called for photo-rendering export (a custom exporter that implements `T:Autodesk.Revit.DB.IPhotoRenderContext` ).

#### Parameter `node`

A node describing the light object.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.OnRPC(Autodesk.Revit.DB.RPCNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnRPC(Autodesk.Revit.DB.RPCNode)`

#### Summary

This method marks the beginning of export of an RPC object.

#### Remarks

This method is only called for photo-rendering export (a custom exporter that implements `T:Autodesk.Revit.DB.IPhotoRenderContext` ).
When an RPC object is encountered for a model context export (a custom exporter that implements `T:Autodesk.Revit.DB.IModelExportContext` ),
the RPC object will be provided as a polymesh (via `M:Autodesk.Revit.DB.IExportContextProxy.OnPolymesh(Autodesk.Revit.DB.PolymeshTopology)` ).

#### Parameter `node`

A node with asset information about the RPC object.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.OnFaceEnd(Autodesk.Revit.DB.FaceNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnFaceEnd(Autodesk.Revit.DB.FaceNode)`

#### Summary

This method marks the end of the current face being exported.

#### Parameter `node`

An output node that represents a Face.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.OnFaceBegin(Autodesk.Revit.DB.FaceNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnFaceBegin(Autodesk.Revit.DB.FaceNode)`

#### Summary

This method marks the beginning of a Face to be exported.

#### Remarks

Note that this method (as well as OnFaceEnd) is invoked only if the custom
exporter was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

#### Parameter `node`

An output node that represents a Face.

#### Returns

Return RenderNodeAction. Proceed if you wish to receive geometry (polymesh)
for this face, or return RenderNodeAction.Skip otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.OnLinkEnd(Autodesk.Revit.DB.LinkNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnLinkEnd(Autodesk.Revit.DB.LinkNode)`

#### Summary

This method marks the end of a link instance being exported.

#### Parameter `node`

An output node that represents a Revit link.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.OnLinkBegin(Autodesk.Revit.DB.LinkNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnLinkBegin(Autodesk.Revit.DB.LinkNode)`

#### Summary

This method marks the beginning of a link instance to be exported.

#### Returns

Return RenderNodeAction.Skip if you wish to skip processing this link instance,
or return RenderNodeAction.Proceed otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.OnInstanceEnd(Autodesk.Revit.DB.InstanceNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnInstanceEnd(Autodesk.Revit.DB.InstanceNode)`

#### Summary

This method marks the end of processing of an Instance Node (e.g. a family instance).

#### Parameter `node`

An output node that represents a family instance.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.OnInstanceBegin(Autodesk.Revit.DB.InstanceNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnInstanceBegin(Autodesk.Revit.DB.InstanceNode)`

#### Summary

This method marks the start of processing of an instance node (e.g. a family instance).

#### Returns

Return RenderNodeAction.Skip if you wish to skip processing this family instance,
or return RenderNodeAction.Proceed otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.OnElementEnd(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnElementEnd(Autodesk.Revit.DB.ElementId)`

#### Summary

This method marks the end of an element being exported.

#### Remarks

This method is never called for 2D export (see cref="Autodesk::Revit::DB::IExportContext2D").

#### Parameter `elementId`

The Id of the element that has just been processed.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.OnElementBegin(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnElementBegin(Autodesk.Revit.DB.ElementId)`

#### Summary

This method marks the beginning of an element to be exported.

#### Remarks

This method is never called for 2D export (see cref="Autodesk::Revit::DB::IExportContext2D").

#### Parameter `elementId`

The Id of the element that is about to be processed.

#### Returns

Return RenderNodeAction.Skip if you wish to skip exporting this element,
or return RenderNodeAction.Proceed otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.OnViewEnd(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnViewEnd(Autodesk.Revit.DB.ElementId)`

#### Summary

This method marks the end of a 3D view being exported.

#### Parameter `elementId`

The Id of the 3D view that has just been processed.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.OnViewBegin(Autodesk.Revit.DB.ViewNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.OnViewBegin(Autodesk.Revit.DB.ViewNode)`

#### Summary

This method marks the beginning of a 3D view to be exported.

#### Parameter `node`

Geometry node associated with the view.

#### Returns

Return RenderNodeAction.Skip if you wish to skip exporting this view,
or return RenderNodeAction.Proceed otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.IsCanceled`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.IsCanceled`

#### Summary

This method is queried at the beginning of every element.

#### Returns

Return True if you wish to cancel the exporting process, or False otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.Finish`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.Finish`

#### Summary

This method is called at the very end of the export process,
after all entities were processed (or after the process was cancelled).

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContextProxy.Start`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContextProxy.Start`

#### Summary

This method is called at the very start of the export process,
still before the first entity of the model was send out.

#### Returns

Return True if you are ready to proceed with processing the export.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnPolymesh(Autodesk.Revit.DB.PolymeshTopology)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnPolymesh(Autodesk.Revit.DB.PolymeshTopology)`

#### Summary

This method is called when a tessellated polymesh of a 3d face is being output.

#### Parameter `node`

A node representing topology of the polymesh

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnMaterial(Autodesk.Revit.DB.MaterialNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnMaterial(Autodesk.Revit.DB.MaterialNode)`

#### Summary

This method marks a change of the material.

#### Parameter `node`

A node describing the current material.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnLight(Autodesk.Revit.DB.LightNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnLight(Autodesk.Revit.DB.LightNode)`

#### Summary

This method marks the beginning of export of a light which is enabled for rendering.

#### Remarks

This method is only called for photo-rendering export (a custom exporter that implements `T:Autodesk.Revit.DB.IPhotoRenderContext` ).

#### Parameter `node`

A node describing the light object.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnRPC(Autodesk.Revit.DB.RPCNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnRPC(Autodesk.Revit.DB.RPCNode)`

#### Summary

This method marks the beginning of export of an RPC object.

#### Remarks

This method is only called for photo-rendering export (a custom exporter that implements `T:Autodesk.Revit.DB.IPhotoRenderContext` ).
When an RPC object is encountered for a model context export (a custom exporter that implements `T:Autodesk.Revit.DB.IModelExportContext` ),
the RPC object will be provided as a polymesh (via `M:Autodesk.Revit.DB.IExportContext.OnPolymesh(Autodesk.Revit.DB.PolymeshTopology)` ).

#### Parameter `node`

A node with asset information about the RPC object.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnFaceEnd(Autodesk.Revit.DB.FaceNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnFaceEnd(Autodesk.Revit.DB.FaceNode)`

#### Summary

This method marks the end of the current face being exported.

#### Parameter `node`

An output node that represents a Face.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnFaceBegin(Autodesk.Revit.DB.FaceNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnFaceBegin(Autodesk.Revit.DB.FaceNode)`

#### Summary

This method marks the beginning of a Face to be exported.

#### Remarks

Note that this method (as well as OnFaceEnd) is invoked only if the custom
exporter was set up to include geometric objects in the output stream.
See `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` for mode details.

#### Parameter `node`

An output node that represents a Face.

#### Returns

Return RenderNodeAction. Proceed if you wish to receive geometry (polymesh)
for this face, or return RenderNodeAction.Skip otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnLinkEnd(Autodesk.Revit.DB.LinkNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnLinkEnd(Autodesk.Revit.DB.LinkNode)`

#### Summary

This method marks the end of a link instance being exported.

#### Parameter `node`

An output node that represents a Revit link.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnLinkBegin(Autodesk.Revit.DB.LinkNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnLinkBegin(Autodesk.Revit.DB.LinkNode)`

#### Summary

This method marks the beginning of a link instance to be exported.

#### Returns

Return RenderNodeAction.Skip if you wish to skip processing this link instance,
or return RenderNodeAction.Proceed otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnInstanceEnd(Autodesk.Revit.DB.InstanceNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnInstanceEnd(Autodesk.Revit.DB.InstanceNode)`

#### Summary

This method marks the end of processing of an Instance Node (e.g. a family instance).

#### Parameter `node`

An output node that represents a family instance.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnInstanceBegin(Autodesk.Revit.DB.InstanceNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnInstanceBegin(Autodesk.Revit.DB.InstanceNode)`

#### Summary

This method marks the start of processing of an instance node (e.g. a family instance).

#### Returns

Return RenderNodeAction.Skip if you wish to skip processing this family instance,
or return RenderNodeAction.Proceed otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnElementEnd(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnElementEnd(Autodesk.Revit.DB.ElementId)`

#### Summary

This method marks the end of an element being exported.

#### Remarks

This method is never called for 2D export (see cref="Autodesk::Revit::DB::IExportContext2D").

#### Parameter `elementId`

The Id of the element that has just been processed.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnElementBegin(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnElementBegin(Autodesk.Revit.DB.ElementId)`

#### Summary

This method marks the beginning of an element to be exported.

#### Remarks

This method is never called for 2D export (see cref="Autodesk::Revit::DB::IExportContext2D").

#### Parameter `elementId`

The Id of the element that is about to be processed.

#### Returns

Return RenderNodeAction.Skip if you wish to skip exporting this element,
or return RenderNodeAction.Proceed otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnViewEnd(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnViewEnd(Autodesk.Revit.DB.ElementId)`

#### Summary

This method marks the end of a 3D view being exported.

#### Parameter `elementId`

The Id of the 3D view that has just been processed.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.OnViewBegin(Autodesk.Revit.DB.ViewNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.OnViewBegin(Autodesk.Revit.DB.ViewNode)`

#### Summary

This method marks the beginning of a 3D view to be exported.

#### Parameter `node`

Geometry node associated with the view.

#### Returns

Return RenderNodeAction.Skip if you wish to skip exporting this view,
or return RenderNodeAction.Proceed otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.IsCanceled`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.IsCanceled`

#### Summary

This method is queried at the beginning of every element.

#### Returns

Return True if you wish to cancel the exporting process, or False otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.Finish`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.Finish`

#### Summary

This method is called at the very end of the export process,
after all entities were processed (or after the process was cancelled).

#### Since

2014

### `M:Autodesk.Revit.DB.IExportContext.Start`

Member kind: method
Symbol: `Autodesk.Revit.DB.IExportContext.Start`

#### Summary

This method is called at the very start of the export process,
still before the first entity of the model was send out.

#### Returns

Return True if you are ready to proceed with processing the export.

#### Since

2014

### `T:Autodesk.Revit.DB.IExportContext`

Member kind: type
Symbol: `Autodesk.Revit.DB.IExportContext`

#### Summary

An interface that is used in custom export to process a Revit model.

#### Remarks

An instance of a class that implements this interface is passed in as a
parameter of the `T:Autodesk.Revit.DB.CustomExporter` constructor.
The methods of the context are then called at times of exporting entities of the model.

This is a base class for two other interfaces derived from it:
`T:Autodesk.Revit.DB.IPhotoRenderContext` and
`T:Autodesk.Revit.DB.IModelExportContext` . This base class contains
methods that are common
to both the leaf interfaces. Although it is still possible to use classes
deriving directly from this base interface (for backward compatibility),
future applications should implement the new leaf interfaces only.

#### Since

2014

### `T:Autodesk.Revit.DB.RenderNodeAction`

Member kind: type
Symbol: `Autodesk.Revit.DB.RenderNodeAction`

#### Summary

Enumerated actions for processing a render node during custom export.

#### Since

2014

### `F:Autodesk.Revit.DB.RenderNodeAction.Skip`

Member kind: field
Symbol: `Autodesk.Revit.DB.RenderNodeAction.Skip`

#### Summary

Instruct the exporter to skip the node. It means the exporter
will not process any child nodes (nor the geometry) of the node.
The respective end-node notification will still be invoked though.

### `F:Autodesk.Revit.DB.RenderNodeAction.Proceed`

Member kind: field
Symbol: `Autodesk.Revit.DB.RenderNodeAction.Proceed`

#### Summary

Instruct the exporter to go on with processing the node. It means
the exporter will continue handling the node by processing all its
child nodes, if it has any, and their geometry where it is relevant.

### `M:Autodesk.Revit.DB.CustomExporter.IsRenderingSupported`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomExporter.IsRenderingSupported`

#### Summary

Checks if view rendering is currently supported in the running instance of Revit.

#### Remarks

A typical reason for rendering not being enabled is when rendering and material
libraries are not currently available in the installed copy of Revit.

#### Returns

Returns True if rendering is currently supported, False otherwise.

#### Since

2014 UR1

### `M:Autodesk.Revit.DB.CustomExporter.Export(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomExporter.Export(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Exports a collection of 3D or 2D views

#### Remarks

Note that the actual export process may differ
depending on the type of export context used. For example, when the
`T:Autodesk.Revit.DB.IModelExportContext` is used,
Revit is likely to perform several rounds of traversing each view, which
may result in invoking the OnViewBegin/OnViewEnd method multiple times
for every one view. It is because Revit draws objects in several layers
(model layer, annotation layer, etc.) and will traverse each layer individually.
In the most common scenario the user will receive two invocations of OnViewBegin/OnViewEnd:
In the first round, all model entities will be received, while in the second round
all text annotation elements will be received, if any present in the given view.

Note that all views in the collection must be either 3D or 2D views and they must match the exporter context.

Note that currently the only 2D view types exported are `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects` FloorPlan, CeilingPlan,Elevation, Section, Detail, EngineeringPlan, AreaPlan.

#### Parameter `viewIds`

An array of views to export

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more elements in viewIds is not a valid exportable view.
For example, templates are not considered valid views to export.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The instance of IExportContext is not valid.
-or-
Rendering is currently not supported in the running instance of Revit.
One reason for that to happen is that rendering and material libraries
are not currently available.

#### Since

2014

### `M:Autodesk.Revit.DB.CustomExporter.Export(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomExporter.Export(Autodesk.Revit.DB.View)`

#### Summary

Exports one 3D or 2D view

#### Remarks

Note that the actual export process may differ
depending on the type of export context used. For example, when the
`T:Autodesk.Revit.DB.IModelExportContext` is used,
Revit is likely to perform several rounds of traversing each view, which
may result in invoking the OnViewBegin/OnViewEnd method multiple times
for every one view. It is because Revit draws objects in several layers
(model layer, annotation layer, etc.) and will traverse each layer individually.
In the most common scenario the user will receive two invocations of OnViewBegin/OnViewEnd:
In the first round, all model entities will be received, while in the second round
all text annotation elements will be received, if any present in the given view.

#### Parameter `view`

An instance of the view to export

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The view is not exportable, such as a template view or wrong type view, for example.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The instance of IExportContext is not valid.
-or-
Rendering is currently not supported in the running instance of Revit.
One reason for that to happen is that rendering and material libraries
are not currently available.

#### Since

2014

### `P:Autodesk.Revit.DB.CustomExporter.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomExporter.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.CustomExporter.Export2DForceDisplayStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomExporter.Export2DForceDisplayStyle`

#### Summary

This value tells the exporter of 2D views to force the given display mode for the view.

#### Remarks

Only DisplayStyle::Wireframe and DisplayStyle::HLR values are supported.
Default forced value is DisplayStyle::HLR unless the view has DisplayStyle:Wireframe.

See notes for 2D export for views in non-Wireframe display style in `!:Autodesk::Revit::DB::IExportContextBase` and `T:Autodesk.Revit.DB.IExportContext2D` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020

### `P:Autodesk.Revit.DB.CustomExporter.Export2DIncludingAnnotationObjects`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomExporter.Export2DIncludingAnnotationObjects`

#### Summary

This flag sets the exporter of 2D views to either include or exclude
output of annotation objects
when the model is being processed by the export context.

#### Remarks

A convenient way of determining whether an element category is annotation is using `!:Autodesk::Revit::DB::Category::CategoryType` .

#### Since

2020

### `P:Autodesk.Revit.DB.CustomExporter.Export2DGeometricObjectsIncludingPatternLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomExporter.Export2DGeometricObjectsIncludingPatternLines`

#### Summary

This flag sets the exporter of 2D views to either include or exclude
output of face pattern lines as part of geometric objects
when the model is being processed by the export context.

#### Remarks

This flag is ignored if view has Wireframe display style.
This flag is ignored unless property "IncludeGeometricObjects" is set to true.

#### Since

2020

### `P:Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomExporter.IncludeGeometricObjects`

#### Summary

This flag sets the exporter to either include or exclude
output of geometric objects such as faces and curves
when the model is being processed by the export context.

#### Remarks

If geometric objects are to be excluded, the context will not
receive any of the calls to related to Faces or Curves. However, the
objects will be still processed by Revit resulting in exporting their
tessellated geometry in form of polymeshes or lines, respectivelly.

Regardless of the value of this property, the export context
must always implement the methods related to receiving of geometric
objects (e.g. OnFaceStart, OnFaceEnd, OnCurve, etc.), even though
the methods may never be invoked.

Setting this property to False allows clients to significantly speed up
the export process. If the export context does not need to examine geometric
objects, it is recommended setting this property to False, which will make
the export process faster even when compared with export during which
notifications about geometric objects are sent, but ignored by the context.

#### Since

2014

### `P:Autodesk.Revit.DB.CustomExporter.ShouldStopOnError`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomExporter.ShouldStopOnError`

#### Summary

This flag instructs the exporting process to either stop or continue
in case an error occurs during any of the exporting methods.

#### Since

2014

### `M:Autodesk.Revit.DB.CustomExporter.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.IExportContext)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomExporter.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.IExportContext)`

#### Summary

Constructs a new instance of a CustomExporter for a given document
using the input instance of IExportContext as the output device.

#### Remarks

The input context should be an instance of a class that implements
either `T:Autodesk.Revit.DB.IModelExportContext`
or `T:Autodesk.Revit.DB.IPhotoRenderContext` interfaces.

#### Parameter `document`

The document containing the model to be exported

#### Parameter `context`

An instance of a context class that will be consuming the output

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.CustomExporter`

Member kind: type
Symbol: `Autodesk.Revit.DB.CustomExporter`

#### Summary

A class that allows exporting 3D or 2D views via an export context.

#### Remarks

The Export method of this class triggers standard rendering or exporting
process in Revit, but instead of displaying the result on screen or printer,
the output is channeled through the given custom context that handles
processing of the geometric as well as non-geometric information.

Revit will process the exporting algorithm depending on the type
of given context. If an instance of `T:Autodesk.Revit.DB.IPhotoRenderContext`
is used, then Revit will output the model as if executing the Render command,
thus only such entities that would be visible in a rendered view
will be sent to the context.

Alternatively, if an instance of `T:Autodesk.Revit.DB.IModelExportContext`
is used, Revit will output the model as if exporting it to a CAD format,
a process which results outputting also objects that would not
appear in a rendered image, such as model curves and text annotations.

For 2D views, an instance of `T:Autodesk.Revit.DB.IExportContext2D`
has to be used. Revit will output the contents of the 2D view as it is displayed on the screen.
Export can be modified by setting properties pertaining to 2D views:
`P:Autodesk.Revit.DB.CustomExporter.Export2DGeometricObjectsIncludingPatternLines` ,
`P:Autodesk.Revit.DB.CustomExporter.Export2DIncludingAnnotationObjects` .
`P:Autodesk.Revit.DB.CustomExporter.Export2DForceDisplayStyle` .

See notes for 2D export in `T:Autodesk.Revit.DB.IExportContext2D` .

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Coefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Coefficient`

#### Summary

The coefficient of the duct.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.PressureDrop`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.PressureDrop`

#### Summary

The pressure drop of the duct. Units: (kg/(ftÂ·sÂ²)).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Friction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Friction`

#### Summary

The friction of the duct. Units: (kg/(ftÂ²Â·sÂ²)).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.VelocityPressure`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.VelocityPressure`

#### Summary

The velocity pressure of the duct. Units: (kg/(ftÂ·sÂ²)).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Velocity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Velocity`

#### Summary

The velocity of the duct. Units: (ft/s).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.ReynoldsNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.ReynoldsNumber`

#### Summary

The reynolds number of the duct.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.HydraulicDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.HydraulicDiameter`

#### Summary

The hydraulic diameter of the duct. Units: (ft).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.EquivalentDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.EquivalentDiameter`

#### Summary

The equivalent diameter of the duct. Units: (ft).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Flow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Flow`

#### Summary

The flow of the duct. Units: (ftÂ³/s).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Roughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Roughness`

#### Summary

The roughness of the duct. Units: (ft).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Viscosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Viscosity`

#### Summary

The viscosity of the duct. Units: (kg/(ftÂ·s)).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Density`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Density`

#### Summary

The density of the duct.Units: (kg/ftÂ³).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Length`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Length`

#### Summary

The length of the duct. Units: (ft).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.WidthOrDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.WidthOrDiameter`

#### Summary

The diameter of the duct with round profile, or the width of the duct with other profiles. Units: (ft).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Height`

#### Summary

The height of the duct. If the duct is round, it will be equal to the diameter of the duct. Units: (ft).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.CategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.CategoryId`

#### Summary

The category id of duct curves. It will be OST_DuctCurves, OST_FlexDuctCurves, or OST_PlaceHolderDucts.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Shape`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Shape`

#### Summary

The profile type of the duct.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Level`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData.Level`

#### Summary

The calculation level of the system.

#### Remarks

If the calculation level is Flow, all parameters that need friction will be displayed as "Not Computed" in Properties dialog (Friction, Pressure Drop, Loss Coefficient).
If the calculation level is None, all parameters that need flow will be displayed as "Not Computed" in Properties dialog (Velocity, Velocity Pressure, Reynolds number, Friction, Pressure Drop, Loss Coefficient).
If the calculation level is All, all parameters will be displayed with their actual values in Properties dialog.

#### Since

2014

### `T:Autodesk.Revit.DB.Mechanical.DuctPressureDropData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctPressureDropData`

#### Summary

The input and output data used by external servers for calculation of the duct pressure drop.

#### Remarks

Profile type, Height, Diameter for round profile or width for other profiles, Length, Density, Viscosity, Roughness and Flow are input field values for the calculation. HydraulicDiameter, ReynoldsNumber, Velocity, VelocityPressure, Friction, PressureDrop, and Coefficient are output field values for the calculation

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.IDuctPressureDropServerProxy.GetHtmlDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctPressureDropServerProxy.GetHtmlDescription`

#### Summary

The method that Revit will invoke to get an HTML formatted description of the server.

#### Remarks

The HTML description is used by Revit unless it is empty or the server is not available, in which case, Revit will use the plain text description from IExternalServer.GetDescription().

#### Returns

The HTML format description of the server.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.IDuctPressureDropServerProxy.GetInformationLink`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctPressureDropServerProxy.GetInformationLink`

#### Summary

The method that Revit will invoke to obtain a URL address which provides more information about the server.

#### Returns

The URL providing server information.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.IDuctPressureDropServerProxy.Calculate(Autodesk.Revit.DB.Mechanical.DuctPressureDropData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctPressureDropServerProxy.Calculate(Autodesk.Revit.DB.Mechanical.DuctPressureDropData)`

#### Summary

Calculate the duct pressure drop.

#### Parameter `data`

The input and output data of the calculation.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.IDuctPressureDropServer.GetHtmlDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctPressureDropServer.GetHtmlDescription`

#### Summary

The method that Revit will invoke to get an HTML formatted description of the server.

#### Remarks

The HTML description is used by Revit unless it is empty or the server is not available, in which case, Revit will use the plain text description from IExternalServer.GetDescription().

#### Returns

The HTML format description of the server.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.IDuctPressureDropServer.GetInformationLink`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctPressureDropServer.GetInformationLink`

#### Summary

The method that Revit will invoke to obtain a URL address which provides more information about the server.

#### Returns

The URL providing server information.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.IDuctPressureDropServer.Calculate(Autodesk.Revit.DB.Mechanical.DuctPressureDropData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctPressureDropServer.Calculate(Autodesk.Revit.DB.Mechanical.DuctPressureDropData)`

#### Summary

Calculate the duct pressure drop.

#### Parameter `data`

The input and output data of the calculation.

#### Since

2014

### `T:Autodesk.Revit.DB.Mechanical.IDuctPressureDropServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctPressureDropServer`

#### Summary

Interface for external servers implementing duct pressure drop calculation.

#### Remarks

A typical way to use the external server can be:
Implement a server class that derives from this interface

Create a new server object and register it with the service, see `!:Autodesk.Revit.DB.ExternalService.ExternalServiceRegistry` .

Assign server for the duct pressure drop calculation in `!:Autodesk.Revit.DB.Mechanical.DuctSettings` .

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData.SetDefaultEntity(Autodesk.Revit.DB.ExtensibleStorage.Entity)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData.SetDefaultEntity(Autodesk.Revit.DB.ExtensibleStorage.Entity)`

#### Summary

Stores the default entity in the data.

#### Parameter `defaultEntity`

The Entity to be stored.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Writing of Entities of this Schema is not allowed to the current add-in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData.GetPresureDropItems`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData.GetPresureDropItems`

#### Summary

Returns the pressure drop items.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData.GetDuctFittingAndAccessoryData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData.GetDuctFittingAndAccessoryData`

#### Summary

Returns the fitting and accessory information.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData.IsCurrentEntityValid`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData.IsCurrentEntityValid`

#### Summary

True if the current settings stored in the entity is valid.

#### Since

2017

### `P:Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData.CalculationType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData.CalculationType`

#### Summary

The calculation type, a bitmask of FittingAndAccessoryCalculationType.

#### Since

2014

### `T:Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData`

#### Summary

The input and output data used by external servers for calculation of the duct fitting and duct accessory pressure drop.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem.Coefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem.Coefficient`

#### Summary

The coefficient between the begin connector and end connector, Units: (kg/(ftÂ·sÂ²)).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem.VelocityPressure`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem.VelocityPressure`

#### Summary

The velocity pressure, for converting between coefficient and pressure drop on this flow path. Units: (kg/(ftÂ·sÂ²)).

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem.EndConnectorIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem.EndConnectorIndex`

#### Summary

The index of the end conector of the flow path.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem.BeginConnectorIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem.BeginConnectorIndex`

#### Summary

The index of the begin connector of the flow path.

#### Since

2014

### `T:Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem`

#### Summary

A flow path of the duct/pipe fitting and accessory. It is defined by the begin connector and end connector.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServerProxy.GetDataSchema`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServerProxy.GetDataSchema`

#### Summary

Obtains the schema of the ESEntity.

#### Returns

Null if the server has no data.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServerProxy.IsApplicable(Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServerProxy.IsApplicable(Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData)`

#### Summary

Check if the server is applicable for the duct fitting or duct accessory.

#### Parameter `data`

The input data of the calculation.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServerProxy.Calculate(Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServerProxy.Calculate(Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData)`

#### Summary

Calculate the duct fitting and duct accessory coefficient.

#### Parameter `data`

The input and output data of the calculation.

#### Returns

True if calculation succeeds.
False if calculation fails.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServer.GetDataSchema`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServer.GetDataSchema`

#### Summary

Obtains the schema of the ESEntity.

#### Returns

Null if the server has no data.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServer.IsApplicable(Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServer.IsApplicable(Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData)`

#### Summary

Check if the server is applicable for the duct fitting or duct accessory.

#### Parameter `data`

The input data of the calculation.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServer.Calculate(Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServer.Calculate(Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData)`

#### Summary

Calculate the duct fitting and duct accessory coefficient.

#### Parameter `data`

The input and output data of the calculation.

#### Returns

True if calculation succeeds.
False if calculation fails.

#### Since

2014

### `T:Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServer`

#### Summary

Interface class for external servers implementing duct fitting and duct accessory coefficient calculation.

#### Remarks

A typical way to use the external server can be:
Implement a server class that derives from this interface

Create a new server object and register it with the service, see `!:Autodesk.Revit.DB.ExternalService.ExternalServiceRegistry` .

Assign server to duct fitting instance.

#### Since

2014

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DHandleServerProxy.Match(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DHandleServerProxy.Match(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns true if current server represents the specified handle / instance.

#### Since

2023

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DHandleServerProxy.GetHandleId`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DHandleServerProxy.GetHandleId`

#### Summary

Reports the id of the Handle element that the server is associated with.

#### Remarks

In the current release servers that use handle elements can only work with internal addins.

Third-party implementers should return ElementId.invalidElementId.

#### Returns

The id of the Handle element.

#### Since

2021

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DHandleServer.Match(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DHandleServer.Match(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns true if current server represents the specified handle / instance.

#### Since

2023

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DHandleServer.GetHandleId`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DHandleServer.GetHandleId`

#### Summary

Reports the id of the Handle element that the server is associated with.

#### Remarks

In the current release servers that use handle elements can only work with internal addins.

Third-party implementers should return ElementId.invalidElementId.

#### Returns

The id of the Handle element.

#### Since

2021

### `T:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DHandleServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DHandleServer`

#### Summary

The interface to be implemented by a server that is connected to a handle.

#### Since

2021

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.RenderScene(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DisplayStyle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.RenderScene(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DisplayStyle)`

#### Summary

Performs rendering of the scene that the server creates.

#### Remarks

The representation of geometry is in terms of a set of vertex and index buffers. The server can
use facilities in Autodesk::Revit::DB::DirectContext3D::DrawContext to
create the buffers and fill them with data that encode primitives such as triangles, lines, and points.
The server can also adjust the geometry that it submits based on the argument to RenderScene() and in
response to certain rendering parameters whose values are available through DrawContext (e.g., clip planes).

The final step in the process of submitting geometry for rendering is to call DrawContext::FlushBuffer()
for the appropriate buffers.

This interface method may be called in a separate thread from the others.

#### Parameter `dBView`

The view where rendering will occur.

#### Parameter `displayStyle`

The display style of the view in which the submitted geometry will be drawn.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.UseInTransparentPass(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.UseInTransparentPass(Autodesk.Revit.DB.View)`

#### Summary

Indicates whether this server will submit geometry during the rendering pass for transparent geometry.

#### Remarks

Transparent geometry is rendered in a separate pass following the opaque geometry. If a server
returns true from UseInTransparentPass(), it can provide geometry for rendering in either pass using
the RenderScene() method. Otherwise, the server will be called to submit only opaque
geometry.

The server has a way to determine whether it should submit opaque or transparent geometry when
RenderScene() is called
(see Autodesk::Revit::DB::DirectContext3D::DrawContext::IsTransparentPass(void)).

#### Parameter `dBView`

The view where rendering will occur.

#### Returns

True if the server needs to render transparent geometry, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.GetBoundingBox(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.GetBoundingBox(Autodesk.Revit.DB.View)`

#### Summary

Reports a bounding box of the geometry that this server submits for drawing.

#### Remarks

Revit uses the bounding box when navigating views, e.g., when a Zoom to Fit command is issued.
The reported bounding box does not have to be tight. However, there may be unintended side-effects
if the box is inconsistent with the submitted geometry.

#### Parameter `dBView`

The view where rendering will occur. If this argument is `null` , a view-independent bounding box should be reported.

#### Returns

The bounding box as an Outline.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.UsesHandles`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.UsesHandles`

#### Summary

Tests whether this server uses DirectContext3D handle elements.

#### Remarks

In the current release servers that use handle elements can only work with internal addins.

Third-party implementers should return 'false'.

#### Returns

True if the server needs to use DirectContext3D handle elements, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.GetSourceId`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.GetSourceId`

#### Summary

Reports this server's source ID.

#### Returns

The source ID.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.GetApplicationId`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.GetApplicationId`

#### Summary

Reports this server's application ID.

#### Returns

The application ID.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.CanExecute(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServerProxy.CanExecute(Autodesk.Revit.DB.View)`

#### Summary

Can be used to allow the server to execute only in certain views.

#### Remarks

Execution of a DirectContext3D server means that the server is called upon to contribute a bounding box
and graphics content (opaque and transparent) for an opened view. The following are some of the conditions
that control whether the server is executed:

The return value of this interface method.

Whether the server is one of the active servers for the service.

For servers that use DirectContext3D handles, the visibility of handle instances.

#### Parameter `dBView`

The view where rendering will occur.

#### Returns

True if the server can be executed in the provided view, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.RenderScene(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DisplayStyle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.RenderScene(Autodesk.Revit.DB.View,Autodesk.Revit.DB.DisplayStyle)`

#### Summary

Performs rendering of the scene that the server creates.

#### Remarks

The representation of geometry is in terms of a set of vertex and index buffers. The server can
use facilities in Autodesk::Revit::DB::DirectContext3D::DrawContext to
create the buffers and fill them with data that encode primitives such as triangles, lines, and points.
The server can also adjust the geometry that it submits based on the argument to RenderScene() and in
response to certain rendering parameters whose values are available through DrawContext (e.g., clip planes).

The final step in the process of submitting geometry for rendering is to call DrawContext::FlushBuffer()
for the appropriate buffers.

This interface method may be called in a separate thread from the others.

#### Parameter `dBView`

The view where rendering will occur.

#### Parameter `displayStyle`

The display style of the view in which the submitted geometry will be drawn.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.UseInTransparentPass(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.UseInTransparentPass(Autodesk.Revit.DB.View)`

#### Summary

Indicates whether this server will submit geometry during the rendering pass for transparent geometry.

#### Remarks

Transparent geometry is rendered in a separate pass following the opaque geometry. If a server
returns true from UseInTransparentPass(), it can provide geometry for rendering in either pass using
the RenderScene() method. Otherwise, the server will be called to submit only opaque
geometry.

The server has a way to determine whether it should submit opaque or transparent geometry when
RenderScene() is called
(see Autodesk::Revit::DB::DirectContext3D::DrawContext::IsTransparentPass(void)).

#### Parameter `dBView`

The view where rendering will occur.

#### Returns

True if the server needs to render transparent geometry, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.GetBoundingBox(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.GetBoundingBox(Autodesk.Revit.DB.View)`

#### Summary

Reports a bounding box of the geometry that this server submits for drawing.

#### Remarks

Revit uses the bounding box when navigating views, e.g., when a Zoom to Fit command is issued.
The reported bounding box does not have to be tight. However, there may be unintended side-effects
if the box is inconsistent with the submitted geometry.

#### Parameter `dBView`

The view where rendering will occur. If this argument is `null` , a view-independent bounding box should be reported.

#### Returns

The bounding box as an Outline.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.UsesHandles`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.UsesHandles`

#### Summary

Tests whether this server uses DirectContext3D handle elements.

#### Remarks

In the current release servers that use handle elements can only work with internal addins.

Third-party implementers should return 'false'.

#### Returns

True if the server needs to use DirectContext3D handle elements, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.GetSourceId`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.GetSourceId`

#### Summary

Reports this server's source ID.

#### Returns

The source ID.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.GetApplicationId`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.GetApplicationId`

#### Summary

Reports this server's application ID.

#### Returns

The application ID.

#### Since

2018

### `M:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.CanExecute(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer.CanExecute(Autodesk.Revit.DB.View)`

#### Summary

Can be used to allow the server to execute only in certain views.

#### Remarks

Execution of a DirectContext3D server means that the server is called upon to contribute a bounding box
and graphics content (opaque and transparent) for an opened view. The following are some of the conditions
that control whether the server is executed:

The return value of this interface method.

Whether the server is one of the active servers for the service.

For servers that use DirectContext3D handles, the visibility of handle instances.

#### Parameter `dBView`

The view where rendering will occur.

#### Returns

True if the server can be executed in the provided view, false otherwise.

#### Since

2018

### `T:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer`

#### Summary

The interface to be implemented by a server of the DirectContext3D external service.

#### Since

2018

### `M:Autodesk.Revit.DB.IDataConversionMonitorProxy.GetVerbosity`

Member kind: method
Symbol: `Autodesk.Revit.DB.IDataConversionMonitorProxy.GetVerbosity`

#### Summary

Reports requested verbosity level

#### Since

2016

### `M:Autodesk.Revit.DB.IDataConversionMonitorProxy.ProcessMessage(Autodesk.Revit.DB.DataExchangeMessageId,Autodesk.Revit.DB.DataExchangeMessageSeverity,System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.IDataConversionMonitorProxy.ProcessMessage(Autodesk.Revit.DB.DataExchangeMessageId,Autodesk.Revit.DB.DataExchangeMessageSeverity,System.Collections.Generic.IList{System.String})`

#### Summary

The default implementation ignores input and always returns true. The using app should override the behavior as necessary.
Some examples of overridden behavior are
1. Someone is developing a classic Revit add-on that imports STEP AP 203 solids. She will implement a log object such that
a) At each imported face (logMessage() called with LogMessage::FaceCreated as first argument) the log object will update
count of imported faces and call an application-specific progress indicator where appropriate
b) If the app gets a cancel request between the calls to logMessage(), the next call will return false.
The Import API will then cancel the conversion and clean up the intermediate data.
2. Someone is implementing a web service to convert IFC files to RVT. As a part of that service UI, the user would like
to cancel the conversion on the first error in order to avoid being charged for storage/processor time.
The implementation of logMessage() in that case would be different: the cancellation request would be based on severity of the error.
The app would probably want to keep a detailed count of entities converted.
3. Someone is implementing an IFC importer. Each API call is fast enough that cancelation/progress requests are handled by the application.
Problems with data should be reported to the user, but the conversion should go on regardless. The app collects its own conversion statistics.
The app developer implements logMessage() to accumulate reported errors and appends the formatted results to her conversion report.
The overloaded logMessage() always returns true, since all cancellations are handled by the app.

#### Parameter `messageId`

Indicates a specific event during data conversion.

#### Parameter `messageSeverity`

Indicates a severity of the event.

#### Parameter `entityIds`

Input objects affected by the reported event.

#### Returns

If the function returns true, the import API will continue conversion. Otherwise, it will be cancelled and all intermediate data reset.

#### Since

2016

### `M:Autodesk.Revit.DB.IDataConversionMonitor.GetVerbosity`

Member kind: method
Symbol: `Autodesk.Revit.DB.IDataConversionMonitor.GetVerbosity`

#### Summary

Reports requested verbosity level

#### Since

2016

### `M:Autodesk.Revit.DB.IDataConversionMonitor.ProcessMessage(Autodesk.Revit.DB.DataExchangeMessageId,Autodesk.Revit.DB.DataExchangeMessageSeverity,System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.IDataConversionMonitor.ProcessMessage(Autodesk.Revit.DB.DataExchangeMessageId,Autodesk.Revit.DB.DataExchangeMessageSeverity,System.Collections.Generic.IList{System.String})`

#### Summary

The default implementation ignores input and always returns true. The using app should override the behavior as necessary.
Some examples of overridden behavior are
1. Someone is developing a classic Revit add-on that imports STEP AP 203 solids. She will implement a log object such that
a) At each imported face (logMessage() called with LogMessage::FaceCreated as first argument) the log object will update
count of imported faces and call an application-specific progress indicator where appropriate
b) If the app gets a cancel request between the calls to logMessage(), the next call will return false.
The Import API will then cancel the conversion and clean up the intermediate data.
2. Someone is implementing a web service to convert IFC files to RVT. As a part of that service UI, the user would like
to cancel the conversion on the first error in order to avoid being charged for storage/processor time.
The implementation of logMessage() in that case would be different: the cancellation request would be based on severity of the error.
The app would probably want to keep a detailed count of entities converted.
3. Someone is implementing an IFC importer. Each API call is fast enough that cancelation/progress requests are handled by the application.
Problems with data should be reported to the user, but the conversion should go on regardless. The app collects its own conversion statistics.
The app developer implements logMessage() to accumulate reported errors and appends the formatted results to her conversion report.
The overloaded logMessage() always returns true, since all cancellations are handled by the app.

#### Parameter `messageId`

Indicates a specific event during data conversion.

#### Parameter `messageSeverity`

Indicates a severity of the event.

#### Parameter `entityIds`

Input objects affected by the reported event.

#### Returns

If the function returns true, the import API will continue conversion. Otherwise, it will be cancelled and all intermediate data reset.

#### Since

2016

### `T:Autodesk.Revit.DB.IDataConversionMonitor`

Member kind: type
Symbol: `Autodesk.Revit.DB.IDataConversionMonitor`

#### Summary

A base class for an application-specific logger. It should be used to track errors during conversion and/or , track conversion progress, cancel a conversion process if necessary.
Implementing a logger class is optional, but highly recommended for all but most basic data converters.
The base class is UI- and language-independent. It is up to the using app to implement UI. Language-specifc data may be used to communicate information to application users.
English should be used to communicate data of interest to Revit development.

#### Since

2016

### `T:Autodesk.Revit.DB.DataExchangeMessageVerbosity`

Member kind: type
Symbol: `Autodesk.Revit.DB.DataExchangeMessageVerbosity`

#### Summary

Predefined verbosity levels for DataExchangeLog

#### Since

2016

#### Since

2016

### `F:Autodesk.Revit.DB.DataExchangeMessageVerbosity.Verbose`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageVerbosity.Verbose`

#### Summary

All events are reported.

### `F:Autodesk.Revit.DB.DataExchangeMessageVerbosity.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageVerbosity.Default`

#### Summary

Default verbosity. Warnings, errors, fatal errors are reported.

### `F:Autodesk.Revit.DB.DataExchangeMessageVerbosity.Minimal`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageVerbosity.Minimal`

#### Summary

Minimal verbosity. Only fatal errors are reported.

### `T:Autodesk.Revit.DB.DataExchangeMessageId`

Member kind: type
Symbol: `Autodesk.Revit.DB.DataExchangeMessageId`

#### Summary

Predefined message ids for DataExchangeLog.

#### Since

2016

#### Since

2016

### `F:Autodesk.Revit.DB.DataExchangeMessageId.EmptyObject`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageId.EmptyObject`

#### Summary

A warning level message. The conversion encountered an object with no data to convert. The object will be ignored. This may indicate a problem with incoming data.

### `F:Autodesk.Revit.DB.DataExchangeMessageId.InvalidRenderingStyle`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageId.InvalidRenderingStyle`

#### Summary

An error message. The conversion code was unable to process a render style. The created model will differ in visual appearance.

### `F:Autodesk.Revit.DB.DataExchangeMessageId.ObjectNotConverted`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageId.ObjectNotConverted`

#### Summary

An error message. The conversion code was unable to process a valid supported source object.

### `F:Autodesk.Revit.DB.DataExchangeMessageId.ObjectNotSupported`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageId.ObjectNotSupported`

#### Summary

A warning message. A source object was not converted.

### `F:Autodesk.Revit.DB.DataExchangeMessageId.GenericError`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageId.GenericError`

#### Summary

A catch-all error code. Used for errors that are not enumerated explicitly.

### `F:Autodesk.Revit.DB.DataExchangeMessageId.InvalidDataSet`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageId.InvalidDataSet`

#### Summary

No data could be imported. Would typically be reported as a error. May be reported as a fatal error.

### `F:Autodesk.Revit.DB.DataExchangeMessageId.InvalidSourceObject`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageId.InvalidSourceObject`

#### Summary

An error message. A source object was found to be invalid.

### `F:Autodesk.Revit.DB.DataExchangeMessageId.UnexpectedResult`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageId.UnexpectedResult`

#### Summary

Unexpected result produced by a data conversion operation. Conversion may continue, but the results should be carefully reviewed.

### `F:Autodesk.Revit.DB.DataExchangeMessageId.ObjectCreated`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageId.ObjectCreated`

#### Summary

An informational message. An object - a face, edge, solid, etc. - has been created successfully.

### `F:Autodesk.Revit.DB.DataExchangeMessageId.UnitOfProgressCompleted`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageId.UnitOfProgressCompleted`

#### Summary

That message will be sent at reasonable intervals to provide the using application an opportunity to update its progress indicator.

### `F:Autodesk.Revit.DB.DataExchangeMessageId.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageId.None`

#### Summary

No message.

### `T:Autodesk.Revit.DB.DataExchangeMessageSeverity`

Member kind: type
Symbol: `Autodesk.Revit.DB.DataExchangeMessageSeverity`

#### Summary

Error levels for DataExchangeLog

#### Since

2016

#### Since

2016

### `F:Autodesk.Revit.DB.DataExchangeMessageSeverity.FatalError`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageSeverity.FatalError`

#### Summary

A serious problem that makes further data conversion pointless. The conversion process will be cancelled.

### `F:Autodesk.Revit.DB.DataExchangeMessageSeverity.Error`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageSeverity.Error`

#### Summary

A problem. The converted data should be carefully examined and/or compared to the source data. The application may want to cancel the conversion process.

### `F:Autodesk.Revit.DB.DataExchangeMessageSeverity.Warning`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageSeverity.Warning`

#### Summary

A potential problem. The converted data should be carefully examined and/or compared to the source data

### `F:Autodesk.Revit.DB.DataExchangeMessageSeverity.Info`

Member kind: field
Symbol: `Autodesk.Revit.DB.DataExchangeMessageSeverity.Info`

#### Summary

Informational message, such as successful creation fo a face, edge or a solid.

### `M:Autodesk.Revit.DB.CustomFieldGraphics.GetComputedGraphics`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldGraphics.GetComputedGraphics`

#### Summary

Gets the computed graphics.

#### Returns

Returns the computed graphics.

### `M:Autodesk.Revit.DB.CustomFieldGraphics.ClearComputedGraphics`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldGraphics.ClearComputedGraphics`

#### Summary

Removes all the graphics that were added.

### `M:Autodesk.Revit.DB.CustomFieldGraphics.AddComputedGraphics(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldGraphics.AddComputedGraphics(System.Collections.Generic.IList{Autodesk.Revit.DB.GeometryObject})`

#### Summary

Fills in the computed graphics for Revit to display in the schedule cell.
There is no check to see if the computed graphics fit the cell.
The schedule cell width is defined by `P:Autodesk.Revit.DB.CustomFieldOneRowData.CellWidth` and schedule cell height by `P:Autodesk.Revit.DB.CustomFieldOneRowData.CellHeight` .
The graphics should lie into a plane parallel with XOY.

#### Parameter `computedGraphics`

The computed graphics.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.CustomFieldGraphics.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldGraphics.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.CustomFieldGraphics.Varies`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldGraphics.Varies`

#### Summary

This is the bool which holds if the row items have the same custom graphic representation or not.
If this is true, the computed graphics property will be discarded and, in the cell, will appear a text that indicates that the items have different custom graphic representation.
If it is false, the graphics that were added will be displayed.
The default value stored by this class is false.

### `M:Autodesk.Revit.DB.CustomFieldGraphics.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldGraphics.#ctor`

#### Summary

Constructs a new instance of a CustomFieldGraphics

### `T:Autodesk.Revit.DB.CustomFieldGraphics`

Member kind: type
Symbol: `Autodesk.Revit.DB.CustomFieldGraphics`

#### Summary

Class where can be set the computed graphics for one row, and the information if the graphics varies or not for the items grouped on that row.

### `M:Autodesk.Revit.DB.CustomFieldOneRowData.GetScheduleItems`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldOneRowData.GetScheduleItems`

#### Summary

Gets all the items that are grouped on this row.

#### Returns

Returns all the items that are grouped on this row.

### `P:Autodesk.Revit.DB.CustomFieldOneRowData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldOneRowData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.CustomFieldOneRowData.CellHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldOneRowData.CellHeight`

#### Summary

The height of the cell.

### `P:Autodesk.Revit.DB.CustomFieldOneRowData.CellWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldOneRowData.CellWidth`

#### Summary

The width of the cell.

### `T:Autodesk.Revit.DB.CustomFieldOneRowData`

Member kind: type
Symbol: `Autodesk.Revit.DB.CustomFieldOneRowData`

#### Summary

Class holding the information for one single row needed to compute the value or the graphics.

### `P:Autodesk.Revit.DB.CustomFieldValue.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldValue.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.CustomFieldValue.ValueComputationResult`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldValue.ValueComputationResult`

#### Summary

Identifies the result of the computation of the value.
The default value stored by this class is CustomFieldValueComputaionResult.ItemsDontHaveValue.

### `P:Autodesk.Revit.DB.CustomFieldValue.IntegerFieldValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldValue.IntegerFieldValue`

#### Summary

Identifies a computed value for the schedule items of int type.
The default value stored by this class is 0.

### `P:Autodesk.Revit.DB.CustomFieldValue.DoubleFieldValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldValue.DoubleFieldValue`

#### Summary

Identifies a computed value for the schedule items of double type.
The default value stored by this class is 0.0.

### `P:Autodesk.Revit.DB.CustomFieldValue.StringFieldValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldValue.StringFieldValue`

#### Summary

Identifies a computed value for the schedule items of string type.
The default value stored by this class is "".

### `M:Autodesk.Revit.DB.CustomFieldValue.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldValue.#ctor`

#### Summary

Constructs a new instance of a CustomFieldValue.

### `T:Autodesk.Revit.DB.CustomFieldValue`

Member kind: type
Symbol: `Autodesk.Revit.DB.CustomFieldValue`

#### Summary

Class where can be set the computed value and the result of the computation.

### `T:Autodesk.Revit.DB.CustomFieldValueComputaionResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.CustomFieldValueComputaionResult`

#### Summary

Describes the result of the computation of the value for a list of schedule items.

### `F:Autodesk.Revit.DB.CustomFieldValueComputaionResult.ItemsHaveDifferentValues`

Member kind: field
Symbol: `Autodesk.Revit.DB.CustomFieldValueComputaionResult.ItemsHaveDifferentValues`

#### Summary

The value can't be computed because the items have different values. In this case in the schedule cell will be written a text that indicates that the items have different values.

### `F:Autodesk.Revit.DB.CustomFieldValueComputaionResult.ItemsDontHaveValue`

Member kind: field
Symbol: `Autodesk.Revit.DB.CustomFieldValueComputaionResult.ItemsDontHaveValue`

#### Summary

The value can't be computed because the items don't have a value. In this case the schedule cell will be empty.

### `F:Autodesk.Revit.DB.CustomFieldValueComputaionResult.Success`

Member kind: field
Symbol: `Autodesk.Revit.DB.CustomFieldValueComputaionResult.Success`

#### Summary

The value was computed successfully. In this case the value will be shown in the schedule.

### `M:Autodesk.Revit.DB.CustomFieldNecessaryData.GetNecessarySpecTypeIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldNecessaryData.GetNecessarySpecTypeIds`

#### Summary

Gets the specs that describes the data type that are needed to compute the value/graphics of this custom field.

#### Returns

Returns the specs that describes the data type that are needed to compute the value/graphics of this custom field.

### `M:Autodesk.Revit.DB.CustomFieldNecessaryData.SetNecessarySpecTypeIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeTypeId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldNecessaryData.SetNecessarySpecTypeIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeTypeId})`

#### Summary

Sets the specs that describe the data type that are needed to compute the value/graphics of this custom field.

#### Parameter `necessarySpecTypeIds`

The necessary specs describing the data type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ids that were set should represent spec types.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.CustomFieldNecessaryData.GetNecessaryCategoryIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldNecessaryData.GetNecessaryCategoryIds`

#### Summary

Gets the ids of the categories/subcategories that are needed to compute the value/graphics of this custom field.

#### Returns

Returns the ids of the categories/subcategories that are needed to compute the value/graphics of this custom field.

### `M:Autodesk.Revit.DB.CustomFieldNecessaryData.SetNecessaryCategoryIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldNecessaryData.SetNecessaryCategoryIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets the ids of the categories/subcategories that are needed to compute the value/graphics of this custom field.

#### Parameter `necessaryCategoryIds`

The necessary categories/subcategories ids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ids that were set should represent categories or subcategories.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.CustomFieldNecessaryData.GetNecessaryElementTypeIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldNecessaryData.GetNecessaryElementTypeIds`

#### Summary

Gets the ids of the element types that are needed to compute the value/graphics of this custom field.

#### Returns

Returns the ids of the elements that are needed to compute the value/graphics of this custom field.

### `M:Autodesk.Revit.DB.CustomFieldNecessaryData.SetNecessaryElementTypeIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldNecessaryData.SetNecessaryElementTypeIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets the ids of the element types that are needed to compute the value/graphics of this custom field.

#### Parameter `necessaryElementTypeIds`

The necessary element type ids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ids that were set should represent Element Types.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.CustomFieldNecessaryData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldNecessaryData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.CustomFieldNecessaryData.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldNecessaryData.#ctor`

#### Summary

Constructs a new instance of a CustomFieldNecessaryData.

### `T:Autodesk.Revit.DB.CustomFieldNecessaryData`

Member kind: type
Symbol: `Autodesk.Revit.DB.CustomFieldNecessaryData`

#### Summary

Class where the ids of the element types or categories/subcategories or specs describing the data type
that are needed to compute the value/graphics of this field can be set.
Examples of such ids can be ids of dimension styles or ids of categories/subcategories whose graphic styles are used.

### `M:Autodesk.Revit.DB.CustomFieldInformation.SetApplicableCategories(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldInformation.SetApplicableCategories(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets the category ids for which this field can be added to the schedule.
By default, this class doesn't store any applicable category ids.

#### Parameter `applicableCategories`

The category ids for which this field can be added to the schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.CustomFieldInformation.GetApplicableCategories`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldInformation.GetApplicableCategories`

#### Summary

Gets the category ids for which this field can be added to the schedule.
By default, this class doesn't store any applicable category ids.

#### Returns

Returns the category ids for which this field can be added to the schedule.

### `M:Autodesk.Revit.DB.CustomFieldInformation.SetSpecTypeId(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldInformation.SetSpecTypeId(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Sets the spec describing the data type. Can be set only if the StorageType is Double.
The default value stored by this class is an empty ForgeTypeId.

#### Parameter `specTypeId`

The spec describing the data type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a spec identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

To assign a spec StorageType is required to be Double.

### `M:Autodesk.Revit.DB.CustomFieldInformation.GetSpecTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldInformation.GetSpecTypeId`

#### Summary

Gets the spec describing the data type.
Can be obtained only if the StorageType is Double.
The default value stored by this class is an empty ForgeTypeId.

#### Returns

Returns the spec describing the data type.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

To assign a spec StorageType is required to be Double.

### `P:Autodesk.Revit.DB.CustomFieldInformation.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldInformation.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.CustomFieldInformation.DefaultVerticalAlignmentStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldInformation.DefaultVerticalAlignmentStyle`

#### Summary

Identifies the default vertical alignment. This will be used only if `P:Autodesk.Revit.DB.CustomFieldInformation.HasCustomGraphicRepresentationOnSheet` is true.
The default value stored by this class is VerticalAlignmentStyle::Middle.

### `P:Autodesk.Revit.DB.CustomFieldInformation.DefaultHorizontalAlignmentStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldInformation.DefaultHorizontalAlignmentStyle`

#### Summary

Identifies the default horizontal alignment. This will be used only if `P:Autodesk.Revit.DB.CustomFieldInformation.HasCustomGraphicRepresentationOnSheet` is true.
The default value stored by this class is HorizontalAlignmentStyle::Center.

### `P:Autodesk.Revit.DB.CustomFieldInformation.FieldTooltip`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldInformation.FieldTooltip`

#### Summary

The tooltip that will be shown in the schedule properties for this custom field.
The default value stored by this class is "".

### `P:Autodesk.Revit.DB.CustomFieldInformation.DefaultRowHeightOnSheet`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldInformation.DefaultRowHeightOnSheet`

#### Summary

The default row height of the custom field on the sheet, in feet. The default value stored by this class is 0.0.
If there is another field that has a bigger height, that one will be used.
This value will only be applied if `P:Autodesk.Revit.DB.CustomFieldInformation.HasCustomGraphicRepresentationOnSheet` is true.

### `P:Autodesk.Revit.DB.CustomFieldInformation.StorageType`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldInformation.StorageType`

#### Summary

The Storage Type of this field. It can be Integer, Double or String.
The default value stored by this class is String.

### `P:Autodesk.Revit.DB.CustomFieldInformation.HasCustomGraphicRepresentationOnSheet`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldInformation.HasCustomGraphicRepresentationOnSheet`

#### Summary

Identifies if the field has a custom graphic representation when we have a schedule instance placed on the sheet or if its value will be shown as text.
The default value stored by this class is false.

### `P:Autodesk.Revit.DB.CustomFieldInformation.FieldName`

Member kind: property
Symbol: `Autodesk.Revit.DB.CustomFieldInformation.FieldName`

#### Summary

Identifies the field name.
The default value stored by this class is "".

### `M:Autodesk.Revit.DB.CustomFieldInformation.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CustomFieldInformation.#ctor`

#### Summary

Constructs a new instance of a CustomFieldInformation.

### `T:Autodesk.Revit.DB.CustomFieldInformation`

Member kind: type
Symbol: `Autodesk.Revit.DB.CustomFieldInformation`

#### Summary

Class holding the general information about the custom field.

### `M:Autodesk.Revit.DB.ICustomFieldServerProxy.ValidateCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServerProxy.ValidateCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to validate the custom field properties.

#### Parameter `customFieldProperties`

An instance of `T:Autodesk.Revit.DB.ICustomFieldProperties` which represents the properties of this field.

#### Parameter `scheduleField`

The field that is controlled by this server.

#### Returns

If the properties are valid, an empty string should be returned.
If the properties are not valid, a non-empty string which describes the error should be returned.
This string will be thrown as ArgumentException message to the caller of
`!:Autodesk::Revit::DB::CustomFieldData::SetCustomFieldProperties` .
If this field doesn't have any properties, it should return a non-empty string
which says that this field doesn't have any properties.

### `M:Autodesk.Revit.DB.ICustomFieldServerProxy.SetCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServerProxy.SetCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to set the custom field properties.

#### Parameter `customFieldProperties`

An instance of `T:Autodesk.Revit.DB.ICustomFieldProperties` which represents the properties of this field.
It is guaranteed that the properties are valid. Before calling this function Revit called
`M:Autodesk.Revit.DB.ICustomFieldServerProxy.ValidateCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField)` and verified that it returned an empty string
(which means that the properties are valid).

#### Parameter `scheduleField`

The field that is controlled by this server.

### `M:Autodesk.Revit.DB.ICustomFieldServerProxy.GetCustomFieldProperties(Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServerProxy.GetCustomFieldProperties(Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to get the custom field properties.

#### Parameter `scheduleField`

The field that is controlled by this server.

#### Returns

Returns an instance of `T:Autodesk.Revit.DB.ICustomFieldProperties` .
If this field doesn't have any properties will return `null` .

### `M:Autodesk.Revit.DB.ICustomFieldServerProxy.GetCustomFieldGraphics(System.Collections.Generic.IList{Autodesk.Revit.DB.CustomFieldOneRowData},Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServerProxy.GetCustomFieldGraphics(System.Collections.Generic.IList{Autodesk.Revit.DB.CustomFieldOneRowData},Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to compute the graphics for the custom field.

#### Remarks

This function is called only if this custom field has a custom graphic representation

This graphics will be shown when the schedule is placed on a sheet.

During the execution of this function the document can't be modified

#### Parameter `rowsData`

A list where each item represents the data needed for computation for one row.

#### Parameter `scheduleField`

The field that is controlled by this server.

#### Returns

Returns a list of objects which contains the result of the computation.
The object at index ii should represent the value for the items grouped on rowsData[ii],
which means that the size of this list should be the same as the size of the rowsData list.
If the sizes are different, for each row, it will be considered that the values were not found, and the cells will be empty.

### `M:Autodesk.Revit.DB.ICustomFieldServerProxy.GetCustomFieldValue(System.Collections.Generic.IList{Autodesk.Revit.DB.CustomFieldOneRowData},Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServerProxy.GetCustomFieldValue(System.Collections.Generic.IList{Autodesk.Revit.DB.CustomFieldOneRowData},Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to compute the value for the specified items.

#### Remarks

This value will be shown in the schedule view. It will also be shown when the schedule is placed on a sheet only if this custom field doesn't have a custom graphic representation

During the execution of this function the document can't be modified

#### Parameter `rowsData`

A list where each item represents the data needed for computation for one row.

#### Parameter `scheduleField`

The field that is controlled by this server.

#### Returns

Returns a list of objects which contains the result of the computation and the computed value.
The object at index ii should represent the value for the items grouped on rowsData[ii]
which means that the size of this list should be the same as the size of the rowsData list.
If the sizes are different, for each row, it will be considered that the values were not found, and the cells will be empty.

### `M:Autodesk.Revit.DB.ICustomFieldServerProxy.GetCustomFieldNecessaryData(Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServerProxy.GetCustomFieldNecessaryData(Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to inform Revit about the ids of the elements or categories/subcategories or any specific specs describing
the data type that are needed to compute the value/graphics of this custom field.
This function is called when the field is inserted into a schedule or when field properties were set.
Each time when elements, categories/subcategories with these ids or the specs are changed, the schedule will be recomputed.
If one of the necessary ids will be deleted, there will be posted an error with "Remove Field" resolution.

#### Parameter `scheduleField`

The field that is controlled by this server.

#### Returns

Returns an object which contains all the necessary data.

### `M:Autodesk.Revit.DB.ICustomFieldServerProxy.InitializeCustomFieldData(Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServerProxy.InitializeCustomFieldData(Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to get a notification when the field was added in a schedule.

#### Remarks

This is a good place where the default properties for this field can be set.
The View Schedule is an element which can be used to attach and serialize data using Extensible Storage framework.

#### Parameter `scheduleField`

The field that is controlled by this server.
The schedule that contains this field is an element which can be used to attach and serialize data using Extensible Storage framework.

### `M:Autodesk.Revit.DB.ICustomFieldServerProxy.GetCustomFieldInformation`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServerProxy.GetCustomFieldInformation`

#### Summary

Override this function and return the information about the custom field.

#### Returns

Returns an object which contains all the custom field information.

### `M:Autodesk.Revit.DB.ICustomFieldServer.ValidateCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServer.ValidateCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to validate the custom field properties.

#### Parameter `customFieldProperties`

An instance of `T:Autodesk.Revit.DB.ICustomFieldProperties` which represents the properties of this field.

#### Parameter `scheduleField`

The field that is controlled by this server.

#### Returns

If the properties are valid, an empty string should be returned.
If the properties are not valid, a non-empty string which describes the error should be returned.
This string will be thrown as ArgumentException message to the caller of
`!:Autodesk::Revit::DB::CustomFieldData::SetCustomFieldProperties` .
If this field doesn't have any properties, it should return a non-empty string
which says that this field doesn't have any properties.

### `M:Autodesk.Revit.DB.ICustomFieldServer.SetCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServer.SetCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to set the custom field properties.

#### Parameter `customFieldProperties`

An instance of `T:Autodesk.Revit.DB.ICustomFieldProperties` which represents the properties of this field.
It is guaranteed that the properties are valid. Before calling this function Revit called
`M:Autodesk.Revit.DB.ICustomFieldServer.ValidateCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties,Autodesk.Revit.DB.ScheduleField)` and verified that it returned an empty string
(which means that the properties are valid).

#### Parameter `scheduleField`

The field that is controlled by this server.

### `M:Autodesk.Revit.DB.ICustomFieldServer.GetCustomFieldProperties(Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServer.GetCustomFieldProperties(Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to get the custom field properties.

#### Parameter `scheduleField`

The field that is controlled by this server.

#### Returns

Returns an instance of `T:Autodesk.Revit.DB.ICustomFieldProperties` .
If this field doesn't have any properties will return `null` .

### `M:Autodesk.Revit.DB.ICustomFieldServer.GetCustomFieldGraphics(System.Collections.Generic.IList{Autodesk.Revit.DB.CustomFieldOneRowData},Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServer.GetCustomFieldGraphics(System.Collections.Generic.IList{Autodesk.Revit.DB.CustomFieldOneRowData},Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to compute the graphics for the custom field.

#### Remarks

This function is called only if this custom field has a custom graphic representation

This graphics will be shown when the schedule is placed on a sheet.

During the execution of this function the document can't be modified

#### Parameter `rowsData`

A list where each item represents the data needed for computation for one row.

#### Parameter `scheduleField`

The field that is controlled by this server.

#### Returns

Returns a list of objects which contains the result of the computation.
The object at index ii should represent the value for the items grouped on rowsData[ii],
which means that the size of this list should be the same as the size of the rowsData list.
If the sizes are different, for each row, it will be considered that the values were not found, and the cells will be empty.

### `M:Autodesk.Revit.DB.ICustomFieldServer.GetCustomFieldValue(System.Collections.Generic.IList{Autodesk.Revit.DB.CustomFieldOneRowData},Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServer.GetCustomFieldValue(System.Collections.Generic.IList{Autodesk.Revit.DB.CustomFieldOneRowData},Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to compute the value for the specified items.

#### Remarks

This value will be shown in the schedule view. It will also be shown when the schedule is placed on a sheet only if this custom field doesn't have a custom graphic representation

During the execution of this function the document can't be modified

#### Parameter `rowsData`

A list where each item represents the data needed for computation for one row.

#### Parameter `scheduleField`

The field that is controlled by this server.

#### Returns

Returns a list of objects which contains the result of the computation and the computed value.
The object at index ii should represent the value for the items grouped on rowsData[ii]
which means that the size of this list should be the same as the size of the rowsData list.
If the sizes are different, for each row, it will be considered that the values were not found, and the cells will be empty.

### `M:Autodesk.Revit.DB.ICustomFieldServer.GetCustomFieldNecessaryData(Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServer.GetCustomFieldNecessaryData(Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to inform Revit about the ids of the elements or categories/subcategories or any specific specs describing
the data type that are needed to compute the value/graphics of this custom field.
This function is called when the field is inserted into a schedule or when field properties were set.
Each time when elements, categories/subcategories with these ids or the specs are changed, the schedule will be recomputed.
If one of the necessary ids will be deleted, there will be posted an error with "Remove Field" resolution.

#### Parameter `scheduleField`

The field that is controlled by this server.

#### Returns

Returns an object which contains all the necessary data.

### `M:Autodesk.Revit.DB.ICustomFieldServer.InitializeCustomFieldData(Autodesk.Revit.DB.ScheduleField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServer.InitializeCustomFieldData(Autodesk.Revit.DB.ScheduleField)`

#### Summary

Override this function to get a notification when the field was added in a schedule.

#### Remarks

This is a good place where the default properties for this field can be set.
The View Schedule is an element which can be used to attach and serialize data using Extensible Storage framework.

#### Parameter `scheduleField`

The field that is controlled by this server.
The schedule that contains this field is an element which can be used to attach and serialize data using Extensible Storage framework.

### `M:Autodesk.Revit.DB.ICustomFieldServer.GetCustomFieldInformation`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICustomFieldServer.GetCustomFieldInformation`

#### Summary

Override this function and return the information about the custom field.

#### Returns

Returns an object which contains all the custom field information.

### `T:Autodesk.Revit.DB.ICustomFieldServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.ICustomFieldServer`

#### Summary

Represents an interface that should be overridden to allow interaction with a custom field into a schedule.

#### Remarks

Once that a server is implemented, it is needed to add it to CustomFieldService.
When a document that contains a schedule with custom field defined by a server which is not added to the CustomFieldService
(such example may be when addon dll is not loaded into Revit), it will be shown a message which informs the user that the
addon is missing and the corresponding cells in schedule view or in the schedule placed on sheet will be empty.

This server was designed to be public_api but in the end it was decided to be moved to public_api_internal
because the a custom field defined by a third party can't be computed when publish the rvt file into the cloud.
The computation of the value and graphics is done in generateGrep and if the addon the defines the server is not
present it the cell will be empty.
Decision can be found here:
https://autodesk.slack.com/archives/C02KQUH4519/p1673018478447789
https://wiki.autodesk.com/display/aeceng/Public+availability+of+the+Custom+Graphics+API#decision_framework-1761429744

### `P:Autodesk.Revit.DB.Structure.ConnectionTypeChangedServiceData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ConnectionTypeChangedServiceData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.ConnectionTypeChangedServiceData.ConnectionId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ConnectionTypeChangedServiceData.ConnectionId`

#### Summary

The id of the structural connection element.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.ConnectionTypeChangedServiceData.Document`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ConnectionTypeChangedServiceData.Document`

#### Summary

The current document.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.ConnectionTypeChangedServiceData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ConnectionTypeChangedServiceData`

#### Summary

The data needed by connection type changed server.

#### Remarks

It's exposed in internal API.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.IConnectionTypeChangedServerProxy.ConnectionTypeChanged(Autodesk.Revit.DB.Structure.ConnectionTypeChangedServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IConnectionTypeChangedServerProxy.ConnectionTypeChanged(Autodesk.Revit.DB.Structure.ConnectionTypeChangedServiceData)`

#### Summary

The server's method that is called when a structural connection changes it's type.

#### Remarks

The method should always return 'true' if the server is successfully executed, no matter whether the server changes anything.
Return 'false' or if the server throws, indicates a failed case, all changes made by the server will be discarded.

#### Parameter `data`

The data that contains the structural connection element

#### Returns

Indicates whether the connection type changed server is executed successfully.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.IConnectionTypeChangedServer.ConnectionTypeChanged(Autodesk.Revit.DB.Structure.ConnectionTypeChangedServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IConnectionTypeChangedServer.ConnectionTypeChanged(Autodesk.Revit.DB.Structure.ConnectionTypeChangedServiceData)`

#### Summary

The server's method that is called when a structural connection changes it's type.

#### Remarks

The method should always return 'true' if the server is successfully executed, no matter whether the server changes anything.
Return 'false' or if the server throws, indicates a failed case, all changes made by the server will be discarded.

#### Parameter `data`

The data that contains the structural connection element

#### Returns

Indicates whether the connection type changed server is executed successfully.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.IConnectionTypeChangedServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.IConnectionTypeChangedServer`

#### Summary

Interface for external servers implementing connection type changed service.

#### Remarks

It's exposed in internal API.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.CodeCheckingParameterServiceData.GetCurrentElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.CodeCheckingParameterServiceData.GetCurrentElements`

#### Summary

Returns the list of Ids of the current elements.

#### Returns

Ids of the current elements. Contains the analytical model element to which the code checking parameter belongs.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.CodeCheckingParameterServiceData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.CodeCheckingParameterServiceData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.CodeCheckingParameterServiceData.Document`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.CodeCheckingParameterServiceData.Document`

#### Summary

The current document.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.CodeCheckingParameterServiceData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.CodeCheckingParameterServiceData`

#### Summary

The data needed by code checking server to perform code checking.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.ICodeCheckingParameterServerProxy.PerformCodeChecking(Autodesk.Revit.DB.Structure.CodeCheckingParameterServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ICodeCheckingParameterServerProxy.PerformCodeChecking(Autodesk.Revit.DB.Structure.CodeCheckingParameterServiceData)`

#### Summary

The server's method that will be called when Revit User clicks the Code Checking parameter's button from the properties palette.

#### Remarks

The server provides UI way for Revit user to view and modify the detail data corresponding with the parameter value.
The server may also modify the code checking parameter value itself during the execution.
The method should always return 'true' if the server is successfully executed, no matter whether the server changes anything.
Return 'false' or if the server throws, indicates a failed case, all changes made by the server will be discarded.
A typical way to use the external server can be:
Implement a server class that derives from this interface

Create a new server object and register it with the service, see `!:Autodesk.Revit.DB.ExternalService.ExternalServiceRegistry` .

Assign server to code checking instance.

#### Parameter `data`

The Code Checking data.

#### Returns

Indicates whether the code checking parameter server is executed successfully.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.ICodeCheckingParameterServer.PerformCodeChecking(Autodesk.Revit.DB.Structure.CodeCheckingParameterServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ICodeCheckingParameterServer.PerformCodeChecking(Autodesk.Revit.DB.Structure.CodeCheckingParameterServiceData)`

#### Summary

The server's method that will be called when Revit User clicks the Code Checking parameter's button from the properties palette.

#### Remarks

The server provides UI way for Revit user to view and modify the detail data corresponding with the parameter value.
The server may also modify the code checking parameter value itself during the execution.
The method should always return 'true' if the server is successfully executed, no matter whether the server changes anything.
Return 'false' or if the server throws, indicates a failed case, all changes made by the server will be discarded.
A typical way to use the external server can be:
Implement a server class that derives from this interface

Create a new server object and register it with the service, see `!:Autodesk.Revit.DB.ExternalService.ExternalServiceRegistry` .

Assign server to code checking instance.

#### Parameter `data`

The Code Checking data.

#### Returns

Indicates whether the code checking parameter server is executed successfully.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.ICodeCheckingParameterServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ICodeCheckingParameterServer`

#### Summary

Interface for the code checking parameter server to implement.

#### Since

2014

### `P:Autodesk.Revit.CloudProjectInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.CloudProjectInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.CloudProjectInfo.ProjectVersion`

Member kind: property
Symbol: `Autodesk.Revit.CloudProjectInfo.ProjectVersion`

#### Summary

Project version.

#### Since

2019

### `P:Autodesk.Revit.CloudProjectInfo.ProjectGuid`

Member kind: property
Symbol: `Autodesk.Revit.CloudProjectInfo.ProjectGuid`

#### Summary

Project Guid from C4R.

#### Since

2019

### `P:Autodesk.Revit.CloudProjectInfo.ProjectName`

Member kind: property
Symbol: `Autodesk.Revit.CloudProjectInfo.ProjectName`

#### Summary

Project name.

#### Since

2019

### `P:Autodesk.Revit.CloudProjectInfo.ProjectId`

Member kind: property
Symbol: `Autodesk.Revit.CloudProjectInfo.ProjectId`

#### Summary

Project identity in BIM 360 Docs or Autodesk Docs.

#### Since

2019

### `P:Autodesk.Revit.CloudProjectInfo.Region`

Member kind: property
Symbol: `Autodesk.Revit.CloudProjectInfo.Region`

#### Summary

Account region in AWS.

#### Since

2019

### `P:Autodesk.Revit.CloudProjectInfo.HubId`

Member kind: property
Symbol: `Autodesk.Revit.CloudProjectInfo.HubId`

#### Summary

Hub identity in BIM 360 Docs or Autodesk Docs.

#### Since

2019

### `M:Autodesk.Revit.CloudProjectInfo.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.CloudProjectInfo.#ctor`

#### Since

2019

### `T:Autodesk.Revit.CloudProjectInfo`

Member kind: type
Symbol: `Autodesk.Revit.CloudProjectInfo`

#### Summary

The data that can be provided to the CloudExternalService.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServerProxy.GetProjects(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServerProxy.GetProjects(System.String,System.String)`

#### Summary

Gets all projects that are available to current login user from this Hub.

#### Parameter `hubId`

Hub identity in ForgeDM.

#### Parameter `region`

The Hub/BIM 360 Docs or Autodesk Docs account and project region.

#### Returns

The list of Projects. Returns an empty list if there is no project in this Hub.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServerProxy.GetHubs`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServerProxy.GetHubs`

#### Summary

Gets all hubs (of the supported regions) that are available to current login user.

#### Returns

The list of Hubs. Returns an empty list if the current user doesn't have any hub.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServerProxy.GetCloudModelInfo(System.Boolean,System.String,System.Guid,System.Guid,System.String@,System.String@,System.String@,System.String@,System.String@,System.String@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServerProxy.GetCloudModelInfo(System.Boolean,System.String,System.Guid,System.Guid,System.String@,System.String@,System.String@,System.String@,System.String@,System.String@)`

#### Summary

Gets the cloud model and related forge infomation.

#### Parameter `forceToTraverse`

Force use trasverse mode to skip off entitlement check, but with bad performance.

#### Parameter `region`

The Hub/BIM 360 Docs or Autodesk Docs account and project region.

#### Parameter `projectGUID`

The GUID of the cloud project which contains the model.

#### Parameter `modelGUID`

The GUID of the Revit cloud model.

#### Parameter `hubId`

Hub/BIM 360 Docs or Autodesk Docs account id.

#### Parameter `projectId`

Project identity in BIM 360 Docs or Autodesk Docs.

#### Parameter `projectName`

The name of the cloud project which contains the model as returned value.

#### Parameter `folderUrn`

Folder identity in BIM 360 Docs or Autodesk Docs.

#### Parameter `modelUrn`

Model identity in BIM 360 Docs or Autodesk Docs.

#### Parameter `modelName`

The name of the Revit cloud model as returned value.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServerProxy.EnsureGatewayClientInitialized`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServerProxy.EnsureGatewayClientInitialized`

#### Summary

Indicates if the Gateway client is initialized using the global endpoint or not.

#### Remarks

This method will try to initialize the gateway client if the client isn't already set up.

#### Returns

Returns true if the Gateway client is initialized, otherwise returns false.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServerProxy.HasBIM360Accounts`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServerProxy.HasBIM360Accounts`

#### Summary

Indicates if the current login user has any BIM 360 Docs or Autodesk Docs accounts or not.

#### Returns

Returns true if this ADSK account associated one or more BIM 360 Docs or Autodesk Docs accounts, otherwise returns false.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServerProxy.GetCloudGUIDsByCloudModelInfo(System.String,System.String,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServerProxy.GetCloudGUIDsByCloudModelInfo(System.String,System.String,System.String,System.String)`

#### Summary

Gets RCM project GUID and model GUID from project id, folder id and model name.

#### Remarks

Will be replaced by CloudModel in future.
CloudModel means the data comes from forgeDM.

#### Parameter `region`

The BIM 360 Docs or Autodesk Docs account and project region.

#### Parameter `projectId`

Project identity in BIM 360 Docs or Autodesk Docs.

#### Parameter `folderId`

Folder identity in BIM 360 Docs or Autodesk Docs.

#### Parameter `modelName`

Model name in BIM 360 Docs or Autodesk Docs.

#### Returns

Returns a map including RCM project and model GUID.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServerProxy.GetProjectInfoFromFolderLocationInformation(System.String,System.String,Autodesk.Revit.CloudProjectInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServerProxy.GetProjectInfoFromFolderLocationInformation(System.String,System.String,Autodesk.Revit.CloudProjectInfo)`

#### Parameter `accountId`

The BIM 360 Docs or Autodesk Docs account Id.

#### Parameter `projectId`

The BIM 360 Docs or Autodesk Docs project Id.

#### Parameter `data`

Cloud external data as output.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServerProxy.IsValidUrn(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServerProxy.IsValidUrn(System.String)`

#### Summary

check if the uri string represents a valid URN.

#### Parameter `uri`

Folder or model identity in BIM 360 Docs or Autodesk Docs.

#### Returns

Returns true if the uri string represents a valid URN,
which also means it follows the prescribed format.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServerProxy.PublishModel(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServerProxy.PublishModel(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ModelPath)`

#### Parameter `pADoc`

Document to publish

#### Parameter `modelPath`

Model path of the model to publish

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServerProxy.Execute(Autodesk.Revit.CloudProjectInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServerProxy.Execute(Autodesk.Revit.CloudProjectInfo)`

#### Summary

The method that Revit will invoke to get the cloud project information from C4R.

#### Parameter `pCloudData`

Contains the input and output data for the execution.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServer.GetProjects(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServer.GetProjects(System.String,System.String)`

#### Summary

Gets all projects that are available to current login user from this Hub.

#### Parameter `hubId`

Hub identity in ForgeDM.

#### Parameter `region`

The Hub/BIM 360 Docs or Autodesk Docs account and project region.

#### Returns

The list of Projects. Returns an empty list if there is no project in this Hub.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServer.GetHubs`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServer.GetHubs`

#### Summary

Gets all hubs (of the supported regions) that are available to current login user.

#### Returns

The list of Hubs. Returns an empty list if the current user doesn't have any hub.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServer.GetCloudModelInfo(System.Boolean,System.String,System.Guid,System.Guid,System.String@,System.String@,System.String@,System.String@,System.String@,System.String@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServer.GetCloudModelInfo(System.Boolean,System.String,System.Guid,System.Guid,System.String@,System.String@,System.String@,System.String@,System.String@,System.String@)`

#### Summary

Gets the cloud model and related forge infomation.

#### Parameter `forceToTraverse`

Force use trasverse mode to skip off entitlement check, but with bad performance.

#### Parameter `region`

The Hub/BIM 360 Docs or Autodesk Docs account and project region.

#### Parameter `projectGUID`

The GUID of the cloud project which contains the model.

#### Parameter `modelGUID`

The GUID of the Revit cloud model.

#### Parameter `hubId`

Hub/BIM 360 Docs or Autodesk Docs account id.

#### Parameter `projectId`

Project identity in BIM 360 Docs or Autodesk Docs.

#### Parameter `projectName`

The name of the cloud project which contains the model as returned value.

#### Parameter `folderUrn`

Folder identity in BIM 360 Docs or Autodesk Docs.

#### Parameter `modelUrn`

Model identity in BIM 360 Docs or Autodesk Docs.

#### Parameter `modelName`

The name of the Revit cloud model as returned value.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServer.EnsureGatewayClientInitialized`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServer.EnsureGatewayClientInitialized`

#### Summary

Indicates if the Gateway client is initialized using the global endpoint or not.

#### Remarks

This method will try to initialize the gateway client if the client isn't already set up.

#### Returns

Returns true if the Gateway client is initialized, otherwise returns false.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServer.HasBIM360Accounts`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServer.HasBIM360Accounts`

#### Summary

Indicates if the current login user has any BIM 360 Docs or Autodesk Docs accounts or not.

#### Returns

Returns true if this ADSK account associated one or more BIM 360 Docs or Autodesk Docs accounts, otherwise returns false.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServer.GetCloudGUIDsByCloudModelInfo(System.String,System.String,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServer.GetCloudGUIDsByCloudModelInfo(System.String,System.String,System.String,System.String)`

#### Summary

Gets RCM project GUID and model GUID from project id, folder id and model name.

#### Remarks

Will be replaced by CloudModel in future.
CloudModel means the data comes from forgeDM.

#### Parameter `region`

The BIM 360 Docs or Autodesk Docs account and project region.

#### Parameter `projectId`

Project identity in BIM 360 Docs or Autodesk Docs.

#### Parameter `folderId`

Folder identity in BIM 360 Docs or Autodesk Docs.

#### Parameter `modelName`

Model name in BIM 360 Docs or Autodesk Docs.

#### Returns

Returns a map including RCM project and model GUID.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServer.GetProjectInfoFromFolderLocationInformation(System.String,System.String,Autodesk.Revit.CloudProjectInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServer.GetProjectInfoFromFolderLocationInformation(System.String,System.String,Autodesk.Revit.CloudProjectInfo)`

#### Parameter `accountId`

The BIM 360 Docs or Autodesk Docs account Id.

#### Parameter `projectId`

The BIM 360 Docs or Autodesk Docs project Id.

#### Parameter `data`

Cloud external data as output.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServer.IsValidUrn(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServer.IsValidUrn(System.String)`

#### Summary

check if the uri string represents a valid URN.

#### Parameter `uri`

Folder or model identity in BIM 360 Docs or Autodesk Docs.

#### Returns

Returns true if the uri string represents a valid URN,
which also means it follows the prescribed format.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServer.PublishModel(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServer.PublishModel(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ModelPath)`

#### Parameter `pADoc`

Document to publish

#### Parameter `modelPath`

Model path of the model to publish

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudExternalServer.Execute(Autodesk.Revit.CloudProjectInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudExternalServer.Execute(Autodesk.Revit.CloudProjectInfo)`

#### Summary

The method that Revit will invoke to get the cloud project information from C4R.

#### Parameter `pCloudData`

Contains the input and output data for the execution.

#### Since

2019
