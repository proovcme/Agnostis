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
Shard: 5
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPIUI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `P:Autodesk.Revit.UI.RibbonItemData.LongDescription`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonItemData.LongDescription`

#### Summary

Long description of the command tooltip

#### Remarks

It will be used as part of the button's extended
tooltip. This tooltip is shown when the mouse hovers over the command for a long amount
of time. You can split the text of this option into multiple paragraphs by placing <p>
tags around each paragraph. Optional. If neither of this property and TooltipImage is
supplied, the button will not have an extended tooltip.
SplitButton and RadioButtonGroup cannot display the tooltip set by this method, the SplitButton will
always show the current PushButton tooltip, and RadioButtonGroup has no tooltip.

### `P:Autodesk.Revit.UI.RibbonItemData.ToolTip`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonItemData.ToolTip`

#### Summary

The description that appears as a ToolTip for the item.

#### Remarks

The text that is displayed when the mouse pointer moves over the item.
SplitButton and RadioButtonGroup cannot display the tooltip set by this method, the SplitButton will
always show the current PushButton tooltip, and RadioButtonGroup has no tooltip.

### `P:Autodesk.Revit.UI.RibbonItemData.Name`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonItemData.Name`

#### Summary

The name of the item.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when setting the value to `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when setting the value to an empty string.

### `T:Autodesk.Revit.UI.RibbonItemData`

Member kind: type
Symbol: `Autodesk.Revit.UI.RibbonItemData`

#### Summary

Base class used to contain information necessary to construct a RibbonItem in the Ribbon.

### `M:Autodesk.Revit.UI.RibbonItem.SetContextualHelp(Autodesk.Revit.UI.ContextualHelp)`

Member kind: method
Symbol: `Autodesk.Revit.UI.RibbonItem.SetContextualHelp(Autodesk.Revit.UI.ContextualHelp)`

#### Summary

Sets the contextual help bound with this button.

#### Parameter `contextualHelp`

The contextual help.

#### Since

2013

### `M:Autodesk.Revit.UI.RibbonItem.GetContextualHelp`

Member kind: method
Symbol: `Autodesk.Revit.UI.RibbonItem.GetContextualHelp`

#### Summary

Gets the contextual help bound with this control.

#### Returns

The contextual help assigned to the item, or `null` if there is no binding assigned.

#### Since

2013

### `M:Autodesk.Revit.UI.RibbonItem.Equals(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.UI.RibbonItem.Equals(System.Object)`

#### Summary

Determines whether the specified `T:System.Object` is equal to the current `T:System.Object` .

#### Parameter `obj`

Another panel object.

### `P:Autodesk.Revit.UI.RibbonItem.ItemType`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonItem.ItemType`

#### Summary

Gets the item type.

### `P:Autodesk.Revit.UI.RibbonItem.Visible`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonItem.Visible`

#### Summary

Gets or sets a value indicating whether the item is visible.

#### Remarks

When the Visible property is set to false, the item won't be displayed on Ribbon.

#### Since

2011

### `P:Autodesk.Revit.UI.RibbonItem.Enabled`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonItem.Enabled`

#### Summary

Gets or sets a value indicating whether the item is enabled.

#### Remarks

When the Enabled property is set to false, the item cannot be clicked,
and the item's appearance changes. The Image and Text assigned to the item appear grayed
out. For pushbuttons, the button may be enabled programmatically but be disabled in the user interface
because of the Revit context; see the property IsEnabledByContext for RibbonButton.

### `P:Autodesk.Revit.UI.RibbonItem.ToolTipImage`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonItem.ToolTipImage`

#### Summary

The image to show as a part of the button extended tooltip

#### Remarks

Shown when the cursor hovers over the command.
If neither this property nor LongDescription is supplied, the button will not have
an extended tooltip. Maximum height or width is 355 pixels.
SplitButton and RadioButtonGroup cannot display the tooltip set by this method. SplitButton
shows the current PushButton tooltip and RadioButtonGroup has no tooltip.

### `P:Autodesk.Revit.UI.RibbonItem.LongDescription`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonItem.LongDescription`

#### Summary

Long description of the command tooltip

#### Remarks

It will be used as part of the button's extended
tooltip. This tooltip is shown when the mouse hovers over the command for a long amount
of time. You can split the text of this option into multiple paragraphs by placing <p>
tags around each paragraph. Optional. If neither of this property and TooltipImage is
supplied, the button will not have an extended tooltip.
SplitButton and RadioButtonGroup cannot display the tooltip set by this method, the SplitButton will
always show the current PushButton tooltip, and RadioButtonGroup has no tooltip.

### `P:Autodesk.Revit.UI.RibbonItem.ToolTip`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonItem.ToolTip`

#### Summary

The description that appears as a ToolTip for the item.

#### Remarks

The text that is displayed when the mouse pointer moves over the item.
SplitButton and RadioButtonGroup cannot display the tooltip set by this method, the SplitButton will
always show the current PushButton tooltip, and RadioButtonGroup has no tooltip.

### `P:Autodesk.Revit.UI.RibbonItem.ItemText`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonItem.ItemText`

#### Summary

Gets or sets the text displayed on the item.

#### Remarks

The text can be changed at run time. `null` or empty string is not allowed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when setting the text to empty or to the string contains "%".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when setting the text to `null` .

### `P:Autodesk.Revit.UI.RibbonItem.Name`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonItem.Name`

#### Summary

The name of the item.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when setting the text to empty or to the string contains "%".

### `T:Autodesk.Revit.UI.RibbonItem`

Member kind: type
Symbol: `Autodesk.Revit.UI.RibbonItem`

#### Summary

The RibbonItem object represents an item on RibbonPanel, can be a push-button or a pull-down
which should contain the information for creating one RibbonItem.

#### Remarks

This class is not supported in Revit Macros.

### `M:Autodesk.Revit.UI.ContextualHelp.Launch`

Member kind: method
Symbol: `Autodesk.Revit.UI.ContextualHelp.Launch`

#### Summary

Launches and displays the help topic specified by the contents of this ContextualHelp object.

#### Since

2013

### `P:Autodesk.Revit.UI.ContextualHelp.HelpTopicUrl`

Member kind: property
Symbol: `Autodesk.Revit.UI.ContextualHelp.HelpTopicUrl`

#### Summary

The help topic URL.

#### Remarks

Applies only to objects of type ContextualHelpType.ChmFile. If empty or `null` , the default page of the help file will be displayed.
Obtain the URL by:
Open the chm file and go to the page you want to show.

Right click on the page, and choose the Properties command.

In the middle of properties page there is a property called: Address (URL).
The end of the URL contains the topic URL used to open the help file to the correct page.
Here is an example: mk:@MSITStore:C:\RevitAPI2013.chm::/WhatsNew.htm
The help topic URL of this page is "WhatsNew.htm".
Another example: mk:@MSITStore:C:\RevitAPI2013.chm::/html/329b02eb-5ee4-1715-2fbf-2cbbc0d3ff2a.htm
The help topic URL of this page is "html/329b02eb-5ee4-1715-2fbf-2cbbc0d3ff2a.htm".

#### Since

2013

### `P:Autodesk.Revit.UI.ContextualHelp.HelpPath`

Member kind: property
Symbol: `Autodesk.Revit.UI.ContextualHelp.HelpPath`

#### Summary

The context id, help URL, or help file path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when setting the help path to null or empty.

#### Since

2013

### `P:Autodesk.Revit.UI.ContextualHelp.HelpType`

Member kind: property
Symbol: `Autodesk.Revit.UI.ContextualHelp.HelpType`

#### Summary

The contextual help type.

#### Since

2013

### `M:Autodesk.Revit.UI.ContextualHelp.#ctor(Autodesk.Revit.UI.ContextualHelpType,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ContextualHelp.#ctor(Autodesk.Revit.UI.ContextualHelpType,System.String)`

#### Summary

Constructs a contextual help object.

#### Parameter `helpType`

The contextual help type.

#### Parameter `helpPath`

The contextual help path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the helpPath is null or empty.

#### Since

2013

### `T:Autodesk.Revit.UI.ContextualHelp`

Member kind: type
Symbol: `Autodesk.Revit.UI.ContextualHelp`

#### Summary

Contains the details for how Revit should allow invocation of contextual help for an item added by an application.

#### Remarks

An instance of this class may be used to assign a contextual help location to any RibbonItem (through the RibbonItem.SetContextualHelp() method).
It is also possible to use an instance of this class to launch the help path and topic at any time (this permits association of help topics with
user interface components inside dialogs created by the add-in application).

#### Since

2013

### `T:Autodesk.Revit.UI.ContextualHelpType`

Member kind: type
Symbol: `Autodesk.Revit.UI.ContextualHelpType`

#### Summary

Represents the contextual help type.

#### Since

2013

### `F:Autodesk.Revit.UI.ContextualHelpType.ChmFile`

Member kind: field
Symbol: `Autodesk.Revit.UI.ContextualHelpType.ChmFile`

#### Summary

Represents the path to a file on disk. When users invoke help for this item, Revit will launch this file.

### `F:Autodesk.Revit.UI.ContextualHelpType.Url`

Member kind: field
Symbol: `Autodesk.Revit.UI.ContextualHelpType.Url`

#### Summary

Represents an arbitrary URL. When users invoke help for this item, Revit will load this URL into the user's default browser.

### `F:Autodesk.Revit.UI.ContextualHelpType.ContextId`

Member kind: field
Symbol: `Autodesk.Revit.UI.ContextualHelpType.ContextId`

#### Summary

Represents an Autodesk help context id, which will automatically be mapped to a URL in the Revit help system.

### `F:Autodesk.Revit.UI.ContextualHelpType.None`

Member kind: field
Symbol: `Autodesk.Revit.UI.ContextualHelpType.None`

#### Summary

None.

### `T:Autodesk.Revit.UI.RibbonItemType`

Member kind: type
Symbol: `Autodesk.Revit.UI.RibbonItemType`

#### Summary

An enumerated type listing all the toolbar item styles.

### `F:Autodesk.Revit.UI.RibbonItemType.TextBox`

Member kind: field
Symbol: `Autodesk.Revit.UI.RibbonItemType.TextBox`

#### Summary

A text-based control that allows the user to enter text.

### `F:Autodesk.Revit.UI.RibbonItemType.ComboBox`

Member kind: field
Symbol: `Autodesk.Revit.UI.RibbonItemType.ComboBox`

#### Summary

A selection control with a drop-down list that can be shown or hidden by clicking the arrow on the control.

### `F:Autodesk.Revit.UI.RibbonItemType.ComboBoxMember`

Member kind: field
Symbol: `Autodesk.Revit.UI.RibbonItemType.ComboBoxMember`

#### Summary

An item in the drop-down list of a ComboBox.

### `F:Autodesk.Revit.UI.RibbonItemType.RadioButtonGroup`

Member kind: field
Symbol: `Autodesk.Revit.UI.RibbonItemType.RadioButtonGroup`

#### Summary

An item that contains a collection of RibbonToggleButton items.

### `F:Autodesk.Revit.UI.RibbonItemType.ToggleButton`

Member kind: field
Symbol: `Autodesk.Revit.UI.RibbonItemType.ToggleButton`

#### Summary

A standard button that can be added to RadioButtonGroup.

### `F:Autodesk.Revit.UI.RibbonItemType.SplitButton`

Member kind: field
Symbol: `Autodesk.Revit.UI.RibbonItemType.SplitButton`

#### Summary

A split button with a default button and a pull-down menu list.

### `F:Autodesk.Revit.UI.RibbonItemType.PulldownButton`

Member kind: field
Symbol: `Autodesk.Revit.UI.RibbonItemType.PulldownButton`

#### Summary

A button with a pull-down menu list.

### `F:Autodesk.Revit.UI.RibbonItemType.PushButton`

Member kind: field
Symbol: `Autodesk.Revit.UI.RibbonItemType.PushButton`

#### Summary

A standard button with text and image.

### `F:CMFCToolBar.m_bDontScaleImages`

Member kind: field
Symbol: `CMFCToolBar.m_bDontScaleImages`

#### Summary

Specifies whether to scale or not toolbar images in high DPI mode.

### `M:CMFCToolBar.SetLockedSizes(tagSIZE,tagSIZE,System.Int32)`

Member kind: method
Symbol: `CMFCToolBar.SetLockedSizes(tagSIZE,tagSIZE,System.Int32)`

#### Summary

Sets the sizes of locked buttons and locked images on the toolbar.

#### Parameter `sizeButton`

Specifies the size of locked toolbar buttons.

#### Parameter `sizeImage`

Specifies the size of locked toolbar images.

#### Parameter `bDontScale`

Specifies whether to scale or not locked toolbar images in high DPI mode.

### `M:CMFCToolBarImages.ConvertTo32Bits(System.UInt32!System.Runtime.CompilerServices.IsLong)`

Member kind: method
Symbol: `CMFCToolBarImages.ConvertTo32Bits(System.UInt32!System.Runtime.CompilerServices.IsLong)`

#### Summary

Converts underlined bitmaps to 32 bpp images.

#### Returns

TRUE if succeeds; otherwise FALSE.

#### Parameter `clrTransparent`

Specifies transparent color of underlined bitmaps.

### `M:CMFCToolBarImages.IsScaled`

Member kind: method
Symbol: `CMFCToolBarImages.IsScaled`

#### Summary

Tells whether the underlined images are scaled or not.

#### Returns

TRUE if underlined images are scaled; otherwise FALSE.

### `M:CMFCToolBarImages.GetScale`

Member kind: method
Symbol: `CMFCToolBarImages.GetScale`

#### Summary

Returns current scale ratio of underlined images.

#### Returns

A value representing current scale ratio.

### `M:CMFCToolBarImages.SmoothResize(System.Double)`

Member kind: method
Symbol: `CMFCToolBarImages.SmoothResize(System.Double)`

#### Summary

Smoothly resizes underlined images.

#### Parameter `dblImageScale`

Scale ratio.

#### Returns

TRUE if resize succeeds; otherwise FALSE.

### `M:CMFCToolBarImages.GetBitsPerPixel`

Member kind: method
Symbol: `CMFCToolBarImages.GetBitsPerPixel`

#### Summary

Returns current resolution of underlined images.

#### Returns

An integer value representing the current resolution of underlined images, in bits per pixel (bpp).

### `M:Gdiplus.Region.IsVisible(Gdiplus.PointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,Gdiplus.Graphics!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `Gdiplus.Region.IsVisible(Gdiplus.PointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,Gdiplus.Graphics!System.Runtime.CompilerServices.IsConst*)`

### `M:AFX_GLOBAL_DATA.GetITaskbarList3`

Member kind: method
Symbol: `AFX_GLOBAL_DATA.GetITaskbarList3`

#### Summary

Creates and stores in the global data a pointer to ITaskBarList3 interface.

#### Returns

A pointer to ITaskbarList3 interface if creation creation of a task bar list object succeeds, or NULL if creation fails or current
Operation System is less than Windows 7.

### `M:AFX_GLOBAL_DATA.GetITaskbarList`

Member kind: method
Symbol: `AFX_GLOBAL_DATA.GetITaskbarList`

#### Summary

Creates and stores in the global data a pointer to ITaskBarList interface.

#### Returns

A pointer to ITaskbarList interface if creation of a task bar list object succeeds, or NULL if creation fails or current
Operation System is less than Windows 7.

### `M:AFX_GLOBAL_DATA.ShellCreateItemFromParsingName(System.Char!System.Runtime.CompilerServices.IsConst*,IBindCtx*,_GUID!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Void**)`

Member kind: method
Symbol: `AFX_GLOBAL_DATA.ShellCreateItemFromParsingName(System.Char!System.Runtime.CompilerServices.IsConst*,IBindCtx*,_GUID!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Void**)`

#### Summary

Creates and initializes a Shell item object from a parsing name.

#### Parameter `pszPath`

[in] A pointer to a display name.

#### Parameter `pbc`

A pointer to a bind context that controls the parsing operation.

#### Parameter `riid`

A reference to an interface ID.

#### Parameter `ppv`

[out] When this function returns, contains the interface pointer requested in riid. This will typically be IShellItem or IShellItem2.

#### Returns

Returns S_OK if successful, or an error value otherwise.

### `M:AFX_GLOBAL_DATA.GetShellAutohideBars`

Member kind: method
Symbol: `AFX_GLOBAL_DATA.GetShellAutohideBars`

#### Summary

Determines positions of Shell auto hide bars.

#### Returns

An integer value with encoded flags that specify positions of auto hide bars.
It may combine the following values: AFX_AUTOHIDE_BOTTOM, AFX_AUTOHIDE_TOP, AFX_AUTOHIDE_LEFT,
AFX_AUTOHIDE_RIGHT.

### `F:AFX_GLOBAL_DATA.bIsWindows7`

Member kind: field
Symbol: `AFX_GLOBAL_DATA.bIsWindows7`

#### Summary

Indicates whether the application is being executed under Windows 7 OS or higher

### `F:AFX_GLOBAL_DATA.clrInactiveCaptionGradient`

Member kind: field
Symbol: `AFX_GLOBAL_DATA.clrInactiveCaptionGradient`

#### Summary

Specifies gradient color of inactive active caption. Generally used for docking panes.

### `F:AFX_GLOBAL_DATA.clrActiveCaptionGradient`

Member kind: field
Symbol: `AFX_GLOBAL_DATA.clrActiveCaptionGradient`

#### Summary

Specifies gradient color of active caption. Generally used for docking panes.

### `T:Autodesk.Revit.UI.AvailabilityCommands`

Member kind: type
Symbol: `Autodesk.Revit.UI.AvailabilityCommands`

#### Summary

Store all the ObjectHandlers to the availability command.

#### Remarks

In order to enhance the performance, we just create ObjectHandler for each availability command only once.

### `M:Autodesk.Revit.UI.IExternalCommandAvailability.IsCommandAvailable(Autodesk.Revit.UI.UIApplication,Autodesk.Revit.DB.CategorySet)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalCommandAvailability.IsCommandAvailable(Autodesk.Revit.UI.UIApplication,Autodesk.Revit.DB.CategorySet)`

#### Summary

Implement this method to provide control over whether your external command is enabled or disabled.

#### Returns

Indicates whether Revit should enable or disable the corresponding external command.

#### Remarks

This callback will be called by Revit's user interface any time there is a contextual change. Therefore, the callback
must be fast and is not permitted to modify the active document and be blocking in any way.

#### Parameter `applicationData`

An ApplicationServices.Application object which contains reference to Application
needed by external command.

#### Parameter `selectedCategories`

An list of categories of the elements which have been selected in Revit in the active document,
or an empty set if no elements are selected or there is no active document.

### `T:Autodesk.Revit.UI.IExternalCommandAvailability`

Member kind: type
Symbol: `Autodesk.Revit.UI.IExternalCommandAvailability`

#### Summary

An interface that should be implemented to provide the implementation for a accessibility check for a Revit add-in External Command.

#### Remarks

This interface should share the same assembly with add-in External Command.

### `M:Autodesk.Revit.UI.IExternalCommand.Execute(Autodesk.Revit.UI.ExternalCommandData,System.String@,Autodesk.Revit.DB.ElementSet)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalCommand.Execute(Autodesk.Revit.UI.ExternalCommandData,System.String@,Autodesk.Revit.DB.ElementSet)`

#### Summary

Overload this method to implement and external command within Revit.

#### Returns

The result indicates if the execution fails, succeeds, or was canceled by user. If it does not
succeed, Revit will undo any changes made by the external command.

#### Parameter `commandData`

An ExternalCommandData object which contains reference to Application and View
needed by external command.

#### Parameter `message`

Error message can be returned by external command. This will be displayed only if the command status
was "Failed". There is a limit of 1023 characters for this message; strings longer than this will be truncated.

#### Parameter `elements`

Element set indicating problem elements to display in the failure dialog. This will be used
only if the command status was "Failed".

### `T:Autodesk.Revit.UI.IExternalCommand`

Member kind: type
Symbol: `Autodesk.Revit.UI.IExternalCommand`

#### Summary

An interface that should be implemented to provide the implementation for a Revit add-in External Command.

#### Remarks

To add an external command to Autodesk Revit the developer should implement an object
that supports the IExternalCommand interface.

### `M:Autodesk.Revit.UI.IExternalApplication.OnShutdown(Autodesk.Revit.UI.UIControlledApplication)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalApplication.OnShutdown(Autodesk.Revit.UI.UIControlledApplication)`

#### Summary

Implement this method to execute some tasks when Autodesk Revit shuts down.

#### Parameter `application`

A handle to the application being shut down.

#### Returns

Indicates if the external application completes its work successfully.

### `M:Autodesk.Revit.UI.IExternalApplication.OnStartup(Autodesk.Revit.UI.UIControlledApplication)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalApplication.OnStartup(Autodesk.Revit.UI.UIControlledApplication)`

#### Summary

Implement this method to execute some tasks when Autodesk Revit starts.

#### Parameter `application`

A handle to the application being started.

#### Returns

Indicates if the external application completes its work successfully.

### `T:Autodesk.Revit.UI.IExternalApplication`

Member kind: type
Symbol: `Autodesk.Revit.UI.IExternalApplication`

#### Summary

An interface that supports addition of external applications to Revit.

#### Remarks

External applications are permitted to customize the Revit UI, and to add events
and updaters to the session.

### `T:Autodesk.Revit.UI.Result`

Member kind: type
Symbol: `Autodesk.Revit.UI.Result`

#### Summary

Informs Autodesk Revit of the status of your application after execution.

### `F:Autodesk.Revit.UI.Result.Cancelled`

Member kind: field
Symbol: `Autodesk.Revit.UI.Result.Cancelled`

#### Summary

Signifies that the external application is cancelled.

### `F:Autodesk.Revit.UI.Result.Succeeded`

Member kind: field
Symbol: `Autodesk.Revit.UI.Result.Succeeded`

#### Summary

The external application completed successfully. Autodesk Revit will keep this object
during the entire Revit session.

### `F:Autodesk.Revit.UI.Result.Failed`

Member kind: field
Symbol: `Autodesk.Revit.UI.Result.Failed`

#### Summary

The external application was unable to complete its task.

### `E:Autodesk.Revit.UI.UIControlledApplication.ThemeChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.ThemeChanged`

#### Summary

Subscribe to the ThemeChanged event to be notified after the theme was changed.

#### Remarks

This event is raised after the theme was changed.

#### Since

2022

### `E:Autodesk.Revit.UI.UIControlledApplication.SelectionChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.SelectionChanged`

#### Summary

Subscribe to the SelectionChanged event to be notified after the selection was changed.

#### Remarks

This event is raised after the selection was changed in the current document.
Handlers of this event are forbidden to make modifications to the current document.
Handlers of this event are forbidden to change the selection to the current document.
It is not allowed to open a new transaction in the active document when handling this event.

#### Since

2023

### `E:Autodesk.Revit.UI.UIControlledApplication.TransferredProjectStandards`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.TransferredProjectStandards`

#### Summary

Subscribe to the TransferredProjectStandards event to be notified after the scope of a Transfer Project Standards operation has been finalized in the Transfer Project Standards dialog.

#### Remarks

This event is raised just after the native Revit items have been transferred, but before the transaction has been committed.
An add - in that registered external items in `E:Autodesk.Revit.UI.UIControlledApplication.TransferringProjectStandards` should subscribe to this event to carry out the transfer of any items that it registered if the user enabled those items for transfer.
During the scope of this event, modification is permitted to the target document and modification is not permitted to the source document.

#### Since

2017.2

### `E:Autodesk.Revit.UI.UIControlledApplication.TransferringProjectStandards`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.TransferringProjectStandards`

#### Summary

Subscribe to the TransferringProjectStandards event to be notified before the scope of an impending Transfer Project Standards operation has been finalized.

#### Remarks

This event allows an external application to add additional items to the possible list of items to be transferred.
These items will be visible and selectable in the Transfer Project Standards dialog box. By default, new items added in this manner will be enabled for transfer.
During the scope of this event, modification is not permitted to either the source or target documents. And this event is not cancellable.

#### Since

2017.2

### `E:Autodesk.Revit.UI.UIControlledApplication.FabricationPartBrowserChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.FabricationPartBrowserChanged`

#### Summary

Subscribe to MEP Fabrication part browser changed event to be notified when MEP Fabrication part browser is updated.

#### Since

2017

### `E:Autodesk.Revit.UI.UIControlledApplication.DockableFrameFocusChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.DockableFrameFocusChanged`

#### Summary

Subscribe to GenericDockableFrame activated event to be notified when Revit GenericDockableFrame is active or inactive.

#### Since

2015

### `E:Autodesk.Revit.UI.UIControlledApplication.DockableFrameVisibilityChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.DockableFrameVisibilityChanged`

#### Summary

Subscribe to GenericDockableFrame showing or hiding event to be notified when Revit GenericDockableFrame is showing or hiding.

#### Since

2015

### `E:Autodesk.Revit.UI.UIControlledApplication.DisplayingOptionsDialog`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.DisplayingOptionsDialog`

#### Summary

Subscribe to the options dialog displaying event to be notified when Revit options dialog is displaying.

#### Since

2013

### `E:Autodesk.Revit.UI.UIControlledApplication.Idling`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.Idling`

#### Summary

Subscribe to the Idling event to be notified when Revit is not in an active tool or transaction.

#### Remarks

This event is raised when it is safe for the API application to access the active
document between user interactions. The event is raised only when the Revit UI is
in a state where the user could successfully click on an API command button.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

In order to change a document, you must begin a new transaction for that document.
This transaction will appear in the Revit undo stack and may be undone by the Revit user.

This event is invoked between user actions in the Revit UI. If the handler for
this event requires a significant amount of processing time, users will perceive a slowdown
in the responsiveness of Revit. If the execution for updates can be safely split across
multiple calls to this event, the user perception of Revit responsiveness will be improved.

There are two ways to use this event. In the default mode, a single raise of the event
will be made each time Revit begins an idle session. Note that when the user is active in the Revit
user interface, idle sessions begin whenever the mouse stops moving for a moment or when a
command completes. However, if the user is not active in the user interface at all, Revit may not invoke
additional idling sessions for quite some time; this means that your application may not be able to take advantage
of time when the user leaves the machine completely for a period of time.

In the non-default mode, your application forces Revit to keep the idling session open and to make
repeated calls to your event subscriber. In this mode even if the user is totally inactive the Revit
session will continue to make Idling calls to your application. However, this can result in performance
degradation for the system on which Revit is running because the CPU remains fully engaged in serving Idling
events during the Revit application's downtime.

You can indicate the preference for the non-default Idling frequency by calling
`M:Autodesk.Revit.UI.Events.IdlingEventArgs.SetRaiseWithoutDelay`
each time the Idling event callback is made. Revit will revert to the default Idling frequency
if this method is not called every time in your callback.

Event is not cancellable.

### `E:Autodesk.Revit.UI.UIControlledApplication.DialogBoxShowing`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.DialogBoxShowing`

#### Summary

Subscribe to the DialogBoxShowing event to be notified when Revit is just about to show a dialog box or a message box.

#### Remarks

This event is raised when Revit is just about to show a dialog box or a message box.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

Depending on the type of the dialog that is being shown, the event's argument's type varies as follows:
When it is a dialog box, the event's argument is an object of `T:Autodesk.Revit.UI.Events.DialogBoxShowingEventArgs` .
When it is a message box, the event's argument is an object of `T:Autodesk.Revit.UI.Events.MessageBoxShowingEventArgs` ,which is subclass of DialogBoxShowingEventArgs.
When it is a task dialog, the event's argument is an object of `T:Autodesk.Revit.UI.Events.TaskDialogShowingEventArgs` ,which is subclass of DialogBoxShowingEventArgs.

No document may be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

### `E:Autodesk.Revit.UI.UIControlledApplication.ApplicationClosing`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.ApplicationClosing`

#### Summary

Subscribe to the ApplicationClosing event to be notified when the Revit application is just about to be closed.

#### Remarks

This event is raised when the Revit application is just about to be closed.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

No document may be modified at the time of the event.

The sender object of this event is `T:Autodesk.Revit.UI.UIControlledApplication` object.

### `E:Autodesk.Revit.UI.UIControlledApplication.FormulaEditing`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.FormulaEditing`

#### Summary

Subscribe to the FormulaEditing event

### `E:Autodesk.Revit.UI.UIControlledApplication.ViewActivated`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.ViewActivated`

#### Summary

Subscribe to the ViewActivated event to be notified immediately after Revit has finished activating a view of a document.

#### Remarks

This event is raised immediately after Revit has finished activating a view of the document.
It is raised even when view activating failed or was cancelled (during ViewActivating event).

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of view activating has already been finished.

The document may be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

### `E:Autodesk.Revit.UI.UIControlledApplication.ViewActivating`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.ViewActivating`

#### Summary

Subscribe to the ViewActivating event to be notified when Revit is just about to activate a view of a document.

#### Remarks

This event is raised when Revit is just about to activate a view of the document.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The document may be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.UI.UIApplication.ViewActivated` event will be raised immediately after view activating
is finished.

### `M:Autodesk.Revit.UI.UIControlledApplication.SetModelBrowserContent(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.SetModelBrowserContent(System.Object)`

#### Summary

Set the content of backstage.

### `P:Autodesk.Revit.UI.UIControlledApplication.IsViewerModeActive`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIControlledApplication.IsViewerModeActive`

#### Summary

Identifies if the current Revit session is running in Viewer mode

#### Since

2019.1

### `P:Autodesk.Revit.UI.UIControlledApplication.IsLateAddinLoading`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIControlledApplication.IsLateAddinLoading`

#### Summary

Indicates whether this add-in is loaded on the fly or not. If it is loaded when Revit is starting up, it
is false, otherwise it should be true.

### `P:Autodesk.Revit.UI.UIControlledApplication.ControlledApplication`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIControlledApplication.ControlledApplication`

#### Summary

Returns the database level ControlledApplication represented by this UI-level ControlledApplication.

### `T:Autodesk.Revit.UI.UIControlledApplication`

Member kind: type
Symbol: `Autodesk.Revit.UI.UIControlledApplication`

#### Summary

Represents the Autodesk Revit user interface, providing access to
UI customization methods and events.

#### Remarks

This class does not provide access to documents because it is provided to you through the ExternalApplication
OnStartup()/OnShutdown() methods, and those methods are when it is not possible to work with Revit documents.
You can work with documents by getting them from the UIApplication class; that class is obtained from events and
ExternalCommand callbacks.

### `E:Autodesk.Revit.UI.UIApplication.ThemeChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.ThemeChanged`

#### Summary

Subscribe to the ThemeChanged event to be notified after the theme was changed.

#### Remarks

This event is raised after the theme was changed.

#### Since

2024

### `E:Autodesk.Revit.UI.UIApplication.SelectionChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.SelectionChanged`

#### Summary

Subscribe to the SelectionChanged event to be notified after the selection was changed.

#### Remarks

This event is raised after the selection was changed in the current document.
Handlers of this event are forbidden to make modifications to the current document.
Handlers of this event are forbidden to change the selection to the current document.
It is not allowed to open a new transaction in the active document when handling this event.

#### Since

2023

### `E:Autodesk.Revit.UI.UIApplication.TransferredProjectStandards`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.TransferredProjectStandards`

#### Summary

Subscribe to the TransferredProjectStandards event to be notified after the scope of a Transfer Project Standards operation has been finalized.

#### Remarks

This event is raised just after the native Revit items have been transferred, but before the transaction has been committed.
An add-in that registered external items in `E:Autodesk.Revit.UI.UIApplication.TransferringProjectStandards` should subscribe to this event to carry out the transfer of any items that it registered if the user enabled those items for transfer.
During the scope of this event, modification is permitted to the target document and modification is not permitted to the source document.

#### Since

2017.2

### `E:Autodesk.Revit.UI.UIApplication.TransferringProjectStandards`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.TransferringProjectStandards`

#### Summary

Subscribe to the TransferringProjectStandards event to be notified before the scope of an impending Transfer Project Standards operation has been finalized in the Transfer Project Standards dialog.

#### Remarks

This event allows an external application to add additional items to the possible list of items to be transferred.
These items will be visible and selectable in the Transfer Project Standards dialog box. By default, new items added in this manner will be enabled for transfer.
During the scope of this event, modification is not permitted to either the source or target documents. And this event is not cancellable.

#### Since

2017.2

### `E:Autodesk.Revit.UI.UIApplication.FabricationPartBrowserChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.FabricationPartBrowserChanged`

#### Summary

Subscribe to MEP Fabrication part browser changed event to be notified when MEP Fabrication part browser is updated.

#### Remarks

More docs about the different conditions goes here

#### Since

2017

### `E:Autodesk.Revit.UI.UIApplication.DockableFrameFocusChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.DockableFrameFocusChanged`

#### Summary

Subscribe to this event to be notified when a Revit GenericDockableFrame has gained focus or lost focus in the Revit user interface.
This event is called only for API-created GenericDockableFrames.

#### Remarks

This event is raised when the GenericDockableFrame is just about to be active or inactive.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

No document may be modified at the time of the event.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Export()All overloads of Autodesk.Revit.DB.Document.Import()Autodesk::Revit::DB::Document::Print`M:Autodesk.Revit.DB.View.Print` and similar overloads.`M:Autodesk.Revit.DB.PrintManager.SubmitPrint` and similar overloads.`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2015

### `E:Autodesk.Revit.UI.UIApplication.DockableFrameVisibilityChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.DockableFrameVisibilityChanged`

#### Summary

Subscribe to this event to be notified when a Revit GenericDockableFrame has been shown or hidden in the Revit user interface.
This event is called only for API-created GenericDockableFrames.

#### Remarks

This event is raised when the GenericDockableFrame is just about to be shown or hidden.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

No document may be modified at the time of the event.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Export()All overloads of Autodesk.Revit.DB.Document.Import()Autodesk::Revit::DB::Document::Print`M:Autodesk.Revit.DB.View.Print` and similar overloads.`M:Autodesk.Revit.DB.PrintManager.SubmitPrint` and similar overloads.`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2015

### `E:Autodesk.Revit.UI.UIApplication.DisplayingOptionsDialog`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.DisplayingOptionsDialog`

#### Summary

Subscribe to the options dialog displaying event to be notified when Revit options dialog is displaying.

#### Since

2013

### `E:Autodesk.Revit.UI.UIApplication.ApplicationClosing`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.ApplicationClosing`

#### Summary

Subscribe to the ApplicationClosing event to be notified when the Revit application is just about to be closed.

#### Remarks

This event is raised when the Revit application is just about to be closed.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

No document may be modified at the time of the event.

The sender object of this event is `T:Autodesk.Revit.UI.UIControlledApplication` object.

#### Since

2010

### `E:Autodesk.Revit.UI.UIApplication.Idling`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.Idling`

#### Summary

Subscribe to the Idling event to be notified when Revit is not in an active tool or transaction.

#### Remarks

This event is raised when it is safe for the API application to access the active
document between user interactions. The event is raised only when the Revit UI is
in a state where the user could successfully click on an API command button.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

In order to change a document, you must begin a new transaction for that document.
This transaction will appear in the Revit undo stack and may be undone by the Revit user.

This event is invoked between user actions in the Revit UI. If the handler for
this event requires a significant amount of processing time, users will perceive a slowdown
in the responsiveness of Revit. If the execution for updates can be safely split across
multiple calls to this event, the user perception of Revit responsiveness will be improved.

There are two ways to use this event. In the default mode, a single raise of the event
will be made each time Revit begins an idle session. Note that when the user is active in the Revit
user interface, idle sessions begin whenever the mouse stops moving for a moment or when a
command completes. However, if the user is not active in the user interface at all, Revit may not invoke
additional idling sessions for quite some time; this means that your application may not be able to take advantage
of time when the user leaves the machine completely for a period of time.

In the non-default mode, your application forces Revit to keep the idling session open and to make
repeated calls to your event subscriber. In this mode even if the user is totally inactive the Revit
session will continue to make Idling calls to your application. However, this can result in performance
degradation for the system on which Revit is running because the CPU remains fully engaged in serving Idling
events during the Revit application's downtime.

You can indicate the preference for the non-default Idling frequency by calling
`M:Autodesk.Revit.UI.Events.IdlingEventArgs.SetRaiseWithoutDelay`
each time the Idling event callback is made. Revit will revert to the default Idling frequency
if this method is not called every time in your callback.

Event is not cancellable.

#### Since

2010

### `E:Autodesk.Revit.UI.UIApplication.FormulaEditing`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.FormulaEditing`

#### Summary

Subscribe to the FormulaEditing event to be notified when the edit formula button has been clicked.

### `E:Autodesk.Revit.UI.UIApplication.DialogBoxShowing`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.DialogBoxShowing`

#### Summary

Subscribe to the DialogBoxShowing event to be notified when Revit is just about to show a dialog box or a message box.

#### Remarks

This event is raised when Revit is just about to show a dialog box or a message box.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

Depending on the type of the dialog that is being shown, the event's argument's type varies as follows:
When it is a dialog box, the event's argument is an object of `T:Autodesk.Revit.UI.Events.DialogBoxShowingEventArgs` .
When it is a message box, the event's argument is an object of `T:Autodesk.Revit.UI.Events.MessageBoxShowingEventArgs` ,which is subclass of DialogBoxShowingEventArgs.
When it is a task dialog, the event's argument is an object of `T:Autodesk.Revit.UI.Events.TaskDialogShowingEventArgs` ,which is subclass of DialogBoxShowingEventArgs.

No document may be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.UI.UIApplication.ViewActivated`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.ViewActivated`

#### Summary

Subscribe to the ViewActivated event to be notified immediately after Revit has finished activating a view of a document.

#### Remarks

This event is raised immediately after Revit has finished activating a view of the document.
It is raised even when view activating failed or was cancelled (during ViewActivating event).

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of view activating has already been finished.

The document may be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.UI.UIApplication.ViewActivating`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIApplication.ViewActivating`

#### Summary

Subscribe to the ViewActivating event to be notified when Revit is just about to activate a view of a document.

#### Remarks

This event is raised when Revit is just about to activate a view of the document.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The document may be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above
methods is called during this event.

Another `E:Autodesk.Revit.UI.UIApplication.ViewActivated` event will be raised immediately after view
activating is finished.

#### Since

2010

### `M:Autodesk.Revit.UI.UIApplication.UpdateWorksharingActivityIndicator(System.Boolean,System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.UpdateWorksharingActivityIndicator(System.Boolean,System.Collections.Generic.IList{System.String})`

#### Summary

Updates model status on the Worksharing activity indicator.

#### Remarks

The indicator is enabled only when the active document is cloud Worksharing.

#### Parameter `centralIsBusy`

True if the central model is busy.

#### Parameter `syncingUsernames`

An array with the usernames of the users which are currently syncing

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020.1

### `M:Autodesk.Revit.UI.UIApplication.UpdateWorksharingActivityIndicator(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.UpdateWorksharingActivityIndicator(System.Boolean)`

#### Summary

Updates model status on the Worksharing activity indicator.

#### Remarks

The indicator is enabled only when the active document is cloud Worksharing.

#### Parameter `centralIsBusy`

True if the central model is busy.

#### Since

2019.1

### `M:Autodesk.Revit.UI.UIApplication.OpenAndActivateDocumentOperationInternal(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.IOpenFromCloudCallback)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.OpenAndActivateDocumentOperationInternal(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.IOpenFromCloudCallback)`

#### Summary

Opens and activates a Revit document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.UIApplication.OpenAndActivateDocument(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,System.Boolean,Autodesk.Revit.DB.IOpenFromCloudCallback)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.OpenAndActivateDocument(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,System.Boolean,Autodesk.Revit.DB.IOpenFromCloudCallback)`

#### Summary

Opens and activates a Revit document, include both local document or cloud document.

#### Remarks

This method, if successful, changes the active document.
It is not allowed to have an open transaction in the active document when calling this method.
Consequently, this method can only be used in manual transaction mode, not in automatic mode.
Additionally, this method may not be called from inside an event handler.

#### Parameter `modelPath`

A path to a Revit file to be opened.
The file can be either a Revit project, template, or family document.

#### Parameter `openOptions`

Options for opening the file.

#### Parameter `detachAndPrompt`

True means if openOptions specifies DoNotDetach,
then for workshared models detach from central and query the user whether to preserve or discard worksets.
make no sense when opening a cloud document.

#### Parameter `openFromCloudCallback`

Callback function that allow caller to handle cases when conflicts happen during opening a cloud document.
Make no sense when opening a non-cloud document.

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If DetachFromCentralOption is not DoNotDetach when opening a cloud document.
If the active document is currently modifiable.If an API event handler is currently being executed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

If `null` is passed as 'modelPath'.
-or-
If `null` is passed as 'openOptions'.
-or-
A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException`

Cannot open the local model and the central model in the same Revit session. You can close one to open the other in the same Revit session.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Thrown when file is not found at the give path.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Revit encountered serious errors while trying to open the central model.
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.CorruptModelException`

There are too many corrupt elements to open this model.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

When file cannot be opened in Revit LT because it was last saved in a version of Revit prior to 8.1.
when file has an invalid extension. Try changing the file's extension and opening it again.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file specified by 'modelPath' cannot be found or the given 'modelPath' is not a Revit file (a project, template, or family document).

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to open the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The cloud model is not saved in current release of Revit.
-or-
The model is not allowed to access.
-or-
The document can not be opened.Open is temporarily disabled.Revit cannot save the transmitted model as a new central because it is already opened.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Opening was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

If there is any server internal error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id when trying to open a cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.WrongUserException`

The local file is not owned by the current user, who therefore is not allowed to modify it.

#### Since

2019

### `M:Autodesk.Revit.UI.UIApplication.OpenAndActivateDocument(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.OpenAndActivateDocument(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,System.Boolean)`

#### Summary

Opens and activates a Revit document, include both local document or cloud document.

#### Remarks

This method, if successful, changes the active document.
The model will override the local change with the latest change if it is a cloud model and it was restored, or relinquished, or out of date.
It is not allowed to have an open transaction in the active document when calling this method.
Consequently, this method can only be used in manual transaction mode, not in automatic mode.
Additionally, this method may not be called from inside an event handler.

#### Parameter `modelPath`

A path to a Revit file to be opened.
The file can be either a Revit project, template, or family document.

#### Parameter `openOptions`

Options for opening the file.

#### Parameter `detachAndPrompt`

True means if openOptions specifies DoNotDetach,
then for workshared models detach from central and query the user whether to preserve or discard worksets.
make no sense when opening a cloud document.

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If DetachFromCentralOption is not DoNotDetach when opening a cloud document.
If the active document is currently modifiable.If an API event handler is currently being executed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

If `null` is passed as 'modelPath'.
-or-
If `null` is passed as 'openOptions'.
-or-
A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException`

Cannot open the local model and the central model in the same Revit session. You can close one to open the other in the same Revit session.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Thrown when file is not found at the give path.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Revit encountered serious errors while trying to open the central model.
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.CorruptModelException`

There are too many corrupt elements to open this model.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

When file cannot be opened in Revit LT because it was last saved in a version of Revit prior to 8.1.
when file has an invalid extension. Try changing the file's extension and opening it again.
when file was saved by an application that was not developed or licensed by Autodesk.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file specified by 'modelPath' cannot be found or the given 'modelPath' is not a Revit file (a project, template, or family document).

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to open the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The cloud model is not saved in current release of Revit.
-or-
The model is not allowed to access.
-or-
The document can not be opened.Open is temporarily disabled.Revit cannot save the transmitted model as a new central because it is already opened.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Opening was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

If there is any server internal error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id when trying to open a cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.WrongUserException`

The local file is not owned by the current user, who therefore is not allowed to modify it.

#### Since

2013

### `M:Autodesk.Revit.UI.UIApplication.OpenAndActivateDocument(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.OpenAndActivateDocument(System.String)`

#### Summary

Opens and activates a Revit document.

#### Remarks

This method, if successful, changes the active document.
It is not allowed to have an open transaction in the active document when calling this method.
Additionally, this method may not be called from inside an event handler.

#### Parameter `fileName`

A full path to a revit file to be opened.
The file can be either a Revit project, template, or family document.

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given 'fileName' is not a Revit file (a project, template, or family document).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

If `null` is passed as 'fileName'.
-or-
A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file specified by 'fileName' cannot be found.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If the active document is currently modifiable.
If an API event handler is currently being executed.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

If there is any server internal error.

#### Since

2012

### `P:Autodesk.Revit.UI.UIApplication.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIApplication.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.UIApplication.IsViewerModeActive`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIApplication.IsViewerModeActive`

#### Summary

Determines if Revit session is in Viewer mode.

#### Since

2019.1

### `P:Autodesk.Revit.UI.UIApplication.Application`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIApplication.Application`

#### Summary

Returns the database level Application represented by this UI level Application.

### `M:Autodesk.Revit.UI.UIApplication.OpenRecentFileOnRevitHome(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.OpenRecentFileOnRevitHome(Autodesk.Revit.DB.ModelPath)`

#### Summary

Open a recent model on revit home.

### `P:Autodesk.Revit.UI.UIApplication.MainWindowHandle`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIApplication.MainWindowHandle`

#### Summary

Get the handle of the Revit main window.

#### Remarks

Returns the main window handle of the Revit application. This handle should be used when displaying
modal dialogs and message windows to insure that they are properly parented. This property replaces
System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle property, which is no longer a reliable
method of retrieving the main window handle starting with Revit 2019.

#### Since

2019

### `M:Autodesk.Revit.UI.UIApplication.RegisterDockablePane(Autodesk.Revit.UI.DockablePaneId,System.String,Autodesk.Revit.UI.IDockablePaneProvider)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.RegisterDockablePane(Autodesk.Revit.UI.DockablePaneId,System.String,Autodesk.Revit.UI.IDockablePaneProvider)`

#### Summary

Adds a new dockable pane to the Revit user interface.

#### Parameter `id`

Unique identifier for the new pane.

#### Parameter `title`

String to use for the pane caption.

#### Parameter `provider`

Your add-in's implementation of the IDockablePaneProvider interface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if a dockable pane with identifier %id% has already been registered.

#### Since

2014

### `P:Autodesk.Revit.UI.UIApplication.ProductIsRS`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIApplication.ProductIsRS`

#### Summary

Identifies if the current Revit product has an RS designation. Most add-ins will not need to use this information.

#### Since

2019

### `M:Autodesk.Revit.UI.UIApplication.GetDockablePane(Autodesk.Revit.UI.DockablePaneId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.GetDockablePane(Autodesk.Revit.UI.DockablePaneId)`

#### Summary

Gets a DockablePane object by its ID.

#### Parameter `id`

Unique identifier for the new pane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if no dockable pane has been registered with identifier %id%.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the dockable pane with identifier %id% has not been created yet.

#### Since

2014

### `M:Autodesk.Revit.UI.UIApplication.LoadPackageContents(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.LoadPackageContents(System.String)`

#### Summary

Loads add-ins from the given packageContents.xml file.

#### Parameter `packageContentsPath`

The name of package contents file

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

Thrown when manifest file which is specified by
packageContentsPath doesn't exist.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown if the add-in file path specified by
packageContentsPath is null, Or packageContentsPath is null.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the add-in specified by packageContentsPath doesn't
end with 'addin' or packageContentsPath is a zero-length string.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

Thrown if the packageContentsPath is not found.

#### Exception `T:Autodesk.Revit.Exceptions.ApplicationException`

Thrown if the manifest file specified by packageContentsPath
can't be parsed successfully.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when any of the newly added external
applications fails to load and/or initialize properly, possibly because of one of the following reasons:

AllowLoadingIntoExistingSession property is 'No'.

Client id is duplicated.

External application start up failed.

#### Exception `T:Autodesk.Revit.Exceptions.InternalException`

Thrown if packageContentsPath file that was found could not
be loaded.

#### Since

2014

### `M:Autodesk.Revit.UI.UIApplication.LoadAddIn(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.LoadAddIn(System.String)`

#### Summary

Loads add-ins from the given manifest file.

#### Remarks

This method loads the add-ins listed in the provided add-in manifest file.
The API will look for the file in the dedicated folders supported by Revit for loading add-in manifest files.

Some add-ins may have settings in which they decline the ability for Revit to load the external application declared
in the .addin in mid-session.
This happens when the AllowLoadingIntoExistingSession tag is set to "No" in the add-in manifest file, and if the tag
isn't present, the default is set to "Yes".

Note that when Revit starts an add-in in the middle of the session, some add-in logic may not function as expected
because of the different interactions with the session. Specifically:
If the application's goal is to prevent something from happening, the application may not be able to handle
the fact that this activity has already happened in the existing session.

If the application's goal is to manage external information in synch with documents loaded in the session,
the application may not be able to handle documents that were loaded before the application started.
If the application's logic depends on the ApplicationInitialized event, this event has already been called
before the add-in was loaded.

Also, some add-ins may not be able to fully initialize when loading in the middle of the session. This is because some
activities must take place at the start of the Revit session:
Creation of custom failure definitions

Establishment of a system-wide IFailureProcessor to handle all failures.

Registering ExternalServices.

#### Parameter `fileName`

The name of the add-in manifest file including the extension is to identify the
manifest file which contains Revit add-ins.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

Thrown when manifest file which is specified by
fileName doesn't exist.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown if the fileName is null or empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the fileName doesn't end with 'addin'.

#### Exception `T:Autodesk.Revit.Exceptions.ApplicationException`

Thrown if the manifest file can't be parsed successfully.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when any of the newly added external
applications fails to load and/or initialize properly, possibly because of one of the following reasons:

AllowLoadingIntoExistingSession property is 'No'.

Client id is duplicated.

External application start up failed.

#### Since

2014

### `M:Autodesk.Revit.UI.UIApplication.RemoveAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.RemoveAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId)`

#### Summary

Removes an AddInCommandBinding.

#### Parameter `revitCommandId`

The Revit command id to identify the command handler you want to remove the binding.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when uiApplication or revitCommandId
is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the given command is not bound with this add-in.

#### Since

2013

### `M:Autodesk.Revit.UI.UIApplication.CreateAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.CreateAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId)`

#### Summary

Creates a new AddInCommandBinding.

#### Parameter `revitCommandId`

The Revit command id to identify the command handler you want to replace.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when uiApplication or revitCommandId
is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the given command already has been bound.

#### Since

2013

### `P:Autodesk.Revit.UI.UIApplication.ActiveAddInId`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIApplication.ActiveAddInId`

#### Summary

Get current active external application or external command id.

### `P:Autodesk.Revit.UI.UIApplication.LoadedApplications`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIApplication.LoadedApplications`

#### Summary

Returns an array of successfully loaded external applications.

#### Remarks

This property can be used by your application to find all successfully
loaded external applications when Revit starts.

### `M:Autodesk.Revit.UI.UIApplication.GetRibbonPanels(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.GetRibbonPanels(System.String)`

#### Summary

Get all the custom Panels on a designated Revit tab.

#### Parameter `tabName`

The name of the tab on which the panels are located.

#### Remarks

Built-in panels will not be included. tabName must be the name of one of the tabs added
by `M:Autodesk.Revit.UI.UIApplication.CreateRibbonTab(System.String)` .
This method is not supported in Macros.

### `M:Autodesk.Revit.UI.UIApplication.GetRibbonPanels(Autodesk.Revit.UI.Tab)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.GetRibbonPanels(Autodesk.Revit.UI.Tab)`

#### Summary

Get all the custom Panels on a designated standard Revit tab.

#### Parameter `tab`

The tab on which the panels are located.

#### Remarks

Built-in panels will not be included. This method is not supported in Macros.

### `M:Autodesk.Revit.UI.UIApplication.GetRibbonPanels`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.GetRibbonPanels`

#### Summary

Get all the custom Panels on Add-Ins tab of Revit.

#### Remarks

The built-in panels won't be included and the panels added to tabs other than Add-Ins will not be included.
This method is not supported in Macros.

### `M:Autodesk.Revit.UI.UIApplication.CreateRibbonPanel(Autodesk.Revit.UI.Tab,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.CreateRibbonPanel(Autodesk.Revit.UI.Tab,System.String)`

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

### `M:Autodesk.Revit.UI.UIApplication.CreateRibbonPanel(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.CreateRibbonPanel(System.String)`

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

### `M:Autodesk.Revit.UI.UIApplication.CreateRibbonPanel(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.CreateRibbonPanel(System.String,System.String)`

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

### `M:Autodesk.Revit.UI.UIApplication.CreateRibbonTab(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.CreateRibbonTab(System.String)`

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

### `M:Autodesk.Revit.UI.UIApplication.PostCommand(Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.PostCommand(Autodesk.Revit.UI.RevitCommandId)`

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

### `M:Autodesk.Revit.UI.UIApplication.CanPostCommand(Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.CanPostCommand(Autodesk.Revit.UI.RevitCommandId)`

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

### `M:Autodesk.Revit.UI.UIApplication.DoDragDrop(System.Object,Autodesk.Revit.UI.IDropHandler)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.DoDragDrop(System.Object,Autodesk.Revit.UI.IDropHandler)`

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

### `M:Autodesk.Revit.UI.UIApplication.DoDragDrop(System.Collections.Generic.ICollection{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.DoDragDrop(System.Collections.Generic.ICollection{System.String})`

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

### `P:Autodesk.Revit.UI.UIApplication.DrawingAreaExtents`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIApplication.DrawingAreaExtents`

#### Summary

Get the rectangle that represents the screen pixel coordinates of drawing area.

#### Remarks

The drawing area of the Revit window displays views (and sheets and schedules) of projects.
The size of drawing area restricts the max size of the view titles and windows, the value may be empty if modal browser is opened.
If there is no project opened, null will be returned.

#### Since

2011

### `P:Autodesk.Revit.UI.UIApplication.MainWindowExtents`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIApplication.MainWindowExtents`

#### Summary

Get the rectangle that represents the screen pixel coordinates of the Revit main window.

#### Since

2011

### `P:Autodesk.Revit.UI.UIApplication.ActiveUIDocument`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIApplication.ActiveUIDocument`

#### Summary

Provides access to an object that represents the currently active project.

#### Remarks

External API commands can access this property in read-only mode only!
The ability to modify the property is reserved for future implementations.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when attempting to modify the property.

### `M:Autodesk.Revit.UI.UIApplication.#ctor(Autodesk.Revit.ApplicationServices.Application)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIApplication.#ctor(Autodesk.Revit.ApplicationServices.Application)`

#### Summary

Use a database level Application to construct a UI-level Application.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the Application argument is a null pointer.

### `T:Autodesk.Revit.UI.UIApplication`

Member kind: type
Symbol: `Autodesk.Revit.UI.UIApplication`

#### Summary

Represents an active session of the Autodesk Revit user interface, providing access to
UI customization methods, events, the main window, and the active document.

#### Remarks

You can access documents from the database level Application object, obtained from
the Application property. If you have an instance of the database level Application object,
you can construct a UIApplication instance from it.

### `M:Autodesk.Revit.UI.IDockablePaneProvider.SetupDockablePane(Autodesk.Revit.UI.DockablePaneProviderData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IDockablePaneProvider.SetupDockablePane(Autodesk.Revit.UI.DockablePaneProviderData)`

#### Summary

Method called during initialization of the user interface to gather information about a dockable pane window.

#### Parameter `data`

Container for information about the new dockable pane. Implementers should set the
FrameworkElement and InitialState Properties. Optionally, providers can set the
ContextualHelp property if they wish to provide or react to help requests on the pane,
or override the default EditorInteraction property by setting it here.

#### Since

2014

### `T:Autodesk.Revit.UI.IDockablePaneProvider`

Member kind: type
Symbol: `Autodesk.Revit.UI.IDockablePaneProvider`

#### Summary

Interface that the Revit UI will call during initialization of the user interface to gather information about add-in dockable pane windows.

#### Since

2014

### `P:Autodesk.Revit.UI.DockablePaneProviderData.VisibleByDefault`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePaneProviderData.VisibleByDefault`

#### Summary

Controls the default visibility of the pane upon the first time
the pane/plugin is loaded into Revit.

#### Remarks

By default, panes will be created and shown in the Revit UI when
Revit is launched for the first time. Subsequent loads of the Revit
UI will determine the visibility of the panes based upon there state
at the close of the previous Revit session. Providers can set this
to false if they wish there panes to NOT be shown by default.

#### Since

2017

### `P:Autodesk.Revit.UI.DockablePaneProviderData.EditorInteraction`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePaneProviderData.EditorInteraction`

#### Summary

Defines the interaction this pane has with the Active Editor when the pane becomes active.

#### Remarks

Set to KeepAlive to keep the current editor active and
keep active the current selection or Dismiss to dismiss
the Editor and clear the active selection.
Default is to KeepAlive the current editor.

#### Since

2017

### `P:Autodesk.Revit.UI.DockablePaneProviderData.ContextualHelp`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePaneProviderData.ContextualHelp`

#### Summary

The contextual help associated with the pane.

#### Remarks

If set, the contents of this Contextual Help will be used to respond to a user request for help
(typically this is as a result of pressing F1 while the dockable pane has focus).

#### Since

2016

### `P:Autodesk.Revit.UI.DockablePaneProviderData.InitialState`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePaneProviderData.InitialState`

#### Summary

The initial position of the docking pane.

#### Remarks

This position will be used for the first Revit session in which the pane is registered; afterwards, the user is free
to reposition the pane, and the user's saved position will be remembered in future sessions.

#### Since

2014

### `P:Autodesk.Revit.UI.DockablePaneProviderData.FrameworkElementCreator`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePaneProviderData.FrameworkElementCreator`

#### Summary

A creator that will be called for the pane if the FrameworkElement is not set.

#### Remarks

This is more dynamic in nature and allows for embedding things like
WebBrowser controls that cannot be cached for reuse in each pane invocation
but rather needs creating each time.

#### Since

2018

### `P:Autodesk.Revit.UI.DockablePaneProviderData.FrameworkElement`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePaneProviderData.FrameworkElement`

#### Summary

The Windows Presentation Framework object containing the pane's user interface.

#### Remarks

Using a System.Windows.Controls.Page is recommended. This can be null, in which case
it is assumed an IFrameworkElementCreator is provided to create the element on demand.

#### Since

2014

### `M:Autodesk.Revit.UI.DockablePaneProviderData.GetFrameworkElement`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePaneProviderData.GetFrameworkElement`

#### Summary

Wrapper function that returns the FrameworkElement for this provider.

#### Returns

FrameworkElement to use as the pane's user interface.

#### Remarks

If an IFrameworkElementCreator is provided, that will be called to generate the element,
otherwise, the FrameworkElement associated with the provider is returned.

#### Since

2018

### `T:Autodesk.Revit.UI.DockablePaneProviderData`

Member kind: type
Symbol: `Autodesk.Revit.UI.DockablePaneProviderData`

#### Summary

Information about a new dockable pane being added to the Revit user interface.

#### Since

2014

### `P:Autodesk.Revit.UI.EditorInteraction.InteractionType`

Member kind: property
Symbol: `Autodesk.Revit.UI.EditorInteraction.InteractionType`

#### Summary

The type of interaction.

#### Remarks

This property is overridable to allow for clients to
dynamically return the type. For example, if your pane
interacts with certain editors or has different "modes"
based on user workflow.

### `M:Autodesk.Revit.UI.EditorInteraction.#ctor(Autodesk.Revit.UI.EditorInteractionType)`

Member kind: method
Symbol: `Autodesk.Revit.UI.EditorInteraction.#ctor(Autodesk.Revit.UI.EditorInteractionType)`

#### Summary

Construct the interaction with the specified type.

### `M:Autodesk.Revit.UI.EditorInteraction.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.UI.EditorInteraction.#ctor`

#### Summary

Construct a default interaction.

### `T:Autodesk.Revit.UI.EditorInteraction`

Member kind: type
Symbol: `Autodesk.Revit.UI.EditorInteraction`

#### Summary

Wraps the EditorInteractionType for the Pane to allow
for clients to override their type dynamically if need
be.

#### Since

2017

### `M:Autodesk.Revit.UI.IFrameworkElementCreator.CreateFrameworkElement`

Member kind: method
Symbol: `Autodesk.Revit.UI.IFrameworkElementCreator.CreateFrameworkElement`

#### Summary

Method called to create the FrameworkElement.

#### Since

2018

### `T:Autodesk.Revit.UI.IFrameworkElementCreator`

Member kind: type
Symbol: `Autodesk.Revit.UI.IFrameworkElementCreator`

#### Summary

Interface that the Revit UI will call, if present, to construct the FrameworkElement
for the pane.

#### Since

2018

### `M:Autodesk.Revit.UI.DockablePane.PaneExists(Autodesk.Revit.UI.DockablePaneId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePane.PaneExists(Autodesk.Revit.UI.DockablePaneId)`

#### Summary

Returns true if %id% refers to a dockable pane window that currently exists in the Revit user interface, whether it's hidden or shown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.UI.DockablePane.PaneIsRegistered(Autodesk.Revit.UI.DockablePaneId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePane.PaneIsRegistered(Autodesk.Revit.UI.DockablePaneId)`

#### Summary

Returns true if %id% refers to a built-in Revit dockable pane, or an add-in pane that has been properly registered with %Autodesk.Revit.UI.UIApplication.RegisterDockablePane%.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.UI.DockablePane.PaneIsBuiltIn(Autodesk.Revit.UI.DockablePaneId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePane.PaneIsBuiltIn(Autodesk.Revit.UI.DockablePaneId)`

#### Summary

Returns true if %id% refers to a built-in Revit dockable pane, rather than one created by an add-in.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.UI.DockablePane.IsShown`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePane.IsShown`

#### Summary

Identify the pane is currently visible or in a tab.

#### Since

2015

### `M:Autodesk.Revit.UI.DockablePane.Hide`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePane.Hide`

#### Summary

If the pane is on screen, hide it. Has no effect on built-in Revit dockable panes.

#### Since

2014

### `M:Autodesk.Revit.UI.DockablePane.Show`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePane.Show`

#### Summary

If the pane is not currently visible or in a tab, display the pane in the Revit user interface at its last docked location.

#### Since

2014

### `M:Autodesk.Revit.UI.DockablePane.GetTitle`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePane.GetTitle`

#### Summary

Returns the current title (a.k.a. window caption) of the dockable pane.

#### Since

2014

### `P:Autodesk.Revit.UI.DockablePane.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePane.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.DockablePane.Id`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePane.Id`

#### Summary

The unique identifier for this dockable pane.

#### Since

2014

### `M:Autodesk.Revit.UI.DockablePane.#ctor(Autodesk.Revit.UI.DockablePane)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePane.#ctor(Autodesk.Revit.UI.DockablePane)`

#### Summary

Constructs a new copy of the input DockablePane object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.UI.DockablePane.#ctor(Autodesk.Revit.UI.DockablePaneId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePane.#ctor(Autodesk.Revit.UI.DockablePaneId)`

#### Summary

Gets the pane with identifier %id%.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

no dockable pane has been registered with identifier id.
-or-
the dockable pane with identifier id has not been created yet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.UI.DockablePane`

Member kind: type
Symbol: `Autodesk.Revit.UI.DockablePane`

#### Summary

A user interface pane that participates in Revit's docking window system.

#### Since

2014

### `M:Autodesk.Revit.UI.DockablePaneState.SetFloatingRectangle(Autodesk.Revit.DB.Rectangle)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePaneState.SetFloatingRectangle(Autodesk.Revit.DB.Rectangle)`

#### Summary

When %dockPosition% is Floating, sets the rectangle used to determine the size and position of the pane when %dockPosition% is Floating. Coordinates are relative to the upper-left-hand corner of the main Revit window.

#### Parameter `rect`

The rectangle to use when floating.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Rectangle is not normalized.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.UI.DockablePaneState.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePaneState.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.DockablePaneState.MinimumHeight`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePaneState.MinimumHeight`

#### Summary

When %dockPosition% is anything other than floating, the minimum height to use for the pane. Default is 200 pixels.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for minimumHeight is not positive.

#### Since

2020

### `P:Autodesk.Revit.UI.DockablePaneState.MinimumWidth`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePaneState.MinimumWidth`

#### Summary

When %dockPosition% is anything other than floating, the minimum width to use for the pane. Default is 200 pixels.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for minimumWidth is not positive.

#### Since

2020

### `P:Autodesk.Revit.UI.DockablePaneState.TabBehind`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePaneState.TabBehind`

#### Summary

Ignored unless %dockPosition% is Tabbed. The new pane will appear in a tab behind the specified existing pane ID.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: no dockable pane has been registered with identifier tabBehind.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.UI.DockablePaneState.FloatingRectangle`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePaneState.FloatingRectangle`

#### Summary

When %dockPosition% is Floating, this rectangle determines the size and position of the pane. Coordinates are relative to the upper-left-hand corner of the main Revit window.
Note: the returned Rectangle is a copy. In order to change the pane state, you must call SetFloatingRectangle with a modified rectangle.

#### Since

2014

### `P:Autodesk.Revit.UI.DockablePaneState.DockPosition`

Member kind: property
Symbol: `Autodesk.Revit.UI.DockablePaneState.DockPosition`

#### Summary

Which part of the Revit application frame the pane should dock to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.UI.DockablePaneState.#ctor(Autodesk.Revit.UI.DockablePaneState)`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePaneState.#ctor(Autodesk.Revit.UI.DockablePaneState)`

#### Summary

Constructs a new copy of the input DockablePaneState object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.UI.DockablePaneState.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.UI.DockablePaneState.#ctor`

#### Summary

Creates a new DockablePaneState object.

#### Since

2014

### `T:Autodesk.Revit.UI.DockablePaneState`

Member kind: type
Symbol: `Autodesk.Revit.UI.DockablePaneState`

#### Summary

Describes where a dockable pane window should appear in the Revit user interface.

#### Since

2014

### `T:Autodesk.Revit.UI.DockPosition`

Member kind: type
Symbol: `Autodesk.Revit.UI.DockPosition`

#### Summary

Which part of the Revit application frame the pane should dock to.

#### Since

2014

#### Since

2014

### `T:Autodesk.Revit.UI.EditorInteractionType`

Member kind: type
Symbol: `Autodesk.Revit.UI.EditorInteractionType`

#### Summary

Defines the type of interactions a pane has with the active editor when it becomes active in the Revit UI.

#### Since

2017

#### Since

2017

### `F:Autodesk.Revit.UI.EditorInteractionType.KeepAlive`

Member kind: field
Symbol: `Autodesk.Revit.UI.EditorInteractionType.KeepAlive`

#### Summary

Keeps the active editor alive during pane activation.
This results in the current selection being kept active and available to the pane.

One example built-in dockable pane that uses this mode is the Revit Property Palette.

### `F:Autodesk.Revit.UI.EditorInteractionType.Dismiss`

Member kind: field
Symbol: `Autodesk.Revit.UI.EditorInteractionType.Dismiss`

#### Summary

Dismiss the active editor during pane activation.
This results in the current selection being cleared and the editor canceled.

One example built-in dockable pane that uses this mode is the Revit Project Browser.

### `M:Autodesk.Revit.UI.UIDocument.UpdateAllOpenViews`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.UpdateAllOpenViews`

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

### `M:Autodesk.Revit.UI.UIDocument.GetPlacementTypes(Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.GetPlacementTypes(Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.View)`

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

### `M:Autodesk.Revit.UI.UIDocument.SaveAs(Autodesk.Revit.UI.UISaveAsOptions)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.SaveAs(Autodesk.Revit.UI.UISaveAsOptions)`

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

### `M:Autodesk.Revit.UI.UIDocument.SaveAs`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.SaveAs`

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

### `M:Autodesk.Revit.UI.UIDocument.CanPlaceElementType(Autodesk.Revit.DB.ElementType)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.CanPlaceElementType(Autodesk.Revit.DB.ElementType)`

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

### `M:Autodesk.Revit.UI.UIDocument.PromptToMatchElementType(Autodesk.Revit.DB.ElementType)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.PromptToMatchElementType(Autodesk.Revit.DB.ElementType)`

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

### `M:Autodesk.Revit.UI.UIDocument.PromptToPlaceElementTypeOnLegendView(Autodesk.Revit.DB.ElementType)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.PromptToPlaceElementTypeOnLegendView(Autodesk.Revit.DB.ElementType)`

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

### `M:Autodesk.Revit.UI.UIDocument.PostRequestForElementTypePlacement(Autodesk.Revit.DB.ElementType)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.PostRequestForElementTypePlacement(Autodesk.Revit.DB.ElementType)`

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

### `M:Autodesk.Revit.UI.UIDocument.PromptToPlaceViewOnSheet(Autodesk.Revit.DB.View,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.PromptToPlaceViewOnSheet(Autodesk.Revit.DB.View,System.Boolean)`

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

### `M:Autodesk.Revit.UI.UIDocument.GetSketchGalleryOptions(Autodesk.Revit.DB.FamilySymbol)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.GetSketchGalleryOptions(Autodesk.Revit.DB.FamilySymbol)`

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

### `P:Autodesk.Revit.UI.UIDocument.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIDocument.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.UIDocument.ActiveGraphicalView`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIDocument.ActiveGraphicalView`

#### Summary

The currently active graphical view of the currently active document.

#### Remarks

This property is applicable to the currently active document only.
Returns `null` if this document doesn't represent the active document.

#### Since

2015

### `M:Autodesk.Revit.UI.UIDocument.GetOpenUIViews`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.GetOpenUIViews`

#### Summary

Get a list of all open view windows in the Revit user interface.

#### Remarks

A sheet view with an activated viewport will return the view associated with the activated viewport, not the sheet view.

### `P:Autodesk.Revit.UI.UIDocument.Application`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIDocument.Application`

#### Summary

Retrieves an object that represents the current Application.

### `M:Autodesk.Revit.UI.UIDocument.PromptForFamilyInstancePlacement(Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.PromptForFamilyInstancePlacement(Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions)`

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

### `M:Autodesk.Revit.UI.UIDocument.PromptForFamilyInstancePlacement(Autodesk.Revit.DB.FamilySymbol)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.PromptForFamilyInstancePlacement(Autodesk.Revit.DB.FamilySymbol)`

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

### `M:Autodesk.Revit.UI.UIDocument.RequestViewChange(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.RequestViewChange(Autodesk.Revit.DB.View)`

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

### `P:Autodesk.Revit.UI.UIDocument.Document`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIDocument.Document`

#### Summary

Returns the database level document represented by this UI-level document.

### `P:Autodesk.Revit.UI.UIDocument.ActiveView`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIDocument.ActiveView`

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

### `M:Autodesk.Revit.UI.UIDocument.RefreshActiveView`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.RefreshActiveView`

#### Summary

Refresh the display of the active view in the active document.

#### Since

2011

### `M:Autodesk.Revit.UI.UIDocument.ShowElements(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.ShowElements(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

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

### `M:Autodesk.Revit.UI.UIDocument.ShowElements(Autodesk.Revit.DB.ElementSet)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.ShowElements(Autodesk.Revit.DB.ElementSet)`

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

### `M:Autodesk.Revit.UI.UIDocument.ShowElements(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.ShowElements(Autodesk.Revit.DB.Element)`

#### Summary

Shows the element by zoom to fit.

#### Parameter `element`

Element that will be shown.

#### Remarks

Places the element in the center of screen by moving the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Element is null.

### `M:Autodesk.Revit.UI.UIDocument.ShowElements(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.ShowElements(Autodesk.Revit.DB.ElementId)`

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

### `M:Autodesk.Revit.UI.UIDocument.SaveAndClose`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.SaveAndClose`

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

### `P:Autodesk.Revit.UI.UIDocument.Selection`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIDocument.Selection`

#### Summary

Retrieve the currently selected Elements in Autodesk Revit.

#### Remarks

Returns an object that represents the active selection. The Selection property returns an
object that represents the active selection when the command was started.

### `M:Autodesk.Revit.UI.UIDocument.GetRevitUIFamilyLoadOptions`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.GetRevitUIFamilyLoadOptions`

#### Summary

Return the option object that allows you to use Revit's dialog boxes to let the user respond to questions that arise during loading of families.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if
this API method is invoked in UI less mode

### `M:Autodesk.Revit.UI.UIDocument.#ctor(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIDocument.#ctor(Autodesk.Revit.DB.Document)`

#### Summary

Use a database level Document to construct a UI-level Document.

#### Parameter `document`

The database level document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a primary document, it is a linked document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.UI.UIDocument`

Member kind: type
Symbol: `Autodesk.Revit.UI.UIDocument`

#### Summary

An object that represents an Autodesk Revit project opened in the Revit user interface.

#### Remarks

This class represents a document opened in the user interface and therefore offers interfaces
to work with settings and operations in the UI (for example, the active selection). Revit can have multiple
projects open and multiple views to those projects. The active or top most view will be the
active project and hence the active document which is available from the UIApplication object.

Obtain the database level Document (which contains interfaces not related to the UI) via the
Document property. If you have a database level Document and need to access it from the UI, you can
construct a new UIDocument from that object (the document must be open and visible in the UI to allow the methods to
work successfully).

### `T:ModelIdentity`

Member kind: type
Symbol: `ModelIdentity`

#### Summary

Model Identity with GUID

### `T:Autodesk.Revit.UI.SketchGalleryOptions`

Member kind: type
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions`

#### Summary

Enumerates all the sketch options.

#### Since

2017

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_SketchLanding`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_SketchLanding`

#### Summary

Sketch a landing.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_SketchRun`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_SketchRun`

#### Summary

Sketch a run.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_LandingWithTwoRuns`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_LandingWithTwoRuns`

#### Summary

Pick two runs to create a landing.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_WinderUShape`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_WinderUShape`

#### Summary

Sketch a U-Shape winder.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_SupportPickLine`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_SupportPickLine`

#### Summary

Pick a line to create a support.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_WinderPattern`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_WinderPattern`

#### Summary

Pick winder pattern.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_WinderLShape`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_WinderLShape`

#### Summary

Sketch a L-Shape winder.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_LandingSquare`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_LandingSquare`

#### Summary

Sketch a landing square.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_RunArcCenterEnds`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_RunArcCenterEnds`

#### Summary

Sketch a Center-Ends spiral for a run of stairs.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_RunArcFullStep`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_RunArcFullStep`

#### Summary

Sketch a Full-Step spiral for a run of stairs.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_RunLine`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_RunLine`

#### Summary

Sketch a line for a run of stairs.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_PointElement`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_PointElement`

#### Summary

Pick point element.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_PickPoints`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_PickPoints`

#### Summary

Pick points.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_Point`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_Point`

#### Summary

Pick a point.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_PickRoofs`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_PickRoofs`

#### Summary

Pick roofs.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_PickSupports`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_PickSupports`

#### Summary

Pick supports.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_PickWalls`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_PickWalls`

#### Summary

Pick walls.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_PickFaces`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_PickFaces`

#### Summary

Pick faces.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_PickLines`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_PickLines`

#### Summary

Pick lines.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_PartialEllipse`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_PartialEllipse`

#### Summary

Sketch a partial ellipse.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_FullEllipse`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_FullEllipse`

#### Summary

Sketch a full ellipse.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_SplineByPoints`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_SplineByPoints`

#### Summary

Sketch a spline by points.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_Spline`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_Spline`

#### Summary

Sketch a spline.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_ArcFillet`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_ArcFillet`

#### Summary

Sketch a fillet arc.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_ArcTanEnd`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_ArcTanEnd`

#### Summary

Sketch a Tangent-End arc.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_ArcCenterEnds`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_ArcCenterEnds`

#### Summary

Sketch a Center-Ends arc.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_Arc3Point`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_Arc3Point`

#### Summary

Sketch a Start-End-Radius arc.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_Circle`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_Circle`

#### Summary

Sketch a circle.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_CircumscribedPolygon`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_CircumscribedPolygon`

#### Summary

Sketch a circumscribed polygon.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_InscribedPolygon`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_InscribedPolygon`

#### Summary

Sketch an inscribed polygon.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_Rect`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_Rect`

#### Summary

Sketch a rectangle.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_Line`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_Line`

#### Summary

Sketch a line.

### `F:Autodesk.Revit.UI.SketchGalleryOptions.SGO_Default`

Member kind: field
Symbol: `Autodesk.Revit.UI.SketchGalleryOptions.SGO_Default`

#### Summary

The default option which means the real option is decided by Revit internally.

### `T:Autodesk.Revit.UI.FaceBasedPlacementType`

Member kind: type
Symbol: `Autodesk.Revit.UI.FaceBasedPlacementType`

#### Summary

This enumerated type specifies options available for placement of a face-based family instance.

#### Since

2017

### `F:Autodesk.Revit.UI.FaceBasedPlacementType.PlaceOnWorkPlane`

Member kind: field
Symbol: `Autodesk.Revit.UI.FaceBasedPlacementType.PlaceOnWorkPlane`

#### Summary

Placement on current workplane.

### `F:Autodesk.Revit.UI.FaceBasedPlacementType.PlaceOnFace`

Member kind: field
Symbol: `Autodesk.Revit.UI.FaceBasedPlacementType.PlaceOnFace`

#### Summary

Placement on a selected face from existing geometry.

### `F:Autodesk.Revit.UI.FaceBasedPlacementType.PlaceOnVerticalFace`

Member kind: field
Symbol: `Autodesk.Revit.UI.FaceBasedPlacementType.PlaceOnVerticalFace`

#### Summary

Placement on a vertical face.

### `F:Autodesk.Revit.UI.FaceBasedPlacementType.Default`

Member kind: field
Symbol: `Autodesk.Revit.UI.FaceBasedPlacementType.Default`

#### Summary

Placement the instance which is not face-based.

### `M:Autodesk.Revit.UI.RibbonPanel.Equals(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.UI.RibbonPanel.Equals(System.Object)`

#### Summary

Determines whether the specified `T:System.Object` is equal to the current `T:System.Object` .

#### Parameter `obj`

Another panel object.

### `M:Autodesk.Revit.UI.RibbonPanel.AddSlideOut`

Member kind: method
Symbol: `Autodesk.Revit.UI.RibbonPanel.AddSlideOut`

#### Summary

Adds a slideout to the current panel.

#### Remarks

The slideout part of the panel can be shown by clicking on the arrow at the bottom of the panel.
After calling AddSlideOut(), any subsequent calls to add new items will add the new item(s) to the slideout.
The slideout part of the panel will be shown only if items are added after this call.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when a slide out panel is already added.

#### Since

2011

### `M:Autodesk.Revit.UI.RibbonPanel.AddStackedItems(Autodesk.Revit.UI.RibbonItemData,Autodesk.Revit.UI.RibbonItemData,Autodesk.Revit.UI.RibbonItemData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.RibbonPanel.AddStackedItems(Autodesk.Revit.UI.RibbonItemData,Autodesk.Revit.UI.RibbonItemData,Autodesk.Revit.UI.RibbonItemData)`

#### Summary

Adds three stacked items to the panel.

#### Parameter `item1`

Data containing information about the first item. This data must be of type PushButtonData, PulldownButtonData, SplitButtonData, ComboBoxData, or TextBoxData.

#### Parameter `item2`

Data containing information about the second item. This data must be of type PushButtonData, PulldownButtonData, SplitButtonData, ComboBoxData, or TextBoxData.

#### Parameter `item3`

Data containing information about the third item. This data must be of type PushButtonData, PulldownButtonData, SplitButtonData, ComboBoxData, or TextBoxData.

#### Returns

A collection containing the added items.

#### Remarks

Each new item may either be a PushButton, PulldownButton, SplitButton, ComboBox or TextBox, depending upon the type of
data passed in for each argument. The new items will be created as small-size horizontal controls,
with the first stacked on top of the second in the panel.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when item1, item2 or item3 is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when an item with item1.Name or item2.Name or item3.Name already exists in the panel or the data is not of the correct type.

#### Since

2011

### `M:Autodesk.Revit.UI.RibbonPanel.AddStackedItems(Autodesk.Revit.UI.RibbonItemData,Autodesk.Revit.UI.RibbonItemData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.RibbonPanel.AddStackedItems(Autodesk.Revit.UI.RibbonItemData,Autodesk.Revit.UI.RibbonItemData)`

#### Summary

Adds two stacked items to the panel.

#### Parameter `item1`

Data containing information about the first item. This data must be of type PushButtonData, PulldownButtonData, SplitButtonData, ComboBoxData, or TextBoxData.

#### Parameter `item2`

Data containing information about the second item. This data must be of type PushButtonData, PulldownButtonData, SplitButtonData, ComboBoxData, or TextBoxData.

#### Returns

A collection containing the added items.

#### Remarks

Each new item may either be a PushButton, PulldownButton, SplitButton, ComboBox or TextBox, depending upon the type of
data passed in for each argument. The new items will be created as small-size horizontal controls,
with the first stacked on top of the second in the panel.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when item1 or item2 is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when an item with the item1.Name or item2.Name already exists in the panel or the data is not of the correct type.

#### Since

2011

### `M:Autodesk.Revit.UI.RibbonPanel.AddItem(Autodesk.Revit.UI.RibbonItemData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.RibbonPanel.AddItem(Autodesk.Revit.UI.RibbonItemData)`

#### Summary

Adds a Ribbon item to the panel.

#### Parameter `itemData`

Data containing information about the new item.

#### Returns

The added Ribbon item.

#### Remarks

The new item may either be a PushButton, PulldownButton, SplitButon, RadioButtonGroup, ComboBox, or TextBox depending upon the type of data passed in.
The new item may be created as a large-size vertical control in the panel.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when itemData is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when an item with the itemData.Name already exists in the panel or the data is not of the correct type.

#### Since

2011

### `M:Autodesk.Revit.UI.RibbonPanel.AddSeparator`

Member kind: method
Symbol: `Autodesk.Revit.UI.RibbonPanel.AddSeparator`

#### Summary

Adds a new Separator to the panel.

#### Remarks

The separator won't be shown if there are no items already added to the panel.

### `M:Autodesk.Revit.UI.RibbonPanel.GetItems`

Member kind: method
Symbol: `Autodesk.Revit.UI.RibbonPanel.GetItems`

#### Summary

Gets a copy of the collection of RibbonItems assigned to the RibbonPanel.

#### Remarks

This method gets the items assigned to the RibbonPanel.

### `P:Autodesk.Revit.UI.RibbonPanel.Enabled`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonPanel.Enabled`

#### Summary

Gets or sets a value indicating whether the RibbonPanel can respond to user interaction.

#### Value

True if the panel allows interaction, false if the panel disallows interaction with all the controls it contains.

### `P:Autodesk.Revit.UI.RibbonPanel.Visible`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonPanel.Visible`

#### Summary

Gets or sets a value indicating whether the RibbonPanel is displayed.

#### Value

True if the RibbonPanel is displayed; otherwise, false. The default is true.

### `P:Autodesk.Revit.UI.RibbonPanel.Title`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonPanel.Title`

#### Summary

Gets or sets the text of the RibbonPanel.

#### Remarks

If this property is not set, the default value is its Name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the title contains angle bracket.

### `P:Autodesk.Revit.UI.RibbonPanel.Name`

Member kind: property
Symbol: `Autodesk.Revit.UI.RibbonPanel.Name`

#### Summary

Gets or sets the name of the RibbonPanel.

#### Remarks

The name will be displayed on the panel if the Text is not set.

### `T:Autodesk.Revit.UI.RibbonPanel`

Member kind: type
Symbol: `Autodesk.Revit.UI.RibbonPanel`

#### Summary

Represents a panel added by an External Application or External Command into the Add-Ins tab.

#### Remarks

The Panel class provides read and write access to the RibbonItems contained in the panel. Use of this class is not supported in Revit Macros.

### `T:Autodesk.Revit.UI.Tab`

Member kind: type
Symbol: `Autodesk.Revit.UI.Tab`

#### Summary

An enumerated type listing static tabs which support addition of panels via the API.

### `F:Autodesk.Revit.UI.Tab.Analyze`

Member kind: field
Symbol: `Autodesk.Revit.UI.Tab.Analyze`

#### Summary

The Analyze tab.

### `F:Autodesk.Revit.UI.Tab.AddIns`

Member kind: field
Symbol: `Autodesk.Revit.UI.Tab.AddIns`

#### Summary

The Add-Ins tab.

### `P:Autodesk.Revit.UI.Events.ViewActivatingEventArgs.CurrentActiveView`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.ViewActivatingEventArgs.CurrentActiveView`

#### Summary

The view that is currently active.

#### Remarks

May be `null` if there is no currently active view.

#### Since

2010

### `P:Autodesk.Revit.UI.Events.ViewActivatingEventArgs.NewActiveView`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.ViewActivatingEventArgs.NewActiveView`

#### Summary

The view that is going to become active.

#### Since

2010

### `T:Autodesk.Revit.UI.Events.ViewActivatingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.ViewActivatingEventArgs`

#### Summary

The event arguments used by the ViewActivating event.

#### Since

2010

### `P:Autodesk.Revit.UI.Events.ViewActivatedEventArgs.PreviousActiveView`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.ViewActivatedEventArgs.PreviousActiveView`

#### Summary

The previously active view.

#### Remarks

May be `null` if there was no previously active view.

#### Since

2010

### `P:Autodesk.Revit.UI.Events.ViewActivatedEventArgs.CurrentActiveView`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.ViewActivatedEventArgs.CurrentActiveView`

#### Summary

The view that has just become active.

#### Since

2010

### `T:Autodesk.Revit.UI.Events.ViewActivatedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.ViewActivatedEventArgs`

#### Summary

The event arguments used by the ViewActivated event.

#### Since

2010

### `M:Autodesk.Revit.UI.Events.TransferredProjectStandardsEventArgs.GetSelectedExternalItems`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.TransferredProjectStandardsEventArgs.GetSelectedExternalItems`

#### Summary

Gets the collection of externally added items that the user opted to enable for transfer in the Transfer Project Standards dialog.

#### Remarks

If more than one add-in has registered external items, this will report items enabled for transfer for all such add-ins. Add-ins should handle the transfer only for those items which they actually registered in the TransferringProjectStandards event.

#### Returns

External items user wants to transfer.

#### Since

2017.2

### `P:Autodesk.Revit.UI.Events.TransferredProjectStandardsEventArgs.TargetDocument`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.TransferredProjectStandardsEventArgs.TargetDocument`

#### Summary

Target document.

#### Since

2017.2

### `P:Autodesk.Revit.UI.Events.TransferredProjectStandardsEventArgs.SourceDocument`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.TransferredProjectStandardsEventArgs.SourceDocument`

#### Summary

Source document.

#### Since

2017.2

### `T:Autodesk.Revit.UI.Events.TransferredProjectStandardsEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.TransferredProjectStandardsEventArgs`

#### Summary

The event arguments used by the TransferredProjectStandards event.

#### Since

2017.2

### `M:Autodesk.Revit.UI.Events.TransferringProjectStandardsEventArgs.SetExternalItems(System.Collections.Generic.IDictionary{System.Guid,System.String})`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.TransferringProjectStandardsEventArgs.SetExternalItems(System.Collections.Generic.IDictionary{System.Guid,System.String})`

#### Summary

Sets the collection of externally added items which should be shown in the Transfer Project Standards dialog as options.

#### Remarks

The externally added items that the user opted to transfer will be reported in the args to the TransferredProjectStandards event.

#### Parameter `externalItems`

The external items which are displayed in the Transfer Project Standards UI.
GUIDvalue is used to identify the external item string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017.2

### `M:Autodesk.Revit.UI.Events.TransferringProjectStandardsEventArgs.GetExternalItems`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.TransferringProjectStandardsEventArgs.GetExternalItems`

#### Summary

Gets the collection of externally added items which should be shown in the Transfer Project Standards dialog as options.

#### Returns

The external items which are displayed in the Transfer Project Standards UI.
GUIDvalue is used to identify the external item string.

#### Since

2017.2

### `P:Autodesk.Revit.UI.Events.TransferringProjectStandardsEventArgs.TargetDocument`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.TransferringProjectStandardsEventArgs.TargetDocument`

#### Summary

Target document.

#### Since

2017.2

### `P:Autodesk.Revit.UI.Events.TransferringProjectStandardsEventArgs.SourceDocument`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.TransferringProjectStandardsEventArgs.SourceDocument`

#### Summary

Source document.

#### Since

2017.2

### `T:Autodesk.Revit.UI.Events.TransferringProjectStandardsEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.TransferringProjectStandardsEventArgs`

#### Summary

The event arguments used by the TransferringProjectStandards event.

#### Since

2017.2

### `T:Autodesk.Revit.UI.Events.ThemeChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.ThemeChangedEventArgs`

#### Summary

The event arguments used by the ThemeChanged event.

#### Since

2024

### `M:Autodesk.Revit.UI.Events.SelectionChangedEventArgs.GetDocument`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.SelectionChangedEventArgs.GetDocument`

#### Summary

Returns the document associated with this event.

#### Since

2023

### `M:Autodesk.Revit.UI.Events.SelectionChangedEventArgs.GetSelectedElements`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.SelectionChangedEventArgs.GetSelectedElements`

#### Summary

Returns ElementIds of selected elements.

#### Since

2023

### `M:Autodesk.Revit.UI.Events.SelectionChangedEventArgs.GetReferences`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.SelectionChangedEventArgs.GetReferences`

#### Summary

Returns the references that are currently selected.

#### Remarks

The references can be an element or subelement in the host or a linked document.

#### Returns

The collection containing the selected references.

#### Since

2023

### `T:Autodesk.Revit.UI.Events.SelectionChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.SelectionChangedEventArgs`

#### Summary

The event arguments used by the SelectionChanged event.

#### Since

2023

### `M:Autodesk.Revit.UI.Events.IdlingEventArgs.SetRaiseWithoutDelay`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.IdlingEventArgs.SetRaiseWithoutDelay`

#### Summary

Sets the next invocation of the idling event to be called promptly,
rather than relying on the default recurrence of idling from the Revit application. For more
details see the remarks describing the Idling event.

### `T:Autodesk.Revit.UI.Events.IdlingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.IdlingEventArgs`

#### Summary

The event arguments used by the Idling event.

### `M:Autodesk.Revit.UI.Events.FormulaEditingEventArgs.Apply(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FormulaEditingEventArgs.Apply(System.String)`

#### Summary

Applies formula to the parameter

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.UI.Events.FormulaEditingEventArgs.Formula`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.FormulaEditingEventArgs.Formula`

#### Summary

Returns text of the formula that will be modified

### `P:Autodesk.Revit.UI.Events.FormulaEditingEventArgs.ParameterId`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.FormulaEditingEventArgs.ParameterId`

#### Summary

Returns the Id of the modified parameter

### `P:Autodesk.Revit.UI.Events.FormulaEditingEventArgs.CurrentDocument`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.FormulaEditingEventArgs.CurrentDocument`

#### Summary

Returns the current document

### `T:Autodesk.Revit.UI.Events.FormulaEditingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.FormulaEditingEventArgs`

#### Summary

The event arguments used by the DocumentSaving event.

### `M:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetServiceSwapOutInitialSizes`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetServiceSwapOutInitialSizes`

#### Summary

Gets the service swap out initial sizes.

#### Returns

Returns the service swap out initial sizes.

#### Since

2017

### `M:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.SwitchToInlineFittingsTab`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.SwitchToInlineFittingsTab`

#### Summary

Makes the innline fittings tab active in the Change Service window.

#### Since

2017

### `M:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetServiceSwapOutProfiles`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetServiceSwapOutProfiles`

#### Summary

Gets the service swap out profile types.

#### Since

2017

### `M:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetServiceSwapOutDomain`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetServiceSwapOutDomain`

#### Summary

Gets the service swap out domain.

#### Returns

The domain type.

#### Since

2017

### `M:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetServiceSwapOutSizeMappings`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetServiceSwapOutSizeMappings`

#### Summary

Gets the set of service swap out size mappings.

#### Returns

The set of service swap out size mappings.

#### Since

2017

### `M:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetDefaultTypeMappings`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetDefaultTypeMappings`

#### Summary

Gets the set of default maps for part type mappings.

#### Since

2017

### `M:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetServiceSwapOutPartTypeMappings`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetServiceSwapOutPartTypeMappings`

#### Summary

Gets the set of service swap out part type mappings.

#### Returns

The set of service swap out part type mappings.

#### Since

2017

### `M:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetServiceSwapOutServiceIds`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetServiceSwapOutServiceIds`

#### Summary

Gets the set of service ids to be swapped out.

#### Returns

The set of service ids.

#### Since

2017

### `M:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetCurrentSolutionPartTypeIds`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetCurrentSolutionPartTypeIds`

#### Summary

Returns set of fabrication part types that are used in the currently selected solution.

#### Returns

The set of ElementIds.

#### Since

2017

### `M:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetAllSolutionsPartsTypeCounts`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetAllSolutionsPartsTypeCounts`

#### Summary

Returns the total fabrication part type usage count in all routing solutions.

#### Since

2017

### `M:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetFilteredSolutionsPartsTypeCounts`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetFilteredSolutionsPartsTypeCounts`

#### Summary

Returns the active fabrication part type usage count in fitlered routing solutions.

#### Since

2017

### `M:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetRequiredFabricationPartTypeIds`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetRequiredFabricationPartTypeIds`

#### Summary

Returns set of required fabrication part types in use in routing solution mode.

#### Returns

The set of ElementIds for for required fabrication part types that is in use in routing solution mode.

#### Since

2017

### `M:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetFabricationPartTypeIds`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.GetFabricationPartTypeIds`

#### Summary

Returns set of fabrication part types in use in the routing solution mode.

#### Returns

The set of ElementIds for for fabrication part types that is in use in routing solution mode.

#### Since

2017

### `P:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.NumberOfSolutions`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.NumberOfSolutions`

#### Summary

The number of active solutions in routing solution mode.

#### Since

2017

### `P:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.ServiceId`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.ServiceId`

#### Summary

The identifier for the fabrication service.

#### Since

2017

### `P:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.Operation`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs.Operation`

#### Summary

The operation associated with this event

#### Since

2017

### `T:Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserChangedEventArgs`

#### Summary

The event arguments used by the FabricationPartBrowserChangedEventArgs event.

#### Since

2017

### `T:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation`

#### Summary

Operations for the FabricationPartBrowserChangedEventArgs Event

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.SwitchToInlineFittingsTab`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.SwitchToInlineFittingsTab`

#### Summary

Make the inline fittings tab active in Change Service.

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.FinishSizeSwapOutMode`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.FinishSizeSwapOutMode`

#### Summary

Finish size swap out mode.

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.StartSizeSwapOutMode`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.StartSizeSwapOutMode`

#### Summary

Start size swap-out mode.

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.UpdateServiceSwapOutSizes`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.UpdateServiceSwapOutSizes`

#### Summary

Service swap out size mappings has changed.

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.UpdateServiceSwapOutPartTypes`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.UpdateServiceSwapOutPartTypes`

#### Summary

Service swap out part type mappings has changed.

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.FinishServiceSwapOutMode`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.FinishServiceSwapOutMode`

#### Summary

Finish service swap-out mode

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.StartServiceSwapOutMode`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.StartServiceSwapOutMode`

#### Summary

Start service swap-out mode

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.FinishMPRoutingMode`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.FinishMPRoutingMode`

#### Summary

Finish multi-point routing mode

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.StartMPRoutingMode`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.StartMPRoutingMode`

#### Summary

Start multi-point routing mode

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.FinishRoutingSolutionMode`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.FinishRoutingSolutionMode`

#### Summary

Finish routing solution mode

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.RoutingSolutionChanged`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.RoutingSolutionChanged`

#### Summary

Active Routing solution has changed

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.CreatedRoutingSolutions`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.CreatedRoutingSolutions`

#### Summary

Routing solutions (re)created

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.StartRoutingSolutionMode`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.StartRoutingSolutionMode`

#### Summary

Start routing solution mode

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.ShowService`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.ShowService`

#### Summary

Select current service

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.HideBrowser`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.HideBrowser`

#### Summary

Hide browser window

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.ShowBrowser`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.ShowBrowser`

#### Summary

Show browser window

### `F:Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.UnknownOperation`

Member kind: field
Symbol: `Autodesk.Revit.UI.Events.FabricationPartBrowserOperation.UnknownOperation`

#### Summary

Unknown operation

### `P:Autodesk.Revit.UI.Events.DockableFrameVisibilityChangedEventArgs.PaneId`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.DockableFrameVisibilityChangedEventArgs.PaneId`

#### Summary

The identifier for dockable pane.

#### Since

2015

### `P:Autodesk.Revit.UI.Events.DockableFrameVisibilityChangedEventArgs.DockableFrameShown`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.DockableFrameVisibilityChangedEventArgs.DockableFrameShown`

#### Summary

True if the pane is being shown, false if it is being hidden.

#### Since

2015

### `T:Autodesk.Revit.UI.Events.DockableFrameVisibilityChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.DockableFrameVisibilityChangedEventArgs`

#### Summary

The event arguments used by the DockableFrameVisibilityChanged event.

#### Since

2015

### `P:Autodesk.Revit.UI.Events.DockableFrameFocusChangedEventArgs.PaneId`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.DockableFrameFocusChangedEventArgs.PaneId`

#### Summary

The identifier for dockable pane.

#### Since

2015

### `P:Autodesk.Revit.UI.Events.DockableFrameFocusChangedEventArgs.FocusGained`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.DockableFrameFocusChangedEventArgs.FocusGained`

#### Summary

True if the pane is being activated, false if it is being inactivated.

#### Since

2015

### `T:Autodesk.Revit.UI.Events.DockableFrameFocusChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.DockableFrameFocusChangedEventArgs`

#### Summary

The event arguments used by the DockableFrameActivatedChanged event.

#### Since

2015

### `P:Autodesk.Revit.UI.Events.DisplayingOptionsDialogEventArgs.PagesCount`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.DisplayingOptionsDialogEventArgs.PagesCount`

#### Summary

The count of pages in the options dialog (include the default pages added by Revit).

#### Since

2013

### `M:Autodesk.Revit.UI.Events.DisplayingOptionsDialogEventArgs.AddTab(System.String,Autodesk.Revit.UI.TabbedDialogExtension)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.DisplayingOptionsDialogEventArgs.AddTab(System.String,Autodesk.Revit.UI.TabbedDialogExtension)`

#### Summary

Add tab to option dialog with tab name and handler information.

#### Remarks

There is a limit to the number of options page permitted in the dialog.

#### Parameter `newTabName`

The new tab page name.

#### Parameter `tabbedDialogExtension`

The handlers information for the new tab page.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the limit
of pages allowed in the Options dialog will be exceeded (99).

#### Since

2013

### `T:Autodesk.Revit.UI.Events.DisplayingOptionsDialogEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.DisplayingOptionsDialogEventArgs`

#### Summary

The event arguments used by DisplayingOptionDialog event.

### `P:Autodesk.Revit.UI.Events.TaskDialogShowingEventArgs.Message`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.TaskDialogShowingEventArgs.Message`

#### Summary

The message that has been displayed in the dialog box.

#### Since

2010

### `T:Autodesk.Revit.UI.Events.TaskDialogShowingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.TaskDialogShowingEventArgs`

#### Summary

The event arguments used by the DialogBoxShowing event when a Revit task dialog that prompts the user for some action is shown.

#### Remarks

When the application receives this object, a task dialog is about to be displayed in Revit that
requires user interaction. The OverrideResult function can be used to cause the dialog
to be dismissed and return a desired result code.

#### Since

2010

### `P:Autodesk.Revit.UI.Events.MessageBoxShowingEventArgs.DialogType`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.MessageBoxShowingEventArgs.DialogType`

#### Summary

An integer that describes the standard Windows type of the dialog box.

#### Since

2010

### `P:Autodesk.Revit.UI.Events.MessageBoxShowingEventArgs.Message`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.MessageBoxShowingEventArgs.Message`

#### Summary

The message that has been displayed in the dialog box.

#### Since

2010

### `T:Autodesk.Revit.UI.Events.MessageBoxShowingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.MessageBoxShowingEventArgs`

#### Summary

The event arguments used by the DialogBoxShowing event when a Windows message box is about to be displayed in Revit.

#### Remarks

When the application receives this object, a simple message box is about to be displayed in Revit that
requires user interaction. The OverrideResult function can be used to cause the dialog
to be dismissed and return a desired result code.

#### Since

2010

### `M:Autodesk.Revit.UI.Events.DialogBoxShowingEventArgs.OverrideResult(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.DialogBoxShowingEventArgs.OverrideResult(System.Int32)`

#### Summary

Call this method to cause the Autodesk Revit dialog to be dismissed with the specified return value.

#### Remarks

The range of valid result values depends on the type of dialog as follows:
DialogBox: Any non-zero value will cause a dialog to be dismissed.

MessageBox: Standard Message Box IDs, such as IDOK and IDCANCEL, are accepted.
For all possible IDs, refer to the Windows API documentation.
The ID used must be relevant to the buttons in a message box.

TaskDialog: Standard Message Box IDs and Revit Custom IDs are accepted,
depending on the buttons used in a dialog. Standard buttons, such as OK
and Cancel, have standard IDs described in Windows API documentation.
Buttons with custom text have custom IDs with incremental values
starting at 1001 for the left-most or top-most button in a task dialog.

#### Parameter `resultCode`

The result code you wish the Revit dialog to return.

#### Returns

True if the result code was accepted.

#### Since

2010

### `P:Autodesk.Revit.UI.Events.DialogBoxShowingEventArgs.DialogId`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.DialogBoxShowingEventArgs.DialogId`

#### Summary

A unique string identifier for DialogBox and TaskDialog type dialogs in Revit.

#### Remarks

The contents of this entry vary depending on the type of dialog which is shown:
DialogBox: A unique string ID that can be used to identify those whihch dialog has been invoked.

TaskDialog: The customed string if TaskDialog.Id is set, empty string for default TaskDialog.Show(). For Revit-created dialog boxes, this
should always have an assigned value.

Standard Message Boxes: this will be an empty string.

#### Since

2017

### `P:Autodesk.Revit.UI.Events.DialogBoxShowingEventArgs.Result`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.DialogBoxShowingEventArgs.Result`

#### Since

2010

### `T:Autodesk.Revit.UI.Events.DialogBoxShowingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.DialogBoxShowingEventArgs`

#### Summary

The base class for the event arguments used by the DialogBoxShowing event.

#### Remarks

The actual type of the event arguments will be different depending upon the type of dialog shown.
When the application receives this object, a dialog is to be displayed in Revit that
requires user interaction. The OverrideResult function can be used to cause the dialog
to be dismissed and return a desired result code.

#### Since

2010

### `T:Autodesk.Revit.UI.Events.ApplicationClosingEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.ApplicationClosingEventArgs`

#### Summary

The event arguments used by the ApplicationClosing event.

### `M:ModScopeUtil.getSelectableElementsWithGivenType(ADocument*,ElementId,DBView*,System.Boolean!System.Runtime.CompilerServices.IsConst,Arr<ElementId>*)`

Member kind: method
Symbol: `ModScopeUtil.getSelectableElementsWithGivenType(ADocument*,ElementId,DBView*,System.Boolean!System.Runtime.CompilerServices.IsConst,Arr<ElementId>*)`

### `P:Autodesk.Revit.UI.Events.CanExecuteEventArgs.IsChecked`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.CanExecuteEventArgs.IsChecked`

#### Summary

The value that indicates whether the UI associated with the Command associated with this event is in a checked state.

#### Since

2020

### `M:Autodesk.Revit.UI.Events.CanExecuteEventArgs.GetSelectedCategoryIds`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.CanExecuteEventArgs.GetSelectedCategoryIds`

#### Summary

Gets the category ids of selected elements.

#### Since

2013

### `P:Autodesk.Revit.UI.Events.CanExecuteEventArgs.CanExecute`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.CanExecuteEventArgs.CanExecute`

#### Summary

The value that indicates whether the Command associated with this event can be executed.

#### Since

2013

### `T:Autodesk.Revit.UI.Events.CanExecuteEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.CanExecuteEventArgs`

#### Summary

The event arguments used by AddInCommandBinding's CanExecute event.

#### Since

2013

### `M:Autodesk.Revit.UI.Events.ExecutedEventArgs.SetJournalData(System.Collections.Generic.IDictionary{System.String,System.String})`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.ExecutedEventArgs.SetJournalData(System.Collections.Generic.IDictionary{System.String,System.String})`

#### Summary

Sets the journal data associated to this command (on journal playback).

#### Remarks

For details about the use of journal data associated to a command, see ExternalCommandData.JournalData.

#### Since

2017

### `M:Autodesk.Revit.UI.Events.ExecutedEventArgs.GetJournalData`

Member kind: method
Symbol: `Autodesk.Revit.UI.Events.ExecutedEventArgs.GetJournalData`

#### Summary

Gets the journal data associated to this command (on journal playback).

#### Remarks

For details about the use of journal data associated to a command, see ExternalCommandData.JournalData.

#### Since

2017

### `T:Autodesk.Revit.UI.Events.ExecutedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.ExecutedEventArgs`

#### Summary

The event arguments used by AddInCommandBinding's Executed event.

#### Since

2013

### `P:Autodesk.Revit.UI.Events.BeforeExecutedEventArgs.UsingCommandData`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.BeforeExecutedEventArgs.UsingCommandData`

#### Summary

Indicates whether or not the Revit journal will include custom data populated by the application associated with this command.

#### Remarks

For details about the use of journal data associated to a command, see `P:Autodesk.Revit.UI.ExternalCommandData.JournalData` .
The default value is false.

#### Since

2017

### `T:Autodesk.Revit.UI.Events.BeforeExecutedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.BeforeExecutedEventArgs`

#### Summary

The event arguments used by AddInCommandBinding's BeforeExecuted event.

#### Remarks

This event is cancellable. If your callback sets the Cancel property to true, the command will not execute.

#### Since

2014

### `P:Autodesk.Revit.UI.Events.CommandEventArgs.CommandId`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.CommandEventArgs.CommandId`

#### Summary

The command id.

#### Since

2013

### `P:Autodesk.Revit.UI.Events.CommandEventArgs.ActiveDocument`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.CommandEventArgs.ActiveDocument`

#### Summary

The active document.

#### Since

2013

### `T:Autodesk.Revit.UI.Events.CommandEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.CommandEventArgs`

#### Summary

The base class of the command Executed and CanExecute event arguments.

#### Since

2013

### `T:Autodesk.Revit.UI.Events.TextBoxEnterPressedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.TextBoxEnterPressedEventArgs`

#### Summary

The event arguments used by TextBox's EnterPressed event.

### `P:Autodesk.Revit.UI.Events.ComboBoxCurrentChangedEventArgs.NewValue`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.ComboBoxCurrentChangedEventArgs.NewValue`

#### Summary

The current item for the ComboBox after the change.

### `P:Autodesk.Revit.UI.Events.ComboBoxCurrentChangedEventArgs.OldValue`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.ComboBoxCurrentChangedEventArgs.OldValue`

#### Summary

The current item for the ComboBox before the change.

### `T:Autodesk.Revit.UI.Events.ComboBoxCurrentChangedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.ComboBoxCurrentChangedEventArgs`

#### Summary

The event arguments used by ComboBox's CurrentChanged event.

### `T:Autodesk.Revit.UI.Events.ComboBoxDropDownClosedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.ComboBoxDropDownClosedEventArgs`

#### Summary

The event arguments used by ComboBox's DropDownClosed event.

### `T:Autodesk.Revit.UI.Events.ComboBoxDropDownOpenedEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.ComboBoxDropDownOpenedEventArgs`

#### Summary

The event arguments used by ComboBox's DropDownOpened event.

### `P:Autodesk.Revit.UI.Events.RibbonItemEventArgs.Application`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.RibbonItemEventArgs.Application`

#### Summary

The current UIApplication.

### `T:Autodesk.Revit.UI.Events.RibbonItemEventArgs`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.RibbonItemEventArgs`

#### Summary

The base class of the RibbonItem event arguments which have UIApplication property.

### `P:Autodesk.Revit.UI.ExternalCommandData.JournalData`

Member kind: property
Symbol: `Autodesk.Revit.UI.ExternalCommandData.JournalData`

#### Summary

A data map that can be used to read and write data to the Autodesk Revit journal file.

#### Remarks

The data map is a string to string map that can be used to store data in the Revit journal
file at the end of execution of the external command. If the command is then executed from the journal
file during playback this data is then passed to the external command in this Data property so the
external command can execute with this passed data in a UI-less mode, hence providing non interactive
journal playback for automated testing purposes. For more information on Revit's journaling features
contact the Autodesk Developer Network.

### `P:Autodesk.Revit.UI.ExternalCommandData.View`

Member kind: property
Symbol: `Autodesk.Revit.UI.ExternalCommandData.View`

#### Summary

Retrieves an object that represents the View external command work on.

### `P:Autodesk.Revit.UI.ExternalCommandData.Application`

Member kind: property
Symbol: `Autodesk.Revit.UI.ExternalCommandData.Application`

#### Summary

Retrieves an object that represents the current Application for
external command.

### `T:Autodesk.Revit.UI.ExternalCommandData`

Member kind: type
Symbol: `Autodesk.Revit.UI.ExternalCommandData`

#### Summary

A class contains reference to Application and View which are needed by external command.

### `M:Autodesk.Revit.UI.Selection.Selection.SetReferences(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.SetReferences(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

#### Summary

Selects the references. The references can be an element or a subelement in the host or a linked document.

#### Remarks

This function will select the specified references and update the UI.

#### Parameter `references`

The references to be selected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Changing the selection is not permitted while handling SelectionChanged Event.

#### Since

2023

### `M:Autodesk.Revit.UI.Selection.Selection.GetReferences`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.GetReferences`

#### Summary

Returns the references that are currently selected.

#### Remarks

The references can be an element or subelement in the host or a linked document.

#### Returns

The collection containing the selected references.

#### Since

2023

### `M:Autodesk.Revit.UI.Selection.Selection.GetElementIds`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.GetElementIds`

#### Summary

Returns the ids of the elements that are currently selected within the project.
The selection may not be complete. See `M:Autodesk.Revit.UI.Selection.Selection.GetReferences` for more options.

#### Returns

The collection containing the ids of the selected elements.

### `M:Autodesk.Revit.UI.Selection.Selection.SetElementIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.SetElementIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Selects the elements.

#### Remarks

This function will select the specified elements within the project and update the UI.
See `M:Autodesk.Revit.UI.Selection.Selection.SetReferences(System.Collections.Generic.IList`1{Autodesk.Revit.DB.Reference})` for more selection options.

#### Parameter `elementIds`

The ids of the elements to be selected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Changing the selection is not permitted while handling SelectionChanged Event.

#### Since

2015

### `P:Autodesk.Revit.UI.Selection.Selection.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.Selection.Selection.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.UI.Selection.Selection.PickElementsByRectangle(Autodesk.Revit.UI.Selection.ISelectionFilter,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickElementsByRectangle(Autodesk.Revit.UI.Selection.ISelectionFilter,System.String)`

#### Summary

Prompts the user to select multiple elements by drawing a rectangle which pass a customer filter while showing a custom status prompt string.

#### Parameter `selectionFilter`

The selection filter.

#### Parameter `statusPrompt`

The message shown on the status bar.

#### Remarks

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

The selection will not be automatically added to the active selection buffer.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the selectionFilter is `null` or statusPrompt is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

A collection of elements selected by the user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickElementsByRectangle(Autodesk.Revit.UI.Selection.ISelectionFilter)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickElementsByRectangle(Autodesk.Revit.UI.Selection.ISelectionFilter)`

#### Summary

Prompts the user to select multiple elements by drawing a rectangle which pass a customer filter.

#### Parameter `selectionFilter`

The selection filter.

#### Remarks

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

The selection will not be automatically added to the active selection buffer.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the selectionFilter is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

A collection of elements selected by the user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickElementsByRectangle(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickElementsByRectangle(System.String)`

#### Summary

Prompts the user to select multiple elements by drawing a rectangle while showing a custom status prompt string.

#### Parameter `statusPrompt`

The message shown on the status bar.

#### Remarks

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

The selection will not be automatically added to the active selection buffer.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the statusPrompt is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

A collection of elements selected by the user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickElementsByRectangle`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickElementsByRectangle`

#### Overloads

Prompts the user to select multiple elements by drawing a rectangle.

#### Summary

Prompts the user to select multiple elements by drawing a rectangle.

#### Remarks

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

The selection will not be automatically added to the active selection buffer.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

A collection of elements selected by the user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickBox(Autodesk.Revit.UI.Selection.PickBoxStyle,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickBox(Autodesk.Revit.UI.Selection.PickBoxStyle,System.String)`

#### Summary

Invokes a general purpose two-click editor that lets the user to specify a rectangular area on the screen.

#### Parameter `style`

Specifies the value that controls the style of the pick box.

#### Parameter `statusPrompt`

The message shown on the status bar.

#### Remarks

The method starts an editor and returns when it finishes. Returns a PickedBox that contains two XYZ points.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the style is not a recognized value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the argument statusPrompt is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Returns

The picked box that contains two XYZ points.

### `M:Autodesk.Revit.UI.Selection.Selection.PickBox(Autodesk.Revit.UI.Selection.PickBoxStyle)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickBox(Autodesk.Revit.UI.Selection.PickBoxStyle)`

#### Summary

Invokes a general purpose two-click editor that lets the user to specify a rectangular area on the screen.

#### Parameter `style`

Specifies the value that controls the style of the pick box.

#### Remarks

The method starts an editor and returns when it finishes. Returns a PickedBox that contains two XYZ points.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the style is not a recognized value.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Returns

The picked box that contains two XYZ points.

### `M:Autodesk.Revit.UI.Selection.Selection.PickPoint(Autodesk.Revit.UI.Selection.ObjectSnapTypes,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickPoint(Autodesk.Revit.UI.Selection.ObjectSnapTypes,System.String)`

#### Summary

Prompts the user to pick a point on the active work plane using specified snap settings while showing a custom status prompt string.

#### Parameter `snapSettings`

Specifies the object snap types for this pick. Multiple object snap types can be combined with "|"

#### Parameter `statusPrompt`

Specifies the message shown on the status bar.

#### Remarks

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the argument statusPrompt is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when no work plane set in current view.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

The point picked by user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickPoint(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickPoint(System.String)`

#### Summary

Prompts the user to pick a point on the active work plane while showing a custom status prompt string.

#### Parameter `statusPrompt`

Specifies the message shown on the status bar.

#### Remarks

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the argument statusPrompt is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when no work plane set in current view.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

The point picked by user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickPoint(Autodesk.Revit.UI.Selection.ObjectSnapTypes)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickPoint(Autodesk.Revit.UI.Selection.ObjectSnapTypes)`

#### Summary

Prompts the user to pick a point on the active work plane using specified snap settings.

#### Parameter `snapSettings`

Specifies the object snap types for this pick. Multiple object snap types can be combined with "|"

#### Remarks

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when no work plane set in current view.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

The point picked by user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickPoint`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickPoint`

#### Overloads

Prompts the user to pick a point on the active work plane.

#### Summary

Prompts the user to pick a point on the active work plane.

#### Remarks

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when no work plane set in current view.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

The point picked by user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickObjects(Autodesk.Revit.UI.Selection.ObjectType,Autodesk.Revit.UI.Selection.ISelectionFilter,System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickObjects(Autodesk.Revit.UI.Selection.ObjectType,Autodesk.Revit.UI.Selection.ISelectionFilter,System.String,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

#### Summary

Prompts the user to select multiple objects which pass a custom filter while showing a custom status prompt string. A preselected set of objects may be supplied and will be selected at the start of the selection.

#### Parameter `objectType`

Specifies the type of object to be selected.

#### Parameter `selectionFilter`

The selection filter.

#### Parameter `statusPrompt`

The message shown on the status bar.

#### Parameter `pPreSelected`

The previously selected set of objects.

#### Remarks

The user will be shown "Finish" and "Cancel" buttons on the dialog bar to complete the selection operation.
Uncheck the "Multiple" check-box to select single object and it will return the selected object directly.

The previously selected set of objects will be highlighted.

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

The selection will not be automatically added to the active selection buffer.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the objectType is not a recognized value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the selectionFilter is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the Revit user cancelled this operation.
Thrown when pPreSelected references has objects that are not the type of objectType.
Thrown when objectType is PointOnElement which is not supported for selection involving preselected items.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

A collection of references selected by the user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickObjects(Autodesk.Revit.UI.Selection.ObjectType,Autodesk.Revit.UI.Selection.ISelectionFilter,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickObjects(Autodesk.Revit.UI.Selection.ObjectType,Autodesk.Revit.UI.Selection.ISelectionFilter,System.String)`

#### Summary

Prompts the user to select multiple objects which pass a custom filter while showing a custom status prompt string.

#### Parameter `objectType`

Specifies the type of object to be selected.

#### Parameter `selectionFilter`

The selection filter.

#### Parameter `statusPrompt`

The message shown on the status bar.

#### Remarks

The user will be shown "Finish" and "Cancel" buttons on the dialog bar to complete the selection operation.
Uncheck the "Multiple" check-box to select single object and it will return the selected object directly.

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

The selection will not be automatically added to the active selection buffer.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the objectType is not a recognized value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the selectionFilter is `null` or statusPrompt is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

A collection of references selected by the user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickObjects(Autodesk.Revit.UI.Selection.ObjectType,Autodesk.Revit.UI.Selection.ISelectionFilter)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickObjects(Autodesk.Revit.UI.Selection.ObjectType,Autodesk.Revit.UI.Selection.ISelectionFilter)`

#### Summary

Prompts the user to select multiple objects which pass a customer filter.

#### Parameter `objectType`

Specifies the type of object to be selected.

#### Parameter `selectionFilter`

The selection filter.

#### Remarks

The user will be shown "Finish" and "Cancel" buttons on the dialog bar to complete the selection operation.
Uncheck the "Multiple" check-box to select single object and it will return the selected object directly.

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

The selection will not be automatically added to the active selection buffer.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the objectType is not a recognized value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the selectionFilter is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

A collection of references selected by the user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickObjects(Autodesk.Revit.UI.Selection.ObjectType,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickObjects(Autodesk.Revit.UI.Selection.ObjectType,System.String)`

#### Summary

Prompts the user to select multiple objects while showing a custom status prompt string.

#### Parameter `objectType`

Specifies the type of object to be selected.

#### Parameter `statusPrompt`

The message shown on the status bar.

#### Remarks

>
The user will be shown "Finish" and "Cancel" buttons on the dialog bar to complete the selection operation.
Uncheck the "Multiple" check-box to select single object and it will return the selected object directly.

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

The selection will not be automatically added to the active selection buffer.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the objectType is not a recognized value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the statusPrompt is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

A collection of references selected by the user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickObjects(Autodesk.Revit.UI.Selection.ObjectType)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickObjects(Autodesk.Revit.UI.Selection.ObjectType)`

#### Overloads

Prompts the user to select multiple objects.

#### Summary

Prompts the user to select multiple objects.

#### Parameter `objectType`

Specifies the type of object to be selected.

#### Remarks

The user will be shown "Finish" and "Cancel" buttons on the dialog bar to complete the selection operation.
Uncheck the "Multiple" check-box to select single object and it will return the selected object directly.

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

The selection will not be automatically added to the active selection buffer.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the objectType is not a recognized value.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

A collection of references selected by the user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType,Autodesk.Revit.UI.Selection.ISelectionFilter,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType,Autodesk.Revit.UI.Selection.ISelectionFilter,System.String)`

#### Summary

Prompts the user to select one object which passes a custom filter while showing a custom status prompt string.

#### Parameter `objectType`

Specifies the type of object to be selected.

#### Parameter `selectionFilter`

The selection filter.

#### Parameter `statusPrompt`

The message shown on the status bar.

#### Remarks

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

The selection will not be automatically added to the active selection buffer.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the objectType is not a recognized value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the selectionFilter is `null` or statusPrompt is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

A reference object selected by user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType,Autodesk.Revit.UI.Selection.ISelectionFilter)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType,Autodesk.Revit.UI.Selection.ISelectionFilter)`

#### Summary

Prompts the user to select one object which passes a custom filter.

#### Parameter `objectType`

Specifies the type of object to be selected.

#### Parameter `selectionFilter`

The selection filter.

#### Remarks

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

The selection will not be automatically added to the active selection buffer.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the objectType is not a recognized value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the selectionFilter is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

A reference object selected by user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType,System.String)`

#### Summary

Prompts the user to select one object while showing a custom status prompt string.

#### Parameter `objectType`

Specifies the type of object to be selected.

#### Parameter `statusPrompt`

The message shown on the status bar.

#### Remarks

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

The selection will not be automatically added to the active selection buffer.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the objectType is not a recognized value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the statusPrompt is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancelled this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

A reference object selected by user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `M:Autodesk.Revit.UI.Selection.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType)`

#### Overloads

Prompts the user to select one object.

#### Summary

Prompts the user to select one object.

#### Parameter `objectType`

Specifies the type of object to be selected.

#### Remarks

Revit users will be permitted to manipulate the Revit view (zooming, panning, and rotating the view),
but will not be permitted to click other items in the Revit user interface.
Users are not permitted to switch the active view, close the active document or Revit application in the pick session, otherwise an exception will be thrown.

The selection will not be automatically added to the active selection buffer.

Note: this method must not be called during dynamic update, otherwise ForbiddenForDynamicUpdateException will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the objectType is not a recognized value.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Thrown when the Revit user cancels this operation.
Thrown when the Revit user tried to switch the active view, close the active document or Revit application when responding to this mode.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

#### Returns

A reference object selected by user.

Note: if the user cancels the operation (for example, through ESC), the method will throw an OperationCanceledException instance.

### `T:Autodesk.Revit.UI.Selection.Selection`

Member kind: type
Symbol: `Autodesk.Revit.UI.Selection.Selection`

#### Summary

Contains the current user selection of elements within the project.

#### Remarks

The Selection object is used to retrieve the current user selected elements when an external API command is executed.

### `P:Autodesk.Revit.UI.Selection.PickedBox.Max`

Member kind: property
Symbol: `Autodesk.Revit.UI.Selection.PickedBox.Max`

#### Summary

Maximum coordinates (upper-right-front corner of the pick box).

### `P:Autodesk.Revit.UI.Selection.PickedBox.Min`

Member kind: property
Symbol: `Autodesk.Revit.UI.Selection.PickedBox.Min`

#### Summary

Minimum coordinates (lower-left-rear corner of the pick box).

### `T:Autodesk.Revit.UI.Selection.PickedBox`

Member kind: type
Symbol: `Autodesk.Revit.UI.Selection.PickedBox`

#### Summary

A class that contains two XYZ points representing the pick box on the screen.

### `T:Autodesk.Revit.UI.Selection.PickBoxStyle`

Member kind: type
Symbol: `Autodesk.Revit.UI.Selection.PickBoxStyle`

#### Summary

The enum that controls the style of the pick box.

### `F:Autodesk.Revit.UI.Selection.PickBoxStyle.Directional`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.PickBoxStyle.Directional`

#### Summary

The style of the box depends on the direction in which the box is being drawn. It uses the Crossing style if it is being drawn from right to left, or the Enclosing style when drawn in the opposite direction.

### `F:Autodesk.Revit.UI.Selection.PickBoxStyle.Enclosing`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.PickBoxStyle.Enclosing`

#### Summary

Draws the box with the style that is used when selecting objects that are completely enclosed by the box.

### `F:Autodesk.Revit.UI.Selection.PickBoxStyle.Crossing`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.PickBoxStyle.Crossing`

#### Summary

Draws the box with the style that is used when selecting objects completely or partially inside the box.

### `T:Autodesk.Revit.UI.Selection.ObjectSnapTypes`

Member kind: type
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes`

#### Summary

This enumerated type contains object snap types allowed to be set during PickPoint operations.

### `F:Autodesk.Revit.UI.Selection.ObjectSnapTypes.CoordinationModelPoints`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes.CoordinationModelPoints`

#### Summary

Snaps to Coordination Model points.

### `F:Autodesk.Revit.UI.Selection.ObjectSnapTypes.Remote`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes.Remote`

#### Summary

Remote snaps to objects.

#### Remarks

Remote snaps are needed when the snap is away from the object.
This setting has no effect on its own and needs to be used in combination with other settings.
In combination with Nearest, snaps are enabled to extensions of objects on the screen.
In combination with Center, snaps are enabled when hovering in the center of circles.

### `F:Autodesk.Revit.UI.Selection.ObjectSnapTypes.Points`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes.Points`

#### Summary

Snaps to site points.

### `F:Autodesk.Revit.UI.Selection.ObjectSnapTypes.Quadrants`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes.Quadrants`

#### Summary

Snaps to quadrant points. For arcs, jump snaps are enabled.

### `F:Autodesk.Revit.UI.Selection.ObjectSnapTypes.Tangents`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes.Tangents`

#### Summary

Snaps tangent to an arc.

### `F:Autodesk.Revit.UI.Selection.ObjectSnapTypes.Perpendicular`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes.Perpendicular`

#### Summary

Snaps to perpendicular elements or components.

### `F:Autodesk.Revit.UI.Selection.ObjectSnapTypes.Centers`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes.Centers`

#### Summary

Snaps to the center of an arc.

### `F:Autodesk.Revit.UI.Selection.ObjectSnapTypes.Intersections`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes.Intersections`

#### Summary

Snaps to intersections.

### `F:Autodesk.Revit.UI.Selection.ObjectSnapTypes.WorkPlaneGrid`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes.WorkPlaneGrid`

#### Summary

Snaps to a work plane grid.

### `F:Autodesk.Revit.UI.Selection.ObjectSnapTypes.Nearest`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes.Nearest`

#### Summary

Snaps to the nearest element or component.

### `F:Autodesk.Revit.UI.Selection.ObjectSnapTypes.Midpoints`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes.Midpoints`

#### Summary

Snaps to the midpoint of an element or component.

### `F:Autodesk.Revit.UI.Selection.ObjectSnapTypes.Endpoints`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes.Endpoints`

#### Summary

Snaps to the endpoint of an element or component.

### `F:Autodesk.Revit.UI.Selection.ObjectSnapTypes.None`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectSnapTypes.None`

#### Summary

Snaps to nothing.

### `T:Autodesk.Revit.UI.Selection.ObjectType`

Member kind: type
Symbol: `Autodesk.Revit.UI.Selection.ObjectType`

#### Summary

This enumerated type contains object types allowed to be selected during selection operations.

### `F:Autodesk.Revit.UI.Selection.ObjectType.Subelement`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectType.Subelement`

#### Summary

Whole element or subelement.

### `F:Autodesk.Revit.UI.Selection.ObjectType.LinkedElement`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectType.LinkedElement`

#### Summary

Elements in linked RVT files.

### `F:Autodesk.Revit.UI.Selection.ObjectType.Face`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectType.Face`

#### Summary

Any face.

### `F:Autodesk.Revit.UI.Selection.ObjectType.Edge`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectType.Edge`

#### Summary

Any model edge.

### `F:Autodesk.Revit.UI.Selection.ObjectType.PointOnElement`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectType.PointOnElement`

#### Summary

Any point on an element (on a face or curve).

### `F:Autodesk.Revit.UI.Selection.ObjectType.Element`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectType.Element`

#### Summary

Whole element.

### `F:Autodesk.Revit.UI.Selection.ObjectType.Nothing`

Member kind: field
Symbol: `Autodesk.Revit.UI.Selection.ObjectType.Nothing`

#### Summary

Nothing.

### `M:Autodesk.Revit.UI.Selection.ISelectionFilter.AllowReference(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.ISelectionFilter.AllowReference(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

#### Summary

Override this post-filter method to specify if a reference to a piece of geometry is permitted to be selected.

#### Returns

Return true to allow the user to select this candidate reference. Return false to prevent selection of this candidate.

#### Parameter `reference`

A candidate reference in selection operation.

#### Parameter `position`

The 3D position of the mouse on the candidate reference.

#### Remarks

If an exception is thrown from this method, the element will not be permitted to be selected.

### `M:Autodesk.Revit.UI.Selection.ISelectionFilter.AllowElement(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Selection.ISelectionFilter.AllowElement(Autodesk.Revit.DB.Element)`

#### Summary

Override this pre-filter method to specify if the element should be permitted to be selected.

#### Returns

Return true to allow the user to select this candidate element. Return false to prevent selection of this element.

#### Parameter `elem`

A candidate element in selection operation.

#### Remarks

If prompting the user to select an element from a Revit Link instance, the element passed here will be the link instance, not the selected linked element.
Access the linked element from Reference passed to the AllowReference() callback of ISelectionFilter.

If an exception is thrown from this method, the element will not be permitted to be selected.

### `T:Autodesk.Revit.UI.Selection.ISelectionFilter`

Member kind: type
Symbol: `Autodesk.Revit.UI.Selection.ISelectionFilter`

#### Summary

An interface that provides the ability to filter objects during a selection operation.

### `M:ServerPath.#ctor`

Member kind: method
Symbol: `ServerPath.#ctor`

#### Summary

A path to a Revit model stored on a Revit server.

### `M:FilePath.#ctor`

Member kind: method
Symbol: `FilePath.#ctor`

#### Summary

A path to a Revit model stored on disk.

### `M:Autodesk.Revit.UI.IExternalEventHandler.Execute(Autodesk.Revit.UI.UIControlledApplication)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalEventHandler.Execute(Autodesk.Revit.UI.UIControlledApplication)`

#### Summary

This method is called to handle the external event.

#### Since

2013

### `M:Autodesk.Revit.UI.IExternalEventHandler.Execute(Autodesk.Revit.VSTA.ApplicationEntryPoint)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalEventHandler.Execute(Autodesk.Revit.VSTA.ApplicationEntryPoint)`

#### Summary

This method is called to handle the external event.

#### Since

2013

### `M:Autodesk.Revit.UI.IControllableDropHandler.CanExecute(Autodesk.Revit.VSTA.DocumentEntryPoint,System.Object,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IControllableDropHandler.CanExecute(Autodesk.Revit.VSTA.DocumentEntryPoint,System.Object,Autodesk.Revit.DB.ElementId)`

#### Summary

Implement this method to inform Revit whether the drop event can be executed onto the given view.

#### Remarks

Document modifications are not permitted from this callback.

#### Parameter `document`

The document on which the data was dropped.

#### Parameter `data`

The data.

#### Parameter `dropViewId`

The view upon which the user will drop.

#### Returns

Return true to activate the target view and execute the drop.
Return false to cancel the activation and the drop execution.

### `M:Autodesk.Revit.UI.IDropHandler.Execute(Autodesk.Revit.VSTA.DocumentEntryPoint,System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IDropHandler.Execute(Autodesk.Revit.VSTA.DocumentEntryPoint,System.Object)`

#### Summary

Implement this method to handle the drop event for your data.

#### Parameter `document`

The document on which the data was dropped.

#### Parameter `data`

The data.

#### Since

2013

### `M:Autodesk.Revit.UI.AddInCommandBinding.#ctor(Autodesk.Revit.UI.UIControlledApplication,Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.AddInCommandBinding.#ctor(Autodesk.Revit.UI.UIControlledApplication,Autodesk.Revit.UI.RevitCommandId)`

#### Summary

Constructs a new AddInCommandBinding.

#### Parameter `uiApplication`

The UI application.

#### Parameter `revitCommandId`

The Revit command id to identify the command handler you want to replace.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when uiApplication or revitCommandId
is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the given command already has been bound.

#### Since

2013

### `M:Autodesk.Revit.UI.AddInCommandBinding.#ctor(Autodesk.Revit.VSTA.ApplicationEntryPoint,Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.AddInCommandBinding.#ctor(Autodesk.Revit.VSTA.ApplicationEntryPoint,Autodesk.Revit.UI.RevitCommandId)`

#### Summary

Constructs a new AddInCommandBinding.

#### Parameter `uiApplication`

The UI application.

#### Parameter `revitCommandId`

The Revit command id to identify the command handler you want to replace.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when uiApplication or revitCommandId
is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the given command already has been bound.

#### Since

2013

### `M:Autodesk.Revit.UI.IExternalCommandAvailability.IsCommandAvailable(Autodesk.Revit.UI.UIControlledApplication,Autodesk.Revit.DB.CategorySet)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalCommandAvailability.IsCommandAvailable(Autodesk.Revit.UI.UIControlledApplication,Autodesk.Revit.DB.CategorySet)`

#### Summary

Implement this method to provide control over whether your external command is enabled or disabled.

#### Returns

Indicates whether Revit should enable or disable the corresponding external command.

#### Remarks

This callback will be called by Revit's user interface any time there is a contextual change. Therefore, the callback
must be fast and is not permitted to modify the active document and be blocking in any way.

#### Parameter `applicationData`

An ApplicationServices.Application object which contains reference to Application
needed by external command.

#### Parameter `selectedCategories`

An list of categories of the elements which have been selected in Revit in the active document,
or an empty set if no elements are selected or there is no active document.

### `M:Autodesk.Revit.UI.IExternalCommandAvailability.IsCommandAvailable(Autodesk.Revit.VSTA.ApplicationEntryPoint,Autodesk.Revit.DB.CategorySet)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalCommandAvailability.IsCommandAvailable(Autodesk.Revit.VSTA.ApplicationEntryPoint,Autodesk.Revit.DB.CategorySet)`

#### Summary

Implement this method to provide control over whether your external command is enabled or disabled.

#### Returns

Indicates whether Revit should enable or disable the corresponding external command.

#### Remarks

This callback will be called by Revit's user interface any time there is a contextual change. Therefore, the callback
must be fast and is not permitted to modify the active document and be blocking in any way.

#### Parameter `applicationData`

An ApplicationServices.Application object which contains reference to Application
needed by external command.

#### Parameter `selectedCategories`

An list of categories of the elements which have been selected in Revit in the active document,
or an empty set if no elements are selected or there is no active document.

### `E:Autodesk.Revit.UI.UIControlledApplication.ThemeChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.ThemeChanged`

#### Summary

Subscribe to the ThemeChanged event to be notified after the theme was changed.

#### Remarks

This event is raised after the theme was changed.

#### Since

2024

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.ThemeChanged`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.ThemeChanged`

#### Summary

Subscribe to the ThemeChanged event to be notified after the theme was changed.

#### Remarks

This event is raised after the theme was changed.

#### Since

2024

### `E:Autodesk.Revit.UI.UIControlledApplication.SelectionChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.SelectionChanged`

#### Summary

Subscribe to the SelectionChanged event to be notified after the selection was changed.

#### Remarks

This event is raised after the selection was changed in the current document.
Handlers of this event are forbidden to make modifications to the current document.
Handlers of this event are forbidden to change the selection to the current document.
It is not allowed to open a new transaction in the active document when handling this event.

#### Since

2023

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.SelectionChanged`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.SelectionChanged`

#### Summary

Subscribe to the SelectionChanged event to be notified after the selection was changed.

#### Remarks

This event is raised after the selection was changed in the current document.
Handlers of this event are forbidden to make modifications to the current document.
Handlers of this event are forbidden to change the selection to the current document.
It is not allowed to open a new transaction in the active document when handling this event.

#### Since

2023

### `E:Autodesk.Revit.UI.UIControlledApplication.TransferredProjectStandards`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.TransferredProjectStandards`

#### Summary

Subscribe to the TransferredProjectStandards event to be notified after the scope of a Transfer Project Standards operation has been finalized.

#### Remarks

This event is raised just after the native Revit items have been transferred, but before the transaction has been committed.
An add-in that registered external items in `E:Autodesk.Revit.UI.UIApplication.TransferringProjectStandards` should subscribe to this event to carry out the transfer of any items that it registered if the user enabled those items for transfer.
During the scope of this event, modification is permitted to the target document and modification is not permitted to the source document.

#### Since

2017.2

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.TransferredProjectStandards`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.TransferredProjectStandards`

#### Summary

Subscribe to the TransferredProjectStandards event to be notified after the scope of a Transfer Project Standards operation has been finalized.

#### Remarks

This event is raised just after the native Revit items have been transferred, but before the transaction has been committed.
An add-in that registered external items in `E:Autodesk.Revit.UI.UIApplication.TransferringProjectStandards` should subscribe to this event to carry out the transfer of any items that it registered if the user enabled those items for transfer.
During the scope of this event, modification is permitted to the target document and modification is not permitted to the source document.

#### Since

2017.2

### `E:Autodesk.Revit.UI.UIControlledApplication.TransferringProjectStandards`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.TransferringProjectStandards`

#### Summary

Subscribe to the TransferringProjectStandards event to be notified before the scope of an impending Transfer Project Standards operation has been finalized in the Transfer Project Standards dialog.

#### Remarks

This event allows an external application to add additional items to the possible list of items to be transferred.
These items will be visible and selectable in the Transfer Project Standards dialog box. By default, new items added in this manner will be enabled for transfer.
During the scope of this event, modification is not permitted to either the source or target documents. And this event is not cancellable.

#### Since

2017.2

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.TransferringProjectStandards`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.TransferringProjectStandards`

#### Summary

Subscribe to the TransferringProjectStandards event to be notified before the scope of an impending Transfer Project Standards operation has been finalized in the Transfer Project Standards dialog.

#### Remarks

This event allows an external application to add additional items to the possible list of items to be transferred.
These items will be visible and selectable in the Transfer Project Standards dialog box. By default, new items added in this manner will be enabled for transfer.
During the scope of this event, modification is not permitted to either the source or target documents. And this event is not cancellable.

#### Since

2017.2

### `E:Autodesk.Revit.UI.UIControlledApplication.FabricationPartBrowserChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.FabricationPartBrowserChanged`

#### Summary

Subscribe to MEP Fabrication part browser changed event to be notified when MEP Fabrication part browser is updated.

#### Remarks

More docs about the different conditions goes here

#### Since

2017

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.FabricationPartBrowserChanged`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.FabricationPartBrowserChanged`

#### Summary

Subscribe to MEP Fabrication part browser changed event to be notified when MEP Fabrication part browser is updated.

#### Remarks

More docs about the different conditions goes here

#### Since

2017

### `E:Autodesk.Revit.UI.UIControlledApplication.DockableFrameFocusChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.DockableFrameFocusChanged`

#### Summary

Subscribe to this event to be notified when a Revit GenericDockableFrame has gained focus or lost focus in the Revit user interface.
This event is called only for API-created GenericDockableFrames.

#### Remarks

This event is raised when the GenericDockableFrame is just about to be active or inactive.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

No document may be modified at the time of the event.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Export()All overloads of Autodesk.Revit.DB.Document.Import()Autodesk::Revit::DB::Document::Print`M:Autodesk.Revit.DB.View.Print` and similar overloads.`M:Autodesk.Revit.DB.PrintManager.SubmitPrint` and similar overloads.`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2015

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.DockableFrameFocusChanged`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.DockableFrameFocusChanged`

#### Summary

Subscribe to this event to be notified when a Revit GenericDockableFrame has gained focus or lost focus in the Revit user interface.
This event is called only for API-created GenericDockableFrames.

#### Remarks

This event is raised when the GenericDockableFrame is just about to be active or inactive.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

No document may be modified at the time of the event.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Export()All overloads of Autodesk.Revit.DB.Document.Import()Autodesk::Revit::DB::Document::Print`M:Autodesk.Revit.DB.View.Print` and similar overloads.`M:Autodesk.Revit.DB.PrintManager.SubmitPrint` and similar overloads.`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2015

### `E:Autodesk.Revit.UI.UIControlledApplication.DockableFrameVisibilityChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.DockableFrameVisibilityChanged`

#### Summary

Subscribe to this event to be notified when a Revit GenericDockableFrame has been shown or hidden in the Revit user interface.
This event is called only for API-created GenericDockableFrames.

#### Remarks

This event is raised when the GenericDockableFrame is just about to be shown or hidden.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

No document may be modified at the time of the event.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Export()All overloads of Autodesk.Revit.DB.Document.Import()Autodesk::Revit::DB::Document::Print`M:Autodesk.Revit.DB.View.Print` and similar overloads.`M:Autodesk.Revit.DB.PrintManager.SubmitPrint` and similar overloads.`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2015

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.DockableFrameVisibilityChanged`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.DockableFrameVisibilityChanged`

#### Summary

Subscribe to this event to be notified when a Revit GenericDockableFrame has been shown or hidden in the Revit user interface.
This event is called only for API-created GenericDockableFrames.

#### Remarks

This event is raised when the GenericDockableFrame is just about to be shown or hidden.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

No document may be modified at the time of the event.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Export()All overloads of Autodesk.Revit.DB.Document.Import()Autodesk::Revit::DB::Document::Print`M:Autodesk.Revit.DB.View.Print` and similar overloads.`M:Autodesk.Revit.DB.PrintManager.SubmitPrint` and similar overloads.`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2015

### `E:Autodesk.Revit.UI.UIControlledApplication.DisplayingOptionsDialog`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.DisplayingOptionsDialog`

#### Summary

Subscribe to the options dialog displaying event to be notified when Revit options dialog is displaying.

#### Since

2013

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.DisplayingOptionsDialog`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.DisplayingOptionsDialog`

#### Summary

Subscribe to the options dialog displaying event to be notified when Revit options dialog is displaying.

#### Since

2013

### `E:Autodesk.Revit.UI.UIControlledApplication.ApplicationClosing`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.ApplicationClosing`

#### Summary

Subscribe to the ApplicationClosing event to be notified when the Revit application is just about to be closed.

#### Remarks

This event is raised when the Revit application is just about to be closed.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

No document may be modified at the time of the event.

The sender object of this event is `T:Autodesk.Revit.UI.UIControlledApplication` object.

#### Since

2010

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.ApplicationClosing`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.ApplicationClosing`

#### Summary

Subscribe to the ApplicationClosing event to be notified when the Revit application is just about to be closed.

#### Remarks

This event is raised when the Revit application is just about to be closed.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

No document may be modified at the time of the event.

The sender object of this event is `T:Autodesk.Revit.UI.UIControlledApplication` object.

#### Since

2010

### `E:Autodesk.Revit.UI.UIControlledApplication.Idling`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.Idling`

#### Summary

Subscribe to the Idling event to be notified when Revit is not in an active tool or transaction.

#### Remarks

This event is raised when it is safe for the API application to access the active
document between user interactions. The event is raised only when the Revit UI is
in a state where the user could successfully click on an API command button.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

In order to change a document, you must begin a new transaction for that document.
This transaction will appear in the Revit undo stack and may be undone by the Revit user.

This event is invoked between user actions in the Revit UI. If the handler for
this event requires a significant amount of processing time, users will perceive a slowdown
in the responsiveness of Revit. If the execution for updates can be safely split across
multiple calls to this event, the user perception of Revit responsiveness will be improved.

There are two ways to use this event. In the default mode, a single raise of the event
will be made each time Revit begins an idle session. Note that when the user is active in the Revit
user interface, idle sessions begin whenever the mouse stops moving for a moment or when a
command completes. However, if the user is not active in the user interface at all, Revit may not invoke
additional idling sessions for quite some time; this means that your application may not be able to take advantage
of time when the user leaves the machine completely for a period of time.

In the non-default mode, your application forces Revit to keep the idling session open and to make
repeated calls to your event subscriber. In this mode even if the user is totally inactive the Revit
session will continue to make Idling calls to your application. However, this can result in performance
degradation for the system on which Revit is running because the CPU remains fully engaged in serving Idling
events during the Revit application's downtime.

You can indicate the preference for the non-default Idling frequency by calling
`M:Autodesk.Revit.UI.Events.IdlingEventArgs.SetRaiseWithoutDelay`
each time the Idling event callback is made. Revit will revert to the default Idling frequency
if this method is not called every time in your callback.

Event is not cancellable.

#### Since

2010

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.Idling`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.Idling`

#### Summary

Subscribe to the Idling event to be notified when Revit is not in an active tool or transaction.

#### Remarks

This event is raised when it is safe for the API application to access the active
document between user interactions. The event is raised only when the Revit UI is
in a state where the user could successfully click on an API command button.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

In order to change a document, you must begin a new transaction for that document.
This transaction will appear in the Revit undo stack and may be undone by the Revit user.

This event is invoked between user actions in the Revit UI. If the handler for
this event requires a significant amount of processing time, users will perceive a slowdown
in the responsiveness of Revit. If the execution for updates can be safely split across
multiple calls to this event, the user perception of Revit responsiveness will be improved.

There are two ways to use this event. In the default mode, a single raise of the event
will be made each time Revit begins an idle session. Note that when the user is active in the Revit
user interface, idle sessions begin whenever the mouse stops moving for a moment or when a
command completes. However, if the user is not active in the user interface at all, Revit may not invoke
additional idling sessions for quite some time; this means that your application may not be able to take advantage
of time when the user leaves the machine completely for a period of time.

In the non-default mode, your application forces Revit to keep the idling session open and to make
repeated calls to your event subscriber. In this mode even if the user is totally inactive the Revit
session will continue to make Idling calls to your application. However, this can result in performance
degradation for the system on which Revit is running because the CPU remains fully engaged in serving Idling
events during the Revit application's downtime.

You can indicate the preference for the non-default Idling frequency by calling
`M:Autodesk.Revit.UI.Events.IdlingEventArgs.SetRaiseWithoutDelay`
each time the Idling event callback is made. Revit will revert to the default Idling frequency
if this method is not called every time in your callback.

Event is not cancellable.

#### Since

2010

### `E:Autodesk.Revit.UI.UIControlledApplication.FormulaEditing`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.FormulaEditing`

#### Summary

Subscribe to the FormulaEditing event to be notified when the edit formula button has been clicked.

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.FormulaEditing`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.FormulaEditing`

#### Summary

Subscribe to the FormulaEditing event to be notified when the edit formula button has been clicked.

### `E:Autodesk.Revit.UI.UIControlledApplication.DialogBoxShowing`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.DialogBoxShowing`

#### Summary

Subscribe to the DialogBoxShowing event to be notified when Revit is just about to show a dialog box or a message box.

#### Remarks

This event is raised when Revit is just about to show a dialog box or a message box.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

Depending on the type of the dialog that is being shown, the event's argument's type varies as follows:
When it is a dialog box, the event's argument is an object of `T:Autodesk.Revit.UI.Events.DialogBoxShowingEventArgs` .
When it is a message box, the event's argument is an object of `T:Autodesk.Revit.UI.Events.MessageBoxShowingEventArgs` ,which is subclass of DialogBoxShowingEventArgs.
When it is a task dialog, the event's argument is an object of `T:Autodesk.Revit.UI.Events.TaskDialogShowingEventArgs` ,which is subclass of DialogBoxShowingEventArgs.

No document may be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.DialogBoxShowing`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.DialogBoxShowing`

#### Summary

Subscribe to the DialogBoxShowing event to be notified when Revit is just about to show a dialog box or a message box.

#### Remarks

This event is raised when Revit is just about to show a dialog box or a message box.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

Depending on the type of the dialog that is being shown, the event's argument's type varies as follows:
When it is a dialog box, the event's argument is an object of `T:Autodesk.Revit.UI.Events.DialogBoxShowingEventArgs` .
When it is a message box, the event's argument is an object of `T:Autodesk.Revit.UI.Events.MessageBoxShowingEventArgs` ,which is subclass of DialogBoxShowingEventArgs.
When it is a task dialog, the event's argument is an object of `T:Autodesk.Revit.UI.Events.TaskDialogShowingEventArgs` ,which is subclass of DialogBoxShowingEventArgs.

No document may be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.UI.UIControlledApplication.ViewActivated`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.ViewActivated`

#### Summary

Subscribe to the ViewActivated event to be notified immediately after Revit has finished activating a view of a document.

#### Remarks

This event is raised immediately after Revit has finished activating a view of the document.
It is raised even when view activating failed or was cancelled (during ViewActivating event).

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of view activating has already been finished.

The document may be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.ViewActivated`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.ViewActivated`

#### Summary

Subscribe to the ViewActivated event to be notified immediately after Revit has finished activating a view of a document.

#### Remarks

This event is raised immediately after Revit has finished activating a view of the document.
It is raised even when view activating failed or was cancelled (during ViewActivating event).

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of view activating has already been finished.

The document may be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.UI.UIControlledApplication.ViewActivating`

Member kind: event
Symbol: `Autodesk.Revit.UI.UIControlledApplication.ViewActivating`

#### Summary

Subscribe to the ViewActivating event to be notified when Revit is just about to activate a view of a document.

#### Remarks

This event is raised when Revit is just about to activate a view of the document.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The document may be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above
methods is called during this event.

Another `E:Autodesk.Revit.UI.UIApplication.ViewActivated` event will be raised immediately after view
activating is finished.

#### Since

2010

### `E:Autodesk.Revit.VSTA.ApplicationEntryPoint.ViewActivating`

Member kind: event
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.ViewActivating`

#### Summary

Subscribe to the ViewActivating event to be notified when Revit is just about to activate a view of a document.

#### Remarks

This event is raised when Revit is just about to activate a view of the document.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The document may be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` and similar overloads.`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above
methods is called during this event.

Another `E:Autodesk.Revit.UI.UIApplication.ViewActivated` event will be raised immediately after view
activating is finished.

#### Since

2010

### `M:Autodesk.Revit.UI.UIControlledApplication.UpdateWorksharingActivityIndicator(System.Boolean,System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.UpdateWorksharingActivityIndicator(System.Boolean,System.Collections.Generic.IList{System.String})`

#### Summary

Updates model status on the Worksharing activity indicator.

#### Remarks

The indicator is enabled only when the active document is cloud Worksharing.

#### Parameter `centralIsBusy`

True if the central model is busy.

#### Parameter `syncingUsernames`

An array with the usernames of the users which are currently syncing

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020.1

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.UpdateWorksharingActivityIndicator(System.Boolean,System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.UpdateWorksharingActivityIndicator(System.Boolean,System.Collections.Generic.IList{System.String})`

#### Summary

Updates model status on the Worksharing activity indicator.

#### Remarks

The indicator is enabled only when the active document is cloud Worksharing.

#### Parameter `centralIsBusy`

True if the central model is busy.

#### Parameter `syncingUsernames`

An array with the usernames of the users which are currently syncing

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020.1

### `M:Autodesk.Revit.UI.UIControlledApplication.UpdateWorksharingActivityIndicator(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.UpdateWorksharingActivityIndicator(System.Boolean)`

#### Summary

Updates model status on the Worksharing activity indicator.

#### Remarks

The indicator is enabled only when the active document is cloud Worksharing.

#### Parameter `centralIsBusy`

True if the central model is busy.

#### Since

2019.1

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.UpdateWorksharingActivityIndicator(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.UpdateWorksharingActivityIndicator(System.Boolean)`

#### Summary

Updates model status on the Worksharing activity indicator.

#### Remarks

The indicator is enabled only when the active document is cloud Worksharing.

#### Parameter `centralIsBusy`

True if the central model is busy.

#### Since

2019.1

### `M:Autodesk.Revit.UI.UIControlledApplication.OpenAndActivateDocumentOperationInternal(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.IOpenFromCloudCallback)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.OpenAndActivateDocumentOperationInternal(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.IOpenFromCloudCallback)`

#### Summary

Opens and activates a Revit document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.OpenAndActivateDocumentOperationInternal(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.IOpenFromCloudCallback)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.OpenAndActivateDocumentOperationInternal(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.IOpenFromCloudCallback)`

#### Summary

Opens and activates a Revit document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.UI.UIControlledApplication.OpenAndActivateDocument(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,System.Boolean,Autodesk.Revit.DB.IOpenFromCloudCallback)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.OpenAndActivateDocument(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,System.Boolean,Autodesk.Revit.DB.IOpenFromCloudCallback)`

#### Summary

Opens and activates a Revit document, include both local document or cloud document.

#### Remarks

This method, if successful, changes the active document.
It is not allowed to have an open transaction in the active document when calling this method.
Consequently, this method can only be used in manual transaction mode, not in automatic mode.
Additionally, this method may not be called from inside an event handler.

#### Parameter `modelPath`

A path to a Revit file to be opened.
The file can be either a Revit project, template, or family document.

#### Parameter `openOptions`

Options for opening the file.

#### Parameter `detachAndPrompt`

True means if openOptions specifies DoNotDetach,
then for workshared models detach from central and query the user whether to preserve or discard worksets.
make no sense when opening a cloud document.

#### Parameter `openFromCloudCallback`

Callback function that allow caller to handle cases when conflicts happen during opening a cloud document.
Make no sense when opening a non-cloud document.

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If DetachFromCentralOption is not DoNotDetach when opening a cloud document.
If the active document is currently modifiable.If an API event handler is currently being executed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

If `null` is passed as 'modelPath'.
-or-
If `null` is passed as 'openOptions'.
-or-
A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException`

Cannot open the local model and the central model in the same Revit session. You can close one to open the other in the same Revit session.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Thrown when file is not found at the give path.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Revit encountered serious errors while trying to open the central model.
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.CorruptModelException`

There are too many corrupt elements to open this model.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

When file cannot be opened in Revit LT because it was last saved in a version of Revit prior to 8.1.
when file has an invalid extension. Try changing the file's extension and opening it again.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file specified by 'modelPath' cannot be found or the given 'modelPath' is not a Revit file (a project, template, or family document).

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to open the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The cloud model is not saved in current release of Revit.
-or-
The model is not allowed to access.
-or-
The document can not be opened.Open is temporarily disabled.Revit cannot save the transmitted model as a new central because it is already opened.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Opening was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

If there is any server internal error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id when trying to open a cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.WrongUserException`

The local file is not owned by the current user, who therefore is not allowed to modify it.

#### Since

2019

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.OpenAndActivateDocument(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,System.Boolean,Autodesk.Revit.DB.IOpenFromCloudCallback)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.OpenAndActivateDocument(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,System.Boolean,Autodesk.Revit.DB.IOpenFromCloudCallback)`

#### Summary

Opens and activates a Revit document, include both local document or cloud document.

#### Remarks

This method, if successful, changes the active document.
It is not allowed to have an open transaction in the active document when calling this method.
Consequently, this method can only be used in manual transaction mode, not in automatic mode.
Additionally, this method may not be called from inside an event handler.

#### Parameter `modelPath`

A path to a Revit file to be opened.
The file can be either a Revit project, template, or family document.

#### Parameter `openOptions`

Options for opening the file.

#### Parameter `detachAndPrompt`

True means if openOptions specifies DoNotDetach,
then for workshared models detach from central and query the user whether to preserve or discard worksets.
make no sense when opening a cloud document.

#### Parameter `openFromCloudCallback`

Callback function that allow caller to handle cases when conflicts happen during opening a cloud document.
Make no sense when opening a non-cloud document.

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If DetachFromCentralOption is not DoNotDetach when opening a cloud document.
If the active document is currently modifiable.If an API event handler is currently being executed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

If `null` is passed as 'modelPath'.
-or-
If `null` is passed as 'openOptions'.
-or-
A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException`

Cannot open the local model and the central model in the same Revit session. You can close one to open the other in the same Revit session.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Thrown when file is not found at the give path.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Revit encountered serious errors while trying to open the central model.
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.CorruptModelException`

There are too many corrupt elements to open this model.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

When file cannot be opened in Revit LT because it was last saved in a version of Revit prior to 8.1.
when file has an invalid extension. Try changing the file's extension and opening it again.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file specified by 'modelPath' cannot be found or the given 'modelPath' is not a Revit file (a project, template, or family document).

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to open the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The cloud model is not saved in current release of Revit.
-or-
The model is not allowed to access.
-or-
The document can not be opened.Open is temporarily disabled.Revit cannot save the transmitted model as a new central because it is already opened.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Opening was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

If there is any server internal error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id when trying to open a cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.WrongUserException`

The local file is not owned by the current user, who therefore is not allowed to modify it.

#### Since

2019

### `M:Autodesk.Revit.UI.UIControlledApplication.OpenAndActivateDocument(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.OpenAndActivateDocument(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,System.Boolean)`

#### Summary

Opens and activates a Revit document, include both local document or cloud document.

#### Remarks

This method, if successful, changes the active document.
The model will override the local change with the latest change if it is a cloud model and it was restored, or relinquished, or out of date.
It is not allowed to have an open transaction in the active document when calling this method.
Consequently, this method can only be used in manual transaction mode, not in automatic mode.
Additionally, this method may not be called from inside an event handler.

#### Parameter `modelPath`

A path to a Revit file to be opened.
The file can be either a Revit project, template, or family document.

#### Parameter `openOptions`

Options for opening the file.

#### Parameter `detachAndPrompt`

True means if openOptions specifies DoNotDetach,
then for workshared models detach from central and query the user whether to preserve or discard worksets.
make no sense when opening a cloud document.

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If DetachFromCentralOption is not DoNotDetach when opening a cloud document.
If the active document is currently modifiable.If an API event handler is currently being executed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

If `null` is passed as 'modelPath'.
-or-
If `null` is passed as 'openOptions'.
-or-
A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException`

Cannot open the local model and the central model in the same Revit session. You can close one to open the other in the same Revit session.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Thrown when file is not found at the give path.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Revit encountered serious errors while trying to open the central model.
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.CorruptModelException`

There are too many corrupt elements to open this model.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

When file cannot be opened in Revit LT because it was last saved in a version of Revit prior to 8.1.
when file has an invalid extension. Try changing the file's extension and opening it again.
when file was saved by an application that was not developed or licensed by Autodesk.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file specified by 'modelPath' cannot be found or the given 'modelPath' is not a Revit file (a project, template, or family document).

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to open the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The cloud model is not saved in current release of Revit.
-or-
The model is not allowed to access.
-or-
The document can not be opened.Open is temporarily disabled.Revit cannot save the transmitted model as a new central because it is already opened.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Opening was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

If there is any server internal error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id when trying to open a cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.WrongUserException`

The local file is not owned by the current user, who therefore is not allowed to modify it.

#### Since

2013

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.OpenAndActivateDocument(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.OpenAndActivateDocument(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,System.Boolean)`

#### Summary

Opens and activates a Revit document, include both local document or cloud document.

#### Remarks

This method, if successful, changes the active document.
The model will override the local change with the latest change if it is a cloud model and it was restored, or relinquished, or out of date.
It is not allowed to have an open transaction in the active document when calling this method.
Consequently, this method can only be used in manual transaction mode, not in automatic mode.
Additionally, this method may not be called from inside an event handler.

#### Parameter `modelPath`

A path to a Revit file to be opened.
The file can be either a Revit project, template, or family document.

#### Parameter `openOptions`

Options for opening the file.

#### Parameter `detachAndPrompt`

True means if openOptions specifies DoNotDetach,
then for workshared models detach from central and query the user whether to preserve or discard worksets.
make no sense when opening a cloud document.

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

If DetachFromCentralOption is not DoNotDetach when opening a cloud document.
If the active document is currently modifiable.If an API event handler is currently being executed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

If `null` is passed as 'modelPath'.
-or-
If `null` is passed as 'openOptions'.
-or-
A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException`

Cannot open the local model and the central model in the same Revit session. You can close one to open the other in the same Revit session.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Thrown when file is not found at the give path.

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

Revit encountered serious errors while trying to open the central model.
An internal error happened on the central model, please contact the server administrator.

#### Exception `T:Autodesk.Revit.Exceptions.CorruptModelException`

There are too many corrupt elements to open this model.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

When file cannot be opened in Revit LT because it was last saved in a version of Revit prior to 8.1.
when file has an invalid extension. Try changing the file's extension and opening it again.
when file was saved by an application that was not developed or licensed by Autodesk.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file specified by 'modelPath' cannot be found or the given 'modelPath' is not a Revit file (a project, template, or family document).

#### Exception `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

This computer does not have enough memory, disk space, or other necessary resource to open the model.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The cloud model is not saved in current release of Revit.
-or-
The model is not allowed to access.
-or-
The document can not be opened.Open is temporarily disabled.Revit cannot save the transmitted model as a new central because it is already opened.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Opening was canceled by the user or by an API event callback.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

If there is any server internal error.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id when trying to open a cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.WrongUserException`

The local file is not owned by the current user, who therefore is not allowed to modify it.

#### Since

2013

### `M:Autodesk.Revit.UI.UIControlledApplication.OpenAndActivateDocument(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.OpenAndActivateDocument(System.String)`

#### Summary

Opens and activates a Revit document.

#### Remarks

This method, if successful, changes the active document.
It is not allowed to have an open transaction in the active document when calling this method.
Additionally, this method may not be called from inside an event handler.

#### Parameter `fileName`

A full path to a revit file to be opened.
The file can be either a Revit project, template, or family document.

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given 'fileName' is not a Revit file (a project, template, or family document).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

If `null` is passed as 'fileName'.
-or-
A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file specified by 'fileName' cannot be found.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If the active document is currently modifiable.
If an API event handler is currently being executed.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

If there is any server internal error.

#### Since

2012

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.OpenAndActivateDocument(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.OpenAndActivateDocument(System.String)`

#### Summary

Opens and activates a Revit document.

#### Remarks

This method, if successful, changes the active document.
It is not allowed to have an open transaction in the active document when calling this method.
Additionally, this method may not be called from inside an event handler.

#### Parameter `fileName`

A full path to a revit file to be opened.
The file can be either a Revit project, template, or family document.

#### Returns

The opened document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given 'fileName' is not a Revit file (a project, template, or family document).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

If `null` is passed as 'fileName'.
-or-
A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file specified by 'fileName' cannot be found.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If the active document is currently modifiable.
If an API event handler is currently being executed.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

If there is any server internal error.

#### Since

2012

### `P:Autodesk.Revit.UI.UIControlledApplication.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIControlledApplication.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.VSTA.ApplicationEntryPoint.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.UIControlledApplication.IsViewerModeActive`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIControlledApplication.IsViewerModeActive`

#### Summary

Determines if Revit session is in Viewer mode.

#### Since

2019.1

### `P:Autodesk.Revit.VSTA.ApplicationEntryPoint.IsViewerModeActive`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.IsViewerModeActive`

#### Summary

Determines if Revit session is in Viewer mode.

#### Since

2019.1

### `P:Autodesk.Revit.UI.UIControlledApplication.Application`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIControlledApplication.Application`

#### Summary

Returns the database level Application represented by this UI level Application.

### `P:Autodesk.Revit.VSTA.ApplicationEntryPoint.Application`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.Application`

#### Summary

Returns the database level Application represented by this UI level Application.

### `M:Autodesk.Revit.UI.UIControlledApplication.OpenRecentFileOnRevitHome(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.OpenRecentFileOnRevitHome(Autodesk.Revit.DB.ModelPath)`

#### Summary

Open a recent model on revit home.

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.OpenRecentFileOnRevitHome(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.OpenRecentFileOnRevitHome(Autodesk.Revit.DB.ModelPath)`

#### Summary

Open a recent model on revit home.

### `P:Autodesk.Revit.UI.UIControlledApplication.MainWindowHandle`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIControlledApplication.MainWindowHandle`

#### Summary

Get the handle of the Revit main window.

#### Remarks

Returns the main window handle of the Revit application. This handle should be used when displaying
modal dialogs and message windows to insure that they are properly parented. This property replaces
System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle property, which is no longer a reliable
method of retrieving the main window handle starting with Revit 2019.

#### Since

2019

### `P:Autodesk.Revit.VSTA.ApplicationEntryPoint.MainWindowHandle`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.MainWindowHandle`

#### Summary

Get the handle of the Revit main window.

#### Remarks

Returns the main window handle of the Revit application. This handle should be used when displaying
modal dialogs and message windows to insure that they are properly parented. This property replaces
System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle property, which is no longer a reliable
method of retrieving the main window handle starting with Revit 2019.

#### Since

2019

### `M:Autodesk.Revit.UI.UIControlledApplication.RegisterDockablePane(Autodesk.Revit.UI.DockablePaneId,System.String,Autodesk.Revit.UI.IDockablePaneProvider)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.RegisterDockablePane(Autodesk.Revit.UI.DockablePaneId,System.String,Autodesk.Revit.UI.IDockablePaneProvider)`

#### Summary

Adds a new dockable pane to the Revit user interface.

#### Parameter `id`

Unique identifier for the new pane.

#### Parameter `title`

String to use for the pane caption.

#### Parameter `provider`

Your add-in's implementation of the IDockablePaneProvider interface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if a dockable pane with identifier %id% has already been registered.

#### Since

2014

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.RegisterDockablePane(Autodesk.Revit.UI.DockablePaneId,System.String,Autodesk.Revit.UI.IDockablePaneProvider)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.RegisterDockablePane(Autodesk.Revit.UI.DockablePaneId,System.String,Autodesk.Revit.UI.IDockablePaneProvider)`

#### Summary

Adds a new dockable pane to the Revit user interface.

#### Parameter `id`

Unique identifier for the new pane.

#### Parameter `title`

String to use for the pane caption.

#### Parameter `provider`

Your add-in's implementation of the IDockablePaneProvider interface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if a dockable pane with identifier %id% has already been registered.

#### Since

2014

### `P:Autodesk.Revit.UI.UIControlledApplication.ProductIsRS`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIControlledApplication.ProductIsRS`

#### Summary

Identifies if the current Revit product has an RS designation. Most add-ins will not need to use this information.

#### Since

2019

### `P:Autodesk.Revit.VSTA.ApplicationEntryPoint.ProductIsRS`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.ProductIsRS`

#### Summary

Identifies if the current Revit product has an RS designation. Most add-ins will not need to use this information.

#### Since

2019

### `M:Autodesk.Revit.UI.UIControlledApplication.GetDockablePane(Autodesk.Revit.UI.DockablePaneId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.GetDockablePane(Autodesk.Revit.UI.DockablePaneId)`

#### Summary

Gets a DockablePane object by its ID.

#### Parameter `id`

Unique identifier for the new pane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if no dockable pane has been registered with identifier %id%.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the dockable pane with identifier %id% has not been created yet.

#### Since

2014

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.GetDockablePane(Autodesk.Revit.UI.DockablePaneId)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.GetDockablePane(Autodesk.Revit.UI.DockablePaneId)`

#### Summary

Gets a DockablePane object by its ID.

#### Parameter `id`

Unique identifier for the new pane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if no dockable pane has been registered with identifier %id%.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the dockable pane with identifier %id% has not been created yet.

#### Since

2014

### `M:Autodesk.Revit.UI.UIControlledApplication.LoadPackageContents(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.LoadPackageContents(System.String)`

#### Summary

Loads add-ins from the given packageContents.xml file.

#### Parameter `packageContentsPath`

The name of package contents file

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

Thrown when manifest file which is specified by
packageContentsPath doesn't exist.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown if the add-in file path specified by
packageContentsPath is null, Or packageContentsPath is null.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the add-in specified by packageContentsPath doesn't
end with 'addin' or packageContentsPath is a zero-length string.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

Thrown if the packageContentsPath is not found.

#### Exception `T:Autodesk.Revit.Exceptions.ApplicationException`

Thrown if the manifest file specified by packageContentsPath
can't be parsed successfully.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when any of the newly added external
applications fails to load and/or initialize properly, possibly because of one of the following reasons:

AllowLoadingIntoExistingSession property is 'No'.

Client id is duplicated.

External application start up failed.

#### Exception `T:Autodesk.Revit.Exceptions.InternalException`

Thrown if packageContentsPath file that was found could not
be loaded.

#### Since

2014

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.LoadPackageContents(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.LoadPackageContents(System.String)`

#### Summary

Loads add-ins from the given packageContents.xml file.

#### Parameter `packageContentsPath`

The name of package contents file

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

Thrown when manifest file which is specified by
packageContentsPath doesn't exist.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown if the add-in file path specified by
packageContentsPath is null, Or packageContentsPath is null.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the add-in specified by packageContentsPath doesn't
end with 'addin' or packageContentsPath is a zero-length string.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

Thrown if the packageContentsPath is not found.

#### Exception `T:Autodesk.Revit.Exceptions.ApplicationException`

Thrown if the manifest file specified by packageContentsPath
can't be parsed successfully.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when any of the newly added external
applications fails to load and/or initialize properly, possibly because of one of the following reasons:

AllowLoadingIntoExistingSession property is 'No'.

Client id is duplicated.

External application start up failed.

#### Exception `T:Autodesk.Revit.Exceptions.InternalException`

Thrown if packageContentsPath file that was found could not
be loaded.

#### Since

2014

### `M:Autodesk.Revit.UI.UIControlledApplication.LoadAddIn(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.LoadAddIn(System.String)`

#### Summary

Loads add-ins from the given manifest file.

#### Remarks

This method loads the add-ins listed in the provided add-in manifest file.
The API will look for the file in the dedicated folders supported by Revit for loading add-in manifest files.

Some add-ins may have settings in which they decline the ability for Revit to load the external application declared
in the .addin in mid-session.
This happens when the AllowLoadingIntoExistingSession tag is set to "No" in the add-in manifest file, and if the tag
isn't present, the default is set to "Yes".

Note that when Revit starts an add-in in the middle of the session, some add-in logic may not function as expected
because of the different interactions with the session. Specifically:
If the application's goal is to prevent something from happening, the application may not be able to handle
the fact that this activity has already happened in the existing session.

If the application's goal is to manage external information in synch with documents loaded in the session,
the application may not be able to handle documents that were loaded before the application started.
If the application's logic depends on the ApplicationInitialized event, this event has already been called
before the add-in was loaded.

Also, some add-ins may not be able to fully initialize when loading in the middle of the session. This is because some
activities must take place at the start of the Revit session:
Creation of custom failure definitions

Establishment of a system-wide IFailureProcessor to handle all failures.

Registering ExternalServices.

#### Parameter `fileName`

The name of the add-in manifest file including the extension is to identify the
manifest file which contains Revit add-ins.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

Thrown when manifest file which is specified by
fileName doesn't exist.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown if the fileName is null or empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the fileName doesn't end with 'addin'.

#### Exception `T:Autodesk.Revit.Exceptions.ApplicationException`

Thrown if the manifest file can't be parsed successfully.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when any of the newly added external
applications fails to load and/or initialize properly, possibly because of one of the following reasons:

AllowLoadingIntoExistingSession property is 'No'.

Client id is duplicated.

External application start up failed.

#### Since

2014

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.LoadAddIn(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.LoadAddIn(System.String)`

#### Summary

Loads add-ins from the given manifest file.

#### Remarks

This method loads the add-ins listed in the provided add-in manifest file.
The API will look for the file in the dedicated folders supported by Revit for loading add-in manifest files.

Some add-ins may have settings in which they decline the ability for Revit to load the external application declared
in the .addin in mid-session.
This happens when the AllowLoadingIntoExistingSession tag is set to "No" in the add-in manifest file, and if the tag
isn't present, the default is set to "Yes".

Note that when Revit starts an add-in in the middle of the session, some add-in logic may not function as expected
because of the different interactions with the session. Specifically:
If the application's goal is to prevent something from happening, the application may not be able to handle
the fact that this activity has already happened in the existing session.

If the application's goal is to manage external information in synch with documents loaded in the session,
the application may not be able to handle documents that were loaded before the application started.
If the application's logic depends on the ApplicationInitialized event, this event has already been called
before the add-in was loaded.

Also, some add-ins may not be able to fully initialize when loading in the middle of the session. This is because some
activities must take place at the start of the Revit session:
Creation of custom failure definitions

Establishment of a system-wide IFailureProcessor to handle all failures.

Registering ExternalServices.

#### Parameter `fileName`

The name of the add-in manifest file including the extension is to identify the
manifest file which contains Revit add-ins.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

Thrown when manifest file which is specified by
fileName doesn't exist.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown if the fileName is null or empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the fileName doesn't end with 'addin'.

#### Exception `T:Autodesk.Revit.Exceptions.ApplicationException`

Thrown if the manifest file can't be parsed successfully.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when any of the newly added external
applications fails to load and/or initialize properly, possibly because of one of the following reasons:

AllowLoadingIntoExistingSession property is 'No'.

Client id is duplicated.

External application start up failed.

#### Since

2014

### `M:Autodesk.Revit.UI.UIControlledApplication.RemoveAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.RemoveAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId)`

#### Summary

Removes an AddInCommandBinding.

#### Parameter `revitCommandId`

The Revit command id to identify the command handler you want to remove the binding.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when uiApplication or revitCommandId
is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the given command is not bound with this add-in.

#### Since

2013

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.RemoveAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.RemoveAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId)`

#### Summary

Removes an AddInCommandBinding.

#### Parameter `revitCommandId`

The Revit command id to identify the command handler you want to remove the binding.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when uiApplication or revitCommandId
is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the given command is not bound with this add-in.

#### Since

2013

### `M:Autodesk.Revit.UI.UIControlledApplication.CreateAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.CreateAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId)`

#### Summary

Creates a new AddInCommandBinding.

#### Parameter `revitCommandId`

The Revit command id to identify the command handler you want to replace.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when uiApplication or revitCommandId
is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the given command already has been bound.

#### Since

2013

### `M:Autodesk.Revit.VSTA.ApplicationEntryPoint.CreateAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.CreateAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId)`

#### Summary

Creates a new AddInCommandBinding.

#### Parameter `revitCommandId`

The Revit command id to identify the command handler you want to replace.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when uiApplication or revitCommandId
is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the given command already has been bound.

#### Since

2013

### `P:Autodesk.Revit.UI.UIControlledApplication.ActiveAddInId`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIControlledApplication.ActiveAddInId`

#### Summary

Get current active external application or external command id.

### `P:Autodesk.Revit.VSTA.ApplicationEntryPoint.ActiveAddInId`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.ActiveAddInId`

#### Summary

Get current active external application or external command id.

### `P:Autodesk.Revit.UI.UIControlledApplication.LoadedApplications`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIControlledApplication.LoadedApplications`

#### Summary

Returns an array of successfully loaded external applications.

#### Remarks

This property can be used by your application to find all successfully
loaded external applications when Revit starts.

### `P:Autodesk.Revit.VSTA.ApplicationEntryPoint.LoadedApplications`

Member kind: property
Symbol: `Autodesk.Revit.VSTA.ApplicationEntryPoint.LoadedApplications`

#### Summary

Returns an array of successfully loaded external applications.

#### Remarks

This property can be used by your application to find all successfully
loaded external applications when Revit starts.

### `M:Autodesk.Revit.UI.UIControlledApplication.GetRibbonPanels(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIControlledApplication.GetRibbonPanels(System.String)`

#### Summary

Get all the custom Panels on a designated Revit tab.

#### Parameter `tabName`

The name of the tab on which the panels are located.

#### Remarks

Built-in panels will not be included. tabName must be the name of one of the tabs added
by `M:Autodesk.Revit.UI.UIApplication.CreateRibbonTab(System.String)` .
This method is not supported in Macros.
