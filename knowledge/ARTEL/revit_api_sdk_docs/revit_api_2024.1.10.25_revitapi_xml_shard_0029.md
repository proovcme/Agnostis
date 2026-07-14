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
Shard: 29
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.WorksetConfiguration.#ctor(Autodesk.Revit.DB.WorksetConfiguration)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetConfiguration.#ctor(Autodesk.Revit.DB.WorksetConfiguration)`

#### Summary

Constructs a new copy of the input WorksetConfiguration object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.WorksetConfiguration`

Member kind: type
Symbol: `Autodesk.Revit.DB.WorksetConfiguration`

#### Summary

A configuration class that is passed in to methods that open Revit documents to specify which user-created worksets are opened/closed.

#### Remarks

Once an instance of this class is created, it can be further modified
by calling any of the other methods in any order. It is a specification of a setting for model open;
the methods of this class just adjust the specification, and do not themselves open or close worksets.

Only user-created worksets can be specified to be opened or closed. All system worksets are automatically open.
An open workset allows its elements can be expanded and displayed.
For a closed workset, Revit tries to not expand its elements, and to that end, does not display them.
This is intended to help with performance by reducing Revit's memory footprint.

#### Since

2014

### `T:Autodesk.Revit.DB.WorksetConfigurationOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.WorksetConfigurationOption`

#### Summary

A collection of options used to initialize a WorksetConfiguration.

#### Since

2015

### `F:Autodesk.Revit.DB.WorksetConfigurationOption.OpenLastViewed`

Member kind: field
Symbol: `Autodesk.Revit.DB.WorksetConfigurationOption.OpenLastViewed`

#### Summary

Close all user-created worksets by default, but open last viewed worksets.

### `F:Autodesk.Revit.DB.WorksetConfigurationOption.CloseAllWorksets`

Member kind: field
Symbol: `Autodesk.Revit.DB.WorksetConfigurationOption.CloseAllWorksets`

#### Summary

Close all user-created worksets by default. Additional close requests will be ignored for this type of configuration.

### `F:Autodesk.Revit.DB.WorksetConfigurationOption.OpenAllWorksets`

Member kind: field
Symbol: `Autodesk.Revit.DB.WorksetConfigurationOption.OpenAllWorksets`

#### Summary

Open all user-created worksets by default. Additional open requests will be ignored for this type of configuration.

### `M:Autodesk.Revit.DB.RevitLinkOptions.SetWorksetConfiguration(Autodesk.Revit.DB.WorksetConfiguration)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkOptions.SetWorksetConfiguration(Autodesk.Revit.DB.WorksetConfiguration)`

#### Summary

Sets the set of worksets to open when creating the link.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.RevitLinkOptions.GetWorksetConfiguration`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkOptions.GetWorksetConfiguration`

#### Summary

Gets the set of worksets to open when creating the link.

#### Since

2014

### `P:Autodesk.Revit.DB.RevitLinkOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevitLinkOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RevitLinkOptions.IsRelative`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevitLinkOptions.IsRelative`

#### Summary

The type of path to use when creating the link. If true, Revit will
store a relative path for the link. If false, Revit will store an absolute
path.

If the link is to a Revit Server location, isRelative must be false.

#### Since

2013

### `M:Autodesk.Revit.DB.RevitLinkOptions.#ctor(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkOptions.#ctor(System.Boolean)`

#### Summary

Creates a RevitLinkOptions object, specifying relative or absolute path type.
If the link is workshared, all worksets will be opened.

#### Parameter `relative`

True if the link should use a relative path. False if it should use an
absolute path.

#### Since

2013

### `M:Autodesk.Revit.DB.RevitLinkOptions.#ctor(System.Boolean,Autodesk.Revit.DB.WorksetConfiguration)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkOptions.#ctor(System.Boolean,Autodesk.Revit.DB.WorksetConfiguration)`

#### Summary

Creates a RevitLinkOptions object, specifying relative or absolute path type,
and the desired workset configuration.

#### Parameter `relative`

True if the link should use a relative path. False if it should use an
absolute path.

#### Parameter `config`

A WorksetConfiguration object specifying the worksets to open when creating
the link.
Leave as `null` if the file is not workshared.
Optionally, this may also be `null` for a workshared
file, in which case Revit will open all worksets.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.RevitLinkOptions.#ctor(Autodesk.Revit.DB.RevitLinkOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkOptions.#ctor(Autodesk.Revit.DB.RevitLinkOptions)`

#### Summary

Constructs a new copy of the input RevitLinkOptions object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.RevitLinkOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.RevitLinkOptions`

#### Summary

This class contains the options in use when creating
or loading a Revit link.

#### Since

2013

### `M:Autodesk.Revit.DB.IGetLocalPathForOpenCallbackProxy.GetLocalPathForOpen(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IGetLocalPathForOpenCallbackProxy.GetLocalPathForOpen(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Implement this method to specify the local path from where a copy of a Revit link external resource can be opened
for modification without interfering with its use as a link in other open documents.

#### Parameter `desiredResource`

The ExternalResourceReference that needs to be opened for modification by Revit.

#### Returns

The local path from where Revit can open the linked file as its own top-level document.

#### Since

2015

### `M:Autodesk.Revit.DB.IGetLocalPathForOpenCallback.GetLocalPathForOpen(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IGetLocalPathForOpenCallback.GetLocalPathForOpen(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Implement this method to specify the local path from where a copy of a Revit link external resource can be opened
for modification without interfering with its use as a link in other open documents.

#### Parameter `desiredResource`

The ExternalResourceReference that needs to be opened for modification by Revit.

#### Returns

The local path from where Revit can open the linked file as its own top-level document.

#### Since

2015

### `T:Autodesk.Revit.DB.IGetLocalPathForOpenCallback`

Member kind: type
Symbol: `Autodesk.Revit.DB.IGetLocalPathForOpenCallback`

#### Summary

The interface used to provide custom support for the "Open (and Unload)" command for Revit Links obtained as external resources.

#### Remarks

Revit documents that are linked into host documents are read-only. If the user wishes to edit a linked Revit file
they can use the "Open (and Unload)" command to unload the link, and automatically load it directly as a top-level,
modifiable document (Revit files cannot be edited while they are being used as links). To support this operation for
Revit links obtained as external resources, IExternalResourceServer authors should implement this callback. They
should return a local path from where Revit can open the linked document for edit. Ideally, this should be a
path that is different than the location from where it has been loaded as a link.

Once the user opens a link as a top-level document, they will presumably make changes to it and save it. It is
the responsibility of the server to upload whatever changes the user makes so that the version stored on the server
remains the most current. Server providers can determine when changes have been made by the user to local file
by watching for the DocumentSaved event.

#### Since

2015

### `M:Autodesk.Revit.RevitCloudConfigADPInfo.OutputAdp(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.RevitCloudConfigADPInfo.OutputAdp(System.String,System.String)`

#### Summary

Detail download information
Uri of Revit cloud configuration to download

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.RevitCloudConfigADPInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.RevitCloudConfigADPInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.RevitCloudConfigADPInfo`

Member kind: type
Symbol: `Autodesk.Revit.RevitCloudConfigADPInfo`

#### Summary

ADP output helper class.
We use this to describe what we want to output to adp

### `T:Autodesk.Revit.RevitCloudConfigWaypointsAndAttributes`

Member kind: type
Symbol: `Autodesk.Revit.RevitCloudConfigWaypointsAndAttributes`

#### Summary

This class represents a list of waypoints and attributes used by Revit Cloud Configuration

### `M:Autodesk.Revit.DB.RevisionSettings.IsAcceptableRevisionCloudSpacing(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionSettings.IsAcceptableRevisionCloudSpacing(System.Double)`

#### Summary

Rounds the given raw value and checks whether it is an acceptable cloud spacing value after it is rounded.

#### Remarks

After rounding, the value must be a valid length that is greater than zero.

#### Parameter `rawValue`

The raw value to check. This value need not be rounded prior to calling this function.

#### Returns

True if the value will be acceptable after rounding, False otherwise

#### Since

2015

### `M:Autodesk.Revit.DB.RevisionSettings.RoundRevisionCloudSpacing(Autodesk.Revit.DB.Document,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionSettings.RoundRevisionCloudSpacing(Autodesk.Revit.DB.Document,System.Double)`

#### Summary

Rounds the given revision cloud spacing value according to the document's settings.

#### Parameter `ccda`

The document to use for rounding.

#### Parameter `rawValue`

The unrounded value.

#### Returns

The rounded revision cloud spacing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.RevisionSettings.GetRevisionSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionSettings.GetRevisionSettings(Autodesk.Revit.DB.Document)`

#### Summary

Returns the RevisionSettings for the given project document.

#### Parameter `ccda`

The document to get the RevisionSettings from.

#### Returns

The RevisionSettings for the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

ccda is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.RevisionSettings.RevisionCloudSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevisionSettings.RevisionCloudSpacing`

#### Summary

Determines the size in paper space of revision clouds drawn in a project.

#### Remarks

Revision clouds in Revit are created based on a collection of sketched lines. Revit then
generates a series of "cloud bumps" along those lines to create a cloud shape. This setting
determines the minimum length between the start and end each "cloud bump" (measured along the line).
For example, if this setting were 2" and the sketched line were 3" long, Revit would
create only one 3" bump. If the line length was increased to 4", Revit would add two 2" ones.
Note that a single "cloud bump" consists of two arcs of slightly different size. Revit will always
draw at least one "cloud bump" for each sketched line.

This value will be interpreted by Revit in paper space rather than in model space so
that all of the clouds are shown in a uniform way on a sheet.

This value will be rounded to a length that can be displayed according to the
current project settings. The value may not be zero after rounding. This value may not
exceed the maximum distance that can be represented as a length in Revit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: desiredCloudSpacing is not a valid value for the cloud spacing.

#### Since

2015

### `P:Autodesk.Revit.DB.RevisionSettings.RevisionNumbering`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevisionSettings.RevisionNumbering`

#### Summary

Determines how the revision number values will display on sheets.

#### Remarks

When revision clouds appear on a sheet, the revision number of each revision can be displayed either by
tagging the revision cloud or by a revision schedule within the sheet's titleblock. There
are two ways the number can be determined:
Per project: The value of the Revision numbers will always correspond to the project-wide Revision Sequence Number
assigned to the revision. For example, if revision clouds for revisions with sequence numbers 5, 7, and 8 are
placed on a sheet then revision tags and schedules on that sheet would display 5, 7, and 8.

Per sheet: Revision numbers will be assigned consecutive numbers based on the revision clouds
visible on that sheet. For example, if revision clouds for revisions assigned project-wide Revision Sequence Numbers 5, 7, and 8 are
placed on a sheet then revision tags and schedules on that sheet would display 1, 2, and 3.
The sequence on the sheet will still follow the relative ordering of the Revision Sequence Numbers,
so in this example revision 5 would be displayed as 1 on the sheet, revision 7 would be
displayed as 2, etc.
Note that changing this setting may change the numbering of revisions on any existing
sheets. The numbering will be changed even for revisions that are already issued.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `T:Autodesk.Revit.DB.RevisionSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.RevisionSettings`

#### Summary

Provides access to project-wide settings related to revisions.

#### Remarks

This class provides access to the project-wide settings that affect the appearance and numbering of revisions
and revision clouds. The settings are only available in project documents.

#### Since

2015

### `T:Autodesk.Revit.DB.RevisionNumbering`

Member kind: type
Symbol: `Autodesk.Revit.DB.RevisionNumbering`

#### Since

2015

#### Summary

The options for how revision numbers should be displayed on sheets within a project.

#### Since

2015

### `F:Autodesk.Revit.DB.RevisionNumbering.PerSheet`

Member kind: field
Symbol: `Autodesk.Revit.DB.RevisionNumbering.PerSheet`

#### Summary

The revisions on a given sheet will be automatically assigned a consecutive sequence for their revision numbers displayed on that sheet.

### `F:Autodesk.Revit.DB.RevisionNumbering.PerProject`

Member kind: field
Symbol: `Autodesk.Revit.DB.RevisionNumbering.PerProject`

#### Summary

The revision numbers on a sheet will match the global Revision Sequence Number assigned to the revision.

### `M:Autodesk.Revit.DB.AlphanumericRevisionSettings.SetSequence(System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.AlphanumericRevisionSettings.SetSequence(System.Collections.Generic.IList{System.String})`

#### Summary

Sets the sequence of strings to be used as numbers for revisions with the Alphanumeric RevisionNumberType.

#### Remarks

If there are more alphanumeric revisions than there are
strings in the sequence, subsequent alphanumeric revisions will
be assigned duplicated characters. For example, if the sequence
provided were ["X", "Y"], the first alphanumeric revision would
be shown as "X", the second as "Y", the third as "XX", then "YY",
"XXX", etc.

#### Parameter `sequence`

The sequence. The sequence strings cannot contain commas.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Input sequence contains invalid entries.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.AlphanumericRevisionSettings.GetSequence`

Member kind: method
Symbol: `Autodesk.Revit.DB.AlphanumericRevisionSettings.GetSequence`

#### Summary

Gets a list containing the strings to be used as the numbering sequence for
revisions with the Alphanumeric RevisionNumberType.

#### Since

2016

### `M:Autodesk.Revit.DB.AlphanumericRevisionSettings.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.AlphanumericRevisionSettings.IsValid`

#### Summary

Determines whether the AlphanumericRevisionSettings object is in a valid state.

#### Remarks

The AlphanumericRevisionSettings should have at least one string in its revision numbering sequence.

#### Returns

True if the settings are valid.

#### Since

2016

### `M:Autodesk.Revit.DB.AlphanumericRevisionSettings.IsEqual(Autodesk.Revit.DB.AlphanumericRevisionSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AlphanumericRevisionSettings.IsEqual(Autodesk.Revit.DB.AlphanumericRevisionSettings)`

#### Summary

Determines whether a specified AlphanumericRevisionSettings is the same as 'this'.

#### Remarks

The two AlphanumericRevisionSettings are regarded as the same only if they have the same
revision numbering sequence, and the same prefix and suffix strings.

#### Parameter `other`

The AlphanumericRevisionSettings object to be compared with 'this'.

#### Returns

True, if two AlphanumericRevisionSettings are the same.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.AlphanumericRevisionSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.AlphanumericRevisionSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.AlphanumericRevisionSettings.Suffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.AlphanumericRevisionSettings.Suffix`

#### Summary

The suffix string that will be appended to the number of each revision with Alphanumeric RevisionNumberingType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.AlphanumericRevisionSettings.Prefix`

Member kind: property
Symbol: `Autodesk.Revit.DB.AlphanumericRevisionSettings.Prefix`

#### Summary

The prefix string that will be prepended to the number of each revision with Alphanumeric RevisionNumberingType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.AlphanumericRevisionSettings.#ctor(System.Collections.Generic.IList{System.String},System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AlphanumericRevisionSettings.#ctor(System.Collections.Generic.IList{System.String},System.String,System.String)`

#### Summary

Constructs an AlphanumericRevisionSettings object.

#### Parameter `sequence`

The custom sequence to be used as numbers for revisions with the
Alphanumeric RevisionNumberType.

If there are more alphanumeric revisions than there are
strings in the sequence, subsequent alphanumeric revisions will
be assigned duplicated characters. For example, if the sequence
provided were ["X", "Y"], the first alphanumeric revision would
be shown as "X", the second as "Y", the third as "XX", then "YY",
"XXX", etc.

#### Parameter `prefix`

The prefix string for each revision number in the sequence.

#### Parameter `suffix`

The suffix string for each revision number in the sequence.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Input sequence contains invalid entries.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.AlphanumericRevisionSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.AlphanumericRevisionSettings.#ctor`

#### Summary

Constructs an AlphanumericRevisionSettings with a simple, default sequence.

#### Remarks

The default sequence contains each letter of the alphabet (may differ based on language settings).

#### Since

2016

### `M:Autodesk.Revit.DB.AlphanumericRevisionSettings.#ctor(Autodesk.Revit.DB.AlphanumericRevisionSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.AlphanumericRevisionSettings.#ctor(Autodesk.Revit.DB.AlphanumericRevisionSettings)`

#### Summary

Constructs a new copy of the input AlphanumericRevisionSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

other is not a valid AlphanumericRevisionSettings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.AlphanumericRevisionSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.AlphanumericRevisionSettings`

#### Summary

Contains settings that apply to Revisions with the Alphanumeric RevisionNumberType.

#### Since

2016

### `M:Autodesk.Revit.DB.NumericRevisionSettings.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumericRevisionSettings.IsValid`

#### Summary

Determines whether the NumericRevisionSettings object is in a valid state.

#### Remarks

The NumericRevisionSettings should at least contain a non-negative start number.

#### Returns

True if the NumericRevisionSettings is valid.

#### Since

2016

### `M:Autodesk.Revit.DB.NumericRevisionSettings.IsEqual(Autodesk.Revit.DB.NumericRevisionSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumericRevisionSettings.IsEqual(Autodesk.Revit.DB.NumericRevisionSettings)`

#### Summary

Determines whether a specified NumericRevisionSettings is the same as 'this'.

#### Remarks

The two NumericRevisionSettings are regarded as the same only if they have the same start number,
prefix and suffix strings.

#### Parameter `other`

The specified NumericRevisionSettings with which to compare.

#### Returns

True, if two NumericRevisionSettings are the same.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.NumericRevisionSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumericRevisionSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.NumericRevisionSettings.Suffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumericRevisionSettings.Suffix`

#### Summary

The suffix string that will be appended to the number of each revision with Numeric RevisionNumberingType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.NumericRevisionSettings.Prefix`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumericRevisionSettings.Prefix`

#### Summary

The prefix string that will be prepended to the number of each revision with Numeric RevisionNumberingType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.NumericRevisionSettings.MinimumDigits`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumericRevisionSettings.MinimumDigits`

#### Summary

Controls the minimum number of digits for a revision number.

#### Remarks

Use MinimumDigits to force the minimum number of digits for a revision number.
Zeros will be added to the front of the revision number until the minimum number of digits is satisfied.
For example, if MinimumDigits is 3, then 9 will be printed as 009 and 10 will be printed as 010.
If MinimumDigits is 1, then no zeros are added to the front of the revision number.
The default value for MinimumDigits is 1. Values less than 1 are not allowed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for minimumDigits is not positive.

#### Since

2022

### `P:Autodesk.Revit.DB.NumericRevisionSettings.StartNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumericRevisionSettings.StartNumber`

#### Summary

The start number for the sequence.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for number is negative.

#### Since

2016

### `M:Autodesk.Revit.DB.NumericRevisionSettings.#ctor(System.Int32,System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumericRevisionSettings.#ctor(System.Int32,System.String,System.String)`

#### Summary

Constructs a NumericRevisionSettings object.

#### Remarks

The starting number parameter accepts any non-negative integer, and
the prefix and suffix strings are allowed to be empty.

#### Parameter `startNumber`

The start number for the sequence.

#### Parameter `prefix`

The prefix string for each revision number in the sequence.

#### Parameter `suffix`

The suffix string for each revision number in the sequence.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for startNumber is negative.

#### Since

2016

### `M:Autodesk.Revit.DB.NumericRevisionSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumericRevisionSettings.#ctor`

#### Summary

Constructs a NumericRevisionSettings with a simple, default numbering sequence.

#### Remarks

Initializes startNumber to 1.
The prefix and suffix strings are set to empty.

#### Since

2016

### `M:Autodesk.Revit.DB.NumericRevisionSettings.#ctor(Autodesk.Revit.DB.NumericRevisionSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumericRevisionSettings.#ctor(Autodesk.Revit.DB.NumericRevisionSettings)`

#### Summary

Constructs a new copy of the input NumericRevisionSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

other is not a valid NumericRevisionSettings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.NumericRevisionSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.NumericRevisionSettings`

#### Summary

Contains settings that apply to Revisions with the Numeric RevisionNumberType.

#### Since

2016

### `M:Autodesk.Revit.DB.RevisionNumberingSequence.IsEqualInternal(Autodesk.Revit.DB.RevisionNumberingSequence)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence.IsEqualInternal(Autodesk.Revit.DB.RevisionNumberingSequence)`

#### Summary

Compares this revision numbering sequence to another.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.RevisionNumberingSequence.HasValidAlphanumericRevisionSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence.HasValidAlphanumericRevisionSettings`

#### Summary

Checks whether the revision numbering sequence owns a valid alphanumeric revision settings.

#### Returns

True if the revision numbering sequence owns a valid alphanumeric revision settings.

#### Since

2022

### `M:Autodesk.Revit.DB.RevisionNumberingSequence.HasValidNumericRevisionSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence.HasValidNumericRevisionSettings`

#### Summary

Checks whether the revision numbering sequence owns a valid numeric revision settings.

#### Returns

True if the revision numbering sequence owns a valid numeric revision settings.

#### Since

2022

### `M:Autodesk.Revit.DB.RevisionNumberingSequence.HasValidRevisionSettingsForNumberType`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence.HasValidRevisionSettingsForNumberType`

#### Summary

Checks whether the revision numbering sequence owns a valid revision settings for number type.

#### Returns

True if the revision numbering sequence owns a valid revision settings for number type.

#### Since

2022

### `M:Autodesk.Revit.DB.RevisionNumberingSequence.GetAllRevisionNumberingSequences(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence.GetAllRevisionNumberingSequences(Autodesk.Revit.DB.Document)`

#### Summary

Gets all of the revision numbering sequences from the document.

#### Parameter `document`

The document that contains the sequences.

#### Returns

The revision numbering sequences from the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.RevisionNumberingSequence.SetAlphanumericRevisionSettings(Autodesk.Revit.DB.AlphanumericRevisionSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence.SetAlphanumericRevisionSettings(Autodesk.Revit.DB.AlphanumericRevisionSettings)`

#### Summary

Replaces the current alphanumeric revision numbering settings with the provided settings.

#### Parameter `settings`

The AlphanumericRevisionSettings to be applied to alphanumeric revision numbering.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

settings is not a valid AlphanumericRevisionSettings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.RevisionNumberingSequence.GetAlphanumericRevisionSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence.GetAlphanumericRevisionSettings`

#### Summary

Returns a copy of the AlphanumericRevisionSettings owned by this revision numbering sequence.

#### Returns

The copy of the AlphaumericRevisionSettings owned by this revision numbering sequence.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RevisionNumberingSequence doesn't own a valid alphanumeric revision settings.

#### Since

2022

### `M:Autodesk.Revit.DB.RevisionNumberingSequence.SetNumericRevisionSettings(Autodesk.Revit.DB.NumericRevisionSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence.SetNumericRevisionSettings(Autodesk.Revit.DB.NumericRevisionSettings)`

#### Summary

Replaces the current numeric revision numbering settings with the provided settings.

#### Parameter `settings`

The NumericRevisionSettings to be applied to numeric revision numbering.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

settings is not a valid NumericRevisionSettings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.RevisionNumberingSequence.GetNumericRevisionSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence.GetNumericRevisionSettings`

#### Summary

Returns a copy of the NumericRevisionSettings owned by this revision numbering sequence.

#### Returns

The copy of the NumericRevisionSettings owned by this revision numbering sequence.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RevisionNumberingSequence doesn't own a valid numeric revision settings.

#### Since

2022

### `M:Autodesk.Revit.DB.RevisionNumberingSequence.CreateAlphanumericSequence(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.AlphanumericRevisionSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence.CreateAlphanumericSequence(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.AlphanumericRevisionSettings)`

#### Summary

Creates a new alphanumeric revision numbering sequence in the document.

#### Remarks

The new revision numbering sequence will not be assigned to any revision.
Use `Revision.SetRevisionNumberingSequenceId` to apply the sequence to a revision.

#### Parameter `document`

The document of the new revision numbering sequence.

#### Parameter `name`

The name for the revision numbering sequence.

#### Parameter `settings`

The alphanumeric settings for the revision numbering sequence.

#### Returns

The newly created revision numbering sequence.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
name is an empty string or contains only whitespace.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
settings is not a valid AlphanumericRevisionSettings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).

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

### `M:Autodesk.Revit.DB.RevisionNumberingSequence.CreateNumericSequence(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.NumericRevisionSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence.CreateNumericSequence(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.NumericRevisionSettings)`

#### Summary

Creates a new numeric revision numbering sequence in the document.

#### Remarks

The new revision numbering sequence will not be assigned to any revision.
Use `Revision.SetRevisionNumberingSequenceId` to apply the sequence to a revision.

#### Parameter `document`

The document of the new revision numbering sequence.

#### Parameter `name`

The name for the revision numbering sequence.

#### Parameter `settings`

The numeric settings for the revision numbering sequence.

#### Returns

The newly created revision numbering sequence.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
name is an empty string or contains only whitespace.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
settings is not a valid NumericRevisionSettings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).

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

### `P:Autodesk.Revit.DB.RevisionNumberingSequence.NumberType`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence.NumberType`

#### Summary

Indicates the revision number type of the revision numbering sequence.

#### Remarks

This property can be used to figure out if a revision numbering sequence is numeric or alphanumeric.
The returned RevisionNumberType is either RevisionNumberType::Numeric or RevisionNumberType::Alphanumeric.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RevisionNumberingSequence doesn't own a valid revision settings for number type.

#### Since

2022

### `P:Autodesk.Revit.DB.RevisionNumberingSequence.SequenceName`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence.SequenceName`

#### Summary

The name of this revision numbering sequence.

#### Remarks

This name appears in the Sheet Issues/Revisions dialog as a numbering choice for each revision.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: sequenceName is an empty string or contains only whitespace.
-or-
When setting this property: sequenceName cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.RevisionNumberingSequence`

Member kind: type
Symbol: `Autodesk.Revit.DB.RevisionNumberingSequence`

#### Summary

Defines the sequences by which numbers are assigned to Revisions.

#### Remarks

Revision numbering is numeric or alphanumeric. Revision numbering is assigned to Revisions to control
the numbering scheme of that Revision.

#### Since

2022

### `M:Autodesk.Revit.DB.Revision.CombineWithNext(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Revision.CombineWithNext(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Combines the specified Revision with the next Revision.

#### Remarks

All RevisionClouds and tags associated with the specified Revision will be reassigned
to the next Revision in the model and the specified Revision will be deleted from
the model. The operation can only be performed if both the specified Revision and the
next one are unissued.

#### Parameter `document`

The Document containing the Revisions.

#### Parameter `revisionId`

The Revision that should have its clouds and tags associated with the next Revision.

#### Returns

The ids of all RevisionClouds that were reassigned to the next Revision.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

revisionId is not a valid Revision.
-or-
This operation cannot be performed because revisionId is an issued Revision.
-or-
revisionId cannot be combined with the next Revision because either revisionId is
the last Revision or the next Revision has already been issued.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Revision.CombineWithPrevious(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Revision.CombineWithPrevious(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Combines the specified Revision with the previous Revision.

#### Remarks

All RevisionClouds and tags associated with the specified Revision will be reassigned
to the previous Revision in the model and the specified Revision will be deleted from
the model. The operation can only be performed if both the specified Revision and the
previous one are unissued.

#### Parameter `document`

The Document containing the Revisions.

#### Parameter `revisionId`

The Revision that should have its clouds and tags associated with the previous Revision.

#### Returns

The ids of all RevisionClouds that were reassigned to the previous Revision.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

revisionId is not a valid Revision.
-or-
This operation cannot be performed because revisionId is an issued Revision.
-or-
revisionId cannot be combined with the previous Revision because either revisionId is
the first Revision or the previous Revision has already been issued.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Revision.ReorderRevisionSequence(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Revision.ReorderRevisionSequence(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Reorders the sequence of Revisions in the project.

#### Remarks

This method allows the caller to change the sequence of the Revisions within the project by specifying the
new sequence. The specified sequence must include every Revision in the project exactly once.

Note that changing the sequence of Revisions can change the SequenceNumber and RevisionNumber
of Revisions that have already been issued.

#### Parameter `document`

The document in which the Revision sequence should be reordered.

#### Parameter `newSequence`

The new sequence of Revisions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

newSequence does not contain every Revision exactly once.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Revision.Create(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Revision.Create(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new Revision in the project.

#### Remarks

The new Revision will be added at the end of the sequence of existing Revisions.

#### Parameter `document`

The document of the new Revision.

#### Returns

The newly created Revision.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Revision.GetAllRevisionIds(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Revision.GetAllRevisionIds(Autodesk.Revit.DB.Document)`

#### Summary

Returns the ids of all Revisions in the project ordered by sequence number.

#### Parameter `document`

The document containing the Revisions.

#### Returns

The ids of all the Revisions in the document ordered by sequence number.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.Revision.RevisionNumberingSequenceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Revision.RevisionNumberingSequenceId`

#### Summary

The id of the revision numbering sequence which controls this revision's numbering.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: revisionNumberingSequenceId doesn't represent a RevisionNumberingSequence element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This operation cannot be performed on Revisions that have already been issued.

#### Since

2022

### `P:Autodesk.Revit.DB.Revision.Visibility`

Member kind: property
Symbol: `Autodesk.Revit.DB.Revision.Visibility`

#### Summary

Controls the visibility of revision clouds and revision tags related to this Revision.

#### Remarks

This property provides project-wide control over the visibility of revision clouds and tags associated with this
Revision. If clouds or tags are hidden by this property they will not be visible in any views regardless of the
view's settings. If clouds or tags are visible according to this property they may still be hidden on a particular
view or sheet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `P:Autodesk.Revit.DB.Revision.RevisionDate`

Member kind: property
Symbol: `Autodesk.Revit.DB.Revision.RevisionDate`

#### Summary

The date of this Revision.

#### Remarks

The Revision date is an arbitrary String and can be blank. Revit will not
attempt to interpret it as an actual date.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This operation cannot be performed on Revisions that have already been issued.

#### Since

2015

### `P:Autodesk.Revit.DB.Revision.IssuedBy`

Member kind: property
Symbol: `Autodesk.Revit.DB.Revision.IssuedBy`

#### Summary

Indicates who has issued or will issue this Revision.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This operation cannot be performed on Revisions that have already been issued.

#### Since

2015

### `P:Autodesk.Revit.DB.Revision.IssuedTo`

Member kind: property
Symbol: `Autodesk.Revit.DB.Revision.IssuedTo`

#### Summary

Indicates to whom this Revision was or will be issued.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This operation cannot be performed on Revisions that have already been issued.

#### Since

2015

### `P:Autodesk.Revit.DB.Revision.Issued`

Member kind: property
Symbol: `Autodesk.Revit.DB.Revision.Issued`

#### Summary

Indicates whether this Revision has been issued.

#### Since

2015

### `P:Autodesk.Revit.DB.Revision.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.Revision.Description`

#### Summary

The description of this Revision.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This operation cannot be performed on Revisions that have already been issued.

#### Since

2015

### `P:Autodesk.Revit.DB.Revision.RevisionNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Revision.RevisionNumber`

#### Summary

The Revision number of this revision.

#### Remarks

Note that this field is only available if the RevisionSettings are set to number revisions PerProject.
When Revisions are numbered PerSheet, a given Revision may display a different RevisionNumber on each sheet.
In this case, the revision number can be obtained by calling `!:Autodesk::Revit::DB::ViewSheet::GetRevisionNumberOnSheet()` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is not valid for when the revision numbering is per sheet.

#### Since

2015

### `P:Autodesk.Revit.DB.Revision.SequenceNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Revision.SequenceNumber`

#### Summary

The Sequence Number of this Revision.

#### Remarks

Every Revision in the project will be assigned a consecutive sequence number starting with 1.
This number corresponds to the ordering of the Revisions. If a Revision is deleted, subsequent
Revisions will update their sequence numbers to maintain a consecutive list.

#### Since

2015

### `T:Autodesk.Revit.DB.Revision`

Member kind: type
Symbol: `Autodesk.Revit.DB.Revision`

#### Summary

Represents a single revision in the project.

#### Remarks

The Revision object represents the data related to a single revision in the project.
Revision clouds and tags can be associated with a particular Revision object to display
its properties on sheets.

The revisions in the project are stored in a specific order called the revision
sequence. The revision sequence represents the conceptual sequence in which revisions
will be issued.

#### Since

2015

### `T:Autodesk.Revit.DB.RevisionVisibility`

Member kind: type
Symbol: `Autodesk.Revit.DB.RevisionVisibility`

#### Since

2015

#### Summary

Determines whether Revision Clouds and Revision Tags will be visible in the project.

#### Since

2015

### `F:Autodesk.Revit.DB.RevisionVisibility.TagVisible`

Member kind: field
Symbol: `Autodesk.Revit.DB.RevisionVisibility.TagVisible`

#### Summary

Revision Tags will be visible in the project but Revision Clouds will not be.

### `F:Autodesk.Revit.DB.RevisionVisibility.CloudAndTagVisible`

Member kind: field
Symbol: `Autodesk.Revit.DB.RevisionVisibility.CloudAndTagVisible`

#### Summary

Revision Clouds and Revision Tags will be visible in the project.

### `F:Autodesk.Revit.DB.RevisionVisibility.Hidden`

Member kind: field
Symbol: `Autodesk.Revit.DB.RevisionVisibility.Hidden`

#### Summary

Revision Clouds and Revision Tags will not be visible in the project.

### `T:Autodesk.Revit.DB.RevisionNumberType`

Member kind: type
Symbol: `Autodesk.Revit.DB.RevisionNumberType`

#### Since

2015

#### Summary

Determines how a particular revision will be numbered.

#### Since

2015

### `F:Autodesk.Revit.DB.RevisionNumberType.Alphanumeric`

Member kind: field
Symbol: `Autodesk.Revit.DB.RevisionNumberType.Alphanumeric`

#### Summary

The Revision Number will be a string taken from a user-specified sequence of arbitrary
strings.

### `F:Autodesk.Revit.DB.RevisionNumberType.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.RevisionNumberType.None`

#### Summary

No Revision Number will be assigned.

### `F:Autodesk.Revit.DB.RevisionNumberType.Numeric`

Member kind: field
Symbol: `Autodesk.Revit.DB.RevisionNumberType.Numeric`

#### Summary

The Revision Number will be a number.

### `M:Autodesk.Revit.DB.RevisionCloud.GetSketchCurves`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionCloud.GetSketchCurves`

#### Summary

Returns copies of the Curves that form this RevisionCloud.

#### Remarks

Note that there is no requirement that the curves form closed loops or avoid self-intersections. The
curves may also form multiple closed loops.

#### Returns

Copies of the sketched curves that form this RevisionCloud.

#### Since

2015

### `M:Autodesk.Revit.DB.RevisionCloud.GetSheetIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionCloud.GetSheetIds`

#### Summary

Returns the ids of the ViewSheets where this RevisionCloud may appear and contribute to the sheet's revision schedule.

#### Remarks

A RevisionCloud can appear on a ViewSheet because it is drawn directly on the ViewSheet
or because its owner view is placed on the ViewSheet. If the RevisionCloud is owned by
a view that is a dependent view or has associated dependent views, then the RevisionCloud can also
be visible on the sheets where the related dependent or primary views have been placed.

This RevisionCloud may not be visible in all ViewSheets reported by this method.
Additional factors, such as the visibility settings or annotation crop of the Views or the visibility settings
of the associated Revision may still cause this RevisionCloud to not appear on a particular ViewSheet.

If this RevisionCloud is owned by a ViewLegend, no sheets will be returned because the RevisionCloud
will not participate in revision schedules.

#### Returns

The ids of the ViewSheets where this RevisionCloud may appear.

#### Since

2015

### `M:Autodesk.Revit.DB.RevisionCloud.IsRevisionIssued`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionCloud.IsRevisionIssued`

#### Summary

Indicates whether the Revision associated with this RevisionCloud has been issued.

#### Returns

True if the Revision has been issued, False otherwise.

#### Since

2015

### `M:Autodesk.Revit.DB.RevisionCloud.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevisionCloud.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

#### Summary

Creates a new RevisionCloud in the model.

#### Remarks

Creates a new RevisionCloud in the specified View. The new RevisionCloud will be associated with the specified Revision.
RevisionClouds can only be created if the Revision has not yet been issued.

RevisionClouds can be created in most graphical Views, excepting 3D views and graphical column schedules. Unlike
most other Elements, RevisionClouds can be created directly on a ViewSheet.

RevisionClouds are created based on a series of sketched curves. There is no requirement that the curves form
closed loops and self-intersections are also permitted. The curves will be automatically projected onto the appropriate
plane for the View. The list of curves cannot be empty and any lines cannot be perpendicular to the View's plane.
If the View is a model View, the coordinates specified for the curves will be interpreted in model space. If the View
is a non-model View (such as a ViewSheet) then the coordinates will be interpreted in the View's space.

The cloud graphics will be attached to the curves under the assumption that each curve is oriented in a clockwise direction.
For lines, this means that the outside of the cloud is in the direction of the line's normal vector within the View's plane. Any closed loops should
therefore be oriented clockwise to create the typical cloud shape.

#### Parameter `document`

The document in which the RevisionCloud should be created.

#### Parameter `view`

The View in which the RevisionCloud should appear.

#### Parameter `revisionId`

The Revision to associate with the new RevisionCloud.

#### Parameter `curves`

The curves that will form the RevisionCloud's sketch.

#### Returns

The newly created RevisionCloud.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
revisionId is not a valid Revision.
-or-
This operation cannot be performed because revisionId is an issued Revision.
-or-
view is not a View that can support RevisionClouds.
-or-
The provided Curves curves cannot be used as the basis for a RevisionCloud. Either the list is empty or
one or more of the Curves could not be projected onto the View's plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.RevisionCloud.RevisionId`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevisionCloud.RevisionId`

#### Summary

The Revision associated with this RevisionCloud.

#### Remarks

This property cannot be set to a Revision that has already been issued. If this RevisionCloud is already associated
with a Revision that has been issued then this property cannot be changed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: revisionId is not a valid Revision.
-or-
When setting this property: This operation cannot be performed because revisionId is an issued Revision.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This operation cannot be performed on a RevisionCloud associated with a Revision that has been issued.

#### Since

2015

### `T:Autodesk.Revit.DB.RevisionCloud`

Member kind: type
Symbol: `Autodesk.Revit.DB.RevisionCloud`

#### Summary

A RevisionCloud is a graphical "cloud" that can be displayed on a view or sheet to indicate where revisions in the model have occurred.

#### Remarks

RevisionClouds are view specific and can be created in most graphical views, except 3D. Unlike most Elements, RevisionClouds may be added
directly to a ViewSheet. Each RevisionCloud is associated with one Revision.

When a RevisionCloud is visible on a
ViewSheet (either because it is directly placed on that ViewSheet or because it is visible in a View placed on the ViewSheet),
any revision schedules displayed on the ViewSheet will automatically include the Revision associated with the RevisionCloud.

Note also that when a RevisionCloud is created in a ViewLegend, it is treated as a legend representation of what a RevisionCloud
looks like rather than as an actual indication of a change to the model. As a result, RevisionClouds in ViewLegends will not affect the contents
of revision schedules.

RevisionClouds are created from a collection of sketched curves. Each curve will have a series of "cloud bumps" drawn
along it to form the appearance of a cloud. There is no requirement that the curves form closed loops.

#### Since

2015

### `M:Autodesk.Revit.DB.RepeatingReferenceSource.GetReference(Autodesk.Revit.DB.RepeaterCoordinates)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RepeatingReferenceSource.GetReference(Autodesk.Revit.DB.RepeaterCoordinates)`

#### Summary

Returns an individual repeating reference given by coordinates in the array, or `null` if there is no reference at the coordinates (for example if there is a hole in a divided surface.)

#### Remarks

The coordinates must be within the bounds of the repeating reference source.

#### Parameter `coordinates`

The coordinates in the array of repeating references.

#### Returns

The repeating reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The coordinates are not valid for the repeating reference source. This could be because of a mismatched dimensionality or because the coordinates are outside the bounds of the repeating reference source.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The repeating reference source is no longer valid.

#### Since

2014

### `M:Autodesk.Revit.DB.RepeatingReferenceSource.GetBounds`

Member kind: method
Symbol: `Autodesk.Revit.DB.RepeatingReferenceSource.GetBounds`

#### Summary

Returns information about the boundaries of the repeating reference array.

#### Remarks

See the `T:Autodesk.Revit.DB.RepeaterBounds` structure for more information about repeating reference source bounds.

#### Returns

The bounds of the repeating reference source.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The repeating reference source is no longer valid.

#### Since

2014

### `M:Autodesk.Revit.DB.RepeatingReferenceSource.GetDefaultRepeatingReferenceSource(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RepeatingReferenceSource.GetDefaultRepeatingReferenceSource(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns the default repeating reference source for a given element.

#### Remarks

The element must support repeating references. Use HasRepeatingReferenceSource() to find out whether an element has any repeating references.

#### Parameter `document`

The document that contains the element.

#### Parameter `elementId`

The id of the element.

#### Returns

The default repeating reference source of the given element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementId does not exist in the document
-or-
The element does not have any repeating reference sources.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.RepeatingReferenceSource.HasRepeatingReferenceSource(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RepeatingReferenceSource.HasRepeatingReferenceSource(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Determines whether an element has any repeating reference sources that can be used when creating component repeaters.

#### Parameter `document`

The document that contains the element.

#### Parameter `elementId`

The id of the element.

#### Returns

True if the element has any repeating reference sources.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elementId does not exist in the document

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.RepeatingReferenceSource.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RepeatingReferenceSource.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RepeatingReferenceSource.DimensionCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.RepeatingReferenceSource.DimensionCount`

#### Summary

The dimension count of the repeating reference array.

#### Since

2014

### `T:Autodesk.Revit.DB.RepeatingReferenceSource`

Member kind: type
Symbol: `Autodesk.Revit.DB.RepeatingReferenceSource`

#### Summary

Represents a collection of repeating references.

#### Remarks

The RepeatingReferenceSource class is the building block for setting up component repeaters. Repeating references are arranged
in zero, one or two dimensional arrays. The RepeatingReferenceSource class represents this array of references
and provides access to individual repeating references.

Note that there may be gaps in the array (for example a repeating reference source formed by a divided surface with
holes, or is non-rectangular surface.)

Repeating reference sources are a property of an element. Only point elements, divided paths and divided surface elements
support repeating reference sources. These element respectively have 0, 1 and 2 dimensional repeating references.
Use the HasRepeatingReferenceSource() method to query whether an element supports repeating reference sources and the
GetDefaultRepeatingReferenceSource() method to obtain a repeating reference source from a given element.

See the `T:Autodesk.Revit.DB.ComponentRepeater` and `T:Autodesk.Revit.DB.ComponentRepeaterSlot` classes
for more information.

#### Since

2014

### `M:Autodesk.Revit.DB.RepeaterCoordinates.GetCoordinate(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RepeaterCoordinates.GetCoordinate(System.Int32)`

#### Summary

Returns the coordinate in the given dimension.

#### Remarks

The dimension begins at 0 and must be in the range [0, number of dimensions in the bounds - 1].
This method does not apply to zero dimensional coordinates.

#### Parameter `dimension`

The dimension.

#### Returns

The coordinate.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The dimension is invalid for these coordinates.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The coordinates must have at least one dimension.

#### Since

2014

### `P:Autodesk.Revit.DB.RepeaterCoordinates.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RepeaterCoordinates.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RepeaterCoordinates.DimensionCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.RepeaterCoordinates.DimensionCount`

#### Summary

The number of dimensions of the coordinates (0, 1 or 2 for zero, one or two dimensional arrays.)

#### Since

2014

### `M:Autodesk.Revit.DB.RepeaterCoordinates.#ctor(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RepeaterCoordinates.#ctor(System.Int32,System.Int32)`

#### Summary

Creates two dimensional coordinates.

#### Parameter `x`

The coordinate in first dimension.

#### Parameter `y`

The coordinate in second dimension.

#### Since

2014

### `M:Autodesk.Revit.DB.RepeaterCoordinates.#ctor(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RepeaterCoordinates.#ctor(System.Int32)`

#### Summary

Creates one dimensional coordinates.

#### Parameter `x`

The coordinate.

#### Since

2014

### `M:Autodesk.Revit.DB.RepeaterCoordinates.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.RepeaterCoordinates.#ctor`

#### Summary

Creates zero dimensional coordinates.

#### Since

2014

### `T:Autodesk.Revit.DB.RepeaterCoordinates`

Member kind: type
Symbol: `Autodesk.Revit.DB.RepeaterCoordinates`

#### Summary

Represents coordinates in the array of repeating references in 0, 1, or 2 dimensions.

#### Since

2014

### `M:Autodesk.Revit.DB.RepeaterBounds.AdjustForCyclicalBounds(Autodesk.Revit.DB.RepeaterCoordinates)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RepeaterBounds.AdjustForCyclicalBounds(Autodesk.Revit.DB.RepeaterCoordinates)`

#### Summary

Shifts the input coordinates in the cyclical dimensions so that they fall in the [lower bounds, upper bounds] range.

#### Remarks

The coordinates must have the same number of dimensions as the bounds.
This method does not apply to zero dimensional bounds.

#### Parameter `coordinates`

The coordinates.

#### Returns

The adjusted coordinates.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The coordinates coordinates have incompatible number of dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The bounds must have at least one dimension.

#### Since

2014

### `M:Autodesk.Revit.DB.RepeaterBounds.AreCoordinatesInBounds(Autodesk.Revit.DB.RepeaterCoordinates,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RepeaterBounds.AreCoordinatesInBounds(Autodesk.Revit.DB.RepeaterCoordinates,System.Boolean)`

#### Summary

Determines whether given coordinates are within the bounds.

#### Remarks

The coordinates must have the same number of dimensions as the bounds.
This method does not apply to zero dimensional bounds.

#### Parameter `coordinates`

The coordinates.

#### Parameter `treatCyclicalBoundsAsInfinite`

True if cyclical directions should be treated as unbounded.

#### Returns

True if the coordinates are within the bounds.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The coordinates coordinates have incompatible number of dimensions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The bounds must have at least one dimension.

#### Since

2014

### `M:Autodesk.Revit.DB.RepeaterBounds.IsCyclical(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RepeaterBounds.IsCyclical(System.Int32)`

#### Summary

True if the array doesn't have finite bounds in the given dimension. Cyclical bounds indicate that the array forms a closed loop in the given dimension.

#### Remarks

The dimension begins at 0 and must be in the range [0, number of dimensions in the bounds - 1].
This method does not apply to zero dimensional bounds.

#### Parameter `dimension`

The dimension.

#### Returns

True if the bounds are cyclical in the given dimension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The dimension is invalid for these bounds.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The bounds must have at least one dimension.

#### Since

2014

### `M:Autodesk.Revit.DB.RepeaterBounds.GetUpperBound(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RepeaterBounds.GetUpperBound(System.Int32)`

#### Summary

Returns the highest index of the array in the given dimension.

#### Remarks

The dimension begins at 0 and must be in the range [0, number of dimensions in the bounds - 1].
This method does not apply to zero dimensional bounds.

#### Parameter `dimension`

The dimension.

#### Returns

The highest index of the array in the given dimension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The dimension is invalid for these bounds.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The bounds must have at least one dimension.

#### Since

2014

### `M:Autodesk.Revit.DB.RepeaterBounds.GetLowerBound(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RepeaterBounds.GetLowerBound(System.Int32)`

#### Summary

Returns the smallest index of the array in the given dimension.

#### Remarks

The dimension begins at 0 and must be in the range [0, number of dimensions in the bounds - 1].
This method does not apply to zero dimensional bounds.

#### Parameter `dimension`

The dimension.

#### Returns

The smallest index of the array in the given dimension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The dimension is invalid for these bounds.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The bounds must have at least one dimension.

#### Since

2014

### `P:Autodesk.Revit.DB.RepeaterBounds.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RepeaterBounds.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RepeaterBounds.DimensionCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.RepeaterBounds.DimensionCount`

#### Summary

The number of dimensions of the bounds (0, 1 or 2 for zero, one or two dimensional arrays.)

#### Since

2014

### `T:Autodesk.Revit.DB.RepeaterBounds`

Member kind: type
Symbol: `Autodesk.Revit.DB.RepeaterBounds`

#### Summary

Represents bounds of the array of repeating references in 0, 1, or 2 dimensions.
(See `T:Autodesk.Revit.DB.RepeatingReferenceSource` ).

#### Since

2014

### `P:Autodesk.Revit.DB.ReloadLatestOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReloadLatestOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.ReloadLatestOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReloadLatestOptions.#ctor`

#### Summary

Constructs a new ReloadLatestOptions object.

#### Since

2014

### `T:Autodesk.Revit.DB.ReloadLatestOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReloadLatestOptions`

#### Summary

Options to control behavior of pure reload latest (not part of synchronize with central).

#### Since

2014

### `M:Autodesk.Revit.DB.RelinquishedItems.GetRelinquishedWorksets`

Member kind: method
Symbol: `Autodesk.Revit.DB.RelinquishedItems.GetRelinquishedWorksets`

#### Summary

The elements that were relinquished by the current user.

#### Since

2014

### `M:Autodesk.Revit.DB.RelinquishedItems.GetRelinquishedElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.RelinquishedItems.GetRelinquishedElements`

#### Summary

The elements that were relinquished by the current user.

#### Since

2014

### `P:Autodesk.Revit.DB.RelinquishedItems.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RelinquishedItems.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.RelinquishedItems`

Member kind: type
Symbol: `Autodesk.Revit.DB.RelinquishedItems`

#### Summary

List of elements and worksets that were relinquished by the current user.

#### Since

2014

### `P:Autodesk.Revit.DB.RelinquishOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RelinquishOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RelinquishOptions.CheckedOutElements`

Member kind: property
Symbol: `Autodesk.Revit.DB.RelinquishOptions.CheckedOutElements`

#### Summary

True means all elements checked out by the current user should be relinquished.
False means none of these are relinquished.

#### Since

2014

### `P:Autodesk.Revit.DB.RelinquishOptions.UserWorksets`

Member kind: property
Symbol: `Autodesk.Revit.DB.RelinquishOptions.UserWorksets`

#### Summary

True means all user-created worksets owned by the current user should be relinquished.
False means none of these are relinquished.

#### Remarks

This defaults to false in the User Interface.

#### Since

2014

### `P:Autodesk.Revit.DB.RelinquishOptions.ViewWorksets`

Member kind: property
Symbol: `Autodesk.Revit.DB.RelinquishOptions.ViewWorksets`

#### Summary

True means all view worksets owned by the current user should be relinquished.
False means none of these are relinquished.

#### Since

2014

### `P:Autodesk.Revit.DB.RelinquishOptions.FamilyWorksets`

Member kind: property
Symbol: `Autodesk.Revit.DB.RelinquishOptions.FamilyWorksets`

#### Summary

True means all family worksets owned by the current user should be relinquished.
False means none of these are relinquished.

#### Since

2014

### `P:Autodesk.Revit.DB.RelinquishOptions.StandardWorksets`

Member kind: property
Symbol: `Autodesk.Revit.DB.RelinquishOptions.StandardWorksets`

#### Summary

True means all project standards worksets owned by the current user should be relinquished.
False means none of these are relinquished.

#### Since

2014

### `M:Autodesk.Revit.DB.RelinquishOptions.#ctor(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RelinquishOptions.#ctor(System.Boolean)`

#### Summary

Constructs a new instance of RelinquishOptions.

#### Parameter `relinquishEverything`

The value to apply to all of the members.

#### Since

2014

### `T:Autodesk.Revit.DB.RelinquishOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.RelinquishOptions`

#### Summary

Options to control behavior of relinquishing ownership of elements and worksets.

#### Remarks

The settings correspond to the checkboxes in the Synchronize with Central dialog
in the section "After synchronizing, relinquish the following worksets and elements:".

An element can be owned (reflected in the "Edited By" parameter) either
by being checked out ("borrowed") or by belonging to a checked out workset.

Relinquishing a workset will relinquish all its unmodified elements that the current user owns.

The subtle interactions between checking out elements and checking out worksets
are beyond the scope of the documentation for this class. But as an example,
if a wall is borrowed (explicitly checked out) and then its workset is checked out,
then the wall is no longer considered borrowed because the workset ownership
implicitly grants ownership of all elements in the workset (except elements borrowed by other users).

#### Since

2014

### `M:Autodesk.Revit.RelatedFileUtils.CreateFileFromCloudVersion(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ModelPath,System.Boolean,Autodesk.Revit.DB.RelatedFileType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.RelatedFileUtils.CreateFileFromCloudVersion(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ModelPath,System.Boolean,Autodesk.Revit.DB.RelatedFileType,System.Int32)`

#### Summary

Creates an rvt file from the central model at a specific version

#### Parameter `source`

The path of the existing file.

#### Parameter `target`

The path of the related file to create.

#### Parameter `overwrite`

True means silently overwrite if a file already exists at the target.
False means fail.

#### Parameter `relatedFileType`

The type of related file being created.

#### Parameter `centralModelVersion`

The version from which to create the local file

#### Returns

The result of trying to create the related file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.RelatedFileUtils.CreateRelatedFile(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ModelPath,System.Boolean,Autodesk.Revit.DB.RelatedFileType)`

Member kind: method
Symbol: `Autodesk.Revit.RelatedFileUtils.CreateRelatedFile(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.ModelPath,System.Boolean,Autodesk.Revit.DB.RelatedFileType)`

#### Summary

Creates a file related to an existing file.

#### Parameter `source`

The path of the existing file.

#### Parameter `target`

The path of the related file to create.

#### Parameter `overwrite`

True means silently overwrite if a file already exists at the target.
False means fail.

#### Parameter `relatedFileType`

The type of related file being created.

#### Returns

The result of trying to create the related file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `T:Autodesk.Revit.RelatedFileUtils`

Member kind: type
Symbol: `Autodesk.Revit.RelatedFileUtils`

#### Summary

Encapsulates methods for dealing with models related to a central model,
for instance creating a local model from a given central model.

### `T:Autodesk.Revit.DB.RelatedFileType`

Member kind: type
Symbol: `Autodesk.Revit.DB.RelatedFileType`

#### Summary

Describes the type of related file to be created.

#### Since

2014

### `F:Autodesk.Revit.DB.RelatedFileType.CloudSharedLocalLink`

Member kind: field
Symbol: `Autodesk.Revit.DB.RelatedFileType.CloudSharedLocalLink`

#### Summary

Creates a new local linked model from the given cloud shared central file.
The new file name is a guid that identifies the central model.

### `F:Autodesk.Revit.DB.RelatedFileType.CloudSharedLocal`

Member kind: field
Symbol: `Autodesk.Revit.DB.RelatedFileType.CloudSharedLocal`

#### Summary

Creates a new local from the given cloud shared central file.
The new file name is a guid that identifies the central model.

### `F:Autodesk.Revit.DB.RelatedFileType.LT`

Member kind: field
Symbol: `Autodesk.Revit.DB.RelatedFileType.LT`

#### Summary

Creates a new central file from the given workshared file.
Appends "LT" to the new file name.

### `F:Autodesk.Revit.DB.RelatedFileType.Local`

Member kind: field
Symbol: `Autodesk.Revit.DB.RelatedFileType.Local`

#### Summary

Creates a new local from the given central file.
Appends the username to the new file name.

### `T:Autodesk.Revit.DB.RelatedFileResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.RelatedFileResult`

#### Summary

Gives the result of creating a related file.

#### Since

2014

### `F:Autodesk.Revit.DB.RelatedFileResult.Canceled`

Member kind: field
Symbol: `Autodesk.Revit.DB.RelatedFileResult.Canceled`

#### Summary

The user canceled the operation.

### `F:Autodesk.Revit.DB.RelatedFileResult.Failed`

Member kind: field
Symbol: `Autodesk.Revit.DB.RelatedFileResult.Failed`

#### Summary

We were unable to create the related file

### `F:Autodesk.Revit.DB.RelatedFileResult.LowSpace`

Member kind: field
Symbol: `Autodesk.Revit.DB.RelatedFileResult.LowSpace`

#### Summary

There is not enough space to complete the operation.

### `F:Autodesk.Revit.DB.RelatedFileResult.Succeeded`

Member kind: field
Symbol: `Autodesk.Revit.DB.RelatedFileResult.Succeeded`

#### Summary

We created the related file

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetNumberOfBarPositions(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetNumberOfBarPositions(Autodesk.Revit.DB.Element)`

#### Summary

Returns the number of bars that are held.

#### Parameter `reinforcementElement`

The reinforcement element. Should be Rebar or RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reinforcementElement is not a Rebar or a RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.IsBarIncluded(Autodesk.Revit.DB.Element,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.IsBarIncluded(Autodesk.Revit.DB.Element,System.Int32)`

#### Parameter `reinforcementElement`

The reinforcement element. Should be Rebar or RebarInSystem.

#### Parameter `barPosition`

A bar position index between 0 and NumberOfBarPositions-1.

#### Returns

Returns true if the bar at the specified position is included, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reinforcementElement is not a Rebar or a RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPosition is not in the range [ 0, NumberOfBarPositions-1 ].

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetListeningDimensions(Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetListeningDimensions(Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments)`

#### Parameter `segmentsDefinition`

The shape definition by segments.

#### Returns

Returns the listening dimensions that are in the shape definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetReferenceLineForMeasuringSegment(System.Int32,System.Boolean,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.XYZ,System.Double,System.Double,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetReferenceLineForMeasuringSegment(System.Int32,System.Boolean,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.XYZ,System.Double,System.Double,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Parameter `segmentIdx`

If there is a hook at start, 0 will mean hook at start, 1 the first segment, 2 the second segment...
If there isn't a hook at start, 0 will mean the first segment, 1 the second segment, ...
FakeSegments (180 fillets) are nout counted as segments. e.g. A bar which has two parallel lines and a 180degree arc between them (which is a fake segment in shape definition) it will be considered as having two segments.

#### Parameter `atStart`

It is true it will return the reference curve for measure segment at the start of the segment, false for end of the segment.

#### Parameter `centerlines`

The hooks of a bar may be rotated outside of a bar plane.
We are expecting that these centerlines to be with hooks into the bar plane.
RebarInstBase::getCenterlineCurvesAtIndex is a function that can give you such curves.

#### Parameter `barPlaneNormal`

The bar plane normal.

#### Parameter `barDiameter`

The bar diameter.

#### Parameter `outOfPlaneBendDiameter`

The out of plane bar diameter.

#### Parameter `hookAtStart`

The hook type at start.

#### Parameter `hookAtEnd`

The hook type at end.

#### Returns

Returns the reference line for measuring the segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetFullGeometryForCenterlinesForView(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.View,Autodesk.Revit.DB.Element,System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetFullGeometryForCenterlinesForView(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.View,Autodesk.Revit.DB.Element,System.Int32,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean,System.Boolean)`

#### Summary

Having the centerline curves of a rebar, it will generate full geometry for a specific view.

#### Parameter `curves`

The centerlines curves.

#### Parameter `view`

The view in which the geometry is generated.

#### Parameter `reinforcementElement`

The Reinforcement element from which it will be taken properties for computing the geometry.
It will be used the bar diameter of this element. The RebarStyle will be obtained from the rebar shape at the specified bar index.

#### Parameter `barPositionIndex`

An index between 0 and (number of bars in the rebar set -1).
All the information needed for computation will be obtained from the bar with this index in the input rebar set.

#### Parameter `projectionGraphicsStyle`

Projection graphic style id.

#### Parameter `cutGraphicsStyle`

Cut graphic style id.

#### Parameter `testInViewVisibility`

If true, the curves will be checked for visibility in the view.

#### Parameter `drawRibbon`

If true, representation will be drawn as ribbon.

#### Returns

Returns the generated geometry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reinforcementElement is not a Rebar or a RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetParameterValueAtIndex(Autodesk.Revit.DB.Element,System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetParameterValueAtIndex(Autodesk.Revit.DB.Element,System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Get the parameter value for a bar at the specified index.

#### Parameter `reinforcementElement`

The reinforcement element. Should be Rebar or RebarInSystem.

#### Parameter `barPositionIndex`

An index between 0 and (number of bars in the rebar set -1).

#### Parameter `parameterId`

The parameter Id.

#### Returns

The value of the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reinforcementElement is not a Rebar or a RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetHookLengthAtIndex(Autodesk.Revit.DB.Element,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetHookLengthAtIndex(Autodesk.Revit.DB.Element,System.Int32,System.Int32)`

#### Summary

Gets the Hook length at the specified index, at the specified end.

#### Parameter `reinforcementElement`

The reinforcement element. Should be Rebar or RebarInSystem.

#### Parameter `barPositionIndex`

An index between 0 and (number of bars in the rebar set -1).

#### Parameter `end`

The end of the bar. It should be 0 for start, 1 for end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The end should be 0 or 1.
-or-
reinforcementElement is not a Rebar or a RebarInSystem.
-or-
The end does not have a hook attached.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetEndTreatmentAtIndexAtEnd(Autodesk.Revit.DB.Element,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetEndTreatmentAtIndexAtEnd(Autodesk.Revit.DB.Element,System.Int32,System.Int32)`

#### Summary

Gets the End Treatment Type id of the bar at the specified index, at the specified end.

#### Parameter `reinforcementElement`

The reinforcement element. Should be Rebar or RebarInSystem.

#### Parameter `barPositionIndex`

An index between 0 and (number of bars in the rebar set -1).

#### Parameter `end`

The end of the bar. It should be 0 for start, 1 for end.

#### Returns

Returns the End Treatment Type id of the bar at the specified index, at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The end should be 0 or 1.
-or-
reinforcementElement is not a Rebar or a RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetHookRotationAngleAtIndexAtEnd(Autodesk.Revit.DB.Element,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetHookRotationAngleAtIndexAtEnd(Autodesk.Revit.DB.Element,System.Int32,System.Int32)`

#### Summary

Gets the out of plane hook rotation angle of the bar at the specified index, at the specified end.

#### Parameter `reinforcementElement`

The reinforcement element. Should be Rebar or RebarInSystem.

#### Parameter `barPositionIndex`

An index between 0 and (number of bars in the rebar set -1).

#### Parameter `end`

The end of the bar. It should be 0 for start, 1 for end.

#### Returns

Returns the out of plane hook rotation angle of the bar at the specified index, at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The end should be 0 or 1.
-or-
reinforcementElement is not a Rebar or a RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetHookAtIndexAtEnd(Autodesk.Revit.DB.Element,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetHookAtIndexAtEnd(Autodesk.Revit.DB.Element,System.Int32,System.Int32)`

#### Summary

Gets the Hook Type id of the bar at the specified index, at the specified end.

#### Parameter `reinforcementElement`

The reinforcement element. Should be Rebar or RebarInSystem.

#### Parameter `barPositionIndex`

An index between 0 and (number of bars in the rebar set -1).

#### Parameter `end`

The end of the bar. It should be 0 for start, 1 for end.

#### Returns

Returns the Hook type id of the bar at the specified index, at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The end should be 0 or 1.
-or-
reinforcementElement is not a Rebar or a RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetBarBendingPlaneNormalAtIndex(Autodesk.Revit.DB.Element,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetBarBendingPlaneNormalAtIndex(Autodesk.Revit.DB.Element,System.Int32)`

#### Summary

Gets the normal of the plane in which the reinforcement element is bent.

#### Remarks

Only the bar segments are used to compute the bar bending plane. Hooks are ignored.

#### Parameter `reinforcementElement`

The reinforcement element from which the normal data is provided. Should be Rebar or RebarInSystem.

#### Parameter `barPositionIndex`

An index between 0 and (number of bars in the rebar set -1), representing the bar in set from which we're using the hook data.

#### Returns

Returns the normal of the plane in which the reinforcement element is bent. In case of a Free Form bar that is not planar, it will return XYZ(0,0,0).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reinforcementElement is not a Rebar or a RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetBendDataAtIndex(Autodesk.Revit.DB.Element,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetBendDataAtIndex(Autodesk.Revit.DB.Element,System.Int32)`

#### Summary

Gets the RebarBendData, at the specified bar index.

#### Parameter `reinforcementElement`

The reinforcement element from which the RebarBendData is provided. Should be Rebar or RebarInSystem.

#### Parameter `barPositionIndex`

An index between 0 and (number of bars in the rebar set -1), representing the bar in set from which we're retrieving the RebarBendData.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reinforcementElement is not a Rebar or a RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.RebarShapeMatchesCurvesOfOneBar(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Element,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.RebarShapeMatchesCurvesOfOneBar(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Element,System.Int32)`

#### Summary

Checks if rebarShape matches curves of one particular bar in a reinforcement element.
This check is ignoring hooks and end treatments.
For a bar that is in a Free Form Rebar set that has the workshop instructions set to RebarWorkInstructions.Straight the actual curves are not used. It is used only one line.

#### Parameter `rebarShape`

A RebarShape element that defines the shape of the rebar.

#### Parameter `reinforcementElement`

The reinforcement element. Should be Rebar or RebarInSystem.

#### Parameter `barPositionIndex`

An index between 0 and (number of bars in the rebar set -1).

#### Returns

Returns true if rebarShape matches curves, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reinforcementElement is not a Rebar or a RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.AddHooksToCurves(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarBendData,Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.AddHooksToCurves(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarBendData,Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition)`

#### Summary

Adds hooks to the start and end of the provided chain of curves.

#### Remarks

Returns the curves, the hook segments and the hook fillets at both ends. The initial start and end curves are trimmed for the hook fillet to fit.
If the hooks can't be added it will throw InvalidOperationException.

#### Parameter `document`

The document.

#### Parameter `curveChain`

A chain of curves to which hooks will be added.

#### Parameter `rebarBendData`

The RebarBendData class from which the hook will take its properties.

#### Parameter `pMultiplanarDefinition`

The multiplanar definition, if applicable.

#### Returns

The curves and the hooks at both ends. The initial start and end curves are trimmed for the hook fillet to fit.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.ComputeFilletBetweenCurves(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.Curve,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.ComputeFilletBetweenCurves(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.Curve,System.Double)`

#### Summary

Given two connected input curves this method computes an arc with a given radius tangent to both curves.
The curves will be trimmed for the fillet to fit.

#### Parameter `firstCurve`

The first curve.

#### Parameter `secondCurve`

The second curve.

#### Parameter `filletRadius`

The radius of the fillet arc.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The provided curves are not connected.

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetRebarShapeIdAtIndex(Autodesk.Revit.DB.Element,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetRebarShapeIdAtIndex(Autodesk.Revit.DB.Element,System.Int32)`

#### Summary

Returns the id of the RebarShape element at the specified bar index.
For shape driven Rebar and RebarInSystem all bars in the set have the same RebarShape, for free-form Rebar the shape can vary.

#### Parameter `reinforcementElement`

The reinforcement element. Should be Rebar or RebarInSystem.

#### Parameter `barPositionIndex`

An index between 0 and (number of bars in the rebar set -1).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reinforcementElement is not a Rebar or a RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.ComputeOutlineInView(Autodesk.Revit.DB.GeometryObject,Autodesk.Revit.DB.View,Autodesk.Revit.DB.Outline@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.ComputeOutlineInView(Autodesk.Revit.DB.GeometryObject,Autodesk.Revit.DB.View,Autodesk.Revit.DB.Outline@)`

#### Summary

This method computes the Outline of the provided GeometryElement in view.
Returns true if the outline was computed successfully and false otherwise.

#### Parameter `geometryObject`

The geometry object to compute outline.

#### Parameter `dbView`

The view in which the outline is computed

#### Parameter `outline`

The computed outline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetTransformedCenterlineCurvesAtIndex(Autodesk.Revit.DB.Element,System.Boolean,System.Boolean,Autodesk.Revit.DB.Structure.ReinforcementFilletingOptions,Autodesk.Revit.DB.Structure.MultiplanarOption,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetTransformedCenterlineCurvesAtIndex(Autodesk.Revit.DB.Element,System.Boolean,System.Boolean,Autodesk.Revit.DB.Structure.ReinforcementFilletingOptions,Autodesk.Revit.DB.Structure.MultiplanarOption,System.Int32)`

#### Summary

This method will return the centerline curves for bar at barPositionIndex even if this bar isn't included.
The curves are in the final position. The BarPositionTransform (representing the relative position of any individual bar in the set - a translation along the distribution path)
and MovedBarTransform (representing the movement of the bar relative to its default position along the distribution path) will be applied to the returned curves.

#### Parameter `reinforcementElement`

The Reinforcement element for wich Revit will provide the curves.
Should be Rebar or RebarInSystem.

#### Parameter `adjustForSelfIntersection`

If the curves overlap, as in a planar stirrup, this parameter controls
whether they should be adjusted to avoid intersection (as in fine views),
or kept in a single plane for simplicity (as in coarse views).

#### Parameter `suppressHooks`

Identifies if the chain will include hooks curves.

#### Parameter `filletingOption`

Identifies if the chain will include fillets/drawn arcs or neither of them.

#### Parameter `multiplanarOption`

If the Rebar is a multi-planar shape, this parameter controls whether to generate only
the curves in the primary plane (IncludeOnlyPlanarCurves), or to generate all curves,
(IncludeAllMultiplanarCurves) including the out-of-plane connector segments as well as
multi-planar copies of the primary plane curves.
This argument is ignored for planar shapes.

#### Parameter `barPositionIndex`

An index between 0 and (number of bars in the rebar set -1).
Use the barPositionIndex to obtain all the curves at a specific index in the distribution.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reinforcementElement is not a Rebar or a RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].
-or-
A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.Structure.ReinforcementUtils.GetReinforcementCurvesAsInFamily(Autodesk.Revit.DB.Element,System.Boolean,Autodesk.Revit.DB.Structure.ReinforcementFilletingOptions,Autodesk.Revit.DB.Structure.MultiplanarOption,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils.GetReinforcementCurvesAsInFamily(Autodesk.Revit.DB.Element,System.Boolean,Autodesk.Revit.DB.Structure.ReinforcementFilletingOptions,Autodesk.Revit.DB.Structure.MultiplanarOption,System.Int32)`

#### Summary

A chain of curves representing the centerline of the Reinforcement element.
The curves will lay in XY plane as defined in the RebarShape family.

#### Parameter `reinforcementElement`

The Reinforcement element for wich Revit will provide the curves.
Should be Rebar or RebarInSystem.

#### Parameter `suppressHooks`

Identifies if the chain will include hooks curves.

#### Parameter `filletingOption`

Identifies if the chain will include fillets/drawn arcs or neither of them.

#### Parameter `multiplanarOption`

If the Rebar is a multi-planar shape, this parameter controls whether to generate only
the curves in the primary plane (IncludeOnlyPlanarCurves), or to generate all curves,
(IncludeAllMultiplanarCurves) including the out-of-plane connector segments as well as
multi-planar copies of the primary plane curves.
This argument is ignored for planar shapes.

#### Parameter `barPositionIndex`

An index between 0 and (number of bars in the rebar set -1).
Use the barPositionIndex to obtain all the curves at a specific index in the distribution.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reinforcementElement is not a Rebar or a RebarInSystem.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].
-or-
A value passed for an enumeration argument is not a member of that enumeration

### `T:Autodesk.Revit.DB.Structure.ReinforcementUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementUtils`

#### Summary

Static utility class for Rebar and RebarInSystem elements.

### `T:Autodesk.Revit.DB.Structure.ReinforcementFilletingOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementFilletingOptions`

#### Summary

Multiple filleting options for centerline curves

### `F:Autodesk.Revit.DB.Structure.ReinforcementFilletingOptions.UntrimmedSegments`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementFilletingOptions.UntrimmedSegments`

#### Summary

Centerline curves are un-trimmed and un-filleted at corners.

### `F:Autodesk.Revit.DB.Structure.ReinforcementFilletingOptions.IncludeDrawnArcs`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementFilletingOptions.IncludeDrawnArcs`

#### Summary

Un-filleted centerline curves, but include user-drawn arcs in the RebarShape family.

### `F:Autodesk.Revit.DB.Structure.ReinforcementFilletingOptions.IncludeFillets`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementFilletingOptions.IncludeFillets`

#### Summary

Centerline curves computed with all fillets between curves.

### `P:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTag.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTag.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTag.AbbreviationTag`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTag.AbbreviationTag`

#### Summary

The abbreviation tag value.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTag.TypeTag`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTag.TypeTag`

#### Summary

The abbreviation tag type.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTag.#ctor(Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTag.#ctor(Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType,System.String)`

#### Summary

Constructs a new ReinforcementAbbreviationTag.

#### Parameter `typeTag`

Defines the type of abbreviation tag.

#### Parameter `abbreviationTag`

Defines the abbreviation tag value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTag`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTag`

#### Summary

This class is used to access the Area or Path Reinforcement abbreviation tag data.
It stores abbreviation tag value and abbreviation type.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.ReinforcementSettings.SetReinforcementAbbreviationTag(Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.SetReinforcementAbbreviationTag(Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType,System.String)`

#### Summary

Sets one abbreviation tag for desired ReinforcementAbbreviationTagType.

#### Parameter `tagType`

Defines the type of abbreviation tag.

#### Parameter `abbreviationTag`

Abbreviation tag value to set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The abbreviation type tagType is not valid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.ReinforcementSettings.GetReinforcementAbbreviationTag(Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.GetReinforcementAbbreviationTag(Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType)`

#### Summary

Gets one abbreviation tag for desired ReinforcementAbbreviationTagType.

#### Parameter `tagType`

Defines the type of abbreviation tag.

#### Returns

Abbreviation tag value

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The abbreviation type tagType is not valid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.ReinforcementSettings.GetReinforcementAbbreviationTags(Autodesk.Revit.DB.Structure.ReinforcementAbbreviationObjectType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.GetReinforcementAbbreviationTags(Autodesk.Revit.DB.Structure.ReinforcementAbbreviationObjectType)`

#### Summary

Gets a list of abbreviation tags for desired reinforcement object type.

#### Parameter `objectType`

Defines the type of desired reinforcement object for abbreviation tags.

#### Returns

An array of ReinforcementAbbreviationTag that will define all abbreviations for given reinforcement object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.ReinforcementSettings.GetFabricRoundingManager`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.GetFabricRoundingManager`

#### Summary

Returns an object for managing reinforcement rounding override settings used by FabricSheetType and FabricSheet elements.

#### Returns

The rounding manager.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.ReinforcementSettings.GetRebarRoundingManager`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.GetRebarRoundingManager`

#### Summary

Returns an object for managing reinforcement rounding override settings used by RebarBarTypes, Rebar and RebarInSystem elements.

#### Returns

The rounding manager.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.ReinforcementSettings.IsEqual(Autodesk.Revit.DB.Structure.ReinforcementSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.IsEqual(Autodesk.Revit.DB.Structure.ReinforcementSettings)`

#### Summary

Checks if Reinforcement Settings is equal to other

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.ReinforcementSettings.GetReinforcementSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.GetReinforcementSettings(Autodesk.Revit.DB.Document)`

#### Summary

Obtains the ReinforcementSettings object for the specified project document.

#### Parameter `document`

A project document.

#### Returns

The ReinforcementSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Structure.ReinforcementSettings.RebarVaryingLengthNumberSuffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.RebarVaryingLengthNumberSuffix`

#### Summary

A unique identifier used for a bar within a variable length rebar set.

#### Remarks

This property affects only Rebar sets under the following conditions:
1. The distribution type ( `!:Autodesk::Revit::DB::Rebar::distributionType` ) of the Rebar is DistributionType::Enum::VaryingLength.

2. There are at least two bars within the Rebar set that have different shape parameter values (i.e at least two bars vary in length).
The shape parameters of a Rebar can be accessed via `!:Autodesk::Revit::DB::Structure::RebarShapeDefinition::getParameters` method.

The parameters at a specific index in a Rebar set can be accessed via `!:Autodesk::Revit::DB::Structure::Rebar::getParameterValueAtIndex` method.

This property is assigned to varying Rebar sets
only if they are numbered as a whole (i.e. `P:Autodesk.Revit.DB.Structure.ReinforcementSettings.NumberVaryingLengthRebarsIndividually` is set to false).

The values for this property are valid if :
Input contains at least one character.

Input contains either alphabetical or numeric characters (not both).

When this property is used, each bar in a varying set will be assigned an incremented value of the suffix.
As an example, the suffix values for three bars in a varying set are:
For alphabetic suffix : Aaz -> Aba -> Abb.

For numeric suffix : 129 -> 130 -> 131.
These values are automatically incremented by the system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The rebar number suffix is not valid if :
Input is empty.

Input contains non-alphanumeric characters.

Input contains both numeric and alphabetic characters.

Input is a value that exceeds the maximum integer representation.

Input contains more than 6 alphabetic characters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.ReinforcementSettings.NumberVaryingLengthRebarsIndividually`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.NumberVaryingLengthRebarsIndividually`

#### Summary

Use this option to modify the way varying length bars are numbered (individually or as a whole).

#### Remarks

This property affects only Rebar sets under the following conditions:
1. The distribution type ( `!:Autodesk::Revit::DB::Rebar::distributionType` ) of the Rebar is DistributionType::Enum::VaryingLength.

2. There are at least two bars within the Rebar set that have different shape parameter values (i.e at least two bars vary in length).
The shape parameters of a Rebar can be accessed via `!:Autodesk::Revit::DB::Structure::RebarShapeDefinition::getParameters` method.

The parameters at a specific index in a Rebar set can be accessed via `!:Autodesk::Revit::DB::Structure::Rebar::getParameterValueAtIndex` method.

If this property is true, then the Revit numbering mechanism ( `!:Autodesk::Revit::DB::NumberingSchema` )
will assign each bar, in a varying set, a number.
The number is assigned based on the Revit numbering logic. (For example if two bars are identical, they will receive the same number).
The numbering mechanism will compare varying bars with other varying or uniform bars within the project. (i.e each bar in a varying set is interpreted as an individual Rebar).

If this property is false, the following happens:
1. The Revit numbering mechanism ( `!:Autodesk::Revit::DB::NumberingSchema` )
will assign a unique number for each varying Rebar set.
Each bar within the varying set will have(share) the same number that was assigned for the entire set.
Even if two varying Rebar sets are identical, they will be assigned different numbers.

2. Each bar within a varying set will also be assigned a suffix parameter (REBAR_NUMBER_SUFFIX).
This suffix parameter will receive values based on the `P:Autodesk.Revit.DB.Structure.ReinforcementSettings.RebarVaryingLengthNumberSuffix` property.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.ReinforcementSettings.RebarPresentationInSection`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.RebarPresentationInSection`

#### Summary

The default presentation mode for rebar sets, when:
The view direction is perpendicular to the rebar normal and the rebar set is cut.

The view direction is not perpendicular to the rebar normal and the view direction is not parallel to the rebar normal.

#### Remarks

All bars in a given rebar set will be visible if:
The view is a 3D view.

The view direction is not parallel to the rebar normal.
For this case there are no defaults and no overrides in instances.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.ReinforcementSettings.RebarPresentationInView`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.RebarPresentationInView`

#### Summary

The default presentation mode for rebar sets, when the view direction is perpendicular to the rebar normal and the rebar set is not cut.

#### Remarks

All bars in a given rebar set will be visible if:
The view is a 3D view.

The view direction is not parallel to the rebar normal.
For this case there are no defaults and no overrides in instances.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.ReinforcementSettings.RebarShapeDefinesEndTreatments`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.RebarShapeDefinesEndTreatments`

#### Summary

End Treatments are defined by Rebar Shape of Rebar element. Can be changed if document contains no rebars, area reinforcements and path reinforcements.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Cannot change the RebarShapeDefinesHooks property in these settings because the document contains one or more Rebar elements.
-or-
When setting this property: Cannot change the RebarShapeDefinesHooks property in these settings because the document contains one or more AreaReinforcement or PathReinforcement
elements.
-or-
When setting this property: Cannot change the RebarShapeDefinesHooks property in these settings because the document contains one or more RebarContainer elements.
the document contains one or more RebarContainer elements.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.ReinforcementSettings.RebarShapeDefinesHooks`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.RebarShapeDefinesHooks`

#### Summary

Hooks are defined by Rebar Shape of Rebar element. Can be changed if document contains no rebars, area reinforcements and path reinforcements.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Cannot change the RebarShapeDefinesHooks property in these settings because the document contains one or more Rebar elements.
-or-
When setting this property: Cannot change the RebarShapeDefinesHooks property in these settings because the document contains one or more AreaReinforcement or PathReinforcement
elements.
-or-
When setting this property: Cannot change the RebarShapeDefinesHooks property in these settings because the document contains one or more RebarContainer elements.
the document contains one or more RebarContainer elements.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.ReinforcementSettings.HostStructuralRebar`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings.HostStructuralRebar`

#### Summary

Host Structural Rebar within Area and Path Reinforcement with touching AtomHostStructuralRebar.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Cannot change the RebarShapeDefinesHooks property in these settings because the document contains one or more AreaReinforcement or PathReinforcement
elements.

#### Since

2013

### `T:Autodesk.Revit.DB.Structure.ReinforcementSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementSettings`

#### Summary

Provides access to project-wide reinforcement settings.

#### Since

2013

### `T:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationObjectType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationObjectType`

#### Summary

Defines the type of desired reinforcement object for abbreviation tags.

#### Since

2016

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationObjectType.Path`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationObjectType.Path`

#### Summary

Abbreviation tags for Path Reinforcement.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationObjectType.Area`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationObjectType.Area`

#### Summary

Abbreviation tags for Area Reinforcement.

### `T:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType`

#### Summary

Defines all types of abbreviation tags for Area and Path Reinforcement objects.

#### Since

2016

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.PathReinforcementAlternatingBarOffset`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.PathReinforcementAlternatingBarOffset`

#### Summary

Path Reinforcement - alternating bar offset.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.PathReinforcementAlternating`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.PathReinforcementAlternating`

#### Summary

Path Reinforcement - alternating.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.PathReinforcementExterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.PathReinforcementExterior`

#### Summary

Path Reinforcement - wall exterior.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.PathReinforcementInterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.PathReinforcementInterior`

#### Summary

Path Reinforcement - wall interior.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.PathReinforcementBottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.PathReinforcementBottom`

#### Summary

Path Reinforcement - slab bottom.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.PathReinforcementTop`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.PathReinforcementTop`

#### Summary

Path Reinforcement - slab top.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementLayerEachFace`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementLayerEachFace`

#### Summary

Area Reinforcement - layer for each face

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementLayerEachWay`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementLayerEachWay`

#### Summary

Area Reinforcement - layer for each way

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementExteriorMinor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementExteriorMinor`

#### Summary

Area Reinforcement - wall exterior for minor direction.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementExteriorMajor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementExteriorMajor`

#### Summary

Area Reinforcement - wall exterior for major direction.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementInteriorMinor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementInteriorMinor`

#### Summary

Area Reinforcement - wall interior for minor direction.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementInteriorMajor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementInteriorMajor`

#### Summary

Area Reinforcement - wall interior for major direction.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementBottomMinor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementBottomMinor`

#### Summary

Area Reinforcement - slab bottom for minor direction.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementBottomMajor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementBottomMajor`

#### Summary

Area Reinforcement - slab bottom for major direction.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementTopMinor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementTopMinor`

#### Summary

Area Reinforcement - slab top for minor direction.

### `F:Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementTopMajor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType.AreaReinforcementTopMajor`

#### Summary

Area Reinforcement - slab top for major direction.

### `M:Autodesk.Revit.DB.ReferencePlane.Flip`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePlane.Flip`

#### Summary

Flips the orientation of the reference plane.

### `M:Autodesk.Revit.DB.ReferencePlane.GetReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePlane.GetReference`

#### Summary

Returns the geometry reference of the reference plane.

#### Returns

The geometry reference of the reference plane.

#### Since

2016

### `M:Autodesk.Revit.DB.ReferencePlane.GetPlane`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePlane.GetPlane`

#### Summary

Returns the geometry plane to which the reference plane is assigned.

#### Returns

The geometry plane to which the reference plane is assigned.

#### Since

2016

### `P:Autodesk.Revit.DB.ReferencePlane.Direction`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferencePlane.Direction`

#### Summary

The direction of the reference plane.

#### Remarks

When setting this property, an exception will be thrown if the direction vector is not perpendicular to the normal vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: newDir has zero length.

### `P:Autodesk.Revit.DB.ReferencePlane.Normal`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferencePlane.Normal`

#### Summary

The normal vector of the reference plane.

### `P:Autodesk.Revit.DB.ReferencePlane.FreeEnd`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferencePlane.FreeEnd`

#### Summary

The free end of the reference plane.

#### Remarks

When setting this property, an exception will be thrown if the free end is set to
almost the same point as bubble end or if the vector from BubbleEnd -> FreeEnd is not perpendicular
to the normal vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.ReferencePlane.BubbleEnd`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferencePlane.BubbleEnd`

#### Summary

The bubble end of the reference plane.

#### Remarks

When setting this property, an exception will be thrown if the bubble end is set to almost
the same point as free end or if the vector from BubbleEnd -> FreeEnd
is not perpendicular to the normal vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.ReferencePlane.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferencePlane.Name`

#### Summary

The name property of the reference plane.

#### Remarks

This property overrides Element's default implementation.

### `T:Autodesk.Revit.DB.ReferencePlane`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReferencePlane`

#### Summary

Represents a reference plane of Autodesk Revit.

### `M:Autodesk.Revit.DB.DatumPlane.AddLeader(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.AddLeader(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

#### Summary

Adds a default Leader for the indicated end of the datum plane. This method does not apply to Reference planes (which do not support leaders).

#### Remarks

The leader can be added only to ends where the bubble is set to be shown and does not have a leader applied.

#### Parameter `datumEnd`

The end of the datum plane.

#### Parameter `view`

The view on which the DatumPlane shows.

#### Returns

The Leader of the datum plane. Null will return if the view is null.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The datum plane cannot be visible in the view.
-or-
The bubble is not visible at the datumEnd of the datum plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This datum plane has no leaders.
-or-
The DatumPlane already has a leader applied.

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.SetLeader(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View,Autodesk.Revit.DB.Leader)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.SetLeader(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View,Autodesk.Revit.DB.Leader)`

#### Summary

Sets the leader to the indicated end of the datum plane. This method does not apply to Reference planes (which do not support leaders).

#### Remarks

The leader can be applied only to ends where the bubble is set to be shown.

#### Parameter `datumEnd`

The end of the datum plane.

#### Parameter `view`

The view on which the DatumPlane shows.

#### Parameter `pLeader`

The Leader for setting the datum plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One of the conditions is not valid: the input leader and view is not null;
The leader End, Elbow, Anchor should be in the view;
the End of leader should be in the datum plane curves; Elbow is between End and Anchor.
-or-
The datum plane cannot be visible in the view.
-or-
The bubble is not visible at the datumEnd of the datum plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.GetLeader(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.GetLeader(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

#### Summary

Gets a copy of the leader applied to the indicated end of the datum plane. This method does not apply to Reference planes (which do not support leaders).

#### Parameter `datumEnd`

The end of the datum plane.

#### Parameter `view`

The view on which the DatumPlane shows.

#### Returns

The Leader of the datum plane. Null will return if no leader applied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The datum plane cannot be visible in the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This datum plane has no leaders.

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.IsLeaderValid(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View,Autodesk.Revit.DB.Leader)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.IsLeaderValid(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View,Autodesk.Revit.DB.Leader)`

#### Summary

Identifies if the leader valid or not for this DatumPlane. This method does not apply to Reference planes (which do not support leaders).

#### Remarks

If the view or leader is null, it will throw ArgumentNullException;
A valid leader meets the following conditions:
The leader's End, Elbow and Anchor should lie in the View's plane

The End of the leader should be on the datum plane's curve(s)

The Elbow of the leader should be between the End and Anchor

#### Parameter `datumEnd`

The end of the datum plane.

#### Parameter `view`

The view on which the DatumPlane shows.

#### Parameter `leader`

The Leader for setting the datum plane.

#### Returns

True if the leader is valid for set leader, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This datum plane has no leaders.
-or-
The DatumPlane should not have a leader.

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.PropagateToViews(Autodesk.Revit.DB.View,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.PropagateToViews(Autodesk.Revit.DB.View,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Propagates the extents applied to this datum in the view to the specified parallel views.

#### Parameter `view`

The view on which the DatumPlane shows.

#### Parameter `parallelViews`

The ids of the specified parallel views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The datum plane cannot be visible in the view.
-or-
One ElementId in parallelViews is not valid for extent propagation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.GetPropagationViews(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.GetPropagationViews(Autodesk.Revit.DB.View)`

#### Summary

Gets a list of candidate views which are parallel to the current view and to which the extents of the datum may be propagated.

#### Parameter `view`

The view on which the DatumPlane shows.

#### Returns

A set of ElementIds of the parallel views for extent propagation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The datum plane cannot be visible in the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.IsCurveValidInView(Autodesk.Revit.DB.DatumExtentType,Autodesk.Revit.DB.View,Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.IsCurveValidInView(Autodesk.Revit.DB.DatumExtentType,Autodesk.Revit.DB.View,Autodesk.Revit.DB.Curve)`

#### Summary

Checks if the curve is valid to be as the extents for the datum plane in a view.
The curve must be bound and coincident with the original one of the datum plane.

#### Parameter `extentMode`

The extent type.

#### Parameter `view`

The view.

#### Parameter `curve`

The curve.

#### Returns

True if it is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.SetCurveInView(Autodesk.Revit.DB.DatumExtentType,Autodesk.Revit.DB.View,Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.SetCurveInView(Autodesk.Revit.DB.DatumExtentType,Autodesk.Revit.DB.View,Autodesk.Revit.DB.Curve)`

#### Summary

Sets the extents to match the curve.

#### Parameter `extentMode`

The extent type.

#### Parameter `view`

The view.

#### Parameter `curve`

The curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The datum plane cannot be visible in the view.
-or-
The curve is unbound or not coincident with the original one of the datum plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.GetCurvesInView(Autodesk.Revit.DB.DatumExtentType,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.GetCurvesInView(Autodesk.Revit.DB.DatumExtentType,Autodesk.Revit.DB.View)`

#### Summary

Gets a collection of curves representing the DatumPlane element in the given view.

#### Remarks

Curves returned for Model extents can be different than curves returned for View-specific extents (2d extents) in the given view.
In some cases, such as an arc grid in a section view, there will be two identical curves but offset from one another.

#### Parameter `extentMode`

The extent type.

#### Parameter `view`

The view.

#### Returns

The curves.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The datum plane cannot be visible in the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.SetDatumExtentType(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View,Autodesk.Revit.DB.DatumExtentType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.SetDatumExtentType(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View,Autodesk.Revit.DB.DatumExtentType)`

#### Summary

Sets whether the curve representing the datum plane is displayed according to its 3d extents, or else according to a view specific setting.

#### Remarks

In a particular view, the datum plane is represented by a curve and the two ends of the curve may have different DatumExtentTypes in that view.
If the value is changed from DatumExtentType::Model to DatumExtentType::ViewSpecific, then the view specific extents will be identical to the model
extent until modified.

#### Parameter `datumEnd`

Specifies one end of the curve representing the datum plane in the view.

#### Parameter `view`

The view in which to set the datum extent settings.

#### Parameter `extentMode`

The DatumExtentType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The datum plane cannot be visible in the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.Maximize3DExtents`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.Maximize3DExtents`

#### Summary

Computes the 3d extents of all model geometry and levels, and extends the 3d extents of this datum surface to include the model extents.

#### Remarks

Currently does not apply to curved grids.

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.GetDatumExtentTypeInView(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.GetDatumExtentTypeInView(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

#### Summary

Identifies whether the curve representing the datum plane is displayed according to its actual 3d extents, or else according to a view specific setting.

#### Remarks

In a particular view, the datum plane is represented by a curve and the two ends of the curve may have different DatumExtentTypes in that view.

#### Parameter `datumEnd`

Specifies one end of the curve representing the datum plane in the view.

#### Parameter `view`

The view in which to evaluate the datum extent settings.

#### Returns

The extent type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The datum plane cannot be visible in the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.CanBeVisibleInView(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.CanBeVisibleInView(Autodesk.Revit.DB.View)`

#### Summary

Checks if the datum plane can be visible in the view.

#### Remarks

This method determines if the orientation of the DatumPlane and View allows that the DatumPlane can be seen in the indicated view.
It does not actually determine if the DatumPlane is visible, as many factors can affect the visibility of an element in a given view (for example, hiding the element).

#### Parameter `view`

The view.

#### Returns

True if visible, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.HasBubbleInView(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.HasBubbleInView(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

#### Summary

Identifies if the DatumPlane has bubble or not.

#### Parameter `datumEnd`

The end of the datum plane.

#### Parameter `view`

The view on which the DatumPlane shows.

#### Returns

True if the DatumPlane has bubble, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This datum plane doesn't support bubble operations.

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.IsBubbleVisibleInView(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.IsBubbleVisibleInView(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

#### Summary

Identifies if the bubble is visible or not in a view.

#### Parameter `datumEnd`

The end of the datum plane.

#### Parameter `view`

The view on which the DatumPlane shows.

#### Returns

True if the bubble is visible, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The datum plane cannot be visible in the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This datum plane doesn't support bubble operations.

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.HideBubbleInView(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.HideBubbleInView(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

#### Summary

Hides the bubble in a view. This method does not apply to Reference planes.

#### Parameter `datumEnd`

The end of the datum plane.

#### Parameter `view`

The view on which the DatumPlane shows.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The datum plane cannot be visible in the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This datum plane doesn't support bubble operations.

#### Since

2016

### `M:Autodesk.Revit.DB.DatumPlane.ShowBubbleInView(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DatumPlane.ShowBubbleInView(Autodesk.Revit.DB.DatumEnds,Autodesk.Revit.DB.View)`

#### Summary

Shows the bubble in a view. This method does not apply to Reference planes.

#### Parameter `datumEnd`

The end of the datum plane.

#### Parameter `view`

The view on which the DatumPlane shows.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The datum plane cannot be visible in the view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This datum plane doesn't support bubble operations.
-or-
This DatumPlane doesn't have bubbles shown the view.

#### Since

2016

### `T:Autodesk.Revit.DB.DatumPlane`

Member kind: type
Symbol: `Autodesk.Revit.DB.DatumPlane`

#### Summary

A base class representing a datum surface (level, grid or reference plane) in Autodesk Revit.

#### Remarks

A DatumPlane represents a 3d surface with finite extents. It can be either a rectangle with arbitrary orientation, or a cylinder
whose axis is parallel to the project z-axis.

If a datum is visible in a plan or section view, it will be displayed as one or more curves. These curves are determined by the
intersection of the datum surface with the cut plane of the view. By default, the extents of these curves reflect the 3d extents
of the datum surface. If the surface is a plane, then the extents represent the projection of the surface onto the cut plane. This
matters, for example, when viewing a datum plane, really a 3d rectangle, along one of its diagonals. The extents of the curve
do not vary with the location of the view, because we use the projection of the rectangle and not the actual intersection. If the
surface is a cylinder, then the extents reflect the actual intersection of the surface with the cut plane.

In addition, the curves that represent a DatumPlane can be modified on a view specific basis. In this case, the ends of the curve no
longer reflect the 3d extents of the datum.

#### Since

2016

### `T:Autodesk.Revit.DB.DatumExtentType`

Member kind: type
Symbol: `Autodesk.Revit.DB.DatumExtentType`

#### Summary

Represents the type of datum extent that is displayed in a particular view.

#### Since

2016

### `F:Autodesk.Revit.DB.DatumExtentType.ViewSpecific`

Member kind: field
Symbol: `Autodesk.Revit.DB.DatumExtentType.ViewSpecific`

#### Summary

The extent displayed is specific to the view and does not represent the actual 3D extent of the datum plane.

### `F:Autodesk.Revit.DB.DatumExtentType.Model`

Member kind: field
Symbol: `Autodesk.Revit.DB.DatumExtentType.Model`

#### Summary

The extent represents the actual 3D extent of the datum plane.

### `T:Autodesk.Revit.DB.DatumEnds`

Member kind: type
Symbol: `Autodesk.Revit.DB.DatumEnds`

#### Summary

An enumerated type representing ends of a datum plane.

#### Since

2016

### `F:Autodesk.Revit.DB.DatumEnds.End1`

Member kind: field
Symbol: `Autodesk.Revit.DB.DatumEnds.End1`

#### Summary

The end point of the datum plane in the view.

### `F:Autodesk.Revit.DB.DatumEnds.End0`

Member kind: field
Symbol: `Autodesk.Revit.DB.DatumEnds.End0`

#### Summary

The start point of the datum plane in the view.

### `M:Autodesk.Revit.DB.ReferenceWithContext.GetInstanceTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceWithContext.GetInstanceTransform`

#### Summary

Gets the transform of the instance.

#### Returns

The transform of an instance when the reference is returned by FindReferencesWithContextByDirection(XYZ, XYZ, View3D) or ReferenceIntersector.Find(XYZ, XYZ).

#### Since

2012

### `M:Autodesk.Revit.DB.ReferenceWithContext.GetReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceWithContext.GetReference`

#### Summary

Gets the reference of the geometric object.

#### Returns

The reference of a geometric object when it is returned by FindReferencesWithContextByDirection(XYZ, XYZ, View3D) or ReferenceIntersector.Find(XYZ, XYZ).

#### Since

2012

### `P:Autodesk.Revit.DB.ReferenceWithContext.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceWithContext.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ReferenceWithContext.Proximity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceWithContext.Proximity`

#### Summary

The proximity value to the ray's origin when the reference is returned by FindReferencesWithContextByDirection(XYZ, XYZ, View3D) or ReferenceIntersector.Find(XYZ, XYZ).

#### Since

2012

### `T:Autodesk.Revit.DB.ReferenceWithContext`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReferenceWithContext`

#### Summary

An object including a reference to a geometric object and related context, as instance transform etc.

#### Remarks

The ReferenceWithContext is used as the returned value from the method `!:Autodesk::Revit::DB::Document::FindReferencesWithContextByDirection` ,
ReferenceIntersector.Find(XYZ, XYZ), or ReferenceIntersector.FindNearest(XYZ, XYZ).
It includes a reference intersecting a line extended in a certain direction from an origin point and the context of the geometric object, as
the transform and proximity.

#### Since

2012

### `M:Autodesk.Revit.DB.ReferenceIntersector.SetTargetElementIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.SetTargetElementIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets the set of ElementIds to test from in intersection testing.

#### Parameter `elementIds`

The target ElementIds.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ReferenceIntersector.GetTargetElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.GetTargetElementIds`

#### Summary

Gets the set of ElementIds to test from in intersection testing.

#### Returns

The target ElementIds.

#### Since

2013

### `M:Autodesk.Revit.DB.ReferenceIntersector.SetFilter(Autodesk.Revit.DB.ElementFilter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.SetFilter(Autodesk.Revit.DB.ElementFilter)`

#### Summary

Sets the ElementFilter used in intersection testing.

#### Parameter `filter`

The ElementFilter. Pass `null` to remove the existing filter.

#### Since

2013

### `M:Autodesk.Revit.DB.ReferenceIntersector.GetFilter`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.GetFilter`

#### Summary

Gets the ElementFilter used in intersection testing.

#### Returns

The ElementFilter, or `null` if no filter is set.

#### Since

2013

### `M:Autodesk.Revit.DB.ReferenceIntersector.FindNearest(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.FindNearest(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Projects a ray from the origin along the given direction, and returns the nearest reference from intersected elements which match the ReferenceIntersector's criteria.

#### Remarks

Note that FindNearest() is a convenience method, and other references that may be nearly the same distance from the origin can be obtained from `M:Autodesk.Revit.DB.ReferenceIntersector.Find(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)` .

#### Parameter `origin`

The origin of the ray.

#### Parameter `direction`

The direction of the ray.

#### Returns

The intersected reference nearest to the ray origin, `null` if none is found

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ReferenceIntersector.Find(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.Find(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Projects a ray from the origin along the given direction, and returns all references from intersected elements which match the ReferenceIntersector's criteria.

#### Parameter `origin`

The origin of the ray.

#### Parameter `direction`

The direction of the ray.

#### Returns

A collection containing the intersected references.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.ReferenceIntersector.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ReferenceIntersector.FindReferencesInRevitLinks`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.FindReferencesInRevitLinks`

#### Summary

Determines if references inside Revit Links should be found.

#### Remarks

If set to false, no Reference to any Element from a Revit Link will be found by the ReferenceIntersector,
and you can be certain that any Reference returned will be to a host document Element only. If set to true,
the results may include both References to Elements in hosts and References to Elements from a link
instance.

Setting this value to true may interact with some other settings on the ReferenceIntersector. If a list of target ElementIds is set,
references will be returned only if the ElementId matches the id of the intersected RevitLinkInstance. If there is a match, any intersecting
elements in the link will be returned (their ids will not be compared with the target ids list). If there is an ElementFilter
applied, the elements in the link will be evaluated against the stored ElementFilter.

Note that results may not be as expected if the filter applied is geometric (such as a BoundingBox filter or ElementIntersects filter).
This is because the filter will be evaluated for linked elements in the coordinates of the linked model, which may not match the coordinates
of the elements as they appear in the host model. Also, ElementFilters that accept a Document and/or ElementId as input during
their instantiation will not correctly pass elements that appear in the link, because the filter will not be able to match link elements to
the filter's criteria.

#### Since

2014

### `P:Autodesk.Revit.DB.ReferenceIntersector.TargetType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.TargetType`

#### Summary

The type of reference to find.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.ReferenceIntersector.ViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.ViewId`

#### Summary

The id of the 3D view used for evaluation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: viewId is not the id of a 3D view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ReferenceIntersector.#ctor(Autodesk.Revit.DB.ElementFilter,Autodesk.Revit.DB.FindReferenceTarget,Autodesk.Revit.DB.View3D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.#ctor(Autodesk.Revit.DB.ElementFilter,Autodesk.Revit.DB.FindReferenceTarget,Autodesk.Revit.DB.View3D)`

#### Summary

Constructs a ReferenceIntersector which is set to return intersections from any element which passes an input filter.

#### Parameter `filter`

The element filter. All references will belong to elements passing this filter.

#### Parameter `targetType`

The target type of references to return.

#### Parameter `view3d`

The view in which to find references.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Returns true if the view is not a view template.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.ReferenceIntersector.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.FindReferenceTarget,Autodesk.Revit.DB.View3D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.#ctor(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.FindReferenceTarget,Autodesk.Revit.DB.View3D)`

#### Summary

Constructs a ReferenceIntersector which is set to return intersections from any of a set of target elements.

#### Parameter `targetElementIds`

The target element ids.

#### Parameter `targetType`

The target type of references to return.

#### Parameter `view3d`

The view in which to find references.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Returns true if the view is not a view template.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.ReferenceIntersector.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.FindReferenceTarget,Autodesk.Revit.DB.View3D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.FindReferenceTarget,Autodesk.Revit.DB.View3D)`

#### Summary

Constructs a ReferenceIntersector which is set to return intersections from a single target element only.

#### Parameter `targetElementId`

The target element id.

#### Parameter `targetType`

The target type of references to return.

#### Parameter `view3d`

The view in which to find references.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Returns true if the view is not a view template.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.ReferenceIntersector.#ctor(Autodesk.Revit.DB.View3D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceIntersector.#ctor(Autodesk.Revit.DB.View3D)`

#### Summary

Constructs a ReferenceIntersector which is set to return intersections from all elements and representing all reference target types.

#### Parameter `view3d`

The view in which to find references.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Returns true if the view is not a view template.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.ReferenceIntersector`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReferenceIntersector`

#### Summary

A class used to find and return elements that intersect a ray created from an origin point and direction.

#### Remarks

An instance of this class can be constructed to return any 3D geometric element that intersects the
ray created by the origin and direction, or to return a subset of elements based on filtering and flags.
The caller can opt to filter the results using an ElementFilter, or by applying a specific list of
acceptable elements. The caller can also specify the type of object to be returned, which might be
whole elements, geometry objects, or a combination. In all cases the caller is required to supply
a 3D view for evaluation; the view and visibility settings on the input view will determine if a
particular element is returned (for example, hidden elements will never be returned by this tool, nor
will elements whose geometry is outside the section box of the view).

The class is configured so that a single instance can be constructed and used for multiple evaluations of
different rays. The results of the evaluation are not preserved between invocations on the same ReferenceIntersector.

The class also offers an option to return element results encountered in Revit Links. When the
`P:Autodesk.Revit.DB.ReferenceIntersector.FindReferencesInRevitLinks` flag
is set, the results may include elements in the host document and in any RevitLinkInstance encountered, depending
on the other flags set. See the remarks for `P:Autodesk.Revit.DB.ReferenceIntersector.FindReferencesInRevitLinks` for details on how the
flags affect the results obtained from links.

#### Since

2013

### `T:Autodesk.Revit.DB.FindReferenceTarget`

Member kind: type
Symbol: `Autodesk.Revit.DB.FindReferenceTarget`

#### Summary

The type of reference to find from a ReferenceIntersector.

#### Since

2013

#### Summary

The type of reference to find

#### Since

2013

### `F:Autodesk.Revit.DB.FindReferenceTarget.All`

Member kind: field
Symbol: `Autodesk.Revit.DB.FindReferenceTarget.All`

#### Summary

All target types.

### `F:Autodesk.Revit.DB.FindReferenceTarget.Face`

Member kind: field
Symbol: `Autodesk.Revit.DB.FindReferenceTarget.Face`

#### Summary

A face.

### `F:Autodesk.Revit.DB.FindReferenceTarget.Curve`

Member kind: field
Symbol: `Autodesk.Revit.DB.FindReferenceTarget.Curve`

#### Summary

A curve.

### `F:Autodesk.Revit.DB.FindReferenceTarget.Edge`

Member kind: field
Symbol: `Autodesk.Revit.DB.FindReferenceTarget.Edge`

#### Summary

An edge.

### `F:Autodesk.Revit.DB.FindReferenceTarget.Mesh`

Member kind: field
Symbol: `Autodesk.Revit.DB.FindReferenceTarget.Mesh`

#### Summary

A mesh.

### `F:Autodesk.Revit.DB.FindReferenceTarget.Element`

Member kind: field
Symbol: `Autodesk.Revit.DB.FindReferenceTarget.Element`

#### Summary

An element.

### `T:Autodesk.Revit.DB.RectangularGridSegmentOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.RectangularGridSegmentOrientation`

#### Summary

The orientation type of rectangular grid segment.

#### Since

2012

### `F:Autodesk.Revit.DB.RectangularGridSegmentOrientation.Horizontal`

Member kind: field
Symbol: `Autodesk.Revit.DB.RectangularGridSegmentOrientation.Horizontal`

#### Summary

A horizontal GridSegment

### `F:Autodesk.Revit.DB.RectangularGridSegmentOrientation.Vertical`

Member kind: field
Symbol: `Autodesk.Revit.DB.RectangularGridSegmentOrientation.Vertical`

#### Summary

A vertical GridSegment

### `P:Autodesk.Revit.DB.Lighting.RectangleLightShape.EmitWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.RectangleLightShape.EmitWidth`

#### Summary

The emit width.

#### Value

The emit width as a numerical value in feet between 1.0e-9 and 30000.0

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The shape dimension is not valid because it is not between 1.0e-9 and 30000.0.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.RectangleLightShape.EmitLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.RectangleLightShape.EmitLength`

#### Summary

The emit length.

#### Value

The emit length as a numerical value in feet between 1.0e-9 and 30000.0

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The shape dimension is not valid because it is not between 1.0e-9 and 30000.0.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.RectangleLightShape.#ctor(Autodesk.Revit.DB.Lighting.RectangleLightShape)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.RectangleLightShape.#ctor(Autodesk.Revit.DB.Lighting.RectangleLightShape)`

#### Summary

Creates a copy of the given rectangle light shape

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.RectangleLightShape.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.RectangleLightShape.#ctor(System.Double,System.Double)`

#### Summary

Creates a rectangle light shape object with the given emit length and width.

#### Parameter `emitLength`

The emit length as a numerical value in feet between 1.0e-9 and 30000.0

#### Parameter `emitWidth`

The emit width as a numerical value in feet between 1.0e-9 and 30000.0

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The shape dimension is not valid because it is not between 1.0e-9 and 30000.0.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.RectangleLightShape.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.RectangleLightShape.#ctor`

#### Summary

Creates a rectangle light shape object with 4.0' emit length and a 2.0' emit width.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.RectangleLightShape`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.RectangleLightShape`

#### Summary

This class encapsulates a rectangle light shape.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightShape.Clone`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightShape.Clone`

#### Summary

Creates a copy of the LightShape derived object.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.LightShape.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.LightShape.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Lighting.LightShape`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.LightShape`

#### Summary

This class is the base class for specifying light shape.

#### Since

2013

### `M:Autodesk.Revit.DB.Rectangle.IsNormalized`

Member kind: method
Symbol: `Autodesk.Revit.DB.Rectangle.IsNormalized`

#### Summary

Returns true if the rectangle coordinates are normalized to the screen coordinate space; that is, left is less than right and top is less than bottom.

#### Since

2014

### `P:Autodesk.Revit.DB.Rectangle.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Rectangle.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Rectangle.Bottom`

Member kind: property
Symbol: `Autodesk.Revit.DB.Rectangle.Bottom`

#### Summary

The y-coordinate of the bottom-right corner of the rectangle.

#### Since

2014

### `P:Autodesk.Revit.DB.Rectangle.Right`

Member kind: property
Symbol: `Autodesk.Revit.DB.Rectangle.Right`

#### Summary

The x-coordinate of the bottom-right corner of the rectangle.

#### Since

2014

### `P:Autodesk.Revit.DB.Rectangle.Top`

Member kind: property
Symbol: `Autodesk.Revit.DB.Rectangle.Top`

#### Summary

The y-coordinate of the top-left corner of the rectangle.

#### Since

2014

### `P:Autodesk.Revit.DB.Rectangle.Left`

Member kind: property
Symbol: `Autodesk.Revit.DB.Rectangle.Left`

#### Summary

The x-coordinate of the top-left corner of the rectangle.

#### Since

2014

### `M:Autodesk.Revit.DB.Rectangle.#ctor(System.Int32,System.Int32,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Rectangle.#ctor(System.Int32,System.Int32,System.Int32,System.Int32)`

#### Summary

Creates an Rectangle instance with the specified four integers
that represent the left, top, right and bottom of a rectangle.

#### Parameter `left`

The x-coordinate of the top-left corner.

#### Parameter `top`

The y-coordinate of the top-left corner.

#### Parameter `right`

The x-coordinate of the bottom-right corner.

#### Parameter `bottom`

The y-coordinate of the bottom-right corner.

#### Since

2014

### `M:Autodesk.Revit.DB.Rectangle.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Rectangle.#ctor`

#### Summary

Create an empty Rectangle instance with values (0,0,0,0).

#### Since

2014

### `M:Autodesk.Revit.DB.Rectangle.#ctor(Autodesk.Revit.DB.Rectangle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Rectangle.#ctor(Autodesk.Revit.DB.Rectangle)`

#### Summary

Constructs a new copy of the input ScreenRectangle object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.Rectangle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Rectangle`

#### Summary

Stores a set of four integers that represent the left, top, right and bottom of a rectangle.

#### Remarks

It usually represents a rectangle on the screen. Left must be less than right and top must be less than bottom.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarHandlePositionData.GetDistributionPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlePositionData.GetDistributionPath`

#### Summary

Gets the distribution path currently stored in the rebar.

#### Remarks

For a free form rebar set the distance between two consecutive bars may be different if it is calculated between different points on bars.
The distribution path is an array of curves with the property that based on these curves the set was calculated to respect the layout rule and number of bars or spacing.

#### Returns

Returns array of curves that represent the distribution path.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Structure.RebarHandlePositionData.SetPosition(System.Int32,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlePositionData.SetPosition(System.Int32,Autodesk.Revit.DB.XYZ)`

#### Summary

Sets the position for a specified handle. This information is set to the rebar after the API execution is finished successfully.

#### Parameter `handleTag`

The tag of the handle.

#### Parameter `position`

Position of the handle.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input point lies outside of Revit design limits.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarHandlePositionData.GetBarGeometry(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlePositionData.GetBarGeometry(System.Int32)`

#### Summary

Returns the geometry for a bar at the specified index currently in the Rebar.

#### Parameter `barIndex`

The index of the bar. Should be a number between 0 and GetNumberOfBars() - 1.

#### Returns

Returns an array of curves that defines the bar at the specified index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barIndex is not in the range [ 0, GetNumberOfBars()-1 ].

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarHandlePositionData.GetNumberOfBars`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlePositionData.GetNumberOfBars`

#### Summary

Gets the number of bars currently in the rebar.

#### Returns

Returns the number of bars currently in the rebar.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarHandlePositionData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlePositionData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarHandlePositionData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlePositionData`

#### Summary

The class that contains data for the handle position calculation.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarTrimExtendData.GetRebarUpdateCurvesData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarTrimExtendData.GetRebarUpdateCurvesData`

#### Summary

Gets a class that contains information used as input and output for rebar free form calculation.

#### Returns

Gets a class that contains information used as input and output for rebar free form calculation.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarTrimExtendData.CreateEndConstraint(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference},System.Boolean,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarTrimExtendData.CreateEndConstraint(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference},System.Boolean,System.Double)`

#### Summary

Creates a constraint for the end handle of the rebar. This constraint will be set preferred after the API execution is finished successfully.

#### Parameter `targetReferences`

The references to which the rebar handle will be constrained.
Will throw exception if it's empty or if it's anything but Face(s) from a structural that can host rebar.

#### Parameter `isConstraintToCover`

If true the RebarConstraintType will be set to ToCover, otherwise RebarConstraintType will be set to FixedDistanceToHostFace.

#### Parameter `offsetValue`

The distance from references to the rebar handle.

#### Returns

Returns true if a start constraint can be created with the given references, false otherwise.
The reference should be faces from structurals that can host rebar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarTrimExtendData.CreateStartConstraint(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference},System.Boolean,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarTrimExtendData.CreateStartConstraint(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference},System.Boolean,System.Double)`

#### Summary

Creates a constraint for the start handle of the rebar. This constraint will be set preferred after the API execution is finished successfully.

#### Parameter `targetReferences`

The references to which the rebar handle will be constrained.
Will throw exception if it's empty or if it's anything but Face(s) from a structural that can host rebar.

#### Parameter `isConstraintToCover`

If true the RebarConstraintType will be set to ToCover, otherwise RebarConstraintType will be set to FixedDistanceToHostFace.

#### Parameter `offsetValue`

The distance from references to the rebar handle.

#### Returns

Returns true if a start constraint can be created with the given references, false otherwise.
The reference should be faces from structurals that can host rebar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarTrimExtendData.GetNumberOfBarGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarTrimExtendData.GetNumberOfBarGeometry`

#### Summary

Gets the number of Bar Geometry that were added.

#### Returns

Returns the number of Bar Geometry that were added.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarTrimExtendData.CanAddBarGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarTrimExtendData.CanAddBarGeometry`

#### Summary

Returns true if getNumberOfBarGeometry() is less than GetNumberOfBars(), false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarTrimExtendData.AddBarGeometry(Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarTrimExtendData.AddBarGeometry(Autodesk.Revit.DB.CurveLoop)`

#### Summary

Adds a new rebar geometry. This information is set to the rebar after the API execution is finished successfully.

#### Remarks

This function can fail due to following reasons:

CurveLoop is empty.

CurveLoop contains an unbounded curve.

A rebar constructed from curves can't be bent according to the bending radius.

#### Parameter `curves`

Curves describing one bar in the set.

#### Returns

Returns Success if everything is ok, otherwise the failure reason.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Incorrect number of bar geometry.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarTrimExtendData.AddBarGeometry(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarTrimExtendData.AddBarGeometry(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

#### Summary

Adds a new rebar geometry. This information is set to the rebar after the API execution is finished successfully.

#### Remarks

This function will can fail due to following reasons:

One or more of the input curves was null.

One or more of the input curves was unbounded.

Curves doesn't form a valid curve loop, it forms 0, 2 or more curve loops.

A rebar constructed from curves can't be bent according to the bending radius.

#### Parameter `curves`

Curves describing one bar in the set.

#### Returns

Returns Success if everything is ok, otherwise the failure reason.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Incorrect number of bar geometry.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarTrimExtendData.ClearAllAddedBarGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarTrimExtendData.ClearAllAddedBarGeometry`

#### Summary

This function will remove all bars geometry that were added by calling AddBarGeometry().

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarTrimExtendData.GetAddedBarGeometry(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarTrimExtendData.GetAddedBarGeometry(System.Int32)`

#### Summary

Gets the added curves that will represent the bar at index barIndex.

#### Parameter `barIndex`

The index of the bar. Should be a number between 0 and GetNumberOfBarGeometry() - 1.

#### Returns

Returns the curves that will represent the bar at index barIndex. The hooks plane normals will be applied on these curves.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barIndex is not in the range [ 0, GetNumberOfBarGeometry()-1 ].

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarTrimExtendData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarTrimExtendData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarTrimExtendData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarTrimExtendData`

#### Summary

The class that contains the information needed to calculate and return the curves in a trimmed/extended state, and also find the constraints that trim/extend it.

#### Remarks

If new curves will be added by calling addBarGeometry(), the existing curves in Rebar element will be replaced with these curves. It will not add curves to the existing ones.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarCurvesData.GetRebarUpdateCurvesData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCurvesData.GetRebarUpdateCurvesData`

#### Summary

Gets a class that contains information used as input and output for rebar free form calculation.

#### Returns

Gets a class that contains information used as input and output for rebar free form calculation.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarCurvesData.SetDistributionPath(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCurvesData.SetDistributionPath(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

#### Summary

Sets a new distribution path to be applied to the rebar. This information is set to the rebar after the API execution is finished successfully.

#### Remarks

For a free form rebar set the distance between two consecutive bars may be different if it is calculated between different points on bars.
The distribution path is an array of curves with the property that based on these curves the set was calculated to respect the layout rule and number of bars or spacing.

#### Parameter `path`

Input curves that describe the new path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarCurvesData.GetDistributionPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCurvesData.GetDistributionPath`

#### Summary

Gets the distribution path currently stored in the rebar.

#### Remarks

For a free form rebar set the distance between two consecutive bars may be different if it is calculated between different points on bars.
The distribution path is an array of curves with the property that based on these curves the set was calculated to respect the layout rule and number of bars or spacing.

#### Returns

Returns array of curves that represent the distribution path.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarCurvesData.GetNumberOfBarGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCurvesData.GetNumberOfBarGeometry`

#### Summary

Gets the number of Bar Geometry that were added.

#### Returns

Returns the number of Bar Geometry that were added.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarCurvesData.CanAddBarGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCurvesData.CanAddBarGeometry`

#### Summary

If the layout rule is Singe or FixedNumber or NumberWithSpacing this function will return true if getNumberOfBarGeometry() is less getBarsNumber(), false otherwise.

If the layout rule is MaximumSpacing or MinimumClearSpacing this function will return always true.

#### Returns

Returns true if we can add more bar geometry for the current layout, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarCurvesData.AddBarGeometry(Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCurvesData.AddBarGeometry(Autodesk.Revit.DB.CurveLoop)`

#### Summary

Adds a new bar to the new rebar geometry. This information is set to the rebar after the API execution is finished successfully.

#### Remarks

This function can fail due to following reasons:

CurveLoop is empty.

CurveLoop contains an unbounded curve.

A rebar constructed from curves can't be bent according to the bending radius.

#### Parameter `curves`

Curves describing one bar in the set.

#### Returns

Returns Success if everything is ok, otherwise the failure reason.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Incorrect number of bar geometry for the current layout.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarCurvesData.AddBarGeometry(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCurvesData.AddBarGeometry(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve})`

#### Summary

Adds a new bar to the new rebar geometry. This information is set to the rebar after the API execution is finished successfully.

#### Remarks

This function will can fail due to following reasons:

One or more of the input curves was null.

One or more of the input curves was unbounded.

Curves doesn't form a valid curve loop, it forms 0, 2 or more curve loops.

A rebar constructed from curves can't be bent according to the bending radius.

#### Parameter `curves`

Curves describing one bar in the set.

#### Returns

Returns Success if everything is ok, otherwise the failure reason.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Incorrect number of bar geometry for the current layout.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarCurvesData.ClearAllAddedBarGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCurvesData.ClearAllAddedBarGeometry`

#### Summary

This function will remove all bars geometry that were added by calling AddBarGeometry().

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarCurvesData.GetAddedBarGeometry(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarCurvesData.GetAddedBarGeometry(System.Int32)`

#### Summary

Gets the added curves that will represent the bar at index barIndex.

#### Parameter `barIndex`

The index of the bar. Should be a number between 0 and GetNumberOfBarGeometry() - 1.

#### Returns

Returns the curves that will represent the bar at index barIndex. The hooks plane normals will be applied on these curves.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barIndex is not in the range [ 0, GetNumberOfBarGeometry()-1 ].

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarCurvesData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarCurvesData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarCurvesData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarCurvesData`

#### Summary

The class that contains the information needed to calculate and return the result of the external curve generation.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.SetCycleCounter(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.SetCycleCounter(System.Int32)`

#### Summary

Sets the cycle counter to a specific value.

#### Remarks

The actual value is set into the rebar after the curves computation.

This function can be called to reset the counter to zero or to another value.

The cycle counter value is changed when the free form Rebar element is selected and the user press Space key
-or- by through `!:Autodesk::Revit::DB::Structure::RebarRebarFreeFormAccessor::CycleCounter` property.
-or- by the server if it considers that the counter reaches the maximum value and reset it (set it to 0).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for cycleCounter is negative.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetCycleCounter`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetCycleCounter`

#### Summary

Gets the cycle counter that is stored in the rebar.

#### Remarks

The cycle counter value is changed when the free form Rebar element is selected and the user press Space key
-or- by through `!:Autodesk::Revit::DB::Structure::RebarRebarFreeFormAccessor::CycleCounter` property.
-or- by the server if it considers that the counter reaches the maximum value and reset it (set it to 0).

#### Returns

Returns the cycle counter.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetRebarId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetRebarId`

#### Summary

Get the id of the Rebar element currently being calculated.

#### Returns

returns the id of the Rebar element currently being calculated

#### Since

2020

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetDocument`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetDocument`

#### Summary

Gets a reference to the current document.

#### Returns

Returns a reference to the current document.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetHookOrientationAngle(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetHookOrientationAngle(System.Int32)`

#### Summary

Get the hook orientation angle at end that is currently in the rebar.

#### Parameter `end`

The end of bar. Should be 0 for start or 1 for end.

#### Returns

The hook orientation angle at end that is currently in the rebar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Invalid end.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.SetHookOrientationAngle(System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.SetHookOrientationAngle(System.Int32,System.Double)`

#### Summary

Set the hook orientation angle at end. This information is set to the rebar after the API execution is finished successfully.

#### Parameter `end`

The end of bar. Should be 0 for start or 1 for end.

#### Parameter `angle`

The hook orientation angle at end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Invalid end.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetHookPlaneNormalForBarIdx(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetHookPlaneNormalForBarIdx(System.Int32,System.Int32)`

#### Summary

Returns the normal of plane in which the hook at end of bar with index barPositionIndex that is currently in Rebar.

#### Parameter `end`

The end of bar. Should be 0 for start or 1 for end.

#### Parameter `barPositionIndex`

An index between 0 and (GetNumberOfBars()-1).

#### Returns

The normal of plane in which the hook at end of bar with index barPositionIndex that is currently in Rebar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, GetNumberOfBars()-1 ].
-or-
Invalid end.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.SetHookPlaneNormalForBarIdx(System.Int32,System.Int32,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.SetHookPlaneNormalForBarIdx(System.Int32,System.Int32,Autodesk.Revit.DB.XYZ)`

#### Summary

Set the normal of plane in which the hook at end of bar with index barPositionIndex will stay. This information is set to the rebar after the API execution is finished successfully.

#### Remarks

This information is set to the rebar after the API execution is finished successfully. Before setting the value a validation will be done.
We consider a hook plane normal valid if it isn't parallel with the bar direction at end.

#### Parameter `end`

The end of bar. Should be 0 for start or 1 for end.

#### Parameter `barPositionIndex`

Index of the bar for which it will set hook plane normal.

#### Parameter `hookNormal`

The normal of plane in which the hook at end of bar with index barPositionIndex will stay.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Invalid end.
-or-
hookNormal has zero length.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetHostId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetHostId`

#### Summary

Gets the id of the host structural for this rebar.

#### Returns

Returns the id of the host structural for this rebar.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetBarsNumber`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetBarsNumber`

#### Summary

Gets the number of bars specified in the layout options.
This is used to calculate the sets driven by bar number.

#### Returns

Returns the number of bars specified in the layout options.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetLayoutRule`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetLayoutRule`

#### Summary

Gets the layout rule for this bar.

#### Returns

Returns the layout rule for this bar.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetBendingRadius`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetBendingRadius`

#### Summary

Gets the current bending radius of the rebar.

#### Returns

Returns the current bending radius of the rebar.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetAttachmentType`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetAttachmentType`

#### Summary

Returns attachment type for stirrups to be used in cover calculation.

#### Returns

InteriorFace : rebar to attach to interior face of cover reference.

ExteriorFace : rebar to attach to exterior face of cover reference.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetRebarStyle`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetRebarStyle`

#### Summary

Gets the style of the rebar.

#### Returns

Gets the style of the rebar (Standard or StirrupTie).

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetBarNominalDiameter`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetBarNominalDiameter`

#### Summary

Gets the nominal diameter of the Rebar.

#### Returns

Returns the nominal diameter of the Rebar.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetBarModelDiameter`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetBarModelDiameter`

#### Summary

Gets the model diameter of the Rebar.

#### Returns

Returns the model diameter of the Rebar.

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetEndConstraint`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetEndConstraint`

#### Summary

Gets the current constraint for the end handle of the Rebar.

#### Returns

Returns the current constraint for the end handle of the Rebar. Return value is null is no constraint is present.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetStartConstraint`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetStartConstraint`

#### Summary

Gets the current constraint for the start handle of the Rebar.

#### Returns

Returns the current constraint for the start handle of the Rebar. Return value is null if no constraint is present.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetCustomConstraints`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetCustomConstraints`

#### Summary

Gets all rebar constraints that are attached to custom handles for this rebar.

#### Returns

Returns all rebar constraints that are attached to custom handles for this rebar. This array does not contains the start and end constraints.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetChangedSharedParameterGUIDs`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetChangedSharedParameterGUIDs`

#### Summary

Returns an array containing the shared parameter GUIDs that were changed since the last regeneration.
Array is empty if no shared params were changed since the last regeneration.

#### Returns

Returns an array containing the elementId of the shared params that were changed since the last regeneration.

#### Since

2020

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetChangedCustomHandles`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetChangedCustomHandles`

#### Summary

Returns an array containing custom handles that were changed since the last regeneration.
Array is empty if no handles were changed since the last regeneration.

#### Returns

Returns an array containing the tags of custom handles that were changed since the last regeneration.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetBarGeometry(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetBarGeometry(System.Int32)`

#### Summary

Returns the geometry for a bar at the specified index currently in the Rebar.

#### Parameter `barIndex`

The index of the bar. Should be a number between 0 and GetNumberOfBars() - 1.

#### Returns

Returns an array of curves that defines the bar at the specified index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barIndex is not in the range [ 0, GetNumberOfBars()-1 ].

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetNumberOfBars`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.GetNumberOfBars`

#### Summary

Returns the number of bars currently in the rebar.

#### Returns

Returns the number of bars currently in the rebar.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.AlignedFreeFormSetOrientationOptions`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.AlignedFreeFormSetOrientationOptions`

#### Summary

Orientation options for an Aligned Free Form Rebar set.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.AreOrientationOptionsChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.AreOrientationOptionsChanged`

#### Summary

Indicates if the orientation options have changed since the last regeneration.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.CycleCounterChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.CycleCounterChanged`

#### Summary

True if the cycle counter was changed, false otherwise.

The cycle counter value is changed when the free form Rebar element is selected and the user press Space key
-or- by through `!:Autodesk::Revit::DB::Structure::RebarRebarFreeFormAccessor::CycleCounter` property.
-or- by the server if it considers that the counter reaches the maximum value and reset it (set it to 0).

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.ErrorMessage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.ErrorMessage`

#### Summary

The reason for calculation failure. If the calculation fails, this message will be shown in an error, or warning if we are editing the constraints.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: errorMessage is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2018.1

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsReversed`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsReversed`

#### Summary

Used to store the state of the bar refering to the direction of the bars.
This is useful when using face intersection to calculate bars.
After mirroring, curves created from intersecting faces may be reversed,
so we use this to store the state and keep the rebar pointing in the correct direction.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.HostMirrored`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.HostMirrored`

#### Summary

If true, then host of the rebar was mirrorred (along with the rebar) before this regeneration.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.Spacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.Spacing`

#### Summary

The spacing between the bars, according to the LayoutRule.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsBendingRadiusChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsBendingRadiusChanged`

#### Summary

Indicates if the bending radius has changed since the last regeneration.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsStyleChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsStyleChanged`

#### Summary

Indicates if the style has changed since the last regeneration.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsAttachmentTypeChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsAttachmentTypeChanged`

#### Summary

Indicates if the attachment type has changed since the last regeneration.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsEndConstraintChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsEndConstraintChanged`

#### Summary

Indicates if the end handle constraint has changed since the last regeneration.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsStartConstraintChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsStartConstraintChanged`

#### Summary

Indicates if the start handle constraint has changed since the last regeneration.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsBarsNumberChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsBarsNumberChanged`

#### Summary

Indicates if the bar number has changed since the last regeneration.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsSpacingChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsSpacingChanged`

#### Summary

Indicates if the spacing has changed since the last regeneration.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsLayoutChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.IsLayoutChanged`

#### Summary

Indicates if the layout has changed since the last regeneration.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.WorkshopInstructions`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.WorkshopInstructions`

#### Summary

Identifies the workshop instructions of this rebar.

#### Since

2019

### `P:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.AreWorkshopInstructionsChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData.AreWorkshopInstructionsChanged`

#### Summary

Indicates if the workshop instructions have changed since the last regeneration.

#### Since

2019

### `T:Autodesk.Revit.DB.Structure.RebarUpdateCurvesData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarUpdateCurvesData`

#### Summary

Class holding the information needed to calculate the rebar curves.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarHandleNameData.SetCustomHandleName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHandleNameData.SetCustomHandleName(System.String)`

#### Summary

Sets the name of the handle.

#### Parameter `customHandleName`

The name of the handle.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarHandleNameData.GetCustomHandleTag`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHandleNameData.GetCustomHandleTag`

#### Summary

Gets the handle tag for which we need to specify the name.

#### Returns

Returns the handle tag for which we need to specify the name.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarHandleNameData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarHandleNameData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarHandleNameData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarHandleNameData`

#### Summary

This class is used to contain the information about the rebar handle name defined by an external application.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarHandlesData.GetEndHandle`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlesData.GetEndHandle`

#### Summary

Gets the end handle tag.

#### Returns

Returns the end handle tag.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarHandlesData.SetEndHandle(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlesData.SetEndHandle(System.Int32)`

#### Summary

Sets the end handle tag. This information is set to the rebar after the API execution is finished successfully.

#### Parameter `endHandleTag`

The tag of the end handle.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarHandlesData.GetStartHandle`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlesData.GetStartHandle`

#### Summary

Gets the start handle tag.

#### Returns

Returns the start handle tag.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarHandlesData.SetStartHandle(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlesData.SetStartHandle(System.Int32)`

#### Summary

Sets the start handle tag. This information is set to the rebar after the API execution is finished successfully.

#### Parameter `startHandleTag`

The tag of the start handle.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarHandlesData.GetCustomHandles`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlesData.GetCustomHandles`

#### Summary

Gets the handle definitions for the rebar that were added.

#### Returns

Returns all custom handles.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarHandlesData.AddCustomHandle(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlesData.AddCustomHandle(System.Int32)`

#### Summary

Adds a new handle definition to the rebar. This information is set to the rebar after the API execution is finished successfully.

#### Parameter `customHandleTag`

The tag of the handle. The tag should be different from the previous ones that were added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

customHandleTag is a duplicate tag.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.RebarHandlesData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlesData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarHandlesData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarHandlesData`

#### Summary

This class is used to contain the information about the rebar handles defined by an external application.

#### Remarks

All handle tags (custom, start, end) should have different values.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarSystemSpanSymbol.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarSystemSpanSymbol.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of RebarSystemSpanSymbol in the project.

#### Parameter `document`

The document.

#### Parameter `viewId`

The id of the view in which the symbol should appear.

#### Parameter `hostId`

The ElementId of AreaReinforcement (either in the document, or linked from another document).

#### Parameter `point`

The span symbol's head position.

#### Parameter `symbolId`

The id of the family symbol of this symbol.

#### Returns

A reference to newly created span symbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

hostId should refer to a AreaReinforcement element.
-or-
viewId does not refer to a valid view type for FabricReinSpanSymbol - only floor plan, reflected ceiling plans and elevations are permitted.
-or-
symbolId should refer to a FamilySymbol of category OST_FabricReinSpanSymbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.Structure.RebarSystemSpanSymbol`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarSystemSpanSymbol`

#### Summary

Represents a Rebar System Span Symbol element in Autodesk Revit.

### `M:Autodesk.Revit.DB.Structure.RebarShapeParameters.GetAllRebarShapeParameters(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeParameters.GetAllRebarShapeParameters(Autodesk.Revit.DB.Document)`

#### Summary

List all shape parameters used by all the existing RebarShapes in the specified document.

#### Remarks

This method replaces RebarShape.GetAllRebarShapeParameters() from prior releases.

#### Parameter `doc`

The document.

#### Returns

ElementIds corresponding to the external parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeParameters.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeParameters.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarShapeParameters.GetExternalDefinitionForElementId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.DefinitionFile)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeParameters.GetExternalDefinitionForElementId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.DefinitionFile)`

#### Summary

Seach a DefinitionFile for the ExternalDefinition corresponding to a parameter
in a document.

#### Returns

The external parameter corresponding to the parameter's ElementId,
or null if the Id does not correspond to an external parameter,
or the parameter is not in the definition file.

#### Parameter `doc`

A document.

#### Parameter `paramId`

The id of a shared parameter in the document.

#### Parameter `definitionFile`

A database of shared parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was `null` .

### `M:Autodesk.Revit.DB.Structure.RebarShapeParameters.GetOrCreateElementIdForExternalDefinition(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalDefinition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeParameters.GetOrCreateElementIdForExternalDefinition(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalDefinition)`

#### Summary

Retrieve the ElementId corresponding to an external rebar shape parameter
in the document, if it exists; otherwise, add the parameter to the document
and generate a new ElementId.

#### Remarks

Before a parameter can be used in a RebarShapeDefinition, it must
exist in the definition's document. There are two ways to achieve this.
It can be bound to one or more categories in the document using
the Document.ParameterBindings property, or it can be created with this
method.

#### Returns

An ElementId representing the shared parameter stored in the document.

#### Parameter `doc`

A document.

#### Parameter `externalDefinition`

A shared parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was `null` .

### `M:Autodesk.Revit.DB.Structure.RebarShapeParameters.GetElementIdForExternalDefinition(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalDefinition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeParameters.GetElementIdForExternalDefinition(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalDefinition)`

#### Summary

Retrieve the ElementId corresponding to an external rebar shape parameter
in the document, if it exists; otherwise, return InvalidElementId.

#### Remarks

Before a parameter can be used in a RebarShapeDefinition, it must
exist in the definition's document. There are two ways to achieve this.
It can be bound to one or more categories in the document using
the Document.ParameterBindings property, or it can be created by
calling RebarShapeParameters.GetOrCreateElementIdForExternalDefinition().

#### Returns

An ElementId representing the shared parameter stored in the document,
or InvalidElementId if the parameter is not stored in the document.

#### Parameter `doc`

A document.

#### Parameter `externalDefinition`

A shared parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was `null` .

### `M:Autodesk.Revit.DB.Structure.RebarShapeParameters.IsValidExternalDefinition(Autodesk.Revit.DB.ExternalDefinition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeParameters.IsValidExternalDefinition(Autodesk.Revit.DB.ExternalDefinition)`

#### Summary

Checks that an ExternalDefinition (shared parameter) may be used as a Rebar Shape parameter.

#### Remarks

A Rebar Shape parameter must be an ExternalDefinition with a ParameterType of Length.

#### Parameter `param`

Definition of a shared parameter.

#### Returns

True if the definition is of type Length, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was `null`

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeParameters`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeParameters`

#### Summary

Class containing functions that create and retrieve shared parameters for RebarShapes.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeListeningDimension.GetVertexId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeListeningDimension.GetVertexId(System.Int32)`

#### Returns

may return -1 if reference to whole edge

### `T:Autodesk.Revit.DB.Structure.RebarShapeListeningDimension`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeListeningDimension`

#### Summary

Reporting dimensions that corresponds to read-only shape parameters.

### `M:Autodesk.Revit.DB.Structure.RebarShapeVertex.SetConstraints(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.RebarShapeConstraint})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeVertex.SetConstraints(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.RebarShapeConstraint})`

#### Summary

Assign a new list of constraints to this vertex.

#### Remarks

Any existing constraints are discarded. The new constraints replace them.
Any parameters driving the constraints must already be added
with RebarShapeDefinition.AddParameter().

The allowable constraint types are:
RebarShapeConstraintRadiusRebarShapeConstraintArcLength
Any number of constraints may be specified. With no constraints,
the bend radius will default to the appropriate bend radius
from the RebarBarType element.

#### Parameter `constraints`

A new list of constraints.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more of the constraints is of a type not supported for RebarShapeVertex.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeVertex.GetConstraints`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeVertex.GetConstraints`

#### Summary

Retrieve the list of constraints associated with this vertex.

#### Returns

The list of constraints.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeVertex.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeVertex.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarShapeVertex.BendAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeVertex.BendAngle`

#### Summary

The range of permissible angles at this bend.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeVertex.Turn`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeVertex.Turn`

#### Summary

The sense of the turn. The Turn property must be set to Left or Right on each internal vertex
before the RebarShapeDefinitionBySegments is used.
Default is permissible for the first and last vertex, since they do not correspond to bends.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: turn must be Left or Right.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeVertex`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeVertex`

#### Summary

A bend between segments of a rebar shape definition.

#### Remarks

A RebarShapeVertex is part of a RebarShapeDefinitionBySegments object.
There is one vertex between each pair of adjacent segments, plus one at
each end of the overall shape. The end vertices currently are ignored
by the shape definition, even if they have constraints.

A bend may have the default radius of the bar type referenced by the Rebar element,
or it may have a radius defined by a parameter.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeSegment.SetConstraints(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.RebarShapeConstraint})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeSegment.SetConstraints(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.RebarShapeConstraint})`

#### Summary

Assign a new list of constraints to this segment.

#### Remarks

Any existing constraints are discarded. The new constraints replace them.
Any parameters driving the constraints must already be added
with RebarShapeDefinition.AddParameter().

The allowable constraint types are:
RebarShapeConstraintAngleFromFixedDirRebarShapeConstraintSegmentLengthRebarShapeConstraintFixedSegmentDirRebarShapeConstraintProjectedSegmentLengthRebarShapeConstraint180DegreeBendArcLengthRebarShapeConstraint180DegreeBendRadiusRebarShapeConstraint180DegreeDefaultBend
At least two independent constraints must be specified. Overconstraining
is supported. Constraints of type RebarShapeConstraintFixedSegmentDir must be unique.

#### Parameter `constraints`

A new list of constraints.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more of the constraints is of a type not supported for RebarShapeSegment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeSegment.GetConstraints`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeSegment.GetConstraints`

#### Summary

Retrieve the list of constraints associated with this segment.

#### Returns

The list of constraints.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeSegment.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeSegment.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarShapeSegment`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeSegment`

#### Summary

Part of a RebarShapeDefinitionBySegments, representing one segment
of a shape definition.
Makes sure constraints of type RebarShapeConstraintFixedSegmentDir are uniquely set.
If we try to aquire a second constraint of type RebarShapeConstraintFixedSegmentDir we delete the old one.

#### Remarks

Each segment must have enough constraints
to determine its position. Overconstraining is allowed.
The most common combinations are:
A fixed direction together with a parallel length constraint;A parallel length constraint plus another length constraint parallel to the x-axis or y-axis;A parallel length constraint plus length constraints parallel to both the x-axis and y-axis.
Multiple constraints may be driven by the same parameter, even on the same segment.

Length constraints may be measured in two ways.
For "measured to the outside of the bend," the reference is a tangent to the
exterior face of the bar; the thickness of the bar is included.
For "measured to the inside," the reference is the center of the arc of the bend;
this is the point where the bend begins, if the constraint is parallel to the segment.

A 180-degree bend is described by introducing a short segment in between the
two straight segments, tangent to the midpoint of the bend.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddListeningDimensionSegmentToBend(Autodesk.Revit.DB.ElementId,System.Double,System.Double,System.Int32,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddListeningDimensionSegmentToBend(Autodesk.Revit.DB.ElementId,System.Double,System.Double,System.Int32,System.Int32,System.Int32)`

#### Summary

Specify a dimension perpendicular to one fixed-direction segment,
referring to that segment and some other bend in the shape,
measured by a read-only parameter.

#### Parameter `paramId`

Id of a parameter to report the length of the dimension. The parameter will be read-only
on Rebar instances.

#### Parameter `constraintDirCoordX`

The x-coordinate of a 2D vector specifying the constraint direction.

#### Parameter `constraintDirCoordY`

The y-coordinate of a 2D vector specifying the constraint direction.

#### Parameter `iSegment0`

Index of the first segment (0 to NumberOfSegments - 1).

#### Parameter `iSegment1`

Index of the second segment (0 to NumberOfSegments - 1).

#### Parameter `iEnd1`

End (0 or 1) of the second segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not the id of a shared parameter in the current document,
or its unit type is not UT_Reinforcement_Length or UT_Angle.
-or-
The length of the vector (constraintDirCoordX, constraintDirCoordY) is too close to zero.
-or-
iSegment0 is not between 0 and NumberOfSegments.
-or-
Edge iSegment0 has a variable angle; it must have a fixed angle perpendicular to (constraintDirCoordX, constraintDirCoordY).
-or-
iSegment1 is not between 0 and NumberOfSegments.
-or-
iEnd1 is neither 0 nor 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddListeningDimensionBendToBend(Autodesk.Revit.DB.ElementId,System.Double,System.Double,System.Int32,System.Int32,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddListeningDimensionBendToBend(Autodesk.Revit.DB.ElementId,System.Double,System.Double,System.Int32,System.Int32,System.Int32,System.Int32)`

#### Summary

Specify a dimension between two bends, measured by a read-only parameter.

#### Remarks

Each reference is at the outside of the bend, perpendicular to the specified segment. So the overall length of a shape with 5 segments might be defined by calling this function with iSegment0=0, iEnd0=0, iSegment1=4, iEnd1=1.

#### Parameter `paramId`

Id of a parameter to report the length of the dimension. The parameter will be read-only
on Rebar instances.

#### Parameter `constraintDirCoordX`

The x-coordinate of a 2D vector specifying the constraint direction.

#### Parameter `constraintDirCoordY`

The y-coordinate of a 2D vector specifying the constraint direction.

#### Parameter `iSegment0`

Index of the first segment (0 to NumberOfSegments - 1).

#### Parameter `iEnd0`

End (0 or 1) of the first segment.

#### Parameter `iSegment1`

Index of the second segment (0 to NumberOfSegments - 1).

#### Parameter `iEnd1`

End (0 or 1) of the second segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not the id of a shared parameter in the current document,
or its unit type is not UT_Reinforcement_Length or UT_Angle.
-or-
The length of the vector (constraintDirCoordX, constraintDirCoordY) is too close to zero.
-or-
iSegment0 is not between 0 and NumberOfSegments.
-or-
iEnd0 is neither 0 nor 1.
-or-
iSegment1 is not between 0 and NumberOfSegments.
-or-
iEnd1 is neither 0 nor 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddListeningDimensionSegmentToSegment(Autodesk.Revit.DB.ElementId,System.Double,System.Double,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddListeningDimensionSegmentToSegment(Autodesk.Revit.DB.ElementId,System.Double,System.Double,System.Int32,System.Int32)`

#### Summary

Specify a dimension perpendicular to two fixed-direction segments, measured by a read-only parameter.

#### Remarks

RebarShapeDefinitionBySegments supports driving (read-write) dimensions only when they are associated with a single segment. Non-driving dimensions can involve multiple segments.

#### Parameter `paramId`

Id of a parameter to report the length of the dimension. The parameter will be read-only
on Rebar instances.

#### Parameter `constraintDirCoordX`

The x-coordinate of a 2D vector specifying the constraint direction.

#### Parameter `constraintDirCoordY`

The y-coordinate of a 2D vector specifying the constraint direction.

#### Parameter `iSegment0`

Index of the first segment (0 to NumberOfSegments - 1).

#### Parameter `iSegment1`

Index of the second segment (0 to NumberOfSegments - 1).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not the id of a shared parameter in the current document,
or its unit type is not UT_Reinforcement_Length or UT_Angle.
-or-
The length of the vector (constraintDirCoordX, constraintDirCoordY) is too close to zero.
-or-
iSegment0 is not between 0 and NumberOfSegments.
-or-
iSegment1 is not between 0 and NumberOfSegments.
-or-
Edge iSegment0 has a variable angle; it must have a fixed angle perpendicular to (constraintDirCoordX, constraintDirCoordY).
-or-
Edge iSegment1 has a variable angle; it must have a fixed angle perpendicular to (constraintDirCoordX, constraintDirCoordY).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddBendVariableRadius(System.Int32,Autodesk.Revit.DB.Structure.RebarShapeVertexTurn,Autodesk.Revit.DB.Structure.RebarShapeBendAngle,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddBendVariableRadius(System.Int32,Autodesk.Revit.DB.Structure.RebarShapeVertexTurn,Autodesk.Revit.DB.Structure.RebarShapeBendAngle,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Specify a variable-radius bend.

#### Remarks

You must add a bend between each two segments.

#### Parameter `vertexIndex`

Index of the vertex (1 to NumberOfVertices - 2).

#### Parameter `turn`

Specify turn direction (RebarShapeVertexTurn::Left or RebarShapeVertexTurn::Right).

#### Parameter `angle`

Specify whether the bend is acute, obtuse, etc.

#### Parameter `paramId`

Id of a parameter driving the radius.

#### Parameter `measureIncludingBarThickness`

If true, the radius is measured to the outside of the
bend; if false, it is measured to the inside.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

vertexIndex is not between 0 and NumberOfVertices.
-or-
paramId is not the id of a shared parameter in the current document,
or its unit type is not UT_Reinforcement_Length or UT_Angle.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddBendDefaultRadius(System.Int32,Autodesk.Revit.DB.Structure.RebarShapeVertexTurn,Autodesk.Revit.DB.Structure.RebarShapeBendAngle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddBendDefaultRadius(System.Int32,Autodesk.Revit.DB.Structure.RebarShapeVertexTurn,Autodesk.Revit.DB.Structure.RebarShapeBendAngle)`

#### Summary

Specify a default-radius bend.

#### Remarks

You must add a bend at each vertex except the first and last.

#### Parameter `vertexIndex`

Index of the vertex (1 to NumberOfVertices - 2).

#### Parameter `turn`

Specify turn direction (RebarShapeVertexTurn::Left or RebarShapeVertexTurn::Right).

#### Parameter `angle`

Specify whether the bend is acute, obtuse, etc.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

vertexIndex is not between 0 and NumberOfVertices.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.RemoveParameterFromSegment(System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.RemoveParameterFromSegment(System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Remove constraints from a segment.

#### Remarks

This reverses the effect of any AddConstraint and SetSegmentAs180DegreeBend operations involving the specified segment and parameter.

#### Parameter `iSegment`

Index of the segment (0 to NumberOfSegments - 1).

#### Parameter `paramId`

Id of a parameter driving one or more constraints.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

iSegment is not between 0 and NumberOfSegments.
-or-
paramId is not the id of a shared parameter in the current document,
or its unit type is not UT_Reinforcement_Length or UT_Angle.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.SetSegmentAs180DegreeBend(System.Int32,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.SetSegmentAs180DegreeBend(System.Int32,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Indicate that a segment is a "virtual" segment introduced to describe a 180-degree bend. The radius of the bend will be driven by radiusParam.

#### Parameter `iSegment`

Index of the segment (0 to NumberOfSegments - 1).

#### Parameter `paramId`

Id of a parameter to drive the radius.
To obtain the id of a shared parameter,
call RebarShape.GetElementIdForExternalDefinition().

#### Parameter `measureToOutsideOfBend`

Choose between two possibilities for the references of the radius dimension.
If true, measure to the exterior face of the bar. If false, measure to the interior face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

iSegment is not between 0 and NumberOfSegments.
-or-
paramId is not the id of a shared parameter in the current document,
or its unit type is not UT_Reinforcement_Length or UT_Angle.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.SetSegmentAs180DegreeBend(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.SetSegmentAs180DegreeBend(System.Int32)`

#### Summary

Indicates that a segment is a "virtual" segment introduced to describe a 180-degree bend. The radius of the bend will be taken from the Bar Type.

#### Parameter `iSegment`

Index of the segment (0 to NumberOfSegments - 1).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

iSegment is not between 0 and NumberOfSegments.

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddConstraintToSegment(System.Int32,Autodesk.Revit.DB.ElementId,System.Double,System.Double,System.Int32,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddConstraintToSegment(System.Int32,Autodesk.Revit.DB.ElementId,System.Double,System.Double,System.Int32,System.Boolean,System.Boolean)`

#### Summary

Add a constraint that helps determine the length of a segment.

#### Remarks

The vector defined by (constraintDirCoordX, constraintDirCoordY) must have a positive dot product with the desired direction of the segment. This restriction, combined with the value of signOfZCoordOfCrossProductOfConstraintDirBySegmentDir, defines a quadrant of the plane that limits the variable-angle segment.

#### Parameter `iSegment`

Index of the segment (0 to NumberOfSegments - 1).

#### Parameter `paramId`

Id of a parameter to drive the constraint.
To obtain the id of a shared parameter,
call RebarShape.GetElementIdForExternalDefinition().

#### Parameter `constraintDirCoordX`

The x-coordinate of a 2D vector specifying the constraint direction.

#### Parameter `constraintDirCoordY`

The y-coordinate of a 2D vector specifying the constraint direction.

#### Parameter `signOfZCoordOfCrossProductOfConstraintDirBySegmentDir`

Legal values are 1 and -1. For a fixed-direction segment, this value is ignored. For a variable-direction segment, this value is combined with the constraint length (the nonnegative value associated with 'param') to determine the direction of the segment. For example, a segment whose direction vector lies in the upper-right quadrant of the plane, and whose x-axis projected length is A and whose y-axis projected length is B, could be created by calling: AddConstraintToSegment(iSegment, paramA, 1.0, 0.0, 1, ...) AddConstraintToSegment(iSegment, paramB, 0.0, 1.0, -1, ...)

#### Parameter `measureToOutsideOfBend0`

Choose between two possibilities for the first reference of the length dimension. If false, the reference is at the point where the bend begins; equivalently, at the projection of the bend centerpoint onto the segment. If true, the reference is moved outward by a distance equal to the bend radius plus the bar diameter; if the bend is a right angle or greater, this is equivalent to putting the reference at the outer face of the bend.

#### Parameter `measureToOutsideOfBend1`

Choose between two possibilities for the second reference of the length dimension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

iSegment is not between 0 and NumberOfSegments.
-or-
paramId is not the id of a shared parameter in the current document,
or its unit type is not UT_Reinforcement_Length or UT_Angle.
-or-
The length of the vector (constraintDirCoordX, constraintDirCoordY) is too close to zero.
-or-
signOfZCoordOfCrossProductOfConstraintDirBySegmentDir is neither -1 nor 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddConstraintParallelToSegment(System.Int32,Autodesk.Revit.DB.ElementId,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.AddConstraintParallelToSegment(System.Int32,Autodesk.Revit.DB.ElementId,System.Boolean,System.Boolean)`

#### Summary

Constrain the length of a segment by parameterizing its length.

#### Parameter `iSegment`

Index of the segment (0 to NumberOfSegments - 1).

#### Parameter `paramId`

Id of a parameter to drive the constraint. To obtain the id of a shared parameter,
call RebarShape.GetElementIdForExternalDefinition().

#### Parameter `measureToOutsideOfBend0`

Choose between two possibilities for the first reference of the length dimension. If false, the reference is at the point where the bend begins; equivalently, at the projection of the bend centerpoint onto the segment. If true, the reference is moved outward by a distance equal to the bend radius plus the bar diameter; if the bend is a right angle or greater, this is equivalent to putting the reference at the outer face of the bend.

#### Parameter `measureToOutsideOfBend1`

Choose between two possibilities for the second reference of the length dimension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

iSegment is not between 0 and NumberOfSegments.
-or-
paramId is not the id of a shared parameter in the current document,
or its unit type is not UT_Reinforcement_Length or UT_Angle.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.SetSegmentVariableDirection(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.SetSegmentVariableDirection(System.Int32)`

#### Summary

Remove the fixed direction from a segment.

#### Remarks

The segment's angle will be allowed to vary, with a range of 90 degrees. The segment must have at least two constraints.

#### Parameter `iSegment`

Index of the segment (0 to NumberOfSegments - 1).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

iSegment is not between 0 and NumberOfSegments.

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.SetSegmentFixedDirection(System.Int32,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.SetSegmentFixedDirection(System.Int32,System.Double,System.Double)`

#### Summary

Fix the direction of a segment.

#### Remarks

The centerline of the segment will be constrained to be parallel to the vector. The segment must have at least one constraint.

#### Parameter `iSegment`

Index of the segment (0 to NumberOfSegments - 1).

#### Parameter `vecCoordX`

The x-coordinate of a 2D vector specifying the segment direction.

#### Parameter `vecCoordY`

The y-coordinate of a 2D vector specifying the segment direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

iSegment is not between 0 and NumberOfSegments.
-or-
The length of the vector (vecCoordX, vecCoordY) is too close to zero.

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.GetVertex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.GetVertex(System.Int32)`

#### Summary

Return a reference to one of the vertices in the definition.

#### Parameter `vertexIndex`

Index of the vertex (0 to NumberOfVertices - 1).

#### Returns

The requested vertex.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

vertexIndex is not between 0 and NumberOfVertices.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.GetSegment(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.GetSegment(System.Int32)`

#### Summary

Return a reference to one of the segments in the definition.

#### Parameter `segmentIndex`

Index of the segment (0 to NumberOfSegments - 1).

#### Returns

The requested segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

segmentIndex is not between 0 and NumberOfSegments.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.MajorSegmentIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.MajorSegmentIndex`

#### Summary

Index of a segment that can be considered the most important. Revit
attempts to preserve the orientation of this segment when a Rebar instance
changes its RebarShape to one with a different number of segments.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: majorSegmentIndex is not between 0 and NumberOfSegments.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.NumberOfVertices`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.NumberOfVertices`

#### Summary

The number of vertices in this shape, always equal to NumberOfSegments + 1.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.NumberOfSegments`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.NumberOfSegments`

#### Summary

The number of straight segments in this shape.

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.#ctor(Autodesk.Revit.DB.Document,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments.#ctor(Autodesk.Revit.DB.Document,System.Int32)`

#### Summary

Create a rebar shape definition with a given number of segments.

#### Parameter `doc`

A document. The definition object is not a part of the document,
but it will contain references to parameters that are in a document.
The definition can be used for RebarShape creation only in the
specified document.

#### Parameter `numberOfSegments`

The number of segments in the definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

numberOfSegments must be at least 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments`

#### Summary

Definition of a shape in terms of one or more straight segments of rebar,
with arc bends between the segments.

#### Remarks

The segments are represented by RebarShapeSegment objects.
The segments are numbered starting with 0, and they have a direction;
so the beginning of the shape is end 0 of segment 0, and the end of the
shape is end 1 of segment (NumberOfSegments-1).

The ends and junctions are represented by RebarShapeVertex objects.
The number of vertices is always one greater than the number of segments.
The first vertex represents the start of the shape; the last
vertex represents the end of the shape; and the intermediate
vertices represent the bends between segments.

### `T:Autodesk.Revit.DB.Structure.RebarShapeVertexTurn`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeVertexTurn`

#### Summary

Specify whether a bend at a RebarShapeVertex represents a left or right turn.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.Structure.RebarShapeVertexTurn.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeVertexTurn.Default`

#### Summary

The turn value has not yet been set, or will not be used.

### `F:Autodesk.Revit.DB.Structure.RebarShapeVertexTurn.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeVertexTurn.Right`

#### Summary

A right turn.

### `F:Autodesk.Revit.DB.Structure.RebarShapeVertexTurn.Left`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeVertexTurn.Left`

#### Summary

A left turn.

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.AddConstraintChordLength(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.AddConstraintChordLength(Autodesk.Revit.DB.ElementId)`

#### Summary

Specify a parameter to drive the chord length (the straight-line distance between the endpoints of the arc).

#### Remarks

The chord length is measured on the centerline of the bar.

#### Parameter `paramId`

Id of a parameter to drive the constraint.
To obtain the id of a shared parameter,
call RebarShape.GetElementIdForExternalDefinition().

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.AddConstraintSagittaLength(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.AddConstraintSagittaLength(Autodesk.Revit.DB.ElementId)`

#### Summary

Specify a parameter to drive the sagittal
length (the height of the circular segment, measured
perpendicular to the chord).

#### Remarks

The sagitta will be measured on the centerline of the bar.

#### Parameter `paramId`

Id of a parameter to drive the constraint.
To obtain the id of a shared parameter,
call RebarShape.GetElementIdForExternalDefinition().

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.AddConstraintCircumference(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.AddConstraintCircumference(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

#### Summary

Specify a parameter to drive the circumference of the shape.

#### Parameter `paramId`

Id of a parameter to drive the constraint.
To obtain the id of a shared parameter,
call RebarShape.GetElementIdForExternalDefinition().

#### Parameter `arcRefType`

Specify along which circle the circumference is measured--to the interior
of the bar, the centerline, or the exterior.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.AddConstraintDiameter(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.AddConstraintDiameter(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

#### Summary

Specify a parameter to drive the diameter of the shape.

#### Parameter `paramId`

Id of a parameter to drive the constraint.
To obtain the id of a shared parameter,
call RebarShape.GetElementIdForExternalDefinition().

#### Parameter `arcRefType`

Specify how the diameter should be measured--to the interior of the bend, the centerline of the bar, or the exterior.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.AddConstraintRadius(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.AddConstraintRadius(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

#### Summary

Specify a parameter to drive the radius of the shape.

#### Parameter `paramId`

Id of a parameter to drive the constraint.
To obtain the id of a shared parameter,
call RebarShape.GetElementIdForExternalDefinition().

#### Parameter `arcRefType`

Specify how the radius should be measured--to the interior of the bend, the centerline of the bar, or the exterior.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.AddConstraintArcLength(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.AddConstraintArcLength(Autodesk.Revit.DB.ElementId)`

#### Summary

Specify a parameter to drive the arc length of the shape.

#### Parameter `paramId`

Id of a parameter to drive the constraint.
To obtain the id of a shared parameter,
call RebarShape.GetElementIdForExternalDefinition().

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.SetArcTypeSpiral(System.Double,System.Double,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.SetArcTypeSpiral(System.Double,System.Double,System.Int32,System.Int32)`

#### Summary

Set the RebarShapeDefinitionByArc.Type property to Spiral.

#### Remarks

In order to create a spiral definition, you must provide default values for
height, pitch, and finishing turns.

#### Parameter `height`

The height of the spiral (assuming the spiral is vertical).

#### Parameter `pitch`

The pitch, or vertical distance traveled in one rotation.

#### Parameter `baseFinishingTurns`

The number of finishing turns at the lower end of the spiral.

#### Parameter `topFinishingTurns`

The number of finishing turns at the upper end of the spiral.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

baseFinishingTurns is not between 0 and 100.
-or-
topFinishingTurns is not between 0 and 100.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for height must be greater than 0 and no more than 30000 feet.
-or-
The given value for pitch must be greater than 0 and no more than 30000 feet.

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.SetConstraints(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.RebarShapeConstraint})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.SetConstraints(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.RebarShapeConstraint})`

#### Summary

Assign a new list of constraints to this definition.

#### Remarks

Any existing constraints are discarded. The new constraints replace them.
Any parameters driving the constraints must already be added
with AddParameter().

If the Type is Arc or LappedCircle, the allowable constraint types are:
RebarShapeConstraintArcLengthRebarShapeConstraintRadiusRebarShapeConstraintDiameterRebarShapeConstraintCircumferenceRebarShapeConstraintSagittaLengthRebarShapeConstraintChordLength
At least two independent constraints must be specified. Overconstraining
is supported.

If the Type is Spiral, the allowable constraints are:
RebarShapeConstraintRadiusRebarShapeConstraintDiameterRebarShapeConstraintCircumference
At least one constraint must be specified.

#### Parameter `constraints`

A new list of constraints.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more of the constraints is of a type not supported for this definition.
-or-
One or more of the constraints refers to a parameter that has not been added yet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.GetConstraints`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.GetConstraints`

#### Summary

Retrieve the list of constraints associated with this definition.

#### Returns

The list of constraints.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.Type`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.Type`

#### Summary

Among those rebar shapes defined by an arc, specify which kind.

#### Remarks

This property may be explicitly set to Arc or LappedCircle.
But to set the property to Spiral, you must call SetArcTypeSpiral()
and provide default values for the height, pitch, and finishing turns.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The arc type cannot be set directly
to Spiral. Instead, call SetArcTypeSpiral() to provide defaults
for spiral parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.#ctor(Autodesk.Revit.DB.Document,System.Double,System.Double,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.#ctor(Autodesk.Revit.DB.Document,System.Double,System.Double,System.Int32,System.Int32)`

#### Summary

Create a spiral shape definition.

#### Remarks

In order to create a spiral definition, you must provide default values for the spiral-specific parameters.
Replaces RebarShape.NewDefinitionByArc() from prior versions.

#### Parameter `height`

The height of the spiral (assuming the spiral is vertical).

#### Parameter `pitch`

The pitch, or vertical distance traveled in one rotation.

#### Parameter `baseFinishingTurns`

The number of finishing turns at the lower end of the spiral.

#### Parameter `topFinishingTurns`

The number of finishing turns at the upper end of the spiral.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

baseFinishingTurns is not between 0 and 100.
-or-
topFinishingTurns is not between 0 and 100.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for height must be greater than 0 and no more than 30000 feet.
-or-
The given value for pitch must be greater than 0 and no more than 30000 feet.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArcType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArcType)`

#### Summary

Create a non-spiral shape definition.

#### Remarks

Replaces RebarShape.NewDefinitionByArc() from prior versions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The arc type cannot be set directly
to Spiral. Instead, call SetArcTypeSpiral() to provide defaults
for spiral parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc`

#### Summary

Definition of a shape whose size and position can determined by a single arc.

#### Remarks

In this shape definition, all dimensions are allowed to be driving dimensions.

#### Since

2009

### `T:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArcType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArcType`

#### Summary

A RebarShapeDefinitionByArc takes one of three forms.

### `F:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArcType.Spiral`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArcType.Spiral`

#### Summary

A helical bar. The extent of the helix is determined
by the Rebar properties Height and Pitch.

### `F:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArcType.LappedCircle`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArcType.LappedCircle`

#### Summary

A full circle, subtending an angle more
than 360 degrees and less than 720 degrees. The
behavior in Revit is the same as Arc, but an extra
complete circle is included in the rebar.

### `F:Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArcType.Arc`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArcType.Arc`

#### Summary

An arc, subtending an angle less than 360 degrees.

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraintSagittaLength.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintSagittaLength.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Create a constraint to drive sagitta length.

#### Parameter `paramId`

The Id of a Rebar Shape parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraintSagittaLength`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintSagittaLength`

#### Summary

A constraint that can be applied to a RebarShapeDefinitionByArc
and drives the height of the arc.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeConstraintRadius.ArcReferenceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintRadius.ArcReferenceType`

#### Summary

The choice of rule for measuring the radius.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraintRadius.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintRadius.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

#### Summary

Create a radius constraint.

#### Parameter `paramId`

The Id of a Rebar Shape parameter.

#### Parameter `refType`

A choice of rule for measuring the radius.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraintRadius`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintRadius`

#### Summary

A radius constraint associated with an arc in a RebarShapeDefinition.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraintProjectedSegmentLength.GetSegmentEndReferenceType(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintProjectedSegmentLength.GetSegmentEndReferenceType(System.Int32)`

#### Summary

Choice of two possibilities for the start and end references of the length constraint.

#### Parameter `index`

Which reference on the constraint. Either 0 or 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

index is not 0 or 1.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeConstraintProjectedSegmentLength.Direction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintProjectedSegmentLength.Direction`

#### Summary

A vector specifying the direction of the constraint. The direction is fixed,
and the shape is always constructed so that the segment
direction has a positive dot product with this vector.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeConstraintProjectedSegmentLength.TripleProductSign`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintProjectedSegmentLength.TripleProductSign`

#### Summary

Sign of the z-coordinate of the cross
product of the Direction property with the segment vector.
TripleProductSign is 1 if the segment direction is to be on the left of
the constraint direction,
or -1 if the segment direction is to be on the right.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraintProjectedSegmentLength.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.UV,System.Int32,Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType,Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintProjectedSegmentLength.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.UV,System.Int32,Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType,Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType)`

#### Summary

Constructs a new instance of a RebarConstraintProjectEdgedLength object using a shape
parameter, direction, and reference types.

#### Parameter `paramId`

The Id of a Rebar Shape parameter.

#### Parameter `direction`

A vector specifying the direction of the constraint. The direction is fixed,
and the shape is always constructed so that the segment's
direction has a positive dot product with this vector.

#### Parameter `tripleProductSign`

Sign of the z-coordinate of the cross
product of the "direction" argument with the segment vector. In other words,
1 if the segment direction is to be on the left of the constraint direction,
or -1 if the segment direction is to be on the right.

#### Parameter `refType0`

Choose between two possibilities for the first reference of the length constraint.

#### Parameter `refType1`

Choose between two possibilities for the second reference of the length constraint.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not a valid Element identifier.
-or-
tripleProductSign is not 1 or -1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

direction has zero length.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraintProjectedSegmentLength`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintProjectedSegmentLength`

#### Summary

A constraint that measures the length of a segment as measured by projecting onto a direction
that is not parallel to the segment.

#### Remarks

The constraint has two references, indexed by 0 and 1, that do not have to
correspond to the start and end of the segment. The constraint also specifies
a direction as a 2D vector, which is not necessarily parallel to the segment,
but must point from the segment's start toward its end.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeConstraintFixedSegmentDir.Direction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintFixedSegmentDir.Direction`

#### Summary

The direction of the RebarShapeSegment in UV-space.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraintFixedSegmentDir.#ctor(Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintFixedSegmentDir.#ctor(Autodesk.Revit.DB.UV)`

#### Summary

Create a fixed segment direction constraint.

#### Parameter `dir`

A fixed direction in UV-space.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

dir has zero length.

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraintFixedSegmentDir`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintFixedSegmentDir`

#### Summary

A constraint that can be applied to a RebarShapeSegment and fixes the
direction of the segment in UV-space.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraintSegmentLength.GetSegmentEndReferenceType(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintSegmentLength.GetSegmentEndReferenceType(System.Int32)`

#### Summary

Choice of two possibilities for the start and end references of the length constraint.

#### Parameter `index`

Which reference on the constraint. Either 0 or 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

index is not 0 or 1.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraintSegmentLength.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType,Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintSegmentLength.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType,Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType)`

#### Summary

Create a segment length constraint.

#### Parameter `paramId`

The Id of a Rebar Shape parameter.

#### Parameter `refType0`

Choose between two possibilities for the first reference of the length constraint.

#### Parameter `refType1`

Choose between two possibilities for the second reference of the length constraint.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraintSegmentLength`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintSegmentLength`

#### Summary

A constraint that controls the length of a segment.

#### Remarks

The constraint has two references, indexed by 0 and 1, that do not have to
correspond to the start and end of the segment.

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType`

#### Summary

A choice of two reference points for one end of a constraint driving the length of
a RebarShapeSegment.

#### Remarks

The RebarShapeSegmentEndReferenceType of a constraint is meaningful only
when the bend is
`F:Autodesk.Revit.DB.Structure.RebarShapeBendAngle.Right` or
`F:Autodesk.Revit.DB.Structure.RebarShapeBendAngle.Obtuse` .
If the bend is
`F:Autodesk.Revit.DB.Structure.RebarShapeBendAngle.Acute` ,
the reference type is ignored.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType.Exterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType.Exterior`

#### Summary

Refers to the farthest point on the arc of the bend. Assuming the
bend is 90 degrees or more, an Exterior constraint will be longer than a
Straight constraint by an amount equal to the bend radius.

### `F:Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType.Straight`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType.Straight`

#### Summary

Refers to the end of the straight part of the segment: the point where
the bend begins.

### `P:Autodesk.Revit.DB.Structure.RebarShapeConstraintDiameter.ArcReferenceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintDiameter.ArcReferenceType`

#### Summary

The choice of rule for measuring the diameter.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraintDiameter.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintDiameter.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

#### Summary

Create a diameter constraint.

#### Parameter `paramId`

The Id of a Rebar Shape parameter.

#### Parameter `refType`

A choice of rule for measuring the diameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraintDiameter`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintDiameter`

#### Summary

A diameter constraint associated with an arc in a RebarShapeDefinition.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeConstraintCircumference.ArcReferenceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintCircumference.ArcReferenceType`

#### Summary

The choice of rule for measuring the diameter.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraintCircumference.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintCircumference.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

#### Summary

Create a circumference constraint.

#### Parameter `paramId`

The Id of a Rebar Shape parameter.

#### Parameter `refType`

A choice of rule for measuring the circumference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraintCircumference`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintCircumference`

#### Summary

A circumference constraint associated with an arc in a RebarShapeDefinition.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraintChordLength.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintChordLength.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Create a constraint to drive chord length.

#### Parameter `paramId`

The Id of a Rebar Shape parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraintChordLength`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintChordLength`

#### Summary

A constraint that can be applied to a RebarShapeDefinitionByArc
and drives the straight distance between the arc endpoints.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraintArcLength.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintArcLength.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Create an arc-length constraint.

#### Parameter `paramId`

The Id of a Rebar Shape parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraintArcLength`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintArcLength`

#### Summary

An arc-length constraint associated with an arc in a RebarShapeDefinition.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeConstraintAngleFromFixedDir.Direction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintAngleFromFixedDir.Direction`

#### Summary

A fixed direction in UV-space. The parameter will drive
the segment's angle relative to this direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: direction has zero length.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeConstraintAngleFromFixedDir.Sign`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintAngleFromFixedDir.Sign`

#### Summary

When the sign is 1, the Direction is rotated clockwise by the angle's value.
When -1, the Direction is rotated counter-clockwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: sign is not 1 or -1.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraintAngleFromFixedDir.#ctor(Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintAngleFromFixedDir.#ctor(Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.UV)`

#### Summary

Create an angular constraint.

#### Parameter `paramId`

A Rebar Shape parameter of type UT_Angle.

#### Parameter `sign`

The sign of the angle relative to the direction.

#### Parameter `direction`

A fixed direction in UV-space.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

sign is not 1 or -1.
-or-
paramId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

direction has zero length.

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraintAngleFromFixedDir`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraintAngleFromFixedDir`

#### Summary

A constraint which can be applied to a RebarShapeSegment and drives the angle
of the segment relative to a fixed direction in UV-space.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeDefaultBend.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeDefaultBend.#ctor`

#### Summary

Create a 180-degree bend constraint.

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeDefaultBend`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeDefaultBend`

#### Summary

A constraint which can be applied to a RebarShapeSegment, and causes the segment
to be replaced with a 180-degree arc. The arc's radius is not specified
by the shape; instead it is a "default bend radius," taken from
the RebarBarType associated with the Rebar instance.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeBendRadius.ArcReferenceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeBendRadius.ArcReferenceType`

#### Summary

A choice of rule for measuring the radius.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeBendRadius.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeBendRadius.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType)`

#### Summary

Create a 180-degree bend constraint driven by radius.

#### Parameter `paramId`

The Id of a Rebar Shape parameter.

#### Parameter `refType`

A choice of rule for measuring the radius.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeBendRadius`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeBendRadius`

#### Summary

A constraint which can be applied to a RebarShapeSegment, and causes the segment
to be replaced with a 180-degree arc. The associated parameter drives
the radius of the arc.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeBendArcLength.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeBendArcLength.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Create a 180-degree bend constraint driven by arc length.

#### Parameter `paramId`

The Id of a Rebar Shape parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

paramId is not a valid Element identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeBendArcLength`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeBendArcLength`

#### Summary

A constraint which can be applied to a RebarShapeSegment, and causes the segment
to be replaced with a 180-degree arc. The associated parameter drives
the arc length.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarShapeConstraint.GetParamId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraint.GetParamId`

#### Summary

Return the Id of the parameter associated with this constraint.

#### Remarks

Most subclasses of RebarShapeConstraint require a parameter.

#### Returns

The Id of the parameter, or InvalidElementId if the constraint
does not have one.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarShapeConstraint.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraint.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarShapeConstraint`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeConstraint`

#### Summary

A dimension or other constraint that takes part in a RebarShapeDefinition.

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarShapeBendAngle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeBendAngle`

#### Summary

A bend in a rebar shape has an angular range
specified by one of these values. The angles refer to
the angle swept out by one segment as it is bent
relative to another. That is, an "Obtuse" bend results
in two segments that meet at an angle that is less
than 90 degrees when measured internally. Put another
way, to create an equilateral triangle, you would need
two "Obtuse" bends.

### `F:Autodesk.Revit.DB.Structure.RebarShapeBendAngle.Obtuse`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeBendAngle.Obtuse`

#### Summary

The angle is between 90 and 180 degrees.

### `F:Autodesk.Revit.DB.Structure.RebarShapeBendAngle.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeBendAngle.Right`

#### Summary

The angle is 90 degrees.

### `F:Autodesk.Revit.DB.Structure.RebarShapeBendAngle.Acute`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeBendAngle.Acute`

#### Summary

The angle is less than 90 degrees.

### `T:Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType`

#### Summary

A Rebar Shape Definition constraint that is
measured to a bend must take the bar diameter into
account by specifying whether it measures to
the exterior, centerline, or interior of the bend.

### `F:Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType.External`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType.External`

#### Summary

Measure to the exterior of the bend.

### `F:Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType.Internal`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType.Internal`

#### Summary

Measure to the interior of the bend.

### `F:Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType.Centerline`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType.Centerline`

#### Summary

Measure to the centerline of the bar.

### `M:Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.SetPresenceOfSegments(System.Boolean,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.SetPresenceOfSegments(System.Boolean,System.Boolean,System.Boolean)`

#### Summary

Simultaneously set the presence of all 3D segments.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The shape is disconnected or forms a complete loop:
If the duplicate shape is present, exactly one of the connectors must be present.

### `P:Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.DepthParamId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.DepthParamId`

#### Summary

Id of the parameter driving the multiplanar depth.
The depth is measured center-to-center of the bar.
A valid shape parameter must be assigned to DepthParamId before
the MultiplanarDefinition can be used in RebarShape creation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.OutOfPlaneBendDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.OutOfPlaneBendDiameter`

#### Summary

Bend diameter to be applied to the connector segments.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for outOfPlaneBendDiameter must be greater than 0 and no more than 30000 feet.

### `P:Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.IsEndConnectorPresent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.IsEndConnectorPresent`

#### Summary

Whether a perpendicular segment is constructed
from the end of the 2D shape.

### `P:Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.IsStartConnectorPresent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.IsStartConnectorPresent`

#### Summary

Whether a perpendicular segment is constructed
from the start of the 2D shape.

### `P:Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.IsDuplicateShapePresent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.IsDuplicateShapePresent`

#### Summary

Whether the shape definition includes an offset
copy of the 2D shape.

### `M:Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.#ctor(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition.#ctor(System.Double)`

#### Summary

Create a RebarShapeMultiplanarDefinition for use in creating a RebarShape.

#### Parameter `outOfPlaneBendDiameter`

Bend diameter to be used when the rebar bends out of its main plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for outOfPlaneBendDiameter must be greater than 0 and no more than 30000 feet.

### `T:Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition`

#### Summary

A specification for a simple 3D rebar shape.

#### Remarks

Simple 3D rebar shapes are supported by adding segments to a regular 2D shape definition.
The added segments consist of three optional parts: a "duplicate shape" and two connectors.
A "duplicate shape" is a second copy of the 2D shape, offset in a perpendicular direction,
and connected at either the start or the end by a perpendicular connector segment. Also
supported is adding one or both connector segments, without the duplicate shape.
Fillets are applied to the connector segments with a diameter that is given by
the OutOfPlaneBendDiameter property. The length of the connectors is given by the
Rebar instance parameter "multiplanar depth." The MultiplanarDepth property of this
class is the default value of the parameter.

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinition.CheckDefaultParameterValues(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition.CheckDefaultParameterValues(System.Double,System.Double)`

#### Summary

Check that the shape can be solved with the default parameter values.

#### Remarks

This function runs the rebar solver with the
default parameter values. If it fails (returns false), rebar instances
of this shape will not work. This may be from the
default parameters being inconsistent, or from some
error in the shape definition. The solver requires a
specific bend radius and bar diameter, and the result
depends on these values, but in practice they usually
do not affect the result of this function as long as
they are small. It is legal to pass 0.0 for both
arguments. The definition must be Complete in order
for this function to succeed.

#### Parameter `bendRadius`

A value for the Bend Radius parameter. Zero is allowed.

#### Parameter `barDiameter`

A value for the Bar Diameter parameter. Zero is allowed.

#### Returns

True if the rebar can be solved with the
default parameter values and the given bend radius and
bar diameter; false if it cannot.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinition.RemoveParameter(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition.RemoveParameter(Autodesk.Revit.DB.ElementId)`

#### Summary

Remove the parameter from the definition.

#### Remarks

If the definition does not have the parameter, the method does nothing.

#### Parameter `paramId`

Id of a parameter in the definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinition.SetParameterFormula(Autodesk.Revit.DB.ElementId,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition.SetParameterFormula(Autodesk.Revit.DB.ElementId,System.String)`

#### Summary

Associate a formula with the parameter.

#### Parameter `paramId`

Id of a parameter in the definition.

#### Parameter `formula`

The formula expressed as a string. The string is exactly what a user would
type into the Family Types dialog, e.g. "Total Length*3.14159*(Bar Diameter/2)*(Bar Diameter/2)"

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This RebarShapeDefinition does not have a value for the parameter paramId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinition.SetParameterDefaultValue(Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition.SetParameterDefaultValue(Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Change the parameter's value as stored in the definition.

#### Parameter `paramId`

Id of a parameter in the definition.

#### Parameter `value`

New value for the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This RebarShapeDefinition does not have a value for the parameter paramId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinition.GetParameterFormula(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition.GetParameterFormula(Autodesk.Revit.DB.ElementId)`

#### Summary

Return the parameter's formula, if one is associated with it.

#### Parameter `paramId`

Id of a parameter in the definition.

#### Returns

The formula, or an empty string if there is no formula for the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This RebarShapeDefinition does not have a value for the parameter paramId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarShapeDefinition.GetParameterDefaultValue(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarShapeDefinition.GetParameterDefaultValue(Autodesk.Revit.DB.ElementId)`

#### Summary

Return the parameter's default value as stored in the definition.

#### Parameter `paramId`

Id of a parameter in the definition.

#### Returns

The parameter value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This RebarShapeDefinition does not have a value for the parameter paramId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009
