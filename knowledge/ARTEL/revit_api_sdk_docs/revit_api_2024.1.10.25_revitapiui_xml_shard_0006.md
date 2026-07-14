# ARTEL Revit API 2024 XML Documentation

Product: ARTEL
Document type: REVIT_API_SDK_DOC
Source kind: Revit SDK XML documentation
Revit API version: 2024.1.10.25
Assembly: RevitAPIUI
Source file: RevitAPIUI.xml
Source XML SHA-256: 6ad274f5fb15a6f8b1d145fd485ff977695b72b99039fa1ff55779bcb47a91f1
Package URL: https://api.nuget.org/v3-flatcontainer/autodesk.revit.sdk/2024.1.10.25/autodesk.revit.sdk.2024.1.10.25.nupkg
Package SHA-256: 72e2be30d84f438e6d9d9eeb92ff99a7674dfbcbe906c2dcaf9229b75c5cff43
Shard: 6
Member count: 62

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPIUI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.GetRibbonPanels(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.GetRibbonPanels(System.String)`

#### Summary

Get all the custom Panels on a designated Revit tab.

#### Parameter `tabName`

The name of the tab on which the panels are located.

#### Remarks

Built-in panels will not be included. tabName must be the name of one of the tabs added
by `M:Autodesk.Revit.UI.UIApplication.CreateRibbonTab(System.String)` .
This method is not supported in Macros.

### `M:Autodesk.Revit.UI.UIControlledApplication.GetRibbonPanels(Autodesk.Revit.UI.Tab)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.GetRibbonPanels(Autodesk.Revit.UI.Tab)`

#### Summary

Get all the custom Panels on a designated standard Revit tab.

#### Parameter `tab`

The tab on which the panels are located.

#### Remarks

Built-in panels will not be included. This method is not supported in Macros.

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.GetRibbonPanels(Autodesk.Revit.UI.Tab)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.GetRibbonPanels(Autodesk.Revit.UI.Tab)`

#### Summary

Get all the custom Panels on a designated standard Revit tab.

#### Parameter `tab`

The tab on which the panels are located.

#### Remarks

Built-in panels will not be included. This method is not supported in Macros.

### `M:Autodesk.Revit.UI.UIControlledApplication.GetRibbonPanels`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.GetRibbonPanels`

#### Summary

Get all the custom Panels on Add-Ins tab of Revit.

#### Remarks

The built-in panels won't be included and the panels added to tabs other than Add-Ins will not be included.
This method is not supported in Macros.

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.GetRibbonPanels`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.GetRibbonPanels`

#### Summary

Get all the custom Panels on Add-Ins tab of Revit.

#### Remarks

The built-in panels won't be included and the panels added to tabs other than Add-Ins will not be included.
This method is not supported in Macros.

### `M:Autodesk.Revit.UI.UIControlledApplication.CreateRibbonPanel(Autodesk.Revit.UI.Tab,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.CreateRibbonPanel(Autodesk.Revit.UI.Tab,System.String)`

#### Summary

Create a new RibbonPanel on the designated standard Revit tab.

#### Parameter `tab`

The target tab, on which the new panel will be created.

#### Parameter `panelName`

The name of the panel to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

panelName is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

panelName is Empty or the tab is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If more than 100 panels were created or the tab cannot be found.

#### Remarks

This method will create a custom panel appending to the specified tab. This method is not supported in Macros.

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.CreateRibbonPanel(Autodesk.Revit.UI.Tab,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.CreateRibbonPanel(Autodesk.Revit.UI.Tab,System.String)`

#### Summary

Create a new RibbonPanel on the designated standard Revit tab.

#### Parameter `tab`

The target tab, on which the new panel will be created.

#### Parameter `panelName`

The name of the panel to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

panelName is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

panelName is Empty or the tab is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If more than 100 panels were created or the tab cannot be found.

#### Remarks

This method will create a custom panel appending to the specified tab. This method is not supported in Macros.

### `M:Autodesk.Revit.UI.UIControlledApplication.CreateRibbonPanel(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.CreateRibbonPanel(System.String)`

#### Summary

Create a new RibbonPanel on the Add-Ins tab.

#### Parameter `panelName`

The name of the panel to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

panelName is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

panelName is Empty.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If more than 100 panels were created.

#### Remarks

This method will create a custom panel appending to the Revit AddIns tab. This method is not supported in Macros.

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.CreateRibbonPanel(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.CreateRibbonPanel(System.String)`

#### Summary

Create a new RibbonPanel on the Add-Ins tab.

#### Parameter `panelName`

The name of the panel to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

panelName is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

panelName is Empty.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If more than 100 panels were created.

#### Remarks

This method will create a custom panel appending to the Revit AddIns tab. This method is not supported in Macros.

### `M:Autodesk.Revit.UI.UIControlledApplication.CreateRibbonPanel(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.CreateRibbonPanel(System.String,System.String)`

#### Summary

Create a new RibbonPanel on the specified tab.

#### Parameter `tabName`

The name of the tab, on which the new panel will be created.

#### Parameter `panelName`

The name of the panel to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

tabName or panelName is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

tabName or panelName is Empty.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Too many panels have been added to this tab (Maximum is 100).

#### Remarks

This method will create a custom panel appending to the specified tab. This method is not supported in Macros.

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.CreateRibbonPanel(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.CreateRibbonPanel(System.String,System.String)`

#### Summary

Create a new RibbonPanel on the specified tab.

#### Parameter `tabName`

The name of the tab, on which the new panel will be created.

#### Parameter `panelName`

The name of the panel to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

tabName or panelName is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

tabName or panelName is Empty.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Too many panels have been added to this tab (Maximum is 100).

#### Remarks

This method will create a custom panel appending to the specified tab. This method is not supported in Macros.

### `M:Autodesk.Revit.UI.UIControlledApplication.CreateRibbonTab(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.CreateRibbonTab(System.String)`

#### Summary

Creates a new tab on the Revit user interface.

#### Parameter `tabName`

The name of the tab to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

tabName or panelName is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

tabName or panelName is Empty or the tab name duplicates the name of another tab in the Revit UI.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Too many custom tabs have been created in this session. (Maximum is 20).

#### Remarks

This method will create a custom tab at the end of the list of static tabs. If multiple tabs are added, they will be shown in the order added. This method is not supported in Macros.

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.CreateRibbonTab(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.CreateRibbonTab(System.String)`

#### Summary

Creates a new tab on the Revit user interface.

#### Parameter `tabName`

The name of the tab to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

tabName or panelName is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

tabName or panelName is Empty or the tab name duplicates the name of another tab in the Revit UI.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Too many custom tabs have been created in this session. (Maximum is 20).

#### Remarks

This method will create a custom tab at the end of the list of static tabs. If multiple tabs are added, they will be shown in the order added. This method is not supported in Macros.

### `M:Autodesk.Revit.UI.UIControlledApplication.PostCommand(Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.PostCommand(Autodesk.Revit.UI.RevitCommandId)`

#### Summary

Posts the command to the Revit message queue to be invoked when control returns from the current API context.

#### Parameter `commandId`

The command Id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when commandId is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If the command cannot be posted.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If there is a command already been posted.

#### Since

2014

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.PostCommand(Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.PostCommand(Autodesk.Revit.UI.RevitCommandId)`

#### Summary

Posts the command to the Revit message queue to be invoked when control returns from the current API context.

#### Parameter `commandId`

The command Id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when commandId is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If the command cannot be posted.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If there is a command already been posted.

#### Since

2014

### `M:Autodesk.Revit.UI.UIControlledApplication.CanPostCommand(Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.CanPostCommand(Autodesk.Revit.UI.RevitCommandId)`

#### Summary

Identifies if the given command can be posted, using `M:Autodesk.Revit.UI.UIApplication.PostCommand(Autodesk.Revit.UI.RevitCommandId)` .

#### Parameter `commandId`

The command Id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when commandId is `null` .

#### Remarks

Only members of Autodesk.Revit.UI.PostableCommand or external commands can be posted.

#### Since

2014

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.CanPostCommand(Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.CanPostCommand(Autodesk.Revit.UI.RevitCommandId)`

#### Summary

Identifies if the given command can be posted, using `M:Autodesk.Revit.UI.UIApplication.PostCommand(Autodesk.Revit.UI.RevitCommandId)` .

#### Parameter `commandId`

The command Id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when commandId is `null` .

#### Remarks

Only members of Autodesk.Revit.UI.PostableCommand or external commands can be posted.

#### Since

2014

### `M:Autodesk.Revit.UI.UIControlledApplication.DoDragDrop(System.Object,Autodesk.Revit.UI.IDropHandler)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.DoDragDrop(System.Object,Autodesk.Revit.UI.IDropHandler)`

#### Summary

Initiates a drag and drop operation with a custom drop implementation.

#### Parameter `dropData`

Any arbitrary data to be passed to the drop handler when the drop occurs.

#### Parameter `handler`

The handler to be executed when the drop occurs.

#### Remarks

When the user inputs `T:Autodesk.Revit.UI.IControllableDropHandler` ,
it allows the handler to verify whether the drop event can be executed on the given view;
When the user inputs `T:Autodesk.Revit.UI.IDropHandler`
the handler will be executed without any condition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when dropData or handler is `null` .

#### Since

2013

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.DoDragDrop(System.Object,Autodesk.Revit.UI.IDropHandler)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.DoDragDrop(System.Object,Autodesk.Revit.UI.IDropHandler)`

#### Summary

Initiates a drag and drop operation with a custom drop implementation.

#### Parameter `dropData`

Any arbitrary data to be passed to the drop handler when the drop occurs.

#### Parameter `handler`

The handler to be executed when the drop occurs.

#### Remarks

When the user inputs `T:Autodesk.Revit.UI.IControllableDropHandler` ,
it allows the handler to verify whether the drop event can be executed on the given view;
When the user inputs `T:Autodesk.Revit.UI.IDropHandler`
the handler will be executed without any condition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when dropData or handler is `null` .

#### Since

2013

### `M:Autodesk.Revit.UI.UIControlledApplication.DoDragDrop(System.Collections.Generic.ICollection{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.DoDragDrop(System.Collections.Generic.ICollection{System.String})`

#### Summary

Initiates a drag and drop operation of a collection of file names on the Revit user interface.

#### Remarks

The behavior after the 'dragData' dragged onto Revit is listed bellow:
Only one AutoCAD format or image file dragged onto Revit: a new import placement editor will be started for import the file;

More than one AutoCAD format or image files dragged onto Revit: a new import placement editor will be started only for the first AutoCAD format or image file;

Only one family file dragged onto Revit: the family will be loaded, and an editor will be started to place the family;

More than one family files dragged onto Revit: all the families will be loaded;

More than one family files including other format files dragged onto Revit: Revit will try to open all the files;

If a valid file or list of files is passed, Revit will do its best to use them appropriately. If any files are not usable, failure will be signalled to the interactive Revit user (and will not be signalled to the application with an exception).

#### Parameter `dropData`

The list of file paths and names.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when dropData is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

Thrown when dropData contains a file that doens't exist.

#### Since

2013

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.DoDragDrop(System.Collections.Generic.ICollection{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.DoDragDrop(System.Collections.Generic.ICollection{System.String})`

#### Summary

Initiates a drag and drop operation of a collection of file names on the Revit user interface.

#### Remarks

The behavior after the 'dragData' dragged onto Revit is listed bellow:
Only one AutoCAD format or image file dragged onto Revit: a new import placement editor will be started for import the file;

More than one AutoCAD format or image files dragged onto Revit: a new import placement editor will be started only for the first AutoCAD format or image file;

Only one family file dragged onto Revit: the family will be loaded, and an editor will be started to place the family;

More than one family files dragged onto Revit: all the families will be loaded;

More than one family files including other format files dragged onto Revit: Revit will try to open all the files;

If a valid file or list of files is passed, Revit will do its best to use them appropriately. If any files are not usable, failure will be signalled to the interactive Revit user (and will not be signalled to the application with an exception).

#### Parameter `dropData`

The list of file paths and names.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when dropData is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

Thrown when dropData contains a file that doens't exist.

#### Since

2013

### `P:Autodesk.Revit.UI.UIControlledApplication.DrawingAreaExtents`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIControlledApplication.DrawingAreaExtents`

#### Summary

Get the rectangle that represents the screen pixel coordinates of drawing area.

#### Remarks

The drawing area of the Revit window displays views (and sheets and schedules) of projects.
The size of drawing area restricts the max size of the view titles and windows, the value may be empty if modal browser is opened.
If there is no project opened, null will be returned.

#### Since

2011

### `P:Autodesk.Revit.VSTA.ApplicationEntryPoint.DrawingAreaExtents`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.DrawingAreaExtents`

#### Summary

Get the rectangle that represents the screen pixel coordinates of drawing area.

#### Remarks

The drawing area of the Revit window displays views (and sheets and schedules) of projects.
The size of drawing area restricts the max size of the view titles and windows, the value may be empty if modal browser is opened.
If there is no project opened, null will be returned.

#### Since

2011

### `P:Autodesk.Revit.UI.UIControlledApplication.MainWindowExtents`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIControlledApplication.MainWindowExtents`

#### Summary

Get the rectangle that represents the screen pixel coordinates of the Revit main window.

#### Since

2011

### `P:Autodesk.Revit.VSTA.ApplicationEntryPoint.MainWindowExtents`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.MainWindowExtents`

#### Summary

Get the rectangle that represents the screen pixel coordinates of the Revit main window.

#### Since

2011

### `P:Autodesk.Revit.UI.UIControlledApplication.ActiveUIDocument`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIControlledApplication.ActiveUIDocument`

#### Summary

Provides access to an object that represents the currently active project.

#### Remarks

External API commands can access this property in read-only mode only!
The ability to modify the property is reserved for future implementations.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when attempting to modify the property.

### `P:Autodesk.Revit.VSTA.ApplicationEntryPoint.ActiveUIDocument`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.ActiveUIDocument`

#### Summary

Provides access to an object that represents the currently active project.

#### Remarks

External API commands can access this property in read-only mode only!
The ability to modify the property is reserved for future implementations.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when attempting to modify the property.

### `M:Autodesk.Revit.UI.UIApplication.#ctor(Autodesk.Revit.ApplicationServices.ControlledApplication)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.#ctor(Autodesk.Revit.ApplicationServices.ControlledApplication)`

#### Summary

Use a database level Application to construct a UI-level Application.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the Application argument is a null pointer.

### `M:Autodesk.Revit.UI.UIControlledApplication.#ctor(Autodesk.Revit.ApplicationServices.Application)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.#ctor(Autodesk.Revit.ApplicationServices.Application)`

#### Summary

Use a database level Application to construct a UI-level Application.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the Application argument is a null pointer.

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.#ctor(Autodesk.Revit.ApplicationServices.Application)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.#ctor(Autodesk.Revit.ApplicationServices.Application)`

#### Summary

Use a database level Application to construct a UI-level Application.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the Application argument is a null pointer.

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.UpdateAllOpenViews`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.UpdateAllOpenViews`

#### Summary

Update all open views in this document after elements have been changed, deleted, selected or de-selected.
Graphics in the views are fully redrawn regardless of which elements have changed.

#### Remarks

This function should only rarely be needed, but might be required when working with graphics drawn from outside of Revit's transactions and elements,
for example, when using `T:Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer` .

This function is potentially expensive as many views may be updated at once, including regeneration of view's geometry and redisplay of graphics.
Thus for most situations it is recommended that API applications rely on the Revit application framework to update views more deliberately.

#### Since

2018

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.GetPlacementTypes(Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.GetPlacementTypes(Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.View)`

#### Summary

Get a collection of valid placement types for input family symbol.

#### Parameter `familySymbol`

The family symbol.

#### Parameter `pDBView`

The view in which the family instance will be placed in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.SaveAs(Autodesk.Revit.UI.UISaveAsOptions)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.SaveAs(Autodesk.Revit.UI.UISaveAsOptions)`

#### Summary

Saves the document to a file name obtained from the Revit user optionally prompting the user to overwrite file if it exists.

#### Remarks

This method may not be called unless all transactions, sub-transactions, and transaction groups that were opened by the API code were closed.

That also implies that this method cannot be called during dynamic updates.

#### Parameter `options`

UI options for the SaveAs operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

SaveAs may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Is not a primary document, it is a linked document.
-or-
SaveAs is temporarily disabled.
-or-
Thrown if there are any transactions, sub-transactions or transaction groups which
were opened by the API code, and not closed. All of these items must be handled
before attempting to save the document.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown if saving is cancelled by an external application during 'DocumentSavingAs' event.

#### Since

2016

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.SaveAs`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.SaveAs`

#### Summary

Saves the document to a file name obtained from the Revit user without prompting the user to overwrite file if it exists.

#### Remarks

This method may not be called unless all transactions, sub-transactions, and transaction groups that were opened by the API code were closed.

That also implies that this method cannot be called during dynamic updates.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

SaveAs may not be called during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Is not a primary document, it is a linked document.
-or-
SaveAs is temporarily disabled.
-or-
Thrown if there are any transactions, sub-transactions or transaction groups which
were opened by the API code, and not closed. All of these items must be handled
before attempting to save the document.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown if saving is cancelled by an external application during 'DocumentSavingAs' event.

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.CanPlaceElementType(Autodesk.Revit.DB.ElementType)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.CanPlaceElementType(Autodesk.Revit.DB.ElementType)`

#### Summary

Verifies that the user can be prompted to place the input element type interactively.

#### Remarks

If an element type can be placed interactively, it may be used as input to `M:Autodesk.Revit.UI.UIDocument.PostRequestForElementTypePlacement(Autodesk.Revit.DB.ElementType)`
to have the user place an instance of the element. However, this function does not evaluate whether that element instance may
actually be placed in the current active view.

#### Parameter `elementType`

The ElementType.

#### Returns

True if the user can be prompted to place the input element type interactively, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.PromptToMatchElementType(Autodesk.Revit.DB.ElementType)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.PromptToMatchElementType(Autodesk.Revit.DB.ElementType)`

#### Summary

Prompts the user to select elements to change them to the input type.

#### Remarks

This method uses its own transaction, so it's not permitted to be invoked in an active transaction.
In a single invocation, the user can select multiple elements to be modified to the given type, until they finish.

#### Parameter `elementType`

The ElementType applied to selected instances.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This document is not the currently active one.
-or-
Starting a new transaction is not permitted. It could be because
another transaction already started and has not been completed yet,
or the document is in a state in which it cannot start a new transaction.

#### Since

2015

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.PromptToPlaceElementTypeOnLegendView(Autodesk.Revit.DB.ElementType)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.PromptToPlaceElementTypeOnLegendView(Autodesk.Revit.DB.ElementType)`

#### Summary

Prompts the user to place an element type onto a legend view.

#### Remarks

This method works only for non-annotation element types.
For annotations, use PromptForFamilyInstancePlacement(Autodesk::Revit::DB::FamilySymbol) instead.
This method uses its own transaction, so it's not permitted to be invoked in an active transaction.
The user is not permitted to change the active legend view or
during this placement operation (the operation will be cancelled).
In a single invocation, the user can place multiple instances of the input element type until they finish the
placement (with Cancel or ESC or a click elsewhere in the UI).

#### Parameter `elementType`

The ElementType of which instances are to be placed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input element type does not belong to a model-level category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This document is not the currently active one.
-or-
Starting a new transaction is not permitted. It could be because
another transaction already started and has not been completed yet,
or the document is in a state in which it cannot start a new transaction.
-or-
Thrown when the active view isn't a legend view.
-or-
Can not create this kind of element in legend view.

#### Since

2015

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.PostRequestForElementTypePlacement(Autodesk.Revit.DB.ElementType)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.PostRequestForElementTypePlacement(Autodesk.Revit.DB.ElementType)`

#### Summary

Places a request on Revit's command queue for the user to place instances of the specified ElementType. This does not execute immediately,
but instead when control returns to Revit from the current API context.

#### Remarks

This method starts its own transaction. In a single invocation, the user can place multiple instances of the input element type
until they finish the placement (with Cancel or ESC or a click elsewhere in the UI). This method invokes the UI when control returns
from the current API context; because of this, the normal Revit UI options will be available to the user, but the API will not be
notified when the user has completed this action. Because this request is queued to run at the end of the current API context,
only one such request can be set (between this and the commands set by UIApplication.PostCommand()). This differs from
PromptForFamilyInstancePlacement() as that method can be run within the current API context, but the user is not permitted
full access to the user interface options during placement.

#### Parameter `elementType`

The ElementType of which instances are to be placed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The user cannot be prompted to place the input type interactively.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This document is not the currently active one.
-or-
Starting a new transaction is not permitted. It could be because
another transaction already started and has not been completed yet,
or the document is in a state in which it cannot start a new transaction.

#### Since

2015

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.PromptToPlaceViewOnSheet(Autodesk.Revit.DB.View,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.PromptToPlaceViewOnSheet(Autodesk.Revit.DB.View,System.Boolean)`

#### Summary

Prompts the user to place a specified view onto a sheet.

#### Remarks

This method opens its own transaction, so it's not permitted to be invoked in an active transaction.
In a single invocation, the user can place only one view onto the active sheet.

The user is not permitted to change the active sheet view or the view to be placed
during this placement operation (the operation will be cancelled).

The user can cancel the placement operation by pressing Cancel or ESC or a click elsewhere in the UI.

This method can't be used to place a schedule on a sheet.
Use `T:Autodesk.Revit.DB.ScheduleSheetInstance` Create() to add schedules to sheets.

#### Parameter `view`

The view to insert onto a sheet.

#### Parameter `allowReplaceExistingSheetViewport`

A indicator which allows the user to replace the existing viewport.

If true, the viewport representing this view will be replaced by the new viewport created during placement.
If the view is allowed only to be on one sheet, this will remove the viewport from the old sheet.
If the view is allowed to be on multiple sheets, and the view is currently placed on the active sheet,
the old viewport on this sheet will be replaced.

If false, if the view is only allowed to be on one sheet,
or if the view is allowed to be on multiple sheets but is already on the active sheet, an exception will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This view is a view template.
-or-
view is a schedule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This document is not the currently active one.
-or-
Starting a new transaction is not permitted. It could be because
another transaction already started and has not been completed yet,
or the document is in a state in which it cannot start a new transaction.
-or-
The active view isn't a sheet where a view can be placed.
-or-
The view can't be placed on the sheet. For schedule views use ScheduleSheetInstance::Create() to place them on sheets.
-or-
Thrown when replacing an existing viewport isn't allowed. See allowReplaceExistingSheetViewport parameter documentation for details.

#### Since

2015

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.GetSketchGalleryOptions(Autodesk.Revit.DB.FamilySymbol)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.GetSketchGalleryOptions(Autodesk.Revit.DB.FamilySymbol)`

#### Summary

Gets the valid sketch gallery options of a family symbol.

#### Parameter `familySymbol`

The family symbol.

#### Returns

The valid list of SketchGalleryOptions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.VSTA.DocumentEntryPoint.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.VSTA.DocumentEntryPoint.ActiveGraphicalView`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.ActiveGraphicalView`

#### Summary

The currently active graphical view of the currently active document.

#### Remarks

This property is applicable to the currently active document only.
Returns `null` if this document doesn't represent the active document.

#### Since

2015

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.GetOpenUIViews`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.GetOpenUIViews`

#### Summary

Get a list of all open view windows in the Revit user interface.

#### Remarks

A sheet view with an activated viewport will return the view associated with the activated viewport, not the sheet view.

### `P:Autodesk.Revit.VSTA.DocumentEntryPoint.Application`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.Application`

#### Summary

Retrieves an object that represents the current Application.

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.PromptForFamilyInstancePlacement(Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.PromptForFamilyInstancePlacement(Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions)`

#### Summary

Prompts the user to place instances of the specified FamilySymbol.

#### Parameter `familySymbol`

The FamilySymbol.

#### Parameter `options`

The PromptForFamilyInstancePlacementOptions, to place the family instance according to the options.

#### Remarks

This method opens its own transaction, so it's not permitted to be invoked in an active transaction.
In a single invocation, the user can place multiple instances of the input family type until they finish the
placement (with Cancel or ESC or a click elsewhere in the UI). The user will not be permitted to change the type to be placed.
Users are not permitted to change the active view during this placement operation (the operation will be completed).

This method differs from `M:Autodesk.Revit.UI.UIDocument.PostRequestForElementTypePlacement(Autodesk.Revit.DB.ElementType)` in that it will execute immediately
within the current API context and return to the application when the user completes or cancels the operation. However,
it does not allow the user access to user interface options and settings related to the placement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when
the family symbol should be of category OST_DuctTerminal because PlaceAirTerminalOnDuct in options is true,
or the sketch gallery options in options is invalid,
or the placement type for the family symbol in options is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when
this API method is invoked in an active transaction,
or this document is not active,
or this is a family document and the instances of this family symbol can not exist in the current family,
or this family symbol has no command to create instance,
or the command to create instance is disabled in active view.

#### Since

2015

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.PromptForFamilyInstancePlacement(Autodesk.Revit.DB.FamilySymbol)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.PromptForFamilyInstancePlacement(Autodesk.Revit.DB.FamilySymbol)`

#### Summary

Prompts the user to place instances of the specified FamilySymbol.

#### Parameter `familySymbol`

The FamilySymbol.

#### Remarks

This method opens its own transaction, so it's not permitted to be invoked in an active transaction.
In a single invocation, the user can place multiple instances of the input family type until they finish the
placement (with Cancel or ESC or a click elsewhere in the UI). The user will not be permitted to change the type to be placed.
Users are not permitted to change the active view during this placement operation (the operation will be completed).

This method differs from `M:Autodesk.Revit.UI.UIDocument.PostRequestForElementTypePlacement(Autodesk.Revit.DB.ElementType)` in that it will execute immediately
within the current API context and return to the application when the user completes or cancels the operation. However,
it does not allow the user access to user interface options and settings related to the placement.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when
this API method is invoked in an active transaction,
or this document is not active,
or this is a family document and the instances of this family symbol can not exist in the current family,
or this family symbol has no command to create instance,
or the command to create instance is disabled in active view.

#### Since

2011

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.RequestViewChange(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.RequestViewChange(Autodesk.Revit.DB.View)`

#### Summary

Requests an asynchronous change of the active view in the currently active document.

#### Parameter `view`

The View.

#### Since

2015

#### Remarks

This method requests to change the active view by posting a message asynchronously.
Unlike setting the `P:Autodesk.Revit.UI.UIDocument.ActiveView` property,
this will not make the change in active view immediately. Instead the request will be posted
to occur when control returns to Revit from the API context. This method is permitted to change
the active view from the Idling event or an ExternalEvent callback.

The active view cannot be changed when:
There is an open transaction in the currently active document.`P:Autodesk.Revit.DB.Document.IsModifiable` is true.`P:Autodesk.Revit.DB.Document.IsReadOnly` is true.ViewActivating, ViewActivated, or any pre-event (such as DocumentSaving) is being handled.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

If the 'view' argument is NULL.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If the given view is not a valid view of the document; -or-
If the given view is a template view; -or-
If the given view is an internal view.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If the given view is not from the currently active document; -or-
If the active document is currently modifiable (i.e. with an active transaction); -or-
If the active document is currently in read-only state; -or-
During either ViewActivating or ViewActivated event; -or-
During any pre-action kind of event, such as DocumentSaving, etc.

### `P:Autodesk.Revit.VSTA.DocumentEntryPoint.Document`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.Document`

#### Summary

Returns the database level document represented by this UI-level document.

### `P:Autodesk.Revit.VSTA.DocumentEntryPoint.ActiveView`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.ActiveView`

#### Summary

The currently active view of the currently active document.

#### Since

2012

#### Remarks

This property is applicable to the currently active document only.
Returns `null` if this document doesn't represent the active document.

The active view can only be changed when:
There is no open transaction.`P:Autodesk.Revit.DB.Document.IsModifiable` is false.`P:Autodesk.Revit.DB.Document.IsReadOnly` is false.ViewActivating, ViewActivated, and any pre-action of events (such as DocumentSaving or DocumentClosingevents) are not being handled.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting the property: If the 'view' argument is NULL.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting the property:
If the given view is not a valid view of the document; -or-If the given view is a template view; -or-If the given view is an internal view.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting the property:
If the document is not currently active; -or-If the document is currently modifiable (i.e. with an active transaction); -or-If the document is currently in read-only state; -or-When invoked during either ViewActivating or ViewActivated event; -or-When invoked during any pre-action kind of event, such as DocumentSaving, DocumentClosing, etc.

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.RefreshActiveView`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.RefreshActiveView`

#### Summary

Refresh the display of the active view in the active document.

#### Since

2011

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.ShowElements(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.ShowElements(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Shows the elements by zoom to fit.

#### Parameter `elementIds`

The set of element ids which will be shown.

#### Remarks

Places all the elements on the screen by moving the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

elementIds is null.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Member of elementIds is null.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Member of elementIds is not valid.

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.ShowElements(Autodesk.Revit.DB.ElementSet)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.ShowElements(Autodesk.Revit.DB.ElementSet)`

#### Summary

Shows the elements by zoom to fit.

#### Parameter `elements`

The set of elements that will be shown.

#### Remarks

Places all the elements on the screen by moving the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Elements is null.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Member of elements is null.

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.ShowElements(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.ShowElements(Autodesk.Revit.DB.Element)`

#### Summary

Shows the element by zoom to fit.

#### Parameter `element`

Element that will be shown.

#### Remarks

Places the element in the center of screen by moving the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Element is null.

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.ShowElements(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.ShowElements(Autodesk.Revit.DB.ElementId)`

#### Overloads

Shows one or more elements by zoom to fit.

#### Summary

Shows the element by zoom to fit.

#### Parameter `elementId`

Element id that will be shown.

#### Remarks

Places the element in the center of screen by moving the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Element id is not valid.

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.SaveAndClose`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.SaveAndClose`

#### Summary

Close the document, prompting the user for saving it when necessary.

#### Returns

False if closing procedure fails or if saving of a modified document was requested but failed.
Also returns False if closing is cancelled by an external application during 'DocumentClosing' event.
When function succeeds, True is returned.

#### Remarks

UI dialogs may be shown during the call (e.g. when the document has been changed since last time it was saved) to get user responses.
The currently active document may not be closed by this function. It can only be closed via Revit's UI.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when attempting to close the currently active document.
Thrown if there are any transactions, sub-transactions or transaction groups which
were opened by the API code, and not closed. All of these items must be handled
before attempting to close the document.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if this a linked file.

### `P:Autodesk.Revit.VSTA.DocumentEntryPoint.Selection`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.Selection`

#### Summary

Retrieve the currently selected Elements in Autodesk Revit.

#### Remarks

Returns an object that represents the active selection. The Selection property returns an
object that represents the active selection when the command was started.

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.GetRevitUIFamilyLoadOptions`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.GetRevitUIFamilyLoadOptions`

#### Summary

Return the option object that allows you to use Revit's dialog boxes to let the user respond to questions that arise during loading of families.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if
this API method is invoked in UI less mode

### `M:Autodesk.Revit.VSTA.DocumentEntryPoint.#ctor(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.DocumentEntryPoint.#ctor(Autodesk.Revit.DB.Document)`

#### Summary

Use a database level Document to construct a UI-level Document.

#### Parameter `document`

The database level document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a primary document, it is a linked document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.UIControlledApplication.#ctor(Autodesk.Revit.ApplicationServices.ControlledApplication)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.#ctor(Autodesk.Revit.ApplicationServices.ControlledApplication)`

#### Summary

Use a database level Application to construct a UI-level Application.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the Application argument is a null pointer.

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.#ctor(Autodesk.Revit.ApplicationServices.ControlledApplication)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.#ctor(Autodesk.Revit.ApplicationServices.ControlledApplication)`

#### Summary

Use a database level Application to construct a UI-level Application.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the Application argument is a null pointer.

### `M:Autodesk.Revit.UI.UIControlledApplication.#ctor(Autodesk.Revit.ApplicationServices.ControlledApplication)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.#ctor(Autodesk.Revit.ApplicationServices.ControlledApplication)`

#### Summary

Use a database level Application to construct a UI-level Application.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the Application argument is a null pointer.

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.#ctor(Autodesk.Revit.ApplicationServices.ControlledApplication)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.#ctor(Autodesk.Revit.ApplicationServices.ControlledApplication)`

#### Summary

Use a database level Application to construct a UI-level Application.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the Application argument is a null pointer.
