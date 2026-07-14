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
Shard: 20
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `T:Autodesk.Revit.DB.ModelLine`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelLine`

#### Summary

Represents a ModelLine within Autodesk Revit.

#### Remarks

Geometry-related functionality is provided by the geometry curve object from the
ModelCurve::geometryCurve property.

### `T:Autodesk.Revit.DB.ModelHermiteSpline`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelHermiteSpline`

#### Summary

Represents a ModelHermiteSpline within Autodesk Revit.

#### Remarks

Currently it's just a place holder for specific type.
All the geometry-related functionality is provided by geometry curve object from
ModelCurve::geometryCurve property.

### `T:Autodesk.Revit.DB.ModelEllipse`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelEllipse`

#### Summary

Represents a ModelEllipse within Autodesk Revit.

#### Remarks

Currently it's just a place holder for specific type.
All the geometry-related functionality is provided by geometry curve object from
ModelCurve::geometryCurve property.

### `T:Autodesk.Revit.DB.ModelArc`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelArc`

#### Summary

Represents a ModelArc within Autodesk Revit.

#### Remarks

Currently it's just a place holder for specific type.
All the geometry-related functionality is provided by geometry curve object from
ModelCurve::geometryCurve property.

### `M:Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ImportOptions3DM,Autodesk.Revit.DB.LinkLoadResult@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.ImportOptions3DM,Autodesk.Revit.DB.LinkLoadResult@)`

#### Summary

Creates a new instance of 3DM link type from an external resource reference
and loads the linked file.

#### Remarks

This function creates a new 3DM link type as well as a new instance of this 3DM link type.
The new instance of 3DM link type is returned by this function and the element id of the new 3DM link type
is contained in the LinkLoadResult.

If the given external resource reference of the 3DM link is already used by an existing 3DM link type,
a new instance of this existing 3DM link type is created and returned. The element id of the existing
3DM link type is contained in the LinkLoadResult.

This function regenerates the input document.

#### Parameter `document`

The document in which to create the 3DM link.

#### Parameter `DBView`

The view into which the 3DM link will be created.

#### Parameter `resourceReference`

The external resource reference describing the source of the 3DM link.

#### Parameter `options`

Various import options applicable to the 3DM format.
If `null` , all options will be set to their respective default values.

#### Parameter `linkLoadResult`

An object containing the results of creating and loading
the 3DM link. It contains the ElementId of the new created 3DM link type.

#### Returns

The new instance of 3DM link type created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
document is in an edit mode.
-or-
Import is temporarily disabled.
-or-
The view is not printable.
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
The server referenced by the ExternalResourceReference does not exist or
does not implement IExternalResourceServer.
-or-
The server referenced by the ExternalResourceReference cannot support CAD links.
-or-
The ExternalResourceReference (resourceReference) is not in a format
that is supported by its server.

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

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The 3DM Import/Link module is not available in the installed Revit.

#### Since

2022

### `M:Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.STLImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.STLImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

#### Summary

Creates a new instance of STL link type from an external resource reference
and loads the linked file.

#### Remarks

This function creates a new STL link type as well as a new instance of this STL link type.
The new instance of STL link type is returned by this function and the element id of the new STL link type
is contained in the LinkLoadResult.

If the given external resource reference of the STL link is already used by an existing STL link type,
a new instance of this existing STL link type is created and returned. The element id of the existing
STL link type is contained in the LinkLoadResult.

This function regenerates the input document.

#### Parameter `document`

The document in which to create the STL link.

#### Parameter `DBView`

The view into which the STL link will be created.

#### Parameter `resourceReference`

The external resource reference describing the source of the STL link.

#### Parameter `options`

Various import options applicable to the STL format.
If `null` , all options will be set to their respective default values.

#### Parameter `linkLoadResult`

An object containing the results of creating and loading
the STL link. It contains the ElementId of the new created STL link type.

#### Returns

The new instance of STL link type created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
document is in an edit mode.
-or-
Import is temporarily disabled.
-or-
The view is not printable.
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
The server referenced by the ExternalResourceReference does not exist or
does not implement IExternalResourceServer.
-or-
The server referenced by the ExternalResourceReference cannot support CAD links.
-or-
The ExternalResourceReference (resourceReference) is not in a format
that is supported by its server.

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

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The STL Import/Link module is not available in the installed Revit.

#### Since

2023

### `M:Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.SKPImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.SKPImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

#### Summary

Creates a new instance of SKP link type from an external resource reference
and loads the linked file.

#### Remarks

This function creates a new SKP link type as well as a new instance of this SKP link type.
The new instance of SKP link type is returned by this function and the element id of the new SKP link type
is contained in the LinkLoadResult.

If the given external resource reference of the SKP link is already used by an existing SKP link type,
a new instance of this existing SKP link type is created and returned. The element id of the existing
SKP link type is contained in the LinkLoadResult.

This function regenerates the input document.

#### Parameter `document`

The document in which to create the SKP link.

#### Parameter `DBView`

The view into which the SKP link will be created.

#### Parameter `resourceReference`

The external resource reference describing the source of the SKP link.

#### Parameter `options`

Various import options applicable to the SKP format.
If `null` , all options will be set to their respective default values.

#### Parameter `linkLoadResult`

An object containing the results of creating and loading
the SKP link. It contains the ElementId of the new created SKP link type.

#### Returns

The new instance of SKP link type created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
document is in an edit mode.
-or-
Import is temporarily disabled.
-or-
The view is not printable.
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
The server referenced by the ExternalResourceReference does not exist or
does not implement IExternalResourceServer.
-or-
The server referenced by the ExternalResourceReference cannot support CAD links.
-or-
The ExternalResourceReference (resourceReference) is not in a format
that is supported by its server.

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

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The SKP Import/Link module is not available in the installed Revit.

#### Since

2018

### `M:Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.SATImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.SATImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

#### Summary

Creates a new instance of SAT link type from an external resource reference
and loads the linked file.

#### Remarks

This function creates a new SAT link type as well as a new instance of this SAT link type.
The new instance of SAT link type is returned by this function and the element id of the new SAT link type
is contained in the LinkLoadResult.

If the given external resource reference of the DWG link is already used by an existing SAT link type,
a new instance of this existing SAT link type is created and returned. The element id of the existing
SAT link type is contained in the LinkLoadResult.

This function regenerates the input document.

#### Parameter `document`

The document in which to create the SAT link.

#### Parameter `DBView`

The view into which the SAT link will be created.

#### Parameter `resourceReference`

The external resource reference describing the source of the DGN link.

#### Parameter `options`

Various import options applicable to the SAT format.
If `null` , all options will be set to their respective default values.

#### Parameter `linkLoadResult`

An object containing the results of creating and loading
the SAT link. It contains the ElementId of the new created SAT link type.

#### Returns

The new instance of SAT link type created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
document is in an edit mode.
-or-
Import is temporarily disabled.
-or-
The view is not printable.
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
The server referenced by the ExternalResourceReference does not exist or
does not implement IExternalResourceServer.
-or-
The server referenced by the ExternalResourceReference cannot support CAD links.
-or-
The ExternalResourceReference (resourceReference) is not in a format
that is supported by its server.

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

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The SAT Import/Link module is not available in the installed Revit.

#### Since

2018

### `M:Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.OBJImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.OBJImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

#### Summary

Creates a new instance of OBJ link type from an external resource reference
and loads the linked file.

#### Remarks

This function creates a new OBJ link type as well as a new instance of this OBJ link type.
The new instance of OBJ link type is returned by this function and the element id of the new OBJ link type
is contained in the LinkLoadResult.

If the given external resource reference of the OBJ link is already used by an existing OBJ link type,
a new instance of this existing OBJ link type is created and returned. The element id of the existing
OBJ link type is contained in the LinkLoadResult.

This function regenerates the input document.

#### Parameter `document`

The document in which to create the OBJ link.

#### Parameter `DBView`

The view into which the OBJ link will be created.

#### Parameter `resourceReference`

The external resource reference describing the source of the OBJ link.

#### Parameter `options`

Various import options applicable to the OBJ format.
If `null` , all options will be set to their respective default values.

#### Parameter `linkLoadResult`

An object containing the results of creating and loading
the OBJ link. It contains the ElementId of the new created OBJ link type.

#### Returns

The new instance of OBJ link type created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
document is in an edit mode.
-or-
Import is temporarily disabled.
-or-
The view is not printable.
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
The server referenced by the ExternalResourceReference does not exist or
does not implement IExternalResourceServer.
-or-
The server referenced by the ExternalResourceReference cannot support CAD links.
-or-
The ExternalResourceReference (resourceReference) is not in a format
that is supported by its server.

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

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The OBJ Import/Link module is not available in the installed Revit.

#### Since

2023

### `M:Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.DGNImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.DGNImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

#### Summary

Creates a new instance of DGN link type from an external resource reference
and loads the linked file.

#### Remarks

This function creates a new DGN link type as well as a new instance of this DGN link type.
The new instance of DGN link type is returned by this function and the element id of the new DGN link type
is contained in the LinkLoadResult.

If the given external resource reference of the DWG link is already used by an existing DGN link type,
a new instance of this existing DGN link type is created and returned. The element id of the existing
DGN link type is contained in the LinkLoadResult.

This function regenerates the input document.

#### Parameter `document`

The document in which to create the DGN link.

#### Parameter `DBView`

The view into which the DGN link will be created.

#### Parameter `resourceReference`

The external resource reference describing the source of the DGN link.

#### Parameter `options`

Various import options applicable to the DGN format.
If `null` , all options will be set to their respective default values.

#### Parameter `linkLoadResult`

An object containing the results of creating and loading
the DGN link. It contains the ElementId of the new created DGN link type.

#### Returns

The new instance of DGN link type created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
document is in an edit mode.
-or-
Import is temporarily disabled.
-or-
The view is not printable.
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
The server referenced by the ExternalResourceReference does not exist or
does not implement IExternalResourceServer.
-or-
The server referenced by the ExternalResourceReference cannot support CAD links.
-or-
The ExternalResourceReference (resourceReference) is not in a format
that is supported by its server.

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

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The DGN Import/Link module is not available in the installed Revit.

#### Since

2018

### `M:Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.View)`

#### Summary

Creates a new instance of an existing DWG link type.

#### Remarks

This function regenerates the input document.

#### Parameter `document`

The document in which to create the new instacne of DWG link type.

#### Parameter `typeId`

The element id of the existing DWG link type.

#### Parameter `DBView`

The view into which the new instance of DWG link type will be created.

#### Returns

The new instance of the given DWG link type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
document is in an edit mode.
-or-
The view is not printable.
-or-
The element id is not of a valid CADLinkType.

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

2018

### `M:Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.DWGImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.DWGImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

#### Summary

Creates a new instance of DWG link type from an external resource reference
and loads the linked file.

#### Remarks

This function creates a new DWG link type as well as a new instance of this DWG link type.
The new instance of DWG link type is returned by this function and the element id of the new DWG link type
is contained in the LinkLoadResult.

If the given external resource reference of the DWG link is already used by an existing DWG link type,
a new instance of this existing DWG link type is created and returned. The element id of the existing
DWG link type is contained in the LinkLoadResult.

This function regenerates the input document.

#### Parameter `document`

The document in which to create the DWG link.

#### Parameter `DBView`

The view into which the DWG link will be created.

#### Parameter `resourceReference`

The external resource reference describing the source of the DWG link.

#### Parameter `options`

Various import options applicable to the DWG format.
If `null` , all options will be set to their respective default values.

#### Parameter `linkLoadResult`

An object containing the results of creating and loading
the DWG link. It contains the ElementId of the new created DWG link type.

#### Returns

The new instance of DWG link type created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
document is in an edit mode.
-or-
Import is temporarily disabled.
-or-
The view is not printable.
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The line weights are not valid; either it contains an invalid number of line weights, or a line weight outside the valid range.
-or-
The scale is not valid as a CustomScale for use during import.
-or-
The server referenced by the ExternalResourceReference does not exist or
does not implement IExternalResourceServer.
-or-
The server referenced by the ExternalResourceReference cannot support CAD links.
-or-
The ExternalResourceReference (resourceReference) is not in a format
that is supported by its server.

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

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The DWG Import/Link module is not available in the installed Revit.

#### Since

2018

### `M:Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.String,Autodesk.Revit.DB.DWGImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.View,System.String,Autodesk.Revit.DB.DWGImportOptions,Autodesk.Revit.DB.LinkLoadResult@)`

#### Summary

Creates a new instance of DWG or DXF link type from a file path and loads the linked file.

#### Remarks

This function creates a new DWG or DXF link type as well as a new instance of this link type.
The new instance of DWG or DXF link type is returned by this function and the element id of the new DWG
or DXF link type is contained in the LinkLoadResult.

If the given full path of the DWG or DXF file to link is already used by an existing DWG or DXF link type,
a new instance of this existing DWG or DXF link type will be created and returned. The element id of the existing
DWG or DXF link type is contained in the LinkLoadResult.

This function regenerates the input document.

#### Parameter `document`

The document in which to create the DWG or DXF link.

#### Parameter `DBView`

The view into which the DWG or DXF link will be created.

#### Parameter `path`

The full path of the DWG or DXF file to link. The path must exist and must be a valid DWG or DXF file.

#### Parameter `options`

Various import options applicable to the DWG format.
If `null` , all options will be set to their respective default values.

#### Parameter `linkLoadResult`

An object containing the results of creating and loading
the DWG or DXF link. It contains the ElementId of the new created DWG or DXF link type.

#### Returns

The new instance of DWG or DXF link type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
document is in an edit mode.
-or-
Import is temporarily disabled.
-or-
The view is not printable.
-or-
NullOrEmpty
-or-
Not a valid file for DWG import (.dwg and .dxf files are valid).
-or-
ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view.
-or-
One or more strings describing layer selection is invalid or empty.
-or-
The line weights are not valid; either it contains an invalid number of line weights, or a line weight outside the valid range.
-or-
The scale is not valid as a CustomScale for use during import.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given path does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Place by shared, and the host model and the link do not share the same coordinate system.
Or place by shared, and the shared coordinates of the host model do not match the GIS coordinate system of the link.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

The DWG Import/Link module is not available in the installed Revit.

#### Since

2018

### `P:Autodesk.Revit.DB.ImportInstance.IsLinked`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImportInstance.IsLinked`

#### Summary

Identifies whether this instance is a linked object rather than imported one.

#### Remarks

True if the instance was imported as a link to an external file.
False if the instance was imported as a copy of data from an external file.

#### Since

2011

### `M:Autodesk.Revit.DB.ImportInstance.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportInstance.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

#### Summary

Sets the visibility for the import instance in a family document.

#### Remarks

The visibility of the import instance geometry can be changed for different
types of views and detail levels in the family document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when visibility is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration failed, or the import instance is in a project document.

### `M:Autodesk.Revit.DB.ImportInstance.GetVisibility`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImportInstance.GetVisibility`

#### Summary

Gets the visibility for the import instance in a family document.

#### Returns

A copy of visibility settings for the import instance in a family document.

### `T:Autodesk.Revit.DB.ImportInstance`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImportInstance`

#### Summary

An element created during either import or link operation.
It is an instance of CADLinkType.

### `M:Autodesk.Revit.DB.ImageType.Unload`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageType.Unload`

#### Summary

Unload the linked image.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ImageType is not a link.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing this ImageType is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing this ImageType is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing this ImageType has no open transaction.

#### Since

2021

### `M:Autodesk.Revit.DB.ImageType.ReloadFrom(Autodesk.Revit.DB.ImageTypeOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageType.ReloadFrom(Autodesk.Revit.DB.ImageTypeOptions)`

#### Summary

Reloads the image in the ImageType from a new image file, and for a new `P:Autodesk.Revit.DB.ImageType.PageNumber` .

#### Remarks

If reload fails (because the image file doesn't exist, cannot be read, or does not have the requested page number),
the currently loaded image will remain unchanged.

#### Parameter `options`

Options that specify what image to load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

options.Path is an empty string.
-or-
The file represented by options.Path is not a supported image file type.
-or-
The image file represented by options.Path is a password protected PDF file.
-or-
The image file represented by options.Path does not contain the page specified by options.PageNumber.
-or-
The image file represented by options.Path could not be read and may be corrupt.
-or-
An error occurred while handling the external resource corresponding to the image.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file represented by options.Path does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ImageType was not loaded from a file.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing this ImageType is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing this ImageType is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing this ImageType has no open transaction.

#### Since

2020

### `M:Autodesk.Revit.DB.ImageType.Reload`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageType.Reload`

#### Summary

Reloads the ImageType from the file found at the location specified by the `P:Autodesk.Revit.DB.ImageType.Path` property,
using the same `P:Autodesk.Revit.DB.ImageType.PageNumber` and resolution.

#### Remarks

If reload fails (because the image file doesn't exist, cannot be read, or does not have the correct page),
the currently loaded image will remain unchanged.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

The file represented by Path does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This ImageType was not loaded from a file.
-or-
The file represented by Path is not a supported image file type.
-or-
The image file represented by Path is a password protected PDF file.
-or-
The image file represented by Path does not contain the page specified by PageNumber.
-or-
The image file represented by Path could not be read and may be corrupt.
-or-
An error occurred while handling the external resource corresponding to the image.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing this ImageType is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing this ImageType is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing this ImageType has no open transaction.

#### Since

2015

### `M:Autodesk.Revit.DB.ImageType.CanReload`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageType.CanReload`

#### Summary

Check whether the ImageType can be reloaded from file.

#### Remarks

The test first determines the candidate path for reloading the ImageType. Then the test checks that the
corresponding file is a valid image file, that it is unencrypted, and that it contains the page corresponding to `P:Autodesk.Revit.DB.ImageType.PageNumber` .

#### Returns

True if the ImageType can be reloaded. False, otherwise.

#### Since

2020

### `M:Autodesk.Revit.DB.ImageType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ImageTypeOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ImageTypeOptions)`

#### Summary

Creates a new ImageType element and loads the image into it.

#### Remarks

The ImageType will be created but will not be placed into any view.

#### Parameter `document`

The document.

#### Parameter `options`

Options that specify what image to load.

#### Returns

The new ImageType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The image filename is an empty string.
-or-
The image file is not a supported image file type.
-or-
The image file is password protected.
-or-
The image file does not contain the requested page number.
-or-
The image file could not be read and may be corrupt.
-or-
An error occurred while handling the external resource corresponding to the image.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The image file does not exist.

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

2020

### `P:Autodesk.Revit.DB.ImageType.Resolution`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageType.Resolution`

#### Summary

The size of the pixels in the image, expressed in dots-per-inch (dpi)

#### Since

2021

### `P:Autodesk.Revit.DB.ImageType.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageType.Height`

#### Summary

The vertical size of the image

#### Since

2021

### `P:Autodesk.Revit.DB.ImageType.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageType.Width`

#### Summary

The horizontal size of the image

#### Since

2021

### `P:Autodesk.Revit.DB.ImageType.Status`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageType.Status`

#### Summary

The status of the image

#### Since

2021

### `P:Autodesk.Revit.DB.ImageType.Source`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageType.Source`

#### Summary

The source of the image in the ImageType.

#### Since

2021

### `P:Autodesk.Revit.DB.ImageType.PathType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageType.PathType`

#### Summary

The path type that was used to refer to the file from which the ImageType was loaded.

#### Since

2020

### `P:Autodesk.Revit.DB.ImageType.Path`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageType.Path`

#### Summary

The path to the file from which the ImageType was loaded.

#### Remarks

The path string can be in one of several formats:
absolute local, relative local, or server (indicating that the file was provided by an external
server). The format is determined by `P:Autodesk.Revit.DB.ImageType.PathType`

The path can be an empty string, for example for (but not limited to) ImageTypes created using
"Save to Project as Image".

#### Since

2015

### `P:Autodesk.Revit.DB.ImageType.ExternalResourceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageType.ExternalResourceType`

#### Summary

The type of external resources that represents images.

#### Since

2020

### `P:Autodesk.Revit.DB.ImageType.HeightInPixels`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageType.HeightInPixels`

#### Summary

Number of pixels in the vertical direction of the image

#### Since

2021

### `P:Autodesk.Revit.DB.ImageType.WidthInPixels`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageType.WidthInPixels`

#### Summary

Number of pixels in the horizontal direction of the image

#### Since

2021

### `P:Autodesk.Revit.DB.ImageType.PageNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageType.PageNumber`

#### Summary

The number of the page in a multi-page file, that was used to create the image in the ImageType.

#### Remarks

This number is set when the ImageType is created or reloaded.

#### Since

2020

### `M:Autodesk.Revit.DB.ImageType.GetImage`

Member kind: method
Symbol: `Autodesk.Revit.DB.ImageType.GetImage`

#### Summary

Get the bitmap image stored in the image symbol.

#### Returns

The bitmap image at the original loaded image size.

#### Since

2015

### `T:Autodesk.Revit.DB.ImageType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImageType`

#### Summary

Represents a type containing a raster based image. `!:ImageInstance` of this type can be placed in 2D views, sheets, and schedules.

#### Remarks

ImageType elements are created with the ImageType.Create(Document, ImageTypeOptions) method.

ImageType elements can be loaded from the following file types: *.bmp, *.jpg, *.jpeg, *.png, *.tif.

In addition, when PDF support is available, ImageType elements can also be loaded from *.pdf files.
See: `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsPDFImportAvailable`

#### Since

2015

### `T:Autodesk.Revit.DB.ImageTypeStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImageTypeStatus`

#### Summary

Indicates the current state of the contents of the ImageType.

#### Since

2021

#### Since

2021

### `F:Autodesk.Revit.DB.ImageTypeStatus.Generated`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageTypeStatus.Generated`

#### Summary

The internally created image is available.

### `F:Autodesk.Revit.DB.ImageTypeStatus.Imported`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageTypeStatus.Imported`

#### Summary

The image was imported and is available.

### `F:Autodesk.Revit.DB.ImageTypeStatus.Unloaded`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageTypeStatus.Unloaded`

#### Summary

The linked images was unloaded by the user. No image is available.

### `F:Autodesk.Revit.DB.ImageTypeStatus.FailedToLoad`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageTypeStatus.FailedToLoad`

#### Summary

The linked image could not be loaded from file.

Some possible reasons are:
The file could not be found

The file could be corrupt or not contain image data

In case of PDF files, the file might be encrypted or not have the requested page

### `F:Autodesk.Revit.DB.ImageTypeStatus.Loaded`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageTypeStatus.Loaded`

#### Summary

The linked image was successfully loaded.

### `F:Autodesk.Revit.DB.ImageTypeStatus.Unknown`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageTypeStatus.Unknown`

#### Summary

The linked image has not yet been loaded. No image is available.
This status is only returned before the document is fully opened.

### `T:Autodesk.Revit.DB.ImageTypeSource`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImageTypeSource`

#### Summary

The source of the data used to generate the image.

#### Since

2021

#### Since

2021

### `F:Autodesk.Revit.DB.ImageTypeSource.Internal`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageTypeSource.Internal`

#### Summary

The image data was created internally.
These are rendering images or views saved in the project as images.

### `F:Autodesk.Revit.DB.ImageTypeSource.Import`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageTypeSource.Import`

#### Summary

The image data was imported into the Revit document.

### `F:Autodesk.Revit.DB.ImageTypeSource.Link`

Member kind: field
Symbol: `Autodesk.Revit.DB.ImageTypeSource.Link`

#### Summary

The image data is from an externally linked image file.

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsPDFImportAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsPDFImportAvailable`

#### Summary

Checks whether PDF import is available in the installed Revit.

#### Remarks

PDF Import requires the presence of certain modules that are optional and may not be part of the installed Revit.

#### Returns

True if a PDF import is available in the installed Revit.

#### Since

2020

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsNavisworksExporterAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsNavisworksExporterAvailable`

#### Summary

Checks whether a Navisworks Exporter is available in the installed Revit.

#### Remarks

A Navisworks exporter is registered via an external add-in. If no add-in has registered an exporter, this will not be a part of the session.

#### Returns

True if a Navisworks Exporter is available in the installed Revit.

#### Since

2014

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsIFCAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsIFCAvailable`

#### Summary

Checks whether IFC functionality is available in the installed Revit.

#### Remarks

IFC Import/Export requires presence of certain modules that are optional and may not be part of the installed Revit.

#### Returns

True if the IFC functionality is available in the installed Revit.

#### Since

2014

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsShapeImporterAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsShapeImporterAvailable`

#### Summary

Checks whether the ShapeImporter functionality is available in the installed Revit.

#### Returns

True if the ShapeImporter functionality is available in the installed Revit.

#### Since

2016

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsAXMImportLinkAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsAXMImportLinkAvailable`

#### Summary

Checks whether the AXM Import/Link functionality is available in the installed Revit.

#### Remarks

AXM Import/Link is optional functionality that does not have to be part of the Revit installation.

#### Returns

True if the AXM Import/Link functionality is available in the installed Revit.

#### Since

2022.1

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.Is3DMImportLinkAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.Is3DMImportLinkAvailable`

#### Summary

Checks whether the 3DM Import/Link functionality is available in the installed Revit.

#### Remarks

3DM Import/Link is optional functionality that does not have to be part of the Revit installation.

#### Returns

True if the 3DM Import/Link functionality is available in the installed Revit.

#### Since

2022

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsSTLImportLinkAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsSTLImportLinkAvailable`

#### Summary

Checks whether the STL Import/Link functionality is available in the installed Revit.

#### Remarks

STL Import/Link is optional functionality that does not have to be a part of the Revit installation.

#### Returns

True if the STL Import/Link functionality is available in the installed Revit.

#### Since

2022.1

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsOBJImportLinkAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsOBJImportLinkAvailable`

#### Summary

Checks whether the OBJ Import/Link functionality is available in the installed Revit.

#### Remarks

OBJ Import/Link is optional functionality that does not have to be a part of the Revit installation.

#### Returns

True if the OBJ Import/Link functionality is available in the installed Revit.

#### Since

2022.1

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsSKPImportLinkAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsSKPImportLinkAvailable`

#### Summary

Checks whether the SKP Import/Link functionality is available in the installed Revit.

#### Remarks

SKP Import/Link is optional functionality that does not have to be part of the Revit installation.

#### Returns

True if the SKP Import/Link functionality is available in the installed Revit.

#### Since

2014

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsSATImportLinkAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsSATImportLinkAvailable`

#### Summary

Checks whether the SAT Import/Link functionality is available in the installed Revit.

#### Remarks

SAT Import/Link is optional functionality that does not have to be part of the Revit installation.

#### Returns

True if the SAT Import/Link functionality is available in the installed Revit.

#### Since

2014

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsDGNImportLinkAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsDGNImportLinkAvailable`

#### Summary

Checks whether the DGN Import/Link functionality is available in the installed Revit.

#### Remarks

DGN Import/Link is optional functionality that does not have to be part of the Revit installation.

#### Returns

True if the DGN Import/Link functionality is available in the installed Revit.

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsDGNExportAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsDGNExportAvailable`

#### Summary

Checks whether the DGN Export functionality is available in the installed Revit.

#### Remarks

DGN Export requires presence of certain modules that are optional and may not be part of the installed Revit.

#### Returns

True if the DGN Export functionality is available in the installed Revit.

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsDWFExportAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsDWFExportAvailable`

#### Summary

Checks whether the DWF/DWFx Export functionality is available in the installed Revit.

#### Remarks

DWF/DWFx Export requires presence of certain modules that are optional and may not be part of the installed Revit.

#### Returns

True if the DWF/DWFx Export functionality is available in the installed Revit.

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsDWGImportLinkAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsDWGImportLinkAvailable`

#### Summary

Checks whether the DWG Import/Link functionality is available in the installed Revit.

#### Remarks

DWG Import/Link is optional functionality that does not have to be part of the Revit installation.

#### Returns

True if the DWG Import/Link functionality is available in the installed Revit.

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsDXFExportAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsDXFExportAvailable`

#### Summary

Checks whether the DXF Export functionality is available in the installed Revit.

#### Remarks

DXF Export requires presence of certain modules that are optional and may not be part of the installed Revit.

#### Returns

True if the DXF Export functionality is available in the installed Revit.

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsDWGExportAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsDWGExportAvailable`

#### Summary

Checks whether the DWG Export functionality is available in the installed Revit.

#### Remarks

DWG Export requires presence of certain modules that are optional and may not be part of the installed Revit.

#### Returns

True if the DWG Export functionality is available in the installed Revit.

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsFBXExportAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsFBXExportAvailable`

#### Summary

Checks whether the FBX Export functionality is available in the installed Revit.

#### Remarks

FBX Export requires presence of certain modules that are optional and may not be part of the installed Revit.

#### Returns

True if the FBX Export functionality is available in the installed Revit.

### `M:Autodesk.Revit.DB.OptionalFunctionalityUtils.IsGraphicsAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils.IsGraphicsAvailable`

#### Summary

Checks whether the graphics functionality is available to support display, print, and export functionality.

#### Remarks

Graphics functionality is optional functionality that does not have to be part of the Revit installation.

#### Returns

True if the Graphics functionality is available in the installed Revit.

### `T:Autodesk.Revit.DB.OptionalFunctionalityUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.OptionalFunctionalityUtils`

#### Summary

A collection of utilities that can be used to determine if a particular set of functionality is installed and available.

### `M:Autodesk.Revit.DB.CompoundStructure.CanLayerBeStructuralMaterial(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.CanLayerBeStructuralMaterial(System.Int32)`

#### Summary

Identifies if the input layer can be designated as defining the structural material for this structure.

#### Remarks

Only core layers may be designated as defining the structural material.

#### Parameter `layerIndex`

Index of a layer in the CompoundStructure.

#### Returns

True if the input layer may be used to define the structural material and false otherwise.

#### Since

2016

### `M:Autodesk.Revit.DB.CompoundStructure.CanLayerBeVariable(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.CanLayerBeVariable(System.Int32)`

#### Summary

Identifies if the input layer can be designated as a variable thickness layer.

#### Remarks

A layer whose layer function is StructuralDeck may not be designated as a variable layer.

#### Parameter `variableLayerIndex`

Index of a layer in the CompoundStructure.

#### Returns

True if the input layer may be a variable thickness layer and false otherwise.

#### Since

2016

### `M:Autodesk.Revit.DB.CompoundStructure.GetMinimumLayerThickness`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetMinimumLayerThickness`

#### Summary

Get the minimum allowable layer thickness.

#### Returns

The minimum allowable width of a layer in feet.

### `M:Autodesk.Revit.DB.CompoundStructure.CreateSingleLayerCompoundStructure(System.Double,Autodesk.Revit.DB.MaterialFunctionAssignment,System.Double,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.CreateSingleLayerCompoundStructure(System.Double,Autodesk.Revit.DB.MaterialFunctionAssignment,System.Double,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a vertically compound CompoundStructure with one layer.

#### Remarks

It is not verified that materialId corresponds to a valid MaterialElem.

#### Parameter `sampleHeight`

The sample height of this vertically compound structure.

#### Parameter `layerFunction`

The function of the single layer.

#### Parameter `width`

The width of the single layer.

#### Parameter `materialId`

The ElementId of the material for the single layer.

#### Returns

The newly created compound structure.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for sampleHeight must be greater than 0 and no more than 30000 feet.
-or-
The given value for width must be greater than 0 and no more than 30000 feet.
-or-
A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.CompoundStructure.CreateSingleLayerCompoundStructure(Autodesk.Revit.DB.MaterialFunctionAssignment,System.Double,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.CreateSingleLayerCompoundStructure(Autodesk.Revit.DB.MaterialFunctionAssignment,System.Double,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a CompoundStructure containing a single layer.

#### Remarks

It is not verified that materialId corresponds to a valid Material element.

#### Parameter `layerFunction`

The function of the single layer.

#### Parameter `width`

The width of the single layer.

#### Parameter `materialId`

The ElementId of the material for the single layer.

#### Returns

The newly created compound structure.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for width must be greater than 0 and no more than 30000 feet.
-or-
A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.CompoundStructure.CreateSimpleCompoundStructure(System.Collections.Generic.IList{Autodesk.Revit.DB.CompoundStructureLayer})`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.CreateSimpleCompoundStructure(System.Collections.Generic.IList{Autodesk.Revit.DB.CompoundStructureLayer})`

#### Summary

Creates a non-vertically compound structure comprised of parallel layers.

#### Remarks

All layers are in the core, i.e. there are no shell layers created.

#### Parameter `layers`

An array which describes the parallel layers of this compound structure.

#### Returns

A newly created compound structure.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more layers is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.CompoundStructure.GetLastCoreLayerIndex`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetLastCoreLayerIndex`

#### Summary

Gets the index of the last core layer.

#### Remarks

This is the index on the interior side. You can change the shell/core layer boundary
using `M:Autodesk.Revit.DB.CompoundStructure.SetNumberOfShellLayers(Autodesk.Revit.DB.ShellLayerType,System.Int32)` .

#### Returns

The index of the last core layer.

### `M:Autodesk.Revit.DB.CompoundStructure.GetFirstCoreLayerIndex`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetFirstCoreLayerIndex`

#### Summary

Gets the index of the first core layer.

#### Remarks

This is the index on the exterior side. You can change the shell/core layer boundary
using `M:Autodesk.Revit.DB.CompoundStructure.SetNumberOfShellLayers(Autodesk.Revit.DB.ShellLayerType,System.Int32)` .

#### Returns

The index of the first core layer.

### `M:Autodesk.Revit.DB.CompoundStructure.GetOffsetForLocationLine(Autodesk.Revit.DB.WallLocationLine)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetOffsetForLocationLine(Autodesk.Revit.DB.WallLocationLine)`

#### Summary

Returns the offset from the center of the compound structure to the given location line value.

#### Parameter `wallLocationLine`

The alignment type of the wall's location line.

#### Returns

The offset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only vertically homogeneous compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.GetCoreBoundaryLayerIndex(Autodesk.Revit.DB.ShellLayerType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetCoreBoundaryLayerIndex(Autodesk.Revit.DB.ShellLayerType)`

#### Summary

Returns the index of the layer just below the core boundary.

#### Remarks

-1 returned if there is no such a layer. You can change the shell/core layer boundary
using `M:Autodesk.Revit.DB.CompoundStructure.SetNumberOfShellLayers(Autodesk.Revit.DB.ShellLayerType,System.Int32)` .

#### Parameter `shellLayerType`

If ShellLayerType.Exterior return the index on the exterior side (or top side for a roof, floor, or ceiling type).
If ShellLayerType.Interior return the index on the interior side (or bottom side for a roof, floor, or ceiling type).

#### Returns

The index of the layer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.CompoundStructure.GetPreviousNonZeroLayerIndex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetPreviousNonZeroLayerIndex(System.Int32)`

#### Summary

Returns the index of the nearest non-zero width layer before this layer.

#### Remarks

If this layer is non-zero width, it will be returned. If there are non-zero width layers found, returns -1.

#### Parameter `thisIdx`

The layer from which to look for a non-zero width layer.

#### Returns

The index of the layer found.

### `M:Autodesk.Revit.DB.CompoundStructure.ClearWallSweeps(Autodesk.Revit.DB.WallSweepType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.ClearWallSweeps(Autodesk.Revit.DB.WallSweepType)`

#### Summary

Removes all sweeps or reveals from the compound structure.

#### Parameter `wallSweepType`

The type of a wall sweep.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.RemoveWallSweep(Autodesk.Revit.DB.WallSweepType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.RemoveWallSweep(Autodesk.Revit.DB.WallSweepType,System.Int32)`

#### Summary

Removes a single sweep or reveal from the compound structure.

#### Remarks

No validation of input arguments is performed. If no reveal or sweep
has the specified id, no action is performed.

#### Parameter `wallSweepType`

The type of a wall sweep.

#### Parameter `id`

The id of the sweep or reveal to remove.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.AddWallSweep(Autodesk.Revit.DB.WallSweepInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.AddWallSweep(Autodesk.Revit.DB.WallSweepInfo)`

#### Summary

Adds a new wall sweep or reveal to the compound structure.

#### Remarks

A wall sweep is an object that is created by sweeping a closed 2d profile along a horizontal line
that is positioned on one side (exterior or interior) of the hosting wall.
A reveal is a special wall sweep with a void shape that is subtracted from the hosting wall.

The id field of the WallSweepInfo must be populated with a non-negative integer value.
If there already is a sweep defined for this id, its parameters will be changed.
A new sweep will be created if no existing one has matching id.

#### Parameter `wallSweepInfo`

The wall sweep info to create a wall sweep.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The wall sweep info does not represent a fixed wall sweep. Only fixed wall sweeps may be assigned to vertical compound structures.
-or-
The WallSweepInfo has an invalid id for a fixed wall sweep.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.GetWallSweepsInfo(Autodesk.Revit.DB.WallSweepType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetWallSweepsInfo(Autodesk.Revit.DB.WallSweepType)`

#### Summary

Obtains a list of the intrinsic wall sweeps or reveals in this CompoundStructure.

#### Parameter `wallSweepType`

Whether to obtain wall sweeps or reveals.

#### Returns

An array which describes the intrinsic wall sweeps or reveals.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.CompoundStructure.ChangeRegionWidth(System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.ChangeRegionWidth(System.Int32,System.Double)`

#### Summary

Adjust the width of an existing simple region.

#### Remarks

If width is changed to zero, the effect is to delete the region.

#### Parameter `regionId`

The id of a region.

#### Parameter `newWidth`

The desired width of the specified region.

#### Returns

True if newWidth is zero and the region was deleted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It is not a valid region id.
-or-
It is not a simple region.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.GetRegionsAlongLevel(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetRegionsAlongLevel(System.Double)`

#### Summary

Returns the ids of the regions encountered as the vertically compound structure is traversed
at a constant height above the bottom a wall to which this structure is applied.

#### Parameter `height`

Distance from the bottom of the wall.

#### Returns

The ids of the regions intersected by the specified line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The height is outside valid range. It should be in the range of [0, SampleHeight].

### `M:Autodesk.Revit.DB.CompoundStructure.SetExtendableRegionIds(System.Boolean,System.Collections.Generic.IList{System.Int32})`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.SetExtendableRegionIds(System.Boolean,System.Collections.Generic.IList{System.Int32})`

#### Summary

Sets the extendable region ids for the compound structure.

#### Remarks

Regions along the top or bottom of the wall may be set to be extendable.

#### Parameter `top`

If true, set ids of regions which are extendable at the top, otherwise
set the ids of regions which are extendable at the bottom.

#### Parameter `regionIds`

The ids of regions which will be extendable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The region ids are not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.GetExtendableRegionIds(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetExtendableRegionIds(System.Boolean)`

#### Summary

Gets the extendable region ids for the compound structure.

#### Remarks

Regions along the top or bottom of the wall may be set to be extendable.

#### Parameter `top`

If true, retrieve ids of regions which are extendable at the top, otherwise
retrieve the ids of regions which are extendable at the bottom.

#### Returns

An array of region ids which are marked extendable.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.FindEnclosingRegionAndSegments(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.RectangularGridSegmentOrientation,System.Int32@,System.Int32@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.FindEnclosingRegionAndSegments(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.RectangularGridSegmentOrientation,System.Int32@,System.Int32@)`

#### Summary

Given a pair of grid coordinates, and a direction for splitting, returns the enclosing region and the two segments
intersected by a line through the grid point.

#### Remarks

Grid coordinates correspond to uv coordinates of faces.

#### Parameter `gridUV`

Coordinates of a point in the rectangular grid of this compound structure.

#### Parameter `splitDirection`

Specifies the direction of the split.

#### Parameter `segmentId1`

The id of a segment in the boundary of the containing region which is split by a line through gridUV in the specified direction.

#### Parameter `segmentId2`

The id of a segment in the boundary of the containing region which is split by a line through gridUV in the specified direction.

#### Returns

Returns the id of the enclosing region, and -1 if no region encloses the point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.SplitRegion(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.RectangularGridSegmentOrientation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.SplitRegion(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.RectangularGridSegmentOrientation)`

#### Summary

Splits the region which contains the specified grid point by a line with the specified direction.

#### Remarks

This method is meant to be used in conjunction with `M:Autodesk.Revit.DB.CompoundStructure.FindEnclosingRegionAndSegments(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.RectangularGridSegmentOrientation,System.Int32@,System.Int32@)` .
Grid coordinates correspond to uv coordinates of faces.

#### Parameter `gridUV`

Coordinates of a point in the rectangular grid of this compound structure.

#### Parameter `splitDirection`

Specifies the direction of the split.

#### Returns

The id of the region created by this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Split and merge regions operations can be used only for vertically compound structures without variable thickness layers.

### `M:Autodesk.Revit.DB.CompoundStructure.SplitRegion(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.RectangularGridSegmentOrientation,System.Int32@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.SplitRegion(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.RectangularGridSegmentOrientation,System.Int32@)`

#### Summary

Splits the region which contains the specified grid point by a line with the specified direction.

#### Remarks

This method is meant to be used in conjunction with `M:Autodesk.Revit.DB.CompoundStructure.FindEnclosingRegionAndSegments(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.RectangularGridSegmentOrientation,System.Int32@,System.Int32@)` .
Grid coordinates correspond to uv coordinates of faces.

#### Parameter `gridUV`

Coordinates of a point in the rectangular grid of this compound structure.

#### Parameter `splitDirection`

Specifies the direction of the split.

#### Parameter `newSegmentId`

The id of segment that bounds both the original region and the new region.

#### Returns

The id of the region created by this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Split and merge regions operations can be used only for vertically compound structures without variable thickness layers.

### `M:Autodesk.Revit.DB.CompoundStructure.MergeRegionsAdjacentToSegment(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.MergeRegionsAdjacentToSegment(System.Int32,System.Int32)`

#### Summary

Merges the two regions which share the specified segment.

#### Parameter `segmentId`

The id of a segment in the underlying grid.

#### Parameter `layerIdxForMergedRegion`

The index of the layer to which the resulting region will be associated.

#### Returns

The id of the resulting region. If -1 is returned, then the operation would have produced
an invalid region and was not performed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Split and merge regions operations can be used only for vertically compound structures without variable thickness layers.
-or-
The segment is not shared by adjacent regions.

### `M:Autodesk.Revit.DB.CompoundStructure.GetSegmentEndPoints(System.Int32,System.Int32,Autodesk.Revit.DB.UV@,Autodesk.Revit.DB.UV@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetSegmentEndPoints(System.Int32,System.Int32,Autodesk.Revit.DB.UV@,Autodesk.Revit.DB.UV@)`

#### Summary

Gets the end points of a segment.

#### Parameter `segmentId`

The segment id.

#### Parameter `regionId`

The region id.

#### Parameter `end1`

One end point.

#### Parameter `end2`

The other end point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The segment id is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.GetSegmentCoordinate(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetSegmentCoordinate(System.Int32)`

#### Summary

Gets the coordinate of a segment.

#### Remarks

The boundaries of the regions of a vertically compound structure consist of vertical
horizontal segments.
If the segment orientation is horizontal, then its coordinate will lie in the range [0.0, SampleHeight].
If the segment orientation is vertical, then its coordinate will lie in the range of u values obtained from
`M:Autodesk.Revit.DB.CompoundStructure.GetRegionEnvelope(System.Int32)` .

#### Parameter `segmentId`

The id of a segment in this CompoundStructure.

#### Returns

The local coordinates of the specified segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The segment id is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.GetRegionEnvelope(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetRegionEnvelope(System.Int32)`

#### Summary

Gets the envelope that a specified region spans.

#### Remarks

This envelope indicates the external boundary of the region. The
coordinate system it defines is used in the results of GetSegmentCoordinate().

#### Parameter `regionId`

The id of the region.

#### Returns

The envelope of the region.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It is not a valid region id.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.GetSegmentOrientation(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetSegmentOrientation(System.Int32)`

#### Summary

Gets the orientation of a segment.

#### Remarks

The boundaries of the regions of a vertically compound structure consist of vertical
horizontal segments.

#### Parameter `segmentId`

The id of a segment in this CompoundStructure.

#### Returns

The orientation of the specified segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The segment id is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.GetAdjacentRegions(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetAdjacentRegions(System.Int32)`

#### Summary

Gets the ids of region bound to a specified segment.

#### Remarks

The boundaries of the regions of a vertically compound structure consist of vertical
horizontal segments with unique ids.
The segments which define the outer boundary of the structure are adjacent to one region,
other segments will be adjacent to two regions.

#### Parameter `segmentId`

The id of a segment in this CompoundStructure.

#### Returns

The ids of the regions that are bounded by the specified segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The segment id is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.IsValidSegmentId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsValidSegmentId(System.Int32)`

#### Summary

Determines whether the specified integer is actually the id of a segment in this CompoundStructure.

#### Parameter `segmentId`

The id of a segment in this CompoundStructure.

#### Returns

True if the specified segment is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.IsRectangularRegion(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsRectangularRegion(System.Int32)`

#### Summary

Determines whether the specified region is rectangular.

#### Parameter `regionId`

The id of a region.

#### Returns

True if the specified region is a rectangle, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It is not a valid region id.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.IsSimpleRegion(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsSimpleRegion(System.Int32)`

#### Summary

Determines whether the region is a simple region in this CompoundStructure.

#### Remarks

A region is simple if it rectangular and spans the height of the wall.

#### Parameter `regionId`

The id of a region in this vertically compound structure.

#### Returns

True if the region is simple, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It is not a valid region id.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.IsValidRegionId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsValidRegionId(System.Int32)`

#### Summary

Determines whether the specified integer is actually the id of a region in this CompoundStructure.

#### Parameter `regionId`

The id of a region in this vertically compound structure.

#### Returns

True if the region is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.GetSegmentIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetSegmentIds`

#### Summary

Gets the segment ids of this compound structure.

#### Remarks

The boundaries of the regions of a vertically compound structure consist of vertical
horizontal segments with unique ids.

#### Returns

The ids of the segments which form the boundary of the regions of this CompoundStructure.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.GetRegionIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetRegionIds`

#### Summary

Gets the region ids of this compound structure.

#### Remarks

A vertically compound structure consists of regions with polygonal boundaries.

#### Returns

The ids of the regions defining this CompoundStructure.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.AssociateRegionWithLayer(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.AssociateRegionWithLayer(System.Int32,System.Int32)`

#### Summary

Associates a region with a layer.

#### Parameter `regionId`

The id of a region.

#### Parameter `layerIdx`

The index of a layer in this CompoundStructure.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It is not a valid region id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.GetLayerAssociatedToRegion(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetLayerAssociatedToRegion(System.Int32)`

#### Summary

Gets the layer associated to a particular region.

#### Parameter `regionId`

The id of a region.

#### Returns

The index of a layer in this CompoundStructure.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

For a non-vertically compound structure, implicitly each layer is associated to its corresponding simple region.

### `M:Autodesk.Revit.DB.CompoundStructure.GetRegionsAssociatedToLayer(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetRegionsAssociatedToLayer(System.Int32)`

#### Summary

Gets the set of region ids associated to a particular layer.

#### Remarks

Regions are associated to layers. In a vertically compound structure, more than one region may be associated to a
single layer.

#### Parameter `layerIdx`

The index of a layer in this CompoundStructure.

#### Returns

An array of region ids which are associated to the specified layer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

### `M:Autodesk.Revit.DB.CompoundStructure.CanSplitAndMergeRegionsBeUsed`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.CanSplitAndMergeRegionsBeUsed`

#### Summary

Checks whether split and merge regions operations can be used for this compound structure.

#### Returns

True if split and merge regions operation can be used for this compound structure, false otherwise.

### `M:Autodesk.Revit.DB.CompoundStructure.IsValidSampleHeight(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsValidSampleHeight(System.Double)`

#### Summary

Is the specified height a valid sample height for this compound structure?

#### Remarks

The sample height cannot be less than the value of MinimumSampleHeight.

### `M:Autodesk.Revit.DB.CompoundStructure.IsLayerValid(System.Int32,Autodesk.Revit.DB.CompoundStructureLayer)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsLayerValid(System.Int32,Autodesk.Revit.DB.CompoundStructureLayer)`

#### Summary

Verifies that the data in this layer is internally consistent.

#### Remarks

If the layer function is not Membrane or StructuralDeck, the width must be greater than zero.
If the layer function is not StructuralDeck, then the deck embedding type must be Invalid, and the deck profile id must be InvalidElementId.

#### Parameter `layerIdx`

The index of the layer in the compound structure to be set.

#### Parameter `layer`

The layer to be set.

#### Returns

True if the layer is internally consistent, false if the layer is not internally consistent.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.CompoundStructure.IsCoreLayer(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsCoreLayer(System.Int32)`

#### Summary

Checks if the specified layer is a core layer.

#### Remarks

You can change the shell/core layer boundary using `M:Autodesk.Revit.DB.CompoundStructure.SetNumberOfShellLayers(Autodesk.Revit.DB.ShellLayerType,System.Int32)` .

#### Parameter `layerIdx`

The index of a layer in this CompoundStructure.

#### Returns

Returns true if the layer is within the core layer boundary, false if it is in the interior or exterior shell layers.

### `M:Autodesk.Revit.DB.CompoundStructure.SetNumberOfShellLayers(Autodesk.Revit.DB.ShellLayerType,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.SetNumberOfShellLayers(Autodesk.Revit.DB.ShellLayerType,System.Int32)`

#### Summary

Sets the number of interior or exterior shell layers.

#### Remarks

There must be at least one core layer, i.e. one layer which is not a shell layer.

#### Parameter `shellLayerType`

If ShellLayerType.Exterior set the number of exterior shell layers (or top shell layers for a roof, floor, or ceiling type).
If ShellLayerType.Interior set the number of interior shell layers (or bottom shell layers for a roof, floor, or ceiling type).

#### Parameter `numLayers`

The number of layers to be in the specified shell.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Number of shell layers is negative.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Too many shell layers: there must be at least one core layer.

### `M:Autodesk.Revit.DB.CompoundStructure.GetNumberOfShellLayers(Autodesk.Revit.DB.ShellLayerType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetNumberOfShellLayers(Autodesk.Revit.DB.ShellLayerType)`

#### Summary

Retrieves the number of interior or exterior shell layers.

#### Remarks

There will always be at least one core layer, i.e. one layer which is not a shell layer. You can change the shell/core layer
boundary using `M:Autodesk.Revit.DB.CompoundStructure.SetNumberOfShellLayers(Autodesk.Revit.DB.ShellLayerType,System.Int32)` .

#### Parameter `shellLayerType`

If ShellLayerType.Exterior return the number of exterior shell layers (or top shell layers for a roof, floor, or ceiling type).
If ShellLayerType.Interior return the number of interior shell layers (or bottom shell layers for a roof, floor, or ceiling type).

#### Returns

The number of shell layers in the interior or exterior shell, as specified by shellLayerType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.CompoundStructure.GetWidth`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetWidth`

#### Summary

The width implied by this compound structure.

#### Remarks

If the structure is not vertically compound, then
this is simply the sum of all layers' widths. If the structure is vertically compound,
this is the width of the rectangular grid stored in the vertically compound structure.
The presence of a layer with variable width has no effect on the value returned by this method. The
value returned assumes that all layers have their specified width.

#### Returns

The width of a host object with this compound structure.

### `M:Autodesk.Revit.DB.CompoundStructure.SetParticipatesInWrapping(System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.SetParticipatesInWrapping(System.Int32,System.Boolean)`

#### Summary

Assigns if a layer is included in wrapping at inserts and ends.

#### Remarks

This method applies only to interior and exterior shell layers.

#### Parameter `layerIdx`

The index of the layer.

#### Parameter `participatesInWrapping`

True if the specified layer will participate in wrapping at inserts and ends, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The wrapping of the layer is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

### `M:Autodesk.Revit.DB.CompoundStructure.ParticipatesInWrapping(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.ParticipatesInWrapping(System.Int32)`

#### Summary

Identifies if a layer is included in wrapping at inserts and ends.

#### Remarks

This method applies only to interior and exterior shell layers.

#### Parameter `layerIdx`

The index of the layer.

#### Returns

If true, then the layer participates in wrapping at inserts and openings. If false, the layer will not
participate in wrapping.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

### `M:Autodesk.Revit.DB.CompoundStructure.SetLayer(System.Int32,Autodesk.Revit.DB.CompoundStructureLayer)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.SetLayer(System.Int32,Autodesk.Revit.DB.CompoundStructureLayer)`

#### Summary

Sets a single layer for this CompoundStructure.

#### Remarks

This function does not support addition of new layers, use SetLayers() to change the number of layers.

#### Parameter `layerIdx`

The index of a layer. This should range from 0 to the number of layers - 1.

#### Parameter `layer`

The layer to be set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The layer is not valid for this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for non-vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.SetLayers(System.Collections.Generic.IList{Autodesk.Revit.DB.CompoundStructureLayer})`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.SetLayers(System.Collections.Generic.IList{Autodesk.Revit.DB.CompoundStructureLayer})`

#### Summary

Completely resets this CompoundStructure and applies a new set of layers.

#### Remarks

This function will replace all existing layers with the contents of the input. This provides a full
reset for the CompoundStructure. Therefore:
All layers will be marked as Core layers, and any settings related to Shell layers (such as `M:Autodesk.Revit.DB.CompoundStructure.GetFirstCoreLayerIndex` ,
`M:Autodesk.Revit.DB.CompoundStructure.GetLastCoreLayerIndex` or `M:Autodesk.Revit.DB.CompoundStructure.GetCoreBoundaryLayerIndex(Autodesk.Revit.DB.ShellLayerType)` ) will be modified accordingly.

Because all layers will be set as Core layers, the value of LayerCapFlag will be ignored (and set to true) automatically.

The `P:Autodesk.Revit.DB.CompoundStructure.VariableLayerIndex` will be unset.

The `P:Autodesk.Revit.DB.CompoundStructure.StructuralMaterialIndex` will be unset.

The compound structure will be set to be `M:Autodesk.Revit.DB.CompoundStructure.IsVerticallyHomogeneous` .

#### Parameter `layers`

The layers to be set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.CompoundStructure.SetDeckEmbeddingType(System.Int32,Autodesk.Revit.DB.StructDeckEmbeddingType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.SetDeckEmbeddingType(System.Int32,Autodesk.Revit.DB.StructDeckEmbeddingType)`

#### Summary

Sets the deck embedding type to use for the specified structural deck.

#### Parameter `layerIdx`

Index of a layer in the CompoundStructure.

#### Parameter `embedType`

The embedding type to be used by the specified layer if it is a structural deck.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The layer is not a structural deck.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.
-or-
A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.CompoundStructure.GetDeckEmbeddingType(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetDeckEmbeddingType(System.Int32)`

#### Summary

Retrieves the deck embedding type used for the specified structural deck.

#### Parameter `layerIdx`

Index of a layer in the CompoundStructure.

#### Returns

The embedding type of the structural deck associated to the specified layer. Invalid if it is not a structural deck.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

### `M:Autodesk.Revit.DB.CompoundStructure.SetDeckProfileId(System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.SetDeckProfileId(System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the profile loop to use for the specified structural deck.

#### Parameter `layerIdx`

Index of a layer in the CompoundStructure.

#### Parameter `profileId`

The element id of a FamilySymbol which contains a profile loop to be used by the specified layer if it is a structural deck.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The layer is not a structural deck.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

### `M:Autodesk.Revit.DB.CompoundStructure.GetDeckProfileId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetDeckProfileId(System.Int32)`

#### Summary

Retrieves the profile loop used for the specified structural deck.

#### Parameter `layerIdx`

Index of a layer in the CompoundStructure.

#### Returns

The element id of a FamilySymbol which contains a profile loop used by a structural deck associated to the specified layer,
or invalidElementId if isStructuralDeck(layerIdx) is false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

### `M:Autodesk.Revit.DB.CompoundStructure.IsStructuralDeck(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsStructuralDeck(System.Int32)`

#### Summary

Determines whether a specified layer is a structural deck.

#### Parameter `layerIdx`

Index of a layer in the CompoundStructure.

#### Returns

True if specified layer is a structural deck, and false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

### `M:Autodesk.Revit.DB.CompoundStructure.SetLayerFunction(System.Int32,Autodesk.Revit.DB.MaterialFunctionAssignment)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.SetLayerFunction(System.Int32,Autodesk.Revit.DB.MaterialFunctionAssignment)`

#### Summary

Sets the function of the specified layer.

#### Parameter `layerIdx`

Index of a layer in the CompoundStructure.

#### Parameter `function`

The function of the layer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.
-or-
A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.CompoundStructure.GetLayerFunction(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetLayerFunction(System.Int32)`

#### Summary

Retrieves the function of the specified layer.

#### Remarks

The function determines how this layer interacts with the layers of other elements to which it is joined.

#### Parameter `layerIdx`

Index of a layer in the CompoundStructure.

#### Returns

The function of the layer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

### `M:Autodesk.Revit.DB.CompoundStructure.GetWidth(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetWidth(System.Int32)`

#### Summary

Computes the width of the envelope (2d bounding box) of the specified region.

#### Parameter `regionId`

The id of a region in this vertically compound structure.

#### Returns

The width of the envelope (2d bounding box) of the region.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It is not a valid region id.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `M:Autodesk.Revit.DB.CompoundStructure.CanLayerWidthBeNonZero(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.CanLayerWidthBeNonZero(System.Int32)`

#### Summary

Identifies if changing the width of an existing layer from zero to a positive value will create a rectangular region.

#### Remarks

This is only allowed if there is a vertical line such that all regions to the left are assigned to layers with index < layerIdx,
and all regions to the right are assigned to layers with index > layerIdx.

#### Parameter `layerIdx`

The index of a CompoundStructureLayer.

### `M:Autodesk.Revit.DB.CompoundStructure.SetLayerWidth(System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.SetLayerWidth(System.Int32,System.Double)`

#### Summary

Sets the width of a specified layer.

#### Remarks

If the structure is vertically compound, and the layer is associated to a single simple region,
the width of that region is adjusted. If layerIdx is 0 or LayerCount-1,
and there is no associated region in the VerticalRegionsStructure, one will be created and associated to the layer.
If the specified layer index is associated to a simple region, and the width is set to 0.0, that region will be deleted.

#### Parameter `layerIdx`

Index of a layer in the CompoundStructure.

#### Parameter `width`

The new width of the specified layer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The width of the layer is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If the region of the layer is not a simple region.

### `M:Autodesk.Revit.DB.CompoundStructure.GetLayerWidth(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetLayerWidth(System.Int32)`

#### Summary

Retrieves the width of a specified layer.

#### Parameter `layerIdx`

Index of a layer in the CompoundStructure.

#### Returns

The width of the specified layer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

### `M:Autodesk.Revit.DB.CompoundStructure.GetMaterialId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetMaterialId(System.Int32)`

#### Summary

Retrieves the material element id of a specified layer.

#### Parameter `layerIdx`

Index of a layer in the CompoundStructure.

#### Returns

The material element id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

### `M:Autodesk.Revit.DB.CompoundStructure.SetMaterialId(System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.SetMaterialId(System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Sets a material element for a specified layer.

#### Remarks

It is not verified that materialId corresponds to a valid Material element.

#### Parameter `layerIdx`

Index of a layer in the CompoundStructure.

#### Parameter `materialId`

The ElementId of a Material element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

### `M:Autodesk.Revit.DB.CompoundStructure.DeleteLayer(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.DeleteLayer(System.Int32)`

#### Summary

Deletes the specified layer from this CompoundStructure.

#### Remarks

For a vertically compound structure, a layer
may only be deleted if it is not associated to a region, or else it is associated to exactly one simple
region, which will also be deleted. Regions associated to layers with index greater than layerIdx will
have their associated layer indices decremented by one.

#### Parameter `layerIdx`

The layer index is zero based. It counts from the exterior of wall and from the top of roofs, floors and ceilings.

#### Returns

True if the layer was successfully deleted, and false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The layer cannot be deleted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The layer index is out of range.

### `M:Autodesk.Revit.DB.CompoundStructure.GetSimpleCompoundStructure(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetSimpleCompoundStructure(System.Double,System.Double)`

#### Summary

Takes a horizontal slice through a sample wall to which this CompoundStructure is applied
and returns a simple compound structure which describes that slice, i.e. a series of
parallel layers.

#### Remarks

If `P:Autodesk.Revit.DB.CompoundStructure.IsVerticallyCompound` is false, the output is a copy of this CompoundStructure.

#### Parameter `wallHeight`

The height of the wall.

#### Parameter `distAboveBase`

The distance from the base of the wall at which to take the section.
If distAboveBase < 0, then internally distAboveBase = 0 is used.
If distAboveBase > wallHeight, then internally distAboveBase = wallHeight is used.

#### Returns

A simple CompoundStructure representing a series of parallel layers.

### `M:Autodesk.Revit.DB.CompoundStructure.IsValid(Autodesk.Revit.DB.Document,System.Collections.Generic.IDictionary{System.Int32,Autodesk.Revit.DB.CompoundStructureError}@,System.Collections.Generic.IDictionary{System.Int32,System.Int32}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsValid(Autodesk.Revit.DB.Document,System.Collections.Generic.IDictionary{System.Int32,Autodesk.Revit.DB.CompoundStructureError}@,System.Collections.Generic.IDictionary{System.Int32,System.Int32}@)`

#### Summary

Checks for errors or inconsistencies in the data in this CompoundStructure.

#### Remarks

This check is run before the CompoundStructure may be assigned to a particular ElementType.

#### Parameter `doc`

Access to the document in which the CompoundStructure will be used.

#### Parameter `errMap`

This map will associate each problematic layer index to a value in CompoundStructureError.
General structure errors are reported as associated to layer index -1.

#### Parameter `twoLayerErrorsMap`

The map is associated to a check run only for vertically Compound Structures.
Essentially the Compound Structure is sliced at representative heights.
It looks at the region from exterior to interior, and requires that the assigned layer indices do not decrease.
If they do, an entry is generated for this map. The first entry is the last valid layer index encountered.
The second entry is a region id whose assigned layer index is too small: it should be at least as large as the first entry.

#### Returns

True if the compound structure is valid for the document, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.CompoundStructure.IsVerticallyHomogeneous`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsVerticallyHomogeneous`

#### Summary

Indicates whether this CompoundStructure represents a single set of parallel layers.

#### Remarks

Differs from IsVerticallyCompound as a vertically compound structure might happen not to have
any horizontal breaks. For that situation, both IsVerticallyCompound and this method will return true.

#### Returns

True if this CompoundStructure represents a series of parallel layers that stretch from bottom to top, false otherwise.

### `M:Autodesk.Revit.DB.CompoundStructure.IsEqual(Autodesk.Revit.DB.CompoundStructure)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsEqual(Autodesk.Revit.DB.CompoundStructure)`

#### Summary

Checks whether this CompoundStructure is the same as another CompoundStructure.

#### Parameter `otherStructure`

A CompoundStructure.

#### Returns

True if the two CompoundStructures are the same, and false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.CompoundStructure.GetLayers`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructure.GetLayers`

#### Summary

A copy of the layers which define this compound structure.

#### Returns

The layers, returned in order (Exterior to Interior for walls, top to bottom for roofs, floors or ceilings). The index of each layer in this array
can be used in other CompoundStructure methods accepting a layer index.

### `P:Autodesk.Revit.DB.CompoundStructure.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.CompoundStructure.MinimumSampleHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructure.MinimumSampleHeight`

#### Summary

The minimum sample height determined by the current sample height and the horizontal segments.

#### Remarks

All horizontal segments dimensioned to the top must remain strictly above all horizontal segments
dimensioned to the bottom.

### `P:Autodesk.Revit.DB.CompoundStructure.CutoffHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructure.CutoffHeight`

#### Summary

Horizontal segments below or at the cutoff height have their distance to the wall bottom fixed, those above
have their distance to the wall top fixed.

#### Remarks

This allows layers with one horizontal segment above and one below
this line to be of variable height.

#### Value

The cutoff height of this CompoundStructure.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `P:Autodesk.Revit.DB.CompoundStructure.SampleHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructure.SampleHeight`

#### Summary

The sample height is the presumed height of the wall to which the data in this CompoundStructure is applied.

#### Remarks

This value has meaning only for vertically compound structures.
In order to apply this CompoundStructure to a wall whose height differs from the sample height,
the underlying grid will be rescaled.

#### Value

The height of the wall used to define the vertically compound structure.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value newSampleHeight is smaller than the value of MinimumSampleHeight.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation is valid only for vertically compound structures.

### `P:Autodesk.Revit.DB.CompoundStructure.StructuralMaterialIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructure.StructuralMaterialIndex`

#### Summary

Indicates the layer whose material defines the structural properties of the type for the purposes of analysis.

#### Value

The index of the layer containing the structural material properties.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The specified layer cannot define the structural material properties of the type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The layer index is invalid.

### `P:Autodesk.Revit.DB.CompoundStructure.VariableLayerIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructure.VariableLayerIndex`

#### Summary

Indicates the index of the layer which is designated as variable.

#### Remarks

If the host object to which it is applied
has an actual width that exceeds the total width of all layers, then all layers except the variable layer
will be created with their specified width, and the variable layer will expand to take up the slack.
Generally this is applicable for floors and roofs with shape edits applied. There can be only one variable layer.
In the wall compound structure UI, when a layer is labeled 'variable' in the thickness column,
that means it is assigned either to a non-rectangular region, or it means the layer is assigned to two different layers.
Neither of those situations is what this method refers to.

#### Value

The index of the layer specified as variable. If there is no variable layer, this value is -1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The specified layer cannot be set to a variable layer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The layer index is out of range.
-or-
When setting this property: The layer index is invalid.

### `P:Autodesk.Revit.DB.CompoundStructure.OpeningWrapping`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructure.OpeningWrapping`

#### Summary

Indicates the opening wrapping condition defining which shell layers of a wall, in plan view, wrap at inserts and openings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.CompoundStructure.EndCap`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructure.EndCap`

#### Summary

Indicates the end cap condition defining which shell layers will participate in end wrapping.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.CompoundStructure.HasStructuralDeck`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructure.HasStructuralDeck`

#### Summary

Checks if the compound structure has a structural deck.

### `P:Autodesk.Revit.DB.CompoundStructure.IsVerticallyCompound`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsVerticallyCompound`

#### Summary

Identifies if this CompoundStructure represents a layout that is more complicated than a simple set of parallel layers.

#### Remarks

Vertically compound structures should be assigned only to walls.

### `P:Autodesk.Revit.DB.CompoundStructure.LayerCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructure.LayerCount`

#### Summary

Returns the number of layers contained in this CompoundStructure.

#### Remarks

Establishes the valid range of indices passed to various access functions: [0 ... this value - 1]

### `P:Autodesk.Revit.DB.CompoundStructure.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructure.IsEmpty`

#### Summary

Checks whether this CompoundStructure is empty.

### `T:Autodesk.Revit.DB.CompoundStructure`

Member kind: type
Symbol: `Autodesk.Revit.DB.CompoundStructure`

#### Summary

Describes the internal structure of a wall, floor, roof or ceiling.

#### Remarks

A compound structure consists a collection of ordered layers, proceeding from exterior to interior for a wall, or from top to bottom for a
floor, roof or ceiling. The properties of these layers determine the
thickness, material, and function of the overall structure of the associated wall, floor, roof or ceiling. Layers can
be accessed via the `M:Autodesk.Revit.DB.CompoundStructure.GetLayers` method and completely replaced using SetLayers. Layers
can also be accessed and modified individually using the "layer index", which is a value from in the range [0, LayerCount)
identifying the layer in the structure.

A structure supports the concept of "core layers" and "shell layers". There are two layer indices which identify
where the boundary between core and shell layers occur in the list of layers. The boundaries between shell and core layers
are identifiable using
`M:Autodesk.Revit.DB.CompoundStructure.GetFirstCoreLayerIndex` , `M:Autodesk.Revit.DB.CompoundStructure.GetLastCoreLayerIndex` , `M:Autodesk.Revit.DB.CompoundStructure.GetCoreBoundaryLayerIndex(Autodesk.Revit.DB.ShellLayerType)`
or `M:Autodesk.Revit.DB.CompoundStructure.GetNumberOfShellLayers(Autodesk.Revit.DB.ShellLayerType)` . The core layer boundary can be changed with `M:Autodesk.Revit.DB.CompoundStructure.SetNumberOfShellLayers(Autodesk.Revit.DB.ShellLayerType,System.Int32)` .

Compound structures may be vertically compound. If `P:Autodesk.Revit.DB.CompoundStructure.IsVerticallyCompound` is false,
the CompoundStructure describes a series of parallel layers, each with specified width, function, material and other properties.
If `P:Autodesk.Revit.DB.CompoundStructure.IsVerticallyCompound` is true (which should apply only for CompoundStructures assigned to walls) then
horizontal sections at different elevations may have different layered
structures. In this case, the structure describes a vertical section via a rectangle
which is divided into polygonal regions whose sides are all vertical or horizontal segments.
A map associates each of these regions with the index of a layer in the CompoundStructure which
determines the properties of that region.

### `P:Autodesk.Revit.DB.CompoundStructureLayer.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructureLayer.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.CompoundStructureLayer.LayerCapFlag`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructureLayer.LayerCapFlag`

#### Summary

Identifies if the layer participates in wrapping at end caps and/or inserts.

#### Value

True if the layer participates in wrapping, false otherwise. It is meaningful only for Shell layers
(for Core layers, the value is always true). The default value is true.

### `P:Autodesk.Revit.DB.CompoundStructureLayer.LayerId`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructureLayer.LayerId`

#### Summary

The id of the layer - note that this may be different from the index in the array of layers in a CompoundStructure.

### `P:Autodesk.Revit.DB.CompoundStructureLayer.DeckEmbeddingType`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructureLayer.DeckEmbeddingType`

#### Summary

Embedding type for structural deck - only for a layer whose function is StructuralDeck.

#### Value

The default is StructDeckEmbeddingType.Invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.CompoundStructureLayer.Function`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructureLayer.Function`

#### Summary

The function of the layer.

#### Value

The default is MaterialFunctionAssignment.None.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.CompoundStructureLayer.DeckProfileId`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructureLayer.DeckProfileId`

#### Summary

The ElementId of the structural deck profile - only for a layer whose function is StructuralDeck.

#### Value

The default is InvalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.CompoundStructureLayer.MaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructureLayer.MaterialId`

#### Summary

Id of the material assigned to this layer.

#### Value

The default is InvalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `P:Autodesk.Revit.DB.CompoundStructureLayer.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.CompoundStructureLayer.Width`

#### Summary

Width of the layer.

#### Remarks

Can be 0.0 if this is a membrane layer. 0.0 is the default.

### `M:Autodesk.Revit.DB.CompoundStructureLayer.#ctor(System.Double,Autodesk.Revit.DB.MaterialFunctionAssignment,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructureLayer.#ctor(System.Double,Autodesk.Revit.DB.MaterialFunctionAssignment,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a default compound structure layer based on the given width, function and material element id.

#### Parameter `width`

The width of the layer.

#### Parameter `function`

The function of the layer.

#### Parameter `materialId`

The material element id of the layer.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.CompoundStructureLayer.#ctor(Autodesk.Revit.DB.CompoundStructureLayer)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructureLayer.#ctor(Autodesk.Revit.DB.CompoundStructureLayer)`

#### Summary

Creates a copy of a compound structure layer.

#### Parameter `cs`

The compound structure to copy.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.CompoundStructureLayer.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CompoundStructureLayer.#ctor`

#### Summary

Creates a compound structure layer using default settings.

#### Remarks

Note that the combination of the default values does not create a completely valid CompoundStructureLayer.
You should change the necessary values before adding to a CompoundStructure.

### `T:Autodesk.Revit.DB.CompoundStructureLayer`

Member kind: type
Symbol: `Autodesk.Revit.DB.CompoundStructureLayer`

#### Summary

Describes a single layer in a CompoundStructure.

### `T:Autodesk.Revit.DB.Architecture.GutterType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.GutterType`

#### Summary

An object that represents the gutter type
in Autodesk Revit.

### `M:Autodesk.Revit.DB.Architecture.Gutter.AddSegment(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Gutter.AddSegment(Autodesk.Revit.DB.Reference)`

#### Summary

Add segments to the gutter.

#### Parameter `targetRef`

Segment's reference on which want to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

This exception will be thrown in following cases:
1. Input targetRef is null.
2. Input targetRef is not null but contains nothing.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This exception will be thrown in following cases:
1. Input targetRef has already been added into the gutter.
2. Internal code fails to create the segment object.
3. Regeneration fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

This exception will be thrown if the reference is not suitable for creating a gutter as required.
The reference allowed is :
1. Model Line
2. Roof's horizontal edges
3. Soffit's horizontal edges
4. Fascia's horizontal edges

### `P:Autodesk.Revit.DB.Architecture.Gutter.GutterType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Gutter.GutterType`

#### Summary

Retrieves/set an object that represents the type of the Gutter.

### `T:Autodesk.Revit.DB.Architecture.Gutter`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.Gutter`

#### Summary

An object that represents a gutter within the Autodesk Revit project.

#### Remarks

This object derived from the Element base object and such supports all the
methods of that object such as the ability to retrieve the parameters of that object.

### `P:Autodesk.Revit.DB.Path3d.CurveLoop(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Path3d.CurveLoop(System.Int32)`

#### Summary

Get the Curve Loop of Path3d via index.

#### Remarks

Returns the index order Curve Loop of Path3d.

### `P:Autodesk.Revit.DB.Path3d.AllCurveLoops`

Member kind: property
Symbol: `Autodesk.Revit.DB.Path3d.AllCurveLoops`

#### Summary

Get all the Curve Loops of Path3d.

#### Remarks

Returns all the Curve Loops of Path3d.

### `P:Autodesk.Revit.DB.Path3d.NumCurveLoops`

Member kind: property
Symbol: `Autodesk.Revit.DB.Path3d.NumCurveLoops`

#### Summary

Get the Number of Curve Loops of Path3d.

#### Remarks

Returns the Number of Curve Loops of Path3d.

### `T:Autodesk.Revit.DB.Path3d`

Member kind: type
Symbol: `Autodesk.Revit.DB.Path3d`

#### Summary

Provides access to the Generic 3D path object in Autodesk Revit.

#### Remarks

This object represents a 3D path sketch of Sweep.

### `M:Autodesk.Revit.DB.FootPrintRoof.GetProfiles`

Member kind: method
Symbol: `Autodesk.Revit.DB.FootPrintRoof.GetProfiles`

#### Summary

Retrieve all the curveLoops of FootPrintRoof.

### `P:Autodesk.Revit.DB.FootPrintRoof.CurtainGrids`

Member kind: property
Symbol: `Autodesk.Revit.DB.FootPrintRoof.CurtainGrids`

#### Summary

Retrieve all the CurtainGrid objects of a FootPrintRoof.

#### Remarks

Only applicable when the object is a Curtain FootPrintRoof.

### `P:Autodesk.Revit.DB.FootPrintRoof.Overhang(Autodesk.Revit.DB.ModelCurve)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FootPrintRoof.Overhang(Autodesk.Revit.DB.ModelCurve)`

#### Summary

Retrieve or set the Overhang of the curve.

#### Remarks

Only applicable when the FootPrintRoof is created with Pick Walls.

### `P:Autodesk.Revit.DB.FootPrintRoof.ExtendIntoWall(Autodesk.Revit.DB.ModelCurve)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FootPrintRoof.ExtendIntoWall(Autodesk.Revit.DB.ModelCurve)`

#### Summary

Retrieve or set whether extend into wall the curve.

#### Remarks

Only applicable when the FootPrintRoof is created with Pick Walls.

### `P:Autodesk.Revit.DB.FootPrintRoof.Offset(Autodesk.Revit.DB.ModelCurve)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FootPrintRoof.Offset(Autodesk.Revit.DB.ModelCurve)`

#### Summary

Retrieve or set the Offset of the curve.

### `P:Autodesk.Revit.DB.FootPrintRoof.SlopeAngle(Autodesk.Revit.DB.ModelCurve)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FootPrintRoof.SlopeAngle(Autodesk.Revit.DB.ModelCurve)`

#### Summary

Retrieve or set the SlopeAngle of the curve.

#### Remarks

The value is a "slope" measurement. For example, 0.5 is one unit of rise for each 2 units of run. This creates
a slope of 26.57 degrees (the arctangent of 0.5).

### `P:Autodesk.Revit.DB.FootPrintRoof.DefinesSlope(Autodesk.Revit.DB.ModelCurve)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FootPrintRoof.DefinesSlope(Autodesk.Revit.DB.ModelCurve)`

#### Summary

Retrieve or set the DefinesSlope of the curve.

### `T:Autodesk.Revit.DB.FootPrintRoof`

Member kind: type
Symbol: `Autodesk.Revit.DB.FootPrintRoof`

#### Summary

Represents kinds of FootPrintRoofs.

#### Remarks

The FootPrintRoof object represents some kinds of FootPrintRoof in Revit. The RoofType
property is used to distinguish the type of the roof.

### `T:Autodesk.Revit.DB.Architecture.FasciaType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.FasciaType`

#### Summary

An object that represents the fascia type
in Autodesk Revit.

### `T:Autodesk.Revit.DB.HostedSweepType`

Member kind: type
Symbol: `Autodesk.Revit.DB.HostedSweepType`

#### Summary

An object that represents the attributes for sweep host objects
in Autodesk Revit.

### `M:Autodesk.Revit.DB.Architecture.Fascia.AddSegment(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Fascia.AddSegment(Autodesk.Revit.DB.Reference)`

#### Summary

Add segments to the fascia.

#### Parameter `targetRef`

Segment's reference on which want to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

This exception will be thrown in following cases:
1. Input targetRef is `null` .
2. Input targetRef is not `null` but contains nothing.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This exception will be thrown in following cases:
1. Input targetRef has already been added into the fascia.
2. Internal code fails to create the segment object.
3. Regeneration fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

This exception will be thrown if the reference is suitable for creating a fascia as required.
The reference allowed is :
1. Model Line
2. Roof's horizontal edges
3. Soffit's horizontal edges
4. Other fascia's horizontal edges

### `P:Autodesk.Revit.DB.Architecture.Fascia.FasciaType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Fascia.FasciaType`

#### Summary

Retrieves/set an object that represents the type of the Fascia.

### `T:Autodesk.Revit.DB.Architecture.Fascia`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.Fascia`

#### Summary

An object that represents a fascia within the Autodesk Revit project.

#### Remarks

This object derived from the Element base object and such supports all the
methods of that object such as the ability to retrieve the parameters of that object.

### `M:Autodesk.Revit.DB.HostedSweep.AddSegment(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HostedSweep.AddSegment(Autodesk.Revit.DB.Reference)`

#### Summary

Add segments to the hosted sweep object.

### `M:Autodesk.Revit.DB.HostedSweep.GetEndPointParameter(Autodesk.Revit.DB.Reference,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HostedSweep.GetEndPointParameter(Autodesk.Revit.DB.Reference,System.Int32)`

#### Summary

Retrieve segment's start point or end point parameter.

#### Parameter `targetRef`

Segment's reference whose parameter want to be get.

#### Parameter `endIdx`

Start point (=0) or end point (=1).

#### Returns

Start point or end point parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration fails.

### `M:Autodesk.Revit.DB.HostedSweep.SetEndPointParameter(Autodesk.Revit.DB.Reference,System.Int32,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HostedSweep.SetEndPointParameter(Autodesk.Revit.DB.Reference,System.Int32,System.Double)`

#### Summary

Set segment's start point or end point parameter.

#### Parameter `targetRef`

Segment's reference whose parameter want to be set.

#### Parameter `endIdx`

Start point (=0) or end point (=1).

#### Parameter `param`

Value of parameter.

#### Returns

true if operation success.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration fails.

### `M:Autodesk.Revit.DB.HostedSweep.RemoveSegment(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.HostedSweep.RemoveSegment(Autodesk.Revit.DB.Reference)`

#### Summary

Remove segments from the hosted sweep object.

#### Parameter `targetRef`

Segment's reference which want to be removed.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration fails.

### `M:Autodesk.Revit.DB.HostedSweep.VerticalFlip`

Member kind: method
Symbol: `Autodesk.Revit.DB.HostedSweep.VerticalFlip`

#### Summary

Flip the hosted sweep object along vertical line.

### `M:Autodesk.Revit.DB.HostedSweep.HorizontalFlip`

Member kind: method
Symbol: `Autodesk.Revit.DB.HostedSweep.HorizontalFlip`

#### Summary

Flip the hosted sweep object along horizontal line.

### `P:Autodesk.Revit.DB.HostedSweep.ReferenceCurve(Autodesk.Revit.DB.Reference)`

Member kind: property
Symbol: `Autodesk.Revit.DB.HostedSweep.ReferenceCurve(Autodesk.Revit.DB.Reference)`

#### Summary

The curve on which the hosted sweep segment is created.

#### Parameter `targetRef`

Reference of the curve that hosts the object.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration fails.

### `P:Autodesk.Revit.DB.HostedSweep.VerticalFlipped`

Member kind: property
Symbol: `Autodesk.Revit.DB.HostedSweep.VerticalFlipped`

#### Summary

Retrieve the vertical flip status of the hosted sweep object.

### `P:Autodesk.Revit.DB.HostedSweep.HorizontalFlipped`

Member kind: property
Symbol: `Autodesk.Revit.DB.HostedSweep.HorizontalFlipped`

#### Summary

Retrieve the horizontal flip status of the hosted sweep object.

### `P:Autodesk.Revit.DB.HostedSweep.Angle`

Member kind: property
Symbol: `Autodesk.Revit.DB.HostedSweep.Angle`

#### Summary

Retrieve/set the angle of the hosted sweep object relative its references (Unit : Radian).

### `P:Autodesk.Revit.DB.HostedSweep.VerticalOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.HostedSweep.VerticalOffset`

#### Summary

Retrieve/set the vertical offset of the hosted sweep object.

### `P:Autodesk.Revit.DB.HostedSweep.HorizontalOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.HostedSweep.HorizontalOffset`

#### Summary

Retrieve/set the horizontal offset of the hosted sweep object.

### `P:Autodesk.Revit.DB.HostedSweep.Length`

Member kind: property
Symbol: `Autodesk.Revit.DB.HostedSweep.Length`

#### Summary

Retrieve the length of the hosted sweep object.

### `T:Autodesk.Revit.DB.HostedSweep`

Member kind: type
Symbol: `Autodesk.Revit.DB.HostedSweep`

#### Summary

An object that represents an object hosted by an edge of a roof or floor within the Autodesk Revit project.

### `P:Autodesk.Revit.DB.Mechanical.MechanicalFitting.PartType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalFitting.PartType`

#### Summary

The part type of the mechanical fitting.

### `T:Autodesk.Revit.DB.Mechanical.MechanicalFitting`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalFitting`

#### Summary

A mechanical fitting in the Autodesk Revit MEP product.

#### Remarks

The mechanical fitting is only available in the Autodesk Revit MEP product.

### `T:Autodesk.Revit.DB.Mechanical.MechanicalEquipment`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalEquipment`

#### Summary

Provides access to the Mechanical Equipment in Autodesk Revit MEP.

#### Remarks

The Mechanical Equipment object can only be queried in Autodesk Revit MEP.

### `T:Autodesk.Revit.DB.Electrical.LightingFixture`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.LightingFixture`

#### Summary

Provides access to the Lighting Fixture in Autodesk Revit MEP.

#### Remarks

The Lighting Fixture object can only be queried in Autodesk Revit MEP.

### `T:Autodesk.Revit.DB.Electrical.LightingDevice`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.LightingDevice`

#### Summary

Provides access to the Lighting Device in Autodesk Revit MEP.

#### Remarks

The Lighting Device object can only be queried in Autodesk Revit MEP.

### `M:Autodesk.Revit.DB.Form.Rehost(Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.Rehost(Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.XYZ)`

#### Summary

Rehost Form to sketch plane

#### Parameter `sketchPlane`

The sketch plane on which to rehost the form.

#### Parameter `location`

The location to which to Rehost the form.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the sketchPlane or location is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when rehosting Form failed.

#### Since

2011

### `M:Autodesk.Revit.DB.Form.Rehost(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.Rehost(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

#### Summary

Rehost Form to edge, face or curve.

#### Parameter `hostRef`

The geometry reference on which to rehost the form.

#### Parameter `location`

The location to which to Rehost the form.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the hostRef or location is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when rehosting Form failed.

#### Since

2011

### `P:Autodesk.Revit.DB.Form.BaseOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Form.BaseOffset`

#### Summary

Retrieve/set the base offset of the form object. It is only valid for locked form.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this is not a locked form.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the value is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ApplicationException`

Thrown when it fail to get/set BaseOffset.

### `P:Autodesk.Revit.DB.Form.TopOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Form.TopOffset`

#### Summary

Retrieve/set the top offset of the form object. It is only valid for locked form.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this is not a locked form.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the value is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ApplicationException`

Thrown when it fail to get/set TopOffset.

### `M:Autodesk.Revit.DB.Form.AddProfile(Autodesk.Revit.DB.Reference,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.AddProfile(Autodesk.Revit.DB.Reference,System.Double)`

#### Summary

Add a profile into the form, by a specified edge/param.

#### Parameter `edgeReference`

The geometry reference of edge.

#### Parameter `param`

The param on edge to specify the location.

#### Returns

Index of newly created profile.

### `M:Autodesk.Revit.DB.Form.AddEdge(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.AddEdge(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference)`

#### Summary

Add an edge to the form, connecting two edges on same/different profile, by a pair of specified points.

#### Parameter `startPointReference`

The geometry reference of start point

#### Parameter `endPointReference`

The geometry reference of end point

### `M:Autodesk.Revit.DB.Form.AddEdge(Autodesk.Revit.DB.Reference,System.Double,Autodesk.Revit.DB.Reference,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.AddEdge(Autodesk.Revit.DB.Reference,System.Double,Autodesk.Revit.DB.Reference,System.Double)`

#### Summary

Add an edge to the form, connecting two edges on same/different profile, by a pair of specified edge/param.

#### Parameter `startEdgeReference`

The geometry reference of start edge

#### Parameter `startParam`

The param on start edge to specify the location.

#### Parameter `endEdgeReference`

The geometry reference of end edge

#### Parameter `endParam`

The param on end edge to specify the location.

### `M:Autodesk.Revit.DB.Form.AddEdge(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.AddEdge(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

#### Summary

Add an edge to the form, connecting two edges on different profiles, by a specified face of the form and a point on face.

#### Parameter `faceReference`

The geometry reference of face

#### Parameter `point`

A point on the face, defining the position of edge to be created.

### `M:Autodesk.Revit.DB.Form.ScaleProfile(System.Int32,System.Double,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.ScaleProfile(System.Int32,System.Double,Autodesk.Revit.DB.XYZ)`

#### Summary

Scale a profile of the form, by a specified origin and scale factor.

#### Parameter `profileIndex`

Index to specify the profile.

#### Parameter `factor`

The scale factor, it should be large than zero.

#### Parameter `origin`

The origin where scale happens.

### `M:Autodesk.Revit.DB.Form.ScaleSubElement(Autodesk.Revit.DB.Reference,System.Double,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.ScaleSubElement(Autodesk.Revit.DB.Reference,System.Double,Autodesk.Revit.DB.XYZ)`

#### Summary

Scale a face/edge/curve/vertex of the form, by a specified origin and scale factor.

#### Parameter `subElementReference`

The geometry reference of face/edge/curve/vertex

#### Parameter `factor`

The scale factor, it should be large than zero.

#### Parameter `origin`

The origin where scale happens.

### `M:Autodesk.Revit.DB.Form.RotateProfile(System.Int32,Autodesk.Revit.DB.Line,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.RotateProfile(System.Int32,Autodesk.Revit.DB.Line,System.Double)`

#### Summary

Rotate a profile of the form, by a specified angle around a given axis.

#### Parameter `profileIndex`

Index to specify the profile.

#### Parameter `axis`

An unbounded line that represents the axis of rotation.

#### Parameter `angle`

The angle, in radians, by which the element is to be rotated around the specified axis.

### `M:Autodesk.Revit.DB.Form.RotateSubElement(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Line,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.RotateSubElement(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Line,System.Double)`

#### Summary

Rotate a face/edge/curve/vertex of the form, by a specified angle around a given axis.

#### Parameter `subElementReference`

The geometry reference of face/edge/curve/vertex

#### Parameter `axis`

An unbounded line that represents the axis of rotation.

#### Parameter `angle`

The angle, in radians, by which the element is to be rotated around the specified axis.

### `M:Autodesk.Revit.DB.Form.MoveProfile(System.Int32,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.MoveProfile(System.Int32,Autodesk.Revit.DB.XYZ)`

#### Summary

Move a profile of the form, specified by a reference, and an offset vector.

#### Parameter `profileIndex`

Index to specify the profile.

#### Parameter `offset`

The vector by which the element is to be moved.

### `M:Autodesk.Revit.DB.Form.MoveSubElement(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.MoveSubElement(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ)`

#### Summary

Move a face/edge/curve/vertex of the form, specified by a reference, and an offset vector.

#### Parameter `subElementReference`

The geometry reference of face/edge/curve/vertex

#### Parameter `offset`

The vector by which the element is to be moved.

### `M:Autodesk.Revit.DB.Form.DeleteProfile(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.DeleteProfile(System.Int32)`

#### Summary

Delete a profile of the form.

#### Parameter `profileIndex`

Index to specify the profile.

### `M:Autodesk.Revit.DB.Form.DeleteSubElement(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.DeleteSubElement(Autodesk.Revit.DB.Reference)`

#### Summary

Delete a face/edge/curve/vertex of the form, specified by a reference.

#### Parameter `subElementReference`

The geometry reference of face/edge/curve/vertex

### `M:Autodesk.Revit.DB.Form.CanManipulateProfile(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.CanManipulateProfile(System.Int32)`

#### Summary

Tell if a profile can be deleted/moved/rotated.

#### Parameter `profileIndex`

Index to specify the profile.

#### Remark

It only gives an aggressive answer. Some operations may still cause failure, even this method says "yes".

### `M:Autodesk.Revit.DB.Form.CanManipulateSubElement(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.CanManipulateSubElement(Autodesk.Revit.DB.Reference)`

#### Summary

Tell if a sub element can be deleted/moved/rotated/scaled.

#### Parameter `subElementReference`

The geometry reference of face/edge/curve/vertex

#### Remark

It only gives an aggressive answer. Some operations may still cause failure, even this method says "yes".

### `M:Autodesk.Revit.DB.Form.GetCurvesAndEdgesReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.GetCurvesAndEdgesReference(Autodesk.Revit.DB.Reference)`

#### Summary

Given a point, return all edges and curves that it is lying on.

#### Parameter `pointReference`

The reference of a point.

#### Returns

Reference array containing all edges and curves that the point is lying on.

### `M:Autodesk.Revit.DB.Form.GetControlPoints(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.GetControlPoints(Autodesk.Revit.DB.Reference)`

#### Summary

Given an edge or a curve or a face, return all control points lying on it (in form of geometry references).

#### Parameter `curveOrEdgeOrFaceReference`

The reference of an edge or curve or face.

#### Returns

Reference array containing all control points lying on it.

### `M:Autodesk.Revit.DB.Form.IsConnectingEdge(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.IsConnectingEdge(Autodesk.Revit.DB.Reference)`

#### Summary

Tell if an edge is a connecting edge on a side face. Connecting edges connect vertices on different profiles.

#### Parameter `edgeReference`

The reference of the edge to be checked.

### `M:Autodesk.Revit.DB.Form.IsProfileEdge(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.IsProfileEdge(Autodesk.Revit.DB.Reference)`

#### Summary

Tell if an edge or curve is generated from a profile.

#### Parameter `curveOrEdgeReference`

The reference of the edge or curve to be checked.

### `M:Autodesk.Revit.DB.Form.IsAutoCreaseEdge(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.IsAutoCreaseEdge(Autodesk.Revit.DB.Reference)`

#### Summary

Tell if an edge is an auto-crease on a top/bottom cap face.

#### Parameter `edgeReference`

The reference of the edge to be checked.

#### Remark

An auto crease edge is created when top/bottom cap face cannot be made by a planar face.

### `M:Autodesk.Revit.DB.Form.IsSideFace(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.IsSideFace(Autodesk.Revit.DB.Reference)`

#### Summary

Given a face, tell if it is a side face.

#### Parameter `faceReference`

The reference of the face to be checked.

### `M:Autodesk.Revit.DB.Form.IsEndFace(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.IsEndFace(Autodesk.Revit.DB.Reference)`

#### Summary

Given a face, tell if it is an end cap face.

#### Parameter `faceReference`

The reference of the face to be checked.

### `M:Autodesk.Revit.DB.Form.IsBeginningFace(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.IsBeginningFace(Autodesk.Revit.DB.Reference)`

#### Summary

Given a face, tell if it is a beginning cap face.

#### Parameter `faceReference`

The reference of the face to be checked.

### `M:Autodesk.Revit.DB.Form.IsReferenceOnlyProfile(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.IsReferenceOnlyProfile(System.Int32)`

#### Summary

Tell if the profile is made by referencing existing geometry in the Revit model.

#### Parameter `profileIndex`

Index to specify the profile to be checked.

### `M:Autodesk.Revit.DB.Form.IsFaceReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.IsFaceReference(Autodesk.Revit.DB.Reference)`

#### Summary

Tell if the pick is the reference to a face of the form.

#### Parameter `faceReference`

Reference to be checked.

### `M:Autodesk.Revit.DB.Form.IsCurveReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.IsCurveReference(Autodesk.Revit.DB.Reference)`

#### Summary

Tell if the pick is the reference to a curve of the form.

#### Parameter `curveReference`

Reference to be checked.

### `M:Autodesk.Revit.DB.Form.IsEdgeReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.IsEdgeReference(Autodesk.Revit.DB.Reference)`

#### Summary

Tell if the pick is the reference to an edge of the form.

#### Parameter `edgeReference`

Reference to be checked.

### `M:Autodesk.Revit.DB.Form.IsVertexReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.IsVertexReference(Autodesk.Revit.DB.Reference)`

#### Summary

Tell if the pick is the reference to a vertex of the form.

#### Parameter `vertexReference`

Reference to be checked.

### `P:Autodesk.Revit.DB.Form.HasOpenGeometry`

Member kind: property
Symbol: `Autodesk.Revit.DB.Form.HasOpenGeometry`

#### Summary

Tell if the form has an open geometry.

### `M:Autodesk.Revit.DB.Form.ConstrainProfiles(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.ConstrainProfiles(System.Int32)`

#### Summary

Constrain form profiles using the specified profile as primary. This is an advanced version of property "AreProfilesConstrained", allowing specify the primary profile.

#### Parameter `primaryProfileIndex`

Index to specify the profile used as primary profile.

#### Remark

If "primaryProfileIndex" is less than zero, the form will become unconstrained, it has the same effect as "AreProfilesConstrained = false".

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation can only be performed on a swept blend form.

### `P:Autodesk.Revit.DB.Form.AreProfilesConstrained`

Member kind: property
Symbol: `Autodesk.Revit.DB.Form.AreProfilesConstrained`

#### Summary

Get/set if the form's profiles are constrained.

#### Remark

There is another method "constrainProfile" to constrain profile using certain profile as the primary one.
If this property is used to constrain the form, the first profile will be automatically selected as primary profile.
When form profiles are constrained, changing one profile also changes all other profiles at the same time.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property to 'true'
This operation can only be performed on a swept blend form.

### `P:Autodesk.Revit.DB.Form.IsInXRayMode`

Member kind: property
Symbol: `Autodesk.Revit.DB.Form.IsInXRayMode`

#### Summary

Get/set if the form is in X-Ray mode.

### `P:Autodesk.Revit.DB.Form.HasOneOrMoreReferenceProfiles`

Member kind: property
Symbol: `Autodesk.Revit.DB.Form.HasOneOrMoreReferenceProfiles`

#### Summary

Tell if the form has any reference profile.

### `M:Autodesk.Revit.DB.Form.GetPathCurveIndexByCurveReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.GetPathCurveIndexByCurveReference(Autodesk.Revit.DB.Reference)`

#### Summary

Given a reference to certain curve in the path, return its index.

#### Parameter `curveReference`

Reference to the curve in path

### `P:Autodesk.Revit.DB.Form.PathCurveReference(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Form.PathCurveReference(System.Int32)`

#### Summary

The curve reference in the path, specified by curve index.

#### Parameter `curveIndex`

Index to specify the curve in path

### `P:Autodesk.Revit.DB.Form.PathCurveCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Form.PathCurveCount`

#### Summary

The number of curves in the form path.

### `M:Autodesk.Revit.DB.Form.GetProfileAndCurveLoopIndexFromReference(Autodesk.Revit.DB.Reference,System.Int32@,System.Int32@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Form.GetProfileAndCurveLoopIndexFromReference(Autodesk.Revit.DB.Reference,System.Int32@,System.Int32@)`

#### Summary

Given a reference to certain curve or edge, get the index of its profile and curve loop respectively.

#### Parameter `curveOrEdgeReference`

Reference to a curve/edge that is part of one profile

#### Parameter `profileIndex`

Profile index for output

#### Parameter `curveLoopIndex`

Curve loop index for output

#### Remark

Usually a profile generates edges, but sometimes it generates curves. For example, if there is a middle profile which does not change the
shape of form, curves are generated instead of edges.

### `P:Autodesk.Revit.DB.Form.CurveLoopReferencesOnProfile(System.Int32,System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Form.CurveLoopReferencesOnProfile(System.Int32,System.Int32)`

#### Summary

The curve references in certain curve loop, specified by profile index and curve loop index.

#### Parameter `profileIndex`

Index to specify the profile, should be within 0 and (ProfileCount - 1).

#### Parameter `curveLoopIndex`

Index to specify the curve loop, should be within 0 and (CurveLoopCount - 1).

### `P:Autodesk.Revit.DB.Form.ProfileCurveLoopCount(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Form.ProfileCurveLoopCount(System.Int32)`

#### Summary

The number of curve loops in certain profile, specified by profile index.

#### Parameter `index`

Index to specify the profile, should be within 0 and (ProfileCount - 1).

### `P:Autodesk.Revit.DB.Form.ProfileCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Form.ProfileCount`

#### Summary

The number of profiles in the form.

### `T:Autodesk.Revit.DB.Form`

Member kind: type
Symbol: `Autodesk.Revit.DB.Form`

#### Summary

An object that represents a Form within the Autodesk Revit Massing Family.

#### Remarks

For any reference returned from a Form method, its GeometryObject will become invalid after a form modification method, e.g. MoveSubElement.
Call the method on the Form object to retrieve the new reference if it is needed after the modification.

### `P:Autodesk.Revit.DB.FamilyPointPlacementReference.PointReference`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyPointPlacementReference.PointReference`

#### Summary

The reference on which the point depends on.

### `P:Autodesk.Revit.DB.FamilyPointPlacementReference.Location`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyPointPlacementReference.Location`

#### Summary

The location of the point.

### `P:Autodesk.Revit.DB.FamilyPointPlacementReference.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyPointPlacementReference.Name`

#### Summary

The name of the corresponding reference point in the Family document.

### `T:Autodesk.Revit.DB.FamilyPointPlacementReference`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyPointPlacementReference`

#### Summary

This object represents data corresponding to the placement references in a
certain types of Family Instances (see examples listed below).

#### Remarks

Examples of FamilyInstance objects that contain placement references are Panels
and Flexible Components.

### `P:Autodesk.Revit.DB.IExtension.IsMiterLocked(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.IExtension.IsMiterLocked(System.Int32)`

#### Summary

Retrieves or set the miter locked status at the end.

#### Remarks

Property index must be 0 or 1 to indicate two ends, otherwise exceptions will be thrown.
For beams, only if the beam is extended and is mitered with other beams at the end,
it can be locked. Otherwise, the setting is invalid

### `P:Autodesk.Revit.DB.IExtension.HasMiter(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.IExtension.HasMiter(System.Int32)`

#### Summary

Retrieves the miter status at the end

#### Remarks

Property index must be 0 or 1 to indicate two ends, otherwise exceptions will be thrown.
For beams, this can check whether the beam is mitered with other beams at the end

### `P:Autodesk.Revit.DB.IExtension.SymbolicExtended(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.IExtension.SymbolicExtended(System.Int32)`

#### Summary

Retrieves or set the symbolic extension status at the end

#### Remarks

Property index must be 0 or 1 to indicate two ends, otherwise exceptions will be thrown.
For beams, symbolic extension setting only works when the beam is extended, mitered, and miter locked
at the end. Otherwise the setting is invalid

### `P:Autodesk.Revit.DB.IExtension.Extended(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.IExtension.Extended(System.Int32)`

#### Summary

Retrieves or set the extension status at the end

#### Remarks

Property index must be 0 or 1 to indicate two ends, otherwise exceptions will be thrown.
For beams, if the beam extension status is changed, other status such as
the symbolic extension status, miter status, miter locked status, and
other beams extension status will be changed automatically at the same time.
This change can protect that a join can have up to two extended beams, if
there are two extended beams at the join, they shall be mitered.

### `T:Autodesk.Revit.DB.IExtension`

Member kind: type
Symbol: `Autodesk.Revit.DB.IExtension`

#### Summary

An interface that supports the additional operation for Extension Status

### `M:Autodesk.Revit.DB.ModelCurve.ChangeToReferenceLine`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurve.ChangeToReferenceLine`

#### Summary

Changes this curve to a reference curve.

### `P:Autodesk.Revit.DB.ModelCurve.IsReferenceLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelCurve.IsReferenceLine`

#### Summary

Indicates if this curve is a reference curve.

### `P:Autodesk.Revit.DB.ModelCurve.TrussCurveType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelCurve.TrussCurveType`

#### Summary

The truss curve type of this model curve.

#### Remarks

This property is applicable only to curves in Truss families.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the assigned value for TrussCurveType is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when attempting to set this property to a curve not in a truss family.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when attempting to change truss curves to NonTrussCurve, or when
the truss curve type may not be applied to curves of this shape (webs must be linear, and chords must be linear or arc).

### `P:Autodesk.Revit.DB.ModelCurve.Subcategory`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelCurve.Subcategory`

#### Summary

The subcategory.

#### Remarks

If the family category is non-cuttable, the subcategory can be
set to be the family category or one of its subcategories.
If the family category is cuttable, the subcategory can be set as the graphics
styles of the family category, its subcategories, or the invisible lines graphics style.

### `M:Autodesk.Revit.DB.ModelCurve.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurve.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

#### Summary

Sets the visibility for the model curve in a family document.

#### Remarks

The visibility of the model curve geometry can be changed for different
types of views and detail levels in the family document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when visibility is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration failed, or the model curve is in a project document.

### `M:Autodesk.Revit.DB.ModelCurve.GetVisibility`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurve.GetVisibility`

#### Summary

Gets the visibility for the model curve in a family document.

#### Returns

A copy of visibility settings for the model curve in a family document.

### `T:Autodesk.Revit.DB.ModelCurve`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelCurve`

#### Summary

A model element that exists in 3D space and is visible in all views of a Revit project.

### `P:Autodesk.Revit.DB.ExtrusionRoof.CurtainGrids`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExtrusionRoof.CurtainGrids`

#### Summary

Retrieve all the CurtainGrid objects of a curtain Roof.

#### Remarks

Only when the object is a CurtainRoof, this property makes sense.

### `M:Autodesk.Revit.DB.ExtrusionRoof.GetProfile`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExtrusionRoof.GetProfile`

#### Summary

Retrieve the Profile of ExtrusionRoof.

### `T:Autodesk.Revit.DB.ExtrusionRoof`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExtrusionRoof`

#### Summary

Represents some kinds of Extrusion Roofs.

#### Remarks

The ExtrusionRoof object represents some kinds of extruded roofs in Revit.

### `M:Autodesk.Revit.DB.RoofBase.GetSlabShapeEditor`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoofBase.GetSlabShapeEditor`

#### Summary

Gets a SlabShapeEditor that can used to add or modify points of this RoofBase.

#### Returns

The SlabShapeEditor object

### `P:Autodesk.Revit.DB.RoofBase.SlabShapeEditor`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoofBase.SlabShapeEditor`

#### Summary

Get the SlabShapeEditor used for slab shape editing.

#### Remarks

Roofs cannot be attached to another roof, and the roof cannot be a curtain roof. If either of these conditions is not met, the ShapeEditor will be `null` .

### `P:Autodesk.Revit.DB.RoofBase.FasciaDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoofBase.FasciaDepth`

#### Summary

Retrieve or set the FasciaDepth.

#### Remarks

If the EaveCutterType is PlumbCut, this property doesn't make sense.

### `P:Autodesk.Revit.DB.RoofBase.EaveCuts`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoofBase.EaveCuts`

#### Summary

Retrieve or set the EaveCutterType.

### `P:Autodesk.Revit.DB.RoofBase.RoofType`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoofBase.RoofType`

#### Summary

Retrieve or set the Type.

### `T:Autodesk.Revit.DB.RoofBase`

Member kind: type
Symbol: `Autodesk.Revit.DB.RoofBase`

#### Summary

Represents all kinds of Roofs.

#### Remarks

The RoofBase object represents all kinds of roof in Revit.

### `P:Autodesk.Revit.DB.Extrusion.EndOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Extrusion.EndOffset`

#### Summary

The offset of the end of the extrusion relative to the sketch plane.

#### Remarks

The direction of the offset is based on the normal of the extrusion's sketch
plane: a positive value is in the direction of the normal, a negative value is in the
other direction.

### `P:Autodesk.Revit.DB.Extrusion.StartOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Extrusion.StartOffset`

#### Summary

The offset of the start of the extrusion relative to the sketch plane.

#### Remarks

The direction of the offset is based on the normal of the extrusion's sketch
plane: a positive value is in the direction of the normal, a negative value is in the
other direction.

### `P:Autodesk.Revit.DB.Extrusion.Sketch`

Member kind: property
Symbol: `Autodesk.Revit.DB.Extrusion.Sketch`

#### Summary

Returns the Sketch of the Extrusion.

#### Remarks

This property is used to retrieve the Sketches of the Extrusion.

### `T:Autodesk.Revit.DB.Extrusion`

Member kind: type
Symbol: `Autodesk.Revit.DB.Extrusion`

#### Summary

A extrusion solid or void form.

### `M:Autodesk.Revit.DB.DesignOption.GetActiveDesignOptionId(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DesignOption.GetActiveDesignOptionId(Autodesk.Revit.DB.Document)`

#### Summary

Gets the active design option id for the current design option set.

#### Parameter `document`

The document.

#### Returns

The active design option id. It can be invalid id if there is no active design option in the model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.DesignOption.IsPrimary`

Member kind: property
Symbol: `Autodesk.Revit.DB.DesignOption.IsPrimary`

#### Summary

Determines whether this is a primary design option.

### `T:Autodesk.Revit.DB.DesignOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.DesignOption`

#### Summary

An element that represents a design alternative.

#### Remarks

Design options enable the user to add alternative designs within the same project.
Each element can either be in a design option or not at all, in which case it is considered
to be part of the main model and have no design alternatives.

### `P:Autodesk.Revit.DB.SpacingRule.BeltMeasurement`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpacingRule.BeltMeasurement`

#### Summary

On a curved surface, BeltMeasurement specifies where the
grid's distances are measured.

#### Remarks

On a conical surface, the distance between the radial gridlines is
not constant. To interpret the Distance property, a circumferential
gridline is taken as the "belt." Distance is then measured along
the belt. The BeltMeasurement property gives the location of the
belt relative to the extremes of the surface. The belt is used
whenever gridlines are not parallel. It defaults to 0.5.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when beltMeasurement is outside the range [ 0.0, 1.0 ].

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the gridlines are guaranteed to be parallel; check the
`P:Autodesk.Revit.DB.SpacingRule.HasBeltMeasurement` property before using this property.

### `P:Autodesk.Revit.DB.SpacingRule.HasBeltMeasurement`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpacingRule.HasBeltMeasurement`

#### Summary

True if the gridlines are not parallel due to surface
curvature, and the BeltMeasurement property therefore
applies.

### `P:Autodesk.Revit.DB.SpacingRule.Offset`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpacingRule.Offset`

#### Summary

An additional offset applied to the first
gridline.

#### Remarks

Measured in feet. Must be between -30000' and
30000'.

### `P:Autodesk.Revit.DB.SpacingRule.GridlinesRotation`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpacingRule.GridlinesRotation`

#### Summary

An additional rotation to be applied
to this set of grid lines.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when
angle is outside of the range ( -PI/2, PI/2 ).

### `P:Autodesk.Revit.DB.SpacingRule.Justification`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpacingRule.Justification`

#### Summary

The justification of the lines within
the region.

#### Remarks

This property is only available when
`P:Autodesk.Revit.DB.SpacingRule.Layout` is equal to FixedDistance,
FixedNumber, MaximumSpacing, or MinimumSpacing.

### `P:Autodesk.Revit.DB.SpacingRule.Number`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpacingRule.Number`

#### Summary

The exact number of lines in the
region.

#### Remarks

This property is only available when
`P:Autodesk.Revit.DB.SpacingRule.Layout` is equal to FixedNumber.
Lines will be placed exactly at the boundaries if
possible, so if your region is 100' long and you
specify Number = 11, your lines will be 10'
apart. Must be between 1 and 200.

### `P:Autodesk.Revit.DB.SpacingRule.Distance`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpacingRule.Distance`

#### Summary

The exact distance between layout
lines.

#### Remarks

This property is only available when
`P:Autodesk.Revit.DB.SpacingRule.Layout` is equal to FixedDistance,
MaximumSpacing, or MinimumSpacing. Must be a positive
value less than 30000'.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown
when the `P:Autodesk.Revit.DB.SpacingRule.Layout` property is None or FixedNumber.

### `M:Autodesk.Revit.DB.SpacingRule.SetLayoutMinimumSpacing(System.Double,Autodesk.Revit.DB.SpacingRuleJustification,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpacingRule.SetLayoutMinimumSpacing(System.Double,Autodesk.Revit.DB.SpacingRuleJustification,System.Double,System.Double)`

#### Summary

Set the Layout property to MinimumSpacing.

#### Remarks

When changing the Layout to MinimumSpacing,
you must also simultaneously set the Distance,
Justification, GridlinesRotation, and Offset properties.

### `M:Autodesk.Revit.DB.SpacingRule.SetLayoutMaximumSpacing(System.Double,Autodesk.Revit.DB.SpacingRuleJustification,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpacingRule.SetLayoutMaximumSpacing(System.Double,Autodesk.Revit.DB.SpacingRuleJustification,System.Double,System.Double)`

#### Summary

Set the Layout property to MaximumSpacing.

#### Remarks

When changing the Layout to MaximumSpacing,
you must also simultaneously set the Distance,
Justification, GridlinesRotation, and Offset properties.

### `M:Autodesk.Revit.DB.SpacingRule.SetLayoutFixedNumber(System.Int32,Autodesk.Revit.DB.SpacingRuleJustification,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpacingRule.SetLayoutFixedNumber(System.Int32,Autodesk.Revit.DB.SpacingRuleJustification,System.Double,System.Double)`

#### Summary

Set the Layout property to FixedNumber.

#### Remarks

When changing the Layout to FixedNumber,
you must also simultaneously set the Number,
Justification, GridlinesRotation, and Offset properties.

### `M:Autodesk.Revit.DB.SpacingRule.SetLayoutFixedDistance(System.Double,Autodesk.Revit.DB.SpacingRuleJustification,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpacingRule.SetLayoutFixedDistance(System.Double,Autodesk.Revit.DB.SpacingRuleJustification,System.Double,System.Double)`

#### Summary

Set the Layout property to FixedDistance.

#### Remarks

When changing the Layout to FixedDistance,
you must also simultaneously set the Distance,
Justification, GridlinesRotation, and Offset properties.

### `M:Autodesk.Revit.DB.SpacingRule.SetLayoutNone`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpacingRule.SetLayoutNone`

#### Summary

Set the Layout property to None.

#### Remarks

No internal lines will be
generated, but the effect is equivalent to having two
lines, one at each end of the region.

### `P:Autodesk.Revit.DB.SpacingRule.Layout`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpacingRule.Layout`

#### Summary

A choice of several gridline layout rules.

#### Remarks

If "None" is chosen, no internal lines will be
generated, but the effect is equivalent to having two
lines, one at each end of the region.

### `T:Autodesk.Revit.DB.SpacingRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpacingRule`

#### Summary

A rule for specifying a set of equidistant,
parallel gridlines within a region.

### `T:Autodesk.Revit.DB.SpacingRuleLayout`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpacingRuleLayout`

#### Summary

Rules for laying out a series of equidistant points or parallel lines

### `F:Autodesk.Revit.DB.SpacingRuleLayout.MinimumSpacing`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpacingRuleLayout.MinimumSpacing`

#### Summary

Points or lines are separated by at least the minimum distance.

### `F:Autodesk.Revit.DB.SpacingRuleLayout.MaximumSpacing`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpacingRuleLayout.MaximumSpacing`

#### Summary

Points or lines are separated by at most the max distance.

### `F:Autodesk.Revit.DB.SpacingRuleLayout.FixedNumber`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpacingRuleLayout.FixedNumber`

#### Summary

Fixed number of points or lines with uniform distance between them.

### `F:Autodesk.Revit.DB.SpacingRuleLayout.FixedDistance`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpacingRuleLayout.FixedDistance`

#### Summary

Points or lines are separated by a fixed distance.

### `F:Autodesk.Revit.DB.SpacingRuleLayout.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpacingRuleLayout.None`

#### Summary

No points or lines will be created.

### `T:Autodesk.Revit.DB.SpacingRuleJustification`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpacingRuleJustification`

#### Summary

Justification property of spacing rule

### `M:Autodesk.Revit.DB.DividedSurface.CanBeIntersectionElement(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.CanBeIntersectionElement(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the element can be an intersection reference.

#### Remarks

The element must be a level, grid, reference plane,
or a curve element whose category is lines and reference lines.

#### Parameter `id`

The element to be checked.

#### Returns

True if the element can be an intersection reference., false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.DividedSurface.RemoveAllIntersectionElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.RemoveAllIntersectionElements`

#### Summary

Removes all the intersection elements from a divided surface.

#### Since

2011

### `M:Autodesk.Revit.DB.DividedSurface.RemoveIntersectionElement(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.RemoveIntersectionElement(Autodesk.Revit.DB.ElementId)`

#### Summary

Removes an intersection element from a divided surface.

#### Parameter `referenceElemIdToRemove`

The intersection element to be removed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.DividedSurface.AddIntersectionElement(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.AddIntersectionElement(Autodesk.Revit.DB.ElementId)`

#### Summary

Adds an intersection element to the divided surface.

#### Parameter `newIntersectionElemId`

The intersection element to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element newIntersectionElemId is not a level, grid, reference plane,
or a curve element whose category is lines and reference lines.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.DividedSurface.GetAllIntersectionElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.GetAllIntersectionElements`

#### Summary

Gets all intersection elements which produce division lines.

#### Returns

The intersection elements.

#### Since

2011

### `M:Autodesk.Revit.DB.DividedSurface.GetDividedSurfaceForReference(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.GetDividedSurfaceForReference(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

#### Summary

Get a divided surface for a given reference. Returns null if the reference does not host a divided surface.

#### Parameter `document`

The document.

#### Parameter `faceReference`

Reference that represents a face.

#### Returns

The newly created divided surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.DividedSurface.GetReferencesWithDividedSurfaces(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.GetReferencesWithDividedSurfaces(Autodesk.Revit.DB.Element)`

#### Summary

For a given host element get references to all the faces that host a divided surface

#### Parameter `host`

The element that hosts the divided surfaces

#### Returns

References that host a divided surface

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.DividedSurface.CanBeDivided(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.CanBeDivided(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

#### Summary

This returns true if the reference represents a face that can be used to create a divided surface.

#### Parameter `document`

The document.

#### Parameter `reference`

The reference.

#### Returns

True if the reference can be used to create a divided surface, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.DividedSurface.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

#### Summary

Creates a new instance of a divided surface with a default layout.

#### Parameter `document`

The document.

#### Parameter `faceReference`

Reference that represents a face.

#### Returns

The newly created divided surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document does not allow creation of a divided surface.
-or-
Reference is unstable import element
-or-
Reference does not represent a face
-or-
Reference already hosts a divided surface

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

2014

### `M:Autodesk.Revit.DB.DividedSurface.GetTileFamilyInstance(Autodesk.Revit.DB.GridNode,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.GetTileFamilyInstance(Autodesk.Revit.DB.GridNode,System.Int32)`

#### Summary

Get a reference to a tile element
associated with a given seed node.

#### Returns

A FamilyInstance object. Returns `null` if
the `T:ObjectType` property is not a FamilySymbol.
Returns `null`
if the grid node is not a "seed node", or
if the tile is omitted due to boundary conditions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown if the grid node is outside of the range specified
by NumberOfUGridlines and NumberOfVGridlines,
or if tileIndex is outside the range [0, TilesPerSeedNode-1].

### `M:Autodesk.Revit.DB.DividedSurface.GetTileReference(Autodesk.Revit.DB.GridNode,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.GetTileReference(Autodesk.Revit.DB.GridNode,System.Int32)`

#### Summary

Get a reference to one of the tile surfaces
associated with a given seed node.

#### Parameter `tileIndex`

An integer between 0 and T-1,
where T is `P:Autodesk.Revit.DB.TilePattern.TilesPerSeedNode` .

#### Returns

A reference to a Face (surface). Returns `null`
if the grid node is not a "seed node", or
if the tile is omitted due to boundary conditions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown if the grid node is outside of the range specified
by NumberOfUGridlines and NumberOfVGridlines,
or if tileIndex is outside the range [0, TilesPerSeedNode-1].

### `M:Autodesk.Revit.DB.DividedSurface.IsSeedNode(Autodesk.Revit.DB.GridNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.IsSeedNode(Autodesk.Revit.DB.GridNode)`

#### Summary

Reports whether a grid node is a "seed node," a node
that is associated with one or more tiles.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown
when the grid node indexes are outside the range
[ 0, NumberOfUGridlines - 1 ], [ 0, NumberOfVGridlines - 1 ].

### `M:Autodesk.Revit.DB.DividedSurface.GetGridSegmentReference(Autodesk.Revit.DB.GridNode,Autodesk.Revit.DB.GridSegmentDirection)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.GetGridSegmentReference(Autodesk.Revit.DB.GridNode,Autodesk.Revit.DB.GridSegmentDirection)`

#### Summary

Get a reference to a line segment connecting
two adjacent grid nodes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown
when the grid node indexes are outside the range
[ 0, NumberOfUGridlines - 1 ], [ 0, NumberOfVGridlines - 1 ],
or when the adjacent grid node specified by
gridSegmentDirection is out of range.

### `M:Autodesk.Revit.DB.DividedSurface.GetGridNodeReference(Autodesk.Revit.DB.GridNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.GetGridNodeReference(Autodesk.Revit.DB.GridNode)`

#### Summary

Get a reference to the geometric point
associated with a grid node.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown
when the grid node indexes are outside the range
[ 0, NumberOfUGridlines - 1 ], [ 0, NumberOfVGridlines - 1 ].

### `M:Autodesk.Revit.DB.DividedSurface.GetGridNodeLocation(Autodesk.Revit.DB.GridNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.GetGridNodeLocation(Autodesk.Revit.DB.GridNode)`

#### Summary

Specify whether a particular grid node is
interior to the surface, on the boundary, or outside
the boundary.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown
when the grid node indexes are outside the range
[ 0, NumberOfUGridlines - 1 ], [ 0, NumberOfVGridlines - 1 ].

### `M:Autodesk.Revit.DB.DividedSurface.GetGridNodeUV(Autodesk.Revit.DB.GridNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DividedSurface.GetGridNodeUV(Autodesk.Revit.DB.GridNode)`

#### Summary

Get the position of a grid node in UV
coordinates in the surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown
when the grid node indexes are outside the range
[ 0, NumberOfUGridlines - 1 ], [ 0, NumberOfVGridlines - 1 ].

### `P:Autodesk.Revit.DB.DividedSurface.NumberOfVGridlines`

Member kind: property
Symbol: `Autodesk.Revit.DB.DividedSurface.NumberOfVGridlines`

#### Summary

Get the number of V-gridlines used on the
surface.

### `P:Autodesk.Revit.DB.DividedSurface.NumberOfUGridlines`

Member kind: property
Symbol: `Autodesk.Revit.DB.DividedSurface.NumberOfUGridlines`

#### Summary

Get the number of U-gridlines used on the
surface.

### `P:Autodesk.Revit.DB.DividedSurface.IsComponentFlipped`

Member kind: property
Symbol: `Autodesk.Revit.DB.DividedSurface.IsComponentFlipped`

#### Summary

Whether the pattern is flipped.

#### Remarks

This property has no effect unless a pattern
is selected (the ObjectType property is not `null` ).
Changing this flag effectively reflects the component
through its XY-plane, which is equivalent to reflecting
it through the original surface.

### `P:Autodesk.Revit.DB.DividedSurface.IsComponentMirrored`

Member kind: property
Symbol: `Autodesk.Revit.DB.DividedSurface.IsComponentMirrored`

#### Summary

Whether the pattern is mirror-imaged.

#### Remarks

This property has no effect unless a pattern
is selected (the ObjectType property is not `null` ).
Changing this flag effectively reflects the component
through its YZ-plane.

### `P:Autodesk.Revit.DB.DividedSurface.ComponentRotation`

Member kind: property
Symbol: `Autodesk.Revit.DB.DividedSurface.ComponentRotation`

#### Summary

The rotation of the pattern by a multiple
of 90 degrees.

#### Remarks

This property has no effect unless a pattern
is selected (the ObjectType property is not `null` ).

### `P:Autodesk.Revit.DB.DividedSurface.VPatternIndent`

Member kind: property
Symbol: `Autodesk.Revit.DB.DividedSurface.VPatternIndent`

#### Summary

The offset applied to the pattern by an
integral number of grid nodes in the V-direction.

### `P:Autodesk.Revit.DB.DividedSurface.UPatternIndent`

Member kind: property
Symbol: `Autodesk.Revit.DB.DividedSurface.UPatternIndent`

#### Summary

The offset applied to the pattern by an
integral number of grid nodes in the U-direction.

### `P:Autodesk.Revit.DB.DividedSurface.BorderTile`

Member kind: property
Symbol: `Autodesk.Revit.DB.DividedSurface.BorderTile`

#### Summary

Determines the handling of tiles that overlap the surface's
boundary.

### `P:Autodesk.Revit.DB.DividedSurface.AllGridRotation`

Member kind: property
Symbol: `Autodesk.Revit.DB.DividedSurface.AllGridRotation`

#### Summary

Angle of rotation applied to the U- and V- directions together.

### `P:Autodesk.Revit.DB.DividedSurface.VSpacingRule`

Member kind: property
Symbol: `Autodesk.Revit.DB.DividedSurface.VSpacingRule`

#### Summary

Access to the rule for laying out the second series of equidistant
parallel lines on the surface.

### `P:Autodesk.Revit.DB.DividedSurface.USpacingRule`

Member kind: property
Symbol: `Autodesk.Revit.DB.DividedSurface.USpacingRule`

#### Summary

Access to the rule for laying out the first series of equidistant
parallel lines on the surface.

### `P:Autodesk.Revit.DB.DividedSurface.HostReference`

Member kind: property
Symbol: `Autodesk.Revit.DB.DividedSurface.HostReference`

#### Summary

A reference to the divided face on the host.

#### Remarks

This is the same as the hostReference argument
to the NewDividedSurface method of `T:Autodesk.Revit.Creation.FamilyItemFactory` .

### `P:Autodesk.Revit.DB.DividedSurface.Host`

Member kind: property
Symbol: `Autodesk.Revit.DB.DividedSurface.Host`

#### Summary

The element whose surface has been divided.

### `T:Autodesk.Revit.DB.DividedSurface`

Member kind: type
Symbol: `Autodesk.Revit.DB.DividedSurface`

#### Summary

An element that represents a mesh on the surface of another element, a family instance, an import instance or a geometry combination,
and a tile pattern built on that mesh.

#### Remarks

The type of this element may be set to:
a TilePattern element,
a FamilySymbol element from a Curtain Panel family.

### `P:Autodesk.Revit.DB.GridNode.VIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.GridNode.VIndex`

#### Summary

The node's index along the V axis.

### `P:Autodesk.Revit.DB.GridNode.UIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.GridNode.UIndex`

#### Summary

The node's index along the U axis.

### `T:Autodesk.Revit.DB.GridNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.GridNode`

#### Summary

A structure that represents a particular location in (U,V) from a grid.

### `T:Autodesk.Revit.DB.DetailNurbSpline`

Member kind: type
Symbol: `Autodesk.Revit.DB.DetailNurbSpline`

#### Summary

Represents a DetailNurbSpline within Autodesk Revit.

#### Remarks

Currently it's just a place holder for specific type.
All the geometry-related functionality is provided by geometry curve object from
DetailCurve::geometryCurve property.

### `T:Autodesk.Revit.DB.DetailLine`

Member kind: type
Symbol: `Autodesk.Revit.DB.DetailLine`

#### Summary

Represents a DetailLine within Autodesk Revit.

#### Remarks

Currently it's just a place holder for specific type.
All the geometry-related functionality is provided by geometry curve object from
DetailCurve::geometryCurve property.

### `T:Autodesk.Revit.DB.DetailEllipse`

Member kind: type
Symbol: `Autodesk.Revit.DB.DetailEllipse`

#### Summary

Represents a DetailEllipse within Autodesk Revit.

#### Remarks

Currently it's just a place holder for specific type.
All the geometry-related functionality is provided by geometry curve object from
DetailCurve::geometryCurve property.

### `M:Autodesk.Revit.DB.NurbSpline.Create(Autodesk.Revit.DB.HermiteSpline)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NurbSpline.Create(Autodesk.Revit.DB.HermiteSpline)`

#### Summary

Creates a new geometric NurbSpline object from a HermiteSpline.

#### Parameter `hermiteSpline`

The hermite spline that will be converted to NurbSpline.

#### Returns

The new NurbSpline object.

#### Since

2017

### `M:Autodesk.Revit.DB.NurbSpline.CreateCurve(Autodesk.Revit.DB.HermiteSpline)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NurbSpline.CreateCurve(Autodesk.Revit.DB.HermiteSpline)`

#### Summary

Creates a new geometric Curve object by converting the given HermiteSpline.
The created curve may be a NURBSpline or a simpler curve such as line or arc.

#### Remarks

The function does not support periodic Hermite curve.

#### Parameter `hermiteSpline`

The HermiteSpline that will be converted.

#### Returns

The new Curve object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given hermite spline has to be non-periodic.
-or-
Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2017

### `M:Autodesk.Revit.DB.NurbSpline.CreateCurve(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.DB.NurbSpline.CreateCurve(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Double})`

#### Summary

Creates a new geometric Curve object from NURBS curve data containing just control points and weights.
The created curve may be a NURBSpline or a simpler curve such as line or arc.

#### Remarks

There must be at least 2 control points.
The number of weights must be equal to the the number of control points.
The values of all weights must be positive.

#### Parameter `controlPoints`

The control points of the NURBSpline.

#### Parameter `weights`

The weights of the NURBSpline.

#### Returns

The new Curve object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The number of control points must be at least 2.
-or-
The number of weights must be the same as the number of control points and all weights must be positive.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Since

2017

### `M:Autodesk.Revit.DB.NurbSpline.CreateCurve(System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.DB.NurbSpline.CreateCurve(System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Double})`

#### Summary

Creates a new geometric Curve object from NURBS curve data, which includes weights.
The created curve may be a NURBSpline or a simpler curve such as line or arc.

#### Remarks

Degree must be 1 or greater.
The number of control points must be greater than degree.
The number of knots must equal the sum of degree, number of controlPoints and 1.
The distinct knot values (ignoring multiplicities) must be in increasing order.
The first degree+1 knots should be identical, as should the last degree+1 knots.
The multiplicities of other (interior) knots should be less than degree -1.
The number of weights must be equal to the the number of control points.
The values of all weights must be positive.

#### Parameter `degree`

The degree of the NURBSpline.

#### Parameter `knots`

The knots of the NURBSpline.

#### Parameter `controlPoints`

The control points of the NURBSpline.

#### Parameter `weights`

The weights of the NURBSpline.

#### Returns

The new Curve object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The degree must be at least 1.
-or-
The number of control points must be greater than degree.
-or-
The number of knots must equal the sum of number of control points, degree and 1.
-or-
An interior knot must not repeat itself more than degree times.
-or-
The number of weights must be the same as the number of control points and all weights must be positive.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Since

2017

### `M:Autodesk.Revit.DB.NurbSpline.CreateCurve(System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.NurbSpline.CreateCurve(System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Creates a new geometric Curve object from NURBS curve data, which does not include weights.
The created curve may be a NURBSpline or a simpler curve such as line or arc.

#### Remarks

Degree must be 1 or greater.
The number of control points must be greater than degree.
The number of knots must equal the sum of degree, number of controlPoints and 1.
The distinct knot values (ignoring multiplicities) must be in increasing order.
The first degree+1 knots should be identical, as should the last degree+1 knots.
The multiplicities of other (interior) knots should be less than degree -1.

#### Parameter `degree`

The degree of the NURBSpline.

#### Parameter `knots`

The knots of the NURBSpline.

#### Parameter `controlPoints`

The control points of the NURBSpline.

#### Returns

The new Curve object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The degree must be at least 1.
-or-
The number of control points must be greater than degree.
-or-
The number of knots must equal the sum of number of control points, degree and 1.
-or-
An interior knot must not repeat itself more than degree times.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Since

2017

### `M:Autodesk.Revit.DB.NurbSpline.SetControlPointsAndWeights(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.DoubleArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NurbSpline.SetControlPointsAndWeights(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.DoubleArray)`

#### Summary

Set the control points, weights simultaneously.

### `P:Autodesk.Revit.DB.NurbSpline.Knots`

Member kind: property
Symbol: `Autodesk.Revit.DB.NurbSpline.Knots`

#### Summary

Return/set the knots of the nurb spline.

### `P:Autodesk.Revit.DB.NurbSpline.Weights`

Member kind: property
Symbol: `Autodesk.Revit.DB.NurbSpline.Weights`

#### Summary

Returns the weights of the nurb spline.

### `P:Autodesk.Revit.DB.NurbSpline.CtrlPoints`

Member kind: property
Symbol: `Autodesk.Revit.DB.NurbSpline.CtrlPoints`

#### Summary

Returns the control points of the nurb spline.

### `P:Autodesk.Revit.DB.NurbSpline.Degree`

Member kind: property
Symbol: `Autodesk.Revit.DB.NurbSpline.Degree`

#### Summary

Returns the degree of the nurb spline.

### `P:Autodesk.Revit.DB.NurbSpline.isRational`

Member kind: property
Symbol: `Autodesk.Revit.DB.NurbSpline.isRational`

#### Summary

Returns whether the nurb spline is rational or not.

### `T:Autodesk.Revit.DB.NurbSpline`

Member kind: type
Symbol: `Autodesk.Revit.DB.NurbSpline`

#### Summary

A nurb spline.

#### Remarks

The nurb spline lies in the plane defined by control point, weight,knots,degree.

### `T:Autodesk.Revit.DB.DetailArc`

Member kind: type
Symbol: `Autodesk.Revit.DB.DetailArc`

#### Summary

Represents a DetailArc within Autodesk Revit.

#### Remarks

Currently it's just a place holder for specific type.
All the geometry-related functionality is provided by geometry curve object from
DetailCurve::geometryCurve property.

### `T:Autodesk.Revit.DB.DetailCurve`

Member kind: type
Symbol: `Autodesk.Revit.DB.DetailCurve`

#### Summary

A curve that is used to create a detail drawing.
A detail curve is visible only in the view in which it is drawn.

### `P:Autodesk.Revit.DB.CurveByPoints.ReferenceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveByPoints.ReferenceType`

#### Summary

Indicates the type of reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when argument is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration failed.

### `P:Autodesk.Revit.DB.CurveByPoints.Visible`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveByPoints.Visible`

#### Summary

Whether the point is visible when the family is loaded
into a project.

### `P:Autodesk.Revit.DB.CurveByPoints.Subcategory`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveByPoints.Subcategory`

#### Summary

The subcategory, or graphics style, of the CurveByPoints.

#### Remarks

If the family category is non-cuttable, the subcategory can be
set to be the family category or one of its subcategories.
If the family category is cuttable, the subcategory can be set as the graphics
styles of the family category, its subcategories, or the invisible lines
graphics style.

### `M:Autodesk.Revit.DB.CurveByPoints.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPoints.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

#### Summary

Sets the visibility.

#### Remarks

The visibility of the CurveByPoints can be changed for different
types of views and detail levels in the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when visibility is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration failed.

### `M:Autodesk.Revit.DB.CurveByPoints.GetVisibility`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPoints.GetVisibility`

#### Summary

Gets the visibility.

#### Returns

A copy of visibility settings for the curve.

### `M:Autodesk.Revit.DB.CurveByPoints.SortPoints(Autodesk.Revit.DB.ReferencePointArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPoints.SortPoints(Autodesk.Revit.DB.ReferencePointArray)`

#### Summary

Order a set of ReferencePoints in the same way Revit does
when creating a curve from points.

#### Remarks

Finds a best-fit line to the points by the least squares method,
and orders the points by their projection onto the line.

#### Returns

False if the least-squares method is unable to find a solution;
true otherwise.

#### Parameter `arr`

An array of ReferencePoints. The array is reordered
if sortPoints returns true, and is unchanged if
sortPoints returns false.

### `M:Autodesk.Revit.DB.CurveByPoints.SetPoints(Autodesk.Revit.DB.ReferencePointArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPoints.SetPoints(Autodesk.Revit.DB.ReferencePointArray)`

#### Summary

Change the sequence of points interpolated by this curve.

#### Parameter `points`

An array of 2 or more ReferencePoints.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when
the array contains fewer than 2 points, when the array
contains duplicates, or when adjacent points are
located too close together.

### `M:Autodesk.Revit.DB.CurveByPoints.GetPoints`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPoints.GetPoints`

#### Summary

Get the sequence of points interpolated by this curve.

### `P:Autodesk.Revit.DB.CurveByPoints.SketchPlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveByPoints.SketchPlane`

#### Summary

Override the SketchPlane property of CurveElement.

#### Remarks

CurveByPoints has no associated SketchPlane. Getting this
property returns `null` . Setting it causes an InvalidOperationException.

### `T:Autodesk.Revit.DB.CurveByPoints`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveByPoints`

#### Summary

A curve interpolating two or more points.

#### Remarks

The points to be interpolated are represented as
ReferencePoints, which must already exist in the
document. In terms of appearance and graphics control,
CurveByPoints behaves similarly to ModelCurve. The main
difference being that a ModelCurve refers to a SketchPlane,
while a CurveByPoints does not.
For more methods capable of accessing data from CurveByPoints elements,
see the static class CurveByPointsUtils.

### `M:Autodesk.Revit.DB.PointRelativeToPoint.SetHostPointReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointRelativeToPoint.SetHostPointReference(Autodesk.Revit.DB.Reference)`

#### Summary

Change the host point reference.

#### Remarks

Allowed references are to another Autodesk.Revit.DB.ReferencePoint element
or to an Autodesk.Revit.DB.Point.

#### Since

2013

### `M:Autodesk.Revit.DB.PointRelativeToPoint.GetHostPointReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointRelativeToPoint.GetHostPointReference`

#### Summary

Get a copy of the host point reference.

#### Since

2013

### `M:Autodesk.Revit.DB.PointRelativeToPoint.#ctor(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointRelativeToPoint.#ctor(Autodesk.Revit.DB.Reference)`

#### Summary

Construct a reference to a point placed relative to a host point.

#### Since

2013

### `T:Autodesk.Revit.DB.PointRelativeToPoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointRelativeToPoint`

#### Summary

Represents a point placed relative to another point.

#### Remarks

For this release, the only workflow supported is that the point is
placed coincident with the referenced host (a relative transformation
of Transform.Identity).

#### Since

2013

### `M:Autodesk.Revit.DB.PointOnEdgeEdgeIntersection.SetEdgeReference2(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnEdgeEdgeIntersection.SetEdgeReference2(Autodesk.Revit.DB.Reference)`

#### Summary

Change the second edge or curve reference.

#### Remarks

The referenced element may be any model element, including
FamilyInstance, FormElement, or NonPlanarSketch. The reference
must be of type ElementReferenceType.REFERENCE_TYPE_LINEAR,
and it must correspond to a straight line.

### `M:Autodesk.Revit.DB.PointOnEdgeEdgeIntersection.GetEdgeReference2`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnEdgeEdgeIntersection.GetEdgeReference2`

#### Summary

Get a copy of the second edge or curve reference.

### `M:Autodesk.Revit.DB.PointOnEdgeEdgeIntersection.SetEdgeReference1(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnEdgeEdgeIntersection.SetEdgeReference1(Autodesk.Revit.DB.Reference)`

#### Summary

Change the first edge or curve reference.

#### Remarks

The referenced element may be any model element, including
FamilyInstance, FormElement, or NonPlanarSketch. The reference
must be of type ElementReferenceType.REFERENCE_TYPE_LINEAR,
and it must correspond to a straight line.

### `M:Autodesk.Revit.DB.PointOnEdgeEdgeIntersection.GetEdgeReference1`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnEdgeEdgeIntersection.GetEdgeReference1`

#### Summary

Get a copy of the first edge or curve reference.

### `T:Autodesk.Revit.DB.PointOnEdgeEdgeIntersection`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointOnEdgeEdgeIntersection`

#### Summary

Define a ReferencePoint at the intersection of two
referenceable lines.

#### Remarks

The ReferencePoint is actually placed on the first
line (Edge1) at the closest point to the second line (Edge2).
Its X basis vector is constrained to be parallel to the first
line.

### `P:Autodesk.Revit.DB.PointOnEdgeFaceIntersection.OrientWithEdge`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointOnEdgeFaceIntersection.OrientWithEdge`

#### Summary

Whether to orient the ReferencePoint to the edge or the face.

#### Remarks

If true, the X basis vector will be parallel to the edge.
If false, the X and Y basis vectors will be parallel to the face.

### `M:Autodesk.Revit.DB.PointOnEdgeFaceIntersection.SetFaceReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnEdgeFaceIntersection.SetFaceReference(Autodesk.Revit.DB.Reference)`

#### Summary

Change the face reference.

#### Remarks

The referenced element may be any model element, including
FamilyInstance or FormElement. The reference
must be of type ElementReferenceType.REFERENCE_TYPE_SURFACE,
and the surface must be of type `T:Autodesk.Revit.DB.Plane` .
The Reference's UVPoint property is ignored.

### `M:Autodesk.Revit.DB.PointOnEdgeFaceIntersection.GetFaceReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnEdgeFaceIntersection.GetFaceReference`

#### Summary

Get a copy of the face reference.

### `M:Autodesk.Revit.DB.PointOnEdgeFaceIntersection.SetEdgeReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnEdgeFaceIntersection.SetEdgeReference(Autodesk.Revit.DB.Reference)`

#### Summary

Change the edge or curve reference.

#### Remarks

The referenced element may be any model element, including
FamilyInstance, FormElement, or CurveElement. The reference
must be of type ElementReferenceType.REFERENCE_TYPE_LINEAR.

### `M:Autodesk.Revit.DB.PointOnEdgeFaceIntersection.GetEdgeReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnEdgeFaceIntersection.GetEdgeReference`

#### Summary

Get a copy of the edge or curve reference.

### `T:Autodesk.Revit.DB.PointOnEdgeFaceIntersection`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointOnEdgeFaceIntersection`

#### Summary

Define a ReferencePoint at the intersection of a referenceable
edge or curve and a referenceable face.

#### Remarks

The ReferencePoint's orientation is partially constrained
either to the edge (in the manner of PointOnEdge) or to the face
(in the manner of PointOnFace).

### `P:Autodesk.Revit.DB.PointOnFace.UV`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointOnFace.UV`

#### Summary

The location of the point in the surface's coordinate system.

### `M:Autodesk.Revit.DB.PointOnFace.SetFaceReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnFace.SetFaceReference(Autodesk.Revit.DB.Reference)`

#### Summary

Change the face reference.

#### Remarks

The referenced element may be any model element, including
FamilyInstance or FormElement. The reference
must be of type ElementReferenceType.REFERENCE_TYPE_SURFACE,
and the surface must be of type `T:Autodesk.Revit.DB.Plane` .
The Reference's UVPoint property is ignored.

### `M:Autodesk.Revit.DB.PointOnFace.GetFaceReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnFace.GetFaceReference`

#### Summary

Get a copy of the face reference.

### `T:Autodesk.Revit.DB.PointOnFace`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointOnFace`

#### Summary

Define a ReferencePoint relative to a Face.

#### Remarks

A ReferencePoint on a Face has its X and Y
basis vectors parallel to the Face, but is free to rotate
around its Z basis vector. It must lie on the face
(unlike PointOnPlane).

### `P:Autodesk.Revit.DB.PointOnEdge.LocationOnCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointOnEdge.LocationOnCurve`

#### Summary

The point location on curve.

### `M:Autodesk.Revit.DB.PointOnEdge.SetEdgeReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnEdge.SetEdgeReference(Autodesk.Revit.DB.Reference)`

#### Summary

Change the edge or curve reference.

#### Remarks

The referenced element may be any model element, including
FamilyInstance, FormElement, or CurveElement. The reference
must be of type ElementReferenceType.REFERENCE_TYPE_LINEAR.

### `M:Autodesk.Revit.DB.PointOnEdge.GetEdgeReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnEdge.GetEdgeReference`

#### Summary

Get a copy of the edge or curve reference.

### `T:Autodesk.Revit.DB.PointOnEdge`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointOnEdge`

#### Summary

Define a ReferencePoint relative to a referenceable edge or
curve on another element.

#### Remarks

The ReferencePoint's X basis vector is constrained to the
tangent vector to the curve. The Y and Z vectors are free to rotate
around the curve.

### `P:Autodesk.Revit.DB.PointOnPlane.Offset`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointOnPlane.Offset`

#### Summary

Signed offset from the plane.

#### Remarks

The point's position
is offset in the direction of the normal vector returned by
the Plane.Normal property.

### `P:Autodesk.Revit.DB.PointOnPlane.XVec`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointOnPlane.XVec`

#### Summary

The X-coordinate vector of the point, in the
plane's coordinate system.

### `P:Autodesk.Revit.DB.PointOnPlane.Position`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointOnPlane.Position`

#### Summary

The coordinates of the point (or its projection)
on the plane.

### `M:Autodesk.Revit.DB.PointOnPlane.IsValidPlaneReference(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnPlane.IsValidPlaneReference(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

#### Summary

Check whether a geometry reference
corresponds to a referenceable plane.

#### Remarks

Valid plane references include: planar faces
of solids; the PlaneReference properties of
`T:Autodesk.Revit.DB.Level` and
`T:Autodesk.Revit.DB.SketchPlane` ;
the Reference property of
`T:Autodesk.Revit.DB.ReferencePlane` .

### `M:Autodesk.Revit.DB.PointOnPlane.SetPlaneReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnPlane.SetPlaneReference(Autodesk.Revit.DB.Reference)`

#### Summary

Change the geometric plane reference.

#### Parameter `planeReference`

A reference to some plane
in the document. (Note: the reference must satisfy
IsValidPlaneReference(),
but this is not checked until this PointOnPlane object
is assigned to a ReferencePoint.)

### `M:Autodesk.Revit.DB.PointOnPlane.GetPlaneReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnPlane.GetPlaneReference`

#### Summary

The geometric plane reference.

#### Returns

A copy of the reference stored in the PointOnPlane object.

### `M:Autodesk.Revit.DB.PointOnPlane.NewPointOnPlane(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointOnPlane.NewPointOnPlane(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Construct a PointOnPlane given a reference and a location in space.

#### Returns

A new PointOnPlane object with 2-dimensional Position, XVec, and Offset
properties set to match the given 3-dimensional arguments.

#### Parameter `doc`

The document containing the plane reference.

#### Parameter `position`

A 3-dimensional position.

#### Parameter `xvec`

The direction of the point's
X-coordinate vector in the plane's
coordinates. Optional; default value is the
X-coordinate vector of the plane.

### `T:Autodesk.Revit.DB.PointOnPlane`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointOnPlane`

#### Summary

Define a ReferencePoint relative to a planar reference.

#### Remarks

A ReferencePoint on a plane has its X and Y
basis vectors parallel to the plane, but is free to rotate
around its Z basis vector. It can lie on the plane
or have an offset.

### `T:Autodesk.Revit.DB.PointElementReference`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointElementReference`

#### Summary

Base class for objects defining a way to
constrain a ReferencePoint to one or more other objects in a
document.

### `P:Autodesk.Revit.DB.ReferencePoint.ShowNormalReferencePlaneOnly`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferencePoint.ShowNormalReferencePlaneOnly`

#### Summary

Whether all three coordinate planes are shown, or only the
normal (XY) plane.

### `P:Autodesk.Revit.DB.ReferencePoint.CoordinatePlaneVisibility`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferencePoint.CoordinatePlaneVisibility`

#### Summary

Visibility settings for the coordinate reference planes.

### `M:Autodesk.Revit.DB.ReferencePoint.GetHubId`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePoint.GetHubId`

#### Summary

Id of associated Hub.

### `M:Autodesk.Revit.DB.ReferencePoint.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePoint.SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility)`

#### Summary

Sets the visibility for the point.

#### Remarks

The visibility of the point can be changed for different
types of views and detail levels in the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when visibility is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when regeneration failed.

### `M:Autodesk.Revit.DB.ReferencePoint.GetVisibility`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePoint.GetVisibility`

#### Summary

Gets the visibility for the point.

#### Returns

A copy of visibility settings for the
ReferencePoint.

### `P:Autodesk.Revit.DB.ReferencePoint.Visible`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferencePoint.Visible`

#### Summary

Whether the point is visible when the family is loaded
into a project.

### `M:Autodesk.Revit.DB.ReferencePoint.GetCoordinatePlaneReferenceXZ`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePoint.GetCoordinatePlaneReferenceXZ`

#### Summary

A reference for the XZ plane of the coordinate
system.

### `M:Autodesk.Revit.DB.ReferencePoint.GetCoordinatePlaneReferenceYZ`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePoint.GetCoordinatePlaneReferenceYZ`

#### Summary

A reference for the YZ plane of the coordinate
system.

### `M:Autodesk.Revit.DB.ReferencePoint.GetCoordinatePlaneReferenceXY`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePoint.GetCoordinatePlaneReferenceXY`

#### Summary

A reference for the XY plane of the coordinate
system.

### `M:Autodesk.Revit.DB.ReferencePoint.GetInterpolatingCurves`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePoint.GetInterpolatingCurves`

#### Summary

The set of CurveByPoints elements that interpolate
a ReferencePoint.

#### Remarks

A CurveByPoints is in the `M:Autodesk.Revit.DB.ReferencePoint.GetInterpolatingCurves`
array if and only if the ReferencePoint is in the Points array of
`T:Autodesk.Revit.DB.CurveByPoints` .

### `P:Autodesk.Revit.DB.ReferencePoint.Position`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferencePoint.Position`

#### Summary

The position of the ReferencePoint.

#### Remarks

This is an alternate interface to the property
CoordinateSystem.Origin. When set, the effect is the same
as setting the CoordinateSystem property to the same as
its current value but with a different Origin.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when CoordinateSystem is set while the Reference
property is not `null` , and the ReferencePoint is unable to
move to the new location.

### `M:Autodesk.Revit.DB.ReferencePoint.SetCoordinateSystem(Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePoint.SetCoordinateSystem(Autodesk.Revit.DB.Transform)`

#### Summary

The position and orientation of the ReferencePoint.

#### Remarks

The position of the point is given by
CoordinateSystem.Origin, and the orientation is specified
by the three unit vectors CoordinateSystem.BasisX, BasisY,
BasisZ. The basis vectors must be unit length and mutually
perpendicular.
Whenever the Reference property is not `null` ,
changing the CoordinateSystem property has a compound
effect. First the point is moved to the specified
location. Then the point is moved to conform to its
Reference, by the shortest possible distance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when coordinateSystem does not specify an
orthonormal basis.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when CoordinateSystem is set while the Reference
property is not `null` , and the ReferencePoint is unable to
move to the new location.

### `M:Autodesk.Revit.DB.ReferencePoint.GetCoordinateSystem`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePoint.GetCoordinateSystem`

#### Summary

The position and orientation of the ReferencePoint.

#### Remarks

The position of the point is given by
CoordinateSystem.Origin, and the orientation is specified
by the three unit vectors CoordinateSystem.BasisX, BasisY,
BasisZ.

### `M:Autodesk.Revit.DB.ReferencePoint.SetPointElementReference(Autodesk.Revit.DB.PointElementReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePoint.SetPointElementReference(Autodesk.Revit.DB.PointElementReference)`

#### Summary

Change the rule for computing the
location of the ReferencePoint relative to other elements in
the document.

#### Remarks

pointElementReference may be `null` , in which case the ReferencePoint
does not follow any other element. When Reference is changed
from `null` to a non-null value, the point moves and rotates
to the prescribed location and orientation. Where the
coordinate system has some freedom, it will remain as close
to the old orientation as possible. When
the reference is set to `null` , the point does not move or
rotate.

#### Parameter `pointElementReference`

An object specifying
a rule for the location and orientation of a ReferencePoint.
(Note: The ReferencePoint object does not store the
pointElementReference object after this call.)

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when Reference is set to a non-null object, and the
ReferencePoint is unable to move to the new reference.

### `M:Autodesk.Revit.DB.ReferencePoint.GetPointElementReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePoint.GetPointElementReference`

#### Summary

Retrieve a copy of the rule that computes the
location of the ReferencePoint relative to other elements in
the document.

#### Returns

A PointElementReference object, or `null` if the
ReferencePoint does not have a reference.

### `T:Autodesk.Revit.DB.ReferencePoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReferencePoint`

#### Summary

A reference point in an Autodesk Revit family.

#### Remarks

A ReferencePoint represents a point in space together
with a local coordinate system. ReferencePoints can be free, or
constrained to other elements in several ways. When the point is
constrained, the coordinate system is also constrained in certain
ways.

### `P:Autodesk.Revit.DB.PointLocationOnCurve.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointLocationOnCurve.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.PointLocationOnCurve.MeasureFrom`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointLocationOnCurve.MeasureFrom`

#### Summary

The location on the curve from which the measurement is taken.

#### Remarks

The measure-from is not checked until this class is assigned for a particular reference point on a particular curve.
At that time, the measure-from must be valid for the curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.PointLocationOnCurve.MeasurementValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointLocationOnCurve.MeasurementValue`

#### Summary

The measurement value.

#### Remarks

The measurement value is not checked until this class is assigned for a particular reference point on a particular curve.
At that time, the measurement value must match the expected range for the curve for the given measurement type and measure-from.

#### Since

2012

### `P:Autodesk.Revit.DB.PointLocationOnCurve.MeasurementType`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointLocationOnCurve.MeasurementType`

#### Summary

The measurement type.

#### Remarks

The measurement type is not checked until this class is assigned for a particular reference point on a particular curve.
At that time, the measurement type must be valid for the curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.PointLocationOnCurve.#ctor(Autodesk.Revit.DB.PointOnCurveMeasurementType,System.Double,Autodesk.Revit.DB.PointOnCurveMeasureFrom)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointLocationOnCurve.#ctor(Autodesk.Revit.DB.PointOnCurveMeasurementType,System.Double,Autodesk.Revit.DB.PointOnCurveMeasureFrom)`

#### Summary

Constructs a new instance of a class, with given or default values, to place a point on a curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.PointLocationOnCurve`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointLocationOnCurve`

#### Summary

Defines the measurement parameters necessary to create a point at a specific location on a curve.

#### Remarks

The class will store the following and provides functions to deal with them:
The user visible Measurement Type (driving parameter type).

The corresponding measurement value (driving parameter).

MeasureFrom that tells from where the (driving parameter) measurement is calculated.

#### Since

2012

### `T:Autodesk.Revit.DB.PointOnCurveMeasureFrom`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointOnCurveMeasureFrom`

#### Summary

Point on curve MeasureFrom - It tells from which end of the host curve the point location is measured.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.PointOnCurveMeasureFrom.End`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointOnCurveMeasureFrom.End`

#### Summary

End of the host curve.

### `F:Autodesk.Revit.DB.PointOnCurveMeasureFrom.Beginning`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointOnCurveMeasureFrom.Beginning`

#### Summary

Beginning of the host curve.

### `T:Autodesk.Revit.DB.PointOnCurveMeasurementType`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointOnCurveMeasurementType`

#### Summary

Point on curve measurement type
Defines the types of measurements that may be used when placing a point at a designated distance along a curve.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.PointOnCurveMeasurementType.Angle`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointOnCurveMeasurementType.Angle`

#### Summary

Angle - defined only for arc and circle.
It is the angle subtended at the center by the portion of the curve from the star to the given point.

### `F:Autodesk.Revit.DB.PointOnCurveMeasurementType.ChordLength`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointOnCurveMeasurementType.ChordLength`

#### Summary

Chord length = length of the chord (line segment) joining the start point and the given point.
Also known as 3D distance

### `F:Autodesk.Revit.DB.PointOnCurveMeasurementType.NormalizedSegmentLength`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointOnCurveMeasurementType.NormalizedSegmentLength`

#### Summary

Normalized segment length.
It is defined for curves with user defined bounds or natural bounds.
It is measured as the fraction of the segment length over the total length of the curve.
Its value varies between 0 and 1. 0 corresponds to the start and 1 corresponds to the end.

### `F:Autodesk.Revit.DB.PointOnCurveMeasurementType.SegmentLength`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointOnCurveMeasurementType.SegmentLength`

#### Summary

Length of the curve segment between the start point and the given point.

### `F:Autodesk.Revit.DB.PointOnCurveMeasurementType.NormalizedCurveParameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointOnCurveMeasurementType.NormalizedCurveParameter`

#### Summary

Normalized value of the curve parameter.
It is defined for curves with user defined bounds or natural bounds, start and end.
It is measured as the fraction of the curve parameter (t) over the total parametric range = (t-start) / (end-start).
Its value varies between 0 and 1. 0 corresponds to the start and 1 corresponds to the end.

### `F:Autodesk.Revit.DB.PointOnCurveMeasurementType.NonNormalizedCurveParameter`

Member kind: field
Symbol: `Autodesk.Revit.DB.PointOnCurveMeasurementType.NonNormalizedCurveParameter`

#### Summary

The non-normalized (actual) curve parameter value of the given point.
The curve parameter is the defining parameter of the curve.
It is also known as the raw/natural parameter.

### `T:Autodesk.Revit.DB.CoordinatePlaneVisibility`

Member kind: type
Symbol: `Autodesk.Revit.DB.CoordinatePlaneVisibility`

#### Summary

Visibility settings for ReferencePoint element's coordinate reference planes.

#### Since

2013

### `F:Autodesk.Revit.DB.CoordinatePlaneVisibility.Always`

Member kind: field
Symbol: `Autodesk.Revit.DB.CoordinatePlaneVisibility.Always`

#### Summary

Always Visible.

### `F:Autodesk.Revit.DB.CoordinatePlaneVisibility.WhenSelected`

Member kind: field
Symbol: `Autodesk.Revit.DB.CoordinatePlaneVisibility.WhenSelected`

#### Summary

Visible when selected.

### `F:Autodesk.Revit.DB.CoordinatePlaneVisibility.Never`

Member kind: field
Symbol: `Autodesk.Revit.DB.CoordinatePlaneVisibility.Never`

#### Summary

Never visible.

### `M:Autodesk.Revit.DB.CurtainSystem.RemoveCurtainGrid(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainSystem.RemoveCurtainGrid(Autodesk.Revit.DB.Reference)`

#### Summary

Remove CurtainGrid from the specified face for the CurtainSystem.

#### Parameter `face`

The face CurtainGrid will be removed from.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input parameter face is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the CurtainGrid cannot be removed from the specified face or regenerate fails.

### `M:Autodesk.Revit.DB.CurtainSystem.AddCurtainGrid(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainSystem.AddCurtainGrid(Autodesk.Revit.DB.Reference)`

#### Summary

Add CurtainGrid on the specified face for the CurtainSystem.

#### Parameter `face`

The face new CurtainGrid will be created on.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument face is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when creating CurtainGrid on the specified face fails or regenerate fails.

### `P:Autodesk.Revit.DB.CurtainSystem.CurtainSystemType`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainSystem.CurtainSystemType`

#### Summary

get or set the type of the CurtainSystem.

#### Parameter `curtainSystemType`

The Type of CurtainSystem to be swapped.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the specified parameter curtainSystemType is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the type of the CurtainSystem cannot be changed to the specified one.

### `P:Autodesk.Revit.DB.CurtainSystem.CurtainGrids`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainSystem.CurtainGrids`

#### Summary

Get all the CurtainGrid object of this CurtainSystem. Each CurtainGrid corresponds to one face.

#### Returns

A CurtainGrid set will be returned if the operation succeeds. `null` will be returned if the
CurtainSystem doesn't include any CurtainGrid.

### `T:Autodesk.Revit.DB.CurtainSystem`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurtainSystem`

#### Summary

Provides access to the CurtainSystem object in Autodesk Revit.

#### Remarks

The user can create CurtainSystem object and change the internal properties.

### `T:Autodesk.Revit.DB.CurtainSystemType`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurtainSystemType`

#### Summary

An object that represents CurtainSystem type.

### `T:Autodesk.Revit.DB.CurtainSystemBase`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurtainSystemBase`

#### Summary

Provides access to the CurtainSystemBase object in Autodesk Revit.

#### Remarks

This is the base class of CurtainSystem.

### `M:Autodesk.Revit.DB.Ellipse.CreateCurve(Autodesk.Revit.DB.XYZ,System.Double,System.Double,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Ellipse.CreateCurve(Autodesk.Revit.DB.XYZ,System.Double,System.Double,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Double,System.Double)`

#### Summary

Creates a new geometric ellipse or elliptical arc object.

#### Remarks

If the angle range is equal to or greater than 2 * PI, the curve will be
automatically converted to an unbounded ellipse.
If xRadius and yRadius are almost equal, the curve will be
returned as an arc.

#### Parameter `center`

The center.

#### Parameter `xRadius`

The x vector radius of the ellipse.

#### Parameter `yRadius`

The y vector radius of the ellipse.

#### Parameter `xAxis`

The x axis to define the ellipse plane. Must be normalized.

#### Parameter `yAxis`

The y axis to define the ellipse plane. Must be normalized.

#### Parameter `startParameter`

The raw parameter value at the start of the ellipse.

#### Parameter `endParameter`

The raw parameter value at the end of the ellipse.

#### Returns

The new ellipse or elliptical arc.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for xRadius must be greater than 0 and no more than 30000 feet.
-or-
The given value for yRadius must be greater than 0 and no more than 30000 feet.
-or-
xAxis is not length 1.0.
-or-
yAxis is not length 1.0.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The vectors xAxis and yAxis are not perpendicular.
-or-
Start parameter must be less than end parameter.
-or-
Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

#### Since

2017_subscription_update

### `P:Autodesk.Revit.DB.Ellipse.RadiusY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Ellipse.RadiusY`

#### Summary

Returns the Y vector radius of the ellipse.

### `P:Autodesk.Revit.DB.Ellipse.RadiusX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Ellipse.RadiusX`

#### Summary

Returns the X vector radius of the ellipse.

### `P:Autodesk.Revit.DB.Ellipse.YDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.Ellipse.YDirection`

#### Summary

The Y direction.

#### Since

2013

### `P:Autodesk.Revit.DB.Ellipse.XDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.Ellipse.XDirection`

#### Summary

The X direction.

#### Since

2013

### `P:Autodesk.Revit.DB.Ellipse.Normal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Ellipse.Normal`

#### Summary

Returns the normal to the plane in which the ellipse is defined.

### `P:Autodesk.Revit.DB.Ellipse.Center`

Member kind: property
Symbol: `Autodesk.Revit.DB.Ellipse.Center`

#### Summary

Returns the center of the ellipse.

### `T:Autodesk.Revit.DB.Ellipse`

Member kind: type
Symbol: `Autodesk.Revit.DB.Ellipse`

#### Summary

A whole or partial ellipse.

### `M:Autodesk.Revit.DB.Panel.FindHostPanel`

Member kind: method
Symbol: `Autodesk.Revit.DB.Panel.FindHostPanel`

#### Summary

Finds the id of the host panel (i.e., wall)
associated with this panel. If a host panel is present, then
it is displayed instead of the curtain panel.

#### Returns

Element id of the host panel associated with this panel.
Otherwise, InvalidElementId is returned

#### Since

2015

### `M:Autodesk.Revit.DB.Panel.GetRefGridLines(Autodesk.Revit.DB.ElementId@,Autodesk.Revit.DB.ElementId@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Panel.GetRefGridLines(Autodesk.Revit.DB.ElementId@,Autodesk.Revit.DB.ElementId@)`

#### Summary

This method is used to get the reference gridlines.

### `P:Autodesk.Revit.DB.Panel.Transform`

Member kind: property
Symbol: `Autodesk.Revit.DB.Panel.Transform`

#### Summary

This property is used to find the transform of a curtain panel within project.

#### Remarks

The Transform property returns a Autodesk::Revit::DB::Transform object that can be used to find the
transfer matrix of a curtain panel within the project.

### `P:Autodesk.Revit.DB.Panel.PanelType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Panel.PanelType`

#### Summary

The Panel style of this Panel.

#### Remarks

The Symbol property can be used to retrieve the kind of the panel.
This property can also be used to change the type of a panel by setting it to a different type.
All the panel types in the project can be found using
the Document.CurtainPanelTypes property.

### `P:Autodesk.Revit.DB.Panel.Lockable`

Member kind: property
Symbol: `Autodesk.Revit.DB.Panel.Lockable`

#### Summary

This property is used to know whether a panel can be locked.

#### Remarks

If the panel can be locked, return true, else false.

### `T:Autodesk.Revit.DB.Panel`

Member kind: type
Symbol: `Autodesk.Revit.DB.Panel`

#### Summary

This object represents a curtain panel.

### `T:Autodesk.Revit.DB.MullionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.MullionType`

#### Summary

An object that represents a mullion type.

### `M:Autodesk.Revit.DB.Mullion.BreakMullion`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mullion.BreakMullion`

#### Summary

This method is used to break the current Mullion at ends with its neighboring mullions.

#### Remarks

The mullions being perpendicular to it will be joined accordingly.

### `M:Autodesk.Revit.DB.Mullion.JoinMullion`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mullion.JoinMullion`

#### Summary

This method is used to control the join condition the current Mullion with its neighboring mullions.

#### Remarks

The mullions being perpendicular to it will be broken accordingly.

### `P:Autodesk.Revit.DB.Mullion.LocationCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mullion.LocationCurve`

#### Summary

This method get the curve location of the current Mullion.

### `P:Autodesk.Revit.DB.Mullion.MullionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mullion.MullionType`

#### Summary

The MullionType style of this Mullion.
Get - to access type of mullion
Set - change type of mullion. If the mullion is locked, InvalidOperationException exception will be thrown.

### `P:Autodesk.Revit.DB.Mullion.Lockable`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mullion.Lockable`

#### Summary

Get - to get whether the Mullion can be lock or unlock.

### `P:Autodesk.Revit.DB.Mullion.Lock`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mullion.Lock`

#### Summary

Get - to get whether the Mullion line is locked.
Set - Lock/unlock the Mullion.

### `T:Autodesk.Revit.DB.Mullion`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mullion`

#### Summary

Represents a CurtainGrid within Autodesk Revit.

### `M:Autodesk.Revit.DB.CurtainGridLine.AddMullions(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.MullionType,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridLine.AddMullions(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.MullionType,System.Boolean)`

#### Summary

Add mullions on the specified segments of a grid. If any segment already has a mullion, no change is made to that segment.

#### Parameter `segment`

Curve of the segment.

#### Parameter `mullionType`

The type of the mullion to add.

#### Parameter `oneSegmentOnly`

If true, add one mullion to the specified segment, otherwise add mullions to all the segments of the matching grid line.

#### Returns

If operation succeeds, the created mullions will be returned.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Invalid curtain grid line or invalid mullion type argument.

### `M:Autodesk.Revit.DB.CurtainGridLine.AddAllSegments`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridLine.AddAllSegments`

#### Summary

All the segments on this grid line will be added.

### `M:Autodesk.Revit.DB.CurtainGridLine.AddSegment(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridLine.AddSegment(Autodesk.Revit.DB.Curve)`

#### Summary

Add a segment based on the specified segment curve of the gridline.

#### Parameter `curve`

The curve used to locate the segment to be removed. This function will invoke regeneration.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Segment may not have been found in location indicated by curve.

### `M:Autodesk.Revit.DB.CurtainGridLine.RemoveSegment(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridLine.RemoveSegment(Autodesk.Revit.DB.Curve)`

#### Summary

Remove the segment specified by the input curve.

#### Parameter `curve`

The curve used to locate the segment to be removed.

#### Remarks

When a segment is removed, the neighboring two panels will be merged into one panel. This function will invoke regeneration.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Segment may not have been found in location indicated by curve.

### `P:Autodesk.Revit.DB.CurtainGridLine.ExistingSegmentCurves`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGridLine.ExistingSegmentCurves`

#### Summary

Retrieve all the existing segment curves of the grid line.

#### Remarks

User can get these curves and call RemoveSegment() to remove the segments to the gridline or call AddMullions() to add mullions to these segments.

### `P:Autodesk.Revit.DB.CurtainGridLine.SkippedSegmentCurves`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGridLine.SkippedSegmentCurves`

#### Summary

Retrieve all the removed segment curves of the grid line.

#### Remarks

User can get these curves and then call the method AddSegment() to add the segments to the grid line.

### `P:Autodesk.Revit.DB.CurtainGridLine.AllSegmentCurves`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGridLine.AllSegmentCurves`

#### Summary

Retrieve the curves of all segments.

#### Remarks

User can get these curves and then call the method AddSegment() or RemoveSegment() to add/remove specified segments.
If the specified segment is already added/removed, nothing will happen.

### `P:Autodesk.Revit.DB.CurtainGridLine.FullCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGridLine.FullCurve`

#### Summary

Retrieve the geometry curve of the curtain grid line.

### `P:Autodesk.Revit.DB.CurtainGridLine.IsUGridLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGridLine.IsUGridLine`

#### Summary

Retrieve the direction of a grid line.If it is true,we say it is a UGridLine,otherwise it is VGridLine

### `P:Autodesk.Revit.DB.CurtainGridLine.Lock`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGridLine.Lock`

#### Summary

Retrieves or changes the lock state of the curtain grid line.

### `T:Autodesk.Revit.DB.CurtainGridLine`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurtainGridLine`

#### Summary

Represents a CurtainGridLine within Autodesk Revit.

### `M:Autodesk.Revit.DB.CurtainGrid.GetCell(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGrid.GetCell(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Get the specified cell located by the intersection of the grid lines.

#### Parameter `uGridLineId`

The id of a grid line in the U-direction used to locate the cell.

#### Parameter `vGridLineId`

The id of a grid line in the V-direction used to locate the cell.

#### Returns

The cell.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the grid line ids are not part of this curtain grid.

### `M:Autodesk.Revit.DB.CurtainGrid.GetPanel(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGrid.GetPanel(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Get the specified panel located by the intersection of the grid lines.

#### Parameter `uGridLineId`

The id of a grid line in the U-direction used to locate the panel.

#### Parameter `vGridLineId`

The id of a grid line in the V-direction used to locate the panel.

#### Returns

The panel, or `null` if the panel cannot be found at this intersection.

### `M:Autodesk.Revit.DB.CurtainGrid.AddGridLine(System.Boolean,Autodesk.Revit.DB.XYZ,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGrid.AddGridLine(System.Boolean,Autodesk.Revit.DB.XYZ,System.Boolean)`

#### Summary

Add a grid line to the curtain grid.

#### Parameter `isUGridLine`

If true, a U-direction grid line will be added. Otherwise, a V-direction grid line will be added.

#### Parameter `position`

The position of the grid line.

#### Parameter `oneSegmentOnly`

If it is true, only one segment is added. Otherwise, all segments will be added for the grid line.

#### Returns

The created grid line is returned if the operation is successful. Otherwise, `null` is returned.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the position for the grid line is out of range.

### `M:Autodesk.Revit.DB.CurtainGrid.ChangePanelType(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.ElementType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGrid.ChangePanelType(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.ElementType)`

#### Summary

Change the type of a curtain panel.

#### Parameter `panel`

The panel to be changed, it can be a type of `T:Autodesk.Revit.DB.Panel` or `T:Autodesk.Revit.DB.Wall` .

#### Parameter `newSymbol`

The new symbol, it may be of `T:Autodesk.Revit.DB.PanelType` or `T:Autodesk.Revit.DB.WallType` when the panel is hosted in a curtain wall.
The new symbol can only be of type `T:Autodesk.Revit.DB.PanelType` if the Panel is hosted in a curtain system.

#### Returns

If operation succeeds, the modified panel element is returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the input symbol can't be used for the panel.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the type change failed.

### `M:Autodesk.Revit.DB.CurtainGrid.GetCurtainCells`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGrid.GetCurtainCells`

#### Summary

Gets the CurtainCells owned by this curtain grid.

#### Returns

The CurtainCells owned by this curtain grid.

### `M:Autodesk.Revit.DB.CurtainGrid.GetVGridLineIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGrid.GetVGridLineIds`

#### Summary

Gets all ElementIds of grid lines in the V direction.

#### Returns

The V grid line ElementIds

### `M:Autodesk.Revit.DB.CurtainGrid.GetUGridLineIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGrid.GetUGridLineIds`

#### Summary

Gets all ElementIds of grid lines in the U direction.

#### Returns

The U grid line ElementIds

### `M:Autodesk.Revit.DB.CurtainGrid.GetUnlockedMullionIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGrid.GetUnlockedMullionIds`

#### Summary

Gets all ElementIds of the unlocked mullions of the curtain grid.

#### Remarks

ElementIds are of `T:Autodesk.Revit.DB.Mullion` Elements.

#### Returns

The unlocked mullion ElementIds

### `M:Autodesk.Revit.DB.CurtainGrid.GetMullionIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGrid.GetMullionIds`

#### Summary

Gets all ElementIds of the mullions of the curtain grid.

#### Remarks

ElementIds are of `T:Autodesk.Revit.DB.Mullion` Elements.

#### Returns

The mullion ElementIds

### `M:Autodesk.Revit.DB.CurtainGrid.GetUnlockedPanelIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGrid.GetUnlockedPanelIds`

#### Summary

Gets all ElementIds of the unlocked panels of the curtain grid.

#### Remarks

For curtain walls, the ElementIds in this set are of either `T:Autodesk.Revit.DB.Panel` or `T:Autodesk.Revit.DB.Wall` Elements.
For curtain systems, ElementIds are of `T:Autodesk.Revit.DB.Panel` Elements.

#### Returns

The unlocked panel ElementIds

### `M:Autodesk.Revit.DB.CurtainGrid.GetPanelIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGrid.GetPanelIds`

#### Summary

Gets all ElementIds of the panels of the curtain grid.

#### Remarks

For curtain walls, the ElementIds in this set are of either `T:Autodesk.Revit.DB.Panel` or `T:Autodesk.Revit.DB.Wall` Elements.
For curtain systems, ElementIds are of `T:Autodesk.Revit.DB.Panel` Elements.

#### Returns

The panel ElementIds

### `P:Autodesk.Revit.DB.CurtainGrid.NumPanels`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGrid.NumPanels`

#### Summary

The number of panels.

### `P:Autodesk.Revit.DB.CurtainGrid.NumVLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGrid.NumVLines`

#### Summary

Get the number of grid lines in the V direction.

### `P:Autodesk.Revit.DB.CurtainGrid.NumULines`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGrid.NumULines`

#### Summary

Get the number of grid lines in the U direction.

### `P:Autodesk.Revit.DB.CurtainGrid.Grid2Offset`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGrid.Grid2Offset`

#### Summary

The offset for V grid line pattern of the curtain grid.

### `P:Autodesk.Revit.DB.CurtainGrid.Grid2Angle`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGrid.Grid2Angle`

#### Summary

The angle for V grid line pattern of the curtain grid.

### `P:Autodesk.Revit.DB.CurtainGrid.Grid2Justification`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGrid.Grid2Justification`

#### Summary

The justification for the V grid line pattern of the curtain grid.

### `P:Autodesk.Revit.DB.CurtainGrid.Grid1Offset`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGrid.Grid1Offset`

#### Summary

The offset for the U grid line pattern of the curtain grid.

### `P:Autodesk.Revit.DB.CurtainGrid.Grid1Angle`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGrid.Grid1Angle`

#### Summary

The angle for the U grid line pattern of the curtain grid.

### `P:Autodesk.Revit.DB.CurtainGrid.Grid1Justification`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGrid.Grid1Justification`

#### Summary

The justification for the U grid line pattern of the curtain grid.

### `T:Autodesk.Revit.DB.CurtainGrid`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurtainGrid`

#### Summary

Represents a curtain grid element within Autodesk Revit.

#### Remarks

This element is obtained from a curtain wall, curtain system, or curtain roof.
A curtain wall has only one curtain grid, while a curtain system or curtain roof may have several curtain grids.

### `P:Autodesk.Revit.DB.CurtainCell.CurveLoops`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainCell.CurveLoops`

#### Summary

The cell boundaries on the reference face. The boundaries can have more than one CurveLoop. Each item in the returned array represents a CurveLoop containing 3 or more than 3 edges.

### `P:Autodesk.Revit.DB.CurtainCell.PlanarizedCurveLoops`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainCell.PlanarizedCurveLoops`

#### Summary

The planarized curve loops for cell boundaries. The boundaries can have more than one CurveLoop. Each item in the returned array represents a CurveLoop containing 3 or more than 3 edges.

### `T:Autodesk.Revit.DB.CurtainCell`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurtainCell`

#### Summary

Represents a CurtainCell within Autodesk Revit.

### `P:Autodesk.Revit.DB.GeomCombination.AllMembers`

Member kind: property
Symbol: `Autodesk.Revit.DB.GeomCombination.AllMembers`

#### Summary

All elements that are joined in this geometry combination.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this geometry combination has already been deleted.

#### Remarks

All members are generic forms, for more information, refer to `T:Autodesk.Revit.DB.GenericForm` .

### `T:Autodesk.Revit.DB.GeomCombination`

Member kind: type
Symbol: `Autodesk.Revit.DB.GeomCombination`

#### Summary

An element created by Join and Cut operations applied to combinable elements in an Autodesk Revit family document.

### `P:Autodesk.Revit.DB.VertexIndexPair.Bottom`

Member kind: property
Symbol: `Autodesk.Revit.DB.VertexIndexPair.Bottom`

#### Summary

The index of the vertex pair from the bottom profile.

### `P:Autodesk.Revit.DB.VertexIndexPair.Top`

Member kind: property
Symbol: `Autodesk.Revit.DB.VertexIndexPair.Top`

#### Summary

The index of the vertex pair from the top profile.

### `T:Autodesk.Revit.DB.VertexIndexPair`

Member kind: type
Symbol: `Autodesk.Revit.DB.VertexIndexPair`

#### Summary

Represents a connection between vertices in the top and bottom profile of a blend.

#### Remarks

Use objects of this type in `M:Autodesk.Revit.DB.Blend.GetVertexConnectionMap` ,
`M:Autodesk.Revit.DB.Blend.SetVertexConnectionMap(Autodesk.Revit.DB.VertexIndexPairArray)` ,
`M:Autodesk.Revit.DB.SweptBlend.GetVertexConnectionMap` and
`M:Autodesk.Revit.DB.SweptBlend.SetVertexConnectionMap(Autodesk.Revit.DB.VertexIndexPairArray)` to get/set the vertex connection map.

### `P:Autodesk.Revit.DB.SweptBlend.TopProfile`

Member kind: property
Symbol: `Autodesk.Revit.DB.SweptBlend.TopProfile`

#### Summary

The curves which make up the top profile of the sketch.

#### Remarks

The indices of the curves in this array match the indices used in the vertex connection map.

### `P:Autodesk.Revit.DB.SweptBlend.BottomProfile`

Member kind: property
Symbol: `Autodesk.Revit.DB.SweptBlend.BottomProfile`

#### Summary

The curves which make up the bottom profile of the sketch.

#### Remarks

The indices of the curves in this array match the indices used in the vertex connection map.

### `M:Autodesk.Revit.DB.SweptBlend.SetVertexConnectionMap(Autodesk.Revit.DB.VertexIndexPairArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SweptBlend.SetVertexConnectionMap(Autodesk.Revit.DB.VertexIndexPairArray)`

#### Summary

Sets the mapping between the vertices in the top and bottom profiles.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"vertexMap"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the input argument-"vertexMap"-is empty.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the document failed to regenerate.

### `M:Autodesk.Revit.DB.SweptBlend.GetVertexConnectionMap`

Member kind: method
Symbol: `Autodesk.Revit.DB.SweptBlend.GetVertexConnectionMap`

#### Summary

Gets the mapping between the vertices in the top and bottom profiles.

#### Remarks

Each vertex refers to the start point of the curve from the top and bottom profiles.

### `P:Autodesk.Revit.DB.SweptBlend.SelectedPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.SweptBlend.SelectedPath`

#### Summary

The selected curve used for the swept blend path.

#### Remarks

If the swept blend is based on a sketched path, this property is `null` .

### `P:Autodesk.Revit.DB.SweptBlend.PathSketch`

Member kind: property
Symbol: `Autodesk.Revit.DB.SweptBlend.PathSketch`

#### Summary

The sketched path for the swept blend.

#### Remarks

If the swept blend is based on selected 3d curve, this property is `null` .

### `P:Autodesk.Revit.DB.SweptBlend.BottomProfileSymbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.SweptBlend.BottomProfileSymbol`

#### Summary

The bottom family symbol profile of the swept blend.

#### Remarks

If the bottom profile is sketch-based, this property is `null` .

### `P:Autodesk.Revit.DB.SweptBlend.BottomSketch`

Member kind: property
Symbol: `Autodesk.Revit.DB.SweptBlend.BottomSketch`

#### Summary

The bottom profile sketch of the swept blend.

#### Remarks

If the bottom profile is based on a family symbol, this property is `null` .

### `P:Autodesk.Revit.DB.SweptBlend.TopProfileSymbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.SweptBlend.TopProfileSymbol`

#### Summary

The top family symbol profile of the swept blend.

#### Remarks

If the top profile is sketch-based, this property is `null` .
