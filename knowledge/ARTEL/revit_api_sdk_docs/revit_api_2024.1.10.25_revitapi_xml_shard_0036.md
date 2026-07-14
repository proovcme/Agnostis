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
Shard: 36
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `P:Autodesk.Revit.DB.BuiltInFailures.LoadFailures.AreaLoadNotOverlappingHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LoadFailures.AreaLoadNotOverlappingHost`

#### Summary

Area load is not overlapping with its entire distribution its host.

### `T:Autodesk.Revit.DB.BuiltInFailures.LoadFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LoadFailures`

#### Summary

Failures about Load.

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.WatchedLinkMoved`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.WatchedLinkMoved`

#### Summary

Monitored Link moved.

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.SourceFileDrivenByOtherTarget`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.SourceFileDrivenByOtherTarget`

#### Summary

Linked Model's Shared Coordinates have been modified via another host model in this session. In order to be able to change the Linked File via the active host model, Save and open it again in a new session.

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.NoConstraintsToLinks1`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.NoConstraintsToLinks1`

#### Summary

Constraints may not be created to linked instances using Shared Locations. Constraints will be removed.

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.MultipleLinks`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.MultipleLinks`

#### Summary

Can't complete operation. Linked Files have the same name.

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.ModifyingLinkedFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.ModifyingLinkedFile`

#### Summary

Shared Locations in the Linked Model '[Name]' have been modified, but not saved back to the Linked File.
Upon reopening, instances of the Linked Model will return to their last Saved Positions.
You can Save the Linked Model later via the Manage Links dialog.

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.ModifiedLinkedFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.ModifiedLinkedFile`

#### Summary

Shared Sites in the link have been modified, use move instance to reset the change.

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.LinkedFileOpenInOtherDoc`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.LinkedFileOpenInOtherDoc`

#### Summary

Linked file cannot be reloaded because it is loaded into another open document.

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.LinkInstanceNeedsReconcile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.LinkInstanceNeedsReconcile`

#### Summary

Instance of linked .rvt file needs Coordination Review

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.DeleteLinkSymbolPrompt`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.DeleteLinkSymbolPrompt`

#### Summary

All instances of Linked Model '[Name]' have been deleted, but the file itself is still loaded.
Remove the Linked File using Manage Links dialog to save memory unless you are going to reuse it in this project.
Removing the Link cannot be undone.

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.DataDictionaryDifferentInLink`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.DataDictionaryDifferentInLink`

#### Summary

Linked file [Name] was last saved in a previous version of Revit. Changes to it cannot be saved until it is upgraded.

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.CannotUnlinkFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.CannotUnlinkFile`

#### Summary

Can't unlink file.

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.CannotReloadFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.CannotReloadFile`

#### Summary

Can't reload file.

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.CannotPublishSharedCoordinatesToMirroredNonRevitLinks`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.CannotPublishSharedCoordinatesToMirroredNonRevitLinks`

#### Summary

Shared coordinates cannot be published to mirrored, non Revit, links.

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.CannotOpenLinkedFileServerNotFound`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.CannotOpenLinkedFileServerNotFound`

#### Summary

Cannot open the linked model using Open and Unload because the plugin [name] cannot be accessed. Please check
plugin [name], which has server Id [serverId]

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.CannotOpenLinkedFileServerFound`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.CannotOpenLinkedFileServerFound`

#### Summary

Cannot open the linked model using Open and Unload because the plugin [name] provided by [vendor]
experienced an error. For more information please contact [vendor].

### `P:Autodesk.Revit.DB.BuiltInFailures.LinkFailures.CannotModifyLinkedFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures.CannotModifyLinkedFile`

#### Summary

Shared Sites in the link ""%1!s!"" cannot be modified.

### `T:Autodesk.Revit.DB.BuiltInFailures.LinkFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LinkFailures`

#### Summary

Failures about LinkFailures.

### `P:Autodesk.Revit.DB.BuiltInFailures.LevelFailures.StoryAboveNonStoryLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LevelFailures.StoryAboveNonStoryLevel`

#### Summary

The level set as the Story Above for these levels is no longer a story level. This change will cause these levels to revert to the default Story Above.

### `P:Autodesk.Revit.DB.BuiltInFailures.LevelFailures.StoryAboveMoved`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LevelFailures.StoryAboveMoved`

#### Summary

The level set as the Story Above for these levels has moved below these levels. This change will cause these levels to revert to the default Story Above.

### `P:Autodesk.Revit.DB.BuiltInFailures.LevelFailures.StoryAboveDeleted`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LevelFailures.StoryAboveDeleted`

#### Summary

The level set as the Story Above for these levels is being deleted. This change will cause these levels to revert to the default Story Above.

### `P:Autodesk.Revit.DB.BuiltInFailures.LevelFailures.NoLevelsLeftReloading`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LevelFailures.NoLevelsLeftReloading`

#### Summary

As a result of Reloading Latest, there are no Levels left. Create a new Level, and then Reload Latest again.

### `P:Autodesk.Revit.DB.BuiltInFailures.LevelFailures.NoLevelsLeft`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LevelFailures.NoLevelsLeft`

#### Summary

There are no levels or plan views remaining in the project.

### `T:Autodesk.Revit.DB.BuiltInFailures.LevelFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LevelFailures`

#### Summary

Failures about Level.

### `P:Autodesk.Revit.DB.BuiltInFailures.LevelAssociationFailures.AllLevelsDeleted`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LevelAssociationFailures.AllLevelsDeleted`

#### Summary

All Levels from model were deleted

### `T:Autodesk.Revit.DB.BuiltInFailures.LevelAssociationFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LevelAssociationFailures`

#### Summary

Failures about Level association of Analytical Node.

### `P:Autodesk.Revit.DB.BuiltInFailures.LegendFailures.LegendComponentNotVisible`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LegendFailures.LegendComponentNotVisible`

#### Summary

The component you have selected is not visible in the selected view.

### `P:Autodesk.Revit.DB.BuiltInFailures.LegendFailures.LegendComponentBadViewType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LegendFailures.LegendComponentBadViewType`

#### Summary

Legend Components may only be placed in Legends

### `T:Autodesk.Revit.DB.BuiltInFailures.LegendFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.LegendFailures`

#### Summary

Failures about Legend.

### `P:Autodesk.Revit.DB.BuiltInFailures.KeynoteTagFailures.NoKeynoteAssignedToLinkedElement`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeynoteTagFailures.NoKeynoteAssignedToLinkedElement`

#### Summary

The parameters of the keynote tag are empty because the keynoted linked element uses a different keynote file.

### `P:Autodesk.Revit.DB.BuiltInFailures.KeynoteTagFailures.KeynoteOnLinkWithDifferentKeynoteFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeynoteTagFailures.KeynoteOnLinkWithDifferentKeynoteFile`

#### Summary

The parameters of the keynote tag are empty because the keynoted linked element uses a different keynote file.

### `T:Autodesk.Revit.DB.BuiltInFailures.KeynoteTagFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeynoteTagFailures`

#### Summary

Failures related to keynote tags.

### `P:Autodesk.Revit.DB.BuiltInFailures.KeynoteFailures.NotAssociatedKeynoteParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeynoteFailures.NotAssociatedKeynoteParameter`

#### Summary

Current tag keynoting system uses key value parameter that is not associated with this element category.\nTo resolve,
associate parameter with category or change keynoting system.

### `P:Autodesk.Revit.DB.BuiltInFailures.KeynoteFailures.MissKeynotingSystem`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeynoteFailures.MissKeynotingSystem`

#### Summary

No Keynoting System associated with Tag Family.\nTo resolve, select keynoting system for the tag family.

### `P:Autodesk.Revit.DB.BuiltInFailures.KeynoteFailures.MissKeynoteParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeynoteFailures.MissKeynoteParameter`

#### Summary

No Keynote Parameter.\nTo resolve, select key value parameter in keynoting system.

### `P:Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeFileFailures.CannotUnderstandAtLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeFileFailures.CannotUnderstandAtLine`

#### Summary

Cannot understand [EntryType] line '[Number]'

### `P:Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeFileFailures.CannotOpenFileForRead`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeFileFailures.CannotOpenFileForRead`

#### Summary

Cannot open file [FileName].

### `T:Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeFileFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeFileFailures`

#### Summary

Failures occurred when reading key based tree text file.

### `P:Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeEntryFailures.MissingParent`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeEntryFailures.MissingParent`

#### Summary

No parent [EntryType] '[Code]' for '[Code]'

### `P:Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeEntryFailures.DuplicateEntry`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeEntryFailures.DuplicateEntry`

#### Summary

Duplicate code '[Code]', description: '[Description]'

### `P:Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeEntryFailures.CircularParentage`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeEntryFailures.CircularParentage`

#### Summary

A sub-[EntryType] '[Code]' specified as parent for its current ancestor '[Code]'

### `P:Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeEntryFailures.BadClassificationLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeEntryFailures.BadClassificationLevel`

#### Summary

Level [Level] of Classification [Code] is not an integer from 1 to 5.

### `T:Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeEntryFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.KeyBasedTreeEntryFailures`

#### Summary

Failures about KeyBasedTreeEntry.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.WallTypeUnsupportedError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.WallTypeUnsupportedError`

#### Summary

The selected wall type/shape isn't supported for attaching a wall to a stair. To continue, detach the wall from the stairs' components.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.StructGroupMemberWillDetachFromGrid`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.StructGroupMemberWillDetachFromGrid`

#### Summary

A structural element will be detached from grid(s) due to inconsistent group membership.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.StairsComponentTypeUnsupportedError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.StairsComponentTypeUnsupportedError`

#### Summary

The selected stair type/shape isn't supported for attaching a wall to a stair. To continue, detach the wall from the stairs' components.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.JoiningDisjointWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.JoiningDisjointWarn`

#### Summary

Highlighted elements are joined but do not intersect.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.JoiningDisjoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.JoiningDisjoint`

#### Summary

Highlighted elements are joined but do not intersect.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.FootingWillMoveToBottom`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.FootingWillMoveToBottom`

#### Summary

An attached Structural Foundation will be moved to the bottom of the Column.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.ElementWillBeDetachedFromPlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.ElementWillBeDetachedFromPlane`

#### Summary

Element will be detached from its associated plane

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotKeepWallJoinToRoofError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotKeepWallJoinToRoofError`

#### Summary

Can't keep wall and [target] joined

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotKeepWallJoinToRoof`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotKeepWallJoinToRoof`

#### Summary

Can't keep wall and [target] joined

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotKeepTrussJoined`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotKeepTrussJoined`

#### Summary

Can't keep the highlighted [Element]s joined.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotKeepReferenceOfJoinedElementWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotKeepReferenceOfJoinedElementWarning`

#### Summary

Can't keep reference of joined element.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotKeepReferenceOfJoinedElement`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotKeepReferenceOfJoinedElement`

#### Summary

Can't keep reference of joined element.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotKeepJoined`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotKeepJoined`

#### Summary

Can't keep elements joined.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinRoofError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinRoofError`

#### Summary

The roof cannot be joined.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinRoof`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinRoof`

#### Summary

The roof cannot be joined.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinElementsWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinElementsWarn`

#### Summary

Can't keep elements joined.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinElementsStructuralError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinElementsStructuralError`

#### Summary

Can't keep elements joined.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinElementsStructural`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinElementsStructural`

#### Summary

Can't keep elements joined.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinElementsMultiPlaneError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinElementsMultiPlaneError`

#### Summary

Can't keep elements joined.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinElementsError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinElementsError`

#### Summary

Can't keep elements joined.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinElements`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinElements`

#### Summary

Can't keep elements joined.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinDesignOptions`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotJoinDesignOptions`

#### Summary

An element cannot join to an element in a secondary Design Option unless it is in the same secondary Design Option.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotCutJoinedGeometry`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotCutJoinedGeometry`

#### Summary

Element could not be cut by joined element.

### `P:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotCope`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures.CannotCope`

#### Summary

Can't apply Coping.

### `T:Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.JoinElementsFailures`

#### Summary

Failures about JoinElements.

### `P:Autodesk.Revit.DB.BuiltInFailures.InterferenceFailures.GeometryWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InterferenceFailures.GeometryWarning`

#### Summary

A geometrical error has occurred while checking for Interference. Reported interference may not be accurate.

### `T:Autodesk.Revit.DB.BuiltInFailures.InterferenceFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InterferenceFailures`

#### Summary

Failures about Interference.

### `P:Autodesk.Revit.DB.BuiltInFailures.InfillFailures.MovedInfillToHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures.MovedInfillToHost`

#### Summary

Infilling element was automatically moved to keep it aligned to host.

### `P:Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InsertOverlapsOrOut`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InsertOverlapsOrOut`

#### Summary

Highlighted inserts overlap with other inserts or completely miss their hosts.

### `P:Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InsertJoinedWall`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InsertJoinedWall`

#### Summary

Insert conflicts with joined Wall.

### `P:Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillNoThicknessMultiface`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillNoThicknessMultiface`

#### Summary

Highlighted infilling element could not have thickness different from its host because it spans multiple faces.

### `P:Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillNoThicknessCeiling`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillNoThicknessCeiling`

#### Summary

Could not change type due to highlighted infilling element. 'Basic Ceiling' infills are only compatible with 'Basic Ceiling' hosts.

### `P:Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillNoSlopeGlazing`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillNoSlopeGlazing`

#### Summary

Could not change type due to highlighted infilling element. 'Sloped glazing' infills are not allowed.

### `P:Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillLost`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillLost`

#### Summary

Standalone infilling Wall is separated from its insert.

### `P:Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillDifferentPhase`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillDifferentPhase`

#### Summary

Wall and instance have different phasing settings. Automatic creation of the infilling wall fails.

### `P:Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillCannotHaveDiffThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillCannotHaveDiffThickness`

#### Summary

This infilling element must have the same thickness as its host.

### `P:Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillCannotChangeType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InfillCannotChangeType`

#### Summary

Infilling element replaced by a later phase insert must be the same type as the insert's host.

### `P:Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InPlaceFamilyNotCuttingHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures.InPlaceFamilyNotCuttingHost`

#### Summary

Instance of in-place family is not cutting host.

### `P:Autodesk.Revit.DB.BuiltInFailures.InfillFailures.FamilyInstanceIsNotCuttingHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures.FamilyInstanceIsNotCuttingHost`

#### Summary

Instance is not cutting host.

### `P:Autodesk.Revit.DB.BuiltInFailures.InfillFailures.CannotDeleteInfill`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures.CannotDeleteInfill`

#### Summary

Can't delete infilling element without deleting its insert or host.

### `T:Autodesk.Revit.DB.BuiltInFailures.InfillFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InfillFailures`

#### Summary

Failures about Infill.

### `P:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateWall`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateWall`

#### Summary

Wall is slightly off axis and may cause inaccuracies.

### `P:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateSpaceSeparation`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateSpaceSeparation`

#### Summary

Space separation line is slightly off axis and may cause inaccuracies.

### `P:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateSketchLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateSketchLine`

#### Summary

Line in Sketch is slightly off axis and may cause inaccuracies.

### `P:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateRoomSeparation`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateRoomSeparation`

#### Summary

Room separation line is slightly off axis and may cause inaccuracies.

### `P:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateRefPlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateRefPlane`

#### Summary

Ref Plane is slightly off axis and may cause inaccuracies.

### `P:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateMassingSketchLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateMassingSketchLine`

#### Summary

Line in Massing Sketch is slightly off axis and may cause inaccuracies.

### `P:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateLine`

#### Summary

Line is slightly off axis and may cause inaccuracies.

### `P:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateLevel`

#### Summary

Level is slightly off axis and may cause inaccuracies.

### `P:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateGrid`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateGrid`

#### Summary

Grid is slightly off axis and may cause inaccuracies.

### `P:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateDriveCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateDriveCurve`

#### Summary

Element is slightly off axis and may cause inaccuracies.

### `P:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateCurveBasedFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateCurveBasedFamily`

#### Summary

Curve-Based Family is slightly off axis and may cause inaccuracies.

### `P:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateBeamOrBrace`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateBeamOrBrace`

#### Summary

Beam or Brace is slightly off axis and may cause inaccuracies.

### `P:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateAreaLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures.InaccurateAreaLine`

#### Summary

Area separation line is slightly off axis and may cause inaccuracies.

### `T:Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.InaccurateFailures`

#### Summary

Failures about Inaccurate.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.WorksetCreatedForLinkWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.WorksetCreatedForLinkWarning`

#### Summary

Newly created link types and instances were placed in new workset [workset name]

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.TooManyPickFaces`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.TooManyPickFaces`

#### Summary

Too many faces were created from imported meshes. Host by Face tools may not select the imported meshes correctly.
Decrease the complexity of the file or try importing only selected layers to resolve.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.TextNotImported`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.TextNotImported`

#### Summary

Text is only imported if the "Current View Only" option is selected. To see the text in the original file, import again with this check box selected in the Import Dialog.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.SomeObjectsNotExploded`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.SomeObjectsNotExploded`

#### Summary

Import contained some 3D data or points which can't be exploded.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.LostAcisObjectsOnImport`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.LostAcisObjectsOnImport`

#### Summary

Some ACIS objects could not be imported. To import them, use AutoCAD to convert them into polymesh objects and reimport.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ImportedModelIsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ImportedModelIsEmpty`

#### Summary

Imported model is empty.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ImportTooManyElmentsToExplode`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ImportTooManyElmentsToExplode`

#### Summary

Import Instance has [Number] elements. Imports with more than 10,000 elements cannot be exploded.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ImportTooFarAway`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ImportTooFarAway`

#### Summary

Imported objects located a large distance from the model might not display properly. The 'Center-to-Center' option will be used.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ImportScaleTooLarge`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ImportScaleTooLarge`

#### Summary

This scale factor would make the imported object too large. Reverting to the previous scale factor.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ImportModelTooLarge`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ImportModelTooLarge`

#### Summary

The imported model is too large.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ImportModelOutOfRange`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ImportModelOutOfRange`

#### Summary

The imported model is out of range.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.IFCPartialSchemaSupport`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.IFCPartialSchemaSupport`

#### Summary

IFC versions 4 and above are only partially supported by Open IFC. Consider using Link IFC instead.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.IFCGenericRevitImportWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.IFCGenericRevitImportWarning`

#### Summary

Revit had the following problems importing the IFC file: [Description]

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.IFCGenericImportWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.IFCGenericImportWarning`

#### Summary

The following problems were encountered in the IFC file: [Description]

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.IFCCantUpdateLinkedFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.IFCCantUpdateLinkedFile`

#### Summary

The cached version of this IFC file is already loaded into another document in this session, and can't be updated. To update the IFC file, please close all other documents containing the link, and then update.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.FailedToSetWorkplane`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.FailedToSetWorkplane`

#### Summary

Could not set Work Plane of [Import].\n\nPlease use the Work Plane tool to set a Work Plane for this view.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ElementRenamedOnImport`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ElementRenamedOnImport`

#### Summary

There were duplicate names between the active model and the imported element. To avoid duplicate names, the imported element has been renamed.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.CannotImportFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.CannotImportFile`

#### Summary

Can't import file.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.CannotExplodeElement`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.CannotExplodeElement`

#### Summary

Can't explode the imported object.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.CannotChangeImportSymbol`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.CannotChangeImportSymbol`

#### Summary

Can't change an imported or linked element's symbol type.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.BadFaceFoundInDwg`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.BadFaceFoundInDwg`

#### Summary

One or more hatch regions were found in the imported file with unconnected boundaries. These hatch regions will be ignored.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ATFNonUniformScalingTransform`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ATFNonUniformScalingTransform`

#### Summary

The imported geometry contains non-uniform scaling transformations which Revit does not support. Some objects may be displaced or distorted.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ATFContainedUnsupportedGeometricData`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures.ATFContainedUnsupportedGeometricData`

#### Summary

The original model contains unsupported geometric data such as curves or points.

### `T:Autodesk.Revit.DB.BuiltInFailures.ImportFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportFailures`

#### Summary

Failures about ImportFailures.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImportExportFailures.ViewBoundariesTooLarge`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportExportFailures.ViewBoundariesTooLarge`

#### Summary

The view boundaries are too large to export the view..

### `T:Autodesk.Revit.DB.BuiltInFailures.ImportExportFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImportExportFailures`

#### Summary

Failures about Import and Export.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImageFailures.InvalidWidth`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImageFailures.InvalidWidth`

#### Summary

The image width must be must be no more than 30000 feet.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImageFailures.InvalidHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImageFailures.InvalidHeight`

#### Summary

The image height must be must be no more than 30000 feet.

### `P:Autodesk.Revit.DB.BuiltInFailures.ImageFailures.BadViewType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImageFailures.BadViewType`

#### Summary

Image Instances can't be placed in 3D Views.

### `T:Autodesk.Revit.DB.BuiltInFailures.ImageFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ImageFailures`

#### Summary

Failures about Image.

### `P:Autodesk.Revit.DB.BuiltInFailures.IlluminationFailures.RoomLightLossFactorWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.IlluminationFailures.RoomLightLossFactorWarning`

#### Summary

Estimated Illumination failed. Light Loss factor not set for lighting fixture.

### `P:Autodesk.Revit.DB.BuiltInFailures.IlluminationFailures.RoomCoefficientUtilizationWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.IlluminationFailures.RoomCoefficientUtilizationWarning`

#### Summary

Estimated Illumination failed. Coefficient of utilization not set for lighting fixture.

### `P:Autodesk.Revit.DB.BuiltInFailures.IlluminationFailures.LightingFixtureLumensWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.IlluminationFailures.LightingFixtureLumensWarning`

#### Summary

Estimated Illumination failed. Lumens not set for lighting fixture.

### `P:Autodesk.Revit.DB.BuiltInFailures.IlluminationFailures.IESFileNotFoundWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.IlluminationFailures.IESFileNotFoundWarning`

#### Summary

Estimated Illumination failed. IES file not found for lighting fixture.

### `T:Autodesk.Revit.DB.BuiltInFailures.IlluminationFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.IlluminationFailures`

#### Summary

Failures about Illumination.

### `P:Autodesk.Revit.DB.BuiltInFailures.HvacFailures.PanelDoesntMatchCircuitPropertiesDisconnected`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.HvacFailures.PanelDoesntMatchCircuitPropertiesDisconnected`

#### Summary

The panel no longer matches the properties for the Circuit. Disconnect the panel from the Circuit?

### `T:Autodesk.Revit.DB.BuiltInFailures.HvacFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.HvacFailures`

#### Summary

Failures related to HVAC in MEP.

### `P:Autodesk.Revit.DB.BuiltInFailures.HostObjFailures.ReferencesNulled`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.HostObjFailures.ReferencesNulled`

#### Summary

One or more references are or have become invalid.

### `P:Autodesk.Revit.DB.BuiltInFailures.HostObjFailures.HostMismatch`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.HostObjFailures.HostMismatch`

#### Summary

Can't use this type in this host.

### `T:Autodesk.Revit.DB.BuiltInFailures.HostObjFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.HostObjFailures`

#### Summary

Failures about HostObj.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToTransferAttachedGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToTransferAttachedGroup`

#### Summary

Unable to load attached group [Type Name] of model group [Type Name].

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToSaveGroupType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToSaveGroupType`

#### Summary

Unable to save group type.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToRestoreAllMembersOfGroups`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToRestoreAllMembersOfGroups`

#### Summary

Revit is unable to restore the members of the selected groups.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToReplaceSelectedGroups`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToReplaceSelectedGroups`

#### Summary

Unable to change the types of the groups you have selected and the related groups. You might try deleting the groups you wish
to change and placing or copy/pasting new groups of the desired type.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToRemapDetails`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToRemapDetails`

#### Summary

Unable to create attached detail group in view '[View Name]' for the selected elements.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToMoveElemsToProject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToMoveElemsToProject`

#### Summary

Revit is unable to move the selected group members to the project.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToMaintainExclusionsWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToMaintainExclusionsWarn`

#### Summary

Unable to maintain exclusion of some group members. Some excluded members have been restored.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToMaintainExclusions`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToMaintainExclusions`

#### Summary

Unable to maintain exclusion of some group members. Some excluded members have been restored.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToLoadGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToLoadGroup`

#### Summary

Unable to load file '[File Name]' as a group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToLoadDetailGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToLoadDetailGroup`

#### Summary

Unable to load detail group '[Type Name]'.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToLoadAttachedGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToLoadAttachedGroup`

#### Summary

Unable to load attached detail group '[Type Name]'.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToGroupElems`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToGroupElems`

#### Summary

Revit does not allow grouping of some of the selected elements. These elements will not be included in the group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToExcludeElems`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToExcludeElems`

#### Summary

Unable to exclude the selected group members.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToDetachGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToDetachGroup`

#### Summary

Unable to detach the selected attached detail group(s).

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToCreateAttachedGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToCreateAttachedGroup`

#### Summary

Unable to create attached detail group in view '[View Name]' for the selected elements.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToConvertGroupsToLinks`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToConvertGroupsToLinks`

#### Summary

Unable to convert the selected groups to links.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToBindLinkInstances`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToBindLinkInstances`

#### Summary

Unable to bind some link instances. Either linked file contains no 3d elements or there was an error loading its elements into the current
project.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToBindLink`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.UnableToBindLink`

#### Summary

Unable to bind the selected links.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.SomeMembersNotRestored`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.SomeMembersNotRestored`

#### Summary

Revit was not able to restore all of the requested group members. The members may depend on elements that are still excluded.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.SomeGroupInstsBecameEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.SomeGroupInstsBecameEmpty`

#### Summary

Group instances have had all their group members deleted and will also be deleted.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.RevitUnableToUpadateGroups`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.RevitUnableToUpadateGroups`

#### Summary

Unable to update groups for changes.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.RemovingReferencesFromGroupedCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.RemovingReferencesFromGroupedCurve`

#### Summary

References to elements outside the group were removed from a grouped curve element.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.RemovingElemCannotBeGrouped`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.RemovingElemCannotBeGrouped`

#### Summary

Elements that cannot be grouped were removed from groups of type '[Type Name]'.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.RemoveGroupSketchConstraintParent`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.RemoveGroupSketchConstraintParent`

#### Summary

You are removing an element from the group which is involved in a sketch or family constraint with another element of the same group.
Either remove the constraint or cancel the removal of this element from the group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ReferencesOutsideGroupAreNotAllowed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ReferencesOutsideGroupAreNotAllowed`

#### Summary

The elements you have selected for grouping contain dimensions or tags whose references are not all included in the selection being
grouped and are not all included in a common model group.
As a result, some of the selected elements have not been included in the new group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ProblemRegeneratingInGroupUpdate`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ProblemRegeneratingInGroupUpdate`

#### Summary

Unable to regenerate while updating groups at end of transaction.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.PlaceGroupFailed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.PlaceGroupFailed`

#### Summary

Unable to place group instances.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NotAllGroupsFullyRestored`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NotAllGroupsFullyRestored`

#### Summary

Not all of the excluded members of the select groups were fully restored. You may be able to restore the remaining members individually
or by performing "restore all excluded members" on sub-groups of the selected groups.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NotAGroupFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NotAGroupFile`

#### Summary

This is not a Group File.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NoneOfSelElemsGroupable`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NoneOfSelElemsGroupable`

#### Summary

None of the selected elements can be grouped. The elements may already be grouped or may be element types which are not allowed for grouping.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NoSwapGroupBeingEdited`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NoSwapGroupBeingEdited`

#### Summary

You may not change the type of the group that is currently being edited.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NoModelGroups`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NoModelGroups`

#### Summary

There are no Model Groups in this Project or Family.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NoDetailGroups`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NoDetailGroups`

#### Summary

There are no Detail Groups in this Project or Family.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NoAppropriateGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.NoAppropriateGroup`

#### Summary

There is no Group that can be placed in the current view.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.MoveElemFailed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.MoveElemFailed`

#### Summary

Unable to move element.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ModifyingMultiGroups`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ModifyingMultiGroups`

#### Summary

Multiple groups of the same type are being edited simultaneously outside group edit mode in an unacceptable manner.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.MembersMovedToProjectToMakeConsistent`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.MembersMovedToProjectToMakeConsistent`

#### Summary

Group members had to be "moved to the project" (removed from their group instance) because they were not consistent
with the group type definition.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.MembersExcludedWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.MembersExcludedWarn`

#### Summary

Group members have been excluded from this group instance.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.MembersExcluded`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.MembersExcluded`

#### Summary

Group members have been excluded from this group instance.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.MembersAlignWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.MembersAlignWarn`

#### Summary

User parameter values for group members have been aligned.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.LoadOfGroupAbortedByUser`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.LoadOfGroupAbortedByUser`

#### Summary

You have aborted loading file '[File Name]' as a group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.LinkVisibilityLost`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.LinkVisibilityLost`

#### Summary

Link visibility overrides will be lost.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.LastGroupMemberExcluded`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.LastGroupMemberExcluded`

#### Summary

Last member of group instance was excluded (deleted), removed, or moved to the project. Group instance has been deleted.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.LastCopyOfGroupDeleted`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.LastCopyOfGroupDeleted`

#### Summary

Last copy of Group "[Name]" deleted. Group type removed from project.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.InvalidGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.InvalidGroup`

#### Summary

This group is invalid.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupsNotCompatibleForTypeChange`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupsNotCompatibleForTypeChange`

#### Summary

Some of the selected groups are not compatible with the new group type that was chosen.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupsHaveDifferentMembers`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupsHaveDifferentMembers`

#### Summary

Group instances of the same type do not contain identical members. Press "Fix Groups..." to select from options to make
the groups consistent.\nCorresponding group members in different group instances diverge in the following respects:[Description]

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupsHasCycle`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupsHasCycle`

#### Summary

Can't create Group because it contains multiple copies of same Group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupedModelElemHasViewSpecificSubordinates`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupedModelElemHasViewSpecificSubordinates`

#### Summary

Unable to group the selected elements. Model element in group has view specific subordinates or view specific element in group
has non-view specific subordinates.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupViewSpecificDiffViews`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupViewSpecificDiffViews`

#### Summary

You may not create a detail group with view specific elements from different views.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupPropagationUserCancelled`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupPropagationUserCancelled`

#### Summary

Changes to Group "[Type Name]" have been cancelled.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupPropagationFailedUngroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupPropagationFailedUngroup`

#### Summary

Can't make change to Group "[Type Name]" with more than one instance. To resolve: Ungroup and Group again under a new name.
Edit and make change, then change all instances of the original Group to the new Group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupPropagationFailedSketch`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupPropagationFailedSketch`

#### Summary

Can't change Group"[Name]" with more than one instance because it has a Sketch-based element. Edit the Sketch of the element instead.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupHadFailedElementsWhileUpdating`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupHadFailedElementsWhileUpdating`

#### Summary

Group members failed while updating group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupEditModeNoDuplicates`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupEditModeNoDuplicates`

#### Summary

Can't create duplicates in Edit Group mode.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupChangeNoPlaceElements`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupChangeNoPlaceElements`

#### Summary

Elements cannot be placed as a result of changes to groups.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupCannotSaveWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupCannotSaveWarn`

#### Summary

The group cannot be saved at this time because one of its instances is being edited.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupCannotSave`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupCannotSave`

#### Summary

The group cannot be saved at this time because one of its instances is being edited.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupCannotMixBackAndForegroundDetail`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupCannotMixBackAndForegroundDetail`

#### Summary

This detail group contains some elements which display in the background and some which display in the foreground. Detail groups
must be able to be displayed as a unit in either the foreground or background, so this type of mixture is not allowed.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupAmongstLoadedRenamed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.GroupAmongstLoadedRenamed`

#### Summary

A group or groups that was loaded was renamed because its name was not unique amongst the groups in the file being loaded.
Most likely a model subgroup had the same name as the loaded file.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.FailedToTransformAttachedGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.FailedToTransformAttachedGroup`

#### Summary

Attached group could not be properly relocated.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.FailedToSetLeaderGroupId`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.FailedToSetLeaderGroupId`

#### Summary

Unable to set id of group type.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.FailedToChangeGroupLevelRef`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.FailedToChangeGroupLevelRef`

#### Summary

Unable to change group level ref.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ExcludedElementsRestoredInLink`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ExcludedElementsRestoredInLink`

#### Summary

Excluded elements restored in the link.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ElementsContainsFabricationData`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ElementsContainsFabricationData`

#### Summary

Unable to load models containing elements with fabrication data as group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ElementChangedMoreThanAllowed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ElementChangedMoreThanAllowed`

#### Summary

The Grouped element has changed length enough to make it substantially different from other Group instances.
To make this degree of change Edit Group and make the change again.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.DontEditNestedGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.DontEditNestedGroup`

#### Summary

Cannot edit nested Groups while inside Edit Group mode for its host Group. To edit the nested Group finish editing all Groups.
Use the Tab key to select the nested Group and edit it directly.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.DimensionsOrTagsReferecedRemoved`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.DimensionsOrTagsReferecedRemoved`

#### Summary

Dimensions or Tags that reference non-group members have been removed from group [Name].

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.DimRefsGroupMemberSketch`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.DimRefsGroupMemberSketch`

#### Summary

A group member's sketch or family is constrained to an element that is not a member of the group. These constraints have been removed.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.DetailsOfNestedGroupsLost`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.DetailsOfNestedGroupsLost`

#### Summary

Details will be deleted if they reference group members being ungrouped in other instances of this containing group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ChildrenLostOnGroupSwap`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ChildrenLostOnGroupSwap`

#### Summary

Some elements could not find new hosts after changing group type and will be deleted.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ChildrenDeletedOnGroupSwap`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.ChildrenDeletedOnGroupSwap`

#### Summary

Some dependent elements were deleted by changing group type and cannot be retained.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotSwapNestedGroups`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotSwapNestedGroups`

#### Summary

Can't replace because one Group is contained in the other.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotSaveGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotSaveGroup`

#### Summary

Can't save Group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotRemoveSubordFromGroupWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotRemoveSubordFromGroupWarn`

#### Summary

Element can't be removed or excluded from the Group because it is required by another Group element.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotRemoveSubordFromGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotRemoveSubordFromGroup`

#### Summary

Element can't be removed or excluded from the Group because it is required by another Group element.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotRemoveGroupMemberConstraintWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotRemoveGroupMemberConstraintWarn`

#### Summary

Constraints between group members cannot be removed or excluded from the group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotRemoveGroupMemberConstraint`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotRemoveGroupMemberConstraint`

#### Summary

Constraints between group members cannot be removed or excluded from the group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotReloadWithFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotReloadWithFile`

#### Summary

Group [Type Name] cannot be reloaded from file [File Name].

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotPlaceGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotPlaceGroup`

#### Summary

Can't place Group from browser. Try copy/pasting existing copy of the Group instead.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotLinkAnnotationsForSomeViews`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotLinkAnnotationsForSomeViews`

#### Summary

Annotations for some views cannot be displayed from linked file.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotFinishGroupInSketchMode`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotFinishGroupInSketchMode`

#### Summary

Can't Finish Group while in Sketch Mode.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotCreateGroupWithInvalidReferences`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotCreateGroupWithInvalidReferences`

#### Summary

The elements you have selected for grouping contain dimensions or tags which do not reference a common model group.
No detail group has been created.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotCreateGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotCreateGroup`

#### Summary

Cannot create group of these elements.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotCopyGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotCopyGroup`

#### Summary

Unable to copy the selected group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotAddToGroupFormatWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotAddToGroupFormatWarn`

#### Summary

[Element] cannot be added to the instance of [Group]

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotAddToGroupFormat`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotAddToGroupFormat`

#### Summary

[Element] cannot be added to the instance of [Group]

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotAddAlreadyMemberToDiffGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.CannotAddAlreadyMemberToDiffGroup`

#### Summary

Elements that are already members of one group cannot be added to another group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.BadViewForAttachedGroupWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.BadViewForAttachedGroupWarn`

#### Summary

Attached groups can only be created for view specific elements belonging to non-3d model views.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.BadViewForAttachedGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.BadViewForAttachedGroup`

#### Summary

Attached groups can only be created for view specific elements belonging to non-3d model views.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.BadProblemWithGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.BadProblemWithGroup`

#### Summary

The operation performed affects groups in an unacceptable manner.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AttachedGroupNoPasteToView`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AttachedGroupNoPasteToView`

#### Summary

An attached group cannot be pasted into the selected view type and has been omitted from the elements being pasted.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AttachedGroupNoMirror`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AttachedGroupNoMirror`

#### Summary

Attached detail groups cannot be mirrored without also mirroring their parent group.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AtomViolationWhenOnePlaceInstance`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AtomViolationWhenOnePlaceInstance`

#### Summary

A group has been changed outside group edit mode. The change is being allowed because there is only one instance of the type.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AtomViolationWhenMultiPlacedInstances`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AtomViolationWhenMultiPlacedInstances`

#### Summary

Changes to groups are allowed only in group edit mode. Use the Edit Group command to change to all instances of a group type.
You may use the "Ungroup" option to proceed with this change by ungrouping the changed group instances.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AtomTouchedNotAllowedDelete`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AtomTouchedNotAllowedDelete`

#### Summary

Changes to groups are only allowed during Edit Group mode. Use Edit Group to make this change.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AtomTouchedNotAllowed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AtomTouchedNotAllowed`

#### Summary

Changes to groups are only allowed during Edit Group mode. Use Edit Group to make this change.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AllElementsRemovedFromGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AllElementsRemovedFromGroup`

#### Summary

Group "[Type Name]" is now empty and will be deleted.

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AdditionalElementsRequiredRemove`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AdditionalElementsRequiredRemove`

#### Summary

To be able to remove the selected elements from the group the following additional element(s) will also be removed: [Description]

### `P:Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AdditionalElementsRequired`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures.AdditionalElementsRequired`

#### Summary

Grouping the selected elements requires that additional element(s) also be grouped. [Description]
To satisfy the grouping requirement, these additional element(s) will be automatically added to the group as well.

### `T:Autodesk.Revit.DB.BuiltInFailures.GroupFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GroupFailures`

#### Summary

Failures related to groups and their behavior.

### `P:Autodesk.Revit.DB.BuiltInFailures.GridFailures.GridlineAxisTooFar`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GridFailures.GridlineAxisTooFar`

#### Summary

Axis of gridlines should not be further than [Value] to each other.

### `P:Autodesk.Revit.DB.BuiltInFailures.GridFailures.GridlineAxisTooClose`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GridFailures.GridlineAxisTooClose`

#### Summary

Axis of gridlines should not change order or be closer than [Value] to each other.

### `P:Autodesk.Revit.DB.BuiltInFailures.GridFailures.GridInGridChainCannotMirror`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GridFailures.GridInGridChainCannotMirror`

#### Summary

A grid that is a sub-grid of a multi-segment grid can only be mirrored if the entire multi-segment grid is being mirrored.

### `P:Autodesk.Revit.DB.BuiltInFailures.GridFailures.GridEndSegmentsLengthTooShort`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GridFailures.GridEndSegmentsLengthTooShort`

#### Summary

The end segment length for a grid must be at least [Length Value]

### `T:Autodesk.Revit.DB.BuiltInFailures.GridFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GridFailures`

#### Summary

Failures about Grid.

### `P:Autodesk.Revit.DB.BuiltInFailures.GridChainSketchFailures.OverlappingLines`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GridChainSketchFailures.OverlappingLines`

#### Summary

GridChain sketch contains lines which overlap.

### `P:Autodesk.Revit.DB.BuiltInFailures.GridChainSketchFailures.MoreThanOneLoop`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GridChainSketchFailures.MoreThanOneLoop`

#### Summary

GridChain sketch contains more than one loop.

### `P:Autodesk.Revit.DB.BuiltInFailures.GridChainSketchFailures.InvalidSketch`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GridChainSketchFailures.InvalidSketch`

#### Summary

Sketch is invalid. Grid sketch must consist of a single open loop with no intersecting lines.

### `P:Autodesk.Revit.DB.BuiltInFailures.GridChainSketchFailures.ClosedLoop`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GridChainSketchFailures.ClosedLoop`

#### Summary

GridChain sketch contains a closed loop.

### `T:Autodesk.Revit.DB.BuiltInFailures.GridChainSketchFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GridChainSketchFailures`

#### Summary

Failures related to the GridChain sketch.

### `P:Autodesk.Revit.DB.BuiltInFailures.GlobalParameterFailures.InvalidElementPropToGlobalParamLink`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GlobalParameterFailures.InvalidElementPropToGlobalParamLink`

#### Summary

The following parameters of the highlighted element can no longer be linked to global parameters: %1!s!.

### `P:Autodesk.Revit.DB.BuiltInFailures.GlobalParameterFailures.GlobalParamInvalidElemParamValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GlobalParameterFailures.GlobalParamInvalidElemParamValue`

#### Summary

Invalid value of parameter %1!s! in highlighted element.

### `P:Autodesk.Revit.DB.BuiltInFailures.GlobalParameterFailures.GlobalParamFormulaCircularChainError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GlobalParameterFailures.GlobalParamFormulaCircularChainError`

#### Summary

A formula in a global parameter causes a circular chain of references between highlighted elements.

### `P:Autodesk.Revit.DB.BuiltInFailures.GlobalParameterFailures.GlobalParamFormulaCircularChain`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GlobalParameterFailures.GlobalParamFormulaCircularChain`

#### Summary

A formula in a global parameter causes a circular chain of references between highlighted elements.

### `P:Autodesk.Revit.DB.BuiltInFailures.GlobalParameterFailures.ElementPropLinkCircularChainError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GlobalParameterFailures.ElementPropLinkCircularChainError`

#### Summary

Linked properties in highlighted elements cause a circular chain of references.

### `P:Autodesk.Revit.DB.BuiltInFailures.GlobalParameterFailures.ElementPropLinkCircularChain`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GlobalParameterFailures.ElementPropLinkCircularChain`

#### Summary

Linked properties in highlighted elements cause a circular chain of references.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.TooManyFacesEdges`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.TooManyFacesEdges`

#### Summary

This family instance has too many [Edges and Faces]. Remove unnecessary geometry or split the instance into multiple instances.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.SymbolicLineInvalidPlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.SymbolicLineInvalidPlane`

#### Summary

Symbolic Element refers to a Work Plane with unacceptable normal.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.SuccessToConvertLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.SuccessToConvertLine`

#### Summary

Success to convert lines

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.SiteInvisible`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.SiteInvisible`

#### Summary

Topographic elements are not visible in your current view. You can modify View Range settings in the view's Properties or Visibility settings in Visibility/Graphics.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.PolygonSegmentTooShort`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.PolygonSegmentTooShort`

#### Summary

Polygon segment too short

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.OffsetFaceFailed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.OffsetFaceFailed`

#### Summary

Failed to offset the face.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.LineArcTangentFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.LineArcTangentFailure`

#### Summary

Can't keep arc element and straight line element tangent.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.FailedUpdateCurveChain`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.FailedUpdateCurveChain`

#### Summary

Failed to update curve chain.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.FailedReplaceCurveElemCurveDriver`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.FailedReplaceCurveElemCurveDriver`

#### Summary

Failed to replace curve elem curve driver.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.FailToConvertLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.FailToConvertLine`

#### Summary

Unable to convert lines

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.ElementTooSmall`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.ElementTooSmall`

#### Summary

Element is too small on screen

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.ElementIsTooThin`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.ElementIsTooThin`

#### Summary

[Element] is too thin.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.CurveProjectTooShort`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.CurveProjectTooShort`

#### Summary

The projection of the line in this view is too short to create a new Line

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.CurveDriverError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.CurveDriverError`

#### Summary

Element's internal join data is corrupt.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.CurveAndSurfaceDoNotIntersect`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.CurveAndSurfaceDoNotIntersect`

#### Summary

Curve and Surface do not intersect.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.ConvertFaceRegionsToFacesFailed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.ConvertFaceRegionsToFacesFailed`

#### Summary

Failed to replace an instance face with its face regions.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.ConvertFaceRegionsToFacesCrashed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.ConvertFaceRegionsToFacesCrashed`

#### Summary

Failed to replace an instance face with its face regions.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.CannotFindClosest`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures.CannotFindClosest`

#### Summary

Cannot find closest points within lines.

### `T:Autodesk.Revit.DB.BuiltInFailures.GeometryFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeometryFailures`

#### Summary

Failures about GeometryFailures.

### `P:Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.ValidatePHSegmentLengthWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.ValidatePHSegmentLengthWarning`

#### Summary

The placeholder curve is not long enough to support the required fittings for placeholder convert

### `P:Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.ValidatePHSegmentConnWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.ValidatePHSegmentConnWarning`

#### Summary

The placeholder curve will not be able to connect to the required fittings for placeholder convert

### `P:Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.SplitElementDeletionWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.SplitElementDeletionWarning`

#### Summary

The value specified for the Joint Gap exceeds the length of the split segment, so the segment will be deleted.

### `P:Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.SizingFailedZeroFlow`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.SizingFailedZeroFlow`

#### Summary

Sizing failed. Flow for section is 0.

### `P:Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.SegmentIsTooShort`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.SegmentIsTooShort`

#### Summary

The segment is too short.

### `P:Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.MaxWidthAndHeightReached`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.MaxWidthAndHeightReached`

#### Summary

Maximum width and height reached during sizing

### `P:Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.InlineEndoflineMismatch`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.InlineEndoflineMismatch`

#### Summary

[Element Name]: It is not possible to calculate the flow since there is inline equipment that is configured as end of line.
Please check equipment in this system and make sure that the equipment connectors used inline have a global system classification and a calculated flow configuration.
Global equipment connectors used inline should always be linked to each other.

### `P:Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.FlowDirectionMismatch`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.FlowDirectionMismatch`

#### Summary

[Element Name]: It is not possible to calculate the flow since the flow direction mismatch.
Please check flow direction on all equipment in this system.

### `P:Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.FlowConfigMismatch`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.FlowConfigMismatch`

#### Summary

[Element Name]: It is not possible to calculate the flow since all the components in this system have the flow configuration
set to Preset or System. At least one component is required to have the flow configuration set to Calculated.

### `P:Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.FailedToPlaceCapWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.FailedToPlaceCapWarning`

#### Summary

Failed to place cap on the open connector.

### `P:Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.CapsWereAddedWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.CapsWereAddedWarning`

#### Summary

X caps were added.

### `P:Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.CapWasAddedWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures.CapWasAddedWarning`

#### Summary

1 cap was added.

### `T:Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericMEPFailures`

#### Summary

Failures applicable to different mechanical, electrical and piping Elements.

### `P:Autodesk.Revit.DB.BuiltInFailures.GenericFailures.ElementsInInvalidContext`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericFailures.ElementsInInvalidContext`

#### Summary

There are elements in the document that exist in a context they should not. These elements must be deleted to continue using this project or family.

### `T:Autodesk.Revit.DB.BuiltInFailures.GenericFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GenericFailures`

#### Summary

Generic failures that may apply to any Revit Element

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.WarningInFamilyDismissed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.WarningInFamilyDismissed`

#### Summary

A warning in family "[Name]" was dismissed. Please review warning information to determine if any changes are necessary\nWarning Information:\n"[Text]"

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ValueOutOfRange`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ValueOutOfRange`

#### Summary

Value is out of range ! Please enter a number between [Value] and [Value].

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.UnspecifiedError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.UnspecifiedError`

#### Summary

Revit has experienced an unexpected error. The operation has been cancelled to protect your project from corruption.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.UnresolvableErrorInFamilyWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.UnresolvableErrorInFamilyWarn`

#### Summary

An error occurred in family "[Name]" that cannot be automatically resolved.\nError Information:\n"[Text]"

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.UnresolvableErrorInFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.UnresolvableErrorInFamily`

#### Summary

An error occurred in family "[Name]" that cannot be automatically resolved.\nError Information:\n"[Text]"

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.TransactionFailedWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.TransactionFailedWarn`

#### Summary

[Description]

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.TransactionFailed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.TransactionFailed`

#### Summary

[Description]

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.SeriousElementReferenceCorruption`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.SeriousElementReferenceCorruption`

#### Summary

Element references are seriously corrupt.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ParameterValuesConflict`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ParameterValuesConflict`

#### Summary

The value for [Parameter Name] must be at least [Value] below the value for [Parameter Name].

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ParameterValueNotInRange`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ParameterValueNotInRange`

#### Summary

The value for [Parameter Name] must be between [Value] and [Value].

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.NoRelatedWarnings`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.NoRelatedWarnings`

#### Summary

Document doesn't contain any warnings related to these elements.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.NameNotUnique`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.NameNotUnique`

#### Summary

The name entered is already in use. Enter a unique name.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.NameIsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.NameIsEmpty`

#### Summary

Name is empty

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.NameInUse`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.NameInUse`

#### Summary

The name "[Name]" is already in use.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.InvalidValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.InvalidValue`

#### Summary

Invalid value.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.InvalidOrderOfPhases`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.InvalidOrderOfPhases`

#### Summary

Invalid order of phases: [Type Name] cannot be demolished before it was created.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.InvalidInputWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.InvalidInputWarn`

#### Summary

Invalid Input

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.InvalidInput`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.InvalidInput`

#### Summary

Invalid Input

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.InternalProblemsParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.InternalProblemsParameter`

#### Summary

Parameter cannot be changed due to internal problems.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.InaccuracyDetected`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.InaccuracyDetected`

#### Summary

A geometric inaccuracy was found in the element.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.GenericWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.GenericWarning`

#### Summary

A generic error has occurred.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.GenericNonFatalError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.GenericNonFatalError`

#### Summary

A serious error has occurred. It is strongly recommended that you use Save As to save your work in a new file before continuing.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.GenericFatalError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.GenericFatalError`

#### Summary

A fatal error has occurred. The application will be terminated. You will be given the opportunity to save
recovery files for all of your changed projects.\tWould you like to save a recovery file for [Project Name]?

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.GenericErrorNone`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.GenericErrorNone`

#### Summary

None.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.GenericError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.GenericError`

#### Summary

Error.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.GenericCorruption`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.GenericCorruption`

#### Summary

A generic error has occurred.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.FamilySeparationTestingError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.FamilySeparationTestingError`

#### Summary

Family separation testing error (internal).

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.FailedToReadLine`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.FailedToReadLine`

#### Summary

Failed to read line.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.FailedToOpenFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.FailedToOpenFile`

#### Summary

Failed to open file.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ErrorResolved`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ErrorResolved`

#### Summary

Error "[Text]" was automatically resolved by "[Resolution]"

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ErrorInSymbolFamilyResolved`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ErrorInSymbolFamilyResolved`

#### Summary

An error occurred in family "[Name]" and was automatically resolved, but may require review by the family creator.\nError Information:\n"[Text]"\nError Resolution: [Resolution]

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ErrorInFamilyResolved`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ErrorInFamilyResolved`

#### Summary

An error occurred in family "[Name]" and was automatically resolved. Please review changes made to the family.\nError Information:\n"[Text]"\nError Resolution: [Resolution]

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.EnterValueBetween`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.EnterValueBetween`

#### Summary

Please enter a value between [Value] and [Value].

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.EnterValidRealGreaterThan`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.EnterValidRealGreaterThan`

#### Summary

Enter a number greater than [Value].

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.EnterNonNegativeValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.EnterNonNegativeValue`

#### Summary

Enter a non-negative value.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.DuplicateValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.DuplicateValue`

#### Summary

Elements have duplicate '[Value]' values.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.CoreElemTestingError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.CoreElemTestingError`

#### Summary

Core element testing error (internal).

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ConvertingOldAxisToNormal`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ConvertingOldAxisToNormal`

#### Summary

This operation will convert the existing axis of revolution to a normal line.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ContentDocTreeCorruption`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.ContentDocTreeCorruption`

#### Summary

Problems with the Content Doc Tree structure - e.g. orphaned Content Docs, Families w/o docs, missing Owner Fam, what-not

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.CharactersNotAllowed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.CharactersNotAllowed`

#### Summary

Name cannot contain any of the following characters:\n[{}[]|;<>?`~]\nor any of the non-printable characters.

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.CannotSetParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.CannotSetParameter`

#### Summary

Cant set parameter

### `P:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.CannotFixProblem`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures.CannotFixProblem`

#### Summary

Failed to fix problem. Action has to be cancelled.

### `T:Autodesk.Revit.DB.BuiltInFailures.GeneralFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.GeneralFailures`

#### Summary

Failures about GeneralFailures.

### `P:Autodesk.Revit.DB.BuiltInFailures.FormFailures.VoidFormsNotUsed`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FormFailures.VoidFormsNotUsed`

#### Summary

Some Void Forms of this family do not cut anything and will be deleted. To make a Void Form cut something else use the Cut Geometry tool.

### `P:Autodesk.Revit.DB.BuiltInFailures.FormFailures.OpenProfileMultiSegmentSweepsNotSupported`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FormFailures.OpenProfileMultiSegmentSweepsNotSupported`

#### Summary

An open profile cannot be swept along a multi-segment path.

### `P:Autodesk.Revit.DB.BuiltInFailures.FormFailures.FormElemRegenSelfIntersectionResetConnections`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FormFailures.FormElemRegenSelfIntersectionResetConnections`

#### Summary

This form cannot be created due to self-intersecting geometry. Clicking the Reset Connections button will attempt to solve this problem.

### `P:Autodesk.Revit.DB.BuiltInFailures.FormFailures.FormElemRegenSelfIntersectionReorderProfiles`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FormFailures.FormElemRegenSelfIntersectionReorderProfiles`

#### Summary

This form cannot be created due to self-intersecting geometry. Clicking the Reorder Profiles button will attempt to solve this problem.

### `P:Autodesk.Revit.DB.BuiltInFailures.FormFailures.FormElemRegenSelfIntersection`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FormFailures.FormElemRegenSelfIntersection`

#### Summary

Unable to create form element: self-intersecting or singular geometry would result.

### `P:Autodesk.Revit.DB.BuiltInFailures.FormFailures.FormElemRegenFailureError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FormFailures.FormElemRegenFailureError`

#### Summary

Unable to create form element

### `P:Autodesk.Revit.DB.BuiltInFailures.FormFailures.FormElemRegenFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FormFailures.FormElemRegenFailure`

#### Summary

Unable to create form element

### `P:Autodesk.Revit.DB.BuiltInFailures.FormFailures.FormCreationInvalidGeomCombination`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FormFailures.FormCreationInvalidGeomCombination`

#### Summary

Cannot remake form that is currently cut or joined to other geometry. Please uncut or unjoin first.

### `P:Autodesk.Revit.DB.BuiltInFailures.FormFailures.DissolveUnableToDissolveForm`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FormFailures.DissolveUnableToDissolveForm`

#### Summary

Unable to dissolve form element.

### `P:Autodesk.Revit.DB.BuiltInFailures.FormFailures.DissolveNoValidInputs`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FormFailures.DissolveNoValidInputs`

#### Summary

No form elements selected to dissolve.

### `P:Autodesk.Revit.DB.BuiltInFailures.FormFailures.AddProfileFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FormFailures.AddProfileFailure`

#### Summary

Failed to Add Profile

### `T:Autodesk.Revit.DB.BuiltInFailures.FormFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FormFailures`

#### Summary

Failures about Form.

### `P:Autodesk.Revit.DB.BuiltInFailures.ForeignFileFailures.ForeignLink`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ForeignFileFailures.ForeignLink`

#### Summary

This file [RvtLinkName] was saved by an application that was not developed or licensed by Autodesk.

### `P:Autodesk.Revit.DB.BuiltInFailures.ForeignFileFailures.ForeignFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ForeignFileFailures.ForeignFile`

#### Summary

This file [FamilyName] was saved by an application that was not developed or licensed by Autodesk.

### `T:Autodesk.Revit.DB.BuiltInFailures.ForeignFileFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.ForeignFileFailures`

#### Summary

Failures about files saved by applications that were not developed or licensed by Autodesk.

### `P:Autodesk.Revit.DB.BuiltInFailures.FluidFailures.UndefinedFluidType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FluidFailures.UndefinedFluidType`

#### Summary

The fluid type '[Type Name]' is not defined

### `T:Autodesk.Revit.DB.BuiltInFailures.FluidFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FluidFailures`

#### Summary

Failures about Fluid.

### `P:Autodesk.Revit.DB.BuiltInFailures.FloorFailures.FloorSlopeExceedsThreshold`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FloorFailures.FloorSlopeExceedsThreshold`

#### Summary

Thickness of this Floor may be slightly inaccurate due to extreme Shape Editing. Dimensions to this element in
sections and details may not accurately indicate the Thickness shown in Type Properties.

### `T:Autodesk.Revit.DB.BuiltInFailures.FloorFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FloorFailures`

#### Summary

Failures related to floors and slabs.

### `P:Autodesk.Revit.DB.BuiltInFailures.FilledRegionFailures.CannotDrawFilledRegionError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FilledRegionFailures.CannotDrawFilledRegionError`

#### Summary

Can't draw [Filled Region Name].

### `P:Autodesk.Revit.DB.BuiltInFailures.FilledRegionFailures.CannotDrawFilledRegion`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FilledRegionFailures.CannotDrawFilledRegion`

#### Summary

Can't draw [Filled Region Name].

### `P:Autodesk.Revit.DB.BuiltInFailures.FilledRegionFailures.BadViewType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FilledRegionFailures.BadViewType`

#### Summary

[Filled Region Name] can't be placed in 3D Views.

### `T:Autodesk.Revit.DB.BuiltInFailures.FilledRegionFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FilledRegionFailures`

#### Summary

Failures about FilledRegion.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.WhileScanningParametersForType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.WhileScanningParametersForType`

#### Summary

While loading Type '[Name]', parameter '[Name]': [Description]

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.WhileLoadingFamilyShared`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.WhileLoadingFamilyShared`

#### Summary

While loading shared family '[Family Name]' from family '[Family Name]': [Description]

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.WhileLoadingFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.WhileLoadingFamily`

#### Summary

While loading family '[Family Name]': [Description]

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ValueOutOfRange`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ValueOutOfRange`

#### Summary

The value must be from 0.0 to 1.0

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.UnexpectedFamilyChangeResultsWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.UnexpectedFamilyChangeResultsWarning`

#### Summary

Changing the family for a MEP fitting might cause unexpected results.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.UnexpectedFamilyChangeResultsError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.UnexpectedFamilyChangeResultsError`

#### Summary

Changing the family for a MEP fitting might cause unexpected results.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.UnableToUpgradeDueToCorruptFamilies`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.UnableToUpgradeDueToCorruptFamilies`

#### Summary

Some families have become unusable. Reload the families, or delete them from the model.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.UnableGenerateTrussByFamilyAndOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.UnableGenerateTrussByFamilyAndOrientation`

#### Summary

Revit is unable to generate a truss using the current Layout Family and Truss orientation.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.TypeRecursiveElementIdParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.TypeRecursiveElementIdParameter`

#### Summary

Type's parameter cannot recursively point to the type itself.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.TryingToAttachWhenJoined`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.TryingToAttachWhenJoined`

#### Summary

The column and target are joined. The attachment has been removed.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.TitleblockBadViewType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.TitleblockBadViewType`

#### Summary

Titleblocks can only be placed on sheets.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.StructuralColumnAttachedToNonStructuralTarget`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.StructuralColumnAttachedToNonStructuralTarget`

#### Summary

The structural column is attached to a non-structural target.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.SlantedColumnEndPlanesHaveFlipped`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.SlantedColumnEndPlanesHaveFlipped`

#### Summary

Position of end cut planes has resulted in a slanted column without any geometry.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.SlantedColumnEndCutPlaneIsParallelToGeometry`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.SlantedColumnEndCutPlaneIsParallelToGeometry`

#### Summary

Cut plane of slanted column end is parallel to the location curve.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.SketchCannotBeAutomaticallyDimensioned`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.SketchCannotBeAutomaticallyDimensioned`

#### Summary

Sketch can't be Automatically Dimensioned - this is a prerequisite for Labeled Dimensions to work properly.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.SizeLookupTableIsNotAvailableForType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.SizeLookupTableIsNotAvailableForType`

#### Summary

Size Lookup Table is not available for type [Family Symbol].

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.SharedParameterReplacedByBuiltInOne`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.SharedParameterReplacedByBuiltInOne`

#### Summary

Shared parameter [Name] will be replaced by a built-in parameter with the same name. This may affect scheduling!

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.SetbackTooLarge`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.SetbackTooLarge`

#### Summary

Setback computations are too large for this element.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ReferencePlanesOverconstrained`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ReferencePlanesOverconstrained`

#### Summary

Reference Planes are overconstrained.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ProfileContainsNoLoops`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ProfileContainsNoLoops`

#### Summary

Profile type '[Family Symbol]' contains no loops.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.NotFamilyFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.NotFamilyFile`

#### Summary

The selected file is not a Family File.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.NonGenericAnnotationsOutsideLegend`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.NonGenericAnnotationsOutsideLegend`

#### Summary

Only Generic Annotations may be copied between Legends and other Views

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.NoInstparamFormulas`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.NoInstparamFormulas`

#### Summary

Instance Parameters can't be used in Type Parameter formulas.\n\n[Description]

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.MightntPlaceInsertsWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.MightntPlaceInsertsWarning`

#### Summary

There exist geometry collision. These elements might not be copied.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidSlantedColumnOffsetsInNestedFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidSlantedColumnOffsetsInNestedFamily`

#### Summary

Instance of family [Family Name] can't be updated because in nested family the column's base (Base Level + Base Offset) must be below its top (Top Level + Top Offset).

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidSlantedColumnOffsets`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidSlantedColumnOffsets`

#### Summary

The column's base (Base Level + Base Offset) must be below its top (Top Level + Top Offset).

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidParameterValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidParameterValue`

#### Summary

Parameter [Caption] has an invalid value.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidInsertOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidInsertOrientation`

#### Summary

The insert orientation is incompatible with the wall's cross-section.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidFormularFoundInParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidFormularFoundInParameter`

#### Summary

Invalid formular found in parameter '[Param Name]' in type '[Type Name]'.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidFamilyType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidFamilyType`

#### Summary

Invalid family type "[Type Name]".

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidContextForAdaptivePlacement`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InvalidContextForAdaptivePlacement`

#### Summary

The component '%1!s!' cannot be directly placed in the project environment. Place it in either an In-Place Mass, a Conceptual Mass Family, a Curtain Panel by Pattern Family, or an Adaptive Component.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InstOutsideFaceBoundary`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InstOutsideFaceBoundary`

#### Summary

Instance origin does not lie on host face. Instance will lose association to host.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InstMayCutMoreOrFewerHosts`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.InstMayCutMoreOrFewerHosts`

#### Summary

Insert may be cutting fewer or more hosts than needed. The problem may be solved by forcing regeneration, e.g. by moving the insert out and back by a tiny distance in any direction.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.HighlightedElementFamRefsInvalidWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.HighlightedElementFamRefsInvalidWarning`

#### Summary

One or more references of the highlighted element have become invalid.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.HighlightedElementFamRefsInvalidError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.HighlightedElementFamRefsInvalidError`

#### Summary

One or more references of the highlighted element have become invalid.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FrozenBecauseMonitorRelationshipGone`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FrozenBecauseMonitorRelationshipGone`

#### Summary

The position of this element was determined by copy/monitor but the monitor relationship has been removed. To move this instance, use pick new host to select a valid host.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FrozenBecauseFaceGone`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FrozenBecauseFaceGone`

#### Summary

This family instance was hosted by a curved face that is no longer present in the linked file. To move the family instance, rehost it.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FormulasFailedForType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FormulasFailedForType`

#### Summary

"Can't satisfy formulas for type [Family Symbol].

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FormulaBasedParameterCannotBeChanged`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FormulaBasedParameterCannotBeChanged`

#### Summary

Parameter '[Caption]' cannot be changed because it is defined by formula '[Formula]'

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyValidationResult`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyValidationResult`

#### Summary

Family Validation Warning(s): [Description]

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyParameterNoExist`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyParameterNoExist`

#### Summary

The parameter [Name] doesn't exist in the Family. It will be ignored.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyOverconstraintCB`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyOverconstraintCB`

#### Summary

Dimension overconstrains the Family.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyOverconstraint`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyOverconstraint`

#### Summary

Dimension overconstrains the Family.
Cannot set Family Type to <None>.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyNotFitHostShape`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyNotFitHostShape`

#### Summary

The host shape has changed and the family is no longer appropriate.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyNoExternalParametersWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyNoExternalParametersWarning`

#### Summary

Family's Category can't be changed because the Family contains Shared Parameters which are not permitted in the new Category.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyNoExternalParametersError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyNoExternalParametersError`

#### Summary

Family's Category can't be changed because the Family contains Shared Parameters which are not permitted in the new Category.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyMembersReferToOutsideFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyMembersReferToOutsideFamily`

#### Summary

Memebrs of Family '[Name]' or a nested family thereof illegally refer to Elements outside the family.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyIsCorruptWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyIsCorruptWarning`

#### Summary

Some families have become unusable. Reload the families, or delete them from the model.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyIsCorruptError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyIsCorruptError`

#### Summary

Some families have become unusable. Reload the families, or delete them from the model.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyDoesntMatchSystemPropertiesDisconnected`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyDoesntMatchSystemPropertiesDisconnected`

#### Summary

The family no longer matches the properties for the System. Disconnect the family from the System?

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyConnectorDeletedWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyConnectorDeletedWarning`

#### Summary

The family Connector has been modified so the connection is invalid.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyConnectorDeletedError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyConnectorDeletedError`

#### Summary

The family Connector has been modified so the connection is invalid.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyCannotBeUpgraded`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyCannotBeUpgraded`

#### Summary

"Family '[Name]' cannot be upgraded and must be deleted. To fix the file in the older version of Revit, try loading newer versions of these families: [Names]."

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyBadUnattachedVoids`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FamilyBadUnattachedVoids`

#### Summary

Family '[Family Name]' contains unattached voids that can't be combined for cutting. Try fixing the voids or unset the Cut with Voids parameter in the family.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FailedWhenLoadingFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FailedWhenLoadingFamily`

#### Summary

Some unlocked labeled dimensions prevent family from loading. Please try to lock unlocked labeled dimensions and load again.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FailedToSetParameters`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FailedToSetParameters`

#### Summary

Failed to apply family parameters.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FailedToBecomeNonParametric`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.FailedToBecomeNonParametric`

#### Summary

Family failed to become non-parametric!

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ElementTypeParameterized`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ElementTypeParameterized`

#### Summary

The type(s) of the selected element(s) are driven by family parameter(s). Changing the type directly will break the association.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DuplicateTypeName`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DuplicateTypeName`

#### Summary

"Ignoring attempt to add family type '%1!s!' for a second time."

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DuplicateParamName`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DuplicateParamName`

#### Summary

Family parameters have duplicate names.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DuplicateFamilyParameterNameWithSharedParameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DuplicateFamilyParameterNameWithSharedParameter`

#### Summary

Parameter '[Parameter]' has the same name with an existing shared parameter.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DummyHostMustBePerpendicularToXY`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DummyHostMustBePerpendicularToXY`

#### Summary

Dummy host must be perpendicular to Z or Y axis.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DeletingBadFamTypeDumped`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DeletingBadFamTypeDumped`

#### Summary

Can't make type "[Family Name]". It will be deleted. Failing family has been saved to "[File Name]"

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DeletingBadFamType`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DeletingBadFamType`

#### Summary

Can't make type "[Family Name]". It will be deleted.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DeletingBadFamElemError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DeletingBadFamElemError`

#### Summary

Family contains invalid elements. They will be deleted.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DeletingBadFamElemCorruption`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.DeletingBadFamElemCorruption`

#### Summary

Family contains invalid elements. They will be deleted.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CustomFittingCreated`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CustomFittingCreated`

#### Summary

Custom fitting was created.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CouldNotPlaceAdaptiveFamInst`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CouldNotPlaceAdaptiveFamInst`

#### Summary

Could not place Adaptive Family Instance.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CouldNotGenerateReferencesForFamilyInstance`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CouldNotGenerateReferencesForFamilyInstance`

#### Summary

Could not generate references for Family Instance.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ContainsSharedSameNameFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ContainsSharedSameNameFamily`

#### Summary

Family '[Family Name]' contains a shared family of the same name. Please rename one of the two families before loading!

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ColumnTooLong`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ColumnTooLong`

#### Summary

This column is too long. Maximum length is 30,000 ft.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ColumnHeightZeroBecauseOfInvalidOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ColumnHeightZeroBecauseOfInvalidOffset`

#### Summary

Change Offset Value so that Column height is not 0.0.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ColumnAndTargetAlreadyJoined`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ColumnAndTargetAlreadyJoined`

#### Summary

The column and target are joined, remove that join before attaching them.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ColumnAlreadyAttachedWillBeReattached`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.ColumnAlreadyAttachedWillBeReattached`

#### Summary

The column is already attached. It will be detached and attached to the new target.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CircularRefsForInstParams`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CircularRefsForInstParams`

#### Summary

"Instance parameter '%1!s!' generates circular references."

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantSolve`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantSolve`

#### Summary

Can't find solution for formulas for Type '[Type Name]'.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantSetSlantedColumnEndPlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantSetSlantedColumnEndPlane`

#### Summary

Unable to determine slanted column end cut plane.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantPlaceInstanceWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantPlaceInstanceWarning`

#### Summary

Can't place instance of [Symbol]

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantPlaceInstanceError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantPlaceInstanceError`

#### Summary

Can't place instance of [Symbol]

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantPlaceInsertsWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantPlaceInsertsWarning`

#### Summary

Can't place inserts outside of hosts. These elements won't be copied.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantPlaceInsertsError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantPlaceInsertsError`

#### Summary

Can't place inserts outside of hosts. These elements won't be copied.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantPlaceATOnDuctError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantPlaceATOnDuctError`

#### Summary

The air terminal cannot be placed in an elevation or section view unless it is attached to a duct.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantPasteSelection`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantPasteSelection`

#### Summary

Can't paste selection.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantMoveFrozenInstance`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantMoveFrozenInstance`

#### Summary

A family instance placed on a curved surface of a linked file can't be moved while the link is unloaded. To move the instance, reload the link or rehost the instance.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantMirrorInstWoHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantMirrorInstWoHost`

#### Summary

Can't mirror an instance without its host.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantEditWhileGrouped`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantEditWhileGrouped`

#### Summary

You may not edit this parameter while the element is grouped.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantCopySelectionToNonStory`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CantCopySelectionToNonStory`

#### Summary

Can't copy this selection to a non-story Level.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotUnlockFamilyTemplate`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotUnlockFamilyTemplate`

#### Summary

Can't unlock alignments from Family Template.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotSetFamilyTypeToNone`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotSetFamilyTypeToNone`

#### Summary

Cannot set Family Type to 'None';.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotRotateElement`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotRotateElement`

#### Summary

Can't rotate element into this position.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotRegenerateCorruptFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotRegenerateCorruptFamily`

#### Summary

Family [Family Name] is corrupt and its instances cannot be updated. Please reload the family to repair the project..

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotPasteObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotPasteObject`

#### Summary

Can't paste some or all of the selected objects.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotPasteLabelsAcrossFamilies`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotPasteLabelsAcrossFamilies`

#### Summary

Can't paste Labels across Families of different Categories.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotMakeTypeFamilySaved`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotMakeTypeFamilySaved`

#### Summary

Can't make type "[Family Name]". Failing family has been saved to "[File Name]"

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotMakeTypeCB`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotMakeTypeCB`

#### Summary

Can't make type "[Family Name]".

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotLoadMetricFamilyToImperialProject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotLoadMetricFamilyToImperialProject`

#### Summary

Can't load a metric Family into an imperial Project.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotLoadImperialFamilyToMetricProject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotLoadImperialFamilyToMetricProject`

#### Summary

Can't load an imperial Family into a metric Project.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotFindHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotFindHost`

#### Summary

Couldn't find an appropriate Host. Try selecting a different Host Face or switch Placement Mode.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotCutRefPlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotCutRefPlane`

#### Summary

Can't cut reference plane.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotCopyInplaceFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotCopyInplaceFamily`

#### Summary

In-place family groups cannot be copied between in-place families of the same project.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotCopyByPatternFamilies`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotCopyByPatternFamilies`

#### Summary

Can't copy between Mass or Curtain Panel by Pattern families, and other families or Revit projects.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotConvertInstWorkPlaneToHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotConvertInstWorkPlaneToHost`

#### Summary

Can't convert Instance's Work Plane to Host. Try resetting Work Plane to a Level.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotConvertInstHostToWorkPlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotConvertInstHostToWorkPlane`

#### Summary

Can't convert Instance's Host to Work Plane. Try resetting Host to a Level.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotChangeInstFam`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotChangeInstFam`

#### Summary

Can't change Instance's Family. Try changing Instance's Host to a Level first.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotChangeCategory`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotChangeCategory`

#### Summary

Can't change category of Family Instance

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotApplySplitWithGap`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotApplySplitWithGap`

#### Summary

Can't make structural element.

### `P:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotAddParameterToFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures.CannotAddParameterToFamily`

#### Summary

Parameter '[Parameter]' cannot be added to the family.

### `T:Autodesk.Revit.DB.BuiltInFailures.FamilyFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FamilyFailures`

#### Summary

Failures related to families.

### `P:Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.NoFaceForSplit`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.NoFaceForSplit`

#### Summary

The highlighted element no longer contains a face that has been split by highlighted sketch.

### `P:Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.LoopsOutsideFaceSplitError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.LoopsOutsideFaceSplitError`

#### Summary

Some of the lines drawn lie outside of the boundary of the face being split. All lines used to split a face must be contained
within the face being split and cannot intersect or overlap any of the boundaries of that face.

### `P:Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.LoopsDoNotSubdivideFace`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.LoopsDoNotSubdivideFace`

#### Summary

Sketched loops must sub-divide the face into two or more completely enclosed regions.

### `P:Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.InvalidOpenLoopsForFaceSplit`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.InvalidOpenLoopsForFaceSplit`

#### Summary

The open loops used to split the face must lie completely within the face and cannot intersect or overlap any of the face's edges.

### `P:Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.InvalidClosedLoopsForFaceSplit`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.InvalidClosedLoopsForFaceSplit`

#### Summary

The closed loop used to split the face must lie completely within the face and cannot intersect or overlap any of the face's edges.
To split a face at its border, use an open loop that ends on the boundary of the face.

### `P:Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.EndsNotOnEdgeError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.EndsNotOnEdgeError`

#### Summary

Ends of an open loop in sketch splitting face do not lie on an edge of the face to split.

### `P:Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.CannotUseCurvesForFaceSplit`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures.CannotUseCurvesForFaceSplit`

#### Summary

The sketch cannot split the face of the highlighted element.

### `T:Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FaceSplitterFailures`

#### Summary

Failures about FaceSplitter.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricSheetFailures.FabricSheetOutSideOfHostWarning`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricSheetFailures.FabricSheetOutSideOfHostWarning`

#### Summary

Fabric Sheet is placed completely outside of its host.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricSheetFailures.FabricSheetOutSideOfHostError`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricSheetFailures.FabricSheetOutSideOfHostError`

#### Summary

Fabric Sheet is placed completely outside of its host.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricSheetFailures.BentFabricSheetTooLongBendingProfile`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricSheetFailures.BentFabricSheetTooLongBendingProfile`

#### Summary

The bent edge is shorter than the bend profile for this fabric sheet type.

### `T:Autodesk.Revit.DB.BuiltInFailures.FabricSheetFailures`

Member kind: type
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricSheetFailures`

#### Summary

Failures related to fabric sheet elements.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WrongFabricSheetStartOverhang`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WrongFabricSheetStartOverhang`

#### Summary

Wrong Start Overhang of the Fabric Sheet Type.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WrongFabricSheetSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WrongFabricSheetSpacing`

#### Summary

Wrong Spacing of the Fabric Sheet Type.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WrongFabricSheetOverallLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WrongFabricSheetOverallLength`

#### Summary

Wrong Overall Length/Width of the Fabric Sheet Type.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WrongFabricSheetNumberOfWires`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WrongFabricSheetNumberOfWires`

#### Summary

Wrong Number of Wires of the Fabric Sheet Type.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WrongFabricSheetLayoutPattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WrongFabricSheetLayoutPattern`

#### Summary

The Layout Pattern cannot accommodate the current data. Try decreasing the Number of Wires/Spacing.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WrongFabricSheetEndOverhang`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WrongFabricSheetEndOverhang`

#### Summary

Wrong Start Overhang of the Fabric Sheet Type.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WireDiameterTooLarge`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.WireDiameterTooLarge`

#### Summary

Fabric Wire Diameter is too large.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.NoWireMaterialDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.NoWireMaterialDensity`

#### Summary

Material does not have a density defined. The weight of the Fabric Sheet cannot be computed.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.NoSurfPatternOnWire`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.NoSurfPatternOnWire`

#### Summary

Wire elements do not support surface patterns. The surface pattern associated with this material will not be displayed on the indicated Fabric Sheet Type.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.MinorSpacingFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.MinorSpacingFailure`

#### Summary

The spacing in the minor direction is lower than diameter of the wire in the major direction.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.MinorOverhangFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.MinorOverhangFailure`

#### Summary

At least one of the overhangs in the minor direction is lower than radius of the wire in the major direction.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.MinorLapSpliceFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.MinorLapSpliceFailure`

#### Summary

The lap splice in the minor direction is greater than the half of the overall width.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.MajorSpacingFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.MajorSpacingFailure`

#### Summary

The spacing in the major direction is lower than diameter of the wire in the minor direction.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.MajorOverhangFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.MajorOverhangFailure`

#### Summary

At least one of the overhangs in the major direction is lower than radius of the wire in the minor direction.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.MajorLapSpliceFailure`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.MajorLapSpliceFailure`

#### Summary

The lap splice in the major direction is greater than the half of the overall length.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.FabricSheetWrongHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.FabricSheetWrongHost`

#### Summary

Fabric Sheet can be placed only in Structural Floors and straight Structural Walls.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.FabricAreaWrongSheetAlignment`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.FabricAreaWrongSheetAlignment`

#### Summary

Fabric Area Sheet Alignment is incorrect. Can't create Fabric Area.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.FabricAreaWrongLapSplice`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.FabricAreaWrongLapSplice`

#### Summary

Fabric Area Sheet lap splice is incorrect. Can't create Fabric Area.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.FabricAreaWrongHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.FabricAreaWrongHost`

#### Summary

Fabric Area can be placed only in Structural Floors and straight Structural Walls.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.CoverOffsetTooLongTemp`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.CoverOffsetTooLongTemp`

#### Summary

Cover offset is greater than host thickness - support for transient Single Fabric Sheet in editor.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.CoverOffsetTooLong`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.CoverOffsetTooLong`

#### Summary

Cover offset is greater than host thickness.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.CannotPlaceFabricSheetWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.CannotPlaceFabricSheetWarn`

#### Summary

Can't find a host for Fabric Sheet.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.CannotPlaceFabricSheet`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.CannotPlaceFabricSheet`

#### Summary

Can't find a host for Fabric Sheet.

### `P:Autodesk.Revit.DB.BuiltInFailures.FabricFailures.CannotPlaceFabricAreaWarn`

Member kind: property
Symbol: `Autodesk.Revit.DB.BuiltInFailures.FabricFailures.CannotPlaceFabricAreaWarn`

#### Summary

Can't find a host for Fabric Area.
