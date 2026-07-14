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
Shard: 19
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `F:Autodesk.Revit.DB.HorizontalAlignmentStyle.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.HorizontalAlignmentStyle.Right`

#### Summary

Alignment to right

### `F:Autodesk.Revit.DB.HorizontalAlignmentStyle.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.HorizontalAlignmentStyle.Center`

#### Summary

Alignment to center

### `F:Autodesk.Revit.DB.HorizontalAlignmentStyle.Left`

Member kind: field
Symbol: `Autodesk.Revit.DB.HorizontalAlignmentStyle.Left`

#### Summary

Alignment to left

### `P:Autodesk.Revit.DB.SaveOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SaveOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.SaveOptions.Compact`

Member kind: property
Symbol: `Autodesk.Revit.DB.SaveOptions.Compact`

#### Summary

Default is false: let the OS eliminate as much or as little dead data as it wants to.
True: force the OS to eliminate all dead data from the file on disk.

#### Since

2014

### `P:Autodesk.Revit.DB.SaveOptions.PreviewViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.SaveOptions.PreviewViewId`

#### Summary

The view id that will be used to generate the preview; this id is not saved to the document's permanent settings.

#### Remarks

If this id is set, the indicated view will be used to generate the preview even if
DocumentPreviewSettings.PreviewViewId is also set.

#### Value

The id must be valid for use as a preview view (check DocumentPreviewSettings.IsViewIdValidForPreview()).
Revit does not check validity when setting this value, only when the options are used in a call to SaveAs().

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.SaveOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.SaveOptions.#ctor`

#### Summary

Default constructor.

#### Remarks

PreviewViewId will be InvalidElementId.

#### Since

2012

### `T:Autodesk.Revit.DB.SaveOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.SaveOptions`

#### Summary

This class contains options available for saving a document to disk.

#### Since

2012

### `M:Autodesk.Revit.DB.SynchronizeWithCentralOptions.SetRelinquishOptions(Autodesk.Revit.DB.RelinquishOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.SetRelinquishOptions(Autodesk.Revit.DB.RelinquishOptions)`

#### Summary

Sets the options which govern whether or not to relinquish elements and workset types.

#### Parameter `relinquishOptions`

The options. If `null` , synchronize with central will relinquish the current user's ownership of all worksets and all elements.

#### Since

2014

### `M:Autodesk.Revit.DB.SynchronizeWithCentralOptions.GetRelinquishOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.GetRelinquishOptions`

#### Summary

Gets the options which govern whether or not to relinquish elements and workset types.

#### Returns

The options. If `null` , synchronize with central will relinquish the current user's ownership of all worksets and all elements.

#### Since

2014

### `P:Autodesk.Revit.DB.SynchronizeWithCentralOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.SynchronizeWithCentralOptions.SaveLocalFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.SaveLocalFile`

#### Summary

Indicates whether Revit will save the local file at least once while synchronizing with central.

#### Since

2014

### `P:Autodesk.Revit.DB.SynchronizeWithCentralOptions.RelinquishBorrowedElements`

Member kind: property
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.RelinquishBorrowedElements`

#### Summary

Indicates whether Revit should relinquish borrowed elements after synchronizing with central.

#### Remarks

This is a shortcut to access the value stored in `P:Autodesk.Revit.DB.RelinquishOptions.CheckedOutElements` .

#### Since

2014

### `P:Autodesk.Revit.DB.SynchronizeWithCentralOptions.RelinquishUserCreatedWorksets`

Member kind: property
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.RelinquishUserCreatedWorksets`

#### Summary

Indicates whether Revit should relinquish user-created Standard worksets after synchronizing with central.

#### Remarks

This is a shortcut to access the value stored in `P:Autodesk.Revit.DB.RelinquishOptions.UserWorksets` .

#### Since

2014

### `P:Autodesk.Revit.DB.SynchronizeWithCentralOptions.RelinquishViewWorksets`

Member kind: property
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.RelinquishViewWorksets`

#### Summary

Indicates whether Revit should relinquish View worksets after synchronizing with central.

#### Remarks

This is a shortcut to access the value stored in `P:Autodesk.Revit.DB.RelinquishOptions.ViewWorksets` .

#### Since

2014

### `P:Autodesk.Revit.DB.SynchronizeWithCentralOptions.RelinquishFamilyWorksets`

Member kind: property
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.RelinquishFamilyWorksets`

#### Summary

Indicates whether Revit should relinquish Family worksets after synchronizing with central.

#### Remarks

This is a shortcut to access the value stored in `P:Autodesk.Revit.DB.RelinquishOptions.FamilyWorksets` .

#### Since

2014

### `P:Autodesk.Revit.DB.SynchronizeWithCentralOptions.RelinquishProjectStandardWorksets`

Member kind: property
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.RelinquishProjectStandardWorksets`

#### Summary

Indicates whether Revit should relinquish Project Standard worksets after synchronizing with central.

#### Remarks

This is a shortcut to access the value stored in `P:Autodesk.Revit.DB.RelinquishOptions.StandardWorksets` .

#### Since

2014

### `P:Autodesk.Revit.DB.SynchronizeWithCentralOptions.EnableCloudWorksharing`

Member kind: property
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.EnableCloudWorksharing`

#### Summary

True means enable cloud worksharing in this operation, false means it is a common synchronization

#### Since

2014

### `P:Autodesk.Revit.DB.SynchronizeWithCentralOptions.SaveLocalAfter`

Member kind: property
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.SaveLocalAfter`

#### Summary

True means to save local after saving changes to central. True by default.
Silently ignored if the model in the current session is central rather than local.

#### Remarks

It is recommended practice to save local after SWC because otherwise local becomes incompatible with central.

#### Since

2014

### `P:Autodesk.Revit.DB.SynchronizeWithCentralOptions.Comment`

Member kind: property
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.Comment`

#### Summary

User description of changes made since the last Sync with Central. Empty by default.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: comment has more than 30,000 characters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.SynchronizeWithCentralOptions.Compact`

Member kind: property
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.Compact`

#### Summary

Indicates whether Revit should compact the central model while synchronizing with central.
This option reduces the size of the central model but many increase the time it takes to perform the save.
False by default.

#### Since

2014

### `P:Autodesk.Revit.DB.SynchronizeWithCentralOptions.SaveLocalBefore`

Member kind: property
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.SaveLocalBefore`

#### Summary

True means to save local before the first reload latest if there are changes not yet saved to local.
True by default. Silently ignored if the model in the current session is central rather than local.

#### Since

2014

### `M:Autodesk.Revit.DB.SynchronizeWithCentralOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions.#ctor`

#### Summary

Constructs a new instance of SynchronizeWithCentralOptions initialized with default options.

#### Since

2014

### `T:Autodesk.Revit.DB.SynchronizeWithCentralOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.SynchronizeWithCentralOptions`

#### Summary

Options to control behavior of synchronization with central.

#### Since

2014

### `M:Autodesk.Revit.DB.SaveAsOptions.SetWorksharingOptions(Autodesk.Revit.DB.WorksharingSaveAsOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SaveAsOptions.SetWorksharingOptions(Autodesk.Revit.DB.WorksharingSaveAsOptions)`

#### Summary

Sets Worksharing options for SaveAs.

#### Parameter `worksharingOptions`

Must be `null` for a non-workshared model.

Allowed to be `null` for a workshared model,
in which case default values for WorksharingSaveAsOptions are used.

#### Since

2014

### `M:Autodesk.Revit.DB.SaveAsOptions.GetWorksharingOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.SaveAsOptions.GetWorksharingOptions`

#### Summary

Gets Worksharing options for SaveAs.

#### Returns

Defaults to `null` .
For a workshared model, if `null` default values for WorksharingSaveAsOptions are used.

#### Since

2014

### `P:Autodesk.Revit.DB.SaveAsOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SaveAsOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.SaveAsOptions.Compact`

Member kind: property
Symbol: `Autodesk.Revit.DB.SaveAsOptions.Compact`

#### Summary

Default is false: let the OS eliminate as much or as little dead data as it wants to.
True: force the OS to eliminate all dead data from the file on disk.

#### Since

2014

### `P:Autodesk.Revit.DB.SaveAsOptions.MaximumBackups`

Member kind: property
Symbol: `Autodesk.Revit.DB.SaveAsOptions.MaximumBackups`

#### Summary

The maximum number of backups to keep on disk.

#### Remarks

Non-workshared models have whole-file backups, sequentially numbered.

File-based workshared models have eager, incremental backups
in a backup folder adjacent to the model itself:
Every save backs up all changed data and avoids recopying unchanged elements,
so the latest backup is equivalent to the main copy on disk and
the backup folder does not have huge amounts of redundant data.

#### Value

A positive number means to keep at most that many backups.

The default value of -1 means to use Revit's defaults:
3 for non-workshared, 20 for workshared.
After initialization, the setter can be used to choose a positive number,
but cannot be used to restore this default value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The requested number of backups is out of range.

#### Since

2014

### `P:Autodesk.Revit.DB.SaveAsOptions.PreviewViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.SaveAsOptions.PreviewViewId`

#### Summary

The view id that will be used to generate the preview; this id is not saved to the document's permanent settings.

#### Remarks

If this id is set to a view id, the indicated view will be used to generate the preview even if
DocumentPreviewSettings.PreviewViewId is also set.

#### Value

The id must be valid for use as a preview view (check DocumentPreviewSettings.IsValidPreviewViewId()).
Revit does not check validity when setting this value, only when the options are used in a call to SaveAs().
Default is InvalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.SaveAsOptions.OverwriteExistingFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.SaveAsOptions.OverwriteExistingFile`

#### Summary

Identifies if the operation should be able to overwrite an existing file.

#### Value

True if the SaveAs operation should silently overwrite an existing target file, if it exists.
False if the operation should fail if there is already a file at the target location. Default is false.

#### Since

2012

### `M:Autodesk.Revit.DB.SaveAsOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.SaveAsOptions.#ctor`

#### Summary

Default constructor.

#### Since

2012

### `T:Autodesk.Revit.DB.SaveAsOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.SaveAsOptions`

#### Summary

This class contains options available for saving a document to disk with a new filename.

#### Since

2012

### `M:Autodesk.Revit.DB.STLExportOptions.SetTessellationSettings(Autodesk.Revit.DB.ExportResolution)`

Member kind: method
Symbol: `Autodesk.Revit.DB.STLExportOptions.SetTessellationSettings(Autodesk.Revit.DB.ExportResolution)`

#### Summary

Sets all the tessellation parameters to its predefined values for the given resolution type.

#### Parameter `resolutionType`

Type of exporting resolution.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2021.1

### `M:Autodesk.Revit.DB.STLExportOptions.IsGridAspectRatioSet`

Member kind: method
Symbol: `Autodesk.Revit.DB.STLExportOptions.IsGridAspectRatioSet`

#### Summary

Checks whether the GridAspectRatio tessellation parameter is explicitly set.

#### Returns

True if GridAspectRatio tessellation parameter is explicitly set, false otherwise.

#### Since

2021.1

### `M:Autodesk.Revit.DB.STLExportOptions.IsValidForGridAspectRatio(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.STLExportOptions.IsValidForGridAspectRatio(System.Double)`

#### Summary

Checks whether the value is allowed (is in the allowed range) for GridAspectRatio tessellation parameter.

#### Parameter `value`

The value to be checked.

#### Returns

True if the value is valid for GridAspectRatio, false otherwise.

#### Since

2021.1

### `M:Autodesk.Revit.DB.STLExportOptions.IsMaxEdgeLengthSet`

Member kind: method
Symbol: `Autodesk.Revit.DB.STLExportOptions.IsMaxEdgeLengthSet`

#### Summary

Checks whether the MaxEdgeLength tessellation parameter is explicitly set.

#### Returns

True if MaxEdgeLength tessellation parameter is explicitly set, false otherwise.

#### Since

2021.1

### `M:Autodesk.Revit.DB.STLExportOptions.IsValidForMaxEdgeLength(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.STLExportOptions.IsValidForMaxEdgeLength(System.Double)`

#### Summary

Checks whether the value is allowed (is in the allowed range) for MaxEdgeLength tessellation parameter.

#### Parameter `value`

The value to be checked.

#### Returns

True if the value is valid for MaxEdgeLength, false otherwise.

#### Since

2021.1

### `M:Autodesk.Revit.DB.STLExportOptions.IsNormalToleranceSet`

Member kind: method
Symbol: `Autodesk.Revit.DB.STLExportOptions.IsNormalToleranceSet`

#### Summary

Checks whether the NormalTolerance tessellation parameter is explicitly set.

#### Returns

True if NormalTolerance tessellation parameter is explicitly set, false otherwise.

#### Since

2021.1

### `M:Autodesk.Revit.DB.STLExportOptions.IsValidForNormalTolerance(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.STLExportOptions.IsValidForNormalTolerance(System.Double)`

#### Summary

Checks whether the value is allowed (is in the allowed range) for NormalTolerance tessellation parameter.

#### Parameter `value`

The value to be checked.

#### Returns

True if the value is valid for NormalTolerance, false otherwise.

#### Since

2021.1

### `M:Autodesk.Revit.DB.STLExportOptions.IsSurfaceToleranceSet`

Member kind: method
Symbol: `Autodesk.Revit.DB.STLExportOptions.IsSurfaceToleranceSet`

#### Summary

Checks whether the SurfaceTolerance tessellation parameter is explicitly set.

#### Returns

True if SurfaceTolerance tessellation parameter is explicitly set, false otherwise.

#### Since

2021.1

### `M:Autodesk.Revit.DB.STLExportOptions.IsValidForSurfaceTolerance(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.STLExportOptions.IsValidForSurfaceTolerance(System.Double)`

#### Summary

Checks whether the value is allowed (is in the allowed range) for SurfaceTolerance tessellation parameter.

#### Parameter `value`

The value to be checked.

#### Returns

True if the value is valid for SurfaceTolerance, false otherwise.

#### Since

2021.1

### `P:Autodesk.Revit.DB.STLExportOptions.GridAspectRatio`

Member kind: property
Symbol: `Autodesk.Revit.DB.STLExportOptions.GridAspectRatio`

#### Summary

The maximum aspect ratio allowed in the grid placed across the face.
The minimum allowed value is 1.0. The maximum allowed value is 10.0. By default this property is ignored.

#### Remarks

This property can be set by using export resolution type (by creation of STLExportOptions or using `!:Autodesk::Revit::DB::STLExportOptions::setTessellationSettings(ExportResolution::Enum)` method).
In the case of Fine, Medium and Coarse resolutions, this property has the same value (10.0) and it is considered as explicitly set by the user.
In the case of Custom resolution type, this property is only allowed to be obtained if it has been explicitly set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value gridAspectRatio is outside the allowable range of values for GridAspectRatio tessellation parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

GridAspectRatio tessellation parameter is default (hasn't been explicitly set by the user) and cannot be obtained now.

#### Since

2021.1

### `P:Autodesk.Revit.DB.STLExportOptions.MaxEdgeLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.STLExportOptions.MaxEdgeLength`

#### Summary

The maximum length allowed for any chord on an edge or between any two adjacent grid lines. This is a percentage value.
By exporting, the real value of maximum edge length is calculated as a percent from the length of the diameter of the body bounding box.
The minimum allowed value is 0.1%. The maximum allowed value is 10.0%. By default this property is ignored.

#### Remarks

This property can be set by using export resolution type (by creation of STLExportOptions or using `!:Autodesk::Revit::DB::STLExportOptions::setTessellationSettings(ExportResolution::Enum)` method).
In the case of Fine, Medium and Coarse resolutions, this property has the same value (10.0%) and it is considered as explicitly set by the user.
In the case of Custom resolution type, this property is only allowed to be obtained if it has been explicitly set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value maxEdgeLength is outside the allowable range of values for MaxEdgeLength tessellation parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

MaxEdgeLength tessellation parameter is default (hasn't been explicitly set by the user) and cannot be obtained now.

#### Since

2021.1

### `P:Autodesk.Revit.DB.STLExportOptions.NormalTolerance`

Member kind: property
Symbol: `Autodesk.Revit.DB.STLExportOptions.NormalTolerance`

#### Summary

The maximum change in the surface normal between adjacent nodes in the mesh. This property is defined in degrees.
The minimum allowed value is 1.0 degrees. The maximum allowed value is 45.0 degrees. Default value is 15.0 degrees.

#### Remarks

This property can be set by using export resolution type (by creation of STLExportOptions or using `!:Autodesk::Revit::DB::STLExportOptions::setTessellationSettings(ExportResolution::Enum)` method).
In the case of Fine (10.0 degrees), Medium (15.0 degrees) and Coarse (30.0 degrees) resolutions, this property is considered as explicitly set by the user.
In the case of Custom resolution type, this property is only allowed to be obtained if it has been explicitly set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value normalTolerance is outside the allowable range of values for NormalTolerance tessellation parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

NormalTolerance tessellation parameter is default (hasn't been explicitly set by the user) and cannot be obtained now.

#### Since

2021.1

### `P:Autodesk.Revit.DB.STLExportOptions.SurfaceTolerance`

Member kind: property
Symbol: `Autodesk.Revit.DB.STLExportOptions.SurfaceTolerance`

#### Summary

The maximum distance between mesh triangles and model geometry. This is a percentage value.
By exporting, the real value of surface tolerance is calculated as a percent from the length of the diameter of the body bounding box.
The minimum allowed value is 0.001%. The maximum allowed value is 1.0%. Default value is 0.1%.

#### Remarks

This property can be set by using export resolution type (by creation of STLExportOptions or using `!:Autodesk::Revit::DB::STLExportOptions::setTessellationSettings(ExportResolution::Enum)` method).
In the case of Fine (0.005%), Medium (0.016%) and Coarse (0.04%) resolutions, this property is considered as explicitly set by the user.
In the case of Custom resolution type, this property is only allowed to be obtained if it has been explicitly set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value surfaceTolerance is outside the allowable range of values for SurfaceTolerance tessellation parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

SurfaceTolerance tessellation parameter is default (hasn't been explicitly set by the user) and cannot be obtained now.

#### Since

2021.1

### `P:Autodesk.Revit.DB.STLExportOptions.ExportColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.STLExportOptions.ExportColor`

#### Summary

True to export color information, false otherwise.
Default value is false.

#### Remarks

Color information can be exported only in binary STL format, in the case of ASCII STL format this property will be ignored.

#### Since

2021.1

### `P:Autodesk.Revit.DB.STLExportOptions.TargetUnit`

Member kind: property
Symbol: `Autodesk.Revit.DB.STLExportOptions.TargetUnit`

#### Summary

The unit type of geometry in the resultant STL file.
Default value is ExportUnit::Default.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2021.1

### `P:Autodesk.Revit.DB.STLExportOptions.ExportBinary`

Member kind: property
Symbol: `Autodesk.Revit.DB.STLExportOptions.ExportBinary`

#### Summary

True to export in binary STL format, false to export in ASCII STL format.
Default value is true.

#### Since

2021.1

### `M:Autodesk.Revit.DB.STLExportOptions.#ctor(Autodesk.Revit.DB.ExportResolution)`

Member kind: method
Symbol: `Autodesk.Revit.DB.STLExportOptions.#ctor(Autodesk.Revit.DB.ExportResolution)`

#### Summary

Constructs a new instance of STLExportOptions with all predefined tessellation settings, depending on export resolution type.
Note: in case of Custom resolution type, tessellation settings won't be predefined and will have default values.

#### Parameter `resolutionType`

The type of export resolution.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2021.1

### `M:Autodesk.Revit.DB.STLExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.STLExportOptions.#ctor`

#### Summary

Constructs a new instance of STLExportOptions with default values of all properties.

#### Since

2021.1

### `T:Autodesk.Revit.DB.STLExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.STLExportOptions`

#### Summary

The export options used by exporting STL format file.

#### Since

2021.1

### `M:Autodesk.Revit.DB.SSEPointVisibilitySettings.SetVisibility(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SSEPointVisibilitySettings.SetVisibility(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Sets the SSE point visibility for the given category.

#### Parameter `document`

The document.

#### Parameter `categoryId`

The category id.

#### Parameter `isVisible`

The visibility of the given category. True means the SSE points are visible.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The category is not valid for SSE.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.SSEPointVisibilitySettings.GetVisibility(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SSEPointVisibilitySettings.GetVisibility(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the SSE point visibility for the given category.

#### Parameter `document`

The document.

#### Parameter `categoryId`

The category id.

#### Returns

The visibility of the given category. True means the SSE points are visible.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The category is not valid for SSE.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `T:Autodesk.Revit.DB.SSEPointVisibilitySettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.SSEPointVisibilitySettings`

#### Summary

Represents the settings contained in the document associated to the point display of Floor, Roof and Toposolid.
for serialization
public api methods

#### Since

2024

### `T:Autodesk.Revit.DB.Architecture.TopRailType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.TopRailType`

#### Summary

A rail type object that is used in the generation of top rail.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.TopRail`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.TopRail`

#### Summary

Represents a top rail element in Autodesk Revit.

### `P:Autodesk.Revit.DB.Architecture.StairsType.HasMiddleSupports`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.HasMiddleSupports`

#### Summary

True if the stairs type has middle supports, False otherwise.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.MiddleSupportType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.MiddleSupportType`

#### Summary

The type of middle supports used in the stair.

#### Value

invalidElementId if the stairs type has no middle support.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: supportType is not a valid middle support type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The stairs type has no middle support so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.MiddleSupportsNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.MiddleSupportsNumber`

#### Summary

The number of middle supports used in the stair.

#### Value

0 if the stairs type has no middle support.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for supportsNumber is negative.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The stairs type has no middle support so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.RightLateralOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.RightLateralOffset`

#### Summary

The offset for the right support from the edge of the run in a horizontal direction.

#### Value

0 if the right support is not carriage(open).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for offset must be between 0 and 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The right support style is not carriage(open), so this related data cannot be set.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.LeftLateralOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.LeftLateralOffset`

#### Summary

The offset for the left support from the edge of the run in a horizontal direction.

#### Value

0 if the left support is not carriage(open).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for offset must be between 0 and 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The left support style is not carriage(open), so this related data cannot be set.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.RightSideSupportType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.RightSideSupportType`

#### Summary

The type of right support used in the stair.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: rightSideStringerTypeId is not a valid support type.
-or-
When setting this property: The specified rightSideStringerTypeId doesn't match the desired style of the right side support.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The right support style is none, so this related data cannot be set.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.LeftSideSupportType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.LeftSideSupportType`

#### Summary

The type of left support used in the stair.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: leftSideStringerTypeId is not a valid support type.
-or-
When setting this property: The specified leftSideStringerTypeId doesn't match the desired style of the left side support.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The left support style is none, so this related data cannot be set.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.ConstructionMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.ConstructionMethod`

#### Summary

The construction method of the stairs.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.EndConnectionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.EndConnectionType`

#### Summary

The join style between a run and landing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.LandingType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.LandingType`

#### Summary

The type for all landings in the stair element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The specified landingTypeId is not a valid landing type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.RunType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.RunType`

#### Summary

The type for all runs in the stair element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The specified runTypeId is not a valid run type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.NotchVerticalGap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.NotchVerticalGap`

#### Summary

The width of the vertical gap in the stairs notch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for notchVerticalGap must be between 0 and 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The construction method of the stairs type is not "Precast" or the StairsEndConnectionType of the stairs type is not "Notch", so this related data cannot be set.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.NotchHorizontalGap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.NotchHorizontalGap`

#### Summary

The width of the horizontal gap in the stairs notch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for notchHorizontalGap must be between 0 and 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The construction method of the stairs type is not "Precast" or the StairsEndConnectionType of the stairs type is not "Notch", so this related data cannot be set.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.NotchThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.NotchThickness`

#### Summary

The vertical length of the notch profile from the top.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for notchThickness must be between 0 and 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The construction method of the stairs type is not "Precast" or the StairsEndConnectionType of the stairs type is not "Notch", so this related data cannot be set.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.NotchExtension`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.NotchExtension`

#### Summary

The horizontal length of the notch profile.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for notchExtension must be no more than 30000 feet in absolute value.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The construction method of the stairs type is not "Precast" or the StairsEndConnectionType of the stairs type is not "Notch", so this related data cannot be set.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.MinRunWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.MinRunWidth`

#### Summary

The initial value for the width of a common run.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for minRunWidth must be greater than 0 and no more than 30000 feet.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.MinTreadDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.MinTreadDepth`

#### Summary

The minimum tread width along the center path for all common runs (winder, arc, and straight).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for minTreadDepth must be greater than 0 and no more than 30000 feet.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsType.MaxRiserHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsType.MaxRiserHeight`

#### Summary

The maximum height of each riser on the stair element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for maxRiserHeight must be greater than 0 and no more than 30000 feet.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.StairsType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsType`

#### Summary

A type element containing the properties for a component-based stair.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.RiserToTreadConnect`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.RiserToTreadConnect`

#### Summary

The connection of the riser to tread in relation to each other.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The run type has no riser so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.RiserProfile`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.RiserProfile`

#### Summary

The id of the profile of the risers.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The profile is neither a valid element id nor invalidElementId.
-or-
When setting this property: The profile is not a valid riser profile symbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The run type has no riser so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.RiserThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.RiserThickness`

#### Summary

The thickness of the risers.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for length must be greater than 0 and no more than 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The run type has no riser so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.IsSlanted`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.IsSlanted`

#### Summary

True if risers will be slanted, false if they will be straight.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.TreadNosingPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.TreadNosingPosition`

#### Summary

Represents on which edges of the nosing to apply the nosing profile.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The run type has no tread so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.TreadProfile`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.TreadProfile`

#### Summary

The id of the profile of the treads.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The profile is neither a valid element id nor invalidElementId.
-or-
When setting this property: The profile is not a valid tread profile symbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The run type has no tread so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.NosingProfile`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.NosingProfile`

#### Summary

The id of the nosing profile of the treads.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The profile is neither a valid element id nor invalidElementId.
-or-
When setting this property: The profile is not a valid nosing profile symbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The run type has no tread so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.NosingLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.NosingLength`

#### Summary

The amount of the tread depth that overhangs the next tread.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for length must be between 0 and 30000 feet.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.TreadThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.TreadThickness`

#### Summary

The thickness of the treads.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for thickness must be greater than 0 and no more than 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The run type has no tread so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.MaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.MaterialId`

#### Summary

The material of the stairs run, only available for monolithic stairs run.

#### Value

The id of the material of the stairs run, invalid ElementId if the stairs run is not monolithic.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The materialId is not a valid material element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The stairs run type is not a monolithic type so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.UndersideSurfaceStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.UndersideSurfaceStyle`

#### Summary

The underside surface style of the stairs run, only available for monolithic stairs run.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The stairs run type is not a monolithic type so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.TotalDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.TotalDepth`

#### Summary

The total depth of the stairs run, only available for monolithic stairs run.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.StructuralDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.StructuralDepth`

#### Summary

The structural depth of the stairs run, only available for monolithic stairs run.

#### Value

The structural depth of the stairs run, 0.0 if the stairs run is not monolithic.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for structuralDepth must be between 0 and 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The stairs run type is not a monolithic type so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.HasRisers`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.HasRisers`

#### Summary

True if the stairs run will include risers on steps, false otherwise.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.HasTreads`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.HasTreads`

#### Summary

True if the stairs run will include treads on steps, false otherwise.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRunType.IsMonolithic`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType.IsMonolithic`

#### Summary

True if the stairs run is monolithic, false otherwise.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.StairsRunType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunType`

#### Summary

A stairs run type object that is used in the generation of stairs run.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsRun.CreateSpiralRun(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double,System.Boolean,Autodesk.Revit.DB.Architecture.StairsRunJustification)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.CreateSpiralRun(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double,System.Boolean,Autodesk.Revit.DB.Architecture.StairsRunJustification)`

#### Summary

Creates a spiral run in the project document by providing the center, start angle and included angle.

#### Remarks

The new stairs run and the document will be regenerated.
This should be run from within an open transaction.

#### Parameter `document`

The document.

#### Parameter `stairsId`

The stairs that the new stairs run will belong to.

#### Parameter `center`

The center of the location arc of the spiral run.
The Z coordinate of the center is the base elevation for the new run (in model coordinates).
It must be greater than or equal to the stairs base elevation.

#### Parameter `radius`

The radius of the location arc of the spiral run.

#### Parameter `startAngle`

The start angle of the location arc of the spiral run.
The angle's coordinate system is world coordinate system which always is XYZ.BasisX and XYZ.BasisY.

#### Parameter `includedAngle`

The total angle covered by the spiral run. Must be a positive value (direction is determined by the clockwise flag).

#### Parameter `clockwise`

True if the spiral run will be created along clockwise direction, False otherwise.

#### Parameter `justification`

The location path justification of the new stairs run.

#### Returns

The new stairs run.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The stairsId is not a valid stairs element.
-or-
The given value for startAngle is not finite
-or-
The input center is not a valid center for spiral run (probably the Z coordinate doesn't meet the restrictions)
-or-
The includedAngle doesn't satisfy riser restriction to generate spiral run (probably it's too small).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for radius must be greater than 0 and no more than 30000 feet.
-or-
The given value for includedAngle must be positive.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The radius is too small to generate a spiral run at the given justification.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The stairs element represented by stairsId is not in an active StairsEditScope.
New components cannot be added to it.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.RegenerationFailedException`

The center, radius, startAngle, includedAngle don't satisfy restrictions to generate spiral run.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsRun.CreateStraightRun(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.Architecture.StairsRunJustification)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.CreateStraightRun(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.Architecture.StairsRunJustification)`

#### Summary

Creates a straight run in the project document.

#### Remarks

The new stairs run and the document will be regenerated.
This should be run from within an open transaction.

#### Parameter `document`

The document.

#### Parameter `stairsId`

The stairs that the new stairs run will belong to.

#### Parameter `locationPath`

The line for location path of the new stairs run. The line has following restriction:
The line should be bound line which is parallel to the XY plane.

The Z coordinate of the line is the base elevation for the new run (in model coordinates).
It must be greater than or equal to the stairs base elevation.

The number of created risers will be calculated by rounding the length of the
location path to a multiple of the tread depth.

#### Parameter `justification`

The location path justification of the new stairs run.

#### Returns

The new stairs run.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The stairsId is not a valid stairs element.
-or-
The input locationPath is not a bound line.
-or-
The input locationPath is not a valid location path line for straight run.
-or-
The locationPath is not valid line used as stairs path(probably it's too short).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The stairs element represented by stairsId is not in an active StairsEditScope.
New components cannot be added to it.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.RegenerationFailedException`

The locationPath doesn't satisfy restrictions to generate straight run.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsRun.CreateSketchedRunWithSlopeData(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.SketchedStairsCurveData},System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.CreateSketchedRunWithSlopeData(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.SketchedStairsCurveData},System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

#### Summary

Creates a sketched run in the project document by providing a group of boundary curves and riser curves, specifying slope type and height for boundary curves.

#### Remarks

The run type of the new stairs run will be determined by the specified stairs.
The new stairs run and the document will be regenerated.
This should be run from within an open transaction.

#### Parameter `document`

The document.

#### Parameter `stairsId`

The stairs that the new stairs run will belong to.

#### Parameter `baseElevation`

Base elevation of the new stairs run. It has following restrictions:
The base elevation is relative to the base elevation of the stairs.

The base elevation will be rounded automatically to a multiple of the riser height.

#### Parameter `boundaryCurves`

The boundary curves of the new stairs run, specifying slope type and height. The curves have following restriction:
The curves should consist of bound Line or Arc curves only.

The curves should be a pair of curve chains(two sets of curves which connect end-to-end
to form the left and right boundaries).

The left and right boundary chain curves should not connect to each other.

They can be single curves or multi-segmented curves(for example, straight lines and
arcs connected).

#### Parameter `riserCurves`

The riser curves of the new stairs run. The curves have following restriction:
The curves should consist of bound Line or Arc curves only.

The curves should be able to make at least two curve chains.

The curves in each chain should connect between the left and right boundaries.

#### Parameter `stairsPath`

The stair path curves of the new stairs run. The curves have following restriction:
The curves should consist of bound Line or Arc curves only.

The curves should be able to make one curve chain.

The curve chain should have intersection with all riser curve chains.

The curves should connect between the first and last riser chain curves.

#### Returns

The new stairs run.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The stairsId is not a valid stairs element.
-or-
The input riserCurves is empty.
-or-
The input stairsPath is empty.
-or-
The input boundaryCurves is empty.
The input boundaryCurves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
The input riserCurves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
The input stairsPath contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
The riserCurves or boundaryCurves or stairsPath don't meet restrictions to create sketch run.
-or-
The boundaryCurves has invalid curve used as sketch boundary curve.
-or-
The riserCurves has invalid curve used as sketch riser curve.
-or-
The stairsPath has invalid curve used as sketch stairspath curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for baseElevation must be no more than 30000 feet in absolute value.
-or-
The baseElevation doesn't meet the restriction that bottom of run should not be lower than bottom of stairs.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The stairs element represented by stairsId is not in an active StairsEditScope.
New components cannot be added to it.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.RegenerationFailedException`

The boundaryCurves, riserCurves, stairsPath don't meet restrictions to generate sketch run.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsRun.CreateSketchedRun(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.CreateSketchedRun(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

#### Summary

Creates a sketched run in the project document by providing a group of boundary curves and riser curves.

#### Remarks

The run type of the new stairs run will be determined by the specified stairs.
The new stairs run and the document will be regenerated.
This should be run from within an open transaction.

#### Parameter `document`

The document.

#### Parameter `stairsId`

The stairs that the new stairs run will belong to.

#### Parameter `baseElevation`

Base elevation of the new stairs run. It has following restrictions:
The base elevation is relative to the base elevation of the stairs.

The base elevation will be rounded automatically to a multiple of the riser height.

#### Parameter `boundaryCurves`

The boundary curves of the new stairs run. The curves have following restriction:
The curves should consist of bound Line or Arc curves only.

The curves should be a pair of curve chains(two sets of curves which connect end-to-end
to form the left and right boundaries).

The left and right boundary chain curves should not connect to each other.

They can be single curves or multi-segmented curves(for example, straight lines and
arcs connected).

#### Parameter `riserCurves`

The riser curves of the new stairs run. The curves have following restriction:
The curves should consist of bound Line or Arc curves only.

The curves should be able to make at least two curve chains.

The curves in each chain should connect between the left and right boundaries.

#### Parameter `stairsPath`

The stair path curves of the new stairs run. The curves have following restriction:
The curves should consist of bound Line or Arc curves only.

The curves should be able to make one curve chain.

The curve chain should have intersection with all riser curve chains.

The curves should connect between the first and last riser chain curves.

#### Returns

The new stairs run.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The stairsId is not a valid stairs element.
-or-
The input boundaryCurves is empty.
-or-
The input riserCurves is empty.
-or-
The input stairsPath is empty.
-or-
The input boundaryCurves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
The input riserCurves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
The input stairsPath contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
The riserCurves or boundaryCurves or stairsPath don't meet restrictions to create sketch run.
-or-
The boundaryCurves has invalid curve used as sketch boundary curve.
-or-
The riserCurves has invalid curve used as sketch riser curve.
-or-
The stairsPath has invalid curve used as sketch stairspath curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for baseElevation must be no more than 30000 feet in absolute value.
-or-
The baseElevation doesn't meet the restriction that bottom of run should not be lower than bottom of stairs.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The stairs element represented by stairsId is not in an active StairsEditScope.
New components cannot be added to it.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.RegenerationFailedException`

The boundaryCurves, riserCurves, stairsPath don't meet restrictions to generate sketch run.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsRun.GetFootprintBoundary`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.GetFootprintBoundary`

#### Summary

Returns the run's boundary curves which are projected on the stairs base level.

#### Returns

The boundary curves of the stairs run.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsRun.GetStairsPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.GetStairsPath`

#### Summary

Returns the stairs path curves on the run. The curves are projected on base level of the stairs.

#### Returns

The stairs path curves.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The stairs run has no stairs path it probably because the run was not generated yet.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsRun.GetStairs`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.GetStairs`

#### Summary

Returns the stairs to which the stairs run belongs.

#### Returns

The stairs to which the stairs run belongs.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsRun.GetAllSupports`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.GetAllSupports`

#### Summary

Retrieves all supports hosted by the stair's run.

#### Remarks

The supports consist of left, right, and middle supports of the stair's run.

#### Returns

All supports hosted by the stair's run.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsRun.GetRightSupports`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.GetRightSupports`

#### Summary

Retrieves all supports on the right side of run boundaries.

#### Returns

The supports on the right side of run boundaries.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsRun.GetLeftSupports`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.GetLeftSupports`

#### Summary

Retrieves all supports on the left side of run boundaries.

#### Returns

The supports on the left side of run boundaries.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsRun.GetConnections`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.GetConnections`

#### Summary

Returns information about the connections in which the stairs run participates.
The stairs run may have no connection, or have at maximum two connections at the lower and upper ends.

#### Returns

The connections in which the stairs run participates.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.StairsRun.GetNumberSystemReference(Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.GetNumberSystemReference(Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption)`

#### Summary

Gets the number system reference corresponding to the given reference options.

#### Remarks

The return value of this function is suitable for use in NumberSystem.Create()
to associate a NumberSystem with the location on the StairsRun.
Don't try to get geometry curve from the reference.

#### Parameter `referenceOption`

The reference option.

#### Returns

The reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsRun.SetLocationPathForSpiralRun(Autodesk.Revit.DB.Architecture.StairsRun,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double,System.Boolean,Autodesk.Revit.DB.Architecture.StairsRunJustification)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.SetLocationPathForSpiralRun(Autodesk.Revit.DB.Architecture.StairsRun,Autodesk.Revit.DB.XYZ,System.Double,System.Double,System.Double,System.Boolean,Autodesk.Revit.DB.Architecture.StairsRunJustification)`

#### Summary

Set Location path for a spiral run.

#### Parameter `stairsRun`

The run whose location path will be set.

#### Parameter `center`

The center of the location arc of the spiral run.
The Z coordinate of the center is the base elevation for the new run (in model coordinates).
It must be greater than or equal to the stairs base elevation.

#### Parameter `radius`

The radius of the location arc of the spiral run.

#### Parameter `startAngle`

The start angle of the location arc of the spiral run.
The angle's coordinate system is world coordinate system which always is XYZ.BasisX and XYZ.BasisY.

#### Parameter `includedAngle`

The total angle covered by the spiral run. Must be a positive value (direction is determined by the clockwise flag).

#### Parameter `clockwise`

True if the spiral run will be created along clockwise direction, False otherwise.

#### Parameter `justification`

The location path justification of the new stairs run.

#### Returns

Indicate if set is success or not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for startAngle is not finite
-or-
The input center is not a valid center for spiral run (probably the Z coordinate doesn't meet the restrictions)
-or-
The includedAngle doesn't satisfy riser restriction to generate spiral run (probably it's too small).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for radius must be greater than 0 and no more than 30000 feet.
-or-
The given value for includedAngle must be positive.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The radius is too small to generate a spiral run at the given justification.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The stairs element represented by stairsRun is not in an active StairsEditScope.
The run cannot be modified.

#### Exception `T:Autodesk.Revit.Exceptions.RegenerationFailedException`

The center, radius, startAngle, includedAngle don't satisfy restrictions to generate spiral run.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsRun.SetLocationPathForStraightRun(Autodesk.Revit.DB.Architecture.StairsRun,Autodesk.Revit.DB.Line)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.SetLocationPathForStraightRun(Autodesk.Revit.DB.Architecture.StairsRun,Autodesk.Revit.DB.Line)`

#### Summary

Set location path for a straight run by giving a line.

#### Parameter `stairsRun`

The run whose location path will be set.

#### Parameter `locationPath`

The location path.

#### Returns

Indicate if set is success or not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input locationPath is not a bound line.
-or-
The input locationPath is not a valid location path line for straight run.
-or-
The locationPath is not valid line used as stairs path(probably it's too short).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The stairs element represented by stairsRun is not in an active StairsEditScope.
The run cannot be modified.

#### Exception `T:Autodesk.Revit.Exceptions.RegenerationFailedException`

The locationPath doesn't satisfy restrictions to generate straight run.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRun.LocationLineJustification`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.LocationLineJustification`

#### Summary

The position of the run relative to the Up-direction path used to create the run.

#### Remarks

Only common runs(straight, spiral, winder) have location line justification.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The stairs run is sketched so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRun.EndsWithRiser`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.EndsWithRiser`

#### Summary

True if the stairs run ends with a riser, false otherwise.

#### Remarks

If selected, Revit adds a riser to the end of the run.
Clearing this option will change the number of risers in the run.
You will need to manually add or remove risers to maintain the original height.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRun.BeginsWithRiser`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.BeginsWithRiser`

#### Summary

True if the stairs run begins with a riser, false otherwise.

#### Remarks

If selected, Revit adds a riser to the beginning of the run.
If you clear this option, Revit removes the beginning riser
and positions the adjacent tread at the base elevation.
Clearing this option will change the number of risers in the run.
You will need to manually add a riser to maintain the original height.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRun.ExtensionBelowTreadBase`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.ExtensionBelowTreadBase`

#### Summary

Specifies a value to extend/trim the run's first step against base elevation of the stairs if the stairs begins with a tread.

#### Remarks

This is useful in cases where the run attaches to the face of a floor opening rather than
resting on the surface of the floor.
Negative value extends the run's first step below the stairs' base elevation. Positive
value trims it above the stairs' base elevation.
This value should not be greater than run's top elevation.

#### Value

0.0 if the stairs run connects with stairs landing or the stairs run doesn't begin with a thread.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for extendBelowTreadBase must be no more than 30000 feet in absolute value.
-or-
When setting this property: The extendBelowTreadBase is not less than run height.
-or-
When setting this property: The extendBelowTreadBase is greater than the top elevation of the stairs run.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The run cannot extend its below base because its base joins with other stairs components.
-or-
When setting this property: The run cannot extend its below tread base because it doesn't begin with a tread.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.StairsRun.ExtensionBelowRiserBase`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.ExtensionBelowRiserBase`

#### Summary

Specifies a value to extend/trim the run's first step against base elevation of the stairs if the stairs begins with a riser.

#### Remarks

This is useful in cases where the run attaches to the face of a floor opening rather than
resting on the surface of the floor.
Negative value extends the run's first step below the stairs' base elevation. Positive
value trims it above the stairs' base elevation.
This value should not be greater than run's top elevation.

#### Value

0.0 if the stairs run connects with stairs landing or the stairs run doesn't begin with a riser.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for extendBelowRiserBase must be no more than 30000 feet in absolute value.
-or-
When setting this property: The extendBelowRiserBase is not less than run height.
-or-
When setting this property: The extendBelowRiserBase is greater than the top elevation of the stairs run.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The run cannot extend its below base because its base joins with other stairs components.
-or-
When setting this property: The run cannot extend its below riser base because it doesn't begin with a riser.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.StairsRun.ActualTreadsNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.ActualTreadsNumber`

#### Summary

The actual number of stairs treads in the stairs run.

#### Remarks

This is a read-only value.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRun.ActualRisersNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.ActualRisersNumber`

#### Summary

The actual number of stairs risers in the stairs run.

#### Remarks

This is a read-only value.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRun.ActualRunWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.ActualRunWidth`

#### Summary

Specifies the value of the tread width excluding the width of independent side supports.

#### Value

The actual width of the stairs run, 0.0 if the run is a sketched run.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for runWidth must be greater than 0 and no more than 30000 feet.
-or-
When setting this property: The runWidth is too small or too large to be used as actual run width, probably it
doesn't satisfy the layout generation restriction of the stairs run.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The stairs run is sketched so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRun.TopElevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.TopElevation`

#### Summary

The top elevation of the stairs run.

#### Remarks

The top elevation has following restrictions:
The top elevation is relative to the base elevation of the stairs to which the
stairs run belongs.

When setting this property the value will be rounded automatically to a multiple of
the riser height.

When setting this property for common run, the run's height will change according to
the new base/top elevation. So the value must be greater than base elevation to keep run valid.

When setting this property for sketched run, whose height is fixed, the run's base
elevation will be adjusted to keep the same run height.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for topElevation must be no more than 30000 feet in absolute value.
-or-
When setting this property: The topElevation doesn't meet the minimal height restriction of the stairs run.
-or-
When setting this property: The topElevation is less than the extension below base of the stairs run.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The stairs run is sketched so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRun.BaseElevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.BaseElevation`

#### Summary

The base elevation of the stairs run.

#### Remarks

The base elevation has following restrictions:
The base elevation is relative to the base elevation of the stairs to which the
stairs run belongs.

When setting this property the value will be rounded automatically to a multiple of
the riser height.

When setting this property for common run, the run's height will change according to
the new base/top elevation. So the value must be less than the top elevation to keep run valid.

When setting this property for sketched run, whose height is fixed, the run's top
elevation will be adjusted to keep the same run height.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for baseElevation must be no more than 30000 feet in absolute value.
-or-
When setting this property: The baseElevation doesn't meet the restriction that bottom of run should not be lower than bottom of stairs.
-or-
When setting this property: The baseElevation doesn't meet the minimal height restriction of the stairs run.
-or-
When setting this property: The baseElevation impacts the top elevation which is less than extension below base.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRun.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.Height`

#### Summary

The calculated height of the stairs run.

#### Remarks

The height is the elevation span between run's base elevation and top elevation.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsRun.StairsRunStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun.StairsRunStyle`

#### Summary

The style of the stairs run such as straight, winder, etc.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.StairsRun`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsRun`

#### Summary

Represents a stairs run element in Autodesk Revit.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPathType.FullStepArrow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathType.FullStepArrow`

#### Summary

True if the arrow fills the full step width, false if it fills by the specified arrow size.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPathType.StartFromRiser`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathType.StartFromRiser`

#### Summary

True if the stairs path starts from the riser, false if it starts from the tread.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The StairsPathType is not fixed up direction so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPathType.ShowArrowheadToCutMark`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathType.ShowArrowheadToCutMark`

#### Summary

True if the stairs path arrowhead should be shown to the cutmark, false if the arrow head is not shown.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPathType.DrawForEachRun`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathType.DrawForEachRun`

#### Summary

True if stairs paths should be drawn for each run, false if it should be drawn for the whole stairs.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The StairsPathType is not fixed up direction so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPathType.EndAtRiser`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathType.EndAtRiser`

#### Summary

Represents whether the stairs path ends at the riser.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The StairsPathType is not fixed up direction so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPathType.StairsPathDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathType.StairsPathDirection`

#### Summary

The style of the stairs path.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPathType.LineShapeAtCorner`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathType.LineShapeAtCorner`

#### Summary

The line shape of stairs path at the corner.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Either the stairs path direction is not AutomaticUpDown, or it is AlwaysUp but DrawForEachRun is false.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPathType.StartSymbolTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathType.StartSymbolTypeId`

#### Summary

The start symbol type of stairs path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The startSymbolTypeId is not a valid start symbol type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPathType.ArrowheadTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathType.ArrowheadTypeId`

#### Summary

The arrow head type of the stairs path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The arrowheadTypeId is not a valid arrow head type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPathType.StartExtension`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathType.StartExtension`

#### Summary

The start extension length of the stairs path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for startExtension must be between 0 and 30000 feet.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPathType.DistanceToCutMark`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathType.DistanceToCutMark`

#### Summary

The distance from the stairs path arrow to cut mark.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for distanceToCutMark must be between 0 and 30000 feet.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.StairsPathType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathType`

#### Summary

An object represents the stairs path type.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsPath.CanCreateOnMultistoryStairs(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsPath.CanCreateOnMultistoryStairs(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId)`

#### Summary

Checks if more stairs paths can be added on the plan views of a multistory stairs.

#### Parameter `multistoryStairsId`

The multistory stairs id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsPath.CreateOnMultistoryStairs(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsPath.CreateOnMultistoryStairs(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new stairs path for the stairs in a multistory stairs with the specified stairs path type only in the plan view.

#### Parameter `document`

The document.

#### Parameter `multistoryStairsId`

The id of the multistory stairs element either in the host document or in a linked document.

#### Parameter `typeId`

The type of stairs path.

#### Returns

The new stairs paths.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Cannot add more stairs paths on multistoryStairsId.
-or-
The typeId is not a valid stairs path type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.StairsPath.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsPath.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new stairs path for the specified stairs with the specified stairs path type only in the plan view.

#### Parameter `document`

The document.

#### Parameter `stairsId`

The id of the stairs element either in the host document or in a linked document.

#### Parameter `typeId`

The type of stairs path.

#### Parameter `planViewId`

The plan view in which the stairs path will be shown.

#### Returns

The new stairs path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The stairsId is not a valid stairs.
-or-
The typeId is not a valid stairs path type.
-or-
The planViewId is not a valid plan view.
-or-
The stairsId already has a stairs path.
-or-
The stairsId is not visible in planViewId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPath.ShowDownText`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPath.ShowDownText`

#### Summary

Represents whether show stairs down text or not.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The type of this stairs path is not automatic up/down direction.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPath.ShowUpText`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPath.ShowUpText`

#### Summary

Represents whether show stairs up text or not.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPath.TextOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPath.TextOrientation`

#### Summary

The orientation of stair up and down text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPath.StairsId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPath.StairsId`

#### Summary

The host stairs element id.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPath.StairsPathOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPath.StairsPathOffset`

#### Summary

The offset of stairs path to center line of stairs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for stairsPathOffset is not finite
-or-
When setting this property: The stairsPathOffset is larger than half the width of the stairs.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPath.UpTextOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPath.UpTextOffset`

#### Summary

The offset of stairs up text.

#### Remarks

The z direction makes no sense in API.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The stairs path doesn't not show up text so the data being set is inapplicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPath.DownTextOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPath.DownTextOffset`

#### Summary

The offset of stairs down text.

#### Remarks

The z direction makes no sense in API.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The type of this stairs path is not automatic up/down direction.
-or-
When setting this property: The stairs path doesn't show down text so the data being set is inapplicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPath.DownText`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPath.DownText`

#### Summary

The stairs down text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The type of this stairs path is not automatic up/down direction.
-or-
When setting this property: The stairs path doesn't show down text so the data being set is inapplicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsPath.UpText`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsPath.UpText`

#### Summary

The stairs up text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The stairs path doesn't not show up text so the data being set is inapplicable.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.StairsPath`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsPath`

#### Summary

An object that represents the stairs path.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsLandingType.Thickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsLandingType.Thickness`

#### Summary

Thickness of the stairs landing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for thickness must be greater than 0 and no more than 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The landing type doesn't have monolithic support.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsLandingType.IsMonolithic`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsLandingType.IsMonolithic`

#### Summary

True if the stairs landing is monolithic, false otherwise.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.StairsLandingType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsLandingType`

#### Summary

Represents a stairs landing type in Autodesk Revit.

#### Since

2013

### `M:Autodesk.Revit.DB.SketchedStairsCurveData.GetCurve`

Member kind: method
Symbol: `Autodesk.Revit.DB.SketchedStairsCurveData.GetCurve`

#### Summary

Get a copy of the curve that is formed along this boundary.

#### Returns

A copy of the curve.

#### Since

2015

### `P:Autodesk.Revit.DB.SketchedStairsCurveData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SketchedStairsCurveData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.SketchedStairsCurveData.#ctor(Autodesk.Revit.DB.Curve,System.Double,Autodesk.Revit.DB.Architecture.SketchedCurveSlopeOption)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SketchedStairsCurveData.#ctor(Autodesk.Revit.DB.Curve,System.Double,Autodesk.Revit.DB.Architecture.SketchedCurveSlopeOption)`

#### Summary

Construct a SketchedStairsCurveData defined by a curve associated with its height and slope type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `T:Autodesk.Revit.DB.SketchedStairsCurveData`

Member kind: type
Symbol: `Autodesk.Revit.DB.SketchedStairsCurveData`

#### Summary

Sketched run/landing curves overrides with height and slope

#### Since

2015

### `M:Autodesk.Revit.DB.Architecture.StairsLanding.GetConnections`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding.GetConnections`

#### Summary

Returns information about the connections in which the stairs landing participates.

#### Returns

The connections in which the stairs landing participates.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.StairsLanding.GetStairsPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding.GetStairsPath`

#### Summary

Returns the stairs path curves on the landing. The curves are projected on the stairs base level.

#### Returns

The stairs path curves of the landing.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsLanding.GetAllSupports`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding.GetAllSupports`

#### Summary

Returns all the supports hosting the stairs landing.

#### Remarks

The supports consist of left, right and middle supports of the stairs landing.

#### Returns

All the supports hosting the stairs landings.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsLanding.GetStairs`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding.GetStairs`

#### Summary

Returns the stairs to which the landing belongs.

#### Returns

The stairs to which the landing belongs.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsLanding.SetSketchedLandingBoundaryAndPath(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding.SetSketchedLandingBoundaryAndPath(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.CurveLoop)`

#### Summary

Sets the boundary and path curves of the sketched landing.

#### Remarks

This should be run from within an open transaction.

#### Parameter `document`

The document that owns the landing.

#### Parameter `boundaryCurveLoop`

The closed boundary curves of the landing.

#### Parameter `pathCurveLoop`

The path curves of the landing, can be an empty CurveLoop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The boundaryCurveLoop is not closed.
-or-
The input boundaryCurveLoop contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
The input pathCurveLoop contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
Failed to create curve element by the boundaryCurveLoop or pathCurveLoop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Architecture.StairsLanding.GetFootprintBoundary`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding.GetFootprintBoundary`

#### Summary

Returns the landing's boundary curves which are projected on the stairs base level.

#### Returns

The boundary curves of the landing.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsLanding.CreateSketchedLandingWithSlopeData(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.SketchedStairsCurveData},System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding.CreateSketchedLandingWithSlopeData(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.SketchedStairsCurveData},System.Double)`

#### Summary

Creates a customized landing between two runs by providing the closed boundary curves of the landing, specifying slope type and height.

#### Remarks

The new stairs landing and the document will be regenerated.
This should be run from within an open transaction.

#### Parameter `document`

The document that owns the landing.

#### Parameter `stairsId`

The stairs that the new sketched landing belongs to.

#### Parameter `curveLoop`

The closed boundary curves of the new landing, specifying slope type and height.

#### Parameter `baseElevation`

Base elevation of the new stairs run. The elevation has following restriction:
The base elevation is relative to the base elevation of the stairs.

The base elevation will be rounded automatically to a multiple of the riser height.

The base elevation should be equal to or greater than half of the riser height.

#### Returns

The new sketched landing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element stairsId does not exist in the document
-or-
The stairsId is not a valid stairs element.
-or-
The stairs stairsId has no valid landing type.
-or-
The curveLoop is not closed.
The input curveLoop contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
Failed to create curve element by the curveLoop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for baseElevation must be no more than 30000 feet in absolute value.
-or-
The baseElevation is less than half of the riser height of the stairs.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The stairs element represented by stairsId is not in an active StairsEditScope.
New components cannot be added to it.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.RegenerationFailedException`

The curveLoop doesn't satisfy restrictions to generate sketched landing.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsLanding.CreateSketchedLanding(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.CurveLoop,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding.CreateSketchedLanding(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.CurveLoop,System.Double)`

#### Summary

Creates a customized landing between two runs by providing the closed boundary curves of the landing.

#### Remarks

The new stairs landing and the document will be regenerated.
This should be run from within an open transaction.

#### Parameter `document`

The document that owns the landing.

#### Parameter `stairsId`

The stairs that the new sketched landing belongs to.

#### Parameter `curveLoop`

The closed boundary curves of the new landing.

#### Parameter `baseElevation`

Base elevation of the new stairs run. The elevation has following restriction:
The base elevation is relative to the base elevation of the stairs.

The base elevation will be rounded automatically to a multiple of the riser height.

The base elevation should be equal to or greater than half of the riser height.

#### Returns

The new sketched landing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element stairsId does not exist in the document
-or-
The stairsId is not a valid stairs element.
-or-
The stairs stairsId has no valid landing type.
-or-
The curveLoop is not closed.
-or-
The input curveLoop contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
Failed to create curve element by the curveLoop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for baseElevation must be no more than 30000 feet in absolute value.
-or-
The baseElevation is less than half of the riser height of the stairs.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The stairs element represented by stairsId is not in an active StairsEditScope.
New components cannot be added to it.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.RegenerationFailedException`

The curveLoop doesn't satisfy restrictions to generate sketched landing.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsLanding.CanCreateAutomaticLanding(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding.CanCreateAutomaticLanding(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether automatic landing(s) can be created between the given two stairs runs and
logically join(s) with the stairs runs.

#### Remarks

This only checks whether two stairs runs meet restriction to create automatic landing(s)
without checking the stairs edit scope and document modifiable.

#### Parameter `document`

The document that owns the stairs runs.

#### Parameter `firstRunId`

The first stairs run.

#### Parameter `secondRunId`

The second stairs run.

#### Returns

True if automatic landing(s) can be created between the two stairs runs, False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.StairsLanding.CreateAutomaticLanding(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding.CreateAutomaticLanding(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates automatic landing(s) between two stairs runs.

#### Remarks

This should be called within open stairs edit scope and transaction.
The new stairs landing(s) and the document will be regenerated.
The landing type of the new stairs landing(s) is determined by stairs type.

#### Parameter `document`

The document that owns the stairs runs and new landing(s).

#### Parameter `firstRunId`

The first stairs run.

#### Parameter `secondRunId`

The second stairs run.

#### Returns

The created landing(s) between the two stairs runs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The firstRunId is not a valid stairs run.
-or-
The secondRunId is not a valid stairs run.
-or-
The stairs runs firstRunId and secondRunId belong to different stairs host.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The stairs element to which the stairs component firstRunId belong is not in an active StairsEditScope.
-or-
Cannot create automatic landing(s) between stairs runs of firstRunId and secondRunId.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.RegenerationFailedException`

Failed to create automatic landing(s) due to document regeneration failures.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsLanding.IsAutomaticLanding`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding.IsAutomaticLanding`

#### Summary

True if the landing is an automatic landing, False otherwise.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsLanding.BaseElevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding.BaseElevation`

#### Summary

The base elevation of the landing.

#### Value

The base elevation is relative elevation against base elevation of the stairs to which the stairs run belongs to.
When setting this property the base elevation will be rounded automatically to a multiple of the riser height.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for height must be no more than 30000 feet in absolute value.
-or-
When setting this property: The height is less than half of the riser height of the stairs.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsLanding.Thickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding.Thickness`

#### Summary

The thickness of the landing.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.StairsLanding`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsLanding`

#### Summary

An object that represents a stairs landing in Autodesk Revit.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.StairsComponentConnection.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsComponentConnection.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.StairsComponentConnection.PeerConnectionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsComponentConnection.PeerConnectionType`

#### Summary

The connection type of the peer connected stairs component.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.StairsComponentConnection.ConnectionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsComponentConnection.ConnectionType`

#### Summary

The connection type of the connected stairs component.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.StairsComponentConnection.PeerElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsComponentConnection.PeerElementId`

#### Summary

The element Id of peer connected stairs component in the stairs connection.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.StairsComponentConnection.ElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.StairsComponentConnection.ElementId`

#### Summary

The element Id of connected stairs component in the stairs connection.

#### Since

2014

### `T:Autodesk.Revit.DB.Architecture.StairsComponentConnection`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsComponentConnection`

#### Summary

Represents information about a connection among stairs components(run to landing).

#### Since

2014

### `T:Autodesk.Revit.DB.Architecture.SketchedCurveSlopeOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.SketchedCurveSlopeOption`

#### Summary

The option determines the slop of the sketched run/landing.

#### Since

2015

### `F:Autodesk.Revit.DB.Architecture.SketchedCurveSlopeOption.Sloped`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.SketchedCurveSlopeOption.Sloped`

#### Summary

The slope of the sketched run/landing will be specified by users.

### `F:Autodesk.Revit.DB.Architecture.SketchedCurveSlopeOption.Flat`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.SketchedCurveSlopeOption.Flat`

#### Summary

The slope of the sketched run/landing will be kept flat.

### `F:Autodesk.Revit.DB.Architecture.SketchedCurveSlopeOption.Auto`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.SketchedCurveSlopeOption.Auto`

#### Summary

The slope of the sketched run/landing will be auto detected.

### `T:Autodesk.Revit.DB.Architecture.RiserToTreadConnectionOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RiserToTreadConnectionOption`

#### Summary

Represents the connection style of the riser and tread in relation to each other.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.RiserToTreadConnectionOption.JoinAll`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RiserToTreadConnectionOption.JoinAll`

#### Summary

The connection will join all risers and treads.

### `F:Autodesk.Revit.DB.Architecture.RiserToTreadConnectionOption.TreadUnderRiser`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RiserToTreadConnectionOption.TreadUnderRiser`

#### Summary

The connection will extend tread under riser.

### `F:Autodesk.Revit.DB.Architecture.RiserToTreadConnectionOption.RiserBehindTread`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.RiserToTreadConnectionOption.RiserBehindTread`

#### Summary

The connection will extend riser behind tread.

### `T:Autodesk.Revit.DB.Architecture.TreadNosingPosition`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.TreadNosingPosition`

#### Summary

Represents on which edges of the nosing to apply the nosing profile.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.TreadNosingPosition.FrontLeftAndRight`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.TreadNosingPosition.FrontLeftAndRight`

#### Summary

Adds nosing on the front left and left edge of tread.

### `F:Autodesk.Revit.DB.Architecture.TreadNosingPosition.FrontAndRight`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.TreadNosingPosition.FrontAndRight`

#### Summary

Adds nosing on the front and right edge of tread.

### `F:Autodesk.Revit.DB.Architecture.TreadNosingPosition.FrontAndLeft`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.TreadNosingPosition.FrontAndLeft`

#### Summary

Adds nosing on the front and left edge of tread.

### `F:Autodesk.Revit.DB.Architecture.TreadNosingPosition.FrontOnly`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.TreadNosingPosition.FrontOnly`

#### Summary

Adds nosing on the front edge of tread only.

### `T:Autodesk.Revit.DB.Architecture.StairsConstructionMethod`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsConstructionMethod`

#### Summary

Represents the construction method of the stairs.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.StairsConstructionMethod.Precast`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsConstructionMethod.Precast`

#### Summary

The stairs is constructed by precast method.

### `F:Autodesk.Revit.DB.Architecture.StairsConstructionMethod.CastInPlace`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsConstructionMethod.CastInPlace`

#### Summary

The stairs is constructed by cast-in-place method.

### `F:Autodesk.Revit.DB.Architecture.StairsConstructionMethod.Assembled`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsConstructionMethod.Assembled`

#### Summary

The stairs is constructed by assembly method.

### `T:Autodesk.Revit.DB.Architecture.WinderPathResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.WinderPathResult`

#### Summary

Flag indicates whether curves are valid to use as base lines for winder path.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.WinderPathResult.NotSupported`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.WinderPathResult.NotSupported`

#### Summary

This path(for zigzag winder) is not supported yet

### `F:Autodesk.Revit.DB.Architecture.WinderPathResult.InvalidCurveType`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.WinderPathResult.InvalidCurveType`

#### Summary

Curve is not line.

### `F:Autodesk.Revit.DB.Architecture.WinderPathResult.SelfIntersect`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.WinderPathResult.SelfIntersect`

#### Summary

The first curve intersect with third curve.

### `F:Autodesk.Revit.DB.Architecture.WinderPathResult.ColinearOrOverlap`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.WinderPathResult.ColinearOrOverlap`

#### Summary

Two curves are collinear or overlap.

### `F:Autodesk.Revit.DB.Architecture.WinderPathResult.TooShort`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.WinderPathResult.TooShort`

#### Summary

Curve length is too short.

### `F:Autodesk.Revit.DB.Architecture.WinderPathResult.NotOpenLoop`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.WinderPathResult.NotOpenLoop`

#### Summary

The curves are not in one open loop.

### `F:Autodesk.Revit.DB.Architecture.WinderPathResult.Noncontinuous`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.WinderPathResult.Noncontinuous`

#### Summary

The curves are not continuous in one loop.

### `F:Autodesk.Revit.DB.Architecture.WinderPathResult.Unbound`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.WinderPathResult.Unbound`

#### Summary

Curve is not bound.

### `F:Autodesk.Revit.DB.Architecture.WinderPathResult.NumberOutOfRange`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.WinderPathResult.NumberOutOfRange`

#### Summary

The curves number is not 2 or 3.

### `F:Autodesk.Revit.DB.Architecture.WinderPathResult.Success`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.WinderPathResult.Success`

#### Summary

Indicates curves are valid to use as path base lines for winder run.
This is only one flag indicates curves are fine to use as winder path.

### `T:Autodesk.Revit.DB.Architecture.StairsComponentConnectionEndType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsComponentConnectionEndType`

#### Summary

The end type identifying the connection type among stairs runs and landings.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.StairsComponentConnectionEndType.ET_RunEnd`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsComponentConnectionEndType.ET_RunEnd`

#### Summary

A connection to the end (upper end) of a stairs run.

### `F:Autodesk.Revit.DB.Architecture.StairsComponentConnectionEndType.ET_RunStart`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsComponentConnectionEndType.ET_RunStart`

#### Summary

A connection to the start (lower end) of a stairs run.

### `F:Autodesk.Revit.DB.Architecture.StairsComponentConnectionEndType.ET_Landing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsComponentConnectionEndType.ET_Landing`

#### Summary

A connection to the boundary of a stairs landing.

### `T:Autodesk.Revit.DB.Architecture.StairsSupportTopsideSurfaceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsSupportTopsideSurfaceType`

#### Summary

The style of the topside surface of the support.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.StairsSupportTopsideSurfaceType.Open`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsSupportTopsideSurfaceType.Open`

#### Summary

The style of the topside surface of the support is open.

### `F:Autodesk.Revit.DB.Architecture.StairsSupportTopsideSurfaceType.Closed`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsSupportTopsideSurfaceType.Closed`

#### Summary

The style of the topside surface of the support is closed.

### `T:Autodesk.Revit.DB.Architecture.StairsUndersideSurfaceStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsUndersideSurfaceStyle`

#### Summary

The style of the underside surface of the run.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.StairsUndersideSurfaceStyle.Smooth`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsUndersideSurfaceStyle.Smooth`

#### Summary

The underside surface of the run is smooth.

### `F:Autodesk.Revit.DB.Architecture.StairsUndersideSurfaceStyle.Stepped`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsUndersideSurfaceStyle.Stepped`

#### Summary

The underside surface of the run is stepped.

### `T:Autodesk.Revit.DB.Architecture.StairsRunStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunStyle`

#### Summary

The shape of a run. Different shape has different ways of manipulation.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.StairsRunStyle.Spiral`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunStyle.Spiral`

#### Summary

A spiral run is defined by a cylindrical helix. Both inner and outer boundaries are arcs. Risers are straight lines.

### `F:Autodesk.Revit.DB.Architecture.StairsRunStyle.Straight`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunStyle.Straight`

#### Summary

A straight run is defined by a straight line. All treads are rectangular.

### `F:Autodesk.Revit.DB.Architecture.StairsRunStyle.Sketched`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunStyle.Sketched`

#### Summary

A sketched run can have customized boundary and riser curves. User can customize stair path as well.

### `F:Autodesk.Revit.DB.Architecture.StairsRunStyle.Winder`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunStyle.Winder`

#### Summary

A winder run has distorted treads, for the sake of space saving at corner.

### `T:Autodesk.Revit.DB.Architecture.StairsWinderStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsWinderStyle`

#### Summary

The calculation method for the layout of the winder run steps.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.StairsWinderStyle.SinglePoint`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsWinderStyle.SinglePoint`

#### Summary

Asymmetrical layout style. Winder style is calculated from a single center point.

### `F:Autodesk.Revit.DB.Architecture.StairsWinderStyle.Balanced`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsWinderStyle.Balanced`

#### Summary

Symmetrical layout style.

### `T:Autodesk.Revit.DB.Architecture.StairsRunJustification`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunJustification`

#### Summary

The position of the run relative to the Up-direction path used to create the run.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.StairsRunJustification.RightExterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunJustification.RightExterior`

#### Summary

The creation path for the run is the right stringer exterior edge.

### `F:Autodesk.Revit.DB.Architecture.StairsRunJustification.LeftExterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunJustification.LeftExterior`

#### Summary

The creation path for the run is the left stringer exterior edge.

### `F:Autodesk.Revit.DB.Architecture.StairsRunJustification.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunJustification.Right`

#### Summary

The creation path for the run is the right edge.

### `F:Autodesk.Revit.DB.Architecture.StairsRunJustification.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunJustification.Center`

#### Summary

The creation path for the run is the center.

### `F:Autodesk.Revit.DB.Architecture.StairsRunJustification.Left`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsRunJustification.Left`

#### Summary

The creation path for the run is the left edge.

### `T:Autodesk.Revit.DB.Architecture.StairsEndNotchOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsEndNotchOption`

#### Summary

The style of notch width for the stairs.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.StairsEndNotchOption.Custom`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsEndNotchOption.Custom`

#### Summary

The notch width is customized by user.

### `F:Autodesk.Revit.DB.Architecture.StairsEndNotchOption.FullRunWidth`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsEndNotchOption.FullRunWidth`

#### Summary

The notch width is the run width.

### `T:Autodesk.Revit.DB.Architecture.StairsEndConnectionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsEndConnectionType`

#### Summary

The join style between a run and landing.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.StairsEndConnectionType.Notch`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsEndConnectionType.Notch`

#### Summary

The run and landing are joined by a notch.

### `F:Autodesk.Revit.DB.Architecture.StairsEndConnectionType.StraightCut`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsEndConnectionType.StraightCut`

#### Summary

The run and landing are joined by a straight cut.

### `M:Autodesk.Revit.DB.NumberSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption,Autodesk.Revit.DB.LinkElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption,Autodesk.Revit.DB.LinkElementId)`

#### Summary

Creates a new instance of a NumberSystem associated to a host element, a view, and a reference level of stairs if in a multistory stairs.

#### Remarks

In multistory stairs, a stairs element could be a stair group or individual stair.
This method allows to add a NumberSystem for a run of an individual stairs or a stairs group member on the placementLevelId.

#### Parameter `document`

The document.

#### Parameter `viewId`

The view in which the NumberSystem will be created.

#### Parameter `hostElementId`

The host id on which the NumberSystem will be created.

#### Parameter `referenceOption`

The reference option of the NumberSystem.

#### Parameter `placementLevelId`

The id of the level on which the NumberSystem will be placed. The placement level must be one of the base levels of a stairs group members. It is suggested to
get the level from MultistoryStairs.GetStairsPlacementLevels().

#### Returns

The created NumberSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

viewId is not valid for placement of a NumberSystem (only floor plan views and elevation views are permitted).
-or-
hostElementId is not valid as a host for NumberSystem (only StairsRun elements are permitted in this release).
-or-
The reference option is not valid for a NumberSystem.
-or-
The placementLevelId is not one of the stairs base levels.
-or-
The hostElementId already has a number system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2018

### `M:Autodesk.Revit.DB.NumberSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.Reference)`

#### Summary

Creates a new instance of a NumberSystem associated to a host element and a view.

#### Parameter `document`

The document.

#### Parameter `viewId`

The view in which the NumberSystem will be created.

#### Parameter `numberedElementId`

The host id on which the NumberSystem will be created.

#### Parameter `referenceCurve`

The reference curve along which the NumberSystem will be created. It is suggested to get the new reference via GetNumberSystemReference() from the host element.

#### Returns

The created NumberSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

viewId is not valid for placement of a NumberSystem (only floor plan views and elevation views are permitted).
-or-
numberedElementId is not valid as a host for NumberSystem (only StairsRun elements are permitted in this release).
-or-
The referenceCurve is not valid for NumberSystem on numberedElementId.
-or-
The numberedElementId already has a NumberSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.NumberSystem.SetReferencePick(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberSystem.SetReferencePick(Autodesk.Revit.DB.Reference)`

#### Summary

Sets the reference pick.

#### Remarks

It is suggested to get the new reference via GetNumberSystemReference() from the host element.

#### Parameter `referencePick`

The pick to set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The referencePick is not a valid reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.NumberSystem.GetReferencePick`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberSystem.GetReferencePick`

#### Summary

Gets the reference curve.

#### Returns

The pick of reference curve.

#### Since

2013

### `P:Autodesk.Revit.DB.NumberSystem.JustifyOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumberSystem.JustifyOption`

#### Summary

The number justify option of number system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.NumberSystem.NumberOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumberSystem.NumberOrientation`

#### Summary

The number orientation of number system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: Orientation AnyModelDirection is not supported
-or-
When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.NumberSystem.NumberDisplayRule`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumberSystem.NumberDisplayRule`

#### Summary

The display rule of the number system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.NumberSystem.NumberedElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumberSystem.NumberedElementId`

#### Summary

The LinkElementId of the numbered host element.

#### Since

2013

### `P:Autodesk.Revit.DB.NumberSystem.PlacementLevelId`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumberSystem.PlacementLevelId`

#### Summary

The id of the base level of stairs on which the NumberSystem is placed.

#### Remarks

In multistory stairs, a stairs element could be a stair group or individual stair, this level could be the base level of group member or stairs element.

#### Since

2018

### `P:Autodesk.Revit.DB.NumberSystem.JustifyOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumberSystem.JustifyOffset`

#### Summary

The offset to the justification curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for justifyOffset must be no more than 30000 feet in absolute value.

#### Since

2013

### `P:Autodesk.Revit.DB.NumberSystem.ReferenceOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumberSystem.ReferenceOffset`

#### Summary

The offset to the reference curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for referenceOffset must be no more than 30000 feet in absolute value.

#### Since

2013

### `T:Autodesk.Revit.DB.NumberSystem`

Member kind: type
Symbol: `Autodesk.Revit.DB.NumberSystem`

#### Summary

An annotation that consists of a series of numeric tags attached to and describing a host element.

#### Remarks

For a component-based stair, you can display tread/riser numbers for a run in plan, elevation, or section view. Sketch-based stair is not supported.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Stairs.GetAssociatedRailings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.GetAssociatedRailings`

#### Summary

Gets a list of the Railing elements which are associated to the boundaries of the stairs.

#### Remarks

This does not return railings which are sketched directly to the stairs (and are not
associated to boundaries).

#### Returns

The ids of the Railing elements.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Stairs.GetStairsSupports`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.GetStairsSupports`

#### Summary

Returns all the stairs support components in the stairs.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Stairs.GetStairsLandings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.GetStairsLandings`

#### Summary

Returns all the stairs landing components in the stairs.

#### Returns

The stairs landing components in the stairs.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Stairs.GetStairsRuns`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.GetStairsRuns`

#### Summary

Returns all the stairs run components in the stairs.

#### Returns

The stairs run components in the stairs.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Stairs.IsByComponent(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.IsByComponent(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Indicates if the stairs is created by stairs components(runs, landings and supports).

#### Parameter `document`

The document.

#### Parameter `stairsId`

The stairs element to check.

#### Returns

True if the stairs is created by components, False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element stairsId does not exist in the document

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Stairs.IsInEditMode`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.IsInEditMode`

#### Summary

Indicates whether the stairs is in edit mode or not.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Stairs.MultistoryStairsId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.MultistoryStairsId`

#### Summary

The id of the MultistoryStairs element to which this element belongs.
If this stairs element is not a member of a MultistoryStairs element, this will be InvalidElementId.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Stairs.NumberOfStories`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.NumberOfStories`

#### Summary

The number of stories of a multi-story stair, or 1 for a single-story stair.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Stairs.ActualTreadsNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.ActualTreadsNumber`

#### Summary

The number of treads actually created in the stairs.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Stairs.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.Height`

#### Summary

The height of the stair between the base and top levels.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for stairsHeight must be greater than 0 and no more than 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The stairs top level is not "None", so the height cannot be set independently.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Stairs.TopElevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.TopElevation`

#### Summary

The top elevation of the stairs.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Stairs.BaseElevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.BaseElevation`

#### Summary

The base elevation of the stairs.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Stairs.DesiredRisersNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.DesiredRisersNumber`

#### Summary

The number of risers is calculated based on the height between levels.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for numberOfRisers is not positive.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Stairs.ActualRisersNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.ActualRisersNumber`

#### Summary

The total number of actually created risers in model.

#### Remarks

The number of steps needed to go through when moving from the base level to the top level of the stairs.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Stairs.ActualTreadDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.ActualTreadDepth`

#### Summary

The actual depth of the stairs treads in the stairs, actual tread depth is equal to minimum tread depth by default.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for actualTreadDepth must be greater than 0 and no more than 30000 feet.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Stairs.ActualRiserHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Stairs.ActualRiserHeight`

#### Summary

The actual height of the stairs risers in the stairs.

#### Remarks

The stairs height is determined by its base and top elevation. So, the actual riser height = stairs height / desired riser number.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.Stairs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.Stairs`

#### Summary

Represents a stairs element in Autodesk Revit.

#### Remarks

This element may represent a standalone Stairs element, or a member of a MultistoryStairs element.
Use `P:Autodesk.Revit.DB.Architecture.Stairs.MultistoryStairsId` to identify if this Stairs element is a part of a MultistoryStairs.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.CanDisconnectLevel(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.CanDisconnectLevel(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the given level can be disconnected from multistory stairs.
You cannot disconnect the levels of standard stair (the stair associated with the Reference Level for the multistory stairs) or already disconnected.

#### Parameter `levelId`

The id of the level.

#### Returns

True if the level id can be used to remove stairs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.CanConnectLevel(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.CanConnectLevel(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the given level can be connected into multistory stairs.
You cannot connect levels between standard stairs top and bottom or already connected.

#### Parameter `levelId`

The id of the level.

#### Returns

True if the level can be connected to this multistory stairs, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.GetStairsOnLevel(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.GetStairsOnLevel(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the individual stairs or stairs group on the given base level.

#### Parameter `levelId`

The base level id.

#### Returns

The id of stairs element on the given level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.Pin(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.Pin(Autodesk.Revit.DB.ElementId)`

#### Summary

Restores an unpinned stairs element back into the group of stairs governed by level height.

#### Remarks

If the level height of current story can be found among other stories, the stair will be added back into the group;
Otherwise only the status will be changed to "pinned".

#### Parameter `levelId`

The base level id.
If the level id belongs to the base level of an individual pinned stairs, it returns the stairs id directly.

#### Returns

The stairs element which the pinned story belongs to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There is no stairs instance at the given base levelId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.Unpin(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.Unpin(Autodesk.Revit.DB.ElementId)`

#### Summary

Removes a particular story of the stairs (identified by its base level id) from a stairs group.

#### Remarks

If the story at the given level is in a group, it will separate an individual stairs element from the group with "unpinned" status. Changes you make to the returned stairs element will not affect any other stairs.
If the story of stairs is already an individual stairs element, the status will be changed to "unpinned".

#### Parameter `levelId`

The base level id.
If the level id belongs to the base level of a unpinned stairs element, it returns the stairs id directly.

#### Returns

The unpinned stairs element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There is no stairs instance at the given base levelId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.GetAllConnectedLevels`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.GetAllConnectedLevels`

#### Summary

Gets all connected level ids of this multistory stairs.

#### Returns

The ids of connected levels.

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.IsPinned(Autodesk.Revit.DB.Architecture.Stairs)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.IsPinned(Autodesk.Revit.DB.Architecture.Stairs)`

#### Summary

Checks if a stair is pinned.

#### Parameter `stairs`

A stairs element in this multistory stairs element.

#### Returns

Returns true if the stairs is pinned; otherwise returns false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input stairs is not a member of this multistory stairs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.GetStairsPlacementLevels(Autodesk.Revit.DB.Architecture.Stairs)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.GetStairsPlacementLevels(Autodesk.Revit.DB.Architecture.Stairs)`

#### Summary

Gets all the levels the given stairs group placed on.

#### Remarks

If a stairs element is a stairs group, it gets all the base levels of each member of the group;
If a stairs element is an individual stairs, it just gets the base level of the stairs element.

#### Parameter `stairs`

A stairs element in this multistory stairs element.

#### Returns

The ids of base levels of the given stairs in this multistory stairs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input stairs is not a member of this multistory stairs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.GetAllStairsIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.GetAllStairsIds`

#### Summary

Gets the ids of all the stairs in this multistory stairs.

#### Remarks

Stairs elements returned by this method will either be members of groups of identical stairs instances which share the same level height, or individual Stairs instances which are not connected to a group with the same level height.
Use `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.IsPinned(Autodesk.Revit.DB.Architecture.Stairs)` to identify if a Stairs is a member of a group or not.

#### Returns

The ids of the stairs elements that govern groups of stairs, and the stairs elements that represent individual stairs.

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.DisconnectLevels(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.DisconnectLevels(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Shrinks the multistory stairs by disconnecting input levels.

#### Remarks

If you remove a stairs that is connected at the top and bottom to another level stairs, the remaining stairs will automatically adjust to maintain the multistory stairs.
The stairs above the one that is removed extends to attach to the stairs on the level below the one that is removed.
You cannot disconnect the levels of standard stair (the stair associated with the Reference Level for the multistory stairs) or already disconnected.

#### Parameter `levelIds`

The level ids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This multistory stairs cannot disconnect from one or more members of levelIds.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.ConnectLevels(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.ConnectLevels(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Extends the multistory stairs by connecting input levels.

#### Remarks

The added stairs will be categorized into different groups based on level heights automatically. Stairs with the same level height are considered a group and can be edited together.
You cannot connect the levels between standard stairs top and bottom or already connected.

#### Parameter `levelIds`

The level ids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This multistory stairs cannot connect to one or more members of levelIds.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.IsAcceptableForMultistoryStairs(Autodesk.Revit.DB.Architecture.Stairs)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.IsAcceptableForMultistoryStairs(Autodesk.Revit.DB.Architecture.Stairs)`

#### Summary

Checks if the given stairs can be used to create a multistory stairs.

#### Parameter `stairs`

The given stairs to check.

#### Returns

Returns true if the stairs can be used to create a multistory stairs; otherwise returns false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.Create(Autodesk.Revit.DB.Architecture.Stairs)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.Create(Autodesk.Revit.DB.Architecture.Stairs)`

#### Summary

Creates a multistory stairs from an existing component-based stairs.

#### Parameter `stairs`

A component-based stairs.

#### Returns

The newly created element. Use `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.ConnectLevels(System.Collections.Generic.ISet`1{Autodesk.Revit.DB.ElementId})` to extend this to multiple stories and generate stairs groups for each level height.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.Architecture.MultistoryStairs.StandardStairsId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.StandardStairsId`

#### Summary

Id of the stair associated with the Reference Level for the multistory stairs.
The standard stair is regarded as a definition to generate new stairs when extending multistory stairs to a different level height.

#### Since

2018

### `P:Autodesk.Revit.DB.Architecture.MultistoryStairs.ActualTreadDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs.ActualTreadDepth`

#### Summary

The actual depth of the stairs treads in the stairs, actual tread depth is equal to minimum tread depth by default.

#### Remarks

In a multistory stairs, all the stairs elements keep the same tread depth parameter value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for actualTreadDepth must be greater than 0 and no more than 30000 feet.

#### Since

2018

### `T:Autodesk.Revit.DB.Architecture.MultistoryStairs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.MultistoryStairs`

#### Summary

Represents a multistory stairs element in Autodesk Revit.

#### Remarks

A multistory stairs element may contain multiple stairs whose extents are governed by base and top levels.
Use `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.ConnectLevels(System.Collections.Generic.ISet`1{Autodesk.Revit.DB.ElementId})` and `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.DisconnectLevels(System.Collections.Generic.ISet`1{Autodesk.Revit.DB.ElementId})` to add and remove connected levels to a multistory stairs element.

This element will contain one or more Stairs elements. These can be obtained via `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.GetAllStairsIds` and `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.GetStairsOnLevel(Autodesk.Revit.DB.ElementId)` .
Stairs elements are either a reference instance which is copied to each level covered by groups of identical stairs instances which share the same level height,
or individual Stairs instances which are not connected to a group with the same level height. By default, when adding new levels to the multistory stair,
new stairs will be added to the group (shown in the Revit user interface with a 'Pin' icon).

For groups of duplicate stairs at different levels, the instances can be found as Subelements of the Stairs element (see
`M:Autodesk.Revit.DB.Element.GetSubelements` .

Stairs in a connected group can be edited together by modifying the associated Stairs instance. For specific floors that need special designs,
stairs can be separated from a group by unpinning the element, changes made to this Stairs will not affect other any other instance in the element.
Use `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.Unpin(Autodesk.Revit.DB.ElementId)` for this.

You can add the stairs back into the group via `M:Autodesk.Revit.DB.Architecture.MultistoryStairs.Pin(Autodesk.Revit.DB.ElementId)` if needed. However, any changes made to the stair will be lost since the stair's properties
will be overridden by the group specifications.

#### Since

2018

### `P:Autodesk.Revit.DB.Architecture.HandRailType.SupportJustification`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.HandRailType.SupportJustification`

#### Summary

The support justification method of the handrail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The rail has no support or the support layout is not fixed distance so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.HandRailType.SupportLayout`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.HandRailType.SupportLayout`

#### Summary

The support layout method of the handrail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The rail has no support specified so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.HandRailType.SupportNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.HandRailType.SupportNumber`

#### Summary

The number of supports of the handrail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for supportNumber is negative.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The rail has no support or the support layout is not fixed number so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.HandRailType.SupportTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.HandRailType.SupportTypeId`

#### Summary

The support type of the handrail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The supportTypeId is not a valid rail support or invalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.HandRailType.SupportSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.HandRailType.SupportSpacing`

#### Summary

The support spacing of the handrail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for supportSpacing must be between 0 and 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The rail has no support or the support has inappropriate layout so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.HandRailType.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.HandRailType.Height`

#### Summary

The height of the handrail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for height must be between 0 and 30000 feet.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.HandRailType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.HandRailType`

#### Summary

A rail type object that is used in the generation of hand rail.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRailType.HandClearance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRailType.HandClearance`

#### Summary

The horizontal distance between the inner boundary of the rail and the path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for clearance must be no more than 30000 feet in absolute value.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRailType.Projection`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRailType.Projection`

#### Summary

The horizontal distance between the outer boundary of the rail and the path.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRailType.EndOrTopTermination`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRailType.EndOrTopTermination`

#### Summary

The termination of the rail at the end or top.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The termination is not a valid termination symbol for continuous rail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRailType.StartOrBottomTermination`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRailType.StartOrBottomTermination`

#### Summary

The termination of the rail at the beginning or bottom.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The termination is not a valid termination symbol for continuous rail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRailType.FilletRadius`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRailType.FilletRadius`

#### Summary

The fillet radius of the rail join.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for filletRadius must be between 0 and 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The join option of the rail is not fillet so the data being set is not applicable.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRailType.DefaultJoinOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRailType.DefaultJoinOption`

#### Summary

The default join option between two rails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRailType.Transition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRailType.Transition`

#### Summary

The transition option of the rail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRailType.EndOrTopExtensionStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRailType.EndOrTopExtensionStyle`

#### Summary

The extension style of the rail termination at the end or top.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRailType.StartOrBottomExtensionStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRailType.StartOrBottomExtensionStyle`

#### Summary

The extension style of the rail termination at the beginning or bottom.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRailType.ProfileId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRailType.ProfileId`

#### Summary

The id of the profile of the rail

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The profileId is neither a valid element id nor invalidElementId.
-or-
When setting this property: The profileId is not a valid profile symbol for continuous rail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRailType.EndOrTopExtensionLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRailType.EndOrTopExtensionLength`

#### Summary

The extension length of the rail termination at the end or top.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for endExtensionLength must be between 0 and 30000 feet.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRailType.StartOrBottomExtensionLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRailType.StartOrBottomExtensionLength`

#### Summary

The extension length of the rail termination at the beginning or bottom.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for startExtensionLength must be between 0 and 30000 feet.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.ContinuousRailType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRailType`

#### Summary

A type element containing the properties of a continuous rail.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.HandRail`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.HandRail`

#### Summary

Represents a hand rail element in Autodesk Revit.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.ContinuousRail.GetSupports`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRail.GetSupports`

#### Summary

Returns all the railing supports attached to the rail.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.ContinuousRail.GetEndExtensionPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRail.GetEndExtensionPath`

#### Summary

Retrieves the start extension path.

#### Returns

The start extension path of the rail.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.ContinuousRail.GetStartExtensionPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRail.GetStartExtensionPath`

#### Summary

Retrieves the start extension path.

#### Returns

The start extension path of the rail.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.ContinuousRail.GetPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRail.GetPath`

#### Summary

Retrieves the rail path.

#### Returns

The path of the rail.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRail.HostRailingId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRail.HostRailingId`

#### Summary

The id of the host Railing that contains this rail.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.ContinuousRail.Length`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRail.Length`

#### Summary

The length of the rail.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.ContinuousRail`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.ContinuousRail`

#### Summary

Represents a continuous rail element in Autodesk Revit.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.CutMarkType.CutLineType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.CutMarkType.CutLineType`

#### Summary

The cut line type of the cut mark.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.CutMarkType.CutMarkSymbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.CutMarkType.CutMarkSymbol`

#### Summary

The symbol type of the cut mark.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.CutMarkType.CutLineDistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.CutMarkType.CutLineDistance`

#### Summary

The distance between 2 cut lines.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for distanceBetweenTwoLines must be greater than 0 and no more than 30000 feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The cut mark type is not a double cut line type.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.CutMarkType.CutLineExtension`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.CutMarkType.CutLineExtension`

#### Summary

The extension distance to the boundary.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for extensionDistanceToBoundary must be between 0 and 30000 feet.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.CutMarkType.CutLineAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.CutMarkType.CutLineAngle`

#### Summary

The rotation angle of the cut mark.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for rotationAngle is not finite

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.CutMarkType.CutMarkSymbolSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.CutMarkType.CutMarkSymbolSize`

#### Summary

The size of the cut mark symbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for cutMarkSymbolSize must be greater than 0 and no more than 30000 feet.

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.CutMarkType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.CutMarkType`

#### Summary

An object represents the cut mark type in Autodesk Revit.

#### Since

2013

### `T:Autodesk.Revit.DB.NumberSystemJustifyOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.NumberSystemJustifyOption`

#### Summary

The available options for justification of the numbers in a number system.

#### Since

2013

### `F:Autodesk.Revit.DB.NumberSystemJustifyOption.Back`

Member kind: field
Symbol: `Autodesk.Revit.DB.NumberSystemJustifyOption.Back`

#### Summary

The number will locate in back of the annotated object along the annotating direction.

### `F:Autodesk.Revit.DB.NumberSystemJustifyOption.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.NumberSystemJustifyOption.Center`

#### Summary

The number will locate in the center of the annotated object along the annotating direction.

### `F:Autodesk.Revit.DB.NumberSystemJustifyOption.Front`

Member kind: field
Symbol: `Autodesk.Revit.DB.NumberSystemJustifyOption.Front`

#### Summary

The number will locate in front of the annotated object along the annotating direction.

### `T:Autodesk.Revit.DB.Architecture.StairsPathDirection`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathDirection`

#### Summary

The direction style of stairs path.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.StairsPathDirection.AutomaticUpDown`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathDirection.AutomaticUpDown`

#### Summary

The direction of the stair path will be determined automatically.

### `F:Autodesk.Revit.DB.Architecture.StairsPathDirection.AlwaysUp`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathDirection.AlwaysUp`

#### Summary

The direction of the stair path will always be UP direction.

### `T:Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption`

#### Summary

The reference types permitted for a number system to refer to the geometry of a stairs run.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption.RightQuarter`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption.RightQuarter`

#### Summary

The number system reference to right quarter of stairs

### `F:Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption.LeftQuarter`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption.LeftQuarter`

#### Summary

The number system reference to left quarter of stairs

### `F:Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption.Right`

#### Summary

The number system reference to right boundary of stairs.

### `F:Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption.Left`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption.Left`

#### Summary

The number system reference to left boundary of stairs.

### `F:Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption.Center`

#### Summary

The number system reference to stairs path.

### `T:Autodesk.Revit.DB.NumberSystemDisplayRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.NumberSystemDisplayRule`

#### Summary

The available options for display of numeric values in the number system.

#### Since

2013

### `F:Autodesk.Revit.DB.NumberSystemDisplayRule.StartAndEnd`

Member kind: field
Symbol: `Autodesk.Revit.DB.NumberSystemDisplayRule.StartAndEnd`

#### Summary

The number system will only display the start and end numbers.

### `F:Autodesk.Revit.DB.NumberSystemDisplayRule.Even`

Member kind: field
Symbol: `Autodesk.Revit.DB.NumberSystemDisplayRule.Even`

#### Summary

The number system will only display the even numbers.

### `F:Autodesk.Revit.DB.NumberSystemDisplayRule.Odd`

Member kind: field
Symbol: `Autodesk.Revit.DB.NumberSystemDisplayRule.Odd`

#### Summary

The number system will only display the odd numbers.

### `F:Autodesk.Revit.DB.NumberSystemDisplayRule.All`

Member kind: field
Symbol: `Autodesk.Revit.DB.NumberSystemDisplayRule.All`

#### Summary

The number system will display all the numbers.

### `T:Autodesk.Revit.DB.Architecture.CutLineType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.CutLineType`

#### Summary

The available line types for a stairs cut line.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.CutLineType.DoubleLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.CutLineType.DoubleLine`

#### Summary

Cutline type is double-line.

### `F:Autodesk.Revit.DB.Architecture.CutLineType.SingleLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.CutLineType.SingleLine`

#### Summary

Cutline type is single-line.

### `T:Autodesk.Revit.DB.Architecture.CutMarkSymbol`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.CutMarkSymbol`

#### Summary

The available shapes for the cut mark symbol.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.CutMarkSymbol.Curve`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.CutMarkSymbol.Curve`

#### Summary

Cut mark shape is curved.

### `F:Autodesk.Revit.DB.Architecture.CutMarkSymbol.Zigzag`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.CutMarkSymbol.Zigzag`

#### Summary

Cut mark shape is zigzagged.

### `F:Autodesk.Revit.DB.Architecture.CutMarkSymbol.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.CutMarkSymbol.None`

#### Summary

Cut mark shape is linear.

### `T:Autodesk.Revit.DB.Architecture.StairsPathLineShapeAtCorner`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathLineShapeAtCorner`

#### Summary

The options for the line shape of a stairs path at a corner.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.StairsPathLineShapeAtCorner.Curved`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathLineShapeAtCorner.Curved`

#### Summary

The line shape of stairs path at the corner is curved.

### `F:Autodesk.Revit.DB.Architecture.StairsPathLineShapeAtCorner.Straight`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsPathLineShapeAtCorner.Straight`

#### Summary

The line shape of stairs path at the corner is straight.

### `T:Autodesk.Revit.DB.Architecture.StairsTextOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.StairsTextOrientation`

#### Summary

The options to be used when orienting text annotations relative to stairs.

#### Since

2013

### `F:Autodesk.Revit.DB.Architecture.StairsTextOrientation.Vertical`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsTextOrientation.Vertical`

#### Summary

Indicator text will be displayed vertically.

### `F:Autodesk.Revit.DB.Architecture.StairsTextOrientation.Horizontal`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.StairsTextOrientation.Horizontal`

#### Summary

Indicator text will be displayed horizontally.

### `P:Autodesk.Revit.DB.ViewSheetSet.IsAutomatic`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSheetSet.IsAutomatic`

#### Summary

Automatic order or manual order.

### `P:Autodesk.Revit.DB.ViewSheetSet.ViewOrganizationId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSheetSet.ViewOrganizationId`

#### Summary

`T:Autodesk.Revit.DB.ElementId` to the `T:Autodesk.Revit.DB.BrowserOrganization` for non-sheet views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the `T:Autodesk.Revit.DB.ElementId` does not reference to `T:Autodesk.Revit.DB.BrowserOrganization` , or the target type of `T:Autodesk.Revit.DB.BrowserOrganization` is incompatible.

#### Remarks

Ignored when `!:Autodesk::Revit::DB::PrintSetup::IsAutomatic` is `false` .

### `P:Autodesk.Revit.DB.ViewSheetSet.SheetOrganizationId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSheetSet.SheetOrganizationId`

#### Summary

`T:Autodesk.Revit.DB.ElementId` to the `T:Autodesk.Revit.DB.BrowserOrganization` for sheets.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the `T:Autodesk.Revit.DB.ElementId` does not reference to `T:Autodesk.Revit.DB.BrowserOrganization` , or the target type of `T:Autodesk.Revit.DB.BrowserOrganization` is incompatible.

#### Remarks

Ignored when `!:Autodesk::Revit::DB::PrintSetup::IsAutomatic` is `false` .

### `P:Autodesk.Revit.DB.ViewSheetSet.OrderedViewList`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSheetSet.OrderedViewList`

#### Summary

Ordered views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input ordered view list is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the set operation failed due to invalid view which cannot be printed.

### `P:Autodesk.Revit.DB.ViewSheetSet.Views`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSheetSet.Views`

#### Summary

The views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input views is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the set operation failed due to invalid view which cannot be printed.

### `P:Autodesk.Revit.DB.ViewSheetSet.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSheetSet.Name`

#### Summary

The view sheet set name.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when trying to set the name. Instead, set the name with the `M:Autodesk.Revit.DB.PrintSetup.Rename(System.String)` method.

### `T:Autodesk.Revit.DB.ViewSheetSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewSheetSet`

#### Summary

Represents ViewSheetSets stored in a document.
ViewSheetSets can be stored so that the same printing task can be executed multiple times.

#### Remarks

For the in-session ViewSheetSet, see the class `T:Autodesk.Revit.DB.InSessionViewSheetSet` .
Changes of ViewSheetSet would be effiective after `!:Autodesk::Revit::DB::ViewSheetSetting::Save`

### `P:Autodesk.Revit.DB.InSessionViewSheetSet.IsAutomatic`

Member kind: property
Symbol: `Autodesk.Revit.DB.InSessionViewSheetSet.IsAutomatic`

#### Summary

Automatic order or manual order.

### `P:Autodesk.Revit.DB.InSessionViewSheetSet.ViewOrganizationId`

Member kind: property
Symbol: `Autodesk.Revit.DB.InSessionViewSheetSet.ViewOrganizationId`

#### Summary

`T:Autodesk.Revit.DB.ElementId` to the `T:Autodesk.Revit.DB.BrowserOrganization` for non-sheet views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the `T:Autodesk.Revit.DB.ElementId` does not reference to `T:Autodesk.Revit.DB.BrowserOrganization` , or the target type of `T:Autodesk.Revit.DB.BrowserOrganization` is incompatible.

### `P:Autodesk.Revit.DB.InSessionViewSheetSet.SheetOrganizationId`

Member kind: property
Symbol: `Autodesk.Revit.DB.InSessionViewSheetSet.SheetOrganizationId`

#### Summary

`T:Autodesk.Revit.DB.ElementId` to the `T:Autodesk.Revit.DB.BrowserOrganization` for sheets.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the `T:Autodesk.Revit.DB.ElementId` does not reference to `T:Autodesk.Revit.DB.BrowserOrganization` , or the target type of `T:Autodesk.Revit.DB.BrowserOrganization` is incompatible.

### `P:Autodesk.Revit.DB.InSessionViewSheetSet.OrderedViewList`

Member kind: property
Symbol: `Autodesk.Revit.DB.InSessionViewSheetSet.OrderedViewList`

#### Summary

Ordered views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input ordered view list is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the set operation failed due to invalid view which cannot be printed.

### `P:Autodesk.Revit.DB.InSessionViewSheetSet.Views`

Member kind: property
Symbol: `Autodesk.Revit.DB.InSessionViewSheetSet.Views`

#### Summary

The views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input views is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the set operation failed due to invalid view which cannot be printed.

### `T:Autodesk.Revit.DB.InSessionViewSheetSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.InSessionViewSheetSet`

#### Summary

Represents the in-session ViewSheetSet.

#### Remarks

The in-session ViewSheetSet can't be stored in document.

### `P:Autodesk.Revit.DB.IViewSheetSet.IsAutomatic`

Member kind: property
Symbol: `Autodesk.Revit.DB.IViewSheetSet.IsAutomatic`

#### Summary

Automatic order or manual order.

### `P:Autodesk.Revit.DB.IViewSheetSet.ViewOrganizationId`

Member kind: property
Symbol: `Autodesk.Revit.DB.IViewSheetSet.ViewOrganizationId`

#### Summary

`T:Autodesk.Revit.DB.ElementId` to the `T:Autodesk.Revit.DB.BrowserOrganization` for non-sheet views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the `T:Autodesk.Revit.DB.ElementId` does not reference to `T:Autodesk.Revit.DB.BrowserOrganization` , or the target type of `T:Autodesk.Revit.DB.BrowserOrganization` is incompatible.

### `P:Autodesk.Revit.DB.IViewSheetSet.SheetOrganizationId`

Member kind: property
Symbol: `Autodesk.Revit.DB.IViewSheetSet.SheetOrganizationId`

#### Summary

`T:Autodesk.Revit.DB.ElementId` to the `T:Autodesk.Revit.DB.BrowserOrganization` for sheets.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the `T:Autodesk.Revit.DB.ElementId` does not reference to `T:Autodesk.Revit.DB.BrowserOrganization` , or the target type of `T:Autodesk.Revit.DB.BrowserOrganization` is incompatible.

### `P:Autodesk.Revit.DB.IViewSheetSet.OrderedViewList`

Member kind: property
Symbol: `Autodesk.Revit.DB.IViewSheetSet.OrderedViewList`

#### Summary

Ordered views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input ordered view list is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the set operation failed due to invalid view which cannot be printed.

### `P:Autodesk.Revit.DB.IViewSheetSet.Views`

Member kind: property
Symbol: `Autodesk.Revit.DB.IViewSheetSet.Views`

#### Summary

The views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input views is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the set operation failed due to invalid view which cannot be printed.

### `T:Autodesk.Revit.DB.IViewSheetSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.IViewSheetSet`

#### Summary

This interface represents a selected set of views/sheets which will be used for printing.

### `T:Autodesk.Revit.DB.Structure.TrussType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.TrussType`

#### Summary

Represents a specific type of truss.

### `M:Autodesk.Revit.DB.Structure.Truss.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Truss.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Curve)`

#### Summary

Creates a new Truss.

#### Parameter `document`

The document in which the new Truss is created.

#### Parameter `trussTypeId`

Element id of the truss type.

#### Parameter `sketchPlaneId`

Element id of a SketchPlane.

#### Parameter `curve`

The curve of the truss element.
It must be a line, must not be a vertical line, and must be within the sketch plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve points to a helical curve and is not supported for this operation.
-or-
The element id should refer to a valid TrussType.
-or-
The element id should refer to a valid SketchPlane.
-or-
The curve is invalid to be the base curve of a truss.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This function is only enabled in Revit Structure and Revit Architecture.
-or-
Failed to create Truss element.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.Truss.DropTruss(Autodesk.Revit.DB.Structure.Truss)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Truss.DropTruss(Autodesk.Revit.DB.Structure.Truss)`

#### Summary

Drop truss Family, it will disassociate all members from the truss and delete the truss.

#### Parameter `truss`

The truss to be dropped.

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.Truss.TogglePinMember(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Truss.TogglePinMember(Autodesk.Revit.DB.ElementId)`

#### Summary

Pin/Unpin a truss member.

#### Parameter `elemId`

The member element is going to pin/unpin.

### `M:Autodesk.Revit.DB.Structure.Truss.GetTrussMemberInfo(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Truss.GetTrussMemberInfo(Autodesk.Revit.DB.ElementId)`

#### Summary

Query if a given element is a member of a truss, its lock status and its usage, etc.

#### Parameter `elemId`

The querying element.

#### Returns

A struct TrussMemberInfo that contains the querying element's host truss, whether to lock to the truss, usage type, etc.

### `M:Autodesk.Revit.DB.Structure.Truss.RemoveProfile`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Truss.RemoveProfile`

#### Summary

Remove the profile of a truss.

### `M:Autodesk.Revit.DB.Structure.Truss.SetProfile(Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.CurveArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Truss.SetProfile(Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.CurveArray)`

#### Summary

Add or modify the profile of a truss.

#### Parameter `topChords`

The curves serving as top chords of the truss.

#### Parameter `bottomChords`

The curves serving as bottom chords of the truss.

### `M:Autodesk.Revit.DB.Structure.Truss.DetachChord(Autodesk.Revit.DB.Structure.TrussChordLocation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Truss.DetachChord(Autodesk.Revit.DB.Structure.TrussChordLocation)`

#### Summary

Detach a truss's specific chord from the element to which it is attached.

#### Parameter `location`

The chord.

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.Truss.AttachChord(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.TrussChordLocation,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Truss.AttachChord(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.TrussChordLocation,System.Boolean)`

#### Summary

Attach a truss's specific chord to a specified element, the element should be a roof or floor.

#### Parameter `attachToElement`

The element to which the truss's chord will attach. The element should be a roof or floor.

#### Parameter `location`

The chord need to be attached.

#### Parameter `forceRemoveSketch`

Whether to detach the original sketch if there is one.

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.Truss.TrussType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Truss.TrussType`

#### Summary

Retrieve/set an object that represents the type of the truss.

### `P:Autodesk.Revit.DB.Structure.Truss.Curves`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Truss.Curves`

#### Summary

Get all the truss curves.

#### Returns

The Curves property returns a CurveArray
that contains all the truss curves.

### `P:Autodesk.Revit.DB.Structure.Truss.Members`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Truss.Members`

#### Summary

Get all the members of truss.

#### Returns

The Members property returns an ElementIdSet
that contains all the member Ids of truss.

### `T:Autodesk.Revit.DB.Structure.Truss`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.Truss`

#### Summary

Represents all kinds of Trusses.

#### Remarks

The Truss object represents all the kinds of Trusses in Revit.
The TrussType property is used to distinguish the type of the Truss.

### `T:Autodesk.Revit.DB.Structure.TrussChordLocation`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.TrussChordLocation`

#### Summary

This enumerated type represents the options for the Truss Chord Location.

#### Since

2011

### `F:Autodesk.Revit.DB.Structure.TrussChordLocation.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.TrussChordLocation.Top`

#### Summary

The top chord of the Truss.

### `F:Autodesk.Revit.DB.Structure.TrussChordLocation.Bottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.TrussChordLocation.Bottom`

#### Summary

The bottom chord of the Truss.

### `T:Autodesk.Revit.DB.TextNoteType`

Member kind: type
Symbol: `Autodesk.Revit.DB.TextNoteType`

#### Summary

An object that represents a text note style.

### `P:Autodesk.Revit.DB.SymbolicCurve.Subcategory`

Member kind: property
Symbol: `Autodesk.Revit.DB.SymbolicCurve.Subcategory`

#### Summary

The subcategory.

#### Remarks

If the family category is non-cuttable, the subcategory can be
set to be the family category or one of its subcategories.
If the family category is cuttable, the subcategory can be set as the graphics
styles of the family category, its subcategories, or the invisible lines graphics style.

### `M:Autodesk.Revit.DB.SymbolicCurve.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SymbolicCurve.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

#### Summary

Sets the visibility for the symbolic curve.

#### Remarks

The visibility of the symbolic curve geometry can be changed for different detail levels.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when visibility is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when visibility is not valid for symbolic curves.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration failed.

### `M:Autodesk.Revit.DB.SymbolicCurve.GetVisibility`

Member kind: method
Symbol: `Autodesk.Revit.DB.SymbolicCurve.GetVisibility`

#### Summary

Gets the visibility for the symbolic curve.

#### Returns

A copy of visibility settings for the symbolic curve.

### `P:Autodesk.Revit.DB.SymbolicCurve.ReferenceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.SymbolicCurve.ReferenceType`

#### Summary

Indicates the type of reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when argument is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration failed.

### `P:Autodesk.Revit.DB.SymbolicCurve.IsDrawnInForeground`

Member kind: property
Symbol: `Autodesk.Revit.DB.SymbolicCurve.IsDrawnInForeground`

#### Summary

Indicates if this curve will be drawn in the foreground of the family instance.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration failed.
Thrown when the value for this property cannot be changed.

### `T:Autodesk.Revit.DB.SymbolicCurve`

Member kind: type
Symbol: `Autodesk.Revit.DB.SymbolicCurve`

#### Summary

A curve that provides information but is not intended to represent actual geometry in an element.

#### Remarks

For example, when creating a door family, you might sketch symbolic lines in an elevation view to represent a door swing.
Symbolic curves are visible parallel to the view in which you sketch them.

### `T:Autodesk.Revit.DB.SlabEdgeType`

Member kind: type
Symbol: `Autodesk.Revit.DB.SlabEdgeType`

#### Summary

An object that represents the slab edge type
in Autodesk Revit.

### `M:Autodesk.Revit.DB.SlabEdge.AddSegment(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabEdge.AddSegment(Autodesk.Revit.DB.Reference)`

#### Summary

Add segments to the slab edge.

#### Parameter `targetRef`

Segment's reference on which want to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

This exception will be thrown in following cases:
1. Input targetRef is `null` .
2. Input targetRef is not `null` but contains nothing.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This exception will be thrown in following cases:
1. Input targetRef has already been added into the slab edge.
2. Internal code fails to create the segment object.
3. Regeneration fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

This exception will be thrown if the reference is suitable for creating a slab edge as required.
The reference allowed is :
1. Model Line
2. Floor's horizontal edges
3. Other slab edge's horizontal edges

### `P:Autodesk.Revit.DB.SlabEdge.SlabEdgeType`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabEdge.SlabEdgeType`

#### Summary

Retrieves/set an object that represents the type of the SlabEdge.

### `T:Autodesk.Revit.DB.SlabEdge`

Member kind: type
Symbol: `Autodesk.Revit.DB.SlabEdge`

#### Summary

An object that represents a slab edge within the Autodesk Revit project.

#### Remarks

This object derived from the Element base object and such supports all the
methods of that object such as the ability to retrieve the parameters of that object.

### `M:Autodesk.Revit.DB.SchedulableField.IsCustomFieldWithValidServer`

Member kind: method
Symbol: `Autodesk.Revit.DB.SchedulableField.IsCustomFieldWithValidServer`

#### Summary

Identifies if this is a `F:Autodesk.Revit.DB.ScheduleFieldType.CustomField`
and if there is added an instance of a `T:Autodesk.Revit.DB.ICustomFieldServer` to the custom field service.

#### Returns

Returns true if this is a `F:Autodesk.Revit.DB.ScheduleFieldType.CustomField`
and if there is added an instance of a `T:Autodesk.Revit.DB.ICustomFieldServer` to the custom field service.

#### Since

2013

### `M:Autodesk.Revit.DB.SchedulableField.GetName(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SchedulableField.GetName(Autodesk.Revit.DB.Document)`

#### Summary

Gets the name of the field.

#### Parameter `document`

The document in which the field will be used.

#### Returns

The name of the field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The parameter doesn't exist in document.

#### Since

2013

### `M:Autodesk.Revit.DB.SchedulableField.GetCustomFieldData`

Member kind: method
Symbol: `Autodesk.Revit.DB.SchedulableField.GetCustomFieldData`

#### Summary

Gets the data associated with this custom field. If this field isn't a `F:Autodesk.Revit.DB.ScheduleFieldType.CustomField` will return `null` .

#### Returns

Returns the data associated with this custom field. If this field isn't a `F:Autodesk.Revit.DB.ScheduleFieldType.CustomField` will return `null` .

#### Since

2024

### `P:Autodesk.Revit.DB.SchedulableField.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SchedulableField.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.SchedulableField.ParameterId`

Member kind: property
Symbol: `Autodesk.Revit.DB.SchedulableField.ParameterId`

#### Summary

The ID of the parameter displayed by the field.

#### Remarks

Most non-calculated field types require a parameter ID.
The Count field doesn't have a parameter ID.

#### Value

The parameter ID, or InvalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.SchedulableField.FieldType`

Member kind: property
Symbol: `Autodesk.Revit.DB.SchedulableField.FieldType`

#### Summary

The type of data displayed by the field.

#### Value

See ScheduleFieldType for details.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: fieldType is not a schedulable field type

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.SchedulableField.op_Inequality(Autodesk.Revit.DB.SchedulableField,Autodesk.Revit.DB.SchedulableField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SchedulableField.op_Inequality(Autodesk.Revit.DB.SchedulableField,Autodesk.Revit.DB.SchedulableField)`

#### Summary

Determines whether two SchedulableField are different.

#### Parameter `first`

The first SchedulableField.

#### Parameter `second`

The second SchedulableField.

#### Returns

True if the SchedulableField are different, otherwise false.

### `M:Autodesk.Revit.DB.SchedulableField.op_Equality(Autodesk.Revit.DB.SchedulableField,Autodesk.Revit.DB.SchedulableField)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SchedulableField.op_Equality(Autodesk.Revit.DB.SchedulableField,Autodesk.Revit.DB.SchedulableField)`

#### Summary

Determines whether two SchedulableField are the same.

#### Parameter `first`

The first SchedulableField.

#### Parameter `second`

The second SchedulableField.

#### Returns

True if the SchedulableField are the same, otherwise false.

### `M:Autodesk.Revit.DB.SchedulableField.GetHashCode`

Member kind: method
Symbol: `Autodesk.Revit.DB.SchedulableField.GetHashCode`

#### Summary

Gets the integer value of the SchedulableField as hash code

### `M:Autodesk.Revit.DB.SchedulableField.Equals(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SchedulableField.Equals(System.Object)`

#### Summary

Determines whether the specified `T:System.Object` is equal to the current `T:System.Object` .

#### Parameter `obj`

The other object to evaluate.

### `M:Autodesk.Revit.DB.SchedulableField.#ctor(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SchedulableField.#ctor(System.Guid)`

#### Summary

Creates a new SchedulableField.

#### Parameter `customFieldId`

The Guid that identifies the custom field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The provided guid doens't represent a valid custom field.

#### Since

2024

### `M:Autodesk.Revit.DB.SchedulableField.#ctor(Autodesk.Revit.DB.ScheduleFieldType,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SchedulableField.#ctor(Autodesk.Revit.DB.ScheduleFieldType,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new SchedulableField.

#### Parameter `fieldType`

The type of data displayed by the field.

#### Parameter `parameterId`

The ID of the parameter displayed by the field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fieldType is not a schedulable field type
-or-
The fieldType can't be CustomField. To create a CustomField, you should use the constructor which receives the custom field server id as a parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.SchedulableField.#ctor(Autodesk.Revit.DB.ScheduleFieldType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SchedulableField.#ctor(Autodesk.Revit.DB.ScheduleFieldType)`

#### Summary

Creates a new SchedulableField.

#### Parameter `fieldType`

The type of data displayed by the field.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

fieldType is not a schedulable field type
-or-
The fieldType can't be CustomField. To create a CustomField, you should use the constructor which receives the custom field server id as a parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.SchedulableField.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.SchedulableField.#ctor`

#### Summary

Creates a new SchedulableField.

#### Since

2013

### `T:Autodesk.Revit.DB.SchedulableField`

Member kind: type
Symbol: `Autodesk.Revit.DB.SchedulableField`

#### Summary

A non-calculated field eligible to be included in a schedule.

#### Remarks

The SchedulableField class represents a non-calculated field that is
eligible to be included in a schedule. A list of fields that can be
included in a schedule can be obtained from
ScheduleDefinition.GetSchedulableFields.

#### Since

2013

### `T:Autodesk.Revit.DB.ScheduleFieldType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleFieldType`

#### Summary

The type of data displayed in a schedule field.

#### Since

2013

#### Since

2013

### `F:Autodesk.Revit.DB.ScheduleFieldType.Sheets`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.Sheets`

#### Summary

A parameter of the sheet view owning an annotation element (e.g. Revision Cloud)

### `F:Autodesk.Revit.DB.ScheduleFieldType.Views`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.Views`

#### Summary

A parameter of the primary view owning an annotation element (e.g. Revision Cloud)

### `F:Autodesk.Revit.DB.ScheduleFieldType.Revision`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.Revision`

#### Summary

A parameter of the revision element that the scheduled revision cloud element belongs to.

### `F:Autodesk.Revit.DB.ScheduleFieldType.CustomField`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.CustomField`

#### Summary

For this field type the value for each row is computed based on the (sub)elements that are grouped on that row
and can have a graphic representation when the schedule is placed on a sheet.

### `F:Autodesk.Revit.DB.ScheduleFieldType.HostCount`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.HostCount`

#### Summary

Counts the number of hosts with different mark.

### `F:Autodesk.Revit.DB.ScheduleFieldType.CombinedParameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.CombinedParameter`

#### Summary

Combine parameters of the types that display in a specific part of a
schedule. The values for the combined parameters will display in the
same cell separated by a slash or other separator. You can add a prefix,
suffix or sample value to the parameter.

### `F:Autodesk.Revit.DB.ScheduleFieldType.PhysicalInstance`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.PhysicalInstance`

#### Summary

An instance parameter of the physical element of a scheduled analytical element.

### `F:Autodesk.Revit.DB.ScheduleFieldType.PhysicalType`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.PhysicalType`

#### Summary

A type parameter of the physical element of a scheduled analytical element.

### `F:Autodesk.Revit.DB.ScheduleFieldType.Analytical`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.Analytical`

#### Summary

A parameter of the analytical element of a scheduled physical element.

### `F:Autodesk.Revit.DB.ScheduleFieldType.Space`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.Space`

#### Summary

A parameter of the space that a scheduled element belongs to.

### `F:Autodesk.Revit.DB.ScheduleFieldType.StructuralMaterial`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.StructuralMaterial`

#### Summary

A parameter of the structural material of a scheduled element.

### `F:Autodesk.Revit.DB.ScheduleFieldType.RevitLinkType`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.RevitLinkType`

#### Summary

A parameter of the RevitLinkType that an element in a linked
file belongs to. Currently RVT_LINK_FILE_NAME_WITHOUT_EXT is the only
supported parameter. Only allowed in schedules that include
elements from linked files.

### `F:Autodesk.Revit.DB.ScheduleFieldType.RevitLinkInstance`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.RevitLinkInstance`

#### Summary

A parameter of the RevitLinkInstance that an element in a linked
file belongs to. Currently RVT_LINK_INSTANCE_NAME is the only
supported parameter. Only allowed in schedules that include
elements from linked files.

### `F:Autodesk.Revit.DB.ScheduleFieldType.MaterialQuantity`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.MaterialQuantity`

#### Summary

In a material takeoff, a value representing how a particular material
is used within a scheduled element. The parameter ID can be
MATERIAL_AREA, MATERIAL_VOLUME, or MATERIAL_ASPAINT.

### `F:Autodesk.Revit.DB.ScheduleFieldType.Material`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.Material`

#### Summary

In a material takeoff, a parameter of one of the materials of a
scheduled element.

### `F:Autodesk.Revit.DB.ScheduleFieldType.ProjectInfo`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.ProjectInfo`

#### Summary

A parameter of the Project Info element in the project that the
scheduled element belongs to, which may be a linked file. Only
allowed in schedules that include elements from linked files.

### `F:Autodesk.Revit.DB.ScheduleFieldType.ToRoom`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.ToRoom`

#### Summary

A parameter of the room on the "to" side of a door or window.

### `F:Autodesk.Revit.DB.ScheduleFieldType.FromRoom`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.FromRoom`

#### Summary

A parameter of the room on the "from" side of a door or window.

### `F:Autodesk.Revit.DB.ScheduleFieldType.Room`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.Room`

#### Summary

A parameter of the room that a scheduled element belongs to.

### `F:Autodesk.Revit.DB.ScheduleFieldType.Percentage`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.Percentage`

#### Summary

A value indicating what percent of the total of another field each
element represents.

### `F:Autodesk.Revit.DB.ScheduleFieldType.Formula`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.Formula`

#### Summary

A formula calculated from the values of other fields in the schedule.

### `F:Autodesk.Revit.DB.ScheduleFieldType.ViewBased`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.ViewBased`

#### Summary

A specialized type of field used for a few parameters whose
displayed values can change based on the settings of the view:

ROOM_AREA and ROOM_PERIMETER in room and space schedules.

PROJECT_REVISION_REVISION_NUM in revision schedules.

KEYNOTE_NUMBER in keynote legends that are numbered by sheet.

### `F:Autodesk.Revit.DB.ScheduleFieldType.Count`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.Count`

#### Summary

The number of elements appearing on the schedule row.

### `F:Autodesk.Revit.DB.ScheduleFieldType.ElementType`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.ElementType`

#### Summary

A type parameter of the scheduled elements.

### `F:Autodesk.Revit.DB.ScheduleFieldType.Instance`

Member kind: field
Symbol: `Autodesk.Revit.DB.ScheduleFieldType.Instance`

#### Summary

An instance parameter of the scheduled elements. All shared parameters
also use this type, regardless of whether they are instance or type
parameters.

### `P:Autodesk.Revit.DB.Architecture.RoomTag.TaggedRoomId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RoomTag.TaggedRoomId`

#### Summary

The LinkElementId of the tagged room.

#### Remarks

If there is no tagged room in a linked document so the RoomTag is orphaned, LinkElementId will be InvalidElementId.

#### Since

2017

### `P:Autodesk.Revit.DB.Architecture.RoomTag.TaggedLocalRoomId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RoomTag.TaggedLocalRoomId`

#### Summary

The ElementId of the tagged room.

#### Remarks

If there is no tagged room so the RoomTag is orphaned, ElementId will be InvalidElementId.

#### Since

2017

### `P:Autodesk.Revit.DB.Architecture.RoomTag.IsInRoom`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RoomTag.IsInRoom`

#### Summary

Identifies if the tag is located in a room.

#### Remarks

In some cases the tag may not be located in a room so it looses temporairly an association with the room.

#### Since

2017

### `P:Autodesk.Revit.DB.Architecture.RoomTag.RoomTagType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RoomTag.RoomTagType`

#### Summary

The tag type.

### `P:Autodesk.Revit.DB.Architecture.RoomTag.Room`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RoomTag.Room`

#### Summary

The room that the tag is associated with.

#### Remarks

In rare cases, the tag may not be associated to a room. The property will
be `null` in these situations.

### `T:Autodesk.Revit.DB.Architecture.RoomTag`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RoomTag`

#### Summary

Provides access to the room tag in Autodesk Revit.

### `P:Autodesk.Revit.DB.Revolution.Axis`

Member kind: property
Symbol: `Autodesk.Revit.DB.Revolution.Axis`

#### Summary

Returns the Axis of the Revolution.

#### Remarks

This property is used to retrieve the Axis of the Revolution.

### `P:Autodesk.Revit.DB.Revolution.EndAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Revolution.EndAngle`

#### Summary

The end angle of the revolution relative to the sketch plane.

#### Remarks

The direction of the angle is based on the normal of the sketch plane.
A positive angle is on the same side as the normal, a negative angle on the opposite side.

### `P:Autodesk.Revit.DB.Revolution.StartAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Revolution.StartAngle`

#### Summary

The start angle of the revolution relative to the sketch plane.

#### Remarks

The direction of the angle is based on the normal of the sketch plane.
A positive angle is on the same side as the normal, a negative angle on the opposite side.

### `P:Autodesk.Revit.DB.Revolution.Sketch`

Member kind: property
Symbol: `Autodesk.Revit.DB.Revolution.Sketch`

#### Summary

Returns the Sketch of the Revolution.

#### Remarks

This property is used to retrieve the Sketch of the Revolution.

### `T:Autodesk.Revit.DB.Revolution`

Member kind: type
Symbol: `Autodesk.Revit.DB.Revolution`

#### Summary

A revolution solid or void form.

### `P:Autodesk.Revit.DB.ProjectInfo.OrganizationDescription`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectInfo.OrganizationDescription`

#### Summary

Get or Set the Organization Description of the Project Information.

#### Remarks

This property is used to get or set the Project Number of the Project Information.

### `P:Autodesk.Revit.DB.ProjectInfo.OrganizationName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectInfo.OrganizationName`

#### Summary

Get or Set the Organization Name of the Project Information.

#### Remarks

This property is used to get or set the Project Number of the Project Information.

### `P:Autodesk.Revit.DB.ProjectInfo.BuildingName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectInfo.BuildingName`

#### Summary

Get or Set the Building Name of the Project Information.

#### Remarks

This property is used to get or set the Project Number of the Project Information.

### `P:Autodesk.Revit.DB.ProjectInfo.Author`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectInfo.Author`

#### Summary

Get or Set the Project Author of the Project Information.

#### Remarks

This property is used to get or set the Project Author of the Project Information.

### `P:Autodesk.Revit.DB.ProjectInfo.Number`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectInfo.Number`

#### Summary

Get or Set the Project Number of the Project Information.

#### Remarks

This property is used to get or set the Project Number of the Project Information.

### `P:Autodesk.Revit.DB.ProjectInfo.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectInfo.Name`

#### Summary

Get or Set the Project Name of the Project Information.

#### Remarks

This property is used to get or set the Project Name of the Project Information.

### `P:Autodesk.Revit.DB.ProjectInfo.Address`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectInfo.Address`

#### Summary

Get or Set the Project Address of the Project Information.

#### Remarks

This property is used to get or set the Project Address of the Project Information.

### `P:Autodesk.Revit.DB.ProjectInfo.ClientName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectInfo.ClientName`

#### Summary

Get or Set the Client Name of the Project Information.

#### Remarks

This property is used to get or set the Project Client Name of the Project Information.

### `P:Autodesk.Revit.DB.ProjectInfo.Status`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectInfo.Status`

#### Summary

Get or Set the Project Status of the Project Information.

#### Remarks

This property is used to get or set the Project Status of the Project Information.

### `P:Autodesk.Revit.DB.ProjectInfo.IssueDate`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectInfo.IssueDate`

#### Summary

Get or Set the Project Issue Date of the Project Information.

#### Remarks

This property is used to get or set the Project Issue Date of the Project Information.

### `T:Autodesk.Revit.DB.ProjectInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.ProjectInfo`

#### Summary

An object that represents a Project Information within the Autodesk Revit project.

#### Remarks

This object derived from the Element base object and such supports all the
methods of that object such as the ability to retrieve the parameters of that object.

### `P:Autodesk.Revit.DB.PrintParameters.MaskCoincidentLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.MaskCoincidentLines`

#### Summary

Indicates whether to mask coincident lines when printing.

#### Since

2015

### `P:Autodesk.Revit.DB.PrintParameters.ReplaceHalftoneWithThinLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.ReplaceHalftoneWithThinLines`

#### Summary

Indicates whether to replace halftone with thin lines when printing.

### `P:Autodesk.Revit.DB.PrintParameters.HideCropBoundaries`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.HideCropBoundaries`

#### Summary

Indicates whether to hide crop boundaries when printing.

### `P:Autodesk.Revit.DB.PrintParameters.HideScopeBoxes`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.HideScopeBoxes`

#### Summary

Indicates whether to hide scope boxes when printing.

### `P:Autodesk.Revit.DB.PrintParameters.HideUnreferencedViewTags`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.HideUnreferencedViewTags`

#### Summary

Indicates whether to hide unreferenced view tags when printing.

### `P:Autodesk.Revit.DB.PrintParameters.HideReforWorkPlanes`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.HideReforWorkPlanes`

#### Summary

Indicates whether to hide reference/work planes when printing.

### `P:Autodesk.Revit.DB.PrintParameters.ViewLinksinBlue`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.ViewLinksinBlue`

#### Summary

Indicates whether to view links in blue when printing.

### `P:Autodesk.Revit.DB.PrintParameters.ColorDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.ColorDepth`

#### Summary

The color depth type.

### `P:Autodesk.Revit.DB.PrintParameters.RasterQuality`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.RasterQuality`

#### Summary

The raster quality type.

### `P:Autodesk.Revit.DB.PrintParameters.HiddenLineViews`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.HiddenLineViews`

#### Summary

The hidden line views type.

### `P:Autodesk.Revit.DB.PrintParameters.Zoom`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.Zoom`

#### Summary

The zoom value to a percentage of the original size.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if current ZoomType is not Zoom type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown if input zoom value less than 1.

### `P:Autodesk.Revit.DB.PrintParameters.ZoomType`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.ZoomType`

#### Summary

The zoom type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument is out of range.

### `P:Autodesk.Revit.DB.PrintParameters.OriginOffsetY`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.OriginOffsetY`

#### Summary

The User defined Y value of offset from left bottom corner. Unit is feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if PaperPlacement is not Margins and MarginType is not User defined type.

### `P:Autodesk.Revit.DB.PrintParameters.OriginOffsetX`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.OriginOffsetX`

#### Summary

The User defined X value of offset from left bottom corner. Unit is feet.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if PaperPlacement is not Margins and MarginType is not User defined type.

### `P:Autodesk.Revit.DB.PrintParameters.UserDefinedMarginY`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.UserDefinedMarginY`

#### Summary

The User defined Y value of offset from left bottom corner. Unit is inch.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if PaperPlacement is not Margins and MarginType is not User defined type.

### `P:Autodesk.Revit.DB.PrintParameters.UserDefinedMarginX`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.UserDefinedMarginX`

#### Summary

The User defined X value of offset from left bottom corner. Unit is inch.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if PaperPlacement is not Margins and MarginType is not User defined type.

### `P:Autodesk.Revit.DB.PrintParameters.MarginType`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.MarginType`

#### Summary

The print margin type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the PaperPlacement is not Margins type.

### `P:Autodesk.Revit.DB.PrintParameters.PaperPlacement`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.PaperPlacement`

#### Summary

The paper placement type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument is out of range.

### `P:Autodesk.Revit.DB.PrintParameters.PaperSource`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.PaperSource`

#### Summary

The page source.

#### Remarks

User can select the candidate via `P:Autodesk.Revit.DB.PrintManager.PaperSources` and then
set the Page source of the Print Setting.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument is invalid for current printer.

### `P:Autodesk.Revit.DB.PrintParameters.PaperSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.PaperSize`

#### Summary

The page size.

#### Remarks

User can select the candidate via `P:Autodesk.Revit.DB.PrintManager.PaperSizes` and then
set the Page source of the Print Setting.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument is invalid for current printer.

### `P:Autodesk.Revit.DB.PrintParameters.PageOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintParameters.PageOrientation`

#### Summary

The Page Orientation of the Print Setting.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument is out of range.

### `T:Autodesk.Revit.DB.PrintParameters`

Member kind: type
Symbol: `Autodesk.Revit.DB.PrintParameters`

#### Summary

An object that contains settings used for printing the document.

### `M:Autodesk.Revit.DB.PrintSetting.updateCachePrintParameters`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrintSetting.updateCachePrintParameters`

#### Summary

Returns the Name of Print Setup.

### `P:Autodesk.Revit.DB.PrintSetting.PrintParameters`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintSetting.PrintParameters`

#### Summary

Returns the Parameters of Print Setup.

#### Remarks

The Parameters of Print Setup. Refer to the Print Setup dialog in Revit for details.

### `P:Autodesk.Revit.DB.PrintSetting.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrintSetting.Name`

#### Summary

Returns the Name of Print Setup.

#### Parameter `valueString`

The Name you want to set to Print Setup.

#### Remarks

Retrieve/set the name of Print Setup.

### `T:Autodesk.Revit.DB.PrintSetting`

Member kind: type
Symbol: `Autodesk.Revit.DB.PrintSetting`

#### Summary

Represents the Print Setup (Application Menu->Print->Print Setup) within Autodesk Revit.

### `P:Autodesk.Revit.DB.InSessionPrintSetting.PrintParameters`

Member kind: property
Symbol: `Autodesk.Revit.DB.InSessionPrintSetting.PrintParameters`

#### Summary

Returns the Parameters of Print Setup.

#### Remarks

The Parameters of Print Setup. Refer to the Print Setup dialog in Revit for details.

### `T:Autodesk.Revit.DB.InSessionPrintSetting`

Member kind: type
Symbol: `Autodesk.Revit.DB.InSessionPrintSetting`

#### Summary

Represents the in-session Print Setup (Application Menu->Print->Print Setup) within Autodesk Revit.

#### Remarks

The in-session PrintSetting can't be stored in document.

### `P:Autodesk.Revit.DB.IPrintSetting.PrintParameters`

Member kind: property
Symbol: `Autodesk.Revit.DB.IPrintSetting.PrintParameters`

#### Summary

Returns the Parameters of Print Setup.

#### Remarks

The Parameters of Print Setup. Refer to the Print Setup dialog in Revit for details.

### `T:Autodesk.Revit.DB.IPrintSetting`

Member kind: type
Symbol: `Autodesk.Revit.DB.IPrintSetting`

#### Summary

An interface which represents the Print Setup (Application Menu->Print->Print Setup) within Autodesk Revit.

### `T:Autodesk.Revit.DB.PanelType`

Member kind: type
Symbol: `Autodesk.Revit.DB.PanelType`

#### Summary

An object that represents a curtain panel type.

### `P:Autodesk.Revit.DB.Opening.SketchId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Opening.SketchId`

#### Summary

Returns id of the Sketch or invalidElementId if element deon't own the Sketch.

#### Since

2022

### `P:Autodesk.Revit.DB.Opening.IsTransparentInElevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Opening.IsTransparentInElevation`

#### Summary

Indicates if the opening is transparent in elevation view when loaded into the project.

#### Remarks

This property is only valid in Revit family documents.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when access this property in an opening belonging to a Revit project document.

### `P:Autodesk.Revit.DB.Opening.IsTransparentIn3D`

Member kind: property
Symbol: `Autodesk.Revit.DB.Opening.IsTransparentIn3D`

#### Summary

Indicates if the opening is transparent in 3D view when loaded into the project.

#### Remarks

This property is only valid in Revit family documents.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when access this property in an opening belonging to a Revit project document.

### `P:Autodesk.Revit.DB.Opening.Host`

Member kind: property
Symbol: `Autodesk.Revit.DB.Opening.Host`

#### Summary

Retrieves the host element of this opening.

### `P:Autodesk.Revit.DB.Opening.BoundaryCurves`

Member kind: property
Symbol: `Autodesk.Revit.DB.Opening.BoundaryCurves`

#### Summary

The geometry information for non-rectangular openings in project documents,
or for all openings in family documents.

#### Remarks

If `P:Autodesk.Revit.DB.Opening.IsRectBoundary` is true, this value is `null` .

### `P:Autodesk.Revit.DB.Opening.BoundaryRect`

Member kind: property
Symbol: `Autodesk.Revit.DB.Opening.BoundaryRect`

#### Summary

Retrieves the geometry information if the opening boundary is a rect.

#### Remarks

If `P:Autodesk.Revit.DB.Opening.IsRectBoundary` is false, this value is `null` .

### `P:Autodesk.Revit.DB.Opening.IsRectBoundary`

Member kind: property
Symbol: `Autodesk.Revit.DB.Opening.IsRectBoundary`

#### Summary

Retrieves the information whether the opening has a rectangular boundary.

#### Remarks

If the opening has a rectangular boundary, we can get the geometry information from BoundaryRect property.
Otherwise we should get the geometry information from BoundaryCurves property.

### `T:Autodesk.Revit.DB.Opening`

Member kind: type
Symbol: `Autodesk.Revit.DB.Opening`

#### Summary

An opening in an Autodesk Revit project or family document.

#### Remarks

The object represents a variety of different types of openings:
A rectangular opening in a wall created by two boundary points in a revit project.

An opening created by a set of curves applied to a roof, floor, ceiling, beam, brace or column.

A vertical shaft opening extending one or more levels.

A simple opening created on a wall or ceiling in a family document.
Depending upon the type of opening, some of the properties of this class will not be available.
This object derived from the Element base object and such supports all the methods of that object
such as the ability to retrieve the parameters of that object. This object also supports access
to a structural analytical model but this feature is only available with Autodesk Revit Structure.

### `T:Autodesk.Revit.DB.ModelTextType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelTextType`

#### Summary

A model text type symbol in the Autodesk Revit Family document.

### `P:Autodesk.Revit.DB.ModelText.Subcategory`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelText.Subcategory`

#### Summary

The subcategory.

#### Remarks

The subcategory can be set to either the family category or one of its subcategories.

### `P:Autodesk.Revit.DB.ModelText.ModelTextType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelText.ModelTextType`

#### Summary

The type for the model text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when `null` is assigned to this property.

### `P:Autodesk.Revit.DB.ModelText.HorizontalAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelText.HorizontalAlignment`

#### Summary

The horizontal alignment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when an invalid value is assigned to the property.

### `P:Autodesk.Revit.DB.ModelText.Depth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelText.Depth`

#### Summary

The depth of the model text.

### `M:Autodesk.Revit.DB.ModelText.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelText.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

#### Summary

Sets the visibility for the model text in a family document.

#### Remarks

The visibility of the model text geometry can be changed for different
types of views and detail levels in the family document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when visibility is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration failed, or the model curve is in a project document.

### `M:Autodesk.Revit.DB.ModelText.GetVisibility`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelText.GetVisibility`

#### Summary

Gets the visibility for the model text in a family document.

#### Returns

A copy of visibility settings for the model text in a family document.

### `P:Autodesk.Revit.DB.ModelText.Location`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelText.Location`

#### Summary

This property is used to find the physical location of an instance within project.

### `P:Autodesk.Revit.DB.ModelText.Text`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelText.Text`

#### Summary

The text string in the model text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when `null` is assigned to text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when an empty string is assigned to text.

### `T:Autodesk.Revit.DB.ModelText`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelText`

#### Summary

A model text element in an Autodesk Revit family document.

### `T:Autodesk.Revit.DB.ModelNurbSpline`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelNurbSpline`

#### Summary

Represents a ModelNurbSpline within Autodesk Revit.

#### Remarks

Currently it's just a place holder for specific type.
All the geometry-related functionality is provided by geometry curve object from
ModelCurve::geometryCurve property.
