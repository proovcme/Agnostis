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
Shard: 22
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `P:Autodesk.Revit.DB.SiteLocation.Longitude`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteLocation.Longitude`

#### Summary

The longitude of the site location.

#### Remarks

A property that contains the longitude of the site location.
The value of this property is in radians between +PI and -PI. If the given value is
not between -PI and PI, it will be shifted by multiples of 2PI until it is in range.

When setting this property:
Revit will attempt to match the coordinates to a city it knows about, and if a match is found, will set the
name accordingly.

Revit will attempt to automatically adjust the time zone value to match the new Longitude value set using
`!:Autodesk::Revit::DB::SunAndShadowSettings::CalculateTimeZone` . For some boundary
cases, the time zone calculated may not be correct. You can set the `P:Autodesk.Revit.DB.SiteLocation.TimeZone` property directly to the correct
value if necessary.

Revit will attempt to automatically update the weather station associated with the coordinates.

#### Value

The longitude, in radians between -PI and PI. If the value is not
between -PI and PI, it will be shifted by multiples of 2PI until
it is in range.

### `P:Autodesk.Revit.DB.SiteLocation.Latitude`

Member kind: property
Symbol: `Autodesk.Revit.DB.SiteLocation.Latitude`

#### Summary

The latitude of the site location.

#### Remarks

A property that contains the latitude of the site location.
The value of this property is in radians between +PI/2 and -PI/2.

When setting this property:
Revit will attempt to match the coordinates to a city it knows about, and if a match is found, will set the
name accordingly.

Revit will attempt to automatically adjust the time zone value to match the new Latitude value set using
`!:Autodesk::Revit::DB::SunAndShadowSettings::CalculateTimeZone` . For some boundary
cases, the time zone calculated may not be correct. You can set the `P:Autodesk.Revit.DB.SiteLocation.TimeZone` property directly to the
correct value if necessary.

Revit will attempt to automatically update the weather station associated with the location's coordinates.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The latitude value is out of range. It must be between -PI/2 and PI/2.

### `M:Autodesk.Revit.DB.SiteLocation.ConvertFromProjectTime(System.DateTime)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SiteLocation.ConvertFromProjectTime(System.DateTime)`

#### Summary

Converts project time to UTC time.

#### Remarks

Daylight savings time is not considered during this conversion.

#### Parameter `projectTime`

The project time.

#### Return

Returns the UTC time.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the projectTime's kind is not Unspecified.

### `M:Autodesk.Revit.DB.SiteLocation.ConvertToProjectTime(System.DateTime)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SiteLocation.ConvertToProjectTime(System.DateTime)`

#### Summary

Converts local time or UTC time to project time.

#### Remarks

Daylight savings time is not considered during this conversion.

#### Parameter `inputTime`

The input local time or UTC time.

#### Return

Returns the project time of Unspecified kind.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the inputTime's kind is neither Local nor Utc.

### `T:Autodesk.Revit.DB.SiteLocation`

Member kind: type
Symbol: `Autodesk.Revit.DB.SiteLocation`

#### Summary

Contains the geographical location information for the project's site.

#### Remarks

Each project may have one site which dictates where in the world the project is
based. On this site there may be several locations of the same project. These are represented
by ProjectLocation objects. The site location object can be found by using the SiteLocation property
on the Document object. The properties of this object can be changed such that it represents any
location on the planet or to a known city. Cities already programmed into Revit can be found
from the Cities property on the Application object.

### `M:Autodesk.Revit.DB.ProjectLocation.SetProjectedSpaceToLocalTrf(System.String,Autodesk.Revit.DB.XYZ,System.Double,Autodesk.Revit.DB.XYZ,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocation.SetProjectedSpaceToLocalTrf(System.String,Autodesk.Revit.DB.XYZ,System.Double,Autodesk.Revit.DB.XYZ,System.Double,System.Double)`

#### Summary

Set the transform from projected space to local space, which is calculated from the given local point, grid point, rotation angle and scale factor.

#### Parameter `coordSystem`

the geographic coordinate system

#### Parameter `localPoint`

The point in local space.

#### Parameter `gridPoint`

The point in projected space.

#### Parameter `rotationAngle`

The angle with respect to north (clockwise).

#### Parameter `scaleFactor`

The grid scale factor.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ProjectLocation.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocation.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String)`

#### Summary

Create an instance of ProjectLocation in the document.

#### Remarks

The created instace of ProjectLocation would have the specified name and an identity `!:Autodesk.Revit.DB.Transform` .

#### Parameter `document`

The document where the new instance of ProjectLocation would be created in.

#### Parameter `siteLocationId`

The ElementId of the SiteLocation to which the new ProjectLocation would be created.

#### Parameter `name`

The name of the instance of ProjectLocation to be created.

#### Returns

The newly created instance of ProjectLocation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The element siteLocationId does not exist in the document
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
There is already a ProjectLocation with this name in the given SiteLocation.

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

### `M:Autodesk.Revit.DB.ProjectLocation.IsProjectLocationNameUnique(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocation.IsProjectLocationNameUnique(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.ElementId)`

#### Summary

Verifies that there is no existing ProjectLocation with the given name belonging to the given SiteLocation.

#### Parameter `document`

The document to check.

#### Parameter `name`

The name to check.

#### Parameter `siteLocationId`

The ElementId of the SiteLocation which the ProjectLocation belongs to.

#### Returns

True if the name is unused (among ProjectLocations). False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.ProjectLocation.Duplicate(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocation.Duplicate(System.String)`

#### Summary

Generate a copy of this project location with the specified name.

#### Remarks

The name must not be the same as the name of any existing locations.
This function will modify the document, as the new ProjectLocation
will be added to it.

#### Returns

A new ProjectLocation which is a duplicate of this location, with
the input name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.ProjectLocation.GetSiteLocation`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocation.GetSiteLocation`

#### Summary

Gets the site location to which this project location refers.

#### Remarks

The site location object contains the longitude, latitude, and time-zone
of the entire project site.

### `M:Autodesk.Revit.DB.ProjectLocation.SetProjectPosition(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ProjectPosition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocation.SetProjectPosition(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ProjectPosition)`

#### Summary

Sets the coordinates of a point in the ProjectLocation's coordinate system.

#### Remarks

When setting this value, the transformations applied to the location are modified such that the passed point
becomes the specified North/South, East/West and Elevation, and the coordinate transform will have the designated
angular rotation. This is similar to the Revit command "Specify Coordinates at Point".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Unable to use the project position's transform to calculate the point.

### `M:Autodesk.Revit.DB.ProjectLocation.GetProjectPosition(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocation.GetProjectPosition(Autodesk.Revit.DB.XYZ)`

#### Summary

Gets the coordinates of a point in the ProjectLocation's coordinate system.

#### Remarks

When getting this value, the North/South, East/West, and Elevation values report the coordinates of the point
similar to the Revit command "Report Shared Coordinates". To get the values of the transformations applied by this
project location, pass XYZ.Zero.

If the project has acquired shared coordinates from a linked model, the shared coordinate transformation will
be reflected in the coordinates of the transformed point returned by this property.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Unable to use the project position's transform to calculate the point.

### `T:Autodesk.Revit.DB.ProjectLocation`

Member kind: type
Symbol: `Autodesk.Revit.DB.ProjectLocation`

#### Summary

A representation of a specific instance and location of the current project.

#### Remarks

When using shared coordinates, ProjectLocations can be used to specify
specific locations for instances of a linked model. A ProjectLocation
keeps track of the position of an instance in relationship to the project's
SiteLocation.

By default, each Revit project contains at least one named location, called Internal.
Existing ProjectLocation objects can be found by using the ProjectLocations property on
the Document object. New project locations can be created by duplicating an existing project
location using the Duplicate method, and modifying the location's project position.

See also `T:Autodesk.Revit.DB.SiteLocation`

### `M:Autodesk.Revit.DB.Analysis.GenericZone.GetBoundaries`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.GenericZone.GetBoundaries`

#### Summary

Gets the boundaries for the generic zone.

#### Returns

The generic zone boundaries.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Analysis.GenericZone.GetDomainData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.GenericZone.GetDomainData`

#### Summary

Gets the domain data for the generic zone.

#### Returns

Returns a pointer to the base class for specific domain requirements for the generic zone.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Analysis.GenericZone.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.GenericZoneDomainData,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.GenericZone.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Analysis.GenericZoneDomainData,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop})`

#### Summary

Creates a new instance of a generic zone and adds it to the document.

#### Parameter `doc`

The document where the element will be created and added.

#### Parameter `name`

The name of the generic zone to be created.

#### Parameter `domainData`

The specific domain requirements for the generic zone.

#### Parameter `levelId`

The base level on which the generic zone will be created.

#### Parameter `curveLoops`

The loops that define the lines, curves and areas that overlap or crosses the elements you want to belong to the zone.
Multiple loops are allowed, they can be open or closed, but they should be on the same horizontal plane.

#### Returns

The newly created generic zone.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
name is an empty string.
-or-
The ElementId levelId is not a Level.
-or-
The curve loops in the input array are empty.
-or-
The input curve loops do not all lie in the same horizontal plane.

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

2020.1

### `P:Autodesk.Revit.DB.Analysis.GenericZone.LevelOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.GenericZone.LevelOffset`

#### Summary

The offset distance from this zone to the associated level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for offset must be no more than 30000 feet in absolute value.

#### Since

2021.1

### `T:Autodesk.Revit.DB.Analysis.GenericZone`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.GenericZone`

#### Summary

Provides access to the GenericZone Element in Autodesk Revit.

#### Remarks

A generic zone is a tool that provides for a method of selecting elements that somehow come in contact with the zone object.
A zone is a non-hierarchical structure of geometric information, area or volume definitions for the purpose of analysis.
A generic zone will contain specific domain requirements provided at creation of the element.

#### Since

2020.1

### `P:Autodesk.Revit.DB.Visual.Generic.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericBumpAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericBumpAmount`

#### Summary

The property labeled "Amount" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "-1000, 1000".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericBumpMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericBumpMap`

#### Summary

The property labeled "Bump" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericSelfIllumColorTemperature`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericSelfIllumColorTemperature`

#### Summary

The property labeled "Color Temperature" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDouble".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericSelfIllumLuminance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericSelfIllumLuminance`

#### Summary

The property labeled "Luminance" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDouble".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericSelfIllumFilterMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericSelfIllumFilterMap`

#### Summary

The property labeled "Filter Color" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericCutoutOpacity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericCutoutOpacity`

#### Summary

The property labeled "Cutouts" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDouble".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericRefractionIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericRefractionIndex`

#### Summary

The property labeled "Refraction" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0.01, 5".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericRefractionTranslucencyWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericRefractionTranslucencyWeight`

#### Summary

The property labeled "Translucency" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericTransparencyImageFade`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericTransparencyImageFade`

#### Summary

The property labeled "Image Fade" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericTransparency`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericTransparency`

#### Summary

The property labeled "Transparency" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericReflectivityAt90deg`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericReflectivityAt90deg`

#### Summary

The property labeled "Reflectivity/Oblique" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDouble".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericReflectivityAt0deg`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericReflectivityAt0deg`

#### Summary

The property labeled "Reflectivity/Direct" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDouble".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericIsMetal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericIsMetal`

#### Summary

The property labeled "Highlights" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericGlossiness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericGlossiness`

#### Summary

The property labeled "Glossiness" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDouble".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericDiffuseImageFade`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericDiffuseImageFade`

#### Summary

The property labeled "Image Fade" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.ColorByObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.ColorByObject`

#### Summary

The property labeled "Color By Object" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Generic.GenericDiffuse`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Generic.GenericDiffuse`

#### Summary

The property labeled "Color/Image" from the "Generic" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Generic`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Generic`

#### Summary

A static class that provides access to the property names that appear in the Generic visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.SymbolGeometryId.AsIdentifier`

Member kind: method
Symbol: `Autodesk.Revit.DB.SymbolGeometryId.AsIdentifier`

#### Summary

This will convert the SymbolGeometryId to a string that can be used in comparisons to check if two instances point to the same piece of geometry managed by the same symbol element.

#### Returns

Returns a string that can be used in comparisons to check if two instances point to the same piece of geometry managed by the same symbol element.

#### Since

2023

### `M:Autodesk.Revit.DB.SymbolGeometryId.AsUniqueIdentifier`

Member kind: method
Symbol: `Autodesk.Revit.DB.SymbolGeometryId.AsUniqueIdentifier`

#### Summary

Returns a string suitable to determine if two instances point to the same piece of geometry managed by the same symbol element.

#### Returns

A string suitable to determine if two instances point to the same piece of geometry managed by the same symbol element.

#### Since

2023

### `P:Autodesk.Revit.DB.SymbolGeometryId.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SymbolGeometryId.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.SymbolGeometryId.SymbolId`

Member kind: property
Symbol: `Autodesk.Revit.DB.SymbolGeometryId.SymbolId`

#### Summary

The id of the symbol that is containing the shared geometry.

#### Since

2023

### `T:Autodesk.Revit.DB.SymbolGeometryId`

Member kind: type
Symbol: `Autodesk.Revit.DB.SymbolGeometryId`

#### Summary

This class is used to identify a piece of geometry managed by a symbol element.

#### Remarks

This class can be used to compare if two instances points to the same piece of geometry managed by a symbol element.
The string returned by AsIdentifier can be used to achieve this.

#### Since

2023

### `M:Autodesk.Revit.DB.RenderingSettings.GetRenderingRegionOutline`

Member kind: method
Symbol: `Autodesk.Revit.DB.RenderingSettings.GetRenderingRegionOutline`

#### Summary

Returns the outline of the rendering region.

#### Returns

The outline of the rendering region.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RenderingSettings are not currently using region rendering.

#### Since

2013

### `M:Autodesk.Revit.DB.RenderingSettings.SetRenderingQualitySettings(Autodesk.Revit.DB.RenderingQualitySettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RenderingSettings.SetRenderingQualitySettings(Autodesk.Revit.DB.RenderingQualitySettings)`

#### Summary

Change rendering quality settings.

#### Parameter `settings`

An instance of the new rendering quality settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.RenderingSettings.GetRenderingQualitySettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.RenderingSettings.GetRenderingQualitySettings`

#### Summary

Returns an object that represents the rendering quality settings.

#### Returns

The rendering quality settings.

#### Since

2013

### `M:Autodesk.Revit.DB.RenderingSettings.SetRenderingImageExposureSettings(Autodesk.Revit.DB.RenderingImageExposureSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RenderingSettings.SetRenderingImageExposureSettings(Autodesk.Revit.DB.RenderingImageExposureSettings)`

#### Summary

Changes the rendering image exposure settings.

#### Parameter `exposure`

An instance of the new rendering image exposure settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.RenderingSettings.GetRenderingImageExposureSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.RenderingSettings.GetRenderingImageExposureSettings`

#### Summary

Returns an object that represents the rendering image exposure settings.

#### Returns

The rendering image exposure settings.

#### Since

2013

### `M:Autodesk.Revit.DB.RenderingSettings.SetBackgroundSettings(Autodesk.Revit.DB.BackgroundSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RenderingSettings.SetBackgroundSettings(Autodesk.Revit.DB.BackgroundSettings)`

#### Summary

Changes the rendering background settings details for the current background style.

#### Parameter `background`

An instance of the new rendering background settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.RenderingSettings.GetBackgroundSettings`

Member kind: method
Symbol: `Autodesk.Revit.DB.RenderingSettings.GetBackgroundSettings`

#### Summary

Returns an object that represents the rendering background settings.

#### Remarks

Different kind of settings object will be returned according to different background style.
It could be SkyBackgroundSettings, ColorBackgroundSettings, or ImageBackgroundSettings.

#### Returns

The rendering background settings.

#### Since

2013

### `P:Autodesk.Revit.DB.RenderingSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RenderingSettings.ResolutionValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingSettings.ResolutionValue`

#### Summary

The rendering resolution in dots per inch (DPI).

#### Since

2013

### `P:Autodesk.Revit.DB.RenderingSettings.LightingSource`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingSettings.LightingSource`

#### Summary

The lighting scheme type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.RenderingSettings.PrinterResolution`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingSettings.PrinterResolution`

#### Summary

The resolution level when using printer.

#### Remarks

The suitable resolution value is decided by default. You may obtain it from the ResolutionValue property.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The resolution target is not printer.

#### Since

2013

### `P:Autodesk.Revit.DB.RenderingSettings.ResolutionTarget`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingSettings.ResolutionTarget`

#### Summary

The resolution target.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.RenderingSettings.BackgroundStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingSettings.BackgroundStyle`

#### Summary

The enum value that controls the background style for rendering.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.RenderingSettings.UsesRegionRendering`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingSettings.UsesRegionRendering`

#### Summary

The bool value that indicates whether to use region rendering.

#### Since

2013

### `T:Autodesk.Revit.DB.RenderingSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.RenderingSettings`

#### Summary

Represents the rendering settings for a 3d view.

#### Since

2013

### `P:Autodesk.Revit.DB.RenderingImageExposureSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingImageExposureSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RenderingImageExposureSettings.Saturation`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingImageExposureSettings.Saturation`

#### Summary

The value of rendering image saturation.

#### Remarks

Increase this value to get more intense colors.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value of saturation is not valid. The valid range is 0 to 5.

#### Since

2013

### `P:Autodesk.Revit.DB.RenderingImageExposureSettings.WhitePoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingImageExposureSettings.WhitePoint`

#### Summary

The white point value.

#### Remarks

Specify the white balance of the rendering(measured in Kelvin). Incandescent lighting:2800 K; Daylight 6500K.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value of white point is not valid. The valid range is 1800 to 15000.

#### Since

2013

### `P:Autodesk.Revit.DB.RenderingImageExposureSettings.Shadows`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingImageExposureSettings.Shadows`

#### Summary

The shadows value.

#### Remarks

Increase this value to get darker shadows.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value of shadows is not valid. The valid range is 0.1 to 4.

#### Since

2013

### `P:Autodesk.Revit.DB.RenderingImageExposureSettings.Highlights`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingImageExposureSettings.Highlights`

#### Summary

The highlights value.

#### Remarks

Increase this value to get brighter highlights.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value of highlights is not valid. The valid range is 0 to 1.

#### Since

2013

### `P:Autodesk.Revit.DB.RenderingImageExposureSettings.ExposureValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingImageExposureSettings.ExposureValue`

#### Summary

The value of rendering image exposure.

#### Remarks

Default exposure value based on Lighting Scheme.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value of rendering image exposure is not valid. The valid range is 0 to 21.

#### Since

2013

### `T:Autodesk.Revit.DB.RenderingImageExposureSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.RenderingImageExposureSettings`

#### Summary

Represents the exposure settings of rendering.

#### Since

2013

### `P:Autodesk.Revit.DB.ImageBackgroundSettings.OffsetHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageBackgroundSettings.OffsetHeight`

#### Summary

The vertical offset of the rendering image to the rendering region.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for height must be no more than 30000 feet in absolute value.

#### Since

2013

### `P:Autodesk.Revit.DB.ImageBackgroundSettings.OffsetWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageBackgroundSettings.OffsetWidth`

#### Summary

The horizontal offset of the rendering image to the rendering region.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for width must be no more than 30000 feet in absolute value.

#### Since

2013

### `P:Autodesk.Revit.DB.ImageBackgroundSettings.BackgroundImageFit`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageBackgroundSettings.BackgroundImageFit`

#### Summary

The background image fit type.

#### Remarks

This value indicates how scale should be applied to the image in order to fit it to a page or screen.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.ImageBackgroundSettings.FilePath`

Member kind: property
Symbol: `Autodesk.Revit.DB.ImageBackgroundSettings.FilePath`

#### Summary

File path of the image for the rendering background.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The file specified by path is not an image file.
A valid image file should be in one of the following formats: bmp, jpg, jpeg, png, tif.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

When setting this property: The file specified by path doesn't exist.

#### Since

2013

### `T:Autodesk.Revit.DB.ImageBackgroundSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.ImageBackgroundSettings`

#### Summary

Represents the rendering image background settings.

#### Since

2013

### `P:Autodesk.Revit.DB.GradientBackgroundSettings.GroundColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.GradientBackgroundSettings.GroundColor`

#### Summary

The color of the ground.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.GradientBackgroundSettings.HorizonColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.GradientBackgroundSettings.HorizonColor`

#### Summary

The color of the horizon.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.GradientBackgroundSettings.SkyColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.GradientBackgroundSettings.SkyColor`

#### Summary

The color of the top of the sky.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.GradientBackgroundSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.GradientBackgroundSettings`

#### Summary

Represents the view gradient background settings.

#### Remarks

The colors of the background are interpolated for the pixels
corresponding to the sky - from the "sky color" (top) to the "horizon
color" (bottom). The ground is represented with a solid color ("ground color").

#### Since

2014

### `P:Autodesk.Revit.DB.ColorBackgroundSettings.Color`

Member kind: property
Symbol: `Autodesk.Revit.DB.ColorBackgroundSettings.Color`

#### Summary

The color of the rendering background.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.ColorBackgroundSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.ColorBackgroundSettings`

#### Summary

Represents the rendering color background settings.

#### Since

2013

### `T:Autodesk.Revit.DB.SkyBackgroundSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.SkyBackgroundSettings`

#### Summary

Represents the rendering sky background settings.

#### Since

2013

### `P:Autodesk.Revit.DB.BackgroundSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BackgroundSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.BackgroundSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.BackgroundSettings`

#### Summary

Represents the rendering background settings.

#### Since

2013

### `T:Autodesk.Revit.DB.BackgroundStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.BackgroundStyle`

#### Summary

Indicates the background style in rendering settings.

#### Since

2013

### `F:Autodesk.Revit.DB.BackgroundStyle.Transparent`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackgroundStyle.Transparent`

#### Summary

Transparent background

### `F:Autodesk.Revit.DB.BackgroundStyle.Image`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackgroundStyle.Image`

#### Summary

Image background.

### `F:Autodesk.Revit.DB.BackgroundStyle.Color`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackgroundStyle.Color`

#### Summary

Color background.

### `F:Autodesk.Revit.DB.BackgroundStyle.SkyVeryCloudy`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackgroundStyle.SkyVeryCloudy`

#### Summary

Very cloudy sky background.

### `F:Autodesk.Revit.DB.BackgroundStyle.SkyCloudy`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackgroundStyle.SkyCloudy`

#### Summary

Cloudy sky background.

### `F:Autodesk.Revit.DB.BackgroundStyle.SkyFewClouds`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackgroundStyle.SkyFewClouds`

#### Summary

Sky background with few clouds.

### `F:Autodesk.Revit.DB.BackgroundStyle.SkyVeryFewClouds`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackgroundStyle.SkyVeryFewClouds`

#### Summary

Sky background with very few clouds.

### `F:Autodesk.Revit.DB.BackgroundStyle.SkyNoClouds`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackgroundStyle.SkyNoClouds`

#### Summary

Sky background without clouds.

### `M:Autodesk.Revit.DB.RenderingQualitySettings.IsCustomQuality`

Member kind: method
Symbol: `Autodesk.Revit.DB.RenderingQualitySettings.IsCustomQuality`

#### Summary

Checks if the current rendering quality is custom or not.

#### Returns

True if the current rendering quality is custom, false otherwise.

#### Since

2017

### `M:Autodesk.Revit.DB.RenderingQualitySettings.IsValidRenderTime(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RenderingQualitySettings.IsValidRenderTime(System.Int32)`

#### Summary

Validate the render time is between 1 and 32768.

#### Parameter `value`

The render time value to validate.

#### Returns

True if the value is in the proper range, false otherwise.

#### Since

2017

### `M:Autodesk.Revit.DB.RenderingQualitySettings.IsValidRenderLevel(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RenderingQualitySettings.IsValidRenderLevel(System.Int32)`

#### Summary

Validate the render level is between 1 and 40

#### Parameter `value`

The render level value to validate.

#### Returns

True if the render level value is in the proper range, false otherwise.

#### Since

2017

### `P:Autodesk.Revit.DB.RenderingQualitySettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingQualitySettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RenderingQualitySettings.RenderTime`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingQualitySettings.RenderTime`

#### Summary

The render target time as a numerical value between 1 and 32768.

#### Remarks

Increase this value to increase render time.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value is not valid RenderTime.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The RenderingQualitySettings does not use custom quality currently.
To use custom quality, set RenderingQuality property to RenderingQuality.Custom.

#### Since

2017

### `P:Autodesk.Revit.DB.RenderingQualitySettings.RenderLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingQualitySettings.RenderLevel`

#### Summary

The render target level as a numerical value between 1 and 40.

#### Remarks

Increase this value to increase render level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value is not valid for RenderLevel.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The RenderingQualitySettings does not use custom quality currently.
To use custom quality, set RenderingQuality property to RenderingQuality.Custom.

#### Since

2017

### `P:Autodesk.Revit.DB.RenderingQualitySettings.RenderDuration`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingQualitySettings.RenderDuration`

#### Summary

A value that controls render duration.

#### Remarks

The duration of rendering.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The value is not valid for RenderDuration.
-or-
When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The RenderingQualitySettings does not use custom quality currently.
To use custom quality, set RenderingQuality property to RenderingQuality.Custom.

#### Since

2017

### `P:Autodesk.Revit.DB.RenderingQualitySettings.LightAndMaterialAccuracyMode`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingQualitySettings.LightAndMaterialAccuracyMode`

#### Summary

A value that controls light and material accuracy mode.

#### Remarks

The method of the renderer engine dealing with materials and shadows.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The RenderingQualitySettings does not use custom quality currently.
To use custom quality, set RenderingQuality property to RenderingQuality.Custom.

#### Since

2017

### `P:Autodesk.Revit.DB.RenderingQualitySettings.RenderingQuality`

Member kind: property
Symbol: `Autodesk.Revit.DB.RenderingQualitySettings.RenderingQuality`

#### Summary

The quality applied for rendering.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `T:Autodesk.Revit.DB.RenderingQualitySettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.RenderingQualitySettings`

#### Summary

Represents the quality settings of rendering.

#### Remarks

The other properties in this class can only be modified if the RenderingQuality property is currently set to Custom.

### `T:Autodesk.Revit.DB.RenderDuration`

Member kind: type
Symbol: `Autodesk.Revit.DB.RenderDuration`

#### Summary

An enumerated type containing possible duration types to do Raytracer render.

#### Since

2017

### `F:Autodesk.Revit.DB.RenderDuration.UntilSatisfactory`

Member kind: field
Symbol: `Autodesk.Revit.DB.RenderDuration.UntilSatisfactory`

#### Summary

Render until satisfactory.

### `F:Autodesk.Revit.DB.RenderDuration.ByTime`

Member kind: field
Symbol: `Autodesk.Revit.DB.RenderDuration.ByTime`

#### Summary

Render by the defined time.

### `F:Autodesk.Revit.DB.RenderDuration.ByLevel`

Member kind: field
Symbol: `Autodesk.Revit.DB.RenderDuration.ByLevel`

#### Summary

Render by the defined iterations.

### `T:Autodesk.Revit.DB.LightAndMaterialAccuracyMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.LightAndMaterialAccuracyMode`

#### Summary

An enumerated type containing possible Light and Material Accuracy modes for Raytracer render.

#### Since

2017

### `F:Autodesk.Revit.DB.LightAndMaterialAccuracyMode.Advanced`

Member kind: field
Symbol: `Autodesk.Revit.DB.LightAndMaterialAccuracyMode.Advanced`

#### Summary

Soft shadows and soft reflections from semi-rough materials will be rendered with a high quality level. This is the
standard setting that you typically want to rely on for final high quality renderings.

### `F:Autodesk.Revit.DB.LightAndMaterialAccuracyMode.Simplified`

Member kind: field
Symbol: `Autodesk.Revit.DB.LightAndMaterialAccuracyMode.Simplified`

#### Summary

Rough and semi-rough materials are approximated. Consequently, materials may look more shinier than expected.
Lighting is approximated so shadows will lack in details.

### `T:Autodesk.Revit.DB.RenderingQuality`

Member kind: type
Symbol: `Autodesk.Revit.DB.RenderingQuality`

#### Summary

Indicates the rendering quality in rendering settings.

#### Since

2013

### `F:Autodesk.Revit.DB.RenderingQuality.Custom`

Member kind: field
Symbol: `Autodesk.Revit.DB.RenderingQuality.Custom`

#### Summary

Custom level quality.

### `F:Autodesk.Revit.DB.RenderingQuality.VeryHigh`

Member kind: field
Symbol: `Autodesk.Revit.DB.RenderingQuality.VeryHigh`

#### Summary

Very high level quality.

### `F:Autodesk.Revit.DB.RenderingQuality.High`

Member kind: field
Symbol: `Autodesk.Revit.DB.RenderingQuality.High`

#### Summary

High level quality.

### `F:Autodesk.Revit.DB.RenderingQuality.Medium`

Member kind: field
Symbol: `Autodesk.Revit.DB.RenderingQuality.Medium`

#### Summary

Medium level quality.

### `F:Autodesk.Revit.DB.RenderingQuality.Draft`

Member kind: field
Symbol: `Autodesk.Revit.DB.RenderingQuality.Draft`

#### Summary

Draft level quality.

### `T:Autodesk.Revit.DB.LightingSource`

Member kind: type
Symbol: `Autodesk.Revit.DB.LightingSource`

#### Summary

Indicates the lighting scheme type in rendering settings.

#### Since

2013

### `F:Autodesk.Revit.DB.LightingSource.InteriorArtificial`

Member kind: field
Symbol: `Autodesk.Revit.DB.LightingSource.InteriorArtificial`

#### Summary

Interior source of light, artificial light only.

### `F:Autodesk.Revit.DB.LightingSource.InteriorSunAndArtificial`

Member kind: field
Symbol: `Autodesk.Revit.DB.LightingSource.InteriorSunAndArtificial`

#### Summary

Interior source of light, sun and artificial light.

### `F:Autodesk.Revit.DB.LightingSource.InteriorSun`

Member kind: field
Symbol: `Autodesk.Revit.DB.LightingSource.InteriorSun`

#### Summary

Interior source of light, sun only.

### `F:Autodesk.Revit.DB.LightingSource.ExteriorArtificial`

Member kind: field
Symbol: `Autodesk.Revit.DB.LightingSource.ExteriorArtificial`

#### Summary

Exterior source of light, artificial light only.

### `F:Autodesk.Revit.DB.LightingSource.ExteriorSunAndArtificial`

Member kind: field
Symbol: `Autodesk.Revit.DB.LightingSource.ExteriorSunAndArtificial`

#### Summary

Exterior source of light, sun and artificial light.

### `F:Autodesk.Revit.DB.LightingSource.ExteriorSun`

Member kind: field
Symbol: `Autodesk.Revit.DB.LightingSource.ExteriorSun`

#### Summary

Exterior source of light, sun only.

### `T:Autodesk.Revit.DB.PrinterResolution`

Member kind: type
Symbol: `Autodesk.Revit.DB.PrinterResolution`

#### Summary

Controls the resolution level in rendering settings.

#### Remarks

It is applicable only when using printer resolution.
The suitable resolution value for each resolution level is decided by default in Revit.

#### Since

2013

### `F:Autodesk.Revit.DB.PrinterResolution.VeryHigh`

Member kind: field
Symbol: `Autodesk.Revit.DB.PrinterResolution.VeryHigh`

#### Summary

VeryHigh printer resolution.

### `F:Autodesk.Revit.DB.PrinterResolution.High`

Member kind: field
Symbol: `Autodesk.Revit.DB.PrinterResolution.High`

#### Summary

High printer resolution.

### `F:Autodesk.Revit.DB.PrinterResolution.Medium`

Member kind: field
Symbol: `Autodesk.Revit.DB.PrinterResolution.Medium`

#### Summary

Medium printer resolution.

### `F:Autodesk.Revit.DB.PrinterResolution.Low`

Member kind: field
Symbol: `Autodesk.Revit.DB.PrinterResolution.Low`

#### Summary

Low printer resolution.

### `T:Autodesk.Revit.DB.ResolutionTarget`

Member kind: type
Symbol: `Autodesk.Revit.DB.ResolutionTarget`

#### Summary

Indicates the resolution target(Screen or Printer) used for rendering settings.

#### Since

2013

### `F:Autodesk.Revit.DB.ResolutionTarget.Printer`

Member kind: field
Symbol: `Autodesk.Revit.DB.ResolutionTarget.Printer`

#### Summary

Uses printer resolution for rendering output settings.

### `F:Autodesk.Revit.DB.ResolutionTarget.Screen`

Member kind: field
Symbol: `Autodesk.Revit.DB.ResolutionTarget.Screen`

#### Summary

Uses screen resolution for rendering output settings.

### `T:Autodesk.Revit.DB.BackgroundImageFit`

Member kind: type
Symbol: `Autodesk.Revit.DB.BackgroundImageFit`

#### Summary

Indicates the background image fit type in rendering settings.

#### Since

2013

### `F:Autodesk.Revit.DB.BackgroundImageFit.Stretch`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackgroundImageFit.Stretch`

#### Summary

The image is stretched in both directions so it matches the view's size.

### `F:Autodesk.Revit.DB.BackgroundImageFit.Horizontal`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackgroundImageFit.Horizontal`

#### Summary

The image is proportionally resized so its width matches the view's width.

### `F:Autodesk.Revit.DB.BackgroundImageFit.Vertical`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackgroundImageFit.Vertical`

#### Summary

The image is proportionally resized so its height matches the view's height.

### `F:Autodesk.Revit.DB.BackgroundImageFit.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackgroundImageFit.None`

#### Summary

No scale applied to the image; it will keep its original size.

### `P:Autodesk.Revit.DB.GBXMLExportOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.GBXMLExportOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.GBXMLExportOptions.ExportAnalyticalSystems`

Member kind: property
Symbol: `Autodesk.Revit.DB.GBXMLExportOptions.ExportAnalyticalSystems`

#### Summary

Indicates if the gbXML should contain analytical system elements (e.g., Water Loop, Air System, and Zone Equipment).

#### Since

2020.1

### `P:Autodesk.Revit.DB.GBXMLExportOptions.Encoding`

Member kind: property
Symbol: `Autodesk.Revit.DB.GBXMLExportOptions.Encoding`

#### Summary

The encoding options to go into the processing instruction for the exported gbXML file.

#### Since

2020

### `P:Autodesk.Revit.DB.GBXMLExportOptions.ExportEnergyModelType`

Member kind: property
Symbol: `Autodesk.Revit.DB.GBXMLExportOptions.ExportEnergyModelType`

#### Summary

The energy model type from which gbXML will be exported.

#### Remarks

Default value is SpatialElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.GBXMLExportOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.GBXMLExportOptions.#ctor`

#### Summary

Constructs a new instance of the options used to export a model in gbXML (green-building) format.

#### Since

2015

### `T:Autodesk.Revit.DB.GBXMLExportOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.GBXMLExportOptions`

#### Summary

Green-Building XML Export options.

#### Since

2015

### `T:Autodesk.Revit.DB.ExportEnergyModelType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExportEnergyModelType`

#### Summary

This enum is used to define if energy model used for gbXML export should be based on rooms/spaces, building elements or analysis mode in EnergyDataSettings.

#### Since

2015

### `F:Autodesk.Revit.DB.ExportEnergyModelType.AnalysisMode`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportEnergyModelType.AnalysisMode`

#### Summary

Energy model based on analysis mode in EnergyDataSettings.

### `F:Autodesk.Revit.DB.ExportEnergyModelType.BuildingElement`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportEnergyModelType.BuildingElement`

#### Summary

The building element based energy analytical model.

### `F:Autodesk.Revit.DB.ExportEnergyModelType.SpatialElement`

Member kind: field
Symbol: `Autodesk.Revit.DB.ExportEnergyModelType.SpatialElement`

#### Summary

Energy model based on rooms or spaces.

### `M:Autodesk.Revit.DB.MultipleValuesIndicationSettings.GetMultipleValuesIndicationSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultipleValuesIndicationSettings.GetMultipleValuesIndicationSettings(Autodesk.Revit.DB.Document)`

#### Summary

Returns the MultipleValuesIndicationSettings element for a given document.

#### Remarks

Project documents have a MultipleValuesIndicationSettings element, one per document.
Family documents do not have MultipleValuesIndicationSettings elements.

#### Parameter `cda`

The document for which to get the MultipleValuesIndicationSettings element.

#### Returns

Returns the MultipleValuesIndicationSettings element in project documents
or `null` for family documents
.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.MultipleValuesIndicationSettings.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultipleValuesIndicationSettings.Value`

#### Summary

Value to be used as multiple values indication in the document.
If `P:Autodesk.Revit.DB.MultipleValuesIndicationSettings.Custom` is true, returns `P:Autodesk.Revit.DB.MultipleValuesIndicationSettings.CustomValue` , otherwise returns a hardcoded standard value.

#### Since

2022

### `P:Autodesk.Revit.DB.MultipleValuesIndicationSettings.CustomValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultipleValuesIndicationSettings.CustomValue`

#### Summary

Value used as multiple values indication if `P:Autodesk.Revit.DB.MultipleValuesIndicationSettings.Custom` is set to true.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.MultipleValuesIndicationSettings.Custom`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultipleValuesIndicationSettings.Custom`

#### Summary

If true, `P:Autodesk.Revit.DB.MultipleValuesIndicationSettings.CustomValue` is used as multiple values indication, otherwise a hardcoded standard value.

#### Since

2022

### `T:Autodesk.Revit.DB.MultipleValuesIndicationSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.MultipleValuesIndicationSettings`

#### Summary

MultipleValuesIndicationSettings is an element which contains project-wide settings for multiple values indication in Properties Palette and schedules.

#### Since

2022

### `M:Autodesk.Revit.DB.ExternalService.MultiServerService.SetServerState(System.Guid,Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.MultiServerService.SetServerState(System.Guid,Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

This method will simply switch the active state of a server without affecting in any way the other servers.

#### Remarks

For a service which has cref="Autodesk::Revit::DB::ExternalService::SupportActivation" set to false
calling this method will throw exception.

#### Parameter `serverId`

Id of the server to switch active state for.

#### Parameter `document`

Document for which to activate this server. If null, server will activate globally.

#### Parameter `bActive`

True to activate server, false to deactivate.

#### Returns

True if operation succeeded (even if the server state was not changed), false otherwise (e.g. when serverId is invalid).

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

For a service that doesn't support activation, the servers can't be activated/deactivated.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.MultiServerService.SetActiveServers(System.Collections.Generic.IList{System.Guid},Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.MultiServerService.SetActiveServers(System.Collections.Generic.IList{System.Guid},Autodesk.Revit.DB.Document)`

#### Summary

Changes the active servers and/or their order for the given document.

#### Remarks

More than one server per document can be set as active at any given time
in a multi-server service. A document does not have to have an explicitly
set active servers though - the application-wide active servers would be
normally used when the service is executed for such a document.

Having active servers for a document overrules the active servers
set for the application. That means if the service gets executed in
this particular document, the document-specific servers will be used
instead of the application-wide ones.

It is possible to set servers as active when other servers already are active
for that service in this document. Setting a new set or the same set
but with a different order will automatically replace the previously active
servers in that document

All the servers must be valid (registered with the service) and must be unique
in the set. The set may be empty though which allows to unset active servers
from a document, which means that the document will be executed with the currently
active servers set application-wide

For a service which has cref="Autodesk::Revit::DB::ExternalService::SupportActivation" set to false
calling this method will throw exception.

#### Parameter `serverIds`

A set of Ids of servers that are to be set as active for this service in this
document or an empty set if no server should currently be set as active in this
particular document.

#### Parameter `document`

The document for which the servers are set as active.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Some of the given Ids do not represent valid servers of the service.
-or-
The list of servers contains duplicates. The SetActiveServers method expects a set of unique servers.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The operation is not allowed because the service is being executed.
-or-
For a service that doesn't support activation, the servers can't be activated/deactivated.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.MultiServerService.SetActiveServers(System.Collections.Generic.IList{System.Guid})`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.MultiServerService.SetActiveServers(System.Collections.Generic.IList{System.Guid})`

#### Summary

Changes the active servers and/or their order.

#### Remarks

More than one server can be active at any given time in a multi-server service,
but it is possible that no server is active (unless the service is mandatory).

An application-wide active servers get executed when the service is invoked
in the scope of the entire application (i.e. without a specific document),
or if the service is executed in a document but the document does not have
active servers explicitly set.

For a service which has cref="Autodesk::Revit::DB::ExternalService::SupportActivation" set to true
setting active servers replaces previously active servers. Both the number
of servers and their orders is significant. Servers do always get executed
in the order in which they were set as active. If it is desired the order
of execution is different, the same set of active servers must be set again,
but in the modified, desired order.

For a service which has cref="Autodesk::Revit::DB::ExternalService::SupportActivation" set to false
calling this method will throw exception.

#### Parameter `serverIds`

A set of Ids of servers that are to be set as active for this service
or an empty set if no server should currently be set as active.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Some of the given Ids do not represent valid servers of the service.
-or-
The list of servers contains duplicates. The SetActiveServers method expects a set of unique servers.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The operation is not allowed because the service is being executed.
-or-
For a service that doesn't support activation, the servers can't be activated/deactivated.

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.MultiServerService.GetActiveServerIds(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.MultiServerService.GetActiveServerIds(Autodesk.Revit.DB.Document)`

#### Summary

Returns Ids of the servers currently applicable to the given document for the service.

#### Remarks

The Ids would be of all the servers explicitly assigned to the specified document.

#### Parameter `document`

The associated document.

#### Returns

A set of GUIDs of the document-applicable active servers; the list may be empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ExternalService.MultiServerService.GetActiveServerIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.ExternalService.MultiServerService.GetActiveServerIds`

#### Summary

Returns Ids of the currently active application-level servers registered for the service.

#### Remarks

More than one application-level server can be active at a given time in a multi-server service,
but it is possible that no server is active (unless the service is mandatory).

#### Returns

A set of GUIDs of the application-wide active servers; the list may be empty.

#### Since

2013

### `P:Autodesk.Revit.DB.ExternalService.MultiServerService.ExecutionPolicy`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExternalService.MultiServerService.ExecutionPolicy`

#### Summary

Specifies how a multi-server service executes servers during its execution.

#### Remarks

Read descriptions for the items in the ExecutionPolicy enum
to find out details about all applicable execution policies.

#### Since

2013

### `T:Autodesk.Revit.DB.ExternalService.MultiServerService`

Member kind: type
Symbol: `Autodesk.Revit.DB.ExternalService.MultiServerService`

#### Summary

This class represents a multi-server service inside Revit application.
It is created when an instance of IMultiServerService is registered with Revit.

#### Since

2013

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationType.IsAllowedDimensionStyle(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationType.IsAllowedDimensionStyle(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the dimension style can be used with multi-reference annotations.

#### Remarks

Only linear dimension styles are allowed.

#### Parameter `dimensionStyleId`

The dimension style to check.

#### Returns

True if the dimension style can be used by multi-reference annotations.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationType.IsAllowedReferenceCategory(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationType.IsAllowedReferenceCategory(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the reference category can be used with multi-reference annotations.

#### Remarks

Only Structural Rebar is allowed.

#### Parameter `referenceCategoryId`

The reference category to check.

#### Returns

True when the reference category can be used by multi-reference annotations.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationType.IsAllowedTagCategory(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationType.IsAllowedTagCategory(Autodesk.Revit.DB.ElementId)`

#### Summary

Returns true if tag types belonging to this category can be used with multi-reference annotation types.

#### Remarks

Only Structural Rebar Tags are allowed.

#### Parameter `tagCategoryId`

The tag category to test.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationType.IsAllowedTagType(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationType.IsAllowedTagType(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the tag type can be assigned to this multi-reference annotation type.

#### Remarks

Only tag types which exclusively tag elements from the multi-reference annotation's reference category can be used.

#### Parameter `tagTypeId`

The tag type to test.

#### Returns

True if the tag type exclusively tags elements from the multi-reference annotation's reference category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationType.GetAllowedTagCategory`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationType.GetAllowedTagCategory`

#### Summary

Returns the category ID for the tag types which can be used by this multi-reference annotation type.

#### Remarks

The allowed tag category is determined by the reference category of this multi-reference annotation type.

#### Returns

The allowed tag category ID.

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationType.CreateDefault(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationType.CreateDefault(Autodesk.Revit.DB.Document)`

#### Summary

Creates the first MultiReferenceAnnotationType element and adds it to the document.

#### Remarks

If there is no existing MultiReferenceAnnotationType a new one will be created, otherwise an exception will be thrown.
Use `M:Autodesk.Revit.DB.ElementType.Duplicate(System.String)` to create all further MultiReferenceAnnotationTypes.
The default MultiReferenceAnnotationType will use the document's current default
linear dimension style and will have Structural Rebar as its reference category.
No tag type will be set for the new MultiReferenceAnnotationType.

#### Parameter `document`

The document to be modified.

#### Returns

The new MultiReferenceAnnotationType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
There are existing MultiReferenceAnnotationTypes in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotationType.DimensionStyleId`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationType.DimensionStyleId`

#### Summary

The dimension style which will be used by the child dimension of the multi-reference annotation.

#### Value

Only linear dimension styles can be used.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The dimension style is not allowed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotationType.ShowDimensionText`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationType.ShowDimensionText`

#### Summary

Controls if text from the multi-reference annotation's dimension will be shown.

#### Value

When false, all dimension text including segment values will be hidden.
When true, all dimension text will be shown.

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotationType.GroupTagHeads`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationType.GroupTagHeads`

#### Summary

Controls if parameter values for the annotation's references will be reported in one grouped tag head
or if every reference will get its own tag head.

#### Value

When false, each reference will get one tag head.
When true, if all references report the same parameter values, a single tag head will be created.

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotationType.TagTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationType.TagTypeId`

#### Summary

The tag type which will be used by the child tag the multi-reference annotation.

#### Value

The tag type must be able to tag elements belonging to the multi-reference annotation's reference category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The tag type is not allowed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotationType.ReferenceCategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationType.ReferenceCategoryId`

#### Summary

The category of elements to which this annotation applies.

#### Remarks

The TagTypeId will be cleared because the user must set a new tag type of an appropriate category.

#### Since

2014

### `T:Autodesk.Revit.DB.MultiReferenceAnnotationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationType`

#### Summary

The type for MultiReferenceAnnotation.

#### Remarks

Multi-reference annotations can be used to label and dimension Rebar elements, and are labeled in the user interface as "Multi-rebar annotations".
The type specifies the tag and dimension types to be used in the multi-reference annotation, as well as associated display settings.

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.ElementsMatchReferenceCategory(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.ElementsMatchReferenceCategory(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Verifies that all of the elements match the reference category required
by the MultiReferenceAnnotationType.

#### Parameter `elements`

The elements to test.

#### Returns

True if all the elements match the reference category required by the MultiReferenceAnnotationType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.SetElementsToDimension(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.SetElementsToDimension(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets the elements which the dimension will witness.

#### Remarks

The dimension will automatically find geometric references in the elements.

#### Parameter `elementsToDimension`

The elements which the dimension will witness.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

some elements do not match the reference category required by the MultiReferenceAnnotationType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The MultiReferenceAnnotationType assigned to the options can't create MultiReferenceAnnotations by element.

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.GetElementsToDimension`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.GetElementsToDimension`

#### Summary

Gets the elements which the dimension will witness.

#### Returns

The elements which the dimension will witness.

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.ReferencesDontMatchReferenceCategory(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.ReferencesDontMatchReferenceCategory(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

#### Summary

Verifies that all of the references belongs to elements which doesn't match the
reference category required by the MultiReferenceAnnotationType.

#### Parameter `references`

The references to test.

#### Returns

Returns true if the element categories of all tested references do not match the element category required by the MultiReferenceAnnotationType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.SetAdditionalReferencesToDimension(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.SetAdditionalReferencesToDimension(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

#### Summary

Sets the additional references which the dimension will witness.

#### Remarks

The additional references to dimension cannot come from the same category as the MultiReferenceAnnotationType's reference category.

#### Parameter `referencesToDimension`

The additional references which the dimension will witness.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Some references come from elements which directly match the reference category required by the MultiReferenceAnnotationType. For
those elements please use SetElementsToDimension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.GetAdditionalReferencesToDimension`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.GetAdditionalReferencesToDimension`

#### Summary

Gets the additional references which the dimension will witness.

#### Remarks

These references may be to elements of other categories than the reference category returned by MultiReferenceAnnotationType.

#### Returns

The additional references which the dimension will witness.

#### Since

2020

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.IsAllowedDimensionStyleType(Autodesk.Revit.DB.DimensionStyleType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.IsAllowedDimensionStyleType(Autodesk.Revit.DB.DimensionStyleType)`

#### Summary

Only Linear and LinearFixed dimension style types are allowed for new MultiReferenceAnnotations.

#### Parameter `dimensionStyleType`

The dimension style type to test.

#### Returns

True if the type is allowed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.TagHasLeader`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.TagHasLeader`

#### Summary

When true the tag will be created with an attached leader.
When false the tag will be created without a leader.

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.TagHeadPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.TagHeadPosition`

#### Summary

The position for the tag's head.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.DimensionStyleType`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.DimensionStyleType`

#### Summary

The dimension style type to be used by the new MultiReferenceAnnotation.

#### Remarks

Only Linear and LinearFixed types are allowed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: dimensionStyleType must be either Linear or LinearFixed to be used by MultiReferenceAnnotations.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.DimensionLineOrigin`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.DimensionLineOrigin`

#### Summary

The origin point for the dimension line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.DimensionLineDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.DimensionLineDirection`

#### Summary

The direction vector of the dimension line.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: dimensionLineDirection is not length 1.0.

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.DimensionPlaneNormal`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.DimensionPlaneNormal`

#### Summary

The normal vector to the dimension plane.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: dimensionPlaneNormal is not length 1.0.

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.MultiReferenceAnnotationType`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.MultiReferenceAnnotationType`

#### Summary

The MultiReferenceAnnotationType to be used by the new MultiReferenceAnnotation.

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotationOptions.#ctor(Autodesk.Revit.DB.MultiReferenceAnnotationType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions.#ctor(Autodesk.Revit.DB.MultiReferenceAnnotationType)`

#### Summary

Create an instance of Multi-Reference Annotation Options set with default values.

#### Parameter `multiReferenceAnnotationType`

The MultiReferenceAnnotationType to be used by the new MultiReferenceAnnotation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.MultiReferenceAnnotationOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotationOptions`

#### Summary

Options which control the creation of MultiReferenceAnnotations.

#### Remarks

MultiReferenceAnnotationOptions include the specification of the associated elements and options for the dimension and tag placement.

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotation.Is3DViewValidForDimension(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotation.Is3DViewValidForDimension(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions)`

#### Summary

If the DimensionStyle is LinearFixed, it cannot be created in a 3D View.
If the DimensionStyle is Linear, it cannot be created in a 3D View if the view direction is perpendicular to the current work plane normal.
Returns true if the ownerViewId is not a 3D view.

#### Parameter `document`

The document for the multi-reference annotation.

#### Parameter `ownerViewId`

The view in which the multi-reference annotation will appear.

#### Parameter `options`

Options containing the references which the dimension will witness.

#### Returns

True if the view is suitable for placing the MultiReferenceAnnotation.
False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.MultiReferenceAnnotation.AreReferencesValidForLinearFixedDimension(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotation.AreReferencesValidForLinearFixedDimension(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions)`

#### Summary

If the DimensionStyleType is LinearFixed, validates that the references are valid
for an aligned multi-reference annotation.

#### Parameter `document`

The document for the multi-reference annotation.

#### Parameter `ownerViewId`

The view in which the multi-reference annotation will appear.

#### Parameter `options`

Options containing the references which the dimension will witness.

#### Returns

True DimensionStyleType does not equal LinearFixed or
if an aligned multi-reference annotation can be created from the references.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotation.AreReferencesValidForLinearDimension(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotation.AreReferencesValidForLinearDimension(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions)`

#### Summary

If the DimensionStyleType is Linear, validates that the references are valid
for an aligned multi-reference annotation.

#### Parameter `document`

The document for the multi-reference annotation.

#### Parameter `ownerViewId`

The view in which the multi-reference annotation will appear.

#### Parameter `options`

Options containing the references which the dimension will witness.

#### Returns

True DimensionStyleType does not equal Linear or
if an aligned multi-reference annotation can be created from the references.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotation.AreElementsValidForMultiReferenceAnnotation(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.MultiReferenceAnnotationOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotation.AreElementsValidForMultiReferenceAnnotation(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.MultiReferenceAnnotationOptions)`

#### Summary

The method validates if the input elements match the element category id for the MultiReferenceAnnotationType.

#### Parameter `document`

The document for the multi-reference annotation.

#### Parameter `options`

The creation options for the new MultiReferenceAnnotation.

#### Returns

Returns true if the input elements match the element category id for the MultiReferenceAnnotationType,
false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.MultiReferenceAnnotation.IsLinearFixedDimensionDirectionValid(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotation.IsLinearFixedDimensionDirectionValid(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions)`

#### Summary

If the DimensionStyleType is LinearFixed, this function verifies that the dimension line direction
matches either the view's vertical or horizontal direction.

#### Parameter `document`

The document for the view.

#### Parameter `viewId`

The view in which the dimension line direction will be tested.

#### Parameter `options`

Options containing the DimensionStyleType and dimension line direction to test.

#### Returns

True if the DimensionStyleType is LinearFixed and the dimension line direction can be used in the view.
True if the DimensionStyleType is not LinearFixed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.MultiReferenceAnnotation.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotation.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions)`

#### Summary

Creates a new MultiReferenceAnnotation.

#### Remarks

New linear Dimension and IndependentTag elements will be created as children of the MultiReferenceAnnotation.
The IndependentTag will only be created if the MultiReferenceAnnotationType property TagTypeId is valid.

#### Parameter `document`

The document to which the new MultiReferenceAnnotation will be added.

#### Parameter `ownerViewId`

The view in which the multi-reference annotation will appear.

#### Parameter `options`

The creation options for the new MultiReferenceAnnotation.

#### Returns

The new MultiReferenceAnnotation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The ElementId ownerViewId does not correspond to a View.
-or-
The ElementId ownerViewId is a view template.
-or-
The ElementId ownerViewId is a perspective view.
-or-
The 3D view ownerViewId is not locked.
-or-
The input 3D view cannot be used to place a MultiReferenceAnnotation object.
-or-
dimension line direction and dimension plane normal are not orthogonal.
-or-
There is at least one element that doesn't match the reference category of the MultiReferenceAnnotationType, or there are no elements.
-or-
for DimensionStyleType LinearFixed dimensions the dimension line direction must be parallel to either the view's vertical or horizontal direction.
-or-
some references can't be used with a DimensionStyleType Linear dimension of this direction.
References must either appear as points in the view or be linear references which are
perpendicular to the dimension line.
-or-
some references can't be used with a DimensionStyleType LinearFixed dimension.
Only references which appear as points in the view can be used.

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

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotation.TagId`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotation.TagId`

#### Summary

The child IndependentTag owned by this multi-reference annotation.

#### Since

2014

### `P:Autodesk.Revit.DB.MultiReferenceAnnotation.DimensionId`

Member kind: property
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotation.DimensionId`

#### Summary

The child dimension owned by this multi-reference annotation.

#### Since

2014

### `T:Autodesk.Revit.DB.MultiReferenceAnnotation`

Member kind: type
Symbol: `Autodesk.Revit.DB.MultiReferenceAnnotation`

#### Summary

Multi-reference annotations are annotations pointing to more than one reference, consisting of a dimension and associated tag.

#### Remarks

Multi-reference annotations can be used to label and dimension Rebar elements, and are labeled in the user interface as "Multi-rebar annotations".
MultiReferenceAnnotation is the annotation object instance. This class includes a reference to the associated dimension and tag element.

#### Since

2014

### `M:Autodesk.Revit.DB.ModelUtils.GetSingleUserModelCurrentSessionOwner(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelUtils.GetSingleUserModelCurrentSessionOwner(Autodesk.Revit.DB.ModelPath)`

#### Summary

Returns current session owner of the specified single-user model.

#### Parameter `modelPath`

Path to the single-user model.

#### Returns

Name of current session owner.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.ModelUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelUtils`

#### Summary

A static class that contains utility functions related to models.

### `P:Autodesk.Revit.DB.ModelPathUtils.CloudRegionEMEA`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelPathUtils.CloudRegionEMEA`

#### Summary

The name of cloud region EMEA.

#### Since

2021

### `P:Autodesk.Revit.DB.ModelPathUtils.CloudRegionUS`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelPathUtils.CloudRegionUS`

#### Summary

The name of cloud region US.

#### Since

2021

### `M:Autodesk.Revit.DB.ModelPathUtils.HashDocumentPathName(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPathUtils.HashDocumentPathName(Autodesk.Revit.DB.Document)`

#### Summary

Hash of document's path name by removing private information
Once hashed it can be used for logging. E.g send to analytics

#### Parameter `aDoc`

The document whose path name is to be hashed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ModelPathUtils.IsValidFileName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPathUtils.IsValidFileName(System.String)`

#### Summary

Checks that the file name does not contain
any invalid characters.

#### Parameter `fileName`

The file name to check.

#### Returns

True if the file name is valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ModelPathUtils.ConvertCloudGUIDsToCloudPath(System.String,System.Guid,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPathUtils.ConvertCloudGUIDsToCloudPath(System.String,System.Guid,System.Guid)`

#### Summary

Converts a pair of cloud project and model GUIDs to a valid cloud path.

#### Parameter `region`

The region of the BIM 360 Docs or Autodesk Docs account and project which contains this model.
Please see the reference values, like `P:Autodesk.Revit.DB.ModelPathUtils.CloudRegionUS` and `P:Autodesk.Revit.DB.ModelPathUtils.CloudRegionEMEA` ,
and the new regions from release note.

#### Parameter `projectGuid`

The GUID of the cloud project which contains the model.

#### Parameter `modelGuid`

The GUID of the Revit cloud model.

#### Returns

The cloud model path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.CentralModelException`

The cloud project is missing.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

The central server could not be reached.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

You must sign in to Autodesk 360 in order to complete action.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

You are unauthorized to access this resource.

#### Since

2021

### `M:Autodesk.Revit.DB.ModelPathUtils.ConvertModelPathToUserVisiblePath(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPathUtils.ConvertModelPathToUserVisiblePath(Autodesk.Revit.DB.ModelPath)`

#### Summary

Gets a string version of the path of a given ModelPath.

#### Parameter `path`

A ModelPath representing a file path or a server path.

#### Returns

The path in string form

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ModelPathUtils.ConvertUserVisiblePathToModelPath(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPathUtils.ConvertUserVisiblePathToModelPath(System.String)`

#### Summary

Converts a user-visible path (string) to a ModelPath.

#### Remarks

The path may be a server or file path.

#### Parameter `strPath`

The path in string form, like RSN://{HostNodeName}/school/project.rvt

#### Returns

A ModelPath representing either a server or file path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.ModelPathUtils.IsValidUserVisibleFullServerPath(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelPathUtils.IsValidUserVisibleFullServerPath(System.String)`

#### Summary

Determines whether the given string represents a valid
server path.

#### Remarks

ServerPaths must refer to Revit models.

ServerPaths are relative to the central server location, and
are of the form "RSN://{HostNodeName}/{model_path}".

The {model_path}
portion is a relative path to a Revit model. For example:

RSN://EXS/hospital.rvt

RSN://EXS.autodesk.com/Old Files/hotel2.rvt

RSN://EXS.autodesk.com/Old Files/Last Week/Tuesday\hotel2.rvt
are all valid server paths.
//EXS/Old Files/.rvt

EXS/hospital
are not valid server paths.
If this function returns false, it does not necessarily mean
the given path is a file path. It may be a malformed string.

#### Parameter `strPath`

The path, in string form

#### Returns

True if the given path is a valid server path, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.ModelPathUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelPathUtils`

#### Summary

Utility functions using ModelPaths

#### Since

2012

### `P:Autodesk.Revit.DB.Visual.Mirror.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Mirror.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "Mirror" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Mirror.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Mirror.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "Mirror" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Mirror.MirrorColorByObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Mirror.MirrorColorByObject`

#### Summary

The property labeled "Color By Object" from the "Mirror" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Mirror.MirrorTintcolor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Mirror.MirrorTintcolor`

#### Summary

The property labeled "Color" from the "Mirror" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Mirror`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Mirror`

#### Summary

A static class that provides access to the property names that appear in the Mirror visual asset schema.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintFinishPeelamount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintFinishPeelamount`

#### Summary

The property labeled "Amount" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintFinish`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintFinish`

#### Summary

The property labeled "Finish" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "MetallicpaintFinishType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintTopcoatFalloff`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintTopcoatFalloff`

#### Summary

The property labeled "Angle Falloff" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintTopcoatGlossy`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintTopcoatGlossy`

#### Summary

The property labeled "Glossiness" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintTopcoat`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintTopcoat`

#### Summary

The property labeled "Top Coat" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "MetallicpaintTopcoatType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintPearlIor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintPearlIor`

#### Summary

The property labeled "Blend" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintPearlColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintPearlColor`

#### Summary

The property labeled "Color" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintPearlColorByObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintPearlColorByObject`

#### Summary

The property labeled "Color By Object" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintPearlAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintPearlAmount`

#### Summary

The property labeled "Amount" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintPearl`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintPearl`

#### Summary

The property labeled "Pearl" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "MetallicpaintPearlType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintFlecksSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintFlecksSize`

#### Summary

The property labeled "Size" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintFlecksColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintFlecksColor`

#### Summary

The property labeled "Color" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintFlecksColorByObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintFlecksColorByObject`

#### Summary

The property labeled "Color By Object" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintFlecks`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintFlecks`

#### Summary

The property labeled "Flecks" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "MetallicpaintFlecksType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintBaseHighlightspread`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintBaseHighlightspread`

#### Summary

The property labeled "Highlight Spread" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintBaseColorByObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintBaseColorByObject`

#### Summary

The property labeled "Color By Object" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintBaseColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint.MetallicpaintBaseColor`

#### Summary

The property labeled "Color" from the "MetallicPaint" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.MetallicPaint`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.MetallicPaint`

#### Summary

A static class that provides access to the property names that appear in the MetallicPaint visual asset schema.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.MetalPerforationsCenter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.MetalPerforationsCenter`

#### Summary

The property labeled "Center Spacing" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyDouble" with a minimum of "0.0001".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.MetalPerforationsSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.MetalPerforationsSize`

#### Summary

The property labeled "Diameter/Size" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyDouble" with a minimum of "0.0001".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.MetalPerforationsShader`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.MetalPerforationsShader`

#### Summary

The property labeled "Image" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.MetalPerforations`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.MetalPerforations`

#### Summary

The property labeled "Cutouts" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "MetalPerforationsType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.MetalPatternScale`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.MetalPatternScale`

#### Summary

The property labeled "Scale" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyDouble" with a minimum of "0".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.MetalPatternHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.MetalPatternHeight`

#### Summary

The property labeled "Amount" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 2".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.MetalPatternShader`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.MetalPatternShader`

#### Summary

The property labeled "Image" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.MetalPattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.MetalPattern`

#### Summary

The property labeled "Relief Pattern" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "MetalPatternType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.MetalFinish`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.MetalFinish`

#### Summary

The property labeled "Finish" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "MetalFinishType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.MetalPatina`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.MetalPatina`

#### Summary

The property labeled "Patina" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.MetalColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.MetalColor`

#### Summary

The property labeled "Color" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Metal.MetalType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Metal.MetalType`

#### Summary

The property labeled "Type" from the "Metal" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "MetalType".

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Metal`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Metal`

#### Summary

A static class that provides access to the property names that appear in the Metal visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Structure.MemberForcesServiceData.GetCurrentElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.MemberForcesServiceData.GetCurrentElements`

#### Summary

Returns the list of Ids of the current elements.

#### Returns

Ids of the current elements. Contains the family base element to which the Member Forces parameters belongs.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.MemberForcesServiceData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.MemberForcesServiceData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.MemberForcesServiceData.Document`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.MemberForcesServiceData.Document`

#### Summary

The current document.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.MemberForcesServiceData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.MemberForcesServiceData`

#### Summary

The data needed by member forces server to perform type definition.

#### Since

2016

### `M:Autodesk.Revit.DB.Mechanical.MechanicalUtils.BreakCurve(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalUtils.BreakCurve(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

#### Summary

Breaks the duct curve into two parts at the given position.

#### Remarks

This method is not applicable for breaking the flex duct.

#### Parameter `document`

The document.

#### Parameter `ductId`

The element id of the duct curve to break.

#### Parameter `ptBreak`

The break point on the duct curve.

#### Returns

The new duct curve element id if successful otherwise if a failure occurred an invalidElementId is returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

"The element is neither a duct nor a duct placeholder."
-or-
"The given point is not on the duct curve."

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectAirTerminalOnDuct(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectAirTerminalOnDuct(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Connects an air terminal to a duct directly (without the need for a tee or takeoff).

#### Remarks

The current location of the air terminal will be projected to the duct centerline, and if the point can be successfully projected,
the air terminal will be placed on the most suitable face of the duct.

#### Parameter `document`

The document.

#### Parameter `airTerminalId`

The air terminal id.

#### Parameter `ductCurveId`

The duct curve id.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The familyinstance is not air terminal.
-or-
The element is not duct curve.
-or-
The air terminal already has physical connection.
-or-
The air terminal connector origin doesn't project within the center line of the duct.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtCross(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtCross(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Connects a group of placeholders that can intersect in a Cross connection.

#### Remarks

The placeholders may or may not have physical connection. However:
The ends of four connectors should intersect at same point.

The first and second placeholders should be collinear each other.

The third and fourth placeholders should be collinear each other.

The third and fourth should have intersection with first or second placeholder.
If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `connector1`

The end connector of the first placeholder.

#### Parameter `connector2`

The end connector of the second placeholder.

#### Parameter `connector3`

The end connector of the third placeholder.

#### Parameter `connector4`

The end connector of the fourth placeholder.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The owner of connector is not duct placeholder.
-or-
The owners of connectors belong to different types of system.
-or-
The curves of connector1 and connector2 are not collinear or either the connecto1 or connector2 is not connector of curve end.
-or-
The curves of connector3 and connector4 are not collinear or either the connecto1 or connector2 is not connector of curve end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtCross(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtCross(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Connects a trio of placeholders that can intersect in a Cross connection.

#### Remarks

If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `placeholder1Id`

The element id of the first duct placeholder.

#### Parameter `placeholder2Id`

The element id of the second duct placeholder.

#### Parameter `placeholder3Id`

The element id of third duct placeholder.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id placeholder1Id is not duct placeholder.
-or-
The element id placeholder2Id is not duct placeholder.
-or-
The element id placeholder3Id is not duct placeholder.
-or-
The elements belong to different types of system.
-or-
The curve placeholder2Id does not connect on the curve placeholder1Id or vice versa.
-or-
The curve placeholder3Id does not connect on the curve placeholder1Id or vice versa.
-or-
The curve placeholder2Id and placeholder3Id are not collinear.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtCross(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtCross(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Connects a pair of placeholders that can intersect in a Cross connection.

#### Remarks

The placeholders must intersect each other. If connection succeeds, a new
placeholder duct is created. If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `placeholder1Id`

The element id of the first duct placeholder.

#### Parameter `placeholder2Id`

The element id of the second duct placeholder.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id placeholder1Id is not duct placeholder.
-or-
The element id placeholder2Id is not duct placeholder.
-or-
The elements belong to different types of system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtTee(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtTee(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Connects a trio of placeholders that can intersect in a Tee connection.

#### Remarks

The three placeholders may or may not have physical connections. However,
the first connector should be collinear with the second connector, and the third connector must have
be able to be extended to have an intersection with first and second.

If first placeholder and second placeholder have the same size, the second one
is merged with first one and original placeholder element will become invalid.
If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `connector1`

The end connector of the first placeholder.

#### Parameter `connector2`

The end connector of second placeholder.

#### Parameter `connector3`

The end connector of the third placeholder.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The owner of connector is not duct placeholder.
-or-
The owners of connectors belong to different types of system.
-or-
The curves of connector1 and connector2 are not collinear or either the connecto1 or connector2 is not connector of curve end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtTee(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtTee(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Connects a pair of placeholders that can intersect in a Tee connection.

#### Remarks

The placeholders must have a physical intersection.
If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `placeholder1Id`

The element Id of the first duct placeholder.

#### Parameter `placeholder2Id`

The element Id of the second duct placeholder.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id placeholder1Id is not duct placeholder.
-or-
The element id placeholder2Id is not duct placeholder.
-or-
The elements belong to different types of system.
-or-
The curve placeholder2Id does not connect on the curve placeholder1Id or vice versa.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtElbow(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtElbow(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Connects a pair of placeholders that can intersect in an Elbow connection.

#### Remarks

The placeholders may have a physical intersection but this is not required.
If they are not intersecting the connectors must be coplanar and able to be moved to
intersect each other.
If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `connector1`

The end connector of the first placeholder.

#### Parameter `connector2`

The end connector of the second placeholder.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The owner of connector is not duct placeholder.
-or-
The owners of connectors belong to different types of system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtElbow(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConnectDuctPlaceholdersAtElbow(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Connects a pair of placeholders that can intersect in an Elbow connection.

#### Remarks

The placeholders must meet at a physical end connection.
If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `placeholder1Id`

The element id of the first duct placeholder.

#### Parameter `placeholder2Id`

The element id of the second duct placeholder.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id placeholder1Id is not duct placeholder.
-or-
The element id placeholder2Id is not duct placeholder.
-or-
The elements belong to different types of system.
-or-
The curve placeholder1Id and placeholder2Id are not physically connected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConvertDuctPlaceholders(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalUtils.ConvertDuctPlaceholders(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Converts a collection of duct placeholder elements into duct elements.

#### Remarks

Once conversion succeeds, the duct placeholder elements are deleted.
The new duct and fitting elements are created and connections are established.

#### Parameter `document`

The document.

#### Parameter `placeholderIds`

A collection of element IDs of duct placeholders.

#### Returns

A collection of element IDs of ducts and fittings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element id set is empty.
-or-
The given element IDs (placeholderIds) are not duct placeholders.
-or-
The elements belong to different types of system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.Mechanical.MechanicalUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalUtils`

#### Summary

General utility methods in the Autodesk Revit MEP product.

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSetType.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSetType.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new type of a mechanical equipment set and adds it to the document.

#### Parameter `document`

The document where the new type is created.

#### Parameter `name`

The name of new type.

#### Returns

The newly created mechanical equipment set type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
name is an empty string.
-or-
The given name is not unique

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

2019

### `T:Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSetType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSetType`

#### Summary

Represents a type for a set of interrelated mechanical equipment in a MEP system that works together.

#### Since

2019

### `M:Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.Remove(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.Remove(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Removes member element ids from the mechanical equipment set.

#### Remarks

If all the members are removed, the instance of the mechanical equipment set is automatically deleted.

#### Parameter `elemIds`

Element ids to be removed from the mechanical equipment set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more element ids was not permitted to be removed from the mechanical equipment set.
All elements should be a member of the mechanical equipment set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.Add(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.Add(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Adds member element ids to the mechanical equipment set.

#### Parameter `elemIds`

Element ids to be added to the mechanical equipment set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The valid members must have the same classification and system. They cannot be a member of existing set.
-or-
These elements are serially connected with each other, or with one of the set members.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.GetMembers`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.GetMembers`

#### Summary

Gets member element ids for the mechanical equipment set.

#### Returns

Element ids for the members in the mechanical equipment set.

#### Since

2019

### `M:Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.AreValidMembers(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.AreValidMembers(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Checks if these are valid members for mechanical equipment set.

#### Parameter `document`

The document of the member elements.

#### Parameter `memberIds`

The member element ids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.AreElementsNotConnectedInSeries(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.AreElementsNotConnectedInSeries(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Checks if the elements are not serially connected.

#### Parameter `document`

The document of these elements.

#### Parameter `elemIds`

The element ids to be tested.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Creates a new instance of a mechanical equipment set and adds it to the document.

#### Parameter `document`

The document where the element will be created and added.

#### Parameter `typeId`

The type of new mechanical equipment set.

#### Parameter `memberIds`

The member elements of this mechanical equipment set.

#### Returns

The newly created mechanical equipment set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid mechanical equipment set type.
-or-
This mechanical equipment set needs at least two members.
-or-
The valid members must have the same classification and system. A valid member cannot be a member of any other existing set.
-or-
These elements are serially connected.

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

2019

### `P:Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.OnStandby`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.OnStandby`

#### Summary

The number of pieces of mechanical equipment that are not operational at any given time.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: There should be at least one equipment on duty.

#### Since

2019

### `P:Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.OnDuty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.OnDuty`

#### Summary

The number of pieces of mechanical equipment operating in parallel at any given time.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The number of on duty (number) must be less than or equal to the number of available equipments or there should be at least one equipment on duty.

#### Since

2019

### `P:Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.Classification`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet.Classification`

#### Summary

The classification for the mechanical equipment set.

#### Since

2019

### `T:Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet`

#### Summary

A set of interrelated mechanical equipment in a MEP system that works together.

#### Since

2019

### `M:Autodesk.Revit.DB.MathComparisonUtils.IsAlmostZero(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MathComparisonUtils.IsAlmostZero(System.Double)`

#### Summary

Checks if value is almost zero, using the internal tolerance.

#### Parameter `value`

The value to check.

#### Returns

True if value is almost zero, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for value is not finite

#### Since

2021

### `M:Autodesk.Revit.DB.MathComparisonUtils.IsLessThan(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MathComparisonUtils.IsLessThan(System.Double,System.Double)`

#### Summary

Checks if value1 is strictly less than value2, using the internal tolerance.

#### Parameter `value1`

The first value.

#### Parameter `value2`

The second value.

#### Returns

True if value1 is strictly less than value2, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for value1 is not finite
-or-
The given value for value2 is not finite

#### Since

2021

### `M:Autodesk.Revit.DB.MathComparisonUtils.IsLessThanOrAlmostEqual(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MathComparisonUtils.IsLessThanOrAlmostEqual(System.Double,System.Double)`

#### Summary

Checks if value1 is less than or almost equal to value2, using the internal tolerance.

#### Parameter `value1`

The first value.

#### Parameter `value2`

The second value.

#### Returns

True if value1 is less than or almost equal to value2, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for value1 is not finite
-or-
The given value for value2 is not finite

#### Since

2021

### `M:Autodesk.Revit.DB.MathComparisonUtils.IsGreaterThan(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MathComparisonUtils.IsGreaterThan(System.Double,System.Double)`

#### Summary

Checks if value1 is strictly greater than value2, using the internal tolerance.

#### Parameter `value1`

The first value.

#### Parameter `value2`

The second value.

#### Returns

True if value1 is strictly greater than value2, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for value1 is not finite
-or-
The given value for value2 is not finite

#### Since

2021

### `M:Autodesk.Revit.DB.MathComparisonUtils.IsGreaterThanOrAlmostEqual(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MathComparisonUtils.IsGreaterThanOrAlmostEqual(System.Double,System.Double)`

#### Summary

Checks if value1 is greater than or almost equal to value2, using the internal tolerance.

#### Parameter `value1`

The first value.

#### Parameter `value2`

The second value.

#### Returns

True if value1 is greater than or almost equal to value2, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for value1 is not finite
-or-
The given value for value2 is not finite

#### Since

2021

### `M:Autodesk.Revit.DB.MathComparisonUtils.IsAlmostEqual(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MathComparisonUtils.IsAlmostEqual(System.Double,System.Double)`

#### Summary

Checks if two doubles are almost equal, using the internal tolerance.

#### Parameter `value1`

The first value.

#### Parameter `value2`

The second value.

#### Returns

True if two doubles are almost equal, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for value1 is not finite
-or-
The given value for value2 is not finite

#### Since

2021

### `T:Autodesk.Revit.DB.MathComparisonUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.MathComparisonUtils`

#### Summary

This class contains a set of mathematical utilities to compare doubles, using the internal tolerance.

#### Since

2021

### `M:Autodesk.Revit.DB.Analysis.MassLevelData.IsValidConceptualConstructionTypeElement(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData.IsValidConceptualConstructionTypeElement(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the ElementId is an acceptable conceptual construction type ElementId for the MassLevelData (Mass Floor).

#### Remarks

In the case that 'conceptualConstructionIsByEnergyData' is true, invalidElementId is also acceptable input.

#### Parameter `id`

The ElementId to be checked.

#### Returns

True if the ElementId is an acceptable conceptual construction type ElementId, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.MassLevelData.IsMassFamilyInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData.IsMassFamilyInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the ElementId is a mass family instance.

#### Parameter `document`

The document.

#### Parameter `id`

The ElementId to be checked.

#### Returns

True if the ElementId is a mass family instance, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.MassLevelData.IsEmpty`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData.IsEmpty`

#### Summary

Indicates if the MassLevelData (Mass Floor) has a geometrical representation. May not
if the level does not intersect the mass geometry.

#### Returns

Returns True if MassLevelData is dimensionless, False otherwise.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassLevelData.ConceptualConstructionIsByEnergyData`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData.ConceptualConstructionIsByEnergyData`

#### Summary

Indicates if the ConceptualConstructionType of the MassLevelData (Mass Floor) is synchronized
with the EnergyDataSettings or if it overrides those settings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: ConceptualConstructionIsByEnergyData cannot be set to conceptualConstructionIsByEnergyData.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassLevelData.ConceptualConstructionId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData.ConceptualConstructionId`

#### Summary

The ElementId of the conceptual construction associated with the MassLevelData (Mass Floor).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input ElementId conceptualConstructionId is not a valid conceptual construction type ElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassLevelData.MaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData.MaterialId`

#### Summary

The ElementId of the visualization material used for the MassLevelData (Mass Floor)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input element materialId is not a material element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassLevelData.OwningMassId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData.OwningMassId`

#### Summary

The ElementId of the mass that the MassLevelData (Mass Floor) is associated with.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassLevelData.MaterialType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData.MaterialType`

#### Summary

Indicates if the material used for the graphical appearance is by category or a specific material, or
if the material to be used should be taken from the ConceptualConstructionType of the MassLevelData.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The material type does not fall within an appropriate range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassLevelData.NLevelPerimeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData.NLevelPerimeter`

#### Summary

The perimeter of the intersection of the MassLevelData's level with the mass geometry.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassLevelData.NLevelFafArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData.NLevelFafArea`

#### Summary

The surface area of the intersection of the MassLevelData's level with the mass geometry.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassLevelData.NExteriorSurfaceArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData.NExteriorSurfaceArea`

#### Summary

The exterior surface area of the volume of the mass between the level of this MassLevelData (Mass Floor) to the next in the mass.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassLevelData.NVolume`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData.NVolume`

#### Summary

The volume of from the level of this MassLevelData (Mass Floor) to the next in the mass.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassLevelData.StrUsage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData.StrUsage`

#### Summary

A String which describes the usage or occupancy type of the level of the MassLevelData.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.MassLevelData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.MassLevelData`

#### Summary

MassLevelData is a conceptual representation of an occupiable floor (Mass Floor) in a conceptual building model.
It is defined by associating a particular level with a particular mass element in a Revit project.

#### Remarks

MassLevelData reports metrics, such as floor areas, related to conceptual space planning.
MassLevelData contains information, such as ConceptualConstructionType, used as part of the
Conceptual Energy Analytical model.
The MassLevel data geometry is determined by combining all the geometry of a mass into a single geometry, and then
taking the area of intersection with the level of the MassLevelData.

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.MassSurfaceData.GetFaceReferences`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.GetFaceReferences`

#### Summary

Gets References to the faces that the MassSurfaceData provides properties for.

#### Remarks

The results are always references to Faces. The Reference Type should be REFERENCE_TYPE_SURFACE.
Currently Revit improperly reports it as REFERENCE_TYPE_NONE.

#### Returns

Returns an array of References to Faces that the MassSurfaceData provides properties for.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.ReferenceElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.ReferenceElementId`

#### Summary

The ElementId of the element whose face the MassSurfaceData primarily refers to.

#### Remarks

A MassSurfaceData may represent multiple faces from the same or different elements. This generally
only happens if the faces are geometrically fully coincident and logically represent
a single building object. "Interior walls" of the conceptual energy building model is a common
example where two different faces may be represented by a single MassSurfaceData.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.CategoryIdForConceptualSurfaceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.CategoryIdForConceptualSurfaceType`

#### Summary

Returns the mass subcategory ElementId used for ConceptualSurfaceType for this MassSurfaceData.

#### Remarks

This value is determined by starting with the subcategory property and adjusting it according to properties
such as "isSlab" or "isUnderground".

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.IsSlab`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.IsSlab`

#### Summary

Indicates if a floor is a slab.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.IsUnderground`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.IsUnderground`

#### Summary

Indicates if the roof, floor, slab, or wall surface reference is underground.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.IsGlazingShaded`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.IsGlazingShaded`

#### Summary

Indicates if shade geometry is auto-generated on the top edge of auto-generated glazing.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.IsConceptualConstructionByEnergyData`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.IsConceptualConstructionByEnergyData`

#### Summary

True when the ConceptualConstructionType id is synchronized to the EnergyDataSettings.
False when the ConceptualConstructionType id is overridden for this MassSurfaceData.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: ConceptualConstructionIsByEnergyData cannot be set to conceptualConstructionIsByEnergyData.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.MaterialType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.MaterialType`

#### Summary

material type of mass zone

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The material type does not fall within an appropriate range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.MaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.MaterialId`

#### Summary

The visualization material used for the surface for displaying the energy analytical model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input element materialId is not a material element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.MassLevelDataId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.MassLevelDataId`

#### Summary

The MassLevelData used when the surface is horizontal, planar, and at the same height as a MassLevelData
related to the same mass as the referenced face.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.ConceptualConstructionId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.ConceptualConstructionId`

#### Summary

The id of the conceptual construction associated with the reference surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input element conceptualConstructionId is not a valid ConceptualConstructionType element id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.SurfaceDataSource`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.SurfaceDataSource`

#### Summary

Indicates whether the MassSurfaceData properties are driven by the EnergyDataSettings
of the Document or are overridden for the surface.

#### Remarks

The Construction property is not governed by this setting and
has a separate value to indicate if it is to be synchronized
with EnergyDataSettings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The surface data source does not fall within an appropriate range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.SkylightWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.SkylightWidth`

#### Summary

The length dimension to be used for the sides of each individual square skylight
produced in the grid of auto-generated skylights.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The skylight width is less than eight inches.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.PercentageSkylights`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.PercentageSkylights`

#### Summary

The target percentage of the reference roof surface that is to
be covered with automatically generated skylights. Revit will use this number when
determining the size, shape, and location of automatically generated skylights.

#### Remarks

The resulting coverage of the roof with skylights is not guaranteed to
match this value. It is a target.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The percentage skylights value is between 0.00 and 0.95.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.SillHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.SillHeight`

#### Summary

The height above the level where the bottoms of auto-generated windows will be located.

#### Remarks

Will be accurate unless the target glazing percentage cannot be achieved using this height.
In that case, the sillHeight will be ignored and windows will be created below this height.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The sill height is less than zero.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.ShadeDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.ShadeDepth`

#### Summary

How far any auto-generated shades should extend from the wall surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The shade depth is less than zero.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.PercentageGlazing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.PercentageGlazing`

#### Summary

The target percentage of the reference wall surface that is to
be covered with automatically generated windows. Revit will use this number when
determining the size, shape, and location of automatically generated windows.

#### Remarks

The resulting coverage of the wall with windows is not guaranteed to
match this value. It is a target.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The percentage glazing value is not between 0.00 and 0.95.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.MassSurfaceData.Area`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData.Area`

#### Summary

Area of the references that the MassSurfaceData provides properties for.

#### Remarks

If it is used, should be greater than zero. Otherwise, it will be zero.

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.MassSurfaceData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceData`

#### Summary

Holds properties and other data about a face in the MassEnergyAnalyticalModel element.

#### Remarks

Properties stored in the MassSurfaceData can be used in regeneration by the MassEnergyAnalyticalModel.
For example, faces of the MassEnergyAnalyticalModel take their material values from the settings
in the MassSurfaceData.

#### Since

2012

### `T:Autodesk.Revit.DB.Analysis.MassSurfaceDataMaterialType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceDataMaterialType`

#### Summary

Indicates how the visualization material for the MassSurfaceData is calculated.

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.MassSurfaceDataMaterialType.NormalMaterial`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceDataMaterialType.NormalMaterial`

#### Summary

The visualization material for the MassSurfaceData will be taken from the material
associated with the object style of the subcategory of the MassSurfaceData if the
materialId is InvalidElementId, or the MassSurfaceData will use the specific material
indicated by the materialId property if its value is an ElementId of a MaterialElement.

### `F:Autodesk.Revit.DB.Analysis.MassSurfaceDataMaterialType.MaterialByConstruction`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceDataMaterialType.MaterialByConstruction`

#### Summary

The visualization material for the MassSurfaceData will be taken from the
material assigned to the ConceptualConstructionType which is assigned to the
MassSurfaceData.

### `T:Autodesk.Revit.DB.Analysis.MassSurfaceDataSource`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceDataSource`

#### Summary

Indicates whether values for the properties of the MassSurfaceData
are synchronized with the EnergyDataSettings of the
document or instead, serve as overrides of those settings.

#### Since

2012

### `F:Autodesk.Revit.DB.Analysis.MassSurfaceDataSource.Surface`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceDataSource.Surface`

#### Summary

Override the EnergyDataSettings values for the surface.

### `F:Autodesk.Revit.DB.Analysis.MassSurfaceDataSource.EnergyData`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceDataSource.EnergyData`

#### Summary

Synchronize with the EnergyDataSettings.

### `F:Autodesk.Revit.DB.Analysis.MassSurfaceDataSource.Invalid`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.MassSurfaceDataSource.Invalid`

#### Summary

This value indicates that the parameter has not been properly set.

### `M:Autodesk.Revit.DB.MassInstanceUtils.GetJoinedElementIds(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MassInstanceUtils.GetJoinedElementIds(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Get the ElementIds of Elements that are joined to a mass instance.

#### Parameter `document`

The Document.

#### Parameter `massInstanceId`

The ElementId of the mass instance.

#### Returns

ElementIds of Elements joined to the mass instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId massInstanceId is not a mass instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.MassInstanceUtils.GetGrossVolume(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MassInstanceUtils.GetGrossVolume(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Get the total building volume represented by a mass instance.

#### Parameter `document`

The Document.

#### Parameter `massInstanceId`

The ElementId of the mass instance.

#### Returns

The gross volume in cubic feet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId massInstanceId is not a mass instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.MassInstanceUtils.GetGrossSurfaceArea(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MassInstanceUtils.GetGrossSurfaceArea(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Get the total exterior building surface area represented by a mass instance.

#### Parameter `document`

The Document.

#### Parameter `massInstanceId`

The ElementId of the mass instance.

#### Returns

The gross surface area in square feet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId massInstanceId is not a mass instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.MassInstanceUtils.GetGrossFloorArea(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MassInstanceUtils.GetGrossFloorArea(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Get the total occupiable floor area represented by a mass instance.

#### Remarks

The area is computed from the cross sections that are created by intersecting the
associated Levels with the mass instance Geometry.

#### Parameter `document`

The Document.

#### Parameter `massInstanceId`

The ElementId of the mass instance.

#### Returns

The gross floor area in square feet.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId massInstanceId is not a mass instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.MassInstanceUtils.GetMassLevelIds(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MassInstanceUtils.GetMassLevelIds(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Get the ElementIds of the Levels associated with a mass instance.

#### Parameter `document`

The Document.

#### Parameter `massInstanceId`

The ElementId of the mass instance.

#### Returns

The ElementIds of the Levels

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId massInstanceId is not a mass instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.MassInstanceUtils.GetMassLevelDataIds(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MassInstanceUtils.GetMassLevelDataIds(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Get the ElementIds of the MassLevelDatas (Mass Floors) associated with a mass instance.

#### Parameter `document`

The Document.

#### Parameter `massInstanceId`

The ElementId of the mass instance.

#### Returns

The ElementIds of the MassLevelDatas.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId massInstanceId is not a mass instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.MassInstanceUtils.RemoveMassLevelDataFromMassInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MassInstanceUtils.RemoveMassLevelDataFromMassInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Delete the MassLevelData (Mass Floor) that associates a Level with a mass instance.

#### Remarks

Alternatively, you could just delete the MassLevelData.

#### Parameter `document`

The Document.

#### Parameter `massInstanceId`

The ElementId of the mass instance.

#### Parameter `levelId`

The ElementId of the Level to disassociate from the mass instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId massInstanceId is not a mass instance.
-or-
The ElementId levelId is not a Level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.MassInstanceUtils.AddMassLevelDataToMassInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MassInstanceUtils.AddMassLevelDataToMassInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Create a MassLevelData (Mass Floor) to associate a Level with a mass instance.

#### Parameter `document`

The Document.

#### Parameter `massInstanceId`

The ElementId of the mass instance.

#### Parameter `levelId`

The ElementId of the Level to associate with the mass instance.

#### Returns

The ElementId of the MassLevelData that was created, or the existing ElementId if it was already in added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId massInstanceId is not a mass instance.
-or-
The ElementId levelId is not a Level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.MassInstanceUtils.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.MassInstanceUtils.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.MassInstanceUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.MassInstanceUtils`

#### Summary

A static class that contains methods for processing curves driven by points.

#### Since

2012

### `P:Autodesk.Revit.DB.Visual.MasonryCMU.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MasonryCMU.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "MasonryCMU" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MasonryCMU.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MasonryCMU.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "MasonryCMU" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUPatternHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUPatternHeight`

#### Summary

The property labeled "Amount" from the "MasonryCMU" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 2".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUPatternMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUPatternMap`

#### Summary

The property labeled "Image" from the "MasonryCMU" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUPattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUPattern`

#### Summary

The property labeled "Relief Pattern" from the "MasonryCMU" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "MasonryCMUPatternType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUApplication`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUApplication`

#### Summary

The property labeled "Finish" from the "MasonryCMU" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "MasonryCMUApplicationType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUColorByObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUColorByObject`

#### Summary

The property labeled "Color By Object" from the "MasonryCMU" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUColor`

#### Summary

The property labeled "Color" from the "MasonryCMU" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.MasonryCMU.MasonryCMUType`

#### Summary

The property labeled "Type" from the "MasonryCMU" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "MasonryCMUType".

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.MasonryCMU`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.MasonryCMU`

#### Summary

A static class that provides access to the property names that appear in the MasonryCMU visual asset schema.

#### Since

2018.1

### `T:Autodesk.Revit.DB.MarginType`

Member kind: type
Symbol: `Autodesk.Revit.DB.MarginType`

#### Summary

An enumerated type listing all Margin types of Print Setting.

### `F:Autodesk.Revit.DB.MarginType.UserDefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.MarginType.UserDefined`

#### Summary

The type of Margin is User Defined.

### `F:Autodesk.Revit.DB.MarginType.PrinterLimit`

Member kind: field
Symbol: `Autodesk.Revit.DB.MarginType.PrinterLimit`

#### Summary

The type of Margin is Printer Limit.

### `F:Autodesk.Revit.DB.MarginType.NoMargin`

Member kind: field
Symbol: `Autodesk.Revit.DB.MarginType.NoMargin`

#### Summary

The type of Margin is No Margin.

### `P:Autodesk.Revit.DB.Visual.Marble.TextureRealWorldOffsetZ`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Marble.TextureRealWorldOffsetZ`

#### Summary

The property labeled "Offset Z" from the "Marble" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Marble.TextureRealWorldOffsetY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Marble.TextureRealWorldOffsetY`

#### Summary

The property labeled "Offset Y" from the "Marble" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Marble.TextureRealWorldOffsetX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Marble.TextureRealWorldOffsetX`

#### Summary

The property labeled "Offset X" from the "Marble" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Marble.TextureLinkTextureTransforms`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Marble.TextureLinkTextureTransforms`

#### Summary

The property labeled "Link Transforms" from the "Marble" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Marble.TextureAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Marble.TextureAngle`

#### Summary

The property labeled "Angle" from the "Marble" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray3d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Marble.MarbleWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Marble.MarbleWidth`

#### Summary

The property labeled "Vein Width" from the "Marble" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Marble.MarbleSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Marble.MarbleSize`

#### Summary

The property labeled "Vein Spacing" from the "Marble" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 100".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Marble.MarbleColor2`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Marble.MarbleColor2`

#### Summary

The property labeled "Vein Color" from the "Marble" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Marble.MarbleColor1`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Marble.MarbleColor1`

#### Summary

The property labeled "Stone Color" from the "Marble" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Marble`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Marble`

#### Summary

A static class that provides access to the property names that appear in the Marble visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Mechanical.SystemZoneData.Create`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.SystemZoneData.Create`

#### Summary

Creates a new instance of a system-zone data domain class.

#### Returns

The newly created data domain instance.

#### Since

2020.1

### `P:Autodesk.Revit.DB.Mechanical.SystemZoneData.ZoneEquipmentId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.SystemZoneData.ZoneEquipmentId`

#### Summary

The id of the zone equipment related to the zone.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `T:Autodesk.Revit.DB.Mechanical.SystemZoneData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.SystemZoneData`

#### Summary

Represents the specific domain requirements for a system-zone used in MEP design.

#### Remarks

A system-zone is used to specify what parts of a building are served by specific equipment, air systems and water
loops without having to physically model them. A system-zone is represented as a GenericZone element with a domain
data of type SystemZoneData, which contains specific domain requirements for the purpose of analysis.

#### Since

2020.1

### `P:Autodesk.Revit.DB.Analysis.GenericZoneDomainData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.GenericZoneDomainData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Analysis.GenericZoneDomainData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.GenericZoneDomainData`

#### Summary

A base class for specific domain requirements for a generic zone.

#### Since

2020.1

### `M:Autodesk.Revit.DB.MEPSupportUtils.CreateDuctworkStiffener(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPSupportUtils.CreateDuctworkStiffener(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Create family based stiffener on the specified fabrication ductwork.

#### Parameter `document`

The document.

#### Parameter `familySymbolId`

The id of a stiffener FamilySymbol.

#### Parameter `hostId`

The id of the host ductwork.

#### Parameter `distanceFromHostEnd`

The distance from the host primary end to place the hosted instance. Units are in feet (ft).

#### Returns

The new stiffener family instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
familySymbolId is not a valid Element identifier.
-or-
hostId is not a valid Element identifier.
-or-
Invalid familySymbolId for stiffeners.
-or-
Host is not a straight ductwork.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The distance from host primary end is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The profiles of family symbol and host are mismatch.

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

Failed to create stiffener due to document regenerate error.

#### Since

2024

### `T:Autodesk.Revit.DB.MEPSupportUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.MEPSupportUtils`

#### Summary

General utility methods for the Autodesk Revit MEP Supporting components.

#### Since

2024

### `T:Autodesk.Revit.DB.ReferenceBaseOnHostType`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReferenceBaseOnHostType`

#### Summary

This enumeration is used to classify the Reference Base on Host type .

#### Since

2024

### `T:Autodesk.Revit.DB.FramingShapeClassification`

Member kind: type
Symbol: `Autodesk.Revit.DB.FramingShapeClassification`

#### Summary

This enumeration is used to classify MEP Ancillary Framing shape.

#### Since

2024

### `T:Autodesk.Revit.DB.StiffenerClassification`

Member kind: type
Symbol: `Autodesk.Revit.DB.StiffenerClassification`

#### Summary

This enumeration is used to classify the stiffener.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkIterator.GetAnalyticalModelData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator.GetAnalyticalModelData`

#### Summary

Gets the analytical model data at the current iteration step.

#### Returns

The retrieved model data.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkIterator.GetOtherAnalyticalNode`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator.GetOtherAnalyticalNode`

#### Summary

Gets the other analytical node at the current iteration step.

#### Returns

The retrieved analytical node, null if the current iteration step does not have additional analytical node.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkIterator.GetAnalyticalNode`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator.GetAnalyticalNode`

#### Summary

Gets the analytical node at the current iteration step.

#### Returns

The retrieved node.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkIterator.GetAnalyticalSegment`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator.GetAnalyticalSegment`

#### Summary

Gets the analytical segment at the current iteration step.

#### Returns

The retrieved segment, may be null for the first step.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkIterator.Next`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator.Next`

#### Summary

Moves this iterator to the next step of network iteration.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkIterator.End`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator.End`

#### Summary

Checks if the network iteration has completed.

#### Returns

True if all analytical segments and nodes have been visited, otherwise false.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkIterator.Start`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator.Start`

#### Summary

Gets the first step of network iteration.

#### Remarks

The first step may not contain any analytical segment, but the first analytical node.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkIterator.CurrentElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator.CurrentElementId`

#### Summary

The element id at the current iteration step.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkIterator.SystemClassification`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator.SystemClassification`

#### Summary

The optional MEP system classification where the iterations are restricted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkIterator.SystemId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator.SystemId`

#### Summary

The optional MEP system element id where the iterations are restricted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkIterator.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.MEPAnalyticalNode,Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.MEPAnalyticalNode,Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment)`

#### Summary

Creates an iterator to visit the connected segments on one side of the network.

#### Parameter `pADoc`

The document of the analytical network.

#### Parameter `startNode`

The starting analytical node. It must be one of two nodes of the starting segment.

#### Parameter `startSegment`

The starting analytical segment to specify the traversing direction from the starting node.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkIterator.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData,Autodesk.Revit.DB.ConnectorDomainType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData,Autodesk.Revit.DB.ConnectorDomainType)`

#### Summary

Creates an iterator by the analytical model data to visit all connected components in the network.

#### Parameter `pADoc`

The document of the analytical network.

#### Parameter `seed`

The analytical model data of the starting element.

#### Parameter `eDomain`

The domain of network that the iteration happens.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `T:Autodesk.Revit.DB.Analysis.MEPNetworkIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkIterator`

#### Summary

An iterator to traverse the MEP analytical network.

#### Remarks

The iterator will visit the entire MEP analytical network in the depth-first order. For evert next step,
one analytical node and one analytical segment are typically visited. Sometimes an extra node is
provided if the iteration reaches the end on one side and restarts at the previous intersect node.
Also note that the start step may not contain any segment.

#### Since

2024

### `M:Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings.GetMEPHiddenLineSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings.GetMEPHiddenLineSettings(Autodesk.Revit.DB.Document)`

#### Summary

Gets the MEP hidden line settings in the document.

#### Parameter `doc`

The document where the settings element is found.

#### Returns

The element which stores the MEP hidden line settings for the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings.DrawHiddenLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings.DrawHiddenLine`

#### Summary

Indicates if duct or piping is drawn with the line style and gaps specified for hidden lines.

#### Since

2022

### `P:Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings.LineStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings.LineStyle`

#### Summary

The line style that determines how the lines of a hidden segment display at the point where the segments cross.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The line style is invalid for hidden line display.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2022

### `P:Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings.SingleLineGap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings.SingleLineGap`

#### Summary

The gap for the single hidden lines where segments cross.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The gap size must be between 0" and 3/4".

#### Since

2022

### `P:Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings.OutsideGap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings.OutsideGap`

#### Summary

The gap for the lines that appear external to the crossing segments.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The gap size must be between 0" and 3/4".

#### Since

2022

### `P:Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings.InsideGap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings.InsideGap`

#### Summary

The gap for the lines that appear within a crossing segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The gap size must be between 0" and 3/4".

#### Since

2022

### `T:Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings`

#### Summary

Represents the settings contained in the document associated to the MEP hidden line display.

#### Since

2022

### `T:Autodesk.Revit.DB.Mechanical.ComponentClassification`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification`

#### Summary

An enumerated type lists all MEP component classification. This attribute describes the general purpose of the MEP part component, that is used for scheduling, tagging, filter, ODBC, and etc.
One component classification may include more than one part type.

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Sleeve`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Sleeve`

#### Summary

Sleeve (supports) component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Hanger`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Hanger`

#### Summary

Hanger (supports) component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Sensor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Sensor`

#### Summary

Sensor component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Valve`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Valve`

#### Summary

Valve component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Wye`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Wye`

#### Summary

Wye component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Flange`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Flange`

#### Summary

Flange component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Union`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Union`

#### Summary

Union component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Coupling`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Coupling`

#### Summary

Coupling component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Endcap`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Endcap`

#### Summary

Cap component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Cross`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Cross`

#### Summary

Cross component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Transition`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Transition`

#### Summary

Transition component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Tap`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Tap`

#### Summary

Cap component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Tee`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Tee`

#### Summary

Tee component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Elbow`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Elbow`

#### Summary

Elbow component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.FlexDuct`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.FlexDuct`

#### Summary

Flex duct curve component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.FlexPipe`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.FlexPipe`

#### Summary

Flex pipe curve component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Duct`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Duct`

#### Summary

Straight duct segment component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Pipe`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Pipe`

#### Summary

Straight pipe segment component classification

### `F:Autodesk.Revit.DB.Mechanical.ComponentClassification.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Mechanical.ComponentClassification.Undefined`

#### Summary

Undefined component classification

### `T:Autodesk.Revit.DB.PartType`

Member kind: type
Symbol: `Autodesk.Revit.DB.PartType`

#### Summary

An enumerated type listing all MEP family part types. A part type typically provides one unique set of type parameters that defines this part.

### `F:Autodesk.Revit.DB.PartType.PipeMechanicalCoupling`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.PipeMechanicalCoupling`

#### Summary

Pipe Mechanical Coupling part type

### `F:Autodesk.Revit.DB.PartType.TopRails`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.TopRails`

#### Summary

Top Rails part type

### `F:Autodesk.Revit.DB.PartType.Handrails`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Handrails`

#### Summary

Handrails part type

### `F:Autodesk.Revit.DB.PartType.Rails`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Rails`

#### Summary

Rails part type

### `F:Autodesk.Revit.DB.PartType.TerminationHardware`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.TerminationHardware`

#### Summary

Termination Hardware part type

### `F:Autodesk.Revit.DB.PartType.PanelBracketHardware`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.PanelBracketHardware`

#### Summary

Panel Bracket Hardware part type

### `F:Autodesk.Revit.DB.PartType.HandrailBracketHardware`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.HandrailBracketHardware`

#### Summary

Handrail Bracket Hardware part type

### `F:Autodesk.Revit.DB.PartType.EndCap`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.EndCap`

#### Summary

EndCap part type

### `F:Autodesk.Revit.DB.PartType.Sensor`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Sensor`

#### Summary

Sensor part type

### `F:Autodesk.Revit.DB.PartType.InlineSensor`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.InlineSensor`

#### Summary

Inline Sensor part type

### `F:Autodesk.Revit.DB.PartType.LadderCableTrayMultiPort`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.LadderCableTrayMultiPort`

#### Summary

Ladder CableTray MultiPort part type

### `F:Autodesk.Revit.DB.PartType.LadderCableTrayOffset`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.LadderCableTrayOffset`

#### Summary

Ladder CableTray Offset part type

### `F:Autodesk.Revit.DB.PartType.LadderCableTrayUnion`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.LadderCableTrayUnion`

#### Summary

Ladder CableTray Union part type

### `F:Autodesk.Revit.DB.PartType.LadderCableTrayTransition`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.LadderCableTrayTransition`

#### Summary

Ladder CableTray Transition part type

### `F:Autodesk.Revit.DB.PartType.LadderCableTrayTee`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.LadderCableTrayTee`

#### Summary

Ladder CableTray Tee part type

### `F:Autodesk.Revit.DB.PartType.LadderCableTrayCross`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.LadderCableTrayCross`

#### Summary

Ladder CableTray Cross part type

### `F:Autodesk.Revit.DB.PartType.LadderCableTrayVerticalElbow`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.LadderCableTrayVerticalElbow`

#### Summary

Ladder CableTray Vertical Elbow part type

### `F:Autodesk.Revit.DB.PartType.LadderCableTrayElbow`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.LadderCableTrayElbow`

#### Summary

Ladder CableTray Elbow part type

### `F:Autodesk.Revit.DB.PartType.ChannelCableTrayMultiPort`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.ChannelCableTrayMultiPort`

#### Summary

Channel CableTray MultiPort part type

### `F:Autodesk.Revit.DB.PartType.ChannelCableTrayOffset`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.ChannelCableTrayOffset`

#### Summary

Channel CableTray Offset part type

### `F:Autodesk.Revit.DB.PartType.ChannelCableTrayUnion`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.ChannelCableTrayUnion`

#### Summary

Channel CableTray Union part type

### `F:Autodesk.Revit.DB.PartType.ChannelCableTrayTransition`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.ChannelCableTrayTransition`

#### Summary

Channel CableTray Transition part type

### `F:Autodesk.Revit.DB.PartType.ChannelCableTrayTee`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.ChannelCableTrayTee`

#### Summary

Channel CableTray Tee part type

### `F:Autodesk.Revit.DB.PartType.ChannelCableTrayCross`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.ChannelCableTrayCross`

#### Summary

Channel CableTray Cross part type

### `F:Autodesk.Revit.DB.PartType.ChannelCableTrayVerticalElbow`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.ChannelCableTrayVerticalElbow`

#### Summary

Channel CableTray Vertical Elbow part type

### `F:Autodesk.Revit.DB.PartType.ChannelCableTrayElbow`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.ChannelCableTrayElbow`

#### Summary

Channel CableTray Elbow part type

### `F:Autodesk.Revit.DB.PartType.JunctionBoxElbow`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.JunctionBoxElbow`

#### Summary

JunctionBox elbow part type

### `F:Autodesk.Revit.DB.PartType.PipeFlange`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.PipeFlange`

#### Summary

Pipe flange part type

### `F:Autodesk.Revit.DB.PartType.JunctionBoxCross`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.JunctionBoxCross`

#### Summary

JunctionBox cross part type

### `F:Autodesk.Revit.DB.PartType.JunctionBoxTee`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.JunctionBoxTee`

#### Summary

JunctionBox tee part type

### `F:Autodesk.Revit.DB.PartType.ValveNormal`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.ValveNormal`

#### Summary

Valve normal part type

### `F:Autodesk.Revit.DB.PartType.MultiPort`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.MultiPort`

#### Summary

Multi port part type

### `F:Autodesk.Revit.DB.PartType.Pants`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Pants`

#### Summary

Pants part type

### `F:Autodesk.Revit.DB.PartType.LateralCross`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.LateralCross`

#### Summary

Lateral cross part type

### `F:Autodesk.Revit.DB.PartType.LateralTee`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.LateralTee`

#### Summary

Lateral tee part type

### `F:Autodesk.Revit.DB.PartType.Wye`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Wye`

#### Summary

Wye part type

### `F:Autodesk.Revit.DB.PartType.Damper`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Damper`

#### Summary

Damper part type

### `F:Autodesk.Revit.DB.PartType.SpudAdjustable`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.SpudAdjustable`

#### Summary

Spud adjustable part type

### `F:Autodesk.Revit.DB.PartType.SpudPerpendicular`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.SpudPerpendicular`

#### Summary

Spud perpendicular part type

### `F:Autodesk.Revit.DB.PartType.ValveBreaksInto`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.ValveBreaksInto`

#### Summary

Valve breaks into part type

### `F:Autodesk.Revit.DB.PartType.Switch`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Switch`

#### Summary

Switch part type

### `F:Autodesk.Revit.DB.PartType.EquipmentSwitch`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.EquipmentSwitch`

#### Summary

Equipment switch part type

### `F:Autodesk.Revit.DB.PartType.OtherPanel`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.OtherPanel`

#### Summary

Other panel part type

### `F:Autodesk.Revit.DB.PartType.SwitchBoard`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.SwitchBoard`

#### Summary

Switch board part type

### `F:Autodesk.Revit.DB.PartType.Transformer`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Transformer`

#### Summary

Transformer part type

### `F:Autodesk.Revit.DB.PartType.PanelBoard`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.PanelBoard`

#### Summary

Panel board part type

### `F:Autodesk.Revit.DB.PartType.Union`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Union`

#### Summary

Union part type

### `F:Autodesk.Revit.DB.PartType.Offset`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Offset`

#### Summary

Offset part type

### `F:Autodesk.Revit.DB.PartType.TapAdjustable`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.TapAdjustable`

#### Summary

Tap adjustable part type

### `F:Autodesk.Revit.DB.PartType.TapPerpendicular`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.TapPerpendicular`

#### Summary

Tap perpendicular part type

### `F:Autodesk.Revit.DB.PartType.Cap`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Cap`

#### Summary

Cap part type

### `F:Autodesk.Revit.DB.PartType.Cross`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Cross`

#### Summary

Cross part type

### `F:Autodesk.Revit.DB.PartType.Transition`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Transition`

#### Summary

Transition part type

### `F:Autodesk.Revit.DB.PartType.Tee`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Tee`

#### Summary

Tee part type

### `F:Autodesk.Revit.DB.PartType.Elbow`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Elbow`

#### Summary

Elbow part type

### `F:Autodesk.Revit.DB.PartType.BreaksInto`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.BreaksInto`

#### Summary

Breaks into part type

### `F:Autodesk.Revit.DB.PartType.AttachesTo`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.AttachesTo`

#### Summary

Attaches to part type

### `F:Autodesk.Revit.DB.PartType.JunctionBox`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.JunctionBox`

#### Summary

JunctionBox part type

### `F:Autodesk.Revit.DB.PartType.DuctMounted`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.DuctMounted`

#### Summary

Duct mounted part type

### `F:Autodesk.Revit.DB.PartType.Normal`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Normal`

#### Summary

Normal part type

### `F:Autodesk.Revit.DB.PartType.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.PartType.Undefined`

#### Summary

Undefined part type

### `M:Autodesk.Revit.DB.MEPFamilyConnectorInfo.GetAssociateFamilyParameterId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPFamilyConnectorInfo.GetAssociateFamilyParameterId(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the associate family parameter id of the specified connector parameter id.

#### Parameter `connectorParameterId`

connectorParameterId is defined in the family connector element.

#### Returns

Returns valid ElementId if the connectorParameterId associates to one family parameter; otherwise returns invalid ElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.MEPFamilyConnectorInfo.GetConnectorParameterValue(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPFamilyConnectorInfo.GetConnectorParameterValue(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the parameter value of the specified connector parameter id.

#### Parameter `connectorParameterId`

connectorParameterId is defined in the family connector element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.MEPFamilyConnectorInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.MEPFamilyConnectorInfo`

#### Summary

MEP family connector information.

#### Since

2017

### `P:Autodesk.Revit.DB.MEPConnectorInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPConnectorInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.MEPConnectorInfo.LinkedConnector`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPConnectorInfo.LinkedConnector`

#### Summary

The linked connector or `null` if there is no linked connector

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2016

### `P:Autodesk.Revit.DB.MEPConnectorInfo.IsSecondary`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPConnectorInfo.IsSecondary`

#### Summary

True if this is the secondary connector.

#### Since

2016

### `P:Autodesk.Revit.DB.MEPConnectorInfo.IsPrimary`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPConnectorInfo.IsPrimary`

#### Summary

True if this is the primary connector.

#### Since

2016

### `T:Autodesk.Revit.DB.MEPConnectorInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.MEPConnectorInfo`

#### Summary

MEP connector information.

#### Since

2016

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.GetDownstreamSegments`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.GetDownstreamSegments`

#### Summary

Gets all downstream network segments.

#### Returns

The list of segments that flow out of this segment.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.GetUpstreamSegments`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.GetUpstreamSegments`

#### Summary

Gets all upstream network segments.

#### Returns

The list of segments that flow into this segment.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.IsValid`

#### Summary

Verified if this segment data has been assigned some valid values afer calculation.

#### Returns

True if the segment was assigned valid values, otherwise false.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.Coefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.Coefficient`

#### Summary

The calculated coefficient of this segment, dimensionless.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.PressureDrop`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.PressureDrop`

#### Summary

The calculated pressure drop of this segment, in kg/(ft*s^2).

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.VelocityPressure`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.VelocityPressure`

#### Summary

The calculated velocity pressure of this segment, in kg/(ft*s^2).

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.Velocity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.Velocity`

#### Summary

The calculated velocity of this segment, in ft/s.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.FrictionFactor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.FrictionFactor`

#### Summary

The calculated friction factor of this segment, dimensionless.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.RelativeRoughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.RelativeRoughness`

#### Summary

The relative roughness of this segment, dimensionless.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.ReynoldsNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.ReynoldsNumber`

#### Summary

The Reynolds number of this segment, dimensionless.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.FlowState`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.FlowState`

#### Summary

The calculated flow state of this segment.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.Flow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.Flow`

#### Summary

The calculated flow of this segment, in ft^3/s. The positive value means the flow is from the start to the end node, the negative value means opposite direction.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.SectionNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.SectionNumber`

#### Summary

The section this segment belongs to.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.IsCriticalPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.IsCriticalPath`

#### Summary

Verifies if the segment is on the critical path.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.#ctor(Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.#ctor(Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData)`

#### Summary

Creates a new segment data object based on another object.

#### Parameter `other`

The other segment data that the new object is based on.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData.#ctor`

#### Summary

Creates a default segment data object.

#### Since

2024

### `T:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData`

#### Summary

Represents the analysis data for one network segment.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.Area`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.Area`

#### Summary

The area of the segment profile.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.DemandFlow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.DemandFlow`

#### Summary

The designed flow value, in ft^3/s.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.RevitElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.RevitElementId`

#### Summary

The id of the owning Revit element.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.EndNode`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.EndNode`

#### Summary

The id of the end analytical node.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.StartNode`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.StartNode`

#### Summary

The id of the start analytical node.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.Id`

#### Summary

The identity of this segment.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.Roughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.Roughness`

#### Summary

The roughness of this segment, in ft.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.InnerDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.InnerDiameter`

#### Summary

The inner diameter of this segment, in ft. For rectangular or oval profile, this may be the hydraulic diameter.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.SegmentType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.SegmentType`

#### Summary

The analytical segment type.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.DomainType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment.DomainType`

#### Summary

The connector domain type of this segment.

#### Since

2024
