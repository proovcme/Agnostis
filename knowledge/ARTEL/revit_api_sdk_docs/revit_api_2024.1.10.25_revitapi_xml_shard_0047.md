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
Shard: 47
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.ExportFontTable.GetFontTableIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTable.GetFontTableIterator`

#### Summary

Returns a FontTableIterator that iterates through the collection.

#### Returns

A FontTableIterator object that can be used to iterate through key-value pairs in the collection.

### `M:Autodesk.Revit.DB.ExportFontTable.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTable.#ctor`

#### Summary

Constructs a new ExportFontTable with default values.

#### Since

2014

### `T:Autodesk.Revit.DB.ExportFontTable`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportFontTable`

#### Summary

A table supporting a mapping of Revit font names to font names that will be set
in the target export format.

#### Remarks

This table is structured as a mapping from `T:Autodesk.Revit.DB.ExportFontKey` to
`T:Autodesk.Revit.DB.ExportFontInfo` members. The `T:Autodesk.Revit.DB.ExportFontKey`
contains the identification information for the font table: the Revit font name. The
`T:Autodesk.Revit.DB.ExportFontInfo` contains the font name to use in the export format.

The table can be accessed via direct iteration as a collection of KeyValuePairs, or by traversal of the stored keys
obtained from GetKeys(), or via specific lookup of a key constructed externally. In all cases, the
`T:Autodesk.Revit.DB.ExportFontInfo` returned will be a copy of the `T:Autodesk.Revit.DB.ExportFontInfo`
from the table. In order to make changes to the `T:Autodesk.Revit.DB.ExportFontInfo` and use those settings during export,
set the modified `T:Autodesk.Revit.DB.ExportFontInfo` back into the table using the same key.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportFontTableIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportFontTableIterator.CurrentObject`

### `P:Autodesk.Revit.DB.ExportFontTableIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportFontTableIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.ExportFontTableIterator.GetValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTableIterator.GetValue`

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontTableIterator.GetKey`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTableIterator.GetKey`

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontTableIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTableIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontTableIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTableIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontTableIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontTableIterator.MoveNext`

#### Summary

Increments the iterator to the next item.

#### Returns

True if there is a next available item in this iterator.
False if the iterator has completed all available items.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportFontTableIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportFontTableIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ExportFontTableIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportFontTableIterator`

#### Summary

An iterator to a set of font table.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportFontInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportFontInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportFontInfo.DestinationFontName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportFontInfo.DestinationFontName`

#### Summary

The destination font name (the name of the font in the exported format).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontInfo.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontInfo.#ctor(System.String)`

#### Summary

Constructs a new ExportFontInfo using the destination font name as input.

#### Parameter `destinationFontName`

The destination font name (the name of the font in the exported format).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontInfo.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontInfo.#ctor`

#### Summary

Constructs a new default ExportFontInfo.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontInfo.#ctor(Autodesk.Revit.DB.ExportFontInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontInfo.#ctor(Autodesk.Revit.DB.ExportFontInfo)`

#### Summary

Constructs a new copy of the input ExportFontInfo object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.ExportFontInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportFontInfo`

#### Summary

A value used to represent the info stored in an `T:Autodesk.Revit.DB.ExportFontTable` .

#### Since

2014

### `P:Autodesk.Revit.DB.ExportFontKey.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportFontKey.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportFontKey.OriginalFontName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportFontKey.OriginalFontName`

#### Summary

The original font name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontKey.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontKey.#ctor(System.String)`

#### Summary

Constructs a new ExportFontKey using an input font name.

#### Parameter `originalFontName`

The original font name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontKey.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontKey.#ctor`

#### Summary

Constructs a new default ExportFontKey.

#### Since

2014

### `M:Autodesk.Revit.DB.ExportFontKey.#ctor(Autodesk.Revit.DB.ExportFontKey)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportFontKey.#ctor(Autodesk.Revit.DB.ExportFontKey)`

#### Summary

Constructs a new copy of the input ExportFontKey object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.ExportFontKey`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportFontKey`

#### Summary

A key used to represent an item stored in an `T:Autodesk.Revit.DB.ExportFontTable` .

#### Since

2014

### `M:Autodesk.Revit.DB.ExportDWGSettings.GetActivePredefinedSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDWGSettings.GetActivePredefinedSettings(Autodesk.Revit.DB.Document)`

#### Summary

Returns the active pre-defined non-in-session exporting settings for DWG in the given document.

#### Parameter `aDoc`

A Revit document to retrieve the active pre-defined exporting settings for DWG.

#### Returns

The active pre-defined exporting settings for DWG, or null if nothing pre-defined exists or the in-session settings is selected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.ExportDWGSettings.ListNames(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDWGSettings.ListNames(Autodesk.Revit.DB.Document)`

#### Summary

Returns a list of names of dwg/dxf export settings.

#### Parameter `aDoc`

A Revit document to retrieve names from.

#### Returns

An array of strings representing names of predefined setups.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ExportDWGSettings.FindByName(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDWGSettings.FindByName(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Returns the pre-defined non-in-session exporting settings for DWG in the given document with the specified name.

#### Parameter `aDoc`

A Revit document to retrieve the specified pre-defined exporting settings for DWG.

#### Parameter `name`

The name of the settings to retrieve.

#### Returns

The pre-defined DWG exporting settings, or null if nothing found that has the corresponding name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.ExportDWGSettings.SetDXFExportOptions(Autodesk.Revit.DB.DXFExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDWGSettings.SetDXFExportOptions(Autodesk.Revit.DB.DXFExportOptions)`

#### Summary

Sets the options stored in these settings.

#### Parameter `options`

The options.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ExportDWGSettings.SetDWGExportOptions(Autodesk.Revit.DB.DWGExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDWGSettings.SetDWGExportOptions(Autodesk.Revit.DB.DWGExportOptions)`

#### Summary

Sets the options stored in these settings.

#### Parameter `options`

The options.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ExportDWGSettings.GetDXFExportOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDWGSettings.GetDXFExportOptions`

#### Summary

Gets the options stored in the these settings.

#### Returns

The options

#### Since

2013

### `M:Autodesk.Revit.DB.ExportDWGSettings.GetDWGExportOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDWGSettings.GetDWGExportOptions`

#### Summary

Gets the options stored in the these settings.

#### Returns

The options.

#### Since

2013

### `M:Autodesk.Revit.DB.ExportDWGSettings.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.DXFExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDWGSettings.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.DXFExportOptions)`

#### Summary

Create a DWG export settings with default values.

#### Parameter `document`

Document where created settings is saved.

#### Parameter `name`

The name specified to this settings.

#### Parameter `options`

Initialize settings by using values in DXFExportOptions.

#### Returns

The new DWG export settings instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

ExistOrEmpty

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ExportDWGSettings.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.DWGExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDWGSettings.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.DWGExportOptions)`

#### Summary

Create a DWG export settings with default values.

#### Parameter `document`

Document where created settings is saved.

#### Parameter `name`

The name specified to this settings.

#### Parameter `options`

Initialize settings by using values in DWGExportOptions.

#### Returns

The new DWG export settings instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

ExistOrEmpty

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ExportDWGSettings.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDWGSettings.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Create a DWG export settings with default values.

#### Parameter `document`

Document where created settings is saved.

#### Parameter `name`

The name specified to this settings.

#### Returns

The new DWG export settings instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

ExistOrEmpty

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.ExportDWGSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportDWGSettings`

#### Summary

This element contains DWG/DXF export settings which are saved in a Revit document.

#### Since

2013

### `M:Autodesk.Revit.DB.DGNExportOptions.GetPredefinedOptions(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DGNExportOptions.GetPredefinedOptions(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Returns an instance DGNExportOptions containing settings from a predefined export setup.

#### Parameter `document`

A Revit project document to retrieve the setup from.

#### Parameter `setup`

The name of a predefined export setup from the specified document.

#### Returns

An instance of predefined DGNExportOptions, or `null` if the name was not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.DGNExportOptions.SetExportLineweightTable(Autodesk.Revit.DB.ExportLineweightTable)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DGNExportOptions.SetExportLineweightTable(Autodesk.Revit.DB.ExportLineweightTable)`

#### Summary

Sets the line weight table to use during export.

#### Parameter `lineweightTable`

The line weight table to be set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.DGNExportOptions.GetExportLineweightTable`

Member kind: method
Symbol: `Autodesk.Revit.DB.DGNExportOptions.GetExportLineweightTable`

#### Summary

Gets a copy of the line weight table.

#### Returns

The line weight table.

#### Since

2014

### `M:Autodesk.Revit.DB.DGNExportOptions.GetPredefinedSetupNames(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DGNExportOptions.GetPredefinedSetupNames(Autodesk.Revit.DB.Document)`

#### Summary

Returns a list of names of predefined setups of DGN export options.

#### Remarks

To get predefined options in the desired format use the static method
getPredefinedOptions defined in DGNExportOptions.

#### Parameter `document`

A Revit document to retrieve names from.

#### Returns

An array of strings representing names of predefined setups.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.DGNExportOptions.FileVersion`

Member kind: property
Symbol: `Autodesk.Revit.DB.DGNExportOptions.FileVersion`

#### Summary

The DGN file version.
Default value of fileVersion is DGNFileFormat.Default.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.DGNExportOptions.WorkingUnits`

Member kind: property
Symbol: `Autodesk.Revit.DB.DGNExportOptions.WorkingUnits`

#### Summary

If true, Main Units will be used. If false, Sub Units will be used.
Default value of WorkingUnits is true.

#### Since

2021.1

### `P:Autodesk.Revit.DB.DGNExportOptions.SeedName`

Member kind: property
Symbol: `Autodesk.Revit.DB.DGNExportOptions.SeedName`

#### Summary

The name of the DGN seed.
Default value of seedName is empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.DGNExportOptions.MergedViews`

Member kind: property
Symbol: `Autodesk.Revit.DB.DGNExportOptions.MergedViews`

#### Summary

Whether to merge all views in one file (via XRefs).
Default value of mergedViews is false.

### `M:Autodesk.Revit.DB.DGNExportOptions.#ctor(Autodesk.Revit.DB.DGNExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DGNExportOptions.#ctor(Autodesk.Revit.DB.DGNExportOptions)`

#### Summary

Constructs a new instance of DGNExportOptions as a copy of the export options.

#### Parameter `option`

The options to be copied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.DGNExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DGNExportOptions.#ctor`

#### Summary

Constructs a new instance of DGNExportOptions with default values of all properties.

### `T:Autodesk.Revit.DB.DGNExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DGNExportOptions`

#### Summary

The export options used by exporting DGN format file.

### `P:Autodesk.Revit.DB.SATExportOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SATExportOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.SATExportOptions.#ctor(Autodesk.Revit.DB.SATExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SATExportOptions.#ctor(Autodesk.Revit.DB.SATExportOptions)`

#### Summary

Constructs a new instance of SATImportOptions as a copy of the export options.

#### Parameter `option`

The options to be copied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.SATExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.SATExportOptions.#ctor`

#### Summary

Constructs a new instance of SATImportOptions with default values of all properties.

### `T:Autodesk.Revit.DB.SATExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.SATExportOptions`

#### Summary

The export options used by exporting SAT format file. So far, there is no option in it.

### `M:Autodesk.Revit.DB.DXFExportOptions.GetPredefinedOptions(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DXFExportOptions.GetPredefinedOptions(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Returns an instance DXFExportOptions containing settings from a predefined export setup.

#### Parameter `document`

A Revit project document to retrieve the setup from.

#### Parameter `setup`

The name of a predefined export setup from the specified document.

#### Returns

An instance of predefined DXFExportOptions, or `null` if the name was not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.DXFExportOptions.#ctor(Autodesk.Revit.DB.DXFExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DXFExportOptions.#ctor(Autodesk.Revit.DB.DXFExportOptions)`

#### Summary

Constructs a new instance of DXFImportOptions as a copy of the export options.

#### Parameter `option`

The options to be copied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.DXFExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DXFExportOptions.#ctor`

#### Summary

Constructs a new instance of DXFImportOptions with default values of all properties.

#### Since

2012

### `T:Autodesk.Revit.DB.DXFExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DXFExportOptions`

#### Summary

The export options used by exporting DXF format file.

#### Since

2012

### `M:Autodesk.Revit.DB.DWGExportOptions.GetPredefinedOptions(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DWGExportOptions.GetPredefinedOptions(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Returns an instance DWGExportOptions containing settings from a predefined export setup.

#### Parameter `document`

A Revit project document to retrieve the setup from.

#### Parameter `setup`

The name of a predefined export setup from the specified document.

#### Returns

An instance of predefined DWGExportOptions, or `null` if the name was not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.DWGExportOptions.MergedViews`

Member kind: property
Symbol: `Autodesk.Revit.DB.DWGExportOptions.MergedViews`

#### Summary

Whether to merge all views in one file (via XRefs).
Default value is false for mergedViews.

### `M:Autodesk.Revit.DB.DWGExportOptions.#ctor(Autodesk.Revit.DB.DWGExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DWGExportOptions.#ctor(Autodesk.Revit.DB.DWGExportOptions)`

#### Summary

Constructs a new instance of DWGExportOptions as a copy of the export options.

#### Parameter `option`

The options to be copied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.DWGExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DWGExportOptions.#ctor`

#### Summary

Constructs a new instance of DWGExportOptions with default values of all properties.

### `T:Autodesk.Revit.DB.DWGExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.DWGExportOptions`

#### Summary

The export options used by exporting DWG format file.

### `P:Autodesk.Revit.DB.ACADExportOptions.HatchBackgroundColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.ACADExportOptions.HatchBackgroundColor`

#### Summary

The color that will be set as hatch backgound color on the exported hatch.
This color will be used only if useHatchBackgroundColor is true.
default value is white

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.ACADExportOptions.UseHatchBackgroundColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.ACADExportOptions.UseHatchBackgroundColor`

#### Summary

Indicates if hatch background color will be used or not.
default value is false.

#### Since

2018

### `P:Autodesk.Revit.DB.ACADExportOptions.FileVersion`

Member kind: property
Symbol: `Autodesk.Revit.DB.ACADExportOptions.FileVersion`

#### Summary

ACADVersion::Default
Default value is ACADVersion.Default.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.ACADExportOptions.NonplotSuffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.ACADExportOptions.NonplotSuffix`

#### Summary

If the MarkNonplotLayers attribute is set to true, all layers with names containing this suffix will be marked as non-plot.
No action will be performed if the suffix is empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.ACADExportOptions.MarkNonplotLayers`

Member kind: property
Symbol: `Autodesk.Revit.DB.ACADExportOptions.MarkNonplotLayers`

#### Summary

If true and the nonplot layer suffix is not empty, all layers whose names contain that suffix will be marked as non-plot.

#### Remarks

A typical use would be to mark as non-plot all layers containing -NPLT.
Default value is false

### `P:Autodesk.Revit.DB.ACADExportOptions.ExportingAreas`

Member kind: property
Symbol: `Autodesk.Revit.DB.ACADExportOptions.ExportingAreas`

#### Summary

True to export area and room geometry, false otherwise.
Default value is false.

### `P:Autodesk.Revit.DB.ACADExportOptions.SharedCoords`

Member kind: property
Symbol: `Autodesk.Revit.DB.ACADExportOptions.SharedCoords`

#### Summary

True to use the shared coordinate system's origin, false to use the project origin.
Default value is false.

### `P:Autodesk.Revit.DB.ACADExportOptions.TargetUnit`

Member kind: property
Symbol: `Autodesk.Revit.DB.ACADExportOptions.TargetUnit`

#### Summary

The target unit type.
Default value is ExportUnit.Default.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.ACADExportOptions.ACAPreference`

Member kind: property
Symbol: `Autodesk.Revit.DB.ACADExportOptions.ACAPreference`

#### Summary

The preferred way to generate geometry of ACA objects.
Default value is ACAObjectPreference.Object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.ACADExportOptions.ExportOfSolids`

Member kind: property
Symbol: `Autodesk.Revit.DB.ACADExportOptions.ExportOfSolids`

#### Summary

The mode used to export solids in 3D views.
Default value is SolidGeometry.Polymesh.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.ACADExportOptions.TextTreatment`

Member kind: property
Symbol: `Autodesk.Revit.DB.ACADExportOptions.TextTreatment`

#### Summary

The text treatment.
Deault value is TextTreatment.Exact.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.ACADExportOptions.LinetypesFileName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ACADExportOptions.LinetypesFileName`

#### Summary

The custom linetype file name (*.lin).
Default value is empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.ACADExportOptions.LineScaling`

Member kind: property
Symbol: `Autodesk.Revit.DB.ACADExportOptions.LineScaling`

#### Summary

The scaling mode for the line type.
Default value is LineScaling.ViewScale.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `T:Autodesk.Revit.DB.ACADExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.ACADExportOptions`

#### Summary

The base class for options used to export DWG and DXF format files.

### `M:Autodesk.Revit.DB.BaseExportOptions.SetExportFontTable(Autodesk.Revit.DB.ExportFontTable)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BaseExportOptions.SetExportFontTable(Autodesk.Revit.DB.ExportFontTable)`

#### Summary

Sets font table to option.

#### Parameter `fontTable`

The font table to be set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.BaseExportOptions.GetExportFontTable`

Member kind: method
Symbol: `Autodesk.Revit.DB.BaseExportOptions.GetExportFontTable`

#### Summary

Gets font table.

#### Since

2013

### `M:Autodesk.Revit.DB.BaseExportOptions.SetExportPatternTable(Autodesk.Revit.DB.ExportPatternTable)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BaseExportOptions.SetExportPatternTable(Autodesk.Revit.DB.ExportPatternTable)`

#### Summary

Sets the pattern table to use during export.

#### Parameter `patternTable`

The pattern table to be set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.BaseExportOptions.GetExportPatternTable`

Member kind: method
Symbol: `Autodesk.Revit.DB.BaseExportOptions.GetExportPatternTable`

#### Summary

Gets a copy of the pattern table.

#### Returns

The pattern table.

#### Since

2014

### `M:Autodesk.Revit.DB.BaseExportOptions.SetExportLinetypeTable(Autodesk.Revit.DB.ExportLinetypeTable)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BaseExportOptions.SetExportLinetypeTable(Autodesk.Revit.DB.ExportLinetypeTable)`

#### Summary

Sets the line type table to use during export.

#### Parameter `linetypeTable`

The line type table to be set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.BaseExportOptions.GetExportLinetypeTable`

Member kind: method
Symbol: `Autodesk.Revit.DB.BaseExportOptions.GetExportLinetypeTable`

#### Summary

Gets a copy of the line type table.

#### Returns

The line type table.

#### Since

2014

### `M:Autodesk.Revit.DB.BaseExportOptions.SetExportLayerTable(Autodesk.Revit.DB.ExportLayerTable)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BaseExportOptions.SetExportLayerTable(Autodesk.Revit.DB.ExportLayerTable)`

#### Summary

Sets layer table back to option

#### Parameter `layerTable`

The layer table to be set

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.BaseExportOptions.GetExportLayerTable`

Member kind: method
Symbol: `Autodesk.Revit.DB.BaseExportOptions.GetExportLayerTable`

#### Summary

Gets the layer table.

#### Returns

The layer table.

#### Since

2014

### `M:Autodesk.Revit.DB.BaseExportOptions.GetPredefinedSetupNames(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BaseExportOptions.GetPredefinedSetupNames(Autodesk.Revit.DB.Document)`

#### Summary

Returns a list of names of predefined setups of export options.

#### Remarks

The predefined setups may be used for export to both DWG and DXF formats.
To get predefined options in the desired format use the static method
getPredefinedOptions defined in DWGExportOptions or DXFExportOptions respectively.

#### Parameter `document`

A Revit document to retrieve names from.

#### Returns

An array of strings representing names of predefined setups.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.BaseExportOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseExportOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.BaseExportOptions.PreserveCoincidentLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseExportOptions.PreserveCoincidentLines`

#### Summary

Whether or not to preserve coincident lines.
Default value is false.

#### Since

2015 Subscription Update

### `P:Autodesk.Revit.DB.BaseExportOptions.HideUnreferenceViewTags`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseExportOptions.HideUnreferenceViewTags`

#### Summary

Whether or not to hide unreference view tags.
Default value is false.

#### Since

2013

### `P:Autodesk.Revit.DB.BaseExportOptions.HideReferencePlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseExportOptions.HideReferencePlane`

#### Summary

Whether or not to hide reference planes.
Default value is false.

#### Since

2013

### `P:Autodesk.Revit.DB.BaseExportOptions.HideScopeBox`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseExportOptions.HideScopeBox`

#### Summary

Whether or not to hide the scope box.
Default value is false.

#### Since

2013

### `P:Autodesk.Revit.DB.BaseExportOptions.Colors`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseExportOptions.Colors`

#### Summary

Export color mode.
Default value is ExportColorMode.IndexColors.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.BaseExportOptions.HatchPatternsFileName`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseExportOptions.HatchPatternsFileName`

#### Summary

Custom hatch patterns (pat) file name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.BaseExportOptions.LayerMapping`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseExportOptions.LayerMapping`

#### Summary

Name of a layer settings standard or filename (with custom layer settings).
Valid standards are: DGNV7 (only for DGN), AIA, CP83, BS1192, and ISO13567.
default value is "" (empty) which means if no value is set,
if no value is set, Revit will use a default value according to the localization.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.BaseExportOptions.PropOverrides`

Member kind: property
Symbol: `Autodesk.Revit.DB.BaseExportOptions.PropOverrides`

#### Summary

How to export overridden object styles.
Default value is PropOverrideMode.ByEntity.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `T:Autodesk.Revit.DB.BaseExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.BaseExportOptions`

#### Summary

The base class for options used to export DWG, DXF and DGN format files.

#### Since

2013

### `T:Autodesk.Revit.DB.DGNFileFormat`

Member kind: type
Symbol: `Autodesk.Revit.DB.DGNFileFormat`

#### Since

2013

#### Summary

An enumerated type listing available Microstation versions into which a file may be exported.

#### Since

2013

### `F:Autodesk.Revit.DB.DGNFileFormat.DGNVersion8`

Member kind: field
Symbol: `Autodesk.Revit.DB.DGNFileFormat.DGNVersion8`

#### Summary

Micorstation V8 file format.

### `F:Autodesk.Revit.DB.DGNFileFormat.DGNVersion7`

Member kind: field
Symbol: `Autodesk.Revit.DB.DGNFileFormat.DGNVersion7`

#### Summary

Micorstation V7 file format.

### `F:Autodesk.Revit.DB.DGNFileFormat.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.DGNFileFormat.Default`

#### Summary

The Autodesk Revit application's default file format.

### `T:Autodesk.Revit.DB.ACADVersion`

Member kind: type
Symbol: `Autodesk.Revit.DB.ACADVersion`

#### Summary

An enumerated type listing available AutoCAD versions, into which a file may be exported.

### `F:Autodesk.Revit.DB.ACADVersion.R2018`

Member kind: field
Symbol: `Autodesk.Revit.DB.ACADVersion.R2018`

#### Summary

AutoCAD 2018 file format.

### `F:Autodesk.Revit.DB.ACADVersion.R2013`

Member kind: field
Symbol: `Autodesk.Revit.DB.ACADVersion.R2013`

#### Summary

AutoCAD 2013 file format.

### `F:Autodesk.Revit.DB.ACADVersion.R2010`

Member kind: field
Symbol: `Autodesk.Revit.DB.ACADVersion.R2010`

#### Summary

AutoCAD 2010 file format.

### `F:Autodesk.Revit.DB.ACADVersion.R2007`

Member kind: field
Symbol: `Autodesk.Revit.DB.ACADVersion.R2007`

#### Summary

AutoCAD 2007 file format.

### `F:Autodesk.Revit.DB.ACADVersion.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.ACADVersion.Default`

#### Summary

The Autodesk Revit application's default export format.

### `T:Autodesk.Revit.DB.ExportColorMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportColorMode`

#### Summary

An enumerated type listing export color mode.

### `F:Autodesk.Revit.DB.ExportColorMode.TrueColorPerView`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportColorMode.TrueColorPerView`

#### Summary

All colors from the Revit project will be exported as 24-bit RGB values as specified in view.

### `F:Autodesk.Revit.DB.ExportColorMode.TrueColor`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportColorMode.TrueColor`

#### Summary

All colors from the Revit project will be exported as 24-bit RGB values as specified in object styles.

### `F:Autodesk.Revit.DB.ExportColorMode.IndexColors`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportColorMode.IndexColors`

#### Summary

All colors from the Revit project will be set to the closest of the 255 AutoCAD Color Index colors.

### `T:Autodesk.Revit.DB.TextTreatment`

Member kind: type
Symbol: `Autodesk.Revit.DB.TextTreatment`

#### Summary

An enumerated type listing possible text treatment modes.

### `F:Autodesk.Revit.DB.TextTreatment.Approximate`

Member kind: field
Symbol: `Autodesk.Revit.DB.TextTreatment.Approximate`

#### Summary

Export texts as approximate visual fidelity. Formatting intelligence will be maintained.

### `F:Autodesk.Revit.DB.TextTreatment.Exact`

Member kind: field
Symbol: `Autodesk.Revit.DB.TextTreatment.Exact`

#### Summary

Export texts as exact visual fidelity. Formatting intelligence will be lost.

### `T:Autodesk.Revit.DB.LineScaling`

Member kind: type
Symbol: `Autodesk.Revit.DB.LineScaling`

#### Summary

An enumerated type listing possible LineType scaling modes.

#### Remarks

Whichever option is chosen, line type definitions are created so a dashed line always begins and ends with a dash.
Using these options does change the default behavior of exported DWGs. Some lines expected to be dashed may appear solid or in a different scale.

### `F:Autodesk.Revit.DB.LineScaling.PaperSpace`

Member kind: field
Symbol: `Autodesk.Revit.DB.LineScaling.PaperSpace`

#### Summary

Paperspace scaling. Specifies the value 1 for both LTSCALE and PSLTSCALE.

### `F:Autodesk.Revit.DB.LineScaling.ModelSpace`

Member kind: field
Symbol: `Autodesk.Revit.DB.LineScaling.ModelSpace`

#### Summary

Modelspace scaling. LTSCALE is set to view scale and PSLTSCALE to 0.

### `F:Autodesk.Revit.DB.LineScaling.ViewScale`

Member kind: field
Symbol: `Autodesk.Revit.DB.LineScaling.ViewScale`

#### Summary

Exporting lines as they were scaled by view scale. This option preserves visual fidelity.

### `T:Autodesk.Revit.DB.PropOverrideMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.PropOverrideMode`

#### Summary

An enumerated type listing ways how overridden object styles get exported.

### `F:Autodesk.Revit.DB.PropOverrideMode.NewLayer`

Member kind: field
Symbol: `Autodesk.Revit.DB.PropOverrideMode.NewLayer`

#### Summary

All properties BYLAYER, New Layers for overrides.
Visual fidelity is preserved and there is by-layer control over all entities,
although number of layers in the exported file might be increased.

### `F:Autodesk.Revit.DB.PropOverrideMode.ByLayer`

Member kind: field
Symbol: `Autodesk.Revit.DB.PropOverrideMode.ByLayer`

#### Summary

All properties BYLAYER, no overrides
Forces all entities to follow visual properties as set by their layer.
Visual fidelity is lost, but this produces the least number of layers
while still providing by-layer control over exported entities.

### `F:Autodesk.Revit.DB.PropOverrideMode.ByEntity`

Member kind: field
Symbol: `Autodesk.Revit.DB.PropOverrideMode.ByEntity`

#### Summary

Category properties BYLAYER, overrides BYENTITY.
Entities generated by a specific category are assigned to a layer
accordingly to the layer settings. To preserve visual fidelity,
overridden attributes result in entity-specific attributes

### `T:Autodesk.Revit.DB.ExportSheetType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportSheetType`

#### Summary

An enumerated type listing possible Sheet type.

### `T:Autodesk.Revit.DB.ExportUnit`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportUnit`

#### Summary

An enumerated type listing possible target units for CAD Export.

### `F:Autodesk.Revit.DB.ExportUnit.Meter`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportUnit.Meter`

#### Summary

Meters as decimal values.

### `F:Autodesk.Revit.DB.ExportUnit.Centimeter`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportUnit.Centimeter`

#### Summary

Centimeters as decimal values.

### `F:Autodesk.Revit.DB.ExportUnit.Millimeter`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportUnit.Millimeter`

#### Summary

Millimeters as decimal values.

### `F:Autodesk.Revit.DB.ExportUnit.Foot`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportUnit.Foot`

#### Summary

Feet and Inches in fractional notation.

### `F:Autodesk.Revit.DB.ExportUnit.Inch`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportUnit.Inch`

#### Summary

Inches in fractional notation.

### `F:Autodesk.Revit.DB.ExportUnit.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportUnit.Default`

#### Summary

Default export unit. Depends on Revit's current units.

### `T:Autodesk.Revit.DB.ACAObjectPreference`

Member kind: type
Symbol: `Autodesk.Revit.DB.ACAObjectPreference`

#### Summary

An enumerated type listing possible ways to generate geometry of an ACA object
Revit object parameters used to generate geometry of the exported ACA object.
Revit object geometry is used to generate geometry of the exported ACA object. That may produce better geometric fidelity in some cases.

### `T:Autodesk.Revit.DB.SolidGeometry`

Member kind: type
Symbol: `Autodesk.Revit.DB.SolidGeometry`

#### Summary

An enumerated type listing possible ways of exporting solids in 3D views.

### `F:Autodesk.Revit.DB.SolidGeometry.ACIS`

Member kind: field
Symbol: `Autodesk.Revit.DB.SolidGeometry.ACIS`

#### Summary

All visible Revit Building geometry is exported as ACIS 3D solids
(except for any elements that are already a polymesh.)

### `F:Autodesk.Revit.DB.SolidGeometry.Polymesh`

Member kind: field
Symbol: `Autodesk.Revit.DB.SolidGeometry.Polymesh`

#### Summary

All visible solids are exported as polymesh.

### `M:Autodesk.Revit.DB.ExportDGNSettings.FindByName(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDGNSettings.FindByName(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Returns the pre-defined non-in-session exporting settings for DGN in the given document with the specified name.

#### Parameter `aDoc`

A Revit document to retrieve the specified pre-defined exporting settings for DGN.

#### Parameter `name`

The name of the settings to retrieve.

#### Returns

The pre-defined DGN exporting settings, or null if nothing found that has the corresponding name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.ExportDGNSettings.GetActivePredefinedSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDGNSettings.GetActivePredefinedSettings(Autodesk.Revit.DB.Document)`

#### Summary

Returns the active pre-defined non-in-session exporting settings for DGN in the given document.

#### Parameter `aDoc`

A Revit document to retrieve the active pre-defined exporting settings for DGN.

#### Returns

The active pre-defined exporting settings for DGN, or null if nothing pre-defined exists or the in-session settings is selected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.ExportDGNSettings.ListNames(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDGNSettings.ListNames(Autodesk.Revit.DB.Document)`

#### Summary

Returns a list of names of dgn export settings.

#### Parameter `aDoc`

A Revit document to retrieve names from

#### Returns

An array of strings representing names of predefined setups.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ExportDGNSettings.SetDGNExportOptions(Autodesk.Revit.DB.DGNExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDGNSettings.SetDGNExportOptions(Autodesk.Revit.DB.DGNExportOptions)`

#### Summary

Sets the options stored in these settings.

#### Parameter `options`

The options.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ExportDGNSettings.GetDGNExportOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDGNSettings.GetDGNExportOptions`

#### Summary

Gets the options stored in the these settings.

#### Returns

The options.

#### Since

2013

### `M:Autodesk.Revit.DB.ExportDGNSettings.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.DGNExportOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDGNSettings.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.DGNExportOptions)`

#### Summary

Create DGN export settings with specified values in DGNExportOptions.

#### Parameter `document`

Document where created settings is saved.

#### Parameter `name`

The name specified to this settings.

#### Parameter `options`

The options which will be stored in these settings.

#### Returns

The new DGN export settings instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

ExistOrEmpty

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ExportDGNSettings.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExportDGNSettings.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Create a DGN export settings with default values.

#### Parameter `document`

Document where created settings is saved.

#### Parameter `name`

The name specified to this settings.

#### Returns

The new DGN export settings instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

ExistOrEmpty

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.ExportDGNSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportDGNSettings`

#### Summary

This element contains DGN export settings which are saved in a Revit document.

#### Since

2013

### `T:Autodesk.Revit.DB.ExternalService.DisparityResponse`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalService.DisparityResponse`

#### Since

2014

#### Summary

An enumerated value to return from OnServerDiparity indicating
what the service wants Revit to do as the post-action of the call.

#### Since

2014

### `F:Autodesk.Revit.DB.ExternalService.DisparityResponse.LetUserDecide`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalService.DisparityResponse.LetUserDecide`

#### Summary

Revit is to prompt the end-user to let him or her decide
whether a default action should be applied or a selection
of servers should be set.

### `F:Autodesk.Revit.DB.ExternalService.DisparityResponse.ApplyDefaults`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalService.DisparityResponse.ApplyDefaults`

#### Summary

Revit is to apply the default algorithm which is to activate
just the servers that are remaining available. It could also
mean that no server will be set at all if the servers previously
used in the document are not currently registered. If such a
situation happens for a mandatory service, then the service's
default server will be set as the new (and only) active server.

### `F:Autodesk.Revit.DB.ExternalService.DisparityResponse.DoNothing`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalService.DisparityResponse.DoNothing`

#### Summary

Revit is instructed to do nothing. It is assumed that the service
already handled what needed to be handled (e.g. it set servers
appropriately to the situation.)

### `T:Autodesk.Revit.DB.ExternalService.ExecutionPolicy`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalService.ExecutionPolicy`

#### Since

2013

#### Summary

Controls how servers of multi-server external services are executed.

#### Since

2013

### `F:Autodesk.Revit.DB.ExternalService.ExecutionPolicy.AllApplicableServers`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalService.ExecutionPolicy.AllApplicableServers`

#### Summary

Under this policy the framework will call to execute a service with all
applicable servers, that is the servers that are currently set as active
and for which the service responds affirmatively to the CanExecute method.
If and only if the service can execute all applicable servers successfully
the execution returns ExternalServiceResult.Succeeded. If execution of
any applicable server fails, the execution loop breaks and the return
value will be ExternalServiceResult.Failed. If no applicable servers
can be found, the return value will be ExternalServiceResult.Unhandled.

### `F:Autodesk.Revit.DB.ExternalService.ExecutionPolicy.FirstApplicableServer`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalService.ExecutionPolicy.FirstApplicableServer`

#### Summary

This policy instructs to find the first applicable server,
which would be the first one that the service claims (by
returning True from the CanExecute method) it can be executed.
With that server the service will be called to execute it.
If the execution fails or if an unhandled exception is raised
from it the result will be ExternalServiceResult.Failed, otherwise
it will be ExternalServiceResult.Succeeded, unless no applicable
server can be found, which would cause returning ExternalServiceResult.Unhandled.

### `T:Autodesk.Revit.DB.ExternalService.ExternalServiceResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalService.ExternalServiceResult`

#### Since

2013

#### Summary

An enumerated value representing a result from executing an external service.

#### Since

2013

### `F:Autodesk.Revit.DB.ExternalService.ExternalServiceResult.Unhandled`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalService.ExternalServiceResult.Unhandled`

#### Summary

Execution of a service has not been handled; possibly because there are no applicable servers.

### `F:Autodesk.Revit.DB.ExternalService.ExternalServiceResult.Failed`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalService.ExternalServiceResult.Failed`

#### Summary

Service execution has failed.

### `F:Autodesk.Revit.DB.ExternalService.ExternalServiceResult.Succeeded`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalService.ExternalServiceResult.Succeeded`

#### Summary

Service has been executed successfully.

### `T:Autodesk.Revit.DB.ExternalService.ServerChangeCause`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalService.ServerChangeCause`

#### Since

2013

#### Summary

Indicates the cause for the active server to be changed

#### Since

2013

### `F:Autodesk.Revit.DB.ExternalService.ServerChangeCause.UserChange`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalService.ServerChangeCause.UserChange`

#### Summary

The change of the active server has been explicitly requested by the end user.

### `F:Autodesk.Revit.DB.ExternalService.ServerChangeCause.ImposedChange`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExternalService.ServerChangeCause.ImposedChange`

#### Summary

The active server is being changed as a result of other operations in Revit.

### `M:Autodesk.Revit.DB.IEntitlementExternalServerProxy.HasCloudModelEntitlement(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IEntitlementExternalServerProxy.HasCloudModelEntitlement(System.Boolean)`

#### Summary

Checks if the current user has Non-workshared Cloud Model entitlement.

#### Parameter `allowThrow`

True to throw exception

#### Returns

Indicates whether the current user has Non-workshared Cloud Model entitlement

#### Since

2019

### `M:Autodesk.Revit.DB.IEntitlementExternalServerProxy.HasWorksharedCloudModelEntitlement(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IEntitlementExternalServerProxy.HasWorksharedCloudModelEntitlement(System.Boolean)`

#### Summary

Checks if the current user has Workshared Cloud Model entitlement.

#### Parameter `allowThrow`

True to throw exception

#### Returns

Indicates whether the current user has Workshared Cloud Model entitlement

#### Since

2019

### `M:Autodesk.Revit.DB.IEntitlementExternalServer.HasCloudModelEntitlement(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IEntitlementExternalServer.HasCloudModelEntitlement(System.Boolean)`

#### Summary

Checks if the current user has Non-workshared Cloud Model entitlement.

#### Parameter `allowThrow`

True to throw exception

#### Returns

Indicates whether the current user has Non-workshared Cloud Model entitlement

#### Since

2019

### `M:Autodesk.Revit.DB.IEntitlementExternalServer.HasWorksharedCloudModelEntitlement(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IEntitlementExternalServer.HasWorksharedCloudModelEntitlement(System.Boolean)`

#### Summary

Checks if the current user has Workshared Cloud Model entitlement.

#### Parameter `allowThrow`

True to throw exception

#### Returns

Indicates whether the current user has Workshared Cloud Model entitlement

#### Since

2019

### `T:Autodesk.Revit.DB.IEntitlementExternalServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.IEntitlementExternalServer`

#### Summary

The interface used to get the entitlement information (Workshared Cloud Model entitlement or Non-workshared Cloud Model entitlement or none).

#### Remarks

Implement this interface and register an instance of the derived class with the EntitlementExternalService.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudModelUIServerProxy.EnsureToEnableCloudWorksharing`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudModelUIServerProxy.EnsureToEnableCloudWorksharing`

#### Summary

Shows a dialog for users to ensure if user really wants to enable cloud worksharing.

#### Returns

Indicates whether the user really wants to enable cloud worksharing.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudModelUIServerProxy.ShowNoWorksharedCloudModelEntitlementWindow`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudModelUIServerProxy.ShowNoWorksharedCloudModelEntitlementWindow`

#### Summary

Shows a dialog saying "You don't have access of Workshared Cloud Model entitlement".

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudModelUIServer.EnsureToEnableCloudWorksharing`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudModelUIServer.EnsureToEnableCloudWorksharing`

#### Summary

Shows a dialog for users to ensure if user really wants to enable cloud worksharing.

#### Returns

Indicates whether the user really wants to enable cloud worksharing.

#### Since

2019

### `M:Autodesk.Revit.DB.ICloudModelUIServer.ShowNoWorksharedCloudModelEntitlementWindow`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICloudModelUIServer.ShowNoWorksharedCloudModelEntitlementWindow`

#### Summary

Shows a dialog saying "You don't have access of Workshared Cloud Model entitlement".

#### Since

2019

### `T:Autodesk.Revit.DB.ICloudModelUIServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.ICloudModelUIServer`

#### Summary

The interface for for CloudModelUIServer.

#### Remarks

Implement this interface and register an instance of the derived class with the EntitlementExternalService.

#### Since

2019

### `M:Autodesk.Revit.DB.ExternalService.IExternalServerProxy.GetDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.IExternalServerProxy.GetDescription`

#### Summary

Implement this method to return a description of the server.

#### Remarks

The purpose of this string is to describe the external server
in more details than just a short name alone could do.
The intended use is to show the string to the end user in UI
when UI is appropriate for the corresponding external service.

Beside the requirement for it to be a non-empty string,
there are no other general restrictions imposed by the External Services Framework.
However, the external service may have some specific rules in place for its servers.

#### Returns

Description of the server.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.IExternalServerProxy.GetVendorId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.IExternalServerProxy.GetVendorId`

#### Summary

Implement this method to return the id of the vendor of the server.

#### Remarks

The Id is expected to be a string consisting of 4 characters.

#### Returns

Vendor Id of the server.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.IExternalServerProxy.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.IExternalServerProxy.GetName`

#### Summary

Implement this method to return the name of the server.

#### Remarks

Although a server is uniquely identified by its Id,
the Name can identify it to the end user in UI when UI
is appropriate for the corresponding external service.

Beside the requirement for the name to be a non-empty string,
there are no other general restrictions imposed by the External Services Framework.
However, the external service may have some specific rules in place for its servers.

#### Returns

Name of the server.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.IExternalServerProxy.GetServiceId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.IExternalServerProxy.GetServiceId`

#### Summary

Implement this method to return the id of the service.

#### Remarks

An external server belongs to only one external service.
This method must return an Id that matches the Id of the corresponding service was registered with.

#### Returns

The id of the service to which the server belongs.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.IExternalServerProxy.GetServerId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.IExternalServerProxy.GetServerId`

#### Summary

Implement this method to return the id of the server.

#### Remarks

The Id must uniquely identify the external server
to the corresponding external service. It will be
an error when two servers with identical Ids try
to register for one external service.

#### Returns

The id of the server.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.IExternalServer.GetDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.IExternalServer.GetDescription`

#### Summary

Implement this method to return a description of the server.

#### Remarks

The purpose of this string is to describe the external server
in more details than just a short name alone could do.
The intended use is to show the string to the end user in UI
when UI is appropriate for the corresponding external service.

Beside the requirement for it to be a non-empty string,
there are no other general restrictions imposed by the External Services Framework.
However, the external service may have some specific rules in place for its servers.

#### Returns

Description of the server.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.IExternalServer.GetVendorId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.IExternalServer.GetVendorId`

#### Summary

Implement this method to return the id of the vendor of the server.

#### Remarks

The Id is expected to be a string consisting of 4 characters.

#### Returns

Vendor Id of the server.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.IExternalServer.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.IExternalServer.GetName`

#### Summary

Implement this method to return the name of the server.

#### Remarks

Although a server is uniquely identified by its Id,
the Name can identify it to the end user in UI when UI
is appropriate for the corresponding external service.

Beside the requirement for the name to be a non-empty string,
there are no other general restrictions imposed by the External Services Framework.
However, the external service may have some specific rules in place for its servers.

#### Returns

Name of the server.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.IExternalServer.GetServiceId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.IExternalServer.GetServiceId`

#### Summary

Implement this method to return the id of the service.

#### Remarks

An external server belongs to only one external service.
This method must return an Id that matches the Id of the corresponding service was registered with.

#### Returns

The id of the service to which the server belongs.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.IExternalServer.GetServerId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.IExternalServer.GetServerId`

#### Summary

Implement this method to return the id of the server.

#### Remarks

The Id must uniquely identify the external server
to the corresponding external service. It will be
an error when two servers with identical Ids try
to register for one external service.

#### Returns

The id of the server.

#### Since

2013

### `T:Autodesk.Revit.DB.ExternalService.IExternalServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalService.IExternalServer`

#### Summary

The base interface for all external servers.

#### Remarks

Every external service in Revit declares a specific interface
for its servers. Each interface must be derived from this IExternalServer.
Providers of external servers implement the server interfaces
defined by the respective external services to which the servers
belong. The whole process of creating a server and registering
it with Revit as a server of a concrete external service can be
outlined in the following steps:
A provider of an external service declares a server interface derived from IExternalServer

The provider of the service will make it known that this interface is for the servers of that service

An application wanting to have a server will implement the appropriate interface

The server's application obtains the service from Revit using the ExternalServiceRegistry.GetService method

An instance of the server class can then be registered with Revit by using the ExternalService.AddServer method

#### Since

2013

### `M:Autodesk.Revit.DB.EntitlementExternalServiceUtils.ValidateUser`

Member kind: method
Symbol: `Autodesk.Revit.DB.EntitlementExternalServiceUtils.ValidateUser`

#### Summary

Validates user is either logged in or appropriate 2 legged context is set.

#### Returns

True if validation succeeds.

#### Since

2019

### `M:Autodesk.Revit.DB.EntitlementExternalServiceUtils.RegisterCloudModelUIServer(Autodesk.Revit.DB.ICloudModelUIServer)`

Member kind: method
Symbol: `Autodesk.Revit.DB.EntitlementExternalServiceUtils.RegisterCloudModelUIServer(Autodesk.Revit.DB.ICloudModelUIServer)`

#### Summary

Registers the application-wide cloud model UI external server.

#### Parameter `server`

The object representing the cloud model UI external server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.EntitlementExternalServiceUtils.RegisterEntitlementExternalServer(Autodesk.Revit.DB.IEntitlementExternalServer)`

Member kind: method
Symbol: `Autodesk.Revit.DB.EntitlementExternalServiceUtils.RegisterEntitlementExternalServer(Autodesk.Revit.DB.IEntitlementExternalServer)`

#### Summary

Registers the application-wide entitlement external server.

#### Parameter `server`

The object representing the entitlement external server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.EntitlementExternalServiceUtils.GetCloudModelUIServer`

Member kind: method
Symbol: `Autodesk.Revit.DB.EntitlementExternalServiceUtils.GetCloudModelUIServer`

#### Summary

Returns the application-wide cloud model UI external server.

#### Returns

The object representing the cloud model UI external server.

#### Since

2019

### `M:Autodesk.Revit.DB.EntitlementExternalServiceUtils.GetEntitlementExternalServer`

Member kind: method
Symbol: `Autodesk.Revit.DB.EntitlementExternalServiceUtils.GetEntitlementExternalServer`

#### Summary

Returns the application-wide entitlement external server.

#### Returns

The object representing the entitlement external server.

#### Since

2019

### `M:Autodesk.Revit.DB.EntitlementExternalServiceUtils.EnsureToEnableCloudWorksharing`

Member kind: method
Symbol: `Autodesk.Revit.DB.EntitlementExternalServiceUtils.EnsureToEnableCloudWorksharing`

#### Summary

Shows a dialog for users to ensure if user really wants to enable cloud worksharing.

#### Returns

Indicates whether the user really wants to enable cloud worksharing.

#### Since

2019

### `P:Autodesk.Revit.DB.EntitlementExternalServiceUtils.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.EntitlementExternalServiceUtils.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.EntitlementExternalServiceUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.EntitlementExternalServiceUtils`

#### Summary

Utility class for EntitlementExternalService.

#### Since

2019

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.SetReportsFolder(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.SetReportsFolder(System.String)`

#### Summary

Sets the reports folder path.

#### Parameter `folderPath`

The string to specify the path. It may include the special label for project name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

A folder path cannot contain special characters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.GetReportsFolderParsed`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.GetReportsFolderParsed`

#### Summary

Gets the absolute reports folder path that is parsed from the original input.

#### Returns

The reports folder path after parsing the input string.

#### Since

2022

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.GetBuildingConstructionSetElementId(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.GetBuildingConstructionSetElementId(Autodesk.Revit.DB.Document)`

#### Summary

Id of the building construction set.

#### Remarks

The building construction set is the default
project construction set used when spaces are not assigned a
construction.

#### Returns

Returns the id of the building construction set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckAnalysisType(Autodesk.Revit.DB.Analysis.AnalysisMode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckAnalysisType(Autodesk.Revit.DB.Analysis.AnalysisMode)`

#### Summary

Checks that the analysis type falls within an appropriate range.

#### Parameter `analysisType`

The analysis type to be checked.

#### Returns

True if the analysis type falls within an appropriate range, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckBuildingEnvelope(Autodesk.Revit.DB.Analysis.gbXMLExportBuildingEnvelope)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckBuildingEnvelope(Autodesk.Revit.DB.Analysis.gbXMLExportBuildingEnvelope)`

#### Summary

Checks that the building envelope determination method falls within an appropriate range.

#### Parameter `determinationMethod`

The building envelope determination method to be checked.

#### Returns

True if the building envelope determination method falls within an appropriate range, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckServiceType(Autodesk.Revit.DB.Analysis.gbXMLServiceType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckServiceType(Autodesk.Revit.DB.Analysis.gbXMLServiceType)`

#### Summary

Checks that the service type falls within an appropriate range.

#### Parameter `serviceType`

The service type to be checked.

#### Returns

True if the service type falls within an appropriate range, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckBuildingType(Autodesk.Revit.DB.Analysis.gbXMLBuildingType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckBuildingType(Autodesk.Revit.DB.Analysis.gbXMLBuildingType)`

#### Summary

Checks that the building type falls within an appropriate range.

#### Parameter `buildingType`

The building type to be checked.

#### Returns

True if the building type falls within an appropriate range, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckBuildingHVACSystem(Autodesk.Revit.DB.Analysis.gbXMLBuildingHVACSystem)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckBuildingHVACSystem(Autodesk.Revit.DB.Analysis.gbXMLBuildingHVACSystem)`

#### Summary

Checks that the building HVAC system falls within an appropriate range.

#### Parameter `buildingHVACSystem`

The building HVAC system to be checked.

#### Returns

True if the building HVAC system falls within an appropriate range, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckBuildingOperatingSchedule(Autodesk.Revit.DB.Analysis.gbXMLBuildingOperatingSchedule)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckBuildingOperatingSchedule(Autodesk.Revit.DB.Analysis.gbXMLBuildingOperatingSchedule)`

#### Summary

Checks that the building operating schedule falls within an appropriate range.

#### Parameter `buildingOperatingSchedule`

The building operating schedule to be checked.

#### Returns

True if the building operating schedule falls within an appropriate range, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckProjectReportType(Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckProjectReportType(Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType)`

#### Summary

Checks that the project report type falls within an appropriate range.

#### Parameter `projectReportType`

The project report type to be checked.

#### Returns

True if the project report type falls within an appropriate range, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckBuildingConstructionClass(Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckBuildingConstructionClass(Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass)`

#### Summary

Checks that the building construction class falls within an appropriate range.

#### Parameter `buildingConstructionClass`

The building construction class to be checked.

#### Returns

True if the building construction class falls within an appropriate range, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckExportComplexity(Autodesk.Revit.DB.Analysis.gbXMLExportComplexity)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckExportComplexity(Autodesk.Revit.DB.Analysis.gbXMLExportComplexity)`

#### Summary

Checks that the export complexity falls within an appropriate range.

#### Parameter `exportComplexity`

The export complexity to be checked.

#### Returns

True if the export complexity falls within an appropriate range, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckProjectPhase(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckProjectPhase(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks that the input element is a project phase.

#### Parameter `projectPhaseId`

The element to be checked.

#### Returns

True if the input element is a project phase, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckGroundPlane(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckGroundPlane(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

The ground plane should be an Element of type Level. This method checks to confirm that an ElementId is for a Level element.

#### Parameter `ccda`

The Document.

#### Parameter `groundPlaneId`

The element id to be checked to confirm that it is suitable to be a ground plane (i.e., that it is a level) or
that it is invalidElementId. Setting ground plane with invalidElementId will lead to the ground plane being "reset".

#### Returns

True if the input element is a level or invalidElementId, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckGroundPlane(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckGroundPlane(Autodesk.Revit.DB.ElementId)`

#### Summary

The ground plane should be an Element of type Level. This method checks to confirm that an ElementId is for a Level element.

#### Parameter `groundPlaneId`

The element id to be checked to confirm that it is suitable to be a ground plane (i.e., that it is a level) or
that it is invalidElementId. Setting ground plane with invalidElementId will lead to the ground plane being "reset".

#### Returns

True if the input element is a level or invalidElementId, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckConstructionSetElement(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckConstructionSetElement(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks that the construction set ElementId is acceptable.

#### Parameter `constructionSetElementId`

The construction set ElementId to be checked.

#### Returns

True if the construction set ElementId is a valid construction set element, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckExportCategory(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckExportCategory(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the export category falls within the list:
OST_Rooms

OST_MEPSpaces

#### Parameter `exportCategoryId`

The export category to be checked.

#### Returns

True if the export category falls within the list, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckRangeOfSkylightWidth(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckRangeOfSkylightWidth(System.Double)`

#### Summary

Checks that the skylight width is greater than or equal to eight inches.

#### Parameter `skylightWidth`

The skylight width to be checked. Should be greater than or equal to eight inches.

#### Returns

True if the skylight width is greater than or equal to eight inches, false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckRangeOfPercentageSkylights(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckRangeOfPercentageSkylights(System.Double)`

#### Summary

Checks that the percentage skylights value is between 0.00 and 0.95.

#### Parameter `percentageSkylights`

The percentage skylights to be checked.

#### Returns

True if the percentage skylights value is between 0.00 and 0.95, false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckRangeOfShadeDepth(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckRangeOfShadeDepth(System.Double)`

#### Summary

Checks that the shade depth is greater than or equal to zero.

#### Parameter `shadeDepth`

The shade depth to be checked.

#### Returns

True if the shade depth is greater than or equal to zero, false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckRangeOfSillHeight(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckRangeOfSillHeight(System.Double)`

#### Summary

Checks that the sill height is greater than or equal to zero.

#### Parameter `sillHeight`

The sill height to be checked.

#### Returns

True if the sill height falls is greater than or equal to zero, false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckRangeOfPercentageGlazing(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckRangeOfPercentageGlazing(System.Double)`

#### Summary

Checks that the percentage glazing value is between 0.00 and 0.95.

#### Parameter `percentageGlazing`

The percentage glazing to be checked.

#### Returns

True if the percentage glazing value is between 0.00 and 0.95, false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckRangeOfSliverSpaceTolerance(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CheckRangeOfSliverSpaceTolerance(System.Double)`

#### Summary

Checks that the sliver space tolerance is greater than or equal to zero.

#### Parameter `silverSpaceTolerance`

The sliver space tolerance to be checked.

#### Returns

Returns true if the sliver space tolerance is greater than or equal to zero, false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.IsDocumentUsingEnergyDataAnalyticalModel(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.IsDocumentUsingEnergyDataAnalyticalModel(Autodesk.Revit.DB.Document)`

#### Summary

Get EnergyDataSettings element and if it exists, return result from getCreateAnalyticalModel.

#### Parameter `ccda`

The document.

#### Returns

Returns true if the Conceptual Energy Analytical Model is enabled, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.EnergyDataSettings.GetFromDocument(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.GetFromDocument(Autodesk.Revit.DB.Document)`

#### Summary

Every project document has a EnergyDataSettings element.
Family documents do not have EnergyDataSettings elements.

#### Parameter `cda`

The document.

#### Returns

Returns the EnergyDataSettings element or NULL.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.DividePerimeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.DividePerimeter`

#### Summary

If this is true, zones with exterior boundaries on each floor of the building will be divided based on geometric criteria.

#### Remarks

When the AnalysisType is ConceptualMasses, the division of the perimeter zones is based on the four compass directions.
The quadrants will be True N, S, E, and W. The division of the quadrants will be along the axis of True NW to SE and True SW to NE.
The intersection of the quadrants will be placed at the centroid of the zone.
When the AnalysisType is not ConceptualMasses, the division of the perimeter zones is based on the difference of orientation, maximum length and depth.
Any exterior surfaces that have an angle of 45 degrees or more between them will be divided into separate zones.
Zones greater than 50 ft. will be divided equally. The CoreOffset will determine the depth of the zones.
The purpose of these divisions is to ensure that auto-generated zoning is appropriate for thermal loads generated by the relative position of the building to the sun path.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.EnergyModel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.EnergyModel`

#### Summary

if this is on there should be an energy model dependent on the current AnalysisType
if it is off the conceptual energy model should be turned off
but setting this datum does not do the work, just reflects the state.

#### Value

true if energy model is on, false otherwise

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.BuildingType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.BuildingType`

#### Summary

The type of building.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The building type does not fall within an appropriate range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CoreOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CoreOffset`

#### Summary

The default offset used to determine the outer perimeter to be divided into zones.

#### Remarks

A Zone can be either a Mass Zone or an Analytical Space depending on whether the AnalysisType is ConceptualMasses or otherwise.
Specifying a value here determines the zone depth and creates a core zone.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for coreOffset must be between 0 and 30000 feet.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.IsExportMullionsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.IsExportMullionsEnabled`

#### Summary

Indicates if mullions are included in GreenBuildingXML export of the detailed model.

#### Remarks

Result is based on the ExportComplexity setting.
When this setting is on, mullions will be exported as shading surfaces. A "simplified" analytical
shading surface is produced from a mullion based on its centerline, thickness, and offset.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.IsExportSimplifiedCurtainSystemsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.IsExportSimplifiedCurtainSystemsEnabled`

#### Summary

Indicates if curtain system geometry is being simplified for GreenBuildingXML export of the detailed model.

#### Remarks

Result is based on the ExportComplexity setting.
Curtain Walls and Curtain Systems are normally exported as multiple openings, panel by panel, while for
energy analysis this can be more simply represented as a single glass surface as large as the entire curtain wall/system.
Normally, a curtain wall with 50 panels would be exported as 50 openings. Often, exporting a single opening with
the total curtain system area is more appropriate. When this setting is on, one "large" window/opening will be
exported for a curtain wall/system.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.IsExportShadingSurfacesEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.IsExportShadingSurfacesEnabled`

#### Summary

Indicates if "shading surfaces" are included in GreenBuildingXML export of the detailed model.

#### Remarks

Result is based on the ExportComplexity setting.
The method described by gbs/gbxml.org to calculate the shading surfaces is to
take all surfaces from the MEP spaces, subtract them from the surfaces from all building elements,
and then the remaining surfaces are considered to be the shading surfaces.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.ReportsFolder`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.ReportsFolder`

#### Summary

The folder path where all systems analysis reports are stored. It may include special label and relative path.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.AnalyticalGridCellSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.AnalyticalGridCellSize`

#### Summary

The cell size for the uniform cubical grid used when computing the building envelope

#### Remarks

This is the size of the "cubes" used to divide the building shell
bounding box into a uniform cubical 3D grid.

#### Since

2015

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.BuildingEnvelopeDeterminationMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.BuildingEnvelopeDeterminationMethod`

#### Summary

Indicates if an analysis should be perform to find the model elements that are part of the building envelope

#### Remarks

The analysis is performed for the detailed GreenBuildingXML export and in heating and cooling load calculations.
This method uses a combination of ray-casting and flood-fill algorithms in order to find the building elements that are
exposed to the outside of the building. Analytical surface originated from the building elements in the envelope
will be classified as exterior or shading surfaces.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The building envelope determination method does not fall within an appropriate range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.IncludeThermalProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.IncludeThermalProperties`

#### Summary

Indicates if thermal information from model assemblies and components is included in GreenBuildingXML export of the detailed model.

#### Remarks

If true, Revit will include model thermal data from assemblies and
components when available, when Export Category is Rooms.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.UseAirChangesPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.UseAirChangesPerHour`

#### Summary

True if user is specifying air changes per hour, false otherwise.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.UseCurrentViewOnly`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.UseCurrentViewOnly`

#### Summary

True if only elements visible in the currently active view are used for generation of Energy Model.

#### Remarks

This setting is ignored if the currently active view is not a 3D view or AnalysisType is RoomsOrSpaces.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.UseOutsideAirPerArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.UseOutsideAirPerArea`

#### Summary

True is user is specifying outside air per area, false otherwise.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.UseOutsideAirPerPerson`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.UseOutsideAirPerPerson`

#### Summary

True if user is specifying outside air per person, false otherwise.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.IsGlazingShaded`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.IsGlazingShaded`

#### Summary

If this is true, glazing/windows that are auto-created on exterior walls will automatically
have a shading device created on their top edge.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.CreateAnalyticalModel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.CreateAnalyticalModel`

#### Summary

If this is true, data, features, and geometry related to the Energy Analytical Model
will be created, allowing the energy performance to be analyzed through GreenBuilidingXML.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.UseHeatingCredits`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.UseHeatingCredits`

#### Summary

If true, Revit will use heating credits in the final load sum calculations.
If false, Revit will ignore heating credits in the final load sum calculations.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.ExportDefaults`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.ExportDefaults`

#### Summary

Use for detailed model GreenBuildingXML export.
When this setting is true, all building and space defaults, schedules, and constructions will be exported to GreenBuildingXML.
When this setting is false, only values that are specified on the zone or space will be exported to GreenBuildingXML.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.ServiceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.ServiceType`

#### Summary

The type of heating or cooling system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The service type does not fall within an appropriate range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.BuildingTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.BuildingTypeId`

#### Summary

The building type element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.AnalysisType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.AnalysisType`

#### Summary

The type of analysis mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The analysis type does not fall within an appropriate range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.ProjectPhase`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.ProjectPhase`

#### Summary

The project phase of the EnergyData information.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input element is not a project phase.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.GroundPlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.GroundPlane`

#### Summary

Id of level which represents ground level.

#### Remarks

The ground plane defines what is above and below ground for Conceptual Energy Analysis.
The ground plane can optionally used for the rendering cast shadows.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input element is not a level or invalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.ExportCategory`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.ExportCategory`

#### Summary

Value is a category indicating which discipline model will be used for GreenBuildingXML export.

#### Remarks

OST_Rooms will use the architectural 3d rooms for export.
OST_MEPSpaces will use the MEP 3d Spaces for export.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The export category is neither OST_Rooms nor OST_MEPSpaces.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.BuildingHVACSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.BuildingHVACSystem`

#### Summary

The type of HVAC system used by the building for conceptual model energy calculations.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The building HVAC system does not fall within an appropriate range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.BuildingOperatingSchedule`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.BuildingOperatingSchedule`

#### Summary

The operating schedule of the building used for conceptual model energy calculations.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The building operating schedule does not fall within an appropriate range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.ProjectReportType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.ProjectReportType`

#### Summary

Report type: None, simple, standard, detailed

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The project report type does not fall within an appropriate range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.BuildingConstructionClass`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.BuildingConstructionClass`

#### Summary

Used for both the detailed and conceptual energy model
Construction class of building as defined by:
loose, medium, tight, or none.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The building construction class does not fall within an appropriate range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.ExportComplexity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.ExportComplexity`

#### Summary

Value determines Export Complexity for GreenBuildingXML detailed model export.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The export complexity does not fall within an appropriate range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.OutsideAirChangesRatePerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.OutsideAirChangesRatePerHour`

#### Summary

The number of times the volume of air interchanges in the room in one hour.

#### Remarks

Air Changes per hour is "unitless". It is a number.
It is the number of times the air (the volume) interchanges in the room in one hour.
This number is a format for expressing the requirement for airflow.
The "flow" requirement for a room might be expressed, e.g.,
one room of 100 CF, and 3 Air Changes per Hour (ACH), would compute to 100 CF x 3 ACH / 60 min = 5 CFM.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The outside airChangesRatePerHour does not fall within an appropriate range.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.OutsideAirPerArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.OutsideAirPerArea`

#### Summary

The rate of flow of outside air available per unit area.

#### Remarks

Stored in cubic feet per hour per square foot.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The outside airPerArea does not fall within an appropriate range.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.OutsideAirPerPerson`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.OutsideAirPerPerson`

#### Summary

The rate of flow of outside air available per person.

#### Remarks

Stored in cubic feet per hour.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The outside airPerPerson does not fall within an appropriate range.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.SkylightWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.SkylightWidth`

#### Summary

Used for the conceptual energy model. The approximate width used for the skylights in
massing instances when the Energy Analytical model is being created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The skylight width is less than eight inches.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.PercentageSkylights`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.PercentageSkylights`

#### Summary

Used for the conceptual energy model.
The approximate percentage of the building roof surfaces in
massing instances for the Conceptual Energy Analytical Model.

#### Remarks

This value is used to automatically model the skylights in
massing instances when the Energy Analytical model is being created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The percentage skylights value is between 0.00 and 0.95.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.ShadeDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.ShadeDepth`

#### Summary

Used for the conceptual energy model.
Amount that auto-generated shading will extend from auto-generated windows.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The shade depth is less than zero.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.SillHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.SillHeight`

#### Summary

Used for the conceptual energy model.
The height from the nearest lower level used for auto-glazing created
on walls.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The sill height is less than zero.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.PercentageGlazing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.PercentageGlazing`

#### Summary

Used for the conceptual energy model.
The approximate percentage of the building exterior wall surfaces
which are covered by windows or other glazing.

#### Remarks

This value is used to automatically model these glazed openings in
massing instances for the Conceptual Energy Analytical Model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The percentage glazing value is not between 0.00 and 0.95.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.EnergyDataSettings.SliverSpaceTolerance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings.SliverSpaceTolerance`

#### Summary

Used for Detailed GreenBuildingXML export.
This value is used to identify sliver spaces, i.e. spaces bounded by parallel surfaces belonging to different rooms.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The sliver space tolerance is less than zero.

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.EnergyDataSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyDataSettings`

#### Summary

This element contains settings for gbXML Export and Heating and Cooling Load Calculations
and project level settings for Conceptual Energy Analysis.
for serialization

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType`

#### Summary

Enumerated type listing possible types of reports generated for HVAC loads.

#### Since

2011

### `F:Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType.DetailedReport`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType.DetailedReport`

#### Summary

A detailed report including orientation breakdowns

### `F:Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType.StandardReport`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType.StandardReport`

#### Summary

A standard report including zones and spaces

### `F:Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType.SimpleReport`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType.SimpleReport`

#### Summary

A simple report with summaries

### `F:Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType.NoReport`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType.NoReport`

#### Summary

No report

### `T:Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass`

#### Summary

Enumerated type listing options for construction class for HVAC analysis.

#### Since

2011

### `F:Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass.NoneConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass.NoneConstruction`

#### Summary

A none construction has an infiltration level of 0 cfm/sqft

### `F:Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass.TightConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass.TightConstruction`

#### Summary

A tight construction has an infiltration level of approximately 0.019 cfm/sqft

### `F:Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass.MediumConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass.MediumConstruction`

#### Summary

A medium construction has an infiltration level of approximately 0.038 cfm/sqft

### `F:Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass.LooseConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass.LooseConstruction`

#### Summary

A loose construction has an infiltration level of approximately 0.076 cfm/sqft

### `T:Autodesk.Revit.DB.Analysis.ConstructionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.ConstructionType`

#### Summary

This enumeration specifies the available analytical construction types
like external walls, windows etc. for use in the detailed analytical
energy model.

#### Since

2011

### `F:Autodesk.Revit.DB.Analysis.ConstructionType.UndergroundWall`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConstructionType.UndergroundWall`

#### Summary

Underground walls

### `F:Autodesk.Revit.DB.Analysis.ConstructionType.Skylight`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConstructionType.Skylight`

#### Summary

A window in a roof in the space

### `F:Autodesk.Revit.DB.Analysis.ConstructionType.InteriorWindow`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConstructionType.InteriorWindow`

#### Summary

A window in an interior wall in the space

### `F:Autodesk.Revit.DB.Analysis.ConstructionType.ExteriorWindow`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConstructionType.ExteriorWindow`

#### Summary

A window in an exterior wall in the space

### `F:Autodesk.Revit.DB.Analysis.ConstructionType.Door`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConstructionType.Door`

#### Summary

A door in a wall in the space

### `F:Autodesk.Revit.DB.Analysis.ConstructionType.Floor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConstructionType.Floor`

#### Summary

A floor below the space

### `F:Autodesk.Revit.DB.Analysis.ConstructionType.Ceiling`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConstructionType.Ceiling`

#### Summary

A ceiling over the space

### `F:Autodesk.Revit.DB.Analysis.ConstructionType.Roof`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConstructionType.Roof`

#### Summary

A roof over the space

### `F:Autodesk.Revit.DB.Analysis.ConstructionType.Slab`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConstructionType.Slab`

#### Summary

A slab below the space

### `F:Autodesk.Revit.DB.Analysis.ConstructionType.InteriorWall`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConstructionType.InteriorWall`

#### Summary

An interior wall surrounding the space

### `F:Autodesk.Revit.DB.Analysis.ConstructionType.ExteriorWall`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.ConstructionType.ExteriorWall`

#### Summary

An exterior wall surrounding the space

### `T:Autodesk.Revit.DB.Analysis.EnergyAnalysisZone`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisZone`

#### Summary

Analytical zone.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.Polyloop.ComputeArea`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.Polyloop.ComputeArea`

#### Summary

Gets the area for this polygon.

#### Remarks

The area of the planar non-self-intersecting polygon computed as:
A = 1/2 * (X1 Y2) - (X2 Y1) + ... + (Xn Y1) - (X1 Yn)

#### Returns

The area for this polygon.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.Polyloop.GetPoints`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.Polyloop.GetPoints`

#### Summary

Gets the array of points in the polygon.

#### Returns

The array of points in the polygon.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.Polyloop.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.Polyloop.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.Polyloop.Direction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.Polyloop.Direction`

#### Summary

The direction for the outward normal for this polygon.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.Polyloop.Centroid`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.Polyloop.Centroid`

#### Summary

The polygon centroid.

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.Polyloop`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.Polyloop`

#### Summary

A Polyloop represent a planar polygon with ordered points.

#### Remarks

This class is a loop with straight edges bounding a planar region in space.
The loop is represented by an ordered coplanar collection of points
forming the vertices of the loop. The loop is composed of straight line segments
joining a point in the collection to the succeeding point in the collection.
The closing segment is from the last to the first point in the collection.
The direction of the loop is in the direction of the line segments.
All the points in the polygon defining the poly loop shall be coplanar.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType.GetSolarHeatGainCoefficientsForSolarIndicientAngles`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType.GetSolarHeatGainCoefficientsForSolarIndicientAngles`

#### Summary

Returns a map with solar heat gain coefficients (SHGC-values) for specific incident angles for the window type.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType.Transmittance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType.Transmittance`

#### Summary

The visual light transmittance value (VLT-value) for the window type.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType.SolarHeatGainCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType.SolarHeatGainCoefficient`

#### Summary

The solar heat gain coefficient (SHGC-value) for the window type.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType.HeatTransferCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType.HeatTransferCoefficient`

#### Summary

The heat transfer coefficient value (U-value) of the window type.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType.Description`

#### Summary

The description of the window type.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType.WindowTypeName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType.WindowTypeName`

#### Summary

The name of the window type.

#### Since

2024

### `T:Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType`

#### Summary

The EnergyAnalysisWindowType class contains window type data for gbXml export.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.GetPolyloops`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.GetPolyloops`

#### Summary

Gets the collection of planar polygons describing the surface geometry.

#### Remarks

A collection of polyloops (planar polygons) describing the surface geometry as described
in gbXML. The geometry is currently measured per analytical(center-line).

#### Returns

The collection of polygons describing the surface geometry.

#### Since

2023

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.GetPolyloop`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.GetPolyloop`

#### Summary

Gets the planar polygon describing the surface geometry.

#### Remarks

A planar polygon describing the surface geometry as described
in gbXML. The geometry is currently measured per analytical(center-line).

#### Returns

The planar polygon describing the surface geometry.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.GetConstruction`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.GetConstruction`

#### Summary

Gets the analytic construction this surface is associated with.

#### Returns

The analytic construction.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.GetAnalyticalOpenings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.GetAnalyticalOpenings`

#### Summary

Returns the analytical openings of the analytical surface.

#### Returns

The collection of analytical openings.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.GetAdjacentAnalyticalSpace`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.GetAdjacentAnalyticalSpace`

#### Summary

Gets the secondary adjacent analytical space this surface is associated with.

#### Remarks

An exterior surface will only have one space adjacency.

#### Returns

The secondary analytical space.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.GetAnalyticalSpace`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.GetAnalyticalSpace`

#### Summary

Gets the primary analytical space this surface is associated with.

#### Returns

The primary analytical space.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.SurfaceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.SurfaceId`

#### Summary

The unique identifier for the surface.

#### Remarks

This identification attribute is composed of the prefix "su"
and a sequential number, separated by "-". A sample value would
be "su-1".

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Corner`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Corner`

#### Summary

The lower-left coordinate for the analytical rectangular geometry viewed from outside.

#### Remarks

The analytical rectangular geometry is typically used in simulation engines.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Normal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Normal`

#### Summary

The outward normal for this surface.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.SurfaceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.SurfaceType`

#### Summary

The analytical surface type.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.OriginatingElementName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.OriginatingElementName`

#### Summary

The name for the originating Revit element.

#### Remarks

Surface elements get an originating element assigned according to the below described schema, based on associative room bounding element:

(Family Name) : (Family Type)

Sample:
Basic Wall : Cast Concrete Wall 12"

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.OriginatingElementDescription`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.OriginatingElementDescription`

#### Summary

The description for the originating Revit element.

#### Remarks

Surface and Opening elements get an originating element assigned
according to the below described schema, based on associative
room bounding element:

(Family Name): (Family Type)[Element Id]

Sample:
Basic Wall: Cast Concrete Wall 12" [49749]

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.CADLinkUniqueId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.CADLinkUniqueId`

#### Summary

The unique id of the originating CAD object's link (linked document) associated with this surface.

#### Remarks

This id can be passed to obtain the element from Document.Element[string] property, but any link obtained through this method
may no longer be a valid or up-to-date link. The originating CAD link is only accurate and up-to-date at the time of creation of the energy model.
An empty string is returned if the originating CAD object is not hosted in a linked document.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.CADObjectUniqueId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.CADObjectUniqueId`

#### Summary

The unique id of the originating CAD object (model element) associated with this surface.

#### Remarks

This id can be passed to obtain the element from Document.Element[string] property, but any element obtained through this method
may no longer be a valid or up-to-date model element. The originating CAD object is only accurate and up-to-date at the time of creation of the energy model.
If the originating element belongs to a linked document, the unique id of the link obtained from CADLinkUniqueId should be used to access it.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.OriginatingElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.OriginatingElementId`

#### Summary

The element id for the originating Revit element.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.SurfaceName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.SurfaceName`

#### Summary

The unique name identifier for this surface.

#### Remarks

Surface and Opening elements get an Name element assigned
according to the below described schema:

(Orientation)(Space#)[(Other space#)](Exposure)(Type)-(sequence number)[Opening Type+#]

Sample:
N-101-102-E-W-O-77

N = Orientation [N/NE/E/SE/S/SW/W/NW/N/T/B/X]
(every surface within the sector of 22.5 degrees from the north
vector gets the letter N etc) (horizontal surfaces facing upwards
get the letter T for top, downwards B for bottom) (shading surfaces
get the letter X for differentiation).

101 = Space number.

102 = Other space number.

E = Exposure - exterior/interior/underground [E/I/U].

W = Type [W/C/R/F] (Wall, Roof, Ceiling, Floor, Shade) (every
surface type has it's letter W-Wall R-Roof C-Ceiling F-Floor S-Shade).

O = Opening Type [W/D/O] (Window, Door, Opening) (every opening
type has it's letter W-Window D-Door O-Opening).

77 = sequence number.

Sample surface names:

N-101-E-W-84 North facing Exterior Wall #84 in space 101.

N-101-E-W-84-D-1 Door #1 in North facing Exterior Wall #84 in space 101.

E-101-102-I-W-92 Vertical Interior Wall #92 between space 101 and 102.

T-101-E-R-141 Top facing Exterior Roof #141 in space 101.

B-101-201-I-F-88 Bottom facing Interior Floor #88 between space 101 and 201.

X-73 Shade #73.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Type`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Type`

#### Summary

The gbXML surface type attribute.

#### Remarks

The type of surface is figured out depending on the source element and the number of space adjacencies.
If there is no associate source element and no space adjacencies, it will have a type of Shade. If there are any space adjacencies, it will have a type of Air.

If the source element is a Wall or a Curtain Wall and have one space adjacency, it will have a type of ExteriorWall.

If the source element is a Wall or a Curtain Wall and have two space adjacencies, it will have a type of InteriorWall.

If the source element is a Wall or a Curtain Wall and the type Function parameter is set to "Interior" or "CoreShaft", it will have a type of InteriorWall.

If the source element is a Wall or a Curtain Wall and have one space adjacency and if it is below grade, it will have a type of UndergroundWall.

Note: If the top elevation of a surface is equal or below the elevation specified in Ground Plane, this surface is considered to below grade.

If the source element is a Floor and have one space adjacency, it will have a type of SlabOnGrade. If the source element is above grade, it will have
a type of RaisedFloor. If the source element is below grade, it will have a type of UndergroundSlab.

If the source element is a Floor and have two space adjacencies, it will have a type of InteriorFloor.

If the source element is a Floor and the type Function parameter is set to "Interior", it will have a type of InteriorFloor.

If the source element is a Roof or a Ceiling and have one space adjacency, it will have a type of Roof.

If the source element is a Roof or a Ceiling and have one space adjacency and is below grade, it will have a type of UndergroundCeiling.

If the source element is a Roof or a Ceiling and have two space adjacencies, it will have a type of Ceiling.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Tilt`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Tilt`

#### Summary

The tilt angle for this surface.

#### Remarks

The tilt is computed as the angle of rotation between
the outward normal of the surface and the Z-axis.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Azimuth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Azimuth`

#### Summary

The azimuth angle for this surface.

#### Remarks

The azimuth is computed as the angle of rotation between
the outward normal of the surface and the Y-axis (clockwise is positive).

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Height`

#### Summary

The height of the analytical rectangular geometry.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface.Width`

#### Summary

The width of the analytical rectangular geometry.

#### Remarks

The product of width and height should be equal to the area
of the polyloop for the opening. The width is adjusted to accomplish this.

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface`

#### Summary

Analytical surface.
The collection of analytic openings belonging to this analytical parent surface

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType`

#### Since

2012

#### Summary

Analytical surface types.

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.Underground`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.Underground`

#### Summary

Underground

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.Air`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.Air`

#### Summary

Air.

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.Shading`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.Shading`

#### Summary

Shading.

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.ExteriorFloor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.ExteriorFloor`

#### Summary

Exterior floor.

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.InteriorFloor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.InteriorFloor`

#### Summary

Interior floor.

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.Ceiling`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.Ceiling`

#### Summary

Ceiling.

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.InteriorWall`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.InteriorWall`

#### Summary

Interior wall.

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.ExteriorWall`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.ExteriorWall`

#### Summary

Exterior wall.

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.Roof`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType.Roof`

#### Summary

Roof.

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.GetBoundary`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.GetBoundary`

#### Summary

Gets the collection of polygons that form the 2D boundary.
This method returns a collection of polyloops (planar
polygons) that defines an enclosed area measured by
interior bounding surfaces.

#### Returns

The collection of polygons that form the 2D boundary.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.GetClosedShell`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.GetClosedShell`

#### Summary

Gets the collection of polygons that form a closed shell.
This method returns a collection of polyloops (planar
polygons) that defines an enclosed volume measured by
interior bounding surfaces.

#### Returns

the collection of polygons that form a closed shell.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.GetAnalyticalSurfaces`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.GetAnalyticalSurfaces`

#### Summary

Provides a way to access the collection of
analytical surfaces for a space.
Geometry data defining an analytical space volume.
Through an analytical surface you can connect a
source element with each polygon in a space.
The analytical surfaces defines an enclosed volume
bounded by the center plane of walls
and the top plane of roofs and floors.

#### Returns

the collection of analytical surfaces for a space.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.Volume`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.Volume`

#### Summary

The volume for this space.

#### Remarks

If the space is created with the mode 'Use Rooms or Spaces', this value is the enclosed volume measured by interior bounding surfaces.
Otherwise, this value is the average of the analytical volume and the voxel volume. Note that the analytical volume is measured by
the center plane of walls and the top plane of roofs and floors, and the voxel volume is measured by the number of enclosed unit cubes.

#### Since

2023

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.Area`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.Area`

#### Summary

The area for this space.

#### Remarks

If the space is created with the mode 'Use Rooms or Spaces', this value is the enclosed area measured by interior bounding surfaces.
Otherwise, this value is measured by the center plane of walls and the top plane of roofs and floors.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.CADObjectUniqueId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.CADObjectUniqueId`

#### Summary

The unique id of the originating CAD object (model element) associated with this space.

#### Remarks

This id can be passed to obtain the element from Document.Element[string] property, but any element obtained through this method
may no longer point to a valid or up-to-date model element. The originating CAD object is only accurate and up-to-date at the time of creation of the energy model.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.ComposedName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.ComposedName`

#### Summary

The composed name for this space.

#### Remarks

This value is composed of the number and name attributes,
separated by a space.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.Description`

#### Summary

The description.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.Number`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.Number`

#### Summary

The number to identify the space.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.SpaceName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace.SpaceName`

#### Summary

The name.

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace`

#### Summary

Analytical space.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.GetPolyloops`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.GetPolyloops`

#### Summary

Gets the collection of planar polygons describing the opening geometry.

#### Remarks

A collection of polyloops (planar polygons) describing the opening geometry as described
in gbXML. The geometry is currently measured per analytical(center-line).

#### Returns

The collection of polygons describing the opening geometry.

#### Since

2023

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.GetPolyloop`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.GetPolyloop`

#### Summary

Gets the planar polygon describing the opening geometry.

#### Remarks

A planar polygon describing the surface geometry as described
in gbXML. The geometry is currently measured per analytical(center-line).

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.GetWindowType`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.GetWindowType`

#### Summary

Gets the analytic window type this surface is associated with.

#### Returns

The analytic window type.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.GetConstruction`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.GetConstruction`

#### Summary

Gets the analytic construction this surface is associated with.

#### Returns

The analytic construction.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.GetAnalyticalSurface`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.GetAnalyticalSurface`

#### Summary

Gets the associative analytical parent surface element.

#### Returns

The associative analytical parent surface element.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.OpeningId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.OpeningId`

#### Summary

The unique identifier for the opening.

#### Remarks

This identification attribute is composed of the id for the
parent surface, the prefix "op" and a sequential number, all
separated by "-". A sample value would be "su-1-op-1".

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.Corner`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.Corner`

#### Summary

The lower-left coordinate for the analytical rectangular geometry viewed from outside.

#### Remarks

A planar polygon describing the surface geometry as described
in gbXML. The geometry is currently measured per analytical(center-line).

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.OpeningType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.OpeningType`

#### Summary

The analytical opening type.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.OriginatingElementName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.OriginatingElementName`

#### Summary

The name for the originating Revit element.

#### Remarks

Opening elements get an originating element assigned according to the below described schema, based on associative room bounding element:

(Family Name) : (Family Type)

Sample:
Basic Wall : Cast Concrete Wall 12"

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.OriginatingElementDescription`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.OriginatingElementDescription`

#### Summary

The description for the originating Revit element.

#### Remarks

Surface and Opening elements get an CADObjectId element assigned
according to the below described schema, based on associative
room bounding element:

(Family Name): (Family Type)[Element Id]

Sample:
System Panel: System Panel [50566]

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.CADLinkUniqueId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.CADLinkUniqueId`

#### Summary

The unique id of the originating CAD object's link (linked document) associated with this opening.

#### Remarks

This id can be passed to obtain the element from Document.Element[string] property, but any link obtained through this method
may no longer be a valid or up-to-date link. The originating CAD link is only accurate and up-to-date at the time of creation of the energy model.
An empty string is returned if the originating CAD object is not hosted in a linked document.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.CADObjectUniqueId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.CADObjectUniqueId`

#### Summary

The unique id of the originating CAD object (model element) associated with this opening.

#### Remarks

This id can be passed to obtain the element from Document.Element[string] property, but any element obtained through this method
may no longer be a valid or up-to-date model element. The originating CAD object is only accurate and up-to-date at the time of creation of the energy model.
If the originating element belongs to a linked document, the unique id of the link obtained from CADLinkUniqueId should be used to access it.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.OriginatingElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.OriginatingElementId`

#### Summary

The element id for the originating Revit element.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.OpeningName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.OpeningName`

#### Summary

The unique name identifier for the opening.

#### Remarks

Surface and Opening elements get an Name element assigned
according to the below described schema:

(Orientation)(Space#)[(Other space#)](Exposure)(Type)-(sequence number)[Opening Type+#]

Sample:
N-101-102-E-W-O-77

N = Orientation [N/NE/E/SE/S/SW/W/NW/N/T/B/X]
(every surface within the sector of 22.5 degrees from the north
vector gets the letter N etc) (horizontal surfaces facing upwards
get the letter T for top, downwards B for bottom) (shading surfaces
get the letter X for differentiation).

101 = Space number.

102 = Other space number.

E = Exposure - exterior/interior/underground [E/I/U].

W = Type [W/C/R/F] (Wall, Roof, Ceiling, Floor, Shade) (every
surface type has it's letter W-Wall R-Roof C-Ceiling F-Floor S-Shade).

O = Opening Type [W/D/O] (Window, Door, Opening) (every opening
type has it's letter W-Window D-Door O-Opening).

77 = sequence number.

Sample surface names:

N-101-E-W-84 North facing Exterior Wall #84 in space 101.

N-101-E-W-84-D-1 Door #1 in North facing Exterior Wall #84 in space 101.

E-101-102-I-W-92 Vertical Interior Wall #92 between space 101 and 102.

T-101-E-R-141 Top facing Exterior Roof #141 in space 101.

B-101-201-I-F-88 Bottom facing Interior Floor #88 between space 101 and 201.

X-73 Shade #73.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.Type`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.Type`

#### Summary

The gbXML opening type attribute.

#### Remarks

The type of the opening is based on the family category for
the opening and in what element it is contained in:
If it is a Window it will have a type of OperableWindow.

If it is a Door it will have a type of NonSlidingDoor.

If the opening is contained in a Roof it will have a type of FixedSkylight.

If it is a Curtain Wall Panel, the opening will default to
a type of FixedWindow. If the material specified for the family,
and the material transparency is less than 3%, the opening will
be ignored as a solid panel.
An opening of the category Openings will have the type of Air.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.Height`

#### Summary

The height of the analytical rectangular geometry.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening.Width`

#### Summary

The width of the analytical rectangular geometry.

#### Remarks

The product of width and height should be equal to the area
of the polyloop for the opening. The width is adjusted to accomplish this.

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening`

#### Summary

Analytical opening.

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpeningType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpeningType`

#### Summary

Energy analysis opening type.

#### Since

2012

#### Summary

Analytical opening types.

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpeningType.Air`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpeningType.Air`

#### Summary

Air.

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpeningType.Skylight`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpeningType.Skylight`

#### Summary

Skylight.

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpeningType.Window`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpeningType.Window`

#### Summary

Window.

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisOpeningType.Door`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisOpeningType.Door`

#### Summary

Door.

### `P:Autodesk.Revit.DB.LinkElementId.HostElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinkElementId.HostElementId`

#### Summary

The id of the element in the host, or invalidElementId if there is a link.

#### Since

2012

### `P:Autodesk.Revit.DB.LinkElementId.LinkedElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinkElementId.LinkedElementId`

#### Summary

The id of the element in the link, or invalidElementId if no link.

#### Since

2012

### `P:Autodesk.Revit.DB.LinkElementId.LinkInstanceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinkElementId.LinkInstanceId`

#### Summary

The id of the link, or invalidElementId if no link.

### `M:Autodesk.Revit.DB.LinkElementId.op_Inequality(Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.LinkElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkElementId.op_Inequality(Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.LinkElementId)`

#### Summary

Determines whether these two LinkElementIds are different.

#### Parameter `first`

The first LinkElementId.

#### Parameter `second`

The second LinkElementId.

#### Returns

True if the LinkElementIds are different; otherwise, false.

### `M:Autodesk.Revit.DB.LinkElementId.op_Equality(Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.LinkElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkElementId.op_Equality(Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.LinkElementId)`

#### Summary

Determines whether these two LinkElementIds are the same.

#### Parameter `first`

The first LinkElementId.

#### Parameter `second`

The second LinkElementId.

#### Returns

True if the LinkElementIds are the same; otherwise, false.

### `M:Autodesk.Revit.DB.LinkElementId.Equals(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkElementId.Equals(System.Object)`

#### Summary

Determines whether the specified `T:System.Object` is equal to the current `T:System.Object` .

#### Parameter `obj`

Another object.

### `M:Autodesk.Revit.DB.LinkElementId.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkElementId.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new LinkElementId representing an element in a linked document.

#### Parameter `linkInstanceId`

The id of the linked model element in the host document.

#### Parameter `elementId`

The id of the element in the linked model document.

#### Since

2011

### `M:Autodesk.Revit.DB.LinkElementId.#ctor(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkElementId.#ctor(Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new LinkElementId representing an element in the host document.

#### Parameter `elementId`

The id of the element in the host document.

#### Since

2011

### `T:Autodesk.Revit.DB.LinkElementId`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinkElementId`

#### Summary

LinkElementId represents an element in a linked document.

#### Remarks

The id contains two element ids:
The id of the linked model element in host document.

The id of the element in the linked model document.

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.gbXMLExportBuildingEnvelope`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLExportBuildingEnvelope`

#### Summary

Indicates the determination method for the building envelope

#### Since

2015

### `F:Autodesk.Revit.DB.Analysis.gbXMLExportBuildingEnvelope.IdentifyExteriorElements`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLExportBuildingEnvelope.IdentifyExteriorElements`

#### Summary

This method uses a combination of ray-casting and flood-fill algorithms in order to identify the building elements that are
exposed to the outside of the building, the building envelope. Analytical surface originated from the building elements in the envelope
will be classified as exterior or shading surfaces.

### `F:Autodesk.Revit.DB.Analysis.gbXMLExportBuildingEnvelope.UseFunctionParameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLExportBuildingEnvelope.UseFunctionParameter`

#### Summary

This method uses the Function type parameter of Walls, Floors and Building Pads to determinate the building elements considered to be part of the building envelope.
If a wall has one adjacent space, analytical surface originated from the wall will be classified as exterior surfaces.
If a wall has two adjacent spaces and its function is Exterior, Foundation, Retaining, or Soffit, analytical surface originated from the wall will be classified
as interior surfaces.
If thw wall's function is Interior or Core Shaft, analytical surface originated from the wall will be classfied interior surfaces, regardless of the number of adjacent spaces.

### `T:Autodesk.Revit.DB.Analysis.gbXMLBuildingHVACSystem`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLBuildingHVACSystem`

#### Summary

Enumerations for gbXML (Green Building XML) format, used for energy
analysis, schema version 0.34.

#### Remarks

This enumeration corresponds to the HVAC System attribute in gbXML and
is used to specify the Building HVAC System.

### `T:Autodesk.Revit.DB.Analysis.gbXMLBuildingOperatingSchedule`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLBuildingOperatingSchedule`

#### Summary

Enumerations for gbXML (Green Building XML) format, used for energy
analysis, schema version 0.34.

#### Remarks

This enumeration corresponds to the buildingType attribute in gbXML and
is used to specify the building operating schedule.

### `T:Autodesk.Revit.DB.Analysis.gbXMLOpeningType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLOpeningType`

#### Summary

This enumeration corresponds to the openingType attribute in gbXML
and identifies the type of opening defined.

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.gbXMLOpeningType.NoOfOpeningTypes`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLOpeningType.NoOfOpeningTypes`

#### Summary

No of opening types.

### `F:Autodesk.Revit.DB.Analysis.gbXMLOpeningType.OpeningAir`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLOpeningType.OpeningAir`

#### Summary

Opening air.

### `F:Autodesk.Revit.DB.Analysis.gbXMLOpeningType.NonSlidingDoor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLOpeningType.NonSlidingDoor`

#### Summary

Non sliding door.

### `F:Autodesk.Revit.DB.Analysis.gbXMLOpeningType.SlidingDoor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLOpeningType.SlidingDoor`

#### Summary

Sliding door.

### `F:Autodesk.Revit.DB.Analysis.gbXMLOpeningType.OperableSkylight`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLOpeningType.OperableSkylight`

#### Summary

Operable skylight.

### `F:Autodesk.Revit.DB.Analysis.gbXMLOpeningType.FixedSkylight`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLOpeningType.FixedSkylight`

#### Summary

Fixed skylight.

### `F:Autodesk.Revit.DB.Analysis.gbXMLOpeningType.OperableWindow`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLOpeningType.OperableWindow`

#### Summary

Operable window.

### `F:Autodesk.Revit.DB.Analysis.gbXMLOpeningType.FixedWindow`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLOpeningType.FixedWindow`

#### Summary

Fixed window.

### `T:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType`

#### Summary

This enumeration corresponds to the surfaceType attribute in gbXML
and identifies the type of surface defined.

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.NoOfSurfaceTypes`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.NoOfSurfaceTypes`

#### Summary

No of surface types.

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.SlabOnGrade`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.SlabOnGrade`

#### Summary

Slab on grade.

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.RaisedFloor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.RaisedFloor`

#### Summary

Raised floor.

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.UndergroundCeiling`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.UndergroundCeiling`

#### Summary

Underground ceiling.

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.SurfaceAir`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.SurfaceAir`

#### Summary

Surface air.

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.Ceiling`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.Ceiling`

#### Summary

Ceiling.

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.UndergroundSlab`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.UndergroundSlab`

#### Summary

Underground slab.

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.UndergroundWall`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.UndergroundWall`

#### Summary

Underground wall.

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.Shade`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.Shade`

#### Summary

Shade.

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.ExposedFloor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.ExposedFloor`

#### Summary

Exposed floor.

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.InteriorFloor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.InteriorFloor`

#### Summary

Interior floor.

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.Roof`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.Roof`

#### Summary

Roof.

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.ExteriorWall`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.ExteriorWall`

#### Summary

Exterior wall.

### `F:Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.InteriorWall`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSurfaceType.InteriorWall`

#### Summary

Interior wall.

### `T:Autodesk.Revit.DB.Analysis.gbXMLSpaceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLSpaceType`

#### Summary

This enumeration corresponds to the spaceType attribute in gbXML.
The enumerated attribute identifies the type of space defined and
allows to better approximate the actual internal loads and schedules
associated with the defined space type.

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.gbXMLConditionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLConditionType`

#### Summary

This enumeration corresponds to the conditionType attribute in gbXML.
The enumerated attribute identifies the type of heating, cooling,
or ventilation the space has.

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.gbXMLServiceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLServiceType`

#### Summary

This enumeration corresponds to the systemType attribute in gbXML
and is used for specifying the service for the building or space.

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.gbXMLBuildingType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLBuildingType`

#### Summary

Enumerations for gbXML (Green Building XML) format, used for energy
analysis, schema version 0.34.

#### Summary

This enumeration corresponds to the buildingType attribute in gbXML and
is used to specify the most predominant building use type.

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.gbXMLExportComplexity`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLExportComplexity`

#### Summary

This enumeration specifies the level of detail of the exported analytical energy model in gbXML.
Complex means that Curtain Walls and Curtain Systems are exported as several openings, panel by panel;
a curtain wall with 50 panels gets exported as 50 openings. Simple means that one "huge" opening with
the total opening area equal to the 50 panels is exported. This is more appropriate for most energy analysis.
Mullions mean that Mullions in Curtain Walls and Systems are exported as shading surfaces. A "simplified"
analytical shading surface is produced from a mullion based on its centerline, thickness and offset.

#### Since

2011

### `F:Autodesk.Revit.DB.Analysis.gbXMLExportComplexity.ComplexWithMullionsAndShadingSurfaces`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLExportComplexity.ComplexWithMullionsAndShadingSurfaces`

#### Summary

Using this enumeration, mullions will be exported as shading
surfaces. A "simplified" analytical shading surface is produced
from a mullion based on its centerline, thickness and offset.

### `F:Autodesk.Revit.DB.Analysis.gbXMLExportComplexity.ComplexWithShadingSurfaces`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLExportComplexity.ComplexWithShadingSurfaces`

#### Summary

Using this enumeration, shading surfaces will be produced from
room bounding building elements that are not bounding spaces.

### `F:Autodesk.Revit.DB.Analysis.gbXMLExportComplexity.Complex`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLExportComplexity.Complex`

#### Summary

Using this enumeration, Curtain Walls and Curtain Systems will
exported as several openings, panel by panel.

### `F:Autodesk.Revit.DB.Analysis.gbXMLExportComplexity.SimpleWithShadingSurfaces`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLExportComplexity.SimpleWithShadingSurfaces`

#### Summary

Using this enumeration, shading surfaces will be produced from
room bounding building elements that are not bounding spaces

### `F:Autodesk.Revit.DB.Analysis.gbXMLExportComplexity.Simple`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.gbXMLExportComplexity.Simple`

#### Summary

Curtain Walls and Curtain Systems are normally exported as several openings, panel by panel,
while for energy analysis all you need is one giant window. A curtain wall with 50 panels
gets exported as 50 openings, while 1 opening with the total opening area would be more appropriate.
Using this enumeration, one "large" window/opening will be exported for a curtain wall/system

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.TransformModel`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.TransformModel`

#### Summary

Transforms all surfaces in the model according to the document's active
ground plane, shared coordinates and true north.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation failed.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.GetAnalyticalShadingSurfaces`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.GetAnalyticalShadingSurfaces`

#### Summary

The collection of analytical shading surfaces.

#### Returns

Returns the analytical shading surfaces after model calculation.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.GetAnalyticalOpenings`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.GetAnalyticalOpenings`

#### Summary

The collection of analytical openings.

#### Returns

Returns the analytical openings after model calculation.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.GetAnalyticalSurfaces`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.GetAnalyticalSurfaces`

#### Summary

The collection of analytical surfaces.

#### Returns

Returns the analytical surfaces after model calculation.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.GetAnalyticalSpaces`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.GetAnalyticalSpaces`

#### Summary

The collection of analytical spaces.

#### Returns

Returns the analytical spaces after model calculation.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.GetMainEnergyAnalysisDetailModel(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.GetMainEnergyAnalysisDetailModel(Autodesk.Revit.DB.Document)`

#### Summary

Gets the EnergyAnalysisDetailModel in given document.

#### Parameter `document`

The document that contains the physical model of the building.

#### Returns

Returns the EnergyAnalysisDetailModel contained in the document, if it exists. If it does not exist, this returns `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions)`

#### Summary

Creates a new energy analysis detailed model.

#### Remarks

The generated energy model is always returned in world coordinates.
The method TransformModel() transforms all surfaces in the model according to
ground plane, shared coordinates and true north.
The EnergyModelType in argument EnergyAnalysisDetailModelOptions indicates
whether the generated energy model is based on rooms/spaces or building elements. The default value
is EnergyModelType.SpatialElement.

#### Parameter `document`

The document that contains the physical model of the building.

#### Parameter `options`

The options to control the calculation rules.

#### Returns

The created model instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

An EnergyAnalysisDetailModel cannot be created if EnergyModelType.BuildingElement is input
and AnalysisMode.ConceptualMasses is set in EnergyDataSettings (these values are incompatible).
-or-
Throws if there are no valid spatial bounding elements,
or no valid spatial elements in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to create the energy analysis detail model.

#### Exception `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Throws if user aborted the energy analysis detail model creation.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.ExportCategory`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.ExportCategory`

#### Summary

Export elements of this category in energy analysis.

#### Remarks

Export will be based on the space type associated with the product creating it.
Valid categories are Rooms or MEP Spaces.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.BuildingTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.BuildingTypeId`

#### Summary

The building type element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.ExportMullions`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.ExportMullions`

#### Summary

Indicates if to specify the setting for exporting mullions.

#### Remarks

When this setting is on, mullions will be exported as shading surfaces. A "simplified" analytical
shading surface is produced from a mullion based on its centerline, thickness and offset.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.SimplifyCurtainSystems`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.SimplifyCurtainSystems`

#### Summary

Indicates if to specify the setting for simplified curtain systems.

#### Remarks

Curtain Walls and Curtain Systems are normally exported as several openings, panel by panel,
while for energy analysis all you need is one giant window. A curtain wall with 50 panels
gets exported as 50 openings, while 1 opening with the total opening area would be more appropriate.
When this setting is on, one "large" window/opening will be exported for a curtain wall/system

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.IncludeShadingSurfaces`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.IncludeShadingSurfaces`

#### Summary

Indicates if to set and get the setting for if shading surfaces should be included.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.Tier`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel.Tier`

#### Summary

Level of computation for energy analysis model.

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel`

#### Summary

Manage the analytical thermal model.

#### Remarks

The Export to gbXML and the Heating and Cooling Loads features
produces an analytical thermal model from the physical model
of a building. The analytical thermal model is composed of
spaces, zones and planar surfaces that represent the actual
volumetric elements of the building.
If there are currently no EnergyAnalysisDetailModel elements in
the document, when the first one is generated it will be considered
the persistent energy model (and maybe removed and recreated by
actions the user takes in the UI). If there is already a persistent
EnergyAnalysisDetailModel element in the document, the API can
generate other independent energy models, but they will not be
affected by the actions the user takes in the UI.
The EnergyAnalysisDetailModel will remain in the document until
it is discarded (either by the actions of the user, or by a call
to Document.Delete() ).

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.ExportMullions`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.ExportMullions`

#### Summary

Indicates if to specify the setting for exporting mullions.

#### Remarks

When this setting is on, mullions will be exported as shading surfaces. A "simplified" analytical
shading surface is produced from a mullion based on its centerline, thickness and offset.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.SimplifyCurtainSystems`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.SimplifyCurtainSystems`

#### Summary

Indicates if to specify the setting for simplified curtain systems.

#### Remarks

Curtain Walls and Curtain Systems are normally exported as several openings, panel by panel,
while for energy analysis all you need is one giant window. A curtain wall with 50 panels
gets exported as 50 openings, while 1 opening with the total opening area would be more appropriate.
When this setting is on, one "large" window/opening will be exported for a curtain wall/system

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.IncludeShadingSurfaces`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.IncludeShadingSurfaces`

#### Summary

Indicates if to set and get the setting for if shading surfaces should be included.

#### Remarks

The default is to include the shading surfaces.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.Tier`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.Tier`

#### Summary

Level of computation for energy analysis model.

#### Remarks

The default value is EnergyAnalysisModelTier::Final.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.EnergyModelType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.EnergyModelType`

#### Summary

It indicates whether the energy model is based on rooms/spaces or building elements.

#### Remarks

The default value is EnergyModelType::SpatialElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions.#ctor`

#### Summary

Constructs default options for energy analysis detailed model creation.

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions`

#### Summary

Options that govern the calculations for the generation of the energy analysis detail model.

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.EnergyModelType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyModelType`

#### Summary

This enum is used to define if the energy model is based on rooms/spaces, building elements or analysis mode in EnergyDataSettings.

#### Since

2016

### `F:Autodesk.Revit.DB.Analysis.EnergyModelType.AnalysisMode`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyModelType.AnalysisMode`

#### Summary

Energy model based on analysis mode in EnergyDataSettings.

### `F:Autodesk.Revit.DB.Analysis.EnergyModelType.BuildingElement`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyModelType.BuildingElement`

#### Summary

The building element based energy analytical model.

### `F:Autodesk.Revit.DB.Analysis.EnergyModelType.SpatialElement`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyModelType.SpatialElement`

#### Summary

Energy model based on rooms or spaces.

### `T:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelTier`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelTier`

#### Since

2012

#### Summary

Level of computation for energy analysis model.

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelTier.Final`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelTier.Final`

#### Summary

Constructions, schedules, non-graphical data.

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelTier.SecondLevelBoundaries`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelTier.SecondLevelBoundaries`

#### Summary

Analytical surfaces.

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelTier.FirstLevelBoundaries`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelTier.FirstLevelBoundaries`

#### Summary

Spaces and zones, e.g. minimal need for display. This refers to the analytical spaces.
The analytical spaces are produced from Rooms if you are using RAC, and from MEP Spaces if you are using RME.

### `F:Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelTier.NotComputed`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelTier.NotComputed`

#### Summary

Not computed.

### `T:Autodesk.Revit.DB.Analysis.AnalysisMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisMode`

#### Summary

This enum is used to define the Energy Analysis Model.

#### Since

2016

### `F:Autodesk.Revit.DB.Analysis.AnalysisMode.RoomsOrSpaces`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisMode.RoomsOrSpaces`

#### Summary

Energy Analysis Model based on spatial elements.
This mode uses volumes based on rooms or spaces defined in the building model.

### `F:Autodesk.Revit.DB.Analysis.AnalysisMode.ConceptualMassesAndBuildingElements`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisMode.ConceptualMassesAndBuildingElements`

#### Summary

Energy Analysis Model based on conceptual masses and building elements.

### `F:Autodesk.Revit.DB.Analysis.AnalysisMode.BuildingElements`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AnalysisMode.BuildingElements`

#### Summary

Energy Analysis Model based on building elements.

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.ThermalResistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.ThermalResistance`

#### Summary

The thermal resistance (R-value) of the material.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.SpecificHeatCapacity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.SpecificHeatCapacity`

#### Summary

The specific heat capacity of the material.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.Density`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.Density`

#### Summary

The density of the material.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.ThermalConductivity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.ThermalConductivity`

#### Summary

The thermal conductivity of the material.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.Thickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.Thickness`

#### Summary

The thickness of the material.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.Description`

#### Summary

The description of the material.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.MaterialName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial.MaterialName`

#### Summary

The name of the material.

#### Since

2024

### `T:Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial`

#### Summary

A description of a material with thermal properties in a composite construction.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.GetMaterialIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.GetMaterialIds`

#### Summary

Returns a list of ids of the associated materials to analytical construction.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.Roughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.Roughness`

#### Summary

The roughness value of the construction.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.Absorptance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.Absorptance`

#### Summary

The absorptance value of the construction.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.ThermalMass`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.ThermalMass`

#### Summary

The thermal mass value (Cth-value) of the construction.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.ThermalResistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.ThermalResistance`

#### Summary

The thermal resistance value (R-value) of the construction.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.HeatTransferCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.HeatTransferCoefficient`

#### Summary

The heat transfer coefficient value (U-value) of the construction.

#### Remarks

A heat transfer coefficient measured in W/m^2K

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.Description`

#### Summary

The description of the construction.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.ConstructionName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.ConstructionName`

#### Summary

The name of the construction

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.IsSchematic`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction.IsSchematic`

#### Summary

Indicates if this originates from a schematic or analytical construction.

#### Since

2024

### `T:Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction`

#### Summary

Represent an analytical construction as a composite of layered materials.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.EndTreatmentType.CreateDefaultEndTreatmentType(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.EndTreatmentType.CreateDefaultEndTreatmentType(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new EndTreatmentType object with a default name.

#### Parameter `ADoc`

The document.

#### Returns

The newly created type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.EndTreatmentType.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.EndTreatmentType.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new EndTreatmentType in a document and adds the input string to the endTreatment parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.EndTreatmentType.Create(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.EndTreatmentType.Create(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new EndTreatmentType in a document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.EndTreatmentType.EndTreatment`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.EndTreatmentType.EndTreatment`

#### Summary

String describing the end treatment

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.EndTreatmentType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.EndTreatmentType`

#### Summary

An end treatment type object that is used to hold information about the end treatment applied to bars that are connected to a coupler.

#### Since

2017

### `M:Autodesk.Revit.DB.Transform.AlmostEqual(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform.AlmostEqual(Autodesk.Revit.DB.Transform)`

#### Summary

Determines whether this transformation and the specified transformation are the same within the tolerance (1.0e-09).

#### Parameter `right`

The transformation to compare with this transformation.

#### Returns

True if the two transformations are equal; otherwise, false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the specified transformation is `null` .

#### Remarks

The tolerance is applied memberwise for comparison.

### `M:Autodesk.Revit.DB.Transform.ScaleBasisAndOrigin(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform.ScaleBasisAndOrigin(System.Double)`

#### Summary

Scales the basis vectors and the origin of this transformation and returns the result.

#### Parameter `scale`

The scale value.

#### Returns

The transformation equal to the composition of the two transformations.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the specified value is an infinite number.

#### Remarks

The resulting transformation is equivalent to the application of this transformation
and then the uniform scale, in this order.

### `M:Autodesk.Revit.DB.Transform.ScaleBasis(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform.ScaleBasis(System.Double)`

#### Summary

Scales the basis vectors of this transformation and returns the result.

#### Parameter `scale`

The scale value.

#### Returns

The transformation equal to the composition of the two transformations.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the specified value is an infinite number.

#### Remarks

The resulting transformation is equivalent to the application of the uniform scale
and then this transformation, in this order.

### `M:Autodesk.Revit.DB.Transform.Multiply(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform.Multiply(Autodesk.Revit.DB.Transform)`

#### Summary

Multiplies this transformation by the specified transformation and returns the result.

#### Parameter `right`

The specified transformation.

#### Returns

The transformation equal to the composition of the two transformations.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the handle of the specified transformation is `null` .

#### Remarks

The combined transformation has the same effect as applying the right transformation first,
and the left transformation, second. So, (T1(T2(p)) = (T1 * T2) (p).

### `M:Autodesk.Revit.DB.Transform.op_Multiply(Autodesk.Revit.DB.Transform,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform.op_Multiply(Autodesk.Revit.DB.Transform,Autodesk.Revit.DB.Transform)`

#### Summary

Multiplies the two specified transforms.

#### Parameter `left`

The first transformation.

#### Parameter `right`

The second transformation.

#### Returns

The transformation equal to the composition of the two transformations.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the handle of the first or second transformation is `null` .

#### Remarks

The combined transformation has the same effect as applying the right transformation first,
and the left transformation, second. So, (T1(T2(p)) = (T1 * T2) (p).

### `P:Autodesk.Revit.DB.Transform.Inverse`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform.Inverse`

#### Summary

The inverse transformation of this transformation.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this transformation is not conformal or invertible.

#### Remarks

The transformation matrix A is invertible if there exists a transformation matrix B
such that A*B = B*A = I (identity).

### `P:Autodesk.Revit.DB.Transform.Determinant`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform.Determinant`

#### Summary

The determinant of this transformation.

#### Remarks

The geometric meaning of a determinant is as the scale factor for volume
when applied as linear transformation.

### `P:Autodesk.Revit.DB.Transform.IsConformal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform.IsConformal`

#### Summary

The boolean value that indicates whether this transformation is conformal.

#### Remarks

This property is true if this transformation can be decomposed as the product of
a rigid-body motion, uniform scale and reflection. Such transformation preserves
angles between vectors.

### `P:Autodesk.Revit.DB.Transform.HasReflection`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform.HasReflection`

#### Summary

The boolean value that indicates whether this transformation produces reflection.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this transformation is not conformal and the reflection is undefined.

#### Remarks

Reflection transformation changes the handedness of a coordinate system.

### `P:Autodesk.Revit.DB.Transform.Scale`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform.Scale`

#### Summary

The real number that represents the scale of the transformation.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this transformation is not conformal and the scale is undefined.

#### Remarks

When the transformation is conformal and can be decomposed as the product of
a rigid-body motion, uniform scale and reflection, this property returns the scale
value of the uniform scale transformation.

### `P:Autodesk.Revit.DB.Transform.IsTranslation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform.IsTranslation`

#### Summary

The boolean value that indicates whether this transformation is a translation.

#### Remarks

This property is true if the only effect of transformation is translation. It checks that the
basis of the transform is identity. The translation vector may be zero (which would make this
an identity transformation) or nonzero (which would make this a non-trivial translation).

### `P:Autodesk.Revit.DB.Transform.IsIdentity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform.IsIdentity`

#### Summary

The boolean value that indicates whether this transformation is an identity.

#### Remarks

The identity transformation does not change a point or a vector that it is applied to.

### `M:Autodesk.Revit.DB.Transform.OfVector(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform.OfVector(Autodesk.Revit.DB.XYZ)`

#### Summary

Applies the transform to the vector

#### Parameter `vec`

The vector to be transformed

#### Returns

The new vector after transform

#### Remarks

Transformation of a vector is not affected by the translational part of the transformation.

### `M:Autodesk.Revit.DB.Transform.OfPoint(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform.OfPoint(Autodesk.Revit.DB.XYZ)`

#### Summary

Applies the transformation to the point and returns the result.

#### Parameter `point`

The point to transform.

#### Returns

The transformed point.

#### Remarks

Transformation of a point is affected by the translational part of the transformation.

### `M:Autodesk.Revit.DB.Transform.CreateReflection(Autodesk.Revit.DB.Plane)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform.CreateReflection(Autodesk.Revit.DB.Plane)`

#### Summary

Creates a transform that represents a reflection across the given plane.

#### Parameter `plane`

The plane.

#### Returns

The new transform.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2014

### `M:Autodesk.Revit.DB.Transform.CreateRotationAtPoint(Autodesk.Revit.DB.XYZ,System.Double,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform.CreateRotationAtPoint(Autodesk.Revit.DB.XYZ,System.Double,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a transform that represents a rotation about the given axis at the specified point.

#### Parameter `axis`

The rotation axis.

#### Parameter `angle`

The angle.

#### Parameter `origin`

The origin point.

#### Returns

The new transform.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for angle is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

axis has zero length.

#### Since

2014

### `M:Autodesk.Revit.DB.Transform.CreateRotation(Autodesk.Revit.DB.XYZ,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform.CreateRotation(Autodesk.Revit.DB.XYZ,System.Double)`

#### Summary

Creates a transform that represents a rotation about the given axis at (0, 0, 0).

#### Parameter `axis`

The rotation axis.

#### Parameter `angle`

The angle.

#### Returns

The new transform.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for angle is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

axis has zero length.

#### Since

2014

### `M:Autodesk.Revit.DB.Transform.CreateTranslation(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform.CreateTranslation(Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a transform that represents a translation via the specified vector.

#### Parameter `vector`

The translation vector.

#### Returns

The new transform.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2014

### `P:Autodesk.Revit.DB.Transform.Identity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform.Identity`

#### Summary

The identity transformation.

#### Remarks

The identity transformation does not change a point or a vector that it is applied to.

### `P:Autodesk.Revit.DB.Transform.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform.Origin`

#### Summary

Defines the origin of the old coordinate system in the new coordinate system.

#### Remarks

This corresponds to the fourth column vector of the conventional 3x4 matrix
representation. Also, this is the translation component of the transformation.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the transform is internally marked as read-only.

### `P:Autodesk.Revit.DB.Transform.Basis(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform.Basis(System.Int32)`

#### Summary

Defines the basis of the old coordinate system in the new coordinate system.

#### Parameter `idx`

The index of the basis vector: 0, 1 or 2.

#### Remarks

This corresponds to the first three column vectors of the conventional 3x4 matrix
representation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the given index is larger than 2 in the getter and setter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the transform is internally marked as read-only.

### `P:Autodesk.Revit.DB.Transform.BasisZ`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform.BasisZ`

#### Summary

The basis of the Z axis of this transformation.

#### Remarks

The Z axis of the old coordinate system in the new coordinate system,
or the 3rd column of the conventional 3x4 matrix representation.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the transform is internally marked as read-only.

### `P:Autodesk.Revit.DB.Transform.BasisY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform.BasisY`

#### Summary

The basis of the Y axis of this transformation.

#### Remarks

The Y axis of the old coordinate system in the new coordinate system,
or the 2nd column of the conventional 3x4 matrix representation.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the transform is internally marked as read-only.

### `P:Autodesk.Revit.DB.Transform.BasisX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform.BasisX`

#### Summary

The basis of the X axis of this transformation.

#### Remarks

The X axis of the old coordinate system in the new coordinate system,
or the 1st column of the conventional 3x4 matrix representation.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the transform is internally marked as read-only.

### `M:Autodesk.Revit.DB.Transform.#ctor(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform.#ctor(Autodesk.Revit.DB.Transform)`

#### Summary

The copy constructor.

### `T:Autodesk.Revit.DB.Transform`

Member kind: type
Symbol: `Autodesk.Revit.DB.Transform`

#### Summary

A transformation of the affine 3-space.

### `M:Autodesk.Revit.DB.Plane.CreateByOriginAndBasis(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plane.CreateByOriginAndBasis(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a Plane object defined by the two orthogonal unit vectors and passing through the origin point supplied as arguments.

#### Remarks

The parametric equation of the plane is S(u, v) = origin + u*basisX + v*basisY. The plane's normal is defined as basisX.Cross(basisY).

#### Parameter `origin`

Plane origin. Expected to lie within the Revit design limits `M:Autodesk.Revit.DB.XYZ.IsWithinLengthLimits(Autodesk.Revit.DB.XYZ)` .

#### Parameter `basisX`

First of the two unit vectors that define the plane. Must be orthogonal to the second one.

#### Parameter `basisY`

Second of the two unit vectors that define the plane. Must be orthogonal to the first one.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input point lies outside of Revit design limits.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

basisX is not length 1.0.
-or-
basisY is not length 1.0.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The vectors basisX and basisY are not perpendicular.

#### Since

2017

### `M:Autodesk.Revit.DB.Plane.CreateByNormalAndOrigin(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plane.CreateByNormalAndOrigin(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Constructs a Plane object from a normal and an origin represented as XYZ objects. Follows the standard conventions for a planar surface.
The constructed Plane object will pass through origin and be perpendicular to normal. The X and Y axes of the plane will be defined arbitrarily.

#### Remarks

This function does not guarantee a specific parameterization of the created Plane. Use Plane.Create(Frame) to enforce a specific parameterization of the created Plane object.

#### Parameter `normal`

Plane normal. Expected to be a valid non-zero length vector. Doesn't need to be a unit vector.

#### Parameter `origin`

Plane origin. Expected to lie within the Revit design limits `M:Autodesk.Revit.DB.XYZ.IsWithinLengthLimits(Autodesk.Revit.DB.XYZ)` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input point lies outside of Revit design limits.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

normal has zero length.

#### Since

2017

### `M:Autodesk.Revit.DB.Plane.CreateByThreePoints(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plane.CreateByThreePoints(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a Plane object passing through three points supplied as arguments.

#### Remarks

The points supplied as arguments must fully define a plane: they may not lie on a straight line or be too close to each other. The points must lie within the Revit design limits.
This function does not guarantee a specific parameterization of the created Plane. Use Plane.Create(Frame) to enforce a specific parameterization of the created Plane object.
All three points are expected to lie within the Revit design limits `M:Autodesk.Revit.DB.XYZ.IsWithinLengthLimits(Autodesk.Revit.DB.XYZ)` .

#### Parameter `point1`

First of the three points that define a unique plane. The created Plane object will pass through these points.

#### Parameter `point2`

Second of the three points that define a unique plane.

#### Parameter `point3`

Third of the three points that define a unique plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input point lies outside of Revit design limits.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Throws if the input points do not define a unique plane.
This is typically caused by points being too close to each other, or all three points being on or close to a straight line.

#### Since

2017

### `M:Autodesk.Revit.DB.Plane.Create(Autodesk.Revit.DB.Frame)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plane.Create(Autodesk.Revit.DB.Frame)`

#### Summary

Creates a Plane object defined by a local frame of reference.

#### Remarks

The parametric equation of the plane is S(u, v) = Frame.Origin + u*Frame.BasisX + v*Frame.BasisY. Frame.BasisZ defines the plane's normal.

#### Parameter `frameOfReference`

frameOfReference is an orthonormal frame that defines a local coordinate system for the plane being constructed.
Frame.Origin is a point on plane.

Frame.BasisZ defines the plane's normal, while Frame.BasisX and Frame.BasisY are orthogonal to the normal.

The frame may be either left-handed or right-handed (see Frame.IsRightHanded).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This Frame object may not be used as a local frame of reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Plane.YVec`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plane.YVec`

#### Summary

Axis defining the second parametric direction of the plane.

#### Since

2016

### `P:Autodesk.Revit.DB.Plane.XVec`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plane.XVec`

#### Summary

Axis defining the first parametric direction of the plane.

#### Since

2016

### `P:Autodesk.Revit.DB.Plane.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plane.Origin`

#### Summary

Plane origin.

#### Since

2016

### `P:Autodesk.Revit.DB.Plane.Normal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plane.Normal`

#### Summary

Plane normal.

#### Since

2016

### `T:Autodesk.Revit.DB.Plane`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plane`

#### Summary

A Planar surface.

#### Remarks

The parametric equation of the plane is S(u, v) = origin + u*xVec + v*yVec.

#### Since

2016

### `M:Autodesk.Revit.DB.Surface.GetBoundingBoxUV`

Member kind: method
Symbol: `Autodesk.Revit.DB.Surface.GetBoundingBoxUV`

#### Summary

Gets the UV bounding box of the surface.

#### Remarks

The UV bounding box may not be set.

#### Returns

The UV bounding box of the surface.

#### Since

2021

### `M:Autodesk.Revit.DB.Surface.ProjectWithGuessPoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV@,System.Double@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Surface.ProjectWithGuessPoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV@,System.Double@)`

#### Summary

Project a 3D point orthogonally onto a surface (to find the nearest point).
This method is meant to be used when a good approximate solution for the projection is available.
Throws InvalidOperationException if the projection fails.

#### Parameter `point`

The point to project.

#### Parameter `guessUV`

The calculation will look for a project near the provided UV.

#### Parameter `uv`

The surface coordinates of the projected point.

#### Parameter `distance`

Holds the distance from input point to its projection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The projection failed.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Surface.Project(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.UV@,System.Double@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Surface.Project(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.UV@,System.Double@)`

#### Summary

Project a 3D point orthogonally onto a surface (to find the nearest point).
Throws InvalidOperationException if the projection fails.

#### Parameter `point`

The point to project.

#### Parameter `uv`

The surface coordinates of the projected point.

#### Parameter `distance`

Holds the distance from input point to its projection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The projection failed.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Surface.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Surface.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Surface.OrientationMatchesParametricOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Surface.OrientationMatchesParametricOrientation`

#### Summary

Indicates whether this Surface's orientation is the same as or opposite to its parametric orientation.

#### Remarks

(Revit uses only orientable surfaces).
At any point on a surface, the surface's orientation is specified by a choice of the direction for the normal vector
at that point.The direction can either match or be opposite to the direction of the parametric normal vector,
which is the cross product of the surface's first partial derivatives: dS/du x dS/dv.
The parametric normal vectors define the parametric orientation.
A surface's orientation is then defined by getOrientationMatchesParametricOrientation() -
if getOrientationMatchesParametricOrientation() is true, the surface's orientation is the same as its
parametric orientation; otherwise it is opposite to its parametric orientation.
The purpose of this information to an API user:
Some systems, Industry Foundation Classes (IFC) for example, may only have parametric orientation for its surfaces.
In such a system, the surface normal will always be the parametric normal, whereas
in Revit, the surface normal will be the same as or opposite to the parametric normal according as
getOrientationMatchesParametricOrientation is true or false.
A user who is not familiar with Revit's orientation conventions might assume that Revit's normal vector is
the same as the parametric normal, which is not always correct. Hence, this information is needed if and when
the user tries to export Revit Geometry to IFC, for example.
See also Face::OrientationMatchesSurfaceOrientation.

#### Since

2018

### `T:Autodesk.Revit.DB.Surface`

Member kind: type
Symbol: `Autodesk.Revit.DB.Surface`

#### Summary

A mathematical representation of a surface.

#### Remarks

This geometric object is not bounded by edges or edge loops. A bounded surface obtained from a Revit element
will be represented by a `T:Autodesk.Revit.DB.Face` instead.

#### Since

2016

### `M:Autodesk.Revit.DB.Line.CreateUnbound(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Line.CreateUnbound(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new instance of an unbound linear curve.

#### Parameter `origin`

The origin of the unbound line.

#### Parameter `direction`

The direction of the unbound line.

#### Returns

The new unbound line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

direction has zero length.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Vector and origin cannot form a proper unbound line.

#### Since

2014

### `M:Autodesk.Revit.DB.Line.CreateBound(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Line.CreateBound(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new instance of a bound linear curve.

#### Parameter `endpoint1`

The first line endpoint.

#### Parameter `endpoint2`

The second line endpoint.

#### Returns

The new bound line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Since

2014

### `P:Autodesk.Revit.DB.Line.Direction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Line.Direction`

#### Summary

Returns the direction of the line.

### `P:Autodesk.Revit.DB.Line.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.Line.Origin`

#### Summary

Returns the origin of the line.

### `T:Autodesk.Revit.DB.Line`

Member kind: type
Symbol: `Autodesk.Revit.DB.Line`

#### Summary

A line in space.

### `M:Autodesk.Revit.DB.Curve.ComputeClosestPoints(Autodesk.Revit.DB.Curve,System.Boolean,System.Boolean,System.Boolean,System.Collections.Generic.IList{Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Curve.ComputeClosestPoints(Autodesk.Revit.DB.Curve,System.Boolean,System.Boolean,System.Boolean,System.Collections.Generic.IList{Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves}@)`

#### Summary

Find the closest points between two curves.
Closest points mean closest pairs of points, each pair consisting of a point on this, say P1, and a point on other curve, say P2.
P1 and P2 are closest locally.
Each pairs of closest points will be represented by the corresponding parameter values with respect to the two curves and the 3d points.
A closest pair is also known as a pair of critical points of the distance function between points of the two curves.
If the input parameter returnAllCriticalPoints is set to false, then the function will return only pairs with minimum distance.

#### Parameter `otherCurve`

The specified curve used to compute closest points to this curve.

#### Parameter `withinThisCurveBounds`

If this parameter is true only the solutions that are between this curve bounds will be returned.
This curve must be bound if this parameter is true.

#### Parameter `withinOtherCurveBounds`

If this parameter is true only the solutions that are between other curve bounds will be returned.
The other curve must be bound if this parameter is true.

#### Parameter `returnAllCriticalPnts`

The input parameter returnAllCriticalPnts is used to tell if all the critical points of the
distance function are to be returned.

#### Parameter `resultList`

Output parameter that will contain the results collection.

#### Remarks

The output list of closest points contains one entry for each pair of closest points.
The following is the meaning of every ClosestPointsPairBetweenTwoCurves's members:
XYZPointOnFirstCurve is the closest point on the first curve;

XYZPointOnSecondCurve is the closest point on the second curve;

ParameterOnFirstCurve is the raw (not normalized) parameter on the first curve

ParameterOnSecondCurve is the raw (not normalized) parameter on the second curve

Distance is the distance from the closest point on the first curve to the closest point on the second curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when otherCurve argument is null.
Thrown when resultArray is null.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown when withinThisCurveBounds is true and this curve is unbounded.
Thrown when withinOtherCurveBounds is true and other curve is unbounded.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the method failed. For example the problem has infinitely many solutions
such as two parallel lines or two concentric circles, or in other singular cases that the method currently cannot handle,
such as evaluating the closest points between a spline and a line, and the spline contains
a flat segment (all points on the segment have zero curvature), and the closest points
lie within that flat segment.

#### Since

2018.1
