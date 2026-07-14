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
Shard: 50
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `E:Autodesk.Revit.ApplicationServices.Application.GetFolderContentsRequested`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.GetFolderContentsRequested`

#### Summary

Subscribe to the GetFolderContentsRequested event to be notified immediately when Revit requests for a list of cloud folder contents, containing subfolders and cloud models.

#### Remarks

This event is raised to get information regarding Folder Contents within ForgeDM (Collaborate add-in).

### `E:Autodesk.Revit.ApplicationServices.Application.GetProjectsRequested`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.GetProjectsRequested`

#### Summary

Subscribe to the GetProjectsRequested event to be notified immediately when Revit requests for a list of cloud projects.

#### Remarks

This event is raised to get information regarding Projects within ForgeDM (Collaborate add-in).

### `E:Autodesk.Revit.ApplicationServices.Application.GetHubsRequested`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.GetHubsRequested`

#### Summary

Subscribe to the GetHubsRequested event to be notified immediately when Revit requests for a list of cloud hubs.

#### Remarks

This event is raised to get information regarding Hubs within ForgeDM (Collaborate add-in).

### `E:Autodesk.Revit.ApplicationServices.Application.PositionsSaved`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.PositionsSaved`

#### Summary

Subscribe to the PositionsSaved event to be notified immediately after linked symbols Positions (Shared Coordinates) saved during "Save Positions' operations.

#### Remarks

This event is only raised for shared coordinates changes saved to Revit links.
Users may not change the document in the handler for this event.
It is NOT recommended to do any time-consuming work when handling PositionsSaved event.

#### Since

2018

### `E:Autodesk.Revit.ApplicationServices.Application.ElementTypeDuplicated`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ElementTypeDuplicated`

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

### `E:Autodesk.Revit.ApplicationServices.Application.ElementTypeDuplicating`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ElementTypeDuplicating`

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

### `E:Autodesk.Revit.ApplicationServices.Application.FamilyLoadedIntoDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.FamilyLoadedIntoDocument`

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

### `E:Autodesk.Revit.ApplicationServices.Application.FamilyLoadingIntoDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.FamilyLoadingIntoDocument`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentWorksharingEnabled`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentWorksharingEnabled`

#### Summary

Subscribe to the DocumentWorksharingEnabled event to be notified when a document has become workshared.

#### Remarks

This event is raised when Revit has just enabled worksharing in the document.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

#### Since

2015

### `E:Autodesk.Revit.ApplicationServices.Application.ProgressChanged`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ProgressChanged`

#### Summary

Subscribe to the ProgressChanged event to be notified when an operation in Revit has progress bar data available.

#### Remarks

Handlers of this event may use the `M:Autodesk.Revit.DB.Events.ProgressChangedEventArgs.Cancel` method to cancel the operation tracked by the progress bar.
Users may not change the document in the handler for this event.
Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException` will be thrown if any document-modifying method is called during this event's handler.

#### Since

2013

### `E:Autodesk.Revit.ApplicationServices.Application.WorksharedOperationProgressChanged`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.WorksharedOperationProgressChanged`

#### Summary

Subscribe to the WorksharedOperationProgressChanged to be notified when progress has changed during Collaboration for Revit's workshared operations: open model and synchronize with central.

#### Remarks

This event is only supported for Collaboration for Revit and will not be raised for those operations occurring in local-worksharing and Revit Server workflow.
Users may not change the document in the handler for this event.
It is NOT recommended to do any time-consuming work when handling WorksharedOperationProgressChanged event. This can increase workshared operation time."
Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException` will be thrown if any document-modifying method is called during this event's handler.

#### Since

2017 Subscription Update

### `E:Autodesk.Revit.ApplicationServices.Application.LinkedResourceOpened`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.LinkedResourceOpened`

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

### `E:Autodesk.Revit.ApplicationServices.Application.LinkedResourceOpening`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.LinkedResourceOpening`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentSynchronizedWithCentral`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentSynchronizedWithCentral`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentSynchronizingWithCentral`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentSynchronizingWithCentral`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentOpened`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentOpened`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentOpening`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentOpening`

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

### `E:Autodesk.Revit.ApplicationServices.Application.ViewsExportedByContext`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ViewsExportedByContext`

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

### `E:Autodesk.Revit.ApplicationServices.Application.ViewsExportingByContext`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ViewsExportingByContext`

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

### `E:Autodesk.Revit.ApplicationServices.Application.ViewExported`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ViewExported`

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

### `E:Autodesk.Revit.ApplicationServices.Application.ViewExporting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ViewExporting`

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

### `E:Autodesk.Revit.ApplicationServices.Application.FileExported`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.FileExported`

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

### `E:Autodesk.Revit.ApplicationServices.Application.FileExporting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.FileExporting`

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

### `E:Autodesk.Revit.ApplicationServices.Application.FileImported`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.FileImported`

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

### `E:Autodesk.Revit.ApplicationServices.Application.FileImporting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.FileImporting`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentCreated`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentCreated`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentCreating`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentCreating`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentClosed`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentClosed`

#### Summary

Subscribe to the DocumentClosing event to be notified when Revit is just about to close a document.

#### Remarks

This event is raised immediately after Revit has finished closing a document.
It is raised even when document closing failed or was cancelled (during DocumentClosing event).

This event is not cancellable, for the process of closing document has already been finished.

The document cannot be modified because the corresponding object does not exist anymore.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentClosing`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentClosing`

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

### `E:Autodesk.Revit.ApplicationServices.Application.ViewPrinted`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ViewPrinted`

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

### `E:Autodesk.Revit.ApplicationServices.Application.ViewPrinting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ViewPrinting`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentPrinted`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentPrinted`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentPrinting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentPrinting`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentSavedAs`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentSavedAs`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentSavingAs`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentSavingAs`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentSaved`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentSaved`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentSaving`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentSaving`

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

### `E:Autodesk.Revit.ApplicationServices.Application.FailuresProcessing`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.FailuresProcessing`

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

### `E:Autodesk.Revit.ApplicationServices.Application.DocumentChanged`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.DocumentChanged`

#### Summary

Subscribe to the DocumentChanged event to be notified when Revit document has changed.

#### Remarks

This event is raised whenever a Revit transaction is either committed, undone or redone.
This is a readonly event, designed to allow you to keep external data in synch with the state of the
Revit database.
To update the Revit database in response to changes in elements, use the IUpdater framework.

#### Since

2011

### `E:Autodesk.Revit.ApplicationServices.Application.ApplicationInitialized`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.Application.ApplicationInitialized`

#### Summary

Subscribe to this event to get notified after the Revit application has been initialized

#### Remarks

The event is raised after Revit was launched as fully initialized,
including initialization of external applications.

#### Since

2013

### `M:Autodesk.Revit.ApplicationServices.Application.EnsureGatewayClientInitialized`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.EnsureGatewayClientInitialized`

#### Summary

Indicates if the Gateway client is initialized using the global endpoint or not.

#### Remarks

This method will try to initialize the gateway client if the client isn't already set up.

#### Returns

Returns true if the Gateway client is initialized, otherwise returns false.

### `M:Autodesk.Revit.ApplicationServices.Application.IsCloudCollaborationAddonLoaded`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsCloudCollaborationAddonLoaded`

#### Summary

Indicates if application loaded cloud addons correctly

#### Returns

Returns true if application loaded cloud addons correctly

#### Since

2020

### `M:Autodesk.Revit.ApplicationServices.Application.HasCloudModelEntitlement`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.HasCloudModelEntitlement`

#### Summary

Indicates if the current user has the cloud model entitlement (Cloud Model for Revit) or not.

#### Returns

Returns true if the current user has the cloud model entitlement, otherwise returns false.

#### Since

2019.2

### `M:Autodesk.Revit.ApplicationServices.Application.HasWorksharedCloudModelEntitlement`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.HasWorksharedCloudModelEntitlement`

#### Summary

Indicates if the current user has the workshared cloud model entitlement (BIM 360 Docs or Autodesk Docs Design) or not.

#### Returns

Returns true if the current user has the workshared cloud model entitlement, otherwise returns false.

#### Since

2019.2

### `M:Autodesk.Revit.ApplicationServices.Application.GetCloudGUIDsByCloudModelInfo(System.String,System.String,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.GetCloudGUIDsByCloudModelInfo(System.String,System.String,System.String,System.String)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.HasBIM360Accounts`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.HasBIM360Accounts`

#### Summary

Indicates if the current login user has any BIM 360 Docs or Autodesk Docs accounts or not.

#### Returns

Returns true if the current login user has any BIM 360 Docs or Autodesk Docs accounts, otherwise returns false.

### `M:Autodesk.Revit.ApplicationServices.Application.IsOnSubscription`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsOnSubscription`

#### Summary

Indicates if this Revit is on subscription or not.

#### Returns

Returns true if this Revit is on subscription, otherwise returns false.

#### Since

2019

### `M:Autodesk.Revit.ApplicationServices.Application.OpenCloudCentralModel(Autodesk.Revit.DB.ModelPath,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.OpenCloudCentralModel(Autodesk.Revit.DB.ModelPath,System.Boolean)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.OpenCloudSharedModel(System.String,System.Guid,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.OpenCloudSharedModel(System.String,System.Guid,System.Guid)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.SendAdpData(System.String,Autodesk.Revit.DB.Document,Autodesk.Revit.DB.AddInId)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.SendAdpData(System.String,Autodesk.Revit.DB.Document,Autodesk.Revit.DB.AddInId)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.IsPreviewRelease`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsPreviewRelease`

#### Summary

Checks whether or not the Revit is preview release version.

#### Returns

True if it is preview release, false otherwise.

#### Since

2020

### `M:Autodesk.Revit.ApplicationServices.Application.CreateJournalHint(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.CreateJournalHint(System.String,System.String)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.ReadRevitIniInteger(System.String,System.String,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.ReadRevitIniInteger(System.String,System.String,System.Int32)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.WriteRevitIniString(System.String,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.WriteRevitIniString(System.String,System.String,System.String)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.ReadRevitIniString(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.ReadRevitIniString(System.String,System.String)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.GetIniVarString(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.GetIniVarString(System.String,System.String)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.IsFeatureEnabledInLaunchDarkly(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsFeatureEnabledInLaunchDarkly(System.String)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.IsDebugModeSet(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsDebugModeSet(System.String)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.GetAssets(Autodesk.Revit.DB.Visual.AssetType)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.GetAssets(Autodesk.Revit.DB.Visual.AssetType)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.UpdateRenderAppearanceLibrary`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.UpdateRenderAppearanceLibrary`

#### Summary

Updates the stored render appearance library, giving the Revit session access to any new RPC content.

#### Since

2014

### `M:Autodesk.Revit.ApplicationServices.Application.OpenDocumentFile(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.OpenDocumentFile(System.String)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.OpenDocumentFile(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,Autodesk.Revit.DB.IOpenFromCloudCallback)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.OpenDocumentFile(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,Autodesk.Revit.DB.IOpenFromCloudCallback)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.OpenDocumentFile(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.OpenDocumentFile(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.IsValidThickness(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsValidThickness(System.Double)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.GetRevitServerNetworkHosts`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.GetRevitServerNetworkHosts`

#### Summary

Gets the list of all Revit Server Network hosts in current session.

#### Remarks

The list of Revit Server Network hosts is stored externally in the RSN[version].ini file.

#### Returns

An array of names of all Revit Server Network hosts in current session.

#### Since

2013

### `M:Autodesk.Revit.ApplicationServices.Application.GetWorksharingCentralGUID(Autodesk.Revit.DB.ServerPath)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.GetWorksharingCentralGUID(Autodesk.Revit.DB.ServerPath)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.CopyModel(Autodesk.Revit.DB.ModelPath,System.String,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.CopyModel(Autodesk.Revit.DB.ModelPath,System.String,System.Boolean)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.PurgeReleasedAPIObjects`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.PurgeReleasedAPIObjects`

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

### `M:Autodesk.Revit.ApplicationServices.Application.SetLibraryPaths(System.Collections.Generic.IDictionary{System.String,System.String})`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.SetLibraryPaths(System.Collections.Generic.IDictionary{System.String,System.String})`

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

### `M:Autodesk.Revit.ApplicationServices.Application.GetLibraryPaths`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.GetLibraryPaths`

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

### `M:Autodesk.Revit.ApplicationServices.Application.SetSystemsAnalysisWorkflows(System.Collections.Generic.IDictionary{System.String,System.String})`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.SetSystemsAnalysisWorkflows(System.Collections.Generic.IDictionary{System.String,System.String})`

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

### `M:Autodesk.Revit.ApplicationServices.Application.GetSystemsAnalysisWorkflows`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.GetSystemsAnalysisWorkflows`

#### Summary

Returns name and path information identifying systems analysis workflow files.

#### Remarks

The map that is returned contains a key that is the name of the systems analysis workflow,
and the value is the path to the workflow file.

#### Returns

The map of systems analysis workflows.

#### Since

2020.1

### `M:Autodesk.Revit.ApplicationServices.Application.GetSystemsAnalysisWorkflowNames`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.GetSystemsAnalysisWorkflowNames`

#### Summary

Returns names for systems analysis workflows.

#### Remarks

The array that is returned contains the name of the systems analysis workflow,
in the order they are specified in Options.

#### Returns

An array of names of systems analysis workflows.

#### Since

2020.1

### `M:Autodesk.Revit.ApplicationServices.Application.IsJournalPlaying`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsJournalPlaying`

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

### `M:Autodesk.Revit.ApplicationServices.Application.WriteJournalComment(System.String,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.WriteJournalComment(System.String,System.Boolean)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.GetFailureDefinitionRegistry`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.GetFailureDefinitionRegistry`

#### Summary

Returns the instance of FailureDefinitionRegistry.

#### Returns

The instance of FailureDefinitionRegistry.

#### Since

2011

### `M:Autodesk.Revit.ApplicationServices.Application.RegisterFailuresProcessor(Autodesk.Revit.DB.IFailuresProcessor)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.RegisterFailuresProcessor(Autodesk.Revit.DB.IFailuresProcessor)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.NewProjectDocument(Autodesk.Revit.DB.UnitSystem)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.NewProjectDocument(Autodesk.Revit.DB.UnitSystem)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.OpenIFCDocument(System.String,Autodesk.Revit.DB.IFC.IFCImportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.OpenIFCDocument(System.String,Autodesk.Revit.DB.IFC.IFCImportOptions)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.OpenIFCDocument(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.OpenIFCDocument(System.String)`

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

### `P:Autodesk.Revit.ApplicationServices.Application.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.ApplicationServices.Application.AllowNavigationDuringRedraw`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.AllowNavigationDuringRedraw`

#### Summary

Checks whether or not the navigation during redraw is enabled, and enable or disable it.

#### Since

2016

### `P:Autodesk.Revit.ApplicationServices.Application.LoginUserId`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.LoginUserId`

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

### `P:Autodesk.Revit.ApplicationServices.Application.IsLoggedIn`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsLoggedIn`

#### Summary

Checks if the user is logged in from this session to their Autodesk account.

#### Since

2016

### `P:Autodesk.Revit.ApplicationServices.Application.BackgroundColor`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.BackgroundColor`

#### Summary

The background color to use for model views in this session.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The backgroundColor argument does not represent a valid color.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.ApplicationServices.Application.CurrentUsersAddinsDataFolderPath`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.CurrentUsersAddinsDataFolderPath`

#### Summary

Path to AddinsData folder for the current user.

#### Remarks

Similar to C:\Users\[UserName]\AppData\Roaming\Autodesk\[ProductType]\[ReleaseName]\AddinsData

#### Since

2019

### `P:Autodesk.Revit.ApplicationServices.Application.CurrentUsersDataFolderPath`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.CurrentUsersDataFolderPath`

#### Summary

Path to data folder for the current user.

#### Remarks

Similar to C:\Users\[UserName]\AppData\Roaming\Autodesk\[ProductType]\[ReleaseName]

#### Since

2019

### `P:Autodesk.Revit.ApplicationServices.Application.AllUsersAddinsLocation`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.AllUsersAddinsLocation`

#### Summary

The folder location for .addin files for all users.

#### Since

2014

### `P:Autodesk.Revit.ApplicationServices.Application.CurrentUserAddinsLocation`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.CurrentUserAddinsLocation`

#### Summary

The folder location for .addin files for the current user.

#### Since

2014

### `P:Autodesk.Revit.ApplicationServices.Application.MinimumThickness`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.MinimumThickness`

#### Summary

The minimum thickness allowed in Revit for a variety of geometric constructs. These include blends, extrusions, and wall layers.

#### Remarks

Do not use this value for any purpose other than its intended purpose.
If you want to check for valid thickness value, use the function isValidThickness.

#### Since

2015

### `P:Autodesk.Revit.ApplicationServices.Application.ShortCurveTolerance`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.ShortCurveTolerance`

#### Summary

The enforced minimum length for any curve created by Revit.

#### Since

2014

### `P:Autodesk.Revit.ApplicationServices.Application.CurrentRevitServerAccelerator`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.CurrentRevitServerAccelerator`

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

### `P:Autodesk.Revit.ApplicationServices.Application.IsInfrastructureEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsInfrastructureEnabled`

#### Summary

Checks whether or not infrastructure discipline is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2021.1

### `P:Autodesk.Revit.ApplicationServices.Application.IsRouteAnalysisEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsRouteAnalysisEnabled`

#### Summary

Checks whether or not route analysis is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2020

### `P:Autodesk.Revit.ApplicationServices.Application.IsPipingAnalysisEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsPipingAnalysisEnabled`

#### Summary

Checks whether or not piping analysis is enabled, and enable or disable it.

#### Remarks

Enabling piping analysis will not take effect unless the piping discipline is also enabled.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.Application.IsElectricalAnalysisEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsElectricalAnalysisEnabled`

#### Summary

Checks whether or not electrical analysis is enabled, and enable or disable it.

#### Remarks

Enabling electrical analysis will not take effect unless the electrical discipline is also enabled.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.Application.IsMechanicalAnalysisEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsMechanicalAnalysisEnabled`

#### Summary

Checks whether or not mechanical analysis is enabled, and enable or disable it.

#### Remarks

Enabling mechanical analysis will not take effect unless the mechanical discipline is also enabled.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.Application.IsPipingEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsPipingEnabled`

#### Summary

Checks whether or not the piping discipline is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.Application.IsElectricalEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsElectricalEnabled`

#### Summary

Checks whether or not the electrical discipline is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.Application.IsMechanicalEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsMechanicalEnabled`

#### Summary

Checks whether or not the mechanical discipline is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.Application.IsStructuralAnalysisEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsStructuralAnalysisEnabled`

#### Summary

Checks whether or not the structural analysis is enabled, and enable or disable it.

#### Remarks

When structural analysis is disabled the structural analytical model will not be updated
automatically by Revit. Enabling structural analysis will not take effect unless the structure discipline is also enabled.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.Application.IsEnergyAnalysisEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsEnergyAnalysisEnabled`

#### Summary

Checks whether or not energy analysis is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.Application.IsMassingEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsMassingEnabled`

#### Summary

Checks whether or not the massing and site tools are enabled, and enable or disable them.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.Application.IsSystemsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsSystemsEnabled`

#### Summary

Checks whether or not any systems disciplines (mechanical, electrical, or piping) are enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.Application.IsStructureEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsStructureEnabled`

#### Summary

Checks whether or not the structure discipline is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.Application.IsArchitectureEnabled`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.IsArchitectureEnabled`

#### Summary

Checks whether or not the architecture discipline is enabled, and enable or disable it.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The current product type is not ProductType.Revit and discipline controls are not enabled.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.Application.AngleTolerance`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.AngleTolerance`

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

### `P:Autodesk.Revit.ApplicationServices.Application.VertexTolerance`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.VertexTolerance`

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

### `P:Autodesk.Revit.ApplicationServices.Application.DefaultViewDiscipline`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.DefaultViewDiscipline`

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

### `P:Autodesk.Revit.ApplicationServices.Application.ShowGraphicalWarningHangerDisconnects`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.ShowGraphicalWarningHangerDisconnects`

#### Summary

Whether or not to show the graphical warnings for Fabrication Hanger disconnects.

#### Since

2016

### `P:Autodesk.Revit.ApplicationServices.Application.ShowGraphicalOpenEndsAreaBasedLoadBoundaryDisconnects`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.ShowGraphicalOpenEndsAreaBasedLoadBoundaryDisconnects`

#### Summary

Whether or not to show the graphical open ends for Area Based Load Boundary disconnects.

#### Since

2023

### `P:Autodesk.Revit.ApplicationServices.Application.ShowGraphicalWarningElectricalDisconnects`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.ShowGraphicalWarningElectricalDisconnects`

#### Summary

Whether or not to show the graphical warnings for Electrical disconnects.

#### Since

2012

### `P:Autodesk.Revit.ApplicationServices.Application.ShowGraphicalWarningCableTrayConduitDisconnects`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.ShowGraphicalWarningCableTrayConduitDisconnects`

#### Summary

Whether or not to show the graphical warnings for CTC disconnects.

#### Since

2012

### `P:Autodesk.Revit.ApplicationServices.Application.ShowGraphicalWarningPipeDisconnects`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.ShowGraphicalWarningPipeDisconnects`

#### Summary

Whether or not to show the graphical warnings for Pipe disconnects.

#### Since

2012

### `P:Autodesk.Revit.ApplicationServices.Application.ShowGraphicalWarningDuctDisconnects`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.ShowGraphicalWarningDuctDisconnects`

#### Summary

Whether or not to show the graphical warnings for duct disconnects.

#### Since

2012

### `P:Autodesk.Revit.ApplicationServices.Application.ImportIFCCategoryTable`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.ImportIFCCategoryTable`

#### Summary

Full path to the file that defines IFC entity to Revit category mappings for IFC import.

#### Since

2015

### `P:Autodesk.Revit.ApplicationServices.Application.ExportIFCCategoryTable`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.ExportIFCCategoryTable`

#### Summary

Full path to the file that defines Revit category to IFC entity mappings for IFC export.

#### Since

2015

### `P:Autodesk.Revit.ApplicationServices.Application.DefaultIFCProjectTemplate`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.DefaultIFCProjectTemplate`

#### Summary

Full path to the default template file for new IFC project documents.
It may be empty, in which case the DefaultProjectTemplate should be used.

#### Since

2015

### `P:Autodesk.Revit.ApplicationServices.Application.DefaultProjectTemplate`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.DefaultProjectTemplate`

#### Summary

Full path to the default template file for new project documents.

#### Since

2013

### `P:Autodesk.Revit.ApplicationServices.Application.SystemsAnalysisWorkfilesRootPath`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.SystemsAnalysisWorkfilesRootPath`

#### Summary

Root path for systems analysis workfiles

#### Since

2020

### `P:Autodesk.Revit.ApplicationServices.Application.PointCloudsRootPath`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.PointCloudsRootPath`

#### Summary

Root path for point cloud files.

#### Since

2016

### `P:Autodesk.Revit.ApplicationServices.Application.FamilyTemplatePath`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.FamilyTemplatePath`

#### Summary

Default path for family template files.

#### Since

2011

### `P:Autodesk.Revit.ApplicationServices.Application.SubVersionNumber`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.SubVersionNumber`

#### Summary

The minor version number of Revit

#### Remarks

SubVersionNumber of Revit may have additional APIs and functionality not available in the standard customer releases.
Add-ins written to support standard Revit releases should be compatible with SubVersionNumber releases,
but add-ins written specifically targeting new features in SubVersionNumber releases would not be compatible with the standard releases.

#### Since

2018

### `P:Autodesk.Revit.ApplicationServices.Application.Username`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.Username`

#### Summary

Gets the user name for the current Revit session.

#### Since

2012

### `M:Autodesk.Revit.ApplicationServices.Application.SendAdpData(Autodesk.Revit.DB.AddInId,Autodesk.Revit.DB.Document,Autodesk.ADPDesktopSDK.Facets.Core)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.SendAdpData(Autodesk.Revit.DB.AddInId,Autodesk.Revit.DB.Document,Autodesk.ADPDesktopSDK.Facets.Core)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.SendAdpData(Autodesk.Revit.DB.Document,Autodesk.ADPDesktopSDK.Facets.Core)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.SendAdpData(Autodesk.Revit.DB.Document,Autodesk.ADPDesktopSDK.Facets.Core)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.SendAdpData(Autodesk.Revit.DB.AddInId,Autodesk.ADPDesktopSDK.Facets.Core)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.SendAdpData(Autodesk.Revit.DB.AddInId,Autodesk.ADPDesktopSDK.Facets.Core)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.SendAdpData(Autodesk.ADPDesktopSDK.Facets.Core)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.SendAdpData(Autodesk.ADPDesktopSDK.Facets.Core)`

#### Summary

Sends ADP Core facet with analytics data to the Revit for processing and sending to the ADP data lake.

#### Parameter `coreFacet`

Container for analytics data

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2022

### `M:Autodesk.Revit.ApplicationServices.Application.PostInHouseDbgInfo(System.String,System.String,System.String,System.Int32,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.PostInHouseDbgInfo(System.String,System.String,System.String,System.Int32,System.String)`

#### Summary

Records a message in the journal file.

### `M:Autodesk.Revit.ApplicationServices.Application.PostInHouseDbgWarn(System.String,System.String,System.String,System.Int32,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.PostInHouseDbgWarn(System.String,System.String,System.String,System.Int32,System.String)`

#### Summary

Posts a user-visible warning (when UI is present and runs in the in-house mode) or just records it in the journal file otherwise.

### `P:Autodesk.Revit.ApplicationServices.Application.ActiveAddInId`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.ActiveAddInId`

#### Summary

Retrieves the Id of the currently running external application.

#### Remarks

The application can be either a UI application, DB application, or an external command. If no addin is active, this property will return `null` .
If an event handler is currently being executed, the returned value will be the Id of the application or command in which the event handler was registered.

### `P:Autodesk.Revit.ApplicationServices.Application.SharedParametersFilename`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.SharedParametersFilename`

#### Summary

Contains the fully qualified path to a shared parameters file.

#### Remarks

This path can be read and set via this property. By default Autodesk Revit does not have
a shared parameters file so this property must be set before access is made to the shared parameters
file object otherwise an exception will be thrown.

### `P:Autodesk.Revit.ApplicationServices.Application.Product`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.Product`

#### Summary

The product type for the current session of Revit.

### `P:Autodesk.Revit.ApplicationServices.Application.Language`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.Language`

#### Summary

The language used in the current session of Revit.

#### Remarks

Use this property to determine the language used by Revit; this can allow your application to load the appropriate resources.

### `P:Autodesk.Revit.ApplicationServices.Application.Cities`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.Cities`

#### Summary

Returns a set of all the known city locations within Revit.

#### Remarks

Each city has information about longitude, latitude etc.

### `P:Autodesk.Revit.ApplicationServices.Application.VersionBuild`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.VersionBuild`

#### Summary

Returns the internal build number of the Autodesk Revit application.

#### Remarks

This property can be used by your application to find the version of Autodesk Revit
against which your application is running. Based on this information your application
can report if it is able to work correctly with that version of Autodesk Revit.

### `P:Autodesk.Revit.ApplicationServices.Application.VersionNumber`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.VersionNumber`

#### Summary

Return the primary version of the Revit application.

#### Remarks

This property can be used by your application to find the version of Revit
against which your application is running. Based on this information your application
can report if it is able to work correctly with that version of Revit.

### `P:Autodesk.Revit.ApplicationServices.Application.VersionName`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.VersionName`

#### Summary

Returns the name of the Revit application.

#### Remarks

This property can be used by your application to find the version of Revit
against which your application is running. Based on this information your application
can report if it is able to work correctly with that version of Revit.

### `M:Autodesk.Revit.ApplicationServices.Application.OpenSharedParameterFile`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.OpenSharedParameterFile`

#### Summary

Enables access to shared parameter groups and definitions that are maintained on disk.

#### Returns

An object that represents a shared parameters file that exists on disk. Returns `null` if the file does not exist.

#### Remarks

This function is used to return an object that represents a Revit shared parameters file
Revit can use only one shared parameters file at one time. The filename
for the shared parameters file can be set in the Application.SharedParametersFilename property.

### `P:Autodesk.Revit.ApplicationServices.Application.Create`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.Create`

#### Summary

Provides an object that can be used to create new instances of Autodesk Revit API objects.

#### Remarks

The Create property returns an object that is used to create application wide utility
and geometric objects within the Autodesk Revit API, such as arrays, sets, lines. This object
should be used when you wish to create an object within the Autodesk Revit application memory,
rather than your own application's memory. If you are performing your own memory management
techniques then it is advisable to create any utility objects via the Create object. For example:
Instead of Dim set As New Autodesk_Revit_ElementSet do Set set = application.Create.NewElementSet()

### `P:Autodesk.Revit.ApplicationServices.Application.RecordingJournalFilename`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.RecordingJournalFilename`

#### Summary

Retrieve the name of the journal file the Revit is currently recording to.

#### Remarks

As Revit operates it keeps a log of operations that the user performs
within a file, known as a journal file. These files provide information
about the actions performed in a session and the state of Revit when a problem occurs.
These files are included during error reporting to Autodesk.

### `M:Autodesk.Revit.ApplicationServices.Application.ExtractPartAtomFromFamilyFile(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.ExtractPartAtomFromFamilyFile(System.String,System.String)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.NewFamilyDocument(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.NewFamilyDocument(System.String)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.NewProjectTemplateDocument(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.NewProjectTemplateDocument(System.String)`

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

### `M:Autodesk.Revit.ApplicationServices.Application.NewProjectDocument(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.Application.NewProjectDocument(System.String)`

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

### `P:Autodesk.Revit.ApplicationServices.Application.Documents`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.Application.Documents`

#### Summary

Returns a set of documents within Revit.

#### Remarks

This property can be used for the user to find all the document inside Revit.

### `T:Autodesk.Revit.ApplicationServices.Application`

Member kind: type
Symbol: `Autodesk.Revit.ApplicationServices.Application`

#### Summary

Represents the Autodesk Revit Application, providing access to documents, options and other application wide data and settings.

### `P:Autodesk.Revit.DB.Events.CreateRelatedFileProgressChangedEventArgs.DownloadFinished`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.CreateRelatedFileProgressChangedEventArgs.DownloadFinished`

#### Summary

Indicates if all data downloads are finished.

#### Since

2018

### `P:Autodesk.Revit.DB.Events.CreateRelatedFileProgressChangedEventArgs.FullDownload`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.CreateRelatedFileProgressChangedEventArgs.FullDownload`

#### Summary

Indicates if download the full data of the document, which will take longer than subsequent downloads.

#### Since

2018

### `P:Autodesk.Revit.DB.Events.CreateRelatedFileProgressChangedEventArgs.CreatingCloudSharedLocal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.CreateRelatedFileProgressChangedEventArgs.CreatingCloudSharedLocal`

#### Summary

Indicates if it is creating cloud shared local model.

#### Since

2018

### `M:Autodesk.Revit.DB.Events.CreateRelatedFileProgressChangedEventArgs.#ctor(Autodesk.Revit.DB.Events.CreateRelatedFileProgressChangedEventArgs)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.CreateRelatedFileProgressChangedEventArgs.#ctor(Autodesk.Revit.DB.Events.CreateRelatedFileProgressChangedEventArgs)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `T:Autodesk.Revit.DB.Events.CreateRelatedFileProgressChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.CreateRelatedFileProgressChangedEventArgs`

#### Summary

The event arguments used during creating related file phase of `!:Autodesk::Revit::ApplicationServices::Application::WorksharedOperationProgressChanged` in model open operation.

#### Since

2018

### `P:Autodesk.Revit.DB.Events.DocumentSaveToCentralProgressChangedEventArgs.FailureDueToConflicts`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentSaveToCentralProgressChangedEventArgs.FailureDueToConflicts`

#### Summary

Indicates the 'save to central' failure is caused by submission conflicts, that is because another one finished saving to central first.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.DocumentSaveToCentralProgressChangedEventArgs.SaveToCentralFinished`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentSaveToCentralProgressChangedEventArgs.SaveToCentralFinished`

#### Summary

Indicates if current 'save to central' is finished.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.DocumentSaveToCentralProgressChangedEventArgs.RetryTimes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentSaveToCentralProgressChangedEventArgs.RetryTimes`

#### Summary

The number of times Revit has tried to Save to Central." Its value is '0' at the first time.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.Events.DocumentSaveToCentralProgressChangedEventArgs.#ctor(Autodesk.Revit.DB.Events.DocumentSaveToCentralProgressChangedEventArgs)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.DocumentSaveToCentralProgressChangedEventArgs.#ctor(Autodesk.Revit.DB.Events.DocumentSaveToCentralProgressChangedEventArgs)`

#### Summary

Creates a copy of the DocumentSaveToCentralProgressChangedEventArgs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017 Subscription Update

### `T:Autodesk.Revit.DB.Events.DocumentSaveToCentralProgressChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.DocumentSaveToCentralProgressChangedEventArgs`

#### Summary

The event arguments used during the save to central phase of `!:Autodesk::Revit::ApplicationServices::Application::WorksharedOperationProgressChanged` .

#### Remarks

It is NOT recommended to do any time-consuming work when handling WorksharedOperationProgressChanged event. This can increase workshared operation time.
Name correction - it is renamed from 'DocumentSaveToCentralProgessChangedEventArgs' released since 2017 Subscription Update.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.DocumentReloadLatestProgressChangedEventArgs.ReloadLatestFinished`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentReloadLatestProgressChangedEventArgs.ReloadLatestFinished`

#### Summary

Indicates if current 'reload latest' progress is finished.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.DocumentReloadLatestProgressChangedEventArgs.IsMerging`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentReloadLatestProgressChangedEventArgs.IsMerging`

#### Summary

Indicates if it is merging downloaded data.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.DocumentReloadLatestProgressChangedEventArgs.RetryTimes`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentReloadLatestProgressChangedEventArgs.RetryTimes`

#### Summary

The number of times Revit has tried to Reload Latest. Its value is '0' at the first time.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.Events.DocumentReloadLatestProgressChangedEventArgs.#ctor(Autodesk.Revit.DB.Events.DocumentReloadLatestProgressChangedEventArgs)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.DocumentReloadLatestProgressChangedEventArgs.#ctor(Autodesk.Revit.DB.Events.DocumentReloadLatestProgressChangedEventArgs)`

#### Summary

Creates a copy of the DocumentReloadLatestProgressChangedEventArgs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017 Subscription Update

### `T:Autodesk.Revit.DB.Events.DocumentReloadLatestProgressChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.DocumentReloadLatestProgressChangedEventArgs`

#### Summary

The event arguments used during the reload latest phase of `!:Autodesk::Revit::ApplicationServices::Application::WorksharedOperationProgressChanged` .

#### Remarks

It is NOT recommended to do any time-consuming work when handling WorksharedOperationProgressChanged event. This can increase workshared operation time.
Name correction - it is renamed from 'DocumentReloadLatestProgessChangedEventArgs' released since 2017 Subscription Update.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.DataTransferProgressChangedEventArgs.TotalSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DataTransferProgressChangedEventArgs.TotalSize`

#### Summary

Total expected data size to transfer, in bytes.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.DataTransferProgressChangedEventArgs.FinishedSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DataTransferProgressChangedEventArgs.FinishedSize`

#### Summary

The transferred data size, in bytes, since the last time this event was raised.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.DataTransferProgressChangedEventArgs.Speed`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DataTransferProgressChangedEventArgs.Speed`

#### Summary

Speed(bytes/second) in this event.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.DataTransferProgressChangedEventArgs.TransferMode`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DataTransferProgressChangedEventArgs.TransferMode`

#### Summary

Data transfer mode in this event.

#### Since

2017 Subscription Update

### `T:Autodesk.Revit.DB.Events.DataTransferProgressChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.DataTransferProgressChangedEventArgs`

#### Summary

The event arguments used during the data transferring phase of `!:Autodesk::Revit::ApplicationServices::Application::WorksharedOperationProgressChanged` .

#### Remarks

It is NOT recommended to do any time-consuming work when handling WorksharedOperationProgressChanged event. This can increase workshared operation time.

#### Since

2017 Subscription Update

### `T:Autodesk.Revit.DB.Events.DataTransferMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.DataTransferMode`

#### Summary

Describes the data transfer mode.

#### Summary

Describes the data transfer mode.

#### Since

2017 Subscription Update

### `F:Autodesk.Revit.DB.Events.DataTransferMode.Upload`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.DataTransferMode.Upload`

#### Summary

Transfer data from client to server.

### `F:Autodesk.Revit.DB.Events.DataTransferMode.Download`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.DataTransferMode.Download`

#### Summary

Transfer data from server to client.

### `F:Autodesk.Revit.DB.Events.DataTransferMode.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.DataTransferMode.Undefined`

#### Summary

Undefined mode.

### `P:Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs.SaveToLocalFinished`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs.SaveToLocalFinished`

#### Summary

Indicates if the current "save to local" operation has finished.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs.TotalStreams`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs.TotalStreams`

#### Summary

The total expected number of streams to save to local.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs.FinishedStreams`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs.FinishedStreams`

#### Summary

The number of streams finished since the last time this event was raised.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs.BeforeSaveToCentral`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs.BeforeSaveToCentral`

#### Summary

True if the "save to local" operation is occurring before "save to central"; false if after.

#### Since

2017 Subscription Update

### `M:Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs.#ctor(Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs.#ctor(Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs)`

#### Summary

Creates a copy of the DocumentSaveToLocalProgressChangedEventArgs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017 Subscription Update

### `T:Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs`

#### Summary

The event arguments used during the save to local phase of `!:Autodesk::Revit::ApplicationServices::Application::WorksharedOperationProgressChanged` .

#### Remarks

It is NOT recommended to do any time-consuming work when handling WorksharedOperationProgressChanged event. This can increase workshared operation time.
Name correction - it is renamed from 'DocumentSaveToLocalProgessChangedEventArgs' released since 2017 Subscription Update.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.WorksharedOperationProgressChangedEventArgs.Status`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.WorksharedOperationProgressChangedEventArgs.Status`

#### Summary

Gets API event status, reflect current operation execution status.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.WorksharedOperationProgressChangedEventArgs.Location`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.WorksharedOperationProgressChangedEventArgs.Location`

#### Summary

Full path of the central model which is to be operated.

#### Remarks

For C4R model, it looks like 'Autodesk Docs://My project/my model.rvt'.

#### Since

2017 Subscription Update

### `T:Autodesk.Revit.DB.Events.WorksharedOperationProgressChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.WorksharedOperationProgressChangedEventArgs`

#### Summary

The event arguments used by the WorksharedOperationProgressChanged event, this event will be raised when executing following workshared operations.

#### Remarks

For synchronizing with central operation, there are 4 steps.
1) Save to local (before save to central) - Serializes the streams from memory to local disk cache;
`!:Autodesk::Revit::DB::Events::DocumentSaveToLocalProgressChangedEventArgs`
2) Reload latest - Downloads the streams from central model on server and merge them into local memory;
`!:Autodesk::Revit::DB::Events::DocumentReloadLatestProgressChangedEventArgs`
3) Save to central - Uploads merged streams from local memory to server central model;
`!:Autodesk::Revit::DB::Events::DocumentSaveToCentralProgressChangedEventArgs`
4) Save to local (after save to central) - Serializes the merged streams from memory to local disk cache;
`!:Autodesk::Revit::DB::Events::DocumentSaveToLocalProgressChangedEventArgs`

For document open operation, just download the model from server and then open it; `!:Autodesk::Revit::DB::Events::CreateRelatedFileProgressChangedEventArgs`

It is NOT recommended to deal with time-consuming work when handling WorksharedOperationProgressChanged event, otherwise it would increase synchronizing with central or model open time.

#### Since

2017 Subscription Update

### `P:Autodesk.Revit.DB.Events.DocumentReloadedLatestEventArgs.Location`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentReloadedLatestEventArgs.Location`

#### Summary

Full path of the central model which is to be operated.

#### Remarks

For C4R model, it looks like 'Autodesk Docs://My project/my model.rvt'.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2021

### `T:Autodesk.Revit.DB.Events.DocumentReloadedLatestEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.DocumentReloadedLatestEventArgs`

#### Summary

The event arguments used by the DocumentReloadedLatestEvent event.
This event will be raised when executing pull a latest changes from a central model.

#### Since

2021

### `T:Autodesk.Revit.DB.Events.DocumentReloadingLatestEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.DocumentReloadingLatestEventArgs`

#### Summary

The event arguments used by the DocumentReloadingLatest event.

#### Since

2021

### `P:Autodesk.Revit.DB.Visual.Asset.AssetType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Asset.AssetType`

#### Summary

The type of RenderingAsset

### `P:Autodesk.Revit.DB.Visual.Asset.LibraryName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Asset.LibraryName`

#### Summary

Library name

### `P:Autodesk.Revit.DB.Visual.Asset.Title`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Asset.Title`

#### Summary

Asset title

### `T:Autodesk.Revit.DB.Visual.Asset`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Asset`

#### Summary

Represents a connected property of material.

### `T:Autodesk.Revit.DB.Visual.AssetType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.AssetType`

#### Summary

Enumerated asset types

#### Summary

RenderingAsset Types.

### `F:Autodesk.Revit.DB.Visual.AssetType.Content`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetType.Content`

#### Summary

Content assets (RPC / entourage).

### `F:Autodesk.Revit.DB.Visual.AssetType.Appearance`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetType.Appearance`

#### Summary

Appearance assets (materials).

### `M:Autodesk.Revit.DB.Visual.AssetProperties.IsValidIndex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetProperties.IsValidIndex(System.Int32)`

#### Summary

Returns true if the provided index is valid.

#### Parameter `index`

Index to be validated.

#### Returns

True if index is valid, false otherwise.

#### Since

2019

### `M:Autodesk.Revit.DB.Visual.AssetProperties.Get(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetProperties.Get(System.Int32)`

#### Summary

Gets the property at the given index.

#### Parameter `index`

An integer index.

#### Returns

The property at the given index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

index is out of range.

#### Since

2019

### `M:Autodesk.Revit.DB.Visual.AssetProperties.FindByName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetProperties.FindByName(System.String)`

#### Summary

Gets the property with the given name.

#### Remarks

FindByName will not visit the properties of any connected asset on any of the properties.

#### Parameter `name`

Name of the property.

#### Returns

The property with the specified name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.AssetProperties.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.AssetProperties.Size`

#### Summary

The number of the AssetProperty(s) in the object.

### `P:Autodesk.Revit.DB.Visual.AssetProperties.default(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.AssetProperties.default(System.Int32)`

#### Summary

Gets the one property that the current object contains with the given index.

### `T:Autodesk.Revit.DB.Visual.AssetProperties`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.AssetProperties`

#### Summary

Represents a set of asset property(s).

### `M:Autodesk.Revit.DB.Visual.AssetProperty.SetReadOnlyInternal(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.SetReadOnlyInternal(System.Boolean)`

#### Summary

Set the read-only property of the object.

### `M:Autodesk.Revit.DB.Visual.AssetProperty.IsValidSchemaIdentifier(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.IsValidSchemaIdentifier(System.String)`

#### Summary

Check that schema name is valid

#### Parameter `schemaID`

The schema name.

#### Returns

True if the schema name is valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot check validity for a property not being edited in AppearanceAssetEditScope.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Visual.AssetProperty.RemoveConnectedAsset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.RemoveConnectedAsset`

#### Summary

Removes the connected asset attached to this asset property if any.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The asset property is not editable.
-or-
Cannot check validity for a property not being edited in AppearanceAssetEditScope.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Visual.AssetProperty.AddCopyAsConnectedAsset(Autodesk.Revit.DB.Visual.Asset)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.AddCopyAsConnectedAsset(Autodesk.Revit.DB.Visual.Asset)`

#### Summary

Makes a copy of the asset and connects it to this property.

#### Parameter `pRenderingAsset`

The asset to duplicate and associate with this property as a connected asset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The asset property is not editable.
-or-
Cannot check validity for a property not being edited in AppearanceAssetEditScope.
-or-
Asset property is already connected to one asset.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Visual.AssetProperty.AddConnectedAsset(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.AddConnectedAsset(System.String)`

#### Summary

Adds a new connected asset attached to this asset property, if it allows it.

#### Remarks

Cannot add a connected asset if one is already connected.
Use RemoveConnectedAsset() to avoid an exception being thrown.
A new preset asset is created and connected to the property.
For "UnifiedBitmap", it contains an empty property unifiedbitmap_Bitmap.

#### Parameter `schema`

The schema name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The schema name is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The asset property is not editable.
-or-
Cannot check validity for a property not being edited in AppearanceAssetEditScope.
-or-
Asset property is already connected to one asset.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Visual.AssetProperty.IsEditable`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.IsEditable`

#### Summary

Check if property can be edited.

#### Remarks

Properties can be edited only if there is an active Edit Scope and if the property is allowed to be changed.

#### Returns

True if property is editable.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The asset property is not editable. Asset can be edited only in an edit scope.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Visual.AssetProperty.GetAllConnectedProperties`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.GetAllConnectedProperties`

#### Summary

Gets the list of the connected properties.
Connected properties are the detachable properties of an AssetProperty.
e.g. diffuse property can have texture as its connected property. It can also detach texture on runtime.

#### Returns

A list of the connected properties.

#### Since

2014

### `M:Autodesk.Revit.DB.Visual.AssetProperty.GetSingleConnectedAsset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.GetSingleConnectedAsset`

#### Summary

Gets the single connected asset attached to this asset property, if it exists.

#### Remarks

Throws if there is more than one connected asset.

#### Returns

The connected asset, or `null` if there is no connected asset.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Asset is connected to more than one asset.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Visual.AssetProperty.GetConnectedProperty(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.GetConnectedProperty(System.Int32)`

#### Summary

Gets one connected property with specified index.

#### Returns

The AProperty of that index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is out of range.

#### Since

2014

### `P:Autodesk.Revit.DB.Visual.AssetProperty.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Visual.AssetProperty.IsReadOnly`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.IsReadOnly`

#### Summary

Identifies if the object is read-only or modifiable.
If true, the object may not be modified. If false, the object's contents may be modified.

### `P:Autodesk.Revit.DB.Visual.AssetProperty.NumberOfConnectedProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.NumberOfConnectedProperties`

#### Summary

The number of currently connected properties.

#### Since

2014

### `M:Autodesk.Revit.DB.Visual.AssetProperty.GetTypeName(Autodesk.Revit.DB.Visual.AssetPropertyType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.GetTypeName(Autodesk.Revit.DB.Visual.AssetPropertyType)`

#### Summary

Get the name of the AssetProperty

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when type is AssetPropertyType::Unknown.

### `P:Autodesk.Revit.DB.Visual.AssetProperty.Type`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.Type`

#### Summary

Returns the type of the AssetProperty

### `P:Autodesk.Revit.DB.Visual.AssetProperty.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty.Name`

#### Summary

Get the name of the AssetProperty

### `T:Autodesk.Revit.DB.Visual.AssetProperty`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.AssetProperty`

#### Summary

Represents a property of material.

#### Remarks

AssetProperty is the base class or all other AssetProperty sub classes.

### `T:Autodesk.Revit.DB.Visual.AssetPropertyType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType`

#### Summary

Enumerated type listing the type of asset property

#### Summary

Asset Property Types.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Float3`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Float3`

#### Summary

Represents property Float array. The corresponding AssetProperty sub class is AssetPropertyFloatArray.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.List`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.List`

#### Summary

Represents property List. The corresponding AssetProperty sub class is AssetPropertyList.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.ULonglong`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.ULonglong`

#### Summary

Represents property unsigned Int64. The corresponding AssetProperty sub class is AssetPropertyUInt64.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Longlong`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Longlong`

#### Summary

Represents property Int64. The corresponding AssetProperty sub class is AssetPropertyInt64.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Reference`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Reference`

#### Summary

Represents property Reference. The corresponding AssetProperty sub class is AssetPropertyReference.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Asset`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Asset`

#### Summary

Represents property Asset. The corresponding AssetProperty sub class is Asset.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Distance`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Distance`

#### Summary

Represents property Distance. The corresponding AssetProperty sub class is AssetPropertyDistance.
Special.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Time`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Time`

#### Summary

Represents property Time. The corresponding AssetProperty sub class is AssetPropertyTime.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.String`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.String`

#### Summary

Represents property String. The corresponding AssetProperty sub class is AssetPropertyString.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Double44`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Double44`

#### Summary

Represents property 4x4 Double matrix. The corresponding AssetProperty sub class is AssetPropertyDoubleMatrix44.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Double4`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Double4`

#### Summary

Represents property 4d Double array. The corresponding AssetProperty sub class is AssetPropertyDoubleArray4d.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Double3`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Double3`

#### Summary

Represents property 3d Double array. The corresponding AssetProperty sub class is AssetPropertyDoubleArray3d.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Double2`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Double2`

#### Summary

Represents property 2d Double array. The corresponding AssetProperty sub class is AssetPropertyDoubleArray2d.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Double1`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Double1`

#### Summary

Represents property Double. The corresponding AssetProperty sub class is AssetPropertyDouble.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Float`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Float`

#### Summary

Represents property Float. The corresponding AssetProperty sub class is AssetPropertyFloat.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Integer`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Integer`

#### Summary

Represents property Integer. The corresponding AssetProperty sub class is AssetPropertyInteger.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Enumeration`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Enumeration`

#### Summary

Represents property Enum. The corresponding AssetProperty sub class is AssetPropertyEnum.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Boolean`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Boolean`

#### Summary

Represents property Boolean. The corresponding AssetProperty sub class is AssetPropertyBoolean.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Properties`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Properties`

#### Summary

Represents Properties. The corresponding AssetProperty sub class is AssetProperties.

### `F:Autodesk.Revit.DB.Visual.AssetPropertyType.Unknown`

Member kind: field
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyType.Unknown`

#### Summary

An unknown or unspecified property type.

### `P:Autodesk.Revit.DB.Events.ProjectBrowserDataChangedEventArgs.IsStatusChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ProjectBrowserDataChangedEventArgs.IsStatusChanged`

#### Since

2024

### `P:Autodesk.Revit.DB.Events.ProjectBrowserDataChangedEventArgs.ShouldScroll`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ProjectBrowserDataChangedEventArgs.ShouldScroll`

#### Since

2024

### `T:Autodesk.Revit.DB.Events.ProjectBrowserDataChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ProjectBrowserDataChangedEventArgs`

#### Summary

The event arguments used by the ProjectBrowserDataChanged event.

#### Since

2024

### `M:Autodesk.Revit.DB.Events.ProgressChangedEventArgs.Cancel`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.ProgressChangedEventArgs.Cancel`

#### Summary

Requests to cancel the progress bar's operation.

#### Remarks

Note that an operation may only be cancelled if its stage is
'Unchanged' or if its stage is 'PositionChanged' and the 'Cancellable' property is 'true.'

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The operation cannot be cancelled.

#### Since

2013

### `P:Autodesk.Revit.DB.Events.ProgressChangedEventArgs.Caption`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ProgressChangedEventArgs.Caption`

#### Summary

The text from the progress bar caption that describes the operation in progress

#### Since

2013

### `P:Autodesk.Revit.DB.Events.ProgressChangedEventArgs.UpperRange`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ProgressChangedEventArgs.UpperRange`

#### Summary

Upper part of progress bar range - will be any non-zero number

#### Since

2013

### `P:Autodesk.Revit.DB.Events.ProgressChangedEventArgs.LowerRange`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ProgressChangedEventArgs.LowerRange`

#### Summary

Lower part of progress bar range - always zero

#### Since

2013

### `P:Autodesk.Revit.DB.Events.ProgressChangedEventArgs.Position`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ProgressChangedEventArgs.Position`

#### Summary

Progress bar position - value is always between zero and upperRange and is incremented by one with each event of stage "PositionChanged"

#### Since

2013

### `P:Autodesk.Revit.DB.Events.ProgressChangedEventArgs.Stage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ProgressChangedEventArgs.Stage`

#### Summary

The current stage of the progress bar

#### Since

2013

### `T:Autodesk.Revit.DB.Events.ProgressChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ProgressChangedEventArgs`

#### Summary

The event arguments used by the ProgressChanged event.

#### Since

2013

### `T:Autodesk.Revit.DB.Events.ProgressStage`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ProgressStage`

#### Summary

The associated action of a ProgressChanged event

#### Since

2013

#### Since

2013

### `F:Autodesk.Revit.DB.Events.ProgressStage.Finished`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.ProgressStage.Finished`

#### Summary

Progress bar is finished

### `F:Autodesk.Revit.DB.Events.ProgressStage.Unchanged`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.ProgressStage.Unchanged`

#### Summary

Progress bar has not changed position

### `F:Autodesk.Revit.DB.Events.ProgressStage.CaptionChanged`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.ProgressStage.CaptionChanged`

#### Summary

Progress bar has set new Text

### `F:Autodesk.Revit.DB.Events.ProgressStage.PositionChanged`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.ProgressStage.PositionChanged`

#### Summary

Progress bar has set new position

### `F:Autodesk.Revit.DB.Events.ProgressStage.RangeChanged`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.ProgressStage.RangeChanged`

#### Summary

Progress bar has set new range

### `F:Autodesk.Revit.DB.Events.ProgressStage.Started`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.ProgressStage.Started`

#### Summary

Progress bar has started

### `P:Autodesk.Revit.DB.Events.LinkedResourceOpenedEventArgs.LinkedResourcePathName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.LinkedResourceOpenedEventArgs.LinkedResourcePathName`

#### Summary

Path of the linked resource.

#### Since

2018

### `P:Autodesk.Revit.DB.Events.LinkedResourceOpenedEventArgs.ResourceTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.LinkedResourceOpenedEventArgs.ResourceTypeId`

#### Summary

Element id of the linked resource.

#### Since

2018

### `P:Autodesk.Revit.DB.Events.LinkedResourceOpenedEventArgs.ResourceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.LinkedResourceOpenedEventArgs.ResourceType`

#### Summary

The desired linked resource type.

#### Since

2018

### `T:Autodesk.Revit.DB.Events.LinkedResourceOpenedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.LinkedResourceOpenedEventArgs`

#### Summary

The event arguments used by `!:Autodesk::Revit::ApplicationServices::Application::LinkedResourceOpened` .

#### Since

2018

### `P:Autodesk.Revit.DB.Events.LinkedResourceOpeningEventArgs.LinkedResourcePathName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.LinkedResourceOpeningEventArgs.LinkedResourcePathName`

#### Summary

Path of the linked resource.

#### Since

2018

### `P:Autodesk.Revit.DB.Events.LinkedResourceOpeningEventArgs.ResourceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.LinkedResourceOpeningEventArgs.ResourceType`

#### Summary

The desired linked resource type.

#### Since

2018

### `T:Autodesk.Revit.DB.Events.LinkedResourceOpeningEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.LinkedResourceOpeningEventArgs`

#### Summary

The event arguments used by `!:Autodesk::Revit::ApplicationServices::Application::LinkedResourceOpening` .

#### Since

2018

### `M:Autodesk.Revit.DB.Events.ViewsExportedByContextEventArgs.GetViewIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.ViewsExportedByContextEventArgs.GetViewIds`

#### Summary

Gets the views that were exported by CustomExporter.

#### Returns

The views that were exported by CustomExporter.

#### Since

2021

### `T:Autodesk.Revit.DB.Events.ViewsExportedByContextEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ViewsExportedByContextEventArgs`

#### Summary

The event arguments used by the ViewsExportedByContext event.

#### Since

2021

### `M:Autodesk.Revit.DB.Events.ViewsExportingByContextEventArgs.GetViewIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.ViewsExportingByContextEventArgs.GetViewIds`

#### Summary

Gets the views about to be exported by CustomExporter.

#### Returns

The views about to be exported by CustomExporter.

#### Since

2021

### `T:Autodesk.Revit.DB.Events.ViewsExportingByContextEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ViewsExportingByContextEventArgs`

#### Summary

The event arguments used by the ViewsExportingByContext event.

#### Since

2021

### `P:Autodesk.Revit.DB.Events.ViewExportedEventArgs.ViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ViewExportedEventArgs.ViewId`

#### Summary

Identifies the view that was exported.

#### Since

2018

### `T:Autodesk.Revit.DB.Events.ViewExportedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ViewExportedEventArgs`

#### Summary

The event arguments used by the ViewExported event.

#### Since

2018

### `P:Autodesk.Revit.DB.Events.ViewExportingEventArgs.ViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ViewExportingEventArgs.ViewId`

#### Summary

Identifies the view about to be exported.

#### Since

2018

### `T:Autodesk.Revit.DB.Events.ViewExportingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ViewExportingEventArgs`

#### Summary

The event arguments used by the ViewExporting event.

#### Since

2018

### `P:Autodesk.Revit.DB.Events.FileExportedEventArgs.Format`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FileExportedEventArgs.Format`

#### Summary

Identifies the export format, e.g. DWG or image.

#### Since

2010

### `P:Autodesk.Revit.DB.Events.FileExportedEventArgs.Path`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FileExportedEventArgs.Path`

#### Summary

Target path for the exported file (or files).

#### Remarks

In some cases the path represents only the target directory or a template name.
Such cases include batch export when more than one file is exported as one event.

#### Since

2010

### `T:Autodesk.Revit.DB.Events.FileExportedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.FileExportedEventArgs`

#### Summary

The event arguments used by the FileExported event.

#### Since

2010

### `P:Autodesk.Revit.DB.Events.FileExportingEventArgs.Format`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FileExportingEventArgs.Format`

#### Summary

Identifies the export format, e.g. DWG or image.

#### Since

2010

### `P:Autodesk.Revit.DB.Events.FileExportingEventArgs.Path`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FileExportingEventArgs.Path`

#### Summary

The target path for the export.

#### Remarks

When several files are exported at the same time, 'Path' property will just report the directory instead of those full file names.

#### Since

2010

### `T:Autodesk.Revit.DB.Events.FileExportingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.FileExportingEventArgs`

#### Summary

The event arguments used by the FileExporting event.

#### Since

2010

### `P:Autodesk.Revit.DB.Events.FileImportedEventArgs.ImportedInstanceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FileImportedEventArgs.ImportedInstanceId`

#### Summary

The ElementId of the imported instance that represents the imported object(s) after a successful import.
It could be used for further manipulation of that instance.

#### Remarks

The value could be InvalidElementId for some type of import formats, such as GBXML and Inventor files.

#### Since

2010

### `P:Autodesk.Revit.DB.Events.FileImportedEventArgs.Format`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FileImportedEventArgs.Format`

#### Summary

Identifies the import format, e.g. DWG or image.

#### Since

2010

### `P:Autodesk.Revit.DB.Events.FileImportedEventArgs.Path`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FileImportedEventArgs.Path`

#### Summary

Path of the source file that was imported.

#### Since

2010

### `T:Autodesk.Revit.DB.Events.FileImportedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.FileImportedEventArgs`

#### Summary

The event arguments used by the FileImported event.

#### Since

2010

### `P:Autodesk.Revit.DB.Events.FileImportingEventArgs.Format`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FileImportingEventArgs.Format`

#### Summary

Identifies the import format, e.g. DWG or image.

#### Since

2010

### `P:Autodesk.Revit.DB.Events.FileImportingEventArgs.Path`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FileImportingEventArgs.Path`

#### Summary

Path of the source file which is about to be imported.

#### Since

2010

### `T:Autodesk.Revit.DB.Events.FileImportingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.FileImportingEventArgs`

#### Summary

The event arguments used by the FileImporting event.

#### Since

2010

### `T:Autodesk.Revit.DB.ImportExportFileFormat`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat`

#### Summary

Describes formats supported by import / export.

#### Since

2010

### `F:Autodesk.Revit.DB.ImportExportFileFormat.OBJ`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.OBJ`

#### Summary

OBJ format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.AXM`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.AXM`

#### Summary

AXM format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.STL`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.STL`

#### Summary

STL format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.PDF`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.PDF`

#### Summary

PDF format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.NWC`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.NWC`

#### Summary

Navisworks format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.IFC`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.IFC`

#### Summary

IFC format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.SAT`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.SAT`

#### Summary

SAT format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.DXF`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.DXF`

#### Summary

DXF format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.Inventor`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.Inventor`

#### Summary

Inventor format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.Civil3D`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.Civil3D`

#### Summary

Civil3D format. Obsolete.

### `F:Autodesk.Revit.DB.ImportExportFileFormat.DGN`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.DGN`

#### Summary

DGN format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.Image`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.Image`

#### Summary

Image format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.FBX`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.FBX`

#### Summary

FBX format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.GBXML`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.GBXML`

#### Summary

GBXML format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.DWFX`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.DWFX`

#### Summary

DWFX format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.DWF`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.DWF`

#### Summary

DWF format

### `F:Autodesk.Revit.DB.ImportExportFileFormat.DWG`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImportExportFileFormat.DWG`

#### Summary

DWG format

### `M:Autodesk.Revit.DB.Events.GetProjectsRequestedEventArgs.GetProjects`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.GetProjectsRequestedEventArgs.GetProjects`

#### Summary

gets CloudProject values within Event.

#### Since

2019

### `M:Autodesk.Revit.DB.Events.GetProjectsRequestedEventArgs.SetProjects(System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeDM.CloudProject})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.GetProjectsRequestedEventArgs.SetProjects(System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeDM.CloudProject})`

#### Summary

Sets CloudProject values within Event.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Events.GetProjectsRequestedEventArgs.Region`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.GetProjectsRequestedEventArgs.Region`

#### Summary

region for CloudHub

#### Since

2019

### `P:Autodesk.Revit.DB.Events.GetProjectsRequestedEventArgs.HubId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.GetProjectsRequestedEventArgs.HubId`

#### Summary

Identifier for CloudHub

#### Since

2019

### `M:Autodesk.Revit.DB.Events.GetProjectsRequestedEventArgs.#ctor(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.GetProjectsRequestedEventArgs.#ctor(System.String,System.String)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `T:Autodesk.Revit.DB.Events.GetProjectsRequestedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.GetProjectsRequestedEventArgs`

#### Summary

Event arguments used by the ForgeDM Projects event.
Represents Identifier of current Hub.
Sets CloudProject values within Event.
Gets CloudProject values within Event.

#### Since

2019

### `M:Autodesk.Revit.DB.Events.GetHubsRequestedEventArgs.GetHubs`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.GetHubsRequestedEventArgs.GetHubs`

#### Summary

gets CloudHub values within Event.

#### Since

2019

### `M:Autodesk.Revit.DB.Events.GetHubsRequestedEventArgs.SetHubs(System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeDM.CloudHub})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.GetHubsRequestedEventArgs.SetHubs(System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeDM.CloudHub})`

#### Summary

Sets CloudHub values within Event.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Events.GetHubsRequestedEventArgs.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.GetHubsRequestedEventArgs.#ctor`

#### Since

2019

### `T:Autodesk.Revit.DB.Events.GetHubsRequestedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.GetHubsRequestedEventArgs`

#### Summary

Event arguments used by the ForgeDM Hubs event.
Sets CloudHub values within Event.
Gets CloudHub values within Event.

#### Since

2019

### `M:Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.GetModels`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.GetModels`

#### Summary

gets CloudModel values within Event.

#### Since

2019

### `M:Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.SetModels(System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeDM.CloudModel})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.SetModels(System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeDM.CloudModel})`

#### Summary

Sets CloudModel values within Event.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.GetFolders`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.GetFolders`

#### Summary

gets CloudFolder values within Event.

#### Since

2019

### `M:Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.SetFolders(System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeDM.CloudFolder})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.SetFolders(System.Collections.Generic.IList{Autodesk.Revit.DB.ForgeDM.CloudFolder})`

#### Summary

Sets CloudFolder values within Event.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.FolderId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.FolderId`

#### Summary

Identifier for Folder in CloudProject

#### Since

2019

### `P:Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.ProjectId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.ProjectId`

#### Summary

Identifier for CloudProject

#### Since

2019

### `P:Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.Region`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.Region`

#### Summary

region for CloudHub

#### Since

2019

### `P:Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.HubId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.HubId`

#### Summary

Identifier for CloudHub

#### Since

2019

### `M:Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.#ctor(System.String,System.String,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs.#ctor(System.String,System.String,System.String,System.String)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `T:Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.GetFolderContentsRequestedEventArgs`

#### Summary

Event arguments used by the ForgeDM FolderContents event.
Represents Identifier of current Hub.
Represents region of current Hub.
Represents Identifier of current Project.
Represents Identifier of current Folder in current Project.
Sets CloudFolder values within Event.
Gets CloudFolder values within Event.
Sets CloudModel values within Event.
Gets CloudModel values within Event.

#### Since

2019

### `M:Autodesk.Revit.DB.Events.CloudResourceNavigationEventArgs.RaiseEvent`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.CloudResourceNavigationEventArgs.RaiseEvent`

#### Summary

Raise event for this Event

#### Since

2019

### `M:Autodesk.Revit.DB.Events.CloudResourceNavigationEventArgs.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.CloudResourceNavigationEventArgs.#ctor`

#### Since

2019

### `T:Autodesk.Revit.DB.Events.CloudResourceNavigationEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.CloudResourceNavigationEventArgs`

#### Summary

Event arguments used by the ForgeDM Resources event.
Raises event for this Event.

#### Since

2019

### `P:Autodesk.Revit.DB.Events.FamilyLoadedIntoDocumentEventArgs.NewFamilyId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FamilyLoadedIntoDocumentEventArgs.NewFamilyId`

#### Summary

The newly loaded family id.

#### Since

2015

### `P:Autodesk.Revit.DB.Events.FamilyLoadedIntoDocumentEventArgs.OriginalFamilyId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FamilyLoadedIntoDocumentEventArgs.OriginalFamilyId`

#### Summary

The original family id that is overridden by the newly loaded family.

#### Since

2015

### `P:Autodesk.Revit.DB.Events.FamilyLoadedIntoDocumentEventArgs.FamilyPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FamilyLoadedIntoDocumentEventArgs.FamilyPath`

#### Summary

The file path of the family that is loaded into the document.

#### Since

2015

### `P:Autodesk.Revit.DB.Events.FamilyLoadedIntoDocumentEventArgs.FamilyName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FamilyLoadedIntoDocumentEventArgs.FamilyName`

#### Summary

The file name of the family that is loaded into the document.

#### Since

2015

### `T:Autodesk.Revit.DB.Events.FamilyLoadedIntoDocumentEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.FamilyLoadedIntoDocumentEventArgs`

#### Summary

The event arguments used by the FamilyLoadedInto event.

#### Since

2015

### `P:Autodesk.Revit.DB.Events.FamilyLoadingIntoDocumentEventArgs.FamilyPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FamilyLoadingIntoDocumentEventArgs.FamilyPath`

#### Summary

The file path of the family that is being loaded into the document.

#### Since

2015

### `P:Autodesk.Revit.DB.Events.FamilyLoadingIntoDocumentEventArgs.FamilyName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.FamilyLoadingIntoDocumentEventArgs.FamilyName`

#### Summary

The file name of the family that is being loaded into the document.

#### Since

2015

### `T:Autodesk.Revit.DB.Events.FamilyLoadingIntoDocumentEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.FamilyLoadingIntoDocumentEventArgs`

#### Summary

The event arguments used by the FamilyLoadingInto event.

#### Since

2015

### `M:Autodesk.Revit.DB.Events.FailuresProcessingEventArgs.GetFailuresAccessor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.FailuresProcessingEventArgs.GetFailuresAccessor`

#### Summary

Provides access to the failure information in the document.

#### Returns

The accessor to the failures in the document.

#### Since

2011

### `M:Autodesk.Revit.DB.Events.FailuresProcessingEventArgs.GetProcessingResult`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.FailuresProcessingEventArgs.GetProcessingResult`

#### Summary

Retrieves current status of the failures processing result.

#### Returns

The current failures processing result.

#### Since

2011

### `M:Autodesk.Revit.DB.Events.FailuresProcessingEventArgs.SetProcessingResult(Autodesk.Revit.DB.FailureProcessingResult)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.FailuresProcessingEventArgs.SetProcessingResult(Autodesk.Revit.DB.FailureProcessingResult)`

#### Summary

Sets the result of the failures processing accomplished during this event callback.

#### Remarks

If this value is not explicitly set, the default value (Continue) will be used. If the event callback
is resolving errors explicitly, it must be set to ProceedWithCommit - see the remarks for the
`T:Autodesk.Revit.DB.Events.FailuresProcessingEventArgs` object for more details.

Note that ProceedWithCommit should not be set if the handler has not resolved any errors - the
handler will be called again as a result of the commit request and Revit failure handling will
never be reached.

Setting this result may not affect the outcome if other observers of the event are invoked after this one.
The most prohibitive result set by all handlers will be used.

#### Parameter `result`

The result.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `T:Autodesk.Revit.DB.Events.FailuresProcessingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.FailuresProcessingEventArgs`

#### Summary

The event arguments used by the FailuresProcessing event.

#### Remarks

The event arguments provide access to the FailuresAccessor via `M:Autodesk.Revit.DB.Events.FailuresProcessingEventArgs.GetFailuresAccessor`
which contains the details of the errors and/or warnings that caused the event to trigger.

The arguments also allow you to set a processing result
via `M:Autodesk.Revit.DB.Events.FailuresProcessingEventArgs.SetProcessingResult(Autodesk.Revit.DB.FailureProcessingResult)` . The processing result determines if Revit will attempt to
recommit the currently failing transaction, roll it back, or continue. If you are explicitly
dismissing warnings from the event callback, a processing result of Continue is sufficient. But if you
are explicitly resolving errors from the event callback, you must change the processing result to ProceedWithCommit
to ensure that the user is not shown the dismissed errors. If you wish to cancel the transaction
silently without showing the errors to the user, set the processing result to ProceedWithRollback, however
you must also call `M:Autodesk.Revit.DB.FailureHandlingOptions.SetClearAfterRollback(System.Boolean)` in
order to dismiss the errors and silently cancel the transaction.

#### Since

2011

### `M:Autodesk.Revit.DB.FailureHandlingOptions.GetFailuresPreprocessor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureHandlingOptions.GetFailuresPreprocessor`

#### Summary

Gets the callback to be invoked in the beginning of failure processing.

#### Returns

The callback to be invoked in the beginning of failure processing.

#### Since

2011

### `M:Autodesk.Revit.DB.FailureHandlingOptions.GetTransactionFinalizer`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureHandlingOptions.GetTransactionFinalizer`

#### Summary

Gets the callback to be executed after transaction is completed.

#### Returns

The callback to be executed after transaction is completed.

#### Since

2011

### `M:Autodesk.Revit.DB.FailureHandlingOptions.GetDelayedMiniWarnings`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureHandlingOptions.GetDelayedMiniWarnings`

#### Summary

Obtains the flag indicating if showing of mini-warning dialog should be delayed until the end of next transaction.

#### Returns

True to delay the display of the mini-warning dialog until the end of the next transation, false to display them as this transaction is completed.

#### Since

2011

### `M:Autodesk.Revit.DB.FailureHandlingOptions.GetClearAfterRollback`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureHandlingOptions.GetClearAfterRollback`

#### Summary

Obtains the flag indicating if all posted failures should be removed silently when transaction is being rolled back.

#### Returns

True to clear posted failures silently if the transaction is being rolled back, false to keep these failures in place (they may be displayed to the user).

#### Since

2011

### `M:Autodesk.Revit.DB.FailureHandlingOptions.GetForcedModalHandling`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureHandlingOptions.GetForcedModalHandling`

#### Summary

Obtains the flag indicating if the error handling dialog shown at the end of the failing transaction should be modal.

#### Returns

True if the options force Revit to use a modal error dialog, false if it allows use of a non-blocking dialog for warnings resulting from this transaction.

#### Since

2011

### `M:Autodesk.Revit.DB.FailureHandlingOptions.SetFailuresPreprocessor(Autodesk.Revit.DB.IFailuresPreprocessor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureHandlingOptions.SetFailuresPreprocessor(Autodesk.Revit.DB.IFailuresPreprocessor)`

#### Summary

Sets the callback to be invoked in the beginning of failure processing.

#### Parameter `preprocessor`

The callback to be invoked in the beginning of failure processing.

#### Returns

This FailureHandlingOptions object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FailureHandlingOptions.SetTransactionFinalizer(Autodesk.Revit.DB.ITransactionFinalizer)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureHandlingOptions.SetTransactionFinalizer(Autodesk.Revit.DB.ITransactionFinalizer)`

#### Summary

Sets the callback to be executed after the transaction is completed.

#### Parameter `finalizer`

The callback to be executed after the transaction is completed.

#### Returns

This FailureHandlingOptions object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.FailureHandlingOptions.SetDelayedMiniWarnings(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureHandlingOptions.SetDelayedMiniWarnings(System.Boolean)`

#### Summary

Sets a flag indicating if Revit should delay the display of the mini-warning dialog (if one is to be shown as a result of warnings in the current transaction)
until the end of the next transaction.

#### Remarks

This controls warnings suitable for the mini-warnings dialog only. If the modal flag is set to true
with `M:Autodesk.Revit.DB.FailureHandlingOptions.SetForcedModalHandling(System.Boolean)` then this flag will be ignored.

#### Parameter `bFlag`

True to delay the display of the mini-warning dialog until the end of the next transation, false to display them as this transaction is completed.

#### Returns

This FailureHandlingOptions object.

#### Since

2011

### `M:Autodesk.Revit.DB.FailureHandlingOptions.SetClearAfterRollback(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureHandlingOptions.SetClearAfterRollback(System.Boolean)`

#### Summary

Sets a flag indicating that Revit should clear all posted failures silently when the failing transaction is being rolled back intentionally. If
not set, the failures may still be displayed to the user during rollback.

#### Parameter `bFlag`

True to clear posted failures silently if the transaction is being rolled back, false to keep these failures in place (they may be displayed to the user).

#### Returns

This FailureHandlingOptions object.

#### Since

2011

### `M:Autodesk.Revit.DB.FailureHandlingOptions.SetForcedModalHandling(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FailureHandlingOptions.SetForcedModalHandling(System.Boolean)`

#### Summary

Sets a flag indicating whether Revit will show a modal (blocking) error dialog if the transaction failed to finish.

#### Parameter `bFlag`

True to force Revit to use a modal error dialog, false to allow a non-blocking dialog for warnings resulting from this transaction.

#### Returns

This FailureHandlingOptions object.

#### Since

2011

### `P:Autodesk.Revit.DB.FailureHandlingOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FailureHandlingOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.FailureHandlingOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.FailureHandlingOptions`

#### Summary

Options to control how failures (if any occurred during the transaction)
should be handled at the time the transaction is being ended.

#### Since

2011

### `T:Autodesk.Revit.DB.FailureProcessingResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.FailureProcessingResult`

#### Summary

An enumerated type representing the result achieved by any of the available types of failure handlers:
FailuresPreprocessor, the handler of FailuresProcessing event or a FailuresProcessor.

#### Remarks

The ability to return certain values may be restricted for certain methods or for certain contexts.

#### Since

2011

### `F:Autodesk.Revit.DB.FailureProcessingResult.WaitForUserInput`

Member kind: field
Symbol: `Autodesk.Revit.DB.FailureProcessingResult.WaitForUserInput`

#### Summary

This value should only be returned by a FailuresProcessor - and only if it is waiting for something to happen externally.
Typically this would be some sort of user input needed to complete failures processing.
If this value is set from any other processor, it will be treated as ProceedWithRollback.

### `F:Autodesk.Revit.DB.FailureProcessingResult.ProceedWithRollBack`

Member kind: field
Symbol: `Autodesk.Revit.DB.FailureProcessingResult.ProceedWithRollBack`

#### Summary

This value should be returned if the transaction was originally requested to be committed and
the failure handler requires it to be rolled back instead.
In order to rollback silently, before ProceedWithRollBack is returned the failure handler should
set the FailureHandlingOptions to clear errors after rollback. This will cause all failures
to be deleted. If this is not set, default failure processing will continue, and
failures may be delivered to the user even though the transaction will be rolled back.

### `F:Autodesk.Revit.DB.FailureProcessingResult.ProceedWithCommit`

Member kind: field
Symbol: `Autodesk.Revit.DB.FailureProcessingResult.ProceedWithCommit`

#### Summary

This value should be used if some or all failures were resolved by the handler. It instructs the Revit
failure processing/transaction mechanism to try to repeat the transaction committing process.
Despite the request to commit to the transaction, there is no guarantee that the commit will succeed.
If errors remain unresolved the handler will likely be called again. Handler
code should be careful not to try to repeatedly commit if it is unable to deal with all the errors.
ProceedWithCommit cannot be used if the transaction is already being rolled back, and will be treated as ProceedWithRollBack in this case.

### `F:Autodesk.Revit.DB.FailureProcessingResult.Continue`

Member kind: field
Symbol: `Autodesk.Revit.DB.FailureProcessingResult.Continue`

#### Summary

This value should be used if no action was taken and/or caller should continue with default failure processing for the
open transaction. In the absence of any other available handlers, this means that the Revit user interface will
display any errors to the user for resolution. (Warnings will not be displayed if they have been deleted already
by the failure handler).
If a FailuresProcessor returns Continue with unresolved failures, Revit will instead act as if ProceedWithRollBack was returned.

### `T:Autodesk.Revit.DB.Events.ExternalDataTypeServerFailureResolutionExecutingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ExternalDataTypeServerFailureResolutionExecutingEventArgs`

#### Summary

The event arguments used by the ExternalDataTypeServerFailureResolutionExecuting event.

#### Since

2023

### `P:Autodesk.Revit.DB.Events.ExternalDataInstanceRemovedFromDocumentEventArgs.TypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ExternalDataInstanceRemovedFromDocumentEventArgs.TypeId`

#### Summary

The type id of the external data instance id that has been removed from Revit document.

#### Since

2023

### `T:Autodesk.Revit.DB.Events.ExternalDataInstanceRemovedFromDocumentEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ExternalDataInstanceRemovedFromDocumentEventArgs`

#### Summary

The event arguments used by the ExternalDataInstanceRemovedFrom event.

#### Since

2023

### `P:Autodesk.Revit.DB.Events.ExternalDataInstanceRemovingFromDocumentEventArgs.InstanceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ExternalDataInstanceRemovingFromDocumentEventArgs.InstanceId`

#### Summary

The Revit id of the external data instance being removed from Revit document.

#### Since

2023

### `P:Autodesk.Revit.DB.Events.ExternalDataInstanceRemovingFromDocumentEventArgs.TypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ExternalDataInstanceRemovingFromDocumentEventArgs.TypeId`

#### Summary

The type id of the external data instance id being removed from Revit document.

#### Since

2023

### `T:Autodesk.Revit.DB.Events.ExternalDataInstanceRemovingFromDocumentEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ExternalDataInstanceRemovingFromDocumentEventArgs`

#### Summary

The event arguments used by the ExternalDataInstanceRemovingFrom event.

#### Since

2023

### `P:Autodesk.Revit.DB.Events.ExternalDataInstanceAddedIntoDocumentEventArgs.NewInstanceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ExternalDataInstanceAddedIntoDocumentEventArgs.NewInstanceId`

#### Summary

The newly added external data instance id.

#### Since

2023

### `P:Autodesk.Revit.DB.Events.ExternalDataInstanceAddedIntoDocumentEventArgs.ItemId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ExternalDataInstanceAddedIntoDocumentEventArgs.ItemId`

#### Summary

The id of the external data item to which a new reference has been added.

#### Since

2023

### `P:Autodesk.Revit.DB.Events.ExternalDataInstanceAddedIntoDocumentEventArgs.ProjectId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ExternalDataInstanceAddedIntoDocumentEventArgs.ProjectId`

#### Summary

The id of the external project of the external data item to which a new reference has been added.

#### Since

2023

### `P:Autodesk.Revit.DB.Events.ExternalDataInstanceAddedIntoDocumentEventArgs.TypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ExternalDataInstanceAddedIntoDocumentEventArgs.TypeId`

#### Summary

The type id of the newly added external data instance id.

#### Since

2023

### `T:Autodesk.Revit.DB.Events.ExternalDataInstanceAddedIntoDocumentEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ExternalDataInstanceAddedIntoDocumentEventArgs`

#### Summary

The event arguments used by the ExternalDataInstanceAddedInto event.

#### Since

2023

### `P:Autodesk.Revit.DB.Events.ExternalDataInstanceAddingIntoDocumentEventArgs.TypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ExternalDataInstanceAddingIntoDocumentEventArgs.TypeId`

#### Summary

The type id of the newl external data instance that is being added.

#### Since

2023

### `T:Autodesk.Revit.DB.Events.ExternalDataInstanceAddingIntoDocumentEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ExternalDataInstanceAddingIntoDocumentEventArgs`

#### Summary

The event arguments used by the ExternalDataInstanceAddingInto event.

#### Since

2023

### `P:Autodesk.Revit.DB.Events.ElementTypeDuplicatedEventArgs.NewElementTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ElementTypeDuplicatedEventArgs.NewElementTypeId`

#### Summary

The id of the newly duplicated ElementType.

#### Since

2015

### `P:Autodesk.Revit.DB.Events.ElementTypeDuplicatedEventArgs.NewName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ElementTypeDuplicatedEventArgs.NewName`

#### Summary

The name of the newly duplicated ElementType.

#### Since

2015

### `P:Autodesk.Revit.DB.Events.ElementTypeDuplicatedEventArgs.OriginalElementTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ElementTypeDuplicatedEventArgs.OriginalElementTypeId`

#### Summary

The id of the element type that is duplicated.

#### Since

2015

### `T:Autodesk.Revit.DB.Events.ElementTypeDuplicatedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ElementTypeDuplicatedEventArgs`

#### Summary

The event arguments used by the ElementTypeDuplicated event.

#### Since

2015

### `P:Autodesk.Revit.DB.Events.ElementTypeDuplicatingEventArgs.ElementTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.ElementTypeDuplicatingEventArgs.ElementTypeId`

#### Summary

The id of the ElementType to be duplicated.

#### Since

2015

### `T:Autodesk.Revit.DB.Events.ElementTypeDuplicatingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.ElementTypeDuplicatingEventArgs`

#### Summary

The event arguments used by the ElementTypeDuplicating event.

#### Since

2015

### `M:Autodesk.Revit.DB.Events.DocumentWorksharingEnabledEventArgs.GetDocument`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.DocumentWorksharingEnabledEventArgs.GetDocument`

#### Summary

Returns document associated with this event

#### Returns

The document associated with this event.

#### Since

2015

### `T:Autodesk.Revit.DB.Events.DocumentWorksharingEnabledEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.DocumentWorksharingEnabledEventArgs`

#### Summary

The event arguments used by the DocumentWorksharingEnabled event.

#### Since

2015

### `T:Autodesk.Revit.DB.Events.DocumentOpenedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.DocumentOpenedEventArgs`

#### Summary

The event arguments used by the DocumentOpened event.

#### Since

2010

### `P:Autodesk.Revit.DB.Events.DocumentOpeningEventArgs.DocumentType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentOpeningEventArgs.DocumentType`

#### Summary

Type of the document, e.g. Project or Template.

#### Since

2010

### `P:Autodesk.Revit.DB.Events.DocumentOpeningEventArgs.PathName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentOpeningEventArgs.PathName`

#### Summary

Path of the document to be opened.

#### Since

2010

### `T:Autodesk.Revit.DB.Events.DocumentOpeningEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.DocumentOpeningEventArgs`

#### Summary

The event arguments used by the DocumentOpening event.

#### Since

2010

### `T:Autodesk.Revit.DB.Events.DocumentCreatedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.DocumentCreatedEventArgs`

#### Summary

The event arguments used by the DocumentCreated event.

#### Remarks

The newly created document is supplied in these arguments.

#### Since

2010

### `P:Autodesk.Revit.DB.Events.DocumentCreatingEventArgs.DocumentType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentCreatingEventArgs.DocumentType`

#### Summary

Type of the document which is about to be created, e.g. Project or Template.

#### Since

2010

### `P:Autodesk.Revit.DB.Events.DocumentCreatingEventArgs.Template`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentCreatingEventArgs.Template`

#### Summary

The template file path to be used for creating the new document.

#### Since

2010

### `T:Autodesk.Revit.DB.Events.DocumentCreatingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.DocumentCreatingEventArgs`

#### Summary

The event arguments used by the DocumentCreating event.

#### Since

2010

### `T:Autodesk.Revit.DB.DocumentType`

Member kind: type
Symbol: `Autodesk.Revit.DB.DocumentType`

#### Summary

Types of Revit documents.

#### Since

2010

### `F:Autodesk.Revit.DB.DocumentType.Other`

Member kind: field
Symbol: `Autodesk.Revit.DB.DocumentType.Other`

#### Summary

Document of another type.

### `F:Autodesk.Revit.DB.DocumentType.BuildingComponent`

Member kind: field
Symbol: `Autodesk.Revit.DB.DocumentType.BuildingComponent`

#### Summary

Building Component document.

### `F:Autodesk.Revit.DB.DocumentType.IFC`

Member kind: field
Symbol: `Autodesk.Revit.DB.DocumentType.IFC`

#### Summary

IFC document.

### `F:Autodesk.Revit.DB.DocumentType.Template`

Member kind: field
Symbol: `Autodesk.Revit.DB.DocumentType.Template`

#### Summary

Template document.

### `F:Autodesk.Revit.DB.DocumentType.Family`

Member kind: field
Symbol: `Autodesk.Revit.DB.DocumentType.Family`

#### Summary

Family document.

### `F:Autodesk.Revit.DB.DocumentType.Project`

Member kind: field
Symbol: `Autodesk.Revit.DB.DocumentType.Project`

#### Summary

Project document.

### `M:Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetTransactionNames`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetTransactionNames`

#### Summary

Returns names of the transactions associated with this event

#### Remarks

Typically, there will be only one name in the array, because document changes mostly involve just one transaction

#### Returns

The names of the transactions associated with this event

#### Since

2011

### `M:Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetDocument`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetDocument`

#### Summary

Returns document associated with this event

#### Returns

The document associated with this event.

#### Since

2011

### `M:Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetModifiedElementIds(Autodesk.Revit.DB.ElementFilter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetModifiedElementIds(Autodesk.Revit.DB.ElementFilter)`

#### Summary

Returns set of elements that were modified according to the given element filter.

#### Parameter `filter`

The element filter to be applied.

#### Returns

The set of ElementId for modified elements that pass the filter.
Returns empty set if no elements are found which pass the filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetModifiedElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetModifiedElementIds`

#### Summary

Returns set of elements that were modified.

#### Returns

The set of ElementId for elements that were modified.

#### Since

2011

### `M:Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetDeletedElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetDeletedElementIds`

#### Summary

Returns set of elements that were deleted from the document.

#### Returns

The set of ElementId for elements that were deleted from the document.

#### Since

2011

### `M:Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetAddedElementIds(Autodesk.Revit.DB.ElementFilter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetAddedElementIds(Autodesk.Revit.DB.ElementFilter)`

#### Summary

Returns set of newly added elements that pass the filter.

#### Parameter `filter`

The element filter to be applied.

#### Returns

The set of ElementId for newly added elements that pass the filter.
Returns empty set if no elements are found which pass the filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetAddedElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Events.DocumentChangedEventArgs.GetAddedElementIds`

#### Summary

Returns set of elements newly added to the document.

#### Returns

The set of ElementId for elements newly added to the document.

#### Since

2011

### `P:Autodesk.Revit.DB.Events.DocumentChangedEventArgs.Operation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Events.DocumentChangedEventArgs.Operation`

#### Summary

The operation associated with this event

#### Since

2011

### `T:Autodesk.Revit.DB.Events.DocumentChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.DocumentChangedEventArgs`

#### Summary

The event arguments used by the DocumentChanged event.

#### Since

2011

### `T:Autodesk.Revit.DB.Events.UndoOperation`

Member kind: type
Symbol: `Autodesk.Revit.DB.Events.UndoOperation`

#### Summary

The operation associated with DocumentChanged event

### `F:Autodesk.Revit.DB.Events.UndoOperation.TransactionRedone`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.UndoOperation.TransactionRedone`

#### Summary

A transaction was redone

### `F:Autodesk.Revit.DB.Events.UndoOperation.TransactionUndone`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.UndoOperation.TransactionUndone`

#### Summary

A transaction was undone

### `F:Autodesk.Revit.DB.Events.UndoOperation.TransactionGroupRolledBack`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.UndoOperation.TransactionGroupRolledBack`

#### Summary

A transaction group was rolled back

### `F:Autodesk.Revit.DB.Events.UndoOperation.TransactionRolledBack`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.UndoOperation.TransactionRolledBack`

#### Summary

A transaction was rolled back

### `F:Autodesk.Revit.DB.Events.UndoOperation.TransactionCommitted`

Member kind: field
Symbol: `Autodesk.Revit.DB.Events.UndoOperation.TransactionCommitted`

#### Summary

A transaction was committed

### `M:Autodesk.Revit.DB.SpecUtils.IsValidDataType(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpecUtils.IsValidDataType(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Returns true if the given ForgeTypeId identifies a valid parameter data type.

#### Remarks

A ForgeTypeId is acceptable as a parameter data type if it
identifies either a spec or a category. When a category
identifier is used as a parameter data type, it indicates a
Family Type parameter of that category.

#### Parameter `dataType`

The identifier to check.

#### Returns

True if the ForgeTypeId identifies either a spec or a category, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.SpecUtils.GetAllSpecs`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpecUtils.GetAllSpecs`

#### Summary

Gets the identifiers of all specs.

#### Returns

The spec identifiers.

#### Since

2022

### `M:Autodesk.Revit.DB.SpecUtils.IsSpec(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpecUtils.IsSpec(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether a ForgeTypeId identifies a spec.

#### Parameter `specTypeId`

The identifier to check.

#### Returns

True if the ForgeTypeId identifies a spec, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.SpecUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpecUtils`

#### Summary

A utility class of functions related to specs. A spec describes a data type that parameters can hold.

#### Since

2022

### `P:Autodesk.Revit.DB.StringParameterValue.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.StringParameterValue.Value`

#### Summary

The stored value

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.StringParameterValue.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StringParameterValue.#ctor(System.String)`

#### Summary

Value constructor

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.StringParameterValue.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.StringParameterValue.#ctor`

#### Summary

Default constructor

#### Since

2016 Subscription Update

### `T:Autodesk.Revit.DB.StringParameterValue`

Member kind: type
Symbol: `Autodesk.Revit.DB.StringParameterValue`

#### Summary

A class that holds a String value of a parameter element.

#### Since

2016 Subscription Update

### `P:Autodesk.Revit.DB.ElementIdParameterValue.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementIdParameterValue.Value`

#### Summary

The stored value

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.ElementIdParameterValue.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIdParameterValue.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Value constructor

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.ElementIdParameterValue.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementIdParameterValue.#ctor`

#### Summary

Default constructor

#### Since

2016 Subscription Update

### `T:Autodesk.Revit.DB.ElementIdParameterValue`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementIdParameterValue`

#### Summary

A class that holds a ElementId value of a parameter element.

#### Since

2016 Subscription Update

### `P:Autodesk.Revit.DB.DoubleParameterValue.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.DoubleParameterValue.Value`

#### Summary

The stored value

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.DoubleParameterValue.#ctor(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DoubleParameterValue.#ctor(System.Double)`

#### Summary

Value constructor

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.DoubleParameterValue.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DoubleParameterValue.#ctor`

#### Summary

Default constructor

#### Since

2016 Subscription Update

### `T:Autodesk.Revit.DB.DoubleParameterValue`

Member kind: type
Symbol: `Autodesk.Revit.DB.DoubleParameterValue`

#### Summary

A class that holds a Double value of a parameter element.

#### Since

2016 Subscription Update

### `P:Autodesk.Revit.DB.IntegerParameterValue.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntegerParameterValue.Value`

#### Summary

The stored value

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.IntegerParameterValue.#ctor(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IntegerParameterValue.#ctor(System.Int32)`

#### Summary

Value constructor

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.IntegerParameterValue.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.IntegerParameterValue.#ctor`

#### Summary

Default constructor

#### Since

2016 Subscription Update

### `T:Autodesk.Revit.DB.IntegerParameterValue`

Member kind: type
Symbol: `Autodesk.Revit.DB.IntegerParameterValue`

#### Summary

A class that holds an Integer value of a parameter element.

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.NullParameterValue.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.NullParameterValue.#ctor`

#### Summary

Default constructor

#### Since

2016 Subscription Update

### `T:Autodesk.Revit.DB.NullParameterValue`

Member kind: type
Symbol: `Autodesk.Revit.DB.NullParameterValue`

#### Summary

A class that represent an empty (null) value of a parameter element.

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.ParameterValue.IsSameType(Autodesk.Revit.DB.ParameterValue)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterValue.IsSameType(Autodesk.Revit.DB.ParameterValue)`

#### Summary

Tests another instance is of the same value type.

#### Parameter `other`

The instance to compare with

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.ParameterValue.IsEqual(Autodesk.Revit.DB.ParameterValue)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterValue.IsEqual(Autodesk.Revit.DB.ParameterValue)`

#### Summary

Tests equality with another instance of the same class.

#### Remarks

The result is always False if the two comparands are of a different value types.

#### Parameter `other`

The instance to compare with

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.ParameterValue.Copy`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterValue.Copy`

#### Summary

Makes an identical copy of the given parameter value.

#### Since

2016 Subscription Update

### `P:Autodesk.Revit.DB.ParameterValue.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterValue.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ParameterValue`

Member kind: type
Symbol: `Autodesk.Revit.DB.ParameterValue`

#### Summary

A class that holds a value of a parameter element.

#### Remarks

This is a non-instantiable base class.
Classes that actually store a value of a certain type are all
derived from this base class, once class per each value type.

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.ParameterUtils.IsEnumSchema(Autodesk.Revit.DB.InternalDefinition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.IsEnumSchema(Autodesk.Revit.DB.InternalDefinition)`

#### Summary

Checks whether the given parameter definition has a schema which declares values from an enumeration.

#### Parameter `paramDef`

The parameter definition to check.

#### Returns

True if the parameter definition has a schema which declares values from an enumeration, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ParameterUtils.GetParameterSchema(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.GetParameterSchema(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document)`

#### Summary

Gets the schema defining the given user-defined parameter.

#### Parameter `parameterId`

Identifier of the user-defined parameter to retrieve.

#### Parameter `document`

The document in which the specified parameter is defined.

#### Returns

The parameter schema as a JSON string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when parameterId does not identify a user-defined parameter in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ParameterUtils.DownloadCompanyName(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.DownloadCompanyName(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Downloads the name of the given parameter's owning account and records it in the given document. If the owning
account's name is already recorded in the given document, this method returns the name without downloading it
again.

#### Remarks

In Revit, the account name appears in the parameter tooltip if available.

#### Parameter `document`

Document in which to record the name of the parameter's owning account.

#### Parameter `parameterTypeId`

Parameter identifier.

#### Returns

Name of the owning account.

#### Exception `T:Autodesk.Revit.Exceptions.AccessDeniedException`

Thrown when the user is not authorized to access the requested information.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the parameter identifier does not include an account identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `!:Autodesk::Revit::Exceptions::NetworkCommunicationError`

Thrown when communication with the remote service is unsuccessful.

#### Exception `T:Autodesk.Revit.Exceptions.ResourceNotFoundException`

Thrown when the requested information is not found.

#### Exception `T:Autodesk.Revit.Exceptions.ServerInternalException`

Thrown when the remote service reports an internal error.

#### Exception `T:Autodesk.Revit.Exceptions.UnauthenticatedException`

Thrown when the user is not signed in.

#### Since

2024

### `M:Autodesk.Revit.DB.ParameterUtils.DownloadParameterOptions(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.DownloadParameterOptions(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Retrieves settings associated with the given parameter from the Parameters Service.

#### Remarks

The settings associated with a parameter definition are accessible only to an authorized user.
To retrieve them, the user must be signed in.

#### Parameter `parameterTypeId`

Parameter identifier.

#### Returns

Settings associated with a parameter.

#### Exception `T:Autodesk.Revit.Exceptions.AccessDeniedException`

Thrown when the user is not authorized to access the requested information.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the given parameter identifier is empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `!:Autodesk::Revit::Exceptions::NetworkCommunicationError`

Thrown when communication with the Parameters Service is unsuccessful.

#### Exception `T:Autodesk.Revit.Exceptions.ResourceNotFoundException`

Thrown when the requested parameter is not found.

#### Exception `T:Autodesk.Revit.Exceptions.ServerInternalException`

Thrown when the Parameters Service reports an internal error.

#### Exception `T:Autodesk.Revit.Exceptions.UnauthenticatedException`

Thrown when the user is not signed in.

#### Since

2024

### `M:Autodesk.Revit.DB.ParameterUtils.DownloadParameter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ParameterDownloadOptions,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.DownloadParameter(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ParameterDownloadOptions,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Create a shared parameter element in the given document according to a parameter definition downloaded from the Parameters Service.

#### Remarks

The identifier of a user-defined parameter definition on the Parameters Service has the form
"parameters.<accountId>:<schemaId>-<versionNumber>", where <versionNumber> is a
semantic version number such as "1.0.0" and <accountId> and <schemaId> are GUIDs consisting of
32 hexadecimal digits. Revit will extract the <schemaId> GUID to identify the shared parameter
element.

If a shared parameter with a matching GUID is not yet present in the document, this method will attempt
to obtain the parameter and apply the given bindings. If the parameter definition is already available
locally, Revit will use the local definition. Otherwise, Revit will attempt to download the requested
parameter definition from the Parameters Service.

The given document may be either a project or a family document. The rules for adding parameters to
project and family documents differ.

For family documents, requesting a parameter with a GUID matching that of a shared parameter already
present in the family document is an error.

Family parameters must have unique names. There is an error if the target document is a family and the
downloaded parameter is found to have a name that matches that of a parameter already present in the family
document.

Family parameters must be initialized to a default value. There is an error if the target document is a
family and the downloaded parameter is a Family Type parameter and no family of the requisite category
exists in the family document.

When the target document is a project, if a parameter exactly matching the given ForgeTypeId is already
present in the document, this method will not download anything. Otherwise, if a local shared parameter with
a GUID colliding with the given ForgeTypeId is already present in the project document, this method will
download the requested parameter from the Parameters Service, validate that the requested parameter is
compatible with the existing local definition, and overwrite the existing local definition according to the
downloaded definition. Attempting to download an incompatible definition that collides with an existing
local shared parameter is an error. If the parameter or a compatible local parameter is already present in
the target project document, this method will update the existing parameter's bindings according to the
given bindings. When updating bindings, new category bindings may be added to the existing parameter but
existing category bindings will not be removed.

#### Parameter `document`

Document in which to create a shared parameter from a downloaded definition.

#### Parameter `options`

Parameter download options.

#### Parameter `parameterTypeId`

Parameter identifier.

#### Returns

The shared parameter instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the parameter identifier does not include a GUID, when required bindings are not assigned, when
the requested group identifier does not identify a group that accommodates user-defined parameters, when a
parameter with a matching GUID is already present in the given family document, when the given project
document already contains an incompatible parameter definition with the same GUID, or when a parameter with
a matching name is already present in the given family document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DefaultValueException`

Thrown when the target document is a family and the downloaded parameter is a Family Type parameter and no
family of the requisite category exists in the family document.

#### Exception `T:Autodesk.Revit.Exceptions.NetworkCommunicationException`

Thrown when communication with the Parameters Service is unsuccessful.

#### Exception `T:Autodesk.Revit.Exceptions.ResourceNotFoundException`

Thrown when the requested parameter definition is not found on the Parameters Service.

#### Exception `T:Autodesk.Revit.Exceptions.SchemaException`

Thrown when there is an error interpreting a downloaded parameter definition.

#### Since

2024

### `M:Autodesk.Revit.DB.ParameterUtils.GetAllBuiltInParameters`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.GetAllBuiltInParameters`

#### Summary

Gets the identifiers of all built-in parameters.

#### Returns

The built-in parameter identifiers.

#### Since

2022

### `M:Autodesk.Revit.DB.ParameterUtils.IsBuiltInParameter(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.IsBuiltInParameter(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether an ElementId identifies a built-in parameter.

#### Remarks

An ElementId identifies a built-in parameter if it corresponds to a valid BuiltInParameter value.

#### Parameter `parameterId`

The identifier to check.

#### Returns

True if the ElementId identifies a built-in parameter, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.ParameterUtils.IsBuiltInParameter(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.IsBuiltInParameter(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether a ForgeTypeId identifies a built-in parameter.

#### Remarks

A ForgeTypeId identifies a built-in parameter if it corresponds to a valid BuiltInParameter value.

#### Parameter `parameterTypeId`

The identifier to check.

#### Returns

True if the ForgeTypeId identifies a built-in parameter, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ParameterUtils.GetAllBuiltInGroups`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.GetAllBuiltInGroups`

#### Summary

Gets the identifiers of all built-in parameter groups.

#### Returns

The built-in group identifiers.

#### Since

2022

### `M:Autodesk.Revit.DB.ParameterUtils.IsBuiltInGroup(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.IsBuiltInGroup(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether a ForgeTypeId identifies a built-in parameter group.

#### Remarks

A ForgeTypeId identifies a built-in parameter group if it corresponds to a valid BuiltInParameterGroup value.

#### Parameter `groupTypeId`

The identifier to check.

#### Returns

True if the ForgeTypeId identifies a built-in parameter group, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.ParameterUtils.GetBuiltInParameterGroup(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.GetBuiltInParameterGroup(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the BuiltInParameterGroup value corresponding to built-in parameter group identified by the given ForgeTypeId.

#### Parameter `groupTypeId`

The parameter group identifier.

#### Returns

The BuiltInParameterGroup value corresponding to the given parameter group identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

groupTypeId is not a built-in parameter group identifier. See IsBuiltInParameterGroup(ForgeTypeId) and GetParameterGroupTypeId(BuiltInParameter).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

### `M:Autodesk.Revit.DB.ParameterUtils.GetBuiltInParameter(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.GetBuiltInParameter(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the BuiltInParameter value corresponding to built-in parameter identified by the given ForgeTypeId.

#### Parameter `parameterTypeId`

The parameter identifier.

#### Returns

The BuiltInParameter value corresponding to the given parameter identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

parameterTypeId is not a built-in parameter identifier. See IsBuiltInParameter(ForgeTypeId) and GetParameterTypeId(BuiltInParameter).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

### `M:Autodesk.Revit.DB.ParameterUtils.GetParameterGroupTypeId(Autodesk.Revit.DB.BuiltInParameterGroup)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.GetParameterGroupTypeId(Autodesk.Revit.DB.BuiltInParameterGroup)`

#### Summary

Gets the ForgeTypeId identifying the built-in parameter group corresponding to BuiltInParameterGroup value.

#### Parameter `builtInParamGroup`

The BuiltInParameterGroup value.

#### Returns

Identifier of the parameter group corresponding to the given BuiltInParameterGroup value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.ParameterUtils.GetParameterTypeId(Autodesk.Revit.DB.BuiltInParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterUtils.GetParameterTypeId(Autodesk.Revit.DB.BuiltInParameter)`

#### Summary

Gets the ForgeTypeId identifying the built-in parameter corresponding to the given BuiltInParameter value.

#### Parameter `builtInParam`

The BuiltInParameter value.

#### Returns

Identifier of the parameter corresponding to the given BuiltInParameter value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `T:Autodesk.Revit.DB.ParameterUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.ParameterUtils`

#### Summary

A utility class of functions related to parameters.

#### Since

2022

### `M:Autodesk.Revit.DB.FormatOptions.CanUsePlusPrefix`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.CanUsePlusPrefix`

#### Summary

Checks whether a plus prefix can be displayed for the display unit in this FormatOptions.

#### Returns

True if a plus prefix can be displayed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.CanUsePlusPrefix(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.CanUsePlusPrefix(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether a plus prefix can be displayed for a given unit.

#### Parameter `unitTypeId`

Identifier of the unit.

#### Returns

True if a plus prefix can be displayed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.CanSuppressSpaces`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.CanSuppressSpaces`

#### Summary

Checks whether spaces can be suppressed for the display unit in this FormatOptions.

#### Returns

True if spaces can be suppressed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.CanSuppressSpaces(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.CanSuppressSpaces(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether spaces can be suppressed for a given unit.

#### Parameter `unitTypeId`

Identifier of the unit.

#### Returns

True if spaces can be suppressed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.CanSuppressLeadingZeros`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.CanSuppressLeadingZeros`

#### Summary

Checks whether leading zeros can be suppressed for the display unit in this FormatOptions.

#### Returns

True if leading zeros can be suppressed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.CanSuppressLeadingZeros(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.CanSuppressLeadingZeros(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether leading zeros can be suppressed for a given unit.

#### Parameter `unitTypeId`

Identifier of the unit.

#### Returns

True if leading zeros can be suppressed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.CanSuppressTrailingZeros`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.CanSuppressTrailingZeros`

#### Summary

Checks whether trailing zeros can be suppressed for the display unit in this FormatOptions.

#### Returns

True if trailing zeros can be suppressed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.CanSuppressTrailingZeros(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.CanSuppressTrailingZeros(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether trailing zeros can be suppressed for a given unit.

#### Parameter `unitTypeId`

Identifier of the unit.

#### Returns

True if trailing zeros can be suppressed, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.IsValidAccuracy(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.IsValidAccuracy(System.Double)`

#### Summary

Checks whether an accuracy is valid for the display unit in this FormatOptions.

#### Remarks

See the `P:Autodesk.Revit.DB.FormatOptions.Accuracy` property for details on
valid accuracy values.

#### Parameter `accuracy`

The accuracy to check.

#### Returns

True if the accuracy is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.IsValidAccuracy(Autodesk.Revit.DB.ForgeTypeId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.IsValidAccuracy(Autodesk.Revit.DB.ForgeTypeId,System.Double)`

#### Summary

Checks whether an accuracy is valid for a given unit.

#### Remarks

See the `P:Autodesk.Revit.DB.FormatOptions.Accuracy` property for details on
valid accuracy values.

#### Parameter `unitTypeId`

Identifier of the unit.

#### Parameter `accuracy`

The accuracy to check.

#### Returns

True if the accuracy is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.GetValidSymbols`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.GetValidSymbols`

#### Summary

Gets the identifiers of all valid symbols for the unit in this FormatOptions.

#### Returns

Identifiers of the valid symbols.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.GetValidSymbols(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.GetValidSymbols(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the identifiers of all valid symbols for a given unit.

#### Parameter `unitTypeId`

Identifier of the unit.

#### Returns

Identifiers of the valid symbols.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.IsValidSymbol(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.IsValidSymbol(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether a symbol is valid for the unit in this FormatOptions.

#### Parameter `symbolTypeId`

Identifier of the symbol to check.

#### Returns

True if the symbol is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.IsValidSymbol(Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.IsValidSymbol(Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether a symbol is valid for a given unit.

#### Parameter `unitTypeId`

Identifier of the unit.

#### Parameter `symbolTypeId`

Identifier of the symbol to check.

#### Returns

True if the symbol is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.CanHaveSymbol`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.CanHaveSymbol`

#### Summary

Checks whether a symbol can be specified to display the unit in this FormatOptions.

#### Returns

True if a symbol can be specified, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.CanHaveSymbol(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.CanHaveSymbol(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether a symbol can be specified to display a given unit.

#### Parameter `unitTypeId`

Identifier of the unit.

#### Returns

True if a symbol can be specified, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.SetSymbolTypeId(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.SetSymbolTypeId(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Sets the symbol that should be displayed to indicate the unit quantifying the value.

#### Parameter `symbolTypeId`

The symbol identifier. An empty identifier string indicates no symbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

symbolTypeId is not a valid symbol for the unit in this FormatOptions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.GetSymbolTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.GetSymbolTypeId`

#### Summary

Gets the identifier of the symbol indicating the unit quantifying the value.

#### Returns

The symbol identifier. An empty identifier string indicates no symbol.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.IsValidForSpec(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.IsValidForSpec(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether this FormatOptions is valid for a given spec.

#### Remarks

The FormatOptions is valid if UseDefault is true or if the unit in
the FormatOptions is valid for the spec. See
`M:Autodesk.Revit.DB.UnitUtils.IsValidUnit(Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ForgeTypeId)` and
`M:Autodesk.Revit.DB.UnitUtils.GetValidUnits(Autodesk.Revit.DB.ForgeTypeId)` .

#### Parameter `specTypeId`

Identifier of the spec.

#### Returns

True if the FormatOptions is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.SetUnitTypeId(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.SetUnitTypeId(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Sets the unit used to quantify values.

#### Parameter `unitTypeId`

The unit identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.GetUnitTypeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.GetUnitTypeId`

#### Summary

Gets the identifier of the unit used to quantify values.

#### Remarks

Most units, such as square feet or degrees, are formatted as decimal
decimal numbers. Other units may be displayed with specialized
formatting methods like "feet and fractional inches" or "degrees,
minutes and seconds".

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `P:Autodesk.Revit.DB.FormatOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormatOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.FormatOptions.RoundingMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormatOptions.RoundingMethod`

#### Summary

The method used to round values: round to nearest, round up, or round down.

#### Remarks

The RoundingMethod property is currently only supported for rebar parameters.
A FormatOptions object containing any rounding method may be returned by Element.GetParameterFormatOptions() and may be passed to the formatting and parsing utilities in the UnitFormatUtils class.
FormatOptions objects used in other contexts must contain the default rounding method (Nearest).

#### Value

The rounding method. The default is Nearest.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2016

### `P:Autodesk.Revit.DB.FormatOptions.UseDigitGrouping`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormatOptions.UseDigitGrouping`

#### Summary

Indicates if digit grouping symbols should be displayed.

#### Remarks

When UseDigitGrouping is true, digit grouping symbols (i.e.
thousands separators) will be displayed when needed. For example,
123456789.00 may be displayed as 123,456,789.00. The precise
display is determined by the DigitGroupingSymbol and
DigitGroupingAmount properties of the Units class.

#### Value

True if digit grouping symbols should be displayed, false otherwise. The default is false.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `P:Autodesk.Revit.DB.FormatOptions.UsePlusPrefix`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormatOptions.UsePlusPrefix`

#### Summary

Indicates if a plus sign prefix should be displayed for positive and zero values.

#### Remarks

This property is applicable to length display units (e.g.
meters or feet). It is not currently supported for other unit
types like area or force. The UI also does not permit it to be
enabled in the Units class that represents the document's default
settings, but that restriction is not enforced in the API.

When UsePlusPrefix is true, a plus sign ("+") will be
displayed before positive and zero values, just as a minus sign
("-") is displayed before negative values. For example, 1.234 will
be displayed as +1.234 and 0.0 will be displayed as +0.0.

#### Value

True if a plus prefix should be displayed, false otherwise. The default is false.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.
-or-
When setting this property: UsePlusPrefix was set to true but a plus prefix cannot be displayed for the display unit in this FormatOptions.

#### Since

2014

### `P:Autodesk.Revit.DB.FormatOptions.SuppressSpaces`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormatOptions.SuppressSpaces`

#### Summary

Indicates if spaces around the dash should be suppressed in feet and fractional inches.

#### Remarks

This property is applicable to display units related to feet
and fractional inches:

DUT_FEET_FRACTIONAL_INCHES

DUT_RISE_OVER_FOOT

DUT_RISE_OVER_10_FEET

When SuppressLeadingZeros is true, spaces will not be
inserted before and after the dash separating feet from
inches. For example, 1' - 2 3/4" will be displayed as
1'-2 3/4".

#### Value

True if spaces should be suppressed, false otherwise. The default is false.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.
-or-
When setting this property: SuppressSpaces was set to true but spaces cannot be suppressed for the display unit in this FormatOptions.

#### Since

2014

### `P:Autodesk.Revit.DB.FormatOptions.SuppressLeadingZeros`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormatOptions.SuppressLeadingZeros`

#### Summary

Indicates if leading zeros should be suppressed in feet and fractional inches.

#### Remarks

This property is applicable to display units related to feet
and fractional inches:

DUT_FEET_FRACTIONAL_INCHES

DUT_RISE_OVER_FOOT

DUT_RISE_OVER_10_FEET

When SuppressLeadingZeros is true:

If the foot component of the value is zero (the value is less
than one foot), it will not be displayed. For example, 0' - 2 3/4"
will be displayed as 2 3/4".

If both the foot and integer inch components of the value are
zero (the value is less than one inch), neither will be displayed.
For example, 0' - 0 3/4" will be displayed as 3/4".

However, an integer inch component of zero will be displayed
if the foot component is non-zero. For example 1' - 0 3/4" will be
displayed as 1' - 0 3/4".

#### Value

True if leading zeros should be suppressed, false otherwise. The default is false.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.
-or-
When setting this property: SuppressLeadingZeros was set to true but leading zeros cannot be suppressed for the display unit in this FormatOptions.

#### Since

2014

### `P:Autodesk.Revit.DB.FormatOptions.SuppressTrailingZeros`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormatOptions.SuppressTrailingZeros`

#### Summary

Indicates if trailing zeros after the decimal point should be
suppressed.

#### Remarks

This property is applicable to display units which are
formatted as a decimal number. It is not applicable to the
following display units which have specialized formatting:

DUT_GENERAL

DUT_FEET_FRACTIONAL_INCHES

DUT_FRACTIONAL_INCHES

DUT_METERS_CENTIMETERS

DUT_DEGREES_AND_MINUTES

DUT_RISE_OVER_INCHES

DUT_RISE_OVER_120_INCHES

DUT_RISE_OVER_FOOT

DUT_RISE_OVER_10_FEET

When SuppressTrailingZeros is true, trailing zeros to the
right of the decimal point will not be displayed. For example,
1.200 will be displayed as 1.2.

Trailing zeros are always suppressed for DUT_GENERAL, and the
SuppressTrailingZeros property is not used.

#### Value

True if trailing zeros should be suppressed, false otherwise. The default is false.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.
-or-
When setting this property: SuppressTrailingZeros was set to true but trailing zeros cannot be suppressed for the display unit in this FormatOptions.

#### Since

2014

### `P:Autodesk.Revit.DB.FormatOptions.Accuracy`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormatOptions.Accuracy`

#### Summary

The accuracy to which values will be rounded.

#### Remarks

Formatted values will be rounded to the nearest multiple of
the accuracy value.

Accuracy is specified in display units, not in Revit's
internal units.

For DUT_GENERAL, the accuracy value is always 0.000001 and
cannot be set to another value. DUT_GENERAL is a special display
unit that always rounds to six decimal places and suppresses
trailing zeros, roughly equivalent to DUT_FIXED with the accuracy
set to 0.000001 and SuppressTrailingZeros set to true.

For other display units, a wide range of accuracy values may
be specified. All values from 1.0e-12 to 1.0e12 will be accepted,
but the specified value will be automatically adjusted to the
nearest supported value if necessary. For best results, the
accuracy value should be chosen to be compatible with the display
unit:

For most display units, the value is displayed as a decimal
number, and the accuracy should typically be a power of 10, for
example 1.0 to round to 0 decimal places or 0.001 to round to 3
decimal places. Other values can be used, for example 0.25 to
round to the nearest 0.25 (displayed with 2 decimal places) or
2.0 to round to the nearest even integer (displayed with 0 decimal
places). The specified accuracy will automatically be rounded to
the nearest positive multiple of 1.0e-12.

For DUT_FRACTIONAL_INCHES, DUT_RISE_OVER_INCHES, and
DUT_RISE_OVER_120_INCHES, the accuracy should typically be a power
of 2, for example 0.25 to round to the nearest 1/4". Other values
can be used, for example 6.0 to round to the nearest 6" or 1.5 to
round to the nearest 1 1/2". For DUT_FEET_FRACTIONAL_INCHES,
DUT_RISE_OVER_FOOT, and DUT_RISE_OVER_10_FEET, similar accuracy
values can be used but they must be divided by 12 because the
accuracy is specified in feet. The specified accuracy will
automatically be rounded to the nearest positive multiple of
1/2^20 inches.

For DUT_DEGREES_AND_MINUTES, the accuracy should typically
be a power of 10 divided by 3600 to round seconds to a specific
number of decimal places, for example 1.0 / 3600.0 to round seconds
to 0 decimal places or 0.01 / 3600.0 to round seconds to 2 decimal
places. The specified accuracy will automatically be rounded to
the nearest positive multiple of 1.0e-8 seconds.

#### Value

The accuracy. The default depends on the display unit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: accuracy is not a valid accuracy for the display unit in this FormatOptions.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

UseDefault is true in this FormatOptions.

#### Since

2014

### `P:Autodesk.Revit.DB.FormatOptions.UseDefault`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormatOptions.UseDefault`

#### Summary

Indicates whether default or custom formatting should be used.

#### Remarks

If UseDefault is true, formatting will be according to the default
settings in the Units class, and none of the other settings in the
object are meaningful. If UseDefault is false, the object contains
custom settings that override the default settings in the Units
class. UseDefault is always false for FormatOptions objects in the
Units class.

#### Value

True if default formatting should be used; false if custom formatting should be used.

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.#ctor(Autodesk.Revit.DB.FormatOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.#ctor(Autodesk.Revit.DB.FormatOptions)`

#### Summary

Creates a copy of a FormatOptions object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.#ctor(Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.#ctor(Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Creates a new FormatOptions object that represents custom formatting.

#### Parameter `unitTypeId`

Identifier of the unit to display.

#### Parameter `symbolTypeId`

Identifier of the symbol with which to render the unit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).
-or-
symbolTypeId is not a valid symbol for unitTypeId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.#ctor(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.#ctor(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Creates a new FormatOptions object that represents custom formatting.

#### Parameter `unitTypeId`

Identifier of the unit to display.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.FormatOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormatOptions.#ctor`

#### Summary

Creates a new FormatOptions object that represents default formatting.

#### Since

2014

### `T:Autodesk.Revit.DB.FormatOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.FormatOptions`

#### Summary

Options for formatting numbers with units.

#### Remarks

The FormatOptions class contains settings that control how to
format numbers with units as strings. It contains those settings that
are typically chosen by an end user in the Format dialog and stored in
the document.

The FormatOptions class is used in two different ways. A
FormatOptions object in the `T:Autodesk.Revit.DB.Units` class
represents the default settings for the document. A FormatOptions
object used elsewhere represents settings that may optionally override
the default settings.

The `P:Autodesk.Revit.DB.FormatOptions.UseDefault` property controls
whether a FormatOptions object represents default or custom
formatting. If UseDefault is true, formatting will be according to
the default settings in the Units class, and none of the other
settings in the object are meaningful. If UseDefault is false, the
object contains custom settings that override the default settings in
the Units class. UseDefault is always false for FormatOptions objects
in the Units class.

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.GetTypeCatalogStringForUnit(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.GetTypeCatalogStringForUnit(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the string used in type catalogs to identify a given unit.

#### Parameter `unitTypeId`

Identifier of the unit.

#### Returns

The type catalog string, or an empty string if the unit cannot be used in type catalogs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.GetTypeCatalogStringForSpec(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.GetTypeCatalogStringForSpec(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the string used in type catalogs to identify a given measurable spec.

#### Parameter `specTypeId`

Identifier of the measurable spec.

#### Returns

The type catalog string, or an empty string if the measurable spec cannot be used in type catalogs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.GetAllDisciplines`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.GetAllDisciplines`

#### Summary

Gets the identifiers of all available disciplines.

#### Returns

The discipline identifiers.

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.GetDiscipline(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.GetDiscipline(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the discipline for a given measurable spec.

#### Parameter `specTypeId`

Identifier of the measurable spec.

#### Returns

Identifier of the discipline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.IsSymbol(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.IsSymbol(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether a ForgeTypeId identifies a symbol.

#### Remarks

The SymbolTypeId class offers symbol identifiers.

#### Parameter `symbolTypeId`

The identifier to check.

#### Returns

True if the ForgeTypeId identifies a symbol, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.IsUnit(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.IsUnit(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether a ForgeTypeId identifies a unit.

#### Remarks

The UnitTypeId class offers unit identifiers.

#### Parameter `unitTypeId`

The identifier to check.

#### Returns

True if the ForgeTypeId identifies a unit, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.GetValidUnits(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.GetValidUnits(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the identifiers of all valid units for a given measurable spec.

#### Parameter `specTypeId`

Identifier of the measurable spec.

#### Returns

Identifiers of the valid units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.IsValidUnit(Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.IsValidUnit(Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether a unit is valid for a given measurable spec.

#### Parameter `specTypeId`

Identifier of the measurable spec.

#### Parameter `unitTypeId`

Identifier of the unit to check.

#### Returns

True if the unit is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.GetAllUnits`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.GetAllUnits`

#### Summary

Gets the identifiers of all available units.

#### Returns

The unit identifiers.

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.GetAllMeasurableSpecs`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.GetAllMeasurableSpecs`

#### Summary

Gets the identifiers of all available measurable specs.

#### Returns

The spec identifiers.

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.IsMeasurableSpec(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.IsMeasurableSpec(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks whether a ForgeTypeId identifies a spec associated with units of measurement.

#### Parameter `specTypeId`

The identifier to check.

#### Returns

True if the ForgeTypeId identifies a measurable spec, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.ConvertToInternalUnits(System.Double,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.ConvertToInternalUnits(System.Double,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Converts a value from a given unit to Revit's internal units.

#### Parameter `value`

The value to convert.

#### Parameter `unitTypeId`

Identifier of the unit quantifying the value.

#### Returns

The converted value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for value is not finite
-or-
unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.ConvertFromInternalUnits(System.Double,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.ConvertFromInternalUnits(System.Double,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Converts a value from Revit's internal units to a given unit.

#### Parameter `value`

The value to convert.

#### Parameter `unitTypeId`

Identifier of the desired unit.

#### Returns

The converted value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for value is not finite
-or-
unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.UnitUtils.Convert(System.Double,Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.UnitUtils.Convert(System.Double,Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Converts a value from one unit to another, such as square feet to square meters.

#### Parameter `value`

The value to convert.

#### Parameter `currentUnitTypeId`

Identifier of the current unit.

#### Parameter `desiredUnitTypeId`

Identifier of the desired unit.

#### Returns

The converted value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for value is not finite
-or-
currentUnitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).
-or-
desiredUnitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

currentUnitTypeId and desiredUnitTypeId have different dimensions.

#### Since

2014

### `T:Autodesk.Revit.DB.UnitUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.UnitUtils`

#### Summary

A utility class of functions related to units.

#### Since

2014

### `T:Autodesk.Revit.DB.RoundingMethod`

Member kind: type
Symbol: `Autodesk.Revit.DB.RoundingMethod`

#### Summary

Rounding methods

#### Since

2016

#### Since

2016

### `F:Autodesk.Revit.DB.RoundingMethod.Down`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoundingMethod.Down`

#### Summary

Round Down

### `F:Autodesk.Revit.DB.RoundingMethod.Up`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoundingMethod.Up`

#### Summary

Round Up

### `F:Autodesk.Revit.DB.RoundingMethod.Nearest`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoundingMethod.Nearest`

#### Summary

Standard rounding: Round to Nearest

### `M:Autodesk.Revit.DB.GlobalParametersManager.ShouldHandleGlobalParameters(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.ShouldHandleGlobalParameters(Autodesk.Revit.DB.Document)`

#### Summary

For performance reasons sometimes we don't want to handle Global Parameters processing
when there are no Global Parameters in the project.

#### Returns

True if Global Parameters are allowed and there is at least one global parameter in the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.GlobalParametersManager.DissociateFromProperty(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.DissociateFromProperty(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Dissociates an element's property from a global parameter (any currently associated)

#### Remarks

It is assumed that the property has been previously associated with this
global parameter by using the `M:Autodesk.Revit.DB.GlobalParametersManager.AssociateWithProperty(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)` method.

#### Parameter `document`

Document containing the element of which property is to be dissociated

#### Parameter `elementId`

Id of an element in the given document

#### Parameter `parameterId`

Id of the given element's parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementId does not exist in the document
-or-
Property with the given parameterId is not parameterizable, and thus cannot be driven by a global parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.GlobalParametersManager.AssociateWithProperty(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.AssociateWithProperty(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Associates a global parameter with a property of the given element.

#### Remarks

The given property (parameter) must be parameterizable, meaning it cannot be
read-only, driven by a formula, or have any other restrictions imposed by Revit.

The parameter's value type must match the type of this global parameter.

Once associated property can be later dissociated by calling the
`M:Autodesk.Revit.DB.GlobalParametersManager.DissociateFromProperty(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)` method

#### Parameter `document`

Document containing a global parameter and an element to be associated with

#### Parameter `gpId`

Id of a global parameter contained by the given document

#### Parameter `elementId`

Id of an element in the given document

#### Parameter `parameterId`

Id of the given element's parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input gpId is not of a valid global parameter of the given document.
-or-
The element elementId does not exist in the document
-or-
Property with the given parameterId is either not parameterizable or does not match the type of the global parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.GlobalParametersManager.GetGlobalParameterAssociatedWithProperty(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.GetGlobalParameterAssociatedWithProperty(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns a global parameter, if any, currently associated with the given element property.

#### Remarks

InvalidElementId is returned in case the property is not associated with any global parameter.
InvalidElementId is also returned if called for a parameter that cannot even be associated
with a global parameters (i.e. a non-parametrizable parameter or parameter with a formula).

#### Parameter `document`

Document containing the given element and its parameter

#### Parameter `elementId`

Id of an element in the given document

#### Parameter `parameterId`

Id of the given element's parameter

#### Returns

Id of a global parameter or InvalidElemetnId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementId does not exist in the document

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.GlobalParametersManager.CanElementParameterAndGPBeAssociated(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GlobalParametersManager.CanElementParameterAndGPBeAssociated(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Tests whether a given parameter of an element can be associated with any global parameter.

#### Remarks

Only properties defined as parametrizable can be associated with global parameters.
That excludes any read-only and formula-driven parameters, as well as those that
have other explicit or implicit restrictions imposed by Revit.

#### Parameter `document`

Document containing the given element and its parameter

#### Parameter `gpId`

Id of a global parameter element

#### Parameter `elementId`

Id of an element in the given document

#### Parameter `parameterId`

Id of the given element's parameter

#### Returns

True if the given parameter is parametrizable and matches the type of the given global parameter; False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input gpId is not of a valid global parameter of the given document.
-or-
The element elementId does not exist in the document

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016 Subscription Update
