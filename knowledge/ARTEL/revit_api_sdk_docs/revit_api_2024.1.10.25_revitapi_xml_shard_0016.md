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
Shard: 16
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `T:Autodesk.Revit.DB.ICloudExternalServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.ICloudExternalServer`

#### Summary

The interface used to get the cloud model information that stored on the cloud (such as C4R).

#### Remarks

Implement this interface and register an instance of the derived class with the CloudExternalService.

#### Since

2019

### `M:Autodesk.Revit.DB.ICentralLockedCallbackProxy.ShouldWaitForLockAvailability`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICentralLockedCallbackProxy.ShouldWaitForLockAvailability`

#### Summary

Returns whether Revit should wait and try again to acquire the lock on central.

#### Returns

True means wait and try again later. False means immediately give up.

#### Since

2014

### `M:Autodesk.Revit.DB.ICentralLockedCallback.ShouldWaitForLockAvailability`

Member kind: method
Symbol: `Autodesk.Revit.DB.ICentralLockedCallback.ShouldWaitForLockAvailability`

#### Summary

Returns whether Revit should wait and try again to acquire the lock on central.

#### Returns

True means wait and try again later. False means immediately give up.

#### Since

2014

### `T:Autodesk.Revit.DB.ICentralLockedCallback`

Member kind: type
Symbol: `Autodesk.Revit.DB.ICentralLockedCallback`

#### Summary

An interface that may be used to control Revit's behavior when it tries to lock central
and is blocked because another user already has locked central.

#### Since

2014

### `M:Autodesk.Revit.DB.Infrastructure.IAlignmentServerProxy.GetOrCreateDefaultLabelSetType(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.IAlignmentServerProxy.GetOrCreateDefaultLabelSetType(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

#### Summary

Get the type with default settings for creating a label set.
If one does not exist, create it.

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.IAlignmentServerProxy.SetInSessionDefaultLabelSetTypeId(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.IAlignmentServerProxy.SetInSessionDefaultLabelSetTypeId(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

#### Summary

Set in-session default type for label set creation

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.IAlignmentServerProxy.GetInSessionDefaultLabelSetTypeId(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.IAlignmentServerProxy.GetInSessionDefaultLabelSetTypeId(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

#### Summary

Get in-session default type for label set creation

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.IAlignmentServerProxy.GetValuesByStation(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.IAlignmentServerProxy.GetValuesByStation(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

#### Summary

Get distance and point on geometry by station

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.IAlignmentServerProxy.GetValuesByPoint(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.IAlignmentServerProxy.GetValuesByPoint(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

#### Summary

Get distance, station value and point on geometry by point

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.IAlignmentServerProxy.GetValuesByDistance(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.IAlignmentServerProxy.GetValuesByDistance(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

#### Summary

Get station value and point on geometry by alignment distance

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.IAlignmentServer.GetOrCreateDefaultLabelSetType(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.IAlignmentServer.GetOrCreateDefaultLabelSetType(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

#### Summary

Get the type with default settings for creating a label set.
If one does not exist, create it.

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.IAlignmentServer.SetInSessionDefaultLabelSetTypeId(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.IAlignmentServer.SetInSessionDefaultLabelSetTypeId(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

#### Summary

Set in-session default type for label set creation

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.IAlignmentServer.GetInSessionDefaultLabelSetTypeId(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.IAlignmentServer.GetInSessionDefaultLabelSetTypeId(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

#### Summary

Get in-session default type for label set creation

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.IAlignmentServer.GetValuesByStation(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.IAlignmentServer.GetValuesByStation(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

#### Summary

Get distance and point on geometry by station

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.IAlignmentServer.GetValuesByPoint(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.IAlignmentServer.GetValuesByPoint(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

#### Summary

Get distance, station value and point on geometry by point

#### Since

2021

### `M:Autodesk.Revit.DB.Infrastructure.IAlignmentServer.GetValuesByDistance(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Infrastructure.IAlignmentServer.GetValuesByDistance(Autodesk.Revit.DB.Infrastructure.AlignmentServiceData)`

#### Summary

Get station value and point on geometry by alignment distance

#### Since

2021

### `T:Autodesk.Revit.DB.Infrastructure.IAlignmentServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.Infrastructure.IAlignmentServer`

#### Summary

Interface class for external servers implementing Infrastructure Alignments

#### Remarks

A typical way to use the external server can be:
Implement a server class that derives from this interface

Create a new server object and register it with the service, see `!:Autodesk.Revit.DB.ExternalService.ExternalServiceRegistry` .

#### Since

2021

### `P:Autodesk.Revit.DB.Infrastructure.AlignmentServerId.AlignmentServerGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServerId.AlignmentServerGUID`

#### Summary

GUID to represent the Alignment server id.

#### Since

2021

### `T:Autodesk.Revit.DB.Infrastructure.AlignmentServerId`

Member kind: type
Symbol: `Autodesk.Revit.DB.Infrastructure.AlignmentServerId`

#### Summary

Id for external server implementing Aligment Services

#### Since

2021

### `M:Autodesk.Revit.DB.IAXMImporterServerProxy.ImportAXM(Autodesk.Revit.AXMImporterServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IAXMImporterServerProxy.ImportAXM(Autodesk.Revit.AXMImporterServiceData)`

#### Summary

The method that Revit will invoke to perform AXM import.

#### Parameter `data`

The AXM import data.

#### Returns

Indicates whether the AXM importer server is executed successfully.

### `M:Autodesk.Revit.DB.IAXMImporterServer.ImportAXM(Autodesk.Revit.AXMImporterServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IAXMImporterServer.ImportAXM(Autodesk.Revit.AXMImporterServiceData)`

#### Summary

The method that Revit will invoke to perform AXM import.

#### Parameter `data`

The AXM import data.

#### Returns

Indicates whether the AXM importer server is executed successfully.

### `T:Autodesk.Revit.DB.IAXMImporterServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.IAXMImporterServer`

#### Summary

Interface for external servers implementing AXM import.

### `M:Autodesk.Revit.DB.IATFTranslationServerProxy.Translate(Autodesk.Revit.DB.ATFTranslationServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IATFTranslationServerProxy.Translate(Autodesk.Revit.DB.ATFTranslationServiceData)`

#### Summary

Translate a model according to translationData settings

#### Returns

Returns true if the translation finished successfully, false otherwise.

#### Since

2021

### `M:Autodesk.Revit.DB.IATFTranslationServer.Translate(Autodesk.Revit.DB.ATFTranslationServiceData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IATFTranslationServer.Translate(Autodesk.Revit.DB.ATFTranslationServiceData)`

#### Summary

Translate a model according to translationData settings

#### Returns

Returns true if the translation finished successfully, false otherwise.

#### Since

2021

### `T:Autodesk.Revit.DB.IATFTranslationServer`

Member kind: type
Symbol: `Autodesk.Revit.DB.IATFTranslationServer`

#### Summary

Interface class for external servers implementing ATF translation.

#### Remarks

A typical way to use the external server can be:
Implement a server class that derives from this interface

Create a new server object and register it with the service, see `!:Autodesk.Revit.DB.ExternalService.ExternalServiceRegistry` .

#### Since

2021

### `T:Autodesk.Revit.DB.Mechanical.SpaceTagType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceTagType`

#### Summary

An object that represents a Space Tag style.

### `P:Autodesk.Revit.DB.Mechanical.SpaceTag.SpaceTagType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceTag.SpaceTagType`

#### Summary

The tag type.

### `P:Autodesk.Revit.DB.Mechanical.SpaceTag.Space`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceTag.Space`

#### Summary

The space that the tag is associated with.

#### Remarks

In rare cases, the tag may not be associated to a space. The property will
be `null` in these situations.

### `T:Autodesk.Revit.DB.Mechanical.SpaceTag`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceTag`

#### Summary

Provides access to the space tag in Autodesk Revit.

#### Remarks

The space Tag object can be queried for space information.

### `M:Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction.#ctor(ADocument*,RoomElem*)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction.#ctor(ADocument*,RoomElem*)`

### `M:Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction.DeleteConstruction(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction.DeleteConstruction(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction)`

#### Summary

Remove an existing construction from Space constructions.

#### Parameter `pCurrentConstruction`

The Construction will be deleted.

### `M:Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction.DuplicateConstruction(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction.DuplicateConstruction(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction,System.String)`

#### Summary

Create a new construction for Space constructions.

#### Parameter `pCurrentConstruction`

The existing construction to be duplicated.

#### Parameter `pName`

The name of the new construction.

#### Remarks

If the name is same with the existing one, an exception will be thrown.

### `M:Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction.NewConstruction(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction.NewConstruction(System.String)`

#### Summary

Create a new construction for Space constructions.

#### Parameter `pName`

The name of the new Construction.

#### Remarks

If the name is same as an existing one, an exception will be thrown.

### `P:Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction.SpaceConstructions`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction.SpaceConstructions`

#### Summary

Return all the Space constructions of current space.

#### Parameter `pName`

The name of the new Construction.

#### Remarks

If the name is same with the existing one, an exception will be thrown.

### `P:Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction.CurrentConstruction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction.CurrentConstruction`

#### Summary

Get all the Building Constructions according to the specific Construction type.

#### Parameter `constructionType`

The Construction Type to be set the Building Construction.

#### Remarks

This property is used to get or set the Building Service of the Project Information.

### `T:Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction`

#### Summary

Construction definition for Space.

#### Remarks

This is used to define the information in Constructions.xml.

### `M:Autodesk.Revit.DB.Construction.#ctor(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Construction.#ctor(System.String,System.String)`

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction.#ctor(ConstructionSetBase*)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction.#ctor(ConstructionSetBase*)`

### `P:Autodesk.Revit.DB.Construction.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Construction.Name`

#### Summary

Get the name of the Construction.

#### Remarks

This property is used to get the name of the Construction.

### `P:Autodesk.Revit.DB.Construction.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.Construction.Id`

#### Summary

Get the id of the Construction.

#### Remarks

This property is used to get the id of the Construction.

### `T:Autodesk.Revit.DB.Construction`

Member kind: type
Symbol: `Autodesk.Revit.DB.Construction`

#### Summary

Construction definition for Project Information.

#### Remarks

This is used to define the information in Constructions.xml.

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction.GetBuildingConstructionOverride(Autodesk.Revit.DB.Analysis.ConstructionType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction.GetBuildingConstructionOverride(Autodesk.Revit.DB.Analysis.ConstructionType)`

#### Summary

Gets the Building Construction override for a ConstructionType.

#### Parameter `constructionType`

The ConstructionType override value to get.

#### Returns

True if analytical construction properties specified in Constructions.xml are used for the given ConstructionType, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The ConstructionType is invalid.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction.SetBuildingConstructionOverride(Autodesk.Revit.DB.Analysis.ConstructionType,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction.SetBuildingConstructionOverride(Autodesk.Revit.DB.Analysis.ConstructionType,System.Boolean)`

#### Summary

Sets the Building Construction override for a ConstructionType.

#### Parameter `constructionType`

The ConstructionType to override.

#### Parameter `override`

True to use analytical construction properties specified in Constructions.xml in the given ConstructionType, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The ConstructionType is invalid.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction.SetBuildingConstruction(Autodesk.Revit.DB.Analysis.ConstructionType,Autodesk.Revit.DB.Construction)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction.SetBuildingConstruction(Autodesk.Revit.DB.Analysis.ConstructionType,Autodesk.Revit.DB.Construction)`

#### Summary

Sets the Building Construction of the Project Information.

#### Remarks

This function is used to set the Building Construction of the Project Information.

#### Parameter `constructionType`

The Construction Type of Building Construction.

#### Parameter `buildingConstruction`

The Building Construction to be set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

buildingConstruction is NULL.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Sets construction type to an invalid value.
- or -
Can not set construction type.

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction.GetBuildingConstruction(Autodesk.Revit.DB.Analysis.ConstructionType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction.GetBuildingConstruction(Autodesk.Revit.DB.Analysis.ConstructionType)`

#### Summary

Gets the current Building Construction from the project information.

#### Remarks

This function is used to get the Building Construction of the Project Information.

#### Parameter `constructionType`

The Construction Type of Building Construction.

#### Returns

The Building Construction of the Project Information.

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction.GetConstructions(Autodesk.Revit.DB.Analysis.ConstructionType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction.GetConstructions(Autodesk.Revit.DB.Analysis.ConstructionType)`

#### Summary

Gets all the Building Constructions corresponding to the specific Construction type.

#### Remarks

This function is used to get the Building Construction of the Project Information.

#### Parameter `constructionType`

The Construction Type of Building Construction.

#### Returns

A collection containing Building constructions matching the construction type.

### `T:Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction`

#### Summary

Construction definition for Project Information.

#### Remarks

This is used to define the information in Constructions.xml.

### `T:Autodesk.Revit.DB.Plumbing.FlexPipeType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.FlexPipeType`

#### Summary

A flex pipe type in the Autodesk Revit MEP product.

#### Remarks

The flex pipe type is only available in the Autodesk Revit MEP product.

### `T:Autodesk.Revit.DB.Mechanical.FlexDuctType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.FlexDuctType`

#### Summary

A flex duct type in the Autodesk Revit MEP product.

#### Remarks

The flex duct type is only available in the Autodesk Revit MEP product.

### `M:Autodesk.Revit.DB.ConnectorElement.ChangeHostReference(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Edge)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.ChangeHostReference(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Edge)`

#### Summary

Changes the connector host reference to a new planar face and a new edge loop.

#### Remarks

The connector referenced by an edge loop has the fixed origin as defined by the edge loop.

#### Parameter `planarFace`

The planar face to place the connector on.

#### Parameter `edge`

One of the edges in the edge loop that defines the new connector location on the planar face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The face is not a planar face.
-or-
The edge is not on the planar face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.ConnectorElement.ChangeHostReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.ChangeHostReference(Autodesk.Revit.DB.Reference)`

#### Summary

Changes the connector host reference to a new planar face.

#### Remarks

The connector referenced by a planar face alone is placed at the plane origin, and may be moved later along the planar face.

#### Parameter `planarFace`

The planar face to place the connector on.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The face is not a planar face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.ConnectorElement.FlipDirection`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.FlipDirection`

#### Summary

Reverses the direction of the connector element.

#### Since

2014

### `M:Autodesk.Revit.DB.ConnectorElement.IsSystemClassificationValid(Autodesk.Revit.DB.MEPSystemClassification)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.IsSystemClassificationValid(Autodesk.Revit.DB.MEPSystemClassification)`

#### Summary

Checks that the MEPSystemType is valid for the domain of connector.

#### Parameter `systemClassification`

The MEPSystemType to be validated.

#### Returns

True if the MEPSystemType is valid for the domain of the connector, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.ConnectorElement.AssignAsPrimary`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.AssignAsPrimary`

#### Summary

Assign a connector as a primary connector.

#### Remarks

This method is used to promote this connector as primary, and the rest of connectors in this system will be assigned as secondary.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when fail to assign this connector as primary.

### `M:Autodesk.Revit.DB.ConnectorElement.CreateCableTrayConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Edge)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.CreateCableTrayConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Edge)`

#### Summary

Create a new cable tray ConnectorElement.

#### Remarks

Regenerates the document.

#### Parameter `document`

The document to add the connector to.

#### Parameter `planarFace`

The planar face to place the connector on.

#### Parameter `edge`

One of the edges in the edge loop that defines the connector location on the planar face.

#### Returns

The cable tray ConnectorElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The reference is not a planar face.
-or-
document is not a family document.
-or-
Thrown when the edge does not belong to the face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Connector creation is not allowed in this family.

#### Since

2014

### `M:Autodesk.Revit.DB.ConnectorElement.CreateConduitConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Edge)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.CreateConduitConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Edge)`

#### Summary

Create a new conduit ConnectorElement.

#### Remarks

Regenerates the document.

#### Parameter `document`

The document to add the connector to.

#### Parameter `planarFace`

The planar face to place the connector on.

#### Parameter `edge`

One of the edges in the edge loop that defines the connector location on the planar face.

#### Returns

The conduit ConnectorElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The reference is not a planar face.
-or-
document is not a family document.
-or-
Thrown when the edge does not belong to the face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Connector creation is not allowed in this family.

#### Since

2014

### `M:Autodesk.Revit.DB.ConnectorElement.CreateElectricalConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Electrical.ElectricalSystemType,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Edge)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.CreateElectricalConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Electrical.ElectricalSystemType,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Edge)`

#### Summary

Create a new electrical ConnectorElement.

#### Remarks

Regenerates the document.

#### Parameter `document`

The document to add the connector to.

#### Parameter `electricalSystemType`

The ElectricalSystemTYpe of the connector.

#### Parameter `planarFace`

The planar face to place the connector on.

#### Parameter `edge`

One of the edges in the edge loop that defines the connector location on the planar face.

#### Returns

The electrical ConnectorElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The reference is not a planar face.
-or-
document is not a family document.
-or-
Thrown when the edge does not belong to the face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Connector creation is not allowed in this family.

#### Since

2014

### `M:Autodesk.Revit.DB.ConnectorElement.CreateCableTrayConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.CreateCableTrayConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

#### Summary

Create a new cable tray ConnectorElement.

#### Remarks

Regenerates the document.

#### Parameter `document`

The document to add the connector to.

#### Parameter `planarFace`

The planar face to place the connector on.

#### Returns

The cable tray ConnectorElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The reference is not a planar face.
-or-
document is not a family document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Connector creation is not allowed in this family.

#### Since

2013

### `M:Autodesk.Revit.DB.ConnectorElement.CreateConduitConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.CreateConduitConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

#### Summary

Create a new conduit ConnectorElement.

#### Remarks

Regenerates the document.

#### Parameter `document`

The document to add the connector to.

#### Parameter `planarFace`

The planar face to place the connector on.

#### Returns

The conduit ConnectorElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The reference is not a planar face.
-or-
document is not a family document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Connector creation is not allowed in this family.

#### Since

2013

### `M:Autodesk.Revit.DB.ConnectorElement.CreateElectricalConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Electrical.ElectricalSystemType,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.CreateElectricalConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Electrical.ElectricalSystemType,Autodesk.Revit.DB.Reference)`

#### Summary

Create a new electrical ConnectorElement.

#### Remarks

Regenerates the document.

#### Parameter `document`

The document to add the connector to.

#### Parameter `electricalSystemType`

The ElectricalSystemTYpe of the connector.

#### Parameter `planarFace`

The planar face to place the connector on.

#### Returns

The electrical ConnectorElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The reference is not a planar face.
-or-
document is not a family document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Connector creation is not allowed in this family.

#### Since

2013

### `M:Autodesk.Revit.DB.ConnectorElement.CreateDuctConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Mechanical.DuctSystemType,Autodesk.Revit.DB.ConnectorProfileType,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Edge)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.CreateDuctConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Mechanical.DuctSystemType,Autodesk.Revit.DB.ConnectorProfileType,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Edge)`

#### Summary

Create a new duct ConnectorElement.

#### Remarks

Regenerates the document.

#### Parameter `document`

The document to add the connector to.

#### Parameter `ductSystemType`

The DuctSystemType of the connector.

#### Parameter `profileShape`

The profile shape of the duct.

#### Parameter `planarFace`

The planar face to place the connector on.

#### Parameter `edge`

One of the edges in the edge loop that defines the connector location on the planar face.

#### Returns

The duct ConnectorElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The reference is not a planar face.
-or-
document is not a family document.
-or-
Thrown when the edge does not belong to the face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Connector creation is not allowed in this family.

#### Since

2014

### `M:Autodesk.Revit.DB.ConnectorElement.CreateDuctConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Mechanical.DuctSystemType,Autodesk.Revit.DB.ConnectorProfileType,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.CreateDuctConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Mechanical.DuctSystemType,Autodesk.Revit.DB.ConnectorProfileType,Autodesk.Revit.DB.Reference)`

#### Summary

Create a new duct ConnectorElement.

#### Remarks

Regenerates the document.

#### Parameter `document`

The document to add the connector to.

#### Parameter `ductSystemType`

The DuctSystemType of the connector.

#### Parameter `profileShape`

The profile shape of the duct.

#### Parameter `planarFace`

The planar face to place the connector on.

#### Returns

The duct ConnectorElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The reference is not a planar face.
-or-
document is not a family document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Connector creation is not allowed in this family.

#### Since

2013

### `M:Autodesk.Revit.DB.ConnectorElement.CreatePipeConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Plumbing.PipeSystemType,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Edge)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.CreatePipeConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Plumbing.PipeSystemType,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Edge)`

#### Summary

Create a new pipe ConnectorElement with a face and an edge.

#### Remarks

Regenerates the document.

#### Parameter `document`

The document to add the connector to.

#### Parameter `pipeSystemType`

The PipeSystemType of the connector.

#### Parameter `planarFace`

The planar face to place the connector on.

#### Parameter `edge`

One of the edges in the edge loop that defines the connector location on the planar face.

#### Returns

The pipe ConnectorElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The reference is not a planar face.
-or-
document is not a family document.
-or-
Thrown when the edge does not belong to the face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Connector creation is not allowed in this family.

#### Since

2014

### `M:Autodesk.Revit.DB.ConnectorElement.CreatePipeConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Plumbing.PipeSystemType,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.CreatePipeConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Plumbing.PipeSystemType,Autodesk.Revit.DB.Reference)`

#### Summary

Create a new pipe ConnectorElement.

#### Remarks

Regenerates the document.

#### Parameter `document`

The document to add the connector to.

#### Parameter `pipeSystemType`

The PipeSystemType of the connector.

#### Parameter `planarFace`

The planar face to place the connector on.

#### Returns

The pipe ConnectorElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The reference is not a planar face.
-or-
document is not a family document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Connector creation is not allowed in this family.

#### Since

2013

### `M:Autodesk.Revit.DB.ConnectorElement.SetLinkedConnectorElement(Autodesk.Revit.DB.ConnectorElement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.SetLinkedConnectorElement(Autodesk.Revit.DB.ConnectorElement)`

#### Summary

Set the linked connector element.

#### Remarks

Set the linked connector to `null` to remove the link.

#### Parameter `otherConnector`

The connector to link to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The connector being linked to is a different domain than that of the calling connector.
-or-
The connector being linked to is the same as the calling connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This connector type does not support linked connectors.

#### Since

2013

### `M:Autodesk.Revit.DB.ConnectorElement.GetLinkedConnectorElement`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorElement.GetLinkedConnectorElement`

#### Summary

Get the linked connector element.

#### Returns

The linked connector element. If `null` , the connector has no link.

#### Since

2013

### `P:Autodesk.Revit.DB.ConnectorElement.Direction`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorElement.Direction`

#### Summary

Gets the direction of the connector element.

#### Since

2014

### `P:Autodesk.Revit.DB.ConnectorElement.SystemClassification`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorElement.SystemClassification`

#### Summary

The system classification of the connector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

When setting this property: The MEPSystemType is not valid for the domain of this connector.

#### Since

2014

### `P:Autodesk.Revit.DB.ConnectorElement.IsPrimary`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorElement.IsPrimary`

#### Summary

Identifies if this is the primary connector in the family.

### `P:Autodesk.Revit.DB.ConnectorElement.Radius`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorElement.Radius`

#### Summary

The radius of the connector.

#### Remarks

-1 if the connector is not round.

### `P:Autodesk.Revit.DB.ConnectorElement.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorElement.Height`

#### Summary

The height of the connector.

#### Remarks

-1 if the connector is round.

### `P:Autodesk.Revit.DB.ConnectorElement.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorElement.Width`

#### Summary

The width of the connector.

#### Remarks

-1 if the connector is round.

### `P:Autodesk.Revit.DB.ConnectorElement.Shape`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorElement.Shape`

#### Summary

The shape of the connector.

#### Remarks

ConnectorProfileType::Invalid if the connector is electrical or undefined.

### `P:Autodesk.Revit.DB.ConnectorElement.Domain`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorElement.Domain`

#### Summary

The domain of the connector.

#### Remarks

This property is used to retrieve the domain of the connector.

### `P:Autodesk.Revit.DB.ConnectorElement.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorElement.Origin`

#### Summary

The location of the connector in family document.

### `P:Autodesk.Revit.DB.ConnectorElement.CoordinateSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorElement.CoordinateSystem`

#### Summary

The coordinate system of the connector.

#### Remarks

The Z axis of the coordinate system is the normal to the plane of the connector.

### `T:Autodesk.Revit.DB.ConnectorElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.ConnectorElement`

#### Summary

A base class that provides support for all connector elements occurring in families.

### `M:Autodesk.Revit.DB.LoadedFamilyIntegrityCheck.CheckAllFamiliesSlow(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.LoadedFamilyIntegrityCheck.CheckAllFamiliesSlow(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Check integrity of content documents of all families loaded in the host document.

#### Remarks

This check is slow as it invloves traversal of all content documents.
It also dumps data about bad families into the journal, as well as the whole content tree into the dump file.

#### Parameter `ADoc`

The host document.

#### Parameter `corruptFamilyIds`

Return ids of families that need to be reloaded because their content documents are missing or corrupt.

#### Returns

Returns true if all content documents are usable.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.LoadedFamilyIntegrityCheck.CheckFamily(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LoadedFamilyIntegrityCheck.CheckFamily(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Check that the loaded family has its content document.

#### Parameter `ADoc`

The host document.

#### Parameter `familyId`

The id of the family to check.

#### Returns

Returns true if the family has its content document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.LoadedFamilyIntegrityCheck.CheckAllFamilies(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.LoadedFamilyIntegrityCheck.CheckAllFamilies(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Check that all families loaded in the host document have their content documents.

#### Parameter `ADoc`

The host document.

#### Parameter `corruptFamilyIds`

Return ids of families that need to be reloaded because their content documents are missing.

#### Returns

Returns true if all loaded families have their content documents.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.LoadedFamilyIntegrityCheck`

Member kind: type
Symbol: `Autodesk.Revit.DB.LoadedFamilyIntegrityCheck`

#### Summary

Functions for checking the integrity of loaded families.

### `M:Autodesk.Revit.DB.Structure.LoadNature.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadNature.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new LoadNature.

#### Parameter `document`

The Document to which new load nature element will be added.

#### Parameter `name`

The name of the load nature.

#### Returns

The newly created load nature element if successful, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given name is not unique

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.LoadNature`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LoadNature`

#### Summary

An object that represents a load nature.

### `M:Autodesk.Revit.DB.Structure.LoadUsage.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadUsage.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new LoadUsage.

#### Parameter `document`

The Document to which new load usage element will be added.

#### Parameter `name`

The name of the load usage.

#### Returns

The newly created load usage element if successful, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given name is not unique

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.LoadUsage`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LoadUsage`

#### Summary

An object that represents a load usage.

### `M:Autodesk.Revit.DB.Structure.LoadCase.IsNumberUnique(Autodesk.Revit.DB.Document,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadCase.IsNumberUnique(Autodesk.Revit.DB.Document,System.Int32)`

#### Summary

Checks that a given number is unique among all load cases.

#### Parameter `number`

The number to check.

#### Returns

True if the given number is unique among all load cases, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.LoadCase.IsLoadNatureId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadCase.IsLoadNatureId(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether provided element ID refer to LoadNature element.

#### Parameter `natureId`

The ID to check.

#### Returns

True if the ID refers to LoadNature element, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.LoadCase.IsLoadCaseSubcategoryId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadCase.IsLoadCaseSubcategoryId(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether provided element ID refer to subcategory of Structural Load Cases ( `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCases` ) category - one of built-in or user defined.

#### Remarks

Built-in structural Load Cases ( `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCases` ) subcategories are:
`F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesDead` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesLive` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesWind` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesSnow` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesRoofLive` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesAccidental` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesTemperature` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesSeismic`

#### Parameter `loadCaseSubcategoryId`

The ID to check.

#### Returns

True if the ID refers to load case category element, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.LoadCase.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadCase.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new LoadCase.

#### Remarks

This method is designed to create LoadCase that is associated with user defined category.

#### Parameter `document`

The Document to which new load case element will be added.

#### Parameter `name`

The name of the load case.

#### Parameter `natureId`

The load nature ID.

#### Parameter `subcategoryId`

The load case subcategory ID. Could be one of predefined or user defined load case category.
Built-in structural Load Cases ( `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCases` ) subcategories are:
`F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesDead` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesLive` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesWind` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesSnow` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesRoofLive` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesAccidental` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesTemperature` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesSeismic`

#### Returns

The newly created load case element if successful, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given name is not unique.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.LoadCase.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.LoadCaseCategory)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadCase.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.LoadCaseCategory)`

#### Summary

Creates a new LoadCase.

#### Remarks

This method is designed to create LoadCase that is associated with one of the predefined category.

#### Parameter `document`

The Document to which new load case element will be added.

#### Parameter `name`

The name of the load case.

#### Parameter `natureId`

The load nature ID.

#### Parameter `loadCaseCategory`

The predefined load case category.

#### Returns

The newly created load case element if successful, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given name is not unique.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LoadCase.Number`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadCase.Number`

#### Summary

Returns unique load case number.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given number is not unique.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LoadCase.SubcategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadCase.SubcategoryId`

#### Summary

Build-in or user defined subcategory of Structural Load Cases ( `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCases` ) category.

#### Remarks

Build-in Structural Load Cases ( `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCases` ) subcategories are:
`F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesDead` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesLive` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesWind` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesSnow` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesRoofLive` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesAccidental` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesTemperature` `F:Autodesk.Revit.DB.BuiltInCategory.OST_LoadCasesSeismic`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: the subcategoryId does not refer to predefined nor user defined load case category element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.LoadCase.NatureId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadCase.NatureId`

#### Summary

The nature ID of the load case.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: the natureId does not refer to LoadNature element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.LoadCase`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LoadCase`

#### Summary

An object that represents a load usage.

### `P:Autodesk.Revit.DB.Structure.LoadComponent.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadComponent.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.LoadComponent.Factor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadComponent.Factor`

#### Summary

Load component factor.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LoadComponent.LoadCaseOrCombinationId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadComponent.LoadCaseOrCombinationId`

#### Summary

Load case or combination id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.LoadComponent.#ctor(Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadComponent.#ctor(Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Constructs a new instance of a LoadComponent.
The load case or combination id.
The load case or combination factor.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.LoadComponent`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LoadComponent`

#### Summary

An object that represents a load combination component.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.LoadCombination.SetComponents(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.LoadComponent})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadCombination.SetComponents(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.LoadComponent})`

#### Summary

Sets a collection of the load combination components.

#### Parameter `components`

A collection of the load combination components.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.LoadCombination.GetComponents`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadCombination.GetComponents`

#### Summary

Returns collection of the load combination components.

#### Returns

A collection of the load combination components.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.LoadCombination.SetUsageIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadCombination.SetUsageIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets a collection of the load combination usage IDs.

#### Parameter `usageIds`

A collection of the load combination usage IDs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.LoadCombination.GetUsageIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadCombination.GetUsageIds`

#### Summary

Returns collection of the load combination usage IDs.

#### Returns

A collection of the load combination usage IDs.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.LoadCombination.GetCaseAndCombinationIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadCombination.GetCaseAndCombinationIds`

#### Summary

Returns collection of the load combination case and combination IDs.

#### Remarks

Load combination components could be load cases or other load combinations.
To set them with factors use `M:Autodesk.Revit.DB.Structure.LoadCombination.SetComponents(System.Collections.Generic.IList`1{Autodesk.Revit.DB.Structure.LoadComponent})` method.

#### Returns

A collection of the load combination case and combination IDs.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.LoadCombination.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Structure.LoadCombinationType,Autodesk.Revit.DB.Structure.LoadCombinationState)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadCombination.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Structure.LoadCombinationType,Autodesk.Revit.DB.Structure.LoadCombinationState)`

#### Summary

Creates a new LoadCombination.

#### Parameter `document`

The Document to which new load combination element will be added.

#### Parameter `name`

The name of the load combination.

#### Parameter `type`

The type of the load combination.

#### Parameter `state`

The state of the load combination.

#### Returns

The newly created load combination element if successful, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given name is not unique

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.LoadCombination.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LoadCombination.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new default LoadCombination.

#### Parameter `document`

The Document to which new load combination element will be added.

#### Parameter `name`

The name of the load combination.

#### Returns

The newly created load combination element if successful, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given name is not unique

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LoadCombination.IsThirdPartyGenerated`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadCombination.IsThirdPartyGenerated`

#### Summary

Indicates if the load combination was created by API.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LoadCombination.State`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadCombination.State`

#### Summary

The state of the load combination.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LoadCombination.Type`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LoadCombination.Type`

#### Summary

The type of the load combination.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.LoadCombination`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LoadCombination`

#### Summary

An object that represents a load combination.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.LoadCaseCategory`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LoadCaseCategory`

#### Since

2017

#### Summary

Specifies load case category.

#### Since

2017

### `F:Autodesk.Revit.DB.Structure.LoadCaseCategory.Seismic`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadCaseCategory.Seismic`

#### Summary

Seismic

### `F:Autodesk.Revit.DB.Structure.LoadCaseCategory.Temperature`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadCaseCategory.Temperature`

#### Summary

Temperature

### `F:Autodesk.Revit.DB.Structure.LoadCaseCategory.Accidental`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadCaseCategory.Accidental`

#### Summary

Accidental

### `F:Autodesk.Revit.DB.Structure.LoadCaseCategory.RoofLive`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadCaseCategory.RoofLive`

#### Summary

Roof Live

### `F:Autodesk.Revit.DB.Structure.LoadCaseCategory.Snow`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadCaseCategory.Snow`

#### Summary

Snow

### `F:Autodesk.Revit.DB.Structure.LoadCaseCategory.Wind`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadCaseCategory.Wind`

#### Summary

Wind

### `F:Autodesk.Revit.DB.Structure.LoadCaseCategory.Live`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadCaseCategory.Live`

#### Summary

Live

### `F:Autodesk.Revit.DB.Structure.LoadCaseCategory.Dead`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadCaseCategory.Dead`

#### Summary

Dead

### `T:Autodesk.Revit.DB.Structure.LoadCombinationState`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LoadCombinationState`

#### Since

2016

#### Summary

Specifies load combination state.

#### Since

2016

### `F:Autodesk.Revit.DB.Structure.LoadCombinationState.Ultimate`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadCombinationState.Ultimate`

#### Summary

Ultimate

### `F:Autodesk.Revit.DB.Structure.LoadCombinationState.Serviceability`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadCombinationState.Serviceability`

#### Summary

Serviceability

### `T:Autodesk.Revit.DB.Structure.LoadCombinationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LoadCombinationType`

#### Since

2016

#### Summary

Specifies load combination type.

#### Since

2016

### `F:Autodesk.Revit.DB.Structure.LoadCombinationType.Envelope`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadCombinationType.Envelope`

#### Summary

Envelope

### `F:Autodesk.Revit.DB.Structure.LoadCombinationType.Combination`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.LoadCombinationType.Combination`

#### Summary

Combination

### `M:Autodesk.Revit.DB.IOnLocalLinkSharedCoordinatesSavedCallbackProxy.OnLocalLinkSharedCoordinatesSaved(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IOnLocalLinkSharedCoordinatesSavedCallbackProxy.OnLocalLinkSharedCoordinatesSaved(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Revit will call this method whenever shared coordinates
changes are saved to a linked document provided by an
IExternalResourceServer. This call is a notification
to the server provider that one of their Revit or DWG
links has changed locally, and they should upload the
new version back to their server.

#### Parameter `changedResource`

The ExternalResourceReference whose shared coordinates have been saved.

#### Since

2015

### `M:Autodesk.Revit.DB.IOnLocalLinkSharedCoordinatesSavedCallback.OnLocalLinkSharedCoordinatesSaved(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IOnLocalLinkSharedCoordinatesSavedCallback.OnLocalLinkSharedCoordinatesSaved(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Revit will call this method whenever shared coordinates
changes are saved to a linked document provided by an
IExternalResourceServer. This call is a notification
to the server provider that one of their Revit or DWG
links has changed locally, and they should upload the
new version back to their server.

#### Parameter `changedResource`

The ExternalResourceReference whose shared coordinates have been saved.

#### Since

2015

### `T:Autodesk.Revit.DB.IOnLocalLinkSharedCoordinatesSavedCallback`

Member kind: type
Symbol: `Autodesk.Revit.DB.IOnLocalLinkSharedCoordinatesSavedCallback`

#### Summary

A callback for notifying an IExternalResourceServer that
shared coordinates changes have been saved back to one
of the Revit or DWG links provided by that server.

#### Remarks

Revit will call OnLocalLinkSharedCoordinatesSaved whenever
shared coordinates changes are saved to a linked document
which is provided by an external server. This is a notification
to the server provider so they can copy the updated link
back up to their server.

#### Since

2015

### `M:Autodesk.Revit.DB.LinkLoadContent.GetLinkLoadResult`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkLoadContent.GetLinkLoadResult`

#### Summary

Retrieves the LinkLoadResult of the attempt to load or reload a Revit link.

#### Remarks

A LinkLoadResult object is included in the LinkLoadContent class so that
IExternalResourceUIServers will have additional information about the status of the
link to display to the user.

The LinkLoadResult is added to the LinkLoadContent object during the load operation,
after the IExternalResourceServer LoadResource method has been called.
Consequently, this method will return NULL if called from the LoadResource method
of an IExternalResourceServer.

#### Returns

A LinkLoadObject containing the status and other information about an attempt by Revit
to load a Revit link.

#### Since

2015

### `M:Autodesk.Revit.DB.LinkLoadContent.SetLinkDataPath(Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkLoadContent.SetLinkDataPath(Autodesk.Revit.DB.ModelPath)`

#### Summary

Sets the Link data path owned by this LinkLoadContent object.

#### Remarks

This path must be a location accessible to Revit. Revit will
attempt to load the link from this location.

#### Parameter `linkPath`

The Links data path set for this LinkLoadContent object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.LinkLoadContent.GetLinkDataPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkLoadContent.GetLinkDataPath`

#### Summary

Returns the Link data path owned by this LinkLoadContent object.

#### Remarks

This path represents the physical location of the
link. Revit will attempt to load the link from this
location.

#### Returns

The Links data path owned by this LinkLoadContent object.

#### Since

2015

### `T:Autodesk.Revit.DB.LinkLoadContent`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinkLoadContent`

#### Summary

This class is used by IExternalResourceServers to return Link data to Revit when their
LoadResource method is invoked. It also contains additional information used by
IExternalResourceUIServers to display link load status results to the user.

#### Remarks

This class handles Revit links.

Revit links must be loaded from a path accessible to Revit.
Server implementors should provide Revit with a ModelPath representing
a location from which to load the link. Revit will handle the actual
file loading.

Servers which represent non-local file locations will need to
create their own implementation for copying
or moving files to a Revit-accessible location.

The link data path used for link loading may be different from
the path displayed to the
user. The link data path represents the literal location of the
file, whereas the link's display path represents what the user sees
as the name of the link. See `!:Autodesk::Revit::DB::ExternalResourceReference::InSessionPath`
for more details on display paths.

#### Since

2015

### `M:Autodesk.Revit.DB.LinePattern.SetSegments(System.Collections.Generic.IList{Autodesk.Revit.DB.LinePatternSegment})`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinePattern.SetSegments(System.Collections.Generic.IList{Autodesk.Revit.DB.LinePatternSegment})`

#### Summary

Sets the sequence of segments that defines this line pattern.

#### Parameter `lineSegs`

The sequence of segments.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.LinePattern.GetSegments`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinePattern.GetSegments`

#### Summary

Gets the sequence of segments that defines this line pattern.

#### Returns

The sequence of segments.

### `P:Autodesk.Revit.DB.LinePattern.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinePattern.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.LinePattern.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinePattern.Name`

#### Summary

Line pattern name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `M:Autodesk.Revit.DB.LinePattern.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinePattern.#ctor(System.String)`

#### Summary

Creates a line pattern with given name.

#### Parameter `name`

The name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.LinePattern.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinePattern.#ctor`

#### Summary

Creates a simple line pattern.

### `T:Autodesk.Revit.DB.LinePattern`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinePattern`

#### Summary

Represents a line pattern definition.

#### Remarks

A line pattern is a pattern of dashes and dots used to control the way the lines of an object are drawn in Revit.
Line patterns are used in the definition of GraphicsStyle objects.
A line pattern is defined by a repeating sequence segments.
Each segment is a dash, a dot or a space.
A line pattern definition must contain an even number of segments, starting with a visible segment (a dash or a dot) and alternating between visible segments and spaces.

### `P:Autodesk.Revit.DB.LinePatternSegment.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinePatternSegment.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.LinePatternSegment.Length`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinePatternSegment.Length`

#### Summary

Gets and sets the length of the segment.

#### Value

The length of the segment.

### `P:Autodesk.Revit.DB.LinePatternSegment.Type`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinePatternSegment.Type`

#### Summary

Gets and sets the type of the segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.LinePatternSegment.#ctor(Autodesk.Revit.DB.LinePatternSegmentType,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinePatternSegment.#ctor(Autodesk.Revit.DB.LinePatternSegmentType,System.Double)`

#### Summary

Creates a line pattern segment with given type and length.

#### Parameter `type`

The segment type.

#### Parameter `length`

The length.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

### `M:Autodesk.Revit.DB.LinePatternSegment.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinePatternSegment.#ctor`

#### Summary

Creates a line pattern segment.

### `T:Autodesk.Revit.DB.LinePatternSegment`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinePatternSegment`

#### Summary

Represents a segment in a line pattern.

### `T:Autodesk.Revit.DB.LinePatternSegmentType`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinePatternSegmentType`

#### Summary

Represents the type of a line pattern segment.

### `F:Autodesk.Revit.DB.LinePatternSegmentType.Dot`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinePatternSegmentType.Dot`

#### Summary

A dot

### `F:Autodesk.Revit.DB.LinePatternSegmentType.Space`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinePatternSegmentType.Space`

#### Summary

A space

### `F:Autodesk.Revit.DB.LinePatternSegmentType.Dash`

Member kind: field
Symbol: `Autodesk.Revit.DB.LinePatternSegmentType.Dash`

#### Summary

A dash

### `M:Autodesk.Revit.DB.Structure.LineLoad.SetCurve(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.SetCurve(Autodesk.Revit.DB.Curve)`

#### Summary

Sets the curve for the line load.

#### Remarks

The curve must be bounded.
The curve can be:
Line

Arc

Ellipse

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve is not bound.
-or-
The provided curve is not supported.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This LineLoad is not a hosted load.
-or-
This LineLoad is a constrained load.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.LineLoad.SetPoints(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.SetPoints(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Sets start and end point of the line load.

#### Remarks

This method works with hosted line load only.
This method works for loads which are not constrained to their host.
The curve of the resulted load will be a line.

#### Parameter `startPoint`

The start point.

#### Parameter `endPoint`

The end point.

#### Returns

Returns true if successful, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the end point is equal to the start point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This LineLoad is not a hosted load.
-or-
This LineLoad is a constrained load.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.LineLoad.GetCurve`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.GetCurve`

#### Summary

Returns curve that define geometry of the line load.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.LineLoad.IsCurveInsideHostBoundaries(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.IsCurveInsideHostBoundaries(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Curve)`

#### Summary

Indicates if the curve is inside panel's boundaries or on panel's edges or if the curve is on the member's curve.

#### Parameter `doc`

The document containing both the host and the line load.

#### Parameter `hostId`

The id of the analytical element that is about to host a line load.

#### Parameter `curve`

Curve to be checked.

#### Returns

True if a line load can be placed on the input host id

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.LineLoad.IsValidHostId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.IsValidHostId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Indicates if the provided host id can host line loads
The document containing both the host and the load
The id of the analytical element that is about to host a line load
True if a line load can be placed on the input host id

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.LineLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.LineLoadType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.LineLoadType)`

#### Summary

Creates a new custom line load within the project.

#### Remarks

The curve must be bounded.
The curve can be:
Line

Arc

Ellipse

#### Parameter `document`

Document to which new line load will be added.

#### Parameter `hostElemId`

The analytical host element for the line Load.

#### Parameter `curve`

Curve of the line load.

#### Parameter `forceVector1`

The applied 3d force vector.

#### Parameter `momentVector1`

The applied 3d moment vector.

#### Parameter `symbol`

The symbol of the LineLoad. Set `null` to use default type.

#### Returns

If successful, returns the newly created LineLoad, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element hostElemId does not exist in the document
-or-
hostElemId is not permitted for this type of load.
-or-
The provided curve is not supported.
-or-
The input curve is not bound.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown when all force and moment vectors are equal zero.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if type could not be set for newly created line load.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.LineLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.LineLoadType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Int32,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.LineLoadType)`

#### Summary

Creates a new hosted line load within the project.

#### Parameter `document`

Document to which new line load will be added.

#### Parameter `hostElemId`

The analytical host element for the line Load.

#### Parameter `curveIndex`

The index of a curve in analytical surface element starting from 0.
Use `!:Autodesk::Revit::DB::Structure::AnalyticalSurfaceBase::GetOuterContour` method to obtain appropriate curve index.
Curve index has a unique value in analytical element. The index should be obtain by iteration through all curves in all loops.

#### Parameter `forceVector1`

The applied 3d force vector.

#### Parameter `momentVector1`

The applied 3d moment vector.

#### Parameter `symbol`

The symbol of the LineLoad. Set `null` to use default type.

#### Returns

If successful, returns the newly created LineLoad, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element hostElemId does not exist in the document
-or-
hostElemId is not permitted for this type of load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown when all force and moment vectors are equal zero.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if type could not be set for newly created line load.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.LineLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.LineLoadType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.LineLoadType)`

#### Summary

Creates a new hosted line load within the project.

#### Parameter `document`

Document to which new line load will be added.

#### Parameter `hostElemId`

The analytical host element for the line Load.

#### Parameter `forceVector1`

The applied 3d force vector.

#### Parameter `momentVector1`

The applied 3d moment vector.

#### Parameter `symbol`

The symbol of the LineLoad. Set `null` to use default type.

#### Returns

If successful, returns the newly created LineLoad, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element hostElemId does not exist in the document
-or-
hostElemId is not permitted for this type of load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown when all force and moment vectors are equal zero.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if type could not be set for newly created line load.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.LineLoad.MomentVector2`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.MomentVector2`

#### Summary

The moment vector applied to the end point of the line load, oriented according to OrientTo setting.

#### Remarks

The default force unit is kN-m/m for metric, and kip-ft/ft for imperial.
Use UnitUtils class methods to convert value from or to internal units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LineLoad.MomentVector1`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.MomentVector1`

#### Summary

The moment vector applied to the start point of the line load, oriented according to OrientTo setting.

#### Remarks

The default force unit is kN-m/m for metric, and kip-ft/ft for imperial.
Use UnitUtils class methods to convert value from or to internal units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LineLoad.ForceVector2`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.ForceVector2`

#### Summary

The force vector applied to the end point of the line load, oriented according to OrientTo setting.

#### Remarks

The default force unit is kN/m for metric, and kip/ft for imperial.
Use UnitUtils class methods to convert value from or to internal units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LineLoad.ForceVector1`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.ForceVector1`

#### Summary

The force vector applied to the start point of the line load, oriented according to OrientTo setting.

#### Remarks

The default force unit is kN/m for metric, and kip/ft for imperial.
Use UnitUtils class methods to convert value from or to internal units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LineLoad.EndPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.EndPoint`

#### Summary

Returns the three dimensional location of the end point for the line load.

#### Remarks

The location of the end point is measured in decimal feet.

### `P:Autodesk.Revit.DB.Structure.LineLoad.StartPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.StartPoint`

#### Summary

Returns the three dimensional location of the start point for the line load.

#### Remarks

The location of the start point is measured in decimal feet.

### `P:Autodesk.Revit.DB.Structure.LineLoad.IsProjected`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.IsProjected`

#### Summary

Indicates if the load is projected.

#### Remarks

Returns true if the line load is projected, false otherwise.
This parameter will take effect only if LineLoad.OrientTo property is set to LoadOrientTo.Project.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.LineLoad.IsUniform`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.LineLoad.IsUniform`

#### Summary

Indicates if the load is uniform.

#### Remarks

Returns true if the line load is uniform, false otherwise.
Load is uniform when force and moment vectors assigned to the start and the end point of load are equal.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.LineLoad`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.LineLoad`

#### Summary

An object that represents a force/moment applied in a linear manner.

#### Remarks

The load/moment may be uniform or it may vary between the two ends of the line.

### `P:Autodesk.Revit.DB.Lighting.LineLightShape.EmitLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.LineLightShape.EmitLength`

#### Summary

The emit length.

#### Value

The emit length as a numerical value in feet between 1.0e-9 and 30000.0

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The shape dimension is not valid because it is not between 1.0e-9 and 30000.0.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LineLightShape.#ctor(Autodesk.Revit.DB.Lighting.LineLightShape)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LineLightShape.#ctor(Autodesk.Revit.DB.Lighting.LineLightShape)`

#### Summary

Creates a copy of the given line light shape

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LineLightShape.#ctor(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LineLightShape.#ctor(System.Double)`

#### Summary

Creates a line light shape object with the given emit length.

#### Parameter `emitLength`

The emit length as a numerical value in feet between 1.0e-9 and 30000.0

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The shape dimension is not valid because it is not between 1.0e-9 and 30000.0.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LineLightShape.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LineLightShape.#ctor`

#### Summary

Creates a line light shape object with 2.0' emit length.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.LineLightShape`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.LineLightShape`

#### Summary

This class encapsulates a line light shape.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.InitialIntensity.Clone`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.InitialIntensity.Clone`

#### Summary

Creates a copy of the InitialIntensity derived object.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.InitialIntensity.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.InitialIntensity.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Lighting.InitialIntensity.InitialIntensityValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.InitialIntensity.InitialIntensityValue`

#### Summary

The calculated initial intensity value.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.InitialIntensity`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.InitialIntensity`

#### Summary

This class is the base class for calculating lighting initial intensity.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.InitialColor.Clone`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.InitialColor.Clone`

#### Summary

Creates a copy of the InitialColor derived object.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.InitialColor.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.InitialColor.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Lighting.InitialColor.TemperatureValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.InitialColor.TemperatureValue`

#### Summary

The light color temperature value in Kelvins.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.InitialColor`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.InitialColor`

#### Summary

This class is the base class for calculating initial light color.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightGroup.GetLights`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightGroup.GetLights`

#### Summary

Get the set of contained light instances
The set of light instances

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightGroup.RemoveLight(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightGroup.RemoveLight(Autodesk.Revit.DB.ElementId)`

#### Summary

Remove the given light instance from the set of light instances in this group

#### Parameter `lightId`

The light instance to remove

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The light instance is not in this LightGroup

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightGroup.AddLight(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightGroup.AddLight(Autodesk.Revit.DB.ElementId)`

#### Summary

Add a new light instance to the group

#### Parameter `lightId`

The ID of the light instance to add to the group

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element ID does not correspond to a light instance
-or-
The light instance is in this LightGroup

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.LightGroup.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.LightGroup.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Lighting.LightGroup.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.LightGroup.Id`

#### Summary

The ElementId of the LightGroup

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.LightGroup.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.LightGroup.Name`

#### Summary

The name of the LightGroup

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
When setting this property: The name is not valid because it is not unique within this LightGroupManager

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.LightGroup`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.LightGroup`

#### Summary

This class represents a set of lights grouped together for easier management of various lighting scenarios

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightGroupManager.SetLightDimmer(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightGroupManager.SetLightDimmer(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Sets the dimmer value for the given light for rendering the given view

#### Remarks

The dimmer value is in the range [0.0, 1.0] with 0.0 being totally dimmed and 1.0 being totally on

#### Parameter `viewId`

The Id of the view

#### Parameter `lightId`

The Id of the light to turn on or off

#### Parameter `dimmingValue`

The dimmer value to set int the range of [0.0, 1.0]

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element Id does not correspond to a 3d view
-or-
The given element Id does not correspond to a light instance
-or-
The given dimming value is not in the range [0.0, 1.0]

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightGroupManager.GetLightDimmer(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightGroupManager.GetLightDimmer(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the dimmer value for the given light for rendering the given view

#### Remarks

The dimmer value is in the range [0.0, 1.0] with 0.0 being totally dimmed and 1.0 being totally on

#### Parameter `viewId`

The Id of the view

#### Parameter `lightId`

The Id of the light to turn on or off

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element Id does not correspond to a 3d view
-or-
The given element Id does not correspond to a light instance

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightGroupManager.SetLightOn(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightGroupManager.SetLightOn(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Turns the given light on or off for rendering the given view depending on the bool argument

#### Parameter `viewId`

The Id of the view

#### Parameter `lightId`

The Id of the light to turn on or off

#### Parameter `turnOn`

Turns the light on if true, off if false

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element Id does not correspond to a 3d view
-or-
The given element Id does not correspond to a light instance

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightGroupManager.IsLightOn(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightGroupManager.IsLightOn(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns true if the given light is on for rendering the given view

#### Parameter `viewId`

The Id of the view

#### Parameter `lightId`

The Id of the light

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element Id does not correspond to a 3d view
-or-
The given element Id does not correspond to a light instance

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightGroupManager.SetLightGroupOn(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightGroupManager.SetLightGroupOn(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Turns the given light group on or off for rendering the given view depending on the bool argument

#### Parameter `viewId`

The Id of the view

#### Parameter `groupId`

The Id of the light group

#### Parameter `turnOn`

Turns the light group on if true, off if false

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element Id does not correspond to a 3d view
-or-
The given element Id does not correspond to a light group

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightGroupManager.IsLightGroupOn(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightGroupManager.IsLightGroupOn(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns true if the given light group is on

#### Parameter `viewId`

The Id of the view

#### Parameter `groupId`

The Id of the light group

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element Id does not correspond to a 3d view
-or-
The given element Id does not correspond to a light group

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightGroupManager.GetGroups`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightGroupManager.GetGroups`

#### Summary

Get the set of contained LightGroup objects
The set of LightGroup objects

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightGroupManager.DeleteGroup(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightGroupManager.DeleteGroup(Autodesk.Revit.DB.ElementId)`

#### Summary

Remove the given LightGroup object from the set of LightGroup objects

#### Remarks

Note that only the group is deleted, not the lights contained in the group
The lights will still exist but will not be in a group any longer

#### Parameter `groupId`

The Id of the LightGroup object to remove

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element Id does not correspond to a light group
-or-
The LightGroup is not contained by this LightGroupManager

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightGroupManager.CreateGroup(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightGroupManager.CreateGroup(System.String)`

#### Summary

Create a new LightGroup object with the given name

#### Parameter `name`

The name to use for the new LightGroup object

#### Returns

The new LightGroup object that was created

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The name is not valid because it is not unique within this LightGroupManager
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightGroupManager.GetLightGroupManager(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightGroupManager.GetLightGroupManager(Autodesk.Revit.DB.Document)`

#### Summary

Creates a light group manager object from the given document

#### Parameter `document`

The document the manager is from

#### Returns

The newly created Light group manager object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The document is not valid because it is not a project (rvt) document

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.LightGroupManager.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.LightGroupManager.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Lighting.LightGroupManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.LightGroupManager`

#### Summary

This class represents a set of light groups that are used for easier management of various lighting scenarios

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightType.SetLossFactor(Autodesk.Revit.DB.Lighting.LossFactor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightType.SetLossFactor(Autodesk.Revit.DB.Lighting.LossFactor)`

#### Summary

Replace the current loss factor object with the given object

#### Remarks

The argument object is cloned

#### Parameter `lossFactor`

An object derived from a LossFactor object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightType.GetLossFactor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightType.GetLossFactor`

#### Summary

Return a copy of an object derived from LossFactor

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightType.SetInitialIntensity(Autodesk.Revit.DB.Lighting.InitialIntensity)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightType.SetInitialIntensity(Autodesk.Revit.DB.Lighting.InitialIntensity)`

#### Summary

Replace the current initial intensity object with the given object

#### Remarks

The argument object is cloned

#### Parameter `initialIntensity`

An object derived from an InitialIntensity object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightType.GetInitialIntensity`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightType.GetInitialIntensity`

#### Summary

Return a copy of an object derived from InitialIntensity

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightType.SetInitialColor(Autodesk.Revit.DB.Lighting.InitialColor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightType.SetInitialColor(Autodesk.Revit.DB.Lighting.InitialColor)`

#### Summary

Replace the current initial color object with the given object

#### Remarks

The argument object is cloned

#### Parameter `initialColor`

An object derived from an InitialColor object
The object pointed to is cloned internally

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightType.GetInitialColor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightType.GetInitialColor`

#### Summary

Return a copy of an object derived from InitialColor

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightType.SetLightDistribution(Autodesk.Revit.DB.Lighting.LightDistribution)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightType.SetLightDistribution(Autodesk.Revit.DB.Lighting.LightDistribution)`

#### Summary

Replace the current LightDistribution object with the given object

#### Remarks

The argument object is cloned
Light distribution is a family element parameter. All other LightType properties and methods except for light shape are
family type parameters. Changes to family type parameters may not be committed in the same transaction with changes to
family element parameters, otherwise the modifications to the family type may be lost. Always use a separate transaction
for changes to the shape and distribution of a light.

#### Parameter `lightDistribution`

An instance of an object derived from LightDistribution

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The LightDistribution is the argument that is being validated
The LightDistribution is not valid because it of a different derived type than the current LightDistribution derived type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightType.GetLightDistribution`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightType.GetLightDistribution`

#### Summary

Return a copy of an object derived from LightDistribution

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightType.SetLightShape(Autodesk.Revit.DB.Lighting.LightShape)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightType.SetLightShape(Autodesk.Revit.DB.Lighting.LightShape)`

#### Summary

Replace the current LightShape object with the given object

#### Remarks

The argument object is cloned.
Light shape is a family element parameter. All other LightType properties and methods except for light distribution are
family type parameters. Changes to family type parameters may not be committed in the same transaction with changes to
family element parameters, otherwise the modifications to the family type may be lost. Always use a separate transaction
for changes to the shape and distribution of a light.

#### Parameter `lightShape`

An instance of an object derived from LightShape

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The LightShape is the argument that is being validated
The LightShape is not valid because it of a different derived type than the current LightShape derived type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightType.GetLightShape`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightType.GetLightShape`

#### Summary

Return a copy of an object derived from LightShape

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightType.GetLightTypeFromInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightType.GetLightTypeFromInstance(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a light type object from the given document and element ID

#### Parameter `document`

The document the instanceId is from

#### Parameter `instanceId`

The ID of the light fixture instance

#### Returns

The newly created LightType object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId is the argument that is being validated
The ElementId is not valid because it is not for a light element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightType.GetLightType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightType.GetLightType(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a light type object from the given document and family type ID

#### Parameter `document`

The document the typeId is from

#### Parameter `typeId`

The ID of the light family type

#### Returns

The newly created LightType object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId is the argument that is being validated
The ElementId is not valid because it is not for a light element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.LightType.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.LightType.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Lighting.LightType.DimmingColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.LightType.DimmingColor`

#### Summary

The dimming temperature value in Kelvins.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.LightType.ColorFilter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.LightType.ColorFilter`

#### Summary

The light filter color.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.LightType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.LightType`

#### Summary

This class encapsulates light information.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightFamily.GetLightType(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightFamily.GetLightType(System.Int32)`

#### Summary

Return a LightType object for the light type at the given index

#### Parameter `index`

The index of the light type

#### Returns

A LightType object for the light type at the given index

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The index is the argument that is being validated
The index is not valid because it does not correspond to a valid light type

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightFamily.GetLightTypeName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightFamily.GetLightTypeName(System.Int32)`

#### Summary

Return the name for the light type at the given index

#### Parameter `index`

The index of the light type

#### Returns

The name of the light type at the given index

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The index is the argument that is being validated
The index is not valid because it does not correspond to a valid light type

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightFamily.GetNumberOfLightTypes`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightFamily.GetNumberOfLightTypes`

#### Summary

Return the number of light types contained in this light family

#### Returns

The number of light types contained in this light family

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightFamily.GetLightSourceTransform`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightFamily.GetLightSourceTransform`

#### Summary

Returns a Transform value for the transform of light source.

#### Remarks

When the user moves or rotates the light source in family editor,
the returned Transform gets changed accordingly.

#### Returns

The light source transform.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightFamily.SetLightDistributionStyle(Autodesk.Revit.DB.Lighting.LightDistributionStyle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightFamily.SetLightDistributionStyle(Autodesk.Revit.DB.Lighting.LightDistributionStyle)`

#### Summary

Set the light distribution style to the given shape distribution

#### Parameter `lightDistributionStyle`

The light distribution style to set the light distribution type to

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightFamily.GetLightDistributionStyle`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightFamily.GetLightDistributionStyle`

#### Summary

Returns a LightDistributionStyle value for the light distribution

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightFamily.SetLightShapeStyle(Autodesk.Revit.DB.Lighting.LightShapeStyle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightFamily.SetLightShapeStyle(Autodesk.Revit.DB.Lighting.LightShapeStyle)`

#### Summary

Set the light shape style to the given shape style

#### Parameter `lightShapeStyle`

The light shape style value to set the light shape style to

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightFamily.GetLightShapeStyle`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightFamily.GetLightShapeStyle`

#### Summary

Returns a LightShapeStyle value for the light shape

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.LightFamily.GetLightFamily(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.LightFamily.GetLightFamily(Autodesk.Revit.DB.Document)`

#### Summary

Creates a light family object from the given family document

#### Parameter `document`

The family document

#### Returns

The newly created LightFamily object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The Document is the argument that is being validated
The document is not valid because it is not a light family document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.LightFamily.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.LightFamily.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Lighting.LightFamily`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.LightFamily`

#### Summary

This class encapsulates light family information.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.LightShapeStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.LightShapeStyle`

#### Summary

Tags for specific light shape styles

#### Since

2013

### `F:Autodesk.Revit.DB.Lighting.LightShapeStyle.Circle`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.LightShapeStyle.Circle`

#### Summary

Circular light shape.

### `F:Autodesk.Revit.DB.Lighting.LightShapeStyle.Rectangle`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.LightShapeStyle.Rectangle`

#### Summary

Rectangular light shape.

### `F:Autodesk.Revit.DB.Lighting.LightShapeStyle.Line`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.LightShapeStyle.Line`

#### Summary

Line light shape.

### `F:Autodesk.Revit.DB.Lighting.LightShapeStyle.Point`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.LightShapeStyle.Point`

#### Summary

Point light shape.

### `T:Autodesk.Revit.DB.Lighting.LightDistributionStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.LightDistributionStyle`

#### Summary

Tags for specific light distribution styles

#### Since

2013

### `F:Autodesk.Revit.DB.Lighting.LightDistributionStyle.PhotometricWeb`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.LightDistributionStyle.PhotometricWeb`

#### Summary

Photometric web (IES) light distribution.

### `F:Autodesk.Revit.DB.Lighting.LightDistributionStyle.Spot`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.LightDistributionStyle.Spot`

#### Summary

Spot light distribution.

### `F:Autodesk.Revit.DB.Lighting.LightDistributionStyle.Hemispherical`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.LightDistributionStyle.Hemispherical`

#### Summary

Hemispherical light distribution.

### `F:Autodesk.Revit.DB.Lighting.LightDistributionStyle.Spherical`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.LightDistributionStyle.Spherical`

#### Summary

Spherical light distribution.

### `T:Autodesk.Revit.DB.Lighting.LightDimmingColor`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.LightDimmingColor`

#### Summary

Tags for specific light dimming colors

#### Since

2013

### `F:Autodesk.Revit.DB.Lighting.LightDimmingColor.Incandescent`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.LightDimmingColor.Incandescent`

#### Summary

Incandescent lamp curve dimming color.

### `F:Autodesk.Revit.DB.Lighting.LightDimmingColor.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.LightDimmingColor.None`

#### Summary

No dimming color.

### `M:Autodesk.Revit.DB.LevelAssociationData.SetLevelOffset(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LevelAssociationData.SetLevelOffset(System.Double)`

#### Summary

Sets the offset from the Associated Level.

#### Parameter `offset`

The offset from the Level.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

this operation failed.

#### Since

2023

### `M:Autodesk.Revit.DB.LevelAssociationData.GetLevelAssociationData(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LevelAssociationData.GetLevelAssociationData(Autodesk.Revit.DB.Element)`

#### Summary

Returns LevelAssociationData associated with this element, if it exists.

#### Remarks

If the input element doesn't have LevelAssociationData than it retuns `null` .

#### Parameter `element`

The element from which we try to obtain LevelAssociationData.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.LevelAssociationData.GetLevelOffset`

Member kind: method
Symbol: `Autodesk.Revit.DB.LevelAssociationData.GetLevelOffset`

#### Summary

Returns the offset from the Associated Level.

#### Since

2023

### `M:Autodesk.Revit.DB.LevelAssociationData.SetAssociatedLevel(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LevelAssociationData.SetAssociatedLevel(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the Associated Level.

#### Parameter `levelId`

The id of the Level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

this operation failed.

#### Since

2023

### `M:Autodesk.Revit.DB.LevelAssociationData.GetAssociatedLevel`

Member kind: method
Symbol: `Autodesk.Revit.DB.LevelAssociationData.GetAssociatedLevel`

#### Summary

Returns the Associated Level id.

#### Since

2023

### `P:Autodesk.Revit.DB.LevelAssociationData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.LevelAssociationData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.LevelAssociationData`

Member kind: type
Symbol: `Autodesk.Revit.DB.LevelAssociationData`

#### Summary

This class holds information related to Level.

#### Since

2023

### `M:Autodesk.Revit.DB.LabelUtils.GetStructuralSectionShapeName(Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionShape)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetStructuralSectionShapeName(Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionShape)`

#### Summary

Gets the user-visible name for a StructuralSectionShape.

#### Parameter `shape`

The StructuralSectionShape to get the user-visible name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.Analysis.gbXMLBuildingType,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.Analysis.gbXMLBuildingType,Autodesk.Revit.DB.Document)`

#### Summary

Gets the user-visible name for a gbXMLBuildingType.

#### Remarks

The name is obtained in the current Revit language.

#### Parameter `buildingType`

The gbXMLBuildingType to get the user-visible name.

#### Parameter `document`

The document from which to get the gbXMLBuildingType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input gXMLBuildingType is not available in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelForDiscipline(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelForDiscipline(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the user-visible name for a discipline.

#### Remarks

The name is obtained in the current Revit language.

#### Parameter `disciplineTypeId`

Identifier of the discipline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Discipline must have a definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelForSymbol(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelForSymbol(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the user-visible name for a symbol.

#### Remarks

The name is obtained in the current Revit language.

#### Parameter `symbolTypeId`

Identifier of the symbol to get the user-visible name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Symbol must have a definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelForSpec(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelForSpec(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the user-visible name for a spec.

#### Remarks

The name is obtained in the current Revit language.
If the given identifier is a category, this method returns the name
of the Family Type spec with that category, e.g. "Family Type: Walls".

#### Parameter `specTypeId`

Identifier of the spec to get the user-visible name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given identifier is neither a spec nor a category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelForUnit(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelForUnit(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the user-visible name for a unit.

#### Remarks

The name is obtained in the current Revit language.

#### Parameter `unitTypeId`

Identifier of the unit to get the user-visible name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Cannot find DisplayUnitTypeInfo for the given unit identifier.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.LabelUtils.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.LabelUtils.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.Plumbing.PipeFlowState,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.Plumbing.PipeFlowState,Autodesk.Revit.DB.Document)`

#### Summary

Gets the user-visible name for a PipeFlowState.

#### Parameter `pipeFlowState`

The PipeFlowState to get the user-visible name.

#### Parameter `doc`

The document from which to get the PipeFlowState.

#### Remarks

The name is obtained in the current Revit language.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when information for the input PipeFlowState cannot be found.

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.Plumbing.PipeLossMethodType,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.Plumbing.PipeLossMethodType,Autodesk.Revit.DB.Document)`

#### Summary

Gets the user-visible name for a PipeLossMethodType.

#### Parameter `pipeLossMethodType`

The PipeLossMethodType to get the user-visible name.

#### Parameter `doc`

The document from which to get the PipeLossMethodType.

#### Remarks

The name is obtained in the current Revit language.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when information for the input PipeLossMethodType cannot be found.

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.Mechanical.DuctLossMethodType,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.Mechanical.DuctLossMethodType,Autodesk.Revit.DB.Document)`

#### Summary

Gets the user-visible name for a DuctLossMethodType.

#### Parameter `ductLossMethodType`

The DuctLossMethodType to get the user-visible name.

#### Parameter `doc`

The document from which to get the DuctLossMethodType.

#### Remarks

The name is obtained in the current Revit language.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when information for the input DuctLossMethodType cannot be found.

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.BuiltInCategory)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.BuiltInCategory)`

#### Summary

Gets the user-visible name for a BuiltInCategory.

#### Parameter `builtInCategory`

The BuiltInCategory to get the user-visible name.

#### Remarks

The name is obtained in the current Revit language.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the builtin category is not valid.

#### Since

2020

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.BuiltInParameterGroup)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.BuiltInParameterGroup)`

#### Summary

Gets the user-visible name for a BuiltInParameterGroup.

#### Parameter `builtInParamGroup`

The BuiltInParameterGroup to get the user-visible name.

#### Remarks

The name is obtained in the current Revit language.

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelForGroup(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelForGroup(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the user-visible name for a built-in parameter group. To get the name of parameter group "Other", pass an empty, default-constructed ForgeTypeId.

#### Parameter `groupTypeId`

The identifier of the parameter group to get the user-visible name, or an empty ForgeTypeId for group "Other".

#### Remarks

The name is obtained in the current Revit language.

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.BuiltInParameter,Autodesk.Revit.ApplicationServices.LanguageType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.BuiltInParameter,Autodesk.Revit.ApplicationServices.LanguageType)`

#### Summary

Gets the user-visible name for a BuiltInParameter in a specific LanguageType.

#### Parameter `builtInParam`

The BuiltInParameter to get the user-visible name.

#### Parameter `language`

The desired LanguageType to get the user-visible name in.

#### Returns

The BuiltInParameter name in the desired LanguageType.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the BuiltInParameter cannot be found.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the desired LanguageType cannot be found for the BuiltInParameter name.

#### Since

2020

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelForBuiltInParameter(Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.ApplicationServices.LanguageType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelForBuiltInParameter(Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.ApplicationServices.LanguageType)`

#### Summary

Gets the user-visible name for a built-in parameter in a specific LanguageType.

#### Parameter `parameterTypeId`

Identifier of the built-in parameter to get the user-visible name.

#### Parameter `language`

The desired LanguageType to get the user-visible name in.

#### Returns

The built-in parameter name in the desired LanguageType.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the built-in parameter cannot be found.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the desired LanguageType cannot be found for the built-in parameter name.

#### Since

2020

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.BuiltInParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelFor(Autodesk.Revit.DB.BuiltInParameter)`

#### Summary

Gets the user-visible name for a BuiltInParameter.

#### Parameter `builtInParam`

The BuiltInParameter to get the user-visible name.

#### Remarks

The name is obtained in the current Revit language.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the BuiltInParameter cannot be found.

### `M:Autodesk.Revit.DB.LabelUtils.GetLabelForBuiltInParameter(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LabelUtils.GetLabelForBuiltInParameter(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Gets the user-visible name for a built-in parameter.

#### Parameter `parameterTypeId`

Identifier of the built-in parameter to get the user-visible name.

#### Remarks

The name is obtained in the current Revit language.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the built-in parameter cannot be found.

### `T:Autodesk.Revit.DB.LabelUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.LabelUtils`

#### Summary

Used to obtain user-visible names for enums.

#### Since

2011

### `M:Autodesk.Revit.DB.Visual.AssetUtils.ExtractRPCBlobFromAsset(Autodesk.Revit.DB.Visual.Asset,System.IntPtr,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetUtils.ExtractRPCBlobFromAsset(Autodesk.Revit.DB.Visual.Asset,System.IntPtr,System.Int32)`

#### Summary

Extract the RPC property blob by giving Asset and write it into an input buffer.

#### Parameter `asset`

The asset to extract, only supports RPC assets.

#### Parameter `buffer`

The memory buffer to save the extracted data.
If it is null, it returns the required buffer size.

#### Parameter `bufferSize`

The buffer size of the memory to save the extracted data.
If it is 0, it returns the required buffer size.

#### Returns

The actual number of RPC property blob placed in the buffer (can be less than the
length of the buffer). If there are no enough memory buffer available, return 0.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

The asset parameter was NULL.

#### Since

2015

### `T:Autodesk.Revit.DB.Visual.AssetUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.AssetUtils`

#### Summary

A collection of utilities related to `T:Autodesk.Revit.DB.Visual.Asset` class.

#### Since

2015

### `P:Autodesk.Revit.DB.Visual.AssetPropertyInt64.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyInt64.Value`

#### Summary

Get the value of the property.

### `T:Autodesk.Revit.DB.Visual.AssetPropertyInt64`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyInt64`

#### Summary

Represents a property of Int64 value.

#### Since

2014

### `M:Autodesk.Revit.DB.Visual.AssetPropertyFloatArray.GetValue`

Member kind: method
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyFloatArray.GetValue`

#### Summary

Get the value of the property.

### `T:Autodesk.Revit.DB.Visual.AssetPropertyFloatArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyFloatArray`

#### Summary

Represents a property consisting of an array of float values.

#### Remarks

In virtually all cases, the array will contain exactly 3 values.

#### Since

2014

### `P:Autodesk.Revit.DB.Visual.AssetPropertyDoubleMatrix44.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyDoubleMatrix44.Value`

#### Summary

Get the value of the property

### `T:Autodesk.Revit.DB.Visual.AssetPropertyDoubleMatrix44`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyDoubleMatrix44`

#### Summary

Represents a property consisting of an array of double values.

#### Remarks

In virtually all cases, the array will contain exactly 16 values.
It represents a 4x4 matrix.

### `P:Autodesk.Revit.DB.Visual.AssetPropertyDoubleArray2d.Value`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyDoubleArray2d.Value`

#### Summary

Get the value of the property

### `T:Autodesk.Revit.DB.Visual.AssetPropertyDoubleArray2d`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.AssetPropertyDoubleArray2d`

#### Summary

Represents a property consisting of an array of double values.

#### Remarks

In virtually all cases, the array will contain exactly 2 values.

### `P:Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions.OutputFolder`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions.OutputFolder`

#### Summary

The path of the output folder for systems analysis.

#### Remarks

When requesting a new system analysis, it is okay to have an empty output folder in the SystemsAnalysisOption. In that case,
the ViewSystemsAnalysisReport would supply the output folder, typically at the system TEMP folder.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The analysis requires a valid output folder.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions.WeatherFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions.WeatherFile`

#### Summary

The file name of the EnergyPlus weather (*.epw).

#### Remarks

When requesting a new system analysis, it is okay to have an empty weather file in the SystemsAnalysisOption. In that case,
the ViewSystemsAnalysisReport would use the weather file at the current site location.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The analysis requires a valid EnergyPlus weather (.epw) file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `P:Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions.WorkflowFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions.WorkflowFile`

#### Summary

The file name of the EnergyPlus workflow script.

#### Remarks

When requesting a new system analysis, it is okay to have an empty workflowFile in the SystemsAnalysisOption. In that case,
the ViewSystemsAnalysisReport would supply the weather file with the default value "HVAC Systems Loads and Sizing.osw".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The analysis requires a valid workflow file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020.1

### `M:Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions.#ctor`

#### Summary

Constructs a new instance of the options.

#### Since

2020.1

### `T:Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions`

#### Summary

Contains the options for systems analysis.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Profile.transformGPolyCurve(GPolyCurve*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,Trf!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Profile.transformGPolyCurve(GPolyCurve*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,Trf!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Transforms all curves in the specified polycurve.

### `M:Autodesk.Revit.DB.Profile.Clone`

Member kind: method
Symbol: `Autodesk.Revit.DB.Profile.Clone`

#### Summary

Returns a copy of this profile.

### `P:Autodesk.Revit.DB.Profile.Transformed(Autodesk.Revit.DB.Transform)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Profile.Transformed(Autodesk.Revit.DB.Transform)`

#### Summary

Transforms this profile and returns the result.

#### Parameter `transform`

The transformation used to transform the profile.

#### Returns

The transformed profile.

#### Remarks

Transforms all the curves that define the boundary of this profile.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the handle of the specified transformation is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when failed to transform a curve in the profile.

### `P:Autodesk.Revit.DB.Profile.Curves`

Member kind: property
Symbol: `Autodesk.Revit.DB.Profile.Curves`

#### Summary

Retrieve the curves that make up the boundary of the profile.

### `P:Autodesk.Revit.DB.Profile.Filled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Profile.Filled`

#### Summary

Get or set whether the profile is filled.

### `T:Autodesk.Revit.DB.Profile`

Member kind: type
Symbol: `Autodesk.Revit.DB.Profile`

#### Summary

A geometric profile consisting of a loop of curves.

#### Remarks

The profile may be filled.

### `M:Autodesk.Revit.DB.RevolvedSurface.IsValidProfileCurve(Autodesk.Revit.DB.Frame,Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevolvedSurface.IsValidProfileCurve(Autodesk.Revit.DB.Frame,Autodesk.Revit.DB.Curve)`

#### Summary

Checks if the input profile curve is valid to create a surface of revolution in the given frame of reference.

#### Remarks

The validity is defined as follows:
The profile curve is bounded and non-degenerate.

It is co-planar with the axis of revolution.

It lies on the xz plane of the frame.

It lies on the right side of the axis.

Only the end points of the profile curve can touch the axis.

#### Parameter `frameOfReference`

frameOfReference is an orthonormal frame that defines a local coordinate system for the surface of revolution.
The frame can be "right-handed" or "left-handed".

The origin of the frame is the base of point of the axis of revolution.

The BasisZ of the frame is the direction of the axis.

#### Parameter `profileCurve`

The profile curve.

#### Returns

True if the profile curve is valid; False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.RevolvedSurface.IsValidProfileCurve(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevolvedSurface.IsValidProfileCurve(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Curve)`

#### Summary

Checks if the input profile curve is valid to create a surface of revolution around the given axis.

#### Remarks

The validity is defined as follows:
The profile curve is bounded and non-degenerate.

It is co-planar with the axis of revolution.

It lies on only one side of the axis.

Only the end points of the profile curve can touch the axis.

#### Parameter `axisBasePoint`

The base point of the axis of revolution.

#### Parameter `axisDirection`

The direction of the axis.

#### Parameter `profileCurve`

The profile curve.

#### Returns

True if the profile curve is valid; False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.RevolvedSurface.GetProfileCurveInWorldCoordinates`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevolvedSurface.GetProfileCurveInWorldCoordinates`

#### Summary

Returns a copy of the profile curve expressed in the world coordinate system.

#### Returns

A copy of the profile curve in the world coordinate system.

#### Since

2017_subscription_update

### `M:Autodesk.Revit.DB.RevolvedSurface.GetProfileCurve`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevolvedSurface.GetProfileCurve`

#### Summary

Returns a copy of the profile curve expressed in the surface's coordinate system.

#### Returns

A copy of the profile curve.

#### Since

2017

### `M:Autodesk.Revit.DB.RevolvedSurface.Create(Autodesk.Revit.DB.Frame,Autodesk.Revit.DB.Curve,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevolvedSurface.Create(Autodesk.Revit.DB.Frame,Autodesk.Revit.DB.Curve,System.Double,System.Double)`

#### Summary

Creates a Surface object coincident with the surface of revolution defined by a coordinate frame, a profile curve,
and start and end angles of revolution.

#### Remarks

The returned surface may not be of type RevolvedSurface - this function will create a surface of the simplest possible
type (Plane, Cylinder, etc.) that can be used to represent the required surface of revolution.
Given that the surface may be simplified, this function does not guarantee any particular parameterization of the surface.

#### Parameter `frameOfReference`

frameOfReference is an orthonormal frame that defines a local coordinate system for the surface of revolution.
The frame can be "right-handed" or "left-handed".

The origin of the frame is the base of point of the axis of revolution.

The BasisZ of the frame is the direction of the axis.

#### Parameter `profileCurve`

The profile curve, which should satisfy the following conditions:
It is bounded and non-degenerate.

It is co-planar with the axis of revolution.

It lies on the xz plane of the frame.

It lies on the right side of the axis.

Only the end points of the profile curve can touch the axis.

#### Parameter `startAngle`

Start angle of rotation.
The angles are measured around the axis of revolution, using the right-hand rule.
The profile curve is at the zero angle.

#### Parameter `endAngle`

End angle of rotation.
Start angle must be less than end angle and their difference must be less than or equal to two times PI.

#### Returns

The created surface. Note that this surface may not be of type RevolvedSurface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This Frame object may not be used as a local frame of reference.
-or-
The input profile curve is not valid to create a surface revolution in the given frame.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Start angle must be less than end angle and their difference must be less than or equal to two times PI.

#### Since

2017

### `M:Autodesk.Revit.DB.RevolvedSurface.Create(Autodesk.Revit.DB.Frame,Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevolvedSurface.Create(Autodesk.Revit.DB.Frame,Autodesk.Revit.DB.Curve)`

#### Summary

Creates a Surface object coincident with the surface of revolution defined by a coordinate frame and a profile curve.

#### Remarks

The returned surface may not be of type RevolvedSurface - this function will create a surface of the simplest possible
type (Plane, Cylinder, etc.) that can be used to represent the required surface of revolution.
Given that the surface may be simplified, this function does not guarantee any particular parameterization of the surface.

#### Parameter `frameOfReference`

frameOfReference is an orthonormal frame that defines a local coordinate system for the surface of revolution.
The frame can be "right-handed" or "left-handed".

The origin of the frame is the base of point of the axis of revolution.

The BasisZ of the frame is the direction of the axis.

#### Parameter `profileCurve`

The profile curve, which should satisfy the following conditions:
It is bounded and non-degenerate.

It is co-planar with the axis of revolution.

It lies on the xz plane of the frame.

It lies on the right side of the axis.

Only the end points of the profile curve can touch the axis.

#### Returns

The created surface. Note that this surface may not be of type RevolvedSurface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This Frame object may not be used as a local frame of reference.
-or-
The input profile curve is not valid to create a surface revolution in the given frame.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.RevolvedSurface.Create(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Curve,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevolvedSurface.Create(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Curve,System.Double,System.Double)`

#### Summary

Creates a Surface object coincident with the surface of revolution defined by an axis, a profile curve,
and start and end angles of revolution.

#### Remarks

The returned surface may not be of type RevolvedSurface - this function will create a surface of the simplest possible
type (Plane, Cylinder, etc.) that can be used to represent the required surface of revolution.
Given that the surface may be simplified, this function does not guarantee any particular parameterization of the surface.

#### Parameter `axisBasePoint`

The base point of the axis of revolution. Expected to lie within the Revit design limits `M:Autodesk.Revit.DB.XYZ.IsWithinLengthLimits(Autodesk.Revit.DB.XYZ)` .

#### Parameter `axisDirection`

The direction of the axis.

#### Parameter `profileCurve`

The profile curve, which should satisfy the following conditions:
It is bounded and non-degenerate.

It is co-planar with the axis of revolution.

It lies on only one side of the axis.

Only the end points of the profile curve can touch the axis.

#### Parameter `startAngle`

Start angle of rotation.
The angles are measured around the axis of revolution, using the right-hand rule.
The profile curve is at the zero angle.

#### Parameter `endAngle`

End angle of rotation.
Start angle must be less than end angle and their difference must be less than or equal to two times PI.

#### Returns

The created surface. Note that this surface may not be of type RevolvedSurface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input point lies outside of Revit design limits.
-or-
The input profile curve is not valid to create a surface revolution around the given axis.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

axisDirection has zero length.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Start angle must be less than end angle and their difference must be less than or equal to two times PI.

#### Since

2017

### `M:Autodesk.Revit.DB.RevolvedSurface.Create(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevolvedSurface.Create(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Curve)`

#### Summary

Creates a Surface object coincident with the surface of revolution defined by an axis and a profile curve.

#### Remarks

The returned surface may not be of type RevolvedSurface - this function will create a surface of the simplest possible
type (Plane, Cylinder, etc.) that can be used to represent the required surface of revolution.
Given that the surface may be simplified, this function does not guarantee any particular parameterization of the surface.

#### Parameter `axisBasePoint`

The base point of the axis of revolution. Expected to lie within the Revit design limits `M:Autodesk.Revit.DB.XYZ.IsWithinLengthLimits(Autodesk.Revit.DB.XYZ)` .

#### Parameter `axisDirection`

The direction of the axis.

#### Parameter `profileCurve`

The profile curve, which should satisfy the following conditions:
It is bounded and non-degenerate.

It is co-planar with the axis of revolution.

It lies on only one side of the axis.

Only the end points of the profile curve can touch the axis.

#### Returns

The created surface. Note that this surface may not be of type RevolvedSurface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input point lies outside of Revit design limits.
-or-
The input profile curve is not valid to create a surface revolution around the given axis.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

axisDirection has zero length.

#### Since

2017

### `P:Autodesk.Revit.DB.RevolvedSurface.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevolvedSurface.Origin`

#### Summary

Center of the circle that defines the base of the revolved surface. This is the origin of the local coordinate system associated with this revolved surface.

#### Since

2017

### `P:Autodesk.Revit.DB.RevolvedSurface.YDir`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevolvedSurface.YDir`

#### Summary

X axis of the local coordinate system associated with this revolved surface.

#### Since

2017

### `P:Autodesk.Revit.DB.RevolvedSurface.XDir`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevolvedSurface.XDir`

#### Summary

X axis of the local coordinate system associated with this revolved surface.

#### Since

2017

### `P:Autodesk.Revit.DB.RevolvedSurface.Axis`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevolvedSurface.Axis`

#### Summary

Axis of the revolved surface. This is the Z axis of the local coordinate system associated with this revolved surface.

#### Since

2017

### `T:Autodesk.Revit.DB.RevolvedSurface`

Member kind: type
Symbol: `Autodesk.Revit.DB.RevolvedSurface`

#### Summary

A surface of revolution defined by a profile curve and a local coordinate system.
The surface is obtained by rotating the curve around Z axis of the local coordinate system.

#### Remarks

The parametric equation of a surface of revolution is S(u, v) = center + C1(v)*cos(u)*xVec + C1(v)*sin(u)*yVec + C2(v)*zVec,
where the profile curve in the SurfRev's xz plane has the parametric equation (C1(t), C2(t)).
Note that the direction of X axis may agree or disagree with the chosen orientation of the surface.

#### Since

2017

### `M:Autodesk.Revit.DB.Transform2D.TransformUVDomainIfPossible(Autodesk.Revit.DB.BoundingBoxUV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform2D.TransformUVDomainIfPossible(Autodesk.Revit.DB.BoundingBoxUV)`

#### Summary

Transforms an envelope ( `T:Autodesk.Revit.DB.BoundingBoxUV` ) for one surface to an envelope for a coincident but differently parameterized surface.

#### Remarks

This method succeeds in the case when the uv-parameter transform between the surfaces
has a simple form, that commonly occurs for analytic surfaces,
such that the image of the input envelope under the transform
is itself a rectangular region aligned with the UV coordinate axes.

#### Parameter `uvDomain`

The original surface envelope.

#### Returns

If successful a new `T:Autodesk.Revit.DB.BoundingBoxUV` transformed surface envelope, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

uvDomain is not set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Transform2D.GetInverse`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform2D.GetInverse`

#### Summary

Gets the inverse transformation of this transformation.

#### Remarks

The transformation matrix A is invertible if there exists a transformation matrix B such that A*B = B*A = I (identity).

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This transformation is not conformal or invertible.

#### Since

2021

### `M:Autodesk.Revit.DB.Transform2D.PostScale(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform2D.PostScale(System.Double)`

#### Summary

Scales both the linear and translational parts of this transformation and returns the result.

#### Remarks

The resulting transformation is equivalent to the application of this transformation and then the uniform scale, in this order.

#### Parameter `scale`

The scale value.

#### Returns

Returns a pointer to "this" `T:Autodesk.Revit.DB.Transform2D` .

#### Since

2021

### `M:Autodesk.Revit.DB.Transform2D.PreScale(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform2D.PreScale(System.Double)`

#### Summary

Scales the linear part of this transformation and returns the result.

#### Remarks

The resulting transformation is equivalent to the application of the uniform scale and then this transformation, in this order.

#### Parameter `scale`

The scale value.

#### Returns

Returns a pointer to "this" `T:Autodesk.Revit.DB.Transform2D` .

#### Since

2021

### `M:Autodesk.Revit.DB.Transform2D.OfVector(Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform2D.OfVector(Autodesk.Revit.DB.UV)`

#### Summary

Applies the transformation to the vector and returns the result.

#### Remarks

Transformation of a vector is not affected by the translational part of the transformation.

#### Parameter `vector`

The vector to transform.

#### Returns

The transformed vector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Transform2D.OfPoint(Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform2D.OfPoint(Autodesk.Revit.DB.UV)`

#### Summary

Applies the transformation to the point and returns the result.

#### Remarks

Transformation of a point is affected by the translational part of the transformation.

#### Parameter `point`

The point to transform.

#### Returns

The transformed point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Transform2D.Multiply(Autodesk.Revit.DB.Transform2D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform2D.Multiply(Autodesk.Revit.DB.Transform2D)`

#### Summary

Multiplies this transformation by the specified transformation and returns the result.

#### Remarks

The combined transformation has the same effect as applying the right transformation first, and this transformation, second.
So, denoting this transform by T1 and the right transform by T2, (T1(T2(p)) = (T1 * T2) (p).

#### Returns

The transformation equal to the composition of the two transformations.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Transform2D.CreateIdentity`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform2D.CreateIdentity`

#### Summary

Creates the identity transformation.

#### Remarks

The identity transformation does not change a point or a vector that it is applied to.

#### Returns

The identity transformation.

#### Since

2021

### `M:Autodesk.Revit.DB.Transform2D.SetToIdentity`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform2D.SetToIdentity`

#### Summary

Set this TrfUV to the identity transform.

#### Returns

Returns a pointer to "this" `T:Autodesk.Revit.DB.Transform2D` .

#### Since

2021

### `M:Autodesk.Revit.DB.Transform2D.Assign(Autodesk.Revit.DB.Transform2D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform2D.Assign(Autodesk.Revit.DB.Transform2D)`

#### Summary

Assigns values from the input transformation to this transformation.

#### Parameter `from`

The transformation to use as input.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Transform2D.AlmostEqual(Autodesk.Revit.DB.Transform2D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform2D.AlmostEqual(Autodesk.Revit.DB.Transform2D)`

#### Summary

Determines whether this transformation and the specified transformation are the same within the tolerance (1.0e-09).

#### Remarks

The tolerance is applied memberwise for comparison.

#### Parameter `right`

The transformation to compare with this transformation.

#### Returns

True if the two transformations are equal, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `P:Autodesk.Revit.DB.Transform2D.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform2D.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Transform2D.Scale`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform2D.Scale`

#### Summary

The real number that represents the scale of the conformal transformation.

#### Remarks

When the transformation is conformal and can be decomposed as the product of a rigid-body motion,
uniform scale and reflection, this property returns the scale value of the uniform scale transformation.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This transformation is not conformal and the scale is undefined.

#### Since

2021

### `P:Autodesk.Revit.DB.Transform2D.HasReflection`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform2D.HasReflection`

#### Summary

The boolean value that indicates whether this transformation produces reflection (i.e., is orientation-reversing).

#### Remarks

Reflection transformation changes the handedness of a coordinate system.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This transformation is singular and the reflection is undefined.

#### Since

2021

### `P:Autodesk.Revit.DB.Transform2D.BasisV`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform2D.BasisV`

#### Summary

The image of (0, 1) under `M:Autodesk.Revit.DB.Transform2D.OfVector(Autodesk.Revit.DB.UV)` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2021

### `P:Autodesk.Revit.DB.Transform2D.BasisU`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform2D.BasisU`

#### Summary

The image of (1, 0) under `M:Autodesk.Revit.DB.Transform2D.OfVector(Autodesk.Revit.DB.UV)` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2021

### `P:Autodesk.Revit.DB.Transform2D.Determinant`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform2D.Determinant`

#### Summary

The determinant of this transformation.

#### Remarks

The geometric meaning of a determinant is as the scale factor for volume when applied as linear transformation.

#### Since

2021

### `P:Autodesk.Revit.DB.Transform2D.IsConformal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform2D.IsConformal`

#### Summary

The boolean value that indicates whether this transformation is conformal.

#### Remarks

This property is true if this transformation can be decomposed as the product
of a rigid-body motion, uniform scale and reflection.
Such transformation preserves angles between vectors.

#### Since

2021

### `P:Autodesk.Revit.DB.Transform2D.IsTranslation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform2D.IsTranslation`

#### Summary

The boolean value that indicates whether this transformation is a translation.

#### Remarks

This property is true if the only effect of transformation is translation.
It checks that the linear part of the transform is identity. The translation vector may be zero
(which would make this an identity transformation) or nonzero (which would make this a non-trivial translation).

#### Since

2021

### `P:Autodesk.Revit.DB.Transform2D.IsIdentity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform2D.IsIdentity`

#### Summary

The boolean value that indicates whether this transformation is an identity.

#### Remarks

The identity transformation does not change a point or a vector that it is applied to.

#### Since

2021

### `P:Autodesk.Revit.DB.Transform2D.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.Transform2D.Origin`

#### Summary

The image of (0, 0) under `M:Autodesk.Revit.DB.Transform2D.OfPoint(Autodesk.Revit.DB.UV)` .
This defines the translational part of the transform.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Transform2D.#ctor(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform2D.#ctor(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV)`

#### Summary

Constructs the transformation by specifying the vectors and the origin.

#### Parameter `uVec`

The image of (1, 0) under `M:Autodesk.Revit.DB.Transform2D.OfVector(Autodesk.Revit.DB.UV)` .

#### Parameter `vVec`

The image of (0, 1) under `M:Autodesk.Revit.DB.Transform2D.OfVector(Autodesk.Revit.DB.UV)` .

#### Parameter `origin`

The image of (0, 0) under `M:Autodesk.Revit.DB.Transform2D.OfPoint(Autodesk.Revit.DB.UV)` .
This defines the translational part of the transform.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Transform2D.#ctor(Autodesk.Revit.DB.Transform2D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Transform2D.#ctor(Autodesk.Revit.DB.Transform2D)`

#### Summary

The copy constructor.

#### Parameter `other`

The transformation to use as input.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `T:Autodesk.Revit.DB.Transform2D`

Member kind: type
Symbol: `Autodesk.Revit.DB.Transform2D`

#### Summary

An affine transform of 2D Euclidean space.

#### Remarks

An affine transform is a linear transform plus a translation (which may be zero).
Some functions only accept certain kinds of transform (e.g., rigid motion, conformal, non-singular, etc.).

#### Since

2021

### `M:Autodesk.Revit.DB.CurveUV.Transform(Autodesk.Revit.DB.Transform2D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveUV.Transform(Autodesk.Revit.DB.Transform2D)`

#### Summary

Transform this CurveUV by the given 2D affine transform if possible.

#### Parameter `trfUV`

The given 2D affine transform.

#### Returns

If successful a transformed CurveUV, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.CurveUV.GetEndParameter(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveUV.GetEndParameter(System.Int32)`

#### Summary

Gets the raw parameter value at the start or end of this curve.

#### Parameter `index`

Use 0 for the start parameter, 1 for the end parameter of the curve.

#### Returns

The raw parameter value at the start or end of this curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for index is not 0 or 1.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This curve is unbound and does not have start and end points.

#### Since

2021

### `M:Autodesk.Revit.DB.CurveUV.ComputeDerivatives(System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveUV.ComputeDerivatives(System.Double,System.Boolean)`

#### Summary

Computes the first derivative, the second derivative and the unit tangent vector at the specified parameter along the curve.

#### Parameter `parameter`

The specified parameter along the curve.

#### Parameter `normalized`

If false, parameter is interpreted as natural parameterization of the curve. If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.

#### Returns

The array containing three members: the first derivative (at index [0]), the second derivative (at index [1]) and the unit tangent vector (at index [2]).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for parameter is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The curve cannot be evaluated as normalized because it is unbound.
-or-
The parameter is not a valid value for normalized evaluation.

#### Since

2021

### `M:Autodesk.Revit.DB.CurveUV.Evaluate(System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveUV.Evaluate(System.Double,System.Boolean)`

#### Summary

Evaluates and returns the point at the specified parameter along the curve.

#### Parameter `parameter`

The specified parameter along the curve.

#### Parameter `normalized`

If false, parameter is interpreted as natural parameterization of the curve. If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.

#### Returns

The point evaluated along the curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for parameter is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The curve cannot be evaluated as normalized because it is unbound.
-or-
The parameter is not a valid value for normalized evaluation.

#### Since

2021

### `M:Autodesk.Revit.DB.CurveUV.As3DCurveInXYPlane`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveUV.As3DCurveInXYPlane`

#### Summary

Returns a 3D curve lying in the XY plane in XYZ coordinates, representing the 2D curve with its UV coordinates identified with XY coordinates.

#### Remarks

Ideally, this function should only be used in cases when the 2D curve needs to be used in a context
that does not support 2D curves, but can represent them as 3D curves with Z = 0 everywhere (for example,
converting the 2D curve to another CAD system that does not support 2D curves).

#### Returns

3D curve lying in the XY plane in XYZ coordinates, representing the 2D curve with its UV coordinates identified with XY coordinates.

#### Since

2021

### `M:Autodesk.Revit.DB.CurveUV.Create(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveUV.Create(Autodesk.Revit.DB.Curve)`

#### Summary

Create a CurveUV from a bounded 3D Curve lying in the XY plane.

#### Remarks

The XY plane is identified with the uv parameter space of the surface to which this SurfParamSpaceCurve refers.

#### Parameter `curve3D`

The input bounded 3D Curve lying in the XY plane (i.e., z = 0 everywhere along the curve).

#### Returns

The newly created CurveUV.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input Curve is not a bounded 3D Curve lying in the XY plane (i.e., z = 0 everywhere along the curve).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `P:Autodesk.Revit.DB.CurveUV.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveUV.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.CurveUV.IsBound`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveUV.IsBound`

#### Summary

Describes whether the parameter of the curve is restricted to a particular interval.

#### Since

2021

### `T:Autodesk.Revit.DB.CurveUV`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveUV`

#### Summary

A class that encapsulates the notion of a curve in the 2D parameter space of a surface in 3D space.

#### Remarks

Revit does not have a class to represent 2D curves explicitly.

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.StructuralFramingUtils.FlipEnds(Autodesk.Revit.DB.FamilyInstance)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralFramingUtils.FlipEnds(Autodesk.Revit.DB.FamilyInstance)`

#### Summary

Flips the ends of the structural framing element.

#### Remarks

Only ends of non-concrete structural framing element like beam and brace can be flipped and only in case if it is a line, arc or ellipse element.

#### Parameter `familyInstance`

The FamilyInstance, which must be of a structural framing category, non-concrete.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input familyInstance is concrete or is not a line, arc or ellipse element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The input familyInstance is not of a structural framing category.

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.DB.Structure.StructuralFramingUtils.CanFlipEnds(Autodesk.Revit.DB.FamilyInstance)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralFramingUtils.CanFlipEnds(Autodesk.Revit.DB.FamilyInstance)`

#### Summary

Determines if the ends of the given framing element can be flipped.

#### Parameter `familyInstance`

The FamilyInstance, which must be of a structural framing category, non-concrete.

#### Returns

True for non-concrete line, arc or ellipse framing element, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015 Subscription Update

### `M:Autodesk.Revit.DB.Structure.StructuralFramingUtils.IsJoinAllowedAtEnd(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralFramingUtils.IsJoinAllowedAtEnd(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

#### Summary

Identifies if the indicated end of the framing element is allowed to join to others.

#### Parameter `familyInstance`

The FamilyInstance, which must be of a structural framing category.

#### Parameter `end`

The index of the end (0 for the start, 1 for the end).

#### Returns

True if it is allowed to join. False if it is disallowed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The input familyInstance is not of a structural framing category.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralFramingUtils.AllowJoinAtEnd(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralFramingUtils.AllowJoinAtEnd(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

#### Summary

Sets the indicated end of the framing element to be allowed to join to others.

#### Remarks

If that end is near other elements it will become joined as a result.
By default all framing elements are allowed to join at ends, so this function is only needed if this element end is already disallowed to join.

#### Parameter `familyInstance`

The FamilyInstance, which must be of a structural framing category.

#### Parameter `end`

The index of the end (0 for the start, 1 for the end).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The input familyInstance is not of a structural framing category.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralFramingUtils.DisallowJoinAtEnd(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralFramingUtils.DisallowJoinAtEnd(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

#### Summary

Sets the indicated end of the framing element to not be allowed to join to others.

#### Remarks

If this framing element is already joined at this end, it will become disconnected.

#### Parameter `familyInstance`

The FamilyInstance, which must be of a structural framing category.

#### Parameter `end`

The index of the end (0 for the start, 1 for the end).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The input familyInstance is not of a structural framing category.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralFramingUtils.SetEndReference(Autodesk.Revit.DB.FamilyInstance,System.Int32,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralFramingUtils.SetEndReference(Autodesk.Revit.DB.FamilyInstance,System.Int32,Autodesk.Revit.DB.Reference)`

#### Summary

Sets the end reference of a framing element.

#### Remarks

The setback value will be changed as a result of the removal.

#### Parameter `familyInstance`

The FamilyInstance, which must be of a structural framing category, non-concrete and joined.

#### Parameter `end`

The index of the end (0 for the start, 1 for the end).

#### Parameter `pick`

The reference to set to the given end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The input familyInstance is not of a structural framing category or is concrete or is not joined at given end and cannot have an end reference set.
-or-
The input pick cannot be set as the end reference for the given end of the structural framing element.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralFramingUtils.GetEndReference(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralFramingUtils.GetEndReference(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

#### Summary

Returns a reference to the end of a framing element according to the setback settings.

#### Parameter `familyInstance`

The FamilyInstance, which must be of a structural framing category, non-concrete and joined.

#### Parameter `end`

The index of the end (0 for the start, 1 for the end).

#### Returns

The end reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The input familyInstance is not of a structural framing category or is concrete or is not joined at given end and cannot have an end reference set.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralFramingUtils.RemoveEndReference(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralFramingUtils.RemoveEndReference(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

#### Summary

Resets the end reference of the structural framing element.

#### Remarks

The setback value will be changed as a result of the removal.

#### Parameter `familyInstance`

The FamilyInstance, which must be of a structural framing category, non-concrete and joined.

#### Parameter `end`

The index of the end (0 for the start, 1 for the end).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The input familyInstance is not of a structural framing category or is concrete or is not joined at given end and cannot have an end reference set.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralFramingUtils.IsEndReferenceValid(Autodesk.Revit.DB.FamilyInstance,System.Int32,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralFramingUtils.IsEndReferenceValid(Autodesk.Revit.DB.FamilyInstance,System.Int32,Autodesk.Revit.DB.Reference)`

#### Summary

Determines if the given reference can be set for the given end of the framing element.

#### Parameter `familyInstance`

The FamilyInstance, which must be of a structural framing category, non-concrete and joined at the given end.

#### Parameter `end`

The index of the end (0 for the start, 1 for the end).

#### Parameter `pick`

The reference to be checked against the given end of the framing element.

#### Returns

True if the given reference can be set for the given end of the framing element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralFramingUtils.CanSetEndReference(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralFramingUtils.CanSetEndReference(Autodesk.Revit.DB.FamilyInstance,System.Int32)`

#### Summary

Determines if a reference can be set for the given end of the framing element.

#### Parameter `familyInstance`

The FamilyInstance, which must be of a structural framing category, non-concrete and joined at the given end.

#### Parameter `end`

The index of the end (0 for the start, 1 for the end).

#### Returns

True if reference can be set for the given end of the framing element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralFramingUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralFramingUtils`

#### Summary

A collection of Structural Framing Utilities.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSettings.SetValuesForLoadsDisplayScaling(System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.SetValuesForLoadsDisplayScaling(System.Double,System.Double,System.Double,System.Double)`

#### Summary

Sets values for loads display scaling by providing two load forces and their corresponding length of the representative lines in internal units.

#### Remarks

Use UnitUtils class methods to convert value from or to internal units.
The values are used to scale the representation of all load types(point, line and area loads).

#### Parameter `minimumLoadValue`

The minimum force in SpecTypeId.Force units.

#### Parameter `minimumForceLineLength`

The line length for minimum force.

#### Parameter `maximumLoadValue`

The maximum force in SpecTypeId.Force units.

#### Parameter `maximumForceLineLength`

The line length for maximum force.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown when:
- forces are negative.
- line lengths are negative.
- minimum force is greater or equal to the maximum force.
- line length for minimum force is greater than line length for maximum force.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.StructuralSettings.GetLoadForceVectorReprLine(Autodesk.Revit.DB.Structure.LoadType,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.GetLoadForceVectorReprLine(Autodesk.Revit.DB.Structure.LoadType,Autodesk.Revit.DB.XYZ)`

#### Summary

Returns the representative line of the load force vector according to loads display scaling.

#### Parameter `loadType`

LoadType::Point, Line, or Area

#### Parameter `forceVector`

The load force vector in internal units.

#### Returns

The the representative line in internal units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.StructuralSettings.GetStructuralSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.GetStructuralSettings(Autodesk.Revit.DB.Document)`

#### Summary

Obtains the StructuralSettings object for the specified project document.

#### Parameter `doc`

A project document.

#### Returns

The StructuralSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.UseLoadsDisplayScaling`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.UseLoadsDisplayScaling`

#### Summary

Whether to use loads display scaling. If disabled then loads are displayed according to force scale type parameters.

#### Since

2024

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.ShowBraceBelow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.ShowBraceBelow`

#### Summary

Whether to show brace symbols below beams in plan views.

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.ShowBraceAbove`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.ShowBraceAbove`

#### Summary

Whether to show brace symbols above beams in plan views.

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.BoundaryConditionFamilySymbolUserDefined`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.BoundaryConditionFamilySymbolUserDefined`

#### Summary

The id of the FamilySymbol to represent a user-defined boundary condition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.BoundaryConditionFamilySymbolRoller`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.BoundaryConditionFamilySymbolRoller`

#### Summary

The id of the FamilySymbol to represent a roller boundary condition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.BoundaryConditionFamilySymbolPinned`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.BoundaryConditionFamilySymbolPinned`

#### Summary

The id of the FamilySymbol to represent a pinned boundary condition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.BoundaryConditionFamilySymbolFixed`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.BoundaryConditionFamilySymbolFixed`

#### Summary

The id of the FamilySymbol to represent a fixed boundary condition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.KickerBraceSymbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.KickerBraceSymbol`

#### Summary

The id of the ElementType to represent a kicker brace.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.BraceBelowSymbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.BraceBelowSymbol`

#### Summary

The id of the ElementType to represent a brace below a beam in plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.BraceAboveSymbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.BraceAboveSymbol`

#### Summary

The id of the ElementType to represent a brace above a beam in plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.BoundaryConditionAreaAndLineSymbolSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.BoundaryConditionAreaAndLineSymbolSpacing`

#### Summary

Symbol spacing for boundary conditions.

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.SymbolicCutbackForColumn`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.SymbolicCutbackForColumn`

#### Summary

Symbolic cutback distance to be applied to all columns.

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.SymbolicCutbackForBrace`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.SymbolicCutbackForBrace`

#### Summary

Symbolic cutback distance to be applied to all braces.

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.SymbolicCutbackForBeamAndTruss`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.SymbolicCutbackForBeamAndTruss`

#### Summary

Symbolic cutback distance to be applied to all beams and trusses.

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralSettings.BraceParallelLineOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings.BraceParallelLineOffset`

#### Summary

The distance by which brace symbols in plan
views will be offset.

#### Remarks

Applies only when BracePlanRepresentation is set to ParallelLine.

#### Since

2011

### `T:Autodesk.Revit.DB.Structure.StructuralSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSettings`

#### Summary

Provides access to project-wide structural settings.

#### Since

2011

### `T:Autodesk.Revit.DB.Structure.BracePlanRepresentation`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.BracePlanRepresentation`

#### Summary

The possible representations for braces in plan views.

#### Since

2011

### `F:Autodesk.Revit.DB.Structure.BracePlanRepresentation.LineWithAngle`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BracePlanRepresentation.LineWithAngle`

#### Summary

Braces are represented by a line with angle.

### `F:Autodesk.Revit.DB.Structure.BracePlanRepresentation.ParallelLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.BracePlanRepresentation.ParallelLine`

#### Summary

Braces are represented by a parallel line.

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRound.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRound.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Concrete Round shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `diameter`

Pipe Diameter.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl).

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation.

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct).

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H).

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRound`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRound`

#### Summary

Creates a new instance of Structural Section Concrete Round shape with the associated set of parameters,
used to attach to structural element.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteCross.CantileverHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteCross.CantileverHeight`

#### Summary

Flange cantilever thickness.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteCross.CantileverLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteCross.CantileverLength`

#### Summary

Flange cantilever length.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteCross.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteCross.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Concrete Cross shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `cantileverLength`

Flange cantilever length.

#### Parameter `cantileverHeight`

Flange cantilever thickness.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteCross`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteCross`

#### Summary

Defines parameters for parameterized concrete cross structural section.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteT.CantileverHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteT.CantileverHeight`

#### Summary

Flange cantilever thickness.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteT.CantileverLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteT.CantileverLength`

#### Summary

Flange cantilever length.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteT.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteT.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Concrete T shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `cantileverLength`

Flange cantilever length.

#### Parameter `cantileverHeight`

Flange cantilever thickness.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteT`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteT`

#### Summary

Defines parameters for parameterized concrete T structural section.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangleCut.BottomCutHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangleCut.BottomCutHeight`

#### Summary

Section height left Cut.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangleCut.BottomCutWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangleCut.BottomCutWidth`

#### Summary

Section width left Cut.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangleCut.TopCutHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangleCut.TopCutHeight`

#### Summary

Section height right Cut.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangleCut.TopCutWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangleCut.TopCutWidth`

#### Summary

Section width right Cut.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangleCut.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangleCut.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Concrete Rectangle Cut shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `topCutWidth`

Section width right Cut.

#### Parameter `topCutHeight`

Section height right Cut.

#### Parameter `bottomCutWidth`

Section width left Cut.

#### Parameter `bottomCutHeight`

Section height left Cut.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangleCut`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangleCut`

#### Summary

Defines parameters for parameterized concrete rectangle cut structural section.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangle.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangle.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Concrete Rectangle shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangle`

#### Summary

Defines parameters for parameterized concrete rectangle structural section.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUserDefined.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUserDefined.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section User Defined shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUserDefined`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUserDefined`

#### Summary

Defines parameters for parameterized user defined structural section.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold.TopBendLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold.TopBendLength`

#### Summary

Top Bend segment length.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold.MiddleBendLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold.MiddleBendLength`

#### Summary

Middle Bend segment length.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold.LipLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold.LipLength`

#### Summary

Lip segment length.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold.BendWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold.BendWidth`

#### Summary

Bend segment width.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold.FoldWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold.FoldWidth`

#### Summary

Fold segment width.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Sigma Profile With Fold shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `foldWidth`

Fold segment width.

#### Parameter `lipLength`

Lip segment length.

#### Parameter `bendWidth`

Bend segment width.

#### Parameter `middleBendLength`

Middle Bend segment length.

#### Parameter `topBendLength`

Top Bend segment length.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold`

#### Summary

Defines parameters for structural Sigma profile section with fold.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithLips.TopBendLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithLips.TopBendLength`

#### Summary

Top Bend segment length.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithLips.MiddleBendLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithLips.MiddleBendLength`

#### Summary

Middle Bend segment length.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithLips.LipLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithLips.LipLength`

#### Summary

Lip segment length.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithLips.BendWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithLips.BendWidth`

#### Summary

Bend segment width.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithLips.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithLips.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Sigma Profile With Lips shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `lipLength`

Lip segment length.

#### Parameter `bendWidth`

Bend segment width.

#### Parameter `middleBendLength`

Middle Bend segment length.

#### Parameter `topBendLength`

Top Bend segment length.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithLips`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithLips`

#### Summary

Defines parameters for structural Sigma Profile section with lips.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfile.TopBendLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfile.TopBendLength`

#### Summary

Top Bend segment length.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfile.MiddleBendLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfile.MiddleBendLength`

#### Summary

Middle Bend segment length.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfile.BendWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfile.BendWidth`

#### Summary

Bend segment width.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfile.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfile.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Sigma Profile shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `bendWidth`

Bend segment width.

#### Parameter `middleBendLength`

Middle Bend segment length.

#### Parameter `topBendLength`

Top Bend segment length.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfile`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfile`

#### Summary

Defines parameters for Sigma Profile structural section.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionZProfileWithLips.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionZProfileWithLips.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Z Profile With Lips shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `bottomFlangeLength`

Bottom Flange segment length.

#### Parameter `lipLength`

Lip segment length.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionZProfileWithLips`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionZProfileWithLips`

#### Summary

Defines parameters for Z Profile with lips structural section.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionZProfile.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionZProfile.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Z Profile shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `bottomFlangeLength`

Bottom Flange segment length.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionZProfile`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionZProfile`

#### Summary

Defines parameters for Z Profile structural section.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLProfileWithLips.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLProfileWithLips.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section L Profile With Lips shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `lipLength`

Lip segment length.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLProfileWithLips`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLProfileWithLips`

#### Summary

Defines parameters for L Profile with lips structural section.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLProfile.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLProfile.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section L Profile shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLProfile`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLProfile`

#### Summary

Defines parameters for L profile structural section.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfileWithFold.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfileWithFold.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section C Profile With Fold shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `lipLength`

Lip segment length.

#### Parameter `foldLength`

Fold segment length.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfileWithFold`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfileWithFold`

#### Summary

Defines parameters for C Profile with fold structural section.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfileWithLips.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfileWithLips.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section C Profile With Lips shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `lipLength`

Lip segment length.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfileWithLips`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfileWithLips`

#### Summary

Defines parameters for C Profile with lips structural section.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfile.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfile.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section C Profile shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfile`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfile`

#### Summary

Defines parameters for C Profile structural section.

#### Since

2016

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRoundHSS.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRoundHSS.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Round HSS shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `diameter`

Pipe Diameter.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of pipe.

#### Parameter `wallDesignThickness`

Represents wall design thickness of pipe.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl).

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation.

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct).

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H).

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRoundHSS`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRoundHSS`

#### Summary

Defines parameters for pipes known as Round HSS (HollowStructuralSection).

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangleHSS.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangleHSS.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Rectangle HSS shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `outerFillet`

Outer Fillet - Corner fillet outer radius.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangleHSS`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangleHSS`

#### Summary

Defines parameters for parameterized rectangle HSS structural section.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.WebHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.WebHeight`

#### Summary

Web Height.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.WebThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.WebThickness`

#### Summary

Web Thickness.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.BottomFlangeWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.BottomFlangeWidth`

#### Summary

Bottom Flange Width.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.BottomFlangeThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.BottomFlangeThickness`

#### Summary

Bottom Flange Thickness.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.TopFlangeWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.TopFlangeWidth`

#### Summary

Top Flange Width.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.TopFlangeThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.TopFlangeThickness`

#### Summary

Top Flange Thickness.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section I Welded shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `topFlangeThickness`

Top Flange Thickness.

#### Parameter `topFlangeWidth`

Top Flange Width.

#### Parameter `bottomFlangeThickness`

Bottom Flange Thickness.

#### Parameter `bottomFlangeWidth`

Bottom Flange Width.

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webHeight`

Web Height.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded`

#### Summary

Defines parameters for I-shape Welded structural section.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRoundBar.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRoundBar.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Round Bar shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `diameter`

Pipe Diameter.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRoundBar`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRoundBar`

#### Summary

Defines parameters for Round Bar structural section.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangularBar.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangularBar.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Rectangular Bar shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangularBar`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangularBar`

#### Summary

Defines parameters for Rectangular Bar structural section.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.BoltDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.BoltDiameter`

#### Summary

Maximum bolt hole diameter, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.BoltSpacingBetweenRows`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.BoltSpacingBetweenRows`

#### Summary

Standard bolt spacing between rows, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.BoltSpacingTwoRows`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.BoltSpacingTwoRows`

#### Summary

Standard bolt spacing for two rows , in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.BoltSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.BoltSpacing`

#### Summary

Standard bolt spacing, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.WebToeOfFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.WebToeOfFillet`

#### Summary

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.FlangeToeOfFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.FlangeToeOfFillet`

#### Summary

Detailing distance from center of web to flange toe of fillet, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.ClearWebHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.ClearWebHeight`

#### Summary

Detailing depth between the web toes of the fillets, in.(mm)

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section I Wide Flange shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `flangeThickness`

Flange Thickness.

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webFillet`

Web Fillet - fillet radius between web and flange.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `clearWebHeight`

Detailing depth between the web toes of the fillets, in.(mm)

#### Parameter `flangeToeOfFillet`

Detailing distance from center of web to flange toe of fillet, in. (mm)

#### Parameter `webToeOfFillet`

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Parameter `boltSpacing`

Standard bolt spacing, in. (mm)

#### Parameter `boltSpacingTwoRows`

Standard bolt spacing for two rows , in. (mm)

#### Parameter `boltSpacingBetweenRows`

Standard bolt spacing between rows, in. (mm)

#### Parameter `boltDiameter`

Maximum bolt hole diameter, in. (mm)

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange`

#### Summary

Defines parameters for I-shape Wide Flange structural section.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitSlopedFlange.BoltDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitSlopedFlange.BoltDiameter`

#### Summary

Maximum bolt hole diameter, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitSlopedFlange.BoltSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitSlopedFlange.BoltSpacing`

#### Summary

Standard bolt spacing, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitSlopedFlange.ClearWebHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitSlopedFlange.ClearWebHeight`

#### Summary

Detailing depth between the web toes of the fillets, in.(mm)

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitSlopedFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitSlopedFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section I Split Sloped Flange shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `flangeThickness`

Flange Thickness.

#### Parameter `flangeThicknessLocation`

Flange Thickness Location.

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webFillet`

Web Fillet - fillet radius between web and flange.

#### Parameter `flangeFillet`

Flange Fillet - fillet radius at the flange end.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `clearWebHeight`

Detailing depth between the web toes of the fillets, in.(mm)

#### Parameter `webToeOfFillet`

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Parameter `boltSpacing`

Standard bolt spacing, in. (mm)

#### Parameter `boltDiameter`

Maximum bolt hole diameter, in. (mm)

#### Parameter `slopedFlangeAngle`

Sloped flange angle. (rad)

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitSlopedFlange`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitSlopedFlange`

#### Summary

Defines parameters for I-split Sloped Flange structural section.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionStructuralTees.BoltDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionStructuralTees.BoltDiameter`

#### Summary

Maximum bolt hole diameter, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionStructuralTees.BoltSpacingWeb`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionStructuralTees.BoltSpacingWeb`

#### Summary

Standard bolt spacing in the web, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionStructuralTees.BoltSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionStructuralTees.BoltSpacing`

#### Summary

Standard bolt spacing in the flange, in. (mm)

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionStructuralTees.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionStructuralTees.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Tees shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `flangeThickness`

Flange Thickness.

#### Parameter `flangeThicknessLocation`

Flange Thickness Location.

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webThicknessLocation`

Web Thickness Location.

#### Parameter `webFillet`

Web Fillet - fillet radius between web and flange.

#### Parameter `flangeFillet`

Flange Fillet - fillet radius at the flange end.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `boltSpacing`

Standard bolt spacing in the flange, in. (mm)

#### Parameter `boltSpacingWeb`

Standard bolt spacing in the web, in. (mm)

#### Parameter `boltDiameter`

Maximum bolt hole diameter, in. (mm)

#### Parameter `slopedFlangeAngle`

Sloped flange angle. (rad)

#### Parameter `slopedWebAngle`

Sloped web angle. (rad)

#### Parameter `topWebFillet`

Top Web Fillet - fillet radius at the top of web.

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionStructuralTees`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionStructuralTees`

#### Summary

Defines parameters for Structural Tees structural section.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle.BoltDiameterShorterFlange`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle.BoltDiameterShorterFlange`

#### Summary

Maximum bolt hole diameter in the shorter flange, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle.BoltDiameterLongerFlange`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle.BoltDiameterLongerFlange`

#### Summary

Maximum bolt hole diameter in the longer flange, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle.BoltSpacingShorterFlange`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle.BoltSpacingShorterFlange`

#### Summary

Standard bolt spacing in the shorter flange, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle.BoltSpacing2LongerFlange`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle.BoltSpacing2LongerFlange`

#### Summary

Standard bolt spacing second row in the longer flange, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle.BoltSpacing1LongerFlange`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle.BoltSpacing1LongerFlange`

#### Summary

Standard bolt spacing first row in the longer flange, in. (mm)

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section L Angle shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `flangeThickness`

Flange Thickness.

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webFillet`

Web Fillet - fillet radius between web and flange.

#### Parameter `flangeFillet`

Flange Fillet - fillet radius at the flange end.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `boltSpacing1LongerFlange`

Standard bolt spacing first row in the longer flange, in. (mm)

#### Parameter `boltSpacing2LongerFlange`

Standard bolt spacing second row in the longer flange, in. (mm)

#### Parameter `boltSpacingShorterFlange`

Standard bolt spacing in the shorter flangI-split Parallel Flangee, in. (mm)

#### Parameter `boltDiameterLongerFlange`

Maximum bolt hole diameter in the longer flange, in. (mm)

#### Parameter `boltDiameterShorterFlange`

Maximum bolt hole diameter in the shorter flange, in. (mm)

#### Parameter `topWebFillet`

Top Web Fillet - fillet radius at the top of web.

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle`

#### Summary

Defines parameters for L-angle Flange structural section.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCSlopedFlange.BoltDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCSlopedFlange.BoltDiameter`

#### Summary

Maximum bolt hole diameter, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCSlopedFlange.BoltSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCSlopedFlange.BoltSpacing`

#### Summary

Standard bolt spacing, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCSlopedFlange.ClearWebHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCSlopedFlange.ClearWebHeight`

#### Summary

Detailing depth between the web toes of the fillets, in.(mm)

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCSlopedFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCSlopedFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section C Sloped Flange shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `flangeThickness`

Flange Thickness.

#### Parameter `flangeThicknessLocation`

Flange Thickness Location.

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webFillet`

Web Fillet - fillet radius between web and flange.

#### Parameter `flangeFillet`

Flange Fillet - fillet radius at the flange end.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `clearWebHeight`

Detailing depth between the web toes of the fillets, in.(mm)

#### Parameter `webToeOfFillet`

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Parameter `boltSpacing`

Standard bolt spacing, in. (mm)

#### Parameter `boltDiameter`

Maximum bolt hole diameter, in. (mm)

#### Parameter `slopedFlangeAngle`

Sloped flange angle. (rad)

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCSlopedFlange`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCSlopedFlange`

#### Summary

Defines parameters for C-channel Sloped Flange structural section.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCParallelFlange.BoltDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCParallelFlange.BoltDiameter`

#### Summary

Maximum bolt hole diameter, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCParallelFlange.BoltSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCParallelFlange.BoltSpacing`

#### Summary

Standard bolt spacing, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCParallelFlange.ClearWebHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCParallelFlange.ClearWebHeight`

#### Summary

Detailing depth between the web toes of the fillets, in.(mm)

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCParallelFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCParallelFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section C Parallel Flange shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `flangeThickness`

Flange Thickness.

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webFillet`

Web Fillet - fillet radius between web and flange.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `clearWebHeight`

Detailing depth between the web toes of the fillets, in.(mm)

#### Parameter `flangeToeOfFillet`

Detailing distance from center of web to flange toe of fillet, in. (mm)

#### Parameter `webToeOfFillet`

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Parameter `boltSpacing`

Standard bolt spacing, in. (mm)

#### Parameter `boltDiameter`

Maximum bolt hole diameter, in. (mm)

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCParallelFlange`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCParallelFlange`

#### Summary

Defines parameters for C-channel Parallel Flange structural section.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISlopedFlange.BoltDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISlopedFlange.BoltDiameter`

#### Summary

Maximum bolt hole diameter, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISlopedFlange.BoltSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISlopedFlange.BoltSpacing`

#### Summary

Standard bolt spacing, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISlopedFlange.ClearWebHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISlopedFlange.ClearWebHeight`

#### Summary

Detailing depth between the web toes of the fillets, in.(mm)

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISlopedFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISlopedFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section I Sloped Flange shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `flangeThickness`

Flange Thickness.

#### Parameter `flangeThicknessLocation`

Flange Thickness Location.

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webFillet`

Web Fillet - fillet radius between web and flange.

#### Parameter `flangeFillet`

Flange Fillet - fillet radius at the flange end.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `clearWebHeight`

Detailing depth between the web toes of the fillets, in.(mm)

#### Parameter `webToeOfFillet`

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Parameter `boltSpacing`

Standard bolt spacing, in. (mm)

#### Parameter `boltDiameter`

Maximum bolt hole diameter, in. (mm)

#### Parameter `slopedFlangeAngle`

Sloped flange angle. (rad)

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISlopedFlange`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISlopedFlange`

#### Summary

Defines parameters for I-shape Sloped Flange structural section.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitParallelFlange.BoltDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitParallelFlange.BoltDiameter`

#### Summary

Maximum bolt hole diameter, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitParallelFlange.BoltSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitParallelFlange.BoltSpacing`

#### Summary

Standard bolt spacing, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitParallelFlange.ClearWebHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitParallelFlange.ClearWebHeight`

#### Summary

Detailing depth between the web toes of the fillets, in.(mm)

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitParallelFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitParallelFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section I Split Parallel Flange shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `flangeThickness`

Flange Thickness.

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webFillet`

Web Fillet - fillet radius between web and flange.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `clearWebHeight`

Detailing depth between the web toes of the fillets, in.(mm)

#### Parameter `flangeToeOfFillet`

Detailing distance from center of web to flange toe of fillet, in. (mm)

#### Parameter `webToeOfFillet`

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Parameter `boltSpacing`

Standard bolt spacing, in. (mm)

#### Parameter `boltDiameter`

Maximum bolt hole diameter, in. (mm)

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitParallelFlange`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitParallelFlange`

#### Summary

Defines parameters for I-split Parallel Flange structural section.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIParallelFlange.BoltDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIParallelFlange.BoltDiameter`

#### Summary

Maximum bolt hole diameter, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIParallelFlange.BoltSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIParallelFlange.BoltSpacing`

#### Summary

Standard bolt spacing, in. (mm)

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIParallelFlange.ClearWebHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIParallelFlange.ClearWebHeight`

#### Summary

Detailing depth between the web toes of the fillets, in.(mm)

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIParallelFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIParallelFlange.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section I Parallel Flange shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `flangeThickness`

Flange Thickness.

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webFillet`

Web Fillet - fillet radius between web and flange.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Parameter `clearWebHeight`

Detailing depth between the web toes Of the fillets, in.(mm)

#### Parameter `flangeToeOfFillet`

Detailing distance from center of web to flange toe of fillet, in. (mm)

#### Parameter `webToeOfFillet`

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Parameter `boltSpacing`

Standard bolt spacing, in. (mm)

#### Parameter `boltDiameter`

Maximum bolt hole diameter, in. (mm)

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIParallelFlange`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIParallelFlange`

#### Summary

Defines parameters for I-shape Parallel Flange structural section.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangleParameterized.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangleParameterized.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Rectangle Parameterized shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl)

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct)

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H)

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangleParameterized`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangleParameterized`

#### Summary

Defines parameters for parameterized rectangle structural section.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionPipeStandard.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionPipeStandard.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of Structural Section Pipe Standard shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `diameter`

Pipe Diameter.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `principalAxesAngle`

Rotation angle between the principal axes and cross section reference planes.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `sectionArea`

Cross section area.

#### Parameter `perimeter`

Painting surface of the unit length.

#### Parameter `nominalWeight`

Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.

#### Parameter `momentOfInertiaStrongAxis`

Moment of Inertia about main strong axis (I).

#### Parameter `momentOfInertiaWeakAxis`

Moment of Inertia about main weak axis (I).

#### Parameter `elasticModulusStrongAxis`

Elastic section modulus about main strong axis for calculation of bending stresses.

#### Parameter `elasticModulusWeakAxis`

Elastic section modulus about main weak axis for calculation of bending stresses.

#### Parameter `plasticModulusStrongAxis`

Plastic section modulus in bending about main strong axis (Z, Wpl).

#### Parameter `plasticModulusWeakAxis`

Plastic section modulus in bending about main weak axis.

#### Parameter `torsionalMomentOfInertia`

Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation.

#### Parameter `torsionalModulus`

Section modulus for calculations of torsion stresses (Ct).

#### Parameter `warpingConstant`

Warping constant (Cw, Iomega, H).

#### Parameter `shearAreaStrongAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).

#### Parameter `shearAreaWeakAxis`

Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionPipeStandard`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionPipeStandard`

#### Summary

Defines parameters for pipes also known as RoundHSS or HollowStructuralSection (HSS).

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralF.#ctor(System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralF.#ctor(System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

#### Summary

Creates a new instance of Structural Section Flat Bar.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `analysisParams`

Common set of parameters for structural analysis.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralF`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralF`

#### Summary

Defines parameters for Flat Bar.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralR.WallDesignThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralR.WallDesignThickness`

#### Summary

Represents wall design thickness of rectangle.

#### Remarks

Design thickness of pipe wall is value should be thinner value than measured real value (nominal).
In EN standard it is marked as "d". //Need to be verified!!!!!!!
In ACI standard it is marked as "d". //Need to be verified!!!!!!!

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralR.WallNominalThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralR.WallNominalThickness`

#### Summary

Represents wall nominal thickness of rectangle.

#### Remarks

Nominal is measured real value of profile, should be thicker than designed.
In EN standard it is marked as "d". //Need to be verified!!!!!!!
In ACI standard it is marked as "d". //Need to be verified!!!!!!!

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralR.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralR.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

#### Summary

Creates a new instance of Structural Section Pipe.

#### Parameter `diameter`

Pipe Diameter.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `analysisParams`

Common set of parameters for structural analysis.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralR`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralR`

#### Summary

Defines parameters for pipes.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralS.#ctor(System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralS.#ctor(System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

#### Summary

Creates a new instance of Round Bar shape.

#### Parameter `diameter`

Pipe Diameter.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `analysisParams`

Common set of parameters for structural analysis.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralS`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralS`

#### Summary

Defines parameters for Round Bar structural section.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralH.OuterFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralH.OuterFillet`

#### Summary

Outer Fillet - Corner fillet outer radius.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralH.InnerFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralH.InnerFillet`

#### Summary

Inner Fillet - Corner fillet inner radius.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralH.WallDesignThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralH.WallDesignThickness`

#### Summary

Represents wall design thickness of rectangle.

#### Remarks

Design thickness of pipe wall is value should be thinner value than measured real value (nominal).

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralH.WallNominalThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralH.WallNominalThickness`

#### Summary

Represents wall nominal thickness of rectangle.

#### Remarks

Nominal is measured real value of profile, should be thicker than designed.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralH.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralH.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

#### Summary

Creates a new instance of Rectangular Pipe shape.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `outerFillet`

Outer Fillet - Corner fillet outer radius.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `analysisParams`

Common set of parameters for structural analysis.

#### Since

2018
