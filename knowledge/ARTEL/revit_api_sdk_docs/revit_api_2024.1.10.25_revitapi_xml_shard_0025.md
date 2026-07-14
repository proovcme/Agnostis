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
Shard: 25
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `P:Autodesk.Revit.DB.WorksharingDisplayGraphicSettings.LineColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksharingDisplayGraphicSettings.LineColor`

#### Summary

The line color that will be applied to elements when these settings are
applied.

#### Since

2012

### `P:Autodesk.Revit.DB.WorksharingDisplayGraphicSettings.IsApplied`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksharingDisplayGraphicSettings.IsApplied`

#### Summary

Indicates whether this set of graphic overrides will be applied.

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplayGraphicSettings.#ctor(System.Boolean,Autodesk.Revit.DB.Color)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplayGraphicSettings.#ctor(System.Boolean,Autodesk.Revit.DB.Color)`

#### Summary

Creates a new instance.

#### Parameter `shouldApply`

True if the settings should be applied, False if they should be set but not applied.

#### Parameter `lineColor`

The desired line color, which must be a valid color. Note that the fill
color is calculated automatically from the line color so it is not advisable
to use white, black, or shades of grey.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The lineColor argument does not represent a valid color.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.WorksharingDisplayGraphicSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.WorksharingDisplayGraphicSettings`

#### Summary

Represents the graphical settings that can be assigned to elements in the worksharing
display modes.

#### Since

2012

### `M:Autodesk.Revit.DB.TransactWithCentralOptions.GetLockCallback`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactWithCentralOptions.GetLockCallback`

#### Summary

Gets the callback object that changes Revit's default behavior of endlessly waiting and repeatedly trying to lock a central model.

#### Since

2014

### `M:Autodesk.Revit.DB.TransactWithCentralOptions.SetLockCallback(Autodesk.Revit.DB.ICentralLockedCallback)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactWithCentralOptions.SetLockCallback(Autodesk.Revit.DB.ICentralLockedCallback)`

#### Summary

Sets or resets a callback object that would allow an external application to change Revit's default behavior of endlessly waiting and repeatedly trying to lock a central model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.TransactWithCentralOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.TransactWithCentralOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.TransactWithCentralOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.TransactWithCentralOptions.#ctor`

#### Summary

Constructs a new TransactWithCentralOptions.

#### Since

2014

### `T:Autodesk.Revit.DB.TransactWithCentralOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.TransactWithCentralOptions`

#### Summary

Options to customize Revit behavior when accessing the central model.

#### Since

2014

### `M:Autodesk.Revit.DB.WorksharingUtils.IsUpToDate(Autodesk.Revit.DB.ModelPath,System.Int32,System.Guid,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.IsUpToDate(Autodesk.Revit.DB.ModelPath,System.Int32,System.Guid,System.Guid)`

#### Summary

Check whether a local cache is up to date with its central model.

#### Remarks

This API only works for cloud-based models.

#### Parameter `modelPath`

Model path of the central model

#### Parameter `latestCentralVersionInLocal`

Latest central version in the local model.

#### Parameter `latestCentralEpisodeGUIDInLocal`

Latest central episodeGUID in the local model.

#### Parameter `clientModelID`

ID of the local model

#### Returns

true if the local cache is up to date with its central model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model is being accessed by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Since

2018

### `M:Autodesk.Revit.DB.WorksharingUtils.IsUpToDate(System.String,System.Guid,System.Guid,System.Int32,System.Guid,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.IsUpToDate(System.String,System.Guid,System.Guid,System.Int32,System.Guid,System.Guid)`

#### Summary

Check whether a local cache is up to date with its central model.

#### Remarks

This API only works for cloud-based models.

#### Parameter `region`

account region of the central model

#### Parameter `projectID`

project ID of the central model.

#### Parameter `modelID`

ID of the central model.

#### Parameter `latestCentralVersionInLocal`

latest central version in the local model.

#### Parameter `latestCentralEpisodeGUIDInLocal`

latest central episodeGUID in the local model.

#### Parameter `clientModelID`

ID of the local model

#### Returns

true if the local cache is up to date with its central model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model is being accessed by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Since

2015

### `M:Autodesk.Revit.DB.WorksharingUtils.LogWorksharingTime(System.String,System.Guid,System.Guid,System.Guid,System.String,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.LogWorksharingTime(System.String,System.Guid,System.Guid,System.Guid,System.String,System.Double)`

#### Summary

Log the time taken by a given worksharing operation into the server logs.

#### Parameter `region`

account region

#### Parameter `projectID`

GUID of the project

#### Parameter `modelID`

GUID of the project

#### Parameter `clientModelID`

GUID of the project

#### Parameter `operation`

String identifying the operation to be timed

#### Parameter `time`

Measured time taken for the operation

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingUtils.GetWorksharingTooltipInfo(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.GetWorksharingTooltipInfo(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets worksharing information about an element to display in an in-canvas tooltip.

#### Remarks

If there is no element corresponding to the given id,
then all the strings returned in WorksharingTooltipInfo are empty.

The return value may not be dependable in the middle of a transaction.
See the remarks on `T:Autodesk.Revit.DB.WorksharingUtils` for more details.

#### Parameter `document`

The document containing the element

#### Parameter `elementId`

The id of the element in question

#### Returns

Worksharing information about the specified element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingUtils.CreateNewLocal(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.CreateNewLocal(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ModelPath)`

#### Summary

Takes a path to a central model and copies the model into a new local file for the current user.

#### Parameter `sourcePath`

The path to the central model.

#### Parameter `targetPath`

The path to put the new local file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given path sourcePath is a cloud path which is not supported in this method.
-or-
The model is not workshared.
-or-
The central model has not fully enabled worksharing.
It must be opened and resaved to finish enabling worksharing.
-or-
The model is a local file.
-or-
The central model is not saved in the current Revit version.
-or-
The model is transmitted.
-or-

-or-
The specified filepath is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied due to lack of access privileges.
-or-
Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model is locked by another user.
-or-
The central model is being accessed by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

The central model is missing.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentAlreadyExistsException`

The file or folder already exists and cannot be overwritten.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This functionality is not available in Revit LT.
-or-
File already exists!
-or-
Revit Server does not support local models.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Since

2014

### `M:Autodesk.Revit.DB.WorksharingUtils.GetUserWorksetInfo(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.GetUserWorksetInfo(Autodesk.Revit.DB.ModelPath)`

#### Summary

Gets information about user worksets in a workshared model file, without fully opening the file.

#### Remarks

This method provides a preview of the user worksets available in a file, allowing an
application to look up the necessary workset ids and information to properly fill out a WorksetConfiguration
structure before opening or linking to this model.

#### Parameter `path`

The path to the workshared model.

#### Returns

Information about all the user worksets in the model.
The list is sorted by workset id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied due to lack of access privileges.
-or-
Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model are locked by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

The central model is missing.
-or-
The central model is corrupt or not an RVT file.
-or-
The model is not workshared.
-or-
The central model is overwritten by other user.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The model could not be accessed due to lack of access privileges.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The Revit model specified by path doesn't exist.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

The model could not be found at the specified path.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This functionality is not available in Revit LT.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingUtils.RelinquishOwnership(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.RelinquishOptions,Autodesk.Revit.DB.TransactWithCentralOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.RelinquishOwnership(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.RelinquishOptions,Autodesk.Revit.DB.TransactWithCentralOptions)`

#### Summary

Relinquishes ownership by the current user of as many specified elements and worksets as possible,
and grants element ownership requested by other users on a first-come, first-served basis.

#### Remarks

Elements and worksets owned by other users are ignored.

Only unmodified elements already in central will be relinquished by this method.
Newly added and modified elements cannot be relinquished
until they have been synchronized with central.

For best performance, relinquish items in one big call, rather than many small calls.

#### Parameter `document`

The document containing the elements and worksets.

#### Parameter `generalCategories`

General categories of items to relinquish. See RelinquishOptions for details.

#### Parameter `options`

Options to customize access to the central model.
`null` is allowed and means no customization.

#### Returns

The elements and worksets that were relinquished.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a workshared document.
-or-
document is not a primary document, it is a linked document.
-or-
document is read-only: It cannot be modified.
-or-
document has an open editing transaction and is accepting changes.
-or-
Saving is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralFileCommunicationException`

The file-based central model could not be reached,
e.g. the network is down or the file server is down.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied due to lack of access privileges.
-or-
Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model is locked by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

The central model is overwritten by other user.
-or-
The central model is missing.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Since

2014

### `M:Autodesk.Revit.DB.WorksharingUtils.CheckoutWorksets(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.WorksetId},Autodesk.Revit.DB.TransactWithCentralOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.CheckoutWorksets(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.WorksetId},Autodesk.Revit.DB.TransactWithCentralOptions)`

#### Summary

Obtains ownership for the current user of as many specified worksets as possible.

#### Remarks

For best performance, check out all worksets in one big call, rather than many small calls.

#### Parameter `document`

The document containing the worksets.

#### Parameter `worksetsToCheckout`

The ids of the worksets to attempt to check out.

#### Parameter `options`

Options to customize access to the central model.
`null` is allowed and means no customization.

#### Returns

The ids of all specified worksets that are now owned,
including all that were owned prior to the function call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a workshared document.
-or-
document is not a primary document, it is a linked document.
-or-
document is read-only: It cannot be modified.
-or-
document has an open editing transaction and is accepting changes.
-or-
There are one or more ids with no corresponding workset.
-or-
Saving is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralFileCommunicationException`

The file-based central model could not be reached,
e.g. the network is down or the file server is down.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied due to lack of access privileges.
-or-
Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model are locked by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

The central model is overwritten by other user.
-or-
The central model is missing.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelVersionArchivedException`

Last central version merged into the local model has been archived in the central model.
This exception could only be thrown from cloud models.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Since

2015

### `M:Autodesk.Revit.DB.WorksharingUtils.CheckoutWorksets(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.WorksetId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.CheckoutWorksets(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.WorksetId})`

#### Summary

Obtains ownership for the current user of as many specified worksets as possible.

#### Remarks

For best performance, check out all worksets in one big call, rather than many small calls.

When there comes a contention error when locking the central model, this API would wait and retry
endlessly until getting the lock of the central model.

#### Parameter `document`

The document containing the worksets.

#### Parameter `worksetsToCheckout`

The ids of the worksets to attempt to check out.

#### Returns

The ids of all specified worksets that are now owned,
including all that were owned prior to the function call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a workshared document.
-or-
document is not a primary document, it is a linked document.
-or-
document is read-only: It cannot be modified.
-or-
document has an open editing transaction and is accepting changes.
-or-
There are one or more ids with no corresponding workset.
-or-
Saving is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralFileCommunicationException`

The file-based central model could not be reached,
e.g. the network is down or the file server is down.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied due to lack of access privileges.
-or-
Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The central model are locked by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

The central model is overwritten by other user.
-or-
The central model is missing.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelVersionArchivedException`

Last central version merged into the local model has been archived in the central model.
This exception could only be thrown from cloud models.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Since

2014

### `M:Autodesk.Revit.DB.WorksharingUtils.CheckoutElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.TransactWithCentralOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.CheckoutElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.TransactWithCentralOptions)`

#### Summary

Obtains ownership for the current user of as many specified elements as possible.

#### Remarks

For best performance, checkout all elements in one big call, rather than many small calls.

Revit may check out additional elements that are needed to check out the elements you requested.
For example, if you request an element that is in a group, Revit will check out the entire group.

#### Parameter `document`

The document containing the elements.

#### Parameter `elementsToCheckout`

The ids of the elements to attempt to check out.

#### Parameter `options`

Options to customize access to the central model.
`null` is allowed and means no customization.

#### Returns

The ids of all specified elements that are now owned (but possibly out of date),
including all that were owned prior to the function call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a workshared document.
-or-
document is not a primary document, it is a linked document.
-or-
One or more elements in elementsToCheckout do not exist in the document.
-or-
Saving is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralFileCommunicationException`

Editing permissions for the file-based central model could not be accessed for write,
e.g. the network is down, central is missing, or central is read-only.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

Editing permissions for the central model are locked and the last attempt to lock was canceled.
-or-
The central model is being accessed by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

An error has occurred while checking out worksets or elements.
-or-
The central model is overwritten by other user.
-or-
The central model is missing.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelVersionArchivedException`

Last central version merged into the local model has been archived in the central model.
This exception could only be thrown from cloud models.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Since

2015

### `M:Autodesk.Revit.DB.WorksharingUtils.CheckoutElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.CheckoutElements(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Obtains ownership for the current user of as many specified elements as possible.

#### Remarks

For best performance, checkout all elements in one big call, rather than many small calls.

Revit may check out additional elements that are needed to check out the elements you requested.
For example, if you request an element that is in a group, Revit will check out the entire group.

When there comes a contention error when locking the central model, this API would wait and retry
endlessly until getting the lock of the central model.

#### Parameter `document`

The document containing the elements.

#### Parameter `elementsToCheckout`

The ids of the elements to attempt to check out.

#### Returns

The ids of all specified elements that are now owned (but possibly out of date),
including all that were owned prior to the function call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a workshared document.
-or-
document is not a primary document, it is a linked document.
-or-
One or more elements in elementsToCheckout do not exist in the document.
-or-
Saving is not allowed in the current application mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralFileCommunicationException`

Editing permissions for the file-based central model could not be accessed for write,
e.g. the network is down, central is missing, or central is read-only.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

Editing permissions for the central model are locked and the last attempt to lock was canceled.
-or-
The central model is being accessed by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

An error has occurred while checking out worksets or elements.
-or-
The central model is overwritten by other user.
-or-
The central model is missing.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelVersionArchivedException`

Last central version merged into the local model has been archived in the central model.
This exception could only be thrown from cloud models.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Since

2014

### `M:Autodesk.Revit.DB.WorksharingUtils.GetCheckoutStatus(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.GetCheckoutStatus(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the ownership status of an element.

#### Remarks

This method returns a locally cached value which may not be up to date with the current state
of the element in the central. Because of this, the return value is suitable for reporting to an
interactive user (e.g. via a mechanism similar to Worksharing display mode), but cannot be considered
a reliable indication of whether the element can be immediately edited by the application. Also, the return value
may not be dependable in the middle of a local transaction. See the remarks
on `T:Autodesk.Revit.DB.WorksharingUtils` for more details.

For performance reasons, the model is not validated to be workshared,
and the element id is also not validated; the element will not be expanded.

#### Parameter `document`

The document containing the element.

#### Parameter `elementId`

The id of the element.

#### Returns

A summary of whether the element is unowned, owned by the current user, or owned by another user.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingUtils.GetCheckoutStatus(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.GetCheckoutStatus(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String@)`

#### Summary

Gets the ownership status and outputs the owner of an element.

#### Remarks

This method returns a locally cached value which may not be up to date with the current state
of the element in the central. Because of this, the return value is suitable for reporting to an
interactive user (e.g. via a mechanism similar to Worksharing display mode), but cannot be considered
a reliable indication of whether the element can be immediately edited by the application. Also, the return value
may not be dependable in the middle of a local transaction. See the remarks
on `T:Autodesk.Revit.DB.WorksharingUtils` for more details.

For performance reasons, the model is not validated to be workshared,
and the element id is also not validated; the element will not be expanded.

#### Parameter `document`

The document containing the element.

#### Parameter `elementId`

The id of the element.

#### Parameter `owner`

The owner of the element, or an empty string if no one owns it.

#### Returns

An indication of whether the element is unowned, owned by the current user, or owned by another user.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingUtils.GetModelUpdatesStatus(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingUtils.GetModelUpdatesStatus(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the status of a single element in the central model.

#### Remarks

This method returns a locally cached value which may not be up to date with the current state
of the element in the central. Because of this, the return value is suitable for reporting to an
interactive user (e.g. via a mechanism similar to Worksharing display mode), but cannot be considered
a reliable indication of whether the element can be immediately edited by the application. Also, the return value
may not be dependable in the middle of a local transaction. See the remarks
on `T:Autodesk.Revit.DB.WorksharingUtils` for more details.

For performance reasons, the model is not validated to be workshared,
and the element id is also not validated; the element will not be expanded.

#### Parameter `document`

The document containing the element.

#### Parameter `elementId`

The id of the element.

#### Returns

The status of the element in the local session versus the central model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.WorksharingUtils.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksharingUtils.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.WorksharingUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.WorksharingUtils`

#### Summary

A static class that contains utility functions related to worksharing.

#### Remarks

Return values from inquiries about the worksharing status of elements or worksets
rely on local caching of information from the central model so it is possible that the
information is out of date. Because of this, the return value is suitable for reporting to an
interactive user (e.g. via a mechanism similar to Worksharing display mode), but cannot be considered
a reliable indication of whether the element can be immediately edited by the application. To make an immediate
attempt to edit elements, use `!:CheckoutElements()` and check the return status,
then confirm if the elements are up to date.

In addition, information about the current user may not be
reliable while Revit is in the middle of an editing transaction. For example,
if you move an unowned wall from an unowned workset to a workset you own,
then before you explicitly or Revit automatically checks out the wall for you,
GetCheckoutStatus() might erroneously tell you CheckoutStatus.OwnedByCurrentUser
because although the official (as seen in central and by other users) owner is no one,
locally it looks like you already own it since it belongs to a workset you own.

For operations that interact with central (as opposed to use only cached values),
Revit might opportunistically refresh some editing permissions or check the status of editing requests.

Some useful definitions to keep in mind follow:
The owner of a workset: the user who has the Workset checked out; this could be nobody (the empty string).

The borrower of an element: the user who has explicitly checked out ("borrowed") the Element;
this could be nobody.

The owner of an element: If element is borrowed (i.e. explicitly checked out),
then the element's owner is the borrower, otherwise it is the owner or the workset containing the element.

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingTooltipInfo.GetRequesters`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingTooltipInfo.GetRequesters`

#### Summary

The ordered list of unique user names of users who have outstanding editing requests for
the specified element.

#### Remarks

The list is ordered by who placed the earliest request.
If the list is empty it means that nobody is currently requesting the specified element.

#### Returns

The ordered list of unique user names.

#### Since

2012

### `P:Autodesk.Revit.DB.WorksharingTooltipInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksharingTooltipInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.WorksharingTooltipInfo.LastChangedBy`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksharingTooltipInfo.LastChangedBy`

#### Summary

The user name of the most recent user who saved a user change of this element
to the central model.

#### Since

2012

### `P:Autodesk.Revit.DB.WorksharingTooltipInfo.Creator`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksharingTooltipInfo.Creator`

#### Summary

The user name of the user who created the element.

#### Since

2012

### `P:Autodesk.Revit.DB.WorksharingTooltipInfo.Owner`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksharingTooltipInfo.Owner`

#### Summary

The current owner of the element or empty string if no one owns the element.

#### Since

2012

### `T:Autodesk.Revit.DB.WorksharingTooltipInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.WorksharingTooltipInfo`

#### Summary

Worksharing information about a single element suitable for display in an in-canvas tooltip.

#### Remarks

Some or all of the strings may be empty.

#### Since

2012

### `T:Autodesk.Revit.DB.ModelUpdatesStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelUpdatesStatus`

#### Summary

Indicates whether an element in the current model has additional user changes in the central model.

#### Remarks

Note that this status only indicates that the element has user changes in the central model.
A user change is typically an action specifically taken by a user. Making a user change
to an element requires that the user making the change reload all other user changes made to
the element in the central model. Making a user change also causes the element to be
checked out to the current user so other users will not be able to make user changes to
the same element.

Elements can also be modified by system changes. A system change is one which is done
automatically by Revit to fully update the model after a user change occurs. Users may
make changes to an element in their local model even if the element contains additional
system changes in the central model.

Example: Suppose Alice and Bob are working on the same model. Alice moves a wall which
contains windows. Then Alice synchronizes with the central file. The wall was explicitly
changed by Alice and so it will report as "UpdatedInCentral" in Bob's model. Bob
would have to reload latest before he could make user changes to that wall. In contrast, Revit
automatically moved the windows with the wall, so the windows do not contain any user changes.
The windows would therefore report "CurrentWithCentral" and Bob would be allowed to
modify them in his local model without reloading latest.

#### Since

2012

### `F:Autodesk.Revit.DB.ModelUpdatesStatus.UpdatedInCentral`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModelUpdatesStatus.UpdatedInCentral`

#### Summary

The element has additional user changes in the central model. A reload latest will be
required before it can be modified in the current model.

### `F:Autodesk.Revit.DB.ModelUpdatesStatus.DeletedInCentral`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModelUpdatesStatus.DeletedInCentral`

#### Summary

The element has been deleted in the central model.

### `F:Autodesk.Revit.DB.ModelUpdatesStatus.NotYetInCentral`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModelUpdatesStatus.NotYetInCentral`

#### Summary

The element is new in the current model and has not been saved to the central model. Note that this
status will apply to newly created elements even if they are created in the central model.

### `F:Autodesk.Revit.DB.ModelUpdatesStatus.CurrentWithCentral`

Member kind: field
Symbol: `Autodesk.Revit.DB.ModelUpdatesStatus.CurrentWithCentral`

#### Summary

The element has no additional changes in the central model.

### `T:Autodesk.Revit.DB.CheckoutStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.CheckoutStatus`

#### Summary

Indicates the ownership status of an element

#### Since

2012

### `F:Autodesk.Revit.DB.CheckoutStatus.NotOwned`

Member kind: field
Symbol: `Autodesk.Revit.DB.CheckoutStatus.NotOwned`

#### Summary

The element is not owned by any user.

### `F:Autodesk.Revit.DB.CheckoutStatus.OwnedByOtherUser`

Member kind: field
Symbol: `Autodesk.Revit.DB.CheckoutStatus.OwnedByOtherUser`

#### Summary

The element is owned by some user other than the current user.

### `F:Autodesk.Revit.DB.CheckoutStatus.OwnedByCurrentUser`

Member kind: field
Symbol: `Autodesk.Revit.DB.CheckoutStatus.OwnedByCurrentUser`

#### Summary

The element is owned by the current user.

### `P:Autodesk.Revit.DB.WorksharingSaveAsOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksharingSaveAsOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.WorksharingSaveAsOptions.ClearTransmitted`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksharingSaveAsOptions.ClearTransmitted`

#### Summary

For a transmitted model opened with DetachAndPreserveWorksets,
clear its transmitted flag in the Save/SaveAs operation.

#### Since

2014

### `P:Autodesk.Revit.DB.WorksharingSaveAsOptions.OpenWorksetsDefault`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksharingSaveAsOptions.OpenWorksetsDefault`

#### Summary

The default set of user-worksets to open when opening the model in the UI.
Default is AskUserToSpecify.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.WorksharingSaveAsOptions.SaveAsCentral`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksharingSaveAsOptions.SaveAsCentral`

#### Summary

Whether to save the new model as a central instead of local model.
True: save as a central model.
Default is false: save as a local model.

#### Remarks

Must be true for a model where the model has not yet been saved as a central
after either worksharing has just been enabled
or the model was opened detached from central
and .

#### Since

2014

### `M:Autodesk.Revit.DB.WorksharingSaveAsOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingSaveAsOptions.#ctor`

#### Summary

Constructs a new WorksharingSaveAsOptions with default settings.

#### Since

2014

### `T:Autodesk.Revit.DB.WorksharingSaveAsOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.WorksharingSaveAsOptions`

#### Summary

This class contains options specific to worksharing SaveAs.

#### Since

2014

### `T:Autodesk.Revit.DB.SimpleWorksetConfiguration`

Member kind: type
Symbol: `Autodesk.Revit.DB.SimpleWorksetConfiguration`

#### Summary

Indicates the set of user-created worksets to open in memory

#### Since

2014

### `F:Autodesk.Revit.DB.SimpleWorksetConfiguration.AskUserToSpecify`

Member kind: field
Symbol: `Autodesk.Revit.DB.SimpleWorksetConfiguration.AskUserToSpecify`

#### Summary

Explicitly ask the user the specify which user-created worksets to open.

### `F:Autodesk.Revit.DB.SimpleWorksetConfiguration.LastViewed`

Member kind: field
Symbol: `Autodesk.Revit.DB.SimpleWorksetConfiguration.LastViewed`

#### Summary

The set of user-created worksets last opened for this model.

### `F:Autodesk.Revit.DB.SimpleWorksetConfiguration.AllEditable`

Member kind: field
Symbol: `Autodesk.Revit.DB.SimpleWorksetConfiguration.AllEditable`

#### Summary

All user-created worksets checked out to the current user.

### `F:Autodesk.Revit.DB.SimpleWorksetConfiguration.AllWorksets`

Member kind: field
Symbol: `Autodesk.Revit.DB.SimpleWorksetConfiguration.AllWorksets`

#### Summary

All user-created worksets.

### `M:Autodesk.Revit.DB.WorksetDefaultVisibilitySettings.GetWorksetDefaultVisibilitySettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetDefaultVisibilitySettings.GetWorksetDefaultVisibilitySettings(Autodesk.Revit.DB.Document)`

#### Summary

Get the WorksetDefaultVisibilitySettings of the document.

#### Remarks

WorksetDefaultVisibilitySettings is not available in family documents.

#### Parameter `aDoc`

The document.

#### Returns

The WorksetDefaultVisibilitySettings of the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

WorksetDefaultVisibilitySettings is not applicable to family documents.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WorksetDefaultVisibilitySettings.SetWorksetVisibility(Autodesk.Revit.DB.WorksetId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetDefaultVisibilitySettings.SetWorksetVisibility(Autodesk.Revit.DB.WorksetId,System.Boolean)`

#### Summary

Set the default visibility of a workset.

#### Parameter `worksetId`

Id of the workset.

#### Parameter `visible`

Whether the workset should be visible by default or not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There is no workset with this Id in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

WorksetDefaultVisibilitySettings is not applicable to family documents.

#### Since

2012

### `M:Autodesk.Revit.DB.WorksetDefaultVisibilitySettings.IsWorksetVisible(Autodesk.Revit.DB.WorksetId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetDefaultVisibilitySettings.IsWorksetVisible(Autodesk.Revit.DB.WorksetId)`

#### Summary

Indicates whether the workset is visible by default.

#### Parameter `worksetId`

Id of the workset.

#### Returns

Whether the workset is visible by default.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There is no workset with this Id in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

WorksetDefaultVisibilitySettings is not applicable to family documents.

#### Since

2012

### `T:Autodesk.Revit.DB.WorksetDefaultVisibilitySettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.WorksetDefaultVisibilitySettings`

#### Summary

An object that manages default visibility of worksets in a document.

#### Remarks

WorksetDefaultVisibilitySettings does not exist for family documents.
In case worksharing is disabled in a document, all elements are moved into a single workset;
that workset, and any worksets (re)created if worksharing is re-enabled, is visible by default regardless of any current settings.

#### Since

2012

### `M:Autodesk.Revit.DB.WorksetTable.IsWorksetNameUnique(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetTable.IsWorksetNameUnique(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Checks if the given workset name is unique in the document.

#### Parameter `aDoc`

The document in which the workset is accessed.

#### Parameter `name`

The workset name.

#### Returns

True if this given workset name is unique in the document, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.DB.WorksetTable.RenameWorkset(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.WorksetId,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetTable.RenameWorkset(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.WorksetId,System.String)`

#### Summary

Renames the workset.

#### Parameter `aDoc`

The document in which the workset is accessed.

#### Parameter `worksetId`

The workset Id.

#### Parameter `name`

The workset name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

aDoc is not a workshared document.
-or-
name is an empty string or contains only whitespace.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
The given workset name is already in use.
-or-
There is no workset in the document with this id.

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

2015 Subscription Update

### `M:Autodesk.Revit.DB.WorksetTable.DeleteWorkset(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.DeleteWorksetSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetTable.DeleteWorkset(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.DeleteWorksetSettings)`

#### Summary

Delete the specific workset.

#### Remarks

Please checkout the workset before executing this method.
The method may fail in some situations that mentioned in `M:Autodesk.Revit.DB.WorksetTable.CanDeleteWorkset(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.DeleteWorksetSettings)` .
Another failure case is the Transaction failure due to "Deleting all open views in a project is not allowed."

#### Parameter `document`

The document containing the worksets.

#### Parameter `worksetId`

The id of the workset to delete.

#### Parameter `deleteWorksetSettings`

The settings to delete a workset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a workshared document.
-or-
document is not a primary document, it is a linked document.
-or-
document is read-only: It cannot be modified.
-or-
There is no workset in the document with this id.
-or-
Workset cannot be deleted.

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

#### Exception `T:Autodesk.Revit.Exceptions.RegenerationFailedException`

The document regeneration fails during the DeleteWorkset operation.

#### Since

2022.1

### `M:Autodesk.Revit.DB.WorksetTable.CanDeleteWorkset(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.DeleteWorksetSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetTable.CanDeleteWorkset(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.DeleteWorksetSettings)`

#### Summary

Indicates if a workset can be deleted.

#### Remarks

The workset can't be deleted in the following cases:
The input worksetId is not valid in the document.

The input worksetId doesn't represent a user-created workset, which means this workset might be a system workset.

The workset is not editable by the current user. In order to resolve this problem,
please checkout the workset by calling `!:Autodesk::Revit::DB::WorksharingUtils::CheckoutWorksets` .

The workset or some elements under the workset are owned by the other users. In order to resolve this problem,
please ask the other users to call `!:Autodesk::Revit::DB::WorksharingUtils::RelinquishOwnership`
to relinquish their ownership on the workset and elements.

The target workset is not a user-created workset.

#### Parameter `document`

The document containing the worksets.

#### Parameter `worksetId`

The id of the workset to delete.

#### Parameter `deleteWorksetSettings`

The settings to delete a workset.

#### Returns

True if the workset can be deleted, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022.1

### `M:Autodesk.Revit.DB.WorksetTable.SetActiveWorksetId(Autodesk.Revit.DB.WorksetId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetTable.SetActiveWorksetId(Autodesk.Revit.DB.WorksetId)`

#### Summary

Sets the active workset.

#### Parameter `worksetId`

The workset Id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There is no workset in the document with this id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.DB.WorksetTable.GetActiveWorksetId`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetTable.GetActiveWorksetId`

#### Summary

Returns the active workset's WorksetId.

#### Returns

WorksetId of the active workset.

#### Since

2012

### `M:Autodesk.Revit.DB.WorksetTable.GetWorkset(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetTable.GetWorkset(System.Guid)`

#### Summary

Returns the workset from a input Guid.

#### Parameter `guid`

Guid of the workset.

#### Returns

The returned workset. `null` if there is no workset in this table with this Id.

#### Since

2012

### `M:Autodesk.Revit.DB.WorksetTable.GetWorkset(Autodesk.Revit.DB.WorksetId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetTable.GetWorkset(Autodesk.Revit.DB.WorksetId)`

#### Summary

Returns the workset from a input WorksetId.

#### Parameter `id`

Id of a workset.

#### Returns

The returned workset. `null` if there is no workset in this table with this Id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.WorksetTable.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksetTable.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.WorksetTable`

Member kind: type
Symbol: `Autodesk.Revit.DB.WorksetTable`

#### Summary

A table containing references to all the worksets contained in a document.

#### Remarks

There is one WorksetTable for each document.
There will be at least one default workset in the table, even if worksharing has not been enabled in the document.

#### Since

2012

### `P:Autodesk.Revit.DB.DeleteWorksetSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DeleteWorksetSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.DeleteWorksetSettings.WorksetId`

Member kind: property
Symbol: `Autodesk.Revit.DB.DeleteWorksetSettings.WorksetId`

#### Summary

The target worksetId for those elements under the deleted workset, which is used for DeleteWorksetOption::MoveElementsToWorkset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022.1

### `P:Autodesk.Revit.DB.DeleteWorksetSettings.DeleteWorksetOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.DeleteWorksetSettings.DeleteWorksetOption`

#### Summary

The current delete workset option.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022.1

### `M:Autodesk.Revit.DB.DeleteWorksetSettings.#ctor(Autodesk.Revit.DB.DeleteWorksetOption,Autodesk.Revit.DB.WorksetId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DeleteWorksetSettings.#ctor(Autodesk.Revit.DB.DeleteWorksetOption,Autodesk.Revit.DB.WorksetId)`

#### Summary

Constructs a DeleteWorksetSettings object.

#### Remarks

elementsMoveInto only takes effect when DeleteWorksetOption::Enum is MoveElementsToWorkset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022.1

### `M:Autodesk.Revit.DB.DeleteWorksetSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DeleteWorksetSettings.#ctor`

#### Summary

Constructs a DeleteWorksetSettings object with DeleteWorksetOption::DeleteAllElements option.

#### Since

2022.1

### `T:Autodesk.Revit.DB.DeleteWorksetSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.DeleteWorksetSettings`

#### Summary

This class represents the settings used to delete a workset.

#### Since

2022.1

### `T:Autodesk.Revit.DB.DeleteWorksetOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.DeleteWorksetOption`

#### Summary

This class defines an enumerative type used to specify the option to delete a workset.

#### Since

2022.1

#### Summary

This enumerative type corresponds to the possible options to delete a workset.

#### Since

2022.1

### `F:Autodesk.Revit.DB.DeleteWorksetOption.DeleteAllElements`

Member kind: field
Symbol: `Autodesk.Revit.DB.DeleteWorksetOption.DeleteAllElements`

#### Summary

Delete a workset together with all the elements in this workset.

### `F:Autodesk.Revit.DB.DeleteWorksetOption.MoveElementsToWorkset`

Member kind: field
Symbol: `Autodesk.Revit.DB.DeleteWorksetOption.MoveElementsToWorkset`

#### Summary

Delete a workset, while moving the elements from the deleted workset to another workset.

### `M:Autodesk.Revit.DB.WorkerProgressNotifier.IsCalculationCancelled`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorkerProgressNotifier.IsCalculationCancelled`

#### Summary

is the secondary calculation cancelled due to the primary data change?

#### Since

2017

### `M:Autodesk.Revit.DB.WorkerProgressNotifier.MarkProgress`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorkerProgressNotifier.MarkProgress`

#### Summary

Sends a heart beat signal of the current calculation progress

#### Remarks

Any secondary data calculation is required to keep the main process informed about its progress. If the main
process does not detect the heart beats within the limit WorkerServicesExecutive::WorkerCalculationTimeout
(15 seconds), the calculation is deemed failed and rolled over in the main process.
By default, the cross-process element access would call this method. If your secondary data calculation does not
access elements and the algorithm is long enough to exceed the time limit, you need explicitly call this method
to avoid the calculation failure!

#### Since

2017

### `T:Autodesk.Revit.DB.WorkerProgressNotifier`

Member kind: type
Symbol: `Autodesk.Revit.DB.WorkerProgressNotifier`

#### Summary

An interface to mark the progress of secondary data calculation in worker

#### Since

2017

### `P:Autodesk.Revit.DB.Visual.Wood.TextureAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wood.TextureAngle`

#### Summary

The property labeled "Angle" from the "Wood" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray3d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wood.TextureRealWorldOffsetZ`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wood.TextureRealWorldOffsetZ`

#### Summary

The property labeled "Offset Z" from the "Wood" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wood.TextureRealWorldOffsetY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wood.TextureRealWorldOffsetY`

#### Summary

The property labeled "Offset Y" from the "Wood" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wood.TextureRealWorldOffsetX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wood.TextureRealWorldOffsetX`

#### Summary

The property labeled "Offset X" from the "Wood" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wood.TextureLinkTextureTransforms`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wood.TextureLinkTextureTransforms`

#### Summary

The property labeled "Link Transforms" from the "Wood" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wood.WoodThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wood.WoodThickness`

#### Summary

The property labeled "Grain Thickness" from the "Wood" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 100".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wood.WoodAxialNoise`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wood.WoodAxialNoise`

#### Summary

The property labeled "Axial Noise" from the "Wood" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 100".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wood.WoodRadialNoise`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wood.WoodRadialNoise`

#### Summary

The property labeled "Radial Noise" from the "Wood" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 100".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wood.WoodColor2`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wood.WoodColor2`

#### Summary

The property labeled "Color 2" from the "Wood" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wood.WoodColor1`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wood.WoodColor1`

#### Summary

The property labeled "Color 1" from the "Wood" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Wood`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Wood`

#### Summary

A static class that provides access to the property names that appear in the Wood visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Point.Create(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Visibility,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Point.Create(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Visibility,System.Int32)`

#### Summary

Creates a point at the given coordinates and assigns it the specified GraphicsStyle and Visibility.

#### Since

2021

#### Parameter `coord`

The coordinates where the point will be created.

#### Parameter `id`

The id of the GraphicsStyle element from which to apply the point properties.

#### Parameter `visibility`

The visibility to apply to the point object.

#### Parameter `size`

The size to apply to the point object.

#### Returns

A Point object.

#### Throws

Exception is thrown unless visibility is set to Visible, Highlight or Invisible.

### `P:Autodesk.Revit.DB.Point.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Point.Size`

#### Summary

Returns the size of the point.

### `P:Autodesk.Revit.DB.Point.Reference`

Member kind: property
Symbol: `Autodesk.Revit.DB.Point.Reference`

#### Summary

Returns a stable reference to the point.

#### Remarks

This value is if the corresponding geometry object does not permit referencing.

### `P:Autodesk.Revit.DB.Point.Coord`

Member kind: property
Symbol: `Autodesk.Revit.DB.Point.Coord`

#### Summary

Returns the coordinates of the point.

### `M:Autodesk.Revit.DB.Point.Create(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Point.Create(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a point at the given coordinates and assigns it the specified GraphicsStyle.

#### Since

2016

#### Parameter `coord`

The coordinates where the point will be created.

#### Parameter `id`

The id of the GraphicsStyle element from which to apply the point properties.

#### Returns

A Point object.

### `M:Autodesk.Revit.DB.Point.Create(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Point.Create(Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a point at the given coordinates.

#### Since

2016

#### Parameter `coord`

The coordinates where the point will be created.

#### Returns

A Point object.

### `T:Autodesk.Revit.DB.Point`

Member kind: type
Symbol: `Autodesk.Revit.DB.Point`

#### Summary

A 3D point.

#### Remarks

The point lies at a given XYZ coordinate location.

### `M:Autodesk.Revit.DB.WireframeBuilder.ValidateCurve(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WireframeBuilder.ValidateCurve(Autodesk.Revit.DB.Curve)`

#### Summary

Validates curve to be added to the wireframe shape being constructed. Used by addCurve to validate input.
This function may be used to pre-validate the geometry being added to avoid an exception from AddCurve().

#### Parameter `GCurve`

Curve object to be validated.

#### Returns

True is %GCurve% is acceptable as a part of a wireframe shape representation being built.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.WireframeBuilder.ValidatePoint(Autodesk.Revit.DB.Point)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WireframeBuilder.ValidatePoint(Autodesk.Revit.DB.Point)`

#### Summary

Validates the point object to be added to the wireframe shape being constructed. Used by AddPoint() to validate input.

#### Remarks

This function may be used to pre-validate the geometry being added to avoid an exception from AddPoint().

#### Parameter `GPoint`

Point object to be validated.

#### Returns

True is %GPoint% is acceptable as a part of a wireframe shape representation being built.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.WireframeBuilder.AddCurve(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WireframeBuilder.AddCurve(Autodesk.Revit.DB.Curve)`

#### Summary

Add a curve to the shape representation stored in this WireframeBuilder.

#### Parameter `GCurve`

The curve to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

GCurve is not acceptable for a wireframe shape representation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.WireframeBuilder.AddPoint(Autodesk.Revit.DB.Point)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WireframeBuilder.AddPoint(Autodesk.Revit.DB.Point)`

#### Summary

Add a point to the shape representation stored in this WireframeBuilder.

#### Parameter `GPoint`

The point to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

GPoint is not acceptable for a wireframe shape representation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.WireframeBuilder.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.WireframeBuilder.Reset`

#### Summary

Clears the accumulated geometry.

#### Since

2016

### `M:Autodesk.Revit.DB.WireframeBuilder.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.WireframeBuilder.#ctor`

#### Summary

Default constructor.

#### Since

2016

### `T:Autodesk.Revit.DB.WireframeBuilder`

Member kind: type
Symbol: `Autodesk.Revit.DB.WireframeBuilder`

#### Summary

Constructs a shape representation consisting of points and curves. That shape would typically be stored in a DirectShape or a DirectShapeType object.

#### Since

2016

### `T:Autodesk.Revit.DB.WidthMeasuredAt`

Member kind: type
Symbol: `Autodesk.Revit.DB.WidthMeasuredAt`

#### Summary

The allowed values for the WALL_TYPE_WIDTH_MEASURED_AT parameter.

### `F:Autodesk.Revit.DB.WidthMeasuredAt.Bottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.WidthMeasuredAt.Bottom`

#### Summary

The bottom of the wall taking into the base offset before any attachment.

### `F:Autodesk.Revit.DB.WidthMeasuredAt.Base`

Member kind: field
Symbol: `Autodesk.Revit.DB.WidthMeasuredAt.Base`

#### Summary

The base constraint of the wall.

### `F:Autodesk.Revit.DB.WidthMeasuredAt.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.WidthMeasuredAt.Top`

#### Summary

The top of the wall taking into account the top offset before any attachment.

### `P:Autodesk.Revit.DB.Visual.Wave.TextureAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.TextureAngle`

#### Summary

The property labeled "Angle" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray3d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.TextureRealWorldOffsetZ`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.TextureRealWorldOffsetZ`

#### Summary

The property labeled "Offset Z" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.TextureRealWorldOffsetY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.TextureRealWorldOffsetY`

#### Summary

The property labeled "Offset Y" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.TextureRealWorldOffsetX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.TextureRealWorldOffsetX`

#### Summary

The property labeled "Offset X" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.TextureLinkTextureTransforms`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.TextureLinkTextureTransforms`

#### Summary

The property labeled "Link Transforms" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.WaveRandomSeed`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.WaveRandomSeed`

#### Summary

The property labeled "Random Seed" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyInteger" within the range of "0, 65535".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.WavePhase`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.WavePhase`

#### Summary

The property labeled "Phase" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 10000".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.WaveAmplitude`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.WaveAmplitude`

#### Summary

The property labeled "Amplitude" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 10000".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.WaveWaveLenMax`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.WaveWaveLenMax`

#### Summary

The property labeled "Len Max" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1000000000".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.WaveWaveLenMin`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.WaveWaveLenMin`

#### Summary

The property labeled "Len Min" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1000000000".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.WaveWaveRadius`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.WaveWaveRadius`

#### Summary

The property labeled "Radius" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1000000000".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.WaveNumWaveSets`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.WaveNumWaveSets`

#### Summary

The property labeled "Number" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyInteger" within the range of "1, 50".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.WaveDistribution`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.WaveDistribution`

#### Summary

The property labeled "Distribution" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "WaveDistributionType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.WaveColor2`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.WaveColor2`

#### Summary

The property labeled "Color 2" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Wave.WaveColor1`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Wave.WaveColor1`

#### Summary

The property labeled "Color 1" from the "Wave" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Wave`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Wave`

#### Summary

A static class that provides access to the property names that appear in the Wave visual asset schema.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Mechanical.WaterLoopData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.WaterLoopData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.WaterLoopData.CondenserWaterLoopId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.WaterLoopData.CondenserWaterLoopId`

#### Summary

The water loop element id for the water cooled chiller.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.WaterLoopData.ChillerType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.WaterLoopData.ChillerType`

#### Summary

The type of water chiller. Note this property change would reset the condenser water loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.WaterLoopData.WaterLoopType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.WaterLoopData.WaterLoopType`

#### Summary

The type of water loop. Note this property change would reset other properties.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2020.1

### `T:Autodesk.Revit.DB.Mechanical.WaterLoopData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.WaterLoopData`

#### Summary

Represents the data and parameters of analytical water loop.

#### Since

2020.1

### `P:Autodesk.Revit.DB.Visual.Water.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Water.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "Water" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Water.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Water.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "Water" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Water.WaterBumpAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Water.WaterBumpAmount`

#### Summary

The property labeled "Wave Height" from the "Water" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 5".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Water.WaterColorByObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Water.WaterColorByObject`

#### Summary

The property labeled "Custom Color" from the "Water" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Water.WaterTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Water.WaterTintColor`

#### Summary

The property labeled "Custom Color" from the "Water" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Water.WaterTintEnable`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Water.WaterTintEnable`

#### Summary

The property labeled "Color" from the "Water" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "WaterTintEnableType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Water.WaterType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Water.WaterType`

#### Summary

The property labeled "Type" from the "Water" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "WaterType".

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Water`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Water`

#### Summary

A static class that provides access to the property names that appear in the Water visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.WallUtils.IsWallJoinAllowedAtEnd(Autodesk.Revit.DB.Wall,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WallUtils.IsWallJoinAllowedAtEnd(Autodesk.Revit.DB.Wall,System.Int32)`

#### Summary

Identifies if the indicated end of the wall allows joins or not.

#### Parameter `wall`

The wall in question

#### Parameter `end`

0 or 1 for the beginning or end of the wall's curve

#### Returns

true if it is allowed to join. false if it is disallowed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WallUtils.AllowWallJoinAtEnd(Autodesk.Revit.DB.Wall,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WallUtils.AllowWallJoinAtEnd(Autodesk.Revit.DB.Wall,System.Int32)`

#### Summary

Allows the wall's end to join to other walls. If that end is near other walls it will become joined as a result.

#### Remarks

By default all walls are allowed to join at ends, so this function is only needed if this wall end is already disallowed to join.
If this wall is a stacked wall, all subwalls at this end will be allowed to join.

#### Parameter `wall`

The wall in question

#### Parameter `end`

0 or 1 for the beginning or end of the wall's curve

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WallUtils.DisallowWallJoinAtEnd(Autodesk.Revit.DB.Wall,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WallUtils.DisallowWallJoinAtEnd(Autodesk.Revit.DB.Wall,System.Int32)`

#### Summary

Sets the wall's end not to join to other walls.

#### Remarks

If this wall is already joined at this end, it will become disconnected.
If this wall is a stacked wall, all subwalls at this end will be disallowed to join.

#### Parameter `wall`

The wall in question

#### Parameter `end`

0 or 1 for the beginning or end of the wall's curve

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.WallUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.WallUtils`

#### Summary

General Wall utility methods

#### Since

2012

### `M:Autodesk.Revit.DB.WallSweepInfo.IsEqual(Autodesk.Revit.DB.WallSweepInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WallSweepInfo.IsEqual(Autodesk.Revit.DB.WallSweepInfo)`

#### Summary

Determines if the input object is equivalent to this WallSweepInfo.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.WallSweepInfo.IsFixed`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.IsFixed`

#### Summary

Indicates if the described wall sweep is fixed. A sweep is fixed if it is a part of a vertical compound structure.

#### Remarks

Wall sweeps from the definition of a vertical compound structure are fixed based on the wall type's definition.
They are not permitted to be moved by users.
Other wall sweeps defined outside of CompoundStructure by UI or API are permitted to be moved.

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.IsVertical`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.IsVertical`

#### Summary

Indicates whether the sweep or reveal is swept vertically or horizontally.

#### Remarks

Wall sweeps defined as a part of a vertical compound structure will always be horizontal.

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.CutsWall`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.CutsWall`

#### Summary

Indicates if you want the sweep to cut geometry out of the host wall.

#### Remarks

When a sweep is offset and embedded in the wall, it cuts the geometry from the wall.

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.IsCutByInserts`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.IsCutByInserts`

#### Summary

Indicates if the sweep is cut by wall inserts.

#### Value

True if the sweep is cut by wall inserts, false otherwise.

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.IsProfileFlipped`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.IsProfileFlipped`

#### Summary

Indicates if the profile is applied upside-down.

#### Value

True if the profile is applied upside-down, false otherwise.

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.WallSweepOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.WallSweepOrientation`

#### Summary

Indicates how the profile of a horiztonal sweep is oriented with repect to the wall side face.

#### Value

Allowed values are Horizontal and Perpendicular. Default is Perpendicular

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.DistanceMeasuredFrom`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.DistanceMeasuredFrom`

#### Summary

Indicates if Distance is measured from the top or bottom of the wall.

#### Value

If the sweep or reveal is vertical, DistanceMeasuredFrom.Base represents the
start of the wall's location curve (t=0). DistanceMeasuredFrom.Top is currently
not implemented for vertical sweeps and shouldn't be used when creating them.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.WallSweepType`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.WallSweepType`

#### Summary

The type (either a wall sweep or a reveal).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.WallSide`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.WallSide`

#### Summary

The side of the wall to which the sweep or reveal is attached.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.Id`

#### Summary

The id of the sweep or reveal.

#### Value

If the wall sweep belongs to a vertically compound structure, this must be a non-negative
value. If the wall sweep belongs to a sweep defined outside of compound structures by UI or API
the id will typically be -1 and is not used.

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.MaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.MaterialId`

#### Summary

The element id of the material used to create the sweep or reveal.

#### Remarks

This value is not used when creating standalone wall sweeps. The material id of the
wall sweep's type is used instead.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.ProfileId`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.ProfileId`

#### Summary

The element id of the profile family used to create the sweep or reveal.

#### Remarks

This value is not used when creating standalone wall sweeps. The profile id of the
wall sweep's type is used instead.

#### Value

May be InvalidElementId if the default profile is used.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.DefaultSetback`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.DefaultSetback`

#### Summary

The sweep setback distance from inserts, such as windows and doors.

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.WallOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.WallOffset`

#### Summary

The offset from the sweep or reveal to the wall.

#### Value

If the sweep is a solid sweep, a negative value moves it toward the wall core.
If the sweep is a reveal, a negative offset value moves it away from the wall.

#### Since

2012

### `P:Autodesk.Revit.DB.WallSweepInfo.Distance`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallSweepInfo.Distance`

#### Summary

Represents the distance from either the top or base of the wall for horizontal sweeps,
or the parameter along the wall's path curve for vertical ones.

#### Value

DistanceMeasuredFrom determines where the measurement starts from, depending on the orientation of the sweep.
If the sweep or reveal is vertical, this distance is equal to the parameter along the wall's path curve.

#### Since

2012

### `M:Autodesk.Revit.DB.WallSweepInfo.#ctor(Autodesk.Revit.DB.WallSweepType,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WallSweepInfo.#ctor(Autodesk.Revit.DB.WallSweepType,System.Boolean)`

#### Summary

Constructs a new WallSweepInfo instance.

#### Parameter `type`

The type of the WallSweepInfo instance.

#### Parameter `vertical`

True to construct a vertical wall sweep, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.WallSweepInfo.#ctor(System.Boolean,Autodesk.Revit.DB.WallSweepType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WallSweepInfo.#ctor(System.Boolean,Autodesk.Revit.DB.WallSweepType)`

#### Summary

Constructs a new WallSweepInfo instance.

#### Parameter `fixed`

True if the WallSweepInfo should be fixed (suitable for use in CompoundStructure.AddWallSweep()).
False if the WallSweepInfo should be suitable for use in standalone wall sweep or reveal elements.

#### Parameter `type`

The type of the WallSweepInfo instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.WallSweepInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.WallSweepInfo`

#### Summary

Represents a wall sweep or reveal of a vertically compound structure.

#### Since

2012

### `T:Autodesk.Revit.DB.WallSweepOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.WallSweepOrientation`

#### Summary

Represents the orientation of horizonally placed sweep's profile relative to the wall side face.

#### Since

2021

### `F:Autodesk.Revit.DB.WallSweepOrientation.Perpendicular`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallSweepOrientation.Perpendicular`

#### Summary

Profile is perpendicular to the wall side face

### `F:Autodesk.Revit.DB.WallSweepOrientation.Horizontal`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallSweepOrientation.Horizontal`

#### Summary

Profile is oriented horizontally regardless of wall slant angle

### `T:Autodesk.Revit.DB.DistanceMeasuredFrom`

Member kind: type
Symbol: `Autodesk.Revit.DB.DistanceMeasuredFrom`

#### Summary

Indicates if the distance is measured from the top or bottom of the wall.

#### Since

2012

### `F:Autodesk.Revit.DB.DistanceMeasuredFrom.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.DistanceMeasuredFrom.Top`

#### Summary

From top.

### `F:Autodesk.Revit.DB.DistanceMeasuredFrom.Base`

Member kind: field
Symbol: `Autodesk.Revit.DB.DistanceMeasuredFrom.Base`

#### Summary

From bottom.

### `T:Autodesk.Revit.DB.WallSide`

Member kind: type
Symbol: `Autodesk.Revit.DB.WallSide`

#### Summary

Represents the possible sides of a wall where a sweep or reveal may be attached.

#### Since

2012

### `F:Autodesk.Revit.DB.WallSide.Interior`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallSide.Interior`

#### Summary

The interior of the wall.

### `F:Autodesk.Revit.DB.WallSide.Exterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallSide.Exterior`

#### Summary

The exterior of the wall.

### `T:Autodesk.Revit.DB.WallSweepType`

Member kind: type
Symbol: `Autodesk.Revit.DB.WallSweepType`

#### Summary

Represents the possible types for methods affecting wall sweeps or reveals.

#### Since

2012

### `F:Autodesk.Revit.DB.WallSweepType.Reveal`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallSweepType.Reveal`

#### Summary

Represents a reveal.

### `F:Autodesk.Revit.DB.WallSweepType.Sweep`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallSweepType.Sweep`

#### Summary

Represents a wall sweep.

### `M:Autodesk.Revit.DB.Wall.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Wall.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a non rectangular profile wall within the project using the specified wall type and normal vector.

#### Parameter `document`

The document in which the new wall is created.

#### Parameter `profile`

An array of planar curves that represent the vertical profile of the wall.

#### Parameter `wallTypeId`

Id of the wall type to be used by the new wall instead of the default type.

#### Parameter `levelId`

Id of the level on which the wall is to be placed.

#### Parameter `structural`

If set, specifies that the wall is structural in nature.

#### Parameter `normal`

A vector that must be perpendicular to the profile which dictates which side of the wall is considered to be inside and outside.

#### Returns

If successful a new wall object within the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input profile contains at least one helical curve and is not supported for this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the wall.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

### `M:Autodesk.Revit.DB.Wall.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Wall.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Creates a non rectangular profile wall within the project using the specified wall type.

#### Parameter `document`

The document in which the new wall is created.

#### Parameter `profile`

An array of planar curves that represent the vertical profile of the wall.

#### Parameter `wallTypeId`

Id of the wall type to be used by the new wall instead of the default type.

#### Parameter `levelId`

Id of the level on which the wall is to be placed.

#### Parameter `structural`

If set, specifies that the wall is structural in nature.

#### Returns

If successful a new wall object within the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input profile contains at least one helical curve and is not supported for this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the wall.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

### `M:Autodesk.Revit.DB.Wall.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Wall.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},System.Boolean)`

#### Summary

Creates a non rectangular profile wall within the project using the default wall type.

#### Parameter `document`

The document in which the new wall is created.

#### Parameter `profile`

An array of planar curves that represent the vertical profile of the wall.

#### Parameter `structural`

If set, specifies that the wall is structural in nature.

#### Returns

If successful a new wall object within the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input profile contains at least one helical curve and is not supported for this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the wall.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

### `M:Autodesk.Revit.DB.Wall.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double,System.Double,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Wall.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double,System.Double,System.Boolean,System.Boolean)`

#### Summary

Creates a new rectangular profile wall within the project using the specified wall type, height, and offset.

#### Parameter `document`

The document in which the new wall is created.

#### Parameter `curve`

A curve representing the base line of the wall.

#### Parameter `wallTypeId`

Id of the wall type to be used by the new wall instead of the default type.

#### Parameter `levelId`

Id of the level on which the wall is to be placed.

#### Parameter `height`

The height of the wall other than the default height.

#### Parameter `offset`

Modifies the wall's Base Offset parameter to determine its vertical placement.

#### Parameter `flip`

Change which side of the wall is considered to be the inside and outside of the wall.

#### Parameter `structural`

If set, specifies that the wall is structural in nature.

#### Returns

If successful a new wall object within the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The curve argument is not valid for wall creation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for height must be greater than 0 and no more than 30000 feet.
-or-
The given value for offset must be no more than 30000 feet in absolute value.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

### `M:Autodesk.Revit.DB.Wall.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Wall.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Creates a new rectangular profile wall within the project using the default wall style.

#### Parameter `document`

The document in which the new wall is created.

#### Parameter `curve`

A curve representing the base line of the wall.

#### Parameter `levelId`

Id of the level on which the wall is to be placed.

#### Parameter `structural`

If set, specifies that the wall is structural in nature.

#### Returns

If successful a new wall object within the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The curve argument is not valid for wall creation.

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

### `M:Autodesk.Revit.DB.Wall.CanHaveProfileSketch`

Member kind: method
Symbol: `Autodesk.Revit.DB.Wall.CanHaveProfileSketch`

#### Summary

Checks whether this wall has or can have a profile sketch.

#### Remarks

Wall does not support profile if it is not a straight wall; or wall is tapered;
or it is an old curtain wall; or it is an infill wall; or it is a replacement curtain panel.

#### Returns

True if wall supports profile sketch, false otherwise.

### `M:Autodesk.Revit.DB.Wall.Flip`

Member kind: method
Symbol: `Autodesk.Revit.DB.Wall.Flip`

#### Summary

The wall orientation will be flipped.

### `M:Autodesk.Revit.DB.Wall.IsWallCrossSectionValid(Autodesk.Revit.DB.WallCrossSection)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Wall.IsWallCrossSectionValid(Autodesk.Revit.DB.WallCrossSection)`

#### Summary

Checks whether the desired cross section is valid for the current wall.

#### Parameter `wallCrossSection`

The desired cross section.

#### Returns

True if the wall can be set to the desired cross section.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `M:Autodesk.Revit.DB.Wall.GetStackedWallMemberIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Wall.GetStackedWallMemberIds`

#### Summary

Get the sub walls which belongs to the wall.

#### Returns

If the wall is a stacked wall, the Ids of the sub will be returned in bottom-top order.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This wall isn't a consistent stacked wall.

#### Since

2015

### `M:Autodesk.Revit.DB.Wall.RemoveProfileSketch`

Member kind: method
Symbol: `Autodesk.Revit.DB.Wall.RemoveProfileSketch`

#### Summary

Reverts an edited wall to its original shape.

#### Remarks

The wall profile is changed back to its original rectangular profile. All profile changes made in the sketch mode are discarded.
To check if wall sketch can be removed call `P:Autodesk.Revit.DB.Wall.SketchId` .

#### Since

2022

### `M:Autodesk.Revit.DB.Wall.CreateProfileSketch`

Member kind: method
Symbol: `Autodesk.Revit.DB.Wall.CreateProfileSketch`

#### Summary

Creates a new Wall profile Sketch.

#### Remarks

The loop of the sketch cannot be obtained until regeneration.
To regenerate the document use `M:Autodesk.Revit.DB.Document.Regenerate` .
To edit the Wall profile use `!:Autodesk::Revit::DB::SketchEditScope` .

#### Returns

Created profile Sketch of the Wall.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Wall does not support profile Sketch as it is not a straight wall; or is tapered;
or it is an old curtain wall; or it is an infill wall; or it is a replacement curtain panel.
-or-
Wall already has a sketch.

#### Since

2022

### `P:Autodesk.Revit.DB.Wall.Orientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Wall.Orientation`

#### Summary

The normal vector projected from the exterior side of the wall.

### `P:Autodesk.Revit.DB.Wall.CrossSection`

Member kind: property
Symbol: `Autodesk.Revit.DB.Wall.CrossSection`

#### Summary

Obtain the Wall Cross-section for this wall.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The current wall does not support the cross section wallCrossSection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `P:Autodesk.Revit.DB.Wall.StackedWallOwnerId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Wall.StackedWallOwnerId`

#### Summary

Gets the stacked wall which contains this stacked wall member.

#### Since

2015

### `P:Autodesk.Revit.DB.Wall.IsStackedWallMember`

Member kind: property
Symbol: `Autodesk.Revit.DB.Wall.IsStackedWallMember`

#### Summary

Identifies if the wall is a member of a stacked wall.

#### Since

2015

### `P:Autodesk.Revit.DB.Wall.IsStackedWall`

Member kind: property
Symbol: `Autodesk.Revit.DB.Wall.IsStackedWall`

#### Summary

Identifies if the wall is a stacked wall.

#### Since

2015

### `P:Autodesk.Revit.DB.Wall.Flipped`

Member kind: property
Symbol: `Autodesk.Revit.DB.Wall.Flipped`

#### Summary

Property to test whether the wall orientation is flipped.

### `P:Autodesk.Revit.DB.Wall.StructuralUsage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Wall.StructuralUsage`

#### Summary

Retrieves or changes the wall's designated structural usage.

#### Value

The wall's designated structural usage, such as bearing or non bearing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The enum value is not invalid for StructuralWallUsage.
-or-
When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.Wall.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.Wall.Width`

#### Summary

Get the overall thickness of the wall.

### `P:Autodesk.Revit.DB.Wall.WallType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Wall.WallType`

#### Summary

Retrieves or changes the type of the wall.

#### Remarks

The WallType property can be used to retrieve the kind of the wall.
This property can also be used to change the type of a wall by setting it to a different wall type.
All the wall types in the project can be found using the Document.WallTypes property.

#### Value

The type of the wall.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The wall type wallType is not valid for the current wall.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.Wall.SketchId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Wall.SketchId`

#### Summary

Returns id of the profile sketch, or invalidElementId if sketch does not exist.

#### Remarks

To create profile Sketch for the Wall, call `M:Autodesk.Revit.DB.Wall.CreateProfileSketch` .

#### Since

2022

### `P:Autodesk.Revit.DB.Wall.CurtainGrid`

Member kind: property
Symbol: `Autodesk.Revit.DB.Wall.CurtainGrid`

#### Summary

Get the grid object of a curtain wall

#### Remarks

This property is readonly.

### `T:Autodesk.Revit.DB.Wall`

Member kind: type
Symbol: `Autodesk.Revit.DB.Wall`

#### Summary

Represents a wall in Autodesk Revit.

#### Remarks

The wall object represents all the different kinds of walls in Revit.

### `M:Autodesk.Revit.DB.WallSweep.WallAllowsWallSweep(Autodesk.Revit.DB.Wall)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WallSweep.WallAllowsWallSweep(Autodesk.Revit.DB.Wall)`

#### Summary

Validates that the wall is of a type that may be a host for a wall sweep or reveal.

#### Remarks

This function excludes curtain walls and the main wall of a set of stacked walls.
The wall must be fully regenerated for this function to work correctly.

#### Parameter `wall`

The wall.

#### Returns

True if the wall may host a wall sweep, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WallSweep.Create(Autodesk.Revit.DB.Wall,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.WallSweepInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WallSweep.Create(Autodesk.Revit.DB.Wall,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.WallSweepInfo)`

#### Summary

Creates a new wall sweep or reveal.

#### Remarks

The wall sweep's profile and type are taken from the wall sweep type properties. The
values set in the WallSweepInfo are ignored.

#### Parameter `wall`

The wall upon which to create the new sweep or reveal.

#### Parameter `wallSweepType`

The wall sweep or reveal type.

#### Parameter `wallSweepInfo`

The information that describes the new wall sweep or reveal.

#### Returns

The new wall sweep.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The wall sweep info represents a fixed wall sweep. Fixed wall sweeps may not be assigned to standalone wall sweep elements.
-or-
The WallSweepInfo id must be set to -1 for a non-fixed wall sweep.
-or-
wall may not host a wall sweep or reveal.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WallSweep.GetHostIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.WallSweep.GetHostIds`

#### Summary

Gets a list of all host walls on which the sweep resides.

#### Remarks

Fixed wall sweeps from vertically compound structures will return only one host element.

#### Returns

The list of wall ids.

#### Since

2012

### `M:Autodesk.Revit.DB.WallSweep.GetWallSweepInfo`

Member kind: method
Symbol: `Autodesk.Revit.DB.WallSweep.GetWallSweepInfo`

#### Summary

Gets the information of the wall sweep or reveal.

#### Returns

The information that describes the wall sweep or reveal.

#### Since

2012

### `T:Autodesk.Revit.DB.WallSweep`

Member kind: type
Symbol: `Autodesk.Revit.DB.WallSweep`

#### Summary

Represents a wall sweep or reveal.

#### Remarks

This element may represent either a standalone sweep or reveal element created by the Revit user interface
or API, or a "fixed" wall sweep or reveal that was created by the contents of a wall's compound structure.

#### Since

2012

### `P:Autodesk.Revit.DB.Visual.WallPaint.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.WallPaint.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "WallPaint" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.WallPaint.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.WallPaint.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "WallPaint" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.WallPaint.WallpaintApplication`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.WallPaint.WallpaintApplication`

#### Summary

The property labeled "Application" from the "WallPaint" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "WallpaintApplicationType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.WallPaint.WallpaintFinish`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.WallPaint.WallpaintFinish`

#### Summary

The property labeled "Finish" from the "WallPaint" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "WallpaintFinishType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.WallPaint.WallpaintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.WallPaint.WallpaintColor`

#### Summary

The property labeled "Color" from the "WallPaint" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.WallPaint`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.WallPaint`

#### Summary

A static class that provides access to the property names that appear in the WallPaint visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.WallFoundation.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WallFoundation.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new wall foundation within the project.

#### Parameter `document`

The document.

#### Parameter `typeId`

The id of the wall foundation type of the newly created wall foundation.

#### Parameter `wallId`

The id of the host wall of the newly created wall foundation.

#### Returns

If successful, returns the newly created wall foundation, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

typeId is not a valid WallFoundationType id.
-or-
wallId does not refer to a valid wall.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.WallFoundation.WallId`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallFoundation.WallId`

#### Summary

Returns the id of the host wall.

#### Since

2016

### `T:Autodesk.Revit.DB.WallFoundation`

Member kind: type
Symbol: `Autodesk.Revit.DB.WallFoundation`

#### Summary

An object that represents a wall foundation element.

#### Since

2016

### `T:Autodesk.Revit.DB.WallFoundationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.WallFoundationType`

#### Summary

An object that represents the type of a wall foundation in Autodesk Revit.

#### Since

2016

### `P:Autodesk.Revit.DB.WallType.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallType.Width`

#### Summary

The overall thickness of this type of wall.

### `P:Autodesk.Revit.DB.WallType.Kind`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallType.Kind`

#### Summary

The nature of the wall.

### `P:Autodesk.Revit.DB.WallType.ThermalProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallType.ThermalProperties`

#### Summary

The calculated and settable thermal properties of the WallType

#### Remarks

Returns `null` if the wall has no thermal properties.
Curtain walls and stacked walls do not store thermal properties.

#### Since

2013

### `P:Autodesk.Revit.DB.WallType.Function`

Member kind: property
Symbol: `Autodesk.Revit.DB.WallType.Function`

#### Summary

The wall function.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `T:Autodesk.Revit.DB.WallType`

Member kind: type
Symbol: `Autodesk.Revit.DB.WallType`

#### Summary

Represents a specific type of wall, such as 'Generic - 8"'.

#### Remarks

All wall type objects available in the project can be retrieved from the Document object
via the WallTypes property. Every Wall object has a WallType property that returns the a
WallType object representing the type. This same WallType property can also be used to
change the type of the wall by setting it to a different type.

### `T:Autodesk.Revit.DB.WallFunction`

Member kind: type
Symbol: `Autodesk.Revit.DB.WallFunction`

#### Summary

Indicates the function of a specified WallType, as specified in the parameter FUNCTION_PARAM on the WallType.

### `F:Autodesk.Revit.DB.WallFunction.Coreshaft`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallFunction.Coreshaft`

#### Summary

A coreshaft wall.

### `F:Autodesk.Revit.DB.WallFunction.Soffit`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallFunction.Soffit`

#### Summary

A soffit wall.

### `F:Autodesk.Revit.DB.WallFunction.Retaining`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallFunction.Retaining`

#### Summary

A retaining wall.

### `F:Autodesk.Revit.DB.WallFunction.Foundation`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallFunction.Foundation`

#### Summary

A foundation wall.

### `F:Autodesk.Revit.DB.WallFunction.Exterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallFunction.Exterior`

#### Summary

An exterior wall.

### `F:Autodesk.Revit.DB.WallFunction.Interior`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallFunction.Interior`

#### Summary

An interior wall.

### `T:Autodesk.Revit.DB.WallKind`

Member kind: type
Symbol: `Autodesk.Revit.DB.WallKind`

#### Summary

Describes the fundamental type of wall, such as curtain wall or stacked wall.

### `F:Autodesk.Revit.DB.WallKind.Stacked`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallKind.Stacked`

#### Summary

A stacked wall of several wall types.

### `F:Autodesk.Revit.DB.WallKind.Curtain`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallKind.Curtain`

#### Summary

A curtain wall.

### `F:Autodesk.Revit.DB.WallKind.Basic`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallKind.Basic`

#### Summary

A standard wall.

### `F:Autodesk.Revit.DB.WallKind.Unknown`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallKind.Unknown`

#### Summary

The basic type is not known.

### `T:Autodesk.Revit.DB.WallCrossSection`

Member kind: type
Symbol: `Autodesk.Revit.DB.WallCrossSection`

#### Summary

The allowed values for the WALL_CROSS_SECTION parameter.

### `F:Autodesk.Revit.DB.WallCrossSection.Tapered`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallCrossSection.Tapered`

#### Summary

A tapered wall whose angle is controlled by the parameters
WALL_TAPERED_EXTERIOR_INWARD_ANGLE and WALL_TAPERED_INTERIOR_INWARD_ANGLE.

### `F:Autodesk.Revit.DB.WallCrossSection.SingleSlanted`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallCrossSection.SingleSlanted`

#### Summary

A single-slanted wall whose angle is controlled by the parameter WALL_SINGLE_SLANT_ANGLE_FROM_VERTICAL.

### `F:Autodesk.Revit.DB.WallCrossSection.Vertical`

Member kind: field
Symbol: `Autodesk.Revit.DB.WallCrossSection.Vertical`

#### Summary

A vertical wall, 0 degrees.

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.CanBeDivisionProfile(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.CanBeDivisionProfile(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether a family defines a profile which can be used by this method.

#### Parameter `familyId`

Element id of the family.

#### Returns

True if the family defines a profile which can be used by a part maker,
false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.CanBeDivisionProfile(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.CanBeDivisionProfile(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document)`

#### Summary

Checks whether a family defines a profile which can be used by this method.

#### Parameter `familyId`

Element id of the family.

#### Parameter `familyDocument`

The document containing the family to be tested.

#### Returns

True if the family defines a profile which can be used by a part maker,
false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.RemoveIntersectingReference(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.RemoveIntersectingReference(Autodesk.Revit.DB.ElementId)`

#### Summary

Removed intersecting reference.

#### Parameter `intersectingReference`

Id of the intersecting reference to remove.

#### Returns

True if the PartMaker used this intersecting reference and
this call removed it, false if the PartMaker did not use this
intersecting reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id was not permitted as intersecting references.
Intersecting references should be levels, grids, or reference planes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.AddIntersectingReference(Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.AddIntersectingReference(Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Adds intersecting reference with an offset.

#### Parameter `intersectingReference`

Id of the new intersecting reference.

#### Parameter `offset`

The Offste for the new intersecting reference.

#### Returns

True if the PartMaker did not already use this
intersecting reference and it was added, false if the PartMaker
already used this intersecting reference and this call
only updated its offset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id was not permitted as intersecting references.
Intersecting references should be levels, grids, or reference planes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.GetOffsetForIntersectingReference(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.GetOffsetForIntersectingReference(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets offset for the intersecting reference.

#### Parameter `intersectingReference`

The intersecting reference to obtain offset value from.

#### Returns

The offset for the intersecting reference

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

PartMaker does not use the specified intersecting reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.SetOffsetForIntersectingReference(Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.SetOffsetForIntersectingReference(Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Sets offset for the intersecting reference.

#### Parameter `intersectingReference`

The intersecting reference that will be offset.

#### Parameter `offset`

The new offset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

PartMaker does not use the specified intersecting reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.UsesReference(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.UsesReference(Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if the PartMaker uses the intersecting reference.

#### Parameter `intersectingReference`

Intersecting reference to be tested.

#### Returns

True if the intersecting reference is used by the PartMaker.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.IsValidSketchPlane(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.IsValidSketchPlane(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if provided sketch plane is valid.

#### Parameter `document`

The document.

#### Parameter `sketchPlaneId`

SketchPlane ids to be tested for validity for PartMaker.

#### Returns

True if SketchPlane valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.AreElementsValidIntersectingReferences(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.AreElementsValidIntersectingReferences(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Identifies if provided members are valid.

#### Parameter `document`

The document.

#### Parameter `elementIds`

Element ids to be tested for validity for intersecting references.

#### Returns

True if all references are valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.AreElementsValidIntersectingReferences(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.AreElementsValidIntersectingReferences(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Identifies if provided members are valid.

#### Parameter `elementIds`

Element ids to be tested for validity for intersecting references.

#### Returns

True if all references are valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.IsElementValidIntersectingReference(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.IsElementValidIntersectingReference(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if the provided member is valid.

#### Parameter `document`

The document.

#### Parameter `elementId`

Element ids to be tested for validity for intersecting references.

#### Returns

True if the reference is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.IsElementValidIntersectingReference(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.IsElementValidIntersectingReference(Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if the provided member is valid.

#### Parameter `elementId`

Element ids to be tested for validity for intersecting references.

#### Returns

True if the reference is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.GetSplitRefsOffsets`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.GetSplitRefsOffsets`

#### Summary

Returns offsets for plane-defining splitters.

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.GetPlaneOfSketch`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.GetPlaneOfSketch`

#### Summary

Gets the plane of the sketch.

#### Returns

The plane of the sketch.

#### Since

2013

### `M:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.GetSketchCurves(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.GetSketchCurves(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve}@)`

#### Summary

Populates the array with copies of curves in the sketch.

#### Parameter `curveArray`

Curves in the sketch. Tags of the curves are consistent with the curve tags
used in part keys.

#### Since

2013

### `P:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.DivisionPatternMirror`

Member kind: property
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.DivisionPatternMirror`

#### Summary

Whether pattern defined by the division rule should be mirrored before application
Mirroring is similar to changing indices of u-const gridlines.

#### Since

2013

### `P:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.DivisionRotationAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.DivisionRotationAngle`

#### Summary

Angle by which both u- and v- gridlines of the division are rotated with respect
to the natural u/v-const directions of the sketch plane.

#### Since

2013

### `P:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.VConstDivisionIndent`

Member kind: property
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.VConstDivisionIndent`

#### Summary

Indentation for the application of division rule's pattern across v-const gridlines
(i.e., similar to changing indices of v-const gridlines).

#### Since

2013

### `P:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.UConstDivisionIndent`

Member kind: property
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.UConstDivisionIndent`

#### Summary

Indentation for the application of division rule's pattern across u-const gridlines
(i.e., similar to changing indices of u-const gridlines).

#### Since

2013

### `P:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.DivisionRuleId`

Member kind: property
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.DivisionRuleId`

#### Summary

Id of the 'DivisionRule' which is used to augment the cutting sketch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The provided element id cannot be assigned as a division rule
to this PartMakerMethodToDivideVolumes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.ProfileFlipAlong`

Member kind: property
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.ProfileFlipAlong`

#### Summary

True if the corresponding left/upper parts profile are mirrored with respect
to the center line of the hosts to be divided. False if the profile of
left/upper parts are defined directly by the profile family.

#### Since

2013

### `P:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.ProfileFlipAcross`

Member kind: property
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.ProfileFlipAcross`

#### Summary

True if the corresponding left/upper parts profile are mirrored with respect
to the division line. False if the profile of left/upper parts are defined
directly by the profile family.

#### Since

2013

### `P:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.ProfileType`

Member kind: property
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.ProfileType`

#### Summary

The id of the profile family applied to boundaries between parts.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.ProfileOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.ProfileOffset`

#### Summary

The offset which is applied to a family-defined profile in the
direction away from the division line and toward left/upper part
to obtain its profile.

#### Since

2013

### `P:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.DivisionGap`

Member kind: property
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.DivisionGap`

#### Summary

The gap which is created between matching profiles of parts.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for divisionGap must be between 0 and 30000 feet.

#### Since

2013

### `P:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.ProfileMatch`

Member kind: property
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes.ProfileMatch`

#### Summary

Determines how two profiles match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `T:Autodesk.Revit.DB.PartMakerMethodToDivideVolumes`

Member kind: type
Symbol: `Autodesk.Revit.DB.PartMakerMethodToDivideVolumes`

#### Summary

By-References dividing strategy used by PartMaker element.
TODO_REFACTOR("LegacyMechanismOfMovingElements")
returns true if
- the Host Elements are not floors or walls
- OR
- the Host Elements that are referenced by this PartMaker are floors or walls
- transformation has already been applied on those Host Elements

#### Since

2013

### `T:Autodesk.Revit.DB.PartEdgeConditionOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.PartEdgeConditionOrientation`

#### Summary

Relative orientation of the right/lower and left/upper edge condition profiles.

#### Remarks

A family-based profile defines the shape of the left/upper profile and this
value defines how a matching right/lower profile is obtained.

#### Since

2013

### `F:Autodesk.Revit.DB.PartEdgeConditionOrientation.MirroredAndRotated`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartEdgeConditionOrientation.MirroredAndRotated`

#### Summary

Right/lower profile is obtained first by mirroring the left/upper profile with respect to the
division line and then by mirroring the result with respect to the center line of the
divided thickness. The division gap is not applied.

### `F:Autodesk.Revit.DB.PartEdgeConditionOrientation.Mirrored`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartEdgeConditionOrientation.Mirrored`

#### Summary

Right/lower profile is obtained by mirroring the left/upper profile with respect to the
division line. The division gap is not applied.

### `F:Autodesk.Revit.DB.PartEdgeConditionOrientation.Complement`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartEdgeConditionOrientation.Complement`

#### Summary

Before division gap is applied the left/upper and right/lower profiles coincide
and neighboring panels complement each other precisely.

### `P:Autodesk.Revit.DB.Visual.BumpMap.BumpmapType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.BumpmapType`

#### Summary

The property labeled "Bump Type" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "BumpmapType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.BumpMap.TextureVRepeat`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.TextureVRepeat`

#### Summary

The property labeled "V Repeat" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.BumpMap.TextureURepeat`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.TextureURepeat`

#### Summary

The property labeled "U Repeat" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.BumpMap.BumpmapNormalScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.BumpmapNormalScale`

#### Summary

The property labeled "Amount" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyDouble".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.BumpMap.BumpmapDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.BumpmapDepth`

#### Summary

The property labeled "Amount" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.BumpMap.TextureScaleLock`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.TextureScaleLock`

#### Summary

The property labeled "Scale Lock" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.BumpMap.TextureRealWorldScaleY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.TextureRealWorldScaleY`

#### Summary

The property labeled "Size Y" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyDistance" with a minimum of "0.01".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.BumpMap.TextureRealWorldScaleX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.TextureRealWorldScaleX`

#### Summary

The property labeled "Size X" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyDistance" with a minimum of "0.01".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.BumpMap.TextureWAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.TextureWAngle`

#### Summary

The property labeled "Angle" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 360".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.BumpMap.TextureOffsetLock`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.TextureOffsetLock`

#### Summary

The property labeled "Offset Lock" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.BumpMap.TextureRealWorldOffsetY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.TextureRealWorldOffsetY`

#### Summary

The property labeled "Offset Y" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.BumpMap.TextureRealWorldOffsetX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.TextureRealWorldOffsetX`

#### Summary

The property labeled "Offset X" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.BumpMap.TextureLinkTextureTransforms`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.TextureLinkTextureTransforms`

#### Summary

The property labeled "Link Transforms" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.BumpMap.BumpmapBitmap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.BumpMap.BumpmapBitmap`

#### Summary

The property labeled "Source" from the "BumpMap" schema.

#### Remarks

This property is of type "AssetPropertyString" and will contain a relative path.

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.BumpMap`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.BumpMap`

#### Summary

A static class that provides access to the property names that appear in the BumpMap visual asset schema.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Structure.StructuralWallUsageFilter.StructuralWallUsage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralWallUsageFilter.StructuralWallUsage`

#### Summary

The wall structural usage.

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.StructuralWallUsageFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralWallUsage,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralWallUsageFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralWallUsage,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match walls that have the given structural wall usage,
with the option to match all walls which are not of the given structural wall usage.

#### Parameter `structuralWallUsage`

The structural usage to match.

#### Parameter `inverted`

True if the filter should match all walls which are not of the given structural wall usage.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.StructuralWallUsageFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralWallUsage)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralWallUsageFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralWallUsage)`

#### Summary

Constructs a new instance of a filter to match walls that have the given structural wall usage.

#### Parameter `structuralWallUsage`

The wall structural usage.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `T:Autodesk.Revit.DB.Structure.StructuralWallUsageFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralWallUsageFilter`

#### Summary

A filter used to match walls that have the given structural wall usage.

#### Remarks

This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements
before the elements are obtained and expanded. Therefore this filter does not have to be
paired with another quick filter to minimize the number of Elements that are expanded.

#### Since

2011

### `T:Autodesk.Revit.DB.Structure.StructuralWallUsage`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralWallUsage`

#### Since

2011

#### Summary

Represents the structural usage of a wall.

#### Since

2011

### `F:Autodesk.Revit.DB.Structure.StructuralWallUsage.Combined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralWallUsage.Combined`

#### Summary

Structural usage is combined.

### `F:Autodesk.Revit.DB.Structure.StructuralWallUsage.Shear`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralWallUsage.Shear`

#### Summary

Structural usage is shear.

### `F:Autodesk.Revit.DB.Structure.StructuralWallUsage.Bearing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralWallUsage.Bearing`

#### Summary

Structural usage is bearing.

### `F:Autodesk.Revit.DB.Structure.StructuralWallUsage.NonBearing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralWallUsage.NonBearing`

#### Summary

Structural usage is non-bearing.

### `P:Autodesk.Revit.DB.Structure.StructuralMaterialTypeFilter.StructuralMaterialType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralMaterialTypeFilter.StructuralMaterialType`

#### Summary

The structural material type.

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.StructuralMaterialTypeFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralMaterialType,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralMaterialTypeFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralMaterialType,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match family instances by structural material type,
with the option to match all families which are not of the given structural material type.

#### Parameter `structuralMaterialType`

The structural material type to match.

#### Parameter `inverted`

True if the filter should match all family instances which are not of the given structural material type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.StructuralMaterialTypeFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralMaterialType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralMaterialTypeFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralMaterialType)`

#### Summary

Constructs a new instance of a filter to match family instances that have the given structural material type.

#### Parameter `structuralMaterialType`

The structural material type to match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `T:Autodesk.Revit.DB.Structure.StructuralMaterialTypeFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralMaterialTypeFilter`

#### Summary

A filter used to match family instances that have the given structural material type.

#### Remarks

This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements
before the elements are obtained and expanded. Therefore this filter does not have to be
paired with another quick filter to minimize the number of Elements that are expanded.

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralInstanceUsageFilter.StructuralUsage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsageFilter.StructuralUsage`

#### Summary

The family instance structural usage.

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.StructuralInstanceUsageFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralInstanceUsage,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsageFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralInstanceUsage,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match family instances by structural usage,
with the option to match all family instances which are not of the given structural usage.

#### Parameter `structuralUsage`

The structural usage to match.

#### Parameter `inverted`

True if the filter should match all family instances which are not of the given structural usage.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.StructuralInstanceUsageFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralInstanceUsage)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsageFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralInstanceUsage)`

#### Summary

Constructs a new instance of a filter to match structural family instances (typically columns, beams, or braces) of the given structural usage.

#### Parameter `structuralUsage`

The family instance structural usage.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `T:Autodesk.Revit.DB.Structure.StructuralInstanceUsageFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralInstanceUsageFilter`

#### Summary

A filter used to find elements that are structural family instances (typically columns, beams or braces) of the given structural usage.

#### Remarks

This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements
before the elements are obtained and expanded. Therefore this filter does not have to be
paired with another quick filter to minimize the number of Elements that are expanded.

#### Since

2011

### `P:Autodesk.Revit.DB.FamilyInstanceFilter.FamilySymbolId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyInstanceFilter.FamilySymbolId`

#### Summary

The family symbol id.

#### Since

2011

### `M:Autodesk.Revit.DB.FamilyInstanceFilter.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyInstanceFilter.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a new instance of a filter to match family instances of the given family symbol.

#### Parameter `document`

The document. This requirement is unique to this filter and is needed to ensure the input
family symbol id is valid for the provided document. This ensures the most stability and
greatest performance for this filter.

#### Parameter `familySymbolId`

The family symbol id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The familySymbolId does not represent a valid FamilySymbol record in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.FamilyInstanceFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyInstanceFilter`

#### Summary

A filter used to find elements that are family instances of the given family symbol.

#### Remarks

This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements
before the elements are obtained and expanded. Therefore this filter does not have to be
paired with another quick filter to minimize the number of Elements that are expanded.

#### Since

2011

### `P:Autodesk.Revit.DB.FamilySymbolFilter.FamilyId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilySymbolFilter.FamilyId`

#### Summary

The family id.

#### Since

2011

### `M:Autodesk.Revit.DB.FamilySymbolFilter.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilySymbolFilter.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a new instance of a filter to find all family symbols of the given family.

#### Parameter `familyId`

The family id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The familyId is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.FamilySymbolFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilySymbolFilter`

#### Summary

A filter used to find all family symbols of the given family.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

Note that it may be faster to get a list of symbol ids from
`M:Autodesk.Revit.DB.Family.GetFamilySymbolIds`
rather than to iterate all of the contents of a document with this filter applied.

#### Since

2011

### `P:Autodesk.Revit.DB.ElementStructuralTypeFilter.StructuralType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementStructuralTypeFilter.StructuralType`

#### Summary

The structural type.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementStructuralTypeFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralType,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementStructuralTypeFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralType,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements by structural type, with the option to match all elements which are of the given structural type.

#### Parameter `structuralType`

The structural type to match.

#### Parameter `inverted`

True if the filter should match all elements which are not of the given structural type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.ElementStructuralTypeFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementStructuralTypeFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralType)`

#### Summary

Constructs a new instance of a filter to match elements by structural type.

#### Parameter `structuralType`

The structural type to match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `T:Autodesk.Revit.DB.ElementStructuralTypeFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementStructuralTypeFilter`

#### Summary

A filter used to find elements matching a structural type.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2011

### `P:Autodesk.Revit.DB.CurveElementFilter.CurveElementType`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveElementFilter.CurveElementType`

#### Summary

The curve element type.

#### Since

2011

### `M:Autodesk.Revit.DB.CurveElementFilter.#ctor(Autodesk.Revit.DB.CurveElementType,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElementFilter.#ctor(Autodesk.Revit.DB.CurveElementType,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match specific types of curve elements,
with the option to match all curves which are not of the given curve type.

#### Parameter `curveElementType`

The curve element type to match.

#### Parameter `inverted`

True if the filter should match all curves which are not of the given curve type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.CurveElementFilter.#ctor(Autodesk.Revit.DB.CurveElementType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveElementFilter.#ctor(Autodesk.Revit.DB.CurveElementType)`

#### Summary

Constructs a new instance of a filter to match specific types of curve elements.

#### Parameter `curveElementType`

The curve element type to match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `T:Autodesk.Revit.DB.CurveElementFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveElementFilter`

#### Summary

A filter used to pass curve elements which are of a specific type.

#### Since

2011

### `T:Autodesk.Revit.DB.CurveElementType`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveElementType`

#### Summary

An enumerated type listing the curve element types that can be used when filtering elements
(via CurveElementFilter).

#### Since

2011

### `F:Autodesk.Revit.DB.CurveElementType.AreaBasedLoadBoundary`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveElementType.AreaBasedLoadBoundary`

#### Summary

An Area Based Load Boundary curve.

### `F:Autodesk.Revit.DB.CurveElementType.Cloud`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveElementType.Cloud`

#### Summary

A portion of a revision cloud.

### `F:Autodesk.Revit.DB.CurveElementType.Insulation`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveElementType.Insulation`

#### Summary

A detail curve representing insulation.

### `F:Autodesk.Revit.DB.CurveElementType.RepeatingDetail`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveElementType.RepeatingDetail`

#### Summary

The profile of a repeating detail set.

### `F:Autodesk.Revit.DB.CurveElementType.CurveByPoints`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveElementType.CurveByPoints`

#### Summary

A curve created by connecting a set of points.

### `F:Autodesk.Revit.DB.CurveElementType.AreaSeparation`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveElementType.AreaSeparation`

#### Summary

An area separation curve.

### `F:Autodesk.Revit.DB.CurveElementType.RoomSeparation`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveElementType.RoomSeparation`

#### Summary

An room separation curve.

### `F:Autodesk.Revit.DB.CurveElementType.SpaceSeparation`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveElementType.SpaceSeparation`

#### Summary

A space separation curve.

### `F:Autodesk.Revit.DB.CurveElementType.ReferenceLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveElementType.ReferenceLine`

#### Summary

A reference line.

### `F:Autodesk.Revit.DB.CurveElementType.SymbolicCurve`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveElementType.SymbolicCurve`

#### Summary

A symbolic curve.

### `F:Autodesk.Revit.DB.CurveElementType.DetailCurve`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveElementType.DetailCurve`

#### Summary

A detail curve.

### `F:Autodesk.Revit.DB.CurveElementType.ModelCurve`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveElementType.ModelCurve`

#### Summary

A model curve.

### `F:Autodesk.Revit.DB.CurveElementType.Invalid`

Member kind: field
Symbol: `Autodesk.Revit.DB.CurveElementType.Invalid`

#### Summary

An invalid curve element type.

### `M:Autodesk.Revit.DB.ElementPhaseStatusFilter.GetPhaseStatuses`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementPhaseStatusFilter.GetPhaseStatuses`

#### Summary

Returns the phase statuses assigned to this filter.

#### Returns

The phase statuses.

#### Since

2012

### `P:Autodesk.Revit.DB.ElementPhaseStatusFilter.PhaseId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementPhaseStatusFilter.PhaseId`

#### Summary

The phase id.

#### Since

2012

### `M:Autodesk.Revit.DB.ElementPhaseStatusFilter.#ctor(Autodesk.Revit.DB.ElementId,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementOnPhaseStatus},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementPhaseStatusFilter.#ctor(Autodesk.Revit.DB.ElementId,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementOnPhaseStatus},System.Boolean)`

#### Summary

Constructs a new instance of a file to match elements that have a given phase statuses on the input phase, with the option
to match all elements that have a phase status other than the input statuses.

#### Parameter `phaseId`

Id of the phase.

#### Parameter `phaseStatuses`

Target statuses.

#### Parameter `inverted`

True to match all phase statuses other than the input statuses.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ElementPhaseStatusFilter.#ctor(Autodesk.Revit.DB.ElementId,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementOnPhaseStatus})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementPhaseStatusFilter.#ctor(Autodesk.Revit.DB.ElementId,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementOnPhaseStatus})`

#### Summary

Constructs a new instance of a file to match elements that have a given phase statuses on the input phase.

#### Parameter `phaseId`

Id of the phase.

#### Parameter `phaseStatuses`

Target statuses.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ElementPhaseStatusFilter.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementOnPhaseStatus,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementPhaseStatusFilter.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementOnPhaseStatus,System.Boolean)`

#### Summary

Constructs a new instance of a file to match elements that have a given phase status on the input phase, with the option
to match all elements that have a phase status other than the input status.

#### Parameter `phaseId`

Id of the phase.

#### Parameter `phaseStatus`

Target status.

#### Parameter `inverted`

True to match all phase statuses other than the input status.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.ElementPhaseStatusFilter.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementOnPhaseStatus)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementPhaseStatusFilter.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementOnPhaseStatus)`

#### Summary

Constructs a new instance of a file to match elements that have a given phase status on the input phase.

#### Parameter `phaseId`

Id of the phase.

#### Parameter `phaseStatus`

Target status.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.ElementPhaseStatusFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementPhaseStatusFilter`

#### Summary

A filter used to match elements that have a given phase status on a given phase.

#### Remarks

This filter is a slow filter.
Slow filters require that the Element be obtained and expanded in memory first.
Thus it is preferable to couple this filter with at least one ElementQuickFilter,
which should minimize the number of Elements that are expanded.

#### Since

2012

### `M:Autodesk.Revit.DB.PrimaryDesignOptionMemberFilter.#ctor(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrimaryDesignOptionMemberFilter.#ctor(System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements contained in any primary design option of any design option set, with the option to invert the filter
and find elements not contained in any primary design option of any design option set.

#### Parameter `inverted`

True if the filter should match all elements which are not contained within a particular design option.

#### Since

2011

### `M:Autodesk.Revit.DB.PrimaryDesignOptionMemberFilter.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrimaryDesignOptionMemberFilter.#ctor`

#### Summary

Constructs a new instance of a filter to match elements contained in any primary design option of any design option set.

#### Since

2011

### `T:Autodesk.Revit.DB.PrimaryDesignOptionMemberFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.PrimaryDesignOptionMemberFilter`

#### Summary

A filter used to find elements contained in any primary design option of any design option set.

#### Remarks

This filter will only pass elements in a primary design option. It will not pass elements in the main model not associated
to any design option.
This filter is a slow filter.
Slow filters require that the Element be obtained and expanded in memory first.
Thus it is preferable to couple this filter with at least one ElementQuickFilter,
which should minimize the number of Elements that are expanded.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementParameterFilter.GetRules`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementParameterFilter.GetRules`

#### Summary

Returns the set of rules contained in this filter.

#### Returns

A copy of the set of rules.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementParameterFilter.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.FilterRule},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementParameterFilter.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.FilterRule},System.Boolean)`

#### Summary

Constructs a new instance of an ElementParameterFilter, with the option to match all elements not passing the given filter rules.

#### Parameter `filterRules`

The rules applied to test if the element passes this filter.

#### Parameter `inverted`

True if the filter should match all elements which do not pass the filter rules.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The filterRules array is empty or invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ElementParameterFilter.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.FilterRule})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementParameterFilter.#ctor(System.Collections.Generic.IList{Autodesk.Revit.DB.FilterRule})`

#### Summary

Constructs a new instance of an ElementParameterFilter from a set of rules.

#### Parameter `filterRules`

The rules applied to test if the element passes this filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The filterRules array is empty or invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ElementParameterFilter.#ctor(Autodesk.Revit.DB.FilterRule,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementParameterFilter.#ctor(Autodesk.Revit.DB.FilterRule,System.Boolean)`

#### Summary

Constructs a new instance of an ElementParameterFilter, with the option to match all elements not passing a given filter rule.

#### Parameter `filterRule`

The rule applied to test if the element passes this filter.

#### Parameter `inverted`

True if the filter should match all elements which do not pass the filter rule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ElementParameterFilter.#ctor(Autodesk.Revit.DB.FilterRule)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementParameterFilter.#ctor(Autodesk.Revit.DB.FilterRule)`

#### Summary

Constructs a new instance of an ElementParameterFilter from a single rule.

#### Parameter `filterRule`

The rule applied to test if the element passes this filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.ElementParameterFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementParameterFilter`

#### Summary

A filter used to match elements by one or more parameter filter rules.

#### Remarks

This filter is a slow filter.
Slow filters require that the Element be obtained and expanded in memory first.
Thus it is preferable to couple this filter with at least one ElementQuickFilter,
which should minimize the number of Elements that are expanded.

#### Since

2011

### `P:Autodesk.Revit.DB.ElementLevelFilter.LevelId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementLevelFilter.LevelId`

#### Summary

The id of the level that will be matched to elements' associated level.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementLevelFilter.#ctor(Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementLevelFilter.#ctor(Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Constructs a new instance of an ElementLevelFilter, with the option to match all elements not associated to the given level id.

#### Parameter `levelId`

The id of the level that will be matched to elements' associated level.

#### Parameter `inverted`

True if the filter should match all elements not associated to the given level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ElementLevelFilter.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementLevelFilter.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a new instance of an ElementLevelFilter.

#### Parameter `levelId`

The id of the level that will be matched to elements' associated level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.ElementLevelFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementLevelFilter`

#### Summary

A filter used to match elements by their associated level.

#### Remarks

This filter is a slow filter.
Slow filters require that the Element be obtained and expanded in memory first.
Thus it is preferable to couple this filter with at least one ElementQuickFilter,
which should minimize the number of Elements that are expanded.

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.FamilyStructuralMaterialTypeFilter.StructuralMaterialType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.FamilyStructuralMaterialTypeFilter.StructuralMaterialType`

#### Summary

The family structural material type.

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.FamilyStructuralMaterialTypeFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralMaterialType,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FamilyStructuralMaterialTypeFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralMaterialType,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match families by structural material type,
with the option to match all families which are not of the given structural material type.

#### Parameter `structuralMaterialType`

The structural material type to match.

#### Parameter `inverted`

True if the filter should match all families which are not of the given structural material type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.FamilyStructuralMaterialTypeFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralMaterialType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.FamilyStructuralMaterialTypeFilter.#ctor(Autodesk.Revit.DB.Structure.StructuralMaterialType)`

#### Summary

Constructs a new instance of a filter to match families that have the given structural material type.

#### Parameter `structuralMaterialType`

The structural material type to match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `T:Autodesk.Revit.DB.Structure.FamilyStructuralMaterialTypeFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.FamilyStructuralMaterialTypeFilter`

#### Summary

A filter used to match families that have the given structural material type.

#### Remarks

This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements
before the elements are obtained and expanded. Therefore this filter does not have to be
paired with another quick filter to minimize the number of Elements that are expanded.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementEpisodeRangeFilter.#ctor(Autodesk.Revit.DB.Document,System.Guid,System.Guid,Autodesk.Revit.DB.EpisodeUsage)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementEpisodeRangeFilter.#ctor(Autodesk.Revit.DB.Document,System.Guid,System.Guid,Autodesk.Revit.DB.EpisodeUsage)`

#### Summary

Constructs a new instance of a filter to match elements having the specified creation, modification,
or user-modification episode id in the specified range.

#### Parameter `document`

The current document.

#### Parameter `startEpisodeGuid`

The earliest element history to match. If null (all zeros), indicates earliest known episode.

#### Parameter `endEpisodeGuid`

The latest element history to match. If null (all zeros), indicates latest known episode.

#### Parameter `episodeUsage`

Restrict match to Creation, Modification, or User Modification episode id. Flags can be combined.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2023

### `M:Autodesk.Revit.DB.ElementEpisodeRangeFilter.#ctor(Autodesk.Revit.DB.Document,System.Guid,System.Guid,Autodesk.Revit.DB.EpisodeUsage,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementEpisodeRangeFilter.#ctor(Autodesk.Revit.DB.Document,System.Guid,System.Guid,Autodesk.Revit.DB.EpisodeUsage,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements having the specified creation, modification,
or user-modification episode id in the specified range, with the option to invert the filter.

#### Parameter `document`

The current document.

#### Parameter `startEpisodeGuid`

The earliest element history to match. If null (all zeros), indicates earliest known episode.

#### Parameter `endEpisodeGuid`

The latest element history to match. If null (all zeros), indicates latest known episode.

#### Parameter `episodeUsage`

Restrict match to Creation, Modification, or User Modification episode id. Flags can be combined.

#### Parameter `inverted`

True if the filter should match all elements whose versions are outside the specified range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2023

### `T:Autodesk.Revit.DB.ElementEpisodeRangeFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementEpisodeRangeFilter`

#### Summary

A filter used to match elements altered within two specified episodes. The given episodes
are checked against one or more of the element's creation date, last user modification date,
or last modification date. If any match, then it is considered a overall match and included.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2023

### `T:Autodesk.Revit.DB.EpisodeUsage`

Member kind: type
Symbol: `Autodesk.Revit.DB.EpisodeUsage`

#### Summary

Enumerated option for how to use episodes when filtering elements by history.

#### Since

2021

#### Since

2021

### `F:Autodesk.Revit.DB.EpisodeUsage.UserModification`

Member kind: field
Symbol: `Autodesk.Revit.DB.EpisodeUsage.UserModification`

#### Summary

Compare to element last user modification date

### `F:Autodesk.Revit.DB.EpisodeUsage.Modification`

Member kind: field
Symbol: `Autodesk.Revit.DB.EpisodeUsage.Modification`

#### Summary

Compare to element last modification date

### `F:Autodesk.Revit.DB.EpisodeUsage.Creation`

Member kind: field
Symbol: `Autodesk.Revit.DB.EpisodeUsage.Creation`

#### Summary

Compare to element creation date

### `F:Autodesk.Revit.DB.EpisodeUsage.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.EpisodeUsage.None`

#### Summary

Compare to nothing in element history

### `P:Autodesk.Revit.DB.BoundingBoxContainsPointFilter.Tolerance`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundingBoxContainsPointFilter.Tolerance`

#### Summary

Allows control over the match criteria by using a tolerance in the geometry comparison. It is suggested to use this in cases where trivial differences should be considered when matching elements.

#### Remarks

By default this is set to zero, but depending on your units of measure and how close objects may be, it is advised to set this to something more realistic.
If the tolerance is positive, the point may lie up to the tolerance amount outside the outline to be matched.
If the tolerance is negative, the point must lie at least the tolerance amount inside the outline to be matched.

#### Since

2011

### `P:Autodesk.Revit.DB.BoundingBoxContainsPointFilter.Point`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundingBoxContainsPointFilter.Point`

#### Summary

The XYZ point to use when matching element bounding boxes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxContainsPointFilter.#ctor(Autodesk.Revit.DB.XYZ,System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxContainsPointFilter.#ctor(Autodesk.Revit.DB.XYZ,System.Double,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements with a bounding box that contains the given point,
while specifying the tolerance to be used in deciding if the point matches the criteria.
This constructor includes the option to invert the filter and match all elements with a bounding box that do not contain the given point.

#### Parameter `point`

The point used to find elements with a bounding box containing it.

#### Parameter `tolerance`

The tolerance value to use instead of zero. See the tolerance property for details.

#### Parameter `inverted`

True if the filter should be inverted and match all elements with a bounding box that do not contain the given point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for tolerance is not finite
-or-
The given value for tolerance is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxContainsPointFilter.#ctor(Autodesk.Revit.DB.XYZ,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxContainsPointFilter.#ctor(Autodesk.Revit.DB.XYZ,System.Double)`

#### Summary

Constructs a new instance of a filter to match elements with a bounding box that contains the given point,
while specifying the tolerance to be used in deciding if the point matches the criteria.

#### Parameter `point`

The point used to find elements with a bounding box that contains it.

#### Parameter `tolerance`

The tolerance value to use instead of zero. See the tolerance property for details.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for tolerance is not finite
-or-
The given value for tolerance is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxContainsPointFilter.#ctor(Autodesk.Revit.DB.XYZ,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxContainsPointFilter.#ctor(Autodesk.Revit.DB.XYZ,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements with a bounding box that contains the given point,
with the option to invert the filter and match all elements with a bounding box that do not contain the given point.

#### Parameter `point`

The point used to find elements with a bounding box containing it.

#### Parameter `inverted`

True if the filter should be inverted and match all elements with a bounding box that do not contain the given point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxContainsPointFilter.#ctor(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxContainsPointFilter.#ctor(Autodesk.Revit.DB.XYZ)`

#### Summary

Constructs a new instance of a filter to match elements with a bounding box that contains the given point.

#### Parameter `point`

The point used to find elements with a bounding box that contains it.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.BoundingBoxContainsPointFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.BoundingBoxContainsPointFilter`

#### Summary

A filter used to match elements with a bounding box that contains the given point.

#### Remarks

This filter excludes all objects derived from View and objects derived from ElementType.
This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxIsInsideFilter.GetBoundingBox`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxIsInsideFilter.GetBoundingBox`

#### Summary

Gets the outline being used for this filter.

#### Returns

The outline being used for this filter.

#### Since

2011

### `P:Autodesk.Revit.DB.BoundingBoxIsInsideFilter.Tolerance`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundingBoxIsInsideFilter.Tolerance`

#### Summary

Allows control over the match criteria by using a tolerance in the geometry comparison. It is suggested to use this in cases where trivial differences should be considered when matching elements.

#### Remarks

By default this is set to zero, but depending on your units of measure and how close objects may be, it is advised to set this to something more realistic.
If the tolerance is positive, the iterated element's Outline may extend the tolerance distance outside of the given Outline in each coordinate to be a match.
If the tolerance is negative, the iterated element's Outline must lie at least the tolerance distance inside the given Outline in each coordinate to be a match.

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxIsInsideFilter.#ctor(Autodesk.Revit.DB.Outline,System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxIsInsideFilter.#ctor(Autodesk.Revit.DB.Outline,System.Double,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements with a bounding box is contained by the given Outline,
with the option to invert the filter and match all elements with a bounding box that are not contained by the given Outline.

#### Parameter `outline`

The Outline used to find elements with a bounding box that are contained by it.

#### Parameter `tolerance`

The tolerance value to use instead of zero. See the tolerance property for details.

#### Parameter `inverted`

True if the filter should be inverted and match all elements with a bounding box that are not contained by the given Outline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

outline is an empty Outline.
-or-
The given value for tolerance is not finite
-or-
The given value for tolerance is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxIsInsideFilter.#ctor(Autodesk.Revit.DB.Outline,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxIsInsideFilter.#ctor(Autodesk.Revit.DB.Outline,System.Double)`

#### Summary

Constructs a new instance of a filter to match elements with a bounding box that is contained by the given Outline.

#### Parameter `outline`

The Outline used to find elements with a bounding box that are contained by it.

#### Parameter `tolerance`

The tolerance value to use instead of zero. See the tolerance property for details.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

outline is an empty Outline.
-or-
The given value for tolerance is not finite
-or-
The given value for tolerance is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxIsInsideFilter.#ctor(Autodesk.Revit.DB.Outline,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxIsInsideFilter.#ctor(Autodesk.Revit.DB.Outline,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements with a bounding box is contained by the given Outline,
with the option to invert the filter and match all elements with a bounding box that are not contained by the given Outline.

#### Parameter `outline`

The Outline used to find elements with a bounding box that are contained by it.

#### Parameter `inverted`

True if the filter should be inverted and match all elements with a bounding box that are not contained by the given Outline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

outline is an empty Outline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxIsInsideFilter.#ctor(Autodesk.Revit.DB.Outline)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxIsInsideFilter.#ctor(Autodesk.Revit.DB.Outline)`

#### Summary

Constructs a new instance of a filter to match elements with a bounding box that is contained by the given Outline.

#### Parameter `outline`

The Outline used to find elements with a bounding box that are contained by it.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

outline is an empty Outline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `T:Autodesk.Revit.DB.BoundingBoxIsInsideFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.BoundingBoxIsInsideFilter`

#### Summary

A filter used to match elements with a bounding box that is contained by the given Outline.

#### Remarks

This filter excludes all objects derived from View and objects derived from ElementType.
This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxIntersectsFilter.GetBoundingBox`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxIntersectsFilter.GetBoundingBox`

#### Summary

Gets the outline being used for this filter.

#### Returns

The outline being used for this filter.

#### Since

2011

### `P:Autodesk.Revit.DB.BoundingBoxIntersectsFilter.Tolerance`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundingBoxIntersectsFilter.Tolerance`

#### Summary

Allows control over the match criteria by using a tolerance in the geometry comparison. It is suggested to use this in cases where trivial differences should be considered when matching elements.

#### Remarks

By default this is set to zero, but depending on your units of measure and how close objects may be, it is advised to set this to something more realistic.
If the tolerance is positive, the outlines may be separated by the tolerance distance in each coordinate.
If the tolerance is negative, the outlines must overlap by at least the tolerance distance in each coordinate.

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxIntersectsFilter.#ctor(Autodesk.Revit.DB.Outline,System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxIntersectsFilter.#ctor(Autodesk.Revit.DB.Outline,System.Double,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements with a bounding box that intersects the given Outline,
with the option to invert the filter and match all elements with a bounding box that are not intersecting the given Outline.

#### Parameter `outline`

The Outline used to find elements with a bounding box that intersect it.

#### Parameter `tolerance`

The tolerance value to use instead of zero. See the tolerance property for details.

#### Parameter `inverted`

True if the filter should be inverted and match all elements with a bounding box that are not intersecting the given Outline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

outline is an empty Outline.
-or-
The given value for tolerance is not finite
-or-
The given value for tolerance is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxIntersectsFilter.#ctor(Autodesk.Revit.DB.Outline,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxIntersectsFilter.#ctor(Autodesk.Revit.DB.Outline,System.Double)`

#### Summary

Constructs a new instance of a filter to match elements with a bounding box that intersects the given Outline.

#### Parameter `outline`

The Outline used to find elements with a bounding box that intersect it.

#### Parameter `tolerance`

The tolerance value to use instead of zero. See the tolerance property for details.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

outline is an empty Outline.
-or-
The given value for tolerance is not finite
-or-
The given value for tolerance is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxIntersectsFilter.#ctor(Autodesk.Revit.DB.Outline,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxIntersectsFilter.#ctor(Autodesk.Revit.DB.Outline,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements with a bounding box that intersects the given Outline,
with the option to invert the filter and match all elements with a bounding box that are not intersecting the given Outline.

#### Parameter `outline`

The Outline used to find elements with a bounding box that intersect it.

#### Parameter `inverted`

True if the filter should be inverted and match all elements with a bounding box that are not intersecting the given Outline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

outline is an empty Outline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.BoundingBoxIntersectsFilter.#ctor(Autodesk.Revit.DB.Outline)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxIntersectsFilter.#ctor(Autodesk.Revit.DB.Outline)`

#### Summary

Constructs a new instance of a filter to match elements with a bounding box that intersects the given Outline.

#### Parameter `outline`

The Outline used to find elements with a bounding box that intersect it.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

outline is an empty Outline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `T:Autodesk.Revit.DB.BoundingBoxIntersectsFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.BoundingBoxIntersectsFilter`

#### Summary

A filter used to match elements with a bounding box that intersects the given Outline.

#### Remarks

This filter excludes all objects derived from View and objects derived from ElementType.
This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementIsCurveDrivenFilter.#ctor(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIsCurveDrivenFilter.#ctor(System.Boolean)`

#### Summary

Constructs a new instance of a filter to match only curve driven elements, with the option to match all elements which are not curve driven elements.

#### Remarks

The term "curve driven" indicates that the element's Location property is a LocationCurve.
Example elements found by this filter include walls, beams, and curve elements.

#### Parameter `inverted`

True if the filter should match all elements which are not curve driven elements.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementIsCurveDrivenFilter.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIsCurveDrivenFilter.#ctor`

#### Summary

Constructs a new instance of a filter to match only curve driven elements.

#### Remarks

The term "curve driven" indicates that the element's Location property is a LocationCurve.
Example elements found by this filter include walls, beams, and curve elements.

#### Since

2011

### `T:Autodesk.Revit.DB.ElementIsCurveDrivenFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementIsCurveDrivenFilter`

#### Summary

A filter used to match elements which are curve driven.

#### Remarks

The term "curve driven" indicates that the element's Location property is a LocationCurve.
Example elements found by this filter include walls, beams, and curve elements.

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2011

### `P:Autodesk.Revit.DB.ElementDesignOptionFilter.DesignOptionId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementDesignOptionFilter.DesignOptionId`

#### Summary

The design option id.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementDesignOptionFilter.#ctor(Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementDesignOptionFilter.#ctor(Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements contained within a particular design option, with the option to invert the filter and find elements not contained within a particular design option.

#### Parameter `designOptionId`

The design option id to match.

#### Parameter `inverted`

True if the filter should match all elements which are not contained within a particular design option.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ElementDesignOptionFilter.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementDesignOptionFilter.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a new instance of a filter to match elements contained within a particular design option.

#### Parameter `designOptionId`

The design option id to match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.ElementDesignOptionFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementDesignOptionFilter`

#### Summary

A filter used to find elements contained within a particular design option.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2011

### `P:Autodesk.Revit.DB.ElementOwnerViewFilter.ViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementOwnerViewFilter.ViewId`

#### Summary

The view id.

### `M:Autodesk.Revit.DB.ElementOwnerViewFilter.#ctor(Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementOwnerViewFilter.#ctor(Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements which are owned by a particular view,
with the option to invert the filter and find elements not owned by the given view.

#### Parameter `viewId`

The view id to match.
Pass invalid element id to create a filter that will pass non-view-specific elements.

#### Parameter `inverted`

True if the filter should match all elements which are not owned by the given view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ElementOwnerViewFilter.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementOwnerViewFilter.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a new instance of a filter to match elements which are owned by a particular view.

#### Parameter `viewId`

The view id to match.
Pass invalid element id to create a filter that will pass non-view-specific elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.ElementOwnerViewFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementOwnerViewFilter`

#### Summary

A filter used to match elements which are owned by a particular view.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

### `M:Autodesk.Revit.DB.ElementIsElementTypeFilter.#ctor(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIsElementTypeFilter.#ctor(System.Boolean)`

#### Summary

Constructs a new instance of a filter to match only ElementTypes, with the option to match all elements which are not ElementTypes.

#### Parameter `inverted`

True if the filter should match all elements which are not ElementTypes.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementIsElementTypeFilter.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIsElementTypeFilter.#ctor`

#### Summary

Constructs a new instance of a filter to match only ElementTypes.

#### Since

2011

### `T:Autodesk.Revit.DB.ElementIsElementTypeFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementIsElementTypeFilter`

#### Summary

A filter used to match elements which are ElementTypes.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementClassFilter.GetElementClass`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementClassFilter.GetElementClass`

#### Summary

The class for the filter.

#### Returns

The class.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementClassFilter.#ctor(System.Type,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementClassFilter.#ctor(System.Type,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements by class, with the option to match all elements which are not of the given class.

#### Parameter `type`

The type to match.

#### Parameter `inverted`

True if the filter should match all elements which are not of the given class.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input type is not a subclass of Element.
-or-
The input type is of an element class that exists in the API, but not in Revit's native object model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ElementClassFilter.#ctor(System.Type)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementClassFilter.#ctor(System.Type)`

#### Summary

Constructs a new instance of a filter to match elements by class.

#### Parameter `type`

The type to match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input type is not a subclass of Element.
-or-
The input type is of an element class that exists in the API, but not in Revit's native object model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.ElementClassFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementClassFilter`

#### Summary

A filter used to match elements by their class.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

This filter will match elements whose class is an exact match to the input class,
or elements whose class is derived from the input class.

There is a small subset of Element subclasses in the API which are not supported
by this filter. These types exist in the API, but not in Revit's native object model,
which means that this filter doesn't support them. In order to use a class filter to
find elements of these types, it is necessary to use a higher level class and then
process the results further to find elements matching only the subtype. The following
types are affected by this restriction:
Subclasses of Autodesk.Revit.DB.Material

Subclasses of Autodesk.Revit.DB.CurveElement

Subclasses of Autodesk.Revit.DB.ConnectorElement

Subclasses of Autodesk.Revit.DB.HostedSweep

Autodesk.Revit.DB.Architecture.Room

Autodesk.Revit.DB.Mechanical.Space

Autodesk.Revit.DB.Area

Autodesk.Revit.DB.Architecture.RoomTag

Autodesk.Revit.DB.Mechanical.SpaceTag

Autodesk.Revit.DB.AreaTag

Autodesk.Revit.DB.CombinableElement

Autodesk.Revit.DB.Mullion

Autodesk.Revit.DB.Panel

Autodesk.Revit.DB.AnnotationSymbol

Autodesk.Revit.DB.Structure.AreaReinforcementType

Autodesk.Revit.DB.Structure.PathReinforcementType

Autodesk.Revit.DB.AnnotationSymbolType

Autodesk.Revit.DB.Architecture.RoomTagType

Autodesk.Revit.DB.Mechanical.SpaceTagType

Autodesk.Revit.DB.AreaTagType

Autodesk.Revit.DB.Structure.TrussType

#### Since

2011

### `M:Autodesk.Revit.DB.ElementMulticlassFilter.#ctor(System.Collections.Generic.IList{System.Type},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementMulticlassFilter.#ctor(System.Collections.Generic.IList{System.Type},System.Boolean)`

#### Summary

Constructs a new instance of a filter to find elements whose Element subclasses matches any of a given set of input classes, with an option to instead match
elements whose Element subclass does not match the list of input classes.

#### Parameter `typeList`

The list of Element subclass types to match.

#### Parameter `inverted`

True if the filter should match all elements which are not of the given Element subclass.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more input types are not valid subclasses of Element for this filter.
-or-
One or more of the types do not exist in Revit's native object model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ElementMulticlassFilter.#ctor(System.Collections.Generic.IList{System.Type})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementMulticlassFilter.#ctor(System.Collections.Generic.IList{System.Type})`

#### Summary

Constructs a new instance of a filter to find elements whose Element subclasses matches any of a given set of input classes.

#### Parameter `typeList`

The list of Element subclass types to match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more input types are not valid subclasses of Element for this filter.
-or-
One or more of the types do not exist in Revit's native object model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.ElementMulticlassFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementMulticlassFilter`

#### Summary

A filter used to match elements by their class, where more than one class of element may be passed.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

Only elements whose class is an exact match to one of the input classes,
or elements whose type is derived from the input class will pass the collector.

There is a small subset of Element subclasses in the API that are not supported
by this filter. These classes exist in the API, but not in Revit's native object model,
which means that this filter doesn't support them. In order to use a class filter to
find elements of these types, it is necessary to use a higher level class and then
process the results further to find elements matching only the subclass. For a list
of subclasses affected by this restriction, consult the documentation for `!:Autodesk::Revit::DB::ElementClassFilter` .

#### Since

2012

### `M:Autodesk.Revit.DB.ElementMulticategoryFilter.GetCategoryIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementMulticategoryFilter.GetCategoryIds`

#### Summary

Gets the category ids assigned to this filter.

#### Returns

The category ids.

#### Since

2012

### `M:Autodesk.Revit.DB.ElementMulticategoryFilter.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.BuiltInCategory},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementMulticategoryFilter.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.BuiltInCategory},System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements by built-in category, with the option to match all elements which are not of the given category.

#### Parameter `categories`

The built-in categories to match.

#### Parameter `inverted`

True if the filter should match all elements which are not of the given built-in categories.

### `M:Autodesk.Revit.DB.ElementMulticategoryFilter.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.BuiltInCategory})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementMulticategoryFilter.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.BuiltInCategory})`

#### Summary

Constructs a new instance of a filter to match elements by built-in category.

#### Parameter `categories`

The built-in categories to match.

### `M:Autodesk.Revit.DB.ElementMulticategoryFilter.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementMulticategoryFilter.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Boolean)`

#### Summary

Constructs a new instance of a filter to find elements whose category matches any of a given set of categories, with the option to instead match elements which are not of the given categories.

#### Parameter `categoryIds`

The category ids to match.

#### Parameter `inverted`

True if the filter should match all elements which are not of the given categories.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more categories was not valid for filtering.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ElementMulticategoryFilter.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementMulticategoryFilter.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Constructs a new instance of a filter to find elements whose category matches any of a given set of categories.

#### Parameter `categoryIds`

The category ids to match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more categories was not valid for filtering.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.ElementMulticategoryFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementMulticategoryFilter`

#### Summary

A filter used to find elements whose category matches any of a given set of categories.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2012

### `P:Autodesk.Revit.DB.ElementCategoryFilter.CategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementCategoryFilter.CategoryId`

#### Summary

The category id.

#### Since

2011

### `M:Autodesk.Revit.DB.ElementCategoryFilter.#ctor(Autodesk.Revit.DB.BuiltInCategory,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementCategoryFilter.#ctor(Autodesk.Revit.DB.BuiltInCategory,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements by category, with the option to match all elements which are not of the given category.

#### Parameter `category`

The category to match.

#### Parameter `inverted`

True if the filter should match all elements which are not of the given category.

### `M:Autodesk.Revit.DB.ElementCategoryFilter.#ctor(Autodesk.Revit.DB.BuiltInCategory)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementCategoryFilter.#ctor(Autodesk.Revit.DB.BuiltInCategory)`

#### Summary

Constructs a new instance of a filter to match elements by category.

#### Parameter `category`

The category to match.

### `M:Autodesk.Revit.DB.ElementCategoryFilter.#ctor(Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementCategoryFilter.#ctor(Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements by category, with the option to match all elements which are of the given category.

#### Parameter `categoryId`

The category id to match.

#### Parameter `inverted`

True if the filter should match all elements which are not of the given category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The category was not valid for filtering.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.ElementCategoryFilter.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementCategoryFilter.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a new instance of a filter to match elements by category.

#### Parameter `categoryId`

The category id to match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The category was not valid for filtering.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.ElementCategoryFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementCategoryFilter`

#### Summary

A filter used to match elements by their category.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2011

### `P:Autodesk.Revit.DB.ElementWorksetFilter.WorksetId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementWorksetFilter.WorksetId`

#### Summary

The workset id.

#### Since

2012

### `M:Autodesk.Revit.DB.ElementWorksetFilter.#ctor(Autodesk.Revit.DB.WorksetId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementWorksetFilter.#ctor(Autodesk.Revit.DB.WorksetId,System.Boolean)`

#### Summary

Constructs a new instance of a filter to match elements in a given workset.

#### Parameter `worksetId`

The workset id to match.

#### Parameter `inverted`

True if the filter should match all elements which are not in the given workset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ElementWorksetFilter.#ctor(Autodesk.Revit.DB.WorksetId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementWorksetFilter.#ctor(Autodesk.Revit.DB.WorksetId)`

#### Summary

Constructs a new instance of a filter to match elements in a given workset.

#### Parameter `worksetId`

The workset id to match.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.ElementWorksetFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementWorksetFilter`

#### Summary

A filter used to match elements which reside in a given workset.

#### Remarks

This filter is a quick filter.

#### Since

2012

### `M:Autodesk.Revit.DB.ElementIdSetFilter.GetIdsToInclude`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIdSetFilter.GetIdsToInclude`

#### Summary

Returns the ids of this filter.

#### Returns

The collection of ids.

#### Since

2021

### `M:Autodesk.Revit.DB.ElementIdSetFilter.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIdSetFilter.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Constructs a new instance of a filter wrapping a set of elements.

#### Parameter `idsToInclude`

The ids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input collection of ids was empty, or its contents were not valid for iteration.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `T:Autodesk.Revit.DB.ElementIdSetFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementIdSetFilter`

#### Summary

A filter wrapping a set of elements.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2021

### `M:Autodesk.Revit.DB.ExclusionFilter.GetIdsToExclude`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExclusionFilter.GetIdsToExclude`

#### Summary

Returns the ids to be excluded by this filter.

#### Returns

The collection of ids to exclude.

#### Since

2011

### `M:Autodesk.Revit.DB.ExclusionFilter.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExclusionFilter.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Constructs a new instance of a filter to exclude elements automatically.

#### Parameter `idsToExclude`

The ids to exclude from the results.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input collection of ids was empty, or its contents were not valid for iteration.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.ExclusionFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExclusionFilter`

#### Summary

A filter used to exclude a set of elements automatically.

#### Remarks

This filter is a quick filter.
Quick filters operate only on the ElementRecord, a low-memory class which has
a limited interface to read element properties. Elements which are rejected
by a quick filter will not be expanded in memory.

#### Since

2011

### `M:Autodesk.Revit.DB.BuildingPadType.CreateDefault(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BuildingPadType.CreateDefault(Autodesk.Revit.DB.Document)`

#### Summary

Creates a BuildingPadType element and adds it to the document.

#### Remarks

The default BuildiPadType adopts the value of 1.0 for the paremeter of thickness.
If there is no BuildingPadType existing, will create a new one; otherwise, an exception will be thrown.

#### Parameter `document`

The document to be modified.

#### Returns

The new BuildingPadType element.

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

### `P:Autodesk.Revit.DB.BuildingPadType.ThermalProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuildingPadType.ThermalProperties`

#### Summary

The calculated and settable thermal properties of the BuildingPadType

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

the building pad does not have thermal properties.

#### Since

2013

### `T:Autodesk.Revit.DB.BuildingPadType`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuildingPadType`

#### Summary

Represents a specific type of Building Pad.

### `M:Autodesk.Revit.DB.Architecture.BuildingPad.SetBoundary(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.BuildingPad.SetBoundary(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Set a given curve loops as the boundary of the current BuildingPad element.

#### Parameter `curveLoops`

A collection of curve loops to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve loops cannot compose a valid boundary, that means:
no curve loop is contained in the given collection;
these curve loops intersect with each other for some of them;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the horizontal(XY) plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the Sketch for the boundary of current BuildingPad.
-or-
Cannot find an appropriate hosting topography surface for this BuildingPad.
-or-
This topography surface cannot be the host of this BuildingPad.
-or-
The given curve loops intersect with curve loops of existing BuildingPads hosted on the same TopographySurface.
-or-
There is at least one existing SubRegion which is completely inside or overlap the boundary of current BuildingPad hosted on the same TopographySurface. This behavior is not allowed.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing this BuildingPad is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing this BuildingPad is being loaded, or is in the midst of another

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing this BuildingPad has no open transaction.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.BuildingPad.GetBoundary`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.BuildingPad.GetBoundary`

#### Summary

Gets the boundary of current BuildingPad element.

#### Returns

The curve loops that represent the boundary of the BuildingPad.

#### Since

2014

### `M:Autodesk.Revit.DB.Architecture.BuildingPad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.BuildingPad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Creates a new BuildingPad element and adds it to the document.

#### Remarks

The document will be regenerated during the creation of building pad element.
If the input curve loops intersect the curve loops of existing BuildingPads hosted on the same topography surface,
an InvalidOperationException will be thrown.
If you need access to the topography surface created by the introduction of this building pad, you can obtain it from
`P:Autodesk.Revit.DB.Architecture.BuildingPad.AssociatedTopographySurfaceId` .

#### Parameter `document`

The document to be modified.

#### Parameter `buildingPadTypeId`

The type id set to the BuildingPad.

#### Parameter `levelId`

The level id set to the BuildingPad.

#### Parameter `curveLoops`

The boundary of the BuildingPad.

#### Returns

The new BuildingPad element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The buildingPadTypeId is not a valid type id for a BuildingPad.
-or-
The ElementId levelId is not a Level.
-or-
The input curve loops cannot compose a valid boundary, that means:
no curve loop is contained in the given collection;
these curve loops intersect with each other for some of them;
or each curve loop is not closed individually;
or each curve loop is not planar;
or each curve loop is not in a plane parallel to the horizontal(XY) plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the Sketch for the boundary of new created BuildingPad.
-or-
Cannot find an appropriate hosting topography surface for this BuildingPad.
-or-
This topography surface cannot be the host of this BuildingPad.
-or-
The given curve loops intersect with curve loops of existing BuildingPads hosted on the same TopographySurface.
-or-
There is at least one existing SubRegion which is completely inside or overlap the boundary of current BuildingPad hosted on the same TopographySurface. This behavior is not allowed.

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

### `P:Autodesk.Revit.DB.Architecture.BuildingPad.AssociatedTopographySurfaceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BuildingPad.AssociatedTopographySurfaceId`

#### Summary

The element id of a topography surface created by the introduction of this building pad.

#### Since

2015

### `P:Autodesk.Revit.DB.Architecture.BuildingPad.HostId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BuildingPad.HostId`

#### Summary

The element id of the topography surface hosting this BuidlingPad.

#### Since

2014

### `T:Autodesk.Revit.DB.Architecture.BuildingPad`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.BuildingPad`

#### Summary

Represents a BuildingPad element.

#### Since

2014

### `M:Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer.GetCenterPointsForConnectedGridCellsInSpaceVolume(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer.GetCenterPointsForConnectedGridCellsInSpaceVolume(System.Int32)`

#### Summary

Returns the collection of connected cells in an enclosed space volume.

#### Remarks

This method requires the building envelope analyzer method created with
the option set to compute enclosed space volumes.

#### Returns

The center points for the connected analytical grid cells in the enclosed space volume.

#### Since

2015

### `M:Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer.GetBoundingElementsForSpaceVolume(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer.GetBoundingElementsForSpaceVolume(System.Int32)`

#### Summary

Returns the collection of bounding building elements for an enclosed space volume.

#### Remarks

This method requires the building envelope analyzer method created with
the option set to compute enclosed space volumes.

#### Returns

The ids of the bounding building elements for the enclosed space volume.

#### Since

2015

### `M:Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer.GetBoundingElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer.GetBoundingElements`

#### Summary

Returns the collection of building elements exposed to the outside forming the building envelope.

#### Returns

The ids of the building elements in the envelope.

#### Since

2015

### `M:Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions)`

#### Summary

Creates a new analyzer.

#### Parameter `document`

The document that contains the physical model of the building.

#### Parameter `options`

Options for the method analyzing the building elements for the building envelope.

#### Returns

The created analyzer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer`

#### Summary

Analyzes which elements are part of the building envelope, the building elements exposed to the outside.

#### Remarks

This class uses a combination of ray-casting and flood-fill
algorithms in order to find the building elements that are
exposed to the outside of the building.
This method can also look for the bounding building elements for
enclosed space volumes inside the building.

#### Since

2015

### `P:Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions.GridCellSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions.GridCellSize`

#### Summary

The cell size for the uniform cubical grid used when analyzing the building envelope.

#### Remarks

This is the base size of the "cubes" used to divide the building shell
bounding box into a uniform cubical 3D grid. If this overrideGridCellSize option is set,
this exact value will be used for the grid cell size. The cell size should be specified in
the length unit for the Revit project.

#### Since

2015

### `P:Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions.OptimizeGridCellSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions.OptimizeGridCellSize`

#### Summary

Whether or not to use the exact value for the cell size or let the analyzer optimize the cell size based on the specified grid size

#### Remarks

If this option is true, the analyzer will decide the optimal cell size for the uniform cubical grid used
when computing the building envelope. The optimal cell size is based on the specified cell size,
but can be higher. If this option is false, the exact specified grid cell size will be used.

#### Since

2015

### `P:Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions.AnalyzeEnclosedSpaceVolumes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions.AnalyzeEnclosedSpaceVolumes`

#### Summary

Whether or not to analyze interior connected regions inside the building forming enclosed space volumes.

#### Remarks

If true, the analyzer will also look for bounding building elements and
connected analytical grid cells for enclosed space volumes inside the building.

#### Since

2015

### `M:Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions.#ctor`

#### Summary

Constructs a new instance of BuildingEnvelopeAnalyzerOptions, using default values.

#### Since

2015

### `T:Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions`

#### Summary

Specific options for the method analyzing the building elements for the building envelope.

#### Remarks

The analyze method uses a combination of ray-casting and flood-fill
algorithms in order to find the building elements that are
exposed to the outside of the building.
The analyze method can also look for the bounding building elements for
enclosed space volumes inside the building.

#### Since

2015

### `M:Autodesk.Revit.DB.BrowserOrganization.GetCurrentBrowserOrganizationForSchedules(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BrowserOrganization.GetCurrentBrowserOrganizationForSchedules(Autodesk.Revit.DB.Document)`

#### Summary

Gets the `T:Autodesk.Revit.DB.BrowserOrganization` that applies to the Schedules section of the project browser.

#### Parameter `document`

Revit document from which to get the organization data.

#### Returns

The BrowserOrganization for schedules, or null if no schedules sections exist

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018.1

### `M:Autodesk.Revit.DB.BrowserOrganization.GetCurrentBrowserOrganizationForSheets(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BrowserOrganization.GetCurrentBrowserOrganizationForSheets(Autodesk.Revit.DB.Document)`

#### Summary

Gets the `T:Autodesk.Revit.DB.BrowserOrganization` that applies to the Sheets section of the project browser.

#### Parameter `document`

Revit document from which to get the organization data.

#### Returns

The BrowserOrganization for sheets, or null if no sheets exist.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.BrowserOrganization.GetCurrentBrowserOrganizationForViews(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BrowserOrganization.GetCurrentBrowserOrganizationForViews(Autodesk.Revit.DB.Document)`

#### Summary

Gets the `T:Autodesk.Revit.DB.BrowserOrganization` that applies to the Views section of the project browser.

#### Parameter `document`

Revit document from which to get the organization data.

#### Returns

The BrowserOrganization for views, or null if no view sections exist

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.BrowserOrganization.GetFolderItems(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BrowserOrganization.GetFolderItems(Autodesk.Revit.DB.ElementId)`

#### Summary

Returns a collection of leaf `T:Autodesk.Revit.DB.FolderItemInfo` objects each containing the given element Id.

#### Remarks

Each returned `T:Autodesk.Revit.DB.FolderItemInfo` includes the folder name and the corresponding folder parameter Id.

#### Parameter `elementId`

Element id located at a leaf position in the project browser.

#### Returns

An array of FolderItemInfo objects.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

elementId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.BrowserOrganization.AreFiltersSatisfied(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BrowserOrganization.AreFiltersSatisfied(Autodesk.Revit.DB.ElementId)`

#### Summary

Determines if the given element satisfies the filters defined by the browser organization.

#### Parameter `elementId`

The element to check.

#### Returns

True if the given element satisfies the filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

elementId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.BrowserOrganization.SortingOrder`

Member kind: property
Symbol: `Autodesk.Revit.DB.BrowserOrganization.SortingOrder`

#### Summary

The sorting order if sorting of items is applicable in the browser.

#### Since

2015

### `P:Autodesk.Revit.DB.BrowserOrganization.Type`

Member kind: property
Symbol: `Autodesk.Revit.DB.BrowserOrganization.Type`

#### Summary

Get BrowserOrganizationType.

#### Since

2023

### `P:Autodesk.Revit.DB.BrowserOrganization.SortingParameterId`

Member kind: property
Symbol: `Autodesk.Revit.DB.BrowserOrganization.SortingParameterId`

#### Summary

The Id of the parameter used to determine the sorting order of items in the browser.

#### Since

2015

### `T:Autodesk.Revit.DB.BrowserOrganization`

Member kind: type
Symbol: `Autodesk.Revit.DB.BrowserOrganization`

#### Summary

The organization settings for grouping, sorting, and filtering of items in the project browser.

#### Since

2015

### `P:Autodesk.Revit.DB.FolderItemInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FolderItemInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FolderItemInfo.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.FolderItemInfo.Name`

#### Summary

The folder name

#### Since

2015

### `P:Autodesk.Revit.DB.FolderItemInfo.ElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.FolderItemInfo.ElementId`

#### Summary

The folder parameter Id

#### Since

2015

### `T:Autodesk.Revit.DB.FolderItemInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.FolderItemInfo`

#### Summary

Contains data for each folder item in the organization settings of the project browser including folder parameter Id and folder name.

#### Remarks

FolderItemInfo is the return value of BrowserOrganization.GetFolderItems().

#### Since

2015

### `T:Autodesk.Revit.DB.BrowserOrganizationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.BrowserOrganizationType`

#### Summary

Enumerated type representing the type of browser organization.

#### Since

2015

#### Since

2015

### `F:Autodesk.Revit.DB.BrowserOrganizationType.Schedules`

Member kind: field
Symbol: `Autodesk.Revit.DB.BrowserOrganizationType.Schedules`

#### Summary

The browser organization definition for schedules.

### `F:Autodesk.Revit.DB.BrowserOrganizationType.Sheets`

Member kind: field
Symbol: `Autodesk.Revit.DB.BrowserOrganizationType.Sheets`

#### Summary

The browser organization definition for sheets.

### `F:Autodesk.Revit.DB.BrowserOrganizationType.Views`

Member kind: field
Symbol: `Autodesk.Revit.DB.BrowserOrganizationType.Views`

#### Summary

The browser organization definition for views.

### `T:Autodesk.Revit.DB.SortingOrder`

Member kind: type
Symbol: `Autodesk.Revit.DB.SortingOrder`

#### Summary

Enumerated type representing the sorting order of a collection of objects.

#### Since

2015

### `F:Autodesk.Revit.DB.SortingOrder.Descending`

Member kind: field
Symbol: `Autodesk.Revit.DB.SortingOrder.Descending`

#### Summary

Descending sorting order

### `F:Autodesk.Revit.DB.SortingOrder.Ascending`

Member kind: field
Symbol: `Autodesk.Revit.DB.SortingOrder.Ascending`

#### Summary

Ascending sorting order

### `M:Autodesk.Revit.DB.BoundaryValidation.IsValidBoundaryOnSketchPlane(Autodesk.Revit.DB.SketchPlane,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundaryValidation.IsValidBoundaryOnSketchPlane(Autodesk.Revit.DB.SketchPlane,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Indicates if the given curve loops compose a valid boundary on the sketch plane.

#### Remarks

The curve loops are valid if projections of the loops onto the sketch plane do not intersect each other;
each curve loop is closed; input curves do not contain any helical curve;
and each loop is planar and lies on a plane parallel to the sketch plane, but not necessarily the same plane.

#### Parameter `sketchPlane`

The sketch plane.

#### Parameter `curveLoops`

The curve loops to be checked.

#### Returns

True if the given curve loops are valid as described above, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.BoundaryValidation.IsValidBoundaryOnView(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundaryValidation.IsValidBoundaryOnView(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Indicates if the given curve loops compose a valid boundary on the view's detail sketch plane.

#### Remarks

The curve loops are valid if projections of the loops onto the views's detail sketch plane do not intersect each other;
each curve loop is closed; input curves do not contain any helical curve;
and each loop is planar and lies on a plane parallel to the views's detail sketch plane, but not necessarily the same plane.

#### Parameter `document`

The document.

#### Parameter `viewId`

The view Id.

#### Parameter `curveLoops`

The curve loops to be checked.

#### Returns

True if the given curve loops are valid as described above, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.BoundaryValidation.IsValidHorizontalBoundary(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundaryValidation.IsValidHorizontalBoundary(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Identifies whether the given curve loops compose a valid horizontal boundary.

#### Remarks

The curve loops are valid if projections of the loops onto a horizontal(XY) plane do not intersect each other;
each curve loop is closed; input curves do not contain any helical curve;
and each loop is planar and lies on a plane parallel to the horizontal(XY) plane, but not necessarily the same plane.

#### Parameter `curveLoops`

The curve loops to be checked.

#### Returns

True if the given curve loops are valid as described above, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.BoundaryValidation.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundaryValidation.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.BoundaryValidation`

Member kind: type
Symbol: `Autodesk.Revit.DB.BoundaryValidation`

#### Summary

Curve loop validators.

#### Since

2022

### `P:Autodesk.Revit.DB.ValidateCurveLoopsOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ValidateCurveLoopsOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ValidateCurveLoopsOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ValidateCurveLoopsOptions`

#### Summary

Options for array of curve loops validation.

#### Since

2022

### `M:Autodesk.Revit.DB.GeometryCreationUtilities.CreateFixedReferenceSweptGeometry(Autodesk.Revit.DB.CurveLoop,System.Int32,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.SolidOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities.CreateFixedReferenceSweptGeometry(Autodesk.Revit.DB.CurveLoop,System.Int32,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.SolidOptions)`

#### Summary

Creates a solid by sweeping one or more closed coplanar curve loops along a path while keeping the
profile plane oriented so that a line in the plane that is initially perpendicular to a given fixed
direction remains perpendicular as the profile is swept along the path.

#### Remarks

The profile loops must lie in a plane orthogonal to the sweep path at some attachment point along the path.
An example where this method is useful is in constructing railings. If the fixed direction is the upward
vertical, a line in the profile plane that is initially horizontal will remain horizontal as the profile
is swept along the path. This property can be used to ensure that the top of the railing remains horizontal
all along the railing.

The STEP ISO 10303-42 and IFC standards define a "Fixed Reference Sweep" similar to this sweep method, though
there are some minor technical differences:
The STEP ISO reference describes a specific parameterization of the swept surface, whereas we do not guarantee any particular parameterization (partly because we simplify the surface when possible).

Neither reference mentions what should be done if the sweep pathâ€™s tangent is tangent to the reference direction at some point(s) or along the entire directrix.

Both references impose unnecessary conditions, and they're inconsistent: STEP says "the swept_curve is required to be a curve lying in the plane z = 0" while IFC says "The SweptArea shall lie in the plane z = 0" (SweptArea is the profile being swept).

#### Parameter `sweepPath`

The sweep path, consisting of a set of contiguous curves. The path may be open or closed,
but should not otherwise have any self-intersections. The path may be planar or non-planar.
With the exception of path curves that lie in a plane parallel to %fixedReferenceDirection%,
the curve's tangent should be nowhere parallel to %fixedReferenceDirection%. If the sweep path
has corners, the solid segments that meet at a corner may not meet smoothly.

#### Parameter `pathAttachmentCrvIdx`

The index of the curve in the sweep path where the profile loops are situated.
Indexing starts at 0. Together with pathAttachmentParam, this specifies the profile's attachment point.

#### Parameter `pathAttachmentParam`

Parameter of the path curve specified by pathAttachmentCrvIdx.
The profile curves must lie in the plane orthogonal to the path at this attachment point.

#### Parameter `profileLoops`

The curve loops defining the planar domain to be swept along the path.
No conditions are imposed on the orientations of the loops; this function will use copies of the input loops
that have been oriented as necessary to conform to Revit's orientation conventions.
Restrictions:
The loops must lie in the plane orthogonal to the path at the attachment point as defined above.

The curve loop(s) must be closed and should define a single planar domain (one outer loop and, optionally, one or more inner loops).

The curve loops must be without intersections, self-intersections, or degeneracies.

No loop may contain just one closed curve - split such loops into two or more curves beforehand.

#### Parameter `fixedReferenceDirection`

A unit vector specifying the fixed direction used to control how the profile plane is swept along the path; see the description and remarks above.
The profile CurveLoops do not satisfy the input requirements.

#### Parameter `solidOptions`

The optional information to control the properties of the Solid.

#### Returns

The requested solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input argument sweepPath should at least contain one curve.
-or-
The input argument pathAttachmentCrvIdx is not valid.
-or-

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

fixedReferenceDirection is not length 1.0.

#### Since

2017

### `M:Autodesk.Revit.DB.GeometryCreationUtilities.CreateFixedReferenceSweptGeometry(Autodesk.Revit.DB.CurveLoop,System.Int32,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities.CreateFixedReferenceSweptGeometry(Autodesk.Revit.DB.CurveLoop,System.Int32,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a solid by sweeping one or more closed coplanar curve loops along a path while keeping the
profile plane oriented so that a line in the plane that is initially perpendicular to a given fixed
direction remains perpendicular as the profile is swept along the path.

#### Remarks

The profile loops must lie in a plane orthogonal to the sweep path at some attachment point along the path.
An example where this method is useful is in constructing railings. If the fixed direction is the upward
vertical, a line in the profile plane that is initially horizontal will remain horizontal as the profile
is swept along the path. This property can be used to ensure that the top of the railing remains horizontal
all along the railing.

The STEP ISO 10303-42 and IFC standards define a "Fixed Reference Sweep" similar to this sweep method, though
there are some minor technical differences:
The STEP ISO reference describes a specific parameterization of the swept surface, whereas we do not guarantee any particular parameterization (partly because we simplify the surface when possible).

Neither reference mentions what should be done if the sweep pathâ€™s tangent is tangent to the reference direction at some point(s) or along the entire directrix.

Both references impose unnecessary conditions, and they're inconsistent: STEP says "the swept_curve is required to be a curve lying in the plane z = 0" while IFC says "The SweptArea shall lie in the plane z = 0" (SweptArea is the profile being swept).

#### Parameter `sweepPath`

The sweep path, consisting of a set of contiguous curves. The path may be open or closed,
but should not otherwise have any self-intersections. The path may be planar or non-planar.
With the exception of path curves that lie in a plane parallel to %fixedReferenceDirection%,
the curve's tangent should be nowhere parallel to %fixedReferenceDirection%. If the sweep path
has corners, the solid segments that meet at a corner may not meet smoothly.

#### Parameter `pathAttachmentCrvIdx`

The index of the curve in the sweep path where the profile loops are situated.
Indexing starts at 0. Together with pathAttachmentParam, this specifies the profile's attachment point.

#### Parameter `pathAttachmentParam`

Parameter of the path curve specified by pathAttachmentCrvIdx.
The profile curves must lie in the plane orthogonal to the path at this attachment point.

#### Parameter `profileLoops`

The curve loops defining the planar domain to be swept along the path.
No conditions are imposed on the orientations of the loops; this function will use copies of the input loops
that have been oriented as necessary to conform to Revit's orientation conventions.
Restrictions:
The loops must lie in the plane orthogonal to the path at the attachment point as defined above.

The curve loop(s) must be closed and should define a single planar domain (one outer loop and, optionally, one or more inner loops).

The curve loops must be without intersections, self-intersections, or degeneracies.

No loop may contain just one closed curve - split such loops into two or more curves beforehand.

#### Parameter `fixedReferenceDirection`

A unit vector specifying the fixed direction used to control how the profile plane is swept along the path; see the description and remarks above.

#### Returns

The requested solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input argument sweepPath should at least contain one curve.
-or-
The input argument pathAttachmentCrvIdx is not valid.
-or-
The profile CurveLoops do not satisfy the input requirements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

fixedReferenceDirection is not length 1.0.

#### Since

2017

### `M:Autodesk.Revit.DB.GeometryCreationUtilities.CreateLoftGeometry(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.SolidOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities.CreateLoftGeometry(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.SolidOptions)`

#### Summary

Creates a solid or open shell geometry by lofting between a sequence of curve loops.

#### Remarks

If all the curve loops are closed it will create a solid. No loop may contain just one closed curve - split such loops into two or more curves beforehand.
If all the curve loops are open, then create an open shell.
If there are both open and closed loops, only the first and/or last loop are allowed to be open,
others (if they exist) must be closed. A solid will be created in this case.
The surface of the solid or open shell will pass through these profiles blending smoothly between the profiles.
Each profile loop must be free of intersections and degeneracies. No orientation conditions on the loops are imposed.

#### Parameter `profileLoops`

The array of curve loops, where the order of the array determines the lofting sequence used.

#### Parameter `solidOptions`

The optional information to control the properties of the solid or open shell.

#### Returns

The requested solid or open shell.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The number of profile CurveLoops is less than 2.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.GeometryCreationUtilities.CreateBlendGeometry(Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.CurveLoop,System.Collections.Generic.ICollection{Autodesk.Revit.DB.VertexPair},Autodesk.Revit.DB.SolidOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities.CreateBlendGeometry(Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.CurveLoop,System.Collections.Generic.ICollection{Autodesk.Revit.DB.VertexPair},Autodesk.Revit.DB.SolidOptions)`

#### Summary

Creates a solid by blending two closed curve loops lying in non-coincident planes.

#### Parameter `firstLoop`

The first curve loop. The loop must be a closed planar loop without intersections or degeneracies. No orientation conditions are imposed. The loop must be a closed planar loop without intersections or degeneracies. No orientation conditions are imposed. The loop may not contain just one closed curve - split such a loop into two or more curves beforehand.

#### Parameter `secondLoop`

The second curve loop, satisfying the same conditions as the first loop.
The planes of the first and second loops must not be coincident, but they need not be parallel.

#### Parameter `vertexPairs`

This input specifies how the two profile loops should be connected.
If null, the function chooses vertex connections that will result in a geometrically reasonable blend.

#### Parameter `solidOptions`

The optional information to control the properties of the Solid.

#### Returns

The requested solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The first profile CurveLoop do not satisfy the input requirements.
-or-
The second profile CurveLoop do not satisfy the input requirements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.GeometryCreationUtilities.CreateSweptBlendGeometry(Autodesk.Revit.DB.Curve,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},System.Collections.Generic.IList{System.Collections.Generic.ICollection{Autodesk.Revit.DB.VertexPair}},Autodesk.Revit.DB.SolidOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities.CreateSweptBlendGeometry(Autodesk.Revit.DB.Curve,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},System.Collections.Generic.IList{System.Collections.Generic.ICollection{Autodesk.Revit.DB.VertexPair}},Autodesk.Revit.DB.SolidOptions)`

#### Summary

Creates a solid by simultaneously sweeping and blending two or more closed planar curve loops along a single curve.

#### Parameter `pathCurve`

The sweep path, consisting of a single bounded, open curve.

#### Parameter `pathParams`

An increasing sequence of parameters along the path curve (lying within the curve's bounds).
These parameters specify the locations of the planes orthogonal to the path that contain the profile loops.
This array must have the same size as the input array "profileLoops".

#### Parameter `profileLoops`

Closed, planar curve loops arrayed along the path. No loop may contain just one closed curve - split such loops into two or more curves beforehand.
The solid will have these profiles as cross-sections at the points specified by the input pathParams. The solid will blend smoothly between the profiles.
This array must have the same size as the input array "pathParams", and each profile loop must lie in the plane orthogonal to the path at the point specified by the corresponding entry in the input array "pathParams".
Each profile loop must define a single planar domain and must be free of intersections and degeneracies. No orientation conditions on the loops are imposed.

#### Parameter `vertexPairs`

This input specifies how adjacent profile loops should be connected.
It must contain one less element than the "profileLoops" input, and entry vertexPairs[idx] specifies how profileLoops[idx] and profileLoops[idx+1] should be connected (indexing starts at 0).

#### Parameter `solidOptions`

The optional information to control the properties of the Solid.

#### Returns

The requested solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input pathCurve is a helical curve and is not supported for this operation.
-or-
The input argument pathCurve should be bounded.
The input argument pathCurve should be non-degenerate.
-or-
The input argument pathParams should be an increasing array.
-or-
The profile CurveLoops do not satisfy the input requirements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.GeometryCreationUtilities.CreateSweptGeometry(Autodesk.Revit.DB.CurveLoop,System.Int32,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.SolidOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities.CreateSweptGeometry(Autodesk.Revit.DB.CurveLoop,System.Int32,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.SolidOptions)`

#### Summary

Creates a solid by sweeping one or more closed coplanar curve loops along a path.

#### Remarks

The profile loops must lie in a plane orthogonal to the sweep path at some attachment point along the path.

#### Parameter `sweepPath`

The sweep path, consisting of a set of contiguous curves. The path may be open or closed,
but should not otherwise have any self-intersections. The path may be planar or non-planar.

#### Parameter `pathAttachmentCrvIdx`

The index of the curve in the sweep path where the profile loops are situated.
Indexing starts at 0. Together with pathAttachmentParam, this specifies the profile's attachment point.

#### Parameter `pathAttachmentParam`

Parameter of the path curve specified by pathAttachmentCrvIdx.
The profile curves must lie in the plane orthogonal to the path at this attachment point.

#### Parameter `profileLoops`

The curve loops defining the planar domain to be swept along the path.
No conditions are imposed on the orientations of the loops:
this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions.
Restrictions:
The loops must lie in the plane orthogonal to the path at the attachment point as defined above.

The curve loop(s) must be closed and should define a single planar domain (one outer loop and, optionally, one or more inner loops)

The curve loops must be without intersections, self-intersections, or degeneracies.

No loop may contain just one closed curve - split such loops into two or more curves beforehand.

#### Parameter `solidOptions`

The optional information to control the properties of the Solid.

#### Returns

The requested solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input argument sweepPath should at least contain one curve.
-or-
The input argument pathAttachmentCrvIdx is not valid.
The given attachment point doesn't lie in the plane of the Curve Loop.
-or-
The profile CurveLoops do not satisfy the input requirements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.GeometryCreationUtilities.CreateRevolvedGeometry(Autodesk.Revit.DB.Frame,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},System.Double,System.Double,Autodesk.Revit.DB.SolidOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities.CreateRevolvedGeometry(Autodesk.Revit.DB.Frame,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},System.Double,System.Double,Autodesk.Revit.DB.SolidOptions)`

#### Summary

Creates a solid of revolution by revolving a set of closed curve loops around an axis by a specified angle.

#### Parameter `coordinateFrame`

A right-handed orthonormal frame of vectors. The frame's z-vector is the axis of revolution. The start and end angle inputs refer to this frame.

#### Parameter `profileLoops`

The profile loops to be revolved. No conditions are imposed on the orientations of the loops.
This function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions.
Restrictions:
The loops must lie in the xz coordinate plane of the input coordinate frame.

The curve loop(s) must be closed and must define a single planar domain (one outer loop and, optionally, one or more inner loops).

The curve loops must be without intersections, self-intersections, or degeneracies.

The loops must lie on the "right" side of the z axis (where x >= 0).

No loop may contain just one closed curve - split such loops into two or more curves beforehand.

#### Parameter `startAngle`

The start angle for the revolution, in radians,
measured counter-clockwise from the coordinate frame's x-axis as viewed looking down the frame's z-axis.

#### Parameter `endAngle`

The end angle for the revolution, using the same conventions as the start angle.
The end angle may be less than (but not equal to) the start angle.
The total angle of revolution, equal to the absolute value of (endAngle â€“ startAngle), must be at most 2*PI.

#### Parameter `solidOptions`

The optional information to control the properties of the Solid.

#### Returns

The requested solid. Note that if less than a full revolution is used, planar end faces will be added as part of the solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input argument coordinateFrame should be a right-handed orthonormal frame of vectors.
-or-
The profile CurveLoops do not satisfy the input requirements.
-or-
The absolute value of %(endAngle â€“ startAngle)%, must be at most 2*PI.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.GeometryCreationUtilities.CreateExtrusionGeometry(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ,System.Double,Autodesk.Revit.DB.SolidOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities.CreateExtrusionGeometry(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ,System.Double,Autodesk.Revit.DB.SolidOptions)`

#### Summary

Creates a solid by linearly extruding one or more closed coplanar curve loops.

#### Parameter `profileLoops`

The profile loops to be extruded. The loops must be closed, coplanar, and without intersections, self-intersections, or degeneracies. No loop may contain just one closed curve - split such loops into two or more curves beforehand.
No conditions are imposed on the orientations of the loops: this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions.

#### Parameter `extrusionDir`

The direction in which to extrude the profile loops. This vector must be non-zero and transverse
(i.e., not parallel) to the plane of the profile loops. Its length is irrelevant; only its direction is used.

#### Parameter `extrusionDist`

The positive distance by which the loops are to be extruded in the direction of the input extrusionDir.

#### Parameter `solidOptions`

The optional information to control the properties of the Solid.

#### Returns

The requested solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The profile CurveLoops do not satisfy the input requirements.
-or-
The Input extrusionDir must be a non-zero vector.
The normal of the loop plane should not be perpendicular to the given extrusionDir.
-or-
The input argument extrusionDist must be positive.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.GeometryCreationUtilities.CreateBlendGeometry(Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.CurveLoop,System.Collections.Generic.ICollection{Autodesk.Revit.DB.VertexPair})`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities.CreateBlendGeometry(Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.CurveLoop,System.Collections.Generic.ICollection{Autodesk.Revit.DB.VertexPair})`

#### Summary

Creates a solid by blending two closed curve loops lying in non-coincident planes.

#### Parameter `firstLoop`

The first curve loop. The loop must be a closed planar loop without intersections or degeneracies. No orientation conditions are imposed. The loop may not contain just one closed curve - split such a loop into two or more curves beforehand.

#### Parameter `secondLoop`

The second curve loop, satisfying the same conditions as the first loop.
The planes of the first and second loops must not be coincident, but they need not be parallel.

#### Parameter `vertexPairs`

This input specifies how the two profile loops should be connected.
If null, the function chooses vertex connections that will result in a geometrically reasonable blend.

#### Returns

The requested solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The first profile CurveLoop do not satisfy the input requirements.
-or-
The second profile CurveLoop do not satisfy the input requirements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.GeometryCreationUtilities.CreateSweptBlendGeometry(Autodesk.Revit.DB.Curve,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},System.Collections.Generic.IList{System.Collections.Generic.ICollection{Autodesk.Revit.DB.VertexPair}})`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities.CreateSweptBlendGeometry(Autodesk.Revit.DB.Curve,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},System.Collections.Generic.IList{System.Collections.Generic.ICollection{Autodesk.Revit.DB.VertexPair}})`

#### Summary

Creates a solid by simultaneously sweeping and blending two or more closed planar curve loops along a single curve.

#### Parameter `pathCurve`

The sweep path, consisting of a single bounded, open curve.

#### Parameter `pathParams`

An increasing sequence of parameters along the path curve (lying within the curve's bounds).
These parameters specify the locations of the planes orthogonal to the path that contain the profile loops.
This array must have the same size as the input array "profileLoops".

#### Parameter `profileLoops`

Closed, planar curve loops arrayed along the path. No loop may contain just one closed curve - split such loops into two or more curves beforehand.
The solid will have these profiles as cross-sections at the points specified by the input pathParams. The solid will blend smoothly between the profiles.
This array must have the same size as the input array "pathParams", and each profile loop must lie in the plane orthogonal to the path at the point specified by the corresponding entry in the input array "pathParams".
Each profile loop must define a single planar domain and must be free of intersections and degeneracies. No orientation conditions on the loops are imposed.

#### Parameter `vertexPairs`

This input specifies how adjacent profile loops should be connected.
It must contain one less element than the "profileLoops" input, and entry vertexPairs[idx] specifies how profileLoops[idx] and profileLoops[idx+1] should be connected (indexing starts at 0).

#### Returns

The requested solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input pathCurve is a helical curve and is not supported for this operation.
-or-
The input argument pathCurve should be bounded.
The input argument pathCurve should be non-degenerate.
-or-
The input argument pathParams should be an increasing array.
-or-
The profile CurveLoops do not satisfy the input requirements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.GeometryCreationUtilities.CreateSweptGeometry(Autodesk.Revit.DB.CurveLoop,System.Int32,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities.CreateSweptGeometry(Autodesk.Revit.DB.CurveLoop,System.Int32,System.Double,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Creates a solid by sweeping one or more closed coplanar curve loops along a path.

#### Remarks

The profile loops must lie in a plane orthogonal to the sweep path at some attachment point along the path.

#### Parameter `sweepPath`

The sweep path, consisting of a set of contiguous curves. The path may be open or closed,
but should not otherwise have any self-intersections. The path may be planar or non-planar.

#### Parameter `pathAttachmentCrvIdx`

The index of the curve in the sweep path where the profile loops are situated.
Indexing starts at 0. Together with pathAttachmentParam, this specifies the profile's attachment point.

#### Parameter `pathAttachmentParam`

Parameter of the path curve specified by pathAttachmentCrvIdx.
The profile curves must lie in the plane orthogonal to the path at this attachment point.

#### Parameter `profileLoops`

The curve loops defining the planar domain to be swept along the path.
No conditions are imposed on the orientations of the loops:
this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions.
Restrictions:
The loops must lie in the plane orthogonal to the path at the attachment point as defined above.

The curve loop(s) must be closed and should define a single planar domain (one outer loop and, optionally, one or more inner loops)

The curve loops must be without intersections, self-intersections, or degeneracies.

No loop may contain just one closed curve - split such loops into two or more curves beforehand.

#### Returns

The requested solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input argument sweepPath should at least contain one curve.
-or-
The input argument pathAttachmentCrvIdx is not valid.
The given attachment point doesn't lie in the plane of the Curve Loop.
-or-
The profile CurveLoops do not satisfy the input requirements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the swept solid.

#### Since

2012

### `M:Autodesk.Revit.DB.GeometryCreationUtilities.CreateRevolvedGeometry(Autodesk.Revit.DB.Frame,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities.CreateRevolvedGeometry(Autodesk.Revit.DB.Frame,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},System.Double,System.Double)`

#### Summary

Creates a solid of revolution by revolving a set of closed curve loops around an axis by a specified angle.

#### Parameter `coordinateFrame`

A right-handed orthonormal frame of vectors. The frame's z-vector is the axis of revolution. The start and end angle inputs refer to this frame.

#### Parameter `profileLoops`

The profile loops to be revolved. No conditions are imposed on the orientations of the loops.
This function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions.
Restrictions:
The loops must lie in the xz coordinate plane of the input coordinate frame.

The curve loop(s) must be closed and must define a single planar domain (one outer loop and, optionally, one or more inner loops).

The curve loops must be without intersections, self-intersections, or degeneracies.

The loops must lie on the "right" side of the z axis (where x >= 0).

No loop may contain just one closed curve - split such loops into two or more curves beforehand.

#### Parameter `startAngle`

The start angle for the revolution, in radians,
measured counter-clockwise from the coordinate frame's x-axis as viewed looking down the frame's z-axis.

#### Parameter `endAngle`

The end angle for the revolution, using the same conventions as the start angle.
The end angle may be less than (but not equal to) the start angle.
The total angle of revolution, equal to the absolute value of (endAngle â€“ startAngle), must be at most 2*PI.

#### Returns

The requested solid. Note that if less than a full revolution is used, planar end faces will be added as part of the solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input argument coordinateFrame should be a right-handed orthonormal frame of vectors.
-or-
The profile CurveLoops do not satisfy the input requirements.
-or-
The absolute value of %(endAngle â€“ startAngle)%, must be at most 2*PI.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.GeometryCreationUtilities.CreateExtrusionGeometry(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities.CreateExtrusionGeometry(System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.XYZ,System.Double)`

#### Summary

Creates a solid by linearly extruding one or more closed coplanar curve loops.

#### Parameter `profileLoops`

The profile loops to be extruded. The loops must be closed, coplanar, and without intersections, self-intersections, or degeneracies. No loop may contain just one closed curve - split such loops into two or more curves beforehand.
No conditions are imposed on the orientations of the loops: this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions.

#### Parameter `extrusionDir`

The direction in which to extrude the profile loops. This vector must be non-zero and transverse
(i.e., not parallel) to the plane of the profile loops. Its length is irrelevant; only its direction is used.

#### Parameter `extrusionDist`

The positive distance by which the loops are to be extruded in the direction of the input extrusionDir.

#### Returns

The requested solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The profile CurveLoops do not satisfy the input requirements.
-or-
The Input extrusionDir must be a non-zero vector.
The normal of the loop plane should not be perpendicular to the given extrusionDir.
-or-
The input argument extrusionDist must be positive.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.GeometryCreationUtilities`

Member kind: type
Symbol: `Autodesk.Revit.DB.GeometryCreationUtilities`

#### Summary

A utility that allows construction of basic solid shapes.

#### Remarks

The shapes created by these utilities are not a part of any Revit document,
but can be used in conjunction with other geometric utilities from within API applications.

#### Since

2012

### `P:Autodesk.Revit.DB.SolidOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SolidOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.SolidOptions.ExtraFaceAndEdgeHistoryKey`

Member kind: property
Symbol: `Autodesk.Revit.DB.SolidOptions.ExtraFaceAndEdgeHistoryKey`

#### Summary

Optional extra key used to create face and edge histories for the Solid.
If extraFaceAndEdgeHistoryKey is higher than -1, the Solid's face and edge histories will be created depending on the geometry generation of the Solid.

#### Since

2015

### `P:Autodesk.Revit.DB.SolidOptions.GraphicsStyleId`

Member kind: property
Symbol: `Autodesk.Revit.DB.SolidOptions.GraphicsStyleId`

#### Summary

Defines the graphics style id for the Solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.SolidOptions.MaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.SolidOptions.MaterialId`

#### Summary

Defines the material id for the Solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.SolidOptions.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SolidOptions.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new SolidOptions class with material and graphics style settings.

#### Parameter `materialId`

The material id for the Solid.

#### Parameter `graphicsStyleId`

The graphics style id for the Solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.SolidOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.SolidOptions`

#### Summary

A class containing optional information to control the properties of the Solid generated by the GeometryCreationUtilities routines.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.BendingDetailInternals.GetTickMarkGeometry(Autodesk.Revit.DB.View,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.DimensionType,System.Double,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailInternals.GetTickMarkGeometry(Autodesk.Revit.DB.View,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.DimensionType,System.Double,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates the tick mark specified buy the input dimension type.

#### Parameter `dbView`

The view that has the dimension.

#### Parameter `position`

The position of the TickMark.

#### Parameter `direction`

The direction of the line on which the tick mark will stay.

#### Parameter `normal`

The normal of the plane in this the tick mark will stay

#### Parameter `dimenstionType`

The dimsion type.

#### Parameter `modelToSheetScale`

A scale that will be applied to the text. Ususally it is the view scale.

#### Parameter `graphicStyleId`

The graphic sttyle that will be set on the entre GGroup.

#### Returns

Returns a GGroup which contins the tick mark graphics.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.BendingDetailInternals.TransformGNode(Autodesk.Revit.DB.Transform,Autodesk.Revit.DB.GeometryObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailInternals.TransformGNode(Autodesk.Revit.DB.Transform,Autodesk.Revit.DB.GeometryObject)`

#### Summary

Apply the transformation to the input GNode

#### Parameter `transform`

The transformation

#### Parameter `gNodeToTransform`

The GNode that would be transformed

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.BendingDetailInternals.MoveTextAtTheEndOfLine(Autodesk.Revit.DB.Line,System.Int32,Autodesk.Revit.DB.GeometryObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailInternals.MoveTextAtTheEndOfLine(Autodesk.Revit.DB.Line,System.Int32,Autodesk.Revit.DB.GeometryObject)`

#### Summary

It will move the text at the specified end of the line.

#### Parameter `line`

The Line

#### Parameter `lineEnd`

The end of the line.

#### Parameter `groupWithTexts`

The GGroup node with texts that would be transformed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.BendingDetailInternals.MoveTextWithVec(Autodesk.Revit.DB.XYZ,System.Boolean,Autodesk.Revit.DB.GeometryObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailInternals.MoveTextWithVec(Autodesk.Revit.DB.XYZ,System.Boolean,Autodesk.Revit.DB.GeometryObject)`

#### Summary

It will move the text with the specified vector plus (only if addHalfOfWidth is true) half of the text width in the same direction as the specified vector.

#### Parameter `moveVec`

The movement vector.

#### Parameter `addHalfOfWidth`

If true, will add half of width in the direction of moveVec.

#### Parameter `groupWithTexts`

The GGroup node with texts that would be transformed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.BendingDetailInternals.AlterDimensionGraphics(System.Boolean,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.XYZ,System.String,System.String,Autodesk.Revit.DB.Document,System.Double,System.Boolean,Autodesk.Revit.DB.GeometryObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailInternals.AlterDimensionGraphics(System.Boolean,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.XYZ,System.String,System.String,Autodesk.Revit.DB.Document,System.Double,System.Boolean,Autodesk.Revit.DB.GeometryObject)`

#### Summary

It will replace the text's content with contentText (if is not an empty string).
If the text generated by the dimension is between the bar segment and dimension extension curve (line/arc), it will be moved on the other part of the dimension extension curve (line/arc).
If contentAlternateText is non empty, a new text with this string as content will be created on the other part of the dimension extension curve
If removeAllButText, the returned graphics will contin just the texts

#### Parameter `adjustTextSide`

If true, it will calcualte if the text is "inside" the dimension using outsideDir. If it's inside it will be moved on the opposite part.

#### Parameter `dimensionExtensionCurve`

The dimension extension curve (line/arc).

#### Parameter `outsideDir`

The direction which means that is "outside" of the segment.
Starting from the segment in this direction it should be the dimension extension curve (line/arc) and than the text.

#### Parameter `contentText`

The new content for the text that already exists in the dimension geometry .

#### Parameter `contentAlternateText`

If this is non empty, a text on the oppsite part of the dimenion extendion curve will be created.

#### Parameter `document`

The Document which was used to compute the dimension's geometry.

#### Parameter `modelToSheetScale`

1 / The view scale.

#### Parameter `removeAllButText`

If this is true, only the texts from dimenion grapics will be returned.

#### Parameter `dimensionGeometry`

The geometry of the dimension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.BendingDetailInternals.GetTextWidth(Autodesk.Revit.DB.GeometryObject)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailInternals.GetTextWidth(Autodesk.Revit.DB.GeometryObject)`

#### Parameter `pTextGNode`

The GText.

#### Returns

Returns the width of the text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.BendingDetailInternals.CreateTextGeometryObject(System.String,Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String,System.Double,Autodesk.Revit.DB.Color,System.Double,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.HorizontalTextAlignment,Autodesk.Revit.DB.VerticalTextAlignment)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailInternals.CreateTextGeometryObject(System.String,Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String,System.Double,Autodesk.Revit.DB.Color,System.Double,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.HorizontalTextAlignment,Autodesk.Revit.DB.VerticalTextAlignment)`

#### Summary

Creates a GeomtryObject that is a text.
This function should be removed and GRichText class should be exposed to API.
Keep in mind that GText is still present in Revit. Maybe the APIText class should wrap both GRichText and GText

#### Parameter `text`

The content of the text.

#### Parameter `document`

The document that contains element which has the properties of the text.

#### Parameter `textStyleOwnerId`

The id of the element from which the text properties were taken.

#### Parameter `fontName`

The name of the text font.

#### Parameter `height`

Height [ft] of the area of the text content in model space.

#### Parameter `fontColor`

The color of the text. RGB value of the color.

#### Parameter `modelToSheetScale`

A scale that will be applied to the text. Ususally it is the view scale.

#### Parameter `position`

Position of the text in model coordinates.

#### Parameter `baseDirection`

Direction of the base line of the text object in model space.

#### Parameter `upDirection`

Direction along the vertical axis of letters of the text object in model space.

#### Parameter `horizontalAlignment`

Indicates default horizontal alignment of the text.

#### Parameter `verticalAlignment`

Indicates default vertical alignment of the text.

#### Returns

Returns the newly created GeometryObject that is a text.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.Structure.BendingDetailInternals.ComputeOutlineInView(Autodesk.Revit.DB.GeometryObject,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailInternals.ComputeOutlineInView(Autodesk.Revit.DB.GeometryObject,Autodesk.Revit.DB.View)`

#### Summary

This method computes the Outline of the provided GeometryElement in view.
Returns true if the outline was computed successfully and false otherwise.

#### Parameter `geometryObject`

The geometry object to compute outline.

#### Parameter `dbView`

The view in which the outline is computed

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.Structure.BendingDetailInternals`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BendingDetailInternals`

#### Summary

Static utility class with public_api_internal methods needed for bending detail computation.
This functions should be exposed to API in a way or another.

### `P:Autodesk.Revit.DB.Lighting.BasicLossFactor.LossFactor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.BasicLossFactor.LossFactor`

#### Summary

The loss factor.

#### Value

The loss factor as a numerical value between 0.0 and 4.0

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The loss factor is not valid because it is not between 0.0 and 4.0.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.BasicLossFactor.#ctor(Autodesk.Revit.DB.Lighting.BasicLossFactor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.BasicLossFactor.#ctor(Autodesk.Revit.DB.Lighting.BasicLossFactor)`

#### Summary

Creates a copy of the given basic loss factor object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.BasicLossFactor.#ctor(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.BasicLossFactor.#ctor(System.Double)`

#### Summary

Creates a basic loss factor object with the given value.

#### Parameter `lossFactorIn`

The loss factor as a numerical value between 0.0 and 4.0

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The loss factor is not valid because it is not between 0.0 and 4.0.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.BasicLossFactor.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.BasicLossFactor.#ctor`

#### Summary

Creates a basic loss factor object with no loss.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.BasicLossFactor`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.BasicLossFactor`

#### Summary

This class encapsulates basic lighting loss factor calculation.

#### Since

2013
