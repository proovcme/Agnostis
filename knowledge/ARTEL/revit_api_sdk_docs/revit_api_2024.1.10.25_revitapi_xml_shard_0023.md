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
Shard: 23
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `T:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment`

#### Summary

Represents an analytical segment of the MEP analytical model.

#### Since

2024

### `T:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType`

#### Summary

The type of analytical segment.

#### Since

2024

#### Since

2024

### `F:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType.SourceEquipment`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType.SourceEquipment`

#### Summary

The source equipment (e.g., chiller, boiler, etc.)

### `F:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType.Loss`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType.Loss`

#### Summary

The terminal loss (e.g., radiator, coil, etc.)

### `F:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType.Pump`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType.Pump`

#### Summary

The segment is pump.

### `F:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType.Fitting`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType.Fitting`

#### Summary

The segment is fitting.

### `F:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType.Segment`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType.Segment`

#### Summary

The segment is undefined.

### `F:Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType.Undefined`

#### Summary

The segment is undefined.

### `M:Autodesk.Revit.DB.Analysis.MEPAnalyticalNode.IsSameNode(Autodesk.Revit.DB.Analysis.MEPAnalyticalNode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalNode.IsSameNode(Autodesk.Revit.DB.Analysis.MEPAnalyticalNode)`

#### Summary

Verify if this node is connected to the other node and thus represents the same analytical node in the network.

#### Parameter `other`

The other node to be compared.

#### Returns

True if two nodes represent the same node of the network. Otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalNode.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalNode.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalNode.Location`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalNode.Location`

#### Summary

The location of this node.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalNode.IsFlowBlocked`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalNode.IsFlowBlocked`

#### Summary

Is the flow blocked at this analytical node?

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalNode.IsFocalNode`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalNode.IsFocalNode`

#### Summary

Is this node a focal point of multiple branches?

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalNode.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalNode.Id`

#### Summary

The identity used in the MEPAnalyticalSegment

#### Since

2024

### `T:Autodesk.Revit.DB.Analysis.MEPAnalyticalNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalNode`

#### Summary

Represents an analytical node of the MEP analytical model.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetMEPAnalyticalModelData(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetMEPAnalyticalModelData(Autodesk.Revit.DB.Element)`

#### Summary

Gets the MEP analytical model data of the specified element.

#### Parameter `pElement`

The element that owns the MEP analytical model data.

#### Returns

The MEP analytical model data of this element, null if not available.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetNodeByIndex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetNodeByIndex(System.Int32)`

#### Summary

Gets the specified analytical node.

#### Parameter `index`

The node index number by their storing sequence, starting from 0.

#### Returns

The returned analytical node.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index must range from 0 to GetNumberOfNodes()-1.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.IsValidNodeId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.IsValidNodeId(System.Int32)`

#### Summary

Verifies if a valid analytical node id.

#### Parameter `nodeId`

The node id to be verified.

#### Returns

True if valid, otherwise false.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetNodeById(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetNodeById(System.Int32)`

#### Summary

Gets the analytical node with the specified id.

#### Parameter `nodeId`

The node identifier, be aware that this identifier may not be sequentially ordered for all analytical nodes.

#### Returns

The returned analytical node.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input must be a valid node id.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetNumberOfSegments`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetNumberOfSegments`

#### Summary

Returns the number of analytical segments.

#### Returns

The total number of

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetNumberOfNodes`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetNumberOfNodes`

#### Summary

Returns the number of analytical nodes.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetSegmentData(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetSegmentData(System.Int32)`

#### Summary

Gets the analysis data on the specified segment.

#### Parameter `segmentId`

The segment id to be retrieved.

#### Returns

The calculated data of this segment. Be aware that the segment data may be invalid if the calculation failed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input must be a valid segment id.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.IsValidSegmentId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.IsValidSegmentId(System.Int32)`

#### Summary

Verifies if a valid segment id.

#### Parameter `segmentId`

The segment id to be verified.

#### Returns

True if the id is a valid segment id, otherwise false.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetSegmentByIndex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetSegmentByIndex(System.Int32)`

#### Summary

Gets the analytical segment at the specified position.

#### Parameter `index`

The index where the segment is stored. This index is 0 based.

#### Returns

The returned analytical segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index must range from 0 to GetNumberOfSegments()-1.

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetSegmentById(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.GetSegmentById(System.Int32)`

#### Summary

Gets the analytical segment with the specified id.

#### Parameter `segmentId`

The segment id to be retrieved. This id is not 0 based.

#### Returns

The returned analytical segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input must be a valid segment id.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData`

#### Summary

Represents the MEP analytical model data attached to individual element.

#### Remarks

The MEP analytical model is composed of generic analytical segments and nodes.
Each Revit element may have one or more analytical segments. Connected together,
these data form a network that is used in the flow and pressure drop calculation.

#### Since

2024

### `M:Autodesk.Revit.DB.Mechanical.MEPAnalyticalSystem.GetAirSystemData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPAnalyticalSystem.GetAirSystemData`

#### Summary

Returns the air system data, null if not available.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Mechanical.MEPAnalyticalSystem.GetWaterLoopData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPAnalyticalSystem.GetWaterLoopData`

#### Summary

Returns the water loop data, null if not available.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Mechanical.MEPAnalyticalSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Mechanical.AnalyticalSystemDomain,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPAnalyticalSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Mechanical.AnalyticalSystemDomain,System.String)`

#### Summary

Creates a new analytical system

#### Parameter `document`

The document where the new element will be created.

#### Parameter `domain`

The domain of analytical system to be created.

#### Parameter `name`

The name of new analytical system. The actual name may be post-fixed if already exists.

#### Returns

The newly created analytical system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
name is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

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

### `P:Autodesk.Revit.DB.Mechanical.MEPAnalyticalSystem.AnalyticalSystemDomain`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPAnalyticalSystem.AnalyticalSystemDomain`

#### Summary

The type of analytical system.

#### Since

2020.1

### `T:Autodesk.Revit.DB.Mechanical.MEPAnalyticalSystem`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MEPAnalyticalSystem`

#### Summary

Represents an analytical system where the air or water is circulated to satisfy building energy requirements.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetAllDownstreamOnDutyLoadIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetAllDownstreamOnDutyLoadIds`

#### Summary

Get all the descendant on duty Electrical Analytical Load ids of the node.

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetAnalyticalLoadClassificationData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetAnalyticalLoadClassificationData`

#### Summary

Gets the electrical analytical load classification data which used to get demand load detail information of the node.

#### Returns

The electrical analytical load classification data.

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetAnalyticalLoadScenariosData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetAnalyticalLoadScenariosData`

#### Summary

Gets the electrical analytical load scenarios data.

#### Returns

The electrical analytical load scenarios data.

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetAllDownstreamLoadIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetAllDownstreamLoadIds`

#### Summary

Get all the descendant Electrical Analytical Load ids of the node.

#### Remarks

No matter the load is on stand by or not, the load id will be included in the returned load ids set.

#### Since

2024

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.CanConnectToUpstreamNode(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.CanConnectToUpstreamNode(Autodesk.Revit.DB.ElementId)`

#### Summary

Verifies that the current node can connect to the upstream node.

#### Parameter `upstreamNodeId`

The upstream node id.

#### Returns

True if the current node can connect to the upstream node.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.CanDisconnectFromUpstreamNode(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.CanDisconnectFromUpstreamNode(Autodesk.Revit.DB.ElementId)`

#### Summary

Verifies that the current node can disconnect from the upstream node.

#### Parameter `upstreamNodeId`

The upstream node id.

#### Returns

True if the current node can disconnect from the upstream node.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetDownstreamNodeIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetDownstreamNodeIds`

#### Summary

Gets the downstream node ids.

#### Remarks

If node B supplies from node A, node B is the downstream node of node A, and node A is the upstream node of node B.
Usually one node may have many downstream nodes, but TransferSwitch can only have one downstream node.

#### Returns

The array of downstream node ids.

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.DisconnectFromUpstreamNode(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.DisconnectFromUpstreamNode(Autodesk.Revit.DB.ElementId)`

#### Summary

Disconnects from upstream node.

#### Parameter `upstreamNodeId`

The upstream node id to disconnect from.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id is not an analytical distribution node id.
-or-
The analytical distribution node can not disconnect from the upstream node.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.ConnectToUpstreamNode(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.ConnectToUpstreamNode(Autodesk.Revit.DB.ElementId)`

#### Summary

Connects to upstream node.

#### Parameter `upstreamNodeId`

The upstream node id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id is not an analytical distribution node id.
-or-
The analytical distribution node is full of downstream nodes.
-or-
The analytical distribution node can not connect to the upstream node.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The analytical distribution node is full of upstream nodes.

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetUpstreamNodeIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetUpstreamNodeIds`

#### Summary

Gets upstream node ids.

#### Remarks

If node B supplies from node A, node B is the downstream node of node A, and node A is the upstream node of node B.
Usually one node only has one upstream node, but TransferSwitch may have two upstream nodes.

#### Returns

The array of upstream node ids.

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetAnalyticalPropertyData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.GetAnalyticalPropertyData`

#### Summary

Gets the electrical analytical node property data, `null` if not available.

#### Remarks

These types have special data:
Bus

TransferSwitch

EquipmentLoad

#### Returns

The electrical analytical node property data.

#### Since

2023

### `M:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType,System.String)`

#### Summary

Creates an electrical analytical node.

#### Parameter `document`

The document where the new element will be created.

#### Parameter `type`

The type of electrical analytical node to be created.

#### Parameter `name`

The name of new electrical analytical node. The actual name may be post-fixed if already exists.

#### Returns

The newly created electrical analytical node.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
name is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

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

2023

### `P:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.TotalLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.TotalLoad`

#### Summary

The Total Connected Load.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.NodeType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode.NodeType`

#### Summary

The type of electrical analytical node.

#### Since

2023

### `T:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode`

#### Summary

Represents an electrical analytical node under the Analytical Power Distribution in the System Browser.

#### Remarks

This represents one of any number of types, as specified by the `T:Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType` .
Some of those types will have `T:Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData` while others will not, and if they do have data they can be downcast to a specific subclass of data to be used.

#### Since

2023

### `M:Autodesk.Revit.DB.MEPAnalyticalConnectionType.FindTypeByName(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPAnalyticalConnectionType.FindTypeByName(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Finds the analytical connection type by its name.

#### Parameter `doc`

The document where the analytical conneciton type is expected.

#### Parameter `name`

The name of the expected analytical connection type.

#### Returns

The element id of matched analytical connection type, otherwise invalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.MEPAnalyticalConnectionType.IsNameUnused(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPAnalyticalConnectionType.IsNameUnused(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Checks if this is an unused name.

#### Parameter `doc`

The document.

#### Parameter `name`

The name to be verified.

#### Returns

True if not used by an existing analytical connection type in this document, false if used.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.MEPAnalyticalConnectionType.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPAnalyticalConnectionType.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates an analytical connection type element.

#### Remarks

The newly created type would have the default pressure loss being 0.
Use ElementType.duplicate to copy from any existing type.

#### Parameter `doc`

The document.

#### Parameter `name`

The name of the analytical type to be created.

#### Returns

The created analytical connection type element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This name is already used by an existing analytical connection type in the document.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
name is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.MEPAnalyticalConnectionType.PressureLoss`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPAnalyticalConnectionType.PressureLoss`

#### Summary

The pressure loss of this analytical connection type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for pressureLoss must be non-negative.

#### Since

2018

### `T:Autodesk.Revit.DB.MEPAnalyticalConnectionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.MEPAnalyticalConnectionType`

#### Summary

Represents an analytical connection type between mechanical equipment and piping network.

#### Since

2018

### `M:Autodesk.Revit.DB.MEPAnalyticalConnection.GetFlow`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPAnalyticalConnection.GetFlow`

#### Summary

Gets the flow value of this analytical connection.

#### Remarks

If the network flow is asynchronously calculated, this method would wait until the calculation is completed.
This ensures the returned flow value is always up to date.

#### Returns

The flow value.

#### Since

2018

### `M:Autodesk.Revit.DB.MEPAnalyticalConnection.CreateMultipleConnections(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.Connector},System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPAnalyticalConnection.CreateMultipleConnections(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.Connector},System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Creates new analytical connections between the equipment connector and the nearest point on the curves.

#### Parameter `doc`

The document where the new elements are created.

#### Parameter `typeId`

The type of new analytical connections.

#### Parameter `equipmentOpenConnectors`

The open equipment connectors to be analytically connected.

#### Parameter `curveIdsToConnect`

The curves which the equipment is connected to.

#### Returns

The new analytical connection elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid connection type.
-or-
Not all connectors support the analytical connection.
-or-
No connector included.
-or-
Not all elements are valid curve ids.
-or-
No curve included.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.MEPAnalyticalConnection.CanSupportAnalyticalConnection(Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPAnalyticalConnection.CanSupportAnalyticalConnection(Autodesk.Revit.DB.Connector)`

#### Summary

Checks if the connector can support the analytical connection.

#### Parameter `connector`

The testing connector.

#### Returns

True if the connector can support the network flow/pressure analysis, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.MEPAnalyticalConnection.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPAnalyticalConnection.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Creates a new analytical connection between two open connectors.

#### Parameter `doc`

The document where the new element is created.

#### Parameter `typeId`

The type of new analytical connection.

#### Parameter `startConnector`

The open connector on the equipment side, whose level is inherited by the analytical connection.

#### Parameter `endConnector`

The open connector on the network.

#### Returns

The newly created analytical connection element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Invalid connection type.
-or-
The connector does not support analytical connection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `T:Autodesk.Revit.DB.MEPAnalyticalConnection`

Member kind: type
Symbol: `Autodesk.Revit.DB.MEPAnalyticalConnection`

#### Summary

Represents an analytical element that connects mechanical equipment to piping network.

#### Remarks

The analytical connection takes mechanical equipment into account of network flow/pressure analysis.
The connection remains the same even if the mechanical equipment moves and rotates. It enables a
fast establishment of piping network to analyze the flow and pressure, especially at the early stage
of the design process.

#### Since

2018

### `M:Autodesk.Revit.Exceptions.ExceptionConvertor.GenerateAPIException(ApplicationException!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.ExceptionConvertor.GenerateAPIException(ApplicationException!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Converts a Revit native exception to a matching .NET exception.

#### Remarks

This function exists because it was faster to have the code calling NativeToManaged outside of the macros below and in
a single location in the function. For managed exception processing and default exception generation this did not seem faster, so
those exception types are handled directly in the macros.

### `M:Autodesk.Revit.Exceptions.SchemaException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.SchemaException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.SchemaException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.SchemaException`

#### Summary

The exception thrown when Revit cannot interpret a data structure described by a schema.

#### Since

2024

### `M:Autodesk.Revit.Exceptions.DefaultValueException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.DefaultValueException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.DefaultValueException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.DefaultValueException`

#### Summary

The exception thrown when Revit cannot initialize a default value for a family parameter.

#### Since

2024

### `M:Autodesk.Revit.Exceptions.AccessDeniedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.AccessDeniedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `M:Autodesk.Revit.Exceptions.UnauthenticatedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.UnauthenticatedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `M:Autodesk.Revit.Exceptions.ResourceNotFoundException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.ResourceNotFoundException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `M:Autodesk.Revit.Exceptions.ServerInternalException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.ServerInternalException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `M:Autodesk.Revit.Exceptions.NetworkCommunicationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.NetworkCommunicationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `M:Autodesk.Revit.Exceptions.BackgroundTaskCancelledException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.BackgroundTaskCancelledException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.BackgroundTaskCancelledException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.BackgroundTaskCancelledException`

#### Summary

The exception thrown when Revit cancels a background operation. Third-party
developers are not expected to catch and handle this exception. Instead, if allowed
to propagate back to Revit code, it will be handled by Revit.

#### Since

2017

### `M:Autodesk.Revit.Exceptions.TransientElementCreationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.TransientElementCreationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.TransientElementCreationException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.TransientElementCreationException`

#### Summary

The exception that is thrown when TransientElementCreationScope is used incorrectly.

#### Remarks

The exception would be thrown in the following cases:
An element that does not support TransientElementCreationScope is being created in the Scope.

A TransientElementCreationScope is being created while another such scope is already active.

#### Since

2016

### `M:Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException`

#### Summary

The exception thrown when both a central model
and also a local file for the same central model are opened in the same session.

#### Since

2014

### `M:Autodesk.Revit.Exceptions.NotTransmittedModelException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.NotTransmittedModelException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.NotTransmittedModelException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.NotTransmittedModelException`

#### Summary

The exception thrown when OpenOptions were provided to deal with
a transmitted model, but the model is not transmitted.

#### Since

2014

### `M:Autodesk.Revit.Exceptions.TransmittedModelException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.TransmittedModelException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.TransmittedModelException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.TransmittedModelException`

#### Summary

The exception thrown when model was transmitted (sent by eTransmit)
and insufficient OpenOptions were provided to handle its transmitted flag.

#### Since

2014

### `M:Autodesk.Revit.Exceptions.WrongUserException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.WrongUserException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.WrongUserException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.WrongUserException`

#### Summary

The exception thrown when a local model is manipulated under
a different username than it was created with.

#### Since

2014

### `M:Autodesk.Revit.Exceptions.CheckoutElementsRequestTooLargeException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.CheckoutElementsRequestTooLargeException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.CheckoutElementsRequestTooLargeException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.CheckoutElementsRequestTooLargeException`

#### Summary

Exception is thrown when too many elements are requested for checkout

#### Since

2021

### `M:Autodesk.Revit.Exceptions.CentralModelVersionArchivedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.CentralModelVersionArchivedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.CentralModelVersionArchivedException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.CentralModelVersionArchivedException`

#### Summary

Exception is thrown when last central version merged into the local model has been archived in the central model.
Reload Latest or Synchronized with Central needs to be conducted before the current failed operation is retried.

#### Since

2021

### `M:Autodesk.Revit.Exceptions.CentralModelAlreadyExistsException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.CentralModelAlreadyExistsException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.CentralModelAlreadyExistsException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.CentralModelAlreadyExistsException`

#### Summary

Exception is thrown when the central model already exists at the specified location.

#### Since

2015

### `M:Autodesk.Revit.Exceptions.OutdatedDirectlyOpenedCentralException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.OutdatedDirectlyOpenedCentralException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.OutdatedDirectlyOpenedCentralException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.OutdatedDirectlyOpenedCentralException`

#### Summary

The exception thrown when a central model is opened directly and its copy in the session is
outdated. If the operation is supported for local files, first resave as local, and try again.

#### Since

2014

### `M:Autodesk.Revit.Exceptions.CentralModelContentionException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.CentralModelContentionException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `P:Autodesk.Revit.Exceptions.CentralModelContentionException.CurrentUser`

Member kind: property
Symbol: `Autodesk.Revit.Exceptions.CentralModelContentionException.CurrentUser`

#### Summary

Retrieves current user name.

### `T:Autodesk.Revit.Exceptions.CentralModelContentionException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.CentralModelContentionException`

#### Summary

The exception thrown when a central model is busy (locked)
and the operation is canceled.

#### Since

2014

### `M:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.CentralModelAccessDeniedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.CentralModelAccessDeniedException`

#### Summary

The exceptions thrown when a central model can be reached but
access is denied due to a lack of access privileges.

#### Since

2014

### `M:Autodesk.Revit.Exceptions.CentralFileCommunicationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.CentralFileCommunicationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.CentralFileCommunicationException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.CentralFileCommunicationException`

#### Summary

The exception thrown when there is a network communication error involving a file-based central model.

#### Since

2014

### `M:Autodesk.Revit.Exceptions.CentralModelIncompatibleRollbackException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.CentralModelIncompatibleRollbackException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.CentralModelIncompatibleRollbackException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.CentralModelIncompatibleRollbackException`

#### Summary

The exception thrown when a model's central version has been rolled back.
This leaves the local model incompatible with the central model.

### `M:Autodesk.Revit.Exceptions.CentralModelIncompatibleRelinquishException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.CentralModelIncompatibleRelinquishException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.CentralModelIncompatibleRelinquishException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.CentralModelIncompatibleRelinquishException`

#### Summary

The exception thrown when the user has been force relinquished from the model.
This leaves the local model incompatible with the central model.

### `M:Autodesk.Revit.Exceptions.CentralModelMissingException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.CentralModelMissingException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.CentralModelMissingException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.CentralModelMissingException`

#### Summary

The exception would be thrown when a model's central is missing, may be moved or deleted.

#### Remarks

Any operations for cloud or Revit Server model would get this exception if model is removed or deleted.

#### Since

2019

### `M:Autodesk.Revit.Exceptions.CentralModelException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.CentralModelException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.CentralModelException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.CentralModelException`

#### Summary

The base class for exceptions that are
common to both file-based and server-based central models or
specific to just file-based central models.

#### Since

2014

### `M:Autodesk.Revit.Exceptions.RevitServerModelNameBreaksConventionException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.RevitServerModelNameBreaksConventionException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.RevitServerModelNameBreaksConventionException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.RevitServerModelNameBreaksConventionException`

#### Summary

The exception that is thrown when the model is breaking the project naming convention.

#### Since

2022

### `M:Autodesk.Revit.Exceptions.RevitServerModelAlreadyExistsException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.RevitServerModelAlreadyExistsException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.RevitServerModelAlreadyExistsException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.RevitServerModelAlreadyExistsException`

#### Summary

The exception that is thrown when there is a model with the same name already exist.

#### Since

2022

### `M:Autodesk.Revit.Exceptions.RevitServerCollaborationNotAvailableException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.RevitServerCollaborationNotAvailableException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.RevitServerCollaborationNotAvailableException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.RevitServerCollaborationNotAvailableException`

#### Summary

The exception that is thrown when Collaboration fails because of an external resource (e.g., Amazon S3) failure.

### `M:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

#### Summary

The exception that is thrown when an unauthenticated user attempts to initiate a call to RevitServer.

### `M:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.RevitServerUnauthorizedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

#### Summary

The exception that is thrown when a call to the server is unauthorized.

### `M:Autodesk.Revit.Exceptions.RevitServerInternalException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.RevitServerInternalException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.RevitServerInternalException`

#### Summary

The exception that is thrown when there is any server internal error happening.

### `M:Autodesk.Revit.Exceptions.RevitServerCommunicationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.RevitServerCommunicationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.RevitServerCommunicationException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.RevitServerCommunicationException`

#### Summary

The exception that is thrown when there is any network communication error happening.

### `M:Autodesk.Revit.Exceptions.RevitServerException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.RevitServerException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.RevitServerException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.RevitServerException`

#### Summary

The exception that is base class for all exceptions originating from the Revit server.

### `M:Autodesk.Revit.Exceptions.CorruptModelException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.CorruptModelException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.CorruptModelException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.CorruptModelException`

#### Summary

The exception that is thrown when the model is or seems corrupt.

### `M:Autodesk.Revit.Exceptions.OperationCanceledException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.OperationCanceledException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.OperationCanceledException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.OperationCanceledException`

#### Summary

The exception that is thrown when an operation is unexpectedly cancelled.

### `M:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException`

#### Summary

The exception that is thrown when the optional functionality is not available in the installed Revit

### `M:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

#### Summary

The exception that is thrown when making or attempting to make changes that are forbidden during dynamic updates to the model.

#### Remarks

Modifications leading to a new mutual relationship between
elements that did not depend on each other before are potentially
not safe in work-set environment. This exception is thrown when
an Updater either makes such modifications or attempts to call
a method that will or may modify the model in such unsafe matter.

### `M:Autodesk.Revit.Exceptions.AutoJoinFailedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.AutoJoinFailedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.AutoJoinFailedException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.AutoJoinFailedException`

#### Summary

The exception that is thrown when an autojoin operation failed.

### `M:Autodesk.Revit.Exceptions.RegenerationFailedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.RegenerationFailedException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.RegenerationFailedException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.RegenerationFailedException`

#### Summary

The exception that is thrown when a regeneration operation failed.

### `M:Autodesk.Revit.Exceptions.ExternalApplicationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.ExternalApplicationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.ExternalApplicationException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.ExternalApplicationException`

#### Summary

The exception that is thrown when an issue in the Add-Ins resulted in an unexpected error.

#### Remarks

Please contact your external application provider with the information about what led to this exception.

### `M:Autodesk.Revit.Exceptions.InternalException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.InternalException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.InternalException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.InternalException`

#### Summary

The exception that is thrown when an issue in the Revit code resulted in an unexpected error.

#### Remarks

Please contact Autodesk Developer Support with the information about what led to this exception.

### `M:Autodesk.Revit.Exceptions.InvalidDataStreamException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.InvalidDataStreamException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.InvalidDataStreamException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.InvalidDataStreamException`

#### Summary

The exception that is thrown when the reading or saving operation failed due to parsing error.

### `M:Autodesk.Revit.Exceptions.FileAccessException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.FileAccessException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.FileAccessException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.FileAccessException`

#### Summary

The exception that is thrown when the specified file could not be accessed, e.g. read-only, locked by the OS etc.

### `M:Autodesk.Revit.Exceptions.DirectoryNotFoundException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.DirectoryNotFoundException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.DirectoryNotFoundException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.DirectoryNotFoundException`

#### Summary

The exception that is thrown when the specified directory could not be found.

### `M:Autodesk.Revit.Exceptions.FileNotFoundException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.FileNotFoundException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.FileNotFoundException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.FileNotFoundException`

#### Summary

The exception that is thrown when the specified file could not be found.

### `M:Autodesk.Revit.Exceptions.IOException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.IOException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.IOException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.IOException`

#### Summary

The exception that is thrown when an I/O error occurs.

### `M:Autodesk.Revit.Exceptions.InsufficientResourcesException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.InsufficientResourcesException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.InsufficientResourcesException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.InsufficientResourcesException`

#### Summary

The exception that is thrown when the OS runs out of resources,
e.g. memory, disk space, or USER or GDI objects.

### `M:Autodesk.Revit.Exceptions.DisabledDisciplineException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.DisabledDisciplineException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.DisabledDisciplineException`

#### Summary

The exception that is thrown when the function cannot execute because
a discipline is disabled. The exception specifies which discipline(s) would let
the operation succeed.

### `M:Autodesk.Revit.Exceptions.FamilyContextException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.FamilyContextException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.FamilyContextException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.FamilyContextException`

#### Summary

The exception that is thrown when an operation is invalid in the current family document, because of the type of family.

### `M:Autodesk.Revit.Exceptions.InapplicableDataException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.InapplicableDataException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.InapplicableDataException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.InapplicableDataException`

#### Summary

The exception that is thrown when attempting to access a piece of data that is structurally not part of an object at the moment.

### `M:Autodesk.Revit.Exceptions.ObjectAccessException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.ObjectAccessException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.ObjectAccessException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.ObjectAccessException`

#### Summary

The exception that is thrown when an operation is denied, e.g. an attempt was made to set a read-only property.

### `M:Autodesk.Revit.Exceptions.ModificationForbiddenException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.ModificationForbiddenException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.ModificationForbiddenException`

#### Summary

The exception that is thrown by the undo transaction framework when a modification operation is not allowed.

#### Remarks

See also: `!:Autodesk::Revit::DB::Element::IsModifiable` and `!:Autodesk::Revit::DB::Document::IsModifiable` .

### `M:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.ModificationOutsideTransactionException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

#### Summary

The exception that is thrown by the undo transaction framework when the modification operation to the model is outside of a transaction.

### `M:Autodesk.Revit.Exceptions.InvalidObjectException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.InvalidObjectException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.InvalidObjectException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.InvalidObjectException`

#### Summary

The exception that is thrown when referencing an object that is no longer valid.

#### Remarks

The object may no longer exist for many reasons:
The object was explicitly deleted from the database.

A change to other database items caused the item to be automatically deleted from the database.

The object no longer exists as its creation was undone (by rolling a transaction back).

### `M:Autodesk.Revit.Exceptions.InvalidOperationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.InvalidOperationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.InvalidOperationException`

#### Summary

The exception that is thrown when a method call is invalid for the object's current state.

### `M:Autodesk.Revit.Exceptions.ArgumentsInconsistentException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.ArgumentsInconsistentException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

#### Summary

The exception that is thrown when each individual argument is OK, but a joint constraint is violated.

### `M:Autodesk.Revit.Exceptions.FileArgumentAlreadyExistsException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.FileArgumentAlreadyExistsException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.FileArgumentAlreadyExistsException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.FileArgumentAlreadyExistsException`

#### Summary

The exception that is thrown when the specified file exists.

### `M:Autodesk.Revit.Exceptions.FileArgumentNotFoundException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.FileArgumentNotFoundException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

#### Summary

The exception that is thrown when a method received a filename as an argument and requires it to exist as a precondition.

### `M:Autodesk.Revit.Exceptions.DirectoryNotEmptyException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.DirectoryNotEmptyException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.DirectoryNotEmptyException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.DirectoryNotEmptyException`

#### Summary

The exception that is thrown when a method received a directory as an argument and
requires that the directory be empty but the directory is not empty.

#### Since

2024

### `M:Autodesk.Revit.Exceptions.InvalidPathArgumentException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.InvalidPathArgumentException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.InvalidPathArgumentException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.InvalidPathArgumentException`

#### Summary

The exception that is thrown when a method received a pathname as an argument, but the pathname is
illegal: too long, invalid characters, etc.

### `M:Autodesk.Revit.Exceptions.ArgumentNullException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.ArgumentNullException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.ArgumentNullException`

#### Summary

The exception that is thrown when `null` is passed to a method that does not accept it as a valid argument.

### `M:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.ArgumentOutOfRangeException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

#### Summary

The exception that is thrown when the value of an argument is outside the allowable range of values as defined by the invoked method.

### `P:Autodesk.Revit.Exceptions.ArgumentException.ParamName`

Member kind: property
Symbol: `Autodesk.Revit.Exceptions.ArgumentException.ParamName`

#### Summary

Gets the name of the parameter that causes this exception.

### `P:Autodesk.Revit.Exceptions.ArgumentException.Message`

Member kind: property
Symbol: `Autodesk.Revit.Exceptions.ArgumentException.Message`

#### Summary

Gets the error message and the parameter name, or only the error message if no parameter name is set.

#### Remarks

The text of Message should completely describe the error and should, when possible, explain how to correct it.

### `M:Autodesk.Revit.Exceptions.ArgumentException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.ArgumentException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.ArgumentException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.ArgumentException`

#### Summary

The exception that is thrown when one of the arguments provided to a method is not valid.

#### Remarks

This is the base class for exceptions that are thrown while validating the arguments to a function.

### `P:Autodesk.Revit.Exceptions.ApplicationException.FunctionId`

Member kind: property
Symbol: `Autodesk.Revit.Exceptions.ApplicationException.FunctionId`

#### Summary

The information of the function throwing the exception.

### `M:Autodesk.Revit.Exceptions.ApplicationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.ApplicationException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.ApplicationException`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.ApplicationException`

#### Summary

The exception that is thrown when a non-fatal application error occurs.

#### Remarks

This class is the base class of all Revit specified exceptions.

### `P:Autodesk.Revit.Exceptions.FunctionId.Function`

Member kind: property
Symbol: `Autodesk.Revit.Exceptions.FunctionId.Function`

#### Summary

The name of the function throwing an exception.

### `P:Autodesk.Revit.Exceptions.FunctionId.Line`

Member kind: property
Symbol: `Autodesk.Revit.Exceptions.FunctionId.Line`

#### Summary

The line number of the function throwing an exception.

### `P:Autodesk.Revit.Exceptions.FunctionId.File`

Member kind: property
Symbol: `Autodesk.Revit.Exceptions.FunctionId.File`

#### Summary

The name of the file including the function throwing an exception.

### `M:Autodesk.Revit.Exceptions.FunctionId.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

Member kind: method
Symbol: `Autodesk.Revit.Exceptions.FunctionId.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)`

#### Summary

Retrieves data needed to serialize the target object.

#### Parameter `info`

Data needed to serialize or deserialize the object.

#### Parameter `context`

The destination of the serialized stream.

### `T:Autodesk.Revit.Exceptions.FunctionId`

Member kind: type
Symbol: `Autodesk.Revit.Exceptions.FunctionId`

#### Summary

The information of a function throwing an exception.

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
