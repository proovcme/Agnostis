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
Shard: 62
Member count: 165

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `P:Autodesk.Revit.DB.Events.RevitAPIEventArgs.Cancellable`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.RevitAPIEventArgs.Cancellable`

#### Summary

Indicates whether an event may be cancelled by an event delegate.

#### Remarks

If Cancellable returns true, event delegates may cancel the command that
was announced by the event. To do so, a delegate may call the Cancel() method if it is available.
Typically, single-events and post-events (e.g. DocumentPrinted) are not cancellable,
while most pre-events (e.g. DocumentPrinting) are cancellable, except for special
conditions and situations, such as when the Revit application is being closed
or if an event is raised during another event.

#### Since

2011

### `T:Autodesk.Revit.DB.Events.RevitAPIEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.RevitAPIEventArgs`

#### Summary

The class is used as base class for all event argument classes.

#### Since

2011

### `T:Autodesk.Revit.DB.Events.RevitAPIEventStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.RevitAPIEventStatus`

#### Summary

Describes the status of an action which triggered a post event.

#### Summary

Describes the status of an action which triggered a post event.

#### Since

2011

### `F:Autodesk.Revit.DB.Events.RevitAPIEventStatus.Cancelled`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.RevitAPIEventStatus.Cancelled`

#### Summary

The action that triggered this event was cancelled by an event handler from the pre-event for the action.

### `F:Autodesk.Revit.DB.Events.RevitAPIEventStatus.Succeeded`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.RevitAPIEventStatus.Succeeded`

#### Summary

The action that triggered this event succeeded.

### `F:Autodesk.Revit.DB.Events.RevitAPIEventStatus.Failed`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.RevitAPIEventStatus.Failed`

#### Summary

The action that triggered this event failed .

### `T:Autodesk.Revit.DB.Binding`

Member kind: type
Symbol: `Autodesk.Revit.DB.Binding`

#### Summary

Binding objects are used to take a parameter definition and bind it to one or
more categories.

#### Remarks

This class is a base class for all types of parameter binding within Autodesk
Revit. Once the binding objects are created and added to the document parameters will be
added to elements in those categories specified in the binding. There are currently two
types of binding available, Instance binding and Type binding. The key difference between
the two is that the instance bound parameters appear on all instances of the elements in
those categories. Changing the parameter on one does not affect the other instances of
the parameter. The Type bound parameters appear only on the type object and is shared by
all the instances that use that type. Changing the type bound parameter affects all
instances of the elements that use that type. Note, a definition can only be bound to an
instance or a type and not both.

### `P:Autodesk.Revit.DB.APIObject.IsReadOnlyInternal`

Member kind: property
Symbol: `Autodesk.Revit.DB.APIObject.IsReadOnlyInternal`

### `M:Autodesk.Revit.DB.APIObject.Dispose`

Member kind: method
Symbol: `Autodesk.Revit.DB.APIObject.Dispose`

#### Summary

Causes the object to release immediately any resources it may be utilizing.

#### Remarks

This method is usually called implicitly by the programming language when
the object is destroyed. After calling this method the object will no longer work correctly.

### `P:Autodesk.Revit.DB.APIObject.IsReadOnly`

Member kind: property
Symbol: `Autodesk.Revit.DB.APIObject.IsReadOnly`

#### Summary

Identifies if the object is read-only or modifiable.

#### Value

If true, the object may not be modified. If false, the object's contents may be modified.

### `T:Autodesk.Revit.DB.APIObject`

Member kind: type
Symbol: `Autodesk.Revit.DB.APIObject`

#### Summary

Supports all objects in the Autodesk Revit API hierarchy.

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ProjectBrowserDataChanged`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ProjectBrowserDataChanged`

#### Summary

Subscribe to the ProjectBrowserDataChanged event to be notified when the ProjectBrowser data is changed.

#### Since

2024

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataTypeServerFailureResolutionExecuting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataTypeServerFailureResolutionExecuting`

#### Summary

Subscribe to the ExternalDataTypeServerFailureResolutionExecuting event to be notified when the ExternalDataTypeServerFailureResolution is executing in Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceRemovedFromDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceRemovedFromDocument`

#### Summary

Subscribe to the ExternalDataInstanceRemovedFromDocument event to be notified when an ExternalDataInstance has been removed from Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceRemovingFromDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceRemovingFromDocument`

#### Summary

Subscribe to the ExternalDataInstanceRemovingFromDocument event to be notified when an ExternalDataInstance is being removed from Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceAddedIntoDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceAddedIntoDocument`

#### Summary

Subscribe to the ExternalDataInstanceAddedIntoDocument event to be notified when a new ExternalDataInstance has been added to Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceAddingIntoDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceAddingIntoDocument`

#### Summary

Subscribe to the ExternalDataInstanceAddingIntoDocument event to be notified when a new ExternalDataInstance is being added to Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentReloadedLatest`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentReloadedLatest`

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

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentReloadingLatest`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentReloadingLatest`

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

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.GetFolderContentsRequested`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetFolderContentsRequested`

#### Summary

Subscribe to the GetFolderContentsRequested event to be notified immediately when Revit requests for a list of cloud folder contents, containing subfolders and cloud models.

#### Remarks

This event is raised to get information regarding Folder Contents within ForgeDM (Collaborate add-in).

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.GetProjectsRequested`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetProjectsRequested`

#### Summary

Subscribe to the GetProjectsRequested event to be notified immediately when Revit requests for a list of cloud projects.

#### Remarks

This event is raised to get information regarding Projects within ForgeDM (Collaborate add-in).

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.GetHubsRequested`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetHubsRequested`

#### Summary

Subscribe to the GetHubsRequested event to be notified immediately when Revit requests for a list of cloud hubs.

#### Remarks

This event is raised to get information regarding Hubs within ForgeDM (Collaborate add-in).

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.PositionsSaved`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.PositionsSaved`

#### Summary

Subscribe to the PositionsSaved event to be notified immediately after linked symbols Positions (Shared Coordinates) saved during "Save Positions' operations.

#### Remarks

This event is only raised for shared coordinates changes saved to Revit links.
Users may not change the document in the handler for this event.
It is NOT recommended to do any time-consuming work when handling PositionsSaved event.

#### Since

2018

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ElementTypeDuplicated`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ElementTypeDuplicated`

#### Summary

Subscribe to the ElementTypeDuplicated event to be notified immediately after Revit has finished duplicating an element type.

#### Remarks

This event is raised immediately after Revit has finished duplicating an element type.
It is raised even when duplicating an element type failed or was cancelled (during ElementTypeDuplicating event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in the event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of duplicating an element type has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2015

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ElementTypeDuplicating`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ElementTypeDuplicating`

#### Summary

Subscribe to the ElementTypeDuplicating event to be notified when Revit is just about to duplicate an element type.

#### Remarks

This event is raised when Revit is just about to duplicate an element type.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Import()`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.ElementTypeDuplicated` event will be raised immediately after duplicating an element type is finished.

#### Since

2015

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FamilyLoadedIntoDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FamilyLoadedIntoDocument`

#### Summary

Subscribe to the FamilyLoadedInto event to be notified after Revit loaded a family into a document.

#### Remarks

This event is raised immediately after Revit has finished loading a family into a document.
It is raised even when family loading failed or was cancelled (during FamilyLoadingIntoDocument event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of importing has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2015

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FamilyLoadingIntoDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FamilyLoadingIntoDocument`

#### Summary

Subscribe to the FamilyLoadingInto event to be notified when Revit is just about to load a family into a document.

#### Remarks

This event is raised when Revit is just about to load a family into a document.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Import()`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.FamilyLoadedIntoDocument` event will be raised immediately after family loading
is finished.

#### Since

2015

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentWorksharingEnabled`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentWorksharingEnabled`

#### Summary

Subscribe to the DocumentWorksharingEnabled event to be notified when a document has become workshared.

#### Remarks

This event is raised when Revit has just enabled worksharing in the document.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

#### Since

2015

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ProgressChanged`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ProgressChanged`

#### Summary

Subscribe to the ProgressChanged event to be notified when an operation in Revit has progress bar data available.

#### Remarks

Handlers of this event may use the `M:Autodesk.Revit.DB.Events.ProgressChangedEventArgs.Cancel` method to cancel the operation tracked by the progress bar.
Users may not change the document in the handler for this event.
Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException` will be thrown if any document-modifying method is called during this event's handler.

#### Since

2013

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.WorksharedOperationProgressChanged`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.WorksharedOperationProgressChanged`

#### Summary

Subscribe to the WorksharedOperationProgressChanged to be notified when progress has changed during Collaboration for Revit's workshared operations: open model and synchronize with central.

#### Remarks

This event is only supported for Collaboration for Revit and will not be raised for those operations occurring in local-worksharing and Revit Server workflow.
Users may not change the document in the handler for this event.
It is NOT recommended to do any time-consuming work when handling WorksharedOperationProgressChanged event. This can increase workshared operation time."
Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException` will be thrown if any document-modifying method is called during this event's handler.

#### Since

2017 Subscription Update

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.LinkedResourceOpened`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.LinkedResourceOpened`

#### Summary

Subscribe to the LinkedResourceOpened event to be notified immediately after Revit has finished opening a linked resource.

#### Remarks

This event is raised immediately after Revit has finished opening a linked resource.
Only supports linked resources for following types : Revit; IFC; CAD(dwg, dxf, dgn, sat); Topography;
It is raised even when a linked resource opening failed.
The LinkedResourceOpened events would not raised if there are no update on linked CAD, IFC resources.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

Another `E:Autodesk.Revit.ApplicationServices.Application.LinkedResourceOpening` event will be raised when Revit is just about to
open a linked resource.

#### Since

2018

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.LinkedResourceOpening`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.LinkedResourceOpening`

#### Summary

Subscribe to the LinkedResourceOpening event to be notified when Revit is just about to open a linked resource.

#### Remarks

This event is raised when Revit is just about to open a linked resource.
Only supports linked resources for following types : Revit; IFC; CAD(dwg, dxf, dgn, sat);
This event would not be raised if there are no update on linked CAD, IFC resources.

Event is not cancellable.

The linked resource cannot be modified, for it is not opened yet at the time of the event.

Another `E:Autodesk.Revit.ApplicationServices.Application.LinkedResourceOpened` event will be raised immediately after
linked resource is opened.

#### Since

2018

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSynchronizedWithCentral`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSynchronizedWithCentral`

#### Summary

Subscribe to the DocumentSynchronizedWithCentral event to be notified immediately after Revit has finished synchronizing a document with central model.

#### Remarks

This event is raised immediately after Revit has finished synchronizing a document with central model.
It is raised even when document synchronizing with central model failed or was cancelled (during DocumentSynchronizingWithCentral event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of synchronizing a document with central model has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSynchronizingWithCentral`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSynchronizingWithCentral`

#### Summary

Subscribe to the DocumentSynchronizingWithCentral event to be notified when Revit is just about to synchronize a document with central model.

#### Remarks

This event is raised when Revit is just about to synchronize a document with central model.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.DocumentSynchronizedWithCentral` event will be raised immediately after document synchronizing with central model
is finished.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentOpened`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentOpened`

#### Summary

Subscribe to the DocumentOpened event to be notified immediately after Revit has finished opening a document.

#### Remarks

This event is raised immediately after Revit has finished opening a document.
It is raised even when document opening failed or was cancelled (during DocumentOpening event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of opening document has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentOpening`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentOpening`

#### Summary

Subscribe to the DocumentOpening event to be notified when Revit is just about to open a document.

#### Remarks

This event is raised when Revit is just about to open a document.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The document cannot be modified, for it is not opened yet at the time of the event.

Another `E:Autodesk.Revit.ApplicationServices.Application.DocumentOpened` event will be raised immediately after document
is opened.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ViewsExportedByContext`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ViewsExportedByContext`

#### Summary

Subscribe to the ViewsExportedByContext event to be notified immediately after Revit has finished exporting one or more views of the document via an export context by CustomExporter.

#### Remarks

This event is raised immediately after Revit has finished exporting views of the document via an export context by CustomExporter.

It is raised even when view exporting via export context by CustomExporter failed.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action was successful or not.

This event is not cancellable, for the process of view exporting by CustomExporter has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2021

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ViewsExportingByContext`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ViewsExportingByContext`

#### Summary

Subscribe to the ViewsExportingByContext event to be notified when Revit is just about to export one or more views of the document via an export context by CustomExporter.

#### Remarks

This event is raised when Revit is just about to export views of the document via an export context by CustomExporter.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another event `E:Autodesk.Revit.ApplicationServices.Application.ViewsExportedByContext` will be raised immediately after view exporting by CustomExporter
is finished.

#### Since

2021

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ViewExported`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ViewExported`

#### Summary

Subscribe to the ViewExported event to be notified immediately after Revit has finished exporting a view of the document.

#### Remarks

This event is raised immediately after Revit has finished exporting a view of the document.
It is raised only during accelerated export jobs, in which views are exported in parallel using a background process.
Accelerated export only occurs when exporting to DWF formats and not combining views into a single file.

It is raised even when view exporting failed.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action was successful or not.

This event is not cancellable, for the process of view exporting has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2018

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ViewExporting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ViewExporting`

#### Summary

Subscribe to the ViewExporting event to be notified when Revit is just about to export a view of the document.

#### Remarks

This event is raised when Revit is just about to export a view of the document.
It is raised only during accelerated export jobs, in which views are exported in parallel using a background process.
Accelerated export only occurs when exporting to DWF formats and not combining views into a single file.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Export()Autodesk.Revit.DB.Document.Print()`M:Autodesk.Revit.DB.View.Print` and similar overloads.`M:Autodesk.Revit.DB.PrintManager.SubmitPrint` and similar overloads.`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another event `E:Autodesk.Revit.ApplicationServices.Application.ViewExported` will be raised immediately after view exporting
is finished.

#### Since

2018

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FileExported`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FileExported`

#### Summary

Subscribe to the FileExported event to be notified immediately after Revit has finished exporting files of formats supported by the API.

#### Remarks

This event is raised immediately after Revit has finished exporting files of formats supported by the API.
It is raised even when file exporting failed or was cancelled (during FileExporting event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.
If export is a part of 'Publish to Buzzsaw' command which consists of two parts â€“ export of a document followed by publishing it to a BuzzSaw server, the event status only reflects the result of the Export action. The publishing part of the command could still be cancelled or could fail after FileExported event is raised.

This event is not cancellable, for the process of exporting file has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FileExporting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FileExporting`

#### Summary

Subscribe to the FileExporting event to be notified when Revit is just about to export files of formats supported by the API.

#### Remarks

This event is raised when Revit is just about to export files of formats supported by the API.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Export()Autodesk.Revit.Document.Print()`M:Autodesk.Revit.DB.View.Print` and similar overloads.`M:Autodesk.Revit.DB.PrintManager.SubmitPrint` and similar overloads.`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.FileExported` event will be raised immediately after file exporting
is finished.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FileImported`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FileImported`

#### Summary

Subscribe to the FileImported event to be notified immediately after Revit has finished importing a file of format supported by the API.

#### Remarks

This event is raised immediately after Revit has finished importing a file of format supported by the API.
It is raised even when file importing failed or was cancelled (during FileImporting event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of importing has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FileImporting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FileImporting`

#### Summary

Subscribe to the FileImporting event to be notified when Revit is just about to import a file of format supported by the API.

#### Remarks

This event is raised when Revit is just about to import a file of format supported by the API.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Import()`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.FileImported` event will be raised immediately after file importing
is finished.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentCreated`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentCreated`

#### Summary

Subscribe to the DocumentCreated event to be notified immediately after Revit has finished creating a new document.

#### Remarks

This event is raised immediately after Revit has finished creating a new document.
It is raised even when document creation failed or was cancelled (during DocumentCreating event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.
This event is not cancellable, for the process of document creation has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentCreating`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentCreating`

#### Summary

Subscribe to the DocumentCreating event to be notified when Revit is just about to create a new document.

#### Remarks

This event is raised when Revit is just about to create a new document.

Event is cancellable. To cancel it, call the 'Cancel()' method of event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The document cannot be modified, for it is not created yet at the time of the event.

The following API functions are not available for the current document during this event:
`!:Autodesk::Revit::ApplicationServices::Application::NewProjectDocument()``M:Autodesk.Revit.ApplicationServices.Application.NewFamilyDocument(System.String)``M:Autodesk.Revit.ApplicationServices.Application.NewProjectTemplateDocument(System.String)``M:Autodesk.Revit.ApplicationServices.Application.OpenDocumentFile(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.DocumentCreated` event will be raised immediately after document
creation is finished.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentClosed`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentClosed`

#### Summary

Subscribe to the DocumentClosing event to be notified when Revit is just about to close a document.

#### Remarks

This event is raised immediately after Revit has finished closing a document.
It is raised even when document closing failed or was cancelled (during DocumentClosing event).

This event is not cancellable, for the process of closing document has already been finished.

The document cannot be modified because the corresponding object does not exist anymore.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentClosing`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentClosing`

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

An `E:Autodesk.Revit.ApplicationServices.Application.DocumentClosed` event will be raised immediately after document is closed.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ViewPrinted`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ViewPrinted`

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

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ViewPrinting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ViewPrinting`

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

Another event `E:Autodesk.Revit.ApplicationServices.Application.ViewPrinted` will be raised immediately after view printing
is finished.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentPrinted`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentPrinted`

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

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentPrinting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentPrinting`

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

After this event, for each view being printed, `E:Autodesk.Revit.ApplicationServices.Application.ViewPrinting` and `E:Autodesk.Revit.ApplicationServices.Application.ViewPrinted` events will be raised.
Another event `E:Autodesk.Revit.DB.Document.DocumentPrinted` will be raised immediately after document printing
is finished.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSavedAs`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSavedAs`

#### Summary

Subscribe to the DocumentSavedAs event to be notified immediately after Revit has finished saving document with a new file name.

#### Remarks

This event is raised immediately after Revit has finished saving document with a new file name.
Note that the first save of a newly created document will raise DocumentSavedAs rather than `E:Autodesk.Revit.ApplicationServices.Application.DocumentSaved` event.
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

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSavingAs`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSavingAs`

#### Summary

Subscribe to the DocumentSavingAs event to be notified when Revit is just about to save the document with a new file name.

#### Remarks

This event is raised when Revit is just about to save the document with a new file name.
Note that the first save of a newly created document will raise DocumentSavingAs rather than `E:Autodesk.Revit.ApplicationServices.Application.DocumentSaving` event.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

This event is cancellable, except when it is raised during close of the application.
Check the 'Cancellable' property of event's argument to see whether it is cancellable or not.
When it is cancellable, call the 'Cancel()' method of event's argument to cancel it.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another event `E:Autodesk.Revit.ApplicationServices.Application.DocumentSavedAs` will be raised immediately after the document has been saved with a new file name.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSaved`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSaved`

#### Summary

Subscribe to the DocumentSaved event to be notified immediately after Revit has finished saving a document.

#### Remarks

This event is raised immediately after Revit has finished saving a document.
Note that the first save of a newly created document will raise `E:Autodesk.Revit.ApplicationServices.Application.DocumentSavedAs`
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

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSaving`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSaving`

#### Summary

Subscribe to the DocumentSaving event to be notified when Revit is just about to save a document.

#### Remarks

This event is raised when Revit is just about to save the document.
Note that the first save of a newly created document will raise `E:Autodesk.Revit.ApplicationServices.Application.DocumentSavingAs`
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

Another event `E:Autodesk.Revit.ApplicationServices.Application.DocumentSaved` will be raised immediately after the document has been saved.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FailuresProcessing`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FailuresProcessing`

#### Summary

Subscribe to the FailuresProcessing event to be notified when failures are being processed at the end of transaction.

#### Remarks

This event is raised when failures are being processed during transaction commit or rollback operations.
Handlers of this event have a limited ability to modify the document and/or failures in it, using the provided
restricted failures accessor interface.

The event arguments provide access to the FailuresAccessor via
`!:Autodesk::Revit::DB::FailuresProcessingEventArgs::GetFailuresAccessor()`
which contains the details of the errors and/or warnings that caused the event to trigger.

The arguments also allow you to set a processing result via
`!:Autodesk::Revit::DB::FailuresProcessingEventArgs::SetProcessingResult()` . The processing
result determines if Revit will attempt to recommit the currently failing transaction, roll it back, or continue.
If you are explicitly dismissing warnings from the event callback, a processing result of Continue
is sufficient. But if you are explicitly resolving errors from the event callback, you must change the
processing result to ProceedWithCommit to ensure that the user is not shown the dismissed errors. If you
wish to cancel the transaction silently without showing the errors to the user, set the processing result to
ProceedWithRollback, however you must also call
`M:Autodesk.Revit.DB.FailureHandlingOptions.SetClearAfterRollback(System.Boolean)` in
order to dismiss the errors and silently cancel the transaction.

#### Since

2011

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentChanged`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentChanged`

#### Summary

Subscribe to the DocumentChanged event to be notified when Revit document has changed.

#### Remarks

This event is raised whenever a Revit transaction is either committed, undone or redone.
This is a readonly event, designed to allow you to keep external data in synch with the state of the
Revit database.
To update the Revit database in response to changes in elements, use the IUpdater framework.

#### Since

2011

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ApplicationInitialized`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ApplicationInitialized`

#### Summary

Subscribe to this event to get notified after the Revit application has been initialized

#### Remarks

The event is raised after Revit was launched as fully initialized,
including initialization of external applications.

#### Since

2013

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.EnsureGatewayClientInitialized`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.EnsureGatewayClientInitialized`

#### Summary

Indicates if the Gateway client is initialized using the global endpoint or not.

#### Remarks

This method will try to initialize the gateway client if the client isn't already set up.

#### Returns

Returns true if the Gateway client is initialized, otherwise returns false.

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.IsCloudCollaborationAddonLoaded`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsCloudCollaborationAddonLoaded`

#### Summary

Indicates if application loaded cloud addons correctly

#### Returns

Returns true if application loaded cloud addons correctly

#### Since

2020

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.HasCloudModelEntitlement`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.HasCloudModelEntitlement`

#### Summary

Indicates if the current user has the cloud model entitlement (Cloud Model for Revit) or not.

#### Returns

Returns true if the current user has the cloud model entitlement, otherwise returns false.

#### Since

2019.2

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.HasWorksharedCloudModelEntitlement`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.HasWorksharedCloudModelEntitlement`

#### Summary

Indicates if the current user has the workshared cloud model entitlement (BIM 360 Docs or Autodesk Docs Design) or not.

#### Returns

Returns true if the current user has the workshared cloud model entitlement, otherwise returns false.

#### Since

2019.2

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.GetCloudGUIDsByCloudModelInfo(System.String,System.String,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetCloudGUIDsByCloudModelInfo(System.String,System.String,System.String,System.String)`

#### Summary

Gets RCM project GUID and model GUID from project id, folder id and model name.

#### Parameter `region`

The BIM 360 Docs or Autodesk Docs account and project region.

#### Parameter `projectId`

Project identity in BIM 360 Docs or Autodesk Docs.

#### Parameter `folderId`

Folder identity in BIM 360 Docs or Autodesk Docs.

#### Parameter `modelName`

Model name in BIM 360 Docs or Autodesk Docs.

#### Returns

Returns a map including RCM project GUID and model GUID.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.HasBIM360Accounts`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.HasBIM360Accounts`

#### Summary

Indicates if the current login user has any BIM 360 Docs or Autodesk Docs accounts or not.

#### Returns

Returns true if the current login user has any BIM 360 Docs or Autodesk Docs accounts, otherwise returns false.

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.IsOnSubscription`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsOnSubscription`

#### Summary

Indicates if this Revit is on subscription or not.

#### Returns

Returns true if this Revit is on subscription, otherwise returns false.

#### Since

2019

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.OpenCloudCentralModel(Autodesk.Revit.DB.ModelPath,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.OpenCloudCentralModel(Autodesk.Revit.DB.ModelPath,System.Boolean)`

#### Summary

Opens a central document from cloud directly without creating a local cache

#### Remarks

This method opens the document into memory but does not make it visible to the user in any way.

#### Parameter `cloudPath`

The path to the cloud model to be opened.

#### Parameter `doNotLoadLinks`

Whether or not loading links when opening the model

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException`

Cannot open the local model and the central model in the same Revit session.You can close one to open the other in the same Revit session.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied.A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The model on the Skyscraper server is being accessed by other users.
-or-
The central model is locked by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Revit encountered serious errors while trying to open the central model.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.CorruptModelException`

There are too many corrupt elements to open this model.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

File cannot be opened in Revit LT because it was last saved in a version of Revit prior to 8.1.
-or-
File has an invalid extension.Try changing the file's extension and opening it again.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

File Not Found

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to open the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Open is temporarily disabled.
-or-
The document can not be opened.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Opening was canceled by the user or by an API event callback.

#### Exception `!:Autodesk::Revit::Exceptions::SkyscraperServerCommunicationException`

The skyscraper central model could not be accessed
because of a network communication error.

#### Exception `!:Autodesk::Revit::Exceptions::SkyscraperServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.WrongUserException`

The local file is not owned by the current user, who therefore is not allowed to modify it.

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.OpenCloudSharedModel(System.String,System.Guid,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.OpenCloudSharedModel(System.String,System.Guid,System.Guid)`

#### Summary

Opens a document from a cloud shared model

#### Remarks

The resulting document is a local file attached to the central model in the cloud.
This method opens the document into memory but does not make it visible to the user in any way.
Internally calls openDocumentFile, so this method may throw any of the same exceptions.

#### Parameter `region`

Account region of the model.

#### Parameter `projectID`

The id of the project to which the model has been assigned.

#### Parameter `modelID`

The id of the model.

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(System.String,Autodesk.Revit.DB.Document,Autodesk.Revit.DB.AddInId)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(System.String,Autodesk.Revit.DB.Document,Autodesk.Revit.DB.AddInId)`

#### Summary

Send analytics data, i.e. create ADP event

#### Remarks

This methods allows Revit inhouse addins to create ADP events for the data analytics purposes
without having to initialize ADP in the addin.
The events created by this method will appear as part of Revit session.
Attributes describing addin identity, like addin id, name, vendor id, will be added automatically.

#### Parameter `serializedData`

JSON serialized Facet::Core.

#### Parameter `pDocument`

Pointer to ADocument, may be nullptr

#### Parameter `pAddIn`

Pointer to AddInId, may be nullptr

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.IsPreviewRelease`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsPreviewRelease`

#### Summary

Checks whether or not the Revit is preview release version.

#### Returns

True if it is preview release, false otherwise.

#### Since

2020

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.CreateJournalHint(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.CreateJournalHint(System.String,System.String)`

#### Summary

Records a string in the journal file in the interactive session and fails on playback if recorded string is different.

#### Parameter `stringToJournal`

The string to journal.

#### Parameter `failureMessage`

The failure message.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.ReadRevitIniInteger(System.String,System.String,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ReadRevitIniInteger(System.String,System.String,System.Int32)`

#### Summary

Gets a setting from Revit ini file, as a integer.

#### Parameter `iniSection`

The section in the ini file where the setting is declared.

#### Parameter `iniEntry`

The setting's name.

#### Parameter `nDefaultValue`

The default value when no setting was found.

#### Returns

The value of the setting or the default value if no setting was found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.WriteRevitIniString(System.String,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.WriteRevitIniString(System.String,System.String,System.String)`

#### Summary

Writes a setting to Revit ini file, as a string.

#### Parameter `iniSection`

The section in the ini file where the setting is to be declared.

#### Parameter `iniEntry`

The setting's name.

#### Parameter `iniValue`

The setting's value.

#### Returns

True if the write was successful.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.ReadRevitIniString(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ReadRevitIniString(System.String,System.String)`

#### Summary

Gets a setting from Revit ini file, as a string.

#### Parameter `iniSection`

The section in the ini file where the setting is declared.

#### Parameter `iniEntry`

The setting's name.

#### Returns

The value of the setting or an empty string is no setting was found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.GetIniVarString(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetIniVarString(System.String,System.String)`

#### Summary

Gets a setting from an ini file, as a string.

#### Parameter `iniSection`

The section in the ini file where the setting is declared.

#### Parameter `iniEntry`

The setting's name.

#### Returns

The value of the setting or an empty string is no setting was found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.IsFeatureEnabledInLaunchDarkly(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsFeatureEnabledInLaunchDarkly(System.String)`

#### Summary

Determines if the specified feature is enabled in Launch Darkly.

#### Parameter `strFeatureName`

The feature name you want to ask Launch Darkly about

#### Returns

True if Launch Darkly flag is on

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.IsDebugModeSet(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsDebugModeSet(System.String)`

#### Summary

Determines if the specified debug mode is set.

#### Parameter `modeName`

The debug mode name.

#### Returns

True if the debug mode is set, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.GetAssets(Autodesk.Revit.DB.Visual.AssetType)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetAssets(Autodesk.Revit.DB.Visual.AssetType)`

#### Summary

Gets all the Assets of the specified type.

#### Parameter `assetType`

The asset type.

#### Returns

Returns an array of all the Assets within Revit of the specified type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2018.1

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.UpdateRenderAppearanceLibrary`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.UpdateRenderAppearanceLibrary`

#### Summary

Updates the stored render appearance library, giving the Revit session access to any new RPC content.

#### Since

2014

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.OpenDocumentFile(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.OpenDocumentFile(System.String)`

#### Summary

Opens a document from disk.

#### Remarks

This method opens the document into memory but does not make it visible to the user in any way.

#### Parameter `fileName`

The file to be opened.

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The fileName to be opened is empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException`

Cannot open the local model and the central model in the same Revit session. You can close one to open the other in the same Revit session.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Revit encountered serious errors while trying to open the central model.

#### Exception `T:Autodesk.Revit.Exceptions.CorruptModelException`

There are too many corrupt elements to open this model.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

File cannot be opened in Revit LT because it was last saved in a version of Revit prior to 8.1.
-or-
File has an invalid extension. Try changing the file's extension and opening it again.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

The fileName to be opened doesn't exist.
-or-
File Not Found

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to open the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Open is temporarily disabled.
-or-
The document can not be opened.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Opening was canceled by the user or by an API event callback.

#### Since

2013

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.OpenDocumentFile(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,Autodesk.Revit.DB.IOpenFromCloudCallback)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.OpenDocumentFile(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,Autodesk.Revit.DB.IOpenFromCloudCallback)`

#### Summary

Opens a document from disk or cloud.

#### Remarks

This method opens the document into memory but does not make it visible to the user in any way.
If the user currently has ownership of elements in this model and there is no local model on this machine,
Revit will post a warning.

#### Parameter `modelPath`

The file to be opened.

#### Parameter `openOptions`

Options for opening the file.

#### Parameter `openFromCloudCallback`

The interface implementation to use when opening a cloud document. Only used for opening cloud model.

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The modelPath to be opened is empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException`

Cannot open the local model and the central model in the same Revit session. You can close one to open the other in the same Revit session.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The model on the RevitServer is being accessed by other users.
-or-
The central model is locked by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Revit encountered serious errors while trying to open the central model.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.CorruptModelException`

There are too many corrupt elements to open this model.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

File cannot be opened in Revit LT because it was last saved in a version of Revit prior to 8.1.
-or-
File has an invalid extension. Try changing the file's extension and opening it again.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

The modelPath to be opened doesn't exist.
-or-
File Not Found

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to open the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Open is temporarily disabled.
-or-
The cloud model is not saved in current release of Revit.
-or-
The model is not allowed to access.
-or-
The document can not be opened.
-or-
Revit cannot save the transmitted model as a new central because it is already opened.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Opening was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.WrongUserException`

The local file is not owned by the current user, who therefore is not allowed to modify it.

#### Since

2019

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.OpenDocumentFile(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.OpenDocumentFile(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions)`

#### Summary

Opens a document from disk or cloud.

#### Remarks

This method opens the document into memory but does not make it visible to the user in any way.
If the user currently has ownership of elements in this model and there is no local model on this machine,
Revit will post a warning.

#### Parameter `modelPath`

The file to be opened.

#### Parameter `openOptions`

Options for opening the file.

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The modelPath to be opened is empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException`

Cannot open the local model and the central model in the same Revit session. You can close one to open the other in the same Revit session.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

The model on the RevitServer is being accessed by other users.
-or-
The central model is locked by another client.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Revit encountered serious errors while trying to open the central model.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.CorruptModelException`

There are too many corrupt elements to open this model.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

File cannot be opened in Revit LT because it was last saved in a version of Revit prior to 8.1.
-or-
File has an invalid extension. Try changing the file's extension and opening it again.
-or-
File was saved by an application that was not developed or licensed by Autodesk.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

The modelPath to be opened doesn't exist.
-or-
File Not Found

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to open the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Open is temporarily disabled.
-or-
The cloud model is not saved in current release of Revit.
-or-
The model is not allowed to access.
-or-
The document can not be opened.
-or-
Revit cannot save the transmitted model as a new central because it is already opened.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Opening was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.WrongUserException`

The local file is not owned by the current user, who therefore is not allowed to modify it.

#### Since

2013

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.IsValidThickness(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsValidThickness(System.Double)`

#### Summary

Checks if the input value is valid to be supplied as a thickness (for an extrusion, or blend, or wall layer, or similar geometric construct).

#### Remarks

This checks two conditions:
The value is greater than or equal to the minimum thickness allowed in Revit for these types of geometric constructs.

The value is less than or equal to the maximum length/distance allowed by Revit for elements.

#### Parameter `thickness`

The input value.

#### Returns

True if the input value is valid for thickness; false otherwise.

#### Since

2015

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.GetRevitServerNetworkHosts`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetRevitServerNetworkHosts`

#### Summary

Gets the list of all Revit Server Network hosts in current session.

#### Remarks

The list of Revit Server Network hosts is stored externally in the RSN[version].ini file.

#### Returns

An array of names of all Revit Server Network hosts in current session.

#### Since

2013

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.GetWorksharingCentralGUID(Autodesk.Revit.DB.ServerPath)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetWorksharingCentralGUID(Autodesk.Revit.DB.ServerPath)`

#### Summary

Gets the worksharing central GUID of the given server-based model.

#### Remarks

The given server-based model saved in a release prior to Revit 2013 did not have this GUID.
Only the given server-based model saved in Revit 2013 or later will be able to provide this value.

#### Parameter `serverModelPath`

The server-based model path.

#### Returns

The worksharing central GUID.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

The central model is missing.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

Thrown when the given model is not created in Revit 2013 or later release.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Since

2013

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.CopyModel(Autodesk.Revit.DB.ModelPath,System.String,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.CopyModel(Autodesk.Revit.DB.ModelPath,System.String,System.Boolean)`

#### Summary

Copies an existing model to a new file. Overwriting a file of the same name is allowed.

#### Parameter `sourceModelPath`

The path of the file-based or server-based source model.

#### Parameter `destFilePath`

The path of the destination file.

#### Parameter `overwrite`

True if the destination file can be overwritten; otherwise, false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given path sourceModelPath is a cloud path which is not supported in this method.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Access to the central model was denied. A possible reason is because the model was under maintenance.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

The central model is missing.
-or-
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.DirectoryNotFoundException`

Thrown when the directory of destination file doesn't exist.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentAlreadyExistsException`

The destination file exists and can't be overwritten.
-or-
destFilePath is pointing to a folder that already exists and cannot be deleted.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The Revit model specified by sourceModelPath doesn't exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

The destination file name includes one or more invalid characters.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The server-based central model could not be accessed
because of a network communication error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

An internal error happened on the server, please contact the server administrator.

#### Since

2012

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.PurgeReleasedAPIObjects`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.PurgeReleasedAPIObjects`

#### Summary

Explicitly purges all API objects that have been released but are still awaiting to be finalized

#### Remarks

Revit purges API objects automatically every time when command control returns from
an API application (an external command, event handler, etc.) back to Revit.
This is necessary because Revit does not allow API objects to be finalized when the
finalization is invoked from an outside thread (from the garbage collector, specifically).
This automatic purging is adequate in most scenarios. When an application uses a lot
of API objects during one single command though, it may be necessary or beneficial
to invoke an additional purge explicitly to free the deleted API objects from memory.

#### Since

2011

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.SetLibraryPaths(System.Collections.Generic.IDictionary{System.String,System.String})`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SetLibraryPaths(System.Collections.Generic.IDictionary{System.String,System.String})`

#### Summary

Sets path information identifying where Revit searches for content.

#### Remarks

The map that
is returned should contain a key that is purpose of the path, such as Material Libraries and the value
in the map is the fully qualified path to be used for that search path.

#### Parameter `paths`

The map of library paths.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.GetLibraryPaths`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetLibraryPaths`

#### Summary

Returns path information identifying where Revit searches for content.

#### Remarks

The map that
is returned contains a key that is purpose of the path, such as Material Libraries and the value
in the map is the fully qualified path that is used for that search path.

#### Returns

The map of library paths.

#### Since

2012

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.SetSystemsAnalysisWorkflows(System.Collections.Generic.IDictionary{System.String,System.String})`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SetSystemsAnalysisWorkflows(System.Collections.Generic.IDictionary{System.String,System.String})`

#### Summary

Sets name and path information identifying systems analysis workflow files.

#### Remarks

The map should be specified as a key that is the name of the systems analysis workflow,
and a value that is the path to the workflow file.

#### Parameter `paths`

The map of systems analysis workflows.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020.1

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.GetSystemsAnalysisWorkflows`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetSystemsAnalysisWorkflows`

#### Summary

Returns name and path information identifying systems analysis workflow files.

#### Remarks

The map that is returned contains a key that is the name of the systems analysis workflow,
and the value is the path to the workflow file.

#### Returns

The map of systems analysis workflows.

#### Since

2020.1

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.GetSystemsAnalysisWorkflowNames`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetSystemsAnalysisWorkflowNames`

#### Summary

Returns names for systems analysis workflows.

#### Remarks

The array that is returned contains the name of the systems analysis workflow,
in the order they are specified in Options.

#### Returns

An array of names of systems analysis workflows.

#### Since

2020.1

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.IsJournalPlaying`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsJournalPlaying`

#### Summary

Determines if the application is currently in journal playback mode.

#### Remarks

Determines if Revit is in the process of playing back a journal. It can be
used to help prevent any user interaction that may cause issues during playback.
For more information on Revit's journaling features contact the Autodesk Developer Network.

#### Returns

true if a journal is currently playing back, false otherwise.

#### Since

2020

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.WriteJournalComment(System.String,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.WriteJournalComment(System.String,System.Boolean)`

#### Summary

Writes a comment to the Revit journal file.

#### Parameter `comment`

Text for journal comment.

#### Parameter `timeStamp`

If a time stamp should be included in the journal comment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.GetFailureDefinitionRegistry`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetFailureDefinitionRegistry`

#### Summary

Returns the instance of FailureDefinitionRegistry.

#### Returns

The instance of FailureDefinitionRegistry.

#### Since

2011

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.RegisterFailuresProcessor(Autodesk.Revit.DB.IFailuresProcessor)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.RegisterFailuresProcessor(Autodesk.Revit.DB.IFailuresProcessor)`

#### Summary

Replaces Revit's default user interface (if present) with alternative handling for all warnings and errors
(including those not generated by your application) for the rest of the Revit session;
if your application is not prepared to respond to all warnings and errors,
consider use of IFailuresPreprocessor (in your opened Transaction)
or the FailuresProcessing event instead of this interface.

#### Remarks

If there is previously registered Failures Processor, it gets discarded.
If you opt to register a FailuresProcessor for Revit, your processor will become the default error handler
for all Revit errors for the session. The standard Revit error dialog will not appear.

#### Parameter `processor`

Instance of Failures Processor to be used by the Revit Application.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.NewProjectDocument(Autodesk.Revit.DB.UnitSystem)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.NewProjectDocument(Autodesk.Revit.DB.UnitSystem)`

#### Summary

Creates a new project document with no template file specified.

#### Parameter `unitSystem`

The unit system used for the new document.

#### Returns

The newly created document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.OpenIFCDocument(System.String,Autodesk.Revit.DB.IFC.IFCImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.OpenIFCDocument(System.String,Autodesk.Revit.DB.IFC.IFCImportOptions)`

#### Summary

Opens an IFC document from disk using custom options.

#### Parameter `fileName`

The IFC file to be opened.

#### Parameter `importOptions`

The options for this import.

#### Returns

The newly created document containing the IFC file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If 'fileName' is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

If the file specified by 'fileName' cannot be found.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If Revit is missing document templates or if the file cannot be opened.

#### Since

2015

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.OpenIFCDocument(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.OpenIFCDocument(System.String)`

#### Summary

Opens an IFC document from disk using default options.

#### Parameter `fileName`

The IFC file to be opened.

#### Returns

The newly created document containing the IFC file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If 'fileName' is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

If `null` is passed as 'fileName'
-or-
A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

If the file specified by 'fileName' cannot be found.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If Revit is missing document templates or if the file cannot be opened.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.AllowNavigationDuringRedraw`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.AllowNavigationDuringRedraw`

#### Summary

Checks whether or not the navigation during redraw is enabled, and enable or disable it.

#### Since

2016

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.LoginUserId`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.LoginUserId`

#### Summary

The user id of the user currently logged in. The user id will be empty
if the user is not logged in.

#### Remarks

The internal id of Autodesk ID that the current user has logged in to A360.
This user id is in human unrecognizable form. In conjunction with the Store Entitlement REST
API, a publisher of Autodesk Exchange Store app can verify if the current user has purchased
their app from the store. For more information about Store Entitlement API, please refer
to www.autodesk.com/developapps.

#### Since

2016

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsLoggedIn`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsLoggedIn`

#### Summary

Checks if the user is logged in from this session to their Autodesk account.

#### Since

2016

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.BackgroundColor`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.BackgroundColor`

#### Summary

The background color to use for model views in this session.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The backgroundColor argument does not represent a valid color.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentUsersAddinsDataFolderPath`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentUsersAddinsDataFolderPath`

#### Summary

Path to AddinsData folder for the current user.

#### Remarks

Similar to C:\Users\[UserName]\AppData\Roaming\Autodesk\[ProductType]\[ReleaseName]\AddinsData

#### Since

2019

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentUsersDataFolderPath`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentUsersDataFolderPath`

#### Summary

Path to data folder for the current user.

#### Remarks

Similar to C:\Users\[UserName]\AppData\Roaming\Autodesk\[ProductType]\[ReleaseName]

#### Since

2019

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.AllUsersAddinsLocation`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.AllUsersAddinsLocation`

#### Summary

The folder location for .addin files for all users.

#### Since

2014

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentUserAddinsLocation`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentUserAddinsLocation`

#### Summary

The folder location for .addin files for the current user.

#### Since

2014

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.MinimumThickness`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.MinimumThickness`

#### Summary

The minimum thickness allowed in Revit for a variety of geometric constructs. These include blends, extrusions, and wall layers.

#### Remarks

Do not use this value for any purpose other than its intended purpose.
If you want to check for valid thickness value, use the function isValidThickness.

#### Since

2015

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.ShortCurveTolerance`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ShortCurveTolerance`

#### Summary

The enforced minimum length for any curve created by Revit.

#### Since

2014

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentRevitServerAccelerator`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentRevitServerAccelerator`

#### Summary

Current Revit Server accelerator.

#### Remarks

Revit connects with Revit Server hosts via current Revit Server accelerator.
If current Revit Server accelerator is not set, this will be an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The server name can not be used to construct a well formed Uri string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: When setting the value, Revit failed to write current Revit Server accelerator to the user environment.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsInfrastructureEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsInfrastructureEnabled`

#### Summary

Checks whether or not infrastructure discipline is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2021.1

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsRouteAnalysisEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsRouteAnalysisEnabled`

#### Summary

Checks whether or not route analysis is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2020

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsPipingAnalysisEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsPipingAnalysisEnabled`

#### Summary

Checks whether or not piping analysis is enabled, and enable or disable it.

#### Remarks

Enabling piping analysis will not take effect unless the piping discipline is also enabled.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsElectricalAnalysisEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsElectricalAnalysisEnabled`

#### Summary

Checks whether or not electrical analysis is enabled, and enable or disable it.

#### Remarks

Enabling electrical analysis will not take effect unless the electrical discipline is also enabled.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsMechanicalAnalysisEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsMechanicalAnalysisEnabled`

#### Summary

Checks whether or not mechanical analysis is enabled, and enable or disable it.

#### Remarks

Enabling mechanical analysis will not take effect unless the mechanical discipline is also enabled.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsPipingEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsPipingEnabled`

#### Summary

Checks whether or not the piping discipline is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsElectricalEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsElectricalEnabled`

#### Summary

Checks whether or not the electrical discipline is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsMechanicalEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsMechanicalEnabled`

#### Summary

Checks whether or not the mechanical discipline is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsStructuralAnalysisEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsStructuralAnalysisEnabled`

#### Summary

Checks whether or not the structural analysis is enabled, and enable or disable it.

#### Remarks

When structural analysis is disabled the structural analytical model will not be updated
automatically by Revit. Enabling structural analysis will not take effect unless the structure discipline is also enabled.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsEnergyAnalysisEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsEnergyAnalysisEnabled`

#### Summary

Checks whether or not energy analysis is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsMassingEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsMassingEnabled`

#### Summary

Checks whether or not the massing and site tools are enabled, and enable or disable them.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsSystemsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsSystemsEnabled`

#### Summary

Checks whether or not any systems disciplines (mechanical, electrical, or piping) are enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsStructureEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsStructureEnabled`

#### Summary

Checks whether or not the structure discipline is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsArchitectureEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsArchitectureEnabled`

#### Summary

Checks whether or not the architecture discipline is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.AngleTolerance`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.AngleTolerance`

#### Summary

Angle tolerance.

#### Remarks

Value is in radians.
Two angle measurements closer than this value are considered identical.
Do not use this value for any purpose other than its intended purpose,
which is to check if two angles are the same within this tolerance value.
Do not use this value to set the value of an angle.
Doing so will result in unstable behavior.

#### Since

2015

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.VertexTolerance`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.VertexTolerance`

#### Summary

Vertex tolerance.

#### Remarks

Two points within this distance are considered coincident.
Do not use this value for any purpose other than its intended purpose,
which is to check if two points are the same within this tolerance value.
Do not use this value to set the distance between two points.
Doing so will result in unstable behavior.

#### Since

2012

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.DefaultViewDiscipline`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DefaultViewDiscipline`

#### Summary

The view discipline that will be applied to new views by default.

#### Remarks

This view discipline may be overridden by a view template when a view template is also applied to new views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This functionality is not available in Revit LT.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.ShowGraphicalWarningHangerDisconnects`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ShowGraphicalWarningHangerDisconnects`

#### Summary

Whether or not to show the graphical warnings for Fabrication Hanger disconnects.

#### Since

2016

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.ShowGraphicalOpenEndsAreaBasedLoadBoundaryDisconnects`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ShowGraphicalOpenEndsAreaBasedLoadBoundaryDisconnects`

#### Summary

Whether or not to show the graphical open ends for Area Based Load Boundary disconnects.

#### Since

2023

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.ShowGraphicalWarningElectricalDisconnects`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ShowGraphicalWarningElectricalDisconnects`

#### Summary

Whether or not to show the graphical warnings for Electrical disconnects.

#### Since

2012

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.ShowGraphicalWarningCableTrayConduitDisconnects`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ShowGraphicalWarningCableTrayConduitDisconnects`

#### Summary

Whether or not to show the graphical warnings for CTC disconnects.

#### Since

2012

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.ShowGraphicalWarningPipeDisconnects`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ShowGraphicalWarningPipeDisconnects`

#### Summary

Whether or not to show the graphical warnings for Pipe disconnects.

#### Since

2012

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.ShowGraphicalWarningDuctDisconnects`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ShowGraphicalWarningDuctDisconnects`

#### Summary

Whether or not to show the graphical warnings for duct disconnects.

#### Since

2012

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.ImportIFCCategoryTable`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ImportIFCCategoryTable`

#### Summary

Full path to the file that defines IFC entity to Revit category mappings for IFC import.

#### Since

2015

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.ExportIFCCategoryTable`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ExportIFCCategoryTable`

#### Summary

Full path to the file that defines Revit category to IFC entity mappings for IFC export.

#### Since

2015

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.DefaultIFCProjectTemplate`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DefaultIFCProjectTemplate`

#### Summary

Full path to the default template file for new IFC project documents.
It may be empty, in which case the DefaultProjectTemplate should be used.

#### Since

2015

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.DefaultProjectTemplate`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DefaultProjectTemplate`

#### Summary

Full path to the default template file for new project documents.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.SystemsAnalysisWorkfilesRootPath`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SystemsAnalysisWorkfilesRootPath`

#### Summary

Root path for systems analysis workfiles

#### Since

2020

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.PointCloudsRootPath`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.PointCloudsRootPath`

#### Summary

Root path for point cloud files.

#### Since

2016

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.FamilyTemplatePath`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FamilyTemplatePath`

#### Summary

Default path for family template files.

#### Since

2011

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.SubVersionNumber`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SubVersionNumber`

#### Summary

The minor version number of Revit

#### Remarks

SubVersionNumber of Revit may have additional APIs and functionality not available in the standard customer releases.
Add-ins written to support standard Revit releases should be compatible with SubVersionNumber releases,
but add-ins written specifically targeting new features in SubVersionNumber releases would not be compatible with the standard releases.

#### Since

2018

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.Username`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.Username`

#### Summary

Gets the user name for the current Revit session.

#### Since

2012

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.Revit.DB.AddInId,Autodesk.Revit.DB.Document,Autodesk.ADPDesktopSDK.Facets.Core)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.Revit.DB.AddInId,Autodesk.Revit.DB.Document,Autodesk.ADPDesktopSDK.Facets.Core)`

#### Summary

Sends ADP Core facet with analytics data, DB::AddInId and DB::Document to the Revit for processing and sending to the ADP data lake.

#### Parameter `addInId`

DB::AddInId addInId with data for collection

#### Parameter `document`

DB::Document document with data for collection

#### Parameter `coreFacet`

Container for analytics data

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2022

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.Revit.DB.Document,Autodesk.ADPDesktopSDK.Facets.Core)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.Revit.DB.Document,Autodesk.ADPDesktopSDK.Facets.Core)`

#### Summary

Sends ADP Core facet with analytics data, and DB::Document to the Revit for processing and sending to the ADP data lake.

#### Parameter `document`

DB::Document addInId with data for collection

#### Parameter `coreFacet`

Container for analytics data

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2022

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.Revit.DB.AddInId,Autodesk.ADPDesktopSDK.Facets.Core)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.Revit.DB.AddInId,Autodesk.ADPDesktopSDK.Facets.Core)`

#### Summary

Sends ADP Core facet with analytics data, and DB::AddInId to the Revit for processing and sending to the ADP data lake.

#### Parameter `addInId`

DB::AddInId addInId with data for collection

#### Parameter `coreFacet`

Container for analytics data

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2022

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.ADPDesktopSDK.Facets.Core)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.ADPDesktopSDK.Facets.Core)`

#### Summary

Sends ADP Core facet with analytics data to the Revit for processing and sending to the ADP data lake.

#### Parameter `coreFacet`

Container for analytics data

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2022

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.PostInHouseDbgInfo(System.String,System.String,System.String,System.Int32,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.PostInHouseDbgInfo(System.String,System.String,System.String,System.Int32,System.String)`

#### Summary

Records a message in the journal file.

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.PostInHouseDbgWarn(System.String,System.String,System.String,System.Int32,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.PostInHouseDbgWarn(System.String,System.String,System.String,System.Int32,System.String)`

#### Summary

Posts a user-visible warning (when UI is present and runs in the in-house mode) or just records it in the journal file otherwise.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.ActiveAddInId`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ActiveAddInId`

#### Summary

Retrieves the Id of the currently running external application.

#### Remarks

The application can be either a UI application, DB application, or an external command. If no addin is active, this property will return `null` .
If an event handler is currently being executed, the returned value will be the Id of the application or command in which the event handler was registered.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.SharedParametersFilename`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SharedParametersFilename`

#### Summary

Contains the fully qualified path to a shared parameters file.

#### Remarks

This path can be read and set via this property. By default Autodesk Revit does not have
a shared parameters file so this property must be set before access is made to the shared parameters
file object otherwise an exception will be thrown.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.Product`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.Product`

#### Summary

The product type for the current session of Revit.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.Language`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.Language`

#### Summary

The language used in the current session of Revit.

#### Remarks

Use this property to determine the language used by Revit; this can allow your application to load the appropriate resources.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.Cities`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.Cities`

#### Summary

Returns a set of all the known city locations within Revit.

#### Remarks

Each city has information about longitude, latitude etc.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.VersionBuild`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.VersionBuild`

#### Summary

Returns the internal build number of the Autodesk Revit application.

#### Remarks

This property can be used by your application to find the version of Autodesk Revit
against which your application is running. Based on this information your application
can report if it is able to work correctly with that version of Autodesk Revit.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.VersionNumber`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.VersionNumber`

#### Summary

Return the primary version of the Revit application.

#### Remarks

This property can be used by your application to find the version of Revit
against which your application is running. Based on this information your application
can report if it is able to work correctly with that version of Revit.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.VersionName`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.VersionName`

#### Summary

Returns the name of the Revit application.

#### Remarks

This property can be used by your application to find the version of Revit
against which your application is running. Based on this information your application
can report if it is able to work correctly with that version of Revit.

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.OpenSharedParameterFile`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.OpenSharedParameterFile`

#### Summary

Enables access to shared parameter groups and definitions that are maintained on disk.

#### Returns

An object that represents a shared parameters file that exists on disk. Returns `null` if the file does not exist.

#### Remarks

This function is used to return an object that represents a Revit shared parameters file
Revit can use only one shared parameters file at one time. The filename
for the shared parameters file can be set in the Application.SharedParametersFilename property.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.Create`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.Create`

#### Summary

Provides an object that can be used to create new instances of Autodesk Revit API objects.

#### Remarks

The Create property returns an object that is used to create application wide utility
and geometric objects within the Autodesk Revit API, such as arrays, sets, lines. This object
should be used when you wish to create an object within the Autodesk Revit application memory,
rather than your own application's memory. If you are performing your own memory management
techniques then it is advisable to create any utility objects via the Create object. For example:
Instead of Dim set As New Autodesk_Revit_ElementSet do Set set = application.Create.NewElementSet()

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.RecordingJournalFilename`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.RecordingJournalFilename`

#### Summary

Retrieve the name of the journal file the Revit is currently recording to.

#### Remarks

As Revit operates it keeps a log of operations that the user performs
within a file, known as a journal file. These files provide information
about the actions performed in a session and the state of Revit when a problem occurs.
These files are included during error reporting to Autodesk.

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.ExtractPartAtomFromFamilyFile(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ExtractPartAtomFromFamilyFile(System.String,System.String)`

#### Summary

Writes a PartAtom XML from the contents of a family file.

#### Parameter `familyFilePath`

The family file to be processed.

#### Parameter `xmlFilePath`

The xml file to be saved.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If 'familyFilePath' or 'xmlFilePath' is `null` or an empty string or if the family file doesn't exist on disk.

#### Remarks

If there is a TXT type catalog next to the family file (a TXT file with the same name as the RFA file),
the function will read it as well and process its contents into PartAtom.
To extract a PartAtom XML from a family loaded into a document in session, use Family.ExtractPartAtom().

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.NewFamilyDocument(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.NewFamilyDocument(System.String)`

#### Summary

New family document, including family, titleblock, and annotation symbol

#### Parameter `templateFileName`

The template file name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If 'templateFileName' is `null` or an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If the new family document cannot be created.

#### Remarks

This command corresponds to File->New->Family.../TitleBlock.../Annotation Symbol....

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.NewProjectTemplateDocument(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.NewProjectTemplateDocument(System.String)`

#### Summary

New project template document

#### Parameter `templateFilename`

The template file name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If 'templateFileName' is `null` or an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If the project template document cannot be created.

#### Remarks

This command corresponds to New->Project->Project Template command in the user-interface.

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.NewProjectDocument(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.NewProjectDocument(System.String)`

#### Summary

New project document

#### Parameter `templateFileName`

The template file name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If 'templateFileName' is `null` or an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If the new project document cannot be created.

#### Remarks

This command corresponds to New->Project command in the user-interface.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.Documents`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.Documents`

#### Summary

Returns a set of documents within Revit.

#### Remarks

This property can be used for the user to find all the document inside Revit.
