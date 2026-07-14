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
Shard: 2
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPIUI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `P:Autodesk.Revit.UI.Events.DialogBoxData.HelpId`

Member kind: property
Symbol: `Autodesk.Revit.UI.Events.DialogBoxData.HelpId`

#### Summary

An ID that represents the dialog that has been displayed.

#### Remarks

Use this ID within your application to key suitable responses for the dialog. Note: this id is
not guaranteed to remain stable for different builds of Autodesk Revit.

### `T:Autodesk.Revit.UI.Events.DialogBoxData`

Member kind: type
Symbol: `Autodesk.Revit.UI.Events.DialogBoxData`

#### Summary

An object that is passed to your application when a dialog is displayed in Revit.

#### Remarks

When the application receives this object, a dialog has been displayed in Revit that
requires user interaction. The OverrideResult function can be used to cause the dialog
to be dismissed and return a desired result code.

### `P:Autodesk.Revit.UI.TextBoxData.Image`

Member kind: property
Symbol: `Autodesk.Revit.UI.TextBoxData.Image`

#### Summary

The image of the TextBox.

#### Remarks

The image will be shown on the left side of the item.
The best size is 16 x 16 pixels.

#### Since

2011

### `M:Autodesk.Revit.UI.TextBoxData.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.TextBoxData.#ctor(System.String)`

#### Summary

Constructs a new instance of TextBoxData.

#### Parameter `name`

The internal name of the TextBoxData.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when `null` is passed for name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when an empty string is passed for name.

#### Since

2011

### `T:Autodesk.Revit.UI.TextBoxData`

Member kind: type
Symbol: `Autodesk.Revit.UI.TextBoxData`

#### Summary

This class contains information necessary to construct a text box in the Ribbon.

#### Since

2011

### `E:Autodesk.Revit.UI.TextBox.EnterPressed`

Member kind: event
Symbol: `Autodesk.Revit.UI.TextBox.EnterPressed`

#### Summary

Subscribe to this event to be notified when the Enter button is pressed in the text box.

### `P:Autodesk.Revit.UI.TextBox.Width`

Member kind: property
Symbol: `Autodesk.Revit.UI.TextBox.Width`

#### Summary

Gets or sets the width of the TextBox.

#### Remarks

The value for this property must be positive and cannot be Infinity.
This value is interpreted in device-independent units (1/96th inch) measurement
device-independent units.
The default value is 200.

#### Since

2011

### `P:Autodesk.Revit.UI.TextBox.ShowImageAsButton`

Member kind: property
Symbol: `Autodesk.Revit.UI.TextBox.ShowImageAsButton`

#### Summary

Gets or sets a value that indicates if the Image set
in the text box should be displayed as a clickable button.

#### Remarks

If this property is true, the image will shown as a button inside the textbox.
Clicking this button will trigger the EnterPressed event. The default value
is false.

#### Since

2011

### `P:Autodesk.Revit.UI.TextBox.Image`

Member kind: property
Symbol: `Autodesk.Revit.UI.TextBox.Image`

#### Summary

The image of the TextBox.

#### Remarks

The image will be shown on the left side of the item.
The best size is 16 x 16 pixels.

#### Since

2011

### `P:Autodesk.Revit.UI.TextBox.Value`

Member kind: property
Symbol: `Autodesk.Revit.UI.TextBox.Value`

#### Summary

The object that supplies the text value.

#### Remarks

The value assigned to the TextBox can be a `T:System.String` or any other data type.
If the type is not a String the TextBox will display the return of the ToString() method.
When the text is edited in the UI, the type of Value will always be `T:System.String` .

#### Since

2011

### `P:Autodesk.Revit.UI.TextBox.SelectTextOnFocus`

Member kind: property
Symbol: `Autodesk.Revit.UI.TextBox.SelectTextOnFocus`

#### Summary

A value that indicates if the text is selected when the text box gains focus.

#### Remarks

If the value is true all the text in the text box will be selected when the text box gets keyboard
focus. If it is false the text is not selected. The default value is false.

#### Since

2011

### `P:Autodesk.Revit.UI.TextBox.PromptText`

Member kind: property
Symbol: `Autodesk.Revit.UI.TextBox.PromptText`

#### Summary

The prompt text for the text box.

#### Remarks

Prompt text is displayed when the text box is empty
and does not have keyboard focus. This text is displayed in italics. The default value is `null` .

#### Since

2011

### `T:Autodesk.Revit.UI.TextBox`

Member kind: type
Symbol: `Autodesk.Revit.UI.TextBox`

#### Summary

The TextBox object represents text-based control that allows the user to enter text.

#### Remarks

The ItemText property inherited from RibbonItem has no effect.
The text entered in the TextBox is edited by the UI user is accepted only if the user presses the Enter key or click the image button when ShowImageAsButton is true.
If the user clicks off of this component without pressing Enter or click the image button; then the text will be reverted to the previous value.
Use of this class is not supported in Revit Macros.

#### Since

2011

### `P:Autodesk.Revit.UI.Macros.ApplicationEntryPoint.AddinFolder`

Member kind: property
Symbol: `Autodesk.Revit.UI.Macros.ApplicationEntryPoint.AddinFolder`

#### Summary

The full path to the Revit Macros module.

#### Remarks

This path should be used instead of the .NET GetExecutingAssembly() result, because
the Macros module is loaded in such a way to make that result unreliable.

### `M:Autodesk.Revit.UI.Macros.ApplicationEntryPoint.OnShutdownEO`

Member kind: method
Symbol: `Autodesk.Revit.UI.Macros.ApplicationEntryPoint.OnShutdownEO`

#### Summary

For Revit Macros internal use only.

### `M:Autodesk.Revit.UI.Macros.ApplicationEntryPoint.FinishInitializationEO`

Member kind: method
Symbol: `Autodesk.Revit.UI.Macros.ApplicationEntryPoint.FinishInitializationEO`

#### Summary

For Revit Macros internal use only.

### `M:Autodesk.Revit.UI.Macros.ApplicationEntryPoint.Initialize(System.Object,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.Macros.ApplicationEntryPoint.Initialize(System.Object,System.String)`

#### Summary

For Revit Macros internal use only.

### `T:Autodesk.Revit.UI.Macros.ApplicationEntryPoint`

Member kind: type
Symbol: `Autodesk.Revit.UI.Macros.ApplicationEntryPoint`

#### Summary

For Revit Macros use only.

### `M:MFCDockableFrame.isActiveDocChanged(ADocument*)`

Member kind: method
Symbol: `MFCDockableFrame.isActiveDocChanged(ADocument*)`

#### Summary

If current active document is changed.

### `M:DockablePaneInterop.PreTranslateMessage(tagMSG*)`

Member kind: method
Symbol: `DockablePaneInterop.PreTranslateMessage(tagMSG*)`

#### Summary

Override message pre-translation to allow the WPF source and any embedded
WinForms controls to handle any keyboard input properly, prior to Windows
doing any sort of translation or dispatching.

#### Remarks

This pre-translation is required for proper handling of tabbing and other
keyboard mnemonics for the embedded WPF/WinForms controls.

### `M:DockablePaneInterop.attachPane(HWND__*,Autodesk.Revit.UI.DockablePaneProviderData)`

Member kind: method
Symbol: `DockablePaneInterop.attachPane(HWND__*,Autodesk.Revit.UI.DockablePaneProviderData)`

#### Summary

Called to attach to the specified pane

#### Parameter `parent`

The native HWND parent/container for the Pane.

#### Parameter `paneData`

The provider information describing the Pane.

#### Returns

true if successfully attached, false otherwise.

### `M:DockablePaneMsgHook.HookProc(System.IntPtr,System.Int32,System.IntPtr,System.IntPtr,System.Boolean@)`

Member kind: method
Symbol: `DockablePaneMsgHook.HookProc(System.IntPtr,System.Int32,System.IntPtr,System.IntPtr,System.Boolean@)`

#### Summary

The hook delegate that gets called for each message on the hooked source.
We hook to handle any DockablePane specific messages as well as to hook
WM_GETDLGCODE properly to allow for input commands on the embedded controls.

### `M:DockablePaneMsgHook.#ctor(System.Windows.Interop.HwndSource)`

Member kind: method
Symbol: `DockablePaneMsgHook.#ctor(System.Windows.Interop.HwndSource)`

#### Summary

Construct a hook for the given source and panelData

### `M:Autodesk.Revit.UI.ToggleButtonData.#ctor(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ToggleButtonData.#ctor(System.String,System.String)`

#### Summary

Constructs a new instance of ToggleButtonData, where the ToggleButton will not be associated to an ExternalCommand.

#### Parameter `name`

The internal name of the new button.

#### Parameter `text`

The user visible text seen on the new button.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when `null` is passed for one or more arguments.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when an empty string is passed for one or more arguments.

#### Since

2011

### `M:Autodesk.Revit.UI.ToggleButtonData.#ctor(System.String,System.String,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ToggleButtonData.#ctor(System.String,System.String,System.String,System.String)`

#### Summary

Constructs a new instance of ToggleButtonData, where the ToggleButton will execute an ExternalCommand when clicked.

#### Parameter `name`

The internal name of the new button.

#### Parameter `text`

The user visible text seen on the new button.

#### Parameter `assemblyName`

The assembly path of the button.

#### Parameter `className`

The name of the class containing the implementation for the command.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when `null` is passed for one or more arguments.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when an empty string is passed for one or more arguments.

#### Since

2011

### `T:Autodesk.Revit.UI.ToggleButtonData`

Member kind: type
Symbol: `Autodesk.Revit.UI.ToggleButtonData`

#### Summary

This class contains information necessary to construct a toggle button in a RadioButtonGroup.

#### Since

2011

### `T:Autodesk.Revit.UI.ToggleButton`

Member kind: type
Symbol: `Autodesk.Revit.UI.ToggleButton`

#### Summary

The ToggleButton object represents a button that has been added to a RadioButtonGroup.

#### Remarks

Use of this class is not supported in Revit Macros.

#### Since

2011

### `M:Autodesk.Revit.UI.RadioButtonGroupData.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.RadioButtonGroupData.#ctor(System.String)`

#### Summary

Constructs a new instance of RadioButtonGroupData.

#### Parameter `name`

The internal name of the RadioButtonGroup.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when `null` is passed for name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when an empty string is passed for name.

#### Since

2011

### `T:Autodesk.Revit.UI.RadioButtonGroupData`

Member kind: type
Symbol: `Autodesk.Revit.UI.RadioButtonGroupData`

#### Summary

This class contains information necessary to construct a ribbon gallery in the Ribbon.

#### Since

2011

### `M:Autodesk.Revit.UI.RadioButtonGroup.GetItems`

Member kind: method
Symbol: `Autodesk.Revit.UI.RadioButtonGroup.GetItems`

#### Summary

Gets the collection of ToggleButtons assigned to the RadioButtonGroup.

#### Remarks

This is a copy of all the ToggleButtons assigned to this group.

#### Since

2011

### `M:Autodesk.Revit.UI.RadioButtonGroup.AddItems(System.Collections.Generic.IList{Autodesk.Revit.UI.ToggleButtonData})`

Member kind: method
Symbol: `Autodesk.Revit.UI.RadioButtonGroup.AddItems(System.Collections.Generic.IList{Autodesk.Revit.UI.ToggleButtonData})`

#### Summary

Adds new ToggleButtons to the RadioButtonGroup.

#### Parameter `buttonData`

A list of objects containing the data needed to construct the ToggleButtons.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when buttonData is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when button with buttonData.Name already exists in the group.

#### Returns

The newly added ToggleButtons.

#### Since

2011

### `M:Autodesk.Revit.UI.RadioButtonGroup.AddItem(Autodesk.Revit.UI.ToggleButtonData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.RadioButtonGroup.AddItem(Autodesk.Revit.UI.ToggleButtonData)`

#### Summary

Adds a new ToggleButton to the RadioButtonGroup.

#### Parameter `buttonData`

An object containing the data needed to construct the ToggleButton.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when buttonData is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when button with buttonData.Name already exists in the group.

#### Returns

The newly added ToggleButton.

#### Since

2011

### `P:Autodesk.Revit.UI.RadioButtonGroup.Current`

Member kind: property
Symbol: `Autodesk.Revit.UI.RadioButtonGroup.Current`

#### Summary

Gets or sets the current checked ToggleButton of the RadioButtonGroup.

#### Remarks

The default value is the first ToggleButton added to the group.
When using this property to set the current ToggleButton, the external command of that button will not be called.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when trying to set this property to `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when trying to set this property to a button not in this group.

#### Since

2011

### `T:Autodesk.Revit.UI.RadioButtonGroup`

Member kind: type
Symbol: `Autodesk.Revit.UI.RadioButtonGroup`

#### Summary

Represents a group of related buttons in the Ribbon.

#### Remarks

This class contains a collection of ToggleButtons. Only one of the ToggleButtons will appear active at a given time.
When a different button is clicked in the UI the current ToggleButton will be changed, and the ToggleButton's external command will be invoked.
Use of this class is not supported in Revit Macros.

#### Since

2011

### `M:Autodesk.Revit.UI.ExternalEvent.Raise`

Member kind: method
Symbol: `Autodesk.Revit.UI.ExternalEvent.Raise`

#### Summary

Instructing Revit to raise (signal) the external event.

#### Remarks

Revit will wait until it is ready to process the event and then
it will execute its event handler by calling the Execute method.
Revit processes external events only when no other commands or
edit modes are currently active in Revit, which is the same policy
like the one that applies to evoking external commands.

#### Returns

The result of event raising request. If the request is 'Accepted',
the event would be added to the event queue and its handler will
be executed in the next event-processing cycle.

#### Since

2013

### `M:Autodesk.Revit.UI.ExternalEvent.CreateJournalable(Autodesk.Revit.UI.IExternalEventHandler)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ExternalEvent.CreateJournalable(Autodesk.Revit.UI.IExternalEventHandler)`

#### Summary

Creates an instance of external event which will have the ability to record its executions in the journal.

#### Parameter `handler`

An instance of IExternalEventHandler which will execute the event.

#### Returns

An instance of ExternalEvent class, which will be used to invoke the event

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2015

### `M:Autodesk.Revit.UI.ExternalEvent.Create(Autodesk.Revit.UI.IExternalEventHandler)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ExternalEvent.Create(Autodesk.Revit.UI.IExternalEventHandler)`

#### Summary

Creates an instance of external event.

#### Parameter `handler`

An instance of IExternalEventHandler which will execute the event.

#### Returns

An instance of ExternalEvent class, which will be used to invoke the event

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2013

### `P:Autodesk.Revit.UI.ExternalEvent.IsPending`

Member kind: property
Symbol: `Autodesk.Revit.UI.ExternalEvent.IsPending`

#### Summary

Checking whether an event has been raised but not yet executed.

#### Remarks

When an event is requested to raise it is not executed immediately;
instead, it waits for the next possible opportunity, which is determined
by various internal conditions in Revit (policy similar to invoking
external commands). When the opportunity comes, the event is executed
by calling the event's handler. In the meantime, the event is 'Pending'.

#### Since

2013

### `T:Autodesk.Revit.UI.ExternalEvent`

Member kind: type
Symbol: `Autodesk.Revit.UI.ExternalEvent`

#### Summary

A class that represent an external event.

#### Remarks

An instance if this class will be returned to an external event's owner upon the event's creation.
The event's owner will use this instance to signal that his application needs to be called by Revit.
Revit will periodically check if any of the events have been signaled (raised), and will execute
all events that were signaled (raised) by calling the Execute method on the events' respective handlers.

#### Since

2013

### `T:Autodesk.Revit.UI.ExternalEventRequest`

Member kind: type
Symbol: `Autodesk.Revit.UI.ExternalEventRequest`

#### Summary

Represents the possible outcomes of a request for raising an external event.

### `F:Autodesk.Revit.UI.ExternalEventRequest.TimedOut`

Member kind: field
Symbol: `Autodesk.Revit.UI.ExternalEventRequest.TimedOut`

#### Summary

Request not accepted due to synchronization issues with other thread(s).

### `F:Autodesk.Revit.UI.ExternalEventRequest.Denied`

Member kind: field
Symbol: `Autodesk.Revit.UI.ExternalEventRequest.Denied`

#### Summary

Request was denied due to failures of the corresponding event handler.

### `F:Autodesk.Revit.UI.ExternalEventRequest.Pending`

Member kind: field
Symbol: `Autodesk.Revit.UI.ExternalEventRequest.Pending`

#### Summary

Request not accepted, because the previous request is still pending (not executed).

### `F:Autodesk.Revit.UI.ExternalEventRequest.Accepted`

Member kind: field
Symbol: `Autodesk.Revit.UI.ExternalEventRequest.Accepted`

#### Summary

Request accepted; event was added into the event queue and will be executed momentarily.

### `M:Autodesk.Revit.UI.IExternalEventHandler.GetName`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalEventHandler.GetName`

#### Summary

String identification of the event handler.

#### Returns

The event's name

#### Since

2013

### `M:Autodesk.Revit.UI.IExternalEventHandler.Execute(Autodesk.Revit.UI.UIApplication)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IExternalEventHandler.Execute(Autodesk.Revit.UI.UIApplication)`

#### Summary

This method is called to handle the external event.

#### Since

2013

### `T:Autodesk.Revit.UI.IExternalEventHandler`

Member kind: type
Symbol: `Autodesk.Revit.UI.IExternalEventHandler`

#### Summary

An interface to be executed when an external event is raised.

#### Remarks

An instance of a class implementing this interface will be registered
with Revit first, and every time the corresponding external event
is raised, the Execute method of this interface will be invoked.

#### Since

2013

### `M:UVUtils.cross(UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `UVUtils.cross(UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:UVUtils.dot(UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `UVUtils.dot(UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,UVUtils.UV!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:UVUtils.UV.normalized`

Member kind: method
Symbol: `UVUtils.UV.normalized`

### `M:UVUtils.UV.unit`

Member kind: method
Symbol: `UVUtils.UV.unit`

### `M:UVUtils.UV.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `UVUtils.UV.#ctor(System.Double,System.Double)`

### `M:UVUtils.UV.basisV`

Member kind: method
Symbol: `UVUtils.UV.basisV`

### `M:UVUtils.UV.basisU`

Member kind: method
Symbol: `UVUtils.UV.basisU`

### `M:UVUtils.UV.zero`

Member kind: method
Symbol: `UVUtils.UV.zero`

### `T:UVUtils.UV`

Member kind: type
Symbol: `UVUtils.UV`

#### Summary

'UVUtils::UV' is a class that represents a 2d vector or a 2d point.

#### Remarks

By default UVUtils::UV is initialized to {0.0, 0.0}.

### `M:castToUVArr(Arr<System.Double[N2][2]>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `castToUVArr(Arr<System.Double[N2][2]>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:XYZUtils.vecsAreParallelExact(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `XYZUtils.vecsAreParallelExact(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:XYZUtils.vecsAreParallelApprox(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `XYZUtils.vecsAreParallelApprox(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:XYZUtils.almostEqual(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `XYZUtils.almostEqual(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:XYZUtils.tripleProduct(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `XYZUtils.tripleProduct(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:XYZUtils.asUnitOrZero(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `XYZUtils.asUnitOrZero(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:XYZUtils.asUnit(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `XYZUtils.asUnit(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:XYZUtils.cross(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `XYZUtils.cross(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:XYZUtils.dot(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `XYZUtils.dot(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:XYZUtils.XYZ.normalized`

Member kind: method
Symbol: `XYZUtils.XYZ.normalized`

### `M:XYZUtils.XYZ.unit`

Member kind: method
Symbol: `XYZUtils.XYZ.unit`

### `M:XYZUtils.XYZ.#ctor(System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `XYZUtils.XYZ.#ctor(System.Double,System.Double,System.Double)`

### `M:XYZUtils.XYZ.basis(System.Int32)`

Member kind: method
Symbol: `XYZUtils.XYZ.basis(System.Int32)`

### `M:XYZUtils.XYZ.basisZ`

Member kind: method
Symbol: `XYZUtils.XYZ.basisZ`

### `M:XYZUtils.XYZ.basisY`

Member kind: method
Symbol: `XYZUtils.XYZ.basisY`

### `M:XYZUtils.XYZ.basisX`

Member kind: method
Symbol: `XYZUtils.XYZ.basisX`

### `M:XYZUtils.XYZ.zero`

Member kind: method
Symbol: `XYZUtils.XYZ.zero`

### `T:XYZUtils.XYZ`

Member kind: type
Symbol: `XYZUtils.XYZ`

#### Summary

'XYZUtils::XYZ' is a class that represents a 3d vector or a 3d point.

#### Remarks

By default XYZUtils::XYZ is initialized to {0.0, 0.0, 0.0}.

### `M:castToXYZArr(Arr<System.Double[N3][3]>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `castToXYZArr(Arr<System.Double[N3][3]>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `F:CBitmapRenderTarget.m_pBitmapRenderTarget`

Member kind: field
Symbol: `CBitmapRenderTarget.m_pBitmapRenderTarget`

#### Summary

A pointer to an ID2D1BitmapRenderTarget object.

### `M:CBitmapRenderTarget.GetBitmap(CD2DBitmap*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CBitmapRenderTarget.GetBitmap(CD2DBitmap*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Retrieves the bitmap for this render target. The returned bitmap can be used for drawing operations.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `bitmap`

When this method returns, contains the valid bitmap for this render target. This bitmap can be used for drawing operations.

### `M:CBitmapRenderTarget.op_Implicit~ID2D1BitmapRenderTarget*`

Member kind: method
Symbol: `CBitmapRenderTarget.op_Implicit~ID2D1BitmapRenderTarget*`

#### Summary

Returns ID2D1BitmapRenderTarget interface

#### Returns

Pointer to an ID2D1BitmapRenderTarget interface or NULL if object is not initialized yet.

### `M:CBitmapRenderTarget.GetBitmapRenderTarget`

Member kind: method
Symbol: `CBitmapRenderTarget.GetBitmapRenderTarget`

#### Summary

Returns ID2D1BitmapRenderTarget interface

#### Returns

Pointer to an ID2D1BitmapRenderTarget interface or NULL if object is not initialized yet.

### `M:CBitmapRenderTarget.Detach`

Member kind: method
Symbol: `CBitmapRenderTarget.Detach`

#### Summary

Detaches render target interface from the object

#### Returns

Pointer to detached render target interface.

### `M:CBitmapRenderTarget.Attach(ID2D1BitmapRenderTarget*)`

Member kind: method
Symbol: `CBitmapRenderTarget.Attach(ID2D1BitmapRenderTarget*)`

#### Summary

Attaches existing render target interface to the object

#### Parameter `pTarget`

Existing render target interface. Cannot be NULL

### `M:CBitmapRenderTarget.#ctor`

Member kind: method
Symbol: `CBitmapRenderTarget.#ctor`

#### Summary

Constructs a CBitmapRenderTarget object.

### `F:CDCRenderTarget.m_pDCRenderTarget`

Member kind: field
Symbol: `CDCRenderTarget.m_pDCRenderTarget`

#### Summary

A pointer to an ID2D1DCRenderTarget object.

### `M:CDCRenderTarget.op_Implicit~ID2D1DCRenderTarget*`

Member kind: method
Symbol: `CDCRenderTarget.op_Implicit~ID2D1DCRenderTarget*`

#### Summary

Returns ID2D1DCRenderTarget interface

#### Returns

Pointer to an ID2D1DCRenderTarget interface or NULL if object is not initialized yet.

### `M:CDCRenderTarget.GetDCRenderTarget`

Member kind: method
Symbol: `CDCRenderTarget.GetDCRenderTarget`

#### Summary

Returns ID2D1DCRenderTarget interface

#### Returns

Pointer to an ID2D1DCRenderTarget interface or NULL if object is not initialized yet.

### `M:CDCRenderTarget.BindDC(CDC!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CDCRenderTarget.BindDC(CDC!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Binds the render target to the device context to which it issues drawing commands

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `dc`

The device context to which the render target issues drawing commands

#### Parameter `rect`

The dimensions of the handle to a device context (HDC) to which the render target is bound

### `M:CDCRenderTarget.Create(D2D1_RENDER_TARGET_PROPERTIES!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CDCRenderTarget.Create(D2D1_RENDER_TARGET_PROPERTIES!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Creates a CDCRenderTarget.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `props`

The rendering mode, pixel format, remoting options, DPI information, and the minimum DirectX support required for hardware rendering.

### `M:CDCRenderTarget.Detach`

Member kind: method
Symbol: `CDCRenderTarget.Detach`

#### Summary

Detaches render target interface from the object

#### Returns

Pointer to detached render target interface.

### `M:CDCRenderTarget.Attach(ID2D1DCRenderTarget*)`

Member kind: method
Symbol: `CDCRenderTarget.Attach(ID2D1DCRenderTarget*)`

#### Summary

Attaches existing render target interface to the object

#### Parameter `pTarget`

Existing render target interface. Cannot be NULL

### `M:CDCRenderTarget.#ctor`

Member kind: method
Symbol: `CDCRenderTarget.#ctor`

#### Summary

Constructs a CDCRenderTarget object.

### `T:CDCRenderTarget`

Member kind: type
Symbol: `CDCRenderTarget`

#### Summary

ID2D1DCRenderTarget wrapper.

### `F:CHwndRenderTarget.m_pHwndRenderTarget`

Member kind: field
Symbol: `CHwndRenderTarget.m_pHwndRenderTarget`

#### Summary

A pointer to an ID2D1HwndRenderTarget object.

### `M:CHwndRenderTarget.Resize(CD2DSizeU!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CHwndRenderTarget.Resize(CD2DSizeU!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Changes the size of the render target to the specified pixel size

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `size`

The new size of the render target in device pixels

### `M:CHwndRenderTarget.CheckWindowState`

Member kind: method
Symbol: `CHwndRenderTarget.CheckWindowState`

#### Summary

Indicates whether the HWND associated with this render target is occluded.

#### Returns

A value that indicates whether the HWND associated with this render target is occluded.

### `M:CHwndRenderTarget.GetHwnd`

Member kind: method
Symbol: `CHwndRenderTarget.GetHwnd`

#### Summary

Returns the HWND associated with this render target.

#### Returns

The HWND associated with this render target.

### `M:CHwndRenderTarget.op_Implicit~ID2D1HwndRenderTarget*`

Member kind: method
Symbol: `CHwndRenderTarget.op_Implicit~ID2D1HwndRenderTarget*`

#### Summary

Returns ID2D1HwndRenderTarget interface.

#### Returns

Pointer to an ID2D1HwndRenderTarget interface or NULL if object is not initialized yet.

### `M:CHwndRenderTarget.GetHwndRenderTarget`

Member kind: method
Symbol: `CHwndRenderTarget.GetHwndRenderTarget`

#### Summary

Returns ID2D1HwndRenderTarget interface.

#### Returns

Pointer to an ID2D1HwndRenderTarget interface or NULL if object is not initialized yet.

### `M:CHwndRenderTarget.ReCreate(HWND__*)`

Member kind: method
Symbol: `CHwndRenderTarget.ReCreate(HWND__*)`

#### Summary

Re-creates a render target associated with the window

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `hWnd`

The HWND associated with this render target

### `M:CHwndRenderTarget.Create(HWND__*)`

Member kind: method
Symbol: `CHwndRenderTarget.Create(HWND__*)`

#### Summary

Creates a render target associated with the window

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE

#### Parameter `hWnd`

The HWND associated with this render target

### `M:CHwndRenderTarget.Detach`

Member kind: method
Symbol: `CHwndRenderTarget.Detach`

#### Summary

Detaches render target interface from the object

#### Returns

Pointer to detached render target interface.

### `M:CHwndRenderTarget.Attach(ID2D1HwndRenderTarget*)`

Member kind: method
Symbol: `CHwndRenderTarget.Attach(ID2D1HwndRenderTarget*)`

#### Summary

Attaches existing render target interface to the object

#### Parameter `pTarget`

Existing render target interface. Cannot be NULL

### `M:CHwndRenderTarget.#ctor(HWND__*)`

Member kind: method
Symbol: `CHwndRenderTarget.#ctor(HWND__*)`

#### Summary

Constructs a CHwndRenderTarget object from HWND.

#### Parameter `hwnd`

The HWND associated with this render target

### `T:CHwndRenderTarget`

Member kind: type
Symbol: `CHwndRenderTarget`

#### Summary

ID2D1HwndRenderTarget wrapper.

### `F:CRenderTarget.m_pTextFormatDefault`

Member kind: field
Symbol: `CRenderTarget.m_pTextFormatDefault`

#### Summary

A pointer to CD2DTextFormat object that contains a default text format.

### `F:CRenderTarget.m_lstResources`

Member kind: field
Symbol: `CRenderTarget.m_lstResources`

#### Summary

A list of pointers to CD2DResource objects.

### `F:CRenderTarget.m_pRenderTarget`

Member kind: field
Symbol: `CRenderTarget.m_pRenderTarget`

#### Summary

A pointer to an ID2D1RenderTarget object.

### `M:CRenderTarget.VerifyResource(CD2DResource*)`

Member kind: method
Symbol: `CRenderTarget.VerifyResource(CD2DResource*)`

#### Summary

Verifies CD2DResource object validity; creates the object if it didn't already exist.

#### Parameter `pResource`

Pointer to CD2DResource object.

#### Returns

TRUE is object if valid; otherwise FALSE.

### `M:CRenderTarget.PopAxisAlignedClip`

Member kind: method
Symbol: `CRenderTarget.PopAxisAlignedClip`

#### Summary

Removes the last axis-aligned clip from the render target. After this method is called, the clip is no longer applied to subsequent drawing operations.

### `M:CRenderTarget.PushAxisAlignedClip(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,D2D1_ANTIALIAS_MODE)`

Member kind: method
Symbol: `CRenderTarget.PushAxisAlignedClip(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,D2D1_ANTIALIAS_MODE)`

#### Summary

Removes the last axis-aligned clip from the render target. After this method is called, the clip is no longer applied to subsequent drawing operations.

#### Parameter `rectClip`

The size and position of the clipping area, in device-independent pixels.

#### Parameter `mode`

The antialiasing mode that is used to draw the edges of clip rects that have subpixel boundaries, and to blend the clip with the scene contents. The blending is performed once when the PopAxisAlignedClip method is called, and does not apply to each primitive within the layer.

### `M:CRenderTarget.RestoreDrawingState(ID2D1DrawingStateBlock*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CRenderTarget.RestoreDrawingState(ID2D1DrawingStateBlock*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Sets the render target's drawing state to that of the specified ID2D1DrawingStateBlock.

#### Parameter `drawingStateBlock`

The new drawing state of the render target.

### `M:CRenderTarget.SaveDrawingState(ID2D1DrawingStateBlock*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CRenderTarget.SaveDrawingState(ID2D1DrawingStateBlock*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Saves the current drawing state to the specified ID2D1DrawingStateBlock.

#### Parameter `drawingStateBlock`

When this method returns, contains the current drawing state of the render target. This parameter must be initialized before passing it to the method.

### `M:CRenderTarget.Flush(System.UInt64*,System.UInt64*)`

Member kind: method
Symbol: `CRenderTarget.Flush(System.UInt64*,System.UInt64*)`

#### Summary

Executes all pending drawing commands.

#### Parameter `tag1`

Contains the tag for drawing operations that caused errors or 0 if there were no errors. This parameter is passed uninitialized.

#### Parameter `tag2`

Contains the tag for drawing operations that caused errors or 0 if there were no errors. This parameter is passed uninitialized.

### `M:CRenderTarget.PopLayer`

Member kind: method
Symbol: `CRenderTarget.PopLayer`

#### Summary

Stops redirecting drawing operations to the layer that is specified by the last PushLayer call.

### `M:CRenderTarget.PushLayer(D2D1_LAYER_PARAMETERS!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DLayer*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CRenderTarget.PushLayer(D2D1_LAYER_PARAMETERS!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DLayer*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Adds the specified layer to the render target so that it receives all subsequent drawing operations until PopLayer is called.

#### Parameter `layerParameters`

The content bounds, geometric mask, opacity, opacity mask, and antialiasing options for the layer.

#### Parameter `layer`

The layer that receives subsequent drawing operations.

### `M:CRenderTarget.CreateCompatibleRenderTarget(CBitmapRenderTarget*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DSizeF,CD2DSizeU,D2D1_PIXEL_FORMAT*,D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS)`

Member kind: method
Symbol: `CRenderTarget.CreateCompatibleRenderTarget(CBitmapRenderTarget*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DSizeF,CD2DSizeU,D2D1_PIXEL_FORMAT*,D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS)`

#### Summary

Creates a new bitmap render target for use during intermediate offscreen drawing that is compatible with the current render target .

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `bitmapTarget`

When this method returns, contains the address of a pointer to a new bitmap render target. This parameter is passed uninitialized.

#### Parameter `sizeDesired`

The desired size of the new render target in device-independent pixels if it should be different from the original render target, or NULL. For more information, see the Remarks section.

#### Parameter `sizePixelDesired`

The desired size of the new render target in pixels if it should be different from the original render target, or NULL. For more information, see the Remarks section.

#### Parameter `desiredFormat`

The desired pixel format and alpha mode of the new render target, or NULL. If the pixel format is set to DXGI_FORMAT_UNKNOWN or if this parameter is null, the new render target uses the same pixel format as the original render target. If the alpha mode is D2D1_ALPHA_MODE_UNKNOWN or this parameter is NULL, the alpha mode of the new render target defaults to D2D1_ALPHA_MODE_PREMULTIPLIED. For information about supported pixel formats, see Supported Pixel Formats and Alpha Modes.

#### Parameter `options`

A value that specifies whether the new render target must be compatible with GDI.

### `M:CRenderTarget.GetTransform(D2D_MATRIX_3X2_F*)`

Member kind: method
Symbol: `CRenderTarget.GetTransform(D2D_MATRIX_3X2_F*)`

#### Summary

Applies the specified transform to the render target, replacing the existing transformation. All subsequent drawing operations occur in the transformed space.

#### Parameter `transform`

The transform to apply to the render target.

### `M:CRenderTarget.SetTransform(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CRenderTarget.SetTransform(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Applies the specified transform to the render target, replacing the existing transformation. All subsequent drawing operations occur in the transformed space.

#### Parameter `transform`

The transform to apply to the render target.

### `M:CRenderTarget.SetTransform(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CRenderTarget.SetTransform(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Applies the specified transform to the render target, replacing the existing transformation. All subsequent drawing operations occur in the transformed space.

#### Parameter `transform`

The transform to apply to the render target.

### `M:CRenderTarget.GetTextRenderingParams(IDWriteRenderingParams**)`

Member kind: method
Symbol: `CRenderTarget.GetTextRenderingParams(IDWriteRenderingParams**)`

#### Summary

Retrieves the render target's current text rendering options.

#### Parameter `textRenderingParams`

When this method returns, textRenderingParamscontains the address of a pointer to the render target's current text rendering options.

### `M:CRenderTarget.SetTextRenderingParams(IDWriteRenderingParams*)`

Member kind: method
Symbol: `CRenderTarget.SetTextRenderingParams(IDWriteRenderingParams*)`

#### Summary

Specifies text rendering options to be applied to all subsequent text and glyph drawing operations.

#### Parameter `textRenderingParams`

The text rendering options to be applied to all subsequent text and glyph drawing operations; NULL to clear current text rendering options.

### `M:CRenderTarget.GetTextAntialiasMode`

Member kind: method
Symbol: `CRenderTarget.GetTextAntialiasMode`

#### Summary

Gets the current antialiasing mode for text and glyph drawing operations.

#### Returns

Current antialiasing mode for text and glyph drawing operations.

### `M:CRenderTarget.SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE)`

Member kind: method
Symbol: `CRenderTarget.SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE)`

#### Summary

Specifies the antialiasing mode to use for subsequent text and glyph drawing operations.

#### Parameter `textAntialiasMode`

The antialiasing mode to use for subsequent text and glyph drawing operations.

### `M:CRenderTarget.GetAntialiasMode`

Member kind: method
Symbol: `CRenderTarget.GetAntialiasMode`

#### Summary

Retrieves the current antialiasing mode for nontext drawing operations.

#### Returns

Current antialiasing mode for nontext drawing operations.

### `M:CRenderTarget.SetAntialiasMode(D2D1_ANTIALIAS_MODE)`

Member kind: method
Symbol: `CRenderTarget.SetAntialiasMode(D2D1_ANTIALIAS_MODE)`

#### Summary

Sets the antialiasing mode of the render target. The antialiasing mode applies to all subsequent drawing operations, excluding text and glyph drawing operations.

#### Parameter `antialiasMode`

The antialiasing mode for future drawing operations.

### `M:CRenderTarget.FillMesh(CD2DMesh*,CD2DBrush*)`

Member kind: method
Symbol: `CRenderTarget.FillMesh(CD2DMesh*,CD2DBrush*)`

#### Summary

Paints the interior of the specified mesh.

#### Parameter `pMesh`

The mesh to paint.

#### Parameter `pBrush`

The brush used to paint the mesh.

### `M:CRenderTarget.DrawGlyphRun(CD2DPointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,DWRITE_GLYPH_RUN!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*,DWRITE_MEASURING_MODE)`

Member kind: method
Symbol: `CRenderTarget.DrawGlyphRun(CD2DPointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,DWRITE_GLYPH_RUN!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*,DWRITE_MEASURING_MODE)`

#### Summary

Draws the specified glyphs.

#### Parameter `ptBaseLineOrigin`

The origin, in device-independent pixels, of the glyphs' baseline.

#### Parameter `glyphRun`

The glyphs to render.

#### Parameter `pForegroundBrush`

The brush used to paint the specified glyphs.

#### Parameter `measuringMode`

A value that indicates how glyph metrics are used to measure text when it is formatted. The default value is DWRITE_MEASURING_MODE_NATURAL.

### `M:CRenderTarget.FillGeometry(CD2DGeometry*,CD2DBrush*,CD2DBrush*)`

Member kind: method
Symbol: `CRenderTarget.FillGeometry(CD2DGeometry*,CD2DBrush*,CD2DBrush*)`

#### Summary

Paints the interior of the specified geometry.

#### Parameter `pGeometry`

The geometry to paint.

#### Parameter `pBrush`

The brush used to paint the geometry's interior.

#### Parameter `pOpacityBrush`

The opacity mask to apply to the geometry;NULL for no opacity mask. If an opacity mask (the opacityBrush parameter) is specified, brush must be an ID2D1BitmapBrush that has its x- and y-extend modes set to D2D1_EXTEND_MODE_CLAMP. For more information, see the Remarks section.

### `M:CRenderTarget.DrawGeometry(CD2DGeometry*,CD2DBrush*,System.Single,ID2D1StrokeStyle*)`

Member kind: method
Symbol: `CRenderTarget.DrawGeometry(CD2DGeometry*,CD2DBrush*,System.Single,ID2D1StrokeStyle*)`

#### Summary

Draws the outline of the specified geometry using the specified stroke style.

#### Parameter `pGeometry`

The geometry to draw.

#### Parameter `pBrush`

The brush used to paint the geometry's stroke.

#### Parameter `fStrokeWidth`

The thickness of the geometry's stroke. The stroke is centered on the geometry's outline.

#### Parameter `strokeStyle`

The style of stroke to apply to the geometry's outline, or NULL to paint a solid stroke.

### `M:CRenderTarget.DrawBitmap(CD2DBitmap*,CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single,D2D1_BITMAP_INTERPOLATION_MODE,CD2DRectF!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CRenderTarget.DrawBitmap(CD2DBitmap*,CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single,D2D1_BITMAP_INTERPOLATION_MODE,CD2DRectF!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Draws the formatted text described by the specified IDWriteTextLayout object.

#### Parameter `pBitmap`

The bitmap to render.

#### Parameter `rectDest`

The size and position, in device-independent pixels in the render target's coordinate space, of the area to which the bitmap is drawn. If the rectangle is not well-ordered, nothing is drawn, but the render target does not enter an error state.

#### Parameter `fOpacity`

A value between 0.0f and 1.0f, inclusive, that specifies an opacity value to apply to the bitmap; this value is multiplied against the alpha values of the bitmap's contents.

#### Parameter `interpolationMode`

The interpolation mode to use if the bitmap is scaled or rotated by the drawing operation.

#### Parameter `pRectSrc`

The size and position, in device-independent pixels in the bitmap's coordinate space, of the area within the bitmap to draw.

### `M:CRenderTarget.DrawTextLayout(CD2DPointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DTextLayout*,CD2DBrush*,D2D1_DRAW_TEXT_OPTIONS)`

Member kind: method
Symbol: `CRenderTarget.DrawTextLayout(CD2DPointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DTextLayout*,CD2DBrush*,D2D1_DRAW_TEXT_OPTIONS)`

#### Summary

Draws the formatted text described by the specified IDWriteTextLayout object.

#### Parameter `ptOrigin`

The point, described in device-independent pixels, at which the upper-left corner of the text described by textLayout is drawn.

#### Parameter `textLayout`

The formatted text to draw. Any drawing effects that do not inherit from ID2D1Resource are ignored. If there are drawing effects that inherit from ID2D1Resource that are not brushes, this method fails and the render target is put in an error state.

#### Parameter `pBrushForeground`

The brush used to paint any text in textLayout that does not already have a brush associated with it as a drawing effect (specified by the IDWriteTextLayout::SetDrawingEffect method).

#### Parameter `options`

A value that indicates whether the text should be snapped to pixel boundaries and whether the text should be clipped to the layout rectangle. The default value is D2D1_DRAW_TEXT_OPTIONS_NONE, which indicates that text should be snapped to pixel boundaries and it should not be clipped to the layout rectangle.

### `M:CRenderTarget.DrawText(ATL.CStringT<System.Char,StrTraitMFC_DLL<System.Char,ATL.ChTraitsCRT{System.Char}>>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*,CD2DTextFormat*,D2D1_DRAW_TEXT_OPTIONS,DWRITE_MEASURING_MODE)`

Member kind: method
Symbol: `CRenderTarget.DrawText(ATL.CStringT<System.Char,StrTraitMFC_DLL<System.Char,ATL.ChTraitsCRT{System.Char}>>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*,CD2DTextFormat*,D2D1_DRAW_TEXT_OPTIONS,DWRITE_MEASURING_MODE)`

#### Summary

Draws the specified text using the format information provided by an IDWriteTextFormat object.

#### Parameter `strText`

A pointer to an array of Unicode characters to draw.

#### Parameter `rect`

The size and position of the area in which the text is drawn.

#### Parameter `pForegroundBrush`

The brush used to paint the text.

#### Parameter `textFormat`

An object that describes formatting details of the text to draw, such as the font, the font size, and flow direction.

#### Parameter `options`

A value that indicates whether the text should be snapped to pixel boundaries and whether the text should be clipped to the layout rectangle. The default value is D2D1_DRAW_TEXT_OPTIONS_NONE, which indicates that text should be snapped to pixel boundaries and it should not be clipped to the layout rectangle.

#### Parameter `measuringMode`

A value that indicates how glyph metrics are used to measure text when it is formatted. The default value is DWRITE_MEASURING_MODE_NATURAL.

### `M:CRenderTarget.FillOpacityMask(CD2DBitmap*,CD2DBrush*,D2D1_OPACITY_MASK_CONTENT,CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CRenderTarget.FillOpacityMask(CD2DBitmap*,CD2DBrush*,D2D1_OPACITY_MASK_CONTENT,CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Applies the opacity mask described by the specified bitmap to a brush and uses that brush to paint a region of the render target.

#### Parameter `pOpacityMask`

The position and radius, in device-independent pixels, of the ellipse to paint.

#### Parameter `pBrush`

The brush used to paint the region of the render target specified by destinationRectangle.

#### Parameter `content`

The type of content the opacity mask contains. The value is used to determine the color space in which the opacity mask is blended.

#### Parameter `rectDest`

The region of the render target to paint, in device-independent pixels.

#### Parameter `rectSrc`

The region of the bitmap to use as the opacity mask, in device-independent pixels.

### `M:CRenderTarget.DrawLine(CD2DPointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DPointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*,System.Single,ID2D1StrokeStyle*)`

Member kind: method
Symbol: `CRenderTarget.DrawLine(CD2DPointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DPointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*,System.Single,ID2D1StrokeStyle*)`

#### Summary

Draws a line between the specified points using the specified stroke style.

#### Parameter `ptFrom`

The start point of the line, in device-independent pixels.

#### Parameter `ptTo`

The end point of the line, in device-independent pixels.

#### Parameter `pBrush`

The brush used to paint the line's stroke.

#### Parameter `fStrokeWidth`

A value greater than or equal to 0.0f that specifies the width of the stroke. If this parameter isn't specified, it defaults to 1.0f. The stroke is centered on the line.

#### Parameter `strokeStyle`

The style of stroke to paint, or NULL to paint a solid line.

### `M:CRenderTarget.FillEllipse(CD2DEllipse!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*)`

Member kind: method
Symbol: `CRenderTarget.FillEllipse(CD2DEllipse!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*)`

#### Summary

Paints the interior of the specified ellipse.

#### Parameter `ellipse`

The position and radius, in device-independent pixels, of the ellipse to paint.

#### Parameter `pBrush`

The brush used to paint the interior of the ellipse.

### `M:CRenderTarget.DrawEllipse(CD2DEllipse!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*,System.Single,ID2D1StrokeStyle*)`

Member kind: method
Symbol: `CRenderTarget.DrawEllipse(CD2DEllipse!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*,System.Single,ID2D1StrokeStyle*)`

#### Summary

Draws the outline of the specified ellipse using the specified stroke style.

#### Parameter `ellipse`

The position and radius of the ellipse to draw, in device-independent pixels.

#### Parameter `pBrush`

The brush used to paint the ellipse's outline.

#### Parameter `fStrokeWidth`

The thickness of the ellipse's stroke. The stroke is centered on the ellipse's outline.

#### Parameter `strokeStyle`

The style of stroke to apply to the ellipse's outline, or NULL to paint a solid stroke.

### `M:CRenderTarget.FillRoundedRectangle(CD2DRoundedRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*)`

Member kind: method
Symbol: `CRenderTarget.FillRoundedRectangle(CD2DRoundedRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*)`

#### Summary

Paints the interior of the specified rounded rectangle.

#### Parameter `rectRounded`

The dimensions of the rounded rectangle to paint, in device independent pixels.

#### Parameter `pBrush`

The brush used to paint the interior of the rounded rectangle.

### `M:CRenderTarget.DrawRoundedRectangle(CD2DRoundedRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*,System.Single,ID2D1StrokeStyle*)`

Member kind: method
Symbol: `CRenderTarget.DrawRoundedRectangle(CD2DRoundedRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*,System.Single,ID2D1StrokeStyle*)`

#### Summary

Draws the outline of the specified rounded rectangle using the specified stroke style.

#### Parameter `rectRounded`

The dimensions of the rounded rectangle to draw, in device-independent pixels.

#### Parameter `pBrush`

The brush used to paint the rounded rectangle's outline.

#### Parameter `fStrokeWidth`

The width of the rounded rectangle's stroke. The stroke is centered on the rounded rectangle's outline. The default value is 1.0f.

#### Parameter `strokeStyle`

The style of the rounded rectangle's stroke, or NULL to paint a solid stroke. The default value is NULL.

### `M:CRenderTarget.FillRectangle(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*)`

Member kind: method
Symbol: `CRenderTarget.FillRectangle(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*)`

#### Summary

Paints the interior of the specified rectangle.

#### Parameter `rect`

The dimension of the rectangle to paint, in device-independent pixels.

#### Parameter `pBrush`

The brush used to paint the rectangle's interior.

### `M:CRenderTarget.DrawRectangle(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*,System.Single,ID2D1StrokeStyle*)`

Member kind: method
Symbol: `CRenderTarget.DrawRectangle(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DBrush*,System.Single,ID2D1StrokeStyle*)`

#### Summary

Draws the outline of a rectangle that has the specified dimensions and stroke style.

#### Parameter `rect`

The dimensions of the rectangle to draw, in device-independent pixels

#### Parameter `pBrush`

The brush used to paint the rectangle's stroke

#### Parameter `fStrokeWidth`

A value greater than or equal to 0.0f that specifies the width of the rectangle's stroke. The stroke is centered on the rectangle's outline.

#### Parameter `strokeStyle`

The style of stroke to paint, or NULL to paint a solid stroke.

### `M:CRenderTarget.Clear(_D3DCOLORVALUE)`

Member kind: method
Symbol: `CRenderTarget.Clear(_D3DCOLORVALUE)`

#### Summary

Clears the drawing area to the specified color.

#### Parameter `color`

The color to which the drawing area is cleared.

### `M:CRenderTarget.COLORREF_TO_D2DCOLOR(System.UInt32!System.Runtime.CompilerServices.IsLong,System.Int32)`

Member kind: method
Symbol: `CRenderTarget.COLORREF_TO_D2DCOLOR(System.UInt32!System.Runtime.CompilerServices.IsLong,System.Int32)`

#### Summary

Converts GDI color and alpha values to the D2D1_COLOR_F object.

#### Parameter `color`

RGB value.

#### Parameter `nAlpha`

Alpha value.

#### Returns

D2D1_COLOR_F value.

### `M:CRenderTarget.EndDraw`

Member kind: method
Symbol: `CRenderTarget.EndDraw`

#### Summary

Ends drawing operations on the render target and indicates the current error state and associated tags.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

### `M:CRenderTarget.BeginDraw`

Member kind: method
Symbol: `CRenderTarget.BeginDraw`

#### Summary

Initiates drawing on this render target.

### `M:CRenderTarget.Detach`

Member kind: method
Symbol: `CRenderTarget.Detach`

#### Summary

Detaches render target interface from the object

#### Returns

Pointer to detached render target interface.

### `M:CRenderTarget.Attach(ID2D1RenderTarget*)`

Member kind: method
Symbol: `CRenderTarget.Attach(ID2D1RenderTarget*)`

#### Summary

Attaches existing render target interface to the object

#### Parameter `pRenderTarget`

Existing render target interface. Cannot be NULL

### `M:CRenderTarget.GetMaximumBitmapSize`

Member kind: method
Symbol: `CRenderTarget.GetMaximumBitmapSize`

#### Summary

Gets the maximum size, in device-dependent units (pixels), of any one bitmap dimension supported by the render target

#### Returns

The maximum size, in pixels, of any one bitmap dimension supported by the render target

### `M:CRenderTarget.IsSupported(D2D1_RENDER_TARGET_PROPERTIES!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CRenderTarget.IsSupported(D2D1_RENDER_TARGET_PROPERTIES!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Indicates whether the render target supports the specified properties

#### Returns

TRUE if the specified render target properties are supported by this render target; otherwise, FALSE

#### Parameter `renderTargetProperties`

The render target properties to test

### `M:CRenderTarget.SetTags(System.UInt64,System.UInt64)`

Member kind: method
Symbol: `CRenderTarget.SetTags(System.UInt64,System.UInt64)`

#### Summary

Specifies a label for subsequent drawing operations.

#### Parameter `tag1`

A label to apply to subsequent drawing operations.

#### Parameter `tag2`

A label to apply to subsequent drawing operations.

### `M:CRenderTarget.GetTags(System.UInt64*,System.UInt64*)`

Member kind: method
Symbol: `CRenderTarget.GetTags(System.UInt64*,System.UInt64*)`

#### Summary

Gets the label for subsequent drawing operations.

#### Parameter `tag1`

Contains the first label for subsequent drawing operations. This parameter is passed uninitialized. If NULL is specified, no value is retrieved for this parameter.

#### Parameter `tag2`

Contains the second label for subsequent drawing operations. This parameter is passed uninitialized. If NULL is specified, no value is retrieved for this parameter.

### `M:CRenderTarget.GetPixelSize`

Member kind: method
Symbol: `CRenderTarget.GetPixelSize`

#### Summary

Returns the size of the render target in device pixels

#### Returns

The size of the render target in device pixels

### `M:CRenderTarget.GetPixelFormat`

Member kind: method
Symbol: `CRenderTarget.GetPixelFormat`

#### Summary

Retrieves the pixel format and alpha mode of the render target

#### Returns

The pixel format and alpha mode of the render target

### `M:CRenderTarget.GetDpi`

Member kind: method
Symbol: `CRenderTarget.GetDpi`

#### Summary

Returns the render target's dots per inch (DPI)

#### Returns

The render target's dots per inch (DPI).

### `M:CRenderTarget.SetDpi(CD2DSizeF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CRenderTarget.SetDpi(CD2DSizeF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Sets the dots per inch (DPI) of the render target.

#### Parameter `sizeDPI`

A value greater than or equal to zero that specifies the horizontal/verticalDPI of the render target.

### `M:CRenderTarget.GetSize`

Member kind: method
Symbol: `CRenderTarget.GetSize`

#### Summary

Returns the size of the render target in device-independent pixels

#### Returns

The current size of the render target in device-independent pixels

### `M:CRenderTarget.op_Implicit~ID2D1RenderTarget*`

Member kind: method
Symbol: `CRenderTarget.op_Implicit~ID2D1RenderTarget*`

#### Summary

Returns ID2D1RenderTarget interface

#### Returns

Pointer to an ID2D1RenderTarget interface or NULL if object is not initialized yet.

### `M:CRenderTarget.GetRenderTarget`

Member kind: method
Symbol: `CRenderTarget.GetRenderTarget`

#### Summary

Returns ID2D1RenderTarget interface

#### Returns

Pointer to an ID2D1RenderTarget interface or NULL if object is not initialized yet.

### `M:CRenderTarget.IsValid`

Member kind: method
Symbol: `CRenderTarget.IsValid`

#### Summary

Checks resource validity

#### Returns

TRUE if resource is valid; otherwise FALSE.

### `M:CRenderTarget.Destroy(System.Int32)`

Member kind: method
Symbol: `CRenderTarget.Destroy(System.Int32)`

#### Summary

Deletes one or more resources

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE

#### Parameter `bDeleteResources`

If bDeleteResources is TRUE, all resources located in m_lstResources will be automatically destroyed.

### `M:CRenderTarget.Dispose`

Member kind: method
Symbol: `CRenderTarget.Dispose`

#### Summary

The destructor. Called when a render target object is being destroyed.

### `M:CRenderTarget.#ctor`

Member kind: method
Symbol: `CRenderTarget.#ctor`

#### Summary

Constructs a CRenderTarget object.

### `T:CRenderTarget`

Member kind: type
Symbol: `CRenderTarget`

#### Summary

ID2D1RenderTarget wrapper.

### `F:CD2DMesh.m_pMesh`

Member kind: field
Symbol: `CD2DMesh.m_pMesh`

#### Summary

A pointer to an ID2D1Mesh.

### `M:CD2DMesh.IsValid`

Member kind: method
Symbol: `CD2DMesh.IsValid`

#### Summary

Checks resource validity

#### Returns

TRUE if resource is valid; otherwise FALSE.

### `M:CD2DMesh.Destroy`

Member kind: method
Symbol: `CD2DMesh.Destroy`

#### Summary

Destroys a CD2DMesh object.

### `M:CD2DMesh.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DMesh.Create(CRenderTarget*)`

#### Summary

Creates a CD2DMesh.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DMesh.Open`

Member kind: method
Symbol: `CD2DMesh.Open`

#### Summary

Opens the mesh for population.

#### Returns

A pointer to an ID2D1TessellationSink that is used to populate the mesh.

### `M:CD2DMesh.op_Implicit~ID2D1Mesh*`

Member kind: method
Symbol: `CD2DMesh.op_Implicit~ID2D1Mesh*`

#### Summary

Returns ID2D1Mesh interface

#### Returns

Pointer to an ID2D1Mesh interface or NULL if object is not initialized yet.

### `M:CD2DMesh.Get`

Member kind: method
Symbol: `CD2DMesh.Get`

#### Summary

Returns ID2D1Mesh interface

#### Returns

Pointer to an ID2D1Mesh interface or NULL if object is not initialized yet.

### `M:CD2DMesh.Detach`

Member kind: method
Symbol: `CD2DMesh.Detach`

#### Summary

Detaches resource interface from the object

#### Returns

Pointer to detached resource interface.

### `M:CD2DMesh.Attach(ID2D1Mesh*)`

Member kind: method
Symbol: `CD2DMesh.Attach(ID2D1Mesh*)`

#### Summary

Attaches existing resource interface to the object

#### Parameter `pResource`

Existing resource interface. Cannot be NULL

### `M:CD2DMesh.Dispose`

Member kind: method
Symbol: `CD2DMesh.Dispose`

#### Summary

The destructor. Called when a D2D mesh object is being destroyed.

### `M:CD2DMesh.#ctor(CRenderTarget*,System.Int32)`

Member kind: method
Symbol: `CD2DMesh.#ctor(CRenderTarget*,System.Int32)`

#### Summary

Constructs a CD2DMesh object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DMesh`

Member kind: type
Symbol: `CD2DMesh`

#### Summary

ID2D1Mesh wrapper.

### `F:CD2DGeometrySink.m_pSink`

Member kind: field
Symbol: `CD2DGeometrySink.m_pSink`

#### Summary

A pointer to an ID2D1GeometrySink.

### `M:CD2DGeometrySink.SetSegmentFlags(D2D1_PATH_SEGMENT)`

Member kind: method
Symbol: `CD2DGeometrySink.SetSegmentFlags(D2D1_PATH_SEGMENT)`

#### Summary

Specifies stroke and join options to be applied to new segments added to the geometry sink.

#### Parameter `vertexFlags`

Stroke and join options to be applied to new segments added to the geometry sink.

### `M:CD2DGeometrySink.SetFillMode(D2D1_FILL_MODE)`

Member kind: method
Symbol: `CD2DGeometrySink.SetFillMode(D2D1_FILL_MODE)`

#### Summary

Specifies the method used to determine which points are inside the geometry described by this geometry sink and which points are outside.

#### Parameter `fillMode`

The method used to determine whether a given point is part of the geometry.

### `M:CD2DGeometrySink.Close`

Member kind: method
Symbol: `CD2DGeometrySink.Close`

#### Summary

Closes the geometry sink

#### Returns

Nonzero if successful; otherwise FALSE.

### `M:CD2DGeometrySink.AddLines(CArray<CD2DPointF,CD2DPointF>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DGeometrySink.AddLines(CArray<CD2DPointF,CD2DPointF>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Creates a sequence of lines using the specified points and adds them to the geometry sink.

#### Parameter `points`

An array of one or more points that describe the lines to draw. A line is drawn from the geometry sink's current point (the end point of the last segment drawn or the location specified by BeginFigure) to the first point in the array. if the array contains additional points, a line is drawn from the first point to the second point in the array, from the second point to the third point, and so on. An array of a sequence of the end points of the lines to draw.

### `M:CD2DGeometrySink.AddLine(CD2DPointF)`

Member kind: method
Symbol: `CD2DGeometrySink.AddLine(CD2DPointF)`

#### Summary

Creates a line segment between the current point and the specified end point and adds it to the geometry sink.

#### Parameter `point`

The end point of the line to draw.

### `M:CD2DGeometrySink.AddQuadraticBeziers(CArray<D2D1_QUADRATIC_BEZIER_SEGMENT,D2D1_QUADRATIC_BEZIER_SEGMENT>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DGeometrySink.AddQuadraticBeziers(CArray<D2D1_QUADRATIC_BEZIER_SEGMENT,D2D1_QUADRATIC_BEZIER_SEGMENT>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Adds a sequence of quadratic Bezier segments as an array in a single call.

#### Parameter `beziers`

An array of a sequence of quadratic Bezier segments.

### `M:CD2DGeometrySink.AddQuadraticBezier(D2D1_QUADRATIC_BEZIER_SEGMENT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DGeometrySink.AddQuadraticBezier(D2D1_QUADRATIC_BEZIER_SEGMENT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Creates a quadratic Bezier curve between the current point and the specified end point.

#### Parameter `bezier`

A structure that describes the control point and the end point of the quadratic Bezier curve to add.

### `M:CD2DGeometrySink.AddBeziers(CArray<D2D1_BEZIER_SEGMENT,D2D1_BEZIER_SEGMENT>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DGeometrySink.AddBeziers(CArray<D2D1_BEZIER_SEGMENT,D2D1_BEZIER_SEGMENT>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Creates a sequence of cubic Bezier curves and adds them to the geometry sink.

#### Parameter `beziers`

An array of Bezier segments that describes the Bezier curves to create. A curve is drawn from the geometry sink's current point (the end point of the last segment drawn or the location specified by BeginFigure) to the end point of the first Bezier segment in the array. if the array contains additional Bezier segments, each subsequent Bezier segment uses the end point of the preceding Bezier segment as its start point.

### `M:CD2DGeometrySink.AddBezier(D2D1_BEZIER_SEGMENT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DGeometrySink.AddBezier(D2D1_BEZIER_SEGMENT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Creates a cubic Bezier curve between the current point and the specified end point.

#### Parameter `bezier`

A structure that describes the control points and end point of the Bezier curve to add.

### `M:CD2DGeometrySink.AddArc(D2D1_ARC_SEGMENT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DGeometrySink.AddArc(D2D1_ARC_SEGMENT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Adds a single arc to the path geometry

#### Parameter `arc`

The arc segment to add to the figure

### `M:CD2DGeometrySink.EndFigure(D2D1_FIGURE_END)`

Member kind: method
Symbol: `CD2DGeometrySink.EndFigure(D2D1_FIGURE_END)`

#### Summary

Ends the current figure; optionally, closes it.

#### Parameter `figureEnd`

A value that indicates whether the current figure is closed. If the figure is closed, a line is drawn between the current point and the start point specified by BeginFigure.

### `M:CD2DGeometrySink.BeginFigure(CD2DPointF,D2D1_FIGURE_BEGIN)`

Member kind: method
Symbol: `CD2DGeometrySink.BeginFigure(CD2DPointF,D2D1_FIGURE_BEGIN)`

#### Summary

Starts a new figure at the specified point.

#### Parameter `startPoint`

The point at which to begin the new figure.

#### Parameter `figureBegin`

Whether the new figure should be hollow or filled.

### `M:CD2DGeometrySink.op_Implicit~ID2D1GeometrySink*`

Member kind: method
Symbol: `CD2DGeometrySink.op_Implicit~ID2D1GeometrySink*`

#### Summary

Returns ID2D1GeometrySink interface

#### Returns

Pointer to an ID2D1GeometrySink interface or NULL if object is not initialized yet.

### `M:CD2DGeometrySink.Get`

Member kind: method
Symbol: `CD2DGeometrySink.Get`

#### Summary

Returns ID2D1GeometrySink interface

#### Returns

Pointer to an ID2D1GeometrySink interface or NULL if object is not initialized yet.

### `M:CD2DGeometrySink.IsValid`

Member kind: method
Symbol: `CD2DGeometrySink.IsValid`

#### Summary

Checks geometry sink validity

#### Returns

TRUE if geometry sink is valid; otherwise FALSE.

### `M:CD2DGeometrySink.Dispose`

Member kind: method
Symbol: `CD2DGeometrySink.Dispose`

#### Summary

The destructor. Called when a D2D geometry sink object is being destroyed.

### `M:CD2DGeometrySink.#ctor(CD2DPathGeometry*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DGeometrySink.#ctor(CD2DPathGeometry*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DGeometrySink object from CD2DPathGeometry object.

#### Parameter `pathGeometry`

An existing CD2DPathGeometry object.

### `T:CD2DGeometrySink`

Member kind: type
Symbol: `CD2DGeometrySink`

#### Summary

ID2D1GeometrySink wrapper.

### `F:CD2DPathGeometry.m_pPathGeometry`

Member kind: field
Symbol: `CD2DPathGeometry.m_pPathGeometry`

#### Summary

A pointer to an ID2D1PathGeometry.

### `M:CD2DPathGeometry.GetFigureCount`

Member kind: method
Symbol: `CD2DPathGeometry.GetFigureCount`

#### Summary

Retrieves tthe number of figures in the path geometry.

#### Returns

Returns the number of figures in the path geometry.

### `M:CD2DPathGeometry.GetSegmentCount`

Member kind: method
Symbol: `CD2DPathGeometry.GetSegmentCount`

#### Summary

Retrieves the number of segments in the path geometry.

#### Returns

Returns the number of segments in the path geometry.

### `M:CD2DPathGeometry.Stream(ID2D1GeometrySink*)`

Member kind: method
Symbol: `CD2DPathGeometry.Stream(ID2D1GeometrySink*)`

#### Summary

Copies the contents of the path geometry to the specified ID2D1GeometrySink.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `geometrySink`

The sink to which the path geometry's contents are copied. Modifying this sink does not change the contents of this path geometry.

### `M:CD2DPathGeometry.Open`

Member kind: method
Symbol: `CD2DPathGeometry.Open`

#### Summary

Retrieves the geometry sink that is used to populate the path geometry with figures and segments.

#### Returns

A pointer to the ID2D1GeometrySink that is used to populate the path geometry with figures and segments.

### `M:CD2DPathGeometry.Detach`

Member kind: method
Symbol: `CD2DPathGeometry.Detach`

#### Summary

Detaches resource interface from the object

#### Returns

Pointer to detached resource interface.

### `M:CD2DPathGeometry.Attach(ID2D1PathGeometry*)`

Member kind: method
Symbol: `CD2DPathGeometry.Attach(ID2D1PathGeometry*)`

#### Summary

Attaches existing resource interface to the object

#### Parameter `pResource`

Existing resource interface. Cannot be NULL

### `M:CD2DPathGeometry.Destroy`

Member kind: method
Symbol: `CD2DPathGeometry.Destroy`

#### Summary

Destroys a CD2DPathGeometry object.

### `M:CD2DPathGeometry.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DPathGeometry.Create(CRenderTarget*)`

#### Summary

Creates a CD2DPathGeometry.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DPathGeometry.#ctor(CRenderTarget*,System.Int32)`

Member kind: method
Symbol: `CD2DPathGeometry.#ctor(CRenderTarget*,System.Int32)`

#### Summary

Constructs a CD2DPathGeometry object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DPathGeometry`

Member kind: type
Symbol: `CD2DPathGeometry`

#### Summary

ID2D1PathGeometry wrapper.

### `F:CD2DGeometry.m_pGeometry`

Member kind: field
Symbol: `CD2DGeometry.m_pGeometry`

#### Summary

A pointer to an ID2D1Geometry.

### `M:CD2DGeometry.Widen(System.Single,ID2D1StrokeStyle*,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,ID2D1SimplifiedGeometrySink*,System.Single)`

Member kind: method
Symbol: `CD2DGeometry.Widen(System.Single,ID2D1StrokeStyle*,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,ID2D1SimplifiedGeometrySink*,System.Single)`

#### Summary

Widens the geometry by the specified stroke and writes the result to an ID2D1SimplifiedGeometrySink after it has been transformed by the specified matrix and flattened using the specified tolerance.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `strokeWidth`

The amount by which to widen the geometry.

#### Parameter `strokeStyle`

The style of stroke to apply to the geometry, or NULL.

#### Parameter `worldTransform`

The transform to apply to the geometry after widening it.

#### Parameter `geometrySink`

The ID2D1SimplifiedGeometrySink to which the widened geometry is appended.

#### Parameter `flatteningTolerance`

The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.

### `M:CD2DGeometry.Tessellate(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,ID2D1TessellationSink*,System.Single)`

Member kind: method
Symbol: `CD2DGeometry.Tessellate(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,ID2D1TessellationSink*,System.Single)`

#### Summary

Creates a set of clockwise-wound triangles that cover the geometry after it has been transformed using the specified matrix and flattened using the specified tolerance.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `worldTransform`

The transform to apply to this geometry, or NULL.

#### Parameter `tessellationSink`

The ID2D1TessellationSink to which the tessellated is appended.

#### Parameter `flatteningTolerance`

The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.

### `M:CD2DGeometry.Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,ID2D1SimplifiedGeometrySink*,System.Single)`

Member kind: method
Symbol: `CD2DGeometry.Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,ID2D1SimplifiedGeometrySink*,System.Single)`

#### Summary

Creates a simplified version of the geometry that contains only lines and (optionally) cubic Bezier curves and writes the result to an ID2D1SimplifiedGeometrySink.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `simplificationOption`

A value that specifies whether the simplified geometry should contain curves.

#### Parameter `worldTransform`

The transform to apply to the simplified geometry.

#### Parameter `geometrySink`

The ID2D1SimplifiedGeometrySink to which the simplified geometry is appended.

#### Parameter `flatteningTolerance`

The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.

### `M:CD2DGeometry.Outline(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,ID2D1SimplifiedGeometrySink*,System.Single)`

Member kind: method
Symbol: `CD2DGeometry.Outline(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,ID2D1SimplifiedGeometrySink*,System.Single)`

#### Summary

Computes the outline of the geometry and writes the result to an ID2D1SimplifiedGeometrySink.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `worldTransform`

The transform to apply to the geometry outline.

#### Parameter `geometrySink`

The ID2D1SimplifiedGeometrySink to which the geometry transformed outline is appended.

#### Parameter `flatteningTolerance`

The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.

### `M:CD2DGeometry.StrokeContainsPoint(CD2DPointF,System.Single,ID2D1StrokeStyle*,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Int32*,System.Single)`

Member kind: method
Symbol: `CD2DGeometry.StrokeContainsPoint(CD2DPointF,System.Single,ID2D1StrokeStyle*,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Int32*,System.Single)`

#### Summary

Determines whether the geometry's stroke contains the specified point given the specified stroke thickness, style, and transform.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `point`

The point to test for containment.

#### Parameter `strokeWidth`

The thickness of the stroke to apply.

#### Parameter `strokeStyle`

The style of the stroke to apply.

#### Parameter `worldTransform`

The transform to apply to the stroked geometry.

#### Parameter `contains`

When this method returns, contains a boolean value set to TRUE if the geometry's stroke contains the specified point; otherwise, FALSE. You must allocate storage for this parameter.

#### Parameter `flatteningTolerance`

The numeric accuracy with which the precise geometric path and path intersection is calculated. Points missing the stroke by less than the tolerance are still considered inside. Smaller values produce more accurate results but cause slower execution.

### `M:CD2DGeometry.FillContainsPoint(CD2DPointF,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Int32*,System.Single)`

Member kind: method
Symbol: `CD2DGeometry.FillContainsPoint(CD2DPointF,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Int32*,System.Single)`

#### Summary

Indicates whether the area filled by the geometry would contain the specified point given the specified flattening tolerance.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `point`

The point to test.

#### Parameter `worldTransform`

The transform to apply to the geometry prior to testing for containment.

#### Parameter `contains`

When this method returns, contains a bool value that is TRUE if the area filled by the geometry contains point; otherwise, FALSE. You must allocate storage for this parameter.

#### Parameter `flatteningTolerance`

The numeric accuracy with which the precise geometric path and path intersection is calculated. Points missing the fill by less than the tolerance are still considered inside. Smaller values produce more accurate results but cause slower execution.

### `M:CD2DGeometry.GetWidenedBounds(System.Single,ID2D1StrokeStyle*,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DRectF*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single)`

Member kind: method
Symbol: `CD2DGeometry.GetWidenedBounds(System.Single,ID2D1StrokeStyle*,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DRectF*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single)`

#### Summary

Gets the bounds of the geometry after it has been widened by the specified stroke width and style and transformed by the specified matrix.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `strokeWidth`

The amount by which to widen the geometry by stroking its outline.

#### Parameter `strokeStyle`

The style of the stroke that widens the geometry.

#### Parameter `worldTransform`

A transform to apply to the geometry after the geometry is transformed and after the geometry has been stroked.

#### Parameter `bounds`

When this method returns, contains the bounds of the widened geometry. You must allocate storage for this parameter.

#### Parameter `flatteningTolerance`

The maximum bounds on the distance between points in the polygonal approximation of the geometries. Smaller values produce more accurate results but cause slower execution.

### `M:CD2DGeometry.GetBounds(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DRectF*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DGeometry.GetBounds(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DRectF*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Retrieves the bounds of the geometry.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `worldTransform`

The transform to apply to this geometry before calculating its bounds.

#### Parameter `bounds`

When this method returns, contains the bounds of this geometry. If the bounds are empty, this will be a rect where bounds.left is greater than bounds.right. You must allocate storage for this parameter.

### `M:CD2DGeometry.ComputePointAtLength(System.Single,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DPointF*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DPointF*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single)`

Member kind: method
Symbol: `CD2DGeometry.ComputePointAtLength(System.Single,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DPointF*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DPointF*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single)`

#### Summary

Calculates the point and tangent vector at the specified distance along the geometry after it has been transformed by the specified matrix and flattened using the specified tolerance.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `length`

The distance along the geometry of the point and tangent to find. If this distance is less then 0, this method calculates the first point in the geometry. If this distance is greater than the length of the geometry, this method calculates the last point in the geometry.

#### Parameter `worldTransform`

The transform to apply to the geometry before calculating the specified point and tangent.

#### Parameter `point`

The location at the specified distance along the geometry. If the geometry is empty, this point contains NaN as its x and y values.

#### Parameter `unitTangentVector`

When this method returns, contains a pointer to the tangent vector at the specified distance along the geometry. If the geometry is empty, this vector contains NaN as its x and y values. You must allocate storage for this parameter.

#### Parameter `flatteningTolerance`

The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.

### `M:CD2DGeometry.ComputeLength(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single)`

Member kind: method
Symbol: `CD2DGeometry.ComputeLength(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single)`

#### Summary

Calculates the length of the geometry as though each segment were unrolled into a line.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `worldTransform`

The transform to apply to the geometry before calculating its length.

#### Parameter `length`

When this method returns, contains a pointer to the length of the geometry. For closed geometries, the length includes an implicit closing segment. You must allocate storage for this parameter.

#### Parameter `flatteningTolerance`

The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.

### `M:CD2DGeometry.ComputeArea(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single)`

Member kind: method
Symbol: `CD2DGeometry.ComputeArea(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single)`

#### Summary

Computes the area of the geometry after it has been transformed by the specified matrix and flattened using the specified tolerance.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `worldTransform`

The transform to apply to this geometry before computing its area.

#### Parameter `area`

When this method returns, contains a pointer to the area of the transformed, flattened version of this geometry. You must allocate storage for this parameter.

#### Parameter `flatteningTolerance`

The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.

### `M:CD2DGeometry.CompareWithGeometry(CD2DGeometry*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single)`

Member kind: method
Symbol: `CD2DGeometry.CompareWithGeometry(CD2DGeometry*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single)`

#### Summary

Describes the intersection between this geometry and the specified geometry. The comparison is performed using the specified flattening tolerance.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `inputGeometry`

The geometry to test.

#### Parameter `inputGeometryTransform`

The transform to apply to inputGeometry.

#### Parameter `flatteningTolerance`

The maximum bounds on the distance between points in the polygonal approximation of the geometries. Smaller values produce more accurate results but cause slower execution.

### `M:CD2DGeometry.CombineWithGeometry(CD2DGeometry*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,D2D1_COMBINE_MODE,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,ID2D1SimplifiedGeometrySink*,System.Single)`

Member kind: method
Symbol: `CD2DGeometry.CombineWithGeometry(CD2DGeometry*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,D2D1_COMBINE_MODE,D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,ID2D1SimplifiedGeometrySink*,System.Single)`

#### Summary

Combines this geometry with the specified geometry and stores the result in an ID2D1SimplifiedGeometrySink.

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.

#### Parameter `inputGeometry`

The geometry to combine with this instance.

#### Parameter `combineMode`

The type of combine operation to perform.

#### Parameter `inputGeometryTransform`

The transform to apply to inputGeometry before combining.

#### Parameter `geometrySink`

The result of the combine operation.

#### Parameter `flatteningTolerance`

The maximum bounds on the distance between points in the polygonal approximation of the geometries. Smaller values produce more accurate results but cause slower execution.

### `M:CD2DGeometry.IsValid`

Member kind: method
Symbol: `CD2DGeometry.IsValid`

#### Summary

Checks resource validity

#### Returns

TRUE if resource is valid; otherwise FALSE.

### `M:CD2DGeometry.Destroy`

Member kind: method
Symbol: `CD2DGeometry.Destroy`

#### Summary

Destroys a CD2DGeometry object.

### `M:CD2DGeometry.op_Implicit~ID2D1Geometry*`

Member kind: method
Symbol: `CD2DGeometry.op_Implicit~ID2D1Geometry*`

#### Summary

Returns ID2D1Geometry interface

#### Returns

Pointer to an ID2D1Geometry interface or NULL if object is not initialized yet.

### `M:CD2DGeometry.Get`

Member kind: method
Symbol: `CD2DGeometry.Get`

#### Summary

Returns ID2D1Geometry interface

#### Returns

Pointer to an ID2D1Geometry interface or NULL if object is not initialized yet.

### `M:CD2DGeometry.Detach`

Member kind: method
Symbol: `CD2DGeometry.Detach`

#### Summary

Detaches resource interface from the object

#### Returns

Pointer to detached resource interface.

### `M:CD2DGeometry.Attach(ID2D1Geometry*)`

Member kind: method
Symbol: `CD2DGeometry.Attach(ID2D1Geometry*)`

#### Summary

Attaches existing resource interface to the object

#### Parameter `pResource`

Existing resource interface. Cannot be NULL

### `M:CD2DGeometry.Dispose`

Member kind: method
Symbol: `CD2DGeometry.Dispose`

#### Summary

The destructor. Called when a D2D geometry object is being destroyed.

### `M:CD2DGeometry.#ctor(CRenderTarget*,System.Int32)`

Member kind: method
Symbol: `CD2DGeometry.#ctor(CRenderTarget*,System.Int32)`

#### Summary

Constructs a CD2DGeometry object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DGeometry`

Member kind: type
Symbol: `CD2DGeometry`

#### Summary

ID2D1Geometry wrapper.

### `F:CD2DTextLayout.m_pTextLayout`

Member kind: field
Symbol: `CD2DTextLayout.m_pTextLayout`

#### Summary

A pointer to an IDWriteTextLayout.

### `M:CD2DTextLayout.GetLocaleName(System.UInt32,DWRITE_TEXT_RANGE*)`

Member kind: method
Symbol: `CD2DTextLayout.GetLocaleName(System.UInt32,DWRITE_TEXT_RANGE*)`

#### Summary

Gets the locale name of the text at the specified position.

#### Returns

CString object that contains the current locale name.

#### Parameter `currentPosition`

The position of the text to inspect.

#### Parameter `textRange`

The range of text that has the same formatting as the text at the position specified by currentPosition. This means the run has the exact formatting as the position specified, including but not limited to the locale name.

### `M:CD2DTextLayout.GetFontFamilyName(System.UInt32,DWRITE_TEXT_RANGE*)`

Member kind: method
Symbol: `CD2DTextLayout.GetFontFamilyName(System.UInt32,DWRITE_TEXT_RANGE*)`

#### Summary

Copies the font family name of the text at the specified position.

#### Returns

CString object that contains the current font family name.

#### Parameter `currentPosition`

The position of the text to examine.

#### Parameter `textRange`

The range of text that has the same formatting as the text at the position specified by currentPosition. This means the run has the exact formatting as the position specified, including but not limited to the font family name.

### `M:CD2DTextLayout.SetLocaleName(System.Char!System.Runtime.CompilerServices.IsConst*,DWRITE_TEXT_RANGE)`

Member kind: method
Symbol: `CD2DTextLayout.SetLocaleName(System.Char!System.Runtime.CompilerServices.IsConst*,DWRITE_TEXT_RANGE)`

#### Summary

Sets the locale name for text within a specified text range

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE

#### Parameter `pwzLocaleName`

A null-terminated locale name string

#### Parameter `textRange`

Text range to which this change applies

### `M:CD2DTextLayout.SetFontFamilyName(System.Char!System.Runtime.CompilerServices.IsConst*,DWRITE_TEXT_RANGE)`

Member kind: method
Symbol: `CD2DTextLayout.SetFontFamilyName(System.Char!System.Runtime.CompilerServices.IsConst*,DWRITE_TEXT_RANGE)`

#### Summary

Sets null-terminated font family name for text within a specified text range

#### Returns

If the method succeeds, it returns TRUE. Otherwise, it returns FALSE

#### Parameter `pwzFontFamilyName`

The font family name that applies to the entire text string within the range specified by textRange

#### Parameter `textRange`

Text range to which this change applies

### `M:CD2DTextLayout.op_Implicit~IDWriteTextLayout*`

Member kind: method
Symbol: `CD2DTextLayout.op_Implicit~IDWriteTextLayout*`

#### Summary

Returns IDWriteTextLayout interface

#### Returns

Pointer to an IDWriteTextLayout interface or NULL if object is not initialized yet.

### `M:CD2DTextLayout.Get`

Member kind: method
Symbol: `CD2DTextLayout.Get`

#### Summary

Returns IDWriteTextLayout interface

#### Returns

Pointer to an IDWriteTextLayout interface or NULL if object is not initialized yet.

### `M:CD2DTextLayout.IsValid`

Member kind: method
Symbol: `CD2DTextLayout.IsValid`

#### Summary

Checks resource validity

#### Returns

TRUE if resource is valid; otherwise FALSE.

### `M:CD2DTextLayout.Destroy`

Member kind: method
Symbol: `CD2DTextLayout.Destroy`

#### Summary

Destroys a CD2DTextLayout object.

### `M:CD2DTextLayout.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DTextLayout.Create(CRenderTarget*)`

#### Summary

Creates a CD2DTextLayout.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DTextLayout.ReCreate(CRenderTarget*)`

Member kind: method
Symbol: `CD2DTextLayout.ReCreate(CRenderTarget*)`

#### Summary

Re-creates a CD2DTextLayout.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DTextLayout.Dispose`

Member kind: method
Symbol: `CD2DTextLayout.Dispose`

#### Summary

The destructor. Called when a D2D text layout object is being destroyed.

### `M:CD2DTextLayout.#ctor(CRenderTarget*,ATL.CStringT<System.Char,StrTraitMFC_DLL<System.Char,ATL.ChTraitsCRT{System.Char}>>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DTextFormat*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DSizeF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Int32)`

Member kind: method
Symbol: `CD2DTextLayout.#ctor(CRenderTarget*,ATL.CStringT<System.Char,StrTraitMFC_DLL<System.Char,ATL.ChTraitsCRT{System.Char}>>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DTextFormat*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DSizeF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Int32)`

#### Summary

Constructs a CD2DTextLayout object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `strText`

A CString object that contains the string to create a new CD2DTextLayout object from.

#### Parameter `textFormat`

A CString object that contains the format to apply to the string.

#### Parameter `sizeMax`

The size of the layout box.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DTextLayout`

Member kind: type
Symbol: `CD2DTextLayout`

#### Summary

IDWriteTextLayout wrapper.

### `F:CD2DTextFormat.m_pTextFormat`

Member kind: field
Symbol: `CD2DTextFormat.m_pTextFormat`

#### Summary

A pointer to an IDWriteTextFormat.

### `M:CD2DTextFormat.GetLocaleName`

Member kind: method
Symbol: `CD2DTextFormat.GetLocaleName`

#### Summary

Gets a copy of the locale name.

#### Returns

CString object that contains the current locale name.

### `M:CD2DTextFormat.GetFontFamilyName`

Member kind: method
Symbol: `CD2DTextFormat.GetFontFamilyName`

#### Summary

Gets a copy of the font family name.

#### Returns

CString object that contains the current font family name.

### `M:CD2DTextFormat.op_Implicit~IDWriteTextFormat*`

Member kind: method
Symbol: `CD2DTextFormat.op_Implicit~IDWriteTextFormat*`

#### Summary

Returns IDWriteTextFormat interface

#### Returns

Pointer to an IDWriteTextFormat interface or NULL if object is not initialized yet.

### `M:CD2DTextFormat.Get`

Member kind: method
Symbol: `CD2DTextFormat.Get`

#### Summary

Returns IDWriteTextFormat interface

#### Returns

Pointer to an IDWriteTextFormat interface or NULL if object is not initialized yet.

### `M:CD2DTextFormat.IsValid`

Member kind: method
Symbol: `CD2DTextFormat.IsValid`

#### Summary

Checks resource validity

#### Returns

TRUE if resource is valid; otherwise FALSE.

### `M:CD2DTextFormat.Destroy`

Member kind: method
Symbol: `CD2DTextFormat.Destroy`

#### Summary

Destroys a CD2DTextFormat object.

### `M:CD2DTextFormat.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DTextFormat.Create(CRenderTarget*)`

#### Summary

Creates a CD2DTextFormat.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DTextFormat.ReCreate(CRenderTarget*)`

Member kind: method
Symbol: `CD2DTextFormat.ReCreate(CRenderTarget*)`

#### Summary

Re-creates a CD2DTextFormat.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DTextFormat.Dispose`

Member kind: method
Symbol: `CD2DTextFormat.Dispose`

#### Summary

The destructor. Called when a D2D text format object is being destroyed.

### `M:CD2DTextFormat.#ctor(CRenderTarget*,ATL.CStringT<System.Char,StrTraitMFC_DLL<System.Char,ATL.ChTraitsCRT{System.Char}>>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single,DWRITE_FONT_WEIGHT,DWRITE_FONT_STYLE,DWRITE_FONT_STRETCH,ATL.CStringT<System.Char,StrTraitMFC_DLL<System.Char,ATL.ChTraitsCRT{System.Char}>>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,IDWriteFontCollection*,System.Int32)`

Member kind: method
Symbol: `CD2DTextFormat.#ctor(CRenderTarget*,ATL.CStringT<System.Char,StrTraitMFC_DLL<System.Char,ATL.ChTraitsCRT{System.Char}>>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.Single,DWRITE_FONT_WEIGHT,DWRITE_FONT_STYLE,DWRITE_FONT_STRETCH,ATL.CStringT<System.Char,StrTraitMFC_DLL<System.Char,ATL.ChTraitsCRT{System.Char}>>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,IDWriteFontCollection*,System.Int32)`

#### Summary

Constructs a CD2DTextFormat object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `strFontFamilyName`

A CString object that contains the name of the font family.

#### Parameter `fontSize`

The logical size of the font in DIP ("device-independent pixel") units. A DIPequals 1/96 inch.

#### Parameter `fontWeight`

A value that indicates the font weight for the text object.

#### Parameter `fontStyle`

A value that indicates the font style for the text object.

#### Parameter `fontStretch`

A value that indicates the font stretch for the text object.

#### Parameter `strFontLocale`

A CString object that contains the locale name.

#### Parameter `pFontCollection`

A pointer to a font collection object. When this is NULL, indicates the system font collection.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DTextFormat`

Member kind: type
Symbol: `CD2DTextFormat`

#### Summary

IDWriteTextFormat wrapper.

### `F:CD2DRadialGradientBrush.m_pRadialGradientBrush`

Member kind: field
Symbol: `CD2DRadialGradientBrush.m_pRadialGradientBrush`

#### Summary

A pointer to an ID2D1RadialGradientBrush.

### `F:CD2DRadialGradientBrush.m_RadialGradientBrushProperties`

Member kind: field
Symbol: `CD2DRadialGradientBrush.m_RadialGradientBrushProperties`

#### Summary

The center, gradient origin offset, and x-radius and y-radius of the brush's gradient.

### `M:CD2DRadialGradientBrush.GetRadiusY`

Member kind: method
Symbol: `CD2DRadialGradientBrush.GetRadiusY`

#### Summary

Retrieves the y-radius of the gradient ellipse

#### Returns

The y-radius of the gradient ellipse. This value is expressed in the brush's coordinate space

### `M:CD2DRadialGradientBrush.GetRadiusX`

Member kind: method
Symbol: `CD2DRadialGradientBrush.GetRadiusX`

#### Summary

Retrieves the x-radius of the gradient ellipse

#### Returns

The x-radius of the gradient ellipse. This value is expressed in the brush's coordinate space

### `M:CD2DRadialGradientBrush.GetGradientOriginOffset`

Member kind: method
Symbol: `CD2DRadialGradientBrush.GetGradientOriginOffset`

#### Summary

Retrieves the offset of the gradient origin relative to the gradient ellipse's center

#### Returns

The offset of the gradient origin from the center of the gradient ellipse. This value is expressed in the brush's coordinate space

### `M:CD2DRadialGradientBrush.GetCenter`

Member kind: method
Symbol: `CD2DRadialGradientBrush.GetCenter`

#### Summary

Retrieves the center of the gradient ellipse

#### Returns

The center of the gradient ellipse. This value is expressed in the brush's coordinate space

### `M:CD2DRadialGradientBrush.SetRadiusY(System.Single)`

Member kind: method
Symbol: `CD2DRadialGradientBrush.SetRadiusY(System.Single)`

#### Summary

Specifies the y-radius of the gradient ellipse, in the brush's coordinate space

#### Parameter `radiusY`

The y-radius of the gradient ellipse. This value is in the brush's coordinate space

### `M:CD2DRadialGradientBrush.SetRadiusX(System.Single)`

Member kind: method
Symbol: `CD2DRadialGradientBrush.SetRadiusX(System.Single)`

#### Summary

Specifies the x-radius of the gradient ellipse, in the brush's coordinate space

#### Parameter `radiusX`

The x-radius of the gradient ellipse. This value is in the brush's coordinate space

### `M:CD2DRadialGradientBrush.SetGradientOriginOffset(CD2DPointF)`

Member kind: method
Symbol: `CD2DRadialGradientBrush.SetGradientOriginOffset(CD2DPointF)`

#### Summary

Specifies the offset of the gradient origin relative to the gradient ellipse's center

#### Parameter `gradientOriginOffset`

The offset of the gradient origin from the center of the gradient ellipse

### `M:CD2DRadialGradientBrush.SetCenter(CD2DPointF)`

Member kind: method
Symbol: `CD2DRadialGradientBrush.SetCenter(CD2DPointF)`

#### Summary

Specifies the center of the gradient ellipse in the brush's coordinate space

#### Parameter `point`

The center of the gradient ellipse, in the brush's coordinate space

### `M:CD2DRadialGradientBrush.op_Implicit~ID2D1RadialGradientBrush*`

Member kind: method
Symbol: `CD2DRadialGradientBrush.op_Implicit~ID2D1RadialGradientBrush*`

#### Summary

Returns ID2D1RadialGradientBrush interface

#### Returns

Pointer to an ID2D1RadialGradientBrush interface or NULL if object is not initialized yet.

### `M:CD2DRadialGradientBrush.Get`

Member kind: method
Symbol: `CD2DRadialGradientBrush.Get`

#### Summary

Returns ID2D1RadialGradientBrush interface

#### Returns

Pointer to an ID2D1RadialGradientBrush interface or NULL if object is not initialized yet.

### `M:CD2DRadialGradientBrush.Detach`

Member kind: method
Symbol: `CD2DRadialGradientBrush.Detach`

#### Summary

Detaches resource interface from the object

#### Returns

Pointer to detached resource interface.

### `M:CD2DRadialGradientBrush.Attach(ID2D1RadialGradientBrush*)`

Member kind: method
Symbol: `CD2DRadialGradientBrush.Attach(ID2D1RadialGradientBrush*)`

#### Summary

Attaches existing resource interface to the object

#### Parameter `pResource`

Existing resource interface. Cannot be NULL

### `M:CD2DRadialGradientBrush.Destroy`

Member kind: method
Symbol: `CD2DRadialGradientBrush.Destroy`

#### Summary

Destroys a CD2DRadialGradientBrush object.

### `M:CD2DRadialGradientBrush.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DRadialGradientBrush.Create(CRenderTarget*)`

#### Summary

Creates a CD2DRadialGradientBrush.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DRadialGradientBrush.Dispose`

Member kind: method
Symbol: `CD2DRadialGradientBrush.Dispose`

#### Summary

The destructor. Called when a D2D radial gradient brush object is being destroyed.

### `M:CD2DRadialGradientBrush.#ctor(CRenderTarget*,D2D1_GRADIENT_STOP!System.Runtime.CompilerServices.IsConst*,System.UInt32,D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES,D2D1_GAMMA,D2D1_EXTEND_MODE,CD2DBrushProperties*,System.Int32)`

Member kind: method
Symbol: `CD2DRadialGradientBrush.#ctor(CRenderTarget*,D2D1_GRADIENT_STOP!System.Runtime.CompilerServices.IsConst*,System.UInt32,D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES,D2D1_GAMMA,D2D1_EXTEND_MODE,CD2DBrushProperties*,System.Int32)`

#### Summary

Constructs a CD2DLinearGradientBrush object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `gradientStops`

A pointer to an array of D2D1_GRADIENT_STOP structures.

#### Parameter `gradientStopsCount`

A value greater than or equal to 1 that specifies the number of gradient stops in the gradientStops array.

#### Parameter `RadialGradientBrushProperties`

The center, gradient origin offset, and x-radius and y-radius of the brush's gradient.

#### Parameter `colorInterpolationGamma`

The space in which color interpolation between the gradient stops is performed.

#### Parameter `extendMode`

The behavior of the gradient outside the [0,1] normalized range.

#### Parameter `pBrushProperties`

A pointer to the opacity and transformation of a brush.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DRadialGradientBrush`

Member kind: type
Symbol: `CD2DRadialGradientBrush`

#### Summary

ID2D1RadialGradientBrush wrapper.

### `F:CD2DLinearGradientBrush.m_pLinearGradientBrush`

Member kind: field
Symbol: `CD2DLinearGradientBrush.m_pLinearGradientBrush`

#### Summary

A pointer to an ID2D1LinearGradientBrush.

### `F:CD2DLinearGradientBrush.m_LinearGradientBrushProperties`

Member kind: field
Symbol: `CD2DLinearGradientBrush.m_LinearGradientBrushProperties`

#### Summary

The start and end points of the gradient.

### `M:CD2DLinearGradientBrush.GetEndPoint`

Member kind: method
Symbol: `CD2DLinearGradientBrush.GetEndPoint`

#### Summary

Retrieves the ending coordinates of the linear gradient

#### Returns

The ending two-dimensional coordinates of the linear gradient, in the brush's coordinate space

### `M:CD2DLinearGradientBrush.GetStartPoint`

Member kind: method
Symbol: `CD2DLinearGradientBrush.GetStartPoint`

#### Summary

Retrieves the starting coordinates of the linear gradient

#### Returns

The starting two-dimensional coordinates of the linear gradient, in the brush's coordinate space

### `M:CD2DLinearGradientBrush.SetEndPoint(CD2DPointF)`

Member kind: method
Symbol: `CD2DLinearGradientBrush.SetEndPoint(CD2DPointF)`

#### Summary

Sets the ending coordinates of the linear gradient in the brush's coordinate space

#### Parameter `point`

The ending two-dimensional coordinates of the linear gradient, in the brush's coordinate space

### `M:CD2DLinearGradientBrush.SetStartPoint(CD2DPointF)`

Member kind: method
Symbol: `CD2DLinearGradientBrush.SetStartPoint(CD2DPointF)`

#### Summary

Sets the starting coordinates of the linear gradient in the brush's coordinate space

#### Parameter `point`

The starting two-dimensional coordinates of the linear gradient, in the brush's coordinate space

### `M:CD2DLinearGradientBrush.op_Implicit~ID2D1LinearGradientBrush*`

Member kind: method
Symbol: `CD2DLinearGradientBrush.op_Implicit~ID2D1LinearGradientBrush*`

#### Summary

Returns ID2D1LinearGradientBrush interface

#### Returns

Pointer to an ID2D1LinearGradientBrush interface or NULL if object is not initialized yet.

### `M:CD2DLinearGradientBrush.Get`

Member kind: method
Symbol: `CD2DLinearGradientBrush.Get`

#### Summary

Returns ID2D1LinearGradientBrush interface

#### Returns

Pointer to an ID2D1LinearGradientBrush interface or NULL if object is not initialized yet.

### `M:CD2DLinearGradientBrush.Detach`

Member kind: method
Symbol: `CD2DLinearGradientBrush.Detach`

#### Summary

Detaches resource interface from the object

#### Returns

Pointer to detached resource interface.

### `M:CD2DLinearGradientBrush.Attach(ID2D1LinearGradientBrush*)`

Member kind: method
Symbol: `CD2DLinearGradientBrush.Attach(ID2D1LinearGradientBrush*)`

#### Summary

Attaches existing resource interface to the object

#### Parameter `pResource`

Existing resource interface. Cannot be NULL

### `M:CD2DLinearGradientBrush.Destroy`

Member kind: method
Symbol: `CD2DLinearGradientBrush.Destroy`

#### Summary

Destroys a CD2DLinearGradientBrush object.

### `M:CD2DLinearGradientBrush.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DLinearGradientBrush.Create(CRenderTarget*)`

#### Summary

Creates a CD2DLinearGradientBrush.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DLinearGradientBrush.Dispose`

Member kind: method
Symbol: `CD2DLinearGradientBrush.Dispose`

#### Summary

The destructor. Called when a D2D linear gradient brush object is being destroyed.

### `M:CD2DLinearGradientBrush.#ctor(CRenderTarget*,D2D1_GRADIENT_STOP!System.Runtime.CompilerServices.IsConst*,System.UInt32,D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES,D2D1_GAMMA,D2D1_EXTEND_MODE,CD2DBrushProperties*,System.Int32)`

Member kind: method
Symbol: `CD2DLinearGradientBrush.#ctor(CRenderTarget*,D2D1_GRADIENT_STOP!System.Runtime.CompilerServices.IsConst*,System.UInt32,D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES,D2D1_GAMMA,D2D1_EXTEND_MODE,CD2DBrushProperties*,System.Int32)`

#### Summary

Constructs a CD2DLinearGradientBrush object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `gradientStops`

A pointer to an array of D2D1_GRADIENT_STOP structures.

#### Parameter `gradientStopsCount`

A value greater than or equal to 1 that specifies the number of gradient stops in the gradientStops array.

#### Parameter `LinearGradientBrushProperties`

The start and end points of the gradient.

#### Parameter `colorInterpolationGamma`

The space in which color interpolation between the gradient stops is performed.

#### Parameter `extendMode`

The behavior of the gradient outside the [0,1] normalized range.

#### Parameter `pBrushProperties`

A pointer to the opacity and transformation of a brush.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DLinearGradientBrush`

Member kind: type
Symbol: `CD2DLinearGradientBrush`

#### Summary

ID2D1LinearGradientBrush wrapper.

### `F:CD2DGradientBrush.m_pGradientStops`

Member kind: field
Symbol: `CD2DGradientBrush.m_pGradientStops`

#### Summary

A pointer to an array of D2D1_GRADIENT_STOP structures.

### `F:CD2DGradientBrush.m_extendMode`

Member kind: field
Symbol: `CD2DGradientBrush.m_extendMode`

#### Summary

The behavior of the gradient outside the [0,1] normalized range.

### `F:CD2DGradientBrush.m_colorInterpolationGamma`

Member kind: field
Symbol: `CD2DGradientBrush.m_colorInterpolationGamma`

#### Summary

The space in which color interpolation between the gradient stops is performed.

### `F:CD2DGradientBrush.m_arGradientStops`

Member kind: field
Symbol: `CD2DGradientBrush.m_arGradientStops`

#### Summary

Array of the D2D1_GRADIENT_STOP structures.

### `M:CD2DGradientBrush.Destroy`

Member kind: method
Symbol: `CD2DGradientBrush.Destroy`

#### Summary

Destroys a CD2DGradientBrush object.

### `M:CD2DGradientBrush.Dispose`

Member kind: method
Symbol: `CD2DGradientBrush.Dispose`

#### Summary

The destructor. Called when a D2D gradient brush object is being destroyed.

### `M:CD2DGradientBrush.#ctor(CRenderTarget*,D2D1_GRADIENT_STOP!System.Runtime.CompilerServices.IsConst*,System.UInt32,D2D1_GAMMA,D2D1_EXTEND_MODE,CD2DBrushProperties*,System.Int32)`

Member kind: method
Symbol: `CD2DGradientBrush.#ctor(CRenderTarget*,D2D1_GRADIENT_STOP!System.Runtime.CompilerServices.IsConst*,System.UInt32,D2D1_GAMMA,D2D1_EXTEND_MODE,CD2DBrushProperties*,System.Int32)`

#### Summary

Constructs a CD2DGradientBrush object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `gradientStops`

A pointer to an array of D2D1_GRADIENT_STOP structures.

#### Parameter `gradientStopsCount`

A value greater than or equal to 1 that specifies the number of gradient stops in the gradientStops array.

#### Parameter `colorInterpolationGamma`

The space in which color interpolation between the gradient stops is performed.

#### Parameter `extendMode`

The behavior of the gradient outside the [0,1] normalized range.

#### Parameter `pBrushProperties`

A pointer to the opacity and transformation of a brush.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DGradientBrush`

Member kind: type
Symbol: `CD2DGradientBrush`

#### Summary

The base class of CD2DLinearGradientBrush and CD2DRadialGradientBrush classes.

### `F:CD2DBitmapBrush.m_pBitmapBrushProperties`

Member kind: field
Symbol: `CD2DBitmapBrush.m_pBitmapBrushProperties`

#### Summary

Bitmap brush properties.

### `F:CD2DBitmapBrush.m_pBitmapBrush`

Member kind: field
Symbol: `CD2DBitmapBrush.m_pBitmapBrush`

#### Summary

Stores a pointer to an ID2D1BitmapBrush object.

### `F:CD2DBitmapBrush.m_pBitmap`

Member kind: field
Symbol: `CD2DBitmapBrush.m_pBitmap`

#### Summary

Stores a pointer to a CD2DBitmap object.

### `M:CD2DBitmapBrush.CommonInit(D2D1_BITMAP_BRUSH_PROPERTIES*)`

Member kind: method
Symbol: `CD2DBitmapBrush.CommonInit(D2D1_BITMAP_BRUSH_PROPERTIES*)`

#### Summary

Initializes the object

#### Parameter `pBitmapBrushProperties`

A pointer to the bitmap brush properties.

### `M:CD2DBitmapBrush.Destroy`

Member kind: method
Symbol: `CD2DBitmapBrush.Destroy`

#### Summary

Destroys a CD2DBitmapBrush object.

### `M:CD2DBitmapBrush.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DBitmapBrush.Create(CRenderTarget*)`

#### Summary

Creates a CD2DBitmapBrush.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DBitmapBrush.GetInterpolationMode`

Member kind: method
Symbol: `CD2DBitmapBrush.GetInterpolationMode`

#### Summary

Gets the interpolation method used when the brush bitmap is scaled or rotated

#### Returns

The interpolation method used when the brush bitmap is scaled or rotated

### `M:CD2DBitmapBrush.GetExtendModeY`

Member kind: method
Symbol: `CD2DBitmapBrush.GetExtendModeY`

#### Summary

Gets the method by which the brush vertically tiles those areas that extend past its bitmap

#### Returns

A value that specifies how the brush vertically tiles those areas that extend past its bitmap

### `M:CD2DBitmapBrush.GetExtendModeX`

Member kind: method
Symbol: `CD2DBitmapBrush.GetExtendModeX`

#### Summary

Gets the method by which the brush horizontally tiles those areas that extend past its bitmap

#### Returns

A value that specifies how the brush horizontally tiles those areas that extend past its bitmap

### `M:CD2DBitmapBrush.SetBitmap(CD2DBitmap*)`

Member kind: method
Symbol: `CD2DBitmapBrush.SetBitmap(CD2DBitmap*)`

#### Summary

Specifies the bitmap source that this brush uses to paint

#### Parameter `pBitmap`

The bitmap source used by the brush

### `M:CD2DBitmapBrush.SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE)`

Member kind: method
Symbol: `CD2DBitmapBrush.SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE)`

#### Summary

Specifies the interpolation mode used when the brush bitmap is scaled or rotated

#### Parameter `interpolationMode`

The interpolation mode used when the brush bitmap is scaled or rotated

### `M:CD2DBitmapBrush.SetExtendModeY(D2D1_EXTEND_MODE)`

Member kind: method
Symbol: `CD2DBitmapBrush.SetExtendModeY(D2D1_EXTEND_MODE)`

#### Summary

Specifies how the brush vertically tiles those areas that extend past its bitmap

#### Parameter `extendModeY`

A value that specifies how the brush vertically tiles those areas that extend past its bitmap

### `M:CD2DBitmapBrush.SetExtendModeX(D2D1_EXTEND_MODE)`

Member kind: method
Symbol: `CD2DBitmapBrush.SetExtendModeX(D2D1_EXTEND_MODE)`

#### Summary

Specifies how the brush horizontally tiles those areas that extend past its bitmap

#### Parameter `extendModeX`

A value that specifies how the brush horizontally tiles those areas that extend past its bitmap

### `M:CD2DBitmapBrush.GetBitmap`

Member kind: method
Symbol: `CD2DBitmapBrush.GetBitmap`

#### Summary

Gets the bitmap source that this brush uses to paint

#### Returns

Pointer to an CD2DBitmap object or NULL if object is not initialized yet.

### `M:CD2DBitmapBrush.op_Implicit~ID2D1BitmapBrush*`

Member kind: method
Symbol: `CD2DBitmapBrush.op_Implicit~ID2D1BitmapBrush*`

#### Summary

Returns ID2D1BitmapBrush interface

#### Returns

Pointer to an ID2D1BitmapBrush interface or NULL if object is not initialized yet.

### `M:CD2DBitmapBrush.Get`

Member kind: method
Symbol: `CD2DBitmapBrush.Get`

#### Summary

Returns ID2D1BitmapBrush interface

#### Returns

Pointer to an ID2D1BitmapBrush interface or NULL if object is not initialized yet.

### `M:CD2DBitmapBrush.Detach`

Member kind: method
Symbol: `CD2DBitmapBrush.Detach`

#### Summary

Detaches resource interface from the object

#### Returns

Pointer to detached resource interface.

### `M:CD2DBitmapBrush.Attach(ID2D1BitmapBrush*)`

Member kind: method
Symbol: `CD2DBitmapBrush.Attach(ID2D1BitmapBrush*)`

#### Summary

Attaches existing resource interface to the object

#### Parameter `pResource`

Existing resource interface. Cannot be NULL

### `M:CD2DBitmapBrush.Dispose`

Member kind: method
Symbol: `CD2DBitmapBrush.Dispose`

#### Summary

The destructor. Called when a D2D bitmap brush object is being destroyed.

### `M:CD2DBitmapBrush.#ctor(CRenderTarget*,System.Char!System.Runtime.CompilerServices.IsConst*,CD2DSizeU,D2D1_BITMAP_BRUSH_PROPERTIES*,CD2DBrushProperties*,System.Int32)`

Member kind: method
Symbol: `CD2DBitmapBrush.#ctor(CRenderTarget*,System.Char!System.Runtime.CompilerServices.IsConst*,CD2DSizeU,D2D1_BITMAP_BRUSH_PROPERTIES*,CD2DBrushProperties*,System.Int32)`

#### Summary

Constructs a CD2DBitmapBrush object from file.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `lpszImagePath`

Pointer to a null-terminated string that contains the name of file.

#### Parameter `sizeDest`

Destination size of the bitmap.

#### Parameter `pBitmapBrushProperties`

A pointer to the extend modes and the interpolation mode of a bitmap brush.

#### Parameter `pBrushProperties`

A pointer to the opacity and transformation of a brush.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `M:CD2DBitmapBrush.#ctor(CRenderTarget*,System.UInt32,System.Char!System.Runtime.CompilerServices.IsConst*,CD2DSizeU,D2D1_BITMAP_BRUSH_PROPERTIES*,CD2DBrushProperties*,System.Int32)`

Member kind: method
Symbol: `CD2DBitmapBrush.#ctor(CRenderTarget*,System.UInt32,System.Char!System.Runtime.CompilerServices.IsConst*,CD2DSizeU,D2D1_BITMAP_BRUSH_PROPERTIES*,CD2DBrushProperties*,System.Int32)`

#### Summary

Constructs a CD2DBitmapBrush object from resource.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `uiResID`

The resource ID number of the resource.

#### Parameter `lpszType`

Pointer to a null-terminated string that contains the resource type.

#### Parameter `sizeDest`

Destination size of the bitmap.

#### Parameter `pBitmapBrushProperties`

A pointer to the extend modes and the interpolation mode of a bitmap brush.

#### Parameter `pBrushProperties`

A pointer to the opacity and transformation of a brush.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `M:CD2DBitmapBrush.#ctor(CRenderTarget*,D2D1_BITMAP_BRUSH_PROPERTIES*,CD2DBrushProperties*,System.Int32)`

Member kind: method
Symbol: `CD2DBitmapBrush.#ctor(CRenderTarget*,D2D1_BITMAP_BRUSH_PROPERTIES*,CD2DBrushProperties*,System.Int32)`

#### Summary

Constructs a CD2DBitmapBrush object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `pBitmapBrushProperties`

A pointer to the extend modes and the interpolation mode of a bitmap brush.

#### Parameter `pBrushProperties`

A pointer to the opacity and transformation of a brush.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DBitmapBrush`

Member kind: type
Symbol: `CD2DBitmapBrush`

#### Summary

ID2D1BitmapBrush wrapper.

### `F:CD2DSolidColorBrush.m_colorSolid`

Member kind: field
Symbol: `CD2DSolidColorBrush.m_colorSolid`

#### Summary

Brush solid color.

### `F:CD2DSolidColorBrush.m_pSolidColorBrush`

Member kind: field
Symbol: `CD2DSolidColorBrush.m_pSolidColorBrush`

#### Summary

Stores a pointer to an ID2D1SolidColorBrush object.

### `M:CD2DSolidColorBrush.Destroy`

Member kind: method
Symbol: `CD2DSolidColorBrush.Destroy`

#### Summary

Destroys a CD2DSolidColorBrush object.

### `M:CD2DSolidColorBrush.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DSolidColorBrush.Create(CRenderTarget*)`

#### Summary

Creates a CD2DSolidColorBrush.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DSolidColorBrush.GetColor`

Member kind: method
Symbol: `CD2DSolidColorBrush.GetColor`

#### Summary

Retrieves the color of the solid color brush

#### Returns

The color of this solid color brush

### `M:CD2DSolidColorBrush.SetColor(_D3DCOLORVALUE)`

Member kind: method
Symbol: `CD2DSolidColorBrush.SetColor(_D3DCOLORVALUE)`

#### Summary

Specifies the color of this solid color brush

#### Parameter `color`

The color of this solid color brush

### `M:CD2DSolidColorBrush.op_Implicit~ID2D1SolidColorBrush*`

Member kind: method
Symbol: `CD2DSolidColorBrush.op_Implicit~ID2D1SolidColorBrush*`

#### Summary

Returns ID2D1SolidColorBrush interface

#### Returns

Pointer to an ID2D1SolidColorBrush interface or NULL if object is not initialized yet.

### `M:CD2DSolidColorBrush.Get`

Member kind: method
Symbol: `CD2DSolidColorBrush.Get`

#### Summary

Returns ID2D1SolidColorBrush interface

#### Returns

Pointer to an ID2D1SolidColorBrush interface or NULL if object is not initialized yet.

### `M:CD2DSolidColorBrush.Detach`

Member kind: method
Symbol: `CD2DSolidColorBrush.Detach`

#### Summary

Detaches resource interface from the object

#### Returns

Pointer to detached resource interface.

### `M:CD2DSolidColorBrush.Attach(ID2D1SolidColorBrush*)`

Member kind: method
Symbol: `CD2DSolidColorBrush.Attach(ID2D1SolidColorBrush*)`

#### Summary

Attaches existing resource interface to the object

#### Parameter `pResource`

Existing resource interface. Cannot be NULL

### `M:CD2DSolidColorBrush.Dispose`

Member kind: method
Symbol: `CD2DSolidColorBrush.Dispose`

#### Summary

The destructor. Called when a D2D solid brush object is being destroyed.

### `M:CD2DSolidColorBrush.#ctor(CRenderTarget*,System.UInt32!System.Runtime.CompilerServices.IsLong,System.Int32,CD2DBrushProperties*,System.Int32)`

Member kind: method
Symbol: `CD2DSolidColorBrush.#ctor(CRenderTarget*,System.UInt32!System.Runtime.CompilerServices.IsLong,System.Int32,CD2DBrushProperties*,System.Int32)`

#### Summary

Constructs a CD2DSolidColorBrush object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `color`

The red, green, and blue values of the brush's color.

#### Parameter `nAlpha`

The opacity of the brush's color.

#### Parameter `pBrushProperties`

A pointer to the opacity and transformation of a brush.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `M:CD2DSolidColorBrush.#ctor(CRenderTarget*,_D3DCOLORVALUE,CD2DBrushProperties*,System.Int32)`

Member kind: method
Symbol: `CD2DSolidColorBrush.#ctor(CRenderTarget*,_D3DCOLORVALUE,CD2DBrushProperties*,System.Int32)`

#### Summary

Constructs a CD2DSolidColorBrush object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `color`

The red, green, blue, and alpha values of the brush's color.

#### Parameter `pBrushProperties`

A pointer to the opacity and transformation of a brush.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DSolidColorBrush`

Member kind: type
Symbol: `CD2DSolidColorBrush`

#### Summary

ID2D1SolidColorBrush wrapper.

### `F:CD2DBrush.m_pBrushProperties`

Member kind: field
Symbol: `CD2DBrush.m_pBrushProperties`

#### Summary

Brush properties.

### `F:CD2DBrush.m_pBrush`

Member kind: field
Symbol: `CD2DBrush.m_pBrush`

#### Summary

Stores a pointer to an ID2D1Brush object.

### `M:CD2DBrush.GetTransform(D2D_MATRIX_3X2_F*)`

Member kind: method
Symbol: `CD2DBrush.GetTransform(D2D_MATRIX_3X2_F*)`

#### Summary

Gets the current transform of the render target

#### Parameter `transform`

When this returns, contains the current transform of the render target. This parameter is passed uninitialized

### `M:CD2DBrush.SetTransform(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DBrush.SetTransform(D2D_MATRIX_3X2_F!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Applies the specified transform to the render target, replacing the existing transformation. All subsequent drawing operations occur in the transformed space

#### Parameter `transform`

The transform to apply to the render target

### `M:CD2DBrush.GetOpacity`

Member kind: method
Symbol: `CD2DBrush.GetOpacity`

#### Summary

Gets the degree of opacity of this brush

#### Returns

A value between zero and 1 that indicates the opacity of the brush. This value is a constant multiplier that linearly scales the alpha value of all pixels filled by the brush. The opacity values are clamped in the range 0 to 1 before they are multiplied together

### `M:CD2DBrush.SetOpacity(System.Single)`

Member kind: method
Symbol: `CD2DBrush.SetOpacity(System.Single)`

#### Summary

Sets the degree of opacity of this brush

#### Parameter `opacity`

A value between zero and 1 that indicates the opacity of the brush. This value is a constant multiplier that linearly scales the alpha value of all pixels filled by the brush. The opacity values are clamped in the range 0 to 1 before they are multiplied together

### `M:CD2DBrush.Destroy`

Member kind: method
Symbol: `CD2DBrush.Destroy`

#### Summary

Destroys a CD2DBrush object.

### `M:CD2DBrush.op_Implicit~ID2D1Brush*`

Member kind: method
Symbol: `CD2DBrush.op_Implicit~ID2D1Brush*`

#### Summary

Returns ID2D1Brush interface

#### Returns

Pointer to an ID2D1Brush interface or NULL if object is not initialized yet.

### `M:CD2DBrush.Get`

Member kind: method
Symbol: `CD2DBrush.Get`

#### Summary

Returns ID2D1Brush interface

#### Returns

Pointer to an ID2D1Brush interface or NULL if object is not initialized yet.

### `M:CD2DBrush.IsValid`

Member kind: method
Symbol: `CD2DBrush.IsValid`

#### Summary

Checks resource validity

#### Returns

TRUE if resource is valid; otherwise FALSE.

### `M:CD2DBrush.Detach`

Member kind: method
Symbol: `CD2DBrush.Detach`

#### Summary

Detaches resource interface from the object

#### Returns

Pointer to detached resource interface.

### `M:CD2DBrush.Attach(ID2D1Brush*)`

Member kind: method
Symbol: `CD2DBrush.Attach(ID2D1Brush*)`

#### Summary

Attaches existing resource interface to the object

#### Parameter `pResource`

Existing resource interface. Cannot be NULL

### `M:CD2DBrush.Dispose`

Member kind: method
Symbol: `CD2DBrush.Dispose`

#### Summary

The destructor. Called when a D2D brush object is being destroyed.

### `M:CD2DBrush.#ctor(CRenderTarget*,CD2DBrushProperties*,System.Int32)`

Member kind: method
Symbol: `CD2DBrush.#ctor(CRenderTarget*,CD2DBrushProperties*,System.Int32)`

#### Summary

Constructs a CD2DBrush object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `pBrushProperties`

A pointer to the opacity and transformation of a brush.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DBrush`

Member kind: type
Symbol: `CD2DBrush`

#### Summary

ID2D1Brush wrapper.

### `M:CD2DBrushProperties.CommonInit`

Member kind: method
Symbol: `CD2DBrushProperties.CommonInit`

#### Summary

Initializes the object

### `M:CD2DBrushProperties.#ctor(D2D_MATRIX_3X2_F,System.Single)`

Member kind: method
Symbol: `CD2DBrushProperties.#ctor(D2D_MATRIX_3X2_F,System.Single)`

#### Summary

Creates a CD2D_BRUSH_PROPERTIES structure

#### Parameter `_transform`

The transformation to apply to the brush

#### Parameter `_opacity`

The base opacity of the brush. The default value is 1.0.

### `M:CD2DBrushProperties.#ctor(System.Single)`

Member kind: method
Symbol: `CD2DBrushProperties.#ctor(System.Single)`

#### Summary

Creates a CD2D_BRUSH_PROPERTIES structure

#### Parameter `_opacity`

The base opacity of the brush. The default value is 1.0.

### `M:CD2DBrushProperties.#ctor`

Member kind: method
Symbol: `CD2DBrushProperties.#ctor`

#### Summary

Creates a CD2D_BRUSH_PROPERTIES structure

### `T:CD2DBrushProperties`

Member kind: type
Symbol: `CD2DBrushProperties`

#### Summary

D2D1_BRUSH_PROPERTIES wrapper.

### `F:CD2DBitmap.m_bAutoDestroyHBMP`

Member kind: field
Symbol: `CD2DBitmap.m_bAutoDestroyHBMP`

#### Summary

TRUE if m_hBmpSrc should be destroyed; otherwise FALSE.

### `F:CD2DBitmap.m_hBmpSrc`

Member kind: field
Symbol: `CD2DBitmap.m_hBmpSrc`

#### Summary

Source bitmap handle.

### `F:CD2DBitmap.m_sizeDest`

Member kind: field
Symbol: `CD2DBitmap.m_sizeDest`

#### Summary

Bitmap destination size.

### `F:CD2DBitmap.m_strPath`

Member kind: field
Symbol: `CD2DBitmap.m_strPath`

#### Summary

Botmap file path.

### `F:CD2DBitmap.m_lpszType`

Member kind: field
Symbol: `CD2DBitmap.m_lpszType`

#### Summary

Resource type.

### `F:CD2DBitmap.m_uiResID`

Member kind: field
Symbol: `CD2DBitmap.m_uiResID`

#### Summary

Bitmap resource ID.

### `F:CD2DBitmap.m_pBitmap`

Member kind: field
Symbol: `CD2DBitmap.m_pBitmap`

#### Summary

Stores a pointer to an ID2D1Bitmap object.

### `M:CD2DBitmap.Destroy`

Member kind: method
Symbol: `CD2DBitmap.Destroy`

#### Summary

Destroys a CD2DBitmap object.

### `M:CD2DBitmap.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DBitmap.Create(CRenderTarget*)`

#### Summary

Creates a CD2DBitmap.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DBitmap.CommonInit`

Member kind: method
Symbol: `CD2DBitmap.CommonInit`

#### Summary

Initializes the object

### `M:CD2DBitmap.op_Implicit~ID2D1Bitmap*`

Member kind: method
Symbol: `CD2DBitmap.op_Implicit~ID2D1Bitmap*`

#### Summary

Returns ID2D1Bitmap interface

#### Returns

Pointer to an ID2D1Bitmap interface or NULL if object is not initialized yet.

### `M:CD2DBitmap.Get`

Member kind: method
Symbol: `CD2DBitmap.Get`

#### Summary

Returns ID2D1Bitmap interface

#### Returns

Pointer to an ID2D1Bitmap interface or NULL if object is not initialized yet.

### `M:CD2DBitmap.IsValid`

Member kind: method
Symbol: `CD2DBitmap.IsValid`

#### Summary

Checks resource validity

#### Returns

TRUE if resource is valid; otherwise FALSE.

### `M:CD2DBitmap.CopyFromMemory(System.Void!System.Runtime.CompilerServices.IsConst*,System.UInt32,CD2DRectU!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DBitmap.CopyFromMemory(System.Void!System.Runtime.CompilerServices.IsConst*,System.UInt32,CD2DRectU!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Copies the specified region from memory into the current bitmap

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `srcData`

The data to copy

#### Parameter `pitch`

The stride, or pitch, of the source bitmap stored in srcData. The stride is the byte count of a scanline (one row of pixels in memory). The stride can be computed from the following formula: pixel width * bytes per pixel + memory padding

#### Parameter `destRect`

In the current bitmap, the upper-left corner of the area to which the region specified by srcRect is copied

### `M:CD2DBitmap.CopyFromRenderTarget(CRenderTarget!System.Runtime.CompilerServices.IsConst*,CD2DPointU!System.Runtime.CompilerServices.IsConst*,CD2DRectU!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DBitmap.CopyFromRenderTarget(CRenderTarget!System.Runtime.CompilerServices.IsConst*,CD2DPointU!System.Runtime.CompilerServices.IsConst*,CD2DRectU!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Copies the specified region from the specified render target into the current bitmap

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

The render target that contains the region to copy

#### Parameter `destPoint`

In the current bitmap, the upper-left corner of the area to which the region specified by srcRect is copied

#### Parameter `srcRect`

The area of renderTarget to copy

### `M:CD2DBitmap.CopyFromBitmap(CD2DBitmap!System.Runtime.CompilerServices.IsConst*,CD2DPointU!System.Runtime.CompilerServices.IsConst*,CD2DRectU!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DBitmap.CopyFromBitmap(CD2DBitmap!System.Runtime.CompilerServices.IsConst*,CD2DPointU!System.Runtime.CompilerServices.IsConst*,CD2DRectU!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Copies the specified region from the specified bitmap into the current bitmap

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pBitmap`

The bitmap to copy from

#### Parameter `destPoint`

In the current bitmap, the upper-left corner of the area to which the region specified by srcRect is copied

#### Parameter `srcRect`

The area of bitmap to copy

### `M:CD2DBitmap.GetDPI`

Member kind: method
Symbol: `CD2DBitmap.GetDPI`

#### Summary

Return the dots per inch (DPI) of the bitmap

#### Returns

The horizontal and vertical DPI of the bitmap.

### `M:CD2DBitmap.GetPixelFormat`

Member kind: method
Symbol: `CD2DBitmap.GetPixelFormat`

#### Summary

Retrieves the pixel format and alpha mode of the bitmap

#### Returns

The pixel format and alpha mode of the bitmap.

### `M:CD2DBitmap.GetPixelSize`

Member kind: method
Symbol: `CD2DBitmap.GetPixelSize`

#### Summary

Returns the size, in device-dependent units (pixels), of the bitmap

#### Returns

The size, in pixels, of the bitmap..

### `M:CD2DBitmap.GetSize`

Member kind: method
Symbol: `CD2DBitmap.GetSize`

#### Summary

Returns the size, in device-independent pixels (DIPs), of the bitmap

#### Returns

The size, in DIPs, of the bitmap.

### `M:CD2DBitmap.Detach`

Member kind: method
Symbol: `CD2DBitmap.Detach`

#### Summary

Detaches resource interface from the object

#### Returns

Pointer to detached resource interface.

### `M:CD2DBitmap.Attach(ID2D1Bitmap*)`

Member kind: method
Symbol: `CD2DBitmap.Attach(ID2D1Bitmap*)`

#### Summary

Attaches existing resource interface to the object

#### Parameter `pResource`

Existing resource interface. Cannot be NULL

### `M:CD2DBitmap.Dispose`

Member kind: method
Symbol: `CD2DBitmap.Dispose`

#### Summary

The destructor. Called when a D2D bitmap object is being destroyed.

### `M:CD2DBitmap.#ctor(CRenderTarget*,System.Int32)`

Member kind: method
Symbol: `CD2DBitmap.#ctor(CRenderTarget*,System.Int32)`

#### Summary

Constructs a CD2DBitmap object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `M:CD2DBitmap.#ctor(CRenderTarget*,HBITMAP__*,CD2DSizeU,System.Int32)`

Member kind: method
Symbol: `CD2DBitmap.#ctor(CRenderTarget*,HBITMAP__*,CD2DSizeU,System.Int32)`

#### Summary

Constructs a CD2DBitmap object from HBITMAP.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `hbmpSrc`

Handle to the bitmap.

#### Parameter `sizeDest`

Destination size of the bitmap.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `M:CD2DBitmap.#ctor(CRenderTarget*,System.Char!System.Runtime.CompilerServices.IsConst*,CD2DSizeU,System.Int32)`

Member kind: method
Symbol: `CD2DBitmap.#ctor(CRenderTarget*,System.Char!System.Runtime.CompilerServices.IsConst*,CD2DSizeU,System.Int32)`

#### Summary

Constructs a CD2DBitmap object from file.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `lpszPath`

Pointer to a null-terminated string that contains the name of file.

#### Parameter `sizeDest`

Destination size of the bitmap.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `M:CD2DBitmap.#ctor(CRenderTarget*,System.UInt32,System.Char!System.Runtime.CompilerServices.IsConst*,CD2DSizeU,System.Int32)`

Member kind: method
Symbol: `CD2DBitmap.#ctor(CRenderTarget*,System.UInt32,System.Char!System.Runtime.CompilerServices.IsConst*,CD2DSizeU,System.Int32)`

#### Summary

Constructs a CD2DBitmap object from resource.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `uiResID`

The resource ID number of the resource.

#### Parameter `lpszType`

Pointer to a null-terminated string that contains the resource type.

#### Parameter `sizeDest`

Destination size of the bitmap.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DBitmap`

Member kind: type
Symbol: `CD2DBitmap`

#### Summary

ID2D1Bitmap wrapper.

### `F:CD2DLayer.m_pLayer`

Member kind: field
Symbol: `CD2DLayer.m_pLayer`

#### Summary

Stores a pointer to an ID2D1Layer object.

### `M:CD2DLayer.Destroy`

Member kind: method
Symbol: `CD2DLayer.Destroy`

#### Summary

Destroys a CD2DLayer object.

### `M:CD2DLayer.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DLayer.Create(CRenderTarget*)`

#### Summary

Creates a CD2DLayer.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DLayer.Detach`

Member kind: method
Symbol: `CD2DLayer.Detach`

#### Summary

Detaches resource interface from the object

#### Returns

Pointer to detached resource interface.

### `M:CD2DLayer.Attach(ID2D1Layer*)`

Member kind: method
Symbol: `CD2DLayer.Attach(ID2D1Layer*)`

#### Summary

Attaches existing resource interface to the object

#### Parameter `pResource`

Existing resource interface. Cannot be NULL

### `M:CD2DLayer.op_Implicit~ID2D1Layer*`

Member kind: method
Symbol: `CD2DLayer.op_Implicit~ID2D1Layer*`

#### Summary

Returns ID2D1Layer interface

#### Returns

Pointer to an ID2D1Layer interface or NULL if object is not initialized yet.

### `M:CD2DLayer.Get`

Member kind: method
Symbol: `CD2DLayer.Get`

#### Summary

Returns ID2D1Layer interface

#### Returns

Pointer to an ID2D1Layer interface or NULL if object is not initialized yet.

### `M:CD2DLayer.IsValid`

Member kind: method
Symbol: `CD2DLayer.IsValid`

#### Summary

Checks resource validity

#### Returns

TRUE if resource is valid; otherwise FALSE.

### `M:CD2DLayer.GetSize`

Member kind: method
Symbol: `CD2DLayer.GetSize`

#### Summary

Returns the size of the render target in device-independent pixels

#### Returns

The current size of the render target in device-independent pixels

### `M:CD2DLayer.Dispose`

Member kind: method
Symbol: `CD2DLayer.Dispose`

#### Summary

The destructor. Called when a D2D layer object is being destroyed.

### `M:CD2DLayer.#ctor(CRenderTarget*,System.Int32)`

Member kind: method
Symbol: `CD2DLayer.#ctor(CRenderTarget*,System.Int32)`

#### Summary

Constructs a CD2DLayer object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DLayer`

Member kind: type
Symbol: `CD2DLayer`

#### Summary

ID2D1Layer wrapper.

### `F:CD2DResource.m_pParentTarget`

Member kind: field
Symbol: `CD2DResource.m_pParentTarget`

#### Summary

Pointer to the parent CRenderTarget)

### `F:CD2DResource.m_bIsAutoDestroy`

Member kind: field
Symbol: `CD2DResource.m_bIsAutoDestroy`

#### Summary

Resource will be destoyed by owner (CRenderTarget)

### `M:CD2DResource.IsValid`

Member kind: method
Symbol: `CD2DResource.IsValid`

#### Summary

Checks resource validity

#### Returns

TRUE if resource is valid; otherwise FALSE.

### `M:CD2DResource.Destroy`

Member kind: method
Symbol: `CD2DResource.Destroy`

#### Summary

Destroys a CD2DResource object.

### `M:CD2DResource.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DResource.Create(CRenderTarget*)`

#### Summary

Creates a CD2DResource.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DResource.ReCreate(CRenderTarget*)`

Member kind: method
Symbol: `CD2DResource.ReCreate(CRenderTarget*)`

#### Summary

Re-creates a CD2DResource.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DResource.IsAutoDestroy`

Member kind: method
Symbol: `CD2DResource.IsAutoDestroy`

#### Summary

Check auto destroy flag.

#### Returns

TRUE if the object will be destroyed by its owner; otherwise FALSE.

### `M:CD2DResource.Dispose`

Member kind: method
Symbol: `CD2DResource.Dispose`

#### Summary

The destructor. Called when a D2D resource object is being destroyed.

### `M:CD2DResource.#ctor(CRenderTarget*,System.Int32)`

Member kind: method
Symbol: `CD2DResource.#ctor(CRenderTarget*,System.Int32)`

#### Summary

Constructs a CD2DResource object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DResource`

Member kind: type
Symbol: `CD2DResource`

#### Summary

An abstract class, which provides a interface for creating and managing D2D resources such as brushes, layers and texts.

### `M:CD2DEllipse.#ctor(CD2DPointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DSizeF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DEllipse.#ctor(CD2DPointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DSizeF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DEllipse from CD2DPointF and CD2DSizeF objects.

#### Parameter `ptCenter`

The center point of the ellipse.

#### Parameter `sizeRadius`

The X-radius and Y-radius of the ellipse.

### `M:CD2DEllipse.#ctor(D2D1_ELLIPSE!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DEllipse.#ctor(D2D1_ELLIPSE!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DEllipse object from D2D1_ELLIPSE object.

#### Parameter `ellipse`

source ellipse

### `M:CD2DEllipse.#ctor(D2D1_ELLIPSE!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DEllipse.#ctor(D2D1_ELLIPSE!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DEllipse object from D2D1_ELLIPSE object.

#### Parameter `ellipse`

source ellipse

### `M:CD2DEllipse.#ctor(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DEllipse.#ctor(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DEllipse object from CD2DRectF object.

#### Parameter `rect`

source rectangle

### `T:CD2DEllipse`

Member kind: type
Symbol: `CD2DEllipse`

#### Summary

D2D1_ELLIPSE wrapper

### `M:CD2DRoundedRect.#ctor(D2D1_ROUNDED_RECT!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DRoundedRect.#ctor(D2D1_ROUNDED_RECT!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DRoundedRect object from D2D1_ROUNDED_RECT object.

#### Parameter `rectIn`

source rectangle

### `M:CD2DRoundedRect.#ctor(D2D1_ROUNDED_RECT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DRoundedRect.#ctor(D2D1_ROUNDED_RECT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DRoundedRect object from D2D1_ROUNDED_RECT object.

#### Parameter `rectIn`

source rectangle

### `M:CD2DRoundedRect.#ctor(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DSizeF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DRoundedRect.#ctor(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DSizeF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DRoundedRect object from CD2DRectF object.

#### Parameter `rectIn`

source rectangle

#### Parameter `sizeRadius`

radius size

### `T:CD2DRoundedRect`

Member kind: type
Symbol: `CD2DRoundedRect`

#### Summary

D2D1_ROUNDED_RECT wrapper

### `M:CD2DRectU.op_Implicit~CRect`

Member kind: method
Symbol: `CD2DRectU.op_Implicit~CRect`

#### Summary

Converts CD2DRectU to CRect object.

#### Returns

Current value of D2D rectangle.

### `M:CD2DRectU.IsNull`

Member kind: method
Symbol: `CD2DRectU.IsNull`

#### Summary

Returns a Boolean value that indicates whether an expression contains no valid data (Null).

#### Returns

TRUE if rectangle's top, left, bottom, and right values are all equal to 0; otherwise FALSE.

### `M:CD2DRectU.#ctor(System.UInt32,System.UInt32,System.UInt32,System.UInt32)`

Member kind: method
Symbol: `CD2DRectU.#ctor(System.UInt32,System.UInt32,System.UInt32,System.UInt32)`

#### Summary

Constructs a CD2DRectU object from four UINT32 values.

#### Parameter `uLeft`

source left coordinate

#### Parameter `uTop`

source top coordinate

#### Parameter `uRight`

source right coordinate

#### Parameter `uBottom`

source bottom coordinate

### `M:CD2DRectU.#ctor(D2D_RECT_U!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DRectU.#ctor(D2D_RECT_U!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DRectU object from D2D1_RECT_U object.

#### Parameter `rect`

source rectangle

### `M:CD2DRectU.#ctor(D2D_RECT_U!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DRectU.#ctor(D2D_RECT_U!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DRectU object from D2D1_RECT_U object.

#### Parameter `rect`

source rectangle

### `M:CD2DRectU.#ctor(CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DRectU.#ctor(CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DRectU object from CRect object.

#### Parameter `rect`

source rectangle

### `T:CD2DRectU`

Member kind: type
Symbol: `CD2DRectU`

#### Summary

D2D1_RECT_U wrapper

### `M:CD2DRectF.op_Implicit~CRect`

Member kind: method
Symbol: `CD2DRectF.op_Implicit~CRect`

#### Summary

Converts CD2DRectF to CRect object.

#### Returns

Current value of D2D rectangle.

### `M:CD2DRectF.IsNull`

Member kind: method
Symbol: `CD2DRectF.IsNull`

#### Summary

Returns a Boolean value that indicates whether an expression contains no valid data (Null).

#### Returns

TRUE if rectangle's top, left, bottom, and right values are all equal to 0; otherwise FALSE.

### `M:CD2DRectF.#ctor(System.Single,System.Single,System.Single,System.Single)`

Member kind: method
Symbol: `CD2DRectF.#ctor(System.Single,System.Single,System.Single,System.Single)`

#### Summary

Constructs a CD2DRectF object from four FLOAT values.

#### Parameter `fLeft`

source left coordinate

#### Parameter `fTop`

source top coordinate

#### Parameter `fRight`

source right coordinate

#### Parameter `fBottom`

source bottom coordinate

### `M:CD2DRectF.#ctor(D2D_RECT_F!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DRectF.#ctor(D2D_RECT_F!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DRectF object from D2D1_RECT_F object.

#### Parameter `rect`

source rectangle

### `M:CD2DRectF.#ctor(D2D_RECT_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DRectF.#ctor(D2D_RECT_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DRectF object from D2D1_RECT_F object.

#### Parameter `rect`

source rectangle

### `M:CD2DRectF.#ctor(CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DRectF.#ctor(CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DRectF object from CRect object.

#### Parameter `rect`

source rectangle

### `T:CD2DRectF`

Member kind: type
Symbol: `CD2DRectF`

#### Summary

D2D1_RECT_F wrapper

### `M:CD2DSizeU.op_Implicit~CSize`

Member kind: method
Symbol: `CD2DSizeU.op_Implicit~CSize`

#### Summary

Converts CD2DSizeU to CSize object.

#### Returns

Current value of D2D size.

### `M:CD2DSizeU.IsNull`

Member kind: method
Symbol: `CD2DSizeU.IsNull`

#### Summary

Returns a Boolean value that indicates whether an expression contains no valid data (Null).

#### Returns

TRUE if width and height are empty; otherwise FALSE.

### `M:CD2DSizeU.#ctor(System.UInt32,System.UInt32)`

Member kind: method
Symbol: `CD2DSizeU.#ctor(System.UInt32,System.UInt32)`

#### Summary

Constructs a CD2DSizeU object from two UINT32 values.

#### Parameter `cx`

source width

#### Parameter `cy`

source height

### `M:CD2DSizeU.#ctor(D2D_SIZE_U!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DSizeU.#ctor(D2D_SIZE_U!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DSizeU object from D2D1_SIZE_U object.

#### Parameter `size`

source size

### `M:CD2DSizeU.#ctor(D2D_SIZE_U!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DSizeU.#ctor(D2D_SIZE_U!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DSizeU object from D2D1_SIZE_U object.

#### Parameter `size`

source size

### `M:CD2DSizeU.#ctor(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DSizeU.#ctor(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DSizeU object from CSize object.

#### Parameter `size`

source size

### `T:CD2DSizeU`

Member kind: type
Symbol: `CD2DSizeU`

#### Summary

D2D1_SIZE_U wrapper

### `M:CD2DSizeF.op_Implicit~CSize`

Member kind: method
Symbol: `CD2DSizeF.op_Implicit~CSize`

#### Summary

Converts CD2DSizeF to CSize object.

#### Returns

Current value of D2D size.

### `M:CD2DSizeF.IsNull`

Member kind: method
Symbol: `CD2DSizeF.IsNull`

#### Summary

Returns a Boolean value that indicates whether an expression contains no valid data (Null).

#### Returns

TRUE if width and height are empty; otherwise FALSE.

### `M:CD2DSizeF.#ctor(System.Single,System.Single)`

Member kind: method
Symbol: `CD2DSizeF.#ctor(System.Single,System.Single)`

#### Summary

Constructs a CD2DSizeF object from two FLOAT values.

#### Parameter `cx`

source width

#### Parameter `cy`

source height

### `M:CD2DSizeF.#ctor(D2D_SIZE_F!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DSizeF.#ctor(D2D_SIZE_F!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DSizeF object from D2D1_SIZE_F object.

#### Parameter `size`

source size

### `M:CD2DSizeF.#ctor(D2D_SIZE_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DSizeF.#ctor(D2D_SIZE_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DSizeF object from D2D1_SIZE_F object.

#### Parameter `size`

source size

### `M:CD2DSizeF.#ctor(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DSizeF.#ctor(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DSizeF object from CSize object.

#### Parameter `size`

source size

### `T:CD2DSizeF`

Member kind: type
Symbol: `CD2DSizeF`

#### Summary

D2D1_SIZE_F wrapper

### `M:CD2DPointU.op_Implicit~CPoint`

Member kind: method
Symbol: `CD2DPointU.op_Implicit~CPoint`

#### Summary

Converts CD2DPointU to CPoint object.

#### Returns

Current value of D2D point.

### `M:CD2DPointU.#ctor(System.UInt32,System.UInt32)`

Member kind: method
Symbol: `CD2DPointU.#ctor(System.UInt32,System.UInt32)`

#### Summary

Constructs a CD2DPointU object from two UINT32 values.

#### Parameter `uX`

source X

#### Parameter `uY`

source Y

### `M:CD2DPointU.#ctor(D2D_POINT_2U!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DPointU.#ctor(D2D_POINT_2U!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DPointU from object D2D1_POINT_2U object.

#### Parameter `pt`

source point

### `M:CD2DPointU.#ctor(D2D_POINT_2U!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DPointU.#ctor(D2D_POINT_2U!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DPointU from object D2D1_POINT_2U object.

#### Parameter `pt`

source point

### `M:CD2DPointU.#ctor(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DPointU.#ctor(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DPointU object from CPoint object.

#### Parameter `pt`

source point

### `T:CD2DPointU`

Member kind: type
Symbol: `CD2DPointU`

#### Summary

D2D1_POINT_2U wrapper

### `M:CD2DPointF.op_Implicit~CPoint`

Member kind: method
Symbol: `CD2DPointF.op_Implicit~CPoint`

#### Summary

Converts CD2DPointF to CPoint object.

#### Returns

Current value of D2D point.

### `M:CD2DPointF.#ctor(System.Single,System.Single)`

Member kind: method
Symbol: `CD2DPointF.#ctor(System.Single,System.Single)`

#### Summary

Constructs a CD2DPointF object from two FLOAT values.

#### Parameter `fX`

source X

#### Parameter `fY`

source Y

### `M:CD2DPointF.#ctor(D2D_POINT_2F!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DPointF.#ctor(D2D_POINT_2F!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DPointF object from D2D1_POINT_2F object.

#### Parameter `pt`

source point

### `M:CD2DPointF.#ctor(D2D_POINT_2F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DPointF.#ctor(D2D_POINT_2F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DPointF object from D2D1_POINT_2F object.

#### Parameter `pt`

source point

### `M:CD2DPointF.#ctor(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DPointF.#ctor(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DPointF object from CPoint object.

#### Parameter `pt`

source point

### `T:CD2DPointF`

Member kind: type
Symbol: `CD2DPointF`

#### Summary

D2D1_POINT_2F wrapper

### `M:CCustomTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CCustomTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Remarks

This method also can set initial value and initial velocity to be applied to an animation variable, which is
associated with this transition. For this purpose you have to call SetInitialValue and SetInitialVelocity before
the framework creates the encapsulated transition COM object (it happens when you call CAnimationController::AnimateGroup).

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `M:CCustomTransition.SetInitialVelocity(System.Double)`

Member kind: method
Symbol: `CCustomTransition.SetInitialVelocity(System.Double)`

#### Summary

Sets an initial velocity, which will be applied to an animation variable associated with this transition.

### `M:CCustomTransition.SetInitialValue(System.Double)`

Member kind: method
Symbol: `CCustomTransition.SetInitialValue(System.Double)`

#### Summary

Sets an initial value, which will be applied to an animation variable associated with this transition.

### `M:CCustomTransition.#ctor(CCustomInterpolator*)`

Member kind: method
Symbol: `CCustomTransition.#ctor(CCustomInterpolator*)`

#### Summary

Constructs a custom transition object.

#### Parameter `pInterpolator`

A pointer to custom interpolator.

### `F:CCustomTransition.m_initialVelocity`

Member kind: field
Symbol: `CCustomTransition.m_initialVelocity`

#### Summary

Stores the initial velocity.

### `F:CCustomTransition.m_initialValue`

Member kind: field
Symbol: `CCustomTransition.m_initialValue`

#### Summary

Stores the initial value.

### `F:CCustomTransition.m_bInitialVelocitySpecified`

Member kind: field
Symbol: `CCustomTransition.m_bInitialVelocitySpecified`

#### Summary

Specifies whether the initial velocity was specified with SetInitialVelocity.

### `F:CCustomTransition.m_bInitialValueSpecified`

Member kind: field
Symbol: `CCustomTransition.m_bInitialValueSpecified`

#### Summary

Specifies whether the initial value was specified with SetInitialValue.

### `F:CCustomTransition.m_pInterpolator`

Member kind: field
Symbol: `CCustomTransition.m_pInterpolator`

#### Summary

Stores a pointer to a custom interpolator.

### `T:CCustomTransition`

Member kind: type
Symbol: `CCustomTransition`

#### Summary

Implements custom transition.

#### Remarks

The CCustomTransitions class allows developers to implement custom transitions. It's created and used
as a standard transition, but its constructor accepts as parameter a pointer to a custom interpolator.
Perform the following steps to use custom transitions:
1. Derive a class from CCustomInterpolator and implement at least InterpolateValue method.
2. Ensure that the lifetime of custom interpolator object must be longer than duration of animation where it's used.
3. Instantiate (using operator new) a CCustomTransition object and pass a pointer to custom interpolator in the constructor.
4. Call CCustomTransition::SetInitialValue and CCustomTransition::SetInitialVelocity if these parameters are required for custom interpolation.
5. Pass the pointer to custom transition to AddTransition method of animation object, whose value should be animated with the custom algorithm.
6. When the value of animation object should change Windows Animation API will call InterpolateValue (and other relevant methods) in CCustomInterpolator.

### `M:CInterpolatorBase.GetDependencies(__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*)`

Member kind: method
Symbol: `CInterpolatorBase.GetDependencies(__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*)`

#### Summary

Gets the interpolator's dependencies.

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the GetDependencies method.

#### Parameter `initialValueDependencies`

Output. Aspects of the interpolator that depend on the initial value passed to SetInitialValueAndVelocity.

#### Parameter `initialVelocityDependencies`

Output. Aspects of the interpolator that depend on the initial velocity passed to SetInitialValueAndVelocity.

#### Parameter `durationDependencies`

Output. Aspects of the interpolator that depend on the duration passed to SetDuration.

### `M:CInterpolatorBase.InterpolateVelocity(System.Double,System.Double*)`

Member kind: method
Symbol: `CInterpolatorBase.InterpolateVelocity(System.Double,System.Double*)`

#### Summary

Interpolates the velocity at a given offset

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the InterpolateVelocity method.

#### Parameter `offset`

The offset from the start of the transition.
The offset is always greater than or equal to zero and less than or equal to the duration of the transition.
This method is not called if the duration of the transition is zero.

#### Parameter `velocity`

Output. The velocity of the variable at the offset.

### `M:CInterpolatorBase.InterpolateValue(System.Double,System.Double*)`

Member kind: method
Symbol: `CInterpolatorBase.InterpolateValue(System.Double,System.Double*)`

#### Summary

Interpolates the value at a given offset

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the InterpolateValue method.

#### Parameter `offset`

The offset from the start of the transition.
The offset is always greater than or equal to zero and less than the duration of the transition.
This method is not called if the duration of the transition is zero.

#### Parameter `value`

Output. The interpolated value.

### `M:CInterpolatorBase.GetFinalValue(System.Double*)`

Member kind: method
Symbol: `CInterpolatorBase.GetFinalValue(System.Double*)`

#### Summary

Gets the final value to which the interpolator leads.

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the GetFinalValue method.

#### Parameter `value`

Output. The final value of a variable at the end of the transition.

### `M:CInterpolatorBase.GetDuration(System.Double*)`

Member kind: method
Symbol: `CInterpolatorBase.GetDuration(System.Double*)`

#### Summary

Gets the interpolator's duration.

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the GetDuration method.

#### Parameter `duration`

Output. The duration of the transition, in seconds.

### `M:CInterpolatorBase.SetDuration(System.Double)`

Member kind: method
Symbol: `CInterpolatorBase.SetDuration(System.Double)`

#### Summary

Sets the interpolator's duration

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the SetDuration method.

#### Parameter `duration`

The duration of the transition.

### `M:CInterpolatorBase.SetInitialValueAndVelocity(System.Double,System.Double)`

Member kind: method
Symbol: `CInterpolatorBase.SetInitialValueAndVelocity(System.Double,System.Double)`

#### Summary

Sets the interpolator's initial value and velocity.

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the SetInitialValueAndVelocity method.

#### Parameter `initialValue`

The value of the variable at the start of the transition.

#### Parameter `initialVelocity`

The velocity of the variable at the start of the transition.

### `M:CInterpolatorBase.CreateInstance(CCustomInterpolator*,IUIAnimationInterpolator**)`

Member kind: method
Symbol: `CInterpolatorBase.CreateInstance(CCustomInterpolator*,IUIAnimationInterpolator**)`

#### Summary

Creates an instance of CInterpolatorBase and stores a pointer to custom interpolator, which will be handling events.

#### Parameter `pInterpolator`

A pointer to custom interpolator.

#### Parameter `ppHandler`

Output. Contains a pointer to instance of CInterpolatorBase when the function returns.

### `M:CInterpolatorBase.SetCustomInterpolator(CCustomInterpolator*)`

Member kind: method
Symbol: `CInterpolatorBase.SetCustomInterpolator(CCustomInterpolator*)`

#### Summary

Stores a pointer to custom interpolator, which will be handling events.

#### Parameter `pInterpolator`

A pointer to custom interpolator.

### `M:CInterpolatorBase.#ctor`

Member kind: method
Symbol: `CInterpolatorBase.#ctor`

#### Summary

Constructs the CInterpolatorBase object.

### `T:CInterpolatorBase`

Member kind: type
Symbol: `CInterpolatorBase`

#### Summary

Implements a callback, which is called by Animation API when it needs to calculate a new value of animation variable.

#### Remarks

This handler is created and passed to IUIAnimationTransitionFactory::CreateTransition when a CCustomTransition
object is being created as a part of animation initialization process (started by CAnimationController::AnimateGroup).
Usually you don't need to use this class directly, it just routs all events to a CCustomInterpolator-derived class, whose
pointer is passed to constructor of CCustomTransition.

### `M:CCustomInterpolator.GetDependencies(__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*)`

Member kind: method
Symbol: `CCustomInterpolator.GetDependencies(__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*)`

#### Summary

Gets the interpolator's dependencies.

#### Returns

Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `initialValueDependencies`

Output. Aspects of the interpolator that depend on the initial value passed to SetInitialValueAndVelocity.

#### Parameter `initialVelocityDependencies`

Output. Aspects of the interpolator that depend on the initial velocity passed to SetInitialValueAndVelocity.

#### Parameter `durationDependencies`

Output. Aspects of the interpolator that depend on the duration passed to SetDuration.

### `M:CCustomInterpolator.InterpolateVelocity(System.Double,System.Double*)`

Member kind: method
Symbol: `CCustomInterpolator.InterpolateVelocity(System.Double,System.Double*)`

#### Summary

Interpolates the velocity at a given offset

#### Returns

Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `offset`

The offset from the start of the transition.
The offset is always greater than or equal to zero and less than or equal to the duration of the transition.
This method is not called if the duration of the transition is zero.

#### Parameter `velocity`

Output. The velocity of the variable at the offset.

### `M:CCustomInterpolator.InterpolateValue(System.Double,System.Double*)`

Member kind: method
Symbol: `CCustomInterpolator.InterpolateValue(System.Double,System.Double*)`

#### Summary

Interpolates the value at a given offset.

#### Returns

Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `offset`

The offset from the start of the transition.
The offset is always greater than or equal to zero and less than the duration of the transition.
This method is not called if the duration of the transition is zero.

#### Parameter `value`

Output. The interpolated value.

### `M:CCustomInterpolator.GetFinalValue(System.Double*)`

Member kind: method
Symbol: `CCustomInterpolator.GetFinalValue(System.Double*)`

#### Summary

Gets the final value to which the interpolator leads.

#### Returns

Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `value`

Output. The final value of a variable at the end of the transition.

### `M:CCustomInterpolator.GetDuration(System.Double*)`

Member kind: method
Symbol: `CCustomInterpolator.GetDuration(System.Double*)`

#### Summary

Gets the interpolator's duration.

#### Returns

Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `duration`

Output. The duration of the transition, in seconds.

### `M:CCustomInterpolator.SetDuration(System.Double)`

Member kind: method
Symbol: `CCustomInterpolator.SetDuration(System.Double)`

#### Summary

Sets the interpolator's duration.

#### Returns

Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `duration`

The duration of the transition.

### `M:CCustomInterpolator.SetInitialValueAndVelocity(System.Double,System.Double)`

Member kind: method
Symbol: `CCustomInterpolator.SetInitialValueAndVelocity(System.Double,System.Double)`

#### Summary

Sets the interpolator's initial value and velocity.

#### Returns

The basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `initialValue`

The value of the variable at the start of the transition.

#### Parameter `initialVelocity`

The velocity of the variable at the start of the transition.

### `M:CCustomInterpolator.Init(System.Double,System.Double)`

Member kind: method
Symbol: `CCustomInterpolator.Init(System.Double,System.Double)`

#### Summary

Initializes duration and final value.

#### Parameter `duration`

The duration of the transition.

#### Parameter `finalValue`

The final value of a variable at the end of the transition.

### `M:CCustomInterpolator.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `CCustomInterpolator.#ctor(System.Double,System.Double)`

#### Summary

Constructs a custom interpolator object and initializes duration and velocity to specified values.

#### Parameter `duration`

The duration of the transition.

### `M:CCustomInterpolator.#ctor`

Member kind: method
Symbol: `CCustomInterpolator.#ctor`

#### Summary

Constructs a custom interpolator object and sets all values to default 0.

#### Remarks

Use CCustomInterpolator::Init to initialize duration and final value later in the code.

### `F:CCustomInterpolator.m_currentVelocity`

Member kind: field
Symbol: `CCustomInterpolator.m_currentVelocity`

#### Summary

The interpolated velocity.

### `F:CCustomInterpolator.m_currentValue`

Member kind: field
Symbol: `CCustomInterpolator.m_currentValue`

#### Summary

The interpolated value.

### `F:CCustomInterpolator.m_initialVelocity`

Member kind: field
Symbol: `CCustomInterpolator.m_initialVelocity`

#### Summary

The velocity of the variable at the start of the transition.

### `F:CCustomInterpolator.m_initialValue`

Member kind: field
Symbol: `CCustomInterpolator.m_initialValue`

#### Summary

The value of the variable at the start of the transition.

### `F:CCustomInterpolator.m_finalValue`

Member kind: field
Symbol: `CCustomInterpolator.m_finalValue`

#### Summary

The final value of a variable at the end of the transition.

### `F:CCustomInterpolator.m_duration`

Member kind: field
Symbol: `CCustomInterpolator.m_duration`

#### Summary

The duration of the transition.

### `T:CCustomInterpolator`

Member kind: type
Symbol: `CCustomInterpolator`

#### Summary

Implements a basic interpolator.

#### Remarks

Derive a class from CCustomInterpolator and override all necessary methods in order to implement a custom
interpolation algorithm. A pointer to this class should be passed as a parameter to CCustomTransition.

### `M:CSinusoidalTransitionFromVelocity.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CSinusoidalTransitionFromVelocity.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CSinusoidalTransitionFromVelocity.m_period`

Member kind: field
Symbol: `CSinusoidalTransitionFromVelocity.m_period`

#### Summary

The period of oscillation of the sinusoidal wave in seconds.

### `F:CSinusoidalTransitionFromVelocity.m_duration`

Member kind: field
Symbol: `CSinusoidalTransitionFromVelocity.m_duration`

#### Summary

The duration of the transition.

### `M:CSinusoidalTransitionFromVelocity.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `CSinusoidalTransitionFromVelocity.#ctor(System.Double,System.Double)`

#### Summary

Constructs a transition object.

#### Parameter `duration`

The duration of the transition.

#### Parameter `period`

The period of oscillation of the sinusoidal wave in seconds.

### `T:CSinusoidalTransitionFromVelocity`

Member kind: type
Symbol: `CSinusoidalTransitionFromVelocity`

#### Summary

Encapsulates a sinusoidal-velocity transition, with an amplitude determined by the animation variable's initial velocity..

#### Remarks

The value of the animation variable oscillates around the initial value over the entire duration of a
sinusoidal-range transition. The amplitude of the oscillation is determined by the animation variable's velocity
when the transition begins.
Because all transitions are cleared automatically, it's recommended to allocated them using operator new.
The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then
it's NULL. Changing member variables after creation of this COM object has no effect.

### `M:CSinusoidalTransitionFromRange.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CSinusoidalTransitionFromRange.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CSinusoidalTransitionFromRange.m_slope`

Member kind: field
Symbol: `CSinusoidalTransitionFromRange.m_slope`

#### Summary

The slope at the start of the transition.

### `F:CSinusoidalTransitionFromRange.m_period`

Member kind: field
Symbol: `CSinusoidalTransitionFromRange.m_period`

#### Summary

The period of oscillation of the sinusoidal wave in seconds.

### `F:CSinusoidalTransitionFromRange.m_dblMaximumValue`

Member kind: field
Symbol: `CSinusoidalTransitionFromRange.m_dblMaximumValue`

#### Summary

The value of the animation variable at a peak of the sinusoidal wave.

### `F:CSinusoidalTransitionFromRange.m_dblMinimumValue`

Member kind: field
Symbol: `CSinusoidalTransitionFromRange.m_dblMinimumValue`

#### Summary

The value of the animation variable at a trough of the sinusoidal wave.

### `F:CSinusoidalTransitionFromRange.m_duration`

Member kind: field
Symbol: `CSinusoidalTransitionFromRange.m_duration`

#### Summary

The duration of the transition.

### `M:CSinusoidalTransitionFromRange.#ctor(System.Double,System.Double,System.Double,System.Double,__MIDL___MIDL_itf_UIAnimation_0000_0009_0001)`

Member kind: method
Symbol: `CSinusoidalTransitionFromRange.#ctor(System.Double,System.Double,System.Double,System.Double,__MIDL___MIDL_itf_UIAnimation_0000_0009_0001)`

#### Summary

Constructs a transition object.

#### Parameter `duration`

The duration of the transition.

#### Parameter `dblMinimumValue`

The value of the animation variable at a trough of the sinusoidal wave.

#### Parameter `dblMaximumValue`

The value of the animation variable at a peak of the sinusoidal wave.

#### Parameter `period`

The period of oscillation of the sinusoidal wave in seconds.

#### Parameter `slope`

The slope at the start of the transition.
