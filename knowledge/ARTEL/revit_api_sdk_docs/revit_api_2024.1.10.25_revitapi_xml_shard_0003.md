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
Shard: 3
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.IPerformanceAdviserRule.InitCheck(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRule.InitCheck(Autodesk.Revit.DB.Document)`

#### Summary

Invoked by performance advisor once in the beginning of the check. If rule checks document as a whole,
the check can be performed in this method.

#### Parameter `document`

Document for which performance problems are being checked.

#### Since

2012

### `T:Autodesk.Revit.DB.IPerformanceAdviserRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRule`

#### Summary

Base class to derive specific performance adviser rules from.

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.GetRuleDescription(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.GetRuleDescription(System.Int32)`

#### Summary

Retrieves the description of the rule.

#### Parameter `index`

The rule index to get information for.

#### Returns

The description of the rule.

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.GetRuleName(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.GetRuleName(System.Int32)`

#### Summary

Retrieves the name of the rule.

#### Parameter `index`

The rule index to get information for.

#### Returns

The name of the rule.

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.GetElementFilterFromRule(System.Int32,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.GetElementFilterFromRule(System.Int32,Autodesk.Revit.DB.Document)`

#### Summary

Retrieves a filter to restrict elements to be checked.

#### Parameter `index`

The rule index to get information for.

#### Parameter `document`

Document for which performance problems are being checked.

#### Returns

The filter to restrict elements to be checked.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.WillRuleCheckElements(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.WillRuleCheckElements(System.Int32)`

#### Summary

Reports if rule needs to be executed on individual elements.

#### Parameter `index`

The rule index to get information for.

#### Returns

True if rule needs to be executed on individual elements.

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.GetRuleDescription(Autodesk.Revit.DB.PerformanceAdviserRuleId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.GetRuleDescription(Autodesk.Revit.DB.PerformanceAdviserRuleId)`

#### Summary

Retrieves the description of the rule.

#### Parameter `id`

The rule id to get information for.

#### Returns

The description of the rule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.GetRuleName(Autodesk.Revit.DB.PerformanceAdviserRuleId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.GetRuleName(Autodesk.Revit.DB.PerformanceAdviserRuleId)`

#### Summary

Retrieves the name of the rule.

#### Parameter `id`

The rule id to get information for.

#### Returns

The name of the rule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.GetElementFilterFromRule(Autodesk.Revit.DB.PerformanceAdviserRuleId,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.GetElementFilterFromRule(Autodesk.Revit.DB.PerformanceAdviserRuleId,Autodesk.Revit.DB.Document)`

#### Summary

Retrieves a filter to restrict elements to be checked.

#### Parameter `id`

The rule id to get information for.

#### Parameter `document`

Document for which performance problems are being checked.

#### Returns

The filter to restrict elements to be checked.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.WillRuleCheckElements(Autodesk.Revit.DB.PerformanceAdviserRuleId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.WillRuleCheckElements(Autodesk.Revit.DB.PerformanceAdviserRuleId)`

#### Summary

Reports if rule needs to be executed on individual elements.

#### Parameter `id`

The rule id to get information for.

#### Returns

True if rule needs to be executed on individual elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.PostWarning(Autodesk.Revit.DB.FailureMessage)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.PostWarning(Autodesk.Revit.DB.FailureMessage)`

#### Summary

Reports a problem detected during execution of a rule.

#### Parameter `message`

Warning describing the problem detected by a rule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The message must have severity "warning".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Performance advisor is not executing rules.

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.ExecuteRules(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{System.Int32})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.ExecuteRules(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{System.Int32})`

#### Summary

Executes selected rules on a given document.

#### Remarks

Disabled rules are not executed.

#### Parameter `document`

Document on which the rules will be executed.

#### Parameter `rules`

Indices of rules to be executed.

#### Returns

Failure messages explaining performance problems detected in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.ExecuteRules(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.PerformanceAdviserRuleId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.ExecuteRules(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.PerformanceAdviserRuleId})`

#### Summary

Executes selected rules on a given document.

#### Parameter `document`

Document on which the rules will be executed.

#### Parameter `rules`

Ids of rules to be executed.

#### Returns

Failure messages explaining performance problems detected in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.ExecuteAllRules(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.ExecuteAllRules(Autodesk.Revit.DB.Document)`

#### Summary

Executes all rules in the list on a given document.

#### Remarks

Disabled rules are not executed.

#### Parameter `document`

Document on which the rules will be executed.

#### Returns

Failure messages explaining performance problems detected in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.SetRuleEnabled(Autodesk.Revit.DB.PerformanceAdviserRuleId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.SetRuleEnabled(Autodesk.Revit.DB.PerformanceAdviserRuleId,System.Boolean)`

#### Summary

Retrieves an enabled/disabled status for the given rule.

#### Parameter `id`

The rule id to set enabled/disabled status for.

#### Parameter `enabled`

True enables the rule, false disables.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id does not correspond to any registered rule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.SetRuleEnabled(System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.SetRuleEnabled(System.Int32,System.Boolean)`

#### Summary

Retrieves an enabled/disabled status for the given rule.

#### Parameter `index`

The rule index to set enabled/disabled status for.

#### Parameter `enabled`

True enables the rule, false disables.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The index is outside of acceptable range.

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.IsRuleEnabled(Autodesk.Revit.DB.PerformanceAdviserRuleId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.IsRuleEnabled(Autodesk.Revit.DB.PerformanceAdviserRuleId)`

#### Summary

Retrieves an enabled/disabled status for the given rule.

#### Parameter `id`

The rule id to retrieve enabled/disabled status for.

#### Returns

True if rule is disabled, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The id does not correspond to any registered rule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.IsRuleEnabled(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.IsRuleEnabled(System.Int32)`

#### Summary

Retrieves an enabled/disabled status for the given rule.

#### Parameter `index`

The rule index to retrieve enabled/disabled status for.

#### Returns

True if rule is disabled, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The index is outside of acceptable range.

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.GetAllRuleIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.GetAllRuleIds`

#### Summary

Retrieves an enumeration of rule Ids.

#### Returns

A collection of rule Ids

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.GetRuleId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.GetRuleId(System.Int32)`

#### Summary

Retrieves an id of a rule for a given index in the list.

#### Parameter `index`

The index to retrieve the rule id for.

#### Returns

The rule id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The index is outside of acceptable range.

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.GetNumberOfRules`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.GetNumberOfRules`

#### Summary

Retrieves number of performance adviser rules in the list.

#### Returns

Number of performance adviser rules in the list.

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.DeleteRule(Autodesk.Revit.DB.PerformanceAdviserRuleId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.DeleteRule(Autodesk.Revit.DB.PerformanceAdviserRuleId)`

#### Summary

Deletes a performance adviser rule from the list of rules.

#### Parameter `id`

An id of the rule to be deleted from the list of rules.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.AddRule(Autodesk.Revit.DB.PerformanceAdviserRuleId,Autodesk.Revit.DB.IPerformanceAdviserRule)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.AddRule(Autodesk.Revit.DB.PerformanceAdviserRuleId,Autodesk.Revit.DB.IPerformanceAdviserRule)`

#### Summary

Adds a performance adviser rule to the list of rules.

#### Parameter `id`

An id of the rule to be added to the list of rules.

#### Parameter `rule`

The rule to be added

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PerformanceAdviser.GetPerformanceAdviser`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.GetPerformanceAdviser`

#### Summary

Returns the only instance of PerformanceAdviser in the Application.

#### Returns

The only instance of PerformanceAdviser in the Application.

#### Since

2012

### `P:Autodesk.Revit.DB.PerformanceAdviser.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PerformanceAdviser.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.PerformanceAdviser`

Member kind: type
Symbol: `Autodesk.Revit.DB.PerformanceAdviser`

#### Summary

The tool to report performance problems in a given document.

#### Remarks

Class is an application-wide singleton that performs a dual role: it is a repository of rules to run
in order to detect potential performance problems as well as an access point to execute checks.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.PathReinforcementType.CreateDefaultPathReinforcementType(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcementType.CreateDefaultPathReinforcementType(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new PathReinforcementType object with a default name.

#### Parameter `ADoc`

The document.

#### Returns

The newly created type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.PathReinforcementType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.PathReinforcementType`

#### Summary

An object that specifies the type of a Structural Path Reinforcement element in Autodesk Revit.

#### Remarks

The clear cover settings can be accessed via this object.

### `M:Autodesk.Revit.DB.Structure.PathReinSpanSymbol.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PathReinSpanSymbol.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of PathReinSpanSymbol in the project.

#### Parameter `document`

The document.

#### Parameter `viewId`

The id of the view in which the symbol should appear.

#### Parameter `hostId`

The ElementId of PathReinforcement (either in the document, or linked from another document).

#### Parameter `point`

The span symbol's head position.

#### Parameter `symbolId`

The family symbol id of this element.

#### Returns

A reference to newly created span symbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

hostId should refer to a PathReinforcement element.
-or-
viewId does not refer to a valid view type for FabricReinSpanSymbol - only floor plan, reflected ceiling plans and elevations are permitted.
-or-
symbolId should refer to a FamilySymbol of category OST_FabricReinSpanSymbol.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `T:Autodesk.Revit.DB.Structure.PathReinSpanSymbol`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.PathReinSpanSymbol`

#### Summary

Represents a Path Reinforcement Span Symbol element in Autodesk Revit.

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.SetDistanceMapModeForRooms(Autodesk.Revit.DB.View,System.Boolean,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.SetDistanceMapModeForRooms(Autodesk.Revit.DB.View,System.Boolean,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Sets Distance Map mode for the given view, displaying distances to the closest destination point.

#### Parameter `DBView`

The view to set Distance Map mode for.

#### Parameter `newState`

New state of Distance Map mode to be set for the view.

#### Parameter `destinationPoints`

Destination points for which Distance Map is calculated.
This argument is ignored when setting the mode off.

#### Returns

Result status of the operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element "DBView" is in a family document or a document in in-place edit mode.
-or-
View is not a floor plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The Path of Travel calculation service is not available

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing DBView is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing DBView has no open transaction.

#### Since

2021

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.IsInDistanceMapModeForRooms(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.IsInDistanceMapModeForRooms(Autodesk.Revit.DB.View)`

#### Summary

Returns current state of Distance Map mode for the given view.

#### Parameter `DBView`

The view to determine current state of Distance Map mode for.

#### Returns

True if Distance Map mode is ON for the view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element "DBView" is in a family document or a document in in-place edit mode.
-or-
View is not a floor plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The Path of Travel calculation service is not available

#### Since

2021

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.GetRoomForPoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.GetRoomForPoint(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.View)`

#### Summary

For a given point, get the room element which contains the point or `null` .
The Z elevation of the point is adjusted to equal the view's level elevation + 4'.
While not entirely accurate, this is a reasonable elevation approximation at which to look for a room.
The output room will be in the view's design option and phase.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.SetRevealObstaclesMode(Autodesk.Revit.DB.View,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.SetRevealObstaclesMode(Autodesk.Revit.DB.View,System.Boolean)`

#### Summary

Sets Reveal Obstacles mode for the given view.

#### Parameter `DBView`

The view to set Reveal Obstacles mode for.

#### Parameter `newState`

New state of Reveal Obstacles mode to be set for the view.

#### Returns

Result status of the operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element "DBView" is in a family document or a document in in-place edit mode.
-or-
View is not a floor plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The Path of Travel calculation service is not available

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing DBView is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing DBView has no open transaction.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.IsInRevealObstaclesMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.IsInRevealObstaclesMode(Autodesk.Revit.DB.View)`

#### Summary

Returns current state of Reveal Obstacles mode for the given view.

#### Parameter `DBView`

The view to determine current state of Reveal Obstacles mode for.

#### Returns

True if Reveal Obstacles mode is ON for the view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element "DBView" is in a family document or a document in in-place edit mode.
-or-
View is not a floor plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The Path of Travel calculation service is not available

#### Since

2020.1

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.RemoveWaypoint(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.RemoveWaypoint(System.Int32)`

#### Summary

Remove a waypoint.

#### Parameter `index`

The index of the waypoint to remove.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Index refers to a non-existent waypoint.
-or-
This functionality is not available in Revit LT.
-or-
Cannot perform this operation for a path of travel in a group.

#### Since

2020.2

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.SetWaypoint(Autodesk.Revit.DB.XYZ,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.SetWaypoint(Autodesk.Revit.DB.XYZ,System.Int32)`

#### Summary

Updates the specified waypoint.

#### Parameter `waypoint`

The new point for the waypoint.

#### Parameter `index`

The index of the waypoint to update.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Index refers to a non-existent waypoint.
-or-
This functionality is not available in Revit LT.
-or-
Cannot perform this operation for a path of travel in a group.

#### Since

2020.2

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.InsertWaypoint(Autodesk.Revit.DB.XYZ,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.InsertWaypoint(Autodesk.Revit.DB.XYZ,System.Int32)`

#### Summary

Insert a waypoint at the specified index

#### Parameter `waypoint`

The waypoint to insert.

#### Parameter `index`

The index to insert the waypoint at.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Index is invalid for an existing or new waypoint for this path.
-or-
This functionality is not available in Revit LT.
-or-
Cannot perform this operation for a path of travel in a group.

#### Since

2020.2

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.GetWaypoints`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.GetWaypoints`

#### Summary

return the waypoints set for the Path of Travel

#### Since

2020.2

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.GetCurves`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.GetCurves`

#### Summary

Gets the array of curves representing the path of travel.

#### Returns

The array of curves.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.UpdateMultiple(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.UpdateMultiple(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus}@)`

#### Summary

Updates the specified paths of travel by recalculating each path using their original start and end points and provides creation result statuses.

#### Remarks

For unsuccessfully updated elements, Revit will post warnings.

#### Parameter `adoc`

Document of elements to be updated.

#### Parameter `elementsToUpdate`

The list of `T:Autodesk.Revit.DB.ElementId` of the paths to update.

#### Parameter `resultStatus`

Result statuses of each path of travel creation.
The order of statuses corresponds to the order of elements in the array passed to the function.

#### Returns

number of successfully updated elements

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This functionality is not available in Revit LT.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.UpdateMultiple(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.UpdateMultiple(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Updates the specified paths of travel by recalculating each path using their original start and end points.

#### Remarks

For unsuccessfully updated elements, Revit will post warnings.

#### Parameter `adoc`

Document of elements to be updated.

#### Parameter `elementsToUpdate`

The list of `T:Autodesk.Revit.DB.ElementId` of the paths to update.

#### Returns

number of successfully updated elements

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This functionality is not available in Revit LT.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.Update`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.Update`

#### Summary

Updates the path of travel by recalculating the path between the original start and end points.

#### Remarks

If recalculation results in failure, Revit will post a warning.

#### Returns

The status result of the recalculation.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This functionality is not available in Revit LT.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.FindShortestPaths(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.FindShortestPaths(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

For a floor plan view, calculates paths from each start point to its closest destinations.
Returns the path, represented by an array of XYZ points.

#### Remarks

The calculation is done in a floor plan with one or more destinationPoints and one or more startPoints.
The shortest path is calculated from each start point to its closest destination point.

#### Parameter `DBView`

The floor plan view to use when computing the points.

#### Parameter `destinationPoints`

Destination points. The input Z coordinates are ignored and set to the view's level elevation.

#### Parameter `startPoints`

Start points for which shortest paths are calculated.

#### Returns

Array of paths calculated from each start point to its corresponding closest destination.
If a path cannot be caculated the corresponsing sub-array is set to an empty array.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

View is not a floor plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Path of Travel calculation service is not available
-or-
This functionality is not available in Revit LT.

#### Since

2021

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.FindEndsOfShortestPaths(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.FindEndsOfShortestPaths(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

For a floor plan view, calculates the paths from each start point to its closest destination and return the path end points.

#### Remarks

The calculation is done in a floor plan with one or more destinationPoints and one or more startPoints.
The shortest path is calculated from each start point to its corresponding closest destination.

#### Parameter `DBView`

The floor plan view to use when computing the points.

#### Parameter `destinationPoints`

Destination points. The input Z coordinates are ignored and set to the view's level elevation.

#### Parameter `startPoints`

Start points for which shortest path end points are calculated.

#### Returns

End points of paths calculated from each start point to its corresponding closest destination.
If a path cannot be calculated the corresponsing end point is set to the corresponding start point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

View is not a floor plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Path of Travel calculation service is not available
-or-
This functionality is not available in Revit LT.

#### Since

2020.2

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.FindStartsOfLongestPathsFromRooms(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.FindStartsOfLongestPathsFromRooms(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

For a floor plan view, calculates paths from points inside rooms to the closests of the destinations.
Returns the start points of the longest path(s). If multiple paths have the same longest length, returns multiple start points.

#### Remarks

The entire plan is divided in small tiles, and the distance to the closest destination point
is calculated for each tile center point. Only tile center points that are located in rooms in the view are taken into account.

#### Parameter `DBView`

The floor plan view to use when computing the points.

#### Parameter `destinationPoints`

Destination points. The input Z coordinates are ignored and set to the view's level elevation.

#### Returns

Start points of the paths with longest lengths.
The array is empty if there are no valid paths from any points in rooms to any of the destination points.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

View is not a floor plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Path of Travel calculation service is not available
-or-
This functionality is not available in Revit LT.

#### Since

2020.2

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.CreateMapped(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.CreateMapped(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Creates multiple new paths of travel by mapping each of a set of start points to each of a set of end points.

#### Remarks

InvalidOperationException is thrown if PathOfTravel cannot be created for the following conditions:
View has crop box active and crop box is splitView model outline area is larger than the current limit (2,000,000 sq.ft.)View export contains too much geometry (more than 200,000 lines)
ArgumentException exception is thrown if arrays of start or end points are of zero size
or if the total number of paths of travel attempted to be created is more than maximum allowed (50000).

#### Parameter `DBView`

The floor plan view to use when computing the shortest distance.

#### Parameter `pathStarts`

The start points of the path. The input Z coordinates are ignored and set to the view's level elevation.

#### Parameter `pathEnds`

The end points of the path. The input Z coordinates are ignored and set to the view's level elevation.

#### Returns

The array of newly created path of travel elements, or `null` if no path between the two points is found.
The number of elements is the number of start points multiplied by the number of end points.
The order of elements corresponds to the order of end and then start points in the argument arrays:
s0->e0, s1->e0, ... , s0->e1, s1->e1... etc.
There are some additional conditions that are checked and if any condition is true the `null` value is returned:
View has crop box active and start or end point lies outside of the cropStart and end points are too close

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element "DBView" is in a family document or a document in in-place edit mode.
-or-
View is not a floor plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
This operation cannot be performed while the document is in edit mode.
-or-
The Path of Travel calculation service is not available
-or-
This functionality is not available in Revit LT.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing DBView is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing DBView has no open transaction.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.CreateMapped(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.CreateMapped(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus}@)`

#### Summary

Creates multiple new paths of travel by mapping each of a set of start points to each of a set of end points and provides creation result statuses.

#### Remarks

InvalidOperationException is thrown if PathOfTravel cannot be created for the following conditions:
View has crop box active and crop box is splitView model outline area is larger than the current limit (2,000,000 sq.ft.)View export contains too much geometry (more than 200,000 lines)
ArgumentException exception is thrown if arrays of start or end points are of zero size
or if the total number of paths of travel attempted to be created is more than maximum allowed (50000).

#### Parameter `DBView`

The floor plan view to use when computing the shortest distance.

#### Parameter `pathStarts`

The start points of the path. The input Z coordinates are ignored and set to the view's level elevation.

#### Parameter `pathEnds`

The end points of the path. The input Z coordinates are ignored and set to the view's level elevation.

#### Parameter `resultStatus`

Result statuses of each path of travel creation.
The order of statuses corresponds to the order of elements in the array returned by the function.

#### Returns

The array of newly created path of travel elements, or `null` if no path between the two points is found.
The number of elements is the number of start points multiplied by the number of end points.
The order of elements corresponds to the order of end and then start points in the argument arrays:
s0->e0, s1->e0, ... , s0->e1, s1->e1... etc.
There are some additional conditions that are checked and if any condition is true the `null` value is returned:
View has crop box active and start or end point lies outside of the cropStart and end points are too close

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element "DBView" is in a family document or a document in in-place edit mode.
-or-
View is not a floor plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
This operation cannot be performed while the document is in edit mode.
-or-
The Path of Travel calculation service is not available
-or-
This functionality is not available in Revit LT.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing DBView is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing DBView has no open transaction.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.CreateMultiple(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.CreateMultiple(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus}@)`

#### Summary

Creates multiple new paths of travel between same size sets of start and end points and provides creation result statuses.

#### Remarks

InvalidOperationException is thrown if PathOfTravel cannot be created for the following conditions:
View has crop box active and crop box is splitView model outline area is larger than the current limit (2,000,000 sq.ft.)View export contains too much geometry (more than 200,000 lines)
ArgumentException exception is thrown if arrays of start and end points are of different size
or if the total number of paths of travel attempted to be created is more than maximum allowed (50000).

#### Parameter `DBView`

The floor plan view to use when computing the shortest distance.

#### Parameter `pathStarts`

The start points of the path. The input Z coordinates are ignored and set to the view's level elevation.

#### Parameter `pathEnds`

The end points of the path. The input Z coordinates are ignored and set to the view's level elevation.

#### Parameter `resultStatus`

Result statuses of each path of travel creation.
The order of statuses corresponds to the order of elements in the array returned by the function.

#### Returns

The array of newly created path of travel elements, or `null` if no path between the two points is found.
The order of elements corresponds to the order of start/end points in the argument arrays.
There are some additional conditions that are checked and if any condition is true the `null` value is returned:
View has crop box active and start or end point lies outside of the cropStart and end points are too close

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element "DBView" is in a family document or a document in in-place edit mode.
-or-
View is not a floor plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
This operation cannot be performed while the document is in edit mode.
-or-
The Path of Travel calculation service is not available
-or-
This functionality is not available in Revit LT.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing DBView is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing DBView has no open transaction.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.CreateMultiple(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.CreateMultiple(Autodesk.Revit.DB.View,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Creates multiple new paths of travel between same size sets of start and end points.

#### Remarks

InvalidOperationException is thrown if PathOfTravel cannot be created for the following conditions:
View has crop box active and crop box is splitView model outline area is larger than the current limit (2,000,000 sq.ft.)View export contains too much geometry (more than 200,000 lines)
ArgumentException exception is thrown if arrays of start and end points are of different size
or if the total number of paths of travel attempted to be created is more than maximum allowed (50000).

#### Parameter `DBView`

The floor plan view to use when computing the shortest distance.

#### Parameter `pathStarts`

The start points of the path. The input Z coordinates are ignored and set to the view's level elevation.

#### Parameter `pathEnds`

The end points of the path. The input Z coordinates are ignored and set to the view's level elevation.

#### Returns

The array of newly created path of travel elements, or `null` if no path between the two points is found.
The order of elements corresponds to the order of start/end points in the argument arrays.
There are some additional conditions that are checked and if any condition is true the `null` value is returned:
View has crop box active and start or end point lies outside of the cropStart and end points are too close

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element "DBView" is in a family document or a document in in-place edit mode.
-or-
View is not a floor plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
This operation cannot be performed while the document is in edit mode.
-or-
The Path of Travel calculation service is not available
-or-
This functionality is not available in Revit LT.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing DBView is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing DBView has no open transaction.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new path of travel between two points.

#### Remarks

InvalidOperationException is thrown if PathOfTravel cannot be created for the following conditions:
View has crop box active and crop box is splitView has crop box active and start or end point lies outside of the cropView model outline area is larger than the current limit (2,000,000 sq.ft.)View export contains too much geometry (more than 200,000 lines)Start and end points are too close

#### Parameter `DBView`

The floor plan view to use when computing the shortest distance.

#### Parameter `pathStart`

The start point of the path. The input Z coordinates are ignored and set to the view's level elevation.

#### Parameter `pathEnd`

The end point of the path. The input Z coordinates are ignored and set to the view's level elevation.

#### Returns

The newly created path of travel element, or `null` if no path between the two points is found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element "DBView" is in a family document or a document in in-place edit mode.
-or-
View is not a floor plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
This operation cannot be performed while the document is in edit mode.
-or-
The Path of Travel calculation service is not available
-or-
This functionality is not available in Revit LT.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing DBView is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing DBView has no open transaction.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.PathOfTravel.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.Create(Autodesk.Revit.DB.View,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus@)`

#### Summary

Creates a new path of travel between two points and provides creation result status.

#### Remarks

InvalidOperationException is thrown if PathOfTravel cannot be created for the following conditions:
View has crop box active and crop box is splitView has crop box active and start or end point lies outside of the cropView model outline area is larger than the current limit (2,000,000 sq.ft.)View export contains too much geometry (more than 200,000 lines)Start and end points are too close

#### Parameter `DBView`

The floor plan view to use when computing the shortest distance.

#### Parameter `pathStart`

The start point of the path. The input Z coordinates are ignored and set to the view's level elevation.

#### Parameter `pathEnd`

The end point of the path. The input Z coordinates are ignored and set to the view's level elevation.

#### Parameter `resultStatus`

Result status of path of travel creation.

#### Returns

The newly created path of travel element, or `null` if no path between the two points is found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element "DBView" is in a family document or a document in in-place edit mode.
-or-
View is not a floor plan view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
This operation cannot be performed while the document is in edit mode.
-or-
The Path of Travel calculation service is not available
-or-
This functionality is not available in Revit LT.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document containing DBView is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document containing DBView is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document containing DBView has no open transaction.

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.PathOfTravel.LineStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.LineStyle`

#### Summary

The line style of the path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.PathOfTravel.PathEnd`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.PathEnd`

#### Summary

The end point of the path. The Z coordinate will equal the view's level elevation.
To update path calculations, call update.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This functionality is not available in Revit LT.
-or-
When setting this property: Cannot perform this operation for a path of travel in a group.

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.PathOfTravel.PathStart`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.PathStart`

#### Summary

The start point of the path. The Z coordinate will equal the view's level elevation.
To update path calculations, call update.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This functionality is not available in Revit LT.
-or-
When setting this property: Cannot perform this operation for a path of travel in a group.

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.PathOfTravel.PathMidpoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel.PathMidpoint`

#### Summary

The midpoint of the path. The Z coordinate will equal the view's level elevation.

#### Since

2020

### `T:Autodesk.Revit.DB.Analysis.PathOfTravel`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.PathOfTravel`

#### Summary

An element which holds a graphical representation of the shortest route between two points in the plane of a floor plan view.
The shortest route is calculated to go around model geometry visible in the view.
Route calculation is affected by properties of the `!:Autodesk::Revit::DB::Analysis::RouteAnalysisSettings` element.

#### Since

2020

### `M:Autodesk.Revit.DB.PartUtils.GetPartMakerMethodToDivideVolumeFW(Autodesk.Revit.DB.PartMaker)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.GetPartMakerMethodToDivideVolumeFW(Autodesk.Revit.DB.PartMaker)`

#### Summary

Obtains the object allowing access to the divided volume
properties of the PartMaker.

#### Parameter `partMaker`

The PartMaker.

#### Returns

The object handle. Returns `null` if the
PartMaker does not represent divided volumes.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartUtils.IsPartDerivedFromLink(Autodesk.Revit.DB.Part)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.IsPartDerivedFromLink(Autodesk.Revit.DB.Part)`

#### Summary

Is the Part derived from link geometry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartUtils.GetMergedParts(Autodesk.Revit.DB.Part)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.GetMergedParts(Autodesk.Revit.DB.Part)`

#### Summary

Retrieves the element ids of the source elements of a merged part.

#### Parameter `part`

A merged part.

#### Returns

The element ids of the parts that were merged to create the specified merged part.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The specified Part is not a merged part.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartUtils.IsMergedPart(Autodesk.Revit.DB.Part)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.IsMergedPart(Autodesk.Revit.DB.Part)`

#### Summary

Is the Part the result of a merge.

#### Returns

True if the Part is the result of a merge operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartUtils.FindMergeableClusters(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.FindMergeableClusters(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Segregates a set of elements into subsets which are
valid for merge.

#### Remarks

Element ids in the input set that do not correspond to Part
elements will be ignored, as will element ids corresponding
to Part elements that already have associated parts.

#### Parameter `doc`

The document.

#### Parameter `partIds`

A set of element ids.

#### Returns

An array of clusters such that all the elements in a single cluster
are valid for merge. Each cluster will be maximal in that appending
any of the other Parts specified as input will result in a collection
that is not valid for merge.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartUtils.CreateMergedPart(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.CreateMergedPart(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Create a single merged part which represents the Parts
specified by partsToMerge.

#### Parameter `document`

The document.

#### Parameter `partIds`

The elements that the merged part will be created from.

#### Returns

The newly created PartMaker. `null` if no parts are merged.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more element ids was not suitable for merging with the others.
Specified elements should all be Parts, report the same material,
creation and demolition phases, and have contiguous geometry.

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

2013

### `M:Autodesk.Revit.DB.PartUtils.ArePartsValidForMerge(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.ArePartsValidForMerge(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Identifies whether Part elements may be merged.

#### Parameter `document`

The document.

#### Parameter `partIds`

Element ids of Parts.

#### Returns

True if all element ids correspond to Part elements,
none of the parts already has associated parts,
the parts have contiguous geometry, all report the same materials,
and all have the same creation and demolition phases.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartUtils.GetAssociatedPartMaker(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.GetAssociatedPartMaker(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets associated PartMaker for an element.

#### Parameter `hostDocument`

The document

#### Parameter `elementId`

The id for the element to be checked for associated Parts

#### Returns

The PartMaker element that is making Parts for this element.
`null` if there is no associated PartMaker.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PartUtils.GetAssociatedPartMaker(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.GetAssociatedPartMaker(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId)`

#### Summary

Gets associated PartMaker for an element.

#### Parameter `hostDocument`

The document

#### Parameter `hostOrLinkElementId`

The id for the element to be checked for associated Parts

#### Returns

The PartMaker element that is making Parts for this element.
`null` if there is no associated PartMaker.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartUtils.GetAssociatedParts(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.GetAssociatedParts(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Boolean,System.Boolean)`

#### Summary

Returns all Parts that are associated with the given element.

#### Parameter `hostDocument`

The document of the element.

#### Parameter `elementId`

The element to be checked for associated Parts.

#### Parameter `includePartsWithAssociatedParts`

If true, include parts that have associated parts.

#### Parameter `includeAllChildren`

If true, return all associated Parts recursively for all children.
If false, only return immediate children.

#### Returns

Parts that are associated to the element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PartUtils.GetAssociatedParts(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.GetAssociatedParts(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId,System.Boolean,System.Boolean)`

#### Summary

Returns all Parts that are associated with the given element

#### Parameter `hostDocument`

The document of the element

#### Parameter `hostOrLinkElementId`

The element to be checked for associated Parts.

#### Parameter `includePartsWithAssociatedParts`

If true, include parts that have associated parts

#### Parameter `includeAllChildren`

If true, return all associated Parts recursively for all children
If false, only return immediate children

#### Returns

Parts that are associated to the element

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartUtils.HasAssociatedParts(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.HasAssociatedParts(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if an element has associated parts.

#### Parameter `hostDocument`

The document.

#### Parameter `elementId`

The element to be checked for associated Parts

#### Returns

True if the element has associated Parts.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PartUtils.HasAssociatedParts(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.HasAssociatedParts(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId)`

#### Summary

Checks if an element has associated parts.

#### Parameter `hostDocument`

The document.

#### Parameter `hostOrLinkElementId`

The element to be checked for associated Parts.

#### Returns

True if the element has associated Parts.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartUtils.GetChainLengthToOriginal(Autodesk.Revit.DB.Part)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.GetChainLengthToOriginal(Autodesk.Revit.DB.Part)`

#### Summary

Calculates the length of the longest chain of divisions/merges to reach to an original non-Part element that is the source of the tested part.

#### Parameter `part`

The part to be tested

#### Returns

The length of the longest chain.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartUtils.ArePartsValidForDivide(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.ArePartsValidForDivide(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Identifies if provided members are valid for dividing parts.

#### Parameter `document`

The document.

#### Parameter `elementIdsToDivide`

Element ids to be tested for validity for dividing parts.

#### Returns

True if all member ids are valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartUtils.AreElementsValidForCreateParts(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.AreElementsValidForCreateParts(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Identifies if the given elements can be used to create parts.

#### Parameter `document`

The document.

#### Parameter `elementIds`

Element ids to be tested for validity for creating parts.

#### Returns

True if all member ids are valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PartUtils.GetSplittingCurves(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Plane@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.GetSplittingCurves(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Plane@)`

#### Summary

Identifies the curves that were used to create the part and the plane in which they reside.

#### Parameter `document`

The source document of the part.

#### Parameter `partId`

The part id.

#### Parameter `sketchPlane`

The plane in which the division curves were sketched.

#### Returns

The curves that created the part. Empty if partId is not a part or Part is not divided.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019.1

### `M:Autodesk.Revit.DB.PartUtils.GetSplittingCurves(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.GetSplittingCurves(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies the curves that were used to create the part.

#### Parameter `document`

The source document of the part.

#### Parameter `partId`

The part id.

#### Returns

The curves that created the part. Empty if partId is not a Part or Part is not divided.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019.1

### `M:Autodesk.Revit.DB.PartUtils.GetSplittingElements(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.GetSplittingElements(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies the elements ( reference planes, levels, grids ) that were used to create the part.

#### Parameter `document`

The source document of the part.

#### Parameter `partId`

The part id.

#### Returns

The elements that created the part. Empty if partId is not a Part or Part is not divided.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019.1

### `M:Autodesk.Revit.DB.PartUtils.IsValidForCreateParts(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.IsValidForCreateParts(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinkElementId)`

#### Summary

Identifies if the given element can be used to create parts.

#### Parameter `document`

The document.

#### Parameter `hostOrLinkElementId`

Id to be tested for validity for creating part.

#### Returns

True if this id is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PartUtils.DivideParts(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.DivideParts(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId},System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.ElementId)`

#### Summary

Creates divided parts out of parts.

#### Parameter `document`

The document containing the parts.

#### Parameter `elementIdsToDivide`

The elements that will be divided.

#### Parameter `intersectingReferenceIds`

Intersecting references that will divide the elements.

#### Parameter `curveArray`

Array of curves that will divide the elements.

#### Parameter `sketchPlaneId`

SketchPlane id for the curves that divide the elements.

#### Returns

The newly created PartMaker. `null` if no parts are divided.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more element ids was not permitted for dividing parts.
Elements should be parts that are not yet divided and maximum distance from an original has not yet been reached.
-or-
One or more element ids was not permitted as intersecting references.
Intersecting references should be levels, grids, or reference planes.
-or-
The element id should refer to a valid SketchPlane.
-or-
The input curveArray contains at least one helical curve and is not supported for this operation.
-or-
The input curveArray contains at least one NULL pointer and is not supported for this operation.

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

2012

### `M:Autodesk.Revit.DB.PartUtils.CreateParts(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.CreateParts(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Creates a new set of parts out of the original elements.

#### Remarks

Parts will be added to the model after regeneration.

#### Parameter `document`

The document containing the elements.

#### Parameter `elementIds`

The elements that parts will be created from.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more element ids was not permitted for creating parts.
Elements should be of a valid category and the ids should be valid and should not already be divided into parts.

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

2012

### `M:Autodesk.Revit.DB.PartUtils.CreateParts(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.LinkElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PartUtils.CreateParts(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.LinkElementId})`

#### Summary

Creates a new set of parts out of the original elements.

#### Remarks

Parts will be added to the model after regeneration.
To get the ids of the parts created by this method use PartUtils.GetAssociatedParts() with the contents of hostOrLinkElementIds.

#### Parameter `document`

The document containing the elements.

#### Parameter `hostOrLinkElementIds`

The elements that parts will be created from.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more element ids was not permitted for creating parts.
HostOrLinkElements should be of a valid category and the ids should be valid and should not already be divided into parts.

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

2013

### `T:Autodesk.Revit.DB.PartUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.PartUtils`

#### Summary

General Part utility methods

#### Since

2012

### `P:Autodesk.Revit.DB.ParameterTypeId.PlacementTop`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PlacementTop`

#### Summary

"Top"

### `P:Autodesk.Revit.DB.ParameterTypeId.PlacementRight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PlacementRight`

#### Summary

"Right"

### `P:Autodesk.Revit.DB.ParameterTypeId.PlacementBottom`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PlacementBottom`

#### Summary

"Bottom"

### `P:Autodesk.Revit.DB.ParameterTypeId.PlacementLeft`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PlacementLeft`

#### Summary

"Left"

### `P:Autodesk.Revit.DB.ParameterTypeId.PlacementCenterY`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PlacementCenterY`

#### Summary

"Center Y"

### `P:Autodesk.Revit.DB.ParameterTypeId.PlacementCenterX`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PlacementCenterX`

#### Summary

"Center X"

### `P:Autodesk.Revit.DB.ParameterTypeId.PlacementParamsShow`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PlacementParamsShow`

#### Summary

"Enable Position Parameters"

### `P:Autodesk.Revit.DB.ParameterTypeId.ExchangeEntityId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ExchangeEntityId`

#### Summary

"Exchange Entity ID"

### `P:Autodesk.Revit.DB.ParameterTypeId.ExchangeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ExchangeId`

#### Summary

"Exchange ID"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailDetailLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailDetailLevel`

#### Summary

"Detail Level"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailAngularDimensionTextPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailAngularDimensionTextPosition`

#### Summary

"Angle Text Position"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailSegmentLengthDimensionTextPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailSegmentLengthDimensionTextPosition`

#### Summary

"Dimension Text Position"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailSegmenetRepesentation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailSegmenetRepesentation`

#### Summary

"Representation"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailVaryingRebarDimension`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailVaryingRebarDimension`

#### Summary

"Varying Rebar Set Dimensions"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailRepesentationFor3dBars`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailRepesentationFor3dBars`

#### Summary

"View for 3D Shape"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeAngularDimensionsMeasurement`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeAngularDimensionsMeasurement`

#### Summary

"Angle Measurement"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeAngularDimensionsForHooksEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeAngularDimensionsForHooksEnabled`

#### Summary

"Hook Angles"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeBendDiameterDimensionsForHooksEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeBendDiameterDimensionsForHooksEnabled`

#### Summary

"Hook Bends"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeBendDiameterDimensionsForSegmentsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeBendDiameterDimensionsForSegmentsEnabled`

#### Summary

"Segment Bends"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeShowBarBendingUsing`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeShowBarBendingUsing`

#### Summary

"Dimension Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeDiameterDimensionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeDiameterDimensionTypeId`

#### Summary

"Diameter Dimension Style"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeRadialDimensionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeRadialDimensionTypeId`

#### Summary

"Radial Dimension Style"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeBendDiameterDimensionsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeBendDiameterDimensionsEnabled`

#### Summary

"Bend Diameter Dimensions"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeAngularDimensionOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeAngularDimensionOffset`

#### Summary

"Angular Dimension Offset"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeShowAngularDimensionsFor`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeShowAngularDimensionsFor`

#### Summary

"Show for Angles"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeAngularDimensionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeAngularDimensionTypeId`

#### Summary

"Angular Dimension Style"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeAngularDimensionsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeAngularDimensionsEnabled`

#### Summary

"Angular Dimensions"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeOrthogonalAndOverallDimesionsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeOrthogonalAndOverallDimesionsEnabled`

#### Summary

"Other Dimensions"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeSegmentLengthDimensionsForHooksEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeSegmentLengthDimensionsForHooksEnabled`

#### Summary

"Hook Lengths"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeSegmentLengthDimensionsOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeSegmentLengthDimensionsOffset`

#### Summary

"Dimension Offset"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeSegmentLengthsDisplayOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeSegmentLengthsDisplayOption`

#### Summary

"Straight Segment Lengths"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeSegmentLengthsForArcsDisplayOption`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeSegmentLengthsForArcsDisplayOption`

#### Summary

"Arc Segment Lengths"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeSegmentLengthDimensionTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeSegmentLengthDimensionTypeId`

#### Summary

"Linear Dimension Style"

### `P:Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeSegmentLengthDimensionsEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BendingDetailTypeSegmentLengthDimensionsEnabled`

#### Summary

"Segment Length Dimensions"

### `P:Autodesk.Revit.DB.ParameterTypeId.LoadIsConstrainedOnHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LoadIsConstrainedOnHost`

#### Summary

"Is constrained on host"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarAlignmentOptions`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarAlignmentOptions`

#### Summary

"Bar Alignment"

### `P:Autodesk.Revit.DB.ParameterTypeId.ScheduleRowHeightInput`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ScheduleRowHeightInput`

#### Summary

"Row Height"

### `P:Autodesk.Revit.DB.ParameterTypeId.ScheduleResizeRows`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ScheduleResizeRows`

#### Summary

"Resize Rows"

### `P:Autodesk.Revit.DB.ParameterTypeId.ScheduleRotationOnSheet`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ScheduleRotationOnSheet`

#### Summary

"Rotation on Sheet"

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemScheduleFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemScheduleFamily`

#### Summary

"Family"

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemIsVariable`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemIsVariable`

#### Summary

"Is Variable"

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemIsStructuralMaterial`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemIsStructuralMaterial`

#### Summary

"Is Structural Material"

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemIsCoreLayer`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemIsCoreLayer`

#### Summary

"Is Core Layer"

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemCompoundElemType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemCompoundElemType`

#### Summary

"Compound Element Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemCompoundElemFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemCompoundElemFamily`

#### Summary

"Compound Element Family"

### `P:Autodesk.Revit.DB.ParameterTypeId.SsePointElevationBaseType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SsePointElevationBaseType`

#### Summary

"Elevation Base Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.SsePointElevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SsePointElevation`

#### Summary

"Elevation"

### `P:Autodesk.Revit.DB.ParameterTypeId.SsePointOffsetFromSurface`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SsePointOffsetFromSurface`

#### Summary

"Offset from Surface"

### `P:Autodesk.Revit.DB.ParameterTypeId.SsePointBasetypeEnum`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SsePointBasetypeEnum`

#### Summary

"Point Base Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.ToposolidContourSubcategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ToposolidContourSubcategoryId`

#### Summary

"Subcategory"

### `P:Autodesk.Revit.DB.ParameterTypeId.ToposolidContourDisplaySettingsIdParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ToposolidContourDisplaySettingsIdParam`

#### Summary

"Contour Display"

### `P:Autodesk.Revit.DB.ParameterTypeId.ToposolidSubdivideMaterial`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ToposolidSubdivideMaterial`

#### Summary

"Material"

### `P:Autodesk.Revit.DB.ParameterTypeId.ToposolidSubdivideHeignt`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ToposolidSubdivideHeignt`

#### Summary

"Sub-divide Height"

### `P:Autodesk.Revit.DB.ParameterTypeId.ToposolidInheritContours`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ToposolidInheritContours`

#### Summary

"Inherit Contours"

### `P:Autodesk.Revit.DB.ParameterTypeId.ToposolidFunctionParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ToposolidFunctionParam`

#### Summary

"Function"

### `P:Autodesk.Revit.DB.ParameterTypeId.PreferPatternAlignUiFilter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PreferPatternAlignUiFilter`

#### Summary

"Pattern:": This is used by the UI to allow to select the preferred preference of aligning pattern.

### `P:Autodesk.Revit.DB.ParameterTypeId.ToposolidElevationAtTop`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ToposolidElevationAtTop`

#### Summary

"Elevation at Top"

### `P:Autodesk.Revit.DB.ParameterTypeId.ToposolidElevationAtBottom`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ToposolidElevationAtBottom`

#### Summary

"Elevation at Bottom"

### `P:Autodesk.Revit.DB.ParameterTypeId.ToposolidStructureIdParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ToposolidStructureIdParam`

#### Summary

"Structure"

### `P:Autodesk.Revit.DB.ParameterTypeId.LowestAssociatedLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LowestAssociatedLevel`

#### Summary

"Lowest Associated Level": The lowest level associated with this Analytical Element.

### `P:Autodesk.Revit.DB.ParameterTypeId.HighestAssociatedLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.HighestAssociatedLevel`

#### Summary

"Highest Associated Level": The highest level associated with this Analytical Element.

### `P:Autodesk.Revit.DB.ParameterTypeId.ToposolidHeightabovelevelParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ToposolidHeightabovelevelParam`

#### Summary

"Height Offset From Level"

### `P:Autodesk.Revit.DB.ParameterTypeId.ToposolidAttrThicknessParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ToposolidAttrThicknessParam`

#### Summary

"Thickness"

### `P:Autodesk.Revit.DB.ParameterTypeId.ToposolidTypeDefaultThicknessParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ToposolidTypeDefaultThicknessParam`

#### Summary

"Default Thickness"

### `P:Autodesk.Revit.DB.ParameterTypeId.OffsetFromReferenceBase`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.OffsetFromReferenceBase`

#### Summary

"Offset from Reference Base"

### `P:Autodesk.Revit.DB.ParameterTypeId.ReferenceBaseOnHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ReferenceBaseOnHost`

#### Summary

"Reference Base on Host"

### `P:Autodesk.Revit.DB.ParameterTypeId.OvalFramingHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.OvalFramingHeight`

#### Summary

"Oval Height"

### `P:Autodesk.Revit.DB.ParameterTypeId.OvalFramingWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.OvalFramingWidth`

#### Summary

"Oval Width"

### `P:Autodesk.Revit.DB.ParameterTypeId.CircularFramingDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CircularFramingDiameter`

#### Summary

"Circular Diameter"

### `P:Autodesk.Revit.DB.ParameterTypeId.LinearFramingLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LinearFramingLength`

#### Summary

"Length"

### `P:Autodesk.Revit.DB.ParameterTypeId.FramingShapeClassification`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.FramingShapeClassification`

#### Summary

"Framing Shape"

### `P:Autodesk.Revit.DB.ParameterTypeId.StiffenerClassification`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StiffenerClassification`

#### Summary

"Classification"

### `P:Autodesk.Revit.DB.ParameterTypeId.FamilySelfOrienting`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.FamilySelfOrienting`

#### Summary

"Align to View"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerRotationAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerRotationAngle`

#### Summary

"Coupler Rotation"

### `P:Autodesk.Revit.DB.ParameterTypeId.PreferDimSideUiFilter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PreferDimSideUiFilter`

#### Summary

"Prefer:": This is used by the UI to allow select prefer dimension side.

### `P:Autodesk.Revit.DB.ParameterTypeId.MultipleAlignmentUiToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MultipleAlignmentUiToggle`

#### Summary

"Multiple Alignment": This is used by the UI to allow selection of multiple elements.

### `P:Autodesk.Revit.DB.ParameterTypeId.LockAlignmentUiToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LockAlignmentUiToggle`

#### Summary

"Lock": This is used by the UI to allow selection of lock alignment.

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemBaseExtensionDis`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemBaseExtensionDis`

#### Summary

"Base Extension Distance"

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemTopExtensionDis`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemTopExtensionDis`

#### Summary

"Top Extension Distance"

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemFunction`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemFunction`

#### Summary

"Function": Function

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemMaterials`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemMaterials`

#### Summary

"Material": Material

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemThickness`

#### Summary

"Thickness": Thickness

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemAreaComputed`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemAreaComputed`

#### Summary

"Area"

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemOffsetFromHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemOffsetFromHost`

#### Summary

"Offset From Host"

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemVolumeComputed`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemVolumeComputed`

#### Summary

"Volume"

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerTypeMaterials`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerTypeMaterials`

#### Summary

"Material": Material

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerTypeThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerTypeThickness`

#### Summary

"Thickness": Thickness

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemBaseConstraint`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemBaseConstraint`

#### Summary

"Base Constraint"

### `P:Autodesk.Revit.DB.ParameterTypeId.LayerElemTopConstraint`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.LayerElemTopConstraint`

#### Summary

"Top Constraint"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarInstanceBarModelDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarInstanceBarModelDiameter`

#### Summary

"Model Bar Diameter"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarModelBarDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarModelBarDiameter`

#### Summary

"Model Bar Diameter"

### `P:Autodesk.Revit.DB.ParameterTypeId.ViewShowGrids`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ViewShowGrids`

#### Summary

"Show Grids"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarModifiedSet`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarModifiedSet`

#### Summary

"Modified Rebar Set"

### `P:Autodesk.Revit.DB.ParameterTypeId.MovesWithGridParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MovesWithGridParam`

#### Summary

"Moves With Grids": Disable attachment from grids.

### `P:Autodesk.Revit.DB.ParameterTypeId.DpartLayerIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.DpartLayerIndex`

#### Summary

"Layer Index"

### `P:Autodesk.Revit.DB.ParameterTypeId.VoidCutsGeometry`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.VoidCutsGeometry`

#### Summary

"Cuts Geometry"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarHookRotationAtEndSchedulesTagsFilters`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarHookRotationAtEndSchedulesTagsFilters`

#### Summary

"Hook Rotation At End"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarHookRotationAtStartSchedulesTagsFilters`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarHookRotationAtStartSchedulesTagsFilters`

#### Summary

"Hook Rotation At Start"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarHookLengthOverride`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarHookLengthOverride`

#### Summary

"Override Hook Lengths"

### `P:Autodesk.Revit.DB.ParameterTypeId.InfrastructureAlignmentName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.InfrastructureAlignmentName`

#### Summary

"Name"

### `P:Autodesk.Revit.DB.ParameterTypeId.InfrastructureAlignmentDescription`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.InfrastructureAlignmentDescription`

#### Summary

"Description"

### `P:Autodesk.Revit.DB.ParameterTypeId.InfrastructureAlignmentDisplayedStartStation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.InfrastructureAlignmentDisplayedStartStation`

#### Summary

"Displayed Start Station"

### `P:Autodesk.Revit.DB.ParameterTypeId.InfrastructureAlignmentDisplayedEndStation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.InfrastructureAlignmentDisplayedEndStation`

#### Summary

"Displayed End Station"

### `P:Autodesk.Revit.DB.ParameterTypeId.AssemblyPrecastFreeze`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.AssemblyPrecastFreeze`

#### Summary

"Disable Precast Updates"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarHookRotationAtEnd`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarHookRotationAtEnd`

#### Summary

"Hook Rotation At End"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarHookRotationAtStart`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarHookRotationAtStart`

#### Summary

"Hook Rotation At Start"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarShapeHookRotationAtEnd`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarShapeHookRotationAtEnd`

#### Summary

"Hook Rotation At End"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarShapeHookRotationAtStart`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarShapeHookRotationAtStart`

#### Summary

"Hook Rotation At Start"

### `P:Autodesk.Revit.DB.ParameterTypeId.PathOfTravelFromRoom`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PathOfTravelFromRoom`

#### Summary

"From Room"

### `P:Autodesk.Revit.DB.ParameterTypeId.PathOfTravelToRoom`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PathOfTravelToRoom`

#### Summary

"To Room"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalTotalCoincidentLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalTotalCoincidentLoad`

#### Summary

"Total Coincident Loads"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecNumberOfCircuits`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecNumberOfCircuits`

#### Summary

"Max Number of Circuits"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemProfileVolume`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemProfileVolume`

#### Summary

"Volume"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemProfileLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemProfileLength`

#### Summary

"Length"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemProfileType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemProfileType`

#### Summary

"Profile Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecEditCircuitNamingSettingsParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecEditCircuitNamingSettingsParam`

#### Summary

"Circuit Naming Settings"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateJustification`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateJustification`

#### Summary

"Justification"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPlatePaintArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPlatePaintArea`

#### Summary

"Paint Area"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateExactWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateExactWeight`

#### Summary

"Exact Weight"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateWeight`

#### Summary

"Weight"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateVolume`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateVolume`

#### Summary

"Volume"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateArea`

#### Summary

"Area"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateWidth`

#### Summary

"Width"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateLength`

#### Summary

"Length"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateType`

#### Summary

"Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltTotalWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltTotalWeight`

#### Summary

"Total Weight"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemShearstudTotalWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemShearstudTotalWeight`

#### Summary

"Total Weight"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorTotalWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorTotalWeight`

#### Summary

"Total Weight"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorOrientation`

#### Summary

"Anchor Orientation"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemCutLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemCutLength`

#### Summary

"Cut Length"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemExactWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemExactWeight`

#### Summary

"Exact Weight"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPaintArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPaintArea`

#### Summary

"Paint Area"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeight`

#### Summary

"Weight"

### `P:Autodesk.Revit.DB.ParameterTypeId.PathOfTravelSpeed`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PathOfTravelSpeed`

#### Summary

"Speed"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltLocation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltLocation`

#### Summary

"Location"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltFinishCalculationAtGap`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltFinishCalculationAtGap`

#### Summary

"Finish Calculation At Gap"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltInverted`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltInverted`

#### Summary

"Inverted"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltGripLengthIncrease`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltGripLengthIncrease`

#### Summary

"Grip Length Increase"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltGripLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltGripLength`

#### Summary

"Grip Length"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltLength`

#### Summary

"Bolt Length"

### `P:Autodesk.Revit.DB.ParameterTypeId.GenericZoneName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.GenericZoneName`

#### Summary

"Name"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsPipeBottomElevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsPipeBottomElevation`

#### Summary

"Lower End Bottom Elevation"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsPipeTopElevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsPipeTopElevation`

#### Summary

"Upper End Top Elevation"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsCurrentPhasec`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsCurrentPhasec`

#### Summary

"Feed Through Lugs Current Phase C"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsCurrentPhaseb`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsCurrentPhaseb`

#### Summary

"Feed Through Lugs Current Phase B"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsCurrentPhasea`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsCurrentPhasea`

#### Summary

"Feed Through Lugs Current Phase A"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsApparentLoadPhasec`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsApparentLoadPhasec`

#### Summary

"Feed Through Lugs Apparent Load Phase C"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsApparentLoadPhaseb`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsApparentLoadPhaseb`

#### Summary

"Feed Through Lugs Apparent Load Phase B"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsApparentLoadPhasea`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsApparentLoadPhasea`

#### Summary

"Feed Through Lugs Apparent Load Phase A"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelBranchCircuitCurrentPhasec`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelBranchCircuitCurrentPhasec`

#### Summary

"Branch Circuit Current Phase C"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelBranchCircuitCurrentPhaseb`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelBranchCircuitCurrentPhaseb`

#### Summary

"Branch Circuit Current Phase B"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelBranchCircuitCurrentPhasea`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelBranchCircuitCurrentPhasea`

#### Summary

"Branch Circuit Current Phase A"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelBranchCircuitApparentLoadPhasec`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelBranchCircuitApparentLoadPhasec`

#### Summary

"Branch Circuit Apparent Load Phase C"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelBranchCircuitApparentLoadPhaseb`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelBranchCircuitApparentLoadPhaseb`

#### Summary

"Branch Circuit Apparent Load Phase B"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelBranchCircuitApparentLoadPhasea`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelBranchCircuitApparentLoadPhasea`

#### Summary

"Branch Circuit Apparent Load Phase A"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleDefinition`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleDefinition`

#### Summary

"Hole Definition"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecPanelFeedThruLugsParam`

#### Summary

"Feed Through Lugs"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecCircuitNumberingType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecCircuitNumberingType`

#### Summary

"Circuit Numbering Option"

### `P:Autodesk.Revit.DB.ParameterTypeId.TagOnPlacementUi`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.TagOnPlacementUi`

#### Summary

"Tag on Placement"

### `P:Autodesk.Revit.DB.ParameterTypeId.RouteAnalysisSettingsParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RouteAnalysisSettingsParam`

#### Summary

"Route Analysis Settings"

### `P:Autodesk.Revit.DB.ParameterTypeId.PathOfTravelViewName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PathOfTravelViewName`

#### Summary

"View Name"

### `P:Autodesk.Revit.DB.ParameterTypeId.PathOfTravelLevelName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PathOfTravelLevelName`

#### Summary

"Level"

### `P:Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionOverrideType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionOverrideType`

#### Summary

"Override by Instance"

### `P:Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionEditType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionEditType`

#### Summary

"Modify Parameters"

### `P:Autodesk.Revit.DB.ParameterTypeId.PathOfTravelTime`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PathOfTravelTime`

#### Summary

"Time"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemZclipType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemZclipType`

#### Summary

"Boundary"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemCopeAroundAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemCopeAroundAxis`

#### Summary

"Around beam axis"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemCopeAxisAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemCopeAxisAngle`

#### Summary

"Tilt angle"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemCopeZAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemCopeZAngle`

#### Summary

"Plan rotation"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemCopeXAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemCopeXAngle`

#### Summary

"Cross-section rotation"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemCopeDistanceAxis`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemCopeDistanceAxis`

#### Summary

"Distance from axis"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemCopeWidthx`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemCopeWidthx`

#### Summary

"Cutback"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemYDistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemYDistance`

#### Summary

"Side 2"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemXDistance`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemXDistance`

#### Summary

"Side 1"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemCutType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemCutType`

#### Summary

"Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateShortenCutstraight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateShortenCutstraight`

#### Summary

"Cut straight"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateShortenSuction`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateShortenSuction`

#### Summary

"Suction"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateShortenAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateShortenAngle`

#### Summary

"Angle"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldPrefix`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldPrefix`

#### Summary

"Prefix"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldTextModule`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldTextModule`

#### Summary

"Text module"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleDepthOfBoltHead`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleDepthOfBoltHead`

#### Summary

"Depth of bolt head"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleTapping`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleTapping`

#### Summary

"Right-handed thread"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleBackTaperThread`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleBackTaperThread`

#### Summary

"Back taper thread"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleTappingHole`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleTappingHole`

#### Summary

"Tapping hole"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleHeadDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleHeadDiameter`

#### Summary

"Head diameter"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleAngle`

#### Summary

"Chamfer angle"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleAlpha`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleAlpha`

#### Summary

"Taper Angle"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleDepth`

#### Summary

"Hole Depth"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleSlotDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleSlotDirection`

#### Summary

"Along side 1"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleSlotLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleSlotLength`

#### Summary

"Length of the slot"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleType`

#### Summary

"Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemHoleDiameter`

#### Summary

"Diameter"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternNumber`

#### Summary

"Number"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternRadius`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternRadius`

#### Summary

"Radius"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternEdgeDistanceY`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternEdgeDistanceY`

#### Summary

"Edge distance on side 2"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternEdgeDistanceX`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternEdgeDistanceX`

#### Summary

"Edge distance on side 1"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternIntermediateDistanceY`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternIntermediateDistanceY`

#### Summary

"Intermediate distance on side 2"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternIntermediateDistanceX`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternIntermediateDistanceX`

#### Summary

"Intermediate distance on side 1"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternTotalWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternTotalWidth`

#### Summary

"Length on side 2"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternTotalLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternTotalLength`

#### Summary

"Length on side 1"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternNumberY`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternNumberY`

#### Summary

"Number on side 2"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternNumberX`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPatternNumberX`

#### Summary

"Number on side 1"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoublePrepdepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoublePrepdepth`

#### Summary

"Double Preparation Depth"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleEffectivethroat`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleEffectivethroat`

#### Summary

"Double Effective Throat"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleRootopening`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleRootopening`

#### Summary

"Double Root Opening"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleWeldprep`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleWeldprep`

#### Summary

"Double Weld preparation"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleSurfaceshape`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleSurfaceshape`

#### Summary

"Double Surface Shape"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleText`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleText`

#### Summary

"Double Text"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleThickness`

#### Summary

"Double Thickness"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldDoubleType`

#### Summary

"Double Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainPrepdepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainPrepdepth`

#### Summary

"Main Preparation Depth"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainEffectivethroat`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainEffectivethroat`

#### Summary

"Main Effective Throat"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainRootopening`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainRootopening`

#### Summary

"Main Root Opening"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainWeldprep`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainWeldprep`

#### Summary

"Main Weld preparation"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainSurfaceshape`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainSurfaceshape`

#### Summary

"Surface Shape"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainText`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainText`

#### Summary

"Main Text"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldPitch`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldPitch`

#### Summary

"Pitch"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldContinuous`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldContinuous`

#### Summary

"Continuous"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldLocation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldLocation`

#### Summary

"Location"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldLength`

#### Summary

"Length"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainThickness`

#### Summary

"Main Thickness"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemWeldMainType`

#### Summary

"Main Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemParamBoringout`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemParamBoringout`

#### Summary

"Boring out"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemParamRadius`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemParamRadius`

#### Summary

"Radius"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemContourSide2dist`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemContourSide2dist`

#### Summary

"Boundary distance 2"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemContourSide1dist`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemContourSide1dist`

#### Summary

"Boundary distance 1"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemContourGapWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemContourGapWidth`

#### Summary

"Gap Width"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemShortenAnglez`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemShortenAnglez`

#### Summary

"Angle along width"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemShortenAngley`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemShortenAngley`

#### Summary

"Angle along height"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemShortenReflength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemShortenReflength`

#### Summary

"Length"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemShearstudLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemShearstudLength`

#### Summary

"Length"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltCoating`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltCoating`

#### Summary

"Coating"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorLength`

#### Summary

"Length"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemShearstudDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemShearstudDiameter`

#### Summary

"Diameter"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemShearstudGrade`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemShearstudGrade`

#### Summary

"Grade"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemShearstudStandard`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemShearstudStandard`

#### Summary

"Standard"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorDiameter`

#### Summary

"Diameter"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorAssembly`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorAssembly`

#### Summary

"Assembly"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorGrade`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorGrade`

#### Summary

"Grade"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorStandard`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemAnchorStandard`

#### Summary

"Standard"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemCoating`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemCoating`

#### Summary

"Coating"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltDiameter`

#### Summary

"Diameter"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltAssembly`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltAssembly`

#### Summary

"Assembly"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltGrade`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltGrade`

#### Summary

"Grade"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltStandard`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemBoltStandard`

#### Summary

"Standard"

### `P:Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SteelElemPlateThickness`

#### Summary

"Thickness"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarWorkshopInstructions`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarWorkshopInstructions`

#### Summary

"Workshop Instructions"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarGeometryType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarGeometryType`

#### Summary

"Geometry"

### `P:Autodesk.Revit.DB.ParameterTypeId.BasepointLatitudeParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BasepointLatitudeParam`

#### Summary

"Lat"

### `P:Autodesk.Revit.DB.ParameterTypeId.BasepointLongitudeParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.BasepointLongitudeParam`

#### Summary

"Lon"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarFreeFormHookEndPlaneAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarFreeFormHookEndPlaneAngle`

#### Summary

"Hook Orientation At End"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarFreeFormHookStartPlaneAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarFreeFormHookStartPlaneAngle`

#### Summary

"Hook Orientation At Start"

### `P:Autodesk.Revit.DB.ParameterTypeId.RoomOutdoorAirflowParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RoomOutdoorAirflowParam`

#### Summary

"Outdoor Airflow"

### `P:Autodesk.Revit.DB.ParameterTypeId.RoomOutdoorAirflowStandardParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RoomOutdoorAirflowStandardParam`

#### Summary

"Outdoor Air Method"

### `P:Autodesk.Revit.DB.ParameterTypeId.Directcontext3dSourceId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.Directcontext3dSourceId`

#### Summary

"Path"

### `P:Autodesk.Revit.DB.ParameterTypeId.Directcontext3dApplicationId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.Directcontext3dApplicationId`

#### Summary

"ApplicationId"

### `P:Autodesk.Revit.DB.ParameterTypeId.Directcontext3dLoaded`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.Directcontext3dLoaded`

#### Summary

"Loaded"

### `P:Autodesk.Revit.DB.ParameterTypeId.Directcontext3dServerId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.Directcontext3dServerId`

#### Summary

"ServerId"

### `P:Autodesk.Revit.DB.ParameterTypeId.Directcontext3dName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.Directcontext3dName`

#### Summary

"Name"

### `P:Autodesk.Revit.DB.ParameterTypeId.RoomAirChangesPerHourParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RoomAirChangesPerHourParam`

#### Summary

"Air Changes per Hour"

### `P:Autodesk.Revit.DB.ParameterTypeId.RoomOutdoorAirPerAreaParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RoomOutdoorAirPerAreaParam`

#### Summary

"Outdoor Air per Area"

### `P:Autodesk.Revit.DB.ParameterTypeId.RoomOutdoorAirPerPersonParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RoomOutdoorAirPerPersonParam`

#### Summary

"Outdoor Air per Person"

### `P:Autodesk.Revit.DB.ParameterTypeId.RoomOutdoorAirInfoParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RoomOutdoorAirInfoParam`

#### Summary

"Outdoor Air Information"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarInternalMultiplanarArcConnector`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarInternalMultiplanarArcConnector`

#### Summary

"INTERNAL: Multiplanar Arc Connector"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarShapeEndtreatmentEndType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarShapeEndtreatmentEndType`

#### Summary

"End Treatment At End"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarShapeEndtreatmentStartType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarShapeEndtreatmentStartType`

#### Summary

"End Treatment At Start"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarElemEndtreatmentEnd`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarElemEndtreatmentEnd`

#### Summary

"End Treatment At End"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarElemEndtreatmentStart`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarElemEndtreatmentStart`

#### Summary

"End Treatment At Start"

### `P:Autodesk.Revit.DB.ParameterTypeId.EndTreatment`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.EndTreatment`

#### Summary

"End Treatment"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerCoupledEndtreatment`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerCoupledEndtreatment`

#### Summary

"End Treatment 2"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerMainEndtreatment`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerMainEndtreatment`

#### Summary

"End Treatment 1"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerWidth`

#### Summary

"External Diameter"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerMark`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerMark`

#### Summary

"Schedule Mark"

### `P:Autodesk.Revit.DB.ParameterTypeId.FamilyFreeinstDefaultElevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.FamilyFreeinstDefaultElevation`

#### Summary

"Default Elevation"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerCoupledEngagement`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerCoupledEngagement`

#### Summary

"Bar Engagement 2"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerMainEngagement`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerMainEngagement`

#### Summary

"Bar Engagement 1"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerLength`

#### Summary

"Total Length"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerWeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerWeight`

#### Summary

"Mass"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerNumber`

#### Summary

"Coupler Number"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerQuantity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerQuantity`

#### Summary

"Quantity"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerCoupledBarSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerCoupledBarSize`

#### Summary

"Bar Size 2"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerMainBarSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerMainBarSize`

#### Summary

"Bar Size 1"

### `P:Autodesk.Revit.DB.ParameterTypeId.CouplerCode`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.CouplerCode`

#### Summary

"Part Number"

### `P:Autodesk.Revit.DB.ParameterTypeId.MultistoryStairsActualTreadDepth`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MultistoryStairsActualTreadDepth`

#### Summary

"Actual Tread Depth"

### `P:Autodesk.Revit.DB.ParameterTypeId.MultistoryStairsRefLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MultistoryStairsRefLevel`

#### Summary

"Reference Level": The reference level of stairs

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarElemHostMark`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarElemHostMark`

#### Summary

"Host Mark"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarShapeImage`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarShapeImage`

#### Summary

"Shape Image"

### `P:Autodesk.Revit.DB.ParameterTypeId.FabricNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.FabricNumber`

#### Summary

"Fabric Number"

### `P:Autodesk.Revit.DB.ParameterTypeId.RebarNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RebarNumber`

#### Summary

"Rebar Number"

### `P:Autodesk.Revit.DB.ParameterTypeId.GraphicDisplayOptionsSketchyLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.GraphicDisplayOptionsSketchyLines`

#### Summary

"Sketchy Lines"

### `P:Autodesk.Revit.DB.ParameterTypeId.NumberPartitionParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.NumberPartitionParam`

#### Summary

"Partition"

### `P:Autodesk.Revit.DB.ParameterTypeId.ViewShowHiddenLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ViewShowHiddenLines`

#### Summary

"Show Hidden Lines"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalArea`

#### Summary

"Area"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadsInSet`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadsInSet`

#### Summary

"Loads in Set"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadSetOnStandby`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadSetOnStandby`

#### Summary

"Quantity on Standby"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadSetOnDuty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadSetOnDuty`

#### Summary

"Quantity of Prime"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecDistributionNodeLoadSet`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecDistributionNodeLoadSet`

#### Summary

"Load Set"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecDistributionNodeSupplyTo`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecDistributionNodeSupplyTo`

#### Summary

"Supply To"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalFeederLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalFeederLength`

#### Summary

"Length"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLevelId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLevelId`

#### Summary

"Level"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecApparentPowerDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecApparentPowerDensity`

#### Summary

"Apparent Power Density"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecDistributionNodeSupplyFrom2`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecDistributionNodeSupplyFrom2`

#### Summary

"Supply From 2"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecDistributionNodeSupplyFrom`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecDistributionNodeSupplyFrom`

#### Summary

"Supply From"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecDistributionNodeSupplyFrom1`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecDistributionNodeSupplyFrom1`

#### Summary

"Supply From 1"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadSetOnTotal`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadSetOnTotal`

#### Summary

"Total Quantity"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadNameParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadNameParam`

#### Summary

"Name"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadTypeParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadTypeParam`

#### Summary

"Load Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsAreaBasedLoadType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsAreaBasedLoadType`

#### Summary

"Area Based Load Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsElecAnalyticalLoadDensity`

#### Summary

"Power Density"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepElecZoneEquipmentType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepElecZoneEquipmentType`

#### Summary

"Equipment Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepZoneEquipmentDrawVentilation`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepZoneEquipmentDrawVentilation`

#### Summary

"Draw Ventilation"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepVrfLoop`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepVrfLoop`

#### Summary

"Variable Refrigerant Flow Loop"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepReheatHotwaterLoop`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepReheatHotwaterLoop`

#### Summary

"Reheat Hot Water Loop"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepZoneEquipment`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepZoneEquipment`

#### Summary

"Zone Equipment"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalEquipmentName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalEquipmentName`

#### Summary

"Name"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepZoneHotwaterLoop`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepZoneHotwaterLoop`

#### Summary

"Heating Hot Water Loop"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepZoneAirLoop`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepZoneAirLoop`

#### Summary

"Air System"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepReheatCoilType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepReheatCoilType`

#### Summary

"Reheat Coil"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepZoneEquipmentBehavior`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepZoneEquipmentBehavior`

#### Summary

"Behavior"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepZoneEquipmentType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepZoneEquipmentType`

#### Summary

"Equipment Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepAirloopFantype`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepAirloopFantype`

#### Summary

"Fan"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepChilledWaterLoop`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepChilledWaterLoop`

#### Summary

"Chilled Water Loop"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepCoolingCoilType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepCoolingCoilType`

#### Summary

"Cooling Coil"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepHeatingHotwaterLoop`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepHeatingHotwaterLoop`

#### Summary

"Heating Hot Water Loop"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepHeatingCoilType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepHeatingCoilType`

#### Summary

"Heating Coil"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepPreheatHotwaterLoop`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepPreheatHotwaterLoop`

#### Summary

"Preheat Hot Water Loop"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepAirloopPreheatCoiltype`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepAirloopPreheatCoiltype`

#### Summary

"Preheat Coil"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepAirloopHeatexchangerType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepAirloopHeatexchangerType`

#### Summary

"Heat Exchanger"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepCondenserWaterLoop`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepCondenserWaterLoop`

#### Summary

"Condenser Water Loop"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepWaterloopChillertype`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepWaterloopChillertype`

#### Summary

"Chiller Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepWaterloopType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepWaterloopType`

#### Summary

"Loop Type"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalLoopName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalLoopName`

#### Summary

"Name"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalElecCurrent`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalElecCurrent`

#### Summary

"Current"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalElecVoltage`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalElecVoltage`

#### Summary

"Voltage"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalElecCurrentRating`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalElecCurrentRating`

#### Summary

"Current Rating"

### `P:Autodesk.Revit.DB.ParameterTypeId.SystemEquipmentSets`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.SystemEquipmentSets`

#### Summary

"Equipment Sets"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepIgnoreFlowAnalysis`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepIgnoreFlowAnalysis`

#### Summary

"Ignore Flow Analysis"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalLoopBoundaryParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalLoopBoundaryParam`

#### Summary

"Loop Boundary"

### `P:Autodesk.Revit.DB.ParameterTypeId.MechanicalEquipmentSetIdParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MechanicalEquipmentSetIdParam`

#### Summary

"Mechanical Equipment Set"

### `P:Autodesk.Revit.DB.ParameterTypeId.MechanicalEquipmentSetName`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MechanicalEquipmentSetName`

#### Summary

"Name"

### `P:Autodesk.Revit.DB.ParameterTypeId.MechanicalEquipmentSetOnStandby`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MechanicalEquipmentSetOnStandby`

#### Summary

"On Standby"

### `P:Autodesk.Revit.DB.ParameterTypeId.MechanicalEquipmentSetOnDuty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MechanicalEquipmentSetOnDuty`

#### Summary

"On Duty"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalCriticalpathParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalCriticalpathParam`

#### Summary

"Critical Path"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalPipeDesignflow`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepAnalyticalPipeDesignflow`

#### Summary

"Design Flow"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepEquipmentCalcPipingpressuredropParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepEquipmentCalcPipingpressuredropParam`

#### Summary

"Calculated Pressure Drop"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepEquipmentCalcPipingflowParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepEquipmentCalcPipingflowParam`

#### Summary

"Calculated Flow"

### `P:Autodesk.Revit.DB.ParameterTypeId.MepEquipmentClassification`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MepEquipmentClassification`

#### Summary

"Classification"

### `P:Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionInputElements`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionInputElements`

#### Summary

"Input Elements"

### `P:Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionNobleStatus`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionNobleStatus`

#### Summary

"Noble Status"

### `P:Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionCodeCheckingStatus`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionCodeCheckingStatus`

#### Summary

"Code Checking Status"

### `P:Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionApprovalStatus`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionApprovalStatus`

#### Summary

"Approval Status"

### `P:Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionModifyConnectionParameters`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionModifyConnectionParameters`

#### Summary

"Detailed Parameters"

### `P:Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionSymbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StructuralConnectionSymbol`

#### Summary

"Connection Symbol"

### `P:Autodesk.Revit.DB.ParameterTypeId.AllModelImage`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.AllModelImage`

#### Summary

"Image"

### `P:Autodesk.Revit.DB.ParameterTypeId.AllModelTypeImage`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.AllModelTypeImage`

#### Summary

"Type Image"

### `P:Autodesk.Revit.DB.ParameterTypeId.StructFramJoinStatus`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StructFramJoinStatus`

#### Summary

"Join Status"

### `P:Autodesk.Revit.DB.ParameterTypeId.ReferencedView`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ReferencedView`

#### Summary

"Referenced View": The view referenced by a section or callout.

### `P:Autodesk.Revit.DB.ParameterTypeId.EnergyAnalysisAdvancedOptions`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.EnergyAnalysisAdvancedOptions`

#### Summary

"Other Options"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsEnergyAnalysisMode`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsEnergyAnalysisMode`

#### Summary

"Mode"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsEnergyAnalysisBuildingEnvelopeAnalyticalSurfaceIdentificationResolution`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsEnergyAnalysisBuildingEnvelopeAnalyticalSurfaceIdentificationResolution`

#### Summary

"Analytical Surface Resolution"

### `P:Autodesk.Revit.DB.ParameterTypeId.RbsEnergyAnalysisBuildingEnvelopeAnalyticalSpaceIdentificationResolution`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.RbsEnergyAnalysisBuildingEnvelopeAnalyticalSpaceIdentificationResolution`

#### Summary

"Analytical Space Resolution"

### `P:Autodesk.Revit.DB.ParameterTypeId.FamilyRoundconnectorDimensiontype`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.FamilyRoundconnectorDimensiontype`

#### Summary

"Round Connector Dimension"

### `P:Autodesk.Revit.DB.ParameterTypeId.FamProfileDefinition`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.FamProfileDefinition`

#### Summary

"Profile Definition"

### `P:Autodesk.Revit.DB.ParameterTypeId.EndZOffsetValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.EndZOffsetValue`

#### Summary

"End z Offset Value"

### `P:Autodesk.Revit.DB.ParameterTypeId.EndZJustification`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.EndZJustification`

#### Summary

"End z Justification"

### `P:Autodesk.Revit.DB.ParameterTypeId.EndYOffsetValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.EndYOffsetValue`

#### Summary

"End y Offset Value"

### `P:Autodesk.Revit.DB.ParameterTypeId.EndYJustification`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.EndYJustification`

#### Summary

"End y Justification"

### `P:Autodesk.Revit.DB.ParameterTypeId.StartZOffsetValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StartZOffsetValue`

#### Summary

"Start z Offset Value"

### `P:Autodesk.Revit.DB.ParameterTypeId.StartZJustification`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StartZJustification`

#### Summary

"Start z Justification"

### `P:Autodesk.Revit.DB.ParameterTypeId.StartYOffsetValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StartYOffsetValue`

#### Summary

"Start y Offset Value"

### `P:Autodesk.Revit.DB.ParameterTypeId.StartYJustification`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StartYJustification`

#### Summary

"Start y Justification"

### `P:Autodesk.Revit.DB.ParameterTypeId.ZOffsetValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ZOffsetValue`

#### Summary

"z Offset Value"

### `P:Autodesk.Revit.DB.ParameterTypeId.ZJustification`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ZJustification`

#### Summary

"z Justification"

### `P:Autodesk.Revit.DB.ParameterTypeId.YOffsetValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.YOffsetValue`

#### Summary

"y Offset Value"

### `P:Autodesk.Revit.DB.ParameterTypeId.YJustification`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.YJustification`

#### Summary

"y Justification"

### `P:Autodesk.Revit.DB.ParameterTypeId.YzJustification`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.YzJustification`

#### Summary

"yz Justification"

### `P:Autodesk.Revit.DB.ParameterTypeId.EndJoinCutback`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.EndJoinCutback`

#### Summary

"End Join Cutback"

### `P:Autodesk.Revit.DB.ParameterTypeId.StartJoinCutback`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StartJoinCutback`

#### Summary

"Start Join Cutback"

### `P:Autodesk.Revit.DB.ParameterTypeId.EndExtension`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.EndExtension`

#### Summary

"End Extension"

### `P:Autodesk.Revit.DB.ParameterTypeId.StartExtension`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.StartExtension`

#### Summary

"Start Extension"

### `P:Autodesk.Revit.DB.ParameterTypeId.DivisionSketchCurveDivisionParamsOverrideParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.DivisionSketchCurveDivisionParamsOverrideParam`

#### Summary

"Profile Override"

### `P:Autodesk.Revit.DB.ParameterTypeId.DivisionSketchCurveExtentdToSilhParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.DivisionSketchCurveExtentdToSilhParam`

#### Summary

"Extend to Silhouette"

### `P:Autodesk.Revit.DB.ParameterTypeId.DivisionRuleParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.DivisionRuleParam`

#### Summary

"Division Rule"

### `P:Autodesk.Revit.DB.ParameterTypeId.PatternMirrorForDivisionRule`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PatternMirrorForDivisionRule`

#### Summary

"Mirror"

### `P:Autodesk.Revit.DB.ParameterTypeId.AllGridRotationForDivisionRule`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.AllGridRotationForDivisionRule`

#### Summary

"All Grid Rotation"

### `P:Autodesk.Revit.DB.ParameterTypeId.PatternIndent2ForDivisionRule`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PatternIndent2ForDivisionRule`

#### Summary

"Indent 2"

### `P:Autodesk.Revit.DB.ParameterTypeId.PatternIndent1ForDivisionRule`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PatternIndent1ForDivisionRule`

#### Summary

"Indent 1"

### `P:Autodesk.Revit.DB.ParameterTypeId.DivisionPattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.DivisionPattern`

#### Summary

"Division Pattern"

### `P:Autodesk.Revit.DB.ParameterTypeId.DpartShapeModified`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.DpartShapeModified`

#### Summary

"Shape is modified"

### `P:Autodesk.Revit.DB.ParameterTypeId.DpartExcluded`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.DpartExcluded`

#### Summary

"Excluded"

### `P:Autodesk.Revit.DB.ParameterTypeId.AnalyticalModelManuallyAdjusted`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.AnalyticalModelManuallyAdjusted`

#### Summary

"Manually Adjusted"

### `P:Autodesk.Revit.DB.ParameterTypeId.PropertySetKeywords`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PropertySetKeywords`

#### Summary

"Keywords"

### `P:Autodesk.Revit.DB.ParameterTypeId.MaterialAssetParamSourceUrl`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MaterialAssetParamSourceUrl`

#### Summary

"Source URL"

### `P:Autodesk.Revit.DB.ParameterTypeId.MaterialAssetParamSource`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MaterialAssetParamSource`

#### Summary

"Source"

### `P:Autodesk.Revit.DB.ParameterTypeId.MaterialAssetParamExternalMaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MaterialAssetParamExternalMaterialId`

#### Summary

"External Material ID"

### `P:Autodesk.Revit.DB.ParameterTypeId.MaterialAssetParamCommonSharedAsset`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MaterialAssetParamCommonSharedAsset`

#### Summary

"Sharing"

### `P:Autodesk.Revit.DB.ParameterTypeId.MaterialAssetParamAssetLibId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.MaterialAssetParamAssetLibId`

#### Summary

"Asset library id"

### `P:Autodesk.Revit.DB.ParameterTypeId.DpartBaseLevelByOriginal`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.DpartBaseLevelByOriginal`

#### Summary

"Base Level By Original"

### `P:Autodesk.Revit.DB.ParameterTypeId.DpartBaseLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.DpartBaseLevel`

#### Summary

"Base Level"

### `P:Autodesk.Revit.DB.ParameterTypeId.PointAdaptiveNumParam`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PointAdaptiveNumParam`

#### Summary

"Number"

### `P:Autodesk.Revit.DB.ParameterTypeId.PointAdaptiveShowNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PointAdaptiveShowNumber`

#### Summary

"Show Placement Number"

### `P:Autodesk.Revit.DB.ParameterTypeId.PointAdaptiveConstrained`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PointAdaptiveConstrained`

#### Summary

"Constrained"

### `P:Autodesk.Revit.DB.ParameterTypeId.PointAdaptiveOrientationType`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PointAdaptiveOrientationType`

#### Summary

"Orients to"

### `P:Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamElectricalResistivity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamElectricalResistivity`

#### Summary

"Electrical Resistivity"

### `P:Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamReflectivity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamReflectivity`

#### Summary

"Reflectivity"

### `P:Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamPorosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamPorosity`

#### Summary

"Porosity"

### `P:Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamPermeability`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamPermeability`

#### Summary

"Permeability"

### `P:Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamTransmitsLight`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamTransmitsLight`

#### Summary

"Transmits Light"

### `P:Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamVaporPressure`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamVaporPressure`

#### Summary

"Vapor Pressure"

### `P:Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamSpecificHeatOfVaporization`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamSpecificHeatOfVaporization`

#### Summary

"Specific Heat of Vaporization"

### `P:Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamLiquidViscosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamLiquidViscosity`

#### Summary

"Liquid Viscosity"

### `P:Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamCompressibility`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamCompressibility`

#### Summary

"Compressibility"

### `P:Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamGasViscosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamGasViscosity`

#### Summary

"Gas Viscosity"

### `P:Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamEmissivity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.ThermalMaterialParamEmissivity`

#### Summary

"Emissivity"

### `P:Autodesk.Revit.DB.ParameterTypeId.PhyMaterialParamWoodConstruction`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PhyMaterialParamWoodConstruction`

#### Summary

"Construction"

### `P:Autodesk.Revit.DB.ParameterTypeId.PhyMaterialParamFivepercentModulusOfElacticity`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PhyMaterialParamFivepercentModulusOfElacticity`

#### Summary

"5% Modulus of Elasticity"

### `P:Autodesk.Revit.DB.ParameterTypeId.PhyMaterialParamAverageModulus`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PhyMaterialParamAverageModulus`

#### Summary

"Average Modulus"

### `P:Autodesk.Revit.DB.ParameterTypeId.PhyMaterialParamTensionPerpendicular`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PhyMaterialParamTensionPerpendicular`

#### Summary

"Tension Perpendicular to Grain"

### `P:Autodesk.Revit.DB.ParameterTypeId.PhyMaterialParamTensionParallel`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterTypeId.PhyMaterialParamTensionParallel`

#### Summary

"Tension Parallel to Grain"
